using Hl7.Fhir.Model.R4;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Serialization.R4;
using System.Net;
using System.Threading.Tasks;

namespace Hl7.Fhir.Rest.R4
{
    public interface IRequester
    {
        Bundle.EntryComponent Execute(Bundle.EntryComponent interaction);
        Task<Bundle.EntryComponent> ExecuteAsync(Bundle.EntryComponent interaction);

        Bundle.EntryComponent LastResult { get; }
        bool UseFormatParameter { get; set; }
        ResourceFormat PreferredFormat { get; set; }
        int Timeout { get; set; }           // In milliseconds

        Prefer? PreferredReturn { get; set; }
        SearchParameterHandling? PreferredParameterHandling { get; set; }

        /// <summary>
        /// This will do 2 things:
        /// 1. Add the header Accept-Encoding: gzip, deflate
        /// 2. decompress any responses that have Content-Encoding: gzip (or deflate)
        /// </summary>
        bool PreferCompressedResponses { get; set; }
        /// <summary>
        /// Compress any Request bodies 
        /// (warning, if a server does not handle compressed requests you will get a 415 response)
        /// </summary>
        bool CompressRequestBody { get; set; }

        ParserSettings ParserSettings { get; set; }
        HttpStatusCode? LastStatusCode { get; }
    }
}
