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
    /// Ordering of medication for patient or group
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "MedicationRequest", IsResource=true)]
    [DataContract]
    public partial class MedicationRequest : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationRequest; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationRequest"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DispenseRequestComponent")]
        [DataContract]
        public partial class DispenseRequestComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DispenseRequestComponent"; } }
            
            /// <summary>
            /// Time period supply is authorized for
            /// </summary>
            [FhirElement("validityPeriod", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Period ValidityPeriod
            {
                get { return _ValidityPeriod; }
                set { _ValidityPeriod = value; OnPropertyChanged("ValidityPeriod"); }
            }
            
            private Hl7.Fhir.Model.R4.Period _ValidityPeriod;
            
            /// <summary>
            /// Number of refills authorized
            /// </summary>
            [FhirElement("numberOfRepeatsAllowed", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.UnsignedInt NumberOfRepeatsAllowedElement
            {
                get { return _NumberOfRepeatsAllowedElement; }
                set { _NumberOfRepeatsAllowedElement = value; OnPropertyChanged("NumberOfRepeatsAllowedElement"); }
            }
            
            private Hl7.Fhir.Model.R4.UnsignedInt _NumberOfRepeatsAllowedElement;
            
            /// <summary>
            /// Number of refills authorized
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? NumberOfRepeatsAllowed
            {
                get { return NumberOfRepeatsAllowedElement != null ? NumberOfRepeatsAllowedElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberOfRepeatsAllowedElement = null;
                    else
                        NumberOfRepeatsAllowedElement = new Hl7.Fhir.Model.R4.UnsignedInt(value);
                    OnPropertyChanged("NumberOfRepeatsAllowed");
                }
            }
            
            /// <summary>
            /// Amount of medication to supply per dispense
            /// </summary>
            [FhirElement("quantity", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.R4.SimpleQuantity _Quantity;
            
            /// <summary>
            /// Number of days supply per dispense
            /// </summary>
            [FhirElement("expectedSupplyDuration", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Duration ExpectedSupplyDuration
            {
                get { return _ExpectedSupplyDuration; }
                set { _ExpectedSupplyDuration = value; OnPropertyChanged("ExpectedSupplyDuration"); }
            }
            
            private Hl7.Fhir.Model.R4.Duration _ExpectedSupplyDuration;
            
            /// <summary>
            /// Intended dispenser
            /// </summary>
            [FhirElement("performer", Order=80)]
            [CLSCompliant(false)]
            [References("Organization")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Performer
            {
                get { return _Performer; }
                set { _Performer = value; OnPropertyChanged("Performer"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Performer;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DispenseRequestComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(ValidityPeriod != null) dest.ValidityPeriod = (Hl7.Fhir.Model.R4.Period)ValidityPeriod.DeepCopy();
                    if(NumberOfRepeatsAllowedElement != null) dest.NumberOfRepeatsAllowedElement = (Hl7.Fhir.Model.R4.UnsignedInt)NumberOfRepeatsAllowedElement.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.R4.SimpleQuantity)Quantity.DeepCopy();
                    if(ExpectedSupplyDuration != null) dest.ExpectedSupplyDuration = (Hl7.Fhir.Model.R4.Duration)ExpectedSupplyDuration.DeepCopy();
                    if(Performer != null) dest.Performer = (Hl7.Fhir.Model.R4.ResourceReference)Performer.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DispenseRequestComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DispenseRequestComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(ValidityPeriod, otherT.ValidityPeriod)) return false;
                if( !DeepComparable.Matches(NumberOfRepeatsAllowedElement, otherT.NumberOfRepeatsAllowedElement)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(ExpectedSupplyDuration, otherT.ExpectedSupplyDuration)) return false;
                if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DispenseRequestComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(ValidityPeriod, otherT.ValidityPeriod)) return false;
                if( !DeepComparable.IsExactly(NumberOfRepeatsAllowedElement, otherT.NumberOfRepeatsAllowedElement)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(ExpectedSupplyDuration, otherT.ExpectedSupplyDuration)) return false;
                if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ValidityPeriod != null) yield return ValidityPeriod;
                    if (NumberOfRepeatsAllowedElement != null) yield return NumberOfRepeatsAllowedElement;
                    if (Quantity != null) yield return Quantity;
                    if (ExpectedSupplyDuration != null) yield return ExpectedSupplyDuration;
                    if (Performer != null) yield return Performer;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ValidityPeriod != null) yield return new ElementValue("validityPeriod", false, ValidityPeriod);
                    if (NumberOfRepeatsAllowedElement != null) yield return new ElementValue("numberOfRepeatsAllowed", false, NumberOfRepeatsAllowedElement);
                    if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                    if (ExpectedSupplyDuration != null) yield return new ElementValue("expectedSupplyDuration", false, ExpectedSupplyDuration);
                    if (Performer != null) yield return new ElementValue("performer", false, Performer);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SubstitutionComponent")]
        [DataContract]
        public partial class SubstitutionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SubstitutionComponent"; } }
            
            /// <summary>
            /// Whether substitution is allowed or not
            /// </summary>
            [FhirElement("allowed", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean AllowedElement
            {
                get { return _AllowedElement; }
                set { _AllowedElement = value; OnPropertyChanged("AllowedElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _AllowedElement;
            
            /// <summary>
            /// Whether substitution is allowed or not
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Allowed
            {
                get { return AllowedElement != null ? AllowedElement.Value : null; }
                set
                {
                    if (value == null)
                        AllowedElement = null;
                    else
                        AllowedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Allowed");
                }
            }
            
            /// <summary>
            /// Why should (not) substitution be made
            /// </summary>
            [FhirElement("reason", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Reason
            {
                get { return _Reason; }
                set { _Reason = value; OnPropertyChanged("Reason"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Reason;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstitutionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(AllowedElement != null) dest.AllowedElement = (Hl7.Fhir.Model.FhirBoolean)AllowedElement.DeepCopy();
                    if(Reason != null) dest.Reason = (Hl7.Fhir.Model.R4.CodeableConcept)Reason.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SubstitutionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(AllowedElement, otherT.AllowedElement)) return false;
                if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(AllowedElement, otherT.AllowedElement)) return false;
                if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (AllowedElement != null) yield return AllowedElement;
                    if (Reason != null) yield return Reason;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (AllowedElement != null) yield return new ElementValue("allowed", false, AllowedElement);
                    if (Reason != null) yield return new ElementValue("reason", false, Reason);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// External ids for this request
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
        /// active | on-hold | cancelled | completed | entered-in-error | stopped | draft | unknown
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
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
        /// active | on-hold | cancelled | completed | entered-in-error | stopped | draft | unknown
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
        /// proposal | plan | order | original-order | instance-order | option
        /// </summary>
        [FhirElement("intent", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
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
        /// proposal | plan | order | original-order | instance-order | option
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
        /// Type of medication usage
        /// </summary>
        [FhirElement("category", Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> Category
        {
            get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Category; }
            set { _Category = value; OnPropertyChanged("Category"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _Category;
        
        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        [FhirElement("priority", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code PriorityElement
        {
            get { return _PriorityElement; }
            set { _PriorityElement = value; OnPropertyChanged("PriorityElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _PriorityElement;
        
        /// <summary>
        /// routine | urgent | asap | stat
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
        /// Medication to be taken
        /// </summary>
        [FhirElement("medication", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.R4.CodeableConcept),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Element Medication
        {
            get { return _Medication; }
            set { _Medication = value; OnPropertyChanged("Medication"); }
        }
        
        private Hl7.Fhir.Model.Element _Medication;
        
        /// <summary>
        /// Who or group medication request is for
        /// </summary>
        [FhirElement("subject", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [References("Patient","Group")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Subject;
        
        /// <summary>
        /// Created during encounter/admission/stay
        /// </summary>
        [FhirElement("context", Order=160)]
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
        /// Information to support ordering of the medication
        /// </summary>
        [FhirElement("supportingInformation", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> SupportingInformation
        {
            get { if(_SupportingInformation==null) _SupportingInformation = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _SupportingInformation; }
            set { _SupportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _SupportingInformation;
        
        /// <summary>
        /// When request was initially authored
        /// </summary>
        [FhirElement("authoredOn", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime AuthoredOnElement
        {
            get { return _AuthoredOnElement; }
            set { _AuthoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _AuthoredOnElement;
        
        /// <summary>
        /// When request was initially authored
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
        /// Who/What requested the Request
        /// </summary>
        [FhirElement("requester", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Organization","Patient","RelatedPerson","Device")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Requester
        {
            get { return _Requester; }
            set { _Requester = value; OnPropertyChanged("Requester"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Requester;
        
        /// <summary>
        /// Intended performer of administration
        /// </summary>
        [FhirElement("performer", Order=200)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Organization","Patient","Device","RelatedPerson","CareTeam")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Performer
        {
            get { return _Performer; }
            set { _Performer = value; OnPropertyChanged("Performer"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Performer;
        
        /// <summary>
        /// Desired kind of performer of the medication administration
        /// </summary>
        [FhirElement("performerType", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept PerformerType
        {
            get { return _PerformerType; }
            set { _PerformerType = value; OnPropertyChanged("PerformerType"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _PerformerType;
        
        /// <summary>
        /// Person who entered the request
        /// </summary>
        [FhirElement("recorder", Order=220)]
        [CLSCompliant(false)]
        [References("Practitioner")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Recorder
        {
            get { return _Recorder; }
            set { _Recorder = value; OnPropertyChanged("Recorder"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Recorder;
        
        /// <summary>
        /// Reason or indication for writing the prescription
        /// </summary>
        [FhirElement("reasonCode", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> ReasonCode
        {
            get { if(_ReasonCode==null) _ReasonCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _ReasonCode; }
            set { _ReasonCode = value; OnPropertyChanged("ReasonCode"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _ReasonCode;
        
        /// <summary>
        /// Condition or observation that supports why the prescription is being written
        /// </summary>
        [FhirElement("reasonReference", Order=240)]
        [CLSCompliant(false)]
        [References("Condition","Observation")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> ReasonReference
        {
            get { if(_ReasonReference==null) _ReasonReference = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _ReasonReference; }
            set { _ReasonReference = value; OnPropertyChanged("ReasonReference"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _ReasonReference;
        
        /// <summary>
        /// Instantiates protocol or definition
        /// </summary>
        [FhirElement("instantiates", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=250)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirUri> InstantiatesElement
        {
            get { if(_InstantiatesElement==null) _InstantiatesElement = new List<Hl7.Fhir.Model.FhirUri>(); return _InstantiatesElement; }
            set { _InstantiatesElement = value; OnPropertyChanged("InstantiatesElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirUri> _InstantiatesElement;
        
        /// <summary>
        /// Instantiates protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Instantiates
        {
            get { return InstantiatesElement != null ? InstantiatesElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesElement = null;
                else
                    InstantiatesElement = new List<Hl7.Fhir.Model.FhirUri>(value.Select(elem=>new Hl7.Fhir.Model.FhirUri(elem)));
                OnPropertyChanged("Instantiates");
            }
        }
        
        /// <summary>
        /// What request fulfills
        /// </summary>
        [FhirElement("basedOn", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=260)]
        [CLSCompliant(false)]
        [References("CarePlan","MedicationRequest","ServiceRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> BasedOn
        {
            get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _BasedOn; }
            set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _BasedOn;
        
        /// <summary>
        /// Composite request this is part of
        /// </summary>
        [FhirElement("groupIdentifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=270)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Identifier GroupIdentifier
        {
            get { return _GroupIdentifier; }
            set { _GroupIdentifier = value; OnPropertyChanged("GroupIdentifier"); }
        }
        
        private Hl7.Fhir.Model.R4.Identifier _GroupIdentifier;
        
        /// <summary>
        /// Reason for current status
        /// </summary>
        [FhirElement("statusReason", Order=280)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept StatusReason
        {
            get { return _StatusReason; }
            set { _StatusReason = value; OnPropertyChanged("StatusReason"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _StatusReason;
        
        /// <summary>
        /// Associated insurance coverage
        /// </summary>
        [FhirElement("insurance", Order=290)]
        [CLSCompliant(false)]
        [References("Coverage","ClaimResponse")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Insurance
        {
            get { if(_Insurance==null) _Insurance = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Insurance; }
            set { _Insurance = value; OnPropertyChanged("Insurance"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Insurance;
        
        /// <summary>
        /// Information about the prescription
        /// </summary>
        [FhirElement("note", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.R4.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Annotation> _Note;
        
        /// <summary>
        /// How the medication should be taken
        /// </summary>
        [FhirElement("dosageInstruction", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Dosage> DosageInstruction
        {
            get { if(_DosageInstruction==null) _DosageInstruction = new List<Hl7.Fhir.Model.R4.Dosage>(); return _DosageInstruction; }
            set { _DosageInstruction = value; OnPropertyChanged("DosageInstruction"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Dosage> _DosageInstruction;
        
        /// <summary>
        /// Medication supply authorization
        /// </summary>
        [FhirElement("dispenseRequest", Order=320)]
        [DataMember]
        public DispenseRequestComponent DispenseRequest
        {
            get { return _DispenseRequest; }
            set { _DispenseRequest = value; OnPropertyChanged("DispenseRequest"); }
        }
        
        private DispenseRequestComponent _DispenseRequest;
        
        /// <summary>
        /// Any restrictions on medication substitution
        /// </summary>
        [FhirElement("substitution", Order=330)]
        [DataMember]
        public SubstitutionComponent Substitution
        {
            get { return _Substitution; }
            set { _Substitution = value; OnPropertyChanged("Substitution"); }
        }
        
        private SubstitutionComponent _Substitution;
        
        /// <summary>
        /// An order/prescription that is being replaced
        /// </summary>
        [FhirElement("priorPrescription", Order=340)]
        [CLSCompliant(false)]
        [References("MedicationRequest")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference PriorPrescription
        {
            get { return _PriorPrescription; }
            set { _PriorPrescription = value; OnPropertyChanged("PriorPrescription"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _PriorPrescription;
        
        /// <summary>
        /// Clinical Issue with action
        /// </summary>
        [FhirElement("detectedIssue", Order=350)]
        [CLSCompliant(false)]
        [References("DetectedIssue")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> DetectedIssue
        {
            get { if(_DetectedIssue==null) _DetectedIssue = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _DetectedIssue; }
            set { _DetectedIssue = value; OnPropertyChanged("DetectedIssue"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _DetectedIssue;
        
        /// <summary>
        /// A list of events of interest in the lifecycle
        /// </summary>
        [FhirElement("eventHistory", Order=360)]
        [CLSCompliant(false)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> EventHistory
        {
            get { if(_EventHistory==null) _EventHistory = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _EventHistory; }
            set { _EventHistory = value; OnPropertyChanged("EventHistory"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _EventHistory;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationRequest;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(IntentElement != null) dest.IntentElement = (Hl7.Fhir.Model.R4.Code)IntentElement.DeepCopy();
                if(Category != null) dest.Category = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Category.DeepCopy());
                if(PriorityElement != null) dest.PriorityElement = (Hl7.Fhir.Model.R4.Code)PriorityElement.DeepCopy();
                if(Medication != null) dest.Medication = (Hl7.Fhir.Model.Element)Medication.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.R4.ResourceReference)Subject.DeepCopy();
                if(Context != null) dest.Context = (Hl7.Fhir.Model.R4.ResourceReference)Context.DeepCopy();
                if(SupportingInformation != null) dest.SupportingInformation = new List<Hl7.Fhir.Model.R4.ResourceReference>(SupportingInformation.DeepCopy());
                if(AuthoredOnElement != null) dest.AuthoredOnElement = (Hl7.Fhir.Model.R4.FhirDateTime)AuthoredOnElement.DeepCopy();
                if(Requester != null) dest.Requester = (Hl7.Fhir.Model.R4.ResourceReference)Requester.DeepCopy();
                if(Performer != null) dest.Performer = (Hl7.Fhir.Model.R4.ResourceReference)Performer.DeepCopy();
                if(PerformerType != null) dest.PerformerType = (Hl7.Fhir.Model.R4.CodeableConcept)PerformerType.DeepCopy();
                if(Recorder != null) dest.Recorder = (Hl7.Fhir.Model.R4.ResourceReference)Recorder.DeepCopy();
                if(ReasonCode != null) dest.ReasonCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(ReasonCode.DeepCopy());
                if(ReasonReference != null) dest.ReasonReference = new List<Hl7.Fhir.Model.R4.ResourceReference>(ReasonReference.DeepCopy());
                if(InstantiatesElement != null) dest.InstantiatesElement = new List<Hl7.Fhir.Model.FhirUri>(InstantiatesElement.DeepCopy());
                if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.R4.ResourceReference>(BasedOn.DeepCopy());
                if(GroupIdentifier != null) dest.GroupIdentifier = (Hl7.Fhir.Model.R4.Identifier)GroupIdentifier.DeepCopy();
                if(StatusReason != null) dest.StatusReason = (Hl7.Fhir.Model.R4.CodeableConcept)StatusReason.DeepCopy();
                if(Insurance != null) dest.Insurance = new List<Hl7.Fhir.Model.R4.ResourceReference>(Insurance.DeepCopy());
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.R4.Annotation>(Note.DeepCopy());
                if(DosageInstruction != null) dest.DosageInstruction = new List<Hl7.Fhir.Model.R4.Dosage>(DosageInstruction.DeepCopy());
                if(DispenseRequest != null) dest.DispenseRequest = (DispenseRequestComponent)DispenseRequest.DeepCopy();
                if(Substitution != null) dest.Substitution = (SubstitutionComponent)Substitution.DeepCopy();
                if(PriorPrescription != null) dest.PriorPrescription = (Hl7.Fhir.Model.R4.ResourceReference)PriorPrescription.DeepCopy();
                if(DetectedIssue != null) dest.DetectedIssue = new List<Hl7.Fhir.Model.R4.ResourceReference>(DetectedIssue.DeepCopy());
                if(EventHistory != null) dest.EventHistory = new List<Hl7.Fhir.Model.R4.ResourceReference>(EventHistory.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationRequest());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationRequest;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if( !DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if( !DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Context, otherT.Context)) return false;
            if( !DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if( !DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if( !DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if( !DeepComparable.Matches(PerformerType, otherT.PerformerType)) return false;
            if( !DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.Matches(InstantiatesElement, otherT.InstantiatesElement)) return false;
            if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if( !DeepComparable.Matches(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if( !DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if( !DeepComparable.Matches(Insurance, otherT.Insurance)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(DosageInstruction, otherT.DosageInstruction)) return false;
            if( !DeepComparable.Matches(DispenseRequest, otherT.DispenseRequest)) return false;
            if( !DeepComparable.Matches(Substitution, otherT.Substitution)) return false;
            if( !DeepComparable.Matches(PriorPrescription, otherT.PriorPrescription)) return false;
            if( !DeepComparable.Matches(DetectedIssue, otherT.DetectedIssue)) return false;
            if( !DeepComparable.Matches(EventHistory, otherT.EventHistory)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationRequest;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if( !DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if( !DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if( !DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if( !DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if( !DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if( !DeepComparable.IsExactly(PerformerType, otherT.PerformerType)) return false;
            if( !DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if( !DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.IsExactly(InstantiatesElement, otherT.InstantiatesElement)) return false;
            if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if( !DeepComparable.IsExactly(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if( !DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if( !DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(DosageInstruction, otherT.DosageInstruction)) return false;
            if( !DeepComparable.IsExactly(DispenseRequest, otherT.DispenseRequest)) return false;
            if( !DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;
            if( !DeepComparable.IsExactly(PriorPrescription, otherT.PriorPrescription)) return false;
            if( !DeepComparable.IsExactly(DetectedIssue, otherT.DetectedIssue)) return false;
            if( !DeepComparable.IsExactly(EventHistory, otherT.EventHistory)) return false;
        
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
                if (IntentElement != null) yield return IntentElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (PriorityElement != null) yield return PriorityElement;
                if (Medication != null) yield return Medication;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (Requester != null) yield return Requester;
                if (Performer != null) yield return Performer;
                if (PerformerType != null) yield return PerformerType;
                if (Recorder != null) yield return Recorder;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in InstantiatesElement) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                if (GroupIdentifier != null) yield return GroupIdentifier;
                if (StatusReason != null) yield return StatusReason;
                foreach (var elem in Insurance) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in DosageInstruction) { if (elem != null) yield return elem; }
                if (DispenseRequest != null) yield return DispenseRequest;
                if (Substitution != null) yield return Substitution;
                if (PriorPrescription != null) yield return PriorPrescription;
                foreach (var elem in DetectedIssue) { if (elem != null) yield return elem; }
                foreach (var elem in EventHistory) { if (elem != null) yield return elem; }
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
                if (IntentElement != null) yield return new ElementValue("intent", false, IntentElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", true, elem); }
                if (PriorityElement != null) yield return new ElementValue("priority", false, PriorityElement);
                if (Medication != null) yield return new ElementValue("medication", false, Medication);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (Context != null) yield return new ElementValue("context", false, Context);
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", true, elem); }
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", false, AuthoredOnElement);
                if (Requester != null) yield return new ElementValue("requester", false, Requester);
                if (Performer != null) yield return new ElementValue("performer", false, Performer);
                if (PerformerType != null) yield return new ElementValue("performerType", false, PerformerType);
                if (Recorder != null) yield return new ElementValue("recorder", false, Recorder);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", true, elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", true, elem); }
                foreach (var elem in InstantiatesElement) { if (elem != null) yield return new ElementValue("instantiates", true, elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", true, elem); }
                if (GroupIdentifier != null) yield return new ElementValue("groupIdentifier", false, GroupIdentifier);
                if (StatusReason != null) yield return new ElementValue("statusReason", false, StatusReason);
                foreach (var elem in Insurance) { if (elem != null) yield return new ElementValue("insurance", true, elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", true, elem); }
                foreach (var elem in DosageInstruction) { if (elem != null) yield return new ElementValue("dosageInstruction", true, elem); }
                if (DispenseRequest != null) yield return new ElementValue("dispenseRequest", false, DispenseRequest);
                if (Substitution != null) yield return new ElementValue("substitution", false, Substitution);
                if (PriorPrescription != null) yield return new ElementValue("priorPrescription", false, PriorPrescription);
                foreach (var elem in DetectedIssue) { if (elem != null) yield return new ElementValue("detectedIssue", true, elem); }
                foreach (var elem in EventHistory) { if (elem != null) yield return new ElementValue("eventHistory", true, elem); }
            }
        }
    
    }

}
