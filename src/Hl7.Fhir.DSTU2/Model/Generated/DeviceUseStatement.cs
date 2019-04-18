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
    [FhirType("DeviceUseStatement", IsResource = true)]
    [DataContract]
    public partial class DeviceUseStatement : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DeviceUseStatement; } }
        [NotMapped]
        public override string TypeName { get { return "DeviceUseStatement"; } }


        /// <summary>
        /// Target body site
        /// </summary>
        [FhirElement("bodySite", InSummary = true, Order = 90, Choice = ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept), typeof(ResourceReference))]
        [DataMember]
        public Element BodySite
        {
            get { return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private Element _bodySite;

        [FhirElement("whenUsed", InSummary = true, Order = 100)]
        [DataMember]
        public Period WhenUsed
        {
            get { return _whenUsed; }
            set { _whenUsed = value; OnPropertyChanged("WhenUsed"); }
        }

        private Period _whenUsed;

        [FhirElement("device", InSummary = true, Order = 110)]
        [References("Device")]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public ResourceReference Device
        {
            get { return _device; }
            set { _device = value; OnPropertyChanged("Device"); }
        }

        private ResourceReference _device;

        [FhirElement("identifier", InSummary = true, Order = 120)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        [FhirElement("indication", InSummary = true, Order = 130)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> Indication
        {
            get { if (_indication == null) _indication = new List<CodeableConcept>(); return _indication; }
            set { _indication = value; OnPropertyChanged("Indication"); }
        }

        private List<CodeableConcept> _indication;

        [FhirElement("notes", InSummary = true, Order = 140)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<FhirString> NotesElement
        {
            get { if (_notesElement == null) _notesElement = new List<FhirString>(); return _notesElement; }
            set { _notesElement = value; OnPropertyChanged("NotesElement"); }
        }

        private List<FhirString> _notesElement;

        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Notes
        {
            get { return NotesElement != null ? NotesElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    NotesElement = null;
                else
                    NotesElement = new List<FhirString>(value.Select(elem => new FhirString(elem)));
                OnPropertyChanged("Notes");
            }
        }

        [FhirElement("recordedOn", InSummary = true, Order = 150)]
        [DataMember]
        public FhirDateTime RecordedOnElement
        {
            get { return _recordedOnElement; }
            set { _recordedOnElement = value; OnPropertyChanged("RecordedOnElement"); }
        }

        private FhirDateTime _recordedOnElement;

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

        [FhirElement("subject", InSummary = true, Order = 160)]
        [References("Patient")]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        [FhirElement("timing", InSummary = true, Order = 170, Choice = ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Timing), typeof(Period), typeof(FhirDateTime))]
        [DataMember]
        public Element Timing
        {
            get { return _timing; }
            set { _timing = value; OnPropertyChanged("Timing"); }
        }

        private Element _timing;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DeviceUseStatement;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (BodySite != null) dest.BodySite = (Element)BodySite.DeepCopy();
                if (WhenUsed != null) dest.WhenUsed = (Period)WhenUsed.DeepCopy();
                if (Device != null) dest.Device = (ResourceReference)Device.DeepCopy();
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Indication != null) dest.Indication = new List<CodeableConcept>(Indication.DeepCopy());
                if (NotesElement != null) dest.NotesElement = new List<FhirString>(NotesElement.DeepCopy());
                if (RecordedOnElement != null) dest.RecordedOnElement = (FhirDateTime)RecordedOnElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
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
            if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.Matches(WhenUsed, otherT.WhenUsed)) return false;
            if (!DeepComparable.Matches(Device, otherT.Device)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Indication, otherT.Indication)) return false;
            if (!DeepComparable.Matches(NotesElement, otherT.NotesElement)) return false;
            if (!DeepComparable.Matches(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DeviceUseStatement;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(WhenUsed, otherT.WhenUsed)) return false;
            if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
            if (!DeepComparable.IsExactly(NotesElement, otherT.NotesElement)) return false;
            if (!DeepComparable.IsExactly(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (BodySite != null) yield return BodySite;
                if (WhenUsed != null) yield return WhenUsed;
                if (Device != null) yield return Device;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in Indication) { if (elem != null) yield return elem; }
                foreach (var elem in NotesElement) { if (elem != null) yield return elem; }
                if (RecordedOnElement != null) yield return RecordedOnElement;
                if (Subject != null) yield return Subject;
                if (Timing != null) yield return Timing;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                if (WhenUsed != null) yield return new ElementValue("whenUsed", WhenUsed);
                if (Device != null) yield return new ElementValue("device", Device);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in Indication) { if (elem != null) yield return new ElementValue("indication", elem); }
                foreach (var elem in NotesElement) { if (elem != null) yield return new ElementValue("notes", elem); }
                if (RecordedOnElement != null) yield return new ElementValue("recordedOn", RecordedOnElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Timing != null) yield return new ElementValue("timing", Timing);
            }
        }

    }

}
