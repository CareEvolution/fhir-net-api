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
    /// Medical care, research study or other healthcare event causing physical injury
    /// </summary>
    [FhirType("AdverseEvent", IsResource=true)]
    [DataContract]
    public partial class AdverseEvent : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.AdverseEvent; } }
        [NotMapped]
        public override string TypeName { get { return "AdverseEvent"; } }

        /// <summary>
        /// Overall nature of the event, e.g. real or potential.
        /// (url: http://hl7.org/fhir/ValueSet/adverse-event-actuality)
        /// </summary>
        [FhirEnumeration("AdverseEventActuality")]
        public enum AdverseEventActuality
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/adverse-event-actuality)
            /// </summary>
            [EnumLiteral("actual", "http://hl7.org/fhir/adverse-event-actuality"), Description("Adverse Event")]
            Actual,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/adverse-event-actuality)
            /// </summary>
            [EnumLiteral("potential", "http://hl7.org/fhir/adverse-event-actuality"), Description("Potential Adverse Event")]
            Potential,
        }


        [FhirType("SuspectEntityComponent")]
        [DataContract]
        public partial class SuspectEntityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SuspectEntityComponent"; } }

            /// <summary>
            /// Refers to the specific entity that caused the adverse event
            /// </summary>
            [FhirElement("instance", InSummary=true, Order=40)]
            [References("Immunization","Procedure","Substance","Medication","MedicationAdministration","MedicationStatement","Device")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Instance
            {
                get { return _instance; }
                set { _instance = value; OnPropertyChanged("Instance"); }
            }

            private ResourceReference _instance;

            /// <summary>
            /// Information on the possible cause of the event
            /// </summary>
            [FhirElement("causality", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CausalityComponent> Causality
            {
                get { if (_causality==null) _causality = new List<CausalityComponent>(); return _causality; }
                set { _causality = value; OnPropertyChanged("Causality"); }
            }

            private List<CausalityComponent> _causality;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SuspectEntityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Instance != null) dest.Instance = (ResourceReference)Instance.DeepCopy();
                    if (Causality != null) dest.Causality = new List<CausalityComponent>(Causality.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SuspectEntityComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SuspectEntityComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Instance, otherT.Instance)) return false;
                if ( !DeepComparable.Matches(Causality, otherT.Causality)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SuspectEntityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Instance, otherT.Instance)) return false;
                if (!DeepComparable.IsExactly(Causality, otherT.Causality)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Instance != null) yield return Instance;
                    foreach (var elem in Causality) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Instance != null) yield return new ElementValue("instance", Instance);
                    foreach (var elem in Causality) { if (elem != null) yield return new ElementValue("causality", elem); }
                }
            }


        }


        [FhirType("CausalityComponent")]
        [DataContract]
        public partial class CausalityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CausalityComponent"; } }

            /// <summary>
            /// Assessment of if the entity caused the event
            /// </summary>
            [FhirElement("assessment", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Assessment
            {
                get { return _assessment; }
                set { _assessment = value; OnPropertyChanged("Assessment"); }
            }

            private CodeableConcept _assessment;

            /// <summary>
            /// AdverseEvent.suspectEntity.causalityProductRelatedness
            /// </summary>
            [FhirElement("productRelatedness", InSummary=true, Order=50)]
            [DataMember]
            public FhirString ProductRelatednessElement
            {
                get { return _productRelatednessElement; }
                set { _productRelatednessElement = value; OnPropertyChanged("ProductRelatednessElement"); }
            }

            private FhirString _productRelatednessElement;

            /// <summary>
            /// AdverseEvent.suspectEntity.causalityProductRelatedness
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ProductRelatedness
            {
                get { return ProductRelatednessElement != null ? ProductRelatednessElement.Value : null; }
                set
                {
                    if (value == null)
                        ProductRelatednessElement = null;
                    else
                        ProductRelatednessElement = new FhirString(value);
                    OnPropertyChanged("ProductRelatedness");
                }
            }

            /// <summary>
            /// AdverseEvent.suspectEntity.causalityAuthor
            /// </summary>
            [FhirElement("author", InSummary=true, Order=60)]
            [References("Practitioner","PractitionerRole")]
            [DataMember]
            public ResourceReference Author
            {
                get { return _author; }
                set { _author = value; OnPropertyChanged("Author"); }
            }

            private ResourceReference _author;

            /// <summary>
            /// ProbabilityScale | Bayesian | Checklist
            /// </summary>
            [FhirElement("method", InSummary=true, Order=70)]
            [DataMember]
            public CodeableConcept Method
            {
                get { return _method; }
                set { _method = value; OnPropertyChanged("Method"); }
            }

            private CodeableConcept _method;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CausalityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Assessment != null) dest.Assessment = (CodeableConcept)Assessment.DeepCopy();
                    if (ProductRelatednessElement != null) dest.ProductRelatednessElement = (FhirString)ProductRelatednessElement.DeepCopy();
                    if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                    if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CausalityComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CausalityComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Assessment, otherT.Assessment)) return false;
                if (!DeepComparable.Matches(ProductRelatednessElement, otherT.ProductRelatednessElement)) return false;
                if (!DeepComparable.Matches(Author, otherT.Author)) return false;
                if (!DeepComparable.Matches(Method, otherT.Method)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CausalityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Assessment, otherT.Assessment)) return false;
                if (!DeepComparable.IsExactly(ProductRelatednessElement, otherT.ProductRelatednessElement)) return false;
                if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
                if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Assessment != null) yield return Assessment;
                    if (ProductRelatednessElement != null) yield return ProductRelatednessElement;
                    if (Author != null) yield return Author;
                    if (Method != null) yield return Method;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Assessment != null) yield return new ElementValue("assessment", Assessment);
                    if (ProductRelatednessElement != null) yield return new ElementValue("productRelatedness", ProductRelatednessElement);
                    if (Author != null) yield return new ElementValue("author", Author);
                    if (Method != null) yield return new ElementValue("method", Method);
                }
            }


        }


        /// <summary>
        /// Business identifier for the event
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// actual | potential
        /// </summary>
        [FhirElement("actuality", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<AdverseEventActuality> ActualityElement
        {
            get { return _actualityElement; }
            set { _actualityElement = value; OnPropertyChanged("ActualityElement"); }
        }

        private Code<AdverseEventActuality> _actualityElement;

        /// <summary>
        /// actual | potential
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AdverseEventActuality? Actuality
        {
            get { return ActualityElement != null ? ActualityElement.Value : null; }
            set
            {
                if (value == null)
                    ActualityElement = null;
                else
                    ActualityElement = new Code<AdverseEventActuality>(value);
                OnPropertyChanged("Actuality");
            }
        }

        /// <summary>
        /// product-problem | product-quality | product-use-error | wrong-dose | incorrect-prescribing-information | wrong-technique | wrong-route-of-administration | wrong-rate | wrong-duration | wrong-time | expired-drug | medical-device-use-error | problem-different-manufacturer | unsafe-physical-environment
        /// </summary>
        [FhirElement("category", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// Type of the event itself in relation to the subject
        /// </summary>
        [FhirElement("event", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Event
        {
            get { return _event; }
            set { _event = value; OnPropertyChanged("Event"); }
        }

        private CodeableConcept _event;

        /// <summary>
        /// Subject impacted by event
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=130)]
        [References("Patient","Group","Practitioner","RelatedPerson")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Encounter or episode of care that establishes the context for this AdverseEvent
        /// </summary>
        [FhirElement("context", InSummary=true, Order=140)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When the event occurred
        /// </summary>
        [FhirElement("date", InSummary=true, Order=150)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// When the event occurred
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
        /// When the event was detected
        /// </summary>
        [FhirElement("detected", InSummary=true, Order=160)]
        [DataMember]
        public FhirDateTime DetectedElement
        {
            get { return _detectedElement; }
            set { _detectedElement = value; OnPropertyChanged("DetectedElement"); }
        }

        private FhirDateTime _detectedElement;

        /// <summary>
        /// When the event was detected
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Detected
        {
            get { return DetectedElement != null ? DetectedElement.Value : null; }
            set
            {
                if (value == null)
                    DetectedElement = null;
                else
                    DetectedElement = new FhirDateTime(value);
                OnPropertyChanged("Detected");
            }
        }

        /// <summary>
        /// When the event was recorded
        /// </summary>
        [FhirElement("recordedDate", InSummary=true, Order=170)]
        [DataMember]
        public FhirDateTime RecordedDateElement
        {
            get { return _recordedDateElement; }
            set { _recordedDateElement = value; OnPropertyChanged("RecordedDateElement"); }
        }

        private FhirDateTime _recordedDateElement;

        /// <summary>
        /// When the event was recorded
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
        /// Effect on the subject due to this event
        /// </summary>
        [FhirElement("resultingCondition", InSummary=true, Order=180)]
        [References("Condition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ResultingCondition
        {
            get { if (_resultingCondition==null) _resultingCondition = new List<ResourceReference>(); return _resultingCondition; }
            set { _resultingCondition = value; OnPropertyChanged("ResultingCondition"); }
        }

        private List<ResourceReference> _resultingCondition;

        /// <summary>
        /// Location where adverse event occurred
        /// </summary>
        [FhirElement("location", InSummary=true, Order=190)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Seriousness of the event
        /// </summary>
        [FhirElement("seriousness", InSummary=true, Order=200)]
        [DataMember]
        public CodeableConcept Seriousness
        {
            get { return _seriousness; }
            set { _seriousness = value; OnPropertyChanged("Seriousness"); }
        }

        private CodeableConcept _seriousness;

        /// <summary>
        /// mild | moderate | severe
        /// </summary>
        [FhirElement("severity", InSummary=true, Order=210)]
        [DataMember]
        public CodeableConcept Severity
        {
            get { return _severity; }
            set { _severity = value; OnPropertyChanged("Severity"); }
        }

        private CodeableConcept _severity;

        /// <summary>
        /// resolved | recovering | ongoing | resolvedWithSequelae | fatal | unknown
        /// </summary>
        [FhirElement("outcome", InSummary=true, Order=220)]
        [DataMember]
        public CodeableConcept Outcome
        {
            get { return _outcome; }
            set { _outcome = value; OnPropertyChanged("Outcome"); }
        }

        private CodeableConcept _outcome;

        /// <summary>
        /// Who recorded the adverse event
        /// </summary>
        [FhirElement("recorder", InSummary=true, Order=230)]
        [References("Patient","Practitioner","RelatedPerson")]
        [DataMember]
        public ResourceReference Recorder
        {
            get { return _recorder; }
            set { _recorder = value; OnPropertyChanged("Recorder"); }
        }

        private ResourceReference _recorder;

        /// <summary>
        /// Who  was involved in the adverse event or the potential adverse event
        /// </summary>
        [FhirElement("contributor", InSummary=true, Order=240)]
        [References("Practitioner","Device")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Contributor
        {
            get { if (_contributor==null) _contributor = new List<ResourceReference>(); return _contributor; }
            set { _contributor = value; OnPropertyChanged("Contributor"); }
        }

        private List<ResourceReference> _contributor;

        /// <summary>
        /// The suspected agent causing the adverse event
        /// </summary>
        [FhirElement("suspectEntity", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SuspectEntityComponent> SuspectEntity
        {
            get { if (_suspectEntity==null) _suspectEntity = new List<SuspectEntityComponent>(); return _suspectEntity; }
            set { _suspectEntity = value; OnPropertyChanged("SuspectEntity"); }
        }

        private List<SuspectEntityComponent> _suspectEntity;

        /// <summary>
        /// AdverseEvent.subjectMedicalHistory
        /// </summary>
        [FhirElement("subjectMedicalHistory", InSummary=true, Order=260)]
        [References("Condition","Observation","AllergyIntolerance","FamilyMemberHistory","Immunization","Procedure","Media","DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SubjectMedicalHistory
        {
            get { if (_subjectMedicalHistory==null) _subjectMedicalHistory = new List<ResourceReference>(); return _subjectMedicalHistory; }
            set { _subjectMedicalHistory = value; OnPropertyChanged("SubjectMedicalHistory"); }
        }

        private List<ResourceReference> _subjectMedicalHistory;

        /// <summary>
        /// AdverseEvent.referenceDocument
        /// </summary>
        [FhirElement("referenceDocument", InSummary=true, Order=270)]
        [References("DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReferenceDocument
        {
            get { if (_referenceDocument==null) _referenceDocument = new List<ResourceReference>(); return _referenceDocument; }
            set { _referenceDocument = value; OnPropertyChanged("ReferenceDocument"); }
        }

        private List<ResourceReference> _referenceDocument;

        /// <summary>
        /// AdverseEvent.study
        /// </summary>
        [FhirElement("study", InSummary=true, Order=280)]
        [References("ResearchStudy")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Study
        {
            get { if (_study==null) _study = new List<ResourceReference>(); return _study; }
            set { _study = value; OnPropertyChanged("Study"); }
        }

        private List<ResourceReference> _study;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as AdverseEvent;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (ActualityElement != null) dest.ActualityElement = (Code<AdverseEventActuality>)ActualityElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (Event != null) dest.Event = (CodeableConcept)Event.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (DetectedElement != null) dest.DetectedElement = (FhirDateTime)DetectedElement.DeepCopy();
                if (RecordedDateElement != null) dest.RecordedDateElement = (FhirDateTime)RecordedDateElement.DeepCopy();
                if (ResultingCondition != null) dest.ResultingCondition = new List<ResourceReference>(ResultingCondition.DeepCopy());
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (Seriousness != null) dest.Seriousness = (CodeableConcept)Seriousness.DeepCopy();
                if (Severity != null) dest.Severity = (CodeableConcept)Severity.DeepCopy();
                if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                if (Recorder != null) dest.Recorder = (ResourceReference)Recorder.DeepCopy();
                if (Contributor != null) dest.Contributor = new List<ResourceReference>(Contributor.DeepCopy());
                if (SuspectEntity != null) dest.SuspectEntity = new List<SuspectEntityComponent>(SuspectEntity.DeepCopy());
                if (SubjectMedicalHistory != null) dest.SubjectMedicalHistory = new List<ResourceReference>(SubjectMedicalHistory.DeepCopy());
                if (ReferenceDocument != null) dest.ReferenceDocument = new List<ResourceReference>(ReferenceDocument.DeepCopy());
                if (Study != null) dest.Study = new List<ResourceReference>(Study.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new AdverseEvent());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as AdverseEvent;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActualityElement, otherT.ActualityElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Event, otherT.Event)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(DetectedElement, otherT.DetectedElement)) return false;
            if (!DeepComparable.Matches(RecordedDateElement, otherT.RecordedDateElement)) return false;
            if ( !DeepComparable.Matches(ResultingCondition, otherT.ResultingCondition)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(Seriousness, otherT.Seriousness)) return false;
            if (!DeepComparable.Matches(Severity, otherT.Severity)) return false;
            if (!DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if ( !DeepComparable.Matches(Contributor, otherT.Contributor)) return false;
            if ( !DeepComparable.Matches(SuspectEntity, otherT.SuspectEntity)) return false;
            if ( !DeepComparable.Matches(SubjectMedicalHistory, otherT.SubjectMedicalHistory)) return false;
            if ( !DeepComparable.Matches(ReferenceDocument, otherT.ReferenceDocument)) return false;
            if ( !DeepComparable.Matches(Study, otherT.Study)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as AdverseEvent;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActualityElement, otherT.ActualityElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Event, otherT.Event)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(DetectedElement, otherT.DetectedElement)) return false;
            if (!DeepComparable.IsExactly(RecordedDateElement, otherT.RecordedDateElement)) return false;
            if (!DeepComparable.IsExactly(ResultingCondition, otherT.ResultingCondition)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(Seriousness, otherT.Seriousness)) return false;
            if (!DeepComparable.IsExactly(Severity, otherT.Severity)) return false;
            if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.IsExactly(Contributor, otherT.Contributor)) return false;
            if (!DeepComparable.IsExactly(SuspectEntity, otherT.SuspectEntity)) return false;
            if (!DeepComparable.IsExactly(SubjectMedicalHistory, otherT.SubjectMedicalHistory)) return false;
            if (!DeepComparable.IsExactly(ReferenceDocument, otherT.ReferenceDocument)) return false;
            if (!DeepComparable.IsExactly(Study, otherT.Study)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (ActualityElement != null) yield return ActualityElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (Event != null) yield return Event;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (DateElement != null) yield return DateElement;
                if (DetectedElement != null) yield return DetectedElement;
                if (RecordedDateElement != null) yield return RecordedDateElement;
                foreach (var elem in ResultingCondition) { if (elem != null) yield return elem; }
                if (Location != null) yield return Location;
                if (Seriousness != null) yield return Seriousness;
                if (Severity != null) yield return Severity;
                if (Outcome != null) yield return Outcome;
                if (Recorder != null) yield return Recorder;
                foreach (var elem in Contributor) { if (elem != null) yield return elem; }
                foreach (var elem in SuspectEntity) { if (elem != null) yield return elem; }
                foreach (var elem in SubjectMedicalHistory) { if (elem != null) yield return elem; }
                foreach (var elem in ReferenceDocument) { if (elem != null) yield return elem; }
                foreach (var elem in Study) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (ActualityElement != null) yield return new ElementValue("actuality", ActualityElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (Event != null) yield return new ElementValue("event", Event);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (DetectedElement != null) yield return new ElementValue("detected", DetectedElement);
                if (RecordedDateElement != null) yield return new ElementValue("recordedDate", RecordedDateElement);
                foreach (var elem in ResultingCondition) { if (elem != null) yield return new ElementValue("resultingCondition", elem); }
                if (Location != null) yield return new ElementValue("location", Location);
                if (Seriousness != null) yield return new ElementValue("seriousness", Seriousness);
                if (Severity != null) yield return new ElementValue("severity", Severity);
                if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                if (Recorder != null) yield return new ElementValue("recorder", Recorder);
                foreach (var elem in Contributor) { if (elem != null) yield return new ElementValue("contributor", elem); }
                foreach (var elem in SuspectEntity) { if (elem != null) yield return new ElementValue("suspectEntity", elem); }
                foreach (var elem in SubjectMedicalHistory) { if (elem != null) yield return new ElementValue("subjectMedicalHistory", elem); }
                foreach (var elem in ReferenceDocument) { if (elem != null) yield return new ElementValue("referenceDocument", elem); }
                foreach (var elem in Study) { if (elem != null) yield return new ElementValue("study", elem); }
            }
        }

    }

}
