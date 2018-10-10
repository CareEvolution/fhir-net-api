/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */


using System;
using System.Collections;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Serialization
{
    internal class PocoBuilder : IExceptionSource
    {
        public PocoBuilder(IModelInfo modelInfo, PocoBuilderSettings settings = null)
        {
            _modelInfo = modelInfo;
            _settings = settings?.Clone() ?? new PocoBuilderSettings();
        }

        private readonly IModelInfo _modelInfo;
        private readonly PocoBuilderSettings _settings;
        private readonly DefaultModelFactory _defaultModelFactory = new DefaultModelFactory();

        public ExceptionNotificationHandler ExceptionHandler { get; set; }

        public Base BuildFrom(ISourceNode source, Type dataType = null)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));

            if (dataType != null)
                return buildInternal(source, dataType);
            else
            {
                var rti = source.GetResourceTypeIndicator();
                if (rti == null)
                {
                    ExceptionHandler.NotifyOrThrow(this,
                     ExceptionNotification.Error(new StructuralTypeException($"No type indication on source to build POCO's for.")));
                    return null;
                }
                else
                    return BuildFrom(source, rti);
            }
        }

        public Base BuildFrom(ISourceNode source, string dataType)
        {
            if (dataType == null) throw Error.ArgumentNull(nameof(dataType));

            var typeFound = _modelInfo.GetTypeForFhirType(dataType);

            if (typeFound == null)
            {
                ExceptionNotification.Error(
                    new StructuralTypeException($"There is no .NET type representing the FHIR type '{dataType}'."));

                return null;
            }
            else
                return buildInternal(source, typeFound);
        }

        public Base BuildFrom(ITypedElement source)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));

            return BuildFrom(source.ToSourceNode(), source.InstanceType);
        }

        private Base buildInternal(ISourceNode source, Type typeToBuild)
        {
            if (source is IExceptionSource)
            {
                using (source.Catch((o, a) => ExceptionHandler.NotifyOrThrow(o, a)))
                {
                    return Build();
                }
            }

            return Build();

            Base Build()
            {
                return typeToBuild.CanBeTreatedAsType(typeof(ResourceBase))
                    ? DeserializeResource(source)
                    : DeserializeComplexType(typeToBuild, source);
            }
        }

        private ResourceBase DeserializeResource(ISourceNode node)
        {
            // If there's no a priori knowledge of the type of Resource we will encounter,
            // we'll have to determine from the data itself. 
            var resourceTypeName = node.GetResourceTypeIndicator();
            var mapping = _modelInfo.FindClassMappingForResource(resourceTypeName);

            if (mapping == null)
                throw Error.Format("Asked to deserialize unknown resource '" + resourceTypeName + "'", node.Location);

            // Delegate the actual work to the ComplexTypeReader, since
            // the serialization of Resources and ComplexTypes are virtually the same
            return (ResourceBase)DeserializeComplexType(mapping, node);
        }

        private Base DeserializeComplexType(Type elementType, ISourceNode node)
        {
            var mapping = _modelInfo.FindClassMappingByType(elementType);

            if (mapping == null)
                throw Error.Format("Asked to deserialize unknown type '" + elementType.Name + "'", node.Location);

            return DeserializeComplexType(mapping, node);
        }

        private Base DeserializeComplexType(ClassMapping mapping, ISourceNode node, Base existing = null)
        {
            if (mapping == null) throw Error.ArgumentNull(nameof(mapping));

            if (existing == null)
            {
                existing = (Base)_defaultModelFactory.Create(mapping.NativeType);
            }
            else
            {
                if (mapping.NativeType != existing.GetType())
                    throw Error.Argument(nameof(existing), "Existing instance is of type {0}, but data indicates resource is a {1}".FormatWith(existing.GetType().Name, mapping.NativeType.Name));
            }

            if (node.Text != null)
            {
                ReadComplexType(mapping, SourceNode.Valued("value", node.Text), existing);
            }
            foreach (var child in node.Children())
            {
                ReadComplexType(mapping, child, existing);
            }

            return existing;
        }

        private void ReadComplexType(ClassMapping mapping, ISourceNode node, Base existing)
        {
            var memberName = node.Name;  // tuple: first is name of member

            // Find a property on the instance that matches the element found in the data
            // NB: This function knows how to handle suffixed names (e.g. xxxxBoolean) (for choice types).
            var mappedProperty = mapping.FindMappedElementByName(memberName);

            if (mappedProperty != null)
            {
                object value = null;

                // For primitive members we can save time by not calling the getter
                if (!mappedProperty.IsPrimitive)
                {
                    value = mappedProperty.GetValue(existing);

                    if (value != null && !mappedProperty.IsCollection)
                        throw Error.Format($"Element '{mappedProperty.Name}' must not repeat", node.Location);
                }

                value = DeserializeProperty(mappedProperty, node, memberName, arrayMode: false, value);

                if (mappedProperty.RepresentsValueElement && mappedProperty.ImplementingType.IsEnum() && value is String)
                {
                    if (!_settings.AllowUnrecognizedEnums)
                    {
                        if (EnumUtility.ParseLiteral((string)value, mappedProperty.ImplementingType) == null)
                            throw Error.Format("Literal '{0}' is not a valid value for enumeration '{1}'".FormatWith(value, mappedProperty.ImplementingType.Name), node.Location);
                    }
                    ((IPrimitive)existing).ObjectValue = value;
                }
                else
                {
                    mappedProperty.SetValue(existing, value);
                }
            }
            else
            {
                if (_settings.IgnoreUnknownMembers == false)
                    throw Error.Format("Encountered unknown member '{0}' while de-serializing".FormatWith(memberName), node.Location);
                Message.Info("Skipping unknown member " + memberName);
            }


        }

        private object DeserializeProperty(PropertyMapping prop, ISourceNode node, string memberName, bool arrayMode, object existing = null)
        {
            if (prop == null) throw Error.ArgumentNull(nameof(prop));

            // ArrayMode avoid the dispatcher making nested calls into the RepeatingElementReader again
            // when reading array elements. FHIR does not support nested arrays, and this avoids an endlessly
            // nesting series of dispatcher calls
            if (!arrayMode && prop.IsCollection)
            {
                if (existing != null && !(existing is IList)) throw Error.Argument(nameof(existing), "Can only read repeating elements into a type implementing IList");
                return DeserializeRepeatingProperty(prop, node, memberName, (IList)existing);
            }

            // If this is a primitive type, no classmappings and reflection is involved,
            // just parse the primitive from the input
            // NB: no choices for primitives!
            if (prop.IsPrimitive)
            {
                return DeserializePrimitive(prop.ImplementingType, node);
            }

            // A Choice property that contains a choice of any resource
            // (as used in Resource.contained)
            if (prop.Choice == ChoiceType.ResourceChoice)
            {
                return DeserializeResource(node);
            }

            ClassMapping mapping;

            // Handle other Choices having any datatype or a list of datatypes
            if (prop.Choice == ChoiceType.DatatypeChoice)
            {
                // For Choice properties, determine the actual type of the element using
                // the suffix of the membername (i.e. deceasedBoolean, deceasedDate)
                // This function implements type substitution.
                mapping = DetermineElementPropertyType();
            }
            // Else use the actual return type of the property
            else
            {
                mapping = _modelInfo.FindClassMappingByType(prop.ImplementingType);
            }

            if (existing != null && !(existing is ResourceBase) && !(existing is ElementBase)) throw Error.Argument(nameof(existing), "Can only read complex elements into types that are Element or Resource");
            return DeserializeComplexType(mapping, node, (Base)existing);

            ClassMapping DetermineElementPropertyType()
            {
                var typeName = prop.GetChoiceSuffixFromName(memberName);

                if (String.IsNullOrEmpty(typeName))
                    throw Error.Format("Encountered polymorph member {0}, but is does not specify the type used".FormatWith(memberName), node.Location);

                // Exception: valueResource actually means the element is of type ResourceReference
                if (typeName == "Resource") typeName = "Reference";

                // NB: this will return the latest type registered for that name, so supports type mapping/overriding
                // Maybe we should Import the types present on the choice, to make sure they are available. For now
                // assume the caller has Imported all types in the right (overriding) order.
                var result = _modelInfo.FindClassMappingForFhirDataType(typeName);

                if (result == null)
                    throw Error.Format("Encountered polymorph member {0}, which uses unknown datatype {1}".FormatWith(memberName, typeName), node.Location);

                return result;
            }
        }

        private object DeserializePrimitive(Type nativeType, ISourceNode node)
        {
            if (nativeType == null) throw Error.ArgumentNull(nameof(nativeType));

            object primitiveValue = node.Text;

            if (nativeType.IsEnum() && primitiveValue is string)
            {
                // Don't try to parse enums in the parser -> it's been moved to the Code<T> type
                return primitiveValue;
            }

            try
            {
                return PrimitiveTypeConverter.ConvertTo(primitiveValue, nativeType);
            }
            catch (NotSupportedException exc)
            {
                // thrown when an unsupported conversion was required
                throw Error.Format(exc.Message, node.Location);
            }
        }

        private IList DeserializeRepeatingProperty(PropertyMapping prop, ISourceNode node, string memberName, IList existing = null)
        {
            if (prop == null) throw Error.ArgumentNull(nameof(prop));

            IList result = existing;

            if (result == null) result = ReflectionHelper.CreateGenericList(prop.ImplementingType);

            result.Add(DeserializeProperty(prop, node, memberName, arrayMode: true));

            return result;
        }
    }
}

