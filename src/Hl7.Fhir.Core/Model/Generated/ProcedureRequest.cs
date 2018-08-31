using System;
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
    /// <summary>
    /// A request for a procedure to be performed
    /// </summary>
    [FhirType("ProcedureRequest", IsResource=true)]
    [DataContract]
    public partial class ProcedureRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ProcedureRequest; } }
        [NotMapped]
        public override string TypeName { get { return "ProcedureRequest"; } }

        /// <summary>
        /// The status of the request.
        /// (url: http://hl7.org/fhir/ValueSet/procedure-request-status)
        /// </summary>
        [FhirEnumeration("ProcedureRequestStatus")]
        public enum ProcedureRequestStatus
        {
            /// <summary>
            /// The request has been proposed.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("proposed", "http://hl7.org/fhir/procedure-request-status"), Description("Proposed")]
            Proposed,
            /// <summary>
            /// The request is in preliminary form, prior to being requested.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("draft", "http://hl7.org/fhir/procedure-request-status"), Description("Draft")]
            Draft,
            /// <summary>
            /// The request has been placed.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("requested", "http://hl7.org/fhir/procedure-request-status"), Description("Requested")]
            Requested,
            /// <summary>
            /// The receiving system has received the request but not yet decided whether it will be performed.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("received", "http://hl7.org/fhir/procedure-request-status"), Description("Received")]
            Received,
            /// <summary>
            /// The receiving system has accepted the request, but work has not yet commenced.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("accepted", "http://hl7.org/fhir/procedure-request-status"), Description("Accepted")]
            Accepted,
            /// <summary>
            /// The work to fulfill the request is happening.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/procedure-request-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// The work has been completed, the report(s) released, and no further work is planned.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/procedure-request-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The request has been held by originating system/user request.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("suspended", "http://hl7.org/fhir/procedure-request-status"), Description("Suspended")]
            Suspended,
            /// <summary>
            /// The receiving system has declined to fulfill the request.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/procedure-request-status"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// The request was attempted, but due to some procedural error, it could not be completed.
            /// (system: http://hl7.org/fhir/procedure-request-status)
            /// </summary>
            [EnumLiteral("aborted", "http://hl7.org/fhir/procedure-request-status"), Description("Aborted")]
            Aborted,
        }

        /// <summary>
        /// The priority of the request.
        /// (url: http://hl7.org/fhir/ValueSet/procedure-request-priority)
        /// </summary>
        [FhirEnumeration("ProcedureRequestPriority")]
        public enum ProcedureRequestPriority
        {
            /// <summary>
            /// The request has a normal priority.
            /// (system: http://hl7.org/fhir/procedure-request-priority)
            /// </summary>
            [EnumLiteral("routine", "http://hl7.org/fhir/procedure-request-priority"), Description("Routine")]
            Routine,
            /// <summary>
            /// The request should be done urgently.
            /// (system: http://hl7.org/fhir/procedure-request-priority)
            /// </summary>
            [EnumLiteral("urgent", "http://hl7.org/fhir/procedure-request-priority"), Description("Urgent")]
            Urgent,
            /// <summary>
            /// The request is time-critical.
            /// (system: http://hl7.org/fhir/procedure-request-priority)
            /// </summary>
            [EnumLiteral("stat", "http://hl7.org/fhir/procedure-request-priority"), Description("Stat")]
            Stat,
            /// <summary>
            /// The request should be acted on as soon as possible.
            /// (system: http://hl7.org/fhir/procedure-request-priority)
            /// </summary>
            [EnumLiteral("asap", "http://hl7.org/fhir/procedure-request-priority"), Description("ASAP")]
            Asap,
        }


        /// <summary>
        /// Unique identifier for the request
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
        /// Who the procedure should be done to
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=100)]
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
        /// What procedure to perform
        /// </summary>
        [FhirElement("code", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// What part of body to perform on
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> BodySite
        {
            get { if (_bodySite==null) _bodySite = new List<CodeableConcept>(); return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private List<CodeableConcept> _bodySite;

        /// <summary>
        /// Why procedure should occur
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=130, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private Element _reason;

        /// <summary>
        /// When procedure should occur
        /// </summary>
        [FhirElement("scheduled", InSummary=true, Order=140, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(Timing))]
        [DataMember]
        public Element Scheduled
        {
            get { return _scheduled; }
            set { _scheduled = value; OnPropertyChanged("Scheduled"); }
        }

        private Element _scheduled;

        /// <summary>
        /// Encounter request created during
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=150)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Who should perform the procedure
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=160)]
        [References("Practitioner","Organization","Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Performer
        {
            get { return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private ResourceReference _performer;

        /// <summary>
        /// proposed | draft | requested | received | accepted | in-progress | completed | suspended | rejected | aborted
        /// </summary>
        [FhirElement("status", InSummary=true, Order=170)]
        [DataMember]
        public Code<ProcedureRequestStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ProcedureRequestStatus> _statusElement;

        /// <summary>
        /// proposed | draft | requested | received | accepted | in-progress | completed | suspended | rejected | aborted
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ProcedureRequestStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ProcedureRequestStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Additional information about desired procedure
        /// </summary>
        [FhirElement("notes", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Notes
        {
            get { if (_notes==null) _notes = new List<Annotation>(); return _notes; }
            set { _notes = value; OnPropertyChanged("Notes"); }
        }

        private List<Annotation> _notes;

        /// <summary>
        /// Preconditions for procedure
        /// </summary>
        [FhirElement("asNeeded", InSummary=true, Order=190, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirBoolean),typeof(CodeableConcept))]
        [DataMember]
        public Element AsNeeded
        {
            get { return _asNeeded; }
            set { _asNeeded = value; OnPropertyChanged("AsNeeded"); }
        }

        private Element _asNeeded;

        /// <summary>
        /// When request was created
        /// </summary>
        [FhirElement("orderedOn", InSummary=true, Order=200)]
        [DataMember]
        public FhirDateTime OrderedOnElement
        {
            get { return _orderedOnElement; }
            set { _orderedOnElement = value; OnPropertyChanged("OrderedOnElement"); }
        }

        private FhirDateTime _orderedOnElement;

        /// <summary>
        /// When request was created
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string OrderedOn
        {
            get { return OrderedOnElement != null ? OrderedOnElement.Value : null; }
            set
            {
                if (value == null)
                    OrderedOnElement = null;
                else
                    OrderedOnElement = new FhirDateTime(value);
                OnPropertyChanged("OrderedOn");
            }
        }

        /// <summary>
        /// Who made request
        /// </summary>
        [FhirElement("orderer", InSummary=true, Order=210)]
        [References("Practitioner","Patient","RelatedPerson","Device")]
        [DataMember]
        public ResourceReference Orderer
        {
            get { return _orderer; }
            set { _orderer = value; OnPropertyChanged("Orderer"); }
        }

        private ResourceReference _orderer;

        /// <summary>
        /// routine | urgent | stat | asap
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=220)]
        [DataMember]
        public Code<ProcedureRequestPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<ProcedureRequestPriority> _priorityElement;

        /// <summary>
        /// routine | urgent | stat | asap
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ProcedureRequestPriority? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (value == null)
                    PriorityElement = null;
                else
                    PriorityElement = new Code<ProcedureRequestPriority>(value);
                OnPropertyChanged("Priority");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ProcedureRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (BodySite != null) dest.BodySite = new List<CodeableConcept>(BodySite.DeepCopy());
                if (Reason != null) dest.Reason = (Element)Reason.DeepCopy();
                if (Scheduled != null) dest.Scheduled = (Element)Scheduled.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ProcedureRequestStatus>)StatusElement.DeepCopy();
                if (Notes != null) dest.Notes = new List<Annotation>(Notes.DeepCopy());
                if (AsNeeded != null) dest.AsNeeded = (Element)AsNeeded.DeepCopy();
                if (OrderedOnElement != null) dest.OrderedOnElement = (FhirDateTime)OrderedOnElement.DeepCopy();
                if (Orderer != null) dest.Orderer = (ResourceReference)Orderer.DeepCopy();
                if (PriorityElement != null) dest.PriorityElement = (Code<ProcedureRequestPriority>)PriorityElement.DeepCopy();
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
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if ( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(Scheduled, otherT.Scheduled)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(Notes, otherT.Notes)) return false;
            if (!DeepComparable.Matches(AsNeeded, otherT.AsNeeded)) return false;
            if (!DeepComparable.Matches(OrderedOnElement, otherT.OrderedOnElement)) return false;
            if (!DeepComparable.Matches(Orderer, otherT.Orderer)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ProcedureRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Scheduled, otherT.Scheduled)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Notes, otherT.Notes)) return false;
            if (!DeepComparable.IsExactly(AsNeeded, otherT.AsNeeded)) return false;
            if (!DeepComparable.IsExactly(OrderedOnElement, otherT.OrderedOnElement)) return false;
            if (!DeepComparable.IsExactly(Orderer, otherT.Orderer)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Subject != null) yield return Subject;
                if (Code != null) yield return Code;
                foreach (var elem in BodySite) { if (elem != null) yield return elem; }
                if (Reason != null) yield return Reason;
                if (Scheduled != null) yield return Scheduled;
                if (Encounter != null) yield return Encounter;
                if (Performer != null) yield return Performer;
                if (StatusElement != null) yield return StatusElement;
                foreach (var elem in Notes) { if (elem != null) yield return elem; }
                if (AsNeeded != null) yield return AsNeeded;
                if (OrderedOnElement != null) yield return OrderedOnElement;
                if (Orderer != null) yield return Orderer;
                if (PriorityElement != null) yield return PriorityElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Code != null) yield return new ElementValue("code", Code);
                foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", elem); }
                if (Reason != null) yield return new ElementValue("reason", Reason);
                if (Scheduled != null) yield return new ElementValue("scheduled", Scheduled);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Performer != null) yield return new ElementValue("performer", Performer);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                foreach (var elem in Notes) { if (elem != null) yield return new ElementValue("notes", elem); }
                if (AsNeeded != null) yield return new ElementValue("asNeeded", AsNeeded);
                if (OrderedOnElement != null) yield return new ElementValue("orderedOn", OrderedOnElement);
                if (Orderer != null) yield return new ElementValue("orderer", Orderer);
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
            }
        }

    }

}
