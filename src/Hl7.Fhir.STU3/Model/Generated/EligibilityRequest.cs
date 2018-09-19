﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Determine insurance validity and scope of coverage
    /// </summary>
    [FhirType("EligibilityRequest", IsResource=true)]
    [DataContract]
    public partial class EligibilityRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.EligibilityRequest; } }
        [NotMapped]
        public override string TypeName { get { return "EligibilityRequest"; } }


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
        /// Desired processing priority
        /// </summary>
        [FhirElement("priority", Order=110)]
        [DataMember]
        public CodeableConcept Priority
        {
            get { return _priority; }
            set { _priority = value; OnPropertyChanged("Priority"); }
        }

        private CodeableConcept _priority;

        /// <summary>
        /// The subject of the Products and Services
        /// </summary>
        [FhirElement("patient", Order=120)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Estimated date or dates of Service
        /// </summary>
        [FhirElement("serviced", Order=130, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Date),typeof(Period))]
        [DataMember]
        public Element Serviced
        {
            get { return _serviced; }
            set { _serviced = value; OnPropertyChanged("Serviced"); }
        }

        private Element _serviced;

        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", Order=140)]
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
        /// Author
        /// </summary>
        [FhirElement("enterer", Order=150)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Enterer
        {
            get { return _enterer; }
            set { _enterer = value; OnPropertyChanged("Enterer"); }
        }

        private ResourceReference _enterer;

        /// <summary>
        /// Responsible practitioner
        /// </summary>
        [FhirElement("provider", Order=160)]
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
        [FhirElement("organization", Order=170)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private ResourceReference _organization;

        /// <summary>
        /// Target
        /// </summary>
        [FhirElement("insurer", Order=180)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Insurer
        {
            get { return _insurer; }
            set { _insurer = value; OnPropertyChanged("Insurer"); }
        }

        private ResourceReference _insurer;

        /// <summary>
        /// Servicing Facility
        /// </summary>
        [FhirElement("facility", Order=190)]
        [References("Location")]
        [DataMember]
        public ResourceReference Facility
        {
            get { return _facility; }
            set { _facility = value; OnPropertyChanged("Facility"); }
        }

        private ResourceReference _facility;

        /// <summary>
        /// Insurance or medical plan
        /// </summary>
        [FhirElement("coverage", Order=200)]
        [References("Coverage")]
        [DataMember]
        public ResourceReference Coverage
        {
            get { return _coverage; }
            set { _coverage = value; OnPropertyChanged("Coverage"); }
        }

        private ResourceReference _coverage;

        /// <summary>
        /// Business agreement
        /// </summary>
        [FhirElement("businessArrangement", Order=210)]
        [DataMember]
        public FhirString BusinessArrangementElement
        {
            get { return _businessArrangementElement; }
            set { _businessArrangementElement = value; OnPropertyChanged("BusinessArrangementElement"); }
        }

        private FhirString _businessArrangementElement;

        /// <summary>
        /// Business agreement
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string BusinessArrangement
        {
            get { return BusinessArrangementElement != null ? BusinessArrangementElement.Value : null; }
            set
            {
                if (value == null)
                    BusinessArrangementElement = null;
                else
                    BusinessArrangementElement = new FhirString(value);
                OnPropertyChanged("BusinessArrangement");
            }
        }

        /// <summary>
        /// Type of services covered
        /// </summary>
        [FhirElement("benefitCategory", Order=220)]
        [DataMember]
        public CodeableConcept BenefitCategory
        {
            get { return _benefitCategory; }
            set { _benefitCategory = value; OnPropertyChanged("BenefitCategory"); }
        }

        private CodeableConcept _benefitCategory;

        /// <summary>
        /// Detailed services covered within the type
        /// </summary>
        [FhirElement("benefitSubCategory", Order=230)]
        [DataMember]
        public CodeableConcept BenefitSubCategory
        {
            get { return _benefitSubCategory; }
            set { _benefitSubCategory = value; OnPropertyChanged("BenefitSubCategory"); }
        }

        private CodeableConcept _benefitSubCategory;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as EligibilityRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (Priority != null) dest.Priority = (CodeableConcept)Priority.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Serviced != null) dest.Serviced = (Element)Serviced.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Enterer != null) dest.Enterer = (ResourceReference)Enterer.DeepCopy();
                if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (Insurer != null) dest.Insurer = (ResourceReference)Insurer.DeepCopy();
                if (Facility != null) dest.Facility = (ResourceReference)Facility.DeepCopy();
                if (Coverage != null) dest.Coverage = (ResourceReference)Coverage.DeepCopy();
                if (BusinessArrangementElement != null) dest.BusinessArrangementElement = (FhirString)BusinessArrangementElement.DeepCopy();
                if (BenefitCategory != null) dest.BenefitCategory = (CodeableConcept)BenefitCategory.DeepCopy();
                if (BenefitSubCategory != null) dest.BenefitSubCategory = (CodeableConcept)BenefitSubCategory.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new EligibilityRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as EligibilityRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Serviced, otherT.Serviced)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.Matches(Facility, otherT.Facility)) return false;
            if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
            if (!DeepComparable.Matches(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
            if (!DeepComparable.Matches(BenefitCategory, otherT.BenefitCategory)) return false;
            if (!DeepComparable.Matches(BenefitSubCategory, otherT.BenefitSubCategory)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as EligibilityRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Serviced, otherT.Serviced)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.IsExactly(Facility, otherT.Facility)) return false;
            if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
            if (!DeepComparable.IsExactly(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
            if (!DeepComparable.IsExactly(BenefitCategory, otherT.BenefitCategory)) return false;
            if (!DeepComparable.IsExactly(BenefitSubCategory, otherT.BenefitSubCategory)) return false;

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
                if (Priority != null) yield return Priority;
                if (Patient != null) yield return Patient;
                if (Serviced != null) yield return Serviced;
                if (CreatedElement != null) yield return CreatedElement;
                if (Enterer != null) yield return Enterer;
                if (Provider != null) yield return Provider;
                if (Organization != null) yield return Organization;
                if (Insurer != null) yield return Insurer;
                if (Facility != null) yield return Facility;
                if (Coverage != null) yield return Coverage;
                if (BusinessArrangementElement != null) yield return BusinessArrangementElement;
                if (BenefitCategory != null) yield return BenefitCategory;
                if (BenefitSubCategory != null) yield return BenefitSubCategory;
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
                if (Priority != null) yield return new ElementValue("priority", Priority);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Serviced != null) yield return new ElementValue("serviced", Serviced);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Enterer != null) yield return new ElementValue("enterer", Enterer);
                if (Provider != null) yield return new ElementValue("provider", Provider);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                if (Insurer != null) yield return new ElementValue("insurer", Insurer);
                if (Facility != null) yield return new ElementValue("facility", Facility);
                if (Coverage != null) yield return new ElementValue("coverage", Coverage);
                if (BusinessArrangementElement != null) yield return new ElementValue("businessArrangement", BusinessArrangementElement);
                if (BenefitCategory != null) yield return new ElementValue("benefitCategory", BenefitCategory);
                if (BenefitSubCategory != null) yield return new ElementValue("benefitSubCategory", BenefitSubCategory);
            }
        }

    }

}