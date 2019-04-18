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
    /// The details of a healthcare service available at a location
    /// </summary>
    [FhirType("HealthcareService", IsResource = true)]
    [DataContract]
    public partial class HealthcareService : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.HealthcareService; } }
        [NotMapped]
        public override string TypeName { get { return "HealthcareService"; } }

        /// <summary>
        /// The days of the week.
        /// (url: http://hl7.org/fhir/ValueSet/days-of-week)
        /// </summary>
        [FhirEnumeration("DaysOfWeek")]
        public enum DaysOfWeek
        {
            /// <summary>
            /// Monday
            /// (system: http://hl7.org/fhir/days-of-week)
            /// </summary>
            [EnumLiteral("mon", "http://hl7.org/fhir/days-of-week"), Description("Monday")]
            Mon,
            /// <summary>
            /// Tuesday
            /// (system: http://hl7.org/fhir/days-of-week)
            /// </summary>
            [EnumLiteral("tue", "http://hl7.org/fhir/days-of-week"), Description("Tuesday")]
            Tue,
            /// <summary>
            /// Wednesday
            /// (system: http://hl7.org/fhir/days-of-week)
            /// </summary>
            [EnumLiteral("wed", "http://hl7.org/fhir/days-of-week"), Description("Wednesday")]
            Wed,
            /// <summary>
            /// Thursday
            /// (system: http://hl7.org/fhir/days-of-week)
            /// </summary>
            [EnumLiteral("thu", "http://hl7.org/fhir/days-of-week"), Description("Thursday")]
            Thu,
            /// <summary>
            /// Friday
            /// (system: http://hl7.org/fhir/days-of-week)
            /// </summary>
            [EnumLiteral("fri", "http://hl7.org/fhir/days-of-week"), Description("Friday")]
            Fri,
            /// <summary>
            /// Saturday
            /// (system: http://hl7.org/fhir/days-of-week)
            /// </summary>
            [EnumLiteral("sat", "http://hl7.org/fhir/days-of-week"), Description("Saturday")]
            Sat,
            /// <summary>
            /// Sunday
            /// (system: http://hl7.org/fhir/days-of-week)
            /// </summary>
            [EnumLiteral("sun", "http://hl7.org/fhir/days-of-week"), Description("Sunday")]
            Sun,
        }


        [FhirType("ServiceTypeComponent")]
        [DataContract]
        public partial class ServiceTypeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ServiceTypeComponent"; } }

            /// <summary>
            /// Type of service delivered or performed
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Specialties handled by the Service Site
            /// </summary>
            [FhirElement("specialty", InSummary = true, Order = 50)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<CodeableConcept> Specialty
            {
                get { if (_specialty == null) _specialty = new List<CodeableConcept>(); return _specialty; }
                set { _specialty = value; OnPropertyChanged("Specialty"); }
            }

            private List<CodeableConcept> _specialty;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ServiceTypeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Specialty != null) dest.Specialty = new List<CodeableConcept>(Specialty.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ServiceTypeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ServiceTypeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Specialty, otherT.Specialty)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ServiceTypeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Specialty) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Specialty) { if (elem != null) yield return new ElementValue("specialty", elem); }
                }
            }


        }


        [FhirType("AvailableTimeComponent")]
        [DataContract]
        public partial class AvailableTimeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AvailableTimeComponent"; } }

            /// <summary>
            /// mon | tue | wed | thu | fri | sat | sun
            /// </summary>
            [FhirElement("daysOfWeek", Order = 40)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<Code<DaysOfWeek>> DaysOfWeekElement
            {
                get { if (_daysOfWeekElement == null) _daysOfWeekElement = new List<Code<DaysOfWeek>>(); return _daysOfWeekElement; }
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
                        DaysOfWeekElement = new List<Code<DaysOfWeek>>(value.Select(elem => new Code<DaysOfWeek>(elem)));
                    OnPropertyChanged("DaysOfWeek");
                }
            }

            /// <summary>
            /// Always available? e.g. 24 hour service
            /// </summary>
            [FhirElement("allDay", Order = 50)]
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
                    if (!value.HasValue)
                        AllDayElement = null;
                    else
                        AllDayElement = new FhirBoolean(value);
                    OnPropertyChanged("AllDay");
                }
            }

            /// <summary>
            /// Opening time of day (ignored if allDay = true)
            /// </summary>
            [FhirElement("availableStartTime", Order = 60)]
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
            [FhirElement("availableEndTime", Order = 70)]
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
                if (!DeepComparable.Matches(DaysOfWeekElement, otherT.DaysOfWeekElement)) return false;
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
        public partial class NotAvailableComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "NotAvailableComponent"; } }

            /// <summary>
            /// Reason presented to the user explaining why time not available
            /// </summary>
            [FhirElement("description", Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
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
            [FhirElement("during", Order = 50)]
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
        /// External identifiers for this item
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
        /// Organization that provides this service
        /// </summary>
        [FhirElement("providedBy", InSummary = true, Order = 100)]
        [References("Organization")]
        [DataMember]
        public ResourceReference ProvidedBy
        {
            get { return _providedBy; }
            set { _providedBy = value; OnPropertyChanged("ProvidedBy"); }
        }

        private ResourceReference _providedBy;

        /// <summary>
        /// Broad category of service being performed or delivered
        /// </summary>
        [FhirElement("serviceCategory", InSummary = true, Order = 110)]
        [DataMember]
        public CodeableConcept ServiceCategory
        {
            get { return _serviceCategory; }
            set { _serviceCategory = value; OnPropertyChanged("ServiceCategory"); }
        }

        private CodeableConcept _serviceCategory;

        /// <summary>
        /// Specific service delivered or performed
        /// </summary>
        [FhirElement("serviceType", InSummary = true, Order = 120)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ServiceTypeComponent> ServiceType
        {
            get { if (_serviceType == null) _serviceType = new List<ServiceTypeComponent>(); return _serviceType; }
            set { _serviceType = value; OnPropertyChanged("ServiceType"); }
        }

        private List<ServiceTypeComponent> _serviceType;

        /// <summary>
        /// Location where service may be provided
        /// </summary>
        [FhirElement("location", InSummary = true, Order = 130)]
        [References("Location")]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Description of service as presented to a consumer while searching
        /// </summary>
        [FhirElement("serviceName", InSummary = true, Order = 140)]
        [DataMember]
        public FhirString ServiceNameElement
        {
            get { return _serviceNameElement; }
            set { _serviceNameElement = value; OnPropertyChanged("ServiceNameElement"); }
        }

        private FhirString _serviceNameElement;

        /// <summary>
        /// Description of service as presented to a consumer while searching
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ServiceName
        {
            get { return ServiceNameElement != null ? ServiceNameElement.Value : null; }
            set
            {
                if (value == null)
                    ServiceNameElement = null;
                else
                    ServiceNameElement = new FhirString(value);
                OnPropertyChanged("ServiceName");
            }
        }

        /// <summary>
        /// Additional description and/or any specific issues not covered elsewhere
        /// </summary>
        [FhirElement("comment", InSummary = true, Order = 150)]
        [DataMember]
        public FhirString CommentElement
        {
            get { return _commentElement; }
            set { _commentElement = value; OnPropertyChanged("CommentElement"); }
        }

        private FhirString _commentElement;

        /// <summary>
        /// Additional description and/or any specific issues not covered elsewhere
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
        /// Extra details about the service that can't be placed in the other fields
        /// </summary>
        [FhirElement("extraDetails", Order = 160)]
        [DataMember]
        public FhirString ExtraDetailsElement
        {
            get { return _extraDetailsElement; }
            set { _extraDetailsElement = value; OnPropertyChanged("ExtraDetailsElement"); }
        }

        private FhirString _extraDetailsElement;

        /// <summary>
        /// Extra details about the service that can't be placed in the other fields
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ExtraDetails
        {
            get { return ExtraDetailsElement != null ? ExtraDetailsElement.Value : null; }
            set
            {
                if (value == null)
                    ExtraDetailsElement = null;
                else
                    ExtraDetailsElement = new FhirString(value);
                OnPropertyChanged("ExtraDetails");
            }
        }

        /// <summary>
        /// Facilitates quick identification of the service
        /// </summary>
        [FhirElement("photo", InSummary = true, Order = 170)]
        [DataMember]
        public Attachment Photo
        {
            get { return _photo; }
            set { _photo = value; OnPropertyChanged("Photo"); }
        }

        private Attachment _photo;

        /// <summary>
        /// Contacts related to the healthcare service
        /// </summary>
        [FhirElement("telecom", Order = 180)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ContactPoint> Telecom
        {
            get { if (_telecom == null) _telecom = new List<ContactPoint>(); return _telecom; }
            set { _telecom = value; OnPropertyChanged("Telecom"); }
        }

        private List<ContactPoint> _telecom;

        /// <summary>
        /// Location(s) service is inteded for/available to
        /// </summary>
        [FhirElement("coverageArea", Order = 190)]
        [References("Location")]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ResourceReference> CoverageArea
        {
            get { if (_coverageArea == null) _coverageArea = new List<ResourceReference>(); return _coverageArea; }
            set { _coverageArea = value; OnPropertyChanged("CoverageArea"); }
        }

        private List<ResourceReference> _coverageArea;

        /// <summary>
        /// Conditions under which service is available/offered
        /// </summary>
        [FhirElement("serviceProvisionCode", Order = 200)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> ServiceProvisionCode
        {
            get { if (_serviceProvisionCode == null) _serviceProvisionCode = new List<CodeableConcept>(); return _serviceProvisionCode; }
            set { _serviceProvisionCode = value; OnPropertyChanged("ServiceProvisionCode"); }
        }

        private List<CodeableConcept> _serviceProvisionCode;

        /// <summary>
        /// Specific eligibility requirements required to use the service
        /// </summary>
        [FhirElement("eligibility", Order = 210)]
        [DataMember]
        public CodeableConcept Eligibility
        {
            get { return _eligibility; }
            set { _eligibility = value; OnPropertyChanged("Eligibility"); }
        }

        private CodeableConcept _eligibility;

        /// <summary>
        /// Describes the eligibility conditions for the service
        /// </summary>
        [FhirElement("eligibilityNote", Order = 220)]
        [DataMember]
        public FhirString EligibilityNoteElement
        {
            get { return _eligibilityNoteElement; }
            set { _eligibilityNoteElement = value; OnPropertyChanged("EligibilityNoteElement"); }
        }

        private FhirString _eligibilityNoteElement;

        /// <summary>
        /// Describes the eligibility conditions for the service
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string EligibilityNote
        {
            get { return EligibilityNoteElement != null ? EligibilityNoteElement.Value : null; }
            set
            {
                if (value == null)
                    EligibilityNoteElement = null;
                else
                    EligibilityNoteElement = new FhirString(value);
                OnPropertyChanged("EligibilityNote");
            }
        }

        /// <summary>
        /// Program Names that categorize the service
        /// </summary>
        [FhirElement("programName", Order = 230)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<FhirString> ProgramNameElement
        {
            get { if (_programNameElement == null) _programNameElement = new List<FhirString>(); return _programNameElement; }
            set { _programNameElement = value; OnPropertyChanged("ProgramNameElement"); }
        }

        private List<FhirString> _programNameElement;

        /// <summary>
        /// Program Names that categorize the service
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> ProgramName
        {
            get { return ProgramNameElement != null ? ProgramNameElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ProgramNameElement = null;
                else
                    ProgramNameElement = new List<FhirString>(value.Select(elem => new FhirString(elem)));
                OnPropertyChanged("ProgramName");
            }
        }

        /// <summary>
        /// Collection of characteristics (attributes)
        /// </summary>
        [FhirElement("characteristic", Order = 240)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> Characteristic
        {
            get { if (_characteristic == null) _characteristic = new List<CodeableConcept>(); return _characteristic; }
            set { _characteristic = value; OnPropertyChanged("Characteristic"); }
        }

        private List<CodeableConcept> _characteristic;

        /// <summary>
        /// Ways that the service accepts referrals
        /// </summary>
        [FhirElement("referralMethod", Order = 250)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> ReferralMethod
        {
            get { if (_referralMethod == null) _referralMethod = new List<CodeableConcept>(); return _referralMethod; }
            set { _referralMethod = value; OnPropertyChanged("ReferralMethod"); }
        }

        private List<CodeableConcept> _referralMethod;

        /// <summary>
        /// PKI Public keys to support secure communications
        /// </summary>
        [FhirElement("publicKey", Order = 260)]
        [DataMember]
        public FhirString PublicKeyElement
        {
            get { return _publicKeyElement; }
            set { _publicKeyElement = value; OnPropertyChanged("PublicKeyElement"); }
        }

        private FhirString _publicKeyElement;

        /// <summary>
        /// PKI Public keys to support secure communications
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PublicKey
        {
            get { return PublicKeyElement != null ? PublicKeyElement.Value : null; }
            set
            {
                if (value == null)
                    PublicKeyElement = null;
                else
                    PublicKeyElement = new FhirString(value);
                OnPropertyChanged("PublicKey");
            }
        }

        /// <summary>
        /// If an appointment is required for access to this service
        /// </summary>
        [FhirElement("appointmentRequired", Order = 270)]
        [DataMember]
        public FhirBoolean AppointmentRequiredElement
        {
            get { return _appointmentRequiredElement; }
            set { _appointmentRequiredElement = value; OnPropertyChanged("AppointmentRequiredElement"); }
        }

        private FhirBoolean _appointmentRequiredElement;

        /// <summary>
        /// If an appointment is required for access to this service
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? AppointmentRequired
        {
            get { return AppointmentRequiredElement != null ? AppointmentRequiredElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    AppointmentRequiredElement = null;
                else
                    AppointmentRequiredElement = new FhirBoolean(value);
                OnPropertyChanged("AppointmentRequired");
            }
        }

        /// <summary>
        /// Times the Service Site is available
        /// </summary>
        [FhirElement("availableTime", Order = 280)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<AvailableTimeComponent> AvailableTime
        {
            get { if (_availableTime == null) _availableTime = new List<AvailableTimeComponent>(); return _availableTime; }
            set { _availableTime = value; OnPropertyChanged("AvailableTime"); }
        }

        private List<AvailableTimeComponent> _availableTime;

        /// <summary>
        /// Not available during this time due to provided reason
        /// </summary>
        [FhirElement("notAvailable", Order = 290)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<NotAvailableComponent> NotAvailable
        {
            get { if (_notAvailable == null) _notAvailable = new List<NotAvailableComponent>(); return _notAvailable; }
            set { _notAvailable = value; OnPropertyChanged("NotAvailable"); }
        }

        private List<NotAvailableComponent> _notAvailable;

        /// <summary>
        /// Description of availability exceptions
        /// </summary>
        [FhirElement("availabilityExceptions", Order = 300)]
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


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as HealthcareService;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ProvidedBy != null) dest.ProvidedBy = (ResourceReference)ProvidedBy.DeepCopy();
                if (ServiceCategory != null) dest.ServiceCategory = (CodeableConcept)ServiceCategory.DeepCopy();
                if (ServiceType != null) dest.ServiceType = new List<ServiceTypeComponent>(ServiceType.DeepCopy());
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (ServiceNameElement != null) dest.ServiceNameElement = (FhirString)ServiceNameElement.DeepCopy();
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                if (ExtraDetailsElement != null) dest.ExtraDetailsElement = (FhirString)ExtraDetailsElement.DeepCopy();
                if (Photo != null) dest.Photo = (Attachment)Photo.DeepCopy();
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (CoverageArea != null) dest.CoverageArea = new List<ResourceReference>(CoverageArea.DeepCopy());
                if (ServiceProvisionCode != null) dest.ServiceProvisionCode = new List<CodeableConcept>(ServiceProvisionCode.DeepCopy());
                if (Eligibility != null) dest.Eligibility = (CodeableConcept)Eligibility.DeepCopy();
                if (EligibilityNoteElement != null) dest.EligibilityNoteElement = (FhirString)EligibilityNoteElement.DeepCopy();
                if (ProgramNameElement != null) dest.ProgramNameElement = new List<FhirString>(ProgramNameElement.DeepCopy());
                if (Characteristic != null) dest.Characteristic = new List<CodeableConcept>(Characteristic.DeepCopy());
                if (ReferralMethod != null) dest.ReferralMethod = new List<CodeableConcept>(ReferralMethod.DeepCopy());
                if (PublicKeyElement != null) dest.PublicKeyElement = (FhirString)PublicKeyElement.DeepCopy();
                if (AppointmentRequiredElement != null) dest.AppointmentRequiredElement = (FhirBoolean)AppointmentRequiredElement.DeepCopy();
                if (AvailableTime != null) dest.AvailableTime = new List<AvailableTimeComponent>(AvailableTime.DeepCopy());
                if (NotAvailable != null) dest.NotAvailable = new List<NotAvailableComponent>(NotAvailable.DeepCopy());
                if (AvailabilityExceptionsElement != null) dest.AvailabilityExceptionsElement = (FhirString)AvailabilityExceptionsElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new HealthcareService());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as HealthcareService;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ProvidedBy, otherT.ProvidedBy)) return false;
            if (!DeepComparable.Matches(ServiceCategory, otherT.ServiceCategory)) return false;
            if (!DeepComparable.Matches(ServiceType, otherT.ServiceType)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(ServiceNameElement, otherT.ServiceNameElement)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.Matches(ExtraDetailsElement, otherT.ExtraDetailsElement)) return false;
            if (!DeepComparable.Matches(Photo, otherT.Photo)) return false;
            if (!DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.Matches(CoverageArea, otherT.CoverageArea)) return false;
            if (!DeepComparable.Matches(ServiceProvisionCode, otherT.ServiceProvisionCode)) return false;
            if (!DeepComparable.Matches(Eligibility, otherT.Eligibility)) return false;
            if (!DeepComparable.Matches(EligibilityNoteElement, otherT.EligibilityNoteElement)) return false;
            if (!DeepComparable.Matches(ProgramNameElement, otherT.ProgramNameElement)) return false;
            if (!DeepComparable.Matches(Characteristic, otherT.Characteristic)) return false;
            if (!DeepComparable.Matches(ReferralMethod, otherT.ReferralMethod)) return false;
            if (!DeepComparable.Matches(PublicKeyElement, otherT.PublicKeyElement)) return false;
            if (!DeepComparable.Matches(AppointmentRequiredElement, otherT.AppointmentRequiredElement)) return false;
            if (!DeepComparable.Matches(AvailableTime, otherT.AvailableTime)) return false;
            if (!DeepComparable.Matches(NotAvailable, otherT.NotAvailable)) return false;
            if (!DeepComparable.Matches(AvailabilityExceptionsElement, otherT.AvailabilityExceptionsElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as HealthcareService;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ProvidedBy, otherT.ProvidedBy)) return false;
            if (!DeepComparable.IsExactly(ServiceCategory, otherT.ServiceCategory)) return false;
            if (!DeepComparable.IsExactly(ServiceType, otherT.ServiceType)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(ServiceNameElement, otherT.ServiceNameElement)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.IsExactly(ExtraDetailsElement, otherT.ExtraDetailsElement)) return false;
            if (!DeepComparable.IsExactly(Photo, otherT.Photo)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(CoverageArea, otherT.CoverageArea)) return false;
            if (!DeepComparable.IsExactly(ServiceProvisionCode, otherT.ServiceProvisionCode)) return false;
            if (!DeepComparable.IsExactly(Eligibility, otherT.Eligibility)) return false;
            if (!DeepComparable.IsExactly(EligibilityNoteElement, otherT.EligibilityNoteElement)) return false;
            if (!DeepComparable.IsExactly(ProgramNameElement, otherT.ProgramNameElement)) return false;
            if (!DeepComparable.IsExactly(Characteristic, otherT.Characteristic)) return false;
            if (!DeepComparable.IsExactly(ReferralMethod, otherT.ReferralMethod)) return false;
            if (!DeepComparable.IsExactly(PublicKeyElement, otherT.PublicKeyElement)) return false;
            if (!DeepComparable.IsExactly(AppointmentRequiredElement, otherT.AppointmentRequiredElement)) return false;
            if (!DeepComparable.IsExactly(AvailableTime, otherT.AvailableTime)) return false;
            if (!DeepComparable.IsExactly(NotAvailable, otherT.NotAvailable)) return false;
            if (!DeepComparable.IsExactly(AvailabilityExceptionsElement, otherT.AvailabilityExceptionsElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (ProvidedBy != null) yield return ProvidedBy;
                if (ServiceCategory != null) yield return ServiceCategory;
                foreach (var elem in ServiceType) { if (elem != null) yield return elem; }
                if (Location != null) yield return Location;
                if (ServiceNameElement != null) yield return ServiceNameElement;
                if (CommentElement != null) yield return CommentElement;
                if (ExtraDetailsElement != null) yield return ExtraDetailsElement;
                if (Photo != null) yield return Photo;
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                foreach (var elem in CoverageArea) { if (elem != null) yield return elem; }
                foreach (var elem in ServiceProvisionCode) { if (elem != null) yield return elem; }
                if (Eligibility != null) yield return Eligibility;
                if (EligibilityNoteElement != null) yield return EligibilityNoteElement;
                foreach (var elem in ProgramNameElement) { if (elem != null) yield return elem; }
                foreach (var elem in Characteristic) { if (elem != null) yield return elem; }
                foreach (var elem in ReferralMethod) { if (elem != null) yield return elem; }
                if (PublicKeyElement != null) yield return PublicKeyElement;
                if (AppointmentRequiredElement != null) yield return AppointmentRequiredElement;
                foreach (var elem in AvailableTime) { if (elem != null) yield return elem; }
                foreach (var elem in NotAvailable) { if (elem != null) yield return elem; }
                if (AvailabilityExceptionsElement != null) yield return AvailabilityExceptionsElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (ProvidedBy != null) yield return new ElementValue("providedBy", ProvidedBy);
                if (ServiceCategory != null) yield return new ElementValue("serviceCategory", ServiceCategory);
                foreach (var elem in ServiceType) { if (elem != null) yield return new ElementValue("serviceType", elem); }
                if (Location != null) yield return new ElementValue("location", Location);
                if (ServiceNameElement != null) yield return new ElementValue("serviceName", ServiceNameElement);
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                if (ExtraDetailsElement != null) yield return new ElementValue("extraDetails", ExtraDetailsElement);
                if (Photo != null) yield return new ElementValue("photo", Photo);
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                foreach (var elem in CoverageArea) { if (elem != null) yield return new ElementValue("coverageArea", elem); }
                foreach (var elem in ServiceProvisionCode) { if (elem != null) yield return new ElementValue("serviceProvisionCode", elem); }
                if (Eligibility != null) yield return new ElementValue("eligibility", Eligibility);
                if (EligibilityNoteElement != null) yield return new ElementValue("eligibilityNote", EligibilityNoteElement);
                foreach (var elem in ProgramNameElement) { if (elem != null) yield return new ElementValue("programName", elem); }
                foreach (var elem in Characteristic) { if (elem != null) yield return new ElementValue("characteristic", elem); }
                foreach (var elem in ReferralMethod) { if (elem != null) yield return new ElementValue("referralMethod", elem); }
                if (PublicKeyElement != null) yield return new ElementValue("publicKey", PublicKeyElement);
                if (AppointmentRequiredElement != null) yield return new ElementValue("appointmentRequired", AppointmentRequiredElement);
                foreach (var elem in AvailableTime) { if (elem != null) yield return new ElementValue("availableTime", elem); }
                foreach (var elem in NotAvailable) { if (elem != null) yield return new ElementValue("notAvailable", elem); }
                if (AvailabilityExceptionsElement != null) yield return new ElementValue("availabilityExceptions", AvailabilityExceptionsElement);
            }
        }

    }

}
