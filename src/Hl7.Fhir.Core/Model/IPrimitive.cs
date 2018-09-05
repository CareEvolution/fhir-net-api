namespace Hl7.Fhir.Model
{
    public interface IPrimitive
    {
        object ObjectValue { get; set; }
    }

    public interface IParsedPrimitive
    {
        object ParsedValue { get; }
    }

}
