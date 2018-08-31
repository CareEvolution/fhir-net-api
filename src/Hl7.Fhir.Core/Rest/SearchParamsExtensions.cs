﻿/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using Hl7.Fhir.Utility;
using System;

namespace Hl7.Fhir.Rest
{
    public static class SearchParamsExtensions
    {
        public static SearchParams Include(this SearchParams qry, string path)
        {
            qry.Include.Add(path);

            return qry;
        }

	    public static SearchParams Where(this SearchParams qry, string criterium)
        {
            var keyVal = criterium.SplitLeft('=');
            qry.Add(keyVal.Item1, keyVal.Item2);

            return qry;
        }

        public static SearchParams Custom(this SearchParams qry, string customQueryName)
        {
			if (customQueryName == null) throw Error.ArgumentNull(nameof(customQueryName));

			qry.Query = customQueryName;
            return qry;
        }

        public static SearchParams OrderBy(this SearchParams qry, string paramName, SortOrder order = SortOrder.Ascending)
        {
            if (paramName == null) throw Error.ArgumentNull(nameof(paramName));

            qry.Sort.Add(Tuple.Create(paramName, order));
            return qry;
        }

        public static SearchParams LimitTo(this SearchParams qry, int count)
        {
            qry.Count = count;
            return qry;
        }

        public static SearchParams CountOnly(this SearchParams qry)
        {
            qry.Summary = SummaryType.Count;
            return qry;
        }


        public static SearchParams SummaryOnly(this SearchParams qry, SummaryType summaryOnly = SummaryType.True)
        {            
            qry.Summary = summaryOnly;
            return qry;
        }

        public static SearchParams TextOnly(this SearchParams qry)
        {
            qry.Summary = SummaryType.Text;
            return qry;
        }

        public static SearchParams DataOnly(this SearchParams qry)
        {
            qry.Summary = SummaryType.Data;
            return qry;
        }


    }
}

namespace Hl7.Fhir.Rest.DSTU2
{
    using Hl7.Fhir.Model.DSTU2;
    using Hl7.Fhir.Serialization;

    public static class SearchParamsExtensions
    {
        public static SearchParams FromParameters( Parameters parameters)
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
