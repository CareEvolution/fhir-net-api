using System;
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

        /// <summary>
        /// A code that identifies the status of the family history record.
        /// (url: http://hl7.org/fhir/ValueSet/history-status)
        /// </summary>
        [FhirEnumeration("FamilyHistoryStatus")]
        public enum FamilyHistoryStatus
        {
            /// <summary>
            /// Some health information is known and captured, but not complete - see notes for details.
            /// (system: http://hl7.org/fhir/history-status)
            /// </summary>
            [EnumLiteral("partial", "http://hl7.org/fhir/history-status"), Description("Partial")]
            Partial,
            /// <summary>
            /// All relevant health information is known and captured.
            /// (system: http://hl7.org/fhir/history-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/history-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// This instance should not have been part of this patient's medical record.
            /// (system: http://hl7.org/fhir/history-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/history-status"), Description("Entered in error")]
            EnteredInError,
            /// <summary>
            /// Health information for this individual is unavailable/unknown.
            /// (system: http://hl7.org/fhir/history-status)
            /// </summary>
            [EnumLiteral("health-unknown", "http://hl7.org/fhir/history-status"), Description("Health unknown")]
            HealthUnknown,
        }


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
            [DataMember]
            public Annotation Note
            {
                get { return _note; }
                set { _note = value; OnPropertyChanged("Note"); }
            }

            private Annotation _note;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ConditionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                    if (Onset != null) dest.Onset = (Element)Onset.DeepCopy();
                    if (Note != null) dest.Note = (Annotation)Note.DeepCopy();
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
                if (!DeepComparable.Matches(Note, otherT.Note)) return false;

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
                    if (Note != null) yield return Note;
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
                    if (Note != null) yield return new ElementValue("note", Note);
                }
            }


        }


        /// <summary>
        /// External Id(s) for this record
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Patient history is about
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
        /// When history was captured/updated
        /// </summary>
        [FhirElement("date", InSummary=true, Order=110)]
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
        /// partial | completed | entered-in-error | health-unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
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
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<FamilyHistoryStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The family member described
        /// </summary>
        [FhirElement("name", InSummary=true, Order=130)]
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
        [FhirElement("relationship", InSummary=true, Order=140)]
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
        [FhirElement("gender", InSummary=true, Order=150)]
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
                if (!value.HasValue)
                    GenderElement = null;
                else
                    GenderElement = new Code<AdministrativeGender>(value);
                OnPropertyChanged("Gender");
            }
        }

        /// <summary>
        /// (approximate) date of birth
        /// </summary>
        [FhirElement("born", Order=160, Choice=ChoiceType.DatatypeChoice)]
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
        [FhirElement("age", Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Age),typeof(Range),typeof(FhirString))]
        [DataMember]
        public Element Age
        {
            get { return _age; }
            set { _age = value; OnPropertyChanged("Age"); }
        }

        private Element _age;

        /// <summary>
        /// Dead? How old/when?
        /// </summary>
        [FhirElement("deceased", Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirBoolean),typeof(Age),typeof(Range),typeof(Date),typeof(FhirString))]
        [DataMember]
        public Element Deceased
        {
            get { return _deceased; }
            set { _deceased = value; OnPropertyChanged("Deceased"); }
        }

        private Element _deceased;

        /// <summary>
        /// General note about related person
        /// </summary>
        [FhirElement("note", Order=190)]
        [DataMember]
        public Annotation Note
        {
            get { return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private Annotation _note;

        /// <summary>
        /// Condition that the related person had
        /// </summary>
        [FhirElement("condition", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ConditionComponent> Condition
        {
            get { if (_condition == null) _condition = new List<ConditionComponent>(); return _condition; }
            set { _condition = value; OnPropertyChanged("Condition"); }
        }

        private List<ConditionComponent> _condition;


        public static ElementDefinition.ConstraintComponent FamilyMemberHistory_FHS_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "age.empty() or born.empty()",
            Key = "fhs-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Can have age[x] or born[x], but not both",
            Xpath = "not (*[starts-with(local-name(.), 'age')] and *[starts-with(local-name(.), 'birth')])"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(FamilyMemberHistory_FHS_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as FamilyMemberHistory;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<FamilyHistoryStatus>)StatusElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (Relationship != null) dest.Relationship = (CodeableConcept)Relationship.DeepCopy();
                if (GenderElement != null) dest.GenderElement = (Code<AdministrativeGender>)GenderElement.DeepCopy();
                if (Born != null) dest.Born = (Element)Born.DeepCopy();
                if (Age != null) dest.Age = (Element)Age.DeepCopy();
                if (Deceased != null) dest.Deceased = (Element)Deceased.DeepCopy();
                if (Note != null) dest.Note = (Annotation)Note.DeepCopy();
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
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
            if (!DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.Matches(Born, otherT.Born)) return false;
            if (!DeepComparable.Matches(Age, otherT.Age)) return false;
            if (!DeepComparable.Matches(Deceased, otherT.Deceased)) return false;
            if (!DeepComparable.Matches(Note, otherT.Note)) return false;
            if (!DeepComparable.Matches(Condition, otherT.Condition)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as FamilyMemberHistory;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
            if (!DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.IsExactly(Born, otherT.Born)) return false;
            if (!DeepComparable.IsExactly(Age, otherT.Age)) return false;
            if (!DeepComparable.IsExactly(Deceased, otherT.Deceased)) return false;
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
                if (Patient != null) yield return Patient;
                if (DateElement != null) yield return DateElement;
                if (StatusElement != null) yield return StatusElement;
                if (NameElement != null) yield return NameElement;
                if (Relationship != null) yield return Relationship;
                if (GenderElement != null) yield return GenderElement;
                if (Born != null) yield return Born;
                if (Age != null) yield return Age;
                if (Deceased != null) yield return Deceased;
                if (Note != null) yield return Note;
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
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (Relationship != null) yield return new ElementValue("relationship", Relationship);
                if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                if (Born != null) yield return new ElementValue("born", Born);
                if (Age != null) yield return new ElementValue("age", Age);
                if (Deceased != null) yield return new ElementValue("deceased", Deceased);
                if (Note != null) yield return new ElementValue("note", Note);
                foreach (var elem in Condition) { if (elem != null) yield return new ElementValue("condition", elem); }
            }
        }

    }

}
