using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.STU3;
using Hl7.Fhir.Validation.STU3;
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
// Generated for FHIR v3.0.1
//
namespace Hl7.Fhir.Model.STU3
{
    /// <summary>
    /// A timing schedule that specifies an event that may occur multiple times
    /// </summary>
    [FhirType("Timing")]
    [DataContract]
    public partial class Timing : Element
    {
        [NotMapped]
        public override string TypeName { get { return "Timing"; } }


        [FhirType("RepeatComponent")]
        [DataContract]
        public partial class RepeatComponent : Element
        {
            [NotMapped]
            public override string TypeName { get { return "RepeatComponent"; } }

            /// <summary>
            /// Length/Range of lengths, or (Start and/or end) limits
            /// </summary>
            [FhirElement("bounds", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Duration),typeof(Range),typeof(Period))]
            [DataMember]
            public Element Bounds
            {
                get { return _bounds; }
                set { _bounds = value; OnPropertyChanged("Bounds"); }
            }

            private Element _bounds;

            /// <summary>
            /// Number of times to repeat
            /// </summary>
            [FhirElement("count", InSummary=true, Order=50)]
            [DataMember]
            public Integer CountElement
            {
                get { return _countElement; }
                set { _countElement = value; OnPropertyChanged("CountElement"); }
            }

            private Integer _countElement;

            /// <summary>
            /// Number of times to repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Count
            {
                get { return CountElement != null ? CountElement.Value : null; }
                set
                {
                    if (value == null)
                        CountElement = null;
                    else
                        CountElement = new Integer(value);
                    OnPropertyChanged("Count");
                }
            }

            /// <summary>
            /// Maximum number of times to repeat
            /// </summary>
            [FhirElement("countMax", InSummary=true, Order=60)]
            [DataMember]
            public Integer CountMaxElement
            {
                get { return _countMaxElement; }
                set { _countMaxElement = value; OnPropertyChanged("CountMaxElement"); }
            }

            private Integer _countMaxElement;

            /// <summary>
            /// Maximum number of times to repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? CountMax
            {
                get { return CountMaxElement != null ? CountMaxElement.Value : null; }
                set
                {
                    if (value == null)
                        CountMaxElement = null;
                    else
                        CountMaxElement = new Integer(value);
                    OnPropertyChanged("CountMax");
                }
            }

            /// <summary>
            /// How long when it happens
            /// </summary>
            [FhirElement("duration", InSummary=true, Order=70)]
            [DataMember]
            public FhirDecimal DurationElement
            {
                get { return _durationElement; }
                set { _durationElement = value; OnPropertyChanged("DurationElement"); }
            }

            private FhirDecimal _durationElement;

            /// <summary>
            /// How long when it happens
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Duration
            {
                get { return DurationElement != null ? DurationElement.Value : null; }
                set
                {
                    if (value == null)
                        DurationElement = null;
                    else
                        DurationElement = new FhirDecimal(value);
                    OnPropertyChanged("Duration");
                }
            }

            /// <summary>
            /// How long when it happens (Max)
            /// </summary>
            [FhirElement("durationMax", InSummary=true, Order=80)]
            [DataMember]
            public FhirDecimal DurationMaxElement
            {
                get { return _durationMaxElement; }
                set { _durationMaxElement = value; OnPropertyChanged("DurationMaxElement"); }
            }

            private FhirDecimal _durationMaxElement;

            /// <summary>
            /// How long when it happens (Max)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? DurationMax
            {
                get { return DurationMaxElement != null ? DurationMaxElement.Value : null; }
                set
                {
                    if (value == null)
                        DurationMaxElement = null;
                    else
                        DurationMaxElement = new FhirDecimal(value);
                    OnPropertyChanged("DurationMax");
                }
            }

            /// <summary>
            /// s | min | h | d | wk | mo | a - unit of time (UCUM)
            /// </summary>
            [FhirElement("durationUnit", InSummary=true, Order=90)]
            [DataMember]
            public Code<UnitsOfTime> DurationUnitElement
            {
                get { return _durationUnitElement; }
                set { _durationUnitElement = value; OnPropertyChanged("DurationUnitElement"); }
            }

