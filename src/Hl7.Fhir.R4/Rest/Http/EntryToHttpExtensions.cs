﻿/*
 * Copyright (c) 2014, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest.R4;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Serialization.R4;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Rest
{
    internal static class EntryToHttpExtensions
    {
        public static HttpRequestMessage ToHttpRequestMessage(this IBundleEntry entry, Uri baseUrl,
            SearchParameterHandling? handlingPreference, Prefer? returnPreference, ResourceFormat format, bool useFormatParameter, bool CompressRequestBody)
        {
            System.Diagnostics.Debug.WriteLine("{0}: {1}", entry.Request.HttpMethod.ToString(), entry.Request.Url);

            var interaction = entry.Request;

            if (entry.Resource != null && !(interaction.HttpMethod == HttpMethod.Post || interaction.HttpMethod == HttpMethod.Put))
                throw Error.InvalidOperation("Cannot have a body on an Http " + interaction.HttpMethod.ToString());

            var uri = new Uri(interaction.Url, UriKind.RelativeOrAbsolute);
            if (!uri.IsAbsoluteUri)
            {
                uri = HttpUtil.MakeAbsoluteToBase(uri, baseUrl);
            }
            var location = new RestUrl(uri);

            if (useFormatParameter)
                location.AddParam(HttpUtil.RESTPARAM_FORMAT, ContentType.BuildFormatParam(format));

            var request = new HttpRequestMessage(interaction.HttpMethod, location.Uri);

            if (!useFormatParameter)
                request.Headers.Accept.Add(MediaTypeWithQualityHeaderValue.Parse(ContentType.BuildContentType(format, forBundle: false)));

            if (interaction.IfMatch != null) request.Headers.Add("If-Match", interaction.IfMatch);
            if (interaction.IfNoneMatch != null) request.Headers.Add("If-None-Match", interaction.IfNoneMatch);
            if (interaction.IfModifiedSince != null) request.Headers.IfModifiedSince = interaction.IfModifiedSince.Value.UtcDateTime;
            if (interaction.IfNoneExist != null) request.Headers.Add("If-None-Exist", interaction.IfNoneExist);

            var interactionType = entry.Annotation<TransactionBuilder.InteractionType>();

            if (interactionType == TransactionBuilder.InteractionType.Create && returnPreference != null)
                request.Headers.Add("Prefer", "return=" + PrimitiveTypeConverter.ConvertTo<string>(returnPreference));
            else if (interactionType == TransactionBuilder.InteractionType.Search && handlingPreference != null)
                request.Headers.Add("Prefer", "handling=" + PrimitiveTypeConverter.ConvertTo<string>(handlingPreference));

            if (entry.Resource != null)
            {
                bool searchUsingPost =
                   interaction.HttpMethod == HttpMethod.Post
                   && (entry.HasAnnotation<TransactionBuilder.InteractionType>()
                   && entry.Annotation<TransactionBuilder.InteractionType>() == TransactionBuilder.InteractionType.Search)
                   && entry.Resource is IParameters;
                setBodyAndContentType(request, entry.Resource, format, CompressRequestBody, searchUsingPost);
            }
                

            return request;
        }

        ///// <summary>
        ///// Converts bundle http verb to corresponding <see cref="HttpMethod"/>.
        ///// </summary>
        ///// <param name="verb"><see cref="Bundle.HTTPVerb"/> specified by input bundle.</param>
        ///// <returns><see cref="HttpMethod"/> corresponding to verb specified in input bundle.</returns>
        //private static HttpMethod getMethod(Bundle.HTTPVerb? verb)
        //{
        //    switch(verb)
        //    {
        //        case Bundle.HTTPVerb.GET:
        //            return HttpMethod.Get;
        //        case Bundle.HTTPVerb.POST:
        //            return HttpMethod.Post;
        //        case Bundle.HTTPVerb.PUT:
        //            return HttpMethod.Put;
        //        case Bundle.HTTPVerb.DELETE:
        //            return HttpMethod.Delete;
        //    }
        //    throw new HttpRequestException($"Valid HttpVerb could not be found for verb type: [{verb}]");
        //}

        private static void setBodyAndContentType(HttpRequestMessage request, ResourceBase data, ResourceFormat format, bool CompressRequestBody, bool searchUsingPost)
        {
            if (data == null) throw Error.ArgumentNull(nameof(data));

            byte[] body;
            string contentType;

            if (data is IBinary bin)
            {
                body = bin.Content;
                // This is done by the caller after the OnBeforeRequest is called so that other properties
                // can be set before the content is committed
                // request.WriteBody(CompressRequestBody, bin.Content);
                contentType = bin.ContentType;
            }
            else if (searchUsingPost)
            {
                IDictionary<string, string> bodyParameters = new Dictionary<string, string>();
                foreach (var parameter in ((IParameters)data).Parameters)
                {
                    bodyParameters.Add(parameter.Name, parameter.Value.ToString());
                }
                if (bodyParameters.Count > 0)
                {
                    FormUrlEncodedContent content = new FormUrlEncodedContent(bodyParameters);
                    body = content.ReadAsByteArrayAsync().GetAwaiter().GetResult();
                }
                else
                {
                    body = null;
                }

                contentType = "application/x-www-form-urlencoded";
            }
            else
            {
                body = format == ResourceFormat.Xml ?
                    new FhirXmlSerializer().SerializeToBytes(data, summary: SummaryType.False) :
                    new FhirJsonSerializer().SerializeToBytes(data, summary: SummaryType.False);

                // This is done by the caller after the OnBeforeRequest is called so that other properties
                // can be set before the content is committed
                // request.WriteBody(CompressRequestBody, body);
                contentType = ContentType.BuildContentType(format, forBundle: false);
            }

            request.Content = new ByteArrayContent(body);

            request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse(contentType);
        }


    }
}
