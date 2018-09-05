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
    /// A reference to a document
    /// </summary>
    [FhirType("DocumentReference", IsResource=true)]
    [DataContract]
    public partial class DocumentReference : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DocumentReference; } }
        [NotMapped]
        public override string TypeName { get { return "DocumentReference"; } }


        [FhirType("RelatesToComponent")]
        [DataContract]
        public partial class RelatesToComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelatesToComponent"; } }

            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<DocumentRelationshipType> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<DocumentRelationshipType> _codeElement;

            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DocumentRelationshipType? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<DocumentRelationshipType>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Target of the relationship
            /// </summary>
            [FhirElement("target", InSummary=true, Order=50)]
            [References("DocumentReference")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Target
            {
                get { return _target; }
                set { _target = value; OnPropertyChanged("Target"); }
            }

            private ResourceReference _target;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatesToComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code<DocumentRelationshipType>)CodeElement.DeepCopy();
                    if (Target != null) dest.Target = (ResourceReference)Target.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelatesToComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatesToComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(Target, otherT.Target)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatesToComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (Target != null) yield return Target;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (Target != null) yield return new ElementValue("target", Target);
                }
            }


        }


        [FhirType("ContentComponent")]
        [DataContract]
        public partial class ContentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContentComponent"; } }

            /// <summary>
            /// Where to access the document
            /// </summary>
            [FhirElement("attachment", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Attachment Attachment
            {
                get { return _attachment; }
                set { _attachment = value; OnPropertyChanged("Attachment"); }
            }

            private Attachment _attachment;

            /// <summary>
            /// Format/content rules for the document
            /// </summary>
            [FhirElement("format", InSummary=true, Order=50)]
            [DataMember]
            public Coding Format
            {
                get { return _format; }
                set { _format = value; OnPropertyChanged("Format"); }
            }

            private Coding _format;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Attachment != null) dest.Attachment = (Attachment)Attachment.DeepCopy();
                    if (Format != null) dest.Format = (Coding)Format.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Attachment, otherT.Attachment)) return false;
                if (!DeepComparable.Matches(Format, otherT.Format)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Attachment, otherT.Attachment)) return false;
                if (!DeepComparable.IsExactly(Format, otherT.Format)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Attachment != null) yield return Attachment;
                    if (Format != null) yield return Format;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Attachment != null) yield return new ElementValue("attachment", Attachment);
                    if (Format != null) yield return new ElementValue("format", Format);
                }
            }


        }


        [FhirType("ContextComponent")]
        [DataContract]
        public partial class ContextComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContextComponent"; } }

            /// <summary>
            /// Context of the document  content
            /// </summary>
            [FhirElement("encounter", InSummary=true, Order=40)]
            [References("Encounter")]
            [DataMember]
            public ResourceReference Encounter
            {
                get { return _encounter; }
                set { _encounter = value; OnPropertyChanged("Encounter"); }
            }

            private ResourceReference _encounter;

            /// <summary>
            /// Main clinical acts documented
            /// </summary>
            [FhirElement("event", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Event
            {
                get { if (_event==null) _event = new List<CodeableConcept>(); return _event; }
                set { _event = value; OnPropertyChanged("Event"); }
            }

            private List<CodeableConcept> _event;

            /// <summary>
            /// Time of service that is being documented
            /// </summary>
            [FhirElement("period", InSummary=true, Order=60)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            /// <summary>
            /// Kind of facility where patient was seen
            /// </summary>
            [FhirElement("facilityType", InSummary=true, Order=70)]
            [DataMember]
            public CodeableConcept FacilityType
            {
                get { return _facilityType; }
                set { _facilityType = value; OnPropertyChanged("FacilityType"); }
            }

            private CodeableConcept _facilityType;

            /// <summary>
            /// Additional details about where the content was created (e.g. clinical specialty)
            /// </summary>
            [FhirElement("practiceSetting", InSummary=true, Order=80)]
            [DataMember]
            public CodeableConcept PracticeSetting
            {
                get { return _practiceSetting; }
                set { _practiceSetting = value; OnPropertyChanged("PracticeSetting"); }
            }

            private CodeableConcept _practiceSetting;

            /// <summary>
            /// Patient demographics from source
            /// </summary>
            [FhirElement("sourcePatientInfo", InSummary=true, Order=90)]
            [References("Patient")]
            [DataMember]
            public ResourceReference SourcePatientInfo
            {
                get { return _sourcePatientInfo; }
                set { _sourcePatientInfo = value; OnPropertyChanged("SourcePatientInfo"); }
            }

            private ResourceReference _sourcePatientInfo;

            /// <summary>
            /// Related identifiers or resources
            /// </summary>
            [FhirElement("related", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RelatedComponent> Related
            {
                get { if (_related==null) _related = new List<RelatedComponent>(); return _related; }
                set { _related = value; OnPropertyChanged("Related"); }
            }

            private List<RelatedComponent> _related;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContextComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                    if (Event != null) dest.Event = new List<CodeableConcept>(Event.DeepCopy());
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (FacilityType != null) dest.FacilityType = (CodeableConcept)FacilityType.DeepCopy();
                    if (PracticeSetting != null) dest.PracticeSetting = (CodeableConcept)PracticeSetting.DeepCopy();
                    if (SourcePatientInfo != null) dest.SourcePatientInfo = (ResourceReference)SourcePatientInfo.DeepCopy();
                    if (Related != null) dest.Related = new List<RelatedComponent>(Related.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContextComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContextComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
                if ( !DeepComparable.Matches(Event, otherT.Event)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if (!DeepComparable.Matches(FacilityType, otherT.FacilityType)) return false;
                if (!DeepComparable.Matches(PracticeSetting, otherT.PracticeSetting)) return false;
                if (!DeepComparable.Matches(SourcePatientInfo, otherT.SourcePatientInfo)) return false;
                if ( !DeepComparable.Matches(Related, otherT.Related)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContextComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
                if (!DeepComparable.IsExactly(Event, otherT.Event)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(FacilityType, otherT.FacilityType)) return false;
                if (!DeepComparable.IsExactly(PracticeSetting, otherT.PracticeSetting)) return false;
                if (!DeepComparable.IsExactly(SourcePatientInfo, otherT.SourcePatientInfo)) return false;
                if (!DeepComparable.IsExactly(Related, otherT.Related)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Encounter != null) yield return Encounter;
                    foreach (var elem in Event) { if (elem != null) yield return elem; }
                    if (Period != null) yield return Period;
                    if (FacilityType != null) yield return FacilityType;
                    if (PracticeSetting != null) yield return PracticeSetting;
                    if (SourcePatientInfo != null) yield return SourcePatientInfo;
                    foreach (var elem in Related) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                    foreach (var elem in Event) { if (elem != null) yield return new ElementValue("event", elem); }
                    if (Period != null) yield return new ElementValue("period", Period);
                    if (FacilityType != null) yield return new ElementValue("facilityType", FacilityType);
                    if (PracticeSetting != null) yield return new ElementValue("practiceSetting", PracticeSetting);
                    if (SourcePatientInfo != null) yield return new ElementValue("sourcePatientInfo", SourcePatientInfo);
                    foreach (var elem in Related) { if (elem != null) yield return new ElementValue("related", elem); }
                }
            }


        }


        [FhirType("RelatedComponent")]
        [DataContract]
        public partial class RelatedComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedComponent"; } }

            /// <summary>
            /// Identifier of related objects or events
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Related Resource
            /// </summary>
            [FhirElement("ref", InSummary=true, Order=50)]
            [DataMember]
            public ResourceReference Ref
            {
                get { return _ref; }
                set { _ref = value; OnPropertyChanged("Ref"); }
            }

            private ResourceReference _ref;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatedComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (Ref != null) dest.Ref = (ResourceReference)Ref.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelatedComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatedComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(Ref, otherT.Ref)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Ref, otherT.Ref)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (Ref != null) yield return Ref;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (Ref != null) yield return new ElementValue("ref", Ref);
                }
            }


        }


        /// <summary>
        /// Master Version Specific Identifier
        /// </summary>
        [FhirElement("masterIdentifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier MasterIdentifier
        {
            get { return _masterIdentifier; }
            set { _masterIdentifier = value; OnPropertyChanged("MasterIdentifier"); }
        }

        private Identifier _masterIdentifier;

        /// <summary>
        /// Other identifiers for the document
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// current | superseded | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<DocumentReferenceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<DocumentReferenceStatus> _statusElement;

        /// <summary>
        /// current | superseded | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DocumentReferenceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<DocumentReferenceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// preliminary | final | appended | amended | entered-in-error
        /// </summary>
        [FhirElement("docStatus", InSummary=true, Order=120)]
        [DataMember]
        public Code<CompositionStatus> DocStatusElement
        {
            get { return _docStatusElement; }
            set { _docStatusElement = value; OnPropertyChanged("DocStatusElement"); }
        }

        private Code<CompositionStatus> _docStatusElement;

        /// <summary>
        /// preliminary | final | appended | amended | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CompositionStatus? DocStatus
        {
            get { return DocStatusElement != null ? DocStatusElement.Value : null; }
            set
            {
                if (value == null)
                    DocStatusElement = null;
                else
                    DocStatusElement = new Code<CompositionStatus>(value);
                OnPropertyChanged("DocStatus");
            }
        }

        /// <summary>
        /// Kind of document (LOINC if possible)
        /// </summary>
        [FhirElement("type", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Categorization of document
        /// </summary>
        [FhirElement("class", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept Class
        {
            get { return _class; }
            set { _class = value; OnPropertyChanged("Class"); }
        }

        private CodeableConcept _class;

        /// <summary>
        /// Who/what is the subject of the document
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=150)]
        [References("Patient","Practitioner","Group","Device")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Document creation time
        /// </summary>
        [FhirElement("created", InSummary=true, Order=160)]
        [DataMember]
        public FhirDateTime CreatedElement
        {
            get { return _createdElement; }
            set { _createdElement = value; OnPropertyChanged("CreatedElement"); }
        }

        private FhirDateTime _createdElement;

        /// <summary>
        /// Document creation time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if (value == null)
                    CreatedElement = null;
                else
                    CreatedElement = new FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }

        /// <summary>
        /// When this document reference was created
        /// </summary>
        [FhirElement("indexed", InSummary=true, Order=170)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Instant IndexedElement
        {
            get { return _indexedElement; }
            set { _indexedElement = value; OnPropertyChanged("IndexedElement"); }
        }

        private Instant _indexedElement;

        /// <summary>
        /// When this document reference was created
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? Indexed
        {
            get { return IndexedElement != null ? IndexedElement.Value : null; }
            set
            {
                if (value == null)
                    IndexedElement = null;
                else
                    IndexedElement = new Instant(value);
                OnPropertyChanged("Indexed");
            }
        }

        /// <summary>
        /// Who and/or what authored the document
        /// </summary>
        [FhirElement("author", InSummary=true, Order=180)]
        [References("Practitioner","Organization","Device","Patient","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Author
        {
            get { if (_author==null) _author = new List<ResourceReference>(); return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private List<ResourceReference> _author;

        /// <summary>
        /// Who/what authenticated the document
        /// </summary>
        [FhirElement("authenticator", InSummary=true, Order=190)]
        [References("Practitioner","Organization")]
        [DataMember]
        public ResourceReference Authenticator
        {
            get { return _authenticator; }
            set { _authenticator = value; OnPropertyChanged("Authenticator"); }
        }

        private ResourceReference _authenticator;

        /// <summary>
        /// Organization which maintains the document
        /// </summary>
        [FhirElement("custodian", InSummary=true, Order=200)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Custodian
        {
            get { return _custodian; }
            set { _custodian = value; OnPropertyChanged("Custodian"); }
        }

        private ResourceReference _custodian;

        /// <summary>
        /// Relationships to other documents
        /// </summary>
        [FhirElement("relatesTo", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatesToComponent> RelatesTo
        {
            get { if (_relatesTo==null) _relatesTo = new List<RelatesToComponent>(); return _relatesTo; }
            set { _relatesTo = value; OnPropertyChanged("RelatesTo"); }
        }

        private List<RelatesToComponent> _relatesTo;

        /// <summary>
        /// Human-readable description (title)
        /// </summary>
        [FhirElement("description", InSummary=true, Order=220)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Human-readable description (title)
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
        /// Document security-tags
        /// </summary>
        [FhirElement("securityLabel", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> SecurityLabel
        {
            get { if (_securityLabel==null) _securityLabel = new List<CodeableConcept>(); return _securityLabel; }
            set { _securityLabel = value; OnPropertyChanged("SecurityLabel"); }
        }

        private List<CodeableConcept> _securityLabel;

        /// <summary>
        /// Document referenced
        /// </summary>
        [FhirElement("content", InSummary=true, Order=240)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<ContentComponent> Content
        {
            get { if (_content==null) _content = new List<ContentComponent>(); return _content; }
            set { _content = value; OnPropertyChanged("Content"); }
        }

        private List<ContentComponent> _content;

        /// <summary>
        /// Clinical context of document
        /// </summary>
        [FhirElement("context", InSummary=true, Order=250)]
        [DataMember]
        public ContextComponent Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ContextComponent _context;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DocumentReference;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (MasterIdentifier != null) dest.MasterIdentifier = (Identifier)MasterIdentifier.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<DocumentReferenceStatus>)StatusElement.DeepCopy();
                if (DocStatusElement != null) dest.DocStatusElement = (Code<CompositionStatus>)DocStatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Class != null) dest.Class = (CodeableConcept)Class.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (IndexedElement != null) dest.IndexedElement = (Instant)IndexedElement.DeepCopy();
                if (Author != null) dest.Author = new List<ResourceReference>(Author.DeepCopy());
                if (Authenticator != null) dest.Authenticator = (ResourceReference)Authenticator.DeepCopy();
                if (Custodian != null) dest.Custodian = (ResourceReference)Custodian.DeepCopy();
                if (RelatesTo != null) dest.RelatesTo = new List<RelatesToComponent>(RelatesTo.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (SecurityLabel != null) dest.SecurityLabel = new List<CodeableConcept>(SecurityLabel.DeepCopy());
                if (Content != null) dest.Content = new List<ContentComponent>(Content.DeepCopy());
                if (Context != null) dest.Context = (ContextComponent)Context.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new DocumentReference());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DocumentReference;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(MasterIdentifier, otherT.MasterIdentifier)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(DocStatusElement, otherT.DocStatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Class, otherT.Class)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(IndexedElement, otherT.IndexedElement)) return false;
            if ( !DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(Authenticator, otherT.Authenticator)) return false;
            if (!DeepComparable.Matches(Custodian, otherT.Custodian)) return false;
            if ( !DeepComparable.Matches(RelatesTo, otherT.RelatesTo)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
            if ( !DeepComparable.Matches(Content, otherT.Content)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DocumentReference;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(MasterIdentifier, otherT.MasterIdentifier)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(DocStatusElement, otherT.DocStatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Class, otherT.Class)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(IndexedElement, otherT.IndexedElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Authenticator, otherT.Authenticator)) return false;
            if (!DeepComparable.IsExactly(Custodian, otherT.Custodian)) return false;
            if (!DeepComparable.IsExactly(RelatesTo, otherT.RelatesTo)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
            if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (MasterIdentifier != null) yield return MasterIdentifier;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (DocStatusElement != null) yield return DocStatusElement;
                if (Type != null) yield return Type;
                if (Class != null) yield return Class;
                if (Subject != null) yield return Subject;
                if (CreatedElement != null) yield return CreatedElement;
                if (IndexedElement != null) yield return IndexedElement;
                foreach (var elem in Author) { if (elem != null) yield return elem; }
                if (Authenticator != null) yield return Authenticator;
                if (Custodian != null) yield return Custodian;
                foreach (var elem in RelatesTo) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
                foreach (var elem in Content) { if (elem != null) yield return elem; }
                if (Context != null) yield return Context;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (MasterIdentifier != null) yield return new ElementValue("masterIdentifier", MasterIdentifier);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (DocStatusElement != null) yield return new ElementValue("docStatus", DocStatusElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (Class != null) yield return new ElementValue("class", Class);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (IndexedElement != null) yield return new ElementValue("indexed", IndexedElement);
                foreach (var elem in Author) { if (elem != null) yield return new ElementValue("author", elem); }
                if (Authenticator != null) yield return new ElementValue("authenticator", Authenticator);
                if (Custodian != null) yield return new ElementValue("custodian", Custodian);
                foreach (var elem in RelatesTo) { if (elem != null) yield return new ElementValue("relatesTo", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", elem); }
                foreach (var elem in Content) { if (elem != null) yield return new ElementValue("content", elem); }
                if (Context != null) yield return new ElementValue("context", Context);
            }
        }

    }

}
