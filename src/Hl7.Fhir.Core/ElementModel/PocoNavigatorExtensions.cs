using Hl7.Fhir.Model;
using Hl7.Fhir.Specification;

namespace Hl7.Fhir.ElementModel
{
    public static class PocoNavigatorExtensions
    {
        public static ITypedElement ToTypedElement(this Base @base, Model.Version version, string rootName = null) =>
            new PocoElementNode(@base, new PocoStructureDefinitionSummaryProvider(version), rootName: rootName);
    }
}
