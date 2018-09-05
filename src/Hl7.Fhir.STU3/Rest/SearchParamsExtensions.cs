/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.Model.STU3;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Utility;

namespace Hl7.Fhir.Rest.STU3
{
    public static class SearchParamsExtensions
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
