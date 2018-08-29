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
    /// Explanation of Benefit resource
    /// </summary>
    [FhirType("ExplanationOfBenefit", IsResource=true)]
    [DataContract]
    public partial class ExplanationOfBenefit : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ExplanationOfBenefit; } }
        [NotMapped]
        public override string TypeName { get { return "ExplanationOfBenefit"; } }


        [FhirType("RelatedClaimComponent")]
        [DataContract]
        public partial class RelatedClaimComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedClaimComponent"; } }

            /// <summary>
            /// Reference to the related claim
            /// </summary>
            [FhirElement("claim", Order=40)]
            [References("Claim")]
            [DataMember]
            public ResourceReference Claim
            {
                get { return _claim; }
                set { _claim = value; OnPropertyChanged("Claim"); }
            }

            private ResourceReference _claim;

            /// <summary>
            /// How the reference claim is related
            /// </summary>
            [FhirElement("relationship", Order=50)]
            [DataMember]
            public CodeableConcept Relationship
            {
                get { return _relationship; }
                set { _relationship = value; OnPropertyChanged("Relationship"); }
            }

            private CodeableConcept _relationship;

            /// <summary>
            /// Related file or case reference
            /// </summary>
            [FhirElement("reference", Order=60)]
            [DataMember]
            public Identifier Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private Identifier _reference;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatedClaimComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Claim != null) dest.Claim = (ResourceReference)Claim.DeepCopy();
                    if (Relationship != null) dest.Relationship = (CodeableConcept)Relationship.DeepCopy();
                    if (Reference != null) dest.Reference = (Identifier)Reference.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelatedClaimComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatedClaimComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Claim, otherT.Claim)) return false;
                if (!DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedClaimComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Claim, otherT.Claim)) return false;
                if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Claim != null) yield return Claim;
                    if (Relationship != null) yield return Relationship;
                    if (Reference != null) yield return Reference;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Claim != null) yield return new ElementValue("claim", false, Claim);
                    if (Relationship != null) yield return new ElementValue("relationship", false, Relationship);
                    if (Reference != null) yield return new ElementValue("reference", false, Reference);
                }
            }


        }


        [FhirType("PayeeComponent")]
        [DataContract]
        public partial class PayeeComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PayeeComponent"; } }

            /// <summary>
            /// Type of party: Subscriber, Provider, other
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
            /// organization | patient | practitioner | relatedperson
            /// </summary>
            [FhirElement("resource", Order=50)]
            [DataMember]
            public Coding Resource
            {
                get { return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private Coding _resource;

            /// <summary>
            /// Party to receive the payable
            /// </summary>
            [FhirElement("party", Order=60)]
            [References("Practitioner","PractitionerRole","Organization","Patient","RelatedPerson")]
            [DataMember]
            public ResourceReference Party
            {
                get { return _party; }
                set { _party = value; OnPropertyChanged("Party"); }
            }

            private ResourceReference _party;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PayeeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Resource != null) dest.Resource = (Coding)Resource.DeepCopy();
                    if (Party != null) dest.Party = (ResourceReference)Party.DeepCopy();
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
                if (!DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if (!DeepComparable.Matches(Party, otherT.Party)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PayeeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Party, otherT.Party)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Resource != null) yield return Resource;
                    if (Party != null) yield return Party;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Resource != null) yield return new ElementValue("resource", false, Resource);
                    if (Party != null) yield return new ElementValue("party", false, Party);
                }
            }


        }


        [FhirType("SupportingInformationComponent")]
        [DataContract]
        public partial class SupportingInformationComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SupportingInformationComponent"; } }

            /// <summary>
            /// Information instance identifier
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Information instance identifier
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// General class of information
            /// </summary>
            [FhirElement("category", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Type of information
            /// </summary>
            [FhirElement("code", Order=60)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// When it occurred
            /// </summary>
            [FhirElement("timing", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Date),typeof(Period))]
            [DataMember]
            public Element Timing
            {
                get { return _timing; }
                set { _timing = value; OnPropertyChanged("Timing"); }
            }

            private Element _timing;

            /// <summary>
            /// Additional Data or supporting information
            /// </summary>
            [FhirElement("value", Order=80, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(FhirBoolean),typeof(FhirString),typeof(Quantity),typeof(Attachment),typeof(ResourceReference))]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            /// <summary>
            /// Reason associated with the information
            /// </summary>
            [FhirElement("reason", Order=90)]
            [DataMember]
            public Coding Reason
            {
                get { return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private Coding _reason;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SupportingInformationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    if (Reason != null) dest.Reason = (Coding)Reason.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SupportingInformationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SupportingInformationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;
                if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SupportingInformationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (Category != null) yield return Category;
                    if (Code != null) yield return Code;
                    if (Timing != null) yield return Timing;
                    if (Value != null) yield return Value;
                    if (Reason != null) yield return Reason;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", false, SequenceElement);
                    if (Category != null) yield return new ElementValue("category", false, Category);
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (Timing != null) yield return new ElementValue("timing", false, Timing);
                    if (Value != null) yield return new ElementValue("value", false, Value);
                    if (Reason != null) yield return new ElementValue("reason", false, Reason);
                }
            }


        }


        [FhirType("CareTeamComponent")]
        [DataContract]
        public partial class CareTeamComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CareTeamComponent"; } }

            /// <summary>
            /// Number to convey order of careteam
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Number to convey order of careteam
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Member of the Care Team
            /// </summary>
            [FhirElement("provider", Order=50)]
            [References("Practitioner","PractitionerRole","Organization")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Provider
            {
                get { return _provider; }
                set { _provider = value; OnPropertyChanged("Provider"); }
            }

            private ResourceReference _provider;

            /// <summary>
            /// Billing practitioner
            /// </summary>
            [FhirElement("responsible", Order=60)]
            [DataMember]
            public FhirBoolean ResponsibleElement
            {
                get { return _responsibleElement; }
                set { _responsibleElement = value; OnPropertyChanged("ResponsibleElement"); }
            }

            private FhirBoolean _responsibleElement;

            /// <summary>
            /// Billing practitioner
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Responsible
            {
                get { return ResponsibleElement != null ? ResponsibleElement.Value : null; }
                set
                {
                    if (value == null)
                        ResponsibleElement = null;
                    else
                        ResponsibleElement = new FhirBoolean(value);
                    OnPropertyChanged("Responsible");
                }
            }

            /// <summary>
            /// Role on the team
            /// </summary>
            [FhirElement("role", Order=70)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            /// <summary>
            /// Type, classification or Specialization
            /// </summary>
            [FhirElement("qualification", Order=80)]
            [DataMember]
            public CodeableConcept Qualification
            {
                get { return _qualification; }
                set { _qualification = value; OnPropertyChanged("Qualification"); }
            }

            private CodeableConcept _qualification;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CareTeamComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                    if (ResponsibleElement != null) dest.ResponsibleElement = (FhirBoolean)ResponsibleElement.DeepCopy();
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    if (Qualification != null) dest.Qualification = (CodeableConcept)Qualification.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CareTeamComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CareTeamComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
                if (!DeepComparable.Matches(ResponsibleElement, otherT.ResponsibleElement)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Qualification, otherT.Qualification)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CareTeamComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
                if (!DeepComparable.IsExactly(ResponsibleElement, otherT.ResponsibleElement)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Qualification, otherT.Qualification)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (Provider != null) yield return Provider;
                    if (ResponsibleElement != null) yield return ResponsibleElement;
                    if (Role != null) yield return Role;
                    if (Qualification != null) yield return Qualification;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", false, SequenceElement);
                    if (Provider != null) yield return new ElementValue("provider", false, Provider);
                    if (ResponsibleElement != null) yield return new ElementValue("responsible", false, ResponsibleElement);
                    if (Role != null) yield return new ElementValue("role", false, Role);
                    if (Qualification != null) yield return new ElementValue("qualification", false, Qualification);
                }
            }


        }


        [FhirType("DiagnosisComponent")]
        [DataContract]
        public partial class DiagnosisComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DiagnosisComponent"; } }

            /// <summary>
            /// Number to convey order of diagnosis
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Number to convey order of diagnosis
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Patient's diagnosis
            /// </summary>
            [FhirElement("diagnosis", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Diagnosis
            {
                get { return _diagnosis; }
                set { _diagnosis = value; OnPropertyChanged("Diagnosis"); }
            }

            private Element _diagnosis;

            /// <summary>
            /// Timing or nature of the diagnosis
            /// </summary>
            [FhirElement("type", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Type
            {
                get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private List<CodeableConcept> _type;

            /// <summary>
            /// Package billing code
            /// </summary>
            [FhirElement("packageCode", Order=70)]
            [DataMember]
            public CodeableConcept PackageCode
            {
                get { return _packageCode; }
                set { _packageCode = value; OnPropertyChanged("PackageCode"); }
            }

            private CodeableConcept _packageCode;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DiagnosisComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Diagnosis != null) dest.Diagnosis = (Element)Diagnosis.DeepCopy();
                    if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                    if (PackageCode != null) dest.PackageCode = (CodeableConcept)PackageCode.DeepCopy();
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
                if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(PackageCode, otherT.PackageCode)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DiagnosisComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(PackageCode, otherT.PackageCode)) return false;

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
                    foreach (var elem in Type) { if (elem != null) yield return elem; }
                    if (PackageCode != null) yield return PackageCode;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", false, SequenceElement);
                    if (Diagnosis != null) yield return new ElementValue("diagnosis", false, Diagnosis);
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", true, elem); }
                    if (PackageCode != null) yield return new ElementValue("packageCode", false, PackageCode);
                }
            }


        }


        [FhirType("ProcedureComponent")]
        [DataContract]
        public partial class ProcedureComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ProcedureComponent"; } }

            /// <summary>
            /// Procedure sequence for reference
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public PositiveInt SequenceElement
            {
                get { return _sequenceElement; }
                set { _sequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }

            private PositiveInt _sequenceElement;

            /// <summary>
            /// Procedure sequence for reference
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// When the procedure was performed
            /// </summary>
            [FhirElement("date", Order=50)]
            [DataMember]
            public FhirDateTime DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private FhirDateTime _dateElement;

            /// <summary>
            /// When the procedure was performed
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
            /// Patient's list of procedures performed
            /// </summary>
            [FhirElement("procedure", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Procedure
            {
                get { return _procedure; }
                set { _procedure = value; OnPropertyChanged("Procedure"); }
            }

            private Element _procedure;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProcedureComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                    if (Procedure != null) dest.Procedure = (Element)Procedure.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ProcedureComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProcedureComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(Procedure, otherT.Procedure)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProcedureComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(Procedure, otherT.Procedure)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (DateElement != null) yield return DateElement;
                    if (Procedure != null) yield return Procedure;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", false, SequenceElement);
                    if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                    if (Procedure != null) yield return new ElementValue("procedure", false, Procedure);
                }
            }


        }


        [FhirType("InsuranceComponent")]
        [DataContract]
        public partial class InsuranceComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InsuranceComponent"; } }

            /// <summary>
            /// Insurance information
            /// </summary>
            [FhirElement("coverage", Order=40)]
            [References("Coverage")]
            [DataMember]
            public ResourceReference Coverage
            {
                get { return _coverage; }
                set { _coverage = value; OnPropertyChanged("Coverage"); }
            }

            private ResourceReference _coverage;

            /// <summary>
            /// Pre-Authorization/Determination Reference
            /// </summary>
            [FhirElement("preAuthRef", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> PreAuthRefElement
            {
                get { if (_preAuthRefElement==null) _preAuthRefElement = new List<FhirString>(); return _preAuthRefElement; }
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
                        PreAuthRefElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("PreAuthRef");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InsuranceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Coverage != null) dest.Coverage = (ResourceReference)Coverage.DeepCopy();
                    if (PreAuthRefElement != null) dest.PreAuthRefElement = new List<FhirString>(PreAuthRefElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InsuranceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InsuranceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
                if ( !DeepComparable.Matches(PreAuthRefElement, otherT.PreAuthRefElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InsuranceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.IsExactly(PreAuthRefElement, otherT.PreAuthRefElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Coverage != null) yield return Coverage;
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Coverage != null) yield return new ElementValue("coverage", false, Coverage);
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return new ElementValue("preAuthRef", true, elem); }
                }
            }


        }


        [FhirType("AccidentComponent")]
        [DataContract]
        public partial class AccidentComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AccidentComponent"; } }

            /// <summary>
            /// When the accident occurred
            /// </summary>
            [FhirElement("date", Order=40)]
            [DataMember]
            public Date DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private Date _dateElement;

            /// <summary>
            /// When the accident occurred
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
            /// The nature of the accident
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Accident Place
            /// </summary>
            [FhirElement("location", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Address),typeof(ResourceReference))]
            [DataMember]
            public Element Location
            {
                get { return _location; }
                set { _location = value; OnPropertyChanged("Location"); }
            }

            private Element _location;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AccidentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DateElement != null) dest.DateElement = (Date)DateElement.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Location != null) dest.Location = (Element)Location.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AccidentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AccidentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Location, otherT.Location)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AccidentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DateElement != null) yield return DateElement;
                    if (Type != null) yield return Type;
                    if (Location != null) yield return Location;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Location != null) yield return new ElementValue("location", false, Location);
                }
            }


        }


        [FhirType("ItemComponent")]
        [DataContract]
        public partial class ItemComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ItemComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
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
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Applicable careteam members
            /// </summary>
            [FhirElement("careTeamSequence", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> CareTeamSequenceElement
            {
                get { if (_careTeamSequenceElement==null) _careTeamSequenceElement = new List<PositiveInt>(); return _careTeamSequenceElement; }
                set { _careTeamSequenceElement = value; OnPropertyChanged("CareTeamSequenceElement"); }
            }

            private List<PositiveInt> _careTeamSequenceElement;

            /// <summary>
            /// Applicable careteam members
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> CareTeamSequence
            {
                get { return CareTeamSequenceElement != null ? CareTeamSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        CareTeamSequenceElement = null;
                    else
                        CareTeamSequenceElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("CareTeamSequence");
                }
            }

            /// <summary>
            /// Applicable diagnoses
            /// </summary>
            [FhirElement("diagnosisSequence", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> DiagnosisSequenceElement
            {
                get { if (_diagnosisSequenceElement==null) _diagnosisSequenceElement = new List<PositiveInt>(); return _diagnosisSequenceElement; }
                set { _diagnosisSequenceElement = value; OnPropertyChanged("DiagnosisSequenceElement"); }
            }

            private List<PositiveInt> _diagnosisSequenceElement;

            /// <summary>
            /// Applicable diagnoses
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> DiagnosisSequence
            {
                get { return DiagnosisSequenceElement != null ? DiagnosisSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        DiagnosisSequenceElement = null;
                    else
                        DiagnosisSequenceElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("DiagnosisSequence");
                }
            }

            /// <summary>
            /// Applicable procedures
            /// </summary>
            [FhirElement("procedureSequence", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> ProcedureSequenceElement
            {
                get { if (_procedureSequenceElement==null) _procedureSequenceElement = new List<PositiveInt>(); return _procedureSequenceElement; }
                set { _procedureSequenceElement = value; OnPropertyChanged("ProcedureSequenceElement"); }
            }

            private List<PositiveInt> _procedureSequenceElement;

            /// <summary>
            /// Applicable procedures
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> ProcedureSequence
            {
                get { return ProcedureSequenceElement != null ? ProcedureSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ProcedureSequenceElement = null;
                    else
                        ProcedureSequenceElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("ProcedureSequence");
                }
            }

            /// <summary>
            /// Applicable exception and supporting information
            /// </summary>
            [FhirElement("informationSequence", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> InformationSequenceElement
            {
                get { if (_informationSequenceElement==null) _informationSequenceElement = new List<PositiveInt>(); return _informationSequenceElement; }
                set { _informationSequenceElement = value; OnPropertyChanged("InformationSequenceElement"); }
            }

            private List<PositiveInt> _informationSequenceElement;

            /// <summary>
            /// Applicable exception and supporting information
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> InformationSequence
            {
                get { return InformationSequenceElement != null ? InformationSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        InformationSequenceElement = null;
                    else
                        InformationSequenceElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("InformationSequence");
                }
            }

            /// <summary>
            /// Revenue or cost center code
            /// </summary>
            [FhirElement("revenue", Order=90)]
            [DataMember]
            public CodeableConcept Revenue
            {
                get { return _revenue; }
                set { _revenue = value; OnPropertyChanged("Revenue"); }
            }

            private CodeableConcept _revenue;

            /// <summary>
            /// Type of service or product
            /// </summary>
            [FhirElement("category", Order=100)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Billing Code
            /// </summary>
            [FhirElement("service", Order=110)]
            [DataMember]
            public CodeableConcept Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private CodeableConcept _service;

            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Modifier
            {
                get { if (_modifier==null) _modifier = new List<CodeableConcept>(); return _modifier; }
                set { _modifier = value; OnPropertyChanged("Modifier"); }
            }

            private List<CodeableConcept> _modifier;

            /// <summary>
            /// Program specific reason for item inclusion
            /// </summary>
            [FhirElement("programCode", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ProgramCode
            {
                get { if (_programCode==null) _programCode = new List<CodeableConcept>(); return _programCode; }
                set { _programCode = value; OnPropertyChanged("ProgramCode"); }
            }

            private List<CodeableConcept> _programCode;

            /// <summary>
            /// Date or dates of Service
            /// </summary>
            [FhirElement("serviced", Order=140, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Date),typeof(Period))]
            [DataMember]
            public Element Serviced
            {
                get { return _serviced; }
                set { _serviced = value; OnPropertyChanged("Serviced"); }
            }

            private Element _serviced;

            /// <summary>
            /// Place of service
            /// </summary>
            [FhirElement("location", Order=150, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(Address),typeof(ResourceReference))]
            [DataMember]
            public Element Location
            {
                get { return _location; }
                set { _location = value; OnPropertyChanged("Location"); }
            }

            private Element _location;

            /// <summary>
            /// Count of Products or Services
            /// </summary>
            [FhirElement("quantity", Order=160)]
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
            [FhirElement("unitPrice", Order=170)]
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
            [FhirElement("factor", Order=180)]
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
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Total item cost
            /// </summary>
            [FhirElement("net", Order=190)]
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
            [FhirElement("udi", Order=200)]
            [References("Device")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Udi
            {
                get { if (_udi==null) _udi = new List<ResourceReference>(); return _udi; }
                set { _udi = value; OnPropertyChanged("Udi"); }
            }

            private List<ResourceReference> _udi;

            /// <summary>
            /// Service Location
            /// </summary>
            [FhirElement("bodySite", Order=210)]
            [DataMember]
            public CodeableConcept BodySite
            {
                get { return _bodySite; }
                set { _bodySite = value; OnPropertyChanged("BodySite"); }
            }

            private CodeableConcept _bodySite;

            /// <summary>
            /// Service Sub-location
            /// </summary>
            [FhirElement("subSite", Order=220)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> SubSite
            {
                get { if (_subSite==null) _subSite = new List<CodeableConcept>(); return _subSite; }
                set { _subSite = value; OnPropertyChanged("SubSite"); }
            }

            private List<CodeableConcept> _subSite;

            /// <summary>
            /// Encounters related to this billed item
            /// </summary>
            [FhirElement("encounter", Order=230)]
            [References("Encounter")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Encounter
            {
                get { if (_encounter==null) _encounter = new List<ResourceReference>(); return _encounter; }
                set { _encounter = value; OnPropertyChanged("Encounter"); }
            }

            private List<ResourceReference> _encounter;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=240)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement==null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
                set { _noteNumberElement = value; OnPropertyChanged("NoteNumberElement"); }
            }

            private List<PositiveInt> _noteNumberElement;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> NoteNumber
            {
                get { return NoteNumberElement != null ? NoteNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberElement = null;
                    else
                        NoteNumberElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("NoteNumber");
                }
            }

            /// <summary>
            /// Adjudication details
            /// </summary>
            [FhirElement("adjudication", Order=250)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AdjudicationComponent> Adjudication
            {
                get { if (_adjudication==null) _adjudication = new List<AdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AdjudicationComponent> _adjudication;

            /// <summary>
            /// Additional items
            /// </summary>
            [FhirElement("detail", Order=260)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DetailComponent> Detail
            {
                get { if (_detail==null) _detail = new List<DetailComponent>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<DetailComponent> _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (CareTeamSequenceElement != null) dest.CareTeamSequenceElement = new List<PositiveInt>(CareTeamSequenceElement.DeepCopy());
                    if (DiagnosisSequenceElement != null) dest.DiagnosisSequenceElement = new List<PositiveInt>(DiagnosisSequenceElement.DeepCopy());
                    if (ProcedureSequenceElement != null) dest.ProcedureSequenceElement = new List<PositiveInt>(ProcedureSequenceElement.DeepCopy());
                    if (InformationSequenceElement != null) dest.InformationSequenceElement = new List<PositiveInt>(InformationSequenceElement.DeepCopy());
                    if (Revenue != null) dest.Revenue = (CodeableConcept)Revenue.DeepCopy();
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Service != null) dest.Service = (CodeableConcept)Service.DeepCopy();
                    if (Modifier != null) dest.Modifier = new List<CodeableConcept>(Modifier.DeepCopy());
                    if (ProgramCode != null) dest.ProgramCode = new List<CodeableConcept>(ProgramCode.DeepCopy());
                    if (Serviced != null) dest.Serviced = (Element)Serviced.DeepCopy();
                    if (Location != null) dest.Location = (Element)Location.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
                    if (Udi != null) dest.Udi = new List<ResourceReference>(Udi.DeepCopy());
                    if (BodySite != null) dest.BodySite = (CodeableConcept)BodySite.DeepCopy();
                    if (SubSite != null) dest.SubSite = new List<CodeableConcept>(SubSite.DeepCopy());
                    if (Encounter != null) dest.Encounter = new List<ResourceReference>(Encounter.DeepCopy());
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
                    if (Detail != null) dest.Detail = new List<DetailComponent>(Detail.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if ( !DeepComparable.Matches(CareTeamSequenceElement, otherT.CareTeamSequenceElement)) return false;
                if ( !DeepComparable.Matches(DiagnosisSequenceElement, otherT.DiagnosisSequenceElement)) return false;
                if ( !DeepComparable.Matches(ProcedureSequenceElement, otherT.ProcedureSequenceElement)) return false;
                if ( !DeepComparable.Matches(InformationSequenceElement, otherT.InformationSequenceElement)) return false;
                if (!DeepComparable.Matches(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if ( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if ( !DeepComparable.Matches(ProgramCode, otherT.ProgramCode)) return false;
                if (!DeepComparable.Matches(Serviced, otherT.Serviced)) return false;
                if (!DeepComparable.Matches(Location, otherT.Location)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;
                if ( !DeepComparable.Matches(Udi, otherT.Udi)) return false;
                if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
                if ( !DeepComparable.Matches(SubSite, otherT.SubSite)) return false;
                if ( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
                if ( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if ( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(CareTeamSequenceElement, otherT.CareTeamSequenceElement)) return false;
                if (!DeepComparable.IsExactly(DiagnosisSequenceElement, otherT.DiagnosisSequenceElement)) return false;
                if (!DeepComparable.IsExactly(ProcedureSequenceElement, otherT.ProcedureSequenceElement)) return false;
                if (!DeepComparable.IsExactly(InformationSequenceElement, otherT.InformationSequenceElement)) return false;
                if (!DeepComparable.IsExactly(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.IsExactly(ProgramCode, otherT.ProgramCode)) return false;
                if (!DeepComparable.IsExactly(Serviced, otherT.Serviced)) return false;
                if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if (!DeepComparable.IsExactly(Udi, otherT.Udi)) return false;
                if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
                if (!DeepComparable.IsExactly(SubSite, otherT.SubSite)) return false;
                if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
                if (!DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    foreach (var elem in CareTeamSequenceElement) { if (elem != null) yield return elem; }
                    foreach (var elem in DiagnosisSequenceElement) { if (elem != null) yield return elem; }
                    foreach (var elem in ProcedureSequenceElement) { if (elem != null) yield return elem; }
                    foreach (var elem in InformationSequenceElement) { if (elem != null) yield return elem; }
                    if (Revenue != null) yield return Revenue;
                    if (Category != null) yield return Category;
                    if (Service != null) yield return Service;
                    foreach (var elem in Modifier) { if (elem != null) yield return elem; }
                    foreach (var elem in ProgramCode) { if (elem != null) yield return elem; }
                    if (Serviced != null) yield return Serviced;
                    if (Location != null) yield return Location;
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (Net != null) yield return Net;
                    foreach (var elem in Udi) { if (elem != null) yield return elem; }
                    if (BodySite != null) yield return BodySite;
                    foreach (var elem in SubSite) { if (elem != null) yield return elem; }
                    foreach (var elem in Encounter) { if (elem != null) yield return elem; }
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", false, SequenceElement);
                    foreach (var elem in CareTeamSequenceElement) { if (elem != null) yield return new ElementValue("careTeamSequence", true, elem); }
                    foreach (var elem in DiagnosisSequenceElement) { if (elem != null) yield return new ElementValue("diagnosisSequence", true, elem); }
                    foreach (var elem in ProcedureSequenceElement) { if (elem != null) yield return new ElementValue("procedureSequence", true, elem); }
                    foreach (var elem in InformationSequenceElement) { if (elem != null) yield return new ElementValue("informationSequence", true, elem); }
                    if (Revenue != null) yield return new ElementValue("revenue", false, Revenue);
                    if (Category != null) yield return new ElementValue("category", false, Category);
                    if (Service != null) yield return new ElementValue("service", false, Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", true, elem); }
                    foreach (var elem in ProgramCode) { if (elem != null) yield return new ElementValue("programCode", true, elem); }
                    if (Serviced != null) yield return new ElementValue("serviced", false, Serviced);
                    if (Location != null) yield return new ElementValue("location", false, Location);
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", false, UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", false, FactorElement);
                    if (Net != null) yield return new ElementValue("net", false, Net);
                    foreach (var elem in Udi) { if (elem != null) yield return new ElementValue("udi", true, elem); }
                    if (BodySite != null) yield return new ElementValue("bodySite", false, BodySite);
                    foreach (var elem in SubSite) { if (elem != null) yield return new ElementValue("subSite", true, elem); }
                    foreach (var elem in Encounter) { if (elem != null) yield return new ElementValue("encounter", true, elem); }
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return new ElementValue("noteNumber", true, elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", true, elem); }
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", true, elem); }
                }
            }


        }


        [FhirType("AdjudicationComponent")]
        [DataContract]
        public partial class AdjudicationComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AdjudicationComponent"; } }

            /// <summary>
            /// Adjudication category such as co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("category", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Explanation of Adjudication outcome
            /// </summary>
            [FhirElement("reason", Order=50)]
            [DataMember]
            public CodeableConcept Reason
            {
                get { return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private CodeableConcept _reason;

            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", Order=60)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            /// <summary>
            /// Non-monitory value
            /// </summary>
            [FhirElement("value", Order=70)]
            [DataMember]
            public FhirDecimal ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirDecimal _valueElement;

            /// <summary>
            /// Non-monitory value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirDecimal(value);
                    OnPropertyChanged("Value");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AdjudicationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirDecimal)ValueElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AdjudicationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AdjudicationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AdjudicationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    if (Reason != null) yield return Reason;
                    if (Amount != null) yield return Amount;
                    if (ValueElement != null) yield return ValueElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", false, Category);
                    if (Reason != null) yield return new ElementValue("reason", false, Reason);
                    if (Amount != null) yield return new ElementValue("amount", false, Amount);
                    if (ValueElement != null) yield return new ElementValue("value", false, ValueElement);
                }
            }


        }


        [FhirType("DetailComponent")]
        [DataContract]
        public partial class DetailComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DetailComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
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
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Revenue or cost center code
            /// </summary>
            [FhirElement("revenue", Order=50)]
            [DataMember]
            public CodeableConcept Revenue
            {
                get { return _revenue; }
                set { _revenue = value; OnPropertyChanged("Revenue"); }
            }

            private CodeableConcept _revenue;

            /// <summary>
            /// Type of service or product
            /// </summary>
            [FhirElement("category", Order=60)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Billing Code
            /// </summary>
            [FhirElement("service", Order=70)]
            [DataMember]
            public CodeableConcept Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private CodeableConcept _service;

            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Modifier
            {
                get { if (_modifier==null) _modifier = new List<CodeableConcept>(); return _modifier; }
                set { _modifier = value; OnPropertyChanged("Modifier"); }
            }

            private List<CodeableConcept> _modifier;

            /// <summary>
            /// Program specific reason for item inclusion
            /// </summary>
            [FhirElement("programCode", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ProgramCode
            {
                get { if (_programCode==null) _programCode = new List<CodeableConcept>(); return _programCode; }
                set { _programCode = value; OnPropertyChanged("ProgramCode"); }
            }

            private List<CodeableConcept> _programCode;

            /// <summary>
            /// Count of Products or Services
            /// </summary>
            [FhirElement("quantity", Order=100)]
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
            [FhirElement("unitPrice", Order=110)]
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
            [FhirElement("factor", Order=120)]
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
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Total additional item cost
            /// </summary>
            [FhirElement("net", Order=130)]
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
            [FhirElement("udi", Order=140)]
            [References("Device")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Udi
            {
                get { if (_udi==null) _udi = new List<ResourceReference>(); return _udi; }
                set { _udi = value; OnPropertyChanged("Udi"); }
            }

            private List<ResourceReference> _udi;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement==null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
                set { _noteNumberElement = value; OnPropertyChanged("NoteNumberElement"); }
            }

            private List<PositiveInt> _noteNumberElement;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> NoteNumber
            {
                get { return NoteNumberElement != null ? NoteNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberElement = null;
                    else
                        NoteNumberElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("NoteNumber");
                }
            }

            /// <summary>
            /// Detail level adjudication details
            /// </summary>
            [FhirElement("adjudication", Order=160)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AdjudicationComponent> Adjudication
            {
                get { if (_adjudication==null) _adjudication = new List<AdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AdjudicationComponent> _adjudication;

            /// <summary>
            /// Additional items
            /// </summary>
            [FhirElement("subDetail", Order=170)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SubDetailComponent> SubDetail
            {
                get { if (_subDetail==null) _subDetail = new List<SubDetailComponent>(); return _subDetail; }
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
                    if (Revenue != null) dest.Revenue = (CodeableConcept)Revenue.DeepCopy();
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Service != null) dest.Service = (CodeableConcept)Service.DeepCopy();
                    if (Modifier != null) dest.Modifier = new List<CodeableConcept>(Modifier.DeepCopy());
                    if (ProgramCode != null) dest.ProgramCode = new List<CodeableConcept>(ProgramCode.DeepCopy());
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
                    if (Udi != null) dest.Udi = new List<ResourceReference>(Udi.DeepCopy());
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
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
                if (!DeepComparable.Matches(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if ( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if ( !DeepComparable.Matches(ProgramCode, otherT.ProgramCode)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;
                if ( !DeepComparable.Matches(Udi, otherT.Udi)) return false;
                if ( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if ( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if ( !DeepComparable.Matches(SubDetail, otherT.SubDetail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.IsExactly(ProgramCode, otherT.ProgramCode)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if (!DeepComparable.IsExactly(Udi, otherT.Udi)) return false;
                if (!DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;
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
                    if (Revenue != null) yield return Revenue;
                    if (Category != null) yield return Category;
                    if (Service != null) yield return Service;
                    foreach (var elem in Modifier) { if (elem != null) yield return elem; }
                    foreach (var elem in ProgramCode) { if (elem != null) yield return elem; }
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (Net != null) yield return Net;
                    foreach (var elem in Udi) { if (elem != null) yield return elem; }
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                    foreach (var elem in SubDetail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", false, SequenceElement);
                    if (Revenue != null) yield return new ElementValue("revenue", false, Revenue);
                    if (Category != null) yield return new ElementValue("category", false, Category);
                    if (Service != null) yield return new ElementValue("service", false, Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", true, elem); }
                    foreach (var elem in ProgramCode) { if (elem != null) yield return new ElementValue("programCode", true, elem); }
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", false, UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", false, FactorElement);
                    if (Net != null) yield return new ElementValue("net", false, Net);
                    foreach (var elem in Udi) { if (elem != null) yield return new ElementValue("udi", true, elem); }
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return new ElementValue("noteNumber", true, elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", true, elem); }
                    foreach (var elem in SubDetail) { if (elem != null) yield return new ElementValue("subDetail", true, elem); }
                }
            }


        }


        [FhirType("SubDetailComponent")]
        [DataContract]
        public partial class SubDetailComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubDetailComponent"; } }

            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
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
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Revenue or cost center code
            /// </summary>
            [FhirElement("revenue", Order=50)]
            [DataMember]
            public CodeableConcept Revenue
            {
                get { return _revenue; }
                set { _revenue = value; OnPropertyChanged("Revenue"); }
            }

            private CodeableConcept _revenue;

            /// <summary>
            /// Type of service or product
            /// </summary>
            [FhirElement("category", Order=60)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Billing Code
            /// </summary>
            [FhirElement("service", Order=70)]
            [DataMember]
            public CodeableConcept Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private CodeableConcept _service;

            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Modifier
            {
                get { if (_modifier==null) _modifier = new List<CodeableConcept>(); return _modifier; }
                set { _modifier = value; OnPropertyChanged("Modifier"); }
            }

            private List<CodeableConcept> _modifier;

            /// <summary>
            /// Program specific reason for item inclusion
            /// </summary>
            [FhirElement("programCode", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ProgramCode
            {
                get { if (_programCode==null) _programCode = new List<CodeableConcept>(); return _programCode; }
                set { _programCode = value; OnPropertyChanged("ProgramCode"); }
            }

            private List<CodeableConcept> _programCode;

            /// <summary>
            /// Count of Products or Services
            /// </summary>
            [FhirElement("quantity", Order=100)]
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
            [FhirElement("unitPrice", Order=110)]
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
            [FhirElement("factor", Order=120)]
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
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }

            /// <summary>
            /// Net additional item cost
            /// </summary>
            [FhirElement("net", Order=130)]
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
            [FhirElement("udi", Order=140)]
            [References("Device")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Udi
            {
                get { if (_udi==null) _udi = new List<ResourceReference>(); return _udi; }
                set { _udi = value; OnPropertyChanged("Udi"); }
            }

            private List<ResourceReference> _udi;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement==null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
                set { _noteNumberElement = value; OnPropertyChanged("NoteNumberElement"); }
            }

            private List<PositiveInt> _noteNumberElement;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> NoteNumber
            {
                get { return NoteNumberElement != null ? NoteNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberElement = null;
                    else
                        NoteNumberElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("NoteNumber");
                }
            }

            /// <summary>
            /// Language if different from the resource
            /// </summary>
            [FhirElement("adjudication", Order=160)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AdjudicationComponent> Adjudication
            {
                get { if (_adjudication==null) _adjudication = new List<AdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AdjudicationComponent> _adjudication;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubDetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Revenue != null) dest.Revenue = (CodeableConcept)Revenue.DeepCopy();
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Service != null) dest.Service = (CodeableConcept)Service.DeepCopy();
                    if (Modifier != null) dest.Modifier = new List<CodeableConcept>(Modifier.DeepCopy());
                    if (ProgramCode != null) dest.ProgramCode = new List<CodeableConcept>(ProgramCode.DeepCopy());
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (UnitPrice != null) dest.UnitPrice = (Money)UnitPrice.DeepCopy();
                    if (FactorElement != null) dest.FactorElement = (FhirDecimal)FactorElement.DeepCopy();
                    if (Net != null) dest.Net = (Money)Net.DeepCopy();
                    if (Udi != null) dest.Udi = new List<ResourceReference>(Udi.DeepCopy());
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
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
                if (!DeepComparable.Matches(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if ( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if ( !DeepComparable.Matches(ProgramCode, otherT.ProgramCode)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.Matches(Net, otherT.Net)) return false;
                if ( !DeepComparable.Matches(Udi, otherT.Udi)) return false;
                if ( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if ( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubDetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(Revenue, otherT.Revenue)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.IsExactly(ProgramCode, otherT.ProgramCode)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if (!DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if (!DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if (!DeepComparable.IsExactly(Udi, otherT.Udi)) return false;
                if (!DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SequenceElement != null) yield return SequenceElement;
                    if (Revenue != null) yield return Revenue;
                    if (Category != null) yield return Category;
                    if (Service != null) yield return Service;
                    foreach (var elem in Modifier) { if (elem != null) yield return elem; }
                    foreach (var elem in ProgramCode) { if (elem != null) yield return elem; }
                    if (Quantity != null) yield return Quantity;
                    if (UnitPrice != null) yield return UnitPrice;
                    if (FactorElement != null) yield return FactorElement;
                    if (Net != null) yield return Net;
                    foreach (var elem in Udi) { if (elem != null) yield return elem; }
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", false, SequenceElement);
                    if (Revenue != null) yield return new ElementValue("revenue", false, Revenue);
                    if (Category != null) yield return new ElementValue("category", false, Category);
                    if (Service != null) yield return new ElementValue("service", false, Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", true, elem); }
                    foreach (var elem in ProgramCode) { if (elem != null) yield return new ElementValue("programCode", true, elem); }
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", false, UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", false, FactorElement);
                    if (Net != null) yield return new ElementValue("net", false, Net);
                    foreach (var elem in Udi) { if (elem != null) yield return new ElementValue("udi", true, elem); }
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return new ElementValue("noteNumber", true, elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", true, elem); }
                }
            }


        }


        [FhirType("AddedItemComponent")]
        [DataContract]
        public partial class AddedItemComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AddedItemComponent"; } }

            /// <summary>
            /// Service instances
            /// </summary>
            [FhirElement("itemSequence", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> ItemSequenceElement
            {
                get { if (_itemSequenceElement==null) _itemSequenceElement = new List<PositiveInt>(); return _itemSequenceElement; }
                set { _itemSequenceElement = value; OnPropertyChanged("ItemSequenceElement"); }
            }

            private List<PositiveInt> _itemSequenceElement;

            /// <summary>
            /// Service instances
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> ItemSequence
            {
                get { return ItemSequenceElement != null ? ItemSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ItemSequenceElement = null;
                    else
                        ItemSequenceElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("ItemSequence");
                }
            }

            /// <summary>
            /// Detail sequence number
            /// </summary>
            [FhirElement("detailSequence", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> DetailSequenceElement
            {
                get { if (_detailSequenceElement==null) _detailSequenceElement = new List<PositiveInt>(); return _detailSequenceElement; }
                set { _detailSequenceElement = value; OnPropertyChanged("DetailSequenceElement"); }
            }

            private List<PositiveInt> _detailSequenceElement;

            /// <summary>
            /// Detail sequence number
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> DetailSequence
            {
                get { return DetailSequenceElement != null ? DetailSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        DetailSequenceElement = null;
                    else
                        DetailSequenceElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("DetailSequence");
                }
            }

            /// <summary>
            /// Subdetail sequence number
            /// </summary>
            [FhirElement("subDetailSequence", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> SubDetailSequenceElement
            {
                get { if (_subDetailSequenceElement==null) _subDetailSequenceElement = new List<PositiveInt>(); return _subDetailSequenceElement; }
                set { _subDetailSequenceElement = value; OnPropertyChanged("SubDetailSequenceElement"); }
            }

            private List<PositiveInt> _subDetailSequenceElement;

            /// <summary>
            /// Subdetail sequence number
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> SubDetailSequence
            {
                get { return SubDetailSequenceElement != null ? SubDetailSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SubDetailSequenceElement = null;
                    else
                        SubDetailSequenceElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("SubDetailSequence");
                }
            }

            /// <summary>
            /// Billing Code
            /// </summary>
            [FhirElement("service", Order=70)]
            [DataMember]
            public CodeableConcept Service
            {
                get { return _service; }
                set { _service = value; OnPropertyChanged("Service"); }
            }

            private CodeableConcept _service;

            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Modifier
            {
                get { if (_modifier==null) _modifier = new List<CodeableConcept>(); return _modifier; }
                set { _modifier = value; OnPropertyChanged("Modifier"); }
            }

            private List<CodeableConcept> _modifier;

            /// <summary>
            /// Professional fee or Product charge
            /// </summary>
            [FhirElement("fee", Order=90)]
            [DataMember]
            public Money Fee
            {
                get { return _fee; }
                set { _fee = value; OnPropertyChanged("Fee"); }
            }

            private Money _fee;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> NoteNumberElement
            {
                get { if (_noteNumberElement==null) _noteNumberElement = new List<PositiveInt>(); return _noteNumberElement; }
                set { _noteNumberElement = value; OnPropertyChanged("NoteNumberElement"); }
            }

            private List<PositiveInt> _noteNumberElement;

            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> NoteNumber
            {
                get { return NoteNumberElement != null ? NoteNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberElement = null;
                    else
                        NoteNumberElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("NoteNumber");
                }
            }

            /// <summary>
            /// Added items adjudication
            /// </summary>
            [FhirElement("adjudication", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<AdjudicationComponent> Adjudication
            {
                get { if (_adjudication==null) _adjudication = new List<AdjudicationComponent>(); return _adjudication; }
                set { _adjudication = value; OnPropertyChanged("Adjudication"); }
            }

            private List<AdjudicationComponent> _adjudication;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AddedItemComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ItemSequenceElement != null) dest.ItemSequenceElement = new List<PositiveInt>(ItemSequenceElement.DeepCopy());
                    if (DetailSequenceElement != null) dest.DetailSequenceElement = new List<PositiveInt>(DetailSequenceElement.DeepCopy());
                    if (SubDetailSequenceElement != null) dest.SubDetailSequenceElement = new List<PositiveInt>(SubDetailSequenceElement.DeepCopy());
                    if (Service != null) dest.Service = (CodeableConcept)Service.DeepCopy();
                    if (Modifier != null) dest.Modifier = new List<CodeableConcept>(Modifier.DeepCopy());
                    if (Fee != null) dest.Fee = (Money)Fee.DeepCopy();
                    if (NoteNumberElement != null) dest.NoteNumberElement = new List<PositiveInt>(NoteNumberElement.DeepCopy());
                    if (Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AddedItemComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AddedItemComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(ItemSequenceElement, otherT.ItemSequenceElement)) return false;
                if ( !DeepComparable.Matches(DetailSequenceElement, otherT.DetailSequenceElement)) return false;
                if ( !DeepComparable.Matches(SubDetailSequenceElement, otherT.SubDetailSequenceElement)) return false;
                if (!DeepComparable.Matches(Service, otherT.Service)) return false;
                if ( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.Matches(Fee, otherT.Fee)) return false;
                if ( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if ( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AddedItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ItemSequenceElement, otherT.ItemSequenceElement)) return false;
                if (!DeepComparable.IsExactly(DetailSequenceElement, otherT.DetailSequenceElement)) return false;
                if (!DeepComparable.IsExactly(SubDetailSequenceElement, otherT.SubDetailSequenceElement)) return false;
                if (!DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if (!DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if (!DeepComparable.IsExactly(Fee, otherT.Fee)) return false;
                if (!DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if (!DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in ItemSequenceElement) { if (elem != null) yield return elem; }
                    foreach (var elem in DetailSequenceElement) { if (elem != null) yield return elem; }
                    foreach (var elem in SubDetailSequenceElement) { if (elem != null) yield return elem; }
                    if (Service != null) yield return Service;
                    foreach (var elem in Modifier) { if (elem != null) yield return elem; }
                    if (Fee != null) yield return Fee;
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return elem; }
                    foreach (var elem in Adjudication) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in ItemSequenceElement) { if (elem != null) yield return new ElementValue("itemSequence", true, elem); }
                    foreach (var elem in DetailSequenceElement) { if (elem != null) yield return new ElementValue("detailSequence", true, elem); }
                    foreach (var elem in SubDetailSequenceElement) { if (elem != null) yield return new ElementValue("subDetailSequence", true, elem); }
                    if (Service != null) yield return new ElementValue("service", false, Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", true, elem); }
                    if (Fee != null) yield return new ElementValue("fee", false, Fee);
                    foreach (var elem in NoteNumberElement) { if (elem != null) yield return new ElementValue("noteNumber", true, elem); }
                    foreach (var elem in Adjudication) { if (elem != null) yield return new ElementValue("adjudication", true, elem); }
                }
            }


        }


        [FhirType("TotalComponent")]
        [DataContract]
        public partial class TotalComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TotalComponent"; } }

            /// <summary>
            /// Adjudication category such as submitted, co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("category", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TotalComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TotalComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TotalComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TotalComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    if (Amount != null) yield return Amount;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", false, Category);
                    if (Amount != null) yield return new ElementValue("amount", false, Amount);
                }
            }


        }


        [FhirType("PaymentComponent")]
        [DataContract]
        public partial class PaymentComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PaymentComponent"; } }

            /// <summary>
            /// Partial or Complete
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
            /// Payment adjustment for non-Claim issues
            /// </summary>
            [FhirElement("adjustment", Order=50)]
            [DataMember]
            public Money Adjustment
            {
                get { return _adjustment; }
                set { _adjustment = value; OnPropertyChanged("Adjustment"); }
            }

            private Money _adjustment;

            /// <summary>
            /// Explanation for the non-claim adjustment
            /// </summary>
            [FhirElement("adjustmentReason", Order=60)]
            [DataMember]
            public CodeableConcept AdjustmentReason
            {
                get { return _adjustmentReason; }
                set { _adjustmentReason = value; OnPropertyChanged("AdjustmentReason"); }
            }

            private CodeableConcept _adjustmentReason;

            /// <summary>
            /// Expected date of Payment
            /// </summary>
            [FhirElement("date", Order=70)]
            [DataMember]
            public Date DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private Date _dateElement;

            /// <summary>
            /// Expected date of Payment
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
            /// Payable amount after adjustment
            /// </summary>
            [FhirElement("amount", Order=80)]
            [DataMember]
            public Money Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Money _amount;

            /// <summary>
            /// Identifier of the payment instrument
            /// </summary>
            [FhirElement("identifier", Order=90)]
            [DataMember]
            public Identifier Identifier
            {
                get { return _identifier; }
                set { _identifier = value; OnPropertyChanged("Identifier"); }
            }

            private Identifier _identifier;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PaymentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Adjustment != null) dest.Adjustment = (Money)Adjustment.DeepCopy();
                    if (AdjustmentReason != null) dest.AdjustmentReason = (CodeableConcept)AdjustmentReason.DeepCopy();
                    if (DateElement != null) dest.DateElement = (Date)DateElement.DeepCopy();
                    if (Amount != null) dest.Amount = (Money)Amount.DeepCopy();
                    if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PaymentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PaymentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Adjustment, otherT.Adjustment)) return false;
                if (!DeepComparable.Matches(AdjustmentReason, otherT.AdjustmentReason)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PaymentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Adjustment, otherT.Adjustment)) return false;
                if (!DeepComparable.IsExactly(AdjustmentReason, otherT.AdjustmentReason)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Adjustment != null) yield return Adjustment;
                    if (AdjustmentReason != null) yield return AdjustmentReason;
                    if (DateElement != null) yield return DateElement;
                    if (Amount != null) yield return Amount;
                    if (Identifier != null) yield return Identifier;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Adjustment != null) yield return new ElementValue("adjustment", false, Adjustment);
                    if (AdjustmentReason != null) yield return new ElementValue("adjustmentReason", false, AdjustmentReason);
                    if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                    if (Amount != null) yield return new ElementValue("amount", false, Amount);
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                }
            }


        }


        [FhirType("NoteComponent")]
        [DataContract]
        public partial class NoteComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "NoteComponent"; } }

            /// <summary>
            /// Sequence number for this note
            /// </summary>
            [FhirElement("number", Order=40)]
            [DataMember]
            public PositiveInt NumberElement
            {
                get { return _numberElement; }
                set { _numberElement = value; OnPropertyChanged("NumberElement"); }
            }

            private PositiveInt _numberElement;

            /// <summary>
            /// Sequence number for this note
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Number
            {
                get { return NumberElement != null ? NumberElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberElement = null;
                    else
                        NumberElement = new PositiveInt(value);
                    OnPropertyChanged("Number");
                }
            }

            /// <summary>
            /// display | print | printoper
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public Code<NoteType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<NoteType> _typeElement;

            /// <summary>
            /// display | print | printoper
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public NoteType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<NoteType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// Note explanitory text
            /// </summary>
            [FhirElement("text", Order=60)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Note explanitory text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new FhirString(value);
                    OnPropertyChanged("Text");
                }
            }

            /// <summary>
            /// Language if different from the resource
            /// </summary>
            [FhirElement("language", Order=70)]
            [DataMember]
            public CodeableConcept Language
            {
                get { return _language; }
                set { _language = value; OnPropertyChanged("Language"); }
            }

            private CodeableConcept _language;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NoteComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NumberElement != null) dest.NumberElement = (PositiveInt)NumberElement.DeepCopy();
                    if (TypeElement != null) dest.TypeElement = (Code<NoteType>)TypeElement.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (Language != null) dest.Language = (CodeableConcept)Language.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new NoteComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as NoteComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(Language, otherT.Language)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NoteComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NumberElement, otherT.NumberElement)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(Language, otherT.Language)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NumberElement != null) yield return NumberElement;
                    if (TypeElement != null) yield return TypeElement;
                    if (TextElement != null) yield return TextElement;
                    if (Language != null) yield return Language;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NumberElement != null) yield return new ElementValue("number", false, NumberElement);
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (TextElement != null) yield return new ElementValue("text", false, TextElement);
                    if (Language != null) yield return new ElementValue("language", false, Language);
                }
            }


        }


        [FhirType("BenefitBalanceComponent")]
        [DataContract]
        public partial class BenefitBalanceComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "BenefitBalanceComponent"; } }

            /// <summary>
            /// Type of services covered
            /// </summary>
            [FhirElement("category", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Detailed services covered within the type
            /// </summary>
            [FhirElement("subCategory", Order=50)]
            [DataMember]
            public CodeableConcept SubCategory
            {
                get { return _subCategory; }
                set { _subCategory = value; OnPropertyChanged("SubCategory"); }
            }

            private CodeableConcept _subCategory;

            /// <summary>
            /// Excluded from the plan
            /// </summary>
            [FhirElement("excluded", Order=60)]
            [DataMember]
            public FhirBoolean ExcludedElement
            {
                get { return _excludedElement; }
                set { _excludedElement = value; OnPropertyChanged("ExcludedElement"); }
            }

            private FhirBoolean _excludedElement;

            /// <summary>
            /// Excluded from the plan
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Excluded
            {
                get { return ExcludedElement != null ? ExcludedElement.Value : null; }
                set
                {
                    if (value == null)
                        ExcludedElement = null;
                    else
                        ExcludedElement = new FhirBoolean(value);
                    OnPropertyChanged("Excluded");
                }
            }

            /// <summary>
            /// Short name for the benefit
            /// </summary>
            [FhirElement("name", Order=70)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Short name for the benefit
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
            /// Description of the benefit or services covered
            /// </summary>
            [FhirElement("description", Order=80)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Description of the benefit or services covered
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
            /// In or out of network
            /// </summary>
            [FhirElement("network", Order=90)]
            [DataMember]
            public CodeableConcept Network
            {
                get { return _network; }
                set { _network = value; OnPropertyChanged("Network"); }
            }

            private CodeableConcept _network;

            /// <summary>
            /// Individual or family
            /// </summary>
            [FhirElement("unit", Order=100)]
            [DataMember]
            public CodeableConcept Unit
            {
                get { return _unit; }
                set { _unit = value; OnPropertyChanged("Unit"); }
            }

            private CodeableConcept _unit;

            /// <summary>
            /// Annual or lifetime
            /// </summary>
            [FhirElement("term", Order=110)]
            [DataMember]
            public CodeableConcept Term
            {
                get { return _term; }
                set { _term = value; OnPropertyChanged("Term"); }
            }

            private CodeableConcept _term;

            /// <summary>
            /// Benefit Summary
            /// </summary>
            [FhirElement("financial", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<BenefitComponent> Financial
            {
                get { if (_financial==null) _financial = new List<BenefitComponent>(); return _financial; }
                set { _financial = value; OnPropertyChanged("Financial"); }
            }

            private List<BenefitComponent> _financial;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BenefitBalanceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (SubCategory != null) dest.SubCategory = (CodeableConcept)SubCategory.DeepCopy();
                    if (ExcludedElement != null) dest.ExcludedElement = (FhirBoolean)ExcludedElement.DeepCopy();
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Network != null) dest.Network = (CodeableConcept)Network.DeepCopy();
                    if (Unit != null) dest.Unit = (CodeableConcept)Unit.DeepCopy();
                    if (Term != null) dest.Term = (CodeableConcept)Term.DeepCopy();
                    if (Financial != null) dest.Financial = new List<BenefitComponent>(Financial.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BenefitBalanceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BenefitBalanceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(SubCategory, otherT.SubCategory)) return false;
                if (!DeepComparable.Matches(ExcludedElement, otherT.ExcludedElement)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Network, otherT.Network)) return false;
                if (!DeepComparable.Matches(Unit, otherT.Unit)) return false;
                if (!DeepComparable.Matches(Term, otherT.Term)) return false;
                if ( !DeepComparable.Matches(Financial, otherT.Financial)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BenefitBalanceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(SubCategory, otherT.SubCategory)) return false;
                if (!DeepComparable.IsExactly(ExcludedElement, otherT.ExcludedElement)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Network, otherT.Network)) return false;
                if (!DeepComparable.IsExactly(Unit, otherT.Unit)) return false;
                if (!DeepComparable.IsExactly(Term, otherT.Term)) return false;
                if (!DeepComparable.IsExactly(Financial, otherT.Financial)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    if (SubCategory != null) yield return SubCategory;
                    if (ExcludedElement != null) yield return ExcludedElement;
                    if (NameElement != null) yield return NameElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Network != null) yield return Network;
                    if (Unit != null) yield return Unit;
                    if (Term != null) yield return Term;
                    foreach (var elem in Financial) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", false, Category);
                    if (SubCategory != null) yield return new ElementValue("subCategory", false, SubCategory);
                    if (ExcludedElement != null) yield return new ElementValue("excluded", false, ExcludedElement);
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                    if (Network != null) yield return new ElementValue("network", false, Network);
                    if (Unit != null) yield return new ElementValue("unit", false, Unit);
                    if (Term != null) yield return new ElementValue("term", false, Term);
                    foreach (var elem in Financial) { if (elem != null) yield return new ElementValue("financial", true, elem); }
                }
            }


        }


        [FhirType("BenefitComponent")]
        [DataContract]
        public partial class BenefitComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "BenefitComponent"; } }

            /// <summary>
            /// Deductable, visits, benefit amount
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
            /// Benefits allowed
            /// </summary>
            [FhirElement("allowed", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(UnsignedInt),typeof(FhirString),typeof(Money))]
            [DataMember]
            public Element Allowed
            {
                get { return _allowed; }
                set { _allowed = value; OnPropertyChanged("Allowed"); }
            }

            private Element _allowed;

            /// <summary>
            /// Benefits used
            /// </summary>
            [FhirElement("used", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(UnsignedInt),typeof(Money))]
            [DataMember]
            public Element Used
            {
                get { return _used; }
                set { _used = value; OnPropertyChanged("Used"); }
            }

            private Element _used;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BenefitComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Allowed != null) dest.Allowed = (Element)Allowed.DeepCopy();
                    if (Used != null) dest.Used = (Element)Used.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new BenefitComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as BenefitComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Allowed, otherT.Allowed)) return false;
                if (!DeepComparable.Matches(Used, otherT.Used)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BenefitComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Allowed, otherT.Allowed)) return false;
                if (!DeepComparable.IsExactly(Used, otherT.Used)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Allowed != null) yield return Allowed;
                    if (Used != null) yield return Used;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Allowed != null) yield return new ElementValue("allowed", false, Allowed);
                    if (Used != null) yield return new ElementValue("used", false, Used);
                }
            }


        }


        /// <summary>
        /// Business Identifier
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
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<ExplanationOfBenefitStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ExplanationOfBenefitStatus> _statusElement;

        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ExplanationOfBenefitStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ExplanationOfBenefitStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Type or discipline
        /// </summary>
        [FhirElement("type", Order=110)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Finer grained claim type information
        /// </summary>
        [FhirElement("subType", Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> SubType
        {
            get { if (_subType==null) _subType = new List<CodeableConcept>(); return _subType; }
            set { _subType = value; OnPropertyChanged("SubType"); }
        }

        private List<CodeableConcept> _subType;

        /// <summary>
        /// complete | proposed | exploratory | other
        /// </summary>
        [FhirElement("use", Order=130)]
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
        public Use? Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if (value == null)
                    UseElement = null;
                else
                    UseElement = new Code<Use>(value);
                OnPropertyChanged("Use");
            }
        }

        /// <summary>
        /// The subject of the Products and Services
        /// </summary>
        [FhirElement("patient", Order=140)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Period for charge submission
        /// </summary>
        [FhirElement("billablePeriod", Order=150)]
        [DataMember]
        public Period BillablePeriod
        {
            get { return _billablePeriod; }
            set { _billablePeriod = value; OnPropertyChanged("BillablePeriod"); }
        }

        private Period _billablePeriod;

        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", Order=160)]
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
        /// Author
        /// </summary>
        [FhirElement("enterer", Order=170)]
        [References("Practitioner","PractitionerRole")]
        [DataMember]
        public ResourceReference Enterer
        {
            get { return _enterer; }
            set { _enterer = value; OnPropertyChanged("Enterer"); }
        }

        private ResourceReference _enterer;

        /// <summary>
        /// Insurer responsible for the EOB
        /// </summary>
        [FhirElement("insurer", Order=180)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Insurer
        {
            get { return _insurer; }
            set { _insurer = value; OnPropertyChanged("Insurer"); }
        }

        private ResourceReference _insurer;

        /// <summary>
        /// Responsible provider for the claim
        /// </summary>
        [FhirElement("provider", Order=190)]
        [References("Practitioner","PractitionerRole","Organization")]
        [DataMember]
        public ResourceReference Provider
        {
            get { return _provider; }
            set { _provider = value; OnPropertyChanged("Provider"); }
        }

        private ResourceReference _provider;

        /// <summary>
        /// Treatment Referral
        /// </summary>
        [FhirElement("referral", Order=200)]
        [References("ServiceRequest")]
        [DataMember]
        public ResourceReference Referral
        {
            get { return _referral; }
            set { _referral = value; OnPropertyChanged("Referral"); }
        }

        private ResourceReference _referral;

        /// <summary>
        /// Servicing Facility
        /// </summary>
        [FhirElement("facility", Order=210)]
        [References("Location")]
        [DataMember]
        public ResourceReference Facility
        {
            get { return _facility; }
            set { _facility = value; OnPropertyChanged("Facility"); }
        }

        private ResourceReference _facility;

        /// <summary>
        /// Claim reference
        /// </summary>
        [FhirElement("claim", Order=220)]
        [References("Claim")]
        [DataMember]
        public ResourceReference Claim
        {
            get { return _claim; }
            set { _claim = value; OnPropertyChanged("Claim"); }
        }

        private ResourceReference _claim;

        /// <summary>
        /// Claim response reference
        /// </summary>
        [FhirElement("claimResponse", Order=230)]
        [References("ClaimResponse")]
        [DataMember]
        public ResourceReference ClaimResponse
        {
            get { return _claimResponse; }
            set { _claimResponse = value; OnPropertyChanged("ClaimResponse"); }
        }

        private ResourceReference _claimResponse;

        /// <summary>
        /// queued | complete | error | partial
        /// </summary>
        [FhirElement("outcome", Order=240)]
        [DataMember]
        public Code<ClaimProcessingCodes> OutcomeElement
        {
            get { return _outcomeElement; }
            set { _outcomeElement = value; OnPropertyChanged("OutcomeElement"); }
        }

        private Code<ClaimProcessingCodes> _outcomeElement;

        /// <summary>
        /// queued | complete | error | partial
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ClaimProcessingCodes? Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if (value == null)
                    OutcomeElement = null;
                else
                    OutcomeElement = new Code<ClaimProcessingCodes>(value);
                OnPropertyChanged("Outcome");
            }
        }

        /// <summary>
        /// Disposition Message
        /// </summary>
        [FhirElement("disposition", Order=250)]
        [DataMember]
        public FhirString DispositionElement
        {
            get { return _dispositionElement; }
            set { _dispositionElement = value; OnPropertyChanged("DispositionElement"); }
        }

        private FhirString _dispositionElement;

        /// <summary>
        /// Disposition Message
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Disposition
        {
            get { return DispositionElement != null ? DispositionElement.Value : null; }
            set
            {
                if (value == null)
                    DispositionElement = null;
                else
                    DispositionElement = new FhirString(value);
                OnPropertyChanged("Disposition");
            }
        }

        /// <summary>
        /// Related Claims which may be revelant to processing this claim
        /// </summary>
        [FhirElement("related", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedClaimComponent> Related
        {
            get { if (_related==null) _related = new List<RelatedClaimComponent>(); return _related; }
            set { _related = value; OnPropertyChanged("Related"); }
        }

        private List<RelatedClaimComponent> _related;

        /// <summary>
        /// Prescription authorizing services or products
        /// </summary>
        [FhirElement("prescription", Order=270)]
        [References("MedicationRequest","VisionPrescription")]
        [DataMember]
        public ResourceReference Prescription
        {
            get { return _prescription; }
            set { _prescription = value; OnPropertyChanged("Prescription"); }
        }

        private ResourceReference _prescription;

        /// <summary>
        /// Original prescription if superceded by fulfiller
        /// </summary>
        [FhirElement("originalPrescription", Order=280)]
        [References("MedicationRequest")]
        [DataMember]
        public ResourceReference OriginalPrescription
        {
            get { return _originalPrescription; }
            set { _originalPrescription = value; OnPropertyChanged("OriginalPrescription"); }
        }

        private ResourceReference _originalPrescription;

        /// <summary>
        /// Party to be paid any benefits payable
        /// </summary>
        [FhirElement("payee", Order=290)]
        [DataMember]
        public PayeeComponent Payee
        {
            get { return _payee; }
            set { _payee = value; OnPropertyChanged("Payee"); }
        }

        private PayeeComponent _payee;

        /// <summary>
        /// Exceptions, special considerations, the condition, situation, prior or concurrent issues
        /// </summary>
        [FhirElement("information", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SupportingInformationComponent> Information
        {
            get { if (_information==null) _information = new List<SupportingInformationComponent>(); return _information; }
            set { _information = value; OnPropertyChanged("Information"); }
        }

        private List<SupportingInformationComponent> _information;

        /// <summary>
        /// Care Team members
        /// </summary>
        [FhirElement("careTeam", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CareTeamComponent> CareTeam
        {
            get { if (_careTeam==null) _careTeam = new List<CareTeamComponent>(); return _careTeam; }
            set { _careTeam = value; OnPropertyChanged("CareTeam"); }
        }

        private List<CareTeamComponent> _careTeam;

        /// <summary>
        /// List of Diagnosis
        /// </summary>
        [FhirElement("diagnosis", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DiagnosisComponent> Diagnosis
        {
            get { if (_diagnosis==null) _diagnosis = new List<DiagnosisComponent>(); return _diagnosis; }
            set { _diagnosis = value; OnPropertyChanged("Diagnosis"); }
        }

        private List<DiagnosisComponent> _diagnosis;

        /// <summary>
        /// Procedures performed
        /// </summary>
        [FhirElement("procedure", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ProcedureComponent> Procedure
        {
            get { if (_procedure==null) _procedure = new List<ProcedureComponent>(); return _procedure; }
            set { _procedure = value; OnPropertyChanged("Procedure"); }
        }

        private List<ProcedureComponent> _procedure;

        /// <summary>
        /// Precedence (primary, secondary, etc.)
        /// </summary>
        [FhirElement("precedence", Order=340)]
        [DataMember]
        public PositiveInt PrecedenceElement
        {
            get { return _precedenceElement; }
            set { _precedenceElement = value; OnPropertyChanged("PrecedenceElement"); }
        }

        private PositiveInt _precedenceElement;

        /// <summary>
        /// Precedence (primary, secondary, etc.)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Precedence
        {
            get { return PrecedenceElement != null ? PrecedenceElement.Value : null; }
            set
            {
                if (value == null)
                    PrecedenceElement = null;
                else
                    PrecedenceElement = new PositiveInt(value);
                OnPropertyChanged("Precedence");
            }
        }

        /// <summary>
        /// Insurance or medical plan
        /// </summary>
        [FhirElement("insurance", Order=350)]
        [DataMember]
        public InsuranceComponent Insurance
        {
            get { return _insurance; }
            set { _insurance = value; OnPropertyChanged("Insurance"); }
        }

        private InsuranceComponent _insurance;

        /// <summary>
        /// Details of an accident
        /// </summary>
        [FhirElement("accident", Order=360)]
        [DataMember]
        public AccidentComponent Accident
        {
            get { return _accident; }
            set { _accident = value; OnPropertyChanged("Accident"); }
        }

        private AccidentComponent _accident;

        /// <summary>
        /// Goods and Services
        /// </summary>
        [FhirElement("item", Order=370)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ItemComponent> Item
        {
            get { if (_item==null) _item = new List<ItemComponent>(); return _item; }
            set { _item = value; OnPropertyChanged("Item"); }
        }

        private List<ItemComponent> _item;

        /// <summary>
        /// Insurer added line items
        /// </summary>
        [FhirElement("addItem", Order=380)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AddedItemComponent> AddItem
        {
            get { if (_addItem==null) _addItem = new List<AddedItemComponent>(); return _addItem; }
            set { _addItem = value; OnPropertyChanged("AddItem"); }
        }

        private List<AddedItemComponent> _addItem;

        /// <summary>
        /// Adjudication totals
        /// </summary>
        [FhirElement("total", Order=390)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TotalComponent> Total
        {
            get { if (_total==null) _total = new List<TotalComponent>(); return _total; }
            set { _total = value; OnPropertyChanged("Total"); }
        }

        private List<TotalComponent> _total;

        /// <summary>
        /// Payment (if paid)
        /// </summary>
        [FhirElement("payment", Order=400)]
        [DataMember]
        public PaymentComponent Payment
        {
            get { return _payment; }
            set { _payment = value; OnPropertyChanged("Payment"); }
        }

        private PaymentComponent _payment;

        /// <summary>
        /// Printed Form Identifier
        /// </summary>
        [FhirElement("form", Order=410)]
        [DataMember]
        public CodeableConcept Form
        {
            get { return _form; }
            set { _form = value; OnPropertyChanged("Form"); }
        }

        private CodeableConcept _form;

        /// <summary>
        /// Processing notes
        /// </summary>
        [FhirElement("processNote", Order=420)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<NoteComponent> ProcessNote
        {
            get { if (_processNote==null) _processNote = new List<NoteComponent>(); return _processNote; }
            set { _processNote = value; OnPropertyChanged("ProcessNote"); }
        }

        private List<NoteComponent> _processNote;

        /// <summary>
        /// Balance by Benefit Category
        /// </summary>
        [FhirElement("benefitBalance", Order=430)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<BenefitBalanceComponent> BenefitBalance
        {
            get { if (_benefitBalance==null) _benefitBalance = new List<BenefitBalanceComponent>(); return _benefitBalance; }
            set { _benefitBalance = value; OnPropertyChanged("BenefitBalance"); }
        }

        private List<BenefitBalanceComponent> _benefitBalance;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ExplanationOfBenefit;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<ExplanationOfBenefitStatus>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (SubType != null) dest.SubType = new List<CodeableConcept>(SubType.DeepCopy());
                if (UseElement != null) dest.UseElement = (Code<Use>)UseElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (BillablePeriod != null) dest.BillablePeriod = (Period)BillablePeriod.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Enterer != null) dest.Enterer = (ResourceReference)Enterer.DeepCopy();
                if (Insurer != null) dest.Insurer = (ResourceReference)Insurer.DeepCopy();
                if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                if (Referral != null) dest.Referral = (ResourceReference)Referral.DeepCopy();
                if (Facility != null) dest.Facility = (ResourceReference)Facility.DeepCopy();
                if (Claim != null) dest.Claim = (ResourceReference)Claim.DeepCopy();
                if (ClaimResponse != null) dest.ClaimResponse = (ResourceReference)ClaimResponse.DeepCopy();
                if (OutcomeElement != null) dest.OutcomeElement = (Code<ClaimProcessingCodes>)OutcomeElement.DeepCopy();
                if (DispositionElement != null) dest.DispositionElement = (FhirString)DispositionElement.DeepCopy();
                if (Related != null) dest.Related = new List<RelatedClaimComponent>(Related.DeepCopy());
                if (Prescription != null) dest.Prescription = (ResourceReference)Prescription.DeepCopy();
                if (OriginalPrescription != null) dest.OriginalPrescription = (ResourceReference)OriginalPrescription.DeepCopy();
                if (Payee != null) dest.Payee = (PayeeComponent)Payee.DeepCopy();
                if (Information != null) dest.Information = new List<SupportingInformationComponent>(Information.DeepCopy());
                if (CareTeam != null) dest.CareTeam = new List<CareTeamComponent>(CareTeam.DeepCopy());
                if (Diagnosis != null) dest.Diagnosis = new List<DiagnosisComponent>(Diagnosis.DeepCopy());
                if (Procedure != null) dest.Procedure = new List<ProcedureComponent>(Procedure.DeepCopy());
                if (PrecedenceElement != null) dest.PrecedenceElement = (PositiveInt)PrecedenceElement.DeepCopy();
                if (Insurance != null) dest.Insurance = (InsuranceComponent)Insurance.DeepCopy();
                if (Accident != null) dest.Accident = (AccidentComponent)Accident.DeepCopy();
                if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                if (AddItem != null) dest.AddItem = new List<AddedItemComponent>(AddItem.DeepCopy());
                if (Total != null) dest.Total = new List<TotalComponent>(Total.DeepCopy());
                if (Payment != null) dest.Payment = (PaymentComponent)Payment.DeepCopy();
                if (Form != null) dest.Form = (CodeableConcept)Form.DeepCopy();
                if (ProcessNote != null) dest.ProcessNote = new List<NoteComponent>(ProcessNote.DeepCopy());
                if (BenefitBalance != null) dest.BenefitBalance = new List<BenefitBalanceComponent>(BenefitBalance.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ExplanationOfBenefit());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ExplanationOfBenefit;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(SubType, otherT.SubType)) return false;
            if (!DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(BillablePeriod, otherT.BillablePeriod)) return false;
            if (!DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.Matches(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.Matches(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.Matches(Provider, otherT.Provider)) return false;
            if (!DeepComparable.Matches(Referral, otherT.Referral)) return false;
            if (!DeepComparable.Matches(Facility, otherT.Facility)) return false;
            if (!DeepComparable.Matches(Claim, otherT.Claim)) return false;
            if (!DeepComparable.Matches(ClaimResponse, otherT.ClaimResponse)) return false;
            if (!DeepComparable.Matches(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if ( !DeepComparable.Matches(Related, otherT.Related)) return false;
            if (!DeepComparable.Matches(Prescription, otherT.Prescription)) return false;
            if (!DeepComparable.Matches(OriginalPrescription, otherT.OriginalPrescription)) return false;
            if (!DeepComparable.Matches(Payee, otherT.Payee)) return false;
            if ( !DeepComparable.Matches(Information, otherT.Information)) return false;
            if ( !DeepComparable.Matches(CareTeam, otherT.CareTeam)) return false;
            if ( !DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
            if ( !DeepComparable.Matches(Procedure, otherT.Procedure)) return false;
            if (!DeepComparable.Matches(PrecedenceElement, otherT.PrecedenceElement)) return false;
            if (!DeepComparable.Matches(Insurance, otherT.Insurance)) return false;
            if (!DeepComparable.Matches(Accident, otherT.Accident)) return false;
            if ( !DeepComparable.Matches(Item, otherT.Item)) return false;
            if ( !DeepComparable.Matches(AddItem, otherT.AddItem)) return false;
            if ( !DeepComparable.Matches(Total, otherT.Total)) return false;
            if (!DeepComparable.Matches(Payment, otherT.Payment)) return false;
            if (!DeepComparable.Matches(Form, otherT.Form)) return false;
            if ( !DeepComparable.Matches(ProcessNote, otherT.ProcessNote)) return false;
            if ( !DeepComparable.Matches(BenefitBalance, otherT.BenefitBalance)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ExplanationOfBenefit;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
            if (!DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(BillablePeriod, otherT.BillablePeriod)) return false;
            if (!DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if (!DeepComparable.IsExactly(Enterer, otherT.Enterer)) return false;
            if (!DeepComparable.IsExactly(Insurer, otherT.Insurer)) return false;
            if (!DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
            if (!DeepComparable.IsExactly(Referral, otherT.Referral)) return false;
            if (!DeepComparable.IsExactly(Facility, otherT.Facility)) return false;
            if (!DeepComparable.IsExactly(Claim, otherT.Claim)) return false;
            if (!DeepComparable.IsExactly(ClaimResponse, otherT.ClaimResponse)) return false;
            if (!DeepComparable.IsExactly(OutcomeElement, otherT.OutcomeElement)) return false;
            if (!DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if (!DeepComparable.IsExactly(Related, otherT.Related)) return false;
            if (!DeepComparable.IsExactly(Prescription, otherT.Prescription)) return false;
            if (!DeepComparable.IsExactly(OriginalPrescription, otherT.OriginalPrescription)) return false;
            if (!DeepComparable.IsExactly(Payee, otherT.Payee)) return false;
            if (!DeepComparable.IsExactly(Information, otherT.Information)) return false;
            if (!DeepComparable.IsExactly(CareTeam, otherT.CareTeam)) return false;
            if (!DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
            if (!DeepComparable.IsExactly(Procedure, otherT.Procedure)) return false;
            if (!DeepComparable.IsExactly(PrecedenceElement, otherT.PrecedenceElement)) return false;
            if (!DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;
            if (!DeepComparable.IsExactly(Accident, otherT.Accident)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
            if (!DeepComparable.IsExactly(AddItem, otherT.AddItem)) return false;
            if (!DeepComparable.IsExactly(Total, otherT.Total)) return false;
            if (!DeepComparable.IsExactly(Payment, otherT.Payment)) return false;
            if (!DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if (!DeepComparable.IsExactly(ProcessNote, otherT.ProcessNote)) return false;
            if (!DeepComparable.IsExactly(BenefitBalance, otherT.BenefitBalance)) return false;

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
                if (Type != null) yield return Type;
                foreach (var elem in SubType) { if (elem != null) yield return elem; }
                if (UseElement != null) yield return UseElement;
                if (Patient != null) yield return Patient;
                if (BillablePeriod != null) yield return BillablePeriod;
                if (CreatedElement != null) yield return CreatedElement;
                if (Enterer != null) yield return Enterer;
                if (Insurer != null) yield return Insurer;
                if (Provider != null) yield return Provider;
                if (Referral != null) yield return Referral;
                if (Facility != null) yield return Facility;
                if (Claim != null) yield return Claim;
                if (ClaimResponse != null) yield return ClaimResponse;
                if (OutcomeElement != null) yield return OutcomeElement;
                if (DispositionElement != null) yield return DispositionElement;
                foreach (var elem in Related) { if (elem != null) yield return elem; }
                if (Prescription != null) yield return Prescription;
                if (OriginalPrescription != null) yield return OriginalPrescription;
                if (Payee != null) yield return Payee;
                foreach (var elem in Information) { if (elem != null) yield return elem; }
                foreach (var elem in CareTeam) { if (elem != null) yield return elem; }
                foreach (var elem in Diagnosis) { if (elem != null) yield return elem; }
                foreach (var elem in Procedure) { if (elem != null) yield return elem; }
                if (PrecedenceElement != null) yield return PrecedenceElement;
                if (Insurance != null) yield return Insurance;
                if (Accident != null) yield return Accident;
                foreach (var elem in Item) { if (elem != null) yield return elem; }
                foreach (var elem in AddItem) { if (elem != null) yield return elem; }
                foreach (var elem in Total) { if (elem != null) yield return elem; }
                if (Payment != null) yield return Payment;
                if (Form != null) yield return Form;
                foreach (var elem in ProcessNote) { if (elem != null) yield return elem; }
                foreach (var elem in BenefitBalance) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (Type != null) yield return new ElementValue("type", false, Type);
                foreach (var elem in SubType) { if (elem != null) yield return new ElementValue("subType", true, elem); }
                if (UseElement != null) yield return new ElementValue("use", false, UseElement);
                if (Patient != null) yield return new ElementValue("patient", false, Patient);
                if (BillablePeriod != null) yield return new ElementValue("billablePeriod", false, BillablePeriod);
                if (CreatedElement != null) yield return new ElementValue("created", false, CreatedElement);
                if (Enterer != null) yield return new ElementValue("enterer", false, Enterer);
                if (Insurer != null) yield return new ElementValue("insurer", false, Insurer);
                if (Provider != null) yield return new ElementValue("provider", false, Provider);
                if (Referral != null) yield return new ElementValue("referral", false, Referral);
                if (Facility != null) yield return new ElementValue("facility", false, Facility);
                if (Claim != null) yield return new ElementValue("claim", false, Claim);
                if (ClaimResponse != null) yield return new ElementValue("claimResponse", false, ClaimResponse);
                if (OutcomeElement != null) yield return new ElementValue("outcome", false, OutcomeElement);
                if (DispositionElement != null) yield return new ElementValue("disposition", false, DispositionElement);
                foreach (var elem in Related) { if (elem != null) yield return new ElementValue("related", true, elem); }
                if (Prescription != null) yield return new ElementValue("prescription", false, Prescription);
                if (OriginalPrescription != null) yield return new ElementValue("originalPrescription", false, OriginalPrescription);
                if (Payee != null) yield return new ElementValue("payee", false, Payee);
                foreach (var elem in Information) { if (elem != null) yield return new ElementValue("information", true, elem); }
                foreach (var elem in CareTeam) { if (elem != null) yield return new ElementValue("careTeam", true, elem); }
                foreach (var elem in Diagnosis) { if (elem != null) yield return new ElementValue("diagnosis", true, elem); }
                foreach (var elem in Procedure) { if (elem != null) yield return new ElementValue("procedure", true, elem); }
                if (PrecedenceElement != null) yield return new ElementValue("precedence", false, PrecedenceElement);
                if (Insurance != null) yield return new ElementValue("insurance", false, Insurance);
                if (Accident != null) yield return new ElementValue("accident", false, Accident);
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", true, elem); }
                foreach (var elem in AddItem) { if (elem != null) yield return new ElementValue("addItem", true, elem); }
                foreach (var elem in Total) { if (elem != null) yield return new ElementValue("total", true, elem); }
                if (Payment != null) yield return new ElementValue("payment", false, Payment);
                if (Form != null) yield return new ElementValue("form", false, Form);
                foreach (var elem in ProcessNote) { if (elem != null) yield return new ElementValue("processNote", true, elem); }
                foreach (var elem in BenefitBalance) { if (elem != null) yield return new ElementValue("benefitBalance", true, elem); }
            }
        }

    }

}
