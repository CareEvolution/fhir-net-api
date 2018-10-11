using Hl7.Fhir.ElementModel;

namespace Hl7.Fhir.Model.DSTU2
{
    public static class TypedElementExtensions
    {
        public static ITypedElement ToTypedElement(this Base @base, string rootName = null) =>
            new PocoElementNode(@base, DSTU2ModelInfo.Instance.StructureDefinitionProvider, rootName: rootName);
    }
}
