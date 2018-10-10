using System;
using System.Collections.Generic;
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
    /// Clinical issue with action
    /// </summary>
    [FhirType("DetectedIssue", IsResource=true)]
    [DataContract]
    public partial class DetectedIssue : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DetectedIssue; } }
        [NotMapped]
        public override string TypeName { get { return "DetectedIssue"; } }

        /// <summary>
        /// Indicates the potential degree of impact of the identified issue on the patient.
        /// (url: http://hl7.org/fhir/ValueSet/detectedissue-severity)
        /// </summary>
        [FhirEnumeration("DetectedIssueSeverity")]
        public enum DetectedIssueSeverity
        {
            /// <summary>
            /// Indicates the issue may be life-threatening or has the potential to cause permanent injury.
            /// (system: http://hl7.org/fhir/detectedissue-severity)
            /// </summary>
            [EnumLiteral("high", "http://hl7.org/fhir/detectedissue-severity"), Description("High")]
            High,
            /// <summary>
            /// Indicates the issue may result in noticeable adverse consequences but is unlikely to be life-threatening or cause permanent injury.
            /// (system: http://hl7.org/fhir/detectedissue-severity)
            /// </summary>
            [EnumLiteral("moderate", "http://hl7.org/fhir/detectedissue-severity"), Description("Moderate")]
            Moderate,
            /// <summary>
            /// Indicates the issue may result in some adverse consequences but is unlikely to substantially affect the situation of the subject.
            /// (system: http://hl7.org/fhir/detectedissue-severity)
            /// </summary>
            [EnumLiteral("low", "http://hl7.org/fhir/detectedissue-severity"), Description("Low")]
            Low,
        }


        [FhirType("MitigationComponent")]
        [DataContract]
        public partial class MitigationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "MitigationComponent"; } }

            /// <summary>
            /// What mitigation?
            /// </summary>
            [FhirElement("action", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Action
            {
                get { return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private CodeableConcept _action;

            /// <summary>
            /// Date committed
            /// </summary>
            [FhirElement("date", Order=50)]
            [DataMember]
            public FhirDateTime DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private FhirDateTime _dateElement;

            /// <summary>
            /// Date committed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Date
            {
                get { return DateElement != null ? DateElement.Value : null; }
                set
                {
                    if (value == null)
                        DateElement = null;
                    else
                        DateElement = new FhirDateTime(value);
                    OnPropertyChanged("Date");
                }
            }

            /// <summary>
            /// Who is committing?
            /// </summary>
            [FhirElement("author", Order=60)]
            [References("Practitioner")]
            [DataMember]
            public ResourceReference Author
            {
                get { return _author; }
                set { _author = value; OnPropertyChanged("Author"); }
            }

            private ResourceReference _author;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MitigationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Action != null) dest.Action = (CodeableConcept)Action.DeepCopy();
                    if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                    if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MitigationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MitigationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Action, otherT.Action)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(Author, otherT.Author)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MitigationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Action != null) yield return Action;
                    if (DateElement != null) yield return DateElement;
                    if (Author != null) yield return Author;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Action != null) yield return new ElementValue("action", Action);
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                    if (Author != null) yield return new ElementValue("author", Author);
                }
            }


        }


        /// <summary>
        /// Associated patient
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=90)]
        [References("Patient")]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Issue Category, e.g. drug-drug, duplicate therapy, etc.
        /// </summary>
        [FhirElement("category", InSummary=true, Order=100)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// high | moderate | low
        /// </summary>
        [FhirElement("severity", InSummary=true, Order=110)]
        [DataMember]
        public Code<DetectedIssueSeverity> SeverityElement
        {
            get { return _severityElement; }
            set { _severityElement = value; OnPropertyChanged("SeverityElement"); }
        }

        private Code<DetectedIssueSeverity> _severityElement;

        /// <summary>
        /// high | moderate | low
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DetectedIssueSeverity? Severity
        {
            get { return SeverityElement != null ? SeverityElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    SeverityElement = null;
                else
                    SeverityElement = new Code<DetectedIssueSeverity>(value);
                OnPropertyChanged("Severity");
            }
        }

        /// <summary>
        /// Problem resource
        /// </summary>
        [FhirElement("implicated", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Implicated
        {
            get { if (_implicated == null) _implicated = new List<ResourceReference>(); return _implicated; }
            set { _implicated = value; OnPropertyChanged("Implicated"); }
        }

        private List<ResourceReference> _implicated;

        /// <summary>
        /// Description and context
        /// </summary>
        [FhirElement("detail", Order=130)]
        [DataMember]
        public FhirString DetailElement
        {
            get { return _detailElement; }
            set { _detailElement = value; OnPropertyChanged("DetailElement"); }
        }

        private FhirString _detailElement;

        /// <summary>
        /// Description and context
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Detail
        {
            get { return DetailElement != null ? DetailElement.Value : null; }
            set
            {
                if (value == null)
                    DetailElement = null;
                else
                    DetailElement = new FhirString(value);
                OnPropertyChanged("Detail");
            }
        }

        /// <summary>
        /// When identified
        /// </summary>
        [FhirElement("date", InSummary=true, Order=140)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// When identified
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// The provider or device that identified the issue
        /// </summary>
        [FhirElement("author", InSummary=true, Order=150)]
        [References("Practitioner","Device")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// Unique id for the detected issue
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=160)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Authority for issue
        /// </summary>
        [FhirElement("reference", Order=170)]
        [DataMember]
        public FhirUri ReferenceElement
        {
            get { return _referenceElement; }
            set { _referenceElement = value; OnPropertyChanged("ReferenceElement"); }
        }

        private FhirUri _referenceElement;

        /// <summary>
        /// Authority for issue
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Reference
        {
            get { return ReferenceElement != null ? ReferenceElement.Value : null; }
            set
            {
                if (value == null)
                    ReferenceElement = null;
                else
                    ReferenceElement = new FhirUri(value);
                OnPropertyChanged("Reference");
            }
        }

        /// <summary>
        /// Step taken to address
        /// </summary>
        [FhirElement("mitigation", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MitigationComponent> Mitigation
        {
            get { if (_mitigation == null) _mitigation = new List<MitigationComponent>(); return _mitigation; }
            set { _mitigation = value; OnPropertyChanged("Mitigation"); }
        }

        private List<MitigationComponent> _mitigation;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DetectedIssue;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (SeverityElement != null) dest.SeverityElement = (Code<DetectedIssueSeverity>)SeverityElement.DeepCopy();
                if (Implicated != null) dest.Implicated = new List<ResourceReference>(Implicated.DeepCopy());
                if (DetailElement != null) dest.DetailElement = (FhirString)DetailElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (ReferenceElement != null) dest.ReferenceElement = (FhirUri)ReferenceElement.DeepCopy();
                if (Mitigation != null) dest.Mitigation = new List<MitigationComponent>(Mitigation.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new DetectedIssue());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DetectedIssue;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(SeverityElement, otherT.SeverityElement)) return false;
            if (!DeepComparable.Matches(Implicated, otherT.Implicated)) return false;
            if (!DeepComparable.Matches(DetailElement, otherT.DetailElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;
            if (!DeepComparable.Matches(Mitigation, otherT.Mitigation)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DetectedIssue;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(SeverityElement, otherT.SeverityElement)) return false;
            if (!DeepComparable.IsExactly(Implicated, otherT.Implicated)) return false;
            if (!DeepComparable.IsExactly(DetailElement, otherT.DetailElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;
            if (!DeepComparable.IsExactly(Mitigation, otherT.Mitigation)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Patient != null) yield return Patient;
                if (Category != null) yield return Category;
                if (SeverityElement != null) yield return SeverityElement;
                foreach (var elem in Implicated) { if (elem != null) yield return elem; }
                if (DetailElement != null) yield return DetailElement;
                if (DateElement != null) yield return DateElement;
                if (Author != null) yield return Author;
                if (Identifier != null) yield return Identifier;
                if (ReferenceElement != null) yield return ReferenceElement;
                foreach (var elem in Mitigation) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Category != null) yield return new ElementValue("category", Category);
                if (SeverityElement != null) yield return new ElementValue("severity", SeverityElement);
                foreach (var elem in Implicated) { if (elem != null) yield return new ElementValue("implicated", elem); }
                if (DetailElement != null) yield return new ElementValue("detail", DetailElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Author != null) yield return new ElementValue("author", Author);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (ReferenceElement != null) yield return new ElementValue("reference", ReferenceElement);
                foreach (var elem in Mitigation) { if (elem != null) yield return new ElementValue("mitigation", elem); }
            }
        }

    }

}
