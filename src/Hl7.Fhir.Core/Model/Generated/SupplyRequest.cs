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

        /// <summary>
        /// Status of the supply request
        /// (url: http://hl7.org/fhir/ValueSet/supplyrequest-status)
        /// </summary>
        [FhirEnumeration("SupplyRequestStatus")]
        public enum SupplyRequestStatus
        {
            /// <summary>
            /// Supply has been requested, but not dispensed.
            /// (system: http://hl7.org/fhir/supplyrequest-status)
            /// </summary>
            [EnumLiteral("requested", "http://hl7.org/fhir/supplyrequest-status"), Description("Requested")]
            Requested,
            /// <summary>
            /// Supply has been received by the requestor.
            /// (system: http://hl7.org/fhir/supplyrequest-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/supplyrequest-status"), Description("Received")]
            Completed,
            /// <summary>
            /// The supply will not be completed because the supplier was unable or unwilling to supply the item.
            /// (system: http://hl7.org/fhir/supplyrequest-status)
            /// </summary>
            [EnumLiteral("failed", "http://hl7.org/fhir/supplyrequest-status"), Description("Failed")]
            Failed,
            /// <summary>
            /// The orderer of the supply cancelled the request.
            /// (system: http://hl7.org/fhir/supplyrequest-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/supplyrequest-status"), Description("Cancelled")]
            Cancelled,
        }


        [FhirType("WhenComponent")]
        [DataContract]
        public partial class WhenComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "WhenComponent"; } }

            /// <summary>
            /// Fulfilment code
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Formal fulfillment schedule
            /// </summary>
            [FhirElement("schedule", InSummary=true, Order=50)]
            [DataMember]
            public Timing Schedule
            {
                get { return _schedule; }
                set { _schedule = value; OnPropertyChanged("Schedule"); }
            }

            private Timing _schedule;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as WhenComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Schedule != null) dest.Schedule = (Timing)Schedule.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new WhenComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as WhenComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Schedule, otherT.Schedule)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as WhenComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Schedule != null) yield return Schedule;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Schedule != null) yield return new ElementValue("schedule", Schedule);
                }
            }


        }


        /// <summary>
        /// Patient for whom the item is supplied
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=90)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Who initiated this order
        /// </summary>
        [FhirElement("source", InSummary=true, Order=100)]
        [References("Practitioner","Organization","Patient")]
        [DataMember]
        public ResourceReference Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private ResourceReference _source;

        /// <summary>
        /// When the request was made
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
        /// When the request was made
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
        /// Unique identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=120)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// requested | completed | failed | cancelled
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
        [DataMember]
        public Code<SupplyRequestStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<SupplyRequestStatus> _statusElement;

        /// <summary>
        /// requested | completed | failed | cancelled
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
        [FhirElement("kind", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept Kind
        {
            get { return _kind; }
            set { _kind = value; OnPropertyChanged("Kind"); }
        }

        private CodeableConcept _kind;

        /// <summary>
        /// Medication, Substance, or Device requested to be supplied
        /// </summary>
        [FhirElement("orderedItem", InSummary=true, Order=150)]
        [References("Medication","Substance","Device")]
        [DataMember]
        public ResourceReference OrderedItem
        {
            get { return _orderedItem; }
            set { _orderedItem = value; OnPropertyChanged("OrderedItem"); }
        }

        private ResourceReference _orderedItem;

        /// <summary>
        /// Who is intended to fulfill the request
        /// </summary>
        [FhirElement("supplier", InSummary=true, Order=160)]
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
        [FhirElement("reason", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private Element _reason;

        /// <summary>
        /// When the request should be fulfilled
        /// </summary>
        [FhirElement("when", InSummary=true, Order=180)]
        [DataMember]
        public WhenComponent When
        {
            get { return _when; }
            set { _when = value; OnPropertyChanged("When"); }
        }

        private WhenComponent _when;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SupplyRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Source != null) dest.Source = (ResourceReference)Source.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<SupplyRequestStatus>)StatusElement.DeepCopy();
                if (Kind != null) dest.Kind = (CodeableConcept)Kind.DeepCopy();
                if (OrderedItem != null) dest.OrderedItem = (ResourceReference)OrderedItem.DeepCopy();
                if (Supplier != null) dest.Supplier = new List<ResourceReference>(Supplier.DeepCopy());
                if (Reason != null) dest.Reason = (Element)Reason.DeepCopy();
                if (When != null) dest.When = (WhenComponent)When.DeepCopy();
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
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Kind, otherT.Kind)) return false;
            if (!DeepComparable.Matches(OrderedItem, otherT.OrderedItem)) return false;
            if ( !DeepComparable.Matches(Supplier, otherT.Supplier)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(When, otherT.When)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SupplyRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Kind, otherT.Kind)) return false;
            if (!DeepComparable.IsExactly(OrderedItem, otherT.OrderedItem)) return false;
            if (!DeepComparable.IsExactly(Supplier, otherT.Supplier)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(When, otherT.When)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Patient != null) yield return Patient;
                if (Source != null) yield return Source;
                if (DateElement != null) yield return DateElement;
                if (Identifier != null) yield return Identifier;
                if (StatusElement != null) yield return StatusElement;
                if (Kind != null) yield return Kind;
                if (OrderedItem != null) yield return OrderedItem;
                foreach (var elem in Supplier) { if (elem != null) yield return elem; }
                if (Reason != null) yield return Reason;
                if (When != null) yield return When;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Source != null) yield return new ElementValue("source", Source);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Kind != null) yield return new ElementValue("kind", Kind);
                if (OrderedItem != null) yield return new ElementValue("orderedItem", OrderedItem);
                foreach (var elem in Supplier) { if (elem != null) yield return new ElementValue("supplier", elem); }
                if (Reason != null) yield return new ElementValue("reason", Reason);
                if (When != null) yield return new ElementValue("when", When);
            }
        }

    }

}
