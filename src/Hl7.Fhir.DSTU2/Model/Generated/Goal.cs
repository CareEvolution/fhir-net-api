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
    /// Describes the intended objective(s) for a patient, group or organization
    /// </summary>
    [FhirType("Goal", IsResource=true)]
    [DataContract]
    public partial class Goal : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Goal; } }
        [NotMapped]
        public override string TypeName { get { return "Goal"; } }

        /// <summary>
        /// Indicates whether the goal has been met and is still being targeted
        /// (url: http://hl7.org/fhir/ValueSet/goal-status)
        /// </summary>
        [FhirEnumeration("GoalStatus")]
        public enum GoalStatus
        {
            /// <summary>
            /// A goal is proposed for this patient
            /// (system: http://hl7.org/fhir/goal-status)
            /// </summary>
            [EnumLiteral("proposed", "http://hl7.org/fhir/goal-status"), Description("Proposed")]
            Proposed,
            /// <summary>
            /// A goal is planned for this patient
            /// (system: http://hl7.org/fhir/goal-status)
            /// </summary>
            [EnumLiteral("planned", "http://hl7.org/fhir/goal-status"), Description("Planned")]
            Planned,
            /// <summary>
            /// A proposed goal was accepted
            /// (system: http://hl7.org/fhir/goal-status)
            /// </summary>
            [EnumLiteral("accepted", "http://hl7.org/fhir/goal-status"), Description("Accepted")]
            Accepted,
            /// <summary>
            /// A proposed goal was rejected
            /// (system: http://hl7.org/fhir/goal-status)
            /// </summary>
            [EnumLiteral("rejected", "http://hl7.org/fhir/goal-status"), Description("Rejected")]
            Rejected,
            /// <summary>
            /// The goal is being sought but has not yet been reached.  (Also applies if goal was reached in the past but there has been regression and goal is being sought again)
            /// (system: http://hl7.org/fhir/goal-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/goal-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// The goal has been met and no further action is needed
            /// (system: http://hl7.org/fhir/goal-status)
            /// </summary>
            [EnumLiteral("achieved", "http://hl7.org/fhir/goal-status"), Description("Achieved")]
            Achieved,
            /// <summary>
            /// The goal has been met, but ongoing activity is needed to sustain the goal objective
            /// (system: http://hl7.org/fhir/goal-status)
            /// </summary>
            [EnumLiteral("sustaining", "http://hl7.org/fhir/goal-status"), Description("Sustaining")]
            Sustaining,
            /// <summary>
            /// The goal remains a long term objective but is no longer being actively pursued for a temporary period of time.
            /// (system: http://hl7.org/fhir/goal-status)
            /// </summary>
            [EnumLiteral("on-hold", "http://hl7.org/fhir/goal-status"), Description("On Hold")]
            OnHold,
            /// <summary>
            /// The goal is no longer being sought
            /// (system: http://hl7.org/fhir/goal-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/goal-status"), Description("Cancelled")]
            Cancelled,
        }


        [FhirType("OutcomeComponent")]
        [DataContract]
        public partial class OutcomeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OutcomeComponent"; } }

            /// <summary>
            /// Code or observation that resulted from goal
            /// </summary>
            [FhirElement("result", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Result
            {
                get { return _result; }
                set { _result = value; OnPropertyChanged("Result"); }
            }

            private Element _result;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OutcomeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Result != null) dest.Result = (Element)Result.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OutcomeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OutcomeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Result, otherT.Result)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OutcomeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Result, otherT.Result)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Result != null) yield return Result;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Result != null) yield return new ElementValue("result", Result);
                }
            }


        }


        /// <summary>
        /// External Ids for this goal
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
        /// Who this goal is intended for
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=100)]
        [References("Patient","Group","Organization")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// When goal pursuit begins
        /// </summary>
        [FhirElement("start", InSummary=true, Order=110, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Date),typeof(CodeableConcept))]
        [DataMember]
        public Element Start
        {
            get { return _start; }
            set { _start = value; OnPropertyChanged("Start"); }
        }

        private Element _start;

        /// <summary>
        /// Reach goal on or before
        /// </summary>
        [FhirElement("target", InSummary=true, Order=120, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Date),typeof(Duration))]
        [DataMember]
        public Element Target
        {
            get { return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private Element _target;

        /// <summary>
        /// E.g. Treatment, dietary, behavioral, etc.
        /// </summary>
        [FhirElement("category", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// What's the desired outcome?
        /// </summary>
        [FhirElement("description", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// What's the desired outcome?
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new FhirString(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// proposed | planned | accepted | rejected | in-progress | achieved | sustaining | on-hold | cancelled
        /// </summary>
        [FhirElement("status", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<GoalStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<GoalStatus> _statusElement;

        /// <summary>
        /// proposed | planned | accepted | rejected | in-progress | achieved | sustaining | on-hold | cancelled
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public GoalStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<GoalStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// When goal status took effect
        /// </summary>
        [FhirElement("statusDate", InSummary=true, Order=160)]
        [DataMember]
        public Date StatusDateElement
        {
            get { return _statusDateElement; }
            set { _statusDateElement = value; OnPropertyChanged("StatusDateElement"); }
        }

        private Date _statusDateElement;

        /// <summary>
        /// When goal status took effect
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string StatusDate
        {
            get { return StatusDateElement != null ? StatusDateElement.Value : null; }
            set
            {
                if (value == null)
                    StatusDateElement = null;
                else
                    StatusDateElement = new Date(value);
                OnPropertyChanged("StatusDate");
            }
        }

        /// <summary>
        /// Reason for current status
        /// </summary>
        [FhirElement("statusReason", Order=170)]
        [DataMember]
        public CodeableConcept StatusReason
        {
            get { return _statusReason; }
            set { _statusReason = value; OnPropertyChanged("StatusReason"); }
        }

        private CodeableConcept _statusReason;

        /// <summary>
        /// Who's responsible for creating Goal?
        /// </summary>
        [FhirElement("author", InSummary=true, Order=180)]
        [References("Patient","Practitioner","RelatedPerson")]
        [DataMember]
        public ResourceReference Author
        {
            get { return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private ResourceReference _author;

        /// <summary>
        /// high | medium |low
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=190)]
        [DataMember]
        public CodeableConcept Priority
        {
            get { return _priority; }
            set { _priority = value; OnPropertyChanged("Priority"); }
        }

        private CodeableConcept _priority;

        /// <summary>
        /// Issues addressed by this goal
        /// </summary>
        [FhirElement("addresses", Order=200)]
        [References("Condition","Observation","MedicationStatement","NutritionOrder","ProcedureRequest","RiskAssessment")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Addresses
        {
            get { if (_addresses==null) _addresses = new List<ResourceReference>(); return _addresses; }
            set { _addresses = value; OnPropertyChanged("Addresses"); }
        }

        private List<ResourceReference> _addresses;

        /// <summary>
        /// Comments about the goal
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

        /// <summary>
        /// What was end result of goal?
        /// </summary>
        [FhirElement("outcome", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<OutcomeComponent> Outcome
        {
            get { if (_outcome==null) _outcome = new List<OutcomeComponent>(); return _outcome; }
            set { _outcome = value; OnPropertyChanged("Outcome"); }
        }

        private List<OutcomeComponent> _outcome;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Goal;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Start != null) dest.Start = (Element)Start.DeepCopy();
                if (Target != null) dest.Target = (Element)Target.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<GoalStatus>)StatusElement.DeepCopy();
                if (StatusDateElement != null) dest.StatusDateElement = (Date)StatusDateElement.DeepCopy();
                if (StatusReason != null) dest.StatusReason = (CodeableConcept)StatusReason.DeepCopy();
                if (Author != null) dest.Author = (ResourceReference)Author.DeepCopy();
                if (Priority != null) dest.Priority = (CodeableConcept)Priority.DeepCopy();
                if (Addresses != null) dest.Addresses = new List<ResourceReference>(Addresses.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Outcome != null) dest.Outcome = new List<OutcomeComponent>(Outcome.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Goal());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Goal;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Start, otherT.Start)) return false;
            if (!DeepComparable.Matches(Target, otherT.Target)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
            if (!DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if ( !DeepComparable.Matches(Addresses, otherT.Addresses)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Outcome, otherT.Outcome)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Goal;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Start, otherT.Start)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
            if (!DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if (!DeepComparable.IsExactly(Addresses, otherT.Addresses)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;

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
                if (Start != null) yield return Start;
                if (Target != null) yield return Target;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                if (StatusElement != null) yield return StatusElement;
                if (StatusDateElement != null) yield return StatusDateElement;
                if (StatusReason != null) yield return StatusReason;
                if (Author != null) yield return Author;
                if (Priority != null) yield return Priority;
                foreach (var elem in Addresses) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Outcome) { if (elem != null) yield return elem; }
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
                if (Start != null) yield return new ElementValue("start", Start);
                if (Target != null) yield return new ElementValue("target", Target);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (StatusDateElement != null) yield return new ElementValue("statusDate", StatusDateElement);
                if (StatusReason != null) yield return new ElementValue("statusReason", StatusReason);
                if (Author != null) yield return new ElementValue("author", Author);
                if (Priority != null) yield return new ElementValue("priority", Priority);
                foreach (var elem in Addresses) { if (elem != null) yield return new ElementValue("addresses", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in Outcome) { if (elem != null) yield return new ElementValue("outcome", elem); }
            }
        }

    }

}
