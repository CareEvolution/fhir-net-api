/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Serialization
{
    internal class ResourceReader
    {
        private ITypedElement _reader;
        private IModelInfo _modelInfo;

        public ParserSettings Settings { get; private set; }

        internal ResourceReader(IModelInfo modelInfo, ITypedElement reader, ParserSettings settings)
        {
            _reader = reader;
            _modelInfo = modelInfo;
            Settings = settings;
        }

        public Base Deserialize(Base existing = null)
        {
            if (_reader.InstanceType is null)
                throw Error.Format("Underlying data source was not able to provide the actual instance type of the resource.");

            var mapping = _modelInfo.FindClassMappingForResource(_reader.InstanceType);

            if (mapping == null)
                throw Error.Format("Asked to deserialize unknown resource '" + _reader.InstanceType + "'", _reader.Location);

            // Delegate the actual work to the ComplexTypeReader, since
            // the serialization of Resources and ComplexTypes are virtually the same
            var cplxReader = new ComplexTypeReader(_modelInfo, _reader, Settings);
            return (Base)cplxReader.Deserialize(mapping, existing);
        }
    }
}
