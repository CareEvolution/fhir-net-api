using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using Hl7.Fhir.Validation.STU3;
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
// Generated for FHIR v3.0.1
//
namespace Hl7.Fhir.Model.STU3
{
    /// <summary>
    /// Set of values bounded by low and high
    /// </summary>
    [FhirType("Range")]
    [DataContract]
    public partial class Range : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Range"; } }


        /// <summary>
        /// Low limit
        /// </summary>
        [FhirElement("low", InSummary=true, Order=30)]
        [DataMember]
        public SimpleQuantity Low
        {
            get { return _low; }
            set { _low = value; OnPropertyChanged("Low"); }
        }

        private SimpleQuantity _low;

        /// <summary>
        /// High limit
        /// </summary>
        [FhirElement("high", InSummary=true, Order=40)]
        [DataMember]
        public SimpleQuantity High
        {
            get { return _high; }
            set { _high = value; OnPropertyChanged("High"); }
        }

        private SimpleQuantity _high;


        public static ElementDefinition.ConstraintComponent Range_RNG_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "low.empty() or high.empty() or (low <= high)",
            Key = "rng-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If present, low SHALL have a lower value than high",
            Xpath = "not(exists(f:low/f:value/@value)) or not(exists(f:high/f:value/@value)) or (number(f:low/f:value/@value) <= number(f:high/f:value/@value))"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Range;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Low != null) dest.Low = (SimpleQuantity)Low.DeepCopy();
                if (High != null) dest.High = (SimpleQuantity)High.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Range());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Range;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Low, otherT.Low)) return false;
            if (!DeepComparable.Matches(High, otherT.High)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Range;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Low, otherT.Low)) return false;
            if (!DeepComparable.IsExactly(High, otherT.High)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Low != null) yield return Low;
                if (High != null) yield return High;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Low != null) yield return new ElementValue("low", Low);
                if (High != null) yield return new ElementValue("high", High);
            }
        }

    }

}
