﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// <summary>
    /// Definition of an operation or a named query
    /// </summary>
    [FhirType("OperationDefinition", IsResource=true)]
    [DataContract]
    public partial class OperationDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.OperationDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "OperationDefinition"; } }

        /// <summary>
        /// Whether an operation is a normal operation or a query.
        /// (url: http://hl7.org/fhir/ValueSet/operation-kind)
        /// </summary>
        [FhirEnumeration("OperationKind")]
        public enum OperationKind
        {
            /// <summary>
            /// This operation is invoked as an operation.
            /// (system: http://hl7.org/fhir/operation-kind)
            /// </summary>
            [EnumLiteral("operation", "http://hl7.org/fhir/operation-kind"), Description("Operation")]
            Operation,
            /// <summary>
            /// This operation is a named query, invoked using the search mechanism.
            /// (system: http://hl7.org/fhir/operation-kind)
            /// </summary>
            [EnumLiteral("query", "http://hl7.org/fhir/operation-kind"), Description("Query")]
            Query,
        }

        /// <summary>
        /// Whether an operation parameter is an input or an output parameter.
        /// (url: http://hl7.org/fhir/ValueSet/operation-parameter-use)
        /// </summary>
        [FhirEnumeration("OperationParameterUse")]
        public enum OperationParameterUse
        {
            /// <summary>
            /// This is an input parameter.
            /// (system: http://hl7.org/fhir/operation-parameter-use)
            /// </summary>
            [EnumLiteral("in", "http://hl7.org/fhir/operation-parameter-use"), Description("In")]
            In,
            /// <summary>
            /// This is an output parameter.
            /// (system: http://hl7.org/fhir/operation-parameter-use)
            /// </summary>
            [EnumLiteral("out", "http://hl7.org/fhir/operation-parameter-use"), Description("Out")]
            Out,
        }

        /// <summary>
        /// Parameter Types used in Operation Definitions
        /// (url: http://hl7.org/fhir/ValueSet/operation-parameter-type)
        /// </summary>
        [FhirEnumeration("ParameterTypesusedinOperationDefinitions")]
        public enum ParameterTypesusedinOperationDefinitions
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-param-type)
            /// </summary>
            [EnumLiteral("number", "http://hl7.org/fhir/search-param-type"), Description("Number")]
            Number,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-param-type)
            /// </summary>
            [EnumLiteral("date", "http://hl7.org/fhir/search-param-type"), Description("Date/DateTime")]
            Date,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-param-type)
            /// </summary>
            [EnumLiteral("string", "http://hl7.org/fhir/search-param-type"), Description("String")]
            String,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-param-type)
            /// </summary>
            [EnumLiteral("token", "http://hl7.org/fhir/search-param-type"), Description("Token")]
            Token,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-param-type)
            /// </summary>
            [EnumLiteral("reference", "http://hl7.org/fhir/search-param-type"), Description("Reference")]
            Reference,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-param-type)
            /// </summary>
            [EnumLiteral("composite", "http://hl7.org/fhir/search-param-type"), Description("Composite")]
            Composite,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-param-type)
            /// </summary>
            [EnumLiteral("quantity", "http://hl7.org/fhir/search-param-type"), Description("Quantity")]
            Quantity,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/search-param-type)
            /// </summary>
            [EnumLiteral("uri", "http://hl7.org/fhir/search-param-type"), Description("URI")]
            Uri,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Address", "http://hl7.org/fhir/data-types"), Description("Address")]
            Address,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Age", "http://hl7.org/fhir/data-types"), Description("Age")]
            Age,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Annotation", "http://hl7.org/fhir/data-types"), Description("Annotation")]
            Annotation,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Attachment", "http://hl7.org/fhir/data-types"), Description("Attachment")]
            Attachment,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("BackboneElement", "http://hl7.org/fhir/data-types"), Description("BackboneElement")]
            BackboneElement,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("CodeableConcept", "http://hl7.org/fhir/data-types"), Description("CodeableConcept")]
            CodeableConcept,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Coding", "http://hl7.org/fhir/data-types"), Description("Coding")]
            Coding,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("ContactPoint", "http://hl7.org/fhir/data-types"), Description("ContactPoint")]
            ContactPoint,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Count", "http://hl7.org/fhir/data-types"), Description("Count")]
            Count,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Distance", "http://hl7.org/fhir/data-types"), Description("Distance")]
            Distance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Duration", "http://hl7.org/fhir/data-types"), Description("Duration")]
            Duration,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Element", "http://hl7.org/fhir/data-types"), Description("Element")]
            Element,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("ElementDefinition", "http://hl7.org/fhir/data-types"), Description("ElementDefinition")]
            ElementDefinition,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Extension", "http://hl7.org/fhir/data-types"), Description("Extension")]
            Extension,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("HumanName", "http://hl7.org/fhir/data-types"), Description("HumanName")]
            HumanName,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Identifier", "http://hl7.org/fhir/data-types"), Description("Identifier")]
            Identifier,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Meta", "http://hl7.org/fhir/data-types"), Description("Meta")]
            Meta,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Money", "http://hl7.org/fhir/data-types"), Description("Money")]
            Money,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Narrative", "http://hl7.org/fhir/data-types"), Description("Narrative")]
            Narrative,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Period", "http://hl7.org/fhir/data-types"), Description("Period")]
            Period,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Range", "http://hl7.org/fhir/data-types"), Description("Range")]
            Range,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Ratio", "http://hl7.org/fhir/data-types"), Description("Ratio")]
            Ratio,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("SampledData", "http://hl7.org/fhir/data-types"), Description("SampledData")]
            SampledData,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Signature", "http://hl7.org/fhir/data-types"), Description("Signature")]
            Signature,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("SimpleQuantity", "http://hl7.org/fhir/data-types"), Description("SimpleQuantity")]
            SimpleQuantity,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Timing", "http://hl7.org/fhir/data-types"), Description("Timing")]
            Timing,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("base64Binary", "http://hl7.org/fhir/data-types"), Description("base64Binary")]
            Base64Binary,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("boolean", "http://hl7.org/fhir/data-types"), Description("boolean")]
            Boolean,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("code", "http://hl7.org/fhir/data-types"), Description("code")]
            Code,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("dateTime", "http://hl7.org/fhir/data-types"), Description("dateTime")]
            DateTime,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("decimal", "http://hl7.org/fhir/data-types"), Description("decimal")]
            Decimal,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("id", "http://hl7.org/fhir/data-types"), Description("id")]
            Id,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("instant", "http://hl7.org/fhir/data-types"), Description("instant")]
            Instant,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("integer", "http://hl7.org/fhir/data-types"), Description("integer")]
            Integer,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("markdown", "http://hl7.org/fhir/data-types"), Description("markdown")]
            Markdown,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("oid", "http://hl7.org/fhir/data-types"), Description("oid")]
            Oid,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("positiveInt", "http://hl7.org/fhir/data-types"), Description("positiveInt")]
            PositiveInt,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("time", "http://hl7.org/fhir/data-types"), Description("time")]
            Time,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("unsignedInt", "http://hl7.org/fhir/data-types"), Description("unsignedInt")]
            UnsignedInt,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("uuid", "http://hl7.org/fhir/data-types"), Description("uuid")]
            Uuid,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("xhtml", "http://hl7.org/fhir/data-types"), Description("XHTML")]
            Xhtml,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Account", "http://hl7.org/fhir/resource-types"), Description("Account")]
            Account,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("AllergyIntolerance", "http://hl7.org/fhir/resource-types"), Description("AllergyIntolerance")]
            AllergyIntolerance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Appointment", "http://hl7.org/fhir/resource-types"), Description("Appointment")]
            Appointment,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("AppointmentResponse", "http://hl7.org/fhir/resource-types"), Description("AppointmentResponse")]
            AppointmentResponse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("AuditEvent", "http://hl7.org/fhir/resource-types"), Description("AuditEvent")]
            AuditEvent,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Basic", "http://hl7.org/fhir/resource-types"), Description("Basic")]
            Basic,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Binary", "http://hl7.org/fhir/resource-types"), Description("Binary")]
            Binary,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("BodySite", "http://hl7.org/fhir/resource-types"), Description("BodySite")]
            BodySite,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Bundle", "http://hl7.org/fhir/resource-types"), Description("Bundle")]
            Bundle,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("CarePlan", "http://hl7.org/fhir/resource-types"), Description("CarePlan")]
            CarePlan,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Claim", "http://hl7.org/fhir/resource-types"), Description("Claim")]
            Claim,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ClaimResponse", "http://hl7.org/fhir/resource-types"), Description("ClaimResponse")]
            ClaimResponse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ClinicalImpression", "http://hl7.org/fhir/resource-types"), Description("ClinicalImpression")]
            ClinicalImpression,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Communication", "http://hl7.org/fhir/resource-types"), Description("Communication")]
            Communication,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("CommunicationRequest", "http://hl7.org/fhir/resource-types"), Description("CommunicationRequest")]
            CommunicationRequest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Composition", "http://hl7.org/fhir/resource-types"), Description("Composition")]
            Composition,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ConceptMap", "http://hl7.org/fhir/resource-types"), Description("ConceptMap")]
            ConceptMap,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Condition", "http://hl7.org/fhir/resource-types"), Description("Condition")]
            Condition,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Conformance", "http://hl7.org/fhir/resource-types"), Description("Conformance")]
            Conformance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Contract", "http://hl7.org/fhir/resource-types"), Description("Contract")]
            Contract,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Coverage", "http://hl7.org/fhir/resource-types"), Description("Coverage")]
            Coverage,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DataElement", "http://hl7.org/fhir/resource-types"), Description("DataElement")]
            DataElement,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DetectedIssue", "http://hl7.org/fhir/resource-types"), Description("DetectedIssue")]
            DetectedIssue,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Device", "http://hl7.org/fhir/resource-types"), Description("Device")]
            Device,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DeviceComponent", "http://hl7.org/fhir/resource-types"), Description("DeviceComponent")]
            DeviceComponent,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DeviceMetric", "http://hl7.org/fhir/resource-types"), Description("DeviceMetric")]
            DeviceMetric,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DeviceUseRequest", "http://hl7.org/fhir/resource-types"), Description("DeviceUseRequest")]
            DeviceUseRequest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DeviceUseStatement", "http://hl7.org/fhir/resource-types"), Description("DeviceUseStatement")]
            DeviceUseStatement,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DiagnosticOrder", "http://hl7.org/fhir/resource-types"), Description("DiagnosticOrder")]
            DiagnosticOrder,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DiagnosticReport", "http://hl7.org/fhir/resource-types"), Description("DiagnosticReport")]
            DiagnosticReport,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DocumentManifest", "http://hl7.org/fhir/resource-types"), Description("DocumentManifest")]
            DocumentManifest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DocumentReference", "http://hl7.org/fhir/resource-types"), Description("DocumentReference")]
            DocumentReference,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("DomainResource", "http://hl7.org/fhir/resource-types"), Description("DomainResource")]
            DomainResource,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("EligibilityRequest", "http://hl7.org/fhir/resource-types"), Description("EligibilityRequest")]
            EligibilityRequest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("EligibilityResponse", "http://hl7.org/fhir/resource-types"), Description("EligibilityResponse")]
            EligibilityResponse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Encounter", "http://hl7.org/fhir/resource-types"), Description("Encounter")]
            Encounter,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("EnrollmentRequest", "http://hl7.org/fhir/resource-types"), Description("EnrollmentRequest")]
            EnrollmentRequest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("EnrollmentResponse", "http://hl7.org/fhir/resource-types"), Description("EnrollmentResponse")]
            EnrollmentResponse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("EpisodeOfCare", "http://hl7.org/fhir/resource-types"), Description("EpisodeOfCare")]
            EpisodeOfCare,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ExplanationOfBenefit", "http://hl7.org/fhir/resource-types"), Description("ExplanationOfBenefit")]
            ExplanationOfBenefit,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("FamilyMemberHistory", "http://hl7.org/fhir/resource-types"), Description("FamilyMemberHistory")]
            FamilyMemberHistory,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Flag", "http://hl7.org/fhir/resource-types"), Description("Flag")]
            Flag,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Goal", "http://hl7.org/fhir/resource-types"), Description("Goal")]
            Goal,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Group", "http://hl7.org/fhir/resource-types"), Description("Group")]
            Group,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("HealthcareService", "http://hl7.org/fhir/resource-types"), Description("HealthcareService")]
            HealthcareService,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ImagingObjectSelection", "http://hl7.org/fhir/resource-types"), Description("ImagingObjectSelection")]
            ImagingObjectSelection,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ImagingStudy", "http://hl7.org/fhir/resource-types"), Description("ImagingStudy")]
            ImagingStudy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Immunization", "http://hl7.org/fhir/resource-types"), Description("Immunization")]
            Immunization,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ImmunizationRecommendation", "http://hl7.org/fhir/resource-types"), Description("ImmunizationRecommendation")]
            ImmunizationRecommendation,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ImplementationGuide", "http://hl7.org/fhir/resource-types"), Description("ImplementationGuide")]
            ImplementationGuide,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("List", "http://hl7.org/fhir/resource-types"), Description("List")]
            List,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Location", "http://hl7.org/fhir/resource-types"), Description("Location")]
            Location,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Media", "http://hl7.org/fhir/resource-types"), Description("Media")]
            Media,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Medication", "http://hl7.org/fhir/resource-types"), Description("Medication")]
            Medication,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicationAdministration", "http://hl7.org/fhir/resource-types"), Description("MedicationAdministration")]
            MedicationAdministration,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicationDispense", "http://hl7.org/fhir/resource-types"), Description("MedicationDispense")]
            MedicationDispense,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicationOrder", "http://hl7.org/fhir/resource-types"), Description("MedicationOrder")]
            MedicationOrder,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicationStatement", "http://hl7.org/fhir/resource-types"), Description("MedicationStatement")]
            MedicationStatement,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MessageHeader", "http://hl7.org/fhir/resource-types"), Description("MessageHeader")]
            MessageHeader,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("NamingSystem", "http://hl7.org/fhir/resource-types"), Description("NamingSystem")]
            NamingSystem,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("NutritionOrder", "http://hl7.org/fhir/resource-types"), Description("NutritionOrder")]
            NutritionOrder,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Observation", "http://hl7.org/fhir/resource-types"), Description("Observation")]
            Observation,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("OperationDefinition", "http://hl7.org/fhir/resource-types"), Description("OperationDefinition")]
            OperationDefinition,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("OperationOutcome", "http://hl7.org/fhir/resource-types"), Description("OperationOutcome")]
            OperationOutcome,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Order", "http://hl7.org/fhir/resource-types"), Description("Order")]
            Order,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("OrderResponse", "http://hl7.org/fhir/resource-types"), Description("OrderResponse")]
            OrderResponse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Organization", "http://hl7.org/fhir/resource-types"), Description("Organization")]
            Organization,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Parameters", "http://hl7.org/fhir/resource-types"), Description("Parameters")]
            Parameters,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Patient", "http://hl7.org/fhir/resource-types"), Description("Patient")]
            Patient,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("PaymentNotice", "http://hl7.org/fhir/resource-types"), Description("PaymentNotice")]
            PaymentNotice,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("PaymentReconciliation", "http://hl7.org/fhir/resource-types"), Description("PaymentReconciliation")]
            PaymentReconciliation,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Person", "http://hl7.org/fhir/resource-types"), Description("Person")]
            Person,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Practitioner", "http://hl7.org/fhir/resource-types"), Description("Practitioner")]
            Practitioner,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Procedure", "http://hl7.org/fhir/resource-types"), Description("Procedure")]
            Procedure,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ProcedureRequest", "http://hl7.org/fhir/resource-types"), Description("ProcedureRequest")]
            ProcedureRequest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ProcessRequest", "http://hl7.org/fhir/resource-types"), Description("ProcessRequest")]
            ProcessRequest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ProcessResponse", "http://hl7.org/fhir/resource-types"), Description("ProcessResponse")]
            ProcessResponse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Provenance", "http://hl7.org/fhir/resource-types"), Description("Provenance")]
            Provenance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Questionnaire", "http://hl7.org/fhir/resource-types"), Description("Questionnaire")]
            Questionnaire,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("QuestionnaireResponse", "http://hl7.org/fhir/resource-types"), Description("QuestionnaireResponse")]
            QuestionnaireResponse,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ReferralRequest", "http://hl7.org/fhir/resource-types"), Description("ReferralRequest")]
            ReferralRequest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("RelatedPerson", "http://hl7.org/fhir/resource-types"), Description("RelatedPerson")]
            RelatedPerson,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Resource", "http://hl7.org/fhir/resource-types"), Description("Resource")]
            Resource,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("RiskAssessment", "http://hl7.org/fhir/resource-types"), Description("RiskAssessment")]
            RiskAssessment,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Schedule", "http://hl7.org/fhir/resource-types"), Description("Schedule")]
            Schedule,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("SearchParameter", "http://hl7.org/fhir/resource-types"), Description("SearchParameter")]
            SearchParameter,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Slot", "http://hl7.org/fhir/resource-types"), Description("Slot")]
            Slot,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Specimen", "http://hl7.org/fhir/resource-types"), Description("Specimen")]
            Specimen,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("StructureDefinition", "http://hl7.org/fhir/resource-types"), Description("StructureDefinition")]
            StructureDefinition,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Subscription", "http://hl7.org/fhir/resource-types"), Description("Subscription")]
            Subscription,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Substance", "http://hl7.org/fhir/resource-types"), Description("Substance")]
            Substance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("SupplyDelivery", "http://hl7.org/fhir/resource-types"), Description("SupplyDelivery")]
            SupplyDelivery,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("SupplyRequest", "http://hl7.org/fhir/resource-types"), Description("SupplyRequest")]
            SupplyRequest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("TestScript", "http://hl7.org/fhir/resource-types"), Description("TestScript")]
            TestScript,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ValueSet", "http://hl7.org/fhir/resource-types"), Description("ValueSet")]
            ValueSet,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("VisionPrescription", "http://hl7.org/fhir/resource-types"), Description("VisionPrescription")]
            VisionPrescription,
        }


        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }

            /// <summary>
            /// Name of a individual to contact
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name of a individual to contact
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new FhirString(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Contact details for individual or publisher
            /// </summary>
            [FhirElement("telecom", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContactPoint> Telecom
            {
                get { if (_telecom == null) _telecom = new List<ContactPoint>(); return _telecom; }
                set { _telecom = value; OnPropertyChanged("Telecom"); }
            }

            private List<ContactPoint> _telecom;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContactComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(Telecom, otherT.Telecom)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                }
            }


        }


        [FhirType("ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }

            /// <summary>
            /// Name in Parameters.parameter.name or in URL
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private Code _nameElement;

            /// <summary>
            /// Name in Parameters.parameter.name or in URL
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new Code(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// in | out
            /// </summary>
            [FhirElement("use", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<OperationParameterUse> UseElement
            {
                get { return _useElement; }
                set { _useElement = value; OnPropertyChanged("UseElement"); }
            }

            private Code<OperationParameterUse> _useElement;

            /// <summary>
            /// in | out
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public OperationParameterUse? Use
            {
                get { return UseElement != null ? UseElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        UseElement = null;
                    else
                        UseElement = new Code<OperationParameterUse>(value);
                    OnPropertyChanged("Use");
                }
            }

            /// <summary>
            /// Minimum Cardinality
            /// </summary>
            [FhirElement("min", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Integer MinElement
            {
                get { return _minElement; }
                set { _minElement = value; OnPropertyChanged("MinElement"); }
            }

            private Integer _minElement;

            /// <summary>
            /// Minimum Cardinality
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Min
            {
                get { return MinElement != null ? MinElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        MinElement = null;
                    else
                        MinElement = new Integer(value);
                    OnPropertyChanged("Min");
                }
            }

            /// <summary>
            /// Maximum Cardinality (a number or *)
            /// </summary>
            [FhirElement("max", Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString MaxElement
            {
                get { return _maxElement; }
                set { _maxElement = value; OnPropertyChanged("MaxElement"); }
            }

            private FhirString _maxElement;

            /// <summary>
            /// Maximum Cardinality (a number or *)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Max
            {
                get { return MaxElement != null ? MaxElement.Value : null; }
                set
                {
                    if (value == null)
                        MaxElement = null;
                    else
                        MaxElement = new FhirString(value);
                    OnPropertyChanged("Max");
                }
            }

            /// <summary>
            /// Description of meaning/use
            /// </summary>
            [FhirElement("documentation", Order=80)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Description of meaning/use
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            /// <summary>
            /// What type this parameter has
            /// </summary>
            [FhirElement("type", Order=90)]
            [DataMember]
            public Code TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code _typeElement;

            /// <summary>
            /// What type this parameter has
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Profile on the type
            /// </summary>
            [FhirElement("profile", Order=100)]
            [References("StructureDefinition")]
            [DataMember]
            public ResourceReference Profile
            {
                get { return _profile; }
                set { _profile = value; OnPropertyChanged("Profile"); }
            }

            private ResourceReference _profile;

            /// <summary>
            /// ValueSet details if this is coded
            /// </summary>
            [FhirElement("binding", Order=110)]
            [DataMember]
            public BindingComponent Binding
            {
                get { return _binding; }
                set { _binding = value; OnPropertyChanged("Binding"); }
            }

            private BindingComponent _binding;

            /// <summary>
            /// Parts of a Tuple Parameter
            /// </summary>
            [FhirElement("part", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParameterComponent> Part
            {
                get { if (_part == null) _part = new List<ParameterComponent>(); return _part; }
                set { _part = value; OnPropertyChanged("Part"); }
            }

            private List<ParameterComponent> _part;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParameterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (Code)NameElement.DeepCopy();
                    if (UseElement != null) dest.UseElement = (Code<OperationParameterUse>)UseElement.DeepCopy();
                    if (MinElement != null) dest.MinElement = (Integer)MinElement.DeepCopy();
                    if (MaxElement != null) dest.MaxElement = (FhirString)MaxElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code)TypeElement.DeepCopy();
                    if (Profile != null) dest.Profile = (ResourceReference)Profile.DeepCopy();
                    if (Binding != null) dest.Binding = (BindingComponent)Binding.DeepCopy();
                    if (Part != null) dest.Part = new List<ParameterComponent>(Part.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParameterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
                if (!DeepComparable.Matches(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.Matches(MaxElement, otherT.MaxElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(Profile, otherT.Profile)) return false;
                if (!DeepComparable.Matches(Binding, otherT.Binding)) return false;
                if (!DeepComparable.Matches(Part, otherT.Part)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
                if (!DeepComparable.IsExactly(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.IsExactly(MaxElement, otherT.MaxElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
                if (!DeepComparable.IsExactly(Binding, otherT.Binding)) return false;
                if (!DeepComparable.IsExactly(Part, otherT.Part)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (UseElement != null) yield return UseElement;
                    if (MinElement != null) yield return MinElement;
                    if (MaxElement != null) yield return MaxElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                    if (TypeElement != null) yield return TypeElement;
                    if (Profile != null) yield return Profile;
                    if (Binding != null) yield return Binding;
                    foreach (var elem in Part) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (UseElement != null) yield return new ElementValue("use", UseElement);
                    if (MinElement != null) yield return new ElementValue("min", MinElement);
                    if (MaxElement != null) yield return new ElementValue("max", MaxElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (Profile != null) yield return new ElementValue("profile", Profile);
                    if (Binding != null) yield return new ElementValue("binding", Binding);
                    foreach (var elem in Part) { if (elem != null) yield return new ElementValue("part", elem); }
                }
            }


        }


        [FhirType("BindingComponent")]
        [DataContract]
        public partial class BindingComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "BindingComponent"; } }

            /// <summary>
            /// required | extensible | preferred | example
            /// </summary>
            [FhirElement("strength", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<BindingStrength> StrengthElement
            {
                get { return _strengthElement; }
                set { _strengthElement = value; OnPropertyChanged("StrengthElement"); }
            }

            private Code<BindingStrength> _strengthElement;

            /// <summary>
            /// required | extensible | preferred | example
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public BindingStrength? Strength
            {
                get { return StrengthElement != null ? StrengthElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        StrengthElement = null;
                    else
                        StrengthElement = new Code<BindingStrength>(value);
                    OnPropertyChanged("Strength");
                }
            }

            /// <summary>
            /// Source of value set
            /// </summary>
            [FhirElement("valueSet", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirUri),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element ValueSet
            {
                get { return _valueSet; }
                set { _valueSet = value; OnPropertyChanged("ValueSet"); }
            }

            private Element _valueSet;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BindingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StrengthElement != null) dest.StrengthElement = (Code<BindingStrength>)StrengthElement.DeepCopy();
                    if (ValueSet != null) dest.ValueSet = (Element)ValueSet.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BindingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BindingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StrengthElement, otherT.StrengthElement)) return false;
                if (!DeepComparable.Matches(ValueSet, otherT.ValueSet)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BindingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StrengthElement, otherT.StrengthElement)) return false;
                if (!DeepComparable.IsExactly(ValueSet, otherT.ValueSet)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StrengthElement != null) yield return StrengthElement;
                    if (ValueSet != null) yield return ValueSet;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StrengthElement != null) yield return new ElementValue("strength", StrengthElement);
                    if (ValueSet != null) yield return new ElementValue("valueSet", ValueSet);
                }
            }


        }


        /// <summary>
        /// Logical URL to reference this operation definition
        /// </summary>
        [FhirElement("url", Order=90)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Logical URL to reference this operation definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                    UrlElement = null;
                else
                    UrlElement = new FhirUri(value);
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        /// Logical id for this version of the operation definition
        /// </summary>
        [FhirElement("version", Order=100)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Logical id for this version of the operation definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new FhirString(value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Informal name for this operation
        /// </summary>
        [FhirElement("name", Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Informal name for this operation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                    NameElement = null;
                else
                    NameElement = new FhirString(value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ConformanceResourceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ConformanceResourceStatus> _statusElement;

        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConformanceResourceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<ConformanceResourceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// operation | query
        /// </summary>
        [FhirElement("kind", Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<OperationKind> KindElement
        {
            get { return _kindElement; }
            set { _kindElement = value; OnPropertyChanged("KindElement"); }
        }

        private Code<OperationKind> _kindElement;

        /// <summary>
        /// operation | query
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public OperationKind? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    KindElement = null;
                else
                    KindElement = new Code<OperationKind>(value);
                OnPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", Order=140)]
        [DataMember]
        public FhirBoolean ExperimentalElement
        {
            get { return _experimentalElement; }
            set { _experimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }

        private FhirBoolean _experimentalElement;

        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }

        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=150)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                    PublisherElement = null;
                else
                    PublisherElement = new FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }

        /// <summary>
        /// Contact details of the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact == null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// Date for this version of the operation definition
        /// </summary>
        [FhirElement("date", Order=170)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date for this version of the operation definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Natural language description of the operation
        /// </summary>
        [FhirElement("description", Order=180)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Natural language description of the operation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new FhirString(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Why is this needed?
        /// </summary>
        [FhirElement("requirements", Order=190)]
        [DataMember]
        public FhirString RequirementsElement
        {
            get { return _requirementsElement; }
            set { _requirementsElement = value; OnPropertyChanged("RequirementsElement"); }
        }

        private FhirString _requirementsElement;

        /// <summary>
        /// Why is this needed?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Requirements
        {
            get { return RequirementsElement != null ? RequirementsElement.Value : null; }
            set
            {
                if (value == null)
                    RequirementsElement = null;
                else
                    RequirementsElement = new FhirString(value);
                OnPropertyChanged("Requirements");
            }
        }

        /// <summary>
        /// Whether content is unchanged by operation
        /// </summary>
        [FhirElement("idempotent", Order=200)]
        [DataMember]
        public FhirBoolean IdempotentElement
        {
            get { return _idempotentElement; }
            set { _idempotentElement = value; OnPropertyChanged("IdempotentElement"); }
        }

        private FhirBoolean _idempotentElement;

        /// <summary>
        /// Whether content is unchanged by operation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Idempotent
        {
            get { return IdempotentElement != null ? IdempotentElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    IdempotentElement = null;
                else
                    IdempotentElement = new FhirBoolean(value);
                OnPropertyChanged("Idempotent");
            }
        }

        /// <summary>
        /// Name used to invoke the operation
        /// </summary>
        [FhirElement("code", Order=210)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code CodeElement
        {
            get { return _codeElement; }
            set { _codeElement = value; OnPropertyChanged("CodeElement"); }
        }

        private Code _codeElement;

        /// <summary>
        /// Name used to invoke the operation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Code
        {
            get { return CodeElement != null ? CodeElement.Value : null; }
            set
            {
                if (value == null)
                    CodeElement = null;
                else
                    CodeElement = new Code(value);
                OnPropertyChanged("Code");
            }
        }

        /// <summary>
        /// Additional information about use
        /// </summary>
        [FhirElement("notes", Order=220)]
        [DataMember]
        public FhirString NotesElement
        {
            get { return _notesElement; }
            set { _notesElement = value; OnPropertyChanged("NotesElement"); }
        }

        private FhirString _notesElement;

        /// <summary>
        /// Additional information about use
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Notes
        {
            get { return NotesElement != null ? NotesElement.Value : null; }
            set
            {
                if (value == null)
                    NotesElement = null;
                else
                    NotesElement = new FhirString(value);
                OnPropertyChanged("Notes");
            }
        }

        /// <summary>
        /// Marks this as a profile of the base
        /// </summary>
        [FhirElement("base", Order=230)]
        [References("OperationDefinition")]
        [DataMember]
        public ResourceReference Base
        {
            get { return _base; }
            set { _base = value; OnPropertyChanged("Base"); }
        }

        private ResourceReference _base;

        /// <summary>
        /// Invoke at the system level?
        /// </summary>
        [FhirElement("system", Order=240)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirBoolean SystemElement
        {
            get { return _systemElement; }
            set { _systemElement = value; OnPropertyChanged("SystemElement"); }
        }

        private FhirBoolean _systemElement;

        /// <summary>
        /// Invoke at the system level?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? System
        {
            get { return SystemElement != null ? SystemElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    SystemElement = null;
                else
                    SystemElement = new FhirBoolean(value);
                OnPropertyChanged("System");
            }
        }

        /// <summary>
        /// Invoke at resource level for these type
        /// </summary>
        [FhirElement("type", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<ResourceType>> TypeElement
        {
            get { if (_typeElement == null) _typeElement = new List<Code<ResourceType>>(); return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private List<Code<ResourceType>> _typeElement;

        /// <summary>
        /// Invoke at resource level for these type
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<ResourceType?> Type
        {
            get { return TypeElement != null ? TypeElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new List<Code<ResourceType>>(value.Select(elem=>new Code<ResourceType>(elem)));
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Invoke on an instance?
        /// </summary>
        [FhirElement("instance", Order=260)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirBoolean InstanceElement
        {
            get { return _instanceElement; }
            set { _instanceElement = value; OnPropertyChanged("InstanceElement"); }
        }

        private FhirBoolean _instanceElement;

        /// <summary>
        /// Invoke on an instance?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Instance
        {
            get { return InstanceElement != null ? InstanceElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    InstanceElement = null;
                else
                    InstanceElement = new FhirBoolean(value);
                OnPropertyChanged("Instance");
            }
        }

        /// <summary>
        /// Parameters for the operation/query
        /// </summary>
        [FhirElement("parameter", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParameterComponent> Parameter
        {
            get { if (_parameter == null) _parameter = new List<ParameterComponent>(); return _parameter; }
            set { _parameter = value; OnPropertyChanged("Parameter"); }
        }

        private List<ParameterComponent> _parameter;


        public static ElementDefinition.ConstraintComponent OperationDefinition_OPD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "parameter.all(type or part)",
            Key = "opd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Either a type must be provided, or parts",
            Xpath = "exists(f:type) or exists(f:part)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(OperationDefinition_OPD_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as OperationDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ConformanceResourceStatus>)StatusElement.DeepCopy();
                if (KindElement != null) dest.KindElement = (Code<OperationKind>)KindElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (RequirementsElement != null) dest.RequirementsElement = (FhirString)RequirementsElement.DeepCopy();
                if (IdempotentElement != null) dest.IdempotentElement = (FhirBoolean)IdempotentElement.DeepCopy();
                if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                if (NotesElement != null) dest.NotesElement = (FhirString)NotesElement.DeepCopy();
                if (Base != null) dest.Base = (ResourceReference)Base.DeepCopy();
                if (SystemElement != null) dest.SystemElement = (FhirBoolean)SystemElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = new List<Code<ResourceType>>(TypeElement.DeepCopy());
                if (InstanceElement != null) dest.InstanceElement = (FhirBoolean)InstanceElement.DeepCopy();
                if (Parameter != null) dest.Parameter = new List<ParameterComponent>(Parameter.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new OperationDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as OperationDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.Matches(IdempotentElement, otherT.IdempotentElement)) return false;
            if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
            if (!DeepComparable.Matches(NotesElement, otherT.NotesElement)) return false;
            if (!DeepComparable.Matches(Base, otherT.Base)) return false;
            if (!DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(InstanceElement, otherT.InstanceElement)) return false;
            if (!DeepComparable.Matches(Parameter, otherT.Parameter)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as OperationDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.IsExactly(IdempotentElement, otherT.IdempotentElement)) return false;
            if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
            if (!DeepComparable.IsExactly(NotesElement, otherT.NotesElement)) return false;
            if (!DeepComparable.IsExactly(Base, otherT.Base)) return false;
            if (!DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(InstanceElement, otherT.InstanceElement)) return false;
            if (!DeepComparable.IsExactly(Parameter, otherT.Parameter)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (StatusElement != null) yield return StatusElement;
                if (KindElement != null) yield return KindElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DateElement != null) yield return DateElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                if (RequirementsElement != null) yield return RequirementsElement;
                if (IdempotentElement != null) yield return IdempotentElement;
                if (CodeElement != null) yield return CodeElement;
                if (NotesElement != null) yield return NotesElement;
                if (Base != null) yield return Base;
                if (SystemElement != null) yield return SystemElement;
                foreach (var elem in TypeElement) { if (elem != null) yield return elem; }
                if (InstanceElement != null) yield return InstanceElement;
                foreach (var elem in Parameter) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (KindElement != null) yield return new ElementValue("kind", KindElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (RequirementsElement != null) yield return new ElementValue("requirements", RequirementsElement);
                if (IdempotentElement != null) yield return new ElementValue("idempotent", IdempotentElement);
                if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                if (NotesElement != null) yield return new ElementValue("notes", NotesElement);
                if (Base != null) yield return new ElementValue("base", Base);
                if (SystemElement != null) yield return new ElementValue("system", SystemElement);
                foreach (var elem in TypeElement) { if (elem != null) yield return new ElementValue("type", elem); }
                if (InstanceElement != null) yield return new ElementValue("instance", InstanceElement);
                foreach (var elem in Parameter) { if (elem != null) yield return new ElementValue("parameter", elem); }
            }
        }

    }

}
