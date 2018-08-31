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
    /// Administration of medication to a patient
    /// </summary>
    [FhirType("MedicationAdministration", IsResource=true)]
    [DataContract]
    public partial class MedicationAdministration : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationAdministration; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationAdministration"; } }


        [FhirType("DosageComponent")]
        [DataContract]
        public partial class DosageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DosageComponent"; } }

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
            /// Body site administered to
            /// </summary>
            [FhirElement("site", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Site
            {
                get { return _site; }
                set { _site = value; OnPropertyChanged("Site"); }
            }

            private Element _site;

            /// <summary>
            /// Path of substance into body
            /// </summary>
            [FhirElement("route", InSummary=true, Order=60)]
            [DataMember]
            public CodeableConcept Route
            {
                get { return _route; }
                set { _route = value; OnPropertyChanged("Route"); }
            }

            private CodeableConcept _route;

            /// <summary>
            /// How drug was administered
            /// </summary>
            [FhirElement("method", InSummary=true, Order=70)]
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
            [FhirElement("quantity", InSummary=true, Order=80)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Dose quantity per unit of time
            /// </summary>
            [FhirElement("rate", InSummary=true, Order=90, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Ratio),typeof(Range))]
            [DataMember]
            public Element Rate
            {
                get { return _rate; }
                set { _rate = value; OnPropertyChanged("Rate"); }
            }

            private Element _rate;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DosageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (Site != null) dest.Site = (Element)Site.DeepCopy();
                    if (Route != null) dest.Route = (CodeableConcept)Route.DeepCopy();
                    if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (Rate != null) dest.Rate = (Element)Rate.DeepCopy();
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
                if (!DeepComparable.Matches(Site, otherT.Site)) return false;
                if (!DeepComparable.Matches(Route, otherT.Route)) return false;
                if (!DeepComparable.Matches(Method, otherT.Method)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(Rate, otherT.Rate)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DosageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(Site, otherT.Site)) return false;
                if (!DeepComparable.IsExactly(Route, otherT.Route)) return false;
                if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(Rate, otherT.Rate)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TextElement != null) yield return TextElement;
                    if (Site != null) yield return Site;
                    if (Route != null) yield return Route;
                    if (Method != null) yield return Method;
                    if (Quantity != null) yield return Quantity;
                    if (Rate != null) yield return Rate;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    if (Site != null) yield return new ElementValue("site", Site);
                    if (Route != null) yield return new ElementValue("route", Route);
                    if (Method != null) yield return new ElementValue("method", Method);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (Rate != null) yield return new ElementValue("rate", Rate);
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
        /// in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MedicationAdministrationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationAdministrationStatus> _statusElement;

        /// <summary>
        /// in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationAdministrationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationAdministrationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Who received medication
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=110)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Who administered substance
        /// </summary>
        [FhirElement("practitioner", InSummary=true, Order=120)]
        [References("Practitioner","Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Practitioner
        {
            get { return _practitioner; }
            set { _practitioner = value; OnPropertyChanged("Practitioner"); }
        }

        private ResourceReference _practitioner;

        /// <summary>
        /// Encounter administered as part of
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=130)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Order administration performed against
        /// </summary>
        [FhirElement("prescription", InSummary=true, Order=140)]
        [References("MedicationOrder")]
        [DataMember]
        public ResourceReference Prescription
        {
            get { return _prescription; }
            set { _prescription = value; OnPropertyChanged("Prescription"); }
        }

        private ResourceReference _prescription;

        /// <summary>
        /// True if medication not administered
        /// </summary>
        [FhirElement("wasNotGiven", InSummary=true, Order=150)]
        [DataMember]
        public FhirBoolean WasNotGivenElement
        {
            get { return _wasNotGivenElement; }
            set { _wasNotGivenElement = value; OnPropertyChanged("WasNotGivenElement"); }
        }

        private FhirBoolean _wasNotGivenElement;

        /// <summary>
        /// True if medication not administered
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? WasNotGiven
        {
            get { return WasNotGivenElement != null ? WasNotGivenElement.Value : null; }
            set
            {
                if (value == null)
                    WasNotGivenElement = null;
                else
                    WasNotGivenElement = new FhirBoolean(value);
                OnPropertyChanged("WasNotGiven");
            }
        }

        /// <summary>
        /// Reason administration not performed
        /// </summary>
        [FhirElement("reasonNotGiven", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonNotGiven
        {
            get { if (_reasonNotGiven==null) _reasonNotGiven = new List<CodeableConcept>(); return _reasonNotGiven; }
            set { _reasonNotGiven = value; OnPropertyChanged("ReasonNotGiven"); }
        }

        private List<CodeableConcept> _reasonNotGiven;

        /// <summary>
        /// Reason administration performed
        /// </summary>
        [FhirElement("reasonGiven", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonGiven
        {
            get { if (_reasonGiven==null) _reasonGiven = new List<CodeableConcept>(); return _reasonGiven; }
            set { _reasonGiven = value; OnPropertyChanged("ReasonGiven"); }
        }

        private List<CodeableConcept> _reasonGiven;

        /// <summary>
        /// Start and end time of administration
        /// </summary>
        [FhirElement("effectiveTime", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element EffectiveTime
        {
            get { return _effectiveTime; }
            set { _effectiveTime = value; OnPropertyChanged("EffectiveTime"); }
        }

        private Element _effectiveTime;

        /// <summary>
        /// What was administered
        /// </summary>
        [FhirElement("medication", InSummary=true, Order=190, Choice=ChoiceType.DatatypeChoice)]
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
        /// Device used to administer
        /// </summary>
        [FhirElement("device", InSummary=true, Order=200)]
        [References("Device")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Device
        {
            get { if (_device==null) _device = new List<ResourceReference>(); return _device; }
            set { _device = value; OnPropertyChanged("Device"); }
        }

        private List<ResourceReference> _device;

        /// <summary>
        /// Information about the administration
        /// </summary>
        [FhirElement("note", InSummary=true, Order=210)]
        [DataMember]
        public FhirString NoteElement
        {
            get { return _noteElement; }
            set { _noteElement = value; OnPropertyChanged("NoteElement"); }
        }

        private FhirString _noteElement;

        /// <summary>
        /// Information about the administration
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
        /// Details of how medication was taken
        /// </summary>
        [FhirElement("dosage", InSummary=true, Order=220)]
        [DataMember]
        public DosageComponent Dosage
        {
            get { return _dosage; }
            set { _dosage = value; OnPropertyChanged("Dosage"); }
        }

        private DosageComponent _dosage;


        public static ElementDefinition.ConstraintComponent MedicationAdministration_MAD_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "reasonGiven.empty() or wasNotGiven = 'false'",
            Key = "mad-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Reason given is only permitted if wasNotGiven is false",
            Xpath = "not(exists(f:reasonGiven) and f:wasNotGiven/@value=true())"
        };

        public static ElementDefinition.ConstraintComponent MedicationAdministration_MAD_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "reasonNotGiven.empty() or wasNotGiven = 'true'",
            Key = "mad-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Reason not given is only permitted if wasNotGiven is true",
            Xpath = "not(exists(f:reasonNotGiven) and f:wasNotGiven/@value=false())"
        };

        public static ElementDefinition.ConstraintComponent MedicationAdministration_MAD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "dosage.all(quantity or rate)",
            Key = "mad-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "SHALL have at least one of dosage.quantity and dosage.rate[x]",
            Xpath = "exists(f:quantity) or exists(f:rateRatio) or exists(f:rateRange)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(MedicationAdministration_MAD_3);
            InvariantConstraints.Add(MedicationAdministration_MAD_2);
            InvariantConstraints.Add(MedicationAdministration_MAD_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationAdministration;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<MedicationAdministrationStatus>)StatusElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Practitioner != null) dest.Practitioner = (ResourceReference)Practitioner.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Prescription != null) dest.Prescription = (ResourceReference)Prescription.DeepCopy();
                if (WasNotGivenElement != null) dest.WasNotGivenElement = (FhirBoolean)WasNotGivenElement.DeepCopy();
                if (ReasonNotGiven != null) dest.ReasonNotGiven = new List<CodeableConcept>(ReasonNotGiven.DeepCopy());
                if (ReasonGiven != null) dest.ReasonGiven = new List<CodeableConcept>(ReasonGiven.DeepCopy());
                if (EffectiveTime != null) dest.EffectiveTime = (Element)EffectiveTime.DeepCopy();
                if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                if (Device != null) dest.Device = new List<ResourceReference>(Device.DeepCopy());
                if (NoteElement != null) dest.NoteElement = (FhirString)NoteElement.DeepCopy();
                if (Dosage != null) dest.Dosage = (DosageComponent)Dosage.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationAdministration());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationAdministration;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Practitioner, otherT.Practitioner)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Prescription, otherT.Prescription)) return false;
            if (!DeepComparable.Matches(WasNotGivenElement, otherT.WasNotGivenElement)) return false;
            if ( !DeepComparable.Matches(ReasonNotGiven, otherT.ReasonNotGiven)) return false;
            if ( !DeepComparable.Matches(ReasonGiven, otherT.ReasonGiven)) return false;
            if (!DeepComparable.Matches(EffectiveTime, otherT.EffectiveTime)) return false;
            if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if ( !DeepComparable.Matches(Device, otherT.Device)) return false;
            if (!DeepComparable.Matches(NoteElement, otherT.NoteElement)) return false;
            if (!DeepComparable.Matches(Dosage, otherT.Dosage)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationAdministration;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Practitioner, otherT.Practitioner)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Prescription, otherT.Prescription)) return false;
            if (!DeepComparable.IsExactly(WasNotGivenElement, otherT.WasNotGivenElement)) return false;
            if (!DeepComparable.IsExactly(ReasonNotGiven, otherT.ReasonNotGiven)) return false;
            if (!DeepComparable.IsExactly(ReasonGiven, otherT.ReasonGiven)) return false;
            if (!DeepComparable.IsExactly(EffectiveTime, otherT.EffectiveTime)) return false;
            if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if (!DeepComparable.IsExactly(NoteElement, otherT.NoteElement)) return false;
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
                if (StatusElement != null) yield return StatusElement;
                if (Patient != null) yield return Patient;
                if (Practitioner != null) yield return Practitioner;
                if (Encounter != null) yield return Encounter;
                if (Prescription != null) yield return Prescription;
                if (WasNotGivenElement != null) yield return WasNotGivenElement;
                foreach (var elem in ReasonNotGiven) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonGiven) { if (elem != null) yield return elem; }
                if (EffectiveTime != null) yield return EffectiveTime;
                if (Medication != null) yield return Medication;
                foreach (var elem in Device) { if (elem != null) yield return elem; }
                if (NoteElement != null) yield return NoteElement;
                if (Dosage != null) yield return Dosage;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Practitioner != null) yield return new ElementValue("practitioner", Practitioner);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Prescription != null) yield return new ElementValue("prescription", Prescription);
                if (WasNotGivenElement != null) yield return new ElementValue("wasNotGiven", WasNotGivenElement);
                foreach (var elem in ReasonNotGiven) { if (elem != null) yield return new ElementValue("reasonNotGiven", elem); }
                foreach (var elem in ReasonGiven) { if (elem != null) yield return new ElementValue("reasonGiven", elem); }
                if (EffectiveTime != null) yield return new ElementValue("effectiveTime", EffectiveTime);
                if (Medication != null) yield return new ElementValue("medication", Medication);
                foreach (var elem in Device) { if (elem != null) yield return new ElementValue("device", elem); }
                if (NoteElement != null) yield return new ElementValue("note", NoteElement);
                if (Dosage != null) yield return new ElementValue("dosage", Dosage);
            }
        }

    }

}
