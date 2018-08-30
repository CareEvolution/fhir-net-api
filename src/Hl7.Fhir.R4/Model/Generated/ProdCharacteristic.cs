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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available
    /// </summary>
    [FhirType("ProdCharacteristic")]
    [DataContract]
    public partial class ProdCharacteristic : BackboneElement
    {
        [NotMapped]
        public override string TypeName { get { return "ProdCharacteristic"; } }


        /// <summary>
        /// Where applicable, the height can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used
        /// </summary>
        [FhirElement("height", InSummary=true, Order=90)]
        [DataMember]
        public Quantity Height
        {
            get { return _height; }
            set { _height = value; OnPropertyChanged("Height"); }
        }

        private Quantity _height;

        /// <summary>
        /// Where applicable, the width can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used
        /// </summary>
        [FhirElement("width", InSummary=true, Order=100)]
        [DataMember]
        public Quantity Width
        {
            get { return _width; }
            set { _width = value; OnPropertyChanged("Width"); }
        }

        private Quantity _width;

        /// <summary>
        /// Where applicable, the depth can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used
        /// </summary>
        [FhirElement("depth", InSummary=true, Order=110)]
        [DataMember]
        public Quantity Depth
        {
            get { return _depth; }
            set { _depth = value; OnPropertyChanged("Depth"); }
        }

        private Quantity _depth;

        /// <summary>
        /// Where applicable, the weight can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used
        /// </summary>
        [FhirElement("weight", InSummary=true, Order=120)]
        [DataMember]
        public Quantity Weight
        {
            get { return _weight; }
            set { _weight = value; OnPropertyChanged("Weight"); }
        }

        private Quantity _weight;

        /// <summary>
        /// Where applicable, the nominal volume can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used
        /// </summary>
        [FhirElement("nominalVolume", InSummary=true, Order=130)]
        [DataMember]
        public Quantity NominalVolume
        {
            get { return _nominalVolume; }
            set { _nominalVolume = value; OnPropertyChanged("NominalVolume"); }
        }

        private Quantity _nominalVolume;

        /// <summary>
        /// Where applicable, the external diameter can be specified using a numerical value and its unit of measurement The unit of measurement shall be specified in accordance with ISO 11240 and the resulting terminology The symbol and the symbol identifier shall be used
        /// </summary>
        [FhirElement("externalDiameter", InSummary=true, Order=140)]
        [DataMember]
        public Quantity ExternalDiameter
        {
            get { return _externalDiameter; }
            set { _externalDiameter = value; OnPropertyChanged("ExternalDiameter"); }
        }

        private Quantity _externalDiameter;

        /// <summary>
        /// Where applicable, the shape can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used
        /// </summary>
        [FhirElement("shape", InSummary=true, Order=150)]
        [DataMember]
        public FhirString ShapeElement
        {
            get { return _shapeElement; }
            set { _shapeElement = value; OnPropertyChanged("ShapeElement"); }
        }

        private FhirString _shapeElement;

        /// <summary>
        /// Where applicable, the shape can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Shape
        {
            get { return ShapeElement != null ? ShapeElement.Value : null; }
            set
            {
                if (value == null)
                    ShapeElement = null;
                else
                    ShapeElement = new FhirString(value);
                OnPropertyChanged("Shape");
            }
        }

        /// <summary>
        /// Where applicable, the color can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used
        /// </summary>
        [FhirElement("color", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> ColorElement
        {
            get { if (_colorElement==null) _colorElement = new List<FhirString>(); return _colorElement; }
            set { _colorElement = value; OnPropertyChanged("ColorElement"); }
        }

        private List<FhirString> _colorElement;

        /// <summary>
        /// Where applicable, the color can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Color
        {
            get { return ColorElement != null ? ColorElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ColorElement = null;
                else
                    ColorElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Color");
            }
        }

        /// <summary>
        /// Where applicable, the imprint can be specified as text
        /// </summary>
        [FhirElement("imprint", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> ImprintElement
        {
            get { if (_imprintElement==null) _imprintElement = new List<FhirString>(); return _imprintElement; }
            set { _imprintElement = value; OnPropertyChanged("ImprintElement"); }
        }

        private List<FhirString> _imprintElement;

        /// <summary>
        /// Where applicable, the imprint can be specified as text
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Imprint
        {
            get { return ImprintElement != null ? ImprintElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ImprintElement = null;
                else
                    ImprintElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Imprint");
            }
        }

        /// <summary>
        /// Where applicable, the image can be provided The format of the image attachment shall be specified by regional implementations
        /// </summary>
        [FhirElement("image", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Attachment> Image
        {
            get { if (_image==null) _image = new List<Attachment>(); return _image; }
            set { _image = value; OnPropertyChanged("Image"); }
        }

        private List<Attachment> _image;

        /// <summary>
        /// Where applicable, the scoring can be specified An appropriate controlled vocabulary shall be used The term and the term identifier shall be used
        /// </summary>
        [FhirElement("scoring", InSummary=true, Order=190)]
        [DataMember]
        public CodeableConcept Scoring
        {
            get { return _scoring; }
            set { _scoring = value; OnPropertyChanged("Scoring"); }
        }

        private CodeableConcept _scoring;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ProdCharacteristic;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Height != null) dest.Height = (Quantity)Height.DeepCopy();
                if (Width != null) dest.Width = (Quantity)Width.DeepCopy();
                if (Depth != null) dest.Depth = (Quantity)Depth.DeepCopy();
                if (Weight != null) dest.Weight = (Quantity)Weight.DeepCopy();
                if (NominalVolume != null) dest.NominalVolume = (Quantity)NominalVolume.DeepCopy();
                if (ExternalDiameter != null) dest.ExternalDiameter = (Quantity)ExternalDiameter.DeepCopy();
                if (ShapeElement != null) dest.ShapeElement = (FhirString)ShapeElement.DeepCopy();
                if (ColorElement != null) dest.ColorElement = new List<FhirString>(ColorElement.DeepCopy());
                if (ImprintElement != null) dest.ImprintElement = new List<FhirString>(ImprintElement.DeepCopy());
                if (Image != null) dest.Image = new List<Attachment>(Image.DeepCopy());
                if (Scoring != null) dest.Scoring = (CodeableConcept)Scoring.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ProdCharacteristic());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ProdCharacteristic;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Height, otherT.Height)) return false;
            if (!DeepComparable.Matches(Width, otherT.Width)) return false;
            if (!DeepComparable.Matches(Depth, otherT.Depth)) return false;
            if (!DeepComparable.Matches(Weight, otherT.Weight)) return false;
            if (!DeepComparable.Matches(NominalVolume, otherT.NominalVolume)) return false;
            if (!DeepComparable.Matches(ExternalDiameter, otherT.ExternalDiameter)) return false;
            if (!DeepComparable.Matches(ShapeElement, otherT.ShapeElement)) return false;
            if ( !DeepComparable.Matches(ColorElement, otherT.ColorElement)) return false;
            if ( !DeepComparable.Matches(ImprintElement, otherT.ImprintElement)) return false;
            if ( !DeepComparable.Matches(Image, otherT.Image)) return false;
            if (!DeepComparable.Matches(Scoring, otherT.Scoring)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ProdCharacteristic;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Height, otherT.Height)) return false;
            if (!DeepComparable.IsExactly(Width, otherT.Width)) return false;
            if (!DeepComparable.IsExactly(Depth, otherT.Depth)) return false;
            if (!DeepComparable.IsExactly(Weight, otherT.Weight)) return false;
            if (!DeepComparable.IsExactly(NominalVolume, otherT.NominalVolume)) return false;
            if (!DeepComparable.IsExactly(ExternalDiameter, otherT.ExternalDiameter)) return false;
            if (!DeepComparable.IsExactly(ShapeElement, otherT.ShapeElement)) return false;
            if (!DeepComparable.IsExactly(ColorElement, otherT.ColorElement)) return false;
            if (!DeepComparable.IsExactly(ImprintElement, otherT.ImprintElement)) return false;
            if (!DeepComparable.IsExactly(Image, otherT.Image)) return false;
            if (!DeepComparable.IsExactly(Scoring, otherT.Scoring)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Height != null) yield return Height;
                if (Width != null) yield return Width;
                if (Depth != null) yield return Depth;
                if (Weight != null) yield return Weight;
                if (NominalVolume != null) yield return NominalVolume;
                if (ExternalDiameter != null) yield return ExternalDiameter;
                if (ShapeElement != null) yield return ShapeElement;
                foreach (var elem in ColorElement) { if (elem != null) yield return elem; }
                foreach (var elem in ImprintElement) { if (elem != null) yield return elem; }
                foreach (var elem in Image) { if (elem != null) yield return elem; }
                if (Scoring != null) yield return Scoring;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Height != null) yield return new ElementValue("height", Height);
                if (Width != null) yield return new ElementValue("width", Width);
                if (Depth != null) yield return new ElementValue("depth", Depth);
                if (Weight != null) yield return new ElementValue("weight", Weight);
                if (NominalVolume != null) yield return new ElementValue("nominalVolume", NominalVolume);
                if (ExternalDiameter != null) yield return new ElementValue("externalDiameter", ExternalDiameter);
                if (ShapeElement != null) yield return new ElementValue("shape", ShapeElement);
                foreach (var elem in ColorElement) { if (elem != null) yield return new ElementValue("color", elem); }
                foreach (var elem in ImprintElement) { if (elem != null) yield return new ElementValue("imprint", elem); }
                foreach (var elem in Image) { if (elem != null) yield return new ElementValue("image", elem); }
                if (Scoring != null) yield return new ElementValue("scoring", Scoring);
            }
        }

    }

}
