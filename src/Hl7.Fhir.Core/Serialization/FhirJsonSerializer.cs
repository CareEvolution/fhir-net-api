/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Hl7.Fhir.Specification;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Hl7.Fhir.Serialization
{
    public class FhirJsonSerializer : BaseFhirSerializer
    {
        public FhirJsonSerializer(IModelInfo modelInfo, SerializerSettings settings = null) : base(modelInfo, settings)
        {
        }

        private FhirJsonSerializationSettings buildFhirJsonWriterSettings() =>
            new FhirJsonSerializationSettings { Pretty = Settings.Pretty };

        // public string SerializeToString(Base instance) =>
        //     instance.ToTypedElement(_modelInfo.StructureDefinitionProvider).ToJson(buildFhirJsonWriterSettings());

        public string SerializeToString(Base instance, SummaryType summary = SummaryType.False, string[] elements = null) =>
            _modelInfo
                .AddSubsettedTag(instance, summary, elements)
                .ToTypedElement(_modelInfo.StructureDefinitionProvider)
                .ScopeToSummary(summary, elements)
                .ToJson(buildFhirJsonWriterSettings());

        // public byte[] SerializeToBytes(Base instance) =>
        //     instance
        //         .ToTypedElement(_modelInfo.StructureDefinitionProvider)
        //         .ToJsonBytes(buildFhirJsonWriterSettings());

        public byte[] SerializeToBytes(Base instance, SummaryType summary = SummaryType.False, string[] elements = null) =>
            _modelInfo
                .AddSubsettedTag(instance, summary, elements)
                .ToTypedElement(_modelInfo.StructureDefinitionProvider)
                .ScopeToSummary(summary, elements)
                .ToJsonBytes(buildFhirJsonWriterSettings());

        public JObject SerializeToDocument(Base instance) =>
            instance.ToTypedElement(_modelInfo.StructureDefinitionProvider).ToJObject(buildFhirJsonWriterSettings());

        public void Serialize(Base instance, JsonWriter writer) =>
            instance.ToTypedElement(_modelInfo.StructureDefinitionProvider).WriteTo(writer, buildFhirJsonWriterSettings());
    }
}
