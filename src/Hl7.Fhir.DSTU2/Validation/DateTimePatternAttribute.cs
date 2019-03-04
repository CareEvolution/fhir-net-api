﻿/* 
 * Copyright (c) 2014, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/fhir-net-api/master/LICENSE
 */

using System;
using System.ComponentModel.DataAnnotations;
using Hl7.Fhir.Model.DSTU2;

namespace Hl7.Fhir.Validation.DSTU2
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = false)]
    public class DateTimePatternAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null) return ValidationResult.Success;

            if (value.GetType() != typeof(string))
                throw new ArgumentException("DateTimePatternAttribute can only be applied to string properties");

            if (FhirDateTime.IsValidValue(value as string))
                return ValidationResult.Success;
            else
                return DotNetAttributeValidation.BuildResult(validationContext, "{0} is not a correctly formatted DateTime", value as string);
        }
    }
}
