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
    /// Legal Agreement
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.STU3, "Contract", IsResource=true)]
    [DataContract]
    public partial class Contract : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Contract; } }
        [NotMapped]
        public override string TypeName { get { return "Contract"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "AgentComponent")]
        [DataContract]
        public partial class AgentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AgentComponent"; } }
            
            /// <summary>
            /// Contract Agent Type
            /// </summary>
            [FhirElement("actor", Order=40)]
            [CLSCompliant(false)]
            [References("Contract","Device","Group","Location","Organization","Patient","Practitioner","RelatedPerson","Substance")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.ResourceReference Actor
            {
                get { return _Actor; }
                set { _Actor = value; OnPropertyChanged("Actor"); }
            }
            
            private Hl7.Fhir.Model.STU3.ResourceReference _Actor;
            
            /// <summary>
            /// Role type of the agent
            /// </summary>
            [FhirElement("role", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Role
            {
                get { if(_Role==null) _Role = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Role;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AgentComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Actor != null) dest.Actor = (Hl7.Fhir.Model.STU3.ResourceReference)Actor.DeepCopy();
                    if(Role != null) dest.Role = new List<Hl7.Fhir.Model.CodeableConcept>(Role.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AgentComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Actor != null) yield return Actor;
                    foreach (var elem in Role) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Actor != null) yield return new ElementValue("actor", false, Actor);
                    foreach (var elem in Role) { if (elem != null) yield return new ElementValue("role", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "SignatoryComponent")]
        [DataContract]
        public partial class SignatoryComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SignatoryComponent"; } }
            
            /// <summary>
            /// Contract Signatory Role
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.Coding _Type;
            
            /// <summary>
            /// Contract Signatory Party
            /// </summary>
            [FhirElement("party", Order=50)]
            [CLSCompliant(false)]
            [References("Organization","Patient","Practitioner","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.ResourceReference Party
            {
                get { return _Party; }
                set { _Party = value; OnPropertyChanged("Party"); }
            }
            
            private Hl7.Fhir.Model.STU3.ResourceReference _Party;
            
            /// <summary>
            /// Contract Documentation Signature
            /// </summary>
            [FhirElement("signature", Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.STU3.Signature> Signature
            {
                get { if(_Signature==null) _Signature = new List<Hl7.Fhir.Model.STU3.Signature>(); return _Signature; }
                set { _Signature = value; OnPropertyChanged("Signature"); }
            }
            
            private List<Hl7.Fhir.Model.STU3.Signature> _Signature;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SignatoryComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.Coding)Type.DeepCopy();
                    if(Party != null) dest.Party = (Hl7.Fhir.Model.STU3.ResourceReference)Party.DeepCopy();
                    if(Signature != null) dest.Signature = new List<Hl7.Fhir.Model.STU3.Signature>(Signature.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SignatoryComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SignatoryComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Party, otherT.Party)) return false;
                if( !DeepComparable.Matches(Signature, otherT.Signature)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SignatoryComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Party, otherT.Party)) return false;
                if( !DeepComparable.IsExactly(Signature, otherT.Signature)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Party != null) yield return Party;
                    foreach (var elem in Signature) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Party != null) yield return new ElementValue("party", false, Party);
                    foreach (var elem in Signature) { if (elem != null) yield return new ElementValue("signature", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "ValuedItemComponent")]
        [DataContract]
        public partial class ValuedItemComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ValuedItemComponent"; } }
            
            /// <summary>
            /// Contract Valued Item Type
            /// </summary>
            [FhirElement("entity", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.STU3.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Entity
            {
                get { return _Entity; }
                set { _Entity = value; OnPropertyChanged("Entity"); }
            }
            
            private Hl7.Fhir.Model.Element _Entity;
            
            /// <summary>
            /// Contract Valued Item Number
            /// </summary>
            [FhirElement("identifier", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.STU3.Identifier _Identifier;
            
            /// <summary>
            /// Contract Valued Item Effective Tiem
            /// </summary>
            [FhirElement("effectiveTime", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime EffectiveTimeElement
            {
                get { return _EffectiveTimeElement; }
                set { _EffectiveTimeElement = value; OnPropertyChanged("EffectiveTimeElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _EffectiveTimeElement;
            
            /// <summary>
            /// Contract Valued Item Effective Tiem
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string EffectiveTime
            {
                get { return EffectiveTimeElement != null ? EffectiveTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        EffectiveTimeElement = null;
                    else
                        EffectiveTimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("EffectiveTime");
                }
            }
            
            /// <summary>
            /// Count of Contract Valued Items
            /// </summary>
            [FhirElement("quantity", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Contract Valued Item fee, charge, or cost
            /// </summary>
            [FhirElement("unitPrice", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.Money UnitPrice
            {
                get { return _UnitPrice; }
                set { _UnitPrice = value; OnPropertyChanged("UnitPrice"); }
            }
            
            private Hl7.Fhir.Model.Money _UnitPrice;
            
            /// <summary>
            /// Contract Valued Item Price Scaling Factor
            /// </summary>
            [FhirElement("factor", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDecimal FactorElement
            {
                get { return _FactorElement; }
                set { _FactorElement = value; OnPropertyChanged("FactorElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDecimal _FactorElement;
            
            /// <summary>
            /// Contract Valued Item Price Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new Hl7.Fhir.Model.FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }
            
            /// <summary>
            /// Contract Valued Item Difficulty Scaling Factor
            /// </summary>
            [FhirElement("points", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDecimal PointsElement
            {
                get { return _PointsElement; }
                set { _PointsElement = value; OnPropertyChanged("PointsElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDecimal _PointsElement;
            
            /// <summary>
            /// Contract Valued Item Difficulty Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Points
            {
                get { return PointsElement != null ? PointsElement.Value : null; }
                set
                {
                    if (value == null)
                        PointsElement = null;
                    else
                        PointsElement = new Hl7.Fhir.Model.FhirDecimal(value);
                    OnPropertyChanged("Points");
                }
            }
            
            /// <summary>
            /// Total Contract Valued Item Value
            /// </summary>
            [FhirElement("net", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.Money Net
            {
                get { return _Net; }
                set { _Net = value; OnPropertyChanged("Net"); }
            }
            
            private Hl7.Fhir.Model.Money _Net;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ValuedItemComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Entity != null) dest.Entity = (Hl7.Fhir.Model.Element)Entity.DeepCopy();
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.STU3.Identifier)Identifier.DeepCopy();
                    if(EffectiveTimeElement != null) dest.EffectiveTimeElement = (Hl7.Fhir.Model.FhirDateTime)EffectiveTimeElement.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.SimpleQuantity)Quantity.DeepCopy();
                    if(UnitPrice != null) dest.UnitPrice = (Hl7.Fhir.Model.Money)UnitPrice.DeepCopy();
                    if(FactorElement != null) dest.FactorElement = (Hl7.Fhir.Model.FhirDecimal)FactorElement.DeepCopy();
                    if(PointsElement != null) dest.PointsElement = (Hl7.Fhir.Model.FhirDecimal)PointsElement.DeepCopy();
                    if(Net != null) dest.Net = (Hl7.Fhir.Model.Money)Net.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ValuedItemComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ValuedItemComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Entity, otherT.Entity)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.Matches(PointsElement, otherT.PointsElement)) return false;
                if( !DeepComparable.Matches(Net, otherT.Net)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ValuedItemComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.IsExactly(PointsElement, otherT.PointsElement)) return false;
                if( !DeepComparable.IsExactly(Net, otherT.Net)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Entity != null) yield return Entity;
                    if (Identifier != null) yield return Identifier;
                    if (EffectiveTimeElement != null) yield return EffectiveTimeElement;
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (PointsElement != null) yield return PointsElement;
                    if (Net != null) yield return Net;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Entity != null) yield return new ElementValue("entity", false, Entity);
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                    if (EffectiveTimeElement != null) yield return new ElementValue("effectiveTime", false, EffectiveTimeElement);
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", false, UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", false, FactorElement);
                    if (PointsElement != null) yield return new ElementValue("points", false, PointsElement);
                    if (Net != null) yield return new ElementValue("net", false, Net);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "TermComponent")]
        [DataContract]
        public partial class TermComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TermComponent"; } }
            
            /// <summary>
            /// Contract Term Number
            /// </summary>
            [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.STU3.Identifier _Identifier;
            
            /// <summary>
            /// Contract Term Issue Date Time
            /// </summary>
            [FhirElement("issued", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime IssuedElement
            {
                get { return _IssuedElement; }
                set { _IssuedElement = value; OnPropertyChanged("IssuedElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _IssuedElement;
            
            /// <summary>
            /// Contract Term Issue Date Time
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Issued
            {
                get { return IssuedElement != null ? IssuedElement.Value : null; }
                set
                {
                    if (value == null)
                        IssuedElement = null;
                    else
                        IssuedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("Issued");
                }
            }
            
            /// <summary>
            /// Contract Term Effective Time
            /// </summary>
            [FhirElement("applies", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.Period Applies
            {
                get { return _Applies; }
                set { _Applies = value; OnPropertyChanged("Applies"); }
            }
            
            private Hl7.Fhir.Model.Period _Applies;
            
            /// <summary>
            /// Contract Term Type or Form
            /// </summary>
            [FhirElement("type", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Contract Term Type specific classification
            /// </summary>
            [FhirElement("subType", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept SubType
            {
                get { return _SubType; }
                set { _SubType = value; OnPropertyChanged("SubType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _SubType;
            
            /// <summary>
            /// Context of the Contract term
            /// </summary>
            [FhirElement("topic", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.STU3.ResourceReference> Topic
            {
                get { if(_Topic==null) _Topic = new List<Hl7.Fhir.Model.STU3.ResourceReference>(); return _Topic; }
                set { _Topic = value; OnPropertyChanged("Topic"); }
            }
            
            private List<Hl7.Fhir.Model.STU3.ResourceReference> _Topic;
            
            /// <summary>
            /// Contract Term Activity
            /// </summary>
            [FhirElement("action", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Action
            {
                get { if(_Action==null) _Action = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Action; }
                set { _Action = value; OnPropertyChanged("Action"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Action;
            
            /// <summary>
            /// Purpose for the Contract Term Action
            /// </summary>
            [FhirElement("actionReason", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> ActionReason
            {
                get { if(_ActionReason==null) _ActionReason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ActionReason; }
                set { _ActionReason = value; OnPropertyChanged("ActionReason"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _ActionReason;
            
            /// <summary>
            /// Security Labels that define affected terms
            /// </summary>
            [FhirElement("securityLabel", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.Coding> SecurityLabel
            {
                get { if(_SecurityLabel==null) _SecurityLabel = new List<Hl7.Fhir.Model.Coding>(); return _SecurityLabel; }
                set { _SecurityLabel = value; OnPropertyChanged("SecurityLabel"); }
            }
            
            private List<Hl7.Fhir.Model.Coding> _SecurityLabel;
            
            /// <summary>
            /// Contract Term Agent List
            /// </summary>
            [FhirElement("agent", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TermAgentComponent> Agent
            {
                get { if(_Agent==null) _Agent = new List<TermAgentComponent>(); return _Agent; }
                set { _Agent = value; OnPropertyChanged("Agent"); }
            }
            
            private List<TermAgentComponent> _Agent;
            
            /// <summary>
            /// Human readable Contract term text
            /// </summary>
            [FhirElement("text", Order=140)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TextElement
            {
                get { return _TextElement; }
                set { _TextElement = value; OnPropertyChanged("TextElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _TextElement;
            
            /// <summary>
            /// Human readable Contract term text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Text");
                }
            }
            
            /// <summary>
            /// Contract Term Valued Item List
            /// </summary>
            [FhirElement("valuedItem", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TermValuedItemComponent> ValuedItem
            {
                get { if(_ValuedItem==null) _ValuedItem = new List<TermValuedItemComponent>(); return _ValuedItem; }
                set { _ValuedItem = value; OnPropertyChanged("ValuedItem"); }
            }
            
            private List<TermValuedItemComponent> _ValuedItem;
            
            /// <summary>
            /// Nested Contract Term Group
            /// </summary>
            [FhirElement("group", Order=160)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TermComponent> Group
            {
                get { if(_Group==null) _Group = new List<TermComponent>(); return _Group; }
                set { _Group = value; OnPropertyChanged("Group"); }
            }
            
            private List<TermComponent> _Group;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TermComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.STU3.Identifier)Identifier.DeepCopy();
                    if(IssuedElement != null) dest.IssuedElement = (Hl7.Fhir.Model.FhirDateTime)IssuedElement.DeepCopy();
                    if(Applies != null) dest.Applies = (Hl7.Fhir.Model.Period)Applies.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(SubType != null) dest.SubType = (Hl7.Fhir.Model.CodeableConcept)SubType.DeepCopy();
                    if(Topic != null) dest.Topic = new List<Hl7.Fhir.Model.STU3.ResourceReference>(Topic.DeepCopy());
                    if(Action != null) dest.Action = new List<Hl7.Fhir.Model.CodeableConcept>(Action.DeepCopy());
                    if(ActionReason != null) dest.ActionReason = new List<Hl7.Fhir.Model.CodeableConcept>(ActionReason.DeepCopy());
                    if(SecurityLabel != null) dest.SecurityLabel = new List<Hl7.Fhir.Model.Coding>(SecurityLabel.DeepCopy());
                    if(Agent != null) dest.Agent = new List<TermAgentComponent>(Agent.DeepCopy());
                    if(TextElement != null) dest.TextElement = (Hl7.Fhir.Model.FhirString)TextElement.DeepCopy();
                    if(ValuedItem != null) dest.ValuedItem = new List<TermValuedItemComponent>(ValuedItem.DeepCopy());
                    if(Group != null) dest.Group = new List<TermComponent>(Group.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TermComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TermComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
                if( !DeepComparable.Matches(Applies, otherT.Applies)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(SubType, otherT.SubType)) return false;
                if( !DeepComparable.Matches(Topic, otherT.Topic)) return false;
                if( !DeepComparable.Matches(Action, otherT.Action)) return false;
                if( !DeepComparable.Matches(ActionReason, otherT.ActionReason)) return false;
                if( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
                if( !DeepComparable.Matches(Agent, otherT.Agent)) return false;
                if( !DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if( !DeepComparable.Matches(ValuedItem, otherT.ValuedItem)) return false;
                if( !DeepComparable.Matches(Group, otherT.Group)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TermComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
                if( !DeepComparable.IsExactly(Applies, otherT.Applies)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
                if( !DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
                if( !DeepComparable.IsExactly(Action, otherT.Action)) return false;
                if( !DeepComparable.IsExactly(ActionReason, otherT.ActionReason)) return false;
                if( !DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
                if( !DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
                if( !DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if( !DeepComparable.IsExactly(ValuedItem, otherT.ValuedItem)) return false;
                if( !DeepComparable.IsExactly(Group, otherT.Group)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (IssuedElement != null) yield return IssuedElement;
                    if (Applies != null) yield return Applies;
                    if (Type != null) yield return Type;
                    if (SubType != null) yield return SubType;
                    foreach (var elem in Topic) { if (elem != null) yield return elem; }
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                    foreach (var elem in ActionReason) { if (elem != null) yield return elem; }
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
                    foreach (var elem in Agent) { if (elem != null) yield return elem; }
                    if (TextElement != null) yield return TextElement;
                    foreach (var elem in ValuedItem) { if (elem != null) yield return elem; }
                    foreach (var elem in Group) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                    if (IssuedElement != null) yield return new ElementValue("issued", false, IssuedElement);
                    if (Applies != null) yield return new ElementValue("applies", false, Applies);
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (SubType != null) yield return new ElementValue("subType", false, SubType);
                    foreach (var elem in Topic) { if (elem != null) yield return new ElementValue("topic", true, elem); }
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", true, elem); }
                    foreach (var elem in ActionReason) { if (elem != null) yield return new ElementValue("actionReason", true, elem); }
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", true, elem); }
                    foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", true, elem); }
                    if (TextElement != null) yield return new ElementValue("text", false, TextElement);
                    foreach (var elem in ValuedItem) { if (elem != null) yield return new ElementValue("valuedItem", true, elem); }
                    foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "TermAgentComponent")]
        [DataContract]
        public partial class TermAgentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TermAgentComponent"; } }
            
            /// <summary>
            /// Contract Term Agent Subject
            /// </summary>
            [FhirElement("actor", Order=40)]
            [CLSCompliant(false)]
            [References("Contract","Device","Group","Location","Organization","Patient","Practitioner","RelatedPerson","Substance")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.ResourceReference Actor
            {
                get { return _Actor; }
                set { _Actor = value; OnPropertyChanged("Actor"); }
            }
            
            private Hl7.Fhir.Model.STU3.ResourceReference _Actor;
            
            /// <summary>
            /// Type of the Contract Term Agent
            /// </summary>
            [FhirElement("role", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Role
            {
                get { if(_Role==null) _Role = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Role;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TermAgentComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Actor != null) dest.Actor = (Hl7.Fhir.Model.STU3.ResourceReference)Actor.DeepCopy();
                    if(Role != null) dest.Role = new List<Hl7.Fhir.Model.CodeableConcept>(Role.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TermAgentComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TermAgentComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TermAgentComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Actor != null) yield return Actor;
                    foreach (var elem in Role) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Actor != null) yield return new ElementValue("actor", false, Actor);
                    foreach (var elem in Role) { if (elem != null) yield return new ElementValue("role", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "TermValuedItemComponent")]
        [DataContract]
        public partial class TermValuedItemComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TermValuedItemComponent"; } }
            
            /// <summary>
            /// Contract Term Valued Item Type
            /// </summary>
            [FhirElement("entity", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.STU3.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Entity
            {
                get { return _Entity; }
                set { _Entity = value; OnPropertyChanged("Entity"); }
            }
            
            private Hl7.Fhir.Model.Element _Entity;
            
            /// <summary>
            /// Contract Term Valued Item Number
            /// </summary>
            [FhirElement("identifier", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.STU3.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.STU3.Identifier _Identifier;
            
            /// <summary>
            /// Contract Term Valued Item Effective Tiem
            /// </summary>
            [FhirElement("effectiveTime", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime EffectiveTimeElement
            {
                get { return _EffectiveTimeElement; }
                set { _EffectiveTimeElement = value; OnPropertyChanged("EffectiveTimeElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _EffectiveTimeElement;
            
            /// <summary>
            /// Contract Term Valued Item Effective Tiem
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string EffectiveTime
            {
                get { return EffectiveTimeElement != null ? EffectiveTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        EffectiveTimeElement = null;
                    else
                        EffectiveTimeElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("EffectiveTime");
                }
            }
            
            /// <summary>
            /// Contract Term Valued Item Count
            /// </summary>
            [FhirElement("quantity", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Contract Term Valued Item fee, charge, or cost
            /// </summary>
            [FhirElement("unitPrice", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.Money UnitPrice
            {
                get { return _UnitPrice; }
                set { _UnitPrice = value; OnPropertyChanged("UnitPrice"); }
            }
            
            private Hl7.Fhir.Model.Money _UnitPrice;
            
            /// <summary>
            /// Contract Term Valued Item Price Scaling Factor
            /// </summary>
            [FhirElement("factor", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDecimal FactorElement
            {
                get { return _FactorElement; }
                set { _FactorElement = value; OnPropertyChanged("FactorElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDecimal _FactorElement;
            
            /// <summary>
            /// Contract Term Valued Item Price Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new Hl7.Fhir.Model.FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }
            
            /// <summary>
            /// Contract Term Valued Item Difficulty Scaling Factor
            /// </summary>
            [FhirElement("points", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDecimal PointsElement
            {
                get { return _PointsElement; }
                set { _PointsElement = value; OnPropertyChanged("PointsElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDecimal _PointsElement;
            
            /// <summary>
            /// Contract Term Valued Item Difficulty Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Points
            {
                get { return PointsElement != null ? PointsElement.Value : null; }
                set
                {
                    if (value == null)
                        PointsElement = null;
                    else
                        PointsElement = new Hl7.Fhir.Model.FhirDecimal(value);
                    OnPropertyChanged("Points");
                }
            }
            
            /// <summary>
            /// Total Contract Term Valued Item Value
            /// </summary>
            [FhirElement("net", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.Money Net
            {
                get { return _Net; }
                set { _Net = value; OnPropertyChanged("Net"); }
            }
            
            private Hl7.Fhir.Model.Money _Net;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TermValuedItemComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Entity != null) dest.Entity = (Hl7.Fhir.Model.Element)Entity.DeepCopy();
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.STU3.Identifier)Identifier.DeepCopy();
                    if(EffectiveTimeElement != null) dest.EffectiveTimeElement = (Hl7.Fhir.Model.FhirDateTime)EffectiveTimeElement.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.SimpleQuantity)Quantity.DeepCopy();
                    if(UnitPrice != null) dest.UnitPrice = (Hl7.Fhir.Model.Money)UnitPrice.DeepCopy();
                    if(FactorElement != null) dest.FactorElement = (Hl7.Fhir.Model.FhirDecimal)FactorElement.DeepCopy();
                    if(PointsElement != null) dest.PointsElement = (Hl7.Fhir.Model.FhirDecimal)PointsElement.DeepCopy();
                    if(Net != null) dest.Net = (Hl7.Fhir.Model.Money)Net.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TermValuedItemComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TermValuedItemComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Entity, otherT.Entity)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.Matches(PointsElement, otherT.PointsElement)) return false;
                if( !DeepComparable.Matches(Net, otherT.Net)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TermValuedItemComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.IsExactly(PointsElement, otherT.PointsElement)) return false;
                if( !DeepComparable.IsExactly(Net, otherT.Net)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Entity != null) yield return Entity;
                    if (Identifier != null) yield return Identifier;
                    if (EffectiveTimeElement != null) yield return EffectiveTimeElement;
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (PointsElement != null) yield return PointsElement;
                    if (Net != null) yield return Net;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Entity != null) yield return new ElementValue("entity", false, Entity);
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                    if (EffectiveTimeElement != null) yield return new ElementValue("effectiveTime", false, EffectiveTimeElement);
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", false, UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", false, FactorElement);
                    if (PointsElement != null) yield return new ElementValue("points", false, PointsElement);
                    if (Net != null) yield return new ElementValue("net", false, Net);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "FriendlyLanguageComponent")]
        [DataContract]
        public partial class FriendlyLanguageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "FriendlyLanguageComponent"; } }
            
            /// <summary>
            /// Easily comprehended representation of this Contract
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Attachment),typeof(Hl7.Fhir.Model.STU3.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Content
            {
                get { return _Content; }
                set { _Content = value; OnPropertyChanged("Content"); }
            }
            
            private Hl7.Fhir.Model.Element _Content;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FriendlyLanguageComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Content != null) dest.Content = (Hl7.Fhir.Model.Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FriendlyLanguageComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FriendlyLanguageComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Content, otherT.Content)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FriendlyLanguageComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Content, otherT.Content)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", false, Content);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "LegalLanguageComponent")]
        [DataContract]
        public partial class LegalLanguageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "LegalLanguageComponent"; } }
            
            /// <summary>
            /// Contract Legal Text
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Attachment),typeof(Hl7.Fhir.Model.STU3.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Content
            {
                get { return _Content; }
                set { _Content = value; OnPropertyChanged("Content"); }
            }
            
            private Hl7.Fhir.Model.Element _Content;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LegalLanguageComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Content != null) dest.Content = (Hl7.Fhir.Model.Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LegalLanguageComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LegalLanguageComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Content, otherT.Content)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LegalLanguageComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Content, otherT.Content)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", false, Content);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "ComputableLanguageComponent")]
        [DataContract]
        public partial class ComputableLanguageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ComputableLanguageComponent"; } }
            
            /// <summary>
            /// Computable Contract Rules
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Attachment),typeof(Hl7.Fhir.Model.STU3.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Content
            {
                get { return _Content; }
                set { _Content = value; OnPropertyChanged("Content"); }
            }
            
            private Hl7.Fhir.Model.Element _Content;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ComputableLanguageComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Content != null) dest.Content = (Hl7.Fhir.Model.Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ComputableLanguageComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ComputableLanguageComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Content, otherT.Content)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ComputableLanguageComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Content, otherT.Content)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", false, Content);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Contract number
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.STU3.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.STU3.Identifier _Identifier;
        
        /// <summary>
        /// amended | appended | cancelled | disputed | entered-in-error | executable | executed | negotiable | offered | policy | rejected | renewed | revoked | resolved | terminated
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Code<Hl7.Fhir.Model.STU3.ContractResourceStatusCodes> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.STU3.ContractResourceStatusCodes> _StatusElement;
        
        /// <summary>
        /// amended | appended | cancelled | disputed | entered-in-error | executable | executed | negotiable | offered | policy | rejected | renewed | revoked | resolved | terminated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.STU3.ContractResourceStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<Hl7.Fhir.Model.STU3.ContractResourceStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// When this Contract was issued
        /// </summary>
        [FhirElement("issued", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime IssuedElement
        {
            get { return _IssuedElement; }
            set { _IssuedElement = value; OnPropertyChanged("IssuedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _IssuedElement;
        
        /// <summary>
        /// When this Contract was issued
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Issued
        {
            get { return IssuedElement != null ? IssuedElement.Value : null; }
            set
            {
                if (value == null)
                    IssuedElement = null;
                else
                    IssuedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Issued");
            }
        }
        
        /// <summary>
        /// Effective time
        /// </summary>
        [FhirElement("applies", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.Period Applies
        {
            get { return _Applies; }
            set { _Applies = value; OnPropertyChanged("Applies"); }
        }
        
        private Hl7.Fhir.Model.Period _Applies;
        
        /// <summary>
        /// Contract Target Entity
        /// </summary>
        [FhirElement("subject", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.ResourceReference> Subject
        {
            get { if(_Subject==null) _Subject = new List<Hl7.Fhir.Model.STU3.ResourceReference>(); return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.ResourceReference> _Subject;
        
        /// <summary>
        /// Context of the Contract
        /// </summary>
        [FhirElement("topic", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.ResourceReference> Topic
        {
            get { if(_Topic==null) _Topic = new List<Hl7.Fhir.Model.STU3.ResourceReference>(); return _Topic; }
            set { _Topic = value; OnPropertyChanged("Topic"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.ResourceReference> _Topic;
        
        /// <summary>
        /// Authority under which this Contract has standing
        /// </summary>
        [FhirElement("authority", Order=150)]
        [CLSCompliant(false)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.ResourceReference> Authority
        {
            get { if(_Authority==null) _Authority = new List<Hl7.Fhir.Model.STU3.ResourceReference>(); return _Authority; }
            set { _Authority = value; OnPropertyChanged("Authority"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.ResourceReference> _Authority;
        
        /// <summary>
        /// Domain in which this Contract applies
        /// </summary>
        [FhirElement("domain", Order=160)]
        [CLSCompliant(false)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.STU3.ResourceReference> Domain
        {
            get { if(_Domain==null) _Domain = new List<Hl7.Fhir.Model.STU3.ResourceReference>(); return _Domain; }
            set { _Domain = value; OnPropertyChanged("Domain"); }
        }
        
        private List<Hl7.Fhir.Model.STU3.ResourceReference> _Domain;
        
        /// <summary>
        /// Type or form
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// Subtype within the context of type
        /// </summary>
        [FhirElement("subType", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> SubType
        {
            get { if(_SubType==null) _SubType = new List<Hl7.Fhir.Model.CodeableConcept>(); return _SubType; }
            set { _SubType = value; OnPropertyChanged("SubType"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _SubType;
        
        /// <summary>
        /// Action stipulated by this Contract
        /// </summary>
        [FhirElement("action", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Action
        {
            get { if(_Action==null) _Action = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Action; }
            set { _Action = value; OnPropertyChanged("Action"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Action;
        
        /// <summary>
        /// Rationale for the stiplulated action
        /// </summary>
        [FhirElement("actionReason", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> ActionReason
        {
            get { if(_ActionReason==null) _ActionReason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ActionReason; }
            set { _ActionReason = value; OnPropertyChanged("ActionReason"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _ActionReason;
        
        /// <summary>
        /// Decision by Grantor
        /// </summary>
        [FhirElement("decisionType", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept DecisionType
        {
            get { return _DecisionType; }
            set { _DecisionType = value; OnPropertyChanged("DecisionType"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _DecisionType;
        
        /// <summary>
        /// Content derived from the basal information
        /// </summary>
        [FhirElement("contentDerivative", Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept ContentDerivative
        {
            get { return _ContentDerivative; }
            set { _ContentDerivative = value; OnPropertyChanged("ContentDerivative"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _ContentDerivative;
        
        /// <summary>
        /// Security Labels that define affected resources
        /// </summary>
        [FhirElement("securityLabel", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Coding> SecurityLabel
        {
            get { if(_SecurityLabel==null) _SecurityLabel = new List<Hl7.Fhir.Model.Coding>(); return _SecurityLabel; }
            set { _SecurityLabel = value; OnPropertyChanged("SecurityLabel"); }
        }
        
        private List<Hl7.Fhir.Model.Coding> _SecurityLabel;
        
        /// <summary>
        /// Entity being ascribed responsibility
        /// </summary>
        [FhirElement("agent", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AgentComponent> Agent
        {
            get { if(_Agent==null) _Agent = new List<AgentComponent>(); return _Agent; }
            set { _Agent = value; OnPropertyChanged("Agent"); }
        }
        
        private List<AgentComponent> _Agent;
        
        /// <summary>
        /// Contract Signatory
        /// </summary>
        [FhirElement("signer", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SignatoryComponent> Signer
        {
            get { if(_Signer==null) _Signer = new List<SignatoryComponent>(); return _Signer; }
            set { _Signer = value; OnPropertyChanged("Signer"); }
        }
        
        private List<SignatoryComponent> _Signer;
        
        /// <summary>
        /// Contract Valued Item List
        /// </summary>
        [FhirElement("valuedItem", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ValuedItemComponent> ValuedItem
        {
            get { if(_ValuedItem==null) _ValuedItem = new List<ValuedItemComponent>(); return _ValuedItem; }
            set { _ValuedItem = value; OnPropertyChanged("ValuedItem"); }
        }
        
        private List<ValuedItemComponent> _ValuedItem;
        
        /// <summary>
        /// Contract Term List
        /// </summary>
        [FhirElement("term", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TermComponent> Term
        {
            get { if(_Term==null) _Term = new List<TermComponent>(); return _Term; }
            set { _Term = value; OnPropertyChanged("Term"); }
        }
        
        private List<TermComponent> _Term;
        
        /// <summary>
        /// Binding Contract
        /// </summary>
        [FhirElement("binding", Order=280, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.Attachment),typeof(Hl7.Fhir.Model.STU3.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element Binding
        {
            get { return _Binding; }
            set { _Binding = value; OnPropertyChanged("Binding"); }
        }
        
        private Hl7.Fhir.Model.Element _Binding;
        
        /// <summary>
        /// Contract Friendly Language
        /// </summary>
        [FhirElement("friendly", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FriendlyLanguageComponent> Friendly
        {
            get { if(_Friendly==null) _Friendly = new List<FriendlyLanguageComponent>(); return _Friendly; }
            set { _Friendly = value; OnPropertyChanged("Friendly"); }
        }
        
        private List<FriendlyLanguageComponent> _Friendly;
        
        /// <summary>
        /// Contract Legal Language
        /// </summary>
        [FhirElement("legal", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LegalLanguageComponent> Legal
        {
            get { if(_Legal==null) _Legal = new List<LegalLanguageComponent>(); return _Legal; }
            set { _Legal = value; OnPropertyChanged("Legal"); }
        }
        
        private List<LegalLanguageComponent> _Legal;
        
        /// <summary>
        /// Computable Contract Language
        /// </summary>
        [FhirElement("rule", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ComputableLanguageComponent> Rule
        {
            get { if(_Rule==null) _Rule = new List<ComputableLanguageComponent>(); return _Rule; }
            set { _Rule = value; OnPropertyChanged("Rule"); }
        }
        
        private List<ComputableLanguageComponent> _Rule;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Contract;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.STU3.Identifier)Identifier.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.STU3.ContractResourceStatusCodes>)StatusElement.DeepCopy();
                if(IssuedElement != null) dest.IssuedElement = (Hl7.Fhir.Model.FhirDateTime)IssuedElement.DeepCopy();
                if(Applies != null) dest.Applies = (Hl7.Fhir.Model.Period)Applies.DeepCopy();
                if(Subject != null) dest.Subject = new List<Hl7.Fhir.Model.STU3.ResourceReference>(Subject.DeepCopy());
                if(Topic != null) dest.Topic = new List<Hl7.Fhir.Model.STU3.ResourceReference>(Topic.DeepCopy());
                if(Authority != null) dest.Authority = new List<Hl7.Fhir.Model.STU3.ResourceReference>(Authority.DeepCopy());
                if(Domain != null) dest.Domain = new List<Hl7.Fhir.Model.STU3.ResourceReference>(Domain.DeepCopy());
                if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                if(SubType != null) dest.SubType = new List<Hl7.Fhir.Model.CodeableConcept>(SubType.DeepCopy());
                if(Action != null) dest.Action = new List<Hl7.Fhir.Model.CodeableConcept>(Action.DeepCopy());
                if(ActionReason != null) dest.ActionReason = new List<Hl7.Fhir.Model.CodeableConcept>(ActionReason.DeepCopy());
                if(DecisionType != null) dest.DecisionType = (Hl7.Fhir.Model.CodeableConcept)DecisionType.DeepCopy();
                if(ContentDerivative != null) dest.ContentDerivative = (Hl7.Fhir.Model.CodeableConcept)ContentDerivative.DeepCopy();
                if(SecurityLabel != null) dest.SecurityLabel = new List<Hl7.Fhir.Model.Coding>(SecurityLabel.DeepCopy());
                if(Agent != null) dest.Agent = new List<AgentComponent>(Agent.DeepCopy());
                if(Signer != null) dest.Signer = new List<SignatoryComponent>(Signer.DeepCopy());
                if(ValuedItem != null) dest.ValuedItem = new List<ValuedItemComponent>(ValuedItem.DeepCopy());
                if(Term != null) dest.Term = new List<TermComponent>(Term.DeepCopy());
                if(Binding != null) dest.Binding = (Hl7.Fhir.Model.Element)Binding.DeepCopy();
                if(Friendly != null) dest.Friendly = new List<FriendlyLanguageComponent>(Friendly.DeepCopy());
                if(Legal != null) dest.Legal = new List<LegalLanguageComponent>(Legal.DeepCopy());
                if(Rule != null) dest.Rule = new List<ComputableLanguageComponent>(Rule.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Contract());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Contract;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if( !DeepComparable.Matches(Applies, otherT.Applies)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Topic, otherT.Topic)) return false;
            if( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
            if( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(SubType, otherT.SubType)) return false;
            if( !DeepComparable.Matches(Action, otherT.Action)) return false;
            if( !DeepComparable.Matches(ActionReason, otherT.ActionReason)) return false;
            if( !DeepComparable.Matches(DecisionType, otherT.DecisionType)) return false;
            if( !DeepComparable.Matches(ContentDerivative, otherT.ContentDerivative)) return false;
            if( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
            if( !DeepComparable.Matches(Agent, otherT.Agent)) return false;
            if( !DeepComparable.Matches(Signer, otherT.Signer)) return false;
            if( !DeepComparable.Matches(ValuedItem, otherT.ValuedItem)) return false;
            if( !DeepComparable.Matches(Term, otherT.Term)) return false;
            if( !DeepComparable.Matches(Binding, otherT.Binding)) return false;
            if( !DeepComparable.Matches(Friendly, otherT.Friendly)) return false;
            if( !DeepComparable.Matches(Legal, otherT.Legal)) return false;
            if( !DeepComparable.Matches(Rule, otherT.Rule)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Contract;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if( !DeepComparable.IsExactly(Applies, otherT.Applies)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
            if( !DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
            if( !DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
            if( !DeepComparable.IsExactly(Action, otherT.Action)) return false;
            if( !DeepComparable.IsExactly(ActionReason, otherT.ActionReason)) return false;
            if( !DeepComparable.IsExactly(DecisionType, otherT.DecisionType)) return false;
            if( !DeepComparable.IsExactly(ContentDerivative, otherT.ContentDerivative)) return false;
            if( !DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
            if( !DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
            if( !DeepComparable.IsExactly(Signer, otherT.Signer)) return false;
            if( !DeepComparable.IsExactly(ValuedItem, otherT.ValuedItem)) return false;
            if( !DeepComparable.IsExactly(Term, otherT.Term)) return false;
            if( !DeepComparable.IsExactly(Binding, otherT.Binding)) return false;
            if( !DeepComparable.IsExactly(Friendly, otherT.Friendly)) return false;
            if( !DeepComparable.IsExactly(Legal, otherT.Legal)) return false;
            if( !DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (StatusElement != null) yield return StatusElement;
                if (IssuedElement != null) yield return IssuedElement;
                if (Applies != null) yield return Applies;
                foreach (var elem in Subject) { if (elem != null) yield return elem; }
                foreach (var elem in Topic) { if (elem != null) yield return elem; }
                foreach (var elem in Authority) { if (elem != null) yield return elem; }
                foreach (var elem in Domain) { if (elem != null) yield return elem; }
                if (Type != null) yield return Type;
                foreach (var elem in SubType) { if (elem != null) yield return elem; }
                foreach (var elem in Action) { if (elem != null) yield return elem; }
                foreach (var elem in ActionReason) { if (elem != null) yield return elem; }
                if (DecisionType != null) yield return DecisionType;
                if (ContentDerivative != null) yield return ContentDerivative;
                foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
                foreach (var elem in Agent) { if (elem != null) yield return elem; }
                foreach (var elem in Signer) { if (elem != null) yield return elem; }
                foreach (var elem in ValuedItem) { if (elem != null) yield return elem; }
                foreach (var elem in Term) { if (elem != null) yield return elem; }
                if (Binding != null) yield return Binding;
                foreach (var elem in Friendly) { if (elem != null) yield return elem; }
                foreach (var elem in Legal) { if (elem != null) yield return elem; }
                foreach (var elem in Rule) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (IssuedElement != null) yield return new ElementValue("issued", false, IssuedElement);
                if (Applies != null) yield return new ElementValue("applies", false, Applies);
                foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", true, elem); }
                foreach (var elem in Topic) { if (elem != null) yield return new ElementValue("topic", true, elem); }
                foreach (var elem in Authority) { if (elem != null) yield return new ElementValue("authority", true, elem); }
                foreach (var elem in Domain) { if (elem != null) yield return new ElementValue("domain", true, elem); }
                if (Type != null) yield return new ElementValue("type", false, Type);
                foreach (var elem in SubType) { if (elem != null) yield return new ElementValue("subType", true, elem); }
                foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", true, elem); }
                foreach (var elem in ActionReason) { if (elem != null) yield return new ElementValue("actionReason", true, elem); }
                if (DecisionType != null) yield return new ElementValue("decisionType", false, DecisionType);
                if (ContentDerivative != null) yield return new ElementValue("contentDerivative", false, ContentDerivative);
                foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", true, elem); }
                foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", true, elem); }
                foreach (var elem in Signer) { if (elem != null) yield return new ElementValue("signer", true, elem); }
                foreach (var elem in ValuedItem) { if (elem != null) yield return new ElementValue("valuedItem", true, elem); }
                foreach (var elem in Term) { if (elem != null) yield return new ElementValue("term", true, elem); }
                if (Binding != null) yield return new ElementValue("binding", false, Binding);
                foreach (var elem in Friendly) { if (elem != null) yield return new ElementValue("friendly", true, elem); }
                foreach (var elem in Legal) { if (elem != null) yield return new ElementValue("legal", true, elem); }
                foreach (var elem in Rule) { if (elem != null) yield return new ElementValue("rule", true, elem); }
            }
        }
    
    }

}