/* 
 * Copyright (c) 2018, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://github.com/FirelyTeam/fhir-net-api/blob/master/LICENSE
 */


using System;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;

namespace Hl7.Fhir.ElementModel
{
    public static class PocoBuilderExtensions
    {
        public static Base ToPoco(this ISourceNode source, IModelInfo modelInfo, Type pocoType = null, PocoBuilderSettings settings = null) =>
            new PocoBuilder(modelInfo, settings).BuildFrom(source, pocoType);

        public static T ToPoco<T>(this ISourceNode source, IModelInfo modelInfo, PocoBuilderSettings settings = null) where T : Base =>
               (T)source.ToPoco(modelInfo, typeof(T), settings);

        public static Base ToPoco(this ITypedElement element, IModelInfo modelInfo, PocoBuilderSettings settings = null) =>
            new PocoBuilder(modelInfo, settings).BuildFrom(element);

        public static T ToPoco<T>(this ITypedElement element, IModelInfo modelInfo, PocoBuilderSettings settings = null) where T : Base =>
               (T)element.ToPoco(modelInfo, settings);
    }
}
