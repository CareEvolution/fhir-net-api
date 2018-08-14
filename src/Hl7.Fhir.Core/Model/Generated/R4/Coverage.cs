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
    /// Insurance or medical plan or a payment agreement
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "Coverage", IsResource=true)]
    [DataContract]
    public partial class Coverage : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Coverage; } }
        [NotMapped]
        public override string TypeName { get { return "Coverage"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ClassComponent")]
        [DataContract]
        public partial class ClassComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ClassComponent"; } }
            
            /// <summary>
            /// Type of class such as 'group' or 'plan'
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.Coding _Type;
            
            /// <summary>
            /// The tag or value under the classification
            /// </summary>
            [FhirElement("value", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString ValueElement
            {
                get { return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _ValueElement;
            
            /// <summary>
            /// The tag or value under the classification
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Value");
                }
            }
            
            /// <summary>
            /// Display text for an identifier for the group
            /// </summary>
            [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Display text for an identifier for the group
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
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClassComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.Coding)Type.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ClassComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ClassComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClassComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (ValueElement != null) yield return ValueElement;
                    if (NameElement != null) yield return NameElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (ValueElement != null) yield return new ElementValue("value", false, ValueElement);
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "CoPayComponent")]
        [DataContract]
        public partial class CoPayComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "CoPayComponent"; } }
            
            /// <summary>
            /// The type of service or product
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Coding Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.Coding _Type;
            
            /// <summary>
            /// The amount or percentage of the copayment
            /// </summary>
            [FhirElement("value", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Quantity Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.R4.Quantity _Value;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CoPayComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.Coding)Type.DeepCopy();
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.R4.Quantity)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CoPayComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CoPayComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CoPayComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Value != null) yield return Value;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Value != null) yield return new ElementValue("value", false, Value);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// The primary coverage ID
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
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
        /// Type of coverage such as medical or accident
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Type;
        
        /// <summary>
        /// Owner of the policy
        /// </summary>
        [FhirElement("policyHolder", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [References("Patient","RelatedPerson","Organization")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference PolicyHolder
        {
            get { return _PolicyHolder; }
            set { _PolicyHolder = value; OnPropertyChanged("PolicyHolder"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _PolicyHolder;
        
        /// <summary>
        /// Subscriber to the policy
        /// </summary>
        [FhirElement("subscriber", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [References("Patient","RelatedPerson")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Subscriber
        {
            get { return _Subscriber; }
            set { _Subscriber = value; OnPropertyChanged("Subscriber"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Subscriber;
        
        /// <summary>
        /// ID assigned to the Subscriber
        /// </summary>
        [FhirElement("subscriberId", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString SubscriberIdElement
        {
            get { return _SubscriberIdElement; }
            set { _SubscriberIdElement = value; OnPropertyChanged("SubscriberIdElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _SubscriberIdElement;
        
        /// <summary>
        /// ID assigned to the Subscriber
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string SubscriberId
        {
            get { return SubscriberIdElement != null ? SubscriberIdElement.Value : null; }
            set
            {
                if (value == null)
                    SubscriberIdElement = null;
                else
                    SubscriberIdElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("SubscriberId");
            }
        }
        
        /// <summary>
        /// Plan Beneficiary
        /// </summary>
        [FhirElement("beneficiary", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [References("Patient")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Beneficiary
        {
            get { return _Beneficiary; }
            set { _Beneficiary = value; OnPropertyChanged("Beneficiary"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Beneficiary;
        
        /// <summary>
        /// Dependent number
        /// </summary>
        [FhirElement("dependent", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DependentElement
        {
            get { return _DependentElement; }
            set { _DependentElement = value; OnPropertyChanged("DependentElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DependentElement;
        
        /// <summary>
        /// Dependent number
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Dependent
        {
            get { return DependentElement != null ? DependentElement.Value : null; }
            set
            {
                if (value == null)
                    DependentElement = null;
                else
                    DependentElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Dependent");
            }
        }
        
        /// <summary>
        /// Beneficiary relationship to the Subscriber
        /// </summary>
        [FhirElement("relationship", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Relationship
        {
            get { return _Relationship; }
            set { _Relationship = value; OnPropertyChanged("Relationship"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Relationship;
        
        /// <summary>
        /// Coverage start and end dates
        /// </summary>
        [FhirElement("period", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Period Period
        {
            get { return _Period; }
            set { _Period = value; OnPropertyChanged("Period"); }
        }
        
        private Hl7.Fhir.Model.R4.Period _Period;
        
        /// <summary>
        /// Identifier for the plan or agreement issuer
        /// </summary>
        [FhirElement("payor", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [References("Organization","Patient","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Payor
        {
            get { if(_Payor==null) _Payor = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Payor; }
            set { _Payor = value; OnPropertyChanged("Payor"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Payor;
        
        /// <summary>
        /// Additional coverage classifications
        /// </summary>
        [FhirElement("class", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ClassComponent> Class
        {
            get { if(_Class==null) _Class = new List<ClassComponent>(); return _Class; }
            set { _Class = value; OnPropertyChanged("Class"); }
        }
        
        private List<ClassComponent> _Class;
        
        /// <summary>
        /// Relative order of the coverage
        /// </summary>
        [FhirElement("order", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.PositiveInt OrderElement
        {
            get { return _OrderElement; }
            set { _OrderElement = value; OnPropertyChanged("OrderElement"); }
        }
        
        private Hl7.Fhir.Model.R4.PositiveInt _OrderElement;
        
        /// <summary>
        /// Relative order of the coverage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? Order
        {
            get { return OrderElement != null ? OrderElement.Value : null; }
            set
            {
                if (value == null)
                    OrderElement = null;
                else
                    OrderElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                OnPropertyChanged("Order");
            }
        }
        
        /// <summary>
        /// Insurer network
        /// </summary>
        [FhirElement("network", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NetworkElement
        {
            get { return _NetworkElement; }
            set { _NetworkElement = value; OnPropertyChanged("NetworkElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NetworkElement;
        
        /// <summary>
        /// Insurer network
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Network
        {
            get { return NetworkElement != null ? NetworkElement.Value : null; }
            set
            {
                if (value == null)
                    NetworkElement = null;
                else
                    NetworkElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Network");
            }
        }
        
        /// <summary>
        /// Patient payments for services/products
        /// </summary>
        [FhirElement("copay", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CoPayComponent> Copay
        {
            get { if(_Copay==null) _Copay = new List<CoPayComponent>(); return _Copay; }
            set { _Copay = value; OnPropertyChanged("Copay"); }
        }
        
        private List<CoPayComponent> _Copay;
        
        /// <summary>
        /// Contract details
        /// </summary>
        [FhirElement("contract", Order=240)]
        [CLSCompliant(false)]
        [References("Contract")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Contract
        {
            get { if(_Contract==null) _Contract = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Contract; }
            set { _Contract = value; OnPropertyChanged("Contract"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Contract;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Coverage;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                if(PolicyHolder != null) dest.PolicyHolder = (Hl7.Fhir.Model.R4.ResourceReference)PolicyHolder.DeepCopy();
                if(Subscriber != null) dest.Subscriber = (Hl7.Fhir.Model.R4.ResourceReference)Subscriber.DeepCopy();
                if(SubscriberIdElement != null) dest.SubscriberIdElement = (Hl7.Fhir.Model.FhirString)SubscriberIdElement.DeepCopy();
                if(Beneficiary != null) dest.Beneficiary = (Hl7.Fhir.Model.R4.ResourceReference)Beneficiary.DeepCopy();
                if(DependentElement != null) dest.DependentElement = (Hl7.Fhir.Model.FhirString)DependentElement.DeepCopy();
                if(Relationship != null) dest.Relationship = (Hl7.Fhir.Model.R4.CodeableConcept)Relationship.DeepCopy();
                if(Period != null) dest.Period = (Hl7.Fhir.Model.R4.Period)Period.DeepCopy();
                if(Payor != null) dest.Payor = new List<Hl7.Fhir.Model.R4.ResourceReference>(Payor.DeepCopy());
                if(Class != null) dest.Class = new List<ClassComponent>(Class.DeepCopy());
                if(OrderElement != null) dest.OrderElement = (Hl7.Fhir.Model.R4.PositiveInt)OrderElement.DeepCopy();
                if(NetworkElement != null) dest.NetworkElement = (Hl7.Fhir.Model.FhirString)NetworkElement.DeepCopy();
                if(Copay != null) dest.Copay = new List<CoPayComponent>(Copay.DeepCopy());
                if(Contract != null) dest.Contract = new List<Hl7.Fhir.Model.R4.ResourceReference>(Contract.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Coverage());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Coverage;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(PolicyHolder, otherT.PolicyHolder)) return false;
            if( !DeepComparable.Matches(Subscriber, otherT.Subscriber)) return false;
            if( !DeepComparable.Matches(SubscriberIdElement, otherT.SubscriberIdElement)) return false;
            if( !DeepComparable.Matches(Beneficiary, otherT.Beneficiary)) return false;
            if( !DeepComparable.Matches(DependentElement, otherT.DependentElement)) return false;
            if( !DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
            if( !DeepComparable.Matches(Period, otherT.Period)) return false;
            if( !DeepComparable.Matches(Payor, otherT.Payor)) return false;
            if( !DeepComparable.Matches(Class, otherT.Class)) return false;
            if( !DeepComparable.Matches(OrderElement, otherT.OrderElement)) return false;
            if( !DeepComparable.Matches(NetworkElement, otherT.NetworkElement)) return false;
            if( !DeepComparable.Matches(Copay, otherT.Copay)) return false;
            if( !DeepComparable.Matches(Contract, otherT.Contract)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Coverage;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(PolicyHolder, otherT.PolicyHolder)) return false;
            if( !DeepComparable.IsExactly(Subscriber, otherT.Subscriber)) return false;
            if( !DeepComparable.IsExactly(SubscriberIdElement, otherT.SubscriberIdElement)) return false;
            if( !DeepComparable.IsExactly(Beneficiary, otherT.Beneficiary)) return false;
            if( !DeepComparable.IsExactly(DependentElement, otherT.DependentElement)) return false;
            if( !DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
            if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if( !DeepComparable.IsExactly(Payor, otherT.Payor)) return false;
            if( !DeepComparable.IsExactly(Class, otherT.Class)) return false;
            if( !DeepComparable.IsExactly(OrderElement, otherT.OrderElement)) return false;
            if( !DeepComparable.IsExactly(NetworkElement, otherT.NetworkElement)) return false;
            if( !DeepComparable.IsExactly(Copay, otherT.Copay)) return false;
            if( !DeepComparable.IsExactly(Contract, otherT.Contract)) return false;
        
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
                if (PolicyHolder != null) yield return PolicyHolder;
                if (Subscriber != null) yield return Subscriber;
                if (SubscriberIdElement != null) yield return SubscriberIdElement;
                if (Beneficiary != null) yield return Beneficiary;
                if (DependentElement != null) yield return DependentElement;
                if (Relationship != null) yield return Relationship;
                if (Period != null) yield return Period;
                foreach (var elem in Payor) { if (elem != null) yield return elem; }
                foreach (var elem in Class) { if (elem != null) yield return elem; }
                if (OrderElement != null) yield return OrderElement;
                if (NetworkElement != null) yield return NetworkElement;
                foreach (var elem in Copay) { if (elem != null) yield return elem; }
                foreach (var elem in Contract) { if (elem != null) yield return elem; }
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
                if (PolicyHolder != null) yield return new ElementValue("policyHolder", false, PolicyHolder);
                if (Subscriber != null) yield return new ElementValue("subscriber", false, Subscriber);
                if (SubscriberIdElement != null) yield return new ElementValue("subscriberId", false, SubscriberIdElement);
                if (Beneficiary != null) yield return new ElementValue("beneficiary", false, Beneficiary);
                if (DependentElement != null) yield return new ElementValue("dependent", false, DependentElement);
                if (Relationship != null) yield return new ElementValue("relationship", false, Relationship);
                if (Period != null) yield return new ElementValue("period", false, Period);
                foreach (var elem in Payor) { if (elem != null) yield return new ElementValue("payor", true, elem); }
                foreach (var elem in Class) { if (elem != null) yield return new ElementValue("class", true, elem); }
                if (OrderElement != null) yield return new ElementValue("order", false, OrderElement);
                if (NetworkElement != null) yield return new ElementValue("network", false, NetworkElement);
                foreach (var elem in Copay) { if (elem != null) yield return new ElementValue("copay", true, elem); }
                foreach (var elem in Contract) { if (elem != null) yield return new ElementValue("contract", true, elem); }
            }
        }
    
    }

}
