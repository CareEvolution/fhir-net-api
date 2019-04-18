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
    /// A request for a diagnostic service
    /// </summary>
    [FhirType("DiagnosticOrder", IsResource = true)]
    [DataContract]
    public partial class DiagnosticOrder : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DiagnosticOrder; } }
        [NotMapped]
        public override string TypeName { get { return "DiagnosticOrder"; } }

        /// <summary>
        /// The status of a diagnostic order.
        /// (url: http://hl7.org/fhir/ValueSet/diagnostic-order-status)
        /// </summary>
        [FhirEnumeration("DiagnosticOrderStatus")]
        public enum DiagnosticOrderStatus
        {
            /// <summary>
            /// The request has been proposed.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("proposed", "http://hl7.org/fhir/diagnostic-order-status"), Description("Proposed")]
            Proposed,
            /// <summary>
            /// The request is in preliminary form prior to being sent.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("draft", "http://hl7.org/fhir/diagnostic-order-status"), Description("Draft")]
            Draft,
            /// <summary>
            /// The request has been planned.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("planned", "http://hl7.org/fhir/diagnostic-order-status"), Description("Planned")]
            Planned,
            /// <summary>
            /// The request has been placed.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("requested", "http://hl7.org/fhir/diagnostic-order-status"), Description("Requested")]
            Requested,
            /// <summary>
            /// The receiving system has received the order, but not yet decided whether it will be performed.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("received", "http://hl7.org/fhir/diagnostic-order-status"), Description("Received")]
            Received,
            /// <summary>
            /// The receiving system has accepted the order, but work has not yet commenced.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("accepted", "http://hl7.org/fhir/diagnostic-order-status"), Description("Accepted")]
            Accepted,
            /// <summary>
            /// The work to fulfill the order is happening.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/diagnostic-order-status"), Description("In-Progress")]
            InProgress,
            /// <summary>
            /// The work is complete, and the outcomes are being reviewed for approval.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("review", "http://hl7.org/fhir/diagnostic-order-status"), Description("Review")]
            Review,
            /// <summary>
            /// The work has been completed, the report(s) released, and no further work is planned.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/diagnostic-order-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The request has been withdrawn.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/diagnostic-order-status"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// The request has been held by originating system/user request.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("suspended", "http://hl7.org/fhir/diagnostic-order-status"), Description("Suspended")]
            Suspended,
            /// <summary>
            /// The receiving system has declined to fulfill the request.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/diagnostic-order-status"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// The diagnostic investigation was attempted, but due to some procedural error, it could not be completed.
            /// (system: http://hl7.org/fhir/diagnostic-order-status)
            /// </summary>
            [EnumLiteral("failed", "http://hl7.org/fhir/diagnostic-order-status"), Description("Failed")]
            Failed,
        }

        /// <summary>
        /// The clinical priority of a diagnostic order.
        /// (url: http://hl7.org/fhir/ValueSet/diagnostic-order-priority)
        /// </summary>
        [FhirEnumeration("DiagnosticOrderPriority")]
        public enum DiagnosticOrderPriority
        {
            /// <summary>
            /// The order has a normal priority .
            /// (system: http://hl7.org/fhir/diagnostic-order-priority)
            /// </summary>
            [EnumLiteral("routine", "http://hl7.org/fhir/diagnostic-order-priority"), Description("Routine")]
            Routine,
            /// <summary>
            /// The order should be urgently.
            /// (system: http://hl7.org/fhir/diagnostic-order-priority)
            /// </summary>
            [EnumLiteral("urgent", "http://hl7.org/fhir/diagnostic-order-priority"), Description("Urgent")]
            Urgent,
            /// <summary>
            /// The order is time-critical.
            /// (system: http://hl7.org/fhir/diagnostic-order-priority)
            /// </summary>
            [EnumLiteral("stat", "http://hl7.org/fhir/diagnostic-order-priority"), Description("Stat")]
            Stat,
            /// <summary>
            /// The order should be acted on as soon as possible.
            /// (system: http://hl7.org/fhir/diagnostic-order-priority)
            /// </summary>
            [EnumLiteral("asap", "http://hl7.org/fhir/diagnostic-order-priority"), Description("ASAP")]
            Asap,
        }


        [FhirType("EventComponent")]
        [DataContract]
        public partial class EventComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EventComponent"; } }

            /// <summary>
            /// proposed | draft | planned | requested | received | accepted | in-progress | review | completed | cancelled | suspended | rejected | failed
            /// </summary>
            [FhirElement("status", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Code<DiagnosticOrderStatus> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<DiagnosticOrderStatus> _statusElement;

            /// <summary>
            /// proposed | draft | planned | requested | received | accepted | in-progress | review | completed | cancelled | suspended | rejected | failed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DiagnosticOrderStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        StatusElement = null;
                    else
                        StatusElement = new Code<DiagnosticOrderStatus>(value);
                    OnPropertyChanged("Status");
                }
            }

            /// <summary>
            /// More information about the event and its context
            /// </summary>
            [FhirElement("description", InSummary = true, Order = 50)]
            [DataMember]
            public CodeableConcept Description
            {
                get { return _description; }
                set { _description = value; OnPropertyChanged("Description"); }
            }

            private CodeableConcept _description;

            /// <summary>
            /// The date at which the event happened
            /// </summary>
            [FhirElement("dateTime", InSummary = true, Order = 60)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public FhirDateTime DateTimeElement
            {
                get { return _dateTimeElement; }
                set { _dateTimeElement = value; OnPropertyChanged("DateTimeElement"); }
            }

            private FhirDateTime _dateTimeElement;

            /// <summary>
            /// The date at which the event happened
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string DateTime
            {
                get { return DateTimeElement != null ? DateTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        DateTimeElement = null;
                    else
                        DateTimeElement = new FhirDateTime(value);
                    OnPropertyChanged("DateTime");
                }
            }

            /// <summary>
            /// Who recorded or did this
            /// </summary>
            [FhirElement("actor", Order = 70)]
            [References("Practitioner", "Device")]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EventComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StatusElement != null) dest.StatusElement = (Code<DiagnosticOrderStatus>)StatusElement.DeepCopy();
                    if (Description != null) dest.Description = (CodeableConcept)Description.DeepCopy();
                    if (DateTimeElement != null) dest.DateTimeElement = (FhirDateTime)DateTimeElement.DeepCopy();
                    if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new EventComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EventComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.Matches(Description, otherT.Description)) return false;
                if (!DeepComparable.Matches(DateTimeElement, otherT.DateTimeElement)) return false;
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EventComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
                if (!DeepComparable.IsExactly(DateTimeElement, otherT.DateTimeElement)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StatusElement != null) yield return StatusElement;
                    if (Description != null) yield return Description;
                    if (DateTimeElement != null) yield return DateTimeElement;
                    if (Actor != null) yield return Actor;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                    if (Description != null) yield return new ElementValue("description", Description);
                    if (DateTimeElement != null) yield return new ElementValue("dateTime", DateTimeElement);
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                }
            }


        }


        [FhirType("ItemComponent")]
        [DataContract]
        public partial class ItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemComponent"; } }

            /// <summary>
            /// Code to indicate the item (test or panel) being ordered
            /// </summary>
            [FhirElement("code", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// If this item relates to specific specimens
            /// </summary>
            [FhirElement("specimen", Order = 50)]
            [References("Specimen")]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<ResourceReference> Specimen
            {
                get { if (_specimen == null) _specimen = new List<ResourceReference>(); return _specimen; }
                set { _specimen = value; OnPropertyChanged("Specimen"); }
            }

            private List<ResourceReference> _specimen;

            /// <summary>
            /// Location of requested test (if applicable)
            /// </summary>
            [FhirElement("bodySite", Order = 60)]
            [DataMember]
            public CodeableConcept BodySite
            {
                get { return _bodySite; }
                set { _bodySite = value; OnPropertyChanged("BodySite"); }
            }

            private CodeableConcept _bodySite;

            /// <summary>
            /// proposed | draft | planned | requested | received | accepted | in-progress | review | completed | cancelled | suspended | rejected | failed
            /// </summary>
            [FhirElement("status", InSummary = true, Order = 70)]
            [DataMember]
            public Code<DiagnosticOrderStatus> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<DiagnosticOrderStatus> _statusElement;

            /// <summary>
            /// proposed | draft | planned | requested | received | accepted | in-progress | review | completed | cancelled | suspended | rejected | failed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DiagnosticOrderStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        StatusElement = null;
                    else
                        StatusElement = new Code<DiagnosticOrderStatus>(value);
                    OnPropertyChanged("Status");
                }
            }

            /// <summary>
            /// Events specific to this item
            /// </summary>
            [FhirElement("event", InSummary = true, Order = 80)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<EventComponent> Event
            {
                get { if (_event == null) _event = new List<EventComponent>(); return _event; }
                set { _event = value; OnPropertyChanged("Event"); }
            }

            private List<EventComponent> _event;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Specimen != null) dest.Specimen = new List<ResourceReference>(Specimen.DeepCopy());
                    if (BodySite != null) dest.BodySite = (CodeableConcept)BodySite.DeepCopy();
                    if (StatusElement != null) dest.StatusElement = (Code<DiagnosticOrderStatus>)StatusElement.DeepCopy();
                    if (Event != null) dest.Event = new List<EventComponent>(Event.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
                if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.Matches(Event, otherT.Event)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
                if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.IsExactly(Event, otherT.Event)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in Specimen) { if (elem != null) yield return elem; }
                    if (BodySite != null) yield return BodySite;
                    if (StatusElement != null) yield return StatusElement;
                    foreach (var elem in Event) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    foreach (var elem in Specimen) { if (elem != null) yield return new ElementValue("specimen", elem); }
                    if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                    if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                    foreach (var elem in Event) { if (elem != null) yield return new ElementValue("event", elem); }
                }
            }


        }


        /// <summary>
        /// Who and/or what test is about
        /// </summary>
        [FhirElement("subject", InSummary = true, Order = 90)]
        [References("Patient", "Group", "Location", "Device")]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Who ordered the test
        /// </summary>
        [FhirElement("orderer", InSummary = true, Order = 100)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Orderer
        {
            get { return _orderer; }
            set { _orderer = value; OnPropertyChanged("Orderer"); }
        }

        private ResourceReference _orderer;

        /// <summary>
        /// Identifiers assigned to this order
        /// </summary>
        [FhirElement("identifier", InSummary = true, Order = 110)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// The encounter that this diagnostic order is associated with
        /// </summary>
        [FhirElement("encounter", InSummary = true, Order = 120)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Explanation/Justification for test
        /// </summary>
        [FhirElement("reason", Order = 130)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> Reason
        {
            get { if (_reason == null) _reason = new List<CodeableConcept>(); return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private List<CodeableConcept> _reason;

        /// <summary>
        /// Additional clinical information
        /// </summary>
        [FhirElement("supportingInformation", Order = 140)]
        [References("Observation", "Condition", "DocumentReference")]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ResourceReference> SupportingInformation
        {
            get { if (_supportingInformation == null) _supportingInformation = new List<ResourceReference>(); return _supportingInformation; }
            set { _supportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }

        private List<ResourceReference> _supportingInformation;

        /// <summary>
        /// If the whole order relates to specific specimens
        /// </summary>
        [FhirElement("specimen", Order = 150)]
        [References("Specimen")]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ResourceReference> Specimen
        {
            get { if (_specimen == null) _specimen = new List<ResourceReference>(); return _specimen; }
            set { _specimen = value; OnPropertyChanged("Specimen"); }
        }

        private List<ResourceReference> _specimen;

        /// <summary>
        /// proposed | draft | planned | requested | received | accepted | in-progress | review | completed | cancelled | suspended | rejected | failed
        /// </summary>
        [FhirElement("status", InSummary = true, Order = 160)]
        [DataMember]
        public Code<DiagnosticOrderStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<DiagnosticOrderStatus> _statusElement;

        /// <summary>
        /// proposed | draft | planned | requested | received | accepted | in-progress | review | completed | cancelled | suspended | rejected | failed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DiagnosticOrderStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<DiagnosticOrderStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// routine | urgent | stat | asap
        /// </summary>
        [FhirElement("priority", InSummary = true, Order = 170)]
        [DataMember]
        public Code<DiagnosticOrderPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<DiagnosticOrderPriority> _priorityElement;

        /// <summary>
        /// routine | urgent | stat | asap
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DiagnosticOrderPriority? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    PriorityElement = null;
                else
                    PriorityElement = new Code<DiagnosticOrderPriority>(value);
                OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        /// A list of events of interest in the lifecycle
        /// </summary>
        [FhirElement("event", Order = 180)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<EventComponent> Event
        {
            get { if (_event == null) _event = new List<EventComponent>(); return _event; }
            set { _event = value; OnPropertyChanged("Event"); }
        }

        private List<EventComponent> _event;

        /// <summary>
        /// The items the orderer requested
        /// </summary>
        [FhirElement("item", Order = 190)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ItemComponent> Item
        {
            get { if (_item == null) _item = new List<ItemComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<ItemComponent> _item;

        /// <summary>
        /// Other notes and comments
        /// </summary>
        [FhirElement("note", Order = 200)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note == null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DiagnosticOrder;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Orderer != null) dest.Orderer = (ResourceReference)Orderer.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                if (SupportingInformation != null) dest.SupportingInformation = new List<ResourceReference>(SupportingInformation.DeepCopy());
                if (Specimen != null) dest.Specimen = new List<ResourceReference>(Specimen.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<DiagnosticOrderStatus>)StatusElement.DeepCopy();
                if (PriorityElement != null) dest.PriorityElement = (Code<DiagnosticOrderPriority>)PriorityElement.DeepCopy();
                if (Event != null) dest.Event = new List<EventComponent>(Event.DeepCopy());
                if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new DiagnosticOrder());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DiagnosticOrder;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Orderer, otherT.Orderer)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.Matches(Event, otherT.Event)) return false;
            if (!DeepComparable.Matches(Item, otherT.Item)) return false;
            if (!DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DiagnosticOrder;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Orderer, otherT.Orderer)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(Event, otherT.Event)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Subject != null) yield return Subject;
                if (Orderer != null) yield return Orderer;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Encounter != null) yield return Encounter;
                foreach (var elem in Reason) { if (elem != null) yield return elem; }
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
                foreach (var elem in Specimen) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (PriorityElement != null) yield return PriorityElement;
                foreach (var elem in Event) { if (elem != null) yield return elem; }
                foreach (var elem in Item) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Orderer != null) yield return new ElementValue("orderer", Orderer);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", elem); }
                foreach (var elem in Specimen) { if (elem != null) yield return new ElementValue("specimen", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                foreach (var elem in Event) { if (elem != null) yield return new ElementValue("event", elem); }
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
