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
    /// Legal Agreement
    /// </summary>
    [FhirType("Contract", IsResource=true)]
    [DataContract]
    public partial class Contract : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Contract; } }
        [NotMapped]
        public override string TypeName { get { return "Contract"; } }

        /// <summary>
        /// This value set contract specific codes for status.
        /// (url: http://hl7.org/fhir/ValueSet/contract-status)
        /// </summary>
        [FhirEnumeration("ContractResourceStatusCodes")]
        public enum ContractResourceStatusCodes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("amended", "http://hl7.org/fhir/contract-status"), Description("Amended")]
            Amended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("appended", "http://hl7.org/fhir/contract-status"), Description("Appended")]
            Appended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/contract-status"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("disputed", "http://hl7.org/fhir/contract-status"), Description("Disputed")]
            Disputed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/contract-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("executable", "http://hl7.org/fhir/contract-status"), Description("Executable")]
            Executable,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("executed", "http://hl7.org/fhir/contract-status"), Description("Executed")]
            Executed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("negotiable", "http://hl7.org/fhir/contract-status"), Description("Negotiable")]
            Negotiable,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("offered", "http://hl7.org/fhir/contract-status"), Description("Offered")]
            Offered,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("policy", "http://hl7.org/fhir/contract-status"), Description("Policy")]
            Policy,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/contract-status"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("renewed", "http://hl7.org/fhir/contract-status"), Description("Renewed")]
            Renewed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("revoked", "http://hl7.org/fhir/contract-status"), Description("Revoked")]
            Revoked,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("resolved", "http://hl7.org/fhir/contract-status"), Description("Resolved")]
            Resolved,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-status)
            /// </summary>
            [EnumLiteral("terminated", "http://hl7.org/fhir/contract-status"), Description("Terminated")]
            Terminated,
        }

        /// <summary>
        /// How a resource reference is interpreted when evaluating contract offers
        /// (url: http://hl7.org/fhir/ValueSet/contract-data-meaning)
        /// </summary>
        [FhirEnumeration("ContractDataMeaning")]
        public enum ContractDataMeaning
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-data-meaning)
            /// </summary>
            [EnumLiteral("instance", "http://hl7.org/fhir/contract-data-meaning"), Description("Instance")]
            Instance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-data-meaning)
            /// </summary>
            [EnumLiteral("related", "http://hl7.org/fhir/contract-data-meaning"), Description("Related")]
            Related,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-data-meaning)
            /// </summary>
            [EnumLiteral("dependents", "http://hl7.org/fhir/contract-data-meaning"), Description("Dependents")]
            Dependents,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contract-data-meaning)
            /// </summary>
            [EnumLiteral("authoredby", "http://hl7.org/fhir/contract-data-meaning"), Description("AuthoredBy")]
            Authoredby,
        }


        [FhirType("TermComponent")]
        [DataContract]
        public partial class TermComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TermComponent"; } }

            /// <summary>
            /// Contract Term Number
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
            /// Contract Term Issue Date Time
            /// </summary>
            [FhirElement("issued", InSummary=true, Order=50)]
            [DataMember]
            public FhirDateTime IssuedElement
            {
                get { return _issuedElement; }
                set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
            }

            private FhirDateTime _issuedElement;

            /// <summary>
            /// Contract Term Issue Date Time
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Issued
            {
                get { return IssuedElement != null ? IssuedElement.Value : null; }
                set
                {
                    if (value == null)
                        IssuedElement = null;
                    else
                        IssuedElement = new FhirDateTime(value);
                    OnPropertyChanged("Issued");
                }
            }

            /// <summary>
            /// Contract Term Effective Time
            /// </summary>
            [FhirElement("applies", InSummary=true, Order=60)]
            [DataMember]
            public Period Applies
            {
                get { return _applies; }
                set { _applies = value; OnPropertyChanged("Applies"); }
            }

            private Period _applies;

            /// <summary>
            /// Contract Term Type or Form
            /// </summary>
            [FhirElement("type", Order=70)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Contract Term Type specific classification
            /// </summary>
            [FhirElement("subType", Order=80)]
            [DataMember]
            public CodeableConcept SubType
            {
                get { return _subType; }
                set { _subType = value; OnPropertyChanged("SubType"); }
            }

            private CodeableConcept _subType;

            /// <summary>
            /// Context of the Contract term
            /// </summary>
            [FhirElement("offer", Order=90)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ContractOfferComponent Offer
            {
                get { return _offer; }
                set { _offer = value; OnPropertyChanged("Offer"); }
            }

            private ContractOfferComponent _offer;

            /// <summary>
            /// Contract Term Asset List
            /// </summary>
            [FhirElement("asset", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContractAssetComponent> Asset
            {
                get { if (_asset==null) _asset = new List<ContractAssetComponent>(); return _asset; }
                set { _asset = value; OnPropertyChanged("Asset"); }
            }

            private List<ContractAssetComponent> _asset;

            /// <summary>
            /// Entity being ascribed responsibility
            /// </summary>
            [FhirElement("agent", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AgentComponent> Agent
            {
                get { if (_agent==null) _agent = new List<AgentComponent>(); return _agent; }
                set { _agent = value; OnPropertyChanged("Agent"); }
            }

            private List<AgentComponent> _agent;

            /// <summary>
            /// Contract Term Activity
            /// </summary>
            [FhirElement("action", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Action
            {
                get { if (_action==null) _action = new List<CodeableConcept>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<CodeableConcept> _action;

            /// <summary>
            /// Purpose for the Contract Term Action
            /// </summary>
            [FhirElement("actionReason", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ActionReason
            {
                get { if (_actionReason==null) _actionReason = new List<CodeableConcept>(); return _actionReason; }
                set { _actionReason = value; OnPropertyChanged("ActionReason"); }
            }

            private List<CodeableConcept> _actionReason;

            /// <summary>
            /// Nested Contract Term Group
            /// </summary>
            [FhirElement("group", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TermComponent> Group
            {
                get { if (_group==null) _group = new List<TermComponent>(); return _group; }
                set { _group = value; OnPropertyChanged("Group"); }
            }

            private List<TermComponent> _group;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TermComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (IssuedElement != null) dest.IssuedElement = (FhirDateTime)IssuedElement.DeepCopy();
                    if (Applies != null) dest.Applies = (Period)Applies.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (SubType != null) dest.SubType = (CodeableConcept)SubType.DeepCopy();
                    if (Offer != null) dest.Offer = (ContractOfferComponent)Offer.DeepCopy();
                    if (Asset != null) dest.Asset = new List<ContractAssetComponent>(Asset.DeepCopy());
                    if (Agent != null) dest.Agent = new List<AgentComponent>(Agent.DeepCopy());
                    if (Action != null) dest.Action = new List<CodeableConcept>(Action.DeepCopy());
                    if (ActionReason != null) dest.ActionReason = new List<CodeableConcept>(ActionReason.DeepCopy());
                    if (Group != null) dest.Group = new List<TermComponent>(Group.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TermComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TermComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
                if (!DeepComparable.Matches(Applies, otherT.Applies)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(SubType, otherT.SubType)) return false;
                if (!DeepComparable.Matches(Offer, otherT.Offer)) return false;
                if ( !DeepComparable.Matches(Asset, otherT.Asset)) return false;
                if ( !DeepComparable.Matches(Agent, otherT.Agent)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;
                if ( !DeepComparable.Matches(ActionReason, otherT.ActionReason)) return false;
                if ( !DeepComparable.Matches(Group, otherT.Group)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TermComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
                if (!DeepComparable.IsExactly(Applies, otherT.Applies)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
                if (!DeepComparable.IsExactly(Offer, otherT.Offer)) return false;
                if (!DeepComparable.IsExactly(Asset, otherT.Asset)) return false;
                if (!DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;
                if (!DeepComparable.IsExactly(ActionReason, otherT.ActionReason)) return false;
                if (!DeepComparable.IsExactly(Group, otherT.Group)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (IssuedElement != null) yield return IssuedElement;
                    if (Applies != null) yield return Applies;
                    if (Type != null) yield return Type;
                    if (SubType != null) yield return SubType;
                    if (Offer != null) yield return Offer;
                    foreach (var elem in Asset) { if (elem != null) yield return elem; }
                    foreach (var elem in Agent) { if (elem != null) yield return elem; }
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                    foreach (var elem in ActionReason) { if (elem != null) yield return elem; }
                    foreach (var elem in Group) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                    if (Applies != null) yield return new ElementValue("applies", Applies);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (SubType != null) yield return new ElementValue("subType", SubType);
                    if (Offer != null) yield return new ElementValue("offer", Offer);
                    foreach (var elem in Asset) { if (elem != null) yield return new ElementValue("asset", elem); }
                    foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", elem); }
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                    foreach (var elem in ActionReason) { if (elem != null) yield return new ElementValue("actionReason", elem); }
                    foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", elem); }
                }
            }


        }


        [FhirType("ContractOfferComponent")]
        [DataContract]
        public partial class ContractOfferComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContractOfferComponent"; } }

            /// <summary>
            /// Negotiable offer asset
            /// </summary>
            [FhirElement("topic", InSummary=true, Order=40)]
            [DataMember]
            public ResourceReference Topic
            {
                get { return _topic; }
                set { _topic = value; OnPropertyChanged("Topic"); }
            }

            private ResourceReference _topic;

            /// <summary>
            /// Contract Offer Type or Form
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Decision by Grantor
            /// </summary>
            [FhirElement("decision", Order=60)]
            [DataMember]
            public CodeableConcept Decision
            {
                get { return _decision; }
                set { _decision = value; OnPropertyChanged("Decision"); }
            }

            private CodeableConcept _decision;

            /// <summary>
            /// Human readable offer text
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
            /// Human readable offer text
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
            /// Pointer to text
            /// </summary>
            [FhirElement("linkId", Order=80)]
            [DataMember]
            public FhirString LinkIdElement
            {
                get { return _linkIdElement; }
                set { _linkIdElement = value; OnPropertyChanged("LinkIdElement"); }
            }

            private FhirString _linkIdElement;

            /// <summary>
            /// Pointer to text
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContractOfferComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Topic != null) dest.Topic = (ResourceReference)Topic.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Decision != null) dest.Decision = (CodeableConcept)Decision.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (LinkIdElement != null) dest.LinkIdElement = (FhirString)LinkIdElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContractOfferComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContractOfferComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Topic, otherT.Topic)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Decision, otherT.Decision)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(LinkIdElement, otherT.LinkIdElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContractOfferComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Topic, otherT.Topic)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Decision, otherT.Decision)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(LinkIdElement, otherT.LinkIdElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Topic != null) yield return Topic;
                    if (Type != null) yield return Type;
                    if (Decision != null) yield return Decision;
                    if (TextElement != null) yield return TextElement;
                    if (LinkIdElement != null) yield return LinkIdElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Topic != null) yield return new ElementValue("topic", Topic);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Decision != null) yield return new ElementValue("decision", Decision);
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    if (LinkIdElement != null) yield return new ElementValue("linkId", LinkIdElement);
                }
            }


        }


        [FhirType("ContractAssetComponent")]
        [DataContract]
        public partial class ContractAssetComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContractAssetComponent"; } }

            /// <summary>
            /// Resource Type, Profile, or CDA etc.
            /// </summary>
            [FhirElement("class", Order=40)]
            [DataMember]
            public Coding Class
            {
                get { return _class; }
                set { _class = value; OnPropertyChanged("Class"); }
            }

            private Coding _class;

            /// <summary>
            /// Code in the content
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public Coding Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private Coding _code;

            /// <summary>
            /// Time period of the asset
            /// </summary>
            [FhirElement("period", Order=60)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            /// <summary>
            /// Time period of the data for the asset
            /// </summary>
            [FhirElement("dataPeriod", Order=70)]
            [DataMember]
            public Period DataPeriod
            {
                get { return _dataPeriod; }
                set { _dataPeriod = value; OnPropertyChanged("DataPeriod"); }
            }

            private Period _dataPeriod;

            /// <summary>
            /// Data defined by this Asset
            /// </summary>
            [FhirElement("data", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AssetDataComponent> Data
            {
                get { if (_data==null) _data = new List<AssetDataComponent>(); return _data; }
                set { _data = value; OnPropertyChanged("Data"); }
            }

            private List<AssetDataComponent> _data;

            /// <summary>
            /// Contract Valued Item List
            /// </summary>
            [FhirElement("valuedItem", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ValuedItemComponent> ValuedItem
            {
                get { if (_valuedItem==null) _valuedItem = new List<ValuedItemComponent>(); return _valuedItem; }
                set { _valuedItem = value; OnPropertyChanged("ValuedItem"); }
            }

            private List<ValuedItemComponent> _valuedItem;

            /// <summary>
            /// Security Labels that define affected terms
            /// </summary>
            [FhirElement("securityLabel", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> SecurityLabel
            {
                get { if (_securityLabel==null) _securityLabel = new List<Coding>(); return _securityLabel; }
                set { _securityLabel = value; OnPropertyChanged("SecurityLabel"); }
            }

            private List<Coding> _securityLabel;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContractAssetComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Class != null) dest.Class = (Coding)Class.DeepCopy();
                    if (Code != null) dest.Code = (Coding)Code.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (DataPeriod != null) dest.DataPeriod = (Period)DataPeriod.DeepCopy();
                    if (Data != null) dest.Data = new List<AssetDataComponent>(Data.DeepCopy());
                    if (ValuedItem != null) dest.ValuedItem = new List<ValuedItemComponent>(ValuedItem.DeepCopy());
                    if (SecurityLabel != null) dest.SecurityLabel = new List<Coding>(SecurityLabel.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContractAssetComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContractAssetComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Class, otherT.Class)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if (!DeepComparable.Matches(DataPeriod, otherT.DataPeriod)) return false;
                if ( !DeepComparable.Matches(Data, otherT.Data)) return false;
                if ( !DeepComparable.Matches(ValuedItem, otherT.ValuedItem)) return false;
                if ( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContractAssetComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Class, otherT.Class)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(DataPeriod, otherT.DataPeriod)) return false;
                if (!DeepComparable.IsExactly(Data, otherT.Data)) return false;
                if (!DeepComparable.IsExactly(ValuedItem, otherT.ValuedItem)) return false;
                if (!DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Class != null) yield return Class;
                    if (Code != null) yield return Code;
                    if (Period != null) yield return Period;
                    if (DataPeriod != null) yield return DataPeriod;
                    foreach (var elem in Data) { if (elem != null) yield return elem; }
                    foreach (var elem in ValuedItem) { if (elem != null) yield return elem; }
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Class != null) yield return new ElementValue("class", Class);
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Period != null) yield return new ElementValue("period", Period);
                    if (DataPeriod != null) yield return new ElementValue("dataPeriod", DataPeriod);
                    foreach (var elem in Data) { if (elem != null) yield return new ElementValue("data", elem); }
                    foreach (var elem in ValuedItem) { if (elem != null) yield return new ElementValue("valuedItem", elem); }
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", elem); }
                }
            }


        }


        [FhirType("AssetDataComponent")]
        [DataContract]
        public partial class AssetDataComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AssetDataComponent"; } }

            /// <summary>
            /// instance | related | dependents | authoredby
            /// </summary>
            [FhirElement("meaning", Order=40)]
            [DataMember]
            public Code<ContractDataMeaning> MeaningElement
            {
                get { return _meaningElement; }
                set { _meaningElement = value; OnPropertyChanged("MeaningElement"); }
            }

            private Code<ContractDataMeaning> _meaningElement;

            /// <summary>
            /// instance | related | dependents | authoredby
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ContractDataMeaning? Meaning
            {
                get { return MeaningElement != null ? MeaningElement.Value : null; }
                set
                {
                    if (value == null)
                        MeaningElement = null;
                    else
                        MeaningElement = new Code<ContractDataMeaning>(value);
                    OnPropertyChanged("Meaning");
                }
            }

            /// <summary>
            /// The actual data reference
            /// </summary>
            [FhirElement("reference", Order=50)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AssetDataComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (MeaningElement != null) dest.MeaningElement = (Code<ContractDataMeaning>)MeaningElement.DeepCopy();
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AssetDataComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AssetDataComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(MeaningElement, otherT.MeaningElement)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AssetDataComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(MeaningElement, otherT.MeaningElement)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (MeaningElement != null) yield return MeaningElement;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (MeaningElement != null) yield return new ElementValue("meaning", MeaningElement);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                }
            }


        }


        [FhirType("ValuedItemComponent")]
        [DataContract]
        public partial class ValuedItemComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ValuedItemComponent"; } }

            /// <summary>
            /// Contract Valued Item Type
            /// </summary>
            [FhirElement("entity", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Entity
            {
                get { return _entity; }
                set { _entity = value; OnPropertyChanged("Entity"); }
            }

            private Element _entity;

            /// <summary>
            /// Contract Valued Item Number
            /// </summary>
            [FhirElement("identifier", Order=50)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Contract Valued Item Effective Tiem
            /// </summary>
            [FhirElement("effectiveTime", Order=60)]
            [DataMember]
            public FhirDateTime EffectiveTimeElement
            {
                get { return _effectiveTimeElement; }
                set { _effectiveTimeElement = value; OnPropertyChanged("EffectiveTimeElement"); }
            }

            private FhirDateTime _effectiveTimeElement;

            /// <summary>
            /// Contract Valued Item Effective Tiem
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string EffectiveTime
            {
                get { return EffectiveTimeElement != null ? EffectiveTimeElement.Value : null; }
                set
                {
                    if (value == null)
                        EffectiveTimeElement = null;
                    else
                        EffectiveTimeElement = new FhirDateTime(value);
                    OnPropertyChanged("EffectiveTime");
                }
            }

            /// <summary>
            /// Count of Contract Valued Items
            /// </summary>
            [FhirElement("quantity", Order=70)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Contract Valued Item fee, charge, or cost
            /// </summary>
            [FhirElement("unitPrice", Order=80)]
            [DataMember]
            public Money UnitPrice
            {
                get { return _unitPrice; }
                set { _unitPrice = value; OnPropertyChanged("UnitPrice"); }
            }

            private Money _unitPrice;

            /// <summary>
            /// Contract Valued Item Price Scaling Factor
            /// </summary>
            [FhirElement("factor", Order=90)]
            [DataMember]
            public FhirDecimal FactorElement
            {
                get { return _factorElement; }
                set { _factorElement = value; OnPropertyChanged("FactorElement"); }
            }

            private FhirDecimal _factorElement;

            /// <summary>
            /// Contract Valued Item Price Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Contract Valued Item Difficulty Scaling Factor
            /// </summary>
            [FhirElement("points", Order=100)]
            [DataMember]
            public FhirDecimal PointsElement
            {
                get { return _pointsElement; }
                set { _pointsElement = value; OnPropertyChanged("PointsElement"); }
            }

            private FhirDecimal _pointsElement;

            /// <summary>
            /// Contract Valued Item Difficulty Scaling Factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Points
            {
                get { return PointsElement != null ? PointsElement.Value : null; }
                set
                {
                    if (value == null)
                        PointsElement = null;
                    else
                        PointsElement = new FhirDecimal(value);
                    OnPropertyChanged("Points");
                }
            }

            /// <summary>
            /// Total Contract Valued Item Value
            /// </summary>
            [FhirElement("net", Order=110)]
            [DataMember]
            public Money Net
            {
                get { return _net; }
                set { _net = value; OnPropertyChanged("Net"); }
            }

            private Money _net;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ValuedItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Entity != null) dest.Entity = (Element)Entity.DeepCopy();
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (EffectiveTimeElement != null) dest.EffectiveTimeElement = (FhirDateTime)EffectiveTimeElement.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (PointsElement != null) dest.PointsElement = (FhirDecimal)PointsElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ValuedItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ValuedItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Entity, otherT.Entity)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ValuedItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(EffectiveTimeElement, otherT.EffectiveTimeElement)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Entity != null) yield return Entity;
                    if (Identifier != null) yield return Identifier;
                    if (EffectiveTimeElement != null) yield return EffectiveTimeElement;
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (PointsElement != null) yield return PointsElement;
                    if (Net != null) yield return Net;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Entity != null) yield return new ElementValue("entity", Entity);
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (EffectiveTimeElement != null) yield return new ElementValue("effectiveTime", EffectiveTimeElement);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (PointsElement != null) yield return new ElementValue("points", PointsElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                }
            }


        }


        [FhirType("AgentComponent")]
        [DataContract]
        public partial class AgentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AgentComponent"; } }

            /// <summary>
            /// Contract Agent Type
            /// </summary>
            [FhirElement("actor", Order=40)]
            [References("Contract","Device","Group","Location","Organization","Patient","Practitioner","RelatedPerson","Substance")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            /// <summary>
            /// Role type of the agent
            /// </summary>
            [FhirElement("role", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Role
            {
                get { if (_role==null) _role = new List<CodeableConcept>(); return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private List<CodeableConcept> _role;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AgentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
                    if (Role != null) dest.Role = new List<CodeableConcept>(Role.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AgentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if ( !DeepComparable.Matches(Role, otherT.Role)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Actor != null) yield return Actor;
                    foreach (var elem in Role) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                    foreach (var elem in Role) { if (elem != null) yield return new ElementValue("role", elem); }
                }
            }


        }


        [FhirType("SignatoryComponent")]
        [DataContract]
        public partial class SignatoryComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SignatoryComponent"; } }

            /// <summary>
            /// Contract Signatory Role
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Contract Signatory Party
            /// </summary>
            [FhirElement("party", Order=50)]
            [References("Organization","Patient","Practitioner","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Party
            {
                get { return _party; }
                set { _party = value; OnPropertyChanged("Party"); }
            }

            private ResourceReference _party;

            /// <summary>
            /// Contract Documentation Signature
            /// </summary>
            [FhirElement("signature", Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Signature> Signature
            {
                get { if (_signature==null) _signature = new List<Signature>(); return _signature; }
                set { _signature = value; OnPropertyChanged("Signature"); }
            }

            private List<Signature> _signature;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SignatoryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Party != null) dest.Party = (ResourceReference)Party.DeepCopy();
                    if (Signature != null) dest.Signature = new List<Signature>(Signature.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SignatoryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SignatoryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Party, otherT.Party)) return false;
                if ( !DeepComparable.Matches(Signature, otherT.Signature)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SignatoryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Party, otherT.Party)) return false;
                if (!DeepComparable.IsExactly(Signature, otherT.Signature)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Party != null) yield return Party;
                    foreach (var elem in Signature) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Party != null) yield return new ElementValue("party", Party);
                    foreach (var elem in Signature) { if (elem != null) yield return new ElementValue("signature", elem); }
                }
            }


        }


        [FhirType("FriendlyLanguageComponent")]
        [DataContract]
        public partial class FriendlyLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FriendlyLanguageComponent"; } }

            /// <summary>
            /// Easily comprehended representation of this Contract
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FriendlyLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FriendlyLanguageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FriendlyLanguageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FriendlyLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        [FhirType("LegalLanguageComponent")]
        [DataContract]
        public partial class LegalLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LegalLanguageComponent"; } }

            /// <summary>
            /// Contract Legal Text
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LegalLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LegalLanguageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LegalLanguageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LegalLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        [FhirType("ComputableLanguageComponent")]
        [DataContract]
        public partial class ComputableLanguageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ComputableLanguageComponent"; } }

            /// <summary>
            /// Computable Contract Rules
            /// </summary>
            [FhirElement("content", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Content
            {
                get { return _content; }
                set { _content = value; OnPropertyChanged("Content"); }
            }

            private Element _content;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ComputableLanguageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Content != null) dest.Content = (Element)Content.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ComputableLanguageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ComputableLanguageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Content, otherT.Content)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ComputableLanguageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Content != null) yield return Content;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Content != null) yield return new ElementValue("content", Content);
                }
            }


        }


        /// <summary>
        /// Contract number
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
        /// amended | appended | cancelled | disputed | entered-in-error | executable | executed | negotiable | offered | policy | rejected | renewed | revoked | resolved | terminated
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<ContractResourceStatusCodes> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ContractResourceStatusCodes> _statusElement;

        /// <summary>
        /// amended | appended | cancelled | disputed | entered-in-error | executable | executed | negotiable | offered | policy | rejected | renewed | revoked | resolved | terminated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ContractResourceStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ContractResourceStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Content derived from the basal information
        /// </summary>
        [FhirElement("contentDerivative", Order=110)]
        [DataMember]
        public CodeableConcept ContentDerivative
        {
            get { return _contentDerivative; }
            set { _contentDerivative = value; OnPropertyChanged("ContentDerivative"); }
        }

        private CodeableConcept _contentDerivative;

        /// <summary>
        /// When this Contract was issued
        /// </summary>
        [FhirElement("issued", InSummary=true, Order=120)]
        [DataMember]
        public FhirDateTime IssuedElement
        {
            get { return _issuedElement; }
            set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
        }

        private FhirDateTime _issuedElement;

        /// <summary>
        /// When this Contract was issued
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Issued
        {
            get { return IssuedElement != null ? IssuedElement.Value : null; }
            set
            {
                if (value == null)
                    IssuedElement = null;
                else
                    IssuedElement = new FhirDateTime(value);
                OnPropertyChanged("Issued");
            }
        }

        /// <summary>
        /// Effective time
        /// </summary>
        [FhirElement("applies", InSummary=true, Order=130)]
        [DataMember]
        public Period Applies
        {
            get { return _applies; }
            set { _applies = value; OnPropertyChanged("Applies"); }
        }

        private Period _applies;

        /// <summary>
        /// Contract Target Entity
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Subject
        {
            get { if (_subject==null) _subject = new List<ResourceReference>(); return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private List<ResourceReference> _subject;

        /// <summary>
        /// Authority under which this Contract has standing
        /// </summary>
        [FhirElement("authority", Order=150)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Authority
        {
            get { if (_authority==null) _authority = new List<ResourceReference>(); return _authority; }
            set { _authority = value; OnPropertyChanged("Authority"); }
        }

        private List<ResourceReference> _authority;

        /// <summary>
        /// A sphere of control governed by an authoritative jurisdiction, organization, or person
        /// </summary>
        [FhirElement("domain", Order=160)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Domain
        {
            get { if (_domain==null) _domain = new List<ResourceReference>(); return _domain; }
            set { _domain = value; OnPropertyChanged("Domain"); }
        }

        private List<ResourceReference> _domain;

        /// <summary>
        /// Type or form
        /// </summary>
        [FhirElement("type", InSummary=true, Order=170)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Subtype within the context of type
        /// </summary>
        [FhirElement("subType", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> SubType
        {
            get { if (_subType==null) _subType = new List<CodeableConcept>(); return _subType; }
            set { _subType = value; OnPropertyChanged("SubType"); }
        }

        private List<CodeableConcept> _subType;

        /// <summary>
        /// Contract Term List
        /// </summary>
        [FhirElement("term", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TermComponent> Term
        {
            get { if (_term==null) _term = new List<TermComponent>(); return _term; }
            set { _term = value; OnPropertyChanged("Term"); }
        }

        private List<TermComponent> _term;

        /// <summary>
        /// Contract Signatory
        /// </summary>
        [FhirElement("signer", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SignatoryComponent> Signer
        {
            get { if (_signer==null) _signer = new List<SignatoryComponent>(); return _signer; }
            set { _signer = value; OnPropertyChanged("Signer"); }
        }

        private List<SignatoryComponent> _signer;

        /// <summary>
        /// Contract Friendly Language
        /// </summary>
        [FhirElement("friendly", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FriendlyLanguageComponent> Friendly
        {
            get { if (_friendly==null) _friendly = new List<FriendlyLanguageComponent>(); return _friendly; }
            set { _friendly = value; OnPropertyChanged("Friendly"); }
        }

        private List<FriendlyLanguageComponent> _friendly;

        /// <summary>
        /// Contract Legal Language
        /// </summary>
        [FhirElement("legal", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LegalLanguageComponent> Legal
        {
            get { if (_legal==null) _legal = new List<LegalLanguageComponent>(); return _legal; }
            set { _legal = value; OnPropertyChanged("Legal"); }
        }

        private List<LegalLanguageComponent> _legal;

        /// <summary>
        /// Computable Contract Language
        /// </summary>
        [FhirElement("rule", Order=230)]
        [DataMember]
        public ComputableLanguageComponent Rule
        {
            get { return _rule; }
            set { _rule = value; OnPropertyChanged("Rule"); }
        }

        private ComputableLanguageComponent _rule;

        /// <summary>
        /// Binding Contract
        /// </summary>
        [FhirElement("legallyBinding", Order=240, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Attachment),typeof(ResourceReference))]
        [DataMember]
        public Element LegallyBinding
        {
            get { return _legallyBinding; }
            set { _legallyBinding = value; OnPropertyChanged("LegallyBinding"); }
        }

        private Element _legallyBinding;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Contract;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<ContractResourceStatusCodes>)StatusElement.DeepCopy();
                if (ContentDerivative != null) dest.ContentDerivative = (CodeableConcept)ContentDerivative.DeepCopy();
                if (IssuedElement != null) dest.IssuedElement = (FhirDateTime)IssuedElement.DeepCopy();
                if (Applies != null) dest.Applies = (Period)Applies.DeepCopy();
                if (Subject != null) dest.Subject = new List<ResourceReference>(Subject.DeepCopy());
                if (Authority != null) dest.Authority = new List<ResourceReference>(Authority.DeepCopy());
                if (Domain != null) dest.Domain = new List<ResourceReference>(Domain.DeepCopy());
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (SubType != null) dest.SubType = new List<CodeableConcept>(SubType.DeepCopy());
                if (Term != null) dest.Term = new List<TermComponent>(Term.DeepCopy());
                if (Signer != null) dest.Signer = new List<SignatoryComponent>(Signer.DeepCopy());
                if (Friendly != null) dest.Friendly = new List<FriendlyLanguageComponent>(Friendly.DeepCopy());
                if (Legal != null) dest.Legal = new List<LegalLanguageComponent>(Legal.DeepCopy());
                if (Rule != null) dest.Rule = (ComputableLanguageComponent)Rule.DeepCopy();
                if (LegallyBinding != null) dest.LegallyBinding = (Element)LegallyBinding.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Contract());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Contract;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ContentDerivative, otherT.ContentDerivative)) return false;
            if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.Matches(Applies, otherT.Applies)) return false;
            if ( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
            if ( !DeepComparable.Matches(Domain, otherT.Domain)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(SubType, otherT.SubType)) return false;
            if ( !DeepComparable.Matches(Term, otherT.Term)) return false;
            if ( !DeepComparable.Matches(Signer, otherT.Signer)) return false;
            if ( !DeepComparable.Matches(Friendly, otherT.Friendly)) return false;
            if ( !DeepComparable.Matches(Legal, otherT.Legal)) return false;
            if (!DeepComparable.Matches(Rule, otherT.Rule)) return false;
            if (!DeepComparable.Matches(LegallyBinding, otherT.LegallyBinding)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Contract;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ContentDerivative, otherT.ContentDerivative)) return false;
            if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.IsExactly(Applies, otherT.Applies)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
            if (!DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
            if (!DeepComparable.IsExactly(Term, otherT.Term)) return false;
            if (!DeepComparable.IsExactly(Signer, otherT.Signer)) return false;
            if (!DeepComparable.IsExactly(Friendly, otherT.Friendly)) return false;
            if (!DeepComparable.IsExactly(Legal, otherT.Legal)) return false;
            if (!DeepComparable.IsExactly(Rule, otherT.Rule)) return false;
            if (!DeepComparable.IsExactly(LegallyBinding, otherT.LegallyBinding)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (ContentDerivative != null) yield return ContentDerivative;
                if (IssuedElement != null) yield return IssuedElement;
                if (Applies != null) yield return Applies;
                foreach (var elem in Subject) { if (elem != null) yield return elem; }
                foreach (var elem in Authority) { if (elem != null) yield return elem; }
                foreach (var elem in Domain) { if (elem != null) yield return elem; }
                if (Type != null) yield return Type;
                foreach (var elem in SubType) { if (elem != null) yield return elem; }
                foreach (var elem in Term) { if (elem != null) yield return elem; }
                foreach (var elem in Signer) { if (elem != null) yield return elem; }
                foreach (var elem in Friendly) { if (elem != null) yield return elem; }
                foreach (var elem in Legal) { if (elem != null) yield return elem; }
                if (Rule != null) yield return Rule;
                if (LegallyBinding != null) yield return LegallyBinding;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ContentDerivative != null) yield return new ElementValue("contentDerivative", ContentDerivative);
                if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                if (Applies != null) yield return new ElementValue("applies", Applies);
                foreach (var elem in Subject) { if (elem != null) yield return new ElementValue("subject", elem); }
                foreach (var elem in Authority) { if (elem != null) yield return new ElementValue("authority", elem); }
                foreach (var elem in Domain) { if (elem != null) yield return new ElementValue("domain", elem); }
                if (Type != null) yield return new ElementValue("type", Type);
                foreach (var elem in SubType) { if (elem != null) yield return new ElementValue("subType", elem); }
                foreach (var elem in Term) { if (elem != null) yield return new ElementValue("term", elem); }
                foreach (var elem in Signer) { if (elem != null) yield return new ElementValue("signer", elem); }
                foreach (var elem in Friendly) { if (elem != null) yield return new ElementValue("friendly", elem); }
                foreach (var elem in Legal) { if (elem != null) yield return new ElementValue("legal", elem); }
                if (Rule != null) yield return new ElementValue("rule", Rule);
                if (LegallyBinding != null) yield return new ElementValue("legallyBinding", LegallyBinding);
            }
        }

    }

}
