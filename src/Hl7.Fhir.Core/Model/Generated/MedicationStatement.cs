﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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
        [References("MedicationRequest","CarePlan","ServiceRequest")]
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
        /// active | completed | entered-in-error | intended | stopped | on-hold | unknown | not-taken
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MedicationStatementStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationStatementStatus> _statusElement;

        /// <summary>
        /// active | completed | entered-in-error | intended | stopped | on-hold | unknown | not-taken
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
        /// Reason for current status
        /// </summary>
        [FhirElement("statusReason", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> StatusReason
        {
            get { if (_statusReason==null) _statusReason = new List<CodeableConcept>(); return _statusReason; }
            set { _statusReason = value; OnPropertyChanged("StatusReason"); }
        }

        private List<CodeableConcept> _statusReason;

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
        /// Who is/was taking  the medication
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=160)]
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
        /// Encounter / Episode associated with MedicationStatement
        /// </summary>
        [FhirElement("context", InSummary=true, Order=170)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// The date/time or interval when the medication is/was/will taken
        /// </summary>
        [FhirElement("effective", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
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
        [FhirElement("dateAsserted", InSummary=true, Order=190)]
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
        [FhirElement("informationSource", Order=200)]
        [References("Patient","Practitioner","RelatedPerson","Organization")]
        [DataMember]
        public ResourceReference InformationSource
        {
            get { return _informationSource; }
            set { _informationSource = value; OnPropertyChanged("InformationSource"); }
        }

        private ResourceReference _informationSource;

        /// <summary>
        /// Additional supporting information
        /// </summary>
        [FhirElement("derivedFrom", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> DerivedFrom
        {
            get { if (_derivedFrom==null) _derivedFrom = new List<ResourceReference>(); return _derivedFrom; }
            set { _derivedFrom = value; OnPropertyChanged("DerivedFrom"); }
        }

        private List<ResourceReference> _derivedFrom;

        /// <summary>
        /// Reason for why the medication is being/was taken
        /// </summary>
        [FhirElement("reasonCode", Order=220)]
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
        [FhirElement("reasonReference", Order=230)]
        [References("Condition","Observation","DiagnosticReport")]
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
        [FhirElement("note", Order=240)]
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
        [FhirElement("dosage", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Dosage> Dosage
        {
            get { if (_dosage==null) _dosage = new List<Dosage>(); return _dosage; }
            set { _dosage = value; OnPropertyChanged("Dosage"); }
        }

        private List<Dosage> _dosage;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationStatement;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<MedicationStatementStatus>)StatusElement.DeepCopy();
                if (StatusReason != null) dest.StatusReason = new List<CodeableConcept>(StatusReason.DeepCopy());
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Effective != null) dest.Effective = (Element)Effective.DeepCopy();
                if (DateAssertedElement != null) dest.DateAssertedElement = (FhirDateTime)DateAssertedElement.DeepCopy();
                if (InformationSource != null) dest.InformationSource = (ResourceReference)InformationSource.DeepCopy();
                if (DerivedFrom != null) dest.DerivedFrom = new List<ResourceReference>(DerivedFrom.DeepCopy());
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
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;
            if (!DeepComparable.Matches(DateAssertedElement, otherT.DateAssertedElement)) return false;
            if (!DeepComparable.Matches(InformationSource, otherT.InformationSource)) return false;
            if ( !DeepComparable.Matches(DerivedFrom, otherT.DerivedFrom)) return false;
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
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
            if (!DeepComparable.IsExactly(DateAssertedElement, otherT.DateAssertedElement)) return false;
            if (!DeepComparable.IsExactly(InformationSource, otherT.InformationSource)) return false;
            if (!DeepComparable.IsExactly(DerivedFrom, otherT.DerivedFrom)) return false;
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
                if (StatusElement != null) yield return StatusElement;
                foreach (var elem in StatusReason) { if (elem != null) yield return elem; }
                if (Category != null) yield return Category;
                if (Medication != null) yield return Medication;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Effective != null) yield return Effective;
                if (DateAssertedElement != null) yield return DateAssertedElement;
                if (InformationSource != null) yield return InformationSource;
                foreach (var elem in DerivedFrom) { if (elem != null) yield return elem; }
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
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", true, elem); }
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                foreach (var elem in StatusReason) { if (elem != null) yield return new ElementValue("statusReason", true, elem); }
                if (Category != null) yield return new ElementValue("category", false, Category);
                if (Medication != null) yield return new ElementValue("medication", false, Medication);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (Context != null) yield return new ElementValue("context", false, Context);
                if (Effective != null) yield return new ElementValue("effective", false, Effective);
                if (DateAssertedElement != null) yield return new ElementValue("dateAsserted", false, DateAssertedElement);
                if (InformationSource != null) yield return new ElementValue("informationSource", false, InformationSource);
                foreach (var elem in DerivedFrom) { if (elem != null) yield return new ElementValue("derivedFrom", true, elem); }
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", true, elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", true, elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", true, elem); }
                foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", true, elem); }
            }
        }

    }

}
