using System;
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
    /// Key Object Selection
    /// </summary>
    [FhirType("ImagingObjectSelection", IsResource=true)]
    [DataContract]
    public partial class ImagingObjectSelection : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImagingObjectSelection; } }
        [NotMapped]
        public override string TypeName { get { return "ImagingObjectSelection"; } }


        [FhirType("StudyComponent")]
        [DataContract]
        public partial class StudyComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StudyComponent"; } }

            /// <summary>
            /// Study instance UID
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
            /// Study instance UID
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
            /// Retrieve study URL
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// Retrieve study URL
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if (value == null)
                        UrlElement = null;
                    else
                        UrlElement = new FhirUri(value);
                    OnPropertyChanged("Url");
                }
            }

            /// <summary>
            /// Reference to ImagingStudy
            /// </summary>
            [FhirElement("imagingStudy", InSummary=true, Order=60)]
            [References("ImagingStudy")]
            [DataMember]
            public ResourceReference ImagingStudy
            {
                get { return _imagingStudy; }
                set { _imagingStudy = value; OnPropertyChanged("ImagingStudy"); }
            }

            private ResourceReference _imagingStudy;

            /// <summary>
            /// Series identity of the selected instances
            /// </summary>
            [FhirElement("series", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<SeriesComponent> Series
            {
                get { if (_series==null) _series = new List<SeriesComponent>(); return _series; }
                set { _series = value; OnPropertyChanged("Series"); }
            }

            private List<SeriesComponent> _series;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StudyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UidElement != null) dest.UidElement = (Oid)UidElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                    if (ImagingStudy != null) dest.ImagingStudy = (ResourceReference)ImagingStudy.DeepCopy();
                    if (Series != null) dest.Series = new List<SeriesComponent>(Series.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StudyComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StudyComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.Matches(ImagingStudy, otherT.ImagingStudy)) return false;
                if ( !DeepComparable.Matches(Series, otherT.Series)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StudyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.IsExactly(ImagingStudy, otherT.ImagingStudy)) return false;
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
                    if (UrlElement != null) yield return UrlElement;
                    if (ImagingStudy != null) yield return ImagingStudy;
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
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                    if (ImagingStudy != null) yield return new ElementValue("imagingStudy", ImagingStudy);
                    foreach (var elem in Series) { if (elem != null) yield return new ElementValue("series", elem); }
                }
            }


        }


        [FhirType("SeriesComponent")]
        [DataContract]
        public partial class SeriesComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SeriesComponent"; } }

            /// <summary>
            /// Series instance UID
            /// </summary>
            [FhirElement("uid", InSummary=true, Order=40)]
            [DataMember]
            public Oid UidElement
            {
                get { return _uidElement; }
                set { _uidElement = value; OnPropertyChanged("UidElement"); }
            }

            private Oid _uidElement;

            /// <summary>
            /// Series instance UID
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
            /// Retrieve series URL
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// Retrieve series URL
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if (value == null)
                        UrlElement = null;
                    else
                        UrlElement = new FhirUri(value);
                    OnPropertyChanged("Url");
                }
            }

            /// <summary>
            /// The selected instance
            /// </summary>
            [FhirElement("instance", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=-1)]
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
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
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
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if ( !DeepComparable.Matches(Instance, otherT.Instance)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SeriesComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
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
                    if (UrlElement != null) yield return UrlElement;
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
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
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
            /// SOP class UID of instance
            /// </summary>
            [FhirElement("sopClass", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Oid SopClassElement
            {
                get { return _sopClassElement; }
                set { _sopClassElement = value; OnPropertyChanged("SopClassElement"); }
            }

            private Oid _sopClassElement;

            /// <summary>
            /// SOP class UID of instance
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
            /// Selected instance UID
            /// </summary>
            [FhirElement("uid", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Oid UidElement
            {
                get { return _uidElement; }
                set { _uidElement = value; OnPropertyChanged("UidElement"); }
            }

            private Oid _uidElement;

            /// <summary>
            /// Selected instance UID
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
            /// Retrieve instance URL
            /// </summary>
            [FhirElement("url", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// Retrieve instance URL
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if (value == null)
                        UrlElement = null;
                    else
                        UrlElement = new FhirUri(value);
                    OnPropertyChanged("Url");
                }
            }

            /// <summary>
            /// The frame set
            /// </summary>
            [FhirElement("frames", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FramesComponent> Frames
            {
                get { if (_frames==null) _frames = new List<FramesComponent>(); return _frames; }
                set { _frames = value; OnPropertyChanged("Frames"); }
            }

            private List<FramesComponent> _frames;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InstanceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SopClassElement != null) dest.SopClassElement = (Oid)SopClassElement.DeepCopy();
                    if (UidElement != null) dest.UidElement = (Oid)UidElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                    if (Frames != null) dest.Frames = new List<FramesComponent>(Frames.DeepCopy());
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
                if (!DeepComparable.Matches(SopClassElement, otherT.SopClassElement)) return false;
                if (!DeepComparable.Matches(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
                if ( !DeepComparable.Matches(Frames, otherT.Frames)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InstanceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SopClassElement, otherT.SopClassElement)) return false;
                if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
                if (!DeepComparable.IsExactly(Frames, otherT.Frames)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SopClassElement != null) yield return SopClassElement;
                    if (UidElement != null) yield return UidElement;
                    if (UrlElement != null) yield return UrlElement;
                    foreach (var elem in Frames) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SopClassElement != null) yield return new ElementValue("sopClass", SopClassElement);
                    if (UidElement != null) yield return new ElementValue("uid", UidElement);
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                    foreach (var elem in Frames) { if (elem != null) yield return new ElementValue("frames", elem); }
                }
            }


        }


        [FhirType("FramesComponent")]
        [DataContract]
        public partial class FramesComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FramesComponent"; } }

            /// <summary>
            /// Frame numbers
            /// </summary>
            [FhirElement("frameNumbers", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<UnsignedInt> FrameNumbersElement
            {
                get { if (_frameNumbersElement==null) _frameNumbersElement = new List<UnsignedInt>(); return _frameNumbersElement; }
                set { _frameNumbersElement = value; OnPropertyChanged("FrameNumbersElement"); }
            }

            private List<UnsignedInt> _frameNumbersElement;

            /// <summary>
            /// Frame numbers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> FrameNumbers
            {
                get { return FrameNumbersElement != null ? FrameNumbersElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        FrameNumbersElement = null;
                    else
                        FrameNumbersElement = new List<UnsignedInt>(value.Select(elem=>new UnsignedInt(elem)));
                    OnPropertyChanged("FrameNumbers");
                }
            }

            /// <summary>
            /// Retrieve frame URL
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// Retrieve frame URL
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Url
            {
                get { return UrlElement != null ? UrlElement.Value : null; }
                set
                {
                    if (value == null)
                        UrlElement = null;
                    else
                        UrlElement = new FhirUri(value);
                    OnPropertyChanged("Url");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FramesComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (FrameNumbersElement != null) dest.FrameNumbersElement = new List<UnsignedInt>(FrameNumbersElement.DeepCopy());
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FramesComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FramesComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(FrameNumbersElement, otherT.FrameNumbersElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FramesComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(FrameNumbersElement, otherT.FrameNumbersElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in FrameNumbersElement) { if (elem != null) yield return elem; }
                    if (UrlElement != null) yield return UrlElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in FrameNumbersElement) { if (elem != null) yield return new ElementValue("frameNumbers", elem); }
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                }
            }


        }


        /// <summary>
        /// Instance UID
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
        /// Instance UID
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
        /// Patient of the selected objects
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=100)]
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
        /// Reason for selection
        /// </summary>
        [FhirElement("title", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged("Title"); }
        }

        private CodeableConcept _title;

        /// <summary>
        /// Description text
        /// </summary>
        [FhirElement("description", InSummary=true, Order=120)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Description text
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
        /// Author (human or machine)
        /// </summary>
        [FhirElement("author", InSummary=true, Order=130)]
        [References("Practitioner","Device","Organization","Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// Authoring time of the selection
        /// </summary>
        [FhirElement("authoringTime", InSummary=true, Order=140)]
        [DataMember]
        public FhirDateTime AuthoringTimeElement
        {
            get { return _authoringTimeElement; }
            set { _authoringTimeElement = value; OnPropertyChanged("AuthoringTimeElement"); }
        }

        private FhirDateTime _authoringTimeElement;

        /// <summary>
        /// Authoring time of the selection
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string AuthoringTime
        {
            get { return AuthoringTimeElement != null ? AuthoringTimeElement.Value : null; }
            set
            {
                if (value == null)
                    AuthoringTimeElement = null;
                else
                    AuthoringTimeElement = new FhirDateTime(value);
                OnPropertyChanged("AuthoringTime");
            }
        }

        /// <summary>
        /// Study identity of the selected instances
        /// </summary>
        [FhirElement("study", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<StudyComponent> Study
        {
            get { if (_study==null) _study = new List<StudyComponent>(); return _study; }
            set { _study = value; OnPropertyChanged("Study"); }
        }

        private List<StudyComponent> _study;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImagingObjectSelection;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UidElement != null) dest.UidElement = (Oid)UidElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Title != null) dest.Title = (CodeableConcept)Title.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (AuthoringTimeElement != null) dest.AuthoringTimeElement = (FhirDateTime)AuthoringTimeElement.DeepCopy();
                if (Study != null) dest.Study = new List<StudyComponent>(Study.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ImagingObjectSelection());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ImagingObjectSelection;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UidElement, otherT.UidElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Title, otherT.Title)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(AuthoringTimeElement, otherT.AuthoringTimeElement)) return false;
            if ( !DeepComparable.Matches(Study, otherT.Study)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImagingObjectSelection;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Title, otherT.Title)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(AuthoringTimeElement, otherT.AuthoringTimeElement)) return false;
            if (!DeepComparable.IsExactly(Study, otherT.Study)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UidElement != null) yield return UidElement;
                if (Patient != null) yield return Patient;
                if (Title != null) yield return Title;
                if (DescriptionElement != null) yield return DescriptionElement;
                if (Author != null) yield return Author;
                if (AuthoringTimeElement != null) yield return AuthoringTimeElement;
                foreach (var elem in Study) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UidElement != null) yield return new ElementValue("uid", UidElement);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Title != null) yield return new ElementValue("title", Title);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (Author != null) yield return new ElementValue("author", Author);
                if (AuthoringTimeElement != null) yield return new ElementValue("authoringTime", AuthoringTimeElement);
                foreach (var elem in Study) { if (elem != null) yield return new ElementValue("study", elem); }
            }
        }

    }

}
