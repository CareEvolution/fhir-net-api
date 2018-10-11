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
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace Hl7.Fhir.Specification
{
    public class PocoStructureDefinitionSummaryProvider : IStructureDefinitionSummaryProvider
    {
        private readonly IModelInfo _modelInfo;
        private readonly ModelInspector _modelInspector;
        private readonly Dictionary<Type, PocoComplexTypeSerializationInfo> _structureSummaryByType = new Dictionary<Type, PocoComplexTypeSerializationInfo>();
        private readonly object _lockObject = new object();

        public PocoStructureDefinitionSummaryProvider(IModelInfo modelInfo, ModelInspector modelInspector)
        {
            _modelInfo = modelInfo;
            _modelInspector = modelInspector;
            foreach (var classMapping in modelInspector.ClassMappings)
            {
                _structureSummaryByType.Add(classMapping.NativeType, new PocoComplexTypeSerializationInfo(classMapping));
            }
            foreach (var structureSummary in _structureSummaryByType.Values)
            {
                structureSummary.Elements = CreateElements(structureSummary.ClassMapping);
            }
        }

        public IStructureDefinitionSummary Provide(Type type)
        {
            PocoComplexTypeSerializationInfo entry;
            if (_structureSummaryByType.TryGetValue(type, out entry))
            {
                return entry;
            }

            var classMapping = _modelInspector.ImportType(type);
            if (classMapping == null) return null;
            lock (_lockObject)
            {
                entry = new PocoComplexTypeSerializationInfo(classMapping);
                entry.Elements = CreateElements(entry.ClassMapping);
                _structureSummaryByType.Add(classMapping.NativeType, entry);
            }

            return entry;
        }

        public IStructureDefinitionSummary Provide(string canonical)
        {
            var isLocalType = !canonical.Contains("/");
            var typeName = canonical;

            if (!isLocalType)
            {
                // So, we have received a canonical url, not being a relative path
                // (know resource/datatype), we -for now- only know how to get a ClassMapping
                // for this, if it's a built-in T4 generated POCO, so there's no way
                // to find a mapping for this.
                return null;
            }

            Type csType = _modelInfo.GetTypeForFhirType(typeName);
            if (csType == null) return null;

            return Provide(csType);
        }

        private IEnumerable<IElementDefinitionSummary> CreateElements(ClassMapping classMapping)
        {
            return classMapping.PropertyMappings
                .Where(pm => !pm.RepresentsValueElement)
                .Select(pm => (IElementDefinitionSummary)new PocoElementSerializationInfo(pm, CreateTypes(pm)))
                .ToList();
        }

        private ITypeSerializationInfo[] CreateTypes(PropertyMapping propertyMapping)
        {
            if (propertyMapping.IsBackboneElement)
            {
                return new ITypeSerializationInfo[] { _structureSummaryByType[propertyMapping.ImplementingType] };
            }
            else
            {
                var names = propertyMapping.FhirType.Select(ft => getFhirTypeName(ft));
                return names.Select(n => (ITypeSerializationInfo)new PocoTypeReferenceInfo(n)).ToArray();
            }

            string getFhirTypeName(Type ft)
            {
                var map = _modelInfo.FindClassMappingByType(ft);
                return map.IsCodeOfT ? "code" : map.Name;
            }
        }

        internal bool IsProfiledQuantity(string typeName)
        {
            return _modelInfo.IsProfiledQuantity(typeName);
        }
    }

    public interface IModelInfo
    {
        string Version { get; }
        PocoStructureDefinitionSummaryProvider StructureDefinitionProvider { get; }
        string GetFhirTypeNameForType(Type dataType);
        Type GetTypeForFhirType(string typeName);
        ClassMapping FindClassMappingByType(Type elementType);
        ClassMapping FindClassMappingForFhirDataType(string typeName);
        ClassMapping FindClassMappingForResource(string resourceTypeName);
        Base AddSubsettedTag(Base instance, SummaryType summaryType);
        bool IsProfiledQuantity(string typeName);
    }

    internal class PocoComplexTypeSerializationInfo : IStructureDefinitionSummary
    {
        public PocoComplexTypeSerializationInfo(ClassMapping classMapping)
        {
            ClassMapping = classMapping;
            if (!ClassMapping.IsBackbone)
            {
                TypeName = ClassMapping.Name;
            }
            else
            {
                // IBackboneElement isn't a good marker, because Timing.RepeatComponent is IBackboneElement but not BackboneElement.
                if (ClassMapping.NativeType.BaseType.Name.Contains("BackboneElement"))
                {
                    TypeName = "BackboneElement";
                }
                else
                {
                    TypeName = "Element";
                }

            }
        }

        public string TypeName { get; }

        public ClassMapping ClassMapping { get; }

        public bool IsAbstract => ClassMapping.IsAbstract;
        public bool IsResource => ClassMapping.IsResource;

        public IEnumerable<IElementDefinitionSummary> Elements { get; set; }
    }

    internal class PocoTypeReferenceInfo : IStructureDefinitionReference
    {
        public PocoTypeReferenceInfo(string canonical)
        {
            ReferredType = canonical;
        }

        public string ReferredType { get; }
    }

    internal class PocoElementSerializationInfo : IElementDefinitionSummary
    {
        private readonly PropertyMapping _pm;

        internal PocoElementSerializationInfo(PropertyMapping pm, ITypeSerializationInfo[] type)
        {
            _pm = pm;
            Type = type;
        }

        public string ElementName => _pm.Name;

        public bool IsCollection => _pm.IsCollection;

        public bool InSummary => _pm.InSummary;

        public XmlRepresentation Representation => _pm.SerializationHint != XmlRepresentation.None ?
            _pm.SerializationHint : XmlRepresentation.XmlElement;

        public bool IsChoiceElement => _pm.Choice == ChoiceType.DatatypeChoice;

        public bool IsResource => _pm.Choice == ChoiceType.ResourceChoice;

        public bool IsRequired => _pm.IsMandatoryElement;

        public int Order => _pm.Order;

        public ITypeSerializationInfo[] Type { get; }

        public string NonDefaultNamespace => null;
    }
}