            private Code<UnitsOfTime> _durationUnitElement;

            /// <summary>
            /// s | min | h | d | wk | mo | a - unit of time (UCUM)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public UnitsOfTime? DurationUnit
            {
                get { return DurationUnitElement != null ? DurationUnitElement.Value : null; }
                set
                {
                    if (value == null)
                        DurationUnitElement = null;
                    else
                        DurationUnitElement = new Code<UnitsOfTime>(value);
                    OnPropertyChanged("DurationUnit");
                }
            }

            /// <summary>
            /// Event occurs frequency times per period
            /// </summary>
            [FhirElement("frequency", InSummary=true, Order=100)]
            [DataMember]
            public Integer FrequencyElement
            {
                get { return _frequencyElement; }
                set { _frequencyElement = value; OnPropertyChanged("FrequencyElement"); }
            }

            private Integer _frequencyElement;

            /// <summary>
            /// Event occurs frequency times per period
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Frequency
            {
                get { return FrequencyElement != null ? FrequencyElement.Value : null; }
                set
                {
                    if (value == null)
                        FrequencyElement = null;
                    else
                        FrequencyElement = new Integer(value);
                    OnPropertyChanged("Frequency");
                }
            }

            /// <summary>
            /// Event occurs up to frequencyMax times per period
            /// </summary>
            [FhirElement("frequencyMax", InSummary=true, Order=110)]
            [DataMember]
            public Integer FrequencyMaxElement
            {
                get { return _frequencyMaxElement; }
                set { _frequencyMaxElement = value; OnPropertyChanged("FrequencyMaxElement"); }
            }

            private Integer _frequencyMaxElement;

            /// <summary>
            /// Event occurs up to frequencyMax times per period
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? FrequencyMax
            {
                get { return FrequencyMaxElement != null ? FrequencyMaxElement.Value : null; }
                set
                {
                    if (value == null)
                        FrequencyMaxElement = null;
                    else
                        FrequencyMaxElement = new Integer(value);
                    OnPropertyChanged("FrequencyMax");
                }
            }

            /// <summary>
            /// Event occurs frequency times per period
            /// </summary>
            [FhirElement("period", InSummary=true, Order=120)]
            [DataMember]
            public FhirDecimal PeriodElement
            {
                get { return _periodElement; }
                set { _periodElement = value; OnPropertyChanged("PeriodElement"); }
            }

            private FhirDecimal _periodElement;

            /// <summary>
            /// Event occurs frequency times per period
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? Period
            {
                get { return PeriodElement != null ? PeriodElement.Value : null; }
                set
                {
                    if (value == null)
                        PeriodElement = null;
                    else
                        PeriodElement = new FhirDecimal(value);
                    OnPropertyChanged("Period");
                }
            }

            /// <summary>
            /// Upper limit of period (3-4 hours)
            /// </summary>
            [FhirElement("periodMax", InSummary=true, Order=130)]
            [DataMember]
            public FhirDecimal PeriodMaxElement
            {
                get { return _periodMaxElement; }
                set { _periodMaxElement = value; OnPropertyChanged("PeriodMaxElement"); }
            }

            private FhirDecimal _periodMaxElement;

            /// <summary>
            /// Upper limit of period (3-4 hours)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public decimal? PeriodMax
            {
                get { return PeriodMaxElement != null ? PeriodMaxElement.Value : null; }
                set
                {
                    if (value == null)
                        PeriodMaxElement = null;
                    else
                        PeriodMaxElement = new FhirDecimal(value);
                    OnPropertyChanged("PeriodMax");
                }
            }

            /// <summary>
            /// s | min | h | d | wk | mo | a - unit of time (UCUM)
            /// </summary>
            [FhirElement("periodUnit", InSummary=true, Order=140)]
            [DataMember]
            public Code<UnitsOfTime> PeriodUnitElement
            {
                get { return _periodUnitElement; }
                set { _periodUnitElement = value; OnPropertyChanged("PeriodUnitElement"); }
            }

            private Code<UnitsOfTime> _periodUnitElement;

