﻿/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/FirelyTeam/fhir-net-api/blob/master/LICENSE
 */

using Hl7.Fhir.Introspection;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Hl7.Fhir.Specification
{
    public class PocoStructureDefinitionSummaryProvider : IStructureDefinitionSummaryProvider
    {
        public Model.Version Version { get; }

        public PocoStructureDefinitionSummaryProvider(Model.Version version)
        {
            if (version == Model.Version.All || version == Model.Version.None) throw Error.Argument(nameof(version), "Must be a specific version");

            Version = version;
        }

        public IStructureDefinitionSummary Provide(Type type)
        {
            var classMapping = GetMappingForType(type);
            if (classMapping == null) return null;

            return new PocoComplexTypeSerializationInfo(Version, classMapping);
        }

        public IStructureDefinitionSummary Provide(string canonical)
        {
            var isLocalType = !canonical.Contains("/");
            var typeName = canonical;

            if(!isLocalType)
            {
                // So, we have received a canonical url, not being a relative path
                // (know resource/datatype), we -for now- only know how to get a ClassMapping
                // for this, if it's a built-in T4 generated POCO, so there's no way
                // to find a mapping for this.
                return null;
            }

            var csType = ModelInfos.Get(Version).GetTypeForFhirType(typeName);
            if (csType == null) return null;

            return Provide(csType);
        }

        internal static ClassMapping GetMappingForType(Type elementType)
        {
            var inspector = Serialization.BaseFhirParser.Inspector;
            return inspector.ImportType(elementType);
        }
    }


    internal struct PocoComplexTypeSerializationInfo : IStructureDefinitionSummary
    {
        private readonly Model.Version _version;
        private readonly ClassMapping _classMapping;

        public PocoComplexTypeSerializationInfo(Model.Version version, ClassMapping classMapping)
        {
            if (version == Model.Version.All) throw Error.Argument(nameof(version), "Must be a specific version");

            _version = version;
            _classMapping = classMapping;
        }

        public string TypeName => !_classMapping.IsComponent ? _classMapping.Name :
            (_classMapping.NativeType.CanBeTreatedAsType(typeof(BackboneElement)) ?
            "BackboneElement" : "Element");

        public bool IsAbstract => _classMapping.IsAbstract;
        public bool IsResource => _classMapping.IsResource;

        public IReadOnlyCollection<IElementDefinitionSummary> GetElements()
        {
            var version = _version;
            return _classMapping.GetPropertyMappings(version)
                .Where(pm => !pm.RepresentsValueElement)
                .Select(pm => (IElementDefinitionSummary)new PocoElementSerializationInfo(version, pm))
#if NET40
                .ToReadOnlyCollection();
#else
                .ToList();
#endif
        }

        public IElementDefinitionSummary GetElement(string name)
        {
            var version = _version;
            return _classMapping.GetPropertyMappings(version)
                .Where(pm => !pm.RepresentsValueElement && pm.Name == name)
                .Select(s => (IElementDefinitionSummary)new PocoElementSerializationInfo(version, s)).SingleOrDefault();
        }
    }

    internal struct PocoTypeReferenceInfo : IStructureDefinitionReference
    {
        public PocoTypeReferenceInfo(string canonical)
        {
            ReferredType = canonical;
        }

        public string ReferredType { get; private set; }
    }


    internal struct PocoElementSerializationInfo : IElementDefinitionSummary
    {
        private readonly Model.Version _version;
        private readonly PropertyMapping _pm;

        // [WMR 20180822] OPTIMIZE: use LazyInitializer.EnsureInitialized instead of Lazy<T>
        // Lazy<T> introduces considerable performance degradation when running in debugger (F5) ?
        //private readonly Lazy<ITypeSerializationInfo[]> _types;
        private ITypeSerializationInfo[] _types;

        internal PocoElementSerializationInfo(Model.Version version, PropertyMapping pm)
        {
            if (version == Model.Version.All) throw Error.Argument(nameof(version), "Must be a specific version");

            _version = version;
            _pm = pm;

            // [WMR 20180822] OPTIMIZE
            // _types = new Lazy<ITypeSerializationInfo[]>(() => buildTypes(pm));
            _types = null;
        }

        // [WMR 20180822] OPTIMIZE
        // private static ITypeSerializationInfo[] buildTypes(PropertyMapping pm)
        private ITypeSerializationInfo[] buildTypes()
        {
            var pm = _pm;

            if (pm.IsComponent)
            {
                var mapping = PocoStructureDefinitionSummaryProvider.GetMappingForType(pm.ImplementingType);
                return new ITypeSerializationInfo[] { new PocoComplexTypeSerializationInfo(_version, mapping) };
            }
            else
            {              
                if ( !pm.FhirTypeByVersion.TryGetValue( Model.Version.All, out var fhirType ) )
                {
                    pm.FhirTypeByVersion.TryGetValue(_version, out fhirType);
                }
                var names = fhirType.Select(ft => getFhirTypeName(ft));
                return names.Select(n => (ITypeSerializationInfo)new PocoTypeReferenceInfo(n)).ToArray();
            }

            string getFhirTypeName(Type ft)
            {
                var map = PocoStructureDefinitionSummaryProvider.GetMappingForType(ft);
                return map.IsCodeOfT ? "code" : map.Name;
            }
        }

        public string ElementName => _pm.Name;

        public bool IsCollection => _pm.IsCollection;

        public bool InSummary => (_pm.InSummary & _version) != 0;

        public XmlRepresentation Representation => _pm.SerializationHint != XmlRepresentation.None ?
            _pm.SerializationHint : XmlRepresentation.XmlElement;

        public bool IsChoiceElement => _pm.Choice == ChoiceType.DatatypeChoice;

        public bool IsResource => _pm.Choice == ChoiceType.ResourceChoice;

        public bool IsRequired => _pm.IsMandatoryElement;

        public int Order => _pm.Order;

        // [WMR 20180822] OPTIMIZE
        public ITypeSerializationInfo[] Type //=> _types.Value;
        {
            get
            {
                // [WMR 20180822] Optimize lazy initialization
                // Multiple threads may execute buildTypes, first result is used & assigned
                // Safe, because buildTypes is idempotent
                LazyInitializer.EnsureInitialized(ref _types, buildTypes);
                return _types;
            }
        }

        public string NonDefaultNamespace => null;
    }
}
