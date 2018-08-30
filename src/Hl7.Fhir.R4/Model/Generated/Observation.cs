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
// Generated for FHIR v3.5.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Measurements and simple assertions
    /// </summary>
    [FhirType("Observation", IsResource=true)]
    [DataContract]
    public partial class Observation : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Observation; } }
        [NotMapped]
        public override string TypeName { get { return "Observation"; } }


        [FhirType("ReferenceRangeComponent")]
        [DataContract]
        public partial class ReferenceRangeComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ReferenceRangeComponent"; } }

            /// <summary>
            /// Low Range, if relevant
            /// </summary>
            [FhirElement("low", Order=40)]
            [DataMember]
            public SimpleQuantity Low
            {
                get { return _low; }
                set { _low = value; OnPropertyChanged("Low"); }
            }

            private SimpleQuantity _low;

            /// <summary>
            /// High Range, if relevant
            /// </summary>
            [FhirElement("high", Order=50)]
            [DataMember]
            public SimpleQuantity High
            {
                get { return _high; }
                set { _high = value; OnPropertyChanged("High"); }
            }

            private SimpleQuantity _high;

            /// <summary>
            /// Reference range qualifier
            /// </summary>
            [FhirElement("type", Order=60)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Reference range population
            /// </summary>
            [FhirElement("appliesTo", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> AppliesTo
            {
                get { if (_appliesTo==null) _appliesTo = new List<CodeableConcept>(); return _appliesTo; }
                set { _appliesTo = value; OnPropertyChanged("AppliesTo"); }
            }

            private List<CodeableConcept> _appliesTo;

            /// <summary>
            /// Applicable age range, if relevant
            /// </summary>
            [FhirElement("age", Order=80)]
            [DataMember]
            public Range Age
            {
                get { return _age; }
                set { _age = value; OnPropertyChanged("Age"); }
            }

            private Range _age;

            /// <summary>
            /// Text based reference range in an observation
            /// </summary>
            [FhirElement("text", Order=90)]
            [DataMember]
            public FhirString TextElement
            {
                get { return _textElement; }
                set { _textElement = value; OnPropertyChanged("TextElement"); }
            }

            private FhirString _textElement;

            /// <summary>
            /// Text based reference range in an observation
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

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReferenceRangeComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Low != null) dest.Low = (SimpleQuantity)Low.DeepCopy();
                    if (High != null) dest.High = (SimpleQuantity)High.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (AppliesTo != null) dest.AppliesTo = new List<CodeableConcept>(AppliesTo.DeepCopy());
                    if (Age != null) dest.Age = (Range)Age.DeepCopy();
                    if (TextElement != null) dest.TextElement = (FhirString)TextElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ReferenceRangeComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReferenceRangeComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Low, otherT.Low)) return false;
                if (!DeepComparable.Matches(High, otherT.High)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if ( !DeepComparable.Matches(AppliesTo, otherT.AppliesTo)) return false;
                if (!DeepComparable.Matches(Age, otherT.Age)) return false;
                if (!DeepComparable.Matches(TextElement, otherT.TextElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReferenceRangeComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Low, otherT.Low)) return false;
                if (!DeepComparable.IsExactly(High, otherT.High)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(AppliesTo, otherT.AppliesTo)) return false;
                if (!DeepComparable.IsExactly(Age, otherT.Age)) return false;
                if (!DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Low != null) yield return Low;
                    if (High != null) yield return High;
                    if (Type != null) yield return Type;
                    foreach (var elem in AppliesTo) { if (elem != null) yield return elem; }
                    if (Age != null) yield return Age;
                    if (TextElement != null) yield return TextElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Low != null) yield return new ElementValue("low", Low);
                    if (High != null) yield return new ElementValue("high", High);
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in AppliesTo) { if (elem != null) yield return new ElementValue("appliesTo", elem); }
                    if (Age != null) yield return new ElementValue("age", Age);
                    if (TextElement != null) yield return new ElementValue("text", TextElement);
                }
            }


        }


        [FhirType("ComponentComponent")]
        [DataContract]
        public partial class ComponentComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ComponentComponent"; } }

            /// <summary>
            /// Type of component observation (code / type)
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Actual component result
            /// </summary>
            [FhirElement("value", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Quantity),typeof(CodeableConcept),typeof(FhirString),typeof(FhirBoolean),typeof(Integer),typeof(Range),typeof(Ratio),typeof(SampledData),typeof(Time),typeof(FhirDateTime),typeof(Period))]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            /// <summary>
            /// Why the component result is missing
            /// </summary>
            [FhirElement("dataAbsentReason", Order=60)]
            [DataMember]
            public CodeableConcept DataAbsentReason
            {
                get { return _dataAbsentReason; }
                set { _dataAbsentReason = value; OnPropertyChanged("DataAbsentReason"); }
            }

            private CodeableConcept _dataAbsentReason;

            /// <summary>
            /// High, low, normal, etc.
            /// </summary>
            [FhirElement("interpretation", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Interpretation
            {
                get { if (_interpretation==null) _interpretation = new List<CodeableConcept>(); return _interpretation; }
                set { _interpretation = value; OnPropertyChanged("Interpretation"); }
            }

            private List<CodeableConcept> _interpretation;

            /// <summary>
            /// Provides guide for interpretation of component result
            /// </summary>
            [FhirElement("referenceRange", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ReferenceRangeComponent> ReferenceRange
            {
                get { if (_referenceRange==null) _referenceRange = new List<ReferenceRangeComponent>(); return _referenceRange; }
                set { _referenceRange = value; OnPropertyChanged("ReferenceRange"); }
            }

            private List<ReferenceRangeComponent> _referenceRange;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ComponentComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    if (DataAbsentReason != null) dest.DataAbsentReason = (CodeableConcept)DataAbsentReason.DeepCopy();
                    if (Interpretation != null) dest.Interpretation = new List<CodeableConcept>(Interpretation.DeepCopy());
                    if (ReferenceRange != null) dest.ReferenceRange = new List<ReferenceRangeComponent>(ReferenceRange.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ComponentComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ComponentComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;
                if (!DeepComparable.Matches(DataAbsentReason, otherT.DataAbsentReason)) return false;
                if ( !DeepComparable.Matches(Interpretation, otherT.Interpretation)) return false;
                if ( !DeepComparable.Matches(ReferenceRange, otherT.ReferenceRange)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ComponentComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if (!DeepComparable.IsExactly(DataAbsentReason, otherT.DataAbsentReason)) return false;
                if (!DeepComparable.IsExactly(Interpretation, otherT.Interpretation)) return false;
                if (!DeepComparable.IsExactly(ReferenceRange, otherT.ReferenceRange)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (Value != null) yield return Value;
                    if (DataAbsentReason != null) yield return DataAbsentReason;
                    foreach (var elem in Interpretation) { if (elem != null) yield return elem; }
                    foreach (var elem in ReferenceRange) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Value != null) yield return new ElementValue("value", Value);
                    if (DataAbsentReason != null) yield return new ElementValue("dataAbsentReason", DataAbsentReason);
                    foreach (var elem in Interpretation) { if (elem != null) yield return new ElementValue("interpretation", elem); }
                    foreach (var elem in ReferenceRange) { if (elem != null) yield return new ElementValue("referenceRange", elem); }
                }
            }


        }


        /// <summary>
        /// Business Identifier for observation
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
        /// Fulfills plan, proposal or order
        /// </summary>
        [FhirElement("basedOn", InSummary=true, Order=100)]
        [References("CarePlan","DeviceRequest","ImmunizationRecommendation","MedicationRequest","NutritionOrder","ServiceRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> BasedOn
        {
            get { if (_basedOn==null) _basedOn = new List<ResourceReference>(); return _basedOn; }
            set { _basedOn = value; OnPropertyChanged("BasedOn"); }
        }

        private List<ResourceReference> _basedOn;

        /// <summary>
        /// Part of referenced event
        /// </summary>
        [FhirElement("partOf", InSummary=true, Order=110)]
        [References("MedicationAdministration","MedicationDispense","MedicationStatement","Procedure","Immunization","ImagingStudy")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> PartOf
        {
            get { if (_partOf==null) _partOf = new List<ResourceReference>(); return _partOf; }
            set { _partOf = value; OnPropertyChanged("PartOf"); }
        }

        private List<ResourceReference> _partOf;

        /// <summary>
        /// registered | preliminary | final | amended +
        /// </summary>
        [FhirElement("status", InSummary=true, Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ObservationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ObservationStatus> _statusElement;

        /// <summary>
        /// registered | preliminary | final | amended +
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ObservationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ObservationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Classification of  type of observation
        /// </summary>
        [FhirElement("category", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Category
        {
            get { if (_category==null) _category = new List<CodeableConcept>(); return _category; }
            set { _category = value; OnPropertyChanged("Category"); }
        }

        private List<CodeableConcept> _category;

        /// <summary>
        /// Type of observation (code / type)
        /// </summary>
        [FhirElement("code", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// Who and/or what the observation is about
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=150)]
        [References("Patient","Group","Device","Location")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// What the observation is about, when it is not about the subject of record
        /// </summary>
        [FhirElement("focus", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Focus
        {
            get { if (_focus==null) _focus = new List<ResourceReference>(); return _focus; }
            set { _focus = value; OnPropertyChanged("Focus"); }
        }

        private List<ResourceReference> _focus;

        /// <summary>
        /// Healthcare event during which this observation is made
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=170)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Clinically relevant time/time-period for observation
        /// </summary>
        [FhirElement("effective", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirDateTime),typeof(Period),typeof(Timing),typeof(Instant))]
        [DataMember]
        public Element Effective
        {
            get { return _effective; }
            set { _effective = value; OnPropertyChanged("Effective"); }
        }

        private Element _effective;

        /// <summary>
        /// Date/Time this version was made available
        /// </summary>
        [FhirElement("issued", InSummary=true, Order=190)]
        [DataMember]
        public Instant IssuedElement
        {
            get { return _issuedElement; }
            set { _issuedElement = value; OnPropertyChanged("IssuedElement"); }
        }

        private Instant _issuedElement;

        /// <summary>
        /// Date/Time this version was made available
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public DateTimeOffset? Issued
        {
            get { return IssuedElement != null ? IssuedElement.Value : null; }
            set
            {
                if (value == null)
                    IssuedElement = null;
                else
                    IssuedElement = new Instant(value);
                OnPropertyChanged("Issued");
            }
        }

        /// <summary>
        /// Who is responsible for the observation
        /// </summary>
        [FhirElement("performer", InSummary=true, Order=200)]
        [References("Practitioner","PractitionerRole","Organization","CareTeam","Patient","RelatedPerson")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> Performer
        {
            get { if (_performer==null) _performer = new List<ResourceReference>(); return _performer; }
            set { _performer = value; OnPropertyChanged("Performer"); }
        }

        private List<ResourceReference> _performer;

        /// <summary>
        /// Actual result
        /// </summary>
        [FhirElement("value", InSummary=true, Order=210, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(Quantity),typeof(CodeableConcept),typeof(FhirString),typeof(FhirBoolean),typeof(Integer),typeof(Range),typeof(Ratio),typeof(SampledData),typeof(Time),typeof(FhirDateTime),typeof(Period))]
        [DataMember]
        public Element Value
        {
            get { return _value; }
            set { _value = value; OnPropertyChanged("Value"); }
        }

        private Element _value;

        /// <summary>
        /// Why the result is missing
        /// </summary>
        [FhirElement("dataAbsentReason", Order=220)]
        [DataMember]
        public CodeableConcept DataAbsentReason
        {
            get { return _dataAbsentReason; }
            set { _dataAbsentReason = value; OnPropertyChanged("DataAbsentReason"); }
        }

        private CodeableConcept _dataAbsentReason;

        /// <summary>
        /// High, low, normal, etc.
        /// </summary>
        [FhirElement("interpretation", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Interpretation
        {
            get { if (_interpretation==null) _interpretation = new List<CodeableConcept>(); return _interpretation; }
            set { _interpretation = value; OnPropertyChanged("Interpretation"); }
        }

        private List<CodeableConcept> _interpretation;

        /// <summary>
        /// Comments about the test result value
        /// </summary>
        [FhirElement("comment", Order=240)]
        [DataMember]
        public FhirString CommentElement
        {
            get { return _commentElement; }
            set { _commentElement = value; OnPropertyChanged("CommentElement"); }
        }

        private FhirString _commentElement;

        /// <summary>
        /// Comments about the test result value
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

        /// <summary>
        /// Observed body part
        /// </summary>
        [FhirElement("bodySite", Order=250)]
        [DataMember]
        public CodeableConcept BodySite
        {
            get { return _bodySite; }
            set { _bodySite = value; OnPropertyChanged("BodySite"); }
        }

        private CodeableConcept _bodySite;

        /// <summary>
        /// How it was done
        /// </summary>
        [FhirElement("method", Order=260)]
        [DataMember]
        public CodeableConcept Method
        {
            get { return _method; }
            set { _method = value; OnPropertyChanged("Method"); }
        }

        private CodeableConcept _method;

        /// <summary>
        /// Specimen used for this observation
        /// </summary>
        [FhirElement("specimen", Order=270)]
        [References("Specimen")]
        [DataMember]
        public ResourceReference Specimen
        {
            get { return _specimen; }
            set { _specimen = value; OnPropertyChanged("Specimen"); }
        }

        private ResourceReference _specimen;

        /// <summary>
        /// (Measurement) Device
        /// </summary>
        [FhirElement("device", Order=280)]
        [References("Device","DeviceMetric")]
        [DataMember]
        public ResourceReference Device
        {
            get { return _device; }
            set { _device = value; OnPropertyChanged("Device"); }
        }

        private ResourceReference _device;

        /// <summary>
        /// Provides guide for interpretation
        /// </summary>
        [FhirElement("referenceRange", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ReferenceRangeComponent> ReferenceRange
        {
            get { if (_referenceRange==null) _referenceRange = new List<ReferenceRangeComponent>(); return _referenceRange; }
            set { _referenceRange = value; OnPropertyChanged("ReferenceRange"); }
        }

        private List<ReferenceRangeComponent> _referenceRange;

        /// <summary>
        /// Related resource that belongs to the Observation group
        /// </summary>
        [FhirElement("hasMember", InSummary=true, Order=300)]
        [References("Observation","QuestionnaireResponse","Sequence")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> HasMember
        {
            get { if (_hasMember==null) _hasMember = new List<ResourceReference>(); return _hasMember; }
            set { _hasMember = value; OnPropertyChanged("HasMember"); }
        }

        private List<ResourceReference> _hasMember;

        /// <summary>
        /// Related measurements the observation is made from
        /// </summary>
        [FhirElement("derivedFrom", InSummary=true, Order=310)]
        [References("DocumentReference","ImagingStudy","Media","QuestionnaireResponse","Observation","Sequence")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ResourceReference> DerivedFrom
        {
            get { if (_derivedFrom==null) _derivedFrom = new List<ResourceReference>(); return _derivedFrom; }
            set { _derivedFrom = value; OnPropertyChanged("DerivedFrom"); }
        }

        private List<ResourceReference> _derivedFrom;

        /// <summary>
        /// Component results
        /// </summary>
        [FhirElement("component", InSummary=true, Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ComponentComponent> Component
        {
            get { if (_component==null) _component = new List<ComponentComponent>(); return _component; }
            set { _component = value; OnPropertyChanged("Component"); }
        }

        private List<ComponentComponent> _component;


        public static ElementDefinition.ConstraintComponent Observation_OBS_7 = new ElementDefinition.ConstraintComponent
        {
            Expression = "value.empty() or component.code.where( (coding.code = %resource.code.coding.code) and (coding.system = %resource.code.coding.system)).empty()",
            Key = "obs-7",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If Observation.code is the same as a Observation.component.code then the value element associated with the code SHALL NOT be present",
            Xpath = "not(f:*[starts-with(local-name(.), 'value')] and (for $coding in f:code/f:coding return f:component/f:code/f:coding[f:code/@value=$coding/f:code/@value] [f:system/@value=$coding/f:system/@value]))"
        };

        public static ElementDefinition.ConstraintComponent Observation_OBS_6 = new ElementDefinition.ConstraintComponent
        {
            Expression = "dataAbsentReason.empty() or value.empty()",
            Key = "obs-6",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "dataAbsentReason SHALL only be present if Observation.value[x] is not present",
            Xpath = "not(exists(f:dataAbsentReason)) or (not(exists(*[starts-with(local-name(.), 'value')])))"
        };

        public static ElementDefinition.ConstraintComponent Observation_OBS_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "referenceRange.all(low.exists() or high.exists() or text.exists())",
            Key = "obs-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "Must have at least a low or a high or text",
            Xpath = "(exists(f:low) or exists(f:high)or exists(f:text))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Observation_OBS_7);
            InvariantConstraints.Add(Observation_OBS_6);
            InvariantConstraints.Add(Observation_OBS_3);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Observation;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (BasedOn != null) dest.BasedOn = new List<ResourceReference>(BasedOn.DeepCopy());
                if (PartOf != null) dest.PartOf = new List<ResourceReference>(PartOf.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<ObservationStatus>)StatusElement.DeepCopy();
                if (Category != null) dest.Category = new List<CodeableConcept>(Category.DeepCopy());
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Focus != null) dest.Focus = new List<ResourceReference>(Focus.DeepCopy());
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (Effective != null) dest.Effective = (Element)Effective.DeepCopy();
                if (IssuedElement != null) dest.IssuedElement = (Instant)IssuedElement.DeepCopy();
                if (Performer != null) dest.Performer = new List<ResourceReference>(Performer.DeepCopy());
                if (Value != null) dest.Value = (Element)Value.DeepCopy();
                if (DataAbsentReason != null) dest.DataAbsentReason = (CodeableConcept)DataAbsentReason.DeepCopy();
                if (Interpretation != null) dest.Interpretation = new List<CodeableConcept>(Interpretation.DeepCopy());
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                if (BodySite != null) dest.BodySite = (CodeableConcept)BodySite.DeepCopy();
                if (Method != null) dest.Method = (CodeableConcept)Method.DeepCopy();
                if (Specimen != null) dest.Specimen = (ResourceReference)Specimen.DeepCopy();
                if (Device != null) dest.Device = (ResourceReference)Device.DeepCopy();
                if (ReferenceRange != null) dest.ReferenceRange = new List<ReferenceRangeComponent>(ReferenceRange.DeepCopy());
                if (HasMember != null) dest.HasMember = new List<ResourceReference>(HasMember.DeepCopy());
                if (DerivedFrom != null) dest.DerivedFrom = new List<ResourceReference>(DerivedFrom.DeepCopy());
                if (Component != null) dest.Component = new List<ComponentComponent>(Component.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Observation());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Observation;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if ( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
            if ( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if ( !DeepComparable.Matches(Category, otherT.Category)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if ( !DeepComparable.Matches(Focus, otherT.Focus)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(Effective, otherT.Effective)) return false;
            if (!DeepComparable.Matches(IssuedElement, otherT.IssuedElement)) return false;
            if ( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if (!DeepComparable.Matches(Value, otherT.Value)) return false;
            if (!DeepComparable.Matches(DataAbsentReason, otherT.DataAbsentReason)) return false;
            if ( !DeepComparable.Matches(Interpretation, otherT.Interpretation)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.Matches(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.Matches(Method, otherT.Method)) return false;
            if (!DeepComparable.Matches(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.Matches(Device, otherT.Device)) return false;
            if ( !DeepComparable.Matches(ReferenceRange, otherT.ReferenceRange)) return false;
            if ( !DeepComparable.Matches(HasMember, otherT.HasMember)) return false;
            if ( !DeepComparable.Matches(DerivedFrom, otherT.DerivedFrom)) return false;
            if ( !DeepComparable.Matches(Component, otherT.Component)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Observation;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
            if (!DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Category, otherT.Category)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Focus, otherT.Focus)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
            if (!DeepComparable.IsExactly(IssuedElement, otherT.IssuedElement)) return false;
            if (!DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;
            if (!DeepComparable.IsExactly(DataAbsentReason, otherT.DataAbsentReason)) return false;
            if (!DeepComparable.IsExactly(Interpretation, otherT.Interpretation)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.IsExactly(BodySite, otherT.BodySite)) return false;
            if (!DeepComparable.IsExactly(Method, otherT.Method)) return false;
            if (!DeepComparable.IsExactly(Specimen, otherT.Specimen)) return false;
            if (!DeepComparable.IsExactly(Device, otherT.Device)) return false;
            if (!DeepComparable.IsExactly(ReferenceRange, otherT.ReferenceRange)) return false;
            if (!DeepComparable.IsExactly(HasMember, otherT.HasMember)) return false;
            if (!DeepComparable.IsExactly(DerivedFrom, otherT.DerivedFrom)) return false;
            if (!DeepComparable.IsExactly(Component, otherT.Component)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
                foreach (var elem in PartOf) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                foreach (var elem in Category) { if (elem != null) yield return elem; }
                if (Code != null) yield return Code;
                if (Subject != null) yield return Subject;
                foreach (var elem in Focus) { if (elem != null) yield return elem; }
                if (Encounter != null) yield return Encounter;
                if (Effective != null) yield return Effective;
                if (IssuedElement != null) yield return IssuedElement;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                if (Value != null) yield return Value;
                if (DataAbsentReason != null) yield return DataAbsentReason;
                foreach (var elem in Interpretation) { if (elem != null) yield return elem; }
                if (CommentElement != null) yield return CommentElement;
                if (BodySite != null) yield return BodySite;
                if (Method != null) yield return Method;
                if (Specimen != null) yield return Specimen;
                if (Device != null) yield return Device;
                foreach (var elem in ReferenceRange) { if (elem != null) yield return elem; }
                foreach (var elem in HasMember) { if (elem != null) yield return elem; }
                foreach (var elem in DerivedFrom) { if (elem != null) yield return elem; }
                foreach (var elem in Component) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
                foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
                if (Code != null) yield return new ElementValue("code", Code);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                foreach (var elem in Focus) { if (elem != null) yield return new ElementValue("focus", elem); }
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Effective != null) yield return new ElementValue("effective", Effective);
                if (IssuedElement != null) yield return new ElementValue("issued", IssuedElement);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                if (Value != null) yield return new ElementValue("value", Value);
                if (DataAbsentReason != null) yield return new ElementValue("dataAbsentReason", DataAbsentReason);
                foreach (var elem in Interpretation) { if (elem != null) yield return new ElementValue("interpretation", elem); }
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                if (BodySite != null) yield return new ElementValue("bodySite", BodySite);
                if (Method != null) yield return new ElementValue("method", Method);
                if (Specimen != null) yield return new ElementValue("specimen", Specimen);
                if (Device != null) yield return new ElementValue("device", Device);
                foreach (var elem in ReferenceRange) { if (elem != null) yield return new ElementValue("referenceRange", elem); }
                foreach (var elem in HasMember) { if (elem != null) yield return new ElementValue("hasMember", elem); }
                foreach (var elem in DerivedFrom) { if (elem != null) yield return new ElementValue("derivedFrom", elem); }
                foreach (var elem in Component) { if (elem != null) yield return new ElementValue("component", elem); }
            }
        }

    }

}
