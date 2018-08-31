﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.DSTU2;
using Hl7.Fhir.Validation.DSTU2;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Specification;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.

  Redistribution and use in source and binary forms, with or without modification,
  are permitted provided that the following conditions are met:

   * Redistributions of source code must retain the above copyright notice, this
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice,
     this list of conditions and the following disclaimer in the documentation
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to
     endorse or promote products derived from this software without specific
     prior written permission.

  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY,
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
  POSSIBILITY OF SUCH DAMAGE.


*/

#pragma warning disable 1591 // suppress XML summary warnings

//
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
{
    [FhirType("Quantity")]
    [DataContract]
    public partial class Age : Quantity
    {
        [NotMapped]
        public override string TypeName { get { return "Age"; } }



        public static ElementDefinition.ConstraintComponent Age_AGE_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(code or value.empty()) and (system.empty() or system = %ucum) and (value.empty() or value.toString().contains('.').not())",
            Key = "age-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "There SHALL be a code if there is a value and it SHALL be an expression of time.  If system is present, it SHALL be UCUM.  If value is present, it SHALL be positive.",
            Xpath = "(f:code or not(f:value)) and (not(exists(f:system)) or f:system/@value='http://unitsofmeasure.org') and not(contains(f:value/@value, '-'))"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Age());
        }

    }

}
