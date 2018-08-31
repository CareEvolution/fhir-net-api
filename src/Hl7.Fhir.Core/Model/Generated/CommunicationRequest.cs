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
    /// A request for information to be sent to a receiver
    /// </summary>
    [FhirType("CommunicationRequest", IsResource=true)]
    [DataContract]
    public partial class CommunicationRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.CommunicationRequest; } }
        [NotMapped]
        public override string TypeName { get { return "CommunicationRequest"; } }

        /// <summary>
        /// The status of the communication.
        /// (url: http://hl7.org/fhir/ValueSet/communication-request-status)
        /// </summary>
        [FhirEnumeration("CommunicationRequestStatus")]
        public enum CommunicationRequestStatus
        {
            /// <summary>
            /// The request has been proposed.
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("proposed", "http://hl7.org/fhir/communication-request-status"), Description("Proposed")]
            Proposed,
            /// <summary>
            /// The request has been planned.
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("planned", "http://hl7.org/fhir/communication-request-status"), Description("Planned")]
            Planned,
            /// <summary>
            /// The request has been placed.
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("requested", "http://hl7.org/fhir/communication-request-status"), Description("Requested")]
            Requested,
            /// <summary>
            /// The receiving system has received the request but not yet decided whether it will be performed.
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("received", "http://hl7.org/fhir/communication-request-status"), Description("Received")]
            Received,
            /// <summary>
            /// The receiving system has accepted the order, but work has not yet commenced.
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("accepted", "http://hl7.org/fhir/communication-request-status"), Description("Accepted")]
            Accepted,
            /// <summary>
            /// The work to fulfill the order is happening.
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/communication-request-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// The work has been complete, the report(s) released, and no further work is planned.
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/communication-request-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The request has been held by originating system/user request.
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("suspended", "http://hl7.org/fhir/communication-request-status"), Description("Suspended")]
            Suspended,
            /// <summary>
            /// The receiving system has declined to fulfill the request
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/communication-request-status"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// The communication was attempted, but due to some procedural error, it could not be completed.
            /// (system: http://hl7.org/fhir/communication-request-status)
            /// </summary>
            [EnumLiteral("failed", "http://hl7.org/fhir/communication-request-status"), Description("Failed")]
            Failed,
        }


        [FhirType("PayloadComponent")]
        [DataContract]
        public partial class PayloadComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PayloadComponent"; } }

            /// <summary>
            /// Message part content
            /// </summary>
            [FhirElement("content", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirString),typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PayloadComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PayloadComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PayloadComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PayloadComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        /// <summary>
        /// Unique identifier
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
        /// Message category
        /// </summary>
        [FhirElement("category", InSummary=true, Order=100)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// Message sender
        /// </summary>
        [FhirElement("sender", InSummary=true, Order=110)]
        [References("Device","Organization","Patient","Practitioner","RelatedPerson")]
        [DataMember]
        public ResourceReference Sender
        {
            get { return _sender; }
            set { _sender = value; OnPropertyChanged("Sender"); }
        }

        private ResourceReference _sender;

        /// <summary>
        /// Message recipient
        /// </summary>
        [FhirElement("recipient", InSummary=true, Order=120)]
        [References("Device","Organization","Patient","Practitioner","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Recipient
        {
            get { if (_recipient==null) _recipient = new List<ResourceReference>(); return _recipient; }
            set { _recipient = value; OnPropertyChanged("Recipient"); }
        }

        private List<ResourceReference> _recipient;

        /// <summary>
        /// Message payload
        /// </summary>
        [FhirElement("payload", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PayloadComponent> Payload
        {
            get { if (_payload==null) _payload = new List<PayloadComponent>(); return _payload; }
            set { _payload = value; OnPropertyChanged("Payload"); }
        }

        private List<PayloadComponent> _payload;

        /// <summary>
        /// A channel of communication
        /// </summary>
        [FhirElement("medium", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Medium
        {
            get { if (_medium==null) _medium = new List<CodeableConcept>(); return _medium; }
            set { _medium = value; OnPropertyChanged("Medium"); }
        }

        private List<CodeableConcept> _medium;

        /// <summary>
        /// An individual who requested a communication
        /// </summary>
        [FhirElement("requester", InSummary=true, Order=150)]
        [References("Practitioner","Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private ResourceReference _requester;

        /// <summary>
        /// proposed | planned | requested | received | accepted | in-progress | completed | suspended | rejected | failed
        /// </summary>
        [FhirElement("status", InSummary=true, Order=160)]
        [DataMember]
        public Code<CommunicationRequestStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<CommunicationRequestStatus> _statusElement;

        /// <summary>
        /// proposed | planned | requested | received | accepted | in-progress | completed | suspended | rejected | failed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CommunicationRequestStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<CommunicationRequestStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Encounter leading to message
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=170)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// When scheduled
        /// </summary>
        [FhirElement("scheduled", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [DataMember]
        public Element Scheduled
        {
            get { return _scheduled; }
            set { _scheduled = value; OnPropertyChanged("Scheduled"); }
        }

        private Element _scheduled;

        /// <summary>
        /// Indication for message
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Reason
        {
            get { if (_reason==null) _reason = new List<CodeableConcept>(); return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private List<CodeableConcept> _reason;

        /// <summary>
        /// When ordered or proposed
        /// </summary>
        [FhirElement("requestedOn", InSummary=true, Order=200)]
        [DataMember]
        public FhirDateTime RequestedOnElement
        {
            get { return _requestedOnElement; }
            set { _requestedOnElement = value; OnPropertyChanged("RequestedOnElement"); }
        }

        private FhirDateTime _requestedOnElement;

        /// <summary>
        /// When ordered or proposed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string RequestedOn
        {
            get { return RequestedOnElement != null ? RequestedOnElement.Value : null; }
            set
            {
                if (value == null)
                    RequestedOnElement = null;
                else
                    RequestedOnElement = new FhirDateTime(value);
                OnPropertyChanged("RequestedOn");
            }
        }

        /// <summary>
        /// Focus of message
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=210)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Message urgency
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=220)]
        [DataMember]
        public CodeableConcept Priority
        {
            get { return _priority; }
            set { _priority = value; OnPropertyChanged("Priority"); }
        }

        private CodeableConcept _priority;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as CommunicationRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Sender != null) dest.Sender = (ResourceReference)Sender.DeepCopy();
                if (Recipient != null) dest.Recipient = new List<ResourceReference>(Recipient.DeepCopy());
                if (Payload != null) dest.Payload = new List<PayloadComponent>(Payload.DeepCopy());
                if (Medium != null) dest.Medium = new List<CodeableConcept>(Medium.DeepCopy());
                if (Requester != null) dest.Requester = (ResourceReference)Requester.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<CommunicationRequestStatus>)StatusElement.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Scheduled != null) dest.Scheduled = (Element)Scheduled.DeepCopy();
                if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                if (RequestedOnElement != null) dest.RequestedOnElement = (FhirDateTime)RequestedOnElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Priority != null) dest.Priority = (CodeableConcept)Priority.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new CommunicationRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as CommunicationRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Sender, otherT.Sender)) return false;
            if ( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            if ( !DeepComparable.Matches(Payload, otherT.Payload)) return false;
            if ( !DeepComparable.Matches(Medium, otherT.Medium)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Scheduled, otherT.Scheduled)) return false;
            if ( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(RequestedOnElement, otherT.RequestedOnElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as CommunicationRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Sender, otherT.Sender)) return false;
            if (!DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.IsExactly(Payload, otherT.Payload)) return false;
            if (!DeepComparable.IsExactly(Medium, otherT.Medium)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Scheduled, otherT.Scheduled)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(RequestedOnElement, otherT.RequestedOnElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Category != null) yield return Category;
                if (Sender != null) yield return Sender;
                foreach (var elem in Recipient) { if (elem != null) yield return elem; }
                foreach (var elem in Payload) { if (elem != null) yield return elem; }
                foreach (var elem in Medium) { if (elem != null) yield return elem; }
                if (Requester != null) yield return Requester;
                if (StatusElement != null) yield return StatusElement;
                if (Encounter != null) yield return Encounter;
                if (Scheduled != null) yield return Scheduled;
                foreach (var elem in Reason) { if (elem != null) yield return elem; }
                if (RequestedOnElement != null) yield return RequestedOnElement;
                if (Subject != null) yield return Subject;
                if (Priority != null) yield return Priority;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Category != null) yield return new ElementValue("category", Category);
                if (Sender != null) yield return new ElementValue("sender", Sender);
                foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", elem); }
                foreach (var elem in Payload) { if (elem != null) yield return new ElementValue("payload", elem); }
                foreach (var elem in Medium) { if (elem != null) yield return new ElementValue("medium", elem); }
                if (Requester != null) yield return new ElementValue("requester", Requester);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Scheduled != null) yield return new ElementValue("scheduled", Scheduled);
                foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                if (RequestedOnElement != null) yield return new ElementValue("requestedOn", RequestedOnElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Priority != null) yield return new ElementValue("priority", Priority);
            }
        }

    }

}
