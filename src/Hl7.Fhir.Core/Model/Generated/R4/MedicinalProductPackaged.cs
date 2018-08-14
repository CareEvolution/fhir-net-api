using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
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
    /// A medicinal product in a container or package
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "MedicinalProductPackaged", IsResource=true)]
    [DataContract]
    public partial class MedicinalProductPackaged : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProductPackaged; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProductPackaged"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "BatchIdentifierComponent")]
        [DataContract]
        public partial class BatchIdentifierComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "BatchIdentifierComponent"; } }
            
            /// <summary>
            /// A number appearing on the outer packaging of a specific batch
            /// </summary>
            [FhirElement("outerPackaging", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier OuterPackaging
            {
                get { return _OuterPackaging; }
                set { _OuterPackaging = value; OnPropertyChanged("OuterPackaging"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _OuterPackaging;
            
            /// <summary>
            /// A number appearing on the immediate packaging (and not the outer packaging)
            /// </summary>
            [FhirElement("immediatePackaging", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier ImmediatePackaging
            {
                get { return _ImmediatePackaging; }
                set { _ImmediatePackaging = value; OnPropertyChanged("ImmediatePackaging"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _ImmediatePackaging;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BatchIdentifierComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(OuterPackaging != null) dest.OuterPackaging = (Hl7.Fhir.Model.R4.Identifier)OuterPackaging.DeepCopy();
                    if(ImmediatePackaging != null) dest.ImmediatePackaging = (Hl7.Fhir.Model.R4.Identifier)ImmediatePackaging.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(OuterPackaging, otherT.OuterPackaging)) return false;
                if( !DeepComparable.Matches(ImmediatePackaging, otherT.ImmediatePackaging)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BatchIdentifierComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(OuterPackaging, otherT.OuterPackaging)) return false;
                if( !DeepComparable.IsExactly(ImmediatePackaging, otherT.ImmediatePackaging)) return false;
            
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
                    if (OuterPackaging != null) yield return new ElementValue("outerPackaging", false, OuterPackaging);
                    if (ImmediatePackaging != null) yield return new ElementValue("immediatePackaging", false, ImmediatePackaging);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PackageItemComponent")]
        [DataContract]
        public partial class PackageItemComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PackageItemComponent"; } }
            
            /// <summary>
            /// Including possibly Data Carrier Identifier
            /// </summary>
            [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Identifier> Identifier
            {
                get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(); return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Identifier> _Identifier;
            
            /// <summary>
            /// The physical type of the container of the medicine
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// The quantity of this package in the medicinal product, at the current level of packaging. The outermost is always 1
            /// </summary>
            [FhirElement("quantity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Quantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.R4.Quantity _Quantity;
            
            /// <summary>
            /// Material type of the package item
            /// </summary>
            [FhirElement("material", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Material
            {
                get { if(_Material==null) _Material = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Material; }
                set { _Material = value; OnPropertyChanged("Material"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Material;
            
            /// <summary>
            /// A possible alternate material for the packaging
            /// </summary>
            [FhirElement("alternateMaterial", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> AlternateMaterial
            {
                get { if(_AlternateMaterial==null) _AlternateMaterial = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _AlternateMaterial; }
                set { _AlternateMaterial = value; OnPropertyChanged("AlternateMaterial"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _AlternateMaterial;
            
            /// <summary>
            /// Manufacturer of this Package Item
            /// </summary>
            [FhirElement("manufacturer", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [References("Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Manufacturer
            {
                get { if(_Manufacturer==null) _Manufacturer = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Manufacturer; }
                set { _Manufacturer = value; OnPropertyChanged("Manufacturer"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Manufacturer;
            
            /// <summary>
            /// A device accompanying a medicinal product
            /// </summary>
            [FhirElement("device", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [References("MedicinalProductDeviceSpec")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Device
            {
                get { if(_Device==null) _Device = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Device; }
                set { _Device = value; OnPropertyChanged("Device"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Device;
            
            /// <summary>
            /// The manufactured item as contained in the packaged medicinal product
            /// </summary>
            [FhirElement("manufacturedItem", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ManufacturedItemComponent> ManufacturedItem
            {
                get { if(_ManufacturedItem==null) _ManufacturedItem = new List<ManufacturedItemComponent>(); return _ManufacturedItem; }
                set { _ManufacturedItem = value; OnPropertyChanged("ManufacturedItem"); }
            }
            
            private List<ManufacturedItemComponent> _ManufacturedItem;
            
            /// <summary>
            /// Other codeable characteristics
            /// </summary>
            [FhirElement("otherCharacteristics", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> OtherCharacteristics
            {
                get { if(_OtherCharacteristics==null) _OtherCharacteristics = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _OtherCharacteristics; }
                set { _OtherCharacteristics = value; OnPropertyChanged("OtherCharacteristics"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _OtherCharacteristics;
            
            /// <summary>
            /// Allows containers within containers
            /// </summary>
            [FhirElement("packageItem", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PackageItemComponent> PackageItem
            {
                get { if(_PackageItem==null) _PackageItem = new List<PackageItemComponent>(); return _PackageItem; }
                set { _PackageItem = value; OnPropertyChanged("PackageItem"); }
            }
            
            private List<PackageItemComponent> _PackageItem;
            
            /// <summary>
            /// Dimensions, color etc.
            /// </summary>
            [FhirElement("physicalCharacteristics", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ProdCharacteristic PhysicalCharacteristics
            {
                get { return _PhysicalCharacteristics; }
                set { _PhysicalCharacteristics = value; OnPropertyChanged("PhysicalCharacteristics"); }
            }
            
            private Hl7.Fhir.Model.R4.ProdCharacteristic _PhysicalCharacteristics;
            
            /// <summary>
            /// Shelf Life and storage information
            /// </summary>
            [FhirElement("shelfLifeStorage", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ProductShelfLife> ShelfLifeStorage
            {
                get { if(_ShelfLifeStorage==null) _ShelfLifeStorage = new List<Hl7.Fhir.Model.R4.ProductShelfLife>(); return _ShelfLifeStorage; }
                set { _ShelfLifeStorage = value; OnPropertyChanged("ShelfLifeStorage"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ProductShelfLife> _ShelfLifeStorage;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PackageItemComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.R4.Quantity)Quantity.DeepCopy();
                    if(Material != null) dest.Material = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Material.DeepCopy());
                    if(AlternateMaterial != null) dest.AlternateMaterial = new List<Hl7.Fhir.Model.R4.CodeableConcept>(AlternateMaterial.DeepCopy());
                    if(Manufacturer != null) dest.Manufacturer = new List<Hl7.Fhir.Model.R4.ResourceReference>(Manufacturer.DeepCopy());
                    if(Device != null) dest.Device = new List<Hl7.Fhir.Model.R4.ResourceReference>(Device.DeepCopy());
                    if(ManufacturedItem != null) dest.ManufacturedItem = new List<ManufacturedItemComponent>(ManufacturedItem.DeepCopy());
                    if(OtherCharacteristics != null) dest.OtherCharacteristics = new List<Hl7.Fhir.Model.R4.CodeableConcept>(OtherCharacteristics.DeepCopy());
                    if(PackageItem != null) dest.PackageItem = new List<PackageItemComponent>(PackageItem.DeepCopy());
                    if(PhysicalCharacteristics != null) dest.PhysicalCharacteristics = (Hl7.Fhir.Model.R4.ProdCharacteristic)PhysicalCharacteristics.DeepCopy();
                    if(ShelfLifeStorage != null) dest.ShelfLifeStorage = new List<Hl7.Fhir.Model.R4.ProductShelfLife>(ShelfLifeStorage.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(Material, otherT.Material)) return false;
                if( !DeepComparable.Matches(AlternateMaterial, otherT.AlternateMaterial)) return false;
                if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
                if( !DeepComparable.Matches(Device, otherT.Device)) return false;
                if( !DeepComparable.Matches(ManufacturedItem, otherT.ManufacturedItem)) return false;
                if( !DeepComparable.Matches(OtherCharacteristics, otherT.OtherCharacteristics)) return false;
                if( !DeepComparable.Matches(PackageItem, otherT.PackageItem)) return false;
                if( !DeepComparable.Matches(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
                if( !DeepComparable.Matches(ShelfLifeStorage, otherT.ShelfLifeStorage)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PackageItemComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(Material, otherT.Material)) return false;
                if( !DeepComparable.IsExactly(AlternateMaterial, otherT.AlternateMaterial)) return false;
                if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
                if( !DeepComparable.IsExactly(Device, otherT.Device)) return false;
                if( !DeepComparable.IsExactly(ManufacturedItem, otherT.ManufacturedItem)) return false;
                if( !DeepComparable.IsExactly(OtherCharacteristics, otherT.OtherCharacteristics)) return false;
                if( !DeepComparable.IsExactly(PackageItem, otherT.PackageItem)) return false;
                if( !DeepComparable.IsExactly(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
                if( !DeepComparable.IsExactly(ShelfLifeStorage, otherT.ShelfLifeStorage)) return false;
            
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
                    foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    foreach (var elem in Material) { if (elem != null) yield return new ElementValue("material", true, elem); }
                    foreach (var elem in AlternateMaterial) { if (elem != null) yield return new ElementValue("alternateMaterial", true, elem); }
                    foreach (var elem in Manufacturer) { if (elem != null) yield return new ElementValue("manufacturer", true, elem); }
                    foreach (var elem in Device) { if (elem != null) yield return new ElementValue("device", true, elem); }
                    foreach (var elem in ManufacturedItem) { if (elem != null) yield return new ElementValue("manufacturedItem", true, elem); }
                    foreach (var elem in OtherCharacteristics) { if (elem != null) yield return new ElementValue("otherCharacteristics", true, elem); }
                    foreach (var elem in PackageItem) { if (elem != null) yield return new ElementValue("packageItem", true, elem); }
                    if (PhysicalCharacteristics != null) yield return new ElementValue("physicalCharacteristics", false, PhysicalCharacteristics);
                    foreach (var elem in ShelfLifeStorage) { if (elem != null) yield return new ElementValue("shelfLifeStorage", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ManufacturedItemComponent")]
        [DataContract]
        public partial class ManufacturedItemComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ManufacturedItemComponent"; } }
            
            /// <summary>
            /// Dose form as manufactured and before any transformation into the pharmaceutical product
            /// </summary>
            [FhirElement("manufacturedDoseForm", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept ManufacturedDoseForm
            {
                get { return _ManufacturedDoseForm; }
                set { _ManufacturedDoseForm = value; OnPropertyChanged("ManufacturedDoseForm"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _ManufacturedDoseForm;
            
            /// <summary>
            /// The “real world” units in which the quantity of the manufactured item is described
            /// </summary>
            [FhirElement("unitOfPresentation", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept UnitOfPresentation
            {
                get { return _UnitOfPresentation; }
                set { _UnitOfPresentation = value; OnPropertyChanged("UnitOfPresentation"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _UnitOfPresentation;
            
            /// <summary>
            /// The quantity or "count number" of the manufactured item
            /// </summary>
            [FhirElement("quantity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Quantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.R4.Quantity _Quantity;
            
            /// <summary>
            /// Manufacturer of the item (Note that this should be named "manufacturer" but it currently causes technical issues)
            /// </summary>
            [FhirElement("xManufacturer", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [References("Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> XManufacturer
            {
                get { if(_XManufacturer==null) _XManufacturer = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _XManufacturer; }
                set { _XManufacturer = value; OnPropertyChanged("XManufacturer"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _XManufacturer;
            
            /// <summary>
            /// Ingredient
            /// </summary>
            [FhirElement("ingredient", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [References("MedicinalProductIngredient")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Ingredient
            {
                get { if(_Ingredient==null) _Ingredient = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Ingredient; }
                set { _Ingredient = value; OnPropertyChanged("Ingredient"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Ingredient;
            
            /// <summary>
            /// Dimensions, color etc.
            /// </summary>
            [FhirElement("physicalCharacteristics", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ProdCharacteristic PhysicalCharacteristics
            {
                get { return _PhysicalCharacteristics; }
                set { _PhysicalCharacteristics = value; OnPropertyChanged("PhysicalCharacteristics"); }
            }
            
            private Hl7.Fhir.Model.R4.ProdCharacteristic _PhysicalCharacteristics;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ManufacturedItemComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(ManufacturedDoseForm != null) dest.ManufacturedDoseForm = (Hl7.Fhir.Model.R4.CodeableConcept)ManufacturedDoseForm.DeepCopy();
                    if(UnitOfPresentation != null) dest.UnitOfPresentation = (Hl7.Fhir.Model.R4.CodeableConcept)UnitOfPresentation.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.R4.Quantity)Quantity.DeepCopy();
                    if(XManufacturer != null) dest.XManufacturer = new List<Hl7.Fhir.Model.R4.ResourceReference>(XManufacturer.DeepCopy());
                    if(Ingredient != null) dest.Ingredient = new List<Hl7.Fhir.Model.R4.ResourceReference>(Ingredient.DeepCopy());
                    if(PhysicalCharacteristics != null) dest.PhysicalCharacteristics = (Hl7.Fhir.Model.R4.ProdCharacteristic)PhysicalCharacteristics.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(ManufacturedDoseForm, otherT.ManufacturedDoseForm)) return false;
                if( !DeepComparable.Matches(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(XManufacturer, otherT.XManufacturer)) return false;
                if( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
                if( !DeepComparable.Matches(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ManufacturedItemComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(ManufacturedDoseForm, otherT.ManufacturedDoseForm)) return false;
                if( !DeepComparable.IsExactly(UnitOfPresentation, otherT.UnitOfPresentation)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(XManufacturer, otherT.XManufacturer)) return false;
                if( !DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
                if( !DeepComparable.IsExactly(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
            
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
                    if (ManufacturedDoseForm != null) yield return new ElementValue("manufacturedDoseForm", false, ManufacturedDoseForm);
                    if (UnitOfPresentation != null) yield return new ElementValue("unitOfPresentation", false, UnitOfPresentation);
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    foreach (var elem in XManufacturer) { if (elem != null) yield return new ElementValue("xManufacturer", true, elem); }
                    foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", true, elem); }
                    if (PhysicalCharacteristics != null) yield return new ElementValue("physicalCharacteristics", false, PhysicalCharacteristics);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Unique identifier
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.R4.Identifier _Identifier;
        
        /// <summary>
        /// Textual description
        /// </summary>
        [FhirElement("description", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Textual description
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// Marketing information
        /// </summary>
        [FhirElement("marketingStatus", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.MarketingStatus> MarketingStatus
        {
            get { if(_MarketingStatus==null) _MarketingStatus = new List<Hl7.Fhir.Model.R4.MarketingStatus>(); return _MarketingStatus; }
            set { _MarketingStatus = value; OnPropertyChanged("MarketingStatus"); }
        }
        
        private List<Hl7.Fhir.Model.R4.MarketingStatus> _MarketingStatus;
        
        /// <summary>
        /// Batch numbering
        /// </summary>
        [FhirElement("batchIdentifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<BatchIdentifierComponent> BatchIdentifier
        {
            get { if(_BatchIdentifier==null) _BatchIdentifier = new List<BatchIdentifierComponent>(); return _BatchIdentifier; }
            set { _BatchIdentifier = value; OnPropertyChanged("BatchIdentifier"); }
        }
        
        private List<BatchIdentifierComponent> _BatchIdentifier;
        
        /// <summary>
        /// A packaging item, as a contained for medicine, possibly with other packaging items within
        /// </summary>
        [FhirElement("packageItem", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<PackageItemComponent> PackageItem
        {
            get { if(_PackageItem==null) _PackageItem = new List<PackageItemComponent>(); return _PackageItem; }
            set { _PackageItem = value; OnPropertyChanged("PackageItem"); }
        }
        
        private List<PackageItemComponent> _PackageItem;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProductPackaged;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(MarketingStatus != null) dest.MarketingStatus = new List<Hl7.Fhir.Model.R4.MarketingStatus>(MarketingStatus.DeepCopy());
                if(BatchIdentifier != null) dest.BatchIdentifier = new List<BatchIdentifierComponent>(BatchIdentifier.DeepCopy());
                if(PackageItem != null) dest.PackageItem = new List<PackageItemComponent>(PackageItem.DeepCopy());
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(MarketingStatus, otherT.MarketingStatus)) return false;
            if( !DeepComparable.Matches(BatchIdentifier, otherT.BatchIdentifier)) return false;
            if( !DeepComparable.Matches(PackageItem, otherT.PackageItem)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProductPackaged;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(MarketingStatus, otherT.MarketingStatus)) return false;
            if( !DeepComparable.IsExactly(BatchIdentifier, otherT.BatchIdentifier)) return false;
            if( !DeepComparable.IsExactly(PackageItem, otherT.PackageItem)) return false;
        
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
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                foreach (var elem in MarketingStatus) { if (elem != null) yield return new ElementValue("marketingStatus", true, elem); }
                foreach (var elem in BatchIdentifier) { if (elem != null) yield return new ElementValue("batchIdentifier", true, elem); }
                foreach (var elem in PackageItem) { if (elem != null) yield return new ElementValue("packageItem", true, elem); }
            }
        }
    
    }

}
