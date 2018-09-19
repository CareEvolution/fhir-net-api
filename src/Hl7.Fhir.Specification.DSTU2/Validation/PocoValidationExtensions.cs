﻿/* 
 * Copyright (c) 2016, Firely (info@fire.ly) and contributors
 * See the file CONTRIBUTORS for details.
 * 
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/ewoutkramer/fhir-net-api/master/LICENSE
 */

using System.Collections.Generic;
using Hl7.Fhir.ElementModel;
using Hl7.Fhir.ElementModel.DSTU2;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.DSTU2;

namespace Hl7.Fhir.Validation
{
    /// <summary>
    /// Add support for validating against Base subclasses (instead of ITypedElement) to the Validator
    /// </summary>
    public static class PocoValidationExtensions
    {
        public static OperationOutcome Validate(this Validator me, Base instance)
        {
            return me.Validate(instance.ToTypedElement());
        }

        public static OperationOutcome Validate(this Validator me, Base instance, params string[] definitionUri)
        {
            return me.Validate(instance.ToTypedElement(), definitionUri);
        }

        public static OperationOutcome Validate(this Validator me, Base instance, StructureDefinition structureDefinition)
        {
            return me.Validate(instance.ToTypedElement(), structureDefinition);
        }

        public static OperationOutcome Validate(this Validator me, Base instance, IEnumerable<StructureDefinition> structureDefinitions)
        {
            return me.Validate(instance.ToTypedElement(), structureDefinitions);
        }
    }
}