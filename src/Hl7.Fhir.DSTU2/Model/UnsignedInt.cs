using System.Xml;
using Hl7.Fhir.Introspection;

namespace Hl7.Fhir.Model.DSTU2
{
    public partial class UnsignedInt : INullableIntegerValue, IParsedPrimitive
    {
        public static bool IsValidValue(string value)
        {
            try
            {
                var dummy = XmlConvert.ToInt32(value);
                if (dummy < 0) return false;
            }
            catch
            {
                return false;
            }

            return true;
        }

        [NotMapped]
        public object ParsedValue => (long?)Value;
    }
}
