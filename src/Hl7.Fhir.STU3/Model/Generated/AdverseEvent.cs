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


        [FhirType("SuspectEntityComponent")]
        [DataContract]
        public partial class SuspectEntityComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SuspectEntityComponent"; } }

            /// <summary>
            /// Refers to the specific entity that caused the adverse event
            /// </summary>
            [FhirElement("instance", InSummary=true, Order=40)]
            [References("Substance","Medication","MedicationAdministration","MedicationStatement","Device")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Instance
            {
                get { return _instance; }
                set { _instance = value; OnPropertyChanged("Instance"); }
            }

            private ResourceReference _instance;

            /// <summary>
            /// causality1 | causality2
            /// </summary>
            [FhirElement("causality", InSummary=true, Order=50)]
            [DataMember]
            public Code<AdverseEventCausality> CausalityElement
            {
                get { return _causalityElement; }
                set { _causalityElement = value; OnPropertyChanged("CausalityElement"); }
            }

            private Code<AdverseEventCausality> _causalityElement;

            /// <summary>
            /// causality1 | causality2
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AdverseEventCausality? Causality
            {
                get { return CausalityElement != null ? CausalityElement.Value : null; }
                set
                {
                    if (value == null)
                        CausalityElement = null;
                    else
                        CausalityElement = new Code<AdverseEventCausality>(value);
                    OnPropertyChanged("Causality");
                }
            }

            /// <summary>
            /// assess1 | assess2
            /// </summary>
            [FhirElement("causalityAssessment", InSummary=true, Order=60)]
            [DataMember]
            public CodeableConcept CausalityAssessment
            {
                get { return _causalityAssessment; }
                set { _causalityAssessment = value; OnPropertyChanged("CausalityAssessment"); }
            }

            private CodeableConcept _causalityAssessment;

            /// <summary>
            /// AdverseEvent.suspectEntity.causalityProductRelatedness
            /// </summary>
            [FhirElement("causalityProductRelatedness", InSummary=true, Order=70)]
            [DataMember]
            public FhirString CausalityProductRelatednessElement
            {
                get { return _causalityProductRelatednessElement; }
                set { _causalityProductRelatednessElement = value; OnPropertyChanged("CausalityProductRelatednessElement"); }
            }

            private FhirString _causalityProductRelatednessElement;

            /// <summary>
            /// AdverseEvent.suspectEntity.causalityProductRelatedness
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string CausalityProductRelatedness
            {
                get { return CausalityProductRelatednessElement != null ? CausalityProductRelatednessElement.Value : null; }
                set
                {
                    if (value == null)
                        CausalityProductRelatednessElement = null;
                    else
                        CausalityProductRelatednessElement = new FhirString(value);
                    OnPropertyChanged("CausalityProductRelatedness");
                }
            }

            /// <summary>
            /// method1 | method2
            /// </summary>
            [FhirElement("causalityMethod", InSummary=true, Order=80)]
            [DataMember]
            public CodeableConcept CausalityMethod
            {
                get { return _causalityMethod; }
                set { _causalityMethod = value; OnPropertyChanged("CausalityMethod"); }
            }

            private CodeableConcept _causalityMethod;

            /// <summary>
            /// AdverseEvent.suspectEntity.causalityAuthor
            /// </summary>
            [FhirElement("causalityAuthor", InSummary=true, Order=90)]
            [References("Practitioner","PractitionerRole")]
            [DataMember]
            public ResourceReference CausalityAuthor
            {
                get { return _causalityAuthor; }
                set { _causalityAuthor = value; OnPropertyChanged("CausalityAuthor"); }
            }

            private ResourceReference _causalityAuthor;

            /// <summary>
            /// result1 | result2
            /// </summary>
            [FhirElement("causalityResult", InSummary=true, Order=100)]
            [DataMember]
            public CodeableConcept CausalityResult
            {
                get { return _causalityResult; }
                set { _causalityResult = value; OnPropertyChanged("CausalityResult"); }
            }

            private CodeableConcept _causalityResult;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SuspectEntityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Instance != null) dest.Instance = (ResourceReference)Instance.DeepCopy();
                    if (CausalityElement != null) dest.CausalityElement = (Code<AdverseEventCausality>)CausalityElement.DeepCopy();
                    if (CausalityAssessment != null) dest.CausalityAssessment = (CodeableConcept)CausalityAssessment.DeepCopy();
                    if (CausalityProductRelatednessElement != null) dest.CausalityProductRelatednessElement = (FhirString)CausalityProductRelatednessElement.DeepCopy();
                    if (CausalityMethod != null) dest.CausalityMethod = (CodeableConcept)CausalityMethod.DeepCopy();
                    if (CausalityAuthor != null) dest.CausalityAuthor = (ResourceReference)CausalityAuthor.DeepCopy();
                    if (CausalityResult != null) dest.CausalityResult = (CodeableConcept)CausalityResult.DeepCopy();
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
                if (!DeepComparable.Matches(CausalityElement, otherT.CausalityElement)) return false;
                if (!DeepComparable.Matches(CausalityAssessment, otherT.CausalityAssessment)) return false;
                if (!DeepComparable.Matches(CausalityProductRelatednessElement, otherT.CausalityProductRelatednessElement)) return false;
                if (!DeepComparable.Matches(CausalityMethod, otherT.CausalityMethod)) return false;
                if (!DeepComparable.Matches(CausalityAuthor, otherT.CausalityAuthor)) return false;
                if (!DeepComparable.Matches(CausalityResult, otherT.CausalityResult)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SuspectEntityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Instance, otherT.Instance)) return false;
                if (!DeepComparable.IsExactly(CausalityElement, otherT.CausalityElement)) return false;
                if (!DeepComparable.IsExactly(CausalityAssessment, otherT.CausalityAssessment)) return false;
                if (!DeepComparable.IsExactly(CausalityProductRelatednessElement, otherT.CausalityProductRelatednessElement)) return false;
                if (!DeepComparable.IsExactly(CausalityMethod, otherT.CausalityMethod)) return false;
                if (!DeepComparable.IsExactly(CausalityAuthor, otherT.CausalityAuthor)) return false;
                if (!DeepComparable.IsExactly(CausalityResult, otherT.CausalityResult)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Instance != null) yield return Instance;
                    if (CausalityElement != null) yield return CausalityElement;
                    if (CausalityAssessment != null) yield return CausalityAssessment;
                    if (CausalityProductRelatednessElement != null) yield return CausalityProductRelatednessElement;
                    if (CausalityMethod != null) yield return CausalityMethod;
                    if (CausalityAuthor != null) yield return CausalityAuthor;
                    if (CausalityResult != null) yield return CausalityResult;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Instance != null) yield return new ElementValue("instance", Instance);
                    if (CausalityElement != null) yield return new ElementValue("causality", CausalityElement);
                    if (CausalityAssessment != null) yield return new ElementValue("causalityAssessment", CausalityAssessment);
                    if (CausalityProductRelatednessElement != null) yield return new ElementValue("causalityProductRelatedness", CausalityProductRelatednessElement);
                    if (CausalityMethod != null) yield return new ElementValue("causalityMethod", CausalityMethod);
                    if (CausalityAuthor != null) yield return new ElementValue("causalityAuthor", CausalityAuthor);
                    if (CausalityResult != null) yield return new ElementValue("causalityResult", CausalityResult);
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
        /// AE | PAE <br/>
        /// An adverse event is an event that caused harm to a patient,  an adverse reaction is a something that is a subject-specific event that is a result of an exposure to a medication, food, device or environmental substance, a potential adverse event is something that occurred and that could have caused harm to a patient but did not
        /// </summary>
        [FhirElement("category", InSummary=true, Order=100)]
        [DataMember]
        public Code<AdverseEventCategory> CategoryElement
        {
            get { return _categoryElement; }
            set { _categoryElement = value; OnPropertyChanged("CategoryElement"); }
        }

        private Code<AdverseEventCategory> _categoryElement;

        /// <summary>
        /// AE | PAE <br/>
        /// An adverse event is an event that caused harm to a patient,  an adverse reaction is a something that is a subject-specific event that is a result of an exposure to a medication, food, device or environmental substance, a potential adverse event is something that occurred and that could have caused harm to a patient but did not
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AdverseEventCategory? Category
        {
            get { return CategoryElement != null ? CategoryElement.Value : null; }
            set
            {
                if (value == null)
                    CategoryElement = null;
                else
                    CategoryElement = new Code<AdverseEventCategory>(value);
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        /// actual | potential
        /// </summary>
        [FhirElement("type", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Subject or group impacted by event
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=120)]
        [References("Patient","ResearchSubject","Medication","Device")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// When the event occurred
        /// </summary>
        [FhirElement("date", InSummary=true, Order=130)]
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
        /// Adverse Reaction Events linked to exposure to substance
        /// </summary>
        [FhirElement("reaction", InSummary=true, Order=140)]
        [References("Condition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Reaction
        {
            get { if (_reaction==null) _reaction = new List<ResourceReference>(); return _reaction; }
            set { _reaction = value; OnPropertyChanged("Reaction"); }
        }

        private List<ResourceReference> _reaction;

        /// <summary>
        /// Location where adverse event occurred
        /// </summary>
        [FhirElement("location", InSummary=true, Order=150)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Mild | Moderate | Severe
        /// </summary>
        [FhirElement("seriousness", InSummary=true, Order=160)]
        [DataMember]
        public CodeableConcept Seriousness
        {
            get { return _seriousness; }
            set { _seriousness = value; OnPropertyChanged("Seriousness"); }
        }

        private CodeableConcept _seriousness;

        /// <summary>
        /// resolved | recovering | ongoing | resolvedWithSequelae | fatal | unknown
        /// </summary>
        [FhirElement("outcome", InSummary=true, Order=170)]
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
        [FhirElement("recorder", InSummary=true, Order=180)]
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
        [FhirElement("eventParticipant", InSummary=true, Order=190)]
        [References("Practitioner","Device")]
        [DataMember]
        public ResourceReference EventParticipant
        {
            get { return _eventParticipant; }
            set { _eventParticipant = value; OnPropertyChanged("EventParticipant"); }
        }

        private ResourceReference _eventParticipant;

        /// <summary>
        /// Description of the adverse event
        /// </summary>
        [FhirElement("description", InSummary=true, Order=200)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Description of the adverse event
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
        /// The suspected agent causing the adverse event
        /// </summary>
        [FhirElement("suspectEntity", InSummary=true, Order=210)]
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
        [FhirElement("subjectMedicalHistory", InSummary=true, Order=220)]
        [References("Condition","Observation","AllergyIntolerance","FamilyMemberHistory","Immunization","Procedure")]
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
        [FhirElement("referenceDocument", InSummary=true, Order=230)]
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
        [FhirElement("study", InSummary=true, Order=240)]
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
                if (CategoryElement != null) dest.CategoryElement = (Code<AdverseEventCategory>)CategoryElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Reaction != null) dest.Reaction = new List<ResourceReference>(Reaction.DeepCopy());
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (Seriousness != null) dest.Seriousness = (CodeableConcept)Seriousness.DeepCopy();
                if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                if (Recorder != null) dest.Recorder = (ResourceReference)Recorder.DeepCopy();
                if (EventParticipant != null) dest.EventParticipant = (ResourceReference)EventParticipant.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
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
            if (!DeepComparable.Matches(CategoryElement, otherT.CategoryElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if ( !DeepComparable.Matches(Reaction, otherT.Reaction)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(Seriousness, otherT.Seriousness)) return false;
            if (!DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.Matches(EventParticipant, otherT.EventParticipant)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
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
            if (!DeepComparable.IsExactly(CategoryElement, otherT.CategoryElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Reaction, otherT.Reaction)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(Seriousness, otherT.Seriousness)) return false;
            if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.IsExactly(EventParticipant, otherT.EventParticipant)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
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
                if (CategoryElement != null) yield return CategoryElement;
                if (Type != null) yield return Type;
                if (Subject != null) yield return Subject;
                if (DateElement != null) yield return DateElement;
                foreach (var elem in Reaction) { if (elem != null) yield return elem; }
                if (Location != null) yield return Location;
                if (Seriousness != null) yield return Seriousness;
                if (Outcome != null) yield return Outcome;
                if (Recorder != null) yield return Recorder;
                if (EventParticipant != null) yield return EventParticipant;
                if (DescriptionElement != null) yield return DescriptionElement;
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
                if (CategoryElement != null) yield return new ElementValue("category", CategoryElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                foreach (var elem in Reaction) { if (elem != null) yield return new ElementValue("reaction", elem); }
                if (Location != null) yield return new ElementValue("location", Location);
                if (Seriousness != null) yield return new ElementValue("seriousness", Seriousness);
                if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                if (Recorder != null) yield return new ElementValue("recorder", Recorder);
                if (EventParticipant != null) yield return new ElementValue("eventParticipant", EventParticipant);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in SuspectEntity) { if (elem != null) yield return new ElementValue("suspectEntity", elem); }
                foreach (var elem in SubjectMedicalHistory) { if (elem != null) yield return new ElementValue("subjectMedicalHistory", elem); }
                foreach (var elem in ReferenceDocument) { if (elem != null) yield return new ElementValue("referenceDocument", elem); }
                foreach (var elem in Study) { if (elem != null) yield return new ElementValue("study", elem); }
            }
        }

    }

}
