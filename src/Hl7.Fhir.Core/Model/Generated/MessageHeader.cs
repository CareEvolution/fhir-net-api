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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A resource that describes a message that is exchanged between systems
    /// </summary>
    [FhirType("MessageHeader", IsResource=true)]
    [DataContract]
    public partial class MessageHeader : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MessageHeader; } }
        [NotMapped]
        public override string TypeName { get { return "MessageHeader"; } }

        /// <summary>
        /// The kind of response to a message
        /// (url: http://hl7.org/fhir/ValueSet/response-code)
        /// </summary>
        [FhirEnumeration("ResponseType")]
        public enum ResponseType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/response-code)
            /// </summary>
            [EnumLiteral("ok", "http://hl7.org/fhir/response-code"), Description("OK")]
            Ok,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/response-code)
            /// </summary>
            [EnumLiteral("transient-error", "http://hl7.org/fhir/response-code"), Description("Transient Error")]
            TransientError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/response-code)
            /// </summary>
            [EnumLiteral("fatal-error", "http://hl7.org/fhir/response-code"), Description("Fatal Error")]
            FatalError,
        }


        [FhirType("MessageDestinationComponent")]
        [DataContract]
        public partial class MessageDestinationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MessageDestinationComponent"; } }

            /// <summary>
            /// Name of system
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name of system
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
            /// Particular delivery destination within the destination
            /// </summary>
            [FhirElement("target", InSummary=true, Order=50)]
            [References("Device")]
            [DataMember]
            public ResourceReference Target
            {
                get { return _target; }
                set { _target = value; OnPropertyChanged("Target"); }
            }

            private ResourceReference _target;

            /// <summary>
            /// Actual destination address or id
            /// </summary>
            [FhirElement("endpoint", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUrl EndpointElement
            {
                get { return _endpointElement; }
                set { _endpointElement = value; OnPropertyChanged("EndpointElement"); }
            }

            private FhirUrl _endpointElement;

            /// <summary>
            /// Actual destination address or id
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Endpoint
            {
                get { return EndpointElement != null ? EndpointElement.Value : null; }
                set
                {
                    if (value == null)
                        EndpointElement = null;
                    else
                        EndpointElement = new FhirUrl(value);
                    OnPropertyChanged("Endpoint");
                }
            }

            /// <summary>
            /// Intended "real-world" recipient for the data
            /// </summary>
            [FhirElement("receiver", InSummary=true, Order=70)]
            [References("Practitioner","Organization")]
            [DataMember]
            public ResourceReference Receiver
            {
                get { return _receiver; }
                set { _receiver = value; OnPropertyChanged("Receiver"); }
            }

            private ResourceReference _receiver;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MessageDestinationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Target != null) dest.Target = (ResourceReference)Target.DeepCopy();
                    if (EndpointElement != null) dest.EndpointElement = (FhirUrl)EndpointElement.DeepCopy();
                    if (Receiver != null) dest.Receiver = (ResourceReference)Receiver.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MessageDestinationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MessageDestinationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(Target, otherT.Target)) return false;
                if (!DeepComparable.Matches(EndpointElement, otherT.EndpointElement)) return false;
                if (!DeepComparable.Matches(Receiver, otherT.Receiver)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MessageDestinationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
                if (!DeepComparable.IsExactly(EndpointElement, otherT.EndpointElement)) return false;
                if (!DeepComparable.IsExactly(Receiver, otherT.Receiver)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (Target != null) yield return Target;
                    if (EndpointElement != null) yield return EndpointElement;
                    if (Receiver != null) yield return Receiver;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (Target != null) yield return new ElementValue("target", Target);
                    if (EndpointElement != null) yield return new ElementValue("endpoint", EndpointElement);
                    if (Receiver != null) yield return new ElementValue("receiver", Receiver);
                }
            }


        }


        [FhirType("MessageSourceComponent")]
        [DataContract]
        public partial class MessageSourceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MessageSourceComponent"; } }

            /// <summary>
            /// Name of system
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name of system
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
            /// Name of software running the system
            /// </summary>
            [FhirElement("software", InSummary=true, Order=50)]
            [DataMember]
            public FhirString SoftwareElement
            {
                get { return _softwareElement; }
                set { _softwareElement = value; OnPropertyChanged("SoftwareElement"); }
            }

            private FhirString _softwareElement;

            /// <summary>
            /// Name of software running the system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Software
            {
                get { return SoftwareElement != null ? SoftwareElement.Value : null; }
                set
                {
                    if (value == null)
                        SoftwareElement = null;
                    else
                        SoftwareElement = new FhirString(value);
                    OnPropertyChanged("Software");
                }
            }

            /// <summary>
            /// Version of software running
            /// </summary>
            [FhirElement("version", InSummary=true, Order=60)]
            [DataMember]
            public FhirString VersionElement
            {
                get { return _versionElement; }
                set { _versionElement = value; OnPropertyChanged("VersionElement"); }
            }

            private FhirString _versionElement;

            /// <summary>
            /// Version of software running
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
            /// Human contact for problems
            /// </summary>
            [FhirElement("contact", InSummary=true, Order=70)]
            [DataMember]
            public ContactPoint Contact
            {
                get { return _contact; }
                set { _contact = value; OnPropertyChanged("Contact"); }
            }

            private ContactPoint _contact;

            /// <summary>
            /// Actual message source address or id
            /// </summary>
            [FhirElement("endpoint", InSummary=true, Order=80)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUrl EndpointElement
            {
                get { return _endpointElement; }
                set { _endpointElement = value; OnPropertyChanged("EndpointElement"); }
            }

            private FhirUrl _endpointElement;

            /// <summary>
            /// Actual message source address or id
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Endpoint
            {
                get { return EndpointElement != null ? EndpointElement.Value : null; }
                set
                {
                    if (value == null)
                        EndpointElement = null;
                    else
                        EndpointElement = new FhirUrl(value);
                    OnPropertyChanged("Endpoint");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MessageSourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (SoftwareElement != null) dest.SoftwareElement = (FhirString)SoftwareElement.DeepCopy();
                    if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                    if (Contact != null) dest.Contact = (ContactPoint)Contact.DeepCopy();
                    if (EndpointElement != null) dest.EndpointElement = (FhirUrl)EndpointElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MessageSourceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MessageSourceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(SoftwareElement, otherT.SoftwareElement)) return false;
                if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
                if (!DeepComparable.Matches(Contact, otherT.Contact)) return false;
                if (!DeepComparable.Matches(EndpointElement, otherT.EndpointElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MessageSourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(SoftwareElement, otherT.SoftwareElement)) return false;
                if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
                if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
                if (!DeepComparable.IsExactly(EndpointElement, otherT.EndpointElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (SoftwareElement != null) yield return SoftwareElement;
                    if (VersionElement != null) yield return VersionElement;
                    if (Contact != null) yield return Contact;
                    if (EndpointElement != null) yield return EndpointElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (SoftwareElement != null) yield return new ElementValue("software", SoftwareElement);
                    if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                    if (Contact != null) yield return new ElementValue("contact", Contact);
                    if (EndpointElement != null) yield return new ElementValue("endpoint", EndpointElement);
                }
            }


        }


        [FhirType("ResponseComponent")]
        [DataContract]
        public partial class ResponseComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ResponseComponent"; } }

            /// <summary>
            /// Id of original message
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id IdentifierElement
            {
                get { return _identifierElement; }
                set { _identifierElement = value; OnPropertyChanged("IdentifierElement"); }
            }

            private Id _identifierElement;

            /// <summary>
            /// Id of original message
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Identifier
            {
                get { return IdentifierElement != null ? IdentifierElement.Value : null; }
                set
                {
                    if (value == null)
                        IdentifierElement = null;
                    else
                        IdentifierElement = new Id(value);
                    OnPropertyChanged("Identifier");
                }
            }

            /// <summary>
            /// ok | transient-error | fatal-error
            /// </summary>
            [FhirElement("code", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ResponseType> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<ResponseType> _codeElement;

            /// <summary>
            /// ok | transient-error | fatal-error
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ResponseType? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<ResponseType>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Specific list of hints/warnings/errors
            /// </summary>
            [FhirElement("details", InSummary=true, Order=60)]
            [References("OperationOutcome")]
            [DataMember]
            public ResourceReference Details
            {
                get { return _details; }
                set { _details = value; OnPropertyChanged("Details"); }
            }

            private ResourceReference _details;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResponseComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (IdentifierElement != null) dest.IdentifierElement = (Id)IdentifierElement.DeepCopy();
                    if (CodeElement != null) dest.CodeElement = (Code<ResponseType>)CodeElement.DeepCopy();
                    if (Details != null) dest.Details = (ResourceReference)Details.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ResponseComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ResponseComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(IdentifierElement, otherT.IdentifierElement)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(Details, otherT.Details)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResponseComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(IdentifierElement, otherT.IdentifierElement)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(Details, otherT.Details)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (IdentifierElement != null) yield return IdentifierElement;
                    if (CodeElement != null) yield return CodeElement;
                    if (Details != null) yield return Details;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IdentifierElement != null) yield return new ElementValue("identifier", IdentifierElement);
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (Details != null) yield return new ElementValue("details", Details);
                }
            }


        }


        /// <summary>
        /// Code for the event this message represents or link to event definition
        /// </summary>
        [FhirElement("event", InSummary=true, Order=90, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Coding),typeof(FhirUri))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Event
        {
            get { return _event; }
            set { _event = value; OnPropertyChanged("Event"); }
        }

        private Element _event;

        /// <summary>
        /// Message destination application(s)
        /// </summary>
        [FhirElement("destination", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MessageDestinationComponent> Destination
        {
            get { if (_destination==null) _destination = new List<MessageDestinationComponent>(); return _destination; }
            set { _destination = value; OnPropertyChanged("Destination"); }
        }

        private List<MessageDestinationComponent> _destination;

        /// <summary>
        /// Real world sender of the message
        /// </summary>
        [FhirElement("sender", InSummary=true, Order=110)]
        [References("Practitioner","Organization")]
        [DataMember]
        public ResourceReference Sender
        {
            get { return _sender; }
            set { _sender = value; OnPropertyChanged("Sender"); }
        }

        private ResourceReference _sender;

        /// <summary>
        /// The source of the data entry
        /// </summary>
        [FhirElement("enterer", InSummary=true, Order=120)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Enterer
        {
            get { return _enterer; }
            set { _enterer = value; OnPropertyChanged("Enterer"); }
        }

        private ResourceReference _enterer;

        /// <summary>
        /// The source of the decision
        /// </summary>
        [FhirElement("author", InSummary=true, Order=130)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// Message source application
        /// </summary>
        [FhirElement("source", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public MessageSourceComponent Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private MessageSourceComponent _source;

        /// <summary>
        /// Final responsibility for event
        /// </summary>
        [FhirElement("responsible", InSummary=true, Order=150)]
        [References("Practitioner","Organization")]
        [DataMember]
        public ResourceReference Responsible
        {
            get { return _responsible; }
            set { _responsible = value; OnPropertyChanged("Responsible"); }
        }

        private ResourceReference _responsible;

        /// <summary>
        /// Cause of event
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=160)]
        [DataMember]
        public CodeableConcept Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private CodeableConcept _reason;

        /// <summary>
        /// If this is a reply to prior message
        /// </summary>
        [FhirElement("response", InSummary=true, Order=170)]
        [DataMember]
        public ResponseComponent Response
        {
            get { return _response; }
            set { _response = value; OnPropertyChanged("Response"); }
        }

        private ResponseComponent _response;

        /// <summary>
        /// The actual content of the message
        /// </summary>
        [FhirElement("focus", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Focus
        {
            get { if (_focus==null) _focus = new List<ResourceReference>(); return _focus; }
            set { _focus = value; OnPropertyChanged("Focus"); }
        }

        private List<ResourceReference> _focus;

        /// <summary>
        /// Link to the definition for this message
        /// </summary>
        [FhirElement("definition", InSummary=true, Order=190)]
        [DataMember]
        public Canonical DefinitionElement
        {
            get { return _definitionElement; }
            set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
        }

        private Canonical _definitionElement;

        /// <summary>
        /// Link to the definition for this message
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Definition
        {
            get { return DefinitionElement != null ? DefinitionElement.Value : null; }
            set
            {
                if (value == null)
                    DefinitionElement = null;
                else
                    DefinitionElement = new Canonical(value);
                OnPropertyChanged("Definition");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MessageHeader;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Event != null) dest.Event = (Element)Event.DeepCopy();
                if (Destination != null) dest.Destination = new List<MessageDestinationComponent>(Destination.DeepCopy());
                if (Sender != null) dest.Sender = (ResourceReference)Sender.DeepCopy();
                if (Enterer != null) dest.Enterer = (ResourceReference)Enterer.DeepCopy();
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (Source != null) dest.Source = (MessageSourceComponent)Source.DeepCopy();
                if (Responsible != null) dest.Responsible = (ResourceReference)Responsible.DeepCopy();
                if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                if (Response != null) dest.Response = (ResponseComponent)Response.DeepCopy();
                if (Focus != null) dest.Focus = new List<ResourceReference>(Focus.DeepCopy());
                if (DefinitionElement != null) dest.DefinitionElement = (Canonical)DefinitionElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MessageHeader());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MessageHeader;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Event, otherT.Event)) return false;
            if ( !DeepComparable.Matches(Destination, otherT.Destination)) return false;
            if (!DeepComparable.Matches(Sender, otherT.Sender)) return false;
            if (!DeepComparable.Matches(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if (!DeepComparable.Matches(Responsible, otherT.Responsible)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(Response, otherT.Response)) return false;
            if ( !DeepComparable.Matches(Focus, otherT.Focus)) return false;
            if (!DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MessageHeader;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Event, otherT.Event)) return false;
            if (!DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
            if (!DeepComparable.IsExactly(Sender, otherT.Sender)) return false;
            if (!DeepComparable.IsExactly(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Responsible, otherT.Responsible)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Response, otherT.Response)) return false;
            if (!DeepComparable.IsExactly(Focus, otherT.Focus)) return false;
            if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Event != null) yield return Event;
                foreach (var elem in Destination) { if (elem != null) yield return elem; }
                if (Sender != null) yield return Sender;
                if (Enterer != null) yield return Enterer;
                if (Author != null) yield return Author;
                if (Source != null) yield return Source;
                if (Responsible != null) yield return Responsible;
                if (Reason != null) yield return Reason;
                if (Response != null) yield return Response;
                foreach (var elem in Focus) { if (elem != null) yield return elem; }
                if (DefinitionElement != null) yield return DefinitionElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Event != null) yield return new ElementValue("event", Event);
                foreach (var elem in Destination) { if (elem != null) yield return new ElementValue("destination", elem); }
                if (Sender != null) yield return new ElementValue("sender", Sender);
                if (Enterer != null) yield return new ElementValue("enterer", Enterer);
                if (Author != null) yield return new ElementValue("author", Author);
                if (Source != null) yield return new ElementValue("source", Source);
                if (Responsible != null) yield return new ElementValue("responsible", Responsible);
                if (Reason != null) yield return new ElementValue("reason", Reason);
                if (Response != null) yield return new ElementValue("response", Response);
                foreach (var elem in Focus) { if (elem != null) yield return new ElementValue("focus", elem); }
                if (DefinitionElement != null) yield return new ElementValue("definition", DefinitionElement);
            }
        }

    }

}
