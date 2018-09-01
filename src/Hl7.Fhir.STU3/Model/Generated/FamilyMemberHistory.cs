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
    /// Information about patient's relatives, relevant for patient
    /// </summary>
    [FhirType("FamilyMemberHistory", IsResource=true)]
    [DataContract]
    public partial class FamilyMemberHistory : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.FamilyMemberHistory; } }
        [NotMapped]
        public override string TypeName { get { return "FamilyMemberHistory"; } }


        [FhirType("ConditionComponent")]
        [DataContract]
        public partial class ConditionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ConditionComponent"; } }

            /// <summary>
            /// Condition suffered by relation
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
            /// deceased | permanent disability | etc.
            /// </summary>
            [FhirElement("outcome", Order=50)]
            [DataMember]
            public CodeableConcept Outcome
            {
                get { return _outcome; }
                set { _outcome = value; OnPropertyChanged("Outcome"); }
            }

            private CodeableConcept _outcome;

            /// <summary>
            /// When condition first manifested
            /// </summary>
            [FhirElement("onset", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Age),typeof(Range),typeof(Period),typeof(FhirString))]
            [DataMember]
            public Element Onset
            {
                get { return _onset; }
                set { _onset = value; OnPropertyChanged("Onset"); }
            }

            private Element _onset;

            /// <summary>
            /// Extra information about condition
            /// </summary>
            [FhirElement("note", Order=70)]
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
                var dest = other as ConditionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                    if (Onset != null) dest.Onset = (Element)Onset.DeepCopy();
                    if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ConditionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ConditionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
                if (!DeepComparable.Matches(Onset, otherT.Onset)) return false;
                if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ConditionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
                if (!DeepComparable.IsExactly(Onset, otherT.Onset)) return false;
                if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Outcome != null) yield return Outcome;
                    if (Onset != null) yield return Onset;
                    foreach (var elem in Note) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                    if (Onset != null) yield return new ElementValue("onset", Onset);
                    foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                }
            }


        }


        /// <summary>
        /// External Id(s) for this record
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
        /// Instantiates protocol or definition
        /// </summary>
        [FhirElement("definition", InSummary=true, Order=100)]
        [References("PlanDefinition","Questionnaire")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Definition
        {
            get { if (_definition==null) _definition = new List<ResourceReference>(); return _definition; }
            set { _definition = value; OnPropertyChanged("Definition"); }
        }

        private List<ResourceReference> _definition;

        /// <summary>
        /// partial | completed | entered-in-error | health-unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<FamilyHistoryStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<FamilyHistoryStatus> _statusElement;

        /// <summary>
        /// partial | completed | entered-in-error | health-unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public FamilyHistoryStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<FamilyHistoryStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The taking of a family member's history did not occur
        /// </summary>
        [FhirElement("notDone", InSummary=true, Order=120)]
        [DataMember]
        public FhirBoolean NotDoneElement
        {
            get { return _notDoneElement; }
            set { _notDoneElement = value; OnPropertyChanged("NotDoneElement"); }
        }

        private FhirBoolean _notDoneElement;

        /// <summary>
        /// The taking of a family member's history did not occur
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? NotDone
        {
            get { return NotDoneElement != null ? NotDoneElement.Value : null; }
            set
            {
                if (value == null)
                    NotDoneElement = null;
                else
                    NotDoneElement = new FhirBoolean(value);
                OnPropertyChanged("NotDone");
            }
        }

        /// <summary>
        /// subject-unknown | withheld | unable-to-obtain | deferred
        /// </summary>
        [FhirElement("notDoneReason", InSummary=true, Order=130)]
        [DataMember]
        public CodeableConcept NotDoneReason
        {
            get { return _notDoneReason; }
            set { _notDoneReason = value; OnPropertyChanged("NotDoneReason"); }
        }

        private CodeableConcept _notDoneReason;

        /// <summary>
        /// Patient history is about
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=140)]
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
        /// When history was captured/updated
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
        /// When history was captured/updated
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
        /// The family member described
        /// </summary>
        [FhirElement("name", InSummary=true, Order=160)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// The family member described
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                    NameElement = null;
                else
                    NameElement = new FhirString(value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Relationship to the subject
        /// </summary>
        [FhirElement("relationship", InSummary=true, Order=170)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Relationship
        {
            get { return _relationship; }
            set { _relationship = value; OnPropertyChanged("Relationship"); }
        }

        private CodeableConcept _relationship;

        /// <summary>
        /// male | female | other | unknown
        /// </summary>
        [FhirElement("gender", InSummary=true, Order=180)]
        [DataMember]
        public Code<AdministrativeGender> GenderElement
        {
            get { return _genderElement; }
            set { _genderElement = value; OnPropertyChanged("GenderElement"); }
        }

        private Code<AdministrativeGender> _genderElement;

        /// <summary>
        /// male | female | other | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AdministrativeGender? Gender
        {
            get { return GenderElement != null ? GenderElement.Value : null; }
            set
            {
                if (value == null)
                    GenderElement = null;
                else
                    GenderElement = new Code<AdministrativeGender>(value);
                OnPropertyChanged("Gender");
            }
        }

        /// <summary>
        /// (approximate) date of birth
        /// </summary>
        [FhirElement("born", Order=190, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Period),typeof(Date),typeof(FhirString))]
        [DataMember]
        public Element Born
        {
            get { return _born; }
            set { _born = value; OnPropertyChanged("Born"); }
        }

        private Element _born;

        /// <summary>
        /// (approximate) age
        /// </summary>
        [FhirElement("age", InSummary=true, Order=200, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Age),typeof(Range),typeof(FhirString))]
        [DataMember]
        public Element Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged("Age"); }
        }

        private Element _age;

        /// <summary>
        /// Age is estimated?
        /// </summary>
        [FhirElement("estimatedAge", InSummary=true, Order=210)]
        [DataMember]
        public FhirBoolean EstimatedAgeElement
        {
            get { return _estimatedAgeElement; }
            set { _estimatedAgeElement = value; OnPropertyChanged("EstimatedAgeElement"); }
        }

        private FhirBoolean _estimatedAgeElement;

        /// <summary>
        /// Age is estimated?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? EstimatedAge
        {
            get { return EstimatedAgeElement != null ? EstimatedAgeElement.Value : null; }
            set
            {
                if (value == null)
                    EstimatedAgeElement = null;
                else
                    EstimatedAgeElement = new FhirBoolean(value);
                OnPropertyChanged("EstimatedAge");
            }
        }

        /// <summary>
        /// Dead? How old/when?
        /// </summary>
        [FhirElement("deceased", InSummary=true, Order=220, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirBoolean),typeof(Age),typeof(Range),typeof(Date),typeof(FhirString))]
        [DataMember]
        public Element Deceased
        {
            get { return _deceased; }
            set { _deceased = value; OnPropertyChanged("Deceased"); }
        }

        private Element _deceased;

        /// <summary>
        /// Why was family member history performed?
        /// </summary>
        [FhirElement("reasonCode", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Why was family member history performed?
        /// </summary>
        [FhirElement("reasonReference", InSummary=true, Order=240)]
        [References("Condition","Observation","AllergyIntolerance","QuestionnaireResponse")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// General note about related person
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

        /// <summary>
        /// Condition that the related person had
        /// </summary>
        [FhirElement("condition", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ConditionComponent> Condition
        {
            get { if (_condition==null) _condition = new List<ConditionComponent>(); return _condition; }
            set { _condition = value; OnPropertyChanged("Condition"); }
        }

        private List<ConditionComponent> _condition;


        public static ElementDefinition.ConstraintComponent FamilyMemberHistory_FHS_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "age.exists() or estimatedAge.empty()",
            Key = "fhs-2",
            Severity = ConstraintSeverity.Warning,
            Human = "Can only have estimatedAge if age[x] is present",
            Xpath = "exists(*[starts-with(local-name(.), 'age')]) or not(exists(f:estimatedAge))"
        };

        public static ElementDefinition.ConstraintComponent FamilyMemberHistory_FHS_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "notDone or notDoneReason.exists().not()",
            Key = "fhs-3",
            Severity = ConstraintSeverity.Warning,
            Human = "Not Done Reason can only be specified if NotDone is \"true\"",
            Xpath = "f:notDone/@value=true() or not(exists(f:notDoneReason))"
        };

        public static ElementDefinition.ConstraintComponent FamilyMemberHistory_FHS_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "age.empty() or born.empty()",
            Key = "fhs-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Can have age[x] or born[x], but not both",
            Xpath = "not (*[starts-with(local-name(.), 'age')] and *[starts-with(local-name(.), 'birth')])"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(FamilyMemberHistory_FHS_2);
            InvariantConstraints.Add(FamilyMemberHistory_FHS_3);
            InvariantConstraints.Add(FamilyMemberHistory_FHS_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as FamilyMemberHistory;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Definition != null) dest.Definition = new List<ResourceReference>(Definition.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FamilyHistoryStatus>)StatusElement.DeepCopy();
                if (NotDoneElement != null) dest.NotDoneElement = (FhirBoolean)NotDoneElement.DeepCopy();
                if (NotDoneReason != null) dest.NotDoneReason = (CodeableConcept)NotDoneReason.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (Relationship != null) dest.Relationship = (CodeableConcept)Relationship.DeepCopy();
                if (GenderElement != null) dest.GenderElement = (Code<AdministrativeGender>)GenderElement.DeepCopy();
                if (Born != null) dest.Born = (Element)Born.DeepCopy();
                if (Age != null) dest.Age = (Element)Age.DeepCopy();
                if (EstimatedAgeElement != null) dest.EstimatedAgeElement = (FhirBoolean)EstimatedAgeElement.DeepCopy();
                if (Deceased != null) dest.Deceased = (Element)Deceased.DeepCopy();
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Condition != null) dest.Condition = new List<ConditionComponent>(Condition.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new FamilyMemberHistory());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as FamilyMemberHistory;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(NotDoneElement, otherT.NotDoneElement)) return false;
            if (!DeepComparable.Matches(NotDoneReason, otherT.NotDoneReason)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
            if (!DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.Matches(Born, otherT.Born)) return false;
            if (!DeepComparable.Matches(Age, otherT.Age)) return false;
            if (!DeepComparable.Matches(EstimatedAgeElement, otherT.EstimatedAgeElement)) return false;
            if (!DeepComparable.Matches(Deceased, otherT.Deceased)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Condition, otherT.Condition)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as FamilyMemberHistory;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(NotDoneElement, otherT.NotDoneElement)) return false;
            if (!DeepComparable.IsExactly(NotDoneReason, otherT.NotDoneReason)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
            if (!DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.IsExactly(Born, otherT.Born)) return false;
            if (!DeepComparable.IsExactly(Age, otherT.Age)) return false;
            if (!DeepComparable.IsExactly(EstimatedAgeElement, otherT.EstimatedAgeElement)) return false;
            if (!DeepComparable.IsExactly(Deceased, otherT.Deceased)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Condition, otherT.Condition)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in Definition) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (NotDoneElement != null) yield return NotDoneElement;
                if (NotDoneReason != null) yield return NotDoneReason;
                if (Patient != null) yield return Patient;
                if (DateElement != null) yield return DateElement;
                if (NameElement != null) yield return NameElement;
                if (Relationship != null) yield return Relationship;
                if (GenderElement != null) yield return GenderElement;
                if (Born != null) yield return Born;
                if (Age != null) yield return Age;
                if (EstimatedAgeElement != null) yield return EstimatedAgeElement;
                if (Deceased != null) yield return Deceased;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Condition) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in Definition) { if (elem != null) yield return new ElementValue("definition", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (NotDoneElement != null) yield return new ElementValue("notDone", NotDoneElement);
                if (NotDoneReason != null) yield return new ElementValue("notDoneReason", NotDoneReason);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (Relationship != null) yield return new ElementValue("relationship", Relationship);
                if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                if (Born != null) yield return new ElementValue("born", Born);
                if (Age != null) yield return new ElementValue("age", Age);
                if (EstimatedAgeElement != null) yield return new ElementValue("estimatedAge", EstimatedAgeElement);
                if (Deceased != null) yield return new ElementValue("deceased", Deceased);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Condition) { if (elem != null) yield return new ElementValue("condition", elem); }
            }
        }

    }

}
