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
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Claim
            /// </summary>
            [FhirElement("request", Order=50)]
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
            [FhirElement("response", Order=60)]
            [DataMember]
            public ResourceReference Response
            {
                get { return _response; }
                set { _response = value; OnPropertyChanged("Response"); }
            }

            private ResourceReference _response;

            /// <summary>
            /// Organization which submitted the claim
            /// </summary>
            [FhirElement("submitter", Order=70)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Submitter
            {
                get { return _submitter; }
                set { _submitter = value; OnPropertyChanged("Submitter"); }
            }

            private ResourceReference _submitter;

            /// <summary>
            /// Organization which is receiving the payment
            /// </summary>
            [FhirElement("payee", Order=80)]
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
            [FhirElement("date", Order=90)]
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
            /// Amount being paid
            /// </summary>
            [FhirElement("amount", Order=100)]
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
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                    if (Response != null) dest.Response = (ResourceReference)Response.DeepCopy();
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
                if (!DeepComparable.Matches(Response, otherT.Response)) return false;
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
                if (!DeepComparable.IsExactly(Response, otherT.Response)) return false;
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
                    if (Response != null) yield return Response;
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
                    if (Response != null) yield return new ElementValue("response", Response);
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
            [FhirElement("type", Order=40)]
            [DataMember]
            public Code<NoteType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<NoteType> _typeElement;

            /// <summary>
            /// display | print | printoper
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public NoteType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<NoteType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Comment on the processing
            /// </summary>
            [FhirElement("text", Order=50)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Comment on the processing
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
                    if (TypeElement != null) dest.TypeElement = (Code<NoteType>)TypeElement.DeepCopy();
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
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NotesComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (TextElement != null) yield return TextElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                }
            }


        }


        /// <summary>
        /// Business Identifier
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<FinancialResourceStatusCodes> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<FinancialResourceStatusCodes> _statusElement;

        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public FinancialResourceStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<FinancialResourceStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Period covered
        /// </summary>
        [FhirElement("period", Order=110)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", Order=120)]
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
        /// Insurer
        /// </summary>
        [FhirElement("organization", Order=130)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private ResourceReference _organization;

        /// <summary>
        /// Claim reference
        /// </summary>
        [FhirElement("request", Order=140)]
        [References("ProcessRequest")]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// queued | complete | error | partial
        /// </summary>
        [FhirElement("outcome", Order=150)]
        [DataMember]
        public Code<ClaimProcessingCodes> OutcomeElement
        {
            get { return _outcomeElement; }
            set { _outcomeElement = value; OnPropertyChanged("OutcomeElement"); }
        }

        private Code<ClaimProcessingCodes> _outcomeElement;

        /// <summary>
        /// queued | complete | error | partial
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ClaimProcessingCodes? Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if (value == null)
                    OutcomeElement = null;
                else
                    OutcomeElement = new Code<ClaimProcessingCodes>(value);
                OnPropertyChanged("Outcome");
            }
        }

        /// <summary>
        /// Disposition Message
        /// </summary>
        [FhirElement("disposition", Order=160)]
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
        /// Responsible practitioner
        /// </summary>
        [FhirElement("requestProvider", Order=170)]
        [References("Practitioner","PractitionerRole","Organization")]
        [DataMember]
        public ResourceReference RequestProvider
        {
            get { return _requestProvider; }
            set { _requestProvider = value; OnPropertyChanged("RequestProvider"); }
        }

        private ResourceReference _requestProvider;

        /// <summary>
        /// List of settlements
        /// </summary>
        [FhirElement("detail", Order=180)]
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
        [FhirElement("form", Order=190)]
        [DataMember]
        public CodeableConcept Form
        {
            get { return _form; }
            set { _form = value; OnPropertyChanged("Form"); }
        }

        private CodeableConcept _form;

        /// <summary>
        /// Total amount of Payment
        /// </summary>
        [FhirElement("total", Order=200)]
        [DataMember]
        public Money Total
        {
            get { return _total; }
            set { _total = value; OnPropertyChanged("Total"); }
        }

        private Money _total;

        /// <summary>
        /// Processing comments
        /// </summary>
        [FhirElement("processNote", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<NotesComponent> ProcessNote
        {
            get { if (_processNote==null) _processNote = new List<NotesComponent>(); return _processNote; }
            set { _processNote = value; OnPropertyChanged("ProcessNote"); }
        }

        private List<NotesComponent> _processNote;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as PaymentReconciliation;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (OutcomeElement != null) dest.OutcomeElement = (Code<ClaimProcessingCodes>)OutcomeElement.DeepCopy();
                if (DispositionElement != null) dest.DispositionElement = (FhirString)DispositionElement.DeepCopy();
                if (RequestProvider != null) dest.RequestProvider = (ResourceReference)RequestProvider.DeepCopy();
                if (Detail != null) dest.Detail = new List<DetailsComponent>(Detail.DeepCopy());
                if (Form != null) dest.Form = (CodeableConcept)Form.DeepCopy();
                if (Total != null) dest.Total = (Money)Total.DeepCopy();
                if (ProcessNote != null) dest.ProcessNote = new List<NotesComponent>(ProcessNote.DeepCopy());
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
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.Matches(RequestProvider, otherT.RequestProvider)) return false;
            if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;
            if (!DeepComparable.Matches(Form, otherT.Form)) return false;
            if (!DeepComparable.Matches(Total, otherT.Total)) return false;
            if ( !DeepComparable.Matches(ProcessNote, otherT.ProcessNote)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as PaymentReconciliation;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.IsExactly(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
            if (!DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if (!DeepComparable.IsExactly(Total, otherT.Total)) return false;
            if (!DeepComparable.IsExactly(ProcessNote, otherT.ProcessNote)) return false;

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
                if (Period != null) yield return Period;
                if (CreatedElement != null) yield return CreatedElement;
                if (Organization != null) yield return Organization;
                if (Request != null) yield return Request;
                if (OutcomeElement != null) yield return OutcomeElement;
                if (DispositionElement != null) yield return DispositionElement;
                if (RequestProvider != null) yield return RequestProvider;
                foreach (var elem in Detail) { if (elem != null) yield return elem; }
                if (Form != null) yield return Form;
                if (Total != null) yield return Total;
                foreach (var elem in ProcessNote) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Period != null) yield return new ElementValue("period", Period);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                if (Request != null) yield return new ElementValue("request", Request);
                if (OutcomeElement != null) yield return new ElementValue("outcome", OutcomeElement);
                if (DispositionElement != null) yield return new ElementValue("disposition", DispositionElement);
                if (RequestProvider != null) yield return new ElementValue("requestProvider", RequestProvider);
                foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
                if (Form != null) yield return new ElementValue("form", Form);
                if (Total != null) yield return new ElementValue("total", Total);
                foreach (var elem in ProcessNote) { if (elem != null) yield return new ElementValue("processNote", elem); }
            }
        }

    }

}
