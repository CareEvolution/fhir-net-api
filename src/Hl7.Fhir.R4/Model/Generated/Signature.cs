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
    /// A Signature - XML DigSig, JWS, Graphical image of signature, etc.
    /// </summary>
    [FhirType("Signature")]
    [DataContract]
    public partial class Signature : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Signature"; } }


        /// <summary>
        /// Indication of the reason the entity signed the object(s)
        /// </summary>
        [FhirElement("type", InSummary=true, Order=30)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Coding> Type
        {
            get { if (_type==null) _type = new List<Coding>(); return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private List<Coding> _type;

        /// <summary>
        /// When the signature was created
        /// </summary>
        [FhirElement("when", InSummary=true, Order=40)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Instant WhenElement
        {
            get { return _whenElement; }
            set { _whenElement = value; OnPropertyChanged("WhenElement"); }
        }

        private Instant _whenElement;

        /// <summary>
        /// When the signature was created
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? When
        {
            get { return WhenElement != null ? WhenElement.Value : null; }
            set
            {
                if (value == null)
                    WhenElement = null;
                else
                    WhenElement = new Instant(value);
                OnPropertyChanged("When");
            }
        }

        /// <summary>
        /// Who signed
        /// </summary>
        [FhirElement("who", InSummary=true, Order=50)]
        [References("Practitioner","RelatedPerson","Patient","Device","Organization")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Who
        {
            get { return _who; }
            set { _who = value; OnPropertyChanged("Who"); }
        }

        private ResourceReference _who;

        /// <summary>
        /// The party represented
        /// </summary>
        [FhirElement("onBehalfOf", InSummary=true, Order=60)]
        [References("Practitioner","RelatedPerson","Patient","Device","Organization")]
        [DataMember]
        public ResourceReference OnBehalfOf
        {
            get { return _onBehalfOf; }
            set { _onBehalfOf = value; OnPropertyChanged("OnBehalfOf"); }
        }

        private ResourceReference _onBehalfOf;

        /// <summary>
        /// The technical format of the signed resources
        /// </summary>
        [FhirElement("targetFormat", Order=70)]
        [DataMember]
        public Code TargetFormatElement
        {
            get { return _targetFormatElement; }
            set { _targetFormatElement = value; OnPropertyChanged("TargetFormatElement"); }
        }

        private Code _targetFormatElement;

        /// <summary>
        /// The technical format of the signed resources
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string TargetFormat
        {
            get { return TargetFormatElement != null ? TargetFormatElement.Value : null; }
            set
            {
                if (value == null)
                    TargetFormatElement = null;
                else
                    TargetFormatElement = new Code(value);
                OnPropertyChanged("TargetFormat");
            }
        }

        /// <summary>
        /// The technical format of the signature
        /// </summary>
        [FhirElement("sigFormat", Order=80)]
        [DataMember]
        public Code SigFormatElement
        {
            get { return _sigFormatElement; }
            set { _sigFormatElement = value; OnPropertyChanged("SigFormatElement"); }
        }

        private Code _sigFormatElement;

        /// <summary>
        /// The technical format of the signature
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string SigFormat
        {
            get { return SigFormatElement != null ? SigFormatElement.Value : null; }
            set
            {
                if (value == null)
                    SigFormatElement = null;
                else
                    SigFormatElement = new Code(value);
                OnPropertyChanged("SigFormat");
            }
        }

        /// <summary>
        /// The actual signature content (XML DigSig. JWS, picture, etc.)
        /// </summary>
        [FhirElement("data", Order=90)]
        [DataMember]
        public Base64Binary DataElement
        {
            get { return _dataElement; }
            set { _dataElement = value; OnPropertyChanged("DataElement"); }
        }

        private Base64Binary _dataElement;

        /// <summary>
        /// The actual signature content (XML DigSig. JWS, picture, etc.)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public byte[] Data
        {
            get { return DataElement != null ? DataElement.Value : null; }
            set
            {
                if (value == null)
                    DataElement = null;
                else
                    DataElement = new Base64Binary(value);
                OnPropertyChanged("Data");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Signature;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Type != null) dest.Type = new List<Coding>(Type.DeepCopy());
                if (WhenElement != null) dest.WhenElement = (Instant)WhenElement.DeepCopy();
                if (Who != null) dest.Who = (ResourceReference)Who.DeepCopy();
                if (OnBehalfOf != null) dest.OnBehalfOf = (ResourceReference)OnBehalfOf.DeepCopy();
                if (TargetFormatElement != null) dest.TargetFormatElement = (Code)TargetFormatElement.DeepCopy();
                if (SigFormatElement != null) dest.SigFormatElement = (Code)SigFormatElement.DeepCopy();
                if (DataElement != null) dest.DataElement = (Base64Binary)DataElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Signature());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Signature;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(WhenElement, otherT.WhenElement)) return false;
            if (!DeepComparable.Matches(Who, otherT.Who)) return false;
            if (!DeepComparable.Matches(OnBehalfOf, otherT.OnBehalfOf)) return false;
            if (!DeepComparable.Matches(TargetFormatElement, otherT.TargetFormatElement)) return false;
            if (!DeepComparable.Matches(SigFormatElement, otherT.SigFormatElement)) return false;
            if (!DeepComparable.Matches(DataElement, otherT.DataElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Signature;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(WhenElement, otherT.WhenElement)) return false;
            if (!DeepComparable.IsExactly(Who, otherT.Who)) return false;
            if (!DeepComparable.IsExactly(OnBehalfOf, otherT.OnBehalfOf)) return false;
            if (!DeepComparable.IsExactly(TargetFormatElement, otherT.TargetFormatElement)) return false;
            if (!DeepComparable.IsExactly(SigFormatElement, otherT.SigFormatElement)) return false;
            if (!DeepComparable.IsExactly(DataElement, otherT.DataElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                if (WhenElement != null) yield return WhenElement;
                if (Who != null) yield return Who;
                if (OnBehalfOf != null) yield return OnBehalfOf;
                if (TargetFormatElement != null) yield return TargetFormatElement;
                if (SigFormatElement != null) yield return SigFormatElement;
                if (DataElement != null) yield return DataElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                if (WhenElement != null) yield return new ElementValue("when", WhenElement);
                if (Who != null) yield return new ElementValue("who", Who);
                if (OnBehalfOf != null) yield return new ElementValue("onBehalfOf", OnBehalfOf);
                if (TargetFormatElement != null) yield return new ElementValue("targetFormat", TargetFormatElement);
                if (SigFormatElement != null) yield return new ElementValue("sigFormat", SigFormatElement);
                if (DataElement != null) yield return new ElementValue("data", DataElement);
            }
        }

    }

}
