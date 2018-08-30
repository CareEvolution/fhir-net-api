﻿using System;
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
    /// Definition of an observation
    /// </summary>
    [FhirType("ObservationDefinition", IsResource=true)]
    [DataContract]
    public partial class ObservationDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ObservationDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "ObservationDefinition"; } }


        [FhirType("QuantitativeDetailsComponent")]
        [DataContract]
        public partial class QuantitativeDetailsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "QuantitativeDetailsComponent"; } }

            /// <summary>
            /// Customary unit for quantitative results
            /// </summary>
            [FhirElement("customaryUnit", Order=40)]
            [DataMember]
            public Coding CustomaryUnit
            {
                get { return _customaryUnit; }
                set { _customaryUnit = value; OnPropertyChanged("CustomaryUnit"); }
            }

            private Coding _customaryUnit;

            /// <summary>
            /// SI unit for quantitative results
            /// </summary>
            [FhirElement("unit", Order=50)]
            [DataMember]
            public Coding Unit
            {
                get { return _unit; }
                set { _unit = value; OnPropertyChanged("Unit"); }
            }

            private Coding _unit;

            /// <summary>
            /// SI to Customary unit conversion factor
            /// </summary>
            [FhirElement("conversionFactor", Order=60)]
            [DataMember]
            public FhirDecimal ConversionFactorElement
            {
                get { return _conversionFactorElement; }
                set { _conversionFactorElement = value; OnPropertyChanged("ConversionFactorElement"); }
            }

            private FhirDecimal _conversionFactorElement;

            /// <summary>
            /// SI to Customary unit conversion factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? ConversionFactor
            {
                get { return ConversionFactorElement != null ? ConversionFactorElement.Value : null; }
                set
                {
                    if (value == null)
                        ConversionFactorElement = null;
                    else
                        ConversionFactorElement = new FhirDecimal(value);
                    OnPropertyChanged("ConversionFactor");
                }
            }

            /// <summary>
            /// Decimal precision of observation quantitative results
            /// </summary>
            [FhirElement("decimalPrecision", Order=70)]
            [DataMember]
            public Integer DecimalPrecisionElement
            {
                get { return _decimalPrecisionElement; }
                set { _decimalPrecisionElement = value; OnPropertyChanged("DecimalPrecisionElement"); }
            }

            private Integer _decimalPrecisionElement;

            /// <summary>
            /// Decimal precision of observation quantitative results
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? DecimalPrecision
            {
                get { return DecimalPrecisionElement != null ? DecimalPrecisionElement.Value : null; }
                set
                {
                    if (value == null)
                        DecimalPrecisionElement = null;
                    else
                        DecimalPrecisionElement = new Integer(value);
                    OnPropertyChanged("DecimalPrecision");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as QuantitativeDetailsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CustomaryUnit != null) dest.CustomaryUnit = (Coding)CustomaryUnit.DeepCopy();
                    if (Unit != null) dest.Unit = (Coding)Unit.DeepCopy();
                    if (ConversionFactorElement != null) dest.ConversionFactorElement = (FhirDecimal)ConversionFactorElement.DeepCopy();
                    if (DecimalPrecisionElement != null) dest.DecimalPrecisionElement = (Integer)DecimalPrecisionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new QuantitativeDetailsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as QuantitativeDetailsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CustomaryUnit, otherT.CustomaryUnit)) return false;
                if (!DeepComparable.Matches(Unit, otherT.Unit)) return false;
                if (!DeepComparable.Matches(ConversionFactorElement, otherT.ConversionFactorElement)) return false;
                if (!DeepComparable.Matches(DecimalPrecisionElement, otherT.DecimalPrecisionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as QuantitativeDetailsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CustomaryUnit, otherT.CustomaryUnit)) return false;
                if (!DeepComparable.IsExactly(Unit, otherT.Unit)) return false;
                if (!DeepComparable.IsExactly(ConversionFactorElement, otherT.ConversionFactorElement)) return false;
                if (!DeepComparable.IsExactly(DecimalPrecisionElement, otherT.DecimalPrecisionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CustomaryUnit != null) yield return CustomaryUnit;
                    if (Unit != null) yield return Unit;
                    if (ConversionFactorElement != null) yield return ConversionFactorElement;
                    if (DecimalPrecisionElement != null) yield return DecimalPrecisionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CustomaryUnit != null) yield return new ElementValue("customaryUnit", CustomaryUnit);
                    if (Unit != null) yield return new ElementValue("unit", Unit);
                    if (ConversionFactorElement != null) yield return new ElementValue("conversionFactor", ConversionFactorElement);
                    if (DecimalPrecisionElement != null) yield return new ElementValue("decimalPrecision", DecimalPrecisionElement);
                }
            }


        }


        [FhirType("QualifiedIntervalComponent")]
        [DataContract]
        public partial class QualifiedIntervalComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "QualifiedIntervalComponent"; } }

            /// <summary>
            /// The category or type of interval
            /// </summary>
            [FhirElement("category", Order=40)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Low bound of reference range, if relevant
            /// </summary>
            [FhirElement("range", Order=50)]
            [DataMember]
            public Range Range
            {
                get { return _range; }
                set { _range = value; OnPropertyChanged("Range"); }
            }

            private Range _range;

            /// <summary>
            /// Reference range qualifier
            /// </summary>
            [FhirElement("type", Order=60)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Reference range population
            /// </summary>
            [FhirElement("appliesTo", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> AppliesTo
            {
                get { if (_appliesTo==null) _appliesTo = new List<CodeableConcept>(); return _appliesTo; }
                set { _appliesTo = value; OnPropertyChanged("AppliesTo"); }
            }

            private List<CodeableConcept> _appliesTo;

            /// <summary>
            /// Applicable age range, if relevant
            /// </summary>
            [FhirElement("age", Order=80)]
            [DataMember]
            public Range Age
            {
                get { return _age; }
                set { _age = value; OnPropertyChanged("Age"); }
            }

            private Range _age;

            /// <summary>
            /// Applicable gestational age range, if relevant
            /// </summary>
            [FhirElement("gestationalAge", Order=90)]
            [DataMember]
            public Range GestationalAge
            {
                get { return _gestationalAge; }
                set { _gestationalAge = value; OnPropertyChanged("GestationalAge"); }
            }

            private Range _gestationalAge;

            /// <summary>
            /// Condition associated with the reference range
            /// </summary>
            [FhirElement("condition", Order=100)]
            [DataMember]
            public FhirString ConditionElement
            {
                get { return _conditionElement; }
                set { _conditionElement = value; OnPropertyChanged("ConditionElement"); }
            }

            private FhirString _conditionElement;

            /// <summary>
            /// Condition associated with the reference range
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Condition
            {
                get { return ConditionElement != null ? ConditionElement.Value : null; }
                set
                {
                    if (value == null)
                        ConditionElement = null;
                    else
                        ConditionElement = new FhirString(value);
                    OnPropertyChanged("Condition");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as QualifiedIntervalComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Range != null) dest.Range = (Range)Range.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (AppliesTo != null) dest.AppliesTo = new List<CodeableConcept>(AppliesTo.DeepCopy());
                    if (Age != null) dest.Age = (Range)Age.DeepCopy();
                    if (GestationalAge != null) dest.GestationalAge = (Range)GestationalAge.DeepCopy();
                    if (ConditionElement != null) dest.ConditionElement = (FhirString)ConditionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new QualifiedIntervalComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as QualifiedIntervalComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Range, otherT.Range)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(AppliesTo, otherT.AppliesTo)) return false;
                if (!DeepComparable.Matches(Age, otherT.Age)) return false;
                if (!DeepComparable.Matches(GestationalAge, otherT.GestationalAge)) return false;
                if (!DeepComparable.Matches(ConditionElement, otherT.ConditionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as QualifiedIntervalComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Range, otherT.Range)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(AppliesTo, otherT.AppliesTo)) return false;
                if (!DeepComparable.IsExactly(Age, otherT.Age)) return false;
                if (!DeepComparable.IsExactly(GestationalAge, otherT.GestationalAge)) return false;
                if (!DeepComparable.IsExactly(ConditionElement, otherT.ConditionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    if (Range != null) yield return Range;
                    if (Type != null) yield return Type;
                    foreach (var elem in AppliesTo) { if (elem != null) yield return elem; }
                    if (Age != null) yield return Age;
                    if (GestationalAge != null) yield return GestationalAge;
                    if (ConditionElement != null) yield return ConditionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Range != null) yield return new ElementValue("range", Range);
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in AppliesTo) { if (elem != null) yield return new ElementValue("appliesTo", elem); }
                    if (Age != null) yield return new ElementValue("age", Age);
                    if (GestationalAge != null) yield return new ElementValue("gestationalAge", GestationalAge);
                    if (ConditionElement != null) yield return new ElementValue("condition", ConditionElement);
                }
            }


        }


        /// <summary>
        /// Category of observation
        /// </summary>
        [FhirElement("category", InSummary=true, Order=90)]
        [DataMember]
        public Coding Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private Coding _category;

        /// <summary>
        /// Type of observation (code / type)
        /// </summary>
        [FhirElement("code", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Coding Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private Coding _code;

        /// <summary>
        /// Permitted data type for observation value
        /// </summary>
        [FhirElement("permittedDataType", Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> PermittedDataType
        {
            get { if (_permittedDataType==null) _permittedDataType = new List<Coding>(); return _permittedDataType; }
            set { _permittedDataType = value; OnPropertyChanged("PermittedDataType"); }
        }

        private List<Coding> _permittedDataType;

        /// <summary>
        /// Multiple results allowed
        /// </summary>
        [FhirElement("multipleResultsAllowed", Order=120)]
        [DataMember]
        public FhirBoolean MultipleResultsAllowedElement
        {
            get { return _multipleResultsAllowedElement; }
            set { _multipleResultsAllowedElement = value; OnPropertyChanged("MultipleResultsAllowedElement"); }
        }

        private FhirBoolean _multipleResultsAllowedElement;

        /// <summary>
        /// Multiple results allowed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? MultipleResultsAllowed
        {
            get { return MultipleResultsAllowedElement != null ? MultipleResultsAllowedElement.Value : null; }
            set
            {
                if (value == null)
                    MultipleResultsAllowedElement = null;
                else
                    MultipleResultsAllowedElement = new FhirBoolean(value);
                OnPropertyChanged("MultipleResultsAllowed");
            }
        }

        /// <summary>
        /// The method or technique used to perform the observation
        /// </summary>
        [FhirElement("method", Order=130)]
        [DataMember]
        public CodeableConcept Method
        {
            get { return _method; }
            set { _method = value; OnPropertyChanged("Method"); }
        }

        private CodeableConcept _method;

        /// <summary>
        /// Preferred report name
        /// </summary>
        [FhirElement("preferredReportName", Order=140)]
        [DataMember]
        public FhirString PreferredReportNameElement
        {
            get { return _preferredReportNameElement; }
            set { _preferredReportNameElement = value; OnPropertyChanged("PreferredReportNameElement"); }
        }

        private FhirString _preferredReportNameElement;

        /// <summary>
        /// Preferred report name
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PreferredReportName
        {
            get { return PreferredReportNameElement != null ? PreferredReportNameElement.Value : null; }
            set
            {
                if (value == null)
                    PreferredReportNameElement = null;
                else
                    PreferredReportNameElement = new FhirString(value);
                OnPropertyChanged("PreferredReportName");
            }
        }

        /// <summary>
        /// Characteristics of quantitative results
        /// </summary>
        [FhirElement("quantitativeDetails", Order=150)]
        [DataMember]
        public QuantitativeDetailsComponent QuantitativeDetails
        {
            get { return _quantitativeDetails; }
            set { _quantitativeDetails = value; OnPropertyChanged("QuantitativeDetails"); }
        }

        private QuantitativeDetailsComponent _quantitativeDetails;

        /// <summary>
        /// Reference range for observation result
        /// </summary>
        [FhirElement("qualifiedInterval", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<QualifiedIntervalComponent> QualifiedInterval
        {
            get { if (_qualifiedInterval==null) _qualifiedInterval = new List<QualifiedIntervalComponent>(); return _qualifiedInterval; }
            set { _qualifiedInterval = value; OnPropertyChanged("QualifiedInterval"); }
        }

        private List<QualifiedIntervalComponent> _qualifiedInterval;

        /// <summary>
        /// Value set of valid coded values for the observation
        /// </summary>
        [FhirElement("validCodedValueSet", Order=170)]
        [DataMember]
        public FhirUri ValidCodedValueSetElement
        {
            get { return _validCodedValueSetElement; }
            set { _validCodedValueSetElement = value; OnPropertyChanged("ValidCodedValueSetElement"); }
        }

        private FhirUri _validCodedValueSetElement;

        /// <summary>
        /// Value set of valid coded values for the observation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ValidCodedValueSet
        {
            get { return ValidCodedValueSetElement != null ? ValidCodedValueSetElement.Value : null; }
            set
            {
                if (value == null)
                    ValidCodedValueSetElement = null;
                else
                    ValidCodedValueSetElement = new FhirUri(value);
                OnPropertyChanged("ValidCodedValueSet");
            }
        }

        /// <summary>
        /// Value set of normal coded values for the observation
        /// </summary>
        [FhirElement("normalCodedValueSet", Order=180)]
        [DataMember]
        public FhirUri NormalCodedValueSetElement
        {
            get { return _normalCodedValueSetElement; }
            set { _normalCodedValueSetElement = value; OnPropertyChanged("NormalCodedValueSetElement"); }
        }

        private FhirUri _normalCodedValueSetElement;

        /// <summary>
        /// Value set of normal coded values for the observation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string NormalCodedValueSet
        {
            get { return NormalCodedValueSetElement != null ? NormalCodedValueSetElement.Value : null; }
            set
            {
                if (value == null)
                    NormalCodedValueSetElement = null;
                else
                    NormalCodedValueSetElement = new FhirUri(value);
                OnPropertyChanged("NormalCodedValueSet");
            }
        }

        /// <summary>
        /// Value set of abnormal coded values for the observation
        /// </summary>
        [FhirElement("abnormalCodedValueSet", Order=190)]
        [DataMember]
        public FhirUri AbnormalCodedValueSetElement
        {
            get { return _abnormalCodedValueSetElement; }
            set { _abnormalCodedValueSetElement = value; OnPropertyChanged("AbnormalCodedValueSetElement"); }
        }

        private FhirUri _abnormalCodedValueSetElement;

        /// <summary>
        /// Value set of abnormal coded values for the observation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string AbnormalCodedValueSet
        {
            get { return AbnormalCodedValueSetElement != null ? AbnormalCodedValueSetElement.Value : null; }
            set
            {
                if (value == null)
                    AbnormalCodedValueSetElement = null;
                else
                    AbnormalCodedValueSetElement = new FhirUri(value);
                OnPropertyChanged("AbnormalCodedValueSet");
            }
        }

        /// <summary>
        /// Value set of critical coded values for the observation
        /// </summary>
        [FhirElement("criticalCodedValueSet", Order=200)]
        [DataMember]
        public FhirUri CriticalCodedValueSetElement
        {
            get { return _criticalCodedValueSetElement; }
            set { _criticalCodedValueSetElement = value; OnPropertyChanged("CriticalCodedValueSetElement"); }
        }

        private FhirUri _criticalCodedValueSetElement;

        /// <summary>
        /// Value set of critical coded values for the observation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string CriticalCodedValueSet
        {
            get { return CriticalCodedValueSetElement != null ? CriticalCodedValueSetElement.Value : null; }
            set
            {
                if (value == null)
                    CriticalCodedValueSetElement = null;
                else
                    CriticalCodedValueSetElement = new FhirUri(value);
                OnPropertyChanged("CriticalCodedValueSet");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ObservationDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Category != null) dest.Category = (Coding)Category.DeepCopy();
                if (Code != null) dest.Code = (Coding)Code.DeepCopy();
                if (PermittedDataType != null) dest.PermittedDataType = new List<Coding>(PermittedDataType.DeepCopy());
                if (MultipleResultsAllowedElement != null) dest.MultipleResultsAllowedElement = (FhirBoolean)MultipleResultsAllowedElement.DeepCopy();
                if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                if (PreferredReportNameElement != null) dest.PreferredReportNameElement = (FhirString)PreferredReportNameElement.DeepCopy();
                if (QuantitativeDetails != null) dest.QuantitativeDetails = (QuantitativeDetailsComponent)QuantitativeDetails.DeepCopy();
                if (QualifiedInterval != null) dest.QualifiedInterval = new List<QualifiedIntervalComponent>(QualifiedInterval.DeepCopy());
                if (ValidCodedValueSetElement != null) dest.ValidCodedValueSetElement = (FhirUri)ValidCodedValueSetElement.DeepCopy();
                if (NormalCodedValueSetElement != null) dest.NormalCodedValueSetElement = (FhirUri)NormalCodedValueSetElement.DeepCopy();
                if (AbnormalCodedValueSetElement != null) dest.AbnormalCodedValueSetElement = (FhirUri)AbnormalCodedValueSetElement.DeepCopy();
                if (CriticalCodedValueSetElement != null) dest.CriticalCodedValueSetElement = (FhirUri)CriticalCodedValueSetElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ObservationDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ObservationDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if ( !DeepComparable.Matches(PermittedDataType, otherT.PermittedDataType)) return false;
            if (!DeepComparable.Matches(MultipleResultsAllowedElement, otherT.MultipleResultsAllowedElement)) return false;
            if (!DeepComparable.Matches(Method, otherT.Method)) return false;
            if (!DeepComparable.Matches(PreferredReportNameElement, otherT.PreferredReportNameElement)) return false;
            if (!DeepComparable.Matches(QuantitativeDetails, otherT.QuantitativeDetails)) return false;
            if ( !DeepComparable.Matches(QualifiedInterval, otherT.QualifiedInterval)) return false;
            if (!DeepComparable.Matches(ValidCodedValueSetElement, otherT.ValidCodedValueSetElement)) return false;
            if (!DeepComparable.Matches(NormalCodedValueSetElement, otherT.NormalCodedValueSetElement)) return false;
            if (!DeepComparable.Matches(AbnormalCodedValueSetElement, otherT.AbnormalCodedValueSetElement)) return false;
            if (!DeepComparable.Matches(CriticalCodedValueSetElement, otherT.CriticalCodedValueSetElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ObservationDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(PermittedDataType, otherT.PermittedDataType)) return false;
            if (!DeepComparable.IsExactly(MultipleResultsAllowedElement, otherT.MultipleResultsAllowedElement)) return false;
            if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
            if (!DeepComparable.IsExactly(PreferredReportNameElement, otherT.PreferredReportNameElement)) return false;
            if (!DeepComparable.IsExactly(QuantitativeDetails, otherT.QuantitativeDetails)) return false;
            if (!DeepComparable.IsExactly(QualifiedInterval, otherT.QualifiedInterval)) return false;
            if (!DeepComparable.IsExactly(ValidCodedValueSetElement, otherT.ValidCodedValueSetElement)) return false;
            if (!DeepComparable.IsExactly(NormalCodedValueSetElement, otherT.NormalCodedValueSetElement)) return false;
            if (!DeepComparable.IsExactly(AbnormalCodedValueSetElement, otherT.AbnormalCodedValueSetElement)) return false;
            if (!DeepComparable.IsExactly(CriticalCodedValueSetElement, otherT.CriticalCodedValueSetElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Category != null) yield return Category;
                if (Code != null) yield return Code;
                foreach (var elem in PermittedDataType) { if (elem != null) yield return elem; }
                if (MultipleResultsAllowedElement != null) yield return MultipleResultsAllowedElement;
                if (Method != null) yield return Method;
                if (PreferredReportNameElement != null) yield return PreferredReportNameElement;
                if (QuantitativeDetails != null) yield return QuantitativeDetails;
                foreach (var elem in QualifiedInterval) { if (elem != null) yield return elem; }
                if (ValidCodedValueSetElement != null) yield return ValidCodedValueSetElement;
                if (NormalCodedValueSetElement != null) yield return NormalCodedValueSetElement;
                if (AbnormalCodedValueSetElement != null) yield return AbnormalCodedValueSetElement;
                if (CriticalCodedValueSetElement != null) yield return CriticalCodedValueSetElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Category != null) yield return new ElementValue("category", Category);
                if (Code != null) yield return new ElementValue("code", Code);
                foreach (var elem in PermittedDataType) { if (elem != null) yield return new ElementValue("permittedDataType", elem); }
                if (MultipleResultsAllowedElement != null) yield return new ElementValue("multipleResultsAllowed", MultipleResultsAllowedElement);
                if (Method != null) yield return new ElementValue("method", Method);
                if (PreferredReportNameElement != null) yield return new ElementValue("preferredReportName", PreferredReportNameElement);
                if (QuantitativeDetails != null) yield return new ElementValue("quantitativeDetails", QuantitativeDetails);
                foreach (var elem in QualifiedInterval) { if (elem != null) yield return new ElementValue("qualifiedInterval", elem); }
                if (ValidCodedValueSetElement != null) yield return new ElementValue("validCodedValueSet", ValidCodedValueSetElement);
                if (NormalCodedValueSetElement != null) yield return new ElementValue("normalCodedValueSet", NormalCodedValueSetElement);
                if (AbnormalCodedValueSetElement != null) yield return new ElementValue("abnormalCodedValueSet", AbnormalCodedValueSetElement);
                if (CriticalCodedValueSetElement != null) yield return new ElementValue("criticalCodedValueSet", CriticalCodedValueSetElement);
            }
        }

    }

}
