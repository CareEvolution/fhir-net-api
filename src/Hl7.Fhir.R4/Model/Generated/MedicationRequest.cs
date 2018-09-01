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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Ordering of medication for patient or group
    /// </summary>
    [FhirType("MedicationRequest", IsResource=true)]
    [DataContract]
    public partial class MedicationRequest : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationRequest; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationRequest"; } }

        /// <summary>
        /// A coded concept specifying the state of the prescribing event. Describes the lifecycle of the prescription.
        /// (url: http://hl7.org/fhir/ValueSet/medication-request-status)
        /// </summary>
        [FhirEnumeration("MedicationRequestStatus")]
        public enum MedicationRequestStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-status)
            /// </summary>
            [EnumLiteral("active", "http://hl7.org/fhir/medication-request-status"), Description("Active")]
            Active,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-status)
            /// </summary>
            [EnumLiteral("on-hold", "http://hl7.org/fhir/medication-request-status"), Description("On Hold")]
            OnHold,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-status)
            /// </summary>
            [EnumLiteral("cancelled", "http://hl7.org/fhir/medication-request-status"), Description("Cancelled")]
            Cancelled,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/medication-request-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/medication-request-status"), Description("Entered In Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-status)
            /// </summary>
            [EnumLiteral("stopped", "http://hl7.org/fhir/medication-request-status"), Description("Stopped")]
            Stopped,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-status)
            /// </summary>
            [EnumLiteral("draft", "http://hl7.org/fhir/medication-request-status"), Description("Draft")]
            Draft,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-status)
            /// </summary>
            [EnumLiteral("unknown", "http://hl7.org/fhir/medication-request-status"), Description("Unknown")]
            Unknown,
        }

        /// <summary>
        /// The kind of medication order.
        /// (url: http://hl7.org/fhir/ValueSet/medication-request-intent)
        /// </summary>
        [FhirEnumeration("MedicationRequestIntent")]
        public enum MedicationRequestIntent
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-intent)
            /// </summary>
            [EnumLiteral("proposal", "http://hl7.org/fhir/medication-request-intent"), Description("Proposal")]
            Proposal,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-intent)
            /// </summary>
            [EnumLiteral("plan", "http://hl7.org/fhir/medication-request-intent"), Description("Plan")]
            Plan,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-intent)
            /// </summary>
            [EnumLiteral("order", "http://hl7.org/fhir/medication-request-intent"), Description("Order")]
            Order,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-intent)
            /// </summary>
            [EnumLiteral("original-order", "http://hl7.org/fhir/medication-request-intent"), Description("Original Order")]
            OriginalOrder,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-intent)
            /// </summary>
            [EnumLiteral("instance-order", "http://hl7.org/fhir/medication-request-intent"), Description("Instance Order")]
            InstanceOrder,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-request-intent)
            /// </summary>
            [EnumLiteral("option", "http://hl7.org/fhir/medication-request-intent"), Description("Option")]
            Option,
        }


        [FhirType("DispenseRequestComponent")]
        [DataContract]
        public partial class DispenseRequestComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DispenseRequestComponent"; } }

            /// <summary>
            /// First fill details
            /// </summary>
            [FhirElement("initialFill", Order=40)]
            [DataMember]
            public InitialFillComponent InitialFill
            {
                get { return _initialFill; }
                set { _initialFill = value; OnPropertyChanged("InitialFill"); }
            }

            private InitialFillComponent _initialFill;

            /// <summary>
            /// Minimum period of time between dispenses
            /// </summary>
            [FhirElement("dispenseInterval", Order=50)]
            [DataMember]
            public Duration DispenseInterval
            {
                get { return _dispenseInterval; }
                set { _dispenseInterval = value; OnPropertyChanged("DispenseInterval"); }
            }

            private Duration _dispenseInterval;

            /// <summary>
            /// Time period supply is authorized for
            /// </summary>
            [FhirElement("validityPeriod", Order=60)]
            [DataMember]
            public Period ValidityPeriod
            {
                get { return _validityPeriod; }
                set { _validityPeriod = value; OnPropertyChanged("ValidityPeriod"); }
            }

            private Period _validityPeriod;

            /// <summary>
            /// Number of refills authorized
            /// </summary>
            [FhirElement("numberOfRepeatsAllowed", Order=70)]
            [DataMember]
            public UnsignedInt NumberOfRepeatsAllowedElement
            {
                get { return _numberOfRepeatsAllowedElement; }
                set { _numberOfRepeatsAllowedElement = value; OnPropertyChanged("NumberOfRepeatsAllowedElement"); }
            }

            private UnsignedInt _numberOfRepeatsAllowedElement;

            /// <summary>
            /// Number of refills authorized
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? NumberOfRepeatsAllowed
            {
                get { return NumberOfRepeatsAllowedElement != null ? NumberOfRepeatsAllowedElement.Value : null; }
                set
                {
                    if (value == null)
                        NumberOfRepeatsAllowedElement = null;
                    else
                        NumberOfRepeatsAllowedElement = new UnsignedInt(value);
                    OnPropertyChanged("NumberOfRepeatsAllowed");
                }
            }

            /// <summary>
            /// Amount of medication to supply per dispense
            /// </summary>
            [FhirElement("quantity", Order=80)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// Number of days supply per dispense
            /// </summary>
            [FhirElement("expectedSupplyDuration", Order=90)]
            [DataMember]
            public Duration ExpectedSupplyDuration
            {
                get { return _expectedSupplyDuration; }
                set { _expectedSupplyDuration = value; OnPropertyChanged("ExpectedSupplyDuration"); }
            }

            private Duration _expectedSupplyDuration;

            /// <summary>
            /// Intended dispenser
            /// </summary>
            [FhirElement("performer", Order=100)]
            [References("Organization")]
            [DataMember]
            public ResourceReference Performer
            {
                get { return _performer; }
                set { _performer = value; OnPropertyChanged("Performer"); }
            }

            private ResourceReference _performer;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DispenseRequestComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (InitialFill != null) dest.InitialFill = (InitialFillComponent)InitialFill.DeepCopy();
                    if (DispenseInterval != null) dest.DispenseInterval = (Duration)DispenseInterval.DeepCopy();
                    if (ValidityPeriod != null) dest.ValidityPeriod = (Period)ValidityPeriod.DeepCopy();
                    if (NumberOfRepeatsAllowedElement != null) dest.NumberOfRepeatsAllowedElement = (UnsignedInt)NumberOfRepeatsAllowedElement.DeepCopy();
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (ExpectedSupplyDuration != null) dest.ExpectedSupplyDuration = (Duration)ExpectedSupplyDuration.DeepCopy();
                    if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DispenseRequestComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DispenseRequestComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(InitialFill, otherT.InitialFill)) return false;
                if (!DeepComparable.Matches(DispenseInterval, otherT.DispenseInterval)) return false;
                if (!DeepComparable.Matches(ValidityPeriod, otherT.ValidityPeriod)) return false;
                if (!DeepComparable.Matches(NumberOfRepeatsAllowedElement, otherT.NumberOfRepeatsAllowedElement)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(ExpectedSupplyDuration, otherT.ExpectedSupplyDuration)) return false;
                if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DispenseRequestComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(InitialFill, otherT.InitialFill)) return false;
                if (!DeepComparable.IsExactly(DispenseInterval, otherT.DispenseInterval)) return false;
                if (!DeepComparable.IsExactly(ValidityPeriod, otherT.ValidityPeriod)) return false;
                if (!DeepComparable.IsExactly(NumberOfRepeatsAllowedElement, otherT.NumberOfRepeatsAllowedElement)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(ExpectedSupplyDuration, otherT.ExpectedSupplyDuration)) return false;
                if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (InitialFill != null) yield return InitialFill;
                    if (DispenseInterval != null) yield return DispenseInterval;
                    if (ValidityPeriod != null) yield return ValidityPeriod;
                    if (NumberOfRepeatsAllowedElement != null) yield return NumberOfRepeatsAllowedElement;
                    if (Quantity != null) yield return Quantity;
                    if (ExpectedSupplyDuration != null) yield return ExpectedSupplyDuration;
                    if (Performer != null) yield return Performer;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (InitialFill != null) yield return new ElementValue("initialFill", InitialFill);
                    if (DispenseInterval != null) yield return new ElementValue("dispenseInterval", DispenseInterval);
                    if (ValidityPeriod != null) yield return new ElementValue("validityPeriod", ValidityPeriod);
                    if (NumberOfRepeatsAllowedElement != null) yield return new ElementValue("numberOfRepeatsAllowed", NumberOfRepeatsAllowedElement);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (ExpectedSupplyDuration != null) yield return new ElementValue("expectedSupplyDuration", ExpectedSupplyDuration);
                    if (Performer != null) yield return new ElementValue("performer", Performer);
                }
            }


        }


        [FhirType("InitialFillComponent")]
        [DataContract]
        public partial class InitialFillComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "InitialFillComponent"; } }

            /// <summary>
            /// First fill quantity
            /// </summary>
            [FhirElement("quantity", Order=40)]
            [DataMember]
            public SimpleQuantity Quantity
            {
                get { return _quantity; }
                set { _quantity = value; OnPropertyChanged("Quantity"); }
            }

            private SimpleQuantity _quantity;

            /// <summary>
            /// First fill duration
            /// </summary>
            [FhirElement("duration", Order=50)]
            [DataMember]
            public Duration Duration
            {
                get { return _duration; }
                set { _duration = value; OnPropertyChanged("Duration"); }
            }

            private Duration _duration;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as InitialFillComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                    if (Duration != null) dest.Duration = (Duration)Duration.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new InitialFillComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as InitialFillComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.Matches(Duration, otherT.Duration)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as InitialFillComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if (!DeepComparable.IsExactly(Duration, otherT.Duration)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Quantity != null) yield return Quantity;
                    if (Duration != null) yield return Duration;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (Duration != null) yield return new ElementValue("duration", Duration);
                }
            }


        }


        [FhirType("SubstitutionComponent")]
        [DataContract]
        public partial class SubstitutionComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubstitutionComponent"; } }

            /// <summary>
            /// Whether substitution is allowed or not
            /// </summary>
            [FhirElement("allowed", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean AllowedElement
            {
                get { return _allowedElement; }
                set { _allowedElement = value; OnPropertyChanged("AllowedElement"); }
            }

            private FhirBoolean _allowedElement;

            /// <summary>
            /// Whether substitution is allowed or not
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Allowed
            {
                get { return AllowedElement != null ? AllowedElement.Value : null; }
                set
                {
                    if (value == null)
                        AllowedElement = null;
                    else
                        AllowedElement = new FhirBoolean(value);
                    OnPropertyChanged("Allowed");
                }
            }

            /// <summary>
            /// Why should (not) substitution be made
            /// </summary>
            [FhirElement("reason", Order=50)]
            [DataMember]
            public CodeableConcept Reason
            {
                get { return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private CodeableConcept _reason;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstitutionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (AllowedElement != null) dest.AllowedElement = (FhirBoolean)AllowedElement.DeepCopy();
                    if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SubstitutionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(AllowedElement, otherT.AllowedElement)) return false;
                if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(AllowedElement, otherT.AllowedElement)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (AllowedElement != null) yield return AllowedElement;
                    if (Reason != null) yield return Reason;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (AllowedElement != null) yield return new ElementValue("allowed", AllowedElement);
                    if (Reason != null) yield return new ElementValue("reason", Reason);
                }
            }


        }


        /// <summary>
        /// External ids for this request
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
        /// active | on-hold | cancelled | completed | entered-in-error | stopped | draft | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MedicationRequestStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationRequestStatus> _statusElement;

        /// <summary>
        /// active | on-hold | cancelled | completed | entered-in-error | stopped | draft | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationRequestStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationRequestStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// proposal | plan | order | original-order | instance-order | option
        /// </summary>
        [FhirElement("intent", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MedicationRequestIntent> IntentElement
        {
            get { return _intentElement; }
            set { _intentElement = value; OnPropertyChanged("IntentElement"); }
        }

        private Code<MedicationRequestIntent> _intentElement;

        /// <summary>
        /// proposal | plan | order | original-order | instance-order | option
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationRequestIntent? Intent
        {
            get { return IntentElement != null ? IntentElement.Value : null; }
            set
            {
                if (value == null)
                    IntentElement = null;
                else
                    IntentElement = new Code<MedicationRequestIntent>(value);
                OnPropertyChanged("Intent");
            }
        }

        /// <summary>
        /// Type of medication usage
        /// </summary>
        [FhirElement("category", Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        [FhirElement("priority", InSummary=true, Order=130)]
        [DataMember]
        public Code<RequestPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<RequestPriority> _priorityElement;

        /// <summary>
        /// routine | urgent | asap | stat
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RequestPriority? Priority
        {
            get { return PriorityElement != null ? PriorityElement.Value : null; }
            set
            {
                if (value == null)
                    PriorityElement = null;
                else
                    PriorityElement = new Code<RequestPriority>(value);
                OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        /// True if request is prohibiting action
        /// </summary>
        [FhirElement("doNotPerform", InSummary=true, Order=140)]
        [DataMember]
        public FhirBoolean DoNotPerformElement
        {
            get { return _doNotPerformElement; }
            set { _doNotPerformElement = value; OnPropertyChanged("DoNotPerformElement"); }
        }

        private FhirBoolean _doNotPerformElement;

        /// <summary>
        /// True if request is prohibiting action
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? DoNotPerform
        {
            get { return DoNotPerformElement != null ? DoNotPerformElement.Value : null; }
            set
            {
                if (value == null)
                    DoNotPerformElement = null;
                else
                    DoNotPerformElement = new FhirBoolean(value);
                OnPropertyChanged("DoNotPerform");
            }
        }

        /// <summary>
        /// Medication to be taken
        /// </summary>
        [FhirElement("medication", InSummary=true, Order=150, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Medication
        {
            get { return _medication; }
            set { _medication = value; OnPropertyChanged("Medication"); }
        }

        private Element _medication;

        /// <summary>
        /// Who or group medication request is for
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=160)]
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
        /// Created during encounter/admission/stay
        /// </summary>
        [FhirElement("context", Order=170)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// Information to support ordering of the medication
        /// </summary>
        [FhirElement("supportingInformation", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInformation
        {
            get { if (_supportingInformation==null) _supportingInformation = new List<ResourceReference>(); return _supportingInformation; }
            set { _supportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }

        private List<ResourceReference> _supportingInformation;

        /// <summary>
        /// When request was initially authored
        /// </summary>
        [FhirElement("authoredOn", InSummary=true, Order=190)]
        [DataMember]
        public FhirDateTime AuthoredOnElement
        {
            get { return _authoredOnElement; }
            set { _authoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }

        private FhirDateTime _authoredOnElement;

        /// <summary>
        /// When request was initially authored
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string AuthoredOn
        {
            get { return AuthoredOnElement != null ? AuthoredOnElement.Value : null; }
            set
            {
                if (value == null)
                    AuthoredOnElement = null;
                else
                    AuthoredOnElement = new FhirDateTime(value);
                OnPropertyChanged("AuthoredOn");
            }
        }

        /// <summary>
        /// Who/What requested the Request
        /// </summary>
        [FhirElement("requester", InSummary=true, Order=200)]
        [References("Practitioner","PractitionerRole","Organization","Patient","RelatedPerson","Device")]
        [DataMember]
        public ResourceReference Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private ResourceReference _requester;

        /// <summary>
        /// Intended performer of administration
        /// </summary>
        [FhirElement("performer", Order=210)]
        [References("Practitioner","PractitionerRole","Organization","Patient","Device","RelatedPerson","CareTeam")]
        [DataMember]
        public ResourceReference Performer
        {
            get { return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private ResourceReference _performer;

        /// <summary>
        /// Desired kind of performer of the medication administration
        /// </summary>
        [FhirElement("performerType", InSummary=true, Order=220)]
        [DataMember]
        public CodeableConcept PerformerType
        {
            get { return _performerType; }
            set { _performerType = value; OnPropertyChanged("PerformerType"); }
        }

        private CodeableConcept _performerType;

        /// <summary>
        /// Person who entered the request
        /// </summary>
        [FhirElement("recorder", Order=230)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference Recorder
        {
            get { return _recorder; }
            set { _recorder = value; OnPropertyChanged("Recorder"); }
        }

        private ResourceReference _recorder;

        /// <summary>
        /// Reason or indication for ordering or not ordering the medication
        /// </summary>
        [FhirElement("reasonCode", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Condition or observation that supports why the prescription is being written
        /// </summary>
        [FhirElement("reasonReference", Order=250)]
        [References("Condition","Observation")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReasonReference
        {
            get { if (_reasonReference==null) _reasonReference = new List<ResourceReference>(); return _reasonReference; }
            set { _reasonReference = value; OnPropertyChanged("ReasonReference"); }
        }

        private List<ResourceReference> _reasonReference;

        /// <summary>
        /// Instantiates protocol or definition
        /// </summary>
        [FhirElement("instantiates", InSummary=true, Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<FhirUri> InstantiatesElement
        {
            get { if (_instantiatesElement==null) _instantiatesElement = new List<FhirUri>(); return _instantiatesElement; }
            set { _instantiatesElement = value; OnPropertyChanged("InstantiatesElement"); }
        }

        private List<FhirUri> _instantiatesElement;

        /// <summary>
        /// Instantiates protocol or definition
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public IEnumerable<string> Instantiates
        {
            get { return InstantiatesElement != null ? InstantiatesElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    InstantiatesElement = null;
                else
                    InstantiatesElement = new List<FhirUri>(value.Select(elem=>new FhirUri(elem)));
                OnPropertyChanged("Instantiates");
            }
        }

        /// <summary>
        /// What request fulfills
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=270)]
        [References("CarePlan","MedicationRequest","ServiceRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Composite request this is part of
        /// </summary>
        [FhirElement("groupIdentifier", InSummary=true, Order=280)]
        [DataMember]
        public Identifier GroupIdentifier
        {
            get { return _groupIdentifier; }
            set { _groupIdentifier = value; OnPropertyChanged("GroupIdentifier"); }
        }

        private Identifier _groupIdentifier;

        /// <summary>
        /// Reason for current status
        /// </summary>
        [FhirElement("statusReason", Order=290)]
        [DataMember]
        public CodeableConcept StatusReason
        {
            get { return _statusReason; }
            set { _statusReason = value; OnPropertyChanged("StatusReason"); }
        }

        private CodeableConcept _statusReason;

        /// <summary>
        /// Overall pattern of medication administration
        /// </summary>
        [FhirElement("courseOfTherapyType", Order=300)]
        [DataMember]
        public CodeableConcept CourseOfTherapyType
        {
            get { return _courseOfTherapyType; }
            set { _courseOfTherapyType = value; OnPropertyChanged("CourseOfTherapyType"); }
        }

        private CodeableConcept _courseOfTherapyType;

        /// <summary>
        /// Associated insurance coverage
        /// </summary>
        [FhirElement("insurance", Order=310)]
        [References("Coverage","ClaimResponse")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Insurance
        {
            get { if (_insurance==null) _insurance = new List<ResourceReference>(); return _insurance; }
            set { _insurance = value; OnPropertyChanged("Insurance"); }
        }

        private List<ResourceReference> _insurance;

        /// <summary>
        /// Information about the prescription
        /// </summary>
        [FhirElement("note", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// How the medication should be taken
        /// </summary>
        [FhirElement("dosageInstruction", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Dosage> DosageInstruction
        {
            get { if (_dosageInstruction==null) _dosageInstruction = new List<Dosage>(); return _dosageInstruction; }
            set { _dosageInstruction = value; OnPropertyChanged("DosageInstruction"); }
        }

        private List<Dosage> _dosageInstruction;

        /// <summary>
        /// Medication supply authorization
        /// </summary>
        [FhirElement("dispenseRequest", Order=340)]
        [DataMember]
        public DispenseRequestComponent DispenseRequest
        {
            get { return _dispenseRequest; }
            set { _dispenseRequest = value; OnPropertyChanged("DispenseRequest"); }
        }

        private DispenseRequestComponent _dispenseRequest;

        /// <summary>
        /// Any restrictions on medication substitution
        /// </summary>
        [FhirElement("substitution", Order=350)]
        [DataMember]
        public SubstitutionComponent Substitution
        {
            get { return _substitution; }
            set { _substitution = value; OnPropertyChanged("Substitution"); }
        }

        private SubstitutionComponent _substitution;

        /// <summary>
        /// An order/prescription that is being replaced
        /// </summary>
        [FhirElement("priorPrescription", Order=360)]
        [References("MedicationRequest")]
        [DataMember]
        public ResourceReference PriorPrescription
        {
            get { return _priorPrescription; }
            set { _priorPrescription = value; OnPropertyChanged("PriorPrescription"); }
        }

        private ResourceReference _priorPrescription;

        /// <summary>
        /// Clinical Issue with action
        /// </summary>
        [FhirElement("detectedIssue", Order=370)]
        [References("DetectedIssue")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> DetectedIssue
        {
            get { if (_detectedIssue==null) _detectedIssue = new List<ResourceReference>(); return _detectedIssue; }
            set { _detectedIssue = value; OnPropertyChanged("DetectedIssue"); }
        }

        private List<ResourceReference> _detectedIssue;

        /// <summary>
        /// A list of events of interest in the lifecycle
        /// </summary>
        [FhirElement("eventHistory", Order=380)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> EventHistory
        {
            get { if (_eventHistory==null) _eventHistory = new List<ResourceReference>(); return _eventHistory; }
            set { _eventHistory = value; OnPropertyChanged("EventHistory"); }
        }

        private List<ResourceReference> _eventHistory;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationRequest;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<MedicationRequestStatus>)StatusElement.DeepCopy();
                if (IntentElement != null) dest.IntentElement = (Code<MedicationRequestIntent>)IntentElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (PriorityElement != null) dest.PriorityElement = (Code<RequestPriority>)PriorityElement.DeepCopy();
                if (DoNotPerformElement != null) dest.DoNotPerformElement = (FhirBoolean)DoNotPerformElement.DeepCopy();
                if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (SupportingInformation != null) dest.SupportingInformation = new List<ResourceReference>(SupportingInformation.DeepCopy());
                if (AuthoredOnElement != null) dest.AuthoredOnElement = (FhirDateTime)AuthoredOnElement.DeepCopy();
                if (Requester != null) dest.Requester = (ResourceReference)Requester.DeepCopy();
                if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                if (PerformerType != null) dest.PerformerType = (CodeableConcept)PerformerType.DeepCopy();
                if (Recorder != null) dest.Recorder = (ResourceReference)Recorder.DeepCopy();
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (InstantiatesElement != null) dest.InstantiatesElement = new List<FhirUri>(InstantiatesElement.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (GroupIdentifier != null) dest.GroupIdentifier = (Identifier)GroupIdentifier.DeepCopy();
                if (StatusReason != null) dest.StatusReason = (CodeableConcept)StatusReason.DeepCopy();
                if (CourseOfTherapyType != null) dest.CourseOfTherapyType = (CodeableConcept)CourseOfTherapyType.DeepCopy();
                if (Insurance != null) dest.Insurance = new List<ResourceReference>(Insurance.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (DosageInstruction != null) dest.DosageInstruction = new List<Dosage>(DosageInstruction.DeepCopy());
                if (DispenseRequest != null) dest.DispenseRequest = (DispenseRequestComponent)DispenseRequest.DeepCopy();
                if (Substitution != null) dest.Substitution = (SubstitutionComponent)Substitution.DeepCopy();
                if (PriorPrescription != null) dest.PriorPrescription = (ResourceReference)PriorPrescription.DeepCopy();
                if (DetectedIssue != null) dest.DetectedIssue = new List<ResourceReference>(DetectedIssue.DeepCopy());
                if (EventHistory != null) dest.EventHistory = new List<ResourceReference>(EventHistory.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationRequest());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationRequest;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.Matches(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if ( !DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(PerformerType, otherT.PerformerType)) return false;
            if (!DeepComparable.Matches(Recorder, otherT.Recorder)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if ( !DeepComparable.Matches(InstantiatesElement, otherT.InstantiatesElement)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.Matches(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if (!DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.Matches(CourseOfTherapyType, otherT.CourseOfTherapyType)) return false;
            if ( !DeepComparable.Matches(Insurance, otherT.Insurance)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(DosageInstruction, otherT.DosageInstruction)) return false;
            if (!DeepComparable.Matches(DispenseRequest, otherT.DispenseRequest)) return false;
            if (!DeepComparable.Matches(Substitution, otherT.Substitution)) return false;
            if (!DeepComparable.Matches(PriorPrescription, otherT.PriorPrescription)) return false;
            if ( !DeepComparable.Matches(DetectedIssue, otherT.DetectedIssue)) return false;
            if ( !DeepComparable.Matches(EventHistory, otherT.EventHistory)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationRequest;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(DoNotPerformElement, otherT.DoNotPerformElement)) return false;
            if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(PerformerType, otherT.PerformerType)) return false;
            if (!DeepComparable.IsExactly(Recorder, otherT.Recorder)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(InstantiatesElement, otherT.InstantiatesElement)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if (!DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.IsExactly(CourseOfTherapyType, otherT.CourseOfTherapyType)) return false;
            if (!DeepComparable.IsExactly(Insurance, otherT.Insurance)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(DosageInstruction, otherT.DosageInstruction)) return false;
            if (!DeepComparable.IsExactly(DispenseRequest, otherT.DispenseRequest)) return false;
            if (!DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;
            if (!DeepComparable.IsExactly(PriorPrescription, otherT.PriorPrescription)) return false;
            if (!DeepComparable.IsExactly(DetectedIssue, otherT.DetectedIssue)) return false;
            if (!DeepComparable.IsExactly(EventHistory, otherT.EventHistory)) return false;

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
                if (IntentElement != null) yield return IntentElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (PriorityElement != null) yield return PriorityElement;
                if (DoNotPerformElement != null) yield return DoNotPerformElement;
                if (Medication != null) yield return Medication;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (Requester != null) yield return Requester;
                if (Performer != null) yield return Performer;
                if (PerformerType != null) yield return PerformerType;
                if (Recorder != null) yield return Recorder;
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                foreach (var elem in InstantiatesElement) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                if (GroupIdentifier != null) yield return GroupIdentifier;
                if (StatusReason != null) yield return StatusReason;
                if (CourseOfTherapyType != null) yield return CourseOfTherapyType;
                foreach (var elem in Insurance) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in DosageInstruction) { if (elem != null) yield return elem; }
                if (DispenseRequest != null) yield return DispenseRequest;
                if (Substitution != null) yield return Substitution;
                if (PriorPrescription != null) yield return PriorPrescription;
                foreach (var elem in DetectedIssue) { if (elem != null) yield return elem; }
                foreach (var elem in EventHistory) { if (elem != null) yield return elem; }
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
                if (IntentElement != null) yield return new ElementValue("intent", IntentElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                if (DoNotPerformElement != null) yield return new ElementValue("doNotPerform", DoNotPerformElement);
                if (Medication != null) yield return new ElementValue("medication", Medication);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", elem); }
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", AuthoredOnElement);
                if (Requester != null) yield return new ElementValue("requester", Requester);
                if (Performer != null) yield return new ElementValue("performer", Performer);
                if (PerformerType != null) yield return new ElementValue("performerType", PerformerType);
                if (Recorder != null) yield return new ElementValue("recorder", Recorder);
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                foreach (var elem in InstantiatesElement) { if (elem != null) yield return new ElementValue("instantiates", elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                if (GroupIdentifier != null) yield return new ElementValue("groupIdentifier", GroupIdentifier);
                if (StatusReason != null) yield return new ElementValue("statusReason", StatusReason);
                if (CourseOfTherapyType != null) yield return new ElementValue("courseOfTherapyType", CourseOfTherapyType);
                foreach (var elem in Insurance) { if (elem != null) yield return new ElementValue("insurance", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in DosageInstruction) { if (elem != null) yield return new ElementValue("dosageInstruction", elem); }
                if (DispenseRequest != null) yield return new ElementValue("dispenseRequest", DispenseRequest);
                if (Substitution != null) yield return new ElementValue("substitution", Substitution);
                if (PriorPrescription != null) yield return new ElementValue("priorPrescription", PriorPrescription);
                foreach (var elem in DetectedIssue) { if (elem != null) yield return new ElementValue("detectedIssue", elem); }
                foreach (var elem in EventHistory) { if (elem != null) yield return new ElementValue("eventHistory", elem); }
            }
        }

    }

}
