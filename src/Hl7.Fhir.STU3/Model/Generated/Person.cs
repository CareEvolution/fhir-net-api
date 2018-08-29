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
    /// A generic person record
    /// </summary>
    [FhirType("Person", IsResource=true)]
    [DataContract]
    public partial class Person : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Person; } }
        [NotMapped]
        public override string TypeName { get { return "Person"; } }


        [FhirType("LinkComponent")]
        [DataContract]
        public partial class LinkComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LinkComponent"; } }

            /// <summary>
            /// The resource to which this actual person is associated
            /// </summary>
            [FhirElement("target", Order=40)]
            [References("Patient","Practitioner","RelatedPerson","Person")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Target
            {
                get { return _target; }
                set { _target = value; OnPropertyChanged("Target"); }
            }

            private ResourceReference _target;

            /// <summary>
            /// level1 | level2 | level3 | level4
            /// </summary>
            [FhirElement("assurance", Order=50)]
            [DataMember]
            public Code<IdentityAssuranceLevel> AssuranceElement
            {
                get { return _assuranceElement; }
                set { _assuranceElement = value; OnPropertyChanged("AssuranceElement"); }
            }

            private Code<IdentityAssuranceLevel> _assuranceElement;

            /// <summary>
            /// level1 | level2 | level3 | level4
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IdentityAssuranceLevel? Assurance
            {
                get { return AssuranceElement != null ? AssuranceElement.Value : null; }
                set
                {
                    if (value == null)
                        AssuranceElement = null;
                    else
                        AssuranceElement = new Code<IdentityAssuranceLevel>(value);
                    OnPropertyChanged("Assurance");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LinkComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Target != null) dest.Target = (ResourceReference)Target.DeepCopy();
                    if (AssuranceElement != null) dest.AssuranceElement = (Code<IdentityAssuranceLevel>)AssuranceElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LinkComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Target, otherT.Target)) return false;
                if (!DeepComparable.Matches(AssuranceElement, otherT.AssuranceElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
                if (!DeepComparable.IsExactly(AssuranceElement, otherT.AssuranceElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Target != null) yield return Target;
                    if (AssuranceElement != null) yield return AssuranceElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Target != null) yield return new ElementValue("target", Target);
                    if (AssuranceElement != null) yield return new ElementValue("assurance", AssuranceElement);
                }
            }


        }


        /// <summary>
        /// A human identifier for this person
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// A name associated with the person
        /// </summary>
        [FhirElement("name", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<HumanName> Name
        {
            get { if (_name==null) _name = new List<HumanName>(); return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        private List<HumanName> _name;

        /// <summary>
        /// A contact detail for the person
        /// </summary>
        [FhirElement("telecom", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Telecom
        {
            get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
            set { _telecom = value; OnPropertyChanged("Telecom"); }
        }

        private List<ContactPoint> _telecom;

        /// <summary>
        /// male | female | other | unknown
        /// </summary>
        [FhirElement("gender", InSummary=true, Order=120)]
        [DataMember]
        public Code<AdministrativeGender> GenderElement
        {
            get { return _genderElement; }
            set { _genderElement = value; OnPropertyChanged("GenderElement"); }
        }

        private Code<AdministrativeGender> _genderElement;

        /// <summary>
        /// male | female | other | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AdministrativeGender? Gender
        {
            get { return GenderElement != null ? GenderElement.Value : null; }
            set
            {
                if (value == null)
                    GenderElement = null;
                else
                    GenderElement = new Code<AdministrativeGender>(value);
                OnPropertyChanged("Gender");
            }
        }

        /// <summary>
        /// The date on which the person was born
        /// </summary>
        [FhirElement("birthDate", InSummary=true, Order=130)]
        [DataMember]
        public Date BirthDateElement
        {
            get { return _birthDateElement; }
            set { _birthDateElement = value; OnPropertyChanged("BirthDateElement"); }
        }

        private Date _birthDateElement;

        /// <summary>
        /// The date on which the person was born
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string BirthDate
        {
            get { return BirthDateElement != null ? BirthDateElement.Value : null; }
            set
            {
                if (value == null)
                    BirthDateElement = null;
                else
                    BirthDateElement = new Date(value);
                OnPropertyChanged("BirthDate");
            }
        }

        /// <summary>
        /// One or more addresses for the person
        /// </summary>
        [FhirElement("address", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Address> Address
        {
            get { if (_address==null) _address = new List<Address>(); return _address; }
            set { _address = value; OnPropertyChanged("Address"); }
        }

        private List<Address> _address;

        /// <summary>
        /// Image of the person
        /// </summary>
        [FhirElement("photo", Order=150)]
        [DataMember]
        public Attachment Photo
        {
            get { return _photo; }
            set { _photo = value; OnPropertyChanged("Photo"); }
        }

        private Attachment _photo;

        /// <summary>
        /// The organization that is the custodian of the person record
        /// </summary>
        [FhirElement("managingOrganization", InSummary=true, Order=160)]
        [References("Organization")]
        [DataMember]
        public ResourceReference ManagingOrganization
        {
            get { return _managingOrganization; }
            set { _managingOrganization = value; OnPropertyChanged("ManagingOrganization"); }
        }

        private ResourceReference _managingOrganization;

        /// <summary>
        /// This person's record is in active use
        /// </summary>
        [FhirElement("active", InSummary=true, Order=170)]
        [DataMember]
        public FhirBoolean ActiveElement
        {
            get { return _activeElement; }
            set { _activeElement = value; OnPropertyChanged("ActiveElement"); }
        }

        private FhirBoolean _activeElement;

        /// <summary>
        /// This person's record is in active use
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
        /// Link to a resource that concerns the same actual person
        /// </summary>
        [FhirElement("link", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LinkComponent> Link
        {
            get { if (_link==null) _link = new List<LinkComponent>(); return _link; }
            set { _link = value; OnPropertyChanged("Link"); }
        }

        private List<LinkComponent> _link;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Person;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Name != null) dest.Name = new List<HumanName>(Name.DeepCopy());
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (GenderElement != null) dest.GenderElement = (Code<AdministrativeGender>)GenderElement.DeepCopy();
                if (BirthDateElement != null) dest.BirthDateElement = (Date)BirthDateElement.DeepCopy();
                if (Address != null) dest.Address = new List<Address>(Address.DeepCopy());
                if (Photo != null) dest.Photo = (Attachment)Photo.DeepCopy();
                if (ManagingOrganization != null) dest.ManagingOrganization = (ResourceReference)ManagingOrganization.DeepCopy();
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (Link != null) dest.Link = new List<LinkComponent>(Link.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Person());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Person;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(Name, otherT.Name)) return false;
            if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.Matches(BirthDateElement, otherT.BirthDateElement)) return false;
            if ( !DeepComparable.Matches(Address, otherT.Address)) return false;
            if (!DeepComparable.Matches(Photo, otherT.Photo)) return false;
            if (!DeepComparable.Matches(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if ( !DeepComparable.Matches(Link, otherT.Link)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Person;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.IsExactly(BirthDateElement, otherT.BirthDateElement)) return false;
            if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if (!DeepComparable.IsExactly(Photo, otherT.Photo)) return false;
            if (!DeepComparable.IsExactly(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(Link, otherT.Link)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in Name) { if (elem != null) yield return elem; }
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                if (GenderElement != null) yield return GenderElement;
                if (BirthDateElement != null) yield return BirthDateElement;
                foreach (var elem in Address) { if (elem != null) yield return elem; }
                if (Photo != null) yield return Photo;
                if (ManagingOrganization != null) yield return ManagingOrganization;
                if (ActiveElement != null) yield return ActiveElement;
                foreach (var elem in Link) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in Name) { if (elem != null) yield return new ElementValue("name", elem); }
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                if (BirthDateElement != null) yield return new ElementValue("birthDate", BirthDateElement);
                foreach (var elem in Address) { if (elem != null) yield return new ElementValue("address", elem); }
                if (Photo != null) yield return new ElementValue("photo", Photo);
                if (ManagingOrganization != null) yield return new ElementValue("managingOrganization", ManagingOrganization);
                if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
                foreach (var elem in Link) { if (elem != null) yield return new ElementValue("link", elem); }
            }
        }

    }

}
