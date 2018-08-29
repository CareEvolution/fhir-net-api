using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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


        [FhirType("PrimarySourceComponent")]
        [DataContract]
        public partial class PrimarySourceComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PrimarySourceComponent"; } }

            /// <summary>
            /// URI of the primary source for validation
            /// </summary>
            [FhirElement("identifier", Order=40)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Reference to the primary source
            /// </summary>
            [FhirElement("organization", Order=50)]
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
            [FhirElement("type", InSummary=true, Order=60)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Type
            {
                get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private List<CodeableConcept> _type;

            /// <summary>
            /// Method for communicating with the primary source (manual; API; Push)
            /// </summary>
            [FhirElement("validationProcess", InSummary=true, Order=70)]
            [Cardinality(Min=1,Max=-1)]
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
            [FhirElement("validationStatus", Order=80)]
            [DataMember]
            public Code<validation_status> ValidationStatusElement
            {
                get { return _validationStatusElement; }
                set { _validationStatusElement = value; OnPropertyChanged("ValidationStatusElement"); }
            }

            private Code<validation_status> _validationStatusElement;

            /// <summary>
            /// successful | failed | unknown
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public validation_status? ValidationStatus
            {
                get { return ValidationStatusElement != null ? ValidationStatusElement.Value : null; }
                set
                {
                    if (value == null)
                        ValidationStatusElement = null;
                    else
                        ValidationStatusElement = new Code<validation_status>(value);
                    OnPropertyChanged("ValidationStatus");
                }
            }

            /// <summary>
            /// When the target was validated against the primary source
            /// </summary>
            [FhirElement("validationDate", Order=90)]
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
            [FhirElement("canPushUpdates", InSummary=true, Order=100)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<can_push_updates> CanPushUpdatesElement
            {
                get { return _canPushUpdatesElement; }
                set { _canPushUpdatesElement = value; OnPropertyChanged("CanPushUpdatesElement"); }
            }

            private Code<can_push_updates> _canPushUpdatesElement;

            /// <summary>
            /// yes | no | undetermined
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public can_push_updates? CanPushUpdates
            {
                get { return CanPushUpdatesElement != null ? CanPushUpdatesElement.Value : null; }
                set
                {
                    if (value == null)
                        CanPushUpdatesElement = null;
                    else
                        CanPushUpdatesElement = new Code<can_push_updates>(value);
                    OnPropertyChanged("CanPushUpdates");
                }
            }

            /// <summary>
            /// specific | any | source
            /// </summary>
            [FhirElement("pushTypeAvailable", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<push_type_available>> PushTypeAvailableElement
            {
                get { if (_pushTypeAvailableElement==null) _pushTypeAvailableElement = new List<Code<push_type_available>>(); return _pushTypeAvailableElement; }
                set { _pushTypeAvailableElement = value; OnPropertyChanged("PushTypeAvailableElement"); }
            }

            private List<Code<push_type_available>> _pushTypeAvailableElement;

            /// <summary>
            /// specific | any | source
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<push_type_available?> PushTypeAvailable
            {
                get { return PushTypeAvailableElement != null ? PushTypeAvailableElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PushTypeAvailableElement = null;
                    else
                        PushTypeAvailableElement = new List<Code<push_type_available>>(value.Select(elem=>new Code<push_type_available>(elem)));
                    OnPropertyChanged("PushTypeAvailable");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PrimarySourceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                    if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                    if (ValidationProcess != null) dest.ValidationProcess = new List<CodeableConcept>(ValidationProcess.DeepCopy());
                    if (ValidationStatusElement != null) dest.ValidationStatusElement = (Code<validation_status>)ValidationStatusElement.DeepCopy();
                    if (ValidationDateElement != null) dest.ValidationDateElement = (FhirDateTime)ValidationDateElement.DeepCopy();
                    if (CanPushUpdatesElement != null) dest.CanPushUpdatesElement = (Code<can_push_updates>)CanPushUpdatesElement.DeepCopy();
                    if (PushTypeAvailableElement != null) dest.PushTypeAvailableElement = new List<Code<push_type_available>>(PushTypeAvailableElement.DeepCopy());
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
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
                if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(ValidationProcess, otherT.ValidationProcess)) return false;
                if (!DeepComparable.Matches(ValidationStatusElement, otherT.ValidationStatusElement)) return false;
                if (!DeepComparable.Matches(ValidationDateElement, otherT.ValidationDateElement)) return false;
                if (!DeepComparable.Matches(CanPushUpdatesElement, otherT.CanPushUpdatesElement)) return false;
                if ( !DeepComparable.Matches(PushTypeAvailableElement, otherT.PushTypeAvailableElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PrimarySourceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(ValidationProcess, otherT.ValidationProcess)) return false;
                if (!DeepComparable.IsExactly(ValidationStatusElement, otherT.ValidationStatusElement)) return false;
                if (!DeepComparable.IsExactly(ValidationDateElement, otherT.ValidationDateElement)) return false;
                if (!DeepComparable.IsExactly(CanPushUpdatesElement, otherT.CanPushUpdatesElement)) return false;
                if (!DeepComparable.IsExactly(PushTypeAvailableElement, otherT.PushTypeAvailableElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (Organization != null) yield return Organization;
                    foreach (var elem in Type) { if (elem != null) yield return elem; }
                    foreach (var elem in ValidationProcess) { if (elem != null) yield return elem; }
                    if (ValidationStatusElement != null) yield return ValidationStatusElement;
                    if (ValidationDateElement != null) yield return ValidationDateElement;
                    if (CanPushUpdatesElement != null) yield return CanPushUpdatesElement;
                    foreach (var elem in PushTypeAvailableElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                    if (Organization != null) yield return new ElementValue("organization", false, Organization);
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", true, elem); }
                    foreach (var elem in ValidationProcess) { if (elem != null) yield return new ElementValue("validationProcess", true, elem); }
                    if (ValidationStatusElement != null) yield return new ElementValue("validationStatus", false, ValidationStatusElement);
                    if (ValidationDateElement != null) yield return new ElementValue("validationDate", false, ValidationDateElement);
                    if (CanPushUpdatesElement != null) yield return new ElementValue("canPushUpdates", false, CanPushUpdatesElement);
                    foreach (var elem in PushTypeAvailableElement) { if (elem != null) yield return new ElementValue("pushTypeAvailable", true, elem); }
                }
            }


        }


        [FhirType("AttestationComponent")]
        [DataContract]
        public partial class AttestationComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AttestationComponent"; } }

            /// <summary>
            /// The individual attesting to information
            /// </summary>
            [FhirElement("source", InSummary=true, Order=40)]
            [References("Practitioner")]
            [Cardinality(Min=1,Max=1)]
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
            [Cardinality(Min=1,Max=1)]
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
            [Cardinality(Min=1,Max=1)]
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
            [Cardinality(Min=1,Max=1)]
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
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Source != null) yield return new ElementValue("source", false, Source);
                    if (Organization != null) yield return new ElementValue("organization", false, Organization);
                    if (Method != null) yield return new ElementValue("method", false, Method);
                    if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                    if (SourceIdentityCertificateElement != null) yield return new ElementValue("sourceIdentityCertificate", false, SourceIdentityCertificateElement);
                    if (ProxyIdentityCertificateElement != null) yield return new ElementValue("proxyIdentityCertificate", false, ProxyIdentityCertificateElement);
                }
            }


        }


        [FhirType("ValidatorComponent")]
        [DataContract]
        public partial class ValidatorComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ValidatorComponent"; } }

            /// <summary>
            /// URI of the validator
            /// </summary>
            [FhirElement("identifier", Order=40)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            /// <summary>
            /// Reference to the organization validating information
            /// </summary>
            [FhirElement("organization", Order=50)]
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
            [FhirElement("identityCertificate", Order=60)]
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
            /// Date on which the validator last validated the information
            /// </summary>
            [FhirElement("dateValidated", Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Date DateValidatedElement
            {
                get { return _dateValidatedElement; }
                set { _dateValidatedElement = value; OnPropertyChanged("DateValidatedElement"); }
            }

            private Date _dateValidatedElement;

            /// <summary>
            /// Date on which the validator last validated the information
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string DateValidated
            {
                get { return DateValidatedElement != null ? DateValidatedElement.Value : null; }
                set
                {
                    if (value == null)
                        DateValidatedElement = null;
                    else
                        DateValidatedElement = new Date(value);
                    OnPropertyChanged("DateValidated");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ValidatorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                    if (IdentityCertificateElement != null) dest.IdentityCertificateElement = (FhirString)IdentityCertificateElement.DeepCopy();
                    if (DateValidatedElement != null) dest.DateValidatedElement = (Date)DateValidatedElement.DeepCopy();
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
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
                if (!DeepComparable.Matches(IdentityCertificateElement, otherT.IdentityCertificateElement)) return false;
                if (!DeepComparable.Matches(DateValidatedElement, otherT.DateValidatedElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ValidatorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
                if (!DeepComparable.IsExactly(IdentityCertificateElement, otherT.IdentityCertificateElement)) return false;
                if (!DeepComparable.IsExactly(DateValidatedElement, otherT.DateValidatedElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (Organization != null) yield return Organization;
                    if (IdentityCertificateElement != null) yield return IdentityCertificateElement;
                    if (DateValidatedElement != null) yield return DateValidatedElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                    if (Organization != null) yield return new ElementValue("organization", false, Organization);
                    if (IdentityCertificateElement != null) yield return new ElementValue("identityCertificate", false, IdentityCertificateElement);
                    if (DateValidatedElement != null) yield return new ElementValue("dateValidated", false, DateValidatedElement);
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
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<need> NeedElement
        {
            get { return _needElement; }
            set { _needElement = value; OnPropertyChanged("NeedElement"); }
        }

        private Code<need> _needElement;

        /// <summary>
        /// none | initial | periodic
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public need? Need
        {
            get { return NeedElement != null ? NeedElement.Value : null; }
            set
            {
                if (value == null)
                    NeedElement = null;
                else
                    NeedElement = new Code<need>(value);
                OnPropertyChanged("Need");
            }
        }

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
        [Cardinality(Min=1,Max=1)]
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
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<validation_type> ValidationTypeElement
        {
            get { return _validationTypeElement; }
            set { _validationTypeElement = value; OnPropertyChanged("ValidationTypeElement"); }
        }

        private Code<validation_type> _validationTypeElement;

        /// <summary>
        /// nothing | primary | multiple
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public validation_type? ValidationType
        {
            get { return ValidationTypeElement != null ? ValidationTypeElement.Value : null; }
            set
            {
                if (value == null)
                    ValidationTypeElement = null;
                else
                    ValidationTypeElement = new Code<validation_type>(value);
                OnPropertyChanged("ValidationType");
            }
        }

        /// <summary>
        /// The primary process by which the target is validated (edit check; value set; primary source; multiple sources; standalone; in context)
        /// </summary>
        [FhirElement("validationProcess", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=-1)]
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
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<failure_action> FailureActionElement
        {
            get { return _failureActionElement; }
            set { _failureActionElement = value; OnPropertyChanged("FailureActionElement"); }
        }

        private Code<failure_action> _failureActionElement;

        /// <summary>
        /// fatal | warn | rec-only | none
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public failure_action? FailureAction
        {
            get { return FailureActionElement != null ? FailureActionElement.Value : null; }
            set
            {
                if (value == null)
                    FailureActionElement = null;
                else
                    FailureActionElement = new Code<failure_action>(value);
                OnPropertyChanged("FailureAction");
            }
        }

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
                if (NeedElement != null) dest.NeedElement = (Code<need>)NeedElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<status>)StatusElement.DeepCopy();
                if (StatusDateElement != null) dest.StatusDateElement = (FhirDateTime)StatusDateElement.DeepCopy();
                if (ValidationTypeElement != null) dest.ValidationTypeElement = (Code<validation_type>)ValidationTypeElement.DeepCopy();
                if (ValidationProcess != null) dest.ValidationProcess = new List<CodeableConcept>(ValidationProcess.DeepCopy());
                if (Frequency != null) dest.Frequency = (Timing)Frequency.DeepCopy();
                if (LastPerformedElement != null) dest.LastPerformedElement = (FhirDateTime)LastPerformedElement.DeepCopy();
                if (NextScheduledElement != null) dest.NextScheduledElement = (Date)NextScheduledElement.DeepCopy();
                if (FailureActionElement != null) dest.FailureActionElement = (Code<failure_action>)FailureActionElement.DeepCopy();
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
            if (!DeepComparable.Matches(NeedElement, otherT.NeedElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
            if (!DeepComparable.Matches(ValidationTypeElement, otherT.ValidationTypeElement)) return false;
            if ( !DeepComparable.Matches(ValidationProcess, otherT.ValidationProcess)) return false;
            if (!DeepComparable.Matches(Frequency, otherT.Frequency)) return false;
            if (!DeepComparable.Matches(LastPerformedElement, otherT.LastPerformedElement)) return false;
            if (!DeepComparable.Matches(NextScheduledElement, otherT.NextScheduledElement)) return false;
            if (!DeepComparable.Matches(FailureActionElement, otherT.FailureActionElement)) return false;
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
            if (!DeepComparable.IsExactly(NeedElement, otherT.NeedElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
            if (!DeepComparable.IsExactly(ValidationTypeElement, otherT.ValidationTypeElement)) return false;
            if (!DeepComparable.IsExactly(ValidationProcess, otherT.ValidationProcess)) return false;
            if (!DeepComparable.IsExactly(Frequency, otherT.Frequency)) return false;
            if (!DeepComparable.IsExactly(LastPerformedElement, otherT.LastPerformedElement)) return false;
            if (!DeepComparable.IsExactly(NextScheduledElement, otherT.NextScheduledElement)) return false;
            if (!DeepComparable.IsExactly(FailureActionElement, otherT.FailureActionElement)) return false;
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
                if (NeedElement != null) yield return NeedElement;
                if (StatusElement != null) yield return StatusElement;
                if (StatusDateElement != null) yield return StatusDateElement;
                if (ValidationTypeElement != null) yield return ValidationTypeElement;
                foreach (var elem in ValidationProcess) { if (elem != null) yield return elem; }
                if (Frequency != null) yield return Frequency;
                if (LastPerformedElement != null) yield return LastPerformedElement;
                if (NextScheduledElement != null) yield return NextScheduledElement;
                if (FailureActionElement != null) yield return FailureActionElement;
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
                foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", true, elem); }
                foreach (var elem in TargetLocationElement) { if (elem != null) yield return new ElementValue("targetLocation", true, elem); }
                if (NeedElement != null) yield return new ElementValue("need", false, NeedElement);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (StatusDateElement != null) yield return new ElementValue("statusDate", false, StatusDateElement);
                if (ValidationTypeElement != null) yield return new ElementValue("validationType", false, ValidationTypeElement);
                foreach (var elem in ValidationProcess) { if (elem != null) yield return new ElementValue("validationProcess", true, elem); }
                if (Frequency != null) yield return new ElementValue("frequency", false, Frequency);
                if (LastPerformedElement != null) yield return new ElementValue("lastPerformed", false, LastPerformedElement);
                if (NextScheduledElement != null) yield return new ElementValue("nextScheduled", false, NextScheduledElement);
                if (FailureActionElement != null) yield return new ElementValue("failureAction", false, FailureActionElement);
                foreach (var elem in PrimarySource) { if (elem != null) yield return new ElementValue("primarySource", true, elem); }
                if (Attestation != null) yield return new ElementValue("attestation", false, Attestation);
                foreach (var elem in Validator) { if (elem != null) yield return new ElementValue("validator", true, elem); }
            }
        }

    }

}
