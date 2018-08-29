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
    /// A list that defines a set of documents
    /// </summary>
    [FhirType("DocumentManifest", IsResource=true)]
    [DataContract]
    public partial class DocumentManifest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DocumentManifest; } }
        [NotMapped]
        public override string TypeName { get { return "DocumentManifest"; } }


        [FhirType("ContentComponent")]
        [DataContract]
        public partial class ContentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContentComponent"; } }

            /// <summary>
            /// Contents of this set of documents
            /// </summary>
            [FhirElement("p", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element P
            {
                get { return _p; }
                set { _p = value; OnPropertyChanged("P"); }
            }

            private Element _p;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (P != null) dest.P = (Element)P.DeepCopy();
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
                if (!DeepComparable.Matches(P, otherT.P)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(P, otherT.P)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (P != null) yield return P;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (P != null) yield return new ElementValue("p", P);
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
            /// Identifiers of things that are related
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
        /// Unique Identifier for the set of documents
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
        /// Other identifiers for the manifest
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
        /// Kind of document set
        /// </summary>
        [FhirElement("type", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// The subject of the set of documents
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=130)]
        [References("Patient","Practitioner","Group","Device")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// When this document manifest created
        /// </summary>
        [FhirElement("created", InSummary=true, Order=140)]
        [DataMember]
        public FhirDateTime CreatedElement
        {
            get { return _createdElement; }
            set { _createdElement = value; OnPropertyChanged("CreatedElement"); }
        }

        private FhirDateTime _createdElement;

        /// <summary>
        /// When this document manifest created
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
        /// Who and/or what authored the manifest
        /// </summary>
        [FhirElement("author", InSummary=true, Order=150)]
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
        /// Intended to get notified about this set of documents
        /// </summary>
        [FhirElement("recipient", InSummary=true, Order=160)]
        [References("Patient","Practitioner","RelatedPerson","Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Recipient
        {
            get { if (_recipient==null) _recipient = new List<ResourceReference>(); return _recipient; }
            set { _recipient = value; OnPropertyChanged("Recipient"); }
        }

        private List<ResourceReference> _recipient;

        /// <summary>
        /// The source system/application/software
        /// </summary>
        [FhirElement("source", InSummary=true, Order=170)]
        [DataMember]
        public FhirUri SourceElement
        {
            get { return _sourceElement; }
            set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
        }

        private FhirUri _sourceElement;

        /// <summary>
        /// The source system/application/software
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Source
        {
            get { return SourceElement != null ? SourceElement.Value : null; }
            set
            {
                if (value == null)
                    SourceElement = null;
                else
                    SourceElement = new FhirUri(value);
                OnPropertyChanged("Source");
            }
        }

        /// <summary>
        /// Human-readable description (title)
        /// </summary>
        [FhirElement("description", InSummary=true, Order=180)]
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
        /// The items included
        /// </summary>
        [FhirElement("content", InSummary=true, Order=190)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<ContentComponent> Content
        {
            get { if (_content==null) _content = new List<ContentComponent>(); return _content; }
            set { _content = value; OnPropertyChanged("Content"); }
        }

        private List<ContentComponent> _content;

        /// <summary>
        /// Related things
        /// </summary>
        [FhirElement("related", InSummary=true, Order=200)]
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
            var dest = other as DocumentManifest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (MasterIdentifier != null) dest.MasterIdentifier = (Identifier)MasterIdentifier.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<DocumentReferenceStatus>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Author != null) dest.Author = new List<ResourceReference>(Author.DeepCopy());
                if (Recipient != null) dest.Recipient = new List<ResourceReference>(Recipient.DeepCopy());
                if (SourceElement != null) dest.SourceElement = (FhirUri)SourceElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Content != null) dest.Content = new List<ContentComponent>(Content.DeepCopy());
                if (Related != null) dest.Related = new List<RelatedComponent>(Related.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new DocumentManifest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DocumentManifest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(MasterIdentifier, otherT.MasterIdentifier)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if ( !DeepComparable.Matches(Author, otherT.Author)) return false;
            if ( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(Content, otherT.Content)) return false;
            if ( !DeepComparable.Matches(Related, otherT.Related)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DocumentManifest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(MasterIdentifier, otherT.MasterIdentifier)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;
            if (!DeepComparable.IsExactly(Related, otherT.Related)) return false;

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
                if (Type != null) yield return Type;
                if (Subject != null) yield return Subject;
                if (CreatedElement != null) yield return CreatedElement;
                foreach (var elem in Author) { if (elem != null) yield return elem; }
                foreach (var elem in Recipient) { if (elem != null) yield return elem; }
                if (SourceElement != null) yield return SourceElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in Content) { if (elem != null) yield return elem; }
                foreach (var elem in Related) { if (elem != null) yield return elem; }
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
                if (Type != null) yield return new ElementValue("type", Type);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                foreach (var elem in Author) { if (elem != null) yield return new ElementValue("author", elem); }
                foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", elem); }
                if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in Content) { if (elem != null) yield return new ElementValue("content", elem); }
                foreach (var elem in Related) { if (elem != null) yield return new ElementValue("related", elem); }
            }
        }

    }

}
