using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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
    /// Details of a Health Insurance product/plan provided by an organization
    /// </summary>
    [FhirType("ProductPlan", IsResource=true)]
    [DataContract]
    public partial class ProductPlan : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ProductPlan; } }
        [NotMapped]
        public override string TypeName { get { return "ProductPlan"; } }


        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }

            /// <summary>
            /// The type of contact
            /// </summary>
            [FhirElement("purpose", Order=40)]
            [DataMember]
            public CodeableConcept Purpose
            {
                get { return _purpose; }
                set { _purpose = value; OnPropertyChanged("Purpose"); }
            }

            private CodeableConcept _purpose;

            /// <summary>
            /// A name associated with the contact
            /// </summary>
            [FhirElement("name", Order=50)]
            [DataMember]
            public HumanName Name
            {
                get { return _name; }
                set { _name = value; OnPropertyChanged("Name"); }
            }

            private HumanName _name;

            /// <summary>
            /// Contact details (telephone, email, etc.)  for a contact
            /// </summary>
            [FhirElement("telecom", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContactPoint> Telecom
            {
                get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
                set { _telecom = value; OnPropertyChanged("Telecom"); }
            }

            private List<ContactPoint> _telecom;

            /// <summary>
            /// Visiting or postal addresses for the contact
            /// </summary>
            [FhirElement("address", Order=70)]
            [DataMember]
            public Address Address
            {
                get { return _address; }
                set { _address = value; OnPropertyChanged("Address"); }
            }

            private Address _address;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Purpose != null) dest.Purpose = (CodeableConcept)Purpose.DeepCopy();
                    if (Name != null) dest.Name = (HumanName)Name.DeepCopy();
                    if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                    if (Address != null) dest.Address = (Address)Address.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContactComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
                if (!DeepComparable.Matches(Name, otherT.Name)) return false;
                if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
                if (!DeepComparable.Matches(Address, otherT.Address)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
                if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
                if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Purpose != null) yield return Purpose;
                    if (Name != null) yield return Name;
                    foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                    if (Address != null) yield return Address;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Purpose != null) yield return new ElementValue("purpose", false, Purpose);
                    if (Name != null) yield return new ElementValue("name", false, Name);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", true, elem); }
                    if (Address != null) yield return new ElementValue("address", false, Address);
                }
            }


        }


        [FhirType("CoverageComponent")]
        [DataContract]
        public partial class CoverageComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CoverageComponent"; } }

            /// <summary>
            /// Type of coverage
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
            /// Specific benefits under this type of coverage
            /// </summary>
            [FhirElement("benefit", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<CoverageBenefitComponent> Benefit
            {
                get { if (_benefit==null) _benefit = new List<CoverageBenefitComponent>(); return _benefit; }
                set { _benefit = value; OnPropertyChanged("Benefit"); }
            }

            private List<CoverageBenefitComponent> _benefit;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CoverageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Benefit != null) dest.Benefit = new List<CoverageBenefitComponent>(Benefit.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CoverageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CoverageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Benefit, otherT.Benefit)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CoverageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Benefit, otherT.Benefit)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Benefit) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    foreach (var elem in Benefit) { if (elem != null) yield return new ElementValue("benefit", true, elem); }
                }
            }


        }


        [FhirType("CoverageBenefitComponent")]
        [DataContract]
        public partial class CoverageBenefitComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CoverageBenefitComponent"; } }

            /// <summary>
            /// Type of benefit
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
            /// Specific benefit and related value
            /// </summary>
            [FhirElement("item", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ItemComponent> Item
            {
                get { if (_item==null) _item = new List<ItemComponent>(); return _item; }
                set { _item = value; OnPropertyChanged("Item"); }
            }

            private List<ItemComponent> _item;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CoverageBenefitComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CoverageBenefitComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CoverageBenefitComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Item, otherT.Item)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CoverageBenefitComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Item) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", true, elem); }
                }
            }


        }


        [FhirType("ItemComponent")]
        [DataContract]
        public partial class ItemComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemComponent"; } }

            /// <summary>
            /// Coded Details of the specific benefit (days; visits)
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

            /// <summary>
            /// Value of the specific benefit
            /// </summary>
            [FhirElement("benefitValue", Order=50)]
            [DataMember]
            public Quantity BenefitValue
            {
                get { return _benefitValue; }
                set { _benefitValue = value; OnPropertyChanged("BenefitValue"); }
            }

            private Quantity _benefitValue;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (BenefitValue != null) dest.BenefitValue = (Quantity)BenefitValue.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(BenefitValue, otherT.BenefitValue)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(BenefitValue, otherT.BenefitValue)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (BenefitValue != null) yield return BenefitValue;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (BenefitValue != null) yield return new ElementValue("benefitValue", false, BenefitValue);
                }
            }


        }


        [FhirType("PlanComponent")]
        [DataContract]
        public partial class PlanComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PlanComponent"; } }

            /// <summary>
            /// Type of plan
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
            /// Additional descriptive content about the plan
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Additional descriptive content about the plan
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
            /// Plan premium
            /// </summary>
            [FhirElement("premium", Order=60)]
            [DataMember]
            public Money Premium
            {
                get { return _premium; }
                set { _premium = value; OnPropertyChanged("Premium"); }
            }

            private Money _premium;

            /// <summary>
            /// List of the costs associated with plan benefits
            /// </summary>
            [FhirElement("category", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CategoryComponent> Category
            {
                get { if (_category==null) _category = new List<CategoryComponent>(); return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private List<CategoryComponent> _category;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PlanComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Premium != null) dest.Premium = (Money)Premium.DeepCopy();
                    if (Category != null) dest.Category = new List<CategoryComponent>(Category.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PlanComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PlanComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Premium, otherT.Premium)) return false;
                if ( !DeepComparable.Matches(Category, otherT.Category)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PlanComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Premium, otherT.Premium)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Premium != null) yield return Premium;
                    foreach (var elem in Category) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (Premium != null) yield return new ElementValue("premium", false, Premium);
                    foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", true, elem); }
                }
            }


        }


        [FhirType("CategoryComponent")]
        [DataContract]
        public partial class CategoryComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CategoryComponent"; } }

            /// <summary>
            /// General category of benefit (Medical; Dental; Vision; Drug; Mental Health; Substance Abuse; Hospice, Home Health)
            /// </summary>
            [FhirElement("code", Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// List of the specific benefits under this category of benefit
            /// </summary>
            [FhirElement("benefit", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PlanBenefitComponent> Benefit
            {
                get { if (_benefit==null) _benefit = new List<PlanBenefitComponent>(); return _benefit; }
                set { _benefit = value; OnPropertyChanged("Benefit"); }
            }

            private List<PlanBenefitComponent> _benefit;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CategoryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Benefit != null) dest.Benefit = new List<PlanBenefitComponent>(Benefit.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CategoryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CategoryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if ( !DeepComparable.Matches(Benefit, otherT.Benefit)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CategoryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Benefit, otherT.Benefit)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in Benefit) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    foreach (var elem in Benefit) { if (elem != null) yield return new ElementValue("benefit", true, elem); }
                }
            }


        }


        [FhirType("PlanBenefitComponent")]
        [DataContract]
        public partial class PlanBenefitComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PlanBenefitComponent"; } }

            /// <summary>
            /// Type of specific benefit (preventative; primary care office visit; speciality office visit; hospitalization; emergency room; urgent care)
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
            /// List of the costs associated with a specific benefit
            /// </summary>
            [FhirElement("cost", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CostComponent> Cost
            {
                get { if (_cost==null) _cost = new List<CostComponent>(); return _cost; }
                set { _cost = value; OnPropertyChanged("Cost"); }
            }

            private List<CostComponent> _cost;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PlanBenefitComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Cost != null) dest.Cost = new List<CostComponent>(Cost.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PlanBenefitComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PlanBenefitComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Cost, otherT.Cost)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PlanBenefitComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Cost, otherT.Cost)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Cost) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    foreach (var elem in Cost) { if (elem != null) yield return new ElementValue("cost", true, elem); }
                }
            }


        }


        [FhirType("CostComponent")]
        [DataContract]
        public partial class CostComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CostComponent"; } }

            /// <summary>
            /// Type of cost (copay; individual cap; family cap; coinsurance; deductible)
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
            /// Whether the cost applies to in-network or out-of-network providers (in-network; out-of-network; other)
            /// </summary>
            [FhirElement("applicability", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Applicability
            {
                get { if (_applicability==null) _applicability = new List<Coding>(); return _applicability; }
                set { _applicability = value; OnPropertyChanged("Applicability"); }
            }

            private List<Coding> _applicability;

            /// <summary>
            /// Additional information about the cost, such as information about funding sources (e.g. HSA, HRA, FSA, RRA)
            /// </summary>
            [FhirElement("qualifiers", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> QualifiersElement
            {
                get { if (_qualifiersElement==null) _qualifiersElement = new List<FhirString>(); return _qualifiersElement; }
                set { _qualifiersElement = value; OnPropertyChanged("QualifiersElement"); }
            }

            private List<FhirString> _qualifiersElement;

            /// <summary>
            /// Additional information about the cost, such as information about funding sources (e.g. HSA, HRA, FSA, RRA)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Qualifiers
            {
                get { return QualifiersElement != null ? QualifiersElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        QualifiersElement = null;
                    else
                        QualifiersElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Qualifiers");
                }
            }

            /// <summary>
            /// The actual cost value
            /// </summary>
            [FhirElement("value", Order=70)]
            [DataMember]
            public Quantity Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Quantity _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CostComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Applicability != null) dest.Applicability = new List<Coding>(Applicability.DeepCopy());
                    if (QualifiersElement != null) dest.QualifiersElement = new List<FhirString>(QualifiersElement.DeepCopy());
                    if (Value != null) dest.Value = (Quantity)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CostComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CostComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Applicability, otherT.Applicability)) return false;
                if ( !DeepComparable.Matches(QualifiersElement, otherT.QualifiersElement)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CostComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Applicability, otherT.Applicability)) return false;
                if (!DeepComparable.IsExactly(QualifiersElement, otherT.QualifiersElement)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Applicability) { if (elem != null) yield return elem; }
                    foreach (var elem in QualifiersElement) { if (elem != null) yield return elem; }
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    foreach (var elem in Applicability) { if (elem != null) yield return new ElementValue("applicability", true, elem); }
                    foreach (var elem in QualifiersElement) { if (elem != null) yield return new ElementValue("qualifiers", true, elem); }
                    if (Value != null) yield return new ElementValue("value", false, Value);
                }
            }


        }


        /// <summary>
        /// Identifies this product/plan  across multiple systems
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<PublicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<PublicationStatus> _statusElement;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Kind of product/plan
        /// </summary>
        [FhirElement("type", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Type
        {
            get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private List<CodeableConcept> _type;

        /// <summary>
        /// Official name
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Official name
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
        /// A list of alternate names that the product/plan is known as, or was known as in the past
        /// </summary>
        [FhirElement("alias", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> AliasElement
        {
            get { if (_aliasElement==null) _aliasElement = new List<FhirString>(); return _aliasElement; }
            set { _aliasElement = value; OnPropertyChanged("AliasElement"); }
        }

        private List<FhirString> _aliasElement;

        /// <summary>
        /// A list of alternate names that the product/plan is known as, or was known as in the past
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Alias
        {
            get { return AliasElement != null ? AliasElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    AliasElement = null;
                else
                    AliasElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Alias");
            }
        }

        /// <summary>
        /// The time period the product/plan is available
        /// </summary>
        [FhirElement("period", Order=140)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Owner of the product/plan
        /// </summary>
        [FhirElement("ownedBy", InSummary=true, Order=150)]
        [References("Organization")]
        [DataMember]
        public ResourceReference OwnedBy
        {
            get { return _ownedBy; }
            set { _ownedBy = value; OnPropertyChanged("OwnedBy"); }
        }

        private ResourceReference _ownedBy;

        /// <summary>
        /// Administrator of the product/plan
        /// </summary>
        [FhirElement("administeredBy", InSummary=true, Order=160)]
        [References("Organization")]
        [DataMember]
        public ResourceReference AdministeredBy
        {
            get { return _administeredBy; }
            set { _administeredBy = value; OnPropertyChanged("AdministeredBy"); }
        }

        private ResourceReference _administeredBy;

        /// <summary>
        /// An address for the organization
        /// </summary>
        [FhirElement("address", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Address> Address
        {
            get { if (_address==null) _address = new List<Address>(); return _address; }
            set { _address = value; OnPropertyChanged("Address"); }
        }

        private List<Address> _address;

        /// <summary>
        /// The geographic region in which this product/plan is available
        /// </summary>
        [FhirElement("coverageArea", InSummary=true, Order=180)]
        [References("Location")]
        [DataMember]
        public ResourceReference CoverageArea
        {
            get { return _coverageArea; }
            set { _coverageArea = value; OnPropertyChanged("CoverageArea"); }
        }

        private ResourceReference _coverageArea;

        /// <summary>
        /// Contact for the product/plan for a certain purpose
        /// </summary>
        [FhirElement("contact", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact==null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// Details about the coverage offered by the insurance product
        /// </summary>
        [FhirElement("coverage", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CoverageComponent> Coverage
        {
            get { if (_coverage==null) _coverage = new List<CoverageComponent>(); return _coverage; }
            set { _coverage = value; OnPropertyChanged("Coverage"); }
        }

        private List<CoverageComponent> _coverage;

        /// <summary>
        /// Details about an insurance plan
        /// </summary>
        [FhirElement("plan", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PlanComponent> Plan
        {
            get { if (_plan==null) _plan = new List<PlanComponent>(); return _plan; }
            set { _plan = value; OnPropertyChanged("Plan"); }
        }

        private List<PlanComponent> _plan;

        /// <summary>
        /// Technical endpoints providing access to services operated for the organization
        /// </summary>
        [FhirElement("endpoint", Order=220)]
        [References("Endpoint")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Endpoint
        {
            get { if (_endpoint==null) _endpoint = new List<ResourceReference>(); return _endpoint; }
            set { _endpoint = value; OnPropertyChanged("Endpoint"); }
        }

        private List<ResourceReference> _endpoint;


        public static ElementDefinition.ConstraintComponent ProductPlan_PPN_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(identifier.count() + name.count()) > 0",
            Key = "ppn-1",
            Severity = ConstraintSeverity.Warning,
            Human = "The organization SHALL at least have a name or an id, and possibly more than one",
            Xpath = "count(f:identifier | f:name) > 0"
        };

        public static ElementDefinition.ConstraintComponent ProductPlan_PPN_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "address.all(where(use = 'home').empty())",
            Key = "ppn-2",
            Severity = ConstraintSeverity.Warning,
            Human = "An address of an organization can never be of use 'home'",
            Xpath = "count(f:use[@value='home']) = 0"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ProductPlan_PPN_1);
            InvariantConstraints.Add(ProductPlan_PPN_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ProductPlan;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (AliasElement != null) dest.AliasElement = new List<FhirString>(AliasElement.DeepCopy());
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (OwnedBy != null) dest.OwnedBy = (ResourceReference)OwnedBy.DeepCopy();
                if (AdministeredBy != null) dest.AdministeredBy = (ResourceReference)AdministeredBy.DeepCopy();
                if (Address != null) dest.Address = new List<Address>(Address.DeepCopy());
                if (CoverageArea != null) dest.CoverageArea = (ResourceReference)CoverageArea.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (Coverage != null) dest.Coverage = new List<CoverageComponent>(Coverage.DeepCopy());
                if (Plan != null) dest.Plan = new List<PlanComponent>(Plan.DeepCopy());
                if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ProductPlan());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ProductPlan;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if ( !DeepComparable.Matches(AliasElement, otherT.AliasElement)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(OwnedBy, otherT.OwnedBy)) return false;
            if (!DeepComparable.Matches(AdministeredBy, otherT.AdministeredBy)) return false;
            if ( !DeepComparable.Matches(Address, otherT.Address)) return false;
            if (!DeepComparable.Matches(CoverageArea, otherT.CoverageArea)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if ( !DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
            if ( !DeepComparable.Matches(Plan, otherT.Plan)) return false;
            if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ProductPlan;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(AliasElement, otherT.AliasElement)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(OwnedBy, otherT.OwnedBy)) return false;
            if (!DeepComparable.IsExactly(AdministeredBy, otherT.AdministeredBy)) return false;
            if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if (!DeepComparable.IsExactly(CoverageArea, otherT.CoverageArea)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
            if (!DeepComparable.IsExactly(Plan, otherT.Plan)) return false;
            if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;

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
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                if (NameElement != null) yield return NameElement;
                foreach (var elem in AliasElement) { if (elem != null) yield return elem; }
                if (Period != null) yield return Period;
                if (OwnedBy != null) yield return OwnedBy;
                if (AdministeredBy != null) yield return AdministeredBy;
                foreach (var elem in Address) { if (elem != null) yield return elem; }
                if (CoverageArea != null) yield return CoverageArea;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                foreach (var elem in Coverage) { if (elem != null) yield return elem; }
                foreach (var elem in Plan) { if (elem != null) yield return elem; }
                foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
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
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", true, elem); }
                if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                foreach (var elem in AliasElement) { if (elem != null) yield return new ElementValue("alias", true, elem); }
                if (Period != null) yield return new ElementValue("period", false, Period);
                if (OwnedBy != null) yield return new ElementValue("ownedBy", false, OwnedBy);
                if (AdministeredBy != null) yield return new ElementValue("administeredBy", false, AdministeredBy);
                foreach (var elem in Address) { if (elem != null) yield return new ElementValue("address", true, elem); }
                if (CoverageArea != null) yield return new ElementValue("coverageArea", false, CoverageArea);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", true, elem); }
                foreach (var elem in Coverage) { if (elem != null) yield return new ElementValue("coverage", true, elem); }
                foreach (var elem in Plan) { if (elem != null) yield return new ElementValue("plan", true, elem); }
                foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", true, elem); }
            }
        }

    }

}
