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
        /// A coded concept indicating the current status of a the Device Usage.
        /// (url: http://hl7.org/fhir/ValueSet/device-statement-status)
        /// </summary>
        [FhirEnumeration("DeviceUseStatementStatus")]
        public enum DeviceUseStatementStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-statement-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/device-statement-status"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-statement-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/device-statement-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-statement-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/device-statement-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-statement-status)
            /// </summary>
            [EnumLiteral("intended", "http://hl7.org/fhir/device-statement-status"), Description("Intended")]
            Intended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-statement-status)
            /// </summary>
            [EnumLiteral("stopped", "http://hl7.org/fhir/device-statement-status"), Description("Stopped")]
            Stopped,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/device-statement-status)
            /// </summary>
            [EnumLiteral("on-hold", "http://hl7.org/fhir/device-statement-status"), Description("On Hold")]
            OnHold,
        }


        /// <summary>
        /// External identifier for this record
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
        /// Fulfills plan, proposal or order
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=100)]
        [References("ServiceRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// active | completed | entered-in-error +
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
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
        [FhirElement("subject", InSummary=true, Order=120)]
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
        /// Supporting information
        /// </summary>
        [FhirElement("derivedFrom", InSummary=true, Order=130)]
        [References("ServiceRequest","Procedure","Claim","Observation","QuestionnaireResponse","DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> DerivedFrom
        {
            get { if (_derivedFrom==null) _derivedFrom = new List<ResourceReference>(); return _derivedFrom; }
            set { _derivedFrom = value; OnPropertyChanged("DerivedFrom"); }
        }

        private List<ResourceReference> _derivedFrom;

        /// <summary>
        /// How often  the device was used
        /// </summary>
        [FhirElement("timing", InSummary=true, Order=140, Choice=ChoiceType.DatatypeChoice)]
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
        [FhirElement("recordedOn", InSummary=true, Order=150)]
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
        [FhirElement("source", InSummary=true, Order=160)]
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
        [FhirElement("device", InSummary=true, Order=170)]
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
        [FhirElement("reasonCode", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Why was DeviceUseStatement performed?
        /// </summary>
        [FhirElement("reasonReference", InSummary=true, Order=190)]
        [References("Condition","Observation","DiagnosticReport","DocumentReference","Media")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// Target body site
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=200)]
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
        [FhirElement("note", Order=210)]
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
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<DeviceUseStatementStatus>)StatusElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (DerivedFrom != null) dest.DerivedFrom = new List<ResourceReference>(DerivedFrom.DeepCopy());
                if (Timing != null) dest.Timing = (Element)Timing.DeepCopy();
                if (RecordedOnElement != null) dest.RecordedOnElement = (FhirDateTime)RecordedOnElement.DeepCopy();
                if (Source != null) dest.Source = (ResourceReference)Source.DeepCopy();
                if (Device != null) dest.Device = (ResourceReference)Device.DeepCopy();
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
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
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(DerivedFrom, otherT.DerivedFrom)) return false;
            if (!DeepComparable.Matches(Timing, otherT.Timing)) return false;
            if (!DeepComparable.Matches(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if (!DeepComparable.Matches(Device, otherT.Device)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
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
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(DerivedFrom, otherT.DerivedFrom)) return false;
            if (!DeepComparable.IsExactly(Timing, otherT.Timing)) return false;
            if (!DeepComparable.IsExactly(RecordedOnElement, otherT.RecordedOnElement)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
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
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (Subject != null) yield return Subject;
                foreach (var elem in DerivedFrom) { if (elem != null) yield return elem; }
                if (Timing != null) yield return Timing;
                if (RecordedOnElement != null) yield return RecordedOnElement;
                if (Source != null) yield return Source;
                if (Device != null) yield return Device;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
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
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                foreach (var elem in DerivedFrom) { if (elem != null) yield return new ElementValue("derivedFrom", elem); }
                if (Timing != null) yield return new ElementValue("timing", Timing);
                if (RecordedOnElement != null) yield return new ElementValue("recordedOn", RecordedOnElement);
                if (Source != null) yield return new ElementValue("source", Source);
                if (Device != null) yield return new ElementValue("device", Device);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
