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
    /// A photo, video, or audio recording acquired or used in healthcare. The actual content may be inline or provided by direct reference
    /// </summary>
    [FhirType("Media", IsResource=true)]
    [DataContract]
    public partial class Media : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Media; } }
        [NotMapped]
        public override string TypeName { get { return "Media"; } }

        /// <summary>
        /// Whether the Media is a photo, video, or audio
        /// (url: http://hl7.org/fhir/ValueSet/digital-media-type)
        /// </summary>
        [FhirEnumeration("DigitalMediaType")]
        public enum DigitalMediaType
        {
            /// <summary>
            /// The media consists of one or more unmoving images, including photographs, computer-generated graphs and charts, and scanned documents
            /// (system: http://hl7.org/fhir/digital-media-type)
            /// </summary>
            [EnumLiteral("photo", "http://hl7.org/fhir/digital-media-type"), Description("Photo")]
            Photo,
            /// <summary>
            /// The media consists of a series of frames that capture a moving image
            /// (system: http://hl7.org/fhir/digital-media-type)
            /// </summary>
            [EnumLiteral("video", "http://hl7.org/fhir/digital-media-type"), Description("Video")]
            Video,
            /// <summary>
            /// The media consists of a sound recording
            /// (system: http://hl7.org/fhir/digital-media-type)
            /// </summary>
            [EnumLiteral("audio", "http://hl7.org/fhir/digital-media-type"), Description("Audio")]
            Audio,
        }


        /// <summary>
        /// photo | video | audio
        /// </summary>
        [FhirElement("type", InSummary=true, Order=90)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<DigitalMediaType> TypeElement
        {
            get { return _typeElement; }
            set { _typeElement = value; OnPropertyChanged("TypeElement"); }
        }

        private Code<DigitalMediaType> _typeElement;

        /// <summary>
        /// photo | video | audio
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DigitalMediaType? Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    TypeElement = null;
                else
                    TypeElement = new Code<DigitalMediaType>(value);
                OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// The type of acquisition equipment/process
        /// </summary>
        [FhirElement("subtype", InSummary=true, Order=100)]
        [DataMember]
        public CodeableConcept Subtype
        {
            get { return _subtype; }
            set { _subtype = value; OnPropertyChanged("Subtype"); }
        }

        private CodeableConcept _subtype;

        /// <summary>
        /// Identifier(s) for the image
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Who/What this Media is a record of
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=120)]
        [References("Patient","Practitioner","Group","Device","Specimen")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// The person who generated the image
        /// </summary>
        [FhirElement("operator", InSummary=true, Order=130)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Operator
        {
            get { return _operator; }
            set { _operator = value; OnPropertyChanged("Operator"); }
        }

        private ResourceReference _operator;

        /// <summary>
        /// Imaging view, e.g. Lateral or Antero-posterior
        /// </summary>
        [FhirElement("view", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept View
        {
            get { return _view; }
            set { _view = value; OnPropertyChanged("View"); }
        }

        private CodeableConcept _view;

        /// <summary>
        /// Name of the device/manufacturer
        /// </summary>
        [FhirElement("deviceName", InSummary=true, Order=150)]
        [DataMember]
        public FhirString DeviceNameElement
        {
            get { return _deviceNameElement; }
            set { _deviceNameElement = value; OnPropertyChanged("DeviceNameElement"); }
        }

        private FhirString _deviceNameElement;

        /// <summary>
        /// Name of the device/manufacturer
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string DeviceName
        {
            get { return DeviceNameElement != null ? DeviceNameElement.Value : null; }
            set
            {
                if (value == null)
                    DeviceNameElement = null;
                else
                    DeviceNameElement = new FhirString(value);
                OnPropertyChanged("DeviceName");
            }
        }

        /// <summary>
        /// Height of the image in pixels (photo/video)
        /// </summary>
        [FhirElement("height", InSummary=true, Order=160)]
        [DataMember]
        public PositiveInt HeightElement
        {
            get { return _heightElement; }
            set { _heightElement = value; OnPropertyChanged("HeightElement"); }
        }

        private PositiveInt _heightElement;

        /// <summary>
        /// Height of the image in pixels (photo/video)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Height
        {
            get { return HeightElement != null ? HeightElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    HeightElement = null;
                else
                    HeightElement = new PositiveInt(value);
                OnPropertyChanged("Height");
            }
        }

        /// <summary>
        /// Width of the image in pixels (photo/video)
        /// </summary>
        [FhirElement("width", InSummary=true, Order=170)]
        [DataMember]
        public PositiveInt WidthElement
        {
            get { return _widthElement; }
            set { _widthElement = value; OnPropertyChanged("WidthElement"); }
        }

        private PositiveInt _widthElement;

        /// <summary>
        /// Width of the image in pixels (photo/video)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Width
        {
            get { return WidthElement != null ? WidthElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    WidthElement = null;
                else
                    WidthElement = new PositiveInt(value);
                OnPropertyChanged("Width");
            }
        }

        /// <summary>
        /// Number of frames if &gt; 1 (photo)
        /// </summary>
        [FhirElement("frames", InSummary=true, Order=180)]
        [DataMember]
        public PositiveInt FramesElement
        {
            get { return _framesElement; }
            set { _framesElement = value; OnPropertyChanged("FramesElement"); }
        }

        private PositiveInt _framesElement;

        /// <summary>
        /// Number of frames if &gt; 1 (photo)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Frames
        {
            get { return FramesElement != null ? FramesElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    FramesElement = null;
                else
                    FramesElement = new PositiveInt(value);
                OnPropertyChanged("Frames");
            }
        }

        /// <summary>
        /// Length in seconds (audio / video)
        /// </summary>
        [FhirElement("duration", InSummary=true, Order=190)]
        [DataMember]
        public UnsignedInt DurationElement
        {
            get { return _durationElement; }
            set { _durationElement = value; OnPropertyChanged("DurationElement"); }
        }

        private UnsignedInt _durationElement;

        /// <summary>
        /// Length in seconds (audio / video)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public int? Duration
        {
            get { return DurationElement != null ? DurationElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    DurationElement = null;
                else
                    DurationElement = new UnsignedInt(value);
                OnPropertyChanged("Duration");
            }
        }

        /// <summary>
        /// Actual Media - reference or data
        /// </summary>
        [FhirElement("content", Order=200)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Attachment Content
        {
            get { return _content; }
            set { _content = value; OnPropertyChanged("Content"); }
        }

        private Attachment _content;


        public static ElementDefinition.ConstraintComponent Media_MDA_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "height.empty() or type != 'audio'",
            Key = "mda-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Height can only be used for a photo or video",
            Xpath = "not(f:type/@value='audio') or not(f:height)"
        };

        public static ElementDefinition.ConstraintComponent Media_MDA_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "width.empty() or type != 'audio'",
            Key = "mda-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Width can only be used for a photo or video",
            Xpath = "not(f:type/@value='audio') or not(f:width)"
        };

        public static ElementDefinition.ConstraintComponent Media_MDA_4 = new ElementDefinition.ConstraintComponent
        {
            Expression = "duration.empty() or type != 'photo'",
            Key = "mda-4",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Duration can only be used for an audio or a video",
            Xpath = "not(f:type/@value='photo') or not(f:duration)"
        };

        public static ElementDefinition.ConstraintComponent Media_MDA_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "frames.empty() or type = 'photo'",
            Key = "mda-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Frames can only be used for a photo",
            Xpath = "(f:type/@value='photo') or not(f:frames)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Media_MDA_1);
            InvariantConstraints.Add(Media_MDA_2);
            InvariantConstraints.Add(Media_MDA_4);
            InvariantConstraints.Add(Media_MDA_3);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Media;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (TypeElement != null) dest.TypeElement = (Code<DigitalMediaType>)TypeElement.DeepCopy();
                if (Subtype != null) dest.Subtype = (CodeableConcept)Subtype.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Operator != null) dest.Operator = (ResourceReference)Operator.DeepCopy();
                if (View != null) dest.View = (CodeableConcept)View.DeepCopy();
                if (DeviceNameElement != null) dest.DeviceNameElement = (FhirString)DeviceNameElement.DeepCopy();
                if (HeightElement != null) dest.HeightElement = (PositiveInt)HeightElement.DeepCopy();
                if (WidthElement != null) dest.WidthElement = (PositiveInt)WidthElement.DeepCopy();
                if (FramesElement != null) dest.FramesElement = (PositiveInt)FramesElement.DeepCopy();
                if (DurationElement != null) dest.DurationElement = (UnsignedInt)DurationElement.DeepCopy();
                if (Content != null) dest.Content = (Attachment)Content.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Media());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Media;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.Matches(Subtype, otherT.Subtype)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Operator, otherT.Operator)) return false;
            if (!DeepComparable.Matches(View, otherT.View)) return false;
            if (!DeepComparable.Matches(DeviceNameElement, otherT.DeviceNameElement)) return false;
            if (!DeepComparable.Matches(HeightElement, otherT.HeightElement)) return false;
            if (!DeepComparable.Matches(WidthElement, otherT.WidthElement)) return false;
            if (!DeepComparable.Matches(FramesElement, otherT.FramesElement)) return false;
            if (!DeepComparable.Matches(DurationElement, otherT.DurationElement)) return false;
            if (!DeepComparable.Matches(Content, otherT.Content)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Media;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if (!DeepComparable.IsExactly(Subtype, otherT.Subtype)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Operator, otherT.Operator)) return false;
            if (!DeepComparable.IsExactly(View, otherT.View)) return false;
            if (!DeepComparable.IsExactly(DeviceNameElement, otherT.DeviceNameElement)) return false;
            if (!DeepComparable.IsExactly(HeightElement, otherT.HeightElement)) return false;
            if (!DeepComparable.IsExactly(WidthElement, otherT.WidthElement)) return false;
            if (!DeepComparable.IsExactly(FramesElement, otherT.FramesElement)) return false;
            if (!DeepComparable.IsExactly(DurationElement, otherT.DurationElement)) return false;
            if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (TypeElement != null) yield return TypeElement;
                if (Subtype != null) yield return Subtype;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Subject != null) yield return Subject;
                if (Operator != null) yield return Operator;
                if (View != null) yield return View;
                if (DeviceNameElement != null) yield return DeviceNameElement;
                if (HeightElement != null) yield return HeightElement;
                if (WidthElement != null) yield return WidthElement;
                if (FramesElement != null) yield return FramesElement;
                if (DurationElement != null) yield return DurationElement;
                if (Content != null) yield return Content;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (TypeElement != null) yield return new ElementValue("type", TypeElement);
                if (Subtype != null) yield return new ElementValue("subtype", Subtype);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Operator != null) yield return new ElementValue("operator", Operator);
                if (View != null) yield return new ElementValue("view", View);
                if (DeviceNameElement != null) yield return new ElementValue("deviceName", DeviceNameElement);
                if (HeightElement != null) yield return new ElementValue("height", HeightElement);
                if (WidthElement != null) yield return new ElementValue("width", WidthElement);
                if (FramesElement != null) yield return new ElementValue("frames", FramesElement);
                if (DurationElement != null) yield return new ElementValue("duration", DurationElement);
                if (Content != null) yield return new ElementValue("content", Content);
            }
        }

    }

}
