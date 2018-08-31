/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Hl7.Fhir.Validation
{
    public class DotNetAttributeValidation
    {
        public static ValidationContext BuildContext(object value = null)
        {
#if NET40
            return new ValidationContext(value, null, null);
#else
            return new ValidationContext(value);
#endif
        }

        public static void Validate(object value, bool recurse = false)
        {
            if (value == null) throw new ArgumentNullException("value");

            var validationContext = BuildContext(value);
            validationContext.SetValidateRecursively(recurse);

            Validator.ValidateObject(value, validationContext, true);
        }

        public static bool TryValidate(object value, ICollection<ValidationResult> validationResults = null, bool recurse = false)
        {
            if (value == null) throw new ArgumentNullException("value");

            var results = validationResults ?? new List<ValidationResult>();
            var validationContext = BuildContext(value);
            validationContext.SetValidateRecursively(recurse);
            return Validator.TryValidateObject(value, validationContext, results, true);

            // Note, if you pass a null validationResults, you will *not* get results (it's not an out param!)
        }


        internal static ValidationResult BuildResult(ValidationContext context, string message, params object[] messageArgs)
        {
            var resultMessage = string.Format(message, messageArgs);

            if (context != null && context.MemberName != null)
                return new ValidationResult(resultMessage, new string[] { context.MemberName });
            else
                return new ValidationResult(resultMessage);
        }
    }

}
