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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// A container for slots of time that may be available for booking appointments
    /// </summary>
    [FhirType("Schedule", IsResource=true)]
    [DataContract]
    public partial class Schedule : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Schedule; } }
        [NotMapped]
        public override string TypeName { get { return "Schedule"; } }


        /// <summary>
        /// External Ids for this item
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
        /// Whether this schedule is in active use
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
        /// Whether this schedule is in active use
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
        /// High-level category
        /// </summary>
        [FhirElement("serviceCategory", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ServiceCategory
        {
            get { if (_serviceCategory==null) _serviceCategory = new List<CodeableConcept>(); return _serviceCategory; }
            set { _serviceCategory = value; OnPropertyChanged("ServiceCategory"); }
        }

        private List<CodeableConcept> _serviceCategory;

        /// <summary>
        /// Specific service
        /// </summary>
        [FhirElement("serviceType", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> ServiceType
        {
            get { if (_serviceType==null) _serviceType = new List<CodeableConcept>(); return _serviceType; }
            set { _serviceType = value; OnPropertyChanged("ServiceType"); }
        }

        private List<CodeableConcept> _serviceType;

        /// <summary>
        /// Type of specialty needed
        /// </summary>
        [FhirElement("specialty", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Specialty
        {
            get { if (_specialty==null) _specialty = new List<CodeableConcept>(); return _specialty; }
            set { _specialty = value; OnPropertyChanged("Specialty"); }
        }

        private List<CodeableConcept> _specialty;

        /// <summary>
        /// E.g. HealthCareService, Location, Practitioner, etc.
        /// </summary>
        [FhirElement("actor", InSummary=true, Order=140)]
        [References("Patient","Practitioner","PractitionerRole","RelatedPerson","Device","HealthcareService","Location")]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<ResourceReference> Actor
        {
            get { if (_actor==null) _actor = new List<ResourceReference>(); return _actor; }
            set { _actor = value; OnPropertyChanged("Actor"); }
        }

        private List<ResourceReference> _actor;

        /// <summary>
        /// Period of time covered by schedule
        /// </summary>
        [FhirElement("planningHorizon", InSummary=true, Order=150)]
        [DataMember]
        public Period PlanningHorizon
        {
            get { return _planningHorizon; }
            set { _planningHorizon = value; OnPropertyChanged("PlanningHorizon"); }
        }

        private Period _planningHorizon;

        /// <summary>
        /// Comments on availability
        /// </summary>
        [FhirElement("comment", Order=160)]
        [DataMember]
        public FhirString CommentElement
        {
            get { return _commentElement; }
            set { _commentElement = value; OnPropertyChanged("CommentElement"); }
        }

        private FhirString _commentElement;

        /// <summary>
        /// Comments on availability
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Comment
        {
            get { return CommentElement != null ? CommentElement.Value : null; }
            set
            {
                if (value == null)
                    CommentElement = null;
                else
                    CommentElement = new FhirString(value);
                OnPropertyChanged("Comment");
            }
        }


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Schedule;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (ActiveElement != null) dest.ActiveElement = (FhirBoolean)ActiveElement.DeepCopy();
                if (ServiceCategory != null) dest.ServiceCategory = new List<CodeableConcept>(ServiceCategory.DeepCopy());
                if (ServiceType != null) dest.ServiceType = new List<CodeableConcept>(ServiceType.DeepCopy());
                if (Specialty != null) dest.Specialty = new List<CodeableConcept>(Specialty.DeepCopy());
                if (Actor != null) dest.Actor = new List<ResourceReference>(Actor.DeepCopy());
                if (PlanningHorizon != null) dest.PlanningHorizon = (Period)PlanningHorizon.DeepCopy();
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Schedule());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Schedule;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(ActiveElement, otherT.ActiveElement)) return false;
            if ( !DeepComparable.Matches(ServiceCategory, otherT.ServiceCategory)) return false;
            if ( !DeepComparable.Matches(ServiceType, otherT.ServiceType)) return false;
            if ( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
            if ( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
            if (!DeepComparable.Matches(PlanningHorizon, otherT.PlanningHorizon)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Schedule;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(ActiveElement, otherT.ActiveElement)) return false;
            if (!DeepComparable.IsExactly(ServiceCategory, otherT.ServiceCategory)) return false;
            if (!DeepComparable.IsExactly(ServiceType, otherT.ServiceType)) return false;
            if (!DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
            if (!DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
            if (!DeepComparable.IsExactly(PlanningHorizon, otherT.PlanningHorizon)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;

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
                foreach (var elem in ServiceCategory) { if (elem != null) yield return elem; }
                foreach (var elem in ServiceType) { if (elem != null) yield return elem; }
                foreach (var elem in Specialty) { if (elem != null) yield return elem; }
                foreach (var elem in Actor) { if (elem != null) yield return elem; }
                if (PlanningHorizon != null) yield return PlanningHorizon;
                if (CommentElement != null) yield return CommentElement;
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
                foreach (var elem in ServiceCategory) { if (elem != null) yield return new ElementValue("serviceCategory", elem); }
                foreach (var elem in ServiceType) { if (elem != null) yield return new ElementValue("serviceType", elem); }
                foreach (var elem in Specialty) { if (elem != null) yield return new ElementValue("specialty", elem); }
                foreach (var elem in Actor) { if (elem != null) yield return new ElementValue("actor", elem); }
                if (PlanningHorizon != null) yield return new ElementValue("planningHorizon", PlanningHorizon);
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
            }
        }

    }

}
