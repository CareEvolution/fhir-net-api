using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.STU3;
using Hl7.Fhir.Validation.STU3;
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
// Generated for FHIR v3.0.1
//
namespace Hl7.Fhir.Model.STU3
{
    /// <summary>
    /// Claim, Pre-determination or Pre-authorization
    /// </summary>
    [FhirType("Claim", IsResource=true)]
    [DataContract]
    public partial class Claim : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Claim; } }
        [NotMapped]
        public override string TypeName { get { return "Claim"; } }


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
                    if (Claim != null) yield return new ElementValue("claim", Claim);
                    if (Relationship != null) yield return new ElementValue("relationship", Relationship);
                    if (Reference != null) yield return new ElementValue("reference", Reference);
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
            [Cardinality(Min=1,Max=1)]
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
            [FhirElement("resourceType", Order=50)]
            [DataMember]
            public Coding ResourceType
            {
                get { return _resourceType; }
                set { _resourceType = value; OnPropertyChanged("ResourceType"); }
            }

            private Coding _resourceType;

            /// <summary>
            /// Party to receive the payable
            /// </summary>
            [FhirElement("party", Order=60)]
            [References("Practitioner","Organization","Patient","RelatedPerson")]
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
                    if (ResourceType != null) dest.ResourceType = (Coding)ResourceType.DeepCopy();
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
                if (!DeepComparable.Matches(ResourceType, otherT.ResourceType)) return false;
                if (!DeepComparable.Matches(Party, otherT.Party)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PayeeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(ResourceType, otherT.ResourceType)) return false;
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
                    if (ResourceType != null) yield return ResourceType;
                    if (Party != null) yield return Party;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (ResourceType != null) yield return new ElementValue("resourceType", ResourceType);
                    if (Party != null) yield return new ElementValue("party", Party);
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
            /// Number to covey order of careTeam
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
            /// Number to covey order of careTeam
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
            /// Provider individual or organization
            /// </summary>
            [FhirElement("provider", Order=50)]
            [References("Practitioner","Organization")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Provider
            {
                get { return _provider; }
                set { _provider = value; OnPropertyChanged("Provider"); }
            }

            private ResourceReference _provider;

            /// <summary>
            /// Billing provider
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
            /// Billing provider
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
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (Provider != null) yield return new ElementValue("provider", Provider);
                    if (ResponsibleElement != null) yield return new ElementValue("responsible", ResponsibleElement);
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Qualification != null) yield return new ElementValue("qualification", Qualification);
                }
            }


        }


        [FhirType("SpecialConditionComponent")]
        [DataContract]
        public partial class SpecialConditionComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SpecialConditionComponent"; } }

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
            [AllowedTypes(typeof(FhirString),typeof(Quantity),typeof(Attachment),typeof(ResourceReference))]
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
            public CodeableConcept Reason
            {
                get { return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private CodeableConcept _reason;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SpecialConditionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SpecialConditionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SpecialConditionComponent;
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
                var otherT = other as SpecialConditionComponent;
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
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Timing != null) yield return new ElementValue("timing", Timing);
                    if (Value != null) yield return new ElementValue("value", Value);
                    if (Reason != null) yield return new ElementValue("reason", Reason);
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
            /// Number to covey order of diagnosis
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
            /// Number to covey order of diagnosis
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
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (Diagnosis != null) yield return new ElementValue("diagnosis", Diagnosis);
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                    if (PackageCode != null) yield return new ElementValue("packageCode", PackageCode);
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
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                    if (Procedure != null) yield return new ElementValue("procedure", Procedure);
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
            /// Service instance identifier
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
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }

            /// <summary>
            /// Is the focal Coverage
            /// </summary>
            [FhirElement("focal", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean FocalElement
            {
                get { return _focalElement; }
                set { _focalElement = value; OnPropertyChanged("FocalElement"); }
            }

            private FhirBoolean _focalElement;

            /// <summary>
            /// Is the focal Coverage
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Focal
            {
                get { return FocalElement != null ? FocalElement.Value : null; }
                set
                {
                    if (value == null)
                        FocalElement = null;
                    else
                        FocalElement = new FhirBoolean(value);
                    OnPropertyChanged("Focal");
                }
            }

            /// <summary>
            /// Insurance information
            /// </summary>
            [FhirElement("coverage", Order=60)]
            [References("Coverage")]
            [Cardinality(Min=1,Max=1)]
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
            [FhirElement("businessArrangement", Order=70)]
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
            /// Pre-Authorization/Determination Reference
            /// </summary>
            [FhirElement("preAuthRef", Order=80)]
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

            /// <summary>
            /// Adjudication results
            /// </summary>
            [FhirElement("claimResponse", Order=90)]
            [References("ClaimResponse")]
            [DataMember]
            public ResourceReference ClaimResponse
            {
                get { return _claimResponse; }
                set { _claimResponse = value; OnPropertyChanged("ClaimResponse"); }
            }

            private ResourceReference _claimResponse;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InsuranceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SequenceElement != null) dest.SequenceElement = (PositiveInt)SequenceElement.DeepCopy();
                    if (FocalElement != null) dest.FocalElement = (FhirBoolean)FocalElement.DeepCopy();
                    if (Coverage != null) dest.Coverage = (ResourceReference)Coverage.DeepCopy();
                    if (BusinessArrangementElement != null) dest.BusinessArrangementElement = (FhirString)BusinessArrangementElement.DeepCopy();
                    if (PreAuthRefElement != null) dest.PreAuthRefElement = new List<FhirString>(PreAuthRefElement.DeepCopy());
                    if (ClaimResponse != null) dest.ClaimResponse = (ResourceReference)ClaimResponse.DeepCopy();
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
                if (!DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.Matches(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.Matches(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
                if ( !DeepComparable.Matches(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
                if (!DeepComparable.Matches(ClaimResponse, otherT.ClaimResponse)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InsuranceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(FocalElement, otherT.FocalElement)) return false;
                if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.IsExactly(BusinessArrangementElement, otherT.BusinessArrangementElement)) return false;
                if (!DeepComparable.IsExactly(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
                if (!DeepComparable.IsExactly(ClaimResponse, otherT.ClaimResponse)) return false;

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
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return elem; }
                    if (ClaimResponse != null) yield return ClaimResponse;
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
                    foreach (var elem in PreAuthRefElement) { if (elem != null) yield return new ElementValue("preAuthRef", elem); }
                    if (ClaimResponse != null) yield return new ElementValue("claimResponse", ClaimResponse);
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
            /// When the accident occurred<br/>
            /// see information codes<br/>
            /// see information codes
            /// </summary>
            [FhirElement("date", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Date DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private Date _dateElement;

            /// <summary>
            /// When the accident occurred<br/>
            /// see information codes<br/>
            /// see information codes
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
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Location != null) yield return new ElementValue("location", Location);
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
            /// Applicable careTeam members
            /// </summary>
            [FhirElement("careTeamLinkId", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> CareTeamLinkIdElement
            {
                get { if (_careTeamLinkIdElement==null) _careTeamLinkIdElement = new List<PositiveInt>(); return _careTeamLinkIdElement; }
                set { _careTeamLinkIdElement = value; OnPropertyChanged("CareTeamLinkIdElement"); }
            }

            private List<PositiveInt> _careTeamLinkIdElement;

            /// <summary>
            /// Applicable careTeam members
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> CareTeamLinkId
            {
                get { return CareTeamLinkIdElement != null ? CareTeamLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        CareTeamLinkIdElement = null;
                    else
                        CareTeamLinkIdElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("CareTeamLinkId");
                }
            }

            /// <summary>
            /// Applicable diagnoses
            /// </summary>
            [FhirElement("diagnosisLinkId", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> DiagnosisLinkIdElement
            {
                get { if (_diagnosisLinkIdElement==null) _diagnosisLinkIdElement = new List<PositiveInt>(); return _diagnosisLinkIdElement; }
                set { _diagnosisLinkIdElement = value; OnPropertyChanged("DiagnosisLinkIdElement"); }
            }

            private List<PositiveInt> _diagnosisLinkIdElement;

            /// <summary>
            /// Applicable diagnoses
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
                        DiagnosisLinkIdElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("DiagnosisLinkId");
                }
            }

            /// <summary>
            /// Applicable procedures
            /// </summary>
            [FhirElement("procedureLinkId", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> ProcedureLinkIdElement
            {
                get { if (_procedureLinkIdElement==null) _procedureLinkIdElement = new List<PositiveInt>(); return _procedureLinkIdElement; }
                set { _procedureLinkIdElement = value; OnPropertyChanged("ProcedureLinkIdElement"); }
            }

            private List<PositiveInt> _procedureLinkIdElement;

            /// <summary>
            /// Applicable procedures
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> ProcedureLinkId
            {
                get { return ProcedureLinkIdElement != null ? ProcedureLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ProcedureLinkIdElement = null;
                    else
                        ProcedureLinkIdElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("ProcedureLinkId");
                }
            }

            /// <summary>
            /// Applicable exception and supporting information
            /// </summary>
            [FhirElement("informationLinkId", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PositiveInt> InformationLinkIdElement
            {
                get { if (_informationLinkIdElement==null) _informationLinkIdElement = new List<PositiveInt>(); return _informationLinkIdElement; }
                set { _informationLinkIdElement = value; OnPropertyChanged("InformationLinkIdElement"); }
            }

            private List<PositiveInt> _informationLinkIdElement;

            /// <summary>
            /// Applicable exception and supporting information
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<int?> InformationLinkId
            {
                get { return InformationLinkIdElement != null ? InformationLinkIdElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        InformationLinkIdElement = null;
                    else
                        InformationLinkIdElement = new List<PositiveInt>(value.Select(elem=>new PositiveInt(elem)));
                    OnPropertyChanged("InformationLinkId");
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
            /// Additional items
            /// </summary>
            [FhirElement("detail", Order=240)]
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
                    if (CareTeamLinkIdElement != null) dest.CareTeamLinkIdElement = new List<PositiveInt>(CareTeamLinkIdElement.DeepCopy());
                    if (DiagnosisLinkIdElement != null) dest.DiagnosisLinkIdElement = new List<PositiveInt>(DiagnosisLinkIdElement.DeepCopy());
                    if (ProcedureLinkIdElement != null) dest.ProcedureLinkIdElement = new List<PositiveInt>(ProcedureLinkIdElement.DeepCopy());
                    if (InformationLinkIdElement != null) dest.InformationLinkIdElement = new List<PositiveInt>(InformationLinkIdElement.DeepCopy());
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
                if ( !DeepComparable.Matches(CareTeamLinkIdElement, otherT.CareTeamLinkIdElement)) return false;
                if ( !DeepComparable.Matches(DiagnosisLinkIdElement, otherT.DiagnosisLinkIdElement)) return false;
                if ( !DeepComparable.Matches(ProcedureLinkIdElement, otherT.ProcedureLinkIdElement)) return false;
                if ( !DeepComparable.Matches(InformationLinkIdElement, otherT.InformationLinkIdElement)) return false;
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
                if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if (!DeepComparable.IsExactly(CareTeamLinkIdElement, otherT.CareTeamLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(DiagnosisLinkIdElement, otherT.DiagnosisLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(ProcedureLinkIdElement, otherT.ProcedureLinkIdElement)) return false;
                if (!DeepComparable.IsExactly(InformationLinkIdElement, otherT.InformationLinkIdElement)) return false;
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
                    foreach (var elem in CareTeamLinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in DiagnosisLinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in ProcedureLinkIdElement) { if (elem != null) yield return elem; }
                    foreach (var elem in InformationLinkIdElement) { if (elem != null) yield return elem; }
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
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    foreach (var elem in CareTeamLinkIdElement) { if (elem != null) yield return new ElementValue("careTeamLinkId", elem); }
                    foreach (var elem in DiagnosisLinkIdElement) { if (elem != null) yield return new ElementValue("diagnosisLinkId", elem); }
                    foreach (var elem in ProcedureLinkIdElement) { if (elem != null) yield return new ElementValue("procedureLinkId", elem); }
                    foreach (var elem in InformationLinkIdElement) { if (elem != null) yield return new ElementValue("informationLinkId", elem); }
                    if (Revenue != null) yield return new ElementValue("revenue", Revenue);
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Service != null) yield return new ElementValue("service", Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", elem); }
                    foreach (var elem in ProgramCode) { if (elem != null) yield return new ElementValue("programCode", elem); }
                    if (Serviced != null) yield return new ElementValue("serviced", Serviced);
                    if (Location != null) yield return new ElementValue("location", Location);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                    foreach (var elem in Udi) { if (elem != null) yield return new ElementValue("udi", elem); }
                    if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                    foreach (var elem in SubSite) { if (elem != null) yield return new ElementValue("subSite", elem); }
                    foreach (var elem in Encounter) { if (elem != null) yield return new ElementValue("encounter", elem); }
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
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
            /// Additional items
            /// </summary>
            [FhirElement("subDetail", Order=150)]
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
                    if (Revenue != null) yield return new ElementValue("revenue", Revenue);
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Service != null) yield return new ElementValue("service", Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", elem); }
                    foreach (var elem in ProgramCode) { if (elem != null) yield return new ElementValue("programCode", elem); }
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                    foreach (var elem in Udi) { if (elem != null) yield return new ElementValue("udi", elem); }
                    foreach (var elem in SubDetail) { if (elem != null) yield return new ElementValue("subDetail", elem); }
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
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
                    if (Revenue != null) yield return new ElementValue("revenue", Revenue);
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Service != null) yield return new ElementValue("service", Service);
                    foreach (var elem in Modifier) { if (elem != null) yield return new ElementValue("modifier", elem); }
                    foreach (var elem in ProgramCode) { if (elem != null) yield return new ElementValue("programCode", elem); }
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (UnitPrice != null) yield return new ElementValue("unitPrice", UnitPrice);
                    if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
                    if (Net != null) yield return new ElementValue("net", Net);
                    foreach (var elem in Udi) { if (elem != null) yield return new ElementValue("udi", elem); }
                }
            }


        }


        /// <summary>
        /// Claim number
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
        public Code<FinancialResourceStatusCodes> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<FinancialResourceStatusCodes> _statusElement;

        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public FinancialResourceStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<FinancialResourceStatusCodes>(value);
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
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Enterer
        {
            get { return _enterer; }
            set { _enterer = value; OnPropertyChanged("Enterer"); }
        }

        private ResourceReference _enterer;

        /// <summary>
        /// Target
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
        /// Responsible provider
        /// </summary>
        [FhirElement("provider", Order=190)]
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
        [FhirElement("organization", Order=200)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private ResourceReference _organization;

        /// <summary>
        /// Desired processing priority
        /// </summary>
        [FhirElement("priority", Order=210)]
        [DataMember]
        public CodeableConcept Priority
        {
            get { return _priority; }
            set { _priority = value; OnPropertyChanged("Priority"); }
        }

        private CodeableConcept _priority;

        /// <summary>
        /// Funds requested to be reserved
        /// </summary>
        [FhirElement("fundsReserve", Order=220)]
        [DataMember]
        public CodeableConcept FundsReserve
        {
            get { return _fundsReserve; }
            set { _fundsReserve = value; OnPropertyChanged("FundsReserve"); }
        }

        private CodeableConcept _fundsReserve;

        /// <summary>
        /// Related Claims which may be revelant to processing this claimn
        /// </summary>
        [FhirElement("related", Order=230)]
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
        [FhirElement("prescription", Order=240)]
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
        [FhirElement("originalPrescription", Order=250)]
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
        [FhirElement("payee", Order=260)]
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
        [FhirElement("referral", Order=270)]
        [References("ReferralRequest")]
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
        [FhirElement("facility", Order=280)]
        [References("Location")]
        [DataMember]
        public ResourceReference Facility
        {
            get { return _facility; }
            set { _facility = value; OnPropertyChanged("Facility"); }
        }

        private ResourceReference _facility;

        /// <summary>
        /// Members of the care team
        /// </summary>
        [FhirElement("careTeam", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CareTeamComponent> CareTeam
        {
            get { if (_careTeam==null) _careTeam = new List<CareTeamComponent>(); return _careTeam; }
            set { _careTeam = value; OnPropertyChanged("CareTeam"); }
        }

        private List<CareTeamComponent> _careTeam;

        /// <summary>
        /// Exceptions, special considerations, the condition, situation, prior or concurrent issues
        /// </summary>
        [FhirElement("information", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SpecialConditionComponent> Information
        {
            get { if (_information==null) _information = new List<SpecialConditionComponent>(); return _information; }
            set { _information = value; OnPropertyChanged("Information"); }
        }

        private List<SpecialConditionComponent> _information;

        /// <summary>
        /// List of Diagnosis
        /// </summary>
        [FhirElement("diagnosis", Order=310)]
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
        [FhirElement("procedure", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ProcedureComponent> Procedure
        {
            get { if (_procedure==null) _procedure = new List<ProcedureComponent>(); return _procedure; }
            set { _procedure = value; OnPropertyChanged("Procedure"); }
        }

        private List<ProcedureComponent> _procedure;

        /// <summary>
        /// Insurance or medical plan
        /// </summary>
        [FhirElement("insurance", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<InsuranceComponent> Insurance
        {
            get { if (_insurance==null) _insurance = new List<InsuranceComponent>(); return _insurance; }
            set { _insurance = value; OnPropertyChanged("Insurance"); }
        }

        private List<InsuranceComponent> _insurance;

        /// <summary>
        /// Details about an accident
        /// </summary>
        [FhirElement("accident", Order=340)]
        [DataMember]
        public AccidentComponent Accident
        {
            get { return _accident; }
            set { _accident = value; OnPropertyChanged("Accident"); }
        }

        private AccidentComponent _accident;

        /// <summary>
        /// Period unable to work
        /// </summary>
        [FhirElement("employmentImpacted", Order=350)]
        [DataMember]
        public Period EmploymentImpacted
        {
            get { return _employmentImpacted; }
            set { _employmentImpacted = value; OnPropertyChanged("EmploymentImpacted"); }
        }

        private Period _employmentImpacted;

        /// <summary>
        /// Period in hospital
        /// </summary>
        [FhirElement("hospitalization", Order=360)]
        [DataMember]
        public Period Hospitalization
        {
            get { return _hospitalization; }
            set { _hospitalization = value; OnPropertyChanged("Hospitalization"); }
        }

        private Period _hospitalization;

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
        /// Total claim cost
        /// </summary>
        [FhirElement("total", Order=380)]
        [DataMember]
        public Money Total
        {
            get { return _total; }
            set { _total = value; OnPropertyChanged("Total"); }
        }

        private Money _total;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Claim;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (SubType != null) dest.SubType = new List<CodeableConcept>(SubType.DeepCopy());
                if (UseElement != null) dest.UseElement = (Code<Use>)UseElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (BillablePeriod != null) dest.BillablePeriod = (Period)BillablePeriod.DeepCopy();
                if (CreatedElement != null) dest.CreatedElement = (FhirDateTime)CreatedElement.DeepCopy();
                if (Enterer != null) dest.Enterer = (ResourceReference)Enterer.DeepCopy();
                if (Insurer != null) dest.Insurer = (ResourceReference)Insurer.DeepCopy();
                if (Provider != null) dest.Provider = (ResourceReference)Provider.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (Priority != null) dest.Priority = (CodeableConcept)Priority.DeepCopy();
                if (FundsReserve != null) dest.FundsReserve = (CodeableConcept)FundsReserve.DeepCopy();
                if (Related != null) dest.Related = new List<RelatedClaimComponent>(Related.DeepCopy());
                if (Prescription != null) dest.Prescription = (ResourceReference)Prescription.DeepCopy();
                if (OriginalPrescription != null) dest.OriginalPrescription = (ResourceReference)OriginalPrescription.DeepCopy();
                if (Payee != null) dest.Payee = (PayeeComponent)Payee.DeepCopy();
                if (Referral != null) dest.Referral = (ResourceReference)Referral.DeepCopy();
                if (Facility != null) dest.Facility = (ResourceReference)Facility.DeepCopy();
                if (CareTeam != null) dest.CareTeam = new List<CareTeamComponent>(CareTeam.DeepCopy());
                if (Information != null) dest.Information = new List<SpecialConditionComponent>(Information.DeepCopy());
                if (Diagnosis != null) dest.Diagnosis = new List<DiagnosisComponent>(Diagnosis.DeepCopy());
                if (Procedure != null) dest.Procedure = new List<ProcedureComponent>(Procedure.DeepCopy());
                if (Insurance != null) dest.Insurance = new List<InsuranceComponent>(Insurance.DeepCopy());
                if (Accident != null) dest.Accident = (AccidentComponent)Accident.DeepCopy();
                if (EmploymentImpacted != null) dest.EmploymentImpacted = (Period)EmploymentImpacted.DeepCopy();
                if (Hospitalization != null) dest.Hospitalization = (Period)Hospitalization.DeepCopy();
                if (Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                if (Total != null) dest.Total = (Money)Total.DeepCopy();
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
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if (!DeepComparable.Matches(FundsReserve, otherT.FundsReserve)) return false;
            if ( !DeepComparable.Matches(Related, otherT.Related)) return false;
            if (!DeepComparable.Matches(Prescription, otherT.Prescription)) return false;
            if (!DeepComparable.Matches(OriginalPrescription, otherT.OriginalPrescription)) return false;
            if (!DeepComparable.Matches(Payee, otherT.Payee)) return false;
            if (!DeepComparable.Matches(Referral, otherT.Referral)) return false;
            if (!DeepComparable.Matches(Facility, otherT.Facility)) return false;
            if ( !DeepComparable.Matches(CareTeam, otherT.CareTeam)) return false;
            if ( !DeepComparable.Matches(Information, otherT.Information)) return false;
            if ( !DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
            if ( !DeepComparable.Matches(Procedure, otherT.Procedure)) return false;
            if ( !DeepComparable.Matches(Insurance, otherT.Insurance)) return false;
            if (!DeepComparable.Matches(Accident, otherT.Accident)) return false;
            if (!DeepComparable.Matches(EmploymentImpacted, otherT.EmploymentImpacted)) return false;
            if (!DeepComparable.Matches(Hospitalization, otherT.Hospitalization)) return false;
            if ( !DeepComparable.Matches(Item, otherT.Item)) return false;
            if (!DeepComparable.Matches(Total, otherT.Total)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Claim;
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
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if (!DeepComparable.IsExactly(FundsReserve, otherT.FundsReserve)) return false;
            if (!DeepComparable.IsExactly(Related, otherT.Related)) return false;
            if (!DeepComparable.IsExactly(Prescription, otherT.Prescription)) return false;
            if (!DeepComparable.IsExactly(OriginalPrescription, otherT.OriginalPrescription)) return false;
            if (!DeepComparable.IsExactly(Payee, otherT.Payee)) return false;
            if (!DeepComparable.IsExactly(Referral, otherT.Referral)) return false;
            if (!DeepComparable.IsExactly(Facility, otherT.Facility)) return false;
            if (!DeepComparable.IsExactly(CareTeam, otherT.CareTeam)) return false;
            if (!DeepComparable.IsExactly(Information, otherT.Information)) return false;
            if (!DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
            if (!DeepComparable.IsExactly(Procedure, otherT.Procedure)) return false;
            if (!DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;
            if (!DeepComparable.IsExactly(Accident, otherT.Accident)) return false;
            if (!DeepComparable.IsExactly(EmploymentImpacted, otherT.EmploymentImpacted)) return false;
            if (!DeepComparable.IsExactly(Hospitalization, otherT.Hospitalization)) return false;
            if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;
            if (!DeepComparable.IsExactly(Total, otherT.Total)) return false;

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
                if (Organization != null) yield return Organization;
                if (Priority != null) yield return Priority;
                if (FundsReserve != null) yield return FundsReserve;
                foreach (var elem in Related) { if (elem != null) yield return elem; }
                if (Prescription != null) yield return Prescription;
                if (OriginalPrescription != null) yield return OriginalPrescription;
                if (Payee != null) yield return Payee;
                if (Referral != null) yield return Referral;
                if (Facility != null) yield return Facility;
                foreach (var elem in CareTeam) { if (elem != null) yield return elem; }
                foreach (var elem in Information) { if (elem != null) yield return elem; }
                foreach (var elem in Diagnosis) { if (elem != null) yield return elem; }
                foreach (var elem in Procedure) { if (elem != null) yield return elem; }
                foreach (var elem in Insurance) { if (elem != null) yield return elem; }
                if (Accident != null) yield return Accident;
                if (EmploymentImpacted != null) yield return EmploymentImpacted;
                if (Hospitalization != null) yield return Hospitalization;
                foreach (var elem in Item) { if (elem != null) yield return elem; }
                if (Total != null) yield return Total;
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
                if (Type != null) yield return new ElementValue("type", Type);
                foreach (var elem in SubType) { if (elem != null) yield return new ElementValue("subType", elem); }
                if (UseElement != null) yield return new ElementValue("use", UseElement);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (BillablePeriod != null) yield return new ElementValue("billablePeriod", BillablePeriod);
                if (CreatedElement != null) yield return new ElementValue("created", CreatedElement);
                if (Enterer != null) yield return new ElementValue("enterer", Enterer);
                if (Insurer != null) yield return new ElementValue("insurer", Insurer);
                if (Provider != null) yield return new ElementValue("provider", Provider);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                if (Priority != null) yield return new ElementValue("priority", Priority);
                if (FundsReserve != null) yield return new ElementValue("fundsReserve", FundsReserve);
                foreach (var elem in Related) { if (elem != null) yield return new ElementValue("related", elem); }
                if (Prescription != null) yield return new ElementValue("prescription", Prescription);
                if (OriginalPrescription != null) yield return new ElementValue("originalPrescription", OriginalPrescription);
                if (Payee != null) yield return new ElementValue("payee", Payee);
                if (Referral != null) yield return new ElementValue("referral", Referral);
                if (Facility != null) yield return new ElementValue("facility", Facility);
                foreach (var elem in CareTeam) { if (elem != null) yield return new ElementValue("careTeam", elem); }
                foreach (var elem in Information) { if (elem != null) yield return new ElementValue("information", elem); }
                foreach (var elem in Diagnosis) { if (elem != null) yield return new ElementValue("diagnosis", elem); }
                foreach (var elem in Procedure) { if (elem != null) yield return new ElementValue("procedure", elem); }
                foreach (var elem in Insurance) { if (elem != null) yield return new ElementValue("insurance", elem); }
                if (Accident != null) yield return new ElementValue("accident", Accident);
                if (EmploymentImpacted != null) yield return new ElementValue("employmentImpacted", EmploymentImpacted);
                if (Hospitalization != null) yield return new ElementValue("hospitalization", Hospitalization);
                foreach (var elem in Item) { if (elem != null) yield return new ElementValue("item", elem); }
                if (Total != null) yield return new ElementValue("total", Total);
            }
        }

    }

}
