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
    /// Measurement, calculation or setting capability of a medical device
    /// </summary>
    [FhirType("DeviceMetric", IsResource=true)]
    [DataContract]
    public partial class DeviceMetric : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DeviceMetric; } }
        [NotMapped]
        public override string TypeName { get { return "DeviceMetric"; } }

        /// <summary>
        /// Describes the operational status of the DeviceMetric.
        /// (url: http://hl7.org/fhir/ValueSet/metric-operational-status)
        /// </summary>
        [FhirEnumeration("DeviceMetricOperationalStatus")]
        public enum DeviceMetricOperationalStatus
        {
            /// <summary>
            /// The DeviceMetric is operating and will generate DeviceObservations.
            /// (system: http://hl7.org/fhir/metric-operational-status)
            /// </summary>
            [EnumLiteral("on", "http://hl7.org/fhir/metric-operational-status"), Description("On")]
            On,
            /// <summary>
            /// The DeviceMetric is not operating.
            /// (system: http://hl7.org/fhir/metric-operational-status)
            /// </summary>
            [EnumLiteral("off", "http://hl7.org/fhir/metric-operational-status"), Description("Off")]
            Off,
            /// <summary>
            /// The DeviceMetric is operating, but will not generate any DeviceObservations.
            /// (system: http://hl7.org/fhir/metric-operational-status)
            /// </summary>
            [EnumLiteral("standby", "http://hl7.org/fhir/metric-operational-status"), Description("Standby")]
            Standby,
        }

        /// <summary>
        /// Describes the typical color of representation.
        /// (url: http://hl7.org/fhir/ValueSet/metric-color)
        /// </summary>
        [FhirEnumeration("DeviceMetricColor")]
        public enum DeviceMetricColor
        {
            /// <summary>
            /// Color for representation - black.
            /// (system: http://hl7.org/fhir/metric-color)
            /// </summary>
            [EnumLiteral("black", "http://hl7.org/fhir/metric-color"), Description("Color Black")]
            Black,
            /// <summary>
            /// Color for representation - red.
            /// (system: http://hl7.org/fhir/metric-color)
            /// </summary>
            [EnumLiteral("red", "http://hl7.org/fhir/metric-color"), Description("Color Red")]
            Red,
            /// <summary>
            /// Color for representation - green.
            /// (system: http://hl7.org/fhir/metric-color)
            /// </summary>
            [EnumLiteral("green", "http://hl7.org/fhir/metric-color"), Description("Color Green")]
            Green,
            /// <summary>
            /// Color for representation - yellow.
            /// (system: http://hl7.org/fhir/metric-color)
            /// </summary>
            [EnumLiteral("yellow", "http://hl7.org/fhir/metric-color"), Description("Color Yellow")]
            Yellow,
            /// <summary>
            /// Color for representation - blue.
            /// (system: http://hl7.org/fhir/metric-color)
            /// </summary>
            [EnumLiteral("blue", "http://hl7.org/fhir/metric-color"), Description("Color Blue")]
            Blue,
            /// <summary>
            /// Color for representation - magenta.
            /// (system: http://hl7.org/fhir/metric-color)
            /// </summary>
            [EnumLiteral("magenta", "http://hl7.org/fhir/metric-color"), Description("Color Magenta")]
            Magenta,
            /// <summary>
            /// Color for representation - cyan.
            /// (system: http://hl7.org/fhir/metric-color)
            /// </summary>
            [EnumLiteral("cyan", "http://hl7.org/fhir/metric-color"), Description("Color Cyan")]
            Cyan,
            /// <summary>
            /// Color for representation - white.
            /// (system: http://hl7.org/fhir/metric-color)
            /// </summary>
            [EnumLiteral("white", "http://hl7.org/fhir/metric-color"), Description("Color White")]
            White,
        }

        /// <summary>
        /// Describes the category of the metric.
        /// (url: http://hl7.org/fhir/ValueSet/metric-category)
        /// </summary>
        [FhirEnumeration("DeviceMetricCategory")]
        public enum DeviceMetricCategory
        {
            /// <summary>
            /// DeviceObservations generated for this DeviceMetric are measured.
            /// (system: http://hl7.org/fhir/metric-category)
            /// </summary>
            [EnumLiteral("measurement", "http://hl7.org/fhir/metric-category"), Description("Measurement")]
            Measurement,
            /// <summary>
            /// DeviceObservations generated for this DeviceMetric is a setting that will influence the behavior of the Device.
            /// (system: http://hl7.org/fhir/metric-category)
            /// </summary>
            [EnumLiteral("setting", "http://hl7.org/fhir/metric-category"), Description("Setting")]
            Setting,
            /// <summary>
            /// DeviceObservations generated for this DeviceMetric are calculated.
            /// (system: http://hl7.org/fhir/metric-category)
            /// </summary>
            [EnumLiteral("calculation", "http://hl7.org/fhir/metric-category"), Description("Calculation")]
            Calculation,
            /// <summary>
            /// The category of this DeviceMetric is unspecified.
            /// (system: http://hl7.org/fhir/metric-category)
            /// </summary>
            [EnumLiteral("unspecified", "http://hl7.org/fhir/metric-category"), Description("Unspecified")]
            Unspecified,
        }

        /// <summary>
        /// Describes the type of a metric calibration.
        /// (url: http://hl7.org/fhir/ValueSet/metric-calibration-type)
        /// </summary>
        [FhirEnumeration("DeviceMetricCalibrationType")]
        public enum DeviceMetricCalibrationType
        {
            /// <summary>
            /// TODO
            /// (system: http://hl7.org/fhir/metric-calibration-type)
            /// </summary>
            [EnumLiteral("unspecified", "http://hl7.org/fhir/metric-calibration-type"), Description("Unspecified")]
            Unspecified,
            /// <summary>
            /// TODO
            /// (system: http://hl7.org/fhir/metric-calibration-type)
            /// </summary>
            [EnumLiteral("offset", "http://hl7.org/fhir/metric-calibration-type"), Description("Offset")]
            Offset,
            /// <summary>
            /// TODO
            /// (system: http://hl7.org/fhir/metric-calibration-type)
            /// </summary>
            [EnumLiteral("gain", "http://hl7.org/fhir/metric-calibration-type"), Description("Gain")]
            Gain,
            /// <summary>
            /// TODO
            /// (system: http://hl7.org/fhir/metric-calibration-type)
            /// </summary>
            [EnumLiteral("two-point", "http://hl7.org/fhir/metric-calibration-type"), Description("Two Point")]
            TwoPoint,
        }

        /// <summary>
        /// Describes the state of a metric calibration.
        /// (url: http://hl7.org/fhir/ValueSet/metric-calibration-state)
        /// </summary>
        [FhirEnumeration("DeviceMetricCalibrationState")]
        public enum DeviceMetricCalibrationState
        {
            /// <summary>
            /// The metric has not been calibrated.
            /// (system: http://hl7.org/fhir/metric-calibration-state)
            /// </summary>
            [EnumLiteral("not-calibrated", "http://hl7.org/fhir/metric-calibration-state"), Description("Not Calibrated")]
            NotCalibrated,
            /// <summary>
            /// The metric needs to be calibrated.
            /// (system: http://hl7.org/fhir/metric-calibration-state)
            /// </summary>
            [EnumLiteral("calibration-required", "http://hl7.org/fhir/metric-calibration-state"), Description("Calibration Required")]
            CalibrationRequired,
            /// <summary>
            /// The metric has been calibrated.
            /// (system: http://hl7.org/fhir/metric-calibration-state)
            /// </summary>
            [EnumLiteral("calibrated", "http://hl7.org/fhir/metric-calibration-state"), Description("Calibrated")]
            Calibrated,
            /// <summary>
            /// The state of calibration of this metric is unspecified.
            /// (system: http://hl7.org/fhir/metric-calibration-state)
            /// </summary>
            [EnumLiteral("unspecified", "http://hl7.org/fhir/metric-calibration-state"), Description("Unspecified")]
            Unspecified,
        }


        [FhirType("CalibrationComponent")]
        [DataContract]
        public partial class CalibrationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CalibrationComponent"; } }

            /// <summary>
            /// unspecified | offset | gain | two-point
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public Code<DeviceMetricCalibrationType> TypeElement
            {
                get { return _typeElement; }
                set { _typeElement = value; OnPropertyChanged("TypeElement"); }
            }

            private Code<DeviceMetricCalibrationType> _typeElement;

            /// <summary>
            /// unspecified | offset | gain | two-point
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DeviceMetricCalibrationType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (value == null)
                        TypeElement = null;
                    else
                        TypeElement = new Code<DeviceMetricCalibrationType>(value);
                    OnPropertyChanged("Type");
                }
            }

            /// <summary>
            /// not-calibrated | calibration-required | calibrated | unspecified
            /// </summary>
            [FhirElement("state", InSummary=true, Order=50)]
            [DataMember]
            public Code<DeviceMetricCalibrationState> StateElement
            {
                get { return _stateElement; }
                set { _stateElement = value; OnPropertyChanged("StateElement"); }
            }

            private Code<DeviceMetricCalibrationState> _stateElement;

            /// <summary>
            /// not-calibrated | calibration-required | calibrated | unspecified
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DeviceMetricCalibrationState? State
            {
                get { return StateElement != null ? StateElement.Value : null; }
                set
                {
                    if (value == null)
                        StateElement = null;
                    else
                        StateElement = new Code<DeviceMetricCalibrationState>(value);
                    OnPropertyChanged("State");
                }
            }

            /// <summary>
            /// Describes the time last calibration has been performed
            /// </summary>
            [FhirElement("time", InSummary=true, Order=60)]
            [DataMember]
            public Instant TimeElement
            {
                get { return _timeElement; }
                set { _timeElement = value; OnPropertyChanged("TimeElement"); }
            }

            private Instant _timeElement;

            /// <summary>
            /// Describes the time last calibration has been performed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DateTimeOffset? Time
            {
                get { return TimeElement != null ? TimeElement.Value : null; }
                set
                {
                    if (value == null)
                        TimeElement = null;
                    else
                        TimeElement = new Instant(value);
                    OnPropertyChanged("Time");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CalibrationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TypeElement != null) dest.TypeElement = (Code<DeviceMetricCalibrationType>)TypeElement.DeepCopy();
                    if (StateElement != null) dest.StateElement = (Code<DeviceMetricCalibrationState>)StateElement.DeepCopy();
                    if (TimeElement != null) dest.TimeElement = (Instant)TimeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CalibrationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CalibrationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.Matches(StateElement, otherT.StateElement)) return false;
                if (!DeepComparable.Matches(TimeElement, otherT.TimeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CalibrationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if (!DeepComparable.IsExactly(StateElement, otherT.StateElement)) return false;
                if (!DeepComparable.IsExactly(TimeElement, otherT.TimeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (StateElement != null) yield return StateElement;
                    if (TimeElement != null) yield return TimeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                    if (StateElement != null) yield return new ElementValue("state", StateElement);
                    if (TimeElement != null) yield return new ElementValue("time", TimeElement);
                }
            }


        }


        /// <summary>
        /// Type of metric
        /// </summary>
        [FhirElement("type", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Unique identifier of this DeviceMetric
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Unit of metric
        /// </summary>
        [FhirElement("unit", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept Unit
        {
            get { return _unit; }
            set { _unit = value; OnPropertyChanged("Unit"); }
        }

        private CodeableConcept _unit;

        /// <summary>
        /// Describes the link to the source Device
        /// </summary>
        [FhirElement("source", InSummary=true, Order=120)]
        [References("Device")]
        [DataMember]
        public ResourceReference Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private ResourceReference _source;

        /// <summary>
        /// Describes the link to the parent DeviceComponent
        /// </summary>
        [FhirElement("parent", InSummary=true, Order=130)]
        [References("DeviceComponent")]
        [DataMember]
        public ResourceReference Parent
        {
            get { return _parent; }
            set { _parent = value; OnPropertyChanged("Parent"); }
        }

        private ResourceReference _parent;

        /// <summary>
        /// on | off | standby
        /// </summary>
        [FhirElement("operationalStatus", InSummary=true, Order=140)]
        [DataMember]
        public Code<DeviceMetricOperationalStatus> OperationalStatusElement
        {
            get { return _operationalStatusElement; }
            set { _operationalStatusElement = value; OnPropertyChanged("OperationalStatusElement"); }
        }

        private Code<DeviceMetricOperationalStatus> _operationalStatusElement;

        /// <summary>
        /// on | off | standby
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DeviceMetricOperationalStatus? OperationalStatus
        {
            get { return OperationalStatusElement != null ? OperationalStatusElement.Value : null; }
            set
            {
                if (value == null)
                    OperationalStatusElement = null;
                else
                    OperationalStatusElement = new Code<DeviceMetricOperationalStatus>(value);
                OnPropertyChanged("OperationalStatus");
            }
        }

        /// <summary>
        /// black | red | green | yellow | blue | magenta | cyan | white
        /// </summary>
        [FhirElement("color", InSummary=true, Order=150)]
        [DataMember]
        public Code<DeviceMetricColor> ColorElement
        {
            get { return _colorElement; }
            set { _colorElement = value; OnPropertyChanged("ColorElement"); }
        }

        private Code<DeviceMetricColor> _colorElement;

        /// <summary>
        /// black | red | green | yellow | blue | magenta | cyan | white
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DeviceMetricColor? Color
        {
            get { return ColorElement != null ? ColorElement.Value : null; }
            set
            {
                if (value == null)
                    ColorElement = null;
                else
                    ColorElement = new Code<DeviceMetricColor>(value);
                OnPropertyChanged("Color");
            }
        }

        /// <summary>
        /// measurement | setting | calculation | unspecified
        /// </summary>
        [FhirElement("category", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<DeviceMetricCategory> CategoryElement
        {
            get { return _categoryElement; }
            set { _categoryElement = value; OnPropertyChanged("CategoryElement"); }
        }

        private Code<DeviceMetricCategory> _categoryElement;

        /// <summary>
        /// measurement | setting | calculation | unspecified
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DeviceMetricCategory? Category
        {
            get { return CategoryElement != null ? CategoryElement.Value : null; }
            set
            {
                if (value == null)
                    CategoryElement = null;
                else
                    CategoryElement = new Code<DeviceMetricCategory>(value);
                OnPropertyChanged("Category");
            }
        }

        /// <summary>
        /// Describes the measurement repetition time
        /// </summary>
        [FhirElement("measurementPeriod", InSummary=true, Order=170)]
        [DataMember]
        public Timing MeasurementPeriod
        {
            get { return _measurementPeriod; }
            set { _measurementPeriod = value; OnPropertyChanged("MeasurementPeriod"); }
        }

        private Timing _measurementPeriod;

        /// <summary>
        /// Describes the calibrations that have been performed or that are required to be performed
        /// </summary>
        [FhirElement("calibration", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CalibrationComponent> Calibration
        {
            get { if (_calibration==null) _calibration = new List<CalibrationComponent>(); return _calibration; }
            set { _calibration = value; OnPropertyChanged("Calibration"); }
        }

        private List<CalibrationComponent> _calibration;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DeviceMetric;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (Unit != null) dest.Unit = (CodeableConcept)Unit.DeepCopy();
                if (Source != null) dest.Source = (ResourceReference)Source.DeepCopy();
                if (Parent != null) dest.Parent = (ResourceReference)Parent.DeepCopy();
                if (OperationalStatusElement != null) dest.OperationalStatusElement = (Code<DeviceMetricOperationalStatus>)OperationalStatusElement.DeepCopy();
                if (ColorElement != null) dest.ColorElement = (Code<DeviceMetricColor>)ColorElement.DeepCopy();
                if (CategoryElement != null) dest.CategoryElement = (Code<DeviceMetricCategory>)CategoryElement.DeepCopy();
                if (MeasurementPeriod != null) dest.MeasurementPeriod = (Timing)MeasurementPeriod.DeepCopy();
                if (Calibration != null) dest.Calibration = new List<CalibrationComponent>(Calibration.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new DeviceMetric());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DeviceMetric;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Unit, otherT.Unit)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if (!DeepComparable.Matches(Parent, otherT.Parent)) return false;
            if (!DeepComparable.Matches(OperationalStatusElement, otherT.OperationalStatusElement)) return false;
            if (!DeepComparable.Matches(ColorElement, otherT.ColorElement)) return false;
            if (!DeepComparable.Matches(CategoryElement, otherT.CategoryElement)) return false;
            if (!DeepComparable.Matches(MeasurementPeriod, otherT.MeasurementPeriod)) return false;
            if ( !DeepComparable.Matches(Calibration, otherT.Calibration)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DeviceMetric;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Unit, otherT.Unit)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Parent, otherT.Parent)) return false;
            if (!DeepComparable.IsExactly(OperationalStatusElement, otherT.OperationalStatusElement)) return false;
            if (!DeepComparable.IsExactly(ColorElement, otherT.ColorElement)) return false;
            if (!DeepComparable.IsExactly(CategoryElement, otherT.CategoryElement)) return false;
            if (!DeepComparable.IsExactly(MeasurementPeriod, otherT.MeasurementPeriod)) return false;
            if (!DeepComparable.IsExactly(Calibration, otherT.Calibration)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Type != null) yield return Type;
                if (Identifier != null) yield return Identifier;
                if (Unit != null) yield return Unit;
                if (Source != null) yield return Source;
                if (Parent != null) yield return Parent;
                if (OperationalStatusElement != null) yield return OperationalStatusElement;
                if (ColorElement != null) yield return ColorElement;
                if (CategoryElement != null) yield return CategoryElement;
                if (MeasurementPeriod != null) yield return MeasurementPeriod;
                foreach (var elem in Calibration) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Type != null) yield return new ElementValue("type", Type);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (Unit != null) yield return new ElementValue("unit", Unit);
                if (Source != null) yield return new ElementValue("source", Source);
                if (Parent != null) yield return new ElementValue("parent", Parent);
                if (OperationalStatusElement != null) yield return new ElementValue("operationalStatus", OperationalStatusElement);
                if (ColorElement != null) yield return new ElementValue("color", ColorElement);
                if (CategoryElement != null) yield return new ElementValue("category", CategoryElement);
                if (MeasurementPeriod != null) yield return new ElementValue("measurementPeriod", MeasurementPeriod);
                foreach (var elem in Calibration) { if (elem != null) yield return new ElementValue("calibration", elem); }
            }
        }

    }

}
