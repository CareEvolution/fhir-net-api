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
    /// Describes a required data item
    /// </summary>
    [FhirType("DataRequirement")]
    [DataContract]
    public partial class DataRequirement : Element
    {
        [NotMapped]
        public override string TypeName { get { return "DataRequirement"; } }

        /// <summary>
        /// The possible sort directions, ascending or descending
        /// (url: http://hl7.org/fhir/ValueSet/sort-direction)
        /// </summary>
        [FhirEnumeration("SortDirection")]
        public enum SortDirection
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/sort-direction)
            /// </summary>
            [EnumLiteral("ascending", "http://hl7.org/fhir/sort-direction"), Description("Ascending")]
            Ascending,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/sort-direction)
            /// </summary>
            [EnumLiteral("descending", "http://hl7.org/fhir/sort-direction"), Description("Descending")]
            Descending,
        }


        [FhirType("CodeFilterComponent")]
        [DataContract]
        public partial class CodeFilterComponent : Element, IBackboneElement
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
            [AllowedTypes(typeof(FhirUri),typeof(Canonical))]
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
            [FhirElement("code", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Code
            {
                get { if (_code==null) _code = new List<Coding>(); return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private List<Coding> _code;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CodeFilterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (ValueSet != null) dest.ValueSet = (Element)ValueSet.DeepCopy();
                    if (Code != null) dest.Code = new List<Coding>(Code.DeepCopy());
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
                if ( !DeepComparable.Matches(Code, otherT.Code)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CodeFilterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(ValueSet, otherT.ValueSet)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;

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
                    foreach (var elem in Code) { if (elem != null) yield return elem; }
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
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                }
            }


        }


        [FhirType("DateFilterComponent")]
        [DataContract]
        public partial class DateFilterComponent : Element, IBackboneElement
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


        [FhirType("SortComponent")]
        [DataContract]
        public partial class SortComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SortComponent"; } }

            /// <summary>
            /// The name of the attribute to perform the sort
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
            /// The name of the attribute to perform the sort
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
            /// ascending | descending
            /// </summary>
            [FhirElement("direction", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<SortDirection> DirectionElement
            {
                get { return _directionElement; }
                set { _directionElement = value; OnPropertyChanged("DirectionElement"); }
            }

            private Code<SortDirection> _directionElement;

            /// <summary>
            /// ascending | descending
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public SortDirection? Direction
            {
                get { return DirectionElement != null ? DirectionElement.Value : null; }
                set
                {
                    if (value == null)
                        DirectionElement = null;
                    else
                        DirectionElement = new Code<SortDirection>(value);
                    OnPropertyChanged("Direction");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SortComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (DirectionElement != null) dest.DirectionElement = (Code<SortDirection>)DirectionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SortComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SortComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(DirectionElement, otherT.DirectionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SortComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(DirectionElement, otherT.DirectionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PathElement != null) yield return PathElement;
                    if (DirectionElement != null) yield return DirectionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                    if (DirectionElement != null) yield return new ElementValue("direction", DirectionElement);
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
        public List<Canonical> ProfileElement
        {
            get { if (_profileElement==null) _profileElement = new List<Canonical>(); return _profileElement; }
            set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
        }

        private List<Canonical> _profileElement;

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
                    ProfileElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("Profile");
            }
        }

        /// <summary>
        /// E.g. Patient, Practitioner, RelatedPerson, Organization, Location, Device
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private Element _subject;

        /// <summary>
        /// Indicates that specific structure elements are referenced by the knowledge module
        /// </summary>
        [FhirElement("mustSupport", InSummary=true, Order=60)]
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
        [FhirElement("codeFilter", InSummary=true, Order=70)]
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
        [FhirElement("dateFilter", InSummary=true, Order=80)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DateFilterComponent> DateFilter
        {
            get { if (_dateFilter==null) _dateFilter = new List<DateFilterComponent>(); return _dateFilter; }
            set { _dateFilter = value; OnPropertyChanged("DateFilter"); }
        }

        private List<DateFilterComponent> _dateFilter;

        /// <summary>
        /// Number of results
        /// </summary>
        [FhirElement("limit", InSummary=true, Order=90)]
        [DataMember]
        public PositiveInt LimitElement
        {
            get { return _limitElement; }
            set { _limitElement = value; OnPropertyChanged("LimitElement"); }
        }

        private PositiveInt _limitElement;

        /// <summary>
        /// Number of results
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Limit
        {
            get { return LimitElement != null ? LimitElement.Value : null; }
            set
            {
                if (value == null)
                    LimitElement = null;
                else
                    LimitElement = new PositiveInt(value);
                OnPropertyChanged("Limit");
            }
        }

        /// <summary>
        /// Order of the results
        /// </summary>
        [FhirElement("sort", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SortComponent> Sort
        {
            get { if (_sort==null) _sort = new List<SortComponent>(); return _sort; }
            set { _sort = value; OnPropertyChanged("Sort"); }
        }

        private List<SortComponent> _sort;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DataRequirement;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (TypeElement != null) dest.TypeElement = (Code<FHIRAllTypes>)TypeElement.DeepCopy();
                if (ProfileElement != null) dest.ProfileElement = new List<Canonical>(ProfileElement.DeepCopy());
                if (Subject != null) dest.Subject = (Element)Subject.DeepCopy();
                if (MustSupportElement != null) dest.MustSupportElement = new List<FhirString>(MustSupportElement.DeepCopy());
                if (CodeFilter != null) dest.CodeFilter = new List<CodeFilterComponent>(CodeFilter.DeepCopy());
                if (DateFilter != null) dest.DateFilter = new List<DateFilterComponent>(DateFilter.DeepCopy());
                if (LimitElement != null) dest.LimitElement = (PositiveInt)LimitElement.DeepCopy();
                if (Sort != null) dest.Sort = new List<SortComponent>(Sort.DeepCopy());
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
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(MustSupportElement, otherT.MustSupportElement)) return false;
            if ( !DeepComparable.Matches(CodeFilter, otherT.CodeFilter)) return false;
            if ( !DeepComparable.Matches(DateFilter, otherT.DateFilter)) return false;
            if (!DeepComparable.Matches(LimitElement, otherT.LimitElement)) return false;
            if ( !DeepComparable.Matches(Sort, otherT.Sort)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DataRequirement;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(MustSupportElement, otherT.MustSupportElement)) return false;
            if (!DeepComparable.IsExactly(CodeFilter, otherT.CodeFilter)) return false;
            if (!DeepComparable.IsExactly(DateFilter, otherT.DateFilter)) return false;
            if (!DeepComparable.IsExactly(LimitElement, otherT.LimitElement)) return false;
            if (!DeepComparable.IsExactly(Sort, otherT.Sort)) return false;

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
                if (Subject != null) yield return Subject;
                foreach (var elem in MustSupportElement) { if (elem != null) yield return elem; }
                foreach (var elem in CodeFilter) { if (elem != null) yield return elem; }
                foreach (var elem in DateFilter) { if (elem != null) yield return elem; }
                if (LimitElement != null) yield return LimitElement;
                foreach (var elem in Sort) { if (elem != null) yield return elem; }
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
                if (Subject != null) yield return new ElementValue("subject", Subject);
                foreach (var elem in MustSupportElement) { if (elem != null) yield return new ElementValue("mustSupport", elem); }
                foreach (var elem in CodeFilter) { if (elem != null) yield return new ElementValue("codeFilter", elem); }
                foreach (var elem in DateFilter) { if (elem != null) yield return new ElementValue("dateFilter", elem); }
                if (LimitElement != null) yield return new ElementValue("limit", LimitElement);
                foreach (var elem in Sort) { if (elem != null) yield return new ElementValue("sort", elem); }
            }
        }

    }

}
