/* 
 * Copyright (c) 2014, Furore (info@furore.com) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */


using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.R4;

namespace Hl7.Fhir.Rest.R4
{
    public partial class FhirClient : BaseFhirClient
    {
        /// <summary>
        /// Creates a new client using a default endpoint
        /// If the endpoint does not end with a slash (/), it will be added.
        /// </summary>
        /// <param name="endpoint">
        /// The URL of the server to connect to.<br/>
        /// If the trailing '/' is not present, then it will be appended automatically
        /// </param>
        /// <param name="verifyFhirVersion">
        /// <param name="messageHandler"></param>
        /// If parameter is set to true the first time a request is made to the server a 
        /// conformance check will be made to check that the FHIR versions are compatible.
        /// When they are not compatible, a FhirException will be thrown.
        /// </param>
        public FhirClient(Uri endpoint, bool verifyFhirVersion = false, HttpMessageHandler messageHandler = null)
        {
            Endpoint = GetValidatedEndpoint(endpoint);
            VerifyFhirVersion = verifyFhirVersion;

            // If user does not supply message handler, add decompression strategy in default handler.
            var handler = messageHandler ?? new HttpClientHandler()
            {
                AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
            };

            var requester = new RequesterR4(Endpoint, handler);
            Requester = requester;

            // Expose default request headers to user.
            RequestHeaders = requester.Client.DefaultRequestHeaders;
        }

        /// <summary>
        /// Creates a new client using a default endpoint
        /// If the endpoint does not end with a slash (/), it will be added.
        /// </summary>
        /// <param name="endpoint">
        /// The URL of the server to connect to.<br/>
        /// If the trailing '/' is not present, then it will be appended automatically
        /// </param>
        /// <param name="verifyFhirVersion">
        /// <param name="httpClient"></param>
        /// If parameter is set to true the first time a request is made to the server a 
        /// conformance check will be made to check that the FHIR versions are compatible.
        /// When they are not compatible, a FhirException will be thrown.
        /// </param>
        public FhirClient(Uri endpoint, bool verifyFhirVersion, HttpClient httpClient)
        {
            Endpoint = GetValidatedEndpoint(endpoint);
            VerifyFhirVersion = verifyFhirVersion;

            var requester = new RequesterR4(Endpoint, httpClient);
            Requester = requester;

            // Expose default request headers to user.
            RequestHeaders = requester.Client.DefaultRequestHeaders;
        }

        /// <summary>
        /// Creates a new client using a default endpoint
        /// If the endpoint does not end with a slash (/), it will be added.
        /// </summary>
        /// <param name="endpoint">
        /// The URL of the server to connect to.<br/>
        /// If the trailing '/' is not present, then it will be appended automatically
        /// </param>
        /// <param name="verifyFhirVersion">
        /// <param name="messageHandler"></param>
        /// If parameter is set to true the first time a request is made to the server a 
        /// conformance check will be made to check that the FHIR versions are compatible.
        /// When they are not compatible, a FhirException will be thrown.
        /// </param>
        public FhirClient(string endpoint, bool verifyFhirVersion = false, HttpMessageHandler messageHandler = null)
            : this(new Uri(endpoint), verifyFhirVersion, messageHandler)
        {
        }

        /// <summary>
        /// Default request headers that can be modified to persist default headers to internal client.
        /// </summary>
        public HttpRequestHeaders RequestHeaders { get; protected set; }

        /// <summary>
        /// Override dispose in order to clean up request headers tied to disposed requester.
        /// </summary>
        /// <param name="disposing"></param>
        protected override void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    this.RequestHeaders = null;
                    base.Dispose(disposing);
                }

                disposedValue = true;
            }
        }

        class RequesterR4 : Requester
        {
            public RequesterR4(Uri baseUrl, HttpMessageHandler messageHandler) : base(baseUrl, messageHandler)
            { }

            public RequesterR4(Uri baseUrl, HttpClient httpClient) : base(baseUrl, httpClient)
            { }

            protected override string Version => ModelInfo.Version;

            protected override IBundleEntry CreateBundleEntry(HttpResponseMessage response, byte[] body, bool throwOnFormatException)
            {
                return HttpToEntryExtensions.ToBundleEntry(response, body, ParserSettings, throwOnFormatException);
            }

            protected override HttpRequestMessage CreateHttpRequestMessage(IBundleEntry entry)
            {
                return EntryToHttpExtensions.ToHttpRequestMessage(entry, BaseUrl, PreferredParameterHandling, PreferredReturn, PreferredFormat, UseFormatParameter, CompressRequestBody);
            }

            protected override ResourceBase CreateOperationOutcomeForException(Exception exception)
            {
                return OperationOutcome.ForException(exception, OperationOutcome.IssueType.Invalid);
            }
        }
    }
}
