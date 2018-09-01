using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.STU3;
using Hl7.Fhir.Validation.STU3;
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
// Generated for FHIR v3.0.1
//
namespace Hl7.Fhir.Model.STU3
{
    /// <summary>
    /// ProcessResponse resource
    /// </summary>
    [FhirType("ProcessResponse", IsResource=true)]
    [DataContract]
    public partial class ProcessResponse : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ProcessResponse; } }
        [NotMapped]
        public override string TypeName { get { return "ProcessResponse"; } }


        [FhirType("ProcessNoteComponent")]
        [DataContract]
        public partial class ProcessNoteComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ProcessNoteComponent"; } }

            /// <summary>
            /// display | print | printoper
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

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
                var dest = other as ProcessNoteComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ProcessNoteComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProcessNoteComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProcessNoteComponent;
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
        /// Creation date
        /// </summary>
        [FhirElement("created", Order=110)]
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
        /// Authoring Organization
        /// </summary>
        [FhirElement("organization", Order=120)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private ResourceReference _organization;

        /// <summary>
        /// Request reference
        /// </summary>
        [FhirElement("request", Order=130)]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// Processing outcome
        /// </summary>
        [FhirElement("outcome", Order=140)]
        [DataMember]
        public CodeableConcept Outcome
        {
            get { return _outcome; }
            set { _outcome = value; OnPropertyChanged("Outcome"); }
        }

        private CodeableConcept _outcome;

        /// <summary>
        /// Disposition Message
        /// </summary>
        [FhirElement("disposition", Order=150)]
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
        /// Responsible Practitioner
        /// </summary>
        [FhirElement("requestProvider", Order=160)]
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
        [FhirElement("requestOrganization", Order=170)]
        [References("Organization")]
        [DataMember]
        public ResourceReference RequestOrganization
        {
            get { return _requestOrganization; }
            set { _requestOrganization = value; OnPropertyChanged("RequestOrganization"); }
        }

        private ResourceReference _requestOrganization;

        /// <summary>
        /// Printed Form Identifier
        /// </summary>
        [FhirElement("form", Order=180)]
        [DataMember]
        public CodeableConcept Form
        {
            get { return _form; }
            set { _form = value; OnPropertyChanged("Form"); }
        }

        private CodeableConcept _form;

        /// <summary>
        /// Processing comments or additional requirements
        /// </summary>
        [FhirElement("processNote", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ProcessNoteComponent> ProcessNote
        {
            get { if (_processNote==null) _processNote = new List<ProcessNoteComponent>(); return _processNote; }
            set { _processNote = value; OnPropertyChanged("ProcessNote"); }
        }

        private List<ProcessNoteComponent> _processNote;

        /// <summary>
        /// Error code
        /// </summary>
        [FhirElement("error", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Error
        {
            get { if (_error==null) _error = new List<CodeableConcept>(); return _error; }
            set { _error = value; OnPropertyChanged("Error"); }
        }

        private List<CodeableConcept> _error;

        /// <summary>
        /// Request for additional information
        /// </summary>
        [FhirElement("communicationRequest", Order=210)]
        [References("CommunicationRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> CommunicationRequest
        {
            get { if (_communicationRequest==null) _communicationRequest = new List<ResourceReference>(); return _communicationRequest; }
            set { _communicationRequest = value; OnPropertyChanged("CommunicationRequest"); }
        }

        private List<ResourceReference> _communicationRequest;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ProcessResponse;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                if (DispositionElement != null) dest.DispositionElement = (FhirString)DispositionElement.DeepCopy();
                if (RequestProvider != null) dest.RequestProvider = (ResourceReference)RequestProvider.DeepCopy();
                if (RequestOrganization != null) dest.RequestOrganization = (ResourceReference)RequestOrganization.DeepCopy();
                if (Form != null) dest.Form = (CodeableConcept)Form.DeepCopy();
                if (ProcessNote != null) dest.ProcessNote = new List<ProcessNoteComponent>(ProcessNote.DeepCopy());
                if (Error != null) dest.Error = new List<CodeableConcept>(Error.DeepCopy());
                if (CommunicationRequest != null) dest.CommunicationRequest = new List<ResourceReference>(CommunicationRequest.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ProcessResponse());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ProcessResponse;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.Matches(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.Matches(RequestOrganization, otherT.RequestOrganization)) return false;
            if (!DeepComparable.Matches(Form, otherT.Form)) return false;
            if ( !DeepComparable.Matches(ProcessNote, otherT.ProcessNote)) return false;
            if ( !DeepComparable.Matches(Error, otherT.Error)) return false;
            if ( !DeepComparable.Matches(CommunicationRequest, otherT.CommunicationRequest)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ProcessResponse;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.IsExactly(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.IsExactly(RequestOrganization, otherT.RequestOrganization)) return false;
            if (!DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if (!DeepComparable.IsExactly(ProcessNote, otherT.ProcessNote)) return false;
            if (!DeepComparable.IsExactly(Error, otherT.Error)) return false;
            if (!DeepComparable.IsExactly(CommunicationRequest, otherT.CommunicationRequest)) return false;

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
                if (CreatedElement != null) yield return CreatedElement;
                if (Organization != null) yield return Organization;
                if (Request != null) yield return Request;
                if (Outcome != null) yield return Outcome;
                if (DispositionElement != null) yield return DispositionElement;
                if (RequestProvider != null) yield return RequestProvider;
                if (RequestOrganization != null) yield return RequestOrganization;
                if (Form != null) yield return Form;
                foreach (var elem in ProcessNote) { if (elem != null) yield return elem; }
                foreach (var elem in Error) { if (elem != null) yield return elem; }
                foreach (var elem in CommunicationRequest) { if (elem != null) yield return elem; }
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
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                if (Request != null) yield return new ElementValue("request", Request);
                if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                if (DispositionElement != null) yield return new ElementValue("disposition", DispositionElement);
                if (RequestProvider != null) yield return new ElementValue("requestProvider", RequestProvider);
                if (RequestOrganization != null) yield return new ElementValue("requestOrganization", RequestOrganization);
                if (Form != null) yield return new ElementValue("form", Form);
                foreach (var elem in ProcessNote) { if (elem != null) yield return new ElementValue("processNote", elem); }
                foreach (var elem in Error) { if (elem != null) yield return new ElementValue("error", elem); }
                foreach (var elem in CommunicationRequest) { if (elem != null) yield return new ElementValue("communicationRequest", elem); }
            }
        }

    }

}
