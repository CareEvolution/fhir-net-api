using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.STU3;
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


        [FhirType("StageComponent")]
        [DataContract]
        public partial class StageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StageComponent"; } }

            /// <summary>
            /// Simple summary (disease specific)
            /// </summary>
            [FhirElement("summary", Order=40)]
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
            [FhirElement("assessment", Order=50)]
            [References("ClinicalImpression","DiagnosticReport","Observation")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Assessment
            {
                get { if (_assessment==null) _assessment = new List<ResourceReference>(); return _assessment; }
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
                if ( !DeepComparable.Matches(Assessment, otherT.Assessment)) return false;

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
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Code
            {
                get { if (_code==null) _code = new List<CodeableConcept>(); return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private List<CodeableConcept> _code;

            /// <summary>
            /// Supporting information found elsewhere
            /// </summary>
            [FhirElement("detail", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Detail
            {
                get { if (_detail==null) _detail = new List<ResourceReference>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<ResourceReference> _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EvidenceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = new List<CodeableConcept>(Code.DeepCopy());
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
                if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;

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
                    foreach (var elem in Code) { if (elem != null) yield return elem; }
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
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
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// active | recurrence | inactive | remission | resolved
        /// </summary>
        [FhirElement("clinicalStatus", InSummary=true, Order=100)]
        [DataMember]
        public Code<ConditionClinicalStatusCodes> ClinicalStatusElement
        {
            get { return _clinicalStatusElement; }
            set { _clinicalStatusElement = value; OnPropertyChanged("ClinicalStatusElement"); }
        }

        private Code<ConditionClinicalStatusCodes> _clinicalStatusElement;

        /// <summary>
        /// active | recurrence | inactive | remission | resolved
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConditionClinicalStatusCodes? ClinicalStatus
        {
            get { return ClinicalStatusElement != null ? ClinicalStatusElement.Value : null; }
            set
            {
                if (value == null)
                    ClinicalStatusElement = null;
                else
                    ClinicalStatusElement = new Code<ConditionClinicalStatusCodes>(value);
                OnPropertyChanged("ClinicalStatus");
            }
        }

        /// <summary>
        /// provisional | differential | confirmed | refuted | entered-in-error | unknown
        /// </summary>
        [FhirElement("verificationStatus", InSummary=true, Order=110)]
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
                if (value == null)
                    VerificationStatusElement = null;
                else
                    VerificationStatusElement = new Code<ConditionVerificationStatus>(value);
                OnPropertyChanged("VerificationStatus");
            }
        }

        /// <summary>
        /// problem-list-item | encounter-diagnosis
        /// </summary>
        [FhirElement("category", Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// Subjective severity of condition
        /// </summary>
        [FhirElement("severity", Order=130)]
        [DataMember]
        public CodeableConcept Severity
        {
            get { return _severity; }
            set { _severity = value; OnPropertyChanged("Severity"); }
        }

        private CodeableConcept _severity;

        /// <summary>
        /// Identification of the condition, problem or diagnosis
        /// </summary>
        [FhirElement("code", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Anatomical location, if relevant
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> BodySite
        {
            get { if (_bodySite==null) _bodySite = new List<CodeableConcept>(); return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private List<CodeableConcept> _bodySite;

        /// <summary>
        /// Who has the condition?
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=160)]
        [References("Patient","Group")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Encounter or episode when condition first asserted
        /// </summary>
        [FhirElement("context", InSummary=true, Order=170)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// Estimated or actual date,  date-time, or age
        /// </summary>
        [FhirElement("onset", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
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
        [FhirElement("abatement", Order=190, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Age),typeof(FhirBoolean),typeof(Period),typeof(Range),typeof(FhirString))]
        [DataMember]
        public Element Abatement
        {
            get { return _abatement; }
            set { _abatement = value; OnPropertyChanged("Abatement"); }
        }

        private Element _abatement;

        /// <summary>
        /// Date record was believed accurate
        /// </summary>
        [FhirElement("assertedDate", InSummary=true, Order=200)]
        [DataMember]
        public FhirDateTime AssertedDateElement
        {
            get { return _assertedDateElement; }
            set { _assertedDateElement = value; OnPropertyChanged("AssertedDateElement"); }
        }

        private FhirDateTime _assertedDateElement;

        /// <summary>
        /// Date record was believed accurate
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string AssertedDate
        {
            get { return AssertedDateElement != null ? AssertedDateElement.Value : null; }
            set
            {
                if (value == null)
                    AssertedDateElement = null;
                else
                    AssertedDateElement = new FhirDateTime(value);
                OnPropertyChanged("AssertedDate");
            }
        }

        /// <summary>
        /// Person who asserts this condition
        /// </summary>
        [FhirElement("asserter", InSummary=true, Order=210)]
        [References("Practitioner","Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Asserter
        {
            get { return _asserter; }
            set { _asserter = value; OnPropertyChanged("Asserter"); }
        }

        private ResourceReference _asserter;

        /// <summary>
        /// Stage/grade, usually assessed formally
        /// </summary>
        [FhirElement("stage", Order=220)]
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
        [FhirElement("evidence", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EvidenceComponent> Evidence
        {
            get { if (_evidence==null) _evidence = new List<EvidenceComponent>(); return _evidence; }
            set { _evidence = value; OnPropertyChanged("Evidence"); }
        }

        private List<EvidenceComponent> _evidence;

        /// <summary>
        /// Additional information about the Condition
        /// </summary>
        [FhirElement("note", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;


        public static ElementDefinition.ConstraintComponent Condition_CON_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "abatement.empty() or (abatement as boolean).not()  or clinicalStatus='resolved' or clinicalStatus='remission' or clinicalStatus='inactive'",
            Key = "con-4",
            Severity = ConstraintSeverity.Warning,
            Human = "If condition is abated, then clinicalStatus must be either inactive, resolved, or remission",
            Xpath = "not(f:abatementBoolean/@value=true() or (not(exists(f:abatementBoolean)) and exists(*[starts-with(local-name(.), 'abatement')])) or f:clinicalStatus/@value=('resolved', 'remission', 'inactive'))"
        };

        public static ElementDefinition.ConstraintComponent Condition_CON_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "verificationStatus='entered-in-error' or clinicalStatus.exists()",
            Key = "con-3",
            Severity = ConstraintSeverity.Warning,
            Human = "Condition.clinicalStatus SHALL be present if verificationStatus is not entered-in-error",
            Xpath = "f:verificationStatus/@value='entered-in-error' or exists(f:clinicalStatus)"
        };

        public static ElementDefinition.ConstraintComponent Condition_CON_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "stage.all(summary.exists() or assessment.exists())",
            Key = "con-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Stage SHALL have summary or assessment",
            Xpath = "exists(f:summary) or exists(f:assessment)"
        };

        public static ElementDefinition.ConstraintComponent Condition_CON_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "evidence.all(code.exists() or detail.exists())",
            Key = "con-2",
            Severity = ConstraintSeverity.Warning,
            Human = "evidence SHALL have code or details",
            Xpath = "exists(f:code) or exists(f:detail)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Condition_CON_4);
            InvariantConstraints.Add(Condition_CON_3);
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
                if (ClinicalStatusElement != null) dest.ClinicalStatusElement = (Code<ConditionClinicalStatusCodes>)ClinicalStatusElement.DeepCopy();
                if (VerificationStatusElement != null) dest.VerificationStatusElement = (Code<ConditionVerificationStatus>)VerificationStatusElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (Severity != null) dest.Severity = (CodeableConcept)Severity.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (BodySite != null) dest.BodySite = new List<CodeableConcept>(BodySite.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Onset != null) dest.Onset = (Element)Onset.DeepCopy();
                if (Abatement != null) dest.Abatement = (Element)Abatement.DeepCopy();
                if (AssertedDateElement != null) dest.AssertedDateElement = (FhirDateTime)AssertedDateElement.DeepCopy();
                if (Asserter != null) dest.Asserter = (ResourceReference)Asserter.DeepCopy();
                if (Stage != null) dest.Stage = (StageComponent)Stage.DeepCopy();
                if (Evidence != null) dest.Evidence = new List<EvidenceComponent>(Evidence.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
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
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if (!DeepComparable.Matches(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Severity, otherT.Severity)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if ( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Onset, otherT.Onset)) return false;
            if (!DeepComparable.Matches(Abatement, otherT.Abatement)) return false;
            if (!DeepComparable.Matches(AssertedDateElement, otherT.AssertedDateElement)) return false;
            if (!DeepComparable.Matches(Asserter, otherT.Asserter)) return false;
            if (!DeepComparable.Matches(Stage, otherT.Stage)) return false;
            if ( !DeepComparable.Matches(Evidence, otherT.Evidence)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Condition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if (!DeepComparable.IsExactly(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Severity, otherT.Severity)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Onset, otherT.Onset)) return false;
            if (!DeepComparable.IsExactly(Abatement, otherT.Abatement)) return false;
            if (!DeepComparable.IsExactly(AssertedDateElement, otherT.AssertedDateElement)) return false;
            if (!DeepComparable.IsExactly(Asserter, otherT.Asserter)) return false;
            if (!DeepComparable.IsExactly(Stage, otherT.Stage)) return false;
            if (!DeepComparable.IsExactly(Evidence, otherT.Evidence)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (ClinicalStatusElement != null) yield return ClinicalStatusElement;
                if (VerificationStatusElement != null) yield return VerificationStatusElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (Severity != null) yield return Severity;
                if (Code != null) yield return Code;
                foreach (var elem in BodySite) { if (elem != null) yield return elem; }
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Onset != null) yield return Onset;
                if (Abatement != null) yield return Abatement;
                if (AssertedDateElement != null) yield return AssertedDateElement;
                if (Asserter != null) yield return Asserter;
                if (Stage != null) yield return Stage;
                foreach (var elem in Evidence) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (ClinicalStatusElement != null) yield return new ElementValue("clinicalStatus", ClinicalStatusElement);
                if (VerificationStatusElement != null) yield return new ElementValue("verificationStatus", VerificationStatusElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (Severity != null) yield return new ElementValue("severity", Severity);
                if (Code != null) yield return new ElementValue("code", Code);
                foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", elem); }
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Onset != null) yield return new ElementValue("onset", Onset);
                if (Abatement != null) yield return new ElementValue("abatement", Abatement);
                if (AssertedDateElement != null) yield return new ElementValue("assertedDate", AssertedDateElement);
                if (Asserter != null) yield return new ElementValue("asserter", Asserter);
                if (Stage != null) yield return new ElementValue("stage", Stage);
                foreach (var elem in Evidence) { if (elem != null) yield return new ElementValue("evidence", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
