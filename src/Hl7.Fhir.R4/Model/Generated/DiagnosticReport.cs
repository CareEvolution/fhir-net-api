using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using Hl7.Fhir.Validation.R4;
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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A Diagnostic report - a combination of request information, atomic results, images, interpretation, as well as formatted reports
    /// </summary>
    [FhirType("DiagnosticReport", IsResource=true)]
    [DataContract]
    public partial class DiagnosticReport : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DiagnosticReport; } }
        [NotMapped]
        public override string TypeName { get { return "DiagnosticReport"; } }

        /// <summary>
        /// The status of the diagnostic report.
        /// (url: http://hl7.org/fhir/ValueSet/diagnostic-report-status)
        /// </summary>
        [FhirEnumeration("DiagnosticReportStatus")]
        public enum DiagnosticReportStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("registered", "http://hl7.org/fhir/diagnostic-report-status"), Description("Registered")]
            Registered,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("partial", "http://hl7.org/fhir/diagnostic-report-status"), Description("Partial")]
            Partial,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("preliminary", "http://hl7.org/fhir/diagnostic-report-status"), Description("Preliminary")]
            Preliminary,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("final", "http://hl7.org/fhir/diagnostic-report-status"), Description("Final")]
            Final,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("amended", "http://hl7.org/fhir/diagnostic-report-status"), Description("Amended")]
            Amended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("corrected", "http://hl7.org/fhir/diagnostic-report-status"), Description("Corrected")]
            Corrected,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("appended", "http://hl7.org/fhir/diagnostic-report-status"), Description("Appended")]
            Appended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/diagnostic-report-status"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/diagnostic-report-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("unknown", "http://hl7.org/fhir/diagnostic-report-status"), Description("Unknown")]
            Unknown,
        }


        [FhirType("MediaComponent")]
        [DataContract]
        public partial class MediaComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MediaComponent"; } }

            /// <summary>
            /// Comment about the image (e.g. explanation)
            /// </summary>
            [FhirElement("comment", Order=40)]
            [DataMember]
            public FhirString CommentElement
            {
                get { return _commentElement; }
                set { _commentElement = value; OnPropertyChanged("CommentElement"); }
            }

            private FhirString _commentElement;

            /// <summary>
            /// Comment about the image (e.g. explanation)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Comment
            {
                get { return CommentElement != null ? CommentElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentElement = null;
                    else
                        CommentElement = new FhirString(value);
                    OnPropertyChanged("Comment");
                }
            }

            /// <summary>
            /// Reference to the image source
            /// </summary>
            [FhirElement("link", InSummary=true, Order=50)]
            [References("Media")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Link
            {
                get { return _link; }
                set { _link = value; OnPropertyChanged("Link"); }
            }

            private ResourceReference _link;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MediaComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                    if (Link != null) dest.Link = (ResourceReference)Link.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
                if (!DeepComparable.Matches(Link, otherT.Link)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MediaComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
                if (!DeepComparable.IsExactly(Link, otherT.Link)) return false;

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
                    if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                    if (Link != null) yield return new ElementValue("link", Link);
                }
            }


        }


        /// <summary>
        /// Business identifier for report
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// What was requested
        /// </summary>
        [FhirElement("basedOn", Order=100)]
        [References("CarePlan","ImmunizationRecommendation","MedicationRequest","NutritionOrder","ServiceRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// registered | partial | preliminary | final +
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<DiagnosticReportStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<DiagnosticReportStatus> _statusElement;

        /// <summary>
        /// registered | partial | preliminary | final +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DiagnosticReportStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<DiagnosticReportStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Service category
        /// </summary>
        [FhirElement("category", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// Name/Code for this diagnostic report
        /// </summary>
        [FhirElement("code", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// The subject of the report - usually, but not always, the patient
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=140)]
        [References("Patient","Group","Device","Location")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Health care event when test ordered
        /// </summary>
        [FhirElement("context", InSummary=true, Order=150)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// Clinically relevant time/time-period for report
        /// </summary>
        [FhirElement("effective", InSummary=true, Order=160, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [DataMember]
        public Element Effective
        {
            get { return _effective; }
            set { _effective = value; OnPropertyChanged("Effective"); }
        }

        private Element _effective;

        /// <summary>
        /// DateTime this version was made
        /// </summary>
        [FhirElement("issued", InSummary=true, Order=170)]
        [DataMember]
        public Instant IssuedElement
        {
            get { return _issuedElement; }
            set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
        }

        private Instant _issuedElement;

        /// <summary>
        /// DateTime this version was made
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? Issued
        {
            get { return IssuedElement != null ? IssuedElement.Value : null; }
            set
            {
                if (value == null)
                    IssuedElement = null;
                else
                    IssuedElement = new Instant(value);
                OnPropertyChanged("Issued");
            }
        }

        /// <summary>
        /// Responsible Diagnostic Service
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=180)]
        [References("Practitioner","PractitionerRole","Organization","CareTeam")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Performer
        {
            get { if (_performer==null) _performer = new List<ResourceReference>(); return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private List<ResourceReference> _performer;

        /// <summary>
        /// Primary result interpreter
        /// </summary>
        [FhirElement("resultsInterpreter", InSummary=true, Order=190)]
        [References("Practitioner","PractitionerRole","Organization","CareTeam")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ResultsInterpreter
        {
            get { if (_resultsInterpreter==null) _resultsInterpreter = new List<ResourceReference>(); return _resultsInterpreter; }
            set { _resultsInterpreter = value; OnPropertyChanged("ResultsInterpreter"); }
        }

        private List<ResourceReference> _resultsInterpreter;

        /// <summary>
        /// Specimens this report is based on
        /// </summary>
        [FhirElement("specimen", Order=200)]
        [References("Specimen")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Specimen
        {
            get { if (_specimen==null) _specimen = new List<ResourceReference>(); return _specimen; }
            set { _specimen = value; OnPropertyChanged("Specimen"); }
        }

        private List<ResourceReference> _specimen;

        /// <summary>
        /// Observations
        /// </summary>
        [FhirElement("result", Order=210)]
        [References("Observation")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Result
        {
            get { if (_result==null) _result = new List<ResourceReference>(); return _result; }
            set { _result = value; OnPropertyChanged("Result"); }
        }

        private List<ResourceReference> _result;

        /// <summary>
        /// Reference to full details of imaging associated with the diagnostic report
        /// </summary>
        [FhirElement("imagingStudy", Order=220)]
        [References("ImagingStudy")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ImagingStudy
        {
            get { if (_imagingStudy==null) _imagingStudy = new List<ResourceReference>(); return _imagingStudy; }
            set { _imagingStudy = value; OnPropertyChanged("ImagingStudy"); }
        }

        private List<ResourceReference> _imagingStudy;

        /// <summary>
        /// Key images associated with this report
        /// </summary>
        [FhirElement("media", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MediaComponent> Media
        {
            get { if (_media==null) _media = new List<MediaComponent>(); return _media; }
            set { _media = value; OnPropertyChanged("Media"); }
        }

        private List<MediaComponent> _media;

        /// <summary>
        /// Clinical conclusion (interpretation) of test results
        /// </summary>
        [FhirElement("conclusion", Order=240)]
        [DataMember]
        public FhirString ConclusionElement
        {
            get { return _conclusionElement; }
            set { _conclusionElement = value; OnPropertyChanged("ConclusionElement"); }
        }

        private FhirString _conclusionElement;

        /// <summary>
        /// Clinical conclusion (interpretation) of test results
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Conclusion
        {
            get { return ConclusionElement != null ? ConclusionElement.Value : null; }
            set
            {
                if (value == null)
                    ConclusionElement = null;
                else
                    ConclusionElement = new FhirString(value);
                OnPropertyChanged("Conclusion");
            }
        }

        /// <summary>
        /// Codes for the clinical conclusion of test results
        /// </summary>
        [FhirElement("conclusionCode", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ConclusionCode
        {
            get { if (_conclusionCode==null) _conclusionCode = new List<CodeableConcept>(); return _conclusionCode; }
            set { _conclusionCode = value; OnPropertyChanged("ConclusionCode"); }
        }

        private List<CodeableConcept> _conclusionCode;

        /// <summary>
        /// Entire report as issued
        /// </summary>
        [FhirElement("presentedForm", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Attachment> PresentedForm
        {
            get { if (_presentedForm==null) _presentedForm = new List<Attachment>(); return _presentedForm; }
            set { _presentedForm = value; OnPropertyChanged("PresentedForm"); }
        }

        private List<Attachment> _presentedForm;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DiagnosticReport;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<DiagnosticReportStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Effective != null) dest.Effective = (Element)Effective.DeepCopy();
                if (IssuedElement != null) dest.IssuedElement = (Instant)IssuedElement.DeepCopy();
                if (Performer != null) dest.Performer = new List<ResourceReference>(Performer.DeepCopy());
                if (ResultsInterpreter != null) dest.ResultsInterpreter = new List<ResourceReference>(ResultsInterpreter.DeepCopy());
                if (Specimen != null) dest.Specimen = new List<ResourceReference>(Specimen.DeepCopy());
                if (Result != null) dest.Result = new List<ResourceReference>(Result.DeepCopy());
                if (ImagingStudy != null) dest.ImagingStudy = new List<ResourceReference>(ImagingStudy.DeepCopy());
                if (Media != null) dest.Media = new List<MediaComponent>(Media.DeepCopy());
                if (ConclusionElement != null) dest.ConclusionElement = (FhirString)ConclusionElement.DeepCopy();
                if (ConclusionCode != null) dest.ConclusionCode = new List<CodeableConcept>(ConclusionCode.DeepCopy());
                if (PresentedForm != null) dest.PresentedForm = new List<Attachment>(PresentedForm.DeepCopy());
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
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;
            if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if ( !DeepComparable.Matches(ResultsInterpreter, otherT.ResultsInterpreter)) return false;
            if ( !DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if ( !DeepComparable.Matches(Result, otherT.Result)) return false;
            if ( !DeepComparable.Matches(ImagingStudy, otherT.ImagingStudy)) return false;
            if ( !DeepComparable.Matches(Media, otherT.Media)) return false;
            if (!DeepComparable.Matches(ConclusionElement, otherT.ConclusionElement)) return false;
            if ( !DeepComparable.Matches(ConclusionCode, otherT.ConclusionCode)) return false;
            if ( !DeepComparable.Matches(PresentedForm, otherT.PresentedForm)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DiagnosticReport;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
            if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(ResultsInterpreter, otherT.ResultsInterpreter)) return false;
            if (!DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.IsExactly(Result, otherT.Result)) return false;
            if (!DeepComparable.IsExactly(ImagingStudy, otherT.ImagingStudy)) return false;
            if (!DeepComparable.IsExactly(Media, otherT.Media)) return false;
            if (!DeepComparable.IsExactly(ConclusionElement, otherT.ConclusionElement)) return false;
            if (!DeepComparable.IsExactly(ConclusionCode, otherT.ConclusionCode)) return false;
            if (!DeepComparable.IsExactly(PresentedForm, otherT.PresentedForm)) return false;

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
                foreach (var elem in ConclusionCode) { if (elem != null) yield return elem; }
                foreach (var elem in PresentedForm) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Category != null) yield return new ElementValue("category", Category);
                if (Code != null) yield return new ElementValue("code", Code);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Effective != null) yield return new ElementValue("effective", Effective);
                if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                foreach (var elem in ResultsInterpreter) { if (elem != null) yield return new ElementValue("resultsInterpreter", elem); }
                foreach (var elem in Specimen) { if (elem != null) yield return new ElementValue("specimen", elem); }
                foreach (var elem in Result) { if (elem != null) yield return new ElementValue("result", elem); }
                foreach (var elem in ImagingStudy) { if (elem != null) yield return new ElementValue("imagingStudy", elem); }
                foreach (var elem in Media) { if (elem != null) yield return new ElementValue("media", elem); }
                if (ConclusionElement != null) yield return new ElementValue("conclusion", ConclusionElement);
                foreach (var elem in ConclusionCode) { if (elem != null) yield return new ElementValue("conclusionCode", elem); }
                foreach (var elem in PresentedForm) { if (elem != null) yield return new ElementValue("presentedForm", elem); }
            }
        }

    }

}
