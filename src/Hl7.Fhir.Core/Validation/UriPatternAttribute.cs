/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System;
using System.ComponentModel.DataAnnotations;
using Hl7.Fhir.Model.R4;

namespace Hl7.Fhir.Validation.R4
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class UriPatternAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            if (value.GetType() != typeof(string))
                throw new ArgumentException("UriPatternAttribute can only be applied to .NET Uri properties");

            if (!FhirUri.IsValidValue(value as string))
                return DotNetAttributeValidation.BuildResult(validationContext, "Uri uses an urn:oid or urn:uuid scheme, but the syntax {0} is incorrect", value as string);
            else
                return ValidationResult.Success;
        }
    }
}
