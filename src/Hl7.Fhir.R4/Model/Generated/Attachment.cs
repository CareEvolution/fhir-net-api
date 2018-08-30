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
    /// Content in a format defined elsewhere
    /// </summary>
    [FhirType("Attachment")]
    [DataContract]
    public partial class Attachment : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Attachment"; } }


        /// <summary>
        /// Mime type of the content, with charset etc.
        /// </summary>
        [FhirElement("contentType", InSummary=true, Order=30)]
        [DataMember]
        public Code ContentTypeElement
        {
            get { return _contentTypeElement; }
            set { _contentTypeElement = value; OnPropertyChanged("ContentTypeElement"); }
        }

        private Code _contentTypeElement;

        /// <summary>
        /// Mime type of the content, with charset etc.
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
        /// Human language of the content (BCP-47)
        /// </summary>
        [FhirElement("language", InSummary=true, Order=40)]
        [DataMember]
        public Code LanguageElement
        {
            get { return _languageElement; }
            set { _languageElement = value; OnPropertyChanged("LanguageElement"); }
        }

        private Code _languageElement;

        /// <summary>
        /// Human language of the content (BCP-47)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Language
        {
            get { return LanguageElement != null ? LanguageElement.Value : null; }
            set
            {
                if (value == null)
                    LanguageElement = null;
                else
                    LanguageElement = new Code(value);
                OnPropertyChanged("Language");
            }
        }

        /// <summary>
        /// Data inline, base64ed
        /// </summary>
        [FhirElement("data", Order=50)]
        [DataMember]
        public Base64Binary DataElement
        {
            get { return _dataElement; }
            set { _dataElement = value; OnPropertyChanged("DataElement"); }
        }

        private Base64Binary _dataElement;

        /// <summary>
        /// Data inline, base64ed
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

        /// <summary>
        /// Uri where the data can be found
        /// </summary>
        [FhirElement("url", InSummary=true, Order=60)]
        [DataMember]
        public FhirUrl UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUrl _urlElement;

        /// <summary>
        /// Uri where the data can be found
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                    UrlElement = null;
                else
                    UrlElement = new FhirUrl(value);
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        /// Number of bytes of content (if url provided)
        /// </summary>
        [FhirElement("size", InSummary=true, Order=70)]
        [DataMember]
        public UnsignedInt SizeElement
        {
            get { return _sizeElement; }
            set { _sizeElement = value; OnPropertyChanged("SizeElement"); }
        }

        private UnsignedInt _sizeElement;

        /// <summary>
        /// Number of bytes of content (if url provided)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Size
        {
            get { return SizeElement != null ? SizeElement.Value : null; }
            set
            {
                if (value == null)
                    SizeElement = null;
                else
                    SizeElement = new UnsignedInt(value);
                OnPropertyChanged("Size");
            }
        }

        /// <summary>
        /// Hash of the data (sha-1, base64ed)
        /// </summary>
        [FhirElement("hash", InSummary=true, Order=80)]
        [DataMember]
        public Base64Binary HashElement
        {
            get { return _hashElement; }
            set { _hashElement = value; OnPropertyChanged("HashElement"); }
        }

        private Base64Binary _hashElement;

        /// <summary>
        /// Hash of the data (sha-1, base64ed)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public byte[] Hash
        {
            get { return HashElement != null ? HashElement.Value : null; }
            set
            {
                if (value == null)
                    HashElement = null;
                else
                    HashElement = new Base64Binary(value);
                OnPropertyChanged("Hash");
            }
        }

        /// <summary>
        /// Label to display in place of the data
        /// </summary>
        [FhirElement("title", InSummary=true, Order=90)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Label to display in place of the data
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                    TitleElement = null;
                else
                    TitleElement = new FhirString(value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Date attachment was first created
        /// </summary>
        [FhirElement("creation", InSummary=true, Order=100)]
        [DataMember]
        public FhirDateTime CreationElement
        {
            get { return _creationElement; }
            set { _creationElement = value; OnPropertyChanged("CreationElement"); }
        }

        private FhirDateTime _creationElement;

        /// <summary>
        /// Date attachment was first created
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Creation
        {
            get { return CreationElement != null ? CreationElement.Value : null; }
            set
            {
                if (value == null)
                    CreationElement = null;
                else
                    CreationElement = new FhirDateTime(value);
                OnPropertyChanged("Creation");
            }
        }


        public static ElementDefinition.ConstraintComponent Attachment_ATT_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "data.empty() or contentType.exists()",
            Key = "att-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the Attachment has data, it SHALL have a contentType",
            Xpath = "not(exists(f:data)) or exists(f:contentType)"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Attachment;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (ContentTypeElement != null) dest.ContentTypeElement = (Code)ContentTypeElement.DeepCopy();
                if (LanguageElement != null) dest.LanguageElement = (Code)LanguageElement.DeepCopy();
                if (DataElement != null) dest.DataElement = (Base64Binary)DataElement.DeepCopy();
                if (UrlElement != null) dest.UrlElement = (FhirUrl)UrlElement.DeepCopy();
                if (SizeElement != null) dest.SizeElement = (UnsignedInt)SizeElement.DeepCopy();
                if (HashElement != null) dest.HashElement = (Base64Binary)HashElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (CreationElement != null) dest.CreationElement = (FhirDateTime)CreationElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Attachment());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Attachment;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(ContentTypeElement, otherT.ContentTypeElement)) return false;
            if (!DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
            if (!DeepComparable.Matches(DataElement, otherT.DataElement)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(SizeElement, otherT.SizeElement)) return false;
            if (!DeepComparable.Matches(HashElement, otherT.HashElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(CreationElement, otherT.CreationElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Attachment;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(ContentTypeElement, otherT.ContentTypeElement)) return false;
            if (!DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
            if (!DeepComparable.IsExactly(DataElement, otherT.DataElement)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(SizeElement, otherT.SizeElement)) return false;
            if (!DeepComparable.IsExactly(HashElement, otherT.HashElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(CreationElement, otherT.CreationElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (ContentTypeElement != null) yield return ContentTypeElement;
                if (LanguageElement != null) yield return LanguageElement;
                if (DataElement != null) yield return DataElement;
                if (UrlElement != null) yield return UrlElement;
                if (SizeElement != null) yield return SizeElement;
                if (HashElement != null) yield return HashElement;
                if (TitleElement != null) yield return TitleElement;
                if (CreationElement != null) yield return CreationElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (ContentTypeElement != null) yield return new ElementValue("contentType", ContentTypeElement);
                if (LanguageElement != null) yield return new ElementValue("language", LanguageElement);
                if (DataElement != null) yield return new ElementValue("data", DataElement);
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (SizeElement != null) yield return new ElementValue("size", SizeElement);
                if (HashElement != null) yield return new ElementValue("hash", HashElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (CreationElement != null) yield return new ElementValue("creation", CreationElement);
            }
        }

    }

}
