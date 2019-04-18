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
    /// Immunization event information
    /// </summary>
    [FhirType("Immunization", IsResource = true)]
    [DataContract]
    public partial class Immunization : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Immunization; } }
        [NotMapped]
        public override string TypeName { get { return "Immunization"; } }


        [FhirType("ExplanationComponent")]
        [DataContract]
        public partial class ExplanationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ExplanationComponent"; } }

            /// <summary>
            /// Why immunization occurred
            /// </summary>
            [FhirElement("reason", Order = 40)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<CodeableConcept> Reason
            {
                get { if (_reason == null) _reason = new List<CodeableConcept>(); return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private List<CodeableConcept> _reason;

            /// <summary>
            /// Why immunization did not occur
            /// </summary>
            [FhirElement("reasonNotGiven", Order = 50)]
            [Cardinality(Min = 0, Max = -1)]
            [DataMember]
            public List<CodeableConcept> ReasonNotGiven
            {
                get { if (_reasonNotGiven == null) _reasonNotGiven = new List<CodeableConcept>(); return _reasonNotGiven; }
                set { _reasonNotGiven = value; OnPropertyChanged("ReasonNotGiven"); }
            }

            private List<CodeableConcept> _reasonNotGiven;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ExplanationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                    if (ReasonNotGiven != null) dest.ReasonNotGiven = new List<CodeableConcept>(ReasonNotGiven.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ExplanationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ExplanationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if (!DeepComparable.Matches(ReasonNotGiven, otherT.ReasonNotGiven)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExplanationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if (!DeepComparable.IsExactly(ReasonNotGiven, otherT.ReasonNotGiven)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Reason) { if (elem != null) yield return elem; }
                    foreach (var elem in ReasonNotGiven) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                    foreach (var elem in ReasonNotGiven) { if (elem != null) yield return new ElementValue("reasonNotGiven", elem); }
                }
            }


        }


        [FhirType("ReactionComponent")]
        [DataContract]
        public partial class ReactionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ReactionComponent"; } }

            /// <summary>
            /// When reaction started
            /// </summary>
            [FhirElement("date", Order = 40)]
            [DataMember]
            public FhirDateTime DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private FhirDateTime _dateElement;

            /// <summary>
            /// When reaction started
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
            /// Additional information on reaction
            /// </summary>
            [FhirElement("detail", Order = 50)]
            [References("Observation")]
            [DataMember]
            public ResourceReference Detail
            {
                get { return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private ResourceReference _detail;

            /// <summary>
            /// Indicates self-reported reaction
            /// </summary>
            [FhirElement("reported", Order = 60)]
            [DataMember]
            public FhirBoolean ReportedElement
            {
                get { return _reportedElement; }
                set { _reportedElement = value; OnPropertyChanged("ReportedElement"); }
            }

            private FhirBoolean _reportedElement;

            /// <summary>
            /// Indicates self-reported reaction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Reported
            {
                get { return ReportedElement != null ? ReportedElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        ReportedElement = null;
                    else
                        ReportedElement = new FhirBoolean(value);
                    OnPropertyChanged("Reported");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReactionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                    if (Detail != null) dest.Detail = (ResourceReference)Detail.DeepCopy();
                    if (ReportedElement != null) dest.ReportedElement = (FhirBoolean)ReportedElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ReactionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReactionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(Detail, otherT.Detail)) return false;
                if (!DeepComparable.Matches(ReportedElement, otherT.ReportedElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReactionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
                if (!DeepComparable.IsExactly(ReportedElement, otherT.ReportedElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DateElement != null) yield return DateElement;
                    if (Detail != null) yield return Detail;
                    if (ReportedElement != null) yield return ReportedElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                    if (Detail != null) yield return new ElementValue("detail", Detail);
                    if (ReportedElement != null) yield return new ElementValue("reported", ReportedElement);
                }
            }


        }


        [FhirType("VaccinationProtocolComponent")]
        [DataContract]
        public partial class VaccinationProtocolComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "VaccinationProtocolComponent"; } }

            /// <summary>
            /// Dose number within series
            /// </summary>
            [FhirElement("doseSequence", Order = 40)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public PositiveInt DoseSequenceElement
            {
                get { return _doseSequenceElement; }
                set { _doseSequenceElement = value; OnPropertyChanged("DoseSequenceElement"); }
            }

            private PositiveInt _doseSequenceElement;

            /// <summary>
            /// Dose number within series
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? DoseSequence
            {
                get { return DoseSequenceElement != null ? DoseSequenceElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        DoseSequenceElement = null;
                    else
                        DoseSequenceElement = new PositiveInt(value);
                    OnPropertyChanged("DoseSequence");
                }
            }

            /// <summary>
            /// Details of vaccine protocol
            /// </summary>
            [FhirElement("description", Order = 50)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Details of vaccine protocol
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        DescriptionElement = null;
                    else
                        DescriptionElement = new FhirString(value);
                    OnPropertyChanged("Description");
                }
            }

            /// <summary>
            /// Who is responsible for protocol
            /// </summary>
            [FhirElement("authority", Order = 60)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Authority
            {
                get { return _authority; }
                set { _authority = value; OnPropertyChanged("Authority"); }
            }

            private ResourceReference _authority;

            /// <summary>
            /// Name of vaccine series
            /// </summary>
            [FhirElement("series", Order = 70)]
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
            /// Recommended number of doses for immunity
            /// </summary>
            [FhirElement("seriesDoses", Order = 80)]
            [DataMember]
            public PositiveInt SeriesDosesElement
            {
                get { return _seriesDosesElement; }
                set { _seriesDosesElement = value; OnPropertyChanged("SeriesDosesElement"); }
            }

            private PositiveInt _seriesDosesElement;

            /// <summary>
            /// Recommended number of doses for immunity
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? SeriesDoses
            {
                get { return SeriesDosesElement != null ? SeriesDosesElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        SeriesDosesElement = null;
                    else
                        SeriesDosesElement = new PositiveInt(value);
                    OnPropertyChanged("SeriesDoses");
                }
            }

            /// <summary>
            /// Disease immunized against
            /// </summary>
            [FhirElement("targetDisease", Order = 90)]
            [Cardinality(Min = 1, Max = -1)]
            [DataMember]
            public List<CodeableConcept> TargetDisease
            {
                get { if (_targetDisease == null) _targetDisease = new List<CodeableConcept>(); return _targetDisease; }
                set { _targetDisease = value; OnPropertyChanged("TargetDisease"); }
            }

            private List<CodeableConcept> _targetDisease;

            /// <summary>
            /// Indicates if dose counts towards immunity
            /// </summary>
            [FhirElement("doseStatus", Order = 100)]
            [Cardinality(Min = 1, Max = 1)]
            [DataMember]
            public CodeableConcept DoseStatus
            {
                get { return _doseStatus; }
                set { _doseStatus = value; OnPropertyChanged("DoseStatus"); }
            }

            private CodeableConcept _doseStatus;

            /// <summary>
            /// Why dose does (not) count
            /// </summary>
            [FhirElement("doseStatusReason", Order = 110)]
            [DataMember]
            public CodeableConcept DoseStatusReason
            {
                get { return _doseStatusReason; }
                set { _doseStatusReason = value; OnPropertyChanged("DoseStatusReason"); }
            }

            private CodeableConcept _doseStatusReason;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VaccinationProtocolComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (DoseSequenceElement != null) dest.DoseSequenceElement = (PositiveInt)DoseSequenceElement.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    if (Authority != null) dest.Authority = (ResourceReference)Authority.DeepCopy();
                    if (SeriesElement != null) dest.SeriesElement = (FhirString)SeriesElement.DeepCopy();
                    if (SeriesDosesElement != null) dest.SeriesDosesElement = (PositiveInt)SeriesDosesElement.DeepCopy();
                    if (TargetDisease != null) dest.TargetDisease = new List<CodeableConcept>(TargetDisease.DeepCopy());
                    if (DoseStatus != null) dest.DoseStatus = (CodeableConcept)DoseStatus.DeepCopy();
                    if (DoseStatusReason != null) dest.DoseStatusReason = (CodeableConcept)DoseStatusReason.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new VaccinationProtocolComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VaccinationProtocolComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(DoseSequenceElement, otherT.DoseSequenceElement)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.Matches(Authority, otherT.Authority)) return false;
                if (!DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;
                if (!DeepComparable.Matches(SeriesDosesElement, otherT.SeriesDosesElement)) return false;
                if (!DeepComparable.Matches(TargetDisease, otherT.TargetDisease)) return false;
                if (!DeepComparable.Matches(DoseStatus, otherT.DoseStatus)) return false;
                if (!DeepComparable.Matches(DoseStatusReason, otherT.DoseStatusReason)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VaccinationProtocolComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(DoseSequenceElement, otherT.DoseSequenceElement)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if (!DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
                if (!DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;
                if (!DeepComparable.IsExactly(SeriesDosesElement, otherT.SeriesDosesElement)) return false;
                if (!DeepComparable.IsExactly(TargetDisease, otherT.TargetDisease)) return false;
                if (!DeepComparable.IsExactly(DoseStatus, otherT.DoseStatus)) return false;
                if (!DeepComparable.IsExactly(DoseStatusReason, otherT.DoseStatusReason)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DoseSequenceElement != null) yield return DoseSequenceElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Authority != null) yield return Authority;
                    if (SeriesElement != null) yield return SeriesElement;
                    if (SeriesDosesElement != null) yield return SeriesDosesElement;
                    foreach (var elem in TargetDisease) { if (elem != null) yield return elem; }
                    if (DoseStatus != null) yield return DoseStatus;
                    if (DoseStatusReason != null) yield return DoseStatusReason;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DoseSequenceElement != null) yield return new ElementValue("doseSequence", DoseSequenceElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Authority != null) yield return new ElementValue("authority", Authority);
                    if (SeriesElement != null) yield return new ElementValue("series", SeriesElement);
                    if (SeriesDosesElement != null) yield return new ElementValue("seriesDoses", SeriesDosesElement);
                    foreach (var elem in TargetDisease) { if (elem != null) yield return new ElementValue("targetDisease", elem); }
                    if (DoseStatus != null) yield return new ElementValue("doseStatus", DoseStatus);
                    if (DoseStatusReason != null) yield return new ElementValue("doseStatusReason", DoseStatusReason);
                }
            }


        }


        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", Order = 90)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        [FhirElement("status", InSummary = true, Order = 100)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public Code<MedicationAdministrationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationAdministrationStatus> _statusElement;

        /// <summary>
        /// in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationAdministrationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationAdministrationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Vaccination administration date
        /// </summary>
        [FhirElement("date", Order = 110)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Vaccination administration date
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
        /// Vaccine product administered
        /// </summary>
        [FhirElement("vaccineCode", Order = 120)]
        [Cardinality(Min = 1, Max = 1)]
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
        [FhirElement("patient", Order = 130)]
        [References("Patient")]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Flag for whether immunization was given
        /// </summary>
        [FhirElement("wasNotGiven", Order = 140)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public FhirBoolean WasNotGivenElement
        {
            get { return _wasNotGivenElement; }
            set { _wasNotGivenElement = value; OnPropertyChanged("WasNotGivenElement"); }
        }

        private FhirBoolean _wasNotGivenElement;

        /// <summary>
        /// Flag for whether immunization was given
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? WasNotGiven
        {
            get { return WasNotGivenElement != null ? WasNotGivenElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    WasNotGivenElement = null;
                else
                    WasNotGivenElement = new FhirBoolean(value);
                OnPropertyChanged("WasNotGiven");
            }
        }

        /// <summary>
        /// Indicates a self-reported record
        /// </summary>
        [FhirElement("reported", Order = 150)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public FhirBoolean ReportedElement
        {
            get { return _reportedElement; }
            set { _reportedElement = value; OnPropertyChanged("ReportedElement"); }
        }

        private FhirBoolean _reportedElement;

        /// <summary>
        /// Indicates a self-reported record
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Reported
        {
            get { return ReportedElement != null ? ReportedElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    ReportedElement = null;
                else
                    ReportedElement = new FhirBoolean(value);
                OnPropertyChanged("Reported");
            }
        }

        /// <summary>
        /// Who administered vaccine
        /// </summary>
        [FhirElement("performer", Order = 160)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Performer
        {
            get { return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private ResourceReference _performer;

        /// <summary>
        /// Who ordered vaccination
        /// </summary>
        [FhirElement("requester", Order = 170)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private ResourceReference _requester;

        /// <summary>
        /// Encounter administered as part of
        /// </summary>
        [FhirElement("encounter", Order = 180)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Vaccine manufacturer
        /// </summary>
        [FhirElement("manufacturer", Order = 190)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }

        private ResourceReference _manufacturer;

        /// <summary>
        /// Where vaccination occurred
        /// </summary>
        [FhirElement("location", Order = 200)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Vaccine lot number
        /// </summary>
        [FhirElement("lotNumber", Order = 210)]
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
        [FhirElement("expirationDate", Order = 220)]
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
        [FhirElement("site", Order = 230)]
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
        [FhirElement("route", Order = 240)]
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
        [FhirElement("doseQuantity", Order = 250)]
        [DataMember]
        public SimpleQuantity DoseQuantity
        {
            get { return _doseQuantity; }
            set { _doseQuantity = value; OnPropertyChanged("DoseQuantity"); }
        }

        private SimpleQuantity _doseQuantity;

        /// <summary>
        /// Vaccination notes
        /// </summary>
        [FhirElement("note", InSummary = true, Order = 260)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note == null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Administration/non-administration reasons
        /// </summary>
        [FhirElement("explanation", Order = 270)]
        [DataMember]
        public ExplanationComponent Explanation
        {
            get { return _explanation; }
            set { _explanation = value; OnPropertyChanged("Explanation"); }
        }

        private ExplanationComponent _explanation;

        /// <summary>
        /// Details of a reaction that follows immunization
        /// </summary>
        [FhirElement("reaction", Order = 280)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ReactionComponent> Reaction
        {
            get { if (_reaction == null) _reaction = new List<ReactionComponent>(); return _reaction; }
            set { _reaction = value; OnPropertyChanged("Reaction"); }
        }

        private List<ReactionComponent> _reaction;

        /// <summary>
        /// What protocol was followed
        /// </summary>
        [FhirElement("vaccinationProtocol", Order = 290)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<VaccinationProtocolComponent> VaccinationProtocol
        {
            get { if (_vaccinationProtocol == null) _vaccinationProtocol = new List<VaccinationProtocolComponent>(); return _vaccinationProtocol; }
            set { _vaccinationProtocol = value; OnPropertyChanged("VaccinationProtocol"); }
        }

        private List<VaccinationProtocolComponent> _vaccinationProtocol;


        public static ElementDefinition.ConstraintComponent Immunization_IMM_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(wasNotGiven = true) or explanation.reasonNotGiven.empty()",
            Key = "imm-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If immunization was administered (wasNotGiven=false) then explanation.reasonNotGiven SHALL be absent.",
            Xpath = "not(f:wasNotGiven/@value=false() and exists(f:explanation/f:reasonNotGiven))"
        };

        public static ElementDefinition.ConstraintComponent Immunization_IMM_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "(wasNotGiven = true).not() or (reaction.empty() and explanation.reason.empty())",
            Key = "imm-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If immunization was not administred (wasNotGiven=true) then there SHALL be no reaction nor explanation.reason present",
            Xpath = "not(f:wasNotGiven/@value=true() and (count(f:reaction) > 0 or exists(f:explanation/f:reason)))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Immunization_IMM_2);
            InvariantConstraints.Add(Immunization_IMM_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Immunization;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<MedicationAdministrationStatus>)StatusElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (VaccineCode != null) dest.VaccineCode = (CodeableConcept)VaccineCode.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (WasNotGivenElement != null) dest.WasNotGivenElement = (FhirBoolean)WasNotGivenElement.DeepCopy();
                if (ReportedElement != null) dest.ReportedElement = (FhirBoolean)ReportedElement.DeepCopy();
                if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                if (Requester != null) dest.Requester = (ResourceReference)Requester.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Manufacturer != null) dest.Manufacturer = (ResourceReference)Manufacturer.DeepCopy();
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (LotNumberElement != null) dest.LotNumberElement = (FhirString)LotNumberElement.DeepCopy();
                if (ExpirationDateElement != null) dest.ExpirationDateElement = (Date)ExpirationDateElement.DeepCopy();
                if (Site != null) dest.Site = (CodeableConcept)Site.DeepCopy();
                if (Route != null) dest.Route = (CodeableConcept)Route.DeepCopy();
                if (DoseQuantity != null) dest.DoseQuantity = (SimpleQuantity)DoseQuantity.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Explanation != null) dest.Explanation = (ExplanationComponent)Explanation.DeepCopy();
                if (Reaction != null) dest.Reaction = new List<ReactionComponent>(Reaction.DeepCopy());
                if (VaccinationProtocol != null) dest.VaccinationProtocol = new List<VaccinationProtocolComponent>(VaccinationProtocol.DeepCopy());
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
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(VaccineCode, otherT.VaccineCode)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(WasNotGivenElement, otherT.WasNotGivenElement)) return false;
            if (!DeepComparable.Matches(ReportedElement, otherT.ReportedElement)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if (!DeepComparable.Matches(Site, otherT.Site)) return false;
            if (!DeepComparable.Matches(Route, otherT.Route)) return false;
            if (!DeepComparable.Matches(DoseQuantity, otherT.DoseQuantity)) return false;
            if (!DeepComparable.Matches(Note, otherT.Note)) return false;
            if (!DeepComparable.Matches(Explanation, otherT.Explanation)) return false;
            if (!DeepComparable.Matches(Reaction, otherT.Reaction)) return false;
            if (!DeepComparable.Matches(VaccinationProtocol, otherT.VaccinationProtocol)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Immunization;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(VaccineCode, otherT.VaccineCode)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(WasNotGivenElement, otherT.WasNotGivenElement)) return false;
            if (!DeepComparable.IsExactly(ReportedElement, otherT.ReportedElement)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if (!DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if (!DeepComparable.IsExactly(Site, otherT.Site)) return false;
            if (!DeepComparable.IsExactly(Route, otherT.Route)) return false;
            if (!DeepComparable.IsExactly(DoseQuantity, otherT.DoseQuantity)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Explanation, otherT.Explanation)) return false;
            if (!DeepComparable.IsExactly(Reaction, otherT.Reaction)) return false;
            if (!DeepComparable.IsExactly(VaccinationProtocol, otherT.VaccinationProtocol)) return false;

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
                if (DateElement != null) yield return DateElement;
                if (VaccineCode != null) yield return VaccineCode;
                if (Patient != null) yield return Patient;
                if (WasNotGivenElement != null) yield return WasNotGivenElement;
                if (ReportedElement != null) yield return ReportedElement;
                if (Performer != null) yield return Performer;
                if (Requester != null) yield return Requester;
                if (Encounter != null) yield return Encounter;
                if (Manufacturer != null) yield return Manufacturer;
                if (Location != null) yield return Location;
                if (LotNumberElement != null) yield return LotNumberElement;
                if (ExpirationDateElement != null) yield return ExpirationDateElement;
                if (Site != null) yield return Site;
                if (Route != null) yield return Route;
                if (DoseQuantity != null) yield return DoseQuantity;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                if (Explanation != null) yield return Explanation;
                foreach (var elem in Reaction) { if (elem != null) yield return elem; }
                foreach (var elem in VaccinationProtocol) { if (elem != null) yield return elem; }
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
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (VaccineCode != null) yield return new ElementValue("vaccineCode", VaccineCode);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (WasNotGivenElement != null) yield return new ElementValue("wasNotGiven", WasNotGivenElement);
                if (ReportedElement != null) yield return new ElementValue("reported", ReportedElement);
                if (Performer != null) yield return new ElementValue("performer", Performer);
                if (Requester != null) yield return new ElementValue("requester", Requester);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Manufacturer != null) yield return new ElementValue("manufacturer", Manufacturer);
                if (Location != null) yield return new ElementValue("location", Location);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
                if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
                if (Site != null) yield return new ElementValue("site", Site);
                if (Route != null) yield return new ElementValue("route", Route);
                if (DoseQuantity != null) yield return new ElementValue("doseQuantity", DoseQuantity);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                if (Explanation != null) yield return new ElementValue("explanation", Explanation);
                foreach (var elem in Reaction) { if (elem != null) yield return new ElementValue("reaction", elem); }
                foreach (var elem in VaccinationProtocol) { if (elem != null) yield return new ElementValue("vaccinationProtocol", elem); }
            }
        }

    }

}
