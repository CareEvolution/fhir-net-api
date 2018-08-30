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
    /// Guidance or advice relating to an immunization
    /// </summary>
    [FhirType("ImmunizationRecommendation", IsResource=true)]
    [DataContract]
    public partial class ImmunizationRecommendation : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImmunizationRecommendation; } }
        [NotMapped]
        public override string TypeName { get { return "ImmunizationRecommendation"; } }


        [FhirType("RecommendationComponent")]
        [DataContract]
        public partial class RecommendationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RecommendationComponent"; } }

            /// <summary>
            /// Vaccine  or vaccine group recommendation applies to
            /// </summary>
            [FhirElement("vaccineCode", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> VaccineCode
            {
                get { if (_vaccineCode==null) _vaccineCode = new List<CodeableConcept>(); return _vaccineCode; }
                set { _vaccineCode = value; OnPropertyChanged("VaccineCode"); }
            }

            private List<CodeableConcept> _vaccineCode;

            /// <summary>
            /// Disease to be immunized against
            /// </summary>
            [FhirElement("targetDisease", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept TargetDisease
            {
                get { return _targetDisease; }
                set { _targetDisease = value; OnPropertyChanged("TargetDisease"); }
            }

            private CodeableConcept _targetDisease;

            /// <summary>
            /// Vaccine which is contraindicated to fulfill the recommendation
            /// </summary>
            [FhirElement("contraindicatedVaccineCode", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ContraindicatedVaccineCode
            {
                get { if (_contraindicatedVaccineCode==null) _contraindicatedVaccineCode = new List<CodeableConcept>(); return _contraindicatedVaccineCode; }
                set { _contraindicatedVaccineCode = value; OnPropertyChanged("ContraindicatedVaccineCode"); }
            }

            private List<CodeableConcept> _contraindicatedVaccineCode;

            /// <summary>
            /// Vaccine recommendation status
            /// </summary>
            [FhirElement("forecastStatus", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept ForecastStatus
            {
                get { return _forecastStatus; }
                set { _forecastStatus = value; OnPropertyChanged("ForecastStatus"); }
            }

            private CodeableConcept _forecastStatus;

            /// <summary>
            /// Vaccine administration status reason
            /// </summary>
            [FhirElement("forecastReason", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ForecastReason
            {
                get { if (_forecastReason==null) _forecastReason = new List<CodeableConcept>(); return _forecastReason; }
                set { _forecastReason = value; OnPropertyChanged("ForecastReason"); }
            }

            private List<CodeableConcept> _forecastReason;

            /// <summary>
            /// Dates governing proposed immunization
            /// </summary>
            [FhirElement("dateCriterion", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DateCriterionComponent> DateCriterion
            {
                get { if (_dateCriterion==null) _dateCriterion = new List<DateCriterionComponent>(); return _dateCriterion; }
                set { _dateCriterion = value; OnPropertyChanged("DateCriterion"); }
            }

            private List<DateCriterionComponent> _dateCriterion;

            /// <summary>
            /// Protocol details
            /// </summary>
            [FhirElement("description", Order=100)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Protocol details
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        DescriptionElement = null;
                    else
                        DescriptionElement = new FhirString(value);
                    OnPropertyChanged("Description");
                }
            }

            /// <summary>
            /// Name of vaccination series
            /// </summary>
            [FhirElement("series", Order=110)]
            [DataMember]
            public FhirString SeriesElement
            {
                get { return _seriesElement; }
                set { _seriesElement = value; OnPropertyChanged("SeriesElement"); }
            }

            private FhirString _seriesElement;

            /// <summary>
            /// Name of vaccination series
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Series
            {
                get { return SeriesElement != null ? SeriesElement.Value : null; }
                set
                {
                    if (value == null)
                        SeriesElement = null;
                    else
                        SeriesElement = new FhirString(value);
                    OnPropertyChanged("Series");
                }
            }

            /// <summary>
            /// Recommended dose number within series
            /// </summary>
            [FhirElement("doseNumber", InSummary=true, Order=120, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(PositiveInt),typeof(FhirString))]
            [DataMember]
            public Element DoseNumber
            {
                get { return _doseNumber; }
                set { _doseNumber = value; OnPropertyChanged("DoseNumber"); }
            }

            private Element _doseNumber;

            /// <summary>
            /// Recommended number of doses for immunity
            /// </summary>
            [FhirElement("seriesDoses", Order=130, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(PositiveInt),typeof(FhirString))]
            [DataMember]
            public Element SeriesDoses
            {
                get { return _seriesDoses; }
                set { _seriesDoses = value; OnPropertyChanged("SeriesDoses"); }
            }

            private Element _seriesDoses;

            /// <summary>
            /// Past immunizations supporting recommendation
            /// </summary>
            [FhirElement("supportingImmunization", Order=140)]
            [References("Immunization","ImmunizationEvaluation")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> SupportingImmunization
            {
                get { if (_supportingImmunization==null) _supportingImmunization = new List<ResourceReference>(); return _supportingImmunization; }
                set { _supportingImmunization = value; OnPropertyChanged("SupportingImmunization"); }
            }

            private List<ResourceReference> _supportingImmunization;

            /// <summary>
            /// Patient observations supporting recommendation
            /// </summary>
            [FhirElement("supportingPatientInformation", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> SupportingPatientInformation
            {
                get { if (_supportingPatientInformation==null) _supportingPatientInformation = new List<ResourceReference>(); return _supportingPatientInformation; }
                set { _supportingPatientInformation = value; OnPropertyChanged("SupportingPatientInformation"); }
            }

            private List<ResourceReference> _supportingPatientInformation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RecommendationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (VaccineCode != null) dest.VaccineCode = new List<CodeableConcept>(VaccineCode.DeepCopy());
                    if (TargetDisease != null) dest.TargetDisease = (CodeableConcept)TargetDisease.DeepCopy();
                    if (ContraindicatedVaccineCode != null) dest.ContraindicatedVaccineCode = new List<CodeableConcept>(ContraindicatedVaccineCode.DeepCopy());
                    if (ForecastStatus != null) dest.ForecastStatus = (CodeableConcept)ForecastStatus.DeepCopy();
                    if (ForecastReason != null) dest.ForecastReason = new List<CodeableConcept>(ForecastReason.DeepCopy());
                    if (DateCriterion != null) dest.DateCriterion = new List<DateCriterionComponent>(DateCriterion.DeepCopy());
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (SeriesElement != null) dest.SeriesElement = (FhirString)SeriesElement.DeepCopy();
                    if (DoseNumber != null) dest.DoseNumber = (Element)DoseNumber.DeepCopy();
                    if (SeriesDoses != null) dest.SeriesDoses = (Element)SeriesDoses.DeepCopy();
                    if (SupportingImmunization != null) dest.SupportingImmunization = new List<ResourceReference>(SupportingImmunization.DeepCopy());
                    if (SupportingPatientInformation != null) dest.SupportingPatientInformation = new List<ResourceReference>(SupportingPatientInformation.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RecommendationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RecommendationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(VaccineCode, otherT.VaccineCode)) return false;
                if (!DeepComparable.Matches(TargetDisease, otherT.TargetDisease)) return false;
                if ( !DeepComparable.Matches(ContraindicatedVaccineCode, otherT.ContraindicatedVaccineCode)) return false;
                if (!DeepComparable.Matches(ForecastStatus, otherT.ForecastStatus)) return false;
                if ( !DeepComparable.Matches(ForecastReason, otherT.ForecastReason)) return false;
                if ( !DeepComparable.Matches(DateCriterion, otherT.DateCriterion)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;
                if (!DeepComparable.Matches(DoseNumber, otherT.DoseNumber)) return false;
                if (!DeepComparable.Matches(SeriesDoses, otherT.SeriesDoses)) return false;
                if ( !DeepComparable.Matches(SupportingImmunization, otherT.SupportingImmunization)) return false;
                if ( !DeepComparable.Matches(SupportingPatientInformation, otherT.SupportingPatientInformation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RecommendationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(VaccineCode, otherT.VaccineCode)) return false;
                if (!DeepComparable.IsExactly(TargetDisease, otherT.TargetDisease)) return false;
                if (!DeepComparable.IsExactly(ContraindicatedVaccineCode, otherT.ContraindicatedVaccineCode)) return false;
                if (!DeepComparable.IsExactly(ForecastStatus, otherT.ForecastStatus)) return false;
                if (!DeepComparable.IsExactly(ForecastReason, otherT.ForecastReason)) return false;
                if (!DeepComparable.IsExactly(DateCriterion, otherT.DateCriterion)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;
                if (!DeepComparable.IsExactly(DoseNumber, otherT.DoseNumber)) return false;
                if (!DeepComparable.IsExactly(SeriesDoses, otherT.SeriesDoses)) return false;
                if (!DeepComparable.IsExactly(SupportingImmunization, otherT.SupportingImmunization)) return false;
                if (!DeepComparable.IsExactly(SupportingPatientInformation, otherT.SupportingPatientInformation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in VaccineCode) { if (elem != null) yield return elem; }
                    if (TargetDisease != null) yield return TargetDisease;
                    foreach (var elem in ContraindicatedVaccineCode) { if (elem != null) yield return elem; }
                    if (ForecastStatus != null) yield return ForecastStatus;
                    foreach (var elem in ForecastReason) { if (elem != null) yield return elem; }
                    foreach (var elem in DateCriterion) { if (elem != null) yield return elem; }
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (SeriesElement != null) yield return SeriesElement;
                    if (DoseNumber != null) yield return DoseNumber;
                    if (SeriesDoses != null) yield return SeriesDoses;
                    foreach (var elem in SupportingImmunization) { if (elem != null) yield return elem; }
                    foreach (var elem in SupportingPatientInformation) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in VaccineCode) { if (elem != null) yield return new ElementValue("vaccineCode", elem); }
                    if (TargetDisease != null) yield return new ElementValue("targetDisease", TargetDisease);
                    foreach (var elem in ContraindicatedVaccineCode) { if (elem != null) yield return new ElementValue("contraindicatedVaccineCode", elem); }
                    if (ForecastStatus != null) yield return new ElementValue("forecastStatus", ForecastStatus);
                    foreach (var elem in ForecastReason) { if (elem != null) yield return new ElementValue("forecastReason", elem); }
                    foreach (var elem in DateCriterion) { if (elem != null) yield return new ElementValue("dateCriterion", elem); }
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (SeriesElement != null) yield return new ElementValue("series", SeriesElement);
                    if (DoseNumber != null) yield return new ElementValue("doseNumber", DoseNumber);
                    if (SeriesDoses != null) yield return new ElementValue("seriesDoses", SeriesDoses);
                    foreach (var elem in SupportingImmunization) { if (elem != null) yield return new ElementValue("supportingImmunization", elem); }
                    foreach (var elem in SupportingPatientInformation) { if (elem != null) yield return new ElementValue("supportingPatientInformation", elem); }
                }
            }


        }


        [FhirType("DateCriterionComponent")]
        [DataContract]
        public partial class DateCriterionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DateCriterionComponent"; } }

            /// <summary>
            /// Type of date
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Recommended date
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirDateTime ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirDateTime _valueElement;

            /// <summary>
            /// Recommended date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirDateTime(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DateCriterionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirDateTime)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DateCriterionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DateCriterionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DateCriterionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        /// <summary>
        /// Business identifier
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
        /// Who this profile is for
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
        /// Date recommendation(s) created
        /// </summary>
        [FhirElement("date", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date recommendation(s) created
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
        /// Who is responsible for protocol
        /// </summary>
        [FhirElement("authority", Order=120)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Authority
        {
            get { return _authority; }
            set { _authority = value; OnPropertyChanged("Authority"); }
        }

        private ResourceReference _authority;

        /// <summary>
        /// Vaccine administration recommendations
        /// </summary>
        [FhirElement("recommendation", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<RecommendationComponent> Recommendation
        {
            get { if (_recommendation==null) _recommendation = new List<RecommendationComponent>(); return _recommendation; }
            set { _recommendation = value; OnPropertyChanged("Recommendation"); }
        }

        private List<RecommendationComponent> _recommendation;


        public static ElementDefinition.ConstraintComponent ImmunizationRecommendation_IMR_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "recommendation.all(vaccineCode.exists() or targetDisease.exists())",
            Key = "imr-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "One of vaccineCode or targetDisease SHALL be present",
            Xpath = "exists(f:vaccineCode) or exists(f:targetDisease)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ImmunizationRecommendation_IMR_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImmunizationRecommendation;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Authority != null) dest.Authority = (ResourceReference)Authority.DeepCopy();
                if (Recommendation != null) dest.Recommendation = new List<RecommendationComponent>(Recommendation.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ImmunizationRecommendation());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ImmunizationRecommendation;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Authority, otherT.Authority)) return false;
            if ( !DeepComparable.Matches(Recommendation, otherT.Recommendation)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImmunizationRecommendation;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
            if (!DeepComparable.IsExactly(Recommendation, otherT.Recommendation)) return false;

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
                if (DateElement != null) yield return DateElement;
                if (Authority != null) yield return Authority;
                foreach (var elem in Recommendation) { if (elem != null) yield return elem; }
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
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Authority != null) yield return new ElementValue("authority", Authority);
                foreach (var elem in Recommendation) { if (elem != null) yield return new ElementValue("recommendation", elem); }
            }
        }

    }

}
