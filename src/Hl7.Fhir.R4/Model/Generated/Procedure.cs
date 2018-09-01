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
    /// An action that is being or was performed on a patient
    /// </summary>
    [FhirType("Procedure", IsResource=true)]
    [DataContract]
    public partial class Procedure : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Procedure; } }
        [NotMapped]
        public override string TypeName { get { return "Procedure"; } }


        [FhirType("PerformerComponent")]
        [DataContract]
        public partial class PerformerComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PerformerComponent"; } }

            /// <summary>
            /// Type of performance
            /// </summary>
            [FhirElement("function", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Function
            {
                get { return _function; }
                set { _function = value; OnPropertyChanged("Function"); }
            }

            private CodeableConcept _function;

            /// <summary>
            /// The reference to the practitioner
            /// </summary>
            [FhirElement("actor", InSummary=true, Order=50)]
            [References("Practitioner","PractitionerRole","Organization","Patient","RelatedPerson","Device")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            /// <summary>
            /// Organization the device or practitioner was acting for
            /// </summary>
            [FhirElement("onBehalfOf", Order=60)]
            [References("Organization")]
            [DataMember]
            public ResourceReference OnBehalfOf
            {
                get { return _onBehalfOf; }
                set { _onBehalfOf = value; OnPropertyChanged("OnBehalfOf"); }
            }

            private ResourceReference _onBehalfOf;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PerformerComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Function != null) dest.Function = (CodeableConcept)Function.DeepCopy();
                    if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
                    if (OnBehalfOf != null) dest.OnBehalfOf = (ResourceReference)OnBehalfOf.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PerformerComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PerformerComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Function, otherT.Function)) return false;
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if (!DeepComparable.Matches(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PerformerComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Function, otherT.Function)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if (!DeepComparable.IsExactly(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Function != null) yield return Function;
                    if (Actor != null) yield return Actor;
                    if (OnBehalfOf != null) yield return OnBehalfOf;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Function != null) yield return new ElementValue("function", Function);
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                    if (OnBehalfOf != null) yield return new ElementValue("onBehalfOf", OnBehalfOf);
                }
            }


        }


        [FhirType("FocalDeviceComponent")]
        [DataContract]
        public partial class FocalDeviceComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "FocalDeviceComponent"; } }

            /// <summary>
            /// Kind of change to device
            /// </summary>
            [FhirElement("action", Order=40)]
            [DataMember]
            public CodeableConcept Action
            {
                get { return _action; }
                set { _action = value; OnPropertyChanged("Action"); }
            }

            private CodeableConcept _action;

            /// <summary>
            /// Device that was changed
            /// </summary>
            [FhirElement("manipulated", Order=50)]
            [References("Device")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Manipulated
            {
                get { return _manipulated; }
                set { _manipulated = value; OnPropertyChanged("Manipulated"); }
            }

            private ResourceReference _manipulated;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as FocalDeviceComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Action != null) dest.Action = (CodeableConcept)Action.DeepCopy();
                    if (Manipulated != null) dest.Manipulated = (ResourceReference)Manipulated.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new FocalDeviceComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as FocalDeviceComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Action, otherT.Action)) return false;
                if (!DeepComparable.Matches(Manipulated, otherT.Manipulated)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as FocalDeviceComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Action, otherT.Action)) return false;
                if (!DeepComparable.IsExactly(Manipulated, otherT.Manipulated)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Action != null) yield return Action;
                    if (Manipulated != null) yield return Manipulated;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Action != null) yield return new ElementValue("action", Action);
                    if (Manipulated != null) yield return new ElementValue("manipulated", Manipulated);
                }
            }


        }


        /// <summary>
        /// External Identifiers for this procedure
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
        /// Instantiates FHIR protocol or definition
        /// </summary>
        [FhirElement("instantiatesCanonical", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Canonical> InstantiatesCanonicalElement
        {
            get { if (_instantiatesCanonicalElement==null) _instantiatesCanonicalElement = new List<Canonical>(); return _instantiatesCanonicalElement; }
            set { _instantiatesCanonicalElement = value; OnPropertyChanged("InstantiatesCanonicalElement"); }
        }

        private List<Canonical> _instantiatesCanonicalElement;

        /// <summary>
        /// Instantiates FHIR protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> InstantiatesCanonical
        {
            get { return InstantiatesCanonicalElement != null ? InstantiatesCanonicalElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesCanonicalElement = null;
                else
                    InstantiatesCanonicalElement = new List<Canonical>(value.Select(elem=>new Canonical(elem)));
                OnPropertyChanged("InstantiatesCanonical");
            }
        }

        /// <summary>
        /// Instantiates external protocol or definition
        /// </summary>
        [FhirElement("instantiatesUri", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> InstantiatesUriElement
        {
            get { if (_instantiatesUriElement==null) _instantiatesUriElement = new List<FhirUri>(); return _instantiatesUriElement; }
            set { _instantiatesUriElement = value; OnPropertyChanged("InstantiatesUriElement"); }
        }

        private List<FhirUri> _instantiatesUriElement;

        /// <summary>
        /// Instantiates external protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> InstantiatesUri
        {
            get { return InstantiatesUriElement != null ? InstantiatesUriElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesUriElement = null;
                else
                    InstantiatesUriElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("InstantiatesUri");
            }
        }

        /// <summary>
        /// A request for this procedure
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=120)]
        [References("CarePlan","ServiceRequest")]
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
        [FhirElement("partOf", InSummary=true, Order=130)]
        [References("Procedure","Observation","MedicationAdministration")]
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
        [FhirElement("status", InSummary=true, Order=140)]
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
        /// Reason for current status
        /// </summary>
        [FhirElement("statusReason", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept StatusReason
        {
            get { return _statusReason; }
            set { _statusReason = value; OnPropertyChanged("StatusReason"); }
        }

        private CodeableConcept _statusReason;

        /// <summary>
        /// Classification of the procedure
        /// </summary>
        [FhirElement("category", InSummary=true, Order=160)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// Identification of the procedure
        /// </summary>
        [FhirElement("code", InSummary=true, Order=170)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Who the procedure was performed on
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=180)]
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
        /// Encounter or episode associated with the procedure
        /// </summary>
        [FhirElement("context", InSummary=true, Order=190)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When the procedure was performed
        /// </summary>
        [FhirElement("performed", InSummary=true, Order=200, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(FhirString),typeof(Age),typeof(Range))]
        [DataMember]
        public Element Performed
        {
            get { return _performed; }
            set { _performed = value; OnPropertyChanged("Performed"); }
        }

        private Element _performed;

        /// <summary>
        /// Who recorded the procedure
        /// </summary>
        [FhirElement("recorder", InSummary=true, Order=210)]
        [References("Patient","RelatedPerson","Practitioner","PractitionerRole")]
        [DataMember]
        public ResourceReference Recorder
        {
            get { return _recorder; }
            set { _recorder = value; OnPropertyChanged("Recorder"); }
        }

        private ResourceReference _recorder;

        /// <summary>
        /// Person who asserts this procedure
        /// </summary>
        [FhirElement("asserter", InSummary=true, Order=220)]
        [References("Patient","RelatedPerson","Practitioner","PractitionerRole")]
        [DataMember]
        public ResourceReference Asserter
        {
            get { return _asserter; }
            set { _asserter = value; OnPropertyChanged("Asserter"); }
        }

        private ResourceReference _asserter;

        /// <summary>
        /// The people who performed the procedure
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PerformerComponent> Performer
        {
            get { if (_performer==null) _performer = new List<PerformerComponent>(); return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private List<PerformerComponent> _performer;

        /// <summary>
        /// Where the procedure happened
        /// </summary>
        [FhirElement("location", InSummary=true, Order=240)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// Coded reason procedure performed
        /// </summary>
        [FhirElement("reasonCode", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// The justification that the procedure was performed
        /// </summary>
        [FhirElement("reasonReference", InSummary=true, Order=260)]
        [References("Condition","Observation","Procedure","DiagnosticReport","DocumentReference")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// Target body sites
        /// </summary>
        [FhirElement("bodySite", InSummary=true, Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> BodySite
        {
            get { if (_bodySite==null) _bodySite = new List<CodeableConcept>(); return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private List<CodeableConcept> _bodySite;

        /// <summary>
        /// The result of procedure
        /// </summary>
        [FhirElement("outcome", InSummary=true, Order=280)]
        [DataMember]
        public CodeableConcept Outcome
        {
            get { return _outcome; }
            set { _outcome = value; OnPropertyChanged("Outcome"); }
        }

        private CodeableConcept _outcome;

        /// <summary>
        /// Any report resulting from the procedure
        /// </summary>
        [FhirElement("report", Order=290)]
        [References("DiagnosticReport","DocumentReference","Composition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Report
        {
            get { if (_report==null) _report = new List<ResourceReference>(); return _report; }
            set { _report = value; OnPropertyChanged("Report"); }
        }

        private List<ResourceReference> _report;

        /// <summary>
        /// Complication following the procedure
        /// </summary>
        [FhirElement("complication", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Complication
        {
            get { if (_complication==null) _complication = new List<CodeableConcept>(); return _complication; }
            set { _complication = value; OnPropertyChanged("Complication"); }
        }

        private List<CodeableConcept> _complication;

        /// <summary>
        /// A condition that is a result of the procedure
        /// </summary>
        [FhirElement("complicationDetail", Order=310)]
        [References("Condition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ComplicationDetail
        {
            get { if (_complicationDetail==null) _complicationDetail = new List<ResourceReference>(); return _complicationDetail; }
            set { _complicationDetail = value; OnPropertyChanged("ComplicationDetail"); }
        }

        private List<ResourceReference> _complicationDetail;

        /// <summary>
        /// Instructions for follow up
        /// </summary>
        [FhirElement("followUp", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> FollowUp
        {
            get { if (_followUp==null) _followUp = new List<CodeableConcept>(); return _followUp; }
            set { _followUp = value; OnPropertyChanged("FollowUp"); }
        }

        private List<CodeableConcept> _followUp;

        /// <summary>
        /// Additional information about the procedure
        /// </summary>
        [FhirElement("note", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Manipulated, implanted, or removed device
        /// </summary>
        [FhirElement("focalDevice", Order=340)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FocalDeviceComponent> FocalDevice
        {
            get { if (_focalDevice==null) _focalDevice = new List<FocalDeviceComponent>(); return _focalDevice; }
            set { _focalDevice = value; OnPropertyChanged("FocalDevice"); }
        }

        private List<FocalDeviceComponent> _focalDevice;

        /// <summary>
        /// Items used during procedure
        /// </summary>
        [FhirElement("usedReference", Order=350)]
        [References("Device","Medication","Substance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> UsedReference
        {
            get { if (_usedReference==null) _usedReference = new List<ResourceReference>(); return _usedReference; }
            set { _usedReference = value; OnPropertyChanged("UsedReference"); }
        }

        private List<ResourceReference> _usedReference;

        /// <summary>
        /// Coded items used during the procedure
        /// </summary>
        [FhirElement("usedCode", Order=360)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> UsedCode
        {
            get { if (_usedCode==null) _usedCode = new List<CodeableConcept>(); return _usedCode; }
            set { _usedCode = value; OnPropertyChanged("UsedCode"); }
        }

        private List<CodeableConcept> _usedCode;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Procedure;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (InstantiatesCanonicalElement != null) dest.InstantiatesCanonicalElement = new List<Canonical>(InstantiatesCanonicalElement.DeepCopy());
                if (InstantiatesUriElement != null) dest.InstantiatesUriElement = new List<FhirUri>(InstantiatesUriElement.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<EventStatus>)StatusElement.DeepCopy();
                if (StatusReason != null) dest.StatusReason = (CodeableConcept)StatusReason.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Performed != null) dest.Performed = (Element)Performed.DeepCopy();
                if (Recorder != null) dest.Recorder = (ResourceReference)Recorder.DeepCopy();
                if (Asserter != null) dest.Asserter = (ResourceReference)Asserter.DeepCopy();
                if (Performer != null) dest.Performer = new List<PerformerComponent>(Performer.DeepCopy());
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (BodySite != null) dest.BodySite = new List<CodeableConcept>(BodySite.DeepCopy());
                if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                if (Report != null) dest.Report = new List<ResourceReference>(Report.DeepCopy());
                if (Complication != null) dest.Complication = new List<CodeableConcept>(Complication.DeepCopy());
                if (ComplicationDetail != null) dest.ComplicationDetail = new List<ResourceReference>(ComplicationDetail.DeepCopy());
                if (FollowUp != null) dest.FollowUp = new List<CodeableConcept>(FollowUp.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (FocalDevice != null) dest.FocalDevice = new List<FocalDeviceComponent>(FocalDevice.DeepCopy());
                if (UsedReference != null) dest.UsedReference = new List<ResourceReference>(UsedReference.DeepCopy());
                if (UsedCode != null) dest.UsedCode = new List<CodeableConcept>(UsedCode.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Procedure());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Procedure;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(InstantiatesCanonicalElement, otherT.InstantiatesCanonicalElement)) return false;
            if ( !DeepComparable.Matches(InstantiatesUriElement, otherT.InstantiatesUriElement)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Performed, otherT.Performed)) return false;
            if (!DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.Matches(Asserter, otherT.Asserter)) return false;
            if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if ( !DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
            if ( !DeepComparable.Matches(Report, otherT.Report)) return false;
            if ( !DeepComparable.Matches(Complication, otherT.Complication)) return false;
            if ( !DeepComparable.Matches(ComplicationDetail, otherT.ComplicationDetail)) return false;
            if ( !DeepComparable.Matches(FollowUp, otherT.FollowUp)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(FocalDevice, otherT.FocalDevice)) return false;
            if ( !DeepComparable.Matches(UsedReference, otherT.UsedReference)) return false;
            if ( !DeepComparable.Matches(UsedCode, otherT.UsedCode)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Procedure;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(InstantiatesCanonicalElement, otherT.InstantiatesCanonicalElement)) return false;
            if (!DeepComparable.IsExactly(InstantiatesUriElement, otherT.InstantiatesUriElement)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Performed, otherT.Performed)) return false;
            if (!DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.IsExactly(Asserter, otherT.Asserter)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.IsExactly(Report, otherT.Report)) return false;
            if (!DeepComparable.IsExactly(Complication, otherT.Complication)) return false;
            if (!DeepComparable.IsExactly(ComplicationDetail, otherT.ComplicationDetail)) return false;
            if (!DeepComparable.IsExactly(FollowUp, otherT.FollowUp)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(FocalDevice, otherT.FocalDevice)) return false;
            if (!DeepComparable.IsExactly(UsedReference, otherT.UsedReference)) return false;
            if (!DeepComparable.IsExactly(UsedCode, otherT.UsedCode)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in InstantiatesCanonicalElement) { if (elem != null) yield return elem; }
                foreach (var elem in InstantiatesUriElement) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (StatusReason != null) yield return StatusReason;
                if (Category != null) yield return Category;
                if (Code != null) yield return Code;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Performed != null) yield return Performed;
                if (Recorder != null) yield return Recorder;
                if (Asserter != null) yield return Asserter;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                if (Location != null) yield return Location;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in BodySite) { if (elem != null) yield return elem; }
                if (Outcome != null) yield return Outcome;
                foreach (var elem in Report) { if (elem != null) yield return elem; }
                foreach (var elem in Complication) { if (elem != null) yield return elem; }
                foreach (var elem in ComplicationDetail) { if (elem != null) yield return elem; }
                foreach (var elem in FollowUp) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in FocalDevice) { if (elem != null) yield return elem; }
                foreach (var elem in UsedReference) { if (elem != null) yield return elem; }
                foreach (var elem in UsedCode) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in InstantiatesCanonicalElement) { if (elem != null) yield return new ElementValue("instantiatesCanonical", elem); }
                foreach (var elem in InstantiatesUriElement) { if (elem != null) yield return new ElementValue("instantiatesUri", elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (StatusReason != null) yield return new ElementValue("statusReason", StatusReason);
                if (Category != null) yield return new ElementValue("category", Category);
                if (Code != null) yield return new ElementValue("code", Code);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Performed != null) yield return new ElementValue("performed", Performed);
                if (Recorder != null) yield return new ElementValue("recorder", Recorder);
                if (Asserter != null) yield return new ElementValue("asserter", Asserter);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                if (Location != null) yield return new ElementValue("location", Location);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", elem); }
                if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                foreach (var elem in Report) { if (elem != null) yield return new ElementValue("report", elem); }
                foreach (var elem in Complication) { if (elem != null) yield return new ElementValue("complication", elem); }
                foreach (var elem in ComplicationDetail) { if (elem != null) yield return new ElementValue("complicationDetail", elem); }
                foreach (var elem in FollowUp) { if (elem != null) yield return new ElementValue("followUp", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in FocalDevice) { if (elem != null) yield return new ElementValue("focalDevice", elem); }
                foreach (var elem in UsedReference) { if (elem != null) yield return new ElementValue("usedReference", elem); }
                foreach (var elem in UsedCode) { if (elem != null) yield return new ElementValue("usedCode", elem); }
            }
        }

    }

}
