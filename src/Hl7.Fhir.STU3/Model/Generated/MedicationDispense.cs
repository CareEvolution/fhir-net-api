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
    /// Dispensing a medication to a named patient
    /// </summary>
    [FhirType("MedicationDispense", IsResource=true)]
    [DataContract]
    public partial class MedicationDispense : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationDispense; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationDispense"; } }


        [FhirType("PerformerComponent")]
        [DataContract]
        public partial class PerformerComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PerformerComponent"; } }

            /// <summary>
            /// Individual who was performing
            /// </summary>
            [FhirElement("actor", Order=40)]
            [References("Practitioner","Organization","Patient","Device","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Actor
            {
                get { return _actor; }
                set { _actor = value; OnPropertyChanged("Actor"); }
            }

            private ResourceReference _actor;

            /// <summary>
            /// Organization organization was acting for
            /// </summary>
            [FhirElement("onBehalfOf", Order=50)]
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
                if (!DeepComparable.Matches(Actor, otherT.Actor)) return false;
                if (!DeepComparable.Matches(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PerformerComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
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
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                    if (OnBehalfOf != null) yield return new ElementValue("onBehalfOf", OnBehalfOf);
                }
            }


        }


        [FhirType("SubstitutionComponent")]
        [DataContract]
        public partial class SubstitutionComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SubstitutionComponent"; } }

            /// <summary>
            /// Whether a substitution was or was not performed on the dispense
            /// </summary>
            [FhirElement("wasSubstituted", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirBoolean WasSubstitutedElement
            {
                get { return _wasSubstitutedElement; }
                set { _wasSubstitutedElement = value; OnPropertyChanged("WasSubstitutedElement"); }
            }

            private FhirBoolean _wasSubstitutedElement;

            /// <summary>
            /// Whether a substitution was or was not performed on the dispense
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? WasSubstituted
            {
                get { return WasSubstitutedElement != null ? WasSubstitutedElement.Value : null; }
                set
                {
                    if (value == null)
                        WasSubstitutedElement = null;
                    else
                        WasSubstitutedElement = new FhirBoolean(value);
                    OnPropertyChanged("WasSubstituted");
                }
            }

            /// <summary>
            /// Code signifying whether a different drug was dispensed from what was prescribed
            /// </summary>
            [FhirElement("type", Order=50)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Why was substitution made
            /// </summary>
            [FhirElement("reason", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Reason
            {
                get { if (_reason==null) _reason = new List<CodeableConcept>(); return _reason; }
                set { _reason = value; OnPropertyChanged("Reason"); }
            }

            private List<CodeableConcept> _reason;

            /// <summary>
            /// Who is responsible for the substitution
            /// </summary>
            [FhirElement("responsibleParty", Order=70)]
            [References("Practitioner")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> ResponsibleParty
            {
                get { if (_responsibleParty==null) _responsibleParty = new List<ResourceReference>(); return _responsibleParty; }
                set { _responsibleParty = value; OnPropertyChanged("ResponsibleParty"); }
            }

            private List<ResourceReference> _responsibleParty;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstitutionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (WasSubstitutedElement != null) dest.WasSubstitutedElement = (FhirBoolean)WasSubstitutedElement.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                    if (ResponsibleParty != null) dest.ResponsibleParty = new List<ResourceReference>(ResponsibleParty.DeepCopy());
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
                if (!DeepComparable.Matches(WasSubstitutedElement, otherT.WasSubstitutedElement)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if ( !DeepComparable.Matches(ResponsibleParty, otherT.ResponsibleParty)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(WasSubstitutedElement, otherT.WasSubstitutedElement)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if (!DeepComparable.IsExactly(ResponsibleParty, otherT.ResponsibleParty)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (WasSubstitutedElement != null) yield return WasSubstitutedElement;
                    if (Type != null) yield return Type;
                    foreach (var elem in Reason) { if (elem != null) yield return elem; }
                    foreach (var elem in ResponsibleParty) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (WasSubstitutedElement != null) yield return new ElementValue("wasSubstituted", WasSubstitutedElement);
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                    foreach (var elem in ResponsibleParty) { if (elem != null) yield return new ElementValue("responsibleParty", elem); }
                }
            }


        }


        /// <summary>
        /// External identifier
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
        /// Event that dispense is part of
        /// </summary>
        [FhirElement("partOf", Order=100)]
        [References("Procedure")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// preparation | in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [DataMember]
        public Code<MedicationDispenseStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationDispenseStatus> _statusElement;

        /// <summary>
        /// preparation | in-progress | on-hold | completed | entered-in-error | stopped
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationDispenseStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationDispenseStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Type of medication dispense
        /// </summary>
        [FhirElement("category", Order=120)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// What medication was supplied
        /// </summary>
        [FhirElement("medication", InSummary=true, Order=130, Choice=ChoiceType.DatatypeChoice)]
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
        /// Who the dispense is for
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=140)]
        [References("Patient","Group")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Encounter / Episode associated with event
        /// </summary>
        [FhirElement("context", Order=150)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// Information that supports the dispensing of the medication
        /// </summary>
        [FhirElement("supportingInformation", Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInformation
        {
            get { if (_supportingInformation==null) _supportingInformation = new List<ResourceReference>(); return _supportingInformation; }
            set { _supportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }

        private List<ResourceReference> _supportingInformation;

        /// <summary>
        /// Who performed event
        /// </summary>
        [FhirElement("performer", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PerformerComponent> Performer
        {
            get { if (_performer==null) _performer = new List<PerformerComponent>(); return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private List<PerformerComponent> _performer;

        /// <summary>
        /// Medication order that authorizes the dispense
        /// </summary>
        [FhirElement("authorizingPrescription", Order=180)]
        [References("MedicationRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> AuthorizingPrescription
        {
            get { if (_authorizingPrescription==null) _authorizingPrescription = new List<ResourceReference>(); return _authorizingPrescription; }
            set { _authorizingPrescription = value; OnPropertyChanged("AuthorizingPrescription"); }
        }

        private List<ResourceReference> _authorizingPrescription;

        /// <summary>
        /// Trial fill, partial fill, emergency fill, etc.
        /// </summary>
        [FhirElement("type", Order=190)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Amount dispensed
        /// </summary>
        [FhirElement("quantity", Order=200)]
        [DataMember]
        public SimpleQuantity Quantity
        {
            get { return _quantity; }
            set { _quantity = value; OnPropertyChanged("Quantity"); }
        }

        private SimpleQuantity _quantity;

        /// <summary>
        /// Amount of medication expressed as a timing amount
        /// </summary>
        [FhirElement("daysSupply", Order=210)]
        [DataMember]
        public SimpleQuantity DaysSupply
        {
            get { return _daysSupply; }
            set { _daysSupply = value; OnPropertyChanged("DaysSupply"); }
        }

        private SimpleQuantity _daysSupply;

        /// <summary>
        /// When product was packaged and reviewed
        /// </summary>
        [FhirElement("whenPrepared", InSummary=true, Order=220)]
        [DataMember]
        public FhirDateTime WhenPreparedElement
        {
            get { return _whenPreparedElement; }
            set { _whenPreparedElement = value; OnPropertyChanged("WhenPreparedElement"); }
        }

        private FhirDateTime _whenPreparedElement;

        /// <summary>
        /// When product was packaged and reviewed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string WhenPrepared
        {
            get { return WhenPreparedElement != null ? WhenPreparedElement.Value : null; }
            set
            {
                if (value == null)
                    WhenPreparedElement = null;
                else
                    WhenPreparedElement = new FhirDateTime(value);
                OnPropertyChanged("WhenPrepared");
            }
        }

        /// <summary>
        /// When product was given out
        /// </summary>
        [FhirElement("whenHandedOver", Order=230)]
        [DataMember]
        public FhirDateTime WhenHandedOverElement
        {
            get { return _whenHandedOverElement; }
            set { _whenHandedOverElement = value; OnPropertyChanged("WhenHandedOverElement"); }
        }

        private FhirDateTime _whenHandedOverElement;

        /// <summary>
        /// When product was given out
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string WhenHandedOver
        {
            get { return WhenHandedOverElement != null ? WhenHandedOverElement.Value : null; }
            set
            {
                if (value == null)
                    WhenHandedOverElement = null;
                else
                    WhenHandedOverElement = new FhirDateTime(value);
                OnPropertyChanged("WhenHandedOver");
            }
        }

        /// <summary>
        /// Where the medication was sent
        /// </summary>
        [FhirElement("destination", Order=240)]
        [References("Location")]
        [DataMember]
        public ResourceReference Destination
        {
            get { return _destination; }
            set { _destination = value; OnPropertyChanged("Destination"); }
        }

        private ResourceReference _destination;

        /// <summary>
        /// Who collected the medication
        /// </summary>
        [FhirElement("receiver", Order=250)]
        [References("Patient","Practitioner")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Receiver
        {
            get { if (_receiver==null) _receiver = new List<ResourceReference>(); return _receiver; }
            set { _receiver = value; OnPropertyChanged("Receiver"); }
        }

        private List<ResourceReference> _receiver;

        /// <summary>
        /// Information about the dispense
        /// </summary>
        [FhirElement("note", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// How the medication is to be used by the patient or administered by the caregiver
        /// </summary>
        [FhirElement("dosageInstruction", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Dosage> DosageInstruction
        {
            get { if (_dosageInstruction==null) _dosageInstruction = new List<Dosage>(); return _dosageInstruction; }
            set { _dosageInstruction = value; OnPropertyChanged("DosageInstruction"); }
        }

        private List<Dosage> _dosageInstruction;

        /// <summary>
        /// Whether a substitution was performed on the dispense
        /// </summary>
        [FhirElement("substitution", Order=280)]
        [DataMember]
        public SubstitutionComponent Substitution
        {
            get { return _substitution; }
            set { _substitution = value; OnPropertyChanged("Substitution"); }
        }

        private SubstitutionComponent _substitution;

        /// <summary>
        /// Clinical issue with action
        /// </summary>
        [FhirElement("detectedIssue", Order=290)]
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
        /// Whether the dispense was or was not performed
        /// </summary>
        [FhirElement("notDone", Order=300)]
        [DataMember]
        public FhirBoolean NotDoneElement
        {
            get { return _notDoneElement; }
            set { _notDoneElement = value; OnPropertyChanged("NotDoneElement"); }
        }

        private FhirBoolean _notDoneElement;

        /// <summary>
        /// Whether the dispense was or was not performed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? NotDone
        {
            get { return NotDoneElement != null ? NotDoneElement.Value : null; }
            set
            {
                if (value == null)
                    NotDoneElement = null;
                else
                    NotDoneElement = new FhirBoolean(value);
                OnPropertyChanged("NotDone");
            }
        }

        /// <summary>
        /// Why a dispense was not performed
        /// </summary>
        [FhirElement("notDoneReason", Order=310, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element NotDoneReason
        {
            get { return _notDoneReason; }
            set { _notDoneReason = value; OnPropertyChanged("NotDoneReason"); }
        }

        private Element _notDoneReason;

        /// <summary>
        /// A list of releveant lifecycle events
        /// </summary>
        [FhirElement("eventHistory", Order=320)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> EventHistory
        {
            get { if (_eventHistory==null) _eventHistory = new List<ResourceReference>(); return _eventHistory; }
            set { _eventHistory = value; OnPropertyChanged("EventHistory"); }
        }

        private List<ResourceReference> _eventHistory;


        public static ElementDefinition.ConstraintComponent MedicationDispense_MDD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "whenHandedOver.empty() or whenPrepared.empty() or whenHandedOver >= whenPrepared",
            Key = "mdd-1",
            Severity = ConstraintSeverity.Warning,
            Human = "whenHandedOver cannot be before whenPrepared",
            Xpath = "not(exists(f:whenHandedOver/@value)) or not(exists(f:whenPrepared/@value)) or ( f:whenHandedOver/@value >= f:whenPrepared/@value)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(MedicationDispense_MDD_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationDispense;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<MedicationDispenseStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (SupportingInformation != null) dest.SupportingInformation = new List<ResourceReference>(SupportingInformation.DeepCopy());
                if (Performer != null) dest.Performer = new List<PerformerComponent>(Performer.DeepCopy());
                if (AuthorizingPrescription != null) dest.AuthorizingPrescription = new List<ResourceReference>(AuthorizingPrescription.DeepCopy());
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Quantity != null) dest.Quantity = (SimpleQuantity)Quantity.DeepCopy();
                if (DaysSupply != null) dest.DaysSupply = (SimpleQuantity)DaysSupply.DeepCopy();
                if (WhenPreparedElement != null) dest.WhenPreparedElement = (FhirDateTime)WhenPreparedElement.DeepCopy();
                if (WhenHandedOverElement != null) dest.WhenHandedOverElement = (FhirDateTime)WhenHandedOverElement.DeepCopy();
                if (Destination != null) dest.Destination = (ResourceReference)Destination.DeepCopy();
                if (Receiver != null) dest.Receiver = new List<ResourceReference>(Receiver.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (DosageInstruction != null) dest.DosageInstruction = new List<Dosage>(DosageInstruction.DeepCopy());
                if (Substitution != null) dest.Substitution = (SubstitutionComponent)Substitution.DeepCopy();
                if (DetectedIssue != null) dest.DetectedIssue = new List<ResourceReference>(DetectedIssue.DeepCopy());
                if (NotDoneElement != null) dest.NotDoneElement = (FhirBoolean)NotDoneElement.DeepCopy();
                if (NotDoneReason != null) dest.NotDoneReason = (Element)NotDoneReason.DeepCopy();
                if (EventHistory != null) dest.EventHistory = new List<ResourceReference>(EventHistory.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationDispense());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationDispense;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if ( !DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if ( !DeepComparable.Matches(AuthorizingPrescription, otherT.AuthorizingPrescription)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.Matches(DaysSupply, otherT.DaysSupply)) return false;
            if (!DeepComparable.Matches(WhenPreparedElement, otherT.WhenPreparedElement)) return false;
            if (!DeepComparable.Matches(WhenHandedOverElement, otherT.WhenHandedOverElement)) return false;
            if (!DeepComparable.Matches(Destination, otherT.Destination)) return false;
            if ( !DeepComparable.Matches(Receiver, otherT.Receiver)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(DosageInstruction, otherT.DosageInstruction)) return false;
            if (!DeepComparable.Matches(Substitution, otherT.Substitution)) return false;
            if ( !DeepComparable.Matches(DetectedIssue, otherT.DetectedIssue)) return false;
            if (!DeepComparable.Matches(NotDoneElement, otherT.NotDoneElement)) return false;
            if (!DeepComparable.Matches(NotDoneReason, otherT.NotDoneReason)) return false;
            if ( !DeepComparable.Matches(EventHistory, otherT.EventHistory)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationDispense;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(AuthorizingPrescription, otherT.AuthorizingPrescription)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            if (!DeepComparable.IsExactly(DaysSupply, otherT.DaysSupply)) return false;
            if (!DeepComparable.IsExactly(WhenPreparedElement, otherT.WhenPreparedElement)) return false;
            if (!DeepComparable.IsExactly(WhenHandedOverElement, otherT.WhenHandedOverElement)) return false;
            if (!DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
            if (!DeepComparable.IsExactly(Receiver, otherT.Receiver)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(DosageInstruction, otherT.DosageInstruction)) return false;
            if (!DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;
            if (!DeepComparable.IsExactly(DetectedIssue, otherT.DetectedIssue)) return false;
            if (!DeepComparable.IsExactly(NotDoneElement, otherT.NotDoneElement)) return false;
            if (!DeepComparable.IsExactly(NotDoneReason, otherT.NotDoneReason)) return false;
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
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (Category != null) yield return Category;
                if (Medication != null) yield return Medication;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                foreach (var elem in AuthorizingPrescription) { if (elem != null) yield return elem; }
                if (Type != null) yield return Type;
                if (Quantity != null) yield return Quantity;
                if (DaysSupply != null) yield return DaysSupply;
                if (WhenPreparedElement != null) yield return WhenPreparedElement;
                if (WhenHandedOverElement != null) yield return WhenHandedOverElement;
                if (Destination != null) yield return Destination;
                foreach (var elem in Receiver) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in DosageInstruction) { if (elem != null) yield return elem; }
                if (Substitution != null) yield return Substitution;
                foreach (var elem in DetectedIssue) { if (elem != null) yield return elem; }
                if (NotDoneElement != null) yield return NotDoneElement;
                if (NotDoneReason != null) yield return NotDoneReason;
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
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Category != null) yield return new ElementValue("category", Category);
                if (Medication != null) yield return new ElementValue("medication", Medication);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", elem); }
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                foreach (var elem in AuthorizingPrescription) { if (elem != null) yield return new ElementValue("authorizingPrescription", elem); }
                if (Type != null) yield return new ElementValue("type", Type);
                if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                if (DaysSupply != null) yield return new ElementValue("daysSupply", DaysSupply);
                if (WhenPreparedElement != null) yield return new ElementValue("whenPrepared", WhenPreparedElement);
                if (WhenHandedOverElement != null) yield return new ElementValue("whenHandedOver", WhenHandedOverElement);
                if (Destination != null) yield return new ElementValue("destination", Destination);
                foreach (var elem in Receiver) { if (elem != null) yield return new ElementValue("receiver", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in DosageInstruction) { if (elem != null) yield return new ElementValue("dosageInstruction", elem); }
                if (Substitution != null) yield return new ElementValue("substitution", Substitution);
                foreach (var elem in DetectedIssue) { if (elem != null) yield return new ElementValue("detectedIssue", elem); }
                if (NotDoneElement != null) yield return new ElementValue("notDone", NotDoneElement);
                if (NotDoneReason != null) yield return new ElementValue("notDoneReason", NotDoneReason);
                foreach (var elem in EventHistory) { if (elem != null) yield return new ElementValue("eventHistory", elem); }
            }
        }

    }

}
