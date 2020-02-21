﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Utility;

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
    [FhirType(Hl7.Fhir.Model.Version.DSTU2, "RiskAssessment", IsResource=true)]
    [DataContract]
    public partial class RiskAssessment : Hl7.Fhir.Model.DomainResource, Hl7.Fhir.Model.IRiskAssessment, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.RiskAssessment; } }
        [NotMapped]
        public override string TypeName { get { return "RiskAssessment"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.DSTU2, "PredictionComponent")]
        [DataContract]
        public partial class PredictionComponent : Hl7.Fhir.Model.BackboneElement, Hl7.Fhir.Model.IRiskAssessmentPredictionComponent, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "PredictionComponent"; } }
            
            /// <summary>
            /// Possible outcome for the subject
            /// </summary>
            [FhirElement("outcome", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Outcome
            {
                get { return _Outcome; }
                set { _Outcome = value; OnPropertyChanged("Outcome"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Outcome;
            
            /// <summary>
            /// Likelihood of specified outcome
            /// </summary>
            [FhirElement("probability", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDecimal),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.CodeableConcept))]
            [DataMember]
            public Hl7.Fhir.Model.Element Probability
            {
                get { return _Probability; }
                set { _Probability = value; OnPropertyChanged("Probability"); }
            }
            
            private Hl7.Fhir.Model.Element _Probability;
            
            /// <summary>
            /// Relative likelihood
            /// </summary>
            [FhirElement("relativeRisk", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDecimal RelativeRiskElement
            {
                get { return _RelativeRiskElement; }
                set { _RelativeRiskElement = value; OnPropertyChanged("RelativeRiskElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDecimal _RelativeRiskElement;
            
            /// <summary>
            /// Relative likelihood
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? RelativeRisk
            {
                get { return RelativeRiskElement != null ? RelativeRiskElement.Value : null; }
                set
                {
                    if (value == null)
                        RelativeRiskElement = null;
                    else
                        RelativeRiskElement = new Hl7.Fhir.Model.FhirDecimal(value);
                    OnPropertyChanged("RelativeRisk");
                }
            }
            
            /// <summary>
            /// Timeframe or age range
            /// </summary>
            [FhirElement("when", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Period),typeof(Hl7.Fhir.Model.Range))]
            [DataMember]
            public Hl7.Fhir.Model.Element When
            {
                get { return _When; }
                set { _When = value; OnPropertyChanged("When"); }
            }
            
            private Hl7.Fhir.Model.Element _When;
            
            /// <summary>
            /// Explanation of prediction
            /// </summary>
            [FhirElement("rationale", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString RationaleElement
            {
                get { return _RationaleElement; }
                set { _RationaleElement = value; OnPropertyChanged("RationaleElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _RationaleElement;
            
            /// <summary>
            /// Explanation of prediction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Rationale
            {
                get { return RationaleElement != null ? RationaleElement.Value : null; }
                set
                {
                    if (value == null)
                        RationaleElement = null;
                    else
                        RationaleElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Rationale");
                }
            }
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("PredictionComponent");
                base.Serialize(sink);
                sink.Element("outcome", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Outcome?.Serialize(sink);
                sink.Element("probability", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, true); Probability?.Serialize(sink);
                sink.Element("relativeRisk", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); RelativeRiskElement?.Serialize(sink);
                sink.Element("when", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, true); When?.Serialize(sink);
                sink.Element("rationale", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); RationaleElement?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Outcome = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("outcome", Hl7.Fhir.Model.Version.All);
                Probability = source.GetProperty<Hl7.Fhir.Model.Element>("probability", Hl7.Fhir.Model.Version.All);
                RelativeRiskElement = source.GetProperty<Hl7.Fhir.Model.FhirDecimal>("relativeRisk", Hl7.Fhir.Model.Version.All);
                When = source.GetProperty<Hl7.Fhir.Model.Element>("when", Hl7.Fhir.Model.Version.All);
                RationaleElement = source.GetStringProperty("rationale", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"outcome", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"probability", typeof(Hl7.Fhir.Model.Element)},
                    {"relativeRisk", typeof(Hl7.Fhir.Model.FhirDecimal)},
                    {"when", typeof(Hl7.Fhir.Model.Element)},
                    {"rationale", typeof(Hl7.Fhir.Model.FhirString)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PredictionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Outcome != null) dest.Outcome = (Hl7.Fhir.Model.CodeableConcept)Outcome.DeepCopy();
                    if(Probability != null) dest.Probability = (Hl7.Fhir.Model.Element)Probability.DeepCopy();
                    if(RelativeRiskElement != null) dest.RelativeRiskElement = (Hl7.Fhir.Model.FhirDecimal)RelativeRiskElement.DeepCopy();
                    if(When != null) dest.When = (Hl7.Fhir.Model.Element)When.DeepCopy();
                    if(RationaleElement != null) dest.RationaleElement = (Hl7.Fhir.Model.FhirString)RationaleElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
                if( !DeepComparable.Matches(Probability, otherT.Probability)) return false;
                if( !DeepComparable.Matches(RelativeRiskElement, otherT.RelativeRiskElement)) return false;
                if( !DeepComparable.Matches(When, otherT.When)) return false;
                if( !DeepComparable.Matches(RationaleElement, otherT.RationaleElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PredictionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
                if( !DeepComparable.IsExactly(Probability, otherT.Probability)) return false;
                if( !DeepComparable.IsExactly(RelativeRiskElement, otherT.RelativeRiskElement)) return false;
                if( !DeepComparable.IsExactly(When, otherT.When)) return false;
                if( !DeepComparable.IsExactly(RationaleElement, otherT.RationaleElement)) return false;
            
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
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IRiskAssessmentPredictionComponent> Hl7.Fhir.Model.IRiskAssessment.Prediction { get { return Prediction; } }
    
        
        /// <summary>
        /// Who/what does assessment apply to?
        /// </summary>
        [FhirElement("subject", InSummary=Hl7.Fhir.Model.Version.All, Order=90)]
        [CLSCompliant(false)]
        [References("Patient","Group")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// When was assessment made?
        /// </summary>
        [FhirElement("date", InSummary=Hl7.Fhir.Model.Version.All, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// When was assessment made?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Condition assessed
        /// </summary>
        [FhirElement("condition", InSummary=Hl7.Fhir.Model.Version.All, Order=110)]
        [CLSCompliant(false)]
        [References("Condition")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Condition
        {
            get { return _Condition; }
            set { _Condition = value; OnPropertyChanged("Condition"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Condition;
        
        /// <summary>
        /// Where was assessment performed?
        /// </summary>
        [FhirElement("encounter", InSummary=Hl7.Fhir.Model.Version.All, Order=120)]
        [CLSCompliant(false)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// Who did assessment?
        /// </summary>
        [FhirElement("performer", InSummary=Hl7.Fhir.Model.Version.All, Order=130)]
        [CLSCompliant(false)]
        [References("Practitioner","Device")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Performer
        {
            get { return _Performer; }
            set { _Performer = value; OnPropertyChanged("Performer"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Performer;
        
        /// <summary>
        /// Unique identifier for the assessment
        /// </summary>
        [FhirElement("identifier", InSummary=Hl7.Fhir.Model.Version.All, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.Identifier _Identifier;
        
        /// <summary>
        /// Evaluation mechanism
        /// </summary>
        [FhirElement("method", InSummary=Hl7.Fhir.Model.Version.All, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Method
        {
            get { return _Method; }
            set { _Method = value; OnPropertyChanged("Method"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Method;
        
        /// <summary>
        /// Information used in assessment
        /// </summary>
        [FhirElement("basis", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Basis
        {
            get { if(_Basis==null) _Basis = new List<Hl7.Fhir.Model.ResourceReference>(); return _Basis; }
            set { _Basis = value; OnPropertyChanged("Basis"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Basis;
        
        /// <summary>
        /// Outcome predicted
        /// </summary>
        [FhirElement("prediction", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PredictionComponent> Prediction
        {
            get { if(_Prediction==null) _Prediction = new List<PredictionComponent>(); return _Prediction; }
            set { _Prediction = value; OnPropertyChanged("Prediction"); }
        }
        
        private List<PredictionComponent> _Prediction;
        
        /// <summary>
        /// How to reduce risk
        /// </summary>
        [FhirElement("mitigation", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString MitigationElement
        {
            get { return _MitigationElement; }
            set { _MitigationElement = value; OnPropertyChanged("MitigationElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _MitigationElement;
        
        /// <summary>
        /// How to reduce risk
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Mitigation
        {
            get { return MitigationElement != null ? MitigationElement.Value : null; }
            set
            {
                if (value == null)
                    MitigationElement = null;
                else
                    MitigationElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Mitigation");
            }
        }
    
    
        public static ElementDefinitionConstraint[] RiskAssessment_Constraints =
        {
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.DSTU2},
                key: "ras-1",
                severity: ConstraintSeverity.Warning,
                expression: "prediction.probability.all((low.empty() or ((low.code = '%') and (low.system = %ucum))) and (high.empty() or ((high.code = '%') and (high.system = %ucum))))",
                human: "low and high must be percentages, if present",
                xpath: "(not(f:low) or f:low[f:code/@value='%' and f:system/@value='http://unitsofmeasure.org']) and (not(f:high) or f:high[f:code/@value='%' and f:system/@value='http://unitsofmeasure.org'])"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.DSTU2},
                key: "ras-2",
                severity: ConstraintSeverity.Warning,
                expression: "prediction.probability.all($this.as(decimal) <= 100)",
                human: "Must be <= 100",
                xpath: "@value <= 100"
            ),
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
            InvariantConstraints.AddRange(RiskAssessment_Constraints);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as RiskAssessment;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(Condition != null) dest.Condition = (Hl7.Fhir.Model.ResourceReference)Condition.DeepCopy();
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                if(Performer != null) dest.Performer = (Hl7.Fhir.Model.ResourceReference)Performer.DeepCopy();
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                if(Method != null) dest.Method = (Hl7.Fhir.Model.CodeableConcept)Method.DeepCopy();
                if(Basis != null) dest.Basis = new List<Hl7.Fhir.Model.ResourceReference>(Basis.DeepCopy());
                if(Prediction != null) dest.Prediction = new List<PredictionComponent>(Prediction.DeepCopy());
                if(MitigationElement != null) dest.MitigationElement = (Hl7.Fhir.Model.FhirString)MitigationElement.DeepCopy();
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Condition, otherT.Condition)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Method, otherT.Method)) return false;
            if( !DeepComparable.Matches(Basis, otherT.Basis)) return false;
            if( !DeepComparable.Matches(Prediction, otherT.Prediction)) return false;
            if( !DeepComparable.Matches(MitigationElement, otherT.MitigationElement)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as RiskAssessment;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Condition, otherT.Condition)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
            if( !DeepComparable.IsExactly(Basis, otherT.Basis)) return false;
            if( !DeepComparable.IsExactly(Prediction, otherT.Prediction)) return false;
            if( !DeepComparable.IsExactly(MitigationElement, otherT.MitigationElement)) return false;
        
            return true;
        }
    
        internal override void Serialize(Serialization.SerializerSink sink)
        {
            sink.BeginResource("RiskAssessment");
            base.Serialize(sink);
            sink.Element("subject", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Subject?.Serialize(sink);
            sink.Element("date", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); DateElement?.Serialize(sink);
            sink.Element("condition", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Condition?.Serialize(sink);
            sink.Element("encounter", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Encounter?.Serialize(sink);
            sink.Element("performer", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Performer?.Serialize(sink);
            sink.Element("identifier", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Identifier?.Serialize(sink);
            sink.Element("method", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Method?.Serialize(sink);
            sink.BeginList("basis", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Basis)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("prediction", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Prediction)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("mitigation", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); MitigationElement?.Serialize(sink);
            sink.End();
        }
        
        internal override void Parse(Serialization.IParserSource source)
        {
            base.Parse(source);
            Subject = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("subject", Hl7.Fhir.Model.Version.All);
            DateElement = source.GetDateTimeProperty("date", Hl7.Fhir.Model.Version.All);
            Condition = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("condition", Hl7.Fhir.Model.Version.All);
            Encounter = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("encounter", Hl7.Fhir.Model.Version.All);
            Performer = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("performer", Hl7.Fhir.Model.Version.All);
            Identifier = source.GetProperty<Hl7.Fhir.Model.Identifier>("identifier", Hl7.Fhir.Model.Version.All);
            Method = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("method", Hl7.Fhir.Model.Version.All);
            Basis = source.GetList<Hl7.Fhir.Model.ResourceReference>("basis", Hl7.Fhir.Model.Version.All);
            Prediction = source.GetList<PredictionComponent>("prediction", Hl7.Fhir.Model.Version.All);
            MitigationElement = source.GetStringProperty("mitigation", Hl7.Fhir.Model.Version.All);
        }
        
        internal override Type GetPropertyType(string fhirName)
        {
            if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
            return base.GetPropertyType(fhirName);
        }
        
        private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
        {
                {"subject", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"date", typeof(Hl7.Fhir.Model.FhirDateTime)},
                {"condition", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"encounter", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"performer", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"identifier", typeof(Hl7.Fhir.Model.Identifier)},
                {"method", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"basis", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"prediction", typeof(PredictionComponent)},
                {"mitigation", typeof(Hl7.Fhir.Model.FhirString)},
        };
    
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
