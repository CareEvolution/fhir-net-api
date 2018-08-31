using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
    /// Dispensing a medication to a named patient
    /// </summary>
    [FhirType("MedicationDispense", IsResource=true)]
    [DataContract]
    public partial class MedicationDispense : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationDispense; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationDispense"; } }

        /// <summary>
        /// A code specifying the state of the dispense event.<br/>
        /// <br/>
        /// Describes the lifecycle of the dispense.
        /// (url: http://hl7.org/fhir/ValueSet/medication-dispense-status)
        /// </summary>
        [FhirEnumeration("MedicationDispenseStatus")]
        public enum MedicationDispenseStatus
        {
            /// <summary>
            /// The dispense has started but has not yet completed.
            /// (system: http://hl7.org/fhir/medication-dispense-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/medication-dispense-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// Actions implied by the administration have been temporarily halted, but are expected to continue later. May also be called "suspended"
            /// (system: http://hl7.org/fhir/medication-dispense-status)
            /// </summary>
            [EnumLiteral("on-hold", "http://hl7.org/fhir/medication-dispense-status"), Description("On Hold")]
            OnHold,
            /// <summary>
            /// All actions that are implied by the dispense have occurred.
            /// (system: http://hl7.org/fhir/medication-dispense-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/medication-dispense-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The dispense was entered in error and therefore nullified.
            /// (system: http://hl7.org/fhir/medication-dispense-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/medication-dispense-status"), Description("Entered in-Error")]
            EnteredInError,
            /// <summary>
            /// Actions implied by the dispense have been permanently halted, before all of them occurred.
            /// (system: http://hl7.org/fhir/medication-dispense-status)
            /// </summary>
            [EnumLiteral("stopped", "http://hl7.org/fhir/medication-dispense-status"), Description("Stopped")]
            Stopped,
        }


        [FhirType("DosageInstructionComponent")]
        [DataContract]
        public partial class DosageInstructionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DosageInstructionComponent"; } }

            /// <summary>
            /// Dosage Instructions
            /// </summary>
            [FhirElement("text", InSummary=true, Order=40)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Dosage Instructions
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
            /// E.g. "Take with food"
            /// </summary>
            [FhirElement("additionalInstructions", InSummary=true, Order=50)]
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
            [FhirElement("timing", InSummary=true, Order=60)]
            [DataMember]
            public Timing Timing
            {
                get { return _timing; }
                set { _timing = value; OnPropertyChanged("Timing"); }
            }

            private Timing _timing;

            /// <summary>
            /// Take "as needed" f(or x)
            /// </summary>
            [FhirElement("asNeeded", InSummary=true, Order=70, Choice=ChoiceType.DatatypeChoice)]
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
            [FhirElement("site", InSummary=true, Order=80, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
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
            [FhirElement("route", InSummary=true, Order=90)]
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
            [FhirElement("method", InSummary=true, Order=100)]
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
            [FhirElement("dose", InSummary=true, Order=110, Choice=ChoiceType.DatatypeChoice)]
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
            [FhirElement("rate", InSummary=true, Order=120, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Ratio),typeof(Range))]
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
            [FhirElement("maxDosePerPeriod", InSummary=true, Order=130)]
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


        [FhirType("SubstitutionComponent")]
        [DataContract]
        public partial class SubstitutionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubstitutionComponent"; } }

            /// <summary>
            /// Type of substitution
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
            /// Why was substitution made
            /// </summary>
            [FhirElement("reason", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Reason
            {
                get { if (_reason==null) _reason = new List<CodeableConcept>(); return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private List<CodeableConcept> _reason;

            /// <summary>
            /// Who is responsible for the substitution
            /// </summary>
            [FhirElement("responsibleParty", InSummary=true, Order=60)]
            [References("Practitioner")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> ResponsibleParty
            {
                get { if (_responsibleParty==null) _responsibleParty = new List<ResourceReference>(); return _responsibleParty; }
                set { _responsibleParty = value; OnPropertyChanged("ResponsibleParty"); }
            }

            private List<ResourceReference> _responsibleParty;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstitutionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                    if (ResponsibleParty != null) dest.ResponsibleParty = new List<ResourceReference>(ResponsibleParty.DeepCopy());
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
                if ( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if ( !DeepComparable.Matches(ResponsibleParty, otherT.ResponsibleParty)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if (!DeepComparable.IsExactly(ResponsibleParty, otherT.ResponsibleParty)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Reason) { if (elem != null) yield return elem; }
                    foreach (var elem in ResponsibleParty) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                    foreach (var elem in ResponsibleParty) { if (elem != null) yield return new ElementValue("responsibleParty", elem); }
                }
            }


        }


        /// <summary>
        /// External identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<MedicationDispenseStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationDispenseStatus> _statusElement;

        /// <summary>
        /// in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationDispenseStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationDispenseStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Who the dispense is for
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=110)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Practitioner responsible for dispensing medication
        /// </summary>
        [FhirElement("dispenser", InSummary=true, Order=120)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Dispenser
        {
            get { return _dispenser; }
            set { _dispenser = value; OnPropertyChanged("Dispenser"); }
        }

        private ResourceReference _dispenser;

        /// <summary>
        /// Medication order that authorizes the dispense
        /// </summary>
        [FhirElement("authorizingPrescription", InSummary=true, Order=130)]
        [References("MedicationOrder")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> AuthorizingPrescription
        {
            get { if (_authorizingPrescription==null) _authorizingPrescription = new List<ResourceReference>(); return _authorizingPrescription; }
            set { _authorizingPrescription = value; OnPropertyChanged("AuthorizingPrescription"); }
        }

        private List<ResourceReference> _authorizingPrescription;

        /// <summary>
        /// Trial fill, partial fill, emergency fill, etc.
        /// </summary>
        [FhirElement("type", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Amount dispensed
        /// </summary>
        [FhirElement("quantity", InSummary=true, Order=150)]
        [DataMember]
        public SimpleQuantity Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged("Quantity"); }
        }

        private SimpleQuantity _quantity;

        /// <summary>
        /// Days Supply
        /// </summary>
        [FhirElement("daysSupply", InSummary=true, Order=160)]
        [DataMember]
        public SimpleQuantity DaysSupply
        {
            get { return _daysSupply; }
            set { _daysSupply = value; OnPropertyChanged("DaysSupply"); }
        }

        private SimpleQuantity _daysSupply;

        /// <summary>
        /// What medication was supplied
        /// </summary>
        [FhirElement("medication", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Medication
        {
            get { return _medication; }
            set { _medication = value; OnPropertyChanged("Medication"); }
        }

        private Element _medication;

        /// <summary>
        /// Dispense processing time
        /// </summary>
        [FhirElement("whenPrepared", InSummary=true, Order=180)]
        [DataMember]
        public FhirDateTime WhenPreparedElement
        {
            get { return _whenPreparedElement; }
            set { _whenPreparedElement = value; OnPropertyChanged("WhenPreparedElement"); }
        }

        private FhirDateTime _whenPreparedElement;

        /// <summary>
        /// Dispense processing time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string WhenPrepared
        {
            get { return WhenPreparedElement != null ? WhenPreparedElement.Value : null; }
            set
            {
                if (value == null)
                    WhenPreparedElement = null;
                else
                    WhenPreparedElement = new FhirDateTime(value);
                OnPropertyChanged("WhenPrepared");
            }
        }

        /// <summary>
        /// When product was given out
        /// </summary>
        [FhirElement("whenHandedOver", InSummary=true, Order=190)]
        [DataMember]
        public FhirDateTime WhenHandedOverElement
        {
            get { return _whenHandedOverElement; }
            set { _whenHandedOverElement = value; OnPropertyChanged("WhenHandedOverElement"); }
        }

        private FhirDateTime _whenHandedOverElement;

        /// <summary>
        /// When product was given out
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string WhenHandedOver
        {
            get { return WhenHandedOverElement != null ? WhenHandedOverElement.Value : null; }
            set
            {
                if (value == null)
                    WhenHandedOverElement = null;
                else
                    WhenHandedOverElement = new FhirDateTime(value);
                OnPropertyChanged("WhenHandedOver");
            }
        }

        /// <summary>
        /// Where the medication was sent
        /// </summary>
        [FhirElement("destination", InSummary=true, Order=200)]
        [References("Location")]
        [DataMember]
        public ResourceReference Destination
        {
            get { return _destination; }
            set { _destination = value; OnPropertyChanged("Destination"); }
        }

        private ResourceReference _destination;

        /// <summary>
        /// Who collected the medication
        /// </summary>
        [FhirElement("receiver", InSummary=true, Order=210)]
        [References("Patient","Practitioner")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Receiver
        {
            get { if (_receiver==null) _receiver = new List<ResourceReference>(); return _receiver; }
            set { _receiver = value; OnPropertyChanged("Receiver"); }
        }

        private List<ResourceReference> _receiver;

        /// <summary>
        /// Information about the dispense
        /// </summary>
        [FhirElement("note", InSummary=true, Order=220)]
        [DataMember]
        public FhirString NoteElement
        {
            get { return _noteElement; }
            set { _noteElement = value; OnPropertyChanged("NoteElement"); }
        }

        private FhirString _noteElement;

        /// <summary>
        /// Information about the dispense
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
        /// Medicine administration instructions to the patient/caregiver
        /// </summary>
        [FhirElement("dosageInstruction", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DosageInstructionComponent> DosageInstruction
        {
            get { if (_dosageInstruction==null) _dosageInstruction = new List<DosageInstructionComponent>(); return _dosageInstruction; }
            set { _dosageInstruction = value; OnPropertyChanged("DosageInstruction"); }
        }

        private List<DosageInstructionComponent> _dosageInstruction;

        /// <summary>
        /// Deals with substitution of one medicine for another
        /// </summary>
        [FhirElement("substitution", InSummary=true, Order=240)]
        [DataMember]
        public SubstitutionComponent Substitution
        {
            get { return _substitution; }
            set { _substitution = value; OnPropertyChanged("Substitution"); }
        }

        private SubstitutionComponent _substitution;


        public static ElementDefinition.ConstraintComponent MedicationDispense_MDD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "whenHandedOver.empty() or whenPrepared.empty() or whenHandedOver >= whenPrepared",
            Key = "mdd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "whenHandedOver cannot be before whenPrepared",
            Xpath = "not(exists(f:whenHandedOver/@value)) or not(exists(f:whenPrepared/@value)) or ( f:whenHandedOver/@value >= f:whenPrepared/@value)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(MedicationDispense_MDD_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationDispense;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<MedicationDispenseStatus>)StatusElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Dispenser != null) dest.Dispenser = (ResourceReference)Dispenser.DeepCopy();
                if (AuthorizingPrescription != null) dest.AuthorizingPrescription = new List<ResourceReference>(AuthorizingPrescription.DeepCopy());
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                if (DaysSupply != null) dest.DaysSupply = (SimpleQuantity)DaysSupply.DeepCopy();
                if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                if (WhenPreparedElement != null) dest.WhenPreparedElement = (FhirDateTime)WhenPreparedElement.DeepCopy();
                if (WhenHandedOverElement != null) dest.WhenHandedOverElement = (FhirDateTime)WhenHandedOverElement.DeepCopy();
                if (Destination != null) dest.Destination = (ResourceReference)Destination.DeepCopy();
                if (Receiver != null) dest.Receiver = new List<ResourceReference>(Receiver.DeepCopy());
                if (NoteElement != null) dest.NoteElement = (FhirString)NoteElement.DeepCopy();
                if (DosageInstruction != null) dest.DosageInstruction = new List<DosageInstructionComponent>(DosageInstruction.DeepCopy());
                if (Substitution != null) dest.Substitution = (SubstitutionComponent)Substitution.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationDispense());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationDispense;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Dispenser, otherT.Dispenser)) return false;
            if ( !DeepComparable.Matches(AuthorizingPrescription, otherT.AuthorizingPrescription)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.Matches(DaysSupply, otherT.DaysSupply)) return false;
            if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if (!DeepComparable.Matches(WhenPreparedElement, otherT.WhenPreparedElement)) return false;
            if (!DeepComparable.Matches(WhenHandedOverElement, otherT.WhenHandedOverElement)) return false;
            if (!DeepComparable.Matches(Destination, otherT.Destination)) return false;
            if ( !DeepComparable.Matches(Receiver, otherT.Receiver)) return false;
            if (!DeepComparable.Matches(NoteElement, otherT.NoteElement)) return false;
            if ( !DeepComparable.Matches(DosageInstruction, otherT.DosageInstruction)) return false;
            if (!DeepComparable.Matches(Substitution, otherT.Substitution)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationDispense;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Dispenser, otherT.Dispenser)) return false;
            if (!DeepComparable.IsExactly(AuthorizingPrescription, otherT.AuthorizingPrescription)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.IsExactly(DaysSupply, otherT.DaysSupply)) return false;
            if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if (!DeepComparable.IsExactly(WhenPreparedElement, otherT.WhenPreparedElement)) return false;
            if (!DeepComparable.IsExactly(WhenHandedOverElement, otherT.WhenHandedOverElement)) return false;
            if (!DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
            if (!DeepComparable.IsExactly(Receiver, otherT.Receiver)) return false;
            if (!DeepComparable.IsExactly(NoteElement, otherT.NoteElement)) return false;
            if (!DeepComparable.IsExactly(DosageInstruction, otherT.DosageInstruction)) return false;
            if (!DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (StatusElement != null) yield return StatusElement;
                if (Patient != null) yield return Patient;
                if (Dispenser != null) yield return Dispenser;
                foreach (var elem in AuthorizingPrescription) { if (elem != null) yield return elem; }
                if (Type != null) yield return Type;
                if (Quantity != null) yield return Quantity;
                if (DaysSupply != null) yield return DaysSupply;
                if (Medication != null) yield return Medication;
                if (WhenPreparedElement != null) yield return WhenPreparedElement;
                if (WhenHandedOverElement != null) yield return WhenHandedOverElement;
                if (Destination != null) yield return Destination;
                foreach (var elem in Receiver) { if (elem != null) yield return elem; }
                if (NoteElement != null) yield return NoteElement;
                foreach (var elem in DosageInstruction) { if (elem != null) yield return elem; }
                if (Substitution != null) yield return Substitution;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Dispenser != null) yield return new ElementValue("dispenser", Dispenser);
                foreach (var elem in AuthorizingPrescription) { if (elem != null) yield return new ElementValue("authorizingPrescription", elem); }
                if (Type != null) yield return new ElementValue("type", Type);
                if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                if (DaysSupply != null) yield return new ElementValue("daysSupply", DaysSupply);
                if (Medication != null) yield return new ElementValue("medication", Medication);
                if (WhenPreparedElement != null) yield return new ElementValue("whenPrepared", WhenPreparedElement);
                if (WhenHandedOverElement != null) yield return new ElementValue("whenHandedOver", WhenHandedOverElement);
                if (Destination != null) yield return new ElementValue("destination", Destination);
                foreach (var elem in Receiver) { if (elem != null) yield return new ElementValue("receiver", elem); }
                if (NoteElement != null) yield return new ElementValue("note", NoteElement);
                foreach (var elem in DosageInstruction) { if (elem != null) yield return new ElementValue("dosageInstruction", elem); }
                if (Substitution != null) yield return new ElementValue("substitution", Substitution);
            }
        }

    }

}
