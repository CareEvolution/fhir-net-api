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
            [Cardinality(Min=1,Max=1)]
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
            [AllowedTypes(typeof(FhirDecimal),typeof(Range),typeof(CodeableConcept))]
            [DataMember]
            public Element Probability
            {
                get { return _probability; }
                set { _probability = value; OnPropertyChanged("Probability"); }
            }

            private Element _probability;

            /// <summary>
            /// Relative likelihood
            /// </summary>
            [FhirElement("relativeRisk", Order=60)]
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
            [FhirElement("when", Order=70, Choice=ChoiceType.DatatypeChoice)]
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
            [FhirElement("rationale", Order=80)]
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
                    if (RelativeRiskElement != null) yield return new ElementValue("relativeRisk", RelativeRiskElement);
                    if (When != null) yield return new ElementValue("when", When);
                    if (RationaleElement != null) yield return new ElementValue("rationale", RationaleElement);
                }
            }


        }


        /// <summary>
        /// Who/what does assessment apply to?
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=90)]
        [References("Patient","Group")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// When was assessment made?
        /// </summary>
        [FhirElement("date", InSummary=true, Order=100)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// When was assessment made?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Condition assessed
        /// </summary>
        [FhirElement("condition", InSummary=true, Order=110)]
        [References("Condition")]
        [DataMember]
        public ResourceReference Condition
        {
            get { return _condition; }
            set { _condition = value; OnPropertyChanged("Condition"); }
        }

        private ResourceReference _condition;

        /// <summary>
        /// Where was assessment performed?
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=120)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Who did assessment?
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=130)]
        [References("Practitioner","Device")]
        [DataMember]
        public ResourceReference Performer
        {
            get { return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private ResourceReference _performer;

        /// <summary>
        /// Unique identifier for the assessment
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=140)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Evaluation mechanism
        /// </summary>
        [FhirElement("method", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept Method
        {
            get { return _method; }
            set { _method = value; OnPropertyChanged("Method"); }
        }

        private CodeableConcept _method;

        /// <summary>
        /// Information used in assessment
        /// </summary>
        [FhirElement("basis", Order=160)]
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
        [FhirElement("prediction", Order=170)]
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
        [FhirElement("mitigation", Order=180)]
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


        public static ElementDefinition.ConstraintComponent RiskAssessment_RAS_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "prediction.probability.all((low.empty() or ((low.code = '%') and (low.system = %ucum))) and (high.empty() or ((high.code = '%') and (high.system = %ucum))))",
            Key = "ras-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "low and high must be percentages, if present",
            Xpath = "(not(f:low) or f:low[f:code/@value='%' and f:system/@value='http://unitsofmeasure.org']) and (not(f:high) or f:high[f:code/@value='%' and f:system/@value='http://unitsofmeasure.org'])"
        };

        public static ElementDefinition.ConstraintComponent RiskAssessment_RAS_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "prediction.probability.all($this.as(decimal) <= 100)",
            Key = "ras-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Must be <= 100",
            Xpath = "@value <= 100"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(RiskAssessment_RAS_1);
            InvariantConstraints.Add(RiskAssessment_RAS_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as RiskAssessment;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Condition != null) dest.Condition = (ResourceReference)Condition.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                if (Basis != null) dest.Basis = new List<ResourceReference>(Basis.DeepCopy());
                if (Prediction != null) dest.Prediction = new List<PredictionComponent>(Prediction.DeepCopy());
                if (MitigationElement != null) dest.MitigationElement = (FhirString)MitigationElement.DeepCopy();
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
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Condition, otherT.Condition)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Method, otherT.Method)) return false;
            if ( !DeepComparable.Matches(Basis, otherT.Basis)) return false;
            if ( !DeepComparable.Matches(Prediction, otherT.Prediction)) return false;
            if (!DeepComparable.Matches(MitigationElement, otherT.MitigationElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as RiskAssessment;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Condition, otherT.Condition)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
            if (!DeepComparable.IsExactly(Basis, otherT.Basis)) return false;
            if (!DeepComparable.IsExactly(Prediction, otherT.Prediction)) return false;
            if (!DeepComparable.IsExactly(MitigationElement, otherT.MitigationElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Subject != null) yield return Subject;
                if (DateElement != null) yield return DateElement;
                if (Condition != null) yield return Condition;
                if (Encounter != null) yield return Encounter;
                if (Performer != null) yield return Performer;
                if (Identifier != null) yield return Identifier;
                if (Method != null) yield return Method;
                foreach (var elem in Basis) { if (elem != null) yield return elem; }
                foreach (var elem in Prediction) { if (elem != null) yield return elem; }
                if (MitigationElement != null) yield return MitigationElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Condition != null) yield return new ElementValue("condition", Condition);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Performer != null) yield return new ElementValue("performer", Performer);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (Method != null) yield return new ElementValue("method", Method);
                foreach (var elem in Basis) { if (elem != null) yield return new ElementValue("basis", elem); }
                foreach (var elem in Prediction) { if (elem != null) yield return new ElementValue("prediction", elem); }
                if (MitigationElement != null) yield return new ElementValue("mitigation", MitigationElement);
            }
        }

    }

}
