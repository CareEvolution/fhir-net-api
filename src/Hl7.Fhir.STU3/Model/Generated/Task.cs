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
    /// A task to be performed
    /// </summary>
    [FhirType("Task", IsResource=true)]
    [DataContract]
    public partial class Task : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Task; } }
        [NotMapped]
        public override string TypeName { get { return "Task"; } }


        [FhirType("RequesterComponent")]
        [DataContract]
        public partial class RequesterComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RequesterComponent"; } }

            /// <summary>
            /// Individual asking for task
            /// </summary>
            [FhirElement("agent", InSummary=true, Order=40)]
            [References("Device","Organization","Patient","Practitioner","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Agent
            {
                get { return _agent; }
                set { _agent = value; OnPropertyChanged("Agent"); }
            }

            private ResourceReference _agent;

            /// <summary>
            /// Organization individual is acting for
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
                var dest = other as RequesterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Agent != null) dest.Agent = (ResourceReference)Agent.DeepCopy();
                    if (OnBehalfOf != null) dest.OnBehalfOf = (ResourceReference)OnBehalfOf.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RequesterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RequesterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Agent, otherT.Agent)) return false;
                if (!DeepComparable.Matches(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RequesterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
                if (!DeepComparable.IsExactly(OnBehalfOf, otherT.OnBehalfOf)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Agent != null) yield return Agent;
                    if (OnBehalfOf != null) yield return OnBehalfOf;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Agent != null) yield return new ElementValue("agent", Agent);
                    if (OnBehalfOf != null) yield return new ElementValue("onBehalfOf", OnBehalfOf);
                }
            }


        }


        [FhirType("RestrictionComponent")]
        [DataContract]
        public partial class RestrictionComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RestrictionComponent"; } }

            /// <summary>
            /// How many times to repeat
            /// </summary>
            [FhirElement("repetitions", Order=40)]
            [DataMember]
            public PositiveInt RepetitionsElement
            {
                get { return _repetitionsElement; }
                set { _repetitionsElement = value; OnPropertyChanged("RepetitionsElement"); }
            }

            private PositiveInt _repetitionsElement;

            /// <summary>
            /// How many times to repeat
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public int? Repetitions
            {
                get { return RepetitionsElement != null ? RepetitionsElement.Value : null; }
                set
                {
                    if (value == null)
                        RepetitionsElement = null;
                    else
                        RepetitionsElement = new PositiveInt(value);
                    OnPropertyChanged("Repetitions");
                }
            }

            /// <summary>
            /// When fulfillment sought
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
            /// For whom is fulfillment sought?
            /// </summary>
            [FhirElement("recipient", Order=60)]
            [References("Patient","Practitioner","RelatedPerson","Group","Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Recipient
            {
                get { if (_recipient==null) _recipient = new List<ResourceReference>(); return _recipient; }
                set { _recipient = value; OnPropertyChanged("Recipient"); }
            }

            private List<ResourceReference> _recipient;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RestrictionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RepetitionsElement != null) dest.RepetitionsElement = (PositiveInt)RepetitionsElement.DeepCopy();
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (Recipient != null) dest.Recipient = new List<ResourceReference>(Recipient.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RestrictionComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RestrictionComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RepetitionsElement, otherT.RepetitionsElement)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if ( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RestrictionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RepetitionsElement, otherT.RepetitionsElement)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RepetitionsElement != null) yield return RepetitionsElement;
                    if (Period != null) yield return Period;
                    foreach (var elem in Recipient) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RepetitionsElement != null) yield return new ElementValue("repetitions", RepetitionsElement);
                    if (Period != null) yield return new ElementValue("period", Period);
                    foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", elem); }
                }
            }


        }


        [FhirType("ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }

            /// <summary>
            /// Label for the input
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Content to use in performing the task
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Base64Binary),typeof(FhirBoolean),typeof(Code),typeof(Date),typeof(FhirDateTime),typeof(FhirDecimal),typeof(Id),typeof(Instant),typeof(Integer),typeof(Markdown),typeof(Oid),typeof(PositiveInt),typeof(FhirString),typeof(Time),typeof(UnsignedInt),typeof(FhirUri),typeof(Address),typeof(Age),typeof(Annotation),typeof(Attachment),typeof(CodeableConcept),typeof(Coding),typeof(ContactPoint),typeof(Count),typeof(Distance),typeof(Duration),typeof(HumanName),typeof(Identifier),typeof(Money),typeof(Period),typeof(Quantity),typeof(Range),typeof(Ratio),typeof(ResourceReference),typeof(SampledData),typeof(Signature),typeof(Timing),typeof(Meta))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParameterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ParameterComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        [FhirType("OutputComponent")]
        [DataContract]
        public partial class OutputComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OutputComponent"; } }

            /// <summary>
            /// Label for output
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Result of output
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Base64Binary),typeof(FhirBoolean),typeof(Code),typeof(Date),typeof(FhirDateTime),typeof(FhirDecimal),typeof(Id),typeof(Instant),typeof(Integer),typeof(Markdown),typeof(Oid),typeof(PositiveInt),typeof(FhirString),typeof(Time),typeof(UnsignedInt),typeof(FhirUri),typeof(Address),typeof(Age),typeof(Annotation),typeof(Attachment),typeof(CodeableConcept),typeof(Coding),typeof(ContactPoint),typeof(Count),typeof(Distance),typeof(Duration),typeof(HumanName),typeof(Identifier),typeof(Money),typeof(Period),typeof(Quantity),typeof(Range),typeof(Ratio),typeof(ResourceReference),typeof(SampledData),typeof(Signature),typeof(Timing),typeof(Meta))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OutputComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OutputComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OutputComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OutputComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Value != null) yield return Value;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Value != null) yield return new ElementValue("value", Value);
                }
            }


        }


        /// <summary>
        /// Task Instance Identifier
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
        /// Formal definition of task
        /// </summary>
        [FhirElement("definition", InSummary=true, Order=100, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirUri),typeof(ResourceReference))]
        [DataMember]
        public Element Definition
        {
            get { return _definition; }
            set { _definition = value; OnPropertyChanged("Definition"); }
        }

        private Element _definition;

        /// <summary>
        /// Request fulfilled by this task
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Requisition or grouper id
        /// </summary>
        [FhirElement("groupIdentifier", InSummary=true, Order=120)]
        [DataMember]
        public Identifier GroupIdentifier
        {
            get { return _groupIdentifier; }
            set { _groupIdentifier = value; OnPropertyChanged("GroupIdentifier"); }
        }

        private Identifier _groupIdentifier;

        /// <summary>
        /// Composite task
        /// </summary>
        [FhirElement("partOf", InSummary=true, Order=130)]
        [References("Task")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// draft | requested | received | accepted | +
        /// </summary>
        [FhirElement("status", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<TaskStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<TaskStatus> _statusElement;

        /// <summary>
        /// draft | requested | received | accepted | +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public TaskStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<TaskStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Reason for current status
        /// </summary>
        [FhirElement("statusReason", InSummary=true, Order=150)]
        [DataMember]
        public CodeableConcept StatusReason
        {
            get { return _statusReason; }
            set { _statusReason = value; OnPropertyChanged("StatusReason"); }
        }

        private CodeableConcept _statusReason;

        /// <summary>
        /// E.g. "Specimen collected", "IV prepped"
        /// </summary>
        [FhirElement("businessStatus", InSummary=true, Order=160)]
        [DataMember]
        public CodeableConcept BusinessStatus
        {
            get { return _businessStatus; }
            set { _businessStatus = value; OnPropertyChanged("BusinessStatus"); }
        }

        private CodeableConcept _businessStatus;

        /// <summary>
        /// proposal | plan | order +
        /// </summary>
        [FhirElement("intent", InSummary=true, Order=170)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<RequestIntent> IntentElement
        {
            get { return _intentElement; }
            set { _intentElement = value; OnPropertyChanged("IntentElement"); }
        }

        private Code<RequestIntent> _intentElement;

        /// <summary>
        /// proposal | plan | order +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public RequestIntent? Intent
        {
            get { return IntentElement != null ? IntentElement.Value : null; }
            set
            {
                if (value == null)
                    IntentElement = null;
                else
                    IntentElement = new Code<RequestIntent>(value);
                OnPropertyChanged("Intent");
            }
        }

        /// <summary>
        /// normal | urgent | asap | stat
        /// </summary>
        [FhirElement("priority", Order=180)]
        [DataMember]
        public Code<RequestPriority> PriorityElement
        {
            get { return _priorityElement; }
            set { _priorityElement = value; OnPropertyChanged("PriorityElement"); }
        }

        private Code<RequestPriority> _priorityElement;

        /// <summary>
        /// normal | urgent | asap | stat
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
        /// Task Type
        /// </summary>
        [FhirElement("code", InSummary=true, Order=190)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Human-readable explanation of task
        /// </summary>
        [FhirElement("description", InSummary=true, Order=200)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Human-readable explanation of task
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
        /// What task is acting on
        /// </summary>
        [FhirElement("focus", InSummary=true, Order=210)]
        [DataMember]
        public ResourceReference Focus
        {
            get { return _focus; }
            set { _focus = value; OnPropertyChanged("Focus"); }
        }

        private ResourceReference _focus;

        /// <summary>
        /// Beneficiary of the Task
        /// </summary>
        [FhirElement("for", InSummary=true, Order=220)]
        [DataMember]
        public ResourceReference For
        {
            get { return _for; }
            set { _for = value; OnPropertyChanged("For"); }
        }

        private ResourceReference _for;

        /// <summary>
        /// Healthcare event during which this task originated
        /// </summary>
        [FhirElement("context", InSummary=true, Order=230)]
        [References("Encounter","EpisodeOfCare")]
        [DataMember]
        public ResourceReference Context
        {
            get { return _context; }
            set { _context = value; OnPropertyChanged("Context"); }
        }

        private ResourceReference _context;

        /// <summary>
        /// Start and end time of execution
        /// </summary>
        [FhirElement("executionPeriod", InSummary=true, Order=240)]
        [DataMember]
        public Period ExecutionPeriod
        {
            get { return _executionPeriod; }
            set { _executionPeriod = value; OnPropertyChanged("ExecutionPeriod"); }
        }

        private Period _executionPeriod;

        /// <summary>
        /// Task Creation Date
        /// </summary>
        [FhirElement("authoredOn", Order=250)]
        [DataMember]
        public FhirDateTime AuthoredOnElement
        {
            get { return _authoredOnElement; }
            set { _authoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
        }

        private FhirDateTime _authoredOnElement;

        /// <summary>
        /// Task Creation Date
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
        /// Task Last Modified Date
        /// </summary>
        [FhirElement("lastModified", InSummary=true, Order=260)]
        [DataMember]
        public FhirDateTime LastModifiedElement
        {
            get { return _lastModifiedElement; }
            set { _lastModifiedElement = value; OnPropertyChanged("LastModifiedElement"); }
        }

        private FhirDateTime _lastModifiedElement;

        /// <summary>
        /// Task Last Modified Date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string LastModified
        {
            get { return LastModifiedElement != null ? LastModifiedElement.Value : null; }
            set
            {
                if (value == null)
                    LastModifiedElement = null;
                else
                    LastModifiedElement = new FhirDateTime(value);
                OnPropertyChanged("LastModified");
            }
        }

        /// <summary>
        /// Who is asking for task to be done
        /// </summary>
        [FhirElement("requester", InSummary=true, Order=270)]
        [DataMember]
        public RequesterComponent Requester
        {
            get { return _requester; }
            set { _requester = value; OnPropertyChanged("Requester"); }
        }

        private RequesterComponent _requester;

        /// <summary>
        /// requester | dispatcher | scheduler | performer | monitor | manager | acquirer | reviewer
        /// </summary>
        [FhirElement("performerType", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> PerformerType
        {
            get { if (_performerType==null) _performerType = new List<CodeableConcept>(); return _performerType; }
            set { _performerType = value; OnPropertyChanged("PerformerType"); }
        }

        private List<CodeableConcept> _performerType;

        /// <summary>
        /// Responsible individual
        /// </summary>
        [FhirElement("owner", InSummary=true, Order=290)]
        [References("Device","Organization","Patient","Practitioner","RelatedPerson")]
        [DataMember]
        public ResourceReference Owner
        {
            get { return _owner; }
            set { _owner = value; OnPropertyChanged("Owner"); }
        }

        private ResourceReference _owner;

        /// <summary>
        /// Why task is needed
        /// </summary>
        [FhirElement("reason", Order=300)]
        [DataMember]
        public CodeableConcept Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private CodeableConcept _reason;

        /// <summary>
        /// Comments made about the task
        /// </summary>
        [FhirElement("note", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Key events in history of the Task
        /// </summary>
        [FhirElement("relevantHistory", Order=320)]
        [References("Provenance")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> RelevantHistory
        {
            get { if (_relevantHistory==null) _relevantHistory = new List<ResourceReference>(); return _relevantHistory; }
            set { _relevantHistory = value; OnPropertyChanged("RelevantHistory"); }
        }

        private List<ResourceReference> _relevantHistory;

        /// <summary>
        /// Constraints on fulfillment tasks
        /// </summary>
        [FhirElement("restriction", Order=330)]
        [DataMember]
        public RestrictionComponent Restriction
        {
            get { return _restriction; }
            set { _restriction = value; OnPropertyChanged("Restriction"); }
        }

        private RestrictionComponent _restriction;

        /// <summary>
        /// Information used to perform task
        /// </summary>
        [FhirElement("input", Order=340)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParameterComponent> Input
        {
            get { if (_input==null) _input = new List<ParameterComponent>(); return _input; }
            set { _input = value; OnPropertyChanged("Input"); }
        }

        private List<ParameterComponent> _input;

        /// <summary>
        /// Information produced as part of task
        /// </summary>
        [FhirElement("output", Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<OutputComponent> Output
        {
            get { if (_output==null) _output = new List<OutputComponent>(); return _output; }
            set { _output = value; OnPropertyChanged("Output"); }
        }

        private List<OutputComponent> _output;


        public static ElementDefinition.ConstraintComponent Task_INV_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "lastModified.exists().not() or authoredOn.exists().not() or lastModified >= authoredOn",
            Key = "inv-1",
            Severity = ConstraintSeverity.Warning,
            Human = "Last modified date must be greater than or equal to authored-on date.",
            Xpath = "not(exists(f:lastModified/@value)) or not(exists(f:authoredOn/@value)) or f:lastModified/@value >= f:authoredOn/@value"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Task_INV_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Task;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Definition != null) dest.Definition = (Element)Definition.DeepCopy();
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (GroupIdentifier != null) dest.GroupIdentifier = (Identifier)GroupIdentifier.DeepCopy();
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<TaskStatus>)StatusElement.DeepCopy();
                if (StatusReason != null) dest.StatusReason = (CodeableConcept)StatusReason.DeepCopy();
                if (BusinessStatus != null) dest.BusinessStatus = (CodeableConcept)BusinessStatus.DeepCopy();
                if (IntentElement != null) dest.IntentElement = (Code<RequestIntent>)IntentElement.DeepCopy();
                if (PriorityElement != null) dest.PriorityElement = (Code<RequestPriority>)PriorityElement.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (Focus != null) dest.Focus = (ResourceReference)Focus.DeepCopy();
                if (For != null) dest.For = (ResourceReference)For.DeepCopy();
                if (Context != null) dest.Context = (ResourceReference)Context.DeepCopy();
                if (ExecutionPeriod != null) dest.ExecutionPeriod = (Period)ExecutionPeriod.DeepCopy();
                if (AuthoredOnElement != null) dest.AuthoredOnElement = (FhirDateTime)AuthoredOnElement.DeepCopy();
                if (LastModifiedElement != null) dest.LastModifiedElement = (FhirDateTime)LastModifiedElement.DeepCopy();
                if (Requester != null) dest.Requester = (RequesterComponent)Requester.DeepCopy();
                if (PerformerType != null) dest.PerformerType = new List<CodeableConcept>(PerformerType.DeepCopy());
                if (Owner != null) dest.Owner = (ResourceReference)Owner.DeepCopy();
                if (Reason != null) dest.Reason = (CodeableConcept)Reason.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (RelevantHistory != null) dest.RelevantHistory = new List<ResourceReference>(RelevantHistory.DeepCopy());
                if (Restriction != null) dest.Restriction = (RestrictionComponent)Restriction.DeepCopy();
                if (Input != null) dest.Input = new List<ParameterComponent>(Input.DeepCopy());
                if (Output != null) dest.Output = new List<OutputComponent>(Output.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Task());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Task;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Definition, otherT.Definition)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.Matches(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.Matches(BusinessStatus, otherT.BusinessStatus)) return false;
            if (!DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.Matches(Focus, otherT.Focus)) return false;
            if (!DeepComparable.Matches(For, otherT.For)) return false;
            if (!DeepComparable.Matches(Context, otherT.Context)) return false;
            if (!DeepComparable.Matches(ExecutionPeriod, otherT.ExecutionPeriod)) return false;
            if (!DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.Matches(LastModifiedElement, otherT.LastModifiedElement)) return false;
            if (!DeepComparable.Matches(Requester, otherT.Requester)) return false;
            if ( !DeepComparable.Matches(PerformerType, otherT.PerformerType)) return false;
            if (!DeepComparable.Matches(Owner, otherT.Owner)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(RelevantHistory, otherT.RelevantHistory)) return false;
            if (!DeepComparable.Matches(Restriction, otherT.Restriction)) return false;
            if ( !DeepComparable.Matches(Input, otherT.Input)) return false;
            if ( !DeepComparable.Matches(Output, otherT.Output)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Task;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(GroupIdentifier, otherT.GroupIdentifier)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if (!DeepComparable.IsExactly(BusinessStatus, otherT.BusinessStatus)) return false;
            if (!DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
            if (!DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(Focus, otherT.Focus)) return false;
            if (!DeepComparable.IsExactly(For, otherT.For)) return false;
            if (!DeepComparable.IsExactly(Context, otherT.Context)) return false;
            if (!DeepComparable.IsExactly(ExecutionPeriod, otherT.ExecutionPeriod)) return false;
            if (!DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
            if (!DeepComparable.IsExactly(LastModifiedElement, otherT.LastModifiedElement)) return false;
            if (!DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
            if (!DeepComparable.IsExactly(PerformerType, otherT.PerformerType)) return false;
            if (!DeepComparable.IsExactly(Owner, otherT.Owner)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(RelevantHistory, otherT.RelevantHistory)) return false;
            if (!DeepComparable.IsExactly(Restriction, otherT.Restriction)) return false;
            if (!DeepComparable.IsExactly(Input, otherT.Input)) return false;
            if (!DeepComparable.IsExactly(Output, otherT.Output)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Definition != null) yield return Definition;
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                if (GroupIdentifier != null) yield return GroupIdentifier;
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (StatusReason != null) yield return StatusReason;
                if (BusinessStatus != null) yield return BusinessStatus;
                if (IntentElement != null) yield return IntentElement;
                if (PriorityElement != null) yield return PriorityElement;
                if (Code != null) yield return Code;
                if (DescriptionElement != null) yield return DescriptionElement;
                if (Focus != null) yield return Focus;
                if (For != null) yield return For;
                if (Context != null) yield return Context;
                if (ExecutionPeriod != null) yield return ExecutionPeriod;
                if (AuthoredOnElement != null) yield return AuthoredOnElement;
                if (LastModifiedElement != null) yield return LastModifiedElement;
                if (Requester != null) yield return Requester;
                foreach (var elem in PerformerType) { if (elem != null) yield return elem; }
                if (Owner != null) yield return Owner;
                if (Reason != null) yield return Reason;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in RelevantHistory) { if (elem != null) yield return elem; }
                if (Restriction != null) yield return Restriction;
                foreach (var elem in Input) { if (elem != null) yield return elem; }
                foreach (var elem in Output) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Definition != null) yield return new ElementValue("definition", Definition);
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                if (GroupIdentifier != null) yield return new ElementValue("groupIdentifier", GroupIdentifier);
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (StatusReason != null) yield return new ElementValue("statusReason", StatusReason);
                if (BusinessStatus != null) yield return new ElementValue("businessStatus", BusinessStatus);
                if (IntentElement != null) yield return new ElementValue("intent", IntentElement);
                if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
                if (Code != null) yield return new ElementValue("code", Code);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                if (Focus != null) yield return new ElementValue("focus", Focus);
                if (For != null) yield return new ElementValue("for", For);
                if (Context != null) yield return new ElementValue("context", Context);
                if (ExecutionPeriod != null) yield return new ElementValue("executionPeriod", ExecutionPeriod);
                if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", AuthoredOnElement);
                if (LastModifiedElement != null) yield return new ElementValue("lastModified", LastModifiedElement);
                if (Requester != null) yield return new ElementValue("requester", Requester);
                foreach (var elem in PerformerType) { if (elem != null) yield return new ElementValue("performerType", elem); }
                if (Owner != null) yield return new ElementValue("owner", Owner);
                if (Reason != null) yield return new ElementValue("reason", Reason);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in RelevantHistory) { if (elem != null) yield return new ElementValue("relevantHistory", elem); }
                if (Restriction != null) yield return new ElementValue("restriction", Restriction);
                foreach (var elem in Input) { if (elem != null) yield return new ElementValue("input", elem); }
                foreach (var elem in Output) { if (elem != null) yield return new ElementValue("output", elem); }
            }
        }

    }

}
