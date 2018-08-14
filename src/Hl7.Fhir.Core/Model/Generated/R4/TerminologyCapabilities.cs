using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
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
    [FhirType(Hl7.Fhir.Model.Version.R4, "TerminologyCapabilities", IsResource=true)]
    [DataContract]
    public partial class TerminologyCapabilities : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.TerminologyCapabilities; } }
        [NotMapped]
        public override string TypeName { get { return "TerminologyCapabilities"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "CodeSystemComponent")]
        [DataContract]
        public partial class CodeSystemComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CodeSystemComponent"; } }
            
            /// <summary>
            /// URI for the Code System
            /// </summary>
            [FhirElement("uri", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.canonical Uri
            {
                get { return _Uri; }
                set { _Uri = value; OnPropertyChanged("Uri"); }
            }
            
            private Hl7.Fhir.Model.canonical _Uri;
            
            /// <summary>
            /// Version of Code System supported
            /// </summary>
            [FhirElement("version", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<VersionComponent> Version
            {
                get { if(_Version==null) _Version = new List<VersionComponent>(); return _Version; }
                set { _Version = value; OnPropertyChanged("Version"); }
            }
            
            private List<VersionComponent> _Version;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CodeSystemComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Uri != null) dest.Uri = (Hl7.Fhir.Model.canonical)Uri.DeepCopy();
                    if(Version != null) dest.Version = new List<VersionComponent>(Version.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Uri, otherT.Uri)) return false;
                if( !DeepComparable.Matches(Version, otherT.Version)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CodeSystemComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Uri, otherT.Uri)) return false;
                if( !DeepComparable.IsExactly(Version, otherT.Version)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Uri != null) yield return Uri;
                    foreach (var elem in Version) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Uri != null) yield return new ElementValue("uri", false, Uri);
                    foreach (var elem in Version) { if (elem != null) yield return new ElementValue("version", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "VersionComponent")]
        [DataContract]
        public partial class VersionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "VersionComponent"; } }
            
            /// <summary>
            /// Version identifier for this version
            /// </summary>
            [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _CodeElement;
            
            /// <summary>
            /// Version identifier for this version
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// If this is the default version for this code system
            /// </summary>
            [FhirElement("isDefault", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean IsDefaultElement
            {
                get { return _IsDefaultElement; }
                set { _IsDefaultElement = value; OnPropertyChanged("IsDefaultElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _IsDefaultElement;
            
            /// <summary>
            /// If this is the default version for this code system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? IsDefault
            {
                get { return IsDefaultElement != null ? IsDefaultElement.Value : null; }
                set
                {
                    if (value == null)
                        IsDefaultElement = null;
                    else
                        IsDefaultElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("IsDefault");
                }
            }
            
            /// <summary>
            /// If compositional grammar is supported
            /// </summary>
            [FhirElement("compositional", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean CompositionalElement
            {
                get { return _CompositionalElement; }
                set { _CompositionalElement = value; OnPropertyChanged("CompositionalElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _CompositionalElement;
            
            /// <summary>
            /// If compositional grammar is supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Compositional
            {
                get { return CompositionalElement != null ? CompositionalElement.Value : null; }
                set
                {
                    if (value == null)
                        CompositionalElement = null;
                    else
                        CompositionalElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Compositional");
                }
            }
            
            /// <summary>
            /// Language Displays supported
            /// </summary>
            [FhirElement("language", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Code> LanguageElement
            {
                get { if(_LanguageElement==null) _LanguageElement = new List<Hl7.Fhir.Model.R4.Code>(); return _LanguageElement; }
                set { _LanguageElement = value; OnPropertyChanged("LanguageElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Code> _LanguageElement;
            
            /// <summary>
            /// Language Displays supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Language
            {
                get { return LanguageElement != null ? LanguageElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        LanguageElement = null;
                    else
                        LanguageElement = new List<Hl7.Fhir.Model.R4.Code>(value.Select(elem=>new Hl7.Fhir.Model.R4.Code(elem)));
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
                get { if(_Filter==null) _Filter = new List<FilterComponent>(); return _Filter; }
                set { _Filter = value; OnPropertyChanged("Filter"); }
            }
            
            private List<FilterComponent> _Filter;
            
            /// <summary>
            /// Properties supported for $lookup
            /// </summary>
            [FhirElement("property", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Code> PropertyElement
            {
                get { if(_PropertyElement==null) _PropertyElement = new List<Hl7.Fhir.Model.R4.Code>(); return _PropertyElement; }
                set { _PropertyElement = value; OnPropertyChanged("PropertyElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Code> _PropertyElement;
            
            /// <summary>
            /// Properties supported for $lookup
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Property
            {
                get { return PropertyElement != null ? PropertyElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PropertyElement = null;
                    else
                        PropertyElement = new List<Hl7.Fhir.Model.R4.Code>(value.Select(elem=>new Hl7.Fhir.Model.R4.Code(elem)));
                    OnPropertyChanged("Property");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VersionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CodeElement != null) dest.CodeElement = (Hl7.Fhir.Model.FhirString)CodeElement.DeepCopy();
                    if(IsDefaultElement != null) dest.IsDefaultElement = (Hl7.Fhir.Model.FhirBoolean)IsDefaultElement.DeepCopy();
                    if(CompositionalElement != null) dest.CompositionalElement = (Hl7.Fhir.Model.FhirBoolean)CompositionalElement.DeepCopy();
                    if(LanguageElement != null) dest.LanguageElement = new List<Hl7.Fhir.Model.R4.Code>(LanguageElement.DeepCopy());
                    if(Filter != null) dest.Filter = new List<FilterComponent>(Filter.DeepCopy());
                    if(PropertyElement != null) dest.PropertyElement = new List<Hl7.Fhir.Model.R4.Code>(PropertyElement.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.Matches(IsDefaultElement, otherT.IsDefaultElement)) return false;
                if( !DeepComparable.Matches(CompositionalElement, otherT.CompositionalElement)) return false;
                if( !DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if( !DeepComparable.Matches(Filter, otherT.Filter)) return false;
                if( !DeepComparable.Matches(PropertyElement, otherT.PropertyElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VersionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.IsExactly(IsDefaultElement, otherT.IsDefaultElement)) return false;
                if( !DeepComparable.IsExactly(CompositionalElement, otherT.CompositionalElement)) return false;
                if( !DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if( !DeepComparable.IsExactly(Filter, otherT.Filter)) return false;
                if( !DeepComparable.IsExactly(PropertyElement, otherT.PropertyElement)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "FilterComponent")]
        [DataContract]
        public partial class FilterComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "FilterComponent"; } }
            
            /// <summary>
            /// Code of the property supported
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _CodeElement;
            
            /// <summary>
            /// Code of the property supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// Operations supported for the property
            /// </summary>
            [FhirElement("op", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Code> OpElement
            {
                get { if(_OpElement==null) _OpElement = new List<Hl7.Fhir.Model.R4.Code>(); return _OpElement; }
                set { _OpElement = value; OnPropertyChanged("OpElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Code> _OpElement;
            
            /// <summary>
            /// Operations supported for the property
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Op
            {
                get { return OpElement != null ? OpElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        OpElement = null;
                    else
                        OpElement = new List<Hl7.Fhir.Model.R4.Code>(value.Select(elem=>new Hl7.Fhir.Model.R4.Code(elem)));
                    OnPropertyChanged("Op");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FilterComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CodeElement != null) dest.CodeElement = (Hl7.Fhir.Model.R4.Code)CodeElement.DeepCopy();
                    if(OpElement != null) dest.OpElement = new List<Hl7.Fhir.Model.R4.Code>(OpElement.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.Matches(OpElement, otherT.OpElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FilterComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.IsExactly(OpElement, otherT.OpElement)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ExpansionComponent")]
        [DataContract]
        public partial class ExpansionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ExpansionComponent"; } }
            
            /// <summary>
            /// Whether the server can return nested value sets
            /// </summary>
            [FhirElement("hierarchical", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean HierarchicalElement
            {
                get { return _HierarchicalElement; }
                set { _HierarchicalElement = value; OnPropertyChanged("HierarchicalElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _HierarchicalElement;
            
            /// <summary>
            /// Whether the server can return nested value sets
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Hierarchical
            {
                get { return HierarchicalElement != null ? HierarchicalElement.Value : null; }
                set
                {
                    if (value == null)
                        HierarchicalElement = null;
                    else
                        HierarchicalElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Hierarchical");
                }
            }
            
            /// <summary>
            /// Whether the server supports paging on expansion
            /// </summary>
            [FhirElement("paging", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean PagingElement
            {
                get { return _PagingElement; }
                set { _PagingElement = value; OnPropertyChanged("PagingElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _PagingElement;
            
            /// <summary>
            /// Whether the server supports paging on expansion
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Paging
            {
                get { return PagingElement != null ? PagingElement.Value : null; }
                set
                {
                    if (value == null)
                        PagingElement = null;
                    else
                        PagingElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Paging");
                }
            }
            
            /// <summary>
            /// Allow request for incomplete expansions?
            /// </summary>
            [FhirElement("incomplete", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean IncompleteElement
            {
                get { return _IncompleteElement; }
                set { _IncompleteElement = value; OnPropertyChanged("IncompleteElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _IncompleteElement;
            
            /// <summary>
            /// Allow request for incomplete expansions?
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Incomplete
            {
                get { return IncompleteElement != null ? IncompleteElement.Value : null; }
                set
                {
                    if (value == null)
                        IncompleteElement = null;
                    else
                        IncompleteElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Incomplete");
                }
            }
            
            /// <summary>
            /// Supported fields on ExpansionProfile
            /// </summary>
            [FhirElement("definition", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.canonical Definition
            {
                get { return _Definition; }
                set { _Definition = value; OnPropertyChanged("Definition"); }
            }
            
            private Hl7.Fhir.Model.canonical _Definition;
            
            /// <summary>
            /// Supported expansion profiles
            /// </summary>
            [FhirElement("profile", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.canonical> Profile
            {
                get { if(_Profile==null) _Profile = new List<Hl7.Fhir.Model.canonical>(); return _Profile; }
                set { _Profile = value; OnPropertyChanged("Profile"); }
            }
            
            private List<Hl7.Fhir.Model.canonical> _Profile;
            
            /// <summary>
            /// Documentation about text searching works
            /// </summary>
            [FhirElement("textFilter", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.Markdown TextFilterElement
            {
                get { return _TextFilterElement; }
                set { _TextFilterElement = value; OnPropertyChanged("TextFilterElement"); }
            }
            
            private Hl7.Fhir.Model.Markdown _TextFilterElement;
            
            /// <summary>
            /// Documentation about text searching works
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string TextFilter
            {
                get { return TextFilterElement != null ? TextFilterElement.Value : null; }
                set
                {
                    if (value == null)
                        TextFilterElement = null;
                    else
                        TextFilterElement = new Hl7.Fhir.Model.Markdown(value);
                    OnPropertyChanged("TextFilter");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ExpansionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(HierarchicalElement != null) dest.HierarchicalElement = (Hl7.Fhir.Model.FhirBoolean)HierarchicalElement.DeepCopy();
                    if(PagingElement != null) dest.PagingElement = (Hl7.Fhir.Model.FhirBoolean)PagingElement.DeepCopy();
                    if(IncompleteElement != null) dest.IncompleteElement = (Hl7.Fhir.Model.FhirBoolean)IncompleteElement.DeepCopy();
                    if(Definition != null) dest.Definition = (Hl7.Fhir.Model.canonical)Definition.DeepCopy();
                    if(Profile != null) dest.Profile = new List<Hl7.Fhir.Model.canonical>(Profile.DeepCopy());
                    if(TextFilterElement != null) dest.TextFilterElement = (Hl7.Fhir.Model.Markdown)TextFilterElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(HierarchicalElement, otherT.HierarchicalElement)) return false;
                if( !DeepComparable.Matches(PagingElement, otherT.PagingElement)) return false;
                if( !DeepComparable.Matches(IncompleteElement, otherT.IncompleteElement)) return false;
                if( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
                if( !DeepComparable.Matches(Profile, otherT.Profile)) return false;
                if( !DeepComparable.Matches(TextFilterElement, otherT.TextFilterElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExpansionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(HierarchicalElement, otherT.HierarchicalElement)) return false;
                if( !DeepComparable.IsExactly(PagingElement, otherT.PagingElement)) return false;
                if( !DeepComparable.IsExactly(IncompleteElement, otherT.IncompleteElement)) return false;
                if( !DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
                if( !DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
                if( !DeepComparable.IsExactly(TextFilterElement, otherT.TextFilterElement)) return false;
            
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
                    if (Definition != null) yield return Definition;
                    foreach (var elem in Profile) { if (elem != null) yield return elem; }
                    if (TextFilterElement != null) yield return TextFilterElement;
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
                    if (Definition != null) yield return new ElementValue("definition", false, Definition);
                    foreach (var elem in Profile) { if (elem != null) yield return new ElementValue("profile", true, elem); }
                    if (TextFilterElement != null) yield return new ElementValue("textFilter", false, TextFilterElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ValidateCodeComponent")]
        [DataContract]
        public partial class ValidateCodeComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ValidateCodeComponent"; } }
            
            /// <summary>
            /// Whether translations are validated
            /// </summary>
            [FhirElement("translations", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean TranslationsElement
            {
                get { return _TranslationsElement; }
                set { _TranslationsElement = value; OnPropertyChanged("TranslationsElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _TranslationsElement;
            
            /// <summary>
            /// Whether translations are validated
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Translations
            {
                get { return TranslationsElement != null ? TranslationsElement.Value : null; }
                set
                {
                    if (value == null)
                        TranslationsElement = null;
                    else
                        TranslationsElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Translations");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ValidateCodeComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TranslationsElement != null) dest.TranslationsElement = (Hl7.Fhir.Model.FhirBoolean)TranslationsElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TranslationsElement, otherT.TranslationsElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ValidateCodeComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TranslationsElement, otherT.TranslationsElement)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "TranslationComponent")]
        [DataContract]
        public partial class TranslationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TranslationComponent"; } }
            
            /// <summary>
            /// Whether the client must identify the map
            /// </summary>
            [FhirElement("needsMap", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean NeedsMapElement
            {
                get { return _NeedsMapElement; }
                set { _NeedsMapElement = value; OnPropertyChanged("NeedsMapElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _NeedsMapElement;
            
            /// <summary>
            /// Whether the client must identify the map
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? NeedsMap
            {
                get { return NeedsMapElement != null ? NeedsMapElement.Value : null; }
                set
                {
                    if (value == null)
                        NeedsMapElement = null;
                    else
                        NeedsMapElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("NeedsMap");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TranslationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NeedsMapElement != null) dest.NeedsMapElement = (Hl7.Fhir.Model.FhirBoolean)NeedsMapElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NeedsMapElement, otherT.NeedsMapElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TranslationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NeedsMapElement, otherT.NeedsMapElement)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ClosureComponent")]
        [DataContract]
        public partial class ClosureComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ClosureComponent"; } }
            
            /// <summary>
            /// If cross-system closure is supported
            /// </summary>
            [FhirElement("translation", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean TranslationElement
            {
                get { return _TranslationElement; }
                set { _TranslationElement = value; OnPropertyChanged("TranslationElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _TranslationElement;
            
            /// <summary>
            /// If cross-system closure is supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Translation
            {
                get { return TranslationElement != null ? TranslationElement.Value : null; }
                set
                {
                    if (value == null)
                        TranslationElement = null;
                    else
                        TranslationElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Translation");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClosureComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TranslationElement != null) dest.TranslationElement = (Hl7.Fhir.Model.FhirBoolean)TranslationElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TranslationElement, otherT.TranslationElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClosureComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TranslationElement, otherT.TranslationElement)) return false;
            
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
        [FhirElement("url", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri UrlElement
        {
            get { return _UrlElement; }
            set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _UrlElement;
        
        /// <summary>
        /// Canonical identifier for this terminology capabilities, represented as a URI (globally unique)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                    UrlElement = null;
                else
                    UrlElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("Url");
            }
        }
        
        /// <summary>
        /// Business version of the terminology capabilities
        /// </summary>
        [FhirElement("version", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// Business version of the terminology capabilities
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Version");
            }
        }
        
        /// <summary>
        /// Name for this terminology capabilities (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Name for this terminology capabilities (computer friendly)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                    NameElement = null;
                else
                    NameElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Name");
            }
        }
        
        /// <summary>
        /// Name for this terminology capabilities (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString TitleElement
        {
            get { return _TitleElement; }
            set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _TitleElement;
        
        /// <summary>
        /// Name for this terminology capabilities (human friendly)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                    TitleElement = null;
                else
                    TitleElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Title");
            }
        }
        
        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _StatusElement;
        
        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ExperimentalElement
        {
            get { return _ExperimentalElement; }
            set { _ExperimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ExperimentalElement;
        
        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (value == null)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }
        
        /// <summary>
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date last changed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString PublisherElement
        {
            get { return _PublisherElement; }
            set { _PublisherElement = value; OnPropertyChanged("PublisherElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _PublisherElement;
        
        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                    PublisherElement = null;
                else
                    PublisherElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }
        
        /// <summary>
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ContactDetail> Contact
        {
            get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.R4.ContactDetail>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ContactDetail> _Contact;
        
        /// <summary>
        /// Natural language description of the terminology capabilities
        /// </summary>
        [FhirElement("description", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _DescriptionElement;
        
        /// <summary>
        /// Natural language description of the terminology capabilities
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new Hl7.Fhir.Model.Markdown(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.UsageContext> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.R4.UsageContext>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<Hl7.Fhir.Model.R4.UsageContext> _UseContext;
        
        /// <summary>
        /// Intended jurisdiction for terminology capabilities (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> Jurisdiction
        {
            get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Jurisdiction; }
            set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _Jurisdiction;
        
        /// <summary>
        /// Why this terminology capabilities is defined
        /// </summary>
        [FhirElement("purpose", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown PurposeElement
        {
            get { return _PurposeElement; }
            set { _PurposeElement = value; OnPropertyChanged("PurposeElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _PurposeElement;
        
        /// <summary>
        /// Why this terminology capabilities is defined
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Purpose
        {
            get { return PurposeElement != null ? PurposeElement.Value : null; }
            set
            {
                if (value == null)
                    PurposeElement = null;
                else
                    PurposeElement = new Hl7.Fhir.Model.Markdown(value);
                OnPropertyChanged("Purpose");
            }
        }
        
        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown CopyrightElement
        {
            get { return _CopyrightElement; }
            set { _CopyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _CopyrightElement;
        
        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if (value == null)
                    CopyrightElement = null;
                else
                    CopyrightElement = new Hl7.Fhir.Model.Markdown(value);
                OnPropertyChanged("Copyright");
            }
        }
        
        /// <summary>
        /// Whether lockedDate is supported
        /// </summary>
        [FhirElement("lockedDate", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean LockedDateElement
        {
            get { return _LockedDateElement; }
            set { _LockedDateElement = value; OnPropertyChanged("LockedDateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _LockedDateElement;
        
        /// <summary>
        /// Whether lockedDate is supported
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? LockedDate
        {
            get { return LockedDateElement != null ? LockedDateElement.Value : null; }
            set
            {
                if (value == null)
                    LockedDateElement = null;
                else
                    LockedDateElement = new Hl7.Fhir.Model.FhirBoolean(value);
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
            get { if(_CodeSystem==null) _CodeSystem = new List<CodeSystemComponent>(); return _CodeSystem; }
            set { _CodeSystem = value; OnPropertyChanged("CodeSystem"); }
        }
        
        private List<CodeSystemComponent> _CodeSystem;
        
        /// <summary>
        /// Information about the $expansion operation
        /// </summary>
        [FhirElement("expansion", Order=250)]
        [DataMember]
        public ExpansionComponent Expansion
        {
            get { return _Expansion; }
            set { _Expansion = value; OnPropertyChanged("Expansion"); }
        }
        
        private ExpansionComponent _Expansion;
        
        /// <summary>
        /// explicit | all
        /// </summary>
        [FhirElement("codeSearch", Order=260)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code CodeSearchElement
        {
            get { return _CodeSearchElement; }
            set { _CodeSearchElement = value; OnPropertyChanged("CodeSearchElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _CodeSearchElement;
        
        /// <summary>
        /// explicit | all
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string CodeSearch
        {
            get { return CodeSearchElement != null ? CodeSearchElement.Value : null; }
            set
            {
                if (value == null)
                    CodeSearchElement = null;
                else
                    CodeSearchElement = new Hl7.Fhir.Model.R4.Code(value);
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
            get { return _ValidateCode; }
            set { _ValidateCode = value; OnPropertyChanged("ValidateCode"); }
        }
        
        private ValidateCodeComponent _ValidateCode;
        
        /// <summary>
        /// Information about the $translation operation
        /// </summary>
        [FhirElement("translation", Order=280)]
        [DataMember]
        public TranslationComponent Translation
        {
            get { return _Translation; }
            set { _Translation = value; OnPropertyChanged("Translation"); }
        }
        
        private TranslationComponent _Translation;
        
        /// <summary>
        /// Information about the $closure operation
        /// </summary>
        [FhirElement("closure", Order=290)]
        [DataMember]
        public ClosureComponent Closure
        {
            get { return _Closure; }
            set { _Closure = value; OnPropertyChanged("Closure"); }
        }
        
        private ClosureComponent _Closure;
    
    
        public static ElementDefinitionConstraint TerminologyCapabilities_TCP_1 = new ElementDefinitionConstraint
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
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.R4.ContactDetail>(Contact.DeepCopy());
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.R4.UsageContext>(UseContext.DeepCopy());
                if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Jurisdiction.DeepCopy());
                if(PurposeElement != null) dest.PurposeElement = (Hl7.Fhir.Model.Markdown)PurposeElement.DeepCopy();
                if(CopyrightElement != null) dest.CopyrightElement = (Hl7.Fhir.Model.Markdown)CopyrightElement.DeepCopy();
                if(LockedDateElement != null) dest.LockedDateElement = (Hl7.Fhir.Model.FhirBoolean)LockedDateElement.DeepCopy();
                if(CodeSystem != null) dest.CodeSystem = new List<CodeSystemComponent>(CodeSystem.DeepCopy());
                if(Expansion != null) dest.Expansion = (ExpansionComponent)Expansion.DeepCopy();
                if(CodeSearchElement != null) dest.CodeSearchElement = (Hl7.Fhir.Model.R4.Code)CodeSearchElement.DeepCopy();
                if(ValidateCode != null) dest.ValidateCode = (ValidateCodeComponent)ValidateCode.DeepCopy();
                if(Translation != null) dest.Translation = (TranslationComponent)Translation.DeepCopy();
                if(Closure != null) dest.Closure = (ClosureComponent)Closure.DeepCopy();
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
            if( !DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if( !DeepComparable.Matches(LockedDateElement, otherT.LockedDateElement)) return false;
            if( !DeepComparable.Matches(CodeSystem, otherT.CodeSystem)) return false;
            if( !DeepComparable.Matches(Expansion, otherT.Expansion)) return false;
            if( !DeepComparable.Matches(CodeSearchElement, otherT.CodeSearchElement)) return false;
            if( !DeepComparable.Matches(ValidateCode, otherT.ValidateCode)) return false;
            if( !DeepComparable.Matches(Translation, otherT.Translation)) return false;
            if( !DeepComparable.Matches(Closure, otherT.Closure)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as TerminologyCapabilities;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if( !DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
            if( !DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if( !DeepComparable.IsExactly(LockedDateElement, otherT.LockedDateElement)) return false;
            if( !DeepComparable.IsExactly(CodeSystem, otherT.CodeSystem)) return false;
            if( !DeepComparable.IsExactly(Expansion, otherT.Expansion)) return false;
            if( !DeepComparable.IsExactly(CodeSearchElement, otherT.CodeSearchElement)) return false;
            if( !DeepComparable.IsExactly(ValidateCode, otherT.ValidateCode)) return false;
            if( !DeepComparable.IsExactly(Translation, otherT.Translation)) return false;
            if( !DeepComparable.IsExactly(Closure, otherT.Closure)) return false;
        
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
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (PurposeElement != null) yield return PurposeElement;
                if (CopyrightElement != null) yield return CopyrightElement;
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
                if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", true, elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", true, elem); }
                if (PurposeElement != null) yield return new ElementValue("purpose", false, PurposeElement);
                if (CopyrightElement != null) yield return new ElementValue("copyright", false, CopyrightElement);
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
