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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Detailed definition of a medicinal product, typically for uses other than direct patient care (e.g. regulatory use)
    /// </summary>
    [FhirType("MedicinalProduct", IsResource=true)]
    [DataContract]
    public partial class MedicinalProduct : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProduct; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProduct"; } }


        [FhirType("NameComponent")]
        [DataContract]
        public partial class NameComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "NameComponent"; } }

            /// <summary>
            /// The full product name
            /// </summary>
            [FhirElement("fullName", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString FullNameElement
            {
                get { return _fullNameElement; }
                set { _fullNameElement = value; OnPropertyChanged("FullNameElement"); }
            }

            private FhirString _fullNameElement;

            /// <summary>
            /// The full product name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string FullName
            {
                get { return FullNameElement != null ? FullNameElement.Value : null; }
                set
                {
                    if (value == null)
                        FullNameElement = null;
                    else
                        FullNameElement = new FhirString(value);
                    OnPropertyChanged("FullName");
                }
            }

            /// <summary>
            /// Coding words or phrases of the name
            /// </summary>
            [FhirElement("namePart", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<NamePartComponent> NamePart
            {
                get { if (_namePart==null) _namePart = new List<NamePartComponent>(); return _namePart; }
                set { _namePart = value; OnPropertyChanged("NamePart"); }
            }

            private List<NamePartComponent> _namePart;

            /// <summary>
            /// Country where the name applies
            /// </summary>
            [FhirElement("countryLanguage", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CountryLanguageComponent> CountryLanguage
            {
                get { if (_countryLanguage==null) _countryLanguage = new List<CountryLanguageComponent>(); return _countryLanguage; }
                set { _countryLanguage = value; OnPropertyChanged("CountryLanguage"); }
            }

            private List<CountryLanguageComponent> _countryLanguage;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NameComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (FullNameElement != null) dest.FullNameElement = (FhirString)FullNameElement.DeepCopy();
                    if (NamePart != null) dest.NamePart = new List<NamePartComponent>(NamePart.DeepCopy());
                    if (CountryLanguage != null) dest.CountryLanguage = new List<CountryLanguageComponent>(CountryLanguage.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new NameComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NameComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(FullNameElement, otherT.FullNameElement)) return false;
                if ( !DeepComparable.Matches(NamePart, otherT.NamePart)) return false;
                if ( !DeepComparable.Matches(CountryLanguage, otherT.CountryLanguage)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NameComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(FullNameElement, otherT.FullNameElement)) return false;
                if (!DeepComparable.IsExactly(NamePart, otherT.NamePart)) return false;
                if (!DeepComparable.IsExactly(CountryLanguage, otherT.CountryLanguage)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (FullNameElement != null) yield return FullNameElement;
                    foreach (var elem in NamePart) { if (elem != null) yield return elem; }
                    foreach (var elem in CountryLanguage) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (FullNameElement != null) yield return new ElementValue("fullName", FullNameElement);
                    foreach (var elem in NamePart) { if (elem != null) yield return new ElementValue("namePart", elem); }
                    foreach (var elem in CountryLanguage) { if (elem != null) yield return new ElementValue("countryLanguage", elem); }
                }
            }


        }


        [FhirType("NamePartComponent")]
        [DataContract]
        public partial class NamePartComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "NamePartComponent"; } }

            /// <summary>
            /// A fragment of a product name
            /// </summary>
            [FhirElement("part", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString PartElement
            {
                get { return _partElement; }
                set { _partElement = value; OnPropertyChanged("PartElement"); }
            }

            private FhirString _partElement;

            /// <summary>
            /// A fragment of a product name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Part
            {
                get { return PartElement != null ? PartElement.Value : null; }
                set
                {
                    if (value == null)
                        PartElement = null;
                    else
                        PartElement = new FhirString(value);
                    OnPropertyChanged("Part");
                }
            }

            /// <summary>
            /// Idenifying type for this part of the name (e.g. strength part)
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NamePartComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PartElement != null) dest.PartElement = (FhirString)PartElement.DeepCopy();
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new NamePartComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NamePartComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PartElement, otherT.PartElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NamePartComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PartElement, otherT.PartElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PartElement != null) yield return PartElement;
                    if (Type != null) yield return Type;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PartElement != null) yield return new ElementValue("part", PartElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                }
            }


        }


        [FhirType("CountryLanguageComponent")]
        [DataContract]
        public partial class CountryLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CountryLanguageComponent"; } }

            /// <summary>
            /// Country code for where this name applies
            /// </summary>
            [FhirElement("country", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Country
            {
                get { return _country; }
                set { _country = value; OnPropertyChanged("Country"); }
            }

            private CodeableConcept _country;

            /// <summary>
            /// Jurisdiction code for where this name applies
            /// </summary>
            [FhirElement("jurisdiction", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Jurisdiction
            {
                get { return _jurisdiction; }
                set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
            }

            private CodeableConcept _jurisdiction;

            /// <summary>
            /// Language code for this name
            /// </summary>
            [FhirElement("language", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Language
            {
                get { return _language; }
                set { _language = value; OnPropertyChanged("Language"); }
            }

            private CodeableConcept _language;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CountryLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Country != null) dest.Country = (CodeableConcept)Country.DeepCopy();
                    if (Jurisdiction != null) dest.Jurisdiction = (CodeableConcept)Jurisdiction.DeepCopy();
                    if (Language != null) dest.Language = (CodeableConcept)Language.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CountryLanguageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CountryLanguageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Country, otherT.Country)) return false;
                if (!DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
                if (!DeepComparable.Matches(Language, otherT.Language)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CountryLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Country, otherT.Country)) return false;
                if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
                if (!DeepComparable.IsExactly(Language, otherT.Language)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Country != null) yield return Country;
                    if (Jurisdiction != null) yield return Jurisdiction;
                    if (Language != null) yield return Language;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Country != null) yield return new ElementValue("country", Country);
                    if (Jurisdiction != null) yield return new ElementValue("jurisdiction", Jurisdiction);
                    if (Language != null) yield return new ElementValue("language", Language);
                }
            }


        }


        [FhirType("ManufacturingBusinessOperationComponent")]
        [DataContract]
        public partial class ManufacturingBusinessOperationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ManufacturingBusinessOperationComponent"; } }

            /// <summary>
            /// The type of manufacturing operation
            /// </summary>
            [FhirElement("operationType", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept OperationType
            {
                get { return _operationType; }
                set { _operationType = value; OnPropertyChanged("OperationType"); }
            }

            private CodeableConcept _operationType;

            /// <summary>
            /// Regulatory authorization reference number
            /// </summary>
            [FhirElement("authorisationReferenceNumber", InSummary=true, Order=50)]
            [DataMember]
            public Identifier AuthorisationReferenceNumber
            {
                get { return _authorisationReferenceNumber; }
                set { _authorisationReferenceNumber = value; OnPropertyChanged("AuthorisationReferenceNumber"); }
            }

            private Identifier _authorisationReferenceNumber;

            /// <summary>
            /// Regulatory authorization date
            /// </summary>
            [FhirElement("effectiveDate", InSummary=true, Order=60)]
            [DataMember]
            public FhirDateTime EffectiveDateElement
            {
                get { return _effectiveDateElement; }
                set { _effectiveDateElement = value; OnPropertyChanged("EffectiveDateElement"); }
            }

            private FhirDateTime _effectiveDateElement;

            /// <summary>
            /// Regulatory authorization date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string EffectiveDate
            {
                get { return EffectiveDateElement != null ? EffectiveDateElement.Value : null; }
                set
                {
                    if (value == null)
                        EffectiveDateElement = null;
                    else
                        EffectiveDateElement = new FhirDateTime(value);
                    OnPropertyChanged("EffectiveDate");
                }
            }

            /// <summary>
            /// To indicate if this proces is commercially confidential
            /// </summary>
            [FhirElement("confidentialityIndicator", InSummary=true, Order=70)]
            [DataMember]
            public CodeableConcept ConfidentialityIndicator
            {
                get { return _confidentialityIndicator; }
                set { _confidentialityIndicator = value; OnPropertyChanged("ConfidentialityIndicator"); }
            }

            private CodeableConcept _confidentialityIndicator;

            /// <summary>
            /// The manufacturer or establishment associated with the process
            /// </summary>
            [FhirElement("manufacturer", InSummary=true, Order=80)]
            [References("Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Manufacturer
            {
                get { if (_manufacturer==null) _manufacturer = new List<ResourceReference>(); return _manufacturer; }
                set { _manufacturer = value; OnPropertyChanged("Manufacturer"); }
            }

            private List<ResourceReference> _manufacturer;

            /// <summary>
            /// A regulator which oversees the operation
            /// </summary>
            [FhirElement("regulator", InSummary=true, Order=90)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Regulator
            {
                get { return _regulator; }
                set { _regulator = value; OnPropertyChanged("Regulator"); }
            }

            private ResourceReference _regulator;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManufacturingBusinessOperationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (OperationType != null) dest.OperationType = (CodeableConcept)OperationType.DeepCopy();
                    if (AuthorisationReferenceNumber != null) dest.AuthorisationReferenceNumber = (Identifier)AuthorisationReferenceNumber.DeepCopy();
                    if (EffectiveDateElement != null) dest.EffectiveDateElement = (FhirDateTime)EffectiveDateElement.DeepCopy();
                    if (ConfidentialityIndicator != null) dest.ConfidentialityIndicator = (CodeableConcept)ConfidentialityIndicator.DeepCopy();
                    if (Manufacturer != null) dest.Manufacturer = new List<ResourceReference>(Manufacturer.DeepCopy());
                    if (Regulator != null) dest.Regulator = (ResourceReference)Regulator.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ManufacturingBusinessOperationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ManufacturingBusinessOperationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(OperationType, otherT.OperationType)) return false;
                if (!DeepComparable.Matches(AuthorisationReferenceNumber, otherT.AuthorisationReferenceNumber)) return false;
                if (!DeepComparable.Matches(EffectiveDateElement, otherT.EffectiveDateElement)) return false;
                if (!DeepComparable.Matches(ConfidentialityIndicator, otherT.ConfidentialityIndicator)) return false;
                if ( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
                if (!DeepComparable.Matches(Regulator, otherT.Regulator)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManufacturingBusinessOperationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(OperationType, otherT.OperationType)) return false;
                if (!DeepComparable.IsExactly(AuthorisationReferenceNumber, otherT.AuthorisationReferenceNumber)) return false;
                if (!DeepComparable.IsExactly(EffectiveDateElement, otherT.EffectiveDateElement)) return false;
                if (!DeepComparable.IsExactly(ConfidentialityIndicator, otherT.ConfidentialityIndicator)) return false;
                if (!DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
                if (!DeepComparable.IsExactly(Regulator, otherT.Regulator)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (OperationType != null) yield return OperationType;
                    if (AuthorisationReferenceNumber != null) yield return AuthorisationReferenceNumber;
                    if (EffectiveDateElement != null) yield return EffectiveDateElement;
                    if (ConfidentialityIndicator != null) yield return ConfidentialityIndicator;
                    foreach (var elem in Manufacturer) { if (elem != null) yield return elem; }
                    if (Regulator != null) yield return Regulator;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (OperationType != null) yield return new ElementValue("operationType", OperationType);
                    if (AuthorisationReferenceNumber != null) yield return new ElementValue("authorisationReferenceNumber", AuthorisationReferenceNumber);
                    if (EffectiveDateElement != null) yield return new ElementValue("effectiveDate", EffectiveDateElement);
                    if (ConfidentialityIndicator != null) yield return new ElementValue("confidentialityIndicator", ConfidentialityIndicator);
                    foreach (var elem in Manufacturer) { if (elem != null) yield return new ElementValue("manufacturer", elem); }
                    if (Regulator != null) yield return new ElementValue("regulator", Regulator);
                }
            }


        }


        /// <summary>
        /// Business idenfifier for this product. Could be an MPID
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Regulatory type, e.g. Investigational or Authorized
        /// </summary>
        [FhirElement("type", InSummary=true, Order=100)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// The dose form for a single part product, or combined form of a multiple part product
        /// </summary>
        [FhirElement("combinedPharmaceuticalDoseForm", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept CombinedPharmaceuticalDoseForm
        {
            get { return _combinedPharmaceuticalDoseForm; }
            set { _combinedPharmaceuticalDoseForm = value; OnPropertyChanged("CombinedPharmaceuticalDoseForm"); }
        }

        private CodeableConcept _combinedPharmaceuticalDoseForm;

        /// <summary>
        /// Whether the Medicinal Product is subject to additional monitoring for regulatory reasons
        /// </summary>
        [FhirElement("additionalMonitoringIndicator", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept AdditionalMonitoringIndicator
        {
            get { return _additionalMonitoringIndicator; }
            set { _additionalMonitoringIndicator = value; OnPropertyChanged("AdditionalMonitoringIndicator"); }
        }

        private CodeableConcept _additionalMonitoringIndicator;

        /// <summary>
        /// Whether the Medicinal Product is subject to special measures for regulatory reasons
        /// </summary>
        [FhirElement("specialMeasures", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> SpecialMeasuresElement
        {
            get { if (_specialMeasuresElement==null) _specialMeasuresElement = new List<FhirString>(); return _specialMeasuresElement; }
            set { _specialMeasuresElement = value; OnPropertyChanged("SpecialMeasuresElement"); }
        }

        private List<FhirString> _specialMeasuresElement;

        /// <summary>
        /// Whether the Medicinal Product is subject to special measures for regulatory reasons
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> SpecialMeasures
        {
            get { return SpecialMeasuresElement != null ? SpecialMeasuresElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    SpecialMeasuresElement = null;
                else
                    SpecialMeasuresElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("SpecialMeasures");
            }
        }

        /// <summary>
        /// If authorised for use in children
        /// </summary>
        [FhirElement("paediatricUseIndicator", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept PaediatricUseIndicator
        {
            get { return _paediatricUseIndicator; }
            set { _paediatricUseIndicator = value; OnPropertyChanged("PaediatricUseIndicator"); }
        }

        private CodeableConcept _paediatricUseIndicator;

        /// <summary>
        /// Indicates if the medicinal product has an orphan designation for the treatment of a rare disease
        /// </summary>
        [FhirElement("orphanDesignationStatus", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept OrphanDesignationStatus
        {
            get { return _orphanDesignationStatus; }
            set { _orphanDesignationStatus = value; OnPropertyChanged("OrphanDesignationStatus"); }
        }

        private CodeableConcept _orphanDesignationStatus;

        /// <summary>
        /// Allows the product to be classified by various systems
        /// </summary>
        [FhirElement("productClassification", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ProductClassification
        {
            get { if (_productClassification==null) _productClassification = new List<CodeableConcept>(); return _productClassification; }
            set { _productClassification = value; OnPropertyChanged("ProductClassification"); }
        }

        private List<CodeableConcept> _productClassification;

        /// <summary>
        /// Product regulatory authorization
        /// </summary>
        [FhirElement("marketingAuthorization", InSummary=true, Order=170)]
        [References("MedicinalProductAuthorization")]
        [DataMember]
        public ResourceReference MarketingAuthorization
        {
            get { return _marketingAuthorization; }
            set { _marketingAuthorization = value; OnPropertyChanged("MarketingAuthorization"); }
        }

        private ResourceReference _marketingAuthorization;

        /// <summary>
        /// Package representation for the product
        /// </summary>
        [FhirElement("packagedMedicinalProduct", InSummary=true, Order=180)]
        [References("MedicinalProductPackaged")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PackagedMedicinalProduct
        {
            get { if (_packagedMedicinalProduct==null) _packagedMedicinalProduct = new List<ResourceReference>(); return _packagedMedicinalProduct; }
            set { _packagedMedicinalProduct = value; OnPropertyChanged("PackagedMedicinalProduct"); }
        }

        private List<ResourceReference> _packagedMedicinalProduct;

        /// <summary>
        /// Pharmaceutical aspects of product
        /// </summary>
        [FhirElement("pharmaceuticalProduct", InSummary=true, Order=190)]
        [References("MedicinalProductPharmaceutical")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PharmaceuticalProduct
        {
            get { if (_pharmaceuticalProduct==null) _pharmaceuticalProduct = new List<ResourceReference>(); return _pharmaceuticalProduct; }
            set { _pharmaceuticalProduct = value; OnPropertyChanged("PharmaceuticalProduct"); }
        }

        private List<ResourceReference> _pharmaceuticalProduct;

        /// <summary>
        /// Clinical particulars, indications etc.
        /// </summary>
        [FhirElement("clinicalParticulars", InSummary=true, Order=200)]
        [References("MedicinalProductClinicals")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ClinicalParticulars
        {
            get { if (_clinicalParticulars==null) _clinicalParticulars = new List<ResourceReference>(); return _clinicalParticulars; }
            set { _clinicalParticulars = value; OnPropertyChanged("ClinicalParticulars"); }
        }

        private List<ResourceReference> _clinicalParticulars;

        /// <summary>
        /// Supporting documentation, typically for regulatory submission
        /// </summary>
        [FhirElement("attachedDocument", InSummary=true, Order=210)]
        [References("DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> AttachedDocument
        {
            get { if (_attachedDocument==null) _attachedDocument = new List<ResourceReference>(); return _attachedDocument; }
            set { _attachedDocument = value; OnPropertyChanged("AttachedDocument"); }
        }

        private List<ResourceReference> _attachedDocument;

        /// <summary>
        /// A master file for to the medicinal product (e.g. Pharmacovigilance System Master File)
        /// </summary>
        [FhirElement("masterFile", InSummary=true, Order=220)]
        [References("DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> MasterFile
        {
            get { if (_masterFile==null) _masterFile = new List<ResourceReference>(); return _masterFile; }
            set { _masterFile = value; OnPropertyChanged("MasterFile"); }
        }

        private List<ResourceReference> _masterFile;

        /// <summary>
        /// The product's name, including full name and possibly coded parts
        /// </summary>
        [FhirElement("name", InSummary=true, Order=230)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<NameComponent> Name
        {
            get { if (_name==null) _name = new List<NameComponent>(); return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        private List<NameComponent> _name;

        /// <summary>
        /// Reference to another product, e.g. for linking authorised to investigational product
        /// </summary>
        [FhirElement("crossReference", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> CrossReference
        {
            get { if (_crossReference==null) _crossReference = new List<Identifier>(); return _crossReference; }
            set { _crossReference = value; OnPropertyChanged("CrossReference"); }
        }

        private List<Identifier> _crossReference;

        /// <summary>
        /// An operation applied to the product, for manufacturing or adminsitrative purpose
        /// </summary>
        [FhirElement("manufacturingBusinessOperation", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ManufacturingBusinessOperationComponent> ManufacturingBusinessOperation
        {
            get { if (_manufacturingBusinessOperation==null) _manufacturingBusinessOperation = new List<ManufacturingBusinessOperationComponent>(); return _manufacturingBusinessOperation; }
            set { _manufacturingBusinessOperation = value; OnPropertyChanged("ManufacturingBusinessOperation"); }
        }

        private List<ManufacturingBusinessOperationComponent> _manufacturingBusinessOperation;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProduct;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (CombinedPharmaceuticalDoseForm != null) dest.CombinedPharmaceuticalDoseForm = (CodeableConcept)CombinedPharmaceuticalDoseForm.DeepCopy();
                if (AdditionalMonitoringIndicator != null) dest.AdditionalMonitoringIndicator = (CodeableConcept)AdditionalMonitoringIndicator.DeepCopy();
                if (SpecialMeasuresElement != null) dest.SpecialMeasuresElement = new List<FhirString>(SpecialMeasuresElement.DeepCopy());
                if (PaediatricUseIndicator != null) dest.PaediatricUseIndicator = (CodeableConcept)PaediatricUseIndicator.DeepCopy();
                if (OrphanDesignationStatus != null) dest.OrphanDesignationStatus = (CodeableConcept)OrphanDesignationStatus.DeepCopy();
                if (ProductClassification != null) dest.ProductClassification = new List<CodeableConcept>(ProductClassification.DeepCopy());
                if (MarketingAuthorization != null) dest.MarketingAuthorization = (ResourceReference)MarketingAuthorization.DeepCopy();
                if (PackagedMedicinalProduct != null) dest.PackagedMedicinalProduct = new List<ResourceReference>(PackagedMedicinalProduct.DeepCopy());
                if (PharmaceuticalProduct != null) dest.PharmaceuticalProduct = new List<ResourceReference>(PharmaceuticalProduct.DeepCopy());
                if (ClinicalParticulars != null) dest.ClinicalParticulars = new List<ResourceReference>(ClinicalParticulars.DeepCopy());
                if (AttachedDocument != null) dest.AttachedDocument = new List<ResourceReference>(AttachedDocument.DeepCopy());
                if (MasterFile != null) dest.MasterFile = new List<ResourceReference>(MasterFile.DeepCopy());
                if (Name != null) dest.Name = new List<NameComponent>(Name.DeepCopy());
                if (CrossReference != null) dest.CrossReference = new List<Identifier>(CrossReference.DeepCopy());
                if (ManufacturingBusinessOperation != null) dest.ManufacturingBusinessOperation = new List<ManufacturingBusinessOperationComponent>(ManufacturingBusinessOperation.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicinalProduct());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicinalProduct;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(CombinedPharmaceuticalDoseForm, otherT.CombinedPharmaceuticalDoseForm)) return false;
            if (!DeepComparable.Matches(AdditionalMonitoringIndicator, otherT.AdditionalMonitoringIndicator)) return false;
            if ( !DeepComparable.Matches(SpecialMeasuresElement, otherT.SpecialMeasuresElement)) return false;
            if (!DeepComparable.Matches(PaediatricUseIndicator, otherT.PaediatricUseIndicator)) return false;
            if (!DeepComparable.Matches(OrphanDesignationStatus, otherT.OrphanDesignationStatus)) return false;
            if ( !DeepComparable.Matches(ProductClassification, otherT.ProductClassification)) return false;
            if (!DeepComparable.Matches(MarketingAuthorization, otherT.MarketingAuthorization)) return false;
            if ( !DeepComparable.Matches(PackagedMedicinalProduct, otherT.PackagedMedicinalProduct)) return false;
            if ( !DeepComparable.Matches(PharmaceuticalProduct, otherT.PharmaceuticalProduct)) return false;
            if ( !DeepComparable.Matches(ClinicalParticulars, otherT.ClinicalParticulars)) return false;
            if ( !DeepComparable.Matches(AttachedDocument, otherT.AttachedDocument)) return false;
            if ( !DeepComparable.Matches(MasterFile, otherT.MasterFile)) return false;
            if ( !DeepComparable.Matches(Name, otherT.Name)) return false;
            if ( !DeepComparable.Matches(CrossReference, otherT.CrossReference)) return false;
            if ( !DeepComparable.Matches(ManufacturingBusinessOperation, otherT.ManufacturingBusinessOperation)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProduct;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(CombinedPharmaceuticalDoseForm, otherT.CombinedPharmaceuticalDoseForm)) return false;
            if (!DeepComparable.IsExactly(AdditionalMonitoringIndicator, otherT.AdditionalMonitoringIndicator)) return false;
            if (!DeepComparable.IsExactly(SpecialMeasuresElement, otherT.SpecialMeasuresElement)) return false;
            if (!DeepComparable.IsExactly(PaediatricUseIndicator, otherT.PaediatricUseIndicator)) return false;
            if (!DeepComparable.IsExactly(OrphanDesignationStatus, otherT.OrphanDesignationStatus)) return false;
            if (!DeepComparable.IsExactly(ProductClassification, otherT.ProductClassification)) return false;
            if (!DeepComparable.IsExactly(MarketingAuthorization, otherT.MarketingAuthorization)) return false;
            if (!DeepComparable.IsExactly(PackagedMedicinalProduct, otherT.PackagedMedicinalProduct)) return false;
            if (!DeepComparable.IsExactly(PharmaceuticalProduct, otherT.PharmaceuticalProduct)) return false;
            if (!DeepComparable.IsExactly(ClinicalParticulars, otherT.ClinicalParticulars)) return false;
            if (!DeepComparable.IsExactly(AttachedDocument, otherT.AttachedDocument)) return false;
            if (!DeepComparable.IsExactly(MasterFile, otherT.MasterFile)) return false;
            if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if (!DeepComparable.IsExactly(CrossReference, otherT.CrossReference)) return false;
            if (!DeepComparable.IsExactly(ManufacturingBusinessOperation, otherT.ManufacturingBusinessOperation)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (Type != null) yield return Type;
                if (CombinedPharmaceuticalDoseForm != null) yield return CombinedPharmaceuticalDoseForm;
                if (AdditionalMonitoringIndicator != null) yield return AdditionalMonitoringIndicator;
                foreach (var elem in SpecialMeasuresElement) { if (elem != null) yield return elem; }
                if (PaediatricUseIndicator != null) yield return PaediatricUseIndicator;
                if (OrphanDesignationStatus != null) yield return OrphanDesignationStatus;
                foreach (var elem in ProductClassification) { if (elem != null) yield return elem; }
                if (MarketingAuthorization != null) yield return MarketingAuthorization;
                foreach (var elem in PackagedMedicinalProduct) { if (elem != null) yield return elem; }
                foreach (var elem in PharmaceuticalProduct) { if (elem != null) yield return elem; }
                foreach (var elem in ClinicalParticulars) { if (elem != null) yield return elem; }
                foreach (var elem in AttachedDocument) { if (elem != null) yield return elem; }
                foreach (var elem in MasterFile) { if (elem != null) yield return elem; }
                foreach (var elem in Name) { if (elem != null) yield return elem; }
                foreach (var elem in CrossReference) { if (elem != null) yield return elem; }
                foreach (var elem in ManufacturingBusinessOperation) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (Type != null) yield return new ElementValue("type", Type);
                if (CombinedPharmaceuticalDoseForm != null) yield return new ElementValue("combinedPharmaceuticalDoseForm", CombinedPharmaceuticalDoseForm);
                if (AdditionalMonitoringIndicator != null) yield return new ElementValue("additionalMonitoringIndicator", AdditionalMonitoringIndicator);
                foreach (var elem in SpecialMeasuresElement) { if (elem != null) yield return new ElementValue("specialMeasures", elem); }
                if (PaediatricUseIndicator != null) yield return new ElementValue("paediatricUseIndicator", PaediatricUseIndicator);
                if (OrphanDesignationStatus != null) yield return new ElementValue("orphanDesignationStatus", OrphanDesignationStatus);
                foreach (var elem in ProductClassification) { if (elem != null) yield return new ElementValue("productClassification", elem); }
                if (MarketingAuthorization != null) yield return new ElementValue("marketingAuthorization", MarketingAuthorization);
                foreach (var elem in PackagedMedicinalProduct) { if (elem != null) yield return new ElementValue("packagedMedicinalProduct", elem); }
                foreach (var elem in PharmaceuticalProduct) { if (elem != null) yield return new ElementValue("pharmaceuticalProduct", elem); }
                foreach (var elem in ClinicalParticulars) { if (elem != null) yield return new ElementValue("clinicalParticulars", elem); }
                foreach (var elem in AttachedDocument) { if (elem != null) yield return new ElementValue("attachedDocument", elem); }
                foreach (var elem in MasterFile) { if (elem != null) yield return new ElementValue("masterFile", elem); }
                foreach (var elem in Name) { if (elem != null) yield return new ElementValue("name", elem); }
                foreach (var elem in CrossReference) { if (elem != null) yield return new ElementValue("crossReference", elem); }
                foreach (var elem in ManufacturingBusinessOperation) { if (elem != null) yield return new ElementValue("manufacturingBusinessOperation", elem); }
            }
        }

    }

}
