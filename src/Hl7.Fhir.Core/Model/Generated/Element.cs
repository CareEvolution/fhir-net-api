using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.DSTU2;
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
    /// Base for all elements
    /// </summary>
    [DataContract]
    public abstract partial class Element
    {
        [NotMapped]
        public override string TypeName { get { return "Element"; } }


        /// <summary>
        /// xml:id (or equivalent in JSON)
        /// </summary>
        [FhirElement("id",  XmlSerialization=XmlRepresentation.XmlAttr,TypeRedirect = typeof(Id), InSummary=true, Order=10)]
        [DataMember]
        public FhirString IdElement
        {
            get { return _idElement; }
            set { _idElement = value; OnPropertyChanged("IdElement"); }
        }

        private FhirString _idElement;

        /// <summary>
        /// xml:id (or equivalent in JSON)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Id
        {
            get { return IdElement != null ? IdElement.Value : null; }
            set
            {
                if (value == null)
                    IdElement = null;
                else
                    IdElement = new FhirString(value);
                OnPropertyChanged("Id");
            }
        }

        /// <summary>
        /// Additional Content defined by implementations
        /// </summary>
        [FhirElement("extension", Order=20)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Extension> Extension
        {
            get { if (_extension==null) _extension = new List<Extension>(); return _extension; }
            set { _extension = value; OnPropertyChanged("Extension"); }
        }

        private List<Extension> _extension;


        public static ElementDefinition.ConstraintComponent Element_ELE_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "children()",
            Key = "ele-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "All FHIR elements must have a @value or children",
            Xpath = "@value|f:*|h:div"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Element;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (IdElement != null) dest.IdElement = (FhirString)IdElement.DeepCopy();
                if (Extension != null) dest.Extension = new List<Extension>(Extension.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Element;
            if (otherT == null) return false;

            if (!DeepComparable.Matches(IdElement, otherT.IdElement)) return false;
            if ( !DeepComparable.Matches(Extension, otherT.Extension)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Element;
            if (otherT == null) return false;

            if (!DeepComparable.IsExactly(IdElement, otherT.IdElement)) return false;
            if (!DeepComparable.IsExactly(Extension, otherT.Extension)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Extension) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (IdElement != null) yield return new ElementValue("id", IdElement);
                foreach (var elem in Extension) { if (elem != null) yield return new ElementValue("extension", elem); }
            }
        }

    }

}
