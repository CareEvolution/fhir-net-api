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
    /// The regulatory authorization of a medicinal product
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "MedicinalProductAuthorization", IsResource=true)]
    [DataContract]
    public partial class MedicinalProductAuthorization : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicinalProductAuthorization; } }
        [NotMapped]
        public override string TypeName { get { return "MedicinalProductAuthorization"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "JurisdictionalAuthorizationComponent")]
        [DataContract]
        public partial class JurisdictionalAuthorizationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "JurisdictionalAuthorizationComponent"; } }
            
            /// <summary>
            /// Country of authorization
            /// </summary>
            [FhirElement("country", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Country
            {
                get { return _Country; }
                set { _Country = value; OnPropertyChanged("Country"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Country;
            
            /// <summary>
            /// Jurisdiction within a country
            /// </summary>
            [FhirElement("jurisdiction", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Jurisdiction
            {
                get { return _Jurisdiction; }
                set { _Jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Jurisdiction;
            
            /// <summary>
            /// The assigned number for the marketing authorization
            /// </summary>
            [FhirElement("number", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Number
            {
                get { return _Number; }
                set { _Number = value; OnPropertyChanged("Number"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Number;
            
            /// <summary>
            /// The legal status of supply in a jurisdiction or region
            /// </summary>
            [FhirElement("legalStatusOfSupply", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept LegalStatusOfSupply
            {
                get { return _LegalStatusOfSupply; }
                set { _LegalStatusOfSupply = value; OnPropertyChanged("LegalStatusOfSupply"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _LegalStatusOfSupply;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as JurisdictionalAuthorizationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Country != null) dest.Country = (Hl7.Fhir.Model.R4.CodeableConcept)Country.DeepCopy();
                    if(Jurisdiction != null) dest.Jurisdiction = (Hl7.Fhir.Model.R4.CodeableConcept)Jurisdiction.DeepCopy();
                    if(Number != null) dest.Number = (Hl7.Fhir.Model.R4.Identifier)Number.DeepCopy();
                    if(LegalStatusOfSupply != null) dest.LegalStatusOfSupply = (Hl7.Fhir.Model.R4.CodeableConcept)LegalStatusOfSupply.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new JurisdictionalAuthorizationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as JurisdictionalAuthorizationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Country, otherT.Country)) return false;
                if( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.Matches(Number, otherT.Number)) return false;
                if( !DeepComparable.Matches(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as JurisdictionalAuthorizationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Country, otherT.Country)) return false;
                if( !DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
                if( !DeepComparable.IsExactly(Number, otherT.Number)) return false;
                if( !DeepComparable.IsExactly(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Country != null) yield return Country;
                    if (Jurisdiction != null) yield return Jurisdiction;
                    if (Number != null) yield return Number;
                    if (LegalStatusOfSupply != null) yield return LegalStatusOfSupply;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Country != null) yield return new ElementValue("country", false, Country);
                    if (Jurisdiction != null) yield return new ElementValue("jurisdiction", false, Jurisdiction);
                    if (Number != null) yield return new ElementValue("number", false, Number);
                    if (LegalStatusOfSupply != null) yield return new ElementValue("legalStatusOfSupply", false, LegalStatusOfSupply);
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
            /// Identifier for this procedure
            /// </summary>
            [FhirElement("number", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Number
            {
                get { return _Number; }
                set { _Number = value; OnPropertyChanged("Number"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Number;
            
            /// <summary>
            /// Type of procedure
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Date of procedure
            /// </summary>
            [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Period Date
            {
                get { return _Date; }
                set { _Date = value; OnPropertyChanged("Date"); }
            }
            
            private Hl7.Fhir.Model.R4.Period _Date;
            
            /// <summary>
            /// Applcations submitted to obtain a marketing authorization
            /// </summary>
            [FhirElement("application", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ApplicationComponent> Application
            {
                get { if(_Application==null) _Application = new List<ApplicationComponent>(); return _Application; }
                set { _Application = value; OnPropertyChanged("Application"); }
            }
            
            private List<ApplicationComponent> _Application;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProcedureComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Number != null) dest.Number = (Hl7.Fhir.Model.R4.Identifier)Number.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(Date != null) dest.Date = (Hl7.Fhir.Model.R4.Period)Date.DeepCopy();
                    if(Application != null) dest.Application = new List<ApplicationComponent>(Application.DeepCopy());
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
                if( !DeepComparable.Matches(Number, otherT.Number)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Date, otherT.Date)) return false;
                if( !DeepComparable.Matches(Application, otherT.Application)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProcedureComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Number, otherT.Number)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Date, otherT.Date)) return false;
                if( !DeepComparable.IsExactly(Application, otherT.Application)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Number != null) yield return Number;
                    if (Type != null) yield return Type;
                    if (Date != null) yield return Date;
                    foreach (var elem in Application) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Number != null) yield return new ElementValue("number", false, Number);
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Date != null) yield return new ElementValue("date", false, Date);
                    foreach (var elem in Application) { if (elem != null) yield return new ElementValue("application", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ApplicationComponent")]
        [DataContract]
        public partial class ApplicationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ApplicationComponent"; } }
            
            /// <summary>
            /// A unique identifier for the specific instance of an application shall be provided in text. The application identifier/number is usually assigned by a Medicines Regulatory Agency
            /// </summary>
            [FhirElement("number", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Identifier Number
            {
                get { return _Number; }
                set { _Number = value; OnPropertyChanged("Number"); }
            }
            
            private Hl7.Fhir.Model.R4.Identifier _Number;
            
            /// <summary>
            /// The type of the application
            /// </summary>
            [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Type;
            
            /// <summary>
            /// Date that the application was made
            /// </summary>
            [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDateTime DateElement
            {
                get { return _DateElement; }
                set { _DateElement = value; OnPropertyChanged("DateElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
            
            /// <summary>
            /// Date that the application was made
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
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ApplicationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Number != null) dest.Number = (Hl7.Fhir.Model.R4.Identifier)Number.DeepCopy();
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                    if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ApplicationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ApplicationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Number, otherT.Number)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ApplicationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Number, otherT.Number)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Number != null) yield return Number;
                    if (Type != null) yield return Type;
                    if (DateElement != null) yield return DateElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Number != null) yield return new ElementValue("number", false, Number);
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Business identifier for the marketing authorization, as assigned by a regulator
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.R4.Identifier _Identifier;
        
        /// <summary>
        /// The country in which the marketing authorization has been granted
        /// </summary>
        [FhirElement("country", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> Country
        {
            get { if(_Country==null) _Country = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Country; }
            set { _Country = value; OnPropertyChanged("Country"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _Country;
        
        /// <summary>
        /// The legal status of supply of the medicinal product as classified by the regulator
        /// </summary>
        [FhirElement("legalStatusOfSupply", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept LegalStatusOfSupply
        {
            get { return _LegalStatusOfSupply; }
            set { _LegalStatusOfSupply = value; OnPropertyChanged("LegalStatusOfSupply"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _LegalStatusOfSupply;
        
        /// <summary>
        /// The status of the marketing authorization
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Status
        {
            get { return _Status; }
            set { _Status = value; OnPropertyChanged("Status"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Status;
        
        /// <summary>
        /// The date at which the given status has become applicable
        /// </summary>
        [FhirElement("statusDate", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime StatusDateElement
        {
            get { return _StatusDateElement; }
            set { _StatusDateElement = value; OnPropertyChanged("StatusDateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _StatusDateElement;
        
        /// <summary>
        /// The date at which the given status has become applicable
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string StatusDate
        {
            get { return StatusDateElement != null ? StatusDateElement.Value : null; }
            set
            {
                if (value == null)
                    StatusDateElement = null;
                else
                    StatusDateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("StatusDate");
            }
        }
        
        /// <summary>
        /// The date when a suspended the marketing or the marketing authorization of the product is anticipated to be restored
        /// </summary>
        [FhirElement("restoreDate", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime RestoreDateElement
        {
            get { return _RestoreDateElement; }
            set { _RestoreDateElement = value; OnPropertyChanged("RestoreDateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _RestoreDateElement;
        
        /// <summary>
        /// The date when a suspended the marketing or the marketing authorization of the product is anticipated to be restored
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string RestoreDate
        {
            get { return RestoreDateElement != null ? RestoreDateElement.Value : null; }
            set
            {
                if (value == null)
                    RestoreDateElement = null;
                else
                    RestoreDateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("RestoreDate");
            }
        }
        
        /// <summary>
        /// The beginning of the time period in which the marketing authorization is in the specific status shall be specified A complete date consisting of day, month and year shall be specified using the ISO 8601 date format
        /// </summary>
        [FhirElement("validityPeriod", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Period ValidityPeriod
        {
            get { return _ValidityPeriod; }
            set { _ValidityPeriod = value; OnPropertyChanged("ValidityPeriod"); }
        }
        
        private Hl7.Fhir.Model.R4.Period _ValidityPeriod;
        
        /// <summary>
        /// A period of time after authorization before generic product applicatiosn can be submitted
        /// </summary>
        [FhirElement("dataExclusivityPeriod", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Period DataExclusivityPeriod
        {
            get { return _DataExclusivityPeriod; }
            set { _DataExclusivityPeriod = value; OnPropertyChanged("DataExclusivityPeriod"); }
        }
        
        private Hl7.Fhir.Model.R4.Period _DataExclusivityPeriod;
        
        /// <summary>
        /// The date when the first authorization was granted by a Medicines Regulatory Agency
        /// </summary>
        [FhirElement("dateOfFirstAuthorization", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime DateOfFirstAuthorizationElement
        {
            get { return _DateOfFirstAuthorizationElement; }
            set { _DateOfFirstAuthorizationElement = value; OnPropertyChanged("DateOfFirstAuthorizationElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _DateOfFirstAuthorizationElement;
        
        /// <summary>
        /// The date when the first authorization was granted by a Medicines Regulatory Agency
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string DateOfFirstAuthorization
        {
            get { return DateOfFirstAuthorizationElement != null ? DateOfFirstAuthorizationElement.Value : null; }
            set
            {
                if (value == null)
                    DateOfFirstAuthorizationElement = null;
                else
                    DateOfFirstAuthorizationElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("DateOfFirstAuthorization");
            }
        }
        
        /// <summary>
        /// Date of first marketing authorization for a company's new medicinal product in any country in the World
        /// </summary>
        [FhirElement("internationalBirthDate", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime InternationalBirthDateElement
        {
            get { return _InternationalBirthDateElement; }
            set { _InternationalBirthDateElement = value; OnPropertyChanged("InternationalBirthDateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _InternationalBirthDateElement;
        
        /// <summary>
        /// Date of first marketing authorization for a company's new medicinal product in any country in the World
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string InternationalBirthDate
        {
            get { return InternationalBirthDateElement != null ? InternationalBirthDateElement.Value : null; }
            set
            {
                if (value == null)
                    InternationalBirthDateElement = null;
                else
                    InternationalBirthDateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("InternationalBirthDate");
            }
        }
        
        /// <summary>
        /// Authorization in areas within a country
        /// </summary>
        [FhirElement("jurisdictionalAuthorization", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<JurisdictionalAuthorizationComponent> JurisdictionalAuthorization
        {
            get { if(_JurisdictionalAuthorization==null) _JurisdictionalAuthorization = new List<JurisdictionalAuthorizationComponent>(); return _JurisdictionalAuthorization; }
            set { _JurisdictionalAuthorization = value; OnPropertyChanged("JurisdictionalAuthorization"); }
        }
        
        private List<JurisdictionalAuthorizationComponent> _JurisdictionalAuthorization;
        
        /// <summary>
        /// Marketing Authorization Holder
        /// </summary>
        [FhirElement("holder", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [References("Organization")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Holder
        {
            get { return _Holder; }
            set { _Holder = value; OnPropertyChanged("Holder"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Holder;
        
        /// <summary>
        /// Medicines Regulatory Agency
        /// </summary>
        [FhirElement("regulator", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [References("Organization")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Regulator
        {
            get { return _Regulator; }
            set { _Regulator = value; OnPropertyChanged("Regulator"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Regulator;
        
        /// <summary>
        /// The regulatory procedure for granting or amending a marketing authorization
        /// </summary>
        [FhirElement("procedure", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ProcedureComponent Procedure
        {
            get { return _Procedure; }
            set { _Procedure = value; OnPropertyChanged("Procedure"); }
        }
        
        private ProcedureComponent _Procedure;
        
        /// <summary>
        /// Marketing status of the medicinal product, in contrast to marketing authorizaton
        /// </summary>
        [FhirElement("marketingStatus", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.MarketingStatus> MarketingStatus
        {
            get { if(_MarketingStatus==null) _MarketingStatus = new List<Hl7.Fhir.Model.R4.MarketingStatus>(); return _MarketingStatus; }
            set { _MarketingStatus = value; OnPropertyChanged("MarketingStatus"); }
        }
        
        private List<Hl7.Fhir.Model.R4.MarketingStatus> _MarketingStatus;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicinalProductAuthorization;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
                if(Country != null) dest.Country = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Country.DeepCopy());
                if(LegalStatusOfSupply != null) dest.LegalStatusOfSupply = (Hl7.Fhir.Model.R4.CodeableConcept)LegalStatusOfSupply.DeepCopy();
                if(Status != null) dest.Status = (Hl7.Fhir.Model.R4.CodeableConcept)Status.DeepCopy();
                if(StatusDateElement != null) dest.StatusDateElement = (Hl7.Fhir.Model.R4.FhirDateTime)StatusDateElement.DeepCopy();
                if(RestoreDateElement != null) dest.RestoreDateElement = (Hl7.Fhir.Model.R4.FhirDateTime)RestoreDateElement.DeepCopy();
                if(ValidityPeriod != null) dest.ValidityPeriod = (Hl7.Fhir.Model.R4.Period)ValidityPeriod.DeepCopy();
                if(DataExclusivityPeriod != null) dest.DataExclusivityPeriod = (Hl7.Fhir.Model.R4.Period)DataExclusivityPeriod.DeepCopy();
                if(DateOfFirstAuthorizationElement != null) dest.DateOfFirstAuthorizationElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateOfFirstAuthorizationElement.DeepCopy();
                if(InternationalBirthDateElement != null) dest.InternationalBirthDateElement = (Hl7.Fhir.Model.R4.FhirDateTime)InternationalBirthDateElement.DeepCopy();
                if(JurisdictionalAuthorization != null) dest.JurisdictionalAuthorization = new List<JurisdictionalAuthorizationComponent>(JurisdictionalAuthorization.DeepCopy());
                if(Holder != null) dest.Holder = (Hl7.Fhir.Model.R4.ResourceReference)Holder.DeepCopy();
                if(Regulator != null) dest.Regulator = (Hl7.Fhir.Model.R4.ResourceReference)Regulator.DeepCopy();
                if(Procedure != null) dest.Procedure = (ProcedureComponent)Procedure.DeepCopy();
                if(MarketingStatus != null) dest.MarketingStatus = new List<Hl7.Fhir.Model.R4.MarketingStatus>(MarketingStatus.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicinalProductAuthorization());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicinalProductAuthorization;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(Country, otherT.Country)) return false;
            if( !DeepComparable.Matches(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
            if( !DeepComparable.Matches(Status, otherT.Status)) return false;
            if( !DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
            if( !DeepComparable.Matches(RestoreDateElement, otherT.RestoreDateElement)) return false;
            if( !DeepComparable.Matches(ValidityPeriod, otherT.ValidityPeriod)) return false;
            if( !DeepComparable.Matches(DataExclusivityPeriod, otherT.DataExclusivityPeriod)) return false;
            if( !DeepComparable.Matches(DateOfFirstAuthorizationElement, otherT.DateOfFirstAuthorizationElement)) return false;
            if( !DeepComparable.Matches(InternationalBirthDateElement, otherT.InternationalBirthDateElement)) return false;
            if( !DeepComparable.Matches(JurisdictionalAuthorization, otherT.JurisdictionalAuthorization)) return false;
            if( !DeepComparable.Matches(Holder, otherT.Holder)) return false;
            if( !DeepComparable.Matches(Regulator, otherT.Regulator)) return false;
            if( !DeepComparable.Matches(Procedure, otherT.Procedure)) return false;
            if( !DeepComparable.Matches(MarketingStatus, otherT.MarketingStatus)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicinalProductAuthorization;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(Country, otherT.Country)) return false;
            if( !DeepComparable.IsExactly(LegalStatusOfSupply, otherT.LegalStatusOfSupply)) return false;
            if( !DeepComparable.IsExactly(Status, otherT.Status)) return false;
            if( !DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
            if( !DeepComparable.IsExactly(RestoreDateElement, otherT.RestoreDateElement)) return false;
            if( !DeepComparable.IsExactly(ValidityPeriod, otherT.ValidityPeriod)) return false;
            if( !DeepComparable.IsExactly(DataExclusivityPeriod, otherT.DataExclusivityPeriod)) return false;
            if( !DeepComparable.IsExactly(DateOfFirstAuthorizationElement, otherT.DateOfFirstAuthorizationElement)) return false;
            if( !DeepComparable.IsExactly(InternationalBirthDateElement, otherT.InternationalBirthDateElement)) return false;
            if( !DeepComparable.IsExactly(JurisdictionalAuthorization, otherT.JurisdictionalAuthorization)) return false;
            if( !DeepComparable.IsExactly(Holder, otherT.Holder)) return false;
            if( !DeepComparable.IsExactly(Regulator, otherT.Regulator)) return false;
            if( !DeepComparable.IsExactly(Procedure, otherT.Procedure)) return false;
            if( !DeepComparable.IsExactly(MarketingStatus, otherT.MarketingStatus)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                foreach (var elem in Country) { if (elem != null) yield return elem; }
                if (LegalStatusOfSupply != null) yield return LegalStatusOfSupply;
                if (Status != null) yield return Status;
                if (StatusDateElement != null) yield return StatusDateElement;
                if (RestoreDateElement != null) yield return RestoreDateElement;
                if (ValidityPeriod != null) yield return ValidityPeriod;
                if (DataExclusivityPeriod != null) yield return DataExclusivityPeriod;
                if (DateOfFirstAuthorizationElement != null) yield return DateOfFirstAuthorizationElement;
                if (InternationalBirthDateElement != null) yield return InternationalBirthDateElement;
                foreach (var elem in JurisdictionalAuthorization) { if (elem != null) yield return elem; }
                if (Holder != null) yield return Holder;
                if (Regulator != null) yield return Regulator;
                if (Procedure != null) yield return Procedure;
                foreach (var elem in MarketingStatus) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                foreach (var elem in Country) { if (elem != null) yield return new ElementValue("country", true, elem); }
                if (LegalStatusOfSupply != null) yield return new ElementValue("legalStatusOfSupply", false, LegalStatusOfSupply);
                if (Status != null) yield return new ElementValue("status", false, Status);
                if (StatusDateElement != null) yield return new ElementValue("statusDate", false, StatusDateElement);
                if (RestoreDateElement != null) yield return new ElementValue("restoreDate", false, RestoreDateElement);
                if (ValidityPeriod != null) yield return new ElementValue("validityPeriod", false, ValidityPeriod);
                if (DataExclusivityPeriod != null) yield return new ElementValue("dataExclusivityPeriod", false, DataExclusivityPeriod);
                if (DateOfFirstAuthorizationElement != null) yield return new ElementValue("dateOfFirstAuthorization", false, DateOfFirstAuthorizationElement);
                if (InternationalBirthDateElement != null) yield return new ElementValue("internationalBirthDate", false, InternationalBirthDateElement);
                foreach (var elem in JurisdictionalAuthorization) { if (elem != null) yield return new ElementValue("jurisdictionalAuthorization", true, elem); }
                if (Holder != null) yield return new ElementValue("holder", false, Holder);
                if (Regulator != null) yield return new ElementValue("regulator", false, Regulator);
                if (Procedure != null) yield return new ElementValue("procedure", false, Procedure);
                foreach (var elem in MarketingStatus) { if (elem != null) yield return new ElementValue("marketingStatus", true, elem); }
            }
        }
    
    }

}
