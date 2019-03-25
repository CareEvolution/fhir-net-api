﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Utility;

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
// Generated for FHIR v1.0.2, v4.0.0, v3.0.1
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A homogeneous material with a definite composition
    /// </summary>
    public partial interface ISubstance : Hl7.Fhir.Model.IDomainResource
    {
    
        /// <summary>
        /// Unique identifier
        /// </summary>
        List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
    
        /// <summary>
        /// What class/type of substance this is
        /// </summary>
        List<Hl7.Fhir.Model.CodeableConcept> Category { get; set; }
    
        /// <summary>
        /// What substance this is
        /// </summary>
        Hl7.Fhir.Model.CodeableConcept Code { get; set; }
    
        /// <summary>
        /// Textual description of the substance, comments
        /// </summary>
        Hl7.Fhir.Model.FhirString DescriptionElement { get; set; }
        
        /// <summary>
        /// Textual description of the substance, comments
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        string Description { get; set; }
    
        /// <summary>
        /// If this describes a specific package/container of the substance
        /// </summary>
        IEnumerable<Hl7.Fhir.Model.ISubstanceInstanceComponent> Instance { get; }
    
        /// <summary>
        /// Composition information about the substance
        /// </summary>
        IEnumerable<Hl7.Fhir.Model.ISubstanceIngredientComponent> Ingredient { get; }
    
    }
    
    public partial interface ISubstanceInstanceComponent : Hl7.Fhir.Model.IBackboneElement
    {
    
        /// <summary>
        /// Identifier of the package/container
        /// </summary>
        Hl7.Fhir.Model.Identifier Identifier { get; set; }
    
        /// <summary>
        /// When no longer valid to use
        /// </summary>
        Hl7.Fhir.Model.FhirDateTime ExpiryElement { get; set; }
        
        /// <summary>
        /// When no longer valid to use
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        string Expiry { get; set; }
    
        /// <summary>
        /// Amount of substance in the package
        /// </summary>
        Hl7.Fhir.Model.SimpleQuantity Quantity { get; set; }
    
    }
    
    public partial interface ISubstanceIngredientComponent : Hl7.Fhir.Model.IBackboneElement
    {
    
        /// <summary>
        /// Optional amount (concentration)
        /// </summary>
        Hl7.Fhir.Model.Ratio Quantity { get; set; }
    
    }

}