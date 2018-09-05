using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// A set of images produced in single study (one or more series of references images)
    /// </summary>
    [FhirType("ImagingStudy", IsResource=true)]
    [DataContract]
    public partial class ImagingStudy : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImagingStudy; } }
        [NotMapped]
        public override string TypeName { get { return "ImagingStudy"; } }

        /// <summary>
        /// Availability of the resource
        /// (url: http://hl7.org/fhir/ValueSet/instance-availability)
        /// </summary>
        [FhirEnumeration("InstanceAvailability")]
        public enum InstanceAvailability
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://dicom.nema.org/resources/ontology/DCM)
            /// </summary>
            [EnumLiteral("ONLINE", "http://dicom.nema.org/resources/ontology/DCM"), Description("Online")]
            ONLINE,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://dicom.nema.org/resources/ontology/DCM)
            /// </summary>
            [EnumLiteral("OFFLINE", "http://dicom.nema.org/resources/ontology/DCM"), Description("Offline")]
            OFFLINE,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://dicom.nema.org/resources/ontology/DCM)
            /// </summary>
            [EnumLiteral("NEARLINE", "http://dicom.nema.org/resources/ontology/DCM"), Description("Nearline")]
            NEARLINE,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://dicom.nema.org/resources/ontology/DCM)
            /// </summary>
            [EnumLiteral("UNAVAILABLE", "http://dicom.nema.org/resources/ontology/DCM"), Description("Unavailable")]
            UNAVAILABLE,
        }


        [FhirType("SeriesComponent")]
        [DataContract]
        public partial class SeriesComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SeriesComponent"; } }

            /// <summary>
            /// Formal DICOM identifier for this series
            /// </summary>
            [FhirElement("uid", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Oid UidElement
            {
                get { return _uidElement; }
                set { _uidElement = value; OnPropertyChanged("UidElement"); }
            }

            private Oid _uidElement;

            /// <summary>
            /// Formal DICOM identifier for this series
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Uid
            {
                get { return UidElement != null ? UidElement.Value : null; }
                set
                {
                    if (value == null)
                        UidElement = null;
                    else
                        UidElement = new Oid(value);
                    OnPropertyChanged("Uid");
                }
            }

            /// <summary>
            /// Numeric identifier of this series
            /// </summary>
            [FhirElement("number", InSummary=true, Order=50)]
            [DataMember]
            public UnsignedInt NumberElement
            {
                get { return _numberElement; }
                set { _numberElement = value; OnPropertyChanged("NumberElement"); }
            }

            private UnsignedInt _numberElement;

            /// <summary>
            /// Numeric identifier of this series
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Number
            {
                get { return NumberElement != null ? NumberElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberElement = null;
                    else
                        NumberElement = new UnsignedInt(value);
                    OnPropertyChanged("Number");
                }
            }

            /// <summary>
            /// The modality of the instances in the series
            /// </summary>
            [FhirElement("modality", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Modality
            {
                get { return _modality; }
                set { _modality = value; OnPropertyChanged("Modality"); }
            }

            private Coding _modality;

            /// <summary>
            /// A short human readable summary of the series
            /// </summary>
            [FhirElement("description", InSummary=true, Order=70)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// A short human readable summary of the series
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
            /// Number of Series Related Instances
            /// </summary>
            [FhirElement("numberOfInstances", InSummary=true, Order=80)]
            [DataMember]
            public UnsignedInt NumberOfInstancesElement
            {
                get { return _numberOfInstancesElement; }
                set { _numberOfInstancesElement = value; OnPropertyChanged("NumberOfInstancesElement"); }
            }

            private UnsignedInt _numberOfInstancesElement;

            /// <summary>
            /// Number of Series Related Instances
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? NumberOfInstances
            {
                get { return NumberOfInstancesElement != null ? NumberOfInstancesElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberOfInstancesElement = null;
                    else
                        NumberOfInstancesElement = new UnsignedInt(value);
                    OnPropertyChanged("NumberOfInstances");
                }
            }

            /// <summary>
            /// ONLINE | OFFLINE | NEARLINE | UNAVAILABLE
            /// </summary>
            [FhirElement("availability", InSummary=true, Order=90)]
            [DataMember]
            public Code<InstanceAvailability> AvailabilityElement
            {
                get { return _availabilityElement; }
                set { _availabilityElement = value; OnPropertyChanged("AvailabilityElement"); }
            }

            private Code<InstanceAvailability> _availabilityElement;

            /// <summary>
            /// ONLINE | OFFLINE | NEARLINE | UNAVAILABLE
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public InstanceAvailability? Availability
            {
                get { return AvailabilityElement != null ? AvailabilityElement.Value : null; }
                set
                {
                    if (value == null)
                        AvailabilityElement = null;
                    else
                        AvailabilityElement = new Code<InstanceAvailability>(value);
                    OnPropertyChanged("Availability");
                }
            }

            /// <summary>
            /// Series access endpoint
            /// </summary>
            [FhirElement("endpoint", InSummary=true, Order=100)]
            [References("Endpoint")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Endpoint
            {
                get { if (_endpoint==null) _endpoint = new List<ResourceReference>(); return _endpoint; }
                set { _endpoint = value; OnPropertyChanged("Endpoint"); }
            }

            private List<ResourceReference> _endpoint;

            /// <summary>
            /// Body part examined
            /// </summary>
            [FhirElement("bodySite", InSummary=true, Order=110)]
            [DataMember]
            public Coding BodySite
            {
                get { return _bodySite; }
                set { _bodySite = value; OnPropertyChanged("BodySite"); }
            }

            private Coding _bodySite;

            /// <summary>
            /// Body part laterality
            /// </summary>
            [FhirElement("laterality", InSummary=true, Order=120)]
            [DataMember]
            public Coding Laterality
            {
                get { return _laterality; }
                set { _laterality = value; OnPropertyChanged("Laterality"); }
            }

            private Coding _laterality;

            /// <summary>
            /// When the series started
            /// </summary>
            [FhirElement("started", InSummary=true, Order=130)]
            [DataMember]
            public FhirDateTime StartedElement
            {
                get { return _startedElement; }
                set { _startedElement = value; OnPropertyChanged("StartedElement"); }
            }

            private FhirDateTime _startedElement;

            /// <summary>
            /// When the series started
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Started
            {
                get { return StartedElement != null ? StartedElement.Value : null; }
                set
                {
                    if (value == null)
                        StartedElement = null;
                    else
                        StartedElement = new FhirDateTime(value);
                    OnPropertyChanged("Started");
                }
            }

            /// <summary>
            /// Who performed the series
            /// </summary>
            [FhirElement("performer", InSummary=true, Order=140)]
            [References("Practitioner")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Performer
            {
                get { if (_performer==null) _performer = new List<ResourceReference>(); return _performer; }
                set { _performer = value; OnPropertyChanged("Performer"); }
            }

            private List<ResourceReference> _performer;

            /// <summary>
            /// A single SOP instance from the series
            /// </summary>
            [FhirElement("instance", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<InstanceComponent> Instance
            {
                get { if (_instance==null) _instance = new List<InstanceComponent>(); return _instance; }
                set { _instance = value; OnPropertyChanged("Instance"); }
            }

            private List<InstanceComponent> _instance;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SeriesComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UidElement != null) dest.UidElement = (Oid)UidElement.DeepCopy();
                    if (NumberElement != null) dest.NumberElement = (UnsignedInt)NumberElement.DeepCopy();
                    if (Modality != null) dest.Modality = (Coding)Modality.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (NumberOfInstancesElement != null) dest.NumberOfInstancesElement = (UnsignedInt)NumberOfInstancesElement.DeepCopy();
                    if (AvailabilityElement != null) dest.AvailabilityElement = (Code<InstanceAvailability>)AvailabilityElement.DeepCopy();
                    if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
                    if (BodySite != null) dest.BodySite = (Coding)BodySite.DeepCopy();
                    if (Laterality != null) dest.Laterality = (Coding)Laterality.DeepCopy();
                    if (StartedElement != null) dest.StartedElement = (FhirDateTime)StartedElement.DeepCopy();
                    if (Performer != null) dest.Performer = new List<ResourceReference>(Performer.DeepCopy());
                    if (Instance != null) dest.Instance = new List<InstanceComponent>(Instance.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SeriesComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SeriesComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.Matches(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.Matches(Modality, otherT.Modality)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(NumberOfInstancesElement, otherT.NumberOfInstancesElement)) return false;
                if (!DeepComparable.Matches(AvailabilityElement, otherT.AvailabilityElement)) return false;
                if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;
                if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
                if (!DeepComparable.Matches(Laterality, otherT.Laterality)) return false;
                if (!DeepComparable.Matches(StartedElement, otherT.StartedElement)) return false;
                if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
                if ( !DeepComparable.Matches(Instance, otherT.Instance)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SeriesComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.IsExactly(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.IsExactly(Modality, otherT.Modality)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(NumberOfInstancesElement, otherT.NumberOfInstancesElement)) return false;
                if (!DeepComparable.IsExactly(AvailabilityElement, otherT.AvailabilityElement)) return false;
                if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;
                if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
                if (!DeepComparable.IsExactly(Laterality, otherT.Laterality)) return false;
                if (!DeepComparable.IsExactly(StartedElement, otherT.StartedElement)) return false;
                if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
                if (!DeepComparable.IsExactly(Instance, otherT.Instance)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (UidElement != null) yield return UidElement;
                    if (NumberElement != null) yield return NumberElement;
                    if (Modality != null) yield return Modality;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (NumberOfInstancesElement != null) yield return NumberOfInstancesElement;
                    if (AvailabilityElement != null) yield return AvailabilityElement;
                    foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
                    if (BodySite != null) yield return BodySite;
                    if (Laterality != null) yield return Laterality;
                    if (StartedElement != null) yield return StartedElement;
                    foreach (var elem in Performer) { if (elem != null) yield return elem; }
                    foreach (var elem in Instance) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (UidElement != null) yield return new ElementValue("uid", UidElement);
                    if (NumberElement != null) yield return new ElementValue("number", NumberElement);
                    if (Modality != null) yield return new ElementValue("modality", Modality);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (NumberOfInstancesElement != null) yield return new ElementValue("numberOfInstances", NumberOfInstancesElement);
                    if (AvailabilityElement != null) yield return new ElementValue("availability", AvailabilityElement);
                    foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
                    if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                    if (Laterality != null) yield return new ElementValue("laterality", Laterality);
                    if (StartedElement != null) yield return new ElementValue("started", StartedElement);
                    foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                    foreach (var elem in Instance) { if (elem != null) yield return new ElementValue("instance", elem); }
                }
            }


        }


        [FhirType("InstanceComponent")]
        [DataContract]
        public partial class InstanceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InstanceComponent"; } }

            /// <summary>
            /// Formal DICOM identifier for this instance
            /// </summary>
            [FhirElement("uid", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Oid UidElement
            {
                get { return _uidElement; }
                set { _uidElement = value; OnPropertyChanged("UidElement"); }
            }

            private Oid _uidElement;

            /// <summary>
            /// Formal DICOM identifier for this instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Uid
            {
                get { return UidElement != null ? UidElement.Value : null; }
                set
                {
                    if (value == null)
                        UidElement = null;
                    else
                        UidElement = new Oid(value);
                    OnPropertyChanged("Uid");
                }
            }

            /// <summary>
            /// The number of this instance in the series
            /// </summary>
            [FhirElement("number", Order=50)]
            [DataMember]
            public UnsignedInt NumberElement
            {
                get { return _numberElement; }
                set { _numberElement = value; OnPropertyChanged("NumberElement"); }
            }

            private UnsignedInt _numberElement;

            /// <summary>
            /// The number of this instance in the series
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Number
            {
                get { return NumberElement != null ? NumberElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberElement = null;
                    else
                        NumberElement = new UnsignedInt(value);
                    OnPropertyChanged("Number");
                }
            }

            /// <summary>
            /// DICOM class type
            /// </summary>
            [FhirElement("sopClass", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Oid SopClassElement
            {
                get { return _sopClassElement; }
                set { _sopClassElement = value; OnPropertyChanged("SopClassElement"); }
            }

            private Oid _sopClassElement;

            /// <summary>
            /// DICOM class type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SopClass
            {
                get { return SopClassElement != null ? SopClassElement.Value : null; }
                set
                {
                    if (value == null)
                        SopClassElement = null;
                    else
                        SopClassElement = new Oid(value);
                    OnPropertyChanged("SopClass");
                }
            }

            /// <summary>
            /// Description of instance
            /// </summary>
            [FhirElement("title", Order=70)]
            [DataMember]
            public FhirString TitleElement
            {
                get { return _titleElement; }
                set { _titleElement = value; OnPropertyChanged("TitleElement"); }
            }

            private FhirString _titleElement;

            /// <summary>
            /// Description of instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Title
            {
                get { return TitleElement != null ? TitleElement.Value : null; }
                set
                {
                    if (value == null)
                        TitleElement = null;
                    else
                        TitleElement = new FhirString(value);
                    OnPropertyChanged("Title");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InstanceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UidElement != null) dest.UidElement = (Oid)UidElement.DeepCopy();
                    if (NumberElement != null) dest.NumberElement = (UnsignedInt)NumberElement.DeepCopy();
                    if (SopClassElement != null) dest.SopClassElement = (Oid)SopClassElement.DeepCopy();
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InstanceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InstanceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.Matches(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.Matches(SopClassElement, otherT.SopClassElement)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InstanceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.IsExactly(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.IsExactly(SopClassElement, otherT.SopClassElement)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (UidElement != null) yield return UidElement;
                    if (NumberElement != null) yield return NumberElement;
                    if (SopClassElement != null) yield return SopClassElement;
                    if (TitleElement != null) yield return TitleElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (UidElement != null) yield return new ElementValue("uid", UidElement);
                    if (NumberElement != null) yield return new ElementValue("number", NumberElement);
                    if (SopClassElement != null) yield return new ElementValue("sopClass", SopClassElement);
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                }
            }


        }


        /// <summary>
        /// Formal DICOM identifier for the study
        /// </summary>
        [FhirElement("uid", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Oid UidElement
        {
            get { return _uidElement; }
            set { _uidElement = value; OnPropertyChanged("UidElement"); }
        }

        private Oid _uidElement;

        /// <summary>
        /// Formal DICOM identifier for the study
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Uid
        {
            get { return UidElement != null ? UidElement.Value : null; }
            set
            {
                if (value == null)
                    UidElement = null;
                else
                    UidElement = new Oid(value);
                OnPropertyChanged("Uid");
            }
        }

        /// <summary>
        /// Related workflow identifier ("Accession Number")
        /// </summary>
        [FhirElement("accession", InSummary=true, Order=100)]
        [DataMember]
        public Identifier Accession
        {
            get { return _accession; }
            set { _accession = value; OnPropertyChanged("Accession"); }
        }

        private Identifier _accession;

        /// <summary>
        /// Other identifiers for the study
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// ONLINE | OFFLINE | NEARLINE | UNAVAILABLE
        /// </summary>
        [FhirElement("availability", InSummary=true, Order=120)]
        [DataMember]
        public Code<InstanceAvailability> AvailabilityElement
        {
            get { return _availabilityElement; }
            set { _availabilityElement = value; OnPropertyChanged("AvailabilityElement"); }
        }

        private Code<InstanceAvailability> _availabilityElement;

        /// <summary>
        /// ONLINE | OFFLINE | NEARLINE | UNAVAILABLE
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public InstanceAvailability? Availability
        {
            get { return AvailabilityElement != null ? AvailabilityElement.Value : null; }
            set
            {
                if (value == null)
                    AvailabilityElement = null;
                else
                    AvailabilityElement = new Code<InstanceAvailability>(value);
                OnPropertyChanged("Availability");
            }
        }

        /// <summary>
        /// All series modality if actual acquisition modalities
        /// </summary>
        [FhirElement("modalityList", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> ModalityList
        {
            get { if (_modalityList==null) _modalityList = new List<Coding>(); return _modalityList; }
            set { _modalityList = value; OnPropertyChanged("ModalityList"); }
        }

        private List<Coding> _modalityList;

        /// <summary>
        /// Who the images are of
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=140)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Originating context
        /// </summary>
        [FhirElement("context", InSummary=true, Order=150)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When the study was started
        /// </summary>
        [FhirElement("started", InSummary=true, Order=160)]
        [DataMember]
        public FhirDateTime StartedElement
        {
            get { return _startedElement; }
            set { _startedElement = value; OnPropertyChanged("StartedElement"); }
        }

        private FhirDateTime _startedElement;

        /// <summary>
        /// When the study was started
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Started
        {
            get { return StartedElement != null ? StartedElement.Value : null; }
            set
            {
                if (value == null)
                    StartedElement = null;
                else
                    StartedElement = new FhirDateTime(value);
                OnPropertyChanged("Started");
            }
        }

        /// <summary>
        /// Request fulfilled
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=170)]
        [References("ReferralRequest","CarePlan","ProcedureRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Referring physician
        /// </summary>
        [FhirElement("referrer", InSummary=true, Order=180)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Referrer
        {
            get { return _referrer; }
            set { _referrer = value; OnPropertyChanged("Referrer"); }
        }

        private ResourceReference _referrer;

        /// <summary>
        /// Who interpreted images
        /// </summary>
        [FhirElement("interpreter", InSummary=true, Order=190)]
        [References("Practitioner")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Interpreter
        {
            get { if (_interpreter==null) _interpreter = new List<ResourceReference>(); return _interpreter; }
            set { _interpreter = value; OnPropertyChanged("Interpreter"); }
        }

        private List<ResourceReference> _interpreter;

        /// <summary>
        /// Study access endpoint
        /// </summary>
        [FhirElement("endpoint", InSummary=true, Order=200)]
        [References("Endpoint")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Endpoint
        {
            get { if (_endpoint==null) _endpoint = new List<ResourceReference>(); return _endpoint; }
            set { _endpoint = value; OnPropertyChanged("Endpoint"); }
        }

        private List<ResourceReference> _endpoint;

        /// <summary>
        /// Number of Study Related Series
        /// </summary>
        [FhirElement("numberOfSeries", InSummary=true, Order=210)]
        [DataMember]
        public UnsignedInt NumberOfSeriesElement
        {
            get { return _numberOfSeriesElement; }
            set { _numberOfSeriesElement = value; OnPropertyChanged("NumberOfSeriesElement"); }
        }

        private UnsignedInt _numberOfSeriesElement;

        /// <summary>
        /// Number of Study Related Series
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? NumberOfSeries
        {
            get { return NumberOfSeriesElement != null ? NumberOfSeriesElement.Value : null; }
            set
            {
                if (value == null)
                    NumberOfSeriesElement = null;
                else
                    NumberOfSeriesElement = new UnsignedInt(value);
                OnPropertyChanged("NumberOfSeries");
            }
        }

        /// <summary>
        /// Number of Study Related Instances
        /// </summary>
        [FhirElement("numberOfInstances", InSummary=true, Order=220)]
        [DataMember]
        public UnsignedInt NumberOfInstancesElement
        {
            get { return _numberOfInstancesElement; }
            set { _numberOfInstancesElement = value; OnPropertyChanged("NumberOfInstancesElement"); }
        }

        private UnsignedInt _numberOfInstancesElement;

        /// <summary>
        /// Number of Study Related Instances
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? NumberOfInstances
        {
            get { return NumberOfInstancesElement != null ? NumberOfInstancesElement.Value : null; }
            set
            {
                if (value == null)
                    NumberOfInstancesElement = null;
                else
                    NumberOfInstancesElement = new UnsignedInt(value);
                OnPropertyChanged("NumberOfInstances");
            }
        }

        /// <summary>
        /// The performed Procedure reference
        /// </summary>
        [FhirElement("procedureReference", InSummary=true, Order=230)]
        [References("Procedure")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ProcedureReference
        {
            get { if (_procedureReference==null) _procedureReference = new List<ResourceReference>(); return _procedureReference; }
            set { _procedureReference = value; OnPropertyChanged("ProcedureReference"); }
        }

        private List<ResourceReference> _procedureReference;

        /// <summary>
        /// The performed procedure code
        /// </summary>
        [FhirElement("procedureCode", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ProcedureCode
        {
            get { if (_procedureCode==null) _procedureCode = new List<CodeableConcept>(); return _procedureCode; }
            set { _procedureCode = value; OnPropertyChanged("ProcedureCode"); }
        }

        private List<CodeableConcept> _procedureCode;

        /// <summary>
        /// Why the study was requested
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=250)]
        [DataMember]
        public CodeableConcept Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private CodeableConcept _reason;

        /// <summary>
        /// Institution-generated description
        /// </summary>
        [FhirElement("description", InSummary=true, Order=260)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Institution-generated description
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
        /// Each study has one or more series of instances
        /// </summary>
        [FhirElement("series", InSummary=true, Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SeriesComponent> Series
        {
            get { if (_series==null) _series = new List<SeriesComponent>(); return _series; }
            set { _series = value; OnPropertyChanged("Series"); }
        }

        private List<SeriesComponent> _series;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImagingStudy;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UidElement != null) dest.UidElement = (Oid)UidElement.DeepCopy();
                if (Accession != null) dest.Accession = (Identifier)Accession.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (AvailabilityElement != null) dest.AvailabilityElement = (Code<InstanceAvailability>)AvailabilityElement.DeepCopy();
                if (ModalityList != null) dest.ModalityList = new List<Coding>(ModalityList.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (StartedElement != null) dest.StartedElement = (FhirDateTime)StartedElement.DeepCopy();
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (Referrer != null) dest.Referrer = (ResourceReference)Referrer.DeepCopy();
                if (Interpreter != null) dest.Interpreter = new List<ResourceReference>(Interpreter.DeepCopy());
                if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
                if (NumberOfSeriesElement != null) dest.NumberOfSeriesElement = (UnsignedInt)NumberOfSeriesElement.DeepCopy();
                if (NumberOfInstancesElement != null) dest.NumberOfInstancesElement = (UnsignedInt)NumberOfInstancesElement.DeepCopy();
                if (ProcedureReference != null) dest.ProcedureReference = new List<ResourceReference>(ProcedureReference.DeepCopy());
                if (ProcedureCode != null) dest.ProcedureCode = new List<CodeableConcept>(ProcedureCode.DeepCopy());
                if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Series != null) dest.Series = new List<SeriesComponent>(Series.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ImagingStudy());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ImagingStudy;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UidElement, otherT.UidElement)) return false;
            if (!DeepComparable.Matches(Accession, otherT.Accession)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(AvailabilityElement, otherT.AvailabilityElement)) return false;
            if ( !DeepComparable.Matches(ModalityList, otherT.ModalityList)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(StartedElement, otherT.StartedElement)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.Matches(Referrer, otherT.Referrer)) return false;
            if ( !DeepComparable.Matches(Interpreter, otherT.Interpreter)) return false;
            if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;
            if (!DeepComparable.Matches(NumberOfSeriesElement, otherT.NumberOfSeriesElement)) return false;
            if (!DeepComparable.Matches(NumberOfInstancesElement, otherT.NumberOfInstancesElement)) return false;
            if ( !DeepComparable.Matches(ProcedureReference, otherT.ProcedureReference)) return false;
            if ( !DeepComparable.Matches(ProcedureCode, otherT.ProcedureCode)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(Series, otherT.Series)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImagingStudy;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;
            if (!DeepComparable.IsExactly(Accession, otherT.Accession)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(AvailabilityElement, otherT.AvailabilityElement)) return false;
            if (!DeepComparable.IsExactly(ModalityList, otherT.ModalityList)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(StartedElement, otherT.StartedElement)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Referrer, otherT.Referrer)) return false;
            if (!DeepComparable.IsExactly(Interpreter, otherT.Interpreter)) return false;
            if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;
            if (!DeepComparable.IsExactly(NumberOfSeriesElement, otherT.NumberOfSeriesElement)) return false;
            if (!DeepComparable.IsExactly(NumberOfInstancesElement, otherT.NumberOfInstancesElement)) return false;
            if (!DeepComparable.IsExactly(ProcedureReference, otherT.ProcedureReference)) return false;
            if (!DeepComparable.IsExactly(ProcedureCode, otherT.ProcedureCode)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Series, otherT.Series)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UidElement != null) yield return UidElement;
                if (Accession != null) yield return Accession;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (AvailabilityElement != null) yield return AvailabilityElement;
                foreach (var elem in ModalityList) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
                if (Context != null) yield return Context;
                if (StartedElement != null) yield return StartedElement;
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                if (Referrer != null) yield return Referrer;
                foreach (var elem in Interpreter) { if (elem != null) yield return elem; }
                foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
                if (NumberOfSeriesElement != null) yield return NumberOfSeriesElement;
                if (NumberOfInstancesElement != null) yield return NumberOfInstancesElement;
                foreach (var elem in ProcedureReference) { if (elem != null) yield return elem; }
                foreach (var elem in ProcedureCode) { if (elem != null) yield return elem; }
                if (Reason != null) yield return Reason;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in Series) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UidElement != null) yield return new ElementValue("uid", UidElement);
                if (Accession != null) yield return new ElementValue("accession", Accession);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (AvailabilityElement != null) yield return new ElementValue("availability", AvailabilityElement);
                foreach (var elem in ModalityList) { if (elem != null) yield return new ElementValue("modalityList", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Context != null) yield return new ElementValue("context", Context);
                if (StartedElement != null) yield return new ElementValue("started", StartedElement);
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                if (Referrer != null) yield return new ElementValue("referrer", Referrer);
                foreach (var elem in Interpreter) { if (elem != null) yield return new ElementValue("interpreter", elem); }
                foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
                if (NumberOfSeriesElement != null) yield return new ElementValue("numberOfSeries", NumberOfSeriesElement);
                if (NumberOfInstancesElement != null) yield return new ElementValue("numberOfInstances", NumberOfInstancesElement);
                foreach (var elem in ProcedureReference) { if (elem != null) yield return new ElementValue("procedureReference", elem); }
                foreach (var elem in ProcedureCode) { if (elem != null) yield return new ElementValue("procedureCode", elem); }
                if (Reason != null) yield return new ElementValue("reason", Reason);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in Series) { if (elem != null) yield return new ElementValue("series", elem); }
            }
        }

    }

}
