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
    /// A postal address
    /// </summary>
    [FhirType("Address")]
    [DataContract]
    public partial class Address : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Address"; } }

        /// <summary>
        /// The use of an address<br/>
        /// <br/>
        /// The use of an address (home / work / etc.).
        /// (url: http://hl7.org/fhir/ValueSet/address-use)
        /// </summary>
        [FhirEnumeration("AddressUse")]
        public enum AddressUse
        {
            /// <summary>
            /// A communication address at a home.
            /// (system: http://hl7.org/fhir/address-use)
            /// </summary>
            [EnumLiteral("home", "http://hl7.org/fhir/address-use"), Description("Home")]
            Home,
            /// <summary>
            /// An office address. First choice for business related contacts during business hours.
            /// (system: http://hl7.org/fhir/address-use)
            /// </summary>
            [EnumLiteral("work", "http://hl7.org/fhir/address-use"), Description("Work")]
            Work,
            /// <summary>
            /// A temporary address. The period can provide more detailed information.
            /// (system: http://hl7.org/fhir/address-use)
            /// </summary>
            [EnumLiteral("temp", "http://hl7.org/fhir/address-use"), Description("Temporary")]
            Temp,
            /// <summary>
            /// This address is no longer in use (or was never correct, but retained for records).
            /// (system: http://hl7.org/fhir/address-use)
            /// </summary>
            [EnumLiteral("old", "http://hl7.org/fhir/address-use"), Description("Old / Incorrect")]
            Old,
        }

        /// <summary>
        /// The type of an address (physical / postal)<br/>
        /// <br/>
        /// The type of an address (physical / postal).
        /// (url: http://hl7.org/fhir/ValueSet/address-type)
        /// </summary>
        [FhirEnumeration("AddressType")]
        public enum AddressType
        {
            /// <summary>
            /// Mailing addresses - PO Boxes and care-of addresses.
            /// (system: http://hl7.org/fhir/address-type)
            /// </summary>
            [EnumLiteral("postal", "http://hl7.org/fhir/address-type"), Description("Postal")]
            Postal,
            /// <summary>
            /// A physical address that can be visited.
            /// (system: http://hl7.org/fhir/address-type)
            /// </summary>
            [EnumLiteral("physical", "http://hl7.org/fhir/address-type"), Description("Physical")]
            Physical,
            /// <summary>
            /// An address that is both physical and postal.
            /// (system: http://hl7.org/fhir/address-type)
            /// </summary>
            [EnumLiteral("both", "http://hl7.org/fhir/address-type"), Description("Postal & Physical")]
            Both,
        }


        /// <summary>
        /// home | work | temp | old - purpose of this address
        /// </summary>
        [FhirElement("use", InSummary=true, Order=30)]
        [DataMember]
        public Code<AddressUse> UseElement
        {
            get { return _useElement; }
            set { _useElement = value; OnPropertyChanged("UseElement"); }
        }

        private Code<AddressUse> _useElement;

        /// <summary>
        /// home | work | temp | old - purpose of this address
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AddressUse? Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if (value == null)
                    UseElement = null;
                else
                    UseElement = new Code<AddressUse>(value);
                OnPropertyChanged("Use");
            }
        }

        /// <summary>
        /// postal | physical | both
        /// </summary>
        [FhirElement("type", InSummary=true, Order=40)]
        [DataMember]
        public Code<AddressType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<AddressType> _typeElement;

        /// <summary>
        /// postal | physical | both
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AddressType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Code<AddressType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Text representation of the address
        /// </summary>
        [FhirElement("text", InSummary=true, Order=50)]
        [DataMember]
        public FhirString TextElement
        {
            get { return _textElement; }
            set { _textElement = value; OnPropertyChanged("TextElement"); }
        }

        private FhirString _textElement;

        /// <summary>
        /// Text representation of the address
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Text
        {
            get { return TextElement != null ? TextElement.Value : null; }
            set
            {
                if (value == null)
                    TextElement = null;
                else
                    TextElement = new FhirString(value);
                OnPropertyChanged("Text");
            }
        }

        /// <summary>
        /// Street name, number, direction &amp; P.O. Box etc.
        /// </summary>
        [FhirElement("line", InSummary=true, Order=60)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> LineElement
        {
            get { if (_lineElement==null) _lineElement = new List<FhirString>(); return _lineElement; }
            set { _lineElement = value; OnPropertyChanged("LineElement"); }
        }

        private List<FhirString> _lineElement;

        /// <summary>
        /// Street name, number, direction &amp; P.O. Box etc.
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Line
        {
            get { return LineElement != null ? LineElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    LineElement = null;
                else
                    LineElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Line");
            }
        }

        /// <summary>
        /// Name of city, town etc.
        /// </summary>
        [FhirElement("city", InSummary=true, Order=70)]
        [DataMember]
        public FhirString CityElement
        {
            get { return _cityElement; }
            set { _cityElement = value; OnPropertyChanged("CityElement"); }
        }

        private FhirString _cityElement;

        /// <summary>
        /// Name of city, town etc.
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string City
        {
            get { return CityElement != null ? CityElement.Value : null; }
            set
            {
                if (value == null)
                    CityElement = null;
                else
                    CityElement = new FhirString(value);
                OnPropertyChanged("City");
            }
        }

        /// <summary>
        /// District name (aka county)
        /// </summary>
        [FhirElement("district", InSummary=true, Order=80)]
        [DataMember]
        public FhirString DistrictElement
        {
            get { return _districtElement; }
            set { _districtElement = value; OnPropertyChanged("DistrictElement"); }
        }

        private FhirString _districtElement;

        /// <summary>
        /// District name (aka county)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string District
        {
            get { return DistrictElement != null ? DistrictElement.Value : null; }
            set
            {
                if (value == null)
                    DistrictElement = null;
                else
                    DistrictElement = new FhirString(value);
                OnPropertyChanged("District");
            }
        }

        /// <summary>
        /// Sub-unit of country (abbreviations ok)
        /// </summary>
        [FhirElement("state", InSummary=true, Order=90)]
        [DataMember]
        public FhirString StateElement
        {
            get { return _stateElement; }
            set { _stateElement = value; OnPropertyChanged("StateElement"); }
        }

        private FhirString _stateElement;

        /// <summary>
        /// Sub-unit of country (abbreviations ok)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string State
        {
            get { return StateElement != null ? StateElement.Value : null; }
            set
            {
                if (value == null)
                    StateElement = null;
                else
                    StateElement = new FhirString(value);
                OnPropertyChanged("State");
            }
        }

        /// <summary>
        /// Postal code for area
        /// </summary>
        [FhirElement("postalCode", InSummary=true, Order=100)]
        [DataMember]
        public FhirString PostalCodeElement
        {
            get { return _postalCodeElement; }
            set { _postalCodeElement = value; OnPropertyChanged("PostalCodeElement"); }
        }

        private FhirString _postalCodeElement;

        /// <summary>
        /// Postal code for area
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PostalCode
        {
            get { return PostalCodeElement != null ? PostalCodeElement.Value : null; }
            set
            {
                if (value == null)
                    PostalCodeElement = null;
                else
                    PostalCodeElement = new FhirString(value);
                OnPropertyChanged("PostalCode");
            }
        }

        /// <summary>
        /// Country (can be ISO 3166 3 letter code)
        /// </summary>
        [FhirElement("country", InSummary=true, Order=110)]
        [DataMember]
        public FhirString CountryElement
        {
            get { return _countryElement; }
            set { _countryElement = value; OnPropertyChanged("CountryElement"); }
        }

        private FhirString _countryElement;

        /// <summary>
        /// Country (can be ISO 3166 3 letter code)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Country
        {
            get { return CountryElement != null ? CountryElement.Value : null; }
            set
            {
                if (value == null)
                    CountryElement = null;
                else
                    CountryElement = new FhirString(value);
                OnPropertyChanged("Country");
            }
        }

        /// <summary>
        /// Time period when address was/is in use
        /// </summary>
        [FhirElement("period", InSummary=true, Order=120)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Address;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UseElement != null) dest.UseElement = (Code<AddressUse>)UseElement.DeepCopy();
                if (TypeElement != null) dest.TypeElement = (Code<AddressType>)TypeElement.DeepCopy();
                if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                if (LineElement != null) dest.LineElement = new List<FhirString>(LineElement.DeepCopy());
                if (CityElement != null) dest.CityElement = (FhirString)CityElement.DeepCopy();
                if (DistrictElement != null) dest.DistrictElement = (FhirString)DistrictElement.DeepCopy();
                if (StateElement != null) dest.StateElement = (FhirString)StateElement.DeepCopy();
                if (PostalCodeElement != null) dest.PostalCodeElement = (FhirString)PostalCodeElement.DeepCopy();
                if (CountryElement != null) dest.CountryElement = (FhirString)CountryElement.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Address());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Address;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
            if ( !DeepComparable.Matches(LineElement, otherT.LineElement)) return false;
            if (!DeepComparable.Matches(CityElement, otherT.CityElement)) return false;
            if (!DeepComparable.Matches(DistrictElement, otherT.DistrictElement)) return false;
            if (!DeepComparable.Matches(StateElement, otherT.StateElement)) return false;
            if (!DeepComparable.Matches(PostalCodeElement, otherT.PostalCodeElement)) return false;
            if (!DeepComparable.Matches(CountryElement, otherT.CountryElement)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Address;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
            if (!DeepComparable.IsExactly(LineElement, otherT.LineElement)) return false;
            if (!DeepComparable.IsExactly(CityElement, otherT.CityElement)) return false;
            if (!DeepComparable.IsExactly(DistrictElement, otherT.DistrictElement)) return false;
            if (!DeepComparable.IsExactly(StateElement, otherT.StateElement)) return false;
            if (!DeepComparable.IsExactly(PostalCodeElement, otherT.PostalCodeElement)) return false;
            if (!DeepComparable.IsExactly(CountryElement, otherT.CountryElement)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UseElement != null) yield return UseElement;
                if (TypeElement != null) yield return TypeElement;
                if (TextElement != null) yield return TextElement;
                foreach (var elem in LineElement) { if (elem != null) yield return elem; }
                if (CityElement != null) yield return CityElement;
                if (DistrictElement != null) yield return DistrictElement;
                if (StateElement != null) yield return StateElement;
                if (PostalCodeElement != null) yield return PostalCodeElement;
                if (CountryElement != null) yield return CountryElement;
                if (Period != null) yield return Period;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UseElement != null) yield return new ElementValue("use", UseElement);
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (TextElement != null) yield return new ElementValue("text", TextElement);
                foreach (var elem in LineElement) { if (elem != null) yield return new ElementValue("line", elem); }
                if (CityElement != null) yield return new ElementValue("city", CityElement);
                if (DistrictElement != null) yield return new ElementValue("district", DistrictElement);
                if (StateElement != null) yield return new ElementValue("state", StateElement);
                if (PostalCodeElement != null) yield return new ElementValue("postalCode", PostalCodeElement);
                if (CountryElement != null) yield return new ElementValue("country", CountryElement);
                if (Period != null) yield return new ElementValue("period", Period);
            }
        }

    }

}
