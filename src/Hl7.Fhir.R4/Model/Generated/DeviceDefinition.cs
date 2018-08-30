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
    /// An instance of a medical-related component of a medical device
    /// </summary>
    [FhirType("DeviceDefinition", IsResource=true)]
    [DataContract]
    public partial class DeviceDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DeviceDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "DeviceDefinition"; } }


        [FhirType("UdiDeviceIdentifierComponent")]
        [DataContract]
        public partial class UdiDeviceIdentifierComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "UdiDeviceIdentifierComponent"; } }

            /// <summary>
            /// The identifier that is to be associated with every Device that references this DeviceDefintiion for the issuer and jurisdication porvided in the DeviceDefinition.udiDeviceIdentifier
            /// </summary>
            [FhirElement("deviceIdentifier", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString DeviceIdentifierElement
            {
                get { return _deviceIdentifierElement; }
                set { _deviceIdentifierElement = value; OnPropertyChanged("DeviceIdentifierElement"); }
            }

            private FhirString _deviceIdentifierElement;

            /// <summary>
            /// The identifier that is to be associated with every Device that references this DeviceDefintiion for the issuer and jurisdication porvided in the DeviceDefinition.udiDeviceIdentifier
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
            /// The organization that assigns the identifier algorithm
            /// </summary>
            [FhirElement("issuer", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri IssuerElement
            {
                get { return _issuerElement; }
                set { _issuerElement = value; OnPropertyChanged("IssuerElement"); }
            }

            private FhirUri _issuerElement;

            /// <summary>
            /// The organization that assigns the identifier algorithm
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
            /// The jurisdiction to which the deviceIdentifier applies
            /// </summary>
            [FhirElement("jurisdiction", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri JurisdictionElement
            {
                get { return _jurisdictionElement; }
                set { _jurisdictionElement = value; OnPropertyChanged("JurisdictionElement"); }
            }

            private FhirUri _jurisdictionElement;

            /// <summary>
            /// The jurisdiction to which the deviceIdentifier applies
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as UdiDeviceIdentifierComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DeviceIdentifierElement != null) dest.DeviceIdentifierElement = (FhirString)DeviceIdentifierElement.DeepCopy();
                    if (IssuerElement != null) dest.IssuerElement = (FhirUri)IssuerElement.DeepCopy();
                    if (JurisdictionElement != null) dest.JurisdictionElement = (FhirUri)JurisdictionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new UdiDeviceIdentifierComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as UdiDeviceIdentifierComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DeviceIdentifierElement, otherT.DeviceIdentifierElement)) return false;
                if (!DeepComparable.Matches(IssuerElement, otherT.IssuerElement)) return false;
                if (!DeepComparable.Matches(JurisdictionElement, otherT.JurisdictionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as UdiDeviceIdentifierComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DeviceIdentifierElement, otherT.DeviceIdentifierElement)) return false;
                if (!DeepComparable.IsExactly(IssuerElement, otherT.IssuerElement)) return false;
                if (!DeepComparable.IsExactly(JurisdictionElement, otherT.JurisdictionElement)) return false;

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
            public FhirString SystemTypeElement
            {
                get { return _systemTypeElement; }
                set { _systemTypeElement = value; OnPropertyChanged("SystemTypeElement"); }
            }

            private FhirString _systemTypeElement;

            /// <summary>
            /// The standard that is used to operate and communicate
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SystemType
            {
                get { return SystemTypeElement != null ? SystemTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        SystemTypeElement = null;
                    else
                        SystemTypeElement = new FhirString(value);
                    OnPropertyChanged("SystemType");
                }
            }

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
                    if (SystemTypeElement != null) dest.SystemTypeElement = (FhirString)SystemTypeElement.DeepCopy();
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
                if (!DeepComparable.Matches(SystemTypeElement, otherT.SystemTypeElement)) return false;
                if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SpecializationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SystemTypeElement, otherT.SystemTypeElement)) return false;
                if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SystemTypeElement != null) yield return SystemTypeElement;
                    if (VersionElement != null) yield return VersionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SystemTypeElement != null) yield return new ElementValue("systemType", SystemTypeElement);
                    if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                }
            }


        }


        [FhirType("CapabilityComponent")]
        [DataContract]
        public partial class CapabilityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CapabilityComponent"; } }

            /// <summary>
            /// Type of capability
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
            /// Description of capability
            /// </summary>
            [FhirElement("description", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Description
            {
                get { if (_description==null) _description = new List<CodeableConcept>(); return _description; }
                set { _description = value; OnPropertyChanged("Description"); }
            }

            private List<CodeableConcept> _description;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CapabilityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Description != null) dest.Description = new List<CodeableConcept>(Description.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CapabilityComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CapabilityComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Description, otherT.Description)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CapabilityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Description) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Description) { if (elem != null) yield return new ElementValue("description", elem); }
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


        [FhirType("MaterialComponent")]
        [DataContract]
        public partial class MaterialComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MaterialComponent"; } }

            /// <summary>
            /// The substance
            /// </summary>
            [FhirElement("substance", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Substance
            {
                get { return _substance; }
                set { _substance = value; OnPropertyChanged("Substance"); }
            }

            private CodeableConcept _substance;

            /// <summary>
            /// Indicates an alternative material of the device
            /// </summary>
            [FhirElement("alternate", Order=50)]
            [DataMember]
            public FhirBoolean AlternateElement
            {
                get { return _alternateElement; }
                set { _alternateElement = value; OnPropertyChanged("AlternateElement"); }
            }

            private FhirBoolean _alternateElement;

            /// <summary>
            /// Indicates an alternative material of the device
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Alternate
            {
                get { return AlternateElement != null ? AlternateElement.Value : null; }
                set
                {
                    if (value == null)
                        AlternateElement = null;
                    else
                        AlternateElement = new FhirBoolean(value);
                    OnPropertyChanged("Alternate");
                }
            }

            /// <summary>
            /// Whether the substance is a known or suspected allergen
            /// </summary>
            [FhirElement("allergenicIndicator", Order=60)]
            [DataMember]
            public FhirBoolean AllergenicIndicatorElement
            {
                get { return _allergenicIndicatorElement; }
                set { _allergenicIndicatorElement = value; OnPropertyChanged("AllergenicIndicatorElement"); }
            }

            private FhirBoolean _allergenicIndicatorElement;

            /// <summary>
            /// Whether the substance is a known or suspected allergen
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? AllergenicIndicator
            {
                get { return AllergenicIndicatorElement != null ? AllergenicIndicatorElement.Value : null; }
                set
                {
                    if (value == null)
                        AllergenicIndicatorElement = null;
                    else
                        AllergenicIndicatorElement = new FhirBoolean(value);
                    OnPropertyChanged("AllergenicIndicator");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MaterialComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Substance != null) dest.Substance = (CodeableConcept)Substance.DeepCopy();
                    if (AlternateElement != null) dest.AlternateElement = (FhirBoolean)AlternateElement.DeepCopy();
                    if (AllergenicIndicatorElement != null) dest.AllergenicIndicatorElement = (FhirBoolean)AllergenicIndicatorElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MaterialComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MaterialComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Substance, otherT.Substance)) return false;
                if (!DeepComparable.Matches(AlternateElement, otherT.AlternateElement)) return false;
                if (!DeepComparable.Matches(AllergenicIndicatorElement, otherT.AllergenicIndicatorElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MaterialComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
                if (!DeepComparable.IsExactly(AlternateElement, otherT.AlternateElement)) return false;
                if (!DeepComparable.IsExactly(AllergenicIndicatorElement, otherT.AllergenicIndicatorElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Substance != null) yield return Substance;
                    if (AlternateElement != null) yield return AlternateElement;
                    if (AllergenicIndicatorElement != null) yield return AllergenicIndicatorElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Substance != null) yield return new ElementValue("substance", Substance);
                    if (AlternateElement != null) yield return new ElementValue("alternate", AlternateElement);
                    if (AllergenicIndicatorElement != null) yield return new ElementValue("allergenicIndicator", AllergenicIndicatorElement);
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
        [FhirElement("udiDeviceIdentifier", Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UdiDeviceIdentifierComponent> UdiDeviceIdentifier
        {
            get { if (_udiDeviceIdentifier==null) _udiDeviceIdentifier = new List<UdiDeviceIdentifierComponent>(); return _udiDeviceIdentifier; }
            set { _udiDeviceIdentifier = value; OnPropertyChanged("UdiDeviceIdentifier"); }
        }

        private List<UdiDeviceIdentifierComponent> _udiDeviceIdentifier;

        /// <summary>
        /// Name of device manufacturer
        /// </summary>
        [FhirElement("manufacturer", Order=110, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirString),typeof(ResourceReference))]
        [DataMember]
        public Element Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }

        private Element _manufacturer;

        /// <summary>
        /// A name given to the device to identify it
        /// </summary>
        [FhirElement("deviceName", Order=120)]
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
        [FhirElement("modelNumber", Order=130)]
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
        /// What kind of device or device system this is
        /// </summary>
        [FhirElement("type", Order=140)]
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
        [FhirElement("specialization", Order=150)]
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
        [FhirElement("version", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> VersionElement
        {
            get { if (_versionElement==null) _versionElement = new List<FhirString>(); return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private List<FhirString> _versionElement;

        /// <summary>
        /// The actual design of the device or software version running on the device
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Version
        {
            get { return VersionElement != null ? VersionElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Safety characteristics of the device
        /// </summary>
        [FhirElement("safety", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Safety
        {
            get { if (_safety==null) _safety = new List<CodeableConcept>(); return _safety; }
            set { _safety = value; OnPropertyChanged("Safety"); }
        }

        private List<CodeableConcept> _safety;

        /// <summary>
        /// Shelf Life and storage information
        /// </summary>
        [FhirElement("shelfLifeStorage", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ProductShelfLife> ShelfLifeStorage
        {
            get { if (_shelfLifeStorage==null) _shelfLifeStorage = new List<ProductShelfLife>(); return _shelfLifeStorage; }
            set { _shelfLifeStorage = value; OnPropertyChanged("ShelfLifeStorage"); }
        }

        private List<ProductShelfLife> _shelfLifeStorage;

        /// <summary>
        /// Dimensions, color etc.
        /// </summary>
        [FhirElement("physicalCharacteristics", Order=190)]
        [DataMember]
        public ProdCharacteristic PhysicalCharacteristics
        {
            get { return _physicalCharacteristics; }
            set { _physicalCharacteristics = value; OnPropertyChanged("PhysicalCharacteristics"); }
        }

        private ProdCharacteristic _physicalCharacteristics;

        /// <summary>
        /// Language code for the human-readable text strings produced by the device (all supported)
        /// </summary>
        [FhirElement("languageCode", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> LanguageCode
        {
            get { if (_languageCode==null) _languageCode = new List<CodeableConcept>(); return _languageCode; }
            set { _languageCode = value; OnPropertyChanged("LanguageCode"); }
        }

        private List<CodeableConcept> _languageCode;

        /// <summary>
        /// Device capabilities
        /// </summary>
        [FhirElement("capability", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CapabilityComponent> Capability
        {
            get { if (_capability==null) _capability = new List<CapabilityComponent>(); return _capability; }
            set { _capability = value; OnPropertyChanged("Capability"); }
        }

        private List<CapabilityComponent> _capability;

        /// <summary>
        /// The actual configuration settings of a device as it actually operates, e.g., regulation status, time properties
        /// </summary>
        [FhirElement("property", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PropertyComponent> Property
        {
            get { if (_property==null) _property = new List<PropertyComponent>(); return _property; }
            set { _property = value; OnPropertyChanged("Property"); }
        }

        private List<PropertyComponent> _property;

        /// <summary>
        /// Organization responsible for device
        /// </summary>
        [FhirElement("owner", Order=230)]
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
        [FhirElement("contact", Order=240)]
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
        [FhirElement("url", Order=250)]
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
        /// Access to on-line information
        /// </summary>
        [FhirElement("onlineInformation", Order=260)]
        [DataMember]
        public FhirUri OnlineInformationElement
        {
            get { return _onlineInformationElement; }
            set { _onlineInformationElement = value; OnPropertyChanged("OnlineInformationElement"); }
        }

        private FhirUri _onlineInformationElement;

        /// <summary>
        /// Access to on-line information
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string OnlineInformation
        {
            get { return OnlineInformationElement != null ? OnlineInformationElement.Value : null; }
            set
            {
                if (value == null)
                    OnlineInformationElement = null;
                else
                    OnlineInformationElement = new FhirUri(value);
                OnPropertyChanged("OnlineInformation");
            }
        }

        /// <summary>
        /// Device notes and comments
        /// </summary>
        [FhirElement("note", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// The quantity of the device present in the packaging (e.g. the number of devices present in a pack, or the number of devices in the same package of the medicinal product)
        /// </summary>
        [FhirElement("quantity", Order=280)]
        [DataMember]
        public Quantity Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged("Quantity"); }
        }

        private Quantity _quantity;

        /// <summary>
        /// The parent device it can be part of
        /// </summary>
        [FhirElement("parentDevice", InSummary=true, Order=290)]
        [References("DeviceDefinition")]
        [DataMember]
        public ResourceReference ParentDevice
        {
            get { return _parentDevice; }
            set { _parentDevice = value; OnPropertyChanged("ParentDevice"); }
        }

        private ResourceReference _parentDevice;

        /// <summary>
        /// A substance used to create the material(s) of which the device is made
        /// </summary>
        [FhirElement("material", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MaterialComponent> Material
        {
            get { if (_material==null) _material = new List<MaterialComponent>(); return _material; }
            set { _material = value; OnPropertyChanged("Material"); }
        }

        private List<MaterialComponent> _material;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DeviceDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (UdiDeviceIdentifier != null) dest.UdiDeviceIdentifier = new List<UdiDeviceIdentifierComponent>(UdiDeviceIdentifier.DeepCopy());
                if (Manufacturer != null) dest.Manufacturer = (Element)Manufacturer.DeepCopy();
                if (DeviceName != null) dest.DeviceName = new List<DeviceNameComponent>(DeviceName.DeepCopy());
                if (ModelNumberElement != null) dest.ModelNumberElement = (FhirString)ModelNumberElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Specialization != null) dest.Specialization = new List<SpecializationComponent>(Specialization.DeepCopy());
                if (VersionElement != null) dest.VersionElement = new List<FhirString>(VersionElement.DeepCopy());
                if (Safety != null) dest.Safety = new List<CodeableConcept>(Safety.DeepCopy());
                if (ShelfLifeStorage != null) dest.ShelfLifeStorage = new List<ProductShelfLife>(ShelfLifeStorage.DeepCopy());
                if (PhysicalCharacteristics != null) dest.PhysicalCharacteristics = (ProdCharacteristic)PhysicalCharacteristics.DeepCopy();
                if (LanguageCode != null) dest.LanguageCode = new List<CodeableConcept>(LanguageCode.DeepCopy());
                if (Capability != null) dest.Capability = new List<CapabilityComponent>(Capability.DeepCopy());
                if (Property != null) dest.Property = new List<PropertyComponent>(Property.DeepCopy());
                if (Owner != null) dest.Owner = (ResourceReference)Owner.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactPoint>(Contact.DeepCopy());
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (OnlineInformationElement != null) dest.OnlineInformationElement = (FhirUri)OnlineInformationElement.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Quantity != null) dest.Quantity = (Quantity)Quantity.DeepCopy();
                if (ParentDevice != null) dest.ParentDevice = (ResourceReference)ParentDevice.DeepCopy();
                if (Material != null) dest.Material = new List<MaterialComponent>(Material.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new DeviceDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DeviceDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(UdiDeviceIdentifier, otherT.UdiDeviceIdentifier)) return false;
            if (!DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if ( !DeepComparable.Matches(DeviceName, otherT.DeviceName)) return false;
            if (!DeepComparable.Matches(ModelNumberElement, otherT.ModelNumberElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(Specialization, otherT.Specialization)) return false;
            if ( !DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if ( !DeepComparable.Matches(Safety, otherT.Safety)) return false;
            if ( !DeepComparable.Matches(ShelfLifeStorage, otherT.ShelfLifeStorage)) return false;
            if (!DeepComparable.Matches(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
            if ( !DeepComparable.Matches(LanguageCode, otherT.LanguageCode)) return false;
            if ( !DeepComparable.Matches(Capability, otherT.Capability)) return false;
            if ( !DeepComparable.Matches(Property, otherT.Property)) return false;
            if (!DeepComparable.Matches(Owner, otherT.Owner)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(OnlineInformationElement, otherT.OnlineInformationElement)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.Matches(ParentDevice, otherT.ParentDevice)) return false;
            if ( !DeepComparable.Matches(Material, otherT.Material)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DeviceDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(UdiDeviceIdentifier, otherT.UdiDeviceIdentifier)) return false;
            if (!DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.IsExactly(DeviceName, otherT.DeviceName)) return false;
            if (!DeepComparable.IsExactly(ModelNumberElement, otherT.ModelNumberElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Specialization, otherT.Specialization)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(Safety, otherT.Safety)) return false;
            if (!DeepComparable.IsExactly(ShelfLifeStorage, otherT.ShelfLifeStorage)) return false;
            if (!DeepComparable.IsExactly(PhysicalCharacteristics, otherT.PhysicalCharacteristics)) return false;
            if (!DeepComparable.IsExactly(LanguageCode, otherT.LanguageCode)) return false;
            if (!DeepComparable.IsExactly(Capability, otherT.Capability)) return false;
            if (!DeepComparable.IsExactly(Property, otherT.Property)) return false;
            if (!DeepComparable.IsExactly(Owner, otherT.Owner)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(OnlineInformationElement, otherT.OnlineInformationElement)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.IsExactly(ParentDevice, otherT.ParentDevice)) return false;
            if (!DeepComparable.IsExactly(Material, otherT.Material)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in UdiDeviceIdentifier) { if (elem != null) yield return elem; }
                if (Manufacturer != null) yield return Manufacturer;
                foreach (var elem in DeviceName) { if (elem != null) yield return elem; }
                if (ModelNumberElement != null) yield return ModelNumberElement;
                if (Type != null) yield return Type;
                foreach (var elem in Specialization) { if (elem != null) yield return elem; }
                foreach (var elem in VersionElement) { if (elem != null) yield return elem; }
                foreach (var elem in Safety) { if (elem != null) yield return elem; }
                foreach (var elem in ShelfLifeStorage) { if (elem != null) yield return elem; }
                if (PhysicalCharacteristics != null) yield return PhysicalCharacteristics;
                foreach (var elem in LanguageCode) { if (elem != null) yield return elem; }
                foreach (var elem in Capability) { if (elem != null) yield return elem; }
                foreach (var elem in Property) { if (elem != null) yield return elem; }
                if (Owner != null) yield return Owner;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (UrlElement != null) yield return UrlElement;
                if (OnlineInformationElement != null) yield return OnlineInformationElement;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                if (Quantity != null) yield return Quantity;
                if (ParentDevice != null) yield return ParentDevice;
                foreach (var elem in Material) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in UdiDeviceIdentifier) { if (elem != null) yield return new ElementValue("udiDeviceIdentifier", elem); }
                if (Manufacturer != null) yield return new ElementValue("manufacturer", Manufacturer);
                foreach (var elem in DeviceName) { if (elem != null) yield return new ElementValue("deviceName", elem); }
                if (ModelNumberElement != null) yield return new ElementValue("modelNumber", ModelNumberElement);
                if (Type != null) yield return new ElementValue("type", Type);
                foreach (var elem in Specialization) { if (elem != null) yield return new ElementValue("specialization", elem); }
                foreach (var elem in VersionElement) { if (elem != null) yield return new ElementValue("version", elem); }
                foreach (var elem in Safety) { if (elem != null) yield return new ElementValue("safety", elem); }
                foreach (var elem in ShelfLifeStorage) { if (elem != null) yield return new ElementValue("shelfLifeStorage", elem); }
                if (PhysicalCharacteristics != null) yield return new ElementValue("physicalCharacteristics", PhysicalCharacteristics);
                foreach (var elem in LanguageCode) { if (elem != null) yield return new ElementValue("languageCode", elem); }
                foreach (var elem in Capability) { if (elem != null) yield return new ElementValue("capability", elem); }
                foreach (var elem in Property) { if (elem != null) yield return new ElementValue("property", elem); }
                if (Owner != null) yield return new ElementValue("owner", Owner);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (OnlineInformationElement != null) yield return new ElementValue("onlineInformation", OnlineInformationElement);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                if (ParentDevice != null) yield return new ElementValue("parentDevice", ParentDevice);
                foreach (var elem in Material) { if (elem != null) yield return new ElementValue("material", elem); }
            }
        }

    }

}
