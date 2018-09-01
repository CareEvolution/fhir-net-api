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
    /// Investigation to increase healthcare-related patient-independent knowledge
    /// </summary>
    [FhirType("ResearchStudy", IsResource=true)]
    [DataContract]
    public partial class ResearchStudy : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ResearchStudy; } }
        [NotMapped]
        public override string TypeName { get { return "ResearchStudy"; } }

        /// <summary>
        /// Codes that convey the current status of the research study
        /// (url: http://hl7.org/fhir/ValueSet/research-study-status)
        /// </summary>
        [FhirEnumeration("ResearchStudyStatus")]
        public enum ResearchStudyStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-study-status)
            /// </summary>
            [EnumLiteral("draft", "http://hl7.org/fhir/research-study-status"), Description("Draft")]
            Draft,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-study-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/research-study-status"), Description("In-progress")]
            InProgress,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-study-status)
            /// </summary>
            [EnumLiteral("suspended", "http://hl7.org/fhir/research-study-status"), Description("Suspended")]
            Suspended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-study-status)
            /// </summary>
            [EnumLiteral("stopped", "http://hl7.org/fhir/research-study-status"), Description("Stopped")]
            Stopped,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-study-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/research-study-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/research-study-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/research-study-status"), Description("Entered in error")]
            EnteredInError,
        }


        [FhirType("ArmComponent")]
        [DataContract]
        public partial class ArmComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ArmComponent"; } }

            /// <summary>
            /// Label for study arm
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Label for study arm
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
            /// Categorization of study arm
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Short explanation of study path
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
            /// Short explanation of study path
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ArmComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ArmComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ArmComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ArmComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (Code != null) yield return Code;
                    if (DescriptionElement != null) yield return DescriptionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                }
            }


        }


        /// <summary>
        /// Business Identifier for study
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
        /// Name for this study
        /// </summary>
        [FhirElement("title", InSummary=true, Order=100)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Name for this study
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                    TitleElement = null;
                else
                    TitleElement = new FhirString(value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Steps followed in executing study
        /// </summary>
        [FhirElement("protocol", InSummary=true, Order=110)]
        [References("PlanDefinition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Protocol
        {
            get { if (_protocol==null) _protocol = new List<ResourceReference>(); return _protocol; }
            set { _protocol = value; OnPropertyChanged("Protocol"); }
        }

        private List<ResourceReference> _protocol;

        /// <summary>
        /// Part of larger study
        /// </summary>
        [FhirElement("partOf", InSummary=true, Order=120)]
        [References("ResearchStudy")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// draft | in-progress | suspended | stopped | completed | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ResearchStudyStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ResearchStudyStatus> _statusElement;

        /// <summary>
        /// draft | in-progress | suspended | stopped | completed | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ResearchStudyStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ResearchStudyStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Classifications for the study
        /// </summary>
        [FhirElement("category", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// Drugs, devices, conditions, etc. under study
        /// </summary>
        [FhirElement("focus", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Focus
        {
            get { if (_focus==null) _focus = new List<CodeableConcept>(); return _focus; }
            set { _focus = value; OnPropertyChanged("Focus"); }
        }

        private List<CodeableConcept> _focus;

        /// <summary>
        /// Contact details for the study
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// References and dependencies
        /// </summary>
        [FhirElement("relatedArtifact", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedArtifact> RelatedArtifact
        {
            get { if (_relatedArtifact==null) _relatedArtifact = new List<RelatedArtifact>(); return _relatedArtifact; }
            set { _relatedArtifact = value; OnPropertyChanged("RelatedArtifact"); }
        }

        private List<RelatedArtifact> _relatedArtifact;

        /// <summary>
        /// Used to search for the study
        /// </summary>
        [FhirElement("keyword", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Keyword
        {
            get { if (_keyword==null) _keyword = new List<CodeableConcept>(); return _keyword; }
            set { _keyword = value; OnPropertyChanged("Keyword"); }
        }

        private List<CodeableConcept> _keyword;

        /// <summary>
        /// Geographic region(s) for study
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// What this is study doing
        /// </summary>
        [FhirElement("description", Order=200)]
        [DataMember]
        public Markdown DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private Markdown _descriptionElement;

        /// <summary>
        /// What this is study doing
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
                    DescriptionElement = new Markdown(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Inclusion &amp; exclusion criteria
        /// </summary>
        [FhirElement("enrollment", InSummary=true, Order=210)]
        [References("Group")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Enrollment
        {
            get { if (_enrollment==null) _enrollment = new List<ResourceReference>(); return _enrollment; }
            set { _enrollment = value; OnPropertyChanged("Enrollment"); }
        }

        private List<ResourceReference> _enrollment;

        /// <summary>
        /// When the study began and ended
        /// </summary>
        [FhirElement("period", InSummary=true, Order=220)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Organization responsible for the study
        /// </summary>
        [FhirElement("sponsor", InSummary=true, Order=230)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Sponsor
        {
            get { return _sponsor; }
            set { _sponsor = value; OnPropertyChanged("Sponsor"); }
        }

        private ResourceReference _sponsor;

        /// <summary>
        /// The individual responsible for the study
        /// </summary>
        [FhirElement("principalInvestigator", InSummary=true, Order=240)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference PrincipalInvestigator
        {
            get { return _principalInvestigator; }
            set { _principalInvestigator = value; OnPropertyChanged("PrincipalInvestigator"); }
        }

        private ResourceReference _principalInvestigator;

        /// <summary>
        /// Location involved in study execution
        /// </summary>
        [FhirElement("site", InSummary=true, Order=250)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Site
        {
            get { if (_site==null) _site = new List<ResourceReference>(); return _site; }
            set { _site = value; OnPropertyChanged("Site"); }
        }

        private List<ResourceReference> _site;

        /// <summary>
        /// Reason for terminating study early
        /// </summary>
        [FhirElement("reasonStopped", InSummary=true, Order=260)]
        [DataMember]
        public CodeableConcept ReasonStopped
        {
            get { return _reasonStopped; }
            set { _reasonStopped = value; OnPropertyChanged("ReasonStopped"); }
        }

        private CodeableConcept _reasonStopped;

        /// <summary>
        /// Comments made about the event
        /// </summary>
        [FhirElement("note", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Defined path through the study for a subject
        /// </summary>
        [FhirElement("arm", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ArmComponent> Arm
        {
            get { if (_arm==null) _arm = new List<ArmComponent>(); return _arm; }
            set { _arm = value; OnPropertyChanged("Arm"); }
        }

        private List<ArmComponent> _arm;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ResearchStudy;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (Protocol != null) dest.Protocol = new List<ResourceReference>(Protocol.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<ResearchStudyStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (Focus != null) dest.Focus = new List<CodeableConcept>(Focus.DeepCopy());
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (RelatedArtifact != null) dest.RelatedArtifact = new List<RelatedArtifact>(RelatedArtifact.DeepCopy());
                if (Keyword != null) dest.Keyword = new List<CodeableConcept>(Keyword.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                if (Enrollment != null) dest.Enrollment = new List<ResourceReference>(Enrollment.DeepCopy());
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Sponsor != null) dest.Sponsor = (ResourceReference)Sponsor.DeepCopy();
                if (PrincipalInvestigator != null) dest.PrincipalInvestigator = (ResourceReference)PrincipalInvestigator.DeepCopy();
                if (Site != null) dest.Site = new List<ResourceReference>(Site.DeepCopy());
                if (ReasonStopped != null) dest.ReasonStopped = (CodeableConcept)ReasonStopped.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Arm != null) dest.Arm = new List<ArmComponent>(Arm.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ResearchStudy());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ResearchStudy;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if ( !DeepComparable.Matches(Protocol, otherT.Protocol)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if ( !DeepComparable.Matches(Focus, otherT.Focus)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if ( !DeepComparable.Matches(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if ( !DeepComparable.Matches(Keyword, otherT.Keyword)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(Enrollment, otherT.Enrollment)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(Sponsor, otherT.Sponsor)) return false;
            if (!DeepComparable.Matches(PrincipalInvestigator, otherT.PrincipalInvestigator)) return false;
            if ( !DeepComparable.Matches(Site, otherT.Site)) return false;
            if (!DeepComparable.Matches(ReasonStopped, otherT.ReasonStopped)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Arm, otherT.Arm)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ResearchStudy;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(Protocol, otherT.Protocol)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Focus, otherT.Focus)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if (!DeepComparable.IsExactly(Keyword, otherT.Keyword)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Enrollment, otherT.Enrollment)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Sponsor, otherT.Sponsor)) return false;
            if (!DeepComparable.IsExactly(PrincipalInvestigator, otherT.PrincipalInvestigator)) return false;
            if (!DeepComparable.IsExactly(Site, otherT.Site)) return false;
            if (!DeepComparable.IsExactly(ReasonStopped, otherT.ReasonStopped)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Arm, otherT.Arm)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (TitleElement != null) yield return TitleElement;
                foreach (var elem in Protocol) { if (elem != null) yield return elem; }
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                foreach (var elem in Focus) { if (elem != null) yield return elem; }
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return elem; }
                foreach (var elem in Keyword) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in Enrollment) { if (elem != null) yield return elem; }
                if (Period != null) yield return Period;
                if (Sponsor != null) yield return Sponsor;
                if (PrincipalInvestigator != null) yield return PrincipalInvestigator;
                foreach (var elem in Site) { if (elem != null) yield return elem; }
                if (ReasonStopped != null) yield return ReasonStopped;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Arm) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                foreach (var elem in Protocol) { if (elem != null) yield return new ElementValue("protocol", elem); }
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                foreach (var elem in Focus) { if (elem != null) yield return new ElementValue("focus", elem); }
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return new ElementValue("relatedArtifact", elem); }
                foreach (var elem in Keyword) { if (elem != null) yield return new ElementValue("keyword", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in Enrollment) { if (elem != null) yield return new ElementValue("enrollment", elem); }
                if (Period != null) yield return new ElementValue("period", Period);
                if (Sponsor != null) yield return new ElementValue("sponsor", Sponsor);
                if (PrincipalInvestigator != null) yield return new ElementValue("principalInvestigator", PrincipalInvestigator);
                foreach (var elem in Site) { if (elem != null) yield return new ElementValue("site", elem); }
                if (ReasonStopped != null) yield return new ElementValue("reasonStopped", ReasonStopped);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Arm) { if (elem != null) yield return new ElementValue("arm", elem); }
            }
        }

    }

}
