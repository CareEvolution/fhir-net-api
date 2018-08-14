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
    /// A timing schedule that specifies an event that may occur multiple times
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "Timing")]
    [DataContract]
    public partial class Timing : Hl7.Fhir.Model.Primitive<string>, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override string TypeName { get { return "Timing"; } }
    
        public Timing(string value)
        {
            Value = value;
        }
    
        public Timing(): this((string)null) {}
    
        /// <summary>
        /// Primitive value of the element
        /// </summary>
        [FhirElement("value", IsPrimitiveValue=true, XmlSerialization=XmlSerializationHint.Attribute, InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=30)]
        [CLSCompliant(false)]
        [DataMember]
        public string Value
        {
            get { return (string)ObjectValue; }
            set { ObjectValue = value; OnPropertyChanged("Value"); }
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "RepeatComponent")]
        [DataContract]
        public partial class RepeatComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RepeatComponent"; } }
            
            /// <summary>
            /// Length/Range of lengths, or (Start and/or end) limits
            /// </summary>
            [FhirElement("bounds", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.Duration),typeof(Hl7.Fhir.Model.R4.Range),typeof(Hl7.Fhir.Model.R4.Period))]
            [DataMember]
            public Hl7.Fhir.Model.Element Bounds
            {
                get { return _Bounds; }
                set { _Bounds = value; OnPropertyChanged("Bounds"); }
            }
            
            private Hl7.Fhir.Model.Element _Bounds;
            
            /// <summary>
            /// Number of times to repeat
            /// </summary>
            [FhirElement("count", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Integer CountElement
            {
                get { return _CountElement; }
                set { _CountElement = value; OnPropertyChanged("CountElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Integer _CountElement;
            
            /// <summary>
            /// Number of times to repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Count
            {
                get { return CountElement != null ? CountElement.Value : null; }
                set
                {
                    if (value == null)
                        CountElement = null;
                    else
                        CountElement = new Hl7.Fhir.Model.R4.Integer(value);
                    OnPropertyChanged("Count");
                }
            }
            
            /// <summary>
            /// Maximum number of times to repeat
            /// </summary>
            [FhirElement("countMax", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Integer CountMaxElement
            {
                get { return _CountMaxElement; }
                set { _CountMaxElement = value; OnPropertyChanged("CountMaxElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Integer _CountMaxElement;
            
            /// <summary>
            /// Maximum number of times to repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? CountMax
            {
                get { return CountMaxElement != null ? CountMaxElement.Value : null; }
                set
                {
                    if (value == null)
                        CountMaxElement = null;
                    else
                        CountMaxElement = new Hl7.Fhir.Model.R4.Integer(value);
                    OnPropertyChanged("CountMax");
                }
            }
            
            /// <summary>
            /// How long when it happens
            /// </summary>
            [FhirElement("duration", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDecimal DurationElement
            {
                get { return _DurationElement; }
                set { _DurationElement = value; OnPropertyChanged("DurationElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDecimal _DurationElement;
            
            /// <summary>
            /// How long when it happens
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Duration
            {
                get { return DurationElement != null ? DurationElement.Value : null; }
                set
                {
                    if (value == null)
                        DurationElement = null;
                    else
                        DurationElement = new Hl7.Fhir.Model.R4.FhirDecimal(value);
                    OnPropertyChanged("Duration");
                }
            }
            
            /// <summary>
            /// How long when it happens (Max)
            /// </summary>
            [FhirElement("durationMax", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDecimal DurationMaxElement
            {
                get { return _DurationMaxElement; }
                set { _DurationMaxElement = value; OnPropertyChanged("DurationMaxElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDecimal _DurationMaxElement;
            
            /// <summary>
            /// How long when it happens (Max)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? DurationMax
            {
                get { return DurationMaxElement != null ? DurationMaxElement.Value : null; }
                set
                {
                    if (value == null)
                        DurationMaxElement = null;
                    else
                        DurationMaxElement = new Hl7.Fhir.Model.R4.FhirDecimal(value);
                    OnPropertyChanged("DurationMax");
                }
            }
            
            /// <summary>
            /// s | min | h | d | wk | mo | a - unit of time (UCUM)
            /// </summary>
            [FhirElement("durationUnit", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code DurationUnitElement
            {
                get { return _DurationUnitElement; }
                set { _DurationUnitElement = value; OnPropertyChanged("DurationUnitElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _DurationUnitElement;
            
            /// <summary>
            /// s | min | h | d | wk | mo | a - unit of time (UCUM)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string DurationUnit
            {
                get { return DurationUnitElement != null ? DurationUnitElement.Value : null; }
                set
                {
                    if (value == null)
                        DurationUnitElement = null;
                    else
                        DurationUnitElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("DurationUnit");
                }
            }
            
            /// <summary>
            /// Event occurs frequency times per period
            /// </summary>
            [FhirElement("frequency", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Integer FrequencyElement
            {
                get { return _FrequencyElement; }
                set { _FrequencyElement = value; OnPropertyChanged("FrequencyElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Integer _FrequencyElement;
            
            /// <summary>
            /// Event occurs frequency times per period
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Frequency
            {
                get { return FrequencyElement != null ? FrequencyElement.Value : null; }
                set
                {
                    if (value == null)
                        FrequencyElement = null;
                    else
                        FrequencyElement = new Hl7.Fhir.Model.R4.Integer(value);
                    OnPropertyChanged("Frequency");
                }
            }
            
            /// <summary>
            /// Event occurs up to frequencyMax times per period
            /// </summary>
            [FhirElement("frequencyMax", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Integer FrequencyMaxElement
            {
                get { return _FrequencyMaxElement; }
                set { _FrequencyMaxElement = value; OnPropertyChanged("FrequencyMaxElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Integer _FrequencyMaxElement;
            
            /// <summary>
            /// Event occurs up to frequencyMax times per period
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? FrequencyMax
            {
                get { return FrequencyMaxElement != null ? FrequencyMaxElement.Value : null; }
                set
                {
                    if (value == null)
                        FrequencyMaxElement = null;
                    else
                        FrequencyMaxElement = new Hl7.Fhir.Model.R4.Integer(value);
                    OnPropertyChanged("FrequencyMax");
                }
            }
            
            /// <summary>
            /// Event occurs frequency times per period
            /// </summary>
            [FhirElement("period", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDecimal PeriodElement
            {
                get { return _PeriodElement; }
                set { _PeriodElement = value; OnPropertyChanged("PeriodElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDecimal _PeriodElement;
            
            /// <summary>
            /// Event occurs frequency times per period
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? Period
            {
                get { return PeriodElement != null ? PeriodElement.Value : null; }
                set
                {
                    if (value == null)
                        PeriodElement = null;
                    else
                        PeriodElement = new Hl7.Fhir.Model.R4.FhirDecimal(value);
                    OnPropertyChanged("Period");
                }
            }
            
            /// <summary>
            /// Upper limit of period (3-4 hours)
            /// </summary>
            [FhirElement("periodMax", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDecimal PeriodMaxElement
            {
                get { return _PeriodMaxElement; }
                set { _PeriodMaxElement = value; OnPropertyChanged("PeriodMaxElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDecimal _PeriodMaxElement;
            
            /// <summary>
            /// Upper limit of period (3-4 hours)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public decimal? PeriodMax
            {
                get { return PeriodMaxElement != null ? PeriodMaxElement.Value : null; }
                set
                {
                    if (value == null)
                        PeriodMaxElement = null;
                    else
                        PeriodMaxElement = new Hl7.Fhir.Model.R4.FhirDecimal(value);
                    OnPropertyChanged("PeriodMax");
                }
            }
            
            /// <summary>
            /// s | min | h | d | wk | mo | a - unit of time (UCUM)
            /// </summary>
            [FhirElement("periodUnit", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code PeriodUnitElement
            {
                get { return _PeriodUnitElement; }
                set { _PeriodUnitElement = value; OnPropertyChanged("PeriodUnitElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _PeriodUnitElement;
            
            /// <summary>
            /// s | min | h | d | wk | mo | a - unit of time (UCUM)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string PeriodUnit
            {
                get { return PeriodUnitElement != null ? PeriodUnitElement.Value : null; }
                set
                {
                    if (value == null)
                        PeriodUnitElement = null;
                    else
                        PeriodUnitElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("PeriodUnit");
                }
            }
            
            /// <summary>
            /// mon | tue | wed | thu | fri | sat | sun
            /// </summary>
            [FhirElement("dayOfWeek", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Code> DayOfWeekElement
            {
                get { if(_DayOfWeekElement==null) _DayOfWeekElement = new List<Hl7.Fhir.Model.R4.Code>(); return _DayOfWeekElement; }
                set { _DayOfWeekElement = value; OnPropertyChanged("DayOfWeekElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Code> _DayOfWeekElement;
            
            /// <summary>
            /// mon | tue | wed | thu | fri | sat | sun
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> DayOfWeek
            {
                get { return DayOfWeekElement != null ? DayOfWeekElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        DayOfWeekElement = null;
                    else
                        DayOfWeekElement = new List<Hl7.Fhir.Model.R4.Code>(value.Select(elem=>new Hl7.Fhir.Model.R4.Code(elem)));
                    OnPropertyChanged("DayOfWeek");
                }
            }
            
            /// <summary>
            /// Time of day for action
            /// </summary>
            [FhirElement("timeOfDay", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Time> TimeOfDayElement
            {
                get { if(_TimeOfDayElement==null) _TimeOfDayElement = new List<Hl7.Fhir.Model.R4.Time>(); return _TimeOfDayElement; }
                set { _TimeOfDayElement = value; OnPropertyChanged("TimeOfDayElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Time> _TimeOfDayElement;
            
            /// <summary>
            /// Time of day for action
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> TimeOfDay
            {
                get { return TimeOfDayElement != null ? TimeOfDayElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        TimeOfDayElement = null;
                    else
                        TimeOfDayElement = new List<Hl7.Fhir.Model.R4.Time>(value.Select(elem=>new Hl7.Fhir.Model.R4.Time(elem)));
                    OnPropertyChanged("TimeOfDay");
                }
            }
            
            /// <summary>
            /// Code for time period of occurrence
            /// </summary>
            [FhirElement("when", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Code> WhenElement
            {
                get { if(_WhenElement==null) _WhenElement = new List<Hl7.Fhir.Model.R4.Code>(); return _WhenElement; }
                set { _WhenElement = value; OnPropertyChanged("WhenElement"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Code> _WhenElement;
            
            /// <summary>
            /// Code for time period of occurrence
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> When
            {
                get { return WhenElement != null ? WhenElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        WhenElement = null;
                    else
                        WhenElement = new List<Hl7.Fhir.Model.R4.Code>(value.Select(elem=>new Hl7.Fhir.Model.R4.Code(elem)));
                    OnPropertyChanged("When");
                }
            }
            
            /// <summary>
            /// Minutes from event (before or after)
            /// </summary>
            [FhirElement("offset", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.UnsignedInt OffsetElement
            {
                get { return _OffsetElement; }
                set { _OffsetElement = value; OnPropertyChanged("OffsetElement"); }
            }
            
            private Hl7.Fhir.Model.R4.UnsignedInt _OffsetElement;
            
            /// <summary>
            /// Minutes from event (before or after)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Offset
            {
                get { return OffsetElement != null ? OffsetElement.Value : null; }
                set
                {
                    if (value == null)
                        OffsetElement = null;
                    else
                        OffsetElement = new Hl7.Fhir.Model.R4.UnsignedInt(value);
                    OnPropertyChanged("Offset");
                }
            }
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RepeatComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Bounds != null) dest.Bounds = (Hl7.Fhir.Model.Element)Bounds.DeepCopy();
                    if(CountElement != null) dest.CountElement = (Hl7.Fhir.Model.R4.Integer)CountElement.DeepCopy();
                    if(CountMaxElement != null) dest.CountMaxElement = (Hl7.Fhir.Model.R4.Integer)CountMaxElement.DeepCopy();
                    if(DurationElement != null) dest.DurationElement = (Hl7.Fhir.Model.R4.FhirDecimal)DurationElement.DeepCopy();
                    if(DurationMaxElement != null) dest.DurationMaxElement = (Hl7.Fhir.Model.R4.FhirDecimal)DurationMaxElement.DeepCopy();
                    if(DurationUnitElement != null) dest.DurationUnitElement = (Hl7.Fhir.Model.R4.Code)DurationUnitElement.DeepCopy();
                    if(FrequencyElement != null) dest.FrequencyElement = (Hl7.Fhir.Model.R4.Integer)FrequencyElement.DeepCopy();
                    if(FrequencyMaxElement != null) dest.FrequencyMaxElement = (Hl7.Fhir.Model.R4.Integer)FrequencyMaxElement.DeepCopy();
                    if(PeriodElement != null) dest.PeriodElement = (Hl7.Fhir.Model.R4.FhirDecimal)PeriodElement.DeepCopy();
                    if(PeriodMaxElement != null) dest.PeriodMaxElement = (Hl7.Fhir.Model.R4.FhirDecimal)PeriodMaxElement.DeepCopy();
                    if(PeriodUnitElement != null) dest.PeriodUnitElement = (Hl7.Fhir.Model.R4.Code)PeriodUnitElement.DeepCopy();
                    if(DayOfWeekElement != null) dest.DayOfWeekElement = new List<Hl7.Fhir.Model.R4.Code>(DayOfWeekElement.DeepCopy());
                    if(TimeOfDayElement != null) dest.TimeOfDayElement = new List<Hl7.Fhir.Model.R4.Time>(TimeOfDayElement.DeepCopy());
                    if(WhenElement != null) dest.WhenElement = new List<Hl7.Fhir.Model.R4.Code>(WhenElement.DeepCopy());
                    if(OffsetElement != null) dest.OffsetElement = (Hl7.Fhir.Model.R4.UnsignedInt)OffsetElement.DeepCopy();
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Bounds, otherT.Bounds)) return false;
                if( !DeepComparable.Matches(CountElement, otherT.CountElement)) return false;
                if( !DeepComparable.Matches(CountMaxElement, otherT.CountMaxElement)) return false;
                if( !DeepComparable.Matches(DurationElement, otherT.DurationElement)) return false;
                if( !DeepComparable.Matches(DurationMaxElement, otherT.DurationMaxElement)) return false;
                if( !DeepComparable.Matches(DurationUnitElement, otherT.DurationUnitElement)) return false;
                if( !DeepComparable.Matches(FrequencyElement, otherT.FrequencyElement)) return false;
                if( !DeepComparable.Matches(FrequencyMaxElement, otherT.FrequencyMaxElement)) return false;
                if( !DeepComparable.Matches(PeriodElement, otherT.PeriodElement)) return false;
                if( !DeepComparable.Matches(PeriodMaxElement, otherT.PeriodMaxElement)) return false;
                if( !DeepComparable.Matches(PeriodUnitElement, otherT.PeriodUnitElement)) return false;
                if( !DeepComparable.Matches(DayOfWeekElement, otherT.DayOfWeekElement)) return false;
                if( !DeepComparable.Matches(TimeOfDayElement, otherT.TimeOfDayElement)) return false;
                if( !DeepComparable.Matches(WhenElement, otherT.WhenElement)) return false;
                if( !DeepComparable.Matches(OffsetElement, otherT.OffsetElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RepeatComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Bounds, otherT.Bounds)) return false;
                if( !DeepComparable.IsExactly(CountElement, otherT.CountElement)) return false;
                if( !DeepComparable.IsExactly(CountMaxElement, otherT.CountMaxElement)) return false;
                if( !DeepComparable.IsExactly(DurationElement, otherT.DurationElement)) return false;
                if( !DeepComparable.IsExactly(DurationMaxElement, otherT.DurationMaxElement)) return false;
                if( !DeepComparable.IsExactly(DurationUnitElement, otherT.DurationUnitElement)) return false;
                if( !DeepComparable.IsExactly(FrequencyElement, otherT.FrequencyElement)) return false;
                if( !DeepComparable.IsExactly(FrequencyMaxElement, otherT.FrequencyMaxElement)) return false;
                if( !DeepComparable.IsExactly(PeriodElement, otherT.PeriodElement)) return false;
                if( !DeepComparable.IsExactly(PeriodMaxElement, otherT.PeriodMaxElement)) return false;
                if( !DeepComparable.IsExactly(PeriodUnitElement, otherT.PeriodUnitElement)) return false;
                if( !DeepComparable.IsExactly(DayOfWeekElement, otherT.DayOfWeekElement)) return false;
                if( !DeepComparable.IsExactly(TimeOfDayElement, otherT.TimeOfDayElement)) return false;
                if( !DeepComparable.IsExactly(WhenElement, otherT.WhenElement)) return false;
                if( !DeepComparable.IsExactly(OffsetElement, otherT.OffsetElement)) return false;
            
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
                    if (Bounds != null) yield return new ElementValue("bounds", false, Bounds);
                    if (CountElement != null) yield return new ElementValue("count", false, CountElement);
                    if (CountMaxElement != null) yield return new ElementValue("countMax", false, CountMaxElement);
                    if (DurationElement != null) yield return new ElementValue("duration", false, DurationElement);
                    if (DurationMaxElement != null) yield return new ElementValue("durationMax", false, DurationMaxElement);
                    if (DurationUnitElement != null) yield return new ElementValue("durationUnit", false, DurationUnitElement);
                    if (FrequencyElement != null) yield return new ElementValue("frequency", false, FrequencyElement);
                    if (FrequencyMaxElement != null) yield return new ElementValue("frequencyMax", false, FrequencyMaxElement);
                    if (PeriodElement != null) yield return new ElementValue("period", false, PeriodElement);
                    if (PeriodMaxElement != null) yield return new ElementValue("periodMax", false, PeriodMaxElement);
                    if (PeriodUnitElement != null) yield return new ElementValue("periodUnit", false, PeriodUnitElement);
                    foreach (var elem in DayOfWeekElement) { if (elem != null) yield return new ElementValue("dayOfWeek", true, elem); }
                    foreach (var elem in TimeOfDayElement) { if (elem != null) yield return new ElementValue("timeOfDay", true, elem); }
                    foreach (var elem in WhenElement) { if (elem != null) yield return new ElementValue("when", true, elem); }
                    if (OffsetElement != null) yield return new ElementValue("offset", false, OffsetElement);
                }
            }
        
        
        }
    
    
        public static ElementDefinitionConstraint Timing_TIM_9 = new ElementDefinitionConstraint
        {
            Expression = "repeat.all(offset.empty() or (when.exists() and ((when in ('C' | 'CM' | 'CD' | 'CV')).not())))",
            Key = "tim-9",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's an offset, there must be a when (and not C, CM, CD, CV)",
            Xpath = "not(exists(f:offset)) or exists(f:when)"
        };
    
        public static ElementDefinitionConstraint Timing_TIM_5 = new ElementDefinitionConstraint
        {
            Expression = "repeat.all(period.exists() implies period >= 0)",
            Key = "tim-5",
            Severity = ConstraintSeverity.Warning,
            Human = "period SHALL be a non-negative value",
            Xpath = "f:period/@value >= 0 or not(f:period/@value)"
        };
    
        public static ElementDefinitionConstraint Timing_TIM_6 = new ElementDefinitionConstraint
        {
            Expression = "repeat.all(periodMax.empty() or period.exists())",
            Key = "tim-6",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's a periodMax, there must be a period",
            Xpath = "not(exists(f:periodMax)) or exists(f:period)"
        };
    
        public static ElementDefinitionConstraint Timing_TIM_7 = new ElementDefinitionConstraint
        {
            Expression = "repeat.all(durationMax.empty() or duration.exists())",
            Key = "tim-7",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's a durationMax, there must be a duration",
            Xpath = "not(exists(f:durationMax)) or exists(f:duration)"
        };
    
        public static ElementDefinitionConstraint Timing_TIM_8 = new ElementDefinitionConstraint
        {
            Expression = "repeat.all(countMax.empty() or count.exists())",
            Key = "tim-8",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's a countMax, there must be a count",
            Xpath = "not(exists(f:countMax)) or exists(f:count)"
        };
    
        public static ElementDefinitionConstraint Timing_TIM_1 = new ElementDefinitionConstraint
        {
            Expression = "repeat.all(duration.empty() or durationUnit.exists())",
            Key = "tim-1",
            Severity = ConstraintSeverity.Warning,
            Human = "if there's a duration, there needs to be duration units",
            Xpath = "not(exists(f:duration)) or exists(f:durationUnit)"
        };
    
        public static ElementDefinitionConstraint Timing_TIM_10 = new ElementDefinitionConstraint
        {
            Expression = "repeat.all(timeOfDay.empty() or when.empty())",
            Key = "tim-10",
            Severity = ConstraintSeverity.Warning,
            Human = "If there's a timeOfDay, there cannot be be a when, or vice versa",
            Xpath = "not(exists(f:timeOfDay)) or not(exists(f:when))"
        };
    
        public static ElementDefinitionConstraint Timing_TIM_2 = new ElementDefinitionConstraint
        {
            Expression = "repeat.all(period.empty() or periodUnit.exists())",
            Key = "tim-2",
            Severity = ConstraintSeverity.Warning,
            Human = "if there's a period, there needs to be period units",
            Xpath = "not(exists(f:period)) or exists(f:periodUnit)"
        };
    
        public static ElementDefinitionConstraint Timing_TIM_4 = new ElementDefinitionConstraint
        {
            Expression = "repeat.all(duration.exists() implies duration >= 0)",
            Key = "tim-4",
            Severity = ConstraintSeverity.Warning,
            Human = "duration SHALL be a non-negative value",
            Xpath = "f:duration/@value >= 0 or not(f:duration/@value)"
        };
    
        // TODO: Add code to enforce the above constraints
    
    }

}
