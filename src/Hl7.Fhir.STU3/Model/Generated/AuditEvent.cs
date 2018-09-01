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
    /// Event record kept for security purposes
    /// </summary>
    [FhirType("AuditEvent", IsResource=true)]
    [DataContract]
    public partial class AuditEvent : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.AuditEvent; } }
        [NotMapped]
        public override string TypeName { get { return "AuditEvent"; } }


        [FhirType("AgentComponent")]
        [DataContract]
        public partial class AgentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AgentComponent"; } }

            /// <summary>
            /// Agent role in the event
            /// </summary>
            [FhirElement("role", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Role
            {
                get { if (_role==null) _role = new List<CodeableConcept>(); return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private List<CodeableConcept> _role;

            /// <summary>
            /// Direct reference to resource
            /// </summary>
            [FhirElement("reference", InSummary=true, Order=50)]
            [References("Practitioner","Organization","Device","Patient","RelatedPerson")]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            /// <summary>
            /// Unique identifier for the user
            /// </summary>
            [FhirElement("userId", InSummary=true, Order=60)]
            [DataMember]
            public Identifier UserId
            {
                get { return _userId; }
                set { _userId = value; OnPropertyChanged("UserId"); }
            }

            private Identifier _userId;

            /// <summary>
            /// Alternative User id e.g. authentication
            /// </summary>
            [FhirElement("altId", Order=70)]
            [DataMember]
            public FhirString AltIdElement
            {
                get { return _altIdElement; }
                set { _altIdElement = value; OnPropertyChanged("AltIdElement"); }
            }

            private FhirString _altIdElement;

            /// <summary>
            /// Alternative User id e.g. authentication
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string AltId
            {
                get { return AltIdElement != null ? AltIdElement.Value : null; }
                set
                {
                    if (value == null)
                        AltIdElement = null;
                    else
                        AltIdElement = new FhirString(value);
                    OnPropertyChanged("AltId");
                }
            }

            /// <summary>
            /// Human-meaningful name for the agent
            /// </summary>
            [FhirElement("name", Order=80)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Human-meaningful name for the agent
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
            /// Whether user is initiator
            /// </summary>
            [FhirElement("requestor", Order=90)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean RequestorElement
            {
                get { return _requestorElement; }
                set { _requestorElement = value; OnPropertyChanged("RequestorElement"); }
            }

            private FhirBoolean _requestorElement;

            /// <summary>
            /// Whether user is initiator
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Requestor
            {
                get { return RequestorElement != null ? RequestorElement.Value : null; }
                set
                {
                    if (value == null)
                        RequestorElement = null;
                    else
                        RequestorElement = new FhirBoolean(value);
                    OnPropertyChanged("Requestor");
                }
            }

            /// <summary>
            /// Where
            /// </summary>
            [FhirElement("location", Order=100)]
            [References("Location")]
            [DataMember]
            public ResourceReference Location
            {
                get { return _location; }
                set { _location = value; OnPropertyChanged("Location"); }
            }

            private ResourceReference _location;

            /// <summary>
            /// Policy that authorized event
            /// </summary>
            [FhirElement("policy", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirUri> PolicyElement
            {
                get { if (_policyElement==null) _policyElement = new List<FhirUri>(); return _policyElement; }
                set { _policyElement = value; OnPropertyChanged("PolicyElement"); }
            }

            private List<FhirUri> _policyElement;

            /// <summary>
            /// Policy that authorized event
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
            /// Type of media
            /// </summary>
            [FhirElement("media", Order=120)]
            [DataMember]
            public Coding Media
            {
                get { return _media; }
                set { _media = value; OnPropertyChanged("Media"); }
            }

            private Coding _media;

            /// <summary>
            /// Logical network location for application activity
            /// </summary>
            [FhirElement("network", Order=130)]
            [DataMember]
            public NetworkComponent Network
            {
                get { return _network; }
                set { _network = value; OnPropertyChanged("Network"); }
            }

            private NetworkComponent _network;

            /// <summary>
            /// Reason given for this user
            /// </summary>
            [FhirElement("purposeOfUse", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> PurposeOfUse
            {
                get { if (_purposeOfUse==null) _purposeOfUse = new List<CodeableConcept>(); return _purposeOfUse; }
                set { _purposeOfUse = value; OnPropertyChanged("PurposeOfUse"); }
            }

            private List<CodeableConcept> _purposeOfUse;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AgentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Role != null) dest.Role = new List<CodeableConcept>(Role.DeepCopy());
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    if (UserId != null) dest.UserId = (Identifier)UserId.DeepCopy();
                    if (AltIdElement != null) dest.AltIdElement = (FhirString)AltIdElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (RequestorElement != null) dest.RequestorElement = (FhirBoolean)RequestorElement.DeepCopy();
                    if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                    if (PolicyElement != null) dest.PolicyElement = new List<FhirUri>(PolicyElement.DeepCopy());
                    if (Media != null) dest.Media = (Coding)Media.DeepCopy();
                    if (Network != null) dest.Network = (NetworkComponent)Network.DeepCopy();
                    if (PurposeOfUse != null) dest.PurposeOfUse = new List<CodeableConcept>(PurposeOfUse.DeepCopy());
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
                if ( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if (!DeepComparable.Matches(UserId, otherT.UserId)) return false;
                if (!DeepComparable.Matches(AltIdElement, otherT.AltIdElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(RequestorElement, otherT.RequestorElement)) return false;
                if (!DeepComparable.Matches(Location, otherT.Location)) return false;
                if ( !DeepComparable.Matches(PolicyElement, otherT.PolicyElement)) return false;
                if (!DeepComparable.Matches(Media, otherT.Media)) return false;
                if (!DeepComparable.Matches(Network, otherT.Network)) return false;
                if ( !DeepComparable.Matches(PurposeOfUse, otherT.PurposeOfUse)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(UserId, otherT.UserId)) return false;
                if (!DeepComparable.IsExactly(AltIdElement, otherT.AltIdElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(RequestorElement, otherT.RequestorElement)) return false;
                if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
                if (!DeepComparable.IsExactly(PolicyElement, otherT.PolicyElement)) return false;
                if (!DeepComparable.IsExactly(Media, otherT.Media)) return false;
                if (!DeepComparable.IsExactly(Network, otherT.Network)) return false;
                if (!DeepComparable.IsExactly(PurposeOfUse, otherT.PurposeOfUse)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Role) { if (elem != null) yield return elem; }
                    if (Reference != null) yield return Reference;
                    if (UserId != null) yield return UserId;
                    if (AltIdElement != null) yield return AltIdElement;
                    if (NameElement != null) yield return NameElement;
                    if (RequestorElement != null) yield return RequestorElement;
                    if (Location != null) yield return Location;
                    foreach (var elem in PolicyElement) { if (elem != null) yield return elem; }
                    if (Media != null) yield return Media;
                    if (Network != null) yield return Network;
                    foreach (var elem in PurposeOfUse) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Role) { if (elem != null) yield return new ElementValue("role", elem); }
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                    if (UserId != null) yield return new ElementValue("userId", UserId);
                    if (AltIdElement != null) yield return new ElementValue("altId", AltIdElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (RequestorElement != null) yield return new ElementValue("requestor", RequestorElement);
                    if (Location != null) yield return new ElementValue("location", Location);
                    foreach (var elem in PolicyElement) { if (elem != null) yield return new ElementValue("policy", elem); }
                    if (Media != null) yield return new ElementValue("media", Media);
                    if (Network != null) yield return new ElementValue("network", Network);
                    foreach (var elem in PurposeOfUse) { if (elem != null) yield return new ElementValue("purposeOfUse", elem); }
                }
            }


        }


        [FhirType("NetworkComponent")]
        [DataContract]
        public partial class NetworkComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "NetworkComponent"; } }

            /// <summary>
            /// Identifier for the network access point of the user device
            /// </summary>
            [FhirElement("address", Order=40)]
            [DataMember]
            public FhirString AddressElement
            {
                get { return _addressElement; }
                set { _addressElement = value; OnPropertyChanged("AddressElement"); }
            }

            private FhirString _addressElement;

            /// <summary>
            /// Identifier for the network access point of the user device
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Address
            {
                get { return AddressElement != null ? AddressElement.Value : null; }
                set
                {
                    if (value == null)
                        AddressElement = null;
                    else
                        AddressElement = new FhirString(value);
                    OnPropertyChanged("Address");
                }
            }

            /// <summary>
            /// The type of network access point
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public Code<AuditEventAgentNetworkType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<AuditEventAgentNetworkType> _typeElement;

            /// <summary>
            /// The type of network access point
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public AuditEventAgentNetworkType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<AuditEventAgentNetworkType>(value);
                    OnPropertyChanged("Type");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NetworkComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (AddressElement != null) dest.AddressElement = (FhirString)AddressElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<AuditEventAgentNetworkType>)TypeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new NetworkComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NetworkComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(AddressElement, otherT.AddressElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NetworkComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(AddressElement, otherT.AddressElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (AddressElement != null) yield return AddressElement;
                    if (TypeElement != null) yield return TypeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (AddressElement != null) yield return new ElementValue("address", AddressElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                }
            }


        }


        [FhirType("SourceComponent")]
        [DataContract]
        public partial class SourceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SourceComponent"; } }

            /// <summary>
            /// Logical source location within the enterprise
            /// </summary>
            [FhirElement("site", Order=40)]
            [DataMember]
            public FhirString SiteElement
            {
                get { return _siteElement; }
                set { _siteElement = value; OnPropertyChanged("SiteElement"); }
            }

            private FhirString _siteElement;

            /// <summary>
            /// Logical source location within the enterprise
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Site
            {
                get { return SiteElement != null ? SiteElement.Value : null; }
                set
                {
                    if (value == null)
                        SiteElement = null;
                    else
                        SiteElement = new FhirString(value);
                    OnPropertyChanged("Site");
                }
            }

            /// <summary>
            /// The identity of source detecting the event
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// The type of source where event originated
            /// </summary>
            [FhirElement("type", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Type
            {
                get { if (_type==null) _type = new List<Coding>(); return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private List<Coding> _type;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SiteElement != null) dest.SiteElement = (FhirString)SiteElement.DeepCopy();
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (Type != null) dest.Type = new List<Coding>(Type.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SourceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SourceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SiteElement, otherT.SiteElement)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if ( !DeepComparable.Matches(Type, otherT.Type)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SiteElement, otherT.SiteElement)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SiteElement != null) yield return SiteElement;
                    if (Identifier != null) yield return Identifier;
                    foreach (var elem in Type) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SiteElement != null) yield return new ElementValue("site", SiteElement);
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
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
            /// Specific instance of object
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
            /// Specific instance of resource
            /// </summary>
            [FhirElement("reference", InSummary=true, Order=50)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            /// <summary>
            /// Type of entity involved
            /// </summary>
            [FhirElement("type", Order=60)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// What role the entity played
            /// </summary>
            [FhirElement("role", Order=70)]
            [DataMember]
            public Coding Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private Coding _role;

            /// <summary>
            /// Life-cycle stage for the entity
            /// </summary>
            [FhirElement("lifecycle", Order=80)]
            [DataMember]
            public Coding Lifecycle
            {
                get { return _lifecycle; }
                set { _lifecycle = value; OnPropertyChanged("Lifecycle"); }
            }

            private Coding _lifecycle;

            /// <summary>
            /// Security labels on the entity
            /// </summary>
            [FhirElement("securityLabel", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> SecurityLabel
            {
                get { if (_securityLabel==null) _securityLabel = new List<Coding>(); return _securityLabel; }
                set { _securityLabel = value; OnPropertyChanged("SecurityLabel"); }
            }

            private List<Coding> _securityLabel;

            /// <summary>
            /// Descriptor for entity
            /// </summary>
            [FhirElement("name", InSummary=true, Order=100)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Descriptor for entity
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
            /// Descriptive text
            /// </summary>
            [FhirElement("description", Order=110)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Descriptive text
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
            /// Query parameters
            /// </summary>
            [FhirElement("query", InSummary=true, Order=120)]
            [DataMember]
            public Base64Binary QueryElement
            {
                get { return _queryElement; }
                set { _queryElement = value; OnPropertyChanged("QueryElement"); }
            }

            private Base64Binary _queryElement;

            /// <summary>
            /// Query parameters
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public byte[] Query
            {
                get { return QueryElement != null ? QueryElement.Value : null; }
                set
                {
                    if (value == null)
                        QueryElement = null;
                    else
                        QueryElement = new Base64Binary(value);
                    OnPropertyChanged("Query");
                }
            }

            /// <summary>
            /// Additional Information about the entity
            /// </summary>
            [FhirElement("detail", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DetailComponent> Detail
            {
                get { if (_detail==null) _detail = new List<DetailComponent>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<DetailComponent> _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EntityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Role != null) dest.Role = (Coding)Role.DeepCopy();
                    if (Lifecycle != null) dest.Lifecycle = (Coding)Lifecycle.DeepCopy();
                    if (SecurityLabel != null) dest.SecurityLabel = new List<Coding>(SecurityLabel.DeepCopy());
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (QueryElement != null) dest.QueryElement = (Base64Binary)QueryElement.DeepCopy();
                    if (Detail != null) dest.Detail = new List<DetailComponent>(Detail.DeepCopy());
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
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Lifecycle, otherT.Lifecycle)) return false;
                if ( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(QueryElement, otherT.QueryElement)) return false;
                if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EntityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Lifecycle, otherT.Lifecycle)) return false;
                if (!DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(QueryElement, otherT.QueryElement)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (Reference != null) yield return Reference;
                    if (Type != null) yield return Type;
                    if (Role != null) yield return Role;
                    if (Lifecycle != null) yield return Lifecycle;
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (QueryElement != null) yield return QueryElement;
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Lifecycle != null) yield return new ElementValue("lifecycle", Lifecycle);
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", elem); }
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (QueryElement != null) yield return new ElementValue("query", QueryElement);
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
                }
            }


        }


        [FhirType("DetailComponent")]
        [DataContract]
        public partial class DetailComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DetailComponent"; } }

            /// <summary>
            /// Name of the property
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private FhirString _typeElement;

            /// <summary>
            /// Name of the property
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
                        TypeElement = new FhirString(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Property value
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Base64Binary ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private Base64Binary _valueElement;

            /// <summary>
            /// Property value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public byte[] Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new Base64Binary(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (FhirString)TypeElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (Base64Binary)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DetailComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DetailComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        /// <summary>
        /// Type/identifier of event
        /// </summary>
        [FhirElement("type", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Coding Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private Coding _type;

        /// <summary>
        /// More specific type/id for the event
        /// </summary>
        [FhirElement("subtype", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Coding> Subtype
        {
            get { if (_subtype==null) _subtype = new List<Coding>(); return _subtype; }
            set { _subtype = value; OnPropertyChanged("Subtype"); }
        }

        private List<Coding> _subtype;

        /// <summary>
        /// Type of action performed during the event
        /// </summary>
        [FhirElement("action", InSummary=true, Order=110)]
        [DataMember]
        public Code<AuditEventAction> ActionElement
        {
            get { return _actionElement; }
            set { _actionElement = value; OnPropertyChanged("ActionElement"); }
        }

        private Code<AuditEventAction> _actionElement;

        /// <summary>
        /// Type of action performed during the event
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AuditEventAction? Action
        {
            get { return ActionElement != null ? ActionElement.Value : null; }
            set
            {
                if (value == null)
                    ActionElement = null;
                else
                    ActionElement = new Code<AuditEventAction>(value);
                OnPropertyChanged("Action");
            }
        }

        /// <summary>
        /// Time when the event occurred on source
        /// </summary>
        [FhirElement("recorded", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Instant RecordedElement
        {
            get { return _recordedElement; }
            set { _recordedElement = value; OnPropertyChanged("RecordedElement"); }
        }

        private Instant _recordedElement;

        /// <summary>
        /// Time when the event occurred on source
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
        /// Whether the event succeeded or failed
        /// </summary>
        [FhirElement("outcome", InSummary=true, Order=130)]
        [DataMember]
        public Code<AuditEventOutcome> OutcomeElement
        {
            get { return _outcomeElement; }
            set { _outcomeElement = value; OnPropertyChanged("OutcomeElement"); }
        }

        private Code<AuditEventOutcome> _outcomeElement;

        /// <summary>
        /// Whether the event succeeded or failed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AuditEventOutcome? Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if (value == null)
                    OutcomeElement = null;
                else
                    OutcomeElement = new Code<AuditEventOutcome>(value);
                OnPropertyChanged("Outcome");
            }
        }

        /// <summary>
        /// Description of the event outcome
        /// </summary>
        [FhirElement("outcomeDesc", InSummary=true, Order=140)]
        [DataMember]
        public FhirString OutcomeDescElement
        {
            get { return _outcomeDescElement; }
            set { _outcomeDescElement = value; OnPropertyChanged("OutcomeDescElement"); }
        }

        private FhirString _outcomeDescElement;

        /// <summary>
        /// Description of the event outcome
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string OutcomeDesc
        {
            get { return OutcomeDescElement != null ? OutcomeDescElement.Value : null; }
            set
            {
                if (value == null)
                    OutcomeDescElement = null;
                else
                    OutcomeDescElement = new FhirString(value);
                OnPropertyChanged("OutcomeDesc");
            }
        }

        /// <summary>
        /// The purposeOfUse of the event
        /// </summary>
        [FhirElement("purposeOfEvent", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> PurposeOfEvent
        {
            get { if (_purposeOfEvent==null) _purposeOfEvent = new List<CodeableConcept>(); return _purposeOfEvent; }
            set { _purposeOfEvent = value; OnPropertyChanged("PurposeOfEvent"); }
        }

        private List<CodeableConcept> _purposeOfEvent;

        /// <summary>
        /// Actor involved in the event
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
        /// Audit Event Reporter
        /// </summary>
        [FhirElement("source", Order=170)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public SourceComponent Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private SourceComponent _source;

        /// <summary>
        /// Data or objects used
        /// </summary>
        [FhirElement("entity", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EntityComponent> Entity
        {
            get { if (_entity==null) _entity = new List<EntityComponent>(); return _entity; }
            set { _entity = value; OnPropertyChanged("Entity"); }
        }

        private List<EntityComponent> _entity;


        public static ElementDefinition.ConstraintComponent AuditEvent_SEV_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "entity.all(name.empty() or query.empty())",
            Key = "sev-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Either a name or a query (NOT both)",
            Xpath = "not(exists(f:name)) or not(exists(f:query))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(AuditEvent_SEV_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as AuditEvent;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                if (Subtype != null) dest.Subtype = new List<Coding>(Subtype.DeepCopy());
                if (ActionElement != null) dest.ActionElement = (Code<AuditEventAction>)ActionElement.DeepCopy();
                if (RecordedElement != null) dest.RecordedElement = (Instant)RecordedElement.DeepCopy();
                if (OutcomeElement != null) dest.OutcomeElement = (Code<AuditEventOutcome>)OutcomeElement.DeepCopy();
                if (OutcomeDescElement != null) dest.OutcomeDescElement = (FhirString)OutcomeDescElement.DeepCopy();
                if (PurposeOfEvent != null) dest.PurposeOfEvent = new List<CodeableConcept>(PurposeOfEvent.DeepCopy());
                if (Agent != null) dest.Agent = new List<AgentComponent>(Agent.DeepCopy());
                if (Source != null) dest.Source = (SourceComponent)Source.DeepCopy();
                if (Entity != null) dest.Entity = new List<EntityComponent>(Entity.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new AuditEvent());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as AuditEvent;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(Subtype, otherT.Subtype)) return false;
            if (!DeepComparable.Matches(ActionElement, otherT.ActionElement)) return false;
            if (!DeepComparable.Matches(RecordedElement, otherT.RecordedElement)) return false;
            if (!DeepComparable.Matches(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.Matches(OutcomeDescElement, otherT.OutcomeDescElement)) return false;
            if ( !DeepComparable.Matches(PurposeOfEvent, otherT.PurposeOfEvent)) return false;
            if ( !DeepComparable.Matches(Agent, otherT.Agent)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if ( !DeepComparable.Matches(Entity, otherT.Entity)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as AuditEvent;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Subtype, otherT.Subtype)) return false;
            if (!DeepComparable.IsExactly(ActionElement, otherT.ActionElement)) return false;
            if (!DeepComparable.IsExactly(RecordedElement, otherT.RecordedElement)) return false;
            if (!DeepComparable.IsExactly(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.IsExactly(OutcomeDescElement, otherT.OutcomeDescElement)) return false;
            if (!DeepComparable.IsExactly(PurposeOfEvent, otherT.PurposeOfEvent)) return false;
            if (!DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Entity, otherT.Entity)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Type != null) yield return Type;
                foreach (var elem in Subtype) { if (elem != null) yield return elem; }
                if (ActionElement != null) yield return ActionElement;
                if (RecordedElement != null) yield return RecordedElement;
                if (OutcomeElement != null) yield return OutcomeElement;
                if (OutcomeDescElement != null) yield return OutcomeDescElement;
                foreach (var elem in PurposeOfEvent) { if (elem != null) yield return elem; }
                foreach (var elem in Agent) { if (elem != null) yield return elem; }
                if (Source != null) yield return Source;
                foreach (var elem in Entity) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Type != null) yield return new ElementValue("type", Type);
                foreach (var elem in Subtype) { if (elem != null) yield return new ElementValue("subtype", elem); }
                if (ActionElement != null) yield return new ElementValue("action", ActionElement);
                if (RecordedElement != null) yield return new ElementValue("recorded", RecordedElement);
                if (OutcomeElement != null) yield return new ElementValue("outcome", OutcomeElement);
                if (OutcomeDescElement != null) yield return new ElementValue("outcomeDesc", OutcomeDescElement);
                foreach (var elem in PurposeOfEvent) { if (elem != null) yield return new ElementValue("purposeOfEvent", elem); }
                foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", elem); }
                if (Source != null) yield return new ElementValue("source", Source);
                foreach (var elem in Entity) { if (elem != null) yield return new ElementValue("entity", elem); }
            }
        }

    }

}
