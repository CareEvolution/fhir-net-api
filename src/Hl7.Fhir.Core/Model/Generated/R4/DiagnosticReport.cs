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
    /// A Diagnostic report - a combination of request information, atomic results, images, interpretation, as well as formatted reports
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "DiagnosticReport", IsResource=true)]
    [DataContract]
    public partial class DiagnosticReport : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DiagnosticReport; } }
        [NotMapped]
        public override string TypeName { get { return "DiagnosticReport"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "MediaComponent")]
        [DataContract]
        public partial class MediaComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "MediaComponent"; } }
            
            /// <summary>
            /// Comment about the image (e.g. explanation)
            /// </summary>
            [FhirElement("comment", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString CommentElement
            {
                get { return _CommentElement; }
                set { _CommentElement = value; OnPropertyChanged("CommentElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _CommentElement;
            
            /// <summary>
            /// Comment about the image (e.g. explanation)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Comment
            {
                get { return CommentElement != null ? CommentElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentElement = null;
                    else
                        CommentElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Comment");
                }
            }
            
            /// <summary>
            /// Reference to the image source
            /// </summary>
            [FhirElement("link", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [References("Media")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Link
            {
                get { return _Link; }
                set { _Link = value; OnPropertyChanged("Link"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Link;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MediaComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CommentElement != null) dest.CommentElement = (Hl7.Fhir.Model.FhirString)CommentElement.DeepCopy();
                    if(Link != null) dest.Link = (Hl7.Fhir.Model.R4.ResourceReference)Link.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MediaComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MediaComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
                if( !DeepComparable.Matches(Link, otherT.Link)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MediaComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
                if( !DeepComparable.IsExactly(Link, otherT.Link)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CommentElement != null) yield return CommentElement;
                    if (Link != null) yield return Link;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CommentElement != null) yield return new ElementValue("comment", false, CommentElement);
                    if (Link != null) yield return new ElementValue("link", false, Link);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Business identifier for report
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
        /// What was requested
        /// </summary>
        [FhirElement("basedOn", Order=100)]
        [CLSCompliant(false)]
        [References("CarePlan","ImmunizationRecommendation","MedicationRequest","NutritionOrder","ServiceRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> BasedOn
        {
            get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _BasedOn; }
            set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _BasedOn;
        
        /// <summary>
        /// registered | partial | preliminary | final +
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
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
        /// registered | partial | preliminary | final +
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
        /// Service category
        /// </summary>
        [FhirElement("category", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Category
        {
            get { return _Category; }
            set { _Category = value; OnPropertyChanged("Category"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Category;
        
        /// <summary>
        /// Name/Code for this diagnostic report
        /// </summary>
        [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Code;
        
        /// <summary>
        /// The subject of the report - usually, but not always, the patient
        /// </summary>
        [FhirElement("subject", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [References("Patient","Group","Device","Location")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Subject;
        
        /// <summary>
        /// Health care event when test ordered
        /// </summary>
        [FhirElement("context", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
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
        /// Clinically relevant time/time-period for report
        /// </summary>
        [FhirElement("effective", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.R4.FhirDateTime),typeof(Hl7.Fhir.Model.R4.Period))]
        [DataMember]
        public Hl7.Fhir.Model.Element Effective
        {
            get { return _Effective; }
            set { _Effective = value; OnPropertyChanged("Effective"); }
        }
        
        private Hl7.Fhir.Model.Element _Effective;
        
        /// <summary>
        /// DateTime this version was made
        /// </summary>
        [FhirElement("issued", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.Instant IssuedElement
        {
            get { return _IssuedElement; }
            set { _IssuedElement = value; OnPropertyChanged("IssuedElement"); }
        }
        
        private Hl7.Fhir.Model.Instant _IssuedElement;
        
        /// <summary>
        /// DateTime this version was made
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public DateTimeOffset? Issued
        {
            get { return IssuedElement != null ? IssuedElement.Value : null; }
            set
            {
                if (value == null)
                    IssuedElement = null;
                else
                    IssuedElement = new Hl7.Fhir.Model.Instant(value);
                OnPropertyChanged("Issued");
            }
        }
        
        /// <summary>
        /// Responsible Diagnostic Service
        /// </summary>
        [FhirElement("performer", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Organization","CareTeam")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Performer
        {
            get { if(_Performer==null) _Performer = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Performer; }
            set { _Performer = value; OnPropertyChanged("Performer"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Performer;
        
        /// <summary>
        /// Primary result interpreter
        /// </summary>
        [FhirElement("resultsInterpreter", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Organization","CareTeam")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> ResultsInterpreter
        {
            get { if(_ResultsInterpreter==null) _ResultsInterpreter = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _ResultsInterpreter; }
            set { _ResultsInterpreter = value; OnPropertyChanged("ResultsInterpreter"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _ResultsInterpreter;
        
        /// <summary>
        /// Specimens this report is based on
        /// </summary>
        [FhirElement("specimen", Order=200)]
        [CLSCompliant(false)]
        [References("Specimen")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Specimen
        {
            get { if(_Specimen==null) _Specimen = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Specimen; }
            set { _Specimen = value; OnPropertyChanged("Specimen"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Specimen;
        
        /// <summary>
        /// Observations - simple, or complex nested groups
        /// </summary>
        [FhirElement("result", Order=210)]
        [CLSCompliant(false)]
        [References("Observation")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Result
        {
            get { if(_Result==null) _Result = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Result; }
            set { _Result = value; OnPropertyChanged("Result"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Result;
        
        /// <summary>
        /// Reference to full details of imaging associated with the diagnostic report
        /// </summary>
        [FhirElement("imagingStudy", Order=220)]
        [CLSCompliant(false)]
        [References("ImagingStudy")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> ImagingStudy
        {
            get { if(_ImagingStudy==null) _ImagingStudy = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _ImagingStudy; }
            set { _ImagingStudy = value; OnPropertyChanged("ImagingStudy"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _ImagingStudy;
        
        /// <summary>
        /// Key images associated with this report
        /// </summary>
        [FhirElement("media", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=230)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MediaComponent> Media
        {
            get { if(_Media==null) _Media = new List<MediaComponent>(); return _Media; }
            set { _Media = value; OnPropertyChanged("Media"); }
        }
        
        private List<MediaComponent> _Media;
        
        /// <summary>
        /// Clinical Interpretation of test results
        /// </summary>
        [FhirElement("conclusion", Order=240)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString ConclusionElement
        {
            get { return _ConclusionElement; }
            set { _ConclusionElement = value; OnPropertyChanged("ConclusionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _ConclusionElement;
        
        /// <summary>
        /// Clinical Interpretation of test results
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Conclusion
        {
            get { return ConclusionElement != null ? ConclusionElement.Value : null; }
            set
            {
                if (value == null)
                    ConclusionElement = null;
                else
                    ConclusionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Conclusion");
            }
        }
        
        /// <summary>
        /// Codes for the conclusion
        /// </summary>
        [FhirElement("codedDiagnosis", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.CodeableConcept> CodedDiagnosis
        {
            get { if(_CodedDiagnosis==null) _CodedDiagnosis = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _CodedDiagnosis; }
            set { _CodedDiagnosis = value; OnPropertyChanged("CodedDiagnosis"); }
        }
        
        private List<Hl7.Fhir.Model.R4.CodeableConcept> _CodedDiagnosis;
        
        /// <summary>
        /// Entire report as issued
        /// </summary>
        [FhirElement("presentedForm", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Attachment> PresentedForm
        {
            get { if(_PresentedForm==null) _PresentedForm = new List<Hl7.Fhir.Model.R4.Attachment>(); return _PresentedForm; }
            set { _PresentedForm = value; OnPropertyChanged("PresentedForm"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Attachment> _PresentedForm;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DiagnosticReport;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.R4.ResourceReference>(BasedOn.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(Category != null) dest.Category = (Hl7.Fhir.Model.R4.CodeableConcept)Category.DeepCopy();
                if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.R4.ResourceReference)Subject.DeepCopy();
                if(Context != null) dest.Context = (Hl7.Fhir.Model.R4.ResourceReference)Context.DeepCopy();
                if(Effective != null) dest.Effective = (Hl7.Fhir.Model.Element)Effective.DeepCopy();
                if(IssuedElement != null) dest.IssuedElement = (Hl7.Fhir.Model.Instant)IssuedElement.DeepCopy();
                if(Performer != null) dest.Performer = new List<Hl7.Fhir.Model.R4.ResourceReference>(Performer.DeepCopy());
                if(ResultsInterpreter != null) dest.ResultsInterpreter = new List<Hl7.Fhir.Model.R4.ResourceReference>(ResultsInterpreter.DeepCopy());
                if(Specimen != null) dest.Specimen = new List<Hl7.Fhir.Model.R4.ResourceReference>(Specimen.DeepCopy());
                if(Result != null) dest.Result = new List<Hl7.Fhir.Model.R4.ResourceReference>(Result.DeepCopy());
                if(ImagingStudy != null) dest.ImagingStudy = new List<Hl7.Fhir.Model.R4.ResourceReference>(ImagingStudy.DeepCopy());
                if(Media != null) dest.Media = new List<MediaComponent>(Media.DeepCopy());
                if(ConclusionElement != null) dest.ConclusionElement = (Hl7.Fhir.Model.FhirString)ConclusionElement.DeepCopy();
                if(CodedDiagnosis != null) dest.CodedDiagnosis = new List<Hl7.Fhir.Model.R4.CodeableConcept>(CodedDiagnosis.DeepCopy());
                if(PresentedForm != null) dest.PresentedForm = new List<Hl7.Fhir.Model.R4.Attachment>(PresentedForm.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new DiagnosticReport());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DiagnosticReport;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Context, otherT.Context)) return false;
            if( !DeepComparable.Matches(Effective, otherT.Effective)) return false;
            if( !DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if( !DeepComparable.Matches(ResultsInterpreter, otherT.ResultsInterpreter)) return false;
            if( !DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if( !DeepComparable.Matches(Result, otherT.Result)) return false;
            if( !DeepComparable.Matches(ImagingStudy, otherT.ImagingStudy)) return false;
            if( !DeepComparable.Matches(Media, otherT.Media)) return false;
            if( !DeepComparable.Matches(ConclusionElement, otherT.ConclusionElement)) return false;
            if( !DeepComparable.Matches(CodedDiagnosis, otherT.CodedDiagnosis)) return false;
            if( !DeepComparable.Matches(PresentedForm, otherT.PresentedForm)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DiagnosticReport;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if( !DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
            if( !DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if( !DeepComparable.IsExactly(ResultsInterpreter, otherT.ResultsInterpreter)) return false;
            if( !DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if( !DeepComparable.IsExactly(Result, otherT.Result)) return false;
            if( !DeepComparable.IsExactly(ImagingStudy, otherT.ImagingStudy)) return false;
            if( !DeepComparable.IsExactly(Media, otherT.Media)) return false;
            if( !DeepComparable.IsExactly(ConclusionElement, otherT.ConclusionElement)) return false;
            if( !DeepComparable.IsExactly(CodedDiagnosis, otherT.CodedDiagnosis)) return false;
            if( !DeepComparable.IsExactly(PresentedForm, otherT.PresentedForm)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (Category != null) yield return Category;
                if (Code != null) yield return Code;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Effective != null) yield return Effective;
                if (IssuedElement != null) yield return IssuedElement;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                foreach (var elem in ResultsInterpreter) { if (elem != null) yield return elem; }
                foreach (var elem in Specimen) { if (elem != null) yield return elem; }
                foreach (var elem in Result) { if (elem != null) yield return elem; }
                foreach (var elem in ImagingStudy) { if (elem != null) yield return elem; }
                foreach (var elem in Media) { if (elem != null) yield return elem; }
                if (ConclusionElement != null) yield return ConclusionElement;
                foreach (var elem in CodedDiagnosis) { if (elem != null) yield return elem; }
                foreach (var elem in PresentedForm) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (Category != null) yield return new ElementValue("category", false, Category);
                if (Code != null) yield return new ElementValue("code", false, Code);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (Context != null) yield return new ElementValue("context", false, Context);
                if (Effective != null) yield return new ElementValue("effective", false, Effective);
                if (IssuedElement != null) yield return new ElementValue("issued", false, IssuedElement);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", true, elem); }
                foreach (var elem in ResultsInterpreter) { if (elem != null) yield return new ElementValue("resultsInterpreter", true, elem); }
                foreach (var elem in Specimen) { if (elem != null) yield return new ElementValue("specimen", true, elem); }
                foreach (var elem in Result) { if (elem != null) yield return new ElementValue("result", true, elem); }
                foreach (var elem in ImagingStudy) { if (elem != null) yield return new ElementValue("imagingStudy", true, elem); }
                foreach (var elem in Media) { if (elem != null) yield return new ElementValue("media", true, elem); }
                if (ConclusionElement != null) yield return new ElementValue("conclusion", false, ConclusionElement);
                foreach (var elem in CodedDiagnosis) { if (elem != null) yield return new ElementValue("codedDiagnosis", true, elem); }
                foreach (var elem in PresentedForm) { if (elem != null) yield return new ElementValue("presentedForm", true, elem); }
            }
        }
    
    }

}
