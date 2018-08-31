using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.DSTU2;
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
    /// Healthcare plan for patient or group
    /// </summary>
    [FhirType("CarePlan", IsResource=true)]
    [DataContract]
    public partial class CarePlan : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.CarePlan; } }
        [NotMapped]
        public override string TypeName { get { return "CarePlan"; } }

        /// <summary>
        /// Indicates whether the plan is currently being acted upon, represents future intentions or is now a historical record.
        /// (url: http://hl7.org/fhir/ValueSet/care-plan-status)
        /// </summary>
        [FhirEnumeration("CarePlanStatus")]
        public enum CarePlanStatus
        {
            /// <summary>
            /// The plan has been suggested but no commitment to it has yet been made.
            /// (system: http://hl7.org/fhir/care-plan-status)
            /// </summary>
            [EnumLiteral("proposed", "http://hl7.org/fhir/care-plan-status"), Description("Proposed")]
            Proposed,
            /// <summary>
            /// The plan is in development or awaiting use but is not yet intended to be acted upon.
            /// (system: http://hl7.org/fhir/care-plan-status)
            /// </summary>
            [EnumLiteral("draft", "http://hl7.org/fhir/care-plan-status"), Description("Pending")]
            Draft,
            /// <summary>
            /// The plan is intended to be followed and used as part of patient care.
            /// (system: http://hl7.org/fhir/care-plan-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/care-plan-status"), Description("Active")]
            Active,
            /// <summary>
            /// The plan is no longer in use and is not expected to be followed or used in patient care.
            /// (system: http://hl7.org/fhir/care-plan-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/care-plan-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The plan has been terminated prior to reaching completion (though it may have been replaced by a new plan).
            /// (system: http://hl7.org/fhir/care-plan-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/care-plan-status"), Description("Cancelled")]
            Cancelled,
        }

        /// <summary>
        /// Codes identifying the types of relationships between two plans.
        /// (url: http://hl7.org/fhir/ValueSet/care-plan-relationship)
        /// </summary>
        [FhirEnumeration("CarePlanRelationship")]
        public enum CarePlanRelationship
        {
            /// <summary>
            /// The referenced plan is considered to be part of this plan.
            /// (system: http://hl7.org/fhir/care-plan-relationship)
            /// </summary>
            [EnumLiteral("includes", "http://hl7.org/fhir/care-plan-relationship"), Description("Includes")]
            Includes,
            /// <summary>
            /// This plan takes the places of the referenced plan.
            /// (system: http://hl7.org/fhir/care-plan-relationship)
            /// </summary>
            [EnumLiteral("replaces", "http://hl7.org/fhir/care-plan-relationship"), Description("Replaces")]
            Replaces,
            /// <summary>
            /// This plan provides details about how to perform activities defined at a higher level by the referenced plan.
            /// (system: http://hl7.org/fhir/care-plan-relationship)
            /// </summary>
            [EnumLiteral("fulfills", "http://hl7.org/fhir/care-plan-relationship"), Description("Fulfills")]
            Fulfills,
        }

        /// <summary>
        /// Indicates where the activity is at in its overall life cycle.
        /// (url: http://hl7.org/fhir/ValueSet/care-plan-activity-status)
        /// </summary>
        [FhirEnumeration("CarePlanActivityStatus")]
        public enum CarePlanActivityStatus
        {
            /// <summary>
            /// Activity is planned but no action has yet been taken.
            /// (system: http://hl7.org/fhir/care-plan-activity-status)
            /// </summary>
            [EnumLiteral("not-started", "http://hl7.org/fhir/care-plan-activity-status"), Description("Not Started")]
            NotStarted,
            /// <summary>
            /// Appointment or other booking has occurred but activity has not yet begun.
            /// (system: http://hl7.org/fhir/care-plan-activity-status)
            /// </summary>
            [EnumLiteral("scheduled", "http://hl7.org/fhir/care-plan-activity-status"), Description("Scheduled")]
            Scheduled,
            /// <summary>
            /// Activity has been started but is not yet complete.
            /// (system: http://hl7.org/fhir/care-plan-activity-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/care-plan-activity-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// Activity was started but has temporarily ceased with an expectation of resumption at a future time.
            /// (system: http://hl7.org/fhir/care-plan-activity-status)
            /// </summary>
            [EnumLiteral("on-hold", "http://hl7.org/fhir/care-plan-activity-status"), Description("On Hold")]
            OnHold,
            /// <summary>
            /// The activities have been completed (more or less) as planned.
            /// (system: http://hl7.org/fhir/care-plan-activity-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/care-plan-activity-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// The activities have been ended prior to completion (perhaps even before they were started).
            /// (system: http://hl7.org/fhir/care-plan-activity-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/care-plan-activity-status"), Description("Cancelled")]
            Cancelled,
        }


        [FhirType("RelatedPlanComponent")]
        [DataContract]
        public partial class RelatedPlanComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedPlanComponent"; } }

            /// <summary>
            /// includes | replaces | fulfills
            /// </summary>
            [FhirElement("code", Order=40)]
            [DataMember]
            public Code<CarePlanRelationship> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<CarePlanRelationship> _codeElement;

            /// <summary>
            /// includes | replaces | fulfills
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public CarePlanRelationship? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<CarePlanRelationship>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Plan relationship exists with
            /// </summary>
            [FhirElement("plan", Order=50)]
            [References("CarePlan")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Plan
            {
                get { return _plan; }
                set { _plan = value; OnPropertyChanged("Plan"); }
            }

            private ResourceReference _plan;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatedPlanComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code<CarePlanRelationship>)CodeElement.DeepCopy();
                    if (Plan != null) dest.Plan = (ResourceReference)Plan.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelatedPlanComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatedPlanComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(Plan, otherT.Plan)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedPlanComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(Plan, otherT.Plan)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (Plan != null) yield return Plan;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (Plan != null) yield return new ElementValue("plan", Plan);
                }
            }


        }


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// Type of involvement
            /// </summary>
            [FhirElement("role", Order=40)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            /// <summary>
            /// Who is involved
            /// </summary>
            [FhirElement("member", Order=50)]
            [References("Practitioner","RelatedPerson","Patient","Organization")]
            [DataMember]
            public ResourceReference Member
            {
                get { return _member; }
                set { _member = value; OnPropertyChanged("Member"); }
            }

            private ResourceReference _member;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    if (Member != null) dest.Member = (ResourceReference)Member.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParticipantComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(Member, otherT.Member)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(Member, otherT.Member)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Member != null) yield return Member;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Member != null) yield return new ElementValue("member", Member);
                }
            }


        }


        [FhirType("ActivityComponent")]
        [DataContract]
        public partial class ActivityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActivityComponent"; } }

            /// <summary>
            /// Appointments, orders, etc.
            /// </summary>
            [FhirElement("actionResulting", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> ActionResulting
            {
                get { if (_actionResulting==null) _actionResulting = new List<ResourceReference>(); return _actionResulting; }
                set { _actionResulting = value; OnPropertyChanged("ActionResulting"); }
            }

            private List<ResourceReference> _actionResulting;

            /// <summary>
            /// Comments about the activity status/progress
            /// </summary>
            [FhirElement("progress", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Annotation> Progress
            {
                get { if (_progress==null) _progress = new List<Annotation>(); return _progress; }
                set { _progress = value; OnPropertyChanged("Progress"); }
            }

            private List<Annotation> _progress;

            /// <summary>
            /// Activity details defined in specific resource
            /// </summary>
            [FhirElement("reference", Order=60)]
            [References("Appointment","CommunicationRequest","DeviceUseRequest","DiagnosticOrder","MedicationOrder","NutritionOrder","Order","ProcedureRequest","ProcessRequest","ReferralRequest","SupplyRequest","VisionPrescription")]
            [DataMember]
            public ResourceReference Reference
            {
                get { return _reference; }
                set { _reference = value; OnPropertyChanged("Reference"); }
            }

            private ResourceReference _reference;

            /// <summary>
            /// In-line definition of activity
            /// </summary>
            [FhirElement("detail", Order=70)]
            [DataMember]
            public DetailComponent Detail
            {
                get { return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private DetailComponent _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ActivityComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ActionResulting != null) dest.ActionResulting = new List<ResourceReference>(ActionResulting.DeepCopy());
                    if (Progress != null) dest.Progress = new List<Annotation>(Progress.DeepCopy());
                    if (Reference != null) dest.Reference = (ResourceReference)Reference.DeepCopy();
                    if (Detail != null) dest.Detail = (DetailComponent)Detail.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ActivityComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ActivityComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(ActionResulting, otherT.ActionResulting)) return false;
                if ( !DeepComparable.Matches(Progress, otherT.Progress)) return false;
                if (!DeepComparable.Matches(Reference, otherT.Reference)) return false;
                if (!DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ActivityComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ActionResulting, otherT.ActionResulting)) return false;
                if (!DeepComparable.IsExactly(Progress, otherT.Progress)) return false;
                if (!DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in ActionResulting) { if (elem != null) yield return elem; }
                    foreach (var elem in Progress) { if (elem != null) yield return elem; }
                    if (Reference != null) yield return Reference;
                    if (Detail != null) yield return Detail;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in ActionResulting) { if (elem != null) yield return new ElementValue("actionResulting", elem); }
                    foreach (var elem in Progress) { if (elem != null) yield return new ElementValue("progress", elem); }
                    if (Reference != null) yield return new ElementValue("reference", Reference);
                    if (Detail != null) yield return new ElementValue("detail", Detail);
                }
            }


        }


        [FhirType("DetailComponent")]
        [DataContract]
        public partial class DetailComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DetailComponent"; } }

            /// <summary>
            /// diet | drug | encounter | observation | procedure | supply | other
            /// </summary>
            [FhirElement("category", Order=40)]
            [DataMember]
            public CodeableConcept Category
            {
                get { return _category; }
                set { _category = value; OnPropertyChanged("Category"); }
            }

            private CodeableConcept _category;

            /// <summary>
            /// Detail type of activity
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Why activity should be done
            /// </summary>
            [FhirElement("reasonCode", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> ReasonCode
            {
                get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
                set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
            }

            private List<CodeableConcept> _reasonCode;

            /// <summary>
            /// Condition triggering need for activity
            /// </summary>
            [FhirElement("reasonReference", Order=70)]
            [References("Condition")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> ReasonReference
            {
                get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
                set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
            }

            private List<ResourceReference> _reasonReference;

            /// <summary>
            /// Goals this activity relates to
            /// </summary>
            [FhirElement("goal", Order=80)]
            [References("Goal")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Goal
            {
                get { if (_goal==null) _goal = new List<ResourceReference>(); return _goal; }
                set { _goal = value; OnPropertyChanged("Goal"); }
            }

            private List<ResourceReference> _goal;

            /// <summary>
            /// not-started | scheduled | in-progress | on-hold | completed | cancelled
            /// </summary>
            [FhirElement("status", Order=90)]
            [DataMember]
            public Code<CarePlanActivityStatus> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<CarePlanActivityStatus> _statusElement;

            /// <summary>
            /// not-started | scheduled | in-progress | on-hold | completed | cancelled
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public CarePlanActivityStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (value == null)
                        StatusElement = null;
                    else
                        StatusElement = new Code<CarePlanActivityStatus>(value);
                    OnPropertyChanged("Status");
                }
            }

            /// <summary>
            /// Reason for current status
            /// </summary>
            [FhirElement("statusReason", Order=100)]
            [DataMember]
            public CodeableConcept StatusReason
            {
                get { return _statusReason; }
                set { _statusReason = value; OnPropertyChanged("StatusReason"); }
            }

            private CodeableConcept _statusReason;

            /// <summary>
            /// Do NOT do
            /// </summary>
            [FhirElement("prohibited", Order=110)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean ProhibitedElement
            {
                get { return _prohibitedElement; }
                set { _prohibitedElement = value; OnPropertyChanged("ProhibitedElement"); }
            }

            private FhirBoolean _prohibitedElement;

            /// <summary>
            /// Do NOT do
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Prohibited
            {
                get { return ProhibitedElement != null ? ProhibitedElement.Value : null; }
                set
                {
                    if (value == null)
                        ProhibitedElement = null;
                    else
                        ProhibitedElement = new FhirBoolean(value);
                    OnPropertyChanged("Prohibited");
                }
            }

            /// <summary>
            /// When activity is to occur
            /// </summary>
            [FhirElement("scheduled", Order=120, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Timing),typeof(Period),typeof(FhirString))]
            [DataMember]
            public Element Scheduled
            {
                get { return _scheduled; }
                set { _scheduled = value; OnPropertyChanged("Scheduled"); }
            }

            private Element _scheduled;

            /// <summary>
            /// Where it should happen
            /// </summary>
            [FhirElement("location", Order=130)]
            [References("Location")]
            [DataMember]
            public ResourceReference Location
            {
                get { return _location; }
                set { _location = value; OnPropertyChanged("Location"); }
            }

            private ResourceReference _location;

            /// <summary>
            /// Who will be responsible?
            /// </summary>
            [FhirElement("performer", Order=140)]
            [References("Practitioner","Organization","RelatedPerson","Patient")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Performer
            {
                get { if (_performer==null) _performer = new List<ResourceReference>(); return _performer; }
                set { _performer = value; OnPropertyChanged("Performer"); }
            }

            private List<ResourceReference> _performer;

            /// <summary>
            /// What is to be administered/supplied
            /// </summary>
            [FhirElement("product", Order=150, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
            [DataMember]
            public Element Product
            {
                get { return _product; }
                set { _product = value; OnPropertyChanged("Product"); }
            }

            private Element _product;

            /// <summary>
            /// How to consume/day?
            /// </summary>
            [FhirElement("dailyAmount", Order=160)]
            [DataMember]
            public SimpleQuantity DailyAmount
            {
                get { return _dailyAmount; }
                set { _dailyAmount = value; OnPropertyChanged("DailyAmount"); }
            }

            private SimpleQuantity _dailyAmount;

            /// <summary>
            /// How much to administer/supply/consume
            /// </summary>
            [FhirElement("quantity", Order=170)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Extra info describing activity to perform
            /// </summary>
            [FhirElement("description", Order=180)]
            [DataMember]
            public FhirString DescriptionElement
            {
                get { return _descriptionElement; }
                set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }

            private FhirString _descriptionElement;

            /// <summary>
            /// Extra info describing activity to perform
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DetailComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                    if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                    if (Goal != null) dest.Goal = new List<ResourceReference>(Goal.DeepCopy());
                    if (StatusElement != null) dest.StatusElement = (Code<CarePlanActivityStatus>)StatusElement.DeepCopy();
                    if (StatusReason != null) dest.StatusReason = (CodeableConcept)StatusReason.DeepCopy();
                    if (ProhibitedElement != null) dest.ProhibitedElement = (FhirBoolean)ProhibitedElement.DeepCopy();
                    if (Scheduled != null) dest.Scheduled = (Element)Scheduled.DeepCopy();
                    if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                    if (Performer != null) dest.Performer = new List<ResourceReference>(Performer.DeepCopy());
                    if (Product != null) dest.Product = (Element)Product.DeepCopy();
                    if (DailyAmount != null) dest.DailyAmount = (SimpleQuantity)DailyAmount.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DetailComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DetailComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Category, otherT.Category)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
                if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
                if ( !DeepComparable.Matches(Goal, otherT.Goal)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
                if (!DeepComparable.Matches(ProhibitedElement, otherT.ProhibitedElement)) return false;
                if (!DeepComparable.Matches(Scheduled, otherT.Scheduled)) return false;
                if (!DeepComparable.Matches(Location, otherT.Location)) return false;
                if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
                if (!DeepComparable.Matches(Product, otherT.Product)) return false;
                if (!DeepComparable.Matches(DailyAmount, otherT.DailyAmount)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DetailComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
                if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
                if (!DeepComparable.IsExactly(Goal, otherT.Goal)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
                if (!DeepComparable.IsExactly(ProhibitedElement, otherT.ProhibitedElement)) return false;
                if (!DeepComparable.IsExactly(Scheduled, otherT.Scheduled)) return false;
                if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
                if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
                if (!DeepComparable.IsExactly(Product, otherT.Product)) return false;
                if (!DeepComparable.IsExactly(DailyAmount, otherT.DailyAmount)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Category != null) yield return Category;
                    if (Code != null) yield return Code;
                    foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                    foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                    foreach (var elem in Goal) { if (elem != null) yield return elem; }
                    if (StatusElement != null) yield return StatusElement;
                    if (StatusReason != null) yield return StatusReason;
                    if (ProhibitedElement != null) yield return ProhibitedElement;
                    if (Scheduled != null) yield return Scheduled;
                    if (Location != null) yield return Location;
                    foreach (var elem in Performer) { if (elem != null) yield return elem; }
                    if (Product != null) yield return Product;
                    if (DailyAmount != null) yield return DailyAmount;
                    if (Quantity != null) yield return Quantity;
                    if (DescriptionElement != null) yield return DescriptionElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Category != null) yield return new ElementValue("category", Category);
                    if (Code != null) yield return new ElementValue("code", Code);
                    foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                    foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                    foreach (var elem in Goal) { if (elem != null) yield return new ElementValue("goal", elem); }
                    if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                    if (StatusReason != null) yield return new ElementValue("statusReason", StatusReason);
                    if (ProhibitedElement != null) yield return new ElementValue("prohibited", ProhibitedElement);
                    if (Scheduled != null) yield return new ElementValue("scheduled", Scheduled);
                    if (Location != null) yield return new ElementValue("location", Location);
                    foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                    if (Product != null) yield return new ElementValue("product", Product);
                    if (DailyAmount != null) yield return new ElementValue("dailyAmount", DailyAmount);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                }
            }


        }


        /// <summary>
        /// External Ids for this plan
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
        /// Who care plan is for
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=100)]
        [References("Patient","Group")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// proposed | draft | active | completed | cancelled
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<CarePlanStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<CarePlanStatus> _statusElement;

        /// <summary>
        /// proposed | draft | active | completed | cancelled
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CarePlanStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<CarePlanStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Created in context of
        /// </summary>
        [FhirElement("context", InSummary=true, Order=120)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// Time period plan covers
        /// </summary>
        [FhirElement("period", InSummary=true, Order=130)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Who is responsible for contents of the plan
        /// </summary>
        [FhirElement("author", InSummary=true, Order=140)]
        [References("Patient","Practitioner","RelatedPerson","Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Author
        {
            get { if (_author==null) _author = new List<ResourceReference>(); return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private List<ResourceReference> _author;

        /// <summary>
        /// When last updated
        /// </summary>
        [FhirElement("modified", InSummary=true, Order=150)]
        [DataMember]
        public FhirDateTime ModifiedElement
        {
            get { return _modifiedElement; }
            set { _modifiedElement = value; OnPropertyChanged("ModifiedElement"); }
        }

        private FhirDateTime _modifiedElement;

        /// <summary>
        /// When last updated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Modified
        {
            get { return ModifiedElement != null ? ModifiedElement.Value : null; }
            set
            {
                if (value == null)
                    ModifiedElement = null;
                else
                    ModifiedElement = new FhirDateTime(value);
                OnPropertyChanged("Modified");
            }
        }

        /// <summary>
        /// Type of plan
        /// </summary>
        [FhirElement("category", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// Summary of nature of plan
        /// </summary>
        [FhirElement("description", InSummary=true, Order=170)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Summary of nature of plan
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
        /// Health issues this plan addresses
        /// </summary>
        [FhirElement("addresses", InSummary=true, Order=180)]
        [References("Condition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Addresses
        {
            get { if (_addresses==null) _addresses = new List<ResourceReference>(); return _addresses; }
            set { _addresses = value; OnPropertyChanged("Addresses"); }
        }

        private List<ResourceReference> _addresses;

        /// <summary>
        /// Information considered as part of plan
        /// </summary>
        [FhirElement("support", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Support
        {
            get { if (_support==null) _support = new List<ResourceReference>(); return _support; }
            set { _support = value; OnPropertyChanged("Support"); }
        }

        private List<ResourceReference> _support;

        /// <summary>
        /// Plans related to this one
        /// </summary>
        [FhirElement("relatedPlan", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedPlanComponent> RelatedPlan
        {
            get { if (_relatedPlan==null) _relatedPlan = new List<RelatedPlanComponent>(); return _relatedPlan; }
            set { _relatedPlan = value; OnPropertyChanged("RelatedPlan"); }
        }

        private List<RelatedPlanComponent> _relatedPlan;

        /// <summary>
        /// Who's involved in plan?
        /// </summary>
        [FhirElement("participant", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if (_participant==null) _participant = new List<ParticipantComponent>(); return _participant; }
            set { _participant = value; OnPropertyChanged("Participant"); }
        }

        private List<ParticipantComponent> _participant;

        /// <summary>
        /// Desired outcome of plan
        /// </summary>
        [FhirElement("goal", Order=220)]
        [References("Goal")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Goal
        {
            get { if (_goal==null) _goal = new List<ResourceReference>(); return _goal; }
            set { _goal = value; OnPropertyChanged("Goal"); }
        }

        private List<ResourceReference> _goal;

        /// <summary>
        /// Action to occur as part of plan
        /// </summary>
        [FhirElement("activity", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ActivityComponent> Activity
        {
            get { if (_activity==null) _activity = new List<ActivityComponent>(); return _activity; }
            set { _activity = value; OnPropertyChanged("Activity"); }
        }

        private List<ActivityComponent> _activity;

        /// <summary>
        /// Comments about the plan
        /// </summary>
        [FhirElement("note", Order=240)]
        [DataMember]
        public Annotation Note
        {
            get { return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private Annotation _note;


        public static ElementDefinition.ConstraintComponent CarePlan_CPL_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "activity.all(detail.empty() or reference.empty())",
            Key = "cpl-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Provide a reference or detail, not both",
            Xpath = "not(exists(f:detail)) or not(exists(f:reference))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(CarePlan_CPL_3);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as CarePlan;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<CarePlanStatus>)StatusElement.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Author != null) dest.Author = new List<ResourceReference>(Author.DeepCopy());
                if (ModifiedElement != null) dest.ModifiedElement = (FhirDateTime)ModifiedElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Addresses != null) dest.Addresses = new List<ResourceReference>(Addresses.DeepCopy());
                if (Support != null) dest.Support = new List<ResourceReference>(Support.DeepCopy());
                if (RelatedPlan != null) dest.RelatedPlan = new List<RelatedPlanComponent>(RelatedPlan.DeepCopy());
                if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                if (Goal != null) dest.Goal = new List<ResourceReference>(Goal.DeepCopy());
                if (Activity != null) dest.Activity = new List<ActivityComponent>(Activity.DeepCopy());
                if (Note != null) dest.Note = (Annotation)Note.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new CarePlan());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as CarePlan;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if ( !DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(ModifiedElement, otherT.ModifiedElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(Addresses, otherT.Addresses)) return false;
            if ( !DeepComparable.Matches(Support, otherT.Support)) return false;
            if ( !DeepComparable.Matches(RelatedPlan, otherT.RelatedPlan)) return false;
            if ( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if ( !DeepComparable.Matches(Goal, otherT.Goal)) return false;
            if ( !DeepComparable.Matches(Activity, otherT.Activity)) return false;
            if (!DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as CarePlan;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(ModifiedElement, otherT.ModifiedElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Addresses, otherT.Addresses)) return false;
            if (!DeepComparable.IsExactly(Support, otherT.Support)) return false;
            if (!DeepComparable.IsExactly(RelatedPlan, otherT.RelatedPlan)) return false;
            if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if (!DeepComparable.IsExactly(Goal, otherT.Goal)) return false;
            if (!DeepComparable.IsExactly(Activity, otherT.Activity)) return false;
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
                if (Subject != null) yield return Subject;
                if (StatusElement != null) yield return StatusElement;
                if (Context != null) yield return Context;
                if (Period != null) yield return Period;
                foreach (var elem in Author) { if (elem != null) yield return elem; }
                if (ModifiedElement != null) yield return ModifiedElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in Addresses) { if (elem != null) yield return elem; }
                foreach (var elem in Support) { if (elem != null) yield return elem; }
                foreach (var elem in RelatedPlan) { if (elem != null) yield return elem; }
                foreach (var elem in Participant) { if (elem != null) yield return elem; }
                foreach (var elem in Goal) { if (elem != null) yield return elem; }
                foreach (var elem in Activity) { if (elem != null) yield return elem; }
                if (Note != null) yield return Note;
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
                if (Context != null) yield return new ElementValue("context", Context);
                if (Period != null) yield return new ElementValue("period", Period);
                foreach (var elem in Author) { if (elem != null) yield return new ElementValue("author", elem); }
                if (ModifiedElement != null) yield return new ElementValue("modified", ModifiedElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in Addresses) { if (elem != null) yield return new ElementValue("addresses", elem); }
                foreach (var elem in Support) { if (elem != null) yield return new ElementValue("support", elem); }
                foreach (var elem in RelatedPlan) { if (elem != null) yield return new ElementValue("relatedPlan", elem); }
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
                foreach (var elem in Goal) { if (elem != null) yield return new ElementValue("goal", elem); }
                foreach (var elem in Activity) { if (elem != null) yield return new ElementValue("activity", elem); }
                if (Note != null) yield return new ElementValue("note", Note);
            }
        }

    }

}
