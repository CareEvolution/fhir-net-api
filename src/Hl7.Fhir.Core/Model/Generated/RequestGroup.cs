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
    /// A group of related requests
    /// </summary>
    [FhirType("RequestGroup", IsResource=true)]
    [DataContract]
    public partial class RequestGroup : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.RequestGroup; } }
        [NotMapped]
        public override string TypeName { get { return "RequestGroup"; } }


        [FhirType("ActionComponent")]
        [DataContract]
        public partial class ActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActionComponent"; } }

            /// <summary>
            /// User-visible prefix for the action (e.g. 1. or A.)
            /// </summary>
            [FhirElement("prefix", Order=40)]
            [DataMember]
            public FhirString PrefixElement
            {
                get { return _prefixElement; }
                set { _prefixElement = value; OnPropertyChanged("PrefixElement"); }
            }

            private FhirString _prefixElement;

            /// <summary>
            /// User-visible prefix for the action (e.g. 1. or A.)
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
            /// User-visible title
            /// </summary>
            [FhirElement("title", Order=50)]
            [DataMember]
            public FhirString TitleElement
            {
                get { return _titleElement; }
                set { _titleElement = value; OnPropertyChanged("TitleElement"); }
            }

            private FhirString _titleElement;

            /// <summary>
            /// User-visible title
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
            /// Short description of the action
            /// </summary>
            [FhirElement("description", InSummary=true, Order=60)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Short description of the action
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
            /// Static text equivalent of the action, used if the dynamic aspects cannot be interpreted by the receiving system
            /// </summary>
            [FhirElement("textEquivalent", InSummary=true, Order=70)]
            [DataMember]
            public FhirString TextEquivalentElement
            {
                get { return _textEquivalentElement; }
                set { _textEquivalentElement = value; OnPropertyChanged("TextEquivalentElement"); }
            }

            private FhirString _textEquivalentElement;

            /// <summary>
            /// Static text equivalent of the action, used if the dynamic aspects cannot be interpreted by the receiving system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string TextEquivalent
            {
                get { return TextEquivalentElement != null ? TextEquivalentElement.Value : null; }
                set
                {
                    if (value == null)
                        TextEquivalentElement = null;
                    else
                        TextEquivalentElement = new FhirString(value);
                    OnPropertyChanged("TextEquivalent");
                }
            }

            /// <summary>
            /// Code representing the meaning of the action or sub-actions
            /// </summary>
            [FhirElement("code", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Code
            {
                get { if (_code==null) _code = new List<CodeableConcept>(); return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private List<CodeableConcept> _code;

            /// <summary>
            /// Supporting documentation for the intended performer of the action
            /// </summary>
            [FhirElement("documentation", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RelatedArtifact> Documentation
            {
                get { if (_documentation==null) _documentation = new List<RelatedArtifact>(); return _documentation; }
                set { _documentation = value; OnPropertyChanged("Documentation"); }
            }

            private List<RelatedArtifact> _documentation;

            /// <summary>
            /// Whether or not the action is applicable
            /// </summary>
            [FhirElement("condition", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ConditionComponent> Condition
            {
                get { if (_condition==null) _condition = new List<ConditionComponent>(); return _condition; }
                set { _condition = value; OnPropertyChanged("Condition"); }
            }

            private List<ConditionComponent> _condition;

            /// <summary>
            /// Relationship to another action
            /// </summary>
            [FhirElement("relatedAction", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RelatedActionComponent> RelatedAction
            {
                get { if (_relatedAction==null) _relatedAction = new List<RelatedActionComponent>(); return _relatedAction; }
                set { _relatedAction = value; OnPropertyChanged("RelatedAction"); }
            }

            private List<RelatedActionComponent> _relatedAction;

            /// <summary>
            /// When the action should take place
            /// </summary>
            [FhirElement("timing", Order=120, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirDateTime),typeof(Age),typeof(Period),typeof(Duration),typeof(Range),typeof(Timing))]
            [DataMember]
            public Element Timing
            {
                get { return _timing; }
                set { _timing = value; OnPropertyChanged("Timing"); }
            }

            private Element _timing;

            /// <summary>
            /// Who should perform the action
            /// </summary>
            [FhirElement("participant", Order=130)]
            [References("Patient","Practitioner","RelatedPerson")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Participant
            {
                get { if (_participant==null) _participant = new List<ResourceReference>(); return _participant; }
                set { _participant = value; OnPropertyChanged("Participant"); }
            }

            private List<ResourceReference> _participant;

            /// <summary>
            /// create | update | remove | fire-event
            /// </summary>
            [FhirElement("type", Order=140)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// visual-group | logical-group | sentence-group
            /// </summary>
            [FhirElement("groupingBehavior", Order=150)]
            [DataMember]
            public Code<ActionGroupingBehavior> GroupingBehaviorElement
            {
                get { return _groupingBehaviorElement; }
                set { _groupingBehaviorElement = value; OnPropertyChanged("GroupingBehaviorElement"); }
            }

            private Code<ActionGroupingBehavior> _groupingBehaviorElement;

            /// <summary>
            /// visual-group | logical-group | sentence-group
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ActionGroupingBehavior? GroupingBehavior
            {
                get { return GroupingBehaviorElement != null ? GroupingBehaviorElement.Value : null; }
                set
                {
                    if (value == null)
                        GroupingBehaviorElement = null;
                    else
                        GroupingBehaviorElement = new Code<ActionGroupingBehavior>(value);
                    OnPropertyChanged("GroupingBehavior");
                }
            }

            /// <summary>
            /// any | all | all-or-none | exactly-one | at-most-one | one-or-more
            /// </summary>
            [FhirElement("selectionBehavior", Order=160)]
            [DataMember]
            public Code<ActionSelectionBehavior> SelectionBehaviorElement
            {
                get { return _selectionBehaviorElement; }
                set { _selectionBehaviorElement = value; OnPropertyChanged("SelectionBehaviorElement"); }
            }

            private Code<ActionSelectionBehavior> _selectionBehaviorElement;

            /// <summary>
            /// any | all | all-or-none | exactly-one | at-most-one | one-or-more
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ActionSelectionBehavior? SelectionBehavior
            {
                get { return SelectionBehaviorElement != null ? SelectionBehaviorElement.Value : null; }
                set
                {
                    if (value == null)
                        SelectionBehaviorElement = null;
                    else
                        SelectionBehaviorElement = new Code<ActionSelectionBehavior>(value);
                    OnPropertyChanged("SelectionBehavior");
                }
            }

            /// <summary>
            /// must | could | must-unless-documented
            /// </summary>
            [FhirElement("requiredBehavior", Order=170)]
            [DataMember]
            public Code<ActionRequiredBehavior> RequiredBehaviorElement
            {
                get { return _requiredBehaviorElement; }
                set { _requiredBehaviorElement = value; OnPropertyChanged("RequiredBehaviorElement"); }
            }

            private Code<ActionRequiredBehavior> _requiredBehaviorElement;

            /// <summary>
            /// must | could | must-unless-documented
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ActionRequiredBehavior? RequiredBehavior
            {
                get { return RequiredBehaviorElement != null ? RequiredBehaviorElement.Value : null; }
                set
                {
                    if (value == null)
                        RequiredBehaviorElement = null;
                    else
                        RequiredBehaviorElement = new Code<ActionRequiredBehavior>(value);
                    OnPropertyChanged("RequiredBehavior");
                }
            }

            /// <summary>
            /// yes | no
            /// </summary>
            [FhirElement("precheckBehavior", Order=180)]
            [DataMember]
            public Code<ActionPrecheckBehavior> PrecheckBehaviorElement
            {
                get { return _precheckBehaviorElement; }
                set { _precheckBehaviorElement = value; OnPropertyChanged("PrecheckBehaviorElement"); }
            }

            private Code<ActionPrecheckBehavior> _precheckBehaviorElement;

            /// <summary>
            /// yes | no
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ActionPrecheckBehavior? PrecheckBehavior
            {
                get { return PrecheckBehaviorElement != null ? PrecheckBehaviorElement.Value : null; }
                set
                {
                    if (value == null)
                        PrecheckBehaviorElement = null;
                    else
                        PrecheckBehaviorElement = new Code<ActionPrecheckBehavior>(value);
                    OnPropertyChanged("PrecheckBehavior");
                }
            }

            /// <summary>
            /// single | multiple
            /// </summary>
            [FhirElement("cardinalityBehavior", Order=190)]
            [DataMember]
            public Code<ActionCardinalityBehavior> CardinalityBehaviorElement
            {
                get { return _cardinalityBehaviorElement; }
                set { _cardinalityBehaviorElement = value; OnPropertyChanged("CardinalityBehaviorElement"); }
            }

            private Code<ActionCardinalityBehavior> _cardinalityBehaviorElement;

            /// <summary>
            /// single | multiple
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ActionCardinalityBehavior? CardinalityBehavior
            {
                get { return CardinalityBehaviorElement != null ? CardinalityBehaviorElement.Value : null; }
                set
                {
                    if (value == null)
                        CardinalityBehaviorElement = null;
                    else
                        CardinalityBehaviorElement = new Code<ActionCardinalityBehavior>(value);
                    OnPropertyChanged("CardinalityBehavior");
                }
            }

            /// <summary>
            /// The target of the action
            /// </summary>
            [FhirElement("resource", Order=200)]
            [DataMember]
            public ResourceReference Resource
            {
                get { return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private ResourceReference _resource;

            /// <summary>
            /// Sub action
            /// </summary>
            [FhirElement("action", Order=210)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ActionComponent> Action
            {
                get { if (_action==null) _action = new List<ActionComponent>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<ActionComponent> _action;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PrefixElement != null) dest.PrefixElement = (FhirString)PrefixElement.DeepCopy();
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (TextEquivalentElement != null) dest.TextEquivalentElement = (FhirString)TextEquivalentElement.DeepCopy();
                    if (Code != null) dest.Code = new List<CodeableConcept>(Code.DeepCopy());
                    if (Documentation != null) dest.Documentation = new List<RelatedArtifact>(Documentation.DeepCopy());
                    if (Condition != null) dest.Condition = new List<ConditionComponent>(Condition.DeepCopy());
                    if (RelatedAction != null) dest.RelatedAction = new List<RelatedActionComponent>(RelatedAction.DeepCopy());
                    if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
                    if (Participant != null) dest.Participant = new List<ResourceReference>(Participant.DeepCopy());
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (GroupingBehaviorElement != null) dest.GroupingBehaviorElement = (Code<ActionGroupingBehavior>)GroupingBehaviorElement.DeepCopy();
                    if (SelectionBehaviorElement != null) dest.SelectionBehaviorElement = (Code<ActionSelectionBehavior>)SelectionBehaviorElement.DeepCopy();
                    if (RequiredBehaviorElement != null) dest.RequiredBehaviorElement = (Code<ActionRequiredBehavior>)RequiredBehaviorElement.DeepCopy();
                    if (PrecheckBehaviorElement != null) dest.PrecheckBehaviorElement = (Code<ActionPrecheckBehavior>)PrecheckBehaviorElement.DeepCopy();
                    if (CardinalityBehaviorElement != null) dest.CardinalityBehaviorElement = (Code<ActionCardinalityBehavior>)CardinalityBehaviorElement.DeepCopy();
                    if (Resource != null) dest.Resource = (ResourceReference)Resource.DeepCopy();
                    if (Action != null) dest.Action = new List<ActionComponent>(Action.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PrefixElement, otherT.PrefixElement)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(TextEquivalentElement, otherT.TextEquivalentElement)) return false;
                if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if ( !DeepComparable.Matches(Documentation, otherT.Documentation)) return false;
                if ( !DeepComparable.Matches(Condition, otherT.Condition)) return false;
                if ( !DeepComparable.Matches(RelatedAction, otherT.RelatedAction)) return false;
                if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
                if ( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(GroupingBehaviorElement, otherT.GroupingBehaviorElement)) return false;
                if (!DeepComparable.Matches(SelectionBehaviorElement, otherT.SelectionBehaviorElement)) return false;
                if (!DeepComparable.Matches(RequiredBehaviorElement, otherT.RequiredBehaviorElement)) return false;
                if (!DeepComparable.Matches(PrecheckBehaviorElement, otherT.PrecheckBehaviorElement)) return false;
                if (!DeepComparable.Matches(CardinalityBehaviorElement, otherT.CardinalityBehaviorElement)) return false;
                if (!DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PrefixElement, otherT.PrefixElement)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(TextEquivalentElement, otherT.TextEquivalentElement)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Documentation, otherT.Documentation)) return false;
                if (!DeepComparable.IsExactly(Condition, otherT.Condition)) return false;
                if (!DeepComparable.IsExactly(RelatedAction, otherT.RelatedAction)) return false;
                if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
                if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(GroupingBehaviorElement, otherT.GroupingBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(SelectionBehaviorElement, otherT.SelectionBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(RequiredBehaviorElement, otherT.RequiredBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(PrecheckBehaviorElement, otherT.PrecheckBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(CardinalityBehaviorElement, otherT.CardinalityBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PrefixElement != null) yield return PrefixElement;
                    if (TitleElement != null) yield return TitleElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (TextEquivalentElement != null) yield return TextEquivalentElement;
                    foreach (var elem in Code) { if (elem != null) yield return elem; }
                    foreach (var elem in Documentation) { if (elem != null) yield return elem; }
                    foreach (var elem in Condition) { if (elem != null) yield return elem; }
                    foreach (var elem in RelatedAction) { if (elem != null) yield return elem; }
                    if (Timing != null) yield return Timing;
                    foreach (var elem in Participant) { if (elem != null) yield return elem; }
                    if (Type != null) yield return Type;
                    if (GroupingBehaviorElement != null) yield return GroupingBehaviorElement;
                    if (SelectionBehaviorElement != null) yield return SelectionBehaviorElement;
                    if (RequiredBehaviorElement != null) yield return RequiredBehaviorElement;
                    if (PrecheckBehaviorElement != null) yield return PrecheckBehaviorElement;
                    if (CardinalityBehaviorElement != null) yield return CardinalityBehaviorElement;
                    if (Resource != null) yield return Resource;
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PrefixElement != null) yield return new ElementValue("prefix", PrefixElement);
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (TextEquivalentElement != null) yield return new ElementValue("textEquivalent", TextEquivalentElement);
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                    foreach (var elem in Documentation) { if (elem != null) yield return new ElementValue("documentation", elem); }
                    foreach (var elem in Condition) { if (elem != null) yield return new ElementValue("condition", elem); }
                    foreach (var elem in RelatedAction) { if (elem != null) yield return new ElementValue("relatedAction", elem); }
                    if (Timing != null) yield return new ElementValue("timing", Timing);
                    foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (GroupingBehaviorElement != null) yield return new ElementValue("groupingBehavior", GroupingBehaviorElement);
                    if (SelectionBehaviorElement != null) yield return new ElementValue("selectionBehavior", SelectionBehaviorElement);
                    if (RequiredBehaviorElement != null) yield return new ElementValue("requiredBehavior", RequiredBehaviorElement);
                    if (PrecheckBehaviorElement != null) yield return new ElementValue("precheckBehavior", PrecheckBehaviorElement);
                    if (CardinalityBehaviorElement != null) yield return new ElementValue("cardinalityBehavior", CardinalityBehaviorElement);
                    if (Resource != null) yield return new ElementValue("resource", Resource);
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                }
            }


        }


        [FhirType("ConditionComponent")]
        [DataContract]
        public partial class ConditionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ConditionComponent"; } }

            /// <summary>
            /// applicability | start | stop
            /// </summary>
            [FhirElement("kind", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ActionConditionKind> KindElement
            {
                get { return _kindElement; }
                set { _kindElement = value; OnPropertyChanged("KindElement"); }
            }

            private Code<ActionConditionKind> _kindElement;

            /// <summary>
            /// applicability | start | stop
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ActionConditionKind? Kind
            {
                get { return KindElement != null ? KindElement.Value : null; }
                set
                {
                    if (value == null)
                        KindElement = null;
                    else
                        KindElement = new Code<ActionConditionKind>(value);
                    OnPropertyChanged("Kind");
                }
            }

            /// <summary>
            /// Natural language description of the condition
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Natural language description of the condition
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
            /// Language of the expression
            /// </summary>
            [FhirElement("language", Order=60)]
            [DataMember]
            public FhirString LanguageElement
            {
                get { return _languageElement; }
                set { _languageElement = value; OnPropertyChanged("LanguageElement"); }
            }

            private FhirString _languageElement;

            /// <summary>
            /// Language of the expression
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Language
            {
                get { return LanguageElement != null ? LanguageElement.Value : null; }
                set
                {
                    if (value == null)
                        LanguageElement = null;
                    else
                        LanguageElement = new FhirString(value);
                    OnPropertyChanged("Language");
                }
            }

            /// <summary>
            /// Boolean-valued expression
            /// </summary>
            [FhirElement("expression", Order=70)]
            [DataMember]
            public FhirString ExpressionElement
            {
                get { return _expressionElement; }
                set { _expressionElement = value; OnPropertyChanged("ExpressionElement"); }
            }

            private FhirString _expressionElement;

            /// <summary>
            /// Boolean-valued expression
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
                var dest = other as ConditionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (KindElement != null) dest.KindElement = (Code<ActionConditionKind>)KindElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (LanguageElement != null) dest.LanguageElement = (FhirString)LanguageElement.DeepCopy();
                    if (ExpressionElement != null) dest.ExpressionElement = (FhirString)ExpressionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ConditionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ConditionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.Matches(ExpressionElement, otherT.ExpressionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ConditionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(LanguageElement, otherT.LanguageElement)) return false;
                if (!DeepComparable.IsExactly(ExpressionElement, otherT.ExpressionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (KindElement != null) yield return KindElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (LanguageElement != null) yield return LanguageElement;
                    if (ExpressionElement != null) yield return ExpressionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (KindElement != null) yield return new ElementValue("kind", KindElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (LanguageElement != null) yield return new ElementValue("language", LanguageElement);
                    if (ExpressionElement != null) yield return new ElementValue("expression", ExpressionElement);
                }
            }


        }


        [FhirType("RelatedActionComponent")]
        [DataContract]
        public partial class RelatedActionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedActionComponent"; } }

            /// <summary>
            /// What action this is related to
            /// </summary>
            [FhirElement("actionId", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Id ActionIdElement
            {
                get { return _actionIdElement; }
                set { _actionIdElement = value; OnPropertyChanged("ActionIdElement"); }
            }

            private Id _actionIdElement;

            /// <summary>
            /// What action this is related to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ActionId
            {
                get { return ActionIdElement != null ? ActionIdElement.Value : null; }
                set
                {
                    if (value == null)
                        ActionIdElement = null;
                    else
                        ActionIdElement = new Id(value);
                    OnPropertyChanged("ActionId");
                }
            }

            /// <summary>
            /// before-start | before | before-end | concurrent-with-start | concurrent | concurrent-with-end | after-start | after | after-end
            /// </summary>
            [FhirElement("relationship", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ActionRelationshipType> RelationshipElement
            {
                get { return _relationshipElement; }
                set { _relationshipElement = value; OnPropertyChanged("RelationshipElement"); }
            }

            private Code<ActionRelationshipType> _relationshipElement;

            /// <summary>
            /// before-start | before | before-end | concurrent-with-start | concurrent | concurrent-with-end | after-start | after | after-end
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ActionRelationshipType? Relationship
            {
                get { return RelationshipElement != null ? RelationshipElement.Value : null; }
                set
                {
                    if (value == null)
                        RelationshipElement = null;
                    else
                        RelationshipElement = new Code<ActionRelationshipType>(value);
                    OnPropertyChanged("Relationship");
                }
            }

            /// <summary>
            /// Time offset for the relationship
            /// </summary>
            [FhirElement("offset", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Duration),typeof(Range))]
            [DataMember]
            public Element Offset
            {
                get { return _offset; }
                set { _offset = value; OnPropertyChanged("Offset"); }
            }

            private Element _offset;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatedActionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ActionIdElement != null) dest.ActionIdElement = (Id)ActionIdElement.DeepCopy();
                    if (RelationshipElement != null) dest.RelationshipElement = (Code<ActionRelationshipType>)RelationshipElement.DeepCopy();
                    if (Offset != null) dest.Offset = (Element)Offset.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelatedActionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatedActionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ActionIdElement, otherT.ActionIdElement)) return false;
                if (!DeepComparable.Matches(RelationshipElement, otherT.RelationshipElement)) return false;
                if (!DeepComparable.Matches(Offset, otherT.Offset)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedActionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ActionIdElement, otherT.ActionIdElement)) return false;
                if (!DeepComparable.IsExactly(RelationshipElement, otherT.RelationshipElement)) return false;
                if (!DeepComparable.IsExactly(Offset, otherT.Offset)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ActionIdElement != null) yield return ActionIdElement;
                    if (RelationshipElement != null) yield return RelationshipElement;
                    if (Offset != null) yield return Offset;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ActionIdElement != null) yield return new ElementValue("actionId", ActionIdElement);
                    if (RelationshipElement != null) yield return new ElementValue("relationship", RelationshipElement);
                    if (Offset != null) yield return new ElementValue("offset", Offset);
                }
            }


        }


        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Instantiates FHIR protocol or definition
        /// </summary>
        [FhirElement("instantiatesCanonical", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> InstantiatesCanonicalElement
        {
            get { if (_instantiatesCanonicalElement==null) _instantiatesCanonicalElement = new List<Canonical>(); return _instantiatesCanonicalElement; }
            set { _instantiatesCanonicalElement = value; OnPropertyChanged("InstantiatesCanonicalElement"); }
        }

        private List<Canonical> _instantiatesCanonicalElement;

        /// <summary>
        /// Instantiates FHIR protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> InstantiatesCanonical
        {
            get { return InstantiatesCanonicalElement != null ? InstantiatesCanonicalElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesCanonicalElement = null;
                else
                    InstantiatesCanonicalElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("InstantiatesCanonical");
            }
        }

        /// <summary>
        /// Instantiates external protocol or definition
        /// </summary>
        [FhirElement("instantiatesUri", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> InstantiatesUriElement
        {
            get { if (_instantiatesUriElement==null) _instantiatesUriElement = new List<FhirUri>(); return _instantiatesUriElement; }
            set { _instantiatesUriElement = value; OnPropertyChanged("InstantiatesUriElement"); }
        }

        private List<FhirUri> _instantiatesUriElement;

        /// <summary>
        /// Instantiates external protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> InstantiatesUri
        {
            get { return InstantiatesUriElement != null ? InstantiatesUriElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesUriElement = null;
                else
                    InstantiatesUriElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("InstantiatesUri");
            }
        }

        /// <summary>
        /// Fulfills plan, proposal, or order
        /// </summary>
        [FhirElement("basedOn", Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Request(s) replaced by this request
        /// </summary>
        [FhirElement("replaces", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Replaces
        {
            get { if (_replaces==null) _replaces = new List<ResourceReference>(); return _replaces; }
            set { _replaces = value; OnPropertyChanged("Replaces"); }
        }

        private List<ResourceReference> _replaces;

        /// <summary>
        /// Composite request this is part of
        /// </summary>
        [FhirElement("groupIdentifier", InSummary=true, Order=140)]
        [DataMember]
        public Identifier GroupIdentifier
        {
            get { return _groupIdentifier; }
            set { _groupIdentifier = value; OnPropertyChanged("GroupIdentifier"); }
        }

        private Identifier _groupIdentifier;

        /// <summary>
        /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<RequestStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<RequestStatus> _statusElement;

        /// <summary>
        /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RequestStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<RequestStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// proposal | plan | order
        /// </summary>
        [FhirElement("intent", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<RequestIntent> IntentElement
        {
            get { return _intentElement; }
            set { _intentElement = value; OnPropertyChanged("IntentElement"); }
        }

        private Code<RequestIntent> _intentElement;

        /// <summary>
        /// proposal | plan | order
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RequestIntent? Intent
        {
            get { return IntentElement != null ? IntentElement.Value : null; }
            set
            {
                if (value == null)
                    IntentElement = null;
                else
                    IntentElement = new Code<RequestIntent>(value);
                OnPropertyChanged("Intent");
            }
        }

        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=170)]
        [DataMember]
        public Code<RequestPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<RequestPriority> _priorityElement;

        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RequestPriority? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (value == null)
                    PriorityElement = null;
                else
                    PriorityElement = new Code<RequestPriority>(value);
                OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        /// What's being requested/ordered
        /// </summary>
        [FhirElement("code", InSummary=true, Order=180)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Who the request group is about
        /// </summary>
        [FhirElement("subject", Order=190)]
        [References("Patient","Group")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Encounter or Episode for the request group
        /// </summary>
        [FhirElement("context", Order=200)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When the request group was authored
        /// </summary>
        [FhirElement("authoredOn", Order=210)]
        [DataMember]
        public FhirDateTime AuthoredOnElement
        {
            get { return _authoredOnElement; }
            set { _authoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }

        private FhirDateTime _authoredOnElement;

        /// <summary>
        /// When the request group was authored
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string AuthoredOn
        {
            get { return AuthoredOnElement != null ? AuthoredOnElement.Value : null; }
            set
            {
                if (value == null)
                    AuthoredOnElement = null;
                else
                    AuthoredOnElement = new FhirDateTime(value);
                OnPropertyChanged("AuthoredOn");
            }
        }

        /// <summary>
        /// Device or practitioner that authored the request group
        /// </summary>
        [FhirElement("author", Order=220)]
        [References("Device","Practitioner")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// Why the request group is needed
        /// </summary>
        [FhirElement("reasonCode", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Why the request group is needed
        /// </summary>
        [FhirElement("reasonReference", Order=240)]
        [References("Condition","Observation","DiagnosticReport","DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// Additional notes about the response
        /// </summary>
        [FhirElement("note", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Proposed actions, if any
        /// </summary>
        [FhirElement("action", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ActionComponent> Action
        {
            get { if (_action==null) _action = new List<ActionComponent>(); return _action; }
            set { _action = value; OnPropertyChanged("Action"); }
        }

        private List<ActionComponent> _action;


        public static ElementDefinition.ConstraintComponent RequestGroup_RQG_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "action.all(resource.exists() != action.exists())",
            Key = "rqg-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Must have resource or action but not both",
            Xpath = "exists(f:resource) != exists(f:action)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(RequestGroup_RQG_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as RequestGroup;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (InstantiatesCanonicalElement != null) dest.InstantiatesCanonicalElement = new List<Canonical>(InstantiatesCanonicalElement.DeepCopy());
                if (InstantiatesUriElement != null) dest.InstantiatesUriElement = new List<FhirUri>(InstantiatesUriElement.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (Replaces != null) dest.Replaces = new List<ResourceReference>(Replaces.DeepCopy());
                if (GroupIdentifier != null) dest.GroupIdentifier = (Identifier)GroupIdentifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<RequestStatus>)StatusElement.DeepCopy();
                if (IntentElement != null) dest.IntentElement = (Code<RequestIntent>)IntentElement.DeepCopy();
                if (PriorityElement != null) dest.PriorityElement = (Code<RequestPriority>)PriorityElement.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (AuthoredOnElement != null) dest.AuthoredOnElement = (FhirDateTime)AuthoredOnElement.DeepCopy();
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Action != null) dest.Action = new List<ActionComponent>(Action.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new RequestGroup());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as RequestGroup;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(InstantiatesCanonicalElement, otherT.InstantiatesCanonicalElement)) return false;
            if ( !DeepComparable.Matches(InstantiatesUriElement, otherT.InstantiatesUriElement)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.Matches(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Action, otherT.Action)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as RequestGroup;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(InstantiatesCanonicalElement, otherT.InstantiatesCanonicalElement)) return false;
            if (!DeepComparable.IsExactly(InstantiatesUriElement, otherT.InstantiatesUriElement)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.IsExactly(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in InstantiatesCanonicalElement) { if (elem != null) yield return elem; }
                foreach (var elem in InstantiatesUriElement) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in Replaces) { if (elem != null) yield return elem; }
                if (GroupIdentifier != null) yield return GroupIdentifier;
                if (StatusElement != null) yield return StatusElement;
                if (IntentElement != null) yield return IntentElement;
                if (PriorityElement != null) yield return PriorityElement;
                if (Code != null) yield return Code;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (Author != null) yield return Author;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Action) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in InstantiatesCanonicalElement) { if (elem != null) yield return new ElementValue("instantiatesCanonical", elem); }
                foreach (var elem in InstantiatesUriElement) { if (elem != null) yield return new ElementValue("instantiatesUri", elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                foreach (var elem in Replaces) { if (elem != null) yield return new ElementValue("replaces", elem); }
                if (GroupIdentifier != null) yield return new ElementValue("groupIdentifier", GroupIdentifier);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (IntentElement != null) yield return new ElementValue("intent", IntentElement);
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                if (Code != null) yield return new ElementValue("code", Code);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", AuthoredOnElement);
                if (Author != null) yield return new ElementValue("author", Author);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
            }
        }

    }

}
