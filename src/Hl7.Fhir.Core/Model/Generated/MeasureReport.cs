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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Results of a measure evaluation
    /// </summary>
    [FhirType("MeasureReport", IsResource=true)]
    [DataContract]
    public partial class MeasureReport : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MeasureReport; } }
        [NotMapped]
        public override string TypeName { get { return "MeasureReport"; } }

        /// <summary>
        /// The status of the measure report.
        /// (url: http://hl7.org/fhir/ValueSet/measure-report-status)
        /// </summary>
        [FhirEnumeration("MeasureReportStatus")]
        public enum MeasureReportStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/measure-report-status)
            /// </summary>
            [EnumLiteral("complete", "http://hl7.org/fhir/measure-report-status"), Description("Complete")]
            Complete,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/measure-report-status)
            /// </summary>
            [EnumLiteral("pending", "http://hl7.org/fhir/measure-report-status"), Description("Pending")]
            Pending,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/measure-report-status)
            /// </summary>
            [EnumLiteral("error", "http://hl7.org/fhir/measure-report-status"), Description("Error")]
            Error,
        }

        /// <summary>
        /// The type of the measure report.
        /// (url: http://hl7.org/fhir/ValueSet/measure-report-type)
        /// </summary>
        [FhirEnumeration("MeasureReportType")]
        public enum MeasureReportType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/measure-report-type)
            /// </summary>
            [EnumLiteral("individual", "http://hl7.org/fhir/measure-report-type"), Description("Individual")]
            Individual,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/measure-report-type)
            /// </summary>
            [EnumLiteral("subject-list", "http://hl7.org/fhir/measure-report-type"), Description("Subject List")]
            SubjectList,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/measure-report-type)
            /// </summary>
            [EnumLiteral("summary", "http://hl7.org/fhir/measure-report-type"), Description("Summary")]
            Summary,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/measure-report-type)
            /// </summary>
            [EnumLiteral("data-collection", "http://hl7.org/fhir/measure-report-type"), Description("Data Collection")]
            DataCollection,
        }


        [FhirType("GroupComponent")]
        [DataContract]
        public partial class GroupComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GroupComponent"; } }

            /// <summary>
            /// Meaning of the group
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// The populations in the group
            /// </summary>
            [FhirElement("population", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PopulationComponent> Population
            {
                get { if (_population==null) _population = new List<PopulationComponent>(); return _population; }
                set { _population = value; OnPropertyChanged("Population"); }
            }

            private List<PopulationComponent> _population;

            /// <summary>
            /// What score this group achieved
            /// </summary>
            [FhirElement("measureScore", InSummary=true, Order=60)]
            [DataMember]
            public Quantity MeasureScore
            {
                get { return _measureScore; }
                set { _measureScore = value; OnPropertyChanged("MeasureScore"); }
            }

            private Quantity _measureScore;

            /// <summary>
            /// Stratification results
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
                    if (Population != null) dest.Population = new List<PopulationComponent>(Population.DeepCopy());
                    if (MeasureScore != null) dest.MeasureScore = (Quantity)MeasureScore.DeepCopy();
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
                if ( !DeepComparable.Matches(Population, otherT.Population)) return false;
                if (!DeepComparable.Matches(MeasureScore, otherT.MeasureScore)) return false;
                if ( !DeepComparable.Matches(Stratifier, otherT.Stratifier)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GroupComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Population, otherT.Population)) return false;
                if (!DeepComparable.IsExactly(MeasureScore, otherT.MeasureScore)) return false;
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
                    foreach (var elem in Population) { if (elem != null) yield return elem; }
                    if (MeasureScore != null) yield return MeasureScore;
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
                    foreach (var elem in Population) { if (elem != null) yield return new ElementValue("population", elem); }
                    if (MeasureScore != null) yield return new ElementValue("measureScore", MeasureScore);
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
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Size of the population
            /// </summary>
            [FhirElement("count", Order=50)]
            [DataMember]
            public Integer CountElement
            {
                get { return _countElement; }
                set { _countElement = value; OnPropertyChanged("CountElement"); }
            }

            private Integer _countElement;

            /// <summary>
            /// Size of the population
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Count
            {
                get { return CountElement != null ? CountElement.Value : null; }
                set
                {
                    if (value == null)
                        CountElement = null;
                    else
                        CountElement = new Integer(value);
                    OnPropertyChanged("Count");
                }
            }

            /// <summary>
            /// For subject-list reports, the subject results in this population
            /// </summary>
            [FhirElement("subjectResults", Order=60)]
            [References("List")]
            [DataMember]
            public ResourceReference SubjectResults
            {
                get { return _subjectResults; }
                set { _subjectResults = value; OnPropertyChanged("SubjectResults"); }
            }

            private ResourceReference _subjectResults;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PopulationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (CountElement != null) dest.CountElement = (Integer)CountElement.DeepCopy();
                    if (SubjectResults != null) dest.SubjectResults = (ResourceReference)SubjectResults.DeepCopy();
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
                if (!DeepComparable.Matches(CountElement, otherT.CountElement)) return false;
                if (!DeepComparable.Matches(SubjectResults, otherT.SubjectResults)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(CountElement, otherT.CountElement)) return false;
                if (!DeepComparable.IsExactly(SubjectResults, otherT.SubjectResults)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (CountElement != null) yield return CountElement;
                    if (SubjectResults != null) yield return SubjectResults;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (CountElement != null) yield return new ElementValue("count", CountElement);
                    if (SubjectResults != null) yield return new ElementValue("subjectResults", SubjectResults);
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
            /// What stratifier of the group
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
            /// Stratum results, one for each unique value in the stratifier
            /// </summary>
            [FhirElement("stratum", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StratifierGroupComponent> Stratum
            {
                get { if (_stratum==null) _stratum = new List<StratifierGroupComponent>(); return _stratum; }
                set { _stratum = value; OnPropertyChanged("Stratum"); }
            }

            private List<StratifierGroupComponent> _stratum;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StratifierComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Stratum != null) dest.Stratum = new List<StratifierGroupComponent>(Stratum.DeepCopy());
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
                if ( !DeepComparable.Matches(Stratum, otherT.Stratum)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StratifierComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Stratum, otherT.Stratum)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in Stratum) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    foreach (var elem in Stratum) { if (elem != null) yield return new ElementValue("stratum", elem); }
                }
            }


        }


        [FhirType("StratifierGroupComponent")]
        [DataContract]
        public partial class StratifierGroupComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StratifierGroupComponent"; } }

            /// <summary>
            /// The stratum value, e.g. male
            /// </summary>
            [FhirElement("value", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private CodeableConcept _value;

            /// <summary>
            /// Population results in this stratum
            /// </summary>
            [FhirElement("population", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StratifierGroupPopulationComponent> Population
            {
                get { if (_population==null) _population = new List<StratifierGroupPopulationComponent>(); return _population; }
                set { _population = value; OnPropertyChanged("Population"); }
            }

            private List<StratifierGroupPopulationComponent> _population;

            /// <summary>
            /// What score this stratum achieved
            /// </summary>
            [FhirElement("measureScore", Order=60)]
            [DataMember]
            public Quantity MeasureScore
            {
                get { return _measureScore; }
                set { _measureScore = value; OnPropertyChanged("MeasureScore"); }
            }

            private Quantity _measureScore;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StratifierGroupComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Value != null) dest.Value = (CodeableConcept)Value.DeepCopy();
                    if (Population != null) dest.Population = new List<StratifierGroupPopulationComponent>(Population.DeepCopy());
                    if (MeasureScore != null) dest.MeasureScore = (Quantity)MeasureScore.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StratifierGroupComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StratifierGroupComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;
                if ( !DeepComparable.Matches(Population, otherT.Population)) return false;
                if (!DeepComparable.Matches(MeasureScore, otherT.MeasureScore)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StratifierGroupComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if (!DeepComparable.IsExactly(Population, otherT.Population)) return false;
                if (!DeepComparable.IsExactly(MeasureScore, otherT.MeasureScore)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Value != null) yield return Value;
                    foreach (var elem in Population) { if (elem != null) yield return elem; }
                    if (MeasureScore != null) yield return MeasureScore;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Value != null) yield return new ElementValue("value", Value);
                    foreach (var elem in Population) { if (elem != null) yield return new ElementValue("population", elem); }
                    if (MeasureScore != null) yield return new ElementValue("measureScore", MeasureScore);
                }
            }


        }


        [FhirType("StratifierGroupPopulationComponent")]
        [DataContract]
        public partial class StratifierGroupPopulationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StratifierGroupPopulationComponent"; } }

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
            /// Size of the population
            /// </summary>
            [FhirElement("count", Order=50)]
            [DataMember]
            public Integer CountElement
            {
                get { return _countElement; }
                set { _countElement = value; OnPropertyChanged("CountElement"); }
            }

            private Integer _countElement;

            /// <summary>
            /// Size of the population
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Count
            {
                get { return CountElement != null ? CountElement.Value : null; }
                set
                {
                    if (value == null)
                        CountElement = null;
                    else
                        CountElement = new Integer(value);
                    OnPropertyChanged("Count");
                }
            }

            /// <summary>
            /// For subject-list reports, the subject results in this population
            /// </summary>
            [FhirElement("subjectResults", Order=60)]
            [References("List")]
            [DataMember]
            public ResourceReference SubjectResults
            {
                get { return _subjectResults; }
                set { _subjectResults = value; OnPropertyChanged("SubjectResults"); }
            }

            private ResourceReference _subjectResults;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StratifierGroupPopulationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (CountElement != null) dest.CountElement = (Integer)CountElement.DeepCopy();
                    if (SubjectResults != null) dest.SubjectResults = (ResourceReference)SubjectResults.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StratifierGroupPopulationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StratifierGroupPopulationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(CountElement, otherT.CountElement)) return false;
                if (!DeepComparable.Matches(SubjectResults, otherT.SubjectResults)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StratifierGroupPopulationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(CountElement, otherT.CountElement)) return false;
                if (!DeepComparable.IsExactly(SubjectResults, otherT.SubjectResults)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (CountElement != null) yield return CountElement;
                    if (SubjectResults != null) yield return SubjectResults;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (CountElement != null) yield return new ElementValue("count", CountElement);
                    if (SubjectResults != null) yield return new ElementValue("subjectResults", SubjectResults);
                }
            }


        }


        /// <summary>
        /// Additional identifier for the MeasureReport
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
        /// complete | pending | error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MeasureReportStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MeasureReportStatus> _statusElement;

        /// <summary>
        /// complete | pending | error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MeasureReportStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MeasureReportStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// individual | subject-list | summary | data-collection
        /// </summary>
        [FhirElement("type", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MeasureReportType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<MeasureReportType> _typeElement;

        /// <summary>
        /// individual | subject-list | summary | data-collection
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MeasureReportType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<MeasureReportType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// What measure was calculated
        /// </summary>
        [FhirElement("measure", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Canonical MeasureElement
        {
            get { return _measureElement; }
            set { _measureElement = value; OnPropertyChanged("MeasureElement"); }
        }

        private Canonical _measureElement;

        /// <summary>
        /// What measure was calculated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Measure
        {
            get { return MeasureElement != null ? MeasureElement.Value : null; }
            set
            {
                if (value == null)
                    MeasureElement = null;
                else
                    MeasureElement = new Canonical(value);
                OnPropertyChanged("Measure");
            }
        }

        /// <summary>
        /// What individual(s) the report is for
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=130)]
        [References("Patient","Practitioner","PractitionerRole","Location","Device","RelatedPerson","Group")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// When the report was generated
        /// </summary>
        [FhirElement("date", InSummary=true, Order=140)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// When the report was generated
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
        /// Who is reporting the data
        /// </summary>
        [FhirElement("reporter", InSummary=true, Order=150)]
        [References("Practitioner","PractitionerRole","Location","Organization")]
        [DataMember]
        public ResourceReference Reporter
        {
            get { return _reporter; }
            set { _reporter = value; OnPropertyChanged("Reporter"); }
        }

        private ResourceReference _reporter;

        /// <summary>
        /// What period the report covers
        /// </summary>
        [FhirElement("period", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// increase | decrease
        /// </summary>
        [FhirElement("improvementNotation", InSummary=true, Order=170)]
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
        /// Measure results for each group
        /// </summary>
        [FhirElement("group", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GroupComponent> Group
        {
            get { if (_group==null) _group = new List<GroupComponent>(); return _group; }
            set { _group = value; OnPropertyChanged("Group"); }
        }

        private List<GroupComponent> _group;

        /// <summary>
        /// What data was used to calculate the measure score
        /// </summary>
        [FhirElement("evaluatedResource", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> EvaluatedResource
        {
            get { if (_evaluatedResource==null) _evaluatedResource = new List<ResourceReference>(); return _evaluatedResource; }
            set { _evaluatedResource = value; OnPropertyChanged("EvaluatedResource"); }
        }

        private List<ResourceReference> _evaluatedResource;


        public static ElementDefinition.ConstraintComponent MeasureReport_MRP_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(type != 'data-collection') or group.exists().not()",
            Key = "mrp-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Measure Reports used for data collection SHALL NOT communicate group and score information",
            Xpath = "not(f:kind/@value='data-collection') or not(exists(f:group))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(MeasureReport_MRP_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MeasureReport;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<MeasureReportStatus>)StatusElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = (Code<MeasureReportType>)TypeElement.DeepCopy();
                if (MeasureElement != null) dest.MeasureElement = (Canonical)MeasureElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Reporter != null) dest.Reporter = (ResourceReference)Reporter.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (ImprovementNotationElement != null) dest.ImprovementNotationElement = (Code<MeasureImprovementNotation>)ImprovementNotationElement.DeepCopy();
                if (Group != null) dest.Group = new List<GroupComponent>(Group.DeepCopy());
                if (EvaluatedResource != null) dest.EvaluatedResource = new List<ResourceReference>(EvaluatedResource.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MeasureReport());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MeasureReport;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(MeasureElement, otherT.MeasureElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Reporter, otherT.Reporter)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(ImprovementNotationElement, otherT.ImprovementNotationElement)) return false;
            if ( !DeepComparable.Matches(Group, otherT.Group)) return false;
            if ( !DeepComparable.Matches(EvaluatedResource, otherT.EvaluatedResource)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MeasureReport;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(MeasureElement, otherT.MeasureElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Reporter, otherT.Reporter)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(ImprovementNotationElement, otherT.ImprovementNotationElement)) return false;
            if (!DeepComparable.IsExactly(Group, otherT.Group)) return false;
            if (!DeepComparable.IsExactly(EvaluatedResource, otherT.EvaluatedResource)) return false;

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
                if (TypeElement != null) yield return TypeElement;
                if (MeasureElement != null) yield return MeasureElement;
                if (Subject != null) yield return Subject;
                if (DateElement != null) yield return DateElement;
                if (Reporter != null) yield return Reporter;
                if (Period != null) yield return Period;
                if (ImprovementNotationElement != null) yield return ImprovementNotationElement;
                foreach (var elem in Group) { if (elem != null) yield return elem; }
                foreach (var elem in EvaluatedResource) { if (elem != null) yield return elem; }
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
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (MeasureElement != null) yield return new ElementValue("measure", MeasureElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Reporter != null) yield return new ElementValue("reporter", Reporter);
                if (Period != null) yield return new ElementValue("period", Period);
                if (ImprovementNotationElement != null) yield return new ElementValue("improvementNotation", ImprovementNotationElement);
                foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", elem); }
                foreach (var elem in EvaluatedResource) { if (elem != null) yield return new ElementValue("evaluatedResource", elem); }
            }
        }

    }

}
