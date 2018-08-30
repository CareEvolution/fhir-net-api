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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A healthcare consumer's  choices to permit or deny recipients or roles to perform actions for specific purposes and periods of time
    /// </summary>
    [FhirType("Consent", IsResource=true)]
    [DataContract]
    public partial class Consent : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Consent; } }
        [NotMapped]
        public override string TypeName { get { return "Consent"; } }

        /// <summary>
        /// How a rule statement is applied, such as adding additional consent or removing consent
        /// (url: http://hl7.org/fhir/ValueSet/consent-provision-type)
        /// </summary>
        [FhirEnumeration("ConsentProvisionType")]
        public enum ConsentProvisionType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/consent-provision-type)
            /// </summary>
            [EnumLiteral("deny", "http://hl7.org/fhir/consent-provision-type"), Description("Opt Out")]
            Deny,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/consent-provision-type)
            /// </summary>
            [EnumLiteral("permit", "http://hl7.org/fhir/consent-provision-type"), Description("Opt In")]
            Permit,
        }

        /// <summary>
        /// How a resource reference is interpreted when testing consent restrictions
        /// (url: http://hl7.org/fhir/ValueSet/consent-data-meaning)
        /// </summary>
        [FhirEnumeration("ConsentDataMeaning")]
        public enum ConsentDataMeaning
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/consent-data-meaning)
            /// </summary>
            [EnumLiteral("instance", "http://hl7.org/fhir/consent-data-meaning"), Description("Instance")]
            Instance,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/consent-data-meaning)
            /// </summary>
            [EnumLiteral("related", "http://hl7.org/fhir/consent-data-meaning"), Description("Related")]
            Related,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/consent-data-meaning)
            /// </summary>
            [EnumLiteral("dependents", "http://hl7.org/fhir/consent-data-meaning"), Description("Dependents")]
            Dependents,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/consent-data-meaning)
            /// </summary>
            [EnumLiteral("authoredby", "http://hl7.org/fhir/consent-data-meaning"), Description("AuthoredBy")]
            Authoredby,
        }


        [FhirType("PolicyComponent")]
        [DataContract]
        public partial class PolicyComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PolicyComponent"; } }

            /// <summary>
            /// Enforcement source for policy
            /// </summary>
            [FhirElement("authority", Order=40)]
            [DataMember]
            public FhirUri AuthorityElement
            {
                get { return _authorityElement; }
                set { _authorityElement = value; OnPropertyChanged("AuthorityElement"); }
            }

            private FhirUri _authorityElement;

            /// <summary>
            /// Enforcement source for policy
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Authority
            {
                get { return AuthorityElement != null ? AuthorityElement.Value : null; }
                set
                {
                    if (value == null)
                        AuthorityElement = null;
                    else
                        AuthorityElement = new FhirUri(value);
                    OnPropertyChanged("Authority");
                }
            }

            /// <summary>
            /// Specific policy covered by this consent
            /// </summary>
            [FhirElement("uri", Order=50)]
            [DataMember]
            public FhirUri UriElement
            {
                get { return _uriElement; }
                set { _uriElement = value; OnPropertyChanged("UriElement"); }
            }

            private FhirUri _uriElement;

            /// <summary>
            /// Specific policy covered by this consent
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Uri
            {
                get { return UriElement != null ? UriElement.Value : null; }
                set
                {
                    if (value == null)
                        UriElement = null;
                    else
                        UriElement = new FhirUri(value);
                    OnPropertyChanged("Uri");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PolicyComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (AuthorityElement != null) dest.AuthorityElement = (FhirUri)AuthorityElement.DeepCopy();
                    if (UriElement != null) dest.UriElement = (FhirUri)UriElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PolicyComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PolicyComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(AuthorityElement, otherT.AuthorityElement)) return false;
                if (!DeepComparable.Matches(UriElement, otherT.UriElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PolicyComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(AuthorityElement, otherT.AuthorityElement)) return false;
                if (!DeepComparable.IsExactly(UriElement, otherT.UriElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (AuthorityElement != null) yield return AuthorityElement;
                    if (UriElement != null) yield return UriElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (AuthorityElement != null) yield return new ElementValue("authority", AuthorityElement);
                    if (UriElement != null) yield return new ElementValue("uri", UriElement);
                }
            }


        }


        [FhirType("VerificationComponent")]
        [DataContract]
        public partial class VerificationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "VerificationComponent"; } }

            /// <summary>
            /// Has been verified
            /// </summary>
            [FhirElement("verified", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean VerifiedElement
            {
                get { return _verifiedElement; }
                set { _verifiedElement = value; OnPropertyChanged("VerifiedElement"); }
            }

            private FhirBoolean _verifiedElement;

            /// <summary>
            /// Has been verified
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Verified
            {
                get { return VerifiedElement != null ? VerifiedElement.Value : null; }
                set
                {
                    if (value == null)
                        VerifiedElement = null;
                    else
                        VerifiedElement = new FhirBoolean(value);
                    OnPropertyChanged("Verified");
                }
            }

            /// <summary>
            /// Person who verified
            /// </summary>
            [FhirElement("verifiedWith", Order=50)]
            [References("Patient","RelatedPerson")]
            [DataMember]
            public ResourceReference VerifiedWith
            {
                get { return _verifiedWith; }
                set { _verifiedWith = value; OnPropertyChanged("VerifiedWith"); }
            }

            private ResourceReference _verifiedWith;

            /// <summary>
            /// When consent verified
            /// </summary>
            [FhirElement("verificationDate", Order=60)]
            [DataMember]
            public FhirDateTime VerificationDateElement
            {
                get { return _verificationDateElement; }
                set { _verificationDateElement = value; OnPropertyChanged("VerificationDateElement"); }
            }

            private FhirDateTime _verificationDateElement;

            /// <summary>
            /// When consent verified
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string VerificationDate
            {
                get { return VerificationDateElement != null ? VerificationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        VerificationDateElement = null;
                    else
                        VerificationDateElement = new FhirDateTime(value);
                    OnPropertyChanged("VerificationDate");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VerificationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (VerifiedElement != null) dest.VerifiedElement = (FhirBoolean)VerifiedElement.DeepCopy();
                    if (VerifiedWith != null) dest.VerifiedWith = (ResourceReference)VerifiedWith.DeepCopy();
                    if (VerificationDateElement != null) dest.VerificationDateElement = (FhirDateTime)VerificationDateElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new VerificationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VerificationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(VerifiedElement, otherT.VerifiedElement)) return false;
                if (!DeepComparable.Matches(VerifiedWith, otherT.VerifiedWith)) return false;
                if (!DeepComparable.Matches(VerificationDateElement, otherT.VerificationDateElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VerificationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(VerifiedElement, otherT.VerifiedElement)) return false;
                if (!DeepComparable.IsExactly(VerifiedWith, otherT.VerifiedWith)) return false;
                if (!DeepComparable.IsExactly(VerificationDateElement, otherT.VerificationDateElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (VerifiedElement != null) yield return VerifiedElement;
                    if (VerifiedWith != null) yield return VerifiedWith;
                    if (VerificationDateElement != null) yield return VerificationDateElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (VerifiedElement != null) yield return new ElementValue("verified", VerifiedElement);
                    if (VerifiedWith != null) yield return new ElementValue("verifiedWith", VerifiedWith);
                    if (VerificationDateElement != null) yield return new ElementValue("verificationDate", VerificationDateElement);
                }
            }


        }


        [FhirType("provisionComponent")]
        [DataContract]
        public partial class provisionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "provisionComponent"; } }

            /// <summary>
            /// deny | permit
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public Code<ConsentProvisionType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<ConsentProvisionType> _typeElement;

            /// <summary>
            /// deny | permit
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConsentProvisionType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<ConsentProvisionType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Timeframe for this rule
            /// </summary>
            [FhirElement("period", InSummary=true, Order=50)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            /// <summary>
            /// Who|what controlled by this rule (or group, by role)
            /// </summary>
            [FhirElement("actor", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<provisionActorComponent> Actor
            {
                get { if (_actor==null) _actor = new List<provisionActorComponent>(); return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private List<provisionActorComponent> _actor;

            /// <summary>
            /// Actions controlled by this rule
            /// </summary>
            [FhirElement("action", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Action
            {
                get { if (_action==null) _action = new List<CodeableConcept>(); return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private List<CodeableConcept> _action;

            /// <summary>
            /// Security Labels that define affected resources
            /// </summary>
            [FhirElement("securityLabel", InSummary=true, Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> SecurityLabel
            {
                get { if (_securityLabel==null) _securityLabel = new List<Coding>(); return _securityLabel; }
                set { _securityLabel = value; OnPropertyChanged("SecurityLabel"); }
            }

            private List<Coding> _securityLabel;

            /// <summary>
            /// Context of activities covered by this rule
            /// </summary>
            [FhirElement("purpose", InSummary=true, Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Purpose
            {
                get { if (_purpose==null) _purpose = new List<Coding>(); return _purpose; }
                set { _purpose = value; OnPropertyChanged("Purpose"); }
            }

            private List<Coding> _purpose;

            /// <summary>
            /// e.g. Resource Type, Profile, CDA, etc.
            /// </summary>
            [FhirElement("class", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Coding> Class
            {
                get { if (_class==null) _class = new List<Coding>(); return _class; }
                set { _class = value; OnPropertyChanged("Class"); }
            }

            private List<Coding> _class;

            /// <summary>
            /// e.g. LOINC or SNOMED CT code, etc. in the content
            /// </summary>
            [FhirElement("code", InSummary=true, Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Code
            {
                get { if (_code==null) _code = new List<CodeableConcept>(); return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private List<CodeableConcept> _code;

            /// <summary>
            /// Timeframe for data controlled by this rule
            /// </summary>
            [FhirElement("dataPeriod", InSummary=true, Order=120)]
            [DataMember]
            public Period DataPeriod
            {
                get { return _dataPeriod; }
                set { _dataPeriod = value; OnPropertyChanged("DataPeriod"); }
            }

            private Period _dataPeriod;

            /// <summary>
            /// Data controlled by this rule
            /// </summary>
            [FhirElement("data", InSummary=true, Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<provisionDataComponent> Data
            {
                get { if (_data==null) _data = new List<provisionDataComponent>(); return _data; }
                set { _data = value; OnPropertyChanged("Data"); }
            }

            private List<provisionDataComponent> _data;

            /// <summary>
            /// Nested Exception Rules
            /// </summary>
            [FhirElement("provision", Order=140)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<provisionComponent> Provision
            {
                get { if (_provision==null) _provision = new List<provisionComponent>(); return _provision; }
                set { _provision = value; OnPropertyChanged("Provision"); }
            }

            private List<provisionComponent> _provision;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as provisionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<ConsentProvisionType>)TypeElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (Actor != null) dest.Actor = new List<provisionActorComponent>(Actor.DeepCopy());
                    if (Action != null) dest.Action = new List<CodeableConcept>(Action.DeepCopy());
                    if (SecurityLabel != null) dest.SecurityLabel = new List<Coding>(SecurityLabel.DeepCopy());
                    if (Purpose != null) dest.Purpose = new List<Coding>(Purpose.DeepCopy());
                    if (Class != null) dest.Class = new List<Coding>(Class.DeepCopy());
                    if (Code != null) dest.Code = new List<CodeableConcept>(Code.DeepCopy());
                    if (DataPeriod != null) dest.DataPeriod = (Period)DataPeriod.DeepCopy();
                    if (Data != null) dest.Data = new List<provisionDataComponent>(Data.DeepCopy());
                    if (Provision != null) dest.Provision = new List<provisionComponent>(Provision.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new provisionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as provisionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if ( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if ( !DeepComparable.Matches(Action, otherT.Action)) return false;
                if ( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
                if ( !DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
                if ( !DeepComparable.Matches(Class, otherT.Class)) return false;
                if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(DataPeriod, otherT.DataPeriod)) return false;
                if ( !DeepComparable.Matches(Data, otherT.Data)) return false;
                if ( !DeepComparable.Matches(Provision, otherT.Provision)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as provisionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;
                if (!DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
                if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
                if (!DeepComparable.IsExactly(Class, otherT.Class)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(DataPeriod, otherT.DataPeriod)) return false;
                if (!DeepComparable.IsExactly(Data, otherT.Data)) return false;
                if (!DeepComparable.IsExactly(Provision, otherT.Provision)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (Period != null) yield return Period;
                    foreach (var elem in Actor) { if (elem != null) yield return elem; }
                    foreach (var elem in Action) { if (elem != null) yield return elem; }
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
                    foreach (var elem in Purpose) { if (elem != null) yield return elem; }
                    foreach (var elem in Class) { if (elem != null) yield return elem; }
                    foreach (var elem in Code) { if (elem != null) yield return elem; }
                    if (DataPeriod != null) yield return DataPeriod;
                    foreach (var elem in Data) { if (elem != null) yield return elem; }
                    foreach (var elem in Provision) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (Period != null) yield return new ElementValue("period", Period);
                    foreach (var elem in Actor) { if (elem != null) yield return new ElementValue("actor", elem); }
                    foreach (var elem in Action) { if (elem != null) yield return new ElementValue("action", elem); }
                    foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", elem); }
                    foreach (var elem in Purpose) { if (elem != null) yield return new ElementValue("purpose", elem); }
                    foreach (var elem in Class) { if (elem != null) yield return new ElementValue("class", elem); }
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                    if (DataPeriod != null) yield return new ElementValue("dataPeriod", DataPeriod);
                    foreach (var elem in Data) { if (elem != null) yield return new ElementValue("data", elem); }
                    foreach (var elem in Provision) { if (elem != null) yield return new ElementValue("provision", elem); }
                }
            }


        }


        [FhirType("provisionActorComponent")]
        [DataContract]
        public partial class provisionActorComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "provisionActorComponent"; } }

            /// <summary>
            /// How the actor is involved
            /// </summary>
            [FhirElement("role", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            /// <summary>
            /// Resource for the actor (or group, by role)
            /// </summary>
            [FhirElement("reference", Order=50)]
            [References("Device","Group","CareTeam","Organization","Patient","Practitioner","RelatedPerson","PractitionerRole")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as provisionActorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new provisionActorComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as provisionActorComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as provisionActorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                }
            }


        }


        [FhirType("provisionDataComponent")]
        [DataContract]
        public partial class provisionDataComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "provisionDataComponent"; } }

            /// <summary>
            /// instance | related | dependents | authoredby
            /// </summary>
            [FhirElement("meaning", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ConsentDataMeaning> MeaningElement
            {
                get { return _meaningElement; }
                set { _meaningElement = value; OnPropertyChanged("MeaningElement"); }
            }

            private Code<ConsentDataMeaning> _meaningElement;

            /// <summary>
            /// instance | related | dependents | authoredby
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConsentDataMeaning? Meaning
            {
                get { return MeaningElement != null ? MeaningElement.Value : null; }
                set
                {
                    if (value == null)
                        MeaningElement = null;
                    else
                        MeaningElement = new Code<ConsentDataMeaning>(value);
                    OnPropertyChanged("Meaning");
                }
            }

            /// <summary>
            /// The actual data reference
            /// </summary>
            [FhirElement("reference", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as provisionDataComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (MeaningElement != null) dest.MeaningElement = (Code<ConsentDataMeaning>)MeaningElement.DeepCopy();
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new provisionDataComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as provisionDataComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(MeaningElement, otherT.MeaningElement)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as provisionDataComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(MeaningElement, otherT.MeaningElement)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (MeaningElement != null) yield return MeaningElement;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (MeaningElement != null) yield return new ElementValue("meaning", MeaningElement);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                }
            }


        }


        /// <summary>
        /// Identifier for this record (external references)
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
        /// draft | proposed | active | rejected | inactive | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<EventStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<EventStatus> _statusElement;

        /// <summary>
        /// draft | proposed | active | rejected | inactive | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public EventStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<EventStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Which of the four areas this resource covers (extensible)
        /// </summary>
        [FhirElement("scope", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Scope
        {
            get { return _scope; }
            set { _scope = value; OnPropertyChanged("Scope"); }
        }

        private CodeableConcept _scope;

        /// <summary>
        /// Classification of the consent statement - for indexing/retrieval
        /// </summary>
        [FhirElement("category", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// Who the consent applies to
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=130)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// When this Consent was created or indexed
        /// </summary>
        [FhirElement("dateTime", InSummary=true, Order=140)]
        [DataMember]
        public FhirDateTime DateTimeElement
        {
            get { return _dateTimeElement; }
            set { _dateTimeElement = value; OnPropertyChanged("DateTimeElement"); }
        }

        private FhirDateTime _dateTimeElement;

        /// <summary>
        /// When this Consent was created or indexed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DateTime
        {
            get { return DateTimeElement != null ? DateTimeElement.Value : null; }
            set
            {
                if (value == null)
                    DateTimeElement = null;
                else
                    DateTimeElement = new FhirDateTime(value);
                OnPropertyChanged("DateTime");
            }
        }

        /// <summary>
        /// Who is agreeing to the policy and rules
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=150)]
        [References("Organization","Patient","Practitioner","RelatedPerson","PractitionerRole")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Performer
        {
            get { if (_performer==null) _performer = new List<ResourceReference>(); return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private List<ResourceReference> _performer;

        /// <summary>
        /// Custodian of the consent
        /// </summary>
        [FhirElement("organization", InSummary=true, Order=160)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Organization
        {
            get { if (_organization==null) _organization = new List<ResourceReference>(); return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private List<ResourceReference> _organization;

        /// <summary>
        /// Source from which this consent is taken
        /// </summary>
        [FhirElement("source", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Attachment),typeof(Identifier),typeof(ResourceReference))]
        [DataMember]
        public Element Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private Element _source;

        /// <summary>
        /// Policies covered by this consent
        /// </summary>
        [FhirElement("policy", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PolicyComponent> Policy
        {
            get { if (_policy==null) _policy = new List<PolicyComponent>(); return _policy; }
            set { _policy = value; OnPropertyChanged("Policy"); }
        }

        private List<PolicyComponent> _policy;

        /// <summary>
        /// Regulation that this consents to
        /// </summary>
        [FhirElement("policyRule", InSummary=true, Order=190)]
        [DataMember]
        public CodeableConcept PolicyRule
        {
            get { return _policyRule; }
            set { _policyRule = value; OnPropertyChanged("PolicyRule"); }
        }

        private CodeableConcept _policyRule;

        /// <summary>
        /// Consent Verified by patient or family
        /// </summary>
        [FhirElement("verification", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<VerificationComponent> Verification
        {
            get { if (_verification==null) _verification = new List<VerificationComponent>(); return _verification; }
            set { _verification = value; OnPropertyChanged("Verification"); }
        }

        private List<VerificationComponent> _verification;

        /// <summary>
        /// Constraints to the base Consent.policyRule
        /// </summary>
        [FhirElement("provision", InSummary=true, Order=210)]
        [DataMember]
        public provisionComponent Provision
        {
            get { return _provision; }
            set { _provision = value; OnPropertyChanged("Provision"); }
        }

        private provisionComponent _provision;


        public static ElementDefinition.ConstraintComponent Consent_PPC_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "patient.exists() or scope.coding.where(system='something' and code='adr').exists().not()",
            Key = "ppc-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "IF Scope=adr, there must be a patient",
            Xpath = "exists(f:patient) or not(exists(f:scope/f:coding[f:system/@value='something' and f:code/@value='adr')))"
        };

        public static ElementDefinition.ConstraintComponent Consent_PPC_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "patient.exists() or scope.coding.where(system='something' and code='treatment').exists().not()",
            Key = "ppc-5",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "IF Scope=treatment, there must be a patient",
            Xpath = "exists(f:patient) or not(exists(f:scope/f:coding[f:system/@value='something' and f:code/@value='treatment')))"
        };

        public static ElementDefinition.ConstraintComponent Consent_PPC_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "patient.exists() or scope.coding.where(system='something' and code='patient-privacy').exists().not()",
            Key = "ppc-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "IF Scope=privacy, there must be a patient",
            Xpath = "exists(f:patient) or not(exists(f:scope/f:coding[f:system/@value='something' and f:code/@value='patient-privacy')))"
        };

        public static ElementDefinition.ConstraintComponent Consent_PPC_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "patient.exists() or scope.coding.where(system='something' and code='research').exists().not()",
            Key = "ppc-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "IF Scope=research, there must be a patient",
            Xpath = "exists(f:patient) or not(exists(f:scope/f:coding[f:system/@value='something' and f:code/@value='research')))"
        };

        public static ElementDefinition.ConstraintComponent Consent_PPC_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "policy.exists() or policyRule.exists()",
            Key = "ppc-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Either a Policy or PolicyRule",
            Xpath = "exists(f:policy) or exists(f:policyRule)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Consent_PPC_4);
            InvariantConstraints.Add(Consent_PPC_5);
            InvariantConstraints.Add(Consent_PPC_2);
            InvariantConstraints.Add(Consent_PPC_3);
            InvariantConstraints.Add(Consent_PPC_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Consent;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<EventStatus>)StatusElement.DeepCopy();
                if (Scope != null) dest.Scope = (CodeableConcept)Scope.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (DateTimeElement != null) dest.DateTimeElement = (FhirDateTime)DateTimeElement.DeepCopy();
                if (Performer != null) dest.Performer = new List<ResourceReference>(Performer.DeepCopy());
                if (Organization != null) dest.Organization = new List<ResourceReference>(Organization.DeepCopy());
                if (Source != null) dest.Source = (Element)Source.DeepCopy();
                if (Policy != null) dest.Policy = new List<PolicyComponent>(Policy.DeepCopy());
                if (PolicyRule != null) dest.PolicyRule = (CodeableConcept)PolicyRule.DeepCopy();
                if (Verification != null) dest.Verification = new List<VerificationComponent>(Verification.DeepCopy());
                if (Provision != null) dest.Provision = (provisionComponent)Provision.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Consent());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Consent;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Scope, otherT.Scope)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(DateTimeElement, otherT.DateTimeElement)) return false;
            if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if ( !DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if ( !DeepComparable.Matches(Policy, otherT.Policy)) return false;
            if (!DeepComparable.Matches(PolicyRule, otherT.PolicyRule)) return false;
            if ( !DeepComparable.Matches(Verification, otherT.Verification)) return false;
            if (!DeepComparable.Matches(Provision, otherT.Provision)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Consent;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Scope, otherT.Scope)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(DateTimeElement, otherT.DateTimeElement)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Policy, otherT.Policy)) return false;
            if (!DeepComparable.IsExactly(PolicyRule, otherT.PolicyRule)) return false;
            if (!DeepComparable.IsExactly(Verification, otherT.Verification)) return false;
            if (!DeepComparable.IsExactly(Provision, otherT.Provision)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (Scope != null) yield return Scope;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
                if (DateTimeElement != null) yield return DateTimeElement;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                foreach (var elem in Organization) { if (elem != null) yield return elem; }
                if (Source != null) yield return Source;
                foreach (var elem in Policy) { if (elem != null) yield return elem; }
                if (PolicyRule != null) yield return PolicyRule;
                foreach (var elem in Verification) { if (elem != null) yield return elem; }
                if (Provision != null) yield return Provision;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Scope != null) yield return new ElementValue("scope", Scope);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (DateTimeElement != null) yield return new ElementValue("dateTime", DateTimeElement);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                foreach (var elem in Organization) { if (elem != null) yield return new ElementValue("organization", elem); }
                if (Source != null) yield return new ElementValue("source", Source);
                foreach (var elem in Policy) { if (elem != null) yield return new ElementValue("policy", elem); }
                if (PolicyRule != null) yield return new ElementValue("policyRule", PolicyRule);
                foreach (var elem in Verification) { if (elem != null) yield return new ElementValue("verification", elem); }
                if (Provision != null) yield return new ElementValue("provision", Provision);
            }
        }

    }

}
