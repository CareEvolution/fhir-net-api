using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Item used in healthcare
    /// </summary>
    [FhirType("Device", IsResource=true)]
    [DataContract]
    public partial class Device : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Device; } }
        [NotMapped]
        public override string TypeName { get { return "Device"; } }

        /// <summary>
        /// Codes to identify how UDI data was entered
        /// (url: http://hl7.org/fhir/ValueSet/udi-entry-type)
        /// </summary>
        [FhirEnumeration("UDIEntryType")]
        public enum UDIEntryType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/udi-entry-type)
            /// </summary>
            [EnumLiteral("barcode", "http://hl7.org/fhir/udi-entry-type"), Description("BarCode")]
            Barcode,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/udi-entry-type)
            /// </summary>
            [EnumLiteral("rfid", "http://hl7.org/fhir/udi-entry-type"), Description("RFID")]
            Rfid,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/udi-entry-type)
            /// </summary>
            [EnumLiteral("manual", "http://hl7.org/fhir/udi-entry-type"), Description("Manual")]
            Manual,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/udi-entry-type)
            /// </summary>
            [EnumLiteral("card", "http://hl7.org/fhir/udi-entry-type"), Description("Card")]
            Card,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/udi-entry-type)
            /// </summary>
            [EnumLiteral("self-reported", "http://hl7.org/fhir/udi-entry-type"), Description("Self Reported")]
            SelfReported,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/udi-entry-type)
            /// </summary>
            [EnumLiteral("unknown", "http://hl7.org/fhir/udi-entry-type"), Description("Unknown")]
            Unknown,
        }

        /// <summary>
        /// The availability status of the device.
        /// (url: http://hl7.org/fhir/ValueSet/device-status)
        /// </summary>
        [FhirEnumeration("FHIRDeviceStatus")]
        public enum FHIRDeviceStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/device-status"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-status)
            /// </summary>
            [EnumLiteral("inactive", "http://hl7.org/fhir/device-status"), Description("Inactive")]
            Inactive,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/device-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-status)
            /// </summary>
            [EnumLiteral("unknown", "http://hl7.org/fhir/device-status"), Description("Unknown")]
            Unknown,
        }


        [FhirType("UdiComponent")]
        [DataContract]
        public partial class UdiComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "UdiComponent"; } }

            /// <summary>
            /// Mandatory fixed portion of UDI
            /// </summary>
            [FhirElement("deviceIdentifier", InSummary=true, Order=40)]
            [DataMember]
            public FhirString DeviceIdentifierElement
            {
                get { return _deviceIdentifierElement; }
                set { _deviceIdentifierElement = value; OnPropertyChanged("DeviceIdentifierElement"); }
            }

            private FhirString _deviceIdentifierElement;

            /// <summary>
            /// Mandatory fixed portion of UDI
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string DeviceIdentifier
            {
                get { return DeviceIdentifierElement != null ? DeviceIdentifierElement.Value : null; }
                set
                {
                    if (value == null)
                        DeviceIdentifierElement = null;
                    else
                        DeviceIdentifierElement = new FhirString(value);
                    OnPropertyChanged("DeviceIdentifier");
                }
            }

            /// <summary>
            /// Device Name as appears on UDI label
            /// </summary>
            [FhirElement("name", InSummary=true, Order=50)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Device Name as appears on UDI label
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
            /// Regional UDI authority
            /// </summary>
            [FhirElement("jurisdiction", Order=60)]
            [DataMember]
            public FhirUri JurisdictionElement
            {
                get { return _jurisdictionElement; }
                set { _jurisdictionElement = value; OnPropertyChanged("JurisdictionElement"); }
            }

            private FhirUri _jurisdictionElement;

            /// <summary>
            /// Regional UDI authority
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Jurisdiction
            {
                get { return JurisdictionElement != null ? JurisdictionElement.Value : null; }
                set
                {
                    if (value == null)
                        JurisdictionElement = null;
                    else
                        JurisdictionElement = new FhirUri(value);
                    OnPropertyChanged("Jurisdiction");
                }
            }

            /// <summary>
            /// UDI Human Readable Barcode String
            /// </summary>
            [FhirElement("carrierHRF", InSummary=true, Order=70)]
            [DataMember]
            public FhirString CarrierHRFElement
            {
                get { return _carrierHRFElement; }
                set { _carrierHRFElement = value; OnPropertyChanged("CarrierHRFElement"); }
            }

            private FhirString _carrierHRFElement;

            /// <summary>
            /// UDI Human Readable Barcode String
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

            /// <summary>
            /// UDI Machine Readable Barcode String
            /// </summary>
            [FhirElement("carrierAIDC", InSummary=true, Order=80)]
            [DataMember]
            public Base64Binary CarrierAIDCElement
            {
                get { return _carrierAIDCElement; }
                set { _carrierAIDCElement = value; OnPropertyChanged("CarrierAIDCElement"); }
            }

            private Base64Binary _carrierAIDCElement;

            /// <summary>
            /// UDI Machine Readable Barcode String
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public byte[] CarrierAIDC
            {
                get { return CarrierAIDCElement != null ? CarrierAIDCElement.Value : null; }
                set
                {
                    if (value == null)
                        CarrierAIDCElement = null;
                    else
                        CarrierAIDCElement = new Base64Binary(value);
                    OnPropertyChanged("CarrierAIDC");
                }
            }

            /// <summary>
            /// UDI Issuing Organization
            /// </summary>
            [FhirElement("issuer", Order=90)]
            [DataMember]
            public FhirUri IssuerElement
            {
                get { return _issuerElement; }
                set { _issuerElement = value; OnPropertyChanged("IssuerElement"); }
            }

            private FhirUri _issuerElement;

            /// <summary>
            /// UDI Issuing Organization
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Issuer
            {
                get { return IssuerElement != null ? IssuerElement.Value : null; }
                set
                {
                    if (value == null)
                        IssuerElement = null;
                    else
                        IssuerElement = new FhirUri(value);
                    OnPropertyChanged("Issuer");
                }
            }

            /// <summary>
            /// barcode | rfid | manual +
            /// </summary>
            [FhirElement("entryType", Order=100)]
            [DataMember]
            public Code<UDIEntryType> EntryTypeElement
            {
                get { return _entryTypeElement; }
                set { _entryTypeElement = value; OnPropertyChanged("EntryTypeElement"); }
            }

            private Code<UDIEntryType> _entryTypeElement;

            /// <summary>
            /// barcode | rfid | manual +
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public UDIEntryType? EntryType
            {
                get { return EntryTypeElement != null ? EntryTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        EntryTypeElement = null;
                    else
                        EntryTypeElement = new Code<UDIEntryType>(value);
                    OnPropertyChanged("EntryType");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as UdiComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DeviceIdentifierElement != null) dest.DeviceIdentifierElement = (FhirString)DeviceIdentifierElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (JurisdictionElement != null) dest.JurisdictionElement = (FhirUri)JurisdictionElement.DeepCopy();
                    if (CarrierHRFElement != null) dest.CarrierHRFElement = (FhirString)CarrierHRFElement.DeepCopy();
                    if (CarrierAIDCElement != null) dest.CarrierAIDCElement = (Base64Binary)CarrierAIDCElement.DeepCopy();
                    if (IssuerElement != null) dest.IssuerElement = (FhirUri)IssuerElement.DeepCopy();
                    if (EntryTypeElement != null) dest.EntryTypeElement = (Code<UDIEntryType>)EntryTypeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new UdiComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as UdiComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DeviceIdentifierElement, otherT.DeviceIdentifierElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(JurisdictionElement, otherT.JurisdictionElement)) return false;
                if (!DeepComparable.Matches(CarrierHRFElement, otherT.CarrierHRFElement)) return false;
                if (!DeepComparable.Matches(CarrierAIDCElement, otherT.CarrierAIDCElement)) return false;
                if (!DeepComparable.Matches(IssuerElement, otherT.IssuerElement)) return false;
                if (!DeepComparable.Matches(EntryTypeElement, otherT.EntryTypeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as UdiComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DeviceIdentifierElement, otherT.DeviceIdentifierElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(JurisdictionElement, otherT.JurisdictionElement)) return false;
                if (!DeepComparable.IsExactly(CarrierHRFElement, otherT.CarrierHRFElement)) return false;
                if (!DeepComparable.IsExactly(CarrierAIDCElement, otherT.CarrierAIDCElement)) return false;
                if (!DeepComparable.IsExactly(IssuerElement, otherT.IssuerElement)) return false;
                if (!DeepComparable.IsExactly(EntryTypeElement, otherT.EntryTypeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DeviceIdentifierElement != null) yield return DeviceIdentifierElement;
                    if (NameElement != null) yield return NameElement;
                    if (JurisdictionElement != null) yield return JurisdictionElement;
                    if (CarrierHRFElement != null) yield return CarrierHRFElement;
                    if (CarrierAIDCElement != null) yield return CarrierAIDCElement;
                    if (IssuerElement != null) yield return IssuerElement;
                    if (EntryTypeElement != null) yield return EntryTypeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DeviceIdentifierElement != null) yield return new ElementValue("deviceIdentifier", DeviceIdentifierElement);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (JurisdictionElement != null) yield return new ElementValue("jurisdiction", JurisdictionElement);
                    if (CarrierHRFElement != null) yield return new ElementValue("carrierHRF", CarrierHRFElement);
                    if (CarrierAIDCElement != null) yield return new ElementValue("carrierAIDC", CarrierAIDCElement);
                    if (IssuerElement != null) yield return new ElementValue("issuer", IssuerElement);
                    if (EntryTypeElement != null) yield return new ElementValue("entryType", EntryTypeElement);
                }
            }


        }


        /// <summary>
        /// Instance identifier
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
        /// Unique Device Identifier (UDI) Barcode string
        /// </summary>
        [FhirElement("udi", InSummary=true, Order=100)]
        [DataMember]
        public UdiComponent Udi
        {
            get { return _udi; }
            set { _udi = value; OnPropertyChanged("Udi"); }
        }

        private UdiComponent _udi;

        /// <summary>
        /// active | inactive | entered-in-error | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [DataMember]
        public Code<FHIRDeviceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<FHIRDeviceStatus> _statusElement;

        /// <summary>
        /// active | inactive | entered-in-error | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public FHIRDeviceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<FHIRDeviceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// What kind of device this is
        /// </summary>
        [FhirElement("type", Order=120)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Lot number of manufacture
        /// </summary>
        [FhirElement("lotNumber", Order=130)]
        [DataMember]
        public FhirString LotNumberElement
        {
            get { return _lotNumberElement; }
            set { _lotNumberElement = value; OnPropertyChanged("LotNumberElement"); }
        }

        private FhirString _lotNumberElement;

        /// <summary>
        /// Lot number of manufacture
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
        /// Name of device manufacturer
        /// </summary>
        [FhirElement("manufacturer", Order=140)]
        [DataMember]
        public FhirString ManufacturerElement
        {
            get { return _manufacturerElement; }
            set { _manufacturerElement = value; OnPropertyChanged("ManufacturerElement"); }
        }

        private FhirString _manufacturerElement;

        /// <summary>
        /// Name of device manufacturer
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Manufacturer
        {
            get { return ManufacturerElement != null ? ManufacturerElement.Value : null; }
            set
            {
                if (value == null)
                    ManufacturerElement = null;
                else
                    ManufacturerElement = new FhirString(value);
                OnPropertyChanged("Manufacturer");
            }
        }

        /// <summary>
        /// Date when the device was made
        /// </summary>
        [FhirElement("manufactureDate", Order=150)]
        [DataMember]
        public FhirDateTime ManufactureDateElement
        {
            get { return _manufactureDateElement; }
            set { _manufactureDateElement = value; OnPropertyChanged("ManufactureDateElement"); }
        }

        private FhirDateTime _manufactureDateElement;

        /// <summary>
        /// Date when the device was made
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
        /// Date and time of expiry of this device (if applicable)
        /// </summary>
        [FhirElement("expirationDate", Order=160)]
        [DataMember]
        public FhirDateTime ExpirationDateElement
        {
            get { return _expirationDateElement; }
            set { _expirationDateElement = value; OnPropertyChanged("ExpirationDateElement"); }
        }

        private FhirDateTime _expirationDateElement;

        /// <summary>
        /// Date and time of expiry of this device (if applicable)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ExpirationDate
        {
            get { return ExpirationDateElement != null ? ExpirationDateElement.Value : null; }
            set
            {
                if (value == null)
                    ExpirationDateElement = null;
                else
                    ExpirationDateElement = new FhirDateTime(value);
                OnPropertyChanged("ExpirationDate");
            }
        }

        /// <summary>
        /// Model id assigned by the manufacturer
        /// </summary>
        [FhirElement("model", Order=170)]
        [DataMember]
        public FhirString ModelElement
        {
            get { return _modelElement; }
            set { _modelElement = value; OnPropertyChanged("ModelElement"); }
        }

        private FhirString _modelElement;

        /// <summary>
        /// Model id assigned by the manufacturer
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Model
        {
            get { return ModelElement != null ? ModelElement.Value : null; }
            set
            {
                if (value == null)
                    ModelElement = null;
                else
                    ModelElement = new FhirString(value);
                OnPropertyChanged("Model");
            }
        }

        /// <summary>
        /// Version number (i.e. software)
        /// </summary>
        [FhirElement("version", Order=180)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Version number (i.e. software)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new FhirString(value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Patient to whom Device is affixed
        /// </summary>
        [FhirElement("patient", Order=190)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Organization responsible for device
        /// </summary>
        [FhirElement("owner", Order=200)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Owner
        {
            get { return _owner; }
            set { _owner = value; OnPropertyChanged("Owner"); }
        }

        private ResourceReference _owner;

        /// <summary>
        /// Details for human/organization for support
        /// </summary>
        [FhirElement("contact", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Contact
        {
            get { if (_contact==null) _contact = new List<ContactPoint>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactPoint> _contact;

        /// <summary>
        /// Where the resource is found
        /// </summary>
        [FhirElement("location", Order=220)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Network address to contact device
        /// </summary>
        [FhirElement("url", Order=230)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Network address to contact device
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                    UrlElement = null;
                else
                    UrlElement = new FhirUri(value);
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        /// Device notes and comments
        /// </summary>
        [FhirElement("note", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Safety Characteristics of Device
        /// </summary>
        [FhirElement("safety", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Safety
        {
            get { if (_safety==null) _safety = new List<CodeableConcept>(); return _safety; }
            set { _safety = value; OnPropertyChanged("Safety"); }
        }

        private List<CodeableConcept> _safety;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Device;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Udi != null) dest.Udi = (UdiComponent)Udi.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<FHIRDeviceStatus>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (LotNumberElement != null) dest.LotNumberElement = (FhirString)LotNumberElement.DeepCopy();
                if (ManufacturerElement != null) dest.ManufacturerElement = (FhirString)ManufacturerElement.DeepCopy();
                if (ManufactureDateElement != null) dest.ManufactureDateElement = (FhirDateTime)ManufactureDateElement.DeepCopy();
                if (ExpirationDateElement != null) dest.ExpirationDateElement = (FhirDateTime)ExpirationDateElement.DeepCopy();
                if (ModelElement != null) dest.ModelElement = (FhirString)ModelElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Owner != null) dest.Owner = (ResourceReference)Owner.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactPoint>(Contact.DeepCopy());
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Safety != null) dest.Safety = new List<CodeableConcept>(Safety.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Device());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Device;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Udi, otherT.Udi)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.Matches(ManufacturerElement, otherT.ManufacturerElement)) return false;
            if (!DeepComparable.Matches(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if (!DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if (!DeepComparable.Matches(ModelElement, otherT.ModelElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Owner, otherT.Owner)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Safety, otherT.Safety)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Device;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Udi, otherT.Udi)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.IsExactly(ManufacturerElement, otherT.ManufacturerElement)) return false;
            if (!DeepComparable.IsExactly(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if (!DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if (!DeepComparable.IsExactly(ModelElement, otherT.ModelElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Owner, otherT.Owner)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Safety, otherT.Safety)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Udi != null) yield return Udi;
                if (StatusElement != null) yield return StatusElement;
                if (Type != null) yield return Type;
                if (LotNumberElement != null) yield return LotNumberElement;
                if (ManufacturerElement != null) yield return ManufacturerElement;
                if (ManufactureDateElement != null) yield return ManufactureDateElement;
                if (ExpirationDateElement != null) yield return ExpirationDateElement;
                if (ModelElement != null) yield return ModelElement;
                if (VersionElement != null) yield return VersionElement;
                if (Patient != null) yield return Patient;
                if (Owner != null) yield return Owner;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Location != null) yield return Location;
                if (UrlElement != null) yield return UrlElement;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Safety) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Udi != null) yield return new ElementValue("udi", Udi);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
                if (ManufacturerElement != null) yield return new ElementValue("manufacturer", ManufacturerElement);
                if (ManufactureDateElement != null) yield return new ElementValue("manufactureDate", ManufactureDateElement);
                if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
                if (ModelElement != null) yield return new ElementValue("model", ModelElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Owner != null) yield return new ElementValue("owner", Owner);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Location != null) yield return new ElementValue("location", Location);
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Safety) { if (elem != null) yield return new ElementValue("safety", elem); }
            }
        }

    }

}
