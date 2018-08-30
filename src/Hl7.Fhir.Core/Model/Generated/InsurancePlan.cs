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
    /// Details of a Health Insurance product/plan provided by an organization
    /// </summary>
    [FhirType("InsurancePlan", IsResource=true)]
    [DataContract]
    public partial class InsurancePlan : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.InsurancePlan; } }
        [NotMapped]
        public override string TypeName { get { return "InsurancePlan"; } }


        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : BackboneElement, IBackboneElement
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
                    if (Purpose != null) yield return new ElementValue("purpose", Purpose);
                    if (Name != null) yield return new ElementValue("name", Name);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                    if (Address != null) yield return new ElementValue("address", Address);
                }
            }


        }


        [FhirType("CoverageComponent")]
        [DataContract]
        public partial class CoverageComponent : BackboneElement, IBackboneElement
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
            /// What networks provide coverage
            /// </summary>
            [FhirElement("network", Order=50)]
            [References("Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Network
            {
                get { if (_network==null) _network = new List<ResourceReference>(); return _network; }
                set { _network = value; OnPropertyChanged("Network"); }
            }

            private List<ResourceReference> _network;

            /// <summary>
            /// List of benefits
            /// </summary>
            [FhirElement("benefit", Order=60)]
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
                    if (Network != null) dest.Network = new List<ResourceReference>(Network.DeepCopy());
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
                if ( !DeepComparable.Matches(Network, otherT.Network)) return false;
                if ( !DeepComparable.Matches(Benefit, otherT.Benefit)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CoverageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Network, otherT.Network)) return false;
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
                    foreach (var elem in Network) { if (elem != null) yield return elem; }
                    foreach (var elem in Benefit) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Network) { if (elem != null) yield return new ElementValue("network", elem); }
                    foreach (var elem in Benefit) { if (elem != null) yield return new ElementValue("benefit", elem); }
                }
            }


        }


        [FhirType("CoverageBenefitComponent")]
        [DataContract]
        public partial class CoverageBenefitComponent : BackboneElement, IBackboneElement
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
            /// Referral requirements
            /// </summary>
            [FhirElement("requirement", Order=50)]
            [DataMember]
            public FhirString RequirementElement
            {
                get { return _requirementElement; }
                set { _requirementElement = value; OnPropertyChanged("RequirementElement"); }
            }

            private FhirString _requirementElement;

            /// <summary>
            /// Referral requirements
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Requirement
            {
                get { return RequirementElement != null ? RequirementElement.Value : null; }
                set
                {
                    if (value == null)
                        RequirementElement = null;
                    else
                        RequirementElement = new FhirString(value);
                    OnPropertyChanged("Requirement");
                }
            }

            /// <summary>
            /// Benefit limits
            /// </summary>
            [FhirElement("limit", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<LimitComponent> Limit
            {
                get { if (_limit==null) _limit = new List<LimitComponent>(); return _limit; }
                set { _limit = value; OnPropertyChanged("Limit"); }
            }

            private List<LimitComponent> _limit;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CoverageBenefitComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (RequirementElement != null) dest.RequirementElement = (FhirString)RequirementElement.DeepCopy();
                    if (Limit != null) dest.Limit = new List<LimitComponent>(Limit.DeepCopy());
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
                if (!DeepComparable.Matches(RequirementElement, otherT.RequirementElement)) return false;
                if ( !DeepComparable.Matches(Limit, otherT.Limit)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CoverageBenefitComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(RequirementElement, otherT.RequirementElement)) return false;
                if (!DeepComparable.IsExactly(Limit, otherT.Limit)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (RequirementElement != null) yield return RequirementElement;
                    foreach (var elem in Limit) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (RequirementElement != null) yield return new ElementValue("requirement", RequirementElement);
                    foreach (var elem in Limit) { if (elem != null) yield return new ElementValue("limit", elem); }
                }
            }


        }


        [FhirType("LimitComponent")]
        [DataContract]
        public partial class LimitComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LimitComponent"; } }

            /// <summary>
            /// Maximum value allowed
            /// </summary>
            [FhirElement("value", Order=40)]
            [DataMember]
            public Quantity Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Quantity _value;

            /// <summary>
            /// Benefit limit details
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LimitComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Value != null) dest.Value = (Quantity)Value.DeepCopy();
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LimitComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LimitComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LimitComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Value != null) yield return Value;
                    if (Code != null) yield return Code;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Value != null) yield return new ElementValue("value", Value);
                    if (Code != null) yield return new ElementValue("code", Code);
                }
            }


        }


        [FhirType("PlanComponent")]
        [DataContract]
        public partial class PlanComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PlanComponent"; } }

            /// <summary>
            /// Business Identifier for Product
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Identifier> Identifier
            {
                get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private List<Identifier> _identifier;

            /// <summary>
            /// Type of plan
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Where product applies
            /// </summary>
            [FhirElement("coverageArea", InSummary=true, Order=60)]
            [References("Location")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> CoverageArea
            {
                get { if (_coverageArea==null) _coverageArea = new List<ResourceReference>(); return _coverageArea; }
                set { _coverageArea = value; OnPropertyChanged("CoverageArea"); }
            }

            private List<ResourceReference> _coverageArea;

            /// <summary>
            /// What networks provide coverage
            /// </summary>
            [FhirElement("network", Order=70)]
            [References("Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Network
            {
                get { if (_network==null) _network = new List<ResourceReference>(); return _network; }
                set { _network = value; OnPropertyChanged("Network"); }
            }

            private List<ResourceReference> _network;

            /// <summary>
            /// Overall costs
            /// </summary>
            [FhirElement("generalCost", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<GeneralCostComponent> GeneralCost
            {
                get { if (_generalCost==null) _generalCost = new List<GeneralCostComponent>(); return _generalCost; }
                set { _generalCost = value; OnPropertyChanged("GeneralCost"); }
            }

            private List<GeneralCostComponent> _generalCost;

            /// <summary>
            /// Specific costs
            /// </summary>
            [FhirElement("specificCost", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SpecificCostComponent> SpecificCost
            {
                get { if (_specificCost==null) _specificCost = new List<SpecificCostComponent>(); return _specificCost; }
                set { _specificCost = value; OnPropertyChanged("SpecificCost"); }
            }

            private List<SpecificCostComponent> _specificCost;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PlanComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (CoverageArea != null) dest.CoverageArea = new List<ResourceReference>(CoverageArea.DeepCopy());
                    if (Network != null) dest.Network = new List<ResourceReference>(Network.DeepCopy());
                    if (GeneralCost != null) dest.GeneralCost = new List<GeneralCostComponent>(GeneralCost.DeepCopy());
                    if (SpecificCost != null) dest.SpecificCost = new List<SpecificCostComponent>(SpecificCost.DeepCopy());
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
                if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(CoverageArea, otherT.CoverageArea)) return false;
                if ( !DeepComparable.Matches(Network, otherT.Network)) return false;
                if ( !DeepComparable.Matches(GeneralCost, otherT.GeneralCost)) return false;
                if ( !DeepComparable.Matches(SpecificCost, otherT.SpecificCost)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PlanComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(CoverageArea, otherT.CoverageArea)) return false;
                if (!DeepComparable.IsExactly(Network, otherT.Network)) return false;
                if (!DeepComparable.IsExactly(GeneralCost, otherT.GeneralCost)) return false;
                if (!DeepComparable.IsExactly(SpecificCost, otherT.SpecificCost)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                    if (Type != null) yield return Type;
                    foreach (var elem in CoverageArea) { if (elem != null) yield return elem; }
                    foreach (var elem in Network) { if (elem != null) yield return elem; }
                    foreach (var elem in GeneralCost) { if (elem != null) yield return elem; }
                    foreach (var elem in SpecificCost) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in CoverageArea) { if (elem != null) yield return new ElementValue("coverageArea", elem); }
                    foreach (var elem in Network) { if (elem != null) yield return new ElementValue("network", elem); }
                    foreach (var elem in GeneralCost) { if (elem != null) yield return new ElementValue("generalCost", elem); }
                    foreach (var elem in SpecificCost) { if (elem != null) yield return new ElementValue("specificCost", elem); }
                }
            }


        }


        [FhirType("GeneralCostComponent")]
        [DataContract]
        public partial class GeneralCostComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GeneralCostComponent"; } }

            /// <summary>
            /// Type of cost
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
            /// Number of enrollees
            /// </summary>
            [FhirElement("groupSize", Order=50)]
            [DataMember]
            public PositiveInt GroupSizeElement
            {
                get { return _groupSizeElement; }
                set { _groupSizeElement = value; OnPropertyChanged("GroupSizeElement"); }
            }

            private PositiveInt _groupSizeElement;

            /// <summary>
            /// Number of enrollees
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? GroupSize
            {
                get { return GroupSizeElement != null ? GroupSizeElement.Value : null; }
                set
                {
                    if (value == null)
                        GroupSizeElement = null;
                    else
                        GroupSizeElement = new PositiveInt(value);
                    OnPropertyChanged("GroupSize");
                }
            }

            /// <summary>
            /// Cost value
            /// </summary>
            [FhirElement("cost", Order=60)]
            [DataMember]
            public Money Cost
            {
                get { return _cost; }
                set { _cost = value; OnPropertyChanged("Cost"); }
            }

            private Money _cost;

            /// <summary>
            /// Additional cost information
            /// </summary>
            [FhirElement("comment", Order=70)]
            [DataMember]
            public FhirString CommentElement
            {
                get { return _commentElement; }
                set { _commentElement = value; OnPropertyChanged("CommentElement"); }
            }

            private FhirString _commentElement;

            /// <summary>
            /// Additional cost information
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Comment
            {
                get { return CommentElement != null ? CommentElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentElement = null;
                    else
                        CommentElement = new FhirString(value);
                    OnPropertyChanged("Comment");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GeneralCostComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (GroupSizeElement != null) dest.GroupSizeElement = (PositiveInt)GroupSizeElement.DeepCopy();
                    if (Cost != null) dest.Cost = (Money)Cost.DeepCopy();
                    if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GeneralCostComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GeneralCostComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(GroupSizeElement, otherT.GroupSizeElement)) return false;
                if (!DeepComparable.Matches(Cost, otherT.Cost)) return false;
                if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GeneralCostComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(GroupSizeElement, otherT.GroupSizeElement)) return false;
                if (!DeepComparable.IsExactly(Cost, otherT.Cost)) return false;
                if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (GroupSizeElement != null) yield return GroupSizeElement;
                    if (Cost != null) yield return Cost;
                    if (CommentElement != null) yield return CommentElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (GroupSizeElement != null) yield return new ElementValue("groupSize", GroupSizeElement);
                    if (Cost != null) yield return new ElementValue("cost", Cost);
                    if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                }
            }


        }


        [FhirType("SpecificCostComponent")]
        [DataContract]
        public partial class SpecificCostComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SpecificCostComponent"; } }

            /// <summary>
            /// General category of benefit
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
            /// Benefits list
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
                var dest = other as SpecificCostComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Benefit != null) dest.Benefit = new List<PlanBenefitComponent>(Benefit.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SpecificCostComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SpecificCostComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if ( !DeepComparable.Matches(Benefit, otherT.Benefit)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SpecificCostComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Benefit, otherT.Benefit)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    foreach (var elem in Benefit) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", Category);
                    foreach (var elem in Benefit) { if (elem != null) yield return new ElementValue("benefit", elem); }
                }
            }


        }


        [FhirType("PlanBenefitComponent")]
        [DataContract]
        public partial class PlanBenefitComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PlanBenefitComponent"; } }

            /// <summary>
            /// Type of specific benefit
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
            /// List of the costs
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
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Cost) { if (elem != null) yield return new ElementValue("cost", elem); }
                }
            }


        }


        [FhirType("CostComponent")]
        [DataContract]
        public partial class CostComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CostComponent"; } }

            /// <summary>
            /// Type of cost
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
            /// in-network | out-of-network | other
            /// </summary>
            [FhirElement("applicability", Order=50)]
            [DataMember]
            public CodeableConcept Applicability
            {
                get { return _applicability; }
                set { _applicability = value; OnPropertyChanged("Applicability"); }
            }

            private CodeableConcept _applicability;

            /// <summary>
            /// Additional information about the cost
            /// </summary>
            [FhirElement("qualifiers", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Qualifiers
            {
                get { if (_qualifiers==null) _qualifiers = new List<CodeableConcept>(); return _qualifiers; }
                set { _qualifiers = value; OnPropertyChanged("Qualifiers"); }
            }

            private List<CodeableConcept> _qualifiers;

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
                    if (Applicability != null) dest.Applicability = (CodeableConcept)Applicability.DeepCopy();
                    if (Qualifiers != null) dest.Qualifiers = new List<CodeableConcept>(Qualifiers.DeepCopy());
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
                if (!DeepComparable.Matches(Applicability, otherT.Applicability)) return false;
                if ( !DeepComparable.Matches(Qualifiers, otherT.Qualifiers)) return false;
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
                if (!DeepComparable.IsExactly(Qualifiers, otherT.Qualifiers)) return false;
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
                    if (Applicability != null) yield return Applicability;
                    foreach (var elem in Qualifiers) { if (elem != null) yield return elem; }
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Applicability != null) yield return new ElementValue("applicability", Applicability);
                    foreach (var elem in Qualifiers) { if (elem != null) yield return new ElementValue("qualifiers", elem); }
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        /// <summary>
        /// Business Identifier for Product
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
        /// Kind of product
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
        /// Alternate names
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
        /// Alternate names
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
        /// When the product is available
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
        /// Plan issuer
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
        /// Product administrator
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
        /// Where product applies
        /// </summary>
        [FhirElement("coverageArea", InSummary=true, Order=170)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> CoverageArea
        {
            get { if (_coverageArea==null) _coverageArea = new List<ResourceReference>(); return _coverageArea; }
            set { _coverageArea = value; OnPropertyChanged("CoverageArea"); }
        }

        private List<ResourceReference> _coverageArea;

        /// <summary>
        /// Contact for the product
        /// </summary>
        [FhirElement("contact", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact==null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// Technical endpoint
        /// </summary>
        [FhirElement("endpoint", Order=190)]
        [References("Endpoint")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Endpoint
        {
            get { if (_endpoint==null) _endpoint = new List<ResourceReference>(); return _endpoint; }
            set { _endpoint = value; OnPropertyChanged("Endpoint"); }
        }

        private List<ResourceReference> _endpoint;

        /// <summary>
        /// What networks are Included
        /// </summary>
        [FhirElement("network", Order=200)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Network
        {
            get { if (_network==null) _network = new List<ResourceReference>(); return _network; }
            set { _network = value; OnPropertyChanged("Network"); }
        }

        private List<ResourceReference> _network;

        /// <summary>
        /// Coverage details
        /// </summary>
        [FhirElement("coverage", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CoverageComponent> Coverage
        {
            get { if (_coverage==null) _coverage = new List<CoverageComponent>(); return _coverage; }
            set { _coverage = value; OnPropertyChanged("Coverage"); }
        }

        private List<CoverageComponent> _coverage;

        /// <summary>
        /// Plan details
        /// </summary>
        [FhirElement("plan", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PlanComponent> Plan
        {
            get { if (_plan==null) _plan = new List<PlanComponent>(); return _plan; }
            set { _plan = value; OnPropertyChanged("Plan"); }
        }

        private List<PlanComponent> _plan;


        public static ElementDefinition.ConstraintComponent InsurancePlan_IPN_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(identifier.count() + name.count()) > 0",
            Key = "ipn-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "The organization SHALL at least have a name or an idendtifier, and possibly more than one",
            Xpath = "count(f:identifier | f:name) > 0"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(InsurancePlan_IPN_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as InsurancePlan;

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
                if (CoverageArea != null) dest.CoverageArea = new List<ResourceReference>(CoverageArea.DeepCopy());
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
                if (Network != null) dest.Network = new List<ResourceReference>(Network.DeepCopy());
                if (Coverage != null) dest.Coverage = new List<CoverageComponent>(Coverage.DeepCopy());
                if (Plan != null) dest.Plan = new List<PlanComponent>(Plan.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new InsurancePlan());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as InsurancePlan;
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
            if ( !DeepComparable.Matches(CoverageArea, otherT.CoverageArea)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;
            if ( !DeepComparable.Matches(Network, otherT.Network)) return false;
            if ( !DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
            if ( !DeepComparable.Matches(Plan, otherT.Plan)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as InsurancePlan;
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
            if (!DeepComparable.IsExactly(CoverageArea, otherT.CoverageArea)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;
            if (!DeepComparable.IsExactly(Network, otherT.Network)) return false;
            if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
            if (!DeepComparable.IsExactly(Plan, otherT.Plan)) return false;

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
                foreach (var elem in CoverageArea) { if (elem != null) yield return elem; }
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
                foreach (var elem in Network) { if (elem != null) yield return elem; }
                foreach (var elem in Coverage) { if (elem != null) yield return elem; }
                foreach (var elem in Plan) { if (elem != null) yield return elem; }
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
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                foreach (var elem in AliasElement) { if (elem != null) yield return new ElementValue("alias", elem); }
                if (Period != null) yield return new ElementValue("period", Period);
                if (OwnedBy != null) yield return new ElementValue("ownedBy", OwnedBy);
                if (AdministeredBy != null) yield return new ElementValue("administeredBy", AdministeredBy);
                foreach (var elem in CoverageArea) { if (elem != null) yield return new ElementValue("coverageArea", elem); }
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
                foreach (var elem in Network) { if (elem != null) yield return new ElementValue("network", elem); }
                foreach (var elem in Coverage) { if (elem != null) yield return new ElementValue("coverage", elem); }
                foreach (var elem in Plan) { if (elem != null) yield return new ElementValue("plan", elem); }
            }
        }

    }

}
