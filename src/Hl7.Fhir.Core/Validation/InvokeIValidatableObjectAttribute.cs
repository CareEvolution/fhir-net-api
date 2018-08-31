/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Hl7.Fhir.Validation
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    public class InvokeIValidatableObjectAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validatable = value as IValidatableObject;

            if (validatable != null)
                return validatable.Validate(validationContext).FirstOrDefault();
            else
                return null;
        }
    }
}
