﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using Hl7.Fhir.Validation.DSTU2;
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
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
{
    /// <summary>
    /// Contract
    /// </summary>
    [FhirType("Contract", IsResource=true)]
    [DataContract]
    public partial class Contract : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Contract; } }
        [NotMapped]
        public override string TypeName { get { return "Contract"; } }


        [FhirType("ActorComponent")]
        [DataContract]
        public partial class ActorComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActorComponent"; } }

            /// <summary>
            /// Contract Actor Type
            /// </summary>
            [FhirElement("entity", Order=40)]
            [References("Contract","Device","Group","Location","Organization","Patient","Practitioner","RelatedPerson","Substance")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Entity
            {
                get { return _entity; }
                set { _entity = value; OnPropertyChanged("Entity"); }
            }

            private ResourceReference _entity;

            /// <summary>
            /// Contract  Actor Role
            /// </summary>
            [FhirElement("role", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Role
            {
                get { if (_role==null) _role = new List<CodeableConcept>(); return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private List<CodeableConcept> _role;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Entity != null) dest.Entity = (ResourceReference)Entity.DeepCopy();
                    if (Role != null) dest.Role = new List<CodeableConcept>(Role.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActorComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActorComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Entity, otherT.Entity)) return false;
                if ( !DeepComparable.Matches(Role, otherT.Role)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Entity != null) yield return Entity;
                    foreach (var elem in Role) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Entity != null) yield return new ElementValue("entity", Entity);
                    foreach (var elem in Role) { if (elem != null) yield return new ElementValue("role", elem); }
                }
            }


        }


        [FhirType("ValuedItemComponent")]
        [DataContract]
        public partial class ValuedItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ValuedItemComponent"; } }

            /// <summary>
            /// Contract Valued Item Type
            /// </summary>
            [FhirElement("entity", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Entity
            {
                get { return _entity; }
                set { _entity = value; OnPropertyChanged("Entity"); }
            }

            private Element _entity;

            /// <summary>
            /// Contract Valued Item Identifier
            /// </summary>
            [FhirElement("identifier", Order=50)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Contract Valued Item Effective Tiem
            /// </summary>
            [FhirElement("effectiveTime", Order=60)]
            [DataMember]
            public FhirDateTime EffectiveTimeElement
            {
                get { return _effectiveTimeElement; }
                set { _effectiveTimeElement = value; OnPropertyChanged("EffectiveTimeElement"); }
            }

            private FhirDateTime _effectiveTimeElement;

            /// <summary>
            /// Contract Valued Item Effective Tiem
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string EffectiveTime
            {
                get { return EffectiveTimeElement != null ? EffectiveTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        EffectiveTimeElement = null;
                    else
                        EffectiveTimeElement = new FhirDateTime(value);
                    OnPropertyChanged("EffectiveTime");
                }
            }

            /// <summary>
            /// Count of Contract Valued Items
            /// </summary>
            [FhirElement("quantity", Order=70)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Contract Valued Item fee, charge, or cost
            /// </summary>
            [FhirElement("unitPrice", Order=80)]
            [DataMember]
            public Money UnitPrice
            {
                get { return _unitPrice; }
                set { _unitPrice = value; OnPropertyChanged("UnitPrice"); }
            }

            private Money _unitPrice;

            /// <summary>
            /// Contract Valued Item Price Scaling Factor
            /// </summary>
            [FhirElement("factor", Order=90)]
            [DataMember]
            public FhirDecimal FactorElement
            {
                get { return _factorElement; }
                set { _factorElement = value; OnPropertyChanged("FactorElement"); }
            }

            private FhirDecimal _factorElement;

            /// <summary>
            /// Contract Valued Item Price Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Contract Valued Item Difficulty Scaling Factor
            /// </summary>
            [FhirElement("points", Order=100)]
            [DataMember]
            public FhirDecimal PointsElement
            {
                get { return _pointsElement; }
                set { _pointsElement = value; OnPropertyChanged("PointsElement"); }
            }

            private FhirDecimal _pointsElement;

            /// <summary>
            /// Contract Valued Item Difficulty Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Points
            {
                get { return PointsElement != null ? PointsElement.Value : null; }
                set
                {
                    if (value == null)
                        PointsElement = null;
                    else
                        PointsElement = new FhirDecimal(value);
                    OnPropertyChanged("Points");
                }
            }

            /// <summary>
            /// Total Contract Valued Item Value
            /// </summary>
            [FhirElement("net", Order=110)]
            [DataMember]
            public Money Net
            {
                get { return _net; }
                set { _net = value; OnPropertyChanged("Net"); }
            }

            private Money _net;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ValuedItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Entity != null) dest.Entity = (Element)Entity.DeepCopy();
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (EffectiveTimeElement != null) dest.EffectiveTimeElement = (FhirDateTime)EffectiveTimeElement.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (PointsElement != null) dest.PointsElement = (FhirDecimal)PointsElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Entity, otherT.Entity)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ValuedItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;

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
                    if (Entity != null) yield return new ElementValue("entity", Entity);
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (EffectiveTimeElement != null) yield return new ElementValue("effectiveTime", EffectiveTimeElement);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (PointsElement != null) yield return new ElementValue("points", PointsElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                }
            }


        }


        [FhirType("SignatoryComponent")]
        [DataContract]
        public partial class SignatoryComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SignatoryComponent"; } }

            /// <summary>
            /// Contract Signer Type
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Contract Signatory Party
            /// </summary>
            [FhirElement("party", Order=50)]
            [References("Organization","Patient","Practitioner","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Party
            {
                get { return _party; }
                set { _party = value; OnPropertyChanged("Party"); }
            }

            private ResourceReference _party;

            /// <summary>
            /// Contract Documentation Signature
            /// </summary>
            [FhirElement("signature", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString SignatureElement
            {
                get { return _signatureElement; }
                set { _signatureElement = value; OnPropertyChanged("SignatureElement"); }
            }

            private FhirString _signatureElement;

            /// <summary>
            /// Contract Documentation Signature
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Signature
            {
                get { return SignatureElement != null ? SignatureElement.Value : null; }
                set
                {
                    if (value == null)
                        SignatureElement = null;
                    else
                        SignatureElement = new FhirString(value);
                    OnPropertyChanged("Signature");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SignatoryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Party != null) dest.Party = (ResourceReference)Party.DeepCopy();
                    if (SignatureElement != null) dest.SignatureElement = (FhirString)SignatureElement.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Party, otherT.Party)) return false;
                if (!DeepComparable.Matches(SignatureElement, otherT.SignatureElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SignatoryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Party, otherT.Party)) return false;
                if (!DeepComparable.IsExactly(SignatureElement, otherT.SignatureElement)) return false;

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
                    if (SignatureElement != null) yield return SignatureElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Party != null) yield return new ElementValue("party", Party);
                    if (SignatureElement != null) yield return new ElementValue("signature", SignatureElement);
                }
            }


        }


        [FhirType("TermComponent")]
        [DataContract]
        public partial class TermComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TermComponent"; } }

            /// <summary>
            /// Contract Term identifier
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Contract Term Issue Date Time
            /// </summary>
            [FhirElement("issued", InSummary=true, Order=50)]
            [DataMember]
            public FhirDateTime IssuedElement
            {
                get { return _issuedElement; }
                set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
            }

            private FhirDateTime _issuedElement;

            /// <summary>
            /// Contract Term Issue Date Time
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Issued
            {
                get { return IssuedElement != null ? IssuedElement.Value : null; }
                set
                {
                    if (value == null)
                        IssuedElement = null;
                    else
                        IssuedElement = new FhirDateTime(value);
                    OnPropertyChanged("Issued");
                }
            }

            /// <summary>
            /// Contract Term Effective Time
            /// </summary>
            [FhirElement("applies", InSummary=true, Order=60)]
            [DataMember]
            public Period Applies
            {
                get { return _applies; }
                set { _applies = value; OnPropertyChanged("Applies"); }
            }

            private Period _applies;

            /// <summary>
            /// Contract Term Type
            /// </summary>
            [FhirElement("type", Order=70)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Contract Term Subtype
            /// </summary>
            [FhirElement("subType", Order=80)]
            [DataMember]
            public CodeableConcept SubType
            {
                get { return _subType; }
                set { _subType = value; OnPropertyChanged("SubType"); }
            }

            private CodeableConcept _subType;

            /// <summary>
            /// Subject of this Contract Term
            /// </summary>
            [FhirElement("subject", Order=90)]
            [DataMember]
            public ResourceReference Subject
            {
                get { return _subject; }
                set { _subject = value; OnPropertyChanged("Subject"); }
            }

            private ResourceReference _subject;

            /// <summary>
            /// Contract Term Action
            /// </summary>
            [FhirElement("action", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Action
            {
                get { if (_action==null) _action = new List<CodeableConcept>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<CodeableConcept> _action;

            /// <summary>
            /// Contract Term Action Reason
            /// </summary>
            [FhirElement("actionReason", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ActionReason
            {
                get { if (_actionReason==null) _actionReason = new List<CodeableConcept>(); return _actionReason; }
                set { _actionReason = value; OnPropertyChanged("ActionReason"); }
            }

            private List<CodeableConcept> _actionReason;

            /// <summary>
            /// Contract Term Actor List
            /// </summary>
            [FhirElement("actor", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TermActorComponent> Actor
            {
                get { if (_actor==null) _actor = new List<TermActorComponent>(); return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private List<TermActorComponent> _actor;

            /// <summary>
            /// Human readable Contract term text
            /// </summary>
            [FhirElement("text", Order=130)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Human readable Contract term text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new FhirString(value);
                    OnPropertyChanged("Text");
                }
            }

            /// <summary>
            /// Contract Term Valued Item
            /// </summary>
            [FhirElement("valuedItem", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TermValuedItemComponent> ValuedItem
            {
                get { if (_valuedItem==null) _valuedItem = new List<TermValuedItemComponent>(); return _valuedItem; }
                set { _valuedItem = value; OnPropertyChanged("ValuedItem"); }
            }

            private List<TermValuedItemComponent> _valuedItem;

            /// <summary>
            /// Nested Contract Term Group
            /// </summary>
            [FhirElement("group", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TermComponent> Group
            {
                get { if (_group==null) _group = new List<TermComponent>(); return _group; }
                set { _group = value; OnPropertyChanged("Group"); }
            }

            private List<TermComponent> _group;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TermComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (IssuedElement != null) dest.IssuedElement = (FhirDateTime)IssuedElement.DeepCopy();
                    if (Applies != null) dest.Applies = (Period)Applies.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (SubType != null) dest.SubType = (CodeableConcept)SubType.DeepCopy();
                    if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                    if (Action != null) dest.Action = new List<CodeableConcept>(Action.DeepCopy());
                    if (ActionReason != null) dest.ActionReason = new List<CodeableConcept>(ActionReason.DeepCopy());
                    if (Actor != null) dest.Actor = new List<TermActorComponent>(Actor.DeepCopy());
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (ValuedItem != null) dest.ValuedItem = new List<TermValuedItemComponent>(ValuedItem.DeepCopy());
                    if (Group != null) dest.Group = new List<TermComponent>(Group.DeepCopy());
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
                if (!DeepComparable.Matches(Applies, otherT.Applies)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(SubType, otherT.SubType)) return false;
                if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;
                if ( !DeepComparable.Matches(ActionReason, otherT.ActionReason)) return false;
                if ( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if ( !DeepComparable.Matches(ValuedItem, otherT.ValuedItem)) return false;
                if ( !DeepComparable.Matches(Group, otherT.Group)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TermComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
                if (!DeepComparable.IsExactly(Applies, otherT.Applies)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
                if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;
                if (!DeepComparable.IsExactly(ActionReason, otherT.ActionReason)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(ValuedItem, otherT.ValuedItem)) return false;
                if (!DeepComparable.IsExactly(Group, otherT.Group)) return false;

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
                    if (Subject != null) yield return Subject;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                    foreach (var elem in ActionReason) { if (elem != null) yield return elem; }
                    foreach (var elem in Actor) { if (elem != null) yield return elem; }
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
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                    if (Applies != null) yield return new ElementValue("applies", Applies);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (SubType != null) yield return new ElementValue("subType", SubType);
                    if (Subject != null) yield return new ElementValue("subject", Subject);
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                    foreach (var elem in ActionReason) { if (elem != null) yield return new ElementValue("actionReason", elem); }
                    foreach (var elem in Actor) { if (elem != null) yield return new ElementValue("actor", elem); }
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    foreach (var elem in ValuedItem) { if (elem != null) yield return new ElementValue("valuedItem", elem); }
                    foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", elem); }
                }
            }


        }


        [FhirType("TermActorComponent")]
        [DataContract]
        public partial class TermActorComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TermActorComponent"; } }

            /// <summary>
            /// Contract Term Actor
            /// </summary>
            [FhirElement("entity", Order=40)]
            [References("Contract","Device","Group","Location","Organization","Patient","Practitioner","RelatedPerson","Substance")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Entity
            {
                get { return _entity; }
                set { _entity = value; OnPropertyChanged("Entity"); }
            }

            private ResourceReference _entity;

            /// <summary>
            /// Contract Term Actor Role
            /// </summary>
            [FhirElement("role", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Role
            {
                get { if (_role==null) _role = new List<CodeableConcept>(); return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private List<CodeableConcept> _role;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TermActorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Entity != null) dest.Entity = (ResourceReference)Entity.DeepCopy();
                    if (Role != null) dest.Role = new List<CodeableConcept>(Role.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TermActorComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TermActorComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Entity, otherT.Entity)) return false;
                if ( !DeepComparable.Matches(Role, otherT.Role)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TermActorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Entity != null) yield return Entity;
                    foreach (var elem in Role) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Entity != null) yield return new ElementValue("entity", Entity);
                    foreach (var elem in Role) { if (elem != null) yield return new ElementValue("role", elem); }
                }
            }


        }


        [FhirType("TermValuedItemComponent")]
        [DataContract]
        public partial class TermValuedItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TermValuedItemComponent"; } }

            /// <summary>
            /// Contract Term Valued Item Type
            /// </summary>
            [FhirElement("entity", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Entity
            {
                get { return _entity; }
                set { _entity = value; OnPropertyChanged("Entity"); }
            }

            private Element _entity;

            /// <summary>
            /// Contract Term Valued Item Identifier
            /// </summary>
            [FhirElement("identifier", Order=50)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Contract Term Valued Item Effective Tiem
            /// </summary>
            [FhirElement("effectiveTime", Order=60)]
            [DataMember]
            public FhirDateTime EffectiveTimeElement
            {
                get { return _effectiveTimeElement; }
                set { _effectiveTimeElement = value; OnPropertyChanged("EffectiveTimeElement"); }
            }

            private FhirDateTime _effectiveTimeElement;

            /// <summary>
            /// Contract Term Valued Item Effective Tiem
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string EffectiveTime
            {
                get { return EffectiveTimeElement != null ? EffectiveTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        EffectiveTimeElement = null;
                    else
                        EffectiveTimeElement = new FhirDateTime(value);
                    OnPropertyChanged("EffectiveTime");
                }
            }

            /// <summary>
            /// Contract Term Valued Item Count
            /// </summary>
            [FhirElement("quantity", Order=70)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Contract Term Valued Item fee, charge, or cost
            /// </summary>
            [FhirElement("unitPrice", Order=80)]
            [DataMember]
            public Money UnitPrice
            {
                get { return _unitPrice; }
                set { _unitPrice = value; OnPropertyChanged("UnitPrice"); }
            }

            private Money _unitPrice;

            /// <summary>
            /// Contract Term Valued Item Price Scaling Factor
            /// </summary>
            [FhirElement("factor", Order=90)]
            [DataMember]
            public FhirDecimal FactorElement
            {
                get { return _factorElement; }
                set { _factorElement = value; OnPropertyChanged("FactorElement"); }
            }

            private FhirDecimal _factorElement;

            /// <summary>
            /// Contract Term Valued Item Price Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Contract Term Valued Item Difficulty Scaling Factor
            /// </summary>
            [FhirElement("points", Order=100)]
            [DataMember]
            public FhirDecimal PointsElement
            {
                get { return _pointsElement; }
                set { _pointsElement = value; OnPropertyChanged("PointsElement"); }
            }

            private FhirDecimal _pointsElement;

            /// <summary>
            /// Contract Term Valued Item Difficulty Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Points
            {
                get { return PointsElement != null ? PointsElement.Value : null; }
                set
                {
                    if (value == null)
                        PointsElement = null;
                    else
                        PointsElement = new FhirDecimal(value);
                    OnPropertyChanged("Points");
                }
            }

            /// <summary>
            /// Total Contract Term Valued Item Value
            /// </summary>
            [FhirElement("net", Order=110)]
            [DataMember]
            public Money Net
            {
                get { return _net; }
                set { _net = value; OnPropertyChanged("Net"); }
            }

            private Money _net;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TermValuedItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Entity != null) dest.Entity = (Element)Entity.DeepCopy();
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (EffectiveTimeElement != null) dest.EffectiveTimeElement = (FhirDateTime)EffectiveTimeElement.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (PointsElement != null) dest.PointsElement = (FhirDecimal)PointsElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Entity, otherT.Entity)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TermValuedItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;

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
                    if (Entity != null) yield return new ElementValue("entity", Entity);
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (EffectiveTimeElement != null) yield return new ElementValue("effectiveTime", EffectiveTimeElement);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (PointsElement != null) yield return new ElementValue("points", PointsElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                }
            }


        }


        [FhirType("FriendlyLanguageComponent")]
        [DataContract]
        public partial class FriendlyLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FriendlyLanguageComponent"; } }

            /// <summary>
            /// Easily comprehended representation of this Contract
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FriendlyLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FriendlyLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

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
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        [FhirType("LegalLanguageComponent")]
        [DataContract]
        public partial class LegalLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LegalLanguageComponent"; } }

            /// <summary>
            /// Contract Legal Text
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LegalLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LegalLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

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
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        [FhirType("ComputableLanguageComponent")]
        [DataContract]
        public partial class ComputableLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ComputableLanguageComponent"; } }

            /// <summary>
            /// Computable Contract Rules
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ComputableLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ComputableLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

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
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        /// <summary>
        /// Contract identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// When this Contract was issued
        /// </summary>
        [FhirElement("issued", InSummary=true, Order=100)]
        [DataMember]
        public FhirDateTime IssuedElement
        {
            get { return _issuedElement; }
            set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
        }

        private FhirDateTime _issuedElement;

        /// <summary>
        /// When this Contract was issued
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Issued
        {
            get { return IssuedElement != null ? IssuedElement.Value : null; }
            set
            {
                if (value == null)
                    IssuedElement = null;
                else
                    IssuedElement = new FhirDateTime(value);
                OnPropertyChanged("Issued");
            }
        }

        /// <summary>
        /// Effective time
        /// </summary>
        [FhirElement("applies", InSummary=true, Order=110)]
        [DataMember]
        public Period Applies
        {
            get { return _applies; }
            set { _applies = value; OnPropertyChanged("Applies"); }
        }

        private Period _applies;

        /// <summary>
        /// Subject of this Contract
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Subject
        {
            get { if (_subject==null) _subject = new List<ResourceReference>(); return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private List<ResourceReference> _subject;

        /// <summary>
        /// Authority under which this Contract has standing
        /// </summary>
        [FhirElement("authority", Order=130)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Authority
        {
            get { if (_authority==null) _authority = new List<ResourceReference>(); return _authority; }
            set { _authority = value; OnPropertyChanged("Authority"); }
        }

        private List<ResourceReference> _authority;

        /// <summary>
        /// Domain in which this Contract applies
        /// </summary>
        [FhirElement("domain", Order=140)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Domain
        {
            get { if (_domain==null) _domain = new List<ResourceReference>(); return _domain; }
            set { _domain = value; OnPropertyChanged("Domain"); }
        }

        private List<ResourceReference> _domain;

        /// <summary>
        /// Contract Tyoe
        /// </summary>
        [FhirElement("type", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Contract Subtype
        /// </summary>
        [FhirElement("subType", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> SubType
        {
            get { if (_subType==null) _subType = new List<CodeableConcept>(); return _subType; }
            set { _subType = value; OnPropertyChanged("SubType"); }
        }

        private List<CodeableConcept> _subType;

        /// <summary>
        /// Contract Action
        /// </summary>
        [FhirElement("action", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Action
        {
            get { if (_action==null) _action = new List<CodeableConcept>(); return _action; }
            set { _action = value; OnPropertyChanged("Action"); }
        }

        private List<CodeableConcept> _action;

        /// <summary>
        /// Contract Action Reason
        /// </summary>
        [FhirElement("actionReason", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ActionReason
        {
            get { if (_actionReason==null) _actionReason = new List<CodeableConcept>(); return _actionReason; }
            set { _actionReason = value; OnPropertyChanged("ActionReason"); }
        }

        private List<CodeableConcept> _actionReason;

        /// <summary>
        /// Contract Actor
        /// </summary>
        [FhirElement("actor", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ActorComponent> Actor
        {
            get { if (_actor==null) _actor = new List<ActorComponent>(); return _actor; }
            set { _actor = value; OnPropertyChanged("Actor"); }
        }

        private List<ActorComponent> _actor;

        /// <summary>
        /// Contract Valued Item
        /// </summary>
        [FhirElement("valuedItem", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ValuedItemComponent> ValuedItem
        {
            get { if (_valuedItem==null) _valuedItem = new List<ValuedItemComponent>(); return _valuedItem; }
            set { _valuedItem = value; OnPropertyChanged("ValuedItem"); }
        }

        private List<ValuedItemComponent> _valuedItem;

        /// <summary>
        /// Contract Signer
        /// </summary>
        [FhirElement("signer", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SignatoryComponent> Signer
        {
            get { if (_signer==null) _signer = new List<SignatoryComponent>(); return _signer; }
            set { _signer = value; OnPropertyChanged("Signer"); }
        }

        private List<SignatoryComponent> _signer;

        /// <summary>
        /// Contract Term List
        /// </summary>
        [FhirElement("term", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TermComponent> Term
        {
            get { if (_term==null) _term = new List<TermComponent>(); return _term; }
            set { _term = value; OnPropertyChanged("Term"); }
        }

        private List<TermComponent> _term;

        /// <summary>
        /// Binding Contract
        /// </summary>
        [FhirElement("binding", Order=230, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
        [DataMember]
        public Element Binding
        {
            get { return _binding; }
            set { _binding = value; OnPropertyChanged("Binding"); }
        }

        private Element _binding;

        /// <summary>
        /// Contract Friendly Language
        /// </summary>
        [FhirElement("friendly", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FriendlyLanguageComponent> Friendly
        {
            get { if (_friendly==null) _friendly = new List<FriendlyLanguageComponent>(); return _friendly; }
            set { _friendly = value; OnPropertyChanged("Friendly"); }
        }

        private List<FriendlyLanguageComponent> _friendly;

        /// <summary>
        /// Contract Legal Language
        /// </summary>
        [FhirElement("legal", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LegalLanguageComponent> Legal
        {
            get { if (_legal==null) _legal = new List<LegalLanguageComponent>(); return _legal; }
            set { _legal = value; OnPropertyChanged("Legal"); }
        }

        private List<LegalLanguageComponent> _legal;

        /// <summary>
        /// Computable Contract Language
        /// </summary>
        [FhirElement("rule", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ComputableLanguageComponent> Rule
        {
            get { if (_rule==null) _rule = new List<ComputableLanguageComponent>(); return _rule; }
            set { _rule = value; OnPropertyChanged("Rule"); }
        }

        private List<ComputableLanguageComponent> _rule;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Contract;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (IssuedElement != null) dest.IssuedElement = (FhirDateTime)IssuedElement.DeepCopy();
                if (Applies != null) dest.Applies = (Period)Applies.DeepCopy();
                if (Subject != null) dest.Subject = new List<ResourceReference>(Subject.DeepCopy());
                if (Authority != null) dest.Authority = new List<ResourceReference>(Authority.DeepCopy());
                if (Domain != null) dest.Domain = new List<ResourceReference>(Domain.DeepCopy());
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (SubType != null) dest.SubType = new List<CodeableConcept>(SubType.DeepCopy());
                if (Action != null) dest.Action = new List<CodeableConcept>(Action.DeepCopy());
                if (ActionReason != null) dest.ActionReason = new List<CodeableConcept>(ActionReason.DeepCopy());
                if (Actor != null) dest.Actor = new List<ActorComponent>(Actor.DeepCopy());
                if (ValuedItem != null) dest.ValuedItem = new List<ValuedItemComponent>(ValuedItem.DeepCopy());
                if (Signer != null) dest.Signer = new List<SignatoryComponent>(Signer.DeepCopy());
                if (Term != null) dest.Term = new List<TermComponent>(Term.DeepCopy());
                if (Binding != null) dest.Binding = (Element)Binding.DeepCopy();
                if (Friendly != null) dest.Friendly = new List<FriendlyLanguageComponent>(Friendly.DeepCopy());
                if (Legal != null) dest.Legal = new List<LegalLanguageComponent>(Legal.DeepCopy());
                if (Rule != null) dest.Rule = new List<ComputableLanguageComponent>(Rule.DeepCopy());
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
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.Matches(Applies, otherT.Applies)) return false;
            if ( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
            if ( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(SubType, otherT.SubType)) return false;
            if ( !DeepComparable.Matches(Action, otherT.Action)) return false;
            if ( !DeepComparable.Matches(ActionReason, otherT.ActionReason)) return false;
            if ( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
            if ( !DeepComparable.Matches(ValuedItem, otherT.ValuedItem)) return false;
            if ( !DeepComparable.Matches(Signer, otherT.Signer)) return false;
            if ( !DeepComparable.Matches(Term, otherT.Term)) return false;
            if (!DeepComparable.Matches(Binding, otherT.Binding)) return false;
            if ( !DeepComparable.Matches(Friendly, otherT.Friendly)) return false;
            if ( !DeepComparable.Matches(Legal, otherT.Legal)) return false;
            if ( !DeepComparable.Matches(Rule, otherT.Rule)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Contract;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.IsExactly(Applies, otherT.Applies)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
            if (!DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
            if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;
            if (!DeepComparable.IsExactly(ActionReason, otherT.ActionReason)) return false;
            if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
            if (!DeepComparable.IsExactly(ValuedItem, otherT.ValuedItem)) return false;
            if (!DeepComparable.IsExactly(Signer, otherT.Signer)) return false;
            if (!DeepComparable.IsExactly(Term, otherT.Term)) return false;
            if (!DeepComparable.IsExactly(Binding, otherT.Binding)) return false;
            if (!DeepComparable.IsExactly(Friendly, otherT.Friendly)) return false;
            if (!DeepComparable.IsExactly(Legal, otherT.Legal)) return false;
            if (!DeepComparable.IsExactly(Rule, otherT.Rule)) return false;

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
                foreach (var elem in Subject) { if (elem != null) yield return elem; }
                foreach (var elem in Authority) { if (elem != null) yield return elem; }
                foreach (var elem in Domain) { if (elem != null) yield return elem; }
                if (Type != null) yield return Type;
                foreach (var elem in SubType) { if (elem != null) yield return elem; }
                foreach (var elem in Action) { if (elem != null) yield return elem; }
                foreach (var elem in ActionReason) { if (elem != null) yield return elem; }
                foreach (var elem in Actor) { if (elem != null) yield return elem; }
                foreach (var elem in ValuedItem) { if (elem != null) yield return elem; }
                foreach (var elem in Signer) { if (elem != null) yield return elem; }
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
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                if (Applies != null) yield return new ElementValue("applies", Applies);
                foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", elem); }
                foreach (var elem in Authority) { if (elem != null) yield return new ElementValue("authority", elem); }
                foreach (var elem in Domain) { if (elem != null) yield return new ElementValue("domain", elem); }
                if (Type != null) yield return new ElementValue("type", Type);
                foreach (var elem in SubType) { if (elem != null) yield return new ElementValue("subType", elem); }
                foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                foreach (var elem in ActionReason) { if (elem != null) yield return new ElementValue("actionReason", elem); }
                foreach (var elem in Actor) { if (elem != null) yield return new ElementValue("actor", elem); }
                foreach (var elem in ValuedItem) { if (elem != null) yield return new ElementValue("valuedItem", elem); }
                foreach (var elem in Signer) { if (elem != null) yield return new ElementValue("signer", elem); }
                foreach (var elem in Term) { if (elem != null) yield return new ElementValue("term", elem); }
                if (Binding != null) yield return new ElementValue("binding", Binding);
                foreach (var elem in Friendly) { if (elem != null) yield return new ElementValue("friendly", elem); }
                foreach (var elem in Legal) { if (elem != null) yield return new ElementValue("legal", elem); }
                foreach (var elem in Rule) { if (elem != null) yield return new ElementValue("rule", elem); }
            }
        }

    }

}