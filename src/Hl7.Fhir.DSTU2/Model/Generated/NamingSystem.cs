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
    /// System of unique identification
    /// </summary>
    [FhirType("NamingSystem", IsResource=true)]
    [DataContract]
    public partial class NamingSystem : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.NamingSystem; } }
        [NotMapped]
        public override string TypeName { get { return "NamingSystem"; } }

        /// <summary>
        /// Identifies the purpose of the naming system.
        /// (url: http://hl7.org/fhir/ValueSet/namingsystem-type)
        /// </summary>
        [FhirEnumeration("NamingSystemType")]
        public enum NamingSystemType
        {
            /// <summary>
            /// The naming system is used to define concepts and symbols to represent those concepts; e.g. UCUM, LOINC, NDC code, local lab codes, etc.
            /// (system: http://hl7.org/fhir/namingsystem-type)
            /// </summary>
            [EnumLiteral("codesystem", "http://hl7.org/fhir/namingsystem-type"), Description("Code System")]
            Codesystem,
            /// <summary>
            /// The naming system is used to manage identifiers (e.g. license numbers, order numbers, etc.).
            /// (system: http://hl7.org/fhir/namingsystem-type)
            /// </summary>
            [EnumLiteral("identifier", "http://hl7.org/fhir/namingsystem-type"), Description("Identifier")]
            Identifier,
            /// <summary>
            /// The naming system is used as the root for other identifiers and naming systems.
            /// (system: http://hl7.org/fhir/namingsystem-type)
            /// </summary>
            [EnumLiteral("root", "http://hl7.org/fhir/namingsystem-type"), Description("Root")]
            Root,
        }

        /// <summary>
        /// Identifies the style of unique identifier used to identify a namespace.
        /// (url: http://hl7.org/fhir/ValueSet/namingsystem-identifier-type)
        /// </summary>
        [FhirEnumeration("NamingSystemIdentifierType")]
        public enum NamingSystemIdentifierType
        {
            /// <summary>
            /// An ISO object identifier; e.g. 1.2.3.4.5.
            /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
            /// </summary>
            [EnumLiteral("oid", "http://hl7.org/fhir/namingsystem-identifier-type"), Description("OID")]
            Oid,
            /// <summary>
            /// A universally unique identifier of the form a5afddf4-e880-459b-876e-e4591b0acc11.
            /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
            /// </summary>
            [EnumLiteral("uuid", "http://hl7.org/fhir/namingsystem-identifier-type"), Description("UUID")]
            Uuid,
            /// <summary>
            /// A uniform resource identifier (ideally a URL - uniform resource locator); e.g. http://unitsofmeasure.org.
            /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
            /// </summary>
            [EnumLiteral("uri", "http://hl7.org/fhir/namingsystem-identifier-type"), Description("URI")]
            Uri,
            /// <summary>
            /// Some other type of unique identifier; e.g. HL7-assigned reserved string such as LN for LOINC.
            /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
            /// </summary>
            [EnumLiteral("other", "http://hl7.org/fhir/namingsystem-identifier-type"), Description("Other")]
            Other,
        }


        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }

            /// <summary>
            /// Name of a individual to contact
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name of a individual to contact
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
            /// Contact details for individual or publisher
            /// </summary>
            [FhirElement("telecom", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContactPoint> Telecom
            {
                get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
                set { _telecom = value; OnPropertyChanged("Telecom"); }
            }

            private List<ContactPoint> _telecom;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
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
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                }
            }


        }


        [FhirType("UniqueIdComponent")]
        [DataContract]
        public partial class UniqueIdComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "UniqueIdComponent"; } }

            /// <summary>
            /// oid | uuid | uri | other
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<NamingSystemIdentifierType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<NamingSystemIdentifierType> _typeElement;

            /// <summary>
            /// oid | uuid | uri | other
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public NamingSystemIdentifierType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<NamingSystemIdentifierType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// The unique identifier
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// The unique identifier
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

            /// <summary>
            /// Is this the id that should be used for this type
            /// </summary>
            [FhirElement("preferred", Order=60)]
            [DataMember]
            public FhirBoolean PreferredElement
            {
                get { return _preferredElement; }
                set { _preferredElement = value; OnPropertyChanged("PreferredElement"); }
            }

            private FhirBoolean _preferredElement;

            /// <summary>
            /// Is this the id that should be used for this type
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

            /// <summary>
            /// When is identifier valid?
            /// </summary>
            [FhirElement("period", Order=70)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as UniqueIdComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<NamingSystemIdentifierType>)TypeElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    if (PreferredElement != null) dest.PreferredElement = (FhirBoolean)PreferredElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new UniqueIdComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as UniqueIdComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.Matches(PreferredElement, otherT.PreferredElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as UniqueIdComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.IsExactly(PreferredElement, otherT.PreferredElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (ValueElement != null) yield return ValueElement;
                    if (PreferredElement != null) yield return PreferredElement;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                    if (PreferredElement != null) yield return new ElementValue("preferred", PreferredElement);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }


        }


        /// <summary>
        /// Human-readable label
        /// </summary>
        [FhirElement("name", Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Human-readable label
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
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ConformanceResourceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ConformanceResourceStatus> _statusElement;

        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConformanceResourceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ConformanceResourceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// codesystem | identifier | root
        /// </summary>
        [FhirElement("kind", Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<NamingSystemType> KindElement
        {
            get { return _kindElement; }
            set { _kindElement = value; OnPropertyChanged("KindElement"); }
        }

        private Code<NamingSystemType> _kindElement;

        /// <summary>
        /// codesystem | identifier | root
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public NamingSystemType? Kind
        {
            get { return KindElement != null ? KindElement.Value : null; }
            set
            {
                if (value == null)
                    KindElement = null;
                else
                    KindElement = new Code<NamingSystemType>(value);
                OnPropertyChanged("Kind");
            }
        }

        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=120)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (Organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                    PublisherElement = null;
                else
                    PublisherElement = new FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }

        /// <summary>
        /// Contact details of the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact==null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// Who maintains system namespace?
        /// </summary>
        [FhirElement("responsible", Order=140)]
        [DataMember]
        public FhirString ResponsibleElement
        {
            get { return _responsibleElement; }
            set { _responsibleElement = value; OnPropertyChanged("ResponsibleElement"); }
        }

        private FhirString _responsibleElement;

        /// <summary>
        /// Who maintains system namespace?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Responsible
        {
            get { return ResponsibleElement != null ? ResponsibleElement.Value : null; }
            set
            {
                if (value == null)
                    ResponsibleElement = null;
                else
                    ResponsibleElement = new FhirString(value);
                OnPropertyChanged("Responsible");
            }
        }

        /// <summary>
        /// Publication Date(/time)
        /// </summary>
        [FhirElement("date", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Publication Date(/time)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// e.g. driver,  provider,  patient, bank etc.
        /// </summary>
        [FhirElement("type", Order=160)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// What does naming system identify?
        /// </summary>
        [FhirElement("description", Order=170)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// What does naming system identify?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new FhirString(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Content intends to support these contexts
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> UseContext
        {
            get { if (_useContext==null) _useContext = new List<CodeableConcept>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<CodeableConcept> _useContext;

        /// <summary>
        /// How/where is it used
        /// </summary>
        [FhirElement("usage", Order=190)]
        [DataMember]
        public FhirString UsageElement
        {
            get { return _usageElement; }
            set { _usageElement = value; OnPropertyChanged("UsageElement"); }
        }

        private FhirString _usageElement;

        /// <summary>
        /// How/where is it used
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Usage
        {
            get { return UsageElement != null ? UsageElement.Value : null; }
            set
            {
                if (value == null)
                    UsageElement = null;
                else
                    UsageElement = new FhirString(value);
                OnPropertyChanged("Usage");
            }
        }

        /// <summary>
        /// Unique identifiers used for system
        /// </summary>
        [FhirElement("uniqueId", Order=200)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<UniqueIdComponent> UniqueId
        {
            get { if (_uniqueId==null) _uniqueId = new List<UniqueIdComponent>(); return _uniqueId; }
            set { _uniqueId = value; OnPropertyChanged("UniqueId"); }
        }

        private List<UniqueIdComponent> _uniqueId;

        /// <summary>
        /// Use this instead
        /// </summary>
        [FhirElement("replacedBy", Order=210)]
        [References("NamingSystem")]
        [DataMember]
        public ResourceReference ReplacedBy
        {
            get { return _replacedBy; }
            set { _replacedBy = value; OnPropertyChanged("ReplacedBy"); }
        }

        private ResourceReference _replacedBy;


        public static ElementDefinition.ConstraintComponent NamingSystem_NSD_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "uniqueId.where(preferred = true).select(type).isDistinct()",
            Key = "nsd-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Can't have more than one preferred identifier for a type",
            Xpath = "not(exists(for $type in distinct-values(f:uniqueId/f:type/@value) return if (count(f:uniqueId[f:type/@value=$type and f:preferred/@value=true()])>1) then $type else ()))"
        };

        public static ElementDefinition.ConstraintComponent NamingSystem_NSD_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "replacedBy.empty() or status = 'retired'",
            Key = "nsd-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Can only have replacedBy if naming system is retired",
            Xpath = "not(f:replacedBy) or f:status/@value='retired'"
        };

        public static ElementDefinition.ConstraintComponent NamingSystem_NSD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "kind != 'root' or uniqueId in ('uuid' | 'ruid')",
            Key = "nsd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Root systems cannot have uuid or sid identifiers",
            Xpath = "not(f:kind/@value='root' and f:uniqueId/f:type/@value=('uuid', 'ruid'))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(NamingSystem_NSD_2);
            InvariantConstraints.Add(NamingSystem_NSD_3);
            InvariantConstraints.Add(NamingSystem_NSD_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as NamingSystem;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ConformanceResourceStatus>)StatusElement.DeepCopy();
                if (KindElement != null) dest.KindElement = (Code<NamingSystemType>)KindElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (ResponsibleElement != null) dest.ResponsibleElement = (FhirString)ResponsibleElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<CodeableConcept>(UseContext.DeepCopy());
                if (UsageElement != null) dest.UsageElement = (FhirString)UsageElement.DeepCopy();
                if (UniqueId != null) dest.UniqueId = new List<UniqueIdComponent>(UniqueId.DeepCopy());
                if (ReplacedBy != null) dest.ReplacedBy = (ResourceReference)ReplacedBy.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new NamingSystem());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as NamingSystem;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(ResponsibleElement, otherT.ResponsibleElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.Matches(UsageElement, otherT.UsageElement)) return false;
            if ( !DeepComparable.Matches(UniqueId, otherT.UniqueId)) return false;
            if (!DeepComparable.Matches(ReplacedBy, otherT.ReplacedBy)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as NamingSystem;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(KindElement, otherT.KindElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(ResponsibleElement, otherT.ResponsibleElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.IsExactly(UniqueId, otherT.UniqueId)) return false;
            if (!DeepComparable.IsExactly(ReplacedBy, otherT.ReplacedBy)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (NameElement != null) yield return NameElement;
                if (StatusElement != null) yield return StatusElement;
                if (KindElement != null) yield return KindElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (ResponsibleElement != null) yield return ResponsibleElement;
                if (DateElement != null) yield return DateElement;
                if (Type != null) yield return Type;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                if (UsageElement != null) yield return UsageElement;
                foreach (var elem in UniqueId) { if (elem != null) yield return elem; }
                if (ReplacedBy != null) yield return ReplacedBy;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (KindElement != null) yield return new ElementValue("kind", KindElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (ResponsibleElement != null) yield return new ElementValue("responsible", ResponsibleElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                if (UsageElement != null) yield return new ElementValue("usage", UsageElement);
                foreach (var elem in UniqueId) { if (elem != null) yield return new ElementValue("uniqueId", elem); }
                if (ReplacedBy != null) yield return new ElementValue("replacedBy", ReplacedBy);
            }
        }

    }

}
