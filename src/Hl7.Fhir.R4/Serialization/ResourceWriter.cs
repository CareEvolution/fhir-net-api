/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System.Linq;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Model.R4;
using Hl7.Fhir.Rest.R4;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Serialization.R4
{
    public class ResourceWriter
    {
        private IFhirWriter _writer;
        private ModelInspector _inspector;

        public ParserSettings Settings { get; private set; }

        public ResourceWriter(IFhirWriter writer, ParserSettings settings)
        {
            _writer = writer;
            _inspector = BaseFhirParser.Inspector;
            Settings = settings;
        }

        public void Serialize(Resource instance, SummaryType summary, bool contained = false)
        {
            if (instance == null) throw Error.ArgumentNull(nameof(instance));

            var mapping = _inspector.ImportType(instance.GetType());
            if (mapping == null)
                throw Error.Format($"Asked to serialize unknown resource type '{instance.GetType()}'");

            _writer.WriteStartRootObject(mapping.Name, contained);

            var complexSerializer = new ComplexTypeWriter(_writer, Settings);
            Coding subsettedTag = null;
            bool createdMetaElement = false;
            if (summary != SummaryType.False && instance is Resource && !(instance is Bundle))
            {
                var resource = instance as Resource;

                if (resource.Meta == null)
                {
                    resource.Meta = new Meta();
                    createdMetaElement = true;
                }

                if (!resource.Meta.Tag.Any(t => t.System == "http://hl7.org/fhir/v3/ObservationValue" && t.Code == "SUBSETTED"))
                {
                    subsettedTag = new Coding("http://hl7.org/fhir/v3/ObservationValue", "SUBSETTED");
                    resource.Meta.Tag.Add(subsettedTag);
                }
            }

            complexSerializer.Serialize(mapping, instance, summary);

            Resource r = (instance as Resource);
            if (subsettedTag != null)
                r.Meta.Tag.Remove(subsettedTag);

            if (createdMetaElement)
                r.Meta = null; // remove the meta element again.

            _writer.WriteEndRootObject(contained);
        }
    }
}