            /// <summary>
            /// s | min | h | d | wk | mo | a - unit of time (UCUM)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public UnitsOfTime? PeriodUnit
            {
                get { return PeriodUnitElement != null ? PeriodUnitElement.Value : null; }
                set
                {
                    if (value == null)
                        PeriodUnitElement = null;
                    else
                        PeriodUnitElement = new Code<UnitsOfTime>(value);
                    OnPropertyChanged("PeriodUnit");
                }
            }

            /// <summary>
            /// mon | tue | wed | thu | fri | sat | sun
            /// </summary>
            [FhirElement("dayOfWeek", InSummary=true, Order=150)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<DaysOfWeek>> DayOfWeekElement
            {
                get { if (_dayOfWeekElement==null) _dayOfWeekElement = new List<Code<DaysOfWeek>>(); return _dayOfWeekElement; }
                set { _dayOfWeekElement = value; OnPropertyChanged("DayOfWeekElement"); }
            }

            private List<Code<DaysOfWeek>> _dayOfWeekElement;

            /// <summary>
            /// mon | tue | wed | thu | fri | sat | sun
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<DaysOfWeek?> DayOfWeek
            {
                get { return DayOfWeekElement != null ? DayOfWeekElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        DayOfWeekElement = null;
                    else
                        DayOfWeekElement = new List<Code<DaysOfWeek>>(value.Select(elem=>new Code<DaysOfWeek>(elem)));
                    OnPropertyChanged("DayOfWeek");
                }
            }

            /// <summary>
            /// Time of day for action
            /// </summary>
            [FhirElement("timeOfDay", InSummary=true, Order=160)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Time> TimeOfDayElement
            {
                get { if (_timeOfDayElement==null) _timeOfDayElement = new List<Time>(); return _timeOfDayElement; }
                set { _timeOfDayElement = value; OnPropertyChanged("TimeOfDayElement"); }
            }

            private List<Time> _timeOfDayElement;

            /// <summary>
            /// Time of day for action
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<string> TimeOfDay
            {
                get { return TimeOfDayElement != null ? TimeOfDayElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        TimeOfDayElement = null;
                    else
                        TimeOfDayElement = new List<Time>(value.Select(elem=>new Time(elem)));
                    OnPropertyChanged("TimeOfDay");
                }
            }

            /// <summary>
            /// Regular life events the event is tied to
            /// </summary>
            [FhirElement("when", InSummary=true, Order=170)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Code<EventTiming>> WhenElement
            {
                get { if (_whenElement==null) _whenElement = new List<Code<EventTiming>>(); return _whenElement; }
                set { _whenElement = value; OnPropertyChanged("WhenElement"); }
            }

            private List<Code<EventTiming>> _whenElement;

            /// <summary>
            /// Regular life events the event is tied to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<EventTiming?> When
            {
                get { return WhenElement != null ? WhenElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        WhenElement = null;
                    else
                        WhenElement = new List<Code<EventTiming>>(value.Select(elem=>new Code<EventTiming>(elem)));
                    OnPropertyChanged("When");
                }
            }

            /// <summary>
            /// Minutes from event (before or after)
            /// </summary>
            [FhirElement("offset", InSummary=true, Order=180)]
            [DataMember]
            public UnsignedInt OffsetElement
            {
                get { return _offsetElement; }
                set { _offsetElement = value; OnPropertyChanged("OffsetElement"); }
            }

            private UnsignedInt _offsetElement;

            /// <summary>
            /// Minutes from event (before or after)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Offset
            {
                get { return OffsetElement != null ? OffsetElement.Value : null; }
                set
                {
                    if (value == null)
                        OffsetElement = null;
                    else
                        OffsetElement = new UnsignedInt(value);
                    OnPropertyChanged("Offset");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RepeatComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Bounds != null) dest.Bounds = (Element)Bounds.DeepCopy();
                    if (CountElement != null) dest.CountElement = (Integer)CountElement.DeepCopy();
                    if (CountMaxElement != null) dest.CountMaxElement = (Integer)CountMaxElement.DeepCopy();
                    if (DurationElement != null) dest.DurationElement = (FhirDecimal)DurationElement.DeepCopy();
                    if (DurationMaxElement != null) dest.DurationMaxElement = (FhirDecimal)DurationMaxElement.DeepCopy();
                    if (DurationUnitElement != null) dest.DurationUnitElement = (Code<UnitsOfTime>)DurationUnitElement.DeepCopy();
                    if (FrequencyElement != null) dest.FrequencyElement = (Integer)FrequencyElement.DeepCopy();
                    if (FrequencyMaxElement != null) dest.FrequencyMaxElement = (Integer)FrequencyMaxElement.DeepCopy();
                    if (PeriodElement != null) dest.PeriodElement = (FhirDecimal)PeriodElement.DeepCopy();
                    if (PeriodMaxElement != null) dest.PeriodMaxElement = (FhirDecimal)PeriodMaxElement.DeepCopy();
                    if (PeriodUnitElement != null) dest.PeriodUnitElement = (Code<UnitsOfTime>)PeriodUnitElement.DeepCopy();
                    if (DayOfWeekElement != null) dest.DayOfWeekElement = new List<Code<DaysOfWeek>>(DayOfWeekElement.DeepCopy());
                    if (TimeOfDayElement != null) dest.TimeOfDayElement = new List<Time>(TimeOfDayElement.DeepCopy());
                    if (WhenElement != null) dest.WhenElement = new List<Code<EventTiming>>(WhenElement.DeepCopy());
                    if (OffsetElement != null) dest.OffsetElement = (UnsignedInt)OffsetElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RepeatComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RepeatComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Bounds, otherT.Bounds)) return false;
                if (!DeepComparable.Matches(CountElement, otherT.CountElement)) return false;
                if (!DeepComparable.Matches(CountMaxElement, otherT.CountMaxElement)) return false;
                if (!DeepComparable.Matches(DurationElement, otherT.DurationElement)) return false;
                if (!DeepComparable.Matches(DurationMaxElement, otherT.DurationMaxElement)) return false;
                if (!DeepComparable.Matches(DurationUnitElement, otherT.DurationUnitElement)) return false;
                if (!DeepComparable.Matches(FrequencyElement, otherT.FrequencyElement)) return false;
                if (!DeepComparable.Matches(FrequencyMaxElement, otherT.FrequencyMaxElement)) return false;
                if (!DeepComparable.Matches(PeriodElement, otherT.PeriodElement)) return false;
                if (!DeepComparable.Matches(PeriodMaxElement, otherT.PeriodMaxElement)) return false;
                if (!DeepComparable.Matches(PeriodUnitElement, otherT.PeriodUnitElement)) return false;
                if ( !DeepComparable.Matches(DayOfWeekElement, otherT.DayOfWeekElement)) return false;
                if ( !DeepComparable.Matches(TimeOfDayElement, otherT.TimeOfDayElement)) return false;
                if ( !DeepComparable.Matches(WhenElement, otherT.WhenElement)) return false;
                if (!DeepComparable.Matches(OffsetElement, otherT.OffsetElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RepeatComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Bounds, otherT.Bounds)) return false;
                if (!DeepComparable.IsExactly(CountElement, otherT.CountElement)) return false;
                if (!DeepComparable.IsExactly(CountMaxElement, otherT.CountMaxElement)) return false;
                if (!DeepComparable.IsExactly(DurationElement, otherT.DurationElement)) return false;
                if (!DeepComparable.IsExactly(DurationMaxElement, otherT.DurationMaxElement)) return false;
                if (!DeepComparable.IsExactly(DurationUnitElement, otherT.DurationUnitElement)) return false;
                if (!DeepComparable.IsExactly(FrequencyElement, otherT.FrequencyElement)) return false;
                if (!DeepComparable.IsExactly(FrequencyMaxElement, otherT.FrequencyMaxElement)) return false;
                if (!DeepComparable.IsExactly(PeriodElement, otherT.PeriodElement)) return false;
                if (!DeepComparable.IsExactly(PeriodMaxElement, otherT.PeriodMaxElement)) return false;
                if (!DeepComparable.IsExactly(PeriodUnitElement, otherT.PeriodUnitElement)) return false;
                if (!DeepComparable.IsExactly(DayOfWeekElement, otherT.DayOfWeekElement)) return false;
                if (!DeepComparable.IsExactly(TimeOfDayElement, otherT.TimeOfDayElement)) return false;
                if (!DeepComparable.IsExactly(WhenElement, otherT.WhenElement)) return false;
                if (!DeepComparable.IsExactly(OffsetElement, otherT.OffsetElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Bounds != null) yield return Bounds;
                    if (CountElement != null) yield return CountElement;
                    if (CountMaxElement != null) yield return CountMaxElement;
                    if (DurationElement != null) yield return DurationElement;
                    if (DurationMaxElement != null) yield return DurationMaxElement;
                    if (DurationUnitElement != null) yield return DurationUnitElement;
                    if (FrequencyElement != null) yield return FrequencyElement;
                    if (FrequencyMaxElement != null) yield return FrequencyMaxElement;
                    if (PeriodElement != null) yield return PeriodElement;
                    if (PeriodMaxElement != null) yield return PeriodMaxElement;
                    if (PeriodUnitElement != null) yield return PeriodUnitElement;
                    foreach (var elem in DayOfWeekElement) { if (elem != null) yield return elem; }
                    foreach (var elem in TimeOfDayElement) { if (elem != null) yield return elem; }
                    foreach (var elem in WhenElement) { if (elem != null) yield return elem; }
                    if (OffsetElement != null) yield return OffsetElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Bounds != null) yield return new ElementValue("bounds", Bounds);
                    if (CountElement != null) yield return new ElementValue("count", CountElement);
                    if (CountMaxElement != null) yield return new ElementValue("countMax", CountMaxElement);
                    if (DurationElement != null) yield return new ElementValue("duration", DurationElement);
                    if (DurationMaxElement != null) yield return new ElementValue("durationMax", DurationMaxElement);
                    if (DurationUnitElement != null) yield return new ElementValue("durationUnit", DurationUnitElement);
                    if (FrequencyElement != null) yield return new ElementValue("frequency", FrequencyElement);
                    if (FrequencyMaxElement != null) yield return new ElementValue("frequencyMax", FrequencyMaxElement);
                    if (PeriodElement != null) yield return new ElementValue("period", PeriodElement);
                    if (PeriodMaxElement != null) yield return new ElementValue("periodMax", PeriodMaxElement);
                    if (PeriodUnitElement != null) yield return new ElementValue("periodUnit", PeriodUnitElement);
                    foreach (var elem in DayOfWeekElement) { if (elem != null) yield return new ElementValue("dayOfWeek", elem); }
                    foreach (var elem in TimeOfDayElement) { if (elem != null) yield return new ElementValue("timeOfDay", elem); }
                    foreach (var elem in WhenElement) { if (elem != null) yield return new ElementValue("when", elem); }
                    if (OffsetElement != null) yield return new ElementValue("offset", OffsetElement);
                }
            }


        }


