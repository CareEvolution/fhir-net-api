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
    /// Immunization evaluation information
    /// </summary>
    [FhirType("ImmunizationEvaluation", IsResource=true)]
    [DataContract]
    public partial class ImmunizationEvaluation : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImmunizationEvaluation; } }
        [NotMapped]
        public override string TypeName { get { return "ImmunizationEvaluation"; } }


        /// <summary>
        /// Business identifier
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
        /// completed | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ImmunizationEvaluationStatusCodes> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ImmunizationEvaluationStatusCodes> _statusElement;

        /// <summary>
        /// completed | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ImmunizationEvaluationStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ImmunizationEvaluationStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Who this evaluation is for
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=110)]
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
        /// Date evaluation was performed
        /// </summary>
        [FhirElement("date", Order=120)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date evaluation was performed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }

        /// <summary>
        /// Who is responsible for publishing the recommendations
        /// </summary>
        [FhirElement("authority", Order=130)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Authority
        {
            get { return _authority; }
            set { _authority = value; OnPropertyChanged("Authority"); }
        }

        private ResourceReference _authority;

        /// <summary>
        /// Evaluation target disease
        /// </summary>
        [FhirElement("targetDisease", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<CodeableConcept> TargetDisease
        {
            get { if (_targetDisease==null) _targetDisease = new List<CodeableConcept>(); return _targetDisease; }
            set { _targetDisease = value; OnPropertyChanged("TargetDisease"); }
        }

        private List<CodeableConcept> _targetDisease;

        /// <summary>
        /// Immunization being evaluated
        /// </summary>
        [FhirElement("immunizationEvent", InSummary=true, Order=150)]
        [References("Immunization")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference ImmunizationEvent
        {
            get { return _immunizationEvent; }
            set { _immunizationEvent = value; OnPropertyChanged("ImmunizationEvent"); }
        }

        private ResourceReference _immunizationEvent;

        /// <summary>
        /// Status of the dose relative to published recommendations
        /// </summary>
        [FhirElement("doseStatus", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept DoseStatus
        {
            get { return _doseStatus; }
            set { _doseStatus = value; OnPropertyChanged("DoseStatus"); }
        }

        private CodeableConcept _doseStatus;

        /// <summary>
        /// Reason for the dose status
        /// </summary>
        [FhirElement("doseStatusReason", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> DoseStatusReason
        {
            get { if (_doseStatusReason==null) _doseStatusReason = new List<CodeableConcept>(); return _doseStatusReason; }
            set { _doseStatusReason = value; OnPropertyChanged("DoseStatusReason"); }
        }

        private List<CodeableConcept> _doseStatusReason;

        /// <summary>
        /// Evaluation notes
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
        /// Evaluation notes
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
        /// Name of vaccine series
        /// </summary>
        [FhirElement("series", Order=190)]
        [DataMember]
        public FhirString SeriesElement
        {
            get { return _seriesElement; }
            set { _seriesElement = value; OnPropertyChanged("SeriesElement"); }
        }

        private FhirString _seriesElement;

        /// <summary>
        /// Name of vaccine series
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Series
        {
            get { return SeriesElement != null ? SeriesElement.Value : null; }
            set
            {
                if (value == null)
                    SeriesElement = null;
                else
                    SeriesElement = new FhirString(value);
                OnPropertyChanged("Series");
            }
        }

        /// <summary>
        /// Dose number within series
        /// </summary>
        [FhirElement("doseNumber", Order=200, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(PositiveInt),typeof(FhirString))]
        [DataMember]
        public Element DoseNumber
        {
            get { return _doseNumber; }
            set { _doseNumber = value; OnPropertyChanged("DoseNumber"); }
        }

        private Element _doseNumber;

        /// <summary>
        /// Recommended number of doses for immunity
        /// </summary>
        [FhirElement("seriesDoses", Order=210, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(PositiveInt),typeof(FhirString))]
        [DataMember]
        public Element SeriesDoses
        {
            get { return _seriesDoses; }
            set { _seriesDoses = value; OnPropertyChanged("SeriesDoses"); }
        }

        private Element _seriesDoses;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImmunizationEvaluation;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<ImmunizationEvaluationStatusCodes>)StatusElement.DeepCopy();
                if (Patient != null) dest.Patient = (ResourceReference)Patient.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Authority != null) dest.Authority = (ResourceReference)Authority.DeepCopy();
                if (TargetDisease != null) dest.TargetDisease = new List<CodeableConcept>(TargetDisease.DeepCopy());
                if (ImmunizationEvent != null) dest.ImmunizationEvent = (ResourceReference)ImmunizationEvent.DeepCopy();
                if (DoseStatus != null) dest.DoseStatus = (CodeableConcept)DoseStatus.DeepCopy();
                if (DoseStatusReason != null) dest.DoseStatusReason = new List<CodeableConcept>(DoseStatusReason.DeepCopy());
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (SeriesElement != null) dest.SeriesElement = (FhirString)SeriesElement.DeepCopy();
                if (DoseNumber != null) dest.DoseNumber = (Element)DoseNumber.DeepCopy();
                if (SeriesDoses != null) dest.SeriesDoses = (Element)SeriesDoses.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ImmunizationEvaluation());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ImmunizationEvaluation;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Authority, otherT.Authority)) return false;
            if ( !DeepComparable.Matches(TargetDisease, otherT.TargetDisease)) return false;
            if (!DeepComparable.Matches(ImmunizationEvent, otherT.ImmunizationEvent)) return false;
            if (!DeepComparable.Matches(DoseStatus, otherT.DoseStatus)) return false;
            if ( !DeepComparable.Matches(DoseStatusReason, otherT.DoseStatusReason)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;
            if (!DeepComparable.Matches(DoseNumber, otherT.DoseNumber)) return false;
            if (!DeepComparable.Matches(SeriesDoses, otherT.SeriesDoses)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImmunizationEvaluation;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
            if (!DeepComparable.IsExactly(TargetDisease, otherT.TargetDisease)) return false;
            if (!DeepComparable.IsExactly(ImmunizationEvent, otherT.ImmunizationEvent)) return false;
            if (!DeepComparable.IsExactly(DoseStatus, otherT.DoseStatus)) return false;
            if (!DeepComparable.IsExactly(DoseStatusReason, otherT.DoseStatusReason)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;
            if (!DeepComparable.IsExactly(DoseNumber, otherT.DoseNumber)) return false;
            if (!DeepComparable.IsExactly(SeriesDoses, otherT.SeriesDoses)) return false;

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
                if (Patient != null) yield return Patient;
                if (DateElement != null) yield return DateElement;
                if (Authority != null) yield return Authority;
                foreach (var elem in TargetDisease) { if (elem != null) yield return elem; }
                if (ImmunizationEvent != null) yield return ImmunizationEvent;
                if (DoseStatus != null) yield return DoseStatus;
                foreach (var elem in DoseStatusReason) { if (elem != null) yield return elem; }
                if (DescriptionElement != null) yield return DescriptionElement;
                if (SeriesElement != null) yield return SeriesElement;
                if (DoseNumber != null) yield return DoseNumber;
                if (SeriesDoses != null) yield return SeriesDoses;
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
                if (Patient != null) yield return new ElementValue("patient", false, Patient);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (Authority != null) yield return new ElementValue("authority", false, Authority);
                foreach (var elem in TargetDisease) { if (elem != null) yield return new ElementValue("targetDisease", true, elem); }
                if (ImmunizationEvent != null) yield return new ElementValue("immunizationEvent", false, ImmunizationEvent);
                if (DoseStatus != null) yield return new ElementValue("doseStatus", false, DoseStatus);
                foreach (var elem in DoseStatusReason) { if (elem != null) yield return new ElementValue("doseStatusReason", true, elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                if (SeriesElement != null) yield return new ElementValue("series", false, SeriesElement);
                if (DoseNumber != null) yield return new ElementValue("doseNumber", false, DoseNumber);
                if (SeriesDoses != null) yield return new ElementValue("seriesDoses", false, SeriesDoses);
            }
        }

    }

}
