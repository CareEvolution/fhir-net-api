﻿using System;
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
    /// Tracks balance, charges, for patient or cost center
    /// </summary>
    [FhirType("Account", IsResource=true)]
    [DataContract]
    public partial class Account : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Account; } }
        [NotMapped]
        public override string TypeName { get { return "Account"; } }


        [FhirType("CoverageComponent")]
        [DataContract]
        public partial class CoverageComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "CoverageComponent"; } }

            /// <summary>
            /// The party(s) that are responsible for covering the payment of this account
            /// </summary>
            [FhirElement("coverage", InSummary=true, Order=40)]
            [References("Coverage")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Coverage
            {
                get { return _coverage; }
                set { _coverage = value; OnPropertyChanged("Coverage"); }
            }

            private ResourceReference _coverage;

            /// <summary>
            /// The priority of the coverage in the context of this account
            /// </summary>
            [FhirElement("priority", InSummary=true, Order=50)]
            [DataMember]
            public PositiveInt PriorityElement
            {
                get { return _priorityElement; }
                set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
            }

            private PositiveInt _priorityElement;

            /// <summary>
            /// The priority of the coverage in the context of this account
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Priority
            {
                get { return PriorityElement != null ? PriorityElement.Value : null; }
                set
                {
                    if (value == null)
                        PriorityElement = null;
                    else
                        PriorityElement = new PositiveInt(value);
                    OnPropertyChanged("Priority");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CoverageComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Coverage != null) dest.Coverage = (ResourceReference)Coverage.DeepCopy();
                    if (PriorityElement != null) dest.PriorityElement = (PositiveInt)PriorityElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CoverageComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CoverageComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CoverageComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
                if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Coverage != null) yield return Coverage;
                    if (PriorityElement != null) yield return PriorityElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Coverage != null) yield return new ElementValue("coverage", false, Coverage);
                    if (PriorityElement != null) yield return new ElementValue("priority", false, PriorityElement);
                }
            }


        }


        [FhirType("GuarantorComponent")]
        [DataContract]
        public partial class GuarantorComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GuarantorComponent"; } }

            /// <summary>
            /// Responsible entity
            /// </summary>
            [FhirElement("party", Order=40)]
            [References("Patient","RelatedPerson","Organization")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Party
            {
                get { return _party; }
                set { _party = value; OnPropertyChanged("Party"); }
            }

            private ResourceReference _party;

            /// <summary>
            /// Credit or other hold applied
            /// </summary>
            [FhirElement("onHold", Order=50)]
            [DataMember]
            public FhirBoolean OnHoldElement
            {
                get { return _onHoldElement; }
                set { _onHoldElement = value; OnPropertyChanged("OnHoldElement"); }
            }

            private FhirBoolean _onHoldElement;

            /// <summary>
            /// Credit or other hold applied
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? OnHold
            {
                get { return OnHoldElement != null ? OnHoldElement.Value : null; }
                set
                {
                    if (value == null)
                        OnHoldElement = null;
                    else
                        OnHoldElement = new FhirBoolean(value);
                    OnPropertyChanged("OnHold");
                }
            }

            /// <summary>
            /// Guarantee account during
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
                var dest = other as GuarantorComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Party != null) dest.Party = (ResourceReference)Party.DeepCopy();
                    if (OnHoldElement != null) dest.OnHoldElement = (FhirBoolean)OnHoldElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GuarantorComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GuarantorComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Party, otherT.Party)) return false;
                if (!DeepComparable.Matches(OnHoldElement, otherT.OnHoldElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GuarantorComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Party, otherT.Party)) return false;
                if (!DeepComparable.IsExactly(OnHoldElement, otherT.OnHoldElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Party != null) yield return Party;
                    if (OnHoldElement != null) yield return OnHoldElement;
                    if (Period != null) yield return Period;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Party != null) yield return new ElementValue("party", false, Party);
                    if (OnHoldElement != null) yield return new ElementValue("onHold", false, OnHoldElement);
                    if (Period != null) yield return new ElementValue("period", false, Period);
                }
            }


        }


        /// <summary>
        /// Account number
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
        /// active | inactive | entered-in-error | on-hold | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<AccountStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<AccountStatus> _statusElement;

        /// <summary>
        /// active | inactive | entered-in-error | on-hold | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public AccountStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<AccountStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// E.g. patient, expense, depreciation
        /// </summary>
        [FhirElement("type", InSummary=true, Order=110)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Human-readable label
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Human-readable label
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                    NameElement = null;
                else
                    NameElement = new FhirString(value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// What is account tied to?
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=130)]
        [References("Patient","Device","Practitioner","Location","HealthcareService","Organization")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Transaction window
        /// </summary>
        [FhirElement("servicePeriod", InSummary=true, Order=140)]
        [DataMember]
        public Period ServicePeriod
        {
            get { return _servicePeriod; }
            set { _servicePeriod = value; OnPropertyChanged("ServicePeriod"); }
        }

        private Period _servicePeriod;

        /// <summary>
        /// The party(s) that are responsible for covering the payment of this account, and what order should they be applied to the account
        /// </summary>
        [FhirElement("coverage", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CoverageComponent> Coverage
        {
            get { if (_coverage==null) _coverage = new List<CoverageComponent>(); return _coverage; }
            set { _coverage = value; OnPropertyChanged("Coverage"); }
        }

        private List<CoverageComponent> _coverage;

        /// <summary>
        /// Who is responsible?
        /// </summary>
        [FhirElement("owner", InSummary=true, Order=160)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Owner
        {
            get { return _owner; }
            set { _owner = value; OnPropertyChanged("Owner"); }
        }

        private ResourceReference _owner;

        /// <summary>
        /// Explanation of purpose/use
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
        /// Explanation of purpose/use
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
        /// Responsible for the account
        /// </summary>
        [FhirElement("guarantor", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GuarantorComponent> Guarantor
        {
            get { if (_guarantor==null) _guarantor = new List<GuarantorComponent>(); return _guarantor; }
            set { _guarantor = value; OnPropertyChanged("Guarantor"); }
        }

        private List<GuarantorComponent> _guarantor;

        /// <summary>
        /// Reference to a parent Account
        /// </summary>
        [FhirElement("partOf", Order=190)]
        [References("Account")]
        [DataMember]
        public ResourceReference PartOf
        {
            get { return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private ResourceReference _partOf;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Account;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<AccountStatus>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (ServicePeriod != null) dest.ServicePeriod = (Period)ServicePeriod.DeepCopy();
                if (Coverage != null) dest.Coverage = new List<CoverageComponent>(Coverage.DeepCopy());
                if (Owner != null) dest.Owner = (ResourceReference)Owner.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Guarantor != null) dest.Guarantor = new List<GuarantorComponent>(Guarantor.DeepCopy());
                if (PartOf != null) dest.PartOf = (ResourceReference)PartOf.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Account());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Account;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(ServicePeriod, otherT.ServicePeriod)) return false;
            if ( !DeepComparable.Matches(Coverage, otherT.Coverage)) return false;
            if (!DeepComparable.Matches(Owner, otherT.Owner)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(Guarantor, otherT.Guarantor)) return false;
            if (!DeepComparable.Matches(PartOf, otherT.PartOf)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Account;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(ServicePeriod, otherT.ServicePeriod)) return false;
            if (!DeepComparable.IsExactly(Coverage, otherT.Coverage)) return false;
            if (!DeepComparable.IsExactly(Owner, otherT.Owner)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Guarantor, otherT.Guarantor)) return false;
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
                if (Type != null) yield return Type;
                if (NameElement != null) yield return NameElement;
                if (Subject != null) yield return Subject;
                if (ServicePeriod != null) yield return ServicePeriod;
                foreach (var elem in Coverage) { if (elem != null) yield return elem; }
                if (Owner != null) yield return Owner;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in Guarantor) { if (elem != null) yield return elem; }
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
                if (Type != null) yield return new ElementValue("type", false, Type);
                if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (ServicePeriod != null) yield return new ElementValue("servicePeriod", false, ServicePeriod);
                foreach (var elem in Coverage) { if (elem != null) yield return new ElementValue("coverage", true, elem); }
                if (Owner != null) yield return new ElementValue("owner", false, Owner);
                if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                foreach (var elem in Guarantor) { if (elem != null) yield return new ElementValue("guarantor", true, elem); }
                if (PartOf != null) yield return new ElementValue("partOf", false, PartOf);
            }
        }

    }

}
