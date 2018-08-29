using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.R4;
using Hl7.Fhir.Validation.R4;
using Hl7.Fhir.Utility;

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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// An interaction during which services are provided to the patient
    /// </summary>
    [FhirType("Encounter", IsResource=true)]
    [DataContract]
    public partial class Encounter : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Encounter; } }
        [NotMapped]
        public override string TypeName { get { return "Encounter"; } }


        [FhirType("StatusHistoryComponent")]
        [DataContract]
        public partial class StatusHistoryComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StatusHistoryComponent"; } }

            /// <summary>
            /// planned | arrived | triaged | in-progress | onleave | finished | cancelled +
            /// </summary>
            [FhirElement("status", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<EncounterStatus> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<EncounterStatus> _statusElement;

            /// <summary>
            /// planned | arrived | triaged | in-progress | onleave | finished | cancelled +
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public EncounterStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (value == null)
                        StatusElement = null;
                    else
                        StatusElement = new Code<EncounterStatus>(value);
                    OnPropertyChanged("Status");
                }
            }

            /// <summary>
            /// The time that the episode was in the specified status
            /// </summary>
            [FhirElement("period", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StatusHistoryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (StatusElement != null) dest.StatusElement = (Code<EncounterStatus>)StatusElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StatusHistoryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StatusHistoryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StatusHistoryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (StatusElement != null) yield return StatusElement;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                    if (Period != null) yield return new ElementValue("period", false, Period);
                }
            }


        }


        [FhirType("ClassHistoryComponent")]
        [DataContract]
        public partial class ClassHistoryComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ClassHistoryComponent"; } }

            /// <summary>
            /// inpatient | outpatient | ambulatory | emergency +
            /// </summary>
            [FhirElement("class", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Coding Class
            {
                get { return _class; }
                set { _class = value; OnPropertyChanged("Class"); }
            }

            private Coding _class;

            /// <summary>
            /// The time that the episode was in the specified class
            /// </summary>
            [FhirElement("period", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClassHistoryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Class != null) dest.Class = (Coding)Class.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ClassHistoryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ClassHistoryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Class, otherT.Class)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClassHistoryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Class, otherT.Class)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Class != null) yield return Class;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Class != null) yield return new ElementValue("class", false, Class);
                    if (Period != null) yield return new ElementValue("period", false, Period);
                }
            }


        }


        [FhirType("ParticipantComponent")]
        [DataContract]
        public partial class ParticipantComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParticipantComponent"; } }

            /// <summary>
            /// Role of participant in encounter
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Type
            {
                get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private List<CodeableConcept> _type;

            /// <summary>
            /// Period of time during the encounter that the participant participated
            /// </summary>
            [FhirElement("period", Order=50)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            /// <summary>
            /// Persons involved in the encounter other than the patient
            /// </summary>
            [FhirElement("individual", InSummary=true, Order=60)]
            [References("Practitioner","RelatedPerson")]
            [DataMember]
            public ResourceReference Individual
            {
                get { return _individual; }
                set { _individual = value; OnPropertyChanged("Individual"); }
            }

            private ResourceReference _individual;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParticipantComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (Individual != null) dest.Individual = (ResourceReference)Individual.DeepCopy();
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
                if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if (!DeepComparable.Matches(Individual, otherT.Individual)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParticipantComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(Individual, otherT.Individual)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Type) { if (elem != null) yield return elem; }
                    if (Period != null) yield return Period;
                    if (Individual != null) yield return Individual;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", true, elem); }
                    if (Period != null) yield return new ElementValue("period", false, Period);
                    if (Individual != null) yield return new ElementValue("individual", false, Individual);
                }
            }


        }


        [FhirType("DiagnosisComponent")]
        [DataContract]
        public partial class DiagnosisComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DiagnosisComponent"; } }

            /// <summary>
            /// Reason the encounter takes place (resource)
            /// </summary>
            [FhirElement("condition", InSummary=true, Order=40)]
            [References("Condition","Procedure")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Condition
            {
                get { return _condition; }
                set { _condition = value; OnPropertyChanged("Condition"); }
            }

            private ResourceReference _condition;

            /// <summary>
            /// Role that this diagnosis has within the encounter (e.g. admission, billing, discharge …)
            /// </summary>
            [FhirElement("role", Order=50)]
            [DataMember]
            public CodeableConcept Role
            {
                get { return _role; }
                set { _role = value; OnPropertyChanged("Role"); }
            }

            private CodeableConcept _role;

            /// <summary>
            /// Ranking of the diagnosis (for each role type)
            /// </summary>
            [FhirElement("rank", Order=60)]
            [DataMember]
            public PositiveInt RankElement
            {
                get { return _rankElement; }
                set { _rankElement = value; OnPropertyChanged("RankElement"); }
            }

            private PositiveInt _rankElement;

            /// <summary>
            /// Ranking of the diagnosis (for each role type)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Rank
            {
                get { return RankElement != null ? RankElement.Value : null; }
                set
                {
                    if (value == null)
                        RankElement = null;
                    else
                        RankElement = new PositiveInt(value);
                    OnPropertyChanged("Rank");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DiagnosisComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Condition != null) dest.Condition = (ResourceReference)Condition.DeepCopy();
                    if (Role != null) dest.Role = (CodeableConcept)Role.DeepCopy();
                    if (RankElement != null) dest.RankElement = (PositiveInt)RankElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DiagnosisComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DiagnosisComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Condition, otherT.Condition)) return false;
                if (!DeepComparable.Matches(Role, otherT.Role)) return false;
                if (!DeepComparable.Matches(RankElement, otherT.RankElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DiagnosisComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Condition, otherT.Condition)) return false;
                if (!DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if (!DeepComparable.IsExactly(RankElement, otherT.RankElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Condition != null) yield return Condition;
                    if (Role != null) yield return Role;
                    if (RankElement != null) yield return RankElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Condition != null) yield return new ElementValue("condition", false, Condition);
                    if (Role != null) yield return new ElementValue("role", false, Role);
                    if (RankElement != null) yield return new ElementValue("rank", false, RankElement);
                }
            }


        }


        [FhirType("HospitalizationComponent")]
        [DataContract]
        public partial class HospitalizationComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "HospitalizationComponent"; } }

            /// <summary>
            /// Pre-admission identifier
            /// </summary>
            [FhirElement("preAdmissionIdentifier", Order=40)]
            [DataMember]
            public Identifier PreAdmissionIdentifier
            {
                get { return _preAdmissionIdentifier; }
                set { _preAdmissionIdentifier = value; OnPropertyChanged("PreAdmissionIdentifier"); }
            }

            private Identifier _preAdmissionIdentifier;

            /// <summary>
            /// The location/organization from which the patient came before admission
            /// </summary>
            [FhirElement("origin", Order=50)]
            [References("Location","Organization")]
            [DataMember]
            public ResourceReference Origin
            {
                get { return _origin; }
                set { _origin = value; OnPropertyChanged("Origin"); }
            }

            private ResourceReference _origin;

            /// <summary>
            /// From where patient was admitted (physician referral, transfer)
            /// </summary>
            [FhirElement("admitSource", Order=60)]
            [DataMember]
            public CodeableConcept AdmitSource
            {
                get { return _admitSource; }
                set { _admitSource = value; OnPropertyChanged("AdmitSource"); }
            }

            private CodeableConcept _admitSource;

            /// <summary>
            /// The type of hospital re-admission that has occurred (if any). If the value is absent, then this is not identified as a readmission
            /// </summary>
            [FhirElement("reAdmission", Order=70)]
            [DataMember]
            public CodeableConcept ReAdmission
            {
                get { return _reAdmission; }
                set { _reAdmission = value; OnPropertyChanged("ReAdmission"); }
            }

            private CodeableConcept _reAdmission;

            /// <summary>
            /// Diet preferences reported by the patient
            /// </summary>
            [FhirElement("dietPreference", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> DietPreference
            {
                get { if (_dietPreference==null) _dietPreference = new List<CodeableConcept>(); return _dietPreference; }
                set { _dietPreference = value; OnPropertyChanged("DietPreference"); }
            }

            private List<CodeableConcept> _dietPreference;

            /// <summary>
            /// Special courtesies (VIP, board member)
            /// </summary>
            [FhirElement("specialCourtesy", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> SpecialCourtesy
            {
                get { if (_specialCourtesy==null) _specialCourtesy = new List<CodeableConcept>(); return _specialCourtesy; }
                set { _specialCourtesy = value; OnPropertyChanged("SpecialCourtesy"); }
            }

            private List<CodeableConcept> _specialCourtesy;

            /// <summary>
            /// Wheelchair, translator, stretcher, etc.
            /// </summary>
            [FhirElement("specialArrangement", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> SpecialArrangement
            {
                get { if (_specialArrangement==null) _specialArrangement = new List<CodeableConcept>(); return _specialArrangement; }
                set { _specialArrangement = value; OnPropertyChanged("SpecialArrangement"); }
            }

            private List<CodeableConcept> _specialArrangement;

            /// <summary>
            /// Location/organization to which the patient is discharged
            /// </summary>
            [FhirElement("destination", Order=110)]
            [References("Location","Organization")]
            [DataMember]
            public ResourceReference Destination
            {
                get { return _destination; }
                set { _destination = value; OnPropertyChanged("Destination"); }
            }

            private ResourceReference _destination;

            /// <summary>
            /// Category or kind of location after discharge
            /// </summary>
            [FhirElement("dischargeDisposition", Order=120)]
            [DataMember]
            public CodeableConcept DischargeDisposition
            {
                get { return _dischargeDisposition; }
                set { _dischargeDisposition = value; OnPropertyChanged("DischargeDisposition"); }
            }

            private CodeableConcept _dischargeDisposition;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as HospitalizationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PreAdmissionIdentifier != null) dest.PreAdmissionIdentifier = (Identifier)PreAdmissionIdentifier.DeepCopy();
                    if (Origin != null) dest.Origin = (ResourceReference)Origin.DeepCopy();
                    if (AdmitSource != null) dest.AdmitSource = (CodeableConcept)AdmitSource.DeepCopy();
                    if (ReAdmission != null) dest.ReAdmission = (CodeableConcept)ReAdmission.DeepCopy();
                    if (DietPreference != null) dest.DietPreference = new List<CodeableConcept>(DietPreference.DeepCopy());
                    if (SpecialCourtesy != null) dest.SpecialCourtesy = new List<CodeableConcept>(SpecialCourtesy.DeepCopy());
                    if (SpecialArrangement != null) dest.SpecialArrangement = new List<CodeableConcept>(SpecialArrangement.DeepCopy());
                    if (Destination != null) dest.Destination = (ResourceReference)Destination.DeepCopy();
                    if (DischargeDisposition != null) dest.DischargeDisposition = (CodeableConcept)DischargeDisposition.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new HospitalizationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as HospitalizationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(PreAdmissionIdentifier, otherT.PreAdmissionIdentifier)) return false;
                if (!DeepComparable.Matches(Origin, otherT.Origin)) return false;
                if (!DeepComparable.Matches(AdmitSource, otherT.AdmitSource)) return false;
                if (!DeepComparable.Matches(ReAdmission, otherT.ReAdmission)) return false;
                if ( !DeepComparable.Matches(DietPreference, otherT.DietPreference)) return false;
                if ( !DeepComparable.Matches(SpecialCourtesy, otherT.SpecialCourtesy)) return false;
                if ( !DeepComparable.Matches(SpecialArrangement, otherT.SpecialArrangement)) return false;
                if (!DeepComparable.Matches(Destination, otherT.Destination)) return false;
                if (!DeepComparable.Matches(DischargeDisposition, otherT.DischargeDisposition)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as HospitalizationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PreAdmissionIdentifier, otherT.PreAdmissionIdentifier)) return false;
                if (!DeepComparable.IsExactly(Origin, otherT.Origin)) return false;
                if (!DeepComparable.IsExactly(AdmitSource, otherT.AdmitSource)) return false;
                if (!DeepComparable.IsExactly(ReAdmission, otherT.ReAdmission)) return false;
                if (!DeepComparable.IsExactly(DietPreference, otherT.DietPreference)) return false;
                if (!DeepComparable.IsExactly(SpecialCourtesy, otherT.SpecialCourtesy)) return false;
                if (!DeepComparable.IsExactly(SpecialArrangement, otherT.SpecialArrangement)) return false;
                if (!DeepComparable.IsExactly(Destination, otherT.Destination)) return false;
                if (!DeepComparable.IsExactly(DischargeDisposition, otherT.DischargeDisposition)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PreAdmissionIdentifier != null) yield return PreAdmissionIdentifier;
                    if (Origin != null) yield return Origin;
                    if (AdmitSource != null) yield return AdmitSource;
                    if (ReAdmission != null) yield return ReAdmission;
                    foreach (var elem in DietPreference) { if (elem != null) yield return elem; }
                    foreach (var elem in SpecialCourtesy) { if (elem != null) yield return elem; }
                    foreach (var elem in SpecialArrangement) { if (elem != null) yield return elem; }
                    if (Destination != null) yield return Destination;
                    if (DischargeDisposition != null) yield return DischargeDisposition;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PreAdmissionIdentifier != null) yield return new ElementValue("preAdmissionIdentifier", false, PreAdmissionIdentifier);
                    if (Origin != null) yield return new ElementValue("origin", false, Origin);
                    if (AdmitSource != null) yield return new ElementValue("admitSource", false, AdmitSource);
                    if (ReAdmission != null) yield return new ElementValue("reAdmission", false, ReAdmission);
                    foreach (var elem in DietPreference) { if (elem != null) yield return new ElementValue("dietPreference", true, elem); }
                    foreach (var elem in SpecialCourtesy) { if (elem != null) yield return new ElementValue("specialCourtesy", true, elem); }
                    foreach (var elem in SpecialArrangement) { if (elem != null) yield return new ElementValue("specialArrangement", true, elem); }
                    if (Destination != null) yield return new ElementValue("destination", false, Destination);
                    if (DischargeDisposition != null) yield return new ElementValue("dischargeDisposition", false, DischargeDisposition);
                }
            }


        }


        [FhirType("LocationComponent")]
        [DataContract]
        public partial class LocationComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "LocationComponent"; } }

            /// <summary>
            /// Location the encounter takes place
            /// </summary>
            [FhirElement("location", Order=40)]
            [References("Location")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Location
            {
                get { return _location; }
                set { _location = value; OnPropertyChanged("Location"); }
            }

            private ResourceReference _location;

            /// <summary>
            /// planned | active | reserved | completed
            /// </summary>
            [FhirElement("status", Order=50)]
            [DataMember]
            public Code<EncounterLocationStatus> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<EncounterLocationStatus> _statusElement;

            /// <summary>
            /// planned | active | reserved | completed
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public EncounterLocationStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (value == null)
                        StatusElement = null;
                    else
                        StatusElement = new Code<EncounterLocationStatus>(value);
                    OnPropertyChanged("Status");
                }
            }

            /// <summary>
            /// Time period during which the patient was present at the location
            /// </summary>
            [FhirElement("period", Order=60)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as LocationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Location != null) dest.Location = (ResourceReference)Location.DeepCopy();
                    if (StatusElement != null) dest.StatusElement = (Code<EncounterLocationStatus>)StatusElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new LocationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as LocationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Location, otherT.Location)) return false;
                if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as LocationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
                if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Location != null) yield return Location;
                    if (StatusElement != null) yield return StatusElement;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Location != null) yield return new ElementValue("location", false, Location);
                    if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                    if (Period != null) yield return new ElementValue("period", false, Period);
                }
            }


        }


        /// <summary>
        /// Identifier(s) by which this encounter is known
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
        /// planned | arrived | triaged | in-progress | onleave | finished | cancelled +
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<EncounterStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<EncounterStatus> _statusElement;

        /// <summary>
        /// planned | arrived | triaged | in-progress | onleave | finished | cancelled +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public EncounterStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<EncounterStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// List of past encounter statuses
        /// </summary>
        [FhirElement("statusHistory", Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<StatusHistoryComponent> StatusHistory
        {
            get { if (_statusHistory==null) _statusHistory = new List<StatusHistoryComponent>(); return _statusHistory; }
            set { _statusHistory = value; OnPropertyChanged("StatusHistory"); }
        }

        private List<StatusHistoryComponent> _statusHistory;

        /// <summary>
        /// Classification of patient encounter
        /// </summary>
        [FhirElement("class", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Coding Class
        {
            get { return _class; }
            set { _class = value; OnPropertyChanged("Class"); }
        }

        private Coding _class;

        /// <summary>
        /// List of past encounter classes
        /// </summary>
        [FhirElement("classHistory", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ClassHistoryComponent> ClassHistory
        {
            get { if (_classHistory==null) _classHistory = new List<ClassHistoryComponent>(); return _classHistory; }
            set { _classHistory = value; OnPropertyChanged("ClassHistory"); }
        }

        private List<ClassHistoryComponent> _classHistory;

        /// <summary>
        /// Specific type of encounter
        /// </summary>
        [FhirElement("type", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Type
        {
            get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private List<CodeableConcept> _type;

        /// <summary>
        /// Specific type of service
        /// </summary>
        [FhirElement("serviceType", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; OnPropertyChanged("ServiceType"); }
        }

        private CodeableConcept _serviceType;

        /// <summary>
        /// Indicates the urgency of the encounter
        /// </summary>
        [FhirElement("priority", Order=160)]
        [DataMember]
        public CodeableConcept Priority
        {
            get { return _priority; }
            set { _priority = value; OnPropertyChanged("Priority"); }
        }

        private CodeableConcept _priority;

        /// <summary>
        /// The patient or group present at the encounter
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=170)]
        [References("Patient","Group")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Episode(s) of care that this encounter should be recorded against
        /// </summary>
        [FhirElement("episodeOfCare", InSummary=true, Order=180)]
        [References("EpisodeOfCare")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> EpisodeOfCare
        {
            get { if (_episodeOfCare==null) _episodeOfCare = new List<ResourceReference>(); return _episodeOfCare; }
            set { _episodeOfCare = value; OnPropertyChanged("EpisodeOfCare"); }
        }

        private List<ResourceReference> _episodeOfCare;

        /// <summary>
        /// The ServiceRequest that initiated this encounter
        /// </summary>
        [FhirElement("basedOn", Order=190)]
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
        /// List of participants involved in the encounter
        /// </summary>
        [FhirElement("participant", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParticipantComponent> Participant
        {
            get { if (_participant==null) _participant = new List<ParticipantComponent>(); return _participant; }
            set { _participant = value; OnPropertyChanged("Participant"); }
        }

        private List<ParticipantComponent> _participant;

        /// <summary>
        /// The appointment that scheduled this encounter
        /// </summary>
        [FhirElement("appointment", InSummary=true, Order=210)]
        [References("Appointment")]
        [DataMember]
        public ResourceReference Appointment
        {
            get { return _appointment; }
            set { _appointment = value; OnPropertyChanged("Appointment"); }
        }

        private ResourceReference _appointment;

        /// <summary>
        /// The start and end time of the encounter
        /// </summary>
        [FhirElement("period", Order=220)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Quantity of time the encounter lasted (less time absent)
        /// </summary>
        [FhirElement("length", Order=230)]
        [DataMember]
        public Duration Length
        {
            get { return _length; }
            set { _length = value; OnPropertyChanged("Length"); }
        }

        private Duration _length;

        /// <summary>
        /// Reason the encounter takes place (code)
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Reason
        {
            get { if (_reason==null) _reason = new List<CodeableConcept>(); return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private List<CodeableConcept> _reason;

        /// <summary>
        /// The list of diagnosis relevant to this encounter
        /// </summary>
        [FhirElement("diagnosis", InSummary=true, Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DiagnosisComponent> Diagnosis
        {
            get { if (_diagnosis==null) _diagnosis = new List<DiagnosisComponent>(); return _diagnosis; }
            set { _diagnosis = value; OnPropertyChanged("Diagnosis"); }
        }

        private List<DiagnosisComponent> _diagnosis;

        /// <summary>
        /// The set of accounts that may be used for billing for this Encounter
        /// </summary>
        [FhirElement("account", Order=260)]
        [References("Account")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Account
        {
            get { if (_account==null) _account = new List<ResourceReference>(); return _account; }
            set { _account = value; OnPropertyChanged("Account"); }
        }

        private List<ResourceReference> _account;

        /// <summary>
        /// Details about the admission to a healthcare service
        /// </summary>
        [FhirElement("hospitalization", Order=270)]
        [DataMember]
        public HospitalizationComponent Hospitalization
        {
            get { return _hospitalization; }
            set { _hospitalization = value; OnPropertyChanged("Hospitalization"); }
        }

        private HospitalizationComponent _hospitalization;

        /// <summary>
        /// List of locations where the patient has been
        /// </summary>
        [FhirElement("location", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<LocationComponent> Location
        {
            get { if (_location==null) _location = new List<LocationComponent>(); return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private List<LocationComponent> _location;

        /// <summary>
        /// The organization (facility) responsible for this encounter
        /// </summary>
        [FhirElement("serviceProvider", Order=290)]
        [References("Organization")]
        [DataMember]
        public ResourceReference ServiceProvider
        {
            get { return _serviceProvider; }
            set { _serviceProvider = value; OnPropertyChanged("ServiceProvider"); }
        }

        private ResourceReference _serviceProvider;

        /// <summary>
        /// Another Encounter this encounter is part of
        /// </summary>
        [FhirElement("partOf", Order=300)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference PartOf
        {
            get { return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private ResourceReference _partOf;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Encounter;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<EncounterStatus>)StatusElement.DeepCopy();
                if (StatusHistory != null) dest.StatusHistory = new List<StatusHistoryComponent>(StatusHistory.DeepCopy());
                if (Class != null) dest.Class = (Coding)Class.DeepCopy();
                if (ClassHistory != null) dest.ClassHistory = new List<ClassHistoryComponent>(ClassHistory.DeepCopy());
                if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                if (ServiceType != null) dest.ServiceType = (CodeableConcept)ServiceType.DeepCopy();
                if (Priority != null) dest.Priority = (CodeableConcept)Priority.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (EpisodeOfCare != null) dest.EpisodeOfCare = new List<ResourceReference>(EpisodeOfCare.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (Participant != null) dest.Participant = new List<ParticipantComponent>(Participant.DeepCopy());
                if (Appointment != null) dest.Appointment = (ResourceReference)Appointment.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Length != null) dest.Length = (Duration)Length.DeepCopy();
                if (Reason != null) dest.Reason = new List<CodeableConcept>(Reason.DeepCopy());
                if (Diagnosis != null) dest.Diagnosis = new List<DiagnosisComponent>(Diagnosis.DeepCopy());
                if (Account != null) dest.Account = new List<ResourceReference>(Account.DeepCopy());
                if (Hospitalization != null) dest.Hospitalization = (HospitalizationComponent)Hospitalization.DeepCopy();
                if (Location != null) dest.Location = new List<LocationComponent>(Location.DeepCopy());
                if (ServiceProvider != null) dest.ServiceProvider = (ResourceReference)ServiceProvider.DeepCopy();
                if (PartOf != null) dest.PartOf = (ResourceReference)PartOf.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Encounter());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Encounter;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(StatusHistory, otherT.StatusHistory)) return false;
            if (!DeepComparable.Matches(Class, otherT.Class)) return false;
            if ( !DeepComparable.Matches(ClassHistory, otherT.ClassHistory)) return false;
            if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(ServiceType, otherT.ServiceType)) return false;
            if (!DeepComparable.Matches(Priority, otherT.Priority)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(EpisodeOfCare, otherT.EpisodeOfCare)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
            if (!DeepComparable.Matches(Appointment, otherT.Appointment)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(Length, otherT.Length)) return false;
            if ( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if ( !DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
            if ( !DeepComparable.Matches(Account, otherT.Account)) return false;
            if (!DeepComparable.Matches(Hospitalization, otherT.Hospitalization)) return false;
            if ( !DeepComparable.Matches(Location, otherT.Location)) return false;
            if (!DeepComparable.Matches(ServiceProvider, otherT.ServiceProvider)) return false;
            if (!DeepComparable.Matches(PartOf, otherT.PartOf)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Encounter;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusHistory, otherT.StatusHistory)) return false;
            if (!DeepComparable.IsExactly(Class, otherT.Class)) return false;
            if (!DeepComparable.IsExactly(ClassHistory, otherT.ClassHistory)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(ServiceType, otherT.ServiceType)) return false;
            if (!DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(EpisodeOfCare, otherT.EpisodeOfCare)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
            if (!DeepComparable.IsExactly(Appointment, otherT.Appointment)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Length, otherT.Length)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
            if (!DeepComparable.IsExactly(Account, otherT.Account)) return false;
            if (!DeepComparable.IsExactly(Hospitalization, otherT.Hospitalization)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(ServiceProvider, otherT.ServiceProvider)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;

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
                foreach (var elem in StatusHistory) { if (elem != null) yield return elem; }
                if (Class != null) yield return Class;
                foreach (var elem in ClassHistory) { if (elem != null) yield return elem; }
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                if (ServiceType != null) yield return ServiceType;
                if (Priority != null) yield return Priority;
                if (Subject != null) yield return Subject;
                foreach (var elem in EpisodeOfCare) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in Participant) { if (elem != null) yield return elem; }
                if (Appointment != null) yield return Appointment;
                if (Period != null) yield return Period;
                if (Length != null) yield return Length;
                foreach (var elem in Reason) { if (elem != null) yield return elem; }
                foreach (var elem in Diagnosis) { if (elem != null) yield return elem; }
                foreach (var elem in Account) { if (elem != null) yield return elem; }
                if (Hospitalization != null) yield return Hospitalization;
                foreach (var elem in Location) { if (elem != null) yield return elem; }
                if (ServiceProvider != null) yield return ServiceProvider;
                if (PartOf != null) yield return PartOf;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                foreach (var elem in StatusHistory) { if (elem != null) yield return new ElementValue("statusHistory", true, elem); }
                if (Class != null) yield return new ElementValue("class", false, Class);
                foreach (var elem in ClassHistory) { if (elem != null) yield return new ElementValue("classHistory", true, elem); }
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", true, elem); }
                if (ServiceType != null) yield return new ElementValue("serviceType", false, ServiceType);
                if (Priority != null) yield return new ElementValue("priority", false, Priority);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                foreach (var elem in EpisodeOfCare) { if (elem != null) yield return new ElementValue("episodeOfCare", true, elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", true, elem); }
                foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", true, elem); }
                if (Appointment != null) yield return new ElementValue("appointment", false, Appointment);
                if (Period != null) yield return new ElementValue("period", false, Period);
                if (Length != null) yield return new ElementValue("length", false, Length);
                foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", true, elem); }
                foreach (var elem in Diagnosis) { if (elem != null) yield return new ElementValue("diagnosis", true, elem); }
                foreach (var elem in Account) { if (elem != null) yield return new ElementValue("account", true, elem); }
                if (Hospitalization != null) yield return new ElementValue("hospitalization", false, Hospitalization);
                foreach (var elem in Location) { if (elem != null) yield return new ElementValue("location", true, elem); }
                if (ServiceProvider != null) yield return new ElementValue("serviceProvider", false, ServiceProvider);
                if (PartOf != null) yield return new ElementValue("partOf", false, PartOf);
            }
        }

    }

}
