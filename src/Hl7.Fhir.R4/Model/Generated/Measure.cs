using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A quality measure definition
    /// </summary>
    [FhirType("Measure", IsResource=true)]
    [DataContract]
    public partial class Measure : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Measure; } }
        [NotMapped]
        public override string TypeName { get { return "Measure"; } }


        [FhirType("GroupComponent")]
        [DataContract]
        public partial class GroupComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GroupComponent"; } }

            /// <summary>
            /// Meaning of the group
            /// </summary>
            [FhirElement("code", Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Summary description
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Summary description
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
            /// Population criteria
            /// </summary>
            [FhirElement("population", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PopulationComponent> Population
            {
                get { if (_population==null) _population = new List<PopulationComponent>(); return _population; }
                set { _population = value; OnPropertyChanged("Population"); }
            }

            private List<PopulationComponent> _population;

            /// <summary>
            /// Stratifier criteria for the measure
            /// </summary>
            [FhirElement("stratifier", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StratifierComponent> Stratifier
            {
                get { if (_stratifier==null) _stratifier = new List<StratifierComponent>(); return _stratifier; }
                set { _stratifier = value; OnPropertyChanged("Stratifier"); }
            }

            private List<StratifierComponent> _stratifier;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GroupComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Population != null) dest.Population = new List<PopulationComponent>(Population.DeepCopy());
                    if (Stratifier != null) dest.Stratifier = new List<StratifierComponent>(Stratifier.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GroupComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GroupComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if ( !DeepComparable.Matches(Population, otherT.Population)) return false;
                if ( !DeepComparable.Matches(Stratifier, otherT.Stratifier)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GroupComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Population, otherT.Population)) return false;
                if (!DeepComparable.IsExactly(Stratifier, otherT.Stratifier)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    foreach (var elem in Population) { if (elem != null) yield return elem; }
                    foreach (var elem in Stratifier) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    foreach (var elem in Population) { if (elem != null) yield return new ElementValue("population", elem); }
                    foreach (var elem in Stratifier) { if (elem != null) yield return new ElementValue("stratifier", elem); }
                }
            }


        }


        [FhirType("PopulationComponent")]
        [DataContract]
        public partial class PopulationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PopulationComponent"; } }

            /// <summary>
            /// initial-population | numerator | numerator-exclusion | denominator | denominator-exclusion | denominator-exception | measure-population | measure-population-exclusion | measure-observation
            /// </summary>
            [FhirElement("code", Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// The human readable description of this population criteria
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// The human readable description of this population criteria
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
            /// The criteria that defines this population
            /// </summary>
            [FhirElement("criteria", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Expression Criteria
            {
                get { return _criteria; }
                set { _criteria = value; OnPropertyChanged("Criteria"); }
            }

            private Expression _criteria;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PopulationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Criteria != null) dest.Criteria = (Expression)Criteria.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PopulationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Criteria, otherT.Criteria)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Criteria, otherT.Criteria)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Criteria != null) yield return Criteria;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Criteria != null) yield return new ElementValue("criteria", Criteria);
                }
            }


        }


        [FhirType("StratifierComponent")]
        [DataContract]
        public partial class StratifierComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StratifierComponent"; } }

            /// <summary>
            /// Meaning of the stratifier
            /// </summary>
            [FhirElement("code", Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// The human readable description of this stratifier
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// The human readable description of this stratifier
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
            /// How the measure should be stratified
            /// </summary>
            [FhirElement("criteria", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Expression Criteria
            {
                get { return _criteria; }
                set { _criteria = value; OnPropertyChanged("Criteria"); }
            }

            private Expression _criteria;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StratifierComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Criteria != null) dest.Criteria = (Expression)Criteria.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StratifierComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StratifierComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Criteria, otherT.Criteria)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StratifierComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Criteria, otherT.Criteria)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Criteria != null) yield return Criteria;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Criteria != null) yield return new ElementValue("criteria", Criteria);
                }
            }


        }


        [FhirType("SupplementalDataComponent")]
        [DataContract]
        public partial class SupplementalDataComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SupplementalDataComponent"; } }

            /// <summary>
            /// Meaning of the supplemental data
            /// </summary>
            [FhirElement("code", Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// supplemental-data | risk-adjustment-factor
            /// </summary>
            [FhirElement("usage", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Usage
            {
                get { if (_usage==null) _usage = new List<CodeableConcept>(); return _usage; }
                set { _usage = value; OnPropertyChanged("Usage"); }
            }

            private List<CodeableConcept> _usage;

            /// <summary>
            /// The human readable description of this supplemental data
            /// </summary>
            [FhirElement("description", Order=60)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// The human readable description of this supplemental data
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
            /// Expression describing additional data to be reported
            /// </summary>
            [FhirElement("criteria", Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Expression Criteria
            {
                get { return _criteria; }
                set { _criteria = value; OnPropertyChanged("Criteria"); }
            }

            private Expression _criteria;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SupplementalDataComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Usage != null) dest.Usage = new List<CodeableConcept>(Usage.DeepCopy());
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Criteria != null) dest.Criteria = (Expression)Criteria.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SupplementalDataComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SupplementalDataComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if ( !DeepComparable.Matches(Usage, otherT.Usage)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Criteria, otherT.Criteria)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SupplementalDataComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Usage, otherT.Usage)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Criteria, otherT.Criteria)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in Usage) { if (elem != null) yield return elem; }
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Criteria != null) yield return Criteria;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    foreach (var elem in Usage) { if (elem != null) yield return new ElementValue("usage", elem); }
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Criteria != null) yield return new ElementValue("criteria", Criteria);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this measure, represented as a URI (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Canonical identifier for this measure, represented as a URI (globally unique)
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
        /// Additional identifier for the measure
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Business version of the measure
        /// </summary>
        [FhirElement("version", InSummary=true, Order=110)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Business version of the measure
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new FhirString(value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Name for this measure (computer friendly)
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
        /// Name for this measure (computer friendly)
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
        /// Name for this measure (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=true, Order=130)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Name for this measure (human friendly)
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

        /// <summary>
        /// Subordinate title of the measure
        /// </summary>
        [FhirElement("subtitle", Order=140)]
        [DataMember]
        public FhirString SubtitleElement
        {
            get { return _subtitleElement; }
            set { _subtitleElement = value; OnPropertyChanged("SubtitleElement"); }
        }

        private FhirString _subtitleElement;

        /// <summary>
        /// Subordinate title of the measure
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Subtitle
        {
            get { return SubtitleElement != null ? SubtitleElement.Value : null; }
            set
            {
                if (value == null)
                    SubtitleElement = null;
                else
                    SubtitleElement = new FhirString(value);
                OnPropertyChanged("Subtitle");
            }
        }

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<PublicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<PublicationStatus> _statusElement;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=160)]
        [DataMember]
        public FhirBoolean ExperimentalElement
        {
            get { return _experimentalElement; }
            set { _experimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }

        private FhirBoolean _experimentalElement;

        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (value == null)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }

        /// <summary>
        /// E.g. Patient, Practitioner, RelatedPerson, Organization, Location, Device
        /// </summary>
        [FhirElement("subject", Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private Element _subject;

        /// <summary>
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=180)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date last changed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=190)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                    PublisherElement = null;
                else
                    PublisherElement = new FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }

        /// <summary>
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Natural language description of the measure
        /// </summary>
        [FhirElement("description", InSummary=true, Order=210)]
        [DataMember]
        public Markdown DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private Markdown _descriptionElement;

        /// <summary>
        /// Natural language description of the measure
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
                    DescriptionElement = new Markdown(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for measure (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Why this measure is defined
        /// </summary>
        [FhirElement("purpose", Order=240)]
        [DataMember]
        public Markdown PurposeElement
        {
            get { return _purposeElement; }
            set { _purposeElement = value; OnPropertyChanged("PurposeElement"); }
        }

        private Markdown _purposeElement;

        /// <summary>
        /// Why this measure is defined
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Purpose
        {
            get { return PurposeElement != null ? PurposeElement.Value : null; }
            set
            {
                if (value == null)
                    PurposeElement = null;
                else
                    PurposeElement = new Markdown(value);
                OnPropertyChanged("Purpose");
            }
        }

        /// <summary>
        /// Describes the clinical usage of the measure
        /// </summary>
        [FhirElement("usage", Order=250)]
        [DataMember]
        public FhirString UsageElement
        {
            get { return _usageElement; }
            set { _usageElement = value; OnPropertyChanged("UsageElement"); }
        }

        private FhirString _usageElement;

        /// <summary>
        /// Describes the clinical usage of the measure
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Usage
        {
            get { return UsageElement != null ? UsageElement.Value : null; }
            set
            {
                if (value == null)
                    UsageElement = null;
                else
                    UsageElement = new FhirString(value);
                OnPropertyChanged("Usage");
            }
        }

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=260)]
        [DataMember]
        public Markdown CopyrightElement
        {
            get { return _copyrightElement; }
            set { _copyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }

        private Markdown _copyrightElement;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if (value == null)
                    CopyrightElement = null;
                else
                    CopyrightElement = new Markdown(value);
                OnPropertyChanged("Copyright");
            }
        }

        /// <summary>
        /// When the measure was approved by publisher
        /// </summary>
        [FhirElement("approvalDate", Order=270)]
        [DataMember]
        public Date ApprovalDateElement
        {
            get { return _approvalDateElement; }
            set { _approvalDateElement = value; OnPropertyChanged("ApprovalDateElement"); }
        }

        private Date _approvalDateElement;

        /// <summary>
        /// When the measure was approved by publisher
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ApprovalDate
        {
            get { return ApprovalDateElement != null ? ApprovalDateElement.Value : null; }
            set
            {
                if (value == null)
                    ApprovalDateElement = null;
                else
                    ApprovalDateElement = new Date(value);
                OnPropertyChanged("ApprovalDate");
            }
        }

        /// <summary>
        /// When the measure was last reviewed
        /// </summary>
        [FhirElement("lastReviewDate", Order=280)]
        [DataMember]
        public Date LastReviewDateElement
        {
            get { return _lastReviewDateElement; }
            set { _lastReviewDateElement = value; OnPropertyChanged("LastReviewDateElement"); }
        }

        private Date _lastReviewDateElement;

        /// <summary>
        /// When the measure was last reviewed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string LastReviewDate
        {
            get { return LastReviewDateElement != null ? LastReviewDateElement.Value : null; }
            set
            {
                if (value == null)
                    LastReviewDateElement = null;
                else
                    LastReviewDateElement = new Date(value);
                OnPropertyChanged("LastReviewDate");
            }
        }

        /// <summary>
        /// When the measure is expected to be used
        /// </summary>
        [FhirElement("effectivePeriod", InSummary=true, Order=290)]
        [DataMember]
        public Period EffectivePeriod
        {
            get { return _effectivePeriod; }
            set { _effectivePeriod = value; OnPropertyChanged("EffectivePeriod"); }
        }

        private Period _effectivePeriod;

        /// <summary>
        /// The category of the measure, such as Education, Treatment, Assessment, etc.
        /// </summary>
        [FhirElement("topic", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Topic
        {
            get { if (_topic==null) _topic = new List<CodeableConcept>(); return _topic; }
            set { _topic = value; OnPropertyChanged("Topic"); }
        }

        private List<CodeableConcept> _topic;

        /// <summary>
        /// Who authored the content
        /// </summary>
        [FhirElement("author", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Author
        {
            get { if (_author==null) _author = new List<ContactDetail>(); return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private List<ContactDetail> _author;

        /// <summary>
        /// Who edited the content
        /// </summary>
        [FhirElement("editor", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Editor
        {
            get { if (_editor==null) _editor = new List<ContactDetail>(); return _editor; }
            set { _editor = value; OnPropertyChanged("Editor"); }
        }

        private List<ContactDetail> _editor;

        /// <summary>
        /// Who reviewed the content
        /// </summary>
        [FhirElement("reviewer", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Reviewer
        {
            get { if (_reviewer==null) _reviewer = new List<ContactDetail>(); return _reviewer; }
            set { _reviewer = value; OnPropertyChanged("Reviewer"); }
        }

        private List<ContactDetail> _reviewer;

        /// <summary>
        /// Who endorsed the content
        /// </summary>
        [FhirElement("endorser", Order=340)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Endorser
        {
            get { if (_endorser==null) _endorser = new List<ContactDetail>(); return _endorser; }
            set { _endorser = value; OnPropertyChanged("Endorser"); }
        }

        private List<ContactDetail> _endorser;

        /// <summary>
        /// Additional documentation, citations, etc.
        /// </summary>
        [FhirElement("relatedArtifact", Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedArtifact> RelatedArtifact
        {
            get { if (_relatedArtifact==null) _relatedArtifact = new List<RelatedArtifact>(); return _relatedArtifact; }
            set { _relatedArtifact = value; OnPropertyChanged("RelatedArtifact"); }
        }

        private List<RelatedArtifact> _relatedArtifact;

        /// <summary>
        /// Logic used by the measure
        /// </summary>
        [FhirElement("library", Order=360)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> LibraryElement
        {
            get { if (_libraryElement==null) _libraryElement = new List<Canonical>(); return _libraryElement; }
            set { _libraryElement = value; OnPropertyChanged("LibraryElement"); }
        }

        private List<Canonical> _libraryElement;

        /// <summary>
        /// Logic used by the measure
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Library
        {
            get { return LibraryElement != null ? LibraryElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    LibraryElement = null;
                else
                    LibraryElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("Library");
            }
        }

        /// <summary>
        /// Disclaimer for use of the measure or its referenced content
        /// </summary>
        [FhirElement("disclaimer", InSummary=true, Order=370)]
        [DataMember]
        public Markdown DisclaimerElement
        {
            get { return _disclaimerElement; }
            set { _disclaimerElement = value; OnPropertyChanged("DisclaimerElement"); }
        }

        private Markdown _disclaimerElement;

        /// <summary>
        /// Disclaimer for use of the measure or its referenced content
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Disclaimer
        {
            get { return DisclaimerElement != null ? DisclaimerElement.Value : null; }
            set
            {
                if (value == null)
                    DisclaimerElement = null;
                else
                    DisclaimerElement = new Markdown(value);
                OnPropertyChanged("Disclaimer");
            }
        }

        /// <summary>
        /// proportion | ratio | continuous-variable | cohort
        /// </summary>
        [FhirElement("scoring", InSummary=true, Order=380)]
        [DataMember]
        public CodeableConcept Scoring
        {
            get { return _scoring; }
            set { _scoring = value; OnPropertyChanged("Scoring"); }
        }

        private CodeableConcept _scoring;

        /// <summary>
        /// opportunity | all-or-nothing | linear | weighted
        /// </summary>
        [FhirElement("compositeScoring", InSummary=true, Order=390)]
        [DataMember]
        public CodeableConcept CompositeScoring
        {
            get { return _compositeScoring; }
            set { _compositeScoring = value; OnPropertyChanged("CompositeScoring"); }
        }

        private CodeableConcept _compositeScoring;

        /// <summary>
        /// process | outcome | structure | patient-reported-outcome | composite
        /// </summary>
        [FhirElement("type", InSummary=true, Order=400)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Type
        {
            get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private List<CodeableConcept> _type;

        /// <summary>
        /// How risk adjustment is applied for this measure
        /// </summary>
        [FhirElement("riskAdjustment", InSummary=true, Order=410)]
        [DataMember]
        public FhirString RiskAdjustmentElement
        {
            get { return _riskAdjustmentElement; }
            set { _riskAdjustmentElement = value; OnPropertyChanged("RiskAdjustmentElement"); }
        }

        private FhirString _riskAdjustmentElement;

        /// <summary>
        /// How risk adjustment is applied for this measure
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string RiskAdjustment
        {
            get { return RiskAdjustmentElement != null ? RiskAdjustmentElement.Value : null; }
            set
            {
                if (value == null)
                    RiskAdjustmentElement = null;
                else
                    RiskAdjustmentElement = new FhirString(value);
                OnPropertyChanged("RiskAdjustment");
            }
        }

        /// <summary>
        /// How is rate aggregation performed for this measure
        /// </summary>
        [FhirElement("rateAggregation", InSummary=true, Order=420)]
        [DataMember]
        public FhirString RateAggregationElement
        {
            get { return _rateAggregationElement; }
            set { _rateAggregationElement = value; OnPropertyChanged("RateAggregationElement"); }
        }

        private FhirString _rateAggregationElement;

        /// <summary>
        /// How is rate aggregation performed for this measure
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string RateAggregation
        {
            get { return RateAggregationElement != null ? RateAggregationElement.Value : null; }
            set
            {
                if (value == null)
                    RateAggregationElement = null;
                else
                    RateAggregationElement = new FhirString(value);
                OnPropertyChanged("RateAggregation");
            }
        }

        /// <summary>
        /// Detailed description of why the measure exists
        /// </summary>
        [FhirElement("rationale", InSummary=true, Order=430)]
        [DataMember]
        public Markdown RationaleElement
        {
            get { return _rationaleElement; }
            set { _rationaleElement = value; OnPropertyChanged("RationaleElement"); }
        }

        private Markdown _rationaleElement;

        /// <summary>
        /// Detailed description of why the measure exists
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Rationale
        {
            get { return RationaleElement != null ? RationaleElement.Value : null; }
            set
            {
                if (value == null)
                    RationaleElement = null;
                else
                    RationaleElement = new Markdown(value);
                OnPropertyChanged("Rationale");
            }
        }

        /// <summary>
        /// Summary of clinical guidelines
        /// </summary>
        [FhirElement("clinicalRecommendationStatement", InSummary=true, Order=440)]
        [DataMember]
        public Markdown ClinicalRecommendationStatementElement
        {
            get { return _clinicalRecommendationStatementElement; }
            set { _clinicalRecommendationStatementElement = value; OnPropertyChanged("ClinicalRecommendationStatementElement"); }
        }

        private Markdown _clinicalRecommendationStatementElement;

        /// <summary>
        /// Summary of clinical guidelines
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ClinicalRecommendationStatement
        {
            get { return ClinicalRecommendationStatementElement != null ? ClinicalRecommendationStatementElement.Value : null; }
            set
            {
                if (value == null)
                    ClinicalRecommendationStatementElement = null;
                else
                    ClinicalRecommendationStatementElement = new Markdown(value);
                OnPropertyChanged("ClinicalRecommendationStatement");
            }
        }

        /// <summary>
        /// increase | decrease
        /// </summary>
        [FhirElement("improvementNotation", InSummary=true, Order=450)]
        [DataMember]
        public Code<MeasureImprovementNotation> ImprovementNotationElement
        {
            get { return _improvementNotationElement; }
            set { _improvementNotationElement = value; OnPropertyChanged("ImprovementNotationElement"); }
        }

        private Code<MeasureImprovementNotation> _improvementNotationElement;

        /// <summary>
        /// increase | decrease
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MeasureImprovementNotation? ImprovementNotation
        {
            get { return ImprovementNotationElement != null ? ImprovementNotationElement.Value : null; }
            set
            {
                if (value == null)
                    ImprovementNotationElement = null;
                else
                    ImprovementNotationElement = new Code<MeasureImprovementNotation>(value);
                OnPropertyChanged("ImprovementNotation");
            }
        }

        /// <summary>
        /// Defined terms used in the measure documentation
        /// </summary>
        [FhirElement("definition", InSummary=true, Order=460)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Markdown> DefinitionElement
        {
            get { if (_definitionElement==null) _definitionElement = new List<Markdown>(); return _definitionElement; }
            set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
        }

        private List<Markdown> _definitionElement;

        /// <summary>
        /// Defined terms used in the measure documentation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Definition
        {
            get { return DefinitionElement != null ? DefinitionElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    DefinitionElement = null;
                else
                    DefinitionElement = new List<Markdown>(value.Select(elem=>new Markdown(elem)));
                OnPropertyChanged("Definition");
            }
        }

        /// <summary>
        /// Additional guidance for implementers
        /// </summary>
        [FhirElement("guidance", InSummary=true, Order=470)]
        [DataMember]
        public Markdown GuidanceElement
        {
            get { return _guidanceElement; }
            set { _guidanceElement = value; OnPropertyChanged("GuidanceElement"); }
        }

        private Markdown _guidanceElement;

        /// <summary>
        /// Additional guidance for implementers
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Guidance
        {
            get { return GuidanceElement != null ? GuidanceElement.Value : null; }
            set
            {
                if (value == null)
                    GuidanceElement = null;
                else
                    GuidanceElement = new Markdown(value);
                OnPropertyChanged("Guidance");
            }
        }

        /// <summary>
        /// Population criteria group
        /// </summary>
        [FhirElement("group", Order=480)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GroupComponent> Group
        {
            get { if (_group==null) _group = new List<GroupComponent>(); return _group; }
            set { _group = value; OnPropertyChanged("Group"); }
        }

        private List<GroupComponent> _group;

        /// <summary>
        /// What other data should be reported with the measure
        /// </summary>
        [FhirElement("supplementalData", Order=490)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SupplementalDataComponent> SupplementalData
        {
            get { if (_supplementalData==null) _supplementalData = new List<SupplementalDataComponent>(); return _supplementalData; }
            set { _supplementalData = value; OnPropertyChanged("SupplementalData"); }
        }

        private List<SupplementalDataComponent> _supplementalData;


        public static ElementDefinition.ConstraintComponent Measure_MEA_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "mea-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Measure_MEA_0);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Measure;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (SubtitleElement != null) dest.SubtitleElement = (FhirString)SubtitleElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (Subject != null) dest.Subject = (Element)Subject.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (PurposeElement != null) dest.PurposeElement = (Markdown)PurposeElement.DeepCopy();
                if (UsageElement != null) dest.UsageElement = (FhirString)UsageElement.DeepCopy();
                if (CopyrightElement != null) dest.CopyrightElement = (Markdown)CopyrightElement.DeepCopy();
                if (ApprovalDateElement != null) dest.ApprovalDateElement = (Date)ApprovalDateElement.DeepCopy();
                if (LastReviewDateElement != null) dest.LastReviewDateElement = (Date)LastReviewDateElement.DeepCopy();
                if (EffectivePeriod != null) dest.EffectivePeriod = (Period)EffectivePeriod.DeepCopy();
                if (Topic != null) dest.Topic = new List<CodeableConcept>(Topic.DeepCopy());
                if (Author != null) dest.Author = new List<ContactDetail>(Author.DeepCopy());
                if (Editor != null) dest.Editor = new List<ContactDetail>(Editor.DeepCopy());
                if (Reviewer != null) dest.Reviewer = new List<ContactDetail>(Reviewer.DeepCopy());
                if (Endorser != null) dest.Endorser = new List<ContactDetail>(Endorser.DeepCopy());
                if (RelatedArtifact != null) dest.RelatedArtifact = new List<RelatedArtifact>(RelatedArtifact.DeepCopy());
                if (LibraryElement != null) dest.LibraryElement = new List<Canonical>(LibraryElement.DeepCopy());
                if (DisclaimerElement != null) dest.DisclaimerElement = (Markdown)DisclaimerElement.DeepCopy();
                if (Scoring != null) dest.Scoring = (CodeableConcept)Scoring.DeepCopy();
                if (CompositeScoring != null) dest.CompositeScoring = (CodeableConcept)CompositeScoring.DeepCopy();
                if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                if (RiskAdjustmentElement != null) dest.RiskAdjustmentElement = (FhirString)RiskAdjustmentElement.DeepCopy();
                if (RateAggregationElement != null) dest.RateAggregationElement = (FhirString)RateAggregationElement.DeepCopy();
                if (RationaleElement != null) dest.RationaleElement = (Markdown)RationaleElement.DeepCopy();
                if (ClinicalRecommendationStatementElement != null) dest.ClinicalRecommendationStatementElement = (Markdown)ClinicalRecommendationStatementElement.DeepCopy();
                if (ImprovementNotationElement != null) dest.ImprovementNotationElement = (Code<MeasureImprovementNotation>)ImprovementNotationElement.DeepCopy();
                if (DefinitionElement != null) dest.DefinitionElement = new List<Markdown>(DefinitionElement.DeepCopy());
                if (GuidanceElement != null) dest.GuidanceElement = (Markdown)GuidanceElement.DeepCopy();
                if (Group != null) dest.Group = new List<GroupComponent>(Group.DeepCopy());
                if (SupplementalData != null) dest.SupplementalData = new List<SupplementalDataComponent>(SupplementalData.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Measure());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Measure;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(SubtitleElement, otherT.SubtitleElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.Matches(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.Matches(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.Matches(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.Matches(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if ( !DeepComparable.Matches(Topic, otherT.Topic)) return false;
            if ( !DeepComparable.Matches(Author, otherT.Author)) return false;
            if ( !DeepComparable.Matches(Editor, otherT.Editor)) return false;
            if ( !DeepComparable.Matches(Reviewer, otherT.Reviewer)) return false;
            if ( !DeepComparable.Matches(Endorser, otherT.Endorser)) return false;
            if ( !DeepComparable.Matches(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if ( !DeepComparable.Matches(LibraryElement, otherT.LibraryElement)) return false;
            if (!DeepComparable.Matches(DisclaimerElement, otherT.DisclaimerElement)) return false;
            if (!DeepComparable.Matches(Scoring, otherT.Scoring)) return false;
            if (!DeepComparable.Matches(CompositeScoring, otherT.CompositeScoring)) return false;
            if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(RiskAdjustmentElement, otherT.RiskAdjustmentElement)) return false;
            if (!DeepComparable.Matches(RateAggregationElement, otherT.RateAggregationElement)) return false;
            if (!DeepComparable.Matches(RationaleElement, otherT.RationaleElement)) return false;
            if (!DeepComparable.Matches(ClinicalRecommendationStatementElement, otherT.ClinicalRecommendationStatementElement)) return false;
            if (!DeepComparable.Matches(ImprovementNotationElement, otherT.ImprovementNotationElement)) return false;
            if ( !DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
            if (!DeepComparable.Matches(GuidanceElement, otherT.GuidanceElement)) return false;
            if ( !DeepComparable.Matches(Group, otherT.Group)) return false;
            if ( !DeepComparable.Matches(SupplementalData, otherT.SupplementalData)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Measure;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(SubtitleElement, otherT.SubtitleElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.IsExactly(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.IsExactly(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.IsExactly(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.IsExactly(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if (!DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Editor, otherT.Editor)) return false;
            if (!DeepComparable.IsExactly(Reviewer, otherT.Reviewer)) return false;
            if (!DeepComparable.IsExactly(Endorser, otherT.Endorser)) return false;
            if (!DeepComparable.IsExactly(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if (!DeepComparable.IsExactly(LibraryElement, otherT.LibraryElement)) return false;
            if (!DeepComparable.IsExactly(DisclaimerElement, otherT.DisclaimerElement)) return false;
            if (!DeepComparable.IsExactly(Scoring, otherT.Scoring)) return false;
            if (!DeepComparable.IsExactly(CompositeScoring, otherT.CompositeScoring)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(RiskAdjustmentElement, otherT.RiskAdjustmentElement)) return false;
            if (!DeepComparable.IsExactly(RateAggregationElement, otherT.RateAggregationElement)) return false;
            if (!DeepComparable.IsExactly(RationaleElement, otherT.RationaleElement)) return false;
            if (!DeepComparable.IsExactly(ClinicalRecommendationStatementElement, otherT.ClinicalRecommendationStatementElement)) return false;
            if (!DeepComparable.IsExactly(ImprovementNotationElement, otherT.ImprovementNotationElement)) return false;
            if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
            if (!DeepComparable.IsExactly(GuidanceElement, otherT.GuidanceElement)) return false;
            if (!DeepComparable.IsExactly(Group, otherT.Group)) return false;
            if (!DeepComparable.IsExactly(SupplementalData, otherT.SupplementalData)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (TitleElement != null) yield return TitleElement;
                if (SubtitleElement != null) yield return SubtitleElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (Subject != null) yield return Subject;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (PurposeElement != null) yield return PurposeElement;
                if (UsageElement != null) yield return UsageElement;
                if (CopyrightElement != null) yield return CopyrightElement;
                if (ApprovalDateElement != null) yield return ApprovalDateElement;
                if (LastReviewDateElement != null) yield return LastReviewDateElement;
                if (EffectivePeriod != null) yield return EffectivePeriod;
                foreach (var elem in Topic) { if (elem != null) yield return elem; }
                foreach (var elem in Author) { if (elem != null) yield return elem; }
                foreach (var elem in Editor) { if (elem != null) yield return elem; }
                foreach (var elem in Reviewer) { if (elem != null) yield return elem; }
                foreach (var elem in Endorser) { if (elem != null) yield return elem; }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return elem; }
                foreach (var elem in LibraryElement) { if (elem != null) yield return elem; }
                if (DisclaimerElement != null) yield return DisclaimerElement;
                if (Scoring != null) yield return Scoring;
                if (CompositeScoring != null) yield return CompositeScoring;
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                if (RiskAdjustmentElement != null) yield return RiskAdjustmentElement;
                if (RateAggregationElement != null) yield return RateAggregationElement;
                if (RationaleElement != null) yield return RationaleElement;
                if (ClinicalRecommendationStatementElement != null) yield return ClinicalRecommendationStatementElement;
                if (ImprovementNotationElement != null) yield return ImprovementNotationElement;
                foreach (var elem in DefinitionElement) { if (elem != null) yield return elem; }
                if (GuidanceElement != null) yield return GuidanceElement;
                foreach (var elem in Group) { if (elem != null) yield return elem; }
                foreach (var elem in SupplementalData) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (SubtitleElement != null) yield return new ElementValue("subtitle", SubtitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (PurposeElement != null) yield return new ElementValue("purpose", PurposeElement);
                if (UsageElement != null) yield return new ElementValue("usage", UsageElement);
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                if (ApprovalDateElement != null) yield return new ElementValue("approvalDate", ApprovalDateElement);
                if (LastReviewDateElement != null) yield return new ElementValue("lastReviewDate", LastReviewDateElement);
                if (EffectivePeriod != null) yield return new ElementValue("effectivePeriod", EffectivePeriod);
                foreach (var elem in Topic) { if (elem != null) yield return new ElementValue("topic", elem); }
                foreach (var elem in Author) { if (elem != null) yield return new ElementValue("author", elem); }
                foreach (var elem in Editor) { if (elem != null) yield return new ElementValue("editor", elem); }
                foreach (var elem in Reviewer) { if (elem != null) yield return new ElementValue("reviewer", elem); }
                foreach (var elem in Endorser) { if (elem != null) yield return new ElementValue("endorser", elem); }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return new ElementValue("relatedArtifact", elem); }
                foreach (var elem in LibraryElement) { if (elem != null) yield return new ElementValue("library", elem); }
                if (DisclaimerElement != null) yield return new ElementValue("disclaimer", DisclaimerElement);
                if (Scoring != null) yield return new ElementValue("scoring", Scoring);
                if (CompositeScoring != null) yield return new ElementValue("compositeScoring", CompositeScoring);
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                if (RiskAdjustmentElement != null) yield return new ElementValue("riskAdjustment", RiskAdjustmentElement);
                if (RateAggregationElement != null) yield return new ElementValue("rateAggregation", RateAggregationElement);
                if (RationaleElement != null) yield return new ElementValue("rationale", RationaleElement);
                if (ClinicalRecommendationStatementElement != null) yield return new ElementValue("clinicalRecommendationStatement", ClinicalRecommendationStatementElement);
                if (ImprovementNotationElement != null) yield return new ElementValue("improvementNotation", ImprovementNotationElement);
                foreach (var elem in DefinitionElement) { if (elem != null) yield return new ElementValue("definition", elem); }
                if (GuidanceElement != null) yield return new ElementValue("guidance", GuidanceElement);
                foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", elem); }
                foreach (var elem in SupplementalData) { if (elem != null) yield return new ElementValue("supplementalData", elem); }
            }
        }

    }

}
