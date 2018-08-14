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
    /// Immunization event information
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "Immunization", IsResource=true)]
    [DataContract]
    public partial class Immunization : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Immunization; } }
        [NotMapped]
        public override string TypeName { get { return "Immunization"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PerformerComponent")]
        [DataContract]
        public partial class PerformerComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PerformerComponent"; } }
            
            /// <summary>
            /// What type of performance was done
            /// </summary>
            [FhirElement("function", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Function
            {
                get { return _Function; }
                set { _Function = value; OnPropertyChanged("Function"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Function;
            
            /// <summary>
            /// Individual or organization who was performing
            /// </summary>
            [FhirElement("actor", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [References("Practitioner","Organization")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Actor
            {
                get { return _Actor; }
                set { _Actor = value; OnPropertyChanged("Actor"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Actor;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PerformerComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Function != null) dest.Function = (Hl7.Fhir.Model.R4.CodeableConcept)Function.DeepCopy();
                    if(Actor != null) dest.Actor = (Hl7.Fhir.Model.R4.ResourceReference)Actor.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PerformerComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PerformerComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Function, otherT.Function)) return false;
                if( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PerformerComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Function, otherT.Function)) return false;
                if( !DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Function != null) yield return Function;
                    if (Actor != null) yield return Actor;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Function != null) yield return new ElementValue("function", false, Function);
                    if (Actor != null) yield return new ElementValue("actor", false, Actor);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "EducationComponent")]
        [DataContract]
        public partial class EducationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "EducationComponent"; } }
            
            /// <summary>
            /// Educational material document identifier
            /// </summary>
            [FhirElement("documentType", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DocumentTypeElement
            {
                get { return _DocumentTypeElement; }
                set { _DocumentTypeElement = value; OnPropertyChanged("DocumentTypeElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DocumentTypeElement;
            
            /// <summary>
            /// Educational material document identifier
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string DocumentType
            {
                get { return DocumentTypeElement != null ? DocumentTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentTypeElement = null;
                    else
                        DocumentTypeElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("DocumentType");
                }
            }
            
            /// <summary>
            /// Educational material reference pointer
            /// </summary>
            [FhirElement("reference", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri ReferenceElement
            {
                get { return _ReferenceElement; }
                set { _ReferenceElement = value; OnPropertyChanged("ReferenceElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _ReferenceElement;
            
            /// <summary>
            /// Educational material reference pointer
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Reference
            {
                get { return ReferenceElement != null ? ReferenceElement.Value : null; }
                set
                {
                    if (value == null)
                        ReferenceElement = null;
                    else
                        ReferenceElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Reference");
                }
            }
            
            /// <summary>
            /// Educational material publication date
            /// </summary>
            [FhirElement("publicationDate", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDateTime PublicationDateElement
            {
                get { return _PublicationDateElement; }
                set { _PublicationDateElement = value; OnPropertyChanged("PublicationDateElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDateTime _PublicationDateElement;
            
            /// <summary>
            /// Educational material publication date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string PublicationDate
            {
                get { return PublicationDateElement != null ? PublicationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        PublicationDateElement = null;
                    else
                        PublicationDateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                    OnPropertyChanged("PublicationDate");
                }
            }
            
            /// <summary>
            /// Educational material presentation date
            /// </summary>
            [FhirElement("presentationDate", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDateTime PresentationDateElement
            {
                get { return _PresentationDateElement; }
                set { _PresentationDateElement = value; OnPropertyChanged("PresentationDateElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDateTime _PresentationDateElement;
            
            /// <summary>
            /// Educational material presentation date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string PresentationDate
            {
                get { return PresentationDateElement != null ? PresentationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        PresentationDateElement = null;
                    else
                        PresentationDateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                    OnPropertyChanged("PresentationDate");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EducationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(DocumentTypeElement != null) dest.DocumentTypeElement = (Hl7.Fhir.Model.FhirString)DocumentTypeElement.DeepCopy();
                    if(ReferenceElement != null) dest.ReferenceElement = (Hl7.Fhir.Model.FhirUri)ReferenceElement.DeepCopy();
                    if(PublicationDateElement != null) dest.PublicationDateElement = (Hl7.Fhir.Model.R4.FhirDateTime)PublicationDateElement.DeepCopy();
                    if(PresentationDateElement != null) dest.PresentationDateElement = (Hl7.Fhir.Model.R4.FhirDateTime)PresentationDateElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EducationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EducationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(DocumentTypeElement, otherT.DocumentTypeElement)) return false;
                if( !DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;
                if( !DeepComparable.Matches(PublicationDateElement, otherT.PublicationDateElement)) return false;
                if( !DeepComparable.Matches(PresentationDateElement, otherT.PresentationDateElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EducationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(DocumentTypeElement, otherT.DocumentTypeElement)) return false;
                if( !DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;
                if( !DeepComparable.IsExactly(PublicationDateElement, otherT.PublicationDateElement)) return false;
                if( !DeepComparable.IsExactly(PresentationDateElement, otherT.PresentationDateElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DocumentTypeElement != null) yield return DocumentTypeElement;
                    if (ReferenceElement != null) yield return ReferenceElement;
                    if (PublicationDateElement != null) yield return PublicationDateElement;
                    if (PresentationDateElement != null) yield return PresentationDateElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DocumentTypeElement != null) yield return new ElementValue("documentType", false, DocumentTypeElement);
                    if (ReferenceElement != null) yield return new ElementValue("reference", false, ReferenceElement);
                    if (PublicationDateElement != null) yield return new ElementValue("publicationDate", false, PublicationDateElement);
                    if (PresentationDateElement != null) yield return new ElementValue("presentationDate", false, PresentationDateElement);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Business identifier
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
        /// completed | entered-in-error | not-done
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
        /// completed | entered-in-error | not-done
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
        /// Reason not done
        /// </summary>
        [FhirElement("statusReason", Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept StatusReason
        {
            get { return _StatusReason; }
            set { _StatusReason = value; OnPropertyChanged("StatusReason"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _StatusReason;
        
        /// <summary>
        /// Vaccine product administered
        /// </summary>
        [FhirElement("vaccineCode", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept VaccineCode
        {
            get { return _VaccineCode; }
            set { _VaccineCode = value; OnPropertyChanged("VaccineCode"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _VaccineCode;
        
        /// <summary>
        /// Who was immunized
        /// </summary>
        [FhirElement("patient", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Patient;
        
        /// <summary>
        /// Encounter immunization was part of
        /// </summary>
        [FhirElement("encounter", Order=140)]
        [CLSCompliant(false)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Encounter;
        
        /// <summary>
        /// Vaccine administration date
        /// </summary>
        [FhirElement("date", Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
        
        /// <summary>
        /// Vaccine administration date
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
        /// Indicates context the data was recorded in
        /// </summary>
        [FhirElement("primarySource", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean PrimarySourceElement
        {
            get { return _PrimarySourceElement; }
            set { _PrimarySourceElement = value; OnPropertyChanged("PrimarySourceElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _PrimarySourceElement;
        
        /// <summary>
        /// Indicates context the data was recorded in
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? PrimarySource
        {
            get { return PrimarySourceElement != null ? PrimarySourceElement.Value : null; }
            set
            {
                if (value == null)
                    PrimarySourceElement = null;
                else
                    PrimarySourceElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("PrimarySource");
            }
        }
        
        /// <summary>
        /// Indicates the source of a secondarily reported record
        /// </summary>
        [FhirElement("reportOrigin", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept ReportOrigin
        {
            get { return _ReportOrigin; }
            set { _ReportOrigin = value; OnPropertyChanged("ReportOrigin"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _ReportOrigin;
        
        /// <summary>
        /// Where immunization occurred
        /// </summary>
        [FhirElement("location", Order=180)]
        [CLSCompliant(false)]
        [References("Location")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Location
        {
            get { return _Location; }
            set { _Location = value; OnPropertyChanged("Location"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Location;
        
        /// <summary>
        /// Vaccine manufacturer
        /// </summary>
        [FhirElement("manufacturer", Order=190)]
        [CLSCompliant(false)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Manufacturer
        {
            get { return _Manufacturer; }
            set { _Manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Manufacturer;
        
        /// <summary>
        /// Vaccine lot number
        /// </summary>
        [FhirElement("lotNumber", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString LotNumberElement
        {
            get { return _LotNumberElement; }
            set { _LotNumberElement = value; OnPropertyChanged("LotNumberElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _LotNumberElement;
        
        /// <summary>
        /// Vaccine lot number
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string LotNumber
        {
            get { return LotNumberElement != null ? LotNumberElement.Value : null; }
            set
            {
                if (value == null)
                    LotNumberElement = null;
                else
                    LotNumberElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("LotNumber");
            }
        }
        
        /// <summary>
        /// Vaccine expiration date
        /// </summary>
        [FhirElement("expirationDate", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Date ExpirationDateElement
        {
            get { return _ExpirationDateElement; }
            set { _ExpirationDateElement = value; OnPropertyChanged("ExpirationDateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Date _ExpirationDateElement;
        
        /// <summary>
        /// Vaccine expiration date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string ExpirationDate
        {
            get { return ExpirationDateElement != null ? ExpirationDateElement.Value : null; }
            set
            {
                if (value == null)
                    ExpirationDateElement = null;
                else
                    ExpirationDateElement = new Hl7.Fhir.Model.R4.Date(value);
                OnPropertyChanged("ExpirationDate");
            }
        }
        
        /// <summary>
        /// Body site vaccine  was administered
        /// </summary>
        [FhirElement("site", Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Site
        {
            get { return _Site; }
            set { _Site = value; OnPropertyChanged("Site"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Site;
        
        /// <summary>
        /// How vaccine entered body
        /// </summary>
        [FhirElement("route", Order=230)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Route
        {
            get { return _Route; }
            set { _Route = value; OnPropertyChanged("Route"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Route;
        
        /// <summary>
        /// Amount of vaccine administered
        /// </summary>
        [FhirElement("doseQuantity", Order=240)]
        [DataMember]
        public Hl7.Fhir.Model.R4.SimpleQuantity DoseQuantity
        {
            get { return _DoseQuantity; }
            set { _DoseQuantity = value; OnPropertyChanged("DoseQuantity"); }
        }
        
        private Hl7.Fhir.Model.R4.SimpleQuantity _DoseQuantity;
        
        /// <summary>
        /// Who performed event
        /// </summary>
        [FhirElement("performer", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=250)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PerformerComponent> Performer
        {
            get { if(_Performer==null) _Performer = new List<PerformerComponent>(); return _Performer; }
            set { _Performer = value; OnPropertyChanged("Performer"); }
        }
        
        private List<PerformerComponent> _Performer;
        
        /// <summary>
        /// Additional immunization notes
        /// </summary>
        [FhirElement("note", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=260)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.R4.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Annotation> _Note;
        
        /// <summary>
        /// Why immunization occurred
        /// </summary>
        [FhirElement("reasonCode", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> ReasonCode
        {
            get { if(_ReasonCode==null) _ReasonCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _ReasonCode; }
            set { _ReasonCode = value; OnPropertyChanged("ReasonCode"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _ReasonCode;
        
        /// <summary>
        /// Why immunization occurred
        /// </summary>
        [FhirElement("reasonReference", Order=280)]
        [CLSCompliant(false)]
        [References("Condition","Observation","DiagnosticReport")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> ReasonReference
        {
            get { if(_ReasonReference==null) _ReasonReference = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _ReasonReference; }
            set { _ReasonReference = value; OnPropertyChanged("ReasonReference"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _ReasonReference;
        
        /// <summary>
        /// Dose potency
        /// </summary>
        [FhirElement("isPotent", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=290)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean IsPotentElement
        {
            get { return _IsPotentElement; }
            set { _IsPotentElement = value; OnPropertyChanged("IsPotentElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _IsPotentElement;
        
        /// <summary>
        /// Dose potency
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? IsPotent
        {
            get { return IsPotentElement != null ? IsPotentElement.Value : null; }
            set
            {
                if (value == null)
                    IsPotentElement = null;
                else
                    IsPotentElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("IsPotent");
            }
        }
        
        /// <summary>
        /// Reason for being subpotent
        /// </summary>
        [FhirElement("subpotentReason", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> SubpotentReason
        {
            get { if(_SubpotentReason==null) _SubpotentReason = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _SubpotentReason; }
            set { _SubpotentReason = value; OnPropertyChanged("SubpotentReason"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _SubpotentReason;
        
        /// <summary>
        /// Educational material presented to patient
        /// </summary>
        [FhirElement("education", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EducationComponent> Education
        {
            get { if(_Education==null) _Education = new List<EducationComponent>(); return _Education; }
            set { _Education = value; OnPropertyChanged("Education"); }
        }
        
        private List<EducationComponent> _Education;
        
        /// <summary>
        /// Patient eligibility for a vaccination program
        /// </summary>
        [FhirElement("programEligibility", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> ProgramEligibility
        {
            get { if(_ProgramEligibility==null) _ProgramEligibility = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _ProgramEligibility; }
            set { _ProgramEligibility = value; OnPropertyChanged("ProgramEligibility"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _ProgramEligibility;
        
        /// <summary>
        /// Funding source for the vaccine
        /// </summary>
        [FhirElement("fundingSource", Order=330)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept FundingSource
        {
            get { return _FundingSource; }
            set { _FundingSource = value; OnPropertyChanged("FundingSource"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _FundingSource;
    
    
        public static ElementDefinitionConstraint Immunization_IMM_1 = new ElementDefinitionConstraint
        {
            Expression = "education.all(documentType.exists() or reference.exists())",
            Key = "imm-1",
            Severity = ConstraintSeverity.Warning,
            Human = "One of documentType or reference SHALL be present",
            Xpath = "exists(f:documentType) or exists(f:reference)"
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
    
            InvariantConstraints.Add(Immunization_IMM_1);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Immunization;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(StatusReason != null) dest.StatusReason = (Hl7.Fhir.Model.R4.CodeableConcept)StatusReason.DeepCopy();
                if(VaccineCode != null) dest.VaccineCode = (Hl7.Fhir.Model.R4.CodeableConcept)VaccineCode.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.R4.ResourceReference)Patient.DeepCopy();
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.R4.ResourceReference)Encounter.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                if(PrimarySourceElement != null) dest.PrimarySourceElement = (Hl7.Fhir.Model.FhirBoolean)PrimarySourceElement.DeepCopy();
                if(ReportOrigin != null) dest.ReportOrigin = (Hl7.Fhir.Model.R4.CodeableConcept)ReportOrigin.DeepCopy();
                if(Location != null) dest.Location = (Hl7.Fhir.Model.R4.ResourceReference)Location.DeepCopy();
                if(Manufacturer != null) dest.Manufacturer = (Hl7.Fhir.Model.R4.ResourceReference)Manufacturer.DeepCopy();
                if(LotNumberElement != null) dest.LotNumberElement = (Hl7.Fhir.Model.FhirString)LotNumberElement.DeepCopy();
                if(ExpirationDateElement != null) dest.ExpirationDateElement = (Hl7.Fhir.Model.R4.Date)ExpirationDateElement.DeepCopy();
                if(Site != null) dest.Site = (Hl7.Fhir.Model.R4.CodeableConcept)Site.DeepCopy();
                if(Route != null) dest.Route = (Hl7.Fhir.Model.R4.CodeableConcept)Route.DeepCopy();
                if(DoseQuantity != null) dest.DoseQuantity = (Hl7.Fhir.Model.R4.SimpleQuantity)DoseQuantity.DeepCopy();
                if(Performer != null) dest.Performer = new List<PerformerComponent>(Performer.DeepCopy());
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.R4.Annotation>(Note.DeepCopy());
                if(ReasonCode != null) dest.ReasonCode = new List<Hl7.Fhir.Model.R4.CodeableConcept>(ReasonCode.DeepCopy());
                if(ReasonReference != null) dest.ReasonReference = new List<Hl7.Fhir.Model.R4.ResourceReference>(ReasonReference.DeepCopy());
                if(IsPotentElement != null) dest.IsPotentElement = (Hl7.Fhir.Model.FhirBoolean)IsPotentElement.DeepCopy();
                if(SubpotentReason != null) dest.SubpotentReason = new List<Hl7.Fhir.Model.R4.CodeableConcept>(SubpotentReason.DeepCopy());
                if(Education != null) dest.Education = new List<EducationComponent>(Education.DeepCopy());
                if(ProgramEligibility != null) dest.ProgramEligibility = new List<Hl7.Fhir.Model.R4.CodeableConcept>(ProgramEligibility.DeepCopy());
                if(FundingSource != null) dest.FundingSource = (Hl7.Fhir.Model.R4.CodeableConcept)FundingSource.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Immunization());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Immunization;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if( !DeepComparable.Matches(VaccineCode, otherT.VaccineCode)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(PrimarySourceElement, otherT.PrimarySourceElement)) return false;
            if( !DeepComparable.Matches(ReportOrigin, otherT.ReportOrigin)) return false;
            if( !DeepComparable.Matches(Location, otherT.Location)) return false;
            if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if( !DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if( !DeepComparable.Matches(Site, otherT.Site)) return false;
            if( !DeepComparable.Matches(Route, otherT.Route)) return false;
            if( !DeepComparable.Matches(DoseQuantity, otherT.DoseQuantity)) return false;
            if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.Matches(IsPotentElement, otherT.IsPotentElement)) return false;
            if( !DeepComparable.Matches(SubpotentReason, otherT.SubpotentReason)) return false;
            if( !DeepComparable.Matches(Education, otherT.Education)) return false;
            if( !DeepComparable.Matches(ProgramEligibility, otherT.ProgramEligibility)) return false;
            if( !DeepComparable.Matches(FundingSource, otherT.FundingSource)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Immunization;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if( !DeepComparable.IsExactly(VaccineCode, otherT.VaccineCode)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(PrimarySourceElement, otherT.PrimarySourceElement)) return false;
            if( !DeepComparable.IsExactly(ReportOrigin, otherT.ReportOrigin)) return false;
            if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if( !DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if( !DeepComparable.IsExactly(Site, otherT.Site)) return false;
            if( !DeepComparable.IsExactly(Route, otherT.Route)) return false;
            if( !DeepComparable.IsExactly(DoseQuantity, otherT.DoseQuantity)) return false;
            if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.IsExactly(IsPotentElement, otherT.IsPotentElement)) return false;
            if( !DeepComparable.IsExactly(SubpotentReason, otherT.SubpotentReason)) return false;
            if( !DeepComparable.IsExactly(Education, otherT.Education)) return false;
            if( !DeepComparable.IsExactly(ProgramEligibility, otherT.ProgramEligibility)) return false;
            if( !DeepComparable.IsExactly(FundingSource, otherT.FundingSource)) return false;
        
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
                if (StatusReason != null) yield return StatusReason;
                if (VaccineCode != null) yield return VaccineCode;
                if (Patient != null) yield return Patient;
                if (Encounter != null) yield return Encounter;
                if (DateElement != null) yield return DateElement;
                if (PrimarySourceElement != null) yield return PrimarySourceElement;
                if (ReportOrigin != null) yield return ReportOrigin;
                if (Location != null) yield return Location;
                if (Manufacturer != null) yield return Manufacturer;
                if (LotNumberElement != null) yield return LotNumberElement;
                if (ExpirationDateElement != null) yield return ExpirationDateElement;
                if (Site != null) yield return Site;
                if (Route != null) yield return Route;
                if (DoseQuantity != null) yield return DoseQuantity;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                if (IsPotentElement != null) yield return IsPotentElement;
                foreach (var elem in SubpotentReason) { if (elem != null) yield return elem; }
                foreach (var elem in Education) { if (elem != null) yield return elem; }
                foreach (var elem in ProgramEligibility) { if (elem != null) yield return elem; }
                if (FundingSource != null) yield return FundingSource;
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
                if (StatusReason != null) yield return new ElementValue("statusReason", false, StatusReason);
                if (VaccineCode != null) yield return new ElementValue("vaccineCode", false, VaccineCode);
                if (Patient != null) yield return new ElementValue("patient", false, Patient);
                if (Encounter != null) yield return new ElementValue("encounter", false, Encounter);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (PrimarySourceElement != null) yield return new ElementValue("primarySource", false, PrimarySourceElement);
                if (ReportOrigin != null) yield return new ElementValue("reportOrigin", false, ReportOrigin);
                if (Location != null) yield return new ElementValue("location", false, Location);
                if (Manufacturer != null) yield return new ElementValue("manufacturer", false, Manufacturer);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", false, LotNumberElement);
                if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", false, ExpirationDateElement);
                if (Site != null) yield return new ElementValue("site", false, Site);
                if (Route != null) yield return new ElementValue("route", false, Route);
                if (DoseQuantity != null) yield return new ElementValue("doseQuantity", false, DoseQuantity);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", true, elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", true, elem); }
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", true, elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", true, elem); }
                if (IsPotentElement != null) yield return new ElementValue("isPotent", false, IsPotentElement);
                foreach (var elem in SubpotentReason) { if (elem != null) yield return new ElementValue("subpotentReason", true, elem); }
                foreach (var elem in Education) { if (elem != null) yield return new ElementValue("education", true, elem); }
                foreach (var elem in ProgramEligibility) { if (elem != null) yield return new ElementValue("programEligibility", true, elem); }
                if (FundingSource != null) yield return new ElementValue("fundingSource", false, FundingSource);
            }
        }
    
    }

}
