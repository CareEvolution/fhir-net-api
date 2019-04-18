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
    /// Who, What, When for a set of resources
    /// </summary>
    [FhirType("Provenance", IsResource = true)]
    [DataContract]
    public partial class Provenance : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Provenance; } }
        [NotMapped]
        public override string TypeName { get { return "Provenance"; } }

        /// <summary>
        /// How an entity was used in an activity.
        /// (url: http://hl7.org/fhir/ValueSet/provenance-entity-role)
        /// </summary>
        [FhirEnumeration("ProvenanceEntityRole")]
        public enum ProvenanceEntityRole
        {
            /// <summary>
            /// A transformation of an entity into another, an update of an entity resulting in a new one, or the construction of a new entity based on a preexisting entity.
            /// (system: http://hl7.org/fhir/provenance-entity-role)
            /// </summary>
            [EnumLiteral("derivation", "http://hl7.org/fhir/provenance-entity-role"), Description("Derivation")]
            Derivation,
            /// <summary>
            /// A derivation for which the resulting entity is a revised version of some original.
            /// (system: http://hl7.org/fhir/provenance-entity-role)
            /// </summary>
            [EnumLiteral("revision", "http://hl7.org/fhir/provenance-entity-role"), Description("Revision")]
            Revision,
            /// <summary>
            /// The repeat of (some or all of) an entity, such as text or image, by someone who may or may not be its original author.
            /// (system: http://hl7.org/fhir/provenance-entity-role)
            /// </summary>
            [EnumLiteral("quotation", "http://hl7.org/fhir/provenance-entity-role"), Description("Quotation")]
            Quotation,
            /// <summary>
            /// A primary source for a topic refers to something produced by some agent with direct experience and knowledge about the topic, at the time of the topic's study, without benefit from hindsight.
            /// (system: http://hl7.org/fhir/provenance-entity-role)
            /// </summary>
            [EnumLiteral("source", "http://hl7.org/fhir/provenance-entity-role"), Description("Source")]
            Source,
        }


        [FhirType("AgentComponent")]
        [DataContract]
        public partial class AgentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AgentComponent"; } }

            /// <summary>
            /// What the agents involvement was
            /// </summary>
            [FhirElement("role", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private Coding _role;

            /// <summary>
            /// Individual, device or organization playing role
            /// </summary>
            [FhirElement("actor", InSummary = true, Order = 50)]
            [References("Practitioner", "RelatedPerson", "Patient", "Device", "Organization")]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            /// <summary>
            /// Authorization-system identifier for the agent
            /// </summary>
            [FhirElement("userId", InSummary = true, Order = 60)]
            [DataMember]
            public Identifier UserId
            {
                get { return _userId; }
                set { _userId = value; OnPropertyChanged("UserId"); }
            }

            private Identifier _userId;

            /// <summary>
            /// Track delegation between agents
            /// </summary>
            [FhirElement("relatedAgent", InSummary = true, Order = 70)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<RelatedAgentComponent> RelatedAgent
            {
                get { if (_relatedAgent == null) _relatedAgent = new List<RelatedAgentComponent>(); return _relatedAgent; }
                set { _relatedAgent = value; OnPropertyChanged("RelatedAgent"); }
            }

            private List<RelatedAgentComponent> _relatedAgent;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AgentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Role != null) dest.Role = (Coding)Role.DeepCopy();
                    if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
                    if (UserId != null) dest.UserId = (Identifier)UserId.DeepCopy();
                    if (RelatedAgent != null) dest.RelatedAgent = new List<RelatedAgentComponent>(RelatedAgent.DeepCopy());
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
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if (!DeepComparable.Matches(UserId, otherT.UserId)) return false;
                if (!DeepComparable.Matches(RelatedAgent, otherT.RelatedAgent)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if (!DeepComparable.IsExactly(UserId, otherT.UserId)) return false;
                if (!DeepComparable.IsExactly(RelatedAgent, otherT.RelatedAgent)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Actor != null) yield return Actor;
                    if (UserId != null) yield return UserId;
                    foreach (var elem in RelatedAgent) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                    if (UserId != null) yield return new ElementValue("userId", UserId);
                    foreach (var elem in RelatedAgent) { if (elem != null) yield return new ElementValue("relatedAgent", elem); }
                }
            }


        }


        [FhirType("RelatedAgentComponent")]
        [DataContract]
        public partial class RelatedAgentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedAgentComponent"; } }

            /// <summary>
            /// Type of relationship between agents
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Reference to other agent in this resource by identifier
            /// </summary>
            [FhirElement("target", InSummary = true, Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public FhirUri TargetElement
            {
                get { return _targetElement; }
                set { _targetElement = value; OnPropertyChanged("TargetElement"); }
            }

            private FhirUri _targetElement;

            /// <summary>
            /// Reference to other agent in this resource by identifier
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Target
            {
                get { return TargetElement != null ? TargetElement.Value : null; }
                set
                {
                    if (value == null)
                        TargetElement = null;
                    else
                        TargetElement = new FhirUri(value);
                    OnPropertyChanged("Target");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatedAgentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (TargetElement != null) dest.TargetElement = (FhirUri)TargetElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RelatedAgentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatedAgentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(TargetElement, otherT.TargetElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedAgentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(TargetElement, otherT.TargetElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (TargetElement != null) yield return TargetElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (TargetElement != null) yield return new ElementValue("target", TargetElement);
                }
            }


        }


        [FhirType("EntityComponent")]
        [DataContract]
        public partial class EntityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EntityComponent"; } }

            /// <summary>
            /// derivation | revision | quotation | source
            /// </summary>
            [FhirElement("role", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Code<ProvenanceEntityRole> RoleElement
            {
                get { return _roleElement; }
                set { _roleElement = value; OnPropertyChanged("RoleElement"); }
            }

            private Code<ProvenanceEntityRole> _roleElement;

            /// <summary>
            /// derivation | revision | quotation | source
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ProvenanceEntityRole? Role
            {
                get { return RoleElement != null ? RoleElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        RoleElement = null;
                    else
                        RoleElement = new Code<ProvenanceEntityRole>(value);
                    OnPropertyChanged("Role");
                }
            }

            /// <summary>
            /// The type of resource in this entity
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Identity of entity
            /// </summary>
            [FhirElement("reference", InSummary = true, Order = 60)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public FhirUri ReferenceElement
            {
                get { return _referenceElement; }
                set { _referenceElement = value; OnPropertyChanged("ReferenceElement"); }
            }

            private FhirUri _referenceElement;

            /// <summary>
            /// Identity of entity
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Reference
            {
                get { return ReferenceElement != null ? ReferenceElement.Value : null; }
                set
                {
                    if (value == null)
                        ReferenceElement = null;
                    else
                        ReferenceElement = new FhirUri(value);
                    OnPropertyChanged("Reference");
                }
            }

            /// <summary>
            /// Human description of entity
            /// </summary>
            [FhirElement("display", InSummary = true, Order = 70)]
            [DataMember]
            public FhirString DisplayElement
            {
                get { return _displayElement; }
                set { _displayElement = value; OnPropertyChanged("DisplayElement"); }
            }

            private FhirString _displayElement;

            /// <summary>
            /// Human description of entity
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
            /// Entity is attributed to this agent
            /// </summary>
            [FhirElement("agent", InSummary = true, Order = 80)]
            [DataMember]
            public AgentComponent Agent
            {
                get { return _agent; }
                set { _agent = value; OnPropertyChanged("Agent"); }
            }

            private AgentComponent _agent;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EntityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RoleElement != null) dest.RoleElement = (Code<ProvenanceEntityRole>)RoleElement.DeepCopy();
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (ReferenceElement != null) dest.ReferenceElement = (FhirUri)ReferenceElement.DeepCopy();
                    if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
                    if (Agent != null) dest.Agent = (AgentComponent)Agent.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new EntityComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EntityComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RoleElement, otherT.RoleElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;
                if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;
                if (!DeepComparable.Matches(Agent, otherT.Agent)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EntityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RoleElement, otherT.RoleElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;
                if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;
                if (!DeepComparable.IsExactly(Agent, otherT.Agent)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RoleElement != null) yield return RoleElement;
                    if (Type != null) yield return Type;
                    if (ReferenceElement != null) yield return ReferenceElement;
                    if (DisplayElement != null) yield return DisplayElement;
                    if (Agent != null) yield return Agent;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RoleElement != null) yield return new ElementValue("role", RoleElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (ReferenceElement != null) yield return new ElementValue("reference", ReferenceElement);
                    if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
                    if (Agent != null) yield return new ElementValue("agent", Agent);
                }
            }


        }


        /// <summary>
        /// Target Reference(s) (usually version specific)
        /// </summary>
        [FhirElement("target", InSummary = true, Order = 90)]
        [Cardinality(Min = 1, Max = -1)]
        [DataMember]
        public List<ResourceReference> Target
        {
            get { if (_target == null) _target = new List<ResourceReference>(); return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private List<ResourceReference> _target;

        /// <summary>
        /// When the activity occurred
        /// </summary>
        [FhirElement("period", InSummary = true, Order = 100)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// When the activity was recorded / updated
        /// </summary>
        [FhirElement("recorded", InSummary = true, Order = 110)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public Instant RecordedElement
        {
            get { return _recordedElement; }
            set { _recordedElement = value; OnPropertyChanged("RecordedElement"); }
        }

        private Instant _recordedElement;

        /// <summary>
        /// When the activity was recorded / updated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? Recorded
        {
            get { return RecordedElement != null ? RecordedElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    RecordedElement = null;
                else
                    RecordedElement = new Instant(value);
                OnPropertyChanged("Recorded");
            }
        }

        /// <summary>
        /// Reason the activity is occurring
        /// </summary>
        [FhirElement("reason", InSummary = true, Order = 120)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> Reason
        {
            get { if (_reason == null) _reason = new List<CodeableConcept>(); return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private List<CodeableConcept> _reason;

        /// <summary>
        /// Activity that occurred
        /// </summary>
        [FhirElement("activity", InSummary = true, Order = 130)]
        [DataMember]
        public CodeableConcept Activity
        {
            get { return _activity; }
            set { _activity = value; OnPropertyChanged("Activity"); }
        }

        private CodeableConcept _activity;

        /// <summary>
        /// Where the activity occurred, if relevant
        /// </summary>
        [FhirElement("location", InSummary = true, Order = 140)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Policy or plan the activity was defined by
        /// </summary>
        [FhirElement("policy", InSummary = true, Order = 150)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<FhirUri> PolicyElement
        {
            get { if (_policyElement == null) _policyElement = new List<FhirUri>(); return _policyElement; }
            set { _policyElement = value; OnPropertyChanged("PolicyElement"); }
        }

        private List<FhirUri> _policyElement;

        /// <summary>
        /// Policy or plan the activity was defined by
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Policy
        {
            get { return PolicyElement != null ? PolicyElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    PolicyElement = null;
                else
                    PolicyElement = new List<FhirUri>(value.Select(elem => new FhirUri(elem)));
                OnPropertyChanged("Policy");
            }
        }

        /// <summary>
        /// Agents involved in creating resource
        /// </summary>
        [FhirElement("agent", InSummary = true, Order = 160)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<AgentComponent> Agent
        {
            get { if (_agent == null) _agent = new List<AgentComponent>(); return _agent; }
            set { _agent = value; OnPropertyChanged("Agent"); }
        }

        private List<AgentComponent> _agent;

        /// <summary>
        /// An entity used in this activity
        /// </summary>
        [FhirElement("entity", InSummary = true, Order = 170)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<EntityComponent> Entity
        {
            get { if (_entity == null) _entity = new List<EntityComponent>(); return _entity; }
            set { _entity = value; OnPropertyChanged("Entity"); }
        }

        private List<EntityComponent> _entity;

        /// <summary>
        /// Signature on target
        /// </summary>
        [FhirElement("signature", InSummary = true, Order = 180)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Signature> Signature
        {
            get { if (_signature == null) _signature = new List<Signature>(); return _signature; }
            set { _signature = value; OnPropertyChanged("Signature"); }
        }

        private List<Signature> _signature;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Provenance;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Target != null) dest.Target = new List<ResourceReference>(Target.DeepCopy());
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (RecordedElement != null) dest.RecordedElement = (Instant)RecordedElement.DeepCopy();
                if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                if (Activity != null) dest.Activity = (CodeableConcept)Activity.DeepCopy();
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (PolicyElement != null) dest.PolicyElement = new List<FhirUri>(PolicyElement.DeepCopy());
                if (Agent != null) dest.Agent = new List<AgentComponent>(Agent.DeepCopy());
                if (Entity != null) dest.Entity = new List<EntityComponent>(Entity.DeepCopy());
                if (Signature != null) dest.Signature = new List<Signature>(Signature.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Provenance());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Provenance;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Target, otherT.Target)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(RecordedElement, otherT.RecordedElement)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(Activity, otherT.Activity)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(PolicyElement, otherT.PolicyElement)) return false;
            if (!DeepComparable.Matches(Agent, otherT.Agent)) return false;
            if (!DeepComparable.Matches(Entity, otherT.Entity)) return false;
            if (!DeepComparable.Matches(Signature, otherT.Signature)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Provenance;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(RecordedElement, otherT.RecordedElement)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Activity, otherT.Activity)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(PolicyElement, otherT.PolicyElement)) return false;
            if (!DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
            if (!DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
            if (!DeepComparable.IsExactly(Signature, otherT.Signature)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Target) { if (elem != null) yield return elem; }
                if (Period != null) yield return Period;
                if (RecordedElement != null) yield return RecordedElement;
                foreach (var elem in Reason) { if (elem != null) yield return elem; }
                if (Activity != null) yield return Activity;
                if (Location != null) yield return Location;
                foreach (var elem in PolicyElement) { if (elem != null) yield return elem; }
                foreach (var elem in Agent) { if (elem != null) yield return elem; }
                foreach (var elem in Entity) { if (elem != null) yield return elem; }
                foreach (var elem in Signature) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", elem); }
                if (Period != null) yield return new ElementValue("period", Period);
                if (RecordedElement != null) yield return new ElementValue("recorded", RecordedElement);
                foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                if (Activity != null) yield return new ElementValue("activity", Activity);
                if (Location != null) yield return new ElementValue("location", Location);
                foreach (var elem in PolicyElement) { if (elem != null) yield return new ElementValue("policy", elem); }
                foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", elem); }
                foreach (var elem in Entity) { if (elem != null) yield return new ElementValue("entity", elem); }
                foreach (var elem in Signature) { if (elem != null) yield return new ElementValue("signature", elem); }
            }
        }

    }

}
