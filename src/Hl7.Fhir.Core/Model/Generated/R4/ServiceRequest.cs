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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A request for a service to be performed
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "ServiceRequest", IsResource=true)]
    [DataContract]
    public partial class ServiceRequest : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ServiceRequest; } }
        [NotMapped]
        public override string TypeName { get { return "ServiceRequest"; } }
    
        
        /// <summary>
        /// Identifiers assigned to this order
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Identifier> _Identifier;
        
        /// <summary>
        /// Protocol or definition
        /// </summary>
        [FhirElement("instantiates", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirUri> InstantiatesElement
        {
            get { if(_InstantiatesElement==null) _InstantiatesElement = new List<Hl7.Fhir.Model.FhirUri>(); return _InstantiatesElement; }
            set { _InstantiatesElement = value; OnPropertyChanged("InstantiatesElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirUri> _InstantiatesElement;
        
        /// <summary>
        /// Protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Instantiates
        {
            get { return InstantiatesElement != null ? InstantiatesElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesElement = null;
                else
                    InstantiatesElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
                OnPropertyChanged("Instantiates");
            }
        }
        
        /// <summary>
        /// What request fulfills
        /// </summary>
        [FhirElement("basedOn", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [References("CarePlan","ServiceRequest","MedicationRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> BasedOn
        {
            get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _BasedOn; }
            set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _BasedOn;
        
        /// <summary>
        /// What request replaces
        /// </summary>
        [FhirElement("replaces", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [References("ServiceRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Replaces
        {
            get { if(_Replaces==null) _Replaces = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Replaces; }
            set { _Replaces = value; OnPropertyChanged("Replaces"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Replaces;
        
        /// <summary>
        /// Composite Request ID
        /// </summary>
        [FhirElement("requisition", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Identifier Requisition
        {
            get { return _Requisition; }
            set { _Requisition = value; OnPropertyChanged("Requisition"); }
        }
        
        private Hl7.Fhir.Model.R4.Identifier _Requisition;
        
        /// <summary>
        /// draft | active | suspended | completed | entered-in-error | cancelled
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _StatusElement;
        
        /// <summary>
        /// draft | active | suspended | completed | entered-in-error | cancelled
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// proposal | plan | order +
        /// </summary>
        [FhirElement("intent", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code IntentElement
        {
            get { return _IntentElement; }
            set { _IntentElement = value; OnPropertyChanged("IntentElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _IntentElement;
        
        /// <summary>
        /// proposal | plan | order +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Intent
        {
            get { return IntentElement != null ? IntentElement.Value : null; }
            set
            {
                if (value == null)
                    IntentElement = null;
                else
                    IntentElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Intent");
            }
        }
        
        /// <summary>
        /// Classification of service
        /// </summary>
        [FhirElement("category", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> Category
        {
            get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Category; }
            set { _Category = value; OnPropertyChanged("Category"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _Category;
        
        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        [FhirElement("priority", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code PriorityElement
        {
            get { return _PriorityElement; }
            set { _PriorityElement = value; OnPropertyChanged("PriorityElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _PriorityElement;
        
        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (value == null)
                    PriorityElement = null;
                else
                    PriorityElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Priority");
            }
        }
        
        /// <summary>
        /// True if service/procedure should not be performed
        /// </summary>
        [FhirElement("doNotPerform", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean DoNotPerformElement
        {
            get { return _DoNotPerformElement; }
            set { _DoNotPerformElement = value; OnPropertyChanged("DoNotPerformElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _DoNotPerformElement;
        
        /// <summary>
        /// True if service/procedure should not be performed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? DoNotPerform
        {
            get { return DoNotPerformElement != null ? DoNotPerformElement.Value : null; }
            set
            {
                if (value == null)
                    DoNotPerformElement = null;
                else
                    DoNotPerformElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("DoNotPerform");
            }
        }
        
        /// <summary>
        /// What is being requested/ordered
        /// </summary>
        [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Code;
        
        /// <summary>
        /// Additional order information
        /// </summary>
        [FhirElement("orderDetail", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> OrderDetail
        {
            get { if(_OrderDetail==null) _OrderDetail = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _OrderDetail; }
            set { _OrderDetail = value; OnPropertyChanged("OrderDetail"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _OrderDetail;
        
        /// <summary>
        /// Individual the service is ordered for
        /// </summary>
        [FhirElement("subject", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [References("Patient","Group","Location","Device")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Subject;
        
        /// <summary>
        /// Encounter or Episode during which request was created
        /// </summary>
        [FhirElement("context", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Context
        {
            get { return _Context; }
            set { _Context = value; OnPropertyChanged("Context"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Context;
        
        /// <summary>
        /// When service should occur
        /// </summary>
        [FhirElement("occurrence", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.R4.FhirDateTime),typeof(Hl7.Fhir.Model.R4.Period),typeof(Hl7.Fhir.Model.R4.Timing))]
        [DataMember]
        public Hl7.Fhir.Model.Element Occurrence
        {
            get { return _Occurrence; }
            set { _Occurrence = value; OnPropertyChanged("Occurrence"); }
        }
        
        private Hl7.Fhir.Model.Element _Occurrence;
        
        /// <summary>
        /// Preconditions for service
        /// </summary>
        [FhirElement("asNeeded", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=240, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.R4.CodeableConcept))]
        [DataMember]
        public Hl7.Fhir.Model.Element AsNeeded
        {
            get { return _AsNeeded; }
            set { _AsNeeded = value; OnPropertyChanged("AsNeeded"); }
        }
        
        private Hl7.Fhir.Model.Element _AsNeeded;
        
        /// <summary>
        /// Date request signed
        /// </summary>
        [FhirElement("authoredOn", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=250)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime AuthoredOnElement
        {
            get { return _AuthoredOnElement; }
            set { _AuthoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _AuthoredOnElement;
        
        /// <summary>
        /// Date request signed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string AuthoredOn
        {
            get { return AuthoredOnElement != null ? AuthoredOnElement.Value : null; }
            set
            {
                if (value == null)
                    AuthoredOnElement = null;
                else
                    AuthoredOnElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("AuthoredOn");
            }
        }
        
        /// <summary>
        /// Who/what is requesting service
        /// </summary>
        [FhirElement("requester", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=260)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Organization","Patient","RelatedPerson","Device")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Requester
        {
            get { return _Requester; }
            set { _Requester = value; OnPropertyChanged("Requester"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Requester;
        
        /// <summary>
        /// Performer role
        /// </summary>
        [FhirElement("performerType", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=270)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept PerformerType
        {
            get { return _PerformerType; }
            set { _PerformerType = value; OnPropertyChanged("PerformerType"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _PerformerType;
        
        /// <summary>
        /// Requested performer
        /// </summary>
        [FhirElement("performer", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=280)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Organization","CareTeam","HealthcareService","Patient","Device","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Performer
        {
            get { if(_Performer==null) _Performer = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Performer; }
            set { _Performer = value; OnPropertyChanged("Performer"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Performer;
        
        /// <summary>
        /// Explanation/Justification for procedure or service
        /// </summary>
        [FhirElement("reasonCode", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=290)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> ReasonCode
        {
            get { if(_ReasonCode==null) _ReasonCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _ReasonCode; }
            set { _ReasonCode = value; OnPropertyChanged("ReasonCode"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _ReasonCode;
        
        /// <summary>
        /// Explanation/Justification for service or service
        /// </summary>
        [FhirElement("reasonReference", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=300)]
        [CLSCompliant(false)]
        [References("Condition","Observation","DiagnosticReport","DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> ReasonReference
        {
            get { if(_ReasonReference==null) _ReasonReference = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _ReasonReference; }
            set { _ReasonReference = value; OnPropertyChanged("ReasonReference"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _ReasonReference;
        
        /// <summary>
        /// Associated insurance coverage
        /// </summary>
        [FhirElement("insurance", Order=310)]
        [CLSCompliant(false)]
        [References("Coverage","ClaimResponse")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Insurance
        {
            get { if(_Insurance==null) _Insurance = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Insurance; }
            set { _Insurance = value; OnPropertyChanged("Insurance"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Insurance;
        
        /// <summary>
        /// Additional clinical information
        /// </summary>
        [FhirElement("supportingInfo", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> SupportingInfo
        {
            get { if(_SupportingInfo==null) _SupportingInfo = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _SupportingInfo; }
            set { _SupportingInfo = value; OnPropertyChanged("SupportingInfo"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _SupportingInfo;
        
        /// <summary>
        /// Procedure Samples
        /// </summary>
        [FhirElement("specimen", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=330)]
        [CLSCompliant(false)]
        [References("Specimen")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Specimen
        {
            get { if(_Specimen==null) _Specimen = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Specimen; }
            set { _Specimen = value; OnPropertyChanged("Specimen"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Specimen;
        
        /// <summary>
        /// Location on Body
        /// </summary>
        [FhirElement("bodySite", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=340)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> BodySite
        {
            get { if(_BodySite==null) _BodySite = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _BodySite; }
            set { _BodySite = value; OnPropertyChanged("BodySite"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _BodySite;
        
        /// <summary>
        /// Comments
        /// </summary>
        [FhirElement("note", Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.R4.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Annotation> _Note;
        
        /// <summary>
        /// Patient or consumer-oriented instructions
        /// </summary>
        [FhirElement("patientInstruction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=360)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PatientInstructionElement
        {
            get { return _PatientInstructionElement; }
            set { _PatientInstructionElement = value; OnPropertyChanged("PatientInstructionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PatientInstructionElement;
        
        /// <summary>
        /// Patient or consumer-oriented instructions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string PatientInstruction
        {
            get { return PatientInstructionElement != null ? PatientInstructionElement.Value : null; }
            set
            {
                if (value == null)
                    PatientInstructionElement = null;
                else
                    PatientInstructionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("PatientInstruction");
            }
        }
        
        /// <summary>
        /// Request provenance
        /// </summary>
        [FhirElement("relevantHistory", Order=370)]
        [CLSCompliant(false)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> RelevantHistory
        {
            get { if(_RelevantHistory==null) _RelevantHistory = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _RelevantHistory; }
            set { _RelevantHistory = value; OnPropertyChanged("RelevantHistory"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _RelevantHistory;
    
    
        public static ElementDefinitionConstraint ServiceRequest_PRR_1 = new ElementDefinitionConstraint
        {
            Expression = "orderDetail.empty() or code.exists()",
            Key = "prr-1",
            Severity = ConstraintSeverity.Warning,
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
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(InstantiatesElement != null) dest.InstantiatesElement = new List<Hl7.Fhir.Model.FhirUri>(InstantiatesElement.DeepCopy());
                if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.R4.ResourceReference>(BasedOn.DeepCopy());
                if(Replaces != null) dest.Replaces = new List<Hl7.Fhir.Model.R4.ResourceReference>(Replaces.DeepCopy());
                if(Requisition != null) dest.Requisition = (Hl7.Fhir.Model.R4.Identifier)Requisition.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(IntentElement != null) dest.IntentElement = (Hl7.Fhir.Model.R4.Code)IntentElement.DeepCopy();
                if(Category != null) dest.Category = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Category.DeepCopy());
                if(PriorityElement != null) dest.PriorityElement = (Hl7.Fhir.Model.R4.Code)PriorityElement.DeepCopy();
                if(DoNotPerformElement != null) dest.DoNotPerformElement = (Hl7.Fhir.Model.FhirBoolean)DoNotPerformElement.DeepCopy();
                if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                if(OrderDetail != null) dest.OrderDetail = new List<Hl7.Fhir.Model.R4.CodeableConcept>(OrderDetail.DeepCopy());
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.R4.ResourceReference)Subject.DeepCopy();
                if(Context != null) dest.Context = (Hl7.Fhir.Model.R4.ResourceReference)Context.DeepCopy();
                if(Occurrence != null) dest.Occurrence = (Hl7.Fhir.Model.Element)Occurrence.DeepCopy();
                if(AsNeeded != null) dest.AsNeeded = (Hl7.Fhir.Model.Element)AsNeeded.DeepCopy();
                if(AuthoredOnElement != null) dest.AuthoredOnElement = (Hl7.Fhir.Model.R4.FhirDateTime)AuthoredOnElement.DeepCopy();
                if(Requester != null) dest.Requester = (Hl7.Fhir.Model.R4.ResourceReference)Requester.DeepCopy();
                if(PerformerType != null) dest.PerformerType = (Hl7.Fhir.Model.R4.CodeableConcept)PerformerType.DeepCopy();
                if(Performer != null) dest.Performer = new List<Hl7.Fhir.Model.R4.ResourceReference>(Performer.DeepCopy());
                if(ReasonCode != null) dest.ReasonCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(ReasonCode.DeepCopy());
                if(ReasonReference != null) dest.ReasonReference = new List<Hl7.Fhir.Model.R4.ResourceReference>(ReasonReference.DeepCopy());
                if(Insurance != null) dest.Insurance = new List<Hl7.Fhir.Model.R4.ResourceReference>(Insurance.DeepCopy());
                if(SupportingInfo != null) dest.SupportingInfo = new List<Hl7.Fhir.Model.R4.ResourceReference>(SupportingInfo.DeepCopy());
                if(Specimen != null) dest.Specimen = new List<Hl7.Fhir.Model.R4.ResourceReference>(Specimen.DeepCopy());
                if(BodySite != null) dest.BodySite = new List<Hl7.Fhir.Model.R4.CodeableConcept>(BodySite.DeepCopy());
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.R4.Annotation>(Note.DeepCopy());
                if(PatientInstructionElement != null) dest.PatientInstructionElement = (Hl7.Fhir.Model.FhirString)PatientInstructionElement.DeepCopy();
                if(RelevantHistory != null) dest.RelevantHistory = new List<Hl7.Fhir.Model.R4.ResourceReference>(RelevantHistory.DeepCopy());
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(InstantiatesElement, otherT.InstantiatesElement)) return false;
            if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
            if( !DeepComparable.Matches(Requisition, otherT.Requisition)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if( !DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if( !DeepComparable.Matches(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(OrderDetail, otherT.OrderDetail)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Context, otherT.Context)) return false;
            if( !DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if( !DeepComparable.Matches(AsNeeded, otherT.AsNeeded)) return false;
            if( !DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if( !DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if( !DeepComparable.Matches(PerformerType, otherT.PerformerType)) return false;
            if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.Matches(Insurance, otherT.Insurance)) return false;
            if( !DeepComparable.Matches(SupportingInfo, otherT.SupportingInfo)) return false;
            if( !DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(PatientInstructionElement, otherT.PatientInstructionElement)) return false;
            if( !DeepComparable.Matches(RelevantHistory, otherT.RelevantHistory)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ServiceRequest;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(InstantiatesElement, otherT.InstantiatesElement)) return false;
            if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if( !DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
            if( !DeepComparable.IsExactly(Requisition, otherT.Requisition)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if( !DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if( !DeepComparable.IsExactly(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(OrderDetail, otherT.OrderDetail)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if( !DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if( !DeepComparable.IsExactly(AsNeeded, otherT.AsNeeded)) return false;
            if( !DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if( !DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if( !DeepComparable.IsExactly(PerformerType, otherT.PerformerType)) return false;
            if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if( !DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;
            if( !DeepComparable.IsExactly(SupportingInfo, otherT.SupportingInfo)) return false;
            if( !DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if( !DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(PatientInstructionElement, otherT.PatientInstructionElement)) return false;
            if( !DeepComparable.IsExactly(RelevantHistory, otherT.RelevantHistory)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in InstantiatesElement) { if (elem != null) yield return elem; }
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
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Occurrence != null) yield return Occurrence;
                if (AsNeeded != null) yield return AsNeeded;
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (Requester != null) yield return Requester;
                if (PerformerType != null) yield return PerformerType;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
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
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                foreach (var elem in InstantiatesElement) { if (elem != null) yield return new ElementValue("instantiates", true, elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", true, elem); }
                foreach (var elem in Replaces) { if (elem != null) yield return new ElementValue("replaces", true, elem); }
                if (Requisition != null) yield return new ElementValue("requisition", false, Requisition);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (IntentElement != null) yield return new ElementValue("intent", false, IntentElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", true, elem); }
                if (PriorityElement != null) yield return new ElementValue("priority", false, PriorityElement);
                if (DoNotPerformElement != null) yield return new ElementValue("doNotPerform", false, DoNotPerformElement);
                if (Code != null) yield return new ElementValue("code", false, Code);
                foreach (var elem in OrderDetail) { if (elem != null) yield return new ElementValue("orderDetail", true, elem); }
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (Context != null) yield return new ElementValue("context", false, Context);
                if (Occurrence != null) yield return new ElementValue("occurrence", false, Occurrence);
                if (AsNeeded != null) yield return new ElementValue("asNeeded", false, AsNeeded);
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", false, AuthoredOnElement);
                if (Requester != null) yield return new ElementValue("requester", false, Requester);
                if (PerformerType != null) yield return new ElementValue("performerType", false, PerformerType);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", true, elem); }
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", true, elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", true, elem); }
                foreach (var elem in Insurance) { if (elem != null) yield return new ElementValue("insurance", true, elem); }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return new ElementValue("supportingInfo", true, elem); }
                foreach (var elem in Specimen) { if (elem != null) yield return new ElementValue("specimen", true, elem); }
                foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", true, elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", true, elem); }
                if (PatientInstructionElement != null) yield return new ElementValue("patientInstruction", false, PatientInstructionElement);
                foreach (var elem in RelevantHistory) { if (elem != null) yield return new ElementValue("relevantHistory", true, elem); }
            }
        }
    
    }

}