        /// <summary>
        /// When the event occurs
        /// </summary>
        [FhirElement("event", InSummary=true, Order=30)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirDateTime> EventElement
        {
            get { if (_eventElement==null) _eventElement = new List<FhirDateTime>(); return _eventElement; }
            set { _eventElement = value; OnPropertyChanged("EventElement"); }
        }

        private List<FhirDateTime> _eventElement;

        /// <summary>
        /// When the event occurs
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Event
        {
            get { return EventElement != null ? EventElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    EventElement = null;
                else
                    EventElement = new List<FhirDateTime>(value.Select(elem=>new FhirDateTime(elem)));
                OnPropertyChanged("Event");
            }
        }

        /// <summary>
        /// When the event is to occur
        /// </summary>
        [FhirElement("repeat", InSummary=true, Order=40)]
        [DataMember]
        public RepeatComponent Repeat
        {
            get { return _repeat; }
            set { _repeat = value; OnPropertyChanged("Repeat"); }
        }

        private RepeatComponent _repeat;

        /// <summary>
        /// BID | TID | QID | AM | PM | QD | QOD | Q4H | Q6H +
        /// </summary>
        [FhirElement("code", InSummary=true, Order=50)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;


        public static ElementDefinition.ConstraintComponent Timing_TIM_9 = new ElementDefinition.ConstraintComponent
        {
            Expression = "repeat.all(offset.empty() or (when.exists() and ((when in ('C' | 'CM' | 'CD' | 'CV')).not())))",
            Key = "tim-9",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's an offset, there must be a when (and not C, CM, CD, CV)",
            Xpath = "not(exists(f:offset)) or exists(f:when)"
        };

        public static ElementDefinition.ConstraintComponent Timing_TIM_5 = new ElementDefinition.ConstraintComponent
        {
            Expression = "repeat.all(period.exists() implies period >= 0)",
            Key = "tim-5",
            Severity = ConstraintSeverity.Warning,
            Human = "period SHALL be a non-negative value",
            Xpath = "f:period/@value >= 0 or not(f:period/@value)"
        };

        public static ElementDefinition.ConstraintComponent Timing_TIM_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "repeat.all(periodMax.empty() or period.exists())",
            Key = "tim-6",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's a periodMax, there must be a period",
            Xpath = "not(exists(f:periodMax)) or exists(f:period)"
        };

        public static ElementDefinition.ConstraintComponent Timing_TIM_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "repeat.all(durationMax.empty() or duration.exists())",
            Key = "tim-7",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's a durationMax, there must be a duration",
            Xpath = "not(exists(f:durationMax)) or exists(f:duration)"
        };

