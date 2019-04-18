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
    /// Prescription for vision correction products for a patient
    /// </summary>
    [FhirType("VisionPrescription", IsResource = true)]
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
            /// Right Eye
            /// (system: http://hl7.org/fhir/vision-eye-codes)
            /// </summary>
            [EnumLiteral("right", "http://hl7.org/fhir/vision-eye-codes"), Description("Right Eye")]
            Right,
            /// <summary>
            /// Left Eye
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
            /// top
            /// (system: http://hl7.org/fhir/vision-base-codes)
            /// </summary>
            [EnumLiteral("up", "http://hl7.org/fhir/vision-base-codes"), Description("Up")]
            Up,
            /// <summary>
            /// bottom
            /// (system: http://hl7.org/fhir/vision-base-codes)
            /// </summary>
            [EnumLiteral("down", "http://hl7.org/fhir/vision-base-codes"), Description("Down")]
            Down,
            /// <summary>
            /// inner edge
            /// (system: http://hl7.org/fhir/vision-base-codes)
            /// </summary>
            [EnumLiteral("in", "http://hl7.org/fhir/vision-base-codes"), Description("In")]
            In,
            /// <summary>
            /// outer edge
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
            [FhirElement("product", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Product
            {
                get { return _product; }
                set { _product = value; OnPropertyChanged("Product"); }
            }

            private Coding _product;

            /// <summary>
            /// right | left
            /// </summary>
            [FhirElement("eye", InSummary = true, Order = 50)]
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
                    if (!value.HasValue)
                        EyeElement = null;
                    else
                        EyeElement = new Code<VisionEyes>(value);
                    OnPropertyChanged("Eye");
                }
            }

            /// <summary>
            /// Lens sphere
            /// </summary>
            [FhirElement("sphere", InSummary = true, Order = 60)]
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
                    if (!value.HasValue)
                        SphereElement = null;
                    else
                        SphereElement = new FhirDecimal(value);
                    OnPropertyChanged("Sphere");
                }
            }

            /// <summary>
            /// Lens cylinder
            /// </summary>
            [FhirElement("cylinder", InSummary = true, Order = 70)]
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
                    if (!value.HasValue)
                        CylinderElement = null;
                    else
                        CylinderElement = new FhirDecimal(value);
                    OnPropertyChanged("Cylinder");
                }
            }

            /// <summary>
            /// Lens axis
            /// </summary>
            [FhirElement("axis", InSummary = true, Order = 80)]
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
                    if (!value.HasValue)
                        AxisElement = null;
                    else
                        AxisElement = new Integer(value);
                    OnPropertyChanged("Axis");
                }
            }

            /// <summary>
            /// Lens prism
            /// </summary>
            [FhirElement("prism", InSummary = true, Order = 90)]
            [DataMember]
            public FhirDecimal PrismElement
            {
                get { return _prismElement; }
                set { _prismElement = value; OnPropertyChanged("PrismElement"); }
            }

            private FhirDecimal _prismElement;

            /// <summary>
            /// Lens prism
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Prism
            {
                get { return PrismElement != null ? PrismElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        PrismElement = null;
                    else
                        PrismElement = new FhirDecimal(value);
                    OnPropertyChanged("Prism");
                }
            }

            /// <summary>
            /// up | down | in | out
            /// </summary>
            [FhirElement("base", InSummary = true, Order = 100)]
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
                    if (!value.HasValue)
                        BaseElement = null;
                    else
                        BaseElement = new Code<VisionBase>(value);
                    OnPropertyChanged("Base");
                }
            }

            /// <summary>
            /// Lens add
            /// </summary>
            [FhirElement("add", InSummary = true, Order = 110)]
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
                    if (!value.HasValue)
                        AddElement = null;
                    else
                        AddElement = new FhirDecimal(value);
                    OnPropertyChanged("Add");
                }
            }

            /// <summary>
            /// Contact lens power
            /// </summary>
            [FhirElement("power", InSummary = true, Order = 120)]
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
                    if (!value.HasValue)
                        PowerElement = null;
                    else
                        PowerElement = new FhirDecimal(value);
                    OnPropertyChanged("Power");
                }
            }

            /// <summary>
            /// Contact lens back curvature
            /// </summary>
            [FhirElement("backCurve", InSummary = true, Order = 130)]
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
                    if (!value.HasValue)
                        BackCurveElement = null;
                    else
                        BackCurveElement = new FhirDecimal(value);
                    OnPropertyChanged("BackCurve");
                }
            }

            /// <summary>
            /// Contact lens diameter
            /// </summary>
            [FhirElement("diameter", InSummary = true, Order = 140)]
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
                    if (!value.HasValue)
                        DiameterElement = null;
                    else
                        DiameterElement = new FhirDecimal(value);
                    OnPropertyChanged("Diameter");
                }
            }

            /// <summary>
            /// Lens wear duration
            /// </summary>
            [FhirElement("duration", InSummary = true, Order = 150)]
            [DataMember]
            public SimpleQuantity Duration
            {
                get { return _duration; }
                set { _duration = value; OnPropertyChanged("Duration"); }
            }

            private SimpleQuantity _duration;

            /// <summary>
            /// Lens add
            /// </summary>
            [FhirElement("color", InSummary = true, Order = 160)]
            [DataMember]
            public FhirString ColorElement
            {
                get { return _colorElement; }
                set { _colorElement = value; OnPropertyChanged("ColorElement"); }
            }

            private FhirString _colorElement;

            /// <summary>
            /// Lens add
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
            /// Lens add
            /// </summary>
            [FhirElement("brand", InSummary = true, Order = 170)]
            [DataMember]
            public FhirString BrandElement
            {
                get { return _brandElement; }
                set { _brandElement = value; OnPropertyChanged("BrandElement"); }
            }

            private FhirString _brandElement;

            /// <summary>
            /// Lens add
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
            [FhirElement("notes", InSummary = true, Order = 180)]
            [DataMember]
            public FhirString NotesElement
            {
                get { return _notesElement; }
                set { _notesElement = value; OnPropertyChanged("NotesElement"); }
            }

            private FhirString _notesElement;

            /// <summary>
            /// Notes for coatings
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Notes
            {
                get { return NotesElement != null ? NotesElement.Value : null; }
                set
                {
                    if (value == null)
                        NotesElement = null;
                    else
                        NotesElement = new FhirString(value);
                    OnPropertyChanged("Notes");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DispenseComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Product != null) dest.Product = (Coding)Product.DeepCopy();
                    if (EyeElement != null) dest.EyeElement = (Code<VisionEyes>)EyeElement.DeepCopy();
                    if (SphereElement != null) dest.SphereElement = (FhirDecimal)SphereElement.DeepCopy();
                    if (CylinderElement != null) dest.CylinderElement = (FhirDecimal)CylinderElement.DeepCopy();
                    if (AxisElement != null) dest.AxisElement = (Integer)AxisElement.DeepCopy();
                    if (PrismElement != null) dest.PrismElement = (FhirDecimal)PrismElement.DeepCopy();
                    if (BaseElement != null) dest.BaseElement = (Code<VisionBase>)BaseElement.DeepCopy();
                    if (AddElement != null) dest.AddElement = (FhirDecimal)AddElement.DeepCopy();
                    if (PowerElement != null) dest.PowerElement = (FhirDecimal)PowerElement.DeepCopy();
                    if (BackCurveElement != null) dest.BackCurveElement = (FhirDecimal)BackCurveElement.DeepCopy();
                    if (DiameterElement != null) dest.DiameterElement = (FhirDecimal)DiameterElement.DeepCopy();
                    if (Duration != null) dest.Duration = (SimpleQuantity)Duration.DeepCopy();
                    if (ColorElement != null) dest.ColorElement = (FhirString)ColorElement.DeepCopy();
                    if (BrandElement != null) dest.BrandElement = (FhirString)BrandElement.DeepCopy();
                    if (NotesElement != null) dest.NotesElement = (FhirString)NotesElement.DeepCopy();
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
                if (!DeepComparable.Matches(PrismElement, otherT.PrismElement)) return false;
                if (!DeepComparable.Matches(BaseElement, otherT.BaseElement)) return false;
                if (!DeepComparable.Matches(AddElement, otherT.AddElement)) return false;
                if (!DeepComparable.Matches(PowerElement, otherT.PowerElement)) return false;
                if (!DeepComparable.Matches(BackCurveElement, otherT.BackCurveElement)) return false;
                if (!DeepComparable.Matches(DiameterElement, otherT.DiameterElement)) return false;
                if (!DeepComparable.Matches(Duration, otherT.Duration)) return false;
                if (!DeepComparable.Matches(ColorElement, otherT.ColorElement)) return false;
                if (!DeepComparable.Matches(BrandElement, otherT.BrandElement)) return false;
                if (!DeepComparable.Matches(NotesElement, otherT.NotesElement)) return false;

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
                if (!DeepComparable.IsExactly(PrismElement, otherT.PrismElement)) return false;
                if (!DeepComparable.IsExactly(BaseElement, otherT.BaseElement)) return false;
                if (!DeepComparable.IsExactly(AddElement, otherT.AddElement)) return false;
                if (!DeepComparable.IsExactly(PowerElement, otherT.PowerElement)) return false;
                if (!DeepComparable.IsExactly(BackCurveElement, otherT.BackCurveElement)) return false;
                if (!DeepComparable.IsExactly(DiameterElement, otherT.DiameterElement)) return false;
                if (!DeepComparable.IsExactly(Duration, otherT.Duration)) return false;
                if (!DeepComparable.IsExactly(ColorElement, otherT.ColorElement)) return false;
                if (!DeepComparable.IsExactly(BrandElement, otherT.BrandElement)) return false;
                if (!DeepComparable.IsExactly(NotesElement, otherT.NotesElement)) return false;

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
                    if (PrismElement != null) yield return PrismElement;
                    if (BaseElement != null) yield return BaseElement;
                    if (AddElement != null) yield return AddElement;
                    if (PowerElement != null) yield return PowerElement;
                    if (BackCurveElement != null) yield return BackCurveElement;
                    if (DiameterElement != null) yield return DiameterElement;
                    if (Duration != null) yield return Duration;
                    if (ColorElement != null) yield return ColorElement;
                    if (BrandElement != null) yield return BrandElement;
                    if (NotesElement != null) yield return NotesElement;
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
                    if (PrismElement != null) yield return new ElementValue("prism", PrismElement);
                    if (BaseElement != null) yield return new ElementValue("base", BaseElement);
                    if (AddElement != null) yield return new ElementValue("add", AddElement);
                    if (PowerElement != null) yield return new ElementValue("power", PowerElement);
                    if (BackCurveElement != null) yield return new ElementValue("backCurve", BackCurveElement);
                    if (DiameterElement != null) yield return new ElementValue("diameter", DiameterElement);
                    if (Duration != null) yield return new ElementValue("duration", Duration);
                    if (ColorElement != null) yield return new ElementValue("color", ColorElement);
                    if (BrandElement != null) yield return new ElementValue("brand", BrandElement);
                    if (NotesElement != null) yield return new ElementValue("notes", NotesElement);
                }
            }


        }


        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", InSummary = true, Order = 90)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// When prescription was authorized
        /// </summary>
        [FhirElement("dateWritten", InSummary = true, Order = 100)]
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
        /// Who prescription is for
        /// </summary>
        [FhirElement("patient", InSummary = true, Order = 110)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Who authorizes the vision product
        /// </summary>
        [FhirElement("prescriber", InSummary = true, Order = 120)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Prescriber
        {
            get { return _prescriber; }
            set { _prescriber = value; OnPropertyChanged("Prescriber"); }
        }

        private ResourceReference _prescriber;

        /// <summary>
        /// Created during encounter / admission / stay
        /// </summary>
        [FhirElement("encounter", InSummary = true, Order = 130)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Reason or indication for writing the prescription
        /// </summary>
        [FhirElement("reason", InSummary = true, Order = 140, Choice = ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept), typeof(ResourceReference))]
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
        [FhirElement("dispense", InSummary = true, Order = 150)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<DispenseComponent> Dispense
        {
            get { if (_dispense == null) _dispense = new List<DispenseComponent>(); return _dispense; }
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
                if (DateWrittenElement != null) dest.DateWrittenElement = (FhirDateTime)DateWrittenElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Prescriber != null) dest.Prescriber = (ResourceReference)Prescriber.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
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
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(DateWrittenElement, otherT.DateWrittenElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Prescriber, otherT.Prescriber)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(Dispense, otherT.Dispense)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as VisionPrescription;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(DateWrittenElement, otherT.DateWrittenElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Prescriber, otherT.Prescriber)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
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
                if (DateWrittenElement != null) yield return DateWrittenElement;
                if (Patient != null) yield return Patient;
                if (Prescriber != null) yield return Prescriber;
                if (Encounter != null) yield return Encounter;
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
                if (DateWrittenElement != null) yield return new ElementValue("dateWritten", DateWrittenElement);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Prescriber != null) yield return new ElementValue("prescriber", Prescriber);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Reason != null) yield return new ElementValue("reason", Reason);
                foreach (var elem in Dispense) { if (elem != null) yield return new ElementValue("dispense", elem); }
            }
        }

    }

}
