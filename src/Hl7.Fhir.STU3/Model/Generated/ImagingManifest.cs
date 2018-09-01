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
    /// Key Object Selection
    /// </summary>
    [FhirType("ImagingManifest", IsResource=true)]
    [DataContract]
    public partial class ImagingManifest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImagingManifest; } }
        [NotMapped]
        public override string TypeName { get { return "ImagingManifest"; } }


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
            /// Reference to ImagingStudy
            /// </summary>
            [FhirElement("imagingStudy", InSummary=true, Order=50)]
            [References("ImagingStudy")]
            [DataMember]
            public ResourceReference ImagingStudy
            {
                get { return _imagingStudy; }
                set { _imagingStudy = value; OnPropertyChanged("ImagingStudy"); }
            }

            private ResourceReference _imagingStudy;

            /// <summary>
            /// Study access service endpoint
            /// </summary>
            [FhirElement("endpoint", InSummary=true, Order=60)]
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
                    if (ImagingStudy != null) dest.ImagingStudy = (ResourceReference)ImagingStudy.DeepCopy();
                    if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
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
                if (!DeepComparable.Matches(ImagingStudy, otherT.ImagingStudy)) return false;
                if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;
                if ( !DeepComparable.Matches(Series, otherT.Series)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StudyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.IsExactly(ImagingStudy, otherT.ImagingStudy)) return false;
                if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;
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
                    if (ImagingStudy != null) yield return ImagingStudy;
                    foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
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
                    if (ImagingStudy != null) yield return new ElementValue("imagingStudy", ImagingStudy);
                    foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
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
            [Cardinality(Min=1,Max=1)]
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
            /// Series access endpoint
            /// </summary>
            [FhirElement("endpoint", InSummary=true, Order=50)]
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
                    if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
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
                if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;
                if ( !DeepComparable.Matches(Instance, otherT.Instance)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SeriesComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;
                if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;
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
                    foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
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
                    foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InstanceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SopClassElement != null) dest.SopClassElement = (Oid)SopClassElement.DeepCopy();
                    if (UidElement != null) dest.UidElement = (Oid)UidElement.DeepCopy();
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

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InstanceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SopClassElement, otherT.SopClassElement)) return false;
                if (!DeepComparable.IsExactly(UidElement, otherT.UidElement)) return false;

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
                }
            }


        }


        /// <summary>
        /// SOP Instance UID
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

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
        /// Time when the selection of instances was made
        /// </summary>
        [FhirElement("authoringTime", InSummary=true, Order=110)]
        [DataMember]
        public FhirDateTime AuthoringTimeElement
        {
            get { return _authoringTimeElement; }
            set { _authoringTimeElement = value; OnPropertyChanged("AuthoringTimeElement"); }
        }

        private FhirDateTime _authoringTimeElement;

        /// <summary>
        /// Time when the selection of instances was made
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
        /// Author (human or machine)
        /// </summary>
        [FhirElement("author", InSummary=true, Order=120)]
        [References("Practitioner","Device","Organization","Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// Description text
        /// </summary>
        [FhirElement("description", InSummary=true, Order=130)]
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
        /// Study identity of the selected instances
        /// </summary>
        [FhirElement("study", InSummary=true, Order=140)]
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
            var dest = other as ImagingManifest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (AuthoringTimeElement != null) dest.AuthoringTimeElement = (FhirDateTime)AuthoringTimeElement.DeepCopy();
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Study != null) dest.Study = new List<StudyComponent>(Study.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ImagingManifest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ImagingManifest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(AuthoringTimeElement, otherT.AuthoringTimeElement)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(Study, otherT.Study)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImagingManifest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(AuthoringTimeElement, otherT.AuthoringTimeElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Study, otherT.Study)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (Patient != null) yield return Patient;
                if (AuthoringTimeElement != null) yield return AuthoringTimeElement;
                if (Author != null) yield return Author;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in Study) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (AuthoringTimeElement != null) yield return new ElementValue("authoringTime", AuthoringTimeElement);
                if (Author != null) yield return new ElementValue("author", Author);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in Study) { if (elem != null) yield return new ElementValue("study", elem); }
            }
        }

    }

}
