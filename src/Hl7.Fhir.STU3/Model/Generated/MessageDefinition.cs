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
    /// A resource that defines a type of message that can be exchanged between systems
    /// </summary>
    [FhirType("MessageDefinition", IsResource=true)]
    [DataContract]
    public partial class MessageDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MessageDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "MessageDefinition"; } }


        [FhirType("FocusComponent")]
        [DataContract]
        public partial class FocusComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FocusComponent"; } }

            /// <summary>
            /// Type of resource
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ResourceType> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<ResourceType> _codeElement;

            /// <summary>
            /// Type of resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ResourceType? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<ResourceType>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Profile that must be adhered to by focus
            /// </summary>
            [FhirElement("profile", Order=50)]
            [References("StructureDefinition")]
            [DataMember]
            public ResourceReference Profile
            {
                get { return _profile; }
                set { _profile = value; OnPropertyChanged("Profile"); }
            }

            private ResourceReference _profile;

            /// <summary>
            /// Minimum number of focuses of this type
            /// </summary>
            [FhirElement("min", Order=60)]
            [DataMember]
            public UnsignedInt MinElement
            {
                get { return _minElement; }
                set { _minElement = value; OnPropertyChanged("MinElement"); }
            }

            private UnsignedInt _minElement;

            /// <summary>
            /// Minimum number of focuses of this type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Min
            {
                get { return MinElement != null ? MinElement.Value : null; }
                set
                {
                    if (value == null)
                        MinElement = null;
                    else
                        MinElement = new UnsignedInt(value);
                    OnPropertyChanged("Min");
                }
            }

            /// <summary>
            /// Maximum number of focuses of this type
            /// </summary>
            [FhirElement("max", Order=70)]
            [DataMember]
            public FhirString MaxElement
            {
                get { return _maxElement; }
                set { _maxElement = value; OnPropertyChanged("MaxElement"); }
            }

            private FhirString _maxElement;

            /// <summary>
            /// Maximum number of focuses of this type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Max
            {
                get { return MaxElement != null ? MaxElement.Value : null; }
                set
                {
                    if (value == null)
                        MaxElement = null;
                    else
                        MaxElement = new FhirString(value);
                    OnPropertyChanged("Max");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FocusComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code<ResourceType>)CodeElement.DeepCopy();
                    if (Profile != null) dest.Profile = (ResourceReference)Profile.DeepCopy();
                    if (MinElement != null) dest.MinElement = (UnsignedInt)MinElement.DeepCopy();
                    if (MaxElement != null) dest.MaxElement = (FhirString)MaxElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FocusComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FocusComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(Profile, otherT.Profile)) return false;
                if (!DeepComparable.Matches(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.Matches(MaxElement, otherT.MaxElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FocusComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
                if (!DeepComparable.IsExactly(MinElement, otherT.MinElement)) return false;
                if (!DeepComparable.IsExactly(MaxElement, otherT.MaxElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (Profile != null) yield return Profile;
                    if (MinElement != null) yield return MinElement;
                    if (MaxElement != null) yield return MaxElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (Profile != null) yield return new ElementValue("profile", Profile);
                    if (MinElement != null) yield return new ElementValue("min", MinElement);
                    if (MaxElement != null) yield return new ElementValue("max", MaxElement);
                }
            }


        }


        [FhirType("AllowedResponseComponent")]
        [DataContract]
        public partial class AllowedResponseComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AllowedResponseComponent"; } }

            /// <summary>
            /// Reference to allowed message definition response
            /// </summary>
            [FhirElement("message", Order=40)]
            [References("MessageDefinition")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Message
            {
                get { return _message; }
                set { _message = value; OnPropertyChanged("Message"); }
            }

            private ResourceReference _message;

            /// <summary>
            /// When should this response be used
            /// </summary>
            [FhirElement("situation", Order=50)]
            [DataMember]
            public Markdown Situation
            {
                get { return _situation; }
                set { _situation = value; OnPropertyChanged("Situation"); }
            }

            private Markdown _situation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AllowedResponseComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Message != null) dest.Message = (ResourceReference)Message.DeepCopy();
                    if (Situation != null) dest.Situation = (Markdown)Situation.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AllowedResponseComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AllowedResponseComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Message, otherT.Message)) return false;
                if (!DeepComparable.Matches(Situation, otherT.Situation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AllowedResponseComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Message, otherT.Message)) return false;
                if (!DeepComparable.IsExactly(Situation, otherT.Situation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Message != null) yield return Message;
                    if (Situation != null) yield return Situation;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Message != null) yield return new ElementValue("message", Message);
                    if (Situation != null) yield return new ElementValue("situation", Situation);
                }
            }


        }


        /// <summary>
        /// Logical URI to reference this message definition (globally unique)
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
        /// Logical URI to reference this message definition (globally unique)
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
        /// Additional identifier for the message definition
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Business version of the message definition
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
        /// Business version of the message definition
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
        /// Name for this message definition (computer friendly)
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
        /// Name for this message definition (computer friendly)
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
        /// Name for this message definition (human friendly)
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
        /// Name for this message definition (human friendly)
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
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=140)]
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
        [FhirElement("experimental", InSummary=true, Order=150)]
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
        /// Date this was last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date this was last changed
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
        [FhirElement("publisher", InSummary=true, Order=170)]
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
        [FhirElement("contact", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Natural language description of the message definition
        /// </summary>
        [FhirElement("description", InSummary=true, Order=190)]
        [DataMember]
        public Markdown Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }

        private Markdown _description;

        /// <summary>
        /// Context the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for message definition (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Why this message definition is defined
        /// </summary>
        [FhirElement("purpose", InSummary=true, Order=220)]
        [DataMember]
        public Markdown Purpose
        {
            get { return _purpose; }
            set { _purpose = value; OnPropertyChanged("Purpose"); }
        }

        private Markdown _purpose;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=230)]
        [DataMember]
        public Markdown Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        private Markdown _copyright;

        /// <summary>
        /// Definition this one is based on
        /// </summary>
        [FhirElement("base", InSummary=true, Order=240)]
        [References("MessageDefinition")]
        [DataMember]
        public ResourceReference Base
        {
            get { return _base; }
            set { _base = value; OnPropertyChanged("Base"); }
        }

        private ResourceReference _base;

        /// <summary>
        /// Protocol/workflow this is part of
        /// </summary>
        [FhirElement("parent", InSummary=true, Order=250)]
        [References("ActivityDefinition","PlanDefinition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Parent
        {
            get { if (_parent==null) _parent = new List<ResourceReference>(); return _parent; }
            set { _parent = value; OnPropertyChanged("Parent"); }
        }

        private List<ResourceReference> _parent;

        /// <summary>
        /// Takes the place of
        /// </summary>
        [FhirElement("replaces", InSummary=true, Order=260)]
        [References("MessageDefinition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Replaces
        {
            get { if (_replaces==null) _replaces = new List<ResourceReference>(); return _replaces; }
            set { _replaces = value; OnPropertyChanged("Replaces"); }
        }

        private List<ResourceReference> _replaces;

        /// <summary>
        /// Event type
        /// </summary>
        [FhirElement("event", InSummary=true, Order=270)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Coding Event
        {
            get { return _event; }
            set { _event = value; OnPropertyChanged("Event"); }
        }

        private Coding _event;

        /// <summary>
        /// Consequence | Currency | Notification
        /// </summary>
        [FhirElement("category", InSummary=true, Order=280)]
        [DataMember]
        public Code<MessageSignificanceCategory> CategoryElement
        {
            get { return _categoryElement; }
            set { _categoryElement = value; OnPropertyChanged("CategoryElement"); }
        }

        private Code<MessageSignificanceCategory> _categoryElement;

        /// <summary>
        /// Consequence | Currency | Notification
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MessageSignificanceCategory? Category
        {
            get { return CategoryElement != null ? CategoryElement.Value : null; }
            set
            {
                if (value == null)
                    CategoryElement = null;
                else
                    CategoryElement = new Code<MessageSignificanceCategory>(value);
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        /// Resource(s) that are the subject of the event
        /// </summary>
        [FhirElement("focus", InSummary=true, Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FocusComponent> Focus
        {
            get { if (_focus==null) _focus = new List<FocusComponent>(); return _focus; }
            set { _focus = value; OnPropertyChanged("Focus"); }
        }

        private List<FocusComponent> _focus;

        /// <summary>
        /// Is a response required?
        /// </summary>
        [FhirElement("responseRequired", Order=300)]
        [DataMember]
        public FhirBoolean ResponseRequiredElement
        {
            get { return _responseRequiredElement; }
            set { _responseRequiredElement = value; OnPropertyChanged("ResponseRequiredElement"); }
        }

        private FhirBoolean _responseRequiredElement;

        /// <summary>
        /// Is a response required?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? ResponseRequired
        {
            get { return ResponseRequiredElement != null ? ResponseRequiredElement.Value : null; }
            set
            {
                if (value == null)
                    ResponseRequiredElement = null;
                else
                    ResponseRequiredElement = new FhirBoolean(value);
                OnPropertyChanged("ResponseRequired");
            }
        }

        /// <summary>
        /// Responses to this message
        /// </summary>
        [FhirElement("allowedResponse", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AllowedResponseComponent> AllowedResponse
        {
            get { if (_allowedResponse==null) _allowedResponse = new List<AllowedResponseComponent>(); return _allowedResponse; }
            set { _allowedResponse = value; OnPropertyChanged("AllowedResponse"); }
        }

        private List<AllowedResponseComponent> _allowedResponse;


        public static ElementDefinition.ConstraintComponent MessageDefinition_MD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "focus.all(max='*' or (max.toInteger() > 0))",
            Key = "md-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Max must be postive int or *",
            Xpath = "f:max/@value='*' or number(f:max/@value) > 0"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(MessageDefinition_MD_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MessageDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (Description != null) dest.Description = (Markdown)Description.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (Purpose != null) dest.Purpose = (Markdown)Purpose.DeepCopy();
                if (Copyright != null) dest.Copyright = (Markdown)Copyright.DeepCopy();
                if (Base != null) dest.Base = (ResourceReference)Base.DeepCopy();
                if (Parent != null) dest.Parent = new List<ResourceReference>(Parent.DeepCopy());
                if (Replaces != null) dest.Replaces = new List<ResourceReference>(Replaces.DeepCopy());
                if (Event != null) dest.Event = (Coding)Event.DeepCopy();
                if (CategoryElement != null) dest.CategoryElement = (Code<MessageSignificanceCategory>)CategoryElement.DeepCopy();
                if (Focus != null) dest.Focus = new List<FocusComponent>(Focus.DeepCopy());
                if (ResponseRequiredElement != null) dest.ResponseRequiredElement = (FhirBoolean)ResponseRequiredElement.DeepCopy();
                if (AllowedResponse != null) dest.AllowedResponse = new List<AllowedResponseComponent>(AllowedResponse.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MessageDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MessageDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Description, otherT.Description)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.Matches(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.Matches(Base, otherT.Base)) return false;
            if ( !DeepComparable.Matches(Parent, otherT.Parent)) return false;
            if ( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.Matches(Event, otherT.Event)) return false;
            if (!DeepComparable.Matches(CategoryElement, otherT.CategoryElement)) return false;
            if ( !DeepComparable.Matches(Focus, otherT.Focus)) return false;
            if (!DeepComparable.Matches(ResponseRequiredElement, otherT.ResponseRequiredElement)) return false;
            if ( !DeepComparable.Matches(AllowedResponse, otherT.AllowedResponse)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MessageDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.IsExactly(Base, otherT.Base)) return false;
            if (!DeepComparable.IsExactly(Parent, otherT.Parent)) return false;
            if (!DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.IsExactly(Event, otherT.Event)) return false;
            if (!DeepComparable.IsExactly(CategoryElement, otherT.CategoryElement)) return false;
            if (!DeepComparable.IsExactly(Focus, otherT.Focus)) return false;
            if (!DeepComparable.IsExactly(ResponseRequiredElement, otherT.ResponseRequiredElement)) return false;
            if (!DeepComparable.IsExactly(AllowedResponse, otherT.AllowedResponse)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                if (Identifier != null) yield return Identifier;
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (TitleElement != null) yield return TitleElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Description != null) yield return Description;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (Purpose != null) yield return Purpose;
                if (Copyright != null) yield return Copyright;
                if (Base != null) yield return Base;
                foreach (var elem in Parent) { if (elem != null) yield return elem; }
                foreach (var elem in Replaces) { if (elem != null) yield return elem; }
                if (Event != null) yield return Event;
                if (CategoryElement != null) yield return CategoryElement;
                foreach (var elem in Focus) { if (elem != null) yield return elem; }
                if (ResponseRequiredElement != null) yield return ResponseRequiredElement;
                foreach (var elem in AllowedResponse) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (Purpose != null) yield return new ElementValue("purpose", Purpose);
                if (Copyright != null) yield return new ElementValue("copyright", Copyright);
                if (Base != null) yield return new ElementValue("base", Base);
                foreach (var elem in Parent) { if (elem != null) yield return new ElementValue("parent", elem); }
                foreach (var elem in Replaces) { if (elem != null) yield return new ElementValue("replaces", elem); }
                if (Event != null) yield return new ElementValue("event", Event);
                if (CategoryElement != null) yield return new ElementValue("category", CategoryElement);
                foreach (var elem in Focus) { if (elem != null) yield return new ElementValue("focus", elem); }
                if (ResponseRequiredElement != null) yield return new ElementValue("responseRequired", ResponseRequiredElement);
                foreach (var elem in AllowedResponse) { if (elem != null) yield return new ElementValue("allowedResponse", elem); }
            }
        }

    }

}
