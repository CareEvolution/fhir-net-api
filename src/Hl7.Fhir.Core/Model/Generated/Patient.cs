using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
    /// Information about an individual or animal receiving health care services
    /// </summary>
    [FhirType("Patient", IsResource=true)]
    [DataContract]
    public partial class Patient : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Patient; } }
        [NotMapped]
        public override string TypeName { get { return "Patient"; } }

        /// <summary>
        /// The type of link between this patient resource and another patient resource.
        /// (url: http://hl7.org/fhir/ValueSet/link-type)
        /// </summary>
        [FhirEnumeration("LinkType")]
        public enum LinkType
        {
            /// <summary>
            /// The patient resource containing this link must no longer be used. The link points forward to another patient resource that must be used in lieu of the patient resource that contains this link.
            /// (system: http://hl7.org/fhir/link-type)
            /// </summary>
            [EnumLiteral("replace", "http://hl7.org/fhir/link-type"), Description("Replace")]
            Replace,
            /// <summary>
            /// The patient resource containing this link is in use and valid but not considered the main source of information about a patient. The link points forward to another patient resource that should be consulted to retrieve additional patient information.
            /// (system: http://hl7.org/fhir/link-type)
            /// </summary>
            [EnumLiteral("refer", "http://hl7.org/fhir/link-type"), Description("Refer")]
            Refer,
            /// <summary>
            /// The patient resource containing this link is in use and valid, but points to another patient resource that is known to contain data about the same person. Data in this resource might overlap or contradict information found in the other patient resource. This link does not indicate any relative importance of the resources concerned, and both should be regarded as equally valid.
            /// (system: http://hl7.org/fhir/link-type)
            /// </summary>
            [EnumLiteral("seealso", "http://hl7.org/fhir/link-type"), Description("See also")]
            Seealso,
        }


        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }

            /// <summary>
            /// The kind of relationship
            /// </summary>
            [FhirElement("relationship", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Relationship
            {
                get { if (_relationship==null) _relationship = new List<CodeableConcept>(); return _relationship; }
                set { _relationship = value; OnPropertyChanged("Relationship"); }
            }

            private List<CodeableConcept> _relationship;

            /// <summary>
            /// A name associated with the contact person
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
            /// A contact detail for the person
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
            /// Address for the contact person
            /// </summary>
            [FhirElement("address", Order=70)]
            [DataMember]
            public Address Address
            {
                get { return _address; }
                set { _address = value; OnPropertyChanged("Address"); }
            }

            private Address _address;

            /// <summary>
            /// male | female | other | unknown
            /// </summary>
            [FhirElement("gender", Order=80)]
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
            /// Organization that is associated with the contact
            /// </summary>
            [FhirElement("organization", Order=90)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Organization
            {
                get { return _organization; }
                set { _organization = value; OnPropertyChanged("Organization"); }
            }

            private ResourceReference _organization;

            /// <summary>
            /// The period during which this contact person or organization is valid to be contacted relating to this patient
            /// </summary>
            [FhirElement("period", Order=100)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Relationship != null) dest.Relationship = new List<CodeableConcept>(Relationship.DeepCopy());
                    if (Name != null) dest.Name = (HumanName)Name.DeepCopy();
                    if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                    if (Address != null) dest.Address = (Address)Address.DeepCopy();
                    if (GenderElement != null) dest.GenderElement = (Code<AdministrativeGender>)GenderElement.DeepCopy();
                    if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
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
                if ( !DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.Matches(Name, otherT.Name)) return false;
                if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
                if (!DeepComparable.Matches(Address, otherT.Address)) return false;
                if (!DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
                if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
                if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
                if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;
                if (!DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
                if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Relationship) { if (elem != null) yield return elem; }
                    if (Name != null) yield return Name;
                    foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                    if (Address != null) yield return Address;
                    if (GenderElement != null) yield return GenderElement;
                    if (Organization != null) yield return Organization;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Relationship) { if (elem != null) yield return new ElementValue("relationship", elem); }
                    if (Name != null) yield return new ElementValue("name", Name);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                    if (Address != null) yield return new ElementValue("address", Address);
                    if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                    if (Organization != null) yield return new ElementValue("organization", Organization);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }


        }


        [FhirType("AnimalComponent")]
        [DataContract]
        public partial class AnimalComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AnimalComponent"; } }

            /// <summary>
            /// E.g. Dog, Cow
            /// </summary>
            [FhirElement("species", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Species
            {
                get { return _species; }
                set { _species = value; OnPropertyChanged("Species"); }
            }

            private CodeableConcept _species;

            /// <summary>
            /// E.g. Poodle, Angus
            /// </summary>
            [FhirElement("breed", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Breed
            {
                get { return _breed; }
                set { _breed = value; OnPropertyChanged("Breed"); }
            }

            private CodeableConcept _breed;

            /// <summary>
            /// E.g. Neutered, Intact
            /// </summary>
            [FhirElement("genderStatus", InSummary=true, Order=60)]
            [DataMember]
            public CodeableConcept GenderStatus
            {
                get { return _genderStatus; }
                set { _genderStatus = value; OnPropertyChanged("GenderStatus"); }
            }

            private CodeableConcept _genderStatus;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AnimalComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Species != null) dest.Species = (CodeableConcept)Species.DeepCopy();
                    if (Breed != null) dest.Breed = (CodeableConcept)Breed.DeepCopy();
                    if (GenderStatus != null) dest.GenderStatus = (CodeableConcept)GenderStatus.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AnimalComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AnimalComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Species, otherT.Species)) return false;
                if (!DeepComparable.Matches(Breed, otherT.Breed)) return false;
                if (!DeepComparable.Matches(GenderStatus, otherT.GenderStatus)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AnimalComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Species, otherT.Species)) return false;
                if (!DeepComparable.IsExactly(Breed, otherT.Breed)) return false;
                if (!DeepComparable.IsExactly(GenderStatus, otherT.GenderStatus)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Species != null) yield return Species;
                    if (Breed != null) yield return Breed;
                    if (GenderStatus != null) yield return GenderStatus;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Species != null) yield return new ElementValue("species", Species);
                    if (Breed != null) yield return new ElementValue("breed", Breed);
                    if (GenderStatus != null) yield return new ElementValue("genderStatus", GenderStatus);
                }
            }


        }


        [FhirType("CommunicationComponent")]
        [DataContract]
        public partial class CommunicationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CommunicationComponent"; } }

            /// <summary>
            /// The language which can be used to communicate with the patient about his or her health
            /// </summary>
            [FhirElement("language", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Language
            {
                get { return _language; }
                set { _language = value; OnPropertyChanged("Language"); }
            }

            private CodeableConcept _language;

            /// <summary>
            /// Language preference indicator
            /// </summary>
            [FhirElement("preferred", Order=50)]
            [DataMember]
            public FhirBoolean PreferredElement
            {
                get { return _preferredElement; }
                set { _preferredElement = value; OnPropertyChanged("PreferredElement"); }
            }

            private FhirBoolean _preferredElement;

            /// <summary>
            /// Language preference indicator
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Preferred
            {
                get { return PreferredElement != null ? PreferredElement.Value : null; }
                set
                {
                    if (value == null)
                        PreferredElement = null;
                    else
                        PreferredElement = new FhirBoolean(value);
                    OnPropertyChanged("Preferred");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CommunicationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Language != null) dest.Language = (CodeableConcept)Language.DeepCopy();
                    if (PreferredElement != null) dest.PreferredElement = (FhirBoolean)PreferredElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CommunicationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CommunicationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Language, otherT.Language)) return false;
                if (!DeepComparable.Matches(PreferredElement, otherT.PreferredElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CommunicationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Language, otherT.Language)) return false;
                if (!DeepComparable.IsExactly(PreferredElement, otherT.PreferredElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Language != null) yield return Language;
                    if (PreferredElement != null) yield return PreferredElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Language != null) yield return new ElementValue("language", Language);
                    if (PreferredElement != null) yield return new ElementValue("preferred", PreferredElement);
                }
            }


        }


        [FhirType("LinkComponent")]
        [DataContract]
        public partial class LinkComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LinkComponent"; } }

            /// <summary>
            /// The other patient resource that the link refers to
            /// </summary>
            [FhirElement("other", Order=40)]
            [References("Patient")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Other
            {
                get { return _other; }
                set { _other = value; OnPropertyChanged("Other"); }
            }

            private ResourceReference _other;

            /// <summary>
            /// replace | refer | seealso - type of link
            /// </summary>
            [FhirElement("type", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<LinkType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<LinkType> _typeElement;

            /// <summary>
            /// replace | refer | seealso - type of link
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public LinkType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<LinkType>(value);
                    OnPropertyChanged("Type");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LinkComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Other != null) dest.Other = (ResourceReference)Other.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<LinkType>)TypeElement.DeepCopy();
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
                if (!DeepComparable.Matches(Other, otherT.Other)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LinkComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Other, otherT.Other)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Other != null) yield return Other;
                    if (TypeElement != null) yield return TypeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Other != null) yield return new ElementValue("other", Other);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                }
            }


        }


        /// <summary>
        /// An identifier for this patient
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
        /// Whether this patient's record is in active use
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
        /// Whether this patient's record is in active use
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
        /// A name associated with the patient
        /// </summary>
        [FhirElement("name", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<HumanName> Name
        {
            get { if (_name==null) _name = new List<HumanName>(); return _name; }
            set { _name = value; OnPropertyChanged("Name"); }
        }

        private List<HumanName> _name;

        /// <summary>
        /// A contact detail for the individual
        /// </summary>
        [FhirElement("telecom", InSummary=true, Order=120)]
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
        [FhirElement("gender", InSummary=true, Order=130)]
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
        /// The date of birth for the individual
        /// </summary>
        [FhirElement("birthDate", InSummary=true, Order=140)]
        [DataMember]
        public Date BirthDateElement
        {
            get { return _birthDateElement; }
            set { _birthDateElement = value; OnPropertyChanged("BirthDateElement"); }
        }

        private Date _birthDateElement;

        /// <summary>
        /// The date of birth for the individual
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
        /// Indicates if the individual is deceased or not
        /// </summary>
        [FhirElement("deceased", InSummary=true, Order=150, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirBoolean),typeof(FhirDateTime))]
        [DataMember]
        public Element Deceased
        {
            get { return _deceased; }
            set { _deceased = value; OnPropertyChanged("Deceased"); }
        }

        private Element _deceased;

        /// <summary>
        /// Addresses for the individual
        /// </summary>
        [FhirElement("address", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Address> Address
        {
            get { if (_address==null) _address = new List<Address>(); return _address; }
            set { _address = value; OnPropertyChanged("Address"); }
        }

        private List<Address> _address;

        /// <summary>
        /// Marital (civil) status of a patient
        /// </summary>
        [FhirElement("maritalStatus", Order=170)]
        [DataMember]
        public CodeableConcept MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; OnPropertyChanged("MaritalStatus"); }
        }

        private CodeableConcept _maritalStatus;

        /// <summary>
        /// Whether patient is part of a multiple birth
        /// </summary>
        [FhirElement("multipleBirth", Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirBoolean),typeof(Integer))]
        [DataMember]
        public Element MultipleBirth
        {
            get { return _multipleBirth; }
            set { _multipleBirth = value; OnPropertyChanged("MultipleBirth"); }
        }

        private Element _multipleBirth;

        /// <summary>
        /// Image of the patient
        /// </summary>
        [FhirElement("photo", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Attachment> Photo
        {
            get { if (_photo==null) _photo = new List<Attachment>(); return _photo; }
            set { _photo = value; OnPropertyChanged("Photo"); }
        }

        private List<Attachment> _photo;

        /// <summary>
        /// A contact party (e.g. guardian, partner, friend) for the patient
        /// </summary>
        [FhirElement("contact", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact==null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// This patient is known to be an animal (non-human)
        /// </summary>
        [FhirElement("animal", InSummary=true, Order=210)]
        [DataMember]
        public AnimalComponent Animal
        {
            get { return _animal; }
            set { _animal = value; OnPropertyChanged("Animal"); }
        }

        private AnimalComponent _animal;

        /// <summary>
        /// A list of Languages which may be used to communicate with the patient about his or her health
        /// </summary>
        [FhirElement("communication", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CommunicationComponent> Communication
        {
            get { if (_communication==null) _communication = new List<CommunicationComponent>(); return _communication; }
            set { _communication = value; OnPropertyChanged("Communication"); }
        }

        private List<CommunicationComponent> _communication;

        /// <summary>
        /// Patient's nominated primary care provider
        /// </summary>
        [FhirElement("careProvider", Order=230)]
        [References("Organization","Practitioner")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> CareProvider
        {
            get { if (_careProvider==null) _careProvider = new List<ResourceReference>(); return _careProvider; }
            set { _careProvider = value; OnPropertyChanged("CareProvider"); }
        }

        private List<ResourceReference> _careProvider;

        /// <summary>
        /// Organization that is the custodian of the patient record
        /// </summary>
        [FhirElement("managingOrganization", InSummary=true, Order=240)]
        [References("Organization")]
        [DataMember]
        public ResourceReference ManagingOrganization
        {
            get { return _managingOrganization; }
            set { _managingOrganization = value; OnPropertyChanged("ManagingOrganization"); }
        }

        private ResourceReference _managingOrganization;

        /// <summary>
        /// Link to another patient resource that concerns the same actual person
        /// </summary>
        [FhirElement("link", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LinkComponent> Link
        {
            get { if (_link==null) _link = new List<LinkComponent>(); return _link; }
            set { _link = value; OnPropertyChanged("Link"); }
        }

        private List<LinkComponent> _link;


        public static ElementDefinition.ConstraintComponent Patient_PAT_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "contact.all(name or telecom or address or organization)",
            Key = "pat-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "SHALL at least contain a contact's details or a reference to an organization",
            Xpath = "f:name or f:telecom or f:address or f:organization"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Patient_PAT_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Patient;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (Name != null) dest.Name = new List<HumanName>(Name.DeepCopy());
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (GenderElement != null) dest.GenderElement = (Code<AdministrativeGender>)GenderElement.DeepCopy();
                if (BirthDateElement != null) dest.BirthDateElement = (Date)BirthDateElement.DeepCopy();
                if (Deceased != null) dest.Deceased = (Element)Deceased.DeepCopy();
                if (Address != null) dest.Address = new List<Address>(Address.DeepCopy());
                if (MaritalStatus != null) dest.MaritalStatus = (CodeableConcept)MaritalStatus.DeepCopy();
                if (MultipleBirth != null) dest.MultipleBirth = (Element)MultipleBirth.DeepCopy();
                if (Photo != null) dest.Photo = new List<Attachment>(Photo.DeepCopy());
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (Animal != null) dest.Animal = (AnimalComponent)Animal.DeepCopy();
                if (Communication != null) dest.Communication = new List<CommunicationComponent>(Communication.DeepCopy());
                if (CareProvider != null) dest.CareProvider = new List<ResourceReference>(CareProvider.DeepCopy());
                if (ManagingOrganization != null) dest.ManagingOrganization = (ResourceReference)ManagingOrganization.DeepCopy();
                if (Link != null) dest.Link = new List<LinkComponent>(Link.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Patient());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Patient;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if ( !DeepComparable.Matches(Name, otherT.Name)) return false;
            if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.Matches(BirthDateElement, otherT.BirthDateElement)) return false;
            if (!DeepComparable.Matches(Deceased, otherT.Deceased)) return false;
            if ( !DeepComparable.Matches(Address, otherT.Address)) return false;
            if (!DeepComparable.Matches(MaritalStatus, otherT.MaritalStatus)) return false;
            if (!DeepComparable.Matches(MultipleBirth, otherT.MultipleBirth)) return false;
            if ( !DeepComparable.Matches(Photo, otherT.Photo)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Animal, otherT.Animal)) return false;
            if ( !DeepComparable.Matches(Communication, otherT.Communication)) return false;
            if ( !DeepComparable.Matches(CareProvider, otherT.CareProvider)) return false;
            if (!DeepComparable.Matches(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if ( !DeepComparable.Matches(Link, otherT.Link)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Patient;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.IsExactly(BirthDateElement, otherT.BirthDateElement)) return false;
            if (!DeepComparable.IsExactly(Deceased, otherT.Deceased)) return false;
            if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if (!DeepComparable.IsExactly(MaritalStatus, otherT.MaritalStatus)) return false;
            if (!DeepComparable.IsExactly(MultipleBirth, otherT.MultipleBirth)) return false;
            if (!DeepComparable.IsExactly(Photo, otherT.Photo)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Animal, otherT.Animal)) return false;
            if (!DeepComparable.IsExactly(Communication, otherT.Communication)) return false;
            if (!DeepComparable.IsExactly(CareProvider, otherT.CareProvider)) return false;
            if (!DeepComparable.IsExactly(ManagingOrganization, otherT.ManagingOrganization)) return false;
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
                if (ActiveElement != null) yield return ActiveElement;
                foreach (var elem in Name) { if (elem != null) yield return elem; }
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                if (GenderElement != null) yield return GenderElement;
                if (BirthDateElement != null) yield return BirthDateElement;
                if (Deceased != null) yield return Deceased;
                foreach (var elem in Address) { if (elem != null) yield return elem; }
                if (MaritalStatus != null) yield return MaritalStatus;
                if (MultipleBirth != null) yield return MultipleBirth;
                foreach (var elem in Photo) { if (elem != null) yield return elem; }
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Animal != null) yield return Animal;
                foreach (var elem in Communication) { if (elem != null) yield return elem; }
                foreach (var elem in CareProvider) { if (elem != null) yield return elem; }
                if (ManagingOrganization != null) yield return ManagingOrganization;
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
                if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
                foreach (var elem in Name) { if (elem != null) yield return new ElementValue("name", elem); }
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                if (BirthDateElement != null) yield return new ElementValue("birthDate", BirthDateElement);
                if (Deceased != null) yield return new ElementValue("deceased", Deceased);
                foreach (var elem in Address) { if (elem != null) yield return new ElementValue("address", elem); }
                if (MaritalStatus != null) yield return new ElementValue("maritalStatus", MaritalStatus);
                if (MultipleBirth != null) yield return new ElementValue("multipleBirth", MultipleBirth);
                foreach (var elem in Photo) { if (elem != null) yield return new ElementValue("photo", elem); }
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Animal != null) yield return new ElementValue("animal", Animal);
                foreach (var elem in Communication) { if (elem != null) yield return new ElementValue("communication", elem); }
                foreach (var elem in CareProvider) { if (elem != null) yield return new ElementValue("careProvider", elem); }
                if (ManagingOrganization != null) yield return new ElementValue("managingOrganization", ManagingOrganization);
                foreach (var elem in Link) { if (elem != null) yield return new ElementValue("link", elem); }
            }
        }

    }

}
