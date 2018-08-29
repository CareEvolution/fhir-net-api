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
    /// Optional Extensions Element
    /// </summary>
    [FhirType("Extension")]
    [DataContract]
    public partial class Extension : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Extension"; } }


        /// <summary>
        /// identifies the meaning of the extension
        /// </summary>
        [FhirElement("url", Order=30)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// identifies the meaning of the extension
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
                    UrlElement = new FhirUri(value);
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        /// Value of extension
        /// </summary>
        [FhirElement("value", Order=40, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Base64Binary),typeof(FhirBoolean),typeof(Canonical),typeof(Code),typeof(Date),typeof(FhirDateTime),typeof(FhirDecimal),typeof(Id),typeof(Instant),typeof(Integer),typeof(Markdown),typeof(Oid),typeof(PositiveInt),typeof(FhirString),typeof(Time),typeof(UnsignedInt),typeof(FhirUri),typeof(FhirUrl),typeof(Uuid),typeof(Address),typeof(Age),typeof(Annotation),typeof(Attachment),typeof(CodeableConcept),typeof(Coding),typeof(ContactPoint),typeof(Count),typeof(Distance),typeof(Duration),typeof(HumanName),typeof(Identifier),typeof(Money),typeof(Period),typeof(Quantity),typeof(Range),typeof(Ratio),typeof(ResourceReference),typeof(SampledData),typeof(Signature),typeof(Timing),typeof(ParameterDefinition),typeof(DataRequirement),typeof(RelatedArtifact),typeof(ContactDetail),typeof(Contributor),typeof(TriggerDefinition),typeof(UsageContext),typeof(Dosage))]
        [DataMember]
        public Element Value
        {
            get { return _value; }
            set { _value = value; OnPropertyChanged("Value"); }
        }

        private Element _value;


        public static ElementDefinition.ConstraintComponent Extension_EXT_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "extension.exists() != value.exists()",
            Key = "ext-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Must have either extensions or value[x], not both",
            Xpath = "exists(f:extension)!=exists(f:*[starts-with(local-name(.), 'value')])"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Extension;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Value != null) dest.Value = (Element)Value.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Extension());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Extension;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(Value, otherT.Value)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Extension;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Value != null) yield return Value;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Value != null) yield return new ElementValue("value", false, Value);
            }
        }

    }

}
