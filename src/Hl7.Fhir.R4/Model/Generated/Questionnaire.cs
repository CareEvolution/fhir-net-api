﻿using System;
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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
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
        /// Distinguishes groups from questions and display text and indicates data type for questions.
        /// (url: http://hl7.org/fhir/ValueSet/item-type)
        /// </summary>
        [FhirEnumeration("QuestionnaireItemType")]
        public enum QuestionnaireItemType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("group", "http://hl7.org/fhir/item-type"), Description("Group")]
            Group,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("display", "http://hl7.org/fhir/item-type"), Description("Display")]
            Display,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("boolean", "http://hl7.org/fhir/item-type"), Description("Boolean")]
            Boolean,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("decimal", "http://hl7.org/fhir/item-type"), Description("Decimal")]
            Decimal,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("integer", "http://hl7.org/fhir/item-type"), Description("Integer")]
            Integer,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("date", "http://hl7.org/fhir/item-type"), Description("Date")]
            Date,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("dateTime", "http://hl7.org/fhir/item-type"), Description("Date Time")]
            DateTime,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("time", "http://hl7.org/fhir/item-type"), Description("Time")]
            Time,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("string", "http://hl7.org/fhir/item-type"), Description("String")]
            String,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("text", "http://hl7.org/fhir/item-type"), Description("Text")]
            Text,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("url", "http://hl7.org/fhir/item-type"), Description("Url")]
            Url,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("choice", "http://hl7.org/fhir/item-type"), Description("Choice")]
            Choice,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("open-choice", "http://hl7.org/fhir/item-type"), Description("Open Choice")]
            OpenChoice,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("attachment", "http://hl7.org/fhir/item-type"), Description("Attachment")]
            Attachment,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("reference", "http://hl7.org/fhir/item-type"), Description("Reference")]
            Reference,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/item-type)
            /// </summary>
            [EnumLiteral("quantity", "http://hl7.org/fhir/item-type"), Description("Quantity")]
            Quantity,
        }

        /// <summary>
        /// The criteria by which a question is enabled.
        /// (url: http://hl7.org/fhir/ValueSet/questionnaire-enable-operator)
        /// </summary>
        [FhirEnumeration("QuestionnaireItemOperator")]
        public enum QuestionnaireItemOperator
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/questionnaire-enable-operator)
            /// </summary>
            [EnumLiteral("exists", "http://hl7.org/fhir/questionnaire-enable-operator"), Description("Exists")]
            Exists,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/questionnaire-enable-operator)
            /// </summary>
            [EnumLiteral("=", "http://hl7.org/fhir/questionnaire-enable-operator"), Description("Equals")]
            Equal,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/questionnaire-enable-operator)
            /// </summary>
            [EnumLiteral("!=", "http://hl7.org/fhir/questionnaire-enable-operator"), Description("Not Equals")]
            NotEqual,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/questionnaire-enable-operator)
            /// </summary>
            [EnumLiteral(">", "http://hl7.org/fhir/questionnaire-enable-operator"), Description("Greater Than")]
            GreaterThan,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/questionnaire-enable-operator)
            /// </summary>
            [EnumLiteral("<", "http://hl7.org/fhir/questionnaire-enable-operator"), Description("Less Than")]
            LessThan,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/questionnaire-enable-operator)
            /// </summary>
            [EnumLiteral(">=", "http://hl7.org/fhir/questionnaire-enable-operator"), Description("Greater or Equals")]
            GreaterOrEqual,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/questionnaire-enable-operator)
            /// </summary>
            [EnumLiteral("<=", "http://hl7.org/fhir/questionnaire-enable-operator"), Description("Less or Equals")]
            LessOrEqual,
        }

        /// <summary>
        /// Controls how multiple enableWhen values are interpreted -  whether all or any must be true.
        /// (url: http://hl7.org/fhir/ValueSet/questionnaire-enable-behavior)
        /// </summary>
        [FhirEnumeration("EnableWhenBehavior")]
        public enum EnableWhenBehavior
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/questionnaire-enable-behavior)
            /// </summary>
            [EnumLiteral("all", "http://hl7.org/fhir/questionnaire-enable-behavior"), Description("All")]
            All,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/questionnaire-enable-behavior)
            /// </summary>
            [EnumLiteral("any", "http://hl7.org/fhir/questionnaire-enable-behavior"), Description("Any")]
            Any,
        }


        [FhirType("ItemComponent")]
        [DataContract]
        public partial class ItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemComponent"; } }

            /// <summary>
            /// Unique id for item in questionnaire
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
            /// Unique id for item in questionnaire
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
            /// Corresponding concept for this item in a terminology
            /// </summary>
            [FhirElement("code", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Code
            {
                get { if (_code==null) _code = new List<Coding>(); return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private List<Coding> _code;

            /// <summary>
            /// E.g. "1(a)", "2.5.3"
            /// </summary>
            [FhirElement("prefix", Order=70)]
            [DataMember]
            public FhirString PrefixElement
            {
                get { return _prefixElement; }
                set { _prefixElement = value; OnPropertyChanged("PrefixElement"); }
            }

            private FhirString _prefixElement;

            /// <summary>
            /// E.g. "1(a)", "2.5.3"
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Prefix
            {
                get { return PrefixElement != null ? PrefixElement.Value : null; }
                set
                {
                    if (value == null)
                        PrefixElement = null;
                    else
                        PrefixElement = new FhirString(value);
                    OnPropertyChanged("Prefix");
                }
            }

            /// <summary>
            /// Primary text for the item
            /// </summary>
            [FhirElement("text", Order=80)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Primary text for the item
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
            /// group | display | boolean | decimal | integer | date | dateTime +
            /// </summary>
            [FhirElement("type", Order=90)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<QuestionnaireItemType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<QuestionnaireItemType> _typeElement;

            /// <summary>
            /// group | display | boolean | decimal | integer | date | dateTime +
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public QuestionnaireItemType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<QuestionnaireItemType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Only allow data when
            /// </summary>
            [FhirElement("enableWhen", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<EnableWhenComponent> EnableWhen
            {
                get { if (_enableWhen==null) _enableWhen = new List<EnableWhenComponent>(); return _enableWhen; }
                set { _enableWhen = value; OnPropertyChanged("EnableWhen"); }
            }

            private List<EnableWhenComponent> _enableWhen;

            /// <summary>
            /// all | any
            /// </summary>
            [FhirElement("enableBehavior", Order=110)]
            [DataMember]
            public Code<EnableWhenBehavior> EnableBehaviorElement
            {
                get { return _enableBehaviorElement; }
                set { _enableBehaviorElement = value; OnPropertyChanged("EnableBehaviorElement"); }
            }

            private Code<EnableWhenBehavior> _enableBehaviorElement;

            /// <summary>
            /// all | any
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public EnableWhenBehavior? EnableBehavior
            {
                get { return EnableBehaviorElement != null ? EnableBehaviorElement.Value : null; }
                set
                {
                    if (value == null)
                        EnableBehaviorElement = null;
                    else
                        EnableBehaviorElement = new Code<EnableWhenBehavior>(value);
                    OnPropertyChanged("EnableBehavior");
                }
            }

            /// <summary>
            /// Whether the item must be included in data results
            /// </summary>
            [FhirElement("required", Order=120)]
            [DataMember]
            public FhirBoolean RequiredElement
            {
                get { return _requiredElement; }
                set { _requiredElement = value; OnPropertyChanged("RequiredElement"); }
            }

            private FhirBoolean _requiredElement;

            /// <summary>
            /// Whether the item must be included in data results
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Required
            {
                get { return RequiredElement != null ? RequiredElement.Value : null; }
                set
                {
                    if (value == null)
                        RequiredElement = null;
                    else
                        RequiredElement = new FhirBoolean(value);
                    OnPropertyChanged("Required");
                }
            }

            /// <summary>
            /// Whether the item may repeat
            /// </summary>
            [FhirElement("repeats", Order=130)]
            [DataMember]
            public FhirBoolean RepeatsElement
            {
                get { return _repeatsElement; }
                set { _repeatsElement = value; OnPropertyChanged("RepeatsElement"); }
            }

            private FhirBoolean _repeatsElement;

            /// <summary>
            /// Whether the item may repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Repeats
            {
                get { return RepeatsElement != null ? RepeatsElement.Value : null; }
                set
                {
                    if (value == null)
                        RepeatsElement = null;
                    else
                        RepeatsElement = new FhirBoolean(value);
                    OnPropertyChanged("Repeats");
                }
            }

            /// <summary>
            /// Don't allow human editing
            /// </summary>
            [FhirElement("readOnly", Order=140)]
            [DataMember]
            public FhirBoolean ReadOnlyElement
            {
                get { return _readOnlyElement; }
                set { _readOnlyElement = value; OnPropertyChanged("ReadOnlyElement"); }
            }

            private FhirBoolean _readOnlyElement;

            /// <summary>
            /// Don't allow human editing
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? ReadOnly
            {
                get { return ReadOnlyElement != null ? ReadOnlyElement.Value : null; }
                set
                {
                    if (value == null)
                        ReadOnlyElement = null;
                    else
                        ReadOnlyElement = new FhirBoolean(value);
                    OnPropertyChanged("ReadOnly");
                }
            }

            /// <summary>
            /// No more than this many characters
            /// </summary>
            [FhirElement("maxLength", Order=150)]
            [DataMember]
            public Integer MaxLengthElement
            {
                get { return _maxLengthElement; }
                set { _maxLengthElement = value; OnPropertyChanged("MaxLengthElement"); }
            }

            private Integer _maxLengthElement;

            /// <summary>
            /// No more than this many characters
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? MaxLength
            {
                get { return MaxLengthElement != null ? MaxLengthElement.Value : null; }
                set
                {
                    if (value == null)
                        MaxLengthElement = null;
                    else
                        MaxLengthElement = new Integer(value);
                    OnPropertyChanged("MaxLength");
                }
            }

            /// <summary>
            /// Valueset containing permitted answers
            /// </summary>
            [FhirElement("answerValueSet", Order=160)]
            [DataMember]
            public Canonical AnswerValueSetElement
            {
                get { return _answerValueSetElement; }
                set { _answerValueSetElement = value; OnPropertyChanged("AnswerValueSetElement"); }
            }

            private Canonical _answerValueSetElement;

            /// <summary>
            /// Valueset containing permitted answers
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string AnswerValueSet
            {
                get { return AnswerValueSetElement != null ? AnswerValueSetElement.Value : null; }
                set
                {
                    if (value == null)
                        AnswerValueSetElement = null;
                    else
                        AnswerValueSetElement = new Canonical(value);
                    OnPropertyChanged("AnswerValueSet");
                }
            }

            /// <summary>
            /// Permitted answer
            /// </summary>
            [FhirElement("answerOption", Order=170)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AnswerOptionComponent> AnswerOption
            {
                get { if (_answerOption==null) _answerOption = new List<AnswerOptionComponent>(); return _answerOption; }
                set { _answerOption = value; OnPropertyChanged("AnswerOption"); }
            }

            private List<AnswerOptionComponent> _answerOption;

            /// <summary>
            /// Initial value(s) when item is first rendered
            /// </summary>
            [FhirElement("initial", Order=180)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<InitialComponent> Initial
            {
                get { if (_initial==null) _initial = new List<InitialComponent>(); return _initial; }
                set { _initial = value; OnPropertyChanged("Initial"); }
            }

            private List<InitialComponent> _initial;

            /// <summary>
            /// Nested questionnaire items
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (LinkIdElement != null) dest.LinkIdElement = (FhirString)LinkIdElement.DeepCopy();
                    if (DefinitionElement != null) dest.DefinitionElement = (FhirUri)DefinitionElement.DeepCopy();
                    if (Code != null) dest.Code = new List<Coding>(Code.DeepCopy());
                    if (PrefixElement != null) dest.PrefixElement = (FhirString)PrefixElement.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<QuestionnaireItemType>)TypeElement.DeepCopy();
                    if (EnableWhen != null) dest.EnableWhen = new List<EnableWhenComponent>(EnableWhen.DeepCopy());
                    if (EnableBehaviorElement != null) dest.EnableBehaviorElement = (Code<EnableWhenBehavior>)EnableBehaviorElement.DeepCopy();
                    if (RequiredElement != null) dest.RequiredElement = (FhirBoolean)RequiredElement.DeepCopy();
                    if (RepeatsElement != null) dest.RepeatsElement = (FhirBoolean)RepeatsElement.DeepCopy();
                    if (ReadOnlyElement != null) dest.ReadOnlyElement = (FhirBoolean)ReadOnlyElement.DeepCopy();
                    if (MaxLengthElement != null) dest.MaxLengthElement = (Integer)MaxLengthElement.DeepCopy();
                    if (AnswerValueSetElement != null) dest.AnswerValueSetElement = (Canonical)AnswerValueSetElement.DeepCopy();
                    if (AnswerOption != null) dest.AnswerOption = new List<AnswerOptionComponent>(AnswerOption.DeepCopy());
                    if (Initial != null) dest.Initial = new List<InitialComponent>(Initial.DeepCopy());
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
                if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(PrefixElement, otherT.PrefixElement)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if ( !DeepComparable.Matches(EnableWhen, otherT.EnableWhen)) return false;
                if (!DeepComparable.Matches(EnableBehaviorElement, otherT.EnableBehaviorElement)) return false;
                if (!DeepComparable.Matches(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.Matches(RepeatsElement, otherT.RepeatsElement)) return false;
                if (!DeepComparable.Matches(ReadOnlyElement, otherT.ReadOnlyElement)) return false;
                if (!DeepComparable.Matches(MaxLengthElement, otherT.MaxLengthElement)) return false;
                if (!DeepComparable.Matches(AnswerValueSetElement, otherT.AnswerValueSetElement)) return false;
                if ( !DeepComparable.Matches(AnswerOption, otherT.AnswerOption)) return false;
                if ( !DeepComparable.Matches(Initial, otherT.Initial)) return false;
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
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(PrefixElement, otherT.PrefixElement)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(EnableWhen, otherT.EnableWhen)) return false;
                if (!DeepComparable.IsExactly(EnableBehaviorElement, otherT.EnableBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(RequiredElement, otherT.RequiredElement)) return false;
                if (!DeepComparable.IsExactly(RepeatsElement, otherT.RepeatsElement)) return false;
                if (!DeepComparable.IsExactly(ReadOnlyElement, otherT.ReadOnlyElement)) return false;
                if (!DeepComparable.IsExactly(MaxLengthElement, otherT.MaxLengthElement)) return false;
                if (!DeepComparable.IsExactly(AnswerValueSetElement, otherT.AnswerValueSetElement)) return false;
                if (!DeepComparable.IsExactly(AnswerOption, otherT.AnswerOption)) return false;
                if (!DeepComparable.IsExactly(Initial, otherT.Initial)) return false;
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
                    foreach (var elem in Code) { if (elem != null) yield return elem; }
                    if (PrefixElement != null) yield return PrefixElement;
                    if (TextElement != null) yield return TextElement;
                    if (TypeElement != null) yield return TypeElement;
                    foreach (var elem in EnableWhen) { if (elem != null) yield return elem; }
                    if (EnableBehaviorElement != null) yield return EnableBehaviorElement;
                    if (RequiredElement != null) yield return RequiredElement;
                    if (RepeatsElement != null) yield return RepeatsElement;
                    if (ReadOnlyElement != null) yield return ReadOnlyElement;
                    if (MaxLengthElement != null) yield return MaxLengthElement;
                    if (AnswerValueSetElement != null) yield return AnswerValueSetElement;
                    foreach (var elem in AnswerOption) { if (elem != null) yield return elem; }
                    foreach (var elem in Initial) { if (elem != null) yield return elem; }
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
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                    if (PrefixElement != null) yield return new ElementValue("prefix", PrefixElement);
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    foreach (var elem in EnableWhen) { if (elem != null) yield return new ElementValue("enableWhen", elem); }
                    if (EnableBehaviorElement != null) yield return new ElementValue("enableBehavior", EnableBehaviorElement);
                    if (RequiredElement != null) yield return new ElementValue("required", RequiredElement);
                    if (RepeatsElement != null) yield return new ElementValue("repeats", RepeatsElement);
                    if (ReadOnlyElement != null) yield return new ElementValue("readOnly", ReadOnlyElement);
                    if (MaxLengthElement != null) yield return new ElementValue("maxLength", MaxLengthElement);
                    if (AnswerValueSetElement != null) yield return new ElementValue("answerValueSet", AnswerValueSetElement);
                    foreach (var elem in AnswerOption) { if (elem != null) yield return new ElementValue("answerOption", elem); }
                    foreach (var elem in Initial) { if (elem != null) yield return new ElementValue("initial", elem); }
                    foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
                }
            }


        }


        [FhirType("EnableWhenComponent")]
        [DataContract]
        public partial class EnableWhenComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EnableWhenComponent"; } }

            /// <summary>
            /// Question that determines whether item is enabled
            /// </summary>
            [FhirElement("question", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString QuestionElement
            {
                get { return _questionElement; }
                set { _questionElement = value; OnPropertyChanged("QuestionElement"); }
            }

            private FhirString _questionElement;

            /// <summary>
            /// Question that determines whether item is enabled
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Question
            {
                get { return QuestionElement != null ? QuestionElement.Value : null; }
                set
                {
                    if (value == null)
                        QuestionElement = null;
                    else
                        QuestionElement = new FhirString(value);
                    OnPropertyChanged("Question");
                }
            }

            /// <summary>
            /// exists | = | != | &gt; | &lt; | &gt;= | &lt;=
            /// </summary>
            [FhirElement("operator", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<QuestionnaireItemOperator> OperatorElement
            {
                get { return _operatorElement; }
                set { _operatorElement = value; OnPropertyChanged("OperatorElement"); }
            }

            private Code<QuestionnaireItemOperator> _operatorElement;

            /// <summary>
            /// exists | = | != | &gt; | &lt; | &gt;= | &lt;=
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public QuestionnaireItemOperator? Operator
            {
                get { return OperatorElement != null ? OperatorElement.Value : null; }
                set
                {
                    if (value == null)
                        OperatorElement = null;
                    else
                        OperatorElement = new Code<QuestionnaireItemOperator>(value);
                    OnPropertyChanged("Operator");
                }
            }

            /// <summary>
            /// Value for question comparison based on operator
            /// </summary>
            [FhirElement("answer", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(FhirDecimal),typeof(Integer),typeof(Date),typeof(FhirDateTime),typeof(Time),typeof(FhirString),typeof(Coding),typeof(Quantity),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Answer
            {
                get { return _answer; }
                set { _answer = value; OnPropertyChanged("Answer"); }
            }

            private Element _answer;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EnableWhenComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (QuestionElement != null) dest.QuestionElement = (FhirString)QuestionElement.DeepCopy();
                    if (OperatorElement != null) dest.OperatorElement = (Code<QuestionnaireItemOperator>)OperatorElement.DeepCopy();
                    if (Answer != null) dest.Answer = (Element)Answer.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EnableWhenComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EnableWhenComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(QuestionElement, otherT.QuestionElement)) return false;
                if (!DeepComparable.Matches(OperatorElement, otherT.OperatorElement)) return false;
                if (!DeepComparable.Matches(Answer, otherT.Answer)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EnableWhenComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(QuestionElement, otherT.QuestionElement)) return false;
                if (!DeepComparable.IsExactly(OperatorElement, otherT.OperatorElement)) return false;
                if (!DeepComparable.IsExactly(Answer, otherT.Answer)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (QuestionElement != null) yield return QuestionElement;
                    if (OperatorElement != null) yield return OperatorElement;
                    if (Answer != null) yield return Answer;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (QuestionElement != null) yield return new ElementValue("question", QuestionElement);
                    if (OperatorElement != null) yield return new ElementValue("operator", OperatorElement);
                    if (Answer != null) yield return new ElementValue("answer", Answer);
                }
            }


        }


        [FhirType("AnswerOptionComponent")]
        [DataContract]
        public partial class AnswerOptionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AnswerOptionComponent"; } }

            /// <summary>
            /// Answer value
            /// </summary>
            [FhirElement("value", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Integer),typeof(Date),typeof(Time),typeof(FhirString),typeof(Coding),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            /// <summary>
            /// Whether option is selected by default
            /// </summary>
            [FhirElement("initialSelected", Order=50)]
            [DataMember]
            public FhirBoolean InitialSelectedElement
            {
                get { return _initialSelectedElement; }
                set { _initialSelectedElement = value; OnPropertyChanged("InitialSelectedElement"); }
            }

            private FhirBoolean _initialSelectedElement;

            /// <summary>
            /// Whether option is selected by default
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? InitialSelected
            {
                get { return InitialSelectedElement != null ? InitialSelectedElement.Value : null; }
                set
                {
                    if (value == null)
                        InitialSelectedElement = null;
                    else
                        InitialSelectedElement = new FhirBoolean(value);
                    OnPropertyChanged("InitialSelected");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AnswerOptionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    if (InitialSelectedElement != null) dest.InitialSelectedElement = (FhirBoolean)InitialSelectedElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AnswerOptionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AnswerOptionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;
                if (!DeepComparable.Matches(InitialSelectedElement, otherT.InitialSelectedElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AnswerOptionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if (!DeepComparable.IsExactly(InitialSelectedElement, otherT.InitialSelectedElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Value != null) yield return Value;
                    if (InitialSelectedElement != null) yield return InitialSelectedElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Value != null) yield return new ElementValue("value", Value);
                    if (InitialSelectedElement != null) yield return new ElementValue("initialSelected", InitialSelectedElement);
                }
            }


        }


        [FhirType("InitialComponent")]
        [DataContract]
        public partial class InitialComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InitialComponent"; } }

            /// <summary>
            /// Actual value for initializing the question
            /// </summary>
            [FhirElement("value", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(FhirDecimal),typeof(Integer),typeof(Date),typeof(FhirDateTime),typeof(Time),typeof(FhirString),typeof(FhirUri),typeof(Attachment),typeof(Coding),typeof(Quantity),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InitialComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InitialComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InitialComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InitialComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this questionnaire, represented as a URI (globally unique)
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
        /// Canonical identifier for this questionnaire, represented as a URI (globally unique)
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
        /// Additional identifier for the questionnaire
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
        /// Business version of the questionnaire
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
        /// Business version of the questionnaire
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
        /// Name for this questionnaire (computer friendly)
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
        /// Name for this questionnaire (computer friendly)
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
        /// Name for this questionnaire (human friendly)
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
        /// Name for this questionnaire (human friendly)
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
        /// Instantiates protocol or definition
        /// </summary>
        [FhirElement("derivedFrom", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> DerivedFromElement
        {
            get { if (_derivedFromElement==null) _derivedFromElement = new List<Canonical>(); return _derivedFromElement; }
            set { _derivedFromElement = value; OnPropertyChanged("DerivedFromElement"); }
        }

        private List<Canonical> _derivedFromElement;

        /// <summary>
        /// Instantiates protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> DerivedFrom
        {
            get { return DerivedFromElement != null ? DerivedFromElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    DerivedFromElement = null;
                else
                    DerivedFromElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("DerivedFrom");
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
        /// Resource that can be subject of QuestionnaireResponse
        /// </summary>
        [FhirElement("subjectType", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Code<ResourceType>> SubjectTypeElement
        {
            get { if (_subjectTypeElement==null) _subjectTypeElement = new List<Code<ResourceType>>(); return _subjectTypeElement; }
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
        /// Natural language description of the questionnaire
        /// </summary>
        [FhirElement("description", Order=210)]
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
        /// Intended jurisdiction for questionnaire (if applicable)
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
        /// Why this questionnaire is defined
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
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=250)]
        [DataMember]
        public Markdown Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        private Markdown _copyright;

        /// <summary>
        /// When the questionnaire was approved by publisher
        /// </summary>
        [FhirElement("approvalDate", Order=260)]
        [DataMember]
        public Date ApprovalDateElement
        {
            get { return _approvalDateElement; }
            set { _approvalDateElement = value; OnPropertyChanged("ApprovalDateElement"); }
        }

        private Date _approvalDateElement;

        /// <summary>
        /// When the questionnaire was approved by publisher
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
        /// When the questionnaire was last reviewed
        /// </summary>
        [FhirElement("lastReviewDate", Order=270)]
        [DataMember]
        public Date LastReviewDateElement
        {
            get { return _lastReviewDateElement; }
            set { _lastReviewDateElement = value; OnPropertyChanged("LastReviewDateElement"); }
        }

        private Date _lastReviewDateElement;

        /// <summary>
        /// When the questionnaire was last reviewed
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
        /// When the questionnaire is expected to be used
        /// </summary>
        [FhirElement("effectivePeriod", InSummary=true, Order=280)]
        [DataMember]
        public Period EffectivePeriod
        {
            get { return _effectivePeriod; }
            set { _effectivePeriod = value; OnPropertyChanged("EffectivePeriod"); }
        }

        private Period _effectivePeriod;

        /// <summary>
        /// Concept that represents the overall questionnaire
        /// </summary>
        [FhirElement("code", InSummary=true, Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> Code
        {
            get { if (_code==null) _code = new List<Coding>(); return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private List<Coding> _code;

        /// <summary>
        /// Questions and sections within the Questionnaire
        /// </summary>
        [FhirElement("item", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ItemComponent> Item
        {
            get { if (_item==null) _item = new List<ItemComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<ItemComponent> _item;


        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "descendants().linkId.isDistinct()",
            Key = "que-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "The link ids for groups and questions must be unique within the questionnaire",
            Xpath = "count(descendant::f:linkId/@value)=count(distinct-values(descendant::f:linkId/@value))"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "que-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_9 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all(type!='display' or readOnly.empty())",
            Key = "que-9",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Read-only can't be specified for \"display\" items",
            Xpath = "not(f:type/@value=('group', 'display') and f:*[starts-with(local-name(.), 'initial')])"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_8 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all((type!='group' and type!='display') or initial.empty())",
            Key = "que-8",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Initial values can't be specified for groups or display items",
            Xpath = "not(f:type/@value=('group', 'display') and f:*[starts-with(local-name(.), 'initial')])"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all(type!='display' or (required.empty() and repeats.empty()))",
            Key = "que-6",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Required and repeat aren't permitted for display items",
            Xpath = "not(f:type/@value='display' and (f:required or f:repeats))"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all((type ='choice' or type = 'open-choice' or type = 'decimal' or type = 'integer' or type = 'date' or type = 'dateTime' or type = 'time' or type = 'string' or type = 'quantity') or (answerValueSet.empty() and answerOption.empty()))",
            Key = "que-5",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Only 'choice' items can have answerValueSet",
            Xpath = "f:type/@value=('choice','open-choice','decimal','integer','date','dateTime','time','string','quantity',') or not(f:answerOption or f:answerValueSet)"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all(answerOption.empty() or answerValueSet.empty())",
            Key = "que-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "A question cannot have both answerOption and answerValueSet",
            Xpath = "not(f:answerValueSet and f:answerOption)"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all(type!='display' or code.empty())",
            Key = "que-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Display items cannot have a \"code\" asserted",
            Xpath = "not(f:type/@value='display' and f:code)"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_10 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all((type in ('boolean' | 'decimal' | 'integer' | 'string' | 'text' | 'url' | 'open-choice')) or maxLength.empty())",
            Key = "que-10",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Maximum length can only be declared for simple question types",
            Xpath = "f:type/@value=('boolean', 'decimal', 'integer', 'open-choice', 'string', 'text', 'url') or not(f:maxLength)"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all((type='group' implies item.empty().not()) and (type.trace('type')='display' implies item.trace('item').empty()))",
            Key = "que-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Group items must have nested items, display items cannot have nested items",
            Xpath = "not((f:type/@value='group' and not(f:item)) or (f:type/@value='display' and f:item))"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_13 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all(repeats=true or initial.count() <= 1)",
            Key = "que-13",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Can only have multiple initial values for repeating items",
            Xpath = "f:repeats/@value='true' or count(f:initial)<=1"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_11 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all(answerOption.empty() or initial.empty())",
            Key = "que-11",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If one or more answerOption is present, initial[x] must be missing",
            Xpath = "not(f:answerOption) or not(count(f:*[starts-with(local-name(.), 'initial')]))"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_12 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.all(enableWhen.count() > 2 implies enableBehavior.exists())",
            Key = "que-12",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If there are more than one enableWhen, enableBehavior must be specified",
            Xpath = "not(f:answerOption) or not(count(f:*[starts-with(local-name(.), 'initial')]))"
        };

        public static ElementDefinition.ConstraintComponent Questionnaire_QUE_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "item.enableWhen.all(operator = 'exists' implies (answer is Boolean))",
            Key = "que-7",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the operator is 'exists', the value must be a boolean",
            Xpath = "f:operator/@value != 'exists' or exists(f:answerBoolean)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Questionnaire_QUE_2);
            InvariantConstraints.Add(Questionnaire_QUE_0);
            InvariantConstraints.Add(Questionnaire_QUE_9);
            InvariantConstraints.Add(Questionnaire_QUE_8);
            InvariantConstraints.Add(Questionnaire_QUE_6);
            InvariantConstraints.Add(Questionnaire_QUE_5);
            InvariantConstraints.Add(Questionnaire_QUE_4);
            InvariantConstraints.Add(Questionnaire_QUE_3);
            InvariantConstraints.Add(Questionnaire_QUE_10);
            InvariantConstraints.Add(Questionnaire_QUE_1);
            InvariantConstraints.Add(Questionnaire_QUE_13);
            InvariantConstraints.Add(Questionnaire_QUE_11);
            InvariantConstraints.Add(Questionnaire_QUE_12);
            InvariantConstraints.Add(Questionnaire_QUE_7);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Questionnaire;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (DerivedFromElement != null) dest.DerivedFromElement = new List<Canonical>(DerivedFromElement.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (SubjectTypeElement != null) dest.SubjectTypeElement = new List<Code<ResourceType>>(SubjectTypeElement.DeepCopy());
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (Description != null) dest.Description = (Markdown)Description.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (Purpose != null) dest.Purpose = (Markdown)Purpose.DeepCopy();
                if (Copyright != null) dest.Copyright = (Markdown)Copyright.DeepCopy();
                if (ApprovalDateElement != null) dest.ApprovalDateElement = (Date)ApprovalDateElement.DeepCopy();
                if (LastReviewDateElement != null) dest.LastReviewDateElement = (Date)LastReviewDateElement.DeepCopy();
                if (EffectivePeriod != null) dest.EffectivePeriod = (Period)EffectivePeriod.DeepCopy();
                if (Code != null) dest.Code = new List<Coding>(Code.DeepCopy());
                if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
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
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if ( !DeepComparable.Matches(DerivedFromElement, otherT.DerivedFromElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if ( !DeepComparable.Matches(SubjectTypeElement, otherT.SubjectTypeElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Description, otherT.Description)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.Matches(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.Matches(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.Matches(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.Matches(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if ( !DeepComparable.Matches(Item, otherT.Item)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Questionnaire;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(DerivedFromElement, otherT.DerivedFromElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(SubjectTypeElement, otherT.SubjectTypeElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.IsExactly(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.IsExactly(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.IsExactly(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

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
                foreach (var elem in DerivedFromElement) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                foreach (var elem in SubjectTypeElement) { if (elem != null) yield return elem; }
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Description != null) yield return Description;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (Purpose != null) yield return Purpose;
                if (Copyright != null) yield return Copyright;
                if (ApprovalDateElement != null) yield return ApprovalDateElement;
                if (LastReviewDateElement != null) yield return LastReviewDateElement;
                if (EffectivePeriod != null) yield return EffectivePeriod;
                foreach (var elem in Code) { if (elem != null) yield return elem; }
                foreach (var elem in Item) { if (elem != null) yield return elem; }
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
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                foreach (var elem in DerivedFromElement) { if (elem != null) yield return new ElementValue("derivedFrom", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                foreach (var elem in SubjectTypeElement) { if (elem != null) yield return new ElementValue("subjectType", elem); }
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (Purpose != null) yield return new ElementValue("purpose", Purpose);
                if (Copyright != null) yield return new ElementValue("copyright", Copyright);
                if (ApprovalDateElement != null) yield return new ElementValue("approvalDate", ApprovalDateElement);
                if (LastReviewDateElement != null) yield return new ElementValue("lastReviewDate", LastReviewDateElement);
                if (EffectivePeriod != null) yield return new ElementValue("effectivePeriod", EffectivePeriod);
                foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
            }
        }

    }

}
