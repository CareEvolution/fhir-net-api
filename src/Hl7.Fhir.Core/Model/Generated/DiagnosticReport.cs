using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using Hl7.Fhir.Validation.DSTU2;
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
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
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
        /// The status of the diagnostic report as a whole.
        /// (url: http://hl7.org/fhir/ValueSet/diagnostic-report-status)
        /// </summary>
        [FhirEnumeration("DiagnosticReportStatus")]
        public enum DiagnosticReportStatus
        {
            /// <summary>
            /// The existence of the report is registered, but there is nothing yet available.
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("registered", "http://hl7.org/fhir/diagnostic-report-status"), Description("Registered")]
            Registered,
            /// <summary>
            /// This is a partial (e.g. initial, interim or preliminary) report: data in the report may be incomplete or unverified.
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("partial", "http://hl7.org/fhir/diagnostic-report-status"), Description("Partial")]
            Partial,
            /// <summary>
            /// The report is complete and verified by an authorized person.
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("final", "http://hl7.org/fhir/diagnostic-report-status"), Description("Final")]
            Final,
            /// <summary>
            /// The report has been modified subsequent to being Final, and is complete and verified by an authorized person. New content has been added, but existing content hasn't changed
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("corrected", "http://hl7.org/fhir/diagnostic-report-status"), Description("Corrected")]
            Corrected,
            /// <summary>
            /// The report has been modified subsequent to being Final, and is complete and verified by an authorized person. New content has been added, but existing content hasn't changed.
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("appended", "http://hl7.org/fhir/diagnostic-report-status"), Description("Appended")]
            Appended,
            /// <summary>
            /// The report is unavailable because the measurement was not started or not completed (also sometimes called "aborted").
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/diagnostic-report-status"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// The report has been withdrawn following a previous final release.
            /// (system: http://hl7.org/fhir/diagnostic-report-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/diagnostic-report-status"), Description("Entered in Error")]
            EnteredInError,
        }


        [FhirType("ImageComponent")]
        [DataContract]
        public partial class ImageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ImageComponent"; } }

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
                var dest = other as ImageComponent;

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
                 return CopyTo(new ImageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ImageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
                if (!DeepComparable.Matches(Link, otherT.Link)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ImageComponent;
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
        /// Id for external references to this report
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
        /// registered | partial | final | corrected | appended | cancelled | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<DiagnosticReportStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<DiagnosticReportStatus> _statusElement;

        /// <summary>
        /// registered | partial | final | corrected | appended | cancelled | entered-in-error
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
        [FhirElement("category", InSummary=true, Order=110)]
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
        [FhirElement("code", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// The subject of the report, usually, but not always, the patient
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=130)]
        [References("Patient","Group","Device","Location")]
        [Cardinality(Min=1,Max=1)]
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
        [FhirElement("encounter", InSummary=true, Order=140)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Clinically Relevant time/time-period for report
        /// </summary>
        [FhirElement("effective", InSummary=true, Order=150, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Effective
        {
            get { return _effective; }
            set { _effective = value; OnPropertyChanged("Effective"); }
        }

        private Element _effective;

        /// <summary>
        /// DateTime this version was released
        /// </summary>
        [FhirElement("issued", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Instant IssuedElement
        {
            get { return _issuedElement; }
            set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
        }

        private Instant _issuedElement;

        /// <summary>
        /// DateTime this version was released
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
        [FhirElement("performer", InSummary=true, Order=170)]
        [References("Practitioner","Organization")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Performer
        {
            get { return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private ResourceReference _performer;

        /// <summary>
        /// What was requested
        /// </summary>
        [FhirElement("request", Order=180)]
        [References("DiagnosticOrder","ProcedureRequest","ReferralRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Request
        {
            get { if (_request==null) _request = new List<ResourceReference>(); return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private List<ResourceReference> _request;

        /// <summary>
        /// Specimens this report is based on
        /// </summary>
        [FhirElement("specimen", Order=190)]
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
        /// Observations - simple, or complex nested groups
        /// </summary>
        [FhirElement("result", Order=200)]
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
        [FhirElement("imagingStudy", Order=210)]
        [References("ImagingStudy","ImagingObjectSelection")]
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
        [FhirElement("image", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ImageComponent> Image
        {
            get { if (_image==null) _image = new List<ImageComponent>(); return _image; }
            set { _image = value; OnPropertyChanged("Image"); }
        }

        private List<ImageComponent> _image;

        /// <summary>
        /// Clinical Interpretation of test results
        /// </summary>
        [FhirElement("conclusion", Order=230)]
        [DataMember]
        public FhirString ConclusionElement
        {
            get { return _conclusionElement; }
            set { _conclusionElement = value; OnPropertyChanged("ConclusionElement"); }
        }

        private FhirString _conclusionElement;

        /// <summary>
        /// Clinical Interpretation of test results
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
        /// Codes for the conclusion
        /// </summary>
        [FhirElement("codedDiagnosis", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> CodedDiagnosis
        {
            get { if (_codedDiagnosis==null) _codedDiagnosis = new List<CodeableConcept>(); return _codedDiagnosis; }
            set { _codedDiagnosis = value; OnPropertyChanged("CodedDiagnosis"); }
        }

        private List<CodeableConcept> _codedDiagnosis;

        /// <summary>
        /// Entire report as issued
        /// </summary>
        [FhirElement("presentedForm", Order=250)]
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
                if (StatusElement != null) dest.StatusElement = (Code<DiagnosticReportStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Effective != null) dest.Effective = (Element)Effective.DeepCopy();
                if (IssuedElement != null) dest.IssuedElement = (Instant)IssuedElement.DeepCopy();
                if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                if (Request != null) dest.Request = new List<ResourceReference>(Request.DeepCopy());
                if (Specimen != null) dest.Specimen = new List<ResourceReference>(Specimen.DeepCopy());
                if (Result != null) dest.Result = new List<ResourceReference>(Result.DeepCopy());
                if (ImagingStudy != null) dest.ImagingStudy = new List<ResourceReference>(ImagingStudy.DeepCopy());
                if (Image != null) dest.Image = new List<ImageComponent>(Image.DeepCopy());
                if (ConclusionElement != null) dest.ConclusionElement = (FhirString)ConclusionElement.DeepCopy();
                if (CodedDiagnosis != null) dest.CodedDiagnosis = new List<CodeableConcept>(CodedDiagnosis.DeepCopy());
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
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;
            if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if ( !DeepComparable.Matches(Request, otherT.Request)) return false;
            if ( !DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if ( !DeepComparable.Matches(Result, otherT.Result)) return false;
            if ( !DeepComparable.Matches(ImagingStudy, otherT.ImagingStudy)) return false;
            if ( !DeepComparable.Matches(Image, otherT.Image)) return false;
            if (!DeepComparable.Matches(ConclusionElement, otherT.ConclusionElement)) return false;
            if ( !DeepComparable.Matches(CodedDiagnosis, otherT.CodedDiagnosis)) return false;
            if ( !DeepComparable.Matches(PresentedForm, otherT.PresentedForm)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DiagnosticReport;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
            if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.IsExactly(Result, otherT.Result)) return false;
            if (!DeepComparable.IsExactly(ImagingStudy, otherT.ImagingStudy)) return false;
            if (!DeepComparable.IsExactly(Image, otherT.Image)) return false;
            if (!DeepComparable.IsExactly(ConclusionElement, otherT.ConclusionElement)) return false;
            if (!DeepComparable.IsExactly(CodedDiagnosis, otherT.CodedDiagnosis)) return false;
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
                if (StatusElement != null) yield return StatusElement;
                if (Category != null) yield return Category;
                if (Code != null) yield return Code;
                if (Subject != null) yield return Subject;
                if (Encounter != null) yield return Encounter;
                if (Effective != null) yield return Effective;
                if (IssuedElement != null) yield return IssuedElement;
                if (Performer != null) yield return Performer;
                foreach (var elem in Request) { if (elem != null) yield return elem; }
                foreach (var elem in Specimen) { if (elem != null) yield return elem; }
                foreach (var elem in Result) { if (elem != null) yield return elem; }
                foreach (var elem in ImagingStudy) { if (elem != null) yield return elem; }
                foreach (var elem in Image) { if (elem != null) yield return elem; }
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
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Category != null) yield return new ElementValue("category", Category);
                if (Code != null) yield return new ElementValue("code", Code);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Effective != null) yield return new ElementValue("effective", Effective);
                if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                if (Performer != null) yield return new ElementValue("performer", Performer);
                foreach (var elem in Request) { if (elem != null) yield return new ElementValue("request", elem); }
                foreach (var elem in Specimen) { if (elem != null) yield return new ElementValue("specimen", elem); }
                foreach (var elem in Result) { if (elem != null) yield return new ElementValue("result", elem); }
                foreach (var elem in ImagingStudy) { if (elem != null) yield return new ElementValue("imagingStudy", elem); }
                foreach (var elem in Image) { if (elem != null) yield return new ElementValue("image", elem); }
                if (ConclusionElement != null) yield return new ElementValue("conclusion", ConclusionElement);
                foreach (var elem in CodedDiagnosis) { if (elem != null) yield return new ElementValue("codedDiagnosis", elem); }
                foreach (var elem in PresentedForm) { if (elem != null) yield return new ElementValue("presentedForm", elem); }
            }
        }

    }

}
