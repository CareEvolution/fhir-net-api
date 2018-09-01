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
    /// A physical instance of an item
    /// </summary>
    [FhirType("ItemInstance", IsResource=true)]
    [DataContract]
    public partial class ItemInstance : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ItemInstance; } }
        [NotMapped]
        public override string TypeName { get { return "ItemInstance"; } }


        /// <summary>
        /// The count of items
        /// </summary>
        [FhirElement("count", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Integer CountElement
        {
            get { return _countElement; }
            set { _countElement = value; OnPropertyChanged("CountElement"); }
        }

        private Integer _countElement;

        /// <summary>
        /// The count of items
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Count
        {
            get { return CountElement != null ? CountElement.Value : null; }
            set
            {
                if (value == null)
                    CountElement = null;
                else
                    CountElement = new Integer(value);
                OnPropertyChanged("Count");
            }
        }

        /// <summary>
        /// The physical location of the item
        /// </summary>
        [FhirElement("location", InSummary=true, Order=100)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// The patient that the item is affixed to
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=110)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// The manufacture or preparation date and time
        /// </summary>
        [FhirElement("manufactureDate", InSummary=true, Order=120)]
        [DataMember]
        public FhirDateTime ManufactureDateElement
        {
            get { return _manufactureDateElement; }
            set { _manufactureDateElement = value; OnPropertyChanged("ManufactureDateElement"); }
        }

        private FhirDateTime _manufactureDateElement;

        /// <summary>
        /// The manufacture or preparation date and time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ManufactureDate
        {
            get { return ManufactureDateElement != null ? ManufactureDateElement.Value : null; }
            set
            {
                if (value == null)
                    ManufactureDateElement = null;
                else
                    ManufactureDateElement = new FhirDateTime(value);
                OnPropertyChanged("ManufactureDate");
            }
        }

        /// <summary>
        /// The expiry or preparation date and time
        /// </summary>
        [FhirElement("expiryDate", InSummary=true, Order=130)]
        [DataMember]
        public FhirDateTime ExpiryDateElement
        {
            get { return _expiryDateElement; }
            set { _expiryDateElement = value; OnPropertyChanged("ExpiryDateElement"); }
        }

        private FhirDateTime _expiryDateElement;

        /// <summary>
        /// The expiry or preparation date and time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ExpiryDate
        {
            get { return ExpiryDateElement != null ? ExpiryDateElement.Value : null; }
            set
            {
                if (value == null)
                    ExpiryDateElement = null;
                else
                    ExpiryDateElement = new FhirDateTime(value);
                OnPropertyChanged("ExpiryDate");
            }
        }

        /// <summary>
        /// The Software version associated with the device
        /// </summary>
        [FhirElement("currentSWVersion", InSummary=true, Order=140)]
        [DataMember]
        public FhirString CurrentSWVersionElement
        {
            get { return _currentSWVersionElement; }
            set { _currentSWVersionElement = value; OnPropertyChanged("CurrentSWVersionElement"); }
        }

        private FhirString _currentSWVersionElement;

        /// <summary>
        /// The Software version associated with the device
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string CurrentSWVersion
        {
            get { return CurrentSWVersionElement != null ? CurrentSWVersionElement.Value : null; }
            set
            {
                if (value == null)
                    CurrentSWVersionElement = null;
                else
                    CurrentSWVersionElement = new FhirString(value);
                OnPropertyChanged("CurrentSWVersion");
            }
        }

        /// <summary>
        /// The lot or batch number
        /// </summary>
        [FhirElement("lotNumber", InSummary=true, Order=150)]
        [DataMember]
        public FhirString LotNumberElement
        {
            get { return _lotNumberElement; }
            set { _lotNumberElement = value; OnPropertyChanged("LotNumberElement"); }
        }

        private FhirString _lotNumberElement;

        /// <summary>
        /// The lot or batch number
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string LotNumber
        {
            get { return LotNumberElement != null ? LotNumberElement.Value : null; }
            set
            {
                if (value == null)
                    LotNumberElement = null;
                else
                    LotNumberElement = new FhirString(value);
                OnPropertyChanged("LotNumber");
            }
        }

        /// <summary>
        /// The serial number if available
        /// </summary>
        [FhirElement("serialNumber", InSummary=true, Order=160)]
        [DataMember]
        public FhirString SerialNumberElement
        {
            get { return _serialNumberElement; }
            set { _serialNumberElement = value; OnPropertyChanged("SerialNumberElement"); }
        }

        private FhirString _serialNumberElement;

        /// <summary>
        /// The serial number if available
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string SerialNumber
        {
            get { return SerialNumberElement != null ? SerialNumberElement.Value : null; }
            set
            {
                if (value == null)
                    SerialNumberElement = null;
                else
                    SerialNumberElement = new FhirString(value);
                OnPropertyChanged("SerialNumber");
            }
        }

        /// <summary>
        /// The machine-readable AIDC string in base64 encoding
        /// </summary>
        [FhirElement("carrierAIDC", InSummary=true, Order=170)]
        [DataMember]
        public FhirString CarrierAIDCElement
        {
            get { return _carrierAIDCElement; }
            set { _carrierAIDCElement = value; OnPropertyChanged("CarrierAIDCElement"); }
        }

        private FhirString _carrierAIDCElement;

        /// <summary>
        /// The machine-readable AIDC string in base64 encoding
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string CarrierAIDC
        {
            get { return CarrierAIDCElement != null ? CarrierAIDCElement.Value : null; }
            set
            {
                if (value == null)
                    CarrierAIDCElement = null;
                else
                    CarrierAIDCElement = new FhirString(value);
                OnPropertyChanged("CarrierAIDC");
            }
        }

        /// <summary>
        /// The human-readable barcode string
        /// </summary>
        [FhirElement("carrierHRF", InSummary=true, Order=180)]
        [DataMember]
        public FhirString CarrierHRFElement
        {
            get { return _carrierHRFElement; }
            set { _carrierHRFElement = value; OnPropertyChanged("CarrierHRFElement"); }
        }

        private FhirString _carrierHRFElement;

        /// <summary>
        /// The human-readable barcode string
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string CarrierHRF
        {
            get { return CarrierHRFElement != null ? CarrierHRFElement.Value : null; }
            set
            {
                if (value == null)
                    CarrierHRFElement = null;
                else
                    CarrierHRFElement = new FhirString(value);
                OnPropertyChanged("CarrierHRF");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ItemInstance;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (CountElement != null) dest.CountElement = (Integer)CountElement.DeepCopy();
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (ManufactureDateElement != null) dest.ManufactureDateElement = (FhirDateTime)ManufactureDateElement.DeepCopy();
                if (ExpiryDateElement != null) dest.ExpiryDateElement = (FhirDateTime)ExpiryDateElement.DeepCopy();
                if (CurrentSWVersionElement != null) dest.CurrentSWVersionElement = (FhirString)CurrentSWVersionElement.DeepCopy();
                if (LotNumberElement != null) dest.LotNumberElement = (FhirString)LotNumberElement.DeepCopy();
                if (SerialNumberElement != null) dest.SerialNumberElement = (FhirString)SerialNumberElement.DeepCopy();
                if (CarrierAIDCElement != null) dest.CarrierAIDCElement = (FhirString)CarrierAIDCElement.DeepCopy();
                if (CarrierHRFElement != null) dest.CarrierHRFElement = (FhirString)CarrierHRFElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ItemInstance());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ItemInstance;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(CountElement, otherT.CountElement)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if (!DeepComparable.Matches(ExpiryDateElement, otherT.ExpiryDateElement)) return false;
            if (!DeepComparable.Matches(CurrentSWVersionElement, otherT.CurrentSWVersionElement)) return false;
            if (!DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.Matches(SerialNumberElement, otherT.SerialNumberElement)) return false;
            if (!DeepComparable.Matches(CarrierAIDCElement, otherT.CarrierAIDCElement)) return false;
            if (!DeepComparable.Matches(CarrierHRFElement, otherT.CarrierHRFElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ItemInstance;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(CountElement, otherT.CountElement)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if (!DeepComparable.IsExactly(ExpiryDateElement, otherT.ExpiryDateElement)) return false;
            if (!DeepComparable.IsExactly(CurrentSWVersionElement, otherT.CurrentSWVersionElement)) return false;
            if (!DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.IsExactly(SerialNumberElement, otherT.SerialNumberElement)) return false;
            if (!DeepComparable.IsExactly(CarrierAIDCElement, otherT.CarrierAIDCElement)) return false;
            if (!DeepComparable.IsExactly(CarrierHRFElement, otherT.CarrierHRFElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (CountElement != null) yield return CountElement;
                if (Location != null) yield return Location;
                if (Subject != null) yield return Subject;
                if (ManufactureDateElement != null) yield return ManufactureDateElement;
                if (ExpiryDateElement != null) yield return ExpiryDateElement;
                if (CurrentSWVersionElement != null) yield return CurrentSWVersionElement;
                if (LotNumberElement != null) yield return LotNumberElement;
                if (SerialNumberElement != null) yield return SerialNumberElement;
                if (CarrierAIDCElement != null) yield return CarrierAIDCElement;
                if (CarrierHRFElement != null) yield return CarrierHRFElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (CountElement != null) yield return new ElementValue("count", CountElement);
                if (Location != null) yield return new ElementValue("location", Location);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (ManufactureDateElement != null) yield return new ElementValue("manufactureDate", ManufactureDateElement);
                if (ExpiryDateElement != null) yield return new ElementValue("expiryDate", ExpiryDateElement);
                if (CurrentSWVersionElement != null) yield return new ElementValue("currentSWVersion", CurrentSWVersionElement);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
                if (SerialNumberElement != null) yield return new ElementValue("serialNumber", SerialNumberElement);
                if (CarrierAIDCElement != null) yield return new ElementValue("carrierAIDC", CarrierAIDCElement);
                if (CarrierHRFElement != null) yield return new ElementValue("carrierHRF", CarrierHRFElement);
            }
        }

    }

}
