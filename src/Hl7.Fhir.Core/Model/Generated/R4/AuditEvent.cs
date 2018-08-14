﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Utility;

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
    /// Event record kept for security purposes
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "AuditEvent", IsResource=true)]
    [DataContract]
    public partial class AuditEvent : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.AuditEvent; } }
        [NotMapped]
        public override string TypeName { get { return "AuditEvent"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "AgentComponent")]
        [DataContract]
        public partial class AgentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AgentComponent"; } }
            
            /// <summary>
            /// How agent participated
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Agent role in the event
            /// </summary>
            [FhirElement("role", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Role
            {
                get { if(_Role==null) _Role = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Role;
            
            /// <summary>
            /// Direct reference to resource
            /// </summary>
            [FhirElement("reference", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [References("PractitionerRole","Practitioner","Organization","Device","Patient","RelatedPerson")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Reference
            {
                get { return _Reference; }
                set { _Reference = value; OnPropertyChanged("Reference"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Reference;
            
            /// <summary>
            /// Unique identifier for the user
            /// </summary>
            [FhirElement("userId", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier UserId
            {
                get { return _UserId; }
                set { _UserId = value; OnPropertyChanged("UserId"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _UserId;
            
            /// <summary>
            /// Alternative User id e.g. authentication
            /// </summary>
            [FhirElement("altId", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AltIdElement
            {
                get { return _AltIdElement; }
                set { _AltIdElement = value; OnPropertyChanged("AltIdElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AltIdElement;
            
            /// <summary>
            /// Alternative User id e.g. authentication
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string AltId
            {
                get { return AltIdElement != null ? AltIdElement.Value : null; }
                set
                {
                    if (value == null)
                        AltIdElement = null;
                    else
                        AltIdElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("AltId");
                }
            }
            
            /// <summary>
            /// Human-meaningful name for the agent
            /// </summary>
            [FhirElement("name", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Human-meaningful name for the agent
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Whether user is initiator
            /// </summary>
            [FhirElement("requestor", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean RequestorElement
            {
                get { return _RequestorElement; }
                set { _RequestorElement = value; OnPropertyChanged("RequestorElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _RequestorElement;
            
            /// <summary>
            /// Whether user is initiator
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Requestor
            {
                get { return RequestorElement != null ? RequestorElement.Value : null; }
                set
                {
                    if (value == null)
                        RequestorElement = null;
                    else
                        RequestorElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Requestor");
                }
            }
            
            /// <summary>
            /// Where
            /// </summary>
            [FhirElement("location", Order=110)]
            [CLSCompliant(false)]
            [References("Location")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Location
            {
                get { return _Location; }
                set { _Location = value; OnPropertyChanged("Location"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Location;
            
            /// <summary>
            /// Policy that authorized event
            /// </summary>
            [FhirElement("policy", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirUri> PolicyElement
            {
                get { if(_PolicyElement==null) _PolicyElement = new List<Hl7.Fhir.Model.FhirUri>(); return _PolicyElement; }
                set { _PolicyElement = value; OnPropertyChanged("PolicyElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirUri> _PolicyElement;
            
            /// <summary>
            /// Policy that authorized event
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Policy
            {
                get { return PolicyElement != null ? PolicyElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PolicyElement = null;
                    else
                        PolicyElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
                    OnPropertyChanged("Policy");
                }
            }
            
            /// <summary>
            /// Type of media
            /// </summary>
            [FhirElement("media", Order=130)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Coding Media
            {
                get { return _Media; }
                set { _Media = value; OnPropertyChanged("Media"); }
            }
            
            private Hl7.Fhir.Model.R4.Coding _Media;
            
            /// <summary>
            /// Logical network location for application activity
            /// </summary>
            [FhirElement("network", Order=140)]
            [DataMember]
            public NetworkComponent Network
            {
                get { return _Network; }
                set { _Network = value; OnPropertyChanged("Network"); }
            }
            
            private NetworkComponent _Network;
            
            /// <summary>
            /// Reason given for this user
            /// </summary>
            [FhirElement("purposeOfUse", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> PurposeOfUse
            {
                get { if(_PurposeOfUse==null) _PurposeOfUse = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _PurposeOfUse; }
                set { _PurposeOfUse = value; OnPropertyChanged("PurposeOfUse"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _PurposeOfUse;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AgentComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Role != null) dest.Role = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Role.DeepCopy());
                    if(Reference != null) dest.Reference = (Hl7.Fhir.Model.R4.ResourceReference)Reference.DeepCopy();
                    if(UserId != null) dest.UserId = (Hl7.Fhir.Model.R4.Identifier)UserId.DeepCopy();
                    if(AltIdElement != null) dest.AltIdElement = (Hl7.Fhir.Model.FhirString)AltIdElement.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(RequestorElement != null) dest.RequestorElement = (Hl7.Fhir.Model.FhirBoolean)RequestorElement.DeepCopy();
                    if(Location != null) dest.Location = (Hl7.Fhir.Model.R4.ResourceReference)Location.DeepCopy();
                    if(PolicyElement != null) dest.PolicyElement = new List<Hl7.Fhir.Model.FhirUri>(PolicyElement.DeepCopy());
                    if(Media != null) dest.Media = (Hl7.Fhir.Model.R4.Coding)Media.DeepCopy();
                    if(Network != null) dest.Network = (NetworkComponent)Network.DeepCopy();
                    if(PurposeOfUse != null) dest.PurposeOfUse = new List<Hl7.Fhir.Model.R4.CodeableConcept>(PurposeOfUse.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if( !DeepComparable.Matches(UserId, otherT.UserId)) return false;
                if( !DeepComparable.Matches(AltIdElement, otherT.AltIdElement)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(RequestorElement, otherT.RequestorElement)) return false;
                if( !DeepComparable.Matches(Location, otherT.Location)) return false;
                if( !DeepComparable.Matches(PolicyElement, otherT.PolicyElement)) return false;
                if( !DeepComparable.Matches(Media, otherT.Media)) return false;
                if( !DeepComparable.Matches(Network, otherT.Network)) return false;
                if( !DeepComparable.Matches(PurposeOfUse, otherT.PurposeOfUse)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if( !DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if( !DeepComparable.IsExactly(UserId, otherT.UserId)) return false;
                if( !DeepComparable.IsExactly(AltIdElement, otherT.AltIdElement)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(RequestorElement, otherT.RequestorElement)) return false;
                if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
                if( !DeepComparable.IsExactly(PolicyElement, otherT.PolicyElement)) return false;
                if( !DeepComparable.IsExactly(Media, otherT.Media)) return false;
                if( !DeepComparable.IsExactly(Network, otherT.Network)) return false;
                if( !DeepComparable.IsExactly(PurposeOfUse, otherT.PurposeOfUse)) return false;
            
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
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    foreach (var elem in Role) { if (elem != null) yield return new ElementValue("role", true, elem); }
                    if (Reference != null) yield return new ElementValue("reference", false, Reference);
                    if (UserId != null) yield return new ElementValue("userId", false, UserId);
                    if (AltIdElement != null) yield return new ElementValue("altId", false, AltIdElement);
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (RequestorElement != null) yield return new ElementValue("requestor", false, RequestorElement);
                    if (Location != null) yield return new ElementValue("location", false, Location);
                    foreach (var elem in PolicyElement) { if (elem != null) yield return new ElementValue("policy", true, elem); }
                    if (Media != null) yield return new ElementValue("media", false, Media);
                    if (Network != null) yield return new ElementValue("network", false, Network);
                    foreach (var elem in PurposeOfUse) { if (elem != null) yield return new ElementValue("purposeOfUse", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "NetworkComponent")]
        [DataContract]
        public partial class NetworkComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NetworkComponent"; } }
            
            /// <summary>
            /// Identifier for the network access point of the user device
            /// </summary>
            [FhirElement("address", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString AddressElement
            {
                get { return _AddressElement; }
                set { _AddressElement = value; OnPropertyChanged("AddressElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _AddressElement;
            
            /// <summary>
            /// Identifier for the network access point of the user device
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Address
            {
                get { return AddressElement != null ? AddressElement.Value : null; }
                set
                {
                    if (value == null)
                        AddressElement = null;
                    else
                        AddressElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Address");
                }
            }
            
            /// <summary>
            /// The type of network access point
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _TypeElement;
            
            /// <summary>
            /// The type of network access point
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Type");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NetworkComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(AddressElement != null) dest.AddressElement = (Hl7.Fhir.Model.FhirString)AddressElement.DeepCopy();
                    if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.R4.Code)TypeElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(AddressElement, otherT.AddressElement)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NetworkComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(AddressElement, otherT.AddressElement)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            
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
                    if (AddressElement != null) yield return new ElementValue("address", false, AddressElement);
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SourceComponent")]
        [DataContract]
        public partial class SourceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SourceComponent"; } }
            
            /// <summary>
            /// Logical source location within the enterprise
            /// </summary>
            [FhirElement("site", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString SiteElement
            {
                get { return _SiteElement; }
                set { _SiteElement = value; OnPropertyChanged("SiteElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _SiteElement;
            
            /// <summary>
            /// Logical source location within the enterprise
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Site
            {
                get { return SiteElement != null ? SiteElement.Value : null; }
                set
                {
                    if (value == null)
                        SiteElement = null;
                    else
                        SiteElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Site");
                }
            }
            
            /// <summary>
            /// The identity of source detecting the event
            /// </summary>
            [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Identifier;
            
            /// <summary>
            /// The type of source where event originated
            /// </summary>
            [FhirElement("type", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Coding> Type
            {
                get { if(_Type==null) _Type = new List<Hl7.Fhir.Model.R4.Coding>(); return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Coding> _Type;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SourceComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SiteElement != null) dest.SiteElement = (Hl7.Fhir.Model.FhirString)SiteElement.DeepCopy();
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
                    if(Type != null) dest.Type = new List<Hl7.Fhir.Model.R4.Coding>(Type.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SiteElement, otherT.SiteElement)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SourceComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SiteElement, otherT.SiteElement)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            
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
                    if (SiteElement != null) yield return new ElementValue("site", false, SiteElement);
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "EntityComponent")]
        [DataContract]
        public partial class EntityComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "EntityComponent"; } }
            
            /// <summary>
            /// Specific instance of object
            /// </summary>
            [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Identifier;
            
            /// <summary>
            /// Specific instance of resource
            /// </summary>
            [FhirElement("reference", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Reference
            {
                get { return _Reference; }
                set { _Reference = value; OnPropertyChanged("Reference"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Reference;
            
            /// <summary>
            /// Type of entity involved
            /// </summary>
            [FhirElement("type", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.Coding _Type;
            
            /// <summary>
            /// What role the entity played
            /// </summary>
            [FhirElement("role", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Coding Role
            {
                get { return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private Hl7.Fhir.Model.R4.Coding _Role;
            
            /// <summary>
            /// Life-cycle stage for the entity
            /// </summary>
            [FhirElement("lifecycle", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Coding Lifecycle
            {
                get { return _Lifecycle; }
                set { _Lifecycle = value; OnPropertyChanged("Lifecycle"); }
            }
            
            private Hl7.Fhir.Model.R4.Coding _Lifecycle;
            
            /// <summary>
            /// Security labels on the entity
            /// </summary>
            [FhirElement("securityLabel", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Coding> SecurityLabel
            {
                get { if(_SecurityLabel==null) _SecurityLabel = new List<Hl7.Fhir.Model.R4.Coding>(); return _SecurityLabel; }
                set { _SecurityLabel = value; OnPropertyChanged("SecurityLabel"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Coding> _SecurityLabel;
            
            /// <summary>
            /// Descriptor for entity
            /// </summary>
            [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Descriptor for entity
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Descriptive text
            /// </summary>
            [FhirElement("description", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Descriptive text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        DescriptionElement = null;
                    else
                        DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Query parameters
            /// </summary>
            [FhirElement("query", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.Base64Binary QueryElement
            {
                get { return _QueryElement; }
                set { _QueryElement = value; OnPropertyChanged("QueryElement"); }
            }
            
            private Hl7.Fhir.Model.Base64Binary _QueryElement;
            
            /// <summary>
            /// Query parameters
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public byte[] Query
            {
                get { return QueryElement != null ? QueryElement.Value : null; }
                set
                {
                    if (value == null)
                        QueryElement = null;
                    else
                        QueryElement = new Hl7.Fhir.Model.Base64Binary(value);
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
                get { if(_Detail==null) _Detail = new List<DetailComponent>(); return _Detail; }
                set { _Detail = value; OnPropertyChanged("Detail"); }
            }
            
            private List<DetailComponent> _Detail;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EntityComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
                    if(Reference != null) dest.Reference = (Hl7.Fhir.Model.R4.ResourceReference)Reference.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.Coding)Type.DeepCopy();
                    if(Role != null) dest.Role = (Hl7.Fhir.Model.R4.Coding)Role.DeepCopy();
                    if(Lifecycle != null) dest.Lifecycle = (Hl7.Fhir.Model.R4.Coding)Lifecycle.DeepCopy();
                    if(SecurityLabel != null) dest.SecurityLabel = new List<Hl7.Fhir.Model.R4.Coding>(SecurityLabel.DeepCopy());
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(QueryElement != null) dest.QueryElement = (Hl7.Fhir.Model.Base64Binary)QueryElement.DeepCopy();
                    if(Detail != null) dest.Detail = new List<DetailComponent>(Detail.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if( !DeepComparable.Matches(Lifecycle, otherT.Lifecycle)) return false;
                if( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(QueryElement, otherT.QueryElement)) return false;
                if( !DeepComparable.Matches(Detail, otherT.Detail)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EntityComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if( !DeepComparable.IsExactly(Lifecycle, otherT.Lifecycle)) return false;
                if( !DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(QueryElement, otherT.QueryElement)) return false;
                if( !DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
            
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
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                    if (Reference != null) yield return new ElementValue("reference", false, Reference);
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Role != null) yield return new ElementValue("role", false, Role);
                    if (Lifecycle != null) yield return new ElementValue("lifecycle", false, Lifecycle);
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", true, elem); }
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (QueryElement != null) yield return new ElementValue("query", false, QueryElement);
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DetailComponent")]
        [DataContract]
        public partial class DetailComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DetailComponent"; } }
            
            /// <summary>
            /// Name of the property
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _TypeElement;
            
            /// <summary>
            /// Name of the property
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Property value
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.Base64Binary))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.Element _Value;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DetailComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.FhirString)TypeElement.DeepCopy();
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.Element)Value.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DetailComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Value != null) yield return Value;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (Value != null) yield return new ElementValue("value", false, Value);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Type/identifier of event
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Coding Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.R4.Coding _Type;
        
        /// <summary>
        /// More specific type/id for the event
        /// </summary>
        [FhirElement("subtype", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Coding> Subtype
        {
            get { if(_Subtype==null) _Subtype = new List<Hl7.Fhir.Model.R4.Coding>(); return _Subtype; }
            set { _Subtype = value; OnPropertyChanged("Subtype"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Coding> _Subtype;
        
        /// <summary>
        /// Type of action performed during the event
        /// </summary>
        [FhirElement("action", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code ActionElement
        {
            get { return _ActionElement; }
            set { _ActionElement = value; OnPropertyChanged("ActionElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _ActionElement;
        
        /// <summary>
        /// Type of action performed during the event
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Action
        {
            get { return ActionElement != null ? ActionElement.Value : null; }
            set
            {
                if (value == null)
                    ActionElement = null;
                else
                    ActionElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Action");
            }
        }
        
        /// <summary>
        /// When the activity occurred
        /// </summary>
        [FhirElement("period", Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Period Period
        {
            get { return _Period; }
            set { _Period = value; OnPropertyChanged("Period"); }
        }
        
        private Hl7.Fhir.Model.R4.Period _Period;
        
        /// <summary>
        /// Time when the event was recorded
        /// </summary>
        [FhirElement("recorded", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Instant RecordedElement
        {
            get { return _RecordedElement; }
            set { _RecordedElement = value; OnPropertyChanged("RecordedElement"); }
        }
        
        private Hl7.Fhir.Model.Instant _RecordedElement;
        
        /// <summary>
        /// Time when the event was recorded
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public DateTimeOffset? Recorded
        {
            get { return RecordedElement != null ? RecordedElement.Value : null; }
            set
            {
                if (value == null)
                    RecordedElement = null;
                else
                    RecordedElement = new Hl7.Fhir.Model.Instant(value);
                OnPropertyChanged("Recorded");
            }
        }
        
        /// <summary>
        /// Whether the event succeeded or failed
        /// </summary>
        [FhirElement("outcome", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code OutcomeElement
        {
            get { return _OutcomeElement; }
            set { _OutcomeElement = value; OnPropertyChanged("OutcomeElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _OutcomeElement;
        
        /// <summary>
        /// Whether the event succeeded or failed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if (value == null)
                    OutcomeElement = null;
                else
                    OutcomeElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Outcome");
            }
        }
        
        /// <summary>
        /// Description of the event outcome
        /// </summary>
        [FhirElement("outcomeDesc", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString OutcomeDescElement
        {
            get { return _OutcomeDescElement; }
            set { _OutcomeDescElement = value; OnPropertyChanged("OutcomeDescElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _OutcomeDescElement;
        
        /// <summary>
        /// Description of the event outcome
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string OutcomeDesc
        {
            get { return OutcomeDescElement != null ? OutcomeDescElement.Value : null; }
            set
            {
                if (value == null)
                    OutcomeDescElement = null;
                else
                    OutcomeDescElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("OutcomeDesc");
            }
        }
        
        /// <summary>
        /// The purposeOfUse of the event
        /// </summary>
        [FhirElement("purposeOfEvent", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> PurposeOfEvent
        {
            get { if(_PurposeOfEvent==null) _PurposeOfEvent = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _PurposeOfEvent; }
            set { _PurposeOfEvent = value; OnPropertyChanged("PurposeOfEvent"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _PurposeOfEvent;
        
        /// <summary>
        /// Actor involved in the event
        /// </summary>
        [FhirElement("agent", Order=170)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<AgentComponent> Agent
        {
            get { if(_Agent==null) _Agent = new List<AgentComponent>(); return _Agent; }
            set { _Agent = value; OnPropertyChanged("Agent"); }
        }
        
        private List<AgentComponent> _Agent;
        
        /// <summary>
        /// Audit Event Reporter
        /// </summary>
        [FhirElement("source", Order=180)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public SourceComponent Source
        {
            get { return _Source; }
            set { _Source = value; OnPropertyChanged("Source"); }
        }
        
        private SourceComponent _Source;
        
        /// <summary>
        /// Data or objects used
        /// </summary>
        [FhirElement("entity", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EntityComponent> Entity
        {
            get { if(_Entity==null) _Entity = new List<EntityComponent>(); return _Entity; }
            set { _Entity = value; OnPropertyChanged("Entity"); }
        }
        
        private List<EntityComponent> _Entity;
    
    
        public static ElementDefinitionConstraint AuditEvent_SEV_1 = new ElementDefinitionConstraint
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
                if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.Coding)Type.DeepCopy();
                if(Subtype != null) dest.Subtype = new List<Hl7.Fhir.Model.R4.Coding>(Subtype.DeepCopy());
                if(ActionElement != null) dest.ActionElement = (Hl7.Fhir.Model.R4.Code)ActionElement.DeepCopy();
                if(Period != null) dest.Period = (Hl7.Fhir.Model.R4.Period)Period.DeepCopy();
                if(RecordedElement != null) dest.RecordedElement = (Hl7.Fhir.Model.Instant)RecordedElement.DeepCopy();
                if(OutcomeElement != null) dest.OutcomeElement = (Hl7.Fhir.Model.R4.Code)OutcomeElement.DeepCopy();
                if(OutcomeDescElement != null) dest.OutcomeDescElement = (Hl7.Fhir.Model.FhirString)OutcomeDescElement.DeepCopy();
                if(PurposeOfEvent != null) dest.PurposeOfEvent = new List<Hl7.Fhir.Model.R4.CodeableConcept>(PurposeOfEvent.DeepCopy());
                if(Agent != null) dest.Agent = new List<AgentComponent>(Agent.DeepCopy());
                if(Source != null) dest.Source = (SourceComponent)Source.DeepCopy();
                if(Entity != null) dest.Entity = new List<EntityComponent>(Entity.DeepCopy());
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(Subtype, otherT.Subtype)) return false;
            if( !DeepComparable.Matches(ActionElement, otherT.ActionElement)) return false;
            if( !DeepComparable.Matches(Period, otherT.Period)) return false;
            if( !DeepComparable.Matches(RecordedElement, otherT.RecordedElement)) return false;
            if( !DeepComparable.Matches(OutcomeElement, otherT.OutcomeElement)) return false;
            if( !DeepComparable.Matches(OutcomeDescElement, otherT.OutcomeDescElement)) return false;
            if( !DeepComparable.Matches(PurposeOfEvent, otherT.PurposeOfEvent)) return false;
            if( !DeepComparable.Matches(Agent, otherT.Agent)) return false;
            if( !DeepComparable.Matches(Source, otherT.Source)) return false;
            if( !DeepComparable.Matches(Entity, otherT.Entity)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as AuditEvent;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(Subtype, otherT.Subtype)) return false;
            if( !DeepComparable.IsExactly(ActionElement, otherT.ActionElement)) return false;
            if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if( !DeepComparable.IsExactly(RecordedElement, otherT.RecordedElement)) return false;
            if( !DeepComparable.IsExactly(OutcomeElement, otherT.OutcomeElement)) return false;
            if( !DeepComparable.IsExactly(OutcomeDescElement, otherT.OutcomeDescElement)) return false;
            if( !DeepComparable.IsExactly(PurposeOfEvent, otherT.PurposeOfEvent)) return false;
            if( !DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
            if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if( !DeepComparable.IsExactly(Entity, otherT.Entity)) return false;
        
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
                if (Period != null) yield return Period;
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
                if (Type != null) yield return new ElementValue("type", false, Type);
                foreach (var elem in Subtype) { if (elem != null) yield return new ElementValue("subtype", true, elem); }
                if (ActionElement != null) yield return new ElementValue("action", false, ActionElement);
                if (Period != null) yield return new ElementValue("period", false, Period);
                if (RecordedElement != null) yield return new ElementValue("recorded", false, RecordedElement);
                if (OutcomeElement != null) yield return new ElementValue("outcome", false, OutcomeElement);
                if (OutcomeDescElement != null) yield return new ElementValue("outcomeDesc", false, OutcomeDescElement);
                foreach (var elem in PurposeOfEvent) { if (elem != null) yield return new ElementValue("purposeOfEvent", true, elem); }
                foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", true, elem); }
                if (Source != null) yield return new ElementValue("source", false, Source);
                foreach (var elem in Entity) { if (elem != null) yield return new ElementValue("entity", true, elem); }
            }
        }
    
    }

}
