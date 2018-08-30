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

        /// <summary>
        /// The degree to which the server supports the code search parameter on ValueSet, if it is supported.
        /// (url: http://hl7.org/fhir/ValueSet/code-search-support)
        /// </summary>
        [FhirEnumeration("CodeSearchSupport")]
        public enum CodeSearchSupport
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/code-search-support)
            /// </summary>
            [EnumLiteral("explicit", "http://hl7.org/fhir/code-search-support"), Description("Explicit Codes")]
            Explicit,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/code-search-support)
            /// </summary>
            [EnumLiteral("all", "http://hl7.org/fhir/code-search-support"), Description("Implicit Codes")]
            All,
        }


        [FhirType("SoftwareComponent")]
        [DataContract]
        public partial class SoftwareComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SoftwareComponent"; } }

            /// <summary>
            /// A name the software is known by
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// A name the software is known by
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
            /// Version covered by this statement
            /// </summary>
            [FhirElement("version", InSummary=true, Order=50)]
            [DataMember]
            public FhirString VersionElement
            {
                get { return _versionElement; }
                set { _versionElement = value; OnPropertyChanged("VersionElement"); }
            }

            private FhirString _versionElement;

            /// <summary>
            /// Version covered by this statement
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SoftwareComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SoftwareComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SoftwareComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SoftwareComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (VersionElement != null) yield return VersionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                }
            }


        }


        [FhirType("ImplementationComponent")]
        [DataContract]
        public partial class ImplementationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ImplementationComponent"; } }

            /// <summary>
            /// Describes this specific instance
            /// </summary>
            [FhirElement("description", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Describes this specific instance
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
            /// Base URL for the implementation
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [DataMember]
            public FhirUrl UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUrl _urlElement;

            /// <summary>
            /// Base URL for the implementation
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
                        UrlElement = new FhirUrl(value);
                    OnPropertyChanged("Url");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ImplementationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (FhirUrl)UrlElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ImplementationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ImplementationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ImplementationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (UrlElement != null) yield return UrlElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                }
            }


        }


        [FhirType("CodeSystemComponent")]
        [DataContract]
        public partial class CodeSystemComponent : BackboneElement, IBackboneElement
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

            /// <summary>
            /// Whether subsumption is supported
            /// </summary>
            [FhirElement("subsumption", Order=60)]
            [DataMember]
            public FhirBoolean SubsumptionElement
            {
                get { return _subsumptionElement; }
                set { _subsumptionElement = value; OnPropertyChanged("SubsumptionElement"); }
            }

            private FhirBoolean _subsumptionElement;

            /// <summary>
            /// Whether subsumption is supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Subsumption
            {
                get { return SubsumptionElement != null ? SubsumptionElement.Value : null; }
                set
                {
                    if (value == null)
                        SubsumptionElement = null;
                    else
                        SubsumptionElement = new FhirBoolean(value);
                    OnPropertyChanged("Subsumption");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CodeSystemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (UriElement != null) dest.UriElement = (Canonical)UriElement.DeepCopy();
                    if (Version != null) dest.Version = new List<VersionComponent>(Version.DeepCopy());
                    if (SubsumptionElement != null) dest.SubsumptionElement = (FhirBoolean)SubsumptionElement.DeepCopy();
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
                if (!DeepComparable.Matches(SubsumptionElement, otherT.SubsumptionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CodeSystemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.IsExactly(Version, otherT.Version)) return false;
                if (!DeepComparable.IsExactly(SubsumptionElement, otherT.SubsumptionElement)) return false;

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
                    if (SubsumptionElement != null) yield return SubsumptionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                    foreach (var elem in Version) { if (elem != null) yield return new ElementValue("version", elem); }
                    if (SubsumptionElement != null) yield return new ElementValue("subsumption", SubsumptionElement);
                }
            }


        }


        [FhirType("VersionComponent")]
        [DataContract]
        public partial class VersionComponent : BackboneElement, IBackboneElement
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
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (IsDefaultElement != null) yield return new ElementValue("isDefault", IsDefaultElement);
                    if (CompositionalElement != null) yield return new ElementValue("compositional", CompositionalElement);
                    foreach (var elem in LanguageElement) { if (elem != null) yield return new ElementValue("language", elem); }
                    foreach (var elem in Filter) { if (elem != null) yield return new ElementValue("filter", elem); }
                    foreach (var elem in PropertyElement) { if (elem != null) yield return new ElementValue("property", elem); }
                }
            }


        }


        [FhirType("FilterComponent")]
        [DataContract]
        public partial class FilterComponent : BackboneElement, IBackboneElement
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
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    foreach (var elem in OpElement) { if (elem != null) yield return new ElementValue("op", elem); }
                }
            }


        }


        [FhirType("ExpansionComponent")]
        [DataContract]
        public partial class ExpansionComponent : BackboneElement, IBackboneElement
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
            /// Supported expansion parameter
            /// </summary>
            [FhirElement("parameter", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParameterComponent> Parameter
            {
                get { if (_parameter==null) _parameter = new List<ParameterComponent>(); return _parameter; }
                set { _parameter = value; OnPropertyChanged("Parameter"); }
            }

            private List<ParameterComponent> _parameter;

            /// <summary>
            /// Documentation about text searching works
            /// </summary>
            [FhirElement("textFilter", Order=80)]
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
                    if (Parameter != null) dest.Parameter = new List<ParameterComponent>(Parameter.DeepCopy());
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
                if ( !DeepComparable.Matches(Parameter, otherT.Parameter)) return false;
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
                if (!DeepComparable.IsExactly(Parameter, otherT.Parameter)) return false;
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
                    foreach (var elem in Parameter) { if (elem != null) yield return elem; }
                    if (TextFilter != null) yield return TextFilter;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (HierarchicalElement != null) yield return new ElementValue("hierarchical", HierarchicalElement);
                    if (PagingElement != null) yield return new ElementValue("paging", PagingElement);
                    if (IncompleteElement != null) yield return new ElementValue("incomplete", IncompleteElement);
                    foreach (var elem in Parameter) { if (elem != null) yield return new ElementValue("parameter", elem); }
                    if (TextFilter != null) yield return new ElementValue("textFilter", TextFilter);
                }
            }


        }


        [FhirType("ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }

            /// <summary>
            /// Expansion Parameter name
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
            /// Expansion Parameter name
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
            /// Description of support for parameter
            /// </summary>
            [FhirElement("documentation", Order=50)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Description of support for parameter
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParameterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (Code)NameElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
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
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                }
            }


        }


        [FhirType("ValidateCodeComponent")]
        [DataContract]
        public partial class ValidateCodeComponent : BackboneElement, IBackboneElement
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
                    if (TranslationsElement != null) yield return new ElementValue("translations", TranslationsElement);
                }
            }


        }


        [FhirType("TranslationComponent")]
        [DataContract]
        public partial class TranslationComponent : BackboneElement, IBackboneElement
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
                    if (NeedsMapElement != null) yield return new ElementValue("needsMap", NeedsMapElement);
                }
            }


        }


        [FhirType("ClosureComponent")]
        [DataContract]
        public partial class ClosureComponent : BackboneElement, IBackboneElement
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
                    if (TranslationElement != null) yield return new ElementValue("translation", TranslationElement);
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
        /// instance | capability | requirements
        /// </summary>
        [FhirElement("kind", InSummary=true, Order=230)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<CapabilityStatementKind> KindElement
        {
            get { return _kindElement; }
            set { _kindElement = value; OnPropertyChanged("KindElement"); }
        }

        private Code<CapabilityStatementKind> _kindElement;

        /// <summary>
        /// instance | capability | requirements
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CapabilityStatementKind? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (value == null)
                    KindElement = null;
                else
                    KindElement = new Code<CapabilityStatementKind>(value);
                OnPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// Software that is covered by this terminology capability statement
        /// </summary>
        [FhirElement("software", InSummary=true, Order=240)]
        [DataMember]
        public SoftwareComponent Software
        {
            get { return _software; }
            set { _software = value; OnPropertyChanged("Software"); }
        }

        private SoftwareComponent _software;

        /// <summary>
        /// If this describes a specific instance
        /// </summary>
        [FhirElement("implementation", InSummary=true, Order=250)]
        [DataMember]
        public ImplementationComponent Implementation
        {
            get { return _implementation; }
            set { _implementation = value; OnPropertyChanged("Implementation"); }
        }

        private ImplementationComponent _implementation;

        /// <summary>
        /// Whether lockedDate is supported
        /// </summary>
        [FhirElement("lockedDate", InSummary=true, Order=260)]
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
        [FhirElement("codeSystem", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeSystemComponent> CodeSystem
        {
            get { if (_codeSystem==null) _codeSystem = new List<CodeSystemComponent>(); return _codeSystem; }
            set { _codeSystem = value; OnPropertyChanged("CodeSystem"); }
        }

        private List<CodeSystemComponent> _codeSystem;

        /// <summary>
        /// Information about the [ValueSet/$expand](valueset-operation-expand.html) operation
        /// </summary>
        [FhirElement("expansion", Order=280)]
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
        [FhirElement("codeSearch", Order=290)]
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
        /// Information about the [ValueSet/$validate-code](valueset-operation-validate-code.html) operation
        /// </summary>
        [FhirElement("validateCode", Order=300)]
        [DataMember]
        public ValidateCodeComponent ValidateCode
        {
            get { return _validateCode; }
            set { _validateCode = value; OnPropertyChanged("ValidateCode"); }
        }

        private ValidateCodeComponent _validateCode;

        /// <summary>
        /// Information about the [ConceptMap/$translate](conceptmap-operation-translate.html) operation
        /// </summary>
        [FhirElement("translation", Order=310)]
        [DataMember]
        public TranslationComponent Translation
        {
            get { return _translation; }
            set { _translation = value; OnPropertyChanged("Translation"); }
        }

        private TranslationComponent _translation;

        /// <summary>
        /// Information about the [ConceptMap/$closure](conceptmap-operation-closure.html) operation
        /// </summary>
        [FhirElement("closure", Order=320)]
        [DataMember]
        public ClosureComponent Closure
        {
            get { return _closure; }
            set { _closure = value; OnPropertyChanged("Closure"); }
        }

        private ClosureComponent _closure;


        public static ElementDefinition.ConstraintComponent TerminologyCapabilities_TCP_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "tcp-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public static ElementDefinition.ConstraintComponent TerminologyCapabilities_TCP_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(kind != 'instance') or implementation.exists()",
            Key = "tcp-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If kind = instance, implementation must be present and software may be present",
            Xpath = "not(f:kind/@value='instance') or exists(f:implementation)"
        };

        public static ElementDefinition.ConstraintComponent TerminologyCapabilities_TCP_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(description.count() + software.count() + implementation.count()) > 0",
            Key = "tcp-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A Capability Statement SHALL have at least one of description, software, or implementation element.",
            Xpath = "count(f:software | f:implementation | f:description) > 0"
        };

        public static ElementDefinition.ConstraintComponent TerminologyCapabilities_TCP_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(kind!='requirements') or (implementation.exists().not() and software.exists().not())",
            Key = "tcp-5",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If kind = requirements, implementation and software must be absent",
            Xpath = "not(f:kind/@value='instance') or (not(exists(f:implementation)) and not(exists(f:software)))"
        };

        public static ElementDefinition.ConstraintComponent TerminologyCapabilities_TCP_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(kind != 'capability') or (implementation.exists().not() and software.exists())",
            Key = "tcp-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If kind = capability, implementation must be absent, software must be present",
            Xpath = " not(f:kind/@value='instance') or (not(exists(f:implementation)) and exists(f:software))"
        };

        public static ElementDefinition.ConstraintComponent TerminologyCapabilities_TCP_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "codeSystem.all(version.count() > 1 implies version.all(code.exists()))",
            Key = "tcp-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If there is more than one version, a version code must be defined",
            Xpath = "(count(f:version) <= 1) or not(exists(f:version[not(f:code)]))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(TerminologyCapabilities_TCP_0);
            InvariantConstraints.Add(TerminologyCapabilities_TCP_3);
            InvariantConstraints.Add(TerminologyCapabilities_TCP_2);
            InvariantConstraints.Add(TerminologyCapabilities_TCP_5);
            InvariantConstraints.Add(TerminologyCapabilities_TCP_4);
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
                if (KindElement != null) dest.KindElement = (Code<CapabilityStatementKind>)KindElement.DeepCopy();
                if (Software != null) dest.Software = (SoftwareComponent)Software.DeepCopy();
                if (Implementation != null) dest.Implementation = (ImplementationComponent)Implementation.DeepCopy();
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
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.Matches(Software, otherT.Software)) return false;
            if (!DeepComparable.Matches(Implementation, otherT.Implementation)) return false;
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
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(Software, otherT.Software)) return false;
            if (!DeepComparable.IsExactly(Implementation, otherT.Implementation)) return false;
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
                if (KindElement != null) yield return KindElement;
                if (Software != null) yield return Software;
                if (Implementation != null) yield return Implementation;
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
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (Purpose != null) yield return new ElementValue("purpose", Purpose);
                if (Copyright != null) yield return new ElementValue("copyright", Copyright);
                if (KindElement != null) yield return new ElementValue("kind", KindElement);
                if (Software != null) yield return new ElementValue("software", Software);
                if (Implementation != null) yield return new ElementValue("implementation", Implementation);
                if (LockedDateElement != null) yield return new ElementValue("lockedDate", LockedDateElement);
                foreach (var elem in CodeSystem) { if (elem != null) yield return new ElementValue("codeSystem", elem); }
                if (Expansion != null) yield return new ElementValue("expansion", Expansion);
                if (CodeSearchElement != null) yield return new ElementValue("codeSearch", CodeSearchElement);
                if (ValidateCode != null) yield return new ElementValue("validateCode", ValidateCode);
                if (Translation != null) yield return new ElementValue("translation", Translation);
                if (Closure != null) yield return new ElementValue("closure", Closure);
            }
        }

    }

}
