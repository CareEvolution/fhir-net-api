/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */

using System;
using System.Text.Json;
using Hl7.Fhir.Model;

namespace Hl7.Fhir.Serialization
{
    public class FhirJsonFastParser : BaseFhirParser
    {
        public FhirJsonFastParser(Model.Version version) : base(version)
        { }

        public FhirJsonFastParser(ParserSettings settings) : base(settings)
        { }

        public T Parse<T>(string json) where T : Base => (T)Parse(json, typeof(T));

        public T Parse<T>(ref Utf8JsonReader reader) where T : Base => (T)Parse(ref reader, typeof(T));
        
        public Base Parse(string json, Type dataType = null)
        {
            try
            {
                return (Base)JsonSerializer.Deserialize(json, dataType ?? typeof(Resource), new JsonSerializerOptions().ForFhir(Settings));
            }
            catch (JsonException jsonException)
            {
                throw jsonException.ToFormatException();
            }
        }

        public Base Parse(ref Utf8JsonReader reader, Type dataType = null)
        {
            try
            {
                return (Base)JsonSerializer.Deserialize(ref reader, dataType ?? typeof(Resource), new JsonSerializerOptions().ForFhir(Settings));
            }
            catch (JsonException jsonException)
            {
                throw jsonException.ToFormatException();
            }
        }
    }
}
