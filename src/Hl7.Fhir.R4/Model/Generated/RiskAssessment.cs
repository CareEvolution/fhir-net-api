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
    /// Potential outcomes for a subject with likelihood
    /// </summary>
    [FhirType("RiskAssessment", IsResource=true)]
    [DataContract]
    public partial class RiskAssessment : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.RiskAssessment; } }
        [NotMapped]
        public override string TypeName { get { return "RiskAssessment"; } }


        [FhirType("PredictionComponent")]
        [DataContract]
        public partial class PredictionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PredictionComponent"; } }

            /// <summary>
            /// Possible outcome for the subject
            /// </summary>
            [FhirElement("outcome", Order=40)]
            [DataMember]
            public CodeableConcept Outcome
            {
                get { return _outcome; }
                set { _outcome = value; OnPropertyChanged("Outcome"); }
            }

            private CodeableConcept _outcome;

            /// <summary>
            /// Likelihood of specified outcome
            /// </summary>
            [FhirElement("probability", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirDecimal),typeof(Range))]
            [DataMember]
            public Element Probability
            {
                get { return _probability; }
                set { _probability = value; OnPropertyChanged("Probability"); }
            }

            private Element _probability;

            /// <summary>
            /// Likelihood of specified outcome as a qualitative value
            /// </summary>
            [FhirElement("qualitativeRisk", Order=60)]
            [DataMember]
            public CodeableConcept QualitativeRisk
            {
                get { return _qualitativeRisk; }
                set { _qualitativeRisk = value; OnPropertyChanged("QualitativeRisk"); }
            }

            private CodeableConcept _qualitativeRisk;

            /// <summary>
            /// Relative likelihood
            /// </summary>
            [FhirElement("relativeRisk", Order=70)]
            [DataMember]
            public FhirDecimal RelativeRiskElement
            {
                get { return _relativeRiskElement; }
                set { _relativeRiskElement = value; OnPropertyChanged("RelativeRiskElement"); }
            }

            private FhirDecimal _relativeRiskElement;

            /// <summary>
            /// Relative likelihood
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? RelativeRisk
            {
                get { return RelativeRiskElement != null ? RelativeRiskElement.Value : null; }
                set
                {
                    if (value == null)
                        RelativeRiskElement = null;
                    else
                        RelativeRiskElement = new FhirDecimal(value);
                    OnPropertyChanged("RelativeRisk");
                }
            }

            /// <summary>
            /// Timeframe or age range
            /// </summary>
            [FhirElement("when", Order=80, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Period),typeof(Range))]
            [DataMember]
            public Element When
            {
                get { return _when; }
                set { _when = value; OnPropertyChanged("When"); }
            }

            private Element _when;

            /// <summary>
            /// Explanation of prediction
            /// </summary>
            [FhirElement("rationale", Order=90)]
            [DataMember]
            public FhirString RationaleElement
            {
                get { return _rationaleElement; }
                set { _rationaleElement = value; OnPropertyChanged("RationaleElement"); }
            }

            private FhirString _rationaleElement;

            /// <summary>
            /// Explanation of prediction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Rationale
            {
                get { return RationaleElement != null ? RationaleElement.Value : null; }
                set
                {
                    if (value == null)
                        RationaleElement = null;
                    else
                        RationaleElement = new FhirString(value);
                    OnPropertyChanged("Rationale");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PredictionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                    if (Probability != null) dest.Probability = (Element)Probability.DeepCopy();
                    if (QualitativeRisk != null) dest.QualitativeRisk = (CodeableConcept)QualitativeRisk.DeepCopy();
                    if (RelativeRiskElement != null) dest.RelativeRiskElement = (FhirDecimal)RelativeRiskElement.DeepCopy();
                    if (When != null) dest.When = (Element)When.DeepCopy();
                    if (RationaleElement != null) dest.RationaleElement = (FhirString)RationaleElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PredictionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PredictionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
                if (!DeepComparable.Matches(Probability, otherT.Probability)) return false;
                if (!DeepComparable.Matches(QualitativeRisk, otherT.QualitativeRisk)) return false;
                if (!DeepComparable.Matches(RelativeRiskElement, otherT.RelativeRiskElement)) return false;
                if (!DeepComparable.Matches(When, otherT.When)) return false;
                if (!DeepComparable.Matches(RationaleElement, otherT.RationaleElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PredictionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
                if (!DeepComparable.IsExactly(Probability, otherT.Probability)) return false;
                if (!DeepComparable.IsExactly(QualitativeRisk, otherT.QualitativeRisk)) return false;
                if (!DeepComparable.IsExactly(RelativeRiskElement, otherT.RelativeRiskElement)) return false;
                if (!DeepComparable.IsExactly(When, otherT.When)) return false;
                if (!DeepComparable.IsExactly(RationaleElement, otherT.RationaleElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Outcome != null) yield return Outcome;
                    if (Probability != null) yield return Probability;
                    if (QualitativeRisk != null) yield return QualitativeRisk;
                    if (RelativeRiskElement != null) yield return RelativeRiskElement;
                    if (When != null) yield return When;
                    if (RationaleElement != null) yield return RationaleElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                    if (Probability != null) yield return new ElementValue("probability", Probability);
                    if (QualitativeRisk != null) yield return new ElementValue("qualitativeRisk", QualitativeRisk);
                    if (RelativeRiskElement != null) yield return new ElementValue("relativeRisk", RelativeRiskElement);
                    if (When != null) yield return new ElementValue("when", When);
                    if (RationaleElement != null) yield return new ElementValue("rationale", RationaleElement);
                }
            }


        }


        /// <summary>
        /// Unique identifier for the assessment
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
        /// Request fulfilled by this assessment
        /// </summary>
        [FhirElement("basedOn", Order=100)]
        [DataMember]
        public ResourceReference BasedOn
        {
            get { return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private ResourceReference _basedOn;

        /// <summary>
        /// Part of this occurrence
        /// </summary>
        [FhirElement("parent", Order=110)]
        [DataMember]
        public ResourceReference Parent
        {
            get { return _parent; }
            set { _parent = value; OnPropertyChanged("Parent"); }
        }

        private ResourceReference _parent;

        /// <summary>
        /// registered | preliminary | final | amended +
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ObservationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ObservationStatus> _statusElement;

        /// <summary>
        /// registered | preliminary | final | amended +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ObservationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ObservationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Evaluation mechanism
        /// </summary>
        [FhirElement("method", InSummary=true, Order=130)]
        [DataMember]
        public CodeableConcept Method
        {
            get { return _method; }
            set { _method = value; OnPropertyChanged("Method"); }
        }

        private CodeableConcept _method;

        /// <summary>
        /// Type of assessment
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
        /// Who/what does assessment apply to?
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=150)]
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
        /// Where was assessment performed?
        /// </summary>
        [FhirElement("context", InSummary=true, Order=160)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When was assessment made?
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [DataMember]
        public Element Occurrence
        {
            get { return _occurrence; }
            set { _occurrence = value; OnPropertyChanged("Occurrence"); }
        }

        private Element _occurrence;

        /// <summary>
        /// Condition assessed
        /// </summary>
        [FhirElement("condition", InSummary=true, Order=180)]
        [References("Condition")]
        [DataMember]
        public ResourceReference Condition
        {
            get { return _condition; }
            set { _condition = value; OnPropertyChanged("Condition"); }
        }

        private ResourceReference _condition;

        /// <summary>
        /// Who did assessment?
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=190)]
        [References("Practitioner","Device")]
        [DataMember]
        public ResourceReference Performer
        {
            get { return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private ResourceReference _performer;

        /// <summary>
        /// Why the assessment was necessary?
        /// </summary>
        [FhirElement("reasonCode", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Why the assessment was necessary?
        /// </summary>
        [FhirElement("reasonReference", Order=210)]
        [References("Condition","Observation","DiagnosticReport","DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// Information used in assessment
        /// </summary>
        [FhirElement("basis", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Basis
        {
            get { if (_basis==null) _basis = new List<ResourceReference>(); return _basis; }
            set { _basis = value; OnPropertyChanged("Basis"); }
        }

        private List<ResourceReference> _basis;

        /// <summary>
        /// Outcome predicted
        /// </summary>
        [FhirElement("prediction", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PredictionComponent> Prediction
        {
            get { if (_prediction==null) _prediction = new List<PredictionComponent>(); return _prediction; }
            set { _prediction = value; OnPropertyChanged("Prediction"); }
        }

        private List<PredictionComponent> _prediction;

        /// <summary>
        /// How to reduce risk
        /// </summary>
        [FhirElement("mitigation", Order=240)]
        [DataMember]
        public FhirString MitigationElement
        {
            get { return _mitigationElement; }
            set { _mitigationElement = value; OnPropertyChanged("MitigationElement"); }
        }

        private FhirString _mitigationElement;

        /// <summary>
        /// How to reduce risk
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Mitigation
        {
            get { return MitigationElement != null ? MitigationElement.Value : null; }
            set
            {
                if (value == null)
                    MitigationElement = null;
                else
                    MitigationElement = new FhirString(value);
                OnPropertyChanged("Mitigation");
            }
        }

        /// <summary>
        /// Comments on the risk assessment
        /// </summary>
        [FhirElement("note", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;


        public static ElementDefinition.ConstraintComponent RiskAssessment_RAS_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "prediction.all(probability is decimal implies (probability as decimal) <= 100)",
            Key = "ras-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Must be <= 100",
            Xpath = "not(f:probabilityDecimal) or f:probabilityDecimal/@value <= 100"
        };

        public static ElementDefinition.ConstraintComponent RiskAssessment_RAS_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "prediction.probability.all((low.empty() or ((low.code = '%') and (low.system = %ucum))) and (high.empty() or ((high.code = '%') and (high.system = %ucum))))",
            Key = "ras-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "low and high must be percentages, if present",
            Xpath = "(not(f:low) or f:low[f:code/@value='%' and f:system/@value='http://unitsofmeasure.org']) and (not(f:high) or f:high[f:code/@value='%' and f:system/@value='http://unitsofmeasure.org'])"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(RiskAssessment_RAS_2);
            InvariantConstraints.Add(RiskAssessment_RAS_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as RiskAssessment;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (BasedOn != null) dest.BasedOn = (ResourceReference)BasedOn.DeepCopy();
                if (Parent != null) dest.Parent = (ResourceReference)Parent.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ObservationStatus>)StatusElement.DeepCopy();
                if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                if (Condition != null) dest.Condition = (ResourceReference)Condition.DeepCopy();
                if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (Basis != null) dest.Basis = new List<ResourceReference>(Basis.DeepCopy());
                if (Prediction != null) dest.Prediction = new List<PredictionComponent>(Prediction.DeepCopy());
                if (MitigationElement != null) dest.MitigationElement = (FhirString)MitigationElement.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new RiskAssessment());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as RiskAssessment;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.Matches(Parent, otherT.Parent)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Method, otherT.Method)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.Matches(Condition, otherT.Condition)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if ( !DeepComparable.Matches(Basis, otherT.Basis)) return false;
            if ( !DeepComparable.Matches(Prediction, otherT.Prediction)) return false;
            if (!DeepComparable.Matches(MitigationElement, otherT.MitigationElement)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as RiskAssessment;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Parent, otherT.Parent)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.IsExactly(Condition, otherT.Condition)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(Basis, otherT.Basis)) return false;
            if (!DeepComparable.IsExactly(Prediction, otherT.Prediction)) return false;
            if (!DeepComparable.IsExactly(MitigationElement, otherT.MitigationElement)) return false;
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
                if (BasedOn != null) yield return BasedOn;
                if (Parent != null) yield return Parent;
                if (StatusElement != null) yield return StatusElement;
                if (Method != null) yield return Method;
                if (Code != null) yield return Code;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Occurrence != null) yield return Occurrence;
                if (Condition != null) yield return Condition;
                if (Performer != null) yield return Performer;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in Basis) { if (elem != null) yield return elem; }
                foreach (var elem in Prediction) { if (elem != null) yield return elem; }
                if (MitigationElement != null) yield return MitigationElement;
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
                if (BasedOn != null) yield return new ElementValue("basedOn", BasedOn);
                if (Parent != null) yield return new ElementValue("parent", Parent);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Method != null) yield return new ElementValue("method", Method);
                if (Code != null) yield return new ElementValue("code", Code);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                if (Condition != null) yield return new ElementValue("condition", Condition);
                if (Performer != null) yield return new ElementValue("performer", Performer);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                foreach (var elem in Basis) { if (elem != null) yield return new ElementValue("basis", elem); }
                foreach (var elem in Prediction) { if (elem != null) yield return new ElementValue("prediction", elem); }
                if (MitigationElement != null) yield return new ElementValue("mitigation", MitigationElement);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
