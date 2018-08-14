using System;
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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Medical care, research study or other healthcare event causing physical injury
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "AdverseEvent", IsResource=true)]
    [DataContract]
    public partial class AdverseEvent : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.AdverseEvent; } }
        [NotMapped]
        public override string TypeName { get { return "AdverseEvent"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SuspectEntityComponent")]
        [DataContract]
        public partial class SuspectEntityComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SuspectEntityComponent"; } }
            
            /// <summary>
            /// Refers to the specific entity that caused the adverse event
            /// </summary>
            [FhirElement("instance", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [References("Immunization","Procedure","Substance","Medication","MedicationAdministration","MedicationStatement","Device")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Instance
            {
                get { return _Instance; }
                set { _Instance = value; OnPropertyChanged("Instance"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Instance;
            
            /// <summary>
            /// Information on the possible cause of the event
            /// </summary>
            [FhirElement("causality", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CausalityComponent> Causality
            {
                get { if(_Causality==null) _Causality = new List<CausalityComponent>(); return _Causality; }
                set { _Causality = value; OnPropertyChanged("Causality"); }
            }
            
            private List<CausalityComponent> _Causality;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SuspectEntityComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Instance != null) dest.Instance = (Hl7.Fhir.Model.R4.ResourceReference)Instance.DeepCopy();
                    if(Causality != null) dest.Causality = new List<CausalityComponent>(Causality.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Instance, otherT.Instance)) return false;
                if( !DeepComparable.Matches(Causality, otherT.Causality)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SuspectEntityComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Instance, otherT.Instance)) return false;
                if( !DeepComparable.IsExactly(Causality, otherT.Causality)) return false;
            
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
                    if (Instance != null) yield return new ElementValue("instance", false, Instance);
                    foreach (var elem in Causality) { if (elem != null) yield return new ElementValue("causality", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "CausalityComponent")]
        [DataContract]
        public partial class CausalityComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CausalityComponent"; } }
            
            /// <summary>
            /// Assessment of if the entity caused the event
            /// </summary>
            [FhirElement("assessment", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Assessment
            {
                get { return _Assessment; }
                set { _Assessment = value; OnPropertyChanged("Assessment"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Assessment;
            
            /// <summary>
            /// AdverseEvent.suspectEntity.causalityProductRelatedness
            /// </summary>
            [FhirElement("productRelatedness", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ProductRelatednessElement
            {
                get { return _ProductRelatednessElement; }
                set { _ProductRelatednessElement = value; OnPropertyChanged("ProductRelatednessElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ProductRelatednessElement;
            
            /// <summary>
            /// AdverseEvent.suspectEntity.causalityProductRelatedness
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string ProductRelatedness
            {
                get { return ProductRelatednessElement != null ? ProductRelatednessElement.Value : null; }
                set
                {
                    if (value == null)
                        ProductRelatednessElement = null;
                    else
                        ProductRelatednessElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("ProductRelatedness");
                }
            }
            
            /// <summary>
            /// AdverseEvent.suspectEntity.causalityAuthor
            /// </summary>
            [FhirElement("author", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [References("Practitioner","PractitionerRole")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Author
            {
                get { return _Author; }
                set { _Author = value; OnPropertyChanged("Author"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Author;
            
            /// <summary>
            /// ProbabilityScale | Bayesian | Checklist
            /// </summary>
            [FhirElement("method", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Method
            {
                get { return _Method; }
                set { _Method = value; OnPropertyChanged("Method"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Method;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CausalityComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Assessment != null) dest.Assessment = (Hl7.Fhir.Model.R4.CodeableConcept)Assessment.DeepCopy();
                    if(ProductRelatednessElement != null) dest.ProductRelatednessElement = (Hl7.Fhir.Model.FhirString)ProductRelatednessElement.DeepCopy();
                    if(Author != null) dest.Author = (Hl7.Fhir.Model.R4.ResourceReference)Author.DeepCopy();
                    if(Method != null) dest.Method = (Hl7.Fhir.Model.R4.CodeableConcept)Method.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Assessment, otherT.Assessment)) return false;
                if( !DeepComparable.Matches(ProductRelatednessElement, otherT.ProductRelatednessElement)) return false;
                if( !DeepComparable.Matches(Author, otherT.Author)) return false;
                if( !DeepComparable.Matches(Method, otherT.Method)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CausalityComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Assessment, otherT.Assessment)) return false;
                if( !DeepComparable.IsExactly(ProductRelatednessElement, otherT.ProductRelatednessElement)) return false;
                if( !DeepComparable.IsExactly(Author, otherT.Author)) return false;
                if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
            
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
                    if (Assessment != null) yield return new ElementValue("assessment", false, Assessment);
                    if (ProductRelatednessElement != null) yield return new ElementValue("productRelatedness", false, ProductRelatednessElement);
                    if (Author != null) yield return new ElementValue("author", false, Author);
                    if (Method != null) yield return new ElementValue("method", false, Method);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Business identifier for the event
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.R4.Identifier _Identifier;
        
        /// <summary>
        /// actual | potential
        /// </summary>
        [FhirElement("actuality", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code ActualityElement
        {
            get { return _ActualityElement; }
            set { _ActualityElement = value; OnPropertyChanged("ActualityElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _ActualityElement;
        
        /// <summary>
        /// actual | potential
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Actuality
        {
            get { return ActualityElement != null ? ActualityElement.Value : null; }
            set
            {
                if (value == null)
                    ActualityElement = null;
                else
                    ActualityElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Actuality");
            }
        }
        
        /// <summary>
        /// ProductProblem | ProductQuality | ProductUseError | WrongDose | IncorrectPrescribingInformation | WrongTechnique | WrongRouteOfAdministration | WrongRate | WrongDuration | WrongTime | ExpiredDrug | MedicalDeviceUseError | ProblemDifferentManufacturer | UnsafePhysicalEnvironment
        /// </summary>
        [FhirElement("category", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> Category
        {
            get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Category; }
            set { _Category = value; OnPropertyChanged("Category"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _Category;
        
        /// <summary>
        /// Type of the event itself in relation to the subject
        /// </summary>
        [FhirElement("event", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Event
        {
            get { return _Event; }
            set { _Event = value; OnPropertyChanged("Event"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Event;
        
        /// <summary>
        /// Subject impacted by event
        /// </summary>
        [FhirElement("subject", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [References("Patient","Group","Practitioner","RelatedPerson")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Subject;
        
        /// <summary>
        /// Encounter or episode of care that establishes the context for this AdverseEvent
        /// </summary>
        [FhirElement("context", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Context
        {
            get { return _Context; }
            set { _Context = value; OnPropertyChanged("Context"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Context;
        
        /// <summary>
        /// When the event occurred
        /// </summary>
        [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
        
        /// <summary>
        /// When the event occurred
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
                    DateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Effect on the subject due to this event
        /// </summary>
        [FhirElement("resultingCondition", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [References("Condition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> ResultingCondition
        {
            get { if(_ResultingCondition==null) _ResultingCondition = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _ResultingCondition; }
            set { _ResultingCondition = value; OnPropertyChanged("ResultingCondition"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _ResultingCondition;
        
        /// <summary>
        /// Location where adverse event occurred
        /// </summary>
        [FhirElement("location", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [References("Location")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Location
        {
            get { return _Location; }
            set { _Location = value; OnPropertyChanged("Location"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Location;
        
        /// <summary>
        /// Seriousness of the event
        /// </summary>
        [FhirElement("seriousness", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Seriousness
        {
            get { return _Seriousness; }
            set { _Seriousness = value; OnPropertyChanged("Seriousness"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Seriousness;
        
        /// <summary>
        /// Mild | Moderate | Severe
        /// </summary>
        [FhirElement("severity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Severity
        {
            get { return _Severity; }
            set { _Severity = value; OnPropertyChanged("Severity"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Severity;
        
        /// <summary>
        /// resolved | recovering | ongoing | resolvedWithSequelae | fatal | unknown
        /// </summary>
        [FhirElement("outcome", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Outcome
        {
            get { return _Outcome; }
            set { _Outcome = value; OnPropertyChanged("Outcome"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Outcome;
        
        /// <summary>
        /// Who recorded the adverse event
        /// </summary>
        [FhirElement("recorder", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [References("Patient","Practitioner","RelatedPerson")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Recorder
        {
            get { return _Recorder; }
            set { _Recorder = value; OnPropertyChanged("Recorder"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Recorder;
        
        /// <summary>
        /// Who  was involved in the adverse event or the potential adverse event
        /// </summary>
        [FhirElement("contributor", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [References("Practitioner","Device")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Contributor
        {
            get { if(_Contributor==null) _Contributor = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Contributor; }
            set { _Contributor = value; OnPropertyChanged("Contributor"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Contributor;
        
        /// <summary>
        /// The suspected agent causing the adverse event
        /// </summary>
        [FhirElement("suspectEntity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SuspectEntityComponent> SuspectEntity
        {
            get { if(_SuspectEntity==null) _SuspectEntity = new List<SuspectEntityComponent>(); return _SuspectEntity; }
            set { _SuspectEntity = value; OnPropertyChanged("SuspectEntity"); }
        }
        
        private List<SuspectEntityComponent> _SuspectEntity;
        
        /// <summary>
        /// AdverseEvent.subjectMedicalHistory
        /// </summary>
        [FhirElement("subjectMedicalHistory", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=240)]
        [CLSCompliant(false)]
        [References("Condition","Observation","AllergyIntolerance","FamilyMemberHistory","Immunization","Procedure","Media","DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> SubjectMedicalHistory
        {
            get { if(_SubjectMedicalHistory==null) _SubjectMedicalHistory = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _SubjectMedicalHistory; }
            set { _SubjectMedicalHistory = value; OnPropertyChanged("SubjectMedicalHistory"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _SubjectMedicalHistory;
        
        /// <summary>
        /// AdverseEvent.referenceDocument
        /// </summary>
        [FhirElement("referenceDocument", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=250)]
        [CLSCompliant(false)]
        [References("DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> ReferenceDocument
        {
            get { if(_ReferenceDocument==null) _ReferenceDocument = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _ReferenceDocument; }
            set { _ReferenceDocument = value; OnPropertyChanged("ReferenceDocument"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _ReferenceDocument;
        
        /// <summary>
        /// AdverseEvent.study
        /// </summary>
        [FhirElement("study", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=260)]
        [CLSCompliant(false)]
        [References("ResearchStudy")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Study
        {
            get { if(_Study==null) _Study = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Study; }
            set { _Study = value; OnPropertyChanged("Study"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Study;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as AdverseEvent;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
                if(ActualityElement != null) dest.ActualityElement = (Hl7.Fhir.Model.R4.Code)ActualityElement.DeepCopy();
                if(Category != null) dest.Category = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Category.DeepCopy());
                if(Event != null) dest.Event = (Hl7.Fhir.Model.R4.CodeableConcept)Event.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.R4.ResourceReference)Subject.DeepCopy();
                if(Context != null) dest.Context = (Hl7.Fhir.Model.R4.ResourceReference)Context.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                if(ResultingCondition != null) dest.ResultingCondition = new List<Hl7.Fhir.Model.R4.ResourceReference>(ResultingCondition.DeepCopy());
                if(Location != null) dest.Location = (Hl7.Fhir.Model.R4.ResourceReference)Location.DeepCopy();
                if(Seriousness != null) dest.Seriousness = (Hl7.Fhir.Model.R4.CodeableConcept)Seriousness.DeepCopy();
                if(Severity != null) dest.Severity = (Hl7.Fhir.Model.R4.CodeableConcept)Severity.DeepCopy();
                if(Outcome != null) dest.Outcome = (Hl7.Fhir.Model.R4.CodeableConcept)Outcome.DeepCopy();
                if(Recorder != null) dest.Recorder = (Hl7.Fhir.Model.R4.ResourceReference)Recorder.DeepCopy();
                if(Contributor != null) dest.Contributor = new List<Hl7.Fhir.Model.R4.ResourceReference>(Contributor.DeepCopy());
                if(SuspectEntity != null) dest.SuspectEntity = new List<SuspectEntityComponent>(SuspectEntity.DeepCopy());
                if(SubjectMedicalHistory != null) dest.SubjectMedicalHistory = new List<Hl7.Fhir.Model.R4.ResourceReference>(SubjectMedicalHistory.DeepCopy());
                if(ReferenceDocument != null) dest.ReferenceDocument = new List<Hl7.Fhir.Model.R4.ResourceReference>(ReferenceDocument.DeepCopy());
                if(Study != null) dest.Study = new List<Hl7.Fhir.Model.R4.ResourceReference>(Study.DeepCopy());
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(ActualityElement, otherT.ActualityElement)) return false;
            if( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if( !DeepComparable.Matches(Event, otherT.Event)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Context, otherT.Context)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(ResultingCondition, otherT.ResultingCondition)) return false;
            if( !DeepComparable.Matches(Location, otherT.Location)) return false;
            if( !DeepComparable.Matches(Seriousness, otherT.Seriousness)) return false;
            if( !DeepComparable.Matches(Severity, otherT.Severity)) return false;
            if( !DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
            if( !DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if( !DeepComparable.Matches(Contributor, otherT.Contributor)) return false;
            if( !DeepComparable.Matches(SuspectEntity, otherT.SuspectEntity)) return false;
            if( !DeepComparable.Matches(SubjectMedicalHistory, otherT.SubjectMedicalHistory)) return false;
            if( !DeepComparable.Matches(ReferenceDocument, otherT.ReferenceDocument)) return false;
            if( !DeepComparable.Matches(Study, otherT.Study)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as AdverseEvent;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(ActualityElement, otherT.ActualityElement)) return false;
            if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if( !DeepComparable.IsExactly(Event, otherT.Event)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(ResultingCondition, otherT.ResultingCondition)) return false;
            if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if( !DeepComparable.IsExactly(Seriousness, otherT.Seriousness)) return false;
            if( !DeepComparable.IsExactly(Severity, otherT.Severity)) return false;
            if( !DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
            if( !DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if( !DeepComparable.IsExactly(Contributor, otherT.Contributor)) return false;
            if( !DeepComparable.IsExactly(SuspectEntity, otherT.SuspectEntity)) return false;
            if( !DeepComparable.IsExactly(SubjectMedicalHistory, otherT.SubjectMedicalHistory)) return false;
            if( !DeepComparable.IsExactly(ReferenceDocument, otherT.ReferenceDocument)) return false;
            if( !DeepComparable.IsExactly(Study, otherT.Study)) return false;
        
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
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                if (ActualityElement != null) yield return new ElementValue("actuality", false, ActualityElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", true, elem); }
                if (Event != null) yield return new ElementValue("event", false, Event);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (Context != null) yield return new ElementValue("context", false, Context);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                foreach (var elem in ResultingCondition) { if (elem != null) yield return new ElementValue("resultingCondition", true, elem); }
                if (Location != null) yield return new ElementValue("location", false, Location);
                if (Seriousness != null) yield return new ElementValue("seriousness", false, Seriousness);
                if (Severity != null) yield return new ElementValue("severity", false, Severity);
                if (Outcome != null) yield return new ElementValue("outcome", false, Outcome);
                if (Recorder != null) yield return new ElementValue("recorder", false, Recorder);
                foreach (var elem in Contributor) { if (elem != null) yield return new ElementValue("contributor", true, elem); }
                foreach (var elem in SuspectEntity) { if (elem != null) yield return new ElementValue("suspectEntity", true, elem); }
                foreach (var elem in SubjectMedicalHistory) { if (elem != null) yield return new ElementValue("subjectMedicalHistory", true, elem); }
                foreach (var elem in ReferenceDocument) { if (elem != null) yield return new ElementValue("referenceDocument", true, elem); }
                foreach (var elem in Study) { if (elem != null) yield return new ElementValue("study", true, elem); }
            }
        }
    
    }

}
