﻿using System;
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
    /// Text node with attribution
    /// </summary>
    [FhirType("Annotation")]
    [DataContract]
    public partial class Annotation : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Annotation"; } }


        /// <summary>
        /// Individual responsible for the annotation
        /// </summary>
        [FhirElement("author", InSummary=true, Order=30, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(ResourceReference),typeof(FhirString))]
        [DataMember]
        public Element Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private Element _author;

        /// <summary>
        /// When the annotation was made
        /// </summary>
        [FhirElement("time", InSummary=true, Order=40)]
        [DataMember]
        public FhirDateTime TimeElement
        {
            get { return _timeElement; }
            set { _timeElement = value; OnPropertyChanged("TimeElement"); }
        }

        private FhirDateTime _timeElement;

        /// <summary>
        /// When the annotation was made
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Time
        {
            get { return TimeElement != null ? TimeElement.Value : null; }
            set
            {
                if (value == null)
                    TimeElement = null;
                else
                    TimeElement = new FhirDateTime(value);
                OnPropertyChanged("Time");
            }
        }

        /// <summary>
        /// The annotation  - text content (as markdown)
        /// </summary>
        [FhirElement("text", InSummary=true, Order=50)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Markdown TextElement
        {
            get { return _textElement; }
            set { _textElement = value; OnPropertyChanged("TextElement"); }
        }

        private Markdown _textElement;

        /// <summary>
        /// The annotation  - text content (as markdown)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Text
        {
            get { return TextElement != null ? TextElement.Value : null; }
            set
            {
                if (value == null)
                    TextElement = null;
                else
                    TextElement = new Markdown(value);
                OnPropertyChanged("Text");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Annotation;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Author != null) dest.Author = (Element)Author.DeepCopy();
                if (TimeElement != null) dest.TimeElement = (FhirDateTime)TimeElement.DeepCopy();
                if (TextElement != null) dest.TextElement = (Markdown)TextElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Annotation());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Annotation;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(TimeElement, otherT.TimeElement)) return false;
            if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Annotation;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(TimeElement, otherT.TimeElement)) return false;
            if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Author != null) yield return Author;
                if (TimeElement != null) yield return TimeElement;
                if (TextElement != null) yield return TextElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Author != null) yield return new ElementValue("author", Author);
                if (TimeElement != null) yield return new ElementValue("time", TimeElement);
                if (TextElement != null) yield return new ElementValue("text", TextElement);
            }
        }

    }

}