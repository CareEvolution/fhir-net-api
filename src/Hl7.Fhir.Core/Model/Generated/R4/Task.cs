using System;
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
    /// A task to be performed
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "Task", IsResource=true)]
    [DataContract]
    public partial class Task : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Task; } }
        [NotMapped]
        public override string TypeName { get { return "Task"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "RestrictionComponent")]
        [DataContract]
        public partial class RestrictionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RestrictionComponent"; } }
            
            /// <summary>
            /// How many times to repeat
            /// </summary>
            [FhirElement("repetitions", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.PositiveInt RepetitionsElement
            {
                get { return _RepetitionsElement; }
                set { _RepetitionsElement = value; OnPropertyChanged("RepetitionsElement"); }
            }
            
            private Hl7.Fhir.Model.R4.PositiveInt _RepetitionsElement;
            
            /// <summary>
            /// How many times to repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Repetitions
            {
                get { return RepetitionsElement != null ? RepetitionsElement.Value : null; }
                set
                {
                    if (value == null)
                        RepetitionsElement = null;
                    else
                        RepetitionsElement = new Hl7.Fhir.Model.R4.PositiveInt(value);
                    OnPropertyChanged("Repetitions");
                }
            }
            
            /// <summary>
            /// When fulfillment sought
            /// </summary>
            [FhirElement("period", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Period Period
            {
                get { return _Period; }
                set { _Period = value; OnPropertyChanged("Period"); }
            }
            
            private Hl7.Fhir.Model.R4.Period _Period;
            
            /// <summary>
            /// For whom is fulfillment sought?
            /// </summary>
            [FhirElement("recipient", Order=60)]
            [CLSCompliant(false)]
            [References("Patient","Practitioner","RelatedPerson","Group","Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Recipient
            {
                get { if(_Recipient==null) _Recipient = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Recipient; }
                set { _Recipient = value; OnPropertyChanged("Recipient"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Recipient;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RestrictionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(RepetitionsElement != null) dest.RepetitionsElement = (Hl7.Fhir.Model.R4.PositiveInt)RepetitionsElement.DeepCopy();
                    if(Period != null) dest.Period = (Hl7.Fhir.Model.R4.Period)Period.DeepCopy();
                    if(Recipient != null) dest.Recipient = new List<Hl7.Fhir.Model.R4.ResourceReference>(Recipient.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RestrictionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RestrictionComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(RepetitionsElement, otherT.RepetitionsElement)) return false;
                if( !DeepComparable.Matches(Period, otherT.Period)) return false;
                if( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RestrictionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(RepetitionsElement, otherT.RepetitionsElement)) return false;
                if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if( !DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RepetitionsElement != null) yield return RepetitionsElement;
                    if (Period != null) yield return Period;
                    foreach (var elem in Recipient) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RepetitionsElement != null) yield return new ElementValue("repetitions", false, RepetitionsElement);
                    if (Period != null) yield return new ElementValue("period", false, Period);
                    foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }
            
            /// <summary>
            /// Label for the input
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
            /// Content to use in performing the task
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Base64Binary),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.canonical),typeof(Hl7.Fhir.Model.R4.Code),typeof(Hl7.Fhir.Model.R4.Date),typeof(Hl7.Fhir.Model.R4.FhirDateTime),typeof(Hl7.Fhir.Model.R4.FhirDecimal),typeof(Hl7.Fhir.Model.R4.Id),typeof(Hl7.Fhir.Model.Instant),typeof(Hl7.Fhir.Model.R4.Integer),typeof(Hl7.Fhir.Model.Markdown),typeof(Hl7.Fhir.Model.R4.Oid),typeof(Hl7.Fhir.Model.R4.PositiveInt),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.R4.Time),typeof(Hl7.Fhir.Model.R4.UnsignedInt),typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.url),typeof(Hl7.Fhir.Model.uuid),typeof(Hl7.Fhir.Model.R4.Address),typeof(Hl7.Fhir.Model.R4.Age),typeof(Hl7.Fhir.Model.R4.Annotation),typeof(Hl7.Fhir.Model.R4.Attachment),typeof(Hl7.Fhir.Model.R4.CodeableConcept),typeof(Hl7.Fhir.Model.R4.Coding),typeof(Hl7.Fhir.Model.R4.ContactPoint),typeof(Hl7.Fhir.Model.R4.Count),typeof(Hl7.Fhir.Model.R4.Distance),typeof(Hl7.Fhir.Model.R4.Duration),typeof(Hl7.Fhir.Model.R4.HumanName),typeof(Hl7.Fhir.Model.R4.Identifier),typeof(Hl7.Fhir.Model.R4.Money),typeof(Hl7.Fhir.Model.R4.Period),typeof(Hl7.Fhir.Model.R4.Quantity),typeof(Hl7.Fhir.Model.R4.Range),typeof(Hl7.Fhir.Model.R4.Ratio),typeof(Hl7.Fhir.Model.R4.ResourceReference),typeof(Hl7.Fhir.Model.R4.SampledData),typeof(Hl7.Fhir.Model.R4.Signature),typeof(Hl7.Fhir.Model.R4.Timing),typeof(Hl7.Fhir.Model.R4.ParameterDefinition),typeof(Hl7.Fhir.Model.R4.DataRequirement),typeof(Hl7.Fhir.Model.R4.RelatedArtifact),typeof(Hl7.Fhir.Model.R4.ContactDetail),typeof(Hl7.Fhir.Model.R4.Contributor),typeof(Hl7.Fhir.Model.R4.TriggerDefinition),typeof(Hl7.Fhir.Model.R4.UsageContext),typeof(Hl7.Fhir.Model.R4.Dosage))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.Element _Value;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParameterComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParameterComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "OutputComponent")]
        [DataContract]
        public partial class OutputComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "OutputComponent"; } }
            
            /// <summary>
            /// Label for output
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
            /// Result of output
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Base64Binary),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.canonical),typeof(Hl7.Fhir.Model.R4.Code),typeof(Hl7.Fhir.Model.R4.Date),typeof(Hl7.Fhir.Model.R4.FhirDateTime),typeof(Hl7.Fhir.Model.R4.FhirDecimal),typeof(Hl7.Fhir.Model.R4.Id),typeof(Hl7.Fhir.Model.Instant),typeof(Hl7.Fhir.Model.R4.Integer),typeof(Hl7.Fhir.Model.Markdown),typeof(Hl7.Fhir.Model.R4.Oid),typeof(Hl7.Fhir.Model.R4.PositiveInt),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.R4.Time),typeof(Hl7.Fhir.Model.R4.UnsignedInt),typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.url),typeof(Hl7.Fhir.Model.uuid),typeof(Hl7.Fhir.Model.R4.Address),typeof(Hl7.Fhir.Model.R4.Age),typeof(Hl7.Fhir.Model.R4.Annotation),typeof(Hl7.Fhir.Model.R4.Attachment),typeof(Hl7.Fhir.Model.R4.CodeableConcept),typeof(Hl7.Fhir.Model.R4.Coding),typeof(Hl7.Fhir.Model.R4.ContactPoint),typeof(Hl7.Fhir.Model.R4.Count),typeof(Hl7.Fhir.Model.R4.Distance),typeof(Hl7.Fhir.Model.R4.Duration),typeof(Hl7.Fhir.Model.R4.HumanName),typeof(Hl7.Fhir.Model.R4.Identifier),typeof(Hl7.Fhir.Model.R4.Money),typeof(Hl7.Fhir.Model.R4.Period),typeof(Hl7.Fhir.Model.R4.Quantity),typeof(Hl7.Fhir.Model.R4.Range),typeof(Hl7.Fhir.Model.R4.Ratio),typeof(Hl7.Fhir.Model.R4.ResourceReference),typeof(Hl7.Fhir.Model.R4.SampledData),typeof(Hl7.Fhir.Model.R4.Signature),typeof(Hl7.Fhir.Model.R4.Timing),typeof(Hl7.Fhir.Model.R4.ParameterDefinition),typeof(Hl7.Fhir.Model.R4.DataRequirement),typeof(Hl7.Fhir.Model.R4.RelatedArtifact),typeof(Hl7.Fhir.Model.R4.ContactDetail),typeof(Hl7.Fhir.Model.R4.Contributor),typeof(Hl7.Fhir.Model.R4.TriggerDefinition),typeof(Hl7.Fhir.Model.R4.UsageContext),typeof(Hl7.Fhir.Model.R4.Dosage))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.Element _Value;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OutputComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OutputComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OutputComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OutputComponent;
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
        /// Task Instance Identifier
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
        /// Formal definition of task
        /// </summary>
        [FhirElement("instantiates", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
        [DataMember]
        public Hl7.Fhir.Model.Element Instantiates
        {
            get { return _Instantiates; }
            set { _Instantiates = value; OnPropertyChanged("Instantiates"); }
        }
        
        private Hl7.Fhir.Model.Element _Instantiates;
        
        /// <summary>
        /// Request fulfilled by this task
        /// </summary>
        [FhirElement("basedOn", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> BasedOn
        {
            get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _BasedOn; }
            set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _BasedOn;
        
        /// <summary>
        /// Requisition or grouper id
        /// </summary>
        [FhirElement("groupIdentifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Identifier GroupIdentifier
        {
            get { return _GroupIdentifier; }
            set { _GroupIdentifier = value; OnPropertyChanged("GroupIdentifier"); }
        }
        
        private Hl7.Fhir.Model.R4.Identifier _GroupIdentifier;
        
        /// <summary>
        /// Composite task
        /// </summary>
        [FhirElement("partOf", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [References("Task")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> PartOf
        {
            get { if(_PartOf==null) _PartOf = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _PartOf; }
            set { _PartOf = value; OnPropertyChanged("PartOf"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _PartOf;
        
        /// <summary>
        /// draft | requested | received | accepted | +
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _StatusElement;
        
        /// <summary>
        /// draft | requested | received | accepted | +
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
        /// Reason for current status
        /// </summary>
        [FhirElement("statusReason", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept StatusReason
        {
            get { return _StatusReason; }
            set { _StatusReason = value; OnPropertyChanged("StatusReason"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _StatusReason;
        
        /// <summary>
        /// E.g. "Specimen collected", "IV prepped"
        /// </summary>
        [FhirElement("businessStatus", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept BusinessStatus
        {
            get { return _BusinessStatus; }
            set { _BusinessStatus = value; OnPropertyChanged("BusinessStatus"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _BusinessStatus;
        
        /// <summary>
        /// proposal | plan | order +
        /// </summary>
        [FhirElement("intent", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code IntentElement
        {
            get { return _IntentElement; }
            set { _IntentElement = value; OnPropertyChanged("IntentElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _IntentElement;
        
        /// <summary>
        /// proposal | plan | order +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Intent
        {
            get { return IntentElement != null ? IntentElement.Value : null; }
            set
            {
                if (value == null)
                    IntentElement = null;
                else
                    IntentElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Intent");
            }
        }
        
        /// <summary>
        /// normal | urgent | asap | stat
        /// </summary>
        [FhirElement("priority", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code PriorityElement
        {
            get { return _PriorityElement; }
            set { _PriorityElement = value; OnPropertyChanged("PriorityElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _PriorityElement;
        
        /// <summary>
        /// normal | urgent | asap | stat
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (value == null)
                    PriorityElement = null;
                else
                    PriorityElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Priority");
            }
        }
        
        /// <summary>
        /// Task Type
        /// </summary>
        [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Code;
        
        /// <summary>
        /// Human-readable explanation of task
        /// </summary>
        [FhirElement("description", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Human-readable explanation of task
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
        /// What task is acting on
        /// </summary>
        [FhirElement("focus", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Focus
        {
            get { return _Focus; }
            set { _Focus = value; OnPropertyChanged("Focus"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Focus;
        
        /// <summary>
        /// Beneficiary of the Task
        /// </summary>
        [FhirElement("for", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference For
        {
            get { return _For; }
            set { _For = value; OnPropertyChanged("For"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _For;
        
        /// <summary>
        /// Healthcare event during which this task originated
        /// </summary>
        [FhirElement("context", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Context
        {
            get { return _Context; }
            set { _Context = value; OnPropertyChanged("Context"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Context;
        
        /// <summary>
        /// Start and end time of execution
        /// </summary>
        [FhirElement("executionPeriod", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=240)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Period ExecutionPeriod
        {
            get { return _ExecutionPeriod; }
            set { _ExecutionPeriod = value; OnPropertyChanged("ExecutionPeriod"); }
        }
        
        private Hl7.Fhir.Model.R4.Period _ExecutionPeriod;
        
        /// <summary>
        /// Task Creation Date
        /// </summary>
        [FhirElement("authoredOn", Order=250)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime AuthoredOnElement
        {
            get { return _AuthoredOnElement; }
            set { _AuthoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _AuthoredOnElement;
        
        /// <summary>
        /// Task Creation Date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string AuthoredOn
        {
            get { return AuthoredOnElement != null ? AuthoredOnElement.Value : null; }
            set
            {
                if (value == null)
                    AuthoredOnElement = null;
                else
                    AuthoredOnElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("AuthoredOn");
            }
        }
        
        /// <summary>
        /// Task Last Modified Date
        /// </summary>
        [FhirElement("lastModified", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=260)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime LastModifiedElement
        {
            get { return _LastModifiedElement; }
            set { _LastModifiedElement = value; OnPropertyChanged("LastModifiedElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _LastModifiedElement;
        
        /// <summary>
        /// Task Last Modified Date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string LastModified
        {
            get { return LastModifiedElement != null ? LastModifiedElement.Value : null; }
            set
            {
                if (value == null)
                    LastModifiedElement = null;
                else
                    LastModifiedElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("LastModified");
            }
        }
        
        /// <summary>
        /// Who is asking for task to be done
        /// </summary>
        [FhirElement("requester", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=270)]
        [CLSCompliant(false)]
        [References("Device","Organization","Patient","Practitioner","PractitionerRole","RelatedPerson")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Requester
        {
            get { return _Requester; }
            set { _Requester = value; OnPropertyChanged("Requester"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Requester;
        
        /// <summary>
        /// requester | dispatcher | scheduler | performer | monitor | manager | acquirer | reviewer
        /// </summary>
        [FhirElement("performerType", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> PerformerType
        {
            get { if(_PerformerType==null) _PerformerType = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _PerformerType; }
            set { _PerformerType = value; OnPropertyChanged("PerformerType"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _PerformerType;
        
        /// <summary>
        /// Responsible individual
        /// </summary>
        [FhirElement("owner", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=290)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Organization","CareTeam","HealthcareService","Patient","Device","RelatedPerson")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Owner
        {
            get { return _Owner; }
            set { _Owner = value; OnPropertyChanged("Owner"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Owner;
        
        /// <summary>
        /// Why task is needed
        /// </summary>
        [FhirElement("reasonCode", Order=300)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept ReasonCode
        {
            get { return _ReasonCode; }
            set { _ReasonCode = value; OnPropertyChanged("ReasonCode"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _ReasonCode;
        
        /// <summary>
        /// Why task is needed
        /// </summary>
        [FhirElement("reasonReference", Order=310)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference ReasonReference
        {
            get { return _ReasonReference; }
            set { _ReasonReference = value; OnPropertyChanged("ReasonReference"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _ReasonReference;
        
        /// <summary>
        /// Comments made about the task
        /// </summary>
        [FhirElement("note", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.R4.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Annotation> _Note;
        
        /// <summary>
        /// Key events in history of the Task
        /// </summary>
        [FhirElement("relevantHistory", Order=330)]
        [CLSCompliant(false)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> RelevantHistory
        {
            get { if(_RelevantHistory==null) _RelevantHistory = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _RelevantHistory; }
            set { _RelevantHistory = value; OnPropertyChanged("RelevantHistory"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _RelevantHistory;
        
        /// <summary>
        /// Constraints on fulfillment tasks
        /// </summary>
        [FhirElement("restriction", Order=340)]
        [DataMember]
        public RestrictionComponent Restriction
        {
            get { return _Restriction; }
            set { _Restriction = value; OnPropertyChanged("Restriction"); }
        }
        
        private RestrictionComponent _Restriction;
        
        /// <summary>
        /// Information used to perform task
        /// </summary>
        [FhirElement("input", Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParameterComponent> Input
        {
            get { if(_Input==null) _Input = new List<ParameterComponent>(); return _Input; }
            set { _Input = value; OnPropertyChanged("Input"); }
        }
        
        private List<ParameterComponent> _Input;
        
        /// <summary>
        /// Information produced as part of task
        /// </summary>
        [FhirElement("output", Order=360)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<OutputComponent> Output
        {
            get { if(_Output==null) _Output = new List<OutputComponent>(); return _Output; }
            set { _Output = value; OnPropertyChanged("Output"); }
        }
        
        private List<OutputComponent> _Output;
    
    
        public static ElementDefinitionConstraint Task_INV_1 = new ElementDefinitionConstraint
        {
            Expression = "lastModified.exists().not() or authoredOn.exists().not() or lastModified >= authoredOn",
            Key = "inv-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Last modified date must be greater than or equal to authored-on date.",
            Xpath = "not(exists(f:lastModified/@value)) or not(exists(f:authoredOn/@value)) or f:lastModified/@value >= f:authoredOn/@value"
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
    
            InvariantConstraints.Add(Task_INV_1);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Task;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(Instantiates != null) dest.Instantiates = (Hl7.Fhir.Model.Element)Instantiates.DeepCopy();
                if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.R4.ResourceReference>(BasedOn.DeepCopy());
                if(GroupIdentifier != null) dest.GroupIdentifier = (Hl7.Fhir.Model.R4.Identifier)GroupIdentifier.DeepCopy();
                if(PartOf != null) dest.PartOf = new List<Hl7.Fhir.Model.R4.ResourceReference>(PartOf.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(StatusReason != null) dest.StatusReason = (Hl7.Fhir.Model.R4.CodeableConcept)StatusReason.DeepCopy();
                if(BusinessStatus != null) dest.BusinessStatus = (Hl7.Fhir.Model.R4.CodeableConcept)BusinessStatus.DeepCopy();
                if(IntentElement != null) dest.IntentElement = (Hl7.Fhir.Model.R4.Code)IntentElement.DeepCopy();
                if(PriorityElement != null) dest.PriorityElement = (Hl7.Fhir.Model.R4.Code)PriorityElement.DeepCopy();
                if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(Focus != null) dest.Focus = (Hl7.Fhir.Model.R4.ResourceReference)Focus.DeepCopy();
                if(For != null) dest.For = (Hl7.Fhir.Model.R4.ResourceReference)For.DeepCopy();
                if(Context != null) dest.Context = (Hl7.Fhir.Model.R4.ResourceReference)Context.DeepCopy();
                if(ExecutionPeriod != null) dest.ExecutionPeriod = (Hl7.Fhir.Model.R4.Period)ExecutionPeriod.DeepCopy();
                if(AuthoredOnElement != null) dest.AuthoredOnElement = (Hl7.Fhir.Model.R4.FhirDateTime)AuthoredOnElement.DeepCopy();
                if(LastModifiedElement != null) dest.LastModifiedElement = (Hl7.Fhir.Model.R4.FhirDateTime)LastModifiedElement.DeepCopy();
                if(Requester != null) dest.Requester = (Hl7.Fhir.Model.R4.ResourceReference)Requester.DeepCopy();
                if(PerformerType != null) dest.PerformerType = new List<Hl7.Fhir.Model.R4.CodeableConcept>(PerformerType.DeepCopy());
                if(Owner != null) dest.Owner = (Hl7.Fhir.Model.R4.ResourceReference)Owner.DeepCopy();
                if(ReasonCode != null) dest.ReasonCode = (Hl7.Fhir.Model.R4.CodeableConcept)ReasonCode.DeepCopy();
                if(ReasonReference != null) dest.ReasonReference = (Hl7.Fhir.Model.R4.ResourceReference)ReasonReference.DeepCopy();
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.R4.Annotation>(Note.DeepCopy());
                if(RelevantHistory != null) dest.RelevantHistory = new List<Hl7.Fhir.Model.R4.ResourceReference>(RelevantHistory.DeepCopy());
                if(Restriction != null) dest.Restriction = (RestrictionComponent)Restriction.DeepCopy();
                if(Input != null) dest.Input = new List<ParameterComponent>(Input.DeepCopy());
                if(Output != null) dest.Output = new List<OutputComponent>(Output.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Task());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Task;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Instantiates, otherT.Instantiates)) return false;
            if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if( !DeepComparable.Matches(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if( !DeepComparable.Matches(BusinessStatus, otherT.BusinessStatus)) return false;
            if( !DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if( !DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(Focus, otherT.Focus)) return false;
            if( !DeepComparable.Matches(For, otherT.For)) return false;
            if( !DeepComparable.Matches(Context, otherT.Context)) return false;
            if( !DeepComparable.Matches(ExecutionPeriod, otherT.ExecutionPeriod)) return false;
            if( !DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if( !DeepComparable.Matches(LastModifiedElement, otherT.LastModifiedElement)) return false;
            if( !DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if( !DeepComparable.Matches(PerformerType, otherT.PerformerType)) return false;
            if( !DeepComparable.Matches(Owner, otherT.Owner)) return false;
            if( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(RelevantHistory, otherT.RelevantHistory)) return false;
            if( !DeepComparable.Matches(Restriction, otherT.Restriction)) return false;
            if( !DeepComparable.Matches(Input, otherT.Input)) return false;
            if( !DeepComparable.Matches(Output, otherT.Output)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Task;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Instantiates, otherT.Instantiates)) return false;
            if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if( !DeepComparable.IsExactly(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if( !DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if( !DeepComparable.IsExactly(BusinessStatus, otherT.BusinessStatus)) return false;
            if( !DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if( !DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(Focus, otherT.Focus)) return false;
            if( !DeepComparable.IsExactly(For, otherT.For)) return false;
            if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if( !DeepComparable.IsExactly(ExecutionPeriod, otherT.ExecutionPeriod)) return false;
            if( !DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if( !DeepComparable.IsExactly(LastModifiedElement, otherT.LastModifiedElement)) return false;
            if( !DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if( !DeepComparable.IsExactly(PerformerType, otherT.PerformerType)) return false;
            if( !DeepComparable.IsExactly(Owner, otherT.Owner)) return false;
            if( !DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(RelevantHistory, otherT.RelevantHistory)) return false;
            if( !DeepComparable.IsExactly(Restriction, otherT.Restriction)) return false;
            if( !DeepComparable.IsExactly(Input, otherT.Input)) return false;
            if( !DeepComparable.IsExactly(Output, otherT.Output)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Instantiates != null) yield return Instantiates;
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                if (GroupIdentifier != null) yield return GroupIdentifier;
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (StatusReason != null) yield return StatusReason;
                if (BusinessStatus != null) yield return BusinessStatus;
                if (IntentElement != null) yield return IntentElement;
                if (PriorityElement != null) yield return PriorityElement;
                if (Code != null) yield return Code;
                if (DescriptionElement != null) yield return DescriptionElement;
                if (Focus != null) yield return Focus;
                if (For != null) yield return For;
                if (Context != null) yield return Context;
                if (ExecutionPeriod != null) yield return ExecutionPeriod;
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (LastModifiedElement != null) yield return LastModifiedElement;
                if (Requester != null) yield return Requester;
                foreach (var elem in PerformerType) { if (elem != null) yield return elem; }
                if (Owner != null) yield return Owner;
                if (ReasonCode != null) yield return ReasonCode;
                if (ReasonReference != null) yield return ReasonReference;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in RelevantHistory) { if (elem != null) yield return elem; }
                if (Restriction != null) yield return Restriction;
                foreach (var elem in Input) { if (elem != null) yield return elem; }
                foreach (var elem in Output) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (Instantiates != null) yield return new ElementValue("instantiates", false, Instantiates);
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", true, elem); }
                if (GroupIdentifier != null) yield return new ElementValue("groupIdentifier", false, GroupIdentifier);
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (StatusReason != null) yield return new ElementValue("statusReason", false, StatusReason);
                if (BusinessStatus != null) yield return new ElementValue("businessStatus", false, BusinessStatus);
                if (IntentElement != null) yield return new ElementValue("intent", false, IntentElement);
                if (PriorityElement != null) yield return new ElementValue("priority", false, PriorityElement);
                if (Code != null) yield return new ElementValue("code", false, Code);
                if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                if (Focus != null) yield return new ElementValue("focus", false, Focus);
                if (For != null) yield return new ElementValue("for", false, For);
                if (Context != null) yield return new ElementValue("context", false, Context);
                if (ExecutionPeriod != null) yield return new ElementValue("executionPeriod", false, ExecutionPeriod);
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", false, AuthoredOnElement);
                if (LastModifiedElement != null) yield return new ElementValue("lastModified", false, LastModifiedElement);
                if (Requester != null) yield return new ElementValue("requester", false, Requester);
                foreach (var elem in PerformerType) { if (elem != null) yield return new ElementValue("performerType", true, elem); }
                if (Owner != null) yield return new ElementValue("owner", false, Owner);
                if (ReasonCode != null) yield return new ElementValue("reasonCode", false, ReasonCode);
                if (ReasonReference != null) yield return new ElementValue("reasonReference", false, ReasonReference);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", true, elem); }
                foreach (var elem in RelevantHistory) { if (elem != null) yield return new ElementValue("relevantHistory", true, elem); }
                if (Restriction != null) yield return new ElementValue("restriction", false, Restriction);
                foreach (var elem in Input) { if (elem != null) yield return new ElementValue("input", true, elem); }
                foreach (var elem in Output) { if (elem != null) yield return new ElementValue("output", true, elem); }
            }
        }
    
    }

}
