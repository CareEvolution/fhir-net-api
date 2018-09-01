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
    /// Insurance or medical plan or a payment agreement
    /// </summary>
    [FhirType("Coverage", IsResource=true)]
    [DataContract]
    public partial class Coverage : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Coverage; } }
        [NotMapped]
        public override string TypeName { get { return "Coverage"; } }


        [FhirType("ClassComponent")]
        [DataContract]
        public partial class ClassComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ClassComponent"; } }

            /// <summary>
            /// Type of class such as 'group' or 'plan'
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// The tag or value under the classification
            /// </summary>
            [FhirElement("value", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// The tag or value under the classification
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            /// <summary>
            /// Display text for an identifier for the group
            /// </summary>
            [FhirElement("name", InSummary=true, Order=60)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Display text for an identifier for the group
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClassComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ClassComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ClassComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClassComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (ValueElement != null) yield return ValueElement;
                    if (NameElement != null) yield return NameElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                }
            }


        }


        [FhirType("CoPayComponent")]
        [DataContract]
        public partial class CoPayComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CoPayComponent"; } }

            /// <summary>
            /// The type of service or product
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// The amount or percentage of the copayment
            /// </summary>
            [FhirElement("value", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Quantity Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Quantity _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CoPayComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Value != null) dest.Value = (Quantity)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CoPayComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CoPayComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CoPayComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
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
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        /// <summary>
        /// The primary coverage ID
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
        /// Type of coverage such as medical or accident
        /// </summary>
        [FhirElement("type", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Owner of the policy
        /// </summary>
        [FhirElement("policyHolder", InSummary=true, Order=120)]
        [References("Patient","RelatedPerson","Organization")]
        [DataMember]
        public ResourceReference PolicyHolder
        {
            get { return _policyHolder; }
            set { _policyHolder = value; OnPropertyChanged("PolicyHolder"); }
        }

        private ResourceReference _policyHolder;

        /// <summary>
        /// Subscriber to the policy
        /// </summary>
        [FhirElement("subscriber", InSummary=true, Order=130)]
        [References("Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Subscriber
        {
            get { return _subscriber; }
            set { _subscriber = value; OnPropertyChanged("Subscriber"); }
        }

        private ResourceReference _subscriber;

        /// <summary>
        /// ID assigned to the Subscriber
        /// </summary>
        [FhirElement("subscriberId", InSummary=true, Order=140)]
        [DataMember]
        public FhirString SubscriberIdElement
        {
            get { return _subscriberIdElement; }
            set { _subscriberIdElement = value; OnPropertyChanged("SubscriberIdElement"); }
        }

        private FhirString _subscriberIdElement;

        /// <summary>
        /// ID assigned to the Subscriber
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string SubscriberId
        {
            get { return SubscriberIdElement != null ? SubscriberIdElement.Value : null; }
            set
            {
                if (value == null)
                    SubscriberIdElement = null;
                else
                    SubscriberIdElement = new FhirString(value);
                OnPropertyChanged("SubscriberId");
            }
        }

        /// <summary>
        /// Plan Beneficiary
        /// </summary>
        [FhirElement("beneficiary", InSummary=true, Order=150)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Beneficiary
        {
            get { return _beneficiary; }
            set { _beneficiary = value; OnPropertyChanged("Beneficiary"); }
        }

        private ResourceReference _beneficiary;

        /// <summary>
        /// Dependent number
        /// </summary>
        [FhirElement("dependent", InSummary=true, Order=160)]
        [DataMember]
        public FhirString DependentElement
        {
            get { return _dependentElement; }
            set { _dependentElement = value; OnPropertyChanged("DependentElement"); }
        }

        private FhirString _dependentElement;

        /// <summary>
        /// Dependent number
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Dependent
        {
            get { return DependentElement != null ? DependentElement.Value : null; }
            set
            {
                if (value == null)
                    DependentElement = null;
                else
                    DependentElement = new FhirString(value);
                OnPropertyChanged("Dependent");
            }
        }

        /// <summary>
        /// Beneficiary relationship to the Subscriber
        /// </summary>
        [FhirElement("relationship", Order=170)]
        [DataMember]
        public CodeableConcept Relationship
        {
            get { return _relationship; }
            set { _relationship = value; OnPropertyChanged("Relationship"); }
        }

        private CodeableConcept _relationship;

        /// <summary>
        /// Coverage start and end dates
        /// </summary>
        [FhirElement("period", InSummary=true, Order=180)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Identifier for the plan or agreement issuer
        /// </summary>
        [FhirElement("payor", InSummary=true, Order=190)]
        [References("Organization","Patient","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Payor
        {
            get { if (_payor==null) _payor = new List<ResourceReference>(); return _payor; }
            set { _payor = value; OnPropertyChanged("Payor"); }
        }

        private List<ResourceReference> _payor;

        /// <summary>
        /// Additional coverage classifications
        /// </summary>
        [FhirElement("class", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ClassComponent> Class
        {
            get { if (_class==null) _class = new List<ClassComponent>(); return _class; }
            set { _class = value; OnPropertyChanged("Class"); }
        }

        private List<ClassComponent> _class;

        /// <summary>
        /// Relative order of the coverage
        /// </summary>
        [FhirElement("order", InSummary=true, Order=210)]
        [DataMember]
        public PositiveInt OrderElement
        {
            get { return _orderElement; }
            set { _orderElement = value; OnPropertyChanged("OrderElement"); }
        }

        private PositiveInt _orderElement;

        /// <summary>
        /// Relative order of the coverage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Order
        {
            get { return OrderElement != null ? OrderElement.Value : null; }
            set
            {
                if (value == null)
                    OrderElement = null;
                else
                    OrderElement = new PositiveInt(value);
                OnPropertyChanged("Order");
            }
        }

        /// <summary>
        /// Insurer network
        /// </summary>
        [FhirElement("network", InSummary=true, Order=220)]
        [DataMember]
        public FhirString NetworkElement
        {
            get { return _networkElement; }
            set { _networkElement = value; OnPropertyChanged("NetworkElement"); }
        }

        private FhirString _networkElement;

        /// <summary>
        /// Insurer network
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Network
        {
            get { return NetworkElement != null ? NetworkElement.Value : null; }
            set
            {
                if (value == null)
                    NetworkElement = null;
                else
                    NetworkElement = new FhirString(value);
                OnPropertyChanged("Network");
            }
        }

        /// <summary>
        /// Patient payments for services/products
        /// </summary>
        [FhirElement("copay", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CoPayComponent> Copay
        {
            get { if (_copay==null) _copay = new List<CoPayComponent>(); return _copay; }
            set { _copay = value; OnPropertyChanged("Copay"); }
        }

        private List<CoPayComponent> _copay;

        /// <summary>
        /// Contract details
        /// </summary>
        [FhirElement("contract", Order=240)]
        [References("Contract")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Contract
        {
            get { if (_contract==null) _contract = new List<ResourceReference>(); return _contract; }
            set { _contract = value; OnPropertyChanged("Contract"); }
        }

        private List<ResourceReference> _contract;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Coverage;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (PolicyHolder != null) dest.PolicyHolder = (ResourceReference)PolicyHolder.DeepCopy();
                if (Subscriber != null) dest.Subscriber = (ResourceReference)Subscriber.DeepCopy();
                if (SubscriberIdElement != null) dest.SubscriberIdElement = (FhirString)SubscriberIdElement.DeepCopy();
                if (Beneficiary != null) dest.Beneficiary = (ResourceReference)Beneficiary.DeepCopy();
                if (DependentElement != null) dest.DependentElement = (FhirString)DependentElement.DeepCopy();
                if (Relationship != null) dest.Relationship = (CodeableConcept)Relationship.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Payor != null) dest.Payor = new List<ResourceReference>(Payor.DeepCopy());
                if (Class != null) dest.Class = new List<ClassComponent>(Class.DeepCopy());
                if (OrderElement != null) dest.OrderElement = (PositiveInt)OrderElement.DeepCopy();
                if (NetworkElement != null) dest.NetworkElement = (FhirString)NetworkElement.DeepCopy();
                if (Copay != null) dest.Copay = new List<CoPayComponent>(Copay.DeepCopy());
                if (Contract != null) dest.Contract = new List<ResourceReference>(Contract.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Coverage());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Coverage;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(PolicyHolder, otherT.PolicyHolder)) return false;
            if (!DeepComparable.Matches(Subscriber, otherT.Subscriber)) return false;
            if (!DeepComparable.Matches(SubscriberIdElement, otherT.SubscriberIdElement)) return false;
            if (!DeepComparable.Matches(Beneficiary, otherT.Beneficiary)) return false;
            if (!DeepComparable.Matches(DependentElement, otherT.DependentElement)) return false;
            if (!DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if ( !DeepComparable.Matches(Payor, otherT.Payor)) return false;
            if ( !DeepComparable.Matches(Class, otherT.Class)) return false;
            if (!DeepComparable.Matches(OrderElement, otherT.OrderElement)) return false;
            if (!DeepComparable.Matches(NetworkElement, otherT.NetworkElement)) return false;
            if ( !DeepComparable.Matches(Copay, otherT.Copay)) return false;
            if ( !DeepComparable.Matches(Contract, otherT.Contract)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Coverage;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(PolicyHolder, otherT.PolicyHolder)) return false;
            if (!DeepComparable.IsExactly(Subscriber, otherT.Subscriber)) return false;
            if (!DeepComparable.IsExactly(SubscriberIdElement, otherT.SubscriberIdElement)) return false;
            if (!DeepComparable.IsExactly(Beneficiary, otherT.Beneficiary)) return false;
            if (!DeepComparable.IsExactly(DependentElement, otherT.DependentElement)) return false;
            if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Payor, otherT.Payor)) return false;
            if (!DeepComparable.IsExactly(Class, otherT.Class)) return false;
            if (!DeepComparable.IsExactly(OrderElement, otherT.OrderElement)) return false;
            if (!DeepComparable.IsExactly(NetworkElement, otherT.NetworkElement)) return false;
            if (!DeepComparable.IsExactly(Copay, otherT.Copay)) return false;
            if (!DeepComparable.IsExactly(Contract, otherT.Contract)) return false;

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
                if (Type != null) yield return Type;
                if (PolicyHolder != null) yield return PolicyHolder;
                if (Subscriber != null) yield return Subscriber;
                if (SubscriberIdElement != null) yield return SubscriberIdElement;
                if (Beneficiary != null) yield return Beneficiary;
                if (DependentElement != null) yield return DependentElement;
                if (Relationship != null) yield return Relationship;
                if (Period != null) yield return Period;
                foreach (var elem in Payor) { if (elem != null) yield return elem; }
                foreach (var elem in Class) { if (elem != null) yield return elem; }
                if (OrderElement != null) yield return OrderElement;
                if (NetworkElement != null) yield return NetworkElement;
                foreach (var elem in Copay) { if (elem != null) yield return elem; }
                foreach (var elem in Contract) { if (elem != null) yield return elem; }
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
                if (Type != null) yield return new ElementValue("type", Type);
                if (PolicyHolder != null) yield return new ElementValue("policyHolder", PolicyHolder);
                if (Subscriber != null) yield return new ElementValue("subscriber", Subscriber);
                if (SubscriberIdElement != null) yield return new ElementValue("subscriberId", SubscriberIdElement);
                if (Beneficiary != null) yield return new ElementValue("beneficiary", Beneficiary);
                if (DependentElement != null) yield return new ElementValue("dependent", DependentElement);
                if (Relationship != null) yield return new ElementValue("relationship", Relationship);
                if (Period != null) yield return new ElementValue("period", Period);
                foreach (var elem in Payor) { if (elem != null) yield return new ElementValue("payor", elem); }
                foreach (var elem in Class) { if (elem != null) yield return new ElementValue("class", elem); }
                if (OrderElement != null) yield return new ElementValue("order", OrderElement);
                if (NetworkElement != null) yield return new ElementValue("network", NetworkElement);
                foreach (var elem in Copay) { if (elem != null) yield return new ElementValue("copay", elem); }
                foreach (var elem in Contract) { if (elem != null) yield return new ElementValue("contract", elem); }
            }
        }

    }

}
