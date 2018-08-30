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
    /// A statement of system capabilities
    /// </summary>
    [FhirType("CapabilityStatement", IsResource=true)]
    [DataContract]
    public partial class CapabilityStatement : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.CapabilityStatement; } }
        [NotMapped]
        public override string TypeName { get { return "CapabilityStatement"; } }

        /// <summary>
        /// How a capability statement is intended to be used.
        /// (url: http://hl7.org/fhir/ValueSet/capability-statement-kind)
        /// </summary>
        [FhirEnumeration("CapabilityStatementKind")]
        public enum CapabilityStatementKind
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/capability-statement-kind)
            /// </summary>
            [EnumLiteral("instance", "http://hl7.org/fhir/capability-statement-kind"), Description("Instance")]
            Instance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/capability-statement-kind)
            /// </summary>
            [EnumLiteral("capability", "http://hl7.org/fhir/capability-statement-kind"), Description("Capability")]
            Capability,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/capability-statement-kind)
            /// </summary>
            [EnumLiteral("requirements", "http://hl7.org/fhir/capability-statement-kind"), Description("Requirements")]
            Requirements,
        }

        /// <summary>
        /// The mode of a RESTful capability statement.
        /// (url: http://hl7.org/fhir/ValueSet/restful-capability-mode)
        /// </summary>
        [FhirEnumeration("RestfulCapabilityMode")]
        public enum RestfulCapabilityMode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-capability-mode)
            /// </summary>
            [EnumLiteral("client", "http://hl7.org/fhir/restful-capability-mode"), Description("Client")]
            Client,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/restful-capability-mode)
            /// </summary>
            [EnumLiteral("server", "http://hl7.org/fhir/restful-capability-mode"), Description("Server")]
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
            [EnumLiteral("patch", "http://hl7.org/fhir/restful-interaction"), Description("patch")]
            Patch,
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
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/versioning-policy)
            /// </summary>
            [EnumLiteral("no-version", "http://hl7.org/fhir/versioning-policy"), Description("No VersionId Support")]
            NoVersion,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/versioning-policy)
            /// </summary>
            [EnumLiteral("versioned", "http://hl7.org/fhir/versioning-policy"), Description("Versioned")]
            Versioned,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/versioning-policy)
            /// </summary>
            [EnumLiteral("versioned-update", "http://hl7.org/fhir/versioning-policy"), Description("VersionId tracked fully")]
            VersionedUpdate,
        }

        /// <summary>
        /// A code that indicates how the server supports conditional read.
        /// (url: http://hl7.org/fhir/ValueSet/conditional-read-status)
        /// </summary>
        [FhirEnumeration("ConditionalReadStatus")]
        public enum ConditionalReadStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conditional-read-status)
            /// </summary>
            [EnumLiteral("not-supported", "http://hl7.org/fhir/conditional-read-status"), Description("Not Supported")]
            NotSupported,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conditional-read-status)
            /// </summary>
            [EnumLiteral("modified-since", "http://hl7.org/fhir/conditional-read-status"), Description("If-Modified-Since")]
            ModifiedSince,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conditional-read-status)
            /// </summary>
            [EnumLiteral("not-match", "http://hl7.org/fhir/conditional-read-status"), Description("If-None-Match")]
            NotMatch,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conditional-read-status)
            /// </summary>
            [EnumLiteral("full-support", "http://hl7.org/fhir/conditional-read-status"), Description("Full Support")]
            FullSupport,
        }

        /// <summary>
        /// A code that indicates how the server supports conditional delete.
        /// (url: http://hl7.org/fhir/ValueSet/conditional-delete-status)
        /// </summary>
        [FhirEnumeration("ConditionalDeleteStatus")]
        public enum ConditionalDeleteStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conditional-delete-status)
            /// </summary>
            [EnumLiteral("not-supported", "http://hl7.org/fhir/conditional-delete-status"), Description("Not Supported")]
            NotSupported,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conditional-delete-status)
            /// </summary>
            [EnumLiteral("single", "http://hl7.org/fhir/conditional-delete-status"), Description("Single Deletes Supported")]
            Single,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conditional-delete-status)
            /// </summary>
            [EnumLiteral("multiple", "http://hl7.org/fhir/conditional-delete-status"), Description("Multiple Deletes Supported")]
            Multiple,
        }

        /// <summary>
        /// A set of flags that defines how references are supported.
        /// (url: http://hl7.org/fhir/ValueSet/reference-handling-policy)
        /// </summary>
        [FhirEnumeration("ReferenceHandlingPolicy")]
        public enum ReferenceHandlingPolicy
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reference-handling-policy)
            /// </summary>
            [EnumLiteral("literal", "http://hl7.org/fhir/reference-handling-policy"), Description("Literal References")]
            Literal,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reference-handling-policy)
            /// </summary>
            [EnumLiteral("logical", "http://hl7.org/fhir/reference-handling-policy"), Description("Logical References")]
            Logical,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reference-handling-policy)
            /// </summary>
            [EnumLiteral("resolves", "http://hl7.org/fhir/reference-handling-policy"), Description("Resolves References")]
            Resolves,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reference-handling-policy)
            /// </summary>
            [EnumLiteral("enforced", "http://hl7.org/fhir/reference-handling-policy"), Description("Reference Integrity Enforced")]
            Enforced,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/reference-handling-policy)
            /// </summary>
            [EnumLiteral("local", "http://hl7.org/fhir/reference-handling-policy"), Description("Local References Only")]
            Local,
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
            [EnumLiteral("batch", "http://hl7.org/fhir/restful-interaction"), Description("batch")]
            Batch,
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
        /// The mode of a message capability statement.
        /// (url: http://hl7.org/fhir/ValueSet/event-capability-mode)
        /// </summary>
        [FhirEnumeration("EventCapabilityMode")]
        public enum EventCapabilityMode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-capability-mode)
            /// </summary>
            [EnumLiteral("sender", "http://hl7.org/fhir/event-capability-mode"), Description("Sender")]
            Sender,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-capability-mode)
            /// </summary>
            [EnumLiteral("receiver", "http://hl7.org/fhir/event-capability-mode"), Description("Receiver")]
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
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/document-mode)
            /// </summary>
            [EnumLiteral("producer", "http://hl7.org/fhir/document-mode"), Description("Producer")]
            Producer,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/document-mode)
            /// </summary>
            [EnumLiteral("consumer", "http://hl7.org/fhir/document-mode"), Description("Consumer")]
            Consumer,
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
            /// Date this version was released
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
            /// Date this version was released
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
            public FhirUrl UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private FhirUrl _urlElement;

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
                        UrlElement = new FhirUrl(value);
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
                    if (UrlElement != null) dest.UrlElement = (FhirUrl)UrlElement.DeepCopy();
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
            public Code<RestfulCapabilityMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<RestfulCapabilityMode> _modeElement;

            /// <summary>
            /// client | server
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public RestfulCapabilityMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<RestfulCapabilityMode>(value);
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
            [FhirElement("security", InSummary=true, Order=60)]
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
            [Cardinality(Min=0,Max=-1)]
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
            /// Search parameters for searching all resources
            /// </summary>
            [FhirElement("searchParam", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SearchParamComponent> SearchParam
            {
                get { if (_searchParam==null) _searchParam = new List<SearchParamComponent>(); return _searchParam; }
                set { _searchParam = value; OnPropertyChanged("SearchParam"); }
            }

            private List<SearchParamComponent> _searchParam;

            /// <summary>
            /// Definition of a system level operation
            /// </summary>
            [FhirElement("operation", InSummary=true, Order=100)]
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
            [FhirElement("compartment", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Canonical> CompartmentElement
            {
                get { if (_compartmentElement==null) _compartmentElement = new List<Canonical>(); return _compartmentElement; }
                set { _compartmentElement = value; OnPropertyChanged("CompartmentElement"); }
            }

            private List<Canonical> _compartmentElement;

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
                        CompartmentElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                    OnPropertyChanged("Compartment");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ModeElement != null) dest.ModeElement = (Code<RestfulCapabilityMode>)ModeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (Security != null) dest.Security = (SecurityComponent)Security.DeepCopy();
                    if (Resource != null) dest.Resource = new List<ResourceComponent>(Resource.DeepCopy());
                    if (Interaction != null) dest.Interaction = new List<SystemInteractionComponent>(Interaction.DeepCopy());
                    if (SearchParam != null) dest.SearchParam = new List<SearchParamComponent>(SearchParam.DeepCopy());
                    if (Operation != null) dest.Operation = new List<OperationComponent>(Operation.DeepCopy());
                    if (CompartmentElement != null) dest.CompartmentElement = new List<Canonical>(CompartmentElement.DeepCopy());
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
            [FhirElement("cors", InSummary=true, Order=40)]
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
            [FhirElement("service", InSummary=true, Order=50)]
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SecurityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CorsElement != null) dest.CorsElement = (FhirBoolean)CorsElement.DeepCopy();
                    if (Service != null) dest.Service = new List<CodeableConcept>(Service.DeepCopy());
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
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
            [FhirElement("profile", InSummary=true, Order=50)]
            [DataMember]
            public Canonical ProfileElement
            {
                get { return _profileElement; }
                set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
            }

            private Canonical _profileElement;

            /// <summary>
            /// Base System profile for all uses of resource
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Profile
            {
                get { return ProfileElement != null ? ProfileElement.Value : null; }
                set
                {
                    if (value == null)
                        ProfileElement = null;
                    else
                        ProfileElement = new Canonical(value);
                    OnPropertyChanged("Profile");
                }
            }

            /// <summary>
            /// Profiles for use cases supported
            /// </summary>
            [FhirElement("supportedProfile", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Canonical> SupportedProfileElement
            {
                get { if (_supportedProfileElement==null) _supportedProfileElement = new List<Canonical>(); return _supportedProfileElement; }
                set { _supportedProfileElement = value; OnPropertyChanged("SupportedProfileElement"); }
            }

            private List<Canonical> _supportedProfileElement;

            /// <summary>
            /// Profiles for use cases supported
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> SupportedProfile
            {
                get { return SupportedProfileElement != null ? SupportedProfileElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SupportedProfileElement = null;
                    else
                        SupportedProfileElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                    OnPropertyChanged("SupportedProfile");
                }
            }

            /// <summary>
            /// Additional information about the use of the resource type
            /// </summary>
            [FhirElement("documentation", Order=70)]
            [DataMember]
            public Markdown Documentation
            {
                get { return _documentation; }
                set { _documentation = value; OnPropertyChanged("Documentation"); }
            }

            private Markdown _documentation;

            /// <summary>
            /// What operations are supported?
            /// </summary>
            [FhirElement("interaction", Order=80)]
            [Cardinality(Min=0,Max=-1)]
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
            [FhirElement("versioning", Order=90)]
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
            [FhirElement("readHistory", Order=100)]
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
            [FhirElement("updateCreate", Order=110)]
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
            [FhirElement("conditionalCreate", Order=120)]
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
            /// not-supported | modified-since | not-match | full-support
            /// </summary>
            [FhirElement("conditionalRead", Order=130)]
            [DataMember]
            public Code<ConditionalReadStatus> ConditionalReadElement
            {
                get { return _conditionalReadElement; }
                set { _conditionalReadElement = value; OnPropertyChanged("ConditionalReadElement"); }
            }

            private Code<ConditionalReadStatus> _conditionalReadElement;

            /// <summary>
            /// not-supported | modified-since | not-match | full-support
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConditionalReadStatus? ConditionalRead
            {
                get { return ConditionalReadElement != null ? ConditionalReadElement.Value : null; }
                set
                {
                    if (value == null)
                        ConditionalReadElement = null;
                    else
                        ConditionalReadElement = new Code<ConditionalReadStatus>(value);
                    OnPropertyChanged("ConditionalRead");
                }
            }

            /// <summary>
            /// If allows/uses conditional update
            /// </summary>
            [FhirElement("conditionalUpdate", Order=140)]
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
            [FhirElement("conditionalDelete", Order=150)]
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
            /// literal | logical | resolves | enforced | local
            /// </summary>
            [FhirElement("referencePolicy", Order=160)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<ReferenceHandlingPolicy>> ReferencePolicyElement
            {
                get { if (_referencePolicyElement==null) _referencePolicyElement = new List<Code<ReferenceHandlingPolicy>>(); return _referencePolicyElement; }
                set { _referencePolicyElement = value; OnPropertyChanged("ReferencePolicyElement"); }
            }

            private List<Code<ReferenceHandlingPolicy>> _referencePolicyElement;

            /// <summary>
            /// literal | logical | resolves | enforced | local
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<ReferenceHandlingPolicy?> ReferencePolicy
            {
                get { return ReferencePolicyElement != null ? ReferencePolicyElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ReferencePolicyElement = null;
                    else
                        ReferencePolicyElement = new List<Code<ReferenceHandlingPolicy>>(value.Select(elem=>new Code<ReferenceHandlingPolicy>(elem)));
                    OnPropertyChanged("ReferencePolicy");
                }
            }

            /// <summary>
            /// _include values supported by the server
            /// </summary>
            [FhirElement("searchInclude", Order=170)]
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
            [FhirElement("searchRevInclude", Order=180)]
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
            /// Search parameters supported by implementation
            /// </summary>
            [FhirElement("searchParam", Order=190)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SearchParamComponent> SearchParam
            {
                get { if (_searchParam==null) _searchParam = new List<SearchParamComponent>(); return _searchParam; }
                set { _searchParam = value; OnPropertyChanged("SearchParam"); }
            }

            private List<SearchParamComponent> _searchParam;

            /// <summary>
            /// Definition of a resource operation
            /// </summary>
            [FhirElement("operation", InSummary=true, Order=200)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<OperationComponent> Operation
            {
                get { if (_operation==null) _operation = new List<OperationComponent>(); return _operation; }
                set { _operation = value; OnPropertyChanged("Operation"); }
            }

            private List<OperationComponent> _operation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ResourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ResourceType>)TypeElement.DeepCopy();
                    if (ProfileElement != null) dest.ProfileElement = (Canonical)ProfileElement.DeepCopy();
                    if (SupportedProfileElement != null) dest.SupportedProfileElement = new List<Canonical>(SupportedProfileElement.DeepCopy());
                    if (Documentation != null) dest.Documentation = (Markdown)Documentation.DeepCopy();
                    if (Interaction != null) dest.Interaction = new List<ResourceInteractionComponent>(Interaction.DeepCopy());
                    if (VersioningElement != null) dest.VersioningElement = (Code<ResourceVersionPolicy>)VersioningElement.DeepCopy();
                    if (ReadHistoryElement != null) dest.ReadHistoryElement = (FhirBoolean)ReadHistoryElement.DeepCopy();
                    if (UpdateCreateElement != null) dest.UpdateCreateElement = (FhirBoolean)UpdateCreateElement.DeepCopy();
                    if (ConditionalCreateElement != null) dest.ConditionalCreateElement = (FhirBoolean)ConditionalCreateElement.DeepCopy();
                    if (ConditionalReadElement != null) dest.ConditionalReadElement = (Code<ConditionalReadStatus>)ConditionalReadElement.DeepCopy();
                    if (ConditionalUpdateElement != null) dest.ConditionalUpdateElement = (FhirBoolean)ConditionalUpdateElement.DeepCopy();
                    if (ConditionalDeleteElement != null) dest.ConditionalDeleteElement = (Code<ConditionalDeleteStatus>)ConditionalDeleteElement.DeepCopy();
                    if (ReferencePolicyElement != null) dest.ReferencePolicyElement = new List<Code<ReferenceHandlingPolicy>>(ReferencePolicyElement.DeepCopy());
                    if (SearchIncludeElement != null) dest.SearchIncludeElement = new List<FhirString>(SearchIncludeElement.DeepCopy());
                    if (SearchRevIncludeElement != null) dest.SearchRevIncludeElement = new List<FhirString>(SearchRevIncludeElement.DeepCopy());
                    if (SearchParam != null) dest.SearchParam = new List<SearchParamComponent>(SearchParam.DeepCopy());
                    if (Operation != null) dest.Operation = new List<OperationComponent>(Operation.DeepCopy());
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
                if (!DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;
                if ( !DeepComparable.Matches(SupportedProfileElement, otherT.SupportedProfileElement)) return false;
                if (!DeepComparable.Matches(Documentation, otherT.Documentation)) return false;
                if ( !DeepComparable.Matches(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.Matches(VersioningElement, otherT.VersioningElement)) return false;
                if (!DeepComparable.Matches(ReadHistoryElement, otherT.ReadHistoryElement)) return false;
                if (!DeepComparable.Matches(UpdateCreateElement, otherT.UpdateCreateElement)) return false;
                if (!DeepComparable.Matches(ConditionalCreateElement, otherT.ConditionalCreateElement)) return false;
                if (!DeepComparable.Matches(ConditionalReadElement, otherT.ConditionalReadElement)) return false;
                if (!DeepComparable.Matches(ConditionalUpdateElement, otherT.ConditionalUpdateElement)) return false;
                if (!DeepComparable.Matches(ConditionalDeleteElement, otherT.ConditionalDeleteElement)) return false;
                if ( !DeepComparable.Matches(ReferencePolicyElement, otherT.ReferencePolicyElement)) return false;
                if ( !DeepComparable.Matches(SearchIncludeElement, otherT.SearchIncludeElement)) return false;
                if ( !DeepComparable.Matches(SearchRevIncludeElement, otherT.SearchRevIncludeElement)) return false;
                if ( !DeepComparable.Matches(SearchParam, otherT.SearchParam)) return false;
                if ( !DeepComparable.Matches(Operation, otherT.Operation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ResourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;
                if (!DeepComparable.IsExactly(SupportedProfileElement, otherT.SupportedProfileElement)) return false;
                if (!DeepComparable.IsExactly(Documentation, otherT.Documentation)) return false;
                if (!DeepComparable.IsExactly(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.IsExactly(VersioningElement, otherT.VersioningElement)) return false;
                if (!DeepComparable.IsExactly(ReadHistoryElement, otherT.ReadHistoryElement)) return false;
                if (!DeepComparable.IsExactly(UpdateCreateElement, otherT.UpdateCreateElement)) return false;
                if (!DeepComparable.IsExactly(ConditionalCreateElement, otherT.ConditionalCreateElement)) return false;
                if (!DeepComparable.IsExactly(ConditionalReadElement, otherT.ConditionalReadElement)) return false;
                if (!DeepComparable.IsExactly(ConditionalUpdateElement, otherT.ConditionalUpdateElement)) return false;
                if (!DeepComparable.IsExactly(ConditionalDeleteElement, otherT.ConditionalDeleteElement)) return false;
                if (!DeepComparable.IsExactly(ReferencePolicyElement, otherT.ReferencePolicyElement)) return false;
                if (!DeepComparable.IsExactly(SearchIncludeElement, otherT.SearchIncludeElement)) return false;
                if (!DeepComparable.IsExactly(SearchRevIncludeElement, otherT.SearchRevIncludeElement)) return false;
                if (!DeepComparable.IsExactly(SearchParam, otherT.SearchParam)) return false;
                if (!DeepComparable.IsExactly(Operation, otherT.Operation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (ProfileElement != null) yield return ProfileElement;
                    foreach (var elem in SupportedProfileElement) { if (elem != null) yield return elem; }
                    if (Documentation != null) yield return Documentation;
                    foreach (var elem in Interaction) { if (elem != null) yield return elem; }
                    if (VersioningElement != null) yield return VersioningElement;
                    if (ReadHistoryElement != null) yield return ReadHistoryElement;
                    if (UpdateCreateElement != null) yield return UpdateCreateElement;
                    if (ConditionalCreateElement != null) yield return ConditionalCreateElement;
                    if (ConditionalReadElement != null) yield return ConditionalReadElement;
                    if (ConditionalUpdateElement != null) yield return ConditionalUpdateElement;
                    if (ConditionalDeleteElement != null) yield return ConditionalDeleteElement;
                    foreach (var elem in ReferencePolicyElement) { if (elem != null) yield return elem; }
                    foreach (var elem in SearchIncludeElement) { if (elem != null) yield return elem; }
                    foreach (var elem in SearchRevIncludeElement) { if (elem != null) yield return elem; }
                    foreach (var elem in SearchParam) { if (elem != null) yield return elem; }
                    foreach (var elem in Operation) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (ProfileElement != null) yield return new ElementValue("profile", ProfileElement);
                    foreach (var elem in SupportedProfileElement) { if (elem != null) yield return new ElementValue("supportedProfile", elem); }
                    if (Documentation != null) yield return new ElementValue("documentation", Documentation);
                    foreach (var elem in Interaction) { if (elem != null) yield return new ElementValue("interaction", elem); }
                    if (VersioningElement != null) yield return new ElementValue("versioning", VersioningElement);
                    if (ReadHistoryElement != null) yield return new ElementValue("readHistory", ReadHistoryElement);
                    if (UpdateCreateElement != null) yield return new ElementValue("updateCreate", UpdateCreateElement);
                    if (ConditionalCreateElement != null) yield return new ElementValue("conditionalCreate", ConditionalCreateElement);
                    if (ConditionalReadElement != null) yield return new ElementValue("conditionalRead", ConditionalReadElement);
                    if (ConditionalUpdateElement != null) yield return new ElementValue("conditionalUpdate", ConditionalUpdateElement);
                    if (ConditionalDeleteElement != null) yield return new ElementValue("conditionalDelete", ConditionalDeleteElement);
                    foreach (var elem in ReferencePolicyElement) { if (elem != null) yield return new ElementValue("referencePolicy", elem); }
                    foreach (var elem in SearchIncludeElement) { if (elem != null) yield return new ElementValue("searchInclude", elem); }
                    foreach (var elem in SearchRevIncludeElement) { if (elem != null) yield return new ElementValue("searchRevInclude", elem); }
                    foreach (var elem in SearchParam) { if (elem != null) yield return new ElementValue("searchParam", elem); }
                    foreach (var elem in Operation) { if (elem != null) yield return new ElementValue("operation", elem); }
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
            /// read | vread | update | patch | delete | history-instance | history-type | create | search-type
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
            /// read | vread | update | patch | delete | history-instance | history-type | create | search-type
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
            public Canonical DefinitionElement
            {
                get { return _definitionElement; }
                set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
            }

            private Canonical _definitionElement;

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
                        DefinitionElement = new Canonical(value);
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SearchParamComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DefinitionElement != null) dest.DefinitionElement = (Canonical)DefinitionElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<SearchParamType>)TypeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
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
            [FhirElement("definition", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Canonical DefinitionElement
            {
                get { return _definitionElement; }
                set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
            }

            private Canonical _definitionElement;

            /// <summary>
            /// The defined operation/query
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

            /// <summary>
            /// Specific details about operation behavior
            /// </summary>
            [FhirElement("documentation", Order=60)]
            [DataMember]
            public Markdown Documentation
            {
                get { return _documentation; }
                set { _documentation = value; OnPropertyChanged("Documentation"); }
            }

            private Markdown _documentation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OperationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DefinitionElement != null) dest.DefinitionElement = (Canonical)DefinitionElement.DeepCopy();
                    if (Documentation != null) dest.Documentation = (Markdown)Documentation.DeepCopy();
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
                if (!DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.Matches(Documentation, otherT.Documentation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OperationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.IsExactly(Documentation, otherT.Documentation)) return false;

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
                    if (Documentation != null) yield return Documentation;
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
                    if (Documentation != null) yield return new ElementValue("documentation", Documentation);
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
            /// transaction | batch | search-system | history-system
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
            /// transaction | batch | search-system | history-system
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


        [FhirType("MessagingComponent")]
        [DataContract]
        public partial class MessagingComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MessagingComponent"; } }

            /// <summary>
            /// Where messages should be sent
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
            /// Messages supported by this system
            /// </summary>
            [FhirElement("supportedMessage", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SupportedMessageComponent> SupportedMessage
            {
                get { if (_supportedMessage==null) _supportedMessage = new List<SupportedMessageComponent>(); return _supportedMessage; }
                set { _supportedMessage = value; OnPropertyChanged("SupportedMessage"); }
            }

            private List<SupportedMessageComponent> _supportedMessage;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MessagingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Endpoint != null) dest.Endpoint = new List<EndpointComponent>(Endpoint.DeepCopy());
                    if (ReliableCacheElement != null) dest.ReliableCacheElement = (UnsignedInt)ReliableCacheElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (SupportedMessage != null) dest.SupportedMessage = new List<SupportedMessageComponent>(SupportedMessage.DeepCopy());
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
                if ( !DeepComparable.Matches(SupportedMessage, otherT.SupportedMessage)) return false;

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
                if (!DeepComparable.IsExactly(SupportedMessage, otherT.SupportedMessage)) return false;

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
                    foreach (var elem in SupportedMessage) { if (elem != null) yield return elem; }
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
                    foreach (var elem in SupportedMessage) { if (elem != null) yield return new ElementValue("supportedMessage", elem); }
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
            /// Network address or identifier of the end-point
            /// </summary>
            [FhirElement("address", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUrl AddressElement
            {
                get { return _addressElement; }
                set { _addressElement = value; OnPropertyChanged("AddressElement"); }
            }

            private FhirUrl _addressElement;

            /// <summary>
            /// Network address or identifier of the end-point
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
                        AddressElement = new FhirUrl(value);
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
                    if (AddressElement != null) dest.AddressElement = (FhirUrl)AddressElement.DeepCopy();
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


        [FhirType("SupportedMessageComponent")]
        [DataContract]
        public partial class SupportedMessageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SupportedMessageComponent"; } }

            /// <summary>
            /// sender | receiver
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<EventCapabilityMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<EventCapabilityMode> _modeElement;

            /// <summary>
            /// sender | receiver
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public EventCapabilityMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<EventCapabilityMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// Message supported by this system
            /// </summary>
            [FhirElement("definition", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Canonical DefinitionElement
            {
                get { return _definitionElement; }
                set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
            }

            private Canonical _definitionElement;

            /// <summary>
            /// Message supported by this system
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
                var dest = other as SupportedMessageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ModeElement != null) dest.ModeElement = (Code<EventCapabilityMode>)ModeElement.DeepCopy();
                    if (DefinitionElement != null) dest.DefinitionElement = (Canonical)DefinitionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SupportedMessageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SupportedMessageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SupportedMessageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ModeElement != null) yield return ModeElement;
                    if (DefinitionElement != null) yield return DefinitionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                    if (DefinitionElement != null) yield return new ElementValue("definition", DefinitionElement);
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
            [FhirElement("mode", InSummary=true, Order=40)]
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
            /// Constraint on the resources used in the document
            /// </summary>
            [FhirElement("profile", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Canonical ProfileElement
            {
                get { return _profileElement; }
                set { _profileElement = value; OnPropertyChanged("ProfileElement"); }
            }

            private Canonical _profileElement;

            /// <summary>
            /// Constraint on the resources used in the document
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Profile
            {
                get { return ProfileElement != null ? ProfileElement.Value : null; }
                set
                {
                    if (value == null)
                        ProfileElement = null;
                    else
                        ProfileElement = new Canonical(value);
                    OnPropertyChanged("Profile");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DocumentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ModeElement != null) dest.ModeElement = (Code<DocumentMode>)ModeElement.DeepCopy();
                    if (DocumentationElement != null) dest.DocumentationElement = (FhirString)DocumentationElement.DeepCopy();
                    if (ProfileElement != null) dest.ProfileElement = (Canonical)ProfileElement.DeepCopy();
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
                if (!DeepComparable.Matches(ProfileElement, otherT.ProfileElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DocumentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(DocumentationElement, otherT.DocumentationElement)) return false;
                if (!DeepComparable.IsExactly(ProfileElement, otherT.ProfileElement)) return false;

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
                    if (ProfileElement != null) yield return ProfileElement;
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
                    if (ProfileElement != null) yield return new ElementValue("profile", ProfileElement);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this capability statement, represented as a URI (globally unique)
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
        /// Canonical identifier for this capability statement, represented as a URI (globally unique)
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
        /// Business version of the capability statement
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
        /// Business version of the capability statement
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
        /// Name for this capability statement (computer friendly)
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
        /// Name for this capability statement (computer friendly)
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
        /// Name for this capability statement (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=true, Order=120)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Name for this capability statement (human friendly)
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
        [FhirElement("status", InSummary=true, Order=130)]
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
        [FhirElement("experimental", InSummary=true, Order=140)]
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
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
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
        [FhirElement("publisher", InSummary=true, Order=160)]
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
        [FhirElement("contact", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Natural language description of the capability statement
        /// </summary>
        [FhirElement("description", Order=180)]
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
        [FhirElement("useContext", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for capability statement (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Why this capability statement is defined
        /// </summary>
        [FhirElement("purpose", Order=210)]
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
        [FhirElement("copyright", Order=220)]
        [DataMember]
        public Markdown Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        private Markdown _copyright;

        /// <summary>
        /// instance | capability | requirements
        /// </summary>
        [FhirElement("kind", InSummary=true, Order=230)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<CapabilityStatementKind> KindElement
        {
            get { return _kindElement; }
            set { _kindElement = value; OnPropertyChanged("KindElement"); }
        }

        private Code<CapabilityStatementKind> _kindElement;

        /// <summary>
        /// instance | capability | requirements
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CapabilityStatementKind? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (value == null)
                    KindElement = null;
                else
                    KindElement = new Code<CapabilityStatementKind>(value);
                OnPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// Canonical URL of another capability statement this implements
        /// </summary>
        [FhirElement("instantiates", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> InstantiatesElement
        {
            get { if (_instantiatesElement==null) _instantiatesElement = new List<Canonical>(); return _instantiatesElement; }
            set { _instantiatesElement = value; OnPropertyChanged("InstantiatesElement"); }
        }

        private List<Canonical> _instantiatesElement;

        /// <summary>
        /// Canonical URL of another capability statement this implements
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Instantiates
        {
            get { return InstantiatesElement != null ? InstantiatesElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesElement = null;
                else
                    InstantiatesElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("Instantiates");
            }
        }

        /// <summary>
        /// Software that is covered by this capability statement
        /// </summary>
        [FhirElement("software", InSummary=true, Order=250)]
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
        [FhirElement("implementation", InSummary=true, Order=260)]
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
        [FhirElement("fhirVersion", InSummary=true, Order=270)]
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
        /// formats supported (xml | json | ttl | mime type)
        /// </summary>
        [FhirElement("format", InSummary=true, Order=280)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Code> FormatElement
        {
            get { if (_formatElement==null) _formatElement = new List<Code>(); return _formatElement; }
            set { _formatElement = value; OnPropertyChanged("FormatElement"); }
        }

        private List<Code> _formatElement;

        /// <summary>
        /// formats supported (xml | json | ttl | mime type)
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
        /// Patch formats supported
        /// </summary>
        [FhirElement("patchFormat", InSummary=true, Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code> PatchFormatElement
        {
            get { if (_patchFormatElement==null) _patchFormatElement = new List<Code>(); return _patchFormatElement; }
            set { _patchFormatElement = value; OnPropertyChanged("PatchFormatElement"); }
        }

        private List<Code> _patchFormatElement;

        /// <summary>
        /// Patch formats supported
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> PatchFormat
        {
            get { return PatchFormatElement != null ? PatchFormatElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    PatchFormatElement = null;
                else
                    PatchFormatElement = new List<Code>(value.Select(elem=>new Code(elem)));
                OnPropertyChanged("PatchFormat");
            }
        }

        /// <summary>
        /// Implementation guides supported
        /// </summary>
        [FhirElement("implementationGuide", InSummary=true, Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> ImplementationGuideElement
        {
            get { if (_implementationGuideElement==null) _implementationGuideElement = new List<Canonical>(); return _implementationGuideElement; }
            set { _implementationGuideElement = value; OnPropertyChanged("ImplementationGuideElement"); }
        }

        private List<Canonical> _implementationGuideElement;

        /// <summary>
        /// Implementation guides supported
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> ImplementationGuide
        {
            get { return ImplementationGuideElement != null ? ImplementationGuideElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ImplementationGuideElement = null;
                else
                    ImplementationGuideElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("ImplementationGuide");
            }
        }

        /// <summary>
        /// If the endpoint is a RESTful one
        /// </summary>
        [FhirElement("rest", InSummary=true, Order=310)]
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
        [FhirElement("messaging", InSummary=true, Order=320)]
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
        [FhirElement("document", InSummary=true, Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DocumentComponent> Document
        {
            get { if (_document==null) _document = new List<DocumentComponent>(); return _document; }
            set { _document = value; OnPropertyChanged("Document"); }
        }

        private List<DocumentComponent> _document;


        public static ElementDefinition.ConstraintComponent CapabilityStatement_CPB_8 = new ElementDefinition.ConstraintComponent
        {
            Expression = "rest.select(mode).isDistinct()",
            Key = "cpb-8",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "There can only be one REST declaration per mode.",
            Xpath = "count(f:rest)=count(distinct-values(f:rest/f:mode/@value))"
        };

        public static ElementDefinition.ConstraintComponent CapabilityStatement_CPB_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "document.select(profile&mode).isDistinct()",
            Key = "cpb-7",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "The set of documents must be unique by the combination of profile and mode.",
            Xpath = "count(f:document[f:mode/@value='producer'])=count(distinct-values(f:document[f:mode/@value='producer']/f:profile/f:reference/@value)) and count(f:document[f:mode/@value='consumer'])=count(distinct-values(f:document[f:mode/@value='consumer']/f:profile/f:reference/@value))"
        };

        public static ElementDefinition.ConstraintComponent CapabilityStatement_CPB_15 = new ElementDefinition.ConstraintComponent
        {
            Expression = "implementation.empty() or kind = 'instance'",
            Key = "cpb-15",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Capability Statements cannot have implementation elements unless kind is 'instance'",
            Xpath = "not(exists(f:implementation)) or (f:kind/@value = 'instance')"
        };

        public static ElementDefinition.ConstraintComponent CapabilityStatement_CPB_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "messaging.endpoint.empty() or kind = 'instance'",
            Key = "cpb-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Messaging end-point is required (and is only permitted) when a statement is for an implementation.",
            Xpath = "not(exists(f:messaging/f:endpoint)) or f:kind/@value = 'instance'"
        };

        public static ElementDefinition.ConstraintComponent CapabilityStatement_CPB_14 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(software.empty() and implementation.empty()) or kind != 'requirements'",
            Key = "cpb-14",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Capability Statements of kind 'requirements' do not have software or implementation elements.",
            Xpath = "not(exists(f:software) or exists(f:implementation)) or (f:kind/@value != 'requirements')"
        };

        public static ElementDefinition.ConstraintComponent CapabilityStatement_CPB_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(description.count() + software.count() + implementation.count()) > 0",
            Key = "cpb-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A Capability Statement SHALL have at least one of description, software, or implementation element.",
            Xpath = "count(f:software | f:implementation | f:description) > 0"
        };

        public static ElementDefinition.ConstraintComponent CapabilityStatement_CPB_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "rest.exists() or messaging.exists() or document.exists()",
            Key = "cpb-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A Capability Statement SHALL have at least one of REST, messaging or document element.",
            Xpath = "exists(f:rest) or exists(f:messaging) or exists(f:document)"
        };

        public static ElementDefinition.ConstraintComponent CapabilityStatement_CPB_9 = new ElementDefinition.ConstraintComponent
        {
            Expression = "rest.all(resource.select(type).isDistinct())",
            Key = "cpb-9",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A given resource can only be described once per RESTful mode.",
            Xpath = "count(f:resource)=count(distinct-values(f:resource/f:type/@value))"
        };

        public static ElementDefinition.ConstraintComponent CapabilityStatement_CPB_12 = new ElementDefinition.ConstraintComponent
        {
            Expression = "rest.resource.all(searchParam.select(name).isDistinct())",
            Key = "cpb-12",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Search parameter names must be unique in the context of a resource.",
            Xpath = "count(f:searchParam)=count(distinct-values(f:searchParam/f:name/@value))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(CapabilityStatement_CPB_8);
            InvariantConstraints.Add(CapabilityStatement_CPB_7);
            InvariantConstraints.Add(CapabilityStatement_CPB_15);
            InvariantConstraints.Add(CapabilityStatement_CPB_3);
            InvariantConstraints.Add(CapabilityStatement_CPB_14);
            InvariantConstraints.Add(CapabilityStatement_CPB_2);
            InvariantConstraints.Add(CapabilityStatement_CPB_1);
            InvariantConstraints.Add(CapabilityStatement_CPB_9);
            InvariantConstraints.Add(CapabilityStatement_CPB_12);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as CapabilityStatement;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
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
                if (KindElement != null) dest.KindElement = (Code<CapabilityStatementKind>)KindElement.DeepCopy();
                if (InstantiatesElement != null) dest.InstantiatesElement = new List<Canonical>(InstantiatesElement.DeepCopy());
                if (Software != null) dest.Software = (SoftwareComponent)Software.DeepCopy();
                if (Implementation != null) dest.Implementation = (ImplementationComponent)Implementation.DeepCopy();
                if (FhirVersionElement != null) dest.FhirVersionElement = (Id)FhirVersionElement.DeepCopy();
                if (FormatElement != null) dest.FormatElement = new List<Code>(FormatElement.DeepCopy());
                if (PatchFormatElement != null) dest.PatchFormatElement = new List<Code>(PatchFormatElement.DeepCopy());
                if (ImplementationGuideElement != null) dest.ImplementationGuideElement = new List<Canonical>(ImplementationGuideElement.DeepCopy());
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
             return CopyTo(new CapabilityStatement());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as CapabilityStatement;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
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
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if ( !DeepComparable.Matches(InstantiatesElement, otherT.InstantiatesElement)) return false;
            if (!DeepComparable.Matches(Software, otherT.Software)) return false;
            if (!DeepComparable.Matches(Implementation, otherT.Implementation)) return false;
            if (!DeepComparable.Matches(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if ( !DeepComparable.Matches(FormatElement, otherT.FormatElement)) return false;
            if ( !DeepComparable.Matches(PatchFormatElement, otherT.PatchFormatElement)) return false;
            if ( !DeepComparable.Matches(ImplementationGuideElement, otherT.ImplementationGuideElement)) return false;
            if ( !DeepComparable.Matches(Rest, otherT.Rest)) return false;
            if ( !DeepComparable.Matches(Messaging, otherT.Messaging)) return false;
            if ( !DeepComparable.Matches(Document, otherT.Document)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as CapabilityStatement;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
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
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(InstantiatesElement, otherT.InstantiatesElement)) return false;
            if (!DeepComparable.IsExactly(Software, otherT.Software)) return false;
            if (!DeepComparable.IsExactly(Implementation, otherT.Implementation)) return false;
            if (!DeepComparable.IsExactly(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if (!DeepComparable.IsExactly(FormatElement, otherT.FormatElement)) return false;
            if (!DeepComparable.IsExactly(PatchFormatElement, otherT.PatchFormatElement)) return false;
            if (!DeepComparable.IsExactly(ImplementationGuideElement, otherT.ImplementationGuideElement)) return false;
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
                if (KindElement != null) yield return KindElement;
                foreach (var elem in InstantiatesElement) { if (elem != null) yield return elem; }
                if (Software != null) yield return Software;
                if (Implementation != null) yield return Implementation;
                if (FhirVersionElement != null) yield return FhirVersionElement;
                foreach (var elem in FormatElement) { if (elem != null) yield return elem; }
                foreach (var elem in PatchFormatElement) { if (elem != null) yield return elem; }
                foreach (var elem in ImplementationGuideElement) { if (elem != null) yield return elem; }
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
                if (KindElement != null) yield return new ElementValue("kind", KindElement);
                foreach (var elem in InstantiatesElement) { if (elem != null) yield return new ElementValue("instantiates", elem); }
                if (Software != null) yield return new ElementValue("software", Software);
                if (Implementation != null) yield return new ElementValue("implementation", Implementation);
                if (FhirVersionElement != null) yield return new ElementValue("fhirVersion", FhirVersionElement);
                foreach (var elem in FormatElement) { if (elem != null) yield return new ElementValue("format", elem); }
                foreach (var elem in PatchFormatElement) { if (elem != null) yield return new ElementValue("patchFormat", elem); }
                foreach (var elem in ImplementationGuideElement) { if (elem != null) yield return new ElementValue("implementationGuide", elem); }
                foreach (var elem in Rest) { if (elem != null) yield return new ElementValue("rest", elem); }
                foreach (var elem in Messaging) { if (elem != null) yield return new ElementValue("messaging", elem); }
                foreach (var elem in Document) { if (elem != null) yield return new ElementValue("document", elem); }
            }
        }

    }

}
