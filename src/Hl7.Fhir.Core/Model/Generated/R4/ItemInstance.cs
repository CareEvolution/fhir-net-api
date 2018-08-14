using System;
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
    /// A physical instance of an item
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "ItemInstance", IsResource=true)]
    [DataContract]
    public partial class ItemInstance : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ItemInstance; } }
        [NotMapped]
        public override string TypeName { get { return "ItemInstance"; } }
    
        
        /// <summary>
        /// The count of items
        /// </summary>
        [FhirElement("count", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Integer CountElement
        {
            get { return _CountElement; }
            set { _CountElement = value; OnPropertyChanged("CountElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Integer _CountElement;
        
        /// <summary>
        /// The count of items
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? Count
        {
            get { return CountElement != null ? CountElement.Value : null; }
            set
            {
                if (value == null)
                    CountElement = null;
                else
                    CountElement = new Hl7.Fhir.Model.R4.Integer(value);
                OnPropertyChanged("Count");
            }
        }
        
        /// <summary>
        /// The physical location of the item
        /// </summary>
        [FhirElement("location", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
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
        /// The patient that the item is affixed to
        /// </summary>
        [FhirElement("subject", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [References("Patient")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Subject;
        
        /// <summary>
        /// The manufacture or preparation date and time
        /// </summary>
        [FhirElement("manufactureDate", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime ManufactureDateElement
        {
            get { return _ManufactureDateElement; }
            set { _ManufactureDateElement = value; OnPropertyChanged("ManufactureDateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _ManufactureDateElement;
        
        /// <summary>
        /// The manufacture or preparation date and time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string ManufactureDate
        {
            get { return ManufactureDateElement != null ? ManufactureDateElement.Value : null; }
            set
            {
                if (value == null)
                    ManufactureDateElement = null;
                else
                    ManufactureDateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("ManufactureDate");
            }
        }
        
        /// <summary>
        /// The expiry or preparation date and time
        /// </summary>
        [FhirElement("expiryDate", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime ExpiryDateElement
        {
            get { return _ExpiryDateElement; }
            set { _ExpiryDateElement = value; OnPropertyChanged("ExpiryDateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _ExpiryDateElement;
        
        /// <summary>
        /// The expiry or preparation date and time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string ExpiryDate
        {
            get { return ExpiryDateElement != null ? ExpiryDateElement.Value : null; }
            set
            {
                if (value == null)
                    ExpiryDateElement = null;
                else
                    ExpiryDateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("ExpiryDate");
            }
        }
        
        /// <summary>
        /// The Software version associated with the device
        /// </summary>
        [FhirElement("currentSWVersion", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CurrentSWVersionElement
        {
            get { return _CurrentSWVersionElement; }
            set { _CurrentSWVersionElement = value; OnPropertyChanged("CurrentSWVersionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _CurrentSWVersionElement;
        
        /// <summary>
        /// The Software version associated with the device
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string CurrentSWVersion
        {
            get { return CurrentSWVersionElement != null ? CurrentSWVersionElement.Value : null; }
            set
            {
                if (value == null)
                    CurrentSWVersionElement = null;
                else
                    CurrentSWVersionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("CurrentSWVersion");
            }
        }
        
        /// <summary>
        /// The lot or batch number
        /// </summary>
        [FhirElement("lotNumber", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString LotNumberElement
        {
            get { return _LotNumberElement; }
            set { _LotNumberElement = value; OnPropertyChanged("LotNumberElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _LotNumberElement;
        
        /// <summary>
        /// The lot or batch number
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string LotNumber
        {
            get { return LotNumberElement != null ? LotNumberElement.Value : null; }
            set
            {
                if (value == null)
                    LotNumberElement = null;
                else
                    LotNumberElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("LotNumber");
            }
        }
        
        /// <summary>
        /// The serial number if available
        /// </summary>
        [FhirElement("serialNumber", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString SerialNumberElement
        {
            get { return _SerialNumberElement; }
            set { _SerialNumberElement = value; OnPropertyChanged("SerialNumberElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _SerialNumberElement;
        
        /// <summary>
        /// The serial number if available
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string SerialNumber
        {
            get { return SerialNumberElement != null ? SerialNumberElement.Value : null; }
            set
            {
                if (value == null)
                    SerialNumberElement = null;
                else
                    SerialNumberElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("SerialNumber");
            }
        }
        
        /// <summary>
        /// The machine-readable AIDC string in base64 encoding
        /// </summary>
        [FhirElement("carrierAIDC", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CarrierAIDCElement
        {
            get { return _CarrierAIDCElement; }
            set { _CarrierAIDCElement = value; OnPropertyChanged("CarrierAIDCElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _CarrierAIDCElement;
        
        /// <summary>
        /// The machine-readable AIDC string in base64 encoding
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string CarrierAIDC
        {
            get { return CarrierAIDCElement != null ? CarrierAIDCElement.Value : null; }
            set
            {
                if (value == null)
                    CarrierAIDCElement = null;
                else
                    CarrierAIDCElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("CarrierAIDC");
            }
        }
        
        /// <summary>
        /// The human-readable barcode string
        /// </summary>
        [FhirElement("carrierHRF", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString CarrierHRFElement
        {
            get { return _CarrierHRFElement; }
            set { _CarrierHRFElement = value; OnPropertyChanged("CarrierHRFElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _CarrierHRFElement;
        
        /// <summary>
        /// The human-readable barcode string
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string CarrierHRF
        {
            get { return CarrierHRFElement != null ? CarrierHRFElement.Value : null; }
            set
            {
                if (value == null)
                    CarrierHRFElement = null;
                else
                    CarrierHRFElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("CarrierHRF");
            }
        }
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ItemInstance;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(CountElement != null) dest.CountElement = (Hl7.Fhir.Model.R4.Integer)CountElement.DeepCopy();
                if(Location != null) dest.Location = (Hl7.Fhir.Model.R4.ResourceReference)Location.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.R4.ResourceReference)Subject.DeepCopy();
                if(ManufactureDateElement != null) dest.ManufactureDateElement = (Hl7.Fhir.Model.R4.FhirDateTime)ManufactureDateElement.DeepCopy();
                if(ExpiryDateElement != null) dest.ExpiryDateElement = (Hl7.Fhir.Model.R4.FhirDateTime)ExpiryDateElement.DeepCopy();
                if(CurrentSWVersionElement != null) dest.CurrentSWVersionElement = (Hl7.Fhir.Model.FhirString)CurrentSWVersionElement.DeepCopy();
                if(LotNumberElement != null) dest.LotNumberElement = (Hl7.Fhir.Model.FhirString)LotNumberElement.DeepCopy();
                if(SerialNumberElement != null) dest.SerialNumberElement = (Hl7.Fhir.Model.FhirString)SerialNumberElement.DeepCopy();
                if(CarrierAIDCElement != null) dest.CarrierAIDCElement = (Hl7.Fhir.Model.FhirString)CarrierAIDCElement.DeepCopy();
                if(CarrierHRFElement != null) dest.CarrierHRFElement = (Hl7.Fhir.Model.FhirString)CarrierHRFElement.DeepCopy();
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(CountElement, otherT.CountElement)) return false;
            if( !DeepComparable.Matches(Location, otherT.Location)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if( !DeepComparable.Matches(ExpiryDateElement, otherT.ExpiryDateElement)) return false;
            if( !DeepComparable.Matches(CurrentSWVersionElement, otherT.CurrentSWVersionElement)) return false;
            if( !DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if( !DeepComparable.Matches(SerialNumberElement, otherT.SerialNumberElement)) return false;
            if( !DeepComparable.Matches(CarrierAIDCElement, otherT.CarrierAIDCElement)) return false;
            if( !DeepComparable.Matches(CarrierHRFElement, otherT.CarrierHRFElement)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ItemInstance;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(CountElement, otherT.CountElement)) return false;
            if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if( !DeepComparable.IsExactly(ExpiryDateElement, otherT.ExpiryDateElement)) return false;
            if( !DeepComparable.IsExactly(CurrentSWVersionElement, otherT.CurrentSWVersionElement)) return false;
            if( !DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if( !DeepComparable.IsExactly(SerialNumberElement, otherT.SerialNumberElement)) return false;
            if( !DeepComparable.IsExactly(CarrierAIDCElement, otherT.CarrierAIDCElement)) return false;
            if( !DeepComparable.IsExactly(CarrierHRFElement, otherT.CarrierHRFElement)) return false;
        
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
                if (CountElement != null) yield return new ElementValue("count", false, CountElement);
                if (Location != null) yield return new ElementValue("location", false, Location);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (ManufactureDateElement != null) yield return new ElementValue("manufactureDate", false, ManufactureDateElement);
                if (ExpiryDateElement != null) yield return new ElementValue("expiryDate", false, ExpiryDateElement);
                if (CurrentSWVersionElement != null) yield return new ElementValue("currentSWVersion", false, CurrentSWVersionElement);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", false, LotNumberElement);
                if (SerialNumberElement != null) yield return new ElementValue("serialNumber", false, SerialNumberElement);
                if (CarrierAIDCElement != null) yield return new ElementValue("carrierAIDC", false, CarrierAIDCElement);
                if (CarrierHRFElement != null) yield return new ElementValue("carrierHRF", false, CarrierHRFElement);
            }
        }
    
    }

}
