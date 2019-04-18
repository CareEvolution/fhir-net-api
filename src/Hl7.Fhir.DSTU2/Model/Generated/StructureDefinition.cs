using System;
using System.Collections.Generic;
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
    /// Structural Definition
    /// </summary>
    [FhirType("StructureDefinition", IsResource = true)]
    [DataContract]
    public partial class StructureDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.StructureDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "StructureDefinition"; } }

        /// <summary>
        /// Defines the type of structure that a definition is describing.
        /// (url: http://hl7.org/fhir/ValueSet/structure-definition-kind)
        /// </summary>
        [FhirEnumeration("StructureDefinitionKind")]
        public enum StructureDefinitionKind
        {
            /// <summary>
            /// A data type - either a primitive or complex structure that defines a set of data elements. These can be used throughout Resource and extension definitions.
            /// (system: http://hl7.org/fhir/structure-definition-kind)
            /// </summary>
            [EnumLiteral("datatype", "http://hl7.org/fhir/structure-definition-kind"), Description("Data Type")]
            Datatype,
            /// <summary>
            /// A resource defined by the FHIR specification.
            /// (system: http://hl7.org/fhir/structure-definition-kind)
            /// </summary>
            [EnumLiteral("resource", "http://hl7.org/fhir/structure-definition-kind"), Description("Resource")]
            Resource,
            /// <summary>
            /// A logical model - a conceptual package of data that will be mapped to resources for implementation.
            /// (system: http://hl7.org/fhir/structure-definition-kind)
            /// </summary>
            [EnumLiteral("logical", "http://hl7.org/fhir/structure-definition-kind"), Description("Logical Model")]
            Logical,
        }

        /// <summary>
        /// How an extension context is interpreted.
        /// (url: http://hl7.org/fhir/ValueSet/extension-context)
        /// </summary>
        [FhirEnumeration("ExtensionContext")]
        public enum ExtensionContext
        {
            /// <summary>
            /// The context is all elements matching a particular resource element path.
            /// (system: http://hl7.org/fhir/extension-context)
            /// </summary>
            [EnumLiteral("resource", "http://hl7.org/fhir/extension-context"), Description("Resource")]
            Resource,
            /// <summary>
            /// The context is all nodes matching a particular data type element path (root or repeating element) or all elements referencing a particular primitive data type (expressed as the datatype name).
            /// (system: http://hl7.org/fhir/extension-context)
            /// </summary>
            [EnumLiteral("datatype", "http://hl7.org/fhir/extension-context"), Description("Datatype")]
            Datatype,
            /// <summary>
            /// The context is all nodes whose mapping to a specified reference model corresponds to a particular mapping structure.  The context identifies the mapping target. The mapping should clearly identify where such an extension could be used.
            /// (system: http://hl7.org/fhir/extension-context)
            /// </summary>
            [EnumLiteral("mapping", "http://hl7.org/fhir/extension-context"), Description("Mapping")]
            Mapping,
            /// <summary>
            /// The context is a particular extension from a particular profile, a uri that identifies the extension definition.
            /// (system: http://hl7.org/fhir/extension-context)
            /// </summary>
            [EnumLiteral("extension", "http://hl7.org/fhir/extension-context"), Description("Extension")]
            Extension,
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
            [FhirElement("name", InSummary = true, Order = 40)]
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
            [FhirElement("telecom", InSummary = true, Order = 50)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<ContactPoint> Telecom
            {
                get { if (_telecom == null) _telecom = new List<ContactPoint>(); return _telecom; }
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
                if (!DeepComparable.Matches(Telecom, otherT.Telecom)) return false;

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


        [FhirType("MappingComponent")]
        [DataContract]
        public partial class MappingComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MappingComponent"; } }

            /// <summary>
            /// Internal id when this mapping is used
            /// </summary>
            [FhirElement("identity", Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Id IdentityElement
            {
                get { return _identityElement; }
                set { _identityElement = value; OnPropertyChanged("IdentityElement"); }
            }

            private Id _identityElement;

            /// <summary>
            /// Internal id when this mapping is used
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Identity
            {
                get { return IdentityElement != null ? IdentityElement.Value : null; }
                set
                {
                    if (value == null)
                        IdentityElement = null;
                    else
                        IdentityElement = new Id(value);
                    OnPropertyChanged("Identity");
                }
            }

            /// <summary>
            /// Identifies what this mapping refers to
            /// </summary>
            [FhirElement("uri", Order = 50)]
            [DataMember]
            public FhirUri UriElement
            {
                get { return _uriElement; }
                set { _uriElement = value; OnPropertyChanged("UriElement"); }
            }

            private FhirUri _uriElement;

            /// <summary>
            /// Identifies what this mapping refers to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Uri
            {
                get { return UriElement != null ? UriElement.Value : null; }
                set
                {
                    if (value == null)
                        UriElement = null;
                    else
                        UriElement = new FhirUri(value);
                    OnPropertyChanged("Uri");
                }
            }

            /// <summary>
            /// Names what this mapping refers to
            /// </summary>
            [FhirElement("name", Order = 60)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Names what this mapping refers to
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
            /// Versions, Issues, Scope limitations etc.
            /// </summary>
            [FhirElement("comments", Order = 70)]
            [DataMember]
            public FhirString CommentsElement
            {
                get { return _commentsElement; }
                set { _commentsElement = value; OnPropertyChanged("CommentsElement"); }
            }

            private FhirString _commentsElement;

            /// <summary>
            /// Versions, Issues, Scope limitations etc.
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Comments
            {
                get { return CommentsElement != null ? CommentsElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentsElement = null;
                    else
                        CommentsElement = new FhirString(value);
                    OnPropertyChanged("Comments");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MappingComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (IdentityElement != null) dest.IdentityElement = (Id)IdentityElement.DeepCopy();
                    if (UriElement != null) dest.UriElement = (FhirUri)UriElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (CommentsElement != null) dest.CommentsElement = (FhirString)CommentsElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MappingComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MappingComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(IdentityElement, otherT.IdentityElement)) return false;
                if (!DeepComparable.Matches(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(CommentsElement, otherT.CommentsElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MappingComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(IdentityElement, otherT.IdentityElement)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(CommentsElement, otherT.CommentsElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (IdentityElement != null) yield return IdentityElement;
                    if (UriElement != null) yield return UriElement;
                    if (NameElement != null) yield return NameElement;
                    if (CommentsElement != null) yield return CommentsElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IdentityElement != null) yield return new ElementValue("identity", IdentityElement);
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (CommentsElement != null) yield return new ElementValue("comments", CommentsElement);
                }
            }


        }


        [FhirType("SnapshotComponent")]
        [DataContract]
        public partial class SnapshotComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SnapshotComponent"; } }

            /// <summary>
            /// Definition of elements in the resource (if no StructureDefinition)
            /// </summary>
            [FhirElement("element", Order = 40)]
            [Cardinality(Min = 1, Max = -1)]
            [DataMember]
            public List<ElementDefinition> Element
            {
                get { if (_element == null) _element = new List<ElementDefinition>(); return _element; }
                set { _element = value; OnPropertyChanged("Element"); }
            }

            private List<ElementDefinition> _element;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SnapshotComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Element != null) dest.Element = new List<ElementDefinition>(Element.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SnapshotComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SnapshotComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Element, otherT.Element)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SnapshotComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Element, otherT.Element)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Element) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Element) { if (elem != null) yield return new ElementValue("element", elem); }
                }
            }


        }


        [FhirType("DifferentialComponent")]
        [DataContract]
        public partial class DifferentialComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DifferentialComponent"; } }

            /// <summary>
            /// Definition of elements in the resource (if no StructureDefinition)
            /// </summary>
            [FhirElement("element", Order = 40)]
            [Cardinality(Min = 1, Max = -1)]
            [DataMember]
            public List<ElementDefinition> Element
            {
                get { if (_element == null) _element = new List<ElementDefinition>(); return _element; }
                set { _element = value; OnPropertyChanged("Element"); }
            }

            private List<ElementDefinition> _element;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DifferentialComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Element != null) dest.Element = new List<ElementDefinition>(Element.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new DifferentialComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DifferentialComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Element, otherT.Element)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DifferentialComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Element, otherT.Element)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Element) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Element) { if (elem != null) yield return new ElementValue("element", elem); }
                }
            }


        }


        /// <summary>
        /// Absolute URL used to reference this StructureDefinition
        /// </summary>
        [FhirElement("url", InSummary = true, Order = 90)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Absolute URL used to reference this StructureDefinition
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
        /// Other identifiers for the StructureDefinition
        /// </summary>
        [FhirElement("identifier", InSummary = true, Order = 100)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Logical id for this version of the StructureDefinition
        /// </summary>
        [FhirElement("version", InSummary = true, Order = 110)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Logical id for this version of the StructureDefinition
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
        /// Informal name for this StructureDefinition
        /// </summary>
        [FhirElement("name", InSummary = true, Order = 120)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Informal name for this StructureDefinition
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
        /// Use this name when displaying the value
        /// </summary>
        [FhirElement("display", InSummary = true, Order = 130)]
        [DataMember]
        public FhirString DisplayElement
        {
            get { return _displayElement; }
            set { _displayElement = value; OnPropertyChanged("DisplayElement"); }
        }

        private FhirString _displayElement;

        /// <summary>
        /// Use this name when displaying the value
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Display
        {
            get { return DisplayElement != null ? DisplayElement.Value : null; }
            set
            {
                if (value == null)
                    DisplayElement = null;
                else
                    DisplayElement = new FhirString(value);
                OnPropertyChanged("Display");
            }
        }

        /// <summary>
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", InSummary = true, Order = 140)]
        [Cardinality(Min = 1, Max = 1)]
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
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<ConformanceResourceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary = true, Order = 150)]
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
                if (!value.HasValue)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }

        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary = true, Order = 160)]
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
        [FhirElement("contact", InSummary = true, Order = 170)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact == null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// Date for this version of the StructureDefinition
        /// </summary>
        [FhirElement("date", InSummary = true, Order = 180)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date for this version of the StructureDefinition
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
        /// Natural language description of the StructureDefinition
        /// </summary>
        [FhirElement("description", InSummary = true, Order = 190)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Natural language description of the StructureDefinition
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
        /// Content intends to support these contexts
        /// </summary>
        [FhirElement("useContext", InSummary = true, Order = 200)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> UseContext
        {
            get { if (_useContext == null) _useContext = new List<CodeableConcept>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<CodeableConcept> _useContext;

        /// <summary>
        /// Scope and Usage this structure definition is for
        /// </summary>
        [FhirElement("requirements", Order = 210)]
        [DataMember]
        public FhirString RequirementsElement
        {
            get { return _requirementsElement; }
            set { _requirementsElement = value; OnPropertyChanged("RequirementsElement"); }
        }

        private FhirString _requirementsElement;

        /// <summary>
        /// Scope and Usage this structure definition is for
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
        [FhirElement("copyright", Order = 220)]
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
        /// Assist with indexing and finding
        /// </summary>
        [FhirElement("code", InSummary = true, Order = 230)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Coding> Code
        {
            get { if (_code == null) _code = new List<Coding>(); return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private List<Coding> _code;

        /// <summary>
        /// FHIR Version this StructureDefinition targets
        /// </summary>
        [FhirElement("fhirVersion", InSummary = true, Order = 240)]
        [DataMember]
        public Id FhirVersionElement
        {
            get { return _fhirVersionElement; }
            set { _fhirVersionElement = value; OnPropertyChanged("FhirVersionElement"); }
        }

        private Id _fhirVersionElement;

        /// <summary>
        /// FHIR Version this StructureDefinition targets
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
        /// External specification that the content is mapped to
        /// </summary>
        [FhirElement("mapping", Order = 250)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<MappingComponent> Mapping
        {
            get { if (_mapping == null) _mapping = new List<MappingComponent>(); return _mapping; }
            set { _mapping = value; OnPropertyChanged("Mapping"); }
        }

        private List<MappingComponent> _mapping;

        /// <summary>
        /// datatype | resource | logical
        /// </summary>
        [FhirElement("kind", InSummary = true, Order = 260)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public Code<StructureDefinitionKind> KindElement
        {
            get { return _kindElement; }
            set { _kindElement = value; OnPropertyChanged("KindElement"); }
        }

        private Code<StructureDefinitionKind> _kindElement;

        /// <summary>
        /// datatype | resource | logical
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public StructureDefinitionKind? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    KindElement = null;
                else
                    KindElement = new Code<StructureDefinitionKind>(value);
                OnPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// Any datatype or resource, including abstract ones
        /// </summary>
        [FhirElement("constrainedType", InSummary = true, Order = 270)]
        [DataMember]
        public Code<FHIRDefinedType> ConstrainedTypeElement
        {
            get { return _constrainedTypeElement; }
            set { _constrainedTypeElement = value; OnPropertyChanged("ConstrainedTypeElement"); }
        }

        private Code<FHIRDefinedType> _constrainedTypeElement;

        /// <summary>
        /// Any datatype or resource, including abstract ones
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public FHIRDefinedType? ConstrainedType
        {
            get { return ConstrainedTypeElement != null ? ConstrainedTypeElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    ConstrainedTypeElement = null;
                else
                    ConstrainedTypeElement = new Code<FHIRDefinedType>(value);
                OnPropertyChanged("ConstrainedType");
            }
        }

        /// <summary>
        /// Whether the structure is abstract
        /// </summary>
        [FhirElement("abstract", InSummary = true, Order = 280)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public FhirBoolean AbstractElement
        {
            get { return _abstractElement; }
            set { _abstractElement = value; OnPropertyChanged("AbstractElement"); }
        }

        private FhirBoolean _abstractElement;

        /// <summary>
        /// Whether the structure is abstract
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Abstract
        {
            get { return AbstractElement != null ? AbstractElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    AbstractElement = null;
                else
                    AbstractElement = new FhirBoolean(value);
                OnPropertyChanged("Abstract");
            }
        }

        /// <summary>
        /// resource | datatype | mapping | extension
        /// </summary>
        [FhirElement("contextType", InSummary = true, Order = 290)]
        [DataMember]
        public Code<ExtensionContext> ContextTypeElement
        {
            get { return _contextTypeElement; }
            set { _contextTypeElement = value; OnPropertyChanged("ContextTypeElement"); }
        }

        private Code<ExtensionContext> _contextTypeElement;

        /// <summary>
        /// resource | datatype | mapping | extension
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ExtensionContext? ContextType
        {
            get { return ContextTypeElement != null ? ContextTypeElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    ContextTypeElement = null;
                else
                    ContextTypeElement = new Code<ExtensionContext>(value);
                OnPropertyChanged("ContextType");
            }
        }

        /// <summary>
        /// Where the extension can be used in instances
        /// </summary>
        [FhirElement("context", InSummary = true, Order = 300)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<FhirString> ContextElement
        {
            get { if (_contextElement == null) _contextElement = new List<FhirString>(); return _contextElement; }
            set { _contextElement = value; OnPropertyChanged("ContextElement"); }
        }

        private List<FhirString> _contextElement;

        /// <summary>
        /// Where the extension can be used in instances
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Context
        {
            get { return ContextElement != null ? ContextElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ContextElement = null;
                else
                    ContextElement = new List<FhirString>(value.Select(elem => new FhirString(elem)));
                OnPropertyChanged("Context");
            }
        }

        /// <summary>
        /// Structure that this set of constraints applies to
        /// </summary>
        [FhirElement("base", InSummary = true, Order = 310)]
        [DataMember]
        public FhirUri BaseElement
        {
            get { return _baseElement; }
            set { _baseElement = value; OnPropertyChanged("BaseElement"); }
        }

        private FhirUri _baseElement;

        /// <summary>
        /// Structure that this set of constraints applies to
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Base
        {
            get { return BaseElement != null ? BaseElement.Value : null; }
            set
            {
                if (value == null)
                    BaseElement = null;
                else
                    BaseElement = new FhirUri(value);
                OnPropertyChanged("Base");
            }
        }

        /// <summary>
        /// Snapshot view of the structure
        /// </summary>
        [FhirElement("snapshot", Order = 320)]
        [DataMember]
        public SnapshotComponent Snapshot
        {
            get { return _snapshot; }
            set { _snapshot = value; OnPropertyChanged("Snapshot"); }
        }

        private SnapshotComponent _snapshot;

        /// <summary>
        /// Differential view of the structure
        /// </summary>
        [FhirElement("differential", Order = 330)]
        [DataMember]
        public DifferentialComponent Differential
        {
            get { return _differential; }
            set { _differential = value; OnPropertyChanged("Differential"); }
        }

        private DifferentialComponent _differential;


        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_11 = new ElementDefinition.ConstraintComponent
        {
            Expression = "constrainedType.empty() or snapshot.empty() or snapshot.element.first().path = constrainedType",
            Key = "sdf-11",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If there's a constrained type, its content must match the path name in the first element of a snapshot",
            Xpath = "not(exists(f:constrainedType)) or not(exists(f:snapshot)) or (f:constrainedType/@value = f:snapshot/f:element[1]/f:path/@value)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "constrainedType != 'Extension' or (context and contextType)",
            Key = "sdf-5",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the structure defines an extension then the structure must have context information",
            Xpath = "not(f:constrainedType/@value = 'extension') or (exists(f:context) and exists(f:contextType))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_12 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.element.base implies base",
            Key = "sdf-12",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "element.base cannot appear if there is no base on the structure definition",
            Xpath = "f:base or not(exists(f:snapshot/f:element/f:base) or exists(f:differential/f:element/f:base))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "base or abstract = 'true'",
            Key = "sdf-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A structure must have a base unless abstract = true",
            Xpath = "(f:abstract/@value =true()) or exists(f:base)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "constrainedType or url = 'http://hl7.org/fhir/StructureDefinition/'+id",
            Key = "sdf-7",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the structure describes a base Resource or Type, the URL has to start with \"http://hl7.org/fhir/StructureDefinition/\" and the tail must match the id",
            Xpath = "exists(f:constrainedType) or f:url/@value=concat('http://hl7.org/fhir/StructureDefinition/', f:id/@value)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot or differential",
            Key = "sdf-6",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A structure must have either a differential, or a snapshot (or both)",
            Xpath = "exists(f:snapshot) or exists(f:differential)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "constrainedType or snapshot.element.select(path).isDistinct()",
            Key = "sdf-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Element paths must be unique unless the structure is a constraint",
            Xpath = "exists(f:constrainedType) or (count(f:snapshot/f:element) = count(distinct-values(f:snapshot/f:element/f:path/@value)))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_8 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.element.tail().all(path.startsWith(%context.snapshot.element.first().path+'.')) and differential.element.tail().all(path.startsWith(%context.differential.element.first().path+'.'))",
            Key = "sdf-8",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "In any snapshot or differential, all the elements except the first have to have a path that starts with the path of the first + \".\"",
            Xpath = "string-join(for $elementName in f:*[self::f:snapshot or self::f:differential]/f:element[position()>1]/f:path/@value return if (starts-with($elementName, concat($elementName/ancestor::f:element/parent::f:*/f:element[1]/f:path/@value, '.'))) then '' else $elementName,'')=''"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_9 = new ElementDefinition.ConstraintComponent
        {
            Expression = "children().element.first().label.empty() and children().element.first().code.empty() and children().element.first().requirements.empty()",
            Key = "sdf-9",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "In any snapshot or differential, no label, code or requirements on the an element without a \".\" in the path (e.g. the first element)",
            Xpath = "not(exists(f:snapshot/f:element[not(contains(f:path/@value, '.')) and (f:label or f:code or f:requirements)])) and not(exists(f:differential/f:element[not(contains(f:path/@value, '.')) and (f:label or f:code or f:requirements)]))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_10 = new ElementDefinition.ConstraintComponent
        {
            Expression = "base or abstract = 'true' or constrainedType",
            Key = "sdf-10",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the structure is not abstract, or there's a constrained type, then there SHALL be a base",
            Xpath = "(f:abstract/@value=true()) or not(exists(f:constrainedType)) or exists(f:base)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "mapping.all(name or uri)",
            Key = "sdf-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Must have at a name or a uri (or both)",
            Xpath = "exists(f:uri) or exists(f:name)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.all(element.all(definition and min and max))",
            Key = "sdf-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Each element definition in a snapshot must have a formal definition and cardinalities",
            Xpath = "count(f:element) = count(f:element[exists(f:definition) and exists(f:min) and exists(f:max)])"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(StructureDefinition_SDF_11);
            InvariantConstraints.Add(StructureDefinition_SDF_5);
            InvariantConstraints.Add(StructureDefinition_SDF_12);
            InvariantConstraints.Add(StructureDefinition_SDF_4);
            InvariantConstraints.Add(StructureDefinition_SDF_7);
            InvariantConstraints.Add(StructureDefinition_SDF_6);
            InvariantConstraints.Add(StructureDefinition_SDF_1);
            InvariantConstraints.Add(StructureDefinition_SDF_8);
            InvariantConstraints.Add(StructureDefinition_SDF_9);
            InvariantConstraints.Add(StructureDefinition_SDF_10);
            InvariantConstraints.Add(StructureDefinition_SDF_2);
            InvariantConstraints.Add(StructureDefinition_SDF_3);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as StructureDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ConformanceResourceStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<CodeableConcept>(UseContext.DeepCopy());
                if (RequirementsElement != null) dest.RequirementsElement = (FhirString)RequirementsElement.DeepCopy();
                if (CopyrightElement != null) dest.CopyrightElement = (FhirString)CopyrightElement.DeepCopy();
                if (Code != null) dest.Code = new List<Coding>(Code.DeepCopy());
                if (FhirVersionElement != null) dest.FhirVersionElement = (Id)FhirVersionElement.DeepCopy();
                if (Mapping != null) dest.Mapping = new List<MappingComponent>(Mapping.DeepCopy());
                if (KindElement != null) dest.KindElement = (Code<StructureDefinitionKind>)KindElement.DeepCopy();
                if (ConstrainedTypeElement != null) dest.ConstrainedTypeElement = (Code<FHIRDefinedType>)ConstrainedTypeElement.DeepCopy();
                if (AbstractElement != null) dest.AbstractElement = (FhirBoolean)AbstractElement.DeepCopy();
                if (ContextTypeElement != null) dest.ContextTypeElement = (Code<ExtensionContext>)ContextTypeElement.DeepCopy();
                if (ContextElement != null) dest.ContextElement = new List<FhirString>(ContextElement.DeepCopy());
                if (BaseElement != null) dest.BaseElement = (FhirUri)BaseElement.DeepCopy();
                if (Snapshot != null) dest.Snapshot = (SnapshotComponent)Snapshot.DeepCopy();
                if (Differential != null) dest.Differential = (DifferentialComponent)Differential.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new StructureDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as StructureDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.Matches(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if (!DeepComparable.Matches(Mapping, otherT.Mapping)) return false;
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.Matches(ConstrainedTypeElement, otherT.ConstrainedTypeElement)) return false;
            if (!DeepComparable.Matches(AbstractElement, otherT.AbstractElement)) return false;
            if (!DeepComparable.Matches(ContextTypeElement, otherT.ContextTypeElement)) return false;
            if (!DeepComparable.Matches(ContextElement, otherT.ContextElement)) return false;
            if (!DeepComparable.Matches(BaseElement, otherT.BaseElement)) return false;
            if (!DeepComparable.Matches(Snapshot, otherT.Snapshot)) return false;
            if (!DeepComparable.Matches(Differential, otherT.Differential)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as StructureDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if (!DeepComparable.IsExactly(Mapping, otherT.Mapping)) return false;
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(ConstrainedTypeElement, otherT.ConstrainedTypeElement)) return false;
            if (!DeepComparable.IsExactly(AbstractElement, otherT.AbstractElement)) return false;
            if (!DeepComparable.IsExactly(ContextTypeElement, otherT.ContextTypeElement)) return false;
            if (!DeepComparable.IsExactly(ContextElement, otherT.ContextElement)) return false;
            if (!DeepComparable.IsExactly(BaseElement, otherT.BaseElement)) return false;
            if (!DeepComparable.IsExactly(Snapshot, otherT.Snapshot)) return false;
            if (!DeepComparable.IsExactly(Differential, otherT.Differential)) return false;

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
                if (DisplayElement != null) yield return DisplayElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DateElement != null) yield return DateElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                if (RequirementsElement != null) yield return RequirementsElement;
                if (CopyrightElement != null) yield return CopyrightElement;
                foreach (var elem in Code) { if (elem != null) yield return elem; }
                if (FhirVersionElement != null) yield return FhirVersionElement;
                foreach (var elem in Mapping) { if (elem != null) yield return elem; }
                if (KindElement != null) yield return KindElement;
                if (ConstrainedTypeElement != null) yield return ConstrainedTypeElement;
                if (AbstractElement != null) yield return AbstractElement;
                if (ContextTypeElement != null) yield return ContextTypeElement;
                foreach (var elem in ContextElement) { if (elem != null) yield return elem; }
                if (BaseElement != null) yield return BaseElement;
                if (Snapshot != null) yield return Snapshot;
                if (Differential != null) yield return Differential;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                if (RequirementsElement != null) yield return new ElementValue("requirements", RequirementsElement);
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                if (FhirVersionElement != null) yield return new ElementValue("fhirVersion", FhirVersionElement);
                foreach (var elem in Mapping) { if (elem != null) yield return new ElementValue("mapping", elem); }
                if (KindElement != null) yield return new ElementValue("kind", KindElement);
                if (ConstrainedTypeElement != null) yield return new ElementValue("constrainedType", ConstrainedTypeElement);
                if (AbstractElement != null) yield return new ElementValue("abstract", AbstractElement);
                if (ContextTypeElement != null) yield return new ElementValue("contextType", ContextTypeElement);
                foreach (var elem in ContextElement) { if (elem != null) yield return new ElementValue("context", elem); }
                if (BaseElement != null) yield return new ElementValue("base", BaseElement);
                if (Snapshot != null) yield return new ElementValue("snapshot", Snapshot);
                if (Differential != null) yield return new ElementValue("differential", Differential);
            }
        }

    }

}
