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
    /// An action that is being or was performed on a patient
    /// </summary>
    [FhirType("Procedure", IsResource = true)]
    [DataContract]
    public partial class Procedure : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Procedure; } }
        [NotMapped]
        public override string TypeName { get { return "Procedure"; } }

        /// <summary>
        /// A code specifying the state of the procedure.
        /// (url: http://hl7.org/fhir/ValueSet/procedure-status)
        /// </summary>
        [FhirEnumeration("ProcedureStatus")]
        public enum ProcedureStatus
        {
            /// <summary>
            /// The procedure is still occurring.
            /// (system: http://hl7.org/fhir/procedure-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/procedure-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// The procedure was terminated without completing successfully.
            /// (system: http://hl7.org/fhir/procedure-status)
            /// </summary>
            [EnumLiteral("aborted", "http://hl7.org/fhir/procedure-status"), Description("Aboted")]
            Aborted,
            /// <summary>
            /// All actions involved in the procedure have taken place.
            /// (system: http://hl7.org/fhir/procedure-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/procedure-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The statement was entered in error and Is not valid.
            /// (system: http://hl7.org/fhir/procedure-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/procedure-status"), Description("Entered in Error")]
            EnteredInError,
        }


        [FhirType("PerformerComponent")]
        [DataContract]
        public partial class PerformerComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PerformerComponent"; } }

            /// <summary>
            /// The reference to the practitioner
            /// </summary>
            [FhirElement("actor", InSummary = true, Order = 40)]
            [References("Practitioner", "Organization", "Patient", "RelatedPerson")]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            /// <summary>
            /// The role the actor was in
            /// </summary>
            [FhirElement("role", InSummary = true, Order = 50)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PerformerComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Actor != null) dest.Actor = (ResourceReference)Actor.DeepCopy();
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
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
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PerformerComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Actor != null) yield return Actor;
                    if (Role != null) yield return Role;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                    if (Role != null) yield return new ElementValue("role", Role);
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
            [FhirElement("action", Order = 40)]
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
            [FhirElement("manipulated", Order = 50)]
            [References("Device")]
            [Cardinality(Min = 1, Max = 1)]
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
        [FhirElement("identifier", InSummary = true, Order = 90)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// Who the procedure was performed on
        /// </summary>
        [FhirElement("subject", InSummary = true, Order = 100)]
        [References("Patient", "Group")]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// in-progress | aborted | completed | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary = true, Order = 110)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public Code<ProcedureStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ProcedureStatus> _statusElement;

        /// <summary>
        /// in-progress | aborted | completed | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ProcedureStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    StatusElement = null;
                else
                    StatusElement = new Code<ProcedureStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Classification of the procedure
        /// </summary>
        [FhirElement("category", InSummary = true, Order = 120)]
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
        [FhirElement("code", InSummary = true, Order = 130)]
        [Cardinality(Min = 1, Max = 1)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// True if procedure was not performed as scheduled
        /// </summary>
        [FhirElement("notPerformed", Order = 140)]
        [DataMember]
        public FhirBoolean NotPerformedElement
        {
            get { return _notPerformedElement; }
            set { _notPerformedElement = value; OnPropertyChanged("NotPerformedElement"); }
        }

        private FhirBoolean _notPerformedElement;

        /// <summary>
        /// True if procedure was not performed as scheduled
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? NotPerformed
        {
            get { return NotPerformedElement != null ? NotPerformedElement.Value : null; }
            set
            {
                if (!value.HasValue)
                    NotPerformedElement = null;
                else
                    NotPerformedElement = new FhirBoolean(value);
                OnPropertyChanged("NotPerformed");
            }
        }

        /// <summary>
        /// Reason procedure was not performed
        /// </summary>
        [FhirElement("reasonNotPerformed", Order = 150)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> ReasonNotPerformed
        {
            get { if (_reasonNotPerformed == null) _reasonNotPerformed = new List<CodeableConcept>(); return _reasonNotPerformed; }
            set { _reasonNotPerformed = value; OnPropertyChanged("ReasonNotPerformed"); }
        }

        private List<CodeableConcept> _reasonNotPerformed;

        /// <summary>
        /// Target body sites
        /// </summary>
        [FhirElement("bodySite", InSummary = true, Order = 160)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> BodySite
        {
            get { if (_bodySite == null) _bodySite = new List<CodeableConcept>(); return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private List<CodeableConcept> _bodySite;

        /// <summary>
        /// Reason procedure performed
        /// </summary>
        [FhirElement("reason", InSummary = true, Order = 170, Choice = ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept), typeof(ResourceReference))]
        [DataMember]
        public Element Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private Element _reason;

        /// <summary>
        /// The people who performed the procedure
        /// </summary>
        [FhirElement("performer", InSummary = true, Order = 180)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<PerformerComponent> Performer
        {
            get { if (_performer == null) _performer = new List<PerformerComponent>(); return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private List<PerformerComponent> _performer;

        /// <summary>
        /// Date/Period the procedure was performed
        /// </summary>
        [FhirElement("performed", InSummary = true, Order = 190, Choice = ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime), typeof(Period))]
        [DataMember]
        public Element Performed
        {
            get { return _performed; }
            set { _performed = value; OnPropertyChanged("Performed"); }
        }

        private Element _performed;

        /// <summary>
        /// The encounter associated with the procedure
        /// </summary>
        [FhirElement("encounter", InSummary = true, Order = 200)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Where the procedure happened
        /// </summary>
        [FhirElement("location", InSummary = true, Order = 210)]
        [References("Location")]
        [DataMember]
        public ResourceReference Location
        {
            get { return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private ResourceReference _location;

        /// <summary>
        /// The result of procedure
        /// </summary>
        [FhirElement("outcome", InSummary = true, Order = 220)]
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
        [FhirElement("report", Order = 230)]
        [References("DiagnosticReport")]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ResourceReference> Report
        {
            get { if (_report == null) _report = new List<ResourceReference>(); return _report; }
            set { _report = value; OnPropertyChanged("Report"); }
        }

        private List<ResourceReference> _report;

        /// <summary>
        /// Complication following the procedure
        /// </summary>
        [FhirElement("complication", Order = 240)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> Complication
        {
            get { if (_complication == null) _complication = new List<CodeableConcept>(); return _complication; }
            set { _complication = value; OnPropertyChanged("Complication"); }
        }

        private List<CodeableConcept> _complication;

        /// <summary>
        /// Instructions for follow up
        /// </summary>
        [FhirElement("followUp", Order = 250)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<CodeableConcept> FollowUp
        {
            get { if (_followUp == null) _followUp = new List<CodeableConcept>(); return _followUp; }
            set { _followUp = value; OnPropertyChanged("FollowUp"); }
        }

        private List<CodeableConcept> _followUp;

        /// <summary>
        /// A request for this procedure
        /// </summary>
        [FhirElement("request", Order = 260)]
        [References("CarePlan", "DiagnosticOrder", "ProcedureRequest", "ReferralRequest")]
        [DataMember]
        public ResourceReference Request
        {
            get { return _request; }
            set { _request = value; OnPropertyChanged("Request"); }
        }

        private ResourceReference _request;

        /// <summary>
        /// Additional information about the procedure
        /// </summary>
        [FhirElement("notes", Order = 270)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<Annotation> Notes
        {
            get { if (_notes == null) _notes = new List<Annotation>(); return _notes; }
            set { _notes = value; OnPropertyChanged("Notes"); }
        }

        private List<Annotation> _notes;

        /// <summary>
        /// Device changed in procedure
        /// </summary>
        [FhirElement("focalDevice", Order = 280)]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<FocalDeviceComponent> FocalDevice
        {
            get { if (_focalDevice == null) _focalDevice = new List<FocalDeviceComponent>(); return _focalDevice; }
            set { _focalDevice = value; OnPropertyChanged("FocalDevice"); }
        }

        private List<FocalDeviceComponent> _focalDevice;

        /// <summary>
        /// Items used during procedure
        /// </summary>
        [FhirElement("used", Order = 290)]
        [References("Device", "Medication", "Substance")]
        [Cardinality(Min = 0, Max = -1)]
        [DataMember]
        public List<ResourceReference> Used
        {
            get { if (_used == null) _used = new List<ResourceReference>(); return _used; }
            set { _used = value; OnPropertyChanged("Used"); }
        }

        private List<ResourceReference> _used;


        public static ElementDefinition.ConstraintComponent Procedure_PRO_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "reasonNotPerformed.empty() or notPerformed = 'true'",
            Key = "pro-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Reason not performed is only permitted if notPerformed indicator is true",
            Xpath = "not(exists(f:reasonNotPerformed)) or f:notPerformed/@value=true()"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Procedure_PRO_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Procedure;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ProcedureStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (NotPerformedElement != null) dest.NotPerformedElement = (FhirBoolean)NotPerformedElement.DeepCopy();
                if (ReasonNotPerformed != null) dest.ReasonNotPerformed = new List<CodeableConcept>(ReasonNotPerformed.DeepCopy());
                if (BodySite != null) dest.BodySite = new List<CodeableConcept>(BodySite.DeepCopy());
                if (Reason != null) dest.Reason = (Element)Reason.DeepCopy();
                if (Performer != null) dest.Performer = new List<PerformerComponent>(Performer.DeepCopy());
                if (Performed != null) dest.Performed = (Element)Performed.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                if (Outcome != null) dest.Outcome = (CodeableConcept)Outcome.DeepCopy();
                if (Report != null) dest.Report = new List<ResourceReference>(Report.DeepCopy());
                if (Complication != null) dest.Complication = new List<CodeableConcept>(Complication.DeepCopy());
                if (FollowUp != null) dest.FollowUp = new List<CodeableConcept>(FollowUp.DeepCopy());
                if (Request != null) dest.Request = (ResourceReference)Request.DeepCopy();
                if (Notes != null) dest.Notes = new List<Annotation>(Notes.DeepCopy());
                if (FocalDevice != null) dest.FocalDevice = new List<FocalDeviceComponent>(FocalDevice.DeepCopy());
                if (Used != null) dest.Used = new List<ResourceReference>(Used.DeepCopy());
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
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(NotPerformedElement, otherT.NotPerformedElement)) return false;
            if (!DeepComparable.Matches(ReasonNotPerformed, otherT.ReasonNotPerformed)) return false;
            if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(Performed, otherT.Performed)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.Matches(Report, otherT.Report)) return false;
            if (!DeepComparable.Matches(Complication, otherT.Complication)) return false;
            if (!DeepComparable.Matches(FollowUp, otherT.FollowUp)) return false;
            if (!DeepComparable.Matches(Request, otherT.Request)) return false;
            if (!DeepComparable.Matches(Notes, otherT.Notes)) return false;
            if (!DeepComparable.Matches(FocalDevice, otherT.FocalDevice)) return false;
            if (!DeepComparable.Matches(Used, otherT.Used)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Procedure;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(NotPerformedElement, otherT.NotPerformedElement)) return false;
            if (!DeepComparable.IsExactly(ReasonNotPerformed, otherT.ReasonNotPerformed)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Performed, otherT.Performed)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;
            if (!DeepComparable.IsExactly(Report, otherT.Report)) return false;
            if (!DeepComparable.IsExactly(Complication, otherT.Complication)) return false;
            if (!DeepComparable.IsExactly(FollowUp, otherT.FollowUp)) return false;
            if (!DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if (!DeepComparable.IsExactly(Notes, otherT.Notes)) return false;
            if (!DeepComparable.IsExactly(FocalDevice, otherT.FocalDevice)) return false;
            if (!DeepComparable.IsExactly(Used, otherT.Used)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Subject != null) yield return Subject;
                if (StatusElement != null) yield return StatusElement;
                if (Category != null) yield return Category;
                if (Code != null) yield return Code;
                if (NotPerformedElement != null) yield return NotPerformedElement;
                foreach (var elem in ReasonNotPerformed) { if (elem != null) yield return elem; }
                foreach (var elem in BodySite) { if (elem != null) yield return elem; }
                if (Reason != null) yield return Reason;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                if (Performed != null) yield return Performed;
                if (Encounter != null) yield return Encounter;
                if (Location != null) yield return Location;
                if (Outcome != null) yield return Outcome;
                foreach (var elem in Report) { if (elem != null) yield return elem; }
                foreach (var elem in Complication) { if (elem != null) yield return elem; }
                foreach (var elem in FollowUp) { if (elem != null) yield return elem; }
                if (Request != null) yield return Request;
                foreach (var elem in Notes) { if (elem != null) yield return elem; }
                foreach (var elem in FocalDevice) { if (elem != null) yield return elem; }
                foreach (var elem in Used) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Category != null) yield return new ElementValue("category", Category);
                if (Code != null) yield return new ElementValue("code", Code);
                if (NotPerformedElement != null) yield return new ElementValue("notPerformed", NotPerformedElement);
                foreach (var elem in ReasonNotPerformed) { if (elem != null) yield return new ElementValue("reasonNotPerformed", elem); }
                foreach (var elem in BodySite) { if (elem != null) yield return new ElementValue("bodySite", elem); }
                if (Reason != null) yield return new ElementValue("reason", Reason);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                if (Performed != null) yield return new ElementValue("performed", Performed);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Location != null) yield return new ElementValue("location", Location);
                if (Outcome != null) yield return new ElementValue("outcome", Outcome);
                foreach (var elem in Report) { if (elem != null) yield return new ElementValue("report", elem); }
                foreach (var elem in Complication) { if (elem != null) yield return new ElementValue("complication", elem); }
                foreach (var elem in FollowUp) { if (elem != null) yield return new ElementValue("followUp", elem); }
                if (Request != null) yield return new ElementValue("request", Request);
                foreach (var elem in Notes) { if (elem != null) yield return new ElementValue("notes", elem); }
                foreach (var elem in FocalDevice) { if (elem != null) yield return new ElementValue("focalDevice", elem); }
                foreach (var elem in Used) { if (elem != null) yield return new ElementValue("used", elem); }
            }
        }

    }

}
