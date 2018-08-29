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
    /// Invoice containing ChargeItems from an Account
    /// </summary>
    [FhirType("Invoice", IsResource=true)]
    [DataContract]
    public partial class Invoice : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Invoice; } }
        [NotMapped]
        public override string TypeName { get { return "Invoice"; } }


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// Type of involevent in creation of this Invoice
            /// </summary>
            [FhirElement("role", Order=40)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            /// <summary>
            /// Individual who was involved
            /// </summary>
            [FhirElement("actor", Order=50)]
            [References("Practitioner","Organization","Patient","Device","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;

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


        [FhirType("LineItemComponent")]
        [DataContract]
        public partial class LineItemComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LineItemComponent"; } }

            /// <summary>
            /// Sequence number of line item
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Sequence number of line item
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Reference to ChargeItem containing details of this line item
            /// </summary>
            [FhirElement("chargeItem", Order=50)]
            [References("ChargeItem")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference ChargeItem
            {
                get { return _chargeItem; }
                set { _chargeItem = value; OnPropertyChanged("ChargeItem"); }
            }

            private ResourceReference _chargeItem;

            /// <summary>
            /// Components of total line item price
            /// </summary>
            [FhirElement("priceComponent", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PriceComponentComponent> PriceComponent
            {
                get { if (_priceComponent==null) _priceComponent = new List<PriceComponentComponent>(); return _priceComponent; }
                set { _priceComponent = value; OnPropertyChanged("PriceComponent"); }
            }

            private List<PriceComponentComponent> _priceComponent;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LineItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (ChargeItem != null) dest.ChargeItem = (ResourceReference)ChargeItem.DeepCopy();
                    if (PriceComponent != null) dest.PriceComponent = new List<PriceComponentComponent>(PriceComponent.DeepCopy());
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(ChargeItem, otherT.ChargeItem)) return false;
                if ( !DeepComparable.Matches(PriceComponent, otherT.PriceComponent)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LineItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(ChargeItem, otherT.ChargeItem)) return false;
                if (!DeepComparable.IsExactly(PriceComponent, otherT.PriceComponent)) return false;

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


        [FhirType("PriceComponentComponent")]
        [DataContract]
        public partial class PriceComponentComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PriceComponentComponent"; } }

            /// <summary>
            /// base | surcharge | deduction | discount | tax | informational
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<InvoicePriceComponentType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<InvoicePriceComponentType> _typeElement;

            /// <summary>
            /// base | surcharge | deduction | discount | tax | informational
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public InvoicePriceComponentType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<InvoicePriceComponentType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Code identifying the specific component
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Monetary amount associated with this component
            /// </summary>
            [FhirElement("factor", Order=60)]
            [DataMember]
            public Money Factor
            {
                get { return _factor; }
                set { _factor = value; OnPropertyChanged("Factor"); }
            }

            private Money _factor;

            /// <summary>
            /// Factor used for calculating this component
            /// </summary>
            [FhirElement("amount", Order=70)]
            [DataMember]
            public FhirDecimal AmountElement
            {
                get { return _amountElement; }
                set { _amountElement = value; OnPropertyChanged("AmountElement"); }
            }

            private FhirDecimal _amountElement;

            /// <summary>
            /// Factor used for calculating this component
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new FhirDecimal(value);
                    OnPropertyChanged("Amount");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PriceComponentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<InvoicePriceComponentType>)TypeElement.DeepCopy();
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Factor != null) dest.Factor = (Money)Factor.DeepCopy();
                    if (AmountElement != null) dest.AmountElement = (FhirDecimal)AmountElement.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Factor, otherT.Factor)) return false;
                if (!DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PriceComponentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Factor, otherT.Factor)) return false;
                if (!DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;

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
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// draft | issued | balanced | cancelled | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<InvoiceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<InvoiceStatus> _statusElement;

        /// <summary>
        /// draft | issued | balanced | cancelled | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public InvoiceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<InvoiceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Reason for cancellation of this Invoice
        /// </summary>
        [FhirElement("cancelledReason", Order=110)]
        [DataMember]
        public FhirString CancelledReasonElement
        {
            get { return _cancelledReasonElement; }
            set { _cancelledReasonElement = value; OnPropertyChanged("CancelledReasonElement"); }
        }

        private FhirString _cancelledReasonElement;

        /// <summary>
        /// Reason for cancellation of this Invoice
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string CancelledReason
        {
            get { return CancelledReasonElement != null ? CancelledReasonElement.Value : null; }
            set
            {
                if (value == null)
                    CancelledReasonElement = null;
                else
                    CancelledReasonElement = new FhirString(value);
                OnPropertyChanged("CancelledReason");
            }
        }

        /// <summary>
        /// Type of Invoice
        /// </summary>
        [FhirElement("type", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Recipient(s) of goods and services
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=130)]
        [References("Patient","Group")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Recipient of this invoice
        /// </summary>
        [FhirElement("recipient", InSummary=true, Order=140)]
        [References("Organization","Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Recipient
        {
            get { return _recipient; }
            set { _recipient = value; OnPropertyChanged("Recipient"); }
        }

        private ResourceReference _recipient;

        /// <summary>
        /// Invoice date / posting date
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
        /// Invoice date / posting date
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
        /// Participant in creation of this Invoice
        /// </summary>
        [FhirElement("participant", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if (_participant==null) _participant = new List<ParticipantComponent>(); return _participant; }
            set { _participant = value; OnPropertyChanged("Participant"); }
        }

        private List<ParticipantComponent> _participant;

        /// <summary>
        /// Issuing Organization of Invoice
        /// </summary>
        [FhirElement("issuer", Order=170)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Issuer
        {
            get { return _issuer; }
            set { _issuer = value; OnPropertyChanged("Issuer"); }
        }

        private ResourceReference _issuer;

        /// <summary>
        /// Account that is being balanced
        /// </summary>
        [FhirElement("account", Order=180)]
        [References("Account")]
        [DataMember]
        public ResourceReference Account
        {
            get { return _account; }
            set { _account = value; OnPropertyChanged("Account"); }
        }

        private ResourceReference _account;

        /// <summary>
        /// Line items of this Invoice
        /// </summary>
        [FhirElement("lineItem", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LineItemComponent> LineItem
        {
            get { if (_lineItem==null) _lineItem = new List<LineItemComponent>(); return _lineItem; }
            set { _lineItem = value; OnPropertyChanged("LineItem"); }
        }

        private List<LineItemComponent> _lineItem;

        /// <summary>
        /// Components of Invoice total
        /// </summary>
        [FhirElement("totalPriceComponent", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PriceComponentComponent> TotalPriceComponent
        {
            get { if (_totalPriceComponent==null) _totalPriceComponent = new List<PriceComponentComponent>(); return _totalPriceComponent; }
            set { _totalPriceComponent = value; OnPropertyChanged("TotalPriceComponent"); }
        }

        private List<PriceComponentComponent> _totalPriceComponent;

        /// <summary>
        /// Net total of this Invoice
        /// </summary>
        [FhirElement("totalNet", InSummary=true, Order=210)]
        [DataMember]
        public Money TotalNet
        {
            get { return _totalNet; }
            set { _totalNet = value; OnPropertyChanged("TotalNet"); }
        }

        private Money _totalNet;

        /// <summary>
        /// Gross toal of this Invoice
        /// </summary>
        [FhirElement("totalGross", InSummary=true, Order=220)]
        [DataMember]
        public Money TotalGross
        {
            get { return _totalGross; }
            set { _totalGross = value; OnPropertyChanged("TotalGross"); }
        }

        private Money _totalGross;

        /// <summary>
        /// Payment details
        /// </summary>
        [FhirElement("paymentTerms", Order=230)]
        [DataMember]
        public Markdown PaymentTerms
        {
            get { return _paymentTerms; }
            set { _paymentTerms = value; OnPropertyChanged("PaymentTerms"); }
        }

        private Markdown _paymentTerms;

        /// <summary>
        /// Comments made about the invoice
        /// </summary>
        [FhirElement("note", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Invoice;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<InvoiceStatus>)StatusElement.DeepCopy();
                if (CancelledReasonElement != null) dest.CancelledReasonElement = (FhirString)CancelledReasonElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Recipient != null) dest.Recipient = (ResourceReference)Recipient.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                if (Issuer != null) dest.Issuer = (ResourceReference)Issuer.DeepCopy();
                if (Account != null) dest.Account = (ResourceReference)Account.DeepCopy();
                if (LineItem != null) dest.LineItem = new List<LineItemComponent>(LineItem.DeepCopy());
                if (TotalPriceComponent != null) dest.TotalPriceComponent = new List<PriceComponentComponent>(TotalPriceComponent.DeepCopy());
                if (TotalNet != null) dest.TotalNet = (Money)TotalNet.DeepCopy();
                if (TotalGross != null) dest.TotalGross = (Money)TotalGross.DeepCopy();
                if (PaymentTerms != null) dest.PaymentTerms = (Markdown)PaymentTerms.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
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
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(CancelledReasonElement, otherT.CancelledReasonElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if ( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if (!DeepComparable.Matches(Issuer, otherT.Issuer)) return false;
            if (!DeepComparable.Matches(Account, otherT.Account)) return false;
            if ( !DeepComparable.Matches(LineItem, otherT.LineItem)) return false;
            if ( !DeepComparable.Matches(TotalPriceComponent, otherT.TotalPriceComponent)) return false;
            if (!DeepComparable.Matches(TotalNet, otherT.TotalNet)) return false;
            if (!DeepComparable.Matches(TotalGross, otherT.TotalGross)) return false;
            if (!DeepComparable.Matches(PaymentTerms, otherT.PaymentTerms)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Invoice;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(CancelledReasonElement, otherT.CancelledReasonElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if (!DeepComparable.IsExactly(Issuer, otherT.Issuer)) return false;
            if (!DeepComparable.IsExactly(Account, otherT.Account)) return false;
            if (!DeepComparable.IsExactly(LineItem, otherT.LineItem)) return false;
            if (!DeepComparable.IsExactly(TotalPriceComponent, otherT.TotalPriceComponent)) return false;
            if (!DeepComparable.IsExactly(TotalNet, otherT.TotalNet)) return false;
            if (!DeepComparable.IsExactly(TotalGross, otherT.TotalGross)) return false;
            if (!DeepComparable.IsExactly(PaymentTerms, otherT.PaymentTerms)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

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
                if (PaymentTerms != null) yield return PaymentTerms;
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
                if (PaymentTerms != null) yield return new ElementValue("paymentTerms", false, PaymentTerms);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", true, elem); }
            }
        }

    }

}
