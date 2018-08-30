using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Details and position information for a physical place
    /// </summary>
    [FhirType("Location", IsResource=true)]
    [DataContract]
    public partial class Location : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Location; } }
        [NotMapped]
        public override string TypeName { get { return "Location"; } }

        /// <summary>
        /// Indicates whether the location is still in use.
        /// (url: http://hl7.org/fhir/ValueSet/location-status)
        /// </summary>
        [FhirEnumeration("LocationStatus")]
        public enum LocationStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/location-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/location-status"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/location-status)
            /// </summary>
            [EnumLiteral("suspended", "http://hl7.org/fhir/location-status"), Description("Suspended")]
            Suspended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/location-status)
            /// </summary>
            [EnumLiteral("inactive", "http://hl7.org/fhir/location-status"), Description("Inactive")]
            Inactive,
        }

        /// <summary>
        /// Indicates whether a resource instance represents a specific location or a class of locations.
        /// (url: http://hl7.org/fhir/ValueSet/location-mode)
        /// </summary>
        [FhirEnumeration("LocationMode")]
        public enum LocationMode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/location-mode)
            /// </summary>
            [EnumLiteral("instance", "http://hl7.org/fhir/location-mode"), Description("Instance")]
            Instance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/location-mode)
            /// </summary>
            [EnumLiteral("kind", "http://hl7.org/fhir/location-mode"), Description("Kind")]
            Kind,
        }


        [FhirType("PositionComponent")]
        [DataContract]
        public partial class PositionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PositionComponent"; } }

            /// <summary>
            /// Longitude with WGS84 datum
            /// </summary>
            [FhirElement("longitude", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirDecimal LongitudeElement
            {
                get { return _longitudeElement; }
                set { _longitudeElement = value; OnPropertyChanged("LongitudeElement"); }
            }

            private FhirDecimal _longitudeElement;

            /// <summary>
            /// Longitude with WGS84 datum
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Longitude
            {
                get { return LongitudeElement != null ? LongitudeElement.Value : null; }
                set
                {
                    if (value == null)
                        LongitudeElement = null;
                    else
                        LongitudeElement = new FhirDecimal(value);
                    OnPropertyChanged("Longitude");
                }
            }

            /// <summary>
            /// Latitude with WGS84 datum
            /// </summary>
            [FhirElement("latitude", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirDecimal LatitudeElement
            {
                get { return _latitudeElement; }
                set { _latitudeElement = value; OnPropertyChanged("LatitudeElement"); }
            }

            private FhirDecimal _latitudeElement;

            /// <summary>
            /// Latitude with WGS84 datum
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Latitude
            {
                get { return LatitudeElement != null ? LatitudeElement.Value : null; }
                set
                {
                    if (value == null)
                        LatitudeElement = null;
                    else
                        LatitudeElement = new FhirDecimal(value);
                    OnPropertyChanged("Latitude");
                }
            }

            /// <summary>
            /// Altitude with WGS84 datum
            /// </summary>
            [FhirElement("altitude", Order=60)]
            [DataMember]
            public FhirDecimal AltitudeElement
            {
                get { return _altitudeElement; }
                set { _altitudeElement = value; OnPropertyChanged("AltitudeElement"); }
            }

            private FhirDecimal _altitudeElement;

            /// <summary>
            /// Altitude with WGS84 datum
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Altitude
            {
                get { return AltitudeElement != null ? AltitudeElement.Value : null; }
                set
                {
                    if (value == null)
                        AltitudeElement = null;
                    else
                        AltitudeElement = new FhirDecimal(value);
                    OnPropertyChanged("Altitude");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PositionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LongitudeElement != null) dest.LongitudeElement = (FhirDecimal)LongitudeElement.DeepCopy();
                    if (LatitudeElement != null) dest.LatitudeElement = (FhirDecimal)LatitudeElement.DeepCopy();
                    if (AltitudeElement != null) dest.AltitudeElement = (FhirDecimal)AltitudeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PositionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PositionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LongitudeElement, otherT.LongitudeElement)) return false;
                if (!DeepComparable.Matches(LatitudeElement, otherT.LatitudeElement)) return false;
                if (!DeepComparable.Matches(AltitudeElement, otherT.AltitudeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PositionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LongitudeElement, otherT.LongitudeElement)) return false;
                if (!DeepComparable.IsExactly(LatitudeElement, otherT.LatitudeElement)) return false;
                if (!DeepComparable.IsExactly(AltitudeElement, otherT.AltitudeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LongitudeElement != null) yield return LongitudeElement;
                    if (LatitudeElement != null) yield return LatitudeElement;
                    if (AltitudeElement != null) yield return AltitudeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LongitudeElement != null) yield return new ElementValue("longitude", LongitudeElement);
                    if (LatitudeElement != null) yield return new ElementValue("latitude", LatitudeElement);
                    if (AltitudeElement != null) yield return new ElementValue("altitude", AltitudeElement);
                }
            }


        }


        [FhirType("HoursOfOperationComponent")]
        [DataContract]
        public partial class HoursOfOperationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "HoursOfOperationComponent"; } }

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
            /// The Location is open all day
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
            /// The Location is open all day
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
            /// Time that the Location opens
            /// </summary>
            [FhirElement("openingTime", Order=60)]
            [DataMember]
            public Time OpeningTimeElement
            {
                get { return _openingTimeElement; }
                set { _openingTimeElement = value; OnPropertyChanged("OpeningTimeElement"); }
            }

            private Time _openingTimeElement;

            /// <summary>
            /// Time that the Location opens
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string OpeningTime
            {
                get { return OpeningTimeElement != null ? OpeningTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        OpeningTimeElement = null;
                    else
                        OpeningTimeElement = new Time(value);
                    OnPropertyChanged("OpeningTime");
                }
            }

            /// <summary>
            /// Time that the Location closes
            /// </summary>
            [FhirElement("closingTime", Order=70)]
            [DataMember]
            public Time ClosingTimeElement
            {
                get { return _closingTimeElement; }
                set { _closingTimeElement = value; OnPropertyChanged("ClosingTimeElement"); }
            }

            private Time _closingTimeElement;

            /// <summary>
            /// Time that the Location closes
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ClosingTime
            {
                get { return ClosingTimeElement != null ? ClosingTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        ClosingTimeElement = null;
                    else
                        ClosingTimeElement = new Time(value);
                    OnPropertyChanged("ClosingTime");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as HoursOfOperationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DaysOfWeekElement != null) dest.DaysOfWeekElement = new List<Code<DaysOfWeek>>(DaysOfWeekElement.DeepCopy());
                    if (AllDayElement != null) dest.AllDayElement = (FhirBoolean)AllDayElement.DeepCopy();
                    if (OpeningTimeElement != null) dest.OpeningTimeElement = (Time)OpeningTimeElement.DeepCopy();
                    if (ClosingTimeElement != null) dest.ClosingTimeElement = (Time)ClosingTimeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new HoursOfOperationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as HoursOfOperationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(DaysOfWeekElement, otherT.DaysOfWeekElement)) return false;
                if (!DeepComparable.Matches(AllDayElement, otherT.AllDayElement)) return false;
                if (!DeepComparable.Matches(OpeningTimeElement, otherT.OpeningTimeElement)) return false;
                if (!DeepComparable.Matches(ClosingTimeElement, otherT.ClosingTimeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as HoursOfOperationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DaysOfWeekElement, otherT.DaysOfWeekElement)) return false;
                if (!DeepComparable.IsExactly(AllDayElement, otherT.AllDayElement)) return false;
                if (!DeepComparable.IsExactly(OpeningTimeElement, otherT.OpeningTimeElement)) return false;
                if (!DeepComparable.IsExactly(ClosingTimeElement, otherT.ClosingTimeElement)) return false;

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
                    if (OpeningTimeElement != null) yield return OpeningTimeElement;
                    if (ClosingTimeElement != null) yield return ClosingTimeElement;
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
                    if (OpeningTimeElement != null) yield return new ElementValue("openingTime", OpeningTimeElement);
                    if (ClosingTimeElement != null) yield return new ElementValue("closingTime", ClosingTimeElement);
                }
            }


        }


        /// <summary>
        /// Unique code or number identifying the location to its users
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
        /// active | suspended | inactive
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<LocationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<LocationStatus> _statusElement;

        /// <summary>
        /// active | suspended | inactive
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public LocationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<LocationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The Operational status of the location (typically only for a bed/room)
        /// </summary>
        [FhirElement("operationalStatus", InSummary=true, Order=110)]
        [DataMember]
        public Coding OperationalStatus
        {
            get { return _operationalStatus; }
            set { _operationalStatus = value; OnPropertyChanged("OperationalStatus"); }
        }

        private Coding _operationalStatus;

        /// <summary>
        /// Name of the location as used by humans
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name of the location as used by humans
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                    NameElement = null;
                else
                    NameElement = new FhirString(value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// A list of alternate names that the location is known as or was known as in the past
        /// </summary>
        [FhirElement("alias", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> AliasElement
        {
            get { if (_aliasElement==null) _aliasElement = new List<FhirString>(); return _aliasElement; }
            set { _aliasElement = value; OnPropertyChanged("AliasElement"); }
        }

        private List<FhirString> _aliasElement;

        /// <summary>
        /// A list of alternate names that the location is known as or was known as in the past
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Alias
        {
            get { return AliasElement != null ? AliasElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    AliasElement = null;
                else
                    AliasElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Alias");
            }
        }

        /// <summary>
        /// Additional details about the location that could be displayed as further information to identify the location beyond its name
        /// </summary>
        [FhirElement("description", InSummary=true, Order=140)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Additional details about the location that could be displayed as further information to identify the location beyond its name
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
        /// instance | kind
        /// </summary>
        [FhirElement("mode", InSummary=true, Order=150)]
        [DataMember]
        public Code<LocationMode> ModeElement
        {
            get { return _modeElement; }
            set { _modeElement = value; OnPropertyChanged("ModeElement"); }
        }

        private Code<LocationMode> _modeElement;

        /// <summary>
        /// instance | kind
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public LocationMode? Mode
        {
            get { return ModeElement != null ? ModeElement.Value : null; }
            set
            {
                if (value == null)
                    ModeElement = null;
                else
                    ModeElement = new Code<LocationMode>(value);
                OnPropertyChanged("Mode");
            }
        }

        /// <summary>
        /// Type of function performed
        /// </summary>
        [FhirElement("type", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Type
        {
            get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private List<CodeableConcept> _type;

        /// <summary>
        /// Contact details of the location
        /// </summary>
        [FhirElement("telecom", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Telecom
        {
            get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
            set { _telecom = value; OnPropertyChanged("Telecom"); }
        }

        private List<ContactPoint> _telecom;

        /// <summary>
        /// Physical location
        /// </summary>
        [FhirElement("address", Order=180)]
        [DataMember]
        public Address Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged("Address"); }
        }

        private Address _address;

        /// <summary>
        /// Physical form of the location
        /// </summary>
        [FhirElement("physicalType", InSummary=true, Order=190)]
        [DataMember]
        public CodeableConcept PhysicalType
        {
            get { return _physicalType; }
            set { _physicalType = value; OnPropertyChanged("PhysicalType"); }
        }

        private CodeableConcept _physicalType;

        /// <summary>
        /// The absolute geographic location
        /// </summary>
        [FhirElement("position", Order=200)]
        [DataMember]
        public PositionComponent Position
        {
            get { return _position; }
            set { _position = value; OnPropertyChanged("Position"); }
        }

        private PositionComponent _position;

        /// <summary>
        /// Organization responsible for provisioning and upkeep
        /// </summary>
        [FhirElement("managingOrganization", InSummary=true, Order=210)]
        [References("Organization")]
        [DataMember]
        public ResourceReference ManagingOrganization
        {
            get { return _managingOrganization; }
            set { _managingOrganization = value; OnPropertyChanged("ManagingOrganization"); }
        }

        private ResourceReference _managingOrganization;

        /// <summary>
        /// Another Location this one is physically part of
        /// </summary>
        [FhirElement("partOf", Order=220)]
        [References("Location")]
        [DataMember]
        public ResourceReference PartOf
        {
            get { return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private ResourceReference _partOf;

        /// <summary>
        /// What days/times during a week is this location usually open
        /// </summary>
        [FhirElement("hoursOfOperation", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<HoursOfOperationComponent> HoursOfOperation
        {
            get { if (_hoursOfOperation==null) _hoursOfOperation = new List<HoursOfOperationComponent>(); return _hoursOfOperation; }
            set { _hoursOfOperation = value; OnPropertyChanged("HoursOfOperation"); }
        }

        private List<HoursOfOperationComponent> _hoursOfOperation;

        /// <summary>
        /// Description of availability exceptions
        /// </summary>
        [FhirElement("availabilityExceptions", Order=240)]
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
        /// Technical endpoints providing access to services operated for the location
        /// </summary>
        [FhirElement("endpoint", Order=250)]
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
            var dest = other as Location;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<LocationStatus>)StatusElement.DeepCopy();
                if (OperationalStatus != null) dest.OperationalStatus = (Coding)OperationalStatus.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (AliasElement != null) dest.AliasElement = new List<FhirString>(AliasElement.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (ModeElement != null) dest.ModeElement = (Code<LocationMode>)ModeElement.DeepCopy();
                if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (Address != null) dest.Address = (Address)Address.DeepCopy();
                if (PhysicalType != null) dest.PhysicalType = (CodeableConcept)PhysicalType.DeepCopy();
                if (Position != null) dest.Position = (PositionComponent)Position.DeepCopy();
                if (ManagingOrganization != null) dest.ManagingOrganization = (ResourceReference)ManagingOrganization.DeepCopy();
                if (PartOf != null) dest.PartOf = (ResourceReference)PartOf.DeepCopy();
                if (HoursOfOperation != null) dest.HoursOfOperation = new List<HoursOfOperationComponent>(HoursOfOperation.DeepCopy());
                if (AvailabilityExceptionsElement != null) dest.AvailabilityExceptionsElement = (FhirString)AvailabilityExceptionsElement.DeepCopy();
                if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Location());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Location;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(OperationalStatus, otherT.OperationalStatus)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if ( !DeepComparable.Matches(AliasElement, otherT.AliasElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
            if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.Matches(Address, otherT.Address)) return false;
            if (!DeepComparable.Matches(PhysicalType, otherT.PhysicalType)) return false;
            if (!DeepComparable.Matches(Position, otherT.Position)) return false;
            if (!DeepComparable.Matches(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if (!DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if ( !DeepComparable.Matches(HoursOfOperation, otherT.HoursOfOperation)) return false;
            if (!DeepComparable.Matches(AvailabilityExceptionsElement, otherT.AvailabilityExceptionsElement)) return false;
            if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Location;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(OperationalStatus, otherT.OperationalStatus)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(AliasElement, otherT.AliasElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if (!DeepComparable.IsExactly(PhysicalType, otherT.PhysicalType)) return false;
            if (!DeepComparable.IsExactly(Position, otherT.Position)) return false;
            if (!DeepComparable.IsExactly(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(HoursOfOperation, otherT.HoursOfOperation)) return false;
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
                if (StatusElement != null) yield return StatusElement;
                if (OperationalStatus != null) yield return OperationalStatus;
                if (NameElement != null) yield return NameElement;
                foreach (var elem in AliasElement) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                if (ModeElement != null) yield return ModeElement;
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                if (Address != null) yield return Address;
                if (PhysicalType != null) yield return PhysicalType;
                if (Position != null) yield return Position;
                if (ManagingOrganization != null) yield return ManagingOrganization;
                if (PartOf != null) yield return PartOf;
                foreach (var elem in HoursOfOperation) { if (elem != null) yield return elem; }
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
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (OperationalStatus != null) yield return new ElementValue("operationalStatus", OperationalStatus);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                foreach (var elem in AliasElement) { if (elem != null) yield return new ElementValue("alias", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                if (Address != null) yield return new ElementValue("address", Address);
                if (PhysicalType != null) yield return new ElementValue("physicalType", PhysicalType);
                if (Position != null) yield return new ElementValue("position", Position);
                if (ManagingOrganization != null) yield return new ElementValue("managingOrganization", ManagingOrganization);
                if (PartOf != null) yield return new ElementValue("partOf", PartOf);
                foreach (var elem in HoursOfOperation) { if (elem != null) yield return new ElementValue("hoursOfOperation", elem); }
                if (AvailabilityExceptionsElement != null) yield return new ElementValue("availabilityExceptions", AvailabilityExceptionsElement);
                foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
            }
        }

    }

}
