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
    /// A request for a procedure or diagnostic to be performed
    /// </summary>
    [FhirType("ProcedureRequest", IsResource=true)]
    [DataContract]
    public partial class ProcedureRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ProcedureRequest; } }
        [NotMapped]
        public override string TypeName { get { return "ProcedureRequest"; } }


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
            [References("Device","Practitioner","Organization")]
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
        /// Identifiers assigned to this order
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
        /// Protocol or definition
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
        /// What request fulfills
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// What request replaces
        /// </summary>
        [FhirElement("replaces", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Replaces
        {
            get { if (_replaces==null) _replaces = new List<ResourceReference>(); return _replaces; }
            set { _replaces = value; OnPropertyChanged("Replaces"); }
        }

        private List<ResourceReference> _replaces;

        /// <summary>
        /// Composite Request ID
        /// </summary>
        [FhirElement("requisition", InSummary=true, Order=130)]
        [DataMember]
        public Identifier Requisition
        {
            get { return _requisition; }
            set { _requisition = value; OnPropertyChanged("Requisition"); }
        }

        private Identifier _requisition;

        /// <summary>
        /// draft | active | suspended | completed | entered-in-error | cancelled
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
        /// draft | active | suspended | completed | entered-in-error | cancelled
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
        /// proposal | plan | order +
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
        /// proposal | plan | order +
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
        /// routine | urgent | asap | stat
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=160)]
        [DataMember]
        public Code<RequestPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<RequestPriority> _priorityElement;

        /// <summary>
        /// routine | urgent | asap | stat
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
        /// True if procedure should not be performed
        /// </summary>
        [FhirElement("doNotPerform", InSummary=true, Order=170)]
        [DataMember]
        public FhirBoolean DoNotPerformElement
        {
            get { return _doNotPerformElement; }
            set { _doNotPerformElement = value; OnPropertyChanged("DoNotPerformElement"); }
        }

        private FhirBoolean _doNotPerformElement;

        /// <summary>
        /// True if procedure should not be performed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? DoNotPerform
        {
            get { return DoNotPerformElement != null ? DoNotPerformElement.Value : null; }
            set
            {
                if (value == null)
                    DoNotPerformElement = null;
                else
                    DoNotPerformElement = new FhirBoolean(value);
                OnPropertyChanged("DoNotPerform");
            }
        }

        /// <summary>
        /// Classification of procedure
        /// </summary>
        [FhirElement("category", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// What is being requested/ordered
        /// </summary>
        [FhirElement("code", InSummary=true, Order=190)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Individual the service is ordered for
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=200)]
        [References("Patient","Group","Location","Device")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Encounter or Episode during which request was created
        /// </summary>
        [FhirElement("context", InSummary=true, Order=210)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When procedure should occur
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=220, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(Timing))]
        [DataMember]
        public Element Occurrence
        {
            get { return _occurrence; }
            set { _occurrence = value; OnPropertyChanged("Occurrence"); }
        }

        private Element _occurrence;

        /// <summary>
        /// Preconditions for procedure or diagnostic
        /// </summary>
        [FhirElement("asNeeded", InSummary=true, Order=230, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirBoolean),typeof(CodeableConcept))]
        [DataMember]
        public Element AsNeeded
        {
            get { return _asNeeded; }
            set { _asNeeded = value; OnPropertyChanged("AsNeeded"); }
        }

        private Element _asNeeded;

        /// <summary>
        /// Date request signed
        /// </summary>
        [FhirElement("authoredOn", InSummary=true, Order=240)]
        [DataMember]
        public FhirDateTime AuthoredOnElement
        {
            get { return _authoredOnElement; }
            set { _authoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }

        private FhirDateTime _authoredOnElement;

        /// <summary>
        /// Date request signed
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
        /// Who/what is requesting procedure or diagnostic
        /// </summary>
        [FhirElement("requester", InSummary=true, Order=250)]
        [DataMember]
        public RequesterComponent Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private RequesterComponent _requester;

        /// <summary>
        /// Performer role
        /// </summary>
        [FhirElement("performerType", InSummary=true, Order=260)]
        [DataMember]
        public CodeableConcept PerformerType
        {
            get { return _performerType; }
            set { _performerType = value; OnPropertyChanged("PerformerType"); }
        }

        private CodeableConcept _performerType;

        /// <summary>
        /// Requested perfomer
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=270)]
        [References("Practitioner","Organization","Patient","Device","RelatedPerson","HealthcareService")]
        [DataMember]
        public ResourceReference Performer
        {
            get { return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private ResourceReference _performer;

        /// <summary>
        /// Explanation/Justification for test
        /// </summary>
        [FhirElement("reasonCode", InSummary=true, Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Explanation/Justification for test
        /// </summary>
        [FhirElement("reasonReference", InSummary=true, Order=290)]
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
        /// Additional clinical information
        /// </summary>
        [FhirElement("supportingInfo", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInfo
        {
            get { if (_supportingInfo==null) _supportingInfo = new List<ResourceReference>(); return _supportingInfo; }
            set { _supportingInfo = value; OnPropertyChanged("SupportingInfo"); }
        }

        private List<ResourceReference> _supportingInfo;

        /// <summary>
        /// Procedure Samples
        /// </summary>
        [FhirElement("specimen", InSummary=true, Order=310)]
        [References("Specimen")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Specimen
        {
            get { if (_specimen==null) _specimen = new List<ResourceReference>(); return _specimen; }
            set { _specimen = value; OnPropertyChanged("Specimen"); }
        }

        private List<ResourceReference> _specimen;

        /// <summary>
        /// Location on Body
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> BodySite
        {
            get { if (_bodySite==null) _bodySite = new List<CodeableConcept>(); return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private List<CodeableConcept> _bodySite;

        /// <summary>
        /// Comments
        /// </summary>
        [FhirElement("note", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Request provenance
        /// </summary>
        [FhirElement("relevantHistory", Order=340)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> RelevantHistory
        {
            get { if (_relevantHistory==null) _relevantHistory = new List<ResourceReference>(); return _relevantHistory; }
            set { _relevantHistory = value; OnPropertyChanged("RelevantHistory"); }
        }

        private List<ResourceReference> _relevantHistory;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ProcedureRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Definition != null) dest.Definition = new List<ResourceReference>(Definition.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (Replaces != null) dest.Replaces = new List<ResourceReference>(Replaces.DeepCopy());
                if (Requisition != null) dest.Requisition = (Identifier)Requisition.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<RequestStatus>)StatusElement.DeepCopy();
                if (IntentElement != null) dest.IntentElement = (Code<RequestIntent>)IntentElement.DeepCopy();
                if (PriorityElement != null) dest.PriorityElement = (Code<RequestPriority>)PriorityElement.DeepCopy();
                if (DoNotPerformElement != null) dest.DoNotPerformElement = (FhirBoolean)DoNotPerformElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                if (AsNeeded != null) dest.AsNeeded = (Element)AsNeeded.DeepCopy();
                if (AuthoredOnElement != null) dest.AuthoredOnElement = (FhirDateTime)AuthoredOnElement.DeepCopy();
                if (Requester != null) dest.Requester = (RequesterComponent)Requester.DeepCopy();
                if (PerformerType != null) dest.PerformerType = (CodeableConcept)PerformerType.DeepCopy();
                if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (SupportingInfo != null) dest.SupportingInfo = new List<ResourceReference>(SupportingInfo.DeepCopy());
                if (Specimen != null) dest.Specimen = new List<ResourceReference>(Specimen.DeepCopy());
                if (BodySite != null) dest.BodySite = new List<CodeableConcept>(BodySite.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (RelevantHistory != null) dest.RelevantHistory = new List<ResourceReference>(RelevantHistory.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ProcedureRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ProcedureRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.Matches(Requisition, otherT.Requisition)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.Matches(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.Matches(AsNeeded, otherT.AsNeeded)) return false;
            if (!DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if (!DeepComparable.Matches(PerformerType, otherT.PerformerType)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if ( !DeepComparable.Matches(SupportingInfo, otherT.SupportingInfo)) return false;
            if ( !DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if ( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(RelevantHistory, otherT.RelevantHistory)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ProcedureRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.IsExactly(Requisition, otherT.Requisition)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.IsExactly(AsNeeded, otherT.AsNeeded)) return false;
            if (!DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(PerformerType, otherT.PerformerType)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(SupportingInfo, otherT.SupportingInfo)) return false;
            if (!DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
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
                if (Requisition != null) yield return Requisition;
                if (StatusElement != null) yield return StatusElement;
                if (IntentElement != null) yield return IntentElement;
                if (PriorityElement != null) yield return PriorityElement;
                if (DoNotPerformElement != null) yield return DoNotPerformElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (Code != null) yield return Code;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Occurrence != null) yield return Occurrence;
                if (AsNeeded != null) yield return AsNeeded;
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (Requester != null) yield return Requester;
                if (PerformerType != null) yield return PerformerType;
                if (Performer != null) yield return Performer;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return elem; }
                foreach (var elem in Specimen) { if (elem != null) yield return elem; }
                foreach (var elem in BodySite) { if (elem != null) yield return elem; }
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
                if (Requisition != null) yield return new ElementValue("requisition", Requisition);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (IntentElement != null) yield return new ElementValue("intent", IntentElement);
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                if (DoNotPerformElement != null) yield return new ElementValue("doNotPerform", DoNotPerformElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (Code != null) yield return new ElementValue("code", Code);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                if (AsNeeded != null) yield return new ElementValue("asNeeded", AsNeeded);
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", AuthoredOnElement);
                if (Requester != null) yield return new ElementValue("requester", Requester);
                if (PerformerType != null) yield return new ElementValue("performerType", PerformerType);
                if (Performer != null) yield return new ElementValue("performer", Performer);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return new ElementValue("supportingInfo", elem); }
                foreach (var elem in Specimen) { if (elem != null) yield return new ElementValue("specimen", elem); }
                foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in RelevantHistory) { if (elem != null) yield return new ElementValue("relevantHistory", elem); }
            }
        }

    }

}
