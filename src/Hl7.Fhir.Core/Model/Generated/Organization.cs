﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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
    /// A grouping of people or organizations with a common purpose
    /// </summary>
    [FhirType("Organization", IsResource=true)]
    [DataContract]
    public partial class Organization : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Organization; } }
        [NotMapped]
        public override string TypeName { get { return "Organization"; } }


        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }

            /// <summary>
            /// The type of contact
            /// </summary>
            [FhirElement("purpose", Order=40)]
            [DataMember]
            public CodeableConcept Purpose
            {
                get { return _purpose; }
                set { _purpose = value; OnPropertyChanged("Purpose"); }
            }

            private CodeableConcept _purpose;

            /// <summary>
            /// A name associated with the contact
            /// </summary>
            [FhirElement("name", Order=50)]
            [DataMember]
            public HumanName Name
            {
                get { return _name; }
                set { _name = value; OnPropertyChanged("Name"); }
            }

            private HumanName _name;

            /// <summary>
            /// Contact details (telephone, email, etc.)  for a contact
            /// </summary>
            [FhirElement("telecom", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContactPoint> Telecom
            {
                get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
                set { _telecom = value; OnPropertyChanged("Telecom"); }
            }

            private List<ContactPoint> _telecom;

            /// <summary>
            /// Visiting or postal addresses for the contact
            /// </summary>
            [FhirElement("address", Order=70)]
            [DataMember]
            public Address Address
            {
                get { return _address; }
                set { _address = value; OnPropertyChanged("Address"); }
            }

            private Address _address;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Purpose != null) dest.Purpose = (CodeableConcept)Purpose.DeepCopy();
                    if (Name != null) dest.Name = (HumanName)Name.DeepCopy();
                    if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                    if (Address != null) dest.Address = (Address)Address.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
                if (!DeepComparable.Matches(Name, otherT.Name)) return false;
                if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
                if (!DeepComparable.Matches(Address, otherT.Address)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
                if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
                if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;

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
                    if (Purpose != null) yield return new ElementValue("purpose", false, Purpose);
                    if (Name != null) yield return new ElementValue("name", false, Name);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", true, elem); }
                    if (Address != null) yield return new ElementValue("address", false, Address);
                }
            }


        }


        /// <summary>
        /// Identifies this organization  across multiple systems
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
        /// Whether the organization's record is still in active use
        /// </summary>
        [FhirElement("active", InSummary=true, Order=100)]
        [DataMember]
        public FhirBoolean ActiveElement
        {
            get { return _activeElement; }
            set { _activeElement = value; OnPropertyChanged("ActiveElement"); }
        }

        private FhirBoolean _activeElement;

        /// <summary>
        /// Whether the organization's record is still in active use
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveElement = null;
                else
                    ActiveElement = new FhirBoolean(value);
                OnPropertyChanged("Active");
            }
        }

        /// <summary>
        /// Kind of organization
        /// </summary>
        [FhirElement("type", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Type
        {
            get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private List<CodeableConcept> _type;

        /// <summary>
        /// Name used for the organization
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
        /// Name used for the organization
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
        /// A list of alternate names that the organization is known as, or was known as in the past
        /// </summary>
        [FhirElement("alias", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> AliasElement
        {
            get { if (_aliasElement==null) _aliasElement = new List<FhirString>(); return _aliasElement; }
            set { _aliasElement = value; OnPropertyChanged("AliasElement"); }
        }

        private List<FhirString> _aliasElement;

        /// <summary>
        /// A list of alternate names that the organization is known as, or was known as in the past
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Alias
        {
            get { return AliasElement != null ? AliasElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    AliasElement = null;
                else
                    AliasElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Alias");
            }
        }

        /// <summary>
        /// A contact detail for the organization
        /// </summary>
        [FhirElement("telecom", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Telecom
        {
            get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
            set { _telecom = value; OnPropertyChanged("Telecom"); }
        }

        private List<ContactPoint> _telecom;

        /// <summary>
        /// An address for the organization
        /// </summary>
        [FhirElement("address", Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Address> Address
        {
            get { if (_address==null) _address = new List<Address>(); return _address; }
            set { _address = value; OnPropertyChanged("Address"); }
        }

        private List<Address> _address;

        /// <summary>
        /// The organization of which this organization forms a part
        /// </summary>
        [FhirElement("partOf", InSummary=true, Order=160)]
        [References("Organization")]
        [DataMember]
        public ResourceReference PartOf
        {
            get { return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private ResourceReference _partOf;

        /// <summary>
        /// Contact for the organization for a certain purpose
        /// </summary>
        [FhirElement("contact", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact==null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// Technical endpoints providing access to services operated for the organization
        /// </summary>
        [FhirElement("endpoint", Order=180)]
        [References("Endpoint")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Endpoint
        {
            get { if (_endpoint==null) _endpoint = new List<ResourceReference>(); return _endpoint; }
            set { _endpoint = value; OnPropertyChanged("Endpoint"); }
        }

        private List<ResourceReference> _endpoint;


        public static ElementDefinition.ConstraintComponent Organization_ORG_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(identifier.count() + name.count()) > 0",
            Key = "org-1",
            Severity = ConstraintSeverity.Warning,
            Human = "The organization SHALL at least have a name or an id, and possibly more than one",
            Xpath = "count(f:identifier | f:name) > 0"
        };

        public static ElementDefinition.ConstraintComponent Organization_ORG_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "telecom.all(where(use = 'home').empty())",
            Key = "org-3",
            Severity = ConstraintSeverity.Warning,
            Human = "The telecom of an organization can never be of use 'home'",
            Xpath = "count(f:use[@value='home']) = 0"
        };

        public static ElementDefinition.ConstraintComponent Organization_ORG_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "address.all(where(use = 'home').empty())",
            Key = "org-2",
            Severity = ConstraintSeverity.Warning,
            Human = "An address of an organization can never be of use 'home'",
            Xpath = "count(f:use[@value='home']) = 0"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Organization_ORG_1);
            InvariantConstraints.Add(Organization_ORG_3);
            InvariantConstraints.Add(Organization_ORG_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Organization;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (AliasElement != null) dest.AliasElement = new List<FhirString>(AliasElement.DeepCopy());
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (Address != null) dest.Address = new List<Address>(Address.DeepCopy());
                if (PartOf != null) dest.PartOf = (ResourceReference)PartOf.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
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
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if ( !DeepComparable.Matches(AliasElement, otherT.AliasElement)) return false;
            if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if ( !DeepComparable.Matches(Address, otherT.Address)) return false;
            if (!DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Organization;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(AliasElement, otherT.AliasElement)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (ActiveElement != null) yield return ActiveElement;
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                if (NameElement != null) yield return NameElement;
                foreach (var elem in AliasElement) { if (elem != null) yield return elem; }
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                foreach (var elem in Address) { if (elem != null) yield return elem; }
                if (PartOf != null) yield return PartOf;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (ActiveElement != null) yield return new ElementValue("active", false, ActiveElement);
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", true, elem); }
                if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                foreach (var elem in AliasElement) { if (elem != null) yield return new ElementValue("alias", true, elem); }
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", true, elem); }
                foreach (var elem in Address) { if (elem != null) yield return new ElementValue("address", true, elem); }
                if (PartOf != null) yield return new ElementValue("partOf", false, PartOf);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", true, elem); }
                foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", true, elem); }
            }
        }

    }

}
