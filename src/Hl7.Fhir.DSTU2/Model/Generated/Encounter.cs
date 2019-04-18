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
    /// An interaction during which services are provided to the patient
    /// </summary>
    [FhirType("Encounter", IsResource = true)]
    [DataContract]
    public partial class Encounter : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Encounter; } }
        [NotMapped]
        public override string TypeName { get { return "Encounter"; } }

        /// <summary>
        /// Current state of the encounter
        /// (url: http://hl7.org/fhir/ValueSet/encounter-state)
        /// </summary>
        [FhirEnumeration("EncounterState")]
        public enum EncounterState
        {
            /// <summary>
            /// The Encounter has not yet started.
            /// (system: http://hl7.org/fhir/encounter-state)
            /// </summary>
            [EnumLiteral("planned", "http://hl7.org/fhir/encounter-state"), Description("Planned")]
            Planned,
            /// <summary>
            /// The Patient is present for the encounter, however is not currently meeting with a practitioner.
            /// (system: http://hl7.org/fhir/encounter-state)
            /// </summary>
            [EnumLiteral("arrived", "http://hl7.org/fhir/encounter-state"), Description("Arrived")]
            Arrived,
            /// <summary>
            /// The Encounter has begun and the patient is present / the practitioner and the patient are meeting.
            /// (system: http://hl7.org/fhir/encounter-state)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/encounter-state"), Description("in Progress")]
            InProgress,
            /// <summary>
            /// The Encounter has begun, but the patient is temporarily on leave.
            /// (system: http://hl7.org/fhir/encounter-state)
            /// </summary>
            [EnumLiteral("onleave", "http://hl7.org/fhir/encounter-state"), Description("On Leave")]
            Onleave,
            /// <summary>
            /// The Encounter has ended.
            /// (system: http://hl7.org/fhir/encounter-state)
            /// </summary>
            [EnumLiteral("finished", "http://hl7.org/fhir/encounter-state"), Description("Finished")]
            Finished,
            /// <summary>
            /// The Encounter has ended before it has begun.
            /// (system: http://hl7.org/fhir/encounter-state)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/encounter-state"), Description("Cancelled")]
            Cancelled,
        }

        /// <summary>
        /// Classification of the encounter
        /// (url: http://hl7.org/fhir/ValueSet/encounter-class)
        /// </summary>
        [FhirEnumeration("EncounterClass")]
        public enum EncounterClass
        {
            /// <summary>
            /// An encounter during which the patient is hospitalized and stays overnight.
            /// (system: http://hl7.org/fhir/encounter-class)
            /// </summary>
            [EnumLiteral("inpatient", "http://hl7.org/fhir/encounter-class"), Description("Inpatient")]
            Inpatient,
            /// <summary>
            /// An encounter during which the patient is not hospitalized overnight.
            /// (system: http://hl7.org/fhir/encounter-class)
            /// </summary>
            [EnumLiteral("outpatient", "http://hl7.org/fhir/encounter-class"), Description("Outpatient")]
            Outpatient,
            /// <summary>
            /// An encounter where the patient visits the practitioner in his/her office, e.g. a G.P. visit.
            /// (system: http://hl7.org/fhir/encounter-class)
            /// </summary>
            [EnumLiteral("ambulatory", "http://hl7.org/fhir/encounter-class"), Description("Ambulatory")]
            Ambulatory,
            /// <summary>
            /// An encounter in the Emergency Care Department.
            /// (system: http://hl7.org/fhir/encounter-class)
            /// </summary>
            [EnumLiteral("emergency", "http://hl7.org/fhir/encounter-class"), Description("Emergency")]
            Emergency,
            /// <summary>
            /// An encounter where the practitioner visits the patient at his/her home.
            /// (system: http://hl7.org/fhir/encounter-class)
            /// </summary>
            [EnumLiteral("home", "http://hl7.org/fhir/encounter-class"), Description("Home")]
            Home,
            /// <summary>
            /// An encounter taking place outside the regular environment for giving care.
            /// (system: http://hl7.org/fhir/encounter-class)
            /// </summary>
            [EnumLiteral("field", "http://hl7.org/fhir/encounter-class"), Description("Field")]
            Field,
            /// <summary>
            /// An encounter where the patient needs more prolonged treatment or investigations than outpatients, but who do not need to stay in the hospital overnight.
            /// (system: http://hl7.org/fhir/encounter-class)
            /// </summary>
            [EnumLiteral("daytime", "http://hl7.org/fhir/encounter-class"), Description("Daytime")]
            Daytime,
            /// <summary>
            /// An encounter that takes place where the patient and practitioner do not physically meet but use electronic means for contact.
            /// (system: http://hl7.org/fhir/encounter-class)
            /// </summary>
            [EnumLiteral("virtual", "http://hl7.org/fhir/encounter-class"), Description("Virtual")]
            Virtual,
            /// <summary>
            /// Any other encounter type that is not described by one of the other values. Where this is used it is expected that an implementer will include an extension value to define what the actual other type is.
            /// (system: http://hl7.org/fhir/encounter-class)
            /// </summary>
            [EnumLiteral("other", "http://hl7.org/fhir/encounter-class"), Description("Other")]
            Other,
        }

        /// <summary>
        /// The status of the location.
        /// (url: http://hl7.org/fhir/ValueSet/encounter-location-status)
        /// </summary>
        [FhirEnumeration("EncounterLocationStatus")]
        public enum EncounterLocationStatus
        {
            /// <summary>
            /// The patient is planned to be moved to this location at some point in the future.
            /// (system: http://hl7.org/fhir/encounter-location-status)
            /// </summary>
            [EnumLiteral("planned", "http://hl7.org/fhir/encounter-location-status"), Description("Planned")]
            Planned,
            /// <summary>
            /// The patient is currently at this location, or was between the period specified.
            /// A system may update these records when the patient leaves the location to either reserved, or completed
            /// (system: http://hl7.org/fhir/encounter-location-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/encounter-location-status"), Description("Active")]
            Active,
            /// <summary>
            /// This location is held empty for this patient.
            /// (system: http://hl7.org/fhir/encounter-location-status)
            /// </summary>
            [EnumLiteral("reserved", "http://hl7.org/fhir/encounter-location-status"), Description("Reserved")]
            Reserved,
            /// <summary>
            /// The patient was at this location during the period specified.
            /// Not to be used when the patient is currently at the location
            /// (system: http://hl7.org/fhir/encounter-location-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/encounter-location-status"), Description("Completed")]
            Completed,
        }


        [FhirType("StatusHistoryComponent")]
        [DataContract]
        public partial class StatusHistoryComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StatusHistoryComponent"; } }

            /// <summary>
            /// planned | arrived | in-progress | onleave | finished | cancelled
            /// </summary>
            [FhirElement("status", Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Code<EncounterState> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<EncounterState> _statusElement;

            /// <summary>
            /// planned | arrived | in-progress | onleave | finished | cancelled
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public EncounterState? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        StatusElement = null;
                    else
                        StatusElement = new Code<EncounterState>(value);
                    OnPropertyChanged("Status");
                }
            }

            /// <summary>
            /// The time that the episode was in the specified status
            /// </summary>
            [FhirElement("period", Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StatusHistoryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StatusElement != null) dest.StatusElement = (Code<EncounterState>)StatusElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new StatusHistoryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StatusHistoryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StatusHistoryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StatusElement != null) yield return StatusElement;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }


        }


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// Role of participant in encounter
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 40)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<CodeableConcept> Type
            {
                get { if (_type == null) _type = new List<CodeableConcept>(); return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private List<CodeableConcept> _type;

            /// <summary>
            /// Period of time during the encounter participant was present
            /// </summary>
            [FhirElement("period", Order = 50)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            /// <summary>
            /// Persons involved in the encounter other than the patient
            /// </summary>
            [FhirElement("individual", InSummary = true, Order = 60)]
            [References("Practitioner", "RelatedPerson")]
            [DataMember]
            public ResourceReference Individual
            {
                get { return _individual; }
                set { _individual = value; OnPropertyChanged("Individual"); }
            }

            private ResourceReference _individual;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (Individual != null) dest.Individual = (ResourceReference)Individual.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ParticipantComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if (!DeepComparable.Matches(Individual, otherT.Individual)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(Individual, otherT.Individual)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Type) { if (elem != null) yield return elem; }
                    if (Period != null) yield return Period;
                    if (Individual != null) yield return Individual;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                    if (Period != null) yield return new ElementValue("period", Period);
                    if (Individual != null) yield return new ElementValue("individual", Individual);
                }
            }


        }


        [FhirType("HospitalizationComponent")]
        [DataContract]
        public partial class HospitalizationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "HospitalizationComponent"; } }

            /// <summary>
            /// Pre-admission identifier
            /// </summary>
            [FhirElement("preAdmissionIdentifier", Order = 40)]
            [DataMember]
            public Identifier PreAdmissionIdentifier
            {
                get { return _preAdmissionIdentifier; }
                set { _preAdmissionIdentifier = value; OnPropertyChanged("PreAdmissionIdentifier"); }
            }

            private Identifier _preAdmissionIdentifier;

            /// <summary>
            /// The location from which the patient came before admission
            /// </summary>
            [FhirElement("origin", Order = 50)]
            [References("Location")]
            [DataMember]
            public ResourceReference Origin
            {
                get { return _origin; }
                set { _origin = value; OnPropertyChanged("Origin"); }
            }

            private ResourceReference _origin;

            /// <summary>
            /// From where patient was admitted (physician referral, transfer)
            /// </summary>
            [FhirElement("admitSource", Order = 60)]
            [DataMember]
            public CodeableConcept AdmitSource
            {
                get { return _admitSource; }
                set { _admitSource = value; OnPropertyChanged("AdmitSource"); }
            }

            private CodeableConcept _admitSource;

            /// <summary>
            /// The admitting diagnosis as reported by admitting practitioner
            /// </summary>
            [FhirElement("admittingDiagnosis", Order = 70)]
            [References("Condition")]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<ResourceReference> AdmittingDiagnosis
            {
                get { if (_admittingDiagnosis == null) _admittingDiagnosis = new List<ResourceReference>(); return _admittingDiagnosis; }
                set { _admittingDiagnosis = value; OnPropertyChanged("AdmittingDiagnosis"); }
            }

            private List<ResourceReference> _admittingDiagnosis;

            /// <summary>
            /// The type of hospital re-admission that has occurred (if any). If the value is absent, then this is not identified as a readmission
            /// </summary>
            [FhirElement("reAdmission", Order = 80)]
            [DataMember]
            public CodeableConcept ReAdmission
            {
                get { return _reAdmission; }
                set { _reAdmission = value; OnPropertyChanged("ReAdmission"); }
            }

            private CodeableConcept _reAdmission;

            /// <summary>
            /// Diet preferences reported by the patient
            /// </summary>
            [FhirElement("dietPreference", Order = 90)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<CodeableConcept> DietPreference
            {
                get { if (_dietPreference == null) _dietPreference = new List<CodeableConcept>(); return _dietPreference; }
                set { _dietPreference = value; OnPropertyChanged("DietPreference"); }
            }

            private List<CodeableConcept> _dietPreference;

            /// <summary>
            /// Special courtesies (VIP, board member)
            /// </summary>
            [FhirElement("specialCourtesy", Order = 100)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<CodeableConcept> SpecialCourtesy
            {
                get { if (_specialCourtesy == null) _specialCourtesy = new List<CodeableConcept>(); return _specialCourtesy; }
                set { _specialCourtesy = value; OnPropertyChanged("SpecialCourtesy"); }
            }

            private List<CodeableConcept> _specialCourtesy;

            /// <summary>
            /// Wheelchair, translator, stretcher, etc.
            /// </summary>
            [FhirElement("specialArrangement", Order = 110)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<CodeableConcept> SpecialArrangement
            {
                get { if (_specialArrangement == null) _specialArrangement = new List<CodeableConcept>(); return _specialArrangement; }
                set { _specialArrangement = value; OnPropertyChanged("SpecialArrangement"); }
            }

            private List<CodeableConcept> _specialArrangement;

            /// <summary>
            /// Location to which the patient is discharged
            /// </summary>
            [FhirElement("destination", Order = 120)]
            [References("Location")]
            [DataMember]
            public ResourceReference Destination
            {
                get { return _destination; }
                set { _destination = value; OnPropertyChanged("Destination"); }
            }

            private ResourceReference _destination;

            /// <summary>
            /// Category or kind of location after discharge
            /// </summary>
            [FhirElement("dischargeDisposition", Order = 130)]
            [DataMember]
            public CodeableConcept DischargeDisposition
            {
                get { return _dischargeDisposition; }
                set { _dischargeDisposition = value; OnPropertyChanged("DischargeDisposition"); }
            }

            private CodeableConcept _dischargeDisposition;

            /// <summary>
            /// The final diagnosis given a patient before release from the hospital after all testing, surgery, and workup are complete
            /// </summary>
            [FhirElement("dischargeDiagnosis", Order = 140)]
            [References("Condition")]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<ResourceReference> DischargeDiagnosis
            {
                get { if (_dischargeDiagnosis == null) _dischargeDiagnosis = new List<ResourceReference>(); return _dischargeDiagnosis; }
                set { _dischargeDiagnosis = value; OnPropertyChanged("DischargeDiagnosis"); }
            }

            private List<ResourceReference> _dischargeDiagnosis;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as HospitalizationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PreAdmissionIdentifier != null) dest.PreAdmissionIdentifier = (Identifier)PreAdmissionIdentifier.DeepCopy();
                    if (Origin != null) dest.Origin = (ResourceReference)Origin.DeepCopy();
                    if (AdmitSource != null) dest.AdmitSource = (CodeableConcept)AdmitSource.DeepCopy();
                    if (AdmittingDiagnosis != null) dest.AdmittingDiagnosis = new List<ResourceReference>(AdmittingDiagnosis.DeepCopy());
                    if (ReAdmission != null) dest.ReAdmission = (CodeableConcept)ReAdmission.DeepCopy();
                    if (DietPreference != null) dest.DietPreference = new List<CodeableConcept>(DietPreference.DeepCopy());
                    if (SpecialCourtesy != null) dest.SpecialCourtesy = new List<CodeableConcept>(SpecialCourtesy.DeepCopy());
                    if (SpecialArrangement != null) dest.SpecialArrangement = new List<CodeableConcept>(SpecialArrangement.DeepCopy());
                    if (Destination != null) dest.Destination = (ResourceReference)Destination.DeepCopy();
                    if (DischargeDisposition != null) dest.DischargeDisposition = (CodeableConcept)DischargeDisposition.DeepCopy();
                    if (DischargeDiagnosis != null) dest.DischargeDiagnosis = new List<ResourceReference>(DischargeDiagnosis.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new HospitalizationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as HospitalizationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PreAdmissionIdentifier, otherT.PreAdmissionIdentifier)) return false;
                if (!DeepComparable.Matches(Origin, otherT.Origin)) return false;
                if (!DeepComparable.Matches(AdmitSource, otherT.AdmitSource)) return false;
                if (!DeepComparable.Matches(AdmittingDiagnosis, otherT.AdmittingDiagnosis)) return false;
                if (!DeepComparable.Matches(ReAdmission, otherT.ReAdmission)) return false;
                if (!DeepComparable.Matches(DietPreference, otherT.DietPreference)) return false;
                if (!DeepComparable.Matches(SpecialCourtesy, otherT.SpecialCourtesy)) return false;
                if (!DeepComparable.Matches(SpecialArrangement, otherT.SpecialArrangement)) return false;
                if (!DeepComparable.Matches(Destination, otherT.Destination)) return false;
                if (!DeepComparable.Matches(DischargeDisposition, otherT.DischargeDisposition)) return false;
                if (!DeepComparable.Matches(DischargeDiagnosis, otherT.DischargeDiagnosis)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as HospitalizationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PreAdmissionIdentifier, otherT.PreAdmissionIdentifier)) return false;
                if (!DeepComparable.IsExactly(Origin, otherT.Origin)) return false;
                if (!DeepComparable.IsExactly(AdmitSource, otherT.AdmitSource)) return false;
                if (!DeepComparable.IsExactly(AdmittingDiagnosis, otherT.AdmittingDiagnosis)) return false;
                if (!DeepComparable.IsExactly(ReAdmission, otherT.ReAdmission)) return false;
                if (!DeepComparable.IsExactly(DietPreference, otherT.DietPreference)) return false;
                if (!DeepComparable.IsExactly(SpecialCourtesy, otherT.SpecialCourtesy)) return false;
                if (!DeepComparable.IsExactly(SpecialArrangement, otherT.SpecialArrangement)) return false;
                if (!DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
                if (!DeepComparable.IsExactly(DischargeDisposition, otherT.DischargeDisposition)) return false;
                if (!DeepComparable.IsExactly(DischargeDiagnosis, otherT.DischargeDiagnosis)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PreAdmissionIdentifier != null) yield return PreAdmissionIdentifier;
                    if (Origin != null) yield return Origin;
                    if (AdmitSource != null) yield return AdmitSource;
                    foreach (var elem in AdmittingDiagnosis) { if (elem != null) yield return elem; }
                    if (ReAdmission != null) yield return ReAdmission;
                    foreach (var elem in DietPreference) { if (elem != null) yield return elem; }
                    foreach (var elem in SpecialCourtesy) { if (elem != null) yield return elem; }
                    foreach (var elem in SpecialArrangement) { if (elem != null) yield return elem; }
                    if (Destination != null) yield return Destination;
                    if (DischargeDisposition != null) yield return DischargeDisposition;
                    foreach (var elem in DischargeDiagnosis) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PreAdmissionIdentifier != null) yield return new ElementValue("preAdmissionIdentifier", PreAdmissionIdentifier);
                    if (Origin != null) yield return new ElementValue("origin", Origin);
                    if (AdmitSource != null) yield return new ElementValue("admitSource", AdmitSource);
                    foreach (var elem in AdmittingDiagnosis) { if (elem != null) yield return new ElementValue("admittingDiagnosis", elem); }
                    if (ReAdmission != null) yield return new ElementValue("reAdmission", ReAdmission);
                    foreach (var elem in DietPreference) { if (elem != null) yield return new ElementValue("dietPreference", elem); }
                    foreach (var elem in SpecialCourtesy) { if (elem != null) yield return new ElementValue("specialCourtesy", elem); }
                    foreach (var elem in SpecialArrangement) { if (elem != null) yield return new ElementValue("specialArrangement", elem); }
                    if (Destination != null) yield return new ElementValue("destination", Destination);
                    if (DischargeDisposition != null) yield return new ElementValue("dischargeDisposition", DischargeDisposition);
                    foreach (var elem in DischargeDiagnosis) { if (elem != null) yield return new ElementValue("dischargeDiagnosis", elem); }
                }
            }


        }


        [FhirType("LocationComponent")]
        [DataContract]
        public partial class LocationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LocationComponent"; } }

            /// <summary>
            /// Location the encounter takes place
            /// </summary>
            [FhirElement("location", Order = 40)]
            [References("Location")]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public ResourceReference Location
            {
                get { return _location; }
                set { _location = value; OnPropertyChanged("Location"); }
            }

            private ResourceReference _location;

            /// <summary>
            /// planned | active | reserved | completed
            /// </summary>
            [FhirElement("status", Order = 50)]
            [DataMember]
            public Code<EncounterLocationStatus> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<EncounterLocationStatus> _statusElement;

            /// <summary>
            /// planned | active | reserved | completed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public EncounterLocationStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        StatusElement = null;
                    else
                        StatusElement = new Code<EncounterLocationStatus>(value);
                    OnPropertyChanged("Status");
                }
            }

            /// <summary>
            /// Time period during which the patient was present at the location
            /// </summary>
            [FhirElement("period", Order = 60)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LocationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                    if (StatusElement != null) dest.StatusElement = (Code<EncounterLocationStatus>)StatusElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new LocationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LocationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Location, otherT.Location)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LocationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Location != null) yield return Location;
                    if (StatusElement != null) yield return StatusElement;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Location != null) yield return new ElementValue("location", Location);
                    if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }


        }


        /// <summary>
        /// Identifier(s) by which this encounter is known
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
        /// planned | arrived | in-progress | onleave | finished | cancelled
        /// </summary>
        [FhirElement("status", InSummary = true, Order = 100)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public Code<EncounterState> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<EncounterState> _statusElement;

        /// <summary>
        /// planned | arrived | in-progress | onleave | finished | cancelled
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public EncounterState? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<EncounterState>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// List of past encounter statuses
        /// </summary>
        [FhirElement("statusHistory", Order = 110)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<StatusHistoryComponent> StatusHistory
        {
            get { if (_statusHistory == null) _statusHistory = new List<StatusHistoryComponent>(); return _statusHistory; }
            set { _statusHistory = value; OnPropertyChanged("StatusHistory"); }
        }

        private List<StatusHistoryComponent> _statusHistory;

        /// <summary>
        /// inpatient | outpatient | ambulatory | emergency +
        /// </summary>
        [FhirElement("class", InSummary = true, Order = 120)]
        [DataMember]
        public Code<EncounterClass> ClassElement
        {
            get { return _classElement; }
            set { _classElement = value; OnPropertyChanged("ClassElement"); }
        }

        private Code<EncounterClass> _classElement;

        /// <summary>
        /// inpatient | outpatient | ambulatory | emergency +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public EncounterClass? Class
        {
            get { return ClassElement != null ? ClassElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    ClassElement = null;
                else
                    ClassElement = new Code<EncounterClass>(value);
                OnPropertyChanged("Class");
            }
        }

        /// <summary>
        /// Specific type of encounter
        /// </summary>
        [FhirElement("type", InSummary = true, Order = 130)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> Type
        {
            get { if (_type == null) _type = new List<CodeableConcept>(); return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private List<CodeableConcept> _type;

        /// <summary>
        /// Indicates the urgency of the encounter
        /// </summary>
        [FhirElement("priority", Order = 140)]
        [DataMember]
        public CodeableConcept Priority
        {
            get { return _priority; }
            set { _priority = value; OnPropertyChanged("Priority"); }
        }

        private CodeableConcept _priority;

        /// <summary>
        /// The patient present at the encounter
        /// </summary>
        [FhirElement("patient", InSummary = true, Order = 150)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Episode(s) of care that this encounter should be recorded against
        /// </summary>
        [FhirElement("episodeOfCare", InSummary = true, Order = 160)]
        [References("EpisodeOfCare")]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ResourceReference> EpisodeOfCare
        {
            get { if (_episodeOfCare == null) _episodeOfCare = new List<ResourceReference>(); return _episodeOfCare; }
            set { _episodeOfCare = value; OnPropertyChanged("EpisodeOfCare"); }
        }

        private List<ResourceReference> _episodeOfCare;

        /// <summary>
        /// The ReferralRequest that initiated this encounter
        /// </summary>
        [FhirElement("incomingReferral", Order = 170)]
        [References("ReferralRequest")]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ResourceReference> IncomingReferral
        {
            get { if (_incomingReferral == null) _incomingReferral = new List<ResourceReference>(); return _incomingReferral; }
            set { _incomingReferral = value; OnPropertyChanged("IncomingReferral"); }
        }

        private List<ResourceReference> _incomingReferral;

        /// <summary>
        /// List of participants involved in the encounter
        /// </summary>
        [FhirElement("participant", InSummary = true, Order = 180)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if (_participant == null) _participant = new List<ParticipantComponent>(); return _participant; }
            set { _participant = value; OnPropertyChanged("Participant"); }
        }

        private List<ParticipantComponent> _participant;

        /// <summary>
        /// The appointment that scheduled this encounter
        /// </summary>
        [FhirElement("appointment", InSummary = true, Order = 190)]
        [References("Appointment")]
        [DataMember]
        public ResourceReference Appointment
        {
            get { return _appointment; }
            set { _appointment = value; OnPropertyChanged("Appointment"); }
        }

        private ResourceReference _appointment;

        /// <summary>
        /// The start and end time of the encounter
        /// </summary>
        [FhirElement("period", Order = 200)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Quantity of time the encounter lasted (less time absent)
        /// </summary>
        [FhirElement("length", Order = 210)]
        [DataMember]
        public Duration Length
        {
            get { return _length; }
            set { _length = value; OnPropertyChanged("Length"); }
        }

        private Duration _length;

        /// <summary>
        /// Reason the encounter takes place (code)
        /// </summary>
        [FhirElement("reason", InSummary = true, Order = 220)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> Reason
        {
            get { if (_reason == null) _reason = new List<CodeableConcept>(); return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private List<CodeableConcept> _reason;

        /// <summary>
        /// Reason the encounter takes place (resource)
        /// </summary>
        [FhirElement("indication", Order = 230)]
        [References("Condition", "Procedure")]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ResourceReference> Indication
        {
            get { if (_indication == null) _indication = new List<ResourceReference>(); return _indication; }
            set { _indication = value; OnPropertyChanged("Indication"); }
        }

        private List<ResourceReference> _indication;

        /// <summary>
        /// Details about the admission to a healthcare service
        /// </summary>
        [FhirElement("hospitalization", Order = 240)]
        [DataMember]
        public HospitalizationComponent Hospitalization
        {
            get { return _hospitalization; }
            set { _hospitalization = value; OnPropertyChanged("Hospitalization"); }
        }

        private HospitalizationComponent _hospitalization;

        /// <summary>
        /// List of locations where the patient has been
        /// </summary>
        [FhirElement("location", Order = 250)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<LocationComponent> Location
        {
            get { if (_location == null) _location = new List<LocationComponent>(); return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private List<LocationComponent> _location;

        /// <summary>
        /// The custodian organization of this Encounter record
        /// </summary>
        [FhirElement("serviceProvider", Order = 260)]
        [References("Organization")]
        [DataMember]
        public ResourceReference ServiceProvider
        {
            get { return _serviceProvider; }
            set { _serviceProvider = value; OnPropertyChanged("ServiceProvider"); }
        }

        private ResourceReference _serviceProvider;

        /// <summary>
        /// Another Encounter this encounter is part of
        /// </summary>
        [FhirElement("partOf", Order = 270)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference PartOf
        {
            get { return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private ResourceReference _partOf;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Encounter;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<EncounterState>)StatusElement.DeepCopy();
                if (StatusHistory != null) dest.StatusHistory = new List<StatusHistoryComponent>(StatusHistory.DeepCopy());
                if (ClassElement != null) dest.ClassElement = (Code<EncounterClass>)ClassElement.DeepCopy();
                if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                if (Priority != null) dest.Priority = (CodeableConcept)Priority.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (EpisodeOfCare != null) dest.EpisodeOfCare = new List<ResourceReference>(EpisodeOfCare.DeepCopy());
                if (IncomingReferral != null) dest.IncomingReferral = new List<ResourceReference>(IncomingReferral.DeepCopy());
                if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                if (Appointment != null) dest.Appointment = (ResourceReference)Appointment.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Length != null) dest.Length = (Duration)Length.DeepCopy();
                if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                if (Indication != null) dest.Indication = new List<ResourceReference>(Indication.DeepCopy());
                if (Hospitalization != null) dest.Hospitalization = (HospitalizationComponent)Hospitalization.DeepCopy();
                if (Location != null) dest.Location = new List<LocationComponent>(Location.DeepCopy());
                if (ServiceProvider != null) dest.ServiceProvider = (ResourceReference)ServiceProvider.DeepCopy();
                if (PartOf != null) dest.PartOf = (ResourceReference)PartOf.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Encounter());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Encounter;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(StatusHistory, otherT.StatusHistory)) return false;
            if (!DeepComparable.Matches(ClassElement, otherT.ClassElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(EpisodeOfCare, otherT.EpisodeOfCare)) return false;
            if (!DeepComparable.Matches(IncomingReferral, otherT.IncomingReferral)) return false;
            if (!DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if (!DeepComparable.Matches(Appointment, otherT.Appointment)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(Length, otherT.Length)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(Indication, otherT.Indication)) return false;
            if (!DeepComparable.Matches(Hospitalization, otherT.Hospitalization)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(ServiceProvider, otherT.ServiceProvider)) return false;
            if (!DeepComparable.Matches(PartOf, otherT.PartOf)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Encounter;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusHistory, otherT.StatusHistory)) return false;
            if (!DeepComparable.IsExactly(ClassElement, otherT.ClassElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(EpisodeOfCare, otherT.EpisodeOfCare)) return false;
            if (!DeepComparable.IsExactly(IncomingReferral, otherT.IncomingReferral)) return false;
            if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if (!DeepComparable.IsExactly(Appointment, otherT.Appointment)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Length, otherT.Length)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
            if (!DeepComparable.IsExactly(Hospitalization, otherT.Hospitalization)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(ServiceProvider, otherT.ServiceProvider)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;

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
                foreach (var elem in StatusHistory) { if (elem != null) yield return elem; }
                if (ClassElement != null) yield return ClassElement;
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                if (Priority != null) yield return Priority;
                if (Patient != null) yield return Patient;
                foreach (var elem in EpisodeOfCare) { if (elem != null) yield return elem; }
                foreach (var elem in IncomingReferral) { if (elem != null) yield return elem; }
                foreach (var elem in Participant) { if (elem != null) yield return elem; }
                if (Appointment != null) yield return Appointment;
                if (Period != null) yield return Period;
                if (Length != null) yield return Length;
                foreach (var elem in Reason) { if (elem != null) yield return elem; }
                foreach (var elem in Indication) { if (elem != null) yield return elem; }
                if (Hospitalization != null) yield return Hospitalization;
                foreach (var elem in Location) { if (elem != null) yield return elem; }
                if (ServiceProvider != null) yield return ServiceProvider;
                if (PartOf != null) yield return PartOf;
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
                foreach (var elem in StatusHistory) { if (elem != null) yield return new ElementValue("statusHistory", elem); }
                if (ClassElement != null) yield return new ElementValue("class", ClassElement);
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                if (Priority != null) yield return new ElementValue("priority", Priority);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                foreach (var elem in EpisodeOfCare) { if (elem != null) yield return new ElementValue("episodeOfCare", elem); }
                foreach (var elem in IncomingReferral) { if (elem != null) yield return new ElementValue("incomingReferral", elem); }
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
                if (Appointment != null) yield return new ElementValue("appointment", Appointment);
                if (Period != null) yield return new ElementValue("period", Period);
                if (Length != null) yield return new ElementValue("length", Length);
                foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                foreach (var elem in Indication) { if (elem != null) yield return new ElementValue("indication", elem); }
                if (Hospitalization != null) yield return new ElementValue("hospitalization", Hospitalization);
                foreach (var elem in Location) { if (elem != null) yield return new ElementValue("location", elem); }
                if (ServiceProvider != null) yield return new ElementValue("serviceProvider", ServiceProvider);
                if (PartOf != null) yield return new ElementValue("partOf", PartOf);
            }
        }

    }

}
