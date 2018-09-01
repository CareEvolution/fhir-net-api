using System;
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
    /// EligibilityResponse resource
    /// </summary>
    [FhirType("EligibilityResponse", IsResource=true)]
    [DataContract]
    public partial class EligibilityResponse : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.EligibilityResponse; } }
        [NotMapped]
        public override string TypeName { get { return "EligibilityResponse"; } }


        [FhirType("InsuranceComponent")]
        [DataContract]
        public partial class InsuranceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InsuranceComponent"; } }

            /// <summary>
            /// Updated Coverage details
            /// </summary>
            [FhirElement("coverage", Order=40)]
            [References("Coverage")]
            [DataMember]
            public ResourceReference Coverage
            {
                get { return _coverage; }
                set { _coverage = value; OnPropertyChanged("Coverage"); }
            }

            private ResourceReference _coverage;

            /// <summary>
            /// Contract details
            /// </summary>
            [FhirElement("contract", Order=50)]
            [References("Contract")]
            [DataMember]
            public ResourceReference Contract
            {
                get { return _contract; }
                set { _contract = value; OnPropertyChanged("Contract"); }
            }

            private ResourceReference _contract;

            /// <summary>
            /// Benefits by Category
            /// </summary>
            [FhirElement("benefitBalance", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<BenefitsComponent> BenefitBalance
            {
                get { if (_benefitBalance==null) _benefitBalance = new List<BenefitsComponent>(); return _benefitBalance; }
                set { _benefitBalance = value; OnPropertyChanged("BenefitBalance"); }
            }

            private List<BenefitsComponent> _benefitBalance;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InsuranceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Coverage != null) dest.Coverage = (ResourceReference)Coverage.DeepCopy();
                    if (Contract != null) dest.Contract = (ResourceReference)Contract.DeepCopy();
                    if (BenefitBalance != null) dest.BenefitBalance = new List<BenefitsComponent>(BenefitBalance.DeepCopy());
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
                if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.Matches(Contract, otherT.Contract)) return false;
                if ( !DeepComparable.Matches(BenefitBalance, otherT.BenefitBalance)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InsuranceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.IsExactly(Contract, otherT.Contract)) return false;
                if (!DeepComparable.IsExactly(BenefitBalance, otherT.BenefitBalance)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Coverage != null) yield return Coverage;
                    if (Contract != null) yield return Contract;
                    foreach (var elem in BenefitBalance) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Coverage != null) yield return new ElementValue("coverage", Coverage);
                    if (Contract != null) yield return new ElementValue("contract", Contract);
                    foreach (var elem in BenefitBalance) { if (elem != null) yield return new ElementValue("benefitBalance", elem); }
                }
            }


        }


        [FhirType("BenefitsComponent")]
        [DataContract]
        public partial class BenefitsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "BenefitsComponent"; } }

            /// <summary>
            /// Type of services covered
            /// </summary>
            [FhirElement("category", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Detailed services covered within the type
            /// </summary>
            [FhirElement("subCategory", Order=50)]
            [DataMember]
            public CodeableConcept SubCategory
            {
                get { return _subCategory; }
                set { _subCategory = value; OnPropertyChanged("SubCategory"); }
            }

            private CodeableConcept _subCategory;

            /// <summary>
            /// Excluded from the plan
            /// </summary>
            [FhirElement("excluded", Order=60)]
            [DataMember]
            public FhirBoolean ExcludedElement
            {
                get { return _excludedElement; }
                set { _excludedElement = value; OnPropertyChanged("ExcludedElement"); }
            }

            private FhirBoolean _excludedElement;

            /// <summary>
            /// Excluded from the plan
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Excluded
            {
                get { return ExcludedElement != null ? ExcludedElement.Value : null; }
                set
                {
                    if (value == null)
                        ExcludedElement = null;
                    else
                        ExcludedElement = new FhirBoolean(value);
                    OnPropertyChanged("Excluded");
                }
            }

            /// <summary>
            /// Short name for the benefit
            /// </summary>
            [FhirElement("name", Order=70)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Short name for the benefit
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new FhirString(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Description of the benefit or services covered
            /// </summary>
            [FhirElement("description", Order=80)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Description of the benefit or services covered
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
            /// In or out of network
            /// </summary>
            [FhirElement("network", Order=90)]
            [DataMember]
            public CodeableConcept Network
            {
                get { return _network; }
                set { _network = value; OnPropertyChanged("Network"); }
            }

            private CodeableConcept _network;

            /// <summary>
            /// Individual or family
            /// </summary>
            [FhirElement("unit", Order=100)]
            [DataMember]
            public CodeableConcept Unit
            {
                get { return _unit; }
                set { _unit = value; OnPropertyChanged("Unit"); }
            }

            private CodeableConcept _unit;

            /// <summary>
            /// Annual or lifetime
            /// </summary>
            [FhirElement("term", Order=110)]
            [DataMember]
            public CodeableConcept Term
            {
                get { return _term; }
                set { _term = value; OnPropertyChanged("Term"); }
            }

            private CodeableConcept _term;

            /// <summary>
            /// Benefit Summary
            /// </summary>
            [FhirElement("financial", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<BenefitComponent> Financial
            {
                get { if (_financial==null) _financial = new List<BenefitComponent>(); return _financial; }
                set { _financial = value; OnPropertyChanged("Financial"); }
            }

            private List<BenefitComponent> _financial;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BenefitsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (SubCategory != null) dest.SubCategory = (CodeableConcept)SubCategory.DeepCopy();
                    if (ExcludedElement != null) dest.ExcludedElement = (FhirBoolean)ExcludedElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Network != null) dest.Network = (CodeableConcept)Network.DeepCopy();
                    if (Unit != null) dest.Unit = (CodeableConcept)Unit.DeepCopy();
                    if (Term != null) dest.Term = (CodeableConcept)Term.DeepCopy();
                    if (Financial != null) dest.Financial = new List<BenefitComponent>(Financial.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BenefitsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BenefitsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(SubCategory, otherT.SubCategory)) return false;
                if (!DeepComparable.Matches(ExcludedElement, otherT.ExcludedElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Network, otherT.Network)) return false;
                if (!DeepComparable.Matches(Unit, otherT.Unit)) return false;
                if (!DeepComparable.Matches(Term, otherT.Term)) return false;
                if ( !DeepComparable.Matches(Financial, otherT.Financial)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BenefitsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(SubCategory, otherT.SubCategory)) return false;
                if (!DeepComparable.IsExactly(ExcludedElement, otherT.ExcludedElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Network, otherT.Network)) return false;
                if (!DeepComparable.IsExactly(Unit, otherT.Unit)) return false;
                if (!DeepComparable.IsExactly(Term, otherT.Term)) return false;
                if (!DeepComparable.IsExactly(Financial, otherT.Financial)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    if (SubCategory != null) yield return SubCategory;
                    if (ExcludedElement != null) yield return ExcludedElement;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Network != null) yield return Network;
                    if (Unit != null) yield return Unit;
                    if (Term != null) yield return Term;
                    foreach (var elem in Financial) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (SubCategory != null) yield return new ElementValue("subCategory", SubCategory);
                    if (ExcludedElement != null) yield return new ElementValue("excluded", ExcludedElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Network != null) yield return new ElementValue("network", Network);
                    if (Unit != null) yield return new ElementValue("unit", Unit);
                    if (Term != null) yield return new ElementValue("term", Term);
                    foreach (var elem in Financial) { if (elem != null) yield return new ElementValue("financial", elem); }
                }
            }


        }


        [FhirType("BenefitComponent")]
        [DataContract]
        public partial class BenefitComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "BenefitComponent"; } }

            /// <summary>
            /// Deductable, visits, benefit amount
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
            /// Benefits allowed
            /// </summary>
            [FhirElement("allowed", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(UnsignedInt),typeof(FhirString),typeof(Money))]
            [DataMember]
            public Element Allowed
            {
                get { return _allowed; }
                set { _allowed = value; OnPropertyChanged("Allowed"); }
            }

            private Element _allowed;

            /// <summary>
            /// Benefits used
            /// </summary>
            [FhirElement("used", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(UnsignedInt),typeof(Money))]
            [DataMember]
            public Element Used
            {
                get { return _used; }
                set { _used = value; OnPropertyChanged("Used"); }
            }

            private Element _used;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BenefitComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Allowed != null) dest.Allowed = (Element)Allowed.DeepCopy();
                    if (Used != null) dest.Used = (Element)Used.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BenefitComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BenefitComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Allowed, otherT.Allowed)) return false;
                if (!DeepComparable.Matches(Used, otherT.Used)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BenefitComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Allowed, otherT.Allowed)) return false;
                if (!DeepComparable.IsExactly(Used, otherT.Used)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Allowed != null) yield return Allowed;
                    if (Used != null) yield return Used;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Allowed != null) yield return new ElementValue("allowed", Allowed);
                    if (Used != null) yield return new ElementValue("used", Used);
                }
            }


        }


        [FhirType("ErrorsComponent")]
        [DataContract]
        public partial class ErrorsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ErrorsComponent"; } }

            /// <summary>
            /// Error code detailing processing issues
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ErrorsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ErrorsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ErrorsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ErrorsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
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
        /// Responsible practitioner
        /// </summary>
        [FhirElement("requestProvider", Order=120)]
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
        [FhirElement("requestOrganization", Order=130)]
        [References("Organization")]
        [DataMember]
        public ResourceReference RequestOrganization
        {
            get { return _requestOrganization; }
            set { _requestOrganization = value; OnPropertyChanged("RequestOrganization"); }
        }

        private ResourceReference _requestOrganization;

        /// <summary>
        /// Eligibility reference
        /// </summary>
        [FhirElement("request", Order=140)]
        [References("EligibilityRequest")]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// complete | error | partial
        /// </summary>
        [FhirElement("outcome", Order=150)]
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
        /// Insurer issuing the coverage
        /// </summary>
        [FhirElement("insurer", Order=170)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Insurer
        {
            get { return _insurer; }
            set { _insurer = value; OnPropertyChanged("Insurer"); }
        }

        private ResourceReference _insurer;

        /// <summary>
        /// Coverage inforce indicator
        /// </summary>
        [FhirElement("inforce", Order=180)]
        [DataMember]
        public FhirBoolean InforceElement
        {
            get { return _inforceElement; }
            set { _inforceElement = value; OnPropertyChanged("InforceElement"); }
        }

        private FhirBoolean _inforceElement;

        /// <summary>
        /// Coverage inforce indicator
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Inforce
        {
            get { return InforceElement != null ? InforceElement.Value : null; }
            set
            {
                if (value == null)
                    InforceElement = null;
                else
                    InforceElement = new FhirBoolean(value);
                OnPropertyChanged("Inforce");
            }
        }

        /// <summary>
        /// Details by insurance coverage
        /// </summary>
        [FhirElement("insurance", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<InsuranceComponent> Insurance
        {
            get { if (_insurance==null) _insurance = new List<InsuranceComponent>(); return _insurance; }
            set { _insurance = value; OnPropertyChanged("Insurance"); }
        }

        private List<InsuranceComponent> _insurance;

        /// <summary>
        /// Printed Form Identifier
        /// </summary>
        [FhirElement("form", Order=200)]
        [DataMember]
        public CodeableConcept Form
        {
            get { return _form; }
            set { _form = value; OnPropertyChanged("Form"); }
        }

        private CodeableConcept _form;

        /// <summary>
        /// Processing errors
        /// </summary>
        [FhirElement("error", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ErrorsComponent> Error
        {
            get { if (_error==null) _error = new List<ErrorsComponent>(); return _error; }
            set { _error = value; OnPropertyChanged("Error"); }
        }

        private List<ErrorsComponent> _error;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as EligibilityResponse;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (RequestProvider != null) dest.RequestProvider = (ResourceReference)RequestProvider.DeepCopy();
                if (RequestOrganization != null) dest.RequestOrganization = (ResourceReference)RequestOrganization.DeepCopy();
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                if (DispositionElement != null) dest.DispositionElement = (FhirString)DispositionElement.DeepCopy();
                if (Insurer != null) dest.Insurer = (ResourceReference)Insurer.DeepCopy();
                if (InforceElement != null) dest.InforceElement = (FhirBoolean)InforceElement.DeepCopy();
                if (Insurance != null) dest.Insurance = new List<InsuranceComponent>(Insurance.DeepCopy());
                if (Form != null) dest.Form = (CodeableConcept)Form.DeepCopy();
                if (Error != null) dest.Error = new List<ErrorsComponent>(Error.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new EligibilityResponse());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as EligibilityResponse;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.Matches(RequestOrganization, otherT.RequestOrganization)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.Matches(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.Matches(InforceElement, otherT.InforceElement)) return false;
            if ( !DeepComparable.Matches(Insurance, otherT.Insurance)) return false;
            if (!DeepComparable.Matches(Form, otherT.Form)) return false;
            if ( !DeepComparable.Matches(Error, otherT.Error)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as EligibilityResponse;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(RequestProvider, otherT.RequestProvider)) return false;
            if (!DeepComparable.IsExactly(RequestOrganization, otherT.RequestOrganization)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.IsExactly(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.IsExactly(InforceElement, otherT.InforceElement)) return false;
            if (!DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;
            if (!DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if (!DeepComparable.IsExactly(Error, otherT.Error)) return false;

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
                if (RequestProvider != null) yield return RequestProvider;
                if (RequestOrganization != null) yield return RequestOrganization;
                if (Request != null) yield return Request;
                if (Outcome != null) yield return Outcome;
                if (DispositionElement != null) yield return DispositionElement;
                if (Insurer != null) yield return Insurer;
                if (InforceElement != null) yield return InforceElement;
                foreach (var elem in Insurance) { if (elem != null) yield return elem; }
                if (Form != null) yield return Form;
                foreach (var elem in Error) { if (elem != null) yield return elem; }
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
                if (RequestProvider != null) yield return new ElementValue("requestProvider", RequestProvider);
                if (RequestOrganization != null) yield return new ElementValue("requestOrganization", RequestOrganization);
                if (Request != null) yield return new ElementValue("request", Request);
                if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                if (DispositionElement != null) yield return new ElementValue("disposition", DispositionElement);
                if (Insurer != null) yield return new ElementValue("insurer", Insurer);
                if (InforceElement != null) yield return new ElementValue("inforce", InforceElement);
                foreach (var elem in Insurance) { if (elem != null) yield return new ElementValue("insurance", elem); }
                if (Form != null) yield return new ElementValue("form", Form);
                foreach (var elem in Error) { if (elem != null) yield return new ElementValue("error", elem); }
            }
        }

    }

}
