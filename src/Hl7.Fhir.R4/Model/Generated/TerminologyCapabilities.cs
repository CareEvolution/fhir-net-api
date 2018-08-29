using System;
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
    /// A statement of system capabilities
    /// </summary>
    [FhirType("TerminologyCapabilities", IsResource=true)]
    [DataContract]
    public partial class TerminologyCapabilities : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.TerminologyCapabilities; } }
        [NotMapped]
        public override string TypeName { get { return "TerminologyCapabilities"; } }


        [FhirType("CodeSystemComponent")]
        [DataContract]
        public partial class CodeSystemComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CodeSystemComponent"; } }

            /// <summary>
            /// URI for the Code System
            /// </summary>
            [FhirElement("uri", Order=40)]
            [DataMember]
            public Canonical UriElement
            {
                get { return _uriElement; }
                set { _uriElement = value; OnPropertyChanged("UriElement"); }
            }

            private Canonical _uriElement;

            /// <summary>
            /// URI for the Code System
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Uri
            {
                get { return UriElement != null ? UriElement.Value : null; }
                set
                {
                    if (value == null)
                        UriElement = null;
                    else
                        UriElement = new Canonical(value);
                    OnPropertyChanged("Uri");
                }
            }

            /// <summary>
            /// Version of Code System supported
            /// </summary>
            [FhirElement("version", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<VersionComponent> Version
            {
                get { if (_version==null) _version = new List<VersionComponent>(); return _version; }
                set { _version = value; OnPropertyChanged("Version"); }
            }

            private List<VersionComponent> _version;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CodeSystemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UriElement != null) dest.UriElement = (Canonical)UriElement.DeepCopy();
                    if (Version != null) dest.Version = new List<VersionComponent>(Version.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CodeSystemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CodeSystemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(UriElement, otherT.UriElement)) return false;
                if ( !DeepComparable.Matches(Version, otherT.Version)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CodeSystemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.IsExactly(Version, otherT.Version)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (UriElement != null) yield return UriElement;
                    foreach (var elem in Version) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (UriElement != null) yield return new ElementValue("uri", false, UriElement);
                    foreach (var elem in Version) { if (elem != null) yield return new ElementValue("version", true, elem); }
                }
            }


        }


        [FhirType("VersionComponent")]
        [DataContract]
        public partial class VersionComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "VersionComponent"; } }

            /// <summary>
            /// Version identifier for this version
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public FhirString CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private FhirString _codeElement;

            /// <summary>
            /// Version identifier for this version
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
                        CodeElement = new FhirString(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// If this is the default version for this code system
            /// </summary>
            [FhirElement("isDefault", InSummary=true, Order=50)]
            [DataMember]
            public FhirBoolean IsDefaultElement
            {
                get { return _isDefaultElement; }
                set { _isDefaultElement = value; OnPropertyChanged("IsDefaultElement"); }
            }

            private FhirBoolean _isDefaultElement;

            /// <summary>
            /// If this is the default version for this code system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? IsDefault
            {
                get { return IsDefaultElement != null ? IsDefaultElement.Value : null; }
                set
                {
                    if (value == null)
                        IsDefaultElement = null;
                    else
                        IsDefaultElement = new FhirBoolean(value);
                    OnPropertyChanged("IsDefault");
                }
            }

            /// <summary>
            /// If compositional grammar is supported
            /// </summary>
            [FhirElement("compositional", Order=60)]
            [DataMember]
            public FhirBoolean CompositionalElement
            {
                get { return _compositionalElement; }
                set { _compositionalElement = value; OnPropertyChanged("CompositionalElement"); }
            }

            private FhirBoolean _compositionalElement;

            /// <summary>
            /// If compositional grammar is supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Compositional
            {
                get { return CompositionalElement != null ? CompositionalElement.Value : null; }
                set
                {
                    if (value == null)
                        CompositionalElement = null;
                    else
                        CompositionalElement = new FhirBoolean(value);
                    OnPropertyChanged("Compositional");
                }
            }

            /// <summary>
            /// Language Displays supported
            /// </summary>
            [FhirElement("language", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code> LanguageElement
            {
                get { if (_languageElement==null) _languageElement = new List<Code>(); return _languageElement; }
                set { _languageElement = value; OnPropertyChanged("LanguageElement"); }
            }

            private List<Code> _languageElement;

            /// <summary>
            /// Language Displays supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Language
            {
                get { return LanguageElement != null ? LanguageElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        LanguageElement = null;
                    else
                        LanguageElement = new List<Code>(value.Select(elem=>new Code(elem)));
                    OnPropertyChanged("Language");
                }
            }

            /// <summary>
            /// Filter Properties supported
            /// </summary>
            [FhirElement("filter", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FilterComponent> Filter
            {
                get { if (_filter==null) _filter = new List<FilterComponent>(); return _filter; }
                set { _filter = value; OnPropertyChanged("Filter"); }
            }

            private List<FilterComponent> _filter;

            /// <summary>
            /// Properties supported for $lookup
            /// </summary>
            [FhirElement("property", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code> PropertyElement
            {
                get { if (_propertyElement==null) _propertyElement = new List<Code>(); return _propertyElement; }
                set { _propertyElement = value; OnPropertyChanged("PropertyElement"); }
            }

            private List<Code> _propertyElement;

            /// <summary>
            /// Properties supported for $lookup
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Property
            {
                get { return PropertyElement != null ? PropertyElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PropertyElement = null;
                    else
                        PropertyElement = new List<Code>(value.Select(elem=>new Code(elem)));
                    OnPropertyChanged("Property");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VersionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (FhirString)CodeElement.DeepCopy();
                    if (IsDefaultElement != null) dest.IsDefaultElement = (FhirBoolean)IsDefaultElement.DeepCopy();
                    if (CompositionalElement != null) dest.CompositionalElement = (FhirBoolean)CompositionalElement.DeepCopy();
                    if (LanguageElement != null) dest.LanguageElement = new List<Code>(LanguageElement.DeepCopy());
                    if (Filter != null) dest.Filter = new List<FilterComponent>(Filter.DeepCopy());
                    if (PropertyElement != null) dest.PropertyElement = new List<Code>(PropertyElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new VersionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VersionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(IsDefaultElement, otherT.IsDefaultElement)) return false;
                if (!DeepComparable.Matches(CompositionalElement, otherT.CompositionalElement)) return false;
                if ( !DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if ( !DeepComparable.Matches(Filter, otherT.Filter)) return false;
                if ( !DeepComparable.Matches(PropertyElement, otherT.PropertyElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VersionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(IsDefaultElement, otherT.IsDefaultElement)) return false;
                if (!DeepComparable.IsExactly(CompositionalElement, otherT.CompositionalElement)) return false;
                if (!DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.IsExactly(Filter, otherT.Filter)) return false;
                if (!DeepComparable.IsExactly(PropertyElement, otherT.PropertyElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (IsDefaultElement != null) yield return IsDefaultElement;
                    if (CompositionalElement != null) yield return CompositionalElement;
                    foreach (var elem in LanguageElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Filter) { if (elem != null) yield return elem; }
                    foreach (var elem in PropertyElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", false, CodeElement);
                    if (IsDefaultElement != null) yield return new ElementValue("isDefault", false, IsDefaultElement);
                    if (CompositionalElement != null) yield return new ElementValue("compositional", false, CompositionalElement);
                    foreach (var elem in LanguageElement) { if (elem != null) yield return new ElementValue("language", true, elem); }
                    foreach (var elem in Filter) { if (elem != null) yield return new ElementValue("filter", true, elem); }
                    foreach (var elem in PropertyElement) { if (elem != null) yield return new ElementValue("property", true, elem); }
                }
            }


        }


        [FhirType("FilterComponent")]
        [DataContract]
        public partial class FilterComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FilterComponent"; } }

            /// <summary>
            /// Code of the property supported
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code _codeElement;

            /// <summary>
            /// Code of the property supported
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
            /// Operations supported for the property
            /// </summary>
            [FhirElement("op", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Code> OpElement
            {
                get { if (_opElement==null) _opElement = new List<Code>(); return _opElement; }
                set { _opElement = value; OnPropertyChanged("OpElement"); }
            }

            private List<Code> _opElement;

            /// <summary>
            /// Operations supported for the property
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Op
            {
                get { return OpElement != null ? OpElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        OpElement = null;
                    else
                        OpElement = new List<Code>(value.Select(elem=>new Code(elem)));
                    OnPropertyChanged("Op");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FilterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (OpElement != null) dest.OpElement = new List<Code>(OpElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FilterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FilterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if ( !DeepComparable.Matches(OpElement, otherT.OpElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FilterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(OpElement, otherT.OpElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    foreach (var elem in OpElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", false, CodeElement);
                    foreach (var elem in OpElement) { if (elem != null) yield return new ElementValue("op", true, elem); }
                }
            }


        }


        [FhirType("ExpansionComponent")]
        [DataContract]
        public partial class ExpansionComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ExpansionComponent"; } }

            /// <summary>
            /// Whether the server can return nested value sets
            /// </summary>
            [FhirElement("hierarchical", Order=40)]
            [DataMember]
            public FhirBoolean HierarchicalElement
            {
                get { return _hierarchicalElement; }
                set { _hierarchicalElement = value; OnPropertyChanged("HierarchicalElement"); }
            }

            private FhirBoolean _hierarchicalElement;

            /// <summary>
            /// Whether the server can return nested value sets
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Hierarchical
            {
                get { return HierarchicalElement != null ? HierarchicalElement.Value : null; }
                set
                {
                    if (value == null)
                        HierarchicalElement = null;
                    else
                        HierarchicalElement = new FhirBoolean(value);
                    OnPropertyChanged("Hierarchical");
                }
            }

            /// <summary>
            /// Whether the server supports paging on expansion
            /// </summary>
            [FhirElement("paging", Order=50)]
            [DataMember]
            public FhirBoolean PagingElement
            {
                get { return _pagingElement; }
                set { _pagingElement = value; OnPropertyChanged("PagingElement"); }
            }

            private FhirBoolean _pagingElement;

            /// <summary>
            /// Whether the server supports paging on expansion
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Paging
            {
                get { return PagingElement != null ? PagingElement.Value : null; }
                set
                {
                    if (value == null)
                        PagingElement = null;
                    else
                        PagingElement = new FhirBoolean(value);
                    OnPropertyChanged("Paging");
                }
            }

            /// <summary>
            /// Allow request for incomplete expansions?
            /// </summary>
            [FhirElement("incomplete", Order=60)]
            [DataMember]
            public FhirBoolean IncompleteElement
            {
                get { return _incompleteElement; }
                set { _incompleteElement = value; OnPropertyChanged("IncompleteElement"); }
            }

            private FhirBoolean _incompleteElement;

            /// <summary>
            /// Allow request for incomplete expansions?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Incomplete
            {
                get { return IncompleteElement != null ? IncompleteElement.Value : null; }
                set
                {
                    if (value == null)
                        IncompleteElement = null;
                    else
                        IncompleteElement = new FhirBoolean(value);
                    OnPropertyChanged("Incomplete");
                }
            }

            /// <summary>
            /// Supported fields on ExpansionProfile
            /// </summary>
            [FhirElement("definition", Order=70)]
            [DataMember]
            public Canonical DefinitionElement
            {
                get { return _definitionElement; }
                set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
            }

            private Canonical _definitionElement;

            /// <summary>
            /// Supported fields on ExpansionProfile
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Definition
            {
                get { return DefinitionElement != null ? DefinitionElement.Value : null; }
                set
                {
                    if (value == null)
                        DefinitionElement = null;
                    else
                        DefinitionElement = new Canonical(value);
                    OnPropertyChanged("Definition");
                }
            }

            /// <summary>
            /// Supported expansion profiles
            /// </summary>
            [FhirElement("profile", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Canonical> ProfileElement
            {
                get { if (_profileElement==null) _profileElement = new List<Canonical>(); return _profileElement; }
                set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
            }

            private List<Canonical> _profileElement;

            /// <summary>
            /// Supported expansion profiles
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
            /// Documentation about text searching works
            /// </summary>
            [FhirElement("textFilter", Order=90)]
            [DataMember]
            public Markdown TextFilter
            {
                get { return _textFilter; }
                set { _textFilter = value; OnPropertyChanged("TextFilter"); }
            }

            private Markdown _textFilter;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ExpansionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (HierarchicalElement != null) dest.HierarchicalElement = (FhirBoolean)HierarchicalElement.DeepCopy();
                    if (PagingElement != null) dest.PagingElement = (FhirBoolean)PagingElement.DeepCopy();
                    if (IncompleteElement != null) dest.IncompleteElement = (FhirBoolean)IncompleteElement.DeepCopy();
                    if (DefinitionElement != null) dest.DefinitionElement = (Canonical)DefinitionElement.DeepCopy();
                    if (ProfileElement != null) dest.ProfileElement = new List<Canonical>(ProfileElement.DeepCopy());
                    if (TextFilter != null) dest.TextFilter = (Markdown)TextFilter.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ExpansionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ExpansionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(HierarchicalElement, otherT.HierarchicalElement)) return false;
                if (!DeepComparable.Matches(PagingElement, otherT.PagingElement)) return false;
                if (!DeepComparable.Matches(IncompleteElement, otherT.IncompleteElement)) return false;
                if (!DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
                if ( !DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;
                if (!DeepComparable.Matches(TextFilter, otherT.TextFilter)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExpansionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(HierarchicalElement, otherT.HierarchicalElement)) return false;
                if (!DeepComparable.IsExactly(PagingElement, otherT.PagingElement)) return false;
                if (!DeepComparable.IsExactly(IncompleteElement, otherT.IncompleteElement)) return false;
                if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;
                if (!DeepComparable.IsExactly(TextFilter, otherT.TextFilter)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (HierarchicalElement != null) yield return HierarchicalElement;
                    if (PagingElement != null) yield return PagingElement;
                    if (IncompleteElement != null) yield return IncompleteElement;
                    if (DefinitionElement != null) yield return DefinitionElement;
                    foreach (var elem in ProfileElement) { if (elem != null) yield return elem; }
                    if (TextFilter != null) yield return TextFilter;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (HierarchicalElement != null) yield return new ElementValue("hierarchical", false, HierarchicalElement);
                    if (PagingElement != null) yield return new ElementValue("paging", false, PagingElement);
                    if (IncompleteElement != null) yield return new ElementValue("incomplete", false, IncompleteElement);
                    if (DefinitionElement != null) yield return new ElementValue("definition", false, DefinitionElement);
                    foreach (var elem in ProfileElement) { if (elem != null) yield return new ElementValue("profile", true, elem); }
                    if (TextFilter != null) yield return new ElementValue("textFilter", false, TextFilter);
                }
            }


        }


        [FhirType("ValidateCodeComponent")]
        [DataContract]
        public partial class ValidateCodeComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ValidateCodeComponent"; } }

            /// <summary>
            /// Whether translations are validated
            /// </summary>
            [FhirElement("translations", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean TranslationsElement
            {
                get { return _translationsElement; }
                set { _translationsElement = value; OnPropertyChanged("TranslationsElement"); }
            }

            private FhirBoolean _translationsElement;

            /// <summary>
            /// Whether translations are validated
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Translations
            {
                get { return TranslationsElement != null ? TranslationsElement.Value : null; }
                set
                {
                    if (value == null)
                        TranslationsElement = null;
                    else
                        TranslationsElement = new FhirBoolean(value);
                    OnPropertyChanged("Translations");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ValidateCodeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TranslationsElement != null) dest.TranslationsElement = (FhirBoolean)TranslationsElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ValidateCodeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ValidateCodeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TranslationsElement, otherT.TranslationsElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ValidateCodeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TranslationsElement, otherT.TranslationsElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TranslationsElement != null) yield return TranslationsElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TranslationsElement != null) yield return new ElementValue("translations", false, TranslationsElement);
                }
            }


        }


        [FhirType("TranslationComponent")]
        [DataContract]
        public partial class TranslationComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TranslationComponent"; } }

            /// <summary>
            /// Whether the client must identify the map
            /// </summary>
            [FhirElement("needsMap", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean NeedsMapElement
            {
                get { return _needsMapElement; }
                set { _needsMapElement = value; OnPropertyChanged("NeedsMapElement"); }
            }

            private FhirBoolean _needsMapElement;

            /// <summary>
            /// Whether the client must identify the map
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? NeedsMap
            {
                get { return NeedsMapElement != null ? NeedsMapElement.Value : null; }
                set
                {
                    if (value == null)
                        NeedsMapElement = null;
                    else
                        NeedsMapElement = new FhirBoolean(value);
                    OnPropertyChanged("NeedsMap");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TranslationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NeedsMapElement != null) dest.NeedsMapElement = (FhirBoolean)NeedsMapElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TranslationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TranslationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NeedsMapElement, otherT.NeedsMapElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TranslationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NeedsMapElement, otherT.NeedsMapElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NeedsMapElement != null) yield return NeedsMapElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NeedsMapElement != null) yield return new ElementValue("needsMap", false, NeedsMapElement);
                }
            }


        }


        [FhirType("ClosureComponent")]
        [DataContract]
        public partial class ClosureComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ClosureComponent"; } }

            /// <summary>
            /// If cross-system closure is supported
            /// </summary>
            [FhirElement("translation", Order=40)]
            [DataMember]
            public FhirBoolean TranslationElement
            {
                get { return _translationElement; }
                set { _translationElement = value; OnPropertyChanged("TranslationElement"); }
            }

            private FhirBoolean _translationElement;

            /// <summary>
            /// If cross-system closure is supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Translation
            {
                get { return TranslationElement != null ? TranslationElement.Value : null; }
                set
                {
                    if (value == null)
                        TranslationElement = null;
                    else
                        TranslationElement = new FhirBoolean(value);
                    OnPropertyChanged("Translation");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClosureComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TranslationElement != null) dest.TranslationElement = (FhirBoolean)TranslationElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ClosureComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ClosureComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TranslationElement, otherT.TranslationElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClosureComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TranslationElement, otherT.TranslationElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TranslationElement != null) yield return TranslationElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TranslationElement != null) yield return new ElementValue("translation", false, TranslationElement);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this terminology capabilities, represented as a URI (globally unique)
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
        /// Canonical identifier for this terminology capabilities, represented as a URI (globally unique)
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
        /// Business version of the terminology capabilities
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
        /// Business version of the terminology capabilities
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
        /// Name for this terminology capabilities (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name for this terminology capabilities (computer friendly)
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
        /// Name for this terminology capabilities (human friendly)
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
        /// Name for this terminology capabilities (human friendly)
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
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
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
        /// Natural language description of the terminology capabilities
        /// </summary>
        [FhirElement("description", Order=180)]
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
        /// Intended jurisdiction for terminology capabilities (if applicable)
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
        /// Why this terminology capabilities is defined
        /// </summary>
        [FhirElement("purpose", Order=210)]
        [DataMember]
        public Markdown Purpose
        {
            get { return _purpose; }
            set { _purpose = value; OnPropertyChanged("Purpose"); }
        }

        private Markdown _purpose;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", InSummary=true, Order=220)]
        [DataMember]
        public Markdown Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        private Markdown _copyright;

        /// <summary>
        /// Whether lockedDate is supported
        /// </summary>
        [FhirElement("lockedDate", InSummary=true, Order=230)]
        [DataMember]
        public FhirBoolean LockedDateElement
        {
            get { return _lockedDateElement; }
            set { _lockedDateElement = value; OnPropertyChanged("LockedDateElement"); }
        }

        private FhirBoolean _lockedDateElement;

        /// <summary>
        /// Whether lockedDate is supported
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? LockedDate
        {
            get { return LockedDateElement != null ? LockedDateElement.Value : null; }
            set
            {
                if (value == null)
                    LockedDateElement = null;
                else
                    LockedDateElement = new FhirBoolean(value);
                OnPropertyChanged("LockedDate");
            }
        }

        /// <summary>
        /// A code system supported by the server
        /// </summary>
        [FhirElement("codeSystem", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeSystemComponent> CodeSystem
        {
            get { if (_codeSystem==null) _codeSystem = new List<CodeSystemComponent>(); return _codeSystem; }
            set { _codeSystem = value; OnPropertyChanged("CodeSystem"); }
        }

        private List<CodeSystemComponent> _codeSystem;

        /// <summary>
        /// Information about the $expansion operation
        /// </summary>
        [FhirElement("expansion", Order=250)]
        [DataMember]
        public ExpansionComponent Expansion
        {
            get { return _expansion; }
            set { _expansion = value; OnPropertyChanged("Expansion"); }
        }

        private ExpansionComponent _expansion;

        /// <summary>
        /// explicit | all
        /// </summary>
        [FhirElement("codeSearch", Order=260)]
        [DataMember]
        public Code<CodeSearchSupport> CodeSearchElement
        {
            get { return _codeSearchElement; }
            set { _codeSearchElement = value; OnPropertyChanged("CodeSearchElement"); }
        }

        private Code<CodeSearchSupport> _codeSearchElement;

        /// <summary>
        /// explicit | all
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CodeSearchSupport? CodeSearch
        {
            get { return CodeSearchElement != null ? CodeSearchElement.Value : null; }
            set
            {
                if (value == null)
                    CodeSearchElement = null;
                else
                    CodeSearchElement = new Code<CodeSearchSupport>(value);
                OnPropertyChanged("CodeSearch");
            }
        }

        /// <summary>
        /// Information about the $validation operation
        /// </summary>
        [FhirElement("validateCode", Order=270)]
        [DataMember]
        public ValidateCodeComponent ValidateCode
        {
            get { return _validateCode; }
            set { _validateCode = value; OnPropertyChanged("ValidateCode"); }
        }

        private ValidateCodeComponent _validateCode;

        /// <summary>
        /// Information about the $translation operation
        /// </summary>
        [FhirElement("translation", Order=280)]
        [DataMember]
        public TranslationComponent Translation
        {
            get { return _translation; }
            set { _translation = value; OnPropertyChanged("Translation"); }
        }

        private TranslationComponent _translation;

        /// <summary>
        /// Information about the $closure operation
        /// </summary>
        [FhirElement("closure", Order=290)]
        [DataMember]
        public ClosureComponent Closure
        {
            get { return _closure; }
            set { _closure = value; OnPropertyChanged("Closure"); }
        }

        private ClosureComponent _closure;


        public static ElementDefinition.ConstraintComponent TerminologyCapabilities_TCP_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "codeSystem.all(version.count() > 1 implies version.all(code.exists()))",
            Key = "tcp-1",
            Severity = ConstraintSeverity.Warning,
            Human = "If there is more than one version, a version code must be defined",
            Xpath = "(count(f:version) <= 1) or not(exists(f:version[not(f:code)]))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(TerminologyCapabilities_TCP_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as TerminologyCapabilities;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (Description != null) dest.Description = (Markdown)Description.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (Purpose != null) dest.Purpose = (Markdown)Purpose.DeepCopy();
                if (Copyright != null) dest.Copyright = (Markdown)Copyright.DeepCopy();
                if (LockedDateElement != null) dest.LockedDateElement = (FhirBoolean)LockedDateElement.DeepCopy();
                if (CodeSystem != null) dest.CodeSystem = new List<CodeSystemComponent>(CodeSystem.DeepCopy());
                if (Expansion != null) dest.Expansion = (ExpansionComponent)Expansion.DeepCopy();
                if (CodeSearchElement != null) dest.CodeSearchElement = (Code<CodeSearchSupport>)CodeSearchElement.DeepCopy();
                if (ValidateCode != null) dest.ValidateCode = (ValidateCodeComponent)ValidateCode.DeepCopy();
                if (Translation != null) dest.Translation = (TranslationComponent)Translation.DeepCopy();
                if (Closure != null) dest.Closure = (ClosureComponent)Closure.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new TerminologyCapabilities());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as TerminologyCapabilities;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Description, otherT.Description)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.Matches(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.Matches(LockedDateElement, otherT.LockedDateElement)) return false;
            if ( !DeepComparable.Matches(CodeSystem, otherT.CodeSystem)) return false;
            if (!DeepComparable.Matches(Expansion, otherT.Expansion)) return false;
            if (!DeepComparable.Matches(CodeSearchElement, otherT.CodeSearchElement)) return false;
            if (!DeepComparable.Matches(ValidateCode, otherT.ValidateCode)) return false;
            if (!DeepComparable.Matches(Translation, otherT.Translation)) return false;
            if (!DeepComparable.Matches(Closure, otherT.Closure)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as TerminologyCapabilities;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.IsExactly(LockedDateElement, otherT.LockedDateElement)) return false;
            if (!DeepComparable.IsExactly(CodeSystem, otherT.CodeSystem)) return false;
            if (!DeepComparable.IsExactly(Expansion, otherT.Expansion)) return false;
            if (!DeepComparable.IsExactly(CodeSearchElement, otherT.CodeSearchElement)) return false;
            if (!DeepComparable.IsExactly(ValidateCode, otherT.ValidateCode)) return false;
            if (!DeepComparable.IsExactly(Translation, otherT.Translation)) return false;
            if (!DeepComparable.IsExactly(Closure, otherT.Closure)) return false;

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
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Description != null) yield return Description;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (Purpose != null) yield return Purpose;
                if (Copyright != null) yield return Copyright;
                if (LockedDateElement != null) yield return LockedDateElement;
                foreach (var elem in CodeSystem) { if (elem != null) yield return elem; }
                if (Expansion != null) yield return Expansion;
                if (CodeSearchElement != null) yield return CodeSearchElement;
                if (ValidateCode != null) yield return ValidateCode;
                if (Translation != null) yield return Translation;
                if (Closure != null) yield return Closure;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", false, UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", false, VersionElement);
                if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                if (TitleElement != null) yield return new ElementValue("title", false, TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", false, ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", false, PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", true, elem); }
                if (Description != null) yield return new ElementValue("description", false, Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", true, elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", true, elem); }
                if (Purpose != null) yield return new ElementValue("purpose", false, Purpose);
                if (Copyright != null) yield return new ElementValue("copyright", false, Copyright);
                if (LockedDateElement != null) yield return new ElementValue("lockedDate", false, LockedDateElement);
                foreach (var elem in CodeSystem) { if (elem != null) yield return new ElementValue("codeSystem", true, elem); }
                if (Expansion != null) yield return new ElementValue("expansion", false, Expansion);
                if (CodeSearchElement != null) yield return new ElementValue("codeSearch", false, CodeSearchElement);
                if (ValidateCode != null) yield return new ElementValue("validateCode", false, ValidateCode);
                if (Translation != null) yield return new ElementValue("translation", false, Translation);
                if (Closure != null) yield return new ElementValue("closure", false, Closure);
            }
        }

    }

}
