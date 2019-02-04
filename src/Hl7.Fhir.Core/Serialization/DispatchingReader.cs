/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System.Collections;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Serialization
{
    internal class DispatchingReader
    {
        private readonly ITypedElement _current;
        private readonly IModelInfo _modelInfo;
        private readonly bool _arrayMode;

        public ParserSettings Settings { get; private set; }

        internal DispatchingReader(IModelInfo modelInfo, ITypedElement data, ParserSettings settings, bool arrayMode)
        {
            _current = data;
            _modelInfo = modelInfo;
            _arrayMode = arrayMode;

            Settings = settings;
        }

        public object Deserialize(PropertyMapping prop, string memberName, object existing = null)
        {
            if (prop == null) throw Error.ArgumentNull(nameof(prop));

            // ArrayMode avoid the dispatcher making nested calls into the RepeatingElementReader again
            // when reading array elements. FHIR does not support nested arrays, and this avoids an endlessly
            // nesting series of dispatcher calls
            if (!_arrayMode && prop.IsCollection)
            {
                if (existing != null && !(existing is IList)) throw Error.Argument(nameof(existing), "Can only read repeating elements into a type implementing IList");
                var reader = new RepeatingElementReader(_modelInfo, _current, Settings);
                return reader.Deserialize(prop, memberName, (IList)existing);
            }

            // If this is a primitive type, no classmappings and reflection is involved,
            // just parse the primitive from the input
            // NB: no choices for primitives!
            if (prop.IsPrimitive)
            {
                var reader = new PrimitiveValueReader(_current);
                return reader.Deserialize(prop.ImplementingType);
            }

            // A Choice property that contains a choice of any resource
            // (as used in Resource.contained)
            if (prop.Choice == ChoiceType.ResourceChoice)
            {
                var reader = new ResourceReader(_modelInfo, _current, Settings);
                return reader.Deserialize(null);
            }

            if (_current.InstanceType is null)
                throw Error.Format("Underlying data source was not able to provide the actual instance type of the resource.");

            ClassMapping mapping = prop.Choice == ChoiceType.DatatypeChoice
                ? getMappingForType(prop, memberName, _current.InstanceType)
                : _modelInfo.FindClassMappingByType(prop.ImplementingType);

            // Handle other Choices having any datatype or a list of datatypes

            if (existing != null && !(existing is IResource) && !(existing is ElementBase)) throw Error.Argument(nameof(existing), "Can only read complex elements into types that are Element or Resource");
            var cplxReader = new ComplexTypeReader(_modelInfo, _current, Settings);
            return cplxReader.Deserialize(mapping, (Base)existing);
        }

        private ClassMapping getMappingForType(PropertyMapping mappedProperty, string memberName, string typeName)
        {
            ClassMapping result = null;

            // NB: this will return the latest type registered for that name, so supports type mapping/overriding
            // Maybe we should Import the types present on the choice, to make sure they are available. For now
            // assume the caller has Imported all types in the right (overriding) order.
            result = _modelInfo.FindClassMappingForFhirDataType(typeName);

            if (result == null)
                throw Error.Format("Encountered polymorph member {0}, which uses unknown datatype {1}".FormatWith(memberName, typeName), _current.Location);

            return result;
        }

    }
}
