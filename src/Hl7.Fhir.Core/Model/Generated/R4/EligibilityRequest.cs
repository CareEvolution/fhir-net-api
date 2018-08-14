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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Determine insurance validity and scope of coverage
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "EligibilityRequest", IsResource=true)]
    [DataContract]
    public partial class EligibilityRequest : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.EligibilityRequest; } }
        [NotMapped]
        public override string TypeName { get { return "EligibilityRequest"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "AuthorizationComponent")]
        [DataContract]
        public partial class AuthorizationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AuthorizationComponent"; } }
            
            /// <summary>
            /// Procedure sequence for reference
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt SequenceElement
            {
                get { return _SequenceElement; }
                set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _SequenceElement;
            
            /// <summary>
            /// Procedure sequence for reference
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
            /// Billing Code
            /// </summary>
            [FhirElement("service", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Service
            {
                get { return _Service; }
                set { _Service = value; OnPropertyChanged("Service"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Service;
            
            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Modifier
            {
                get { if(_Modifier==null) _Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Modifier; }
                set { _Modifier = value; OnPropertyChanged("Modifier"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Modifier;
            
            /// <summary>
            /// Count of products or services
            /// </summary>
            [FhirElement("quantity", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.R4.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Fee, charge or cost per point
            /// </summary>
            [FhirElement("unitPrice", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money UnitPrice
            {
                get { return _UnitPrice; }
                set { _UnitPrice = value; OnPropertyChanged("UnitPrice"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _UnitPrice;
            
            /// <summary>
            /// Servicing Facility
            /// </summary>
            [FhirElement("facility", Order=90)]
            [CLSCompliant(false)]
            [References("Location","Organization")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Facility
            {
                get { return _Facility; }
                set { _Facility = value; OnPropertyChanged("Facility"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Facility;
            
            /// <summary>
            /// List of Diagnosis
            /// </summary>
            [FhirElement("diagnosis", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DiagnosisComponent> Diagnosis
            {
                get { if(_Diagnosis==null) _Diagnosis = new List<DiagnosisComponent>(); return _Diagnosis; }
                set { _Diagnosis = value; OnPropertyChanged("Diagnosis"); }
            }
            
            private List<DiagnosisComponent> _Diagnosis;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AuthorizationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.R4.PositiveInt)SequenceElement.DeepCopy();
                    if(Service != null) dest.Service = (Hl7.Fhir.Model.R4.CodeableConcept)Service.DeepCopy();
                    if(Modifier != null) dest.Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Modifier.DeepCopy());
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.R4.SimpleQuantity)Quantity.DeepCopy();
                    if(UnitPrice != null) dest.UnitPrice = (Hl7.Fhir.Model.R4.Money)UnitPrice.DeepCopy();
                    if(Facility != null) dest.Facility = (Hl7.Fhir.Model.R4.ResourceReference)Facility.DeepCopy();
                    if(Diagnosis != null) dest.Diagnosis = new List<DiagnosisComponent>(Diagnosis.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AuthorizationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AuthorizationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.Matches(Service, otherT.Service)) return false;
                if( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.Matches(Facility, otherT.Facility)) return false;
                if( !DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AuthorizationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if( !DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.IsExactly(Facility, otherT.Facility)) return false;
                if( !DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (Service != null) yield return Service;
                    foreach (var elem in Modifier) { if (elem != null) yield return elem; }
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (Facility != null) yield return Facility;
                    foreach (var elem in Diagnosis) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", false, SequenceElement);
                    if (Service != null) yield return new ElementValue("service", false, Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", true, elem); }
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", false, UnitPrice);
                    if (Facility != null) yield return new ElementValue("facility", false, Facility);
                    foreach (var elem in Diagnosis) { if (elem != null) yield return new ElementValue("diagnosis", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DiagnosisComponent")]
        [DataContract]
        public partial class DiagnosisComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DiagnosisComponent"; } }
            
            /// <summary>
            /// Patient's diagnosis
            /// </summary>
            [FhirElement("diagnosis", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.CodeableConcept),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Diagnosis
            {
                get { return _Diagnosis; }
                set { _Diagnosis = value; OnPropertyChanged("Diagnosis"); }
            }
            
            private Hl7.Fhir.Model.Element _Diagnosis;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DiagnosisComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Diagnosis != null) dest.Diagnosis = (Hl7.Fhir.Model.Element)Diagnosis.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DiagnosisComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DiagnosisComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DiagnosisComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Diagnosis != null) yield return Diagnosis;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Diagnosis != null) yield return new ElementValue("diagnosis", false, Diagnosis);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Business Identifier
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Identifier> _Identifier;
        
        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _StatusElement;
        
        /// <summary>
        /// active | cancelled | draft | entered-in-error
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
        /// Desired processing priority
        /// </summary>
        [FhirElement("priority", Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Priority
        {
            get { return _Priority; }
            set { _Priority = value; OnPropertyChanged("Priority"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Priority;
        
        /// <summary>
        /// The subject of the Products and Services
        /// </summary>
        [FhirElement("patient", Order=120)]
        [CLSCompliant(false)]
        [References("Patient")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Patient;
        
        /// <summary>
        /// Estimated date or dates of Service
        /// </summary>
        [FhirElement("serviced", Order=130, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.R4.Date),typeof(Hl7.Fhir.Model.R4.Period))]
        [DataMember]
        public Hl7.Fhir.Model.Element Serviced
        {
            get { return _Serviced; }
            set { _Serviced = value; OnPropertyChanged("Serviced"); }
        }
        
        private Hl7.Fhir.Model.Element _Serviced;
        
        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime CreatedElement
        {
            get { return _CreatedElement; }
            set { _CreatedElement = value; OnPropertyChanged("CreatedElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _CreatedElement;
        
        /// <summary>
        /// Creation date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if (value == null)
                    CreatedElement = null;
                else
                    CreatedElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }
        
        /// <summary>
        /// Author
        /// </summary>
        [FhirElement("enterer", Order=150)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Enterer
        {
            get { return _Enterer; }
            set { _Enterer = value; OnPropertyChanged("Enterer"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Enterer;
        
        /// <summary>
        /// Responsible practitioner
        /// </summary>
        [FhirElement("provider", Order=160)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Organization")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Provider
        {
            get { return _Provider; }
            set { _Provider = value; OnPropertyChanged("Provider"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Provider;
        
        /// <summary>
        /// Target
        /// </summary>
        [FhirElement("insurer", Order=170)]
        [CLSCompliant(false)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Insurer
        {
            get { return _Insurer; }
            set { _Insurer = value; OnPropertyChanged("Insurer"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Insurer;
        
        /// <summary>
        /// Servicing Facility
        /// </summary>
        [FhirElement("facility", Order=180)]
        [CLSCompliant(false)]
        [References("Location")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Facility
        {
            get { return _Facility; }
            set { _Facility = value; OnPropertyChanged("Facility"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Facility;
        
        /// <summary>
        /// Insurance or medical plan
        /// </summary>
        [FhirElement("coverage", Order=190)]
        [CLSCompliant(false)]
        [References("Coverage")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Coverage
        {
            get { return _Coverage; }
            set { _Coverage = value; OnPropertyChanged("Coverage"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Coverage;
        
        /// <summary>
        /// Business agreement
        /// </summary>
        [FhirElement("businessArrangement", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString BusinessArrangementElement
        {
            get { return _BusinessArrangementElement; }
            set { _BusinessArrangementElement = value; OnPropertyChanged("BusinessArrangementElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _BusinessArrangementElement;
        
        /// <summary>
        /// Business agreement
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string BusinessArrangement
        {
            get { return BusinessArrangementElement != null ? BusinessArrangementElement.Value : null; }
            set
            {
                if (value == null)
                    BusinessArrangementElement = null;
                else
                    BusinessArrangementElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("BusinessArrangement");
            }
        }
        
        /// <summary>
        /// Type of services covered
        /// </summary>
        [FhirElement("benefitCategory", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept BenefitCategory
        {
            get { return _BenefitCategory; }
            set { _BenefitCategory = value; OnPropertyChanged("BenefitCategory"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _BenefitCategory;
        
        /// <summary>
        /// Detailed services covered within the type
        /// </summary>
        [FhirElement("benefitSubCategory", Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept BenefitSubCategory
        {
            get { return _BenefitSubCategory; }
            set { _BenefitSubCategory = value; OnPropertyChanged("BenefitSubCategory"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _BenefitSubCategory;
        
        /// <summary>
        /// Services which may require prior authorization
        /// </summary>
        [FhirElement("authorization", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AuthorizationComponent> Authorization
        {
            get { if(_Authorization==null) _Authorization = new List<AuthorizationComponent>(); return _Authorization; }
            set { _Authorization = value; OnPropertyChanged("Authorization"); }
        }
        
        private List<AuthorizationComponent> _Authorization;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as EligibilityRequest;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(Priority != null) dest.Priority = (Hl7.Fhir.Model.R4.CodeableConcept)Priority.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.R4.ResourceReference)Patient.DeepCopy();
                if(Serviced != null) dest.Serviced = (Hl7.Fhir.Model.Element)Serviced.DeepCopy();
                if(CreatedElement != null) dest.CreatedElement = (Hl7.Fhir.Model.R4.FhirDateTime)CreatedElement.DeepCopy();
                if(Enterer != null) dest.Enterer = (Hl7.Fhir.Model.R4.ResourceReference)Enterer.DeepCopy();
                if(Provider != null) dest.Provider = (Hl7.Fhir.Model.R4.ResourceReference)Provider.DeepCopy();
                if(Insurer != null) dest.Insurer = (Hl7.Fhir.Model.R4.ResourceReference)Insurer.DeepCopy();
                if(Facility != null) dest.Facility = (Hl7.Fhir.Model.R4.ResourceReference)Facility.DeepCopy();
                if(Coverage != null) dest.Coverage = (Hl7.Fhir.Model.R4.ResourceReference)Coverage.DeepCopy();
                if(BusinessArrangementElement != null) dest.BusinessArrangementElement = (Hl7.Fhir.Model.FhirString)BusinessArrangementElement.DeepCopy();
                if(BenefitCategory != null) dest.BenefitCategory = (Hl7.Fhir.Model.R4.CodeableConcept)BenefitCategory.DeepCopy();
                if(BenefitSubCategory != null) dest.BenefitSubCategory = (Hl7.Fhir.Model.R4.CodeableConcept)BenefitSubCategory.DeepCopy();
                if(Authorization != null) dest.Authorization = new List<AuthorizationComponent>(Authorization.DeepCopy());
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Serviced, otherT.Serviced)) return false;
            if( !DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.Matches(Enterer, otherT.Enterer)) return false;
            if( !DeepComparable.Matches(Provider, otherT.Provider)) return false;
            if( !DeepComparable.Matches(Insurer, otherT.Insurer)) return false;
            if( !DeepComparable.Matches(Facility, otherT.Facility)) return false;
            if( !DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
            if( !DeepComparable.Matches(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
            if( !DeepComparable.Matches(BenefitCategory, otherT.BenefitCategory)) return false;
            if( !DeepComparable.Matches(BenefitSubCategory, otherT.BenefitSubCategory)) return false;
            if( !DeepComparable.Matches(Authorization, otherT.Authorization)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as EligibilityRequest;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Serviced, otherT.Serviced)) return false;
            if( !DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.IsExactly(Enterer, otherT.Enterer)) return false;
            if( !DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
            if( !DeepComparable.IsExactly(Insurer, otherT.Insurer)) return false;
            if( !DeepComparable.IsExactly(Facility, otherT.Facility)) return false;
            if( !DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
            if( !DeepComparable.IsExactly(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
            if( !DeepComparable.IsExactly(BenefitCategory, otherT.BenefitCategory)) return false;
            if( !DeepComparable.IsExactly(BenefitSubCategory, otherT.BenefitSubCategory)) return false;
            if( !DeepComparable.IsExactly(Authorization, otherT.Authorization)) return false;
        
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
                if (Insurer != null) yield return Insurer;
                if (Facility != null) yield return Facility;
                if (Coverage != null) yield return Coverage;
                if (BusinessArrangementElement != null) yield return BusinessArrangementElement;
                if (BenefitCategory != null) yield return BenefitCategory;
                if (BenefitSubCategory != null) yield return BenefitSubCategory;
                foreach (var elem in Authorization) { if (elem != null) yield return elem; }
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
                if (Priority != null) yield return new ElementValue("priority", false, Priority);
                if (Patient != null) yield return new ElementValue("patient", false, Patient);
                if (Serviced != null) yield return new ElementValue("serviced", false, Serviced);
                if (CreatedElement != null) yield return new ElementValue("created", false, CreatedElement);
                if (Enterer != null) yield return new ElementValue("enterer", false, Enterer);
                if (Provider != null) yield return new ElementValue("provider", false, Provider);
                if (Insurer != null) yield return new ElementValue("insurer", false, Insurer);
                if (Facility != null) yield return new ElementValue("facility", false, Facility);
                if (Coverage != null) yield return new ElementValue("coverage", false, Coverage);
                if (BusinessArrangementElement != null) yield return new ElementValue("businessArrangement", false, BusinessArrangementElement);
                if (BenefitCategory != null) yield return new ElementValue("benefitCategory", false, BenefitCategory);
                if (BenefitSubCategory != null) yield return new ElementValue("benefitSubCategory", false, BenefitSubCategory);
                foreach (var elem in Authorization) { if (elem != null) yield return new ElementValue("authorization", true, elem); }
            }
        }
    
    }

}
