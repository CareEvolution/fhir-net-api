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
    /// Invoice containing ChargeItems from an Account
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "Invoice", IsResource=true)]
    [DataContract]
    public partial class Invoice : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Invoice; } }
        [NotMapped]
        public override string TypeName { get { return "Invoice"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }
            
            /// <summary>
            /// Type of involevent in creation of this Invoice
            /// </summary>
            [FhirElement("role", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Role
            {
                get { return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Role;
            
            /// <summary>
            /// Individual who was involved
            /// </summary>
            [FhirElement("actor", Order=50)]
            [CLSCompliant(false)]
            [References("Practitioner","Organization","Patient","Device","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Actor
            {
                get { return _Actor; }
                set { _Actor = value; OnPropertyChanged("Actor"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Actor;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Role != null) dest.Role = (Hl7.Fhir.Model.R4.CodeableConcept)Role.DeepCopy();
                    if(Actor != null) dest.Actor = (Hl7.Fhir.Model.R4.ResourceReference)Actor.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParticipantComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if( !DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Actor != null) yield return Actor;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", false, Role);
                    if (Actor != null) yield return new ElementValue("actor", false, Actor);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "LineItemComponent")]
        [DataContract]
        public partial class LineItemComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "LineItemComponent"; } }
            
            /// <summary>
            /// Sequence number of line item
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt SequenceElement
            {
                get { return _SequenceElement; }
                set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _SequenceElement;
            
            /// <summary>
            /// Sequence number of line item
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }
            
            /// <summary>
            /// Reference to ChargeItem containing details of this line item
            /// </summary>
            [FhirElement("chargeItem", Order=50)]
            [CLSCompliant(false)]
            [References("ChargeItem")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference ChargeItem
            {
                get { return _ChargeItem; }
                set { _ChargeItem = value; OnPropertyChanged("ChargeItem"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _ChargeItem;
            
            /// <summary>
            /// Components of total line item price
            /// </summary>
            [FhirElement("priceComponent", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PriceComponentComponent> PriceComponent
            {
                get { if(_PriceComponent==null) _PriceComponent = new List<PriceComponentComponent>(); return _PriceComponent; }
                set { _PriceComponent = value; OnPropertyChanged("PriceComponent"); }
            }
            
            private List<PriceComponentComponent> _PriceComponent;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LineItemComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.R4.PositiveInt)SequenceElement.DeepCopy();
                    if(ChargeItem != null) dest.ChargeItem = (Hl7.Fhir.Model.R4.ResourceReference)ChargeItem.DeepCopy();
                    if(PriceComponent != null) dest.PriceComponent = new List<PriceComponentComponent>(PriceComponent.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LineItemComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LineItemComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.Matches(ChargeItem, otherT.ChargeItem)) return false;
                if( !DeepComparable.Matches(PriceComponent, otherT.PriceComponent)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LineItemComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.IsExactly(ChargeItem, otherT.ChargeItem)) return false;
                if( !DeepComparable.IsExactly(PriceComponent, otherT.PriceComponent)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (ChargeItem != null) yield return ChargeItem;
                    foreach (var elem in PriceComponent) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", false, SequenceElement);
                    if (ChargeItem != null) yield return new ElementValue("chargeItem", false, ChargeItem);
                    foreach (var elem in PriceComponent) { if (elem != null) yield return new ElementValue("priceComponent", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PriceComponentComponent")]
        [DataContract]
        public partial class PriceComponentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PriceComponentComponent"; } }
            
            /// <summary>
            /// base | surcharge | deduction | discount | tax | informational
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _TypeElement;
            
            /// <summary>
            /// base | surcharge | deduction | discount | tax | informational
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
            /// Code identifying the specific component
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Code;
            
            /// <summary>
            /// Monetary amount associated with this component
            /// </summary>
            [FhirElement("factor", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Factor
            {
                get { return _Factor; }
                set { _Factor = value; OnPropertyChanged("Factor"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Factor;
            
            /// <summary>
            /// Factor used for calculating this component
            /// </summary>
            [FhirElement("amount", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDecimal AmountElement
            {
                get { return _AmountElement; }
                set { _AmountElement = value; OnPropertyChanged("AmountElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDecimal _AmountElement;
            
            /// <summary>
            /// Factor used for calculating this component
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new Hl7.Fhir.Model.R4.FhirDecimal(value);
                    OnPropertyChanged("Amount");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PriceComponentComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.R4.Code)TypeElement.DeepCopy();
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                    if(Factor != null) dest.Factor = (Hl7.Fhir.Model.R4.Money)Factor.DeepCopy();
                    if(AmountElement != null) dest.AmountElement = (Hl7.Fhir.Model.R4.FhirDecimal)AmountElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PriceComponentComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PriceComponentComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Factor, otherT.Factor)) return false;
                if( !DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PriceComponentComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Factor, otherT.Factor)) return false;
                if( !DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Code != null) yield return Code;
                    if (Factor != null) yield return Factor;
                    if (AmountElement != null) yield return AmountElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (Factor != null) yield return new ElementValue("factor", false, Factor);
                    if (AmountElement != null) yield return new ElementValue("amount", false, AmountElement);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Business Identifier for item
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Identifier> _Identifier;
        
        /// <summary>
        /// draft | issued | balanced | cancelled | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
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
        /// draft | issued | balanced | cancelled | entered-in-error
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
        /// Reason for cancellation of this Invoice
        /// </summary>
        [FhirElement("cancelledReason", Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CancelledReasonElement
        {
            get { return _CancelledReasonElement; }
            set { _CancelledReasonElement = value; OnPropertyChanged("CancelledReasonElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _CancelledReasonElement;
        
        /// <summary>
        /// Reason for cancellation of this Invoice
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string CancelledReason
        {
            get { return CancelledReasonElement != null ? CancelledReasonElement.Value : null; }
            set
            {
                if (value == null)
                    CancelledReasonElement = null;
                else
                    CancelledReasonElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("CancelledReason");
            }
        }
        
        /// <summary>
        /// Type of Invoice
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Type;
        
        /// <summary>
        /// Recipient(s) of goods and services
        /// </summary>
        [FhirElement("subject", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [References("Patient","Group")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Subject;
        
        /// <summary>
        /// Recipient of this invoice
        /// </summary>
        [FhirElement("recipient", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [References("Organization","Patient","RelatedPerson")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Recipient
        {
            get { return _Recipient; }
            set { _Recipient = value; OnPropertyChanged("Recipient"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Recipient;
        
        /// <summary>
        /// Invoice date / posting date
        /// </summary>
        [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
        
        /// <summary>
        /// Invoice date / posting date
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
        /// Participant in creation of this Invoice
        /// </summary>
        [FhirElement("participant", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if(_Participant==null) _Participant = new List<ParticipantComponent>(); return _Participant; }
            set { _Participant = value; OnPropertyChanged("Participant"); }
        }
        
        private List<ParticipantComponent> _Participant;
        
        /// <summary>
        /// Issuing Organization of Invoice
        /// </summary>
        [FhirElement("issuer", Order=170)]
        [CLSCompliant(false)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Issuer
        {
            get { return _Issuer; }
            set { _Issuer = value; OnPropertyChanged("Issuer"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Issuer;
        
        /// <summary>
        /// Account that is being balanced
        /// </summary>
        [FhirElement("account", Order=180)]
        [CLSCompliant(false)]
        [References("Account")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Account
        {
            get { return _Account; }
            set { _Account = value; OnPropertyChanged("Account"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Account;
        
        /// <summary>
        /// Line items of this Invoice
        /// </summary>
        [FhirElement("lineItem", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LineItemComponent> LineItem
        {
            get { if(_LineItem==null) _LineItem = new List<LineItemComponent>(); return _LineItem; }
            set { _LineItem = value; OnPropertyChanged("LineItem"); }
        }
        
        private List<LineItemComponent> _LineItem;
        
        /// <summary>
        /// Components of Invoice total
        /// </summary>
        [FhirElement("totalPriceComponent", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PriceComponentComponent> TotalPriceComponent
        {
            get { if(_TotalPriceComponent==null) _TotalPriceComponent = new List<PriceComponentComponent>(); return _TotalPriceComponent; }
            set { _TotalPriceComponent = value; OnPropertyChanged("TotalPriceComponent"); }
        }
        
        private List<PriceComponentComponent> _TotalPriceComponent;
        
        /// <summary>
        /// Net total of this Invoice
        /// </summary>
        [FhirElement("totalNet", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Money TotalNet
        {
            get { return _TotalNet; }
            set { _TotalNet = value; OnPropertyChanged("TotalNet"); }
        }
        
        private Hl7.Fhir.Model.R4.Money _TotalNet;
        
        /// <summary>
        /// Gross toal of this Invoice
        /// </summary>
        [FhirElement("totalGross", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Money TotalGross
        {
            get { return _TotalGross; }
            set { _TotalGross = value; OnPropertyChanged("TotalGross"); }
        }
        
        private Hl7.Fhir.Model.R4.Money _TotalGross;
        
        /// <summary>
        /// Payment details
        /// </summary>
        [FhirElement("paymentTerms", Order=230)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown PaymentTermsElement
        {
            get { return _PaymentTermsElement; }
            set { _PaymentTermsElement = value; OnPropertyChanged("PaymentTermsElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _PaymentTermsElement;
        
        /// <summary>
        /// Payment details
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string PaymentTerms
        {
            get { return PaymentTermsElement != null ? PaymentTermsElement.Value : null; }
            set
            {
                if (value == null)
                    PaymentTermsElement = null;
                else
                    PaymentTermsElement = new Hl7.Fhir.Model.Markdown(value);
                OnPropertyChanged("PaymentTerms");
            }
        }
        
        /// <summary>
        /// Comments made about the invoice
        /// </summary>
        [FhirElement("note", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.R4.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Annotation> _Note;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Invoice;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(CancelledReasonElement != null) dest.CancelledReasonElement = (Hl7.Fhir.Model.FhirString)CancelledReasonElement.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.R4.ResourceReference)Subject.DeepCopy();
                if(Recipient != null) dest.Recipient = (Hl7.Fhir.Model.R4.ResourceReference)Recipient.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                if(Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                if(Issuer != null) dest.Issuer = (Hl7.Fhir.Model.R4.ResourceReference)Issuer.DeepCopy();
                if(Account != null) dest.Account = (Hl7.Fhir.Model.R4.ResourceReference)Account.DeepCopy();
                if(LineItem != null) dest.LineItem = new List<LineItemComponent>(LineItem.DeepCopy());
                if(TotalPriceComponent != null) dest.TotalPriceComponent = new List<PriceComponentComponent>(TotalPriceComponent.DeepCopy());
                if(TotalNet != null) dest.TotalNet = (Hl7.Fhir.Model.R4.Money)TotalNet.DeepCopy();
                if(TotalGross != null) dest.TotalGross = (Hl7.Fhir.Model.R4.Money)TotalGross.DeepCopy();
                if(PaymentTermsElement != null) dest.PaymentTermsElement = (Hl7.Fhir.Model.Markdown)PaymentTermsElement.DeepCopy();
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.R4.Annotation>(Note.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Invoice());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Invoice;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(CancelledReasonElement, otherT.CancelledReasonElement)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if( !DeepComparable.Matches(Issuer, otherT.Issuer)) return false;
            if( !DeepComparable.Matches(Account, otherT.Account)) return false;
            if( !DeepComparable.Matches(LineItem, otherT.LineItem)) return false;
            if( !DeepComparable.Matches(TotalPriceComponent, otherT.TotalPriceComponent)) return false;
            if( !DeepComparable.Matches(TotalNet, otherT.TotalNet)) return false;
            if( !DeepComparable.Matches(TotalGross, otherT.TotalGross)) return false;
            if( !DeepComparable.Matches(PaymentTermsElement, otherT.PaymentTermsElement)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Invoice;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(CancelledReasonElement, otherT.CancelledReasonElement)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if( !DeepComparable.IsExactly(Issuer, otherT.Issuer)) return false;
            if( !DeepComparable.IsExactly(Account, otherT.Account)) return false;
            if( !DeepComparable.IsExactly(LineItem, otherT.LineItem)) return false;
            if( !DeepComparable.IsExactly(TotalPriceComponent, otherT.TotalPriceComponent)) return false;
            if( !DeepComparable.IsExactly(TotalNet, otherT.TotalNet)) return false;
            if( !DeepComparable.IsExactly(TotalGross, otherT.TotalGross)) return false;
            if( !DeepComparable.IsExactly(PaymentTermsElement, otherT.PaymentTermsElement)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (CancelledReasonElement != null) yield return CancelledReasonElement;
                if (Type != null) yield return Type;
                if (Subject != null) yield return Subject;
                if (Recipient != null) yield return Recipient;
                if (DateElement != null) yield return DateElement;
                foreach (var elem in Participant) { if (elem != null) yield return elem; }
                if (Issuer != null) yield return Issuer;
                if (Account != null) yield return Account;
                foreach (var elem in LineItem) { if (elem != null) yield return elem; }
                foreach (var elem in TotalPriceComponent) { if (elem != null) yield return elem; }
                if (TotalNet != null) yield return TotalNet;
                if (TotalGross != null) yield return TotalGross;
                if (PaymentTermsElement != null) yield return PaymentTermsElement;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (CancelledReasonElement != null) yield return new ElementValue("cancelledReason", false, CancelledReasonElement);
                if (Type != null) yield return new ElementValue("type", false, Type);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (Recipient != null) yield return new ElementValue("recipient", false, Recipient);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", true, elem); }
                if (Issuer != null) yield return new ElementValue("issuer", false, Issuer);
                if (Account != null) yield return new ElementValue("account", false, Account);
                foreach (var elem in LineItem) { if (elem != null) yield return new ElementValue("lineItem", true, elem); }
                foreach (var elem in TotalPriceComponent) { if (elem != null) yield return new ElementValue("totalPriceComponent", true, elem); }
                if (TotalNet != null) yield return new ElementValue("totalNet", false, TotalNet);
                if (TotalGross != null) yield return new ElementValue("totalGross", false, TotalGross);
                if (PaymentTermsElement != null) yield return new ElementValue("paymentTerms", false, PaymentTermsElement);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", true, elem); }
            }
        }
    
    }

}
