﻿/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Rest
{
    public static class HttpToEntryExtensions
    {
        private const string USERDATA_BODY = "$body";
        private const string EXTENSION_RESPONSE_HEADER = "http://hl7.org/fhir/StructureDefinition/http-response-header";

        internal static Bundle.EntryComponent ToBundleEntry(this HttpResponseMessage response, byte[] body, ParserSettings parserSettings, bool throwOnFormatException)
        {
            var result = new Bundle.EntryComponent();

            result.Response = new Bundle.ResponseComponent();
            result.Response.Status = ((int)response.StatusCode).ToString();
            result.Response.SetHeaders(response.Headers);

            var contentType = response.Content.Headers.ContentType;

            Encoding charEncoding = Encoding.UTF8;
            if (response.Content.Headers.ContentType?.CharSet != null)
            {
                try
                {
                    charEncoding = Encoding.GetEncoding(response.Content.Headers.ContentType.CharSet);
                }
                catch (ArgumentException)
                { }
            }

            result.Response.Location = response.Headers.Location?.AbsoluteUri ?? response.Content.Headers.ContentLocation?.AbsoluteUri;

            result.Response.LastModified = response.Content.Headers.LastModified;
            result.Response.Etag = response.Headers.ETag?.Tag.Trim('\"');

            if (body != null && body.Length != 0)
            {
                result.Response.RemoveAnnotations<Body>();
                result.Response.AddAnnotation(new Body { Data = body });

                if (IsBinaryResponse(result.Response.Location, contentType.MediaType.ToString()))
                {
                    result.Resource = new Binary { Content = body, ContentType = contentType.ToString() };
                    if (result.Response.Location != null)
                    {
                        var ri = new ResourceIdentity(result.Response.Location);
                        result.Resource.Id = ri.Id;
                        result.Resource.Meta = new Meta { VersionId = ri.VersionId };
                        result.Resource.ResourceBase = ri.BaseUri;
                    }
                }
                else
                {
                    var bodyText = DecodeBody(body, charEncoding);
                    var resource = parseResource(bodyText, contentType.MediaType.ToString(), parserSettings, throwOnFormatException);
                    result.Resource = resource;

                    if (result.Response.Location != null)
                        result.Resource.ResourceBase = new ResourceIdentity(result.Response.Location).BaseUri;
                }
            }

            return result;
        }


        private static Resource parseResource(string bodyText, string contentType, ParserSettings settings, bool throwOnFormatException)
        {
            Resource result = null;

            var fhirType = ContentType.GetResourceFormatFromContentType(contentType);

            if (fhirType == ResourceFormat.Unknown)
                throw new UnsupportedBodyTypeException(
                    "Endpoint returned a body with contentType '{0}', while a valid FHIR xml/json body type was expected. Is this a FHIR endpoint?"
                        .FormatWith(contentType), contentType, bodyText);

            if (!SerializationUtil.ProbeIsJson(bodyText) && !SerializationUtil.ProbeIsXml(bodyText))
                throw new UnsupportedBodyTypeException(
                        "Endpoint said it returned '{0}', but the body is not recognized as either xml or json.".FormatWith(contentType), contentType, bodyText);

            try
            {
                if (fhirType == ResourceFormat.Json)
                    result = new FhirJsonParser(settings).Parse<Resource>(bodyText);
                else
                    result = new FhirXmlParser(settings).Parse<Resource>(bodyText);
            }
            catch (FormatException fe)
            {
                if (throwOnFormatException) throw fe;
                return null;
            }

            return result;
        }


        internal static bool IsBinaryResponse(string responseUri, string contentType)
        {
            if (!string.IsNullOrEmpty(contentType)
                && (ContentType.XML_CONTENT_HEADERS.Contains(contentType.ToLower())
                    || ContentType.JSON_CONTENT_HEADERS.Contains(contentType.ToLower())
                )
                )
                return false;

            if (ResourceIdentity.IsRestResourceIdentity(responseUri))
            {
                var id = new ResourceIdentity(responseUri);

                if (id.ResourceType != ResourceType.Binary.ToString()) return false;

                if (id.Id != null && Id.IsValidValue(id.Id)) return true;
                if (id.VersionId != null && Id.IsValidValue(id.VersionId)) return true;
            }

            return false;
        }


        internal static string DecodeBody(byte[] body, Encoding enc)
        {
            if (body == null) return null;
            if (enc == null) enc = Encoding.UTF8;

            // [WMR 20160421] Explicit disposal
            // return (new StreamReader(new MemoryStream(body), enc, true)).ReadToEnd();
            using (var stream = new MemoryStream(body))
            using (var reader = new StreamReader(stream, enc, true))
            {
                return reader.ReadToEnd();
            }
        }



        public static string GetBodyAsText(this Bundle.ResponseComponent interaction)
        {
            var body = interaction.GetBody();

            if (body != null)
                return DecodeBody(body, Encoding.UTF8);
            else
                return null;
        }


        private class Body
        {
            public byte[] Data;
        }


        public static byte[] GetBody(this Bundle.ResponseComponent interaction)
        {
            var body = interaction.Annotation<Body>();
            return body != null ? body.Data : null;
        }

        internal static void SetBody(this Bundle.ResponseComponent interaction, byte[] data)
        {
            interaction.RemoveAnnotations<Body>();
            interaction.AddAnnotation(new Body { Data = data });
        }

        internal static void SetHeaders(this Bundle.ResponseComponent interaction, HttpResponseHeaders headers)
        {
            foreach (var header in headers)
            {
                interaction.AddExtension(EXTENSION_RESPONSE_HEADER, new FhirString(header.Key + ":" + header.Value));
            }
        }
    }


    public class UnsupportedBodyTypeException : Exception
    {
        public string BodyType { get; set; }

        public string Body { get; set; }
        public UnsupportedBodyTypeException(string message, string mimeType, string body) : base(message)
        {
            BodyType = mimeType;
            Body = body;
        }
    }
}
