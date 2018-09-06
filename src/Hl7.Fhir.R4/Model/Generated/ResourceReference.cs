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
    /// A reference from one resource to another
    /// </summary>
    [FhirType("Reference")]
    [DataContract]
    public partial class ResourceReference : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Reference"; } }


        /// <summary>
        /// Literal reference, Relative, internal or absolute URL
        /// </summary>
        [FhirElement("reference", InSummary=true, Order=30)]
        [DataMember]
        public FhirString ReferenceElement
        {
            get { return _referenceElement; }
            set { _referenceElement = value; OnPropertyChanged("ReferenceElement"); }
        }

        private FhirString _referenceElement;

        /// <summary>
        /// Literal reference, Relative, internal or absolute URL
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
                    ReferenceElement = new FhirString(value);
                OnPropertyChanged("Reference");
            }
        }

        /// <summary>
        /// Type the reference refers to (e.g. "Patient")
        /// </summary>
        [FhirElement("type", InSummary=true, Order=40)]
        [DataMember]
        public FhirUri TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private FhirUri _typeElement;

        /// <summary>
        /// Type the reference refers to (e.g. "Patient")
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new FhirUri(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Logical reference, when literal reference is not known
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=50)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Text alternative for the resource
        /// </summary>
        [FhirElement("display", InSummary=true, Order=60)]
        [DataMember]
        public FhirString DisplayElement
        {
            get { return _displayElement; }
            set { _displayElement = value; OnPropertyChanged("DisplayElement"); }
        }

        private FhirString _displayElement;

        /// <summary>
        /// Text alternative for the resource
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


        public static ElementDefinition.ConstraintComponent ResourceReference_REF_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "reference.startsWith('#').not() or (reference.substring(1).trace('url') in %resource.contained.id.trace('ids'))",
            Key = "ref-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "SHALL have a contained resource if a local reference is provided",
            Xpath = "not(starts-with(f:reference/@value, '#')) or exists(ancestor::*[self::f:entry or self::f:parameter]/f:resource/f:*/f:contained/f:*[f:id/@value=substring-after(current()/f:reference/@value, '#')]|/*/f:contained/f:*[f:id/@value=substring-after(current()/f:reference/@value, '#')])"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ResourceReference;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (ReferenceElement != null) dest.ReferenceElement = (FhirString)ReferenceElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = (FhirUri)TypeElement.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ResourceReference());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ResourceReference;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ResourceReference;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (ReferenceElement != null) yield return ReferenceElement;
                if (TypeElement != null) yield return TypeElement;
                if (Identifier != null) yield return Identifier;
                if (DisplayElement != null) yield return DisplayElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (ReferenceElement != null) yield return new ElementValue("reference", ReferenceElement);
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
            }
        }

    }

}
