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
    /// CoverageEligibilityRequest resource
    /// </summary>
    [FhirType("CoverageEligibilityRequest", IsResource=true)]
    [DataContract]
    public partial class CoverageEligibilityRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.CoverageEligibilityRequest; } }
        [NotMapped]
        public override string TypeName { get { return "CoverageEligibilityRequest"; } }

        /// <summary>
        /// A code specifying the types of information being requested.
        /// (url: http://hl7.org/fhir/ValueSet/eligibilityrequest-purpose)
        /// </summary>
        [FhirEnumeration("EligibilityRequestPurpose")]
        public enum EligibilityRequestPurpose
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/eligibilityrequest-purpose)
            /// </summary>
            [EnumLiteral("auth-requirements", "http://hl7.org/fhir/eligibilityrequest-purpose"), Description("Coverage auth-requirements")]
            AuthRequirements,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/eligibilityrequest-purpose)
            /// </summary>
            [EnumLiteral("benefits", "http://hl7.org/fhir/eligibilityrequest-purpose"), Description("Coverage benefits")]
            Benefits,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/eligibilityrequest-purpose)
            /// </summary>
            [EnumLiteral("discovery", "http://hl7.org/fhir/eligibilityrequest-purpose"), Description("Coverage Discovery")]
            Discovery,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/eligibilityrequest-purpose)
            /// </summary>
            [EnumLiteral("validation", "http://hl7.org/fhir/eligibilityrequest-purpose"), Description("Coverage Validation")]
            Validation,
        }


        [FhirType("InformationComponent")]
        [DataContract]
        public partial class InformationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InformationComponent"; } }

            /// <summary>
            /// Information instance identifier
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Information instance identifier
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
            /// Additional Data or supporting information
            /// </summary>
            [FhirElement("information", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Information
            {
                get { return _information; }
                set { _information = value; OnPropertyChanged("Information"); }
            }

            private ResourceReference _information;

            /// <summary>
            /// Applies to all items
            /// </summary>
            [FhirElement("appliesToAll", Order=60)]
            [DataMember]
            public FhirBoolean AppliesToAllElement
            {
                get { return _appliesToAllElement; }
                set { _appliesToAllElement = value; OnPropertyChanged("AppliesToAllElement"); }
            }

            private FhirBoolean _appliesToAllElement;

            /// <summary>
            /// Applies to all items
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? AppliesToAll
            {
                get { return AppliesToAllElement != null ? AppliesToAllElement.Value : null; }
                set
                {
                    if (value == null)
                        AppliesToAllElement = null;
                    else
                        AppliesToAllElement = new FhirBoolean(value);
                    OnPropertyChanged("AppliesToAll");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InformationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Information != null) dest.Information = (ResourceReference)Information.DeepCopy();
                    if (AppliesToAllElement != null) dest.AppliesToAllElement = (FhirBoolean)AppliesToAllElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InformationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InformationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(Information, otherT.Information)) return false;
                if (!DeepComparable.Matches(AppliesToAllElement, otherT.AppliesToAllElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InformationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Information, otherT.Information)) return false;
                if (!DeepComparable.IsExactly(AppliesToAllElement, otherT.AppliesToAllElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (Information != null) yield return Information;
                    if (AppliesToAllElement != null) yield return AppliesToAllElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (Information != null) yield return new ElementValue("information", Information);
                    if (AppliesToAllElement != null) yield return new ElementValue("appliesToAll", AppliesToAllElement);
                }
            }


        }


        [FhirType("InsuranceComponent")]
        [DataContract]
        public partial class InsuranceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InsuranceComponent"; } }

            /// <summary>
            /// Is the focal Coverage
            /// </summary>
            [FhirElement("focal", Order=40)]
            [DataMember]
            public FhirBoolean FocalElement
            {
                get { return _focalElement; }
                set { _focalElement = value; OnPropertyChanged("FocalElement"); }
            }

            private FhirBoolean _focalElement;

            /// <summary>
            /// Is the focal Coverage
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Focal
            {
                get { return FocalElement != null ? FocalElement.Value : null; }
                set
                {
                    if (value == null)
                        FocalElement = null;
                    else
                        FocalElement = new FhirBoolean(value);
                    OnPropertyChanged("Focal");
                }
            }

            /// <summary>
            /// Insurance or medical plan
            /// </summary>
            [FhirElement("coverage", Order=50)]
            [References("Coverage")]
            [Cardinality(Min=1,Max=1)]
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
            [FhirElement("businessArrangement", Order=60)]
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InsuranceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (FocalElement != null) dest.FocalElement = (FhirBoolean)FocalElement.DeepCopy();
                    if (Coverage != null) dest.Coverage = (ResourceReference)Coverage.DeepCopy();
                    if (BusinessArrangementElement != null) dest.BusinessArrangementElement = (FhirString)BusinessArrangementElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InsuranceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InsuranceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.Matches(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InsuranceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.IsExactly(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (FocalElement != null) yield return FocalElement;
                    if (Coverage != null) yield return Coverage;
                    if (BusinessArrangementElement != null) yield return BusinessArrangementElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (FocalElement != null) yield return new ElementValue("focal", FocalElement);
                    if (Coverage != null) yield return new ElementValue("coverage", Coverage);
                    if (BusinessArrangementElement != null) yield return new ElementValue("businessArrangement", BusinessArrangementElement);
                }
            }


        }


        [FhirType("DetailsComponent")]
        [DataContract]
        public partial class DetailsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DetailsComponent"; } }

            /// <summary>
            /// Applicable exception and supporting information
            /// </summary>
            [FhirElement("supportingInformationSequence", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> SupportingInformationSequenceElement
            {
                get { if (_supportingInformationSequenceElement==null) _supportingInformationSequenceElement = new List<PositiveInt>(); return _supportingInformationSequenceElement; }
                set { _supportingInformationSequenceElement = value; OnPropertyChanged("SupportingInformationSequenceElement"); }
            }

            private List<PositiveInt> _supportingInformationSequenceElement;

            /// <summary>
            /// Applicable exception and supporting information
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> SupportingInformationSequence
            {
                get { return SupportingInformationSequenceElement != null ? SupportingInformationSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SupportingInformationSequenceElement = null;
                    else
                        SupportingInformationSequenceElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("SupportingInformationSequence");
                }
            }

            /// <summary>
            /// Type of service
            /// </summary>
            [FhirElement("category", Order=50)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Billing Code
            /// </summary>
            [FhirElement("billcode", Order=60)]
            [DataMember]
            public CodeableConcept Billcode
            {
                get { return _billcode; }
                set { _billcode = value; OnPropertyChanged("Billcode"); }
            }

            private CodeableConcept _billcode;

            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Modifier
            {
                get { if (_modifier==null) _modifier = new List<CodeableConcept>(); return _modifier; }
                set { _modifier = value; OnPropertyChanged("Modifier"); }
            }

            private List<CodeableConcept> _modifier;

            /// <summary>
            /// Perfoming practitioner
            /// </summary>
            [FhirElement("provider", Order=80)]
            [References("Practitioner","PractitionerRole")]
            [DataMember]
            public ResourceReference Provider
            {
                get { return _provider; }
                set { _provider = value; OnPropertyChanged("Provider"); }
            }

            private ResourceReference _provider;

            /// <summary>
            /// Count of products or services
            /// </summary>
            [FhirElement("quantity", Order=90)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Fee, charge or cost per point
            /// </summary>
            [FhirElement("unitPrice", Order=100)]
            [DataMember]
            public Money UnitPrice
            {
                get { return _unitPrice; }
                set { _unitPrice = value; OnPropertyChanged("UnitPrice"); }
            }

            private Money _unitPrice;

            /// <summary>
            /// Servicing Facility
            /// </summary>
            [FhirElement("facility", Order=110)]
            [References("Location","Organization")]
            [DataMember]
            public ResourceReference Facility
            {
                get { return _facility; }
                set { _facility = value; OnPropertyChanged("Facility"); }
            }

            private ResourceReference _facility;

            /// <summary>
            /// List of Diagnosis
            /// </summary>
            [FhirElement("diagnosis", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DiagnosisComponent> Diagnosis
            {
                get { if (_diagnosis==null) _diagnosis = new List<DiagnosisComponent>(); return _diagnosis; }
                set { _diagnosis = value; OnPropertyChanged("Diagnosis"); }
            }

            private List<DiagnosisComponent> _diagnosis;

            /// <summary>
            /// Product or service details
            /// </summary>
            [FhirElement("detail", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Detail
            {
                get { if (_detail==null) _detail = new List<ResourceReference>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<ResourceReference> _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DetailsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SupportingInformationSequenceElement != null) dest.SupportingInformationSequenceElement = new List<PositiveInt>(SupportingInformationSequenceElement.DeepCopy());
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Billcode != null) dest.Billcode = (CodeableConcept)Billcode.DeepCopy();
                    if (Modifier != null) dest.Modifier = new List<CodeableConcept>(Modifier.DeepCopy());
                    if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (Facility != null) dest.Facility = (ResourceReference)Facility.DeepCopy();
                    if (Diagnosis != null) dest.Diagnosis = new List<DiagnosisComponent>(Diagnosis.DeepCopy());
                    if (Detail != null) dest.Detail = new List<ResourceReference>(Detail.DeepCopy());
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
                if ( !DeepComparable.Matches(SupportingInformationSequenceElement, otherT.SupportingInformationSequenceElement)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Billcode, otherT.Billcode)) return false;
                if ( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(Facility, otherT.Facility)) return false;
                if ( !DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
                if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DetailsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SupportingInformationSequenceElement, otherT.SupportingInformationSequenceElement)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Billcode, otherT.Billcode)) return false;
                if (!DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(Facility, otherT.Facility)) return false;
                if (!DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in SupportingInformationSequenceElement) { if (elem != null) yield return elem; }
                    if (Category != null) yield return Category;
                    if (Billcode != null) yield return Billcode;
                    foreach (var elem in Modifier) { if (elem != null) yield return elem; }
                    if (Provider != null) yield return Provider;
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (Facility != null) yield return Facility;
                    foreach (var elem in Diagnosis) { if (elem != null) yield return elem; }
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in SupportingInformationSequenceElement) { if (elem != null) yield return new ElementValue("supportingInformationSequence", elem); }
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Billcode != null) yield return new ElementValue("billcode", Billcode);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", elem); }
                    if (Provider != null) yield return new ElementValue("provider", Provider);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (Facility != null) yield return new ElementValue("facility", Facility);
                    foreach (var elem in Diagnosis) { if (elem != null) yield return new ElementValue("diagnosis", elem); }
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
                }
            }


        }


        [FhirType("DiagnosisComponent")]
        [DataContract]
        public partial class DiagnosisComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DiagnosisComponent"; } }

            /// <summary>
            /// Patient's diagnosis
            /// </summary>
            [FhirElement("diagnosis", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Diagnosis
            {
                get { return _diagnosis; }
                set { _diagnosis = value; OnPropertyChanged("Diagnosis"); }
            }

            private Element _diagnosis;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DiagnosisComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Diagnosis != null) dest.Diagnosis = (Element)Diagnosis.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DiagnosisComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;

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
                    if (Diagnosis != null) yield return new ElementValue("diagnosis", Diagnosis);
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
        /// auth-requirements | benefits | discovery | validation
        /// </summary>
        [FhirElement("purpose", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Code<EligibilityRequestPurpose>> PurposeElement
        {
            get { if (_purposeElement==null) _purposeElement = new List<Code<EligibilityRequestPurpose>>(); return _purposeElement; }
            set { _purposeElement = value; OnPropertyChanged("PurposeElement"); }
        }

        private List<Code<EligibilityRequestPurpose>> _purposeElement;

        /// <summary>
        /// auth-requirements | benefits | discovery | validation
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<EligibilityRequestPurpose?> Purpose
        {
            get { return PurposeElement != null ? PurposeElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    PurposeElement = null;
                else
                    PurposeElement = new List<Code<EligibilityRequestPurpose>>(value.Select(elem=>new Code<EligibilityRequestPurpose>(elem)));
                OnPropertyChanged("Purpose");
            }
        }

        /// <summary>
        /// The subject of the Products and Services
        /// </summary>
        [FhirElement("patient", Order=130)]
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
        [FhirElement("serviced", Order=140, Choice=ChoiceType.DatatypeChoice)]
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
        [FhirElement("created", Order=150)]
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
        [FhirElement("enterer", Order=160)]
        [References("Practitioner","PractitionerRole")]
        [DataMember]
        public ResourceReference Enterer
        {
            get { return _enterer; }
            set { _enterer = value; OnPropertyChanged("Enterer"); }
        }

        private ResourceReference _enterer;

        /// <summary>
        /// Responsible provider
        /// </summary>
        [FhirElement("provider", Order=170)]
        [References("Practitioner","PractitionerRole","Organization")]
        [DataMember]
        public ResourceReference Provider
        {
            get { return _provider; }
            set { _provider = value; OnPropertyChanged("Provider"); }
        }

        private ResourceReference _provider;

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
        /// Exceptions, special considerations, the condition, situation, prior or concurrent issues
        /// </summary>
        [FhirElement("supportingInformation", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<InformationComponent> SupportingInformation
        {
            get { if (_supportingInformation==null) _supportingInformation = new List<InformationComponent>(); return _supportingInformation; }
            set { _supportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }

        private List<InformationComponent> _supportingInformation;

        /// <summary>
        /// Patient's Insurance or medical plan(s)
        /// </summary>
        [FhirElement("insurance", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<InsuranceComponent> Insurance
        {
            get { if (_insurance==null) _insurance = new List<InsuranceComponent>(); return _insurance; }
            set { _insurance = value; OnPropertyChanged("Insurance"); }
        }

        private List<InsuranceComponent> _insurance;

        /// <summary>
        /// Service types, codes and supporting information
        /// </summary>
        [FhirElement("item", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DetailsComponent> Item
        {
            get { if (_item==null) _item = new List<DetailsComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<DetailsComponent> _item;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as CoverageEligibilityRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (Priority != null) dest.Priority = (CodeableConcept)Priority.DeepCopy();
                if (PurposeElement != null) dest.PurposeElement = new List<Code<EligibilityRequestPurpose>>(PurposeElement.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Serviced != null) dest.Serviced = (Element)Serviced.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Enterer != null) dest.Enterer = (ResourceReference)Enterer.DeepCopy();
                if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                if (Insurer != null) dest.Insurer = (ResourceReference)Insurer.DeepCopy();
                if (Facility != null) dest.Facility = (ResourceReference)Facility.DeepCopy();
                if (SupportingInformation != null) dest.SupportingInformation = new List<InformationComponent>(SupportingInformation.DeepCopy());
                if (Insurance != null) dest.Insurance = new List<InsuranceComponent>(Insurance.DeepCopy());
                if (Item != null) dest.Item = new List<DetailsComponent>(Item.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new CoverageEligibilityRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as CoverageEligibilityRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if ( !DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Serviced, otherT.Serviced)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
            if (!DeepComparable.Matches(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.Matches(Facility, otherT.Facility)) return false;
            if ( !DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if ( !DeepComparable.Matches(Insurance, otherT.Insurance)) return false;
            if ( !DeepComparable.Matches(Item, otherT.Item)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as CoverageEligibilityRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if (!DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Serviced, otherT.Serviced)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
            if (!DeepComparable.IsExactly(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.IsExactly(Facility, otherT.Facility)) return false;
            if (!DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

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
                foreach (var elem in PurposeElement) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
                if (Serviced != null) yield return Serviced;
                if (CreatedElement != null) yield return CreatedElement;
                if (Enterer != null) yield return Enterer;
                if (Provider != null) yield return Provider;
                if (Insurer != null) yield return Insurer;
                if (Facility != null) yield return Facility;
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
                foreach (var elem in Insurance) { if (elem != null) yield return elem; }
                foreach (var elem in Item) { if (elem != null) yield return elem; }
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
                foreach (var elem in PurposeElement) { if (elem != null) yield return new ElementValue("purpose", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Serviced != null) yield return new ElementValue("serviced", Serviced);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Enterer != null) yield return new ElementValue("enterer", Enterer);
                if (Provider != null) yield return new ElementValue("provider", Provider);
                if (Insurer != null) yield return new ElementValue("insurer", Insurer);
                if (Facility != null) yield return new ElementValue("facility", Facility);
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", elem); }
                foreach (var elem in Insurance) { if (elem != null) yield return new ElementValue("insurance", elem); }
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
            }
        }

    }

}
