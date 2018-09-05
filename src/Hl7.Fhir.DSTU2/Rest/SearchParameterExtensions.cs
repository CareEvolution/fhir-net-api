using Hl7.Fhir.Model.DSTU2;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Rest.DSTU2
{
    public static class SearchParameterExtensions
    {
        public static SearchParams FromParameters(Parameters parameters)
        {
            var result = new SearchParams();

            foreach (var parameter in parameters.Parameter)
            {
                var name = parameter.Name;
                var value = parameter.Value;

                if (value != null && value is Primitive)
                {
                    result.Add(parameter.Name, PrimitiveTypeConverter.ConvertTo<string>(value));
                }
                else
                    if (value == null) throw Error.NotSupported("Can only convert primitive parameters to Uri parameters");
            }

            return result;
        }

        public static Parameters ToParameters(this SearchParams searchParams)
        {
            var result = new Parameters();

            foreach (var parameter in searchParams.ToUriParamList())
            {
                result.Add(parameter.Item1, new FhirString(parameter.Item2));
            }

            return result;
        }
    }
}
