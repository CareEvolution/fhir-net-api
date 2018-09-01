using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Administration of medication to a patient
    /// </summary>
    [FhirType("MedicationAdministration", IsResource=true)]
    [DataContract]
    public partial class MedicationAdministration : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationAdministration; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationAdministration"; } }

        /// <summary>
        /// A set of codes indicating the current status of a MedicationAdministration.
        /// (url: http://hl7.org/fhir/ValueSet/medication-admin-status)
        /// </summary>
        [FhirEnumeration("MedicationAdministrationStatus")]
        public enum MedicationAdministrationStatus
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-admin-status)
            /// </summary>
            [EnumLiteral("in-progress", "http://hl7.org/fhir/medication-admin-status"), Description("In Progress")]
            InProgress,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-admin-status)
            /// </summary>
            [EnumLiteral("on-hold", "http://hl7.org/fhir/medication-admin-status"), Description("On Hold")]
            OnHold,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-admin-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/medication-admin-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-admin-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/medication-admin-status"), Description("Entered in Error")]
            EnteredInError,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-admin-status)
            /// </summary>
            [EnumLiteral("stopped", "http://hl7.org/fhir/medication-admin-status"), Description("Stopped")]
            Stopped,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-admin-status)
            /// </summary>
            [EnumLiteral("unknown", "http://hl7.org/fhir/medication-admin-status"), Description("Unknown")]
            Unknown,
        }


        [FhirType("PerformerComponent")]
        [DataContract]
        public partial class PerformerComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "PerformerComponent"; } }

            /// <summary>
            /// Individual who was performing
            /// </summary>
            [FhirElement("actor", InSummary=true, Order=40)]
            [References("Practitioner","Patient","RelatedPerson","Device")]
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


        [FhirType("DosageComponent")]
        [DataContract]
        public partial class DosageComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DosageComponent"; } }

            /// <summary>
            /// Free text dosage instructions e.g. SIG
            /// </summary>
            [FhirElement("text", Order=40)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Free text dosage instructions e.g. SIG
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null;
                    else
                        TextElement = new FhirString(value);
                    OnPropertyChanged("Text");
                }
            }

            /// <summary>
            /// Body site administered to
            /// </summary>
            [FhirElement("site", Order=50)]
            [DataMember]
            public CodeableConcept Site
            {
                get { return _site; }
                set { _site = value; OnPropertyChanged("Site"); }
            }

            private CodeableConcept _site;

            /// <summary>
            /// Path of substance into body
            /// </summary>
            [FhirElement("route", Order=60)]
            [DataMember]
            public CodeableConcept Route
            {
                get { return _route; }
                set { _route = value; OnPropertyChanged("Route"); }
            }

            private CodeableConcept _route;

            /// <summary>
            /// How drug was administered
            /// </summary>
            [FhirElement("method", Order=70)]
            [DataMember]
            public CodeableConcept Method
            {
                get { return _method; }
                set { _method = value; OnPropertyChanged("Method"); }
            }

            private CodeableConcept _method;

            /// <summary>
            /// Amount of medication per dose
            /// </summary>
            [FhirElement("dose", Order=80)]
            [DataMember]
            public SimpleQuantity Dose
            {
                get { return _dose; }
                set { _dose = value; OnPropertyChanged("Dose"); }
            }

            private SimpleQuantity _dose;

            /// <summary>
            /// Dose quantity per unit of time
            /// </summary>
            [FhirElement("rate", Order=90, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Ratio),typeof(SimpleQuantity))]
            [DataMember]
            public Element Rate
            {
                get { return _rate; }
                set { _rate = value; OnPropertyChanged("Rate"); }
            }

            private Element _rate;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DosageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    if (Site != null) dest.Site = (CodeableConcept)Site.DeepCopy();
                    if (Route != null) dest.Route = (CodeableConcept)Route.DeepCopy();
                    if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                    if (Dose != null) dest.Dose = (SimpleQuantity)Dose.DeepCopy();
                    if (Rate != null) dest.Rate = (Element)Rate.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DosageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DosageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.Matches(Site, otherT.Site)) return false;
                if (!DeepComparable.Matches(Route, otherT.Route)) return false;
                if (!DeepComparable.Matches(Method, otherT.Method)) return false;
                if (!DeepComparable.Matches(Dose, otherT.Dose)) return false;
                if (!DeepComparable.Matches(Rate, otherT.Rate)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DosageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                if (!DeepComparable.IsExactly(Site, otherT.Site)) return false;
                if (!DeepComparable.IsExactly(Route, otherT.Route)) return false;
                if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
                if (!DeepComparable.IsExactly(Dose, otherT.Dose)) return false;
                if (!DeepComparable.IsExactly(Rate, otherT.Rate)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TextElement != null) yield return TextElement;
                    if (Site != null) yield return Site;
                    if (Route != null) yield return Route;
                    if (Method != null) yield return Method;
                    if (Dose != null) yield return Dose;
                    if (Rate != null) yield return Rate;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                    if (Site != null) yield return new ElementValue("site", Site);
                    if (Route != null) yield return new ElementValue("route", Route);
                    if (Method != null) yield return new ElementValue("method", Method);
                    if (Dose != null) yield return new ElementValue("dose", Dose);
                    if (Rate != null) yield return new ElementValue("rate", Rate);
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
        /// Instantiates protocol or definition
        /// </summary>
        [FhirElement("definition", InSummary=true, Order=100)]
        [References("PlanDefinition","ActivityDefinition")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Definition
        {
            get { if (_definition==null) _definition = new List<ResourceReference>(); return _definition; }
            set { _definition = value; OnPropertyChanged("Definition"); }
        }

        private List<ResourceReference> _definition;

        /// <summary>
        /// Part of referenced event
        /// </summary>
        [FhirElement("partOf", InSummary=true, Order=110)]
        [References("MedicationAdministration","Procedure")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// in-progress | on-hold | completed | entered-in-error | stopped | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<MedicationAdministrationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<MedicationAdministrationStatus> _statusElement;

        /// <summary>
        /// in-progress | on-hold | completed | entered-in-error | stopped | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public MedicationAdministrationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<MedicationAdministrationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Type of medication usage
        /// </summary>
        [FhirElement("category", Order=130)]
        [DataMember]
        public CodeableConcept Category
        {
            get { return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private CodeableConcept _category;

        /// <summary>
        /// What was administered
        /// </summary>
        [FhirElement("medication", InSummary=true, Order=140, Choice=ChoiceType.DatatypeChoice)]
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
        /// Who received medication
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=150)]
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
        /// Encounter or Episode of Care administered as part of
        /// </summary>
        [FhirElement("context", Order=160)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// Additional information to support administration
        /// </summary>
        [FhirElement("supportingInformation", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> SupportingInformation
        {
            get { if (_supportingInformation==null) _supportingInformation = new List<ResourceReference>(); return _supportingInformation; }
            set { _supportingInformation = value; OnPropertyChanged("SupportingInformation"); }
        }

        private List<ResourceReference> _supportingInformation;

        /// <summary>
        /// Start and end time of administration
        /// </summary>
        [FhirElement("effective", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Effective
        {
            get { return _effective; }
            set { _effective = value; OnPropertyChanged("Effective"); }
        }

        private Element _effective;

        /// <summary>
        /// Who administered substance
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PerformerComponent> Performer
        {
            get { if (_performer==null) _performer = new List<PerformerComponent>(); return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private List<PerformerComponent> _performer;

        /// <summary>
        /// True if medication not administered
        /// </summary>
        [FhirElement("notGiven", InSummary=true, Order=200)]
        [DataMember]
        public FhirBoolean NotGivenElement
        {
            get { return _notGivenElement; }
            set { _notGivenElement = value; OnPropertyChanged("NotGivenElement"); }
        }

        private FhirBoolean _notGivenElement;

        /// <summary>
        /// True if medication not administered
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? NotGiven
        {
            get { return NotGivenElement != null ? NotGivenElement.Value : null; }
            set
            {
                if (value == null)
                    NotGivenElement = null;
                else
                    NotGivenElement = new FhirBoolean(value);
                OnPropertyChanged("NotGiven");
            }
        }

        /// <summary>
        /// Reason administration not performed
        /// </summary>
        [FhirElement("reasonNotGiven", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonNotGiven
        {
            get { if (_reasonNotGiven==null) _reasonNotGiven = new List<CodeableConcept>(); return _reasonNotGiven; }
            set { _reasonNotGiven = value; OnPropertyChanged("ReasonNotGiven"); }
        }

        private List<CodeableConcept> _reasonNotGiven;

        /// <summary>
        /// Reason administration performed
        /// </summary>
        [FhirElement("reasonCode", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ReasonCode
        {
            get { if (_reasonCode==null) _reasonCode = new List<CodeableConcept>(); return _reasonCode; }
            set { _reasonCode = value; OnPropertyChanged("ReasonCode"); }
        }

        private List<CodeableConcept> _reasonCode;

        /// <summary>
        /// Condition or Observation that supports why the medication was administered
        /// </summary>
        [FhirElement("reasonReference", Order=230)]
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
        /// Request administration performed against
        /// </summary>
        [FhirElement("prescription", Order=240)]
        [References("MedicationRequest")]
        [DataMember]
        public ResourceReference Prescription
        {
            get { return _prescription; }
            set { _prescription = value; OnPropertyChanged("Prescription"); }
        }

        private ResourceReference _prescription;

        /// <summary>
        /// Device used to administer
        /// </summary>
        [FhirElement("device", Order=250)]
        [References("Device")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Device
        {
            get { if (_device==null) _device = new List<ResourceReference>(); return _device; }
            set { _device = value; OnPropertyChanged("Device"); }
        }

        private List<ResourceReference> _device;

        /// <summary>
        /// Information about the administration
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
        /// Details of how medication was taken
        /// </summary>
        [FhirElement("dosage", Order=270)]
        [DataMember]
        public DosageComponent Dosage
        {
            get { return _dosage; }
            set { _dosage = value; OnPropertyChanged("Dosage"); }
        }

        private DosageComponent _dosage;

        /// <summary>
        /// A list of events of interest in the lifecycle
        /// </summary>
        [FhirElement("eventHistory", Order=280)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> EventHistory
        {
            get { if (_eventHistory==null) _eventHistory = new List<ResourceReference>(); return _eventHistory; }
            set { _eventHistory = value; OnPropertyChanged("EventHistory"); }
        }

        private List<ResourceReference> _eventHistory;


        public static ElementDefinition.ConstraintComponent MedicationAdministration_MAD_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "reasonNotGiven.empty() or notGiven = true",
            Key = "mad-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Reason not given is only permitted if NotGiven is true",
            Xpath = "not(exists(f:reasonNotGiven) and f:notGiven/@value=false())"
        };

        public static ElementDefinition.ConstraintComponent MedicationAdministration_MAD_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "reasonCode.empty() or notGiven.empty() or notGiven = 'false'",
            Key = "mad-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Reason given is only permitted if NotGiven is false",
            Xpath = "not(exists(f:reasonCode) and f:notGiven/@value=true())"
        };

        public static ElementDefinition.ConstraintComponent MedicationAdministration_MAD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "dosage.all(dose.exists() or rate.exists())",
            Key = "mad-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "SHALL have at least one of dosage.dose or dosage.rate[x]",
            Xpath = "exists(f:dose) or exists(f:*[starts-with(local-name(.), 'rate')])"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(MedicationAdministration_MAD_2);
            InvariantConstraints.Add(MedicationAdministration_MAD_3);
            InvariantConstraints.Add(MedicationAdministration_MAD_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationAdministration;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Definition != null) dest.Definition = new List<ResourceReference>(Definition.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<MedicationAdministrationStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = (CodeableConcept)Category.DeepCopy();
                if (Medication != null) dest.Medication = (Element)Medication.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (SupportingInformation != null) dest.SupportingInformation = new List<ResourceReference>(SupportingInformation.DeepCopy());
                if (Effective != null) dest.Effective = (Element)Effective.DeepCopy();
                if (Performer != null) dest.Performer = new List<PerformerComponent>(Performer.DeepCopy());
                if (NotGivenElement != null) dest.NotGivenElement = (FhirBoolean)NotGivenElement.DeepCopy();
                if (ReasonNotGiven != null) dest.ReasonNotGiven = new List<CodeableConcept>(ReasonNotGiven.DeepCopy());
                if (ReasonCode != null) dest.ReasonCode = new List<CodeableConcept>(ReasonCode.DeepCopy());
                if (ReasonReference != null) dest.ReasonReference = new List<ResourceReference>(ReasonReference.DeepCopy());
                if (Prescription != null) dest.Prescription = (ResourceReference)Prescription.DeepCopy();
                if (Device != null) dest.Device = new List<ResourceReference>(Device.DeepCopy());
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Dosage != null) dest.Dosage = (DosageComponent)Dosage.DeepCopy();
                if (EventHistory != null) dest.EventHistory = new List<ResourceReference>(EventHistory.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationAdministration());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationAdministration;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Medication, otherT.Medication)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if ( !DeepComparable.Matches(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;
            if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(NotGivenElement, otherT.NotGivenElement)) return false;
            if ( !DeepComparable.Matches(ReasonNotGiven, otherT.ReasonNotGiven)) return false;
            if ( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if ( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.Matches(Prescription, otherT.Prescription)) return false;
            if ( !DeepComparable.Matches(Device, otherT.Device)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if (!DeepComparable.Matches(Dosage, otherT.Dosage)) return false;
            if ( !DeepComparable.Matches(EventHistory, otherT.EventHistory)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationAdministration;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(SupportingInformation, otherT.SupportingInformation)) return false;
            if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(NotGivenElement, otherT.NotGivenElement)) return false;
            if (!DeepComparable.IsExactly(ReasonNotGiven, otherT.ReasonNotGiven)) return false;
            if (!DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if (!DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if (!DeepComparable.IsExactly(Prescription, otherT.Prescription)) return false;
            if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;
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
                foreach (var elem in Definition) { if (elem != null) yield return elem; }
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (Category != null) yield return Category;
                if (Medication != null) yield return Medication;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                foreach (var elem in SupportingInformation) { if (elem != null) yield return elem; }
                if (Effective != null) yield return Effective;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                if (NotGivenElement != null) yield return NotGivenElement;
                foreach (var elem in ReasonNotGiven) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                if (Prescription != null) yield return Prescription;
                foreach (var elem in Device) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                if (Dosage != null) yield return Dosage;
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
                foreach (var elem in Definition) { if (elem != null) yield return new ElementValue("definition", elem); }
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Category != null) yield return new ElementValue("category", Category);
                if (Medication != null) yield return new ElementValue("medication", Medication);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                foreach (var elem in SupportingInformation) { if (elem != null) yield return new ElementValue("supportingInformation", elem); }
                if (Effective != null) yield return new ElementValue("effective", Effective);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                if (NotGivenElement != null) yield return new ElementValue("notGiven", NotGivenElement);
                foreach (var elem in ReasonNotGiven) { if (elem != null) yield return new ElementValue("reasonNotGiven", elem); }
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                if (Prescription != null) yield return new ElementValue("prescription", Prescription);
                foreach (var elem in Device) { if (elem != null) yield return new ElementValue("device", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                if (Dosage != null) yield return new ElementValue("dosage", Dosage);
                foreach (var elem in EventHistory) { if (elem != null) yield return new ElementValue("eventHistory", elem); }
            }
        }

    }

}
