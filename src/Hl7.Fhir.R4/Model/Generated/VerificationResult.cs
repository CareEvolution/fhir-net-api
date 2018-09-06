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
    /// Describes validation requirements, source(s), status and dates for one or more elements
    /// </summary>
    [FhirType("VerificationResult", IsResource=true)]
    [DataContract]
    public partial class VerificationResult : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.VerificationResult; } }
        [NotMapped]
        public override string TypeName { get { return "VerificationResult"; } }

        /// <summary>
        /// The validation status of the target
        /// (url: http://hl7.org/fhir/ValueSet/verificationresult-status)
        /// </summary>
        [FhirEnumeration("status")]
        public enum status
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/CodeSystem/status)
            /// </summary>
            [EnumLiteral("attested", "http://hl7.org/fhir/CodeSystem/status"), Description("Attested")]
            Attested,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/CodeSystem/status)
            /// </summary>
            [EnumLiteral("validated", "http://hl7.org/fhir/CodeSystem/status"), Description("Validated")]
            Validated,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/CodeSystem/status)
            /// </summary>
            [EnumLiteral("in-process", "http://hl7.org/fhir/CodeSystem/status"), Description("In process")]
            InProcess,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/CodeSystem/status)
            /// </summary>
            [EnumLiteral("req-revalid", "http://hl7.org/fhir/CodeSystem/status"), Description("Requires revalidation")]
            ReqRevalid,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/CodeSystem/status)
            /// </summary>
            [EnumLiteral("val-fail", "http://hl7.org/fhir/CodeSystem/status"), Description("Validation failed")]
            ValFail,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/CodeSystem/status)
            /// </summary>
            [EnumLiteral("reval-fail", "http://hl7.org/fhir/CodeSystem/status"), Description("Re-Validation failed")]
            RevalFail,
        }


        [FhirType("PrimarySourceComponent")]
        [DataContract]
        public partial class PrimarySourceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PrimarySourceComponent"; } }

            /// <summary>
            /// Reference to the primary source
            /// </summary>
            [FhirElement("organization", Order=40)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Organization
            {
                get { return _organization; }
                set { _organization = value; OnPropertyChanged("Organization"); }
            }

            private ResourceReference _organization;

            /// <summary>
            /// Type of primary source (License Board; Primary Education; Continuing Education; Postal Service; Relationship owner; Registration Authority; legal source; issuing source; authoritative source)
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Type
            {
                get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private List<CodeableConcept> _type;

            /// <summary>
            /// The process(es) by which the target is validated
            /// </summary>
            [FhirElement("validationProcess", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ValidationProcess
            {
                get { if (_validationProcess==null) _validationProcess = new List<CodeableConcept>(); return _validationProcess; }
                set { _validationProcess = value; OnPropertyChanged("ValidationProcess"); }
            }

            private List<CodeableConcept> _validationProcess;

            /// <summary>
            /// successful | failed | unknown
            /// </summary>
            [FhirElement("validationStatus", Order=70)]
            [DataMember]
            public CodeableConcept ValidationStatus
            {
                get { return _validationStatus; }
                set { _validationStatus = value; OnPropertyChanged("ValidationStatus"); }
            }

            private CodeableConcept _validationStatus;

            /// <summary>
            /// When the target was validated against the primary source
            /// </summary>
            [FhirElement("validationDate", Order=80)]
            [DataMember]
            public FhirDateTime ValidationDateElement
            {
                get { return _validationDateElement; }
                set { _validationDateElement = value; OnPropertyChanged("ValidationDateElement"); }
            }

            private FhirDateTime _validationDateElement;

            /// <summary>
            /// When the target was validated against the primary source
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ValidationDate
            {
                get { return ValidationDateElement != null ? ValidationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        ValidationDateElement = null;
                    else
                        ValidationDateElement = new FhirDateTime(value);
                    OnPropertyChanged("ValidationDate");
                }
            }

            /// <summary>
            /// yes | no | undetermined
            /// </summary>
            [FhirElement("canPushUpdates", InSummary=true, Order=90)]
            [DataMember]
            public CodeableConcept CanPushUpdates
            {
                get { return _canPushUpdates; }
                set { _canPushUpdates = value; OnPropertyChanged("CanPushUpdates"); }
            }

            private CodeableConcept _canPushUpdates;

            /// <summary>
            /// specific | any | source
            /// </summary>
            [FhirElement("pushTypeAvailable", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> PushTypeAvailable
            {
                get { if (_pushTypeAvailable==null) _pushTypeAvailable = new List<CodeableConcept>(); return _pushTypeAvailable; }
                set { _pushTypeAvailable = value; OnPropertyChanged("PushTypeAvailable"); }
            }

            private List<CodeableConcept> _pushTypeAvailable;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PrimarySourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                    if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                    if (ValidationProcess != null) dest.ValidationProcess = new List<CodeableConcept>(ValidationProcess.DeepCopy());
                    if (ValidationStatus != null) dest.ValidationStatus = (CodeableConcept)ValidationStatus.DeepCopy();
                    if (ValidationDateElement != null) dest.ValidationDateElement = (FhirDateTime)ValidationDateElement.DeepCopy();
                    if (CanPushUpdates != null) dest.CanPushUpdates = (CodeableConcept)CanPushUpdates.DeepCopy();
                    if (PushTypeAvailable != null) dest.PushTypeAvailable = new List<CodeableConcept>(PushTypeAvailable.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PrimarySourceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PrimarySourceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
                if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(ValidationProcess, otherT.ValidationProcess)) return false;
                if (!DeepComparable.Matches(ValidationStatus, otherT.ValidationStatus)) return false;
                if (!DeepComparable.Matches(ValidationDateElement, otherT.ValidationDateElement)) return false;
                if (!DeepComparable.Matches(CanPushUpdates, otherT.CanPushUpdates)) return false;
                if ( !DeepComparable.Matches(PushTypeAvailable, otherT.PushTypeAvailable)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PrimarySourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(ValidationProcess, otherT.ValidationProcess)) return false;
                if (!DeepComparable.IsExactly(ValidationStatus, otherT.ValidationStatus)) return false;
                if (!DeepComparable.IsExactly(ValidationDateElement, otherT.ValidationDateElement)) return false;
                if (!DeepComparable.IsExactly(CanPushUpdates, otherT.CanPushUpdates)) return false;
                if (!DeepComparable.IsExactly(PushTypeAvailable, otherT.PushTypeAvailable)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Organization != null) yield return Organization;
                    foreach (var elem in Type) { if (elem != null) yield return elem; }
                    foreach (var elem in ValidationProcess) { if (elem != null) yield return elem; }
                    if (ValidationStatus != null) yield return ValidationStatus;
                    if (ValidationDateElement != null) yield return ValidationDateElement;
                    if (CanPushUpdates != null) yield return CanPushUpdates;
                    foreach (var elem in PushTypeAvailable) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Organization != null) yield return new ElementValue("organization", Organization);
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                    foreach (var elem in ValidationProcess) { if (elem != null) yield return new ElementValue("validationProcess", elem); }
                    if (ValidationStatus != null) yield return new ElementValue("validationStatus", ValidationStatus);
                    if (ValidationDateElement != null) yield return new ElementValue("validationDate", ValidationDateElement);
                    if (CanPushUpdates != null) yield return new ElementValue("canPushUpdates", CanPushUpdates);
                    foreach (var elem in PushTypeAvailable) { if (elem != null) yield return new ElementValue("pushTypeAvailable", elem); }
                }
            }


        }


        [FhirType("AttestationComponent")]
        [DataContract]
        public partial class AttestationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AttestationComponent"; } }

            /// <summary>
            /// The individual attesting to information
            /// </summary>
            [FhirElement("source", InSummary=true, Order=40)]
            [References("Practitioner")]
            [DataMember]
            public ResourceReference Source
            {
                get { return _source; }
                set { _source = value; OnPropertyChanged("Source"); }
            }

            private ResourceReference _source;

            /// <summary>
            /// The organization attesting to information
            /// </summary>
            [FhirElement("organization", InSummary=true, Order=50)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Organization
            {
                get { return _organization; }
                set { _organization = value; OnPropertyChanged("Organization"); }
            }

            private ResourceReference _organization;

            /// <summary>
            /// Who is providing the attested information (owner; authorized representative; authorized intermediary; non-authorized source)
            /// </summary>
            [FhirElement("method", InSummary=true, Order=60)]
            [DataMember]
            public CodeableConcept Method
            {
                get { return _method; }
                set { _method = value; OnPropertyChanged("Method"); }
            }

            private CodeableConcept _method;

            /// <summary>
            /// The date the information was attested to
            /// </summary>
            [FhirElement("date", InSummary=true, Order=70)]
            [DataMember]
            public Date DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private Date _dateElement;

            /// <summary>
            /// The date the information was attested to
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
                        DateElement = new Date(value);
                    OnPropertyChanged("Date");
                }
            }

            /// <summary>
            /// A digital identity certificate associated with the attestation source
            /// </summary>
            [FhirElement("sourceIdentityCertificate", Order=80)]
            [DataMember]
            public FhirString SourceIdentityCertificateElement
            {
                get { return _sourceIdentityCertificateElement; }
                set { _sourceIdentityCertificateElement = value; OnPropertyChanged("SourceIdentityCertificateElement"); }
            }

            private FhirString _sourceIdentityCertificateElement;

            /// <summary>
            /// A digital identity certificate associated with the attestation source
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SourceIdentityCertificate
            {
                get { return SourceIdentityCertificateElement != null ? SourceIdentityCertificateElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceIdentityCertificateElement = null;
                    else
                        SourceIdentityCertificateElement = new FhirString(value);
                    OnPropertyChanged("SourceIdentityCertificate");
                }
            }

            /// <summary>
            /// A digital identity certificate associated with the proxy entity submitting attested information on behalf of the attestation source
            /// </summary>
            [FhirElement("proxyIdentityCertificate", Order=90)]
            [DataMember]
            public FhirString ProxyIdentityCertificateElement
            {
                get { return _proxyIdentityCertificateElement; }
                set { _proxyIdentityCertificateElement = value; OnPropertyChanged("ProxyIdentityCertificateElement"); }
            }

            private FhirString _proxyIdentityCertificateElement;

            /// <summary>
            /// A digital identity certificate associated with the proxy entity submitting attested information on behalf of the attestation source
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ProxyIdentityCertificate
            {
                get { return ProxyIdentityCertificateElement != null ? ProxyIdentityCertificateElement.Value : null; }
                set
                {
                    if (value == null)
                        ProxyIdentityCertificateElement = null;
                    else
                        ProxyIdentityCertificateElement = new FhirString(value);
                    OnPropertyChanged("ProxyIdentityCertificate");
                }
            }

            /// <summary>
            /// Proxy signature
            /// </summary>
            [FhirElement("signedProxyRight", Order=100, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirString),typeof(FhirUri))]
            [DataMember]
            public Element SignedProxyRight
            {
                get { return _signedProxyRight; }
                set { _signedProxyRight = value; OnPropertyChanged("SignedProxyRight"); }
            }

            private Element _signedProxyRight;

            /// <summary>
            /// Attester signature
            /// </summary>
            [FhirElement("signedSourceAttestation", Order=110, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirString),typeof(FhirUri))]
            [DataMember]
            public Element SignedSourceAttestation
            {
                get { return _signedSourceAttestation; }
                set { _signedSourceAttestation = value; OnPropertyChanged("SignedSourceAttestation"); }
            }

            private Element _signedSourceAttestation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AttestationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Source != null) dest.Source = (ResourceReference)Source.DeepCopy();
                    if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                    if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                    if (DateElement != null) dest.DateElement = (Date)DateElement.DeepCopy();
                    if (SourceIdentityCertificateElement != null) dest.SourceIdentityCertificateElement = (FhirString)SourceIdentityCertificateElement.DeepCopy();
                    if (ProxyIdentityCertificateElement != null) dest.ProxyIdentityCertificateElement = (FhirString)ProxyIdentityCertificateElement.DeepCopy();
                    if (SignedProxyRight != null) dest.SignedProxyRight = (Element)SignedProxyRight.DeepCopy();
                    if (SignedSourceAttestation != null) dest.SignedSourceAttestation = (Element)SignedSourceAttestation.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AttestationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AttestationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Source, otherT.Source)) return false;
                if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
                if (!DeepComparable.Matches(Method, otherT.Method)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(SourceIdentityCertificateElement, otherT.SourceIdentityCertificateElement)) return false;
                if (!DeepComparable.Matches(ProxyIdentityCertificateElement, otherT.ProxyIdentityCertificateElement)) return false;
                if (!DeepComparable.Matches(SignedProxyRight, otherT.SignedProxyRight)) return false;
                if (!DeepComparable.Matches(SignedSourceAttestation, otherT.SignedSourceAttestation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AttestationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
                if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
                if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(SourceIdentityCertificateElement, otherT.SourceIdentityCertificateElement)) return false;
                if (!DeepComparable.IsExactly(ProxyIdentityCertificateElement, otherT.ProxyIdentityCertificateElement)) return false;
                if (!DeepComparable.IsExactly(SignedProxyRight, otherT.SignedProxyRight)) return false;
                if (!DeepComparable.IsExactly(SignedSourceAttestation, otherT.SignedSourceAttestation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Source != null) yield return Source;
                    if (Organization != null) yield return Organization;
                    if (Method != null) yield return Method;
                    if (DateElement != null) yield return DateElement;
                    if (SourceIdentityCertificateElement != null) yield return SourceIdentityCertificateElement;
                    if (ProxyIdentityCertificateElement != null) yield return ProxyIdentityCertificateElement;
                    if (SignedProxyRight != null) yield return SignedProxyRight;
                    if (SignedSourceAttestation != null) yield return SignedSourceAttestation;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Source != null) yield return new ElementValue("source", Source);
                    if (Organization != null) yield return new ElementValue("organization", Organization);
                    if (Method != null) yield return new ElementValue("method", Method);
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                    if (SourceIdentityCertificateElement != null) yield return new ElementValue("sourceIdentityCertificate", SourceIdentityCertificateElement);
                    if (ProxyIdentityCertificateElement != null) yield return new ElementValue("proxyIdentityCertificate", ProxyIdentityCertificateElement);
                    if (SignedProxyRight != null) yield return new ElementValue("signedProxyRight", SignedProxyRight);
                    if (SignedSourceAttestation != null) yield return new ElementValue("signedSourceAttestation", SignedSourceAttestation);
                }
            }


        }


        [FhirType("ValidatorComponent")]
        [DataContract]
        public partial class ValidatorComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ValidatorComponent"; } }

            /// <summary>
            /// Reference to the organization validating information
            /// </summary>
            [FhirElement("organization", Order=40)]
            [References("Organization")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Organization
            {
                get { return _organization; }
                set { _organization = value; OnPropertyChanged("Organization"); }
            }

            private ResourceReference _organization;

            /// <summary>
            /// A digital identity certificate associated with the validator
            /// </summary>
            [FhirElement("identityCertificate", Order=50)]
            [DataMember]
            public FhirString IdentityCertificateElement
            {
                get { return _identityCertificateElement; }
                set { _identityCertificateElement = value; OnPropertyChanged("IdentityCertificateElement"); }
            }

            private FhirString _identityCertificateElement;

            /// <summary>
            /// A digital identity certificate associated with the validator
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string IdentityCertificate
            {
                get { return IdentityCertificateElement != null ? IdentityCertificateElement.Value : null; }
                set
                {
                    if (value == null)
                        IdentityCertificateElement = null;
                    else
                        IdentityCertificateElement = new FhirString(value);
                    OnPropertyChanged("IdentityCertificate");
                }
            }

            /// <summary>
            /// Validator signature
            /// </summary>
            [FhirElement("signedValidatorAttestation", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirString),typeof(FhirUri))]
            [DataMember]
            public Element SignedValidatorAttestation
            {
                get { return _signedValidatorAttestation; }
                set { _signedValidatorAttestation = value; OnPropertyChanged("SignedValidatorAttestation"); }
            }

            private Element _signedValidatorAttestation;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ValidatorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                    if (IdentityCertificateElement != null) dest.IdentityCertificateElement = (FhirString)IdentityCertificateElement.DeepCopy();
                    if (SignedValidatorAttestation != null) dest.SignedValidatorAttestation = (Element)SignedValidatorAttestation.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ValidatorComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ValidatorComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
                if (!DeepComparable.Matches(IdentityCertificateElement, otherT.IdentityCertificateElement)) return false;
                if (!DeepComparable.Matches(SignedValidatorAttestation, otherT.SignedValidatorAttestation)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ValidatorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
                if (!DeepComparable.IsExactly(IdentityCertificateElement, otherT.IdentityCertificateElement)) return false;
                if (!DeepComparable.IsExactly(SignedValidatorAttestation, otherT.SignedValidatorAttestation)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Organization != null) yield return Organization;
                    if (IdentityCertificateElement != null) yield return IdentityCertificateElement;
                    if (SignedValidatorAttestation != null) yield return SignedValidatorAttestation;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Organization != null) yield return new ElementValue("organization", Organization);
                    if (IdentityCertificateElement != null) yield return new ElementValue("identityCertificate", IdentityCertificateElement);
                    if (SignedValidatorAttestation != null) yield return new ElementValue("signedValidatorAttestation", SignedValidatorAttestation);
                }
            }


        }


        /// <summary>
        /// A resource that was validated
        /// </summary>
        [FhirElement("target", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Target
        {
            get { if (_target==null) _target = new List<ResourceReference>(); return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private List<ResourceReference> _target;

        /// <summary>
        /// The fhirpath location(s) within the resource that was validated
        /// </summary>
        [FhirElement("targetLocation", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirString> TargetLocationElement
        {
            get { if (_targetLocationElement==null) _targetLocationElement = new List<FhirString>(); return _targetLocationElement; }
            set { _targetLocationElement = value; OnPropertyChanged("TargetLocationElement"); }
        }

        private List<FhirString> _targetLocationElement;

        /// <summary>
        /// The fhirpath location(s) within the resource that was validated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> TargetLocation
        {
            get { return TargetLocationElement != null ? TargetLocationElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    TargetLocationElement = null;
                else
                    TargetLocationElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                OnPropertyChanged("TargetLocation");
            }
        }

        /// <summary>
        /// none | initial | periodic
        /// </summary>
        [FhirElement("need", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept Need
        {
            get { return _need; }
            set { _need = value; OnPropertyChanged("Need"); }
        }

        private CodeableConcept _need;

        /// <summary>
        /// attested | validated | in-process | req-revalid | val-fail | reval-fail
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<status> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<status> _statusElement;

        /// <summary>
        /// attested | validated | in-process | req-revalid | val-fail | reval-fail
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public status? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<status>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// When the validation status was updated
        /// </summary>
        [FhirElement("statusDate", InSummary=true, Order=130)]
        [DataMember]
        public FhirDateTime StatusDateElement
        {
            get { return _statusDateElement; }
            set { _statusDateElement = value; OnPropertyChanged("StatusDateElement"); }
        }

        private FhirDateTime _statusDateElement;

        /// <summary>
        /// When the validation status was updated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string StatusDate
        {
            get { return StatusDateElement != null ? StatusDateElement.Value : null; }
            set
            {
                if (value == null)
                    StatusDateElement = null;
                else
                    StatusDateElement = new FhirDateTime(value);
                OnPropertyChanged("StatusDate");
            }
        }

        /// <summary>
        /// nothing | primary | multiple
        /// </summary>
        [FhirElement("validationType", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept ValidationType
        {
            get { return _validationType; }
            set { _validationType = value; OnPropertyChanged("ValidationType"); }
        }

        private CodeableConcept _validationType;

        /// <summary>
        /// The primary process by which the target is validated (edit check; value set; primary source; multiple sources; standalone; in context)
        /// </summary>
        [FhirElement("validationProcess", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ValidationProcess
        {
            get { if (_validationProcess==null) _validationProcess = new List<CodeableConcept>(); return _validationProcess; }
            set { _validationProcess = value; OnPropertyChanged("ValidationProcess"); }
        }

        private List<CodeableConcept> _validationProcess;

        /// <summary>
        /// Frequency of revalidation
        /// </summary>
        [FhirElement("frequency", Order=160)]
        [DataMember]
        public Timing Frequency
        {
            get { return _frequency; }
            set { _frequency = value; OnPropertyChanged("Frequency"); }
        }

        private Timing _frequency;

        /// <summary>
        /// The date/time validation was last completed (incl. failed validations)
        /// </summary>
        [FhirElement("lastPerformed", Order=170)]
        [DataMember]
        public FhirDateTime LastPerformedElement
        {
            get { return _lastPerformedElement; }
            set { _lastPerformedElement = value; OnPropertyChanged("LastPerformedElement"); }
        }

        private FhirDateTime _lastPerformedElement;

        /// <summary>
        /// The date/time validation was last completed (incl. failed validations)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string LastPerformed
        {
            get { return LastPerformedElement != null ? LastPerformedElement.Value : null; }
            set
            {
                if (value == null)
                    LastPerformedElement = null;
                else
                    LastPerformedElement = new FhirDateTime(value);
                OnPropertyChanged("LastPerformed");
            }
        }

        /// <summary>
        /// The date when target is next validated, if appropriate
        /// </summary>
        [FhirElement("nextScheduled", Order=180)]
        [DataMember]
        public Date NextScheduledElement
        {
            get { return _nextScheduledElement; }
            set { _nextScheduledElement = value; OnPropertyChanged("NextScheduledElement"); }
        }

        private Date _nextScheduledElement;

        /// <summary>
        /// The date when target is next validated, if appropriate
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string NextScheduled
        {
            get { return NextScheduledElement != null ? NextScheduledElement.Value : null; }
            set
            {
                if (value == null)
                    NextScheduledElement = null;
                else
                    NextScheduledElement = new Date(value);
                OnPropertyChanged("NextScheduled");
            }
        }

        /// <summary>
        /// fatal | warn | rec-only | none
        /// </summary>
        [FhirElement("failureAction", InSummary=true, Order=190)]
        [DataMember]
        public CodeableConcept FailureAction
        {
            get { return _failureAction; }
            set { _failureAction = value; OnPropertyChanged("FailureAction"); }
        }

        private CodeableConcept _failureAction;

        /// <summary>
        /// Information about the primary source(s) involved in validation
        /// </summary>
        [FhirElement("primarySource", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PrimarySourceComponent> PrimarySource
        {
            get { if (_primarySource==null) _primarySource = new List<PrimarySourceComponent>(); return _primarySource; }
            set { _primarySource = value; OnPropertyChanged("PrimarySource"); }
        }

        private List<PrimarySourceComponent> _primarySource;

        /// <summary>
        /// Information about the entity attesting to information
        /// </summary>
        [FhirElement("attestation", Order=210)]
        [DataMember]
        public AttestationComponent Attestation
        {
            get { return _attestation; }
            set { _attestation = value; OnPropertyChanged("Attestation"); }
        }

        private AttestationComponent _attestation;

        /// <summary>
        /// Information about the entity validating information
        /// </summary>
        [FhirElement("validator", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ValidatorComponent> Validator
        {
            get { if (_validator==null) _validator = new List<ValidatorComponent>(); return _validator; }
            set { _validator = value; OnPropertyChanged("Validator"); }
        }

        private List<ValidatorComponent> _validator;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as VerificationResult;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Target != null) dest.Target = new List<ResourceReference>(Target.DeepCopy());
                if (TargetLocationElement != null) dest.TargetLocationElement = new List<FhirString>(TargetLocationElement.DeepCopy());
                if (Need != null) dest.Need = (CodeableConcept)Need.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<status>)StatusElement.DeepCopy();
                if (StatusDateElement != null) dest.StatusDateElement = (FhirDateTime)StatusDateElement.DeepCopy();
                if (ValidationType != null) dest.ValidationType = (CodeableConcept)ValidationType.DeepCopy();
                if (ValidationProcess != null) dest.ValidationProcess = new List<CodeableConcept>(ValidationProcess.DeepCopy());
                if (Frequency != null) dest.Frequency = (Timing)Frequency.DeepCopy();
                if (LastPerformedElement != null) dest.LastPerformedElement = (FhirDateTime)LastPerformedElement.DeepCopy();
                if (NextScheduledElement != null) dest.NextScheduledElement = (Date)NextScheduledElement.DeepCopy();
                if (FailureAction != null) dest.FailureAction = (CodeableConcept)FailureAction.DeepCopy();
                if (PrimarySource != null) dest.PrimarySource = new List<PrimarySourceComponent>(PrimarySource.DeepCopy());
                if (Attestation != null) dest.Attestation = (AttestationComponent)Attestation.DeepCopy();
                if (Validator != null) dest.Validator = new List<ValidatorComponent>(Validator.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new VerificationResult());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as VerificationResult;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Target, otherT.Target)) return false;
            if ( !DeepComparable.Matches(TargetLocationElement, otherT.TargetLocationElement)) return false;
            if (!DeepComparable.Matches(Need, otherT.Need)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
            if (!DeepComparable.Matches(ValidationType, otherT.ValidationType)) return false;
            if ( !DeepComparable.Matches(ValidationProcess, otherT.ValidationProcess)) return false;
            if (!DeepComparable.Matches(Frequency, otherT.Frequency)) return false;
            if (!DeepComparable.Matches(LastPerformedElement, otherT.LastPerformedElement)) return false;
            if (!DeepComparable.Matches(NextScheduledElement, otherT.NextScheduledElement)) return false;
            if (!DeepComparable.Matches(FailureAction, otherT.FailureAction)) return false;
            if ( !DeepComparable.Matches(PrimarySource, otherT.PrimarySource)) return false;
            if (!DeepComparable.Matches(Attestation, otherT.Attestation)) return false;
            if ( !DeepComparable.Matches(Validator, otherT.Validator)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as VerificationResult;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(TargetLocationElement, otherT.TargetLocationElement)) return false;
            if (!DeepComparable.IsExactly(Need, otherT.Need)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
            if (!DeepComparable.IsExactly(ValidationType, otherT.ValidationType)) return false;
            if (!DeepComparable.IsExactly(ValidationProcess, otherT.ValidationProcess)) return false;
            if (!DeepComparable.IsExactly(Frequency, otherT.Frequency)) return false;
            if (!DeepComparable.IsExactly(LastPerformedElement, otherT.LastPerformedElement)) return false;
            if (!DeepComparable.IsExactly(NextScheduledElement, otherT.NextScheduledElement)) return false;
            if (!DeepComparable.IsExactly(FailureAction, otherT.FailureAction)) return false;
            if (!DeepComparable.IsExactly(PrimarySource, otherT.PrimarySource)) return false;
            if (!DeepComparable.IsExactly(Attestation, otherT.Attestation)) return false;
            if (!DeepComparable.IsExactly(Validator, otherT.Validator)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Target) { if (elem != null) yield return elem; }
                foreach (var elem in TargetLocationElement) { if (elem != null) yield return elem; }
                if (Need != null) yield return Need;
                if (StatusElement != null) yield return StatusElement;
                if (StatusDateElement != null) yield return StatusDateElement;
                if (ValidationType != null) yield return ValidationType;
                foreach (var elem in ValidationProcess) { if (elem != null) yield return elem; }
                if (Frequency != null) yield return Frequency;
                if (LastPerformedElement != null) yield return LastPerformedElement;
                if (NextScheduledElement != null) yield return NextScheduledElement;
                if (FailureAction != null) yield return FailureAction;
                foreach (var elem in PrimarySource) { if (elem != null) yield return elem; }
                if (Attestation != null) yield return Attestation;
                foreach (var elem in Validator) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", elem); }
                foreach (var elem in TargetLocationElement) { if (elem != null) yield return new ElementValue("targetLocation", elem); }
                if (Need != null) yield return new ElementValue("need", Need);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (StatusDateElement != null) yield return new ElementValue("statusDate", StatusDateElement);
                if (ValidationType != null) yield return new ElementValue("validationType", ValidationType);
                foreach (var elem in ValidationProcess) { if (elem != null) yield return new ElementValue("validationProcess", elem); }
                if (Frequency != null) yield return new ElementValue("frequency", Frequency);
                if (LastPerformedElement != null) yield return new ElementValue("lastPerformed", LastPerformedElement);
                if (NextScheduledElement != null) yield return new ElementValue("nextScheduled", NextScheduledElement);
                if (FailureAction != null) yield return new ElementValue("failureAction", FailureAction);
                foreach (var elem in PrimarySource) { if (elem != null) yield return new ElementValue("primarySource", elem); }
                if (Attestation != null) yield return new ElementValue("attestation", Attestation);
                foreach (var elem in Validator) { if (elem != null) yield return new ElementValue("validator", elem); }
            }
        }

    }

}
