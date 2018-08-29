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


        [FhirType("ActivityComponent")]
        [DataContract]
        public partial class ActivityComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ActivityComponent"; } }

            /// <summary>
            /// Results of the activity
            /// </summary>
            [FhirElement("outcomeCodeableConcept", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> OutcomeCodeableConcept
            {
                get { if (_outcomeCodeableConcept==null) _outcomeCodeableConcept = new List<CodeableConcept>(); return _outcomeCodeableConcept; }
                set { _outcomeCodeableConcept = value; OnPropertyChanged("OutcomeCodeableConcept"); }
            }

            private List<CodeableConcept> _outcomeCodeableConcept;

            /// <summary>
            /// Appointment, Encounter, Procedure, etc.
            /// </summary>
            [FhirElement("outcomeReference", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> OutcomeReference
            {
                get { if (_outcomeReference==null) _outcomeReference = new List<ResourceReference>(); return _outcomeReference; }
                set { _outcomeReference = value; OnPropertyChanged("OutcomeReference"); }
            }

            private List<ResourceReference> _outcomeReference;

            /// <summary>
            /// Comments about the activity status/progress
            /// </summary>
            [FhirElement("progress", Order=60)]
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
            [FhirElement("reference", Order=70)]
            [References("Appointment","CommunicationRequest","DeviceRequest","MedicationRequest","NutritionOrder","Task","ProcedureRequest","ReferralRequest","VisionPrescription","RequestGroup")]
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
            [FhirElement("detail", Order=80)]
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
                    if (OutcomeCodeableConcept != null) dest.OutcomeCodeableConcept = new List<CodeableConcept>(OutcomeCodeableConcept.DeepCopy());
                    if (OutcomeReference != null) dest.OutcomeReference = new List<ResourceReference>(OutcomeReference.DeepCopy());
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
                if ( !DeepComparable.Matches(OutcomeCodeableConcept, otherT.OutcomeCodeableConcept)) return false;
                if ( !DeepComparable.Matches(OutcomeReference, otherT.OutcomeReference)) return false;
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
                if (!DeepComparable.IsExactly(OutcomeCodeableConcept, otherT.OutcomeCodeableConcept)) return false;
                if (!DeepComparable.IsExactly(OutcomeReference, otherT.OutcomeReference)) return false;
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
                    foreach (var elem in OutcomeCodeableConcept) { if (elem != null) yield return elem; }
                    foreach (var elem in OutcomeReference) { if (elem != null) yield return elem; }
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
                    foreach (var elem in OutcomeCodeableConcept) { if (elem != null) yield return new ElementValue("outcomeCodeableConcept", elem); }
                    foreach (var elem in OutcomeReference) { if (elem != null) yield return new ElementValue("outcomeReference", elem); }
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
            /// Protocol or definition
            /// </summary>
            [FhirElement("definition", Order=50)]
            [References("PlanDefinition","ActivityDefinition","Questionnaire")]
            [DataMember]
            public ResourceReference Definition
            {
                get { return _definition; }
                set { _definition = value; OnPropertyChanged("Definition"); }
            }

            private ResourceReference _definition;

            /// <summary>
            /// Detail type of activity
            /// </summary>
            [FhirElement("code", Order=60)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Why activity should be done or why activity was prohibited
            /// </summary>
            [FhirElement("reasonCode", Order=70)]
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
            [FhirElement("reasonReference", Order=80)]
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
            [FhirElement("goal", Order=90)]
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
            /// not-started | scheduled | in-progress | on-hold | completed | cancelled | unknown
            /// </summary>
            [FhirElement("status", Order=100)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<CarePlanActivityStatus> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<CarePlanActivityStatus> _statusElement;

            /// <summary>
            /// not-started | scheduled | in-progress | on-hold | completed | cancelled | unknown
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
            [FhirElement("statusReason", Order=110)]
            [DataMember]
            public FhirString StatusReasonElement
            {
                get { return _statusReasonElement; }
                set { _statusReasonElement = value; OnPropertyChanged("StatusReasonElement"); }
            }

            private FhirString _statusReasonElement;

            /// <summary>
            /// Reason for current status
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string StatusReason
            {
                get { return StatusReasonElement != null ? StatusReasonElement.Value : null; }
                set
                {
                    if (value == null)
                        StatusReasonElement = null;
                    else
                        StatusReasonElement = new FhirString(value);
                    OnPropertyChanged("StatusReason");
                }
            }

            /// <summary>
            /// Do NOT do
            /// </summary>
            [FhirElement("prohibited", Order=120)]
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
            [FhirElement("scheduled", Order=130, Choice=ChoiceType.DatatypeChoice)]
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
            [FhirElement("location", Order=140)]
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
            [FhirElement("performer", Order=150)]
            [References("Practitioner","Organization","RelatedPerson","Patient","CareTeam")]
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
            [FhirElement("product", Order=160, Choice=ChoiceType.DatatypeChoice)]
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
            [FhirElement("dailyAmount", Order=170)]
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
            [FhirElement("quantity", Order=180)]
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
            [FhirElement("description", Order=190)]
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
                    if (Definition != null) dest.Definition = (ResourceReference)Definition.DeepCopy();
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                    if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                    if (Goal != null) dest.Goal = new List<ResourceReference>(Goal.DeepCopy());
                    if (StatusElement != null) dest.StatusElement = (Code<CarePlanActivityStatus>)StatusElement.DeepCopy();
                    if (StatusReasonElement != null) dest.StatusReasonElement = (FhirString)StatusReasonElement.DeepCopy();
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
                if (!DeepComparable.Matches(Definition, otherT.Definition)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
                if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
                if ( !DeepComparable.Matches(Goal, otherT.Goal)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.Matches(StatusReasonElement, otherT.StatusReasonElement)) return false;
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
                if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
                if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
                if (!DeepComparable.IsExactly(Goal, otherT.Goal)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.IsExactly(StatusReasonElement, otherT.StatusReasonElement)) return false;
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
                    if (Definition != null) yield return Definition;
                    if (Code != null) yield return Code;
                    foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                    foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                    foreach (var elem in Goal) { if (elem != null) yield return elem; }
                    if (StatusElement != null) yield return StatusElement;
                    if (StatusReasonElement != null) yield return StatusReasonElement;
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
                    if (Definition != null) yield return new ElementValue("definition", Definition);
                    if (Code != null) yield return new ElementValue("code", Code);
                    foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                    foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                    foreach (var elem in Goal) { if (elem != null) yield return new ElementValue("goal", elem); }
                    if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                    if (StatusReasonElement != null) yield return new ElementValue("statusReason", StatusReasonElement);
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
        /// Protocol or definition
        /// </summary>
        [FhirElement("definition", InSummary=true, Order=100)]
        [References("PlanDefinition","Questionnaire")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Definition
        {
            get { if (_definition==null) _definition = new List<ResourceReference>(); return _definition; }
            set { _definition = value; OnPropertyChanged("Definition"); }
        }

        private List<ResourceReference> _definition;

        /// <summary>
        /// Fulfills care plan
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=110)]
        [References("CarePlan")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// CarePlan replaced by this CarePlan
        /// </summary>
        [FhirElement("replaces", InSummary=true, Order=120)]
        [References("CarePlan")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Replaces
        {
            get { if (_replaces==null) _replaces = new List<ResourceReference>(); return _replaces; }
            set { _replaces = value; OnPropertyChanged("Replaces"); }
        }

        private List<ResourceReference> _replaces;

        /// <summary>
        /// Part of referenced CarePlan
        /// </summary>
        [FhirElement("partOf", InSummary=true, Order=130)]
        [References("CarePlan")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// draft | active | suspended | completed | entered-in-error | cancelled | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<CarePlanStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<CarePlanStatus> _statusElement;

        /// <summary>
        /// draft | active | suspended | completed | entered-in-error | cancelled | unknown
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
        /// proposal | plan | order | option
        /// </summary>
        [FhirElement("intent", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<CarePlanIntent> IntentElement
        {
            get { return _intentElement; }
            set { _intentElement = value; OnPropertyChanged("IntentElement"); }
        }

        private Code<CarePlanIntent> _intentElement;

        /// <summary>
        /// proposal | plan | order | option
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CarePlanIntent? Intent
        {
            get { return IntentElement != null ? IntentElement.Value : null; }
            set
            {
                if (value == null)
                    IntentElement = null;
                else
                    IntentElement = new Code<CarePlanIntent>(value);
                OnPropertyChanged("Intent");
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
        /// Human-friendly name for the CarePlan
        /// </summary>
        [FhirElement("title", InSummary=true, Order=170)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Human-friendly name for the CarePlan
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                    TitleElement = null;
                else
                    TitleElement = new FhirString(value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Summary of nature of plan
        /// </summary>
        [FhirElement("description", InSummary=true, Order=180)]
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
        /// Who care plan is for
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=190)]
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
        /// Created in context of
        /// </summary>
        [FhirElement("context", InSummary=true, Order=200)]
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
        [FhirElement("period", InSummary=true, Order=210)]
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
        [FhirElement("author", InSummary=true, Order=220)]
        [References("Patient","Practitioner","RelatedPerson","Organization","CareTeam")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Author
        {
            get { if (_author==null) _author = new List<ResourceReference>(); return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private List<ResourceReference> _author;

        /// <summary>
        /// Who's involved in plan?
        /// </summary>
        [FhirElement("careTeam", Order=230)]
        [References("CareTeam")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> CareTeam
        {
            get { if (_careTeam==null) _careTeam = new List<ResourceReference>(); return _careTeam; }
            set { _careTeam = value; OnPropertyChanged("CareTeam"); }
        }

        private List<ResourceReference> _careTeam;

        /// <summary>
        /// Health issues this plan addresses
        /// </summary>
        [FhirElement("addresses", InSummary=true, Order=240)]
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
        [FhirElement("supportingInfo", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInfo
        {
            get { if (_supportingInfo==null) _supportingInfo = new List<ResourceReference>(); return _supportingInfo; }
            set { _supportingInfo = value; OnPropertyChanged("SupportingInfo"); }
        }

        private List<ResourceReference> _supportingInfo;

        /// <summary>
        /// Desired outcome of plan
        /// </summary>
        [FhirElement("goal", Order=260)]
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
        [FhirElement("activity", Order=270)]
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
        [FhirElement("note", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;


        public static ElementDefinition.ConstraintComponent CarePlan_CPL_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "activity.all(detail.empty() or reference.empty())",
            Key = "cpl-3",
            Severity = ConstraintSeverity.Warning,
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
                if (Definition != null) dest.Definition = new List<ResourceReference>(Definition.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (Replaces != null) dest.Replaces = new List<ResourceReference>(Replaces.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<CarePlanStatus>)StatusElement.DeepCopy();
                if (IntentElement != null) dest.IntentElement = (Code<CarePlanIntent>)IntentElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Author != null) dest.Author = new List<ResourceReference>(Author.DeepCopy());
                if (CareTeam != null) dest.CareTeam = new List<ResourceReference>(CareTeam.DeepCopy());
                if (Addresses != null) dest.Addresses = new List<ResourceReference>(Addresses.DeepCopy());
                if (SupportingInfo != null) dest.SupportingInfo = new List<ResourceReference>(SupportingInfo.DeepCopy());
                if (Goal != null) dest.Goal = new List<ResourceReference>(Goal.DeepCopy());
                if (Activity != null) dest.Activity = new List<ActivityComponent>(Activity.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
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
            if ( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if ( !DeepComparable.Matches(Author, otherT.Author)) return false;
            if ( !DeepComparable.Matches(CareTeam, otherT.CareTeam)) return false;
            if ( !DeepComparable.Matches(Addresses, otherT.Addresses)) return false;
            if ( !DeepComparable.Matches(SupportingInfo, otherT.SupportingInfo)) return false;
            if ( !DeepComparable.Matches(Goal, otherT.Goal)) return false;
            if ( !DeepComparable.Matches(Activity, otherT.Activity)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as CarePlan;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(CareTeam, otherT.CareTeam)) return false;
            if (!DeepComparable.IsExactly(Addresses, otherT.Addresses)) return false;
            if (!DeepComparable.IsExactly(SupportingInfo, otherT.SupportingInfo)) return false;
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
                foreach (var elem in Definition) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in Replaces) { if (elem != null) yield return elem; }
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (IntentElement != null) yield return IntentElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (TitleElement != null) yield return TitleElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (Period != null) yield return Period;
                foreach (var elem in Author) { if (elem != null) yield return elem; }
                foreach (var elem in CareTeam) { if (elem != null) yield return elem; }
                foreach (var elem in Addresses) { if (elem != null) yield return elem; }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return elem; }
                foreach (var elem in Goal) { if (elem != null) yield return elem; }
                foreach (var elem in Activity) { if (elem != null) yield return elem; }
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
                foreach (var elem in Definition) { if (elem != null) yield return new ElementValue("definition", elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                foreach (var elem in Replaces) { if (elem != null) yield return new ElementValue("replaces", elem); }
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (IntentElement != null) yield return new ElementValue("intent", IntentElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (Period != null) yield return new ElementValue("period", Period);
                foreach (var elem in Author) { if (elem != null) yield return new ElementValue("author", elem); }
                foreach (var elem in CareTeam) { if (elem != null) yield return new ElementValue("careTeam", elem); }
                foreach (var elem in Addresses) { if (elem != null) yield return new ElementValue("addresses", elem); }
                foreach (var elem in SupportingInfo) { if (elem != null) yield return new ElementValue("supportingInfo", elem); }
                foreach (var elem in Goal) { if (elem != null) yield return new ElementValue("goal", elem); }
                foreach (var elem in Activity) { if (elem != null) yield return new ElementValue("activity", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
            }
        }

    }

}
