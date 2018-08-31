using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
    /// A conformance statement
    /// </summary>
    [FhirType("Conformance", IsResource=true)]
    [DataContract]
    public partial class Conformance : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Conformance; } }
        [NotMapped]
        public override string TypeName { get { return "Conformance"; } }

        /// <summary>
        /// How a conformance statement is intended to be used.
        /// (url: http://hl7.org/fhir/ValueSet/conformance-statement-kind)
        /// </summary>
        [FhirEnumeration("ConformanceStatementKind")]
        public enum ConformanceStatementKind
        {
            /// <summary>
            /// The Conformance instance represents the present capabilities of a specific system instance.  This is the kind returned by OPTIONS for a FHIR server end-point.
            /// (system: http://hl7.org/fhir/conformance-statement-kind)
            /// </summary>
            [EnumLiteral("instance", "http://hl7.org/fhir/conformance-statement-kind"), Description("Instance")]
            Instance,
            /// <summary>
            /// The Conformance instance represents the capabilities of a system or piece of software, independent of a particular installation.
            /// (system: http://hl7.org/fhir/conformance-statement-kind)
            /// </summary>
            [EnumLiteral("capability", "http://hl7.org/fhir/conformance-statement-kind"), Description("Capability")]
            Capability,
            /// <summary>
            /// The Conformance instance represents a set of requirements for other systems to meet; e.g. as part of an implementation guide or 'request for proposal'.
            /// (system: http://hl7.org/fhir/conformance-statement-kind)
            /// </summary>
            [EnumLiteral("requirements", "http://hl7.org/fhir/conformance-statement-kind"), Description("Requirements")]
            Requirements,
        }

        /// <summary>
        /// A code that indicates whether an application accepts unknown elements or extensions when reading resources.
        /// (url: http://hl7.org/fhir/ValueSet/unknown-content-code)
        /// </summary>
        [FhirEnumeration("UnknownContentCode")]
        public enum UnknownContentCode
        {
            /// <summary>
            /// The application does not accept either unknown elements or extensions.
            /// (system: http://hl7.org/fhir/unknown-content-code)
            /// </summary>
            [EnumLiteral("no", "http://hl7.org/fhir/unknown-content-code"), Description("Neither Elements or Extensions")]
            No,
            /// <summary>
            /// The application accepts unknown extensions, but not unknown elements.
            /// (system: http://hl7.org/fhir/unknown-content-code)
            /// </summary>
            [EnumLiteral("extensions", "http://hl7.org/fhir/unknown-content-code"), Description("Unknown Extensions")]
            Extensions,
            /// <summary>
            /// The application accepts unknown elements, but not unknown extensions.
            /// (system: http://hl7.org/fhir/unknown-content-code)
            /// </summary>
            [EnumLiteral("elements", "http://hl7.org/fhir/unknown-content-code"), Description("Unknown Elements")]
            Elements,
            /// <summary>
            /// The application accepts unknown elements and extensions.
            /// (system: http://hl7.org/fhir/unknown-content-code)
            /// </summary>
            [EnumLiteral("both", "http://hl7.org/fhir/unknown-content-code"), Description("Unknown Elements and Extensions")]
            Both,
        }

        /// <summary>
        /// The mode of a RESTful conformance statement.
        /// (url: http://hl7.org/fhir/ValueSet/restful-conformance-mode)
        /// </summary>
        [FhirEnumeration("RestfulConformanceMode")]
        public enum RestfulConformanceMode
        {
            /// <summary>
            /// The application acts as a client for this resource.
            /// (system: http://hl7.org/fhir/restful-conformance-mode)
            /// </summary>
            [EnumLiteral("client", "http://hl7.org/fhir/restful-conformance-mode"), Description("Client")]
            Client,
            /// <summary>
            /// The application acts as a server for this resource.
            /// (system: http://hl7.org/fhir/restful-conformance-mode)
            /// </summary>
            [EnumLiteral("server", "http://hl7.org/fhir/restful-conformance-mode"), Description("Server")]
            Server,
        }

        /// <summary>
        /// Operations supported by REST at the type or instance level.
        /// (url: http://hl7.org/fhir/ValueSet/type-restful-interaction)
        /// </summary>
        [FhirEnumeration("TypeRestfulInteraction")]
        public enum TypeRestfulInteraction
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("read", "http://hl7.org/fhir/restful-interaction"), Description("read")]
            Read,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("vread", "http://hl7.org/fhir/restful-interaction"), Description("vread")]
            Vread,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("update", "http://hl7.org/fhir/restful-interaction"), Description("update")]
            Update,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("delete", "http://hl7.org/fhir/restful-interaction"), Description("delete")]
            Delete,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("history-instance", "http://hl7.org/fhir/restful-interaction"), Description("history-instance")]
            HistoryInstance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("validate", "http://hl7.org/fhir/restful-interaction"), Description("validate")]
            Validate,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("history-type", "http://hl7.org/fhir/restful-interaction"), Description("history-type")]
            HistoryType,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("create", "http://hl7.org/fhir/restful-interaction"), Description("create")]
            Create,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("search-type", "http://hl7.org/fhir/restful-interaction"), Description("search-type")]
            SearchType,
        }

        /// <summary>
        /// How the system supports versioning for a resource.
        /// (url: http://hl7.org/fhir/ValueSet/versioning-policy)
        /// </summary>
        [FhirEnumeration("ResourceVersionPolicy")]
        public enum ResourceVersionPolicy
        {
            /// <summary>
            /// VersionId meta-property is not supported (server) or used (client).
            /// (system: http://hl7.org/fhir/versioning-policy)
            /// </summary>
            [EnumLiteral("no-version", "http://hl7.org/fhir/versioning-policy"), Description("No VersionId Support")]
            NoVersion,
            /// <summary>
            /// VersionId meta-property is supported (server) or used (client).
            /// (system: http://hl7.org/fhir/versioning-policy)
            /// </summary>
            [EnumLiteral("versioned", "http://hl7.org/fhir/versioning-policy"), Description("Versioned")]
            Versioned,
            /// <summary>
            /// VersionId is must be correct for updates (server) or will be specified (If-match header) for updates (client).
            /// (system: http://hl7.org/fhir/versioning-policy)
            /// </summary>
            [EnumLiteral("versioned-update", "http://hl7.org/fhir/versioning-policy"), Description("VersionId tracked fully")]
            VersionedUpdate,
        }

        /// <summary>
        /// A code that indicates how the server supports conditional delete.
        /// (url: http://hl7.org/fhir/ValueSet/conditional-delete-status)
        /// </summary>
        [FhirEnumeration("ConditionalDeleteStatus")]
        public enum ConditionalDeleteStatus
        {
            /// <summary>
            /// No support for conditional deletes.
            /// (system: http://hl7.org/fhir/conditional-delete-status)
            /// </summary>
            [EnumLiteral("not-supported", "http://hl7.org/fhir/conditional-delete-status"), Description("Not Supported")]
            NotSupported,
            /// <summary>
            /// Conditional deletes are supported, but only single resources at a time.
            /// (system: http://hl7.org/fhir/conditional-delete-status)
            /// </summary>
            [EnumLiteral("single", "http://hl7.org/fhir/conditional-delete-status"), Description("Single Deletes Supported")]
            Single,
            /// <summary>
            /// Conditional deletes are supported, and multiple resources can be deleted in a single interaction.
            /// (system: http://hl7.org/fhir/conditional-delete-status)
            /// </summary>
            [EnumLiteral("multiple", "http://hl7.org/fhir/conditional-delete-status"), Description("Multiple Deletes Supported")]
            Multiple,
        }

        /// <summary>
        /// A supported modifier for a search parameter.
        /// (url: http://hl7.org/fhir/ValueSet/search-modifier-code)
        /// </summary>
        [FhirEnumeration("SearchModifierCode")]
        public enum SearchModifierCode
        {
            /// <summary>
            /// The search parameter returns resources that have a value or not.
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("missing", "http://hl7.org/fhir/search-modifier-code"), Description("Missing")]
            Missing,
            /// <summary>
            /// The search parameter returns resources that have a value that exactly matches the supplied parameter (the whole string, including casing and accents).
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("exact", "http://hl7.org/fhir/search-modifier-code"), Description("Exact")]
            Exact,
            /// <summary>
            /// The search parameter returns resources that include the supplied parameter value anywhere within the field being searched.
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("contains", "http://hl7.org/fhir/search-modifier-code"), Description("Contains")]
            Contains,
            /// <summary>
            /// The search parameter returns resources that do not contain a match .
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("not", "http://hl7.org/fhir/search-modifier-code"), Description("Not")]
            Not,
            /// <summary>
            /// The search parameter is processed as a string that searches text associated with the code/value - either CodeableConcept.text, Coding.display, or Identifier.type.text.
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("text", "http://hl7.org/fhir/search-modifier-code"), Description("Text")]
            Text,
            /// <summary>
            /// The search parameter is a URI (relative or absolute) that identifies a value set, and the search parameter tests whether the coding is in the specified value set.
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("in", "http://hl7.org/fhir/search-modifier-code"), Description("In")]
            In,
            /// <summary>
            /// The search parameter is a URI (relative or absolute) that identifies a value set, and the search parameter tests whether the coding is not in the specified value set.
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("not-in", "http://hl7.org/fhir/search-modifier-code"), Description("Not In")]
            NotIn,
            /// <summary>
            /// The search parameter tests whether the value in a resource is subsumed by the specified value (is-a, or hierarchical relationships).
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("below", "http://hl7.org/fhir/search-modifier-code"), Description("Below")]
            Below,
            /// <summary>
            /// The search parameter tests whether the value in a resource subsumes the specified value (is-a, or hierarchical relationships).
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("above", "http://hl7.org/fhir/search-modifier-code"), Description("Above")]
            Above,
            /// <summary>
            /// The search parameter only applies to the Resource Type specified as a modifier (e.g. the modifier is not actually :type, but :Patient etc.).
            /// (system: http://hl7.org/fhir/search-modifier-code)
            /// </summary>
            [EnumLiteral("type", "http://hl7.org/fhir/search-modifier-code"), Description("Type")]
            Type,
        }

        /// <summary>
        /// Operations supported by REST at the system level.
        /// (url: http://hl7.org/fhir/ValueSet/system-restful-interaction)
        /// </summary>
        [FhirEnumeration("SystemRestfulInteraction")]
        public enum SystemRestfulInteraction
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("transaction", "http://hl7.org/fhir/restful-interaction"), Description("transaction")]
            Transaction,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("search-system", "http://hl7.org/fhir/restful-interaction"), Description("search-system")]
            SearchSystem,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-interaction)
            /// </summary>
            [EnumLiteral("history-system", "http://hl7.org/fhir/restful-interaction"), Description("history-system")]
            HistorySystem,
        }

        /// <summary>
        /// A code that indicates how transactions are supported.
        /// (url: http://hl7.org/fhir/ValueSet/transaction-mode)
        /// </summary>
        [FhirEnumeration("TransactionMode")]
        public enum TransactionMode
        {
            /// <summary>
            /// Neither batch or transaction is supported.
            /// (system: http://hl7.org/fhir/transaction-mode)
            /// </summary>
            [EnumLiteral("not-supported", "http://hl7.org/fhir/transaction-mode"), Description("None")]
            NotSupported,
            /// <summary>
            /// Batches are  supported.
            /// (system: http://hl7.org/fhir/transaction-mode)
            /// </summary>
            [EnumLiteral("batch", "http://hl7.org/fhir/transaction-mode"), Description("Batches supported")]
            Batch,
            /// <summary>
            /// Transactions are supported.
            /// (system: http://hl7.org/fhir/transaction-mode)
            /// </summary>
            [EnumLiteral("transaction", "http://hl7.org/fhir/transaction-mode"), Description("Transactions Supported")]
            Transaction,
            /// <summary>
            /// Both batches and transactions are supported.
            /// (system: http://hl7.org/fhir/transaction-mode)
            /// </summary>
            [EnumLiteral("both", "http://hl7.org/fhir/transaction-mode"), Description("Batches & Transactions")]
            Both,
        }

        /// <summary>
        /// The impact of the content of a message.
        /// (url: http://hl7.org/fhir/ValueSet/message-significance-category)
        /// </summary>
        [FhirEnumeration("MessageSignificanceCategory")]
        public enum MessageSignificanceCategory
        {
            /// <summary>
            /// The message represents/requests a change that should not be processed more than once; e.g. Making a booking for an appointment.
            /// (system: http://hl7.org/fhir/message-significance-category)
            /// </summary>
            [EnumLiteral("Consequence", "http://hl7.org/fhir/message-significance-category"), Description("Consequence")]
            Consequence,
            /// <summary>
            /// The message represents a response to query for current information. Retrospective processing is wrong and/or wasteful.
            /// (system: http://hl7.org/fhir/message-significance-category)
            /// </summary>
            [EnumLiteral("Currency", "http://hl7.org/fhir/message-significance-category"), Description("Currency")]
            Currency,
            /// <summary>
            /// The content is not necessarily intended to be current, and it can be reprocessed, though there may be version issues created by processing old notifications.
            /// (system: http://hl7.org/fhir/message-significance-category)
            /// </summary>
            [EnumLiteral("Notification", "http://hl7.org/fhir/message-significance-category"), Description("Notification")]
            Notification,
        }

        /// <summary>
        /// The mode of a message conformance statement.
        /// (url: http://hl7.org/fhir/ValueSet/message-conformance-event-mode)
        /// </summary>
        [FhirEnumeration("ConformanceEventMode")]
        public enum ConformanceEventMode
        {
            /// <summary>
            /// The application sends requests and receives responses.
            /// (system: http://hl7.org/fhir/message-conformance-event-mode)
            /// </summary>
            [EnumLiteral("sender", "http://hl7.org/fhir/message-conformance-event-mode"), Description("Sender")]
            Sender,
            /// <summary>
            /// The application receives requests and sends responses.
            /// (system: http://hl7.org/fhir/message-conformance-event-mode)
            /// </summary>
            [EnumLiteral("receiver", "http://hl7.org/fhir/message-conformance-event-mode"), Description("Receiver")]
            Receiver,
        }

        /// <summary>
        /// Whether the application produces or consumes documents.
        /// (url: http://hl7.org/fhir/ValueSet/document-mode)
        /// </summary>
        [FhirEnumeration("DocumentMode")]
        public enum DocumentMode
        {
            /// <summary>
            /// The application produces documents of the specified type.
            /// (system: http://hl7.org/fhir/document-mode)
            /// </summary>
            [EnumLiteral("producer", "http://hl7.org/fhir/document-mode"), Description("Producer")]
            Producer,
            /// <summary>
            /// The application consumes documents of the specified type.
            /// (system: http://hl7.org/fhir/document-mode)
            /// </summary>
            [EnumLiteral("consumer", "http://hl7.org/fhir/document-mode"), Description("Consumer")]
            Consumer,
        }


        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }

            /// <summary>
            /// Name of a individual to contact
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
            /// Name of a individual to contact
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
            /// Contact details for individual or publisher
            /// </summary>
            [FhirElement("telecom", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContactPoint> Telecom
            {
                get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
                set { _telecom = value; OnPropertyChanged("Telecom"); }
            }

            private List<ContactPoint> _telecom;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContactComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                }
            }


        }


        [FhirType("SoftwareComponent")]
        [DataContract]
        public partial class SoftwareComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SoftwareComponent"; } }

            /// <summary>
            /// A name the software is known by
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// A name the software is known by
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
            /// Version covered by this statement
            /// </summary>
            [FhirElement("version", InSummary=true, Order=50)]
            [DataMember]
            public FhirString VersionElement
            {
                get { return _versionElement; }
                set { _versionElement = value; OnPropertyChanged("VersionElement"); }
            }

            private FhirString _versionElement;

            /// <summary>
            /// Version covered by this statement
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
            /// Date this version released
            /// </summary>
            [FhirElement("releaseDate", InSummary=true, Order=60)]
            [DataMember]
            public FhirDateTime ReleaseDateElement
            {
                get { return _releaseDateElement; }
                set { _releaseDateElement = value; OnPropertyChanged("ReleaseDateElement"); }
            }

            private FhirDateTime _releaseDateElement;

            /// <summary>
            /// Date this version released
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ReleaseDate
            {
                get { return ReleaseDateElement != null ? ReleaseDateElement.Value : null; }
                set
                {
                    if (value == null)
                        ReleaseDateElement = null;
                    else
                        ReleaseDateElement = new FhirDateTime(value);
                    OnPropertyChanged("ReleaseDate");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SoftwareComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                    if (ReleaseDateElement != null) dest.ReleaseDateElement = (FhirDateTime)ReleaseDateElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SoftwareComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SoftwareComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
                if (!DeepComparable.Matches(ReleaseDateElement, otherT.ReleaseDateElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SoftwareComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
                if (!DeepComparable.IsExactly(ReleaseDateElement, otherT.ReleaseDateElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (VersionElement != null) yield return VersionElement;
                    if (ReleaseDateElement != null) yield return ReleaseDateElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                    if (ReleaseDateElement != null) yield return new ElementValue("releaseDate", ReleaseDateElement);
                }
            }


        }


        [FhirType("ImplementationComponent")]
        [DataContract]
        public partial class ImplementationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ImplementationComponent"; } }

            /// <summary>
            /// Describes this specific instance
            /// </summary>
            [FhirElement("description", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Describes this specific instance
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
            /// Base URL for the installation
            /// </summary>
            [FhirElement("url", InSummary=true, Order=50)]
            [DataMember]
            public FhirUri UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUri _urlElement;

            /// <summary>
            /// Base URL for the installation
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ImplementationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ImplementationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ImplementationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ImplementationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (UrlElement != null) yield return UrlElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                }
            }


        }


        [FhirType("RestComponent")]
        [DataContract]
        public partial class RestComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RestComponent"; } }

            /// <summary>
            /// client | server
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<RestfulConformanceMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<RestfulConformanceMode> _modeElement;

            /// <summary>
            /// client | server
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public RestfulConformanceMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<RestfulConformanceMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// General description of implementation
            /// </summary>
            [FhirElement("documentation", Order=50)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// General description of implementation
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            /// <summary>
            /// Information about security of implementation
            /// </summary>
            [FhirElement("security", Order=60)]
            [DataMember]
            public SecurityComponent Security
            {
                get { return _security; }
                set { _security = value; OnPropertyChanged("Security"); }
            }

            private SecurityComponent _security;

            /// <summary>
            /// Resource served on the REST interface
            /// </summary>
            [FhirElement("resource", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceComponent> Resource
            {
                get { if (_resource==null) _resource = new List<ResourceComponent>(); return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private List<ResourceComponent> _resource;

            /// <summary>
            /// What operations are supported?
            /// </summary>
            [FhirElement("interaction", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SystemInteractionComponent> Interaction
            {
                get { if (_interaction==null) _interaction = new List<SystemInteractionComponent>(); return _interaction; }
                set { _interaction = value; OnPropertyChanged("Interaction"); }
            }

            private List<SystemInteractionComponent> _interaction;

            /// <summary>
            /// not-supported | batch | transaction | both
            /// </summary>
            [FhirElement("transactionMode", Order=90)]
            [DataMember]
            public Code<TransactionMode> TransactionModeElement
            {
                get { return _transactionModeElement; }
                set { _transactionModeElement = value; OnPropertyChanged("TransactionModeElement"); }
            }

            private Code<TransactionMode> _transactionModeElement;

            /// <summary>
            /// not-supported | batch | transaction | both
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public TransactionMode? TransactionMode
            {
                get { return TransactionModeElement != null ? TransactionModeElement.Value : null; }
                set
                {
                    if (value == null)
                        TransactionModeElement = null;
                    else
                        TransactionModeElement = new Code<TransactionMode>(value);
                    OnPropertyChanged("TransactionMode");
                }
            }

            /// <summary>
            /// Search params for searching all resources
            /// </summary>
            [FhirElement("searchParam", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SearchParamComponent> SearchParam
            {
                get { if (_searchParam==null) _searchParam = new List<SearchParamComponent>(); return _searchParam; }
                set { _searchParam = value; OnPropertyChanged("SearchParam"); }
            }

            private List<SearchParamComponent> _searchParam;

            /// <summary>
            /// Definition of an operation or a custom query
            /// </summary>
            [FhirElement("operation", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<OperationComponent> Operation
            {
                get { if (_operation==null) _operation = new List<OperationComponent>(); return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private List<OperationComponent> _operation;

            /// <summary>
            /// Compartments served/used by system
            /// </summary>
            [FhirElement("compartment", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirUri> CompartmentElement
            {
                get { if (_compartmentElement==null) _compartmentElement = new List<FhirUri>(); return _compartmentElement; }
                set { _compartmentElement = value; OnPropertyChanged("CompartmentElement"); }
            }

            private List<FhirUri> _compartmentElement;

            /// <summary>
            /// Compartments served/used by system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Compartment
            {
                get { return CompartmentElement != null ? CompartmentElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        CompartmentElement = null;
                    else
                        CompartmentElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                    OnPropertyChanged("Compartment");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ModeElement != null) dest.ModeElement = (Code<RestfulConformanceMode>)ModeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (Security != null) dest.Security = (SecurityComponent)Security.DeepCopy();
                    if (Resource != null) dest.Resource = new List<ResourceComponent>(Resource.DeepCopy());
                    if (Interaction != null) dest.Interaction = new List<SystemInteractionComponent>(Interaction.DeepCopy());
                    if (TransactionModeElement != null) dest.TransactionModeElement = (Code<TransactionMode>)TransactionModeElement.DeepCopy();
                    if (SearchParam != null) dest.SearchParam = new List<SearchParamComponent>(SearchParam.DeepCopy());
                    if (Operation != null) dest.Operation = new List<OperationComponent>(Operation.DeepCopy());
                    if (CompartmentElement != null) dest.CompartmentElement = new List<FhirUri>(CompartmentElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RestComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RestComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.Matches(Security, otherT.Security)) return false;
                if ( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if ( !DeepComparable.Matches(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.Matches(TransactionModeElement, otherT.TransactionModeElement)) return false;
                if ( !DeepComparable.Matches(SearchParam, otherT.SearchParam)) return false;
                if ( !DeepComparable.Matches(Operation, otherT.Operation)) return false;
                if ( !DeepComparable.Matches(CompartmentElement, otherT.CompartmentElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RestComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.IsExactly(Security, otherT.Security)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.IsExactly(TransactionModeElement, otherT.TransactionModeElement)) return false;
                if (!DeepComparable.IsExactly(SearchParam, otherT.SearchParam)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;
                if (!DeepComparable.IsExactly(CompartmentElement, otherT.CompartmentElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ModeElement != null) yield return ModeElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                    if (Security != null) yield return Security;
                    foreach (var elem in Resource) { if (elem != null) yield return elem; }
                    foreach (var elem in Interaction) { if (elem != null) yield return elem; }
                    if (TransactionModeElement != null) yield return TransactionModeElement;
                    foreach (var elem in SearchParam) { if (elem != null) yield return elem; }
                    foreach (var elem in Operation) { if (elem != null) yield return elem; }
                    foreach (var elem in CompartmentElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                    if (Security != null) yield return new ElementValue("security", Security);
                    foreach (var elem in Resource) { if (elem != null) yield return new ElementValue("resource", elem); }
                    foreach (var elem in Interaction) { if (elem != null) yield return new ElementValue("interaction", elem); }
                    if (TransactionModeElement != null) yield return new ElementValue("transactionMode", TransactionModeElement);
                    foreach (var elem in SearchParam) { if (elem != null) yield return new ElementValue("searchParam", elem); }
                    foreach (var elem in Operation) { if (elem != null) yield return new ElementValue("operation", elem); }
                    foreach (var elem in CompartmentElement) { if (elem != null) yield return new ElementValue("compartment", elem); }
                }
            }


        }


        [FhirType("SecurityComponent")]
        [DataContract]
        public partial class SecurityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SecurityComponent"; } }

            /// <summary>
            /// Adds CORS Headers (http://enable-cors.org/)
            /// </summary>
            [FhirElement("cors", Order=40)]
            [DataMember]
            public FhirBoolean CorsElement
            {
                get { return _corsElement; }
                set { _corsElement = value; OnPropertyChanged("CorsElement"); }
            }

            private FhirBoolean _corsElement;

            /// <summary>
            /// Adds CORS Headers (http://enable-cors.org/)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Cors
            {
                get { return CorsElement != null ? CorsElement.Value : null; }
                set
                {
                    if (value == null)
                        CorsElement = null;
                    else
                        CorsElement = new FhirBoolean(value);
                    OnPropertyChanged("Cors");
                }
            }

            /// <summary>
            /// OAuth | SMART-on-FHIR | NTLM | Basic | Kerberos | Certificates
            /// </summary>
            [FhirElement("service", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Service
            {
                get { if (_service==null) _service = new List<CodeableConcept>(); return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private List<CodeableConcept> _service;

            /// <summary>
            /// General description of how security works
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
            /// General description of how security works
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
            /// Certificates associated with security profiles
            /// </summary>
            [FhirElement("certificate", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CertificateComponent> Certificate
            {
                get { if (_certificate==null) _certificate = new List<CertificateComponent>(); return _certificate; }
                set { _certificate = value; OnPropertyChanged("Certificate"); }
            }

            private List<CertificateComponent> _certificate;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SecurityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CorsElement != null) dest.CorsElement = (FhirBoolean)CorsElement.DeepCopy();
                    if (Service != null) dest.Service = new List<CodeableConcept>(Service.DeepCopy());
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Certificate != null) dest.Certificate = new List<CertificateComponent>(Certificate.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SecurityComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SecurityComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CorsElement, otherT.CorsElement)) return false;
                if ( !DeepComparable.Matches(Service, otherT.Service)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if ( !DeepComparable.Matches(Certificate, otherT.Certificate)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SecurityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CorsElement, otherT.CorsElement)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Certificate, otherT.Certificate)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CorsElement != null) yield return CorsElement;
                    foreach (var elem in Service) { if (elem != null) yield return elem; }
                    if (DescriptionElement != null) yield return DescriptionElement;
                    foreach (var elem in Certificate) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CorsElement != null) yield return new ElementValue("cors", CorsElement);
                    foreach (var elem in Service) { if (elem != null) yield return new ElementValue("service", elem); }
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    foreach (var elem in Certificate) { if (elem != null) yield return new ElementValue("certificate", elem); }
                }
            }


        }


        [FhirType("CertificateComponent")]
        [DataContract]
        public partial class CertificateComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CertificateComponent"; } }

            /// <summary>
            /// Mime type for certificate
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Code TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code _typeElement;

            /// <summary>
            /// Mime type for certificate
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Actual certificate
            /// </summary>
            [FhirElement("blob", Order=50)]
            [DataMember]
            public Base64Binary BlobElement
            {
                get { return _blobElement; }
                set { _blobElement = value; OnPropertyChanged("BlobElement"); }
            }

            private Base64Binary _blobElement;

            /// <summary>
            /// Actual certificate
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public byte[] Blob
            {
                get { return BlobElement != null ? BlobElement.Value : null; }
                set
                {
                    if (value == null)
                        BlobElement = null;
                    else
                        BlobElement = new Base64Binary(value);
                    OnPropertyChanged("Blob");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CertificateComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code)TypeElement.DeepCopy();
                    if (BlobElement != null) dest.BlobElement = (Base64Binary)BlobElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CertificateComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CertificateComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(BlobElement, otherT.BlobElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CertificateComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(BlobElement, otherT.BlobElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (BlobElement != null) yield return BlobElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (BlobElement != null) yield return new ElementValue("blob", BlobElement);
                }
            }


        }


        [FhirType("ResourceComponent")]
        [DataContract]
        public partial class ResourceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ResourceComponent"; } }

            /// <summary>
            /// A resource type that is supported
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ResourceType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<ResourceType> _typeElement;

            /// <summary>
            /// A resource type that is supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ResourceType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<ResourceType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Base System profile for all uses of resource
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
            /// What operations are supported?
            /// </summary>
            [FhirElement("interaction", Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ResourceInteractionComponent> Interaction
            {
                get { if (_interaction==null) _interaction = new List<ResourceInteractionComponent>(); return _interaction; }
                set { _interaction = value; OnPropertyChanged("Interaction"); }
            }

            private List<ResourceInteractionComponent> _interaction;

            /// <summary>
            /// no-version | versioned | versioned-update
            /// </summary>
            [FhirElement("versioning", Order=70)]
            [DataMember]
            public Code<ResourceVersionPolicy> VersioningElement
            {
                get { return _versioningElement; }
                set { _versioningElement = value; OnPropertyChanged("VersioningElement"); }
            }

            private Code<ResourceVersionPolicy> _versioningElement;

            /// <summary>
            /// no-version | versioned | versioned-update
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ResourceVersionPolicy? Versioning
            {
                get { return VersioningElement != null ? VersioningElement.Value : null; }
                set
                {
                    if (value == null)
                        VersioningElement = null;
                    else
                        VersioningElement = new Code<ResourceVersionPolicy>(value);
                    OnPropertyChanged("Versioning");
                }
            }

            /// <summary>
            /// Whether vRead can return past versions
            /// </summary>
            [FhirElement("readHistory", Order=80)]
            [DataMember]
            public FhirBoolean ReadHistoryElement
            {
                get { return _readHistoryElement; }
                set { _readHistoryElement = value; OnPropertyChanged("ReadHistoryElement"); }
            }

            private FhirBoolean _readHistoryElement;

            /// <summary>
            /// Whether vRead can return past versions
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? ReadHistory
            {
                get { return ReadHistoryElement != null ? ReadHistoryElement.Value : null; }
                set
                {
                    if (value == null)
                        ReadHistoryElement = null;
                    else
                        ReadHistoryElement = new FhirBoolean(value);
                    OnPropertyChanged("ReadHistory");
                }
            }

            /// <summary>
            /// If update can commit to a new identity
            /// </summary>
            [FhirElement("updateCreate", Order=90)]
            [DataMember]
            public FhirBoolean UpdateCreateElement
            {
                get { return _updateCreateElement; }
                set { _updateCreateElement = value; OnPropertyChanged("UpdateCreateElement"); }
            }

            private FhirBoolean _updateCreateElement;

            /// <summary>
            /// If update can commit to a new identity
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? UpdateCreate
            {
                get { return UpdateCreateElement != null ? UpdateCreateElement.Value : null; }
                set
                {
                    if (value == null)
                        UpdateCreateElement = null;
                    else
                        UpdateCreateElement = new FhirBoolean(value);
                    OnPropertyChanged("UpdateCreate");
                }
            }

            /// <summary>
            /// If allows/uses conditional create
            /// </summary>
            [FhirElement("conditionalCreate", Order=100)]
            [DataMember]
            public FhirBoolean ConditionalCreateElement
            {
                get { return _conditionalCreateElement; }
                set { _conditionalCreateElement = value; OnPropertyChanged("ConditionalCreateElement"); }
            }

            private FhirBoolean _conditionalCreateElement;

            /// <summary>
            /// If allows/uses conditional create
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? ConditionalCreate
            {
                get { return ConditionalCreateElement != null ? ConditionalCreateElement.Value : null; }
                set
                {
                    if (value == null)
                        ConditionalCreateElement = null;
                    else
                        ConditionalCreateElement = new FhirBoolean(value);
                    OnPropertyChanged("ConditionalCreate");
                }
            }

            /// <summary>
            /// If allows/uses conditional update
            /// </summary>
            [FhirElement("conditionalUpdate", Order=110)]
            [DataMember]
            public FhirBoolean ConditionalUpdateElement
            {
                get { return _conditionalUpdateElement; }
                set { _conditionalUpdateElement = value; OnPropertyChanged("ConditionalUpdateElement"); }
            }

            private FhirBoolean _conditionalUpdateElement;

            /// <summary>
            /// If allows/uses conditional update
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? ConditionalUpdate
            {
                get { return ConditionalUpdateElement != null ? ConditionalUpdateElement.Value : null; }
                set
                {
                    if (value == null)
                        ConditionalUpdateElement = null;
                    else
                        ConditionalUpdateElement = new FhirBoolean(value);
                    OnPropertyChanged("ConditionalUpdate");
                }
            }

            /// <summary>
            /// not-supported | single | multiple - how conditional delete is supported
            /// </summary>
            [FhirElement("conditionalDelete", Order=120)]
            [DataMember]
            public Code<ConditionalDeleteStatus> ConditionalDeleteElement
            {
                get { return _conditionalDeleteElement; }
                set { _conditionalDeleteElement = value; OnPropertyChanged("ConditionalDeleteElement"); }
            }

            private Code<ConditionalDeleteStatus> _conditionalDeleteElement;

            /// <summary>
            /// not-supported | single | multiple - how conditional delete is supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConditionalDeleteStatus? ConditionalDelete
            {
                get { return ConditionalDeleteElement != null ? ConditionalDeleteElement.Value : null; }
                set
                {
                    if (value == null)
                        ConditionalDeleteElement = null;
                    else
                        ConditionalDeleteElement = new Code<ConditionalDeleteStatus>(value);
                    OnPropertyChanged("ConditionalDelete");
                }
            }

            /// <summary>
            /// _include values supported by the server
            /// </summary>
            [FhirElement("searchInclude", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> SearchIncludeElement
            {
                get { if (_searchIncludeElement==null) _searchIncludeElement = new List<FhirString>(); return _searchIncludeElement; }
                set { _searchIncludeElement = value; OnPropertyChanged("SearchIncludeElement"); }
            }

            private List<FhirString> _searchIncludeElement;

            /// <summary>
            /// _include values supported by the server
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> SearchInclude
            {
                get { return SearchIncludeElement != null ? SearchIncludeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SearchIncludeElement = null;
                    else
                        SearchIncludeElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("SearchInclude");
                }
            }

            /// <summary>
            /// _revinclude values supported by the server
            /// </summary>
            [FhirElement("searchRevInclude", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> SearchRevIncludeElement
            {
                get { if (_searchRevIncludeElement==null) _searchRevIncludeElement = new List<FhirString>(); return _searchRevIncludeElement; }
                set { _searchRevIncludeElement = value; OnPropertyChanged("SearchRevIncludeElement"); }
            }

            private List<FhirString> _searchRevIncludeElement;

            /// <summary>
            /// _revinclude values supported by the server
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> SearchRevInclude
            {
                get { return SearchRevIncludeElement != null ? SearchRevIncludeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SearchRevIncludeElement = null;
                    else
                        SearchRevIncludeElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("SearchRevInclude");
                }
            }

            /// <summary>
            /// Search params supported by implementation
            /// </summary>
            [FhirElement("searchParam", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SearchParamComponent> SearchParam
            {
                get { if (_searchParam==null) _searchParam = new List<SearchParamComponent>(); return _searchParam; }
                set { _searchParam = value; OnPropertyChanged("SearchParam"); }
            }

            private List<SearchParamComponent> _searchParam;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ResourceType>)TypeElement.DeepCopy();
                    if (Profile != null) dest.Profile = (ResourceReference)Profile.DeepCopy();
                    if (Interaction != null) dest.Interaction = new List<ResourceInteractionComponent>(Interaction.DeepCopy());
                    if (VersioningElement != null) dest.VersioningElement = (Code<ResourceVersionPolicy>)VersioningElement.DeepCopy();
                    if (ReadHistoryElement != null) dest.ReadHistoryElement = (FhirBoolean)ReadHistoryElement.DeepCopy();
                    if (UpdateCreateElement != null) dest.UpdateCreateElement = (FhirBoolean)UpdateCreateElement.DeepCopy();
                    if (ConditionalCreateElement != null) dest.ConditionalCreateElement = (FhirBoolean)ConditionalCreateElement.DeepCopy();
                    if (ConditionalUpdateElement != null) dest.ConditionalUpdateElement = (FhirBoolean)ConditionalUpdateElement.DeepCopy();
                    if (ConditionalDeleteElement != null) dest.ConditionalDeleteElement = (Code<ConditionalDeleteStatus>)ConditionalDeleteElement.DeepCopy();
                    if (SearchIncludeElement != null) dest.SearchIncludeElement = new List<FhirString>(SearchIncludeElement.DeepCopy());
                    if (SearchRevIncludeElement != null) dest.SearchRevIncludeElement = new List<FhirString>(SearchRevIncludeElement.DeepCopy());
                    if (SearchParam != null) dest.SearchParam = new List<SearchParamComponent>(SearchParam.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ResourceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(Profile, otherT.Profile)) return false;
                if ( !DeepComparable.Matches(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.Matches(VersioningElement, otherT.VersioningElement)) return false;
                if (!DeepComparable.Matches(ReadHistoryElement, otherT.ReadHistoryElement)) return false;
                if (!DeepComparable.Matches(UpdateCreateElement, otherT.UpdateCreateElement)) return false;
                if (!DeepComparable.Matches(ConditionalCreateElement, otherT.ConditionalCreateElement)) return false;
                if (!DeepComparable.Matches(ConditionalUpdateElement, otherT.ConditionalUpdateElement)) return false;
                if (!DeepComparable.Matches(ConditionalDeleteElement, otherT.ConditionalDeleteElement)) return false;
                if ( !DeepComparable.Matches(SearchIncludeElement, otherT.SearchIncludeElement)) return false;
                if ( !DeepComparable.Matches(SearchRevIncludeElement, otherT.SearchRevIncludeElement)) return false;
                if ( !DeepComparable.Matches(SearchParam, otherT.SearchParam)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
                if (!DeepComparable.IsExactly(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.IsExactly(VersioningElement, otherT.VersioningElement)) return false;
                if (!DeepComparable.IsExactly(ReadHistoryElement, otherT.ReadHistoryElement)) return false;
                if (!DeepComparable.IsExactly(UpdateCreateElement, otherT.UpdateCreateElement)) return false;
                if (!DeepComparable.IsExactly(ConditionalCreateElement, otherT.ConditionalCreateElement)) return false;
                if (!DeepComparable.IsExactly(ConditionalUpdateElement, otherT.ConditionalUpdateElement)) return false;
                if (!DeepComparable.IsExactly(ConditionalDeleteElement, otherT.ConditionalDeleteElement)) return false;
                if (!DeepComparable.IsExactly(SearchIncludeElement, otherT.SearchIncludeElement)) return false;
                if (!DeepComparable.IsExactly(SearchRevIncludeElement, otherT.SearchRevIncludeElement)) return false;
                if (!DeepComparable.IsExactly(SearchParam, otherT.SearchParam)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Profile != null) yield return Profile;
                    foreach (var elem in Interaction) { if (elem != null) yield return elem; }
                    if (VersioningElement != null) yield return VersioningElement;
                    if (ReadHistoryElement != null) yield return ReadHistoryElement;
                    if (UpdateCreateElement != null) yield return UpdateCreateElement;
                    if (ConditionalCreateElement != null) yield return ConditionalCreateElement;
                    if (ConditionalUpdateElement != null) yield return ConditionalUpdateElement;
                    if (ConditionalDeleteElement != null) yield return ConditionalDeleteElement;
                    foreach (var elem in SearchIncludeElement) { if (elem != null) yield return elem; }
                    foreach (var elem in SearchRevIncludeElement) { if (elem != null) yield return elem; }
                    foreach (var elem in SearchParam) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (Profile != null) yield return new ElementValue("profile", Profile);
                    foreach (var elem in Interaction) { if (elem != null) yield return new ElementValue("interaction", elem); }
                    if (VersioningElement != null) yield return new ElementValue("versioning", VersioningElement);
                    if (ReadHistoryElement != null) yield return new ElementValue("readHistory", ReadHistoryElement);
                    if (UpdateCreateElement != null) yield return new ElementValue("updateCreate", UpdateCreateElement);
                    if (ConditionalCreateElement != null) yield return new ElementValue("conditionalCreate", ConditionalCreateElement);
                    if (ConditionalUpdateElement != null) yield return new ElementValue("conditionalUpdate", ConditionalUpdateElement);
                    if (ConditionalDeleteElement != null) yield return new ElementValue("conditionalDelete", ConditionalDeleteElement);
                    foreach (var elem in SearchIncludeElement) { if (elem != null) yield return new ElementValue("searchInclude", elem); }
                    foreach (var elem in SearchRevIncludeElement) { if (elem != null) yield return new ElementValue("searchRevInclude", elem); }
                    foreach (var elem in SearchParam) { if (elem != null) yield return new ElementValue("searchParam", elem); }
                }
            }


        }


        [FhirType("ResourceInteractionComponent")]
        [DataContract]
        public partial class ResourceInteractionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ResourceInteractionComponent"; } }

            /// <summary>
            /// read | vread | update | delete | history-instance | validate | history-type | create | search-type
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<TypeRestfulInteraction> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<TypeRestfulInteraction> _codeElement;

            /// <summary>
            /// read | vread | update | delete | history-instance | validate | history-type | create | search-type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public TypeRestfulInteraction? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<TypeRestfulInteraction>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Anything special about operation behavior
            /// </summary>
            [FhirElement("documentation", Order=50)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Anything special about operation behavior
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResourceInteractionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code<TypeRestfulInteraction>)CodeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ResourceInteractionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ResourceInteractionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResourceInteractionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                }
            }


        }


        [FhirType("SearchParamComponent")]
        [DataContract]
        public partial class SearchParamComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SearchParamComponent"; } }

            /// <summary>
            /// Name of search parameter
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
            /// Name of search parameter
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
            /// Source of definition for parameter
            /// </summary>
            [FhirElement("definition", Order=50)]
            [DataMember]
            public FhirUri DefinitionElement
            {
                get { return _definitionElement; }
                set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
            }

            private FhirUri _definitionElement;

            /// <summary>
            /// Source of definition for parameter
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
                        DefinitionElement = new FhirUri(value);
                    OnPropertyChanged("Definition");
                }
            }

            /// <summary>
            /// number | date | string | token | reference | composite | quantity | uri
            /// </summary>
            [FhirElement("type", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<SearchParamType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<SearchParamType> _typeElement;

            /// <summary>
            /// number | date | string | token | reference | composite | quantity | uri
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public SearchParamType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<SearchParamType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Server-specific usage
            /// </summary>
            [FhirElement("documentation", Order=70)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Server-specific usage
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            /// <summary>
            /// Types of resource (if a resource reference)
            /// </summary>
            [FhirElement("target", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<ResourceType>> TargetElement
            {
                get { if (_targetElement==null) _targetElement = new List<Code<ResourceType>>(); return _targetElement; }
                set { _targetElement = value; OnPropertyChanged("TargetElement"); }
            }

            private List<Code<ResourceType>> _targetElement;

            /// <summary>
            /// Types of resource (if a resource reference)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<ResourceType?> Target
            {
                get { return TargetElement != null ? TargetElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        TargetElement = null;
                    else
                        TargetElement = new List<Code<ResourceType>>(value.Select(elem=>new Code<ResourceType>(elem)));
                    OnPropertyChanged("Target");
                }
            }

            /// <summary>
            /// missing | exact | contains | not | text | in | not-in | below | above | type
            /// </summary>
            [FhirElement("modifier", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<SearchModifierCode>> ModifierElement
            {
                get { if (_modifierElement==null) _modifierElement = new List<Code<SearchModifierCode>>(); return _modifierElement; }
                set { _modifierElement = value; OnPropertyChanged("ModifierElement"); }
            }

            private List<Code<SearchModifierCode>> _modifierElement;

            /// <summary>
            /// missing | exact | contains | not | text | in | not-in | below | above | type
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<SearchModifierCode?> Modifier
            {
                get { return ModifierElement != null ? ModifierElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ModifierElement = null;
                    else
                        ModifierElement = new List<Code<SearchModifierCode>>(value.Select(elem=>new Code<SearchModifierCode>(elem)));
                    OnPropertyChanged("Modifier");
                }
            }

            /// <summary>
            /// Chained names supported
            /// </summary>
            [FhirElement("chain", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> ChainElement
            {
                get { if (_chainElement==null) _chainElement = new List<FhirString>(); return _chainElement; }
                set { _chainElement = value; OnPropertyChanged("ChainElement"); }
            }

            private List<FhirString> _chainElement;

            /// <summary>
            /// Chained names supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> Chain
            {
                get { return ChainElement != null ? ChainElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ChainElement = null;
                    else
                        ChainElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("Chain");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SearchParamComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DefinitionElement != null) dest.DefinitionElement = (FhirUri)DefinitionElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<SearchParamType>)TypeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (TargetElement != null) dest.TargetElement = new List<Code<ResourceType>>(TargetElement.DeepCopy());
                    if (ModifierElement != null) dest.ModifierElement = new List<Code<SearchModifierCode>>(ModifierElement.DeepCopy());
                    if (ChainElement != null) dest.ChainElement = new List<FhirString>(ChainElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SearchParamComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SearchParamComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;
                if ( !DeepComparable.Matches(TargetElement, otherT.TargetElement)) return false;
                if ( !DeepComparable.Matches(ModifierElement, otherT.ModifierElement)) return false;
                if ( !DeepComparable.Matches(ChainElement, otherT.ChainElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SearchParamComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.IsExactly(TargetElement, otherT.TargetElement)) return false;
                if (!DeepComparable.IsExactly(ModifierElement, otherT.ModifierElement)) return false;
                if (!DeepComparable.IsExactly(ChainElement, otherT.ChainElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (DefinitionElement != null) yield return DefinitionElement;
                    if (TypeElement != null) yield return TypeElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                    foreach (var elem in TargetElement) { if (elem != null) yield return elem; }
                    foreach (var elem in ModifierElement) { if (elem != null) yield return elem; }
                    foreach (var elem in ChainElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DefinitionElement != null) yield return new ElementValue("definition", DefinitionElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                    foreach (var elem in TargetElement) { if (elem != null) yield return new ElementValue("target", elem); }
                    foreach (var elem in ModifierElement) { if (elem != null) yield return new ElementValue("modifier", elem); }
                    foreach (var elem in ChainElement) { if (elem != null) yield return new ElementValue("chain", elem); }
                }
            }


        }


        [FhirType("SystemInteractionComponent")]
        [DataContract]
        public partial class SystemInteractionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SystemInteractionComponent"; } }

            /// <summary>
            /// transaction | search-system | history-system
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<SystemRestfulInteraction> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<SystemRestfulInteraction> _codeElement;

            /// <summary>
            /// transaction | search-system | history-system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public SystemRestfulInteraction? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<SystemRestfulInteraction>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Anything special about operation behavior
            /// </summary>
            [FhirElement("documentation", Order=50)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Anything special about operation behavior
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SystemInteractionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code<SystemRestfulInteraction>)CodeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SystemInteractionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SystemInteractionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SystemInteractionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                }
            }


        }


        [FhirType("OperationComponent")]
        [DataContract]
        public partial class OperationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OperationComponent"; } }

            /// <summary>
            /// Name by which the operation/query is invoked
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
            /// Name by which the operation/query is invoked
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
            /// The defined operation/query
            /// </summary>
            [FhirElement("definition", Order=50)]
            [References("OperationDefinition")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Definition
            {
                get { return _definition; }
                set { _definition = value; OnPropertyChanged("Definition"); }
            }

            private ResourceReference _definition;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OperationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Definition != null) dest.Definition = (ResourceReference)Definition.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OperationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(Definition, otherT.Definition)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (Definition != null) yield return Definition;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (Definition != null) yield return new ElementValue("definition", Definition);
                }
            }


        }


        [FhirType("MessagingComponent")]
        [DataContract]
        public partial class MessagingComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MessagingComponent"; } }

            /// <summary>
            /// A messaging service end-point
            /// </summary>
            [FhirElement("endpoint", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<EndpointComponent> Endpoint
            {
                get { if (_endpoint==null) _endpoint = new List<EndpointComponent>(); return _endpoint; }
                set { _endpoint = value; OnPropertyChanged("Endpoint"); }
            }

            private List<EndpointComponent> _endpoint;

            /// <summary>
            /// Reliable Message Cache Length (min)
            /// </summary>
            [FhirElement("reliableCache", Order=50)]
            [DataMember]
            public UnsignedInt ReliableCacheElement
            {
                get { return _reliableCacheElement; }
                set { _reliableCacheElement = value; OnPropertyChanged("ReliableCacheElement"); }
            }

            private UnsignedInt _reliableCacheElement;

            /// <summary>
            /// Reliable Message Cache Length (min)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? ReliableCache
            {
                get { return ReliableCacheElement != null ? ReliableCacheElement.Value : null; }
                set
                {
                    if (value == null)
                        ReliableCacheElement = null;
                    else
                        ReliableCacheElement = new UnsignedInt(value);
                    OnPropertyChanged("ReliableCache");
                }
            }

            /// <summary>
            /// Messaging interface behavior details
            /// </summary>
            [FhirElement("documentation", Order=60)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Messaging interface behavior details
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            /// <summary>
            /// Declare support for this event
            /// </summary>
            [FhirElement("event", Order=70)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<EventComponent> Event
            {
                get { if (_event==null) _event = new List<EventComponent>(); return _event; }
                set { _event = value; OnPropertyChanged("Event"); }
            }

            private List<EventComponent> _event;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MessagingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Endpoint != null) dest.Endpoint = new List<EndpointComponent>(Endpoint.DeepCopy());
                    if (ReliableCacheElement != null) dest.ReliableCacheElement = (UnsignedInt)ReliableCacheElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (Event != null) dest.Event = new List<EventComponent>(Event.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MessagingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MessagingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;
                if (!DeepComparable.Matches(ReliableCacheElement, otherT.ReliableCacheElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;
                if ( !DeepComparable.Matches(Event, otherT.Event)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MessagingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;
                if (!DeepComparable.IsExactly(ReliableCacheElement, otherT.ReliableCacheElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.IsExactly(Event, otherT.Event)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
                    if (ReliableCacheElement != null) yield return ReliableCacheElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                    foreach (var elem in Event) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
                    if (ReliableCacheElement != null) yield return new ElementValue("reliableCache", ReliableCacheElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                    foreach (var elem in Event) { if (elem != null) yield return new ElementValue("event", elem); }
                }
            }


        }


        [FhirType("EndpointComponent")]
        [DataContract]
        public partial class EndpointComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EndpointComponent"; } }

            /// <summary>
            /// http | ftp | mllp +
            /// </summary>
            [FhirElement("protocol", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Protocol
            {
                get { return _protocol; }
                set { _protocol = value; OnPropertyChanged("Protocol"); }
            }

            private Coding _protocol;

            /// <summary>
            /// Address of end-point
            /// </summary>
            [FhirElement("address", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri AddressElement
            {
                get { return _addressElement; }
                set { _addressElement = value; OnPropertyChanged("AddressElement"); }
            }

            private FhirUri _addressElement;

            /// <summary>
            /// Address of end-point
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Address
            {
                get { return AddressElement != null ? AddressElement.Value : null; }
                set
                {
                    if (value == null)
                        AddressElement = null;
                    else
                        AddressElement = new FhirUri(value);
                    OnPropertyChanged("Address");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EndpointComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Protocol != null) dest.Protocol = (Coding)Protocol.DeepCopy();
                    if (AddressElement != null) dest.AddressElement = (FhirUri)AddressElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EndpointComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EndpointComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Protocol, otherT.Protocol)) return false;
                if (!DeepComparable.Matches(AddressElement, otherT.AddressElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EndpointComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Protocol, otherT.Protocol)) return false;
                if (!DeepComparable.IsExactly(AddressElement, otherT.AddressElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Protocol != null) yield return Protocol;
                    if (AddressElement != null) yield return AddressElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Protocol != null) yield return new ElementValue("protocol", Protocol);
                    if (AddressElement != null) yield return new ElementValue("address", AddressElement);
                }
            }


        }


        [FhirType("EventComponent")]
        [DataContract]
        public partial class EventComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EventComponent"; } }

            /// <summary>
            /// Event type
            /// </summary>
            [FhirElement("code", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private Coding _code;

            /// <summary>
            /// Consequence | Currency | Notification
            /// </summary>
            [FhirElement("category", Order=50)]
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
            /// sender | receiver
            /// </summary>
            [FhirElement("mode", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ConformanceEventMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<ConformanceEventMode> _modeElement;

            /// <summary>
            /// sender | receiver
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConformanceEventMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<ConformanceEventMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// Resource that's focus of message
            /// </summary>
            [FhirElement("focus", Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ResourceType> FocusElement
            {
                get { return _focusElement; }
                set { _focusElement = value; OnPropertyChanged("FocusElement"); }
            }

            private Code<ResourceType> _focusElement;

            /// <summary>
            /// Resource that's focus of message
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ResourceType? Focus
            {
                get { return FocusElement != null ? FocusElement.Value : null; }
                set
                {
                    if (value == null)
                        FocusElement = null;
                    else
                        FocusElement = new Code<ResourceType>(value);
                    OnPropertyChanged("Focus");
                }
            }

            /// <summary>
            /// Profile that describes the request
            /// </summary>
            [FhirElement("request", Order=80)]
            [References("StructureDefinition")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Request
            {
                get { return _request; }
                set { _request = value; OnPropertyChanged("Request"); }
            }

            private ResourceReference _request;

            /// <summary>
            /// Profile that describes the response
            /// </summary>
            [FhirElement("response", Order=90)]
            [References("StructureDefinition")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Response
            {
                get { return _response; }
                set { _response = value; OnPropertyChanged("Response"); }
            }

            private ResourceReference _response;

            /// <summary>
            /// Endpoint-specific event documentation
            /// </summary>
            [FhirElement("documentation", Order=100)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Endpoint-specific event documentation
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EventComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (Coding)Code.DeepCopy();
                    if (CategoryElement != null) dest.CategoryElement = (Code<MessageSignificanceCategory>)CategoryElement.DeepCopy();
                    if (ModeElement != null) dest.ModeElement = (Code<ConformanceEventMode>)ModeElement.DeepCopy();
                    if (FocusElement != null) dest.FocusElement = (Code<ResourceType>)FocusElement.DeepCopy();
                    if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                    if (Response != null) dest.Response = (ResourceReference)Response.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EventComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EventComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(CategoryElement, otherT.CategoryElement)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(FocusElement, otherT.FocusElement)) return false;
                if (!DeepComparable.Matches(Request, otherT.Request)) return false;
                if (!DeepComparable.Matches(Response, otherT.Response)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EventComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(CategoryElement, otherT.CategoryElement)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(FocusElement, otherT.FocusElement)) return false;
                if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
                if (!DeepComparable.IsExactly(Response, otherT.Response)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (CategoryElement != null) yield return CategoryElement;
                    if (ModeElement != null) yield return ModeElement;
                    if (FocusElement != null) yield return FocusElement;
                    if (Request != null) yield return Request;
                    if (Response != null) yield return Response;
                    if (DocumentationElement != null) yield return DocumentationElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (CategoryElement != null) yield return new ElementValue("category", CategoryElement);
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                    if (FocusElement != null) yield return new ElementValue("focus", FocusElement);
                    if (Request != null) yield return new ElementValue("request", Request);
                    if (Response != null) yield return new ElementValue("response", Response);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                }
            }


        }


        [FhirType("DocumentComponent")]
        [DataContract]
        public partial class DocumentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DocumentComponent"; } }

            /// <summary>
            /// producer | consumer
            /// </summary>
            [FhirElement("mode", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<DocumentMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<DocumentMode> _modeElement;

            /// <summary>
            /// producer | consumer
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DocumentMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<DocumentMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// Description of document support
            /// </summary>
            [FhirElement("documentation", Order=50)]
            [DataMember]
            public FhirString DocumentationElement
            {
                get { return _documentationElement; }
                set { _documentationElement = value; OnPropertyChanged("DocumentationElement"); }
            }

            private FhirString _documentationElement;

            /// <summary>
            /// Description of document support
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Documentation
            {
                get { return DocumentationElement != null ? DocumentationElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentationElement = null;
                    else
                        DocumentationElement = new FhirString(value);
                    OnPropertyChanged("Documentation");
                }
            }

            /// <summary>
            /// Constraint on a resource used in the document
            /// </summary>
            [FhirElement("profile", Order=60)]
            [References("StructureDefinition")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Profile
            {
                get { return _profile; }
                set { _profile = value; OnPropertyChanged("Profile"); }
            }

            private ResourceReference _profile;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DocumentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ModeElement != null) dest.ModeElement = (Code<DocumentMode>)ModeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (Profile != null) dest.Profile = (ResourceReference)Profile.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DocumentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DocumentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.Matches(Profile, otherT.Profile)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DocumentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ModeElement != null) yield return ModeElement;
                    if (DocumentationElement != null) yield return DocumentationElement;
                    if (Profile != null) yield return Profile;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                    if (DocumentationElement != null) yield return new ElementValue("documentation", DocumentationElement);
                    if (Profile != null) yield return new ElementValue("profile", Profile);
                }
            }


        }


        /// <summary>
        /// Logical uri to reference this statement
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
        /// Logical uri to reference this statement
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
        /// Logical id for this version of the statement
        /// </summary>
        [FhirElement("version", InSummary=true, Order=100)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Logical id for this version of the statement
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
        /// Informal name for this conformance statement
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Informal name for this conformance statement
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
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [DataMember]
        public Code<ConformanceResourceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ConformanceResourceStatus> _statusElement;

        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConformanceResourceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ConformanceResourceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=130)]
        [DataMember]
        public FhirBoolean ExperimentalElement
        {
            get { return _experimentalElement; }
            set { _experimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }

        private FhirBoolean _experimentalElement;

        /// <summary>
        /// If for testing purposes, not real usage
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
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=140)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (Organization or individual)
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
        /// Contact details of the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact==null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// Publication Date(/time)
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
        /// Publication Date(/time)
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
        /// Human description of the conformance statement
        /// </summary>
        [FhirElement("description", InSummary=true, Order=170)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Human description of the conformance statement
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
        /// Why is this needed?
        /// </summary>
        [FhirElement("requirements", Order=180)]
        [DataMember]
        public FhirString RequirementsElement
        {
            get { return _requirementsElement; }
            set { _requirementsElement = value; OnPropertyChanged("RequirementsElement"); }
        }

        private FhirString _requirementsElement;

        /// <summary>
        /// Why is this needed?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Requirements
        {
            get { return RequirementsElement != null ? RequirementsElement.Value : null; }
            set
            {
                if (value == null)
                    RequirementsElement = null;
                else
                    RequirementsElement = new FhirString(value);
                OnPropertyChanged("Requirements");
            }
        }

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=190)]
        [DataMember]
        public FhirString CopyrightElement
        {
            get { return _copyrightElement; }
            set { _copyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }

        private FhirString _copyrightElement;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if (value == null)
                    CopyrightElement = null;
                else
                    CopyrightElement = new FhirString(value);
                OnPropertyChanged("Copyright");
            }
        }

        /// <summary>
        /// instance | capability | requirements
        /// </summary>
        [FhirElement("kind", InSummary=true, Order=200)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ConformanceStatementKind> KindElement
        {
            get { return _kindElement; }
            set { _kindElement = value; OnPropertyChanged("KindElement"); }
        }

        private Code<ConformanceStatementKind> _kindElement;

        /// <summary>
        /// instance | capability | requirements
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConformanceStatementKind? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (value == null)
                    KindElement = null;
                else
                    KindElement = new Code<ConformanceStatementKind>(value);
                OnPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// Software that is covered by this conformance statement
        /// </summary>
        [FhirElement("software", InSummary=true, Order=210)]
        [DataMember]
        public SoftwareComponent Software
        {
            get { return _software; }
            set { _software = value; OnPropertyChanged("Software"); }
        }

        private SoftwareComponent _software;

        /// <summary>
        /// If this describes a specific instance
        /// </summary>
        [FhirElement("implementation", InSummary=true, Order=220)]
        [DataMember]
        public ImplementationComponent Implementation
        {
            get { return _implementation; }
            set { _implementation = value; OnPropertyChanged("Implementation"); }
        }

        private ImplementationComponent _implementation;

        /// <summary>
        /// FHIR Version the system uses
        /// </summary>
        [FhirElement("fhirVersion", InSummary=true, Order=230)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Id FhirVersionElement
        {
            get { return _fhirVersionElement; }
            set { _fhirVersionElement = value; OnPropertyChanged("FhirVersionElement"); }
        }

        private Id _fhirVersionElement;

        /// <summary>
        /// FHIR Version the system uses
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string FhirVersion
        {
            get { return FhirVersionElement != null ? FhirVersionElement.Value : null; }
            set
            {
                if (value == null)
                    FhirVersionElement = null;
                else
                    FhirVersionElement = new Id(value);
                OnPropertyChanged("FhirVersion");
            }
        }

        /// <summary>
        /// no | extensions | elements | both
        /// </summary>
        [FhirElement("acceptUnknown", InSummary=true, Order=240)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<UnknownContentCode> AcceptUnknownElement
        {
            get { return _acceptUnknownElement; }
            set { _acceptUnknownElement = value; OnPropertyChanged("AcceptUnknownElement"); }
        }

        private Code<UnknownContentCode> _acceptUnknownElement;

        /// <summary>
        /// no | extensions | elements | both
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public UnknownContentCode? AcceptUnknown
        {
            get { return AcceptUnknownElement != null ? AcceptUnknownElement.Value : null; }
            set
            {
                if (value == null)
                    AcceptUnknownElement = null;
                else
                    AcceptUnknownElement = new Code<UnknownContentCode>(value);
                OnPropertyChanged("AcceptUnknown");
            }
        }

        /// <summary>
        /// formats supported (xml | json | mime type)
        /// </summary>
        [FhirElement("format", InSummary=true, Order=250)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Code> FormatElement
        {
            get { if (_formatElement==null) _formatElement = new List<Code>(); return _formatElement; }
            set { _formatElement = value; OnPropertyChanged("FormatElement"); }
        }

        private List<Code> _formatElement;

        /// <summary>
        /// formats supported (xml | json | mime type)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Format
        {
            get { return FormatElement != null ? FormatElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    FormatElement = null;
                else
                    FormatElement = new List<Code>(value.Select(elem=>new Code(elem)));
                OnPropertyChanged("Format");
            }
        }

        /// <summary>
        /// Profiles for use cases supported
        /// </summary>
        [FhirElement("profile", Order=260)]
        [References("StructureDefinition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Profile
        {
            get { if (_profile==null) _profile = new List<ResourceReference>(); return _profile; }
            set { _profile = value; OnPropertyChanged("Profile"); }
        }

        private List<ResourceReference> _profile;

        /// <summary>
        /// If the endpoint is a RESTful one
        /// </summary>
        [FhirElement("rest", InSummary=true, Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RestComponent> Rest
        {
            get { if (_rest==null) _rest = new List<RestComponent>(); return _rest; }
            set { _rest = value; OnPropertyChanged("Rest"); }
        }

        private List<RestComponent> _rest;

        /// <summary>
        /// If messaging is supported
        /// </summary>
        [FhirElement("messaging", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MessagingComponent> Messaging
        {
            get { if (_messaging==null) _messaging = new List<MessagingComponent>(); return _messaging; }
            set { _messaging = value; OnPropertyChanged("Messaging"); }
        }

        private List<MessagingComponent> _messaging;

        /// <summary>
        /// Document definition
        /// </summary>
        [FhirElement("document", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DocumentComponent> Document
        {
            get { if (_document==null) _document = new List<DocumentComponent>(); return _document; }
            set { _document = value; OnPropertyChanged("Document"); }
        }

        private List<DocumentComponent> _document;


        public static ElementDefinition.ConstraintComponent Conformance_CNF_14 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(software.empty() and implementation.empty()) or kind != 'requirements'",
            Key = "cnf-14",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Conformance statements of kind 'requirements' do not have software or implementation elements",
            Xpath = "not(exists(f:software) or exists(f:implementation)) or (f:kind/@value != 'requirements')"
        };

        public static ElementDefinition.ConstraintComponent Conformance_CNF_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "rest or messaging or document",
            Key = "cnf-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A Conformance statement SHALL have at least one of REST, messaging or document",
            Xpath = "exists(f:rest) or exists(f:messaging) or exists(f:document)"
        };

        public static ElementDefinition.ConstraintComponent Conformance_CNF_15 = new ElementDefinition.ConstraintComponent
        {
            Expression = "implementation.empty() or kind != 'capability'",
            Key = "cnf-15",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Conformance statements of kind 'software' do not have implementation elements",
            Xpath = "not(exists(f:implementation)) or (f:kind/@value != 'capability')"
        };

        public static ElementDefinition.ConstraintComponent Conformance_CNF_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "description or software or implementation",
            Key = "cnf-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A Conformance statement SHALL have at least one of description, software, or implementation",
            Xpath = "count(f:software | f:implementation | f:description) > 0"
        };

        public static ElementDefinition.ConstraintComponent Conformance_CNF_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "messaging.endpoint.empty() or kind = 'instance'",
            Key = "cnf-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Messaging end-point is required (and is only permitted) when statement is for an implementation",
            Xpath = "not(exists(f:messaging/f:endpoint)) or f:kind/@value = 'instance'"
        };

        public static ElementDefinition.ConstraintComponent Conformance_CNF_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "document.select(profile|mode).isDistinct()",
            Key = "cnf-7",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "The set of documents must be unique by the combination of profile & mode",
            Xpath = "count(f:document[f:mode/@value='producer'])=count(distinct-values(f:document[f:mode/@value='producer']/f:profile/f:reference/@value)) and count(f:document[f:mode/@value='consumer'])=count(distinct-values(f:document[f:mode/@value='consumer']/f:profile/f:reference/@value))"
        };

        public static ElementDefinition.ConstraintComponent Conformance_CNF_8 = new ElementDefinition.ConstraintComponent
        {
            Expression = "rest.select(mode).isDistinct()",
            Key = "cnf-8",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "There can only be one REST declaration per mode",
            Xpath = "count(f:rest)=count(distinct-values(f:rest/f:mode/@value))"
        };

        public static ElementDefinition.ConstraintComponent Conformance_CNF_9 = new ElementDefinition.ConstraintComponent
        {
            Expression = "rest.all(resource.select(type).isDistinct())",
            Key = "cnf-9",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A given resource can only be described once per RESTful mode",
            Xpath = "count(f:resource)=count(distinct-values(f:resource/f:type/@value))"
        };

        public static ElementDefinition.ConstraintComponent Conformance_CNF_12 = new ElementDefinition.ConstraintComponent
        {
            Expression = "rest.resource.all(searchParam.select(name).isDistinct())",
            Key = "cnf-12",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Search parameter names must be unique in the context of a resource",
            Xpath = "count(f:searchParam)=count(distinct-values(f:searchParam/f:name/@value))"
        };

        public static ElementDefinition.ConstraintComponent Conformance_CNF_13 = new ElementDefinition.ConstraintComponent
        {
            Expression = "rest.resource.searchParam.all(chain.empty() or type = 'reference')",
            Key = "cnf-13",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Search parameters can only have chain names when the search parameter type is 'reference'",
            Xpath = "not(exists(f:chain)) or (f:type/@value = 'reference')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Conformance_CNF_14);
            InvariantConstraints.Add(Conformance_CNF_1);
            InvariantConstraints.Add(Conformance_CNF_15);
            InvariantConstraints.Add(Conformance_CNF_2);
            InvariantConstraints.Add(Conformance_CNF_3);
            InvariantConstraints.Add(Conformance_CNF_7);
            InvariantConstraints.Add(Conformance_CNF_8);
            InvariantConstraints.Add(Conformance_CNF_9);
            InvariantConstraints.Add(Conformance_CNF_12);
            InvariantConstraints.Add(Conformance_CNF_13);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Conformance;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ConformanceResourceStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (RequirementsElement != null) dest.RequirementsElement = (FhirString)RequirementsElement.DeepCopy();
                if (CopyrightElement != null) dest.CopyrightElement = (FhirString)CopyrightElement.DeepCopy();
                if (KindElement != null) dest.KindElement = (Code<ConformanceStatementKind>)KindElement.DeepCopy();
                if (Software != null) dest.Software = (SoftwareComponent)Software.DeepCopy();
                if (Implementation != null) dest.Implementation = (ImplementationComponent)Implementation.DeepCopy();
                if (FhirVersionElement != null) dest.FhirVersionElement = (Id)FhirVersionElement.DeepCopy();
                if (AcceptUnknownElement != null) dest.AcceptUnknownElement = (Code<UnknownContentCode>)AcceptUnknownElement.DeepCopy();
                if (FormatElement != null) dest.FormatElement = new List<Code>(FormatElement.DeepCopy());
                if (Profile != null) dest.Profile = new List<ResourceReference>(Profile.DeepCopy());
                if (Rest != null) dest.Rest = new List<RestComponent>(Rest.DeepCopy());
                if (Messaging != null) dest.Messaging = new List<MessagingComponent>(Messaging.DeepCopy());
                if (Document != null) dest.Document = new List<DocumentComponent>(Document.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Conformance());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Conformance;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.Matches(Software, otherT.Software)) return false;
            if (!DeepComparable.Matches(Implementation, otherT.Implementation)) return false;
            if (!DeepComparable.Matches(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if (!DeepComparable.Matches(AcceptUnknownElement, otherT.AcceptUnknownElement)) return false;
            if ( !DeepComparable.Matches(FormatElement, otherT.FormatElement)) return false;
            if ( !DeepComparable.Matches(Profile, otherT.Profile)) return false;
            if ( !DeepComparable.Matches(Rest, otherT.Rest)) return false;
            if ( !DeepComparable.Matches(Messaging, otherT.Messaging)) return false;
            if ( !DeepComparable.Matches(Document, otherT.Document)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Conformance;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(Software, otherT.Software)) return false;
            if (!DeepComparable.IsExactly(Implementation, otherT.Implementation)) return false;
            if (!DeepComparable.IsExactly(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if (!DeepComparable.IsExactly(AcceptUnknownElement, otherT.AcceptUnknownElement)) return false;
            if (!DeepComparable.IsExactly(FormatElement, otherT.FormatElement)) return false;
            if (!DeepComparable.IsExactly(Profile, otherT.Profile)) return false;
            if (!DeepComparable.IsExactly(Rest, otherT.Rest)) return false;
            if (!DeepComparable.IsExactly(Messaging, otherT.Messaging)) return false;
            if (!DeepComparable.IsExactly(Document, otherT.Document)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DateElement != null) yield return DateElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                if (RequirementsElement != null) yield return RequirementsElement;
                if (CopyrightElement != null) yield return CopyrightElement;
                if (KindElement != null) yield return KindElement;
                if (Software != null) yield return Software;
                if (Implementation != null) yield return Implementation;
                if (FhirVersionElement != null) yield return FhirVersionElement;
                if (AcceptUnknownElement != null) yield return AcceptUnknownElement;
                foreach (var elem in FormatElement) { if (elem != null) yield return elem; }
                foreach (var elem in Profile) { if (elem != null) yield return elem; }
                foreach (var elem in Rest) { if (elem != null) yield return elem; }
                foreach (var elem in Messaging) { if (elem != null) yield return elem; }
                foreach (var elem in Document) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (RequirementsElement != null) yield return new ElementValue("requirements", RequirementsElement);
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                if (KindElement != null) yield return new ElementValue("kind", KindElement);
                if (Software != null) yield return new ElementValue("software", Software);
                if (Implementation != null) yield return new ElementValue("implementation", Implementation);
                if (FhirVersionElement != null) yield return new ElementValue("fhirVersion", FhirVersionElement);
                if (AcceptUnknownElement != null) yield return new ElementValue("acceptUnknown", AcceptUnknownElement);
                foreach (var elem in FormatElement) { if (elem != null) yield return new ElementValue("format", elem); }
                foreach (var elem in Profile) { if (elem != null) yield return new ElementValue("profile", elem); }
                foreach (var elem in Rest) { if (elem != null) yield return new ElementValue("rest", elem); }
                foreach (var elem in Messaging) { if (elem != null) yield return new ElementValue("messaging", elem); }
                foreach (var elem in Document) { if (elem != null) yield return new ElementValue("document", elem); }
            }
        }

    }

}
