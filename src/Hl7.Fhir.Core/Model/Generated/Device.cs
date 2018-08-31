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
    /// An instance of a manufactured te that is used in the provision of healthcare
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
        /// The availability status of the device.
        /// (url: http://hl7.org/fhir/ValueSet/devicestatus)
        /// </summary>
        [FhirEnumeration("DeviceStatus")]
        public enum DeviceStatus
        {
            /// <summary>
            /// The Device is available for use.
            /// (system: http://hl7.org/fhir/devicestatus)
            /// </summary>
            [EnumLiteral("available", "http://hl7.org/fhir/devicestatus"), Description("Available")]
            Available,
            /// <summary>
            /// The Device is no longer available for use (e.g. lost, expired, damaged).
            /// (system: http://hl7.org/fhir/devicestatus)
            /// </summary>
            [EnumLiteral("not-available", "http://hl7.org/fhir/devicestatus"), Description("Not Available")]
            NotAvailable,
            /// <summary>
            /// The Device was entered in error and voided.
            /// (system: http://hl7.org/fhir/devicestatus)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/devicestatus"), Description("Entered in Error")]
            EnteredInError,
        }


        /// <summary>
        /// Instance id from manufacturer, owner, and others
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
        /// What kind of device this is
        /// </summary>
        [FhirElement("type", Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Device notes and comments
        /// </summary>
        [FhirElement("note", Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// available | not-available | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [DataMember]
        public Code<DeviceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<DeviceStatus> _statusElement;

        /// <summary>
        /// available | not-available | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DeviceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<DeviceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Name of device manufacturer
        /// </summary>
        [FhirElement("manufacturer", Order=130)]
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
        /// Model id assigned by the manufacturer
        /// </summary>
        [FhirElement("model", Order=140)]
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
        [FhirElement("version", Order=150)]
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
        /// Manufacture date
        /// </summary>
        [FhirElement("manufactureDate", Order=160)]
        [DataMember]
        public FhirDateTime ManufactureDateElement
        {
            get { return _manufactureDateElement; }
            set { _manufactureDateElement = value; OnPropertyChanged("ManufactureDateElement"); }
        }

        private FhirDateTime _manufactureDateElement;

        /// <summary>
        /// Manufacture date
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
        [FhirElement("expiry", Order=170)]
        [DataMember]
        public FhirDateTime ExpiryElement
        {
            get { return _expiryElement; }
            set { _expiryElement = value; OnPropertyChanged("ExpiryElement"); }
        }

        private FhirDateTime _expiryElement;

        /// <summary>
        /// Date and time of expiry of this device (if applicable)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Expiry
        {
            get { return ExpiryElement != null ? ExpiryElement.Value : null; }
            set
            {
                if (value == null)
                    ExpiryElement = null;
                else
                    ExpiryElement = new FhirDateTime(value);
                OnPropertyChanged("Expiry");
            }
        }

        /// <summary>
        /// FDA mandated Unique Device Identifier
        /// </summary>
        [FhirElement("udi", Order=180)]
        [DataMember]
        public FhirString UdiElement
        {
            get { return _udiElement; }
            set { _udiElement = value; OnPropertyChanged("UdiElement"); }
        }

        private FhirString _udiElement;

        /// <summary>
        /// FDA mandated Unique Device Identifier
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Udi
        {
            get { return UdiElement != null ? UdiElement.Value : null; }
            set
            {
                if (value == null)
                    UdiElement = null;
                else
                    UdiElement = new FhirString(value);
                OnPropertyChanged("Udi");
            }
        }

        /// <summary>
        /// Lot number of manufacture
        /// </summary>
        [FhirElement("lotNumber", Order=190)]
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
        /// Where the resource is found
        /// </summary>
        [FhirElement("location", Order=210)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// If the resource is affixed to a person
        /// </summary>
        [FhirElement("patient", Order=220)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Details for human/organization for support
        /// </summary>
        [FhirElement("contact", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Contact
        {
            get { if (_contact==null) _contact = new List<ContactPoint>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactPoint> _contact;

        /// <summary>
        /// Network address to contact device
        /// </summary>
        [FhirElement("url", Order=240)]
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


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Device;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<DeviceStatus>)StatusElement.DeepCopy();
                if (ManufacturerElement != null) dest.ManufacturerElement = (FhirString)ManufacturerElement.DeepCopy();
                if (ModelElement != null) dest.ModelElement = (FhirString)ModelElement.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (ManufactureDateElement != null) dest.ManufactureDateElement = (FhirDateTime)ManufactureDateElement.DeepCopy();
                if (ExpiryElement != null) dest.ExpiryElement = (FhirDateTime)ExpiryElement.DeepCopy();
                if (UdiElement != null) dest.UdiElement = (FhirString)UdiElement.DeepCopy();
                if (LotNumberElement != null) dest.LotNumberElement = (FhirString)LotNumberElement.DeepCopy();
                if (Owner != null) dest.Owner = (ResourceReference)Owner.DeepCopy();
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactPoint>(Contact.DeepCopy());
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
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
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ManufacturerElement, otherT.ManufacturerElement)) return false;
            if (!DeepComparable.Matches(ModelElement, otherT.ModelElement)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if (!DeepComparable.Matches(ExpiryElement, otherT.ExpiryElement)) return false;
            if (!DeepComparable.Matches(UdiElement, otherT.UdiElement)) return false;
            if (!DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.Matches(Owner, otherT.Owner)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Device;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ManufacturerElement, otherT.ManufacturerElement)) return false;
            if (!DeepComparable.IsExactly(ModelElement, otherT.ModelElement)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if (!DeepComparable.IsExactly(ExpiryElement, otherT.ExpiryElement)) return false;
            if (!DeepComparable.IsExactly(UdiElement, otherT.UdiElement)) return false;
            if (!DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.IsExactly(Owner, otherT.Owner)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Type != null) yield return Type;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (ManufacturerElement != null) yield return ManufacturerElement;
                if (ModelElement != null) yield return ModelElement;
                if (VersionElement != null) yield return VersionElement;
                if (ManufactureDateElement != null) yield return ManufactureDateElement;
                if (ExpiryElement != null) yield return ExpiryElement;
                if (UdiElement != null) yield return UdiElement;
                if (LotNumberElement != null) yield return LotNumberElement;
                if (Owner != null) yield return Owner;
                if (Location != null) yield return Location;
                if (Patient != null) yield return Patient;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (UrlElement != null) yield return UrlElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Type != null) yield return new ElementValue("type", Type);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ManufacturerElement != null) yield return new ElementValue("manufacturer", ManufacturerElement);
                if (ModelElement != null) yield return new ElementValue("model", ModelElement);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (ManufactureDateElement != null) yield return new ElementValue("manufactureDate", ManufactureDateElement);
                if (ExpiryElement != null) yield return new ElementValue("expiry", ExpiryElement);
                if (UdiElement != null) yield return new ElementValue("udi", UdiElement);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
                if (Owner != null) yield return new ElementValue("owner", Owner);
                if (Location != null) yield return new ElementValue("location", Location);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
            }
        }

    }

}
