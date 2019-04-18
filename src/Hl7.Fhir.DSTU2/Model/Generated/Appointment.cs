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
    /// A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or device(s) for a specific date/time. This may result in one or more Encounter(s)
    /// </summary>
    [FhirType("Appointment", IsResource = true)]
    [DataContract]
    public partial class Appointment : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Appointment; } }
        [NotMapped]
        public override string TypeName { get { return "Appointment"; } }

        /// <summary>
        /// The free/busy status of an appointment.
        /// (url: http://hl7.org/fhir/ValueSet/appointmentstatus)
        /// </summary>
        [FhirEnumeration("AppointmentStatus")]
        public enum AppointmentStatus
        {
            /// <summary>
            /// None of the participant(s) have finalized their acceptance of the appointment request, and the start/end time may not be set yet.
            /// (system: http://hl7.org/fhir/appointmentstatus)
            /// </summary>
            [EnumLiteral("proposed", "http://hl7.org/fhir/appointmentstatus"), Description("Proposed")]
            Proposed,
            /// <summary>
            /// Some or all of the participant(s) have not finalized their acceptance of the appointment request.
            /// (system: http://hl7.org/fhir/appointmentstatus)
            /// </summary>
            [EnumLiteral("pending", "http://hl7.org/fhir/appointmentstatus"), Description("Pending")]
            Pending,
            /// <summary>
            /// All participant(s) have been considered and the appointment is confirmed to go ahead at the date/times specified.
            /// (system: http://hl7.org/fhir/appointmentstatus)
            /// </summary>
            [EnumLiteral("booked", "http://hl7.org/fhir/appointmentstatus"), Description("Booked")]
            Booked,
            /// <summary>
            /// Some of the patients have arrived.
            /// (system: http://hl7.org/fhir/appointmentstatus)
            /// </summary>
            [EnumLiteral("arrived", "http://hl7.org/fhir/appointmentstatus"), Description("Arrived")]
            Arrived,
            /// <summary>
            /// This appointment has completed and may have resulted in an encounter.
            /// (system: http://hl7.org/fhir/appointmentstatus)
            /// </summary>
            [EnumLiteral("fulfilled", "http://hl7.org/fhir/appointmentstatus"), Description("Fulfilled")]
            Fulfilled,
            /// <summary>
            /// The appointment has been cancelled.
            /// (system: http://hl7.org/fhir/appointmentstatus)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/appointmentstatus"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// Some or all of the participant(s) have not/did not appear for the appointment (usually the patient).
            /// (system: http://hl7.org/fhir/appointmentstatus)
            /// </summary>
            [EnumLiteral("noshow", "http://hl7.org/fhir/appointmentstatus"), Description("No Show")]
            Noshow,
        }

        /// <summary>
        /// Is the Participant required to attend the appointment.
        /// (url: http://hl7.org/fhir/ValueSet/participantrequired)
        /// </summary>
        [FhirEnumeration("ParticipantRequired")]
        public enum ParticipantRequired
        {
            /// <summary>
            /// The participant is required to attend the appointment.
            /// (system: http://hl7.org/fhir/participantrequired)
            /// </summary>
            [EnumLiteral("required", "http://hl7.org/fhir/participantrequired"), Description("Required")]
            Required,
            /// <summary>
            /// The participant may optionally attend the appointment.
            /// (system: http://hl7.org/fhir/participantrequired)
            /// </summary>
            [EnumLiteral("optional", "http://hl7.org/fhir/participantrequired"), Description("Optional")]
            Optional,
            /// <summary>
            /// The participant is excluded from the appointment, and may not be informed of the appointment taking place. (Appointment is about them, not for them - such as 2 doctors discussing results about a patient's test).
            /// (system: http://hl7.org/fhir/participantrequired)
            /// </summary>
            [EnumLiteral("information-only", "http://hl7.org/fhir/participantrequired"), Description("Information Only")]
            InformationOnly,
        }

        /// <summary>
        /// The Participation status of an appointment.
        /// (url: http://hl7.org/fhir/ValueSet/participationstatus)
        /// </summary>
        [FhirEnumeration("ParticipationStatus")]
        public enum ParticipationStatus
        {
            /// <summary>
            /// The participant has accepted the appointment.
            /// (system: http://hl7.org/fhir/participationstatus)
            /// </summary>
            [EnumLiteral("accepted", "http://hl7.org/fhir/participationstatus"), Description("Accepted")]
            Accepted,
            /// <summary>
            /// The participant has declined the appointment and will not participate in the appointment.
            /// (system: http://hl7.org/fhir/participationstatus)
            /// </summary>
            [EnumLiteral("declined", "http://hl7.org/fhir/participationstatus"), Description("Declined")]
            Declined,
            /// <summary>
            /// The participant has  tentatively accepted the appointment. This could be automatically created by a system and requires further processing before it can be accepted. There is no commitment that attendance will occur.
            /// (system: http://hl7.org/fhir/participationstatus)
            /// </summary>
            [EnumLiteral("tentative", "http://hl7.org/fhir/participationstatus"), Description("Tentative")]
            Tentative,
            /// <summary>
            /// The participant needs to indicate if they accept the appointment by changing this status to one of the other statuses.
            /// (system: http://hl7.org/fhir/participationstatus)
            /// </summary>
            [EnumLiteral("needs-action", "http://hl7.org/fhir/participationstatus"), Description("Needs Action")]
            NeedsAction,
        }


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// Role of participant in the appointment
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 40)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<CodeableConcept> Type
            {
                get { if (_type == null) _type = new List<CodeableConcept>(); return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private List<CodeableConcept> _type;

            /// <summary>
            /// Person, Location/HealthcareService or Device
            /// </summary>
            [FhirElement("actor", InSummary = true, Order = 50)]
            [References("Patient", "Practitioner", "RelatedPerson", "Device", "HealthcareService", "Location")]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            /// <summary>
            /// required | optional | information-only
            /// </summary>
            [FhirElement("required", InSummary = true, Order = 60)]
            [DataMember]
            public Code<ParticipantRequired> RequiredElement
            {
                get { return _requiredElement; }
                set { _requiredElement = value; OnPropertyChanged("RequiredElement"); }
            }

            private Code<ParticipantRequired> _requiredElement;

            /// <summary>
            /// required | optional | information-only
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ParticipantRequired? Required
            {
                get { return RequiredElement != null ? RequiredElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        RequiredElement = null;
                    else
                        RequiredElement = new Code<ParticipantRequired>(value);
                    OnPropertyChanged("Required");
                }
            }

            /// <summary>
            /// accepted | declined | tentative | needs-action
            /// </summary>
            [FhirElement("status", Order = 70)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Code<ParticipationStatus> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<ParticipationStatus> _statusElement;

            /// <summary>
            /// accepted | declined | tentative | needs-action
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ParticipationStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        StatusElement = null;
                    else
                        StatusElement = new Code<ParticipationStatus>(value);
                    OnPropertyChanged("Status");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                    if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
                    if (RequiredElement != null) dest.RequiredElement = (Code<ParticipantRequired>)RequiredElement.DeepCopy();
                    if (StatusElement != null) dest.StatusElement = (Code<ParticipationStatus>)StatusElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ParticipantComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if (!DeepComparable.Matches(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if (!DeepComparable.IsExactly(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Type) { if (elem != null) yield return elem; }
                    if (Actor != null) yield return Actor;
                    if (RequiredElement != null) yield return RequiredElement;
                    if (StatusElement != null) yield return StatusElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                    if (RequiredElement != null) yield return new ElementValue("required", RequiredElement);
                    if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                }
            }


        }


        /// <summary>
        /// External Ids for this item
        /// </summary>
        [FhirElement("identifier", InSummary = true, Order = 90)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// proposed | pending | booked | arrived | fulfilled | cancelled | noshow
        /// </summary>
        [FhirElement("status", InSummary = true, Order = 100)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public Code<AppointmentStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<AppointmentStatus> _statusElement;

        /// <summary>
        /// proposed | pending | booked | arrived | fulfilled | cancelled | noshow
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AppointmentStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<AppointmentStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The type of appointment that is being booked
        /// </summary>
        [FhirElement("type", InSummary = true, Order = 110)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Reason this appointment is scheduled
        /// </summary>
        [FhirElement("reason", InSummary = true, Order = 120)]
        [DataMember]
        public CodeableConcept Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private CodeableConcept _reason;

        /// <summary>
        /// Used to make informed decisions if needing to re-prioritize
        /// </summary>
        [FhirElement("priority", Order = 130)]
        [DataMember]
        public UnsignedInt PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private UnsignedInt _priorityElement;

        /// <summary>
        /// Used to make informed decisions if needing to re-prioritize
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    PriorityElement = null;
                else
                    PriorityElement = new UnsignedInt(value);
                OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        /// Shown on a subject line in a meeting request, or appointment list
        /// </summary>
        [FhirElement("description", Order = 140)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Shown on a subject line in a meeting request, or appointment list
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
        /// When appointment is to take place
        /// </summary>
        [FhirElement("start", InSummary = true, Order = 150)]
        [DataMember]
        public Instant StartElement
        {
            get { return _startElement; }
            set { _startElement = value; OnPropertyChanged("StartElement"); }
        }

        private Instant _startElement;

        /// <summary>
        /// When appointment is to take place
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? Start
        {
            get { return StartElement != null ? StartElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StartElement = null;
                else
                    StartElement = new Instant(value);
                OnPropertyChanged("Start");
            }
        }

        /// <summary>
        /// When appointment is to conclude
        /// </summary>
        [FhirElement("end", InSummary = true, Order = 160)]
        [DataMember]
        public Instant EndElement
        {
            get { return _endElement; }
            set { _endElement = value; OnPropertyChanged("EndElement"); }
        }

        private Instant _endElement;

        /// <summary>
        /// When appointment is to conclude
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? End
        {
            get { return EndElement != null ? EndElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    EndElement = null;
                else
                    EndElement = new Instant(value);
                OnPropertyChanged("End");
            }
        }

        /// <summary>
        /// Can be less than start/end (e.g. estimate)
        /// </summary>
        [FhirElement("minutesDuration", Order = 170)]
        [DataMember]
        public PositiveInt MinutesDurationElement
        {
            get { return _minutesDurationElement; }
            set { _minutesDurationElement = value; OnPropertyChanged("MinutesDurationElement"); }
        }

        private PositiveInt _minutesDurationElement;

        /// <summary>
        /// Can be less than start/end (e.g. estimate)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? MinutesDuration
        {
            get { return MinutesDurationElement != null ? MinutesDurationElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    MinutesDurationElement = null;
                else
                    MinutesDurationElement = new PositiveInt(value);
                OnPropertyChanged("MinutesDuration");
            }
        }

        /// <summary>
        /// If provided, then no schedule and start/end values MUST match slot
        /// </summary>
        [FhirElement("slot", Order = 180)]
        [References("Slot")]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ResourceReference> Slot
        {
            get { if (_slot == null) _slot = new List<ResourceReference>(); return _slot; }
            set { _slot = value; OnPropertyChanged("Slot"); }
        }

        private List<ResourceReference> _slot;

        /// <summary>
        /// Additional comments
        /// </summary>
        [FhirElement("comment", Order = 190)]
        [DataMember]
        public FhirString CommentElement
        {
            get { return _commentElement; }
            set { _commentElement = value; OnPropertyChanged("CommentElement"); }
        }

        private FhirString _commentElement;

        /// <summary>
        /// Additional comments
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Comment
        {
            get { return CommentElement != null ? CommentElement.Value : null; }
            set
            {
                if (value == null)
                    CommentElement = null;
                else
                    CommentElement = new FhirString(value);
                OnPropertyChanged("Comment");
            }
        }

        /// <summary>
        /// Participants involved in appointment
        /// </summary>
        [FhirElement("participant", Order = 200)]
        [Cardinality(Min = 1, Max = -1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if (_participant == null) _participant = new List<ParticipantComponent>(); return _participant; }
            set { _participant = value; OnPropertyChanged("Participant"); }
        }

        private List<ParticipantComponent> _participant;


        public static ElementDefinition.ConstraintComponent Appointment_APP_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(start.exists() and end.exists()) or (status = 'proposed') or (status = 'cancelled')",
            Key = "app-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Only proposed or cancelled appointments can be missing start/end dates",
            Xpath = "((exists(f:start) and exists(f:end)) or (f:status/@value='proposed') or (f:status/@value='cancelled'))"
        };

        public static ElementDefinition.ConstraintComponent Appointment_APP_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "start.empty() xor end.exists()",
            Key = "app-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Either start and end are specified, or neither",
            Xpath = "((exists(f:start) and exists(f:end)) or (not(exists(f:start)) and not(exists(f:end))))"
        };

        public static ElementDefinition.ConstraintComponent Appointment_APP_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "participant.all(type.exists() or actor.exists())",
            Key = "app-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Either the type or actor on the participant MUST be specified",
            Xpath = "(exists(f:type) or exists(f:actor))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Appointment_APP_3);
            InvariantConstraints.Add(Appointment_APP_2);
            InvariantConstraints.Add(Appointment_APP_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Appointment;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<AppointmentStatus>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                if (PriorityElement != null) dest.PriorityElement = (UnsignedInt)PriorityElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (StartElement != null) dest.StartElement = (Instant)StartElement.DeepCopy();
                if (EndElement != null) dest.EndElement = (Instant)EndElement.DeepCopy();
                if (MinutesDurationElement != null) dest.MinutesDurationElement = (PositiveInt)MinutesDurationElement.DeepCopy();
                if (Slot != null) dest.Slot = new List<ResourceReference>(Slot.DeepCopy());
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Appointment());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Appointment;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.Matches(EndElement, otherT.EndElement)) return false;
            if (!DeepComparable.Matches(MinutesDurationElement, otherT.MinutesDurationElement)) return false;
            if (!DeepComparable.Matches(Slot, otherT.Slot)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.Matches(Participant, otherT.Participant)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Appointment;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;
            if (!DeepComparable.IsExactly(MinutesDurationElement, otherT.MinutesDurationElement)) return false;
            if (!DeepComparable.IsExactly(Slot, otherT.Slot)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (Type != null) yield return Type;
                if (Reason != null) yield return Reason;
                if (PriorityElement != null) yield return PriorityElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                if (StartElement != null) yield return StartElement;
                if (EndElement != null) yield return EndElement;
                if (MinutesDurationElement != null) yield return MinutesDurationElement;
                foreach (var elem in Slot) { if (elem != null) yield return elem; }
                if (CommentElement != null) yield return CommentElement;
                foreach (var elem in Participant) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (Reason != null) yield return new ElementValue("reason", Reason);
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (StartElement != null) yield return new ElementValue("start", StartElement);
                if (EndElement != null) yield return new ElementValue("end", EndElement);
                if (MinutesDurationElement != null) yield return new ElementValue("minutesDuration", MinutesDurationElement);
                foreach (var elem in Slot) { if (elem != null) yield return new ElementValue("slot", elem); }
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
            }
        }

    }

}
