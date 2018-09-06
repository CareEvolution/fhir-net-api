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
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/namingsystem-type)
            /// </summary>
            [EnumLiteral("codesystem", "http://hl7.org/fhir/namingsystem-type"), Description("Code System")]
            Codesystem,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/namingsystem-type)
            /// </summary>
            [EnumLiteral("identifier", "http://hl7.org/fhir/namingsystem-type"), Description("Identifier")]
            Identifier,
            /// <summary>
            /// MISSING DESCRIPTION
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
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
            /// </summary>
            [EnumLiteral("oid", "http://hl7.org/fhir/namingsystem-identifier-type"), Description("OID")]
            Oid,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
            /// </summary>
            [EnumLiteral("uuid", "http://hl7.org/fhir/namingsystem-identifier-type"), Description("UUID")]
            Uuid,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
            /// </summary>
            [EnumLiteral("uri", "http://hl7.org/fhir/namingsystem-identifier-type"), Description("URI")]
            Uri,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/namingsystem-identifier-type)
            /// </summary>
            [EnumLiteral("other", "http://hl7.org/fhir/namingsystem-identifier-type"), Description("Other")]
            Other,
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
            [FhirElement("type", InSummary=true, Order=40)]
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
            [FhirElement("value", InSummary=true, Order=50)]
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
            /// Notes about identifier usage
            /// </summary>
            [FhirElement("comment", Order=70)]
            [DataMember]
            public FhirString CommentElement
            {
                get { return _commentElement; }
                set { _commentElement = value; OnPropertyChanged("CommentElement"); }
            }

            private FhirString _commentElement;

            /// <summary>
            /// Notes about identifier usage
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Comment
            {
                get { return CommentElement != null ? CommentElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentElement = null;
                    else
                        CommentElement = new FhirString(value);
                    OnPropertyChanged("Comment");
                }
            }

            /// <summary>
            /// When is identifier valid?
            /// </summary>
            [FhirElement("period", Order=80)]
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
                    if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
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
                if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
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
                if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
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
                    if (CommentElement != null) yield return CommentElement;
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
                    if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }


        }


        /// <summary>
        /// Name for this naming system (computer friendly)
        /// </summary>
        [FhirElement("name", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Name for this naming system (computer friendly)
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
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<PublicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<PublicationStatus> _statusElement;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// codesystem | identifier | root
        /// </summary>
        [FhirElement("kind", InSummary=true, Order=110)]
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
        /// Date last changed
        /// </summary>
        [FhirElement("date", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date last changed
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
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=130)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (organization or individual)
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
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Who maintains system namespace?
        /// </summary>
        [FhirElement("responsible", Order=150)]
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
        /// Natural language description of the naming system
        /// </summary>
        [FhirElement("description", Order=170)]
        [DataMember]
        public Markdown DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private Markdown _descriptionElement;

        /// <summary>
        /// Natural language description of the naming system
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
                    DescriptionElement = new Markdown(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for naming system (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// How/where is it used
        /// </summary>
        [FhirElement("usage", Order=200)]
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
        [FhirElement("uniqueId", InSummary=true, Order=210)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<UniqueIdComponent> UniqueId
        {
            get { if (_uniqueId==null) _uniqueId = new List<UniqueIdComponent>(); return _uniqueId; }
            set { _uniqueId = value; OnPropertyChanged("UniqueId"); }
        }

        private List<UniqueIdComponent> _uniqueId;


        public static ElementDefinition.ConstraintComponent NamingSystem_NSD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "kind != 'root' or uniqueId.all(type != 'uuid')",
            Key = "nsd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Root systems cannot have uuid identifiers",
            Xpath = "not(f:kind/@value='root' and f:uniqueId/f:type/@value='uuid')"
        };

        public static ElementDefinition.ConstraintComponent NamingSystem_NSD_0 = new ElementDefinition.ConstraintComponent
        {
            Expression = "name.matches('[A-Z]([A-Za-z0-9_]){0,254}')",
            Key = "nsd-0",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Name should be usable as an identifier for the module by machine processing applications such as code generation",
            Xpath = "not(exists(f:name/@value)) or matches(f:name/@value, '[A-Z]([A-Za-z0-9_]){0,254}')"
        };

        public static ElementDefinition.ConstraintComponent NamingSystem_NSD_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "uniqueId.where(preferred = true).select(type).isDistinct()",
            Key = "nsd-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Can't have more than one preferred identifier for a type",
            Xpath = "not(exists(for $type in distinct-values(f:uniqueId/f:type/@value) return if (count(f:uniqueId[f:type/@value=$type and f:preferred/@value=true()])>1) then $type else ()))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(NamingSystem_NSD_1);
            InvariantConstraints.Add(NamingSystem_NSD_0);
            InvariantConstraints.Add(NamingSystem_NSD_2);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as NamingSystem;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (KindElement != null) dest.KindElement = (Code<NamingSystemType>)KindElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (ResponsibleElement != null) dest.ResponsibleElement = (FhirString)ResponsibleElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (Markdown)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (UsageElement != null) dest.UsageElement = (FhirString)UsageElement.DeepCopy();
                if (UniqueId != null) dest.UniqueId = new List<UniqueIdComponent>(UniqueId.DeepCopy());
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
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(ResponsibleElement, otherT.ResponsibleElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(UsageElement, otherT.UsageElement)) return false;
            if ( !DeepComparable.Matches(UniqueId, otherT.UniqueId)) return false;

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
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(ResponsibleElement, otherT.ResponsibleElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(UsageElement, otherT.UsageElement)) return false;
            if (!DeepComparable.IsExactly(UniqueId, otherT.UniqueId)) return false;

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
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (ResponsibleElement != null) yield return ResponsibleElement;
                if (Type != null) yield return Type;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (UsageElement != null) yield return UsageElement;
                foreach (var elem in UniqueId) { if (elem != null) yield return elem; }
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
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (ResponsibleElement != null) yield return new ElementValue("responsible", ResponsibleElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (UsageElement != null) yield return new ElementValue("usage", UsageElement);
                foreach (var elem in UniqueId) { if (elem != null) yield return new ElementValue("uniqueId", elem); }
            }
        }

    }

}
