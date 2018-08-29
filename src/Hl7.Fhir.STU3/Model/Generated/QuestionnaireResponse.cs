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
    /// A structured set of questions and their answers
    /// </summary>
    [FhirType("QuestionnaireResponse", IsResource=true)]
    [DataContract]
    public partial class QuestionnaireResponse : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.QuestionnaireResponse; } }
        [NotMapped]
        public override string TypeName { get { return "QuestionnaireResponse"; } }


        [FhirType("ItemComponent")]
        [DataContract]
        public partial class ItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemComponent"; } }

            /// <summary>
            /// Pointer to specific item from Questionnaire
            /// </summary>
            [FhirElement("linkId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString LinkIdElement
            {
                get { return _linkIdElement; }
                set { _linkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }

            private FhirString _linkIdElement;

            /// <summary>
            /// Pointer to specific item from Questionnaire
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string LinkId
            {
                get { return LinkIdElement != null ? LinkIdElement.Value : null; }
                set
                {
                    if (value == null)
                        LinkIdElement = null;
                    else
                        LinkIdElement = new FhirString(value);
                    OnPropertyChanged("LinkId");
                }
            }

            /// <summary>
            /// ElementDefinition - details for the item
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
            /// ElementDefinition - details for the item
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
            /// Name for group or question text
            /// </summary>
            [FhirElement("text", Order=60)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Name for group or question text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new FhirString(value);
                    OnPropertyChanged("Text");
                }
            }

            /// <summary>
            /// The subject this group's answers are about
            /// </summary>
            [FhirElement("subject", Order=70)]
            [DataMember]
            public ResourceReference Subject
            {
                get { return _subject; }
                set { _subject = value; OnPropertyChanged("Subject"); }
            }

            private ResourceReference _subject;

            /// <summary>
            /// The response(s) to the question
            /// </summary>
            [FhirElement("answer", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AnswerComponent> Answer
            {
                get { if (_answer==null) _answer = new List<AnswerComponent>(); return _answer; }
                set { _answer = value; OnPropertyChanged("Answer"); }
            }

            private List<AnswerComponent> _answer;

            /// <summary>
            /// Nested questionnaire response items
            /// </summary>
            [FhirElement("item", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ItemComponent> Item
            {
                get { if (_item==null) _item = new List<ItemComponent>(); return _item; }
                set { _item = value; OnPropertyChanged("Item"); }
            }

            private List<ItemComponent> _item;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LinkIdElement != null) dest.LinkIdElement = (FhirString)LinkIdElement.DeepCopy();
                    if (DefinitionElement != null) dest.DefinitionElement = (FhirUri)DefinitionElement.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                    if (Answer != null) dest.Answer = new List<AnswerComponent>(Answer.DeepCopy());
                    if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
                if ( !DeepComparable.Matches(Answer, otherT.Answer)) return false;
                if ( !DeepComparable.Matches(Item, otherT.Item)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
                if (!DeepComparable.IsExactly(Answer, otherT.Answer)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LinkIdElement != null) yield return LinkIdElement;
                    if (DefinitionElement != null) yield return DefinitionElement;
                    if (TextElement != null) yield return TextElement;
                    if (Subject != null) yield return Subject;
                    foreach (var elem in Answer) { if (elem != null) yield return elem; }
                    foreach (var elem in Item) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LinkIdElement != null) yield return new ElementValue("linkId", LinkIdElement);
                    if (DefinitionElement != null) yield return new ElementValue("definition", DefinitionElement);
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    if (Subject != null) yield return new ElementValue("subject", Subject);
                    foreach (var elem in Answer) { if (elem != null) yield return new ElementValue("answer", elem); }
                    foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
                }
            }


        }


        [FhirType("AnswerComponent")]
        [DataContract]
        public partial class AnswerComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AnswerComponent"; } }

            /// <summary>
            /// Single-valued answer to the question
            /// </summary>
            [FhirElement("value", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(FhirDecimal),typeof(Integer),typeof(Date),typeof(FhirDateTime),typeof(Time),typeof(FhirString),typeof(FhirUri),typeof(Attachment),typeof(Coding),typeof(Quantity),typeof(ResourceReference))]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            /// <summary>
            /// Nested groups and questions
            /// </summary>
            [FhirElement("item", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ItemComponent> Item
            {
                get { if (_item==null) _item = new List<ItemComponent>(); return _item; }
                set { _item = value; OnPropertyChanged("Item"); }
            }

            private List<ItemComponent> _item;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AnswerComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AnswerComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AnswerComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;
                if ( !DeepComparable.Matches(Item, otherT.Item)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AnswerComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Value != null) yield return Value;
                    foreach (var elem in Item) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Value != null) yield return new ElementValue("value", Value);
                    foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
                }
            }


        }


        /// <summary>
        /// Unique id for this set of answers
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Request fulfilled by this QuestionnaireResponse
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=100)]
        [References("ReferralRequest","CarePlan","ProcedureRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Part of this action
        /// </summary>
        [FhirElement("parent", InSummary=true, Order=110)]
        [References("Observation","Procedure")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Parent
        {
            get { if (_parent==null) _parent = new List<ResourceReference>(); return _parent; }
            set { _parent = value; OnPropertyChanged("Parent"); }
        }

        private List<ResourceReference> _parent;

        /// <summary>
        /// Form being answered
        /// </summary>
        [FhirElement("questionnaire", InSummary=true, Order=120)]
        [References("Questionnaire")]
        [DataMember]
        public ResourceReference Questionnaire
        {
            get { return _questionnaire; }
            set { _questionnaire = value; OnPropertyChanged("Questionnaire"); }
        }

        private ResourceReference _questionnaire;

        /// <summary>
        /// in-progress | completed | amended | entered-in-error | stopped
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<QuestionnaireResponseStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<QuestionnaireResponseStatus> _statusElement;

        /// <summary>
        /// in-progress | completed | amended | entered-in-error | stopped
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public QuestionnaireResponseStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<QuestionnaireResponseStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The subject of the questions
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=140)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Encounter or Episode during which questionnaire was completed
        /// </summary>
        [FhirElement("context", InSummary=true, Order=150)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// Date the answers were gathered
        /// </summary>
        [FhirElement("authored", InSummary=true, Order=160)]
        [DataMember]
        public FhirDateTime AuthoredElement
        {
            get { return _authoredElement; }
            set { _authoredElement = value; OnPropertyChanged("AuthoredElement"); }
        }

        private FhirDateTime _authoredElement;

        /// <summary>
        /// Date the answers were gathered
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Authored
        {
            get { return AuthoredElement != null ? AuthoredElement.Value : null; }
            set
            {
                if (value == null)
                    AuthoredElement = null;
                else
                    AuthoredElement = new FhirDateTime(value);
                OnPropertyChanged("Authored");
            }
        }

        /// <summary>
        /// Person who received and recorded the answers
        /// </summary>
        [FhirElement("author", InSummary=true, Order=170)]
        [References("Device","Practitioner","Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// The person who answered the questions
        /// </summary>
        [FhirElement("source", InSummary=true, Order=180)]
        [References("Patient","Practitioner","RelatedPerson")]
        [DataMember]
        public ResourceReference Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private ResourceReference _source;

        /// <summary>
        /// Groups and questions
        /// </summary>
        [FhirElement("item", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ItemComponent> Item
        {
            get { if (_item==null) _item = new List<ItemComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<ItemComponent> _item;


        public static ElementDefinition.ConstraintComponent QuestionnaireResponse_QRS_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all((answer.exists() and item.exists()).not())",
            Key = "qrs-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Nested item can't be beneath both item and answer",
            Xpath = "not(exists(f:answer) and exists(f:item))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(QuestionnaireResponse_QRS_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as QuestionnaireResponse;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (Parent != null) dest.Parent = new List<ResourceReference>(Parent.DeepCopy());
                if (Questionnaire != null) dest.Questionnaire = (ResourceReference)Questionnaire.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<QuestionnaireResponseStatus>)StatusElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (AuthoredElement != null) dest.AuthoredElement = (FhirDateTime)AuthoredElement.DeepCopy();
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (Source != null) dest.Source = (ResourceReference)Source.DeepCopy();
                if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new QuestionnaireResponse());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as QuestionnaireResponse;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(Parent, otherT.Parent)) return false;
            if (!DeepComparable.Matches(Questionnaire, otherT.Questionnaire)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(AuthoredElement, otherT.AuthoredElement)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if ( !DeepComparable.Matches(Item, otherT.Item)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as QuestionnaireResponse;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Parent, otherT.Parent)) return false;
            if (!DeepComparable.IsExactly(Questionnaire, otherT.Questionnaire)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(AuthoredElement, otherT.AuthoredElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in Parent) { if (elem != null) yield return elem; }
                if (Questionnaire != null) yield return Questionnaire;
                if (StatusElement != null) yield return StatusElement;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (AuthoredElement != null) yield return AuthoredElement;
                if (Author != null) yield return Author;
                if (Source != null) yield return Source;
                foreach (var elem in Item) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                foreach (var elem in Parent) { if (elem != null) yield return new ElementValue("parent", elem); }
                if (Questionnaire != null) yield return new ElementValue("questionnaire", Questionnaire);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (AuthoredElement != null) yield return new ElementValue("authored", AuthoredElement);
                if (Author != null) yield return new ElementValue("author", Author);
                if (Source != null) yield return new ElementValue("source", Source);
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
            }
        }

    }

}
