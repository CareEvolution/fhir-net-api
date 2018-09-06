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
    /// A human-readable formatted text, including images
    /// </summary>
    [FhirType("Narrative")]
    [DataContract]
    public partial class Narrative : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Narrative"; } }

        /// <summary>
        /// The status of a resource narrative.
        /// (url: http://hl7.org/fhir/ValueSet/narrative-status)
        /// </summary>
        [FhirEnumeration("NarrativeStatus")]
        public enum NarrativeStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/narrative-status)
            /// </summary>
            [EnumLiteral("generated", "http://hl7.org/fhir/narrative-status"), Description("Generated")]
            Generated,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/narrative-status)
            /// </summary>
            [EnumLiteral("extensions", "http://hl7.org/fhir/narrative-status"), Description("Extensions")]
            Extensions,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/narrative-status)
            /// </summary>
            [EnumLiteral("additional", "http://hl7.org/fhir/narrative-status"), Description("Additional")]
            Additional,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/narrative-status)
            /// </summary>
            [EnumLiteral("empty", "http://hl7.org/fhir/narrative-status"), Description("Empty")]
            Empty,
        }


        /// <summary>
        /// generated | extensions | additional | empty
        /// </summary>
        [FhirElement("status", Order=30)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<NarrativeStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<NarrativeStatus> _statusElement;

        /// <summary>
        /// generated | extensions | additional | empty
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public NarrativeStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<NarrativeStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Limited xhtml content
        /// </summary>
        [FhirElement("div", XmlSerialization=XmlRepresentation.XHtml, TypeRedirect = typeof(XHtml), Order=40)]
        [NarrativeXhtmlPattern]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public string Div
        {
            get { return _div; }
            set { _div = value; OnPropertyChanged("Div"); }
        }

        private string _div;


        public static ElementDefinition.ConstraintComponent Narrative_TXT_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "div.all(htmlChecks())",
            Key = "txt-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "The narrative SHALL contain only the basic html formatting elements and attributes described in chapters 7-11 (except section 4 of chapter 9) and 15 of the HTML 4.0 standard, <a> elements (either name or href), images and internally contained style attributes",
            Xpath = "not(descendant-or-self::*[not(local-name(.)=('a', 'abbr', 'acronym', 'b', 'big', 'blockquote', 'br', 'caption', 'cite', 'code', 'col', 'colgroup', 'dd', 'dfn', 'div', 'dl', 'dt', 'em', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'hr', 'i', 'img', 'li', 'ol', 'p', 'pre', 'q', 'samp', 'small', 'span', 'strong', 'sub', 'sup', 'table', 'tbody', 'td', 'tfoot', 'th', 'thead', 'tr', 'tt', 'ul', 'var'))]) and not(descendant-or-self::*/@*[not(name(.)=('abbr', 'accesskey', 'align', 'alt', 'axis', 'bgcolor', 'border', 'cellhalign', 'cellpadding', 'cellspacing', 'cellvalign', 'char', 'charoff', 'charset', 'cite', 'class', 'colspan', 'compact', 'coords', 'dir', 'frame', 'headers', 'height', 'href', 'hreflang', 'hspace', 'id', 'lang', 'longdesc', 'name', 'nowrap', 'rel', 'rev', 'rowspan', 'rules', 'scope', 'shape', 'span', 'src', 'start', 'style', 'summary', 'tabindex', 'title', 'type', 'valign', 'value', 'vspace', 'width'))])"
        };

        public static ElementDefinition.ConstraintComponent Narrative_TXT_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "div.all(htmlChecks())",
            Key = "txt-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "The narrative SHALL have some non-whitespace content",
            Xpath = "descendant::text()[normalize-space(.)!=''] or descendant::h:img[@src]"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Narrative;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (StatusElement != null) dest.StatusElement = (Code<NarrativeStatus>)StatusElement.DeepCopy();
                if (Div != null) dest.Div = Div;
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Narrative());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Narrative;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (Div != otherT.Div) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Narrative;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (Div != otherT.Div) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (StatusElement != null) yield return StatusElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Div != null) yield return new ElementValue("div", Div);
            }
        }

    }

}