        public static ElementDefinition.ConstraintComponent Timing_TIM_8 = new ElementDefinition.ConstraintComponent
        {
            Expression = "repeat.all(countMax.empty() or count.exists())",
            Key = "tim-8",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's a countMax, there must be a count",
            Xpath = "not(exists(f:countMax)) or exists(f:count)"
        };

        public static ElementDefinition.ConstraintComponent Timing_TIM_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "repeat.all(duration.empty() or durationUnit.exists())",
            Key = "tim-1",
            Severity = ConstraintSeverity.Warning,
            Human = "if there's a duration, there needs to be duration units",
            Xpath = "not(exists(f:duration)) or exists(f:durationUnit)"
        };

        public static ElementDefinition.ConstraintComponent Timing_TIM_10 = new ElementDefinition.ConstraintComponent
        {
            Expression = "repeat.all(timeOfDay.empty() or when.empty())",
            Key = "tim-10",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's a timeOfDay, there cannot be be a when, or vice versa",
            Xpath = "not(exists(f:timeOfDay)) or not(exists(f:when))"
        };

        public static ElementDefinition.ConstraintComponent Timing_TIM_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "repeat.all(period.empty() or periodUnit.exists())",
            Key = "tim-2",
            Severity = ConstraintSeverity.Warning,
            Human = "if there's a period, there needs to be period units",
            Xpath = "not(exists(f:period)) or exists(f:periodUnit)"
        };

        public static ElementDefinition.ConstraintComponent Timing_TIM_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "repeat.all(duration.exists() implies duration >= 0)",
            Key = "tim-4",
            Severity = ConstraintSeverity.Warning,
            Human = "duration SHALL be a non-negative value",
            Xpath = "f:duration/@value >= 0 or not(f:duration/@value)"
        };

        // TODO: Add code to enforce the above constraints

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Timing;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (EventElement != null) dest.EventElement = new List<FhirDateTime>(EventElement.DeepCopy());
                if (Repeat != null) dest.Repeat = (RepeatComponent)Repeat.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Timing());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Timing;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(EventElement, otherT.EventElement)) return false;
            if (!DeepComparable.Matches(Repeat, otherT.Repeat)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Timing;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(EventElement, otherT.EventElement)) return false;
            if (!DeepComparable.IsExactly(Repeat, otherT.Repeat)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in EventElement) { if (elem != null) yield return elem; }
                if (Repeat != null) yield return Repeat;
                if (Code != null) yield return Code;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in EventElement) { if (elem != null) yield return new ElementValue("event", elem); }
                if (Repeat != null) yield return new ElementValue("repeat", Repeat);
                if (Code != null) yield return new ElementValue("code", Code);
            }
        }

    }

}
