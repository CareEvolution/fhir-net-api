﻿using System;
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
        public partial class GroupComponent : BackboneElement
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
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    foreach (var elem in Population) { if (elem != null) yield return new ElementValue("population", true, elem); }
                    foreach (var elem in Stratifier) { if (elem != null) yield return new ElementValue("stratifier", true, elem); }
                }
            }


        }


        [FhirType("PopulationComponent")]
        [DataContract]
        public partial class PopulationComponent : BackboneElement
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
            /// The name of a valid referenced CQL expression (may be namespaced) that defines this population criteria
            /// </summary>
            [FhirElement("criteria", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString CriteriaElement
            {
                get { return _criteriaElement; }
                set { _criteriaElement = value; OnPropertyChanged("CriteriaElement"); }
            }

            private FhirString _criteriaElement;

            /// <summary>
            /// The name of a valid referenced CQL expression (may be namespaced) that defines this population criteria
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Criteria
            {
                get { return CriteriaElement != null ? CriteriaElement.Value : null; }
                set
                {
                    if (value == null)
                        CriteriaElement = null;
                    else
                        CriteriaElement = new FhirString(value);
                    OnPropertyChanged("Criteria");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PopulationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (CriteriaElement != null) dest.CriteriaElement = (FhirString)CriteriaElement.DeepCopy();
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
                if (!DeepComparable.Matches(CriteriaElement, otherT.CriteriaElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(CriteriaElement, otherT.CriteriaElement)) return false;

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
                    if (CriteriaElement != null) yield return CriteriaElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (CriteriaElement != null) yield return new ElementValue("criteria", false, CriteriaElement);
                }
            }


        }


        [FhirType("StratifierComponent")]
        [DataContract]
        public partial class StratifierComponent : BackboneElement
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
            [DataMember]
            public FhirString CriteriaElement
            {
                get { return _criteriaElement; }
                set { _criteriaElement = value; OnPropertyChanged("CriteriaElement"); }
            }

            private FhirString _criteriaElement;

            /// <summary>
            /// How the measure should be stratified
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Criteria
            {
                get { return CriteriaElement != null ? CriteriaElement.Value : null; }
                set
                {
                    if (value == null)
                        CriteriaElement = null;
                    else
                        CriteriaElement = new FhirString(value);
                    OnPropertyChanged("Criteria");
                }
            }

            /// <summary>
            /// Path to the stratifier
            /// </summary>
            [FhirElement("path", Order=70)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// Path to the stratifier
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StratifierComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (CriteriaElement != null) dest.CriteriaElement = (FhirString)CriteriaElement.DeepCopy();
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
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
                if (!DeepComparable.Matches(CriteriaElement, otherT.CriteriaElement)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StratifierComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(CriteriaElement, otherT.CriteriaElement)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;

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
                    if (CriteriaElement != null) yield return CriteriaElement;
                    if (PathElement != null) yield return PathElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (CriteriaElement != null) yield return new ElementValue("criteria", false, CriteriaElement);
                    if (PathElement != null) yield return new ElementValue("path", false, PathElement);
                }
            }


        }


        [FhirType("SupplementalDataComponent")]
        [DataContract]
        public partial class SupplementalDataComponent : BackboneElement
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
            [DataMember]
            public FhirString CriteriaElement
            {
                get { return _criteriaElement; }
                set { _criteriaElement = value; OnPropertyChanged("CriteriaElement"); }
            }

            private FhirString _criteriaElement;

            /// <summary>
            /// Expression describing additional data to be reported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Criteria
            {
                get { return CriteriaElement != null ? CriteriaElement.Value : null; }
                set
                {
                    if (value == null)
                        CriteriaElement = null;
                    else
                        CriteriaElement = new FhirString(value);
                    OnPropertyChanged("Criteria");
                }
            }

            /// <summary>
            /// Path to the supplemental data element
            /// </summary>
            [FhirElement("path", Order=80)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// Path to the supplemental data element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SupplementalDataComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Usage != null) dest.Usage = new List<CodeableConcept>(Usage.DeepCopy());
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (CriteriaElement != null) dest.CriteriaElement = (FhirString)CriteriaElement.DeepCopy();
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
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
                if (!DeepComparable.Matches(CriteriaElement, otherT.CriteriaElement)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;

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
                if (!DeepComparable.IsExactly(CriteriaElement, otherT.CriteriaElement)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;

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
                    if (CriteriaElement != null) yield return CriteriaElement;
                    if (PathElement != null) yield return PathElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    foreach (var elem in Usage) { if (elem != null) yield return new ElementValue("usage", true, elem); }
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (CriteriaElement != null) yield return new ElementValue("criteria", false, CriteriaElement);
                    if (PathElement != null) yield return new ElementValue("path", false, PathElement);
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
        public Markdown Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }

        private Markdown _description;

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
        public Markdown Purpose
        {
            get { return _purpose; }
            set { _purpose = value; OnPropertyChanged("Purpose"); }
        }

        private Markdown _purpose;

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
        public Markdown Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        private Markdown _copyright;

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
        /// A content contributor
        /// </summary>
        [FhirElement("contributor", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Contributor> Contributor
        {
            get { if (_contributor==null) _contributor = new List<Contributor>(); return _contributor; }
            set { _contributor = value; OnPropertyChanged("Contributor"); }
        }

        private List<Contributor> _contributor;

        /// <summary>
        /// Additional documentation, citations, etc.
        /// </summary>
        [FhirElement("relatedArtifact", Order=320)]
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
        [FhirElement("library", Order=330)]
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
        [FhirElement("disclaimer", InSummary=true, Order=340)]
        [DataMember]
        public Markdown Disclaimer
        {
            get { return _disclaimer; }
            set { _disclaimer = value; OnPropertyChanged("Disclaimer"); }
        }

        private Markdown _disclaimer;

        /// <summary>
        /// proportion | ratio | continuous-variable | cohort
        /// </summary>
        [FhirElement("scoring", InSummary=true, Order=350)]
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
        [FhirElement("compositeScoring", InSummary=true, Order=360)]
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
        [FhirElement("type", InSummary=true, Order=370)]
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
        [FhirElement("riskAdjustment", InSummary=true, Order=380)]
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
        [FhirElement("rateAggregation", InSummary=true, Order=390)]
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
        /// Why does this measure exist
        /// </summary>
        [FhirElement("rationale", InSummary=true, Order=400)]
        [DataMember]
        public Markdown Rationale
        {
            get { return _rationale; }
            set { _rationale = value; OnPropertyChanged("Rationale"); }
        }

        private Markdown _rationale;

        /// <summary>
        /// Summary of clinical guidelines
        /// </summary>
        [FhirElement("clinicalRecommendationStatement", InSummary=true, Order=410)]
        [DataMember]
        public Markdown ClinicalRecommendationStatement
        {
            get { return _clinicalRecommendationStatement; }
            set { _clinicalRecommendationStatement = value; OnPropertyChanged("ClinicalRecommendationStatement"); }
        }

        private Markdown _clinicalRecommendationStatement;

        /// <summary>
        /// Improvement notation for the measure, e.g. higher score indicates better quality
        /// </summary>
        [FhirElement("improvementNotation", InSummary=true, Order=420)]
        [DataMember]
        public FhirString ImprovementNotationElement
        {
            get { return _improvementNotationElement; }
            set { _improvementNotationElement = value; OnPropertyChanged("ImprovementNotationElement"); }
        }

        private FhirString _improvementNotationElement;

        /// <summary>
        /// Improvement notation for the measure, e.g. higher score indicates better quality
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ImprovementNotation
        {
            get { return ImprovementNotationElement != null ? ImprovementNotationElement.Value : null; }
            set
            {
                if (value == null)
                    ImprovementNotationElement = null;
                else
                    ImprovementNotationElement = new FhirString(value);
                OnPropertyChanged("ImprovementNotation");
            }
        }

        /// <summary>
        /// Defined terms used in the measure documentation
        /// </summary>
        [FhirElement("definition", InSummary=true, Order=430)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Markdown> Definition
        {
            get { if (_definition==null) _definition = new List<Markdown>(); return _definition; }
            set { _definition = value; OnPropertyChanged("Definition"); }
        }

        private List<Markdown> _definition;

        /// <summary>
        /// Additional guidance for implementers
        /// </summary>
        [FhirElement("guidance", InSummary=true, Order=440)]
        [DataMember]
        public Markdown Guidance
        {
            get { return _guidance; }
            set { _guidance = value; OnPropertyChanged("Guidance"); }
        }

        private Markdown _guidance;

        /// <summary>
        /// The measure set, e.g. Preventive Care and Screening
        /// </summary>
        [FhirElement("set", InSummary=true, Order=450)]
        [DataMember]
        public FhirString SetElement
        {
            get { return _setElement; }
            set { _setElement = value; OnPropertyChanged("SetElement"); }
        }

        private FhirString _setElement;

        /// <summary>
        /// The measure set, e.g. Preventive Care and Screening
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Set
        {
            get { return SetElement != null ? SetElement.Value : null; }
            set
            {
                if (value == null)
                    SetElement = null;
                else
                    SetElement = new FhirString(value);
                OnPropertyChanged("Set");
            }
        }

        /// <summary>
        /// Population criteria group
        /// </summary>
        [FhirElement("group", Order=460)]
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
        [FhirElement("supplementalData", Order=470)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SupplementalDataComponent> SupplementalData
        {
            get { if (_supplementalData==null) _supplementalData = new List<SupplementalDataComponent>(); return _supplementalData; }
            set { _supplementalData = value; OnPropertyChanged("SupplementalData"); }
        }

        private List<SupplementalDataComponent> _supplementalData;


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
                if (Description != null) dest.Description = (Markdown)Description.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (Purpose != null) dest.Purpose = (Markdown)Purpose.DeepCopy();
                if (UsageElement != null) dest.UsageElement = (FhirString)UsageElement.DeepCopy();
                if (Copyright != null) dest.Copyright = (Markdown)Copyright.DeepCopy();
                if (ApprovalDateElement != null) dest.ApprovalDateElement = (Date)ApprovalDateElement.DeepCopy();
                if (LastReviewDateElement != null) dest.LastReviewDateElement = (Date)LastReviewDateElement.DeepCopy();
                if (EffectivePeriod != null) dest.EffectivePeriod = (Period)EffectivePeriod.DeepCopy();
                if (Topic != null) dest.Topic = new List<CodeableConcept>(Topic.DeepCopy());
                if (Contributor != null) dest.Contributor = new List<Contributor>(Contributor.DeepCopy());
                if (RelatedArtifact != null) dest.RelatedArtifact = new List<RelatedArtifact>(RelatedArtifact.DeepCopy());
                if (LibraryElement != null) dest.LibraryElement = new List<Canonical>(LibraryElement.DeepCopy());
                if (Disclaimer != null) dest.Disclaimer = (Markdown)Disclaimer.DeepCopy();
                if (Scoring != null) dest.Scoring = (CodeableConcept)Scoring.DeepCopy();
                if (CompositeScoring != null) dest.CompositeScoring = (CodeableConcept)CompositeScoring.DeepCopy();
                if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                if (RiskAdjustmentElement != null) dest.RiskAdjustmentElement = (FhirString)RiskAdjustmentElement.DeepCopy();
                if (RateAggregationElement != null) dest.RateAggregationElement = (FhirString)RateAggregationElement.DeepCopy();
                if (Rationale != null) dest.Rationale = (Markdown)Rationale.DeepCopy();
                if (ClinicalRecommendationStatement != null) dest.ClinicalRecommendationStatement = (Markdown)ClinicalRecommendationStatement.DeepCopy();
                if (ImprovementNotationElement != null) dest.ImprovementNotationElement = (FhirString)ImprovementNotationElement.DeepCopy();
                if (Definition != null) dest.Definition = new List<Markdown>(Definition.DeepCopy());
                if (Guidance != null) dest.Guidance = (Markdown)Guidance.DeepCopy();
                if (SetElement != null) dest.SetElement = (FhirString)SetElement.DeepCopy();
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
            if (!DeepComparable.Matches(Description, otherT.Description)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.Matches(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.Matches(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.Matches(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.Matches(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.Matches(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if ( !DeepComparable.Matches(Topic, otherT.Topic)) return false;
            if ( !DeepComparable.Matches(Contributor, otherT.Contributor)) return false;
            if ( !DeepComparable.Matches(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if ( !DeepComparable.Matches(LibraryElement, otherT.LibraryElement)) return false;
            if (!DeepComparable.Matches(Disclaimer, otherT.Disclaimer)) return false;
            if (!DeepComparable.Matches(Scoring, otherT.Scoring)) return false;
            if (!DeepComparable.Matches(CompositeScoring, otherT.CompositeScoring)) return false;
            if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(RiskAdjustmentElement, otherT.RiskAdjustmentElement)) return false;
            if (!DeepComparable.Matches(RateAggregationElement, otherT.RateAggregationElement)) return false;
            if (!DeepComparable.Matches(Rationale, otherT.Rationale)) return false;
            if (!DeepComparable.Matches(ClinicalRecommendationStatement, otherT.ClinicalRecommendationStatement)) return false;
            if (!DeepComparable.Matches(ImprovementNotationElement, otherT.ImprovementNotationElement)) return false;
            if ( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if (!DeepComparable.Matches(Guidance, otherT.Guidance)) return false;
            if (!DeepComparable.Matches(SetElement, otherT.SetElement)) return false;
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
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.IsExactly(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.IsExactly(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.IsExactly(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.IsExactly(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if (!DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
            if (!DeepComparable.IsExactly(Contributor, otherT.Contributor)) return false;
            if (!DeepComparable.IsExactly(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if (!DeepComparable.IsExactly(LibraryElement, otherT.LibraryElement)) return false;
            if (!DeepComparable.IsExactly(Disclaimer, otherT.Disclaimer)) return false;
            if (!DeepComparable.IsExactly(Scoring, otherT.Scoring)) return false;
            if (!DeepComparable.IsExactly(CompositeScoring, otherT.CompositeScoring)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(RiskAdjustmentElement, otherT.RiskAdjustmentElement)) return false;
            if (!DeepComparable.IsExactly(RateAggregationElement, otherT.RateAggregationElement)) return false;
            if (!DeepComparable.IsExactly(Rationale, otherT.Rationale)) return false;
            if (!DeepComparable.IsExactly(ClinicalRecommendationStatement, otherT.ClinicalRecommendationStatement)) return false;
            if (!DeepComparable.IsExactly(ImprovementNotationElement, otherT.ImprovementNotationElement)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(Guidance, otherT.Guidance)) return false;
            if (!DeepComparable.IsExactly(SetElement, otherT.SetElement)) return false;
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
                if (Description != null) yield return Description;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (Purpose != null) yield return Purpose;
                if (UsageElement != null) yield return UsageElement;
                if (Copyright != null) yield return Copyright;
                if (ApprovalDateElement != null) yield return ApprovalDateElement;
                if (LastReviewDateElement != null) yield return LastReviewDateElement;
                if (EffectivePeriod != null) yield return EffectivePeriod;
                foreach (var elem in Topic) { if (elem != null) yield return elem; }
                foreach (var elem in Contributor) { if (elem != null) yield return elem; }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return elem; }
                foreach (var elem in LibraryElement) { if (elem != null) yield return elem; }
                if (Disclaimer != null) yield return Disclaimer;
                if (Scoring != null) yield return Scoring;
                if (CompositeScoring != null) yield return CompositeScoring;
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                if (RiskAdjustmentElement != null) yield return RiskAdjustmentElement;
                if (RateAggregationElement != null) yield return RateAggregationElement;
                if (Rationale != null) yield return Rationale;
                if (ClinicalRecommendationStatement != null) yield return ClinicalRecommendationStatement;
                if (ImprovementNotationElement != null) yield return ImprovementNotationElement;
                foreach (var elem in Definition) { if (elem != null) yield return elem; }
                if (Guidance != null) yield return Guidance;
                if (SetElement != null) yield return SetElement;
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
                if (UrlElement != null) yield return new ElementValue("url", false, UrlElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (VersionElement != null) yield return new ElementValue("version", false, VersionElement);
                if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                if (TitleElement != null) yield return new ElementValue("title", false, TitleElement);
                if (SubtitleElement != null) yield return new ElementValue("subtitle", false, SubtitleElement);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", false, ExperimentalElement);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", false, PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", true, elem); }
                if (Description != null) yield return new ElementValue("description", false, Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", true, elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", true, elem); }
                if (Purpose != null) yield return new ElementValue("purpose", false, Purpose);
                if (UsageElement != null) yield return new ElementValue("usage", false, UsageElement);
                if (Copyright != null) yield return new ElementValue("copyright", false, Copyright);
                if (ApprovalDateElement != null) yield return new ElementValue("approvalDate", false, ApprovalDateElement);
                if (LastReviewDateElement != null) yield return new ElementValue("lastReviewDate", false, LastReviewDateElement);
                if (EffectivePeriod != null) yield return new ElementValue("effectivePeriod", false, EffectivePeriod);
                foreach (var elem in Topic) { if (elem != null) yield return new ElementValue("topic", true, elem); }
                foreach (var elem in Contributor) { if (elem != null) yield return new ElementValue("contributor", true, elem); }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return new ElementValue("relatedArtifact", true, elem); }
                foreach (var elem in LibraryElement) { if (elem != null) yield return new ElementValue("library", true, elem); }
                if (Disclaimer != null) yield return new ElementValue("disclaimer", false, Disclaimer);
                if (Scoring != null) yield return new ElementValue("scoring", false, Scoring);
                if (CompositeScoring != null) yield return new ElementValue("compositeScoring", false, CompositeScoring);
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", true, elem); }
                if (RiskAdjustmentElement != null) yield return new ElementValue("riskAdjustment", false, RiskAdjustmentElement);
                if (RateAggregationElement != null) yield return new ElementValue("rateAggregation", false, RateAggregationElement);
                if (Rationale != null) yield return new ElementValue("rationale", false, Rationale);
                if (ClinicalRecommendationStatement != null) yield return new ElementValue("clinicalRecommendationStatement", false, ClinicalRecommendationStatement);
                if (ImprovementNotationElement != null) yield return new ElementValue("improvementNotation", false, ImprovementNotationElement);
                foreach (var elem in Definition) { if (elem != null) yield return new ElementValue("definition", true, elem); }
                if (Guidance != null) yield return new ElementValue("guidance", false, Guidance);
                if (SetElement != null) yield return new ElementValue("set", false, SetElement);
                foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", true, elem); }
                foreach (var elem in SupplementalData) { if (elem != null) yield return new ElementValue("supplementalData", true, elem); }
            }
        }

    }

}
