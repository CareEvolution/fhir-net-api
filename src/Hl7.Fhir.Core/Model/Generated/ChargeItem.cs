using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Item containing charge code(s) associated with the provision of healthcare provider products
    /// </summary>
    [FhirType("ChargeItem", IsResource=true)]
    [DataContract]
    public partial class ChargeItem : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ChargeItem; } }
        [NotMapped]
        public override string TypeName { get { return "ChargeItem"; } }

        /// <summary>
        /// Codes identifying the lifecycle stage of a ChargeItem
        /// (url: http://hl7.org/fhir/ValueSet/chargeitem-status)
        /// </summary>
        [FhirEnumeration("ChargeItemStatus")]
        public enum ChargeItemStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/chargeitem-status)
            /// </summary>
            [EnumLiteral("planned", "http://hl7.org/fhir/chargeitem-status"), Description("Planned")]
            Planned,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/chargeitem-status)
            /// </summary>
            [EnumLiteral("billable", "http://hl7.org/fhir/chargeitem-status"), Description("Billable")]
            Billable,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/chargeitem-status)
            /// </summary>
            [EnumLiteral("not-billable", "http://hl7.org/fhir/chargeitem-status"), Description("Not billable")]
            NotBillable,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/chargeitem-status)
            /// </summary>
            [EnumLiteral("aborted", "http://hl7.org/fhir/chargeitem-status"), Description("Aborted")]
            Aborted,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/chargeitem-status)
            /// </summary>
            [EnumLiteral("billed", "http://hl7.org/fhir/chargeitem-status"), Description("Billed")]
            Billed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/chargeitem-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/chargeitem-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/chargeitem-status)
            /// </summary>
            [EnumLiteral("unknown", "http://hl7.org/fhir/chargeitem-status"), Description("Unknown")]
            Unknown,
        }


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// What type of performance was done
            /// </summary>
            [FhirElement("role", Order=40)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            /// <summary>
            /// Individual who was performing
            /// </summary>
            [FhirElement("actor", Order=50)]
            [References("Practitioner","Organization","Patient","Device","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParticipantComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Actor != null) yield return Actor;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                }
            }


        }


        /// <summary>
        /// Business Identifier for item
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Defining information about the code of this charge item
        /// </summary>
        [FhirElement("definition", Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> DefinitionElement
        {
            get { if (_definitionElement==null) _definitionElement = new List<FhirUri>(); return _definitionElement; }
            set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
        }

        private List<FhirUri> _definitionElement;

        /// <summary>
        /// Defining information about the code of this charge item
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Definition
        {
            get { return DefinitionElement != null ? DefinitionElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    DefinitionElement = null;
                else
                    DefinitionElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("Definition");
            }
        }

        /// <summary>
        /// planned | billable | not-billable | aborted | billed | entered-in-error | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ChargeItemStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ChargeItemStatus> _statusElement;

        /// <summary>
        /// planned | billable | not-billable | aborted | billed | entered-in-error | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ChargeItemStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ChargeItemStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Part of referenced ChargeItem
        /// </summary>
        [FhirElement("partOf", Order=120)]
        [References("ChargeItem")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// A code that identifies the charge, like a billing code
        /// </summary>
        [FhirElement("code", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Individual service was done for/to
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=140)]
        [References("Patient","Group")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Encounter / Episode associated with event
        /// </summary>
        [FhirElement("context", InSummary=true, Order=150)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When the charged service was applied
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(Timing))]
        [DataMember]
        public Element Occurrence
        {
            get { return _occurrence; }
            set { _occurrence = value; OnPropertyChanged("Occurrence"); }
        }

        private Element _occurrence;

        /// <summary>
        /// Who performed charged service
        /// </summary>
        [FhirElement("participant", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if (_participant==null) _participant = new List<ParticipantComponent>(); return _participant; }
            set { _participant = value; OnPropertyChanged("Participant"); }
        }

        private List<ParticipantComponent> _participant;

        /// <summary>
        /// Organization providing the charged sevice
        /// </summary>
        [FhirElement("performingOrganization", Order=180)]
        [References("Organization")]
        [DataMember]
        public ResourceReference PerformingOrganization
        {
            get { return _performingOrganization; }
            set { _performingOrganization = value; OnPropertyChanged("PerformingOrganization"); }
        }

        private ResourceReference _performingOrganization;

        /// <summary>
        /// Organization requesting the charged service
        /// </summary>
        [FhirElement("requestingOrganization", Order=190)]
        [References("Organization")]
        [DataMember]
        public ResourceReference RequestingOrganization
        {
            get { return _requestingOrganization; }
            set { _requestingOrganization = value; OnPropertyChanged("RequestingOrganization"); }
        }

        private ResourceReference _requestingOrganization;

        /// <summary>
        /// Organization that has ownership of the (potential, future) revenue
        /// </summary>
        [FhirElement("costCenter", Order=200)]
        [References("Organization","OrganizationRole")]
        [DataMember]
        public ResourceReference CostCenter
        {
            get { return _costCenter; }
            set { _costCenter = value; OnPropertyChanged("CostCenter"); }
        }

        private ResourceReference _costCenter;

        /// <summary>
        /// Quantity of which the charge item has been serviced
        /// </summary>
        [FhirElement("quantity", InSummary=true, Order=210)]
        [DataMember]
        public Quantity Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged("Quantity"); }
        }

        private Quantity _quantity;

        /// <summary>
        /// Anatomical location, if relevant
        /// </summary>
        [FhirElement("bodysite", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Bodysite
        {
            get { if (_bodysite==null) _bodysite = new List<CodeableConcept>(); return _bodysite; }
            set { _bodysite = value; OnPropertyChanged("Bodysite"); }
        }

        private List<CodeableConcept> _bodysite;

        /// <summary>
        /// Factor overriding the associated rules
        /// </summary>
        [FhirElement("factorOverride", Order=230)]
        [DataMember]
        public FhirDecimal FactorOverrideElement
        {
            get { return _factorOverrideElement; }
            set { _factorOverrideElement = value; OnPropertyChanged("FactorOverrideElement"); }
        }

        private FhirDecimal _factorOverrideElement;

        /// <summary>
        /// Factor overriding the associated rules
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public decimal? FactorOverride
        {
            get { return FactorOverrideElement != null ? FactorOverrideElement.Value : null; }
            set
            {
                if (value == null)
                    FactorOverrideElement = null;
                else
                    FactorOverrideElement = new FhirDecimal(value);
                OnPropertyChanged("FactorOverride");
            }
        }

        /// <summary>
        /// Price overriding the associated rules
        /// </summary>
        [FhirElement("priceOverride", Order=240)]
        [DataMember]
        public Money PriceOverride
        {
            get { return _priceOverride; }
            set { _priceOverride = value; OnPropertyChanged("PriceOverride"); }
        }

        private Money _priceOverride;

        /// <summary>
        /// Reason for overriding the list price/factor
        /// </summary>
        [FhirElement("overrideReason", Order=250)]
        [DataMember]
        public FhirString OverrideReasonElement
        {
            get { return _overrideReasonElement; }
            set { _overrideReasonElement = value; OnPropertyChanged("OverrideReasonElement"); }
        }

        private FhirString _overrideReasonElement;

        /// <summary>
        /// Reason for overriding the list price/factor
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string OverrideReason
        {
            get { return OverrideReasonElement != null ? OverrideReasonElement.Value : null; }
            set
            {
                if (value == null)
                    OverrideReasonElement = null;
                else
                    OverrideReasonElement = new FhirString(value);
                OnPropertyChanged("OverrideReason");
            }
        }

        /// <summary>
        /// Individual who was entering
        /// </summary>
        [FhirElement("enterer", InSummary=true, Order=260)]
        [References("Practitioner","Organization","Patient","Device","RelatedPerson")]
        [DataMember]
        public ResourceReference Enterer
        {
            get { return _enterer; }
            set { _enterer = value; OnPropertyChanged("Enterer"); }
        }

        private ResourceReference _enterer;

        /// <summary>
        /// Date the charge item was entered
        /// </summary>
        [FhirElement("enteredDate", InSummary=true, Order=270)]
        [DataMember]
        public FhirDateTime EnteredDateElement
        {
            get { return _enteredDateElement; }
            set { _enteredDateElement = value; OnPropertyChanged("EnteredDateElement"); }
        }

        private FhirDateTime _enteredDateElement;

        /// <summary>
        /// Date the charge item was entered
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string EnteredDate
        {
            get { return EnteredDateElement != null ? EnteredDateElement.Value : null; }
            set
            {
                if (value == null)
                    EnteredDateElement = null;
                else
                    EnteredDateElement = new FhirDateTime(value);
                OnPropertyChanged("EnteredDate");
            }
        }

        /// <summary>
        /// Why was the charged  service rendered?
        /// </summary>
        [FhirElement("reason", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Reason
        {
            get { if (_reason==null) _reason = new List<CodeableConcept>(); return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private List<CodeableConcept> _reason;

        /// <summary>
        /// Which rendered service is being charged?
        /// </summary>
        [FhirElement("service", Order=290)]
        [References("DiagnosticReport","ImagingStudy","Immunization","MedicationAdministration","MedicationDispense","Observation","Procedure","SupplyDelivery")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Service
        {
            get { if (_service==null) _service = new List<ResourceReference>(); return _service; }
            set { _service = value; OnPropertyChanged("Service"); }
        }

        private List<ResourceReference> _service;

        /// <summary>
        /// Account to place this charge
        /// </summary>
        [FhirElement("account", InSummary=true, Order=300)]
        [References("Account")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Account
        {
            get { if (_account==null) _account = new List<ResourceReference>(); return _account; }
            set { _account = value; OnPropertyChanged("Account"); }
        }

        private List<ResourceReference> _account;

        /// <summary>
        /// Comments made about the ChargeItem
        /// </summary>
        [FhirElement("note", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Further information supporting this charge
        /// </summary>
        [FhirElement("supportingInformation", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInformation
        {
            get { if (_supportingInformation==null) _supportingInformation = new List<ResourceReference>(); return _supportingInformation; }
            set { _supportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }

        private List<ResourceReference> _supportingInformation;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ChargeItem;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (DefinitionElement != null) dest.DefinitionElement = new List<FhirUri>(DefinitionElement.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<ChargeItemStatus>)StatusElement.DeepCopy();
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                if (PerformingOrganization != null) dest.PerformingOrganization = (ResourceReference)PerformingOrganization.DeepCopy();
                if (RequestingOrganization != null) dest.RequestingOrganization = (ResourceReference)RequestingOrganization.DeepCopy();
                if (CostCenter != null) dest.CostCenter = (ResourceReference)CostCenter.DeepCopy();
                if (Quantity != null) dest.Quantity = (Quantity)Quantity.DeepCopy();
                if (Bodysite != null) dest.Bodysite = new List<CodeableConcept>(Bodysite.DeepCopy());
                if (FactorOverrideElement != null) dest.FactorOverrideElement = (FhirDecimal)FactorOverrideElement.DeepCopy();
                if (PriceOverride != null) dest.PriceOverride = (Money)PriceOverride.DeepCopy();
                if (OverrideReasonElement != null) dest.OverrideReasonElement = (FhirString)OverrideReasonElement.DeepCopy();
                if (Enterer != null) dest.Enterer = (ResourceReference)Enterer.DeepCopy();
                if (EnteredDateElement != null) dest.EnteredDateElement = (FhirDateTime)EnteredDateElement.DeepCopy();
                if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                if (Service != null) dest.Service = new List<ResourceReference>(Service.DeepCopy());
                if (Account != null) dest.Account = new List<ResourceReference>(Account.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (SupportingInformation != null) dest.SupportingInformation = new List<ResourceReference>(SupportingInformation.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ChargeItem());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ChargeItem;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if ( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if (!DeepComparable.Matches(PerformingOrganization, otherT.PerformingOrganization)) return false;
            if (!DeepComparable.Matches(RequestingOrganization, otherT.RequestingOrganization)) return false;
            if (!DeepComparable.Matches(CostCenter, otherT.CostCenter)) return false;
            if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if ( !DeepComparable.Matches(Bodysite, otherT.Bodysite)) return false;
            if (!DeepComparable.Matches(FactorOverrideElement, otherT.FactorOverrideElement)) return false;
            if (!DeepComparable.Matches(PriceOverride, otherT.PriceOverride)) return false;
            if (!DeepComparable.Matches(OverrideReasonElement, otherT.OverrideReasonElement)) return false;
            if (!DeepComparable.Matches(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.Matches(EnteredDateElement, otherT.EnteredDateElement)) return false;
            if ( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if ( !DeepComparable.Matches(Service, otherT.Service)) return false;
            if ( !DeepComparable.Matches(Account, otherT.Account)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ChargeItem;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if (!DeepComparable.IsExactly(PerformingOrganization, otherT.PerformingOrganization)) return false;
            if (!DeepComparable.IsExactly(RequestingOrganization, otherT.RequestingOrganization)) return false;
            if (!DeepComparable.IsExactly(CostCenter, otherT.CostCenter)) return false;
            if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.IsExactly(Bodysite, otherT.Bodysite)) return false;
            if (!DeepComparable.IsExactly(FactorOverrideElement, otherT.FactorOverrideElement)) return false;
            if (!DeepComparable.IsExactly(PriceOverride, otherT.PriceOverride)) return false;
            if (!DeepComparable.IsExactly(OverrideReasonElement, otherT.OverrideReasonElement)) return false;
            if (!DeepComparable.IsExactly(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.IsExactly(EnteredDateElement, otherT.EnteredDateElement)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
            if (!DeepComparable.IsExactly(Account, otherT.Account)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in DefinitionElement) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (Code != null) yield return Code;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Occurrence != null) yield return Occurrence;
                foreach (var elem in Participant) { if (elem != null) yield return elem; }
                if (PerformingOrganization != null) yield return PerformingOrganization;
                if (RequestingOrganization != null) yield return RequestingOrganization;
                if (CostCenter != null) yield return CostCenter;
                if (Quantity != null) yield return Quantity;
                foreach (var elem in Bodysite) { if (elem != null) yield return elem; }
                if (FactorOverrideElement != null) yield return FactorOverrideElement;
                if (PriceOverride != null) yield return PriceOverride;
                if (OverrideReasonElement != null) yield return OverrideReasonElement;
                if (Enterer != null) yield return Enterer;
                if (EnteredDateElement != null) yield return EnteredDateElement;
                foreach (var elem in Reason) { if (elem != null) yield return elem; }
                foreach (var elem in Service) { if (elem != null) yield return elem; }
                foreach (var elem in Account) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in DefinitionElement) { if (elem != null) yield return new ElementValue("definition", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (Code != null) yield return new ElementValue("code", Code);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
                if (PerformingOrganization != null) yield return new ElementValue("performingOrganization", PerformingOrganization);
                if (RequestingOrganization != null) yield return new ElementValue("requestingOrganization", RequestingOrganization);
                if (CostCenter != null) yield return new ElementValue("costCenter", CostCenter);
                if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                foreach (var elem in Bodysite) { if (elem != null) yield return new ElementValue("bodysite", elem); }
                if (FactorOverrideElement != null) yield return new ElementValue("factorOverride", FactorOverrideElement);
                if (PriceOverride != null) yield return new ElementValue("priceOverride", PriceOverride);
                if (OverrideReasonElement != null) yield return new ElementValue("overrideReason", OverrideReasonElement);
                if (Enterer != null) yield return new ElementValue("enterer", Enterer);
                if (EnteredDateElement != null) yield return new ElementValue("enteredDate", EnteredDateElement);
                foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                foreach (var elem in Service) { if (elem != null) yield return new ElementValue("service", elem); }
                foreach (var elem in Account) { if (elem != null) yield return new ElementValue("account", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", elem); }
            }
        }

    }

}
