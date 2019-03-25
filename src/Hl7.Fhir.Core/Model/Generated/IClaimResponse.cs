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
    /// Remittance resource
    /// </summary>
    public partial interface IClaimResponse : Hl7.Fhir.Model.IDomainResource
    {
    
        /// <summary>
        /// Response  number
        /// </summary>
        List<Hl7.Fhir.Model.Identifier> Identifier { get; set; }
    
        /// <summary>
        /// Creation date
        /// </summary>
        Hl7.Fhir.Model.FhirDateTime CreatedElement { get; set; }
        
        /// <summary>
        /// Creation date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        string Created { get; set; }
    
        /// <summary>
        /// Id of resource triggering adjudication
        /// </summary>
        Hl7.Fhir.Model.ResourceReference Request { get; set; }
    
        /// <summary>
        /// Disposition Message
        /// </summary>
        Hl7.Fhir.Model.FhirString DispositionElement { get; set; }
        
        /// <summary>
        /// Disposition Message
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        string Disposition { get; set; }
    
        /// <summary>
        /// Insurer added line items
        /// </summary>
        IEnumerable<Hl7.Fhir.Model.IClaimResponseAddedItemComponent> AddItem { get; }
    
    }
    
    public partial interface IClaimResponseItemDetailComponent : Hl7.Fhir.Model.IBackboneElement
    {
    
        /// <summary>
        /// Subdetail line items
        /// </summary>
        IEnumerable<Hl7.Fhir.Model.IClaimResponseSubDetailComponent> SubDetail { get; }
    
    }
    
    public partial interface IClaimResponseSubDetailComponent : Hl7.Fhir.Model.IBackboneElement
    {
    
    }
    
    public partial interface IClaimResponseAddedItemComponent : Hl7.Fhir.Model.IBackboneElement
    {
    
    }

}