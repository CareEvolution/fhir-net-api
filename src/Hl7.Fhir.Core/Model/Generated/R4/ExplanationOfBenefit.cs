﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
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
    [FhirType(Hl7.Fhir.Model.Version.R4, "ExplanationOfBenefit", IsResource=true)]
    [DataContract]
    public partial class ExplanationOfBenefit : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ExplanationOfBenefit; } }
        [NotMapped]
        public override string TypeName { get { return "ExplanationOfBenefit"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "RelatedClaimComponent")]
        [DataContract]
        public partial class RelatedClaimComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedClaimComponent"; } }
            
            /// <summary>
            /// Reference to the related claim
            /// </summary>
            [FhirElement("claim", Order=40)]
            [CLSCompliant(false)]
            [References("Claim")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Claim
            {
                get { return _Claim; }
                set { _Claim = value; OnPropertyChanged("Claim"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Claim;
            
            /// <summary>
            /// How the reference claim is related
            /// </summary>
            [FhirElement("relationship", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Relationship
            {
                get { return _Relationship; }
                set { _Relationship = value; OnPropertyChanged("Relationship"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Relationship;
            
            /// <summary>
            /// Related file or case reference
            /// </summary>
            [FhirElement("reference", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Reference
            {
                get { return _Reference; }
                set { _Reference = value; OnPropertyChanged("Reference"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Reference;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatedClaimComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Claim != null) dest.Claim = (Hl7.Fhir.Model.R4.ResourceReference)Claim.DeepCopy();
                    if(Relationship != null) dest.Relationship = (Hl7.Fhir.Model.R4.CodeableConcept)Relationship.DeepCopy();
                    if(Reference != null) dest.Reference = (Hl7.Fhir.Model.R4.Identifier)Reference.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Claim, otherT.Claim)) return false;
                if( !DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
                if( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedClaimComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Claim, otherT.Claim)) return false;
                if( !DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
                if( !DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PayeeComponent")]
        [DataContract]
        public partial class PayeeComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PayeeComponent"; } }
            
            /// <summary>
            /// Type of party: Subscriber, Provider, other
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// organization | patient | practitioner | relatedperson
            /// </summary>
            [FhirElement("resource", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Coding Resource
            {
                get { return _Resource; }
                set { _Resource = value; OnPropertyChanged("Resource"); }
            }
            
            private Hl7.Fhir.Model.R4.Coding _Resource;
            
            /// <summary>
            /// Party to receive the payable
            /// </summary>
            [FhirElement("party", Order=60)]
            [CLSCompliant(false)]
            [References("Practitioner","PractitionerRole","Organization","Patient","RelatedPerson")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Party
            {
                get { return _Party; }
                set { _Party = value; OnPropertyChanged("Party"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Party;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PayeeComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Resource != null) dest.Resource = (Hl7.Fhir.Model.R4.Coding)Resource.DeepCopy();
                    if(Party != null) dest.Party = (Hl7.Fhir.Model.R4.ResourceReference)Party.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if( !DeepComparable.Matches(Party, otherT.Party)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PayeeComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if( !DeepComparable.IsExactly(Party, otherT.Party)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SupportingInformationComponent")]
        [DataContract]
        public partial class SupportingInformationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SupportingInformationComponent"; } }
            
            /// <summary>
            /// Information instance identifier
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt SequenceElement
            {
                get { return _SequenceElement; }
                set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _SequenceElement;
            
            /// <summary>
            /// Information instance identifier
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }
            
            /// <summary>
            /// General class of information
            /// </summary>
            [FhirElement("category", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Category;
            
            /// <summary>
            /// Type of information
            /// </summary>
            [FhirElement("code", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Code;
            
            /// <summary>
            /// When it occurred
            /// </summary>
            [FhirElement("timing", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.Date),typeof(Hl7.Fhir.Model.R4.Period))]
            [DataMember]
            public Hl7.Fhir.Model.Element Timing
            {
                get { return _Timing; }
                set { _Timing = value; OnPropertyChanged("Timing"); }
            }
            
            private Hl7.Fhir.Model.Element _Timing;
            
            /// <summary>
            /// Additional Data or supporting information
            /// </summary>
            [FhirElement("value", Order=80, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.R4.Quantity),typeof(Hl7.Fhir.Model.R4.Attachment),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.Element _Value;
            
            /// <summary>
            /// Reason associated with the information
            /// </summary>
            [FhirElement("reason", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Coding Reason
            {
                get { return _Reason; }
                set { _Reason = value; OnPropertyChanged("Reason"); }
            }
            
            private Hl7.Fhir.Model.R4.Coding _Reason;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SupportingInformationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.R4.PositiveInt)SequenceElement.DeepCopy();
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.R4.CodeableConcept)Category.DeepCopy();
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                    if(Timing != null) dest.Timing = (Hl7.Fhir.Model.Element)Timing.DeepCopy();
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.Element)Value.DeepCopy();
                    if(Reason != null) dest.Reason = (Hl7.Fhir.Model.R4.Coding)Reason.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Timing, otherT.Timing)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
                if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SupportingInformationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
                if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "CareTeamComponent")]
        [DataContract]
        public partial class CareTeamComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CareTeamComponent"; } }
            
            /// <summary>
            /// Number to convey order of careteam
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt SequenceElement
            {
                get { return _SequenceElement; }
                set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _SequenceElement;
            
            /// <summary>
            /// Number to convey order of careteam
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }
            
            /// <summary>
            /// Member of the Care Team
            /// </summary>
            [FhirElement("provider", Order=50)]
            [CLSCompliant(false)]
            [References("Practitioner","PractitionerRole","Organization")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Provider
            {
                get { return _Provider; }
                set { _Provider = value; OnPropertyChanged("Provider"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Provider;
            
            /// <summary>
            /// Billing practitioner
            /// </summary>
            [FhirElement("responsible", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean ResponsibleElement
            {
                get { return _ResponsibleElement; }
                set { _ResponsibleElement = value; OnPropertyChanged("ResponsibleElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _ResponsibleElement;
            
            /// <summary>
            /// Billing practitioner
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Responsible
            {
                get { return ResponsibleElement != null ? ResponsibleElement.Value : null; }
                set
                {
                    if (value == null)
                        ResponsibleElement = null;
                    else
                        ResponsibleElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Responsible");
                }
            }
            
            /// <summary>
            /// Role on the team
            /// </summary>
            [FhirElement("role", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Role
            {
                get { return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Role;
            
            /// <summary>
            /// Type, classification or Specialization
            /// </summary>
            [FhirElement("qualification", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Qualification
            {
                get { return _Qualification; }
                set { _Qualification = value; OnPropertyChanged("Qualification"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Qualification;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CareTeamComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.R4.PositiveInt)SequenceElement.DeepCopy();
                    if(Provider != null) dest.Provider = (Hl7.Fhir.Model.R4.ResourceReference)Provider.DeepCopy();
                    if(ResponsibleElement != null) dest.ResponsibleElement = (Hl7.Fhir.Model.FhirBoolean)ResponsibleElement.DeepCopy();
                    if(Role != null) dest.Role = (Hl7.Fhir.Model.R4.CodeableConcept)Role.DeepCopy();
                    if(Qualification != null) dest.Qualification = (Hl7.Fhir.Model.R4.CodeableConcept)Qualification.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.Matches(Provider, otherT.Provider)) return false;
                if( !DeepComparable.Matches(ResponsibleElement, otherT.ResponsibleElement)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if( !DeepComparable.Matches(Qualification, otherT.Qualification)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CareTeamComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
                if( !DeepComparable.IsExactly(ResponsibleElement, otherT.ResponsibleElement)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if( !DeepComparable.IsExactly(Qualification, otherT.Qualification)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DiagnosisComponent")]
        [DataContract]
        public partial class DiagnosisComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DiagnosisComponent"; } }
            
            /// <summary>
            /// Number to convey order of diagnosis
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt SequenceElement
            {
                get { return _SequenceElement; }
                set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _SequenceElement;
            
            /// <summary>
            /// Number to convey order of diagnosis
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }
            
            /// <summary>
            /// Patient's diagnosis
            /// </summary>
            [FhirElement("diagnosis", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.CodeableConcept),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Diagnosis
            {
                get { return _Diagnosis; }
                set { _Diagnosis = value; OnPropertyChanged("Diagnosis"); }
            }
            
            private Hl7.Fhir.Model.Element _Diagnosis;
            
            /// <summary>
            /// Timing or nature of the diagnosis
            /// </summary>
            [FhirElement("type", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Type
            {
                get { if(_Type==null) _Type = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Type;
            
            /// <summary>
            /// Package billing code
            /// </summary>
            [FhirElement("packageCode", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept PackageCode
            {
                get { return _PackageCode; }
                set { _PackageCode = value; OnPropertyChanged("PackageCode"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _PackageCode;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DiagnosisComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.R4.PositiveInt)SequenceElement.DeepCopy();
                    if(Diagnosis != null) dest.Diagnosis = (Hl7.Fhir.Model.Element)Diagnosis.DeepCopy();
                    if(Type != null) dest.Type = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Type.DeepCopy());
                    if(PackageCode != null) dest.PackageCode = (Hl7.Fhir.Model.R4.CodeableConcept)PackageCode.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(PackageCode, otherT.PackageCode)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DiagnosisComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(PackageCode, otherT.PackageCode)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ProcedureComponent")]
        [DataContract]
        public partial class ProcedureComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ProcedureComponent"; } }
            
            /// <summary>
            /// Procedure sequence for reference
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt SequenceElement
            {
                get { return _SequenceElement; }
                set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _SequenceElement;
            
            /// <summary>
            /// Procedure sequence for reference
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }
            
            /// <summary>
            /// When the procedure was performed
            /// </summary>
            [FhirElement("date", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDateTime DateElement
            {
                get { return _DateElement; }
                set { _DateElement = value; OnPropertyChanged("DateElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
            
            /// <summary>
            /// When the procedure was performed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Date
            {
                get { return DateElement != null ? DateElement.Value : null; }
                set
                {
                    if (value == null)
                        DateElement = null;
                    else
                        DateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                    OnPropertyChanged("Date");
                }
            }
            
            /// <summary>
            /// Patient's list of procedures performed
            /// </summary>
            [FhirElement("procedure", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.CodeableConcept),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Procedure
            {
                get { return _Procedure; }
                set { _Procedure = value; OnPropertyChanged("Procedure"); }
            }
            
            private Hl7.Fhir.Model.Element _Procedure;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProcedureComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.R4.PositiveInt)SequenceElement.DeepCopy();
                    if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                    if(Procedure != null) dest.Procedure = (Hl7.Fhir.Model.Element)Procedure.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if( !DeepComparable.Matches(Procedure, otherT.Procedure)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProcedureComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if( !DeepComparable.IsExactly(Procedure, otherT.Procedure)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "InsuranceComponent")]
        [DataContract]
        public partial class InsuranceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "InsuranceComponent"; } }
            
            /// <summary>
            /// Insurance information
            /// </summary>
            [FhirElement("coverage", Order=40)]
            [CLSCompliant(false)]
            [References("Coverage")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Coverage
            {
                get { return _Coverage; }
                set { _Coverage = value; OnPropertyChanged("Coverage"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Coverage;
            
            /// <summary>
            /// Pre-Authorization/Determination Reference
            /// </summary>
            [FhirElement("preAuthRef", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> PreAuthRefElement
            {
                get { if(_PreAuthRefElement==null) _PreAuthRefElement = new List<Hl7.Fhir.Model.FhirString>(); return _PreAuthRefElement; }
                set { _PreAuthRefElement = value; OnPropertyChanged("PreAuthRefElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _PreAuthRefElement;
            
            /// <summary>
            /// Pre-Authorization/Determination Reference
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> PreAuthRef
            {
                get { return PreAuthRefElement != null ? PreAuthRefElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        PreAuthRefElement = null;
                    else
                        PreAuthRefElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("PreAuthRef");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InsuranceComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Coverage != null) dest.Coverage = (Hl7.Fhir.Model.R4.ResourceReference)Coverage.DeepCopy();
                    if(PreAuthRefElement != null) dest.PreAuthRefElement = new List<Hl7.Fhir.Model.FhirString>(PreAuthRefElement.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
                if( !DeepComparable.Matches(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InsuranceComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
                if( !DeepComparable.IsExactly(PreAuthRefElement, otherT.PreAuthRefElement)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "AccidentComponent")]
        [DataContract]
        public partial class AccidentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AccidentComponent"; } }
            
            /// <summary>
            /// When the accident occurred
            /// </summary>
            [FhirElement("date", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Date DateElement
            {
                get { return _DateElement; }
                set { _DateElement = value; OnPropertyChanged("DateElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Date _DateElement;
            
            /// <summary>
            /// When the accident occurred
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Date
            {
                get { return DateElement != null ? DateElement.Value : null; }
                set
                {
                    if (value == null)
                        DateElement = null;
                    else
                        DateElement = new Hl7.Fhir.Model.R4.Date(value);
                    OnPropertyChanged("Date");
                }
            }
            
            /// <summary>
            /// The nature of the accident
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Accident Place
            /// </summary>
            [FhirElement("location", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.Address),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Location
            {
                get { return _Location; }
                set { _Location = value; OnPropertyChanged("Location"); }
            }
            
            private Hl7.Fhir.Model.Element _Location;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AccidentComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.Date)DateElement.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Location != null) dest.Location = (Hl7.Fhir.Model.Element)Location.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Location, otherT.Location)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AccidentComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ItemComponent")]
        [DataContract]
        public partial class ItemComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ItemComponent"; } }
            
            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt SequenceElement
            {
                get { return _SequenceElement; }
                set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _SequenceElement;
            
            /// <summary>
            /// Service instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }
            
            /// <summary>
            /// Applicable careteam members
            /// </summary>
            [FhirElement("careTeamSequence", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> CareTeamSequenceElement
            {
                get { if(_CareTeamSequenceElement==null) _CareTeamSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _CareTeamSequenceElement; }
                set { _CareTeamSequenceElement = value; OnPropertyChanged("CareTeamSequenceElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _CareTeamSequenceElement;
            
            /// <summary>
            /// Applicable careteam members
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> CareTeamSequence
            {
                get { return CareTeamSequenceElement != null ? CareTeamSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        CareTeamSequenceElement = null;
                    else
                        CareTeamSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
                    OnPropertyChanged("CareTeamSequence");
                }
            }
            
            /// <summary>
            /// Applicable diagnoses
            /// </summary>
            [FhirElement("diagnosisSequence", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> DiagnosisSequenceElement
            {
                get { if(_DiagnosisSequenceElement==null) _DiagnosisSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _DiagnosisSequenceElement; }
                set { _DiagnosisSequenceElement = value; OnPropertyChanged("DiagnosisSequenceElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _DiagnosisSequenceElement;
            
            /// <summary>
            /// Applicable diagnoses
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> DiagnosisSequence
            {
                get { return DiagnosisSequenceElement != null ? DiagnosisSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        DiagnosisSequenceElement = null;
                    else
                        DiagnosisSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
                    OnPropertyChanged("DiagnosisSequence");
                }
            }
            
            /// <summary>
            /// Applicable procedures
            /// </summary>
            [FhirElement("procedureSequence", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> ProcedureSequenceElement
            {
                get { if(_ProcedureSequenceElement==null) _ProcedureSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _ProcedureSequenceElement; }
                set { _ProcedureSequenceElement = value; OnPropertyChanged("ProcedureSequenceElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _ProcedureSequenceElement;
            
            /// <summary>
            /// Applicable procedures
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> ProcedureSequence
            {
                get { return ProcedureSequenceElement != null ? ProcedureSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ProcedureSequenceElement = null;
                    else
                        ProcedureSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
                    OnPropertyChanged("ProcedureSequence");
                }
            }
            
            /// <summary>
            /// Applicable exception and supporting information
            /// </summary>
            [FhirElement("informationSequence", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> InformationSequenceElement
            {
                get { if(_InformationSequenceElement==null) _InformationSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _InformationSequenceElement; }
                set { _InformationSequenceElement = value; OnPropertyChanged("InformationSequenceElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _InformationSequenceElement;
            
            /// <summary>
            /// Applicable exception and supporting information
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> InformationSequence
            {
                get { return InformationSequenceElement != null ? InformationSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        InformationSequenceElement = null;
                    else
                        InformationSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
                    OnPropertyChanged("InformationSequence");
                }
            }
            
            /// <summary>
            /// Revenue or cost center code
            /// </summary>
            [FhirElement("revenue", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Revenue
            {
                get { return _Revenue; }
                set { _Revenue = value; OnPropertyChanged("Revenue"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Revenue;
            
            /// <summary>
            /// Type of service or product
            /// </summary>
            [FhirElement("category", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Category;
            
            /// <summary>
            /// Billing Code
            /// </summary>
            [FhirElement("service", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Service
            {
                get { return _Service; }
                set { _Service = value; OnPropertyChanged("Service"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Service;
            
            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Modifier
            {
                get { if(_Modifier==null) _Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Modifier; }
                set { _Modifier = value; OnPropertyChanged("Modifier"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Modifier;
            
            /// <summary>
            /// Program specific reason for item inclusion
            /// </summary>
            [FhirElement("programCode", Order=130)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> ProgramCode
            {
                get { if(_ProgramCode==null) _ProgramCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _ProgramCode; }
                set { _ProgramCode = value; OnPropertyChanged("ProgramCode"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _ProgramCode;
            
            /// <summary>
            /// Date or dates of Service
            /// </summary>
            [FhirElement("serviced", Order=140, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.Date),typeof(Hl7.Fhir.Model.R4.Period))]
            [DataMember]
            public Hl7.Fhir.Model.Element Serviced
            {
                get { return _Serviced; }
                set { _Serviced = value; OnPropertyChanged("Serviced"); }
            }
            
            private Hl7.Fhir.Model.Element _Serviced;
            
            /// <summary>
            /// Place of service
            /// </summary>
            [FhirElement("location", Order=150, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.CodeableConcept),typeof(Hl7.Fhir.Model.R4.Address),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Location
            {
                get { return _Location; }
                set { _Location = value; OnPropertyChanged("Location"); }
            }
            
            private Hl7.Fhir.Model.Element _Location;
            
            /// <summary>
            /// Count of Products or Services
            /// </summary>
            [FhirElement("quantity", Order=160)]
            [DataMember]
            public Hl7.Fhir.Model.R4.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.R4.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Fee, charge or cost per point
            /// </summary>
            [FhirElement("unitPrice", Order=170)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money UnitPrice
            {
                get { return _UnitPrice; }
                set { _UnitPrice = value; OnPropertyChanged("UnitPrice"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _UnitPrice;
            
            /// <summary>
            /// Price scaling factor
            /// </summary>
            [FhirElement("factor", Order=180)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDecimal FactorElement
            {
                get { return _FactorElement; }
                set { _FactorElement = value; OnPropertyChanged("FactorElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDecimal _FactorElement;
            
            /// <summary>
            /// Price scaling factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new Hl7.Fhir.Model.R4.FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }
            
            /// <summary>
            /// Total item cost
            /// </summary>
            [FhirElement("net", Order=190)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Net
            {
                get { return _Net; }
                set { _Net = value; OnPropertyChanged("Net"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Net;
            
            /// <summary>
            /// Unique Device Identifier
            /// </summary>
            [FhirElement("udi", Order=200)]
            [CLSCompliant(false)]
            [References("Device")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Udi
            {
                get { if(_Udi==null) _Udi = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Udi; }
                set { _Udi = value; OnPropertyChanged("Udi"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Udi;
            
            /// <summary>
            /// Service Location
            /// </summary>
            [FhirElement("bodySite", Order=210)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept BodySite
            {
                get { return _BodySite; }
                set { _BodySite = value; OnPropertyChanged("BodySite"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _BodySite;
            
            /// <summary>
            /// Service Sub-location
            /// </summary>
            [FhirElement("subSite", Order=220)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> SubSite
            {
                get { if(_SubSite==null) _SubSite = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _SubSite; }
                set { _SubSite = value; OnPropertyChanged("SubSite"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _SubSite;
            
            /// <summary>
            /// Encounters related to this billed item
            /// </summary>
            [FhirElement("encounter", Order=230)]
            [CLSCompliant(false)]
            [References("Encounter")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Encounter
            {
                get { if(_Encounter==null) _Encounter = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Encounter; }
                set { _Encounter = value; OnPropertyChanged("Encounter"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Encounter;
            
            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=240)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> NoteNumberElement
            {
                get { if(_NoteNumberElement==null) _NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _NoteNumberElement; }
                set { _NoteNumberElement = value; OnPropertyChanged("NoteNumberElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _NoteNumberElement;
            
            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> NoteNumber
            {
                get { return NoteNumberElement != null ? NoteNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberElement = null;
                    else
                        NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
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
                get { if(_Adjudication==null) _Adjudication = new List<AdjudicationComponent>(); return _Adjudication; }
                set { _Adjudication = value; OnPropertyChanged("Adjudication"); }
            }
            
            private List<AdjudicationComponent> _Adjudication;
            
            /// <summary>
            /// Additional items
            /// </summary>
            [FhirElement("detail", Order=260)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DetailComponent> Detail
            {
                get { if(_Detail==null) _Detail = new List<DetailComponent>(); return _Detail; }
                set { _Detail = value; OnPropertyChanged("Detail"); }
            }
            
            private List<DetailComponent> _Detail;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ItemComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.R4.PositiveInt)SequenceElement.DeepCopy();
                    if(CareTeamSequenceElement != null) dest.CareTeamSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(CareTeamSequenceElement.DeepCopy());
                    if(DiagnosisSequenceElement != null) dest.DiagnosisSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(DiagnosisSequenceElement.DeepCopy());
                    if(ProcedureSequenceElement != null) dest.ProcedureSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(ProcedureSequenceElement.DeepCopy());
                    if(InformationSequenceElement != null) dest.InformationSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(InformationSequenceElement.DeepCopy());
                    if(Revenue != null) dest.Revenue = (Hl7.Fhir.Model.R4.CodeableConcept)Revenue.DeepCopy();
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.R4.CodeableConcept)Category.DeepCopy();
                    if(Service != null) dest.Service = (Hl7.Fhir.Model.R4.CodeableConcept)Service.DeepCopy();
                    if(Modifier != null) dest.Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Modifier.DeepCopy());
                    if(ProgramCode != null) dest.ProgramCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(ProgramCode.DeepCopy());
                    if(Serviced != null) dest.Serviced = (Hl7.Fhir.Model.Element)Serviced.DeepCopy();
                    if(Location != null) dest.Location = (Hl7.Fhir.Model.Element)Location.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.R4.SimpleQuantity)Quantity.DeepCopy();
                    if(UnitPrice != null) dest.UnitPrice = (Hl7.Fhir.Model.R4.Money)UnitPrice.DeepCopy();
                    if(FactorElement != null) dest.FactorElement = (Hl7.Fhir.Model.R4.FhirDecimal)FactorElement.DeepCopy();
                    if(Net != null) dest.Net = (Hl7.Fhir.Model.R4.Money)Net.DeepCopy();
                    if(Udi != null) dest.Udi = new List<Hl7.Fhir.Model.R4.ResourceReference>(Udi.DeepCopy());
                    if(BodySite != null) dest.BodySite = (Hl7.Fhir.Model.R4.CodeableConcept)BodySite.DeepCopy();
                    if(SubSite != null) dest.SubSite = new List<Hl7.Fhir.Model.R4.CodeableConcept>(SubSite.DeepCopy());
                    if(Encounter != null) dest.Encounter = new List<Hl7.Fhir.Model.R4.ResourceReference>(Encounter.DeepCopy());
                    if(NoteNumberElement != null) dest.NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(NoteNumberElement.DeepCopy());
                    if(Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
                    if(Detail != null) dest.Detail = new List<DetailComponent>(Detail.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.Matches(CareTeamSequenceElement, otherT.CareTeamSequenceElement)) return false;
                if( !DeepComparable.Matches(DiagnosisSequenceElement, otherT.DiagnosisSequenceElement)) return false;
                if( !DeepComparable.Matches(ProcedureSequenceElement, otherT.ProcedureSequenceElement)) return false;
                if( !DeepComparable.Matches(InformationSequenceElement, otherT.InformationSequenceElement)) return false;
                if( !DeepComparable.Matches(Revenue, otherT.Revenue)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(Service, otherT.Service)) return false;
                if( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.Matches(ProgramCode, otherT.ProgramCode)) return false;
                if( !DeepComparable.Matches(Serviced, otherT.Serviced)) return false;
                if( !DeepComparable.Matches(Location, otherT.Location)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.Matches(Net, otherT.Net)) return false;
                if( !DeepComparable.Matches(Udi, otherT.Udi)) return false;
                if( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
                if( !DeepComparable.Matches(SubSite, otherT.SubSite)) return false;
                if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
                if( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if( !DeepComparable.Matches(Detail, otherT.Detail)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ItemComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.IsExactly(CareTeamSequenceElement, otherT.CareTeamSequenceElement)) return false;
                if( !DeepComparable.IsExactly(DiagnosisSequenceElement, otherT.DiagnosisSequenceElement)) return false;
                if( !DeepComparable.IsExactly(ProcedureSequenceElement, otherT.ProcedureSequenceElement)) return false;
                if( !DeepComparable.IsExactly(InformationSequenceElement, otherT.InformationSequenceElement)) return false;
                if( !DeepComparable.IsExactly(Revenue, otherT.Revenue)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if( !DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.IsExactly(ProgramCode, otherT.ProgramCode)) return false;
                if( !DeepComparable.IsExactly(Serviced, otherT.Serviced)) return false;
                if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if( !DeepComparable.IsExactly(Udi, otherT.Udi)) return false;
                if( !DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
                if( !DeepComparable.IsExactly(SubSite, otherT.SubSite)) return false;
                if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
                if( !DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if( !DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;
                if( !DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "AdjudicationComponent")]
        [DataContract]
        public partial class AdjudicationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AdjudicationComponent"; } }
            
            /// <summary>
            /// Adjudication category such as co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("category", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Category;
            
            /// <summary>
            /// Explanation of Adjudication outcome
            /// </summary>
            [FhirElement("reason", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Reason
            {
                get { return _Reason; }
                set { _Reason = value; OnPropertyChanged("Reason"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Reason;
            
            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Amount;
            
            /// <summary>
            /// Non-monitory value
            /// </summary>
            [FhirElement("value", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDecimal ValueElement
            {
                get { return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDecimal _ValueElement;
            
            /// <summary>
            /// Non-monitory value
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new Hl7.Fhir.Model.R4.FhirDecimal(value);
                    OnPropertyChanged("Value");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AdjudicationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.R4.CodeableConcept)Category.DeepCopy();
                    if(Reason != null) dest.Reason = (Hl7.Fhir.Model.R4.CodeableConcept)Reason.DeepCopy();
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.R4.Money)Amount.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.R4.FhirDecimal)ValueElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AdjudicationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DetailComponent")]
        [DataContract]
        public partial class DetailComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DetailComponent"; } }
            
            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt SequenceElement
            {
                get { return _SequenceElement; }
                set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _SequenceElement;
            
            /// <summary>
            /// Service instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }
            
            /// <summary>
            /// Revenue or cost center code
            /// </summary>
            [FhirElement("revenue", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Revenue
            {
                get { return _Revenue; }
                set { _Revenue = value; OnPropertyChanged("Revenue"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Revenue;
            
            /// <summary>
            /// Type of service or product
            /// </summary>
            [FhirElement("category", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Category;
            
            /// <summary>
            /// Billing Code
            /// </summary>
            [FhirElement("service", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Service
            {
                get { return _Service; }
                set { _Service = value; OnPropertyChanged("Service"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Service;
            
            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Modifier
            {
                get { if(_Modifier==null) _Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Modifier; }
                set { _Modifier = value; OnPropertyChanged("Modifier"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Modifier;
            
            /// <summary>
            /// Program specific reason for item inclusion
            /// </summary>
            [FhirElement("programCode", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> ProgramCode
            {
                get { if(_ProgramCode==null) _ProgramCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _ProgramCode; }
                set { _ProgramCode = value; OnPropertyChanged("ProgramCode"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _ProgramCode;
            
            /// <summary>
            /// Count of Products or Services
            /// </summary>
            [FhirElement("quantity", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.R4.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.R4.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Fee, charge or cost per point
            /// </summary>
            [FhirElement("unitPrice", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money UnitPrice
            {
                get { return _UnitPrice; }
                set { _UnitPrice = value; OnPropertyChanged("UnitPrice"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _UnitPrice;
            
            /// <summary>
            /// Price scaling factor
            /// </summary>
            [FhirElement("factor", Order=120)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDecimal FactorElement
            {
                get { return _FactorElement; }
                set { _FactorElement = value; OnPropertyChanged("FactorElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDecimal _FactorElement;
            
            /// <summary>
            /// Price scaling factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new Hl7.Fhir.Model.R4.FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }
            
            /// <summary>
            /// Total additional item cost
            /// </summary>
            [FhirElement("net", Order=130)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Net
            {
                get { return _Net; }
                set { _Net = value; OnPropertyChanged("Net"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Net;
            
            /// <summary>
            /// Unique Device Identifier
            /// </summary>
            [FhirElement("udi", Order=140)]
            [CLSCompliant(false)]
            [References("Device")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Udi
            {
                get { if(_Udi==null) _Udi = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Udi; }
                set { _Udi = value; OnPropertyChanged("Udi"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Udi;
            
            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> NoteNumberElement
            {
                get { if(_NoteNumberElement==null) _NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _NoteNumberElement; }
                set { _NoteNumberElement = value; OnPropertyChanged("NoteNumberElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _NoteNumberElement;
            
            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> NoteNumber
            {
                get { return NoteNumberElement != null ? NoteNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberElement = null;
                    else
                        NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
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
                get { if(_Adjudication==null) _Adjudication = new List<AdjudicationComponent>(); return _Adjudication; }
                set { _Adjudication = value; OnPropertyChanged("Adjudication"); }
            }
            
            private List<AdjudicationComponent> _Adjudication;
            
            /// <summary>
            /// Additional items
            /// </summary>
            [FhirElement("subDetail", Order=170)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SubDetailComponent> SubDetail
            {
                get { if(_SubDetail==null) _SubDetail = new List<SubDetailComponent>(); return _SubDetail; }
                set { _SubDetail = value; OnPropertyChanged("SubDetail"); }
            }
            
            private List<SubDetailComponent> _SubDetail;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DetailComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.R4.PositiveInt)SequenceElement.DeepCopy();
                    if(Revenue != null) dest.Revenue = (Hl7.Fhir.Model.R4.CodeableConcept)Revenue.DeepCopy();
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.R4.CodeableConcept)Category.DeepCopy();
                    if(Service != null) dest.Service = (Hl7.Fhir.Model.R4.CodeableConcept)Service.DeepCopy();
                    if(Modifier != null) dest.Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Modifier.DeepCopy());
                    if(ProgramCode != null) dest.ProgramCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(ProgramCode.DeepCopy());
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.R4.SimpleQuantity)Quantity.DeepCopy();
                    if(UnitPrice != null) dest.UnitPrice = (Hl7.Fhir.Model.R4.Money)UnitPrice.DeepCopy();
                    if(FactorElement != null) dest.FactorElement = (Hl7.Fhir.Model.R4.FhirDecimal)FactorElement.DeepCopy();
                    if(Net != null) dest.Net = (Hl7.Fhir.Model.R4.Money)Net.DeepCopy();
                    if(Udi != null) dest.Udi = new List<Hl7.Fhir.Model.R4.ResourceReference>(Udi.DeepCopy());
                    if(NoteNumberElement != null) dest.NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(NoteNumberElement.DeepCopy());
                    if(Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
                    if(SubDetail != null) dest.SubDetail = new List<SubDetailComponent>(SubDetail.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.Matches(Revenue, otherT.Revenue)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(Service, otherT.Service)) return false;
                if( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.Matches(ProgramCode, otherT.ProgramCode)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.Matches(Net, otherT.Net)) return false;
                if( !DeepComparable.Matches(Udi, otherT.Udi)) return false;
                if( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
                if( !DeepComparable.Matches(SubDetail, otherT.SubDetail)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DetailComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.IsExactly(Revenue, otherT.Revenue)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if( !DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.IsExactly(ProgramCode, otherT.ProgramCode)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if( !DeepComparable.IsExactly(Udi, otherT.Udi)) return false;
                if( !DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if( !DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;
                if( !DeepComparable.IsExactly(SubDetail, otherT.SubDetail)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SubDetailComponent")]
        [DataContract]
        public partial class SubDetailComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SubDetailComponent"; } }
            
            /// <summary>
            /// Service instance
            /// </summary>
            [FhirElement("sequence", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt SequenceElement
            {
                get { return _SequenceElement; }
                set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _SequenceElement;
            
            /// <summary>
            /// Service instance
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Sequence
            {
                get { return SequenceElement != null ? SequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        SequenceElement = null;
                    else
                        SequenceElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Sequence");
                }
            }
            
            /// <summary>
            /// Revenue or cost center code
            /// </summary>
            [FhirElement("revenue", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Revenue
            {
                get { return _Revenue; }
                set { _Revenue = value; OnPropertyChanged("Revenue"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Revenue;
            
            /// <summary>
            /// Type of service or product
            /// </summary>
            [FhirElement("category", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Category;
            
            /// <summary>
            /// Billing Code
            /// </summary>
            [FhirElement("service", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Service
            {
                get { return _Service; }
                set { _Service = value; OnPropertyChanged("Service"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Service;
            
            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Modifier
            {
                get { if(_Modifier==null) _Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Modifier; }
                set { _Modifier = value; OnPropertyChanged("Modifier"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Modifier;
            
            /// <summary>
            /// Program specific reason for item inclusion
            /// </summary>
            [FhirElement("programCode", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> ProgramCode
            {
                get { if(_ProgramCode==null) _ProgramCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _ProgramCode; }
                set { _ProgramCode = value; OnPropertyChanged("ProgramCode"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _ProgramCode;
            
            /// <summary>
            /// Count of Products or Services
            /// </summary>
            [FhirElement("quantity", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.R4.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.R4.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Fee, charge or cost per point
            /// </summary>
            [FhirElement("unitPrice", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money UnitPrice
            {
                get { return _UnitPrice; }
                set { _UnitPrice = value; OnPropertyChanged("UnitPrice"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _UnitPrice;
            
            /// <summary>
            /// Price scaling factor
            /// </summary>
            [FhirElement("factor", Order=120)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDecimal FactorElement
            {
                get { return _FactorElement; }
                set { _FactorElement = value; OnPropertyChanged("FactorElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDecimal _FactorElement;
            
            /// <summary>
            /// Price scaling factor
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Factor
            {
                get { return FactorElement != null ? FactorElement.Value : null; }
                set
                {
                    if (value == null)
                        FactorElement = null;
                    else
                        FactorElement = new Hl7.Fhir.Model.R4.FhirDecimal(value);
                    OnPropertyChanged("Factor");
                }
            }
            
            /// <summary>
            /// Net additional item cost
            /// </summary>
            [FhirElement("net", Order=130)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Net
            {
                get { return _Net; }
                set { _Net = value; OnPropertyChanged("Net"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Net;
            
            /// <summary>
            /// Unique Device Identifier
            /// </summary>
            [FhirElement("udi", Order=140)]
            [CLSCompliant(false)]
            [References("Device")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Udi
            {
                get { if(_Udi==null) _Udi = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Udi; }
                set { _Udi = value; OnPropertyChanged("Udi"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Udi;
            
            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> NoteNumberElement
            {
                get { if(_NoteNumberElement==null) _NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _NoteNumberElement; }
                set { _NoteNumberElement = value; OnPropertyChanged("NoteNumberElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _NoteNumberElement;
            
            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> NoteNumber
            {
                get { return NoteNumberElement != null ? NoteNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberElement = null;
                    else
                        NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
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
                get { if(_Adjudication==null) _Adjudication = new List<AdjudicationComponent>(); return _Adjudication; }
                set { _Adjudication = value; OnPropertyChanged("Adjudication"); }
            }
            
            private List<AdjudicationComponent> _Adjudication;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubDetailComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.R4.PositiveInt)SequenceElement.DeepCopy();
                    if(Revenue != null) dest.Revenue = (Hl7.Fhir.Model.R4.CodeableConcept)Revenue.DeepCopy();
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.R4.CodeableConcept)Category.DeepCopy();
                    if(Service != null) dest.Service = (Hl7.Fhir.Model.R4.CodeableConcept)Service.DeepCopy();
                    if(Modifier != null) dest.Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Modifier.DeepCopy());
                    if(ProgramCode != null) dest.ProgramCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(ProgramCode.DeepCopy());
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.R4.SimpleQuantity)Quantity.DeepCopy();
                    if(UnitPrice != null) dest.UnitPrice = (Hl7.Fhir.Model.R4.Money)UnitPrice.DeepCopy();
                    if(FactorElement != null) dest.FactorElement = (Hl7.Fhir.Model.R4.FhirDecimal)FactorElement.DeepCopy();
                    if(Net != null) dest.Net = (Hl7.Fhir.Model.R4.Money)Net.DeepCopy();
                    if(Udi != null) dest.Udi = new List<Hl7.Fhir.Model.R4.ResourceReference>(Udi.DeepCopy());
                    if(NoteNumberElement != null) dest.NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(NoteNumberElement.DeepCopy());
                    if(Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.Matches(Revenue, otherT.Revenue)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(Service, otherT.Service)) return false;
                if( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.Matches(ProgramCode, otherT.ProgramCode)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.Matches(Net, otherT.Net)) return false;
                if( !DeepComparable.Matches(Udi, otherT.Udi)) return false;
                if( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubDetailComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
                if( !DeepComparable.IsExactly(Revenue, otherT.Revenue)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if( !DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.IsExactly(ProgramCode, otherT.ProgramCode)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(UnitPrice, otherT.UnitPrice)) return false;
                if( !DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
                if( !DeepComparable.IsExactly(Net, otherT.Net)) return false;
                if( !DeepComparable.IsExactly(Udi, otherT.Udi)) return false;
                if( !DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if( !DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "AddedItemComponent")]
        [DataContract]
        public partial class AddedItemComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AddedItemComponent"; } }
            
            /// <summary>
            /// Service instances
            /// </summary>
            [FhirElement("itemSequence", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> ItemSequenceElement
            {
                get { if(_ItemSequenceElement==null) _ItemSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _ItemSequenceElement; }
                set { _ItemSequenceElement = value; OnPropertyChanged("ItemSequenceElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _ItemSequenceElement;
            
            /// <summary>
            /// Service instances
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> ItemSequence
            {
                get { return ItemSequenceElement != null ? ItemSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ItemSequenceElement = null;
                    else
                        ItemSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
                    OnPropertyChanged("ItemSequence");
                }
            }
            
            /// <summary>
            /// Detail sequence number
            /// </summary>
            [FhirElement("detailSequence", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> DetailSequenceElement
            {
                get { if(_DetailSequenceElement==null) _DetailSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _DetailSequenceElement; }
                set { _DetailSequenceElement = value; OnPropertyChanged("DetailSequenceElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _DetailSequenceElement;
            
            /// <summary>
            /// Detail sequence number
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> DetailSequence
            {
                get { return DetailSequenceElement != null ? DetailSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        DetailSequenceElement = null;
                    else
                        DetailSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
                    OnPropertyChanged("DetailSequence");
                }
            }
            
            /// <summary>
            /// Subdetail sequence number
            /// </summary>
            [FhirElement("subDetailSequence", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> SubDetailSequenceElement
            {
                get { if(_SubDetailSequenceElement==null) _SubDetailSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _SubDetailSequenceElement; }
                set { _SubDetailSequenceElement = value; OnPropertyChanged("SubDetailSequenceElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _SubDetailSequenceElement;
            
            /// <summary>
            /// Subdetail sequence number
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> SubDetailSequence
            {
                get { return SubDetailSequenceElement != null ? SubDetailSequenceElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        SubDetailSequenceElement = null;
                    else
                        SubDetailSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
                    OnPropertyChanged("SubDetailSequence");
                }
            }
            
            /// <summary>
            /// Billing Code
            /// </summary>
            [FhirElement("service", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Service
            {
                get { return _Service; }
                set { _Service = value; OnPropertyChanged("Service"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Service;
            
            /// <summary>
            /// Service/Product billing modifiers
            /// </summary>
            [FhirElement("modifier", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Modifier
            {
                get { if(_Modifier==null) _Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Modifier; }
                set { _Modifier = value; OnPropertyChanged("Modifier"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Modifier;
            
            /// <summary>
            /// Professional fee or Product charge
            /// </summary>
            [FhirElement("fee", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Fee
            {
                get { return _Fee; }
                set { _Fee = value; OnPropertyChanged("Fee"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Fee;
            
            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            [FhirElement("noteNumber", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.PositiveInt> NoteNumberElement
            {
                get { if(_NoteNumberElement==null) _NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(); return _NoteNumberElement; }
                set { _NoteNumberElement = value; OnPropertyChanged("NoteNumberElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.PositiveInt> _NoteNumberElement;
            
            /// <summary>
            /// List of note numbers which apply
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<int?> NoteNumber
            {
                get { return NoteNumberElement != null ? NoteNumberElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        NoteNumberElement = null;
                    else
                        NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(value.Select(elem=>new Hl7.Fhir.Model.R4.PositiveInt(elem)));
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
                get { if(_Adjudication==null) _Adjudication = new List<AdjudicationComponent>(); return _Adjudication; }
                set { _Adjudication = value; OnPropertyChanged("Adjudication"); }
            }
            
            private List<AdjudicationComponent> _Adjudication;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AddedItemComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(ItemSequenceElement != null) dest.ItemSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(ItemSequenceElement.DeepCopy());
                    if(DetailSequenceElement != null) dest.DetailSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(DetailSequenceElement.DeepCopy());
                    if(SubDetailSequenceElement != null) dest.SubDetailSequenceElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(SubDetailSequenceElement.DeepCopy());
                    if(Service != null) dest.Service = (Hl7.Fhir.Model.R4.CodeableConcept)Service.DeepCopy();
                    if(Modifier != null) dest.Modifier = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Modifier.DeepCopy());
                    if(Fee != null) dest.Fee = (Hl7.Fhir.Model.R4.Money)Fee.DeepCopy();
                    if(NoteNumberElement != null) dest.NoteNumberElement = new List<Hl7.Fhir.Model.R4.PositiveInt>(NoteNumberElement.DeepCopy());
                    if(Adjudication != null) dest.Adjudication = new List<AdjudicationComponent>(Adjudication.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(ItemSequenceElement, otherT.ItemSequenceElement)) return false;
                if( !DeepComparable.Matches(DetailSequenceElement, otherT.DetailSequenceElement)) return false;
                if( !DeepComparable.Matches(SubDetailSequenceElement, otherT.SubDetailSequenceElement)) return false;
                if( !DeepComparable.Matches(Service, otherT.Service)) return false;
                if( !DeepComparable.Matches(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.Matches(Fee, otherT.Fee)) return false;
                if( !DeepComparable.Matches(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if( !DeepComparable.Matches(Adjudication, otherT.Adjudication)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AddedItemComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(ItemSequenceElement, otherT.ItemSequenceElement)) return false;
                if( !DeepComparable.IsExactly(DetailSequenceElement, otherT.DetailSequenceElement)) return false;
                if( !DeepComparable.IsExactly(SubDetailSequenceElement, otherT.SubDetailSequenceElement)) return false;
                if( !DeepComparable.IsExactly(Service, otherT.Service)) return false;
                if( !DeepComparable.IsExactly(Modifier, otherT.Modifier)) return false;
                if( !DeepComparable.IsExactly(Fee, otherT.Fee)) return false;
                if( !DeepComparable.IsExactly(NoteNumberElement, otherT.NoteNumberElement)) return false;
                if( !DeepComparable.IsExactly(Adjudication, otherT.Adjudication)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "TotalComponent")]
        [DataContract]
        public partial class TotalComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "TotalComponent"; } }
            
            /// <summary>
            /// Adjudication category such as submitted, co-pay, eligible, benefit, etc.
            /// </summary>
            [FhirElement("category", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Category;
            
            /// <summary>
            /// Monetary amount
            /// </summary>
            [FhirElement("amount", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Amount;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TotalComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.R4.CodeableConcept)Category.DeepCopy();
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.R4.Money)Amount.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TotalComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PaymentComponent")]
        [DataContract]
        public partial class PaymentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PaymentComponent"; } }
            
            /// <summary>
            /// Partial or Complete
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Payment adjustment for non-Claim issues
            /// </summary>
            [FhirElement("adjustment", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Adjustment
            {
                get { return _Adjustment; }
                set { _Adjustment = value; OnPropertyChanged("Adjustment"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Adjustment;
            
            /// <summary>
            /// Explanation for the non-claim adjustment
            /// </summary>
            [FhirElement("adjustmentReason", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept AdjustmentReason
            {
                get { return _AdjustmentReason; }
                set { _AdjustmentReason = value; OnPropertyChanged("AdjustmentReason"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _AdjustmentReason;
            
            /// <summary>
            /// Expected date of Payment
            /// </summary>
            [FhirElement("date", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Date DateElement
            {
                get { return _DateElement; }
                set { _DateElement = value; OnPropertyChanged("DateElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Date _DateElement;
            
            /// <summary>
            /// Expected date of Payment
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Date
            {
                get { return DateElement != null ? DateElement.Value : null; }
                set
                {
                    if (value == null)
                        DateElement = null;
                    else
                        DateElement = new Hl7.Fhir.Model.R4.Date(value);
                    OnPropertyChanged("Date");
                }
            }
            
            /// <summary>
            /// Payable amount after adjustment
            /// </summary>
            [FhirElement("amount", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Amount
            {
                get { return _Amount; }
                set { _Amount = value; OnPropertyChanged("Amount"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Amount;
            
            /// <summary>
            /// Identifier of the payment instrument
            /// </summary>
            [FhirElement("identifier", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Identifier;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PaymentComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Adjustment != null) dest.Adjustment = (Hl7.Fhir.Model.R4.Money)Adjustment.DeepCopy();
                    if(AdjustmentReason != null) dest.AdjustmentReason = (Hl7.Fhir.Model.R4.CodeableConcept)AdjustmentReason.DeepCopy();
                    if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.Date)DateElement.DeepCopy();
                    if(Amount != null) dest.Amount = (Hl7.Fhir.Model.R4.Money)Amount.DeepCopy();
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Adjustment, otherT.Adjustment)) return false;
                if( !DeepComparable.Matches(AdjustmentReason, otherT.AdjustmentReason)) return false;
                if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PaymentComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Adjustment, otherT.Adjustment)) return false;
                if( !DeepComparable.IsExactly(AdjustmentReason, otherT.AdjustmentReason)) return false;
                if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "NoteComponent")]
        [DataContract]
        public partial class NoteComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "NoteComponent"; } }
            
            /// <summary>
            /// Sequence number for this note
            /// </summary>
            [FhirElement("number", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt NumberElement
            {
                get { return _NumberElement; }
                set { _NumberElement = value; OnPropertyChanged("NumberElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _NumberElement;
            
            /// <summary>
            /// Sequence number for this note
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Number
            {
                get { return NumberElement != null ? NumberElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberElement = null;
                    else
                        NumberElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Number");
                }
            }
            
            /// <summary>
            /// display | print | printoper
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _TypeElement;
            
            /// <summary>
            /// display | print | printoper
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Note explanitory text
            /// </summary>
            [FhirElement("text", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TextElement
            {
                get { return _TextElement; }
                set { _TextElement = value; OnPropertyChanged("TextElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _TextElement;
            
            /// <summary>
            /// Note explanitory text
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Text");
                }
            }
            
            /// <summary>
            /// Language if different from the resource
            /// </summary>
            [FhirElement("language", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Language
            {
                get { return _Language; }
                set { _Language = value; OnPropertyChanged("Language"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Language;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as NoteComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NumberElement != null) dest.NumberElement = (Hl7.Fhir.Model.R4.PositiveInt)NumberElement.DeepCopy();
                    if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.R4.Code)TypeElement.DeepCopy();
                    if(TextElement != null) dest.TextElement = (Hl7.Fhir.Model.FhirString)TextElement.DeepCopy();
                    if(Language != null) dest.Language = (Hl7.Fhir.Model.R4.CodeableConcept)Language.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NumberElement, otherT.NumberElement)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if( !DeepComparable.Matches(Language, otherT.Language)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as NoteComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NumberElement, otherT.NumberElement)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if( !DeepComparable.IsExactly(Language, otherT.Language)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "BenefitBalanceComponent")]
        [DataContract]
        public partial class BenefitBalanceComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "BenefitBalanceComponent"; } }
            
            /// <summary>
            /// Type of services covered
            /// </summary>
            [FhirElement("category", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Category
            {
                get { return _Category; }
                set { _Category = value; OnPropertyChanged("Category"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Category;
            
            /// <summary>
            /// Detailed services covered within the type
            /// </summary>
            [FhirElement("subCategory", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept SubCategory
            {
                get { return _SubCategory; }
                set { _SubCategory = value; OnPropertyChanged("SubCategory"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _SubCategory;
            
            /// <summary>
            /// Excluded from the plan
            /// </summary>
            [FhirElement("excluded", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean ExcludedElement
            {
                get { return _ExcludedElement; }
                set { _ExcludedElement = value; OnPropertyChanged("ExcludedElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _ExcludedElement;
            
            /// <summary>
            /// Excluded from the plan
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Excluded
            {
                get { return ExcludedElement != null ? ExcludedElement.Value : null; }
                set
                {
                    if (value == null)
                        ExcludedElement = null;
                    else
                        ExcludedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Excluded");
                }
            }
            
            /// <summary>
            /// Short name for the benefit
            /// </summary>
            [FhirElement("name", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Short name for the benefit
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// Description of the benefit or services covered
            /// </summary>
            [FhirElement("description", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Description of the benefit or services covered
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        DescriptionElement = null;
                    else
                        DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// In or out of network
            /// </summary>
            [FhirElement("network", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Network
            {
                get { return _Network; }
                set { _Network = value; OnPropertyChanged("Network"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Network;
            
            /// <summary>
            /// Individual or family
            /// </summary>
            [FhirElement("unit", Order=100)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Unit
            {
                get { return _Unit; }
                set { _Unit = value; OnPropertyChanged("Unit"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Unit;
            
            /// <summary>
            /// Annual or lifetime
            /// </summary>
            [FhirElement("term", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Term
            {
                get { return _Term; }
                set { _Term = value; OnPropertyChanged("Term"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Term;
            
            /// <summary>
            /// Benefit Summary
            /// </summary>
            [FhirElement("financial", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<BenefitComponent> Financial
            {
                get { if(_Financial==null) _Financial = new List<BenefitComponent>(); return _Financial; }
                set { _Financial = value; OnPropertyChanged("Financial"); }
            }
            
            private List<BenefitComponent> _Financial;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BenefitBalanceComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Category != null) dest.Category = (Hl7.Fhir.Model.R4.CodeableConcept)Category.DeepCopy();
                    if(SubCategory != null) dest.SubCategory = (Hl7.Fhir.Model.R4.CodeableConcept)SubCategory.DeepCopy();
                    if(ExcludedElement != null) dest.ExcludedElement = (Hl7.Fhir.Model.FhirBoolean)ExcludedElement.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(Network != null) dest.Network = (Hl7.Fhir.Model.R4.CodeableConcept)Network.DeepCopy();
                    if(Unit != null) dest.Unit = (Hl7.Fhir.Model.R4.CodeableConcept)Unit.DeepCopy();
                    if(Term != null) dest.Term = (Hl7.Fhir.Model.R4.CodeableConcept)Term.DeepCopy();
                    if(Financial != null) dest.Financial = new List<BenefitComponent>(Financial.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Category, otherT.Category)) return false;
                if( !DeepComparable.Matches(SubCategory, otherT.SubCategory)) return false;
                if( !DeepComparable.Matches(ExcludedElement, otherT.ExcludedElement)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(Network, otherT.Network)) return false;
                if( !DeepComparable.Matches(Unit, otherT.Unit)) return false;
                if( !DeepComparable.Matches(Term, otherT.Term)) return false;
                if( !DeepComparable.Matches(Financial, otherT.Financial)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BenefitBalanceComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if( !DeepComparable.IsExactly(SubCategory, otherT.SubCategory)) return false;
                if( !DeepComparable.IsExactly(ExcludedElement, otherT.ExcludedElement)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(Network, otherT.Network)) return false;
                if( !DeepComparable.IsExactly(Unit, otherT.Unit)) return false;
                if( !DeepComparable.IsExactly(Term, otherT.Term)) return false;
                if( !DeepComparable.IsExactly(Financial, otherT.Financial)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "BenefitComponent")]
        [DataContract]
        public partial class BenefitComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "BenefitComponent"; } }
            
            /// <summary>
            /// Deductable, visits, benefit amount
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Benefits allowed
            /// </summary>
            [FhirElement("allowed", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.UnsignedInt),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.R4.Money))]
            [DataMember]
            public Hl7.Fhir.Model.Element Allowed
            {
                get { return _Allowed; }
                set { _Allowed = value; OnPropertyChanged("Allowed"); }
            }
            
            private Hl7.Fhir.Model.Element _Allowed;
            
            /// <summary>
            /// Benefits used
            /// </summary>
            [FhirElement("used", Order=60, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.UnsignedInt),typeof(Hl7.Fhir.Model.R4.Money))]
            [DataMember]
            public Hl7.Fhir.Model.Element Used
            {
                get { return _Used; }
                set { _Used = value; OnPropertyChanged("Used"); }
            }
            
            private Hl7.Fhir.Model.Element _Used;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as BenefitComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Allowed != null) dest.Allowed = (Hl7.Fhir.Model.Element)Allowed.DeepCopy();
                    if(Used != null) dest.Used = (Hl7.Fhir.Model.Element)Used.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Allowed, otherT.Allowed)) return false;
                if( !DeepComparable.Matches(Used, otherT.Used)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as BenefitComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Allowed, otherT.Allowed)) return false;
                if( !DeepComparable.IsExactly(Used, otherT.Used)) return false;
            
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
        public List<Hl7.Fhir.Model.R4.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Identifier> _Identifier;
        
        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _StatusElement;
        
        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Type or discipline
        /// </summary>
        [FhirElement("type", Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Type;
        
        /// <summary>
        /// Finer grained claim type information
        /// </summary>
        [FhirElement("subType", Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> SubType
        {
            get { if(_SubType==null) _SubType = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _SubType; }
            set { _SubType = value; OnPropertyChanged("SubType"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _SubType;
        
        /// <summary>
        /// complete | proposed | exploratory | other
        /// </summary>
        [FhirElement("use", Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code UseElement
        {
            get { return _UseElement; }
            set { _UseElement = value; OnPropertyChanged("UseElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _UseElement;
        
        /// <summary>
        /// complete | proposed | exploratory | other
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if (value == null)
                    UseElement = null;
                else
                    UseElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Use");
            }
        }
        
        /// <summary>
        /// The subject of the Products and Services
        /// </summary>
        [FhirElement("patient", Order=140)]
        [CLSCompliant(false)]
        [References("Patient")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Patient;
        
        /// <summary>
        /// Period for charge submission
        /// </summary>
        [FhirElement("billablePeriod", Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Period BillablePeriod
        {
            get { return _BillablePeriod; }
            set { _BillablePeriod = value; OnPropertyChanged("BillablePeriod"); }
        }
        
        private Hl7.Fhir.Model.R4.Period _BillablePeriod;
        
        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime CreatedElement
        {
            get { return _CreatedElement; }
            set { _CreatedElement = value; OnPropertyChanged("CreatedElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _CreatedElement;
        
        /// <summary>
        /// Creation date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if (value == null)
                    CreatedElement = null;
                else
                    CreatedElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }
        
        /// <summary>
        /// Author
        /// </summary>
        [FhirElement("enterer", Order=170)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Enterer
        {
            get { return _Enterer; }
            set { _Enterer = value; OnPropertyChanged("Enterer"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Enterer;
        
        /// <summary>
        /// Insurer responsible for the EOB
        /// </summary>
        [FhirElement("insurer", Order=180)]
        [CLSCompliant(false)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Insurer
        {
            get { return _Insurer; }
            set { _Insurer = value; OnPropertyChanged("Insurer"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Insurer;
        
        /// <summary>
        /// Responsible provider for the claim
        /// </summary>
        [FhirElement("provider", Order=190)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Organization")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Provider
        {
            get { return _Provider; }
            set { _Provider = value; OnPropertyChanged("Provider"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Provider;
        
        /// <summary>
        /// Treatment Referral
        /// </summary>
        [FhirElement("referral", Order=200)]
        [CLSCompliant(false)]
        [References("ServiceRequest")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Referral
        {
            get { return _Referral; }
            set { _Referral = value; OnPropertyChanged("Referral"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Referral;
        
        /// <summary>
        /// Servicing Facility
        /// </summary>
        [FhirElement("facility", Order=210)]
        [CLSCompliant(false)]
        [References("Location")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Facility
        {
            get { return _Facility; }
            set { _Facility = value; OnPropertyChanged("Facility"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Facility;
        
        /// <summary>
        /// Claim reference
        /// </summary>
        [FhirElement("claim", Order=220)]
        [CLSCompliant(false)]
        [References("Claim")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Claim
        {
            get { return _Claim; }
            set { _Claim = value; OnPropertyChanged("Claim"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Claim;
        
        /// <summary>
        /// Claim response reference
        /// </summary>
        [FhirElement("claimResponse", Order=230)]
        [CLSCompliant(false)]
        [References("ClaimResponse")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference ClaimResponse
        {
            get { return _ClaimResponse; }
            set { _ClaimResponse = value; OnPropertyChanged("ClaimResponse"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _ClaimResponse;
        
        /// <summary>
        /// queued | complete | error | partial
        /// </summary>
        [FhirElement("outcome", Order=240)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code OutcomeElement
        {
            get { return _OutcomeElement; }
            set { _OutcomeElement = value; OnPropertyChanged("OutcomeElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _OutcomeElement;
        
        /// <summary>
        /// queued | complete | error | partial
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if (value == null)
                    OutcomeElement = null;
                else
                    OutcomeElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Outcome");
            }
        }
        
        /// <summary>
        /// Disposition Message
        /// </summary>
        [FhirElement("disposition", Order=250)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DispositionElement
        {
            get { return _DispositionElement; }
            set { _DispositionElement = value; OnPropertyChanged("DispositionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DispositionElement;
        
        /// <summary>
        /// Disposition Message
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Disposition
        {
            get { return DispositionElement != null ? DispositionElement.Value : null; }
            set
            {
                if (value == null)
                    DispositionElement = null;
                else
                    DispositionElement = new Hl7.Fhir.Model.FhirString(value);
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
            get { if(_Related==null) _Related = new List<RelatedClaimComponent>(); return _Related; }
            set { _Related = value; OnPropertyChanged("Related"); }
        }
        
        private List<RelatedClaimComponent> _Related;
        
        /// <summary>
        /// Prescription authorizing services or products
        /// </summary>
        [FhirElement("prescription", Order=270)]
        [CLSCompliant(false)]
        [References("MedicationRequest","VisionPrescription")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Prescription
        {
            get { return _Prescription; }
            set { _Prescription = value; OnPropertyChanged("Prescription"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Prescription;
        
        /// <summary>
        /// Original prescription if superceded by fulfiller
        /// </summary>
        [FhirElement("originalPrescription", Order=280)]
        [CLSCompliant(false)]
        [References("MedicationRequest")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference OriginalPrescription
        {
            get { return _OriginalPrescription; }
            set { _OriginalPrescription = value; OnPropertyChanged("OriginalPrescription"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _OriginalPrescription;
        
        /// <summary>
        /// Party to be paid any benefits payable
        /// </summary>
        [FhirElement("payee", Order=290)]
        [DataMember]
        public PayeeComponent Payee
        {
            get { return _Payee; }
            set { _Payee = value; OnPropertyChanged("Payee"); }
        }
        
        private PayeeComponent _Payee;
        
        /// <summary>
        /// Exceptions, special considerations, the condition, situation, prior or concurrent issues
        /// </summary>
        [FhirElement("information", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SupportingInformationComponent> Information
        {
            get { if(_Information==null) _Information = new List<SupportingInformationComponent>(); return _Information; }
            set { _Information = value; OnPropertyChanged("Information"); }
        }
        
        private List<SupportingInformationComponent> _Information;
        
        /// <summary>
        /// Care Team members
        /// </summary>
        [FhirElement("careTeam", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CareTeamComponent> CareTeam
        {
            get { if(_CareTeam==null) _CareTeam = new List<CareTeamComponent>(); return _CareTeam; }
            set { _CareTeam = value; OnPropertyChanged("CareTeam"); }
        }
        
        private List<CareTeamComponent> _CareTeam;
        
        /// <summary>
        /// List of Diagnosis
        /// </summary>
        [FhirElement("diagnosis", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DiagnosisComponent> Diagnosis
        {
            get { if(_Diagnosis==null) _Diagnosis = new List<DiagnosisComponent>(); return _Diagnosis; }
            set { _Diagnosis = value; OnPropertyChanged("Diagnosis"); }
        }
        
        private List<DiagnosisComponent> _Diagnosis;
        
        /// <summary>
        /// Procedures performed
        /// </summary>
        [FhirElement("procedure", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ProcedureComponent> Procedure
        {
            get { if(_Procedure==null) _Procedure = new List<ProcedureComponent>(); return _Procedure; }
            set { _Procedure = value; OnPropertyChanged("Procedure"); }
        }
        
        private List<ProcedureComponent> _Procedure;
        
        /// <summary>
        /// Precedence (primary, secondary, etc.)
        /// </summary>
        [FhirElement("precedence", Order=340)]
        [DataMember]
        public Hl7.Fhir.Model.R4.PositiveInt PrecedenceElement
        {
            get { return _PrecedenceElement; }
            set { _PrecedenceElement = value; OnPropertyChanged("PrecedenceElement"); }
        }
        
        private Hl7.Fhir.Model.R4.PositiveInt _PrecedenceElement;
        
        /// <summary>
        /// Precedence (primary, secondary, etc.)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? Precedence
        {
            get { return PrecedenceElement != null ? PrecedenceElement.Value : null; }
            set
            {
                if (value == null)
                    PrecedenceElement = null;
                else
                    PrecedenceElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
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
            get { return _Insurance; }
            set { _Insurance = value; OnPropertyChanged("Insurance"); }
        }
        
        private InsuranceComponent _Insurance;
        
        /// <summary>
        /// Details of an accident
        /// </summary>
        [FhirElement("accident", Order=360)]
        [DataMember]
        public AccidentComponent Accident
        {
            get { return _Accident; }
            set { _Accident = value; OnPropertyChanged("Accident"); }
        }
        
        private AccidentComponent _Accident;
        
        /// <summary>
        /// Goods and Services
        /// </summary>
        [FhirElement("item", Order=370)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ItemComponent> Item
        {
            get { if(_Item==null) _Item = new List<ItemComponent>(); return _Item; }
            set { _Item = value; OnPropertyChanged("Item"); }
        }
        
        private List<ItemComponent> _Item;
        
        /// <summary>
        /// Insurer added line items
        /// </summary>
        [FhirElement("addItem", Order=380)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AddedItemComponent> AddItem
        {
            get { if(_AddItem==null) _AddItem = new List<AddedItemComponent>(); return _AddItem; }
            set { _AddItem = value; OnPropertyChanged("AddItem"); }
        }
        
        private List<AddedItemComponent> _AddItem;
        
        /// <summary>
        /// Adjudication totals
        /// </summary>
        [FhirElement("total", Order=390)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TotalComponent> Total
        {
            get { if(_Total==null) _Total = new List<TotalComponent>(); return _Total; }
            set { _Total = value; OnPropertyChanged("Total"); }
        }
        
        private List<TotalComponent> _Total;
        
        /// <summary>
        /// Payment (if paid)
        /// </summary>
        [FhirElement("payment", Order=400)]
        [DataMember]
        public PaymentComponent Payment
        {
            get { return _Payment; }
            set { _Payment = value; OnPropertyChanged("Payment"); }
        }
        
        private PaymentComponent _Payment;
        
        /// <summary>
        /// Printed Form Identifier
        /// </summary>
        [FhirElement("form", Order=410)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Form
        {
            get { return _Form; }
            set { _Form = value; OnPropertyChanged("Form"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Form;
        
        /// <summary>
        /// Processing notes
        /// </summary>
        [FhirElement("processNote", Order=420)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<NoteComponent> ProcessNote
        {
            get { if(_ProcessNote==null) _ProcessNote = new List<NoteComponent>(); return _ProcessNote; }
            set { _ProcessNote = value; OnPropertyChanged("ProcessNote"); }
        }
        
        private List<NoteComponent> _ProcessNote;
        
        /// <summary>
        /// Balance by Benefit Category
        /// </summary>
        [FhirElement("benefitBalance", Order=430)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<BenefitBalanceComponent> BenefitBalance
        {
            get { if(_BenefitBalance==null) _BenefitBalance = new List<BenefitBalanceComponent>(); return _BenefitBalance; }
            set { _BenefitBalance = value; OnPropertyChanged("BenefitBalance"); }
        }
        
        private List<BenefitBalanceComponent> _BenefitBalance;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ExplanationOfBenefit;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                if(SubType != null) dest.SubType = new List<Hl7.Fhir.Model.R4.CodeableConcept>(SubType.DeepCopy());
                if(UseElement != null) dest.UseElement = (Hl7.Fhir.Model.R4.Code)UseElement.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.R4.ResourceReference)Patient.DeepCopy();
                if(BillablePeriod != null) dest.BillablePeriod = (Hl7.Fhir.Model.R4.Period)BillablePeriod.DeepCopy();
                if(CreatedElement != null) dest.CreatedElement = (Hl7.Fhir.Model.R4.FhirDateTime)CreatedElement.DeepCopy();
                if(Enterer != null) dest.Enterer = (Hl7.Fhir.Model.R4.ResourceReference)Enterer.DeepCopy();
                if(Insurer != null) dest.Insurer = (Hl7.Fhir.Model.R4.ResourceReference)Insurer.DeepCopy();
                if(Provider != null) dest.Provider = (Hl7.Fhir.Model.R4.ResourceReference)Provider.DeepCopy();
                if(Referral != null) dest.Referral = (Hl7.Fhir.Model.R4.ResourceReference)Referral.DeepCopy();
                if(Facility != null) dest.Facility = (Hl7.Fhir.Model.R4.ResourceReference)Facility.DeepCopy();
                if(Claim != null) dest.Claim = (Hl7.Fhir.Model.R4.ResourceReference)Claim.DeepCopy();
                if(ClaimResponse != null) dest.ClaimResponse = (Hl7.Fhir.Model.R4.ResourceReference)ClaimResponse.DeepCopy();
                if(OutcomeElement != null) dest.OutcomeElement = (Hl7.Fhir.Model.R4.Code)OutcomeElement.DeepCopy();
                if(DispositionElement != null) dest.DispositionElement = (Hl7.Fhir.Model.FhirString)DispositionElement.DeepCopy();
                if(Related != null) dest.Related = new List<RelatedClaimComponent>(Related.DeepCopy());
                if(Prescription != null) dest.Prescription = (Hl7.Fhir.Model.R4.ResourceReference)Prescription.DeepCopy();
                if(OriginalPrescription != null) dest.OriginalPrescription = (Hl7.Fhir.Model.R4.ResourceReference)OriginalPrescription.DeepCopy();
                if(Payee != null) dest.Payee = (PayeeComponent)Payee.DeepCopy();
                if(Information != null) dest.Information = new List<SupportingInformationComponent>(Information.DeepCopy());
                if(CareTeam != null) dest.CareTeam = new List<CareTeamComponent>(CareTeam.DeepCopy());
                if(Diagnosis != null) dest.Diagnosis = new List<DiagnosisComponent>(Diagnosis.DeepCopy());
                if(Procedure != null) dest.Procedure = new List<ProcedureComponent>(Procedure.DeepCopy());
                if(PrecedenceElement != null) dest.PrecedenceElement = (Hl7.Fhir.Model.R4.PositiveInt)PrecedenceElement.DeepCopy();
                if(Insurance != null) dest.Insurance = (InsuranceComponent)Insurance.DeepCopy();
                if(Accident != null) dest.Accident = (AccidentComponent)Accident.DeepCopy();
                if(Item != null) dest.Item = new List<ItemComponent>(Item.DeepCopy());
                if(AddItem != null) dest.AddItem = new List<AddedItemComponent>(AddItem.DeepCopy());
                if(Total != null) dest.Total = new List<TotalComponent>(Total.DeepCopy());
                if(Payment != null) dest.Payment = (PaymentComponent)Payment.DeepCopy();
                if(Form != null) dest.Form = (Hl7.Fhir.Model.R4.CodeableConcept)Form.DeepCopy();
                if(ProcessNote != null) dest.ProcessNote = new List<NoteComponent>(ProcessNote.DeepCopy());
                if(BenefitBalance != null) dest.BenefitBalance = new List<BenefitBalanceComponent>(BenefitBalance.DeepCopy());
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(SubType, otherT.SubType)) return false;
            if( !DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(BillablePeriod, otherT.BillablePeriod)) return false;
            if( !DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.Matches(Enterer, otherT.Enterer)) return false;
            if( !DeepComparable.Matches(Insurer, otherT.Insurer)) return false;
            if( !DeepComparable.Matches(Provider, otherT.Provider)) return false;
            if( !DeepComparable.Matches(Referral, otherT.Referral)) return false;
            if( !DeepComparable.Matches(Facility, otherT.Facility)) return false;
            if( !DeepComparable.Matches(Claim, otherT.Claim)) return false;
            if( !DeepComparable.Matches(ClaimResponse, otherT.ClaimResponse)) return false;
            if( !DeepComparable.Matches(OutcomeElement, otherT.OutcomeElement)) return false;
            if( !DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if( !DeepComparable.Matches(Related, otherT.Related)) return false;
            if( !DeepComparable.Matches(Prescription, otherT.Prescription)) return false;
            if( !DeepComparable.Matches(OriginalPrescription, otherT.OriginalPrescription)) return false;
            if( !DeepComparable.Matches(Payee, otherT.Payee)) return false;
            if( !DeepComparable.Matches(Information, otherT.Information)) return false;
            if( !DeepComparable.Matches(CareTeam, otherT.CareTeam)) return false;
            if( !DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
            if( !DeepComparable.Matches(Procedure, otherT.Procedure)) return false;
            if( !DeepComparable.Matches(PrecedenceElement, otherT.PrecedenceElement)) return false;
            if( !DeepComparable.Matches(Insurance, otherT.Insurance)) return false;
            if( !DeepComparable.Matches(Accident, otherT.Accident)) return false;
            if( !DeepComparable.Matches(Item, otherT.Item)) return false;
            if( !DeepComparable.Matches(AddItem, otherT.AddItem)) return false;
            if( !DeepComparable.Matches(Total, otherT.Total)) return false;
            if( !DeepComparable.Matches(Payment, otherT.Payment)) return false;
            if( !DeepComparable.Matches(Form, otherT.Form)) return false;
            if( !DeepComparable.Matches(ProcessNote, otherT.ProcessNote)) return false;
            if( !DeepComparable.Matches(BenefitBalance, otherT.BenefitBalance)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ExplanationOfBenefit;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(SubType, otherT.SubType)) return false;
            if( !DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(BillablePeriod, otherT.BillablePeriod)) return false;
            if( !DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.IsExactly(Enterer, otherT.Enterer)) return false;
            if( !DeepComparable.IsExactly(Insurer, otherT.Insurer)) return false;
            if( !DeepComparable.IsExactly(Provider, otherT.Provider)) return false;
            if( !DeepComparable.IsExactly(Referral, otherT.Referral)) return false;
            if( !DeepComparable.IsExactly(Facility, otherT.Facility)) return false;
            if( !DeepComparable.IsExactly(Claim, otherT.Claim)) return false;
            if( !DeepComparable.IsExactly(ClaimResponse, otherT.ClaimResponse)) return false;
            if( !DeepComparable.IsExactly(OutcomeElement, otherT.OutcomeElement)) return false;
            if( !DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if( !DeepComparable.IsExactly(Related, otherT.Related)) return false;
            if( !DeepComparable.IsExactly(Prescription, otherT.Prescription)) return false;
            if( !DeepComparable.IsExactly(OriginalPrescription, otherT.OriginalPrescription)) return false;
            if( !DeepComparable.IsExactly(Payee, otherT.Payee)) return false;
            if( !DeepComparable.IsExactly(Information, otherT.Information)) return false;
            if( !DeepComparable.IsExactly(CareTeam, otherT.CareTeam)) return false;
            if( !DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
            if( !DeepComparable.IsExactly(Procedure, otherT.Procedure)) return false;
            if( !DeepComparable.IsExactly(PrecedenceElement, otherT.PrecedenceElement)) return false;
            if( !DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;
            if( !DeepComparable.IsExactly(Accident, otherT.Accident)) return false;
            if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
            if( !DeepComparable.IsExactly(AddItem, otherT.AddItem)) return false;
            if( !DeepComparable.IsExactly(Total, otherT.Total)) return false;
            if( !DeepComparable.IsExactly(Payment, otherT.Payment)) return false;
            if( !DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if( !DeepComparable.IsExactly(ProcessNote, otherT.ProcessNote)) return false;
            if( !DeepComparable.IsExactly(BenefitBalance, otherT.BenefitBalance)) return false;
        
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
