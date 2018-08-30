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
    /// Prescription for vision correction products for a patient
    /// </summary>
    [FhirType("VisionPrescription", IsResource=true)]
    [DataContract]
    public partial class VisionPrescription : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.VisionPrescription; } }
        [NotMapped]
        public override string TypeName { get { return "VisionPrescription"; } }

        /// <summary>
        /// A coded concept listing the eye codes.
        /// (url: http://hl7.org/fhir/ValueSet/vision-eye-codes)
        /// </summary>
        [FhirEnumeration("VisionEyes")]
        public enum VisionEyes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/vision-eye-codes)
            /// </summary>
            [EnumLiteral("right", "http://hl7.org/fhir/vision-eye-codes"), Description("Right Eye")]
            Right,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/vision-eye-codes)
            /// </summary>
            [EnumLiteral("left", "http://hl7.org/fhir/vision-eye-codes"), Description("Left Eye")]
            Left,
        }

        /// <summary>
        /// A coded concept listing the base codes.
        /// (url: http://hl7.org/fhir/ValueSet/vision-base-codes)
        /// </summary>
        [FhirEnumeration("VisionBase")]
        public enum VisionBase
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/vision-base-codes)
            /// </summary>
            [EnumLiteral("up", "http://hl7.org/fhir/vision-base-codes"), Description("Up")]
            Up,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/vision-base-codes)
            /// </summary>
            [EnumLiteral("down", "http://hl7.org/fhir/vision-base-codes"), Description("Down")]
            Down,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/vision-base-codes)
            /// </summary>
            [EnumLiteral("in", "http://hl7.org/fhir/vision-base-codes"), Description("In")]
            In,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/vision-base-codes)
            /// </summary>
            [EnumLiteral("out", "http://hl7.org/fhir/vision-base-codes"), Description("Out")]
            Out,
        }


        [FhirType("DispenseComponent")]
        [DataContract]
        public partial class DispenseComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DispenseComponent"; } }

            /// <summary>
            /// Product to be supplied
            /// </summary>
            [FhirElement("product", Order=40)]
            [DataMember]
            public CodeableConcept Product
            {
                get { return _product; }
                set { _product = value; OnPropertyChanged("Product"); }
            }

            private CodeableConcept _product;

            /// <summary>
            /// right | left
            /// </summary>
            [FhirElement("eye", Order=50)]
            [DataMember]
            public Code<VisionEyes> EyeElement
            {
                get { return _eyeElement; }
                set { _eyeElement = value; OnPropertyChanged("EyeElement"); }
            }

            private Code<VisionEyes> _eyeElement;

            /// <summary>
            /// right | left
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public VisionEyes? Eye
            {
                get { return EyeElement != null ? EyeElement.Value : null; }
                set
                {
                    if (value == null)
                        EyeElement = null;
                    else
                        EyeElement = new Code<VisionEyes>(value);
                    OnPropertyChanged("Eye");
                }
            }

            /// <summary>
            /// Lens sphere
            /// </summary>
            [FhirElement("sphere", Order=60)]
            [DataMember]
            public FhirDecimal SphereElement
            {
                get { return _sphereElement; }
                set { _sphereElement = value; OnPropertyChanged("SphereElement"); }
            }

            private FhirDecimal _sphereElement;

            /// <summary>
            /// Lens sphere
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Sphere
            {
                get { return SphereElement != null ? SphereElement.Value : null; }
                set
                {
                    if (value == null)
                        SphereElement = null;
                    else
                        SphereElement = new FhirDecimal(value);
                    OnPropertyChanged("Sphere");
                }
            }

            /// <summary>
            /// Lens cylinder
            /// </summary>
            [FhirElement("cylinder", Order=70)]
            [DataMember]
            public FhirDecimal CylinderElement
            {
                get { return _cylinderElement; }
                set { _cylinderElement = value; OnPropertyChanged("CylinderElement"); }
            }

            private FhirDecimal _cylinderElement;

            /// <summary>
            /// Lens cylinder
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Cylinder
            {
                get { return CylinderElement != null ? CylinderElement.Value : null; }
                set
                {
                    if (value == null)
                        CylinderElement = null;
                    else
                        CylinderElement = new FhirDecimal(value);
                    OnPropertyChanged("Cylinder");
                }
            }

            /// <summary>
            /// Lens axis
            /// </summary>
            [FhirElement("axis", Order=80)]
            [DataMember]
            public Integer AxisElement
            {
                get { return _axisElement; }
                set { _axisElement = value; OnPropertyChanged("AxisElement"); }
            }

            private Integer _axisElement;

            /// <summary>
            /// Lens axis
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Axis
            {
                get { return AxisElement != null ? AxisElement.Value : null; }
                set
                {
                    if (value == null)
                        AxisElement = null;
                    else
                        AxisElement = new Integer(value);
                    OnPropertyChanged("Axis");
                }
            }

            /// <summary>
            /// Lens prism
            /// </summary>
            [FhirElement("prism", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PrismComponent> Prism
            {
                get { if (_prism==null) _prism = new List<PrismComponent>(); return _prism; }
                set { _prism = value; OnPropertyChanged("Prism"); }
            }

            private List<PrismComponent> _prism;

            /// <summary>
            /// Lens add
            /// </summary>
            [FhirElement("add", Order=100)]
            [DataMember]
            public FhirDecimal AddElement
            {
                get { return _addElement; }
                set { _addElement = value; OnPropertyChanged("AddElement"); }
            }

            private FhirDecimal _addElement;

            /// <summary>
            /// Lens add
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Add
            {
                get { return AddElement != null ? AddElement.Value : null; }
                set
                {
                    if (value == null)
                        AddElement = null;
                    else
                        AddElement = new FhirDecimal(value);
                    OnPropertyChanged("Add");
                }
            }

            /// <summary>
            /// Contact lens power
            /// </summary>
            [FhirElement("power", Order=110)]
            [DataMember]
            public FhirDecimal PowerElement
            {
                get { return _powerElement; }
                set { _powerElement = value; OnPropertyChanged("PowerElement"); }
            }

            private FhirDecimal _powerElement;

            /// <summary>
            /// Contact lens power
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Power
            {
                get { return PowerElement != null ? PowerElement.Value : null; }
                set
                {
                    if (value == null)
                        PowerElement = null;
                    else
                        PowerElement = new FhirDecimal(value);
                    OnPropertyChanged("Power");
                }
            }

            /// <summary>
            /// Contact lens back curvature
            /// </summary>
            [FhirElement("backCurve", Order=120)]
            [DataMember]
            public FhirDecimal BackCurveElement
            {
                get { return _backCurveElement; }
                set { _backCurveElement = value; OnPropertyChanged("BackCurveElement"); }
            }

            private FhirDecimal _backCurveElement;

            /// <summary>
            /// Contact lens back curvature
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? BackCurve
            {
                get { return BackCurveElement != null ? BackCurveElement.Value : null; }
                set
                {
                    if (value == null)
                        BackCurveElement = null;
                    else
                        BackCurveElement = new FhirDecimal(value);
                    OnPropertyChanged("BackCurve");
                }
            }

            /// <summary>
            /// Contact lens diameter
            /// </summary>
            [FhirElement("diameter", Order=130)]
            [DataMember]
            public FhirDecimal DiameterElement
            {
                get { return _diameterElement; }
                set { _diameterElement = value; OnPropertyChanged("DiameterElement"); }
            }

            private FhirDecimal _diameterElement;

            /// <summary>
            /// Contact lens diameter
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Diameter
            {
                get { return DiameterElement != null ? DiameterElement.Value : null; }
                set
                {
                    if (value == null)
                        DiameterElement = null;
                    else
                        DiameterElement = new FhirDecimal(value);
                    OnPropertyChanged("Diameter");
                }
            }

            /// <summary>
            /// Lens wear duration
            /// </summary>
            [FhirElement("duration", Order=140)]
            [DataMember]
            public SimpleQuantity Duration
            {
                get { return _duration; }
                set { _duration = value; OnPropertyChanged("Duration"); }
            }

            private SimpleQuantity _duration;

            /// <summary>
            /// Color required
            /// </summary>
            [FhirElement("color", Order=150)]
            [DataMember]
            public FhirString ColorElement
            {
                get { return _colorElement; }
                set { _colorElement = value; OnPropertyChanged("ColorElement"); }
            }

            private FhirString _colorElement;

            /// <summary>
            /// Color required
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Color
            {
                get { return ColorElement != null ? ColorElement.Value : null; }
                set
                {
                    if (value == null)
                        ColorElement = null;
                    else
                        ColorElement = new FhirString(value);
                    OnPropertyChanged("Color");
                }
            }

            /// <summary>
            /// Brand required
            /// </summary>
            [FhirElement("brand", Order=160)]
            [DataMember]
            public FhirString BrandElement
            {
                get { return _brandElement; }
                set { _brandElement = value; OnPropertyChanged("BrandElement"); }
            }

            private FhirString _brandElement;

            /// <summary>
            /// Brand required
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Brand
            {
                get { return BrandElement != null ? BrandElement.Value : null; }
                set
                {
                    if (value == null)
                        BrandElement = null;
                    else
                        BrandElement = new FhirString(value);
                    OnPropertyChanged("Brand");
                }
            }

            /// <summary>
            /// Notes for coatings
            /// </summary>
            [FhirElement("note", Order=170)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Annotation> Note
            {
                get { if (_note==null) _note = new List<Annotation>(); return _note; }
                set { _note = value; OnPropertyChanged("Note"); }
            }

            private List<Annotation> _note;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DispenseComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Product != null) dest.Product = (CodeableConcept)Product.DeepCopy();
                    if (EyeElement != null) dest.EyeElement = (Code<VisionEyes>)EyeElement.DeepCopy();
                    if (SphereElement != null) dest.SphereElement = (FhirDecimal)SphereElement.DeepCopy();
                    if (CylinderElement != null) dest.CylinderElement = (FhirDecimal)CylinderElement.DeepCopy();
                    if (AxisElement != null) dest.AxisElement = (Integer)AxisElement.DeepCopy();
                    if (Prism != null) dest.Prism = new List<PrismComponent>(Prism.DeepCopy());
                    if (AddElement != null) dest.AddElement = (FhirDecimal)AddElement.DeepCopy();
                    if (PowerElement != null) dest.PowerElement = (FhirDecimal)PowerElement.DeepCopy();
                    if (BackCurveElement != null) dest.BackCurveElement = (FhirDecimal)BackCurveElement.DeepCopy();
                    if (DiameterElement != null) dest.DiameterElement = (FhirDecimal)DiameterElement.DeepCopy();
                    if (Duration != null) dest.Duration = (SimpleQuantity)Duration.DeepCopy();
                    if (ColorElement != null) dest.ColorElement = (FhirString)ColorElement.DeepCopy();
                    if (BrandElement != null) dest.BrandElement = (FhirString)BrandElement.DeepCopy();
                    if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DispenseComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DispenseComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Product, otherT.Product)) return false;
                if (!DeepComparable.Matches(EyeElement, otherT.EyeElement)) return false;
                if (!DeepComparable.Matches(SphereElement, otherT.SphereElement)) return false;
                if (!DeepComparable.Matches(CylinderElement, otherT.CylinderElement)) return false;
                if (!DeepComparable.Matches(AxisElement, otherT.AxisElement)) return false;
                if ( !DeepComparable.Matches(Prism, otherT.Prism)) return false;
                if (!DeepComparable.Matches(AddElement, otherT.AddElement)) return false;
                if (!DeepComparable.Matches(PowerElement, otherT.PowerElement)) return false;
                if (!DeepComparable.Matches(BackCurveElement, otherT.BackCurveElement)) return false;
                if (!DeepComparable.Matches(DiameterElement, otherT.DiameterElement)) return false;
                if (!DeepComparable.Matches(Duration, otherT.Duration)) return false;
                if (!DeepComparable.Matches(ColorElement, otherT.ColorElement)) return false;
                if (!DeepComparable.Matches(BrandElement, otherT.BrandElement)) return false;
                if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DispenseComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Product, otherT.Product)) return false;
                if (!DeepComparable.IsExactly(EyeElement, otherT.EyeElement)) return false;
                if (!DeepComparable.IsExactly(SphereElement, otherT.SphereElement)) return false;
                if (!DeepComparable.IsExactly(CylinderElement, otherT.CylinderElement)) return false;
                if (!DeepComparable.IsExactly(AxisElement, otherT.AxisElement)) return false;
                if (!DeepComparable.IsExactly(Prism, otherT.Prism)) return false;
                if (!DeepComparable.IsExactly(AddElement, otherT.AddElement)) return false;
                if (!DeepComparable.IsExactly(PowerElement, otherT.PowerElement)) return false;
                if (!DeepComparable.IsExactly(BackCurveElement, otherT.BackCurveElement)) return false;
                if (!DeepComparable.IsExactly(DiameterElement, otherT.DiameterElement)) return false;
                if (!DeepComparable.IsExactly(Duration, otherT.Duration)) return false;
                if (!DeepComparable.IsExactly(ColorElement, otherT.ColorElement)) return false;
                if (!DeepComparable.IsExactly(BrandElement, otherT.BrandElement)) return false;
                if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Product != null) yield return Product;
                    if (EyeElement != null) yield return EyeElement;
                    if (SphereElement != null) yield return SphereElement;
                    if (CylinderElement != null) yield return CylinderElement;
                    if (AxisElement != null) yield return AxisElement;
                    foreach (var elem in Prism) { if (elem != null) yield return elem; }
                    if (AddElement != null) yield return AddElement;
                    if (PowerElement != null) yield return PowerElement;
                    if (BackCurveElement != null) yield return BackCurveElement;
                    if (DiameterElement != null) yield return DiameterElement;
                    if (Duration != null) yield return Duration;
                    if (ColorElement != null) yield return ColorElement;
                    if (BrandElement != null) yield return BrandElement;
                    foreach (var elem in Note) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Product != null) yield return new ElementValue("product", Product);
                    if (EyeElement != null) yield return new ElementValue("eye", EyeElement);
                    if (SphereElement != null) yield return new ElementValue("sphere", SphereElement);
                    if (CylinderElement != null) yield return new ElementValue("cylinder", CylinderElement);
                    if (AxisElement != null) yield return new ElementValue("axis", AxisElement);
                    foreach (var elem in Prism) { if (elem != null) yield return new ElementValue("prism", elem); }
                    if (AddElement != null) yield return new ElementValue("add", AddElement);
                    if (PowerElement != null) yield return new ElementValue("power", PowerElement);
                    if (BackCurveElement != null) yield return new ElementValue("backCurve", BackCurveElement);
                    if (DiameterElement != null) yield return new ElementValue("diameter", DiameterElement);
                    if (Duration != null) yield return new ElementValue("duration", Duration);
                    if (ColorElement != null) yield return new ElementValue("color", ColorElement);
                    if (BrandElement != null) yield return new ElementValue("brand", BrandElement);
                    foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                }
            }


        }


        [FhirType("PrismComponent")]
        [DataContract]
        public partial class PrismComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PrismComponent"; } }

            /// <summary>
            /// Amount of adjustment
            /// </summary>
            [FhirElement("amount", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirDecimal AmountElement
            {
                get { return _amountElement; }
                set { _amountElement = value; OnPropertyChanged("AmountElement"); }
            }

            private FhirDecimal _amountElement;

            /// <summary>
            /// Amount of adjustment
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Amount
            {
                get { return AmountElement != null ? AmountElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountElement = null;
                    else
                        AmountElement = new FhirDecimal(value);
                    OnPropertyChanged("Amount");
                }
            }

            /// <summary>
            /// up | down | in | out
            /// </summary>
            [FhirElement("base", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<VisionBase> BaseElement
            {
                get { return _baseElement; }
                set { _baseElement = value; OnPropertyChanged("BaseElement"); }
            }

            private Code<VisionBase> _baseElement;

            /// <summary>
            /// up | down | in | out
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public VisionBase? Base
            {
                get { return BaseElement != null ? BaseElement.Value : null; }
                set
                {
                    if (value == null)
                        BaseElement = null;
                    else
                        BaseElement = new Code<VisionBase>(value);
                    OnPropertyChanged("Base");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PrismComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (AmountElement != null) dest.AmountElement = (FhirDecimal)AmountElement.DeepCopy();
                    if (BaseElement != null) dest.BaseElement = (Code<VisionBase>)BaseElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PrismComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PrismComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(AmountElement, otherT.AmountElement)) return false;
                if (!DeepComparable.Matches(BaseElement, otherT.BaseElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PrismComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(AmountElement, otherT.AmountElement)) return false;
                if (!DeepComparable.IsExactly(BaseElement, otherT.BaseElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (AmountElement != null) yield return AmountElement;
                    if (BaseElement != null) yield return BaseElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (AmountElement != null) yield return new ElementValue("amount", AmountElement);
                    if (BaseElement != null) yield return new ElementValue("base", BaseElement);
                }
            }


        }


        /// <summary>
        /// Business identifier
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
        /// Who prescription is for
        /// </summary>
        [FhirElement("patient", Order=110)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Created during encounter / admission / stay
        /// </summary>
        [FhirElement("encounter", Order=120)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// When prescription was authorized
        /// </summary>
        [FhirElement("dateWritten", Order=130)]
        [DataMember]
        public FhirDateTime DateWrittenElement
        {
            get { return _dateWrittenElement; }
            set { _dateWrittenElement = value; OnPropertyChanged("DateWrittenElement"); }
        }

        private FhirDateTime _dateWrittenElement;

        /// <summary>
        /// When prescription was authorized
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateWritten
        {
            get { return DateWrittenElement != null ? DateWrittenElement.Value : null; }
            set
            {
                if (value == null)
                    DateWrittenElement = null;
                else
                    DateWrittenElement = new FhirDateTime(value);
                OnPropertyChanged("DateWritten");
            }
        }

        /// <summary>
        /// Who authorizes the vision product
        /// </summary>
        [FhirElement("prescriber", Order=140)]
        [References("Practitioner","PractitionerRole")]
        [DataMember]
        public ResourceReference Prescriber
        {
            get { return _prescriber; }
            set { _prescriber = value; OnPropertyChanged("Prescriber"); }
        }

        private ResourceReference _prescriber;

        /// <summary>
        /// Reason or indication for writing the prescription
        /// </summary>
        [FhirElement("reason", Order=150, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private Element _reason;

        /// <summary>
        /// Vision supply authorization
        /// </summary>
        [FhirElement("dispense", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DispenseComponent> Dispense
        {
            get { if (_dispense==null) _dispense = new List<DispenseComponent>(); return _dispense; }
            set { _dispense = value; OnPropertyChanged("Dispense"); }
        }

        private List<DispenseComponent> _dispense;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as VisionPrescription;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (DateWrittenElement != null) dest.DateWrittenElement = (FhirDateTime)DateWrittenElement.DeepCopy();
                if (Prescriber != null) dest.Prescriber = (ResourceReference)Prescriber.DeepCopy();
                if (Reason != null) dest.Reason = (Element)Reason.DeepCopy();
                if (Dispense != null) dest.Dispense = new List<DispenseComponent>(Dispense.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new VisionPrescription());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as VisionPrescription;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(DateWrittenElement, otherT.DateWrittenElement)) return false;
            if (!DeepComparable.Matches(Prescriber, otherT.Prescriber)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if ( !DeepComparable.Matches(Dispense, otherT.Dispense)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as VisionPrescription;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(DateWrittenElement, otherT.DateWrittenElement)) return false;
            if (!DeepComparable.IsExactly(Prescriber, otherT.Prescriber)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Dispense, otherT.Dispense)) return false;

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
                if (Patient != null) yield return Patient;
                if (Encounter != null) yield return Encounter;
                if (DateWrittenElement != null) yield return DateWrittenElement;
                if (Prescriber != null) yield return Prescriber;
                if (Reason != null) yield return Reason;
                foreach (var elem in Dispense) { if (elem != null) yield return elem; }
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
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (DateWrittenElement != null) yield return new ElementValue("dateWritten", DateWrittenElement);
                if (Prescriber != null) yield return new ElementValue("prescriber", Prescriber);
                if (Reason != null) yield return new ElementValue("reason", Reason);
                foreach (var elem in Dispense) { if (elem != null) yield return new ElementValue("dispense", elem); }
            }
        }

    }

}
