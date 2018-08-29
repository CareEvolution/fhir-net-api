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
    /// A slot of time on a schedule that may be available for booking appointments
    /// </summary>
    [FhirType("Slot", IsResource=true)]
    [DataContract]
    public partial class Slot : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Slot; } }
        [NotMapped]
        public override string TypeName { get { return "Slot"; } }


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
        /// A broad categorization of the service that is to be performed during this appointment
        /// </summary>
        [FhirElement("serviceCategory", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ServiceCategory
        {
            get { if (_serviceCategory==null) _serviceCategory = new List<CodeableConcept>(); return _serviceCategory; }
            set { _serviceCategory = value; OnPropertyChanged("ServiceCategory"); }
        }

        private List<CodeableConcept> _serviceCategory;

        /// <summary>
        /// The type of appointments that can be booked into this slot (ideally this would be an identifiable service - which is at a location, rather than the location itself). If provided then this overrides the value provided on the availability resource
        /// </summary>
        [FhirElement("serviceType", InSummary=true, Order=110)]
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
        [FhirElement("specialty", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Specialty
        {
            get { if (_specialty==null) _specialty = new List<CodeableConcept>(); return _specialty; }
            set { _specialty = value; OnPropertyChanged("Specialty"); }
        }

        private List<CodeableConcept> _specialty;

        /// <summary>
        /// The style of appointment or patient that may be booked in the slot (not service type)
        /// </summary>
        [FhirElement("appointmentType", InSummary=true, Order=130)]
        [DataMember]
        public CodeableConcept AppointmentType
        {
            get { return _appointmentType; }
            set { _appointmentType = value; OnPropertyChanged("AppointmentType"); }
        }

        private CodeableConcept _appointmentType;

        /// <summary>
        /// The schedule resource that this slot defines an interval of status information
        /// </summary>
        [FhirElement("schedule", InSummary=true, Order=140)]
        [References("Schedule")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Schedule
        {
            get { return _schedule; }
            set { _schedule = value; OnPropertyChanged("Schedule"); }
        }

        private ResourceReference _schedule;

        /// <summary>
        /// busy | free | busy-unavailable | busy-tentative | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<SlotStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<SlotStatus> _statusElement;

        /// <summary>
        /// busy | free | busy-unavailable | busy-tentative | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public SlotStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<SlotStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Date/Time that the slot is to begin
        /// </summary>
        [FhirElement("start", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Instant StartElement
        {
            get { return _startElement; }
            set { _startElement = value; OnPropertyChanged("StartElement"); }
        }

        private Instant _startElement;

        /// <summary>
        /// Date/Time that the slot is to begin
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
        /// Date/Time that the slot is to conclude
        /// </summary>
        [FhirElement("end", InSummary=true, Order=170)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Instant EndElement
        {
            get { return _endElement; }
            set { _endElement = value; OnPropertyChanged("EndElement"); }
        }

        private Instant _endElement;

        /// <summary>
        /// Date/Time that the slot is to conclude
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
        /// This slot has already been overbooked, appointments are unlikely to be accepted for this time
        /// </summary>
        [FhirElement("overbooked", Order=180)]
        [DataMember]
        public FhirBoolean OverbookedElement
        {
            get { return _overbookedElement; }
            set { _overbookedElement = value; OnPropertyChanged("OverbookedElement"); }
        }

        private FhirBoolean _overbookedElement;

        /// <summary>
        /// This slot has already been overbooked, appointments are unlikely to be accepted for this time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Overbooked
        {
            get { return OverbookedElement != null ? OverbookedElement.Value : null; }
            set
            {
                if (value == null)
                    OverbookedElement = null;
                else
                    OverbookedElement = new FhirBoolean(value);
                OnPropertyChanged("Overbooked");
            }
        }

        /// <summary>
        /// Comments on the slot to describe any extended information. Such as custom constraints on the slot
        /// </summary>
        [FhirElement("comment", Order=190)]
        [DataMember]
        public FhirString CommentElement
        {
            get { return _commentElement; }
            set { _commentElement = value; OnPropertyChanged("CommentElement"); }
        }

        private FhirString _commentElement;

        /// <summary>
        /// Comments on the slot to describe any extended information. Such as custom constraints on the slot
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


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Slot;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ServiceCategory != null) dest.ServiceCategory = new List<CodeableConcept>(ServiceCategory.DeepCopy());
                if (ServiceType != null) dest.ServiceType = new List<CodeableConcept>(ServiceType.DeepCopy());
                if (Specialty != null) dest.Specialty = new List<CodeableConcept>(Specialty.DeepCopy());
                if (AppointmentType != null) dest.AppointmentType = (CodeableConcept)AppointmentType.DeepCopy();
                if (Schedule != null) dest.Schedule = (ResourceReference)Schedule.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<SlotStatus>)StatusElement.DeepCopy();
                if (StartElement != null) dest.StartElement = (Instant)StartElement.DeepCopy();
                if (EndElement != null) dest.EndElement = (Instant)EndElement.DeepCopy();
                if (OverbookedElement != null) dest.OverbookedElement = (FhirBoolean)OverbookedElement.DeepCopy();
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Slot());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Slot;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(ServiceCategory, otherT.ServiceCategory)) return false;
            if ( !DeepComparable.Matches(ServiceType, otherT.ServiceType)) return false;
            if ( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.Matches(AppointmentType, otherT.AppointmentType)) return false;
            if (!DeepComparable.Matches(Schedule, otherT.Schedule)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.Matches(EndElement, otherT.EndElement)) return false;
            if (!DeepComparable.Matches(OverbookedElement, otherT.OverbookedElement)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Slot;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ServiceCategory, otherT.ServiceCategory)) return false;
            if (!DeepComparable.IsExactly(ServiceType, otherT.ServiceType)) return false;
            if (!DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.IsExactly(AppointmentType, otherT.AppointmentType)) return false;
            if (!DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;
            if (!DeepComparable.IsExactly(OverbookedElement, otherT.OverbookedElement)) return false;
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
                foreach (var elem in ServiceCategory) { if (elem != null) yield return elem; }
                foreach (var elem in ServiceType) { if (elem != null) yield return elem; }
                foreach (var elem in Specialty) { if (elem != null) yield return elem; }
                if (AppointmentType != null) yield return AppointmentType;
                if (Schedule != null) yield return Schedule;
                if (StatusElement != null) yield return StatusElement;
                if (StartElement != null) yield return StartElement;
                if (EndElement != null) yield return EndElement;
                if (OverbookedElement != null) yield return OverbookedElement;
                if (CommentElement != null) yield return CommentElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                foreach (var elem in ServiceCategory) { if (elem != null) yield return new ElementValue("serviceCategory", true, elem); }
                foreach (var elem in ServiceType) { if (elem != null) yield return new ElementValue("serviceType", true, elem); }
                foreach (var elem in Specialty) { if (elem != null) yield return new ElementValue("specialty", true, elem); }
                if (AppointmentType != null) yield return new ElementValue("appointmentType", false, AppointmentType);
                if (Schedule != null) yield return new ElementValue("schedule", false, Schedule);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (StartElement != null) yield return new ElementValue("start", false, StartElement);
                if (EndElement != null) yield return new ElementValue("end", false, EndElement);
                if (OverbookedElement != null) yield return new ElementValue("overbooked", false, OverbookedElement);
                if (CommentElement != null) yield return new ElementValue("comment", false, CommentElement);
            }
        }

    }

}
