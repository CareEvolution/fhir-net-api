using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
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
        /// Codes to identify how UDI data was entered.
        /// (url: http://hl7.org/fhir/ValueSet/udi-entry-type)
        /// </summary>
        [FhirEnumeration("UDIEntryType")]
        public enum UDIEntryType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/udi-entry-type)
            /// </summary>
            [EnumLiteral("barcode", "http://hl7.org/fhir/udi-entry-type"), Description("Barcode")]
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


        [FhirType("UdiCarrierComponent")]
        [DataContract]
        public partial class UdiCarrierComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "UdiCarrierComponent"; } }

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
            /// UDI Issuing Organization
            /// </summary>
            [FhirElement("issuer", Order=50)]
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
            /// UDI Machine Readable Barcode String
            /// </summary>
            [FhirElement("carrierAIDC", InSummary=true, Order=70)]
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
            /// UDI Human Readable Barcode String
            /// </summary>
            [FhirElement("carrierHRF", InSummary=true, Order=80)]
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
            /// barcode | rfid | manual +
            /// </summary>
            [FhirElement("entryType", Order=90)]
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
                var dest = other as UdiCarrierComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DeviceIdentifierElement != null) dest.DeviceIdentifierElement = (FhirString)DeviceIdentifierElement.DeepCopy();
                    if (IssuerElement != null) dest.IssuerElement = (FhirUri)IssuerElement.DeepCopy();
                    if (JurisdictionElement != null) dest.JurisdictionElement = (FhirUri)JurisdictionElement.DeepCopy();
                    if (CarrierAIDCElement != null) dest.CarrierAIDCElement = (Base64Binary)CarrierAIDCElement.DeepCopy();
                    if (CarrierHRFElement != null) dest.CarrierHRFElement = (FhirString)CarrierHRFElement.DeepCopy();
                    if (EntryTypeElement != null) dest.EntryTypeElement = (Code<UDIEntryType>)EntryTypeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new UdiCarrierComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as UdiCarrierComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DeviceIdentifierElement, otherT.DeviceIdentifierElement)) return false;
                if (!DeepComparable.Matches(IssuerElement, otherT.IssuerElement)) return false;
                if (!DeepComparable.Matches(JurisdictionElement, otherT.JurisdictionElement)) return false;
                if (!DeepComparable.Matches(CarrierAIDCElement, otherT.CarrierAIDCElement)) return false;
                if (!DeepComparable.Matches(CarrierHRFElement, otherT.CarrierHRFElement)) return false;
                if (!DeepComparable.Matches(EntryTypeElement, otherT.EntryTypeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as UdiCarrierComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DeviceIdentifierElement, otherT.DeviceIdentifierElement)) return false;
                if (!DeepComparable.IsExactly(IssuerElement, otherT.IssuerElement)) return false;
                if (!DeepComparable.IsExactly(JurisdictionElement, otherT.JurisdictionElement)) return false;
                if (!DeepComparable.IsExactly(CarrierAIDCElement, otherT.CarrierAIDCElement)) return false;
                if (!DeepComparable.IsExactly(CarrierHRFElement, otherT.CarrierHRFElement)) return false;
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
                    if (IssuerElement != null) yield return IssuerElement;
                    if (JurisdictionElement != null) yield return JurisdictionElement;
                    if (CarrierAIDCElement != null) yield return CarrierAIDCElement;
                    if (CarrierHRFElement != null) yield return CarrierHRFElement;
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
                    if (IssuerElement != null) yield return new ElementValue("issuer", IssuerElement);
                    if (JurisdictionElement != null) yield return new ElementValue("jurisdiction", JurisdictionElement);
                    if (CarrierAIDCElement != null) yield return new ElementValue("carrierAIDC", CarrierAIDCElement);
                    if (CarrierHRFElement != null) yield return new ElementValue("carrierHRF", CarrierHRFElement);
                    if (EntryTypeElement != null) yield return new ElementValue("entryType", EntryTypeElement);
                }
            }


        }


        [FhirType("DeviceNameComponent")]
        [DataContract]
        public partial class DeviceNameComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DeviceNameComponent"; } }

            /// <summary>
            /// The name of the device
            /// </summary>
            [FhirElement("name", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// The name of the device
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
            /// udi-label-name | user-friendly-name | patient-reported-name | manufacturer-name | model-name | other
            /// </summary>
            [FhirElement("type", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<DeviceNameType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<DeviceNameType> _typeElement;

            /// <summary>
            /// udi-label-name | user-friendly-name | patient-reported-name | manufacturer-name | model-name | other
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DeviceNameType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<DeviceNameType>(value);
                    OnPropertyChanged("Type");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DeviceNameComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<DeviceNameType>)TypeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DeviceNameComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DeviceNameComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DeviceNameComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (TypeElement != null) yield return TypeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                }
            }


        }


        [FhirType("SpecializationComponent")]
        [DataContract]
        public partial class SpecializationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SpecializationComponent"; } }

            /// <summary>
            /// The standard that is used to operate and communicate
            /// </summary>
            [FhirElement("systemType", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept SystemType
            {
                get { return _systemType; }
                set { _systemType = value; OnPropertyChanged("SystemType"); }
            }

            private CodeableConcept _systemType;

            /// <summary>
            /// The version of the standard that is used to operate and communicate
            /// </summary>
            [FhirElement("version", Order=50)]
            [DataMember]
            public FhirString VersionElement
            {
                get { return _versionElement; }
                set { _versionElement = value; OnPropertyChanged("VersionElement"); }
            }

            private FhirString _versionElement;

            /// <summary>
            /// The version of the standard that is used to operate and communicate
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SpecializationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SystemType != null) dest.SystemType = (CodeableConcept)SystemType.DeepCopy();
                    if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SpecializationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SpecializationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SystemType, otherT.SystemType)) return false;
                if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SpecializationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SystemType, otherT.SystemType)) return false;
                if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SystemType != null) yield return SystemType;
                    if (VersionElement != null) yield return VersionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SystemType != null) yield return new ElementValue("systemType", SystemType);
                    if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                }
            }


        }


        [FhirType("VersionComponent")]
        [DataContract]
        public partial class VersionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "VersionComponent"; } }

            /// <summary>
            /// The type of the device version
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// A single component of the device version
            /// </summary>
            [FhirElement("component", Order=50)]
            [DataMember]
            public Identifier Component
            {
                get { return _component; }
                set { _component = value; OnPropertyChanged("Component"); }
            }

            private Identifier _component;

            /// <summary>
            /// The version text
            /// </summary>
            [FhirElement("value", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// The version text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VersionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Component != null) dest.Component = (Identifier)Component.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new VersionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VersionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Component, otherT.Component)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VersionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Component, otherT.Component)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Component != null) yield return Component;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Component != null) yield return new ElementValue("component", Component);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                }
            }


        }


        [FhirType("PropertyComponent")]
        [DataContract]
        public partial class PropertyComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PropertyComponent"; } }

            /// <summary>
            /// Code that specifies the property DeviceDefinitionPropetyCode (Extensible)
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Property value as a quantity
            /// </summary>
            [FhirElement("valueQuanity", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Quantity> ValueQuanity
            {
                get { if (_valueQuanity==null) _valueQuanity = new List<Quantity>(); return _valueQuanity; }
                set { _valueQuanity = value; OnPropertyChanged("ValueQuanity"); }
            }

            private List<Quantity> _valueQuanity;

            /// <summary>
            /// Property value as a code, e.g., NTP4 (synced to NTP)
            /// </summary>
            [FhirElement("valueCode", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ValueCode
            {
                get { if (_valueCode==null) _valueCode = new List<CodeableConcept>(); return _valueCode; }
                set { _valueCode = value; OnPropertyChanged("ValueCode"); }
            }

            private List<CodeableConcept> _valueCode;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PropertyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (ValueQuanity != null) dest.ValueQuanity = new List<Quantity>(ValueQuanity.DeepCopy());
                    if (ValueCode != null) dest.ValueCode = new List<CodeableConcept>(ValueCode.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PropertyComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PropertyComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(ValueQuanity, otherT.ValueQuanity)) return false;
                if ( !DeepComparable.Matches(ValueCode, otherT.ValueCode)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PropertyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(ValueQuanity, otherT.ValueQuanity)) return false;
                if (!DeepComparable.IsExactly(ValueCode, otherT.ValueCode)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in ValueQuanity) { if (elem != null) yield return elem; }
                    foreach (var elem in ValueCode) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in ValueQuanity) { if (elem != null) yield return new ElementValue("valueQuanity", elem); }
                    foreach (var elem in ValueCode) { if (elem != null) yield return new ElementValue("valueCode", elem); }
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
        /// The reference to the definition for the device
        /// </summary>
        [FhirElement("definition", Order=100)]
        [References("DeviceDefinition")]
        [DataMember]
        public ResourceReference Definition
        {
            get { return _definition; }
            set { _definition = value; OnPropertyChanged("Definition"); }
        }

        private ResourceReference _definition;

        /// <summary>
        /// Unique Device Identifier (UDI) Barcode string
        /// </summary>
        [FhirElement("udiCarrier", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UdiCarrierComponent> UdiCarrier
        {
            get { if (_udiCarrier==null) _udiCarrier = new List<UdiCarrierComponent>(); return _udiCarrier; }
            set { _udiCarrier = value; OnPropertyChanged("UdiCarrier"); }
        }

        private List<UdiCarrierComponent> _udiCarrier;

        /// <summary>
        /// active | inactive | entered-in-error | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
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
        /// online | paused | standby | offline | not-ready | transduc-discon | hw-discon | off
        /// </summary>
        [FhirElement("statusReason", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> StatusReason
        {
            get { if (_statusReason==null) _statusReason = new List<CodeableConcept>(); return _statusReason; }
            set { _statusReason = value; OnPropertyChanged("StatusReason"); }
        }

        private List<CodeableConcept> _statusReason;

        /// <summary>
        /// The distinct identification code for a biological product regulated as a device
        /// </summary>
        [FhirElement("distinctIdentificationCode", Order=140)]
        [DataMember]
        public FhirString DistinctIdentificationCodeElement
        {
            get { return _distinctIdentificationCodeElement; }
            set { _distinctIdentificationCodeElement = value; OnPropertyChanged("DistinctIdentificationCodeElement"); }
        }

        private FhirString _distinctIdentificationCodeElement;

        /// <summary>
        /// The distinct identification code for a biological product regulated as a device
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DistinctIdentificationCode
        {
            get { return DistinctIdentificationCodeElement != null ? DistinctIdentificationCodeElement.Value : null; }
            set
            {
                if (value == null)
                    DistinctIdentificationCodeElement = null;
                else
                    DistinctIdentificationCodeElement = new FhirString(value);
                OnPropertyChanged("DistinctIdentificationCode");
            }
        }

        /// <summary>
        /// Name of device manufacturer
        /// </summary>
        [FhirElement("manufacturer", Order=150)]
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
        [FhirElement("manufactureDate", Order=160)]
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
        [FhirElement("expirationDate", Order=170)]
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
        /// Lot number of manufacture
        /// </summary>
        [FhirElement("lotNumber", Order=180)]
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
        /// Serial number assigned by the manufacturer
        /// </summary>
        [FhirElement("serialNumber", Order=190)]
        [DataMember]
        public FhirString SerialNumberElement
        {
            get { return _serialNumberElement; }
            set { _serialNumberElement = value; OnPropertyChanged("SerialNumberElement"); }
        }

        private FhirString _serialNumberElement;

        /// <summary>
        /// Serial number assigned by the manufacturer
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
        /// The name of the device as given by the manufacturer
        /// </summary>
        [FhirElement("deviceName", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DeviceNameComponent> DeviceName
        {
            get { if (_deviceName==null) _deviceName = new List<DeviceNameComponent>(); return _deviceName; }
            set { _deviceName = value; OnPropertyChanged("DeviceName"); }
        }

        private List<DeviceNameComponent> _deviceName;

        /// <summary>
        /// The model number for the device
        /// </summary>
        [FhirElement("modelNumber", Order=210)]
        [DataMember]
        public FhirString ModelNumberElement
        {
            get { return _modelNumberElement; }
            set { _modelNumberElement = value; OnPropertyChanged("ModelNumberElement"); }
        }

        private FhirString _modelNumberElement;

        /// <summary>
        /// The model number for the device
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ModelNumber
        {
            get { return ModelNumberElement != null ? ModelNumberElement.Value : null; }
            set
            {
                if (value == null)
                    ModelNumberElement = null;
                else
                    ModelNumberElement = new FhirString(value);
                OnPropertyChanged("ModelNumber");
            }
        }

        /// <summary>
        /// The part number of the device
        /// </summary>
        [FhirElement("partNumber", Order=220)]
        [DataMember]
        public FhirString PartNumberElement
        {
            get { return _partNumberElement; }
            set { _partNumberElement = value; OnPropertyChanged("PartNumberElement"); }
        }

        private FhirString _partNumberElement;

        /// <summary>
        /// The part number of the device
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string PartNumber
        {
            get { return PartNumberElement != null ? PartNumberElement.Value : null; }
            set
            {
                if (value == null)
                    PartNumberElement = null;
                else
                    PartNumberElement = new FhirString(value);
                OnPropertyChanged("PartNumber");
            }
        }

        /// <summary>
        /// The kind or type of device
        /// </summary>
        [FhirElement("type", Order=230)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// The capabilities supported on a  device, the standards to which the device conforms for a particular purpose, and used for the communication
        /// </summary>
        [FhirElement("specialization", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SpecializationComponent> Specialization
        {
            get { if (_specialization==null) _specialization = new List<SpecializationComponent>(); return _specialization; }
            set { _specialization = value; OnPropertyChanged("Specialization"); }
        }

        private List<SpecializationComponent> _specialization;

        /// <summary>
        /// The actual design of the device or software version running on the device
        /// </summary>
        [FhirElement("version", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<VersionComponent> Version
        {
            get { if (_version==null) _version = new List<VersionComponent>(); return _version; }
            set { _version = value; OnPropertyChanged("Version"); }
        }

        private List<VersionComponent> _version;

        /// <summary>
        /// The actual configuration settings of a device as it actually operates, e.g., regulation status, time properties
        /// </summary>
        [FhirElement("property", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PropertyComponent> Property
        {
            get { if (_property==null) _property = new List<PropertyComponent>(); return _property; }
            set { _property = value; OnPropertyChanged("Property"); }
        }

        private List<PropertyComponent> _property;

        /// <summary>
        /// Patient to whom Device is affixed
        /// </summary>
        [FhirElement("patient", Order=270)]
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
        [FhirElement("owner", Order=280)]
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
        [FhirElement("contact", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Contact
        {
            get { if (_contact==null) _contact = new List<ContactPoint>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactPoint> _contact;

        /// <summary>
        /// Where the device is found
        /// </summary>
        [FhirElement("location", Order=300)]
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
        [FhirElement("url", Order=310)]
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
        [FhirElement("note", Order=320)]
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
        [FhirElement("safety", InSummary=true, Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Safety
        {
            get { if (_safety==null) _safety = new List<CodeableConcept>(); return _safety; }
            set { _safety = value; OnPropertyChanged("Safety"); }
        }

        private List<CodeableConcept> _safety;

        /// <summary>
        /// The parent device
        /// </summary>
        [FhirElement("parent", Order=340)]
        [References("Device")]
        [DataMember]
        public ResourceReference Parent
        {
            get { return _parent; }
            set { _parent = value; OnPropertyChanged("Parent"); }
        }

        private ResourceReference _parent;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Device;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Definition != null) dest.Definition = (ResourceReference)Definition.DeepCopy();
                if (UdiCarrier != null) dest.UdiCarrier = new List<UdiCarrierComponent>(UdiCarrier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FHIRDeviceStatus>)StatusElement.DeepCopy();
                if (StatusReason != null) dest.StatusReason = new List<CodeableConcept>(StatusReason.DeepCopy());
                if (DistinctIdentificationCodeElement != null) dest.DistinctIdentificationCodeElement = (FhirString)DistinctIdentificationCodeElement.DeepCopy();
                if (ManufacturerElement != null) dest.ManufacturerElement = (FhirString)ManufacturerElement.DeepCopy();
                if (ManufactureDateElement != null) dest.ManufactureDateElement = (FhirDateTime)ManufactureDateElement.DeepCopy();
                if (ExpirationDateElement != null) dest.ExpirationDateElement = (FhirDateTime)ExpirationDateElement.DeepCopy();
                if (LotNumberElement != null) dest.LotNumberElement = (FhirString)LotNumberElement.DeepCopy();
                if (SerialNumberElement != null) dest.SerialNumberElement = (FhirString)SerialNumberElement.DeepCopy();
                if (DeviceName != null) dest.DeviceName = new List<DeviceNameComponent>(DeviceName.DeepCopy());
                if (ModelNumberElement != null) dest.ModelNumberElement = (FhirString)ModelNumberElement.DeepCopy();
                if (PartNumberElement != null) dest.PartNumberElement = (FhirString)PartNumberElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Specialization != null) dest.Specialization = new List<SpecializationComponent>(Specialization.DeepCopy());
                if (Version != null) dest.Version = new List<VersionComponent>(Version.DeepCopy());
                if (Property != null) dest.Property = new List<PropertyComponent>(Property.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Owner != null) dest.Owner = (ResourceReference)Owner.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactPoint>(Contact.DeepCopy());
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Safety != null) dest.Safety = new List<CodeableConcept>(Safety.DeepCopy());
                if (Parent != null) dest.Parent = (ResourceReference)Parent.DeepCopy();
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
            if (!DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if ( !DeepComparable.Matches(UdiCarrier, otherT.UdiCarrier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.Matches(DistinctIdentificationCodeElement, otherT.DistinctIdentificationCodeElement)) return false;
            if (!DeepComparable.Matches(ManufacturerElement, otherT.ManufacturerElement)) return false;
            if (!DeepComparable.Matches(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if (!DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if (!DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.Matches(SerialNumberElement, otherT.SerialNumberElement)) return false;
            if ( !DeepComparable.Matches(DeviceName, otherT.DeviceName)) return false;
            if (!DeepComparable.Matches(ModelNumberElement, otherT.ModelNumberElement)) return false;
            if (!DeepComparable.Matches(PartNumberElement, otherT.PartNumberElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(Specialization, otherT.Specialization)) return false;
            if ( !DeepComparable.Matches(Version, otherT.Version)) return false;
            if ( !DeepComparable.Matches(Property, otherT.Property)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Owner, otherT.Owner)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Safety, otherT.Safety)) return false;
            if (!DeepComparable.Matches(Parent, otherT.Parent)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Device;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(UdiCarrier, otherT.UdiCarrier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.IsExactly(DistinctIdentificationCodeElement, otherT.DistinctIdentificationCodeElement)) return false;
            if (!DeepComparable.IsExactly(ManufacturerElement, otherT.ManufacturerElement)) return false;
            if (!DeepComparable.IsExactly(ManufactureDateElement, otherT.ManufactureDateElement)) return false;
            if (!DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if (!DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.IsExactly(SerialNumberElement, otherT.SerialNumberElement)) return false;
            if (!DeepComparable.IsExactly(DeviceName, otherT.DeviceName)) return false;
            if (!DeepComparable.IsExactly(ModelNumberElement, otherT.ModelNumberElement)) return false;
            if (!DeepComparable.IsExactly(PartNumberElement, otherT.PartNumberElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Specialization, otherT.Specialization)) return false;
            if (!DeepComparable.IsExactly(Version, otherT.Version)) return false;
            if (!DeepComparable.IsExactly(Property, otherT.Property)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Owner, otherT.Owner)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Safety, otherT.Safety)) return false;
            if (!DeepComparable.IsExactly(Parent, otherT.Parent)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Definition != null) yield return Definition;
                foreach (var elem in UdiCarrier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                foreach (var elem in StatusReason) { if (elem != null) yield return elem; }
                if (DistinctIdentificationCodeElement != null) yield return DistinctIdentificationCodeElement;
                if (ManufacturerElement != null) yield return ManufacturerElement;
                if (ManufactureDateElement != null) yield return ManufactureDateElement;
                if (ExpirationDateElement != null) yield return ExpirationDateElement;
                if (LotNumberElement != null) yield return LotNumberElement;
                if (SerialNumberElement != null) yield return SerialNumberElement;
                foreach (var elem in DeviceName) { if (elem != null) yield return elem; }
                if (ModelNumberElement != null) yield return ModelNumberElement;
                if (PartNumberElement != null) yield return PartNumberElement;
                if (Type != null) yield return Type;
                foreach (var elem in Specialization) { if (elem != null) yield return elem; }
                foreach (var elem in Version) { if (elem != null) yield return elem; }
                foreach (var elem in Property) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
                if (Owner != null) yield return Owner;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Location != null) yield return Location;
                if (UrlElement != null) yield return UrlElement;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Safety) { if (elem != null) yield return elem; }
                if (Parent != null) yield return Parent;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Definition != null) yield return new ElementValue("definition", Definition);
                foreach (var elem in UdiCarrier) { if (elem != null) yield return new ElementValue("udiCarrier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                foreach (var elem in StatusReason) { if (elem != null) yield return new ElementValue("statusReason", elem); }
                if (DistinctIdentificationCodeElement != null) yield return new ElementValue("distinctIdentificationCode", DistinctIdentificationCodeElement);
                if (ManufacturerElement != null) yield return new ElementValue("manufacturer", ManufacturerElement);
                if (ManufactureDateElement != null) yield return new ElementValue("manufactureDate", ManufactureDateElement);
                if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
                if (SerialNumberElement != null) yield return new ElementValue("serialNumber", SerialNumberElement);
                foreach (var elem in DeviceName) { if (elem != null) yield return new ElementValue("deviceName", elem); }
                if (ModelNumberElement != null) yield return new ElementValue("modelNumber", ModelNumberElement);
                if (PartNumberElement != null) yield return new ElementValue("partNumber", PartNumberElement);
                if (Type != null) yield return new ElementValue("type", Type);
                foreach (var elem in Specialization) { if (elem != null) yield return new ElementValue("specialization", elem); }
                foreach (var elem in Version) { if (elem != null) yield return new ElementValue("version", elem); }
                foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Owner != null) yield return new ElementValue("owner", Owner);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Location != null) yield return new ElementValue("location", Location);
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Safety) { if (elem != null) yield return new ElementValue("safety", elem); }
                if (Parent != null) yield return new ElementValue("parent", Parent);
            }
        }

    }

}
