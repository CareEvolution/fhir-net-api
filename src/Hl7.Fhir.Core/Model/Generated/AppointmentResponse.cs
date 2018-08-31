﻿using System;
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
    /// A reply to an appointment request for a patient and/or practitioner(s), such as a confirmation or rejection
    /// </summary>
    [FhirType("AppointmentResponse", IsResource=true)]
    [DataContract]
    public partial class AppointmentResponse : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.AppointmentResponse; } }
        [NotMapped]
        public override string TypeName { get { return "AppointmentResponse"; } }

        /// <summary>
        /// The Participation status of an appointment.
        /// (url: http://hl7.org/fhir/ValueSet/participantstatus)
        /// </summary>
        [FhirEnumeration("ParticipantStatus")]
        public enum ParticipantStatus
        {
            /// <summary>
            /// The appointment participant has accepted that they can attend the appointment at the time specified in the AppointmentResponse.
            /// (system: http://hl7.org/fhir/participantstatus)
            /// </summary>
            [EnumLiteral("accepted", "http://hl7.org/fhir/participantstatus"), Description("Accepted")]
            Accepted,
            /// <summary>
            /// The appointment participant has declined the appointment.
            /// (system: http://hl7.org/fhir/participantstatus)
            /// </summary>
            [EnumLiteral("declined", "http://hl7.org/fhir/participantstatus"), Description("Declined")]
            Declined,
            /// <summary>
            /// The appointment participant has tentatively accepted the appointment.
            /// (system: http://hl7.org/fhir/participantstatus)
            /// </summary>
            [EnumLiteral("tentative", "http://hl7.org/fhir/participantstatus"), Description("Tentative")]
            Tentative,
            /// <summary>
            /// The participant has in-process the appointment.
            /// (system: http://hl7.org/fhir/participantstatus)
            /// </summary>
            [EnumLiteral("in-process", "http://hl7.org/fhir/participantstatus"), Description("In Process")]
            InProcess,
            /// <summary>
            /// The participant has completed the appointment.
            /// (system: http://hl7.org/fhir/participantstatus)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/participantstatus"), Description("Completed")]
            Completed,
            /// <summary>
            /// This is the intitial status of an appointment participant until a participant has replied. It implies that there is no commitment for the appointment.
            /// (system: http://hl7.org/fhir/participantstatus)
            /// </summary>
            [EnumLiteral("needs-action", "http://hl7.org/fhir/participantstatus"), Description("Needs Action")]
            NeedsAction,
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
        /// Appointment this response relates to
        /// </summary>
        [FhirElement("appointment", InSummary=true, Order=100)]
        [References("Appointment")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Appointment
        {
            get { return _appointment; }
            set { _appointment = value; OnPropertyChanged("Appointment"); }
        }

        private ResourceReference _appointment;

        /// <summary>
        /// Time from appointment, or requested new start time
        /// </summary>
        [FhirElement("start", Order=110)]
        [DataMember]
        public Instant StartElement
        {
            get { return _startElement; }
            set { _startElement = value; OnPropertyChanged("StartElement"); }
        }

        private Instant _startElement;

        /// <summary>
        /// Time from appointment, or requested new start time
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
        /// Time from appointment, or requested new end time
        /// </summary>
        [FhirElement("end", Order=120)]
        [DataMember]
        public Instant EndElement
        {
            get { return _endElement; }
            set { _endElement = value; OnPropertyChanged("EndElement"); }
        }

        private Instant _endElement;

        /// <summary>
        /// Time from appointment, or requested new end time
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
        /// Role of participant in the appointment
        /// </summary>
        [FhirElement("participantType", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ParticipantType
        {
            get { if (_participantType==null) _participantType = new List<CodeableConcept>(); return _participantType; }
            set { _participantType = value; OnPropertyChanged("ParticipantType"); }
        }

        private List<CodeableConcept> _participantType;

        /// <summary>
        /// Person, Location/HealthcareService or Device
        /// </summary>
        [FhirElement("actor", InSummary=true, Order=140)]
        [References("Patient","Practitioner","RelatedPerson","Device","HealthcareService","Location")]
        [DataMember]
        public ResourceReference Actor
        {
            get { return _actor; }
            set { _actor = value; OnPropertyChanged("Actor"); }
        }

        private ResourceReference _actor;

        /// <summary>
        /// accepted | declined | tentative | in-process | completed | needs-action
        /// </summary>
        [FhirElement("participantStatus", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ParticipantStatus> ParticipantStatusElement
        {
            get { return _participantStatusElement; }
            set { _participantStatusElement = value; OnPropertyChanged("ParticipantStatusElement"); }
        }

        private Code<ParticipantStatus> _participantStatusElement;

        /// <summary>
        /// accepted | declined | tentative | in-process | completed | needs-action
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ParticipantStatus? ParticipantStatus
        {
            get { return ParticipantStatusElement != null ? ParticipantStatusElement.Value : null; }
            set
            {
                if (value == null)
                    ParticipantStatusElement = null;
                else
                    ParticipantStatusElement = new Code<ParticipantStatus>(value);
                OnPropertyChanged("ParticipantStatus");
            }
        }

        /// <summary>
        /// Additional comments
        /// </summary>
        [FhirElement("comment", Order=160)]
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


        public static ElementDefinition.ConstraintComponent AppointmentResponse_APR_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "participantType or actor",
            Key = "apr-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Either the participantType or actor must be specified",
            Xpath = "(exists(f:participantType) or exists(f:actor))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(AppointmentResponse_APR_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as AppointmentResponse;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Appointment != null) dest.Appointment = (ResourceReference)Appointment.DeepCopy();
                if (StartElement != null) dest.StartElement = (Instant)StartElement.DeepCopy();
                if (EndElement != null) dest.EndElement = (Instant)EndElement.DeepCopy();
                if (ParticipantType != null) dest.ParticipantType = new List<CodeableConcept>(ParticipantType.DeepCopy());
                if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
                if (ParticipantStatusElement != null) dest.ParticipantStatusElement = (Code<ParticipantStatus>)ParticipantStatusElement.DeepCopy();
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new AppointmentResponse());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as AppointmentResponse;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Appointment, otherT.Appointment)) return false;
            if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.Matches(EndElement, otherT.EndElement)) return false;
            if ( !DeepComparable.Matches(ParticipantType, otherT.ParticipantType)) return false;
            if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;
            if (!DeepComparable.Matches(ParticipantStatusElement, otherT.ParticipantStatusElement)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as AppointmentResponse;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Appointment, otherT.Appointment)) return false;
            if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;
            if (!DeepComparable.IsExactly(ParticipantType, otherT.ParticipantType)) return false;
            if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
            if (!DeepComparable.IsExactly(ParticipantStatusElement, otherT.ParticipantStatusElement)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Appointment != null) yield return Appointment;
                if (StartElement != null) yield return StartElement;
                if (EndElement != null) yield return EndElement;
                foreach (var elem in ParticipantType) { if (elem != null) yield return elem; }
                if (Actor != null) yield return Actor;
                if (ParticipantStatusElement != null) yield return ParticipantStatusElement;
                if (CommentElement != null) yield return CommentElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Appointment != null) yield return new ElementValue("appointment", Appointment);
                if (StartElement != null) yield return new ElementValue("start", StartElement);
                if (EndElement != null) yield return new ElementValue("end", EndElement);
                foreach (var elem in ParticipantType) { if (elem != null) yield return new ElementValue("participantType", elem); }
                if (Actor != null) yield return new ElementValue("actor", Actor);
                if (ParticipantStatusElement != null) yield return new ElementValue("participantStatus", ParticipantStatusElement);
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
            }
        }

    }

}
