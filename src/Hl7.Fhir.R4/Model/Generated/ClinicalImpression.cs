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
    /// A clinical assessment performed when planning treatments and management strategies for a patient
    /// </summary>
    [FhirType("ClinicalImpression", IsResource=true)]
    [DataContract]
    public partial class ClinicalImpression : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ClinicalImpression; } }
        [NotMapped]
        public override string TypeName { get { return "ClinicalImpression"; } }

        /// <summary>
        /// Codes identifying the lifecycle stage of a clinical impression
        /// (url: http://hl7.org/fhir/ValueSet/clinicalimpression-status)
        /// </summary>
        [FhirEnumeration("ClinicalImpressionStatus")]
        public enum ClinicalImpressionStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/event-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/event-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/event-status"), Description("Entered in Error")]
            EnteredInError,
        }


        [FhirType("InvestigationComponent")]
        [DataContract]
        public partial class InvestigationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InvestigationComponent"; } }

            /// <summary>
            /// A name/code for the set
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
            /// Record of a specific investigation
            /// </summary>
            [FhirElement("item", Order=50)]
            [References("Observation","QuestionnaireResponse","FamilyMemberHistory","DiagnosticReport","RiskAssessment","ImagingStudy","Media")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Item
            {
                get { if (_item==null) _item = new List<ResourceReference>(); return _item; }
                set { _item = value; OnPropertyChanged("Item"); }
            }

            private List<ResourceReference> _item;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InvestigationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Item != null) dest.Item = new List<ResourceReference>(Item.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InvestigationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InvestigationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if ( !DeepComparable.Matches(Item, otherT.Item)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InvestigationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in Item) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
                }
            }


        }


        [FhirType("FindingComponent")]
        [DataContract]
        public partial class FindingComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FindingComponent"; } }

            /// <summary>
            /// What was found
            /// </summary>
            [FhirElement("itemCodeableConcept", Order=40)]
            [DataMember]
            public CodeableConcept ItemCodeableConcept
            {
                get { return _itemCodeableConcept; }
                set { _itemCodeableConcept = value; OnPropertyChanged("ItemCodeableConcept"); }
            }

            private CodeableConcept _itemCodeableConcept;

            /// <summary>
            /// What was found
            /// </summary>
            [FhirElement("itemReference", Order=50)]
            [References("Condition","Observation","Media")]
            [DataMember]
            public ResourceReference ItemReference
            {
                get { return _itemReference; }
                set { _itemReference = value; OnPropertyChanged("ItemReference"); }
            }

            private ResourceReference _itemReference;

            /// <summary>
            /// Which investigations support finding
            /// </summary>
            [FhirElement("basis", Order=60)]
            [DataMember]
            public FhirString BasisElement
            {
                get { return _basisElement; }
                set { _basisElement = value; OnPropertyChanged("BasisElement"); }
            }

            private FhirString _basisElement;

            /// <summary>
            /// Which investigations support finding
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Basis
            {
                get { return BasisElement != null ? BasisElement.Value : null; }
                set
                {
                    if (value == null)
                        BasisElement = null;
                    else
                        BasisElement = new FhirString(value);
                    OnPropertyChanged("Basis");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FindingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ItemCodeableConcept != null) dest.ItemCodeableConcept = (CodeableConcept)ItemCodeableConcept.DeepCopy();
                    if (ItemReference != null) dest.ItemReference = (ResourceReference)ItemReference.DeepCopy();
                    if (BasisElement != null) dest.BasisElement = (FhirString)BasisElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FindingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FindingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ItemCodeableConcept, otherT.ItemCodeableConcept)) return false;
                if (!DeepComparable.Matches(ItemReference, otherT.ItemReference)) return false;
                if (!DeepComparable.Matches(BasisElement, otherT.BasisElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FindingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ItemCodeableConcept, otherT.ItemCodeableConcept)) return false;
                if (!DeepComparable.IsExactly(ItemReference, otherT.ItemReference)) return false;
                if (!DeepComparable.IsExactly(BasisElement, otherT.BasisElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ItemCodeableConcept != null) yield return ItemCodeableConcept;
                    if (ItemReference != null) yield return ItemReference;
                    if (BasisElement != null) yield return BasisElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ItemCodeableConcept != null) yield return new ElementValue("itemCodeableConcept", ItemCodeableConcept);
                    if (ItemReference != null) yield return new ElementValue("itemReference", ItemReference);
                    if (BasisElement != null) yield return new ElementValue("basis", BasisElement);
                }
            }


        }


        /// <summary>
        /// Business identifier
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
        /// draft | completed | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ClinicalImpressionStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ClinicalImpressionStatus> _statusElement;

        /// <summary>
        /// draft | completed | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ClinicalImpressionStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ClinicalImpressionStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Reason for current status
        /// </summary>
        [FhirElement("statusReason", Order=110)]
        [DataMember]
        public CodeableConcept StatusReason
        {
            get { return _statusReason; }
            set { _statusReason = value; OnPropertyChanged("StatusReason"); }
        }

        private CodeableConcept _statusReason;

        /// <summary>
        /// Kind of assessment performed
        /// </summary>
        [FhirElement("code", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Why/how the assessment was performed
        /// </summary>
        [FhirElement("description", InSummary=true, Order=130)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Why/how the assessment was performed
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
        /// Patient or group assessed
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=140)]
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
        /// Encounter or Episode created from
        /// </summary>
        [FhirElement("context", InSummary=true, Order=150)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// Time of assessment
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
        /// When the assessment was documented
        /// </summary>
        [FhirElement("date", InSummary=true, Order=170)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// When the assessment was documented
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
        /// The clinician performing the assessment
        /// </summary>
        [FhirElement("assessor", InSummary=true, Order=180)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Assessor
        {
            get { return _assessor; }
            set { _assessor = value; OnPropertyChanged("Assessor"); }
        }

        private ResourceReference _assessor;

        /// <summary>
        /// Reference to last assessment
        /// </summary>
        [FhirElement("previous", Order=190)]
        [References("ClinicalImpression")]
        [DataMember]
        public ResourceReference Previous
        {
            get { return _previous; }
            set { _previous = value; OnPropertyChanged("Previous"); }
        }

        private ResourceReference _previous;

        /// <summary>
        /// Relevant impressions of patient state
        /// </summary>
        [FhirElement("problem", InSummary=true, Order=200)]
        [References("Condition","AllergyIntolerance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Problem
        {
            get { if (_problem==null) _problem = new List<ResourceReference>(); return _problem; }
            set { _problem = value; OnPropertyChanged("Problem"); }
        }

        private List<ResourceReference> _problem;

        /// <summary>
        /// One or more sets of investigations (signs, symptoms, etc.)
        /// </summary>
        [FhirElement("investigation", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<InvestigationComponent> Investigation
        {
            get { if (_investigation==null) _investigation = new List<InvestigationComponent>(); return _investigation; }
            set { _investigation = value; OnPropertyChanged("Investigation"); }
        }

        private List<InvestigationComponent> _investigation;

        /// <summary>
        /// Clinical Protocol followed
        /// </summary>
        [FhirElement("protocol", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> ProtocolElement
        {
            get { if (_protocolElement==null) _protocolElement = new List<FhirUri>(); return _protocolElement; }
            set { _protocolElement = value; OnPropertyChanged("ProtocolElement"); }
        }

        private List<FhirUri> _protocolElement;

        /// <summary>
        /// Clinical Protocol followed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Protocol
        {
            get { return ProtocolElement != null ? ProtocolElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ProtocolElement = null;
                else
                    ProtocolElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("Protocol");
            }
        }

        /// <summary>
        /// Summary of the assessment
        /// </summary>
        [FhirElement("summary", Order=230)]
        [DataMember]
        public FhirString SummaryElement
        {
            get { return _summaryElement; }
            set { _summaryElement = value; OnPropertyChanged("SummaryElement"); }
        }

        private FhirString _summaryElement;

        /// <summary>
        /// Summary of the assessment
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Summary
        {
            get { return SummaryElement != null ? SummaryElement.Value : null; }
            set
            {
                if (value == null)
                    SummaryElement = null;
                else
                    SummaryElement = new FhirString(value);
                OnPropertyChanged("Summary");
            }
        }

        /// <summary>
        /// Possible or likely findings and diagnoses
        /// </summary>
        [FhirElement("finding", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FindingComponent> Finding
        {
            get { if (_finding==null) _finding = new List<FindingComponent>(); return _finding; }
            set { _finding = value; OnPropertyChanged("Finding"); }
        }

        private List<FindingComponent> _finding;

        /// <summary>
        /// Estimate of likely outcome
        /// </summary>
        [FhirElement("prognosisCodeableConcept", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> PrognosisCodeableConcept
        {
            get { if (_prognosisCodeableConcept==null) _prognosisCodeableConcept = new List<CodeableConcept>(); return _prognosisCodeableConcept; }
            set { _prognosisCodeableConcept = value; OnPropertyChanged("PrognosisCodeableConcept"); }
        }

        private List<CodeableConcept> _prognosisCodeableConcept;

        /// <summary>
        /// RiskAssessment expressing likely outcome
        /// </summary>
        [FhirElement("prognosisReference", Order=260)]
        [References("RiskAssessment")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PrognosisReference
        {
            get { if (_prognosisReference==null) _prognosisReference = new List<ResourceReference>(); return _prognosisReference; }
            set { _prognosisReference = value; OnPropertyChanged("PrognosisReference"); }
        }

        private List<ResourceReference> _prognosisReference;

        /// <summary>
        /// Information supporting the clinical impression
        /// </summary>
        [FhirElement("supportingInfo", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInfo
        {
            get { if (_supportingInfo==null) _supportingInfo = new List<ResourceReference>(); return _supportingInfo; }
            set { _supportingInfo = value; OnPropertyChanged("SupportingInfo"); }
        }

        private List<ResourceReference> _supportingInfo;

        /// <summary>
        /// Comments made about the ClinicalImpression
        /// </summary>
        [FhirElement("note", Order=280)]
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
            var dest = other as ClinicalImpression;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<ClinicalImpressionStatus>)StatusElement.DeepCopy();
                if (StatusReason != null) dest.StatusReason = (CodeableConcept)StatusReason.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Effective != null) dest.Effective = (Element)Effective.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Assessor != null) dest.Assessor = (ResourceReference)Assessor.DeepCopy();
                if (Previous != null) dest.Previous = (ResourceReference)Previous.DeepCopy();
                if (Problem != null) dest.Problem = new List<ResourceReference>(Problem.DeepCopy());
                if (Investigation != null) dest.Investigation = new List<InvestigationComponent>(Investigation.DeepCopy());
                if (ProtocolElement != null) dest.ProtocolElement = new List<FhirUri>(ProtocolElement.DeepCopy());
                if (SummaryElement != null) dest.SummaryElement = (FhirString)SummaryElement.DeepCopy();
                if (Finding != null) dest.Finding = new List<FindingComponent>(Finding.DeepCopy());
                if (PrognosisCodeableConcept != null) dest.PrognosisCodeableConcept = new List<CodeableConcept>(PrognosisCodeableConcept.DeepCopy());
                if (PrognosisReference != null) dest.PrognosisReference = new List<ResourceReference>(PrognosisReference.DeepCopy());
                if (SupportingInfo != null) dest.SupportingInfo = new List<ResourceReference>(SupportingInfo.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ClinicalImpression());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ClinicalImpression;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Assessor, otherT.Assessor)) return false;
            if (!DeepComparable.Matches(Previous, otherT.Previous)) return false;
            if ( !DeepComparable.Matches(Problem, otherT.Problem)) return false;
            if ( !DeepComparable.Matches(Investigation, otherT.Investigation)) return false;
            if ( !DeepComparable.Matches(ProtocolElement, otherT.ProtocolElement)) return false;
            if (!DeepComparable.Matches(SummaryElement, otherT.SummaryElement)) return false;
            if ( !DeepComparable.Matches(Finding, otherT.Finding)) return false;
            if ( !DeepComparable.Matches(PrognosisCodeableConcept, otherT.PrognosisCodeableConcept)) return false;
            if ( !DeepComparable.Matches(PrognosisReference, otherT.PrognosisReference)) return false;
            if ( !DeepComparable.Matches(SupportingInfo, otherT.SupportingInfo)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ClinicalImpression;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Assessor, otherT.Assessor)) return false;
            if (!DeepComparable.IsExactly(Previous, otherT.Previous)) return false;
            if (!DeepComparable.IsExactly(Problem, otherT.Problem)) return false;
            if (!DeepComparable.IsExactly(Investigation, otherT.Investigation)) return false;
            if (!DeepComparable.IsExactly(ProtocolElement, otherT.ProtocolElement)) return false;
            if (!DeepComparable.IsExactly(SummaryElement, otherT.SummaryElement)) return false;
            if (!DeepComparable.IsExactly(Finding, otherT.Finding)) return false;
            if (!DeepComparable.IsExactly(PrognosisCodeableConcept, otherT.PrognosisCodeableConcept)) return false;
            if (!DeepComparable.IsExactly(PrognosisReference, otherT.PrognosisReference)) return false;
            if (!DeepComparable.IsExactly(SupportingInfo, otherT.SupportingInfo)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (StatusReason != null) yield return StatusReason;
                if (Code != null) yield return Code;
                if (DescriptionElement != null) yield return DescriptionElement;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Effective != null) yield return Effective;
                if (DateElement != null) yield return DateElement;
                if (Assessor != null) yield return Assessor;
                if (Previous != null) yield return Previous;
                foreach (var elem in Problem) { if (elem != null) yield return elem; }
                foreach (var elem in Investigation) { if (elem != null) yield return elem; }
                foreach (var elem in ProtocolElement) { if (elem != null) yield return elem; }
                if (SummaryElement != null) yield return SummaryElement;
                foreach (var elem in Finding) { if (elem != null) yield return elem; }
                foreach (var elem in PrognosisCodeableConcept) { if (elem != null) yield return elem; }
                foreach (var elem in PrognosisReference) { if (elem != null) yield return elem; }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (StatusReason != null) yield return new ElementValue("statusReason", StatusReason);
                if (Code != null) yield return new ElementValue("code", Code);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Effective != null) yield return new ElementValue("effective", Effective);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Assessor != null) yield return new ElementValue("assessor", Assessor);
                if (Previous != null) yield return new ElementValue("previous", Previous);
                foreach (var elem in Problem) { if (elem != null) yield return new ElementValue("problem", elem); }
                foreach (var elem in Investigation) { if (elem != null) yield return new ElementValue("investigation", elem); }
                foreach (var elem in ProtocolElement) { if (elem != null) yield return new ElementValue("protocol", elem); }
                if (SummaryElement != null) yield return new ElementValue("summary", SummaryElement);
                foreach (var elem in Finding) { if (elem != null) yield return new ElementValue("finding", elem); }
                foreach (var elem in PrognosisCodeableConcept) { if (elem != null) yield return new ElementValue("prognosisCodeableConcept", elem); }
                foreach (var elem in PrognosisReference) { if (elem != null) yield return new ElementValue("prognosisReference", elem); }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return new ElementValue("supportingInfo", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
