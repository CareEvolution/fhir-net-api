using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Record of medication being taken by a patient
    /// </summary>
    [FhirType("MedicationStatement", IsResource=true)]
    [DataContract]
    public partial class MedicationStatement : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationStatement; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationStatement"; } }

        /// <summary>
        /// A coded concept indicating the current status of a MedicationStatement.
        /// (url: http://hl7.org/fhir/ValueSet/medication-statement-status)
        /// </summary>
        [FhirEnumeration("MedicationStatementStatus")]
        public enum MedicationStatementStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/medication-statement-status"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/medication-statement-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/medication-statement-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("intended", "http://hl7.org/fhir/medication-statement-status"), Description("Intended")]
            Intended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("stopped", "http://hl7.org/fhir/medication-statement-status"), Description("Stopped")]
            Stopped,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-status)
            /// </summary>
            [EnumLiteral("on-hold", "http://hl7.org/fhir/medication-statement-status"), Description("On Hold")]
            OnHold,
        }

        /// <summary>
        /// A coded concept identifying level of certainty if patient has taken or has not taken the medication
        /// (url: http://hl7.org/fhir/ValueSet/medication-statement-taken)
        /// </summary>
        [FhirEnumeration("MedicationStatementTaken")]
        public enum MedicationStatementTaken
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-taken)
            /// </summary>
            [EnumLiteral("y", "http://hl7.org/fhir/medication-statement-taken"), Description("Yes")]
            Y,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-taken)
            /// </summary>
            [EnumLiteral("n", "http://hl7.org/fhir/medication-statement-taken"), Description("No")]
            N,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-taken)
            /// </summary>
            [EnumLiteral("unk", "http://hl7.org/fhir/medication-statement-taken"), Description("Unknown")]
            Unk,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-statement-taken)
            /// </summary>
            [EnumLiteral("na", "http://hl7.org/fhir/medication-statement-taken"), Description("Not Applicable")]
            Na,
        }


        /// <summary>
        /// External identifier
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
        /// Fulfils plan, proposal or order
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=100)]
        [References("MedicationRequest","CarePlan","ProcedureRequest","ReferralRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Part of referenced event
        /// </summary>
        [FhirElement("partOf", InSummary=true, Order=110)]
        [References("MedicationAdministration","MedicationDispense","MedicationStatement","Procedure","Observation")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// Encounter / Episode associated with MedicationStatement
        /// </summary>
        [FhirElement("context", InSummary=true, Order=120)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// active | completed | entered-in-error | intended | stopped | on-hold
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MedicationStatementStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationStatementStatus> _statusElement;

        /// <summary>
        /// active | completed | entered-in-error | intended | stopped | on-hold
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationStatementStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationStatementStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Type of medication usage
        /// </summary>
        [FhirElement("category", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// What medication was taken
        /// </summary>
        [FhirElement("medication", InSummary=true, Order=150, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Medication
        {
            get { return _medication; }
            set { _medication = value; OnPropertyChanged("Medication"); }
        }

        private Element _medication;

        /// <summary>
        /// The date/time or interval when the medication was taken
        /// </summary>
        [FhirElement("effective", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [DataMember]
        public Element Effective
        {
            get { return _effective; }
            set { _effective = value; OnPropertyChanged("Effective"); }
        }

        private Element _effective;

        /// <summary>
        /// When the statement was asserted?
        /// </summary>
        [FhirElement("dateAsserted", InSummary=true, Order=170)]
        [DataMember]
        public FhirDateTime DateAssertedElement
        {
            get { return _dateAssertedElement; }
            set { _dateAssertedElement = value; OnPropertyChanged("DateAssertedElement"); }
        }

        private FhirDateTime _dateAssertedElement;

        /// <summary>
        /// When the statement was asserted?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateAsserted
        {
            get { return DateAssertedElement != null ? DateAssertedElement.Value : null; }
            set
            {
                if (value == null)
                    DateAssertedElement = null;
                else
                    DateAssertedElement = new FhirDateTime(value);
                OnPropertyChanged("DateAsserted");
            }
        }

        /// <summary>
        /// Person or organization that provided the information about the taking of this medication
        /// </summary>
        [FhirElement("informationSource", Order=180)]
        [References("Patient","Practitioner","RelatedPerson","Organization")]
        [DataMember]
        public ResourceReference InformationSource
        {
            get { return _informationSource; }
            set { _informationSource = value; OnPropertyChanged("InformationSource"); }
        }

        private ResourceReference _informationSource;

        /// <summary>
        /// Who is/was taking  the medication
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=190)]
        [References("Patient","Group")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Additional supporting information
        /// </summary>
        [FhirElement("derivedFrom", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> DerivedFrom
        {
            get { if (_derivedFrom==null) _derivedFrom = new List<ResourceReference>(); return _derivedFrom; }
            set { _derivedFrom = value; OnPropertyChanged("DerivedFrom"); }
        }

        private List<ResourceReference> _derivedFrom;

        /// <summary>
        /// y | n | unk | na
        /// </summary>
        [FhirElement("taken", InSummary=true, Order=210)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MedicationStatementTaken> TakenElement
        {
            get { return _takenElement; }
            set { _takenElement = value; OnPropertyChanged("TakenElement"); }
        }

        private Code<MedicationStatementTaken> _takenElement;

        /// <summary>
        /// y | n | unk | na
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationStatementTaken? Taken
        {
            get { return TakenElement != null ? TakenElement.Value : null; }
            set
            {
                if (value == null)
                    TakenElement = null;
                else
                    TakenElement = new Code<MedicationStatementTaken>(value);
                OnPropertyChanged("Taken");
            }
        }

        /// <summary>
        /// True if asserting medication was not given
        /// </summary>
        [FhirElement("reasonNotTaken", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonNotTaken
        {
            get { if (_reasonNotTaken==null) _reasonNotTaken = new List<CodeableConcept>(); return _reasonNotTaken; }
            set { _reasonNotTaken = value; OnPropertyChanged("ReasonNotTaken"); }
        }

        private List<CodeableConcept> _reasonNotTaken;

        /// <summary>
        /// Reason for why the medication is being/was taken
        /// </summary>
        [FhirElement("reasonCode", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Condition or observation that supports why the medication is being/was taken
        /// </summary>
        [FhirElement("reasonReference", Order=240)]
        [References("Condition","Observation")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// Further information about the statement
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
        /// Details of how medication is/was taken or should be taken
        /// </summary>
        [FhirElement("dosage", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Dosage> Dosage
        {
            get { if (_dosage==null) _dosage = new List<Dosage>(); return _dosage; }
            set { _dosage = value; OnPropertyChanged("Dosage"); }
        }

        private List<Dosage> _dosage;


        public static ElementDefinition.ConstraintComponent MedicationStatement_MST_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "reasonNotTaken.exists().not() or (taken = 'n')",
            Key = "mst-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Reason not taken is only permitted if Taken is No",
            Xpath = "not(exists(f:reasonNotTaken)) or f:taken/@value='n'"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(MedicationStatement_MST_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationStatement;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<MedicationStatementStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                if (Effective != null) dest.Effective = (Element)Effective.DeepCopy();
                if (DateAssertedElement != null) dest.DateAssertedElement = (FhirDateTime)DateAssertedElement.DeepCopy();
                if (InformationSource != null) dest.InformationSource = (ResourceReference)InformationSource.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (DerivedFrom != null) dest.DerivedFrom = new List<ResourceReference>(DerivedFrom.DeepCopy());
                if (TakenElement != null) dest.TakenElement = (Code<MedicationStatementTaken>)TakenElement.DeepCopy();
                if (ReasonNotTaken != null) dest.ReasonNotTaken = new List<CodeableConcept>(ReasonNotTaken.DeepCopy());
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Dosage != null) dest.Dosage = new List<Dosage>(Dosage.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationStatement());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationStatement;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;
            if (!DeepComparable.Matches(DateAssertedElement, otherT.DateAssertedElement)) return false;
            if (!DeepComparable.Matches(InformationSource, otherT.InformationSource)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(DerivedFrom, otherT.DerivedFrom)) return false;
            if (!DeepComparable.Matches(TakenElement, otherT.TakenElement)) return false;
            if ( !DeepComparable.Matches(ReasonNotTaken, otherT.ReasonNotTaken)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Dosage, otherT.Dosage)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationStatement;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
            if (!DeepComparable.IsExactly(DateAssertedElement, otherT.DateAssertedElement)) return false;
            if (!DeepComparable.IsExactly(InformationSource, otherT.InformationSource)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(DerivedFrom, otherT.DerivedFrom)) return false;
            if (!DeepComparable.IsExactly(TakenElement, otherT.TakenElement)) return false;
            if (!DeepComparable.IsExactly(ReasonNotTaken, otherT.ReasonNotTaken)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (Context != null) yield return Context;
                if (StatusElement != null) yield return StatusElement;
                if (Category != null) yield return Category;
                if (Medication != null) yield return Medication;
                if (Effective != null) yield return Effective;
                if (DateAssertedElement != null) yield return DateAssertedElement;
                if (InformationSource != null) yield return InformationSource;
                if (Subject != null) yield return Subject;
                foreach (var elem in DerivedFrom) { if (elem != null) yield return elem; }
                if (TakenElement != null) yield return TakenElement;
                foreach (var elem in ReasonNotTaken) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Dosage) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (Context != null) yield return new ElementValue("context", Context);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Category != null) yield return new ElementValue("category", Category);
                if (Medication != null) yield return new ElementValue("medication", Medication);
                if (Effective != null) yield return new ElementValue("effective", Effective);
                if (DateAssertedElement != null) yield return new ElementValue("dateAsserted", DateAssertedElement);
                if (InformationSource != null) yield return new ElementValue("informationSource", InformationSource);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                foreach (var elem in DerivedFrom) { if (elem != null) yield return new ElementValue("derivedFrom", elem); }
                if (TakenElement != null) yield return new ElementValue("taken", TakenElement);
                foreach (var elem in ReasonNotTaken) { if (elem != null) yield return new ElementValue("reasonNotTaken", elem); }
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", elem); }
            }
        }

    }

}
