﻿/* 
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
        
        /// <summary>
        /// Build a POCO from an ISourceNode.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dataType">Optional. Type of POCO to build. Should be one of the generated POCO classes.</param>
        /// <returns></returns>
        /// <remarks>If <paramref name="dataType"/> is not supplied, or is <code>Resource</code> or <code>DomainResource</code>, 
        /// the builder will try to determine the actual type to create from the <paramref name="source"/>. </remarks>
        public Base BuildFrom(ISourceNode source, Type dataType = null)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            string typeFound = null;
            if (dataType != null)
            {
                typeFound = _modelInfo.GetFhirTypeNameForType(dataType);

                if (typeFound == null)
                {
                    ExceptionNotification.Error(
                        new StructuralTypeException($"The .NET type '{dataType.Name}' does not represent a FHIR type."));

                    return null;
                }
            }
            return BuildFrom(source, typeFound);
        }

        /// <summary>
        /// Build a POCO from an ISourceNode.
        /// </summary>
        /// <param name="source"></param>
        /// <param name="dataType">Optional. Type of POCO to build. Should be the name of one of the generated POCO classes.</param>
        /// <returns></returns>
        /// <remarks>If <paramref name="dataType"/> is not supplied, or is <code>Resource</code> or <code>DomainResource</code>, 
        /// the builder will try to determine the actual type to create from the <paramref name="source"/>. </remarks>
        public Base BuildFrom(ISourceNode source, string dataType = null)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));
            TypedElementSettings typedSettings = new TypedElementSettings
            {
                ErrorMode = _settings.IgnoreUnknownMembers ?
                    TypedElementSettings.TypeErrorMode.Ignore
                    : TypedElementSettings.TypeErrorMode.Report
            };

            // If dataType is an abstract resource superclass -> ToTypedElement(with type=null) will figure it out;
            if (dataType == "Resource" || dataType == "DomainResource")
                dataType = null;

            var typedSource = source.ToTypedElement(_modelInfo.StructureDefinitionProvider, dataType, typedSettings);

            return BuildFrom(typedSource);
        }

        /// <summary>
        /// Build a POCO from an IElementNode.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public Base BuildFrom(ITypedElement source)
        {
            if (source == null) throw Error.ArgumentNull(nameof(source));

            if (source is IExceptionSource)
            {
                using (source.Catch((o, a) => ExceptionHandler.NotifyOrThrow(o, a)))
                {
                    return build();
                }
            }
            else
                return build();

            Base build()
            {
                var typeToBuild = _modelInfo.GetTypeForFhirType(source.InstanceType);

                if (typeToBuild == null)
                {
                    ExceptionHandler.NotifyOrThrow(this,
                        ExceptionNotification.Error(
                            new StructuralTypeException($"There is no .NET type representing the FHIR type '{source.InstanceType}'.")));

                    return null;
                }

                var settings = new ParserSettings
                {
                    AcceptUnknownMembers = _settings.IgnoreUnknownMembers,
                    AllowUnrecognizedEnums = _settings.AllowUnrecognizedEnums
                };

                return typeToBuild.CanBeTreatedAsType(typeof(IResource))
                    ? new ResourceReader(_modelInfo, source, settings).Deserialize()
                    : new ComplexTypeReader(_modelInfo, source, settings).Deserialize();
            }
        }
    }
}

