﻿using System;
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
    /// PaymentNotice request
    /// </summary>
    [FhirType("PaymentNotice", IsResource=true)]
    [DataContract]
    public partial class PaymentNotice : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.PaymentNotice; } }
        [NotMapped]
        public override string TypeName { get { return "PaymentNotice"; } }


        /// <summary>
        /// Business Identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Resource version
        /// </summary>
        [FhirElement("ruleset", InSummary=true, Order=100)]
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
        [FhirElement("originalRuleset", InSummary=true, Order=110)]
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
        [FhirElement("created", InSummary=true, Order=120)]
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
        /// Insurer or Regulatory body
        /// </summary>
        [FhirElement("target", InSummary=true, Order=130)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Target
        {
            get { return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private ResourceReference _target;

        /// <summary>
        /// Responsible practitioner
        /// </summary>
        [FhirElement("provider", InSummary=true, Order=140)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Provider
        {
            get { return _provider; }
            set { _provider = value; OnPropertyChanged("Provider"); }
        }

        private ResourceReference _provider;

        /// <summary>
        /// Responsible organization
        /// </summary>
        [FhirElement("organization", InSummary=true, Order=150)]
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
        [FhirElement("request", InSummary=true, Order=160)]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// Response reference
        /// </summary>
        [FhirElement("response", InSummary=true, Order=170)]
        [DataMember]
        public ResourceReference Response
        {
            get { return _response; }
            set { _response = value; OnPropertyChanged("Response"); }
        }

        private ResourceReference _response;

        /// <summary>
        /// Status of the payment
        /// </summary>
        [FhirElement("paymentStatus", InSummary=true, Order=180)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Coding PaymentStatus
        {
            get { return _paymentStatus; }
            set { _paymentStatus = value; OnPropertyChanged("PaymentStatus"); }
        }

        private Coding _paymentStatus;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as PaymentNotice;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Ruleset != null) dest.Ruleset = (Coding)Ruleset.DeepCopy();
                if (OriginalRuleset != null) dest.OriginalRuleset = (Coding)OriginalRuleset.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Target != null) dest.Target = (ResourceReference)Target.DeepCopy();
                if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (Response != null) dest.Response = (ResourceReference)Response.DeepCopy();
                if (PaymentStatus != null) dest.PaymentStatus = (Coding)PaymentStatus.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new PaymentNotice());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as PaymentNotice;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.Matches(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Target, otherT.Target)) return false;
            if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(Response, otherT.Response)) return false;
            if (!DeepComparable.Matches(PaymentStatus, otherT.PaymentStatus)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as PaymentNotice;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.IsExactly(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(Response, otherT.Response)) return false;
            if (!DeepComparable.IsExactly(PaymentStatus, otherT.PaymentStatus)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Ruleset != null) yield return Ruleset;
                if (OriginalRuleset != null) yield return OriginalRuleset;
                if (CreatedElement != null) yield return CreatedElement;
                if (Target != null) yield return Target;
                if (Provider != null) yield return Provider;
                if (Organization != null) yield return Organization;
                if (Request != null) yield return Request;
                if (Response != null) yield return Response;
                if (PaymentStatus != null) yield return PaymentStatus;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Ruleset != null) yield return new ElementValue("ruleset", Ruleset);
                if (OriginalRuleset != null) yield return new ElementValue("originalRuleset", OriginalRuleset);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Target != null) yield return new ElementValue("target", Target);
                if (Provider != null) yield return new ElementValue("provider", Provider);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                if (Request != null) yield return new ElementValue("request", Request);
                if (Response != null) yield return new ElementValue("response", Response);
                if (PaymentStatus != null) yield return new ElementValue("paymentStatus", PaymentStatus);
            }
        }

    }

}
