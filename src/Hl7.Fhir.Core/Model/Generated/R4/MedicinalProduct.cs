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
    /// Detailed definition of a medicinal product, typically for uses other than direct patient care (e.g. regulatory use)
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "MedicinalProduct", IsResource=true)]
    [DataContract]
    public partial class MedicinalProduct : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProduct; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProduct"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "NameComponent")]
        [DataContract]
        public partial class NameComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NameComponent"; } }
            
            /// <summary>
            /// The full product name
            /// </summary>
            [FhirElement("fullName", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString FullNameElement
            {
                get { return _FullNameElement; }
                set { _FullNameElement = value; OnPropertyChanged("FullNameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _FullNameElement;
            
            /// <summary>
            /// The full product name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string FullName
            {
                get { return FullNameElement != null ? FullNameElement.Value : null; }
                set
                {
                    if (value == null)
                        FullNameElement = null;
                    else
                        FullNameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("FullName");
                }
            }
            
            /// <summary>
            /// Coding words or phrases of the name
            /// </summary>
            [FhirElement("namePart", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<NamePartComponent> NamePart
            {
                get { if(_NamePart==null) _NamePart = new List<NamePartComponent>(); return _NamePart; }
                set { _NamePart = value; OnPropertyChanged("NamePart"); }
            }
            
            private List<NamePartComponent> _NamePart;
            
            /// <summary>
            /// Country where the name applies
            /// </summary>
            [FhirElement("countryLanguage", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CountryLanguageComponent> CountryLanguage
            {
                get { if(_CountryLanguage==null) _CountryLanguage = new List<CountryLanguageComponent>(); return _CountryLanguage; }
                set { _CountryLanguage = value; OnPropertyChanged("CountryLanguage"); }
            }
            
            private List<CountryLanguageComponent> _CountryLanguage;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NameComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(FullNameElement != null) dest.FullNameElement = (Hl7.Fhir.Model.FhirString)FullNameElement.DeepCopy();
                    if(NamePart != null) dest.NamePart = new List<NamePartComponent>(NamePart.DeepCopy());
                    if(CountryLanguage != null) dest.CountryLanguage = new List<CountryLanguageComponent>(CountryLanguage.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(FullNameElement, otherT.FullNameElement)) return false;
                if( !DeepComparable.Matches(NamePart, otherT.NamePart)) return false;
                if( !DeepComparable.Matches(CountryLanguage, otherT.CountryLanguage)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NameComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(FullNameElement, otherT.FullNameElement)) return false;
                if( !DeepComparable.IsExactly(NamePart, otherT.NamePart)) return false;
                if( !DeepComparable.IsExactly(CountryLanguage, otherT.CountryLanguage)) return false;
            
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
                    if (FullNameElement != null) yield return new ElementValue("fullName", false, FullNameElement);
                    foreach (var elem in NamePart) { if (elem != null) yield return new ElementValue("namePart", true, elem); }
                    foreach (var elem in CountryLanguage) { if (elem != null) yield return new ElementValue("countryLanguage", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "NamePartComponent")]
        [DataContract]
        public partial class NamePartComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NamePartComponent"; } }
            
            /// <summary>
            /// A fragment of a product name
            /// </summary>
            [FhirElement("part", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString PartElement
            {
                get { return _PartElement; }
                set { _PartElement = value; OnPropertyChanged("PartElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _PartElement;
            
            /// <summary>
            /// A fragment of a product name
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Part
            {
                get { return PartElement != null ? PartElement.Value : null; }
                set
                {
                    if (value == null)
                        PartElement = null;
                    else
                        PartElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Part");
                }
            }
            
            /// <summary>
            /// Idenifying type for this part of the name (e.g. strength part)
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.Coding _Type;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NamePartComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(PartElement != null) dest.PartElement = (Hl7.Fhir.Model.FhirString)PartElement.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.Coding)Type.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(PartElement, otherT.PartElement)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NamePartComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(PartElement, otherT.PartElement)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            
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
                    if (PartElement != null) yield return new ElementValue("part", false, PartElement);
                    if (Type != null) yield return new ElementValue("type", false, Type);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "CountryLanguageComponent")]
        [DataContract]
        public partial class CountryLanguageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CountryLanguageComponent"; } }
            
            /// <summary>
            /// Country code for where this name applies
            /// </summary>
            [FhirElement("country", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Country
            {
                get { return _Country; }
                set { _Country = value; OnPropertyChanged("Country"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Country;
            
            /// <summary>
            /// Jurisdiction code for where this name applies
            /// </summary>
            [FhirElement("jurisdiction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Jurisdiction
            {
                get { return _Jurisdiction; }
                set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Jurisdiction;
            
            /// <summary>
            /// Language code for this name
            /// </summary>
            [FhirElement("language", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Language
            {
                get { return _Language; }
                set { _Language = value; OnPropertyChanged("Language"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Language;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CountryLanguageComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Country != null) dest.Country = (Hl7.Fhir.Model.R4.CodeableConcept)Country.DeepCopy();
                    if(Jurisdiction != null) dest.Jurisdiction = (Hl7.Fhir.Model.R4.CodeableConcept)Jurisdiction.DeepCopy();
                    if(Language != null) dest.Language = (Hl7.Fhir.Model.R4.CodeableConcept)Language.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Country, otherT.Country)) return false;
                if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.Matches(Language, otherT.Language)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CountryLanguageComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Country, otherT.Country)) return false;
                if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.IsExactly(Language, otherT.Language)) return false;
            
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
                    if (Country != null) yield return new ElementValue("country", false, Country);
                    if (Jurisdiction != null) yield return new ElementValue("jurisdiction", false, Jurisdiction);
                    if (Language != null) yield return new ElementValue("language", false, Language);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ManufacturingBusinessOperationComponent")]
        [DataContract]
        public partial class ManufacturingBusinessOperationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ManufacturingBusinessOperationComponent"; } }
            
            /// <summary>
            /// The type of manufacturing operation
            /// </summary>
            [FhirElement("operationType", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept OperationType
            {
                get { return _OperationType; }
                set { _OperationType = value; OnPropertyChanged("OperationType"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _OperationType;
            
            /// <summary>
            /// Regulatory authorization reference number
            /// </summary>
            [FhirElement("authorisationReferenceNumber", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier AuthorisationReferenceNumber
            {
                get { return _AuthorisationReferenceNumber; }
                set { _AuthorisationReferenceNumber = value; OnPropertyChanged("AuthorisationReferenceNumber"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _AuthorisationReferenceNumber;
            
            /// <summary>
            /// Regulatory authorization date
            /// </summary>
            [FhirElement("effectiveDate", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDateTime EffectiveDateElement
            {
                get { return _EffectiveDateElement; }
                set { _EffectiveDateElement = value; OnPropertyChanged("EffectiveDateElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDateTime _EffectiveDateElement;
            
            /// <summary>
            /// Regulatory authorization date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string EffectiveDate
            {
                get { return EffectiveDateElement != null ? EffectiveDateElement.Value : null; }
                set
                {
                    if (value == null)
                        EffectiveDateElement = null;
                    else
                        EffectiveDateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                    OnPropertyChanged("EffectiveDate");
                }
            }
            
            /// <summary>
            /// To indicate if this proces is commercially confidential
            /// </summary>
            [FhirElement("confidentialityIndicator", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept ConfidentialityIndicator
            {
                get { return _ConfidentialityIndicator; }
                set { _ConfidentialityIndicator = value; OnPropertyChanged("ConfidentialityIndicator"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _ConfidentialityIndicator;
            
            /// <summary>
            /// The manufacturer or establishment associated with the process
            /// </summary>
            [FhirElement("manufacturer", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [References("Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Manufacturer
            {
                get { if(_Manufacturer==null) _Manufacturer = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Manufacturer; }
                set { _Manufacturer = value; OnPropertyChanged("Manufacturer"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Manufacturer;
            
            /// <summary>
            /// A regulator which oversees the operation
            /// </summary>
            [FhirElement("regulator", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [References("Organization")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Regulator
            {
                get { return _Regulator; }
                set { _Regulator = value; OnPropertyChanged("Regulator"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Regulator;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManufacturingBusinessOperationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(OperationType != null) dest.OperationType = (Hl7.Fhir.Model.R4.CodeableConcept)OperationType.DeepCopy();
                    if(AuthorisationReferenceNumber != null) dest.AuthorisationReferenceNumber = (Hl7.Fhir.Model.R4.Identifier)AuthorisationReferenceNumber.DeepCopy();
                    if(EffectiveDateElement != null) dest.EffectiveDateElement = (Hl7.Fhir.Model.R4.FhirDateTime)EffectiveDateElement.DeepCopy();
                    if(ConfidentialityIndicator != null) dest.ConfidentialityIndicator = (Hl7.Fhir.Model.R4.CodeableConcept)ConfidentialityIndicator.DeepCopy();
                    if(Manufacturer != null) dest.Manufacturer = new List<Hl7.Fhir.Model.R4.ResourceReference>(Manufacturer.DeepCopy());
                    if(Regulator != null) dest.Regulator = (Hl7.Fhir.Model.R4.ResourceReference)Regulator.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(OperationType, otherT.OperationType)) return false;
                if( !DeepComparable.Matches(AuthorisationReferenceNumber, otherT.AuthorisationReferenceNumber)) return false;
                if( !DeepComparable.Matches(EffectiveDateElement, otherT.EffectiveDateElement)) return false;
                if( !DeepComparable.Matches(ConfidentialityIndicator, otherT.ConfidentialityIndicator)) return false;
                if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
                if( !DeepComparable.Matches(Regulator, otherT.Regulator)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManufacturingBusinessOperationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(OperationType, otherT.OperationType)) return false;
                if( !DeepComparable.IsExactly(AuthorisationReferenceNumber, otherT.AuthorisationReferenceNumber)) return false;
                if( !DeepComparable.IsExactly(EffectiveDateElement, otherT.EffectiveDateElement)) return false;
                if( !DeepComparable.IsExactly(ConfidentialityIndicator, otherT.ConfidentialityIndicator)) return false;
                if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
                if( !DeepComparable.IsExactly(Regulator, otherT.Regulator)) return false;
            
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
                    if (OperationType != null) yield return new ElementValue("operationType", false, OperationType);
                    if (AuthorisationReferenceNumber != null) yield return new ElementValue("authorisationReferenceNumber", false, AuthorisationReferenceNumber);
                    if (EffectiveDateElement != null) yield return new ElementValue("effectiveDate", false, EffectiveDateElement);
                    if (ConfidentialityIndicator != null) yield return new ElementValue("confidentialityIndicator", false, ConfidentialityIndicator);
                    foreach (var elem in Manufacturer) { if (elem != null) yield return new ElementValue("manufacturer", true, elem); }
                    if (Regulator != null) yield return new ElementValue("regulator", false, Regulator);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Business idenfifier for this product. Could be an MPID
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.R4.Identifier _Identifier;
        
        /// <summary>
        /// Regulatory type, e.g. Investigational or Authorized
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Type;
        
        /// <summary>
        /// The dose form for a single part product, or combined form of a multiple part product
        /// </summary>
        [FhirElement("combinedPharmaceuticalDoseForm", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept CombinedPharmaceuticalDoseForm
        {
            get { return _CombinedPharmaceuticalDoseForm; }
            set { _CombinedPharmaceuticalDoseForm = value; OnPropertyChanged("CombinedPharmaceuticalDoseForm"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _CombinedPharmaceuticalDoseForm;
        
        /// <summary>
        /// Whether the Medicinal Product is subject to additional monitoring for regulatory reasons
        /// </summary>
        [FhirElement("additionalMonitoringIndicator", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept AdditionalMonitoringIndicator
        {
            get { return _AdditionalMonitoringIndicator; }
            set { _AdditionalMonitoringIndicator = value; OnPropertyChanged("AdditionalMonitoringIndicator"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _AdditionalMonitoringIndicator;
        
        /// <summary>
        /// Whether the Medicinal Product is subject to special measures for regulatory reasons
        /// </summary>
        [FhirElement("specialMeasures", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirString> SpecialMeasuresElement
        {
            get { if(_SpecialMeasuresElement==null) _SpecialMeasuresElement = new List<Hl7.Fhir.Model.FhirString>(); return _SpecialMeasuresElement; }
            set { _SpecialMeasuresElement = value; OnPropertyChanged("SpecialMeasuresElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirString> _SpecialMeasuresElement;
        
        /// <summary>
        /// Whether the Medicinal Product is subject to special measures for regulatory reasons
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> SpecialMeasures
        {
            get { return SpecialMeasuresElement != null ? SpecialMeasuresElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    SpecialMeasuresElement = null;
                else
                    SpecialMeasuresElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                OnPropertyChanged("SpecialMeasures");
            }
        }
        
        /// <summary>
        /// If authorised for use in children
        /// </summary>
        [FhirElement("paediatricUseIndicator", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept PaediatricUseIndicator
        {
            get { return _PaediatricUseIndicator; }
            set { _PaediatricUseIndicator = value; OnPropertyChanged("PaediatricUseIndicator"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _PaediatricUseIndicator;
        
        /// <summary>
        /// Indicates if the medicinal product has an orphan designation for the treatment of a rare disease
        /// </summary>
        [FhirElement("orphanDesignationStatus", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept OrphanDesignationStatus
        {
            get { return _OrphanDesignationStatus; }
            set { _OrphanDesignationStatus = value; OnPropertyChanged("OrphanDesignationStatus"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _OrphanDesignationStatus;
        
        /// <summary>
        /// Allows the product to be classified by various systems
        /// </summary>
        [FhirElement("productClassification", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> ProductClassification
        {
            get { if(_ProductClassification==null) _ProductClassification = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _ProductClassification; }
            set { _ProductClassification = value; OnPropertyChanged("ProductClassification"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _ProductClassification;
        
        /// <summary>
        /// Product regulatory authorization
        /// </summary>
        [FhirElement("marketingAuthorization", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [References("MedicinalProductAuthorization")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference MarketingAuthorization
        {
            get { return _MarketingAuthorization; }
            set { _MarketingAuthorization = value; OnPropertyChanged("MarketingAuthorization"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _MarketingAuthorization;
        
        /// <summary>
        /// Package representation for the product
        /// </summary>
        [FhirElement("packagedMedicinalProduct", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [References("MedicinalProductPackaged")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> PackagedMedicinalProduct
        {
            get { if(_PackagedMedicinalProduct==null) _PackagedMedicinalProduct = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _PackagedMedicinalProduct; }
            set { _PackagedMedicinalProduct = value; OnPropertyChanged("PackagedMedicinalProduct"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _PackagedMedicinalProduct;
        
        /// <summary>
        /// Pharmaceutical aspects of product
        /// </summary>
        [FhirElement("pharmaceuticalProduct", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [References("MedicinalProductPharmaceutical")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> PharmaceuticalProduct
        {
            get { if(_PharmaceuticalProduct==null) _PharmaceuticalProduct = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _PharmaceuticalProduct; }
            set { _PharmaceuticalProduct = value; OnPropertyChanged("PharmaceuticalProduct"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _PharmaceuticalProduct;
        
        /// <summary>
        /// Clinical particulars, indications etc.
        /// </summary>
        [FhirElement("clinicalParticulars", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [References("MedicinalProductClinicals")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> ClinicalParticulars
        {
            get { if(_ClinicalParticulars==null) _ClinicalParticulars = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _ClinicalParticulars; }
            set { _ClinicalParticulars = value; OnPropertyChanged("ClinicalParticulars"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _ClinicalParticulars;
        
        /// <summary>
        /// Supporting documentation, typically for regulatory submission
        /// </summary>
        [FhirElement("attachedDocument", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [References("DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> AttachedDocument
        {
            get { if(_AttachedDocument==null) _AttachedDocument = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _AttachedDocument; }
            set { _AttachedDocument = value; OnPropertyChanged("AttachedDocument"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _AttachedDocument;
        
        /// <summary>
        /// A master file for to the medicinal product (e.g. Pharmacovigilance System Master File)
        /// </summary>
        [FhirElement("masterFile", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [References("DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> MasterFile
        {
            get { if(_MasterFile==null) _MasterFile = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _MasterFile; }
            set { _MasterFile = value; OnPropertyChanged("MasterFile"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _MasterFile;
        
        /// <summary>
        /// The product's name, including full name and possibly coded parts
        /// </summary>
        [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<NameComponent> Name
        {
            get { if(_Name==null) _Name = new List<NameComponent>(); return _Name; }
            set { _Name = value; OnPropertyChanged("Name"); }
        }
        
        private List<NameComponent> _Name;
        
        /// <summary>
        /// Reference to another product, e.g. for linking authorised to investigational product
        /// </summary>
        [FhirElement("crossReference", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=240)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Identifier> CrossReference
        {
            get { if(_CrossReference==null) _CrossReference = new List<Hl7.Fhir.Model.R4.Identifier>(); return _CrossReference; }
            set { _CrossReference = value; OnPropertyChanged("CrossReference"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Identifier> _CrossReference;
        
        /// <summary>
        /// An operation applied to the product, for manufacturing or adminsitrative purpose
        /// </summary>
        [FhirElement("manufacturingBusinessOperation", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=250)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ManufacturingBusinessOperationComponent> ManufacturingBusinessOperation
        {
            get { if(_ManufacturingBusinessOperation==null) _ManufacturingBusinessOperation = new List<ManufacturingBusinessOperationComponent>(); return _ManufacturingBusinessOperation; }
            set { _ManufacturingBusinessOperation = value; OnPropertyChanged("ManufacturingBusinessOperation"); }
        }
        
        private List<ManufacturingBusinessOperationComponent> _ManufacturingBusinessOperation;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProduct;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                if(CombinedPharmaceuticalDoseForm != null) dest.CombinedPharmaceuticalDoseForm = (Hl7.Fhir.Model.R4.CodeableConcept)CombinedPharmaceuticalDoseForm.DeepCopy();
                if(AdditionalMonitoringIndicator != null) dest.AdditionalMonitoringIndicator = (Hl7.Fhir.Model.R4.CodeableConcept)AdditionalMonitoringIndicator.DeepCopy();
                if(SpecialMeasuresElement != null) dest.SpecialMeasuresElement = new List<Hl7.Fhir.Model.FhirString>(SpecialMeasuresElement.DeepCopy());
                if(PaediatricUseIndicator != null) dest.PaediatricUseIndicator = (Hl7.Fhir.Model.R4.CodeableConcept)PaediatricUseIndicator.DeepCopy();
                if(OrphanDesignationStatus != null) dest.OrphanDesignationStatus = (Hl7.Fhir.Model.R4.CodeableConcept)OrphanDesignationStatus.DeepCopy();
                if(ProductClassification != null) dest.ProductClassification = new List<Hl7.Fhir.Model.R4.CodeableConcept>(ProductClassification.DeepCopy());
                if(MarketingAuthorization != null) dest.MarketingAuthorization = (Hl7.Fhir.Model.R4.ResourceReference)MarketingAuthorization.DeepCopy();
                if(PackagedMedicinalProduct != null) dest.PackagedMedicinalProduct = new List<Hl7.Fhir.Model.R4.ResourceReference>(PackagedMedicinalProduct.DeepCopy());
                if(PharmaceuticalProduct != null) dest.PharmaceuticalProduct = new List<Hl7.Fhir.Model.R4.ResourceReference>(PharmaceuticalProduct.DeepCopy());
                if(ClinicalParticulars != null) dest.ClinicalParticulars = new List<Hl7.Fhir.Model.R4.ResourceReference>(ClinicalParticulars.DeepCopy());
                if(AttachedDocument != null) dest.AttachedDocument = new List<Hl7.Fhir.Model.R4.ResourceReference>(AttachedDocument.DeepCopy());
                if(MasterFile != null) dest.MasterFile = new List<Hl7.Fhir.Model.R4.ResourceReference>(MasterFile.DeepCopy());
                if(Name != null) dest.Name = new List<NameComponent>(Name.DeepCopy());
                if(CrossReference != null) dest.CrossReference = new List<Hl7.Fhir.Model.R4.Identifier>(CrossReference.DeepCopy());
                if(ManufacturingBusinessOperation != null) dest.ManufacturingBusinessOperation = new List<ManufacturingBusinessOperationComponent>(ManufacturingBusinessOperation.DeepCopy());
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(CombinedPharmaceuticalDoseForm, otherT.CombinedPharmaceuticalDoseForm)) return false;
            if( !DeepComparable.Matches(AdditionalMonitoringIndicator, otherT.AdditionalMonitoringIndicator)) return false;
            if( !DeepComparable.Matches(SpecialMeasuresElement, otherT.SpecialMeasuresElement)) return false;
            if( !DeepComparable.Matches(PaediatricUseIndicator, otherT.PaediatricUseIndicator)) return false;
            if( !DeepComparable.Matches(OrphanDesignationStatus, otherT.OrphanDesignationStatus)) return false;
            if( !DeepComparable.Matches(ProductClassification, otherT.ProductClassification)) return false;
            if( !DeepComparable.Matches(MarketingAuthorization, otherT.MarketingAuthorization)) return false;
            if( !DeepComparable.Matches(PackagedMedicinalProduct, otherT.PackagedMedicinalProduct)) return false;
            if( !DeepComparable.Matches(PharmaceuticalProduct, otherT.PharmaceuticalProduct)) return false;
            if( !DeepComparable.Matches(ClinicalParticulars, otherT.ClinicalParticulars)) return false;
            if( !DeepComparable.Matches(AttachedDocument, otherT.AttachedDocument)) return false;
            if( !DeepComparable.Matches(MasterFile, otherT.MasterFile)) return false;
            if( !DeepComparable.Matches(Name, otherT.Name)) return false;
            if( !DeepComparable.Matches(CrossReference, otherT.CrossReference)) return false;
            if( !DeepComparable.Matches(ManufacturingBusinessOperation, otherT.ManufacturingBusinessOperation)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProduct;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(CombinedPharmaceuticalDoseForm, otherT.CombinedPharmaceuticalDoseForm)) return false;
            if( !DeepComparable.IsExactly(AdditionalMonitoringIndicator, otherT.AdditionalMonitoringIndicator)) return false;
            if( !DeepComparable.IsExactly(SpecialMeasuresElement, otherT.SpecialMeasuresElement)) return false;
            if( !DeepComparable.IsExactly(PaediatricUseIndicator, otherT.PaediatricUseIndicator)) return false;
            if( !DeepComparable.IsExactly(OrphanDesignationStatus, otherT.OrphanDesignationStatus)) return false;
            if( !DeepComparable.IsExactly(ProductClassification, otherT.ProductClassification)) return false;
            if( !DeepComparable.IsExactly(MarketingAuthorization, otherT.MarketingAuthorization)) return false;
            if( !DeepComparable.IsExactly(PackagedMedicinalProduct, otherT.PackagedMedicinalProduct)) return false;
            if( !DeepComparable.IsExactly(PharmaceuticalProduct, otherT.PharmaceuticalProduct)) return false;
            if( !DeepComparable.IsExactly(ClinicalParticulars, otherT.ClinicalParticulars)) return false;
            if( !DeepComparable.IsExactly(AttachedDocument, otherT.AttachedDocument)) return false;
            if( !DeepComparable.IsExactly(MasterFile, otherT.MasterFile)) return false;
            if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if( !DeepComparable.IsExactly(CrossReference, otherT.CrossReference)) return false;
            if( !DeepComparable.IsExactly(ManufacturingBusinessOperation, otherT.ManufacturingBusinessOperation)) return false;
        
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
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                if (Type != null) yield return new ElementValue("type", false, Type);
                if (CombinedPharmaceuticalDoseForm != null) yield return new ElementValue("combinedPharmaceuticalDoseForm", false, CombinedPharmaceuticalDoseForm);
                if (AdditionalMonitoringIndicator != null) yield return new ElementValue("additionalMonitoringIndicator", false, AdditionalMonitoringIndicator);
                foreach (var elem in SpecialMeasuresElement) { if (elem != null) yield return new ElementValue("specialMeasures", true, elem); }
                if (PaediatricUseIndicator != null) yield return new ElementValue("paediatricUseIndicator", false, PaediatricUseIndicator);
                if (OrphanDesignationStatus != null) yield return new ElementValue("orphanDesignationStatus", false, OrphanDesignationStatus);
                foreach (var elem in ProductClassification) { if (elem != null) yield return new ElementValue("productClassification", true, elem); }
                if (MarketingAuthorization != null) yield return new ElementValue("marketingAuthorization", false, MarketingAuthorization);
                foreach (var elem in PackagedMedicinalProduct) { if (elem != null) yield return new ElementValue("packagedMedicinalProduct", true, elem); }
                foreach (var elem in PharmaceuticalProduct) { if (elem != null) yield return new ElementValue("pharmaceuticalProduct", true, elem); }
                foreach (var elem in ClinicalParticulars) { if (elem != null) yield return new ElementValue("clinicalParticulars", true, elem); }
                foreach (var elem in AttachedDocument) { if (elem != null) yield return new ElementValue("attachedDocument", true, elem); }
                foreach (var elem in MasterFile) { if (elem != null) yield return new ElementValue("masterFile", true, elem); }
                foreach (var elem in Name) { if (elem != null) yield return new ElementValue("name", true, elem); }
                foreach (var elem in CrossReference) { if (elem != null) yield return new ElementValue("crossReference", true, elem); }
                foreach (var elem in ManufacturingBusinessOperation) { if (elem != null) yield return new ElementValue("manufacturingBusinessOperation", true, elem); }
            }
        }
    
    }

}
