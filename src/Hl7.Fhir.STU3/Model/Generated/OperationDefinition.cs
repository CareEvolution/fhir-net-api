﻿using System;
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
            /// number | date | string | token | reference | composite | quantity | uri
            /// </summary>
            [FhirElement("searchType", Order=100)]
            [DataMember]
            public Code<SearchParamType> SearchTypeElement
            {
                get { return _searchTypeElement; }
                set { _searchTypeElement = value; OnPropertyChanged("SearchTypeElement"); }
            }

            private Code<SearchParamType> _searchTypeElement;

            /// <summary>
            /// number | date | string | token | reference | composite | quantity | uri
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
            /// Profile on the type
            /// </summary>
            [FhirElement("profile", Order=110)]
            [References("StructureDefinition")]
            [DataMember]
            public ResourceReference Profile
            {
                get { return _profile; }
                set { _profile = value; OnPropertyChanged("Profile"); }
            }

            private ResourceReference _profile;

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
            /// Parts of a nested Parameter
            /// </summary>
            [FhirElement("part", Order=130)]
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
                    if (SearchTypeElement != null) dest.SearchTypeElement = (Code<SearchParamType>)SearchTypeElement.DeepCopy();
                    if (Profile != null) dest.Profile = (ResourceReference)Profile.DeepCopy();
                    if (Binding != null) dest.Binding = (BindingComponent)Binding.DeepCopy();
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
                if (!DeepComparable.Matches(SearchTypeElement, otherT.SearchTypeElement)) return false;
                if (!DeepComparable.Matches(Profile, otherT.Profile)) return false;
                if (!DeepComparable.Matches(Binding, otherT.Binding)) return false;
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
                if (!DeepComparable.IsExactly(SearchTypeElement, otherT.SearchTypeElement)) return false;
                if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
                if (!DeepComparable.IsExactly(Binding, otherT.Binding)) return false;
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
                    if (SearchTypeElement != null) yield return SearchTypeElement;
                    if (Profile != null) yield return Profile;
                    if (Binding != null) yield return Binding;
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
                    if (SearchTypeElement != null) yield return new ElementValue("searchType", SearchTypeElement);
                    if (Profile != null) yield return new ElementValue("profile", Profile);
                    if (Binding != null) yield return new ElementValue("binding", Binding);
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
            [FhirElement("valueSet", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirUri),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element ValueSet
            {
                get { return _valueSet; }
                set { _valueSet = value; OnPropertyChanged("ValueSet"); }
            }

            private Element _valueSet;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BindingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StrengthElement != null) dest.StrengthElement = (Code<BindingStrength>)StrengthElement.DeepCopy();
                    if (ValueSet != null) dest.ValueSet = (Element)ValueSet.DeepCopy();
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
                if (!DeepComparable.Matches(ValueSet, otherT.ValueSet)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BindingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StrengthElement, otherT.StrengthElement)) return false;
                if (!DeepComparable.IsExactly(ValueSet, otherT.ValueSet)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StrengthElement != null) yield return StrengthElement;
                    if (ValueSet != null) yield return ValueSet;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StrengthElement != null) yield return new ElementValue("strength", StrengthElement);
                    if (ValueSet != null) yield return new ElementValue("valueSet", ValueSet);
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
        /// Logical URI to reference this operation definition (globally unique)
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
        /// Logical URI to reference this operation definition (globally unique)
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
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
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
        [FhirElement("kind", Order=130)]
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
        [FhirElement("experimental", InSummary=true, Order=140)]
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
        /// Date this was last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=150)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date this was last changed
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
        [FhirElement("publisher", InSummary=true, Order=160)]
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
        [FhirElement("contact", InSummary=true, Order=170)]
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
        [FhirElement("description", Order=180)]
        [DataMember]
        public Markdown DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private Markdown _descriptionElement;

        /// <summary>
        /// Natural language description of the operation definition
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
        /// Context the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=190)]
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
        [FhirElement("jurisdiction", InSummary=true, Order=200)]
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
        [FhirElement("purpose", Order=210)]
        [DataMember]
        public Markdown PurposeElement
        {
            get { return _purposeElement; }
            set { _purposeElement = value; OnPropertyChanged("PurposeElement"); }
        }

        private Markdown _purposeElement;

        /// <summary>
        /// Why this operation definition is defined
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
        /// Whether content is unchanged by the operation
        /// </summary>
        [FhirElement("idempotent", InSummary=true, Order=220)]
        [DataMember]
        public FhirBoolean IdempotentElement
        {
            get { return _idempotentElement; }
            set { _idempotentElement = value; OnPropertyChanged("IdempotentElement"); }
        }

        private FhirBoolean _idempotentElement;

        /// <summary>
        /// Whether content is unchanged by the operation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Idempotent
        {
            get { return IdempotentElement != null ? IdempotentElement.Value : null; }
            set
            {
                if (value == null)
                    IdempotentElement = null;
                else
                    IdempotentElement = new FhirBoolean(value);
                OnPropertyChanged("Idempotent");
            }
        }

        /// <summary>
        /// Name used to invoke the operation
        /// </summary>
        [FhirElement("code", InSummary=true, Order=230)]
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
        [FhirElement("comment", Order=240)]
        [DataMember]
        public FhirString CommentElement
        {
            get { return _commentElement; }
            set { _commentElement = value; OnPropertyChanged("CommentElement"); }
        }

        private FhirString _commentElement;

        /// <summary>
        /// Additional information about use
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

        /// <summary>
        /// Marks this as a profile of the base
        /// </summary>
        [FhirElement("base", InSummary=true, Order=250)]
        [References("OperationDefinition")]
        [DataMember]
        public ResourceReference Base
        {
            get { return _base; }
            set { _base = value; OnPropertyChanged("Base"); }
        }

        private ResourceReference _base;

        /// <summary>
        /// Types this operation applies to
        /// </summary>
        [FhirElement("resource", InSummary=true, Order=260)]
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
        [FhirElement("system", InSummary=true, Order=270)]
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
        /// Invole at the type level?
        /// </summary>
        [FhirElement("type", InSummary=true, Order=280)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirBoolean TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private FhirBoolean _typeElement;

        /// <summary>
        /// Invole at the type level?
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
        [FhirElement("instance", InSummary=true, Order=290)]
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
        /// Parameters for the operation/query
        /// </summary>
        [FhirElement("parameter", Order=300)]
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
        [FhirElement("overload", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<OverloadComponent> Overload
        {
            get { if (_overload==null) _overload = new List<OverloadComponent>(); return _overload; }
            set { _overload = value; OnPropertyChanged("Overload"); }
        }

        private List<OverloadComponent> _overload;


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
            Expression = "parameter.all(searchType implies type = 'string')",
            Key = "opd-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A search type can only be specified for parameters of type string",
            Xpath = "not(exists(f:searchType)) or (f:type/@value = 'string')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(OperationDefinition_OPD_1);
            InvariantConstraints.Add(OperationDefinition_OPD_2);
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
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (KindElement != null) dest.KindElement = (Code<OperationKind>)KindElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (PurposeElement != null) dest.PurposeElement = (Markdown)PurposeElement.DeepCopy();
                if (IdempotentElement != null) dest.IdempotentElement = (FhirBoolean)IdempotentElement.DeepCopy();
                if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                if (Base != null) dest.Base = (ResourceReference)Base.DeepCopy();
                if (ResourceElement != null) dest.ResourceElement = new List<Code<ResourceType>>(ResourceElement.DeepCopy());
                if (SystemElement != null) dest.SystemElement = (FhirBoolean)SystemElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = (FhirBoolean)TypeElement.DeepCopy();
                if (InstanceElement != null) dest.InstanceElement = (FhirBoolean)InstanceElement.DeepCopy();
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
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.Matches(IdempotentElement, otherT.IdempotentElement)) return false;
            if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.Matches(Base, otherT.Base)) return false;
            if ( !DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;
            if (!DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(InstanceElement, otherT.InstanceElement)) return false;
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
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.IsExactly(IdempotentElement, otherT.IdempotentElement)) return false;
            if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.IsExactly(Base, otherT.Base)) return false;
            if (!DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;
            if (!DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(InstanceElement, otherT.InstanceElement)) return false;
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
                if (StatusElement != null) yield return StatusElement;
                if (KindElement != null) yield return KindElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (PurposeElement != null) yield return PurposeElement;
                if (IdempotentElement != null) yield return IdempotentElement;
                if (CodeElement != null) yield return CodeElement;
                if (CommentElement != null) yield return CommentElement;
                if (Base != null) yield return Base;
                foreach (var elem in ResourceElement) { if (elem != null) yield return elem; }
                if (SystemElement != null) yield return SystemElement;
                if (TypeElement != null) yield return TypeElement;
                if (InstanceElement != null) yield return InstanceElement;
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
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (KindElement != null) yield return new ElementValue("kind", KindElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (PurposeElement != null) yield return new ElementValue("purpose", PurposeElement);
                if (IdempotentElement != null) yield return new ElementValue("idempotent", IdempotentElement);
                if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                if (Base != null) yield return new ElementValue("base", Base);
                foreach (var elem in ResourceElement) { if (elem != null) yield return new ElementValue("resource", elem); }
                if (SystemElement != null) yield return new ElementValue("system", SystemElement);
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (InstanceElement != null) yield return new ElementValue("instance", InstanceElement);
                foreach (var elem in Parameter) { if (elem != null) yield return new ElementValue("parameter", elem); }
                foreach (var elem in Overload) { if (elem != null) yield return new ElementValue("overload", elem); }
            }
        }

    }

}
