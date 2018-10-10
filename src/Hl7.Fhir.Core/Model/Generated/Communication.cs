using System;
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
    /// A record of information transmitted from a sender to a receiver
    /// </summary>
    [FhirType("Communication", IsResource=true)]
    [DataContract]
    public partial class Communication : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Communication; } }
        [NotMapped]
        public override string TypeName { get { return "Communication"; } }

        /// <summary>
        /// The status of the communication.
        /// (url: http://hl7.org/fhir/ValueSet/communication-status)
        /// </summary>
        [FhirEnumeration("CommunicationStatus")]
        public enum CommunicationStatus
        {
            /// <summary>
            /// The communication transmission is ongoing.
            /// (system: http://hl7.org/fhir/communication-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/communication-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// The message transmission is complete, i.e., delivered to the recipient's destination.
            /// (system: http://hl7.org/fhir/communication-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/communication-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The communication transmission has been held by originating system/user request.
            /// (system: http://hl7.org/fhir/communication-status)
            /// </summary>
            [EnumLiteral("suspended", "http://hl7.org/fhir/communication-status"), Description("Suspended")]
            Suspended,
            /// <summary>
            /// The receiving system has declined to accept the message.
            /// (system: http://hl7.org/fhir/communication-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/communication-status"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// There was a failure in transmitting the message out.
            /// (system: http://hl7.org/fhir/communication-status)
            /// </summary>
            [EnumLiteral("failed", "http://hl7.org/fhir/communication-status"), Description("Failed")]
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
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
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
        [References("Device","Organization","Patient","Practitioner","RelatedPerson","Group")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Recipient
        {
            get { if (_recipient == null) _recipient = new List<ResourceReference>(); return _recipient; }
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
            get { if (_payload == null) _payload = new List<PayloadComponent>(); return _payload; }
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
            get { if (_medium == null) _medium = new List<CodeableConcept>(); return _medium; }
            set { _medium = value; OnPropertyChanged("Medium"); }
        }

        private List<CodeableConcept> _medium;

        /// <summary>
        /// in-progress | completed | suspended | rejected | failed
        /// </summary>
        [FhirElement("status", InSummary=true, Order=150)]
        [DataMember]
        public Code<CommunicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<CommunicationStatus> _statusElement;

        /// <summary>
        /// in-progress | completed | suspended | rejected | failed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CommunicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<CommunicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Encounter leading to message
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=160)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// When sent
        /// </summary>
        [FhirElement("sent", InSummary=true, Order=170)]
        [DataMember]
        public FhirDateTime SentElement
        {
            get { return _sentElement; }
            set { _sentElement = value; OnPropertyChanged("SentElement"); }
        }

        private FhirDateTime _sentElement;

        /// <summary>
        /// When sent
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Sent
        {
            get { return SentElement != null ? SentElement.Value : null; }
            set
            {
                if (value == null)
                    SentElement = null;
                else
                    SentElement = new FhirDateTime(value);
                OnPropertyChanged("Sent");
            }
        }

        /// <summary>
        /// When received
        /// </summary>
        [FhirElement("received", InSummary=true, Order=180)]
        [DataMember]
        public FhirDateTime ReceivedElement
        {
            get { return _receivedElement; }
            set { _receivedElement = value; OnPropertyChanged("ReceivedElement"); }
        }

        private FhirDateTime _receivedElement;

        /// <summary>
        /// When received
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Received
        {
            get { return ReceivedElement != null ? ReceivedElement.Value : null; }
            set
            {
                if (value == null)
                    ReceivedElement = null;
                else
                    ReceivedElement = new FhirDateTime(value);
                OnPropertyChanged("Received");
            }
        }

        /// <summary>
        /// Indication for message
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Reason
        {
            get { if (_reason == null) _reason = new List<CodeableConcept>(); return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private List<CodeableConcept> _reason;

        /// <summary>
        /// Focus of message
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=200)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// CommunicationRequest producing this message
        /// </summary>
        [FhirElement("requestDetail", InSummary=true, Order=210)]
        [References("CommunicationRequest")]
        [DataMember]
        public ResourceReference RequestDetail
        {
            get { return _requestDetail; }
            set { _requestDetail = value; OnPropertyChanged("RequestDetail"); }
        }

        private ResourceReference _requestDetail;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Communication;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Sender != null) dest.Sender = (ResourceReference)Sender.DeepCopy();
                if (Recipient != null) dest.Recipient = new List<ResourceReference>(Recipient.DeepCopy());
                if (Payload != null) dest.Payload = new List<PayloadComponent>(Payload.DeepCopy());
                if (Medium != null) dest.Medium = new List<CodeableConcept>(Medium.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<CommunicationStatus>)StatusElement.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (SentElement != null) dest.SentElement = (FhirDateTime)SentElement.DeepCopy();
                if (ReceivedElement != null) dest.ReceivedElement = (FhirDateTime)ReceivedElement.DeepCopy();
                if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (RequestDetail != null) dest.RequestDetail = (ResourceReference)RequestDetail.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Communication());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Communication;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Sender, otherT.Sender)) return false;
            if (!DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.Matches(Payload, otherT.Payload)) return false;
            if (!DeepComparable.Matches(Medium, otherT.Medium)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(SentElement, otherT.SentElement)) return false;
            if (!DeepComparable.Matches(ReceivedElement, otherT.ReceivedElement)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(RequestDetail, otherT.RequestDetail)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Communication;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Sender, otherT.Sender)) return false;
            if (!DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.IsExactly(Payload, otherT.Payload)) return false;
            if (!DeepComparable.IsExactly(Medium, otherT.Medium)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(SentElement, otherT.SentElement)) return false;
            if (!DeepComparable.IsExactly(ReceivedElement, otherT.ReceivedElement)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(RequestDetail, otherT.RequestDetail)) return false;

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
                if (StatusElement != null) yield return StatusElement;
                if (Encounter != null) yield return Encounter;
                if (SentElement != null) yield return SentElement;
                if (ReceivedElement != null) yield return ReceivedElement;
                foreach (var elem in Reason) { if (elem != null) yield return elem; }
                if (Subject != null) yield return Subject;
                if (RequestDetail != null) yield return RequestDetail;
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
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (SentElement != null) yield return new ElementValue("sent", SentElement);
                if (ReceivedElement != null) yield return new ElementValue("received", ReceivedElement);
                foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (RequestDetail != null) yield return new ElementValue("requestDetail", RequestDetail);
            }
        }

    }

}
