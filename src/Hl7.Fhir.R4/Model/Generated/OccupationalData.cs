using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
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
    /// Patient's or family member's work information (ODH)
    /// </summary>
    [FhirType("OccupationalData", IsResource=true)]
    [DataContract]
    public partial class OccupationalData : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.OccupationalData; } }
        [NotMapped]
        public override string TypeName { get { return "OccupationalData"; } }


        [FhirType("EmploymentStatusComponent")]
        [DataContract]
        public partial class EmploymentStatusComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EmploymentStatusComponent"; } }

            /// <summary>
            /// Employment status code
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Employment status effective time period
            /// </summary>
            [FhirElement("effective", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Period Effective
            {
                get { return _effective; }
                set { _effective = value; OnPropertyChanged("Effective"); }
            }

            private Period _effective;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EmploymentStatusComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Effective != null) dest.Effective = (Period)Effective.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EmploymentStatusComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EmploymentStatusComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EmploymentStatusComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Effective != null) yield return Effective;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (Effective != null) yield return new ElementValue("effective", false, Effective);
                }
            }


        }


        [FhirType("UsualWorkComponent")]
        [DataContract]
        public partial class UsualWorkComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "UsualWorkComponent"; } }

            /// <summary>
            /// Usual Work occupation
            /// </summary>
            [FhirElement("occupation", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Occupation
            {
                get { return _occupation; }
                set { _occupation = value; OnPropertyChanged("Occupation"); }
            }

            private CodeableConcept _occupation;

            /// <summary>
            /// Usual Work industry
            /// </summary>
            [FhirElement("industry", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Industry
            {
                get { return _industry; }
                set { _industry = value; OnPropertyChanged("Industry"); }
            }

            private CodeableConcept _industry;

            /// <summary>
            /// Usual Work start time
            /// </summary>
            [FhirElement("start", InSummary=true, Order=60)]
            [DataMember]
            public FhirDateTime StartElement
            {
                get { return _startElement; }
                set { _startElement = value; OnPropertyChanged("StartElement"); }
            }

            private FhirDateTime _startElement;

            /// <summary>
            /// Usual Work start time
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Start
            {
                get { return StartElement != null ? StartElement.Value : null; }
                set
                {
                    if (value == null)
                        StartElement = null;
                    else
                        StartElement = new FhirDateTime(value);
                    OnPropertyChanged("Start");
                }
            }

            /// <summary>
            /// Usual Work duration
            /// </summary>
            [FhirElement("duration", InSummary=true, Order=70)]
            [DataMember]
            public Duration Duration
            {
                get { return _duration; }
                set { _duration = value; OnPropertyChanged("Duration"); }
            }

            private Duration _duration;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as UsualWorkComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Occupation != null) dest.Occupation = (CodeableConcept)Occupation.DeepCopy();
                    if (Industry != null) dest.Industry = (CodeableConcept)Industry.DeepCopy();
                    if (StartElement != null) dest.StartElement = (FhirDateTime)StartElement.DeepCopy();
                    if (Duration != null) dest.Duration = (Duration)Duration.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new UsualWorkComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as UsualWorkComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Occupation, otherT.Occupation)) return false;
                if (!DeepComparable.Matches(Industry, otherT.Industry)) return false;
                if (!DeepComparable.Matches(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.Matches(Duration, otherT.Duration)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as UsualWorkComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Occupation, otherT.Occupation)) return false;
                if (!DeepComparable.IsExactly(Industry, otherT.Industry)) return false;
                if (!DeepComparable.IsExactly(StartElement, otherT.StartElement)) return false;
                if (!DeepComparable.IsExactly(Duration, otherT.Duration)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Occupation != null) yield return Occupation;
                    if (Industry != null) yield return Industry;
                    if (StartElement != null) yield return StartElement;
                    if (Duration != null) yield return Duration;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Occupation != null) yield return new ElementValue("occupation", false, Occupation);
                    if (Industry != null) yield return new ElementValue("industry", false, Industry);
                    if (StartElement != null) yield return new ElementValue("start", false, StartElement);
                    if (Duration != null) yield return new ElementValue("duration", false, Duration);
                }
            }


        }


        [FhirType("PastOrPresentJobComponent")]
        [DataContract]
        public partial class PastOrPresentJobComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PastOrPresentJobComponent"; } }

            /// <summary>
            /// Past or Present Job occupation
            /// </summary>
            [FhirElement("occupation", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Occupation
            {
                get { return _occupation; }
                set { _occupation = value; OnPropertyChanged("Occupation"); }
            }

            private CodeableConcept _occupation;

            /// <summary>
            /// Past or Present Job industry
            /// </summary>
            [FhirElement("industry", InSummary=true, Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Industry
            {
                get { return _industry; }
                set { _industry = value; OnPropertyChanged("Industry"); }
            }

            private CodeableConcept _industry;

            /// <summary>
            /// Past or Present Job effective time period
            /// </summary>
            [FhirElement("effective", InSummary=true, Order=60)]
            [DataMember]
            public Period Effective
            {
                get { return _effective; }
                set { _effective = value; OnPropertyChanged("Effective"); }
            }

            private Period _effective;

            /// <summary>
            /// Past or Present Job employer
            /// </summary>
            [FhirElement("employer", InSummary=true, Order=70)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Employer
            {
                get { return _employer; }
                set { _employer = value; OnPropertyChanged("Employer"); }
            }

            private ResourceReference _employer;

            /// <summary>
            /// Past or Present Job work classification
            /// </summary>
            [FhirElement("workClassification", InSummary=true, Order=80)]
            [DataMember]
            public CodeableConcept WorkClassification
            {
                get { return _workClassification; }
                set { _workClassification = value; OnPropertyChanged("WorkClassification"); }
            }

            private CodeableConcept _workClassification;

            /// <summary>
            /// Past or Present Job supervisory level
            /// </summary>
            [FhirElement("supervisoryLevel", InSummary=true, Order=90)]
            [DataMember]
            public CodeableConcept SupervisoryLevel
            {
                get { return _supervisoryLevel; }
                set { _supervisoryLevel = value; OnPropertyChanged("SupervisoryLevel"); }
            }

            private CodeableConcept _supervisoryLevel;

            /// <summary>
            /// Past or Present Job job duty
            /// </summary>
            [FhirElement("jobDuty", InSummary=true, Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> JobDutyElement
            {
                get { if (_jobDutyElement==null) _jobDutyElement = new List<FhirString>(); return _jobDutyElement; }
                set { _jobDutyElement = value; OnPropertyChanged("JobDutyElement"); }
            }

            private List<FhirString> _jobDutyElement;

            /// <summary>
            /// Past or Present Job job duty
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> JobDuty
            {
                get { return JobDutyElement != null ? JobDutyElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        JobDutyElement = null;
                    else
                        JobDutyElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("JobDuty");
                }
            }

            /// <summary>
            /// Past or Present Job occupational hazard
            /// </summary>
            [FhirElement("occupationalHazard", InSummary=true, Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<FhirString> OccupationalHazardElement
            {
                get { if (_occupationalHazardElement==null) _occupationalHazardElement = new List<FhirString>(); return _occupationalHazardElement; }
                set { _occupationalHazardElement = value; OnPropertyChanged("OccupationalHazardElement"); }
            }

            private List<FhirString> _occupationalHazardElement;

            /// <summary>
            /// Past or Present Job occupational hazard
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> OccupationalHazard
            {
                get { return OccupationalHazardElement != null ? OccupationalHazardElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        OccupationalHazardElement = null;
                    else
                        OccupationalHazardElement = new List<FhirString>(value.Select(elem=>new FhirString(elem)));
                    OnPropertyChanged("OccupationalHazard");
                }
            }

            /// <summary>
            /// Past or Present Job work schedule
            /// </summary>
            [FhirElement("workSchedule", InSummary=true, Order=120)]
            [DataMember]
            public WorkScheduleComponent WorkSchedule
            {
                get { return _workSchedule; }
                set { _workSchedule = value; OnPropertyChanged("WorkSchedule"); }
            }

            private WorkScheduleComponent _workSchedule;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PastOrPresentJobComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Occupation != null) dest.Occupation = (CodeableConcept)Occupation.DeepCopy();
                    if (Industry != null) dest.Industry = (CodeableConcept)Industry.DeepCopy();
                    if (Effective != null) dest.Effective = (Period)Effective.DeepCopy();
                    if (Employer != null) dest.Employer = (ResourceReference)Employer.DeepCopy();
                    if (WorkClassification != null) dest.WorkClassification = (CodeableConcept)WorkClassification.DeepCopy();
                    if (SupervisoryLevel != null) dest.SupervisoryLevel = (CodeableConcept)SupervisoryLevel.DeepCopy();
                    if (JobDutyElement != null) dest.JobDutyElement = new List<FhirString>(JobDutyElement.DeepCopy());
                    if (OccupationalHazardElement != null) dest.OccupationalHazardElement = new List<FhirString>(OccupationalHazardElement.DeepCopy());
                    if (WorkSchedule != null) dest.WorkSchedule = (WorkScheduleComponent)WorkSchedule.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PastOrPresentJobComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PastOrPresentJobComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Occupation, otherT.Occupation)) return false;
                if (!DeepComparable.Matches(Industry, otherT.Industry)) return false;
                if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;
                if (!DeepComparable.Matches(Employer, otherT.Employer)) return false;
                if (!DeepComparable.Matches(WorkClassification, otherT.WorkClassification)) return false;
                if (!DeepComparable.Matches(SupervisoryLevel, otherT.SupervisoryLevel)) return false;
                if ( !DeepComparable.Matches(JobDutyElement, otherT.JobDutyElement)) return false;
                if ( !DeepComparable.Matches(OccupationalHazardElement, otherT.OccupationalHazardElement)) return false;
                if (!DeepComparable.Matches(WorkSchedule, otherT.WorkSchedule)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PastOrPresentJobComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Occupation, otherT.Occupation)) return false;
                if (!DeepComparable.IsExactly(Industry, otherT.Industry)) return false;
                if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
                if (!DeepComparable.IsExactly(Employer, otherT.Employer)) return false;
                if (!DeepComparable.IsExactly(WorkClassification, otherT.WorkClassification)) return false;
                if (!DeepComparable.IsExactly(SupervisoryLevel, otherT.SupervisoryLevel)) return false;
                if (!DeepComparable.IsExactly(JobDutyElement, otherT.JobDutyElement)) return false;
                if (!DeepComparable.IsExactly(OccupationalHazardElement, otherT.OccupationalHazardElement)) return false;
                if (!DeepComparable.IsExactly(WorkSchedule, otherT.WorkSchedule)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Occupation != null) yield return Occupation;
                    if (Industry != null) yield return Industry;
                    if (Effective != null) yield return Effective;
                    if (Employer != null) yield return Employer;
                    if (WorkClassification != null) yield return WorkClassification;
                    if (SupervisoryLevel != null) yield return SupervisoryLevel;
                    foreach (var elem in JobDutyElement) { if (elem != null) yield return elem; }
                    foreach (var elem in OccupationalHazardElement) { if (elem != null) yield return elem; }
                    if (WorkSchedule != null) yield return WorkSchedule;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Occupation != null) yield return new ElementValue("occupation", false, Occupation);
                    if (Industry != null) yield return new ElementValue("industry", false, Industry);
                    if (Effective != null) yield return new ElementValue("effective", false, Effective);
                    if (Employer != null) yield return new ElementValue("employer", false, Employer);
                    if (WorkClassification != null) yield return new ElementValue("workClassification", false, WorkClassification);
                    if (SupervisoryLevel != null) yield return new ElementValue("supervisoryLevel", false, SupervisoryLevel);
                    foreach (var elem in JobDutyElement) { if (elem != null) yield return new ElementValue("jobDuty", true, elem); }
                    foreach (var elem in OccupationalHazardElement) { if (elem != null) yield return new ElementValue("occupationalHazard", true, elem); }
                    if (WorkSchedule != null) yield return new ElementValue("workSchedule", false, WorkSchedule);
                }
            }


        }


        [FhirType("WorkScheduleComponent")]
        [DataContract]
        public partial class WorkScheduleComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "WorkScheduleComponent"; } }

            /// <summary>
            /// Past or Present Job work schedule code
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Past or Present Job work schedule weekly work days
            /// </summary>
            [FhirElement("weeklyWorkDays", InSummary=true, Order=50)]
            [DataMember]
            public FhirDecimal WeeklyWorkDaysElement
            {
                get { return _weeklyWorkDaysElement; }
                set { _weeklyWorkDaysElement = value; OnPropertyChanged("WeeklyWorkDaysElement"); }
            }

            private FhirDecimal _weeklyWorkDaysElement;

            /// <summary>
            /// Past or Present Job work schedule weekly work days
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? WeeklyWorkDays
            {
                get { return WeeklyWorkDaysElement != null ? WeeklyWorkDaysElement.Value : null; }
                set
                {
                    if (value == null)
                        WeeklyWorkDaysElement = null;
                    else
                        WeeklyWorkDaysElement = new FhirDecimal(value);
                    OnPropertyChanged("WeeklyWorkDays");
                }
            }

            /// <summary>
            /// Past or Present Job work schedule daily work hours
            /// </summary>
            [FhirElement("dailyWorkHours", InSummary=true, Order=60)]
            [DataMember]
            public FhirDecimal DailyWorkHoursElement
            {
                get { return _dailyWorkHoursElement; }
                set { _dailyWorkHoursElement = value; OnPropertyChanged("DailyWorkHoursElement"); }
            }

            private FhirDecimal _dailyWorkHoursElement;

            /// <summary>
            /// Past or Present Job work schedule daily work hours
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? DailyWorkHours
            {
                get { return DailyWorkHoursElement != null ? DailyWorkHoursElement.Value : null; }
                set
                {
                    if (value == null)
                        DailyWorkHoursElement = null;
                    else
                        DailyWorkHoursElement = new FhirDecimal(value);
                    OnPropertyChanged("DailyWorkHours");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as WorkScheduleComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (WeeklyWorkDaysElement != null) dest.WeeklyWorkDaysElement = (FhirDecimal)WeeklyWorkDaysElement.DeepCopy();
                    if (DailyWorkHoursElement != null) dest.DailyWorkHoursElement = (FhirDecimal)DailyWorkHoursElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new WorkScheduleComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as WorkScheduleComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(WeeklyWorkDaysElement, otherT.WeeklyWorkDaysElement)) return false;
                if (!DeepComparable.Matches(DailyWorkHoursElement, otherT.DailyWorkHoursElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as WorkScheduleComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(WeeklyWorkDaysElement, otherT.WeeklyWorkDaysElement)) return false;
                if (!DeepComparable.IsExactly(DailyWorkHoursElement, otherT.DailyWorkHoursElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (WeeklyWorkDaysElement != null) yield return WeeklyWorkDaysElement;
                    if (DailyWorkHoursElement != null) yield return DailyWorkHoursElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (WeeklyWorkDaysElement != null) yield return new ElementValue("weeklyWorkDays", false, WeeklyWorkDaysElement);
                    if (DailyWorkHoursElement != null) yield return new ElementValue("dailyWorkHours", false, DailyWorkHoursElement);
                }
            }


        }


        /// <summary>
        /// Unique identifier for the occupational data (ODH) record
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<PublicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<PublicationStatus> _statusElement;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Who the occupational data (ODH) is collected about
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=110)]
        [References("Patient","RelatedPerson")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Occupational Data (ODH) recording time
        /// </summary>
        [FhirElement("date", Order=120)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Occupational Data (ODH) recording time
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
        /// Occupational Data (ODH) recorder
        /// </summary>
        [FhirElement("recorder", Order=130)]
        [References("Practitioner","PractitionerRole","Patient","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Recorder
        {
            get { if (_recorder==null) _recorder = new List<ResourceReference>(); return _recorder; }
            set { _recorder = value; OnPropertyChanged("Recorder"); }
        }

        private List<ResourceReference> _recorder;

        /// <summary>
        /// Occupational Data (ODH) informant
        /// </summary>
        [FhirElement("informant", Order=140)]
        [References("Patient","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Informant
        {
            get { if (_informant==null) _informant = new List<ResourceReference>(); return _informant; }
            set { _informant = value; OnPropertyChanged("Informant"); }
        }

        private List<ResourceReference> _informant;

        /// <summary>
        /// Employment status
        /// </summary>
        [FhirElement("employmentStatus", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EmploymentStatusComponent> EmploymentStatus
        {
            get { if (_employmentStatus==null) _employmentStatus = new List<EmploymentStatusComponent>(); return _employmentStatus; }
            set { _employmentStatus = value; OnPropertyChanged("EmploymentStatus"); }
        }

        private List<EmploymentStatusComponent> _employmentStatus;

        /// <summary>
        /// Retirement date
        /// </summary>
        [FhirElement("retirementDate", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirDateTime> RetirementDateElement
        {
            get { if (_retirementDateElement==null) _retirementDateElement = new List<FhirDateTime>(); return _retirementDateElement; }
            set { _retirementDateElement = value; OnPropertyChanged("RetirementDateElement"); }
        }

        private List<FhirDateTime> _retirementDateElement;

        /// <summary>
        /// Retirement date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> RetirementDate
        {
            get { return RetirementDateElement != null ? RetirementDateElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    RetirementDateElement = null;
                else
                    RetirementDateElement = new List<FhirDateTime>(value.Select(elem=>new FhirDateTime(elem)));
                OnPropertyChanged("RetirementDate");
            }
        }

        /// <summary>
        /// Combat Zone Work period
        /// </summary>
        [FhirElement("combatZonePeriod", InSummary=true, Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Period> CombatZonePeriod
        {
            get { if (_combatZonePeriod==null) _combatZonePeriod = new List<Period>(); return _combatZonePeriod; }
            set { _combatZonePeriod = value; OnPropertyChanged("CombatZonePeriod"); }
        }

        private List<Period> _combatZonePeriod;

        /// <summary>
        /// Usual Work
        /// </summary>
        [FhirElement("usualWork", InSummary=true, Order=180)]
        [DataMember]
        public UsualWorkComponent UsualWork
        {
            get { return _usualWork; }
            set { _usualWork = value; OnPropertyChanged("UsualWork"); }
        }

        private UsualWorkComponent _usualWork;

        /// <summary>
        /// Past or Present Job
        /// </summary>
        [FhirElement("pastOrPresentJob", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PastOrPresentJobComponent> PastOrPresentJob
        {
            get { if (_pastOrPresentJob==null) _pastOrPresentJob = new List<PastOrPresentJobComponent>(); return _pastOrPresentJob; }
            set { _pastOrPresentJob = value; OnPropertyChanged("PastOrPresentJob"); }
        }

        private List<PastOrPresentJobComponent> _pastOrPresentJob;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as OccupationalData;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Recorder != null) dest.Recorder = new List<ResourceReference>(Recorder.DeepCopy());
                if (Informant != null) dest.Informant = new List<ResourceReference>(Informant.DeepCopy());
                if (EmploymentStatus != null) dest.EmploymentStatus = new List<EmploymentStatusComponent>(EmploymentStatus.DeepCopy());
                if (RetirementDateElement != null) dest.RetirementDateElement = new List<FhirDateTime>(RetirementDateElement.DeepCopy());
                if (CombatZonePeriod != null) dest.CombatZonePeriod = new List<Period>(CombatZonePeriod.DeepCopy());
                if (UsualWork != null) dest.UsualWork = (UsualWorkComponent)UsualWork.DeepCopy();
                if (PastOrPresentJob != null) dest.PastOrPresentJob = new List<PastOrPresentJobComponent>(PastOrPresentJob.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new OccupationalData());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as OccupationalData;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if ( !DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if ( !DeepComparable.Matches(Informant, otherT.Informant)) return false;
            if ( !DeepComparable.Matches(EmploymentStatus, otherT.EmploymentStatus)) return false;
            if ( !DeepComparable.Matches(RetirementDateElement, otherT.RetirementDateElement)) return false;
            if ( !DeepComparable.Matches(CombatZonePeriod, otherT.CombatZonePeriod)) return false;
            if (!DeepComparable.Matches(UsualWork, otherT.UsualWork)) return false;
            if ( !DeepComparable.Matches(PastOrPresentJob, otherT.PastOrPresentJob)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as OccupationalData;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.IsExactly(Informant, otherT.Informant)) return false;
            if (!DeepComparable.IsExactly(EmploymentStatus, otherT.EmploymentStatus)) return false;
            if (!DeepComparable.IsExactly(RetirementDateElement, otherT.RetirementDateElement)) return false;
            if (!DeepComparable.IsExactly(CombatZonePeriod, otherT.CombatZonePeriod)) return false;
            if (!DeepComparable.IsExactly(UsualWork, otherT.UsualWork)) return false;
            if (!DeepComparable.IsExactly(PastOrPresentJob, otherT.PastOrPresentJob)) return false;

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
                if (Subject != null) yield return Subject;
                if (DateElement != null) yield return DateElement;
                foreach (var elem in Recorder) { if (elem != null) yield return elem; }
                foreach (var elem in Informant) { if (elem != null) yield return elem; }
                foreach (var elem in EmploymentStatus) { if (elem != null) yield return elem; }
                foreach (var elem in RetirementDateElement) { if (elem != null) yield return elem; }
                foreach (var elem in CombatZonePeriod) { if (elem != null) yield return elem; }
                if (UsualWork != null) yield return UsualWork;
                foreach (var elem in PastOrPresentJob) { if (elem != null) yield return elem; }
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
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                foreach (var elem in Recorder) { if (elem != null) yield return new ElementValue("recorder", true, elem); }
                foreach (var elem in Informant) { if (elem != null) yield return new ElementValue("informant", true, elem); }
                foreach (var elem in EmploymentStatus) { if (elem != null) yield return new ElementValue("employmentStatus", true, elem); }
                foreach (var elem in RetirementDateElement) { if (elem != null) yield return new ElementValue("retirementDate", true, elem); }
                foreach (var elem in CombatZonePeriod) { if (elem != null) yield return new ElementValue("combatZonePeriod", true, elem); }
                if (UsualWork != null) yield return new ElementValue("usualWork", false, UsualWork);
                foreach (var elem in PastOrPresentJob) { if (elem != null) yield return new ElementValue("pastOrPresentJob", true, elem); }
            }
        }

    }

}
