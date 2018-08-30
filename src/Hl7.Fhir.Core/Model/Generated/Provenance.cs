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
    /// Who, What, When for a set of resources
    /// </summary>
    [FhirType("Provenance", IsResource=true)]
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
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/provenance-entity-role)
            /// </summary>
            [EnumLiteral("derivation", "http://hl7.org/fhir/provenance-entity-role"), Description("Derivation")]
            Derivation,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/provenance-entity-role)
            /// </summary>
            [EnumLiteral("revision", "http://hl7.org/fhir/provenance-entity-role"), Description("Revision")]
            Revision,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/provenance-entity-role)
            /// </summary>
            [EnumLiteral("quotation", "http://hl7.org/fhir/provenance-entity-role"), Description("Quotation")]
            Quotation,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/provenance-entity-role)
            /// </summary>
            [EnumLiteral("source", "http://hl7.org/fhir/provenance-entity-role"), Description("Source")]
            Source,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/provenance-entity-role)
            /// </summary>
            [EnumLiteral("removal", "http://hl7.org/fhir/provenance-entity-role"), Description("Removal")]
            Removal,
        }


        [FhirType("AgentComponent")]
        [DataContract]
        public partial class AgentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AgentComponent"; } }

            /// <summary>
            /// How the agent participated
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// What the agents role was
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

            /// <summary>
            /// Who participated
            /// </summary>
            [FhirElement("who", InSummary=true, Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Identifier),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Who
            {
                get { return _who; }
                set { _who = value; OnPropertyChanged("Who"); }
            }

            private Element _who;

            /// <summary>
            /// Who the agent is representing
            /// </summary>
            [FhirElement("onBehalfOf", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Identifier),typeof(ResourceReference))]
            [DataMember]
            public Element OnBehalfOf
            {
                get { return _onBehalfOf; }
                set { _onBehalfOf = value; OnPropertyChanged("OnBehalfOf"); }
            }

            private Element _onBehalfOf;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AgentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Role != null) dest.Role = new List<CodeableConcept>(Role.DeepCopy());
                    if (Who != null) dest.Who = (Element)Who.DeepCopy();
                    if (OnBehalfOf != null) dest.OnBehalfOf = (Element)OnBehalfOf.DeepCopy();
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
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Who, otherT.Who)) return false;
                if (!DeepComparable.Matches(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Who, otherT.Who)) return false;
                if (!DeepComparable.IsExactly(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Role) { if (elem != null) yield return elem; }
                    if (Who != null) yield return Who;
                    if (OnBehalfOf != null) yield return OnBehalfOf;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Role) { if (elem != null) yield return new ElementValue("role", elem); }
                    if (Who != null) yield return new ElementValue("who", Who);
                    if (OnBehalfOf != null) yield return new ElementValue("onBehalfOf", OnBehalfOf);
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
            /// derivation | revision | quotation | source | removal
            /// </summary>
            [FhirElement("role", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ProvenanceEntityRole> RoleElement
            {
                get { return _roleElement; }
                set { _roleElement = value; OnPropertyChanged("RoleElement"); }
            }

            private Code<ProvenanceEntityRole> _roleElement;

            /// <summary>
            /// derivation | revision | quotation | source | removal
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ProvenanceEntityRole? Role
            {
                get { return RoleElement != null ? RoleElement.Value : null; }
                set
                {
                    if (value == null)
                        RoleElement = null;
                    else
                        RoleElement = new Code<ProvenanceEntityRole>(value);
                    OnPropertyChanged("Role");
                }
            }

            /// <summary>
            /// Identity of entity
            /// </summary>
            [FhirElement("what", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Identifier),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element What
            {
                get { return _what; }
                set { _what = value; OnPropertyChanged("What"); }
            }

            private Element _what;

            /// <summary>
            /// Entity is attributed to this agent
            /// </summary>
            [FhirElement("agent", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AgentComponent> Agent
            {
                get { if (_agent==null) _agent = new List<AgentComponent>(); return _agent; }
                set { _agent = value; OnPropertyChanged("Agent"); }
            }

            private List<AgentComponent> _agent;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EntityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RoleElement != null) dest.RoleElement = (Code<ProvenanceEntityRole>)RoleElement.DeepCopy();
                    if (What != null) dest.What = (Element)What.DeepCopy();
                    if (Agent != null) dest.Agent = new List<AgentComponent>(Agent.DeepCopy());
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
                if (!DeepComparable.Matches(What, otherT.What)) return false;
                if ( !DeepComparable.Matches(Agent, otherT.Agent)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EntityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RoleElement, otherT.RoleElement)) return false;
                if (!DeepComparable.IsExactly(What, otherT.What)) return false;
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
                    if (What != null) yield return What;
                    foreach (var elem in Agent) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RoleElement != null) yield return new ElementValue("role", RoleElement);
                    if (What != null) yield return new ElementValue("what", What);
                    foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", elem); }
                }
            }


        }


        /// <summary>
        /// Target Reference(s) (usually version specific)
        /// </summary>
        [FhirElement("target", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<ResourceReference> Target
        {
            get { if (_target==null) _target = new List<ResourceReference>(); return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private List<ResourceReference> _target;

        /// <summary>
        /// When the activity occurred
        /// </summary>
        [FhirElement("occurred", Order=100, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Period),typeof(FhirDateTime))]
        [DataMember]
        public Element Occurred
        {
            get { return _occurred; }
            set { _occurred = value; OnPropertyChanged("Occurred"); }
        }

        private Element _occurred;

        /// <summary>
        /// When the activity was recorded / updated
        /// </summary>
        [FhirElement("recorded", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
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
                if (value == null)
                    RecordedElement = null;
                else
                    RecordedElement = new Instant(value);
                OnPropertyChanged("Recorded");
            }
        }

        /// <summary>
        /// Policy or plan the activity was defined by
        /// </summary>
        [FhirElement("policy", Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> PolicyElement
        {
            get { if (_policyElement==null) _policyElement = new List<FhirUri>(); return _policyElement; }
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
                    PolicyElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("Policy");
            }
        }

        /// <summary>
        /// Where the activity occurred, if relevant
        /// </summary>
        [FhirElement("location", Order=130)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Reason the activity is occurring
        /// </summary>
        [FhirElement("reason", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Reason
        {
            get { if (_reason==null) _reason = new List<CodeableConcept>(); return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private List<CodeableConcept> _reason;

        /// <summary>
        /// Activity that occurred
        /// </summary>
        [FhirElement("activity", Order=150)]
        [DataMember]
        public CodeableConcept Activity
        {
            get { return _activity; }
            set { _activity = value; OnPropertyChanged("Activity"); }
        }

        private CodeableConcept _activity;

        /// <summary>
        /// Actor involved
        /// </summary>
        [FhirElement("agent", Order=160)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<AgentComponent> Agent
        {
            get { if (_agent==null) _agent = new List<AgentComponent>(); return _agent; }
            set { _agent = value; OnPropertyChanged("Agent"); }
        }

        private List<AgentComponent> _agent;

        /// <summary>
        /// An entity used in this activity
        /// </summary>
        [FhirElement("entity", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EntityComponent> Entity
        {
            get { if (_entity==null) _entity = new List<EntityComponent>(); return _entity; }
            set { _entity = value; OnPropertyChanged("Entity"); }
        }

        private List<EntityComponent> _entity;

        /// <summary>
        /// Signature on target
        /// </summary>
        [FhirElement("signature", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Signature> Signature
        {
            get { if (_signature==null) _signature = new List<Signature>(); return _signature; }
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
                if (Occurred != null) dest.Occurred = (Element)Occurred.DeepCopy();
                if (RecordedElement != null) dest.RecordedElement = (Instant)RecordedElement.DeepCopy();
                if (PolicyElement != null) dest.PolicyElement = new List<FhirUri>(PolicyElement.DeepCopy());
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                if (Activity != null) dest.Activity = (CodeableConcept)Activity.DeepCopy();
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
            if ( !DeepComparable.Matches(Target, otherT.Target)) return false;
            if (!DeepComparable.Matches(Occurred, otherT.Occurred)) return false;
            if (!DeepComparable.Matches(RecordedElement, otherT.RecordedElement)) return false;
            if ( !DeepComparable.Matches(PolicyElement, otherT.PolicyElement)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if ( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(Activity, otherT.Activity)) return false;
            if ( !DeepComparable.Matches(Agent, otherT.Agent)) return false;
            if ( !DeepComparable.Matches(Entity, otherT.Entity)) return false;
            if ( !DeepComparable.Matches(Signature, otherT.Signature)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Provenance;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(Occurred, otherT.Occurred)) return false;
            if (!DeepComparable.IsExactly(RecordedElement, otherT.RecordedElement)) return false;
            if (!DeepComparable.IsExactly(PolicyElement, otherT.PolicyElement)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Activity, otherT.Activity)) return false;
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
                if (Occurred != null) yield return Occurred;
                if (RecordedElement != null) yield return RecordedElement;
                foreach (var elem in PolicyElement) { if (elem != null) yield return elem; }
                if (Location != null) yield return Location;
                foreach (var elem in Reason) { if (elem != null) yield return elem; }
                if (Activity != null) yield return Activity;
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
                if (Occurred != null) yield return new ElementValue("occurred", Occurred);
                if (RecordedElement != null) yield return new ElementValue("recorded", RecordedElement);
                foreach (var elem in PolicyElement) { if (elem != null) yield return new ElementValue("policy", elem); }
                if (Location != null) yield return new ElementValue("location", Location);
                foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                if (Activity != null) yield return new ElementValue("activity", Activity);
                foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", elem); }
                foreach (var elem in Entity) { if (elem != null) yield return new ElementValue("entity", elem); }
                foreach (var elem in Signature) { if (elem != null) yield return new ElementValue("signature", elem); }
            }
        }

    }

}
