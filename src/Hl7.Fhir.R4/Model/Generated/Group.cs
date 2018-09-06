using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Group of multiple entities
    /// </summary>
    [FhirType("Group", IsResource=true)]
    [DataContract]
    public partial class Group : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Group; } }
        [NotMapped]
        public override string TypeName { get { return "Group"; } }

        /// <summary>
        /// Types of resources that are part of group.
        /// (url: http://hl7.org/fhir/ValueSet/group-type)
        /// </summary>
        [FhirEnumeration("GroupType")]
        public enum GroupType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/group-type)
            /// </summary>
            [EnumLiteral("person", "http://hl7.org/fhir/group-type"), Description("Person")]
            Person,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/group-type)
            /// </summary>
            [EnumLiteral("animal", "http://hl7.org/fhir/group-type"), Description("Animal")]
            Animal,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/group-type)
            /// </summary>
            [EnumLiteral("practitioner", "http://hl7.org/fhir/group-type"), Description("Practitioner")]
            Practitioner,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/group-type)
            /// </summary>
            [EnumLiteral("device", "http://hl7.org/fhir/group-type"), Description("Device")]
            Device,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/group-type)
            /// </summary>
            [EnumLiteral("medication", "http://hl7.org/fhir/group-type"), Description("Medication")]
            Medication,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/group-type)
            /// </summary>
            [EnumLiteral("substance", "http://hl7.org/fhir/group-type"), Description("Substance")]
            Substance,
        }


        [FhirType("CharacteristicComponent")]
        [DataContract]
        public partial class CharacteristicComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CharacteristicComponent"; } }

            /// <summary>
            /// Kind of characteristic
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
            /// Value held by characteristic
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(FhirBoolean),typeof(Quantity),typeof(Range))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            /// <summary>
            /// Group includes or excludes
            /// </summary>
            [FhirElement("exclude", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean ExcludeElement
            {
                get { return _excludeElement; }
                set { _excludeElement = value; OnPropertyChanged("ExcludeElement"); }
            }

            private FhirBoolean _excludeElement;

            /// <summary>
            /// Group includes or excludes
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Exclude
            {
                get { return ExcludeElement != null ? ExcludeElement.Value : null; }
                set
                {
                    if (value == null)
                        ExcludeElement = null;
                    else
                        ExcludeElement = new FhirBoolean(value);
                    OnPropertyChanged("Exclude");
                }
            }

            /// <summary>
            /// Period over which characteristic is tested
            /// </summary>
            [FhirElement("period", Order=70)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CharacteristicComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    if (ExcludeElement != null) dest.ExcludeElement = (FhirBoolean)ExcludeElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CharacteristicComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CharacteristicComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;
                if (!DeepComparable.Matches(ExcludeElement, otherT.ExcludeElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CharacteristicComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if (!DeepComparable.IsExactly(ExcludeElement, otherT.ExcludeElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Value != null) yield return Value;
                    if (ExcludeElement != null) yield return ExcludeElement;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Value != null) yield return new ElementValue("value", Value);
                    if (ExcludeElement != null) yield return new ElementValue("exclude", ExcludeElement);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }


        }


        [FhirType("MemberComponent")]
        [DataContract]
        public partial class MemberComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MemberComponent"; } }

            /// <summary>
            /// Reference to the group member
            /// </summary>
            [FhirElement("entity", Order=40)]
            [References("Patient","Practitioner","PractitionerRole","Device","Medication","Substance")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Entity
            {
                get { return _entity; }
                set { _entity = value; OnPropertyChanged("Entity"); }
            }

            private ResourceReference _entity;

            /// <summary>
            /// Period member belonged to the group
            /// </summary>
            [FhirElement("period", Order=50)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            /// <summary>
            /// If member is no longer in group
            /// </summary>
            [FhirElement("inactive", Order=60)]
            [DataMember]
            public FhirBoolean InactiveElement
            {
                get { return _inactiveElement; }
                set { _inactiveElement = value; OnPropertyChanged("InactiveElement"); }
            }

            private FhirBoolean _inactiveElement;

            /// <summary>
            /// If member is no longer in group
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Inactive
            {
                get { return InactiveElement != null ? InactiveElement.Value : null; }
                set
                {
                    if (value == null)
                        InactiveElement = null;
                    else
                        InactiveElement = new FhirBoolean(value);
                    OnPropertyChanged("Inactive");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MemberComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Entity != null) dest.Entity = (ResourceReference)Entity.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (InactiveElement != null) dest.InactiveElement = (FhirBoolean)InactiveElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MemberComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MemberComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Entity, otherT.Entity)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if (!DeepComparable.Matches(InactiveElement, otherT.InactiveElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MemberComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(InactiveElement, otherT.InactiveElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Entity != null) yield return Entity;
                    if (Period != null) yield return Period;
                    if (InactiveElement != null) yield return InactiveElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Entity != null) yield return new ElementValue("entity", Entity);
                    if (Period != null) yield return new ElementValue("period", Period);
                    if (InactiveElement != null) yield return new ElementValue("inactive", InactiveElement);
                }
            }


        }


        /// <summary>
        /// Unique id
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
        /// Whether this group's record is in active use
        /// </summary>
        [FhirElement("active", InSummary=true, Order=100)]
        [DataMember]
        public FhirBoolean ActiveElement
        {
            get { return _activeElement; }
            set { _activeElement = value; OnPropertyChanged("ActiveElement"); }
        }

        private FhirBoolean _activeElement;

        /// <summary>
        /// Whether this group's record is in active use
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveElement = null;
                else
                    ActiveElement = new FhirBoolean(value);
                OnPropertyChanged("Active");
            }
        }

        /// <summary>
        /// person | animal | practitioner | device | medication | substance
        /// </summary>
        [FhirElement("type", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<GroupType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<GroupType> _typeElement;

        /// <summary>
        /// person | animal | practitioner | device | medication | substance
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public GroupType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<GroupType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Descriptive or actual
        /// </summary>
        [FhirElement("actual", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirBoolean ActualElement
        {
            get { return _actualElement; }
            set { _actualElement = value; OnPropertyChanged("ActualElement"); }
        }

        private FhirBoolean _actualElement;

        /// <summary>
        /// Descriptive or actual
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Actual
        {
            get { return ActualElement != null ? ActualElement.Value : null; }
            set
            {
                if (value == null)
                    ActualElement = null;
                else
                    ActualElement = new FhirBoolean(value);
                OnPropertyChanged("Actual");
            }
        }

        /// <summary>
        /// Kind of Group members
        /// </summary>
        [FhirElement("code", InSummary=true, Order=130)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Label for Group
        /// </summary>
        [FhirElement("name", InSummary=true, Order=140)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Label for Group
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
        /// Number of members
        /// </summary>
        [FhirElement("quantity", InSummary=true, Order=150)]
        [DataMember]
        public UnsignedInt QuantityElement
        {
            get { return _quantityElement; }
            set { _quantityElement = value; OnPropertyChanged("QuantityElement"); }
        }

        private UnsignedInt _quantityElement;

        /// <summary>
        /// Number of members
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Quantity
        {
            get { return QuantityElement != null ? QuantityElement.Value : null; }
            set
            {
                if (value == null)
                    QuantityElement = null;
                else
                    QuantityElement = new UnsignedInt(value);
                OnPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Include / Exclude group members by Trait
        /// </summary>
        [FhirElement("characteristic", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CharacteristicComponent> Characteristic
        {
            get { if (_characteristic==null) _characteristic = new List<CharacteristicComponent>(); return _characteristic; }
            set { _characteristic = value; OnPropertyChanged("Characteristic"); }
        }

        private List<CharacteristicComponent> _characteristic;

        /// <summary>
        /// Who or what is in group
        /// </summary>
        [FhirElement("member", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MemberComponent> Member
        {
            get { if (_member==null) _member = new List<MemberComponent>(); return _member; }
            set { _member = value; OnPropertyChanged("Member"); }
        }

        private List<MemberComponent> _member;


        public static ElementDefinition.ConstraintComponent Group_GRP_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "member.empty() or (actual = true)",
            Key = "grp-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Can only have members if group is \"actual\"",
            Xpath = "f:actual/@value=true() or not(exists(f:member))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Group_GRP_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Group;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = (Code<GroupType>)TypeElement.DeepCopy();
                if (ActualElement != null) dest.ActualElement = (FhirBoolean)ActualElement.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (QuantityElement != null) dest.QuantityElement = (UnsignedInt)QuantityElement.DeepCopy();
                if (Characteristic != null) dest.Characteristic = new List<CharacteristicComponent>(Characteristic.DeepCopy());
                if (Member != null) dest.Member = new List<MemberComponent>(Member.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Group());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Group;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(ActualElement, otherT.ActualElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(QuantityElement, otherT.QuantityElement)) return false;
            if ( !DeepComparable.Matches(Characteristic, otherT.Characteristic)) return false;
            if ( !DeepComparable.Matches(Member, otherT.Member)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Group;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(ActualElement, otherT.ActualElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(QuantityElement, otherT.QuantityElement)) return false;
            if (!DeepComparable.IsExactly(Characteristic, otherT.Characteristic)) return false;
            if (!DeepComparable.IsExactly(Member, otherT.Member)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (ActiveElement != null) yield return ActiveElement;
                if (TypeElement != null) yield return TypeElement;
                if (ActualElement != null) yield return ActualElement;
                if (Code != null) yield return Code;
                if (NameElement != null) yield return NameElement;
                if (QuantityElement != null) yield return QuantityElement;
                foreach (var elem in Characteristic) { if (elem != null) yield return elem; }
                foreach (var elem in Member) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (ActualElement != null) yield return new ElementValue("actual", ActualElement);
                if (Code != null) yield return new ElementValue("code", Code);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (QuantityElement != null) yield return new ElementValue("quantity", QuantityElement);
                foreach (var elem in Characteristic) { if (elem != null) yield return new ElementValue("characteristic", elem); }
                foreach (var elem in Member) { if (elem != null) yield return new ElementValue("member", elem); }
            }
        }

    }

}
