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
    /// Allergy or Intolerance (generally: Risk of adverse reaction to a substance)
    /// </summary>
    [FhirType("AllergyIntolerance", IsResource=true)]
    [DataContract]
    public partial class AllergyIntolerance : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.AllergyIntolerance; } }
        [NotMapped]
        public override string TypeName { get { return "AllergyIntolerance"; } }

        /// <summary>
        /// The clinical status of the allergy or intolerance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-clinical-status)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceClinicalStatus")]
        public enum AllergyIntoleranceClinicalStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-clinical-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/allergy-clinical-status"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-clinical-status)
            /// </summary>
            [EnumLiteral("inactive", "http://hl7.org/fhir/allergy-clinical-status"), Description("Inactive")]
            Inactive,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-clinical-status)
            /// </summary>
            [EnumLiteral("resolved", "http://hl7.org/fhir/allergy-clinical-status"), Description("Resolved")]
            Resolved,
        }

        /// <summary>
        /// Assertion about certainty associated with a propensity, or potential risk, of a reaction to the identified substance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-verification-status)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceVerificationStatus")]
        public enum AllergyIntoleranceVerificationStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-verification-status)
            /// </summary>
            [EnumLiteral("unconfirmed", "http://hl7.org/fhir/allergy-verification-status"), Description("Unconfirmed")]
            Unconfirmed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-verification-status)
            /// </summary>
            [EnumLiteral("confirmed", "http://hl7.org/fhir/allergy-verification-status"), Description("Confirmed")]
            Confirmed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-verification-status)
            /// </summary>
            [EnumLiteral("refuted", "http://hl7.org/fhir/allergy-verification-status"), Description("Refuted")]
            Refuted,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-verification-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/allergy-verification-status"), Description("Entered In Error")]
            EnteredInError,
        }

        /// <summary>
        /// Identification of the underlying physiological mechanism for a Reaction Risk.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-type)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceType")]
        public enum AllergyIntoleranceType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-type)
            /// </summary>
            [EnumLiteral("allergy", "http://hl7.org/fhir/allergy-intolerance-type"), Description("Allergy")]
            Allergy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-type)
            /// </summary>
            [EnumLiteral("intolerance", "http://hl7.org/fhir/allergy-intolerance-type"), Description("Intolerance")]
            Intolerance,
        }

        /// <summary>
        /// Category of an identified substance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-category)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceCategory")]
        public enum AllergyIntoleranceCategory
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("food", "http://hl7.org/fhir/allergy-intolerance-category"), Description("Food")]
            Food,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("medication", "http://hl7.org/fhir/allergy-intolerance-category"), Description("Medication")]
            Medication,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("environment", "http://hl7.org/fhir/allergy-intolerance-category"), Description("Environment")]
            Environment,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("biologic", "http://hl7.org/fhir/allergy-intolerance-category"), Description("Biologic")]
            Biologic,
        }

        /// <summary>
        /// Estimate of the potential clinical harm, or seriousness, of a reaction to an identified substance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-criticality)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceCriticality")]
        public enum AllergyIntoleranceCriticality
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-criticality)
            /// </summary>
            [EnumLiteral("low", "http://hl7.org/fhir/allergy-intolerance-criticality"), Description("Low Risk")]
            Low,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-criticality)
            /// </summary>
            [EnumLiteral("high", "http://hl7.org/fhir/allergy-intolerance-criticality"), Description("High Risk")]
            High,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/allergy-intolerance-criticality)
            /// </summary>
            [EnumLiteral("unable-to-assess", "http://hl7.org/fhir/allergy-intolerance-criticality"), Description("Unable to Assess Risk")]
            UnableToAssess,
        }

        /// <summary>
        /// Clinical assessment of the severity of a reaction event as a whole, potentially considering multiple different manifestations.
        /// (url: http://hl7.org/fhir/ValueSet/reaction-event-severity)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceSeverity")]
        public enum AllergyIntoleranceSeverity
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-severity)
            /// </summary>
            [EnumLiteral("mild", "http://hl7.org/fhir/reaction-event-severity"), Description("Mild")]
            Mild,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-severity)
            /// </summary>
            [EnumLiteral("moderate", "http://hl7.org/fhir/reaction-event-severity"), Description("Moderate")]
            Moderate,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reaction-event-severity)
            /// </summary>
            [EnumLiteral("severe", "http://hl7.org/fhir/reaction-event-severity"), Description("Severe")]
            Severe,
        }


        [FhirType("ReactionComponent")]
        [DataContract]
        public partial class ReactionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ReactionComponent"; } }

            /// <summary>
            /// Specific substance or pharmaceutical product considered to be responsible for event
            /// </summary>
            [FhirElement("substance", Order=40)]
            [DataMember]
            public CodeableConcept Substance
            {
                get { return _substance; }
                set { _substance = value; OnPropertyChanged("Substance"); }
            }

            private CodeableConcept _substance;

            /// <summary>
            /// Clinical symptoms/signs associated with the Event
            /// </summary>
            [FhirElement("manifestation", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Manifestation
            {
                get { if (_manifestation==null) _manifestation = new List<CodeableConcept>(); return _manifestation; }
                set { _manifestation = value; OnPropertyChanged("Manifestation"); }
            }

            private List<CodeableConcept> _manifestation;

            /// <summary>
            /// Description of the event as a whole
            /// </summary>
            [FhirElement("description", Order=60)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Description of the event as a whole
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
            /// Date(/time) when manifestations showed
            /// </summary>
            [FhirElement("onset", Order=70)]
            [DataMember]
            public FhirDateTime OnsetElement
            {
                get { return _onsetElement; }
                set { _onsetElement = value; OnPropertyChanged("OnsetElement"); }
            }

            private FhirDateTime _onsetElement;

            /// <summary>
            /// Date(/time) when manifestations showed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Onset
            {
                get { return OnsetElement != null ? OnsetElement.Value : null; }
                set
                {
                    if (value == null)
                        OnsetElement = null;
                    else
                        OnsetElement = new FhirDateTime(value);
                    OnPropertyChanged("Onset");
                }
            }

            /// <summary>
            /// mild | moderate | severe (of event as a whole)
            /// </summary>
            [FhirElement("severity", Order=80)]
            [DataMember]
            public Code<AllergyIntoleranceSeverity> SeverityElement
            {
                get { return _severityElement; }
                set { _severityElement = value; OnPropertyChanged("SeverityElement"); }
            }

            private Code<AllergyIntoleranceSeverity> _severityElement;

            /// <summary>
            /// mild | moderate | severe (of event as a whole)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AllergyIntoleranceSeverity? Severity
            {
                get { return SeverityElement != null ? SeverityElement.Value : null; }
                set
                {
                    if (value == null)
                        SeverityElement = null;
                    else
                        SeverityElement = new Code<AllergyIntoleranceSeverity>(value);
                    OnPropertyChanged("Severity");
                }
            }

            /// <summary>
            /// How the subject was exposed to the substance
            /// </summary>
            [FhirElement("exposureRoute", Order=90)]
            [DataMember]
            public CodeableConcept ExposureRoute
            {
                get { return _exposureRoute; }
                set { _exposureRoute = value; OnPropertyChanged("ExposureRoute"); }
            }

            private CodeableConcept _exposureRoute;

            /// <summary>
            /// Text about event not captured in other fields
            /// </summary>
            [FhirElement("note", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Annotation> Note
            {
                get { if (_note==null) _note = new List<Annotation>(); return _note; }
                set { _note = value; OnPropertyChanged("Note"); }
            }

            private List<Annotation> _note;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReactionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Substance != null) dest.Substance = (CodeableConcept)Substance.DeepCopy();
                    if (Manifestation != null) dest.Manifestation = new List<CodeableConcept>(Manifestation.DeepCopy());
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (OnsetElement != null) dest.OnsetElement = (FhirDateTime)OnsetElement.DeepCopy();
                    if (SeverityElement != null) dest.SeverityElement = (Code<AllergyIntoleranceSeverity>)SeverityElement.DeepCopy();
                    if (ExposureRoute != null) dest.ExposureRoute = (CodeableConcept)ExposureRoute.DeepCopy();
                    if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ReactionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReactionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Substance, otherT.Substance)) return false;
                if ( !DeepComparable.Matches(Manifestation, otherT.Manifestation)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(OnsetElement, otherT.OnsetElement)) return false;
                if (!DeepComparable.Matches(SeverityElement, otherT.SeverityElement)) return false;
                if (!DeepComparable.Matches(ExposureRoute, otherT.ExposureRoute)) return false;
                if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReactionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
                if (!DeepComparable.IsExactly(Manifestation, otherT.Manifestation)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(OnsetElement, otherT.OnsetElement)) return false;
                if (!DeepComparable.IsExactly(SeverityElement, otherT.SeverityElement)) return false;
                if (!DeepComparable.IsExactly(ExposureRoute, otherT.ExposureRoute)) return false;
                if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Substance != null) yield return Substance;
                    foreach (var elem in Manifestation) { if (elem != null) yield return elem; }
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (OnsetElement != null) yield return OnsetElement;
                    if (SeverityElement != null) yield return SeverityElement;
                    if (ExposureRoute != null) yield return ExposureRoute;
                    foreach (var elem in Note) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Substance != null) yield return new ElementValue("substance", Substance);
                    foreach (var elem in Manifestation) { if (elem != null) yield return new ElementValue("manifestation", elem); }
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (OnsetElement != null) yield return new ElementValue("onset", OnsetElement);
                    if (SeverityElement != null) yield return new ElementValue("severity", SeverityElement);
                    if (ExposureRoute != null) yield return new ElementValue("exposureRoute", ExposureRoute);
                    foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                }
            }


        }


        /// <summary>
        /// External ids for this item
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
        /// active | inactive | resolved
        /// </summary>
        [FhirElement("clinicalStatus", InSummary=true, Order=100)]
        [DataMember]
        public Code<AllergyIntoleranceClinicalStatus> ClinicalStatusElement
        {
            get { return _clinicalStatusElement; }
            set { _clinicalStatusElement = value; OnPropertyChanged("ClinicalStatusElement"); }
        }

        private Code<AllergyIntoleranceClinicalStatus> _clinicalStatusElement;

        /// <summary>
        /// active | inactive | resolved
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AllergyIntoleranceClinicalStatus? ClinicalStatus
        {
            get { return ClinicalStatusElement != null ? ClinicalStatusElement.Value : null; }
            set
            {
                if (value == null)
                    ClinicalStatusElement = null;
                else
                    ClinicalStatusElement = new Code<AllergyIntoleranceClinicalStatus>(value);
                OnPropertyChanged("ClinicalStatus");
            }
        }

        /// <summary>
        /// unconfirmed | confirmed | refuted | entered-in-error
        /// </summary>
        [FhirElement("verificationStatus", InSummary=true, Order=110)]
        [DataMember]
        public Code<AllergyIntoleranceVerificationStatus> VerificationStatusElement
        {
            get { return _verificationStatusElement; }
            set { _verificationStatusElement = value; OnPropertyChanged("VerificationStatusElement"); }
        }

        private Code<AllergyIntoleranceVerificationStatus> _verificationStatusElement;

        /// <summary>
        /// unconfirmed | confirmed | refuted | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AllergyIntoleranceVerificationStatus? VerificationStatus
        {
            get { return VerificationStatusElement != null ? VerificationStatusElement.Value : null; }
            set
            {
                if (value == null)
                    VerificationStatusElement = null;
                else
                    VerificationStatusElement = new Code<AllergyIntoleranceVerificationStatus>(value);
                OnPropertyChanged("VerificationStatus");
            }
        }

        /// <summary>
        /// allergy | intolerance - Underlying mechanism (if known)
        /// </summary>
        [FhirElement("type", InSummary=true, Order=120)]
        [DataMember]
        public Code<AllergyIntoleranceType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<AllergyIntoleranceType> _typeElement;

        /// <summary>
        /// allergy | intolerance - Underlying mechanism (if known)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AllergyIntoleranceType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<AllergyIntoleranceType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// food | medication | environment | biologic
        /// </summary>
        [FhirElement("category", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<AllergyIntoleranceCategory>> CategoryElement
        {
            get { if (_categoryElement==null) _categoryElement = new List<Code<AllergyIntoleranceCategory>>(); return _categoryElement; }
            set { _categoryElement = value; OnPropertyChanged("CategoryElement"); }
        }

        private List<Code<AllergyIntoleranceCategory>> _categoryElement;

        /// <summary>
        /// food | medication | environment | biologic
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<AllergyIntoleranceCategory?> Category
        {
            get { return CategoryElement != null ? CategoryElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    CategoryElement = null;
                else
                    CategoryElement = new List<Code<AllergyIntoleranceCategory>>(value.Select(elem=>new Code<AllergyIntoleranceCategory>(elem)));
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        /// low | high | unable-to-assess
        /// </summary>
        [FhirElement("criticality", InSummary=true, Order=140)]
        [DataMember]
        public Code<AllergyIntoleranceCriticality> CriticalityElement
        {
            get { return _criticalityElement; }
            set { _criticalityElement = value; OnPropertyChanged("CriticalityElement"); }
        }

        private Code<AllergyIntoleranceCriticality> _criticalityElement;

        /// <summary>
        /// low | high | unable-to-assess
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AllergyIntoleranceCriticality? Criticality
        {
            get { return CriticalityElement != null ? CriticalityElement.Value : null; }
            set
            {
                if (value == null)
                    CriticalityElement = null;
                else
                    CriticalityElement = new Code<AllergyIntoleranceCriticality>(value);
                OnPropertyChanged("Criticality");
            }
        }

        /// <summary>
        /// Code that identifies the allergy or intolerance
        /// </summary>
        [FhirElement("code", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Who the sensitivity is for
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=160)]
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
        /// Encounter when the allergy or intolerance was asserted
        /// </summary>
        [FhirElement("encounter", Order=170)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// When allergy or intolerance was identified
        /// </summary>
        [FhirElement("onset", Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Age),typeof(Period),typeof(Range),typeof(FhirString))]
        [DataMember]
        public Element Onset
        {
            get { return _onset; }
            set { _onset = value; OnPropertyChanged("Onset"); }
        }

        private Element _onset;

        /// <summary>
        /// Date record was first recorded
        /// </summary>
        [FhirElement("recordedDate", Order=190)]
        [DataMember]
        public FhirDateTime RecordedDateElement
        {
            get { return _recordedDateElement; }
            set { _recordedDateElement = value; OnPropertyChanged("RecordedDateElement"); }
        }

        private FhirDateTime _recordedDateElement;

        /// <summary>
        /// Date record was first recorded
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string RecordedDate
        {
            get { return RecordedDateElement != null ? RecordedDateElement.Value : null; }
            set
            {
                if (value == null)
                    RecordedDateElement = null;
                else
                    RecordedDateElement = new FhirDateTime(value);
                OnPropertyChanged("RecordedDate");
            }
        }

        /// <summary>
        /// Who recorded the sensitivity
        /// </summary>
        [FhirElement("recorder", Order=200)]
        [References("Practitioner","Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Recorder
        {
            get { return _recorder; }
            set { _recorder = value; OnPropertyChanged("Recorder"); }
        }

        private ResourceReference _recorder;

        /// <summary>
        /// Source of the information about the allergy
        /// </summary>
        [FhirElement("asserter", InSummary=true, Order=210)]
        [References("Patient","RelatedPerson","Practitioner")]
        [DataMember]
        public ResourceReference Asserter
        {
            get { return _asserter; }
            set { _asserter = value; OnPropertyChanged("Asserter"); }
        }

        private ResourceReference _asserter;

        /// <summary>
        /// Date(/time) of last known occurrence of a reaction
        /// </summary>
        [FhirElement("lastOccurrence", Order=220)]
        [DataMember]
        public FhirDateTime LastOccurrenceElement
        {
            get { return _lastOccurrenceElement; }
            set { _lastOccurrenceElement = value; OnPropertyChanged("LastOccurrenceElement"); }
        }

        private FhirDateTime _lastOccurrenceElement;

        /// <summary>
        /// Date(/time) of last known occurrence of a reaction
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string LastOccurrence
        {
            get { return LastOccurrenceElement != null ? LastOccurrenceElement.Value : null; }
            set
            {
                if (value == null)
                    LastOccurrenceElement = null;
                else
                    LastOccurrenceElement = new FhirDateTime(value);
                OnPropertyChanged("LastOccurrence");
            }
        }

        /// <summary>
        /// Additional text not captured in other fields
        /// </summary>
        [FhirElement("note", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Adverse Reaction Events linked to exposure to substance
        /// </summary>
        [FhirElement("reaction", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ReactionComponent> Reaction
        {
            get { if (_reaction==null) _reaction = new List<ReactionComponent>(); return _reaction; }
            set { _reaction = value; OnPropertyChanged("Reaction"); }
        }

        private List<ReactionComponent> _reaction;


        public static ElementDefinition.ConstraintComponent AllergyIntolerance_AIT_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "verificationStatus='entered-in-error' or clinicalStatus.exists()",
            Key = "ait-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "AllergyIntolerance.clinicalStatus SHALL be present if verificationStatus is not entered-in-error.",
            Xpath = "f:verificationStatus/@value='entered-in-error' or exists(f:clinicalStatus)"
        };

        public static ElementDefinition.ConstraintComponent AllergyIntolerance_AIT_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "verificationStatus!='entered-in-error' or clinicalStatus.empty()",
            Key = "ait-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "AllergyIntolerance.clinicalStatus SHALL NOT be present if verification Status is entered-in-error",
            Xpath = "f:verificationStatus/@value!='entered-in-error' or not(exists(f:clinicalStatus))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(AllergyIntolerance_AIT_1);
            InvariantConstraints.Add(AllergyIntolerance_AIT_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as AllergyIntolerance;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ClinicalStatusElement != null) dest.ClinicalStatusElement = (Code<AllergyIntoleranceClinicalStatus>)ClinicalStatusElement.DeepCopy();
                if (VerificationStatusElement != null) dest.VerificationStatusElement = (Code<AllergyIntoleranceVerificationStatus>)VerificationStatusElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = (Code<AllergyIntoleranceType>)TypeElement.DeepCopy();
                if (CategoryElement != null) dest.CategoryElement = new List<Code<AllergyIntoleranceCategory>>(CategoryElement.DeepCopy());
                if (CriticalityElement != null) dest.CriticalityElement = (Code<AllergyIntoleranceCriticality>)CriticalityElement.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Onset != null) dest.Onset = (Element)Onset.DeepCopy();
                if (RecordedDateElement != null) dest.RecordedDateElement = (FhirDateTime)RecordedDateElement.DeepCopy();
                if (Recorder != null) dest.Recorder = (ResourceReference)Recorder.DeepCopy();
                if (Asserter != null) dest.Asserter = (ResourceReference)Asserter.DeepCopy();
                if (LastOccurrenceElement != null) dest.LastOccurrenceElement = (FhirDateTime)LastOccurrenceElement.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Reaction != null) dest.Reaction = new List<ReactionComponent>(Reaction.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new AllergyIntolerance());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as AllergyIntolerance;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if (!DeepComparable.Matches(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if ( !DeepComparable.Matches(CategoryElement, otherT.CategoryElement)) return false;
            if (!DeepComparable.Matches(CriticalityElement, otherT.CriticalityElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Onset, otherT.Onset)) return false;
            if (!DeepComparable.Matches(RecordedDateElement, otherT.RecordedDateElement)) return false;
            if (!DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.Matches(Asserter, otherT.Asserter)) return false;
            if (!DeepComparable.Matches(LastOccurrenceElement, otherT.LastOccurrenceElement)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Reaction, otherT.Reaction)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as AllergyIntolerance;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ClinicalStatusElement, otherT.ClinicalStatusElement)) return false;
            if (!DeepComparable.IsExactly(VerificationStatusElement, otherT.VerificationStatusElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(CategoryElement, otherT.CategoryElement)) return false;
            if (!DeepComparable.IsExactly(CriticalityElement, otherT.CriticalityElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Onset, otherT.Onset)) return false;
            if (!DeepComparable.IsExactly(RecordedDateElement, otherT.RecordedDateElement)) return false;
            if (!DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.IsExactly(Asserter, otherT.Asserter)) return false;
            if (!DeepComparable.IsExactly(LastOccurrenceElement, otherT.LastOccurrenceElement)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Reaction, otherT.Reaction)) return false;

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
                if (TypeElement != null) yield return TypeElement;
                foreach (var elem in CategoryElement) { if (elem != null) yield return elem; }
                if (CriticalityElement != null) yield return CriticalityElement;
                if (Code != null) yield return Code;
                if (Patient != null) yield return Patient;
                if (Encounter != null) yield return Encounter;
                if (Onset != null) yield return Onset;
                if (RecordedDateElement != null) yield return RecordedDateElement;
                if (Recorder != null) yield return Recorder;
                if (Asserter != null) yield return Asserter;
                if (LastOccurrenceElement != null) yield return LastOccurrenceElement;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Reaction) { if (elem != null) yield return elem; }
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
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                foreach (var elem in CategoryElement) { if (elem != null) yield return new ElementValue("category", elem); }
                if (CriticalityElement != null) yield return new ElementValue("criticality", CriticalityElement);
                if (Code != null) yield return new ElementValue("code", Code);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Onset != null) yield return new ElementValue("onset", Onset);
                if (RecordedDateElement != null) yield return new ElementValue("recordedDate", RecordedDateElement);
                if (Recorder != null) yield return new ElementValue("recorder", Recorder);
                if (Asserter != null) yield return new ElementValue("asserter", Asserter);
                if (LastOccurrenceElement != null) yield return new ElementValue("lastOccurrence", LastOccurrenceElement);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Reaction) { if (elem != null) yield return new ElementValue("reaction", elem); }
            }
        }

    }

}
