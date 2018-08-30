using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
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
        /// Identifier(s) for the image
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
        /// Procedure that caused this media to be created
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=100)]
        [References("ServiceRequest","CarePlan")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Part of referenced event
        /// </summary>
        [FhirElement("partOf", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// preparation | in-progress | not-done | suspended | aborted | completed | entered-in-error | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<EventStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<EventStatus> _statusElement;

        /// <summary>
        /// preparation | in-progress | not-done | suspended | aborted | completed | entered-in-error | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public EventStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<EventStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Classification of media as image, video, or audio
        /// </summary>
        [FhirElement("type", InSummary=true, Order=130)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// The type of acquisition equipment/process
        /// </summary>
        [FhirElement("modality", InSummary=true, Order=140)]
        [DataMember]
        public CodeableConcept Modality
        {
            get { return _modality; }
            set { _modality = value; OnPropertyChanged("Modality"); }
        }

        private CodeableConcept _modality;

        /// <summary>
        /// Imaging view, e.g. Lateral or Antero-posterior
        /// </summary>
        [FhirElement("view", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept View
        {
            get { return _view; }
            set { _view = value; OnPropertyChanged("View"); }
        }

        private CodeableConcept _view;

        /// <summary>
        /// Who/What this Media is a record of
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=160)]
        [References("Patient","Practitioner","Group","Device","Specimen","Location")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Encounter / Episode associated with media
        /// </summary>
        [FhirElement("context", InSummary=true, Order=170)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When Media was collected
        /// </summary>
        [FhirElement("created", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [DataMember]
        public Element Created
        {
            get { return _created; }
            set { _created = value; OnPropertyChanged("Created"); }
        }

        private Element _created;

        /// <summary>
        /// Date/Time this version was made available
        /// </summary>
        [FhirElement("issued", InSummary=true, Order=190)]
        [DataMember]
        public Instant IssuedElement
        {
            get { return _issuedElement; }
            set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
        }

        private Instant _issuedElement;

        /// <summary>
        /// Date/Time this version was made available
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
        /// The person who generated the image
        /// </summary>
        [FhirElement("operator", InSummary=true, Order=200)]
        [References("Practitioner","PractitionerRole","Organization","CareTeam","Patient","Device","RelatedPerson")]
        [DataMember]
        public ResourceReference Operator
        {
            get { return _operator; }
            set { _operator = value; OnPropertyChanged("Operator"); }
        }

        private ResourceReference _operator;

        /// <summary>
        /// Why was event performed?
        /// </summary>
        [FhirElement("reasonCode", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Observed body part
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=220)]
        [DataMember]
        public CodeableConcept BodySite
        {
            get { return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private CodeableConcept _bodySite;

        /// <summary>
        /// Name of the device/manufacturer
        /// </summary>
        [FhirElement("deviceName", InSummary=true, Order=230)]
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
        /// Observing Device
        /// </summary>
        [FhirElement("device", InSummary=true, Order=240)]
        [References("Device","DeviceMetric","DeviceComponent")]
        [DataMember]
        public ResourceReference Device
        {
            get { return _device; }
            set { _device = value; OnPropertyChanged("Device"); }
        }

        private ResourceReference _device;

        /// <summary>
        /// Height of the image in pixels (photo/video)
        /// </summary>
        [FhirElement("height", InSummary=true, Order=250)]
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
                if (value == null)
                    HeightElement = null;
                else
                    HeightElement = new PositiveInt(value);
                OnPropertyChanged("Height");
            }
        }

        /// <summary>
        /// Width of the image in pixels (photo/video)
        /// </summary>
        [FhirElement("width", InSummary=true, Order=260)]
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
                if (value == null)
                    WidthElement = null;
                else
                    WidthElement = new PositiveInt(value);
                OnPropertyChanged("Width");
            }
        }

        /// <summary>
        /// Number of frames if &gt; 1 (photo)
        /// </summary>
        [FhirElement("frames", InSummary=true, Order=270)]
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
                if (value == null)
                    FramesElement = null;
                else
                    FramesElement = new PositiveInt(value);
                OnPropertyChanged("Frames");
            }
        }

        /// <summary>
        /// Length in seconds (audio / video)
        /// </summary>
        [FhirElement("duration", InSummary=true, Order=280)]
        [DataMember]
        public FhirDecimal DurationElement
        {
            get { return _durationElement; }
            set { _durationElement = value; OnPropertyChanged("DurationElement"); }
        }

        private FhirDecimal _durationElement;

        /// <summary>
        /// Length in seconds (audio / video)
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
        /// Actual Media - reference or data
        /// </summary>
        [FhirElement("content", InSummary=true, Order=290)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Attachment Content
        {
            get { return _content; }
            set { _content = value; OnPropertyChanged("Content"); }
        }

        private Attachment _content;

        /// <summary>
        /// Comments made about the media
        /// </summary>
        [FhirElement("note", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Media;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<EventStatus>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Modality != null) dest.Modality = (CodeableConcept)Modality.DeepCopy();
                if (View != null) dest.View = (CodeableConcept)View.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Created != null) dest.Created = (Element)Created.DeepCopy();
                if (IssuedElement != null) dest.IssuedElement = (Instant)IssuedElement.DeepCopy();
                if (Operator != null) dest.Operator = (ResourceReference)Operator.DeepCopy();
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (BodySite != null) dest.BodySite = (CodeableConcept)BodySite.DeepCopy();
                if (DeviceNameElement != null) dest.DeviceNameElement = (FhirString)DeviceNameElement.DeepCopy();
                if (Device != null) dest.Device = (ResourceReference)Device.DeepCopy();
                if (HeightElement != null) dest.HeightElement = (PositiveInt)HeightElement.DeepCopy();
                if (WidthElement != null) dest.WidthElement = (PositiveInt)WidthElement.DeepCopy();
                if (FramesElement != null) dest.FramesElement = (PositiveInt)FramesElement.DeepCopy();
                if (DurationElement != null) dest.DurationElement = (FhirDecimal)DurationElement.DeepCopy();
                if (Content != null) dest.Content = (Attachment)Content.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
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
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Modality, otherT.Modality)) return false;
            if (!DeepComparable.Matches(View, otherT.View)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Created, otherT.Created)) return false;
            if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.Matches(Operator, otherT.Operator)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.Matches(DeviceNameElement, otherT.DeviceNameElement)) return false;
            if (!DeepComparable.Matches(Device, otherT.Device)) return false;
            if (!DeepComparable.Matches(HeightElement, otherT.HeightElement)) return false;
            if (!DeepComparable.Matches(WidthElement, otherT.WidthElement)) return false;
            if (!DeepComparable.Matches(FramesElement, otherT.FramesElement)) return false;
            if (!DeepComparable.Matches(DurationElement, otherT.DurationElement)) return false;
            if (!DeepComparable.Matches(Content, otherT.Content)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Media;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Modality, otherT.Modality)) return false;
            if (!DeepComparable.IsExactly(View, otherT.View)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Created, otherT.Created)) return false;
            if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.IsExactly(Operator, otherT.Operator)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(DeviceNameElement, otherT.DeviceNameElement)) return false;
            if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if (!DeepComparable.IsExactly(HeightElement, otherT.HeightElement)) return false;
            if (!DeepComparable.IsExactly(WidthElement, otherT.WidthElement)) return false;
            if (!DeepComparable.IsExactly(FramesElement, otherT.FramesElement)) return false;
            if (!DeepComparable.IsExactly(DurationElement, otherT.DurationElement)) return false;
            if (!DeepComparable.IsExactly(Content, otherT.Content)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;

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
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (Type != null) yield return Type;
                if (Modality != null) yield return Modality;
                if (View != null) yield return View;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Created != null) yield return Created;
                if (IssuedElement != null) yield return IssuedElement;
                if (Operator != null) yield return Operator;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                if (BodySite != null) yield return BodySite;
                if (DeviceNameElement != null) yield return DeviceNameElement;
                if (Device != null) yield return Device;
                if (HeightElement != null) yield return HeightElement;
                if (WidthElement != null) yield return WidthElement;
                if (FramesElement != null) yield return FramesElement;
                if (DurationElement != null) yield return DurationElement;
                if (Content != null) yield return Content;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
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
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (Modality != null) yield return new ElementValue("modality", Modality);
                if (View != null) yield return new ElementValue("view", View);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Created != null) yield return new ElementValue("created", Created);
                if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                if (Operator != null) yield return new ElementValue("operator", Operator);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                if (DeviceNameElement != null) yield return new ElementValue("deviceName", DeviceNameElement);
                if (Device != null) yield return new ElementValue("device", Device);
                if (HeightElement != null) yield return new ElementValue("height", HeightElement);
                if (WidthElement != null) yield return new ElementValue("width", WidthElement);
                if (FramesElement != null) yield return new ElementValue("frames", FramesElement);
                if (DurationElement != null) yield return new ElementValue("duration", DurationElement);
                if (Content != null) yield return new ElementValue("content", Content);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
