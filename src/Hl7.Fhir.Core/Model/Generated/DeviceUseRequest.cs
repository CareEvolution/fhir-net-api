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
    /// A request for a patient to use or be given a medical device
    /// </summary>
    [FhirType("DeviceUseRequest", IsResource=true)]
    [DataContract]
    public partial class DeviceUseRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DeviceUseRequest; } }
        [NotMapped]
        public override string TypeName { get { return "DeviceUseRequest"; } }

        /// <summary>
        /// Codes representing the status of the request.
        /// (url: http://hl7.org/fhir/ValueSet/device-use-request-status)
        /// </summary>
        [FhirEnumeration("DeviceUseRequestStatus")]
        public enum DeviceUseRequestStatus
        {
            /// <summary>
            /// The request has been proposed.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("proposed", "http://hl7.org/fhir/device-use-request-status"), Description("Proposed")]
            Proposed,
            /// <summary>
            /// The request has been planned.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("planned", "http://hl7.org/fhir/device-use-request-status"), Description("Planned")]
            Planned,
            /// <summary>
            /// The request has been placed.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("requested", "http://hl7.org/fhir/device-use-request-status"), Description("Requested")]
            Requested,
            /// <summary>
            /// The receiving system has received the request but not yet decided whether it will be performed.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("received", "http://hl7.org/fhir/device-use-request-status"), Description("Received")]
            Received,
            /// <summary>
            /// The receiving system has accepted the request but work has not yet commenced.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("accepted", "http://hl7.org/fhir/device-use-request-status"), Description("Accepted")]
            Accepted,
            /// <summary>
            /// The work to fulfill the order is happening.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/device-use-request-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// The work has been complete, the report(s) released, and no further work is planned.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/device-use-request-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The request has been held by originating system/user request.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("suspended", "http://hl7.org/fhir/device-use-request-status"), Description("Suspended")]
            Suspended,
            /// <summary>
            /// The receiving system has declined to fulfill the request.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/device-use-request-status"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// The request was attempted, but due to some procedural error, it could not be completed.
            /// (system: http://hl7.org/fhir/device-use-request-status)
            /// </summary>
            [EnumLiteral("aborted", "http://hl7.org/fhir/device-use-request-status"), Description("Aborted")]
            Aborted,
        }

        /// <summary>
        /// Codes representing the priority of the request.
        /// (url: http://hl7.org/fhir/ValueSet/device-use-request-priority)
        /// </summary>
        [FhirEnumeration("DeviceUseRequestPriority")]
        public enum DeviceUseRequestPriority
        {
            /// <summary>
            /// The request has a normal priority.
            /// (system: http://hl7.org/fhir/device-use-request-priority)
            /// </summary>
            [EnumLiteral("routine", "http://hl7.org/fhir/device-use-request-priority"), Description("Routine")]
            Routine,
            /// <summary>
            /// The request should be done urgently.
            /// (system: http://hl7.org/fhir/device-use-request-priority)
            /// </summary>
            [EnumLiteral("urgent", "http://hl7.org/fhir/device-use-request-priority"), Description("Urgent")]
            Urgent,
            /// <summary>
            /// The request is time-critical.
            /// (system: http://hl7.org/fhir/device-use-request-priority)
            /// </summary>
            [EnumLiteral("stat", "http://hl7.org/fhir/device-use-request-priority"), Description("Stat")]
            Stat,
            /// <summary>
            /// The request should be acted on as soon as possible.
            /// (system: http://hl7.org/fhir/device-use-request-priority)
            /// </summary>
            [EnumLiteral("asap", "http://hl7.org/fhir/device-use-request-priority"), Description("ASAP")]
            Asap,
        }


        /// <summary>
        /// Target body site
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=90, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element BodySite
        {
            get { return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private Element _bodySite;

        /// <summary>
        /// proposed | planned | requested | received | accepted | in-progress | completed | suspended | rejected | aborted
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<DeviceUseRequestStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<DeviceUseRequestStatus> _statusElement;

        /// <summary>
        /// proposed | planned | requested | received | accepted | in-progress | completed | suspended | rejected | aborted
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DeviceUseRequestStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<DeviceUseRequestStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Device requested
        /// </summary>
        [FhirElement("device", InSummary=true, Order=110)]
        [References("Device")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Device
        {
            get { return _device; }
            set { _device = value; OnPropertyChanged("Device"); }
        }

        private ResourceReference _device;

        /// <summary>
        /// Encounter motivating request
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=120)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Request identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Reason for request
        /// </summary>
        [FhirElement("indication", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Indication
        {
            get { if (_indication == null) _indication = new List<CodeableConcept>(); return _indication; }
            set { _indication = value; OnPropertyChanged("Indication"); }
        }

        private List<CodeableConcept> _indication;

        /// <summary>
        /// Notes or comments
        /// </summary>
        [FhirElement("notes", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> NotesElement
        {
            get { if (_notesElement == null) _notesElement = new List<FhirString>(); return _notesElement; }
            set { _notesElement = value; OnPropertyChanged("NotesElement"); }
        }

        private List<FhirString> _notesElement;

        /// <summary>
        /// Notes or comments
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Notes
        {
            get { return NotesElement != null ? NotesElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    NotesElement = null;
                else
                    NotesElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Notes");
            }
        }

        /// <summary>
        /// PRN
        /// </summary>
        [FhirElement("prnReason", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> PrnReason
        {
            get { if (_prnReason == null) _prnReason = new List<CodeableConcept>(); return _prnReason; }
            set { _prnReason = value; OnPropertyChanged("PrnReason"); }
        }

        private List<CodeableConcept> _prnReason;

        /// <summary>
        /// When ordered
        /// </summary>
        [FhirElement("orderedOn", InSummary=true, Order=170)]
        [DataMember]
        public FhirDateTime OrderedOnElement
        {
            get { return _orderedOnElement; }
            set { _orderedOnElement = value; OnPropertyChanged("OrderedOnElement"); }
        }

        private FhirDateTime _orderedOnElement;

        /// <summary>
        /// When ordered
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
        /// When recorded
        /// </summary>
        [FhirElement("recordedOn", InSummary=true, Order=180)]
        [DataMember]
        public FhirDateTime RecordedOnElement
        {
            get { return _recordedOnElement; }
            set { _recordedOnElement = value; OnPropertyChanged("RecordedOnElement"); }
        }

        private FhirDateTime _recordedOnElement;

        /// <summary>
        /// When recorded
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string RecordedOn
        {
            get { return RecordedOnElement != null ? RecordedOnElement.Value : null; }
            set
            {
                if (value == null)
                    RecordedOnElement = null;
                else
                    RecordedOnElement = new FhirDateTime(value);
                OnPropertyChanged("RecordedOn");
            }
        }

        /// <summary>
        /// Focus of request
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=190)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Schedule for use
        /// </summary>
        [FhirElement("timing", InSummary=true, Order=200, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Timing),typeof(Period),typeof(FhirDateTime))]
        [DataMember]
        public Element Timing
        {
            get { return _timing; }
            set { _timing = value; OnPropertyChanged("Timing"); }
        }

        private Element _timing;

        /// <summary>
        /// routine | urgent | stat | asap
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=210)]
        [DataMember]
        public Code<DeviceUseRequestPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<DeviceUseRequestPriority> _priorityElement;

        /// <summary>
        /// routine | urgent | stat | asap
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DeviceUseRequestPriority? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    PriorityElement = null;
                else
                    PriorityElement = new Code<DeviceUseRequestPriority>(value);
                OnPropertyChanged("Priority");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DeviceUseRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (BodySite != null) dest.BodySite = (Element)BodySite.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<DeviceUseRequestStatus>)StatusElement.DeepCopy();
                if (Device != null) dest.Device = (ResourceReference)Device.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Indication != null) dest.Indication = new List<CodeableConcept>(Indication.DeepCopy());
                if (NotesElement != null) dest.NotesElement = new List<FhirString>(NotesElement.DeepCopy());
                if (PrnReason != null) dest.PrnReason = new List<CodeableConcept>(PrnReason.DeepCopy());
                if (OrderedOnElement != null) dest.OrderedOnElement = (FhirDateTime)OrderedOnElement.DeepCopy();
                if (RecordedOnElement != null) dest.RecordedOnElement = (FhirDateTime)RecordedOnElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
                if (PriorityElement != null) dest.PriorityElement = (Code<DeviceUseRequestPriority>)PriorityElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new DeviceUseRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DeviceUseRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Device, otherT.Device)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Indication, otherT.Indication)) return false;
            if (!DeepComparable.Matches(NotesElement, otherT.NotesElement)) return false;
            if (!DeepComparable.Matches(PrnReason, otherT.PrnReason)) return false;
            if (!DeepComparable.Matches(OrderedOnElement, otherT.OrderedOnElement)) return false;
            if (!DeepComparable.Matches(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DeviceUseRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
            if (!DeepComparable.IsExactly(NotesElement, otherT.NotesElement)) return false;
            if (!DeepComparable.IsExactly(PrnReason, otherT.PrnReason)) return false;
            if (!DeepComparable.IsExactly(OrderedOnElement, otherT.OrderedOnElement)) return false;
            if (!DeepComparable.IsExactly(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (BodySite != null) yield return BodySite;
                if (StatusElement != null) yield return StatusElement;
                if (Device != null) yield return Device;
                if (Encounter != null) yield return Encounter;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in Indication) { if (elem != null) yield return elem; }
                foreach (var elem in NotesElement) { if (elem != null) yield return elem; }
                foreach (var elem in PrnReason) { if (elem != null) yield return elem; }
                if (OrderedOnElement != null) yield return OrderedOnElement;
                if (RecordedOnElement != null) yield return RecordedOnElement;
                if (Subject != null) yield return Subject;
                if (Timing != null) yield return Timing;
                if (PriorityElement != null) yield return PriorityElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Device != null) yield return new ElementValue("device", Device);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in Indication) { if (elem != null) yield return new ElementValue("indication", elem); }
                foreach (var elem in NotesElement) { if (elem != null) yield return new ElementValue("notes", elem); }
                foreach (var elem in PrnReason) { if (elem != null) yield return new ElementValue("prnReason", elem); }
                if (OrderedOnElement != null) yield return new ElementValue("orderedOn", OrderedOnElement);
                if (RecordedOnElement != null) yield return new ElementValue("recordedOn", RecordedOnElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Timing != null) yield return new ElementValue("timing", Timing);
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
            }
        }

    }

}
