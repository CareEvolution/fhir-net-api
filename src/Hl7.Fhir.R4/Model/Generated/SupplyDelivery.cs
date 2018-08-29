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
    /// Delivery of bulk Supplies
    /// </summary>
    [FhirType("SupplyDelivery", IsResource=true)]
    [DataContract]
    public partial class SupplyDelivery : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SupplyDelivery; } }
        [NotMapped]
        public override string TypeName { get { return "SupplyDelivery"; } }


        [FhirType("SuppliedItemComponent")]
        [DataContract]
        public partial class SuppliedItemComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SuppliedItemComponent"; } }

            /// <summary>
            /// Amount dispensed
            /// </summary>
            [FhirElement("quantity", Order=40)]
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
            [FhirElement("item", Order=50, Choice=ChoiceType.DatatypeChoice)]
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
                var dest = other as SuppliedItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (Item != null) dest.Item = (Element)Item.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SuppliedItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SuppliedItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(Item, otherT.Item)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SuppliedItemComponent;
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
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    if (Item != null) yield return new ElementValue("item", false, Item);
                }
            }


        }


        /// <summary>
        /// External identifier
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
        /// Fulfills plan, proposal or order
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=100)]
        [References("SupplyRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Part of referenced event
        /// </summary>
        [FhirElement("partOf", InSummary=true, Order=110)]
        [References("SupplyDelivery","Contract")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// in-progress | completed | abandoned | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [DataMember]
        public Code<SupplyDeliveryStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<SupplyDeliveryStatus> _statusElement;

        /// <summary>
        /// in-progress | completed | abandoned | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public SupplyDeliveryStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<SupplyDeliveryStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Patient for whom the item is supplied
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
        /// Category of dispense event
        /// </summary>
        [FhirElement("type", Order=140)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// The item that is delivered or supplied
        /// </summary>
        [FhirElement("suppliedItem", Order=150)]
        [DataMember]
        public SuppliedItemComponent SuppliedItem
        {
            get { return _suppliedItem; }
            set { _suppliedItem = value; OnPropertyChanged("SuppliedItem"); }
        }

        private SuppliedItemComponent _suppliedItem;

        /// <summary>
        /// When event occurred
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(Timing))]
        [DataMember]
        public Element Occurrence
        {
            get { return _occurrence; }
            set { _occurrence = value; OnPropertyChanged("Occurrence"); }
        }

        private Element _occurrence;

        /// <summary>
        /// Dispenser
        /// </summary>
        [FhirElement("supplier", Order=170)]
        [References("Practitioner","PractitionerRole","Organization")]
        [DataMember]
        public ResourceReference Supplier
        {
            get { return _supplier; }
            set { _supplier = value; OnPropertyChanged("Supplier"); }
        }

        private ResourceReference _supplier;

        /// <summary>
        /// Where the Supply was sent
        /// </summary>
        [FhirElement("destination", Order=180)]
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
        [FhirElement("receiver", Order=190)]
        [References("Practitioner")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Receiver
        {
            get { if (_receiver==null) _receiver = new List<ResourceReference>(); return _receiver; }
            set { _receiver = value; OnPropertyChanged("Receiver"); }
        }

        private List<ResourceReference> _receiver;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SupplyDelivery;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<SupplyDeliveryStatus>)StatusElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (SuppliedItem != null) dest.SuppliedItem = (SuppliedItemComponent)SuppliedItem.DeepCopy();
                if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                if (Supplier != null) dest.Supplier = (ResourceReference)Supplier.DeepCopy();
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
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(SuppliedItem, otherT.SuppliedItem)) return false;
            if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.Matches(Supplier, otherT.Supplier)) return false;
            if (!DeepComparable.Matches(Destination, otherT.Destination)) return false;
            if ( !DeepComparable.Matches(Receiver, otherT.Receiver)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SupplyDelivery;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(SuppliedItem, otherT.SuppliedItem)) return false;
            if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.IsExactly(Supplier, otherT.Supplier)) return false;
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
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (Patient != null) yield return Patient;
                if (Type != null) yield return Type;
                if (SuppliedItem != null) yield return SuppliedItem;
                if (Occurrence != null) yield return Occurrence;
                if (Supplier != null) yield return Supplier;
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
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", true, elem); }
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (Patient != null) yield return new ElementValue("patient", false, Patient);
                if (Type != null) yield return new ElementValue("type", false, Type);
                if (SuppliedItem != null) yield return new ElementValue("suppliedItem", false, SuppliedItem);
                if (Occurrence != null) yield return new ElementValue("occurrence", false, Occurrence);
                if (Supplier != null) yield return new ElementValue("supplier", false, Supplier);
                if (Destination != null) yield return new ElementValue("destination", false, Destination);
                foreach (var elem in Receiver) { if (elem != null) yield return new ElementValue("receiver", true, elem); }
            }
        }

    }

}
