using Hl7.Fhir.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hl7.Fhir.Serialization
{
    public interface IFhirFastParser
    {
        Task<Model.Resource> ParseAsync(Stream stream, CancellationToken cancel);
    }

    public class FhirJsonFastParser : IFhirFastParser
    {
        private readonly ParserSource _source;
        private readonly Model.Version _version;

        public FhirJsonFastParser(Model.Version version)
        {
            _version = version;
            _source = new JsonParserSource(version);
        }

        public async Task<Resource> ParseAsync(Stream stream, CancellationToken cancel)
        {
            using (var reader = new StreamReader(stream))
            using (var jsonReader = new JsonTextReader(reader))
            {
                string currentPropertyName = null;

                while (await jsonReader.ReadAsync(cancel))
                {
                    switch (jsonReader.TokenType)
                    {
                        case JsonToken.None:
                            break;
                        case JsonToken.StartObject:
                            _source.StartElement(currentPropertyName);
                            break;
                        case JsonToken.StartArray:
                            _source.StartList(currentPropertyName);
                            break;
                        case JsonToken.StartConstructor:
                            throw new NotSupportedException();
                        case JsonToken.PropertyName:
                            currentPropertyName = jsonReader.Value as string;
                            break;
                        case JsonToken.Comment:
                            break;
                        case JsonToken.Raw:
                            throw new NotSupportedException();
                        case JsonToken.String:
                            if (currentPropertyName == "resourceType")
                            {
                                _source.SetResourceType((string)jsonReader.Value);
                            }
                            else
                            {
                                _source.Attribute(currentPropertyName, jsonReader.Value);
                            }
                            currentPropertyName = null;
                            break;
                        case JsonToken.Integer:
                        case JsonToken.Float:
                        case JsonToken.Date:
                        case JsonToken.Boolean:
                            _source.Attribute(currentPropertyName, jsonReader.Value);
                            currentPropertyName = null;
                            break;
                        case JsonToken.Null:
                            _source.Attribute(currentPropertyName, jsonReader.Value);
                            currentPropertyName = null;
                            break;
                        case JsonToken.Undefined:
                            throw new NotSupportedException();
                        case JsonToken.EndObject:
                            _source.EndElement();
                            break;
                        case JsonToken.EndArray:
                            _source.EndList();
                            break;
                        case JsonToken.EndConstructor:
                            throw new NotSupportedException();
                        case JsonToken.Bytes:
                        default:
                            throw new NotSupportedException();
                    }
                }

                return _source.GetResource();
            }
        }
    }
}
