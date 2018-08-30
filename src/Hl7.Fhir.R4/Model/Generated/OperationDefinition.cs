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
    /// Definition of an operation or a named query
    /// </summary>
    [FhirType("OperationDefinition", IsResource=true)]
    [DataContract]
    public partial class OperationDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.OperationDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "OperationDefinition"; } }

        /// <summary>
        /// Whether an operation is a normal operation or a query.
        /// (url: http://hl7.org/fhir/ValueSet/operation-kind)
        /// </summary>
        [FhirEnumeration("OperationKind")]
        public enum OperationKind
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/operation-kind)
            /// </summary>
            [EnumLiteral("operation", "http://hl7.org/fhir/operation-kind"), Description("Operation")]
            Operation,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/operation-kind)
            /// </summary>
            [EnumLiteral("query", "http://hl7.org/fhir/operation-kind"), Description("Query")]
            Query,
        }


        [FhirType("ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }

            /// <summary>
            /// Name in Parameters.parameter.name or in URL
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private Code _nameElement;

            /// <summary>
            /// Name in Parameters.parameter.name or in URL
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
                        NameElement = new Code(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// in | out
            /// </summary>
            [FhirElement("use", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<OperationParameterUse> UseElement
            {
                get { return _useElement; }
                set { _useElement = value; OnPropertyChanged("UseElement"); }
            }

            private Code<OperationParameterUse> _useElement;

            /// <summary>
            /// in | out
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public OperationParameterUse? Use
            {
                get { return UseElement != null ? UseElement.Value : null; }
                set
                {
                    if (value == null)
                        UseElement = null;
                    else
                        UseElement = new Code<OperationParameterUse>(value);
                    OnPropertyChanged("Use");
                }
            }

            /// <summary>
            /// Minimum Cardinality
            /// </summary>
            [FhirElement("min", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Integer MinElement
            {
                get { return _minElement; }
                set { _minElement = value; OnPropertyChanged("MinElement"); }
            }

            private Integer _minElement;

            /// <summary>
            /// Minimum Cardinality
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Min
            {
                get { return MinElement != null ? MinElement.Value : null; }
                set
                {
                    if (value == null)
                        MinElement = null;
                    else
                        MinElement = new Integer(value);
                    OnPropertyChanged("Min");
                }
            }

            /// <summary>
            /// Maximum Cardinality (a number or *)
            /// </summary>
            [FhirElement("max", Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString MaxElement
            {
                get { return _maxElement; }
                set { _maxElement = value; OnPropertyChanged("MaxElement"); }
            }

            private FhirString _maxElement;

            /// <summary>
            /// Maximum Cardinality (a number or *)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Max
            {
                get { return MaxElement != null ? MaxElement.Value : null; }
                set
                {
                    if (value == null)
                        MaxElement = null;
                    else
                        MaxElement = new FhirString(value);
                    OnPropertyChanged("Max");
                }
            }

            /// <summary>
            /// Description of meaning/use
            /// </summary>
            [FhirElement("documentation", Order=80)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Description of meaning/use
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            /// <summary>
            /// What type this parameter has
            /// </summary>
            [FhirElement("type", Order=90)]
            [DataMember]
            public Code<FHIRAllTypes> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<FHIRAllTypes> _typeElement;

            /// <summary>
            /// What type this parameter has
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
            /// If type is Reference | canonical, allowed targets
            /// </summary>
            [FhirElement("targetProfile", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Canonical> TargetProfileElement
            {
                get { if (_targetProfileElement==null) _targetProfileElement = new List<Canonical>(); return _targetProfileElement; }
                set { _targetProfileElement = value; OnPropertyChanged("TargetProfileElement"); }
            }

            private List<Canonical> _targetProfileElement;

            /// <summary>
            /// If type is Reference | canonical, allowed targets
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> TargetProfile
            {
                get { return TargetProfileElement != null ? TargetProfileElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        TargetProfileElement = null;
                    else
                        TargetProfileElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                    OnPropertyChanged("TargetProfile");
                }
            }

            /// <summary>
            /// number | date | string | token | reference | composite | quantity | uri | special
            /// </summary>
            [FhirElement("searchType", Order=110)]
            [DataMember]
            public Code<SearchParamType> SearchTypeElement
            {
                get { return _searchTypeElement; }
                set { _searchTypeElement = value; OnPropertyChanged("SearchTypeElement"); }
            }

            private Code<SearchParamType> _searchTypeElement;

            /// <summary>
            /// number | date | string | token | reference | composite | quantity | uri | special
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public SearchParamType? SearchType
            {
                get { return SearchTypeElement != null ? SearchTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        SearchTypeElement = null;
                    else
                        SearchTypeElement = new Code<SearchParamType>(value);
                    OnPropertyChanged("SearchType");
                }
            }

            /// <summary>
            /// ValueSet details if this is coded
            /// </summary>
            [FhirElement("binding", Order=120)]
            [DataMember]
            public BindingComponent Binding
            {
                get { return _binding; }
                set { _binding = value; OnPropertyChanged("Binding"); }
            }

            private BindingComponent _binding;

            /// <summary>
            /// References to this parameter
            /// </summary>
            [FhirElement("referencedFrom", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ReferencedFromComponent> ReferencedFrom
            {
                get { if (_referencedFrom==null) _referencedFrom = new List<ReferencedFromComponent>(); return _referencedFrom; }
                set { _referencedFrom = value; OnPropertyChanged("ReferencedFrom"); }
            }

            private List<ReferencedFromComponent> _referencedFrom;

            /// <summary>
            /// Parts of a nested Parameter
            /// </summary>
            [FhirElement("part", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParameterComponent> Part
            {
                get { if (_part==null) _part = new List<ParameterComponent>(); return _part; }
                set { _part = value; OnPropertyChanged("Part"); }
            }

            private List<ParameterComponent> _part;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParameterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (Code)NameElement.DeepCopy();
                    if (UseElement != null) dest.UseElement = (Code<OperationParameterUse>)UseElement.DeepCopy();
                    if (MinElement != null) dest.MinElement = (Integer)MinElement.DeepCopy();
                    if (MaxElement != null) dest.MaxElement = (FhirString)MaxElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<FHIRAllTypes>)TypeElement.DeepCopy();
                    if (TargetProfileElement != null) dest.TargetProfileElement = new List<Canonical>(TargetProfileElement.DeepCopy());
                    if (SearchTypeElement != null) dest.SearchTypeElement = (Code<SearchParamType>)SearchTypeElement.DeepCopy();
                    if (Binding != null) dest.Binding = (BindingComponent)Binding.DeepCopy();
                    if (ReferencedFrom != null) dest.ReferencedFrom = new List<ReferencedFromComponent>(ReferencedFrom.DeepCopy());
                    if (Part != null) dest.Part = new List<ParameterComponent>(Part.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParameterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
                if (!DeepComparable.Matches(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.Matches(MaxElement, otherT.MaxElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if ( !DeepComparable.Matches(TargetProfileElement, otherT.TargetProfileElement)) return false;
                if (!DeepComparable.Matches(SearchTypeElement, otherT.SearchTypeElement)) return false;
                if (!DeepComparable.Matches(Binding, otherT.Binding)) return false;
                if ( !DeepComparable.Matches(ReferencedFrom, otherT.ReferencedFrom)) return false;
                if ( !DeepComparable.Matches(Part, otherT.Part)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
                if (!DeepComparable.IsExactly(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.IsExactly(MaxElement, otherT.MaxElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(TargetProfileElement, otherT.TargetProfileElement)) return false;
                if (!DeepComparable.IsExactly(SearchTypeElement, otherT.SearchTypeElement)) return false;
                if (!DeepComparable.IsExactly(Binding, otherT.Binding)) return false;
                if (!DeepComparable.IsExactly(ReferencedFrom, otherT.ReferencedFrom)) return false;
                if (!DeepComparable.IsExactly(Part, otherT.Part)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (UseElement != null) yield return UseElement;
                    if (MinElement != null) yield return MinElement;
                    if (MaxElement != null) yield return MaxElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                    if (TypeElement != null) yield return TypeElement;
                    foreach (var elem in TargetProfileElement) { if (elem != null) yield return elem; }
                    if (SearchTypeElement != null) yield return SearchTypeElement;
                    if (Binding != null) yield return Binding;
                    foreach (var elem in ReferencedFrom) { if (elem != null) yield return elem; }
                    foreach (var elem in Part) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (UseElement != null) yield return new ElementValue("use", UseElement);
                    if (MinElement != null) yield return new ElementValue("min", MinElement);
                    if (MaxElement != null) yield return new ElementValue("max", MaxElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    foreach (var elem in TargetProfileElement) { if (elem != null) yield return new ElementValue("targetProfile", elem); }
                    if (SearchTypeElement != null) yield return new ElementValue("searchType", SearchTypeElement);
                    if (Binding != null) yield return new ElementValue("binding", Binding);
                    foreach (var elem in ReferencedFrom) { if (elem != null) yield return new ElementValue("referencedFrom", elem); }
                    foreach (var elem in Part) { if (elem != null) yield return new ElementValue("part", elem); }
                }
            }


        }


        [FhirType("BindingComponent")]
        [DataContract]
        public partial class BindingComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "BindingComponent"; } }

            /// <summary>
            /// required | extensible | preferred | example
            /// </summary>
            [FhirElement("strength", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<BindingStrength> StrengthElement
            {
                get { return _strengthElement; }
                set { _strengthElement = value; OnPropertyChanged("StrengthElement"); }
            }

            private Code<BindingStrength> _strengthElement;

            /// <summary>
            /// required | extensible | preferred | example
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public BindingStrength? Strength
            {
                get { return StrengthElement != null ? StrengthElement.Value : null; }
                set
                {
                    if (value == null)
                        StrengthElement = null;
                    else
                        StrengthElement = new Code<BindingStrength>(value);
                    OnPropertyChanged("Strength");
                }
            }

            /// <summary>
            /// Source of value set
            /// </summary>
            [FhirElement("valueSet", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Canonical ValueSetElement
            {
                get { return _valueSetElement; }
                set { _valueSetElement = value; OnPropertyChanged("ValueSetElement"); }
            }

            private Canonical _valueSetElement;

            /// <summary>
            /// Source of value set
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ValueSet
            {
                get { return ValueSetElement != null ? ValueSetElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueSetElement = null;
                    else
                        ValueSetElement = new Canonical(value);
                    OnPropertyChanged("ValueSet");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BindingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StrengthElement != null) dest.StrengthElement = (Code<BindingStrength>)StrengthElement.DeepCopy();
                    if (ValueSetElement != null) dest.ValueSetElement = (Canonical)ValueSetElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BindingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BindingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StrengthElement, otherT.StrengthElement)) return false;
                if (!DeepComparable.Matches(ValueSetElement, otherT.ValueSetElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BindingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StrengthElement, otherT.StrengthElement)) return false;
                if (!DeepComparable.IsExactly(ValueSetElement, otherT.ValueSetElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StrengthElement != null) yield return StrengthElement;
                    if (ValueSetElement != null) yield return ValueSetElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StrengthElement != null) yield return new ElementValue("strength", StrengthElement);
                    if (ValueSetElement != null) yield return new ElementValue("valueSet", ValueSetElement);
                }
            }


        }


        [FhirType("ReferencedFromComponent")]
        [DataContract]
        public partial class ReferencedFromComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ReferencedFromComponent"; } }

            /// <summary>
            /// Referencing parameter
            /// </summary>
            [FhirElement("source", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString SourceElement
            {
                get { return _sourceElement; }
                set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
            }

            private FhirString _sourceElement;

            /// <summary>
            /// Referencing parameter
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Source
            {
                get { return SourceElement != null ? SourceElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceElement = null;
                    else
                        SourceElement = new FhirString(value);
                    OnPropertyChanged("Source");
                }
            }

            /// <summary>
            /// Element id of reference
            /// </summary>
            [FhirElement("sourceId", Order=50)]
            [DataMember]
            public FhirString SourceIdElement
            {
                get { return _sourceIdElement; }
                set { _sourceIdElement = value; OnPropertyChanged("SourceIdElement"); }
            }

            private FhirString _sourceIdElement;

            /// <summary>
            /// Element id of reference
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SourceId
            {
                get { return SourceIdElement != null ? SourceIdElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceIdElement = null;
                    else
                        SourceIdElement = new FhirString(value);
                    OnPropertyChanged("SourceId");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReferencedFromComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SourceElement != null) dest.SourceElement = (FhirString)SourceElement.DeepCopy();
                    if (SourceIdElement != null) dest.SourceIdElement = (FhirString)SourceIdElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ReferencedFromComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReferencedFromComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.Matches(SourceIdElement, otherT.SourceIdElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReferencedFromComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.IsExactly(SourceIdElement, otherT.SourceIdElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SourceElement != null) yield return SourceElement;
                    if (SourceIdElement != null) yield return SourceIdElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                    if (SourceIdElement != null) yield return new ElementValue("sourceId", SourceIdElement);
                }
            }


        }


        [FhirType("OverloadComponent")]
        [DataContract]
        public partial class OverloadComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OverloadComponent"; } }

            /// <summary>
            /// Name of parameter to include in overload
            /// </summary>
            [FhirElement("parameterName", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ParameterNameElement
            {
                get { if (_parameterNameElement==null) _parameterNameElement = new List<FhirString>(); return _parameterNameElement; }
                set { _parameterNameElement = value; OnPropertyChanged("ParameterNameElement"); }
            }

            private List<FhirString> _parameterNameElement;

            /// <summary>
            /// Name of parameter to include in overload
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> ParameterName
            {
                get { return ParameterNameElement != null ? ParameterNameElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ParameterNameElement = null;
                    else
                        ParameterNameElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("ParameterName");
                }
            }

            /// <summary>
            /// Comments to go on overload
            /// </summary>
            [FhirElement("comment", Order=50)]
            [DataMember]
            public FhirString CommentElement
            {
                get { return _commentElement; }
                set { _commentElement = value; OnPropertyChanged("CommentElement"); }
            }

            private FhirString _commentElement;

            /// <summary>
            /// Comments to go on overload
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Comment
            {
                get { return CommentElement != null ? CommentElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentElement = null;
                    else
                        CommentElement = new FhirString(value);
                    OnPropertyChanged("Comment");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OverloadComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ParameterNameElement != null) dest.ParameterNameElement = new List<FhirString>(ParameterNameElement.DeepCopy());
                    if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OverloadComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OverloadComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(ParameterNameElement, otherT.ParameterNameElement)) return false;
                if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OverloadComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ParameterNameElement, otherT.ParameterNameElement)) return false;
                if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in ParameterNameElement) { if (elem != null) yield return elem; }
                    if (CommentElement != null) yield return CommentElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in ParameterNameElement) { if (elem != null) yield return new ElementValue("parameterName", elem); }
                    if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this operation definition, represented as a URI (globally unique)
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
        /// Canonical identifier for this operation definition, represented as a URI (globally unique)
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
        /// Business version of the operation definition
        /// </summary>
        [FhirElement("version", InSummary=true, Order=100)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Business version of the operation definition
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
        /// Name for this operation definition (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name for this operation definition (computer friendly)
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
        /// Name for this operation definition (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=true, Order=120)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Name for this operation definition (human friendly)
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
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
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
        /// operation | query
        /// </summary>
        [FhirElement("kind", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<OperationKind> KindElement
        {
            get { return _kindElement; }
            set { _kindElement = value; OnPropertyChanged("KindElement"); }
        }

        private Code<OperationKind> _kindElement;

        /// <summary>
        /// operation | query
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public OperationKind? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (value == null)
                    KindElement = null;
                else
                    KindElement = new Code<OperationKind>(value);
                OnPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=150)]
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
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=160)]
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
        [FhirElement("publisher", InSummary=true, Order=170)]
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
        [FhirElement("contact", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Natural language description of the operation definition
        /// </summary>
        [FhirElement("description", Order=190)]
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
        [FhirElement("useContext", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for operation definition (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Why this operation definition is defined
        /// </summary>
        [FhirElement("purpose", Order=220)]
        [DataMember]
        public Markdown Purpose
        {
            get { return _purpose; }
            set { _purpose = value; OnPropertyChanged("Purpose"); }
        }

        private Markdown _purpose;

        /// <summary>
        /// Whether content is changed by the operation
        /// </summary>
        [FhirElement("affectsState", InSummary=true, Order=230)]
        [DataMember]
        public FhirBoolean AffectsStateElement
        {
            get { return _affectsStateElement; }
            set { _affectsStateElement = value; OnPropertyChanged("AffectsStateElement"); }
        }

        private FhirBoolean _affectsStateElement;

        /// <summary>
        /// Whether content is changed by the operation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? AffectsState
        {
            get { return AffectsStateElement != null ? AffectsStateElement.Value : null; }
            set
            {
                if (value == null)
                    AffectsStateElement = null;
                else
                    AffectsStateElement = new FhirBoolean(value);
                OnPropertyChanged("AffectsState");
            }
        }

        /// <summary>
        /// Name used to invoke the operation
        /// </summary>
        [FhirElement("code", InSummary=true, Order=240)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code CodeElement
        {
            get { return _codeElement; }
            set { _codeElement = value; OnPropertyChanged("CodeElement"); }
        }

        private Code _codeElement;

        /// <summary>
        /// Name used to invoke the operation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Code
        {
            get { return CodeElement != null ? CodeElement.Value : null; }
            set
            {
                if (value == null)
                    CodeElement = null;
                else
                    CodeElement = new Code(value);
                OnPropertyChanged("Code");
            }
        }

        /// <summary>
        /// Additional information about use
        /// </summary>
        [FhirElement("comment", Order=250)]
        [DataMember]
        public Markdown Comment
        {
            get { return _comment; }
            set { _comment = value; OnPropertyChanged("Comment"); }
        }

        private Markdown _comment;

        /// <summary>
        /// Marks this as a profile of the base
        /// </summary>
        [FhirElement("base", InSummary=true, Order=260)]
        [DataMember]
        public Canonical BaseElement
        {
            get { return _baseElement; }
            set { _baseElement = value; OnPropertyChanged("BaseElement"); }
        }

        private Canonical _baseElement;

        /// <summary>
        /// Marks this as a profile of the base
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Base
        {
            get { return BaseElement != null ? BaseElement.Value : null; }
            set
            {
                if (value == null)
                    BaseElement = null;
                else
                    BaseElement = new Canonical(value);
                OnPropertyChanged("Base");
            }
        }

        /// <summary>
        /// Types this operation applies to
        /// </summary>
        [FhirElement("resource", InSummary=true, Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<ResourceType>> ResourceElement
        {
            get { if (_resourceElement==null) _resourceElement = new List<Code<ResourceType>>(); return _resourceElement; }
            set { _resourceElement = value; OnPropertyChanged("ResourceElement"); }
        }

        private List<Code<ResourceType>> _resourceElement;

        /// <summary>
        /// Types this operation applies to
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<ResourceType?> Resource
        {
            get { return ResourceElement != null ? ResourceElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ResourceElement = null;
                else
                    ResourceElement = new List<Code<ResourceType>>(value.Select(elem=>new Code<ResourceType>(elem)));
                OnPropertyChanged("Resource");
            }
        }

        /// <summary>
        /// Invoke at the system level?
        /// </summary>
        [FhirElement("system", InSummary=true, Order=280)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirBoolean SystemElement
        {
            get { return _systemElement; }
            set { _systemElement = value; OnPropertyChanged("SystemElement"); }
        }

        private FhirBoolean _systemElement;

        /// <summary>
        /// Invoke at the system level?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? System
        {
            get { return SystemElement != null ? SystemElement.Value : null; }
            set
            {
                if (value == null)
                    SystemElement = null;
                else
                    SystemElement = new FhirBoolean(value);
                OnPropertyChanged("System");
            }
        }

        /// <summary>
        /// Invoke at the type level?
        /// </summary>
        [FhirElement("type", InSummary=true, Order=290)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirBoolean TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private FhirBoolean _typeElement;

        /// <summary>
        /// Invoke at the type level?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new FhirBoolean(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Invoke on an instance?
        /// </summary>
        [FhirElement("instance", InSummary=true, Order=300)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirBoolean InstanceElement
        {
            get { return _instanceElement; }
            set { _instanceElement = value; OnPropertyChanged("InstanceElement"); }
        }

        private FhirBoolean _instanceElement;

        /// <summary>
        /// Invoke on an instance?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Instance
        {
            get { return InstanceElement != null ? InstanceElement.Value : null; }
            set
            {
                if (value == null)
                    InstanceElement = null;
                else
                    InstanceElement = new FhirBoolean(value);
                OnPropertyChanged("Instance");
            }
        }

        /// <summary>
        /// Validation information for in parameters
        /// </summary>
        [FhirElement("inputProfile", Order=310)]
        [DataMember]
        public Canonical InputProfileElement
        {
            get { return _inputProfileElement; }
            set { _inputProfileElement = value; OnPropertyChanged("InputProfileElement"); }
        }

        private Canonical _inputProfileElement;

        /// <summary>
        /// Validation information for in parameters
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string InputProfile
        {
            get { return InputProfileElement != null ? InputProfileElement.Value : null; }
            set
            {
                if (value == null)
                    InputProfileElement = null;
                else
                    InputProfileElement = new Canonical(value);
                OnPropertyChanged("InputProfile");
            }
        }

        /// <summary>
        /// Validation information for out parameters
        /// </summary>
        [FhirElement("outputProfile", Order=320)]
        [DataMember]
        public Canonical OutputProfileElement
        {
            get { return _outputProfileElement; }
            set { _outputProfileElement = value; OnPropertyChanged("OutputProfileElement"); }
        }

        private Canonical _outputProfileElement;

        /// <summary>
        /// Validation information for out parameters
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string OutputProfile
        {
            get { return OutputProfileElement != null ? OutputProfileElement.Value : null; }
            set
            {
                if (value == null)
                    OutputProfileElement = null;
                else
                    OutputProfileElement = new Canonical(value);
                OnPropertyChanged("OutputProfile");
            }
        }

        /// <summary>
        /// Parameters for the operation/query
        /// </summary>
        [FhirElement("parameter", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParameterComponent> Parameter
        {
            get { if (_parameter==null) _parameter = new List<ParameterComponent>(); return _parameter; }
            set { _parameter = value; OnPropertyChanged("Parameter"); }
        }

        private List<ParameterComponent> _parameter;

        /// <summary>
        /// Define overloaded variants for when  generating code
        /// </summary>
        [FhirElement("overload", Order=340)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<OverloadComponent> Overload
        {
            get { if (_overload==null) _overload = new List<OverloadComponent>(); return _overload; }
            set { _overload = value; OnPropertyChanged("Overload"); }
        }

        private List<OverloadComponent> _overload;


        public static ElementDefinition.ConstraintComponent OperationDefinition_OPD_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "opd-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public static ElementDefinition.ConstraintComponent OperationDefinition_OPD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "parameter.all(type.exists() or part.exists())",
            Key = "opd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Either a type must be provided, or parts",
            Xpath = "exists(f:type) or exists(f:part)"
        };

        public static ElementDefinition.ConstraintComponent OperationDefinition_OPD_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "parameter.all(searchType.exists() implies type = 'string')",
            Key = "opd-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A search type can only be specified for parameters of type string",
            Xpath = "not(exists(f:searchType)) or (f:type/@value = 'string')"
        };

        public static ElementDefinition.ConstraintComponent OperationDefinition_OPD_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "parameter.all(targetProfile.exists() implies (type = 'Reference' or type = 'canonical'))",
            Key = "opd-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A targetProfile can only be specified for parameters of type Reference or Canonical",
            Xpath = "not(exists(f:targetProfile)) or ((f:type/@value = 'Reference') or (f:type/@value = 'canonical'))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(OperationDefinition_OPD_0);
            InvariantConstraints.Add(OperationDefinition_OPD_1);
            InvariantConstraints.Add(OperationDefinition_OPD_2);
            InvariantConstraints.Add(OperationDefinition_OPD_3);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as OperationDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (KindElement != null) dest.KindElement = (Code<OperationKind>)KindElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (Description != null) dest.Description = (Markdown)Description.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (Purpose != null) dest.Purpose = (Markdown)Purpose.DeepCopy();
                if (AffectsStateElement != null) dest.AffectsStateElement = (FhirBoolean)AffectsStateElement.DeepCopy();
                if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                if (Comment != null) dest.Comment = (Markdown)Comment.DeepCopy();
                if (BaseElement != null) dest.BaseElement = (Canonical)BaseElement.DeepCopy();
                if (ResourceElement != null) dest.ResourceElement = new List<Code<ResourceType>>(ResourceElement.DeepCopy());
                if (SystemElement != null) dest.SystemElement = (FhirBoolean)SystemElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = (FhirBoolean)TypeElement.DeepCopy();
                if (InstanceElement != null) dest.InstanceElement = (FhirBoolean)InstanceElement.DeepCopy();
                if (InputProfileElement != null) dest.InputProfileElement = (Canonical)InputProfileElement.DeepCopy();
                if (OutputProfileElement != null) dest.OutputProfileElement = (Canonical)OutputProfileElement.DeepCopy();
                if (Parameter != null) dest.Parameter = new List<ParameterComponent>(Parameter.DeepCopy());
                if (Overload != null) dest.Overload = new List<OverloadComponent>(Overload.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new OperationDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as OperationDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Description, otherT.Description)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.Matches(AffectsStateElement, otherT.AffectsStateElement)) return false;
            if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
            if (!DeepComparable.Matches(Comment, otherT.Comment)) return false;
            if (!DeepComparable.Matches(BaseElement, otherT.BaseElement)) return false;
            if ( !DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;
            if (!DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(InstanceElement, otherT.InstanceElement)) return false;
            if (!DeepComparable.Matches(InputProfileElement, otherT.InputProfileElement)) return false;
            if (!DeepComparable.Matches(OutputProfileElement, otherT.OutputProfileElement)) return false;
            if ( !DeepComparable.Matches(Parameter, otherT.Parameter)) return false;
            if ( !DeepComparable.Matches(Overload, otherT.Overload)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as OperationDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.IsExactly(AffectsStateElement, otherT.AffectsStateElement)) return false;
            if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
            if (!DeepComparable.IsExactly(Comment, otherT.Comment)) return false;
            if (!DeepComparable.IsExactly(BaseElement, otherT.BaseElement)) return false;
            if (!DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;
            if (!DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(InstanceElement, otherT.InstanceElement)) return false;
            if (!DeepComparable.IsExactly(InputProfileElement, otherT.InputProfileElement)) return false;
            if (!DeepComparable.IsExactly(OutputProfileElement, otherT.OutputProfileElement)) return false;
            if (!DeepComparable.IsExactly(Parameter, otherT.Parameter)) return false;
            if (!DeepComparable.IsExactly(Overload, otherT.Overload)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (TitleElement != null) yield return TitleElement;
                if (StatusElement != null) yield return StatusElement;
                if (KindElement != null) yield return KindElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Description != null) yield return Description;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (Purpose != null) yield return Purpose;
                if (AffectsStateElement != null) yield return AffectsStateElement;
                if (CodeElement != null) yield return CodeElement;
                if (Comment != null) yield return Comment;
                if (BaseElement != null) yield return BaseElement;
                foreach (var elem in ResourceElement) { if (elem != null) yield return elem; }
                if (SystemElement != null) yield return SystemElement;
                if (TypeElement != null) yield return TypeElement;
                if (InstanceElement != null) yield return InstanceElement;
                if (InputProfileElement != null) yield return InputProfileElement;
                if (OutputProfileElement != null) yield return OutputProfileElement;
                foreach (var elem in Parameter) { if (elem != null) yield return elem; }
                foreach (var elem in Overload) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (KindElement != null) yield return new ElementValue("kind", KindElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (Purpose != null) yield return new ElementValue("purpose", Purpose);
                if (AffectsStateElement != null) yield return new ElementValue("affectsState", AffectsStateElement);
                if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                if (Comment != null) yield return new ElementValue("comment", Comment);
                if (BaseElement != null) yield return new ElementValue("base", BaseElement);
                foreach (var elem in ResourceElement) { if (elem != null) yield return new ElementValue("resource", elem); }
                if (SystemElement != null) yield return new ElementValue("system", SystemElement);
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (InstanceElement != null) yield return new ElementValue("instance", InstanceElement);
                if (InputProfileElement != null) yield return new ElementValue("inputProfile", InputProfileElement);
                if (OutputProfileElement != null) yield return new ElementValue("outputProfile", OutputProfileElement);
                foreach (var elem in Parameter) { if (elem != null) yield return new ElementValue("parameter", elem); }
                foreach (var elem in Overload) { if (elem != null) yield return new ElementValue("overload", elem); }
            }
        }

    }

}
