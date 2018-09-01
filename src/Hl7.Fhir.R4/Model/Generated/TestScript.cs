using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using Hl7.Fhir.Validation.R4;
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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Describes a set of tests
    /// </summary>
    [FhirType("TestScript", IsResource=true)]
    [DataContract]
    public partial class TestScript : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.TestScript; } }
        [NotMapped]
        public override string TypeName { get { return "TestScript"; } }

        /// <summary>
        /// A list of all the concrete types defined in this version of the FHIR specification - Data Types and Resource Types.
        /// (url: http://hl7.org/fhir/ValueSet/defined-types)
        /// </summary>
        [FhirEnumeration("FHIRDefinedType")]
        public enum FHIRDefinedType
        {
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
            [EnumLiteral("ContactDetail", "http://hl7.org/fhir/data-types"), Description("ContactDetail")]
            ContactDetail,
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
            [EnumLiteral("Contributor", "http://hl7.org/fhir/data-types"), Description("Contributor")]
            Contributor,
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
            [EnumLiteral("DataRequirement", "http://hl7.org/fhir/data-types"), Description("DataRequirement")]
            DataRequirement,
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
            [EnumLiteral("Dosage", "http://hl7.org/fhir/data-types"), Description("Dosage")]
            Dosage,
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
            [EnumLiteral("Expression", "http://hl7.org/fhir/data-types"), Description("Expression")]
            Expression,
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
            [EnumLiteral("MarketingStatus", "http://hl7.org/fhir/data-types"), Description("MarketingStatus")]
            MarketingStatus,
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
            [EnumLiteral("MoneyQuantity", "http://hl7.org/fhir/data-types"), Description("MoneyQuantity")]
            MoneyQuantity,
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
            [EnumLiteral("ParameterDefinition", "http://hl7.org/fhir/data-types"), Description("ParameterDefinition")]
            ParameterDefinition,
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
            [EnumLiteral("ProdCharacteristic", "http://hl7.org/fhir/data-types"), Description("ProdCharacteristic")]
            ProdCharacteristic,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("ProductShelfLife", "http://hl7.org/fhir/data-types"), Description("ProductShelfLife")]
            ProductShelfLife,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("Quantity", "http://hl7.org/fhir/data-types"), Description("Quantity")]
            Quantity,
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
            [EnumLiteral("Reference", "http://hl7.org/fhir/data-types"), Description("Reference")]
            Reference,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("RelatedArtifact", "http://hl7.org/fhir/data-types"), Description("RelatedArtifact")]
            RelatedArtifact,
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
            [EnumLiteral("SubstanceAmount", "http://hl7.org/fhir/data-types"), Description("SubstanceAmount")]
            SubstanceAmount,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("SubstanceMoiety", "http://hl7.org/fhir/data-types"), Description("SubstanceMoiety")]
            SubstanceMoiety,
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
            [EnumLiteral("TriggerDefinition", "http://hl7.org/fhir/data-types"), Description("TriggerDefinition")]
            TriggerDefinition,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("UsageContext", "http://hl7.org/fhir/data-types"), Description("UsageContext")]
            UsageContext,
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
            [EnumLiteral("canonical", "http://hl7.org/fhir/data-types"), Description("canonical")]
            Canonical,
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
            [EnumLiteral("date", "http://hl7.org/fhir/data-types"), Description("date")]
            Date,
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
            [EnumLiteral("string", "http://hl7.org/fhir/data-types"), Description("string")]
            String,
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
            [EnumLiteral("uri", "http://hl7.org/fhir/data-types"), Description("uri")]
            Uri,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/data-types)
            /// </summary>
            [EnumLiteral("url", "http://hl7.org/fhir/data-types"), Description("url")]
            Url,
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
            [EnumLiteral("ActivityDefinition", "http://hl7.org/fhir/resource-types"), Description("ActivityDefinition")]
            ActivityDefinition,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("AdverseEvent", "http://hl7.org/fhir/resource-types"), Description("AdverseEvent")]
            AdverseEvent,
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
            [EnumLiteral("BiologicallyDerivedProduct", "http://hl7.org/fhir/resource-types"), Description("BiologicallyDerivedProduct")]
            BiologicallyDerivedProduct,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("BodyStructure", "http://hl7.org/fhir/resource-types"), Description("BodyStructure")]
            BodyStructure,
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
            [EnumLiteral("CapabilityStatement", "http://hl7.org/fhir/resource-types"), Description("CapabilityStatement")]
            CapabilityStatement,
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
            [EnumLiteral("CareTeam", "http://hl7.org/fhir/resource-types"), Description("CareTeam")]
            CareTeam,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ChargeItem", "http://hl7.org/fhir/resource-types"), Description("ChargeItem")]
            ChargeItem,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ChargeItemDefinition", "http://hl7.org/fhir/resource-types"), Description("ChargeItemDefinition")]
            ChargeItemDefinition,
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
            [EnumLiteral("CodeSystem", "http://hl7.org/fhir/resource-types"), Description("CodeSystem")]
            CodeSystem,
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
            [EnumLiteral("CompartmentDefinition", "http://hl7.org/fhir/resource-types"), Description("CompartmentDefinition")]
            CompartmentDefinition,
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
            [EnumLiteral("Consent", "http://hl7.org/fhir/resource-types"), Description("Consent")]
            Consent,
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
            [EnumLiteral("CoverageEligibilityRequest", "http://hl7.org/fhir/resource-types"), Description("CoverageEligibilityRequest")]
            CoverageEligibilityRequest,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("CoverageEligibilityResponse", "http://hl7.org/fhir/resource-types"), Description("CoverageEligibilityResponse")]
            CoverageEligibilityResponse,
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
            [EnumLiteral("DeviceDefinition", "http://hl7.org/fhir/resource-types"), Description("DeviceDefinition")]
            DeviceDefinition,
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
            [EnumLiteral("DeviceRequest", "http://hl7.org/fhir/resource-types"), Description("DeviceRequest")]
            DeviceRequest,
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
            [EnumLiteral("Encounter", "http://hl7.org/fhir/resource-types"), Description("Encounter")]
            Encounter,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Endpoint", "http://hl7.org/fhir/resource-types"), Description("Endpoint")]
            Endpoint,
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
            [EnumLiteral("EntryDefinition", "http://hl7.org/fhir/resource-types"), Description("EntryDefinition")]
            EntryDefinition,
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
            [EnumLiteral("EventDefinition", "http://hl7.org/fhir/resource-types"), Description("EventDefinition")]
            EventDefinition,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ExampleScenario", "http://hl7.org/fhir/resource-types"), Description("ExampleScenario")]
            ExampleScenario,
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
            [EnumLiteral("GraphDefinition", "http://hl7.org/fhir/resource-types"), Description("GraphDefinition")]
            GraphDefinition,
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
            [EnumLiteral("GuidanceResponse", "http://hl7.org/fhir/resource-types"), Description("GuidanceResponse")]
            GuidanceResponse,
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
            [EnumLiteral("ImmunizationEvaluation", "http://hl7.org/fhir/resource-types"), Description("ImmunizationEvaluation")]
            ImmunizationEvaluation,
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
            [EnumLiteral("InsurancePlan", "http://hl7.org/fhir/resource-types"), Description("InsurancePlan")]
            InsurancePlan,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Invoice", "http://hl7.org/fhir/resource-types"), Description("Invoice")]
            Invoice,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ItemInstance", "http://hl7.org/fhir/resource-types"), Description("ItemInstance")]
            ItemInstance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Library", "http://hl7.org/fhir/resource-types"), Description("Library")]
            Library,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("Linkage", "http://hl7.org/fhir/resource-types"), Description("Linkage")]
            Linkage,
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
            [EnumLiteral("Measure", "http://hl7.org/fhir/resource-types"), Description("Measure")]
            Measure,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MeasureReport", "http://hl7.org/fhir/resource-types"), Description("MeasureReport")]
            MeasureReport,
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
            [EnumLiteral("MedicationKnowledge", "http://hl7.org/fhir/resource-types"), Description("MedicationKnowledge")]
            MedicationKnowledge,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicationRequest", "http://hl7.org/fhir/resource-types"), Description("MedicationRequest")]
            MedicationRequest,
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
            [EnumLiteral("MedicinalProduct", "http://hl7.org/fhir/resource-types"), Description("MedicinalProduct")]
            MedicinalProduct,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductAuthorization", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductAuthorization")]
            MedicinalProductAuthorization,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductClinicals", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductClinicals")]
            MedicinalProductClinicals,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductContraindication", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductContraindication")]
            MedicinalProductContraindication,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductDeviceSpec", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductDeviceSpec")]
            MedicinalProductDeviceSpec,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductIndication", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductIndication")]
            MedicinalProductIndication,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductIngredient", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductIngredient")]
            MedicinalProductIngredient,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductInteraction", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductInteraction")]
            MedicinalProductInteraction,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductManufactured", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductManufactured")]
            MedicinalProductManufactured,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductPackaged", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductPackaged")]
            MedicinalProductPackaged,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductPharmaceutical", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductPharmaceutical")]
            MedicinalProductPharmaceutical,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MedicinalProductUndesirableEffect", "http://hl7.org/fhir/resource-types"), Description("MedicinalProductUndesirableEffect")]
            MedicinalProductUndesirableEffect,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("MessageDefinition", "http://hl7.org/fhir/resource-types"), Description("MessageDefinition")]
            MessageDefinition,
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
            [EnumLiteral("ObservationDefinition", "http://hl7.org/fhir/resource-types"), Description("ObservationDefinition")]
            ObservationDefinition,
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
            [EnumLiteral("Organization", "http://hl7.org/fhir/resource-types"), Description("Organization")]
            Organization,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("OrganizationAffiliation", "http://hl7.org/fhir/resource-types"), Description("OrganizationAffiliation")]
            OrganizationAffiliation,
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
            [EnumLiteral("PlanDefinition", "http://hl7.org/fhir/resource-types"), Description("PlanDefinition")]
            PlanDefinition,
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
            [EnumLiteral("PractitionerRole", "http://hl7.org/fhir/resource-types"), Description("PractitionerRole")]
            PractitionerRole,
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
            [EnumLiteral("RelatedPerson", "http://hl7.org/fhir/resource-types"), Description("RelatedPerson")]
            RelatedPerson,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("RequestGroup", "http://hl7.org/fhir/resource-types"), Description("RequestGroup")]
            RequestGroup,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ResearchStudy", "http://hl7.org/fhir/resource-types"), Description("ResearchStudy")]
            ResearchStudy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ResearchSubject", "http://hl7.org/fhir/resource-types"), Description("ResearchSubject")]
            ResearchSubject,
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
            [EnumLiteral("Sequence", "http://hl7.org/fhir/resource-types"), Description("Sequence")]
            Sequence,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("ServiceRequest", "http://hl7.org/fhir/resource-types"), Description("ServiceRequest")]
            ServiceRequest,
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
            [EnumLiteral("SpecimenDefinition", "http://hl7.org/fhir/resource-types"), Description("SpecimenDefinition")]
            SpecimenDefinition,
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
            [EnumLiteral("StructureMap", "http://hl7.org/fhir/resource-types"), Description("StructureMap")]
            StructureMap,
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
            [EnumLiteral("SubstancePolymer", "http://hl7.org/fhir/resource-types"), Description("SubstancePolymer")]
            SubstancePolymer,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("SubstanceReferenceInformation", "http://hl7.org/fhir/resource-types"), Description("SubstanceReferenceInformation")]
            SubstanceReferenceInformation,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("SubstanceSpecification", "http://hl7.org/fhir/resource-types"), Description("SubstanceSpecification")]
            SubstanceSpecification,
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
            [EnumLiteral("Task", "http://hl7.org/fhir/resource-types"), Description("Task")]
            Task,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("TerminologyCapabilities", "http://hl7.org/fhir/resource-types"), Description("TerminologyCapabilities")]
            TerminologyCapabilities,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("TestReport", "http://hl7.org/fhir/resource-types"), Description("TestReport")]
            TestReport,
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
            [EnumLiteral("UserSession", "http://hl7.org/fhir/resource-types"), Description("UserSession")]
            UserSession,
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
            [EnumLiteral("VerificationResult", "http://hl7.org/fhir/resource-types"), Description("VerificationResult")]
            VerificationResult,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/resource-types)
            /// </summary>
            [EnumLiteral("VisionPrescription", "http://hl7.org/fhir/resource-types"), Description("VisionPrescription")]
            VisionPrescription,
        }

        /// <summary>
        /// The type of direction to use for assertion.
        /// (url: http://hl7.org/fhir/ValueSet/assert-direction-codes)
        /// </summary>
        [FhirEnumeration("AssertionDirectionType")]
        public enum AssertionDirectionType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-direction-codes)
            /// </summary>
            [EnumLiteral("response", "http://hl7.org/fhir/assert-direction-codes"), Description("response")]
            Response,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-direction-codes)
            /// </summary>
            [EnumLiteral("request", "http://hl7.org/fhir/assert-direction-codes"), Description("request")]
            Request,
        }

        /// <summary>
        /// The type of operator to use for assertion.
        /// (url: http://hl7.org/fhir/ValueSet/assert-operator-codes)
        /// </summary>
        [FhirEnumeration("AssertionOperatorType")]
        public enum AssertionOperatorType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("equals", "http://hl7.org/fhir/assert-operator-codes"), Description("equals")]
            Equals,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notEquals", "http://hl7.org/fhir/assert-operator-codes"), Description("notEquals")]
            NotEquals,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("in", "http://hl7.org/fhir/assert-operator-codes"), Description("in")]
            In,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notIn", "http://hl7.org/fhir/assert-operator-codes"), Description("notIn")]
            NotIn,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("greaterThan", "http://hl7.org/fhir/assert-operator-codes"), Description("greaterThan")]
            GreaterThan,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("lessThan", "http://hl7.org/fhir/assert-operator-codes"), Description("lessThan")]
            LessThan,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("empty", "http://hl7.org/fhir/assert-operator-codes"), Description("empty")]
            Empty,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notEmpty", "http://hl7.org/fhir/assert-operator-codes"), Description("notEmpty")]
            NotEmpty,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("contains", "http://hl7.org/fhir/assert-operator-codes"), Description("contains")]
            Contains,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("notContains", "http://hl7.org/fhir/assert-operator-codes"), Description("notContains")]
            NotContains,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-operator-codes)
            /// </summary>
            [EnumLiteral("eval", "http://hl7.org/fhir/assert-operator-codes"), Description("evaluate")]
            Eval,
        }

        /// <summary>
        /// The allowable request method or HTTP operation codes.
        /// (url: http://hl7.org/fhir/ValueSet/http-operations)
        /// </summary>
        [FhirEnumeration("TestScriptRequestMethodCode")]
        public enum TestScriptRequestMethodCode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-operations)
            /// </summary>
            [EnumLiteral("delete", "http://hl7.org/fhir/http-operations"), Description("DELETE")]
            Delete,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-operations)
            /// </summary>
            [EnumLiteral("get", "http://hl7.org/fhir/http-operations"), Description("GET")]
            Get,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-operations)
            /// </summary>
            [EnumLiteral("options", "http://hl7.org/fhir/http-operations"), Description("OPTIONS")]
            Options,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-operations)
            /// </summary>
            [EnumLiteral("patch", "http://hl7.org/fhir/http-operations"), Description("PATCH")]
            Patch,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-operations)
            /// </summary>
            [EnumLiteral("post", "http://hl7.org/fhir/http-operations"), Description("POST")]
            Post,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/http-operations)
            /// </summary>
            [EnumLiteral("put", "http://hl7.org/fhir/http-operations"), Description("PUT")]
            Put,
        }

        /// <summary>
        /// The type of response code to use for assertion.
        /// (url: http://hl7.org/fhir/ValueSet/assert-response-code-types)
        /// </summary>
        [FhirEnumeration("AssertionResponseTypes")]
        public enum AssertionResponseTypes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("okay", "http://hl7.org/fhir/assert-response-code-types"), Description("okay")]
            Okay,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("created", "http://hl7.org/fhir/assert-response-code-types"), Description("created")]
            Created,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("noContent", "http://hl7.org/fhir/assert-response-code-types"), Description("noContent")]
            NoContent,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("notModified", "http://hl7.org/fhir/assert-response-code-types"), Description("notModified")]
            NotModified,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("bad", "http://hl7.org/fhir/assert-response-code-types"), Description("bad")]
            Bad,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("forbidden", "http://hl7.org/fhir/assert-response-code-types"), Description("forbidden")]
            Forbidden,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("notFound", "http://hl7.org/fhir/assert-response-code-types"), Description("notFound")]
            NotFound,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("methodNotAllowed", "http://hl7.org/fhir/assert-response-code-types"), Description("methodNotAllowed")]
            MethodNotAllowed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("conflict", "http://hl7.org/fhir/assert-response-code-types"), Description("conflict")]
            Conflict,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("gone", "http://hl7.org/fhir/assert-response-code-types"), Description("gone")]
            Gone,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("preconditionFailed", "http://hl7.org/fhir/assert-response-code-types"), Description("preconditionFailed")]
            PreconditionFailed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/assert-response-code-types)
            /// </summary>
            [EnumLiteral("unprocessable", "http://hl7.org/fhir/assert-response-code-types"), Description("unprocessable")]
            Unprocessable,
        }


        [FhirType("OriginComponent")]
        [DataContract]
        public partial class OriginComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OriginComponent"; } }

            /// <summary>
            /// The index of the abstract origin server starting at 1
            /// </summary>
            [FhirElement("index", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Integer IndexElement
            {
                get { return _indexElement; }
                set { _indexElement = value; OnPropertyChanged("IndexElement"); }
            }

            private Integer _indexElement;

            /// <summary>
            /// The index of the abstract origin server starting at 1
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Index
            {
                get { return IndexElement != null ? IndexElement.Value : null; }
                set
                {
                    if (value == null)
                        IndexElement = null;
                    else
                        IndexElement = new Integer(value);
                    OnPropertyChanged("Index");
                }
            }

            /// <summary>
            /// FHIR-Client | FHIR-SDC-FormFiller
            /// </summary>
            [FhirElement("profile", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Profile
            {
                get { return _profile; }
                set { _profile = value; OnPropertyChanged("Profile"); }
            }

            private Coding _profile;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OriginComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (IndexElement != null) dest.IndexElement = (Integer)IndexElement.DeepCopy();
                    if (Profile != null) dest.Profile = (Coding)Profile.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OriginComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OriginComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(IndexElement, otherT.IndexElement)) return false;
                if (!DeepComparable.Matches(Profile, otherT.Profile)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OriginComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(IndexElement, otherT.IndexElement)) return false;
                if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (IndexElement != null) yield return IndexElement;
                    if (Profile != null) yield return Profile;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IndexElement != null) yield return new ElementValue("index", IndexElement);
                    if (Profile != null) yield return new ElementValue("profile", Profile);
                }
            }


        }


        [FhirType("DestinationComponent")]
        [DataContract]
        public partial class DestinationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DestinationComponent"; } }

            /// <summary>
            /// The index of the abstract destination server starting at 1
            /// </summary>
            [FhirElement("index", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Integer IndexElement
            {
                get { return _indexElement; }
                set { _indexElement = value; OnPropertyChanged("IndexElement"); }
            }

            private Integer _indexElement;

            /// <summary>
            /// The index of the abstract destination server starting at 1
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Index
            {
                get { return IndexElement != null ? IndexElement.Value : null; }
                set
                {
                    if (value == null)
                        IndexElement = null;
                    else
                        IndexElement = new Integer(value);
                    OnPropertyChanged("Index");
                }
            }

            /// <summary>
            /// FHIR-Server | FHIR-SDC-FormManager | FHIR-SDC-FormReceiver | FHIR-SDC-FormProcessor
            /// </summary>
            [FhirElement("profile", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Profile
            {
                get { return _profile; }
                set { _profile = value; OnPropertyChanged("Profile"); }
            }

            private Coding _profile;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DestinationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (IndexElement != null) dest.IndexElement = (Integer)IndexElement.DeepCopy();
                    if (Profile != null) dest.Profile = (Coding)Profile.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DestinationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DestinationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(IndexElement, otherT.IndexElement)) return false;
                if (!DeepComparable.Matches(Profile, otherT.Profile)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DestinationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(IndexElement, otherT.IndexElement)) return false;
                if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (IndexElement != null) yield return IndexElement;
                    if (Profile != null) yield return Profile;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IndexElement != null) yield return new ElementValue("index", IndexElement);
                    if (Profile != null) yield return new ElementValue("profile", Profile);
                }
            }


        }


        [FhirType("MetadataComponent")]
        [DataContract]
        public partial class MetadataComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MetadataComponent"; } }

            /// <summary>
            /// Links to the FHIR specification
            /// </summary>
            [FhirElement("link", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<LinkComponent> Link
            {
                get { if (_link==null) _link = new List<LinkComponent>(); return _link; }
                set { _link = value; OnPropertyChanged("Link"); }
            }

            private List<LinkComponent> _link;

            /// <summary>
            /// Capabilities  that are assumed to function correctly on the FHIR server being tested
            /// </summary>
            [FhirElement("capability", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<CapabilityComponent> Capability
            {
                get { if (_capability==null) _capability = new List<CapabilityComponent>(); return _capability; }
                set { _capability = value; OnPropertyChanged("Capability"); }
            }

            private List<CapabilityComponent> _capability;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MetadataComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Link != null) dest.Link = new List<LinkComponent>(Link.DeepCopy());
                    if (Capability != null) dest.Capability = new List<CapabilityComponent>(Capability.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MetadataComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MetadataComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Link, otherT.Link)) return false;
                if ( !DeepComparable.Matches(Capability, otherT.Capability)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MetadataComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Link, otherT.Link)) return false;
                if (!DeepComparable.IsExactly(Capability, otherT.Capability)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Link) { if (elem != null) yield return elem; }
                    foreach (var elem in Capability) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Link) { if (elem != null) yield return new ElementValue("link", elem); }
                    foreach (var elem in Capability) { if (elem != null) yield return new ElementValue("capability", elem); }
                }
            }


        }


        [FhirType("LinkComponent")]
        [DataContract]
        public partial class LinkComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LinkComponent"; } }

            /// <summary>
            /// URL to the specification
            /// </summary>
            [FhirElement("url", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// URL to the specification
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
            /// Short description
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Short description
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LinkComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LinkComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (UrlElement != null) yield return UrlElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                }
            }


        }


        [FhirType("CapabilityComponent")]
        [DataContract]
        public partial class CapabilityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CapabilityComponent"; } }

            /// <summary>
            /// Are the capabilities required?
            /// </summary>
            [FhirElement("required", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean RequiredElement
            {
                get { return _requiredElement; }
                set { _requiredElement = value; OnPropertyChanged("RequiredElement"); }
            }

            private FhirBoolean _requiredElement;

            /// <summary>
            /// Are the capabilities required?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Required
            {
                get { return RequiredElement != null ? RequiredElement.Value : null; }
                set
                {
                    if (value == null)
                        RequiredElement = null;
                    else
                        RequiredElement = new FhirBoolean(value);
                    OnPropertyChanged("Required");
                }
            }

            /// <summary>
            /// Are the capabilities validated?
            /// </summary>
            [FhirElement("validated", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean ValidatedElement
            {
                get { return _validatedElement; }
                set { _validatedElement = value; OnPropertyChanged("ValidatedElement"); }
            }

            private FhirBoolean _validatedElement;

            /// <summary>
            /// Are the capabilities validated?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Validated
            {
                get { return ValidatedElement != null ? ValidatedElement.Value : null; }
                set
                {
                    if (value == null)
                        ValidatedElement = null;
                    else
                        ValidatedElement = new FhirBoolean(value);
                    OnPropertyChanged("Validated");
                }
            }

            /// <summary>
            /// The expected capabilities of the server
            /// </summary>
            [FhirElement("description", Order=60)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// The expected capabilities of the server
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
            /// Which origin server these requirements apply to
            /// </summary>
            [FhirElement("origin", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Integer> OriginElement
            {
                get { if (_originElement==null) _originElement = new List<Integer>(); return _originElement; }
                set { _originElement = value; OnPropertyChanged("OriginElement"); }
            }

            private List<Integer> _originElement;

            /// <summary>
            /// Which origin server these requirements apply to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> Origin
            {
                get { return OriginElement != null ? OriginElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        OriginElement = null;
                    else
                        OriginElement = new List<Integer>(value.Select(elem=>new Integer(elem)));
                    OnPropertyChanged("Origin");
                }
            }

            /// <summary>
            /// Which server these requirements apply to
            /// </summary>
            [FhirElement("destination", Order=80)]
            [DataMember]
            public Integer DestinationElement
            {
                get { return _destinationElement; }
                set { _destinationElement = value; OnPropertyChanged("DestinationElement"); }
            }

            private Integer _destinationElement;

            /// <summary>
            /// Which server these requirements apply to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Destination
            {
                get { return DestinationElement != null ? DestinationElement.Value : null; }
                set
                {
                    if (value == null)
                        DestinationElement = null;
                    else
                        DestinationElement = new Integer(value);
                    OnPropertyChanged("Destination");
                }
            }

            /// <summary>
            /// Links to the FHIR specification
            /// </summary>
            [FhirElement("link", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirUri> LinkElement
            {
                get { if (_linkElement==null) _linkElement = new List<FhirUri>(); return _linkElement; }
                set { _linkElement = value; OnPropertyChanged("LinkElement"); }
            }

            private List<FhirUri> _linkElement;

            /// <summary>
            /// Links to the FHIR specification
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Link
            {
                get { return LinkElement != null ? LinkElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        LinkElement = null;
                    else
                        LinkElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                    OnPropertyChanged("Link");
                }
            }

            /// <summary>
            /// Required Capability Statement
            /// </summary>
            [FhirElement("capabilities", Order=100)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Canonical CapabilitiesElement
            {
                get { return _capabilitiesElement; }
                set { _capabilitiesElement = value; OnPropertyChanged("CapabilitiesElement"); }
            }

            private Canonical _capabilitiesElement;

            /// <summary>
            /// Required Capability Statement
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Capabilities
            {
                get { return CapabilitiesElement != null ? CapabilitiesElement.Value : null; }
                set
                {
                    if (value == null)
                        CapabilitiesElement = null;
                    else
                        CapabilitiesElement = new Canonical(value);
                    OnPropertyChanged("Capabilities");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CapabilityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RequiredElement != null) dest.RequiredElement = (FhirBoolean)RequiredElement.DeepCopy();
                    if (ValidatedElement != null) dest.ValidatedElement = (FhirBoolean)ValidatedElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (OriginElement != null) dest.OriginElement = new List<Integer>(OriginElement.DeepCopy());
                    if (DestinationElement != null) dest.DestinationElement = (Integer)DestinationElement.DeepCopy();
                    if (LinkElement != null) dest.LinkElement = new List<FhirUri>(LinkElement.DeepCopy());
                    if (CapabilitiesElement != null) dest.CapabilitiesElement = (Canonical)CapabilitiesElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CapabilityComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CapabilityComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.Matches(ValidatedElement, otherT.ValidatedElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if ( !DeepComparable.Matches(OriginElement, otherT.OriginElement)) return false;
                if (!DeepComparable.Matches(DestinationElement, otherT.DestinationElement)) return false;
                if ( !DeepComparable.Matches(LinkElement, otherT.LinkElement)) return false;
                if (!DeepComparable.Matches(CapabilitiesElement, otherT.CapabilitiesElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CapabilityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.IsExactly(ValidatedElement, otherT.ValidatedElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(OriginElement, otherT.OriginElement)) return false;
                if (!DeepComparable.IsExactly(DestinationElement, otherT.DestinationElement)) return false;
                if (!DeepComparable.IsExactly(LinkElement, otherT.LinkElement)) return false;
                if (!DeepComparable.IsExactly(CapabilitiesElement, otherT.CapabilitiesElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RequiredElement != null) yield return RequiredElement;
                    if (ValidatedElement != null) yield return ValidatedElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    foreach (var elem in OriginElement) { if (elem != null) yield return elem; }
                    if (DestinationElement != null) yield return DestinationElement;
                    foreach (var elem in LinkElement) { if (elem != null) yield return elem; }
                    if (CapabilitiesElement != null) yield return CapabilitiesElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RequiredElement != null) yield return new ElementValue("required", RequiredElement);
                    if (ValidatedElement != null) yield return new ElementValue("validated", ValidatedElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    foreach (var elem in OriginElement) { if (elem != null) yield return new ElementValue("origin", elem); }
                    if (DestinationElement != null) yield return new ElementValue("destination", DestinationElement);
                    foreach (var elem in LinkElement) { if (elem != null) yield return new ElementValue("link", elem); }
                    if (CapabilitiesElement != null) yield return new ElementValue("capabilities", CapabilitiesElement);
                }
            }


        }


        [FhirType("FixtureComponent")]
        [DataContract]
        public partial class FixtureComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FixtureComponent"; } }

            /// <summary>
            /// Whether or not to implicitly create the fixture during setup
            /// </summary>
            [FhirElement("autocreate", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean AutocreateElement
            {
                get { return _autocreateElement; }
                set { _autocreateElement = value; OnPropertyChanged("AutocreateElement"); }
            }

            private FhirBoolean _autocreateElement;

            /// <summary>
            /// Whether or not to implicitly create the fixture during setup
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Autocreate
            {
                get { return AutocreateElement != null ? AutocreateElement.Value : null; }
                set
                {
                    if (value == null)
                        AutocreateElement = null;
                    else
                        AutocreateElement = new FhirBoolean(value);
                    OnPropertyChanged("Autocreate");
                }
            }

            /// <summary>
            /// Whether or not to implicitly delete the fixture during teardown
            /// </summary>
            [FhirElement("autodelete", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean AutodeleteElement
            {
                get { return _autodeleteElement; }
                set { _autodeleteElement = value; OnPropertyChanged("AutodeleteElement"); }
            }

            private FhirBoolean _autodeleteElement;

            /// <summary>
            /// Whether or not to implicitly delete the fixture during teardown
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Autodelete
            {
                get { return AutodeleteElement != null ? AutodeleteElement.Value : null; }
                set
                {
                    if (value == null)
                        AutodeleteElement = null;
                    else
                        AutodeleteElement = new FhirBoolean(value);
                    OnPropertyChanged("Autodelete");
                }
            }

            /// <summary>
            /// Reference of the resource
            /// </summary>
            [FhirElement("resource", Order=60)]
            [DataMember]
            public ResourceReference Resource
            {
                get { return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private ResourceReference _resource;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FixtureComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (AutocreateElement != null) dest.AutocreateElement = (FhirBoolean)AutocreateElement.DeepCopy();
                    if (AutodeleteElement != null) dest.AutodeleteElement = (FhirBoolean)AutodeleteElement.DeepCopy();
                    if (Resource != null) dest.Resource = (ResourceReference)Resource.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FixtureComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FixtureComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(AutocreateElement, otherT.AutocreateElement)) return false;
                if (!DeepComparable.Matches(AutodeleteElement, otherT.AutodeleteElement)) return false;
                if (!DeepComparable.Matches(Resource, otherT.Resource)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FixtureComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(AutocreateElement, otherT.AutocreateElement)) return false;
                if (!DeepComparable.IsExactly(AutodeleteElement, otherT.AutodeleteElement)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (AutocreateElement != null) yield return AutocreateElement;
                    if (AutodeleteElement != null) yield return AutodeleteElement;
                    if (Resource != null) yield return Resource;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (AutocreateElement != null) yield return new ElementValue("autocreate", AutocreateElement);
                    if (AutodeleteElement != null) yield return new ElementValue("autodelete", AutodeleteElement);
                    if (Resource != null) yield return new ElementValue("resource", Resource);
                }
            }


        }


        [FhirType("VariableComponent")]
        [DataContract]
        public partial class VariableComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "VariableComponent"; } }

            /// <summary>
            /// Descriptive name for this variable
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Descriptive name for this variable
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
            /// Default, hard-coded, or user-defined value for this variable
            /// </summary>
            [FhirElement("defaultValue", Order=50)]
            [DataMember]
            public FhirString DefaultValueElement
            {
                get { return _defaultValueElement; }
                set { _defaultValueElement = value; OnPropertyChanged("DefaultValueElement"); }
            }

            private FhirString _defaultValueElement;

            /// <summary>
            /// Default, hard-coded, or user-defined value for this variable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string DefaultValue
            {
                get { return DefaultValueElement != null ? DefaultValueElement.Value : null; }
                set
                {
                    if (value == null)
                        DefaultValueElement = null;
                    else
                        DefaultValueElement = new FhirString(value);
                    OnPropertyChanged("DefaultValue");
                }
            }

            /// <summary>
            /// Natural language description of the variable
            /// </summary>
            [FhirElement("description", Order=60)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Natural language description of the variable
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
            /// The FHIRPath expression against the fixture body
            /// </summary>
            [FhirElement("expression", Order=70)]
            [DataMember]
            public FhirString ExpressionElement
            {
                get { return _expressionElement; }
                set { _expressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }

            private FhirString _expressionElement;

            /// <summary>
            /// The FHIRPath expression against the fixture body
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Expression
            {
                get { return ExpressionElement != null ? ExpressionElement.Value : null; }
                set
                {
                    if (value == null)
                        ExpressionElement = null;
                    else
                        ExpressionElement = new FhirString(value);
                    OnPropertyChanged("Expression");
                }
            }

            /// <summary>
            /// HTTP header field name for source
            /// </summary>
            [FhirElement("headerField", Order=80)]
            [DataMember]
            public FhirString HeaderFieldElement
            {
                get { return _headerFieldElement; }
                set { _headerFieldElement = value; OnPropertyChanged("HeaderFieldElement"); }
            }

            private FhirString _headerFieldElement;

            /// <summary>
            /// HTTP header field name for source
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string HeaderField
            {
                get { return HeaderFieldElement != null ? HeaderFieldElement.Value : null; }
                set
                {
                    if (value == null)
                        HeaderFieldElement = null;
                    else
                        HeaderFieldElement = new FhirString(value);
                    OnPropertyChanged("HeaderField");
                }
            }

            /// <summary>
            /// Hint help text for default value to enter
            /// </summary>
            [FhirElement("hint", Order=90)]
            [DataMember]
            public FhirString HintElement
            {
                get { return _hintElement; }
                set { _hintElement = value; OnPropertyChanged("HintElement"); }
            }

            private FhirString _hintElement;

            /// <summary>
            /// Hint help text for default value to enter
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Hint
            {
                get { return HintElement != null ? HintElement.Value : null; }
                set
                {
                    if (value == null)
                        HintElement = null;
                    else
                        HintElement = new FhirString(value);
                    OnPropertyChanged("Hint");
                }
            }

            /// <summary>
            /// XPath or JSONPath against the fixture body
            /// </summary>
            [FhirElement("path", Order=100)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// XPath or JSONPath against the fixture body
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            /// <summary>
            /// Fixture Id of source expression or headerField within this variable
            /// </summary>
            [FhirElement("sourceId", Order=110)]
            [DataMember]
            public Id SourceIdElement
            {
                get { return _sourceIdElement; }
                set { _sourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }

            private Id _sourceIdElement;

            /// <summary>
            /// Fixture Id of source expression or headerField within this variable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceIdElement = null;
                    else
                        SourceIdElement = new Id(value);
                    OnPropertyChanged("SourceId");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VariableComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DefaultValueElement != null) dest.DefaultValueElement = (FhirString)DefaultValueElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (ExpressionElement != null) dest.ExpressionElement = (FhirString)ExpressionElement.DeepCopy();
                    if (HeaderFieldElement != null) dest.HeaderFieldElement = (FhirString)HeaderFieldElement.DeepCopy();
                    if (HintElement != null) dest.HintElement = (FhirString)HintElement.DeepCopy();
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (SourceIdElement != null) dest.SourceIdElement = (Id)SourceIdElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new VariableComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VariableComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DefaultValueElement, otherT.DefaultValueElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;
                if (!DeepComparable.Matches(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if (!DeepComparable.Matches(HintElement, otherT.HintElement)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VariableComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DefaultValueElement, otherT.DefaultValueElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;
                if (!DeepComparable.IsExactly(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if (!DeepComparable.IsExactly(HintElement, otherT.HintElement)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (DefaultValueElement != null) yield return DefaultValueElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (ExpressionElement != null) yield return ExpressionElement;
                    if (HeaderFieldElement != null) yield return HeaderFieldElement;
                    if (HintElement != null) yield return HintElement;
                    if (PathElement != null) yield return PathElement;
                    if (SourceIdElement != null) yield return SourceIdElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DefaultValueElement != null) yield return new ElementValue("defaultValue", DefaultValueElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (ExpressionElement != null) yield return new ElementValue("expression", ExpressionElement);
                    if (HeaderFieldElement != null) yield return new ElementValue("headerField", HeaderFieldElement);
                    if (HintElement != null) yield return new ElementValue("hint", HintElement);
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                    if (SourceIdElement != null) yield return new ElementValue("sourceId", SourceIdElement);
                }
            }


        }


        [FhirType("RuleComponent")]
        [DataContract]
        public partial class RuleComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RuleComponent"; } }

            /// <summary>
            /// Assert rule resource reference
            /// </summary>
            [FhirElement("resource", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Resource
            {
                get { return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private ResourceReference _resource;

            /// <summary>
            /// Rule parameter template
            /// </summary>
            [FhirElement("param", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RuleParamComponent> Param
            {
                get { if (_param==null) _param = new List<RuleParamComponent>(); return _param; }
                set { _param = value; OnPropertyChanged("Param"); }
            }

            private List<RuleParamComponent> _param;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RuleComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Resource != null) dest.Resource = (ResourceReference)Resource.DeepCopy();
                    if (Param != null) dest.Param = new List<RuleParamComponent>(Param.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RuleComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RuleComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if ( !DeepComparable.Matches(Param, otherT.Param)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RuleComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Param, otherT.Param)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Resource != null) yield return Resource;
                    foreach (var elem in Param) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Resource != null) yield return new ElementValue("resource", Resource);
                    foreach (var elem in Param) { if (elem != null) yield return new ElementValue("param", elem); }
                }
            }


        }


        [FhirType("RuleParamComponent")]
        [DataContract]
        public partial class RuleParamComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RuleParamComponent"; } }

            /// <summary>
            /// Parameter name matching external assert rule parameter
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Parameter name matching external assert rule parameter
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
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            [FhirElement("value", Order=50)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RuleParamComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RuleParamComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RuleParamComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RuleParamComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("RulesetComponent")]
        [DataContract]
        public partial class RulesetComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RulesetComponent"; } }

            /// <summary>
            /// Assert ruleset resource reference
            /// </summary>
            [FhirElement("resource", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Resource
            {
                get { return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private ResourceReference _resource;

            /// <summary>
            /// The referenced rule within the ruleset
            /// </summary>
            [FhirElement("rule", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<RulesetRuleComponent> Rule
            {
                get { if (_rule==null) _rule = new List<RulesetRuleComponent>(); return _rule; }
                set { _rule = value; OnPropertyChanged("Rule"); }
            }

            private List<RulesetRuleComponent> _rule;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RulesetComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Resource != null) dest.Resource = (ResourceReference)Resource.DeepCopy();
                    if (Rule != null) dest.Rule = new List<RulesetRuleComponent>(Rule.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RulesetComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RulesetComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if ( !DeepComparable.Matches(Rule, otherT.Rule)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RulesetComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Rule, otherT.Rule)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Resource != null) yield return Resource;
                    foreach (var elem in Rule) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Resource != null) yield return new ElementValue("resource", Resource);
                    foreach (var elem in Rule) { if (elem != null) yield return new ElementValue("rule", elem); }
                }
            }


        }


        [FhirType("RulesetRuleComponent")]
        [DataContract]
        public partial class RulesetRuleComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RulesetRuleComponent"; } }

            /// <summary>
            /// Id of referenced rule within the ruleset
            /// </summary>
            [FhirElement("ruleId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id RuleIdElement
            {
                get { return _ruleIdElement; }
                set { _ruleIdElement = value; OnPropertyChanged("RuleIdElement"); }
            }

            private Id _ruleIdElement;

            /// <summary>
            /// Id of referenced rule within the ruleset
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string RuleId
            {
                get { return RuleIdElement != null ? RuleIdElement.Value : null; }
                set
                {
                    if (value == null)
                        RuleIdElement = null;
                    else
                        RuleIdElement = new Id(value);
                    OnPropertyChanged("RuleId");
                }
            }

            /// <summary>
            /// Ruleset rule parameter template
            /// </summary>
            [FhirElement("param", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RulesetRuleParamComponent> Param
            {
                get { if (_param==null) _param = new List<RulesetRuleParamComponent>(); return _param; }
                set { _param = value; OnPropertyChanged("Param"); }
            }

            private List<RulesetRuleParamComponent> _param;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RulesetRuleComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RuleIdElement != null) dest.RuleIdElement = (Id)RuleIdElement.DeepCopy();
                    if (Param != null) dest.Param = new List<RulesetRuleParamComponent>(Param.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RulesetRuleComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RulesetRuleComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RuleIdElement, otherT.RuleIdElement)) return false;
                if ( !DeepComparable.Matches(Param, otherT.Param)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RulesetRuleComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RuleIdElement, otherT.RuleIdElement)) return false;
                if (!DeepComparable.IsExactly(Param, otherT.Param)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RuleIdElement != null) yield return RuleIdElement;
                    foreach (var elem in Param) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RuleIdElement != null) yield return new ElementValue("ruleId", RuleIdElement);
                    foreach (var elem in Param) { if (elem != null) yield return new ElementValue("param", elem); }
                }
            }


        }


        [FhirType("RulesetRuleParamComponent")]
        [DataContract]
        public partial class RulesetRuleParamComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RulesetRuleParamComponent"; } }

            /// <summary>
            /// Parameter name matching external assert ruleset rule parameter
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Parameter name matching external assert ruleset rule parameter
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
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            [FhirElement("value", Order=50)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RulesetRuleParamComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RulesetRuleParamComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RulesetRuleParamComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RulesetRuleParamComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("SetupComponent")]
        [DataContract]
        public partial class SetupComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SetupComponent"; } }

            /// <summary>
            /// A setup operation or assert to perform
            /// </summary>
            [FhirElement("action", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<SetupActionComponent> Action
            {
                get { if (_action==null) _action = new List<SetupActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<SetupActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SetupComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Action != null) dest.Action = new List<SetupActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SetupComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SetupComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SetupComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("SetupActionComponent")]
        [DataContract]
        public partial class SetupActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SetupActionComponent"; } }

            /// <summary>
            /// The setup operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            /// <summary>
            /// The assertion to perform
            /// </summary>
            [FhirElement("assert", Order=50)]
            [DataMember]
            public AssertComponent Assert
            {
                get { return _assert; }
                set { _assert = value; OnPropertyChanged("Assert"); }
            }

            private AssertComponent _assert;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SetupActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    if (Assert != null) dest.Assert = (AssertComponent)Assert.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SetupActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SetupActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if (!DeepComparable.Matches(Assert, otherT.Assert)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SetupActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if (!DeepComparable.IsExactly(Assert, otherT.Assert)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Operation != null) yield return Operation;
                    if (Assert != null) yield return Assert;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                    if (Assert != null) yield return new ElementValue("assert", Assert);
                }
            }


        }


        [FhirType("OperationComponent")]
        [DataContract]
        public partial class OperationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OperationComponent"; } }

            /// <summary>
            /// The operation code type that will be executed
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Resource type
            /// </summary>
            [FhirElement("resource", Order=50)]
            [DataMember]
            public Code<FHIRDefinedType> ResourceElement
            {
                get { return _resourceElement; }
                set { _resourceElement = value; OnPropertyChanged("ResourceElement"); }
            }

            private Code<FHIRDefinedType> _resourceElement;

            /// <summary>
            /// Resource type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public FHIRDefinedType? Resource
            {
                get { return ResourceElement != null ? ResourceElement.Value : null; }
                set
                {
                    if (value == null)
                        ResourceElement = null;
                    else
                        ResourceElement = new Code<FHIRDefinedType>(value);
                    OnPropertyChanged("Resource");
                }
            }

            /// <summary>
            /// Tracking/logging operation label
            /// </summary>
            [FhirElement("label", Order=60)]
            [DataMember]
            public FhirString LabelElement
            {
                get { return _labelElement; }
                set { _labelElement = value; OnPropertyChanged("LabelElement"); }
            }

            private FhirString _labelElement;

            /// <summary>
            /// Tracking/logging operation label
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Label
            {
                get { return LabelElement != null ? LabelElement.Value : null; }
                set
                {
                    if (value == null)
                        LabelElement = null;
                    else
                        LabelElement = new FhirString(value);
                    OnPropertyChanged("Label");
                }
            }

            /// <summary>
            /// Tracking/reporting operation description
            /// </summary>
            [FhirElement("description", Order=70)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Tracking/reporting operation description
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
            /// Mime type to accept in the payload of the response, with charset etc.
            /// </summary>
            [FhirElement("accept", Order=80)]
            [DataMember]
            public Code AcceptElement
            {
                get { return _acceptElement; }
                set { _acceptElement = value; OnPropertyChanged("AcceptElement"); }
            }

            private Code _acceptElement;

            /// <summary>
            /// Mime type to accept in the payload of the response, with charset etc.
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Accept
            {
                get { return AcceptElement != null ? AcceptElement.Value : null; }
                set
                {
                    if (value == null)
                        AcceptElement = null;
                    else
                        AcceptElement = new Code(value);
                    OnPropertyChanged("Accept");
                }
            }

            /// <summary>
            /// Mime type of the request payload contents, with charset etc.
            /// </summary>
            [FhirElement("contentType", Order=90)]
            [DataMember]
            public Code ContentTypeElement
            {
                get { return _contentTypeElement; }
                set { _contentTypeElement = value; OnPropertyChanged("ContentTypeElement"); }
            }

            private Code _contentTypeElement;

            /// <summary>
            /// Mime type of the request payload contents, with charset etc.
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ContentType
            {
                get { return ContentTypeElement != null ? ContentTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        ContentTypeElement = null;
                    else
                        ContentTypeElement = new Code(value);
                    OnPropertyChanged("ContentType");
                }
            }

            /// <summary>
            /// Server responding to the request
            /// </summary>
            [FhirElement("destination", Order=100)]
            [DataMember]
            public Integer DestinationElement
            {
                get { return _destinationElement; }
                set { _destinationElement = value; OnPropertyChanged("DestinationElement"); }
            }

            private Integer _destinationElement;

            /// <summary>
            /// Server responding to the request
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Destination
            {
                get { return DestinationElement != null ? DestinationElement.Value : null; }
                set
                {
                    if (value == null)
                        DestinationElement = null;
                    else
                        DestinationElement = new Integer(value);
                    OnPropertyChanged("Destination");
                }
            }

            /// <summary>
            /// Whether or not to send the request url in encoded format
            /// </summary>
            [FhirElement("encodeRequestUrl", Order=110)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean EncodeRequestUrlElement
            {
                get { return _encodeRequestUrlElement; }
                set { _encodeRequestUrlElement = value; OnPropertyChanged("EncodeRequestUrlElement"); }
            }

            private FhirBoolean _encodeRequestUrlElement;

            /// <summary>
            /// Whether or not to send the request url in encoded format
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? EncodeRequestUrl
            {
                get { return EncodeRequestUrlElement != null ? EncodeRequestUrlElement.Value : null; }
                set
                {
                    if (value == null)
                        EncodeRequestUrlElement = null;
                    else
                        EncodeRequestUrlElement = new FhirBoolean(value);
                    OnPropertyChanged("EncodeRequestUrl");
                }
            }

            /// <summary>
            /// Server initiating the request
            /// </summary>
            [FhirElement("origin", Order=120)]
            [DataMember]
            public Integer OriginElement
            {
                get { return _originElement; }
                set { _originElement = value; OnPropertyChanged("OriginElement"); }
            }

            private Integer _originElement;

            /// <summary>
            /// Server initiating the request
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Origin
            {
                get { return OriginElement != null ? OriginElement.Value : null; }
                set
                {
                    if (value == null)
                        OriginElement = null;
                    else
                        OriginElement = new Integer(value);
                    OnPropertyChanged("Origin");
                }
            }

            /// <summary>
            /// Explicitly defined path parameters
            /// </summary>
            [FhirElement("params", Order=130)]
            [DataMember]
            public FhirString ParamsElement
            {
                get { return _paramsElement; }
                set { _paramsElement = value; OnPropertyChanged("ParamsElement"); }
            }

            private FhirString _paramsElement;

            /// <summary>
            /// Explicitly defined path parameters
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Params
            {
                get { return ParamsElement != null ? ParamsElement.Value : null; }
                set
                {
                    if (value == null)
                        ParamsElement = null;
                    else
                        ParamsElement = new FhirString(value);
                    OnPropertyChanged("Params");
                }
            }

            /// <summary>
            /// Each operation can have one or more header elements
            /// </summary>
            [FhirElement("requestHeader", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RequestHeaderComponent> RequestHeader
            {
                get { if (_requestHeader==null) _requestHeader = new List<RequestHeaderComponent>(); return _requestHeader; }
                set { _requestHeader = value; OnPropertyChanged("RequestHeader"); }
            }

            private List<RequestHeaderComponent> _requestHeader;

            /// <summary>
            /// Fixture Id of mapped request
            /// </summary>
            [FhirElement("requestId", Order=150)]
            [DataMember]
            public Id RequestIdElement
            {
                get { return _requestIdElement; }
                set { _requestIdElement = value; OnPropertyChanged("RequestIdElement"); }
            }

            private Id _requestIdElement;

            /// <summary>
            /// Fixture Id of mapped request
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string RequestId
            {
                get { return RequestIdElement != null ? RequestIdElement.Value : null; }
                set
                {
                    if (value == null)
                        RequestIdElement = null;
                    else
                        RequestIdElement = new Id(value);
                    OnPropertyChanged("RequestId");
                }
            }

            /// <summary>
            /// Fixture Id of mapped response
            /// </summary>
            [FhirElement("responseId", Order=160)]
            [DataMember]
            public Id ResponseIdElement
            {
                get { return _responseIdElement; }
                set { _responseIdElement = value; OnPropertyChanged("ResponseIdElement"); }
            }

            private Id _responseIdElement;

            /// <summary>
            /// Fixture Id of mapped response
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ResponseId
            {
                get { return ResponseIdElement != null ? ResponseIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ResponseIdElement = null;
                    else
                        ResponseIdElement = new Id(value);
                    OnPropertyChanged("ResponseId");
                }
            }

            /// <summary>
            /// Fixture Id of body for PUT and POST requests
            /// </summary>
            [FhirElement("sourceId", Order=170)]
            [DataMember]
            public Id SourceIdElement
            {
                get { return _sourceIdElement; }
                set { _sourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }

            private Id _sourceIdElement;

            /// <summary>
            /// Fixture Id of body for PUT and POST requests
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceIdElement = null;
                    else
                        SourceIdElement = new Id(value);
                    OnPropertyChanged("SourceId");
                }
            }

            /// <summary>
            /// Id of fixture used for extracting the [id],  [type], and [vid] for GET requests
            /// </summary>
            [FhirElement("targetId", Order=180)]
            [DataMember]
            public Id TargetIdElement
            {
                get { return _targetIdElement; }
                set { _targetIdElement = value; OnPropertyChanged("TargetIdElement"); }
            }

            private Id _targetIdElement;

            /// <summary>
            /// Id of fixture used for extracting the [id],  [type], and [vid] for GET requests
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string TargetId
            {
                get { return TargetIdElement != null ? TargetIdElement.Value : null; }
                set
                {
                    if (value == null)
                        TargetIdElement = null;
                    else
                        TargetIdElement = new Id(value);
                    OnPropertyChanged("TargetId");
                }
            }

            /// <summary>
            /// Request URL
            /// </summary>
            [FhirElement("url", Order=190)]
            [DataMember]
            public FhirString UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirString _urlElement;

            /// <summary>
            /// Request URL
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
                        UrlElement = new FhirString(value);
                    OnPropertyChanged("Url");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OperationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (ResourceElement != null) dest.ResourceElement = (Code<FHIRDefinedType>)ResourceElement.DeepCopy();
                    if (LabelElement != null) dest.LabelElement = (FhirString)LabelElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (AcceptElement != null) dest.AcceptElement = (Code)AcceptElement.DeepCopy();
                    if (ContentTypeElement != null) dest.ContentTypeElement = (Code)ContentTypeElement.DeepCopy();
                    if (DestinationElement != null) dest.DestinationElement = (Integer)DestinationElement.DeepCopy();
                    if (EncodeRequestUrlElement != null) dest.EncodeRequestUrlElement = (FhirBoolean)EncodeRequestUrlElement.DeepCopy();
                    if (OriginElement != null) dest.OriginElement = (Integer)OriginElement.DeepCopy();
                    if (ParamsElement != null) dest.ParamsElement = (FhirString)ParamsElement.DeepCopy();
                    if (RequestHeader != null) dest.RequestHeader = new List<RequestHeaderComponent>(RequestHeader.DeepCopy());
                    if (RequestIdElement != null) dest.RequestIdElement = (Id)RequestIdElement.DeepCopy();
                    if (ResponseIdElement != null) dest.ResponseIdElement = (Id)ResponseIdElement.DeepCopy();
                    if (SourceIdElement != null) dest.SourceIdElement = (Id)SourceIdElement.DeepCopy();
                    if (TargetIdElement != null) dest.TargetIdElement = (Id)TargetIdElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (FhirString)UrlElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OperationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;
                if (!DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(AcceptElement, otherT.AcceptElement)) return false;
                if (!DeepComparable.Matches(ContentTypeElement, otherT.ContentTypeElement)) return false;
                if (!DeepComparable.Matches(DestinationElement, otherT.DestinationElement)) return false;
                if (!DeepComparable.Matches(EncodeRequestUrlElement, otherT.EncodeRequestUrlElement)) return false;
                if (!DeepComparable.Matches(OriginElement, otherT.OriginElement)) return false;
                if (!DeepComparable.Matches(ParamsElement, otherT.ParamsElement)) return false;
                if ( !DeepComparable.Matches(RequestHeader, otherT.RequestHeader)) return false;
                if (!DeepComparable.Matches(RequestIdElement, otherT.RequestIdElement)) return false;
                if (!DeepComparable.Matches(ResponseIdElement, otherT.ResponseIdElement)) return false;
                if (!DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;
                if (!DeepComparable.Matches(TargetIdElement, otherT.TargetIdElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;
                if (!DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(AcceptElement, otherT.AcceptElement)) return false;
                if (!DeepComparable.IsExactly(ContentTypeElement, otherT.ContentTypeElement)) return false;
                if (!DeepComparable.IsExactly(DestinationElement, otherT.DestinationElement)) return false;
                if (!DeepComparable.IsExactly(EncodeRequestUrlElement, otherT.EncodeRequestUrlElement)) return false;
                if (!DeepComparable.IsExactly(OriginElement, otherT.OriginElement)) return false;
                if (!DeepComparable.IsExactly(ParamsElement, otherT.ParamsElement)) return false;
                if (!DeepComparable.IsExactly(RequestHeader, otherT.RequestHeader)) return false;
                if (!DeepComparable.IsExactly(RequestIdElement, otherT.RequestIdElement)) return false;
                if (!DeepComparable.IsExactly(ResponseIdElement, otherT.ResponseIdElement)) return false;
                if (!DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;
                if (!DeepComparable.IsExactly(TargetIdElement, otherT.TargetIdElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (ResourceElement != null) yield return ResourceElement;
                    if (LabelElement != null) yield return LabelElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (AcceptElement != null) yield return AcceptElement;
                    if (ContentTypeElement != null) yield return ContentTypeElement;
                    if (DestinationElement != null) yield return DestinationElement;
                    if (EncodeRequestUrlElement != null) yield return EncodeRequestUrlElement;
                    if (OriginElement != null) yield return OriginElement;
                    if (ParamsElement != null) yield return ParamsElement;
                    foreach (var elem in RequestHeader) { if (elem != null) yield return elem; }
                    if (RequestIdElement != null) yield return RequestIdElement;
                    if (ResponseIdElement != null) yield return ResponseIdElement;
                    if (SourceIdElement != null) yield return SourceIdElement;
                    if (TargetIdElement != null) yield return TargetIdElement;
                    if (UrlElement != null) yield return UrlElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (ResourceElement != null) yield return new ElementValue("resource", ResourceElement);
                    if (LabelElement != null) yield return new ElementValue("label", LabelElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (AcceptElement != null) yield return new ElementValue("accept", AcceptElement);
                    if (ContentTypeElement != null) yield return new ElementValue("contentType", ContentTypeElement);
                    if (DestinationElement != null) yield return new ElementValue("destination", DestinationElement);
                    if (EncodeRequestUrlElement != null) yield return new ElementValue("encodeRequestUrl", EncodeRequestUrlElement);
                    if (OriginElement != null) yield return new ElementValue("origin", OriginElement);
                    if (ParamsElement != null) yield return new ElementValue("params", ParamsElement);
                    foreach (var elem in RequestHeader) { if (elem != null) yield return new ElementValue("requestHeader", elem); }
                    if (RequestIdElement != null) yield return new ElementValue("requestId", RequestIdElement);
                    if (ResponseIdElement != null) yield return new ElementValue("responseId", ResponseIdElement);
                    if (SourceIdElement != null) yield return new ElementValue("sourceId", SourceIdElement);
                    if (TargetIdElement != null) yield return new ElementValue("targetId", TargetIdElement);
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                }
            }


        }


        [FhirType("RequestHeaderComponent")]
        [DataContract]
        public partial class RequestHeaderComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RequestHeaderComponent"; } }

            /// <summary>
            /// HTTP header field name
            /// </summary>
            [FhirElement("field", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString FieldElement
            {
                get { return _fieldElement; }
                set { _fieldElement = value; OnPropertyChanged("FieldElement"); }
            }

            private FhirString _fieldElement;

            /// <summary>
            /// HTTP header field name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Field
            {
                get { return FieldElement != null ? FieldElement.Value : null; }
                set
                {
                    if (value == null)
                        FieldElement = null;
                    else
                        FieldElement = new FhirString(value);
                    OnPropertyChanged("Field");
                }
            }

            /// <summary>
            /// HTTP headerfield value
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// HTTP headerfield value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RequestHeaderComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (FieldElement != null) dest.FieldElement = (FhirString)FieldElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RequestHeaderComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RequestHeaderComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(FieldElement, otherT.FieldElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RequestHeaderComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(FieldElement, otherT.FieldElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (FieldElement != null) yield return FieldElement;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (FieldElement != null) yield return new ElementValue("field", FieldElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("AssertComponent")]
        [DataContract]
        public partial class AssertComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AssertComponent"; } }

            /// <summary>
            /// Tracking/logging assertion label
            /// </summary>
            [FhirElement("label", Order=40)]
            [DataMember]
            public FhirString LabelElement
            {
                get { return _labelElement; }
                set { _labelElement = value; OnPropertyChanged("LabelElement"); }
            }

            private FhirString _labelElement;

            /// <summary>
            /// Tracking/logging assertion label
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Label
            {
                get { return LabelElement != null ? LabelElement.Value : null; }
                set
                {
                    if (value == null)
                        LabelElement = null;
                    else
                        LabelElement = new FhirString(value);
                    OnPropertyChanged("Label");
                }
            }

            /// <summary>
            /// Tracking/reporting assertion description
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Tracking/reporting assertion description
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
            /// response | request
            /// </summary>
            [FhirElement("direction", Order=60)]
            [DataMember]
            public Code<AssertionDirectionType> DirectionElement
            {
                get { return _directionElement; }
                set { _directionElement = value; OnPropertyChanged("DirectionElement"); }
            }

            private Code<AssertionDirectionType> _directionElement;

            /// <summary>
            /// response | request
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AssertionDirectionType? Direction
            {
                get { return DirectionElement != null ? DirectionElement.Value : null; }
                set
                {
                    if (value == null)
                        DirectionElement = null;
                    else
                        DirectionElement = new Code<AssertionDirectionType>(value);
                    OnPropertyChanged("Direction");
                }
            }

            /// <summary>
            /// Id of the source fixture to be evaluated
            /// </summary>
            [FhirElement("compareToSourceId", Order=70)]
            [DataMember]
            public FhirString CompareToSourceIdElement
            {
                get { return _compareToSourceIdElement; }
                set { _compareToSourceIdElement = value; OnPropertyChanged("CompareToSourceIdElement"); }
            }

            private FhirString _compareToSourceIdElement;

            /// <summary>
            /// Id of the source fixture to be evaluated
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string CompareToSourceId
            {
                get { return CompareToSourceIdElement != null ? CompareToSourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        CompareToSourceIdElement = null;
                    else
                        CompareToSourceIdElement = new FhirString(value);
                    OnPropertyChanged("CompareToSourceId");
                }
            }

            /// <summary>
            /// The FHIRPath expression to evaluate against the source fixture
            /// </summary>
            [FhirElement("compareToSourceExpression", Order=80)]
            [DataMember]
            public FhirString CompareToSourceExpressionElement
            {
                get { return _compareToSourceExpressionElement; }
                set { _compareToSourceExpressionElement = value; OnPropertyChanged("CompareToSourceExpressionElement"); }
            }

            private FhirString _compareToSourceExpressionElement;

            /// <summary>
            /// The FHIRPath expression to evaluate against the source fixture
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string CompareToSourceExpression
            {
                get { return CompareToSourceExpressionElement != null ? CompareToSourceExpressionElement.Value : null; }
                set
                {
                    if (value == null)
                        CompareToSourceExpressionElement = null;
                    else
                        CompareToSourceExpressionElement = new FhirString(value);
                    OnPropertyChanged("CompareToSourceExpression");
                }
            }

            /// <summary>
            /// XPath or JSONPath expression to evaluate against the source fixture
            /// </summary>
            [FhirElement("compareToSourcePath", Order=90)]
            [DataMember]
            public FhirString CompareToSourcePathElement
            {
                get { return _compareToSourcePathElement; }
                set { _compareToSourcePathElement = value; OnPropertyChanged("CompareToSourcePathElement"); }
            }

            private FhirString _compareToSourcePathElement;

            /// <summary>
            /// XPath or JSONPath expression to evaluate against the source fixture
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string CompareToSourcePath
            {
                get { return CompareToSourcePathElement != null ? CompareToSourcePathElement.Value : null; }
                set
                {
                    if (value == null)
                        CompareToSourcePathElement = null;
                    else
                        CompareToSourcePathElement = new FhirString(value);
                    OnPropertyChanged("CompareToSourcePath");
                }
            }

            /// <summary>
            /// Mime type to compare against the 'Content-Type' header
            /// </summary>
            [FhirElement("contentType", Order=100)]
            [DataMember]
            public Code ContentTypeElement
            {
                get { return _contentTypeElement; }
                set { _contentTypeElement = value; OnPropertyChanged("ContentTypeElement"); }
            }

            private Code _contentTypeElement;

            /// <summary>
            /// Mime type to compare against the 'Content-Type' header
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ContentType
            {
                get { return ContentTypeElement != null ? ContentTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        ContentTypeElement = null;
                    else
                        ContentTypeElement = new Code(value);
                    OnPropertyChanged("ContentType");
                }
            }

            /// <summary>
            /// The FHIRPath expression to be evaluated
            /// </summary>
            [FhirElement("expression", Order=110)]
            [DataMember]
            public FhirString ExpressionElement
            {
                get { return _expressionElement; }
                set { _expressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }

            private FhirString _expressionElement;

            /// <summary>
            /// The FHIRPath expression to be evaluated
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Expression
            {
                get { return ExpressionElement != null ? ExpressionElement.Value : null; }
                set
                {
                    if (value == null)
                        ExpressionElement = null;
                    else
                        ExpressionElement = new FhirString(value);
                    OnPropertyChanged("Expression");
                }
            }

            /// <summary>
            /// HTTP header field name
            /// </summary>
            [FhirElement("headerField", Order=120)]
            [DataMember]
            public FhirString HeaderFieldElement
            {
                get { return _headerFieldElement; }
                set { _headerFieldElement = value; OnPropertyChanged("HeaderFieldElement"); }
            }

            private FhirString _headerFieldElement;

            /// <summary>
            /// HTTP header field name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string HeaderField
            {
                get { return HeaderFieldElement != null ? HeaderFieldElement.Value : null; }
                set
                {
                    if (value == null)
                        HeaderFieldElement = null;
                    else
                        HeaderFieldElement = new FhirString(value);
                    OnPropertyChanged("HeaderField");
                }
            }

            /// <summary>
            /// Fixture Id of minimum content resource
            /// </summary>
            [FhirElement("minimumId", Order=130)]
            [DataMember]
            public FhirString MinimumIdElement
            {
                get { return _minimumIdElement; }
                set { _minimumIdElement = value; OnPropertyChanged("MinimumIdElement"); }
            }

            private FhirString _minimumIdElement;

            /// <summary>
            /// Fixture Id of minimum content resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string MinimumId
            {
                get { return MinimumIdElement != null ? MinimumIdElement.Value : null; }
                set
                {
                    if (value == null)
                        MinimumIdElement = null;
                    else
                        MinimumIdElement = new FhirString(value);
                    OnPropertyChanged("MinimumId");
                }
            }

            /// <summary>
            /// Perform validation on navigation links?
            /// </summary>
            [FhirElement("navigationLinks", Order=140)]
            [DataMember]
            public FhirBoolean NavigationLinksElement
            {
                get { return _navigationLinksElement; }
                set { _navigationLinksElement = value; OnPropertyChanged("NavigationLinksElement"); }
            }

            private FhirBoolean _navigationLinksElement;

            /// <summary>
            /// Perform validation on navigation links?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? NavigationLinks
            {
                get { return NavigationLinksElement != null ? NavigationLinksElement.Value : null; }
                set
                {
                    if (value == null)
                        NavigationLinksElement = null;
                    else
                        NavigationLinksElement = new FhirBoolean(value);
                    OnPropertyChanged("NavigationLinks");
                }
            }

            /// <summary>
            /// equals | notEquals | in | notIn | greaterThan | lessThan | empty | notEmpty | contains | notContains | eval
            /// </summary>
            [FhirElement("operator", Order=150)]
            [DataMember]
            public Code<AssertionOperatorType> OperatorElement
            {
                get { return _operatorElement; }
                set { _operatorElement = value; OnPropertyChanged("OperatorElement"); }
            }

            private Code<AssertionOperatorType> _operatorElement;

            /// <summary>
            /// equals | notEquals | in | notIn | greaterThan | lessThan | empty | notEmpty | contains | notContains | eval
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AssertionOperatorType? Operator
            {
                get { return OperatorElement != null ? OperatorElement.Value : null; }
                set
                {
                    if (value == null)
                        OperatorElement = null;
                    else
                        OperatorElement = new Code<AssertionOperatorType>(value);
                    OnPropertyChanged("Operator");
                }
            }

            /// <summary>
            /// XPath or JSONPath expression
            /// </summary>
            [FhirElement("path", Order=160)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// XPath or JSONPath expression
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            /// <summary>
            /// delete | get | options | patch | post | put
            /// </summary>
            [FhirElement("requestMethod", Order=170)]
            [DataMember]
            public Code<TestScriptRequestMethodCode> RequestMethodElement
            {
                get { return _requestMethodElement; }
                set { _requestMethodElement = value; OnPropertyChanged("RequestMethodElement"); }
            }

            private Code<TestScriptRequestMethodCode> _requestMethodElement;

            /// <summary>
            /// delete | get | options | patch | post | put
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public TestScriptRequestMethodCode? RequestMethod
            {
                get { return RequestMethodElement != null ? RequestMethodElement.Value : null; }
                set
                {
                    if (value == null)
                        RequestMethodElement = null;
                    else
                        RequestMethodElement = new Code<TestScriptRequestMethodCode>(value);
                    OnPropertyChanged("RequestMethod");
                }
            }

            /// <summary>
            /// Request URL comparison value
            /// </summary>
            [FhirElement("requestURL", Order=180)]
            [DataMember]
            public FhirString RequestURLElement
            {
                get { return _requestURLElement; }
                set { _requestURLElement = value; OnPropertyChanged("RequestURLElement"); }
            }

            private FhirString _requestURLElement;

            /// <summary>
            /// Request URL comparison value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string RequestURL
            {
                get { return RequestURLElement != null ? RequestURLElement.Value : null; }
                set
                {
                    if (value == null)
                        RequestURLElement = null;
                    else
                        RequestURLElement = new FhirString(value);
                    OnPropertyChanged("RequestURL");
                }
            }

            /// <summary>
            /// Resource type
            /// </summary>
            [FhirElement("resource", Order=190)]
            [DataMember]
            public Code<FHIRDefinedType> ResourceElement
            {
                get { return _resourceElement; }
                set { _resourceElement = value; OnPropertyChanged("ResourceElement"); }
            }

            private Code<FHIRDefinedType> _resourceElement;

            /// <summary>
            /// Resource type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public FHIRDefinedType? Resource
            {
                get { return ResourceElement != null ? ResourceElement.Value : null; }
                set
                {
                    if (value == null)
                        ResourceElement = null;
                    else
                        ResourceElement = new Code<FHIRDefinedType>(value);
                    OnPropertyChanged("Resource");
                }
            }

            /// <summary>
            /// okay | created | noContent | notModified | bad | forbidden | notFound | methodNotAllowed | conflict | gone | preconditionFailed | unprocessable
            /// </summary>
            [FhirElement("response", Order=200)]
            [DataMember]
            public Code<AssertionResponseTypes> ResponseElement
            {
                get { return _responseElement; }
                set { _responseElement = value; OnPropertyChanged("ResponseElement"); }
            }

            private Code<AssertionResponseTypes> _responseElement;

            /// <summary>
            /// okay | created | noContent | notModified | bad | forbidden | notFound | methodNotAllowed | conflict | gone | preconditionFailed | unprocessable
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AssertionResponseTypes? Response
            {
                get { return ResponseElement != null ? ResponseElement.Value : null; }
                set
                {
                    if (value == null)
                        ResponseElement = null;
                    else
                        ResponseElement = new Code<AssertionResponseTypes>(value);
                    OnPropertyChanged("Response");
                }
            }

            /// <summary>
            /// HTTP response code to test
            /// </summary>
            [FhirElement("responseCode", Order=210)]
            [DataMember]
            public FhirString ResponseCodeElement
            {
                get { return _responseCodeElement; }
                set { _responseCodeElement = value; OnPropertyChanged("ResponseCodeElement"); }
            }

            private FhirString _responseCodeElement;

            /// <summary>
            /// HTTP response code to test
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ResponseCode
            {
                get { return ResponseCodeElement != null ? ResponseCodeElement.Value : null; }
                set
                {
                    if (value == null)
                        ResponseCodeElement = null;
                    else
                        ResponseCodeElement = new FhirString(value);
                    OnPropertyChanged("ResponseCode");
                }
            }

            /// <summary>
            /// The reference to a TestScript.rule
            /// </summary>
            [FhirElement("rule", Order=220)]
            [DataMember]
            public ActionAssertRuleComponent Rule
            {
                get { return _rule; }
                set { _rule = value; OnPropertyChanged("Rule"); }
            }

            private ActionAssertRuleComponent _rule;

            /// <summary>
            /// The reference to a TestScript.ruleset
            /// </summary>
            [FhirElement("ruleset", Order=230)]
            [DataMember]
            public ActionAssertRulesetComponent Ruleset
            {
                get { return _ruleset; }
                set { _ruleset = value; OnPropertyChanged("Ruleset"); }
            }

            private ActionAssertRulesetComponent _ruleset;

            /// <summary>
            /// Fixture Id of source expression or headerField
            /// </summary>
            [FhirElement("sourceId", Order=240)]
            [DataMember]
            public Id SourceIdElement
            {
                get { return _sourceIdElement; }
                set { _sourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }

            private Id _sourceIdElement;

            /// <summary>
            /// Fixture Id of source expression or headerField
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceIdElement = null;
                    else
                        SourceIdElement = new Id(value);
                    OnPropertyChanged("SourceId");
                }
            }

            /// <summary>
            /// Profile Id of validation profile reference
            /// </summary>
            [FhirElement("validateProfileId", Order=250)]
            [DataMember]
            public Id ValidateProfileIdElement
            {
                get { return _validateProfileIdElement; }
                set { _validateProfileIdElement = value; OnPropertyChanged("ValidateProfileIdElement"); }
            }

            private Id _validateProfileIdElement;

            /// <summary>
            /// Profile Id of validation profile reference
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ValidateProfileId
            {
                get { return ValidateProfileIdElement != null ? ValidateProfileIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ValidateProfileIdElement = null;
                    else
                        ValidateProfileIdElement = new Id(value);
                    OnPropertyChanged("ValidateProfileId");
                }
            }

            /// <summary>
            /// The value to compare to
            /// </summary>
            [FhirElement("value", Order=260)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// The value to compare to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            /// <summary>
            /// Will this assert produce a warning only on error?
            /// </summary>
            [FhirElement("warningOnly", Order=270)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean WarningOnlyElement
            {
                get { return _warningOnlyElement; }
                set { _warningOnlyElement = value; OnPropertyChanged("WarningOnlyElement"); }
            }

            private FhirBoolean _warningOnlyElement;

            /// <summary>
            /// Will this assert produce a warning only on error?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? WarningOnly
            {
                get { return WarningOnlyElement != null ? WarningOnlyElement.Value : null; }
                set
                {
                    if (value == null)
                        WarningOnlyElement = null;
                    else
                        WarningOnlyElement = new FhirBoolean(value);
                    OnPropertyChanged("WarningOnly");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AssertComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LabelElement != null) dest.LabelElement = (FhirString)LabelElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (DirectionElement != null) dest.DirectionElement = (Code<AssertionDirectionType>)DirectionElement.DeepCopy();
                    if (CompareToSourceIdElement != null) dest.CompareToSourceIdElement = (FhirString)CompareToSourceIdElement.DeepCopy();
                    if (CompareToSourceExpressionElement != null) dest.CompareToSourceExpressionElement = (FhirString)CompareToSourceExpressionElement.DeepCopy();
                    if (CompareToSourcePathElement != null) dest.CompareToSourcePathElement = (FhirString)CompareToSourcePathElement.DeepCopy();
                    if (ContentTypeElement != null) dest.ContentTypeElement = (Code)ContentTypeElement.DeepCopy();
                    if (ExpressionElement != null) dest.ExpressionElement = (FhirString)ExpressionElement.DeepCopy();
                    if (HeaderFieldElement != null) dest.HeaderFieldElement = (FhirString)HeaderFieldElement.DeepCopy();
                    if (MinimumIdElement != null) dest.MinimumIdElement = (FhirString)MinimumIdElement.DeepCopy();
                    if (NavigationLinksElement != null) dest.NavigationLinksElement = (FhirBoolean)NavigationLinksElement.DeepCopy();
                    if (OperatorElement != null) dest.OperatorElement = (Code<AssertionOperatorType>)OperatorElement.DeepCopy();
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (RequestMethodElement != null) dest.RequestMethodElement = (Code<TestScriptRequestMethodCode>)RequestMethodElement.DeepCopy();
                    if (RequestURLElement != null) dest.RequestURLElement = (FhirString)RequestURLElement.DeepCopy();
                    if (ResourceElement != null) dest.ResourceElement = (Code<FHIRDefinedType>)ResourceElement.DeepCopy();
                    if (ResponseElement != null) dest.ResponseElement = (Code<AssertionResponseTypes>)ResponseElement.DeepCopy();
                    if (ResponseCodeElement != null) dest.ResponseCodeElement = (FhirString)ResponseCodeElement.DeepCopy();
                    if (Rule != null) dest.Rule = (ActionAssertRuleComponent)Rule.DeepCopy();
                    if (Ruleset != null) dest.Ruleset = (ActionAssertRulesetComponent)Ruleset.DeepCopy();
                    if (SourceIdElement != null) dest.SourceIdElement = (Id)SourceIdElement.DeepCopy();
                    if (ValidateProfileIdElement != null) dest.ValidateProfileIdElement = (Id)ValidateProfileIdElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    if (WarningOnlyElement != null) dest.WarningOnlyElement = (FhirBoolean)WarningOnlyElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AssertComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AssertComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(DirectionElement, otherT.DirectionElement)) return false;
                if (!DeepComparable.Matches(CompareToSourceIdElement, otherT.CompareToSourceIdElement)) return false;
                if (!DeepComparable.Matches(CompareToSourceExpressionElement, otherT.CompareToSourceExpressionElement)) return false;
                if (!DeepComparable.Matches(CompareToSourcePathElement, otherT.CompareToSourcePathElement)) return false;
                if (!DeepComparable.Matches(ContentTypeElement, otherT.ContentTypeElement)) return false;
                if (!DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;
                if (!DeepComparable.Matches(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if (!DeepComparable.Matches(MinimumIdElement, otherT.MinimumIdElement)) return false;
                if (!DeepComparable.Matches(NavigationLinksElement, otherT.NavigationLinksElement)) return false;
                if (!DeepComparable.Matches(OperatorElement, otherT.OperatorElement)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(RequestMethodElement, otherT.RequestMethodElement)) return false;
                if (!DeepComparable.Matches(RequestURLElement, otherT.RequestURLElement)) return false;
                if (!DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;
                if (!DeepComparable.Matches(ResponseElement, otherT.ResponseElement)) return false;
                if (!DeepComparable.Matches(ResponseCodeElement, otherT.ResponseCodeElement)) return false;
                if (!DeepComparable.Matches(Rule, otherT.Rule)) return false;
                if (!DeepComparable.Matches(Ruleset, otherT.Ruleset)) return false;
                if (!DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;
                if (!DeepComparable.Matches(ValidateProfileIdElement, otherT.ValidateProfileIdElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.Matches(WarningOnlyElement, otherT.WarningOnlyElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AssertComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(DirectionElement, otherT.DirectionElement)) return false;
                if (!DeepComparable.IsExactly(CompareToSourceIdElement, otherT.CompareToSourceIdElement)) return false;
                if (!DeepComparable.IsExactly(CompareToSourceExpressionElement, otherT.CompareToSourceExpressionElement)) return false;
                if (!DeepComparable.IsExactly(CompareToSourcePathElement, otherT.CompareToSourcePathElement)) return false;
                if (!DeepComparable.IsExactly(ContentTypeElement, otherT.ContentTypeElement)) return false;
                if (!DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;
                if (!DeepComparable.IsExactly(HeaderFieldElement, otherT.HeaderFieldElement)) return false;
                if (!DeepComparable.IsExactly(MinimumIdElement, otherT.MinimumIdElement)) return false;
                if (!DeepComparable.IsExactly(NavigationLinksElement, otherT.NavigationLinksElement)) return false;
                if (!DeepComparable.IsExactly(OperatorElement, otherT.OperatorElement)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(RequestMethodElement, otherT.RequestMethodElement)) return false;
                if (!DeepComparable.IsExactly(RequestURLElement, otherT.RequestURLElement)) return false;
                if (!DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;
                if (!DeepComparable.IsExactly(ResponseElement, otherT.ResponseElement)) return false;
                if (!DeepComparable.IsExactly(ResponseCodeElement, otherT.ResponseCodeElement)) return false;
                if (!DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
                if (!DeepComparable.IsExactly(Ruleset, otherT.Ruleset)) return false;
                if (!DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;
                if (!DeepComparable.IsExactly(ValidateProfileIdElement, otherT.ValidateProfileIdElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.IsExactly(WarningOnlyElement, otherT.WarningOnlyElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LabelElement != null) yield return LabelElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (DirectionElement != null) yield return DirectionElement;
                    if (CompareToSourceIdElement != null) yield return CompareToSourceIdElement;
                    if (CompareToSourceExpressionElement != null) yield return CompareToSourceExpressionElement;
                    if (CompareToSourcePathElement != null) yield return CompareToSourcePathElement;
                    if (ContentTypeElement != null) yield return ContentTypeElement;
                    if (ExpressionElement != null) yield return ExpressionElement;
                    if (HeaderFieldElement != null) yield return HeaderFieldElement;
                    if (MinimumIdElement != null) yield return MinimumIdElement;
                    if (NavigationLinksElement != null) yield return NavigationLinksElement;
                    if (OperatorElement != null) yield return OperatorElement;
                    if (PathElement != null) yield return PathElement;
                    if (RequestMethodElement != null) yield return RequestMethodElement;
                    if (RequestURLElement != null) yield return RequestURLElement;
                    if (ResourceElement != null) yield return ResourceElement;
                    if (ResponseElement != null) yield return ResponseElement;
                    if (ResponseCodeElement != null) yield return ResponseCodeElement;
                    if (Rule != null) yield return Rule;
                    if (Ruleset != null) yield return Ruleset;
                    if (SourceIdElement != null) yield return SourceIdElement;
                    if (ValidateProfileIdElement != null) yield return ValidateProfileIdElement;
                    if (ValueElement != null) yield return ValueElement;
                    if (WarningOnlyElement != null) yield return WarningOnlyElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LabelElement != null) yield return new ElementValue("label", LabelElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (DirectionElement != null) yield return new ElementValue("direction", DirectionElement);
                    if (CompareToSourceIdElement != null) yield return new ElementValue("compareToSourceId", CompareToSourceIdElement);
                    if (CompareToSourceExpressionElement != null) yield return new ElementValue("compareToSourceExpression", CompareToSourceExpressionElement);
                    if (CompareToSourcePathElement != null) yield return new ElementValue("compareToSourcePath", CompareToSourcePathElement);
                    if (ContentTypeElement != null) yield return new ElementValue("contentType", ContentTypeElement);
                    if (ExpressionElement != null) yield return new ElementValue("expression", ExpressionElement);
                    if (HeaderFieldElement != null) yield return new ElementValue("headerField", HeaderFieldElement);
                    if (MinimumIdElement != null) yield return new ElementValue("minimumId", MinimumIdElement);
                    if (NavigationLinksElement != null) yield return new ElementValue("navigationLinks", NavigationLinksElement);
                    if (OperatorElement != null) yield return new ElementValue("operator", OperatorElement);
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                    if (RequestMethodElement != null) yield return new ElementValue("requestMethod", RequestMethodElement);
                    if (RequestURLElement != null) yield return new ElementValue("requestURL", RequestURLElement);
                    if (ResourceElement != null) yield return new ElementValue("resource", ResourceElement);
                    if (ResponseElement != null) yield return new ElementValue("response", ResponseElement);
                    if (ResponseCodeElement != null) yield return new ElementValue("responseCode", ResponseCodeElement);
                    if (Rule != null) yield return new ElementValue("rule", Rule);
                    if (Ruleset != null) yield return new ElementValue("ruleset", Ruleset);
                    if (SourceIdElement != null) yield return new ElementValue("sourceId", SourceIdElement);
                    if (ValidateProfileIdElement != null) yield return new ElementValue("validateProfileId", ValidateProfileIdElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                    if (WarningOnlyElement != null) yield return new ElementValue("warningOnly", WarningOnlyElement);
                }
            }


        }


        [FhirType("ActionAssertRuleComponent")]
        [DataContract]
        public partial class ActionAssertRuleComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActionAssertRuleComponent"; } }

            /// <summary>
            /// Id of the TestScript.rule
            /// </summary>
            [FhirElement("ruleId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id RuleIdElement
            {
                get { return _ruleIdElement; }
                set { _ruleIdElement = value; OnPropertyChanged("RuleIdElement"); }
            }

            private Id _ruleIdElement;

            /// <summary>
            /// Id of the TestScript.rule
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string RuleId
            {
                get { return RuleIdElement != null ? RuleIdElement.Value : null; }
                set
                {
                    if (value == null)
                        RuleIdElement = null;
                    else
                        RuleIdElement = new Id(value);
                    OnPropertyChanged("RuleId");
                }
            }

            /// <summary>
            /// Rule parameter template
            /// </summary>
            [FhirElement("param", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ActionAssertRuleParamComponent> Param
            {
                get { if (_param==null) _param = new List<ActionAssertRuleParamComponent>(); return _param; }
                set { _param = value; OnPropertyChanged("Param"); }
            }

            private List<ActionAssertRuleParamComponent> _param;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionAssertRuleComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RuleIdElement != null) dest.RuleIdElement = (Id)RuleIdElement.DeepCopy();
                    if (Param != null) dest.Param = new List<ActionAssertRuleParamComponent>(Param.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActionAssertRuleComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionAssertRuleComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RuleIdElement, otherT.RuleIdElement)) return false;
                if ( !DeepComparable.Matches(Param, otherT.Param)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionAssertRuleComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RuleIdElement, otherT.RuleIdElement)) return false;
                if (!DeepComparable.IsExactly(Param, otherT.Param)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RuleIdElement != null) yield return RuleIdElement;
                    foreach (var elem in Param) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RuleIdElement != null) yield return new ElementValue("ruleId", RuleIdElement);
                    foreach (var elem in Param) { if (elem != null) yield return new ElementValue("param", elem); }
                }
            }


        }


        [FhirType("ActionAssertRuleParamComponent")]
        [DataContract]
        public partial class ActionAssertRuleParamComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActionAssertRuleParamComponent"; } }

            /// <summary>
            /// Parameter name matching external assert rule parameter
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Parameter name matching external assert rule parameter
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
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionAssertRuleParamComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActionAssertRuleParamComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionAssertRuleParamComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionAssertRuleParamComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("ActionAssertRulesetComponent")]
        [DataContract]
        public partial class ActionAssertRulesetComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActionAssertRulesetComponent"; } }

            /// <summary>
            /// Id of the TestScript.ruleset
            /// </summary>
            [FhirElement("rulesetId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id RulesetIdElement
            {
                get { return _rulesetIdElement; }
                set { _rulesetIdElement = value; OnPropertyChanged("RulesetIdElement"); }
            }

            private Id _rulesetIdElement;

            /// <summary>
            /// Id of the TestScript.ruleset
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string RulesetId
            {
                get { return RulesetIdElement != null ? RulesetIdElement.Value : null; }
                set
                {
                    if (value == null)
                        RulesetIdElement = null;
                    else
                        RulesetIdElement = new Id(value);
                    OnPropertyChanged("RulesetId");
                }
            }

            /// <summary>
            /// The referenced rule within the ruleset
            /// </summary>
            [FhirElement("rule", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ActionAssertRulesetRuleComponent> Rule
            {
                get { if (_rule==null) _rule = new List<ActionAssertRulesetRuleComponent>(); return _rule; }
                set { _rule = value; OnPropertyChanged("Rule"); }
            }

            private List<ActionAssertRulesetRuleComponent> _rule;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionAssertRulesetComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RulesetIdElement != null) dest.RulesetIdElement = (Id)RulesetIdElement.DeepCopy();
                    if (Rule != null) dest.Rule = new List<ActionAssertRulesetRuleComponent>(Rule.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActionAssertRulesetComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionAssertRulesetComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RulesetIdElement, otherT.RulesetIdElement)) return false;
                if ( !DeepComparable.Matches(Rule, otherT.Rule)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionAssertRulesetComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RulesetIdElement, otherT.RulesetIdElement)) return false;
                if (!DeepComparable.IsExactly(Rule, otherT.Rule)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RulesetIdElement != null) yield return RulesetIdElement;
                    foreach (var elem in Rule) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RulesetIdElement != null) yield return new ElementValue("rulesetId", RulesetIdElement);
                    foreach (var elem in Rule) { if (elem != null) yield return new ElementValue("rule", elem); }
                }
            }


        }


        [FhirType("ActionAssertRulesetRuleComponent")]
        [DataContract]
        public partial class ActionAssertRulesetRuleComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActionAssertRulesetRuleComponent"; } }

            /// <summary>
            /// Id of referenced rule within the ruleset
            /// </summary>
            [FhirElement("ruleId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id RuleIdElement
            {
                get { return _ruleIdElement; }
                set { _ruleIdElement = value; OnPropertyChanged("RuleIdElement"); }
            }

            private Id _ruleIdElement;

            /// <summary>
            /// Id of referenced rule within the ruleset
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string RuleId
            {
                get { return RuleIdElement != null ? RuleIdElement.Value : null; }
                set
                {
                    if (value == null)
                        RuleIdElement = null;
                    else
                        RuleIdElement = new Id(value);
                    OnPropertyChanged("RuleId");
                }
            }

            /// <summary>
            /// Rule parameter template
            /// </summary>
            [FhirElement("param", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParamComponent> Param
            {
                get { if (_param==null) _param = new List<ParamComponent>(); return _param; }
                set { _param = value; OnPropertyChanged("Param"); }
            }

            private List<ParamComponent> _param;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionAssertRulesetRuleComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RuleIdElement != null) dest.RuleIdElement = (Id)RuleIdElement.DeepCopy();
                    if (Param != null) dest.Param = new List<ParamComponent>(Param.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActionAssertRulesetRuleComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionAssertRulesetRuleComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RuleIdElement, otherT.RuleIdElement)) return false;
                if ( !DeepComparable.Matches(Param, otherT.Param)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionAssertRulesetRuleComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RuleIdElement, otherT.RuleIdElement)) return false;
                if (!DeepComparable.IsExactly(Param, otherT.Param)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RuleIdElement != null) yield return RuleIdElement;
                    foreach (var elem in Param) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RuleIdElement != null) yield return new ElementValue("ruleId", RuleIdElement);
                    foreach (var elem in Param) { if (elem != null) yield return new ElementValue("param", elem); }
                }
            }


        }


        [FhirType("ParamComponent")]
        [DataContract]
        public partial class ParamComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParamComponent"; } }

            /// <summary>
            /// Parameter name matching external assert ruleset rule parameter
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Parameter name matching external assert ruleset rule parameter
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
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// Parameter value defined either explicitly or dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParamComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParamComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParamComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParamComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("TestComponent")]
        [DataContract]
        public partial class TestComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TestComponent"; } }

            /// <summary>
            /// Tracking/logging name of this test
            /// </summary>
            [FhirElement("name", Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Tracking/logging name of this test
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
            /// Tracking/reporting short description of the test
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Tracking/reporting short description of the test
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
            /// A test operation or assert to perform
            /// </summary>
            [FhirElement("action", Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<TestActionComponent> Action
            {
                get { if (_action==null) _action = new List<TestActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<TestActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Action != null) dest.Action = new List<TestActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TestComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TestComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TestComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("TestActionComponent")]
        [DataContract]
        public partial class TestActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TestActionComponent"; } }

            /// <summary>
            /// The setup operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            /// <summary>
            /// The setup assertion to perform
            /// </summary>
            [FhirElement("assert", Order=50)]
            [DataMember]
            public AssertComponent Assert
            {
                get { return _assert; }
                set { _assert = value; OnPropertyChanged("Assert"); }
            }

            private AssertComponent _assert;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TestActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    if (Assert != null) dest.Assert = (AssertComponent)Assert.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TestActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TestActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if (!DeepComparable.Matches(Assert, otherT.Assert)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TestActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if (!DeepComparable.IsExactly(Assert, otherT.Assert)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Operation != null) yield return Operation;
                    if (Assert != null) yield return Assert;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                    if (Assert != null) yield return new ElementValue("assert", Assert);
                }
            }


        }


        [FhirType("TeardownComponent")]
        [DataContract]
        public partial class TeardownComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TeardownComponent"; } }

            /// <summary>
            /// One or more teardown operations to perform
            /// </summary>
            [FhirElement("action", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<TeardownActionComponent> Action
            {
                get { if (_action==null) _action = new List<TeardownActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<TeardownActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TeardownComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Action != null) dest.Action = new List<TeardownActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TeardownComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TeardownComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TeardownComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("TeardownActionComponent")]
        [DataContract]
        public partial class TeardownActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TeardownActionComponent"; } }

            /// <summary>
            /// The teardown operation to perform
            /// </summary>
            [FhirElement("operation", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public OperationComponent Operation
            {
                get { return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private OperationComponent _operation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TeardownActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Operation != null) dest.Operation = (OperationComponent)Operation.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TeardownActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TeardownActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Operation, otherT.Operation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TeardownActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Operation != null) yield return Operation;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Operation != null) yield return new ElementValue("operation", Operation);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this test script, represented as a URI (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Canonical identifier for this test script, represented as a URI (globally unique)
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
        /// Additional identifier for the test script
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Business version of the test script
        /// </summary>
        [FhirElement("version", InSummary=true, Order=110)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Business version of the test script
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
        /// Name for this test script (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name for this test script (computer friendly)
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
        /// Name for this test script (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=true, Order=130)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Name for this test script (human friendly)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                    TitleElement = null;
                else
                    TitleElement = new FhirString(value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<PublicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<PublicationStatus> _statusElement;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=150)]
        [DataMember]
        public FhirBoolean ExperimentalElement
        {
            get { return _experimentalElement; }
            set { _experimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }

        private FhirBoolean _experimentalElement;

        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (value == null)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }

        /// <summary>
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=160)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date last changed
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
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=170)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (organization or individual)
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
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Natural language description of the test script
        /// </summary>
        [FhirElement("description", Order=190)]
        [DataMember]
        public Markdown DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private Markdown _descriptionElement;

        /// <summary>
        /// Natural language description of the test script
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
                    DescriptionElement = new Markdown(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for test script (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Why this test script is defined
        /// </summary>
        [FhirElement("purpose", Order=220)]
        [DataMember]
        public Markdown PurposeElement
        {
            get { return _purposeElement; }
            set { _purposeElement = value; OnPropertyChanged("PurposeElement"); }
        }

        private Markdown _purposeElement;

        /// <summary>
        /// Why this test script is defined
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Purpose
        {
            get { return PurposeElement != null ? PurposeElement.Value : null; }
            set
            {
                if (value == null)
                    PurposeElement = null;
                else
                    PurposeElement = new Markdown(value);
                OnPropertyChanged("Purpose");
            }
        }

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=230)]
        [DataMember]
        public Markdown CopyrightElement
        {
            get { return _copyrightElement; }
            set { _copyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }

        private Markdown _copyrightElement;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if (value == null)
                    CopyrightElement = null;
                else
                    CopyrightElement = new Markdown(value);
                OnPropertyChanged("Copyright");
            }
        }

        /// <summary>
        /// An abstract server representing a client or sender in a message exchange
        /// </summary>
        [FhirElement("origin", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<OriginComponent> Origin
        {
            get { if (_origin==null) _origin = new List<OriginComponent>(); return _origin; }
            set { _origin = value; OnPropertyChanged("Origin"); }
        }

        private List<OriginComponent> _origin;

        /// <summary>
        /// An abstract server representing a destination or receiver in a message exchange
        /// </summary>
        [FhirElement("destination", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DestinationComponent> Destination
        {
            get { if (_destination==null) _destination = new List<DestinationComponent>(); return _destination; }
            set { _destination = value; OnPropertyChanged("Destination"); }
        }

        private List<DestinationComponent> _destination;

        /// <summary>
        /// Required capability that is assumed to function correctly on the FHIR server being tested
        /// </summary>
        [FhirElement("metadata", Order=260)]
        [DataMember]
        public MetadataComponent Metadata
        {
            get { return _metadata; }
            set { _metadata = value; OnPropertyChanged("Metadata"); }
        }

        private MetadataComponent _metadata;

        /// <summary>
        /// Fixture in the test script - by reference (uri)
        /// </summary>
        [FhirElement("fixture", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FixtureComponent> Fixture
        {
            get { if (_fixture==null) _fixture = new List<FixtureComponent>(); return _fixture; }
            set { _fixture = value; OnPropertyChanged("Fixture"); }
        }

        private List<FixtureComponent> _fixture;

        /// <summary>
        /// Reference of the validation profile
        /// </summary>
        [FhirElement("profile", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Profile
        {
            get { if (_profile==null) _profile = new List<ResourceReference>(); return _profile; }
            set { _profile = value; OnPropertyChanged("Profile"); }
        }

        private List<ResourceReference> _profile;

        /// <summary>
        /// Placeholder for evaluated elements
        /// </summary>
        [FhirElement("variable", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<VariableComponent> Variable
        {
            get { if (_variable==null) _variable = new List<VariableComponent>(); return _variable; }
            set { _variable = value; OnPropertyChanged("Variable"); }
        }

        private List<VariableComponent> _variable;

        /// <summary>
        /// Assert rule used within the test script
        /// </summary>
        [FhirElement("rule", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RuleComponent> Rule
        {
            get { if (_rule==null) _rule = new List<RuleComponent>(); return _rule; }
            set { _rule = value; OnPropertyChanged("Rule"); }
        }

        private List<RuleComponent> _rule;

        /// <summary>
        /// Assert ruleset used within the test script
        /// </summary>
        [FhirElement("ruleset", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RulesetComponent> Ruleset
        {
            get { if (_ruleset==null) _ruleset = new List<RulesetComponent>(); return _ruleset; }
            set { _ruleset = value; OnPropertyChanged("Ruleset"); }
        }

        private List<RulesetComponent> _ruleset;

        /// <summary>
        /// A series of required setup operations before tests are executed
        /// </summary>
        [FhirElement("setup", Order=320)]
        [DataMember]
        public SetupComponent Setup
        {
            get { return _setup; }
            set { _setup = value; OnPropertyChanged("Setup"); }
        }

        private SetupComponent _setup;

        /// <summary>
        /// A test in this script
        /// </summary>
        [FhirElement("test", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TestComponent> Test
        {
            get { if (_test==null) _test = new List<TestComponent>(); return _test; }
            set { _test = value; OnPropertyChanged("Test"); }
        }

        private List<TestComponent> _test;

        /// <summary>
        /// A series of required clean up steps
        /// </summary>
        [FhirElement("teardown", Order=340)]
        [DataMember]
        public TeardownComponent Teardown
        {
            get { return _teardown; }
            set { _teardown = value; OnPropertyChanged("Teardown"); }
        }

        private TeardownComponent _teardown;


        public static ElementDefinition.ConstraintComponent TestScript_TST_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "tst-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "metadata.all(capability.required.exists() or capability.validated.exists())",
            Key = "tst-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "TestScript metadata capability SHALL contain required or validated or both.",
            Xpath = "f:capability/f:required or f:capability/f:validated or (f:capability/f:required and f:capability/f:validated)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "variable.all(expression.empty() or headerField.empty() or path.empty())",
            Key = "tst-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Variable can only contain one of expression, headerField or path.",
            Xpath = "not(f:expression and f:headerField and f:path)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.all(operation.exists() xor assert.exists())",
            Key = "tst-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Setup action SHALL contain either an operation or assert but not both.",
            Xpath = "(f:operation or f:assert) and not(f:operation and f:assert)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.operation.all(sourceId.exists() or (targetId.count() + url.count() + params.count() = 1) or (type.code in ('capabilities' |'search' | 'transaction' | 'history')))",
            Key = "tst-7",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Setup operation SHALL contain either sourceId or targetId or params or url.",
            Xpath = "f:sourceId or ((f:targetId or f:url or f:params) and (count(f:targetId) + count(f:url) + count(f:params) =1)) or (f:type/f:code/@value='capabilities' or f:type/f:code/@value='search' or f:type/f:code/@value='transaction' or f:type/f:code/@value='history')"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_12 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.assert.all((response.empty() and responseCode.empty() and direction = 'request') or direction.empty() or direction = 'response')",
            Key = "tst-12",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Setup action assert response and responseCode SHALL be empty when direction equals request",
            Xpath = "((count(f:response) + count(f:responseCode)) = 0 and (f:direction/@value='request')) or (count(f:direction) = 0) or (f:direction/@value='response')"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.assert.all(contentType.count() + expression.count() + headerField.count() + minimumId.count() + navigationLinks.count() + path.count() + requestMethod.count() + resource.count() + responseCode.count() + response.count() + rule.count() + ruleset.count() + validateProfileId.count() <=1)",
            Key = "tst-5",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Only a single assertion SHALL be present within setup action assert element.",
            Xpath = "count(f:contentType) + count(f:expression) + count(f:headerField) + count(f:minimumId) + count(f:navigationLinks) + count(f:path) + count(f:requestMethod) + count(f:resource) + count(f:responseCode) + count(f:response) + count(f:rule) + count(f:ruleset) + count(f:validateProfileId)  <=1"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_10 = new ElementDefinition.ConstraintComponent
        {
            Expression = "setup.action.assert.all(compareToSourceId.empty() xor (compareToSourceExpression.exists() or compareToSourcePath.exists()))",
            Key = "tst-10",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Setup action assert SHALL contain either compareToSourceId and compareToSourceExpression, compareToSourceId and compareToSourcePath or neither.",
            Xpath = "(f:compareToSourceId and f:compareToSourceExpression) or (f:compareToSourceId and f:compareToSourcePath) or not(f:compareToSourceId or f:compareToSourceExpression or f:compareToSourcePath)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.all(operation.exists() xor assert.exists())",
            Key = "tst-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Test action SHALL contain either an operation or assert but not both.",
            Xpath = "(f:operation or f:assert) and not(f:operation and f:assert)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_8 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.operation.all(sourceId.exists() or (targetId.count() + url.count() + params.count() = 1) or (type.code in ('capabilities' | 'search' | 'transaction' | 'history')))",
            Key = "tst-8",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Test operation SHALL contain either sourceId or targetId or params or url.",
            Xpath = "f:sourceId or (f:targetId or f:url or f:params) and (count(f:targetId) + count(f:url) + count(f:params) =1) or (f:type/f:code/@value='capabilities' or f:type/f:code/@value='search' or f:type/f:code/@value='transaction' or f:type/f:code/@value='history')"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_11 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.assert.all(compareToSourceId.empty() xor (compareToSourceExpression.exists() or compareToSourcePath.exists()))",
            Key = "tst-11",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Test action assert SHALL contain either compareToSourceId and compareToSourceExpression, compareToSourceId and compareToSourcePath or neither.",
            Xpath = "(f:compareToSourceId and f:compareToSourceExpression) or (f:compareToSourceId and f:compareToSourcePath) or not(f:compareToSourceId or f:compareToSourceExpression or f:compareToSourcePath)"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_13 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.assert.all((response.empty() and responseCode.empty() and direction = 'request') or direction.empty() or direction = 'response')",
            Key = "tst-13",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Test action assert response and response and responseCode SHALL be empty when direction equals request",
            Xpath = "((count(f:response) + count(f:responseCode)) = 0 and (f:direction/@value='request')) or (count(f:direction) = 0) or (f:direction/@value='response')"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "test.action.assert.all(contentType.count() + expression.count() + headerField.count() + minimumId.count() + navigationLinks.count() + path.count() + requestMethod.count() + resource.count() + responseCode.count() + response.count() + rule.count() + ruleset.count() + validateProfileId.count() <=1)",
            Key = "tst-6",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Only a single assertion SHALL be present within test action assert element.",
            Xpath = "count(f:contentType) + count(f:expression) + count(f:headerField) + count(f:minimumId) + count(f:navigationLinks) + count(f:path) + count(f:requestMethod) + count(f:resource) + count(f:responseCode) + count(f:response) + count(f:rule) + count(f:ruleset) + count(f:validateProfileId)  <=1"
        };

        public static ElementDefinition.ConstraintComponent TestScript_TST_9 = new ElementDefinition.ConstraintComponent
        {
            Expression = "teardown.action.operation.all(sourceId.exists() or (targetId.count() + url.count() + params.count() = 1) or (type.code in ('capabilities' | 'search' | 'transaction' | 'history')))",
            Key = "tst-9",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Teardown operation SHALL contain either sourceId or targetId or params or url.",
            Xpath = "f:sourceId or (f:targetId or f:url or (f:params and f:resource)) and (count(f:targetId) + count(f:url) + count(f:params) =1) or (f:type/f:code/@value='capabilities' or f:type/f:code/@value='search' or f:type/f:code/@value='transaction' or f:type/f:code/@value='history')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(TestScript_TST_0);
            InvariantConstraints.Add(TestScript_TST_4);
            InvariantConstraints.Add(TestScript_TST_3);
            InvariantConstraints.Add(TestScript_TST_1);
            InvariantConstraints.Add(TestScript_TST_7);
            InvariantConstraints.Add(TestScript_TST_12);
            InvariantConstraints.Add(TestScript_TST_5);
            InvariantConstraints.Add(TestScript_TST_10);
            InvariantConstraints.Add(TestScript_TST_2);
            InvariantConstraints.Add(TestScript_TST_8);
            InvariantConstraints.Add(TestScript_TST_11);
            InvariantConstraints.Add(TestScript_TST_13);
            InvariantConstraints.Add(TestScript_TST_6);
            InvariantConstraints.Add(TestScript_TST_9);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as TestScript;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (PurposeElement != null) dest.PurposeElement = (Markdown)PurposeElement.DeepCopy();
                if (CopyrightElement != null) dest.CopyrightElement = (Markdown)CopyrightElement.DeepCopy();
                if (Origin != null) dest.Origin = new List<OriginComponent>(Origin.DeepCopy());
                if (Destination != null) dest.Destination = new List<DestinationComponent>(Destination.DeepCopy());
                if (Metadata != null) dest.Metadata = (MetadataComponent)Metadata.DeepCopy();
                if (Fixture != null) dest.Fixture = new List<FixtureComponent>(Fixture.DeepCopy());
                if (Profile != null) dest.Profile = new List<ResourceReference>(Profile.DeepCopy());
                if (Variable != null) dest.Variable = new List<VariableComponent>(Variable.DeepCopy());
                if (Rule != null) dest.Rule = new List<RuleComponent>(Rule.DeepCopy());
                if (Ruleset != null) dest.Ruleset = new List<RulesetComponent>(Ruleset.DeepCopy());
                if (Setup != null) dest.Setup = (SetupComponent)Setup.DeepCopy();
                if (Test != null) dest.Test = new List<TestComponent>(Test.DeepCopy());
                if (Teardown != null) dest.Teardown = (TeardownComponent)Teardown.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new TestScript());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as TestScript;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if ( !DeepComparable.Matches(Origin, otherT.Origin)) return false;
            if ( !DeepComparable.Matches(Destination, otherT.Destination)) return false;
            if (!DeepComparable.Matches(Metadata, otherT.Metadata)) return false;
            if ( !DeepComparable.Matches(Fixture, otherT.Fixture)) return false;
            if ( !DeepComparable.Matches(Profile, otherT.Profile)) return false;
            if ( !DeepComparable.Matches(Variable, otherT.Variable)) return false;
            if ( !DeepComparable.Matches(Rule, otherT.Rule)) return false;
            if ( !DeepComparable.Matches(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.Matches(Setup, otherT.Setup)) return false;
            if ( !DeepComparable.Matches(Test, otherT.Test)) return false;
            if (!DeepComparable.Matches(Teardown, otherT.Teardown)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as TestScript;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.IsExactly(Origin, otherT.Origin)) return false;
            if (!DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
            if (!DeepComparable.IsExactly(Metadata, otherT.Metadata)) return false;
            if (!DeepComparable.IsExactly(Fixture, otherT.Fixture)) return false;
            if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
            if (!DeepComparable.IsExactly(Variable, otherT.Variable)) return false;
            if (!DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
            if (!DeepComparable.IsExactly(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.IsExactly(Setup, otherT.Setup)) return false;
            if (!DeepComparable.IsExactly(Test, otherT.Test)) return false;
            if (!DeepComparable.IsExactly(Teardown, otherT.Teardown)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                if (Identifier != null) yield return Identifier;
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (TitleElement != null) yield return TitleElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (PurposeElement != null) yield return PurposeElement;
                if (CopyrightElement != null) yield return CopyrightElement;
                foreach (var elem in Origin) { if (elem != null) yield return elem; }
                foreach (var elem in Destination) { if (elem != null) yield return elem; }
                if (Metadata != null) yield return Metadata;
                foreach (var elem in Fixture) { if (elem != null) yield return elem; }
                foreach (var elem in Profile) { if (elem != null) yield return elem; }
                foreach (var elem in Variable) { if (elem != null) yield return elem; }
                foreach (var elem in Rule) { if (elem != null) yield return elem; }
                foreach (var elem in Ruleset) { if (elem != null) yield return elem; }
                if (Setup != null) yield return Setup;
                foreach (var elem in Test) { if (elem != null) yield return elem; }
                if (Teardown != null) yield return Teardown;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (PurposeElement != null) yield return new ElementValue("purpose", PurposeElement);
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                foreach (var elem in Origin) { if (elem != null) yield return new ElementValue("origin", elem); }
                foreach (var elem in Destination) { if (elem != null) yield return new ElementValue("destination", elem); }
                if (Metadata != null) yield return new ElementValue("metadata", Metadata);
                foreach (var elem in Fixture) { if (elem != null) yield return new ElementValue("fixture", elem); }
                foreach (var elem in Profile) { if (elem != null) yield return new ElementValue("profile", elem); }
                foreach (var elem in Variable) { if (elem != null) yield return new ElementValue("variable", elem); }
                foreach (var elem in Rule) { if (elem != null) yield return new ElementValue("rule", elem); }
                foreach (var elem in Ruleset) { if (elem != null) yield return new ElementValue("ruleset", elem); }
                if (Setup != null) yield return new ElementValue("setup", Setup);
                foreach (var elem in Test) { if (elem != null) yield return new ElementValue("test", elem); }
                if (Teardown != null) yield return new ElementValue("teardown", Teardown);
            }
        }

    }

}
