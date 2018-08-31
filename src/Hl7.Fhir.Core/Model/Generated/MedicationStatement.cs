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
    /// Record of medication being taken by a patient
    /// </summary>
    [FhirType("MedicationStatement", IsResource=true)]
    [DataContract]
    public partial class MedicationStatement : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationStatement; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationStatement"; } }

        /// <summary>
        /// A set of codes indicating the current status of a MedicationStatement.
        /// (url: http://hl7.org/fhir/ValueSet/medication-statement-status)
        /// </summary>
        [FhirEnumeration("MedicationStatementStatus")]
        public enum MedicationStatementStatus
        {
            /// <summary>
            /// The medication is still being taken.
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/medication-statement-status"), Description("Active")]
            Active,
            /// <summary>
            /// The medication is no longer being taken.
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/medication-statement-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The statement was entered in error.
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/medication-statement-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// The medication may be taken at some time in the future.
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("intended", "http://hl7.org/fhir/medication-statement-status"), Description("Intended")]
            Intended,
        }


        [FhirType("DosageComponent")]
        [DataContract]
        public partial class DosageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DosageComponent"; } }

            /// <summary>
            /// Reported dosage information
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
            /// Reported dosage information
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
            /// When/how often was medication taken
            /// </summary>
            [FhirElement("timing", InSummary=true, Order=50)]
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
            [FhirElement("asNeeded", InSummary=true, Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(CodeableConcept))]
            [DataMember]
            public Element AsNeeded
            {
                get { return _asNeeded; }
                set { _asNeeded = value; OnPropertyChanged("AsNeeded"); }
            }

            private Element _asNeeded;

            /// <summary>
            /// Where (on body) medication is/was administered
            /// </summary>
            [FhirElement("site", InSummary=true, Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Site
            {
                get { return _site; }
                set { _site = value; OnPropertyChanged("Site"); }
            }

            private Element _site;

            /// <summary>
            /// How the medication entered the body
            /// </summary>
            [FhirElement("route", InSummary=true, Order=80)]
            [DataMember]
            public CodeableConcept Route
            {
                get { return _route; }
                set { _route = value; OnPropertyChanged("Route"); }
            }

            private CodeableConcept _route;

            /// <summary>
            /// Technique used to administer medication
            /// </summary>
            [FhirElement("method", InSummary=true, Order=90)]
            [DataMember]
            public CodeableConcept Method
            {
                get { return _method; }
                set { _method = value; OnPropertyChanged("Method"); }
            }

            private CodeableConcept _method;

            /// <summary>
            /// Amount administered in one dose
            /// </summary>
            [FhirElement("quantity", InSummary=true, Order=100, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(SimpleQuantity),typeof(Range))]
            [DataMember]
            public Element Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private Element _quantity;

            /// <summary>
            /// Dose quantity per unit of time
            /// </summary>
            [FhirElement("rate", InSummary=true, Order=110, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Ratio),typeof(Range))]
            [DataMember]
            public Element Rate
            {
                get { return _rate; }
                set { _rate = value; OnPropertyChanged("Rate"); }
            }

            private Element _rate;

            /// <summary>
            /// Maximum dose that was consumed per unit of time
            /// </summary>
            [FhirElement("maxDosePerPeriod", InSummary=true, Order=120)]
            [DataMember]
            public Ratio MaxDosePerPeriod
            {
                get { return _maxDosePerPeriod; }
                set { _maxDosePerPeriod = value; OnPropertyChanged("MaxDosePerPeriod"); }
            }

            private Ratio _maxDosePerPeriod;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DosageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (Timing != null) dest.Timing = (Timing)Timing.DeepCopy();
                    if (AsNeeded != null) dest.AsNeeded = (Element)AsNeeded.DeepCopy();
                    if (Site != null) dest.Site = (Element)Site.DeepCopy();
                    if (Route != null) dest.Route = (CodeableConcept)Route.DeepCopy();
                    if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                    if (Quantity != null) dest.Quantity = (Element)Quantity.DeepCopy();
                    if (Rate != null) dest.Rate = (Element)Rate.DeepCopy();
                    if (MaxDosePerPeriod != null) dest.MaxDosePerPeriod = (Ratio)MaxDosePerPeriod.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DosageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DosageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
                if (!DeepComparable.Matches(AsNeeded, otherT.AsNeeded)) return false;
                if (!DeepComparable.Matches(Site, otherT.Site)) return false;
                if (!DeepComparable.Matches(Route, otherT.Route)) return false;
                if (!DeepComparable.Matches(Method, otherT.Method)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(Rate, otherT.Rate)) return false;
                if (!DeepComparable.Matches(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DosageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
                if (!DeepComparable.IsExactly(AsNeeded, otherT.AsNeeded)) return false;
                if (!DeepComparable.IsExactly(Site, otherT.Site)) return false;
                if (!DeepComparable.IsExactly(Route, otherT.Route)) return false;
                if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
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
                    if (Timing != null) yield return Timing;
                    if (AsNeeded != null) yield return AsNeeded;
                    if (Site != null) yield return Site;
                    if (Route != null) yield return Route;
                    if (Method != null) yield return Method;
                    if (Quantity != null) yield return Quantity;
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
                    if (Timing != null) yield return new ElementValue("timing", Timing);
                    if (AsNeeded != null) yield return new ElementValue("asNeeded", AsNeeded);
                    if (Site != null) yield return new ElementValue("site", Site);
                    if (Route != null) yield return new ElementValue("route", Route);
                    if (Method != null) yield return new ElementValue("method", Method);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (Rate != null) yield return new ElementValue("rate", Rate);
                    if (MaxDosePerPeriod != null) yield return new ElementValue("maxDosePerPeriod", MaxDosePerPeriod);
                }
            }


        }


        /// <summary>
        /// External identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Who is/was taking  the medication
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=100)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        [FhirElement("informationSource", InSummary=true, Order=110)]
        [References("Patient","Practitioner","RelatedPerson")]
        [DataMember]
        public ResourceReference InformationSource
        {
            get { return _informationSource; }
            set { _informationSource = value; OnPropertyChanged("InformationSource"); }
        }

        private ResourceReference _informationSource;

        /// <summary>
        /// When the statement was asserted?
        /// </summary>
        [FhirElement("dateAsserted", InSummary=true, Order=120)]
        [DataMember]
        public FhirDateTime DateAssertedElement
        {
            get { return _dateAssertedElement; }
            set { _dateAssertedElement = value; OnPropertyChanged("DateAssertedElement"); }
        }

        private FhirDateTime _dateAssertedElement;

        /// <summary>
        /// When the statement was asserted?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateAsserted
        {
            get { return DateAssertedElement != null ? DateAssertedElement.Value : null; }
            set
            {
                if (value == null)
                    DateAssertedElement = null;
                else
                    DateAssertedElement = new FhirDateTime(value);
                OnPropertyChanged("DateAsserted");
            }
        }

        /// <summary>
        /// active | completed | entered-in-error | intended
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MedicationStatementStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationStatementStatus> _statusElement;

        /// <summary>
        /// active | completed | entered-in-error | intended
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationStatementStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationStatementStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// True if medication is/was not being taken
        /// </summary>
        [FhirElement("wasNotTaken", InSummary=true, Order=140)]
        [DataMember]
        public FhirBoolean WasNotTakenElement
        {
            get { return _wasNotTakenElement; }
            set { _wasNotTakenElement = value; OnPropertyChanged("WasNotTakenElement"); }
        }

        private FhirBoolean _wasNotTakenElement;

        /// <summary>
        /// True if medication is/was not being taken
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? WasNotTaken
        {
            get { return WasNotTakenElement != null ? WasNotTakenElement.Value : null; }
            set
            {
                if (value == null)
                    WasNotTakenElement = null;
                else
                    WasNotTakenElement = new FhirBoolean(value);
                OnPropertyChanged("WasNotTaken");
            }
        }

        /// <summary>
        /// True if asserting medication was not given
        /// </summary>
        [FhirElement("reasonNotTaken", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonNotTaken
        {
            get { if (_reasonNotTaken==null) _reasonNotTaken = new List<CodeableConcept>(); return _reasonNotTaken; }
            set { _reasonNotTaken = value; OnPropertyChanged("ReasonNotTaken"); }
        }

        private List<CodeableConcept> _reasonNotTaken;

        [FhirElement("reasonForUse", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element ReasonForUse
        {
            get { return _reasonForUse; }
            set { _reasonForUse = value; OnPropertyChanged("ReasonForUse"); }
        }

        private Element _reasonForUse;

        /// <summary>
        /// Over what period was medication consumed?
        /// </summary>
        [FhirElement("effective", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [DataMember]
        public Element Effective
        {
            get { return _effective; }
            set { _effective = value; OnPropertyChanged("Effective"); }
        }

        private Element _effective;

        /// <summary>
        /// Further information about the statement
        /// </summary>
        [FhirElement("note", InSummary=true, Order=180)]
        [DataMember]
        public FhirString NoteElement
        {
            get { return _noteElement; }
            set { _noteElement = value; OnPropertyChanged("NoteElement"); }
        }

        private FhirString _noteElement;

        /// <summary>
        /// Further information about the statement
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
        /// Additional supporting information
        /// </summary>
        [FhirElement("supportingInformation", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInformation
        {
            get { if (_supportingInformation==null) _supportingInformation = new List<ResourceReference>(); return _supportingInformation; }
            set { _supportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }

        private List<ResourceReference> _supportingInformation;

        /// <summary>
        /// What medication was taken
        /// </summary>
        [FhirElement("medication", InSummary=true, Order=200, Choice=ChoiceType.DatatypeChoice)]
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
        /// Details of how medication was taken
        /// </summary>
        [FhirElement("dosage", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DosageComponent> Dosage
        {
            get { if (_dosage==null) _dosage = new List<DosageComponent>(); return _dosage; }
            set { _dosage = value; OnPropertyChanged("Dosage"); }
        }

        private List<DosageComponent> _dosage;


        public static ElementDefinition.ConstraintComponent MedicationStatement_MST_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "reasonForUse.empty() or wasNotTaken = false",
            Key = "mst-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Reason for use is only permitted if wasNotTaken is false",
            Xpath = "not(exists(*[starts-with(local-name(.), 'reasonForUse')]) and f:wasNotTaken/@value=true())"
        };

        public static ElementDefinition.ConstraintComponent MedicationStatement_MST_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "reasonNotTaken.empty() or wasNotTaken = true",
            Key = "mst-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Reason not taken is only permitted if wasNotTaken is true",
            Xpath = "not(exists(f:reasonNotTaken) and f:wasNotTaken/@value=false())"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(MedicationStatement_MST_2);
            InvariantConstraints.Add(MedicationStatement_MST_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationStatement;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (InformationSource != null) dest.InformationSource = (ResourceReference)InformationSource.DeepCopy();
                if (DateAssertedElement != null) dest.DateAssertedElement = (FhirDateTime)DateAssertedElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<MedicationStatementStatus>)StatusElement.DeepCopy();
                if (WasNotTakenElement != null) dest.WasNotTakenElement = (FhirBoolean)WasNotTakenElement.DeepCopy();
                if (ReasonNotTaken != null) dest.ReasonNotTaken = new List<CodeableConcept>(ReasonNotTaken.DeepCopy());
                if (ReasonForUse != null) dest.ReasonForUse = (Element)ReasonForUse.DeepCopy();
                if (Effective != null) dest.Effective = (Element)Effective.DeepCopy();
                if (NoteElement != null) dest.NoteElement = (FhirString)NoteElement.DeepCopy();
                if (SupportingInformation != null) dest.SupportingInformation = new List<ResourceReference>(SupportingInformation.DeepCopy());
                if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                if (Dosage != null) dest.Dosage = new List<DosageComponent>(Dosage.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationStatement());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationStatement;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(InformationSource, otherT.InformationSource)) return false;
            if (!DeepComparable.Matches(DateAssertedElement, otherT.DateAssertedElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(WasNotTakenElement, otherT.WasNotTakenElement)) return false;
            if ( !DeepComparable.Matches(ReasonNotTaken, otherT.ReasonNotTaken)) return false;
            if (!DeepComparable.Matches(ReasonForUse, otherT.ReasonForUse)) return false;
            if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;
            if (!DeepComparable.Matches(NoteElement, otherT.NoteElement)) return false;
            if ( !DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if ( !DeepComparable.Matches(Dosage, otherT.Dosage)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationStatement;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(InformationSource, otherT.InformationSource)) return false;
            if (!DeepComparable.IsExactly(DateAssertedElement, otherT.DateAssertedElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(WasNotTakenElement, otherT.WasNotTakenElement)) return false;
            if (!DeepComparable.IsExactly(ReasonNotTaken, otherT.ReasonNotTaken)) return false;
            if (!DeepComparable.IsExactly(ReasonForUse, otherT.ReasonForUse)) return false;
            if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
            if (!DeepComparable.IsExactly(NoteElement, otherT.NoteElement)) return false;
            if (!DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if (!DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
                if (InformationSource != null) yield return InformationSource;
                if (DateAssertedElement != null) yield return DateAssertedElement;
                if (StatusElement != null) yield return StatusElement;
                if (WasNotTakenElement != null) yield return WasNotTakenElement;
                foreach (var elem in ReasonNotTaken) { if (elem != null) yield return elem; }
                if (ReasonForUse != null) yield return ReasonForUse;
                if (Effective != null) yield return Effective;
                if (NoteElement != null) yield return NoteElement;
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
                if (Medication != null) yield return Medication;
                foreach (var elem in Dosage) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (InformationSource != null) yield return new ElementValue("informationSource", InformationSource);
                if (DateAssertedElement != null) yield return new ElementValue("dateAsserted", DateAssertedElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (WasNotTakenElement != null) yield return new ElementValue("wasNotTaken", WasNotTakenElement);
                foreach (var elem in ReasonNotTaken) { if (elem != null) yield return new ElementValue("reasonNotTaken", elem); }
                if (ReasonForUse != null) yield return new ElementValue("reasonForUse", ReasonForUse);
                if (Effective != null) yield return new ElementValue("effective", Effective);
                if (NoteElement != null) yield return new ElementValue("note", NoteElement);
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", elem); }
                if (Medication != null) yield return new ElementValue("medication", Medication);
                foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", elem); }
            }
        }

    }

}
