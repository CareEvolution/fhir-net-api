/* 
 * Copyright (c) 2016, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Hl7.Fhir.ElementModel
{
    internal class PocoElementNode : ITypedElement, IAnnotated, IExceptionSource, IShortPathGenerator, IFhirValueProvider, IResourceTypeSupplier
    {
        public readonly Model.Version Version;
        public readonly object Current;
        public readonly PocoStructureDefinitionSummaryProvider Provider;
        public readonly IElementDefinitionSummary DefinitionSummary;
        public readonly int ArrayIndex;
        public ExceptionNotificationHandler ExceptionHandler { get; set; }

        internal PocoElementNode(Base parent, PocoStructureDefinitionSummaryProvider provider, string rootName = null)
        {
            Version =  provider.Version;
            Current = parent;
            InstanceType = parent.TypeName;
            var typeInfo = provider.Provide(parent.GetType());
            Definition = Specification.ElementDefinitionSummary.ForRoot(typeInfo, rootName);
            Location = InstanceType;
            ShortPath = InstanceType;
            ArrayIndex = 0;
            Provider = provider;
        }

        private PocoElementNode(object instance, PocoElementNode parent, string location, string shortPath, int arrayIndex,
            IElementDefinitionSummary summary)
        {
            Version = parent.Version;
            Current = instance;
            InstanceType = determineInstanceType(Version, instance, summary);
            Provider = parent.Provider;
            ExceptionHandler = parent.ExceptionHandler;
            Definition = summary;
            Location = location;
            ShortPath = shortPath;
            ArrayIndex = arrayIndex;
            Provider = parent.Provider;
        }

        public IElementDefinitionSummary Definition { get; private set; }

        public string ShortPath { get; private set; }

        private IStructureDefinitionSummary down() =>
            // If this is a backbone element, the child type is the nested complex type
            Definition.Type[0] is IStructureDefinitionSummary be ? 
                    be : 
                    Provider.Provide(InstanceType);


        public IEnumerable<ITypedElement> Children(string name)
        {
            if (!(Current is Base parentBase)) yield break;

            var children = parentBase.NamedChildren;

            string oldElementName = null;
            int arrayIndex = 0;
            var childElementDefinitions = down().GetElements();

            foreach (var child in children)
            {
                if (name == null || child.ElementName == name)
                {
                    var mySummary = childElementDefinitions.SingleOrDefault(c => c.ElementName == child.ElementName);
                    if (mySummary != null)
                    {
                        if (!mySummary.IsCollection || oldElementName != child.ElementName)
                            arrayIndex = 0;
                        else
                            arrayIndex += 1;

                        var location = Location == null ? child.ElementName :
                                    $"{Location}.{child.ElementName}[{arrayIndex}]";
                        var shortPath = ShortPath == null ? child.ElementName :
                            (mySummary.IsCollection ?
                                $"{ShortPath}.{child.ElementName}[{arrayIndex}]" :
                                $"{ShortPath}.{child.ElementName}");

                        yield return new PocoElementNode(child.Value, this, location, shortPath, arrayIndex, mySummary);
                    }
                }

                oldElementName = child.ElementName;
            }
        }

        /// <summary>
        /// This is only needed for search data extraction (and debugging)
        /// to be able to read the values from the selected node (if a coding, so can get the value and system)
        /// </summary>
        /// <remarks>Will return null if on id, value, url (primitive attribute props in xml)</remarks>
        public Base FhirValue => Current as Base;

        public string Name => Definition.ElementName;

        public object Value
        {
            get
            {
                try
                {
                    switch (Current)
                    {
                        case string s:
                            return string.IsNullOrWhiteSpace(s) ? null : s;
                        case Hl7.Fhir.Model.Instant ins:
                            return ins.ToPartialDateTime();
                        case Hl7.Fhir.Model.Time time:
                            return time.ToTime();
                        case Hl7.Fhir.Model.Date dt:
                            return dt.ToPartialDateTime();
                        case FhirDateTime fdt:
                            return fdt.ToPartialDateTime();
                        case Hl7.Fhir.Model.Integer fint:
                            if (!fint.Value.HasValue)
                                return null;
                            return (int)fint.Value;
                        case Hl7.Fhir.Model.PositiveInt pint:
                            if (!pint.Value.HasValue)
                                return null;
                            return (int)pint.Value;
                        case Hl7.Fhir.Model.UnsignedInt unsint:
                            if (!unsint.Value.HasValue)
                                return null;
                            return (int)unsint.Value;
                        case Hl7.Fhir.Model.Base64Binary b64:
                            return b64.Value != null ? PrimitiveTypeConverter.ConvertTo<string>(b64.Value) : null;
                        case Primitive prim:
                            if (prim.ObjectValue is string stringObjectValue && string.IsNullOrWhiteSpace(stringObjectValue)) return null;
                            return prim.ObjectValue;
                        default:
                            return null;
                    }
                }
                catch (FormatException)
                {
                    // If it fails, just return the unparsed contents
                    return (Current as Primitive)?.ObjectValue;
                }
            }
        }


        public string InstanceType { get; private set; }

        public static string determineInstanceType(Model.Version version, object instance, IElementDefinitionSummary summary)
        {
            var typeName = !summary.IsChoiceElement && !summary.IsResource ?
                        summary.Type.Single().GetTypeName() : ((Base)instance).TypeName;

            return ModelInfos.Get(version).IsProfiledQuantity(typeName) ? "Quantity" : typeName;
        }

        public string Location { get; private set; }

        public string ResourceType => Current is Resource ? InstanceType : null;

        public IEnumerable<object> Annotations(Type type)
        {
            if (type == typeof(PocoElementNode) || type == typeof(ITypedElement) || type == typeof(IShortPathGenerator))
                return new[] { this };
            else if (type == typeof(IFhirValueProvider))
                return new[] { this };
            else if (type == typeof(IResourceTypeSupplier))
                return new[] { this };
            else if (FhirValue is IAnnotated ia)
                return ia.Annotations(type);

            else
                return Enumerable.Empty<object>();
        }
    }
}