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
    /// Detailed information about conditions, problems or diagnoses
    /// </summary>
    [FhirType("Condition", IsResource=true)]
    [DataContract]
    public partial class Condition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Condition; } }
        [NotMapped]
        public override string TypeName { get { return "Condition"; } }

        /// <summary>
        /// Preferred value set for Condition Clinical Status.
        /// (url: http://hl7.org/fhir/ValueSet/condition-clinical)
        /// </summary>
        [FhirEnumeration("ConditionClinicalStatusCodes")]
        public enum ConditionClinicalStatusCodes
        {
            /// <summary>
            /// The subject is currently experiencing the symptoms of the condition.
            /// (system: http://hl7.org/fhir/condition-clinical)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/condition-clinical"), Description("Active")]
            Active,
            /// <summary>
            /// The subject is re-experiencing the symptoms of the condition after a period of remission or presumed resolution.
            /// (system: http://hl7.org/fhir/condition-clinical)
            /// </summary>
            [EnumLiteral("relapse", "http://hl7.org/fhir/condition-clinical"), Description("Relapse")]
            Relapse,
            /// <summary>
            /// The subject is no longer experiencing the symptoms of the condition, but there is a risk of the symptoms returning.
            /// (system: http://hl7.org/fhir/condition-clinical)
            /// </summary>
            [EnumLiteral("remission", "http://hl7.org/fhir/condition-clinical"), Description("Remission")]
            Remission,
            /// <summary>
            /// The subject is no longer experiencing the symptoms of the condition and there is no perceived risk of the symptoms returning.
            /// (system: http://hl7.org/fhir/condition-clinical)
            /// </summary>
            [EnumLiteral("resolved", "http://hl7.org/fhir/condition-clinical"), Description("Resolved")]
            Resolved,
        }

        /// <summary>
        /// The verification status to support or decline the clinical status of the condition or diagnosis.
        /// (url: http://hl7.org/fhir/ValueSet/condition-ver-status)
        /// </summary>
        [FhirEnumeration("ConditionVerificationStatus")]
        public enum ConditionVerificationStatus
        {
            /// <summary>
            /// This is a tentative diagnosis - still a candidate that is under consideration.
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("provisional", "http://hl7.org/fhir/condition-ver-status"), Description("Provisional")]
            Provisional,
            /// <summary>
            /// One of a set of potential (and typically mutually exclusive) diagnosis asserted to further guide the diagnostic process and preliminary treatment.
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("differential", "http://hl7.org/fhir/condition-ver-status"), Description("Differential")]
            Differential,
            /// <summary>
            /// There is sufficient diagnostic and/or clinical evidence to treat this as a confirmed condition.
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("confirmed", "http://hl7.org/fhir/condition-ver-status"), Description("Confirmed")]
            Confirmed,
            /// <summary>
            /// This condition has been ruled out by diagnostic and clinical evidence.
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("refuted", "http://hl7.org/fhir/condition-ver-status"), Description("Refuted")]
            Refuted,
            /// <summary>
            /// The statement was entered in error and is not valid.
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/condition-ver-status"), Description("Entered In Error")]
            EnteredInError,
            /// <summary>
            /// The condition status is unknown.  Note that "unknown" is a value of last resort and every attempt should be made to provide a meaningful value other than "unknown".
            /// (system: http://hl7.org/fhir/condition-ver-status)
            /// </summary>
            [EnumLiteral("unknown", "http://hl7.org/fhir/condition-ver-status"), Description("Unknown")]
            Unknown,
        }


        [FhirType("StageComponent")]
        [DataContract]
        public partial class StageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StageComponent"; } }

            /// <summary>
            /// Simple summary (disease specific)
            /// </summary>
            [FhirElement("summary", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Summary
            {
                get { return _summary; }
                set { _summary = value; OnPropertyChanged("Summary"); }
            }

            private CodeableConcept _summary;

            /// <summary>
            /// Formal record of assessment
            /// </summary>
            [FhirElement("assessment", InSummary=true, Order=50)]
            [References("ClinicalImpression","DiagnosticReport","Observation")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Assessment
            {
                get { if (_assessment == null) _assessment = new List<ResourceReference>(); return _assessment; }
                set { _assessment = value; OnPropertyChanged("Assessment"); }
            }

            private List<ResourceReference> _assessment;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Summary != null) dest.Summary = (CodeableConcept)Summary.DeepCopy();
                    if (Assessment != null) dest.Assessment = new List<ResourceReference>(Assessment.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Summary, otherT.Summary)) return false;
                if (!DeepComparable.Matches(Assessment, otherT.Assessment)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Summary, otherT.Summary)) return false;
                if (!DeepComparable.IsExactly(Assessment, otherT.Assessment)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Summary != null) yield return Summary;
                    foreach (var elem in Assessment) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Summary != null) yield return new ElementValue("summary", Summary);
                    foreach (var elem in Assessment) { if (elem != null) yield return new ElementValue("assessment", elem); }
                }
            }


        }


        [FhirType("EvidenceComponent")]
        [DataContract]
        public partial class EvidenceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EvidenceComponent"; } }

            /// <summary>
            /// Manifestation/symptom
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Supporting information found elsewhere
            /// </summary>
            [FhirElement("detail", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Detail
            {
                get { if (_detail == null) _detail = new List<ResourceReference>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<ResourceReference> _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EvidenceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Detail != null) dest.Detail = new List<ResourceReference>(Detail.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EvidenceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EvidenceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EvidenceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
                }
            }


        }


        /// <summary>
        /// External Ids for this condition
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Who has the condition?
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

        /// <summary>
        /// Encounter when condition first asserted
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=110)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Person who asserts this condition
        /// </summary>
        [FhirElement("asserter", InSummary=true, Order=120)]
        [References("Practitioner","Patient")]
        [DataMember]
        public ResourceReference Asserter
        {
            get { return _asserter; }
            set { _asserter = value; OnPropertyChanged("Asserter"); }
        }

        private ResourceReference _asserter;

        /// <summary>
        /// When first entered
        /// </summary>
        [FhirElement("dateRecorded", InSummary=true, Order=130)]
        [DataMember]
        public Date DateRecordedElement
        {
            get { return _dateRecordedElement; }
            set { _dateRecordedElement = value; OnPropertyChanged("DateRecordedElement"); }
        }

        private Date _dateRecordedElement;

        /// <summary>
        /// When first entered
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateRecorded
        {
            get { return DateRecordedElement != null ? DateRecordedElement.Value : null; }
            set
            {
                if (value == null)
                    DateRecordedElement = null;
                else
                    DateRecordedElement = new Date(value);
                OnPropertyChanged("DateRecorded");
            }
        }

        /// <summary>
        /// Identification of the condition, problem or diagnosis
        /// </summary>
        [FhirElement("code", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// complaint | symptom | finding | diagnosis
        /// </summary>
        [FhirElement("category", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// active | relapse | remission | resolved
        /// </summary>
        [FhirElement("clinicalStatus", InSummary=true, Order=160)]
        [DataMember]
        public Code ClinicalStatusElement
        {
            get { return _clinicalStatusElement; }
            set { _clinicalStatusElement = value; OnPropertyChanged("ClinicalStatusElement"); }
        }

        private Code _clinicalStatusElement;

        /// <summary>
        /// active | relapse | remission | resolved
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ClinicalStatus
        {
            get { return ClinicalStatusElement != null ? ClinicalStatusElement.Value : null; }
            set
            {
                if (value == null)
                    ClinicalStatusElement = null;
                else
                    ClinicalStatusElement = new Code(value);
                OnPropertyChanged("ClinicalStatus");
            }
        }

        /// <summary>
        /// provisional | differential | confirmed | refuted | entered-in-error | unknown
        /// </summary>
        [FhirElement("verificationStatus", InSummary=true, Order=170)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ConditionVerificationStatus> VerificationStatusElement
        {
            get { return _verificationStatusElement; }
            set { _verificationStatusElement = value; OnPropertyChanged("VerificationStatusElement"); }
        }

        private Code<ConditionVerificationStatus> _verificationStatusElement;

        /// <summary>
        /// provisional | differential | confirmed | refuted | entered-in-error | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConditionVerificationStatus? VerificationStatus
        {
            get { return VerificationStatusElement != null ? VerificationStatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    VerificationStatusElement = null;
                else
                    VerificationStatusElement = new Code<ConditionVerificationStatus>(value);
                OnPropertyChanged("VerificationStatus");
            }
        }

        /// <summary>
        /// Subjective severity of condition
        /// </summary>
        [FhirElement("severity", InSummary=true, Order=180)]
        [DataMember]
        public CodeableConcept Severity
        {
            get { return _severity; }
            set { _severity = value; OnPropertyChanged("Severity"); }
        }

        private CodeableConcept _severity;

        /// <summary>
        /// Estimated or actual date,  date-time, or age
        /// </summary>
        [FhirElement("onset", InSummary=true, Order=190, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Age),typeof(Period),typeof(Range),typeof(FhirString))]
        [DataMember]
        public Element Onset
        {
            get { return _onset; }
            set { _onset = value; OnPropertyChanged("Onset"); }
        }

        private Element _onset;

        /// <summary>
        /// If/when in resolution/remission
        /// </summary>
        [FhirElement("abatement", InSummary=true, Order=200, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Age),typeof(FhirBoolean),typeof(Period),typeof(Range),typeof(FhirString))]
        [DataMember]
        public Element Abatement
        {
            get { return _abatement; }
            set { _abatement = value; OnPropertyChanged("Abatement"); }
        }

        private Element _abatement;

        /// <summary>
        /// Stage/grade, usually assessed formally
        /// </summary>
        [FhirElement("stage", InSummary=true, Order=210)]
        [DataMember]
        public StageComponent Stage
        {
            get { return _stage; }
            set { _stage = value; OnPropertyChanged("Stage"); }
        }

        private StageComponent _stage;

        /// <summary>
        /// Supporting evidence
        /// </summary>
        [FhirElement("evidence", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EvidenceComponent> Evidence
        {
            get { if (_evidence == null) _evidence = new List<EvidenceComponent>(); return _evidence; }
            set { _evidence = value; OnPropertyChanged("Evidence"); }
        }

        private List<EvidenceComponent> _evidence;

        /// <summary>
        /// Anatomical location, if relevant
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> BodySite
        {
            get { if (_bodySite == null) _bodySite = new List<CodeableConcept>(); return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private List<CodeableConcept> _bodySite;

        /// <summary>
        /// Additional information about the Condition
        /// </summary>
        [FhirElement("notes", InSummary=true, Order=240)]
        [DataMember]
        public FhirString NotesElement
        {
            get { return _notesElement; }
            set { _notesElement = value; OnPropertyChanged("NotesElement"); }
        }

        private FhirString _notesElement;

        /// <summary>
        /// Additional information about the Condition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Notes
        {
            get { return NotesElement != null ? NotesElement.Value : null; }
            set
            {
                if (value == null)
                    NotesElement = null;
                else
                    NotesElement = new FhirString(value);
                OnPropertyChanged("Notes");
            }
        }


        public static ElementDefinition.ConstraintComponent Condition_CON_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "stage.all(summary or assessment)",
            Key = "con-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Stage SHALL have summary or assessment",
            Xpath = "exists(f:summary) or exists(f:assessment)"
        };

        public static ElementDefinition.ConstraintComponent Condition_CON_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "evidence.all(code or detail)",
            Key = "con-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "evidence SHALL have code or details",
            Xpath = "exists(f:code) or exists(f:detail)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Condition_CON_1);
            InvariantConstraints.Add(Condition_CON_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Condition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Asserter != null) dest.Asserter = (ResourceReference)Asserter.DeepCopy();
                if (DateRecordedElement != null) dest.DateRecordedElement = (Date)DateRecordedElement.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (ClinicalStatusElement != null) dest.ClinicalStatusElement = (Code)ClinicalStatusElement.DeepCopy();
                if (VerificationStatusElement != null) dest.VerificationStatusElement = (Code<ConditionVerificationStatus>)VerificationStatusElement.DeepCopy();
                if (Severity != null) dest.Severity = (CodeableConcept)Severity.DeepCopy();
                if (Onset != null) dest.Onset = (Element)Onset.DeepCopy();
                if (Abatement != null) dest.Abatement = (Element)Abatement.DeepCopy();
                if (Stage != null) dest.Stage = (StageComponent)Stage.DeepCopy();
                if (Evidence != null) dest.Evidence = new List<EvidenceComponent>(Evidence.DeepCopy());
                if (BodySite != null) dest.BodySite = new List<CodeableConcept>(BodySite.DeepCopy());
                if (NotesElement != null) dest.NotesElement = (FhirString)NotesElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Condition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Condition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Asserter, otherT.Asserter)) return false;
            if (!DeepComparable.Matches(DateRecordedElement, otherT.DateRecordedElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if (!DeepComparable.Matches(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if (!DeepComparable.Matches(Severity, otherT.Severity)) return false;
            if (!DeepComparable.Matches(Onset, otherT.Onset)) return false;
            if (!DeepComparable.Matches(Abatement, otherT.Abatement)) return false;
            if (!DeepComparable.Matches(Stage, otherT.Stage)) return false;
            if (!DeepComparable.Matches(Evidence, otherT.Evidence)) return false;
            if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.Matches(NotesElement, otherT.NotesElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Condition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Asserter, otherT.Asserter)) return false;
            if (!DeepComparable.IsExactly(DateRecordedElement, otherT.DateRecordedElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if (!DeepComparable.IsExactly(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if (!DeepComparable.IsExactly(Severity, otherT.Severity)) return false;
            if (!DeepComparable.IsExactly(Onset, otherT.Onset)) return false;
            if (!DeepComparable.IsExactly(Abatement, otherT.Abatement)) return false;
            if (!DeepComparable.IsExactly(Stage, otherT.Stage)) return false;
            if (!DeepComparable.IsExactly(Evidence, otherT.Evidence)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(NotesElement, otherT.NotesElement)) return false;

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
                if (Encounter != null) yield return Encounter;
                if (Asserter != null) yield return Asserter;
                if (DateRecordedElement != null) yield return DateRecordedElement;
                if (Code != null) yield return Code;
                if (Category != null) yield return Category;
                if (ClinicalStatusElement != null) yield return ClinicalStatusElement;
                if (VerificationStatusElement != null) yield return VerificationStatusElement;
                if (Severity != null) yield return Severity;
                if (Onset != null) yield return Onset;
                if (Abatement != null) yield return Abatement;
                if (Stage != null) yield return Stage;
                foreach (var elem in Evidence) { if (elem != null) yield return elem; }
                foreach (var elem in BodySite) { if (elem != null) yield return elem; }
                if (NotesElement != null) yield return NotesElement;
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
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Asserter != null) yield return new ElementValue("asserter", Asserter);
                if (DateRecordedElement != null) yield return new ElementValue("dateRecorded", DateRecordedElement);
                if (Code != null) yield return new ElementValue("code", Code);
                if (Category != null) yield return new ElementValue("category", Category);
                if (ClinicalStatusElement != null) yield return new ElementValue("clinicalStatus", ClinicalStatusElement);
                if (VerificationStatusElement != null) yield return new ElementValue("verificationStatus", VerificationStatusElement);
                if (Severity != null) yield return new ElementValue("severity", Severity);
                if (Onset != null) yield return new ElementValue("onset", Onset);
                if (Abatement != null) yield return new ElementValue("abatement", Abatement);
                if (Stage != null) yield return new ElementValue("stage", Stage);
                foreach (var elem in Evidence) { if (elem != null) yield return new ElementValue("evidence", elem); }
                foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", elem); }
                if (NotesElement != null) yield return new ElementValue("notes", NotesElement);
            }
        }

    }

}
