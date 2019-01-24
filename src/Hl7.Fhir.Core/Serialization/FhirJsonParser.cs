/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;
using Newtonsoft.Json;

namespace Hl7.Fhir.Serialization
{
    public class FhirJsonParser : BaseFhirParser
    {
        public FhirJsonParser(IModelInfo modelInfo, ParserSettings settings = null) : base(modelInfo, settings)
        {
            // True for DSTU2, should be false in STU3
            _jsonNodeSettings = new FhirJsonParsingSettings { AllowJsonComments = modelInfo.Version == "1.0.2" };
        }

        public T Parse<T>(string json) where T : Base => (T)Parse(json, typeof(T));

        public T Parse<T>(JsonReader reader) where T : Base => (T)Parse(reader, typeof(T));

        private readonly FhirJsonParsingSettings _jsonNodeSettings;

        public Base Parse(string json, Type dataType = null)
        {
            var jsonReader =
                FhirJsonNode.Parse(json, dataType != null ? _modelInfo.GetFhirTypeNameForType(dataType) : null, jsonNodeSettings);
            return Parse(jsonReader, dataType);
        }

        public Base Parse(JsonReader reader, Type dataType = null)
        {
            var jsonReader =
                FhirJsonNode.Read(reader, dataType != null ? _modelInfo.GetFhirTypeNameForType(dataType) : null, jsonNodeSettings);
            return Parse(jsonReader, dataType);
        }
    }

}
