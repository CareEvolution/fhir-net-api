namespace Hl7.Fhir.Model
{
    /// <summary>
    /// An empty base class to handle Resources in version independent way
    /// </summary>
    // public abstract class ResourceBase : Base
    // {
    // }

    public interface IResource
    {
        string TypeName { get; }
    }

    /// <summary>
    /// An empty base class to handle Elements in version independent way
    /// </summary>
    public abstract class ElementBase : Base
    { }
}
