using System.Collections.Generic;

namespace Hl7.Fhir.Model
{
    public interface IParameters
    {
        IEnumerable<IParameterComponent> Parameters { get; }
    }

    public interface IParameterComponent
    {
        string Name { get; }
        ElementBase Value { get; }
        ResourceBase Resource { get; }
    }
}
