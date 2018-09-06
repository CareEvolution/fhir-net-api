using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A person with a  formal responsibility in the provisioning of healthcare or related services
    /// </summary>
    [FhirType("Practitioner", IsResource=true)]
    [DataContract]
    public partial class Practitioner : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Practitioner; } }
        [NotMapped]
        public override string TypeName { get { return "Practitioner"; } }


        [FhirType("QualificationComponent")]
        [DataContract]
        public partial class QualificationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "QualificationComponent"; } }

            /// <summary>
            /// An identifier for this qualification for the practitioner
            /// </summary>
            [FhirElement("identifier", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Identifier> Identifier
            {
                get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private List<Identifier> _identifier;

            /// <summary>
            /// Coded representation of the qualification
            /// </summary>
            [FhirElement("code", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Period during which the qualification is valid
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
            /// Organization that regulates and issues the qualification
            /// </summary>
            [FhirElement("issuer", Order=70)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Issuer
            {
                get { return _issuer; }
                set { _issuer = value; OnPropertyChanged("Issuer"); }
            }

            private ResourceReference _issuer;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as QualificationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (Issuer != null) dest.Issuer = (ResourceReference)Issuer.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new QualificationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as QualificationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if (!DeepComparable.Matches(Issuer, otherT.Issuer)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as QualificationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(Issuer, otherT.Issuer)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                    if (Code != null) yield return Code;
                    if (Period != null) yield return Period;
                    if (Issuer != null) yield return Issuer;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Period != null) yield return new ElementValue("period", Period);
                    if (Issuer != null) yield return new ElementValue("issuer", Issuer);
                }
            }


        }


        /// <summary>
        /// An identifier for the person as this agent
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
        /// Whether this practitioner's record is in active use
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
        /// Whether this practitioner's record is in active use
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
        /// The name(s) associated with the practitioner
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
        /// A contact detail for the practitioner (that apply to all roles)
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
        /// Address(es) of the practitioner that are not role specific (typically home address)
        /// </summary>
        [FhirElement("address", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Address> Address
        {
            get { if (_address==null) _address = new List<Address>(); return _address; }
            set { _address = value; OnPropertyChanged("Address"); }
        }

        private List<Address> _address;

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
        /// The date  on which the practitioner was born
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
        /// The date  on which the practitioner was born
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
        /// Image of the person
        /// </summary>
        [FhirElement("photo", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Attachment> Photo
        {
            get { if (_photo==null) _photo = new List<Attachment>(); return _photo; }
            set { _photo = value; OnPropertyChanged("Photo"); }
        }

        private List<Attachment> _photo;

        /// <summary>
        /// Certification, licenses, or training pertaining to the provision of care
        /// </summary>
        [FhirElement("qualification", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<QualificationComponent> Qualification
        {
            get { if (_qualification==null) _qualification = new List<QualificationComponent>(); return _qualification; }
            set { _qualification = value; OnPropertyChanged("Qualification"); }
        }

        private List<QualificationComponent> _qualification;

        /// <summary>
        /// A language the practitioner can use in patient communication
        /// </summary>
        [FhirElement("communication", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Communication
        {
            get { if (_communication==null) _communication = new List<CodeableConcept>(); return _communication; }
            set { _communication = value; OnPropertyChanged("Communication"); }
        }

        private List<CodeableConcept> _communication;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Practitioner;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (Name != null) dest.Name = new List<HumanName>(Name.DeepCopy());
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (Address != null) dest.Address = new List<Address>(Address.DeepCopy());
                if (GenderElement != null) dest.GenderElement = (Code<AdministrativeGender>)GenderElement.DeepCopy();
                if (BirthDateElement != null) dest.BirthDateElement = (Date)BirthDateElement.DeepCopy();
                if (Photo != null) dest.Photo = new List<Attachment>(Photo.DeepCopy());
                if (Qualification != null) dest.Qualification = new List<QualificationComponent>(Qualification.DeepCopy());
                if (Communication != null) dest.Communication = new List<CodeableConcept>(Communication.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Practitioner());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Practitioner;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if ( !DeepComparable.Matches(Name, otherT.Name)) return false;
            if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if ( !DeepComparable.Matches(Address, otherT.Address)) return false;
            if (!DeepComparable.Matches(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.Matches(BirthDateElement, otherT.BirthDateElement)) return false;
            if ( !DeepComparable.Matches(Photo, otherT.Photo)) return false;
            if ( !DeepComparable.Matches(Qualification, otherT.Qualification)) return false;
            if ( !DeepComparable.Matches(Communication, otherT.Communication)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Practitioner;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(Name, otherT.Name)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(Address, otherT.Address)) return false;
            if (!DeepComparable.IsExactly(GenderElement, otherT.GenderElement)) return false;
            if (!DeepComparable.IsExactly(BirthDateElement, otherT.BirthDateElement)) return false;
            if (!DeepComparable.IsExactly(Photo, otherT.Photo)) return false;
            if (!DeepComparable.IsExactly(Qualification, otherT.Qualification)) return false;
            if (!DeepComparable.IsExactly(Communication, otherT.Communication)) return false;

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
                foreach (var elem in Address) { if (elem != null) yield return elem; }
                if (GenderElement != null) yield return GenderElement;
                if (BirthDateElement != null) yield return BirthDateElement;
                foreach (var elem in Photo) { if (elem != null) yield return elem; }
                foreach (var elem in Qualification) { if (elem != null) yield return elem; }
                foreach (var elem in Communication) { if (elem != null) yield return elem; }
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
                foreach (var elem in Address) { if (elem != null) yield return new ElementValue("address", elem); }
                if (GenderElement != null) yield return new ElementValue("gender", GenderElement);
                if (BirthDateElement != null) yield return new ElementValue("birthDate", BirthDateElement);
                foreach (var elem in Photo) { if (elem != null) yield return new ElementValue("photo", elem); }
                foreach (var elem in Qualification) { if (elem != null) yield return new ElementValue("qualification", elem); }
                foreach (var elem in Communication) { if (elem != null) yield return new ElementValue("communication", elem); }
            }
        }

    }

}
