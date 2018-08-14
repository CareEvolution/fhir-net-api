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
    /// Todo
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "SubstanceReferenceInformation", IsResource=true)]
    [DataContract]
    public partial class SubstanceReferenceInformation : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SubstanceReferenceInformation; } }
        [NotMapped]
        public override string TypeName { get { return "SubstanceReferenceInformation"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "GeneComponent")]
        [DataContract]
        public partial class GeneComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "GeneComponent"; } }
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("geneSequenceOrigin", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept GeneSequenceOrigin
            {
                get { return _GeneSequenceOrigin; }
                set { _GeneSequenceOrigin = value; OnPropertyChanged("GeneSequenceOrigin"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _GeneSequenceOrigin;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("gene", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Gene
            {
                get { return _Gene; }
                set { _Gene = value; OnPropertyChanged("Gene"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Gene;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Source
            {
                get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Source;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GeneComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(GeneSequenceOrigin != null) dest.GeneSequenceOrigin = (Hl7.Fhir.Model.R4.CodeableConcept)GeneSequenceOrigin.DeepCopy();
                    if(Gene != null) dest.Gene = (Hl7.Fhir.Model.R4.CodeableConcept)Gene.DeepCopy();
                    if(Source != null) dest.Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GeneComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GeneComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(GeneSequenceOrigin, otherT.GeneSequenceOrigin)) return false;
                if( !DeepComparable.Matches(Gene, otherT.Gene)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GeneComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(GeneSequenceOrigin, otherT.GeneSequenceOrigin)) return false;
                if( !DeepComparable.IsExactly(Gene, otherT.Gene)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (GeneSequenceOrigin != null) yield return GeneSequenceOrigin;
                    if (Gene != null) yield return Gene;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (GeneSequenceOrigin != null) yield return new ElementValue("geneSequenceOrigin", false, GeneSequenceOrigin);
                    if (Gene != null) yield return new ElementValue("gene", false, Gene);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "GeneElementComponent")]
        [DataContract]
        public partial class GeneElementComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "GeneElementComponent"; } }
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("element", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Element
            {
                get { return _Element; }
                set { _Element = value; OnPropertyChanged("Element"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Element;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Source
            {
                get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Source;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GeneElementComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Element != null) dest.Element = (Hl7.Fhir.Model.R4.Identifier)Element.DeepCopy();
                    if(Source != null) dest.Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GeneElementComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GeneElementComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Element, otherT.Element)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GeneElementComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Element, otherT.Element)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Element != null) yield return Element;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Element != null) yield return new ElementValue("element", false, Element);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ClassificationComponent")]
        [DataContract]
        public partial class ClassificationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ClassificationComponent"; } }
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("domain", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Domain
            {
                get { return _Domain; }
                set { _Domain = value; OnPropertyChanged("Domain"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Domain;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("classification", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Classification
            {
                get { return _Classification; }
                set { _Classification = value; OnPropertyChanged("Classification"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Classification;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("subtype", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Subtype
            {
                get { if(_Subtype==null) _Subtype = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Subtype; }
                set { _Subtype = value; OnPropertyChanged("Subtype"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Subtype;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Source
            {
                get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Source;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClassificationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Domain != null) dest.Domain = (Hl7.Fhir.Model.R4.CodeableConcept)Domain.DeepCopy();
                    if(Classification != null) dest.Classification = (Hl7.Fhir.Model.R4.CodeableConcept)Classification.DeepCopy();
                    if(Subtype != null) dest.Subtype = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Subtype.DeepCopy());
                    if(Source != null) dest.Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ClassificationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ClassificationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
                if( !DeepComparable.Matches(Classification, otherT.Classification)) return false;
                if( !DeepComparable.Matches(Subtype, otherT.Subtype)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClassificationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
                if( !DeepComparable.IsExactly(Classification, otherT.Classification)) return false;
                if( !DeepComparable.IsExactly(Subtype, otherT.Subtype)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Domain != null) yield return Domain;
                    if (Classification != null) yield return Classification;
                    foreach (var elem in Subtype) { if (elem != null) yield return elem; }
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Domain != null) yield return new ElementValue("domain", false, Domain);
                    if (Classification != null) yield return new ElementValue("classification", false, Classification);
                    foreach (var elem in Subtype) { if (elem != null) yield return new ElementValue("subtype", true, elem); }
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "RelationshipComponent")]
        [DataContract]
        public partial class RelationshipComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RelationshipComponent"; } }
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("substance", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.ResourceReference),typeof(Hl7.Fhir.Model.R4.CodeableConcept))]
            [DataMember]
            public Hl7.Fhir.Model.Element Substance
            {
                get { return _Substance; }
                set { _Substance = value; OnPropertyChanged("Substance"); }
            }
            
            private Hl7.Fhir.Model.Element _Substance;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("relationship", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Relationship
            {
                get { return _Relationship; }
                set { _Relationship = value; OnPropertyChanged("Relationship"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Relationship;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("interaction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Interaction
            {
                get { return _Interaction; }
                set { _Interaction = value; OnPropertyChanged("Interaction"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Interaction;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("isDefining", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean IsDefiningElement
            {
                get { return _IsDefiningElement; }
                set { _IsDefiningElement = value; OnPropertyChanged("IsDefiningElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _IsDefiningElement;
            
            /// <summary>
            /// Todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? IsDefining
            {
                get { return IsDefiningElement != null ? IsDefiningElement.Value : null; }
                set
                {
                    if (value == null)
                        IsDefiningElement = null;
                    else
                        IsDefiningElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("IsDefining");
                }
            }
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amount", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.Quantity),typeof(Hl7.Fhir.Model.R4.Range),typeof(Hl7.Fhir.Model.FhirString))]
            [DataMember]
            public Hl7.Fhir.Model.Element Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.Element _Amount;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amountType", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept AmountType
            {
                get { return _AmountType; }
                set { _AmountType = value; OnPropertyChanged("AmountType"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _AmountType;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amountText", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AmountTextElement
            {
                get { return _AmountTextElement; }
                set { _AmountTextElement = value; OnPropertyChanged("AmountTextElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AmountTextElement;
            
            /// <summary>
            /// Todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string AmountText
            {
                get { return AmountTextElement != null ? AmountTextElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountTextElement = null;
                    else
                        AmountTextElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("AmountText");
                }
            }
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
            [CLSCompliant(false)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Source
            {
                get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Source;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelationshipComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Substance != null) dest.Substance = (Hl7.Fhir.Model.Element)Substance.DeepCopy();
                    if(Relationship != null) dest.Relationship = (Hl7.Fhir.Model.R4.CodeableConcept)Relationship.DeepCopy();
                    if(Interaction != null) dest.Interaction = (Hl7.Fhir.Model.R4.CodeableConcept)Interaction.DeepCopy();
                    if(IsDefiningElement != null) dest.IsDefiningElement = (Hl7.Fhir.Model.FhirBoolean)IsDefiningElement.DeepCopy();
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.Element)Amount.DeepCopy();
                    if(AmountType != null) dest.AmountType = (Hl7.Fhir.Model.R4.CodeableConcept)AmountType.DeepCopy();
                    if(AmountTextElement != null) dest.AmountTextElement = (Hl7.Fhir.Model.FhirString)AmountTextElement.DeepCopy();
                    if(Source != null) dest.Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelationshipComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelationshipComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Substance, otherT.Substance)) return false;
                if( !DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
                if( !DeepComparable.Matches(Interaction, otherT.Interaction)) return false;
                if( !DeepComparable.Matches(IsDefiningElement, otherT.IsDefiningElement)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if( !DeepComparable.Matches(AmountType, otherT.AmountType)) return false;
                if( !DeepComparable.Matches(AmountTextElement, otherT.AmountTextElement)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelationshipComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
                if( !DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
                if( !DeepComparable.IsExactly(Interaction, otherT.Interaction)) return false;
                if( !DeepComparable.IsExactly(IsDefiningElement, otherT.IsDefiningElement)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if( !DeepComparable.IsExactly(AmountType, otherT.AmountType)) return false;
                if( !DeepComparable.IsExactly(AmountTextElement, otherT.AmountTextElement)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Substance != null) yield return Substance;
                    if (Relationship != null) yield return Relationship;
                    if (Interaction != null) yield return Interaction;
                    if (IsDefiningElement != null) yield return IsDefiningElement;
                    if (Amount != null) yield return Amount;
                    if (AmountType != null) yield return AmountType;
                    if (AmountTextElement != null) yield return AmountTextElement;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Substance != null) yield return new ElementValue("substance", false, Substance);
                    if (Relationship != null) yield return new ElementValue("relationship", false, Relationship);
                    if (Interaction != null) yield return new ElementValue("interaction", false, Interaction);
                    if (IsDefiningElement != null) yield return new ElementValue("isDefining", false, IsDefiningElement);
                    if (Amount != null) yield return new ElementValue("amount", false, Amount);
                    if (AmountType != null) yield return new ElementValue("amountType", false, AmountType);
                    if (AmountTextElement != null) yield return new ElementValue("amountText", false, AmountTextElement);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "TargetComponent")]
        [DataContract]
        public partial class TargetComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TargetComponent"; } }
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("target", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Target
            {
                get { return _Target; }
                set { _Target = value; OnPropertyChanged("Target"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Target;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("interaction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Interaction
            {
                get { return _Interaction; }
                set { _Interaction = value; OnPropertyChanged("Interaction"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Interaction;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("organism", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Organism
            {
                get { return _Organism; }
                set { _Organism = value; OnPropertyChanged("Organism"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Organism;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("organismType", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept OrganismType
            {
                get { return _OrganismType; }
                set { _OrganismType = value; OnPropertyChanged("OrganismType"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _OrganismType;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Source
            {
                get { if(_Source==null) _Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Source;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amount", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.Quantity),typeof(Hl7.Fhir.Model.R4.Range),typeof(Hl7.Fhir.Model.FhirString))]
            [DataMember]
            public Hl7.Fhir.Model.Element Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.Element _Amount;
            
            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amountType", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept AmountType
            {
                get { return _AmountType; }
                set { _AmountType = value; OnPropertyChanged("AmountType"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _AmountType;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TargetComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Target != null) dest.Target = (Hl7.Fhir.Model.R4.Identifier)Target.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Interaction != null) dest.Interaction = (Hl7.Fhir.Model.R4.CodeableConcept)Interaction.DeepCopy();
                    if(Organism != null) dest.Organism = (Hl7.Fhir.Model.R4.CodeableConcept)Organism.DeepCopy();
                    if(OrganismType != null) dest.OrganismType = (Hl7.Fhir.Model.R4.CodeableConcept)OrganismType.DeepCopy();
                    if(Source != null) dest.Source = new List<Hl7.Fhir.Model.R4.ResourceReference>(Source.DeepCopy());
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.Element)Amount.DeepCopy();
                    if(AmountType != null) dest.AmountType = (Hl7.Fhir.Model.R4.CodeableConcept)AmountType.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TargetComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TargetComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Target, otherT.Target)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Interaction, otherT.Interaction)) return false;
                if( !DeepComparable.Matches(Organism, otherT.Organism)) return false;
                if( !DeepComparable.Matches(OrganismType, otherT.OrganismType)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if( !DeepComparable.Matches(AmountType, otherT.AmountType)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TargetComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Target, otherT.Target)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Interaction, otherT.Interaction)) return false;
                if( !DeepComparable.IsExactly(Organism, otherT.Organism)) return false;
                if( !DeepComparable.IsExactly(OrganismType, otherT.OrganismType)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if( !DeepComparable.IsExactly(AmountType, otherT.AmountType)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Target != null) yield return Target;
                    if (Type != null) yield return Type;
                    if (Interaction != null) yield return Interaction;
                    if (Organism != null) yield return Organism;
                    if (OrganismType != null) yield return OrganismType;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                    if (Amount != null) yield return Amount;
                    if (AmountType != null) yield return AmountType;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Target != null) yield return new ElementValue("target", false, Target);
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Interaction != null) yield return new ElementValue("interaction", false, Interaction);
                    if (Organism != null) yield return new ElementValue("organism", false, Organism);
                    if (OrganismType != null) yield return new ElementValue("organismType", false, OrganismType);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", true, elem); }
                    if (Amount != null) yield return new ElementValue("amount", false, Amount);
                    if (AmountType != null) yield return new ElementValue("amountType", false, AmountType);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("comment", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CommentElement
        {
            get { return _CommentElement; }
            set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _CommentElement;
        
        /// <summary>
        /// Todo
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
        
        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("gene", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GeneComponent> Gene
        {
            get { if(_Gene==null) _Gene = new List<GeneComponent>(); return _Gene; }
            set { _Gene = value; OnPropertyChanged("Gene"); }
        }
        
        private List<GeneComponent> _Gene;
        
        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("geneElement", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GeneElementComponent> GeneElement
        {
            get { if(_GeneElement==null) _GeneElement = new List<GeneElementComponent>(); return _GeneElement; }
            set { _GeneElement = value; OnPropertyChanged("GeneElement"); }
        }
        
        private List<GeneElementComponent> _GeneElement;
        
        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("classification", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ClassificationComponent> Classification
        {
            get { if(_Classification==null) _Classification = new List<ClassificationComponent>(); return _Classification; }
            set { _Classification = value; OnPropertyChanged("Classification"); }
        }
        
        private List<ClassificationComponent> _Classification;
        
        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("relationship", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelationshipComponent> Relationship
        {
            get { if(_Relationship==null) _Relationship = new List<RelationshipComponent>(); return _Relationship; }
            set { _Relationship = value; OnPropertyChanged("Relationship"); }
        }
        
        private List<RelationshipComponent> _Relationship;
        
        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("target", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TargetComponent> Target
        {
            get { if(_Target==null) _Target = new List<TargetComponent>(); return _Target; }
            set { _Target = value; OnPropertyChanged("Target"); }
        }
        
        private List<TargetComponent> _Target;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SubstanceReferenceInformation;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
                if(Gene != null) dest.Gene = new List<GeneComponent>(Gene.DeepCopy());
                if(GeneElement != null) dest.GeneElement = new List<GeneElementComponent>(GeneElement.DeepCopy());
                if(Classification != null) dest.Classification = new List<ClassificationComponent>(Classification.DeepCopy());
                if(Relationship != null) dest.Relationship = new List<RelationshipComponent>(Relationship.DeepCopy());
                if(Target != null) dest.Target = new List<TargetComponent>(Target.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new SubstanceReferenceInformation());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SubstanceReferenceInformation;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if( !DeepComparable.Matches(Gene, otherT.Gene)) return false;
            if( !DeepComparable.Matches(GeneElement, otherT.GeneElement)) return false;
            if( !DeepComparable.Matches(Classification, otherT.Classification)) return false;
            if( !DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
            if( !DeepComparable.Matches(Target, otherT.Target)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SubstanceReferenceInformation;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if( !DeepComparable.IsExactly(Gene, otherT.Gene)) return false;
            if( !DeepComparable.IsExactly(GeneElement, otherT.GeneElement)) return false;
            if( !DeepComparable.IsExactly(Classification, otherT.Classification)) return false;
            if( !DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
            if( !DeepComparable.IsExactly(Target, otherT.Target)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (CommentElement != null) yield return CommentElement;
                foreach (var elem in Gene) { if (elem != null) yield return elem; }
                foreach (var elem in GeneElement) { if (elem != null) yield return elem; }
                foreach (var elem in Classification) { if (elem != null) yield return elem; }
                foreach (var elem in Relationship) { if (elem != null) yield return elem; }
                foreach (var elem in Target) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (CommentElement != null) yield return new ElementValue("comment", false, CommentElement);
                foreach (var elem in Gene) { if (elem != null) yield return new ElementValue("gene", true, elem); }
                foreach (var elem in GeneElement) { if (elem != null) yield return new ElementValue("geneElement", true, elem); }
                foreach (var elem in Classification) { if (elem != null) yield return new ElementValue("classification", true, elem); }
                foreach (var elem in Relationship) { if (elem != null) yield return new ElementValue("relationship", true, elem); }
                foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", true, elem); }
            }
        }
    
    }

}
