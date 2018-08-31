using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.DSTU2;
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
    /// An person that is related to a patient, but who is not a direct target of care
    /// </summary>
    [FhirType("RelatedPerson", IsResource=true)]
    [DataContract]
    public partial class RelatedPerson : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.RelatedPerson; } }
        [NotMapped]
        public override string TypeName { get { return "RelatedPerson"; } }


        /// <summary>
        /// A human identifier for this person
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
        /// The patient this person is related to
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=100)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// The nature of the relationship
        /// </summary>
        [FhirElement("relationship", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept Relationship
        {
            get { return _relationship; }
            set { _relationship = value; OnPropertyChanged("Relationship"); }
        }

        private CodeableConcept _relationship;

        /// <summary>
        /// A name associated with the person
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
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
        [FhirElement("telecom", InSummary=true, Order=130)]
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
        [FhirElement("gender", InSummary=true, Order=140)]
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
        /// The date on which the related person was born
        /// </summary>
        [FhirElement("birthDate", InSummary=true, Order=150)]
        [DataMember]
        public Date BirthDateElement
        {
            get { return _birthDateElement; }
            set { _birthDateElement = value; OnPropertyChanged("BirthDateElement"); }
        }

        private Date _birthDateElement;

        /// <summary>
        /// The date on which the related person was born
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
        /// Address where the related person can be contacted or visited
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
        /// Image of the person
        /// </summary>
        [FhirElement("photo", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Attachment> Photo
        {
            get { if (_photo==null) _photo = new List<Attachment>(); return _photo; }
            set { _photo = value; OnPropertyChanged("Photo"); }
        }

        private List<Attachment> _photo;

        /// <summary>
        /// Period of time that this relationship is considered valid
        /// </summary>
        [FhirElement("period", Order=180)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as RelatedPerson;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Relationship != null) dest.Relationship = (CodeableConcept)Relationship.DeepCopy();
                if (Name != null) dest.Name = (HumanName)Name.DeepCopy();
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (GenderElement != null) dest.GenderElement = (Code<AdministrativeGender>)GenderElement.DeepCopy();
                if (BirthDateElement != null) dest.BirthDateElement = (Date)BirthDateElement.DeepCopy();
                if (Address != null) dest.Address = new List<Address>(Address.DeepCopy());
                if (Photo != null) dest.Photo = new List<Attachment>(Photo.DeepCopy());
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new RelatedPerson());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as RelatedPerson;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
            if (!DeepComparable.Matches(Name, otherT.Name)) return false;
            if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.Matches(BirthDateElement, otherT.BirthDateElement)) return false;
            if ( !DeepComparable.Matches(Address, otherT.Address)) return false;
            if ( !DeepComparable.Matches(Photo, otherT.Photo)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as RelatedPerson;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
            if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.IsExactly(BirthDateElement, otherT.BirthDateElement)) return false;
            if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if (!DeepComparable.IsExactly(Photo, otherT.Photo)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
                if (Relationship != null) yield return Relationship;
                if (Name != null) yield return Name;
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                if (GenderElement != null) yield return GenderElement;
                if (BirthDateElement != null) yield return BirthDateElement;
                foreach (var elem in Address) { if (elem != null) yield return elem; }
                foreach (var elem in Photo) { if (elem != null) yield return elem; }
                if (Period != null) yield return Period;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Relationship != null) yield return new ElementValue("relationship", Relationship);
                if (Name != null) yield return new ElementValue("name", Name);
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                if (BirthDateElement != null) yield return new ElementValue("birthDate", BirthDateElement);
                foreach (var elem in Address) { if (elem != null) yield return new ElementValue("address", elem); }
                foreach (var elem in Photo) { if (elem != null) yield return new ElementValue("photo", elem); }
                if (Period != null) yield return new ElementValue("period", Period);
            }
        }

    }

}
