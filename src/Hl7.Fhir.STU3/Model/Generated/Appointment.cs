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
    /// A booking of a healthcare event among patient(s), practitioner(s), related person(s) and/or device(s) for a specific date/time. This may result in one or more Encounter(s)
    /// </summary>
    [FhirType("Appointment", IsResource=true)]
    [DataContract]
    public partial class Appointment : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Appointment; } }
        [NotMapped]
        public override string TypeName { get { return "Appointment"; } }


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// Role of participant in the appointment
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Type
            {
                get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private List<CodeableConcept> _type;

            /// <summary>
            /// Person, Location/HealthcareService or Device
            /// </summary>
            [FhirElement("actor", InSummary=true, Order=50)]
            [References("Patient","Practitioner","RelatedPerson","Device","HealthcareService","Location")]
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
            [FhirElement("required", InSummary=true, Order=60)]
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
                    if (value == null)
                        RequiredElement = null;
                    else
                        RequiredElement = new Code<ParticipantRequired>(value);
                    OnPropertyChanged("Required");
                }
            }

            /// <summary>
            /// accepted | declined | tentative | needs-action
            /// </summary>
            [FhirElement("status", Order=70)]
            [Cardinality(Min=1,Max=1)]
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
                    if (value == null)
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
                if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
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
        /// proposed | pending | booked | arrived | fulfilled | cancelled | noshow | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<AppointmentStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<AppointmentStatus> _statusElement;

        /// <summary>
        /// proposed | pending | booked | arrived | fulfilled | cancelled | noshow | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AppointmentStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<AppointmentStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// A broad categorisation of the service that is to be performed during this appointment
        /// </summary>
        [FhirElement("serviceCategory", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept ServiceCategory
        {
            get { return _serviceCategory; }
            set { _serviceCategory = value; OnPropertyChanged("ServiceCategory"); }
        }

        private CodeableConcept _serviceCategory;

        /// <summary>
        /// The specific service that is to be performed during this appointment
        /// </summary>
        [FhirElement("serviceType", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ServiceType
        {
            get { if (_serviceType==null) _serviceType = new List<CodeableConcept>(); return _serviceType; }
            set { _serviceType = value; OnPropertyChanged("ServiceType"); }
        }

        private List<CodeableConcept> _serviceType;

        /// <summary>
        /// The specialty of a practitioner that would be required to perform the service requested in this appointment
        /// </summary>
        [FhirElement("specialty", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Specialty
        {
            get { if (_specialty==null) _specialty = new List<CodeableConcept>(); return _specialty; }
            set { _specialty = value; OnPropertyChanged("Specialty"); }
        }

        private List<CodeableConcept> _specialty;

        /// <summary>
        /// The style of appointment or patient that has been booked in the slot (not service type)
        /// </summary>
        [FhirElement("appointmentType", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept AppointmentType
        {
            get { return _appointmentType; }
            set { _appointmentType = value; OnPropertyChanged("AppointmentType"); }
        }

        private CodeableConcept _appointmentType;

        /// <summary>
        /// Reason this appointment is scheduled
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Reason
        {
            get { if (_reason==null) _reason = new List<CodeableConcept>(); return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private List<CodeableConcept> _reason;

        /// <summary>
        /// Reason the appointment is to takes place (resource)
        /// </summary>
        [FhirElement("indication", Order=160)]
        [References("Condition","Procedure")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Indication
        {
            get { if (_indication==null) _indication = new List<ResourceReference>(); return _indication; }
            set { _indication = value; OnPropertyChanged("Indication"); }
        }

        private List<ResourceReference> _indication;

        /// <summary>
        /// Used to make informed decisions if needing to re-prioritize
        /// </summary>
        [FhirElement("priority", Order=170)]
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
                if (value == null)
                    PriorityElement = null;
                else
                    PriorityElement = new UnsignedInt(value);
                OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        /// Shown on a subject line in a meeting request, or appointment list
        /// </summary>
        [FhirElement("description", Order=180)]
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
        /// Additional information to support the appointment
        /// </summary>
        [FhirElement("supportingInformation", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInformation
        {
            get { if (_supportingInformation==null) _supportingInformation = new List<ResourceReference>(); return _supportingInformation; }
            set { _supportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }

        private List<ResourceReference> _supportingInformation;

        /// <summary>
        /// When appointment is to take place
        /// </summary>
        [FhirElement("start", InSummary=true, Order=200)]
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
                if (value == null)
                    StartElement = null;
                else
                    StartElement = new Instant(value);
                OnPropertyChanged("Start");
            }
        }

        /// <summary>
        /// When appointment is to conclude
        /// </summary>
        [FhirElement("end", InSummary=true, Order=210)]
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
                if (value == null)
                    EndElement = null;
                else
                    EndElement = new Instant(value);
                OnPropertyChanged("End");
            }
        }

        /// <summary>
        /// Can be less than start/end (e.g. estimate)
        /// </summary>
        [FhirElement("minutesDuration", Order=220)]
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
                if (value == null)
                    MinutesDurationElement = null;
                else
                    MinutesDurationElement = new PositiveInt(value);
                OnPropertyChanged("MinutesDuration");
            }
        }

        /// <summary>
        /// The slots that this appointment is filling
        /// </summary>
        [FhirElement("slot", Order=230)]
        [References("Slot")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Slot
        {
            get { if (_slot==null) _slot = new List<ResourceReference>(); return _slot; }
            set { _slot = value; OnPropertyChanged("Slot"); }
        }

        private List<ResourceReference> _slot;

        /// <summary>
        /// The date that this appointment was initially created
        /// </summary>
        [FhirElement("created", Order=240)]
        [DataMember]
        public FhirDateTime CreatedElement
        {
            get { return _createdElement; }
            set { _createdElement = value; OnPropertyChanged("CreatedElement"); }
        }

        private FhirDateTime _createdElement;

        /// <summary>
        /// The date that this appointment was initially created
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if (value == null)
                    CreatedElement = null;
                else
                    CreatedElement = new FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }

        /// <summary>
        /// Additional comments
        /// </summary>
        [FhirElement("comment", Order=250)]
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
        /// The ReferralRequest provided as information to allocate to the Encounter
        /// </summary>
        [FhirElement("incomingReferral", Order=260)]
        [References("ReferralRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> IncomingReferral
        {
            get { if (_incomingReferral==null) _incomingReferral = new List<ResourceReference>(); return _incomingReferral; }
            set { _incomingReferral = value; OnPropertyChanged("IncomingReferral"); }
        }

        private List<ResourceReference> _incomingReferral;

        /// <summary>
        /// Participants involved in appointment
        /// </summary>
        [FhirElement("participant", Order=270)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if (_participant==null) _participant = new List<ParticipantComponent>(); return _participant; }
            set { _participant = value; OnPropertyChanged("Participant"); }
        }

        private List<ParticipantComponent> _participant;

        /// <summary>
        /// Potential date/time interval(s) requested to allocate the appointment within
        /// </summary>
        [FhirElement("requestedPeriod", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Period> RequestedPeriod
        {
            get { if (_requestedPeriod==null) _requestedPeriod = new List<Period>(); return _requestedPeriod; }
            set { _requestedPeriod = value; OnPropertyChanged("RequestedPeriod"); }
        }

        private List<Period> _requestedPeriod;


        public static ElementDefinition.ConstraintComponent Appointment_APP_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(start.exists() and end.exists()) or (status in ('proposed' | 'cancelled'))",
            Key = "app-3",
            Severity = ConstraintSeverity.Warning,
            Human = "Only proposed or cancelled appointments can be missing start/end dates",
            Xpath = "((exists(f:start) and exists(f:end)) or (f:status/@value='proposed') or (f:status/@value='cancelled'))"
        };

        public static ElementDefinition.ConstraintComponent Appointment_APP_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "start.empty() xor end.exists()",
            Key = "app-2",
            Severity = ConstraintSeverity.Warning,
            Human = "Either start and end are specified, or neither",
            Xpath = "((exists(f:start) and exists(f:end)) or (not(exists(f:start)) and not(exists(f:end))))"
        };

        public static ElementDefinition.ConstraintComponent Appointment_APP_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "participant.all(type.exists() or actor.exists())",
            Key = "app-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Either the type or actor on the participant SHALL be specified",
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
                if (ServiceCategory != null) dest.ServiceCategory = (CodeableConcept)ServiceCategory.DeepCopy();
                if (ServiceType != null) dest.ServiceType = new List<CodeableConcept>(ServiceType.DeepCopy());
                if (Specialty != null) dest.Specialty = new List<CodeableConcept>(Specialty.DeepCopy());
                if (AppointmentType != null) dest.AppointmentType = (CodeableConcept)AppointmentType.DeepCopy();
                if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                if (Indication != null) dest.Indication = new List<ResourceReference>(Indication.DeepCopy());
                if (PriorityElement != null) dest.PriorityElement = (UnsignedInt)PriorityElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (SupportingInformation != null) dest.SupportingInformation = new List<ResourceReference>(SupportingInformation.DeepCopy());
                if (StartElement != null) dest.StartElement = (Instant)StartElement.DeepCopy();
                if (EndElement != null) dest.EndElement = (Instant)EndElement.DeepCopy();
                if (MinutesDurationElement != null) dest.MinutesDurationElement = (PositiveInt)MinutesDurationElement.DeepCopy();
                if (Slot != null) dest.Slot = new List<ResourceReference>(Slot.DeepCopy());
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                if (IncomingReferral != null) dest.IncomingReferral = new List<ResourceReference>(IncomingReferral.DeepCopy());
                if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                if (RequestedPeriod != null) dest.RequestedPeriod = new List<Period>(RequestedPeriod.DeepCopy());
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
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ServiceCategory, otherT.ServiceCategory)) return false;
            if ( !DeepComparable.Matches(ServiceType, otherT.ServiceType)) return false;
            if ( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.Matches(AppointmentType, otherT.AppointmentType)) return false;
            if ( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if ( !DeepComparable.Matches(Indication, otherT.Indication)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.Matches(EndElement, otherT.EndElement)) return false;
            if (!DeepComparable.Matches(MinutesDurationElement, otherT.MinutesDurationElement)) return false;
            if ( !DeepComparable.Matches(Slot, otherT.Slot)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if ( !DeepComparable.Matches(IncomingReferral, otherT.IncomingReferral)) return false;
            if ( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if ( !DeepComparable.Matches(RequestedPeriod, otherT.RequestedPeriod)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Appointment;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ServiceCategory, otherT.ServiceCategory)) return false;
            if (!DeepComparable.IsExactly(ServiceType, otherT.ServiceType)) return false;
            if (!DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.IsExactly(AppointmentType, otherT.AppointmentType)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;
            if (!DeepComparable.IsExactly(MinutesDurationElement, otherT.MinutesDurationElement)) return false;
            if (!DeepComparable.IsExactly(Slot, otherT.Slot)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.IsExactly(IncomingReferral, otherT.IncomingReferral)) return false;
            if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if (!DeepComparable.IsExactly(RequestedPeriod, otherT.RequestedPeriod)) return false;

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
                if (ServiceCategory != null) yield return ServiceCategory;
                foreach (var elem in ServiceType) { if (elem != null) yield return elem; }
                foreach (var elem in Specialty) { if (elem != null) yield return elem; }
                if (AppointmentType != null) yield return AppointmentType;
                foreach (var elem in Reason) { if (elem != null) yield return elem; }
                foreach (var elem in Indication) { if (elem != null) yield return elem; }
                if (PriorityElement != null) yield return PriorityElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
                if (StartElement != null) yield return StartElement;
                if (EndElement != null) yield return EndElement;
                if (MinutesDurationElement != null) yield return MinutesDurationElement;
                foreach (var elem in Slot) { if (elem != null) yield return elem; }
                if (CreatedElement != null) yield return CreatedElement;
                if (CommentElement != null) yield return CommentElement;
                foreach (var elem in IncomingReferral) { if (elem != null) yield return elem; }
                foreach (var elem in Participant) { if (elem != null) yield return elem; }
                foreach (var elem in RequestedPeriod) { if (elem != null) yield return elem; }
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
                if (ServiceCategory != null) yield return new ElementValue("serviceCategory", ServiceCategory);
                foreach (var elem in ServiceType) { if (elem != null) yield return new ElementValue("serviceType", elem); }
                foreach (var elem in Specialty) { if (elem != null) yield return new ElementValue("specialty", elem); }
                if (AppointmentType != null) yield return new ElementValue("appointmentType", AppointmentType);
                foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                foreach (var elem in Indication) { if (elem != null) yield return new ElementValue("indication", elem); }
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", elem); }
                if (StartElement != null) yield return new ElementValue("start", StartElement);
                if (EndElement != null) yield return new ElementValue("end", EndElement);
                if (MinutesDurationElement != null) yield return new ElementValue("minutesDuration", MinutesDurationElement);
                foreach (var elem in Slot) { if (elem != null) yield return new ElementValue("slot", elem); }
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                foreach (var elem in IncomingReferral) { if (elem != null) yield return new ElementValue("incomingReferral", elem); }
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
                foreach (var elem in RequestedPeriod) { if (elem != null) yield return new ElementValue("requestedPeriod", elem); }
            }
        }

    }

}
