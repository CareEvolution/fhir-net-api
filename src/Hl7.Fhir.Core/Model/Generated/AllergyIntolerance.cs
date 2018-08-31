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
    /// Allergy or Intolerance (generally: Risk Of Adverse reaction to a substance)
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
        /// Assertion about certainty associated with a propensity, or potential risk, of a reaction to the identified Substance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-status)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceStatus")]
        public enum AllergyIntoleranceStatus
        {
            /// <summary>
            /// An active record of a reaction to the identified Substance.
            /// (system: http://hl7.org/fhir/allergy-intolerance-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/allergy-intolerance-status"), Description("Active")]
            Active,
            /// <summary>
            /// A low level of certainty about the propensity for a reaction to the identified Substance.
            /// (system: http://hl7.org/fhir/allergy-intolerance-status)
            /// </summary>
            [EnumLiteral("unconfirmed", "http://hl7.org/fhir/allergy-intolerance-status"), Description("Unconfirmed")]
            Unconfirmed,
            /// <summary>
            /// A high level of certainty about the propensity for a reaction to the identified Substance, which may include clinical evidence by testing or rechallenge.
            /// (system: http://hl7.org/fhir/allergy-intolerance-status)
            /// </summary>
            [EnumLiteral("confirmed", "http://hl7.org/fhir/allergy-intolerance-status"), Description("Confirmed")]
            Confirmed,
            /// <summary>
            /// An inactive record of a reaction to the identified Substance.
            /// (system: http://hl7.org/fhir/allergy-intolerance-status)
            /// </summary>
            [EnumLiteral("inactive", "http://hl7.org/fhir/allergy-intolerance-status"), Description("Inactive")]
            Inactive,
            /// <summary>
            /// A reaction to the identified Substance has been clinically reassessed by testing or rechallenge and considered to be resolved.
            /// (system: http://hl7.org/fhir/allergy-intolerance-status)
            /// </summary>
            [EnumLiteral("resolved", "http://hl7.org/fhir/allergy-intolerance-status"), Description("Resolved")]
            Resolved,
            /// <summary>
            /// A propensity for a reaction to the identified Substance has been disproven with a high level of clinical certainty, which may include testing or rechallenge, and is refuted.
            /// (system: http://hl7.org/fhir/allergy-intolerance-status)
            /// </summary>
            [EnumLiteral("refuted", "http://hl7.org/fhir/allergy-intolerance-status"), Description("Refuted")]
            Refuted,
            /// <summary>
            /// The statement was entered in error and is not valid.
            /// (system: http://hl7.org/fhir/allergy-intolerance-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/allergy-intolerance-status"), Description("Entered In Error")]
            EnteredInError,
        }

        /// <summary>
        /// Estimate of the potential clinical harm, or seriousness, of a reaction to an identified Substance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-criticality)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceCriticality")]
        public enum AllergyIntoleranceCriticality
        {
            /// <summary>
            /// The potential clinical impact of a future reaction is estimated as low risk: exposure to substance is unlikely to result in a life threatening or organ system threatening outcome. Future exposure to the Substance is considered a relative contra-indication.
            /// (system: http://hl7.org/fhir/allergy-intolerance-criticality)
            /// </summary>
            [EnumLiteral("CRITL", "http://hl7.org/fhir/allergy-intolerance-criticality"), Description("Low Risk")]
            CRITL,
            /// <summary>
            /// The potential clinical impact of a future reaction is estimated as high risk: exposure to substance may result in a life threatening or organ system threatening outcome. Future exposure to the Substance may be considered an absolute contra-indication.
            /// (system: http://hl7.org/fhir/allergy-intolerance-criticality)
            /// </summary>
            [EnumLiteral("CRITH", "http://hl7.org/fhir/allergy-intolerance-criticality"), Description("High Risk")]
            CRITH,
            /// <summary>
            /// Unable to assess the potential clinical impact with the information available.
            /// (system: http://hl7.org/fhir/allergy-intolerance-criticality)
            /// </summary>
            [EnumLiteral("CRITU", "http://hl7.org/fhir/allergy-intolerance-criticality"), Description("Unable to determine")]
            CRITU,
        }

        /// <summary>
        /// Identification of the underlying physiological mechanism for a Reaction Risk.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-type)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceType")]
        public enum AllergyIntoleranceType
        {
            /// <summary>
            /// A propensity for hypersensitivity reaction(s) to a substance.  These reactions are most typically type I hypersensitivity, plus other "allergy-like" reactions, including pseudoallergy.
            /// (system: http://hl7.org/fhir/allergy-intolerance-type)
            /// </summary>
            [EnumLiteral("allergy", "http://hl7.org/fhir/allergy-intolerance-type"), Description("Allergy")]
            Allergy,
            /// <summary>
            /// A propensity for adverse reactions to a substance that is not judged to be allergic or "allergy-like".  These reactions are typically (but not necessarily) non-immune.  They are to some degree idiosyncratic and/or individually specific (i.e. are not a reaction that is expected to occur with most or all patients given similar circumstances).
            /// (system: http://hl7.org/fhir/allergy-intolerance-type)
            /// </summary>
            [EnumLiteral("intolerance", "http://hl7.org/fhir/allergy-intolerance-type"), Description("Intolerance")]
            Intolerance,
        }

        /// <summary>
        /// Category of an identified Substance.
        /// (url: http://hl7.org/fhir/ValueSet/allergy-intolerance-category)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceCategory")]
        public enum AllergyIntoleranceCategory
        {
            /// <summary>
            /// Any substance consumed to provide nutritional support for the body.
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("food", "http://hl7.org/fhir/allergy-intolerance-category"), Description("Food")]
            Food,
            /// <summary>
            /// Substances administered to achieve a physiological effect.
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("medication", "http://hl7.org/fhir/allergy-intolerance-category"), Description("Medication")]
            Medication,
            /// <summary>
            /// Substances that are encountered in the environment.
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("environment", "http://hl7.org/fhir/allergy-intolerance-category"), Description("Environment")]
            Environment,
            /// <summary>
            /// Other substances that are not covered by any other category.
            /// (system: http://hl7.org/fhir/allergy-intolerance-category)
            /// </summary>
            [EnumLiteral("other", "http://hl7.org/fhir/allergy-intolerance-category"), Description("Other")]
            Other,
        }

        /// <summary>
        /// Statement about the degree of clinical certainty that a Specific Substance was the cause of the Manifestation in an reaction event.
        /// (url: http://hl7.org/fhir/ValueSet/reaction-event-certainty)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceCertainty")]
        public enum AllergyIntoleranceCertainty
        {
            /// <summary>
            /// There is a low level of clinical certainty that the reaction was caused by the identified Substance.
            /// (system: http://hl7.org/fhir/reaction-event-certainty)
            /// </summary>
            [EnumLiteral("unlikely", "http://hl7.org/fhir/reaction-event-certainty"), Description("Unlikely")]
            Unlikely,
            /// <summary>
            /// There is a high level of clinical certainty that the reaction was caused by the identified Substance.
            /// (system: http://hl7.org/fhir/reaction-event-certainty)
            /// </summary>
            [EnumLiteral("likely", "http://hl7.org/fhir/reaction-event-certainty"), Description("Likely")]
            Likely,
            /// <summary>
            /// There is a very high level of clinical certainty that the reaction was due to the identified Substance, which may include clinical evidence by testing or rechallenge.
            /// (system: http://hl7.org/fhir/reaction-event-certainty)
            /// </summary>
            [EnumLiteral("confirmed", "http://hl7.org/fhir/reaction-event-certainty"), Description("Confirmed")]
            Confirmed,
        }

        /// <summary>
        /// Clinical assessment of the severity of a reaction event as a whole, potentially considering multiple different manifestations.
        /// (url: http://hl7.org/fhir/ValueSet/reaction-event-severity)
        /// </summary>
        [FhirEnumeration("AllergyIntoleranceSeverity")]
        public enum AllergyIntoleranceSeverity
        {
            /// <summary>
            /// Causes mild physiological effects.
            /// (system: http://hl7.org/fhir/reaction-event-severity)
            /// </summary>
            [EnumLiteral("mild", "http://hl7.org/fhir/reaction-event-severity"), Description("Mild")]
            Mild,
            /// <summary>
            /// Causes moderate physiological effects.
            /// (system: http://hl7.org/fhir/reaction-event-severity)
            /// </summary>
            [EnumLiteral("moderate", "http://hl7.org/fhir/reaction-event-severity"), Description("Moderate")]
            Moderate,
            /// <summary>
            /// Causes severe physiological effects.
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
            /// Specific substance considered to be responsible for event
            /// </summary>
            [FhirElement("substance", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Substance
            {
                get { return _substance; }
                set { _substance = value; OnPropertyChanged("Substance"); }
            }

            private CodeableConcept _substance;

            /// <summary>
            /// unlikely | likely | confirmed - clinical certainty about the specific substance
            /// </summary>
            [FhirElement("certainty", InSummary=true, Order=50)]
            [DataMember]
            public Code<AllergyIntoleranceCertainty> CertaintyElement
            {
                get { return _certaintyElement; }
                set { _certaintyElement = value; OnPropertyChanged("CertaintyElement"); }
            }

            private Code<AllergyIntoleranceCertainty> _certaintyElement;

            /// <summary>
            /// unlikely | likely | confirmed - clinical certainty about the specific substance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AllergyIntoleranceCertainty? Certainty
            {
                get { return CertaintyElement != null ? CertaintyElement.Value : null; }
                set
                {
                    if (value == null)
                        CertaintyElement = null;
                    else
                        CertaintyElement = new Code<AllergyIntoleranceCertainty>(value);
                    OnPropertyChanged("Certainty");
                }
            }

            /// <summary>
            /// Clinical symptoms/signs associated with the Event
            /// </summary>
            [FhirElement("manifestation", InSummary=true, Order=60)]
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
            [FhirElement("description", Order=70)]
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
            [FhirElement("onset", InSummary=true, Order=80)]
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
            [FhirElement("severity", InSummary=true, Order=90)]
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
            [FhirElement("exposureRoute", InSummary=true, Order=100)]
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
            [FhirElement("note", Order=110)]
            [DataMember]
            public Annotation Note
            {
                get { return _note; }
                set { _note = value; OnPropertyChanged("Note"); }
            }

            private Annotation _note;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReactionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Substance != null) dest.Substance = (CodeableConcept)Substance.DeepCopy();
                    if (CertaintyElement != null) dest.CertaintyElement = (Code<AllergyIntoleranceCertainty>)CertaintyElement.DeepCopy();
                    if (Manifestation != null) dest.Manifestation = new List<CodeableConcept>(Manifestation.DeepCopy());
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (OnsetElement != null) dest.OnsetElement = (FhirDateTime)OnsetElement.DeepCopy();
                    if (SeverityElement != null) dest.SeverityElement = (Code<AllergyIntoleranceSeverity>)SeverityElement.DeepCopy();
                    if (ExposureRoute != null) dest.ExposureRoute = (CodeableConcept)ExposureRoute.DeepCopy();
                    if (Note != null) dest.Note = (Annotation)Note.DeepCopy();
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
                if (!DeepComparable.Matches(CertaintyElement, otherT.CertaintyElement)) return false;
                if ( !DeepComparable.Matches(Manifestation, otherT.Manifestation)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(OnsetElement, otherT.OnsetElement)) return false;
                if (!DeepComparable.Matches(SeverityElement, otherT.SeverityElement)) return false;
                if (!DeepComparable.Matches(ExposureRoute, otherT.ExposureRoute)) return false;
                if (!DeepComparable.Matches(Note, otherT.Note)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReactionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
                if (!DeepComparable.IsExactly(CertaintyElement, otherT.CertaintyElement)) return false;
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
                    if (CertaintyElement != null) yield return CertaintyElement;
                    foreach (var elem in Manifestation) { if (elem != null) yield return elem; }
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (OnsetElement != null) yield return OnsetElement;
                    if (SeverityElement != null) yield return SeverityElement;
                    if (ExposureRoute != null) yield return ExposureRoute;
                    if (Note != null) yield return Note;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Substance != null) yield return new ElementValue("substance", Substance);
                    if (CertaintyElement != null) yield return new ElementValue("certainty", CertaintyElement);
                    foreach (var elem in Manifestation) { if (elem != null) yield return new ElementValue("manifestation", elem); }
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (OnsetElement != null) yield return new ElementValue("onset", OnsetElement);
                    if (SeverityElement != null) yield return new ElementValue("severity", SeverityElement);
                    if (ExposureRoute != null) yield return new ElementValue("exposureRoute", ExposureRoute);
                    if (Note != null) yield return new ElementValue("note", Note);
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
        /// Date(/time) when manifestations showed
        /// </summary>
        [FhirElement("onset", InSummary=true, Order=100)]
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
        /// When recorded
        /// </summary>
        [FhirElement("recordedDate", InSummary=true, Order=110)]
        [DataMember]
        public FhirDateTime RecordedDateElement
        {
            get { return _recordedDateElement; }
            set { _recordedDateElement = value; OnPropertyChanged("RecordedDateElement"); }
        }

        private FhirDateTime _recordedDateElement;

        /// <summary>
        /// When recorded
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
        [FhirElement("recorder", InSummary=true, Order=120)]
        [References("Practitioner","Patient")]
        [DataMember]
        public ResourceReference Recorder
        {
            get { return _recorder; }
            set { _recorder = value; OnPropertyChanged("Recorder"); }
        }

        private ResourceReference _recorder;

        /// <summary>
        /// Who the sensitivity is for
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=130)]
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
        /// Source of the information about the allergy
        /// </summary>
        [FhirElement("reporter", InSummary=true, Order=140)]
        [References("Patient","RelatedPerson","Practitioner")]
        [DataMember]
        public ResourceReference Reporter
        {
            get { return _reporter; }
            set { _reporter = value; OnPropertyChanged("Reporter"); }
        }

        private ResourceReference _reporter;

        /// <summary>
        /// Substance, (or class) considered to be responsible for risk
        /// </summary>
        [FhirElement("substance", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Substance
        {
            get { return _substance; }
            set { _substance = value; OnPropertyChanged("Substance"); }
        }

        private CodeableConcept _substance;

        /// <summary>
        /// active | unconfirmed | confirmed | inactive | resolved | refuted | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=160)]
        [DataMember]
        public Code<AllergyIntoleranceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<AllergyIntoleranceStatus> _statusElement;

        /// <summary>
        /// active | unconfirmed | confirmed | inactive | resolved | refuted | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AllergyIntoleranceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<AllergyIntoleranceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// CRITL | CRITH | CRITU
        /// </summary>
        [FhirElement("criticality", InSummary=true, Order=170)]
        [DataMember]
        public Code<AllergyIntoleranceCriticality> CriticalityElement
        {
            get { return _criticalityElement; }
            set { _criticalityElement = value; OnPropertyChanged("CriticalityElement"); }
        }

        private Code<AllergyIntoleranceCriticality> _criticalityElement;

        /// <summary>
        /// CRITL | CRITH | CRITU
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
        /// allergy | intolerance - Underlying mechanism (if known)
        /// </summary>
        [FhirElement("type", InSummary=true, Order=180)]
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
        /// food | medication | environment | other - Category of Substance
        /// </summary>
        [FhirElement("category", InSummary=true, Order=190)]
        [DataMember]
        public Code<AllergyIntoleranceCategory> CategoryElement
        {
            get { return _categoryElement; }
            set { _categoryElement = value; OnPropertyChanged("CategoryElement"); }
        }

        private Code<AllergyIntoleranceCategory> _categoryElement;

        /// <summary>
        /// food | medication | environment | other - Category of Substance
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AllergyIntoleranceCategory? Category
        {
            get { return CategoryElement != null ? CategoryElement.Value : null; }
            set
            {
                if (value == null)
                    CategoryElement = null;
                else
                    CategoryElement = new Code<AllergyIntoleranceCategory>(value);
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        /// Date(/time) of last known occurrence of a reaction
        /// </summary>
        [FhirElement("lastOccurence", InSummary=true, Order=200)]
        [DataMember]
        public FhirDateTime LastOccurenceElement
        {
            get { return _lastOccurenceElement; }
            set { _lastOccurenceElement = value; OnPropertyChanged("LastOccurenceElement"); }
        }

        private FhirDateTime _lastOccurenceElement;

        /// <summary>
        /// Date(/time) of last known occurrence of a reaction
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string LastOccurence
        {
            get { return LastOccurenceElement != null ? LastOccurenceElement.Value : null; }
            set
            {
                if (value == null)
                    LastOccurenceElement = null;
                else
                    LastOccurenceElement = new FhirDateTime(value);
                OnPropertyChanged("LastOccurence");
            }
        }

        /// <summary>
        /// Additional text not captured in other fields
        /// </summary>
        [FhirElement("note", Order=210)]
        [DataMember]
        public Annotation Note
        {
            get { return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private Annotation _note;

        /// <summary>
        /// Adverse Reaction Events linked to exposure to substance
        /// </summary>
        [FhirElement("reaction", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ReactionComponent> Reaction
        {
            get { if (_reaction==null) _reaction = new List<ReactionComponent>(); return _reaction; }
            set { _reaction = value; OnPropertyChanged("Reaction"); }
        }

        private List<ReactionComponent> _reaction;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as AllergyIntolerance;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (OnsetElement != null) dest.OnsetElement = (FhirDateTime)OnsetElement.DeepCopy();
                if (RecordedDateElement != null) dest.RecordedDateElement = (FhirDateTime)RecordedDateElement.DeepCopy();
                if (Recorder != null) dest.Recorder = (ResourceReference)Recorder.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Reporter != null) dest.Reporter = (ResourceReference)Reporter.DeepCopy();
                if (Substance != null) dest.Substance = (CodeableConcept)Substance.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<AllergyIntoleranceStatus>)StatusElement.DeepCopy();
                if (CriticalityElement != null) dest.CriticalityElement = (Code<AllergyIntoleranceCriticality>)CriticalityElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = (Code<AllergyIntoleranceType>)TypeElement.DeepCopy();
                if (CategoryElement != null) dest.CategoryElement = (Code<AllergyIntoleranceCategory>)CategoryElement.DeepCopy();
                if (LastOccurenceElement != null) dest.LastOccurenceElement = (FhirDateTime)LastOccurenceElement.DeepCopy();
                if (Note != null) dest.Note = (Annotation)Note.DeepCopy();
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
            if (!DeepComparable.Matches(OnsetElement, otherT.OnsetElement)) return false;
            if (!DeepComparable.Matches(RecordedDateElement, otherT.RecordedDateElement)) return false;
            if (!DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Reporter, otherT.Reporter)) return false;
            if (!DeepComparable.Matches(Substance, otherT.Substance)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(CriticalityElement, otherT.CriticalityElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(CategoryElement, otherT.CategoryElement)) return false;
            if (!DeepComparable.Matches(LastOccurenceElement, otherT.LastOccurenceElement)) return false;
            if (!DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Reaction, otherT.Reaction)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as AllergyIntolerance;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(OnsetElement, otherT.OnsetElement)) return false;
            if (!DeepComparable.IsExactly(RecordedDateElement, otherT.RecordedDateElement)) return false;
            if (!DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Reporter, otherT.Reporter)) return false;
            if (!DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(CriticalityElement, otherT.CriticalityElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(CategoryElement, otherT.CategoryElement)) return false;
            if (!DeepComparable.IsExactly(LastOccurenceElement, otherT.LastOccurenceElement)) return false;
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
                if (OnsetElement != null) yield return OnsetElement;
                if (RecordedDateElement != null) yield return RecordedDateElement;
                if (Recorder != null) yield return Recorder;
                if (Patient != null) yield return Patient;
                if (Reporter != null) yield return Reporter;
                if (Substance != null) yield return Substance;
                if (StatusElement != null) yield return StatusElement;
                if (CriticalityElement != null) yield return CriticalityElement;
                if (TypeElement != null) yield return TypeElement;
                if (CategoryElement != null) yield return CategoryElement;
                if (LastOccurenceElement != null) yield return LastOccurenceElement;
                if (Note != null) yield return Note;
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
                if (OnsetElement != null) yield return new ElementValue("onset", OnsetElement);
                if (RecordedDateElement != null) yield return new ElementValue("recordedDate", RecordedDateElement);
                if (Recorder != null) yield return new ElementValue("recorder", Recorder);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Reporter != null) yield return new ElementValue("reporter", Reporter);
                if (Substance != null) yield return new ElementValue("substance", Substance);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (CriticalityElement != null) yield return new ElementValue("criticality", CriticalityElement);
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (CategoryElement != null) yield return new ElementValue("category", CategoryElement);
                if (LastOccurenceElement != null) yield return new ElementValue("lastOccurence", LastOccurenceElement);
                if (Note != null) yield return new ElementValue("note", Note);
                foreach (var elem in Reaction) { if (elem != null) yield return new ElementValue("reaction", elem); }
            }
        }

    }

}
