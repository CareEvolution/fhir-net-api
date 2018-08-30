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
    /// An expression that can be used to generate a value
    /// </summary>
    [FhirType("Expression")]
    [DataContract]
    public partial class Expression : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Expression"; } }


        /// <summary>
        /// Natural language description of the condition
        /// </summary>
        [FhirElement("description", InSummary=true, Order=30)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Natural language description of the condition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new FhirString(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Short name assigned to expression for reuse
        /// </summary>
        [FhirElement("name", InSummary=true, Order=40)]
        [DataMember]
        public Id NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private Id _nameElement;

        /// <summary>
        /// Short name assigned to expression for reuse
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                    NameElement = null;
                else
                    NameElement = new Id(value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// text/cql | text/fhirpath | application/x-fhir-query | etc.
        /// </summary>
        [FhirElement("language", InSummary=true, Order=50)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code LanguageElement
        {
            get { return _languageElement; }
            set { _languageElement = value; OnPropertyChanged("LanguageElement"); }
        }

        private Code _languageElement;

        /// <summary>
        /// text/cql | text/fhirpath | application/x-fhir-query | etc.
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
        /// Expression in specified language
        /// </summary>
        [FhirElement("expression", InSummary=true, Order=60)]
        [DataMember]
        public FhirString Expression_Element
        {
            get { return _expression_Element; }
            set { _expression_Element = value; OnPropertyChanged("Expression_Element"); }
        }

        private FhirString _expression_Element;

        /// <summary>
        /// Expression in specified language
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Expression_
        {
            get { return Expression_Element != null ? Expression_Element.Value : null; }
            set
            {
                if (value == null)
                    Expression_Element = null;
                else
                    Expression_Element = new FhirString(value);
                OnPropertyChanged("Expression_");
            }
        }

        /// <summary>
        /// Where the expression is found
        /// </summary>
        [FhirElement("reference", InSummary=true, Order=70)]
        [DataMember]
        public FhirUri ReferenceElement
        {
            get { return _referenceElement; }
            set { _referenceElement = value; OnPropertyChanged("ReferenceElement"); }
        }

        private FhirUri _referenceElement;

        /// <summary>
        /// Where the expression is found
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Reference
        {
            get { return ReferenceElement != null ? ReferenceElement.Value : null; }
            set
            {
                if (value == null)
                    ReferenceElement = null;
                else
                    ReferenceElement = new FhirUri(value);
                OnPropertyChanged("Reference");
            }
        }


        public static ElementDefinition.ConstraintComponent Expression_EXP_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "expression.exists() or reference.exists()",
            Key = "exp-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "An expression or a reference must be provided",
            Xpath = "exists(f:expression) or exists(f:reference)"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Expression;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (Id)NameElement.DeepCopy();
                if (LanguageElement != null) dest.LanguageElement = (Code)LanguageElement.DeepCopy();
                if (Expression_Element != null) dest.Expression_Element = (FhirString)Expression_Element.DeepCopy();
                if (ReferenceElement != null) dest.ReferenceElement = (FhirUri)ReferenceElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Expression());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Expression;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
            if (!DeepComparable.Matches(Expression_Element, otherT.Expression_Element)) return false;
            if (!DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Expression;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
            if (!DeepComparable.IsExactly(Expression_Element, otherT.Expression_Element)) return false;
            if (!DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (DescriptionElement != null) yield return DescriptionElement;
                if (NameElement != null) yield return NameElement;
                if (LanguageElement != null) yield return LanguageElement;
                if (Expression_Element != null) yield return Expression_Element;
                if (ReferenceElement != null) yield return ReferenceElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (LanguageElement != null) yield return new ElementValue("language", LanguageElement);
                if (Expression_Element != null) yield return new ElementValue("expression", Expression_Element);
                if (ReferenceElement != null) yield return new ElementValue("reference", ReferenceElement);
            }
        }

    }

}
