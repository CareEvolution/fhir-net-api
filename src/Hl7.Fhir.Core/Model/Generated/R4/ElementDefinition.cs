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
    /// Definition of an element in a resource or extension
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "ElementDefinition")]
    [DataContract]
    public partial class ElementDefinition : Hl7.Fhir.Model.Primitive<string>, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override string TypeName { get { return "ElementDefinition"; } }
    
        public ElementDefinition(string value)
        {
            Value = value;
        }
    
        public ElementDefinition(): this((string)null) {}
    
        /// <summary>
        /// Primitive value of the element
        /// </summary>
        [FhirElement("value", IsPrimitiveValue=true, XmlSerialization=XmlSerializationHint.Attribute, InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=30)]
        [CLSCompliant(false)]
        [DataMember]
        public string Value
        {
            get { return (string)ObjectValue; }
            set { ObjectValue = value; OnPropertyChanged("Value"); }
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SlicingComponent")]
        [DataContract]
        public partial class SlicingComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SlicingComponent"; } }
            
            /// <summary>
            /// Element values that are used to distinguish the slices
            /// </summary>
            [FhirElement("discriminator", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DiscriminatorComponent> Discriminator
            {
                get { if(_Discriminator==null) _Discriminator = new List<DiscriminatorComponent>(); return _Discriminator; }
                set { _Discriminator = value; OnPropertyChanged("Discriminator"); }
            }
            
            private List<DiscriminatorComponent> _Discriminator;
            
            /// <summary>
            /// Text description of how slicing works (or not)
            /// </summary>
            [FhirElement("description", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Text description of how slicing works (or not)
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
                        DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// If elements must be in same order as slices
            /// </summary>
            [FhirElement("ordered", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean OrderedElement
            {
                get { return _OrderedElement; }
                set { _OrderedElement = value; OnPropertyChanged("OrderedElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _OrderedElement;
            
            /// <summary>
            /// If elements must be in same order as slices
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Ordered
            {
                get { return OrderedElement != null ? OrderedElement.Value : null; }
                set
                {
                    if (value == null)
                        OrderedElement = null;
                    else
                        OrderedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Ordered");
                }
            }
            
            /// <summary>
            /// closed | open | openAtEnd
            /// </summary>
            [FhirElement("rules", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code RulesElement
            {
                get { return _RulesElement; }
                set { _RulesElement = value; OnPropertyChanged("RulesElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _RulesElement;
            
            /// <summary>
            /// closed | open | openAtEnd
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Rules
            {
                get { return RulesElement != null ? RulesElement.Value : null; }
                set
                {
                    if (value == null)
                        RulesElement = null;
                    else
                        RulesElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Rules");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SlicingComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Discriminator != null) dest.Discriminator = new List<DiscriminatorComponent>(Discriminator.DeepCopy());
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(OrderedElement != null) dest.OrderedElement = (Hl7.Fhir.Model.FhirBoolean)OrderedElement.DeepCopy();
                    if(RulesElement != null) dest.RulesElement = (Hl7.Fhir.Model.R4.Code)RulesElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SlicingComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SlicingComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Discriminator, otherT.Discriminator)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(OrderedElement, otherT.OrderedElement)) return false;
                if( !DeepComparable.Matches(RulesElement, otherT.RulesElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SlicingComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Discriminator, otherT.Discriminator)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(OrderedElement, otherT.OrderedElement)) return false;
                if( !DeepComparable.IsExactly(RulesElement, otherT.RulesElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Discriminator) { if (elem != null) yield return elem; }
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (OrderedElement != null) yield return OrderedElement;
                    if (RulesElement != null) yield return RulesElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Discriminator) { if (elem != null) yield return new ElementValue("discriminator", true, elem); }
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (OrderedElement != null) yield return new ElementValue("ordered", false, OrderedElement);
                    if (RulesElement != null) yield return new ElementValue("rules", false, RulesElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DiscriminatorComponent")]
        [DataContract]
        public partial class DiscriminatorComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DiscriminatorComponent"; } }
            
            /// <summary>
            /// value | exists | pattern | type | profile
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _TypeElement;
            
            /// <summary>
            /// value | exists | pattern | type | profile
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
                        TypeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Path to element value
            /// </summary>
            [FhirElement("path", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString PathElement
            {
                get { return _PathElement; }
                set { _PathElement = value; OnPropertyChanged("PathElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _PathElement;
            
            /// <summary>
            /// Path to element value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Path");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DiscriminatorComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.R4.Code)TypeElement.DeepCopy();
                    if(PathElement != null) dest.PathElement = (Hl7.Fhir.Model.FhirString)PathElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DiscriminatorComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DiscriminatorComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DiscriminatorComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (PathElement != null) yield return PathElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (PathElement != null) yield return new ElementValue("path", false, PathElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "BaseComponent")]
        [DataContract]
        public partial class BaseComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "BaseComponent"; } }
            
            /// <summary>
            /// Path that identifies the base element
            /// </summary>
            [FhirElement("path", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString PathElement
            {
                get { return _PathElement; }
                set { _PathElement = value; OnPropertyChanged("PathElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _PathElement;
            
            /// <summary>
            /// Path that identifies the base element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Path");
                }
            }
            
            /// <summary>
            /// Min cardinality of the base element
            /// </summary>
            [FhirElement("min", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.UnsignedInt MinElement
            {
                get { return _MinElement; }
                set { _MinElement = value; OnPropertyChanged("MinElement"); }
            }
            
            private Hl7.Fhir.Model.R4.UnsignedInt _MinElement;
            
            /// <summary>
            /// Min cardinality of the base element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Min
            {
                get { return MinElement != null ? MinElement.Value : null; }
                set
                {
                    if (value == null)
                        MinElement = null;
                    else
                        MinElement = new Hl7.Fhir.Model.R4.UnsignedInt(value);
                    OnPropertyChanged("Min");
                }
            }
            
            /// <summary>
            /// Max cardinality of the base element
            /// </summary>
            [FhirElement("max", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MaxElement
            {
                get { return _MaxElement; }
                set { _MaxElement = value; OnPropertyChanged("MaxElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MaxElement;
            
            /// <summary>
            /// Max cardinality of the base element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Max
            {
                get { return MaxElement != null ? MaxElement.Value : null; }
                set
                {
                    if (value == null)
                        MaxElement = null;
                    else
                        MaxElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Max");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BaseComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(PathElement != null) dest.PathElement = (Hl7.Fhir.Model.FhirString)PathElement.DeepCopy();
                    if(MinElement != null) dest.MinElement = (Hl7.Fhir.Model.R4.UnsignedInt)MinElement.DeepCopy();
                    if(MaxElement != null) dest.MaxElement = (Hl7.Fhir.Model.FhirString)MaxElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BaseComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BaseComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if( !DeepComparable.Matches(MinElement, otherT.MinElement)) return false;
                if( !DeepComparable.Matches(MaxElement, otherT.MaxElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BaseComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if( !DeepComparable.IsExactly(MinElement, otherT.MinElement)) return false;
                if( !DeepComparable.IsExactly(MaxElement, otherT.MaxElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PathElement != null) yield return PathElement;
                    if (MinElement != null) yield return MinElement;
                    if (MaxElement != null) yield return MaxElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PathElement != null) yield return new ElementValue("path", false, PathElement);
                    if (MinElement != null) yield return new ElementValue("min", false, MinElement);
                    if (MaxElement != null) yield return new ElementValue("max", false, MaxElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "TypeRefComponent")]
        [DataContract]
        public partial class TypeRefComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TypeRefComponent"; } }
            
            /// <summary>
            /// Data type or Resource (reference to definition)
            /// </summary>
            [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _CodeElement;
            
            /// <summary>
            /// Data type or Resource (reference to definition)
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
                        CodeElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// Profiles (StructureDefinition or IG) - one must apply
            /// </summary>
            [FhirElement("profile", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.canonical> Profile
            {
                get { if(_Profile==null) _Profile = new List<Hl7.Fhir.Model.canonical>(); return _Profile; }
                set { _Profile = value; OnPropertyChanged("Profile"); }
            }
            
            private List<Hl7.Fhir.Model.canonical> _Profile;
            
            /// <summary>
            /// Profile (StructureDefinition or IG) on the Reference target - one must apply
            /// </summary>
            [FhirElement("targetProfile", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.canonical> TargetProfile
            {
                get { if(_TargetProfile==null) _TargetProfile = new List<Hl7.Fhir.Model.canonical>(); return _TargetProfile; }
                set { _TargetProfile = value; OnPropertyChanged("TargetProfile"); }
            }
            
            private List<Hl7.Fhir.Model.canonical> _TargetProfile;
            
            /// <summary>
            /// contained | referenced | bundled - how aggregated
            /// </summary>
            [FhirElement("aggregation", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Code> AggregationElement
            {
                get { if(_AggregationElement==null) _AggregationElement = new List<Hl7.Fhir.Model.R4.Code>(); return _AggregationElement; }
                set { _AggregationElement = value; OnPropertyChanged("AggregationElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Code> _AggregationElement;
            
            /// <summary>
            /// contained | referenced | bundled - how aggregated
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Aggregation
            {
                get { return AggregationElement != null ? AggregationElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        AggregationElement = null;
                    else
                        AggregationElement = new List<Hl7.Fhir.Model.R4.Code>(value.Select(elem=>new Hl7.Fhir.Model.R4.Code(elem)));
                    OnPropertyChanged("Aggregation");
                }
            }
            
            /// <summary>
            /// either | independent | specific
            /// </summary>
            [FhirElement("versioning", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code VersioningElement
            {
                get { return _VersioningElement; }
                set { _VersioningElement = value; OnPropertyChanged("VersioningElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _VersioningElement;
            
            /// <summary>
            /// either | independent | specific
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Versioning
            {
                get { return VersioningElement != null ? VersioningElement.Value : null; }
                set
                {
                    if (value == null)
                        VersioningElement = null;
                    else
                        VersioningElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Versioning");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TypeRefComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CodeElement != null) dest.CodeElement = (Hl7.Fhir.Model.FhirUri)CodeElement.DeepCopy();
                    if(Profile != null) dest.Profile = new List<Hl7.Fhir.Model.canonical>(Profile.DeepCopy());
                    if(TargetProfile != null) dest.TargetProfile = new List<Hl7.Fhir.Model.canonical>(TargetProfile.DeepCopy());
                    if(AggregationElement != null) dest.AggregationElement = new List<Hl7.Fhir.Model.R4.Code>(AggregationElement.DeepCopy());
                    if(VersioningElement != null) dest.VersioningElement = (Hl7.Fhir.Model.R4.Code)VersioningElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TypeRefComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TypeRefComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.Matches(Profile, otherT.Profile)) return false;
                if( !DeepComparable.Matches(TargetProfile, otherT.TargetProfile)) return false;
                if( !DeepComparable.Matches(AggregationElement, otherT.AggregationElement)) return false;
                if( !DeepComparable.Matches(VersioningElement, otherT.VersioningElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TypeRefComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
                if( !DeepComparable.IsExactly(TargetProfile, otherT.TargetProfile)) return false;
                if( !DeepComparable.IsExactly(AggregationElement, otherT.AggregationElement)) return false;
                if( !DeepComparable.IsExactly(VersioningElement, otherT.VersioningElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    foreach (var elem in Profile) { if (elem != null) yield return elem; }
                    foreach (var elem in TargetProfile) { if (elem != null) yield return elem; }
                    foreach (var elem in AggregationElement) { if (elem != null) yield return elem; }
                    if (VersioningElement != null) yield return VersioningElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", false, CodeElement);
                    foreach (var elem in Profile) { if (elem != null) yield return new ElementValue("profile", true, elem); }
                    foreach (var elem in TargetProfile) { if (elem != null) yield return new ElementValue("targetProfile", true, elem); }
                    foreach (var elem in AggregationElement) { if (elem != null) yield return new ElementValue("aggregation", true, elem); }
                    if (VersioningElement != null) yield return new ElementValue("versioning", false, VersioningElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ExampleComponent")]
        [DataContract]
        public partial class ExampleComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ExampleComponent"; } }
            
            /// <summary>
            /// Describes the purpose of this example
            /// </summary>
            [FhirElement("label", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString LabelElement
            {
                get { return _LabelElement; }
                set { _LabelElement = value; OnPropertyChanged("LabelElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _LabelElement;
            
            /// <summary>
            /// Describes the purpose of this example
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Label
            {
                get { return LabelElement != null ? LabelElement.Value : null; }
                set
                {
                    if (value == null)
                        LabelElement = null;
                    else
                        LabelElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Label");
                }
            }
            
            /// <summary>
            /// Value of Example (one of allowed types)
            /// </summary>
            [FhirElement("value", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Base64Binary),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.canonical),typeof(Hl7.Fhir.Model.R4.Code),typeof(Hl7.Fhir.Model.R4.Date),typeof(Hl7.Fhir.Model.R4.FhirDateTime),typeof(Hl7.Fhir.Model.R4.FhirDecimal),typeof(Hl7.Fhir.Model.R4.Id),typeof(Hl7.Fhir.Model.Instant),typeof(Hl7.Fhir.Model.R4.Integer),typeof(Hl7.Fhir.Model.Markdown),typeof(Hl7.Fhir.Model.R4.Oid),typeof(Hl7.Fhir.Model.R4.PositiveInt),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.R4.Time),typeof(Hl7.Fhir.Model.R4.UnsignedInt),typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.url),typeof(Hl7.Fhir.Model.uuid),typeof(Hl7.Fhir.Model.R4.Address),typeof(Hl7.Fhir.Model.R4.Age),typeof(Hl7.Fhir.Model.R4.Annotation),typeof(Hl7.Fhir.Model.R4.Attachment),typeof(Hl7.Fhir.Model.R4.CodeableConcept),typeof(Hl7.Fhir.Model.R4.Coding),typeof(Hl7.Fhir.Model.R4.ContactPoint),typeof(Hl7.Fhir.Model.R4.Count),typeof(Hl7.Fhir.Model.R4.Distance),typeof(Hl7.Fhir.Model.R4.Duration),typeof(Hl7.Fhir.Model.R4.HumanName),typeof(Hl7.Fhir.Model.R4.Identifier),typeof(Hl7.Fhir.Model.R4.Money),typeof(Hl7.Fhir.Model.R4.Period),typeof(Hl7.Fhir.Model.R4.Quantity),typeof(Hl7.Fhir.Model.R4.Range),typeof(Hl7.Fhir.Model.R4.Ratio),typeof(Hl7.Fhir.Model.R4.ResourceReference),typeof(Hl7.Fhir.Model.R4.SampledData),typeof(Hl7.Fhir.Model.R4.Signature),typeof(Hl7.Fhir.Model.R4.Timing),typeof(Hl7.Fhir.Model.R4.ParameterDefinition),typeof(Hl7.Fhir.Model.R4.DataRequirement),typeof(Hl7.Fhir.Model.R4.RelatedArtifact),typeof(Hl7.Fhir.Model.R4.ContactDetail),typeof(Hl7.Fhir.Model.R4.Contributor),typeof(Hl7.Fhir.Model.R4.TriggerDefinition),typeof(Hl7.Fhir.Model.R4.UsageContext),typeof(Hl7.Fhir.Model.R4.Dosage))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.Element _Value;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ExampleComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(LabelElement != null) dest.LabelElement = (Hl7.Fhir.Model.FhirString)LabelElement.DeepCopy();
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ExampleComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ExampleComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(LabelElement, otherT.LabelElement)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExampleComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(LabelElement, otherT.LabelElement)) return false;
                if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LabelElement != null) yield return LabelElement;
                    if (Value != null) yield return Value;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LabelElement != null) yield return new ElementValue("label", false, LabelElement);
                    if (Value != null) yield return new ElementValue("value", false, Value);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ConstraintComponent")]
        [DataContract]
        public partial class ConstraintComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ConstraintComponent"; } }
            
            /// <summary>
            /// Target of 'condition' reference above
            /// </summary>
            [FhirElement("key", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Id KeyElement
            {
                get { return _KeyElement; }
                set { _KeyElement = value; OnPropertyChanged("KeyElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Id _KeyElement;
            
            /// <summary>
            /// Target of 'condition' reference above
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Key
            {
                get { return KeyElement != null ? KeyElement.Value : null; }
                set
                {
                    if (value == null)
                        KeyElement = null;
                    else
                        KeyElement = new Hl7.Fhir.Model.R4.Id(value);
                    OnPropertyChanged("Key");
                }
            }
            
            /// <summary>
            /// Why this constraint is necessary or appropriate
            /// </summary>
            [FhirElement("requirements", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString RequirementsElement
            {
                get { return _RequirementsElement; }
                set { _RequirementsElement = value; OnPropertyChanged("RequirementsElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _RequirementsElement;
            
            /// <summary>
            /// Why this constraint is necessary or appropriate
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Requirements
            {
                get { return RequirementsElement != null ? RequirementsElement.Value : null; }
                set
                {
                    if (value == null)
                        RequirementsElement = null;
                    else
                        RequirementsElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Requirements");
                }
            }
            
            /// <summary>
            /// error | warning
            /// </summary>
            [FhirElement("severity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code SeverityElement
            {
                get { return _SeverityElement; }
                set { _SeverityElement = value; OnPropertyChanged("SeverityElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _SeverityElement;
            
            /// <summary>
            /// error | warning
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Severity
            {
                get { return SeverityElement != null ? SeverityElement.Value : null; }
                set
                {
                    if (value == null)
                        SeverityElement = null;
                    else
                        SeverityElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Severity");
                }
            }
            
            /// <summary>
            /// Human description of constraint
            /// </summary>
            [FhirElement("human", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString HumanElement
            {
                get { return _HumanElement; }
                set { _HumanElement = value; OnPropertyChanged("HumanElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _HumanElement;
            
            /// <summary>
            /// Human description of constraint
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Human
            {
                get { return HumanElement != null ? HumanElement.Value : null; }
                set
                {
                    if (value == null)
                        HumanElement = null;
                    else
                        HumanElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Human");
                }
            }
            
            /// <summary>
            /// FHIRPath expression of constraint
            /// </summary>
            [FhirElement("expression", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ExpressionElement
            {
                get { return _ExpressionElement; }
                set { _ExpressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ExpressionElement;
            
            /// <summary>
            /// FHIRPath expression of constraint
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Expression
            {
                get { return ExpressionElement != null ? ExpressionElement.Value : null; }
                set
                {
                    if (value == null)
                        ExpressionElement = null;
                    else
                        ExpressionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Expression");
                }
            }
            
            /// <summary>
            /// XPath expression of constraint
            /// </summary>
            [FhirElement("xpath", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString XpathElement
            {
                get { return _XpathElement; }
                set { _XpathElement = value; OnPropertyChanged("XpathElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _XpathElement;
            
            /// <summary>
            /// XPath expression of constraint
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Xpath
            {
                get { return XpathElement != null ? XpathElement.Value : null; }
                set
                {
                    if (value == null)
                        XpathElement = null;
                    else
                        XpathElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Xpath");
                }
            }
            
            /// <summary>
            /// Reference to original source of constraint
            /// </summary>
            [FhirElement("source", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.canonical Source
            {
                get { return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private Hl7.Fhir.Model.canonical _Source;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ConstraintComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(KeyElement != null) dest.KeyElement = (Hl7.Fhir.Model.R4.Id)KeyElement.DeepCopy();
                    if(RequirementsElement != null) dest.RequirementsElement = (Hl7.Fhir.Model.FhirString)RequirementsElement.DeepCopy();
                    if(SeverityElement != null) dest.SeverityElement = (Hl7.Fhir.Model.R4.Code)SeverityElement.DeepCopy();
                    if(HumanElement != null) dest.HumanElement = (Hl7.Fhir.Model.FhirString)HumanElement.DeepCopy();
                    if(ExpressionElement != null) dest.ExpressionElement = (Hl7.Fhir.Model.FhirString)ExpressionElement.DeepCopy();
                    if(XpathElement != null) dest.XpathElement = (Hl7.Fhir.Model.FhirString)XpathElement.DeepCopy();
                    if(Source != null) dest.Source = (Hl7.Fhir.Model.canonical)Source.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ConstraintComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ConstraintComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(KeyElement, otherT.KeyElement)) return false;
                if( !DeepComparable.Matches(RequirementsElement, otherT.RequirementsElement)) return false;
                if( !DeepComparable.Matches(SeverityElement, otherT.SeverityElement)) return false;
                if( !DeepComparable.Matches(HumanElement, otherT.HumanElement)) return false;
                if( !DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;
                if( !DeepComparable.Matches(XpathElement, otherT.XpathElement)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ConstraintComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(KeyElement, otherT.KeyElement)) return false;
                if( !DeepComparable.IsExactly(RequirementsElement, otherT.RequirementsElement)) return false;
                if( !DeepComparable.IsExactly(SeverityElement, otherT.SeverityElement)) return false;
                if( !DeepComparable.IsExactly(HumanElement, otherT.HumanElement)) return false;
                if( !DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;
                if( !DeepComparable.IsExactly(XpathElement, otherT.XpathElement)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (KeyElement != null) yield return KeyElement;
                    if (RequirementsElement != null) yield return RequirementsElement;
                    if (SeverityElement != null) yield return SeverityElement;
                    if (HumanElement != null) yield return HumanElement;
                    if (ExpressionElement != null) yield return ExpressionElement;
                    if (XpathElement != null) yield return XpathElement;
                    if (Source != null) yield return Source;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (KeyElement != null) yield return new ElementValue("key", false, KeyElement);
                    if (RequirementsElement != null) yield return new ElementValue("requirements", false, RequirementsElement);
                    if (SeverityElement != null) yield return new ElementValue("severity", false, SeverityElement);
                    if (HumanElement != null) yield return new ElementValue("human", false, HumanElement);
                    if (ExpressionElement != null) yield return new ElementValue("expression", false, ExpressionElement);
                    if (XpathElement != null) yield return new ElementValue("xpath", false, XpathElement);
                    if (Source != null) yield return new ElementValue("source", false, Source);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ElementDefinitionBindingComponent")]
        [DataContract]
        public partial class ElementDefinitionBindingComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ElementDefinitionBindingComponent"; } }
            
            /// <summary>
            /// required | extensible | preferred | example
            /// </summary>
            [FhirElement("strength", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code StrengthElement
            {
                get { return _StrengthElement; }
                set { _StrengthElement = value; OnPropertyChanged("StrengthElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _StrengthElement;
            
            /// <summary>
            /// required | extensible | preferred | example
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Strength
            {
                get { return StrengthElement != null ? StrengthElement.Value : null; }
                set
                {
                    if (value == null)
                        StrengthElement = null;
                    else
                        StrengthElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Strength");
                }
            }
            
            /// <summary>
            /// Human explanation of the value set
            /// </summary>
            [FhirElement("description", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Human explanation of the value set
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
                        DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Source of value set
            /// </summary>
            [FhirElement("valueSet", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.canonical))]
            [DataMember]
            public Hl7.Fhir.Model.Element ValueSet
            {
                get { return _ValueSet; }
                set { _ValueSet = value; OnPropertyChanged("ValueSet"); }
            }
            
            private Hl7.Fhir.Model.Element _ValueSet;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ElementDefinitionBindingComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(StrengthElement != null) dest.StrengthElement = (Hl7.Fhir.Model.R4.Code)StrengthElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(ValueSet != null) dest.ValueSet = (Hl7.Fhir.Model.Element)ValueSet.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ElementDefinitionBindingComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ElementDefinitionBindingComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(StrengthElement, otherT.StrengthElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(ValueSet, otherT.ValueSet)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ElementDefinitionBindingComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(StrengthElement, otherT.StrengthElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(ValueSet, otherT.ValueSet)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StrengthElement != null) yield return StrengthElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (ValueSet != null) yield return ValueSet;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StrengthElement != null) yield return new ElementValue("strength", false, StrengthElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (ValueSet != null) yield return new ElementValue("valueSet", false, ValueSet);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "MappingComponent")]
        [DataContract]
        public partial class MappingComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MappingComponent"; } }
            
            /// <summary>
            /// Reference to mapping declaration
            /// </summary>
            [FhirElement("identity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Id IdentityElement
            {
                get { return _IdentityElement; }
                set { _IdentityElement = value; OnPropertyChanged("IdentityElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Id _IdentityElement;
            
            /// <summary>
            /// Reference to mapping declaration
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
                        IdentityElement = new Hl7.Fhir.Model.R4.Id(value);
                    OnPropertyChanged("Identity");
                }
            }
            
            /// <summary>
            /// Computable language of mapping
            /// </summary>
            [FhirElement("language", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code LanguageElement
            {
                get { return _LanguageElement; }
                set { _LanguageElement = value; OnPropertyChanged("LanguageElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _LanguageElement;
            
            /// <summary>
            /// Computable language of mapping
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Language
            {
                get { return LanguageElement != null ? LanguageElement.Value : null; }
                set
                {
                    if (value == null)
                        LanguageElement = null;
                    else
                        LanguageElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Language");
                }
            }
            
            /// <summary>
            /// Details of the mapping
            /// </summary>
            [FhirElement("map", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString MapElement
            {
                get { return _MapElement; }
                set { _MapElement = value; OnPropertyChanged("MapElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _MapElement;
            
            /// <summary>
            /// Details of the mapping
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Map
            {
                get { return MapElement != null ? MapElement.Value : null; }
                set
                {
                    if (value == null)
                        MapElement = null;
                    else
                        MapElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Map");
                }
            }
            
            /// <summary>
            /// Comments about the mapping or its use
            /// </summary>
            [FhirElement("comment", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CommentElement
            {
                get { return _CommentElement; }
                set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _CommentElement;
            
            /// <summary>
            /// Comments about the mapping or its use
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
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MappingComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(IdentityElement != null) dest.IdentityElement = (Hl7.Fhir.Model.R4.Id)IdentityElement.DeepCopy();
                    if(LanguageElement != null) dest.LanguageElement = (Hl7.Fhir.Model.R4.Code)LanguageElement.DeepCopy();
                    if(MapElement != null) dest.MapElement = (Hl7.Fhir.Model.FhirString)MapElement.DeepCopy();
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
                if( !DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if( !DeepComparable.Matches(MapElement, otherT.MapElement)) return false;
                if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MappingComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(IdentityElement, otherT.IdentityElement)) return false;
                if( !DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if( !DeepComparable.IsExactly(MapElement, otherT.MapElement)) return false;
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
                    if (LanguageElement != null) yield return LanguageElement;
                    if (MapElement != null) yield return MapElement;
                    if (CommentElement != null) yield return CommentElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IdentityElement != null) yield return new ElementValue("identity", false, IdentityElement);
                    if (LanguageElement != null) yield return new ElementValue("language", false, LanguageElement);
                    if (MapElement != null) yield return new ElementValue("map", false, MapElement);
                    if (CommentElement != null) yield return new ElementValue("comment", false, CommentElement);
                }
            }
        
        
        }
    
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_2 = new ElementDefinitionConstraint
        {
            Expression = "min.empty() or max.empty() or (max = '*') or iif(max != '*', min <= max.toInteger())",
            Key = "eld-2",
            Severity = ConstraintSeverity.Warning,
            Human = "Min <= Max",
            Xpath = "not(exists(f:min)) or not(exists(f:max)) or (not(f:max/@value) and not(f:min/@value)) or (f:max/@value = '*') or (number(f:max/@value) >= f:min/@value)"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_5 = new ElementDefinitionConstraint
        {
            Expression = "contentReference.empty() or (type.empty() and defaultValue.empty() and fixed.empty() and pattern.empty() and example.empty() and minValue.empty() and maxValue.empty() and maxLength.empty() and binding.empty())",
            Key = "eld-5",
            Severity = ConstraintSeverity.Warning,
            Human = "if the element definition has a contentReference, it cannot have type, defaultValue, fixed, pattern, example, minValue, maxValue, maxLength, or binding",
            Xpath = "not(exists(f:contentReference) and (exists(f:type) or exists(f:*[starts-with(local-name(.), 'value')]) or exists(f:*[starts-with(local-name(.), 'defaultValue')])  or exists(f:*[starts-with(local-name(.), 'fixed')]) or exists(f:*[starts-with(local-name(.), 'pattern')]) or exists(f:*[starts-with(local-name(.), 'example')]) or exists(f:*[starts-with(local-name(.), 'f:minValue')]) or exists(f:*[starts-with(local-name(.), 'f:maxValue')]) or exists(f:maxLength) or exists(f:binding)))"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_7 = new ElementDefinitionConstraint
        {
            Expression = "pattern.empty() or (type.count() <= 1)",
            Key = "eld-7",
            Severity = ConstraintSeverity.Warning,
            Human = "Pattern may only be specified if there is one type",
            Xpath = "not(exists(f:*[starts-with(local-name(.), 'pattern')])) or (count(f:type)<=1)"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_6 = new ElementDefinitionConstraint
        {
            Expression = "fixed.empty() or (type.count()  <= 1)",
            Key = "eld-6",
            Severity = ConstraintSeverity.Warning,
            Human = "Fixed value may only be specified if there is one type",
            Xpath = "not(exists(f:*[starts-with(local-name(.), 'fixed')])) or (count(f:type)<=1)"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_11 = new ElementDefinitionConstraint
        {
            Expression = "binding.empty() or type.code.empty() or type.select((code = 'code') or (code = 'Coding') or (code='CodeableConcept') or (code = 'Quantity') or (code = 'string') or (code = 'uri')).exists()",
            Key = "eld-11",
            Severity = ConstraintSeverity.Warning,
            Human = "Binding can only be present for coded elements, string, and uri",
            Xpath = "not(exists(f:binding)) or (count(f:type/f:code) = 0) or  f:type/f:code/@value=('code','Coding','CodeableConcept','Quantity','string', 'uri')"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_8 = new ElementDefinitionConstraint
        {
            Expression = "pattern.empty() or fixed.empty()",
            Key = "eld-8",
            Severity = ConstraintSeverity.Warning,
            Human = "Pattern and value are mutually exclusive",
            Xpath = "not(exists(f:*[starts-with(local-name(.), 'pattern')])) or not(exists(f:*[starts-with(local-name(.), 'fixed')]))"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_14 = new ElementDefinitionConstraint
        {
            Expression = "constraint.select(key).isDistinct()",
            Key = "eld-14",
            Severity = ConstraintSeverity.Warning,
            Human = "Constraints must be unique by key",
            Xpath = "count(f:constraint) = count(distinct-values(f:constraint/f:key/@value))"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_13 = new ElementDefinitionConstraint
        {
            Expression = "type.select(code).isDistinct()",
            Key = "eld-13",
            Severity = ConstraintSeverity.Warning,
            Human = "Types must be unique by code",
            Xpath = "not(exists(for $type in f:type return $type/preceding-sibling::f:type[f:code/@value=$type/f:code/@value))"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_16 = new ElementDefinitionConstraint
        {
            Expression = "sliceName.empty() or sliceName.matches('^[a-zA-Z0-9\\\\/\\\\-_\\\\[\\\\]\\\\@]+$')",
            Key = "eld-16",
            Severity = ConstraintSeverity.Warning,
            Human = "sliceName must be composed of proper tokens separated by \"/\"",
            Xpath = "not(exists(f:sliceName/@value)) or matches(f:sliceName/@value, '^[a-zA-Z0-9\\/\\-_\\[\\]\\@]+$')"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_15 = new ElementDefinitionConstraint
        {
            Expression = "defaultValue.empty() or meaningWhenMissing.empty()",
            Key = "eld-15",
            Severity = ConstraintSeverity.Warning,
            Human = "default value and meaningWhenMissing are mutually exclusive",
            Xpath = "not(exists(f:*[starts-with(local-name(.), 'fixed')])) or not(exists(f:meaningWhenMissing))"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_18 = new ElementDefinitionConstraint
        {
            Expression = "isModifier implies isModifierReason.exists()",
            Key = "eld-18",
            Severity = ConstraintSeverity.Warning,
            Human = "Must have a modifier reason if isModifier = true",
            Xpath = "not(f:isModifier/@value = 'true') or exists(f:isModifierReason)"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_1 = new ElementDefinitionConstraint
        {
            Expression = "slicing.all(discriminator.exists() or description.exists())",
            Key = "eld-1",
            Severity = ConstraintSeverity.Warning,
            Human = "If there are no discriminators, there must be a definition",
            Xpath = "(f:discriminator) or (f:description)"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_3 = new ElementDefinitionConstraint
        {
            Expression = "max.all(empty() or ($this = '*') or (toInteger() >= 0))",
            Key = "eld-3",
            Severity = ConstraintSeverity.Warning,
            Human = "Max SHALL be a number or \"*\"",
            Xpath = "@value='*' or (normalize-space(@value)!='' and normalize-space(translate(@value, '0123456789',''))='')"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_4 = new ElementDefinitionConstraint
        {
            Expression = "type.all(aggregation.empty() or (code = 'Reference'))",
            Key = "eld-4",
            Severity = ConstraintSeverity.Warning,
            Human = "Aggregation may only be specified if one of the allowed types for the element is a reference",
            Xpath = "not(exists(f:aggregation)) or exists(f:code[@value = 'Reference'])"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_17 = new ElementDefinitionConstraint
        {
            Expression = "type.all(code='Reference' or targetProfile.empty())",
            Key = "eld-17",
            Severity = ConstraintSeverity.Warning,
            Human = "targetProfie is only allowed if the type is reference",
            Xpath = "not(exists(f:targetProfile)) or (f:code/@value = 'Reference')"
        };
    
        public static ElementDefinitionConstraint ElementDefinition_ELD_12 = new ElementDefinitionConstraint
        {
            Expression = "binding.all((valueSet is uri).not() or (valueSet as uri).startsWith('http:') or (valueSet as uri).startsWith('https') or (valueSet as uri).startsWith('urn:'))",
            Key = "eld-12",
            Severity = ConstraintSeverity.Warning,
            Human = "ValueSet as a URI SHALL start with http:// or https:// or urn:",
            Xpath = "not(exists(f:valueSetUri)) or (starts-with(string(f:valueSetUri/@value), 'http:') or starts-with(string(f:valueSetUri/@value), 'https:') or starts-with(string(f:valueSetUri/@value), 'urn:'))"
        };
    
        // TODO: Add code to enforce the above constraints
    
    }

}
