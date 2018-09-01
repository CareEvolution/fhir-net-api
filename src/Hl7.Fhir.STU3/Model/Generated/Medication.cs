using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Definition of a Medication
    /// </summary>
    [FhirType("Medication", IsResource=true)]
    [DataContract]
    public partial class Medication : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Medication; } }
        [NotMapped]
        public override string TypeName { get { return "Medication"; } }

        /// <summary>
        /// A coded concept defining if the medication is in active use
        /// (url: http://hl7.org/fhir/ValueSet/medication-status)
        /// </summary>
        [FhirEnumeration("MedicationStatus")]
        public enum MedicationStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/medication-status"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-status)
            /// </summary>
            [EnumLiteral("inactive", "http://hl7.org/fhir/medication-status"), Description("Inactive")]
            Inactive,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/medication-status"), Description("Entered in Error")]
            EnteredInError,
        }


        [FhirType("IngredientComponent")]
        [DataContract]
        public partial class IngredientComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "IngredientComponent"; } }

            /// <summary>
            /// The product contained
            /// </summary>
            [FhirElement("item", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Item
            {
                get { return _item; }
                set { _item = value; OnPropertyChanged("Item"); }
            }

            private Element _item;

            /// <summary>
            /// Active ingredient indicator
            /// </summary>
            [FhirElement("isActive", Order=50)]
            [DataMember]
            public FhirBoolean IsActiveElement
            {
                get { return _isActiveElement; }
                set { _isActiveElement = value; OnPropertyChanged("IsActiveElement"); }
            }

            private FhirBoolean _isActiveElement;

            /// <summary>
            /// Active ingredient indicator
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? IsActive
            {
                get { return IsActiveElement != null ? IsActiveElement.Value : null; }
                set
                {
                    if (value == null)
                        IsActiveElement = null;
                    else
                        IsActiveElement = new FhirBoolean(value);
                    OnPropertyChanged("IsActive");
                }
            }

            /// <summary>
            /// Quantity of ingredient present
            /// </summary>
            [FhirElement("amount", Order=60)]
            [DataMember]
            public Ratio Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Ratio _amount;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as IngredientComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Item != null) dest.Item = (Element)Item.DeepCopy();
                    if (IsActiveElement != null) dest.IsActiveElement = (FhirBoolean)IsActiveElement.DeepCopy();
                    if (Amount != null) dest.Amount = (Ratio)Amount.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new IngredientComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as IngredientComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Item, otherT.Item)) return false;
                if (!DeepComparable.Matches(IsActiveElement, otherT.IsActiveElement)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as IngredientComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
                if (!DeepComparable.IsExactly(IsActiveElement, otherT.IsActiveElement)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Item != null) yield return Item;
                    if (IsActiveElement != null) yield return IsActiveElement;
                    if (Amount != null) yield return Amount;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Item != null) yield return new ElementValue("item", Item);
                    if (IsActiveElement != null) yield return new ElementValue("isActive", IsActiveElement);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                }
            }


        }


        [FhirType("PackageComponent")]
        [DataContract]
        public partial class PackageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PackageComponent"; } }

            /// <summary>
            /// E.g. box, vial, blister-pack
            /// </summary>
            [FhirElement("container", Order=40)]
            [DataMember]
            public CodeableConcept Container
            {
                get { return _container; }
                set { _container = value; OnPropertyChanged("Container"); }
            }

            private CodeableConcept _container;

            /// <summary>
            /// What is  in the package
            /// </summary>
            [FhirElement("content", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContentComponent> Content
            {
                get { if (_content==null) _content = new List<ContentComponent>(); return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private List<ContentComponent> _content;

            /// <summary>
            /// Identifies a single production run
            /// </summary>
            [FhirElement("batch", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<BatchComponent> Batch
            {
                get { if (_batch==null) _batch = new List<BatchComponent>(); return _batch; }
                set { _batch = value; OnPropertyChanged("Batch"); }
            }

            private List<BatchComponent> _batch;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PackageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Container != null) dest.Container = (CodeableConcept)Container.DeepCopy();
                    if (Content != null) dest.Content = new List<ContentComponent>(Content.DeepCopy());
                    if (Batch != null) dest.Batch = new List<BatchComponent>(Batch.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PackageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PackageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Container, otherT.Container)) return false;
                if ( !DeepComparable.Matches(Content, otherT.Content)) return false;
                if ( !DeepComparable.Matches(Batch, otherT.Batch)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PackageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Container, otherT.Container)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;
                if (!DeepComparable.IsExactly(Batch, otherT.Batch)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Container != null) yield return Container;
                    foreach (var elem in Content) { if (elem != null) yield return elem; }
                    foreach (var elem in Batch) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Container != null) yield return new ElementValue("container", Container);
                    foreach (var elem in Content) { if (elem != null) yield return new ElementValue("content", elem); }
                    foreach (var elem in Batch) { if (elem != null) yield return new ElementValue("batch", elem); }
                }
            }


        }


        [FhirType("ContentComponent")]
        [DataContract]
        public partial class ContentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContentComponent"; } }

            /// <summary>
            /// The item in the package
            /// </summary>
            [FhirElement("item", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Item
            {
                get { return _item; }
                set { _item = value; OnPropertyChanged("Item"); }
            }

            private Element _item;

            /// <summary>
            /// Quantity present in the package
            /// </summary>
            [FhirElement("amount", Order=50)]
            [DataMember]
            public SimpleQuantity Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private SimpleQuantity _amount;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Item != null) dest.Item = (Element)Item.DeepCopy();
                    if (Amount != null) dest.Amount = (SimpleQuantity)Amount.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Item, otherT.Item)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Item != null) yield return Item;
                    if (Amount != null) yield return Amount;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Item != null) yield return new ElementValue("item", Item);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                }
            }


        }


        [FhirType("BatchComponent")]
        [DataContract]
        public partial class BatchComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "BatchComponent"; } }

            /// <summary>
            /// Identifier assigned to batch
            /// </summary>
            [FhirElement("lotNumber", Order=40)]
            [DataMember]
            public FhirString LotNumberElement
            {
                get { return _lotNumberElement; }
                set { _lotNumberElement = value; OnPropertyChanged("LotNumberElement"); }
            }

            private FhirString _lotNumberElement;

            /// <summary>
            /// Identifier assigned to batch
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string LotNumber
            {
                get { return LotNumberElement != null ? LotNumberElement.Value : null; }
                set
                {
                    if (value == null)
                        LotNumberElement = null;
                    else
                        LotNumberElement = new FhirString(value);
                    OnPropertyChanged("LotNumber");
                }
            }

            /// <summary>
            /// When batch will expire
            /// </summary>
            [FhirElement("expirationDate", Order=50)]
            [DataMember]
            public FhirDateTime ExpirationDateElement
            {
                get { return _expirationDateElement; }
                set { _expirationDateElement = value; OnPropertyChanged("ExpirationDateElement"); }
            }

            private FhirDateTime _expirationDateElement;

            /// <summary>
            /// When batch will expire
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ExpirationDate
            {
                get { return ExpirationDateElement != null ? ExpirationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        ExpirationDateElement = null;
                    else
                        ExpirationDateElement = new FhirDateTime(value);
                    OnPropertyChanged("ExpirationDate");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BatchComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LotNumberElement != null) dest.LotNumberElement = (FhirString)LotNumberElement.DeepCopy();
                    if (ExpirationDateElement != null) dest.ExpirationDateElement = (FhirDateTime)ExpirationDateElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BatchComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BatchComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
                if (!DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BatchComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
                if (!DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LotNumberElement != null) yield return LotNumberElement;
                    if (ExpirationDateElement != null) yield return ExpirationDateElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
                    if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
                }
            }


        }


        /// <summary>
        /// Codes that identify this medication
        /// </summary>
        [FhirElement("code", InSummary=true, Order=90)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// active | inactive | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<MedicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationStatus> _statusElement;

        /// <summary>
        /// active | inactive | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// True if a brand
        /// </summary>
        [FhirElement("isBrand", InSummary=true, Order=110)]
        [DataMember]
        public FhirBoolean IsBrandElement
        {
            get { return _isBrandElement; }
            set { _isBrandElement = value; OnPropertyChanged("IsBrandElement"); }
        }

        private FhirBoolean _isBrandElement;

        /// <summary>
        /// True if a brand
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? IsBrand
        {
            get { return IsBrandElement != null ? IsBrandElement.Value : null; }
            set
            {
                if (value == null)
                    IsBrandElement = null;
                else
                    IsBrandElement = new FhirBoolean(value);
                OnPropertyChanged("IsBrand");
            }
        }

        /// <summary>
        /// True if medication does not require a prescription
        /// </summary>
        [FhirElement("isOverTheCounter", InSummary=true, Order=120)]
        [DataMember]
        public FhirBoolean IsOverTheCounterElement
        {
            get { return _isOverTheCounterElement; }
            set { _isOverTheCounterElement = value; OnPropertyChanged("IsOverTheCounterElement"); }
        }

        private FhirBoolean _isOverTheCounterElement;

        /// <summary>
        /// True if medication does not require a prescription
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? IsOverTheCounter
        {
            get { return IsOverTheCounterElement != null ? IsOverTheCounterElement.Value : null; }
            set
            {
                if (value == null)
                    IsOverTheCounterElement = null;
                else
                    IsOverTheCounterElement = new FhirBoolean(value);
                OnPropertyChanged("IsOverTheCounter");
            }
        }

        /// <summary>
        /// Manufacturer of the item
        /// </summary>
        [FhirElement("manufacturer", InSummary=true, Order=130)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }

        private ResourceReference _manufacturer;

        /// <summary>
        /// powder | tablets | capsule +
        /// </summary>
        [FhirElement("form", Order=140)]
        [DataMember]
        public CodeableConcept Form
        {
            get { return _form; }
            set { _form = value; OnPropertyChanged("Form"); }
        }

        private CodeableConcept _form;

        /// <summary>
        /// Active or inactive ingredient
        /// </summary>
        [FhirElement("ingredient", Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<IngredientComponent> Ingredient
        {
            get { if (_ingredient==null) _ingredient = new List<IngredientComponent>(); return _ingredient; }
            set { _ingredient = value; OnPropertyChanged("Ingredient"); }
        }

        private List<IngredientComponent> _ingredient;

        /// <summary>
        /// Details about packaged medications
        /// </summary>
        [FhirElement("package", Order=160)]
        [DataMember]
        public PackageComponent Package
        {
            get { return _package; }
            set { _package = value; OnPropertyChanged("Package"); }
        }

        private PackageComponent _package;

        /// <summary>
        /// Picture of the medication
        /// </summary>
        [FhirElement("image", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Attachment> Image
        {
            get { if (_image==null) _image = new List<Attachment>(); return _image; }
            set { _image = value; OnPropertyChanged("Image"); }
        }

        private List<Attachment> _image;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Medication;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<MedicationStatus>)StatusElement.DeepCopy();
                if (IsBrandElement != null) dest.IsBrandElement = (FhirBoolean)IsBrandElement.DeepCopy();
                if (IsOverTheCounterElement != null) dest.IsOverTheCounterElement = (FhirBoolean)IsOverTheCounterElement.DeepCopy();
                if (Manufacturer != null) dest.Manufacturer = (ResourceReference)Manufacturer.DeepCopy();
                if (Form != null) dest.Form = (CodeableConcept)Form.DeepCopy();
                if (Ingredient != null) dest.Ingredient = new List<IngredientComponent>(Ingredient.DeepCopy());
                if (Package != null) dest.Package = (PackageComponent)Package.DeepCopy();
                if (Image != null) dest.Image = new List<Attachment>(Image.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Medication());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Medication;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(IsBrandElement, otherT.IsBrandElement)) return false;
            if (!DeepComparable.Matches(IsOverTheCounterElement, otherT.IsOverTheCounterElement)) return false;
            if (!DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.Matches(Form, otherT.Form)) return false;
            if ( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
            if (!DeepComparable.Matches(Package, otherT.Package)) return false;
            if ( !DeepComparable.Matches(Image, otherT.Image)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Medication;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(IsBrandElement, otherT.IsBrandElement)) return false;
            if (!DeepComparable.IsExactly(IsOverTheCounterElement, otherT.IsOverTheCounterElement)) return false;
            if (!DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if (!DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
            if (!DeepComparable.IsExactly(Package, otherT.Package)) return false;
            if (!DeepComparable.IsExactly(Image, otherT.Image)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Code != null) yield return Code;
                if (StatusElement != null) yield return StatusElement;
                if (IsBrandElement != null) yield return IsBrandElement;
                if (IsOverTheCounterElement != null) yield return IsOverTheCounterElement;
                if (Manufacturer != null) yield return Manufacturer;
                if (Form != null) yield return Form;
                foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
                if (Package != null) yield return Package;
                foreach (var elem in Image) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Code != null) yield return new ElementValue("code", Code);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (IsBrandElement != null) yield return new ElementValue("isBrand", IsBrandElement);
                if (IsOverTheCounterElement != null) yield return new ElementValue("isOverTheCounter", IsOverTheCounterElement);
                if (Manufacturer != null) yield return new ElementValue("manufacturer", Manufacturer);
                if (Form != null) yield return new ElementValue("form", Form);
                foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
                if (Package != null) yield return new ElementValue("package", Package);
                foreach (var elem in Image) { if (elem != null) yield return new ElementValue("image", elem); }
            }
        }

    }

}
