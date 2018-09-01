using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.STU3;
using Hl7.Fhir.Validation.STU3;
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
// Generated for FHIR v3.0.1
//
namespace Hl7.Fhir.Model.STU3
{
    /// <summary>
    /// A request for referral or transfer of care
    /// </summary>
    [FhirType("ReferralRequest", IsResource=true)]
    [DataContract]
    public partial class ReferralRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ReferralRequest; } }
        [NotMapped]
        public override string TypeName { get { return "ReferralRequest"; } }


        [FhirType("RequesterComponent")]
        [DataContract]
        public partial class RequesterComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RequesterComponent"; } }

            /// <summary>
            /// Individual making the request
            /// </summary>
            [FhirElement("agent", InSummary=true, Order=40)]
            [References("Practitioner","Organization","Patient","RelatedPerson","Device")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Agent
            {
                get { return _agent; }
                set { _agent = value; OnPropertyChanged("Agent"); }
            }

            private ResourceReference _agent;

            /// <summary>
            /// Organization agent is acting for
            /// </summary>
            [FhirElement("onBehalfOf", InSummary=true, Order=50)]
            [References("Organization")]
            [DataMember]
            public ResourceReference OnBehalfOf
            {
                get { return _onBehalfOf; }
                set { _onBehalfOf = value; OnPropertyChanged("OnBehalfOf"); }
            }

            private ResourceReference _onBehalfOf;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RequesterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Agent != null) dest.Agent = (ResourceReference)Agent.DeepCopy();
                    if (OnBehalfOf != null) dest.OnBehalfOf = (ResourceReference)OnBehalfOf.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RequesterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RequesterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Agent, otherT.Agent)) return false;
                if (!DeepComparable.Matches(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RequesterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
                if (!DeepComparable.IsExactly(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Agent != null) yield return Agent;
                    if (OnBehalfOf != null) yield return OnBehalfOf;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Agent != null) yield return new ElementValue("agent", Agent);
                    if (OnBehalfOf != null) yield return new ElementValue("onBehalfOf", OnBehalfOf);
                }
            }


        }


        /// <summary>
        /// Business identifier
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
        /// Instantiates protocol or definition
        /// </summary>
        [FhirElement("definition", InSummary=true, Order=100)]
        [References("ActivityDefinition","PlanDefinition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Definition
        {
            get { if (_definition==null) _definition = new List<ResourceReference>(); return _definition; }
            set { _definition = value; OnPropertyChanged("Definition"); }
        }

        private List<ResourceReference> _definition;

        /// <summary>
        /// Request fulfilled by this request
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=110)]
        [References("ReferralRequest","CarePlan","ProcedureRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Request(s) replaced by this request
        /// </summary>
        [FhirElement("replaces", InSummary=true, Order=120)]
        [References("ReferralRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Replaces
        {
            get { if (_replaces==null) _replaces = new List<ResourceReference>(); return _replaces; }
            set { _replaces = value; OnPropertyChanged("Replaces"); }
        }

        private List<ResourceReference> _replaces;

        /// <summary>
        /// Composite request this is part of
        /// </summary>
        [FhirElement("groupIdentifier", InSummary=true, Order=130)]
        [DataMember]
        public Identifier GroupIdentifier
        {
            get { return _groupIdentifier; }
            set { _groupIdentifier = value; OnPropertyChanged("GroupIdentifier"); }
        }

        private Identifier _groupIdentifier;

        /// <summary>
        /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<RequestStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<RequestStatus> _statusElement;

        /// <summary>
        /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RequestStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<RequestStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// proposal | plan | order
        /// </summary>
        [FhirElement("intent", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<RequestIntent> IntentElement
        {
            get { return _intentElement; }
            set { _intentElement = value; OnPropertyChanged("IntentElement"); }
        }

        private Code<RequestIntent> _intentElement;

        /// <summary>
        /// proposal | plan | order
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RequestIntent? Intent
        {
            get { return IntentElement != null ? IntentElement.Value : null; }
            set
            {
                if (value == null)
                    IntentElement = null;
                else
                    IntentElement = new Code<RequestIntent>(value);
                OnPropertyChanged("Intent");
            }
        }

        /// <summary>
        /// Referral/Transition of care request type
        /// </summary>
        [FhirElement("type", InSummary=true, Order=160)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Urgency of referral / transfer of care request
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=170)]
        [DataMember]
        public Code<RequestPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<RequestPriority> _priorityElement;

        /// <summary>
        /// Urgency of referral / transfer of care request
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RequestPriority? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (value == null)
                    PriorityElement = null;
                else
                    PriorityElement = new Code<RequestPriority>(value);
                OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        /// Actions requested as part of the referral
        /// </summary>
        [FhirElement("serviceRequested", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ServiceRequested
        {
            get { if (_serviceRequested==null) _serviceRequested = new List<CodeableConcept>(); return _serviceRequested; }
            set { _serviceRequested = value; OnPropertyChanged("ServiceRequested"); }
        }

        private List<CodeableConcept> _serviceRequested;

        /// <summary>
        /// Patient referred to care or transfer
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=190)]
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
        /// Originating encounter
        /// </summary>
        [FhirElement("context", InSummary=true, Order=200)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When the service(s) requested in the referral should occur
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=210, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [DataMember]
        public Element Occurrence
        {
            get { return _occurrence; }
            set { _occurrence = value; OnPropertyChanged("Occurrence"); }
        }

        private Element _occurrence;

        /// <summary>
        /// Date of creation/activation
        /// </summary>
        [FhirElement("authoredOn", InSummary=true, Order=220)]
        [DataMember]
        public FhirDateTime AuthoredOnElement
        {
            get { return _authoredOnElement; }
            set { _authoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }

        private FhirDateTime _authoredOnElement;

        /// <summary>
        /// Date of creation/activation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string AuthoredOn
        {
            get { return AuthoredOnElement != null ? AuthoredOnElement.Value : null; }
            set
            {
                if (value == null)
                    AuthoredOnElement = null;
                else
                    AuthoredOnElement = new FhirDateTime(value);
                OnPropertyChanged("AuthoredOn");
            }
        }

        /// <summary>
        /// Who/what is requesting service
        /// </summary>
        [FhirElement("requester", InSummary=true, Order=230)]
        [DataMember]
        public RequesterComponent Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private RequesterComponent _requester;

        /// <summary>
        /// The clinical specialty (discipline) that the referral is requested for
        /// </summary>
        [FhirElement("specialty", Order=240)]
        [DataMember]
        public CodeableConcept Specialty
        {
            get { return _specialty; }
            set { _specialty = value; OnPropertyChanged("Specialty"); }
        }

        private CodeableConcept _specialty;

        /// <summary>
        /// Receiver of referral / transfer of care request
        /// </summary>
        [FhirElement("recipient", InSummary=true, Order=250)]
        [References("Practitioner","Organization","HealthcareService")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Recipient
        {
            get { if (_recipient==null) _recipient = new List<ResourceReference>(); return _recipient; }
            set { _recipient = value; OnPropertyChanged("Recipient"); }
        }

        private List<ResourceReference> _recipient;

        /// <summary>
        /// Reason for referral / transfer of care request
        /// </summary>
        [FhirElement("reasonCode", InSummary=true, Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Why is service needed?
        /// </summary>
        [FhirElement("reasonReference", InSummary=true, Order=270)]
        [References("Condition","Observation")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// A textual description of the referral
        /// </summary>
        [FhirElement("description", Order=280)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// A textual description of the referral
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
        /// Additonal information to support referral or transfer of care request
        /// </summary>
        [FhirElement("supportingInfo", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInfo
        {
            get { if (_supportingInfo==null) _supportingInfo = new List<ResourceReference>(); return _supportingInfo; }
            set { _supportingInfo = value; OnPropertyChanged("SupportingInfo"); }
        }

        private List<ResourceReference> _supportingInfo;

        /// <summary>
        /// Comments made about referral request
        /// </summary>
        [FhirElement("note", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Key events in history of request
        /// </summary>
        [FhirElement("relevantHistory", Order=310)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> RelevantHistory
        {
            get { if (_relevantHistory==null) _relevantHistory = new List<ResourceReference>(); return _relevantHistory; }
            set { _relevantHistory = value; OnPropertyChanged("RelevantHistory"); }
        }

        private List<ResourceReference> _relevantHistory;


        public static ElementDefinition.ConstraintComponent ReferralRequest_RFR_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "requester.all((agent.resolve() is Device) or (agent.resolve() is Practitioner) or onBehalfOf.exists().not())",
            Key = "rfr-1",
            Severity = ConstraintSeverity.Warning,
            Human = "onBehalfOf can only be specified if agent is practitioner or device",
            Xpath = "contains(f:agent/f:reference/@value, '/Practitioner/') or contains(f:agent/f:reference/@value, '/Device/') or not(exists(f:onBehalfOf))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ReferralRequest_RFR_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ReferralRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Definition != null) dest.Definition = new List<ResourceReference>(Definition.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (Replaces != null) dest.Replaces = new List<ResourceReference>(Replaces.DeepCopy());
                if (GroupIdentifier != null) dest.GroupIdentifier = (Identifier)GroupIdentifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<RequestStatus>)StatusElement.DeepCopy();
                if (IntentElement != null) dest.IntentElement = (Code<RequestIntent>)IntentElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (PriorityElement != null) dest.PriorityElement = (Code<RequestPriority>)PriorityElement.DeepCopy();
                if (ServiceRequested != null) dest.ServiceRequested = new List<CodeableConcept>(ServiceRequested.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                if (AuthoredOnElement != null) dest.AuthoredOnElement = (FhirDateTime)AuthoredOnElement.DeepCopy();
                if (Requester != null) dest.Requester = (RequesterComponent)Requester.DeepCopy();
                if (Specialty != null) dest.Specialty = (CodeableConcept)Specialty.DeepCopy();
                if (Recipient != null) dest.Recipient = new List<ResourceReference>(Recipient.DeepCopy());
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (SupportingInfo != null) dest.SupportingInfo = new List<ResourceReference>(SupportingInfo.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (RelevantHistory != null) dest.RelevantHistory = new List<ResourceReference>(RelevantHistory.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ReferralRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ReferralRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.Matches(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if ( !DeepComparable.Matches(ServiceRequested, otherT.ServiceRequested)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if (!DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
            if ( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(SupportingInfo, otherT.SupportingInfo)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(RelevantHistory, otherT.RelevantHistory)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ReferralRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.IsExactly(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(ServiceRequested, otherT.ServiceRequested)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(SupportingInfo, otherT.SupportingInfo)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(RelevantHistory, otherT.RelevantHistory)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in Definition) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in Replaces) { if (elem != null) yield return elem; }
                if (GroupIdentifier != null) yield return GroupIdentifier;
                if (StatusElement != null) yield return StatusElement;
                if (IntentElement != null) yield return IntentElement;
                if (Type != null) yield return Type;
                if (PriorityElement != null) yield return PriorityElement;
                foreach (var elem in ServiceRequested) { if (elem != null) yield return elem; }
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Occurrence != null) yield return Occurrence;
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (Requester != null) yield return Requester;
                if (Specialty != null) yield return Specialty;
                foreach (var elem in Recipient) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in SupportingInfo) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in RelevantHistory) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in Definition) { if (elem != null) yield return new ElementValue("definition", elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                foreach (var elem in Replaces) { if (elem != null) yield return new ElementValue("replaces", elem); }
                if (GroupIdentifier != null) yield return new ElementValue("groupIdentifier", GroupIdentifier);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (IntentElement != null) yield return new ElementValue("intent", IntentElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                foreach (var elem in ServiceRequested) { if (elem != null) yield return new ElementValue("serviceRequested", elem); }
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", AuthoredOnElement);
                if (Requester != null) yield return new ElementValue("requester", Requester);
                if (Specialty != null) yield return new ElementValue("specialty", Specialty);
                foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", elem); }
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in SupportingInfo) { if (elem != null) yield return new ElementValue("supportingInfo", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in RelevantHistory) { if (elem != null) yield return new ElementValue("relevantHistory", elem); }
            }
        }

    }

}
