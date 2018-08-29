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
    /// Roles/organizations the practitioner is associated with
    /// </summary>
    [FhirType("PractitionerRole", IsResource=true)]
    [DataContract]
    public partial class PractitionerRole : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.PractitionerRole; } }
        [NotMapped]
        public override string TypeName { get { return "PractitionerRole"; } }


        [FhirType("AvailableTimeComponent")]
        [DataContract]
        public partial class AvailableTimeComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AvailableTimeComponent"; } }

            /// <summary>
            /// mon | tue | wed | thu | fri | sat | sun
            /// </summary>
            [FhirElement("daysOfWeek", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<DaysOfWeek>> DaysOfWeekElement
            {
                get { if (_daysOfWeekElement==null) _daysOfWeekElement = new List<Code<DaysOfWeek>>(); return _daysOfWeekElement; }
                set { _daysOfWeekElement = value; OnPropertyChanged("DaysOfWeekElement"); }
            }

            private List<Code<DaysOfWeek>> _daysOfWeekElement;

            /// <summary>
            /// mon | tue | wed | thu | fri | sat | sun
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<DaysOfWeek?> DaysOfWeek
            {
                get { return DaysOfWeekElement != null ? DaysOfWeekElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        DaysOfWeekElement = null;
                    else
                        DaysOfWeekElement = new List<Code<DaysOfWeek>>(value.Select(elem=>new Code<DaysOfWeek>(elem)));
                    OnPropertyChanged("DaysOfWeek");
                }
            }

            /// <summary>
            /// Always available? e.g. 24 hour service
            /// </summary>
            [FhirElement("allDay", Order=50)]
            [DataMember]
            public FhirBoolean AllDayElement
            {
                get { return _allDayElement; }
                set { _allDayElement = value; OnPropertyChanged("AllDayElement"); }
            }

            private FhirBoolean _allDayElement;

            /// <summary>
            /// Always available? e.g. 24 hour service
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? AllDay
            {
                get { return AllDayElement != null ? AllDayElement.Value : null; }
                set
                {
                    if (value == null)
                        AllDayElement = null;
                    else
                        AllDayElement = new FhirBoolean(value);
                    OnPropertyChanged("AllDay");
                }
            }

            /// <summary>
            /// Opening time of day (ignored if allDay = true)
            /// </summary>
            [FhirElement("availableStartTime", Order=60)]
            [DataMember]
            public Time AvailableStartTimeElement
            {
                get { return _availableStartTimeElement; }
                set { _availableStartTimeElement = value; OnPropertyChanged("AvailableStartTimeElement"); }
            }

            private Time _availableStartTimeElement;

            /// <summary>
            /// Opening time of day (ignored if allDay = true)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string AvailableStartTime
            {
                get { return AvailableStartTimeElement != null ? AvailableStartTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        AvailableStartTimeElement = null;
                    else
                        AvailableStartTimeElement = new Time(value);
                    OnPropertyChanged("AvailableStartTime");
                }
            }

            /// <summary>
            /// Closing time of day (ignored if allDay = true)
            /// </summary>
            [FhirElement("availableEndTime", Order=70)]
            [DataMember]
            public Time AvailableEndTimeElement
            {
                get { return _availableEndTimeElement; }
                set { _availableEndTimeElement = value; OnPropertyChanged("AvailableEndTimeElement"); }
            }

            private Time _availableEndTimeElement;

            /// <summary>
            /// Closing time of day (ignored if allDay = true)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string AvailableEndTime
            {
                get { return AvailableEndTimeElement != null ? AvailableEndTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        AvailableEndTimeElement = null;
                    else
                        AvailableEndTimeElement = new Time(value);
                    OnPropertyChanged("AvailableEndTime");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AvailableTimeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DaysOfWeekElement != null) dest.DaysOfWeekElement = new List<Code<DaysOfWeek>>(DaysOfWeekElement.DeepCopy());
                    if (AllDayElement != null) dest.AllDayElement = (FhirBoolean)AllDayElement.DeepCopy();
                    if (AvailableStartTimeElement != null) dest.AvailableStartTimeElement = (Time)AvailableStartTimeElement.DeepCopy();
                    if (AvailableEndTimeElement != null) dest.AvailableEndTimeElement = (Time)AvailableEndTimeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AvailableTimeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AvailableTimeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(DaysOfWeekElement, otherT.DaysOfWeekElement)) return false;
                if (!DeepComparable.Matches(AllDayElement, otherT.AllDayElement)) return false;
                if (!DeepComparable.Matches(AvailableStartTimeElement, otherT.AvailableStartTimeElement)) return false;
                if (!DeepComparable.Matches(AvailableEndTimeElement, otherT.AvailableEndTimeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AvailableTimeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DaysOfWeekElement, otherT.DaysOfWeekElement)) return false;
                if (!DeepComparable.IsExactly(AllDayElement, otherT.AllDayElement)) return false;
                if (!DeepComparable.IsExactly(AvailableStartTimeElement, otherT.AvailableStartTimeElement)) return false;
                if (!DeepComparable.IsExactly(AvailableEndTimeElement, otherT.AvailableEndTimeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in DaysOfWeekElement) { if (elem != null) yield return elem; }
                    if (AllDayElement != null) yield return AllDayElement;
                    if (AvailableStartTimeElement != null) yield return AvailableStartTimeElement;
                    if (AvailableEndTimeElement != null) yield return AvailableEndTimeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in DaysOfWeekElement) { if (elem != null) yield return new ElementValue("daysOfWeek", elem); }
                    if (AllDayElement != null) yield return new ElementValue("allDay", AllDayElement);
                    if (AvailableStartTimeElement != null) yield return new ElementValue("availableStartTime", AvailableStartTimeElement);
                    if (AvailableEndTimeElement != null) yield return new ElementValue("availableEndTime", AvailableEndTimeElement);
                }
            }


        }


        [FhirType("NotAvailableComponent")]
        [DataContract]
        public partial class NotAvailableComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "NotAvailableComponent"; } }

            /// <summary>
            /// Reason presented to the user explaining why time not available
            /// </summary>
            [FhirElement("description", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Reason presented to the user explaining why time not available
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
            /// Service not availablefrom this date
            /// </summary>
            [FhirElement("during", Order=50)]
            [DataMember]
            public Period During
            {
                get { return _during; }
                set { _during = value; OnPropertyChanged("During"); }
            }

            private Period _during;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NotAvailableComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (During != null) dest.During = (Period)During.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new NotAvailableComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NotAvailableComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(During, otherT.During)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NotAvailableComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(During, otherT.During)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (During != null) yield return During;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (During != null) yield return new ElementValue("during", During);
                }
            }


        }


        /// <summary>
        /// Business Identifiers that are specific to a role/location
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
        /// Whether this practitioner's record is in active use
        /// </summary>
        [FhirElement("active", InSummary=true, Order=100)]
        [DataMember]
        public FhirBoolean ActiveElement
        {
            get { return _activeElement; }
            set { _activeElement = value; OnPropertyChanged("ActiveElement"); }
        }

        private FhirBoolean _activeElement;

        /// <summary>
        /// Whether this practitioner's record is in active use
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveElement = null;
                else
                    ActiveElement = new FhirBoolean(value);
                OnPropertyChanged("Active");
            }
        }

        /// <summary>
        /// The period during which the practitioner is authorized to perform in these role(s)
        /// </summary>
        [FhirElement("period", InSummary=true, Order=110)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Practitioner that is able to provide the defined services for the organation
        /// </summary>
        [FhirElement("practitioner", InSummary=true, Order=120)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Practitioner
        {
            get { return _practitioner; }
            set { _practitioner = value; OnPropertyChanged("Practitioner"); }
        }

        private ResourceReference _practitioner;

        /// <summary>
        /// Organization where the roles are available
        /// </summary>
        [FhirElement("organization", InSummary=true, Order=130)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private ResourceReference _organization;

        /// <summary>
        /// Roles which this practitioner may perform
        /// </summary>
        [FhirElement("code", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Code
        {
            get { if (_code==null) _code = new List<CodeableConcept>(); return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private List<CodeableConcept> _code;

        /// <summary>
        /// Specific specialty of the practitioner
        /// </summary>
        [FhirElement("specialty", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Specialty
        {
            get { if (_specialty==null) _specialty = new List<CodeableConcept>(); return _specialty; }
            set { _specialty = value; OnPropertyChanged("Specialty"); }
        }

        private List<CodeableConcept> _specialty;

        /// <summary>
        /// The location(s) at which this practitioner provides care
        /// </summary>
        [FhirElement("location", InSummary=true, Order=160)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Location
        {
            get { if (_location==null) _location = new List<ResourceReference>(); return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private List<ResourceReference> _location;

        /// <summary>
        /// The list of healthcare services that this worker provides for this role's Organization/Location(s)
        /// </summary>
        [FhirElement("healthcareService", Order=170)]
        [References("HealthcareService")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> HealthcareService
        {
            get { if (_healthcareService==null) _healthcareService = new List<ResourceReference>(); return _healthcareService; }
            set { _healthcareService = value; OnPropertyChanged("HealthcareService"); }
        }

        private List<ResourceReference> _healthcareService;

        /// <summary>
        /// Contact details that are specific to the role/location/service
        /// </summary>
        [FhirElement("telecom", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Telecom
        {
            get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
            set { _telecom = value; OnPropertyChanged("Telecom"); }
        }

        private List<ContactPoint> _telecom;

        /// <summary>
        /// Times the Service Site is available
        /// </summary>
        [FhirElement("availableTime", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AvailableTimeComponent> AvailableTime
        {
            get { if (_availableTime==null) _availableTime = new List<AvailableTimeComponent>(); return _availableTime; }
            set { _availableTime = value; OnPropertyChanged("AvailableTime"); }
        }

        private List<AvailableTimeComponent> _availableTime;

        /// <summary>
        /// Not available during this time due to provided reason
        /// </summary>
        [FhirElement("notAvailable", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<NotAvailableComponent> NotAvailable
        {
            get { if (_notAvailable==null) _notAvailable = new List<NotAvailableComponent>(); return _notAvailable; }
            set { _notAvailable = value; OnPropertyChanged("NotAvailable"); }
        }

        private List<NotAvailableComponent> _notAvailable;

        /// <summary>
        /// Description of availability exceptions
        /// </summary>
        [FhirElement("availabilityExceptions", Order=210)]
        [DataMember]
        public FhirString AvailabilityExceptionsElement
        {
            get { return _availabilityExceptionsElement; }
            set { _availabilityExceptionsElement = value; OnPropertyChanged("AvailabilityExceptionsElement"); }
        }

        private FhirString _availabilityExceptionsElement;

        /// <summary>
        /// Description of availability exceptions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string AvailabilityExceptions
        {
            get { return AvailabilityExceptionsElement != null ? AvailabilityExceptionsElement.Value : null; }
            set
            {
                if (value == null)
                    AvailabilityExceptionsElement = null;
                else
                    AvailabilityExceptionsElement = new FhirString(value);
                OnPropertyChanged("AvailabilityExceptions");
            }
        }

        /// <summary>
        /// Technical endpoints providing access to services operated for the practitioner with this role
        /// </summary>
        [FhirElement("endpoint", Order=220)]
        [References("Endpoint")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Endpoint
        {
            get { if (_endpoint==null) _endpoint = new List<ResourceReference>(); return _endpoint; }
            set { _endpoint = value; OnPropertyChanged("Endpoint"); }
        }

        private List<ResourceReference> _endpoint;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as PractitionerRole;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Practitioner != null) dest.Practitioner = (ResourceReference)Practitioner.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (Code != null) dest.Code = new List<CodeableConcept>(Code.DeepCopy());
                if (Specialty != null) dest.Specialty = new List<CodeableConcept>(Specialty.DeepCopy());
                if (Location != null) dest.Location = new List<ResourceReference>(Location.DeepCopy());
                if (HealthcareService != null) dest.HealthcareService = new List<ResourceReference>(HealthcareService.DeepCopy());
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (AvailableTime != null) dest.AvailableTime = new List<AvailableTimeComponent>(AvailableTime.DeepCopy());
                if (NotAvailable != null) dest.NotAvailable = new List<NotAvailableComponent>(NotAvailable.DeepCopy());
                if (AvailabilityExceptionsElement != null) dest.AvailabilityExceptionsElement = (FhirString)AvailabilityExceptionsElement.DeepCopy();
                if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new PractitionerRole());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as PractitionerRole;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(Practitioner, otherT.Practitioner)) return false;
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if ( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
            if ( !DeepComparable.Matches(Location, otherT.Location)) return false;
            if ( !DeepComparable.Matches(HealthcareService, otherT.HealthcareService)) return false;
            if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if ( !DeepComparable.Matches(AvailableTime, otherT.AvailableTime)) return false;
            if ( !DeepComparable.Matches(NotAvailable, otherT.NotAvailable)) return false;
            if (!DeepComparable.Matches(AvailabilityExceptionsElement, otherT.AvailabilityExceptionsElement)) return false;
            if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as PractitionerRole;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Practitioner, otherT.Practitioner)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(HealthcareService, otherT.HealthcareService)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(AvailableTime, otherT.AvailableTime)) return false;
            if (!DeepComparable.IsExactly(NotAvailable, otherT.NotAvailable)) return false;
            if (!DeepComparable.IsExactly(AvailabilityExceptionsElement, otherT.AvailabilityExceptionsElement)) return false;
            if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (ActiveElement != null) yield return ActiveElement;
                if (Period != null) yield return Period;
                if (Practitioner != null) yield return Practitioner;
                if (Organization != null) yield return Organization;
                foreach (var elem in Code) { if (elem != null) yield return elem; }
                foreach (var elem in Specialty) { if (elem != null) yield return elem; }
                foreach (var elem in Location) { if (elem != null) yield return elem; }
                foreach (var elem in HealthcareService) { if (elem != null) yield return elem; }
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                foreach (var elem in AvailableTime) { if (elem != null) yield return elem; }
                foreach (var elem in NotAvailable) { if (elem != null) yield return elem; }
                if (AvailabilityExceptionsElement != null) yield return AvailabilityExceptionsElement;
                foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
                if (Period != null) yield return new ElementValue("period", Period);
                if (Practitioner != null) yield return new ElementValue("practitioner", Practitioner);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                foreach (var elem in Specialty) { if (elem != null) yield return new ElementValue("specialty", elem); }
                foreach (var elem in Location) { if (elem != null) yield return new ElementValue("location", elem); }
                foreach (var elem in HealthcareService) { if (elem != null) yield return new ElementValue("healthcareService", elem); }
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                foreach (var elem in AvailableTime) { if (elem != null) yield return new ElementValue("availableTime", elem); }
                foreach (var elem in NotAvailable) { if (elem != null) yield return new ElementValue("notAvailable", elem); }
                if (AvailabilityExceptionsElement != null) yield return new ElementValue("availabilityExceptions", AvailabilityExceptionsElement);
                foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
            }
        }

    }

}
