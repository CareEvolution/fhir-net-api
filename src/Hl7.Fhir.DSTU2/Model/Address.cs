using Hl7.Fhir.ElementModel;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Model.DSTU2
{
    partial class Address : ICustomCollectionPath
    {
        public string GetCollectionPath()
        {
            return !Use.HasValue ? string.Empty : $".where(use='{Use.Value.GetLiteral()}')')";
        }
    }
}
