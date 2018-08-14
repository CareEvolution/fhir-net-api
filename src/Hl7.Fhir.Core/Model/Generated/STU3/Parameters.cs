﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
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
// Generated for FHIR v3.0.1
//
namespace Hl7.Fhir.Model.STU3
{
    /// <summary>
    /// Operation Request or Response
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.STU3, "Parameters", IsResource=true)]
    [DataContract]
    public partial class Parameters : Hl7.Fhir.Model.STU3.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Parameters; } }
        [NotMapped]
        public override string TypeName { get { return "Parameters"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "ParameterComponent")]
        [DataContract]
        public partial class ParameterComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ParameterComponent"; } }
            
            /// <summary>
            /// Name from the definition
            /// </summary>
            [FhirElement("name", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Name from the definition
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Name");
                }
            }
            
            /// <summary>
            /// If parameter is a data type
            /// </summary>
            [FhirElement("value", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.Base64Binary),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.STU3.Code),typeof(Hl7.Fhir.Model.STU3.Date),typeof(Hl7.Fhir.Model.STU3.FhirDateTime),typeof(Hl7.Fhir.Model.STU3.FhirDecimal),typeof(Hl7.Fhir.Model.STU3.Id),typeof(Hl7.Fhir.Model.Instant),typeof(Hl7.Fhir.Model.STU3.Integer),typeof(Hl7.Fhir.Model.Markdown),typeof(Hl7.Fhir.Model.STU3.Oid),typeof(Hl7.Fhir.Model.STU3.PositiveInt),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.STU3.Time),typeof(Hl7.Fhir.Model.STU3.UnsignedInt),typeof(Hl7.Fhir.Model.FhirUri),typeof(Hl7.Fhir.Model.STU3.Address),typeof(Hl7.Fhir.Model.STU3.Age),typeof(Hl7.Fhir.Model.STU3.Annotation),typeof(Hl7.Fhir.Model.STU3.Attachment),typeof(Hl7.Fhir.Model.STU3.CodeableConcept),typeof(Hl7.Fhir.Model.STU3.Coding),typeof(Hl7.Fhir.Model.STU3.ContactPoint),typeof(Hl7.Fhir.Model.STU3.Count),typeof(Hl7.Fhir.Model.STU3.Distance),typeof(Hl7.Fhir.Model.STU3.Duration),typeof(Hl7.Fhir.Model.STU3.HumanName),typeof(Hl7.Fhir.Model.STU3.Identifier),typeof(Hl7.Fhir.Model.STU3.Money),typeof(Hl7.Fhir.Model.STU3.Period),typeof(Hl7.Fhir.Model.STU3.Quantity),typeof(Hl7.Fhir.Model.STU3.Range),typeof(Hl7.Fhir.Model.STU3.Ratio),typeof(Hl7.Fhir.Model.STU3.ResourceReference),typeof(Hl7.Fhir.Model.STU3.SampledData),typeof(Hl7.Fhir.Model.STU3.Signature),typeof(Hl7.Fhir.Model.STU3.Timing),typeof(Hl7.Fhir.Model.STU3.Meta))]
            [DataMember]
            public Hl7.Fhir.Model.Element Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.Element _Value;
            
            /// <summary>
            /// If parameter is a whole resource
            /// </summary>
            [FhirElement("resource", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.STU3.Resource))]
            [DataMember]
            public Hl7.Fhir.Model.STU3.Resource Resource
            {
                get { return _Resource; }
                set { _Resource = value; OnPropertyChanged("Resource"); }
            }
            
            private Hl7.Fhir.Model.STU3.Resource _Resource;
            
            /// <summary>
            /// Named part of a multi-part parameter
            /// </summary>
            [FhirElement("part", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=70)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ParameterComponent> Part
            {
                get { if(_Part==null) _Part = new List<ParameterComponent>(); return _Part; }
                set { _Part = value; OnPropertyChanged("Part"); }
            }
            
            private List<ParameterComponent> _Part;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ParameterComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.Element)Value.DeepCopy();
                    if(Resource != null) dest.Resource = (Hl7.Fhir.Model.STU3.Resource)Resource.DeepCopy();
                    if(Part != null) dest.Part = new List<ParameterComponent>(Part.DeepCopy());
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
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
                if( !DeepComparable.Matches(Resource, otherT.Resource)) return false;
                if( !DeepComparable.Matches(Part, otherT.Part)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ParameterComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if( !DeepComparable.IsExactly(Resource, otherT.Resource)) return false;
                if( !DeepComparable.IsExactly(Part, otherT.Part)) return false;
            
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
        [FhirElement("parameter", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ParameterComponent> Parameter
        {
            get { if(_Parameter==null) _Parameter = new List<ParameterComponent>(); return _Parameter; }
            set { _Parameter = value; OnPropertyChanged("Parameter"); }
        }
        
        private List<ParameterComponent> _Parameter;
    
    
        public static ElementDefinitionConstraint Parameters_INV_1 = new ElementDefinitionConstraint
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
                if(Parameter != null) dest.Parameter = new List<ParameterComponent>(Parameter.DeepCopy());
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
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Parameter, otherT.Parameter)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Parameters;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Parameter, otherT.Parameter)) return false;
        
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
