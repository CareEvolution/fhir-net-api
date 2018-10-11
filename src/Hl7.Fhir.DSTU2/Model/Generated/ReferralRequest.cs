using System;
using System.Collections.Generic;
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
    /// A request for referral or transfer of care
    /// </summary>
    [FhirType("ReferralRequest", IsResource=true)]
    [DataContract]
    public partial class ReferralRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ReferralRequest; } }
        [NotMapped]
        public override string TypeName { get { return "ReferralRequest"; } }

        /// <summary>
        /// The status of the referral.
        /// (url: http://hl7.org/fhir/ValueSet/referralstatus)
        /// </summary>
        [FhirEnumeration("ReferralStatus")]
        public enum ReferralStatus
        {
            /// <summary>
            /// A draft referral that has yet to be send.
            /// (system: http://hl7.org/fhir/referralstatus)
            /// </summary>
            [EnumLiteral("draft", "http://hl7.org/fhir/referralstatus"), Description("Draft")]
            Draft,
            /// <summary>
            /// The referral has been transmitted, but not yet acknowledged by the recipient.
            /// (system: http://hl7.org/fhir/referralstatus)
            /// </summary>
            [EnumLiteral("requested", "http://hl7.org/fhir/referralstatus"), Description("Requested")]
            Requested,
            /// <summary>
            /// The referral has been acknowledged by the recipient, and is in the process of being actioned.
            /// (system: http://hl7.org/fhir/referralstatus)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/referralstatus"), Description("Active")]
            Active,
            /// <summary>
            /// The referral has been cancelled without being completed. For example it is no longer needed.
            /// (system: http://hl7.org/fhir/referralstatus)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/referralstatus"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// The recipient has agreed to deliver the care requested by the referral.
            /// (system: http://hl7.org/fhir/referralstatus)
            /// </summary>
            [EnumLiteral("accepted", "http://hl7.org/fhir/referralstatus"), Description("Accepted")]
            Accepted,
            /// <summary>
            /// The recipient has declined to accept the referral.
            /// (system: http://hl7.org/fhir/referralstatus)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/referralstatus"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// The referral has been completely actioned.
            /// (system: http://hl7.org/fhir/referralstatus)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/referralstatus"), Description("Completed")]
            Completed,
        }


        /// <summary>
        /// draft | requested | active | cancelled | accepted | rejected | completed
        /// </summary>
        [FhirElement("status", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ReferralStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ReferralStatus> _statusElement;

        /// <summary>
        /// draft | requested | active | cancelled | accepted | rejected | completed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ReferralStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<ReferralStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Date of creation/activation
        /// </summary>
        [FhirElement("date", InSummary=true, Order=110)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date of creation/activation
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
        /// Referral/Transition of care request type
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
        /// The clinical specialty (discipline) that the referral is requested for
        /// </summary>
        [FhirElement("specialty", Order=130)]
        [DataMember]
        public CodeableConcept Specialty
        {
            get { return _specialty; }
            set { _specialty = value; OnPropertyChanged("Specialty"); }
        }

        private CodeableConcept _specialty;

        /// <summary>
        /// Urgency of referral / transfer of care request
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept Priority
        {
            get { return _priority; }
            set { _priority = value; OnPropertyChanged("Priority"); }
        }

        private CodeableConcept _priority;

        /// <summary>
        /// Patient referred to care or transfer
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=150)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Requester of referral / transfer of care
        /// </summary>
        [FhirElement("requester", InSummary=true, Order=160)]
        [References("Practitioner","Organization","Patient")]
        [DataMember]
        public ResourceReference Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private ResourceReference _requester;

        /// <summary>
        /// Receiver of referral / transfer of care request
        /// </summary>
        [FhirElement("recipient", InSummary=true, Order=170)]
        [References("Practitioner","Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Recipient
        {
            get { if (_recipient == null) _recipient = new List<ResourceReference>(); return _recipient; }
            set { _recipient = value; OnPropertyChanged("Recipient"); }
        }

        private List<ResourceReference> _recipient;

        /// <summary>
        /// Originating encounter
        /// </summary>
        [FhirElement("encounter", Order=180)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Date referral/transfer of care request is sent
        /// </summary>
        [FhirElement("dateSent", InSummary=true, Order=190)]
        [DataMember]
        public FhirDateTime DateSentElement
        {
            get { return _dateSentElement; }
            set { _dateSentElement = value; OnPropertyChanged("DateSentElement"); }
        }

        private FhirDateTime _dateSentElement;

        /// <summary>
        /// Date referral/transfer of care request is sent
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateSent
        {
            get { return DateSentElement != null ? DateSentElement.Value : null; }
            set
            {
                if (value == null)
                    DateSentElement = null;
                else
                    DateSentElement = new FhirDateTime(value);
                OnPropertyChanged("DateSent");
            }
        }

        /// <summary>
        /// Reason for referral / transfer of care request
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=200)]
        [DataMember]
        public CodeableConcept Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private CodeableConcept _reason;

        /// <summary>
        /// A textual description of the referral
        /// </summary>
        [FhirElement("description", Order=210)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// A textual description of the referral
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new FhirString(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Actions requested as part of the referral
        /// </summary>
        [FhirElement("serviceRequested", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ServiceRequested
        {
            get { if (_serviceRequested == null) _serviceRequested = new List<CodeableConcept>(); return _serviceRequested; }
            set { _serviceRequested = value; OnPropertyChanged("ServiceRequested"); }
        }

        private List<CodeableConcept> _serviceRequested;

        /// <summary>
        /// Additonal information to support referral or transfer of care request
        /// </summary>
        [FhirElement("supportingInformation", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInformation
        {
            get { if (_supportingInformation == null) _supportingInformation = new List<ResourceReference>(); return _supportingInformation; }
            set { _supportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }

        private List<ResourceReference> _supportingInformation;

        /// <summary>
        /// Requested service(s) fulfillment time
        /// </summary>
        [FhirElement("fulfillmentTime", InSummary=true, Order=240)]
        [DataMember]
        public Period FulfillmentTime
        {
            get { return _fulfillmentTime; }
            set { _fulfillmentTime = value; OnPropertyChanged("FulfillmentTime"); }
        }

        private Period _fulfillmentTime;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ReferralRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (StatusElement != null) dest.StatusElement = (Code<ReferralStatus>)StatusElement.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Specialty != null) dest.Specialty = (CodeableConcept)Specialty.DeepCopy();
                if (Priority != null) dest.Priority = (CodeableConcept)Priority.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Requester != null) dest.Requester = (ResourceReference)Requester.DeepCopy();
                if (Recipient != null) dest.Recipient = new List<ResourceReference>(Recipient.DeepCopy());
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (DateSentElement != null) dest.DateSentElement = (FhirDateTime)DateSentElement.DeepCopy();
                if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (ServiceRequested != null) dest.ServiceRequested = new List<CodeableConcept>(ServiceRequested.DeepCopy());
                if (SupportingInformation != null) dest.SupportingInformation = new List<ResourceReference>(SupportingInformation.DeepCopy());
                if (FulfillmentTime != null) dest.FulfillmentTime = (Period)FulfillmentTime.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ReferralRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ReferralRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if (!DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(DateSentElement, otherT.DateSentElement)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(ServiceRequested, otherT.ServiceRequested)) return false;
            if (!DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.Matches(FulfillmentTime, otherT.FulfillmentTime)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ReferralRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(DateSentElement, otherT.DateSentElement)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(ServiceRequested, otherT.ServiceRequested)) return false;
            if (!DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.IsExactly(FulfillmentTime, otherT.FulfillmentTime)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (StatusElement != null) yield return StatusElement;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (DateElement != null) yield return DateElement;
                if (Type != null) yield return Type;
                if (Specialty != null) yield return Specialty;
                if (Priority != null) yield return Priority;
                if (Patient != null) yield return Patient;
                if (Requester != null) yield return Requester;
                foreach (var elem in Recipient) { if (elem != null) yield return elem; }
                if (Encounter != null) yield return Encounter;
                if (DateSentElement != null) yield return DateSentElement;
                if (Reason != null) yield return Reason;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in ServiceRequested) { if (elem != null) yield return elem; }
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
                if (FulfillmentTime != null) yield return FulfillmentTime;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (Specialty != null) yield return new ElementValue("specialty", Specialty);
                if (Priority != null) yield return new ElementValue("priority", Priority);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Requester != null) yield return new ElementValue("requester", Requester);
                foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", elem); }
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (DateSentElement != null) yield return new ElementValue("dateSent", DateSentElement);
                if (Reason != null) yield return new ElementValue("reason", Reason);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in ServiceRequested) { if (elem != null) yield return new ElementValue("serviceRequested", elem); }
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", elem); }
                if (FulfillmentTime != null) yield return new ElementValue("fulfillmentTime", FulfillmentTime);
            }
        }

    }

}
