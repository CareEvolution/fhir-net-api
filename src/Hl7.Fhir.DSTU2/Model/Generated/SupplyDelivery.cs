using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Delivery of Supply
    /// </summary>
    [FhirType("SupplyDelivery", IsResource=true)]
    [DataContract]
    public partial class SupplyDelivery : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SupplyDelivery; } }
        [NotMapped]
        public override string TypeName { get { return "SupplyDelivery"; } }

        /// <summary>
        /// Status of the supply delivery.
        /// (url: http://hl7.org/fhir/ValueSet/supplydelivery-status)
        /// </summary>
        [FhirEnumeration("SupplyDeliveryStatus")]
        public enum SupplyDeliveryStatus
        {
            /// <summary>
            /// Supply has been requested, but not delivered.
            /// (system: http://hl7.org/fhir/supplydelivery-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/supplydelivery-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// Supply has been delivered ("completed").
            /// (system: http://hl7.org/fhir/supplydelivery-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/supplydelivery-status"), Description("Delivered")]
            Completed,
            /// <summary>
            /// Dispensing was not completed.
            /// (system: http://hl7.org/fhir/supplydelivery-status)
            /// </summary>
            [EnumLiteral("abandoned", "http://hl7.org/fhir/supplydelivery-status"), Description("Abandoned")]
            Abandoned,
        }


        /// <summary>
        /// External identifier
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
        /// in-progress | completed | abandoned
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<SupplyDeliveryStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<SupplyDeliveryStatus> _statusElement;

        /// <summary>
        /// in-progress | completed | abandoned
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public SupplyDeliveryStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<SupplyDeliveryStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Patient for whom the item is supplied
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=110)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Category of dispense event
        /// </summary>
        [FhirElement("type", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Amount dispensed
        /// </summary>
        [FhirElement("quantity", InSummary=true, Order=130)]
        [DataMember]
        public SimpleQuantity Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged("Quantity"); }
        }

        private SimpleQuantity _quantity;

        /// <summary>
        /// Medication, Substance, or Device supplied
        /// </summary>
        [FhirElement("suppliedItem", InSummary=true, Order=140)]
        [References("Medication","Substance","Device")]
        [DataMember]
        public ResourceReference SuppliedItem
        {
            get { return _suppliedItem; }
            set { _suppliedItem = value; OnPropertyChanged("SuppliedItem"); }
        }

        private ResourceReference _suppliedItem;

        /// <summary>
        /// Dispenser
        /// </summary>
        [FhirElement("supplier", InSummary=true, Order=150)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Supplier
        {
            get { return _supplier; }
            set { _supplier = value; OnPropertyChanged("Supplier"); }
        }

        private ResourceReference _supplier;

        /// <summary>
        /// Dispensing time
        /// </summary>
        [FhirElement("whenPrepared", InSummary=true, Order=160)]
        [DataMember]
        public Period WhenPrepared
        {
            get { return _whenPrepared; }
            set { _whenPrepared = value; OnPropertyChanged("WhenPrepared"); }
        }

        private Period _whenPrepared;

        /// <summary>
        /// Handover time
        /// </summary>
        [FhirElement("time", InSummary=true, Order=170)]
        [DataMember]
        public FhirDateTime TimeElement
        {
            get { return _timeElement; }
            set { _timeElement = value; OnPropertyChanged("TimeElement"); }
        }

        private FhirDateTime _timeElement;

        /// <summary>
        /// Handover time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Time
        {
            get { return TimeElement != null ? TimeElement.Value : null; }
            set
            {
                if (value == null)
                    TimeElement = null;
                else
                    TimeElement = new FhirDateTime(value);
                OnPropertyChanged("Time");
            }
        }

        /// <summary>
        /// Where the Supply was sent
        /// </summary>
        [FhirElement("destination", InSummary=true, Order=180)]
        [References("Location")]
        [DataMember]
        public ResourceReference Destination
        {
            get { return _destination; }
            set { _destination = value; OnPropertyChanged("Destination"); }
        }

        private ResourceReference _destination;

        /// <summary>
        /// Who collected the Supply
        /// </summary>
        [FhirElement("receiver", InSummary=true, Order=190)]
        [References("Practitioner")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Receiver
        {
            get { if (_receiver == null) _receiver = new List<ResourceReference>(); return _receiver; }
            set { _receiver = value; OnPropertyChanged("Receiver"); }
        }

        private List<ResourceReference> _receiver;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SupplyDelivery;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<SupplyDeliveryStatus>)StatusElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                if (SuppliedItem != null) dest.SuppliedItem = (ResourceReference)SuppliedItem.DeepCopy();
                if (Supplier != null) dest.Supplier = (ResourceReference)Supplier.DeepCopy();
                if (WhenPrepared != null) dest.WhenPrepared = (Period)WhenPrepared.DeepCopy();
                if (TimeElement != null) dest.TimeElement = (FhirDateTime)TimeElement.DeepCopy();
                if (Destination != null) dest.Destination = (ResourceReference)Destination.DeepCopy();
                if (Receiver != null) dest.Receiver = new List<ResourceReference>(Receiver.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new SupplyDelivery());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SupplyDelivery;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.Matches(SuppliedItem, otherT.SuppliedItem)) return false;
            if (!DeepComparable.Matches(Supplier, otherT.Supplier)) return false;
            if (!DeepComparable.Matches(WhenPrepared, otherT.WhenPrepared)) return false;
            if (!DeepComparable.Matches(TimeElement, otherT.TimeElement)) return false;
            if (!DeepComparable.Matches(Destination, otherT.Destination)) return false;
            if (!DeepComparable.Matches(Receiver, otherT.Receiver)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SupplyDelivery;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.IsExactly(SuppliedItem, otherT.SuppliedItem)) return false;
            if (!DeepComparable.IsExactly(Supplier, otherT.Supplier)) return false;
            if (!DeepComparable.IsExactly(WhenPrepared, otherT.WhenPrepared)) return false;
            if (!DeepComparable.IsExactly(TimeElement, otherT.TimeElement)) return false;
            if (!DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
            if (!DeepComparable.IsExactly(Receiver, otherT.Receiver)) return false;

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
                if (Patient != null) yield return Patient;
                if (Type != null) yield return Type;
                if (Quantity != null) yield return Quantity;
                if (SuppliedItem != null) yield return SuppliedItem;
                if (Supplier != null) yield return Supplier;
                if (WhenPrepared != null) yield return WhenPrepared;
                if (TimeElement != null) yield return TimeElement;
                if (Destination != null) yield return Destination;
                foreach (var elem in Receiver) { if (elem != null) yield return elem; }
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
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Type != null) yield return new ElementValue("type", Type);
                if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                if (SuppliedItem != null) yield return new ElementValue("suppliedItem", SuppliedItem);
                if (Supplier != null) yield return new ElementValue("supplier", Supplier);
                if (WhenPrepared != null) yield return new ElementValue("whenPrepared", WhenPrepared);
                if (TimeElement != null) yield return new ElementValue("time", TimeElement);
                if (Destination != null) yield return new ElementValue("destination", Destination);
                foreach (var elem in Receiver) { if (elem != null) yield return new ElementValue("receiver", elem); }
            }
        }

    }

}
