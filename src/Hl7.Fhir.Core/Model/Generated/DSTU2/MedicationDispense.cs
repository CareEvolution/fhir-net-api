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
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
{
    /// <summary>
    /// Dispensing a medication to a named patient
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.DSTU2, "MedicationDispense", IsResource=true)]
    [DataContract]
    public partial class MedicationDispense : Hl7.Fhir.Model.DSTU2.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationDispense; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationDispense"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.DSTU2, "DosageInstructionComponent")]
        [DataContract]
        public partial class DosageInstructionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "DosageInstructionComponent"; } }
            
            /// <summary>
            /// Dosage Instructions
            /// </summary>
            [FhirElement("text", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TextElement
            {
                get { return _TextElement; }
                set { _TextElement = value; OnPropertyChanged("TextElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _TextElement;
            
            /// <summary>
            /// Dosage Instructions
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
            /// E.g. "Take with food"
            /// </summary>
            [FhirElement("additionalInstructions", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.DSTU2.CodeableConcept AdditionalInstructions
            {
                get { return _AdditionalInstructions; }
                set { _AdditionalInstructions = value; OnPropertyChanged("AdditionalInstructions"); }
            }
            
            private Hl7.Fhir.Model.DSTU2.CodeableConcept _AdditionalInstructions;
            
            /// <summary>
            /// When medication should be administered
            /// </summary>
            [FhirElement("timing", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.DSTU2.Timing Timing
            {
                get { return _Timing; }
                set { _Timing = value; OnPropertyChanged("Timing"); }
            }
            
            private Hl7.Fhir.Model.DSTU2.Timing _Timing;
            
            /// <summary>
            /// Take "as needed" f(or x)
            /// </summary>
            [FhirElement("asNeeded", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.DSTU2.CodeableConcept))]
            [DataMember]
            public Hl7.Fhir.Model.Element AsNeeded
            {
                get { return _AsNeeded; }
                set { _AsNeeded = value; OnPropertyChanged("AsNeeded"); }
            }
            
            private Hl7.Fhir.Model.Element _AsNeeded;
            
            /// <summary>
            /// Body site to administer to
            /// </summary>
            [FhirElement("site", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.DSTU2.CodeableConcept),typeof(Hl7.Fhir.Model.DSTU2.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Site
            {
                get { return _Site; }
                set { _Site = value; OnPropertyChanged("Site"); }
            }
            
            private Hl7.Fhir.Model.Element _Site;
            
            /// <summary>
            /// How drug should enter body
            /// </summary>
            [FhirElement("route", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.DSTU2.CodeableConcept Route
            {
                get { return _Route; }
                set { _Route = value; OnPropertyChanged("Route"); }
            }
            
            private Hl7.Fhir.Model.DSTU2.CodeableConcept _Route;
            
            /// <summary>
            /// Technique for administering medication
            /// </summary>
            [FhirElement("method", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.DSTU2.CodeableConcept Method
            {
                get { return _Method; }
                set { _Method = value; OnPropertyChanged("Method"); }
            }
            
            private Hl7.Fhir.Model.DSTU2.CodeableConcept _Method;
            
            /// <summary>
            /// Amount of medication per dose
            /// </summary>
            [FhirElement("dose", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.DSTU2.Range),typeof(Hl7.Fhir.Model.DSTU2.SimpleQuantity))]
            [DataMember]
            public Hl7.Fhir.Model.Element Dose
            {
                get { return _Dose; }
                set { _Dose = value; OnPropertyChanged("Dose"); }
            }
            
            private Hl7.Fhir.Model.Element _Dose;
            
            /// <summary>
            /// Amount of medication per unit of time
            /// </summary>
            [FhirElement("rate", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.DSTU2.Ratio),typeof(Hl7.Fhir.Model.DSTU2.Range))]
            [DataMember]
            public Hl7.Fhir.Model.Element Rate
            {
                get { return _Rate; }
                set { _Rate = value; OnPropertyChanged("Rate"); }
            }
            
            private Hl7.Fhir.Model.Element _Rate;
            
            /// <summary>
            /// Upper limit on medication per unit of time
            /// </summary>
            [FhirElement("maxDosePerPeriod", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.DSTU2.Ratio MaxDosePerPeriod
            {
                get { return _MaxDosePerPeriod; }
                set { _MaxDosePerPeriod = value; OnPropertyChanged("MaxDosePerPeriod"); }
            }
            
            private Hl7.Fhir.Model.DSTU2.Ratio _MaxDosePerPeriod;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DosageInstructionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TextElement != null) dest.TextElement = (Hl7.Fhir.Model.FhirString)TextElement.DeepCopy();
                    if(AdditionalInstructions != null) dest.AdditionalInstructions = (Hl7.Fhir.Model.DSTU2.CodeableConcept)AdditionalInstructions.DeepCopy();
                    if(Timing != null) dest.Timing = (Hl7.Fhir.Model.DSTU2.Timing)Timing.DeepCopy();
                    if(AsNeeded != null) dest.AsNeeded = (Hl7.Fhir.Model.Element)AsNeeded.DeepCopy();
                    if(Site != null) dest.Site = (Hl7.Fhir.Model.Element)Site.DeepCopy();
                    if(Route != null) dest.Route = (Hl7.Fhir.Model.DSTU2.CodeableConcept)Route.DeepCopy();
                    if(Method != null) dest.Method = (Hl7.Fhir.Model.DSTU2.CodeableConcept)Method.DeepCopy();
                    if(Dose != null) dest.Dose = (Hl7.Fhir.Model.Element)Dose.DeepCopy();
                    if(Rate != null) dest.Rate = (Hl7.Fhir.Model.Element)Rate.DeepCopy();
                    if(MaxDosePerPeriod != null) dest.MaxDosePerPeriod = (Hl7.Fhir.Model.DSTU2.Ratio)MaxDosePerPeriod.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DosageInstructionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DosageInstructionComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if( !DeepComparable.Matches(AdditionalInstructions, otherT.AdditionalInstructions)) return false;
                if( !DeepComparable.Matches(Timing, otherT.Timing)) return false;
                if( !DeepComparable.Matches(AsNeeded, otherT.AsNeeded)) return false;
                if( !DeepComparable.Matches(Site, otherT.Site)) return false;
                if( !DeepComparable.Matches(Route, otherT.Route)) return false;
                if( !DeepComparable.Matches(Method, otherT.Method)) return false;
                if( !DeepComparable.Matches(Dose, otherT.Dose)) return false;
                if( !DeepComparable.Matches(Rate, otherT.Rate)) return false;
                if( !DeepComparable.Matches(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DosageInstructionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if( !DeepComparable.IsExactly(AdditionalInstructions, otherT.AdditionalInstructions)) return false;
                if( !DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
                if( !DeepComparable.IsExactly(AsNeeded, otherT.AsNeeded)) return false;
                if( !DeepComparable.IsExactly(Site, otherT.Site)) return false;
                if( !DeepComparable.IsExactly(Route, otherT.Route)) return false;
                if( !DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if( !DeepComparable.IsExactly(Dose, otherT.Dose)) return false;
                if( !DeepComparable.IsExactly(Rate, otherT.Rate)) return false;
                if( !DeepComparable.IsExactly(MaxDosePerPeriod, otherT.MaxDosePerPeriod)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TextElement != null) yield return TextElement;
                    if (AdditionalInstructions != null) yield return AdditionalInstructions;
                    if (Timing != null) yield return Timing;
                    if (AsNeeded != null) yield return AsNeeded;
                    if (Site != null) yield return Site;
                    if (Route != null) yield return Route;
                    if (Method != null) yield return Method;
                    if (Dose != null) yield return Dose;
                    if (Rate != null) yield return Rate;
                    if (MaxDosePerPeriod != null) yield return MaxDosePerPeriod;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TextElement != null) yield return new ElementValue("text", false, TextElement);
                    if (AdditionalInstructions != null) yield return new ElementValue("additionalInstructions", false, AdditionalInstructions);
                    if (Timing != null) yield return new ElementValue("timing", false, Timing);
                    if (AsNeeded != null) yield return new ElementValue("asNeeded", false, AsNeeded);
                    if (Site != null) yield return new ElementValue("site", false, Site);
                    if (Route != null) yield return new ElementValue("route", false, Route);
                    if (Method != null) yield return new ElementValue("method", false, Method);
                    if (Dose != null) yield return new ElementValue("dose", false, Dose);
                    if (Rate != null) yield return new ElementValue("rate", false, Rate);
                    if (MaxDosePerPeriod != null) yield return new ElementValue("maxDosePerPeriod", false, MaxDosePerPeriod);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.DSTU2, "SubstitutionComponent")]
        [DataContract]
        public partial class SubstitutionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SubstitutionComponent"; } }
            
            /// <summary>
            /// Type of substitution
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.DSTU2.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.DSTU2.CodeableConcept _Type;
            
            /// <summary>
            /// Why was substitution made
            /// </summary>
            [FhirElement("reason", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.DSTU2.CodeableConcept> Reason
            {
                get { if(_Reason==null) _Reason = new List<Hl7.Fhir.Model.DSTU2.CodeableConcept>(); return _Reason; }
                set { _Reason = value; OnPropertyChanged("Reason"); }
            }
            
            private List<Hl7.Fhir.Model.DSTU2.CodeableConcept> _Reason;
            
            /// <summary>
            /// Who is responsible for the substitution
            /// </summary>
            [FhirElement("responsibleParty", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [References("Practitioner")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.DSTU2.ResourceReference> ResponsibleParty
            {
                get { if(_ResponsibleParty==null) _ResponsibleParty = new List<Hl7.Fhir.Model.DSTU2.ResourceReference>(); return _ResponsibleParty; }
                set { _ResponsibleParty = value; OnPropertyChanged("ResponsibleParty"); }
            }
            
            private List<Hl7.Fhir.Model.DSTU2.ResourceReference> _ResponsibleParty;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstitutionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.DSTU2.CodeableConcept)Type.DeepCopy();
                    if(Reason != null) dest.Reason = new List<Hl7.Fhir.Model.DSTU2.CodeableConcept>(Reason.DeepCopy());
                    if(ResponsibleParty != null) dest.ResponsibleParty = new List<Hl7.Fhir.Model.DSTU2.ResourceReference>(ResponsibleParty.DeepCopy());
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
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if( !DeepComparable.Matches(ResponsibleParty, otherT.ResponsibleParty)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if( !DeepComparable.IsExactly(ResponsibleParty, otherT.ResponsibleParty)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Reason) { if (elem != null) yield return elem; }
                    foreach (var elem in ResponsibleParty) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", true, elem); }
                    foreach (var elem in ResponsibleParty) { if (elem != null) yield return new ElementValue("responsibleParty", true, elem); }
                }
            }
        
        
        }
    
        
        /// <summary>
        /// External identifier
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.Identifier _Identifier;
        
        /// <summary>
        /// in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Code<Hl7.Fhir.Model.DSTU2.MedicationDispenseStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.DSTU2.MedicationDispenseStatus> _StatusElement;
        
        /// <summary>
        /// in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.DSTU2.MedicationDispenseStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<Hl7.Fhir.Model.DSTU2.MedicationDispenseStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Who the dispense is for
        /// </summary>
        [FhirElement("patient", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [References("Patient")]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.ResourceReference _Patient;
        
        /// <summary>
        /// Practitioner responsible for dispensing medication
        /// </summary>
        [FhirElement("dispenser", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [References("Practitioner")]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.ResourceReference Dispenser
        {
            get { return _Dispenser; }
            set { _Dispenser = value; OnPropertyChanged("Dispenser"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.ResourceReference _Dispenser;
        
        /// <summary>
        /// Medication order that authorizes the dispense
        /// </summary>
        [FhirElement("authorizingPrescription", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [References("MedicationOrder")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.DSTU2.ResourceReference> AuthorizingPrescription
        {
            get { if(_AuthorizingPrescription==null) _AuthorizingPrescription = new List<Hl7.Fhir.Model.DSTU2.ResourceReference>(); return _AuthorizingPrescription; }
            set { _AuthorizingPrescription = value; OnPropertyChanged("AuthorizingPrescription"); }
        }
        
        private List<Hl7.Fhir.Model.DSTU2.ResourceReference> _AuthorizingPrescription;
        
        /// <summary>
        /// Trial fill, partial fill, emergency fill, etc.
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.CodeableConcept _Type;
        
        /// <summary>
        /// Amount dispensed
        /// </summary>
        [FhirElement("quantity", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.SimpleQuantity Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; OnPropertyChanged("Quantity"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.SimpleQuantity _Quantity;
        
        /// <summary>
        /// Days Supply
        /// </summary>
        [FhirElement("daysSupply", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.SimpleQuantity DaysSupply
        {
            get { return _DaysSupply; }
            set { _DaysSupply = value; OnPropertyChanged("DaysSupply"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.SimpleQuantity _DaysSupply;
        
        /// <summary>
        /// What medication was supplied
        /// </summary>
        [FhirElement("medication", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.DSTU2.CodeableConcept),typeof(Hl7.Fhir.Model.DSTU2.ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Element Medication
        {
            get { return _Medication; }
            set { _Medication = value; OnPropertyChanged("Medication"); }
        }
        
        private Hl7.Fhir.Model.Element _Medication;
        
        /// <summary>
        /// Dispense processing time
        /// </summary>
        [FhirElement("whenPrepared", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.FhirDateTime WhenPreparedElement
        {
            get { return _WhenPreparedElement; }
            set { _WhenPreparedElement = value; OnPropertyChanged("WhenPreparedElement"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.FhirDateTime _WhenPreparedElement;
        
        /// <summary>
        /// Dispense processing time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string WhenPrepared
        {
            get { return WhenPreparedElement != null ? WhenPreparedElement.Value : null; }
            set
            {
                if (value == null)
                    WhenPreparedElement = null;
                else
                    WhenPreparedElement = new Hl7.Fhir.Model.DSTU2.FhirDateTime(value);
                OnPropertyChanged("WhenPrepared");
            }
        }
        
        /// <summary>
        /// When product was given out
        /// </summary>
        [FhirElement("whenHandedOver", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.FhirDateTime WhenHandedOverElement
        {
            get { return _WhenHandedOverElement; }
            set { _WhenHandedOverElement = value; OnPropertyChanged("WhenHandedOverElement"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.FhirDateTime _WhenHandedOverElement;
        
        /// <summary>
        /// When product was given out
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string WhenHandedOver
        {
            get { return WhenHandedOverElement != null ? WhenHandedOverElement.Value : null; }
            set
            {
                if (value == null)
                    WhenHandedOverElement = null;
                else
                    WhenHandedOverElement = new Hl7.Fhir.Model.DSTU2.FhirDateTime(value);
                OnPropertyChanged("WhenHandedOver");
            }
        }
        
        /// <summary>
        /// Where the medication was sent
        /// </summary>
        [FhirElement("destination", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [References("Location")]
        [DataMember]
        public Hl7.Fhir.Model.DSTU2.ResourceReference Destination
        {
            get { return _Destination; }
            set { _Destination = value; OnPropertyChanged("Destination"); }
        }
        
        private Hl7.Fhir.Model.DSTU2.ResourceReference _Destination;
        
        /// <summary>
        /// Who collected the medication
        /// </summary>
        [FhirElement("receiver", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [References("Patient","Practitioner")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.DSTU2.ResourceReference> Receiver
        {
            get { if(_Receiver==null) _Receiver = new List<Hl7.Fhir.Model.DSTU2.ResourceReference>(); return _Receiver; }
            set { _Receiver = value; OnPropertyChanged("Receiver"); }
        }
        
        private List<Hl7.Fhir.Model.DSTU2.ResourceReference> _Receiver;
        
        /// <summary>
        /// Information about the dispense
        /// </summary>
        [FhirElement("note", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString NoteElement
        {
            get { return _NoteElement; }
            set { _NoteElement = value; OnPropertyChanged("NoteElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _NoteElement;
        
        /// <summary>
        /// Information about the dispense
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Note
        {
            get { return NoteElement != null ? NoteElement.Value : null; }
            set
            {
                if (value == null)
                    NoteElement = null;
                else
                    NoteElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Note");
            }
        }
        
        /// <summary>
        /// Medicine administration instructions to the patient/caregiver
        /// </summary>
        [FhirElement("dosageInstruction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DosageInstructionComponent> DosageInstruction
        {
            get { if(_DosageInstruction==null) _DosageInstruction = new List<DosageInstructionComponent>(); return _DosageInstruction; }
            set { _DosageInstruction = value; OnPropertyChanged("DosageInstruction"); }
        }
        
        private List<DosageInstructionComponent> _DosageInstruction;
        
        /// <summary>
        /// Deals with substitution of one medicine for another
        /// </summary>
        [FhirElement("substitution", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=240)]
        [CLSCompliant(false)]
        [DataMember]
        public SubstitutionComponent Substitution
        {
            get { return _Substitution; }
            set { _Substitution = value; OnPropertyChanged("Substitution"); }
        }
        
        private SubstitutionComponent _Substitution;
    
    
        public static ElementDefinitionConstraint MedicationDispense_MDD_1 = new ElementDefinitionConstraint
        {
            Expression = "whenHandedOver.empty() or whenPrepared.empty() or whenHandedOver >= whenPrepared",
            Key = "mdd-1",
            Severity = ConstraintSeverity.Warning,
            Human = "whenHandedOver cannot be before whenPrepared",
            Xpath = "not(exists(f:whenHandedOver/@value)) or not(exists(f:whenPrepared/@value)) or ( f:whenHandedOver/@value >= f:whenPrepared/@value)"
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
    
            InvariantConstraints.Add(MedicationDispense_MDD_1);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationDispense;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.DSTU2.Identifier)Identifier.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.DSTU2.MedicationDispenseStatus>)StatusElement.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.DSTU2.ResourceReference)Patient.DeepCopy();
                if(Dispenser != null) dest.Dispenser = (Hl7.Fhir.Model.DSTU2.ResourceReference)Dispenser.DeepCopy();
                if(AuthorizingPrescription != null) dest.AuthorizingPrescription = new List<Hl7.Fhir.Model.DSTU2.ResourceReference>(AuthorizingPrescription.DeepCopy());
                if(Type != null) dest.Type = (Hl7.Fhir.Model.DSTU2.CodeableConcept)Type.DeepCopy();
                if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.DSTU2.SimpleQuantity)Quantity.DeepCopy();
                if(DaysSupply != null) dest.DaysSupply = (Hl7.Fhir.Model.DSTU2.SimpleQuantity)DaysSupply.DeepCopy();
                if(Medication != null) dest.Medication = (Hl7.Fhir.Model.Element)Medication.DeepCopy();
                if(WhenPreparedElement != null) dest.WhenPreparedElement = (Hl7.Fhir.Model.DSTU2.FhirDateTime)WhenPreparedElement.DeepCopy();
                if(WhenHandedOverElement != null) dest.WhenHandedOverElement = (Hl7.Fhir.Model.DSTU2.FhirDateTime)WhenHandedOverElement.DeepCopy();
                if(Destination != null) dest.Destination = (Hl7.Fhir.Model.DSTU2.ResourceReference)Destination.DeepCopy();
                if(Receiver != null) dest.Receiver = new List<Hl7.Fhir.Model.DSTU2.ResourceReference>(Receiver.DeepCopy());
                if(NoteElement != null) dest.NoteElement = (Hl7.Fhir.Model.FhirString)NoteElement.DeepCopy();
                if(DosageInstruction != null) dest.DosageInstruction = new List<DosageInstructionComponent>(DosageInstruction.DeepCopy());
                if(Substitution != null) dest.Substitution = (SubstitutionComponent)Substitution.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationDispense());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationDispense;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Dispenser, otherT.Dispenser)) return false;
            if( !DeepComparable.Matches(AuthorizingPrescription, otherT.AuthorizingPrescription)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if( !DeepComparable.Matches(DaysSupply, otherT.DaysSupply)) return false;
            if( !DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if( !DeepComparable.Matches(WhenPreparedElement, otherT.WhenPreparedElement)) return false;
            if( !DeepComparable.Matches(WhenHandedOverElement, otherT.WhenHandedOverElement)) return false;
            if( !DeepComparable.Matches(Destination, otherT.Destination)) return false;
            if( !DeepComparable.Matches(Receiver, otherT.Receiver)) return false;
            if( !DeepComparable.Matches(NoteElement, otherT.NoteElement)) return false;
            if( !DeepComparable.Matches(DosageInstruction, otherT.DosageInstruction)) return false;
            if( !DeepComparable.Matches(Substitution, otherT.Substitution)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationDispense;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Dispenser, otherT.Dispenser)) return false;
            if( !DeepComparable.IsExactly(AuthorizingPrescription, otherT.AuthorizingPrescription)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if( !DeepComparable.IsExactly(DaysSupply, otherT.DaysSupply)) return false;
            if( !DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if( !DeepComparable.IsExactly(WhenPreparedElement, otherT.WhenPreparedElement)) return false;
            if( !DeepComparable.IsExactly(WhenHandedOverElement, otherT.WhenHandedOverElement)) return false;
            if( !DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
            if( !DeepComparable.IsExactly(Receiver, otherT.Receiver)) return false;
            if( !DeepComparable.IsExactly(NoteElement, otherT.NoteElement)) return false;
            if( !DeepComparable.IsExactly(DosageInstruction, otherT.DosageInstruction)) return false;
            if( !DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (StatusElement != null) yield return StatusElement;
                if (Patient != null) yield return Patient;
                if (Dispenser != null) yield return Dispenser;
                foreach (var elem in AuthorizingPrescription) { if (elem != null) yield return elem; }
                if (Type != null) yield return Type;
                if (Quantity != null) yield return Quantity;
                if (DaysSupply != null) yield return DaysSupply;
                if (Medication != null) yield return Medication;
                if (WhenPreparedElement != null) yield return WhenPreparedElement;
                if (WhenHandedOverElement != null) yield return WhenHandedOverElement;
                if (Destination != null) yield return Destination;
                foreach (var elem in Receiver) { if (elem != null) yield return elem; }
                if (NoteElement != null) yield return NoteElement;
                foreach (var elem in DosageInstruction) { if (elem != null) yield return elem; }
                if (Substitution != null) yield return Substitution;
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (Patient != null) yield return new ElementValue("patient", false, Patient);
                if (Dispenser != null) yield return new ElementValue("dispenser", false, Dispenser);
                foreach (var elem in AuthorizingPrescription) { if (elem != null) yield return new ElementValue("authorizingPrescription", true, elem); }
                if (Type != null) yield return new ElementValue("type", false, Type);
                if (Quantity != null) yield return new ElementValue("quantity", false, Quantity);
                if (DaysSupply != null) yield return new ElementValue("daysSupply", false, DaysSupply);
                if (Medication != null) yield return new ElementValue("medication", false, Medication);
                if (WhenPreparedElement != null) yield return new ElementValue("whenPrepared", false, WhenPreparedElement);
                if (WhenHandedOverElement != null) yield return new ElementValue("whenHandedOver", false, WhenHandedOverElement);
                if (Destination != null) yield return new ElementValue("destination", false, Destination);
                foreach (var elem in Receiver) { if (elem != null) yield return new ElementValue("receiver", true, elem); }
                if (NoteElement != null) yield return new ElementValue("note", false, NoteElement);
                foreach (var elem in DosageInstruction) { if (elem != null) yield return new ElementValue("dosageInstruction", true, elem); }
                if (Substitution != null) yield return new ElementValue("substitution", false, Substitution);
            }
        }
    
    }

}
