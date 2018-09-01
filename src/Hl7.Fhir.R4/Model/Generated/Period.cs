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
    /// Time range defined by start and end date/time
    /// </summary>
    [FhirType("Period")]
    [DataContract]
    public partial class Period : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Period"; } }


        /// <summary>
        /// Starting time with inclusive boundary
        /// </summary>
        [FhirElement("start", InSummary=true, Order=30)]
        [DataMember]
        public FhirDateTime StartElement
        {
            get { return _startElement; }
            set { _startElement = value; OnPropertyChanged("StartElement"); }
        }

        private FhirDateTime _startElement;

        /// <summary>
        /// Starting time with inclusive boundary
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Start
        {
            get { return StartElement != null ? StartElement.Value : null; }
            set
            {
                if (value == null)
                    StartElement = null;
                else
                    StartElement = new FhirDateTime(value);
                OnPropertyChanged("Start");
            }
        }

        /// <summary>
        /// End time with inclusive boundary, if not ongoing
        /// </summary>
        [FhirElement("end", InSummary=true, Order=40)]
        [DataMember]
        public FhirDateTime EndElement
        {
            get { return _endElement; }
            set { _endElement = value; OnPropertyChanged("EndElement"); }
        }

        private FhirDateTime _endElement;

        /// <summary>
        /// End time with inclusive boundary, if not ongoing
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string End
        {
            get { return EndElement != null ? EndElement.Value : null; }
            set
            {
                if (value == null)
                    EndElement = null;
                else
                    EndElement = new FhirDateTime(value);
                OnPropertyChanged("End");
            }
        }


        public static ElementDefinition.ConstraintComponent Period_PER_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "start.hasValue().not() or end.hasValue().not() or (start <= end)",
            Key = "per-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If present, start SHALL have a lower value than end",
            Xpath = "not(exists(f:start/@value)) or not(exists(f:end/@value)) or (xs:dateTime(f:start/@value) <= xs:dateTime(f:end/@value))"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Period;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (StartElement != null) dest.StartElement = (FhirDateTime)StartElement.DeepCopy();
                if (EndElement != null) dest.EndElement = (FhirDateTime)EndElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Period());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Period;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.Matches(EndElement, otherT.EndElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Period;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
            if (!DeepComparable.IsExactly(EndElement, otherT.EndElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (StartElement != null) yield return StartElement;
                if (EndElement != null) yield return EndElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (StartElement != null) yield return new ElementValue("start", StartElement);
                if (EndElement != null) yield return new ElementValue("end", EndElement);
            }
        }

    }

}
