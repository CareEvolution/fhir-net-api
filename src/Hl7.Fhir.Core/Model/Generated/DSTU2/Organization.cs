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
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
{
    /// <summary>
    /// A grouping of people or organizations with a common purpose
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.DSTU2, "Organization", IsResource=true)]
    [DataContract]
    public partial class Organization : Hl7.Fhir.Model.DomainResource, Hl7.Fhir.Model.IOrganization, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Organization; } }
        [NotMapped]
        public override string TypeName { get { return "Organization"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.DSTU2, "ContactComponent")]
        [DataContract]
        public partial class ContactComponent : Hl7.Fhir.Model.BackboneElement, Hl7.Fhir.Model.IOrganizationContactComponent, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }
            
            [NotMapped]
            Hl7.Fhir.Model.IHumanName Hl7.Fhir.Model.IOrganizationContactComponent.Name { get { return Name; } }
            
            [NotMapped]
            IEnumerable<Hl7.Fhir.Model.IContactPoint> Hl7.Fhir.Model.IOrganizationContactComponent.Telecom { get { return Telecom; } }
            
            /// <summary>
            /// The type of contact
            /// </summary>
            [FhirElement("purpose", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Purpose
            {
                get { return _Purpose; }
                set { _Purpose = value; OnPropertyChanged("Purpose"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Purpose;
            
            /// <summary>
            /// A name associated with the contact
            /// </summary>
            [FhirElement("name", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.DSTU2.HumanName Name
            {
                get { return _Name; }
                set { _Name = value; OnPropertyChanged("Name"); }
            }
            
            private Hl7.Fhir.Model.DSTU2.HumanName _Name;
            
            /// <summary>
            /// Contact details (telephone, email, etc.)  for a contact
            /// </summary>
            [FhirElement("telecom", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.DSTU2.ContactPoint> Telecom
            {
                get { if(_Telecom==null) _Telecom = new List<Hl7.Fhir.Model.DSTU2.ContactPoint>(); return _Telecom; }
                set { _Telecom = value; OnPropertyChanged("Telecom"); }
            }
            
            private List<Hl7.Fhir.Model.DSTU2.ContactPoint> _Telecom;
            
            /// <summary>
            /// Visiting or postal addresses for the contact
            /// </summary>
            [FhirElement("address", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.Address Address
            {
                get { return _Address; }
                set { _Address = value; OnPropertyChanged("Address"); }
            }
            
            private Hl7.Fhir.Model.Address _Address;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("ContactComponent");
                base.Serialize(sink);
                sink.Element("purpose", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Purpose?.Serialize(sink);
                sink.Element("name", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Name?.Serialize(sink);
                sink.BeginList("telecom", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in Telecom)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.Element("address", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Address?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Purpose = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("purpose", Hl7.Fhir.Model.Version.All);
                Name = source.GetProperty<Hl7.Fhir.Model.DSTU2.HumanName>("name", Hl7.Fhir.Model.Version.All);
                Telecom = source.GetList<Hl7.Fhir.Model.DSTU2.ContactPoint>("telecom", Hl7.Fhir.Model.Version.All);
                Address = source.GetProperty<Hl7.Fhir.Model.Address>("address", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"purpose", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"name", typeof(Hl7.Fhir.Model.DSTU2.HumanName)},
                    {"telecom", typeof(Hl7.Fhir.Model.DSTU2.ContactPoint)},
                    {"address", typeof(Hl7.Fhir.Model.Address)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Purpose != null) dest.Purpose = (Hl7.Fhir.Model.CodeableConcept)Purpose.DeepCopy();
                    if(Name != null) dest.Name = (Hl7.Fhir.Model.DSTU2.HumanName)Name.DeepCopy();
                    if(Telecom != null) dest.Telecom = new List<Hl7.Fhir.Model.DSTU2.ContactPoint>(Telecom.DeepCopy());
                    if(Address != null) dest.Address = (Hl7.Fhir.Model.Address)Address.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContactComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
                if( !DeepComparable.Matches(Name, otherT.Name)) return false;
                if( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
                if( !DeepComparable.Matches(Address, otherT.Address)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
                if( !DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if( !DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
                if( !DeepComparable.IsExactly(Address, otherT.Address)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Purpose != null) yield return Purpose;
                    if (Name != null) yield return Name;
                    foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                    if (Address != null) yield return Address;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Purpose != null) yield return new ElementValue("purpose", Purpose);
                    if (Name != null) yield return new ElementValue("name", Name);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                    if (Address != null) yield return new ElementValue("address", Address);
                }
            }
        
        
        }
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IContactPoint> Hl7.Fhir.Model.IOrganization.Telecom { get { return Telecom; } }
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IOrganizationContactComponent> Hl7.Fhir.Model.IOrganization.Contact { get { return Contact; } }
    
        
        /// <summary>
        /// Identifies this organization  across multiple systems
        /// </summary>
        [FhirElement("identifier", InSummary=Hl7.Fhir.Model.Version.All, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// Whether the organization's record is still in active use
        /// </summary>
        [FhirElement("active", InSummary=Hl7.Fhir.Model.Version.All, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean ActiveElement
        {
            get { return _ActiveElement; }
            set { _ActiveElement = value; OnPropertyChanged("ActiveElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _ActiveElement;
        
        /// <summary>
        /// Whether the organization's record is still in active use
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveElement = null;
                else
                    ActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("Active");
            }
        }
        
        /// <summary>
        /// Kind of organization
        /// </summary>
        [FhirElement("type", InSummary=Hl7.Fhir.Model.Version.All, Order=110)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// Name used for the organization
        /// </summary>
        [FhirElement("name", InSummary=Hl7.Fhir.Model.Version.All, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NameElement
        {
            get { return _NameElement; }
            set { _NameElement = value; OnPropertyChanged("NameElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NameElement;
        
        /// <summary>
        /// Name used for the organization
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
        /// A contact detail for the organization
        /// </summary>
        [FhirElement("telecom", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.DSTU2.ContactPoint> Telecom
        {
            get { if(_Telecom==null) _Telecom = new List<Hl7.Fhir.Model.DSTU2.ContactPoint>(); return _Telecom; }
            set { _Telecom = value; OnPropertyChanged("Telecom"); }
        }
        
        private List<Hl7.Fhir.Model.DSTU2.ContactPoint> _Telecom;
        
        /// <summary>
        /// An address for the organization
        /// </summary>
        [FhirElement("address", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Address> Address
        {
            get { if(_Address==null) _Address = new List<Hl7.Fhir.Model.Address>(); return _Address; }
            set { _Address = value; OnPropertyChanged("Address"); }
        }
        
        private List<Hl7.Fhir.Model.Address> _Address;
        
        /// <summary>
        /// The organization of which this organization forms a part
        /// </summary>
        [FhirElement("partOf", InSummary=Hl7.Fhir.Model.Version.All, Order=150)]
        [CLSCompliant(false)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference PartOf
        {
            get { return _PartOf; }
            set { _PartOf = value; OnPropertyChanged("PartOf"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _PartOf;
        
        /// <summary>
        /// Contact for the organization for a certain purpose
        /// </summary>
        [FhirElement("contact", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if(_Contact==null) _Contact = new List<ContactComponent>(); return _Contact; }
            set { _Contact = value; OnPropertyChanged("Contact"); }
        }
        
        private List<ContactComponent> _Contact;
    
    
        public static ElementDefinitionConstraint[] Organization_Constraints =
        {
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.DSTU2},
                key: "org-1",
                severity: ConstraintSeverity.Warning,
                expression: "identifier or name",
                human: "The organization SHALL at least have a name or an id, and possibly more than one",
                xpath: "count(f:identifier | f:name) > 0"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.DSTU2},
                key: "org-3",
                severity: ConstraintSeverity.Warning,
                expression: "telecom.all($this.where(use = 'home').empty())",
                human: "The telecom of an organization can never be of use 'home'",
                xpath: "count(f:use[@value='home']) = 0"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.DSTU2},
                key: "org-2",
                severity: ConstraintSeverity.Warning,
                expression: "address.all($this.where(use = 'home').empty())",
                human: "An address of an organization can never be of use 'home'",
                xpath: "count(f:use[@value='home']) = 0"
            ),
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
            InvariantConstraints.AddRange(Organization_Constraints);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Organization;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(ActiveElement != null) dest.ActiveElement = (Hl7.Fhir.Model.FhirBoolean)ActiveElement.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                if(Telecom != null) dest.Telecom = new List<Hl7.Fhir.Model.DSTU2.ContactPoint>(Telecom.DeepCopy());
                if(Address != null) dest.Address = new List<Hl7.Fhir.Model.Address>(Address.DeepCopy());
                if(PartOf != null) dest.PartOf = (Hl7.Fhir.Model.ResourceReference)PartOf.DeepCopy();
                if(Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Organization());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Organization;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if( !DeepComparable.Matches(Address, otherT.Address)) return false;
            if( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Organization;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if( !DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if( !DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if( !DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if( !DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
        
            return true;
        }
    
        internal override void Serialize(Serialization.SerializerSink sink)
        {
            sink.BeginResource("Organization");
            base.Serialize(sink);
            sink.BeginList("identifier", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Identifier)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("active", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); ActiveElement?.Serialize(sink);
            sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Type?.Serialize(sink);
            sink.Element("name", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); NameElement?.Serialize(sink);
            sink.BeginList("telecom", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Telecom)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("address", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Address)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("partOf", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); PartOf?.Serialize(sink);
            sink.BeginList("contact", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Contact)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.End();
        }
        
        internal override void Parse(Serialization.IParserSource source)
        {
            base.Parse(source);
            Identifier = source.GetList<Hl7.Fhir.Model.Identifier>("identifier", Hl7.Fhir.Model.Version.All);
            ActiveElement = source.GetBooleanProperty("active", Hl7.Fhir.Model.Version.All);
            Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
            NameElement = source.GetStringProperty("name", Hl7.Fhir.Model.Version.All);
            Telecom = source.GetList<Hl7.Fhir.Model.DSTU2.ContactPoint>("telecom", Hl7.Fhir.Model.Version.All);
            Address = source.GetList<Hl7.Fhir.Model.Address>("address", Hl7.Fhir.Model.Version.All);
            PartOf = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("partOf", Hl7.Fhir.Model.Version.All);
            Contact = source.GetList<ContactComponent>("contact", Hl7.Fhir.Model.Version.All);
        }
        
        internal override Type GetPropertyType(string fhirName)
        {
            if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
            return base.GetPropertyType(fhirName);
        }
        
        private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
        {
                {"identifier", typeof(Hl7.Fhir.Model.Identifier)},
                {"active", typeof(Hl7.Fhir.Model.FhirBoolean)},
                {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"name", typeof(Hl7.Fhir.Model.FhirString)},
                {"telecom", typeof(Hl7.Fhir.Model.DSTU2.ContactPoint)},
                {"address", typeof(Hl7.Fhir.Model.Address)},
                {"partOf", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"contact", typeof(ContactComponent)},
        };
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (ActiveElement != null) yield return ActiveElement;
                if (Type != null) yield return Type;
                if (NameElement != null) yield return NameElement;
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                foreach (var elem in Address) { if (elem != null) yield return elem; }
                if (PartOf != null) yield return PartOf;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                foreach (var elem in Address) { if (elem != null) yield return new ElementValue("address", elem); }
                if (PartOf != null) yield return new ElementValue("partOf", PartOf);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
            }
        }
    
    }

}
