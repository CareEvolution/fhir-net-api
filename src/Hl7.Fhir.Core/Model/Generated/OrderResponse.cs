using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.DSTU2;
using Hl7.Fhir.Validation.DSTU2;
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
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
{
    /// <summary>
    /// A response to an order
    /// </summary>
    [FhirType("OrderResponse", IsResource=true)]
    [DataContract]
    public partial class OrderResponse : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.OrderResponse; } }
        [NotMapped]
        public override string TypeName { get { return "OrderResponse"; } }

        /// <summary>
        /// The status of the response to an order.
        /// (url: http://hl7.org/fhir/ValueSet/order-status)
        /// </summary>
        [FhirEnumeration("OrderStatus")]
        public enum OrderStatus
        {
            /// <summary>
            /// The order is known, but no processing has occurred at this time
            /// (system: http://hl7.org/fhir/order-status)
            /// </summary>
            [EnumLiteral("pending", "http://hl7.org/fhir/order-status"), Description("Pending")]
            Pending,
            /// <summary>
            /// The order is undergoing initial processing to determine whether it will be accepted (usually this involves human review)
            /// (system: http://hl7.org/fhir/order-status)
            /// </summary>
            [EnumLiteral("review", "http://hl7.org/fhir/order-status"), Description("Review")]
            Review,
            /// <summary>
            /// The order was rejected because of a workflow/business logic reason
            /// (system: http://hl7.org/fhir/order-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/order-status"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// The order was unable to be processed because of a technical error (i.e. unexpected error)
            /// (system: http://hl7.org/fhir/order-status)
            /// </summary>
            [EnumLiteral("error", "http://hl7.org/fhir/order-status"), Description("Error")]
            Error,
            /// <summary>
            /// The order has been accepted, and work is in progress.
            /// (system: http://hl7.org/fhir/order-status)
            /// </summary>
            [EnumLiteral("accepted", "http://hl7.org/fhir/order-status"), Description("Accepted")]
            Accepted,
            /// <summary>
            /// Processing the order was halted at the initiators request.
            /// (system: http://hl7.org/fhir/order-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/order-status"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// The order has been cancelled and replaced by another.
            /// (system: http://hl7.org/fhir/order-status)
            /// </summary>
            [EnumLiteral("replaced", "http://hl7.org/fhir/order-status"), Description("Replaced")]
            Replaced,
            /// <summary>
            /// Processing the order was stopped because of some workflow/business logic reason.
            /// (system: http://hl7.org/fhir/order-status)
            /// </summary>
            [EnumLiteral("aborted", "http://hl7.org/fhir/order-status"), Description("Aborted")]
            Aborted,
            /// <summary>
            /// The order has been completed.
            /// (system: http://hl7.org/fhir/order-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/order-status"), Description("Completed")]
            Completed,
        }


        /// <summary>
        /// Identifiers assigned to this order by the orderer or by the receiver
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
        /// The order that this is a response to
        /// </summary>
        [FhirElement("request", InSummary=true, Order=100)]
        [References("Order")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// When the response was made
        /// </summary>
        [FhirElement("date", InSummary=true, Order=110)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// When the response was made
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Who made the response
        /// </summary>
        [FhirElement("who", InSummary=true, Order=120)]
        [References("Practitioner","Organization","Device")]
        [DataMember]
        public ResourceReference Who
        {
            get { return _who; }
            set { _who = value; OnPropertyChanged("Who"); }
        }

        private ResourceReference _who;

        /// <summary>
        /// pending | review | rejected | error | accepted | cancelled | replaced | aborted | completed
        /// </summary>
        [FhirElement("orderStatus", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<OrderStatus> OrderStatusElement
        {
            get { return _orderStatusElement; }
            set { _orderStatusElement = value; OnPropertyChanged("OrderStatusElement"); }
        }

        private Code<OrderStatus> _orderStatusElement;

        /// <summary>
        /// pending | review | rejected | error | accepted | cancelled | replaced | aborted | completed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public OrderStatus? OrderStatus
        {
            get { return OrderStatusElement != null ? OrderStatusElement.Value : null; }
            set
            {
                if (value == null)
                    OrderStatusElement = null;
                else
                    OrderStatusElement = new Code<OrderStatus>(value);
                OnPropertyChanged("OrderStatus");
            }
        }

        /// <summary>
        /// Additional description of the response
        /// </summary>
        [FhirElement("description", InSummary=true, Order=140)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Additional description of the response
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
        /// Details of the outcome of performing the order
        /// </summary>
        [FhirElement("fulfillment", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Fulfillment
        {
            get { if (_fulfillment==null) _fulfillment = new List<ResourceReference>(); return _fulfillment; }
            set { _fulfillment = value; OnPropertyChanged("Fulfillment"); }
        }

        private List<ResourceReference> _fulfillment;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as OrderResponse;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Who != null) dest.Who = (ResourceReference)Who.DeepCopy();
                if (OrderStatusElement != null) dest.OrderStatusElement = (Code<OrderStatus>)OrderStatusElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Fulfillment != null) dest.Fulfillment = new List<ResourceReference>(Fulfillment.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new OrderResponse());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as OrderResponse;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Who, otherT.Who)) return false;
            if (!DeepComparable.Matches(OrderStatusElement, otherT.OrderStatusElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(Fulfillment, otherT.Fulfillment)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as OrderResponse;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Who, otherT.Who)) return false;
            if (!DeepComparable.IsExactly(OrderStatusElement, otherT.OrderStatusElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Fulfillment, otherT.Fulfillment)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Request != null) yield return Request;
                if (DateElement != null) yield return DateElement;
                if (Who != null) yield return Who;
                if (OrderStatusElement != null) yield return OrderStatusElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in Fulfillment) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Request != null) yield return new ElementValue("request", Request);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Who != null) yield return new ElementValue("who", Who);
                if (OrderStatusElement != null) yield return new ElementValue("orderStatus", OrderStatusElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in Fulfillment) { if (elem != null) yield return new ElementValue("fulfillment", elem); }
            }
        }

    }

}
