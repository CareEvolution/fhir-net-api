using System;
using System.Collections.Generic;
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
    /// Claim, Pre-determination or Pre-authorization
    /// </summary>
    [FhirType("Claim", IsResource = true)]
    [DataContract]
    public partial class Claim : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Claim; } }
        [NotMapped]
        public override string TypeName { get { return "Claim"; } }

        /// <summary>
        /// The type or discipline-style of the claim.
        /// (url: http://hl7.org/fhir/ValueSet/claim-type-link)
        /// </summary>
        [FhirEnumeration("ClaimType")]
        public enum ClaimType
        {
            /// <summary>
            /// A claim for Institution based, typically in-patient, goods and services.
            /// (system: http://hl7.org/fhir/claim-type-link)
            /// </summary>
            [EnumLiteral("institutional", "http://hl7.org/fhir/claim-type-link"), Description("Institutional")]
            Institutional,
            /// <summary>
            /// A claim for Oral Health (Dentist, Denturist, Hygienist) goods and services.
            /// (system: http://hl7.org/fhir/claim-type-link)
            /// </summary>
            [EnumLiteral("oral", "http://hl7.org/fhir/claim-type-link"), Description("Oral Health")]
            Oral,
            /// <summary>
            /// A claim for Pharmacy based goods and services.
            /// (system: http://hl7.org/fhir/claim-type-link)
            /// </summary>
            [EnumLiteral("pharmacy", "http://hl7.org/fhir/claim-type-link"), Description("Pharmacy")]
            Pharmacy,
            /// <summary>
            /// A claim for Professional, typically out-patient, goods and services.
            /// (system: http://hl7.org/fhir/claim-type-link)
            /// </summary>
            [EnumLiteral("professional", "http://hl7.org/fhir/claim-type-link"), Description("Professional")]
            Professional,
            /// <summary>
            /// A claim for Vision (Ophthamologist, Optometrist and Optician) goods and services.
            /// (system: http://hl7.org/fhir/claim-type-link)
            /// </summary>
            [EnumLiteral("vision", "http://hl7.org/fhir/claim-type-link"), Description("Vision")]
            Vision,
        }

        /// <summary>
        /// Complete, proposed, exploratory, other.
        /// (url: http://hl7.org/fhir/ValueSet/claim-use-link)
        /// </summary>
        [FhirEnumeration("Use")]
        public enum Use
        {
            /// <summary>
            /// The treatment is complete and this represents a Claim for the services.
            /// (system: http://hl7.org/fhir/claim-use-link)
            /// </summary>
            [EnumLiteral("complete", "http://hl7.org/fhir/claim-use-link"), Description("Complete")]
            Complete,
            /// <summary>
            /// The treatment is proposed and this represents a Pre-authorization for the services.
            /// (system: http://hl7.org/fhir/claim-use-link)
            /// </summary>
            [EnumLiteral("proposed", "http://hl7.org/fhir/claim-use-link"), Description("Proposed")]
            Proposed,
            /// <summary>
            /// The treatment is proposed and this represents a Pre-determination for the services.
            /// (system: http://hl7.org/fhir/claim-use-link)
            /// </summary>
            [EnumLiteral("exploratory", "http://hl7.org/fhir/claim-use-link"), Description("Exploratory")]
            Exploratory,
            /// <summary>
            /// A locally defined or otherwise resolved status.
            /// (system: http://hl7.org/fhir/claim-use-link)
            /// </summary>
            [EnumLiteral("other", "http://hl7.org/fhir/claim-use-link"), Description("Other")]
            Other,
        }


        [FhirType("PayeeComponent")]
        [DataContract]
        public partial class PayeeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PayeeComponent"; } }

            /// <summary>
            /// Party to be paid any benefits payable
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 40)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Provider who is the payee
            /// </summary>
            [FhirElement("provider", InSummary = true, Order = 50)]
            [References("Practitioner")]
            [DataMember]
            public ResourceReference Provider
            {
                get { return _provider; }
                set { _provider = value; OnPropertyChanged("Provider"); }
            }

            private ResourceReference _provider;

            /// <summary>
            /// Organization who is the payee
            /// </summary>
            [FhirElement("organization", InSummary = true, Order = 60)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Organization
            {
                get { return _organization; }
                set { _organization = value; OnPropertyChanged("Organization"); }
            }

            private ResourceReference _organization;

            /// <summary>
            /// Other person who is the payee
            /// </summary>
            [FhirElement("person", InSummary = true, Order = 70)]
            [References("Patient")]
            [DataMember]
            public ResourceReference Person
            {
                get { return _person; }
                set { _person = value; OnPropertyChanged("Person"); }
            }

            private ResourceReference _person;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PayeeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                    if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                    if (Person != null) dest.Person = (ResourceReference)Person.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new PayeeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PayeeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
                if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
                if (!DeepComparable.Matches(Person, otherT.Person)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PayeeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
                if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
                if (!DeepComparable.IsExactly(Person, otherT.Person)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Provider != null) yield return Provider;
                    if (Organization != null) yield return Organization;
                    if (Person != null) yield return Person;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Provider != null) yield return new ElementValue("provider", Provider);
                    if (Organization != null) yield return new ElementValue("organization", Organization);
                    if (Person != null) yield return new ElementValue("person", Person);
                }
            }


        }


        [FhirType("DiagnosisComponent")]
        [DataContract]
        public partial class DiagnosisComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DiagnosisComponent"; } }

            /// <summary>
            /// Sequence of diagnosis
            /// </summary>
            [FhirElement("sequence", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Sequence of diagnosis
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Patient's list of diagnosis
            /// </summary>
            [FhirElement("diagnosis", InSummary = true, Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Diagnosis
            {
                get { return _diagnosis; }
                set { _diagnosis = value; OnPropertyChanged("Diagnosis"); }
            }

            private Coding _diagnosis;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DiagnosisComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Diagnosis != null) dest.Diagnosis = (Coding)Diagnosis.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new DiagnosisComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DiagnosisComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DiagnosisComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (Diagnosis != null) yield return Diagnosis;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (Diagnosis != null) yield return new ElementValue("diagnosis", Diagnosis);
                }
            }


        }


        [FhirType("CoverageComponent")]
        [DataContract]
        public partial class CoverageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CoverageComponent"; } }

            /// <summary>
            /// Service instance identifier
            /// </summary>
            [FhirElement("sequence", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Service instance identifier
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// The focal Coverage
            /// </summary>
            [FhirElement("focal", InSummary = true, Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public FhirBoolean FocalElement
            {
                get { return _focalElement; }
                set { _focalElement = value; OnPropertyChanged("FocalElement"); }
            }

            private FhirBoolean _focalElement;

            /// <summary>
            /// The focal Coverage
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Focal
            {
                get { return FocalElement != null ? FocalElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        FocalElement = null;
                    else
                        FocalElement = new FhirBoolean(value);
                    OnPropertyChanged("Focal");
                }
            }

            /// <summary>
            /// Insurance information
            /// </summary>
            [FhirElement("coverage", InSummary = true, Order = 60)]
            [References("Coverage")]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public ResourceReference Coverage
            {
                get { return _coverage; }
                set { _coverage = value; OnPropertyChanged("Coverage"); }
            }

            private ResourceReference _coverage;

            /// <summary>
            /// Business agreement
            /// </summary>
            [FhirElement("businessArrangement", InSummary = true, Order = 70)]
            [DataMember]
            public FhirString BusinessArrangementElement
            {
                get { return _businessArrangementElement; }
                set { _businessArrangementElement = value; OnPropertyChanged("BusinessArrangementElement"); }
            }

            private FhirString _businessArrangementElement;

            /// <summary>
            /// Business agreement
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string BusinessArrangement
            {
                get { return BusinessArrangementElement != null ? BusinessArrangementElement.Value : null; }
                set
                {
                    if (value == null)
                        BusinessArrangementElement = null;
                    else
                        BusinessArrangementElement = new FhirString(value);
                    OnPropertyChanged("BusinessArrangement");
                }
            }

            /// <summary>
            /// Patient relationship to subscriber
            /// </summary>
            [FhirElement("relationship", InSummary = true, Order = 80)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Relationship
            {
                get { return _relationship; }
                set { _relationship = value; OnPropertyChanged("Relationship"); }
            }

            private Coding _relationship;

            /// <summary>
            /// Pre-Authorization/Determination Reference
            /// </summary>
            [FhirElement("preAuthRef", InSummary = true, Order = 90)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<FhirString> PreAuthRefElement
            {
                get { if (_preAuthRefElement == null) _preAuthRefElement = new List<FhirString>(); return _preAuthRefElement; }
                set { _preAuthRefElement = value; OnPropertyChanged("PreAuthRefElement"); }
            }

            private List<FhirString> _preAuthRefElement;

            /// <summary>
            /// Pre-Authorization/Determination Reference
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> PreAuthRef
            {
                get { return PreAuthRefElement != null ? PreAuthRefElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PreAuthRefElement = null;
                    else
                        PreAuthRefElement = new List<FhirString>(value.Select(elem => new FhirString(elem)));
                    OnPropertyChanged("PreAuthRef");
                }
            }

            /// <summary>
            /// Adjudication results
            /// </summary>
            [FhirElement("claimResponse", InSummary = true, Order = 100)]
            [References("ClaimResponse")]
            [DataMember]
            public ResourceReference ClaimResponse
            {
                get { return _claimResponse; }
                set { _claimResponse = value; OnPropertyChanged("ClaimResponse"); }
            }

            private ResourceReference _claimResponse;

            /// <summary>
            /// Original version
            /// </summary>
            [FhirElement("originalRuleset", InSummary = true, Order = 110)]
            [DataMember]
            public Coding OriginalRuleset
            {
                get { return _originalRuleset; }
                set { _originalRuleset = value; OnPropertyChanged("OriginalRuleset"); }
            }

            private Coding _originalRuleset;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CoverageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (FocalElement != null) dest.FocalElement = (FhirBoolean)FocalElement.DeepCopy();
                    if (Coverage != null) dest.Coverage = (ResourceReference)Coverage.DeepCopy();
                    if (BusinessArrangementElement != null) dest.BusinessArrangementElement = (FhirString)BusinessArrangementElement.DeepCopy();
                    if (Relationship != null) dest.Relationship = (Coding)Relationship.DeepCopy();
                    if (PreAuthRefElement != null) dest.PreAuthRefElement = new List<FhirString>(PreAuthRefElement.DeepCopy());
                    if (ClaimResponse != null) dest.ClaimResponse = (ResourceReference)ClaimResponse.DeepCopy();
                    if (OriginalRuleset != null) dest.OriginalRuleset = (Coding)OriginalRuleset.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new CoverageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CoverageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.Matches(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
                if (!DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.Matches(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
                if (!DeepComparable.Matches(ClaimResponse, otherT.ClaimResponse)) return false;
                if (!DeepComparable.Matches(OriginalRuleset, otherT.OriginalRuleset)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CoverageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.IsExactly(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
                if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.IsExactly(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
                if (!DeepComparable.IsExactly(ClaimResponse, otherT.ClaimResponse)) return false;
                if (!DeepComparable.IsExactly(OriginalRuleset, otherT.OriginalRuleset)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (FocalElement != null) yield return FocalElement;
                    if (Coverage != null) yield return Coverage;
                    if (BusinessArrangementElement != null) yield return BusinessArrangementElement;
                    if (Relationship != null) yield return Relationship;
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return elem; }
                    if (ClaimResponse != null) yield return ClaimResponse;
                    if (OriginalRuleset != null) yield return OriginalRuleset;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (FocalElement != null) yield return new ElementValue("focal", FocalElement);
                    if (Coverage != null) yield return new ElementValue("coverage", Coverage);
                    if (BusinessArrangementElement != null) yield return new ElementValue("businessArrangement", BusinessArrangementElement);
                    if (Relationship != null) yield return new ElementValue("relationship", Relationship);
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return new ElementValue("preAuthRef", elem); }
                    if (ClaimResponse != null) yield return new ElementValue("claimResponse", ClaimResponse);
                    if (OriginalRuleset != null) yield return new ElementValue("originalRuleset", OriginalRuleset);
                }
            }


        }


        [FhirType("ItemsComponent")]
        [DataContract]
        public partial class ItemsComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemsComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequence", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Service instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Group or type of product or service
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Responsible practitioner
            /// </summary>
            [FhirElement("provider", InSummary = true, Order = 60)]
            [References("Practitioner")]
            [DataMember]
            public ResourceReference Provider
            {
                get { return _provider; }
                set { _provider = value; OnPropertyChanged("Provider"); }
            }

            private ResourceReference _provider;

            /// <summary>
            /// Diagnosis Link
            /// </summary>
            [FhirElement("diagnosisLinkId", InSummary = true, Order = 70)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<PositiveInt> DiagnosisLinkIdElement
            {
                get { if (_diagnosisLinkIdElement == null) _diagnosisLinkIdElement = new List<PositiveInt>(); return _diagnosisLinkIdElement; }
                set { _diagnosisLinkIdElement = value; OnPropertyChanged("DiagnosisLinkIdElement"); }
            }

            private List<PositiveInt> _diagnosisLinkIdElement;

            /// <summary>
            /// Diagnosis Link
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> DiagnosisLinkId
            {
                get { return DiagnosisLinkIdElement != null ? DiagnosisLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        DiagnosisLinkIdElement = null;
                    else
                        DiagnosisLinkIdElement = new List<PositiveInt>(value.Select(elem => new PositiveInt(elem)));
                    OnPropertyChanged("DiagnosisLinkId");
                }
            }

            /// <summary>
            /// Item Code
            /// </summary>
            [FhirElement("service", InSummary = true, Order = 80)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private Coding _service;

            /// <summary>
            /// Date of Service
            /// </summary>
            [FhirElement("serviceDate", InSummary = true, Order = 90)]
            [DataMember]
            public Date ServiceDateElement
            {
                get { return _serviceDateElement; }
                set { _serviceDateElement = value; OnPropertyChanged("ServiceDateElement"); }
            }

            private Date _serviceDateElement;

            /// <summary>
            /// Date of Service
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ServiceDate
            {
                get { return ServiceDateElement != null ? ServiceDateElement.Value : null; }
                set
                {
                    if (value == null)
                        ServiceDateElement = null;
                    else
                        ServiceDateElement = new Date(value);
                    OnPropertyChanged("ServiceDate");
                }
            }

            /// <summary>
            /// Count of Products or Services
            /// </summary>
            [FhirElement("quantity", InSummary = true, Order = 100)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Fee, charge or cost per point
            /// </summary>
            [FhirElement("unitPrice", InSummary = true, Order = 110)]
            [DataMember]
            public Money UnitPrice
            {
                get { return _unitPrice; }
                set { _unitPrice = value; OnPropertyChanged("UnitPrice"); }
            }

            private Money _unitPrice;

            /// <summary>
            /// Price scaling factor
            /// </summary>
            [FhirElement("factor", InSummary = true, Order = 120)]
            [DataMember]
            public FhirDecimal FactorElement
            {
                get { return _factorElement; }
                set { _factorElement = value; OnPropertyChanged("FactorElement"); }
            }

            private FhirDecimal _factorElement;

            /// <summary>
            /// Price scaling factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Difficulty scaling factor
            /// </summary>
            [FhirElement("points", InSummary = true, Order = 130)]
            [DataMember]
            public FhirDecimal PointsElement
            {
                get { return _pointsElement; }
                set { _pointsElement = value; OnPropertyChanged("PointsElement"); }
            }

            private FhirDecimal _pointsElement;

            /// <summary>
            /// Difficulty scaling factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Points
            {
                get { return PointsElement != null ? PointsElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        PointsElement = null;
                    else
                        PointsElement = new FhirDecimal(value);
                    OnPropertyChanged("Points");
                }
            }

            /// <summary>
            /// Total item cost
            /// </summary>
            [FhirElement("net", InSummary = true, Order = 140)]
            [DataMember]
            public Money Net
            {
                get { return _net; }
                set { _net = value; OnPropertyChanged("Net"); }
            }

            private Money _net;

            /// <summary>
            /// Unique Device Identifier
            /// </summary>
            [FhirElement("udi", InSummary = true, Order = 150)]
            [DataMember]
            public Coding Udi
            {
                get { return _udi; }
                set { _udi = value; OnPropertyChanged("Udi"); }
            }

            private Coding _udi;

            /// <summary>
            /// Service Location
            /// </summary>
            [FhirElement("bodySite", InSummary = true, Order = 160)]
            [DataMember]
            public Coding BodySite
            {
                get { return _bodySite; }
                set { _bodySite = value; OnPropertyChanged("BodySite"); }
            }

            private Coding _bodySite;

            /// <summary>
            /// Service Sub-location
            /// </summary>
            [FhirElement("subSite", InSummary = true, Order = 170)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<Coding> SubSite
            {
                get { if (_subSite == null) _subSite = new List<Coding>(); return _subSite; }
                set { _subSite = value; OnPropertyChanged("SubSite"); }
            }

            private List<Coding> _subSite;

            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", InSummary = true, Order = 180)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<Coding> Modifier
            {
                get { if (_modifier == null) _modifier = new List<Coding>(); return _modifier; }
                set { _modifier = value; OnPropertyChanged("Modifier"); }
            }

            private List<Coding> _modifier;

            /// <summary>
            /// Additional items
            /// </summary>
            [FhirElement("detail", InSummary = true, Order = 190)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<DetailComponent> Detail
            {
                get { if (_detail == null) _detail = new List<DetailComponent>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<DetailComponent> _detail;

            /// <summary>
            /// Prosthetic details
            /// </summary>
            [FhirElement("prosthesis", InSummary = true, Order = 200)]
            [DataMember]
            public ProsthesisComponent Prosthesis
            {
                get { return _prosthesis; }
                set { _prosthesis = value; OnPropertyChanged("Prosthesis"); }
            }

            private ProsthesisComponent _prosthesis;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemsComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                    if (DiagnosisLinkIdElement != null) dest.DiagnosisLinkIdElement = new List<PositiveInt>(DiagnosisLinkIdElement.DeepCopy());
                    if (Service != null) dest.Service = (Coding)Service.DeepCopy();
                    if (ServiceDateElement != null) dest.ServiceDateElement = (Date)ServiceDateElement.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (PointsElement != null) dest.PointsElement = (FhirDecimal)PointsElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
                    if (Udi != null) dest.Udi = (Coding)Udi.DeepCopy();
                    if (BodySite != null) dest.BodySite = (Coding)BodySite.DeepCopy();
                    if (SubSite != null) dest.SubSite = new List<Coding>(SubSite.DeepCopy());
                    if (Modifier != null) dest.Modifier = new List<Coding>(Modifier.DeepCopy());
                    if (Detail != null) dest.Detail = new List<DetailComponent>(Detail.DeepCopy());
                    if (Prosthesis != null) dest.Prosthesis = (ProsthesisComponent)Prosthesis.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ItemsComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ItemsComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
                if (!DeepComparable.Matches(DiagnosisLinkIdElement, otherT.DiagnosisLinkIdElement)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if (!DeepComparable.Matches(ServiceDateElement, otherT.ServiceDateElement)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;
                if (!DeepComparable.Matches(Udi, otherT.Udi)) return false;
                if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
                if (!DeepComparable.Matches(SubSite, otherT.SubSite)) return false;
                if (!DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.Matches(Detail, otherT.Detail)) return false;
                if (!DeepComparable.Matches(Prosthesis, otherT.Prosthesis)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemsComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
                if (!DeepComparable.IsExactly(DiagnosisLinkIdElement, otherT.DiagnosisLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(ServiceDateElement, otherT.ServiceDateElement)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if (!DeepComparable.IsExactly(Udi, otherT.Udi)) return false;
                if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
                if (!DeepComparable.IsExactly(SubSite, otherT.SubSite)) return false;
                if (!DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
                if (!DeepComparable.IsExactly(Prosthesis, otherT.Prosthesis)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (Type != null) yield return Type;
                    if (Provider != null) yield return Provider;
                    foreach (var elem in DiagnosisLinkIdElement) { if (elem != null) yield return elem; }
                    if (Service != null) yield return Service;
                    if (ServiceDateElement != null) yield return ServiceDateElement;
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (PointsElement != null) yield return PointsElement;
                    if (Net != null) yield return Net;
                    if (Udi != null) yield return Udi;
                    if (BodySite != null) yield return BodySite;
                    foreach (var elem in SubSite) { if (elem != null) yield return elem; }
                    foreach (var elem in Modifier) { if (elem != null) yield return elem; }
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                    if (Prosthesis != null) yield return Prosthesis;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Provider != null) yield return new ElementValue("provider", Provider);
                    foreach (var elem in DiagnosisLinkIdElement) { if (elem != null) yield return new ElementValue("diagnosisLinkId", elem); }
                    if (Service != null) yield return new ElementValue("service", Service);
                    if (ServiceDateElement != null) yield return new ElementValue("serviceDate", ServiceDateElement);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (PointsElement != null) yield return new ElementValue("points", PointsElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                    if (Udi != null) yield return new ElementValue("udi", Udi);
                    if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                    foreach (var elem in SubSite) { if (elem != null) yield return new ElementValue("subSite", elem); }
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", elem); }
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
                    if (Prosthesis != null) yield return new ElementValue("prosthesis", Prosthesis);
                }
            }


        }


        [FhirType("DetailComponent")]
        [DataContract]
        public partial class DetailComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DetailComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequence", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Service instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Group or type of product or service
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Additional item codes
            /// </summary>
            [FhirElement("service", InSummary = true, Order = 60)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private Coding _service;

            /// <summary>
            /// Count of Products or Services
            /// </summary>
            [FhirElement("quantity", InSummary = true, Order = 70)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Fee, charge or cost per point
            /// </summary>
            [FhirElement("unitPrice", InSummary = true, Order = 80)]
            [DataMember]
            public Money UnitPrice
            {
                get { return _unitPrice; }
                set { _unitPrice = value; OnPropertyChanged("UnitPrice"); }
            }

            private Money _unitPrice;

            /// <summary>
            /// Price scaling factor
            /// </summary>
            [FhirElement("factor", InSummary = true, Order = 90)]
            [DataMember]
            public FhirDecimal FactorElement
            {
                get { return _factorElement; }
                set { _factorElement = value; OnPropertyChanged("FactorElement"); }
            }

            private FhirDecimal _factorElement;

            /// <summary>
            /// Price scaling factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Difficulty scaling factor
            /// </summary>
            [FhirElement("points", InSummary = true, Order = 100)]
            [DataMember]
            public FhirDecimal PointsElement
            {
                get { return _pointsElement; }
                set { _pointsElement = value; OnPropertyChanged("PointsElement"); }
            }

            private FhirDecimal _pointsElement;

            /// <summary>
            /// Difficulty scaling factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Points
            {
                get { return PointsElement != null ? PointsElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        PointsElement = null;
                    else
                        PointsElement = new FhirDecimal(value);
                    OnPropertyChanged("Points");
                }
            }

            /// <summary>
            /// Total additional item cost
            /// </summary>
            [FhirElement("net", InSummary = true, Order = 110)]
            [DataMember]
            public Money Net
            {
                get { return _net; }
                set { _net = value; OnPropertyChanged("Net"); }
            }

            private Money _net;

            /// <summary>
            /// Unique Device Identifier
            /// </summary>
            [FhirElement("udi", InSummary = true, Order = 120)]
            [DataMember]
            public Coding Udi
            {
                get { return _udi; }
                set { _udi = value; OnPropertyChanged("Udi"); }
            }

            private Coding _udi;

            /// <summary>
            /// Additional items
            /// </summary>
            [FhirElement("subDetail", InSummary = true, Order = 130)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<SubDetailComponent> SubDetail
            {
                get { if (_subDetail == null) _subDetail = new List<SubDetailComponent>(); return _subDetail; }
                set { _subDetail = value; OnPropertyChanged("SubDetail"); }
            }

            private List<SubDetailComponent> _subDetail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Service != null) dest.Service = (Coding)Service.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (PointsElement != null) dest.PointsElement = (FhirDecimal)PointsElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
                    if (Udi != null) dest.Udi = (Coding)Udi.DeepCopy();
                    if (SubDetail != null) dest.SubDetail = new List<SubDetailComponent>(SubDetail.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new DetailComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DetailComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;
                if (!DeepComparable.Matches(Udi, otherT.Udi)) return false;
                if (!DeepComparable.Matches(SubDetail, otherT.SubDetail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if (!DeepComparable.IsExactly(Udi, otherT.Udi)) return false;
                if (!DeepComparable.IsExactly(SubDetail, otherT.SubDetail)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (Type != null) yield return Type;
                    if (Service != null) yield return Service;
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (PointsElement != null) yield return PointsElement;
                    if (Net != null) yield return Net;
                    if (Udi != null) yield return Udi;
                    foreach (var elem in SubDetail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Service != null) yield return new ElementValue("service", Service);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (PointsElement != null) yield return new ElementValue("points", PointsElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                    if (Udi != null) yield return new ElementValue("udi", Udi);
                    foreach (var elem in SubDetail) { if (elem != null) yield return new ElementValue("subDetail", elem); }
                }
            }


        }


        [FhirType("SubDetailComponent")]
        [DataContract]
        public partial class SubDetailComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubDetailComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequence", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Service instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Type of product or service
            /// </summary>
            [FhirElement("type", InSummary = true, Order = 50)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private Coding _type;

            /// <summary>
            /// Additional item codes
            /// </summary>
            [FhirElement("service", InSummary = true, Order = 60)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private Coding _service;

            /// <summary>
            /// Count of Products or Services
            /// </summary>
            [FhirElement("quantity", InSummary = true, Order = 70)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Fee, charge or cost per point
            /// </summary>
            [FhirElement("unitPrice", InSummary = true, Order = 80)]
            [DataMember]
            public Money UnitPrice
            {
                get { return _unitPrice; }
                set { _unitPrice = value; OnPropertyChanged("UnitPrice"); }
            }

            private Money _unitPrice;

            /// <summary>
            /// Price scaling factor
            /// </summary>
            [FhirElement("factor", InSummary = true, Order = 90)]
            [DataMember]
            public FhirDecimal FactorElement
            {
                get { return _factorElement; }
                set { _factorElement = value; OnPropertyChanged("FactorElement"); }
            }

            private FhirDecimal _factorElement;

            /// <summary>
            /// Price scaling factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Difficulty scaling factor
            /// </summary>
            [FhirElement("points", InSummary = true, Order = 100)]
            [DataMember]
            public FhirDecimal PointsElement
            {
                get { return _pointsElement; }
                set { _pointsElement = value; OnPropertyChanged("PointsElement"); }
            }

            private FhirDecimal _pointsElement;

            /// <summary>
            /// Difficulty scaling factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Points
            {
                get { return PointsElement != null ? PointsElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        PointsElement = null;
                    else
                        PointsElement = new FhirDecimal(value);
                    OnPropertyChanged("Points");
                }
            }

            /// <summary>
            /// Net additional item cost
            /// </summary>
            [FhirElement("net", InSummary = true, Order = 110)]
            [DataMember]
            public Money Net
            {
                get { return _net; }
                set { _net = value; OnPropertyChanged("Net"); }
            }

            private Money _net;

            /// <summary>
            /// Unique Device Identifier
            /// </summary>
            [FhirElement("udi", InSummary = true, Order = 120)]
            [DataMember]
            public Coding Udi
            {
                get { return _udi; }
                set { _udi = value; OnPropertyChanged("Udi"); }
            }

            private Coding _udi;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubDetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Type != null) dest.Type = (Coding)Type.DeepCopy();
                    if (Service != null) dest.Service = (Coding)Service.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (PointsElement != null) dest.PointsElement = (FhirDecimal)PointsElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
                    if (Udi != null) dest.Udi = (Coding)Udi.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SubDetailComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubDetailComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;
                if (!DeepComparable.Matches(Udi, otherT.Udi)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubDetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(PointsElement, otherT.PointsElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if (!DeepComparable.IsExactly(Udi, otherT.Udi)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (Type != null) yield return Type;
                    if (Service != null) yield return Service;
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (PointsElement != null) yield return PointsElement;
                    if (Net != null) yield return Net;
                    if (Udi != null) yield return Udi;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Service != null) yield return new ElementValue("service", Service);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (PointsElement != null) yield return new ElementValue("points", PointsElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                    if (Udi != null) yield return new ElementValue("udi", Udi);
                }
            }


        }


        [FhirType("ProsthesisComponent")]
        [DataContract]
        public partial class ProsthesisComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ProsthesisComponent"; } }

            /// <summary>
            /// Is this the initial service
            /// </summary>
            [FhirElement("initial", InSummary = true, Order = 40)]
            [DataMember]
            public FhirBoolean InitialElement
            {
                get { return _initialElement; }
                set { _initialElement = value; OnPropertyChanged("InitialElement"); }
            }

            private FhirBoolean _initialElement;

            /// <summary>
            /// Is this the initial service
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Initial
            {
                get { return InitialElement != null ? InitialElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        InitialElement = null;
                    else
                        InitialElement = new FhirBoolean(value);
                    OnPropertyChanged("Initial");
                }
            }

            /// <summary>
            /// Initial service Date
            /// </summary>
            [FhirElement("priorDate", InSummary = true, Order = 50)]
            [DataMember]
            public Date PriorDateElement
            {
                get { return _priorDateElement; }
                set { _priorDateElement = value; OnPropertyChanged("PriorDateElement"); }
            }

            private Date _priorDateElement;

            /// <summary>
            /// Initial service Date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string PriorDate
            {
                get { return PriorDateElement != null ? PriorDateElement.Value : null; }
                set
                {
                    if (value == null)
                        PriorDateElement = null;
                    else
                        PriorDateElement = new Date(value);
                    OnPropertyChanged("PriorDate");
                }
            }

            /// <summary>
            /// Prosthetic Material
            /// </summary>
            [FhirElement("priorMaterial", InSummary = true, Order = 60)]
            [DataMember]
            public Coding PriorMaterial
            {
                get { return _priorMaterial; }
                set { _priorMaterial = value; OnPropertyChanged("PriorMaterial"); }
            }

            private Coding _priorMaterial;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProsthesisComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (InitialElement != null) dest.InitialElement = (FhirBoolean)InitialElement.DeepCopy();
                    if (PriorDateElement != null) dest.PriorDateElement = (Date)PriorDateElement.DeepCopy();
                    if (PriorMaterial != null) dest.PriorMaterial = (Coding)PriorMaterial.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ProsthesisComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProsthesisComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(InitialElement, otherT.InitialElement)) return false;
                if (!DeepComparable.Matches(PriorDateElement, otherT.PriorDateElement)) return false;
                if (!DeepComparable.Matches(PriorMaterial, otherT.PriorMaterial)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProsthesisComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(InitialElement, otherT.InitialElement)) return false;
                if (!DeepComparable.IsExactly(PriorDateElement, otherT.PriorDateElement)) return false;
                if (!DeepComparable.IsExactly(PriorMaterial, otherT.PriorMaterial)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (InitialElement != null) yield return InitialElement;
                    if (PriorDateElement != null) yield return PriorDateElement;
                    if (PriorMaterial != null) yield return PriorMaterial;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (InitialElement != null) yield return new ElementValue("initial", InitialElement);
                    if (PriorDateElement != null) yield return new ElementValue("priorDate", PriorDateElement);
                    if (PriorMaterial != null) yield return new ElementValue("priorMaterial", PriorMaterial);
                }
            }


        }


        [FhirType("MissingTeethComponent")]
        [DataContract]
        public partial class MissingTeethComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MissingTeethComponent"; } }

            /// <summary>
            /// Tooth Code
            /// </summary>
            [FhirElement("tooth", InSummary = true, Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public Coding Tooth
            {
                get { return _tooth; }
                set { _tooth = value; OnPropertyChanged("Tooth"); }
            }

            private Coding _tooth;

            /// <summary>
            /// Reason for missing
            /// </summary>
            [FhirElement("reason", InSummary = true, Order = 50)]
            [DataMember]
            public Coding Reason
            {
                get { return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private Coding _reason;

            /// <summary>
            /// Date of Extraction
            /// </summary>
            [FhirElement("extractionDate", InSummary = true, Order = 60)]
            [DataMember]
            public Date ExtractionDateElement
            {
                get { return _extractionDateElement; }
                set { _extractionDateElement = value; OnPropertyChanged("ExtractionDateElement"); }
            }

            private Date _extractionDateElement;

            /// <summary>
            /// Date of Extraction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string ExtractionDate
            {
                get { return ExtractionDateElement != null ? ExtractionDateElement.Value : null; }
                set
                {
                    if (value == null)
                        ExtractionDateElement = null;
                    else
                        ExtractionDateElement = new Date(value);
                    OnPropertyChanged("ExtractionDate");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MissingTeethComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Tooth != null) dest.Tooth = (Coding)Tooth.DeepCopy();
                    if (Reason != null) dest.Reason = (Coding)Reason.DeepCopy();
                    if (ExtractionDateElement != null) dest.ExtractionDateElement = (Date)ExtractionDateElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new MissingTeethComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MissingTeethComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Tooth, otherT.Tooth)) return false;
                if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if (!DeepComparable.Matches(ExtractionDateElement, otherT.ExtractionDateElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MissingTeethComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Tooth, otherT.Tooth)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if (!DeepComparable.IsExactly(ExtractionDateElement, otherT.ExtractionDateElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Tooth != null) yield return Tooth;
                    if (Reason != null) yield return Reason;
                    if (ExtractionDateElement != null) yield return ExtractionDateElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Tooth != null) yield return new ElementValue("tooth", Tooth);
                    if (Reason != null) yield return new ElementValue("reason", Reason);
                    if (ExtractionDateElement != null) yield return new ElementValue("extractionDate", ExtractionDateElement);
                }
            }


        }


        /// <summary>
        /// institutional | oral | pharmacy | professional | vision
        /// </summary>
        [FhirElement("type", InSummary = true, Order = 90)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public Code<ClaimType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<ClaimType> _typeElement;

        /// <summary>
        /// institutional | oral | pharmacy | professional | vision
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ClaimType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    TypeElement = null;
                else
                    TypeElement = new Code<ClaimType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Claim number
        /// </summary>
        [FhirElement("identifier", InSummary = true, Order = 100)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Current specification followed
        /// </summary>
        [FhirElement("ruleset", InSummary = true, Order = 110)]
        [DataMember]
        public Coding Ruleset
        {
            get { return _ruleset; }
            set { _ruleset = value; OnPropertyChanged("Ruleset"); }
        }

        private Coding _ruleset;

        /// <summary>
        /// Original specification followed
        /// </summary>
        [FhirElement("originalRuleset", InSummary = true, Order = 120)]
        [DataMember]
        public Coding OriginalRuleset
        {
            get { return _originalRuleset; }
            set { _originalRuleset = value; OnPropertyChanged("OriginalRuleset"); }
        }

        private Coding _originalRuleset;

        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", InSummary = true, Order = 130)]
        [DataMember]
        public FhirDateTime CreatedElement
        {
            get { return _createdElement; }
            set { _createdElement = value; OnPropertyChanged("CreatedElement"); }
        }

        private FhirDateTime _createdElement;

        /// <summary>
        /// Creation date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if (value == null)
                    CreatedElement = null;
                else
                    CreatedElement = new FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }

        /// <summary>
        /// Insurer
        /// </summary>
        [FhirElement("target", InSummary = true, Order = 140)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Target
        {
            get { return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private ResourceReference _target;

        /// <summary>
        /// Responsible provider
        /// </summary>
        [FhirElement("provider", InSummary = true, Order = 150)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Provider
        {
            get { return _provider; }
            set { _provider = value; OnPropertyChanged("Provider"); }
        }

        private ResourceReference _provider;

        /// <summary>
        /// Responsible organization
        /// </summary>
        [FhirElement("organization", InSummary = true, Order = 160)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private ResourceReference _organization;

        /// <summary>
        /// complete | proposed | exploratory | other
        /// </summary>
        [FhirElement("use", InSummary = true, Order = 170)]
        [DataMember]
        public Code<Use> UseElement
        {
            get { return _useElement; }
            set { _useElement = value; OnPropertyChanged("UseElement"); }
        }

        private Code<Use> _useElement;

        /// <summary>
        /// complete | proposed | exploratory | other
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public Use? Use_
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    UseElement = null;
                else
                    UseElement = new Code<Use>(value);
                OnPropertyChanged("Use_");
            }
        }

        /// <summary>
        /// Desired processing priority
        /// </summary>
        [FhirElement("priority", InSummary = true, Order = 180)]
        [DataMember]
        public Coding Priority
        {
            get { return _priority; }
            set { _priority = value; OnPropertyChanged("Priority"); }
        }

        private Coding _priority;

        /// <summary>
        /// Funds requested to be reserved
        /// </summary>
        [FhirElement("fundsReserve", InSummary = true, Order = 190)]
        [DataMember]
        public Coding FundsReserve
        {
            get { return _fundsReserve; }
            set { _fundsReserve = value; OnPropertyChanged("FundsReserve"); }
        }

        private Coding _fundsReserve;

        /// <summary>
        /// Author
        /// </summary>
        [FhirElement("enterer", InSummary = true, Order = 200)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Enterer
        {
            get { return _enterer; }
            set { _enterer = value; OnPropertyChanged("Enterer"); }
        }

        private ResourceReference _enterer;

        /// <summary>
        /// Servicing Facility
        /// </summary>
        [FhirElement("facility", InSummary = true, Order = 210)]
        [References("Location")]
        [DataMember]
        public ResourceReference Facility
        {
            get { return _facility; }
            set { _facility = value; OnPropertyChanged("Facility"); }
        }

        private ResourceReference _facility;

        /// <summary>
        /// Prescription
        /// </summary>
        [FhirElement("prescription", InSummary = true, Order = 220)]
        [References("MedicationOrder", "VisionPrescription")]
        [DataMember]
        public ResourceReference Prescription
        {
            get { return _prescription; }
            set { _prescription = value; OnPropertyChanged("Prescription"); }
        }

        private ResourceReference _prescription;

        /// <summary>
        /// Original Prescription
        /// </summary>
        [FhirElement("originalPrescription", InSummary = true, Order = 230)]
        [References("MedicationOrder")]
        [DataMember]
        public ResourceReference OriginalPrescription
        {
            get { return _originalPrescription; }
            set { _originalPrescription = value; OnPropertyChanged("OriginalPrescription"); }
        }

        private ResourceReference _originalPrescription;

        /// <summary>
        /// Payee
        /// </summary>
        [FhirElement("payee", InSummary = true, Order = 240)]
        [DataMember]
        public PayeeComponent Payee
        {
            get { return _payee; }
            set { _payee = value; OnPropertyChanged("Payee"); }
        }

        private PayeeComponent _payee;

        /// <summary>
        /// Treatment Referral
        /// </summary>
        [FhirElement("referral", InSummary = true, Order = 250)]
        [References("ReferralRequest")]
        [DataMember]
        public ResourceReference Referral
        {
            get { return _referral; }
            set { _referral = value; OnPropertyChanged("Referral"); }
        }

        private ResourceReference _referral;

        /// <summary>
        /// Diagnosis
        /// </summary>
        [FhirElement("diagnosis", InSummary = true, Order = 260)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<DiagnosisComponent> Diagnosis
        {
            get { if (_diagnosis == null) _diagnosis = new List<DiagnosisComponent>(); return _diagnosis; }
            set { _diagnosis = value; OnPropertyChanged("Diagnosis"); }
        }

        private List<DiagnosisComponent> _diagnosis;

        /// <summary>
        /// List of presenting Conditions
        /// </summary>
        [FhirElement("condition", InSummary = true, Order = 270)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Coding> Condition
        {
            get { if (_condition == null) _condition = new List<Coding>(); return _condition; }
            set { _condition = value; OnPropertyChanged("Condition"); }
        }

        private List<Coding> _condition;

        /// <summary>
        /// The subject of the Products and Services
        /// </summary>
        [FhirElement("patient", InSummary = true, Order = 280)]
        [References("Patient")]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Insurance or medical plan
        /// </summary>
        [FhirElement("coverage", InSummary = true, Order = 290)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CoverageComponent> Coverage
        {
            get { if (_coverage == null) _coverage = new List<CoverageComponent>(); return _coverage; }
            set { _coverage = value; OnPropertyChanged("Coverage"); }
        }

        private List<CoverageComponent> _coverage;

        /// <summary>
        /// Eligibility exceptions
        /// </summary>
        [FhirElement("exception", InSummary = true, Order = 300)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Coding> Exception
        {
            get { if (_exception == null) _exception = new List<Coding>(); return _exception; }
            set { _exception = value; OnPropertyChanged("Exception"); }
        }

        private List<Coding> _exception;

        /// <summary>
        /// Name of School
        /// </summary>
        [FhirElement("school", InSummary = true, Order = 310)]
        [DataMember]
        public FhirString SchoolElement
        {
            get { return _schoolElement; }
            set { _schoolElement = value; OnPropertyChanged("SchoolElement"); }
        }

        private FhirString _schoolElement;

        /// <summary>
        /// Name of School
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string School
        {
            get { return SchoolElement != null ? SchoolElement.Value : null; }
            set
            {
                if (value == null)
                    SchoolElement = null;
                else
                    SchoolElement = new FhirString(value);
                OnPropertyChanged("School");
            }
        }

        /// <summary>
        /// Accident Date
        /// </summary>
        [FhirElement("accident", InSummary = true, Order = 320)]
        [DataMember]
        public Date AccidentElement
        {
            get { return _accidentElement; }
            set { _accidentElement = value; OnPropertyChanged("AccidentElement"); }
        }

        private Date _accidentElement;

        /// <summary>
        /// Accident Date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Accident
        {
            get { return AccidentElement != null ? AccidentElement.Value : null; }
            set
            {
                if (value == null)
                    AccidentElement = null;
                else
                    AccidentElement = new Date(value);
                OnPropertyChanged("Accident");
            }
        }

        /// <summary>
        /// Accident Type
        /// </summary>
        [FhirElement("accidentType", InSummary = true, Order = 330)]
        [DataMember]
        public Coding AccidentType
        {
            get { return _accidentType; }
            set { _accidentType = value; OnPropertyChanged("AccidentType"); }
        }

        private Coding _accidentType;

        /// <summary>
        /// Intervention and exception code (Pharma)
        /// </summary>
        [FhirElement("interventionException", InSummary = true, Order = 340)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Coding> InterventionException
        {
            get { if (_interventionException == null) _interventionException = new List<Coding>(); return _interventionException; }
            set { _interventionException = value; OnPropertyChanged("InterventionException"); }
        }

        private List<Coding> _interventionException;

        /// <summary>
        /// Goods and Services
        /// </summary>
        [FhirElement("item", InSummary = true, Order = 350)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ItemsComponent> Item
        {
            get { if (_item == null) _item = new List<ItemsComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<ItemsComponent> _item;

        /// <summary>
        /// Additional materials, documents, etc.
        /// </summary>
        [FhirElement("additionalMaterials", InSummary = true, Order = 360)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Coding> AdditionalMaterials
        {
            get { if (_additionalMaterials == null) _additionalMaterials = new List<Coding>(); return _additionalMaterials; }
            set { _additionalMaterials = value; OnPropertyChanged("AdditionalMaterials"); }
        }

        private List<Coding> _additionalMaterials;

        /// <summary>
        /// Only if type = oral
        /// </summary>
        [FhirElement("missingTeeth", InSummary = true, Order = 370)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<MissingTeethComponent> MissingTeeth
        {
            get { if (_missingTeeth == null) _missingTeeth = new List<MissingTeethComponent>(); return _missingTeeth; }
            set { _missingTeeth = value; OnPropertyChanged("MissingTeeth"); }
        }

        private List<MissingTeethComponent> _missingTeeth;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Claim;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (TypeElement != null) dest.TypeElement = (Code<ClaimType>)TypeElement.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Ruleset != null) dest.Ruleset = (Coding)Ruleset.DeepCopy();
                if (OriginalRuleset != null) dest.OriginalRuleset = (Coding)OriginalRuleset.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Target != null) dest.Target = (ResourceReference)Target.DeepCopy();
                if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (UseElement != null) dest.UseElement = (Code<Use>)UseElement.DeepCopy();
                if (Priority != null) dest.Priority = (Coding)Priority.DeepCopy();
                if (FundsReserve != null) dest.FundsReserve = (Coding)FundsReserve.DeepCopy();
                if (Enterer != null) dest.Enterer = (ResourceReference)Enterer.DeepCopy();
                if (Facility != null) dest.Facility = (ResourceReference)Facility.DeepCopy();
                if (Prescription != null) dest.Prescription = (ResourceReference)Prescription.DeepCopy();
                if (OriginalPrescription != null) dest.OriginalPrescription = (ResourceReference)OriginalPrescription.DeepCopy();
                if (Payee != null) dest.Payee = (PayeeComponent)Payee.DeepCopy();
                if (Referral != null) dest.Referral = (ResourceReference)Referral.DeepCopy();
                if (Diagnosis != null) dest.Diagnosis = new List<DiagnosisComponent>(Diagnosis.DeepCopy());
                if (Condition != null) dest.Condition = new List<Coding>(Condition.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Coverage != null) dest.Coverage = new List<CoverageComponent>(Coverage.DeepCopy());
                if (Exception != null) dest.Exception = new List<Coding>(Exception.DeepCopy());
                if (SchoolElement != null) dest.SchoolElement = (FhirString)SchoolElement.DeepCopy();
                if (AccidentElement != null) dest.AccidentElement = (Date)AccidentElement.DeepCopy();
                if (AccidentType != null) dest.AccidentType = (Coding)AccidentType.DeepCopy();
                if (InterventionException != null) dest.InterventionException = new List<Coding>(InterventionException.DeepCopy());
                if (Item != null) dest.Item = new List<ItemsComponent>(Item.DeepCopy());
                if (AdditionalMaterials != null) dest.AdditionalMaterials = new List<Coding>(AdditionalMaterials.DeepCopy());
                if (MissingTeeth != null) dest.MissingTeeth = new List<MissingTeethComponent>(MissingTeeth.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Claim());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Claim;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.Matches(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Target, otherT.Target)) return false;
            if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if (!DeepComparable.Matches(FundsReserve, otherT.FundsReserve)) return false;
            if (!DeepComparable.Matches(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.Matches(Facility, otherT.Facility)) return false;
            if (!DeepComparable.Matches(Prescription, otherT.Prescription)) return false;
            if (!DeepComparable.Matches(OriginalPrescription, otherT.OriginalPrescription)) return false;
            if (!DeepComparable.Matches(Payee, otherT.Payee)) return false;
            if (!DeepComparable.Matches(Referral, otherT.Referral)) return false;
            if (!DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
            if (!DeepComparable.Matches(Condition, otherT.Condition)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
            if (!DeepComparable.Matches(Exception, otherT.Exception)) return false;
            if (!DeepComparable.Matches(SchoolElement, otherT.SchoolElement)) return false;
            if (!DeepComparable.Matches(AccidentElement, otherT.AccidentElement)) return false;
            if (!DeepComparable.Matches(AccidentType, otherT.AccidentType)) return false;
            if (!DeepComparable.Matches(InterventionException, otherT.InterventionException)) return false;
            if (!DeepComparable.Matches(Item, otherT.Item)) return false;
            if (!DeepComparable.Matches(AdditionalMaterials, otherT.AdditionalMaterials)) return false;
            if (!DeepComparable.Matches(MissingTeeth, otherT.MissingTeeth)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Claim;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Ruleset, otherT.Ruleset)) return false;
            if (!DeepComparable.IsExactly(OriginalRuleset, otherT.OriginalRuleset)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if (!DeepComparable.IsExactly(FundsReserve, otherT.FundsReserve)) return false;
            if (!DeepComparable.IsExactly(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.IsExactly(Facility, otherT.Facility)) return false;
            if (!DeepComparable.IsExactly(Prescription, otherT.Prescription)) return false;
            if (!DeepComparable.IsExactly(OriginalPrescription, otherT.OriginalPrescription)) return false;
            if (!DeepComparable.IsExactly(Payee, otherT.Payee)) return false;
            if (!DeepComparable.IsExactly(Referral, otherT.Referral)) return false;
            if (!DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
            if (!DeepComparable.IsExactly(Condition, otherT.Condition)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
            if (!DeepComparable.IsExactly(Exception, otherT.Exception)) return false;
            if (!DeepComparable.IsExactly(SchoolElement, otherT.SchoolElement)) return false;
            if (!DeepComparable.IsExactly(AccidentElement, otherT.AccidentElement)) return false;
            if (!DeepComparable.IsExactly(AccidentType, otherT.AccidentType)) return false;
            if (!DeepComparable.IsExactly(InterventionException, otherT.InterventionException)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
            if (!DeepComparable.IsExactly(AdditionalMaterials, otherT.AdditionalMaterials)) return false;
            if (!DeepComparable.IsExactly(MissingTeeth, otherT.MissingTeeth)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (TypeElement != null) yield return TypeElement;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Ruleset != null) yield return Ruleset;
                if (OriginalRuleset != null) yield return OriginalRuleset;
                if (CreatedElement != null) yield return CreatedElement;
                if (Target != null) yield return Target;
                if (Provider != null) yield return Provider;
                if (Organization != null) yield return Organization;
                if (UseElement != null) yield return UseElement;
                if (Priority != null) yield return Priority;
                if (FundsReserve != null) yield return FundsReserve;
                if (Enterer != null) yield return Enterer;
                if (Facility != null) yield return Facility;
                if (Prescription != null) yield return Prescription;
                if (OriginalPrescription != null) yield return OriginalPrescription;
                if (Payee != null) yield return Payee;
                if (Referral != null) yield return Referral;
                foreach (var elem in Diagnosis) { if (elem != null) yield return elem; }
                foreach (var elem in Condition) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
                foreach (var elem in Coverage) { if (elem != null) yield return elem; }
                foreach (var elem in Exception) { if (elem != null) yield return elem; }
                if (SchoolElement != null) yield return SchoolElement;
                if (AccidentElement != null) yield return AccidentElement;
                if (AccidentType != null) yield return AccidentType;
                foreach (var elem in InterventionException) { if (elem != null) yield return elem; }
                foreach (var elem in Item) { if (elem != null) yield return elem; }
                foreach (var elem in AdditionalMaterials) { if (elem != null) yield return elem; }
                foreach (var elem in MissingTeeth) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Ruleset != null) yield return new ElementValue("ruleset", Ruleset);
                if (OriginalRuleset != null) yield return new ElementValue("originalRuleset", OriginalRuleset);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Target != null) yield return new ElementValue("target", Target);
                if (Provider != null) yield return new ElementValue("provider", Provider);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                if (UseElement != null) yield return new ElementValue("use", UseElement);
                if (Priority != null) yield return new ElementValue("priority", Priority);
                if (FundsReserve != null) yield return new ElementValue("fundsReserve", FundsReserve);
                if (Enterer != null) yield return new ElementValue("enterer", Enterer);
                if (Facility != null) yield return new ElementValue("facility", Facility);
                if (Prescription != null) yield return new ElementValue("prescription", Prescription);
                if (OriginalPrescription != null) yield return new ElementValue("originalPrescription", OriginalPrescription);
                if (Payee != null) yield return new ElementValue("payee", Payee);
                if (Referral != null) yield return new ElementValue("referral", Referral);
                foreach (var elem in Diagnosis) { if (elem != null) yield return new ElementValue("diagnosis", elem); }
                foreach (var elem in Condition) { if (elem != null) yield return new ElementValue("condition", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
                foreach (var elem in Coverage) { if (elem != null) yield return new ElementValue("coverage", elem); }
                foreach (var elem in Exception) { if (elem != null) yield return new ElementValue("exception", elem); }
                if (SchoolElement != null) yield return new ElementValue("school", SchoolElement);
                if (AccidentElement != null) yield return new ElementValue("accident", AccidentElement);
                if (AccidentType != null) yield return new ElementValue("accidentType", AccidentType);
                foreach (var elem in InterventionException) { if (elem != null) yield return new ElementValue("interventionException", elem); }
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
                foreach (var elem in AdditionalMaterials) { if (elem != null) yield return new ElementValue("additionalMaterials", elem); }
                foreach (var elem in MissingTeeth) { if (elem != null) yield return new ElementValue("missingTeeth", elem); }
            }
        }

    }

}
