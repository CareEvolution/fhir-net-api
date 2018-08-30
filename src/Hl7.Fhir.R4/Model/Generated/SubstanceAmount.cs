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
    /// Chemical substances are a single substance type whose primary defining element is the molecular structure. Chemical substances shall be defined on the basis of their complete covalent molecular structure; the presence of a salt (counter-ion) and/or solvates (water, alcohols) is also captured. Purity, grade, physical form or particle size are not taken into account in the definition of a chemical substance or in the assignment of a Substance ID
    /// </summary>
    [FhirType("SubstanceAmount")]
    [DataContract]
    public partial class SubstanceAmount : BackboneElement
    {
        [NotMapped]
        public override string TypeName { get { return "SubstanceAmount"; } }


        [FhirType("ReferenceRangeComponent")]
        [DataContract]
        public partial class ReferenceRangeComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ReferenceRangeComponent"; } }

            /// <summary>
            /// Lower limit possible or expected
            /// </summary>
            [FhirElement("lowLimit", InSummary=true, Order=40)]
            [DataMember]
            public Quantity LowLimit
            {
                get { return _lowLimit; }
                set { _lowLimit = value; OnPropertyChanged("LowLimit"); }
            }

            private Quantity _lowLimit;

            /// <summary>
            /// Upper limit possible or expected
            /// </summary>
            [FhirElement("highLimit", InSummary=true, Order=50)]
            [DataMember]
            public Quantity HighLimit
            {
                get { return _highLimit; }
                set { _highLimit = value; OnPropertyChanged("HighLimit"); }
            }

            private Quantity _highLimit;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReferenceRangeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LowLimit != null) dest.LowLimit = (Quantity)LowLimit.DeepCopy();
                    if (HighLimit != null) dest.HighLimit = (Quantity)HighLimit.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ReferenceRangeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReferenceRangeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LowLimit, otherT.LowLimit)) return false;
                if (!DeepComparable.Matches(HighLimit, otherT.HighLimit)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReferenceRangeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LowLimit, otherT.LowLimit)) return false;
                if (!DeepComparable.IsExactly(HighLimit, otherT.HighLimit)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LowLimit != null) yield return LowLimit;
                    if (HighLimit != null) yield return HighLimit;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LowLimit != null) yield return new ElementValue("lowLimit", LowLimit);
                    if (HighLimit != null) yield return new ElementValue("highLimit", HighLimit);
                }
            }


        }


        /// <summary>
        /// Used to capture quantitative values for a variety of elements. If only limits are given, the arithmetic mean would be the average. If only a single definite value for a given element is given, it would be captured in this field
        /// </summary>
        [FhirElement("amount", InSummary=true, Order=90, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Quantity),typeof(Range),typeof(FhirString))]
        [DataMember]
        public Element Amount
        {
            get { return _amount; }
            set { _amount = value; OnPropertyChanged("Amount"); }
        }

        private Element _amount;

        /// <summary>
        /// Most elements that require a quantitative value will also have a field called amount type. Amount type should always be specified because the actual value of the amount is often dependent on it. EXAMPLE: In capturing the actual relative amounts of substances or molecular fragments it is essential to indicate whether the amount refers to a mole ratio or weight ratio. For any given element an effort should be made to use same the amount type for all related definitional elements
        /// </summary>
        [FhirElement("amountType", InSummary=true, Order=100)]
        [DataMember]
        public CodeableConcept AmountType
        {
            get { return _amountType; }
            set { _amountType = value; OnPropertyChanged("AmountType"); }
        }

        private CodeableConcept _amountType;

        /// <summary>
        /// A textual comment on a numeric value
        /// </summary>
        [FhirElement("amountText", InSummary=true, Order=110)]
        [DataMember]
        public FhirString AmountTextElement
        {
            get { return _amountTextElement; }
            set { _amountTextElement = value; OnPropertyChanged("AmountTextElement"); }
        }

        private FhirString _amountTextElement;

        /// <summary>
        /// A textual comment on a numeric value
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string AmountText
        {
            get { return AmountTextElement != null ? AmountTextElement.Value : null; }
            set
            {
                if (value == null)
                    AmountTextElement = null;
                else
                    AmountTextElement = new FhirString(value);
                OnPropertyChanged("AmountText");
            }
        }

        /// <summary>
        /// Reference range of possible or expected values
        /// </summary>
        [FhirElement("referenceRange", InSummary=true, Order=120)]
        [DataMember]
        public ReferenceRangeComponent ReferenceRange
        {
            get { return _referenceRange; }
            set { _referenceRange = value; OnPropertyChanged("ReferenceRange"); }
        }

        private ReferenceRangeComponent _referenceRange;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SubstanceAmount;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Amount != null) dest.Amount = (Element)Amount.DeepCopy();
                if (AmountType != null) dest.AmountType = (CodeableConcept)AmountType.DeepCopy();
                if (AmountTextElement != null) dest.AmountTextElement = (FhirString)AmountTextElement.DeepCopy();
                if (ReferenceRange != null) dest.ReferenceRange = (ReferenceRangeComponent)ReferenceRange.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new SubstanceAmount());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SubstanceAmount;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
            if (!DeepComparable.Matches(AmountType, otherT.AmountType)) return false;
            if (!DeepComparable.Matches(AmountTextElement, otherT.AmountTextElement)) return false;
            if (!DeepComparable.Matches(ReferenceRange, otherT.ReferenceRange)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SubstanceAmount;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
            if (!DeepComparable.IsExactly(AmountType, otherT.AmountType)) return false;
            if (!DeepComparable.IsExactly(AmountTextElement, otherT.AmountTextElement)) return false;
            if (!DeepComparable.IsExactly(ReferenceRange, otherT.ReferenceRange)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Amount != null) yield return Amount;
                if (AmountType != null) yield return AmountType;
                if (AmountTextElement != null) yield return AmountTextElement;
                if (ReferenceRange != null) yield return ReferenceRange;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Amount != null) yield return new ElementValue("amount", Amount);
                if (AmountType != null) yield return new ElementValue("amountType", AmountType);
                if (AmountTextElement != null) yield return new ElementValue("amountText", AmountTextElement);
                if (ReferenceRange != null) yield return new ElementValue("referenceRange", ReferenceRange);
            }
        }

    }

}
