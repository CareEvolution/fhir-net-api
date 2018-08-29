using System;
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
    /// The definition of a specific activity to be taken, independent of any particular patient or context
    /// </summary>
    [FhirType("ActivityDefinition", IsResource=true)]
    [DataContract]
    public partial class ActivityDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ActivityDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "ActivityDefinition"; } }


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// patient | practitioner | related-person
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ActionParticipantType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<ActionParticipantType> _typeElement;

            /// <summary>
            /// patient | practitioner | related-person
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ActionParticipantType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<ActionParticipantType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// E.g. Nurse, Surgeon, Parent, etc.
            /// </summary>
            [FhirElement("role", Order=50)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ActionParticipantType>)TypeElement.DeepCopy();
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParticipantComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Role != null) yield return Role;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (Role != null) yield return new ElementValue("role", false, Role);
                }
            }


        }


        [FhirType("DynamicValueComponent")]
        [DataContract]
        public partial class DynamicValueComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DynamicValueComponent"; } }

            /// <summary>
            /// Natural language description of the dynamic value
            /// </summary>
            [FhirElement("description", Order=40)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Natural language description of the dynamic value
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
            /// The path to the element to be set dynamically
            /// </summary>
            [FhirElement("path", Order=50)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// The path to the element to be set dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            /// <summary>
            /// Language of the expression
            /// </summary>
            [FhirElement("language", Order=60)]
            [DataMember]
            public FhirString LanguageElement
            {
                get { return _languageElement; }
                set { _languageElement = value; OnPropertyChanged("LanguageElement"); }
            }

            private FhirString _languageElement;

            /// <summary>
            /// Language of the expression
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Language
            {
                get { return LanguageElement != null ? LanguageElement.Value : null; }
                set
                {
                    if (value == null)
                        LanguageElement = null;
                    else
                        LanguageElement = new FhirString(value);
                    OnPropertyChanged("Language");
                }
            }

            /// <summary>
            /// An expression that provides the dynamic value for the customization
            /// </summary>
            [FhirElement("expression", Order=70)]
            [DataMember]
            public FhirString ExpressionElement
            {
                get { return _expressionElement; }
                set { _expressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }

            private FhirString _expressionElement;

            /// <summary>
            /// An expression that provides the dynamic value for the customization
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Expression
            {
                get { return ExpressionElement != null ? ExpressionElement.Value : null; }
                set
                {
                    if (value == null)
                        ExpressionElement = null;
                    else
                        ExpressionElement = new FhirString(value);
                    OnPropertyChanged("Expression");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DynamicValueComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (LanguageElement != null) dest.LanguageElement = (FhirString)LanguageElement.DeepCopy();
                    if (ExpressionElement != null) dest.ExpressionElement = (FhirString)ExpressionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DynamicValueComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DynamicValueComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DynamicValueComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (PathElement != null) yield return PathElement;
                    if (LanguageElement != null) yield return LanguageElement;
                    if (ExpressionElement != null) yield return ExpressionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (PathElement != null) yield return new ElementValue("path", false, PathElement);
                    if (LanguageElement != null) yield return new ElementValue("language", false, LanguageElement);
                    if (ExpressionElement != null) yield return new ElementValue("expression", false, ExpressionElement);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this activity definition, represented as a URI (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Canonical identifier for this activity definition, represented as a URI (globally unique)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                    UrlElement = null;
                else
                    UrlElement = new FhirUri(value);
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        /// Additional identifier for the activity definition
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
        /// Business version of the activity definition
        /// </summary>
        [FhirElement("version", InSummary=true, Order=110)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Business version of the activity definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new FhirString(value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Name for this activity definition (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name for this activity definition (computer friendly)
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
        /// Name for this activity definition (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=true, Order=130)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Name for this activity definition (human friendly)
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
        /// Subordinate title of the activity definition
        /// </summary>
        [FhirElement("subtitle", Order=140)]
        [DataMember]
        public FhirString SubtitleElement
        {
            get { return _subtitleElement; }
            set { _subtitleElement = value; OnPropertyChanged("SubtitleElement"); }
        }

        private FhirString _subtitleElement;

        /// <summary>
        /// Subordinate title of the activity definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Subtitle
        {
            get { return SubtitleElement != null ? SubtitleElement.Value : null; }
            set
            {
                if (value == null)
                    SubtitleElement = null;
                else
                    SubtitleElement = new FhirString(value);
                OnPropertyChanged("Subtitle");
            }
        }

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<PublicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<PublicationStatus> _statusElement;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=160)]
        [DataMember]
        public FhirBoolean ExperimentalElement
        {
            get { return _experimentalElement; }
            set { _experimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }

        private FhirBoolean _experimentalElement;

        /// <summary>
        /// For testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (value == null)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }

        /// <summary>
        /// Type of individual the activity definition is intended for
        /// </summary>
        [FhirElement("subject", Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private Element _subject;

        /// <summary>
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=180)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date last changed
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
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=190)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                    PublisherElement = null;
                else
                    PublisherElement = new FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }

        /// <summary>
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Natural language description of the activity definition
        /// </summary>
        [FhirElement("description", InSummary=true, Order=210)]
        [DataMember]
        public Markdown Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }

        private Markdown _description;

        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for activity definition (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Why this activity definition is defined
        /// </summary>
        [FhirElement("purpose", Order=240)]
        [DataMember]
        public Markdown Purpose
        {
            get { return _purpose; }
            set { _purpose = value; OnPropertyChanged("Purpose"); }
        }

        private Markdown _purpose;

        /// <summary>
        /// Describes the clinical usage of the activity definition
        /// </summary>
        [FhirElement("usage", Order=250)]
        [DataMember]
        public FhirString UsageElement
        {
            get { return _usageElement; }
            set { _usageElement = value; OnPropertyChanged("UsageElement"); }
        }

        private FhirString _usageElement;

        /// <summary>
        /// Describes the clinical usage of the activity definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Usage
        {
            get { return UsageElement != null ? UsageElement.Value : null; }
            set
            {
                if (value == null)
                    UsageElement = null;
                else
                    UsageElement = new FhirString(value);
                OnPropertyChanged("Usage");
            }
        }

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=260)]
        [DataMember]
        public Markdown Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        private Markdown _copyright;

        /// <summary>
        /// When the activity definition was approved by publisher
        /// </summary>
        [FhirElement("approvalDate", Order=270)]
        [DataMember]
        public Date ApprovalDateElement
        {
            get { return _approvalDateElement; }
            set { _approvalDateElement = value; OnPropertyChanged("ApprovalDateElement"); }
        }

        private Date _approvalDateElement;

        /// <summary>
        /// When the activity definition was approved by publisher
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ApprovalDate
        {
            get { return ApprovalDateElement != null ? ApprovalDateElement.Value : null; }
            set
            {
                if (value == null)
                    ApprovalDateElement = null;
                else
                    ApprovalDateElement = new Date(value);
                OnPropertyChanged("ApprovalDate");
            }
        }

        /// <summary>
        /// When the activity definition was last reviewed
        /// </summary>
        [FhirElement("lastReviewDate", Order=280)]
        [DataMember]
        public Date LastReviewDateElement
        {
            get { return _lastReviewDateElement; }
            set { _lastReviewDateElement = value; OnPropertyChanged("LastReviewDateElement"); }
        }

        private Date _lastReviewDateElement;

        /// <summary>
        /// When the activity definition was last reviewed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string LastReviewDate
        {
            get { return LastReviewDateElement != null ? LastReviewDateElement.Value : null; }
            set
            {
                if (value == null)
                    LastReviewDateElement = null;
                else
                    LastReviewDateElement = new Date(value);
                OnPropertyChanged("LastReviewDate");
            }
        }

        /// <summary>
        /// When the activity definition is expected to be used
        /// </summary>
        [FhirElement("effectivePeriod", InSummary=true, Order=290)]
        [DataMember]
        public Period EffectivePeriod
        {
            get { return _effectivePeriod; }
            set { _effectivePeriod = value; OnPropertyChanged("EffectivePeriod"); }
        }

        private Period _effectivePeriod;

        /// <summary>
        /// E.g. Education, Treatment, Assessment, etc.
        /// </summary>
        [FhirElement("topic", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Topic
        {
            get { if (_topic==null) _topic = new List<CodeableConcept>(); return _topic; }
            set { _topic = value; OnPropertyChanged("Topic"); }
        }

        private List<CodeableConcept> _topic;

        /// <summary>
        /// A content contributor
        /// </summary>
        [FhirElement("contributor", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Contributor> Contributor
        {
            get { if (_contributor==null) _contributor = new List<Contributor>(); return _contributor; }
            set { _contributor = value; OnPropertyChanged("Contributor"); }
        }

        private List<Contributor> _contributor;

        /// <summary>
        /// Additional documentation, citations, etc.
        /// </summary>
        [FhirElement("relatedArtifact", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedArtifact> RelatedArtifact
        {
            get { if (_relatedArtifact==null) _relatedArtifact = new List<RelatedArtifact>(); return _relatedArtifact; }
            set { _relatedArtifact = value; OnPropertyChanged("RelatedArtifact"); }
        }

        private List<RelatedArtifact> _relatedArtifact;

        /// <summary>
        /// Logic used by the activity definition
        /// </summary>
        [FhirElement("library", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> LibraryElement
        {
            get { if (_libraryElement==null) _libraryElement = new List<Canonical>(); return _libraryElement; }
            set { _libraryElement = value; OnPropertyChanged("LibraryElement"); }
        }

        private List<Canonical> _libraryElement;

        /// <summary>
        /// Logic used by the activity definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Library
        {
            get { return LibraryElement != null ? LibraryElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    LibraryElement = null;
                else
                    LibraryElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("Library");
            }
        }

        /// <summary>
        /// Kind of resource
        /// </summary>
        [FhirElement("kind", InSummary=true, Order=340)]
        [DataMember]
        public Code<ResourceType> KindElement
        {
            get { return _kindElement; }
            set { _kindElement = value; OnPropertyChanged("KindElement"); }
        }

        private Code<ResourceType> _kindElement;

        /// <summary>
        /// Kind of resource
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ResourceType? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (value == null)
                    KindElement = null;
                else
                    KindElement = new Code<ResourceType>(value);
                OnPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// Detail type of activity
        /// </summary>
        [FhirElement("code", InSummary=true, Order=350)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// True if the activity should not be performed
        /// </summary>
        [FhirElement("doNotPerform", InSummary=true, Order=360)]
        [DataMember]
        public FhirBoolean DoNotPerformElement
        {
            get { return _doNotPerformElement; }
            set { _doNotPerformElement = value; OnPropertyChanged("DoNotPerformElement"); }
        }

        private FhirBoolean _doNotPerformElement;

        /// <summary>
        /// True if the activity should not be performed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? DoNotPerform
        {
            get { return DoNotPerformElement != null ? DoNotPerformElement.Value : null; }
            set
            {
                if (value == null)
                    DoNotPerformElement = null;
                else
                    DoNotPerformElement = new FhirBoolean(value);
                OnPropertyChanged("DoNotPerform");
            }
        }

        /// <summary>
        /// When activity is to occur
        /// </summary>
        [FhirElement("timing", Order=370, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Timing),typeof(FhirDateTime),typeof(Age),typeof(Period),typeof(Range),typeof(Duration))]
        [DataMember]
        public Element Timing
        {
            get { return _timing; }
            set { _timing = value; OnPropertyChanged("Timing"); }
        }

        private Element _timing;

        /// <summary>
        /// Where it should happen
        /// </summary>
        [FhirElement("location", Order=380)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Who should participate in the action
        /// </summary>
        [FhirElement("participant", Order=390)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if (_participant==null) _participant = new List<ParticipantComponent>(); return _participant; }
            set { _participant = value; OnPropertyChanged("Participant"); }
        }

        private List<ParticipantComponent> _participant;

        /// <summary>
        /// What's administered/supplied
        /// </summary>
        [FhirElement("product", Order=400, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(ResourceReference),typeof(CodeableConcept))]
        [DataMember]
        public Element Product
        {
            get { return _product; }
            set { _product = value; OnPropertyChanged("Product"); }
        }

        private Element _product;

        /// <summary>
        /// How much is administered/consumed/supplied
        /// </summary>
        [FhirElement("quantity", Order=410)]
        [DataMember]
        public SimpleQuantity Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged("Quantity"); }
        }

        private SimpleQuantity _quantity;

        /// <summary>
        /// Detailed dosage instructions
        /// </summary>
        [FhirElement("dosage", Order=420)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Dosage> Dosage
        {
            get { if (_dosage==null) _dosage = new List<Dosage>(); return _dosage; }
            set { _dosage = value; OnPropertyChanged("Dosage"); }
        }

        private List<Dosage> _dosage;

        /// <summary>
        /// What part of body to perform on
        /// </summary>
        [FhirElement("bodySite", Order=430)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> BodySite
        {
            get { if (_bodySite==null) _bodySite = new List<CodeableConcept>(); return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private List<CodeableConcept> _bodySite;

        /// <summary>
        /// What specimens are required to perform this action
        /// </summary>
        [FhirElement("specimenRequirement", Order=440)]
        [References("SpecimenDefinition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SpecimenRequirement
        {
            get { if (_specimenRequirement==null) _specimenRequirement = new List<ResourceReference>(); return _specimenRequirement; }
            set { _specimenRequirement = value; OnPropertyChanged("SpecimenRequirement"); }
        }

        private List<ResourceReference> _specimenRequirement;

        /// <summary>
        /// Transform to apply the template
        /// </summary>
        [FhirElement("transform", Order=450)]
        [DataMember]
        public Canonical TransformElement
        {
            get { return _transformElement; }
            set { _transformElement = value; OnPropertyChanged("TransformElement"); }
        }

        private Canonical _transformElement;

        /// <summary>
        /// Transform to apply the template
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Transform
        {
            get { return TransformElement != null ? TransformElement.Value : null; }
            set
            {
                if (value == null)
                    TransformElement = null;
                else
                    TransformElement = new Canonical(value);
                OnPropertyChanged("Transform");
            }
        }

        /// <summary>
        /// Dynamic aspects of the definition
        /// </summary>
        [FhirElement("dynamicValue", Order=460)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DynamicValueComponent> DynamicValue
        {
            get { if (_dynamicValue==null) _dynamicValue = new List<DynamicValueComponent>(); return _dynamicValue; }
            set { _dynamicValue = value; OnPropertyChanged("DynamicValue"); }
        }

        private List<DynamicValueComponent> _dynamicValue;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ActivityDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (SubtitleElement != null) dest.SubtitleElement = (FhirString)SubtitleElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (Subject != null) dest.Subject = (Element)Subject.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (Description != null) dest.Description = (Markdown)Description.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (Purpose != null) dest.Purpose = (Markdown)Purpose.DeepCopy();
                if (UsageElement != null) dest.UsageElement = (FhirString)UsageElement.DeepCopy();
                if (Copyright != null) dest.Copyright = (Markdown)Copyright.DeepCopy();
                if (ApprovalDateElement != null) dest.ApprovalDateElement = (Date)ApprovalDateElement.DeepCopy();
                if (LastReviewDateElement != null) dest.LastReviewDateElement = (Date)LastReviewDateElement.DeepCopy();
                if (EffectivePeriod != null) dest.EffectivePeriod = (Period)EffectivePeriod.DeepCopy();
                if (Topic != null) dest.Topic = new List<CodeableConcept>(Topic.DeepCopy());
                if (Contributor != null) dest.Contributor = new List<Contributor>(Contributor.DeepCopy());
                if (RelatedArtifact != null) dest.RelatedArtifact = new List<RelatedArtifact>(RelatedArtifact.DeepCopy());
                if (LibraryElement != null) dest.LibraryElement = new List<Canonical>(LibraryElement.DeepCopy());
                if (KindElement != null) dest.KindElement = (Code<ResourceType>)KindElement.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (DoNotPerformElement != null) dest.DoNotPerformElement = (FhirBoolean)DoNotPerformElement.DeepCopy();
                if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                if (Product != null) dest.Product = (Element)Product.DeepCopy();
                if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                if (Dosage != null) dest.Dosage = new List<Dosage>(Dosage.DeepCopy());
                if (BodySite != null) dest.BodySite = new List<CodeableConcept>(BodySite.DeepCopy());
                if (SpecimenRequirement != null) dest.SpecimenRequirement = new List<ResourceReference>(SpecimenRequirement.DeepCopy());
                if (TransformElement != null) dest.TransformElement = (Canonical)TransformElement.DeepCopy();
                if (DynamicValue != null) dest.DynamicValue = new List<DynamicValueComponent>(DynamicValue.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ActivityDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ActivityDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(SubtitleElement, otherT.SubtitleElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Description, otherT.Description)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.Matches(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.Matches(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.Matches(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.Matches(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.Matches(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if ( !DeepComparable.Matches(Topic, otherT.Topic)) return false;
            if ( !DeepComparable.Matches(Contributor, otherT.Contributor)) return false;
            if ( !DeepComparable.Matches(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if ( !DeepComparable.Matches(LibraryElement, otherT.LibraryElement)) return false;
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if ( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if (!DeepComparable.Matches(Product, otherT.Product)) return false;
            if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if ( !DeepComparable.Matches(Dosage, otherT.Dosage)) return false;
            if ( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if ( !DeepComparable.Matches(SpecimenRequirement, otherT.SpecimenRequirement)) return false;
            if (!DeepComparable.Matches(TransformElement, otherT.TransformElement)) return false;
            if ( !DeepComparable.Matches(DynamicValue, otherT.DynamicValue)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ActivityDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(SubtitleElement, otherT.SubtitleElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.IsExactly(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.IsExactly(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.IsExactly(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.IsExactly(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if (!DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
            if (!DeepComparable.IsExactly(Contributor, otherT.Contributor)) return false;
            if (!DeepComparable.IsExactly(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if (!DeepComparable.IsExactly(LibraryElement, otherT.LibraryElement)) return false;
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if (!DeepComparable.IsExactly(Product, otherT.Product)) return false;
            if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(SpecimenRequirement, otherT.SpecimenRequirement)) return false;
            if (!DeepComparable.IsExactly(TransformElement, otherT.TransformElement)) return false;
            if (!DeepComparable.IsExactly(DynamicValue, otherT.DynamicValue)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (TitleElement != null) yield return TitleElement;
                if (SubtitleElement != null) yield return SubtitleElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (Subject != null) yield return Subject;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Description != null) yield return Description;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (Purpose != null) yield return Purpose;
                if (UsageElement != null) yield return UsageElement;
                if (Copyright != null) yield return Copyright;
                if (ApprovalDateElement != null) yield return ApprovalDateElement;
                if (LastReviewDateElement != null) yield return LastReviewDateElement;
                if (EffectivePeriod != null) yield return EffectivePeriod;
                foreach (var elem in Topic) { if (elem != null) yield return elem; }
                foreach (var elem in Contributor) { if (elem != null) yield return elem; }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return elem; }
                foreach (var elem in LibraryElement) { if (elem != null) yield return elem; }
                if (KindElement != null) yield return KindElement;
                if (Code != null) yield return Code;
                if (DoNotPerformElement != null) yield return DoNotPerformElement;
                if (Timing != null) yield return Timing;
                if (Location != null) yield return Location;
                foreach (var elem in Participant) { if (elem != null) yield return elem; }
                if (Product != null) yield return Product;
                if (Quantity != null) yield return Quantity;
                foreach (var elem in Dosage) { if (elem != null) yield return elem; }
                foreach (var elem in BodySite) { if (elem != null) yield return elem; }
                foreach (var elem in SpecimenRequirement) { if (elem != null) yield return elem; }
                if (TransformElement != null) yield return TransformElement;
                foreach (var elem in DynamicValue) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", false, UrlElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (VersionElement != null) yield return new ElementValue("version", false, VersionElement);
                if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                if (TitleElement != null) yield return new ElementValue("title", false, TitleElement);
                if (SubtitleElement != null) yield return new ElementValue("subtitle", false, SubtitleElement);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", false, ExperimentalElement);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", false, PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", true, elem); }
                if (Description != null) yield return new ElementValue("description", false, Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", true, elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", true, elem); }
                if (Purpose != null) yield return new ElementValue("purpose", false, Purpose);
                if (UsageElement != null) yield return new ElementValue("usage", false, UsageElement);
                if (Copyright != null) yield return new ElementValue("copyright", false, Copyright);
                if (ApprovalDateElement != null) yield return new ElementValue("approvalDate", false, ApprovalDateElement);
                if (LastReviewDateElement != null) yield return new ElementValue("lastReviewDate", false, LastReviewDateElement);
                if (EffectivePeriod != null) yield return new ElementValue("effectivePeriod", false, EffectivePeriod);
                foreach (var elem in Topic) { if (elem != null) yield return new ElementValue("topic", true, elem); }
                foreach (var elem in Contributor) { if (elem != null) yield return new ElementValue("contributor", true, elem); }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return new ElementValue("relatedArtifact", true, elem); }
                foreach (var elem in LibraryElement) { if (elem != null) yield return new ElementValue("library", true, elem); }
                if (KindElement != null) yield return new ElementValue("kind", false, KindElement);
                if (Code != null) yield return new ElementValue("code", false, Code);
                if (DoNotPerformElement != null) yield return new ElementValue("doNotPerform", false, DoNotPerformElement);
                if (Timing != null) yield return new ElementValue("timing", false, Timing);
                if (Location != null) yield return new ElementValue("location", false, Location);
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", true, elem); }
                if (Product != null) yield return new ElementValue("product", false, Product);
                if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", true, elem); }
                foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", true, elem); }
                foreach (var elem in SpecimenRequirement) { if (elem != null) yield return new ElementValue("specimenRequirement", true, elem); }
                if (TransformElement != null) yield return new ElementValue("transform", false, TransformElement);
                foreach (var elem in DynamicValue) { if (elem != null) yield return new ElementValue("dynamicValue", true, elem); }
            }
        }

    }

}
