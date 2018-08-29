using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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


        [FhirType("PayloadComponent")]
        [DataContract]
        public partial class PayloadComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PayloadComponent"; } }

            /// <summary>
            /// Message part content
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
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
                    if (Content != null) yield return new ElementValue("content", false, Content);
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
        /// Fulfills plan or proposal
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=100)]
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
        [FhirElement("replaces", InSummary=true, Order=110)]
        [References("CommunicationRequest")]
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
        [FhirElement("groupIdentifier", InSummary=true, Order=120)]
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
        [FhirElement("status", InSummary=true, Order=130)]
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
        /// Message category
        /// </summary>
        [FhirElement("category", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// Message urgency
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=150)]
        [DataMember]
        public Code<RequestPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<RequestPriority> _priorityElement;

        /// <summary>
        /// Message urgency
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
        /// A channel of communication
        /// </summary>
        [FhirElement("medium", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Medium
        {
            get { if (_medium==null) _medium = new List<CodeableConcept>(); return _medium; }
            set { _medium = value; OnPropertyChanged("Medium"); }
        }

        private List<CodeableConcept> _medium;

        /// <summary>
        /// Focus of message
        /// </summary>
        [FhirElement("subject", Order=170)]
        [References("Patient","Group")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Message recipient
        /// </summary>
        [FhirElement("recipient", Order=180)]
        [References("Device","Organization","Patient","Practitioner","RelatedPerson","Group","CareTeam")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Recipient
        {
            get { if (_recipient==null) _recipient = new List<ResourceReference>(); return _recipient; }
            set { _recipient = value; OnPropertyChanged("Recipient"); }
        }

        private List<ResourceReference> _recipient;

        /// <summary>
        /// Resources that pertain to this communication request
        /// </summary>
        [FhirElement("about", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> About
        {
            get { if (_about==null) _about = new List<ResourceReference>(); return _about; }
            set { _about = value; OnPropertyChanged("About"); }
        }

        private List<ResourceReference> _about;

        /// <summary>
        /// Encounter or episode leading to message
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
        /// Message payload
        /// </summary>
        [FhirElement("payload", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PayloadComponent> Payload
        {
            get { if (_payload==null) _payload = new List<PayloadComponent>(); return _payload; }
            set { _payload = value; OnPropertyChanged("Payload"); }
        }

        private List<PayloadComponent> _payload;

        /// <summary>
        /// When scheduled
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=220, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [DataMember]
        public Element Occurrence
        {
            get { return _occurrence; }
            set { _occurrence = value; OnPropertyChanged("Occurrence"); }
        }

        private Element _occurrence;

        /// <summary>
        /// When request transitioned to being actionable
        /// </summary>
        [FhirElement("authoredOn", InSummary=true, Order=230)]
        [DataMember]
        public FhirDateTime AuthoredOnElement
        {
            get { return _authoredOnElement; }
            set { _authoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }

        private FhirDateTime _authoredOnElement;

        /// <summary>
        /// When request transitioned to being actionable
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
        [FhirElement("requester", InSummary=true, Order=240)]
        [References("Practitioner","PractitionerRole","Organization","Patient","RelatedPerson","Device")]
        [DataMember]
        public ResourceReference Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private ResourceReference _requester;

        /// <summary>
        /// Message sender
        /// </summary>
        [FhirElement("sender", InSummary=true, Order=250)]
        [References("Device","Organization","Patient","Practitioner","PractitionerRole","RelatedPerson","HealthcareService")]
        [DataMember]
        public ResourceReference Sender
        {
            get { return _sender; }
            set { _sender = value; OnPropertyChanged("Sender"); }
        }

        private ResourceReference _sender;

        /// <summary>
        /// Why is communication needed?
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
        /// Why is communication needed?
        /// </summary>
        [FhirElement("reasonReference", InSummary=true, Order=270)]
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
        /// Comments made about communication request
        /// </summary>
        [FhirElement("note", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as CommunicationRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (Replaces != null) dest.Replaces = new List<ResourceReference>(Replaces.DeepCopy());
                if (GroupIdentifier != null) dest.GroupIdentifier = (Identifier)GroupIdentifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<RequestStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (PriorityElement != null) dest.PriorityElement = (Code<RequestPriority>)PriorityElement.DeepCopy();
                if (Medium != null) dest.Medium = new List<CodeableConcept>(Medium.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Recipient != null) dest.Recipient = new List<ResourceReference>(Recipient.DeepCopy());
                if (About != null) dest.About = new List<ResourceReference>(About.DeepCopy());
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Payload != null) dest.Payload = new List<PayloadComponent>(Payload.DeepCopy());
                if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                if (AuthoredOnElement != null) dest.AuthoredOnElement = (FhirDateTime)AuthoredOnElement.DeepCopy();
                if (Requester != null) dest.Requester = (ResourceReference)Requester.DeepCopy();
                if (Sender != null) dest.Sender = (ResourceReference)Sender.DeepCopy();
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
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
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.Matches(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if ( !DeepComparable.Matches(Medium, otherT.Medium)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            if ( !DeepComparable.Matches(About, otherT.About)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if ( !DeepComparable.Matches(Payload, otherT.Payload)) return false;
            if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if (!DeepComparable.Matches(Sender, otherT.Sender)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as CommunicationRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.IsExactly(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(Medium, otherT.Medium)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.IsExactly(About, otherT.About)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Payload, otherT.Payload)) return false;
            if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(Sender, otherT.Sender)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in Replaces) { if (elem != null) yield return elem; }
                if (GroupIdentifier != null) yield return GroupIdentifier;
                if (StatusElement != null) yield return StatusElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (PriorityElement != null) yield return PriorityElement;
                foreach (var elem in Medium) { if (elem != null) yield return elem; }
                if (Subject != null) yield return Subject;
                foreach (var elem in Recipient) { if (elem != null) yield return elem; }
                foreach (var elem in About) { if (elem != null) yield return elem; }
                if (Context != null) yield return Context;
                foreach (var elem in Payload) { if (elem != null) yield return elem; }
                if (Occurrence != null) yield return Occurrence;
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (Requester != null) yield return Requester;
                if (Sender != null) yield return Sender;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", true, elem); }
                foreach (var elem in Replaces) { if (elem != null) yield return new ElementValue("replaces", true, elem); }
                if (GroupIdentifier != null) yield return new ElementValue("groupIdentifier", false, GroupIdentifier);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", true, elem); }
                if (PriorityElement != null) yield return new ElementValue("priority", false, PriorityElement);
                foreach (var elem in Medium) { if (elem != null) yield return new ElementValue("medium", true, elem); }
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", true, elem); }
                foreach (var elem in About) { if (elem != null) yield return new ElementValue("about", true, elem); }
                if (Context != null) yield return new ElementValue("context", false, Context);
                foreach (var elem in Payload) { if (elem != null) yield return new ElementValue("payload", true, elem); }
                if (Occurrence != null) yield return new ElementValue("occurrence", false, Occurrence);
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", false, AuthoredOnElement);
                if (Requester != null) yield return new ElementValue("requester", false, Requester);
                if (Sender != null) yield return new ElementValue("sender", false, Sender);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", true, elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", true, elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", true, elem); }
            }
        }

    }

}
