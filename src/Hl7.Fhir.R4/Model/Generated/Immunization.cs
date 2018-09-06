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
    /// Immunization event information
    /// </summary>
    [FhirType("Immunization", IsResource=true)]
    [DataContract]
    public partial class Immunization : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Immunization; } }
        [NotMapped]
        public override string TypeName { get { return "Immunization"; } }

        /// <summary>
        /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the current status of the administered dose of vaccine.
        /// (url: http://hl7.org/fhir/ValueSet/immunization-status)
        /// </summary>
        [FhirEnumeration("ImmunizationStatusCodes")]
        public enum ImmunizationStatusCodes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/event-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/event-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/event-status)
            /// </summary>
            [EnumLiteral("not-done", "http://hl7.org/fhir/event-status"), Description("Not Done")]
            NotDone,
        }


        [FhirType("PerformerComponent")]
        [DataContract]
        public partial class PerformerComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PerformerComponent"; } }

            /// <summary>
            /// What type of performance was done
            /// </summary>
            [FhirElement("function", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Function
            {
                get { return _function; }
                set { _function = value; OnPropertyChanged("Function"); }
            }

            private CodeableConcept _function;

            /// <summary>
            /// Individual or organization who was performing
            /// </summary>
            [FhirElement("actor", InSummary=true, Order=50)]
            [References("Practitioner","PractitionerRole","Organization")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PerformerComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Function != null) dest.Function = (CodeableConcept)Function.DeepCopy();
                    if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Function, otherT.Function)) return false;
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PerformerComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Function, otherT.Function)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;

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
                    if (Function != null) yield return new ElementValue("function", Function);
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                }
            }


        }


        [FhirType("EducationComponent")]
        [DataContract]
        public partial class EducationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EducationComponent"; } }

            /// <summary>
            /// Educational material document identifier
            /// </summary>
            [FhirElement("documentType", Order=40)]
            [DataMember]
            public FhirString DocumentTypeElement
            {
                get { return _documentTypeElement; }
                set { _documentTypeElement = value; OnPropertyChanged("DocumentTypeElement"); }
            }

            private FhirString _documentTypeElement;

            /// <summary>
            /// Educational material document identifier
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string DocumentType
            {
                get { return DocumentTypeElement != null ? DocumentTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentTypeElement = null;
                    else
                        DocumentTypeElement = new FhirString(value);
                    OnPropertyChanged("DocumentType");
                }
            }

            /// <summary>
            /// Educational material reference pointer
            /// </summary>
            [FhirElement("reference", Order=50)]
            [DataMember]
            public FhirUri ReferenceElement
            {
                get { return _referenceElement; }
                set { _referenceElement = value; OnPropertyChanged("ReferenceElement"); }
            }

            private FhirUri _referenceElement;

            /// <summary>
            /// Educational material reference pointer
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
            /// Educational material publication date
            /// </summary>
            [FhirElement("publicationDate", Order=60)]
            [DataMember]
            public FhirDateTime PublicationDateElement
            {
                get { return _publicationDateElement; }
                set { _publicationDateElement = value; OnPropertyChanged("PublicationDateElement"); }
            }

            private FhirDateTime _publicationDateElement;

            /// <summary>
            /// Educational material publication date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string PublicationDate
            {
                get { return PublicationDateElement != null ? PublicationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        PublicationDateElement = null;
                    else
                        PublicationDateElement = new FhirDateTime(value);
                    OnPropertyChanged("PublicationDate");
                }
            }

            /// <summary>
            /// Educational material presentation date
            /// </summary>
            [FhirElement("presentationDate", Order=70)]
            [DataMember]
            public FhirDateTime PresentationDateElement
            {
                get { return _presentationDateElement; }
                set { _presentationDateElement = value; OnPropertyChanged("PresentationDateElement"); }
            }

            private FhirDateTime _presentationDateElement;

            /// <summary>
            /// Educational material presentation date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string PresentationDate
            {
                get { return PresentationDateElement != null ? PresentationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        PresentationDateElement = null;
                    else
                        PresentationDateElement = new FhirDateTime(value);
                    OnPropertyChanged("PresentationDate");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EducationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DocumentTypeElement != null) dest.DocumentTypeElement = (FhirString)DocumentTypeElement.DeepCopy();
                    if (ReferenceElement != null) dest.ReferenceElement = (FhirUri)ReferenceElement.DeepCopy();
                    if (PublicationDateElement != null) dest.PublicationDateElement = (FhirDateTime)PublicationDateElement.DeepCopy();
                    if (PresentationDateElement != null) dest.PresentationDateElement = (FhirDateTime)PresentationDateElement.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DocumentTypeElement, otherT.DocumentTypeElement)) return false;
                if (!DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;
                if (!DeepComparable.Matches(PublicationDateElement, otherT.PublicationDateElement)) return false;
                if (!DeepComparable.Matches(PresentationDateElement, otherT.PresentationDateElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EducationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DocumentTypeElement, otherT.DocumentTypeElement)) return false;
                if (!DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;
                if (!DeepComparable.IsExactly(PublicationDateElement, otherT.PublicationDateElement)) return false;
                if (!DeepComparable.IsExactly(PresentationDateElement, otherT.PresentationDateElement)) return false;

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
                    if (DocumentTypeElement != null) yield return new ElementValue("documentType", DocumentTypeElement);
                    if (ReferenceElement != null) yield return new ElementValue("reference", ReferenceElement);
                    if (PublicationDateElement != null) yield return new ElementValue("publicationDate", PublicationDateElement);
                    if (PresentationDateElement != null) yield return new ElementValue("presentationDate", PresentationDateElement);
                }
            }


        }


        [FhirType("ProtocolAppliedComponent")]
        [DataContract]
        public partial class ProtocolAppliedComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ProtocolAppliedComponent"; } }

            /// <summary>
            /// Name of vaccine series
            /// </summary>
            [FhirElement("series", Order=40)]
            [DataMember]
            public FhirString SeriesElement
            {
                get { return _seriesElement; }
                set { _seriesElement = value; OnPropertyChanged("SeriesElement"); }
            }

            private FhirString _seriesElement;

            /// <summary>
            /// Name of vaccine series
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Series
            {
                get { return SeriesElement != null ? SeriesElement.Value : null; }
                set
                {
                    if (value == null)
                        SeriesElement = null;
                    else
                        SeriesElement = new FhirString(value);
                    OnPropertyChanged("Series");
                }
            }

            /// <summary>
            /// Who is responsible for publishing the recommendations
            /// </summary>
            [FhirElement("authority", Order=50)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Authority
            {
                get { return _authority; }
                set { _authority = value; OnPropertyChanged("Authority"); }
            }

            private ResourceReference _authority;

            /// <summary>
            /// Vaccine preventatable disease being targetted
            /// </summary>
            [FhirElement("targetDisease", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept TargetDisease
            {
                get { return _targetDisease; }
                set { _targetDisease = value; OnPropertyChanged("TargetDisease"); }
            }

            private CodeableConcept _targetDisease;

            /// <summary>
            /// Dose number within series
            /// </summary>
            [FhirElement("doseNumber", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(PositiveInt),typeof(FhirString))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element DoseNumber
            {
                get { return _doseNumber; }
                set { _doseNumber = value; OnPropertyChanged("DoseNumber"); }
            }

            private Element _doseNumber;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProtocolAppliedComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SeriesElement != null) dest.SeriesElement = (FhirString)SeriesElement.DeepCopy();
                    if (Authority != null) dest.Authority = (ResourceReference)Authority.DeepCopy();
                    if (TargetDisease != null) dest.TargetDisease = (CodeableConcept)TargetDisease.DeepCopy();
                    if (DoseNumber != null) dest.DoseNumber = (Element)DoseNumber.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ProtocolAppliedComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProtocolAppliedComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;
                if (!DeepComparable.Matches(Authority, otherT.Authority)) return false;
                if (!DeepComparable.Matches(TargetDisease, otherT.TargetDisease)) return false;
                if (!DeepComparable.Matches(DoseNumber, otherT.DoseNumber)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProtocolAppliedComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;
                if (!DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
                if (!DeepComparable.IsExactly(TargetDisease, otherT.TargetDisease)) return false;
                if (!DeepComparable.IsExactly(DoseNumber, otherT.DoseNumber)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SeriesElement != null) yield return SeriesElement;
                    if (Authority != null) yield return Authority;
                    if (TargetDisease != null) yield return TargetDisease;
                    if (DoseNumber != null) yield return DoseNumber;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SeriesElement != null) yield return new ElementValue("series", SeriesElement);
                    if (Authority != null) yield return new ElementValue("authority", Authority);
                    if (TargetDisease != null) yield return new ElementValue("targetDisease", TargetDisease);
                    if (DoseNumber != null) yield return new ElementValue("doseNumber", DoseNumber);
                }
            }


        }


        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// completed | entered-in-error | not-done
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ImmunizationStatusCodes> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ImmunizationStatusCodes> _statusElement;

        /// <summary>
        /// completed | entered-in-error | not-done
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ImmunizationStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ImmunizationStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Reason not done
        /// </summary>
        [FhirElement("statusReason", Order=110)]
        [DataMember]
        public CodeableConcept StatusReason
        {
            get { return _statusReason; }
            set { _statusReason = value; OnPropertyChanged("StatusReason"); }
        }

        private CodeableConcept _statusReason;

        /// <summary>
        /// Vaccine product administered
        /// </summary>
        [FhirElement("vaccineCode", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept VaccineCode
        {
            get { return _vaccineCode; }
            set { _vaccineCode = value; OnPropertyChanged("VaccineCode"); }
        }

        private CodeableConcept _vaccineCode;

        /// <summary>
        /// Who was immunized
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=130)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Encounter immunization was part of
        /// </summary>
        [FhirElement("encounter", Order=140)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Vaccine administration date
        /// </summary>
        [FhirElement("occurrence", InSummary=true, Order=150, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(FhirString))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Occurrence
        {
            get { return _occurrence; }
            set { _occurrence = value; OnPropertyChanged("Occurrence"); }
        }

        private Element _occurrence;

        /// <summary>
        /// When the immunization was first captured in the subject's record
        /// </summary>
        [FhirElement("recorded", Order=160)]
        [DataMember]
        public FhirDateTime RecordedElement
        {
            get { return _recordedElement; }
            set { _recordedElement = value; OnPropertyChanged("RecordedElement"); }
        }

        private FhirDateTime _recordedElement;

        /// <summary>
        /// When the immunization was first captured in the subject's record
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Recorded
        {
            get { return RecordedElement != null ? RecordedElement.Value : null; }
            set
            {
                if (value == null)
                    RecordedElement = null;
                else
                    RecordedElement = new FhirDateTime(value);
                OnPropertyChanged("Recorded");
            }
        }

        /// <summary>
        /// Indicates context the data was recorded in
        /// </summary>
        [FhirElement("primarySource", InSummary=true, Order=170)]
        [DataMember]
        public FhirBoolean PrimarySourceElement
        {
            get { return _primarySourceElement; }
            set { _primarySourceElement = value; OnPropertyChanged("PrimarySourceElement"); }
        }

        private FhirBoolean _primarySourceElement;

        /// <summary>
        /// Indicates context the data was recorded in
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? PrimarySource
        {
            get { return PrimarySourceElement != null ? PrimarySourceElement.Value : null; }
            set
            {
                if (value == null)
                    PrimarySourceElement = null;
                else
                    PrimarySourceElement = new FhirBoolean(value);
                OnPropertyChanged("PrimarySource");
            }
        }

        /// <summary>
        /// Indicates the source of a secondarily reported record
        /// </summary>
        [FhirElement("reportOrigin", Order=180)]
        [DataMember]
        public CodeableConcept ReportOrigin
        {
            get { return _reportOrigin; }
            set { _reportOrigin = value; OnPropertyChanged("ReportOrigin"); }
        }

        private CodeableConcept _reportOrigin;

        /// <summary>
        /// Where immunization occurred
        /// </summary>
        [FhirElement("location", Order=190)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Vaccine manufacturer
        /// </summary>
        [FhirElement("manufacturer", Order=200)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }

        private ResourceReference _manufacturer;

        /// <summary>
        /// Vaccine lot number
        /// </summary>
        [FhirElement("lotNumber", Order=210)]
        [DataMember]
        public FhirString LotNumberElement
        {
            get { return _lotNumberElement; }
            set { _lotNumberElement = value; OnPropertyChanged("LotNumberElement"); }
        }

        private FhirString _lotNumberElement;

        /// <summary>
        /// Vaccine lot number
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string LotNumber
        {
            get { return LotNumberElement != null ? LotNumberElement.Value : null; }
            set
            {
                if (value == null)
                    LotNumberElement = null;
                else
                    LotNumberElement = new FhirString(value);
                OnPropertyChanged("LotNumber");
            }
        }

        /// <summary>
        /// Vaccine expiration date
        /// </summary>
        [FhirElement("expirationDate", Order=220)]
        [DataMember]
        public Date ExpirationDateElement
        {
            get { return _expirationDateElement; }
            set { _expirationDateElement = value; OnPropertyChanged("ExpirationDateElement"); }
        }

        private Date _expirationDateElement;

        /// <summary>
        /// Vaccine expiration date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string ExpirationDate
        {
            get { return ExpirationDateElement != null ? ExpirationDateElement.Value : null; }
            set
            {
                if (value == null)
                    ExpirationDateElement = null;
                else
                    ExpirationDateElement = new Date(value);
                OnPropertyChanged("ExpirationDate");
            }
        }

        /// <summary>
        /// Body site vaccine  was administered
        /// </summary>
        [FhirElement("site", Order=230)]
        [DataMember]
        public CodeableConcept Site
        {
            get { return _site; }
            set { _site = value; OnPropertyChanged("Site"); }
        }

        private CodeableConcept _site;

        /// <summary>
        /// How vaccine entered body
        /// </summary>
        [FhirElement("route", Order=240)]
        [DataMember]
        public CodeableConcept Route
        {
            get { return _route; }
            set { _route = value; OnPropertyChanged("Route"); }
        }

        private CodeableConcept _route;

        /// <summary>
        /// Amount of vaccine administered
        /// </summary>
        [FhirElement("doseQuantity", Order=250)]
        [DataMember]
        public SimpleQuantity DoseQuantity
        {
            get { return _doseQuantity; }
            set { _doseQuantity = value; OnPropertyChanged("DoseQuantity"); }
        }

        private SimpleQuantity _doseQuantity;

        /// <summary>
        /// Who performed event
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PerformerComponent> Performer
        {
            get { if (_performer==null) _performer = new List<PerformerComponent>(); return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private List<PerformerComponent> _performer;

        /// <summary>
        /// Additional immunization notes
        /// </summary>
        [FhirElement("note", InSummary=true, Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Why immunization occurred
        /// </summary>
        [FhirElement("reasonCode", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Why immunization occurred
        /// </summary>
        [FhirElement("reasonReference", Order=290)]
        [References("Condition","Observation","DiagnosticReport")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// Dose potency
        /// </summary>
        [FhirElement("isSubpotent", InSummary=true, Order=300)]
        [DataMember]
        public FhirBoolean IsSubpotentElement
        {
            get { return _isSubpotentElement; }
            set { _isSubpotentElement = value; OnPropertyChanged("IsSubpotentElement"); }
        }

        private FhirBoolean _isSubpotentElement;

        /// <summary>
        /// Dose potency
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? IsSubpotent
        {
            get { return IsSubpotentElement != null ? IsSubpotentElement.Value : null; }
            set
            {
                if (value == null)
                    IsSubpotentElement = null;
                else
                    IsSubpotentElement = new FhirBoolean(value);
                OnPropertyChanged("IsSubpotent");
            }
        }

        /// <summary>
        /// Reason for being subpotent
        /// </summary>
        [FhirElement("subpotentReason", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> SubpotentReason
        {
            get { if (_subpotentReason==null) _subpotentReason = new List<CodeableConcept>(); return _subpotentReason; }
            set { _subpotentReason = value; OnPropertyChanged("SubpotentReason"); }
        }

        private List<CodeableConcept> _subpotentReason;

        /// <summary>
        /// Educational material presented to patient
        /// </summary>
        [FhirElement("education", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EducationComponent> Education
        {
            get { if (_education==null) _education = new List<EducationComponent>(); return _education; }
            set { _education = value; OnPropertyChanged("Education"); }
        }

        private List<EducationComponent> _education;

        /// <summary>
        /// Patient eligibility for a vaccination program
        /// </summary>
        [FhirElement("programEligibility", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ProgramEligibility
        {
            get { if (_programEligibility==null) _programEligibility = new List<CodeableConcept>(); return _programEligibility; }
            set { _programEligibility = value; OnPropertyChanged("ProgramEligibility"); }
        }

        private List<CodeableConcept> _programEligibility;

        /// <summary>
        /// Funding source for the vaccine
        /// </summary>
        [FhirElement("fundingSource", Order=340)]
        [DataMember]
        public CodeableConcept FundingSource
        {
            get { return _fundingSource; }
            set { _fundingSource = value; OnPropertyChanged("FundingSource"); }
        }

        private CodeableConcept _fundingSource;

        /// <summary>
        /// Protocol followed by the provider
        /// </summary>
        [FhirElement("protocolApplied", Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ProtocolAppliedComponent> ProtocolApplied
        {
            get { if (_protocolApplied==null) _protocolApplied = new List<ProtocolAppliedComponent>(); return _protocolApplied; }
            set { _protocolApplied = value; OnPropertyChanged("ProtocolApplied"); }
        }

        private List<ProtocolAppliedComponent> _protocolApplied;


        public static ElementDefinition.ConstraintComponent Immunization_IMM_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "education.all(documentType.exists() or reference.exists())",
            Key = "imm-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
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
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<ImmunizationStatusCodes>)StatusElement.DeepCopy();
                if (StatusReason != null) dest.StatusReason = (CodeableConcept)StatusReason.DeepCopy();
                if (VaccineCode != null) dest.VaccineCode = (CodeableConcept)VaccineCode.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Occurrence != null) dest.Occurrence = (Element)Occurrence.DeepCopy();
                if (RecordedElement != null) dest.RecordedElement = (FhirDateTime)RecordedElement.DeepCopy();
                if (PrimarySourceElement != null) dest.PrimarySourceElement = (FhirBoolean)PrimarySourceElement.DeepCopy();
                if (ReportOrigin != null) dest.ReportOrigin = (CodeableConcept)ReportOrigin.DeepCopy();
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (Manufacturer != null) dest.Manufacturer = (ResourceReference)Manufacturer.DeepCopy();
                if (LotNumberElement != null) dest.LotNumberElement = (FhirString)LotNumberElement.DeepCopy();
                if (ExpirationDateElement != null) dest.ExpirationDateElement = (Date)ExpirationDateElement.DeepCopy();
                if (Site != null) dest.Site = (CodeableConcept)Site.DeepCopy();
                if (Route != null) dest.Route = (CodeableConcept)Route.DeepCopy();
                if (DoseQuantity != null) dest.DoseQuantity = (SimpleQuantity)DoseQuantity.DeepCopy();
                if (Performer != null) dest.Performer = new List<PerformerComponent>(Performer.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (IsSubpotentElement != null) dest.IsSubpotentElement = (FhirBoolean)IsSubpotentElement.DeepCopy();
                if (SubpotentReason != null) dest.SubpotentReason = new List<CodeableConcept>(SubpotentReason.DeepCopy());
                if (Education != null) dest.Education = new List<EducationComponent>(Education.DeepCopy());
                if (ProgramEligibility != null) dest.ProgramEligibility = new List<CodeableConcept>(ProgramEligibility.DeepCopy());
                if (FundingSource != null) dest.FundingSource = (CodeableConcept)FundingSource.DeepCopy();
                if (ProtocolApplied != null) dest.ProtocolApplied = new List<ProtocolAppliedComponent>(ProtocolApplied.DeepCopy());
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
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.Matches(VaccineCode, otherT.VaccineCode)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.Matches(RecordedElement, otherT.RecordedElement)) return false;
            if (!DeepComparable.Matches(PrimarySourceElement, otherT.PrimarySourceElement)) return false;
            if (!DeepComparable.Matches(ReportOrigin, otherT.ReportOrigin)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if (!DeepComparable.Matches(Site, otherT.Site)) return false;
            if (!DeepComparable.Matches(Route, otherT.Route)) return false;
            if (!DeepComparable.Matches(DoseQuantity, otherT.DoseQuantity)) return false;
            if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.Matches(IsSubpotentElement, otherT.IsSubpotentElement)) return false;
            if ( !DeepComparable.Matches(SubpotentReason, otherT.SubpotentReason)) return false;
            if ( !DeepComparable.Matches(Education, otherT.Education)) return false;
            if ( !DeepComparable.Matches(ProgramEligibility, otherT.ProgramEligibility)) return false;
            if (!DeepComparable.Matches(FundingSource, otherT.FundingSource)) return false;
            if ( !DeepComparable.Matches(ProtocolApplied, otherT.ProtocolApplied)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Immunization;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.IsExactly(VaccineCode, otherT.VaccineCode)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if (!DeepComparable.IsExactly(RecordedElement, otherT.RecordedElement)) return false;
            if (!DeepComparable.IsExactly(PrimarySourceElement, otherT.PrimarySourceElement)) return false;
            if (!DeepComparable.IsExactly(ReportOrigin, otherT.ReportOrigin)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if (!DeepComparable.IsExactly(Site, otherT.Site)) return false;
            if (!DeepComparable.IsExactly(Route, otherT.Route)) return false;
            if (!DeepComparable.IsExactly(DoseQuantity, otherT.DoseQuantity)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(IsSubpotentElement, otherT.IsSubpotentElement)) return false;
            if (!DeepComparable.IsExactly(SubpotentReason, otherT.SubpotentReason)) return false;
            if (!DeepComparable.IsExactly(Education, otherT.Education)) return false;
            if (!DeepComparable.IsExactly(ProgramEligibility, otherT.ProgramEligibility)) return false;
            if (!DeepComparable.IsExactly(FundingSource, otherT.FundingSource)) return false;
            if (!DeepComparable.IsExactly(ProtocolApplied, otherT.ProtocolApplied)) return false;

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
                if (Occurrence != null) yield return Occurrence;
                if (RecordedElement != null) yield return RecordedElement;
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
                if (IsSubpotentElement != null) yield return IsSubpotentElement;
                foreach (var elem in SubpotentReason) { if (elem != null) yield return elem; }
                foreach (var elem in Education) { if (elem != null) yield return elem; }
                foreach (var elem in ProgramEligibility) { if (elem != null) yield return elem; }
                if (FundingSource != null) yield return FundingSource;
                foreach (var elem in ProtocolApplied) { if (elem != null) yield return elem; }
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
                if (StatusReason != null) yield return new ElementValue("statusReason", StatusReason);
                if (VaccineCode != null) yield return new ElementValue("vaccineCode", VaccineCode);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                if (RecordedElement != null) yield return new ElementValue("recorded", RecordedElement);
                if (PrimarySourceElement != null) yield return new ElementValue("primarySource", PrimarySourceElement);
                if (ReportOrigin != null) yield return new ElementValue("reportOrigin", ReportOrigin);
                if (Location != null) yield return new ElementValue("location", Location);
                if (Manufacturer != null) yield return new ElementValue("manufacturer", Manufacturer);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
                if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
                if (Site != null) yield return new ElementValue("site", Site);
                if (Route != null) yield return new ElementValue("route", Route);
                if (DoseQuantity != null) yield return new ElementValue("doseQuantity", DoseQuantity);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                if (IsSubpotentElement != null) yield return new ElementValue("isSubpotent", IsSubpotentElement);
                foreach (var elem in SubpotentReason) { if (elem != null) yield return new ElementValue("subpotentReason", elem); }
                foreach (var elem in Education) { if (elem != null) yield return new ElementValue("education", elem); }
                foreach (var elem in ProgramEligibility) { if (elem != null) yield return new ElementValue("programEligibility", elem); }
                if (FundingSource != null) yield return new ElementValue("fundingSource", FundingSource);
                foreach (var elem in ProtocolApplied) { if (elem != null) yield return new ElementValue("protocolApplied", elem); }
            }
        }

    }

}
