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
    /// Structural Definition
    /// </summary>
    [FhirType("StructureDefinition", IsResource=true)]
    [DataContract]
    public partial class StructureDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.StructureDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "StructureDefinition"; } }


        [FhirType("MappingComponent")]
        [DataContract]
        public partial class MappingComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MappingComponent"; } }

            /// <summary>
            /// Internal id when this mapping is used
            /// </summary>
            [FhirElement("identity", Order=40)]
            [Cardinality(Min=1,Max=1)]
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
            [FhirElement("uri", Order=50)]
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
            [FhirElement("name", Order=60)]
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
            [FhirElement("comment", Order=70)]
            [DataMember]
            public FhirString CommentElement
            {
                get { return _commentElement; }
                set { _commentElement = value; OnPropertyChanged("CommentElement"); }
            }

            private FhirString _commentElement;

            /// <summary>
            /// Versions, Issues, Scope limitations etc.
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Comment
            {
                get { return CommentElement != null ? CommentElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentElement = null;
                    else
                        CommentElement = new FhirString(value);
                    OnPropertyChanged("Comment");
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
                    if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
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
                if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

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
                if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;

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
                    if (CommentElement != null) yield return CommentElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (IdentityElement != null) yield return new ElementValue("identity", false, IdentityElement);
                    if (UriElement != null) yield return new ElementValue("uri", false, UriElement);
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (CommentElement != null) yield return new ElementValue("comment", false, CommentElement);
                }
            }


        }


        [FhirType("ContextComponent")]
        [DataContract]
        public partial class ContextComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContextComponent"; } }

            /// <summary>
            /// fhirpath | element | extension
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ExtensionContextType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<ExtensionContextType> _typeElement;

            /// <summary>
            /// fhirpath | element | extension
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ExtensionContextType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<ExtensionContextType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Where the extension can be used in instances
            /// </summary>
            [FhirElement("expression", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ExpressionElement
            {
                get { return _expressionElement; }
                set { _expressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }

            private FhirString _expressionElement;

            /// <summary>
            /// Where the extension can be used in instances
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
                var dest = other as ContextComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ExtensionContextType>)TypeElement.DeepCopy();
                    if (ExpressionElement != null) dest.ExpressionElement = (FhirString)ExpressionElement.DeepCopy();
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
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContextComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (ExpressionElement != null) yield return ExpressionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (ExpressionElement != null) yield return new ElementValue("expression", false, ExpressionElement);
                }
            }


        }


        [FhirType("SnapshotComponent")]
        [DataContract]
        public partial class SnapshotComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SnapshotComponent"; } }

            /// <summary>
            /// Definition of elements in the resource (if no StructureDefinition)
            /// </summary>
            [FhirElement("element", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ElementDefinition> Element
            {
                get { if (_element==null) _element = new List<ElementDefinition>(); return _element; }
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
                if ( !DeepComparable.Matches(Element, otherT.Element)) return false;

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
                    foreach (var elem in Element) { if (elem != null) yield return new ElementValue("element", true, elem); }
                }
            }


        }


        [FhirType("DifferentialComponent")]
        [DataContract]
        public partial class DifferentialComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DifferentialComponent"; } }

            /// <summary>
            /// Definition of elements in the resource (if no StructureDefinition)
            /// </summary>
            [FhirElement("element", Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<ElementDefinition> Element
            {
                get { if (_element==null) _element = new List<ElementDefinition>(); return _element; }
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
                if ( !DeepComparable.Matches(Element, otherT.Element)) return false;

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
                    foreach (var elem in Element) { if (elem != null) yield return new ElementValue("element", true, elem); }
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this structure definition, represented as a URI (globally unique)
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Canonical identifier for this structure definition, represented as a URI (globally unique)
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
        /// Additional identifier for the structure definition
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
        /// Business version of the structure definition
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
        /// Business version of the structure definition
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
        /// Name for this structure definition (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name for this structure definition (computer friendly)
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
        /// Name for this structure definition (human friendly)
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
        /// Name for this structure definition (human friendly)
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
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=160)]
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
        /// Natural language description of the structure definition
        /// </summary>
        [FhirElement("description", Order=190)]
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
        /// Intended jurisdiction for structure definition (if applicable)
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
        /// Why this structure definition is defined
        /// </summary>
        [FhirElement("purpose", Order=220)]
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
        /// Assist with indexing and finding
        /// </summary>
        [FhirElement("keyword", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> Keyword
        {
            get { if (_keyword==null) _keyword = new List<Coding>(); return _keyword; }
            set { _keyword = value; OnPropertyChanged("Keyword"); }
        }

        private List<Coding> _keyword;

        /// <summary>
        /// FHIR Version this StructureDefinition targets
        /// </summary>
        [FhirElement("fhirVersion", InSummary=true, Order=250)]
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
        [FhirElement("mapping", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MappingComponent> Mapping
        {
            get { if (_mapping==null) _mapping = new List<MappingComponent>(); return _mapping; }
            set { _mapping = value; OnPropertyChanged("Mapping"); }
        }

        private List<MappingComponent> _mapping;

        /// <summary>
        /// primitive-type | complex-type | resource | logical
        /// </summary>
        [FhirElement("kind", InSummary=true, Order=270)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<StructureDefinitionKind> KindElement
        {
            get { return _kindElement; }
            set { _kindElement = value; OnPropertyChanged("KindElement"); }
        }

        private Code<StructureDefinitionKind> _kindElement;

        /// <summary>
        /// primitive-type | complex-type | resource | logical
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public StructureDefinitionKind? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (value == null)
                    KindElement = null;
                else
                    KindElement = new Code<StructureDefinitionKind>(value);
                OnPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// Whether the structure is abstract
        /// </summary>
        [FhirElement("abstract", InSummary=true, Order=280)]
        [Cardinality(Min=1,Max=1)]
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
                if (value == null)
                    AbstractElement = null;
                else
                    AbstractElement = new FhirBoolean(value);
                OnPropertyChanged("Abstract");
            }
        }

        /// <summary>
        /// If an extension, where it can be used in instances
        /// </summary>
        [FhirElement("context", InSummary=true, Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContextComponent> Context
        {
            get { if (_context==null) _context = new List<ContextComponent>(); return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private List<ContextComponent> _context;

        /// <summary>
        /// FHIRPath invariants - when the extension can be used
        /// </summary>
        [FhirElement("contextInvariant", InSummary=true, Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> ContextInvariantElement
        {
            get { if (_contextInvariantElement==null) _contextInvariantElement = new List<FhirString>(); return _contextInvariantElement; }
            set { _contextInvariantElement = value; OnPropertyChanged("ContextInvariantElement"); }
        }

        private List<FhirString> _contextInvariantElement;

        /// <summary>
        /// FHIRPath invariants - when the extension can be used
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> ContextInvariant
        {
            get { return ContextInvariantElement != null ? ContextInvariantElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    ContextInvariantElement = null;
                else
                    ContextInvariantElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("ContextInvariant");
            }
        }

        /// <summary>
        /// Type defined or constrained by this structure
        /// </summary>
        [FhirElement("type", InSummary=true, Order=310)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirUri TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private FhirUri _typeElement;

        /// <summary>
        /// Type defined or constrained by this structure
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
                    TypeElement = new FhirUri(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Definition that this type is constrained/specialized from
        /// </summary>
        [FhirElement("baseDefinition", InSummary=true, Order=320)]
        [DataMember]
        public Canonical BaseDefinitionElement
        {
            get { return _baseDefinitionElement; }
            set { _baseDefinitionElement = value; OnPropertyChanged("BaseDefinitionElement"); }
        }

        private Canonical _baseDefinitionElement;

        /// <summary>
        /// Definition that this type is constrained/specialized from
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string BaseDefinition
        {
            get { return BaseDefinitionElement != null ? BaseDefinitionElement.Value : null; }
            set
            {
                if (value == null)
                    BaseDefinitionElement = null;
                else
                    BaseDefinitionElement = new Canonical(value);
                OnPropertyChanged("BaseDefinition");
            }
        }

        /// <summary>
        /// specialization | constraint - How relates to base definition
        /// </summary>
        [FhirElement("derivation", InSummary=true, Order=330)]
        [DataMember]
        public Code<TypeDerivationRule> DerivationElement
        {
            get { return _derivationElement; }
            set { _derivationElement = value; OnPropertyChanged("DerivationElement"); }
        }

        private Code<TypeDerivationRule> _derivationElement;

        /// <summary>
        /// specialization | constraint - How relates to base definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public TypeDerivationRule? Derivation
        {
            get { return DerivationElement != null ? DerivationElement.Value : null; }
            set
            {
                if (value == null)
                    DerivationElement = null;
                else
                    DerivationElement = new Code<TypeDerivationRule>(value);
                OnPropertyChanged("Derivation");
            }
        }

        /// <summary>
        /// Snapshot view of the structure
        /// </summary>
        [FhirElement("snapshot", Order=340)]
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
        [FhirElement("differential", Order=350)]
        [DataMember]
        public DifferentialComponent Differential
        {
            get { return _differential; }
            set { _differential = value; OnPropertyChanged("Differential"); }
        }

        private DifferentialComponent _differential;


        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_9 = new ElementDefinition.ConstraintComponent
        {
            Expression = "children().element.where(path.contains('.').not()).label.empty() and children().element.where(path.contains('.').not()).code.empty() and children().element.where(path.contains('.').not()).requirements.empty()",
            Key = "sdf-9",
            Severity = ConstraintSeverity.Warning,
            Human = "In any snapshot or differential, no label, code or requirements on an element without a \".\" in the path (e.g. the first element)",
            Xpath = "not(exists(f:snapshot/f:element[not(contains(f:path/@value, '.')) and (f:label or f:code or f:requirements)])) and not(exists(f:differential/f:element[not(contains(f:path/@value, '.')) and (f:label or f:code or f:requirements)]))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_19 = new ElementDefinition.ConstraintComponent
        {
            Expression = "kind = 'logical' or (differential.element.type.code.all(hasValue() implies matches('^[a-zA-Z0-9]+$')) and snapshot.element.type.code.all(hasValue() implies matches('^[a-zA-Z0-9]+$')))",
            Key = "sdf-19",
            Severity = ConstraintSeverity.Warning,
            Human = "Custom types can only be used in logical models",
            Xpath = "f:kind/@value = 'logical' or count(f:differential/f:element/f:type/f:code[@value and not(matches(string(@value), '^[a-zA-Z0-9]+$'))]|f:snapshot/f:element/f:type/f:code[@value and not(matches(string(@value), '^[a-zA-Z0-9]+$'))]) =0"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_16 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.element.all(id) and snapshot.element.id.trace('ids').isDistinct()",
            Key = "sdf-16",
            Severity = ConstraintSeverity.Warning,
            Human = "All element definitions must have unique ids (snapshot)",
            Xpath = "count(f:snapshot/f:element)=count(f:snapshot/f:element/@id) and (count(f:snapshot/f:element)=count(distinct-values(f:snapshot/f:element/@id)))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_18 = new ElementDefinition.ConstraintComponent
        {
            Expression = "contextInvariant.exists() implies type = 'Extension'",
            Key = "sdf-18",
            Severity = ConstraintSeverity.Warning,
            Human = "Context Invariants can only be used for extensions",
            Xpath = "not(exists(f:contextInvariant)) or (f:type/@value = 'Extension')"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_17 = new ElementDefinition.ConstraintComponent
        {
            Expression = "differential.element.all(id) and differential.element.id.trace('ids').isDistinct()",
            Key = "sdf-17",
            Severity = ConstraintSeverity.Warning,
            Human = "All element definitions must have unique ids (diff)",
            Xpath = "count(f:differential/f:element)=count(f:differential/f:element/@id) and (count(f:differential/f:element)=count(distinct-values(f:differential/f:element/@id)))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_12 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.exists() implies (snapshot.element.base.exists() = baseDefinition.exists())",
            Key = "sdf-12",
            Severity = ConstraintSeverity.Warning,
            Human = "element.base cannot appear if there is no base on the structure definition",
            Xpath = "f:baseDefinition or not(exists(f:snapshot/f:element/f:base) or exists(f:differential/f:element/f:base))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_11 = new ElementDefinition.ConstraintComponent
        {
            Expression = "kind != 'logical' implies snapshot.empty() or snapshot.element.first().path = type",
            Key = "sdf-11",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's a type, its content must match the path name in the first element of a snapshot",
            Xpath = "(f:kind/@value = 'logical') or not(exists(f:snapshot)) or (f:type/@value = f:snapshot/f:element[1]/f:path/@value)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_14 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.element.all(id.exists()) and differential.element.all(id.exists())",
            Key = "sdf-14",
            Severity = ConstraintSeverity.Warning,
            Human = "All element definitions must have an id",
            Xpath = "count(*/f:element)=count(*/f:element/@id)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "derivation = 'constraint' or snapshot.element.select(path).isDistinct()",
            Key = "sdf-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Element paths must be unique unless the structure is a constraint",
            Xpath = "(f:derivation/@value = 'constraint') or (count(f:snapshot/f:element) = count(distinct-values(f:snapshot/f:element/f:path/@value)))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_21 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(snapshot.element.defaultValue.exists() or differential.element.defaultValue.exists()) implies ((kind = 'logical') and (derivation = 'specialization'))",
            Key = "sdf-21",
            Severity = ConstraintSeverity.Warning,
            Human = "Default values can only be specified on logical models",
            Xpath = "(not(exists(f:snapshot/f:element/*[starts-with(local-name(), 'defaultValue')])) and not(exists(f:differential/f:element/*[starts-with(local-name(), 'defaultValue')]))) or ((f:kind/@value = 'logical') and (f:derivation/@value = 'specialization'))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(derivation = 'constraint') or (kind = 'logical') or (url = 'http://hl7.org/fhir/StructureDefinition/'+id)",
            Key = "sdf-7",
            Severity = ConstraintSeverity.Warning,
            Human = "If the structure describes a base Resource or Type, the URL has to start with \"http://hl7.org/fhir/StructureDefinition/\" and the tail must match the id",
            Xpath = "(f:derivation/@value = 'constraint') or (f:kind/@value = 'logical') or (f:url/@value=concat('http://hl7.org/fhir/StructureDefinition/', f:id/@value))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.exists() or differential.exists()",
            Key = "sdf-6",
            Severity = ConstraintSeverity.Warning,
            Human = "A structure must have either a differential, or a snapshot (or both)",
            Xpath = "exists(f:snapshot) or exists(f:differential)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "type != 'Extension' or derivation = 'specialization' or (context.exists())",
            Key = "sdf-5",
            Severity = ConstraintSeverity.Warning,
            Human = "If the structure defines an extension then the structure must have context information",
            Xpath = "not(f:type/@value = 'extension') or (f:derivation/@value = 'specialization') or (exists(f:context))"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "abstract = true or baseDefinition.exists()",
            Key = "sdf-4",
            Severity = ConstraintSeverity.Warning,
            Human = "If the structure is not abstract, then there SHALL be a baseDefinition",
            Xpath = "(f:abstract/@value=true()) or exists(f:baseDefinition)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "mapping.all(name.exists() or uri.exists())",
            Key = "sdf-2",
            Severity = ConstraintSeverity.Warning,
            Human = "Must have at least a name or a uri (or both)",
            Xpath = "exists(f:uri) or exists(f:name)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_15 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.all(element.first().type.empty())",
            Key = "sdf-15",
            Severity = ConstraintSeverity.Warning,
            Human = "The first element in a snapshot has no type",
            Xpath = "not(f:element[1]/f:type)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_8 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.all(element.first().path = %resource.type and element.tail().all(path.startsWith(%resource.type&'.')) and element.all(base.exists()))",
            Key = "sdf-8",
            Severity = ConstraintSeverity.Warning,
            Human = "In any snapshot, all the elements must be in the specified type, and must have a base definition",
            Xpath = "f:element[1]/f:path/@value=parent::f:StructureDefinition/f:type/@value and count(f:element[position()!=1])=count(f:element[position()!=1][starts-with(f:path/@value, concat(ancestor::f:StructureDefinition/f:type/@value, '.'))])"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.all(element.all(definition.exists() and min.exists() and max.exists()))",
            Key = "sdf-3",
            Severity = ConstraintSeverity.Warning,
            Human = "Each element definition in a snapshot must have a formal definition and cardinalities",
            Xpath = "count(f:element) = count(f:element[exists(f:definition) and exists(f:min) and exists(f:max)])"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_10 = new ElementDefinition.ConstraintComponent
        {
            Expression = "snapshot.element.all(binding.empty() or binding.valueSet.exists() or binding.description.exists())",
            Key = "sdf-10",
            Severity = ConstraintSeverity.Warning,
            Human = "provide either a binding reference or a description (or both)",
            Xpath = "not(exists(f:binding)) or (exists(f:binding/f:valueSetUri) or exists(f:binding/f:valueSetReference)) or exists(f:binding/f:description)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_15A = new ElementDefinition.ConstraintComponent
        {
            Expression = "differential.all(element.first().path.contains('.').not() implies element.first().type.empty())",
            Key = "sdf-15a",
            Severity = ConstraintSeverity.Warning,
            Human = "If the first element in a differential has no \".\" in the path, it has no type",
            Xpath = "not(f:element[1][not(contains(f:path/@value, '.'))]/f:type)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_20 = new ElementDefinition.ConstraintComponent
        {
            Expression = "differential.all(element.where(path.contains('.').not()).slicing.empty())",
            Key = "sdf-20",
            Severity = ConstraintSeverity.Warning,
            Human = "No slicing on the root element",
            Xpath = "not(f:element[1]/f:slicing)"
        };

        public static ElementDefinition.ConstraintComponent StructureDefinition_SDF_8A = new ElementDefinition.ConstraintComponent
        {
            Expression = "differential.all(element.first().path.startsWith(%resource.type) and element.tail().all(path.startsWith(%resource.type&'.')))",
            Key = "sdf-8a",
            Severity = ConstraintSeverity.Warning,
            Human = "In any differential, all the elements must be in the specified type",
            Xpath = "count(f:element)=count(f:element[f:path/@value=ancestor::f:StructureDefinition/f:type/@value or starts-with(f:path/@value, concat(ancestor::f:StructureDefinition/f:type/@value, '.'))])"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(StructureDefinition_SDF_9);
            InvariantConstraints.Add(StructureDefinition_SDF_19);
            InvariantConstraints.Add(StructureDefinition_SDF_16);
            InvariantConstraints.Add(StructureDefinition_SDF_18);
            InvariantConstraints.Add(StructureDefinition_SDF_17);
            InvariantConstraints.Add(StructureDefinition_SDF_12);
            InvariantConstraints.Add(StructureDefinition_SDF_11);
            InvariantConstraints.Add(StructureDefinition_SDF_14);
            InvariantConstraints.Add(StructureDefinition_SDF_1);
            InvariantConstraints.Add(StructureDefinition_SDF_21);
            InvariantConstraints.Add(StructureDefinition_SDF_7);
            InvariantConstraints.Add(StructureDefinition_SDF_6);
            InvariantConstraints.Add(StructureDefinition_SDF_5);
            InvariantConstraints.Add(StructureDefinition_SDF_4);
            InvariantConstraints.Add(StructureDefinition_SDF_2);
            InvariantConstraints.Add(StructureDefinition_SDF_15);
            InvariantConstraints.Add(StructureDefinition_SDF_8);
            InvariantConstraints.Add(StructureDefinition_SDF_3);
            InvariantConstraints.Add(StructureDefinition_SDF_10);
            InvariantConstraints.Add(StructureDefinition_SDF_15A);
            InvariantConstraints.Add(StructureDefinition_SDF_20);
            InvariantConstraints.Add(StructureDefinition_SDF_8A);
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
                if (Keyword != null) dest.Keyword = new List<Coding>(Keyword.DeepCopy());
                if (FhirVersionElement != null) dest.FhirVersionElement = (Id)FhirVersionElement.DeepCopy();
                if (Mapping != null) dest.Mapping = new List<MappingComponent>(Mapping.DeepCopy());
                if (KindElement != null) dest.KindElement = (Code<StructureDefinitionKind>)KindElement.DeepCopy();
                if (AbstractElement != null) dest.AbstractElement = (FhirBoolean)AbstractElement.DeepCopy();
                if (Context != null) dest.Context = new List<ContextComponent>(Context.DeepCopy());
                if (ContextInvariantElement != null) dest.ContextInvariantElement = new List<FhirString>(ContextInvariantElement.DeepCopy());
                if (TypeElement != null) dest.TypeElement = (FhirUri)TypeElement.DeepCopy();
                if (BaseDefinitionElement != null) dest.BaseDefinitionElement = (Canonical)BaseDefinitionElement.DeepCopy();
                if (DerivationElement != null) dest.DerivationElement = (Code<TypeDerivationRule>)DerivationElement.DeepCopy();
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
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
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
            if ( !DeepComparable.Matches(Keyword, otherT.Keyword)) return false;
            if (!DeepComparable.Matches(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if ( !DeepComparable.Matches(Mapping, otherT.Mapping)) return false;
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.Matches(AbstractElement, otherT.AbstractElement)) return false;
            if ( !DeepComparable.Matches(Context, otherT.Context)) return false;
            if ( !DeepComparable.Matches(ContextInvariantElement, otherT.ContextInvariantElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(BaseDefinitionElement, otherT.BaseDefinitionElement)) return false;
            if (!DeepComparable.Matches(DerivationElement, otherT.DerivationElement)) return false;
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
            if (!DeepComparable.IsExactly(Keyword, otherT.Keyword)) return false;
            if (!DeepComparable.IsExactly(FhirVersionElement, otherT.FhirVersionElement)) return false;
            if (!DeepComparable.IsExactly(Mapping, otherT.Mapping)) return false;
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(AbstractElement, otherT.AbstractElement)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(ContextInvariantElement, otherT.ContextInvariantElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(BaseDefinitionElement, otherT.BaseDefinitionElement)) return false;
            if (!DeepComparable.IsExactly(DerivationElement, otherT.DerivationElement)) return false;
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
                foreach (var elem in Keyword) { if (elem != null) yield return elem; }
                if (FhirVersionElement != null) yield return FhirVersionElement;
                foreach (var elem in Mapping) { if (elem != null) yield return elem; }
                if (KindElement != null) yield return KindElement;
                if (AbstractElement != null) yield return AbstractElement;
                foreach (var elem in Context) { if (elem != null) yield return elem; }
                foreach (var elem in ContextInvariantElement) { if (elem != null) yield return elem; }
                if (TypeElement != null) yield return TypeElement;
                if (BaseDefinitionElement != null) yield return BaseDefinitionElement;
                if (DerivationElement != null) yield return DerivationElement;
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
                if (UrlElement != null) yield return new ElementValue("url", false, UrlElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (VersionElement != null) yield return new ElementValue("version", false, VersionElement);
                if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                if (TitleElement != null) yield return new ElementValue("title", false, TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", false, ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", false, PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", true, elem); }
                if (Description != null) yield return new ElementValue("description", false, Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", true, elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", true, elem); }
                if (Purpose != null) yield return new ElementValue("purpose", false, Purpose);
                if (Copyright != null) yield return new ElementValue("copyright", false, Copyright);
                foreach (var elem in Keyword) { if (elem != null) yield return new ElementValue("keyword", true, elem); }
                if (FhirVersionElement != null) yield return new ElementValue("fhirVersion", false, FhirVersionElement);
                foreach (var elem in Mapping) { if (elem != null) yield return new ElementValue("mapping", true, elem); }
                if (KindElement != null) yield return new ElementValue("kind", false, KindElement);
                if (AbstractElement != null) yield return new ElementValue("abstract", false, AbstractElement);
                foreach (var elem in Context) { if (elem != null) yield return new ElementValue("context", true, elem); }
                foreach (var elem in ContextInvariantElement) { if (elem != null) yield return new ElementValue("contextInvariant", true, elem); }
                if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                if (BaseDefinitionElement != null) yield return new ElementValue("baseDefinition", false, BaseDefinitionElement);
                if (DerivationElement != null) yield return new ElementValue("derivation", false, DerivationElement);
                if (Snapshot != null) yield return new ElementValue("snapshot", false, Snapshot);
                if (Differential != null) yield return new ElementValue("differential", false, Differential);
            }
        }

    }

}
