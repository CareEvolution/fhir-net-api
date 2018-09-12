namespace Hl7.Fhir.Model
{
    public interface IBinary
    {
        byte[] Content { get; }
        string ContentType { get; }
    }
}
