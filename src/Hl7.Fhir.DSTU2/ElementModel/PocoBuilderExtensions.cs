/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/ewoutkramer/fhir-net-api/blob/master/LICENSE
 */


using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.DSTU2;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;

namespace Hl7.Fhir.ElementModel.DSTU2
{
    public static class PocoBuilderExtensions
    {
        public static Quantity ParseQuantity(this ITypedElement instance)
        {
            var newQuantity = new Quantity
            {
                Value = instance.Children("value").SingleOrDefault()?.Value as decimal?,
                Unit = instance.Children("unit").GetString(),
                System = instance.Children("system").GetString(),
                Code = instance.Children("code").GetString()
            };

            var comp = instance.Children("comparator").GetString();
            if (comp != null)
                newQuantity.ComparatorElement = new Code<Quantity.QuantityComparator> { ObjectValue = comp };

            return newQuantity;
        }

        /// <summary>
        /// Parses a bindeable type (code, Coding, CodeableConcept, Quantity, string, uri) into a FHIR coded datatype.
        /// Extensions will be parsed from the 'value' of the (simple) extension.
        /// </summary>
        /// <param name="instance"></param>
        /// <returns>An Element of a coded type (code, Coding or CodeableConcept) dependin on the instance type,
        /// or null if no bindable instance data was found</returns>
        /// <remarks>The instance type is mapped to a codable type as follows:
        ///   'code' => code
        ///   'Coding' => Coding
        ///   'CodeableConcept' => CodeableConcept
        ///   'Quantity' => Coding
        ///   'Extension' => depends on value[x]
        ///   'string' => code
        ///   'uri' => code
        /// </remarks>
        public static Element ParseBindable(this ITypedElement instance)
        {
            var instanceType = ModelInfo.FhirTypeNameToFhirType(instance.InstanceType);

            switch (instanceType)
            {
                case FHIRDefinedType.Code:
                    return instance.ParsePrimitive<Code>();
                case FHIRDefinedType.Coding:
                    return instance.ParseCoding();
                case FHIRDefinedType.CodeableConcept:
                    return instance.ParseCodeableConcept();
                case FHIRDefinedType.Quantity:
                    return parseQuantity(instance);
                case FHIRDefinedType.String:
                    return new Code(instance.ParsePrimitive<FhirString>()?.Value);
                case FHIRDefinedType.Uri:
                    return new Code(instance.ParsePrimitive<FhirUri>()?.Value);
                case FHIRDefinedType.Extension:
                    return parseExtension(instance);
                case null:
                //HACK: fall through - IElementNav did not provide a type
                //should not happen, and I have no intention to handle it.
                default:
                    // Not bindable
                    return null;
            }

            Coding parseQuantity(ITypedElement nav)
            {
                var newCoding = new Coding();
                var q = instance.ParseQuantity();
                newCoding.Code = q.Unit;
                newCoding.System = q.System ?? "http://unitsofmeasure.org";
                return newCoding;
            }

            Element parseExtension(ITypedElement nav)
            {
                // HACK: For now, assume this is a typed navigator, so we have "value",
                // not the unparsed "valueCode" etc AND we have Type (in ParseBindable())
                var valueChild = instance.Children("value").FirstOrDefault();
                return valueChild?.ParseBindable();
            }
        }

        public static T ParsePrimitive<T>(this ITypedElement instance) where T : Primitive, new()
                    => new T() { ObjectValue = instance.Value };

        public static Coding ParseCoding(this ITypedElement instance)
        {
            return new Coding()
            {
                System = instance.Children("system").GetString(),
                Version = instance.Children("version").GetString(),
                Code = instance.Children("code").GetString(),
                Display = instance.Children("display").GetString(),
                UserSelected = instance.Children("userSelected").SingleOrDefault()?.Value as bool?
            };
        }

        public static ResourceReference ParseResourceReference(this ITypedElement instance)
        {
            return new ResourceReference()
            {
                Reference = instance.Children("reference").GetString(),
                Display = instance.Children("display").GetString()
            };
        }

        public static CodeableConcept ParseCodeableConcept(this ITypedElement instance)
        {
            return new CodeableConcept()
            {
                Coding =
                    instance.Children("coding").Select(codingNav => codingNav.ParseCoding()).ToList(),
                Text = instance.Children("text").GetString()
            };
        }

        public static string GetString(this IEnumerable<ITypedElement> instance)
        {
            return instance.SingleOrDefault()?.Value as string;
        }
    }
}
