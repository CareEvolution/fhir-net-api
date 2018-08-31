using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.DSTU2;
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
    /// PaymentReconciliation resource
    /// </summary>
    [FhirType("PaymentReconciliation", IsResource=true)]
    [DataContract]
    public partial class PaymentReconciliation : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.PaymentReconciliation; } }
        [NotMapped]
        public override string TypeName { get { return "PaymentReconciliation"; } }


        [FhirType("DetailsComponent")]
        [DataContract]
        public partial class DetailsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DetailsComponent"; } }

            /// <summary>
            /// Type code
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Claim
            /// </summary>
            [FhirElement("request", InSummary=true, Order=50)]
            [DataMember]
            public ResourceReference Request
            {
                get { return _request; }
                set { _request = value; OnPropertyChanged("Request"); }
            }

            private ResourceReference _request;

            /// <summary>
            /// Claim Response
            /// </summary>
            [FhirElement("responce", InSummary=true, Order=60)]
            [DataMember]
            public ResourceReference Responce
            {
                get { return _responce; }
                set { _responce = value; OnPropertyChanged("Responce"); }
            }

            private ResourceReference _responce;

            /// <summary>
            /// Submitter
            /// </summary>
            [FhirElement("submitter", InSummary=true, Order=70)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Submitter
            {
                get { return _submitter; }
                set { _submitter = value; OnPropertyChanged("Submitter"); }
            }

            private ResourceReference _submitter;

            /// <summary>
            /// Payee
            /// </summary>
            [FhirElement("payee", InSummary=true, Order=80)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Payee
            {
                get { return _payee; }
                set { _payee = value; OnPropertyChanged("Payee"); }
            }

            private ResourceReference _payee;

            /// <summary>
            /// Invoice date
            /// </summary>
            [FhirElement("date", InSummary=true, Order=90)]
            [DataMember]
            public Date DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private Date _dateElement;

            /// <summary>
            /// Invoice date
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
                        DateElement = new Date(value);
                    OnPropertyChanged("Date");
                }
            }

            /// <summary>
            /// Detail amount
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=100)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DetailsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                    if (Responce != null) dest.Responce = (ResourceReference)Responce.DeepCopy();
                    if (Submitter != null) dest.Submitter = (ResourceReference)Submitter.DeepCopy();
                    if (Payee != null) dest.Payee = (ResourceReference)Payee.DeepCopy();
                    if (DateElement != null) dest.DateElement = (Date)DateElement.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DetailsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DetailsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Request, otherT.Request)) return false;
                if (!DeepComparable.Matches(Responce, otherT.Responce)) return false;
                if (!DeepComparable.Matches(Submitter, otherT.Submitter)) return false;
                if (!DeepComparable.Matches(Payee, otherT.Payee)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DetailsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
                if (!DeepComparable.IsExactly(Responce, otherT.Responce)) return false;
                if (!DeepComparable.IsExactly(Submitter, otherT.Submitter)) return false;
                if (!DeepComparable.IsExactly(Payee, otherT.Payee)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Request != null) yield return Request;
                    if (Responce != null) yield return Responce;
                    if (Submitter != null) yield return Submitter;
                    if (Payee != null) yield return Payee;
                    if (DateElement != null) yield return DateElement;
                    if (Amount != null) yield return Amount;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Request != null) yield return new ElementValue("request", Request);
                    if (Responce != null) yield return new ElementValue("responce", Responce);
                    if (Submitter != null) yield return new ElementValue("submitter", Submitter);
                    if (Payee != null) yield return new ElementValue("payee", Payee);
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                }
            }


        }


        [FhirType("NotesComponent")]
        [DataContract]
        public partial class NotesComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "NotesComponent"; } }

            /// <summary>
            /// display | print | printoper
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Notes text
            /// </summary>
            [FhirElement("text", InSummary=true, Order=50)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Notes text
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NotesComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new NotesComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NotesComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NotesComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (TextElement != null) yield return TextElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                }
            }


        }


        /// <summary>
        /// Business Identifier
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
        /// Claim reference
        /// </summary>
        [FhirElement("request", InSummary=true, Order=100)]
        [References("ProcessRequest")]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// complete | error
        /// </summary>
        [FhirElement("outcome", InSummary=true, Order=110)]
        [DataMember]
        public Code<RemittanceOutcome> OutcomeElement
        {
            get { return _outcomeElement; }
            set { _outcomeElement = value; OnPropertyChanged("OutcomeElement"); }
        }

        private Code<RemittanceOutcome> _outcomeElement;

        /// <summary>
        /// complete | error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RemittanceOutcome? Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if (value == null)
                    OutcomeElement = null;
                else
                    OutcomeElement = new Code<RemittanceOutcome>(value);
                OnPropertyChanged("Outcome");
            }
        }

        /// <summary>
        /// Disposition Message
        /// </summary>
        [FhirElement("disposition", InSummary=true, Order=120)]
        [DataMember]
        public FhirString DispositionElement
        {
            get { return _dispositionElement; }
            set { _dispositionElement = value; OnPropertyChanged("DispositionElement"); }
        }

        private FhirString _dispositionElement;

        /// <summary>
        /// Disposition Message
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Disposition
        {
            get { return DispositionElement != null ? DispositionElement.Value : null; }
            set
            {
                if (value == null)
                    DispositionElement = null;
                else
                    DispositionElement = new FhirString(value);
                OnPropertyChanged("Disposition");
            }
        }

        /// <summary>
        /// Resource version
        /// </summary>
        [FhirElement("ruleset", InSummary=true, Order=130)]
        [DataMember]
        public Coding Ruleset
        {
            get { return _ruleset; }
            set { _ruleset = value; OnPropertyChanged("Ruleset"); }
        }

        private Coding _ruleset;

        /// <summary>
        /// Original version
        /// </summary>
        [FhirElement("originalRuleset", InSummary=true, Order=140)]
        [DataMember]
        public Coding OriginalRuleset
        {
            get { return _originalRuleset; }
            set { _originalRuleset = value; OnPropertyChanged("OriginalRuleset"); }
        }

        private Coding _originalRuleset;

        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", InSummary=true, Order=150)]
        [DataMember]
        public FhirDateTime CreatedElement
        {
            get { return _createdElement; }
            set { _createdElement = value; OnPropertyChanged("CreatedElement"); }
        }

        private FhirDateTime _createdElement;

        /// <summary>
        /// Creation date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if (value == null)
                    CreatedElement = null;
                else
                    CreatedElement = new FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }

        /// <summary>
        /// Period covered
        /// </summary>
        [FhirElement("period", InSummary=true, Order=160)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Insurer
        /// </summary>
        [FhirElement("organization", InSummary=true, Order=170)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private ResourceReference _organization;

        /// <summary>
        /// Responsible practitioner
        /// </summary>
        [FhirElement("requestProvider", InSummary=true, Order=180)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference RequestProvider
        {
            get { return _requestProvider; }
            set { _requestProvider = value; OnPropertyChanged("RequestProvider"); }
        }

        private ResourceReference _requestProvider;

        /// <summary>
        /// Responsible organization
        /// </summary>
        [FhirElement("requestOrganization", InSummary=true, Order=190)]
        [References("Organization")]
        [DataMember]
        public ResourceReference RequestOrganization
        {
            get { return _requestOrganization; }
            set { _requestOrganization = value; OnPropertyChanged("RequestOrganization"); }
        }

        private ResourceReference _requestOrganization;

        /// <summary>
        /// Details
        /// </summary>
        [FhirElement("detail", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DetailsComponent> Detail
        {
            get { if (_detail==null) _detail = new List<DetailsComponent>(); return _detail; }
            set { _detail = value; OnPropertyChanged("Detail"); }
        }

        private List<DetailsComponent> _detail;

        /// <summary>
        /// Printed Form Identifier
        /// </summary>
        [FhirElement("form", InSummary=true, Order=210)]
        [DataMember]
        public Coding Form
        {
            get { return _form; }
            set { _form = value; OnPropertyChanged("Form"); }
        }

        private Coding _form;

        /// <summary>
        /// Total amount of Payment
        /// </summary>
        [FhirElement("total", InSummary=true, Order=220)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Money Total
        {
            get { return _total; }
            set { _total = value; OnPropertyChanged("Total"); }
        }

        private Money _total;

        /// <summary>
        /// Note text
        /// </summary>
        [FhirElement("note", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<NotesComponent> Note
        {
            get { if (_note==null) _note = new List<NotesComponent>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<NotesComponent> _note;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as PaymentReconciliation;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (OutcomeElement != null) dest.OutcomeElement = (Code<RemittanceOutcome>)OutcomeElement.DeepCopy();
                if (DispositionElement != null) dest.DispositionElement = (FhirString)DispositionElement.DeepCopy();
                if (Ruleset != null) dest.Ruleset = (Coding)Ruleset.DeepCopy();
                if (OriginalRuleset != null) dest.OriginalRuleset = (Coding)OriginalRuleset.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (RequestProvider != null) dest.RequestProvider = (ResourceReference)RequestProvider.DeepCopy();
                if (RequestOrganization != null) dest.RequestOrganization = (ResourceReference)RequestOrganization.DeepCopy();
                if (Detail != null) dest.Detail = new List<DetailsComponent>(Detail.DeepCopy());
                if (Form != null) dest.Form = (Coding)Form.DeepCopy();
                if (Total != null) dest.Total = (Money)Total.DeepCopy();
                if (Note != null) dest.Note = new List<NotesComponent>(Note.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new PaymentReconciliation());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as PaymentReconciliation;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.Matches(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.Matches(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.Matches(RequestOrganization, otherT.RequestOrganization)) return false;
            if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;
            if (!DeepComparable.Matches(Form, otherT.Form)) return false;
            if (!DeepComparable.Matches(Total, otherT.Total)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as PaymentReconciliation;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.IsExactly(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.IsExactly(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.IsExactly(RequestOrganization, otherT.RequestOrganization)) return false;
            if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
            if (!DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if (!DeepComparable.IsExactly(Total, otherT.Total)) return false;
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
                if (Request != null) yield return Request;
                if (OutcomeElement != null) yield return OutcomeElement;
                if (DispositionElement != null) yield return DispositionElement;
                if (Ruleset != null) yield return Ruleset;
                if (OriginalRuleset != null) yield return OriginalRuleset;
                if (CreatedElement != null) yield return CreatedElement;
                if (Period != null) yield return Period;
                if (Organization != null) yield return Organization;
                if (RequestProvider != null) yield return RequestProvider;
                if (RequestOrganization != null) yield return RequestOrganization;
                foreach (var elem in Detail) { if (elem != null) yield return elem; }
                if (Form != null) yield return Form;
                if (Total != null) yield return Total;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Request != null) yield return new ElementValue("request", Request);
                if (OutcomeElement != null) yield return new ElementValue("outcome", OutcomeElement);
                if (DispositionElement != null) yield return new ElementValue("disposition", DispositionElement);
                if (Ruleset != null) yield return new ElementValue("ruleset", Ruleset);
                if (OriginalRuleset != null) yield return new ElementValue("originalRuleset", OriginalRuleset);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Period != null) yield return new ElementValue("period", Period);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                if (RequestProvider != null) yield return new ElementValue("requestProvider", RequestProvider);
                if (RequestOrganization != null) yield return new ElementValue("requestOrganization", RequestOrganization);
                foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
                if (Form != null) yield return new ElementValue("form", Form);
                if (Total != null) yield return new ElementValue("total", Total);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
