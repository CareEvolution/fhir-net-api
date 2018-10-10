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
    /// A structured set of questions
    /// </summary>
    [FhirType("Questionnaire", IsResource=true)]
    [DataContract]
    public partial class Questionnaire : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Questionnaire; } }
        [NotMapped]
        public override string TypeName { get { return "Questionnaire"; } }

        /// <summary>
        /// Lifecycle status of the questionnaire.
        /// (url: http://hl7.org/fhir/ValueSet/questionnaire-status)
        /// </summary>
        [FhirEnumeration("QuestionnaireStatus")]
        public enum QuestionnaireStatus
        {
            /// <summary>
            /// This Questionnaire is not ready for official use.
            /// (system: http://hl7.org/fhir/questionnaire-status)
            /// </summary>
            [EnumLiteral("draft", "http://hl7.org/fhir/questionnaire-status"), Description("Draft")]
            Draft,
            /// <summary>
            /// This Questionnaire is ready for use.
            /// (system: http://hl7.org/fhir/questionnaire-status)
            /// </summary>
            [EnumLiteral("published", "http://hl7.org/fhir/questionnaire-status"), Description("Published")]
            Published,
            /// <summary>
            /// This Questionnaire should no longer be used to gather data.
            /// (system: http://hl7.org/fhir/questionnaire-status)
            /// </summary>
            [EnumLiteral("retired", "http://hl7.org/fhir/questionnaire-status"), Description("Retired")]
            Retired,
        }

        /// <summary>
        /// The expected format of an answer.
        /// (url: http://hl7.org/fhir/ValueSet/answer-format)
        /// </summary>
        [FhirEnumeration("AnswerFormat")]
        public enum AnswerFormat
        {
            /// <summary>
            /// Answer is a yes/no answer.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("boolean", "http://hl7.org/fhir/answer-format"), Description("Boolean")]
            Boolean,
            /// <summary>
            /// Answer is a floating point number.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("decimal", "http://hl7.org/fhir/answer-format"), Description("Decimal")]
            Decimal,
            /// <summary>
            /// Answer is an integer.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("integer", "http://hl7.org/fhir/answer-format"), Description("Integer")]
            Integer,
            /// <summary>
            /// Answer is a date.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("date", "http://hl7.org/fhir/answer-format"), Description("Date")]
            Date,
            /// <summary>
            /// Answer is a date and time.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("dateTime", "http://hl7.org/fhir/answer-format"), Description("Date Time")]
            DateTime,
            /// <summary>
            /// Answer is a system timestamp.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("instant", "http://hl7.org/fhir/answer-format"), Description("Instant")]
            Instant,
            /// <summary>
            /// Answer is a time (hour/minute/second) independent of date.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("time", "http://hl7.org/fhir/answer-format"), Description("Time")]
            Time,
            /// <summary>
            /// Answer is a short (few words to short sentence) free-text entry.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("string", "http://hl7.org/fhir/answer-format"), Description("String")]
            String,
            /// <summary>
            /// Answer is a long (potentially multi-paragraph) free-text entry (still captured as a string).
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("text", "http://hl7.org/fhir/answer-format"), Description("Text")]
            Text,
            /// <summary>
            /// Answer is a url (website, FTP site, etc.).
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("url", "http://hl7.org/fhir/answer-format"), Description("Url")]
            Url,
            /// <summary>
            /// Answer is a Coding drawn from a list of options.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("choice", "http://hl7.org/fhir/answer-format"), Description("Choice")]
            Choice,
            /// <summary>
            /// Answer is a Coding drawn from a list of options or a free-text entry.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("open-choice", "http://hl7.org/fhir/answer-format"), Description("Open Choice")]
            OpenChoice,
            /// <summary>
            /// Answer is binary content such as a image, PDF, etc.
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("attachment", "http://hl7.org/fhir/answer-format"), Description("Attachment")]
            Attachment,
            /// <summary>
            /// Answer is a reference to another resource (practitioner, organization, etc.).
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("reference", "http://hl7.org/fhir/answer-format"), Description("Reference")]
            Reference,
            /// <summary>
            /// Answer is a combination of a numeric value and unit, potentially with a comparator (&lt;, &gt;, etc.).
            /// (system: http://hl7.org/fhir/answer-format)
            /// </summary>
            [EnumLiteral("quantity", "http://hl7.org/fhir/answer-format"), Description("Quantity")]
            Quantity,
        }


        [FhirType("GroupComponent")]
        [DataContract]
        public partial class GroupComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GroupComponent"; } }

            /// <summary>
            /// To link questionnaire with questionnaire response
            /// </summary>
            [FhirElement("linkId", Order=40)]
            [DataMember]
            public FhirString LinkIdElement
            {
                get { return _linkIdElement; }
                set { _linkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }

            private FhirString _linkIdElement;

            /// <summary>
            /// To link questionnaire with questionnaire response
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
            /// Name to be displayed for group
            /// </summary>
            [FhirElement("title", InSummary=true, Order=50)]
            [DataMember]
            public FhirString TitleElement
            {
                get { return _titleElement; }
                set { _titleElement = value; OnPropertyChanged("TitleElement"); }
            }

            private FhirString _titleElement;

            /// <summary>
            /// Name to be displayed for group
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
            /// Concept that represents this section in a questionnaire
            /// </summary>
            [FhirElement("concept", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Concept
            {
                get { if (_concept == null) _concept = new List<Coding>(); return _concept; }
                set { _concept = value; OnPropertyChanged("Concept"); }
            }

            private List<Coding> _concept;

            /// <summary>
            /// Additional text for the group
            /// </summary>
            [FhirElement("text", Order=70)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Additional text for the group
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
            /// Whether the group must be included in data results
            /// </summary>
            [FhirElement("required", Order=80)]
            [DataMember]
            public FhirBoolean RequiredElement
            {
                get { return _requiredElement; }
                set { _requiredElement = value; OnPropertyChanged("RequiredElement"); }
            }

            private FhirBoolean _requiredElement;

            /// <summary>
            /// Whether the group must be included in data results
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Required
            {
                get { return RequiredElement != null ? RequiredElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        RequiredElement = null;
                    else
                        RequiredElement = new FhirBoolean(value);
                    OnPropertyChanged("Required");
                }
            }

            /// <summary>
            /// Whether the group may repeat
            /// </summary>
            [FhirElement("repeats", Order=90)]
            [DataMember]
            public FhirBoolean RepeatsElement
            {
                get { return _repeatsElement; }
                set { _repeatsElement = value; OnPropertyChanged("RepeatsElement"); }
            }

            private FhirBoolean _repeatsElement;

            /// <summary>
            /// Whether the group may repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Repeats
            {
                get { return RepeatsElement != null ? RepeatsElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        RepeatsElement = null;
                    else
                        RepeatsElement = new FhirBoolean(value);
                    OnPropertyChanged("Repeats");
                }
            }

            /// <summary>
            /// Nested questionnaire group
            /// </summary>
            [FhirElement("group", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<GroupComponent> Group
            {
                get { if (_group == null) _group = new List<GroupComponent>(); return _group; }
                set { _group = value; OnPropertyChanged("Group"); }
            }

            private List<GroupComponent> _group;

            /// <summary>
            /// Questions in this group
            /// </summary>
            [FhirElement("question", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<QuestionComponent> Question
            {
                get { if (_question == null) _question = new List<QuestionComponent>(); return _question; }
                set { _question = value; OnPropertyChanged("Question"); }
            }

            private List<QuestionComponent> _question;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GroupComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LinkIdElement != null) dest.LinkIdElement = (FhirString)LinkIdElement.DeepCopy();
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    if (Concept != null) dest.Concept = new List<Coding>(Concept.DeepCopy());
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (RequiredElement != null) dest.RequiredElement = (FhirBoolean)RequiredElement.DeepCopy();
                    if (RepeatsElement != null) dest.RepeatsElement = (FhirBoolean)RepeatsElement.DeepCopy();
                    if (Group != null) dest.Group = new List<GroupComponent>(Group.DeepCopy());
                    if (Question != null) dest.Question = new List<QuestionComponent>(Question.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GroupComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GroupComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.Matches(Concept, otherT.Concept)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.Matches(RepeatsElement, otherT.RepeatsElement)) return false;
                if (!DeepComparable.Matches(Group, otherT.Group)) return false;
                if (!DeepComparable.Matches(Question, otherT.Question)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GroupComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.IsExactly(Concept, otherT.Concept)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.IsExactly(RepeatsElement, otherT.RepeatsElement)) return false;
                if (!DeepComparable.IsExactly(Group, otherT.Group)) return false;
                if (!DeepComparable.IsExactly(Question, otherT.Question)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LinkIdElement != null) yield return LinkIdElement;
                    if (TitleElement != null) yield return TitleElement;
                    foreach (var elem in Concept) { if (elem != null) yield return elem; }
                    if (TextElement != null) yield return TextElement;
                    if (RequiredElement != null) yield return RequiredElement;
                    if (RepeatsElement != null) yield return RepeatsElement;
                    foreach (var elem in Group) { if (elem != null) yield return elem; }
                    foreach (var elem in Question) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LinkIdElement != null) yield return new ElementValue("linkId", LinkIdElement);
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                    foreach (var elem in Concept) { if (elem != null) yield return new ElementValue("concept", elem); }
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    if (RequiredElement != null) yield return new ElementValue("required", RequiredElement);
                    if (RepeatsElement != null) yield return new ElementValue("repeats", RepeatsElement);
                    foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", elem); }
                    foreach (var elem in Question) { if (elem != null) yield return new ElementValue("question", elem); }
                }
            }


        }


        [FhirType("QuestionComponent")]
        [DataContract]
        public partial class QuestionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "QuestionComponent"; } }

            /// <summary>
            /// To link questionnaire with questionnaire response
            /// </summary>
            [FhirElement("linkId", Order=40)]
            [DataMember]
            public FhirString LinkIdElement
            {
                get { return _linkIdElement; }
                set { _linkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }

            private FhirString _linkIdElement;

            /// <summary>
            /// To link questionnaire with questionnaire response
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
            /// Concept that represents this question on a questionnaire
            /// </summary>
            [FhirElement("concept", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Concept
            {
                get { if (_concept == null) _concept = new List<Coding>(); return _concept; }
                set { _concept = value; OnPropertyChanged("Concept"); }
            }

            private List<Coding> _concept;

            /// <summary>
            /// Text of the question as it is shown to the user
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
            /// Text of the question as it is shown to the user
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
            /// boolean | decimal | integer | date | dateTime +
            /// </summary>
            [FhirElement("type", Order=70)]
            [DataMember]
            public Code<AnswerFormat> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<AnswerFormat> _typeElement;

            /// <summary>
            /// boolean | decimal | integer | date | dateTime +
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AnswerFormat? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        TypeElement = null;
                    else
                        TypeElement = new Code<AnswerFormat>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Whether the question must be answered in data results
            /// </summary>
            [FhirElement("required", Order=80)]
            [DataMember]
            public FhirBoolean RequiredElement
            {
                get { return _requiredElement; }
                set { _requiredElement = value; OnPropertyChanged("RequiredElement"); }
            }

            private FhirBoolean _requiredElement;

            /// <summary>
            /// Whether the question must be answered in data results
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Required
            {
                get { return RequiredElement != null ? RequiredElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        RequiredElement = null;
                    else
                        RequiredElement = new FhirBoolean(value);
                    OnPropertyChanged("Required");
                }
            }

            /// <summary>
            /// Whether the question  can have multiple answers
            /// </summary>
            [FhirElement("repeats", Order=90)]
            [DataMember]
            public FhirBoolean RepeatsElement
            {
                get { return _repeatsElement; }
                set { _repeatsElement = value; OnPropertyChanged("RepeatsElement"); }
            }

            private FhirBoolean _repeatsElement;

            /// <summary>
            /// Whether the question  can have multiple answers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Repeats
            {
                get { return RepeatsElement != null ? RepeatsElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        RepeatsElement = null;
                    else
                        RepeatsElement = new FhirBoolean(value);
                    OnPropertyChanged("Repeats");
                }
            }

            /// <summary>
            /// Valueset containing permitted answers
            /// </summary>
            [FhirElement("options", Order=100)]
            [References("ValueSet")]
            [DataMember]
            public ResourceReference Options
            {
                get { return _options; }
                set { _options = value; OnPropertyChanged("Options"); }
            }

            private ResourceReference _options;

            /// <summary>
            /// Permitted answer
            /// </summary>
            [FhirElement("option", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Option
            {
                get { if (_option == null) _option = new List<Coding>(); return _option; }
                set { _option = value; OnPropertyChanged("Option"); }
            }

            private List<Coding> _option;

            /// <summary>
            /// Nested questionnaire group
            /// </summary>
            [FhirElement("group", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<GroupComponent> Group
            {
                get { if (_group == null) _group = new List<GroupComponent>(); return _group; }
                set { _group = value; OnPropertyChanged("Group"); }
            }

            private List<GroupComponent> _group;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as QuestionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LinkIdElement != null) dest.LinkIdElement = (FhirString)LinkIdElement.DeepCopy();
                    if (Concept != null) dest.Concept = new List<Coding>(Concept.DeepCopy());
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<AnswerFormat>)TypeElement.DeepCopy();
                    if (RequiredElement != null) dest.RequiredElement = (FhirBoolean)RequiredElement.DeepCopy();
                    if (RepeatsElement != null) dest.RepeatsElement = (FhirBoolean)RepeatsElement.DeepCopy();
                    if (Options != null) dest.Options = (ResourceReference)Options.DeepCopy();
                    if (Option != null) dest.Option = new List<Coding>(Option.DeepCopy());
                    if (Group != null) dest.Group = new List<GroupComponent>(Group.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new QuestionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as QuestionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.Matches(Concept, otherT.Concept)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.Matches(RepeatsElement, otherT.RepeatsElement)) return false;
                if (!DeepComparable.Matches(Options, otherT.Options)) return false;
                if (!DeepComparable.Matches(Option, otherT.Option)) return false;
                if (!DeepComparable.Matches(Group, otherT.Group)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as QuestionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(LinkIdElement, otherT.LinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Concept, otherT.Concept)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.IsExactly(RepeatsElement, otherT.RepeatsElement)) return false;
                if (!DeepComparable.IsExactly(Options, otherT.Options)) return false;
                if (!DeepComparable.IsExactly(Option, otherT.Option)) return false;
                if (!DeepComparable.IsExactly(Group, otherT.Group)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (LinkIdElement != null) yield return LinkIdElement;
                    foreach (var elem in Concept) { if (elem != null) yield return elem; }
                    if (TextElement != null) yield return TextElement;
                    if (TypeElement != null) yield return TypeElement;
                    if (RequiredElement != null) yield return RequiredElement;
                    if (RepeatsElement != null) yield return RepeatsElement;
                    if (Options != null) yield return Options;
                    foreach (var elem in Option) { if (elem != null) yield return elem; }
                    foreach (var elem in Group) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (LinkIdElement != null) yield return new ElementValue("linkId", LinkIdElement);
                    foreach (var elem in Concept) { if (elem != null) yield return new ElementValue("concept", elem); }
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (RequiredElement != null) yield return new ElementValue("required", RequiredElement);
                    if (RepeatsElement != null) yield return new ElementValue("repeats", RepeatsElement);
                    if (Options != null) yield return new ElementValue("options", Options);
                    foreach (var elem in Option) { if (elem != null) yield return new ElementValue("option", elem); }
                    foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", elem); }
                }
            }


        }


        /// <summary>
        /// External identifiers for this questionnaire
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Logical identifier for this version of Questionnaire
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
        /// Logical identifier for this version of Questionnaire
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
        /// draft | published | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<QuestionnaireStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<QuestionnaireStatus> _statusElement;

        /// <summary>
        /// draft | published | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public QuestionnaireStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<QuestionnaireStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Date this version was authored
        /// </summary>
        [FhirElement("date", InSummary=true, Order=120)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date this version was authored
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
        /// Organization/individual who designed the questionnaire
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=130)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Organization/individual who designed the questionnaire
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
        /// Contact information of the publisher
        /// </summary>
        [FhirElement("telecom", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Telecom
        {
            get { if (_telecom == null) _telecom = new List<ContactPoint>(); return _telecom; }
            set { _telecom = value; OnPropertyChanged("Telecom"); }
        }

        private List<ContactPoint> _telecom;

        /// <summary>
        /// Resource that can be subject of QuestionnaireResponse
        /// </summary>
        [FhirElement("subjectType", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<ResourceType>> SubjectTypeElement
        {
            get { if (_subjectTypeElement == null) _subjectTypeElement = new List<Code<ResourceType>>(); return _subjectTypeElement; }
            set { _subjectTypeElement = value; OnPropertyChanged("SubjectTypeElement"); }
        }

        private List<Code<ResourceType>> _subjectTypeElement;

        /// <summary>
        /// Resource that can be subject of QuestionnaireResponse
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<ResourceType?> SubjectType
        {
            get { return SubjectTypeElement != null ? SubjectTypeElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    SubjectTypeElement = null;
                else
                    SubjectTypeElement = new List<Code<ResourceType>>(value.Select(elem=>new Code<ResourceType>(elem)));
                OnPropertyChanged("SubjectType");
            }
        }

        /// <summary>
        /// Grouped questions
        /// </summary>
        [FhirElement("group", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public GroupComponent Group
        {
            get { return _group; }
            set { _group = value; OnPropertyChanged("Group"); }
        }

        private GroupComponent _group;


        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "group.required = true",
            Key = "que-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If root group must be \"required\"",
            Xpath = "f:group/f:required/@value=true()"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "descendants().linkId.isDistinct()",
            Key = "que-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "The link ids for groups and questions must be unique within the questionnaire",
            Xpath = "count(descendant::f:linkId/@value)=count(distinct-values(descendant::f:linkId/@value))"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "group.all(group.empty() or question.empty())",
            Key = "que-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Groups may either contain questions or groups but not both",
            Xpath = "not(exists(f:group) and exists(f:question))"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "group.question.all(option.empty() or options.empty())",
            Key = "que-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A question must use either option or options, not both",
            Xpath = "not(f:options and f:option)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Questionnaire_QUE_3);
            InvariantConstraints.Add(Questionnaire_QUE_2);
            InvariantConstraints.Add(Questionnaire_QUE_1);
            InvariantConstraints.Add(Questionnaire_QUE_4);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Questionnaire;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<QuestionnaireStatus>)StatusElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (SubjectTypeElement != null) dest.SubjectTypeElement = new List<Code<ResourceType>>(SubjectTypeElement.DeepCopy());
                if (Group != null) dest.Group = (GroupComponent)Group.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Questionnaire());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Questionnaire;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.Matches(SubjectTypeElement, otherT.SubjectTypeElement)) return false;
            if (!DeepComparable.Matches(Group, otherT.Group)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Questionnaire;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(SubjectTypeElement, otherT.SubjectTypeElement)) return false;
            if (!DeepComparable.IsExactly(Group, otherT.Group)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (VersionElement != null) yield return VersionElement;
                if (StatusElement != null) yield return StatusElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                foreach (var elem in SubjectTypeElement) { if (elem != null) yield return elem; }
                if (Group != null) yield return Group;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                foreach (var elem in SubjectTypeElement) { if (elem != null) yield return new ElementValue("subjectType", elem); }
                if (Group != null) yield return new ElementValue("group", Group);
            }
        }

    }

}
