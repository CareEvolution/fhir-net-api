using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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
    /// Related artifacts for a knowledge resource
    /// </summary>
    [FhirType("RelatedArtifact")]
    [DataContract]
    public partial class RelatedArtifact : Element
    {
        [NotMapped]
        public override string TypeName { get { return "RelatedArtifact"; } }


        /// <summary>
        /// documentation | justification | citation | predecessor | successor | derived-from | depends-on | composed-of
        /// </summary>
        [FhirElement("type", InSummary=true, Order=30)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<RelatedArtifactType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<RelatedArtifactType> _typeElement;

        /// <summary>
        /// documentation | justification | citation | predecessor | successor | derived-from | depends-on | composed-of
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RelatedArtifactType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<RelatedArtifactType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Brief description of the related artifact
        /// </summary>
        [FhirElement("display", InSummary=true, Order=40)]
        [DataMember]
        public FhirString DisplayElement
        {
            get { return _displayElement; }
            set { _displayElement = value; OnPropertyChanged("DisplayElement"); }
        }

        private FhirString _displayElement;

        /// <summary>
        /// Brief description of the related artifact
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Display
        {
            get { return DisplayElement != null ? DisplayElement.Value : null; }
            set
            {
                if (value == null)
                    DisplayElement = null;
                else
                    DisplayElement = new FhirString(value);
                OnPropertyChanged("Display");
            }
        }

        /// <summary>
        /// Bibliographic citation for the artifact
        /// </summary>
        [FhirElement("citation", InSummary=true, Order=50)]
        [DataMember]
        public FhirString CitationElement
        {
            get { return _citationElement; }
            set { _citationElement = value; OnPropertyChanged("CitationElement"); }
        }

        private FhirString _citationElement;

        /// <summary>
        /// Bibliographic citation for the artifact
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Citation
        {
            get { return CitationElement != null ? CitationElement.Value : null; }
            set
            {
                if (value == null)
                    CitationElement = null;
                else
                    CitationElement = new FhirString(value);
                OnPropertyChanged("Citation");
            }
        }

        /// <summary>
        /// Where the artifact can be accessed
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
        /// Where the artifact can be accessed
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
        /// What document is being referenced
        /// </summary>
        [FhirElement("document", InSummary=true, Order=70)]
        [DataMember]
        public Attachment Document
        {
            get { return _document; }
            set { _document = value; OnPropertyChanged("Document"); }
        }

        private Attachment _document;

        /// <summary>
        /// What resource is being referenced
        /// </summary>
        [FhirElement("resource", InSummary=true, Order=80)]
        [DataMember]
        public Canonical ResourceElement
        {
            get { return _resourceElement; }
            set { _resourceElement = value; OnPropertyChanged("ResourceElement"); }
        }

        private Canonical _resourceElement;

        /// <summary>
        /// What resource is being referenced
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Resource
        {
            get { return ResourceElement != null ? ResourceElement.Value : null; }
            set
            {
                if (value == null)
                    ResourceElement = null;
                else
                    ResourceElement = new Canonical(value);
                OnPropertyChanged("Resource");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as RelatedArtifact;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (TypeElement != null) dest.TypeElement = (Code<RelatedArtifactType>)TypeElement.DeepCopy();
                if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
                if (CitationElement != null) dest.CitationElement = (FhirString)CitationElement.DeepCopy();
                if (UrlElement != null) dest.UrlElement = (FhirUrl)UrlElement.DeepCopy();
                if (Document != null) dest.Document = (Attachment)Document.DeepCopy();
                if (ResourceElement != null) dest.ResourceElement = (Canonical)ResourceElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new RelatedArtifact());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as RelatedArtifact;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;
            if (!DeepComparable.Matches(CitationElement, otherT.CitationElement)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(Document, otherT.Document)) return false;
            if (!DeepComparable.Matches(ResourceElement, otherT.ResourceElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as RelatedArtifact;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;
            if (!DeepComparable.IsExactly(CitationElement, otherT.CitationElement)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Document, otherT.Document)) return false;
            if (!DeepComparable.IsExactly(ResourceElement, otherT.ResourceElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (TypeElement != null) yield return TypeElement;
                if (DisplayElement != null) yield return DisplayElement;
                if (CitationElement != null) yield return CitationElement;
                if (UrlElement != null) yield return UrlElement;
                if (Document != null) yield return Document;
                if (ResourceElement != null) yield return ResourceElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                if (DisplayElement != null) yield return new ElementValue("display", false, DisplayElement);
                if (CitationElement != null) yield return new ElementValue("citation", false, CitationElement);
                if (UrlElement != null) yield return new ElementValue("url", false, UrlElement);
                if (Document != null) yield return new ElementValue("document", false, Document);
                if (ResourceElement != null) yield return new ElementValue("resource", false, ResourceElement);
            }
        }

    }

}
