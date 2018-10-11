using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using Hl7.Fhir.Validation.DSTU2;
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
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
{
    /// <summary>
    /// A request to perform an action
    /// </summary>
    [FhirType("Order", IsResource=true)]
    [DataContract]
    public partial class Order : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Order; } }
        [NotMapped]
        public override string TypeName { get { return "Order"; } }


        [FhirType("WhenComponent")]
        [DataContract]
        public partial class WhenComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "WhenComponent"; } }

            /// <summary>
            /// Code specifies when request should be done. The code may simply be a priority code
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// A formal schedule
            /// </summary>
            [FhirElement("schedule", InSummary=true, Order=50)]
            [DataMember]
            public Timing Schedule
            {
                get { return _schedule; }
                set { _schedule = value; OnPropertyChanged("Schedule"); }
            }

            private Timing _schedule;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as WhenComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Schedule != null) dest.Schedule = (Timing)Schedule.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new WhenComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as WhenComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Schedule, otherT.Schedule)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as WhenComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Schedule != null) yield return Schedule;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Schedule != null) yield return new ElementValue("schedule", Schedule);
                }
            }


        }


        /// <summary>
        /// Identifiers assigned to this order by the orderer or by the receiver
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier == null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// When the order was made
        /// </summary>
        [FhirElement("date", InSummary=true, Order=100)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// When the order was made
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
        /// Patient this order is about
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=110)]
        [References("Patient","Group","Device","Substance")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Who initiated the order
        /// </summary>
        [FhirElement("source", InSummary=true, Order=120)]
        [References("Practitioner","Organization")]
        [DataMember]
        public ResourceReference Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private ResourceReference _source;

        /// <summary>
        /// Who is intended to fulfill the order
        /// </summary>
        [FhirElement("target", InSummary=true, Order=130)]
        [References("Organization","Device","Practitioner")]
        [DataMember]
        public ResourceReference Target
        {
            get { return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private ResourceReference _target;

        /// <summary>
        /// Text - why the order was made
        /// </summary>
        [FhirElement("reason", InSummary=true, Order=140, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(CodeableConcept),typeof(ResourceReference))]
        [DataMember]
        public Element Reason
        {
            get { return _reason; }
            set { _reason = value; OnPropertyChanged("Reason"); }
        }

        private Element _reason;

        /// <summary>
        /// When order should be fulfilled
        /// </summary>
        [FhirElement("when", InSummary=true, Order=150)]
        [DataMember]
        public WhenComponent When
        {
            get { return _when; }
            set { _when = value; OnPropertyChanged("When"); }
        }

        private WhenComponent _when;

        /// <summary>
        /// What action is being ordered
        /// </summary>
        [FhirElement("detail", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<ResourceReference> Detail
        {
            get { if (_detail == null) _detail = new List<ResourceReference>(); return _detail; }
            set { _detail = value; OnPropertyChanged("Detail"); }
        }

        private List<ResourceReference> _detail;


        public static ElementDefinition.ConstraintComponent Order_ORD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "when.all(code.empty() or schedule.empty())",
            Key = "ord-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Provide a code or a schedule, but not both",
            Xpath = "exists(f:code) != exists(f:schedule)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Order_ORD_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Order;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Source != null) dest.Source = (ResourceReference)Source.DeepCopy();
                if (Target != null) dest.Target = (ResourceReference)Target.DeepCopy();
                if (Reason != null) dest.Reason = (Element)Reason.DeepCopy();
                if (When != null) dest.When = (WhenComponent)When.DeepCopy();
                if (Detail != null) dest.Detail = new List<ResourceReference>(Detail.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Order());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Order;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if (!DeepComparable.Matches(Target, otherT.Target)) return false;
            if (!DeepComparable.Matches(Reason, otherT.Reason)) return false;
            if (!DeepComparable.Matches(When, otherT.When)) return false;
            if (!DeepComparable.Matches(Detail, otherT.Detail)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Order;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
            if (!DeepComparable.IsExactly(When, otherT.When)) return false;
            if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (DateElement != null) yield return DateElement;
                if (Subject != null) yield return Subject;
                if (Source != null) yield return Source;
                if (Target != null) yield return Target;
                if (Reason != null) yield return Reason;
                if (When != null) yield return When;
                foreach (var elem in Detail) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Source != null) yield return new ElementValue("source", Source);
                if (Target != null) yield return new ElementValue("target", Target);
                if (Reason != null) yield return new ElementValue("reason", Reason);
                if (When != null) yield return new ElementValue("when", When);
                foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
            }
        }

    }

}
