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
    /// Describes a required data item
    /// </summary>
    [FhirType("DataRequirement")]
    [DataContract]
    public partial class DataRequirement : Element
    {
        [NotMapped]
        public override string TypeName { get { return "DataRequirement"; } }


        [FhirType("CodeFilterComponent")]
        [DataContract]
        public partial class CodeFilterComponent : Element
        {
            [NotMapped]
            public override string TypeName { get { return "CodeFilterComponent"; } }

            /// <summary>
            /// The code-valued attribute of the filter
            /// </summary>
            [FhirElement("path", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// The code-valued attribute of the filter
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

            /// <summary>
            /// Valueset for the filter
            /// </summary>
            [FhirElement("valueSet", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirString),typeof(ResourceReference))]
            [DataMember]
            public Element ValueSet
            {
                get { return _valueSet; }
                set { _valueSet = value; OnPropertyChanged("ValueSet"); }
            }

            private Element _valueSet;

            /// <summary>
            /// What code is expected
            /// </summary>
            [FhirElement("valueCode", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code> ValueCodeElement
            {
                get { if (_valueCodeElement==null) _valueCodeElement = new List<Code>(); return _valueCodeElement; }
                set { _valueCodeElement = value; OnPropertyChanged("ValueCodeElement"); }
            }

            private List<Code> _valueCodeElement;

            /// <summary>
            /// What code is expected
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> ValueCode
            {
                get { return ValueCodeElement != null ? ValueCodeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ValueCodeElement = null;
                    else
                        ValueCodeElement = new List<Code>(value.Select(elem=>new Code(elem)));
                    OnPropertyChanged("ValueCode");
                }
            }

            /// <summary>
            /// What Coding is expected
            /// </summary>
            [FhirElement("valueCoding", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> ValueCoding
            {
                get { if (_valueCoding==null) _valueCoding = new List<Coding>(); return _valueCoding; }
                set { _valueCoding = value; OnPropertyChanged("ValueCoding"); }
            }

            private List<Coding> _valueCoding;

            /// <summary>
            /// What CodeableConcept is expected
            /// </summary>
            [FhirElement("valueCodeableConcept", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ValueCodeableConcept
            {
                get { if (_valueCodeableConcept==null) _valueCodeableConcept = new List<CodeableConcept>(); return _valueCodeableConcept; }
                set { _valueCodeableConcept = value; OnPropertyChanged("ValueCodeableConcept"); }
            }

            private List<CodeableConcept> _valueCodeableConcept;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CodeFilterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (ValueSet != null) dest.ValueSet = (Element)ValueSet.DeepCopy();
                    if (ValueCodeElement != null) dest.ValueCodeElement = new List<Code>(ValueCodeElement.DeepCopy());
                    if (ValueCoding != null) dest.ValueCoding = new List<Coding>(ValueCoding.DeepCopy());
                    if (ValueCodeableConcept != null) dest.ValueCodeableConcept = new List<CodeableConcept>(ValueCodeableConcept.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CodeFilterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CodeFilterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(ValueSet, otherT.ValueSet)) return false;
                if ( !DeepComparable.Matches(ValueCodeElement, otherT.ValueCodeElement)) return false;
                if ( !DeepComparable.Matches(ValueCoding, otherT.ValueCoding)) return false;
                if ( !DeepComparable.Matches(ValueCodeableConcept, otherT.ValueCodeableConcept)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CodeFilterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(ValueSet, otherT.ValueSet)) return false;
                if (!DeepComparable.IsExactly(ValueCodeElement, otherT.ValueCodeElement)) return false;
                if (!DeepComparable.IsExactly(ValueCoding, otherT.ValueCoding)) return false;
                if (!DeepComparable.IsExactly(ValueCodeableConcept, otherT.ValueCodeableConcept)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PathElement != null) yield return PathElement;
                    if (ValueSet != null) yield return ValueSet;
                    foreach (var elem in ValueCodeElement) { if (elem != null) yield return elem; }
                    foreach (var elem in ValueCoding) { if (elem != null) yield return elem; }
                    foreach (var elem in ValueCodeableConcept) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                    if (ValueSet != null) yield return new ElementValue("valueSet", ValueSet);
                    foreach (var elem in ValueCodeElement) { if (elem != null) yield return new ElementValue("valueCode", elem); }
                    foreach (var elem in ValueCoding) { if (elem != null) yield return new ElementValue("valueCoding", elem); }
                    foreach (var elem in ValueCodeableConcept) { if (elem != null) yield return new ElementValue("valueCodeableConcept", elem); }
                }
            }


        }


        [FhirType("DateFilterComponent")]
        [DataContract]
        public partial class DateFilterComponent : Element
        {
            [NotMapped]
            public override string TypeName { get { return "DateFilterComponent"; } }

            /// <summary>
            /// The date-valued attribute of the filter
            /// </summary>
            [FhirElement("path", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// The date-valued attribute of the filter
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

            /// <summary>
            /// The value of the filter, as a Period, DateTime, or Duration value
            /// </summary>
            [FhirElement("value", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(Duration))]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DateFilterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DateFilterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DateFilterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DateFilterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PathElement != null) yield return PathElement;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        /// <summary>
        /// The type of the required data
        /// </summary>
        [FhirElement("type", InSummary=true, Order=30)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<FHIRAllTypes> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<FHIRAllTypes> _typeElement;

        /// <summary>
        /// The type of the required data
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public FHIRAllTypes? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<FHIRAllTypes>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// The profile of the required data
        /// </summary>
        [FhirElement("profile", InSummary=true, Order=40)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> ProfileElement
        {
            get { if (_profileElement==null) _profileElement = new List<FhirUri>(); return _profileElement; }
            set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
        }

        private List<FhirUri> _profileElement;

        /// <summary>
        /// The profile of the required data
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Profile
        {
            get { return ProfileElement != null ? ProfileElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ProfileElement = null;
                else
                    ProfileElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("Profile");
            }
        }

        /// <summary>
        /// Indicates that specific structure elements are referenced by the knowledge module
        /// </summary>
        [FhirElement("mustSupport", InSummary=true, Order=50)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> MustSupportElement
        {
            get { if (_mustSupportElement==null) _mustSupportElement = new List<FhirString>(); return _mustSupportElement; }
            set { _mustSupportElement = value; OnPropertyChanged("MustSupportElement"); }
        }

        private List<FhirString> _mustSupportElement;

        /// <summary>
        /// Indicates that specific structure elements are referenced by the knowledge module
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> MustSupport
        {
            get { return MustSupportElement != null ? MustSupportElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    MustSupportElement = null;
                else
                    MustSupportElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("MustSupport");
            }
        }

        /// <summary>
        /// What codes are expected
        /// </summary>
        [FhirElement("codeFilter", InSummary=true, Order=60)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeFilterComponent> CodeFilter
        {
            get { if (_codeFilter==null) _codeFilter = new List<CodeFilterComponent>(); return _codeFilter; }
            set { _codeFilter = value; OnPropertyChanged("CodeFilter"); }
        }

        private List<CodeFilterComponent> _codeFilter;

        /// <summary>
        /// What dates/date ranges are expected
        /// </summary>
        [FhirElement("dateFilter", InSummary=true, Order=70)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DateFilterComponent> DateFilter
        {
            get { if (_dateFilter==null) _dateFilter = new List<DateFilterComponent>(); return _dateFilter; }
            set { _dateFilter = value; OnPropertyChanged("DateFilter"); }
        }

        private List<DateFilterComponent> _dateFilter;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DataRequirement;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (TypeElement != null) dest.TypeElement = (Code<FHIRAllTypes>)TypeElement.DeepCopy();
                if (ProfileElement != null) dest.ProfileElement = new List<FhirUri>(ProfileElement.DeepCopy());
                if (MustSupportElement != null) dest.MustSupportElement = new List<FhirString>(MustSupportElement.DeepCopy());
                if (CodeFilter != null) dest.CodeFilter = new List<CodeFilterComponent>(CodeFilter.DeepCopy());
                if (DateFilter != null) dest.DateFilter = new List<DateFilterComponent>(DateFilter.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new DataRequirement());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DataRequirement;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if ( !DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;
            if ( !DeepComparable.Matches(MustSupportElement, otherT.MustSupportElement)) return false;
            if ( !DeepComparable.Matches(CodeFilter, otherT.CodeFilter)) return false;
            if ( !DeepComparable.Matches(DateFilter, otherT.DateFilter)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DataRequirement;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;
            if (!DeepComparable.IsExactly(MustSupportElement, otherT.MustSupportElement)) return false;
            if (!DeepComparable.IsExactly(CodeFilter, otherT.CodeFilter)) return false;
            if (!DeepComparable.IsExactly(DateFilter, otherT.DateFilter)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (TypeElement != null) yield return TypeElement;
                foreach (var elem in ProfileElement) { if (elem != null) yield return elem; }
                foreach (var elem in MustSupportElement) { if (elem != null) yield return elem; }
                foreach (var elem in CodeFilter) { if (elem != null) yield return elem; }
                foreach (var elem in DateFilter) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                foreach (var elem in ProfileElement) { if (elem != null) yield return new ElementValue("profile", elem); }
                foreach (var elem in MustSupportElement) { if (elem != null) yield return new ElementValue("mustSupport", elem); }
                foreach (var elem in CodeFilter) { if (elem != null) yield return new ElementValue("codeFilter", elem); }
                foreach (var elem in DateFilter) { if (elem != null) yield return new ElementValue("dateFilter", elem); }
            }
        }

    }

}
