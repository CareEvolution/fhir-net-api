﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// The definition of a plan for a series of actions, independent of any specific patient or context
    /// </summary>
    [FhirType("PlanDefinition", IsResource=true)]
    [DataContract]
    public partial class PlanDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.PlanDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "PlanDefinition"; } }


        [FhirType("GoalComponent")]
        [DataContract]
        public partial class GoalComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GoalComponent"; } }

            /// <summary>
            /// E.g. Treatment, dietary, behavioral
            /// </summary>
            [FhirElement("category", Order=40)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Code or text describing the goal
            /// </summary>
            [FhirElement("description", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Description
            {
                get { return _description; }
                set { _description = value; OnPropertyChanged("Description"); }
            }

            private CodeableConcept _description;

            /// <summary>
            /// high-priority | medium-priority | low-priority
            /// </summary>
            [FhirElement("priority", Order=60)]
            [DataMember]
            public CodeableConcept Priority
            {
                get { return _priority; }
                set { _priority = value; OnPropertyChanged("Priority"); }
            }

            private CodeableConcept _priority;

            /// <summary>
            /// When goal pursuit begins
            /// </summary>
            [FhirElement("start", Order=70)]
            [DataMember]
            public CodeableConcept Start
            {
                get { return _start; }
                set { _start = value; OnPropertyChanged("Start"); }
            }

            private CodeableConcept _start;

            /// <summary>
            /// What does the goal address
            /// </summary>
            [FhirElement("addresses", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Addresses
            {
                get { if (_addresses==null) _addresses = new List<CodeableConcept>(); return _addresses; }
                set { _addresses = value; OnPropertyChanged("Addresses"); }
            }

            private List<CodeableConcept> _addresses;

            /// <summary>
            /// Supporting documentation for the goal
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
            /// Target outcome for the goal
            /// </summary>
            [FhirElement("target", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TargetComponent> Target
            {
                get { if (_target==null) _target = new List<TargetComponent>(); return _target; }
                set { _target = value; OnPropertyChanged("Target"); }
            }

            private List<TargetComponent> _target;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GoalComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Description != null) dest.Description = (CodeableConcept)Description.DeepCopy();
                    if (Priority != null) dest.Priority = (CodeableConcept)Priority.DeepCopy();
                    if (Start != null) dest.Start = (CodeableConcept)Start.DeepCopy();
                    if (Addresses != null) dest.Addresses = new List<CodeableConcept>(Addresses.DeepCopy());
                    if (Documentation != null) dest.Documentation = new List<RelatedArtifact>(Documentation.DeepCopy());
                    if (Target != null) dest.Target = new List<TargetComponent>(Target.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GoalComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GoalComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Description, otherT.Description)) return false;
                if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;
                if (!DeepComparable.Matches(Start, otherT.Start)) return false;
                if ( !DeepComparable.Matches(Addresses, otherT.Addresses)) return false;
                if ( !DeepComparable.Matches(Documentation, otherT.Documentation)) return false;
                if ( !DeepComparable.Matches(Target, otherT.Target)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GoalComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
                if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
                if (!DeepComparable.IsExactly(Start, otherT.Start)) return false;
                if (!DeepComparable.IsExactly(Addresses, otherT.Addresses)) return false;
                if (!DeepComparable.IsExactly(Documentation, otherT.Documentation)) return false;
                if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    if (Description != null) yield return Description;
                    if (Priority != null) yield return Priority;
                    if (Start != null) yield return Start;
                    foreach (var elem in Addresses) { if (elem != null) yield return elem; }
                    foreach (var elem in Documentation) { if (elem != null) yield return elem; }
                    foreach (var elem in Target) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Description != null) yield return new ElementValue("description", Description);
                    if (Priority != null) yield return new ElementValue("priority", Priority);
                    if (Start != null) yield return new ElementValue("start", Start);
                    foreach (var elem in Addresses) { if (elem != null) yield return new ElementValue("addresses", elem); }
                    foreach (var elem in Documentation) { if (elem != null) yield return new ElementValue("documentation", elem); }
                    foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", elem); }
                }
            }


        }


        [FhirType("TargetComponent")]
        [DataContract]
        public partial class TargetComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TargetComponent"; } }

            /// <summary>
            /// The parameter whose value is to be tracked
            /// </summary>
            [FhirElement("measure", Order=40)]
            [DataMember]
            public CodeableConcept Measure
            {
                get { return _measure; }
                set { _measure = value; OnPropertyChanged("Measure"); }
            }

            private CodeableConcept _measure;

            /// <summary>
            /// The target value to be achieved
            /// </summary>
            [FhirElement("detail", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Quantity),typeof(Range),typeof(CodeableConcept))]
            [DataMember]
            public Element Detail
            {
                get { return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private Element _detail;

            /// <summary>
            /// Reach goal within
            /// </summary>
            [FhirElement("due", Order=60)]
            [DataMember]
            public Duration Due
            {
                get { return _due; }
                set { _due = value; OnPropertyChanged("Due"); }
            }

            private Duration _due;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TargetComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Measure != null) dest.Measure = (CodeableConcept)Measure.DeepCopy();
                    if (Detail != null) dest.Detail = (Element)Detail.DeepCopy();
                    if (Due != null) dest.Due = (Duration)Due.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TargetComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TargetComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Measure, otherT.Measure)) return false;
                if (!DeepComparable.Matches(Detail, otherT.Detail)) return false;
                if (!DeepComparable.Matches(Due, otherT.Due)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TargetComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Measure, otherT.Measure)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
                if (!DeepComparable.IsExactly(Due, otherT.Due)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Measure != null) yield return Measure;
                    if (Detail != null) yield return Detail;
                    if (Due != null) yield return Due;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Measure != null) yield return new ElementValue("measure", Measure);
                    if (Detail != null) yield return new ElementValue("detail", Detail);
                    if (Due != null) yield return new ElementValue("due", Due);
                }
            }


        }


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
            /// Brief description of the action
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
            /// Brief description of the action
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
            [FhirElement("textEquivalent", Order=70)]
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
            /// routine | urgent | asap | stat
            /// </summary>
            [FhirElement("priority", Order=80)]
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
            /// Code representing the meaning of the action or sub-actions
            /// </summary>
            [FhirElement("code", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Code
            {
                get { if (_code==null) _code = new List<CodeableConcept>(); return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private List<CodeableConcept> _code;

            /// <summary>
            /// Why the action should be performed
            /// </summary>
            [FhirElement("reason", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Reason
            {
                get { if (_reason==null) _reason = new List<CodeableConcept>(); return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private List<CodeableConcept> _reason;

            /// <summary>
            /// Supporting documentation for the intended performer of the action
            /// </summary>
            [FhirElement("documentation", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<RelatedArtifact> Documentation
            {
                get { if (_documentation==null) _documentation = new List<RelatedArtifact>(); return _documentation; }
                set { _documentation = value; OnPropertyChanged("Documentation"); }
            }

            private List<RelatedArtifact> _documentation;

            /// <summary>
            /// What goals this action supports
            /// </summary>
            [FhirElement("goalId", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Id> GoalIdElement
            {
                get { if (_goalIdElement==null) _goalIdElement = new List<Id>(); return _goalIdElement; }
                set { _goalIdElement = value; OnPropertyChanged("GoalIdElement"); }
            }

            private List<Id> _goalIdElement;

            /// <summary>
            /// What goals this action supports
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> GoalId
            {
                get { return GoalIdElement != null ? GoalIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        GoalIdElement = null;
                    else
                        GoalIdElement = new List<Id>(value.Select(elem=>new Id(elem)));
                    OnPropertyChanged("GoalId");
                }
            }

            /// <summary>
            /// When the action should be triggered
            /// </summary>
            [FhirElement("trigger", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TriggerDefinition> Trigger
            {
                get { if (_trigger==null) _trigger = new List<TriggerDefinition>(); return _trigger; }
                set { _trigger = value; OnPropertyChanged("Trigger"); }
            }

            private List<TriggerDefinition> _trigger;

            /// <summary>
            /// Whether or not the action is applicable
            /// </summary>
            [FhirElement("condition", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ConditionComponent> Condition
            {
                get { if (_condition==null) _condition = new List<ConditionComponent>(); return _condition; }
                set { _condition = value; OnPropertyChanged("Condition"); }
            }

            private List<ConditionComponent> _condition;

            /// <summary>
            /// Input data requirements
            /// </summary>
            [FhirElement("input", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DataRequirement> Input
            {
                get { if (_input==null) _input = new List<DataRequirement>(); return _input; }
                set { _input = value; OnPropertyChanged("Input"); }
            }

            private List<DataRequirement> _input;

            /// <summary>
            /// Output data definition
            /// </summary>
            [FhirElement("output", Order=160)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DataRequirement> Output
            {
                get { if (_output==null) _output = new List<DataRequirement>(); return _output; }
                set { _output = value; OnPropertyChanged("Output"); }
            }

            private List<DataRequirement> _output;

            /// <summary>
            /// Relationship to another action
            /// </summary>
            [FhirElement("relatedAction", Order=170)]
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
            [FhirElement("timing", Order=180, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirDateTime),typeof(Age),typeof(Period),typeof(Duration),typeof(Range),typeof(Timing))]
            [DataMember]
            public Element Timing
            {
                get { return _timing; }
                set { _timing = value; OnPropertyChanged("Timing"); }
            }

            private Element _timing;

            /// <summary>
            /// Who should participate in the action
            /// </summary>
            [FhirElement("participant", Order=190)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParticipantComponent> Participant
            {
                get { if (_participant==null) _participant = new List<ParticipantComponent>(); return _participant; }
                set { _participant = value; OnPropertyChanged("Participant"); }
            }

            private List<ParticipantComponent> _participant;

            /// <summary>
            /// create | update | remove | fire-event
            /// </summary>
            [FhirElement("type", Order=200)]
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
            [FhirElement("groupingBehavior", Order=210)]
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
            [FhirElement("selectionBehavior", Order=220)]
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
            [FhirElement("requiredBehavior", Order=230)]
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
            [FhirElement("precheckBehavior", Order=240)]
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
            [FhirElement("cardinalityBehavior", Order=250)]
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
            /// Description of the activity to be performed
            /// </summary>
            [FhirElement("definition", Order=260)]
            [DataMember]
            public Canonical DefinitionElement
            {
                get { return _definitionElement; }
                set { _definitionElement = value; OnPropertyChanged("DefinitionElement"); }
            }

            private Canonical _definitionElement;

            /// <summary>
            /// Description of the activity to be performed
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
            /// Transform to apply the template
            /// </summary>
            [FhirElement("transform", Order=270)]
            [DataMember]
            public Canonical TransformElement
            {
                get { return _transformElement; }
                set { _transformElement = value; OnPropertyChanged("TransformElement"); }
            }

            private Canonical _transformElement;

            /// <summary>
            /// Transform to apply the template
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Transform
            {
                get { return TransformElement != null ? TransformElement.Value : null; }
                set
                {
                    if (value == null)
                        TransformElement = null;
                    else
                        TransformElement = new Canonical(value);
                    OnPropertyChanged("Transform");
                }
            }

            /// <summary>
            /// Dynamic aspects of the definition
            /// </summary>
            [FhirElement("dynamicValue", Order=280)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DynamicValueComponent> DynamicValue
            {
                get { if (_dynamicValue==null) _dynamicValue = new List<DynamicValueComponent>(); return _dynamicValue; }
                set { _dynamicValue = value; OnPropertyChanged("DynamicValue"); }
            }

            private List<DynamicValueComponent> _dynamicValue;

            /// <summary>
            /// A sub-action
            /// </summary>
            [FhirElement("action", Order=290)]
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
                    if (PriorityElement != null) dest.PriorityElement = (Code<RequestPriority>)PriorityElement.DeepCopy();
                    if (Code != null) dest.Code = new List<CodeableConcept>(Code.DeepCopy());
                    if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                    if (Documentation != null) dest.Documentation = new List<RelatedArtifact>(Documentation.DeepCopy());
                    if (GoalIdElement != null) dest.GoalIdElement = new List<Id>(GoalIdElement.DeepCopy());
                    if (Trigger != null) dest.Trigger = new List<TriggerDefinition>(Trigger.DeepCopy());
                    if (Condition != null) dest.Condition = new List<ConditionComponent>(Condition.DeepCopy());
                    if (Input != null) dest.Input = new List<DataRequirement>(Input.DeepCopy());
                    if (Output != null) dest.Output = new List<DataRequirement>(Output.DeepCopy());
                    if (RelatedAction != null) dest.RelatedAction = new List<RelatedActionComponent>(RelatedAction.DeepCopy());
                    if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
                    if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (GroupingBehaviorElement != null) dest.GroupingBehaviorElement = (Code<ActionGroupingBehavior>)GroupingBehaviorElement.DeepCopy();
                    if (SelectionBehaviorElement != null) dest.SelectionBehaviorElement = (Code<ActionSelectionBehavior>)SelectionBehaviorElement.DeepCopy();
                    if (RequiredBehaviorElement != null) dest.RequiredBehaviorElement = (Code<ActionRequiredBehavior>)RequiredBehaviorElement.DeepCopy();
                    if (PrecheckBehaviorElement != null) dest.PrecheckBehaviorElement = (Code<ActionPrecheckBehavior>)PrecheckBehaviorElement.DeepCopy();
                    if (CardinalityBehaviorElement != null) dest.CardinalityBehaviorElement = (Code<ActionCardinalityBehavior>)CardinalityBehaviorElement.DeepCopy();
                    if (DefinitionElement != null) dest.DefinitionElement = (Canonical)DefinitionElement.DeepCopy();
                    if (TransformElement != null) dest.TransformElement = (Canonical)TransformElement.DeepCopy();
                    if (DynamicValue != null) dest.DynamicValue = new List<DynamicValueComponent>(DynamicValue.DeepCopy());
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
                if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
                if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if ( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if ( !DeepComparable.Matches(Documentation, otherT.Documentation)) return false;
                if ( !DeepComparable.Matches(GoalIdElement, otherT.GoalIdElement)) return false;
                if ( !DeepComparable.Matches(Trigger, otherT.Trigger)) return false;
                if ( !DeepComparable.Matches(Condition, otherT.Condition)) return false;
                if ( !DeepComparable.Matches(Input, otherT.Input)) return false;
                if ( !DeepComparable.Matches(Output, otherT.Output)) return false;
                if ( !DeepComparable.Matches(RelatedAction, otherT.RelatedAction)) return false;
                if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
                if ( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(GroupingBehaviorElement, otherT.GroupingBehaviorElement)) return false;
                if (!DeepComparable.Matches(SelectionBehaviorElement, otherT.SelectionBehaviorElement)) return false;
                if (!DeepComparable.Matches(RequiredBehaviorElement, otherT.RequiredBehaviorElement)) return false;
                if (!DeepComparable.Matches(PrecheckBehaviorElement, otherT.PrecheckBehaviorElement)) return false;
                if (!DeepComparable.Matches(CardinalityBehaviorElement, otherT.CardinalityBehaviorElement)) return false;
                if (!DeepComparable.Matches(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.Matches(TransformElement, otherT.TransformElement)) return false;
                if ( !DeepComparable.Matches(DynamicValue, otherT.DynamicValue)) return false;
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
                if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if (!DeepComparable.IsExactly(Documentation, otherT.Documentation)) return false;
                if (!DeepComparable.IsExactly(GoalIdElement, otherT.GoalIdElement)) return false;
                if (!DeepComparable.IsExactly(Trigger, otherT.Trigger)) return false;
                if (!DeepComparable.IsExactly(Condition, otherT.Condition)) return false;
                if (!DeepComparable.IsExactly(Input, otherT.Input)) return false;
                if (!DeepComparable.IsExactly(Output, otherT.Output)) return false;
                if (!DeepComparable.IsExactly(RelatedAction, otherT.RelatedAction)) return false;
                if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
                if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(GroupingBehaviorElement, otherT.GroupingBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(SelectionBehaviorElement, otherT.SelectionBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(RequiredBehaviorElement, otherT.RequiredBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(PrecheckBehaviorElement, otherT.PrecheckBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(CardinalityBehaviorElement, otherT.CardinalityBehaviorElement)) return false;
                if (!DeepComparable.IsExactly(DefinitionElement, otherT.DefinitionElement)) return false;
                if (!DeepComparable.IsExactly(TransformElement, otherT.TransformElement)) return false;
                if (!DeepComparable.IsExactly(DynamicValue, otherT.DynamicValue)) return false;
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
                    if (PriorityElement != null) yield return PriorityElement;
                    foreach (var elem in Code) { if (elem != null) yield return elem; }
                    foreach (var elem in Reason) { if (elem != null) yield return elem; }
                    foreach (var elem in Documentation) { if (elem != null) yield return elem; }
                    foreach (var elem in GoalIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Trigger) { if (elem != null) yield return elem; }
                    foreach (var elem in Condition) { if (elem != null) yield return elem; }
                    foreach (var elem in Input) { if (elem != null) yield return elem; }
                    foreach (var elem in Output) { if (elem != null) yield return elem; }
                    foreach (var elem in RelatedAction) { if (elem != null) yield return elem; }
                    if (Timing != null) yield return Timing;
                    foreach (var elem in Participant) { if (elem != null) yield return elem; }
                    if (Type != null) yield return Type;
                    if (GroupingBehaviorElement != null) yield return GroupingBehaviorElement;
                    if (SelectionBehaviorElement != null) yield return SelectionBehaviorElement;
                    if (RequiredBehaviorElement != null) yield return RequiredBehaviorElement;
                    if (PrecheckBehaviorElement != null) yield return PrecheckBehaviorElement;
                    if (CardinalityBehaviorElement != null) yield return CardinalityBehaviorElement;
                    if (DefinitionElement != null) yield return DefinitionElement;
                    if (TransformElement != null) yield return TransformElement;
                    foreach (var elem in DynamicValue) { if (elem != null) yield return elem; }
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
                    if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                    foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                    foreach (var elem in Documentation) { if (elem != null) yield return new ElementValue("documentation", elem); }
                    foreach (var elem in GoalIdElement) { if (elem != null) yield return new ElementValue("goalId", elem); }
                    foreach (var elem in Trigger) { if (elem != null) yield return new ElementValue("trigger", elem); }
                    foreach (var elem in Condition) { if (elem != null) yield return new ElementValue("condition", elem); }
                    foreach (var elem in Input) { if (elem != null) yield return new ElementValue("input", elem); }
                    foreach (var elem in Output) { if (elem != null) yield return new ElementValue("output", elem); }
                    foreach (var elem in RelatedAction) { if (elem != null) yield return new ElementValue("relatedAction", elem); }
                    if (Timing != null) yield return new ElementValue("timing", Timing);
                    foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (GroupingBehaviorElement != null) yield return new ElementValue("groupingBehavior", GroupingBehaviorElement);
                    if (SelectionBehaviorElement != null) yield return new ElementValue("selectionBehavior", SelectionBehaviorElement);
                    if (RequiredBehaviorElement != null) yield return new ElementValue("requiredBehavior", RequiredBehaviorElement);
                    if (PrecheckBehaviorElement != null) yield return new ElementValue("precheckBehavior", PrecheckBehaviorElement);
                    if (CardinalityBehaviorElement != null) yield return new ElementValue("cardinalityBehavior", CardinalityBehaviorElement);
                    if (DefinitionElement != null) yield return new ElementValue("definition", DefinitionElement);
                    if (TransformElement != null) yield return new ElementValue("transform", TransformElement);
                    foreach (var elem in DynamicValue) { if (elem != null) yield return new ElementValue("dynamicValue", elem); }
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
            /// Boolean-valued expression
            /// </summary>
            [FhirElement("expression", Order=50)]
            [DataMember]
            public Expression Expression
            {
                get { return _expression; }
                set { _expression = value; OnPropertyChanged("Expression"); }
            }

            private Expression _expression;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ConditionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (KindElement != null) dest.KindElement = (Code<ActionConditionKind>)KindElement.DeepCopy();
                    if (Expression != null) dest.Expression = (Expression)Expression.DeepCopy();
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
                if (!DeepComparable.Matches(Expression, otherT.Expression)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ConditionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
                if (!DeepComparable.IsExactly(Expression, otherT.Expression)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (KindElement != null) yield return KindElement;
                    if (Expression != null) yield return Expression;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (KindElement != null) yield return new ElementValue("kind", KindElement);
                    if (Expression != null) yield return new ElementValue("expression", Expression);
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
            /// What action is this related to
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
            /// What action is this related to
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


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// patient | practitioner | related-person | device
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ActionParticipantType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<ActionParticipantType> _typeElement;

            /// <summary>
            /// patient | practitioner | related-person | device
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ActionParticipantType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<ActionParticipantType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// E.g. Nurse, Surgeon, Parent
            /// </summary>
            [FhirElement("role", Order=50)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ActionParticipantType>)TypeElement.DeepCopy();
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParticipantComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Role != null) yield return Role;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (Role != null) yield return new ElementValue("role", Role);
                }
            }


        }


        [FhirType("DynamicValueComponent")]
        [DataContract]
        public partial class DynamicValueComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DynamicValueComponent"; } }

            /// <summary>
            /// The path to the element to be set dynamically
            /// </summary>
            [FhirElement("path", Order=40)]
            [DataMember]
            public FhirString PathElement
            {
                get { return _pathElement; }
                set { _pathElement = value; OnPropertyChanged("PathElement"); }
            }

            private FhirString _pathElement;

            /// <summary>
            /// The path to the element to be set dynamically
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Path
            {
                get { return PathElement != null ? PathElement.Value : null; }
                set
                {
                    if (value == null)
                        PathElement = null;
                    else
                        PathElement = new FhirString(value);
                    OnPropertyChanged("Path");
                }
            }

            /// <summary>
            /// An expression that provides the dynamic value for the customization
            /// </summary>
            [FhirElement("expression", Order=50)]
            [DataMember]
            public Expression Expression
            {
                get { return _expression; }
                set { _expression = value; OnPropertyChanged("Expression"); }
            }

            private Expression _expression;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DynamicValueComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PathElement != null) dest.PathElement = (FhirString)PathElement.DeepCopy();
                    if (Expression != null) dest.Expression = (Expression)Expression.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DynamicValueComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DynamicValueComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.Matches(Expression, otherT.Expression)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DynamicValueComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PathElement, otherT.PathElement)) return false;
                if (!DeepComparable.IsExactly(Expression, otherT.Expression)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PathElement != null) yield return PathElement;
                    if (Expression != null) yield return Expression;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PathElement != null) yield return new ElementValue("path", PathElement);
                    if (Expression != null) yield return new ElementValue("expression", Expression);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this plan definition, represented as a URI (globally unique)
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
        /// Canonical identifier for this plan definition, represented as a URI (globally unique)
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
        /// Additional identifier for the plan definition
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
        /// Business version of the plan definition
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
        /// Business version of the plan definition
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
        /// Name for this plan definition (computer friendly)
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
        /// Name for this plan definition (computer friendly)
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
        /// Name for this plan definition (human friendly)
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
        /// Name for this plan definition (human friendly)
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
        /// Subordinate title of the plan definition
        /// </summary>
        [FhirElement("subtitle", Order=140)]
        [DataMember]
        public FhirString SubtitleElement
        {
            get { return _subtitleElement; }
            set { _subtitleElement = value; OnPropertyChanged("SubtitleElement"); }
        }

        private FhirString _subtitleElement;

        /// <summary>
        /// Subordinate title of the plan definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Subtitle
        {
            get { return SubtitleElement != null ? SubtitleElement.Value : null; }
            set
            {
                if (value == null)
                    SubtitleElement = null;
                else
                    SubtitleElement = new FhirString(value);
                OnPropertyChanged("Subtitle");
            }
        }

        /// <summary>
        /// order-set | clinical-protocol | eca-rule | workflow-definition
        /// </summary>
        [FhirElement("type", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=160)]
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
        [FhirElement("experimental", InSummary=true, Order=170)]
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
        /// Type of individual the plan definition is focused on
        /// </summary>
        [FhirElement("subject", Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private Element _subject;

        /// <summary>
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=190)]
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
        [FhirElement("publisher", InSummary=true, Order=200)]
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
        [FhirElement("contact", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Natural language description of the plan definition
        /// </summary>
        [FhirElement("description", InSummary=true, Order=220)]
        [DataMember]
        public Markdown DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private Markdown _descriptionElement;

        /// <summary>
        /// Natural language description of the plan definition
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
                    DescriptionElement = new Markdown(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for plan definition (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Why this plan definition is defined
        /// </summary>
        [FhirElement("purpose", Order=250)]
        [DataMember]
        public Markdown PurposeElement
        {
            get { return _purposeElement; }
            set { _purposeElement = value; OnPropertyChanged("PurposeElement"); }
        }

        private Markdown _purposeElement;

        /// <summary>
        /// Why this plan definition is defined
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Purpose
        {
            get { return PurposeElement != null ? PurposeElement.Value : null; }
            set
            {
                if (value == null)
                    PurposeElement = null;
                else
                    PurposeElement = new Markdown(value);
                OnPropertyChanged("Purpose");
            }
        }

        /// <summary>
        /// Describes the clinical usage of the plan
        /// </summary>
        [FhirElement("usage", Order=260)]
        [DataMember]
        public FhirString UsageElement
        {
            get { return _usageElement; }
            set { _usageElement = value; OnPropertyChanged("UsageElement"); }
        }

        private FhirString _usageElement;

        /// <summary>
        /// Describes the clinical usage of the plan
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Usage
        {
            get { return UsageElement != null ? UsageElement.Value : null; }
            set
            {
                if (value == null)
                    UsageElement = null;
                else
                    UsageElement = new FhirString(value);
                OnPropertyChanged("Usage");
            }
        }

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=270)]
        [DataMember]
        public Markdown CopyrightElement
        {
            get { return _copyrightElement; }
            set { _copyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }

        private Markdown _copyrightElement;

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
                    CopyrightElement = new Markdown(value);
                OnPropertyChanged("Copyright");
            }
        }

        /// <summary>
        /// When the plan definition was approved by publisher
        /// </summary>
        [FhirElement("approvalDate", Order=280)]
        [DataMember]
        public Date ApprovalDateElement
        {
            get { return _approvalDateElement; }
            set { _approvalDateElement = value; OnPropertyChanged("ApprovalDateElement"); }
        }

        private Date _approvalDateElement;

        /// <summary>
        /// When the plan definition was approved by publisher
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
        /// When the plan definition was last reviewed
        /// </summary>
        [FhirElement("lastReviewDate", Order=290)]
        [DataMember]
        public Date LastReviewDateElement
        {
            get { return _lastReviewDateElement; }
            set { _lastReviewDateElement = value; OnPropertyChanged("LastReviewDateElement"); }
        }

        private Date _lastReviewDateElement;

        /// <summary>
        /// When the plan definition was last reviewed
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
        /// When the plan definition is expected to be used
        /// </summary>
        [FhirElement("effectivePeriod", InSummary=true, Order=300)]
        [DataMember]
        public Period EffectivePeriod
        {
            get { return _effectivePeriod; }
            set { _effectivePeriod = value; OnPropertyChanged("EffectivePeriod"); }
        }

        private Period _effectivePeriod;

        /// <summary>
        /// E.g. Education, Treatment, Assessment
        /// </summary>
        [FhirElement("topic", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Topic
        {
            get { if (_topic==null) _topic = new List<CodeableConcept>(); return _topic; }
            set { _topic = value; OnPropertyChanged("Topic"); }
        }

        private List<CodeableConcept> _topic;

        /// <summary>
        /// Who authored the content
        /// </summary>
        [FhirElement("author", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Author
        {
            get { if (_author==null) _author = new List<ContactDetail>(); return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private List<ContactDetail> _author;

        /// <summary>
        /// Who edited the content
        /// </summary>
        [FhirElement("editor", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Editor
        {
            get { if (_editor==null) _editor = new List<ContactDetail>(); return _editor; }
            set { _editor = value; OnPropertyChanged("Editor"); }
        }

        private List<ContactDetail> _editor;

        /// <summary>
        /// Who reviewed the content
        /// </summary>
        [FhirElement("reviewer", Order=340)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Reviewer
        {
            get { if (_reviewer==null) _reviewer = new List<ContactDetail>(); return _reviewer; }
            set { _reviewer = value; OnPropertyChanged("Reviewer"); }
        }

        private List<ContactDetail> _reviewer;

        /// <summary>
        /// Who endorsed the content
        /// </summary>
        [FhirElement("endorser", Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Endorser
        {
            get { if (_endorser==null) _endorser = new List<ContactDetail>(); return _endorser; }
            set { _endorser = value; OnPropertyChanged("Endorser"); }
        }

        private List<ContactDetail> _endorser;

        /// <summary>
        /// Additional documentation, citations
        /// </summary>
        [FhirElement("relatedArtifact", Order=360)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedArtifact> RelatedArtifact
        {
            get { if (_relatedArtifact==null) _relatedArtifact = new List<RelatedArtifact>(); return _relatedArtifact; }
            set { _relatedArtifact = value; OnPropertyChanged("RelatedArtifact"); }
        }

        private List<RelatedArtifact> _relatedArtifact;

        /// <summary>
        /// Logic used by the plan definition
        /// </summary>
        [FhirElement("library", Order=370)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> LibraryElement
        {
            get { if (_libraryElement==null) _libraryElement = new List<Canonical>(); return _libraryElement; }
            set { _libraryElement = value; OnPropertyChanged("LibraryElement"); }
        }

        private List<Canonical> _libraryElement;

        /// <summary>
        /// Logic used by the plan definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Library
        {
            get { return LibraryElement != null ? LibraryElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    LibraryElement = null;
                else
                    LibraryElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("Library");
            }
        }

        /// <summary>
        /// What the plan is trying to accomplish
        /// </summary>
        [FhirElement("goal", Order=380)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GoalComponent> Goal
        {
            get { if (_goal==null) _goal = new List<GoalComponent>(); return _goal; }
            set { _goal = value; OnPropertyChanged("Goal"); }
        }

        private List<GoalComponent> _goal;

        /// <summary>
        /// Action defined by the plan
        /// </summary>
        [FhirElement("action", Order=390)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ActionComponent> Action
        {
            get { if (_action==null) _action = new List<ActionComponent>(); return _action; }
            set { _action = value; OnPropertyChanged("Action"); }
        }

        private List<ActionComponent> _action;


        public static ElementDefinition.ConstraintComponent PlanDefinition_PDF_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "pdf-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(PlanDefinition_PDF_0);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as PlanDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (SubtitleElement != null) dest.SubtitleElement = (FhirString)SubtitleElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (Subject != null) dest.Subject = (Element)Subject.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (PurposeElement != null) dest.PurposeElement = (Markdown)PurposeElement.DeepCopy();
                if (UsageElement != null) dest.UsageElement = (FhirString)UsageElement.DeepCopy();
                if (CopyrightElement != null) dest.CopyrightElement = (Markdown)CopyrightElement.DeepCopy();
                if (ApprovalDateElement != null) dest.ApprovalDateElement = (Date)ApprovalDateElement.DeepCopy();
                if (LastReviewDateElement != null) dest.LastReviewDateElement = (Date)LastReviewDateElement.DeepCopy();
                if (EffectivePeriod != null) dest.EffectivePeriod = (Period)EffectivePeriod.DeepCopy();
                if (Topic != null) dest.Topic = new List<CodeableConcept>(Topic.DeepCopy());
                if (Author != null) dest.Author = new List<ContactDetail>(Author.DeepCopy());
                if (Editor != null) dest.Editor = new List<ContactDetail>(Editor.DeepCopy());
                if (Reviewer != null) dest.Reviewer = new List<ContactDetail>(Reviewer.DeepCopy());
                if (Endorser != null) dest.Endorser = new List<ContactDetail>(Endorser.DeepCopy());
                if (RelatedArtifact != null) dest.RelatedArtifact = new List<RelatedArtifact>(RelatedArtifact.DeepCopy());
                if (LibraryElement != null) dest.LibraryElement = new List<Canonical>(LibraryElement.DeepCopy());
                if (Goal != null) dest.Goal = new List<GoalComponent>(Goal.DeepCopy());
                if (Action != null) dest.Action = new List<ActionComponent>(Action.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new PlanDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as PlanDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(SubtitleElement, otherT.SubtitleElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.Matches(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.Matches(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.Matches(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.Matches(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if ( !DeepComparable.Matches(Topic, otherT.Topic)) return false;
            if ( !DeepComparable.Matches(Author, otherT.Author)) return false;
            if ( !DeepComparable.Matches(Editor, otherT.Editor)) return false;
            if ( !DeepComparable.Matches(Reviewer, otherT.Reviewer)) return false;
            if ( !DeepComparable.Matches(Endorser, otherT.Endorser)) return false;
            if ( !DeepComparable.Matches(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if ( !DeepComparable.Matches(LibraryElement, otherT.LibraryElement)) return false;
            if ( !DeepComparable.Matches(Goal, otherT.Goal)) return false;
            if ( !DeepComparable.Matches(Action, otherT.Action)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as PlanDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(SubtitleElement, otherT.SubtitleElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(PurposeElement, otherT.PurposeElement)) return false;
            if (!DeepComparable.IsExactly(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.IsExactly(ApprovalDateElement, otherT.ApprovalDateElement)) return false;
            if (!DeepComparable.IsExactly(LastReviewDateElement, otherT.LastReviewDateElement)) return false;
            if (!DeepComparable.IsExactly(EffectivePeriod, otherT.EffectivePeriod)) return false;
            if (!DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Editor, otherT.Editor)) return false;
            if (!DeepComparable.IsExactly(Reviewer, otherT.Reviewer)) return false;
            if (!DeepComparable.IsExactly(Endorser, otherT.Endorser)) return false;
            if (!DeepComparable.IsExactly(RelatedArtifact, otherT.RelatedArtifact)) return false;
            if (!DeepComparable.IsExactly(LibraryElement, otherT.LibraryElement)) return false;
            if (!DeepComparable.IsExactly(Goal, otherT.Goal)) return false;
            if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;

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
                if (SubtitleElement != null) yield return SubtitleElement;
                if (Type != null) yield return Type;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (Subject != null) yield return Subject;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (PurposeElement != null) yield return PurposeElement;
                if (UsageElement != null) yield return UsageElement;
                if (CopyrightElement != null) yield return CopyrightElement;
                if (ApprovalDateElement != null) yield return ApprovalDateElement;
                if (LastReviewDateElement != null) yield return LastReviewDateElement;
                if (EffectivePeriod != null) yield return EffectivePeriod;
                foreach (var elem in Topic) { if (elem != null) yield return elem; }
                foreach (var elem in Author) { if (elem != null) yield return elem; }
                foreach (var elem in Editor) { if (elem != null) yield return elem; }
                foreach (var elem in Reviewer) { if (elem != null) yield return elem; }
                foreach (var elem in Endorser) { if (elem != null) yield return elem; }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return elem; }
                foreach (var elem in LibraryElement) { if (elem != null) yield return elem; }
                foreach (var elem in Goal) { if (elem != null) yield return elem; }
                foreach (var elem in Action) { if (elem != null) yield return elem; }
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
                if (SubtitleElement != null) yield return new ElementValue("subtitle", SubtitleElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (PurposeElement != null) yield return new ElementValue("purpose", PurposeElement);
                if (UsageElement != null) yield return new ElementValue("usage", UsageElement);
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                if (ApprovalDateElement != null) yield return new ElementValue("approvalDate", ApprovalDateElement);
                if (LastReviewDateElement != null) yield return new ElementValue("lastReviewDate", LastReviewDateElement);
                if (EffectivePeriod != null) yield return new ElementValue("effectivePeriod", EffectivePeriod);
                foreach (var elem in Topic) { if (elem != null) yield return new ElementValue("topic", elem); }
                foreach (var elem in Author) { if (elem != null) yield return new ElementValue("author", elem); }
                foreach (var elem in Editor) { if (elem != null) yield return new ElementValue("editor", elem); }
                foreach (var elem in Reviewer) { if (elem != null) yield return new ElementValue("reviewer", elem); }
                foreach (var elem in Endorser) { if (elem != null) yield return new ElementValue("endorser", elem); }
                foreach (var elem in RelatedArtifact) { if (elem != null) yield return new ElementValue("relatedArtifact", elem); }
                foreach (var elem in LibraryElement) { if (elem != null) yield return new ElementValue("library", elem); }
                foreach (var elem in Goal) { if (elem != null) yield return new ElementValue("goal", elem); }
                foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
            }
        }

    }

}