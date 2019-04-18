using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Prescription of medication to for patient
    /// </summary>
    [FhirType("MedicationOrder", IsResource = true)]
    [DataContract]
    public partial class MedicationOrder : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationOrder; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationOrder"; } }

        /// <summary>
        /// A code specifying the state of the prescribing event. Describes the lifecycle of the prescription.
        /// (url: http://hl7.org/fhir/ValueSet/medication-order-status)
        /// </summary>
        [FhirEnumeration("MedicationOrderStatus")]
        public enum MedicationOrderStatus
        {
            /// <summary>
            /// The prescription is 'actionable', but not all actions that are implied by it have occurred yet.
            /// (system: http://hl7.org/fhir/medication-order-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/medication-order-status"), Description("Active")]
            Active,
            /// <summary>
            /// Actions implied by the prescription are to be temporarily halted, but are expected to continue later.  May also be called "suspended".
            /// (system: http://hl7.org/fhir/medication-order-status)
            /// </summary>
            [EnumLiteral("on-hold", "http://hl7.org/fhir/medication-order-status"), Description("On Hold")]
            OnHold,
            /// <summary>
            /// All actions that are implied by the prescription have occurred.
            /// (system: http://hl7.org/fhir/medication-order-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/medication-order-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The prescription was entered in error.
            /// (system: http://hl7.org/fhir/medication-order-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/medication-order-status"), Description("Entered In Error")]
            EnteredInError,
            /// <summary>
            /// Actions implied by the prescription are to be permanently halted, before all of them occurred.
            /// (system: http://hl7.org/fhir/medication-order-status)
            /// </summary>
            [EnumLiteral("stopped", "http://hl7.org/fhir/medication-order-status"), Description("Stopped")]
            Stopped,
            /// <summary>
            /// The prescription is not yet 'actionable', i.e. it is a work in progress, requires sign-off or verification, and needs to be run through decision support process.
            /// (system: http://hl7.org/fhir/medication-order-status)
            /// </summary>
            [EnumLiteral("draft", "http://hl7.org/fhir/medication-order-status"), Description("Draft")]
            Draft,
        }


        [FhirType("DosageInstructionComponent")]
        [DataContract]
        public partial class DosageInstructionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DosageInstructionComponent"; } }

            /// <summary>
            /// Dosage instructions expressed as text
            /// </summary>
            [FhirElement("text", InSummary = true, Order = 40)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Dosage instructions expressed as text
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
            /// Supplemental instructions - e.g. "with meals"
            /// </summary>
            [FhirElement("additionalInstructions", InSummary = true, Order = 50)]
            [DataMember]
            public CodeableConcept AdditionalInstructions
            {
                get { return _additionalInstructions; }
                set { _additionalInstructions = value; OnPropertyChanged("AdditionalInstructions"); }
            }

            private CodeableConcept _additionalInstructions;

            /// <summary>
            /// When medication should be administered
            /// </summary>
            [FhirElement("timing", InSummary = true, Order = 60)]
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
            [FhirElement("asNeeded", InSummary = true, Order = 70, Choice = ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean), typeof(CodeableConcept))]
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
            [FhirElement("site", InSummary = true, Order = 80, Choice = ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept), typeof(ResourceReference))]
            [DataMember]
            public Element Site
            {
                get { return _site; }
                set { _site = value; OnPropertyChanged("Site"); }
            }

            private Element _site;

            /// <summary>
            /// How drug should enter body
            /// </summary>
            [FhirElement("route", InSummary = true, Order = 90)]
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
            [FhirElement("method", InSummary = true, Order = 100)]
            [DataMember]
            public CodeableConcept Method
            {
                get { return _method; }
                set { _method = value; OnPropertyChanged("Method"); }
            }

            private CodeableConcept _method;

            /// <summary>
            /// Amount of medication per dose
            /// </summary>
            [FhirElement("dose", InSummary = true, Order = 110, Choice = ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Range), typeof(SimpleQuantity))]
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
            [FhirElement("rate", InSummary = true, Order = 120, Choice = ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Ratio), typeof(Range))]
            [DataMember]
            public Element Rate
            {
                get { return _rate; }
                set { _rate = value; OnPropertyChanged("Rate"); }
            }

            private Element _rate;

            /// <summary>
            /// Upper limit on medication per unit of time
            /// </summary>
            [FhirElement("maxDosePerPeriod", InSummary = true, Order = 130)]
            [DataMember]
            public Ratio MaxDosePerPeriod
            {
                get { return _maxDosePerPeriod; }
                set { _maxDosePerPeriod = value; OnPropertyChanged("MaxDosePerPeriod"); }
            }

            private Ratio _maxDosePerPeriod;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DosageInstructionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (AdditionalInstructions != null) dest.AdditionalInstructions = (CodeableConcept)AdditionalInstructions.DeepCopy();
                    if (Timing != null) dest.Timing = (Timing)Timing.DeepCopy();
                    if (AsNeeded != null) dest.AsNeeded = (Element)AsNeeded.DeepCopy();
                    if (Site != null) dest.Site = (Element)Site.DeepCopy();
                    if (Route != null) dest.Route = (CodeableConcept)Route.DeepCopy();
                    if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                    if (Dose != null) dest.Dose = (Element)Dose.DeepCopy();
                    if (Rate != null) dest.Rate = (Element)Rate.DeepCopy();
                    if (MaxDosePerPeriod != null) dest.MaxDosePerPeriod = (Ratio)MaxDosePerPeriod.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new DosageInstructionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DosageInstructionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(AdditionalInstructions, otherT.AdditionalInstructions)) return false;
                if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
                if (!DeepComparable.Matches(AsNeeded, otherT.AsNeeded)) return false;
                if (!DeepComparable.Matches(Site, otherT.Site)) return false;
                if (!DeepComparable.Matches(Route, otherT.Route)) return false;
                if (!DeepComparable.Matches(Method, otherT.Method)) return false;
                if (!DeepComparable.Matches(Dose, otherT.Dose)) return false;
                if (!DeepComparable.Matches(Rate, otherT.Rate)) return false;
                if (!DeepComparable.Matches(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DosageInstructionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(AdditionalInstructions, otherT.AdditionalInstructions)) return false;
                if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
                if (!DeepComparable.IsExactly(AsNeeded, otherT.AsNeeded)) return false;
                if (!DeepComparable.IsExactly(Site, otherT.Site)) return false;
                if (!DeepComparable.IsExactly(Route, otherT.Route)) return false;
                if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if (!DeepComparable.IsExactly(Dose, otherT.Dose)) return false;
                if (!DeepComparable.IsExactly(Rate, otherT.Rate)) return false;
                if (!DeepComparable.IsExactly(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TextElement != null) yield return TextElement;
                    if (AdditionalInstructions != null) yield return AdditionalInstructions;
                    if (Timing != null) yield return Timing;
                    if (AsNeeded != null) yield return AsNeeded;
                    if (Site != null) yield return Site;
                    if (Route != null) yield return Route;
                    if (Method != null) yield return Method;
                    if (Dose != null) yield return Dose;
                    if (Rate != null) yield return Rate;
                    if (MaxDosePerPeriod != null) yield return MaxDosePerPeriod;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    if (AdditionalInstructions != null) yield return new ElementValue("additionalInstructions", AdditionalInstructions);
                    if (Timing != null) yield return new ElementValue("timing", Timing);
                    if (AsNeeded != null) yield return new ElementValue("asNeeded", AsNeeded);
                    if (Site != null) yield return new ElementValue("site", Site);
                    if (Route != null) yield return new ElementValue("route", Route);
                    if (Method != null) yield return new ElementValue("method", Method);
                    if (Dose != null) yield return new ElementValue("dose", Dose);
                    if (Rate != null) yield return new ElementValue("rate", Rate);
                    if (MaxDosePerPeriod != null) yield return new ElementValue("maxDosePerPeriod", MaxDosePerPeriod);
                }
            }


        }


        [FhirType("DispenseRequestComponent")]
        [DataContract]
        public partial class DispenseRequestComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DispenseRequestComponent"; } }

            /// <summary>
            /// Product to be supplied
            /// </summary>
            [FhirElement("medication", InSummary = true, Order = 40, Choice = ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept), typeof(ResourceReference))]
            [DataMember]
            public Element Medication
            {
                get { return _medication; }
                set { _medication = value; OnPropertyChanged("Medication"); }
            }

            private Element _medication;

            /// <summary>
            /// Time period supply is authorized for
            /// </summary>
            [FhirElement("validityPeriod", InSummary = true, Order = 50)]
            [DataMember]
            public Period ValidityPeriod
            {
                get { return _validityPeriod; }
                set { _validityPeriod = value; OnPropertyChanged("ValidityPeriod"); }
            }

            private Period _validityPeriod;

            /// <summary>
            /// Number of refills authorized
            /// </summary>
            [FhirElement("numberOfRepeatsAllowed", InSummary = true, Order = 60)]
            [DataMember]
            public PositiveInt NumberOfRepeatsAllowedElement
            {
                get { return _numberOfRepeatsAllowedElement; }
                set { _numberOfRepeatsAllowedElement = value; OnPropertyChanged("NumberOfRepeatsAllowedElement"); }
            }

            private PositiveInt _numberOfRepeatsAllowedElement;

            /// <summary>
            /// Number of refills authorized
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? NumberOfRepeatsAllowed
            {
                get { return NumberOfRepeatsAllowedElement != null ? NumberOfRepeatsAllowedElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        NumberOfRepeatsAllowedElement = null;
                    else
                        NumberOfRepeatsAllowedElement = new PositiveInt(value);
                    OnPropertyChanged("NumberOfRepeatsAllowed");
                }
            }

            /// <summary>
            /// Amount of medication to supply per dispense
            /// </summary>
            [FhirElement("quantity", InSummary = true, Order = 70)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Number of days supply per dispense
            /// </summary>
            [FhirElement("expectedSupplyDuration", InSummary = true, Order = 80)]
            [DataMember]
            public Duration ExpectedSupplyDuration
            {
                get { return _expectedSupplyDuration; }
                set { _expectedSupplyDuration = value; OnPropertyChanged("ExpectedSupplyDuration"); }
            }

            private Duration _expectedSupplyDuration;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DispenseRequestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                    if (ValidityPeriod != null) dest.ValidityPeriod = (Period)ValidityPeriod.DeepCopy();
                    if (NumberOfRepeatsAllowedElement != null) dest.NumberOfRepeatsAllowedElement = (PositiveInt)NumberOfRepeatsAllowedElement.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (ExpectedSupplyDuration != null) dest.ExpectedSupplyDuration = (Duration)ExpectedSupplyDuration.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new DispenseRequestComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DispenseRequestComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
                if (!DeepComparable.Matches(ValidityPeriod, otherT.ValidityPeriod)) return false;
                if (!DeepComparable.Matches(NumberOfRepeatsAllowedElement, otherT.NumberOfRepeatsAllowedElement)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(ExpectedSupplyDuration, otherT.ExpectedSupplyDuration)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DispenseRequestComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
                if (!DeepComparable.IsExactly(ValidityPeriod, otherT.ValidityPeriod)) return false;
                if (!DeepComparable.IsExactly(NumberOfRepeatsAllowedElement, otherT.NumberOfRepeatsAllowedElement)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(ExpectedSupplyDuration, otherT.ExpectedSupplyDuration)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Medication != null) yield return Medication;
                    if (ValidityPeriod != null) yield return ValidityPeriod;
                    if (NumberOfRepeatsAllowedElement != null) yield return NumberOfRepeatsAllowedElement;
                    if (Quantity != null) yield return Quantity;
                    if (ExpectedSupplyDuration != null) yield return ExpectedSupplyDuration;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Medication != null) yield return new ElementValue("medication", Medication);
                    if (ValidityPeriod != null) yield return new ElementValue("validityPeriod", ValidityPeriod);
                    if (NumberOfRepeatsAllowedElement != null) yield return new ElementValue("numberOfRepeatsAllowed", NumberOfRepeatsAllowedElement);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (ExpectedSupplyDuration != null) yield return new ElementValue("expectedSupplyDuration", ExpectedSupplyDuration);
                }
            }


        }


        [FhirType("SubstitutionComponent")]
        [DataContract]
        public partial class SubstitutionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubstitutionComponent"; } }

            /// <summary>
            /// generic | formulary +
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Why should (not) substitution be made
            /// </summary>
            [FhirElement("reason", InSummary = true, Order = 50)]
            [DataMember]
            public CodeableConcept Reason
            {
                get { return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private CodeableConcept _reason;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstitutionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SubstitutionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Reason != null) yield return Reason;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Reason != null) yield return new ElementValue("reason", Reason);
                }
            }


        }


        /// <summary>
        /// External identifier
        /// </summary>
        [FhirElement("identifier", InSummary = true, Order = 90)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// When prescription was authorized
        /// </summary>
        [FhirElement("dateWritten", InSummary = true, Order = 100)]
        [DataMember]
        public FhirDateTime DateWrittenElement
        {
            get { return _dateWrittenElement; }
            set { _dateWrittenElement = value; OnPropertyChanged("DateWrittenElement"); }
        }

        private FhirDateTime _dateWrittenElement;

        /// <summary>
        /// When prescription was authorized
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateWritten
        {
            get { return DateWrittenElement != null ? DateWrittenElement.Value : null; }
            set
            {
                if (value == null)
                    DateWrittenElement = null;
                else
                    DateWrittenElement = new FhirDateTime(value);
                OnPropertyChanged("DateWritten");
            }
        }

        /// <summary>
        /// active | on-hold | completed | entered-in-error | stopped | draft
        /// </summary>
        [FhirElement("status", InSummary = true, Order = 110)]
        [DataMember]
        public Code<MedicationOrderStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationOrderStatus> _statusElement;

        /// <summary>
        /// active | on-hold | completed | entered-in-error | stopped | draft
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationOrderStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationOrderStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// When prescription was stopped
        /// </summary>
        [FhirElement("dateEnded", InSummary = true, Order = 120)]
        [DataMember]
        public FhirDateTime DateEndedElement
        {
            get { return _dateEndedElement; }
            set { _dateEndedElement = value; OnPropertyChanged("DateEndedElement"); }
        }

        private FhirDateTime _dateEndedElement;

        /// <summary>
        /// When prescription was stopped
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateEnded
        {
            get { return DateEndedElement != null ? DateEndedElement.Value : null; }
            set
            {
                if (value == null)
                    DateEndedElement = null;
                else
                    DateEndedElement = new FhirDateTime(value);
                OnPropertyChanged("DateEnded");
            }
        }

        /// <summary>
        /// Why prescription was stopped
        /// </summary>
        [FhirElement("reasonEnded", InSummary = true, Order = 130)]
        [DataMember]
        public CodeableConcept ReasonEnded
        {
            get { return _reasonEnded; }
            set { _reasonEnded = value; OnPropertyChanged("ReasonEnded"); }
        }

        private CodeableConcept _reasonEnded;

        /// <summary>
        /// Who prescription is for
        /// </summary>
        [FhirElement("patient", InSummary = true, Order = 140)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Who ordered the medication(s)
        /// </summary>
        [FhirElement("prescriber", InSummary = true, Order = 150)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Prescriber
        {
            get { return _prescriber; }
            set { _prescriber = value; OnPropertyChanged("Prescriber"); }
        }

        private ResourceReference _prescriber;

        /// <summary>
        /// Created during encounter/admission/stay
        /// </summary>
        [FhirElement("encounter", InSummary = true, Order = 160)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Reason or indication for writing the prescription
        /// </summary>
        [FhirElement("reason", InSummary = true, Order = 170, Choice = ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept), typeof(ResourceReference))]
        [DataMember]
        public Element Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private Element _reason;

        /// <summary>
        /// Information about the prescription
        /// </summary>
        [FhirElement("note", InSummary = true, Order = 180)]
        [DataMember]
        public FhirString NoteElement
        {
            get { return _noteElement; }
            set { _noteElement = value; OnPropertyChanged("NoteElement"); }
        }

        private FhirString _noteElement;

        /// <summary>
        /// Information about the prescription
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Note
        {
            get { return NoteElement != null ? NoteElement.Value : null; }
            set
            {
                if (value == null)
                    NoteElement = null;
                else
                    NoteElement = new FhirString(value);
                OnPropertyChanged("Note");
            }
        }

        /// <summary>
        /// Medication to be taken
        /// </summary>
        [FhirElement("medication", InSummary = true, Order = 190, Choice = ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept), typeof(ResourceReference))]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public Element Medication
        {
            get { return _medication; }
            set { _medication = value; OnPropertyChanged("Medication"); }
        }

        private Element _medication;

        /// <summary>
        /// How medication should be taken
        /// </summary>
        [FhirElement("dosageInstruction", InSummary = true, Order = 200)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<DosageInstructionComponent> DosageInstruction
        {
            get { if (_dosageInstruction == null) _dosageInstruction = new List<DosageInstructionComponent>(); return _dosageInstruction; }
            set { _dosageInstruction = value; OnPropertyChanged("DosageInstruction"); }
        }

        private List<DosageInstructionComponent> _dosageInstruction;

        /// <summary>
        /// Medication supply authorization
        /// </summary>
        [FhirElement("dispenseRequest", InSummary = true, Order = 210)]
        [DataMember]
        public DispenseRequestComponent DispenseRequest
        {
            get { return _dispenseRequest; }
            set { _dispenseRequest = value; OnPropertyChanged("DispenseRequest"); }
        }

        private DispenseRequestComponent _dispenseRequest;

        /// <summary>
        /// Any restrictions on medication substitution
        /// </summary>
        [FhirElement("substitution", InSummary = true, Order = 220)]
        [DataMember]
        public SubstitutionComponent Substitution
        {
            get { return _substitution; }
            set { _substitution = value; OnPropertyChanged("Substitution"); }
        }

        private SubstitutionComponent _substitution;

        /// <summary>
        /// An order/prescription that this supersedes
        /// </summary>
        [FhirElement("priorPrescription", InSummary = true, Order = 230)]
        [References("MedicationOrder")]
        [DataMember]
        public ResourceReference PriorPrescription
        {
            get { return _priorPrescription; }
            set { _priorPrescription = value; OnPropertyChanged("PriorPrescription"); }
        }

        private ResourceReference _priorPrescription;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationOrder;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (DateWrittenElement != null) dest.DateWrittenElement = (FhirDateTime)DateWrittenElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<MedicationOrderStatus>)StatusElement.DeepCopy();
                if (DateEndedElement != null) dest.DateEndedElement = (FhirDateTime)DateEndedElement.DeepCopy();
                if (ReasonEnded != null) dest.ReasonEnded = (CodeableConcept)ReasonEnded.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Prescriber != null) dest.Prescriber = (ResourceReference)Prescriber.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Reason != null) dest.Reason = (Element)Reason.DeepCopy();
                if (NoteElement != null) dest.NoteElement = (FhirString)NoteElement.DeepCopy();
                if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                if (DosageInstruction != null) dest.DosageInstruction = new List<DosageInstructionComponent>(DosageInstruction.DeepCopy());
                if (DispenseRequest != null) dest.DispenseRequest = (DispenseRequestComponent)DispenseRequest.DeepCopy();
                if (Substitution != null) dest.Substitution = (SubstitutionComponent)Substitution.DeepCopy();
                if (PriorPrescription != null) dest.PriorPrescription = (ResourceReference)PriorPrescription.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new MedicationOrder());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationOrder;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(DateWrittenElement, otherT.DateWrittenElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(DateEndedElement, otherT.DateEndedElement)) return false;
            if (!DeepComparable.Matches(ReasonEnded, otherT.ReasonEnded)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Prescriber, otherT.Prescriber)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(NoteElement, otherT.NoteElement)) return false;
            if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if (!DeepComparable.Matches(DosageInstruction, otherT.DosageInstruction)) return false;
            if (!DeepComparable.Matches(DispenseRequest, otherT.DispenseRequest)) return false;
            if (!DeepComparable.Matches(Substitution, otherT.Substitution)) return false;
            if (!DeepComparable.Matches(PriorPrescription, otherT.PriorPrescription)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationOrder;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(DateWrittenElement, otherT.DateWrittenElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(DateEndedElement, otherT.DateEndedElement)) return false;
            if (!DeepComparable.IsExactly(ReasonEnded, otherT.ReasonEnded)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Prescriber, otherT.Prescriber)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(NoteElement, otherT.NoteElement)) return false;
            if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if (!DeepComparable.IsExactly(DosageInstruction, otherT.DosageInstruction)) return false;
            if (!DeepComparable.IsExactly(DispenseRequest, otherT.DispenseRequest)) return false;
            if (!DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;
            if (!DeepComparable.IsExactly(PriorPrescription, otherT.PriorPrescription)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (DateWrittenElement != null) yield return DateWrittenElement;
                if (StatusElement != null) yield return StatusElement;
                if (DateEndedElement != null) yield return DateEndedElement;
                if (ReasonEnded != null) yield return ReasonEnded;
                if (Patient != null) yield return Patient;
                if (Prescriber != null) yield return Prescriber;
                if (Encounter != null) yield return Encounter;
                if (Reason != null) yield return Reason;
                if (NoteElement != null) yield return NoteElement;
                if (Medication != null) yield return Medication;
                foreach (var elem in DosageInstruction) { if (elem != null) yield return elem; }
                if (DispenseRequest != null) yield return DispenseRequest;
                if (Substitution != null) yield return Substitution;
                if (PriorPrescription != null) yield return PriorPrescription;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (DateWrittenElement != null) yield return new ElementValue("dateWritten", DateWrittenElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (DateEndedElement != null) yield return new ElementValue("dateEnded", DateEndedElement);
                if (ReasonEnded != null) yield return new ElementValue("reasonEnded", ReasonEnded);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Prescriber != null) yield return new ElementValue("prescriber", Prescriber);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Reason != null) yield return new ElementValue("reason", Reason);
                if (NoteElement != null) yield return new ElementValue("note", NoteElement);
                if (Medication != null) yield return new ElementValue("medication", Medication);
                foreach (var elem in DosageInstruction) { if (elem != null) yield return new ElementValue("dosageInstruction", elem); }
                if (DispenseRequest != null) yield return new ElementValue("dispenseRequest", DispenseRequest);
                if (Substitution != null) yield return new ElementValue("substitution", Substitution);
                if (PriorPrescription != null) yield return new ElementValue("priorPrescription", PriorPrescription);
            }
        }

    }

}
