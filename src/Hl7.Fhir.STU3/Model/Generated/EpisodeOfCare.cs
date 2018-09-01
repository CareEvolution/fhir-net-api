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
    /// An association of a Patient with an Organization and  Healthcare Provider(s) for a period of time that the Organization assumes some level of responsibility
    /// </summary>
    [FhirType("EpisodeOfCare", IsResource=true)]
    [DataContract]
    public partial class EpisodeOfCare : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.EpisodeOfCare; } }
        [NotMapped]
        public override string TypeName { get { return "EpisodeOfCare"; } }


        [FhirType("StatusHistoryComponent")]
        [DataContract]
        public partial class StatusHistoryComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "StatusHistoryComponent"; } }

            /// <summary>
            /// planned | waitlist | active | onhold | finished | cancelled | entered-in-error
            /// </summary>
            [FhirElement("status", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<EpisodeOfCareStatus> StatusElement
            {
                get { return _statusElement; }
                set { _statusElement = value; OnPropertyChanged("StatusElement"); }
            }

            private Code<EpisodeOfCareStatus> _statusElement;

            /// <summary>
            /// planned | waitlist | active | onhold | finished | cancelled | entered-in-error
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public EpisodeOfCareStatus? Status
            {
                get { return StatusElement != null ? StatusElement.Value : null; }
                set
                {
                    if (value == null)
                        StatusElement = null;
                    else
                        StatusElement = new Code<EpisodeOfCareStatus>(value);
                    OnPropertyChanged("Status");
                }
            }

            /// <summary>
            /// Duration the EpisodeOfCare was in the specified status
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
                    if (StatusElement != null) dest.StatusElement = (Code<EpisodeOfCareStatus>)StatusElement.DeepCopy();
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
                    if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }


        }


        [FhirType("DiagnosisComponent")]
        [DataContract]
        public partial class DiagnosisComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "DiagnosisComponent"; } }

            /// <summary>
            /// Conditions/problems/diagnoses this episode of care is for
            /// </summary>
            [FhirElement("condition", InSummary=true, Order=40)]
            [References("Condition")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Condition
            {
                get { return _condition; }
                set { _condition = value; OnPropertyChanged("Condition"); }
            }

            private ResourceReference _condition;

            /// <summary>
            /// Role that this diagnosis has within the episode of care (e.g. admission, billing, discharge …)
            /// </summary>
            [FhirElement("role", InSummary=true, Order=50)]
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
            [FhirElement("rank", InSummary=true, Order=60)]
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
                    if (Condition != null) yield return new ElementValue("condition", Condition);
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (RankElement != null) yield return new ElementValue("rank", RankElement);
                }
            }


        }


        /// <summary>
        /// Business Identifier(s) relevant for this EpisodeOfCare
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
        /// planned | waitlist | active | onhold | finished | cancelled | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<EpisodeOfCareStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<EpisodeOfCareStatus> _statusElement;

        /// <summary>
        /// planned | waitlist | active | onhold | finished | cancelled | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public EpisodeOfCareStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<EpisodeOfCareStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Past list of status codes (the current status may be included to cover the start date of the status)
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
        /// Type/class  - e.g. specialist referral, disease management
        /// </summary>
        [FhirElement("type", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Type
        {
            get { if (_type==null) _type = new List<CodeableConcept>(); return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private List<CodeableConcept> _type;

        /// <summary>
        /// The list of diagnosis relevant to this episode of care
        /// </summary>
        [FhirElement("diagnosis", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DiagnosisComponent> Diagnosis
        {
            get { if (_diagnosis==null) _diagnosis = new List<DiagnosisComponent>(); return _diagnosis; }
            set { _diagnosis = value; OnPropertyChanged("Diagnosis"); }
        }

        private List<DiagnosisComponent> _diagnosis;

        /// <summary>
        /// The patient who is the focus of this episode of care
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=140)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged("Patient"); }
        }

        private ResourceReference _patient;

        /// <summary>
        /// Organization that assumes care
        /// </summary>
        [FhirElement("managingOrganization", InSummary=true, Order=150)]
        [References("Organization")]
        [DataMember]
        public ResourceReference ManagingOrganization
        {
            get { return _managingOrganization; }
            set { _managingOrganization = value; OnPropertyChanged("ManagingOrganization"); }
        }

        private ResourceReference _managingOrganization;

        /// <summary>
        /// Interval during responsibility is assumed
        /// </summary>
        [FhirElement("period", InSummary=true, Order=160)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Originating Referral Request(s)
        /// </summary>
        [FhirElement("referralRequest", Order=170)]
        [References("ReferralRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> ReferralRequest
        {
            get { if (_referralRequest==null) _referralRequest = new List<ResourceReference>(); return _referralRequest; }
            set { _referralRequest = value; OnPropertyChanged("ReferralRequest"); }
        }

        private List<ResourceReference> _referralRequest;

        /// <summary>
        /// Care manager/care co-ordinator for the patient
        /// </summary>
        [FhirElement("careManager", Order=180)]
        [References("Practitioner")]
        [DataMember]
        public ResourceReference CareManager
        {
            get { return _careManager; }
            set { _careManager = value; OnPropertyChanged("CareManager"); }
        }

        private ResourceReference _careManager;

        /// <summary>
        /// Other practitioners facilitating this episode of care
        /// </summary>
        [FhirElement("team", Order=190)]
        [References("CareTeam")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Team
        {
            get { if (_team==null) _team = new List<ResourceReference>(); return _team; }
            set { _team = value; OnPropertyChanged("Team"); }
        }

        private List<ResourceReference> _team;

        /// <summary>
        /// The set of accounts that may be used for billing for this EpisodeOfCare
        /// </summary>
        [FhirElement("account", Order=200)]
        [References("Account")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Account
        {
            get { if (_account==null) _account = new List<ResourceReference>(); return _account; }
            set { _account = value; OnPropertyChanged("Account"); }
        }

        private List<ResourceReference> _account;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as EpisodeOfCare;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<EpisodeOfCareStatus>)StatusElement.DeepCopy();
                if (StatusHistory != null) dest.StatusHistory = new List<StatusHistoryComponent>(StatusHistory.DeepCopy());
                if (Type != null) dest.Type = new List<CodeableConcept>(Type.DeepCopy());
                if (Diagnosis != null) dest.Diagnosis = new List<DiagnosisComponent>(Diagnosis.DeepCopy());
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (ManagingOrganization != null) dest.ManagingOrganization = (ResourceReference)ManagingOrganization.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (ReferralRequest != null) dest.ReferralRequest = new List<ResourceReference>(ReferralRequest.DeepCopy());
                if (CareManager != null) dest.CareManager = (ResourceReference)CareManager.DeepCopy();
                if (Team != null) dest.Team = new List<ResourceReference>(Team.DeepCopy());
                if (Account != null) dest.Account = new List<ResourceReference>(Account.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new EpisodeOfCare());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as EpisodeOfCare;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(StatusHistory, otherT.StatusHistory)) return false;
            if ( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if ( !DeepComparable.Matches(Diagnosis, otherT.Diagnosis)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if ( !DeepComparable.Matches(ReferralRequest, otherT.ReferralRequest)) return false;
            if (!DeepComparable.Matches(CareManager, otherT.CareManager)) return false;
            if ( !DeepComparable.Matches(Team, otherT.Team)) return false;
            if ( !DeepComparable.Matches(Account, otherT.Account)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as EpisodeOfCare;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusHistory, otherT.StatusHistory)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Diagnosis, otherT.Diagnosis)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(ManagingOrganization, otherT.ManagingOrganization)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(ReferralRequest, otherT.ReferralRequest)) return false;
            if (!DeepComparable.IsExactly(CareManager, otherT.CareManager)) return false;
            if (!DeepComparable.IsExactly(Team, otherT.Team)) return false;
            if (!DeepComparable.IsExactly(Account, otherT.Account)) return false;

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
                foreach (var elem in Type) { if (elem != null) yield return elem; }
                foreach (var elem in Diagnosis) { if (elem != null) yield return elem; }
                if (Patient != null) yield return Patient;
                if (ManagingOrganization != null) yield return ManagingOrganization;
                if (Period != null) yield return Period;
                foreach (var elem in ReferralRequest) { if (elem != null) yield return elem; }
                if (CareManager != null) yield return CareManager;
                foreach (var elem in Team) { if (elem != null) yield return elem; }
                foreach (var elem in Account) { if (elem != null) yield return elem; }
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
                foreach (var elem in StatusHistory) { if (elem != null) yield return new ElementValue("statusHistory", elem); }
                foreach (var elem in Type) { if (elem != null) yield return new ElementValue("type", elem); }
                foreach (var elem in Diagnosis) { if (elem != null) yield return new ElementValue("diagnosis", elem); }
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (ManagingOrganization != null) yield return new ElementValue("managingOrganization", ManagingOrganization);
                if (Period != null) yield return new ElementValue("period", Period);
                foreach (var elem in ReferralRequest) { if (elem != null) yield return new ElementValue("referralRequest", elem); }
                if (CareManager != null) yield return new ElementValue("careManager", CareManager);
                foreach (var elem in Team) { if (elem != null) yield return new ElementValue("team", elem); }
                foreach (var elem in Account) { if (elem != null) yield return new ElementValue("account", elem); }
            }
        }

    }

}
