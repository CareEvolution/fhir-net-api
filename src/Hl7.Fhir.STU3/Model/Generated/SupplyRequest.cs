using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.STU3;
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
    /// Request for a medication, substance or device
    /// </summary>
    [FhirType("SupplyRequest", IsResource=true)]
    [DataContract]
    public partial class SupplyRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SupplyRequest; } }
        [NotMapped]
        public override string TypeName { get { return "SupplyRequest"; } }


        [FhirType("OrderedItemComponent")]
        [DataContract]
        public partial class OrderedItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OrderedItemComponent"; } }

            /// <summary>
            /// The requested amount of the item indicated
            /// </summary>
            [FhirElement("quantity", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Quantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private Quantity _quantity;

            /// <summary>
            /// Medication, Substance, or Device requested to be supplied
            /// </summary>
            [FhirElement("item", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Item
            {
                get { return _item; }
                set { _item = value; OnPropertyChanged("Item"); }
            }

            private Element _item;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OrderedItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Quantity != null) dest.Quantity = (Quantity)Quantity.DeepCopy();
                    if (Item != null) dest.Item = (Element)Item.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OrderedItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OrderedItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(Item, otherT.Item)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OrderedItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Quantity != null) yield return Quantity;
                    if (Item != null) yield return Item;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (Item != null) yield return new ElementValue("item", Item);
                }
            }


        }


        [FhirType("RequesterComponent")]
        [DataContract]
        public partial class RequesterComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RequesterComponent"; } }

            /// <summary>
            /// Individual making the request
            /// </summary>
            [FhirElement("agent", InSummary=true, Order=40)]
            [References("Practitioner","Organization","Patient","RelatedPerson","Device")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Agent
            {
                get { return _agent; }
                set { _agent = value; OnPropertyChanged("Agent"); }
            }

            private ResourceReference _agent;

            /// <summary>
            /// Organization agent is acting for
            /// </summary>
            [FhirElement("onBehalfOf", Order=50)]
            [References("Organization")]
            [DataMember]
            public ResourceReference OnBehalfOf
            {
                get { return _onBehalfOf; }
                set { _onBehalfOf = value; OnPropertyChanged("OnBehalfOf"); }
            }

            private ResourceReference _onBehalfOf;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RequesterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Agent != null) dest.Agent = (ResourceReference)Agent.DeepCopy();
                    if (OnBehalfOf != null) dest.OnBehalfOf = (ResourceReference)OnBehalfOf.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RequesterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RequesterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Agent, otherT.Agent)) return false;
                if (!DeepComparable.Matches(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RequesterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
                if (!DeepComparable.IsExactly(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Agent != null) yield return Agent;
                    if (OnBehalfOf != null) yield return OnBehalfOf;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Agent != null) yield return new ElementValue("agent", Agent);
                    if (OnBehalfOf != null) yield return new ElementValue("onBehalfOf", OnBehalfOf);
                }
            }


        }


        /// <summary>
        /// Unique identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// draft | active | suspended +
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<SupplyRequestStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<SupplyRequestStatus> _statusElement;

        /// <summary>
        /// draft | active | suspended +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public SupplyRequestStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<SupplyRequestStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The kind of supply (central, non-stock, etc.)
        /// </summary>
        [FhirElement("category", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=120)]
        [DataMember]
        public Code<RequestPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<RequestPriority> _priorityElement;

        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RequestPriority? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (value == null)
                    PriorityElement = null;
                else
                    PriorityElement = new Code<RequestPriority>(value);
                OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        /// The item being requested
        /// </summary>
        [FhirElement("orderedItem", InSummary=true, Order=130)]
        [DataMember]
        public OrderedItemComponent OrderedItem
        {
            get { return _orderedItem; }
            set { _orderedItem = value; OnPropertyChanged("OrderedItem"); }
        }

        private OrderedItemComponent _orderedItem;

        /// <summary>
        /// When the request should be fulfilled
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=140, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(Timing))]
        [DataMember]
        public Element Occurrence
        {
            get { return _occurrence; }
            set { _occurrence = value; OnPropertyChanged("Occurrence"); }
        }

        private Element _occurrence;

        /// <summary>
        /// When the request was made
        /// </summary>
        [FhirElement("authoredOn", InSummary=true, Order=150)]
        [DataMember]
        public FhirDateTime AuthoredOnElement
        {
            get { return _authoredOnElement; }
            set { _authoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }

        private FhirDateTime _authoredOnElement;

        /// <summary>
        /// When the request was made
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string AuthoredOn
        {
            get { return AuthoredOnElement != null ? AuthoredOnElement.Value : null; }
            set
            {
                if (value == null)
                    AuthoredOnElement = null;
                else
                    AuthoredOnElement = new FhirDateTime(value);
                OnPropertyChanged("AuthoredOn");
            }
        }

        /// <summary>
        /// Who/what is requesting service
        /// </summary>
        [FhirElement("requester", InSummary=true, Order=160)]
        [DataMember]
        public RequesterComponent Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private RequesterComponent _requester;

        /// <summary>
        /// Who is intended to fulfill the request
        /// </summary>
        [FhirElement("supplier", InSummary=true, Order=170)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Supplier
        {
            get { if (_supplier==null) _supplier = new List<ResourceReference>(); return _supplier; }
            set { _supplier = value; OnPropertyChanged("Supplier"); }
        }

        private List<ResourceReference> _supplier;

        /// <summary>
        /// Why the supply item was requested
        /// </summary>
        [FhirElement("reason", Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private Element _reason;

        /// <summary>
        /// The origin of the supply
        /// </summary>
        [FhirElement("deliverFrom", Order=190)]
        [References("Organization","Location")]
        [DataMember]
        public ResourceReference DeliverFrom
        {
            get { return _deliverFrom; }
            set { _deliverFrom = value; OnPropertyChanged("DeliverFrom"); }
        }

        private ResourceReference _deliverFrom;

        /// <summary>
        /// The destination of the supply
        /// </summary>
        [FhirElement("deliverTo", Order=200)]
        [References("Organization","Location","Patient")]
        [DataMember]
        public ResourceReference DeliverTo
        {
            get { return _deliverTo; }
            set { _deliverTo = value; OnPropertyChanged("DeliverTo"); }
        }

        private ResourceReference _deliverTo;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SupplyRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<SupplyRequestStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (PriorityElement != null) dest.PriorityElement = (Code<RequestPriority>)PriorityElement.DeepCopy();
                if (OrderedItem != null) dest.OrderedItem = (OrderedItemComponent)OrderedItem.DeepCopy();
                if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                if (AuthoredOnElement != null) dest.AuthoredOnElement = (FhirDateTime)AuthoredOnElement.DeepCopy();
                if (Requester != null) dest.Requester = (RequesterComponent)Requester.DeepCopy();
                if (Supplier != null) dest.Supplier = new List<ResourceReference>(Supplier.DeepCopy());
                if (Reason != null) dest.Reason = (Element)Reason.DeepCopy();
                if (DeliverFrom != null) dest.DeliverFrom = (ResourceReference)DeliverFrom.DeepCopy();
                if (DeliverTo != null) dest.DeliverTo = (ResourceReference)DeliverTo.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new SupplyRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SupplyRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.Matches(OrderedItem, otherT.OrderedItem)) return false;
            if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if ( !DeepComparable.Matches(Supplier, otherT.Supplier)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(DeliverFrom, otherT.DeliverFrom)) return false;
            if (!DeepComparable.Matches(DeliverTo, otherT.DeliverTo)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SupplyRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(OrderedItem, otherT.OrderedItem)) return false;
            if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(Supplier, otherT.Supplier)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(DeliverFrom, otherT.DeliverFrom)) return false;
            if (!DeepComparable.IsExactly(DeliverTo, otherT.DeliverTo)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (StatusElement != null) yield return StatusElement;
                if (Category != null) yield return Category;
                if (PriorityElement != null) yield return PriorityElement;
                if (OrderedItem != null) yield return OrderedItem;
                if (Occurrence != null) yield return Occurrence;
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (Requester != null) yield return Requester;
                foreach (var elem in Supplier) { if (elem != null) yield return elem; }
                if (Reason != null) yield return Reason;
                if (DeliverFrom != null) yield return DeliverFrom;
                if (DeliverTo != null) yield return DeliverTo;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Category != null) yield return new ElementValue("category", Category);
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                if (OrderedItem != null) yield return new ElementValue("orderedItem", OrderedItem);
                if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", AuthoredOnElement);
                if (Requester != null) yield return new ElementValue("requester", Requester);
                foreach (var elem in Supplier) { if (elem != null) yield return new ElementValue("supplier", elem); }
                if (Reason != null) yield return new ElementValue("reason", Reason);
                if (DeliverFrom != null) yield return new ElementValue("deliverFrom", DeliverFrom);
                if (DeliverTo != null) yield return new ElementValue("deliverTo", DeliverTo);
            }
        }

    }

}
