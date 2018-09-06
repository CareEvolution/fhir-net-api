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
    /// How the medication is/was taken or should be taken
    /// </summary>
    [FhirType("Dosage")]
    [DataContract]
    public partial class Dosage : BackboneElement
    {
        [NotMapped]
        public override string TypeName { get { return "Dosage"; } }


        [FhirType("DoseAndRateComponent")]
        [DataContract]
        public partial class DoseAndRateComponent : Element, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DoseAndRateComponent"; } }

            /// <summary>
            /// The kind of dose or rate specified
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Amount of medication per dose
            /// </summary>
            [FhirElement("dose", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Range),typeof(SimpleQuantity))]
            [DataMember]
            public Element Dose
            {
                get { return _dose; }
                set { _dose = value; OnPropertyChanged("Dose"); }
            }

            private Element _dose;

            /// <summary>
            /// Amount of medication per unit of time
            /// </summary>
            [FhirElement("rate", InSummary=true, Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Ratio),typeof(Range),typeof(SimpleQuantity))]
            [DataMember]
            public Element Rate
            {
                get { return _rate; }
                set { _rate = value; OnPropertyChanged("Rate"); }
            }

            private Element _rate;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DoseAndRateComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Dose != null) dest.Dose = (Element)Dose.DeepCopy();
                    if (Rate != null) dest.Rate = (Element)Rate.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DoseAndRateComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DoseAndRateComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Dose, otherT.Dose)) return false;
                if (!DeepComparable.Matches(Rate, otherT.Rate)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DoseAndRateComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Dose, otherT.Dose)) return false;
                if (!DeepComparable.IsExactly(Rate, otherT.Rate)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Dose != null) yield return Dose;
                    if (Rate != null) yield return Rate;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Dose != null) yield return new ElementValue("dose", Dose);
                    if (Rate != null) yield return new ElementValue("rate", Rate);
                }
            }


        }


        /// <summary>
        /// The order of the dosage instructions
        /// </summary>
        [FhirElement("sequence", InSummary=true, Order=90)]
        [DataMember]
        public Integer SequenceElement
        {
            get { return _sequenceElement; }
            set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
        }

        private Integer _sequenceElement;

        /// <summary>
        /// The order of the dosage instructions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Sequence
        {
            get { return SequenceElement != null ? SequenceElement.Value : null; }
            set
            {
                if (value == null)
                    SequenceElement = null;
                else
                    SequenceElement = new Integer(value);
                OnPropertyChanged("Sequence");
            }
        }

        /// <summary>
        /// Free text dosage instructions e.g. SIG
        /// </summary>
        [FhirElement("text", InSummary=true, Order=100)]
        [DataMember]
        public FhirString TextElement
        {
            get { return _textElement; }
            set { _textElement = value; OnPropertyChanged("TextElement"); }
        }

        private FhirString _textElement;

        /// <summary>
        /// Free text dosage instructions e.g. SIG
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
                    TextElement = new FhirString(value);
                OnPropertyChanged("Text");
            }
        }

        /// <summary>
        /// Supplemental instruction or warnings to the patient - e.g. "with meals", "may cause drowsiness"
        /// </summary>
        [FhirElement("additionalInstruction", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> AdditionalInstruction
        {
            get { if (_additionalInstruction==null) _additionalInstruction = new List<CodeableConcept>(); return _additionalInstruction; }
            set { _additionalInstruction = value; OnPropertyChanged("AdditionalInstruction"); }
        }

        private List<CodeableConcept> _additionalInstruction;

        /// <summary>
        /// Patient or consumer oriented instructions
        /// </summary>
        [FhirElement("patientInstruction", InSummary=true, Order=120)]
        [DataMember]
        public FhirString PatientInstructionElement
        {
            get { return _patientInstructionElement; }
            set { _patientInstructionElement = value; OnPropertyChanged("PatientInstructionElement"); }
        }

        private FhirString _patientInstructionElement;

        /// <summary>
        /// Patient or consumer oriented instructions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PatientInstruction
        {
            get { return PatientInstructionElement != null ? PatientInstructionElement.Value : null; }
            set
            {
                if (value == null)
                    PatientInstructionElement = null;
                else
                    PatientInstructionElement = new FhirString(value);
                OnPropertyChanged("PatientInstruction");
            }
        }

        /// <summary>
        /// When medication should be administered
        /// </summary>
        [FhirElement("timing", InSummary=true, Order=130)]
        [DataMember]
        public Timing Timing
        {
            get { return _timing; }
            set { _timing = value; OnPropertyChanged("Timing"); }
        }

        private Timing _timing;

        /// <summary>
        /// Take "as needed" (for x)
        /// </summary>
        [FhirElement("asNeeded", InSummary=true, Order=140, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirBoolean),typeof(CodeableConcept))]
        [DataMember]
        public Element AsNeeded
        {
            get { return _asNeeded; }
            set { _asNeeded = value; OnPropertyChanged("AsNeeded"); }
        }

        private Element _asNeeded;

        /// <summary>
        /// Body site to administer to
        /// </summary>
        [FhirElement("site", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept Site
        {
            get { return _site; }
            set { _site = value; OnPropertyChanged("Site"); }
        }

        private CodeableConcept _site;

        /// <summary>
        /// How drug should enter body
        /// </summary>
        [FhirElement("route", InSummary=true, Order=160)]
        [DataMember]
        public CodeableConcept Route
        {
            get { return _route; }
            set { _route = value; OnPropertyChanged("Route"); }
        }

        private CodeableConcept _route;

        /// <summary>
        /// Technique for administering medication
        /// </summary>
        [FhirElement("method", InSummary=true, Order=170)]
        [DataMember]
        public CodeableConcept Method
        {
            get { return _method; }
            set { _method = value; OnPropertyChanged("Method"); }
        }

        private CodeableConcept _method;

        /// <summary>
        /// Amount of medication administered
        /// </summary>
        [FhirElement("doseAndRate", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DoseAndRateComponent> DoseAndRate
        {
            get { if (_doseAndRate==null) _doseAndRate = new List<DoseAndRateComponent>(); return _doseAndRate; }
            set { _doseAndRate = value; OnPropertyChanged("DoseAndRate"); }
        }

        private List<DoseAndRateComponent> _doseAndRate;

        /// <summary>
        /// Upper limit on medication per unit of time
        /// </summary>
        [FhirElement("maxDosePerPeriod", InSummary=true, Order=190)]
        [DataMember]
        public Ratio MaxDosePerPeriod
        {
            get { return _maxDosePerPeriod; }
            set { _maxDosePerPeriod = value; OnPropertyChanged("MaxDosePerPeriod"); }
        }

        private Ratio _maxDosePerPeriod;

        /// <summary>
        /// Upper limit on medication per administration
        /// </summary>
        [FhirElement("maxDosePerAdministration", InSummary=true, Order=200)]
        [DataMember]
        public SimpleQuantity MaxDosePerAdministration
        {
            get { return _maxDosePerAdministration; }
            set { _maxDosePerAdministration = value; OnPropertyChanged("MaxDosePerAdministration"); }
        }

        private SimpleQuantity _maxDosePerAdministration;

        /// <summary>
        /// Upper limit on medication per lifetime of the patient
        /// </summary>
        [FhirElement("maxDosePerLifetime", InSummary=true, Order=210)]
        [DataMember]
        public SimpleQuantity MaxDosePerLifetime
        {
            get { return _maxDosePerLifetime; }
            set { _maxDosePerLifetime = value; OnPropertyChanged("MaxDosePerLifetime"); }
        }

        private SimpleQuantity _maxDosePerLifetime;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Dosage;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (SequenceElement != null) dest.SequenceElement = (Integer)SequenceElement.DeepCopy();
                if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                if (AdditionalInstruction != null) dest.AdditionalInstruction = new List<CodeableConcept>(AdditionalInstruction.DeepCopy());
                if (PatientInstructionElement != null) dest.PatientInstructionElement = (FhirString)PatientInstructionElement.DeepCopy();
                if (Timing != null) dest.Timing = (Timing)Timing.DeepCopy();
                if (AsNeeded != null) dest.AsNeeded = (Element)AsNeeded.DeepCopy();
                if (Site != null) dest.Site = (CodeableConcept)Site.DeepCopy();
                if (Route != null) dest.Route = (CodeableConcept)Route.DeepCopy();
                if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                if (DoseAndRate != null) dest.DoseAndRate = new List<DoseAndRateComponent>(DoseAndRate.DeepCopy());
                if (MaxDosePerPeriod != null) dest.MaxDosePerPeriod = (Ratio)MaxDosePerPeriod.DeepCopy();
                if (MaxDosePerAdministration != null) dest.MaxDosePerAdministration = (SimpleQuantity)MaxDosePerAdministration.DeepCopy();
                if (MaxDosePerLifetime != null) dest.MaxDosePerLifetime = (SimpleQuantity)MaxDosePerLifetime.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Dosage());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Dosage;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
            if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
            if ( !DeepComparable.Matches(AdditionalInstruction, otherT.AdditionalInstruction)) return false;
            if (!DeepComparable.Matches(PatientInstructionElement, otherT.PatientInstructionElement)) return false;
            if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
            if (!DeepComparable.Matches(AsNeeded, otherT.AsNeeded)) return false;
            if (!DeepComparable.Matches(Site, otherT.Site)) return false;
            if (!DeepComparable.Matches(Route, otherT.Route)) return false;
            if (!DeepComparable.Matches(Method, otherT.Method)) return false;
            if ( !DeepComparable.Matches(DoseAndRate, otherT.DoseAndRate)) return false;
            if (!DeepComparable.Matches(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;
            if (!DeepComparable.Matches(MaxDosePerAdministration, otherT.MaxDosePerAdministration)) return false;
            if (!DeepComparable.Matches(MaxDosePerLifetime, otherT.MaxDosePerLifetime)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Dosage;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
            if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
            if (!DeepComparable.IsExactly(AdditionalInstruction, otherT.AdditionalInstruction)) return false;
            if (!DeepComparable.IsExactly(PatientInstructionElement, otherT.PatientInstructionElement)) return false;
            if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
            if (!DeepComparable.IsExactly(AsNeeded, otherT.AsNeeded)) return false;
            if (!DeepComparable.IsExactly(Site, otherT.Site)) return false;
            if (!DeepComparable.IsExactly(Route, otherT.Route)) return false;
            if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
            if (!DeepComparable.IsExactly(DoseAndRate, otherT.DoseAndRate)) return false;
            if (!DeepComparable.IsExactly(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;
            if (!DeepComparable.IsExactly(MaxDosePerAdministration, otherT.MaxDosePerAdministration)) return false;
            if (!DeepComparable.IsExactly(MaxDosePerLifetime, otherT.MaxDosePerLifetime)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (SequenceElement != null) yield return SequenceElement;
                if (TextElement != null) yield return TextElement;
                foreach (var elem in AdditionalInstruction) { if (elem != null) yield return elem; }
                if (PatientInstructionElement != null) yield return PatientInstructionElement;
                if (Timing != null) yield return Timing;
                if (AsNeeded != null) yield return AsNeeded;
                if (Site != null) yield return Site;
                if (Route != null) yield return Route;
                if (Method != null) yield return Method;
                foreach (var elem in DoseAndRate) { if (elem != null) yield return elem; }
                if (MaxDosePerPeriod != null) yield return MaxDosePerPeriod;
                if (MaxDosePerAdministration != null) yield return MaxDosePerAdministration;
                if (MaxDosePerLifetime != null) yield return MaxDosePerLifetime;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                if (TextElement != null) yield return new ElementValue("text", TextElement);
                foreach (var elem in AdditionalInstruction) { if (elem != null) yield return new ElementValue("additionalInstruction", elem); }
                if (PatientInstructionElement != null) yield return new ElementValue("patientInstruction", PatientInstructionElement);
                if (Timing != null) yield return new ElementValue("timing", Timing);
                if (AsNeeded != null) yield return new ElementValue("asNeeded", AsNeeded);
                if (Site != null) yield return new ElementValue("site", Site);
                if (Route != null) yield return new ElementValue("route", Route);
                if (Method != null) yield return new ElementValue("method", Method);
                foreach (var elem in DoseAndRate) { if (elem != null) yield return new ElementValue("doseAndRate", elem); }
                if (MaxDosePerPeriod != null) yield return new ElementValue("maxDosePerPeriod", MaxDosePerPeriod);
                if (MaxDosePerAdministration != null) yield return new ElementValue("maxDosePerAdministration", MaxDosePerAdministration);
                if (MaxDosePerLifetime != null) yield return new ElementValue("maxDosePerLifetime", MaxDosePerLifetime);
            }
        }

    }

}
