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
    /// The manufactured item as contained in the packaged medicinal product
    /// </summary>
    [FhirType("MedicinalProductManufactured", IsResource=true)]
    [DataContract]
    public partial class MedicinalProductManufactured : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProductManufactured; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProductManufactured"; } }


        /// <summary>
        /// Dose form as manufactured and before any transformation into the pharmaceutical product
        /// </summary>
        [FhirElement("manufacturedDoseForm", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept ManufacturedDoseForm
        {
            get { return _manufacturedDoseForm; }
            set { _manufacturedDoseForm = value; OnPropertyChanged("ManufacturedDoseForm"); }
        }

        private CodeableConcept _manufacturedDoseForm;

        /// <summary>
        /// The “real world” units in which the quantity of the manufactured item is described
        /// </summary>
        [FhirElement("unitOfPresentation", InSummary=true, Order=100)]
        [DataMember]
        public CodeableConcept UnitOfPresentation
        {
            get { return _unitOfPresentation; }
            set { _unitOfPresentation = value; OnPropertyChanged("UnitOfPresentation"); }
        }

        private CodeableConcept _unitOfPresentation;

        /// <summary>
        /// The quantity or "count number" of the manufactured item
        /// </summary>
        [FhirElement("quantity", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Quantity Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged("Quantity"); }
        }

        private Quantity _quantity;

        /// <summary>
        /// Manufacturer of the item (Note that this should be named "manufacturer" but it currently causes technical issues)
        /// </summary>
        [FhirElement("manufacturer", InSummary=true, Order=120)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Manufacturer
        {
            get { if (_manufacturer==null) _manufacturer = new List<ResourceReference>(); return _manufacturer; }
            set { _manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }

        private List<ResourceReference> _manufacturer;

        /// <summary>
        /// Ingredient
        /// </summary>
        [FhirElement("ingredient", InSummary=true, Order=130)]
        [References("MedicinalProductIngredient")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Ingredient
        {
            get { if (_ingredient==null) _ingredient = new List<ResourceReference>(); return _ingredient; }
            set { _ingredient = value; OnPropertyChanged("Ingredient"); }
        }

        private List<ResourceReference> _ingredient;

        /// <summary>
        /// Dimensions, color etc.
        /// </summary>
        [FhirElement("physicalCharacteristics", InSummary=true, Order=140)]
        [DataMember]
        public ProdCharacteristic PhysicalCharacteristics
        {
            get { return _physicalCharacteristics; }
            set { _physicalCharacteristics = value; OnPropertyChanged("PhysicalCharacteristics"); }
        }

        private ProdCharacteristic _physicalCharacteristics;

        /// <summary>
        /// Other codeable characteristics
        /// </summary>
        [FhirElement("otherCharacteristics", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> OtherCharacteristics
        {
            get { if (_otherCharacteristics==null) _otherCharacteristics = new List<CodeableConcept>(); return _otherCharacteristics; }
            set { _otherCharacteristics = value; OnPropertyChanged("OtherCharacteristics"); }
        }

        private List<CodeableConcept> _otherCharacteristics;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProductManufactured;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (ManufacturedDoseForm != null) dest.ManufacturedDoseForm = (CodeableConcept)ManufacturedDoseForm.DeepCopy();
                if (UnitOfPresentation != null) dest.UnitOfPresentation = (CodeableConcept)UnitOfPresentation.DeepCopy();
                if (Quantity != null) dest.Quantity = (Quantity)Quantity.DeepCopy();
                if (Manufacturer != null) dest.Manufacturer = new List<ResourceReference>(Manufacturer.DeepCopy());
                if (Ingredient != null) dest.Ingredient = new List<ResourceReference>(Ingredient.DeepCopy());
                if (PhysicalCharacteristics != null) dest.PhysicalCharacteristics = (ProdCharacteristic)PhysicalCharacteristics.DeepCopy();
                if (OtherCharacteristics != null) dest.OtherCharacteristics = new List<CodeableConcept>(OtherCharacteristics.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicinalProductManufactured());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicinalProductManufactured;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(ManufacturedDoseForm, otherT.ManufacturedDoseForm)) return false;
            if (!DeepComparable.Matches(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
            if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if ( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if ( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
            if (!DeepComparable.Matches(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
            if ( !DeepComparable.Matches(OtherCharacteristics, otherT.OtherCharacteristics)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProductManufactured;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(ManufacturedDoseForm, otherT.ManufacturedDoseForm)) return false;
            if (!DeepComparable.IsExactly(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
            if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
            if (!DeepComparable.IsExactly(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
            if (!DeepComparable.IsExactly(OtherCharacteristics, otherT.OtherCharacteristics)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (ManufacturedDoseForm != null) yield return ManufacturedDoseForm;
                if (UnitOfPresentation != null) yield return UnitOfPresentation;
                if (Quantity != null) yield return Quantity;
                foreach (var elem in Manufacturer) { if (elem != null) yield return elem; }
                foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
                if (PhysicalCharacteristics != null) yield return PhysicalCharacteristics;
                foreach (var elem in OtherCharacteristics) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (ManufacturedDoseForm != null) yield return new ElementValue("manufacturedDoseForm", ManufacturedDoseForm);
                if (UnitOfPresentation != null) yield return new ElementValue("unitOfPresentation", UnitOfPresentation);
                if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                foreach (var elem in Manufacturer) { if (elem != null) yield return new ElementValue("manufacturer", elem); }
                foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
                if (PhysicalCharacteristics != null) yield return new ElementValue("physicalCharacteristics", PhysicalCharacteristics);
                foreach (var elem in OtherCharacteristics) { if (elem != null) yield return new ElementValue("otherCharacteristics", elem); }
            }
        }

    }

}
