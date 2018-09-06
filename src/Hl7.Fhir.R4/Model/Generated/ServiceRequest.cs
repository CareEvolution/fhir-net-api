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
    /// A request for a service to be performed
    /// </summary>
    [FhirType("ServiceRequest", IsResource=true)]
    [DataContract]
    public partial class ServiceRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ServiceRequest; } }
        [NotMapped]
        public override string TypeName { get { return "ServiceRequest"; } }


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
        /// Instantiates FHIR protocol or definition
        /// </summary>
        [FhirElement("instantiatesCanonical", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> InstantiatesCanonicalElement
        {
            get { if (_instantiatesCanonicalElement==null) _instantiatesCanonicalElement = new List<Canonical>(); return _instantiatesCanonicalElement; }
            set { _instantiatesCanonicalElement = value; OnPropertyChanged("InstantiatesCanonicalElement"); }
        }

        private List<Canonical> _instantiatesCanonicalElement;

        /// <summary>
        /// Instantiates FHIR protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> InstantiatesCanonical
        {
            get { return InstantiatesCanonicalElement != null ? InstantiatesCanonicalElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesCanonicalElement = null;
                else
                    InstantiatesCanonicalElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("InstantiatesCanonical");
            }
        }

        /// <summary>
        /// Instantiates external protocol or definition
        /// </summary>
        [FhirElement("instantiatesUri", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> InstantiatesUriElement
        {
            get { if (_instantiatesUriElement==null) _instantiatesUriElement = new List<FhirUri>(); return _instantiatesUriElement; }
            set { _instantiatesUriElement = value; OnPropertyChanged("InstantiatesUriElement"); }
        }

        private List<FhirUri> _instantiatesUriElement;

        /// <summary>
        /// Instantiates external protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> InstantiatesUri
        {
            get { return InstantiatesUriElement != null ? InstantiatesUriElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesUriElement = null;
                else
                    InstantiatesUriElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("InstantiatesUri");
            }
        }

        /// <summary>
        /// What request fulfills
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=120)]
        [References("CarePlan","ServiceRequest","MedicationRequest")]
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
        [FhirElement("replaces", InSummary=true, Order=130)]
        [References("ServiceRequest")]
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
        [FhirElement("requisition", InSummary=true, Order=140)]
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
        [FhirElement("status", InSummary=true, Order=150)]
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
        [FhirElement("intent", InSummary=true, Order=160)]
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
        /// Classification of service
        /// </summary>
        [FhirElement("category", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=180)]
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
        /// True if service/procedure should not be performed
        /// </summary>
        [FhirElement("doNotPerform", InSummary=true, Order=190)]
        [DataMember]
        public FhirBoolean DoNotPerformElement
        {
            get { return _doNotPerformElement; }
            set { _doNotPerformElement = value; OnPropertyChanged("DoNotPerformElement"); }
        }

        private FhirBoolean _doNotPerformElement;

        /// <summary>
        /// True if service/procedure should not be performed
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
        /// What is being requested/ordered
        /// </summary>
        [FhirElement("code", InSummary=true, Order=200)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Additional order information
        /// </summary>
        [FhirElement("orderDetail", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> OrderDetail
        {
            get { if (_orderDetail==null) _orderDetail = new List<CodeableConcept>(); return _orderDetail; }
            set { _orderDetail = value; OnPropertyChanged("OrderDetail"); }
        }

        private List<CodeableConcept> _orderDetail;

        /// <summary>
        /// Service amount
        /// </summary>
        [FhirElement("quantity", InSummary=true, Order=220, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Quantity),typeof(Ratio),typeof(Range))]
        [DataMember]
        public Element Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged("Quantity"); }
        }

        private Element _quantity;

        /// <summary>
        /// Individual the service is ordered for
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=230)]
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
        [FhirElement("context", InSummary=true, Order=240)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When service should occur
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=250, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(Timing))]
        [DataMember]
        public Element Occurrence
        {
            get { return _occurrence; }
            set { _occurrence = value; OnPropertyChanged("Occurrence"); }
        }

        private Element _occurrence;

        /// <summary>
        /// Preconditions for service
        /// </summary>
        [FhirElement("asNeeded", InSummary=true, Order=260, Choice=ChoiceType.DatatypeChoice)]
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
        [FhirElement("authoredOn", InSummary=true, Order=270)]
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
        /// Who/what is requesting service
        /// </summary>
        [FhirElement("requester", InSummary=true, Order=280)]
        [References("Practitioner","PractitionerRole","Organization","Patient","RelatedPerson","Device")]
        [DataMember]
        public ResourceReference Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private ResourceReference _requester;

        /// <summary>
        /// Performer role
        /// </summary>
        [FhirElement("performerType", InSummary=true, Order=290)]
        [DataMember]
        public CodeableConcept PerformerType
        {
            get { return _performerType; }
            set { _performerType = value; OnPropertyChanged("PerformerType"); }
        }

        private CodeableConcept _performerType;

        /// <summary>
        /// Requested performer
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=300)]
        [References("Practitioner","PractitionerRole","Organization","CareTeam","HealthcareService","Patient","Device","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Performer
        {
            get { if (_performer==null) _performer = new List<ResourceReference>(); return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private List<ResourceReference> _performer;

        /// <summary>
        /// Requested location
        /// </summary>
        [FhirElement("locationCode", InSummary=true, Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> LocationCode
        {
            get { if (_locationCode==null) _locationCode = new List<CodeableConcept>(); return _locationCode; }
            set { _locationCode = value; OnPropertyChanged("LocationCode"); }
        }

        private List<CodeableConcept> _locationCode;

        /// <summary>
        /// Requested location
        /// </summary>
        [FhirElement("locationReference", InSummary=true, Order=320)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> LocationReference
        {
            get { if (_locationReference==null) _locationReference = new List<ResourceReference>(); return _locationReference; }
            set { _locationReference = value; OnPropertyChanged("LocationReference"); }
        }

        private List<ResourceReference> _locationReference;

        /// <summary>
        /// Explanation/Justification for procedure or service
        /// </summary>
        [FhirElement("reasonCode", InSummary=true, Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Explanation/Justification for service or service
        /// </summary>
        [FhirElement("reasonReference", InSummary=true, Order=340)]
        [References("Condition","Observation","DiagnosticReport","DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// Associated insurance coverage
        /// </summary>
        [FhirElement("insurance", Order=350)]
        [References("Coverage","ClaimResponse")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Insurance
        {
            get { if (_insurance==null) _insurance = new List<ResourceReference>(); return _insurance; }
            set { _insurance = value; OnPropertyChanged("Insurance"); }
        }

        private List<ResourceReference> _insurance;

        /// <summary>
        /// Additional clinical information
        /// </summary>
        [FhirElement("supportingInfo", Order=360)]
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
        [FhirElement("specimen", InSummary=true, Order=370)]
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
        [FhirElement("bodySite", InSummary=true, Order=380)]
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
        [FhirElement("note", Order=390)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Patient or consumer-oriented instructions
        /// </summary>
        [FhirElement("patientInstruction", InSummary=true, Order=400)]
        [DataMember]
        public FhirString PatientInstructionElement
        {
            get { return _patientInstructionElement; }
            set { _patientInstructionElement = value; OnPropertyChanged("PatientInstructionElement"); }
        }

        private FhirString _patientInstructionElement;

        /// <summary>
        /// Patient or consumer-oriented instructions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PatientInstruction
        {
            get { return PatientInstructionElement != null ? PatientInstructionElement.Value : null; }
            set
            {
                if (value == null)
                    PatientInstructionElement = null;
                else
                    PatientInstructionElement = new FhirString(value);
                OnPropertyChanged("PatientInstruction");
            }
        }

        /// <summary>
        /// Request provenance
        /// </summary>
        [FhirElement("relevantHistory", Order=410)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> RelevantHistory
        {
            get { if (_relevantHistory==null) _relevantHistory = new List<ResourceReference>(); return _relevantHistory; }
            set { _relevantHistory = value; OnPropertyChanged("RelevantHistory"); }
        }

        private List<ResourceReference> _relevantHistory;


        public static ElementDefinition.ConstraintComponent ServiceRequest_PRR_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "orderDetail.empty() or code.exists()",
            Key = "prr-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "orderDetail SHALL only be present if code is present",
            Xpath = "exists(f:code) or not(exists(f:orderDetail))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ServiceRequest_PRR_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ServiceRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (InstantiatesCanonicalElement != null) dest.InstantiatesCanonicalElement = new List<Canonical>(InstantiatesCanonicalElement.DeepCopy());
                if (InstantiatesUriElement != null) dest.InstantiatesUriElement = new List<FhirUri>(InstantiatesUriElement.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (Replaces != null) dest.Replaces = new List<ResourceReference>(Replaces.DeepCopy());
                if (Requisition != null) dest.Requisition = (Identifier)Requisition.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<RequestStatus>)StatusElement.DeepCopy();
                if (IntentElement != null) dest.IntentElement = (Code<RequestIntent>)IntentElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (PriorityElement != null) dest.PriorityElement = (Code<RequestPriority>)PriorityElement.DeepCopy();
                if (DoNotPerformElement != null) dest.DoNotPerformElement = (FhirBoolean)DoNotPerformElement.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (OrderDetail != null) dest.OrderDetail = new List<CodeableConcept>(OrderDetail.DeepCopy());
                if (Quantity != null) dest.Quantity = (Element)Quantity.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                if (AsNeeded != null) dest.AsNeeded = (Element)AsNeeded.DeepCopy();
                if (AuthoredOnElement != null) dest.AuthoredOnElement = (FhirDateTime)AuthoredOnElement.DeepCopy();
                if (Requester != null) dest.Requester = (ResourceReference)Requester.DeepCopy();
                if (PerformerType != null) dest.PerformerType = (CodeableConcept)PerformerType.DeepCopy();
                if (Performer != null) dest.Performer = new List<ResourceReference>(Performer.DeepCopy());
                if (LocationCode != null) dest.LocationCode = new List<CodeableConcept>(LocationCode.DeepCopy());
                if (LocationReference != null) dest.LocationReference = new List<ResourceReference>(LocationReference.DeepCopy());
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (Insurance != null) dest.Insurance = new List<ResourceReference>(Insurance.DeepCopy());
                if (SupportingInfo != null) dest.SupportingInfo = new List<ResourceReference>(SupportingInfo.DeepCopy());
                if (Specimen != null) dest.Specimen = new List<ResourceReference>(Specimen.DeepCopy());
                if (BodySite != null) dest.BodySite = new List<CodeableConcept>(BodySite.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (PatientInstructionElement != null) dest.PatientInstructionElement = (FhirString)PatientInstructionElement.DeepCopy();
                if (RelevantHistory != null) dest.RelevantHistory = new List<ResourceReference>(RelevantHistory.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ServiceRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ServiceRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(InstantiatesCanonicalElement, otherT.InstantiatesCanonicalElement)) return false;
            if ( !DeepComparable.Matches(InstantiatesUriElement, otherT.InstantiatesUriElement)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.Matches(Requisition, otherT.Requisition)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.Matches(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if ( !DeepComparable.Matches(OrderDetail, otherT.OrderDetail)) return false;
            if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.Matches(AsNeeded, otherT.AsNeeded)) return false;
            if (!DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if (!DeepComparable.Matches(PerformerType, otherT.PerformerType)) return false;
            if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if ( !DeepComparable.Matches(LocationCode, otherT.LocationCode)) return false;
            if ( !DeepComparable.Matches(LocationReference, otherT.LocationReference)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if ( !DeepComparable.Matches(Insurance, otherT.Insurance)) return false;
            if ( !DeepComparable.Matches(SupportingInfo, otherT.SupportingInfo)) return false;
            if ( !DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if ( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if (!DeepComparable.Matches(PatientInstructionElement, otherT.PatientInstructionElement)) return false;
            if ( !DeepComparable.Matches(RelevantHistory, otherT.RelevantHistory)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ServiceRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(InstantiatesCanonicalElement, otherT.InstantiatesCanonicalElement)) return false;
            if (!DeepComparable.IsExactly(InstantiatesUriElement, otherT.InstantiatesUriElement)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.IsExactly(Requisition, otherT.Requisition)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(OrderDetail, otherT.OrderDetail)) return false;
            if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.IsExactly(AsNeeded, otherT.AsNeeded)) return false;
            if (!DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(PerformerType, otherT.PerformerType)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(LocationCode, otherT.LocationCode)) return false;
            if (!DeepComparable.IsExactly(LocationReference, otherT.LocationReference)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;
            if (!DeepComparable.IsExactly(SupportingInfo, otherT.SupportingInfo)) return false;
            if (!DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(PatientInstructionElement, otherT.PatientInstructionElement)) return false;
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
                foreach (var elem in InstantiatesCanonicalElement) { if (elem != null) yield return elem; }
                foreach (var elem in InstantiatesUriElement) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in Replaces) { if (elem != null) yield return elem; }
                if (Requisition != null) yield return Requisition;
                if (StatusElement != null) yield return StatusElement;
                if (IntentElement != null) yield return IntentElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (PriorityElement != null) yield return PriorityElement;
                if (DoNotPerformElement != null) yield return DoNotPerformElement;
                if (Code != null) yield return Code;
                foreach (var elem in OrderDetail) { if (elem != null) yield return elem; }
                if (Quantity != null) yield return Quantity;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Occurrence != null) yield return Occurrence;
                if (AsNeeded != null) yield return AsNeeded;
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (Requester != null) yield return Requester;
                if (PerformerType != null) yield return PerformerType;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                foreach (var elem in LocationCode) { if (elem != null) yield return elem; }
                foreach (var elem in LocationReference) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in Insurance) { if (elem != null) yield return elem; }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return elem; }
                foreach (var elem in Specimen) { if (elem != null) yield return elem; }
                foreach (var elem in BodySite) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                if (PatientInstructionElement != null) yield return PatientInstructionElement;
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
                foreach (var elem in InstantiatesCanonicalElement) { if (elem != null) yield return new ElementValue("instantiatesCanonical", elem); }
                foreach (var elem in InstantiatesUriElement) { if (elem != null) yield return new ElementValue("instantiatesUri", elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                foreach (var elem in Replaces) { if (elem != null) yield return new ElementValue("replaces", elem); }
                if (Requisition != null) yield return new ElementValue("requisition", Requisition);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (IntentElement != null) yield return new ElementValue("intent", IntentElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                if (DoNotPerformElement != null) yield return new ElementValue("doNotPerform", DoNotPerformElement);
                if (Code != null) yield return new ElementValue("code", Code);
                foreach (var elem in OrderDetail) { if (elem != null) yield return new ElementValue("orderDetail", elem); }
                if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                if (AsNeeded != null) yield return new ElementValue("asNeeded", AsNeeded);
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", AuthoredOnElement);
                if (Requester != null) yield return new ElementValue("requester", Requester);
                if (PerformerType != null) yield return new ElementValue("performerType", PerformerType);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                foreach (var elem in LocationCode) { if (elem != null) yield return new ElementValue("locationCode", elem); }
                foreach (var elem in LocationReference) { if (elem != null) yield return new ElementValue("locationReference", elem); }
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                foreach (var elem in Insurance) { if (elem != null) yield return new ElementValue("insurance", elem); }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return new ElementValue("supportingInfo", elem); }
                foreach (var elem in Specimen) { if (elem != null) yield return new ElementValue("specimen", elem); }
                foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                if (PatientInstructionElement != null) yield return new ElementValue("patientInstruction", PatientInstructionElement);
                foreach (var elem in RelevantHistory) { if (elem != null) yield return new ElementValue("relevantHistory", elem); }
            }
        }

    }

}
