﻿using System;
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
    /// Guidance or advice relating to an immunization
    /// </summary>
    [FhirType("ImmunizationRecommendation", IsResource = true)]
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
            /// Date recommendation created
            /// </summary>
            [FhirElement("date", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public FhirDateTime DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private FhirDateTime _dateElement;

            /// <summary>
            /// Date recommendation created
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
            /// Vaccine recommendation applies to
            /// </summary>
            [FhirElement("vaccineCode", InSummary = true, Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public CodeableConcept VaccineCode
            {
                get { return _vaccineCode; }
                set { _vaccineCode = value; OnPropertyChanged("VaccineCode"); }
            }

            private CodeableConcept _vaccineCode;

            /// <summary>
            /// Recommended dose number
            /// </summary>
            [FhirElement("doseNumber", InSummary = true, Order = 60)]
            [DataMember]
            public PositiveInt DoseNumberElement
            {
                get { return _doseNumberElement; }
                set { _doseNumberElement = value; OnPropertyChanged("DoseNumberElement"); }
            }

            private PositiveInt _doseNumberElement;

            /// <summary>
            /// Recommended dose number
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? DoseNumber
            {
                get { return DoseNumberElement != null ? DoseNumberElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        DoseNumberElement = null;
                    else
                        DoseNumberElement = new PositiveInt(value);
                    OnPropertyChanged("DoseNumber");
                }
            }

            /// <summary>
            /// Vaccine administration status
            /// </summary>
            [FhirElement("forecastStatus", InSummary = true, Order = 70)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public CodeableConcept ForecastStatus
            {
                get { return _forecastStatus; }
                set { _forecastStatus = value; OnPropertyChanged("ForecastStatus"); }
            }

            private CodeableConcept _forecastStatus;

            /// <summary>
            /// Dates governing proposed immunization
            /// </summary>
            [FhirElement("dateCriterion", Order = 80)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<DateCriterionComponent> DateCriterion
            {
                get { if (_dateCriterion == null) _dateCriterion = new List<DateCriterionComponent>(); return _dateCriterion; }
                set { _dateCriterion = value; OnPropertyChanged("DateCriterion"); }
            }

            private List<DateCriterionComponent> _dateCriterion;

            /// <summary>
            /// Protocol used by recommendation
            /// </summary>
            [FhirElement("protocol", Order = 90)]
            [DataMember]
            public ProtocolComponent Protocol
            {
                get { return _protocol; }
                set { _protocol = value; OnPropertyChanged("Protocol"); }
            }

            private ProtocolComponent _protocol;

            /// <summary>
            /// Past immunizations supporting recommendation
            /// </summary>
            [FhirElement("supportingImmunization", Order = 100)]
            [References("Immunization")]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<ResourceReference> SupportingImmunization
            {
                get { if (_supportingImmunization == null) _supportingImmunization = new List<ResourceReference>(); return _supportingImmunization; }
                set { _supportingImmunization = value; OnPropertyChanged("SupportingImmunization"); }
            }

            private List<ResourceReference> _supportingImmunization;

            /// <summary>
            /// Patient observations supporting recommendation
            /// </summary>
            [FhirElement("supportingPatientInformation", Order = 110)]
            [References("Observation", "AllergyIntolerance")]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<ResourceReference> SupportingPatientInformation
            {
                get { if (_supportingPatientInformation == null) _supportingPatientInformation = new List<ResourceReference>(); return _supportingPatientInformation; }
                set { _supportingPatientInformation = value; OnPropertyChanged("SupportingPatientInformation"); }
            }

            private List<ResourceReference> _supportingPatientInformation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RecommendationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                    if (VaccineCode != null) dest.VaccineCode = (CodeableConcept)VaccineCode.DeepCopy();
                    if (DoseNumberElement != null) dest.DoseNumberElement = (PositiveInt)DoseNumberElement.DeepCopy();
                    if (ForecastStatus != null) dest.ForecastStatus = (CodeableConcept)ForecastStatus.DeepCopy();
                    if (DateCriterion != null) dest.DateCriterion = new List<DateCriterionComponent>(DateCriterion.DeepCopy());
                    if (Protocol != null) dest.Protocol = (ProtocolComponent)Protocol.DeepCopy();
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
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(VaccineCode, otherT.VaccineCode)) return false;
                if (!DeepComparable.Matches(DoseNumberElement, otherT.DoseNumberElement)) return false;
                if (!DeepComparable.Matches(ForecastStatus, otherT.ForecastStatus)) return false;
                if (!DeepComparable.Matches(DateCriterion, otherT.DateCriterion)) return false;
                if (!DeepComparable.Matches(Protocol, otherT.Protocol)) return false;
                if (!DeepComparable.Matches(SupportingImmunization, otherT.SupportingImmunization)) return false;
                if (!DeepComparable.Matches(SupportingPatientInformation, otherT.SupportingPatientInformation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RecommendationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(VaccineCode, otherT.VaccineCode)) return false;
                if (!DeepComparable.IsExactly(DoseNumberElement, otherT.DoseNumberElement)) return false;
                if (!DeepComparable.IsExactly(ForecastStatus, otherT.ForecastStatus)) return false;
                if (!DeepComparable.IsExactly(DateCriterion, otherT.DateCriterion)) return false;
                if (!DeepComparable.IsExactly(Protocol, otherT.Protocol)) return false;
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
                    if (DateElement != null) yield return DateElement;
                    if (VaccineCode != null) yield return VaccineCode;
                    if (DoseNumberElement != null) yield return DoseNumberElement;
                    if (ForecastStatus != null) yield return ForecastStatus;
                    foreach (var elem in DateCriterion) { if (elem != null) yield return elem; }
                    if (Protocol != null) yield return Protocol;
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
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                    if (VaccineCode != null) yield return new ElementValue("vaccineCode", VaccineCode);
                    if (DoseNumberElement != null) yield return new ElementValue("doseNumber", DoseNumberElement);
                    if (ForecastStatus != null) yield return new ElementValue("forecastStatus", ForecastStatus);
                    foreach (var elem in DateCriterion) { if (elem != null) yield return new ElementValue("dateCriterion", elem); }
                    if (Protocol != null) yield return new ElementValue("protocol", Protocol);
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
            [FhirElement("code", Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
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
            [FhirElement("value", Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
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


        [FhirType("ProtocolComponent")]
        [DataContract]
        public partial class ProtocolComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ProtocolComponent"; } }

            /// <summary>
            /// Dose number within sequence
            /// </summary>
            [FhirElement("doseSequence", Order = 40)]
            [DataMember]
            public Integer DoseSequenceElement
            {
                get { return _doseSequenceElement; }
                set { _doseSequenceElement = value; OnPropertyChanged("DoseSequenceElement"); }
            }

            private Integer _doseSequenceElement;

            /// <summary>
            /// Dose number within sequence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? DoseSequence
            {
                get { return DoseSequenceElement != null ? DoseSequenceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        DoseSequenceElement = null;
                    else
                        DoseSequenceElement = new Integer(value);
                    OnPropertyChanged("DoseSequence");
                }
            }

            /// <summary>
            /// Protocol details
            /// </summary>
            [FhirElement("description", Order = 50)]
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
            /// Who is responsible for protocol
            /// </summary>
            [FhirElement("authority", Order = 60)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Authority
            {
                get { return _authority; }
                set { _authority = value; OnPropertyChanged("Authority"); }
            }

            private ResourceReference _authority;

            /// <summary>
            /// Name of vaccination series
            /// </summary>
            [FhirElement("series", Order = 70)]
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProtocolComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DoseSequenceElement != null) dest.DoseSequenceElement = (Integer)DoseSequenceElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Authority != null) dest.Authority = (ResourceReference)Authority.DeepCopy();
                    if (SeriesElement != null) dest.SeriesElement = (FhirString)SeriesElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ProtocolComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProtocolComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DoseSequenceElement, otherT.DoseSequenceElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Authority, otherT.Authority)) return false;
                if (!DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProtocolComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DoseSequenceElement, otherT.DoseSequenceElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
                if (!DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DoseSequenceElement != null) yield return DoseSequenceElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Authority != null) yield return Authority;
                    if (SeriesElement != null) yield return SeriesElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DoseSequenceElement != null) yield return new ElementValue("doseSequence", DoseSequenceElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Authority != null) yield return new ElementValue("authority", Authority);
                    if (SeriesElement != null) yield return new ElementValue("series", SeriesElement);
                }
            }


        }


        /// <summary>
        /// Business identifier
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
        /// Who this profile is for
        /// </summary>
        [FhirElement("patient", InSummary = true, Order = 100)]
        [References("Patient")]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Vaccine administration recommendations
        /// </summary>
        [FhirElement("recommendation", InSummary = true, Order = 110)]
        [Cardinality(Min = 1, Max = -1)]
        [DataMember]
        public List<RecommendationComponent> Recommendation
        {
            get { if (_recommendation == null) _recommendation = new List<RecommendationComponent>(); return _recommendation; }
            set { _recommendation = value; OnPropertyChanged("Recommendation"); }
        }

        private List<RecommendationComponent> _recommendation;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImmunizationRecommendation;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
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
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Recommendation, otherT.Recommendation)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImmunizationRecommendation;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
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
                foreach (var elem in Recommendation) { if (elem != null) yield return new ElementValue("recommendation", elem); }
            }
        }

    }

}
