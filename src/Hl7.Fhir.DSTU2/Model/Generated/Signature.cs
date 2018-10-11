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
    /// A digital Signature - XML DigSig, JWT, Graphical image of signature, etc.
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
            get { if (_type == null) _type = new List<Coding>(); return _type; }
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
                if (!value.HasValue)
                    WhenElement = null;
                else
                    WhenElement = new Instant(value);
                OnPropertyChanged("When");
            }
        }

        /// <summary>
        /// Who signed the signature
        /// </summary>
        [FhirElement("who", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirUri),typeof(ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Who
        {
            get { return _who; }
            set { _who = value; OnPropertyChanged("Who"); }
        }

        private Element _who;

        /// <summary>
        /// The technical format of the signature
        /// </summary>
        [FhirElement("contentType", InSummary=true, Order=60)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code ContentTypeElement
        {
            get { return _contentTypeElement; }
            set { _contentTypeElement = value; OnPropertyChanged("ContentTypeElement"); }
        }

        private Code _contentTypeElement;

        /// <summary>
        /// The technical format of the signature
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ContentType
        {
            get { return ContentTypeElement != null ? ContentTypeElement.Value : null; }
            set
            {
                if (value == null)
                    ContentTypeElement = null;
                else
                    ContentTypeElement = new Code(value);
                OnPropertyChanged("ContentType");
            }
        }

        /// <summary>
        /// The actual signature content (XML DigSig. JWT, picture, etc.)
        /// </summary>
        [FhirElement("blob", InSummary=true, Order=70)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Base64Binary BlobElement
        {
            get { return _blobElement; }
            set { _blobElement = value; OnPropertyChanged("BlobElement"); }
        }

        private Base64Binary _blobElement;

        /// <summary>
        /// The actual signature content (XML DigSig. JWT, picture, etc.)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public byte[] Blob
        {
            get { return BlobElement != null ? BlobElement.Value : null; }
            set
            {
                if (value == null)
                    BlobElement = null;
                else
                    BlobElement = new Base64Binary(value);
                OnPropertyChanged("Blob");
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
                if (Who != null) dest.Who = (Element)Who.DeepCopy();
                if (ContentTypeElement != null) dest.ContentTypeElement = (Code)ContentTypeElement.DeepCopy();
                if (BlobElement != null) dest.BlobElement = (Base64Binary)BlobElement.DeepCopy();
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
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(WhenElement, otherT.WhenElement)) return false;
            if (!DeepComparable.Matches(Who, otherT.Who)) return false;
            if (!DeepComparable.Matches(ContentTypeElement, otherT.ContentTypeElement)) return false;
            if (!DeepComparable.Matches(BlobElement, otherT.BlobElement)) return false;

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
            if (!DeepComparable.IsExactly(ContentTypeElement, otherT.ContentTypeElement)) return false;
            if (!DeepComparable.IsExactly(BlobElement, otherT.BlobElement)) return false;

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
                if (ContentTypeElement != null) yield return ContentTypeElement;
                if (BlobElement != null) yield return BlobElement;
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
                if (ContentTypeElement != null) yield return new ElementValue("contentType", ContentTypeElement);
                if (BlobElement != null) yield return new ElementValue("blob", BlobElement);
            }
        }

    }

}
