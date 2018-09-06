using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
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
    /// Defines an affiliation/assotiation/relationship between 2 distinct oganizations, that is not a part-of relationship/sub-division relationship
    /// </summary>
    [FhirType("OrganizationAffiliation", IsResource=true)]
    [DataContract]
    public partial class OrganizationAffiliation : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.OrganizationAffiliation; } }
        [NotMapped]
        public override string TypeName { get { return "OrganizationAffiliation"; } }


        /// <summary>
        /// Business identifiers that are specific to this role
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
        /// Whether this organization affiliation record is in active use
        /// </summary>
        [FhirElement("active", InSummary=true, Order=100)]
        [DataMember]
        public FhirBoolean ActiveElement
        {
            get { return _activeElement; }
            set { _activeElement = value; OnPropertyChanged("ActiveElement"); }
        }

        private FhirBoolean _activeElement;

        /// <summary>
        /// Whether this organization affiliation record is in active use
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Active
        {
            get { return ActiveElement != null ? ActiveElement.Value : null; }
            set
            {
                if (value == null)
                    ActiveElement = null;
                else
                    ActiveElement = new FhirBoolean(value);
                OnPropertyChanged("Active");
            }
        }

        /// <summary>
        /// The period during which the participatingOrganization is affiliated with the primary organization
        /// </summary>
        [FhirElement("period", InSummary=true, Order=110)]
        [DataMember]
        public Period Period
        {
            get { return _period; }
            set { _period = value; OnPropertyChanged("Period"); }
        }

        private Period _period;

        /// <summary>
        /// Organization where the role is available
        /// </summary>
        [FhirElement("organization", InSummary=true, Order=120)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Organization
        {
            get { return _organization; }
            set { _organization = value; OnPropertyChanged("Organization"); }
        }

        private ResourceReference _organization;

        /// <summary>
        /// Organization that provides/performs the role (e.g. providing services or is a member of)
        /// </summary>
        [FhirElement("participatingOrganization", InSummary=true, Order=130)]
        [References("Organization")]
        [DataMember]
        public ResourceReference ParticipatingOrganization
        {
            get { return _participatingOrganization; }
            set { _participatingOrganization = value; OnPropertyChanged("ParticipatingOrganization"); }
        }

        private ResourceReference _participatingOrganization;

        /// <summary>
        /// Health insurance provider network in which the participatingOrganization provides the role's services (if defined) at the indicated locations (if defined)
        /// </summary>
        [FhirElement("network", InSummary=true, Order=140)]
        [References("Organization")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Network
        {
            get { if (_network==null) _network = new List<ResourceReference>(); return _network; }
            set { _network = value; OnPropertyChanged("Network"); }
        }

        private List<ResourceReference> _network;

        /// <summary>
        /// Definition of the role the participatingOrganization plays
        /// </summary>
        [FhirElement("code", InSummary=true, Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Code
        {
            get { if (_code==null) _code = new List<CodeableConcept>(); return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private List<CodeableConcept> _code;

        /// <summary>
        /// Specific specialty of the participatingOrganization in the context of the role
        /// </summary>
        [FhirElement("specialty", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Specialty
        {
            get { if (_specialty==null) _specialty = new List<CodeableConcept>(); return _specialty; }
            set { _specialty = value; OnPropertyChanged("Specialty"); }
        }

        private List<CodeableConcept> _specialty;

        /// <summary>
        /// The location(s) at which the role occurs
        /// </summary>
        [FhirElement("location", InSummary=true, Order=170)]
        [References("Location")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Location
        {
            get { if (_location==null) _location = new List<ResourceReference>(); return _location; }
            set { _location = value; OnPropertyChanged("Location"); }
        }

        private List<ResourceReference> _location;

        /// <summary>
        /// Healthcare services provided through the role
        /// </summary>
        [FhirElement("healthcareService", Order=180)]
        [References("HealthcareService")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> HealthcareService
        {
            get { if (_healthcareService==null) _healthcareService = new List<ResourceReference>(); return _healthcareService; }
            set { _healthcareService = value; OnPropertyChanged("HealthcareService"); }
        }

        private List<ResourceReference> _healthcareService;

        /// <summary>
        /// Contact details at the participatingOrganization relevant to this Affiliation
        /// </summary>
        [FhirElement("telecom", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactPoint> Telecom
        {
            get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
            set { _telecom = value; OnPropertyChanged("Telecom"); }
        }

        private List<ContactPoint> _telecom;

        /// <summary>
        /// Technical endpoints providing access to services operated for this role
        /// </summary>
        [FhirElement("endpoint", Order=200)]
        [References("Endpoint")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Endpoint
        {
            get { if (_endpoint==null) _endpoint = new List<ResourceReference>(); return _endpoint; }
            set { _endpoint = value; OnPropertyChanged("Endpoint"); }
        }

        private List<ResourceReference> _endpoint;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as OrganizationAffiliation;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (Period != null) dest.Period = (Period)Period.DeepCopy();
                if (Organization != null) dest.Organization = (ResourceReference)Organization.DeepCopy();
                if (ParticipatingOrganization != null) dest.ParticipatingOrganization = (ResourceReference)ParticipatingOrganization.DeepCopy();
                if (Network != null) dest.Network = new List<ResourceReference>(Network.DeepCopy());
                if (Code != null) dest.Code = new List<CodeableConcept>(Code.DeepCopy());
                if (Specialty != null) dest.Specialty = new List<CodeableConcept>(Specialty.DeepCopy());
                if (Location != null) dest.Location = new List<ResourceReference>(Location.DeepCopy());
                if (HealthcareService != null) dest.HealthcareService = new List<ResourceReference>(HealthcareService.DeepCopy());
                if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                if (Endpoint != null) dest.Endpoint = new List<ResourceReference>(Endpoint.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new OrganizationAffiliation());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as OrganizationAffiliation;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.Matches(Period, otherT.Period)) return false;
            if (!DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if (!DeepComparable.Matches(ParticipatingOrganization, otherT.ParticipatingOrganization)) return false;
            if ( !DeepComparable.Matches(Network, otherT.Network)) return false;
            if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if ( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
            if ( !DeepComparable.Matches(Location, otherT.Location)) return false;
            if ( !DeepComparable.Matches(HealthcareService, otherT.HealthcareService)) return false;
            if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;
            if ( !DeepComparable.Matches(Endpoint, otherT.Endpoint)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as OrganizationAffiliation;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if (!DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if (!DeepComparable.IsExactly(ParticipatingOrganization, otherT.ParticipatingOrganization)) return false;
            if (!DeepComparable.IsExactly(Network, otherT.Network)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if (!DeepComparable.IsExactly(HealthcareService, otherT.HealthcareService)) return false;
            if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;
            if (!DeepComparable.IsExactly(Endpoint, otherT.Endpoint)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (ActiveElement != null) yield return ActiveElement;
                if (Period != null) yield return Period;
                if (Organization != null) yield return Organization;
                if (ParticipatingOrganization != null) yield return ParticipatingOrganization;
                foreach (var elem in Network) { if (elem != null) yield return elem; }
                foreach (var elem in Code) { if (elem != null) yield return elem; }
                foreach (var elem in Specialty) { if (elem != null) yield return elem; }
                foreach (var elem in Location) { if (elem != null) yield return elem; }
                foreach (var elem in HealthcareService) { if (elem != null) yield return elem; }
                foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                foreach (var elem in Endpoint) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (ActiveElement != null) yield return new ElementValue("active", ActiveElement);
                if (Period != null) yield return new ElementValue("period", Period);
                if (Organization != null) yield return new ElementValue("organization", Organization);
                if (ParticipatingOrganization != null) yield return new ElementValue("participatingOrganization", ParticipatingOrganization);
                foreach (var elem in Network) { if (elem != null) yield return new ElementValue("network", elem); }
                foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                foreach (var elem in Specialty) { if (elem != null) yield return new ElementValue("specialty", elem); }
                foreach (var elem in Location) { if (elem != null) yield return new ElementValue("location", elem); }
                foreach (var elem in HealthcareService) { if (elem != null) yield return new ElementValue("healthcareService", elem); }
                foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                foreach (var elem in Endpoint) { if (elem != null) yield return new ElementValue("endpoint", elem); }
            }
        }

    }

}
