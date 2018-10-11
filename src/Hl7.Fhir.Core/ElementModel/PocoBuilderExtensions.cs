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
