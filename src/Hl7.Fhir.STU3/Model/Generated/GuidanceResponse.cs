﻿using System;
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
    /// The formal response to a guidance request
    /// </summary>
    [FhirType("GuidanceResponse", IsResource=true)]
    [DataContract]
    public partial class GuidanceResponse : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.GuidanceResponse; } }
        [NotMapped]
        public override string TypeName { get { return "GuidanceResponse"; } }


        /// <summary>
        /// The id of the request associated with this response, if any
        /// </summary>
        [FhirElement("requestId", InSummary=true, Order=90)]
        [DataMember]
        public Id RequestIdElement
        {
            get { return _requestIdElement; }
            set { _requestIdElement = value; OnPropertyChanged("RequestIdElement"); }
        }

        private Id _requestIdElement;

        /// <summary>
        /// The id of the request associated with this response, if any
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string RequestId
        {
            get { return RequestIdElement != null ? RequestIdElement.Value : null; }
            set
            {
                if (value == null)
                    RequestIdElement = null;
                else
                    RequestIdElement = new Id(value);
                OnPropertyChanged("RequestId");
            }
        }

        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// A reference to a knowledge module
        /// </summary>
        [FhirElement("module", InSummary=true, Order=110)]
        [References("ServiceDefinition")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Module
        {
            get { return _module; }
            set { _module = value; OnPropertyChanged("Module"); }
        }

        private ResourceReference _module;

        /// <summary>
        /// success | data-requested | data-required | in-progress | failure | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<GuidanceResponseStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<GuidanceResponseStatus> _statusElement;

        /// <summary>
        /// success | data-requested | data-required | in-progress | failure | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public GuidanceResponseStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<GuidanceResponseStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Patient the request was performed for
        /// </summary>
        [FhirElement("subject", Order=130)]
        [References("Patient","Group")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Encounter or Episode during which the response was returned
        /// </summary>
        [FhirElement("context", Order=140)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// When the guidance response was processed
        /// </summary>
        [FhirElement("occurrenceDateTime", Order=150)]
        [DataMember]
        public FhirDateTime OccurrenceDateTimeElement
        {
            get { return _occurrenceDateTimeElement; }
            set { _occurrenceDateTimeElement = value; OnPropertyChanged("OccurrenceDateTimeElement"); }
        }

        private FhirDateTime _occurrenceDateTimeElement;

        /// <summary>
        /// When the guidance response was processed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string OccurrenceDateTime
        {
            get { return OccurrenceDateTimeElement != null ? OccurrenceDateTimeElement.Value : null; }
            set
            {
                if (value == null)
                    OccurrenceDateTimeElement = null;
                else
                    OccurrenceDateTimeElement = new FhirDateTime(value);
                OnPropertyChanged("OccurrenceDateTime");
            }
        }

        /// <summary>
        /// Device returning the guidance
        /// </summary>
        [FhirElement("performer", Order=160)]
        [References("Device")]
        [DataMember]
        public ResourceReference Performer
        {
            get { return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private ResourceReference _performer;

        /// <summary>
        /// Reason for the response
        /// </summary>
        [FhirElement("reason", Order=170, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private Element _reason;

        /// <summary>
        /// Additional notes about the response
        /// </summary>
        [FhirElement("note", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Messages resulting from the evaluation of the artifact or artifacts
        /// </summary>
        [FhirElement("evaluationMessage", Order=190)]
        [References("OperationOutcome")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> EvaluationMessage
        {
            get { if (_evaluationMessage==null) _evaluationMessage = new List<ResourceReference>(); return _evaluationMessage; }
            set { _evaluationMessage = value; OnPropertyChanged("EvaluationMessage"); }
        }

        private List<ResourceReference> _evaluationMessage;

        /// <summary>
        /// The output parameters of the evaluation, if any
        /// </summary>
        [FhirElement("outputParameters", Order=200)]
        [References("Parameters")]
        [DataMember]
        public ResourceReference OutputParameters
        {
            get { return _outputParameters; }
            set { _outputParameters = value; OnPropertyChanged("OutputParameters"); }
        }

        private ResourceReference _outputParameters;

        /// <summary>
        /// Proposed actions, if any
        /// </summary>
        [FhirElement("result", Order=210)]
        [References("CarePlan","RequestGroup")]
        [DataMember]
        public ResourceReference Result
        {
            get { return _result; }
            set { _result = value; OnPropertyChanged("Result"); }
        }

        private ResourceReference _result;

        /// <summary>
        /// Additional required data
        /// </summary>
        [FhirElement("dataRequirement", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DataRequirement> DataRequirement
        {
            get { if (_dataRequirement==null) _dataRequirement = new List<DataRequirement>(); return _dataRequirement; }
            set { _dataRequirement = value; OnPropertyChanged("DataRequirement"); }
        }

        private List<DataRequirement> _dataRequirement;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as GuidanceResponse;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (RequestIdElement != null) dest.RequestIdElement = (Id)RequestIdElement.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (Module != null) dest.Module = (ResourceReference)Module.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<GuidanceResponseStatus>)StatusElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (OccurrenceDateTimeElement != null) dest.OccurrenceDateTimeElement = (FhirDateTime)OccurrenceDateTimeElement.DeepCopy();
                if (Performer != null) dest.Performer = (ResourceReference)Performer.DeepCopy();
                if (Reason != null) dest.Reason = (Element)Reason.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (EvaluationMessage != null) dest.EvaluationMessage = new List<ResourceReference>(EvaluationMessage.DeepCopy());
                if (OutputParameters != null) dest.OutputParameters = (ResourceReference)OutputParameters.DeepCopy();
                if (Result != null) dest.Result = (ResourceReference)Result.DeepCopy();
                if (DataRequirement != null) dest.DataRequirement = new List<DataRequirement>(DataRequirement.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new GuidanceResponse());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as GuidanceResponse;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(RequestIdElement, otherT.RequestIdElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Module, otherT.Module)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(OccurrenceDateTimeElement, otherT.OccurrenceDateTimeElement)) return false;
            if (!DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(EvaluationMessage, otherT.EvaluationMessage)) return false;
            if (!DeepComparable.Matches(OutputParameters, otherT.OutputParameters)) return false;
            if (!DeepComparable.Matches(Result, otherT.Result)) return false;
            if ( !DeepComparable.Matches(DataRequirement, otherT.DataRequirement)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as GuidanceResponse;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(RequestIdElement, otherT.RequestIdElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Module, otherT.Module)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(OccurrenceDateTimeElement, otherT.OccurrenceDateTimeElement)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(EvaluationMessage, otherT.EvaluationMessage)) return false;
            if (!DeepComparable.IsExactly(OutputParameters, otherT.OutputParameters)) return false;
            if (!DeepComparable.IsExactly(Result, otherT.Result)) return false;
            if (!DeepComparable.IsExactly(DataRequirement, otherT.DataRequirement)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (RequestIdElement != null) yield return RequestIdElement;
                if (Identifier != null) yield return Identifier;
                if (Module != null) yield return Module;
                if (StatusElement != null) yield return StatusElement;
                if (Subject != null) yield return Subject;
                if (Context != null) yield return Context;
                if (OccurrenceDateTimeElement != null) yield return OccurrenceDateTimeElement;
                if (Performer != null) yield return Performer;
                if (Reason != null) yield return Reason;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in EvaluationMessage) { if (elem != null) yield return elem; }
                if (OutputParameters != null) yield return OutputParameters;
                if (Result != null) yield return Result;
                foreach (var elem in DataRequirement) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (RequestIdElement != null) yield return new ElementValue("requestId", RequestIdElement);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (Module != null) yield return new ElementValue("module", Module);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Context != null) yield return new ElementValue("context", Context);
                if (OccurrenceDateTimeElement != null) yield return new ElementValue("occurrenceDateTime", OccurrenceDateTimeElement);
                if (Performer != null) yield return new ElementValue("performer", Performer);
                if (Reason != null) yield return new ElementValue("reason", Reason);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in EvaluationMessage) { if (elem != null) yield return new ElementValue("evaluationMessage", elem); }
                if (OutputParameters != null) yield return new ElementValue("outputParameters", OutputParameters);
                if (Result != null) yield return new ElementValue("result", Result);
                foreach (var elem in DataRequirement) { if (elem != null) yield return new ElementValue("dataRequirement", elem); }
            }
        }

    }

}
