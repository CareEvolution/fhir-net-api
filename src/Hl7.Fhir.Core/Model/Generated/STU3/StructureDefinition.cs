﻿using System;
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
// Generated for FHIR v3.0.1
//
namespace Hl7.Fhir.Model.STU3
{
    /// <summary>
    /// Structural Definition
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.STU3, "StructureDefinition", IsResource=true)]
    [DataContract]
    public partial class StructureDefinition : Hl7.Fhir.Model.DomainResource, Hl7.Fhir.Model.IStructureDefinition, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.StructureDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "StructureDefinition"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "MappingComponent")]
        [DataContract]
        public partial class MappingComponent : Hl7.Fhir.Model.BackboneElement, Hl7.Fhir.Model.IStructureDefinitionMappingComponent, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "MappingComponent"; } }
            
            /// <summary>
            /// Internal id when this mapping is used
            /// </summary>
            [FhirElement("identity", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Id IdentityElement
            {
                get { return _IdentityElement; }
                set { _IdentityElement = value; OnPropertyChanged("IdentityElement"); }
            }
            
            private Hl7.Fhir.Model.Id _IdentityElement;
            
            /// <summary>
            /// Internal id when this mapping is used
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Identity
            {
                get { return IdentityElement != null ? IdentityElement.Value : null; }
                set
                {
                    if (value == null)
                        IdentityElement = null;
                    else
                        IdentityElement = new Hl7.Fhir.Model.Id(value);
                    OnPropertyChanged("Identity");
                }
            }
            
            /// <summary>
            /// Identifies what this mapping refers to
            /// </summary>
            [FhirElement("uri", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri UriElement
            {
                get { return _UriElement; }
                set { _UriElement = value; OnPropertyChanged("UriElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _UriElement;
            
            /// <summary>
            /// Identifies what this mapping refers to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Uri
            {
                get { return UriElement != null ? UriElement.Value : null; }
                set
                {
                    if (value == null)
                        UriElement = null;
                    else
                        UriElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Uri");
                }
            }
            
            /// <summary>
            /// Names what this mapping refers to
            /// </summary>
            [FhirElement("name", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Names what this mapping refers to
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
            /// Versions, Issues, Scope limitations etc.
            /// </summary>
            [FhirElement("comment", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CommentElement
            {
                get { return _CommentElement; }
                set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _CommentElement;
            
            /// <summary>
            /// Versions, Issues, Scope limitations etc.
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Comment
            {
                get { return CommentElement != null ? CommentElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentElement = null;
                    else
                        CommentElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Comment");
                }
            }
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("MappingComponent");
                base.Serialize(sink);
                sink.Element("identity", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); IdentityElement?.Serialize(sink);
                sink.Element("uri", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); UriElement?.Serialize(sink);
                sink.Element("name", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); NameElement?.Serialize(sink);
                sink.Element("comment", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); CommentElement?.Serialize(sink);
                sink.End();
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MappingComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(IdentityElement != null) dest.IdentityElement = (Hl7.Fhir.Model.Id)IdentityElement.DeepCopy();
                    if(UriElement != null) dest.UriElement = (Hl7.Fhir.Model.FhirUri)UriElement.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MappingComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MappingComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(IdentityElement, otherT.IdentityElement)) return false;
                if( !DeepComparable.Matches(UriElement, otherT.UriElement)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MappingComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(IdentityElement, otherT.IdentityElement)) return false;
                if( !DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (IdentityElement != null) yield return IdentityElement;
                    if (UriElement != null) yield return UriElement;
                    if (NameElement != null) yield return NameElement;
                    if (CommentElement != null) yield return CommentElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IdentityElement != null) yield return new ElementValue("identity", IdentityElement);
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "SnapshotComponent")]
        [DataContract]
        public partial class SnapshotComponent : Hl7.Fhir.Model.BackboneElement, Hl7.Fhir.Model.IStructureDefinitionSnapshotComponent, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "SnapshotComponent"; } }
            
            [NotMapped]
            IEnumerable<Hl7.Fhir.Model.IElementDefinition> Hl7.Fhir.Model.IStructureDefinitionSnapshotComponent.Element { get { return Element; } }
            
            /// <summary>
            /// Definition of elements in the resource (if no StructureDefinition)
            /// </summary>
            [FhirElement("element", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.STU3.ElementDefinition> Element
            {
                get { if(_Element==null) _Element = new List<Hl7.Fhir.Model.STU3.ElementDefinition>(); return _Element; }
                set { _Element = value; OnPropertyChanged("Element"); }
            }
            
            private List<Hl7.Fhir.Model.STU3.ElementDefinition> _Element;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("SnapshotComponent");
                base.Serialize(sink);
                sink.BeginList("element", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true);
                foreach(var item in Element)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.End();
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SnapshotComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Element != null) dest.Element = new List<Hl7.Fhir.Model.STU3.ElementDefinition>(Element.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SnapshotComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SnapshotComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Element, otherT.Element)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SnapshotComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Element, otherT.Element)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Element) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Element) { if (elem != null) yield return new ElementValue("element", elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "DifferentialComponent")]
        [DataContract]
        public partial class DifferentialComponent : Hl7.Fhir.Model.BackboneElement, Hl7.Fhir.Model.IStructureDefinitionDifferentialComponent, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "DifferentialComponent"; } }
            
            [NotMapped]
            IEnumerable<Hl7.Fhir.Model.IElementDefinition> Hl7.Fhir.Model.IStructureDefinitionDifferentialComponent.Element { get { return Element; } }
            
            /// <summary>
            /// Definition of elements in the resource (if no StructureDefinition)
            /// </summary>
            [FhirElement("element", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.STU3.ElementDefinition> Element
            {
                get { if(_Element==null) _Element = new List<Hl7.Fhir.Model.STU3.ElementDefinition>(); return _Element; }
                set { _Element = value; OnPropertyChanged("Element"); }
            }
            
            private List<Hl7.Fhir.Model.STU3.ElementDefinition> _Element;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("DifferentialComponent");
                base.Serialize(sink);
                sink.BeginList("element", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true);
                foreach(var item in Element)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.End();
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DifferentialComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Element != null) dest.Element = new List<Hl7.Fhir.Model.STU3.ElementDefinition>(Element.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DifferentialComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DifferentialComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Element, otherT.Element)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DifferentialComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Element, otherT.Element)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Element) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Element) { if (elem != null) yield return new ElementValue("element", elem); }
                }
            }
        
        
        }
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IStructureDefinitionMappingComponent> Hl7.Fhir.Model.IStructureDefinition.Mapping { get { return Mapping; } }
        
        [NotMapped]
        Hl7.Fhir.Model.IStructureDefinitionSnapshotComponent Hl7.Fhir.Model.IStructureDefinition.Snapshot { get { return Snapshot; } }
        
        [NotMapped]
        Hl7.Fhir.Model.IStructureDefinitionDifferentialComponent Hl7.Fhir.Model.IStructureDefinition.Differential { get { return Differential; } }
    
        
        /// <summary>
        /// Logical URI to reference this structure definition (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=Hl7.Fhir.Model.Version.All, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri UrlElement
        {
            get { return _UrlElement; }
            set { _UrlElement = value; OnPropertyChanged("UrlElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _UrlElement;
        
        /// <summary>
        /// Logical URI to reference this structure definition (globally unique)
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
        /// Additional identifier for the structure definition
        /// </summary>
        [FhirElement("identifier", InSummary=Hl7.Fhir.Model.Version.All, Order=100)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Business version of the structure definition
        /// </summary>
        [FhirElement("version", InSummary=Hl7.Fhir.Model.Version.All, Order=110)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString VersionElement
        {
            get { return _VersionElement; }
            set { _VersionElement = value; OnPropertyChanged("VersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _VersionElement;
        
        /// <summary>
        /// Business version of the structure definition
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
        /// Name for this structure definition (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=Hl7.Fhir.Model.Version.All, Order=120)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Name for this structure definition (computer friendly)
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
        /// Name for this structure definition (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=Hl7.Fhir.Model.Version.All, Order=130)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString TitleElement
        {
            get { return _TitleElement; }
            set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _TitleElement;
        
        /// <summary>
        /// Name for this structure definition (human friendly)
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
        [FhirElement("status", InSummary=Hl7.Fhir.Model.Version.All, Order=140)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.PublicationStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.PublicationStatus> _StatusElement;
        
        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<Hl7.Fhir.Model.PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=Hl7.Fhir.Model.Version.All, Order=150)]
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
        /// Date this was last changed
        /// </summary>
        [FhirElement("date", InSummary=Hl7.Fhir.Model.Version.All, Order=160)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date this was last changed
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
                    DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=Hl7.Fhir.Model.Version.All, Order=170)]
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
        [FhirElement("contact", InSummary=Hl7.Fhir.Model.Version.All, Order=180)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.ContactDetail> Contact
        {
            get { if(_Contact==null) _Contact = new List<Hl7.Fhir.Model.STU3.ContactDetail>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.ContactDetail> _Contact;
        
        /// <summary>
        /// Natural language description of the structure definition
        /// </summary>
        [FhirElement("description", Order=190)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _DescriptionElement;
        
        /// <summary>
        /// Natural language description of the structure definition
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
        /// Context the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=Hl7.Fhir.Model.Version.All, Order=200)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.UsageContext> UseContext
        {
            get { if(_UseContext==null) _UseContext = new List<Hl7.Fhir.Model.UsageContext>(); return _UseContext; }
            set { _UseContext = value; OnPropertyChanged("UseContext"); }
        }
        
        private List<Hl7.Fhir.Model.UsageContext> _UseContext;
        
        /// <summary>
        /// Intended jurisdiction for structure definition (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=Hl7.Fhir.Model.Version.All, Order=210)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Jurisdiction
        {
            get { if(_Jurisdiction==null) _Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Jurisdiction; }
            set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Jurisdiction;
        
        /// <summary>
        /// Why this structure definition is defined
        /// </summary>
        [FhirElement("purpose", Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown PurposeElement
        {
            get { return _PurposeElement; }
            set { _PurposeElement = value; OnPropertyChanged("PurposeElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _PurposeElement;
        
        /// <summary>
        /// Why this structure definition is defined
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
        [FhirElement("copyright", Order=230)]
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
        /// Assist with indexing and finding
        /// </summary>
        [FhirElement("keyword", InSummary=Hl7.Fhir.Model.Version.All, Order=240)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Coding> Keyword
        {
            get { if(_Keyword==null) _Keyword = new List<Hl7.Fhir.Model.Coding>(); return _Keyword; }
            set { _Keyword = value; OnPropertyChanged("Keyword"); }
        }
        
        private List<Hl7.Fhir.Model.Coding> _Keyword;
        
        /// <summary>
        /// FHIR Version this StructureDefinition targets
        /// </summary>
        [FhirElement("fhirVersion", InSummary=Hl7.Fhir.Model.Version.All, Order=250)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.Id FhirVersionElement
        {
            get { return _FhirVersionElement; }
            set { _FhirVersionElement = value; OnPropertyChanged("FhirVersionElement"); }
        }
        
        private Hl7.Fhir.Model.Id _FhirVersionElement;
        
        /// <summary>
        /// FHIR Version this StructureDefinition targets
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string FhirVersion
        {
            get { return FhirVersionElement != null ? FhirVersionElement.Value : null; }
            set
            {
                if (value == null)
                    FhirVersionElement = null;
                else
                    FhirVersionElement = new Hl7.Fhir.Model.Id(value);
                OnPropertyChanged("FhirVersion");
            }
        }
        
        /// <summary>
        /// External specification that the content is mapped to
        /// </summary>
        [FhirElement("mapping", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MappingComponent> Mapping
        {
            get { if(_Mapping==null) _Mapping = new List<MappingComponent>(); return _Mapping; }
            set { _Mapping = value; OnPropertyChanged("Mapping"); }
        }
        
        private List<MappingComponent> _Mapping;
        
        /// <summary>
        /// primitive-type | complex-type | resource | logical
        /// </summary>
        [FhirElement("kind", InSummary=Hl7.Fhir.Model.Version.All, Order=270)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.STU3.StructureDefinitionKind> KindElement
        {
            get { return _KindElement; }
            set { _KindElement = value; OnPropertyChanged("KindElement"); }
        }
        
        private Code<Hl7.Fhir.Model.STU3.StructureDefinitionKind> _KindElement;
        
        /// <summary>
        /// primitive-type | complex-type | resource | logical
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.STU3.StructureDefinitionKind? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (value == null)
                    KindElement = null;
                else
                    KindElement = new Code<Hl7.Fhir.Model.STU3.StructureDefinitionKind>(value);
                OnPropertyChanged("Kind");
            }
        }
        
        /// <summary>
        /// Whether the structure is abstract
        /// </summary>
        [FhirElement("abstract", InSummary=Hl7.Fhir.Model.Version.All, Order=280)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean AbstractElement
        {
            get { return _AbstractElement; }
            set { _AbstractElement = value; OnPropertyChanged("AbstractElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _AbstractElement;
        
        /// <summary>
        /// Whether the structure is abstract
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Abstract
        {
            get { return AbstractElement != null ? AbstractElement.Value : null; }
            set
            {
                if (value == null)
                    AbstractElement = null;
                else
                    AbstractElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Abstract");
            }
        }
        
        /// <summary>
        /// resource | datatype | extension
        /// </summary>
        [FhirElement("contextType", InSummary=Hl7.Fhir.Model.Version.All, Order=290)]
        [CLSCompliant(false)]
        [DataMember]
        public Code<Hl7.Fhir.Model.STU3.ExtensionContext> ContextTypeElement
        {
            get { return _ContextTypeElement; }
            set { _ContextTypeElement = value; OnPropertyChanged("ContextTypeElement"); }
        }
        
        private Code<Hl7.Fhir.Model.STU3.ExtensionContext> _ContextTypeElement;
        
        /// <summary>
        /// resource | datatype | extension
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.STU3.ExtensionContext? ContextType
        {
            get { return ContextTypeElement != null ? ContextTypeElement.Value : null; }
            set
            {
                if (value == null)
                    ContextTypeElement = null;
                else
                    ContextTypeElement = new Code<Hl7.Fhir.Model.STU3.ExtensionContext>(value);
                OnPropertyChanged("ContextType");
            }
        }
        
        /// <summary>
        /// Where the extension can be used in instances
        /// </summary>
        [FhirElement("context", InSummary=Hl7.Fhir.Model.Version.All, Order=300)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirString> ContextElement
        {
            get { if(_ContextElement==null) _ContextElement = new List<Hl7.Fhir.Model.FhirString>(); return _ContextElement; }
            set { _ContextElement = value; OnPropertyChanged("ContextElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirString> _ContextElement;
        
        /// <summary>
        /// Where the extension can be used in instances
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Context
        {
            get { return ContextElement != null ? ContextElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ContextElement = null;
                else
                    ContextElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                OnPropertyChanged("Context");
            }
        }
        
        /// <summary>
        /// FHIRPath invariants - when the extension can be used
        /// </summary>
        [FhirElement("contextInvariant", InSummary=Hl7.Fhir.Model.Version.All, Order=310)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirString> ContextInvariantElement
        {
            get { if(_ContextInvariantElement==null) _ContextInvariantElement = new List<Hl7.Fhir.Model.FhirString>(); return _ContextInvariantElement; }
            set { _ContextInvariantElement = value; OnPropertyChanged("ContextInvariantElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirString> _ContextInvariantElement;
        
        /// <summary>
        /// FHIRPath invariants - when the extension can be used
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> ContextInvariant
        {
            get { return ContextInvariantElement != null ? ContextInvariantElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ContextInvariantElement = null;
                else
                    ContextInvariantElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                OnPropertyChanged("ContextInvariant");
            }
        }
        
        /// <summary>
        /// Type defined or constrained by this structure
        /// </summary>
        [FhirElement("type", InSummary=Hl7.Fhir.Model.Version.All, Order=320)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Code TypeElement
        {
            get { return _TypeElement; }
            set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
        }
        
        private Hl7.Fhir.Model.Code _TypeElement;
        
        /// <summary>
        /// Type defined or constrained by this structure
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Hl7.Fhir.Model.Code(value);
                OnPropertyChanged("Type");
            }
        }
        
        /// <summary>
        /// Definition that this type is constrained/specialized from
        /// </summary>
        [FhirElement("baseDefinition", InSummary=Hl7.Fhir.Model.Version.All, Order=330)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirUri BaseDefinitionElement
        {
            get { return _BaseDefinitionElement; }
            set { _BaseDefinitionElement = value; OnPropertyChanged("BaseDefinitionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirUri _BaseDefinitionElement;
        
        /// <summary>
        /// Definition that this type is constrained/specialized from
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string BaseDefinition
        {
            get { return BaseDefinitionElement != null ? BaseDefinitionElement.Value : null; }
            set
            {
                if (value == null)
                    BaseDefinitionElement = null;
                else
                    BaseDefinitionElement = new Hl7.Fhir.Model.FhirUri(value);
                OnPropertyChanged("BaseDefinition");
            }
        }
        
        /// <summary>
        /// specialization | constraint - How relates to base definition
        /// </summary>
        [FhirElement("derivation", InSummary=Hl7.Fhir.Model.Version.All, Order=340)]
        [CLSCompliant(false)]
        [DataMember]
        public Code<Hl7.Fhir.Model.TypeDerivationRule> DerivationElement
        {
            get { return _DerivationElement; }
            set { _DerivationElement = value; OnPropertyChanged("DerivationElement"); }
        }
        
        private Code<Hl7.Fhir.Model.TypeDerivationRule> _DerivationElement;
        
        /// <summary>
        /// specialization | constraint - How relates to base definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.TypeDerivationRule? Derivation
        {
            get { return DerivationElement != null ? DerivationElement.Value : null; }
            set
            {
                if (value == null)
                    DerivationElement = null;
                else
                    DerivationElement = new Code<Hl7.Fhir.Model.TypeDerivationRule>(value);
                OnPropertyChanged("Derivation");
            }
        }
        
        /// <summary>
        /// Snapshot view of the structure
        /// </summary>
        [FhirElement("snapshot", Order=350)]
        [DataMember]
        public SnapshotComponent Snapshot
        {
            get { return _Snapshot; }
            set { _Snapshot = value; OnPropertyChanged("Snapshot"); }
        }
        
        private SnapshotComponent _Snapshot;
        
        /// <summary>
        /// Differential view of the structure
        /// </summary>
        [FhirElement("differential", Order=360)]
        [DataMember]
        public DifferentialComponent Differential
        {
            get { return _Differential; }
            set { _Differential = value; OnPropertyChanged("Differential"); }
        }
        
        private DifferentialComponent _Differential;
    
    
        public static ElementDefinitionConstraint[] StructureDefinition_Constraints =
        {
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-9",
                severity: ConstraintSeverity.Warning,
                expression: "children().element.first().label.empty() and children().element.first().code.empty() and children().element.first().requirements.empty()",
                human: "In any snapshot or differential, no label, code or requirements on the an element without a \".\" in the path (e.g. the first element)",
                xpath: "not(exists(f:snapshot/f:element[not(contains(f:path/@value, '.')) and (f:label or f:code or f:requirements)])) and not(exists(f:differential/f:element[not(contains(f:path/@value, '.')) and (f:label or f:code or f:requirements)]))"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-19",
                severity: ConstraintSeverity.Warning,
                expression: "kind = 'logical' or (differential.element.type.code.all(hasValue() implies matches('^[a-zA-Z0-9]+$')) and snapshot.element.type.code.all(hasValue() implies matches('^[a-zA-Z0-9]+$')))",
                human: "Custom types can only be used in logical models",
                xpath: "f:kind/@value = 'logical' or count(f:differential/f:element/f:type/f:code[@value and not(matches(string(@value), '^[a-zA-Z0-9]+$'))]|f:snapshot/f:element/f:type/f:code[@value and not(matches(string(@value), '^[a-zA-Z0-9]+$'))]) =0"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-16",
                severity: ConstraintSeverity.Warning,
                expression: "snapshot.element.id.trace('ids').isDistinct()",
                human: "All element definitions must have unique ids (snapshot)",
                xpath: "count(*/f:element)=count(*/f:element/@id)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-18",
                severity: ConstraintSeverity.Warning,
                expression: "contextInvariant.exists() implies type = 'Extension'",
                human: "Context Invariants can only be used for extensions",
                xpath: "not(exists(f:contextInvariant)) or (f:type/@value = 'Extension')"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-17",
                severity: ConstraintSeverity.Warning,
                expression: "differential.element.id.trace('ids').isDistinct()",
                human: "All element definitions must have unique ids (diff)",
                xpath: "count(*/f:element)=count(*/f:element/@id)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-12",
                severity: ConstraintSeverity.Warning,
                expression: "snapshot.exists() implies (snapshot.element.base.exists() = baseDefinition.exists())",
                human: "element.base cannot appear if there is no base on the structure definition",
                xpath: "f:baseDefinition or not(exists(f:snapshot/f:element/f:base) or exists(f:differential/f:element/f:base))"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-11",
                severity: ConstraintSeverity.Warning,
                expression: "snapshot.empty() or snapshot.element.first().path = type",
                human: "If there's a type, its content must match the path name in the first element of a snapshot",
                xpath: "not(exists(f:snapshot)) or (f:type/@value = f:snapshot/f:element[1]/f:path/@value)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-14",
                severity: ConstraintSeverity.Warning,
                expression: "snapshot.element.all(id.exists()) and differential.element.all(id.exists())",
                human: "All element definitions must have an id",
                xpath: "count(*/f:element)=count(*/f:element/@id)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-1",
                severity: ConstraintSeverity.Warning,
                expression: "derivation = 'constraint' or snapshot.element.select(path).isDistinct()",
                human: "Element paths must be unique unless the structure is a constraint",
                xpath: "(f:derivation/@value = 'constraint') or (count(f:snapshot/f:element) = count(distinct-values(f:snapshot/f:element/f:path/@value)))"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-7",
                severity: ConstraintSeverity.Warning,
                expression: "(derivation = 'constraint') or (kind = 'logical') or (url = 'http://hl7.org/fhir/StructureDefinition/'+id)",
                human: "If the structure describes a base Resource or Type, the URL has to start with \"http://hl7.org/fhir/StructureDefinition/\" and the tail must match the id",
                xpath: "(f:derivation/@value = 'constraint') or (f:kind/@value = 'logical') or (f:url/@value=concat('http://hl7.org/fhir/StructureDefinition/', f:id/@value))"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-6",
                severity: ConstraintSeverity.Warning,
                expression: "snapshot.exists() or differential.exists()",
                human: "A structure must have either a differential, or a snapshot (or both)",
                xpath: "exists(f:snapshot) or exists(f:differential)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-5",
                severity: ConstraintSeverity.Warning,
                expression: "type != 'Extension' or derivation = 'specialization' or (context.exists() and contextType.exists())",
                human: "If the structure defines an extension then the structure must have context information",
                xpath: "not(f:type/@value = 'extension') or (f:derivation/@value = 'specialization') or (exists(f:context) and exists(f:contextType))"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-4",
                severity: ConstraintSeverity.Warning,
                expression: "abstract = true or baseDefinition.exists()",
                human: "If the structure is not abstract, then there SHALL be a baseDefinition",
                xpath: "(f:abstract/@value=true()) or exists(f:baseDefinition)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-2",
                severity: ConstraintSeverity.Warning,
                expression: "mapping.all(name.exists() or uri.exists())",
                human: "Must have at least a name or a uri (or both)",
                xpath: "exists(f:uri) or exists(f:name)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-15",
                severity: ConstraintSeverity.Warning,
                expression: "snapshot.all(element.first().type.empty())",
                human: "The first element in a snapshot has no type",
                xpath: "not(f:element[1]/f:type)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-8",
                severity: ConstraintSeverity.Warning,
                expression: "snapshot.all(element.first().path = %resource.type and element.tail().all(path.startsWith(%resource.type&'.')))",
                human: "In any snapshot, all the elements must be in the specified type",
                xpath: "f:element[1]/f:path/@value=parent::f:StructureDefinition/f:type/@value and count(f:element[position()!=1])=count(f:element[position()!=1][starts-with(f:path/@value, concat(ancestor::f:StructureDefinition/f:type/@value, '.'))])"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-3",
                severity: ConstraintSeverity.Warning,
                expression: "snapshot.all(element.all(definition and min and max))",
                human: "Each element definition in a snapshot must have a formal definition and cardinalities",
                xpath: "count(f:element) = count(f:element[exists(f:definition) and exists(f:min) and exists(f:max)])"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-15a",
                severity: ConstraintSeverity.Warning,
                expression: "differential.all(element.first().path.contains('.').not() implies element.first().type.empty())",
                human: "If the first element in a differential has no \".\" in the path, it has no type",
                xpath: "not(f:element[1][not(contains(f:path/@value, '.'))]/f:type)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-20",
                severity: ConstraintSeverity.Warning,
                expression: "differential.all(element.first().slicing.empty())",
                human: "No slicing on the root element",
                xpath: "not(f:element[1]/f:slicing)"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "sdf-8a",
                severity: ConstraintSeverity.Warning,
                expression: "differential.all(element.first().path.startsWith(%resource.type) and element.tail().all(path.startsWith(%resource.type&'.')))",
                human: "In any differential, all the elements must be in the specified type",
                xpath: "count(f:element)=count(f:element[f:path/@value=ancestor::f:StructureDefinition/f:type/@value or starts-with(f:path/@value, concat(ancestor::f:StructureDefinition/f:type/@value, '.'))])"
            ),
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
            InvariantConstraints.AddRange(StructureDefinition_Constraints);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as StructureDefinition;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(UrlElement != null) dest.UrlElement = (Hl7.Fhir.Model.FhirUri)UrlElement.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(VersionElement != null) dest.VersionElement = (Hl7.Fhir.Model.FhirString)VersionElement.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.PublicationStatus>)StatusElement.DeepCopy();
                if(ExperimentalElement != null) dest.ExperimentalElement = (Hl7.Fhir.Model.FhirBoolean)ExperimentalElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(PublisherElement != null) dest.PublisherElement = (Hl7.Fhir.Model.FhirString)PublisherElement.DeepCopy();
                if(Contact != null) dest.Contact = new List<Hl7.Fhir.Model.STU3.ContactDetail>(Contact.DeepCopy());
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.Markdown)DescriptionElement.DeepCopy();
                if(UseContext != null) dest.UseContext = new List<Hl7.Fhir.Model.UsageContext>(UseContext.DeepCopy());
                if(Jurisdiction != null) dest.Jurisdiction = new List<Hl7.Fhir.Model.CodeableConcept>(Jurisdiction.DeepCopy());
                if(PurposeElement != null) dest.PurposeElement = (Hl7.Fhir.Model.Markdown)PurposeElement.DeepCopy();
                if(CopyrightElement != null) dest.CopyrightElement = (Hl7.Fhir.Model.Markdown)CopyrightElement.DeepCopy();
                if(Keyword != null) dest.Keyword = new List<Hl7.Fhir.Model.Coding>(Keyword.DeepCopy());
                if(FhirVersionElement != null) dest.FhirVersionElement = (Hl7.Fhir.Model.Id)FhirVersionElement.DeepCopy();
                if(Mapping != null) dest.Mapping = new List<MappingComponent>(Mapping.DeepCopy());
                if(KindElement != null) dest.KindElement = (Code<Hl7.Fhir.Model.STU3.StructureDefinitionKind>)KindElement.DeepCopy();
                if(AbstractElement != null) dest.AbstractElement = (Hl7.Fhir.Model.FhirBoolean)AbstractElement.DeepCopy();
                if(ContextTypeElement != null) dest.ContextTypeElement = (Code<Hl7.Fhir.Model.STU3.ExtensionContext>)ContextTypeElement.DeepCopy();
                if(ContextElement != null) dest.ContextElement = new List<Hl7.Fhir.Model.FhirString>(ContextElement.DeepCopy());
                if(ContextInvariantElement != null) dest.ContextInvariantElement = new List<Hl7.Fhir.Model.FhirString>(ContextInvariantElement.DeepCopy());
                if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.Code)TypeElement.DeepCopy();
                if(BaseDefinitionElement != null) dest.BaseDefinitionElement = (Hl7.Fhir.Model.FhirUri)BaseDefinitionElement.DeepCopy();
                if(DerivationElement != null) dest.DerivationElement = (Code<Hl7.Fhir.Model.TypeDerivationRule>)DerivationElement.DeepCopy();
                if(Snapshot != null) dest.Snapshot = (SnapshotComponent)Snapshot.DeepCopy();
                if(Differential != null) dest.Differential = (DifferentialComponent)Differential.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new StructureDefinition());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as StructureDefinition;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
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
            if( !DeepComparable.Matches(Keyword, otherT.Keyword)) return false;
            if( !DeepComparable.Matches(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if( !DeepComparable.Matches(Mapping, otherT.Mapping)) return false;
            if( !DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if( !DeepComparable.Matches(AbstractElement, otherT.AbstractElement)) return false;
            if( !DeepComparable.Matches(ContextTypeElement, otherT.ContextTypeElement)) return false;
            if( !DeepComparable.Matches(ContextElement, otherT.ContextElement)) return false;
            if( !DeepComparable.Matches(ContextInvariantElement, otherT.ContextInvariantElement)) return false;
            if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.Matches(BaseDefinitionElement, otherT.BaseDefinitionElement)) return false;
            if( !DeepComparable.Matches(DerivationElement, otherT.DerivationElement)) return false;
            if( !DeepComparable.Matches(Snapshot, otherT.Snapshot)) return false;
            if( !DeepComparable.Matches(Differential, otherT.Differential)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as StructureDefinition;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
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
            if( !DeepComparable.IsExactly(Keyword, otherT.Keyword)) return false;
            if( !DeepComparable.IsExactly(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if( !DeepComparable.IsExactly(Mapping, otherT.Mapping)) return false;
            if( !DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if( !DeepComparable.IsExactly(AbstractElement, otherT.AbstractElement)) return false;
            if( !DeepComparable.IsExactly(ContextTypeElement, otherT.ContextTypeElement)) return false;
            if( !DeepComparable.IsExactly(ContextElement, otherT.ContextElement)) return false;
            if( !DeepComparable.IsExactly(ContextInvariantElement, otherT.ContextInvariantElement)) return false;
            if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.IsExactly(BaseDefinitionElement, otherT.BaseDefinitionElement)) return false;
            if( !DeepComparable.IsExactly(DerivationElement, otherT.DerivationElement)) return false;
            if( !DeepComparable.IsExactly(Snapshot, otherT.Snapshot)) return false;
            if( !DeepComparable.IsExactly(Differential, otherT.Differential)) return false;
        
            return true;
        }
    
        internal override void Serialize(Serialization.SerializerSink sink)
        {
            sink.BeginResource("StructureDefinition");
            base.Serialize(sink);
            sink.Element("url", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); UrlElement?.Serialize(sink);
            sink.BeginList("identifier", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Identifier)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("version", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); VersionElement?.Serialize(sink);
            sink.Element("name", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); NameElement?.Serialize(sink);
            sink.Element("title", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); TitleElement?.Serialize(sink);
            sink.Element("status", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); StatusElement?.Serialize(sink);
            sink.Element("experimental", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); ExperimentalElement?.Serialize(sink);
            sink.Element("date", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); DateElement?.Serialize(sink);
            sink.Element("publisher", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); PublisherElement?.Serialize(sink);
            sink.BeginList("contact", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Contact)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("description", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DescriptionElement?.Serialize(sink);
            sink.BeginList("useContext", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in UseContext)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("jurisdiction", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Jurisdiction)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("purpose", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); PurposeElement?.Serialize(sink);
            sink.Element("copyright", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); CopyrightElement?.Serialize(sink);
            sink.BeginList("keyword", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Keyword)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("fhirVersion", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); FhirVersionElement?.Serialize(sink);
            sink.BeginList("mapping", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Mapping)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("kind", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); KindElement?.Serialize(sink);
            sink.Element("abstract", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); AbstractElement?.Serialize(sink);
            sink.Element("contextType", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); ContextTypeElement?.Serialize(sink);
            sink.BeginList("context", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            sink.Serialize(ContextElement);
            sink.End();
            sink.BeginList("contextInvariant", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            sink.Serialize(ContextInvariantElement);
            sink.End();
            sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); TypeElement?.Serialize(sink);
            sink.Element("baseDefinition", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); BaseDefinitionElement?.Serialize(sink);
            sink.Element("derivation", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); DerivationElement?.Serialize(sink);
            sink.Element("snapshot", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Snapshot?.Serialize(sink);
            sink.Element("differential", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Differential?.Serialize(sink);
            sink.End();
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
                foreach (var elem in Keyword) { if (elem != null) yield return elem; }
                if (FhirVersionElement != null) yield return FhirVersionElement;
                foreach (var elem in Mapping) { if (elem != null) yield return elem; }
                if (KindElement != null) yield return KindElement;
                if (AbstractElement != null) yield return AbstractElement;
                if (ContextTypeElement != null) yield return ContextTypeElement;
                foreach (var elem in ContextElement) { if (elem != null) yield return elem; }
                foreach (var elem in ContextInvariantElement) { if (elem != null) yield return elem; }
                if (TypeElement != null) yield return TypeElement;
                if (BaseDefinitionElement != null) yield return BaseDefinitionElement;
                if (DerivationElement != null) yield return DerivationElement;
                if (Snapshot != null) yield return Snapshot;
                if (Differential != null) yield return Differential;
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (PurposeElement != null) yield return new ElementValue("purpose", PurposeElement);
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                foreach (var elem in Keyword) { if (elem != null) yield return new ElementValue("keyword", elem); }
                if (FhirVersionElement != null) yield return new ElementValue("fhirVersion", FhirVersionElement);
                foreach (var elem in Mapping) { if (elem != null) yield return new ElementValue("mapping", elem); }
                if (KindElement != null) yield return new ElementValue("kind", KindElement);
                if (AbstractElement != null) yield return new ElementValue("abstract", AbstractElement);
                if (ContextTypeElement != null) yield return new ElementValue("contextType", ContextTypeElement);
                foreach (var elem in ContextElement) { if (elem != null) yield return new ElementValue("context", elem); }
                foreach (var elem in ContextInvariantElement) { if (elem != null) yield return new ElementValue("contextInvariant", elem); }
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (BaseDefinitionElement != null) yield return new ElementValue("baseDefinition", BaseDefinitionElement);
                if (DerivationElement != null) yield return new ElementValue("derivation", DerivationElement);
                if (Snapshot != null) yield return new ElementValue("snapshot", Snapshot);
                if (Differential != null) yield return new ElementValue("differential", Differential);
            }
        }
    
    }

}
