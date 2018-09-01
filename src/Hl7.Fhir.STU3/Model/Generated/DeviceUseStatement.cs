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
    /// Record of use of a device
    /// </summary>
    [FhirType("DeviceUseStatement", IsResource=true)]
    [DataContract]
    public partial class DeviceUseStatement : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DeviceUseStatement; } }
        [NotMapped]
        public override string TypeName { get { return "DeviceUseStatement"; } }


        /// <summary>
        /// External identifier for this record
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
        /// active | completed | entered-in-error +
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<DeviceUseStatementStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<DeviceUseStatementStatus> _statusElement;

        /// <summary>
        /// active | completed | entered-in-error +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DeviceUseStatementStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<DeviceUseStatementStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Patient using device
        /// </summary>
        [FhirElement("subject", Order=110)]
        [References("Patient","Group")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Period device was used
        /// </summary>
        [FhirElement("whenUsed", Order=120)]
        [DataMember]
        public Period WhenUsed
        {
            get { return _whenUsed; }
            set { _whenUsed = value; OnPropertyChanged("WhenUsed"); }
        }

        private Period _whenUsed;

        /// <summary>
        /// How often  the device was used
        /// </summary>
        [FhirElement("timing", Order=130, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Timing),typeof(Period),typeof(FhirDateTime))]
        [DataMember]
        public Element Timing
        {
            get { return _timing; }
            set { _timing = value; OnPropertyChanged("Timing"); }
        }

        private Element _timing;

        /// <summary>
        /// When statement was recorded
        /// </summary>
        [FhirElement("recordedOn", Order=140)]
        [DataMember]
        public FhirDateTime RecordedOnElement
        {
            get { return _recordedOnElement; }
            set { _recordedOnElement = value; OnPropertyChanged("RecordedOnElement"); }
        }

        private FhirDateTime _recordedOnElement;

        /// <summary>
        /// When statement was recorded
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string RecordedOn
        {
            get { return RecordedOnElement != null ? RecordedOnElement.Value : null; }
            set
            {
                if (value == null)
                    RecordedOnElement = null;
                else
                    RecordedOnElement = new FhirDateTime(value);
                OnPropertyChanged("RecordedOn");
            }
        }

        /// <summary>
        /// Who made the statement
        /// </summary>
        [FhirElement("source", Order=150)]
        [References("Patient","Practitioner","RelatedPerson")]
        [DataMember]
        public ResourceReference Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private ResourceReference _source;

        /// <summary>
        /// Reference to device used
        /// </summary>
        [FhirElement("device", Order=160)]
        [References("Device")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Device
        {
            get { return _device; }
            set { _device = value; OnPropertyChanged("Device"); }
        }

        private ResourceReference _device;

        /// <summary>
        /// Why device was used
        /// </summary>
        [FhirElement("indication", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Indication
        {
            get { if (_indication==null) _indication = new List<CodeableConcept>(); return _indication; }
            set { _indication = value; OnPropertyChanged("Indication"); }
        }

        private List<CodeableConcept> _indication;

        /// <summary>
        /// Target body site
        /// </summary>
        [FhirElement("bodySite", Order=180)]
        [DataMember]
        public CodeableConcept BodySite
        {
            get { return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private CodeableConcept _bodySite;

        /// <summary>
        /// Addition details (comments, instructions)
        /// </summary>
        [FhirElement("note", Order=190)]
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
            var dest = other as DeviceUseStatement;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<DeviceUseStatementStatus>)StatusElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (WhenUsed != null) dest.WhenUsed = (Period)WhenUsed.DeepCopy();
                if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
                if (RecordedOnElement != null) dest.RecordedOnElement = (FhirDateTime)RecordedOnElement.DeepCopy();
                if (Source != null) dest.Source = (ResourceReference)Source.DeepCopy();
                if (Device != null) dest.Device = (ResourceReference)Device.DeepCopy();
                if (Indication != null) dest.Indication = new List<CodeableConcept>(Indication.DeepCopy());
                if (BodySite != null) dest.BodySite = (CodeableConcept)BodySite.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new DeviceUseStatement());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DeviceUseStatement;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(WhenUsed, otherT.WhenUsed)) return false;
            if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
            if (!DeepComparable.Matches(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if (!DeepComparable.Matches(Device, otherT.Device)) return false;
            if ( !DeepComparable.Matches(Indication, otherT.Indication)) return false;
            if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DeviceUseStatement;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(WhenUsed, otherT.WhenUsed)) return false;
            if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
            if (!DeepComparable.IsExactly(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if (!DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
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
                if (StatusElement != null) yield return StatusElement;
                if (Subject != null) yield return Subject;
                if (WhenUsed != null) yield return WhenUsed;
                if (Timing != null) yield return Timing;
                if (RecordedOnElement != null) yield return RecordedOnElement;
                if (Source != null) yield return Source;
                if (Device != null) yield return Device;
                foreach (var elem in Indication) { if (elem != null) yield return elem; }
                if (BodySite != null) yield return BodySite;
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
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (WhenUsed != null) yield return new ElementValue("whenUsed", WhenUsed);
                if (Timing != null) yield return new ElementValue("timing", Timing);
                if (RecordedOnElement != null) yield return new ElementValue("recordedOn", RecordedOnElement);
                if (Source != null) yield return new ElementValue("source", Source);
                if (Device != null) yield return new ElementValue("device", Device);
                foreach (var elem in Indication) { if (elem != null) yield return new ElementValue("indication", elem); }
                if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
