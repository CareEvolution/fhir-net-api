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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A medicinal product in a container or package
    /// </summary>
    [FhirType("MedicinalProductPackaged", IsResource=true)]
    [DataContract]
    public partial class MedicinalProductPackaged : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProductPackaged; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProductPackaged"; } }


        [FhirType("BatchIdentifierComponent")]
        [DataContract]
        public partial class BatchIdentifierComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "BatchIdentifierComponent"; } }

            /// <summary>
            /// A number appearing on the outer packaging of a specific batch
            /// </summary>
            [FhirElement("outerPackaging", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Identifier OuterPackaging
            {
                get { return _outerPackaging; }
                set { _outerPackaging = value; OnPropertyChanged("OuterPackaging"); }
            }

            private Identifier _outerPackaging;

            /// <summary>
            /// A number appearing on the immediate packaging (and not the outer packaging)
            /// </summary>
            [FhirElement("immediatePackaging", InSummary=true, Order=50)]
            [DataMember]
            public Identifier ImmediatePackaging
            {
                get { return _immediatePackaging; }
                set { _immediatePackaging = value; OnPropertyChanged("ImmediatePackaging"); }
            }

            private Identifier _immediatePackaging;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BatchIdentifierComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (OuterPackaging != null) dest.OuterPackaging = (Identifier)OuterPackaging.DeepCopy();
                    if (ImmediatePackaging != null) dest.ImmediatePackaging = (Identifier)ImmediatePackaging.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BatchIdentifierComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BatchIdentifierComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(OuterPackaging, otherT.OuterPackaging)) return false;
                if (!DeepComparable.Matches(ImmediatePackaging, otherT.ImmediatePackaging)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BatchIdentifierComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(OuterPackaging, otherT.OuterPackaging)) return false;
                if (!DeepComparable.IsExactly(ImmediatePackaging, otherT.ImmediatePackaging)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (OuterPackaging != null) yield return OuterPackaging;
                    if (ImmediatePackaging != null) yield return ImmediatePackaging;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (OuterPackaging != null) yield return new ElementValue("outerPackaging", OuterPackaging);
                    if (ImmediatePackaging != null) yield return new ElementValue("immediatePackaging", ImmediatePackaging);
                }
            }


        }


        [FhirType("PackageItemComponent")]
        [DataContract]
        public partial class PackageItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PackageItemComponent"; } }

            /// <summary>
            /// Including possibly Data Carrier Identifier
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
            /// The physical type of the container of the medicine
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// The quantity of this package in the medicinal product, at the current level of packaging. The outermost is always 1
            /// </summary>
            [FhirElement("quantity", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Quantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private Quantity _quantity;

            /// <summary>
            /// Material type of the package item
            /// </summary>
            [FhirElement("material", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Material
            {
                get { if (_material==null) _material = new List<CodeableConcept>(); return _material; }
                set { _material = value; OnPropertyChanged("Material"); }
            }

            private List<CodeableConcept> _material;

            /// <summary>
            /// A possible alternate material for the packaging
            /// </summary>
            [FhirElement("alternateMaterial", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> AlternateMaterial
            {
                get { if (_alternateMaterial==null) _alternateMaterial = new List<CodeableConcept>(); return _alternateMaterial; }
                set { _alternateMaterial = value; OnPropertyChanged("AlternateMaterial"); }
            }

            private List<CodeableConcept> _alternateMaterial;

            /// <summary>
            /// Manufacturer of this Package Item
            /// </summary>
            [FhirElement("manufacturer", InSummary=true, Order=90)]
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
            /// A device accompanying a medicinal product
            /// </summary>
            [FhirElement("device", InSummary=true, Order=100)]
            [References("MedicinalProductDeviceSpec")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Device
            {
                get { if (_device==null) _device = new List<ResourceReference>(); return _device; }
                set { _device = value; OnPropertyChanged("Device"); }
            }

            private List<ResourceReference> _device;

            /// <summary>
            /// The manufactured item as contained in the packaged medicinal product
            /// </summary>
            [FhirElement("manufacturedItem", InSummary=true, Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ManufacturedItemComponent> ManufacturedItem
            {
                get { if (_manufacturedItem==null) _manufacturedItem = new List<ManufacturedItemComponent>(); return _manufacturedItem; }
                set { _manufacturedItem = value; OnPropertyChanged("ManufacturedItem"); }
            }

            private List<ManufacturedItemComponent> _manufacturedItem;

            /// <summary>
            /// Other codeable characteristics
            /// </summary>
            [FhirElement("otherCharacteristics", InSummary=true, Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> OtherCharacteristics
            {
                get { if (_otherCharacteristics==null) _otherCharacteristics = new List<CodeableConcept>(); return _otherCharacteristics; }
                set { _otherCharacteristics = value; OnPropertyChanged("OtherCharacteristics"); }
            }

            private List<CodeableConcept> _otherCharacteristics;

            /// <summary>
            /// Allows containers within containers
            /// </summary>
            [FhirElement("packageItem", InSummary=true, Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PackageItemComponent> PackageItem
            {
                get { if (_packageItem==null) _packageItem = new List<PackageItemComponent>(); return _packageItem; }
                set { _packageItem = value; OnPropertyChanged("PackageItem"); }
            }

            private List<PackageItemComponent> _packageItem;

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
            /// Shelf Life and storage information
            /// </summary>
            [FhirElement("shelfLifeStorage", InSummary=true, Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ProductShelfLife> ShelfLifeStorage
            {
                get { if (_shelfLifeStorage==null) _shelfLifeStorage = new List<ProductShelfLife>(); return _shelfLifeStorage; }
                set { _shelfLifeStorage = value; OnPropertyChanged("ShelfLifeStorage"); }
            }

            private List<ProductShelfLife> _shelfLifeStorage;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PackageItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Quantity != null) dest.Quantity = (Quantity)Quantity.DeepCopy();
                    if (Material != null) dest.Material = new List<CodeableConcept>(Material.DeepCopy());
                    if (AlternateMaterial != null) dest.AlternateMaterial = new List<CodeableConcept>(AlternateMaterial.DeepCopy());
                    if (Manufacturer != null) dest.Manufacturer = new List<ResourceReference>(Manufacturer.DeepCopy());
                    if (Device != null) dest.Device = new List<ResourceReference>(Device.DeepCopy());
                    if (ManufacturedItem != null) dest.ManufacturedItem = new List<ManufacturedItemComponent>(ManufacturedItem.DeepCopy());
                    if (OtherCharacteristics != null) dest.OtherCharacteristics = new List<CodeableConcept>(OtherCharacteristics.DeepCopy());
                    if (PackageItem != null) dest.PackageItem = new List<PackageItemComponent>(PackageItem.DeepCopy());
                    if (PhysicalCharacteristics != null) dest.PhysicalCharacteristics = (ProdCharacteristic)PhysicalCharacteristics.DeepCopy();
                    if (ShelfLifeStorage != null) dest.ShelfLifeStorage = new List<ProductShelfLife>(ShelfLifeStorage.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PackageItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PackageItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if ( !DeepComparable.Matches(Material, otherT.Material)) return false;
                if ( !DeepComparable.Matches(AlternateMaterial, otherT.AlternateMaterial)) return false;
                if ( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
                if ( !DeepComparable.Matches(Device, otherT.Device)) return false;
                if ( !DeepComparable.Matches(ManufacturedItem, otherT.ManufacturedItem)) return false;
                if ( !DeepComparable.Matches(OtherCharacteristics, otherT.OtherCharacteristics)) return false;
                if ( !DeepComparable.Matches(PackageItem, otherT.PackageItem)) return false;
                if (!DeepComparable.Matches(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
                if ( !DeepComparable.Matches(ShelfLifeStorage, otherT.ShelfLifeStorage)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PackageItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(Material, otherT.Material)) return false;
                if (!DeepComparable.IsExactly(AlternateMaterial, otherT.AlternateMaterial)) return false;
                if (!DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
                if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
                if (!DeepComparable.IsExactly(ManufacturedItem, otherT.ManufacturedItem)) return false;
                if (!DeepComparable.IsExactly(OtherCharacteristics, otherT.OtherCharacteristics)) return false;
                if (!DeepComparable.IsExactly(PackageItem, otherT.PackageItem)) return false;
                if (!DeepComparable.IsExactly(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
                if (!DeepComparable.IsExactly(ShelfLifeStorage, otherT.ShelfLifeStorage)) return false;

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
                    if (Quantity != null) yield return Quantity;
                    foreach (var elem in Material) { if (elem != null) yield return elem; }
                    foreach (var elem in AlternateMaterial) { if (elem != null) yield return elem; }
                    foreach (var elem in Manufacturer) { if (elem != null) yield return elem; }
                    foreach (var elem in Device) { if (elem != null) yield return elem; }
                    foreach (var elem in ManufacturedItem) { if (elem != null) yield return elem; }
                    foreach (var elem in OtherCharacteristics) { if (elem != null) yield return elem; }
                    foreach (var elem in PackageItem) { if (elem != null) yield return elem; }
                    if (PhysicalCharacteristics != null) yield return PhysicalCharacteristics;
                    foreach (var elem in ShelfLifeStorage) { if (elem != null) yield return elem; }
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
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    foreach (var elem in Material) { if (elem != null) yield return new ElementValue("material", elem); }
                    foreach (var elem in AlternateMaterial) { if (elem != null) yield return new ElementValue("alternateMaterial", elem); }
                    foreach (var elem in Manufacturer) { if (elem != null) yield return new ElementValue("manufacturer", elem); }
                    foreach (var elem in Device) { if (elem != null) yield return new ElementValue("device", elem); }
                    foreach (var elem in ManufacturedItem) { if (elem != null) yield return new ElementValue("manufacturedItem", elem); }
                    foreach (var elem in OtherCharacteristics) { if (elem != null) yield return new ElementValue("otherCharacteristics", elem); }
                    foreach (var elem in PackageItem) { if (elem != null) yield return new ElementValue("packageItem", elem); }
                    if (PhysicalCharacteristics != null) yield return new ElementValue("physicalCharacteristics", PhysicalCharacteristics);
                    foreach (var elem in ShelfLifeStorage) { if (elem != null) yield return new ElementValue("shelfLifeStorage", elem); }
                }
            }


        }


        [FhirType("ManufacturedItemComponent")]
        [DataContract]
        public partial class ManufacturedItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ManufacturedItemComponent"; } }

            /// <summary>
            /// Dose form as manufactured and before any transformation into the pharmaceutical product
            /// </summary>
            [FhirElement("manufacturedDoseForm", InSummary=true, Order=40)]
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
            [FhirElement("unitOfPresentation", InSummary=true, Order=50)]
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
            [FhirElement("quantity", InSummary=true, Order=60)]
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
            [FhirElement("xManufacturer", InSummary=true, Order=70)]
            [References("Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> XManufacturer
            {
                get { if (_xManufacturer==null) _xManufacturer = new List<ResourceReference>(); return _xManufacturer; }
                set { _xManufacturer = value; OnPropertyChanged("XManufacturer"); }
            }

            private List<ResourceReference> _xManufacturer;

            /// <summary>
            /// Ingredient
            /// </summary>
            [FhirElement("ingredient", InSummary=true, Order=80)]
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
            [FhirElement("physicalCharacteristics", InSummary=true, Order=90)]
            [DataMember]
            public ProdCharacteristic PhysicalCharacteristics
            {
                get { return _physicalCharacteristics; }
                set { _physicalCharacteristics = value; OnPropertyChanged("PhysicalCharacteristics"); }
            }

            private ProdCharacteristic _physicalCharacteristics;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManufacturedItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ManufacturedDoseForm != null) dest.ManufacturedDoseForm = (CodeableConcept)ManufacturedDoseForm.DeepCopy();
                    if (UnitOfPresentation != null) dest.UnitOfPresentation = (CodeableConcept)UnitOfPresentation.DeepCopy();
                    if (Quantity != null) dest.Quantity = (Quantity)Quantity.DeepCopy();
                    if (XManufacturer != null) dest.XManufacturer = new List<ResourceReference>(XManufacturer.DeepCopy());
                    if (Ingredient != null) dest.Ingredient = new List<ResourceReference>(Ingredient.DeepCopy());
                    if (PhysicalCharacteristics != null) dest.PhysicalCharacteristics = (ProdCharacteristic)PhysicalCharacteristics.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ManufacturedItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ManufacturedItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ManufacturedDoseForm, otherT.ManufacturedDoseForm)) return false;
                if (!DeepComparable.Matches(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if ( !DeepComparable.Matches(XManufacturer, otherT.XManufacturer)) return false;
                if ( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
                if (!DeepComparable.Matches(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManufacturedItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ManufacturedDoseForm, otherT.ManufacturedDoseForm)) return false;
                if (!DeepComparable.IsExactly(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(XManufacturer, otherT.XManufacturer)) return false;
                if (!DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
                if (!DeepComparable.IsExactly(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;

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
                    foreach (var elem in XManufacturer) { if (elem != null) yield return elem; }
                    foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
                    if (PhysicalCharacteristics != null) yield return PhysicalCharacteristics;
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
                    foreach (var elem in XManufacturer) { if (elem != null) yield return new ElementValue("xManufacturer", elem); }
                    foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
                    if (PhysicalCharacteristics != null) yield return new ElementValue("physicalCharacteristics", PhysicalCharacteristics);
                }
            }


        }


        /// <summary>
        /// Unique identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Textual description
        /// </summary>
        [FhirElement("description", InSummary=true, Order=100)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Textual description
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
        /// Marketing information
        /// </summary>
        [FhirElement("marketingStatus", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MarketingStatus> MarketingStatus
        {
            get { if (_marketingStatus==null) _marketingStatus = new List<MarketingStatus>(); return _marketingStatus; }
            set { _marketingStatus = value; OnPropertyChanged("MarketingStatus"); }
        }

        private List<MarketingStatus> _marketingStatus;

        /// <summary>
        /// Batch numbering
        /// </summary>
        [FhirElement("batchIdentifier", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<BatchIdentifierComponent> BatchIdentifier
        {
            get { if (_batchIdentifier==null) _batchIdentifier = new List<BatchIdentifierComponent>(); return _batchIdentifier; }
            set { _batchIdentifier = value; OnPropertyChanged("BatchIdentifier"); }
        }

        private List<BatchIdentifierComponent> _batchIdentifier;

        /// <summary>
        /// A packaging item, as a contained for medicine, possibly with other packaging items within
        /// </summary>
        [FhirElement("packageItem", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<PackageItemComponent> PackageItem
        {
            get { if (_packageItem==null) _packageItem = new List<PackageItemComponent>(); return _packageItem; }
            set { _packageItem = value; OnPropertyChanged("PackageItem"); }
        }

        private List<PackageItemComponent> _packageItem;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProductPackaged;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (MarketingStatus != null) dest.MarketingStatus = new List<MarketingStatus>(MarketingStatus.DeepCopy());
                if (BatchIdentifier != null) dest.BatchIdentifier = new List<BatchIdentifierComponent>(BatchIdentifier.DeepCopy());
                if (PackageItem != null) dest.PackageItem = new List<PackageItemComponent>(PackageItem.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicinalProductPackaged());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicinalProductPackaged;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(MarketingStatus, otherT.MarketingStatus)) return false;
            if ( !DeepComparable.Matches(BatchIdentifier, otherT.BatchIdentifier)) return false;
            if ( !DeepComparable.Matches(PackageItem, otherT.PackageItem)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProductPackaged;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(MarketingStatus, otherT.MarketingStatus)) return false;
            if (!DeepComparable.IsExactly(BatchIdentifier, otherT.BatchIdentifier)) return false;
            if (!DeepComparable.IsExactly(PackageItem, otherT.PackageItem)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in MarketingStatus) { if (elem != null) yield return elem; }
                foreach (var elem in BatchIdentifier) { if (elem != null) yield return elem; }
                foreach (var elem in PackageItem) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in MarketingStatus) { if (elem != null) yield return new ElementValue("marketingStatus", elem); }
                foreach (var elem in BatchIdentifier) { if (elem != null) yield return new ElementValue("batchIdentifier", elem); }
                foreach (var elem in PackageItem) { if (elem != null) yield return new ElementValue("packageItem", elem); }
            }
        }

    }

}
