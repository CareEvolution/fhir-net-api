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
    /// Operation Request or Response
    /// </summary>
    [FhirType("Parameters", IsResource=true)]
    [DataContract]
    public partial class Parameters : Resource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Parameters; } }
        [NotMapped]
        public override string TypeName { get { return "Parameters"; } }


        [FhirType("ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }

            /// <summary>
            /// Name from the definition
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name from the definition
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
            /// If parameter is a data type
            /// </summary>
            [FhirElement("value", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Base64Binary),typeof(FhirBoolean),typeof(Canonical),typeof(Code),typeof(Date),typeof(FhirDateTime),typeof(FhirDecimal),typeof(Id),typeof(Instant),typeof(Integer),typeof(Markdown),typeof(Oid),typeof(PositiveInt),typeof(FhirString),typeof(Time),typeof(UnsignedInt),typeof(FhirUri),typeof(FhirUrl),typeof(Uuid),typeof(Address),typeof(Age),typeof(Annotation),typeof(Attachment),typeof(CodeableConcept),typeof(Coding),typeof(ContactPoint),typeof(Count),typeof(Distance),typeof(Duration),typeof(HumanName),typeof(Identifier),typeof(Money),typeof(Period),typeof(Quantity),typeof(Range),typeof(Ratio),typeof(ResourceReference),typeof(SampledData),typeof(Signature),typeof(Timing),typeof(ParameterDefinition),typeof(DataRequirement),typeof(RelatedArtifact),typeof(ContactDetail),typeof(Contributor),typeof(TriggerDefinition),typeof(UsageContext),typeof(Dosage))]
            [DataMember]
            public Element Value
            {
                get { return _value; }
                set { _value = value; OnPropertyChanged("Value"); }
            }

            private Element _value;

            /// <summary>
            /// If parameter is a whole resource
            /// </summary>
            [FhirElement("resource", InSummary=true, Order=60, Choice=ChoiceType.ResourceChoice)]
            [AllowedTypes(typeof(Resource))]
            [DataMember]
            public Resource Resource
            {
                get { return _resource; }
                set { _resource = value; OnPropertyChanged("Resource"); }
            }

            private Resource _resource;

            /// <summary>
            /// Named part of a multi-part parameter
            /// </summary>
            [FhirElement("part", InSummary=true, Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParameterComponent> Part
            {
                get { if (_part==null) _part = new List<ParameterComponent>(); return _part; }
                set { _part = value; OnPropertyChanged("Part"); }
            }

            private List<ParameterComponent> _part;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParameterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Value != null) dest.Value = (Element)Value.DeepCopy();
                    if (Resource != null) dest.Resource = (Resource)Resource.DeepCopy();
                    if (Part != null) dest.Part = new List<ParameterComponent>(Part.DeepCopy());
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
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.Matches(Value, otherT.Value)) return false;
                if (!DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if ( !DeepComparable.Matches(Part, otherT.Part)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if (!DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if (!DeepComparable.IsExactly(Part, otherT.Part)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    if (Value != null) yield return Value;
                    if (Resource != null) yield return Resource;
                    foreach (var elem in Part) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", false, NameElement);
                    if (Value != null) yield return new ElementValue("value", false, Value);
                    if (Resource != null) yield return new ElementValue("resource", false, Resource);
                    foreach (var elem in Part) { if (elem != null) yield return new ElementValue("part", true, elem); }
                }
            }


        }


        /// <summary>
        /// Operation Parameter
        /// </summary>
        [FhirElement("parameter", InSummary=true, Order=50)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParameterComponent> Parameter
        {
            get { if (_parameter==null) _parameter = new List<ParameterComponent>(); return _parameter; }
            set { _parameter = value; OnPropertyChanged("Parameter"); }
        }

        private List<ParameterComponent> _parameter;


        public static ElementDefinition.ConstraintComponent Parameters_INV_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "parameter.all((part.exists() and value.empty() and resource.empty()) or (part.empty() and (value.exists() xor resource.exists())))",
            Key = "inv-1",
            Severity = ConstraintSeverity.Warning,
            Human = "A parameter must have only one of (value, resource, part)",
            Xpath = "exists(f:value) or exists(f:resource) and not(exists(f:value) and exists(f:resource))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(Parameters_INV_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Parameters;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Parameter != null) dest.Parameter = new List<ParameterComponent>(Parameter.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Parameters());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Parameters;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Parameter, otherT.Parameter)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Parameters;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Parameter, otherT.Parameter)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Parameter) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Parameter) { if (elem != null) yield return new ElementValue("parameter", true, elem); }
            }
        }

    }

}
