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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Results of a measure evaluation
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "MeasureReport", IsResource=true)]
    [DataContract]
    public partial class MeasureReport : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MeasureReport; } }
        [NotMapped]
        public override string TypeName { get { return "MeasureReport"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "GroupComponent")]
        [DataContract]
        public partial class GroupComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "GroupComponent"; } }
            
            /// <summary>
            /// Meaning of the group
            /// </summary>
            [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Code;
            
            /// <summary>
            /// The populations in the group
            /// </summary>
            [FhirElement("population", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PopulationComponent> Population
            {
                get { if(_Population==null) _Population = new List<PopulationComponent>(); return _Population; }
                set { _Population = value; OnPropertyChanged("Population"); }
            }
            
            private List<PopulationComponent> _Population;
            
            /// <summary>
            /// What score this group achieved
            /// </summary>
            [FhirElement("measureScore", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Quantity MeasureScore
            {
                get { return _MeasureScore; }
                set { _MeasureScore = value; OnPropertyChanged("MeasureScore"); }
            }
            
            private Hl7.Fhir.Model.R4.Quantity _MeasureScore;
            
            /// <summary>
            /// Stratification results
            /// </summary>
            [FhirElement("stratifier", Order=70)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StratifierComponent> Stratifier
            {
                get { if(_Stratifier==null) _Stratifier = new List<StratifierComponent>(); return _Stratifier; }
                set { _Stratifier = value; OnPropertyChanged("Stratifier"); }
            }
            
            private List<StratifierComponent> _Stratifier;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GroupComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                    if(Population != null) dest.Population = new List<PopulationComponent>(Population.DeepCopy());
                    if(MeasureScore != null) dest.MeasureScore = (Hl7.Fhir.Model.R4.Quantity)MeasureScore.DeepCopy();
                    if(Stratifier != null) dest.Stratifier = new List<StratifierComponent>(Stratifier.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GroupComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GroupComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Population, otherT.Population)) return false;
                if( !DeepComparable.Matches(MeasureScore, otherT.MeasureScore)) return false;
                if( !DeepComparable.Matches(Stratifier, otherT.Stratifier)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GroupComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Population, otherT.Population)) return false;
                if( !DeepComparable.IsExactly(MeasureScore, otherT.MeasureScore)) return false;
                if( !DeepComparable.IsExactly(Stratifier, otherT.Stratifier)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in Population) { if (elem != null) yield return elem; }
                    if (MeasureScore != null) yield return MeasureScore;
                    foreach (var elem in Stratifier) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    foreach (var elem in Population) { if (elem != null) yield return new ElementValue("population", true, elem); }
                    if (MeasureScore != null) yield return new ElementValue("measureScore", false, MeasureScore);
                    foreach (var elem in Stratifier) { if (elem != null) yield return new ElementValue("stratifier", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PopulationComponent")]
        [DataContract]
        public partial class PopulationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "PopulationComponent"; } }
            
            /// <summary>
            /// initial-population | numerator | numerator-exclusion | denominator | denominator-exclusion | denominator-exception | measure-population | measure-population-exclusion | measure-observation
            /// </summary>
            [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Code;
            
            /// <summary>
            /// Size of the population
            /// </summary>
            [FhirElement("count", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Integer CountElement
            {
                get { return _CountElement; }
                set { _CountElement = value; OnPropertyChanged("CountElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Integer _CountElement;
            
            /// <summary>
            /// Size of the population
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Count
            {
                get { return CountElement != null ? CountElement.Value : null; }
                set
                {
                    if (value == null)
                        CountElement = null;
                    else
                        CountElement = new Hl7.Fhir.Model.R4.Integer(value);
                    OnPropertyChanged("Count");
                }
            }
            
            /// <summary>
            /// For subject-list reports, the subjects in this population
            /// </summary>
            [FhirElement("subjects", Order=60)]
            [CLSCompliant(false)]
            [References("List")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Subjects
            {
                get { return _Subjects; }
                set { _Subjects = value; OnPropertyChanged("Subjects"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Subjects;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PopulationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                    if(CountElement != null) dest.CountElement = (Hl7.Fhir.Model.R4.Integer)CountElement.DeepCopy();
                    if(Subjects != null) dest.Subjects = (Hl7.Fhir.Model.R4.ResourceReference)Subjects.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PopulationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(CountElement, otherT.CountElement)) return false;
                if( !DeepComparable.Matches(Subjects, otherT.Subjects)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PopulationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(CountElement, otherT.CountElement)) return false;
                if( !DeepComparable.IsExactly(Subjects, otherT.Subjects)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (CountElement != null) yield return CountElement;
                    if (Subjects != null) yield return Subjects;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (CountElement != null) yield return new ElementValue("count", false, CountElement);
                    if (Subjects != null) yield return new ElementValue("subjects", false, Subjects);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "StratifierComponent")]
        [DataContract]
        public partial class StratifierComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "StratifierComponent"; } }
            
            /// <summary>
            /// What stratifier of the group
            /// </summary>
            [FhirElement("code", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Code;
            
            /// <summary>
            /// Stratum results, one for each unique value in the stratifier
            /// </summary>
            [FhirElement("stratum", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StratifierGroupComponent> Stratum
            {
                get { if(_Stratum==null) _Stratum = new List<StratifierGroupComponent>(); return _Stratum; }
                set { _Stratum = value; OnPropertyChanged("Stratum"); }
            }
            
            private List<StratifierGroupComponent> _Stratum;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StratifierComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                    if(Stratum != null) dest.Stratum = new List<StratifierGroupComponent>(Stratum.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StratifierComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StratifierComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Stratum, otherT.Stratum)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StratifierComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Stratum, otherT.Stratum)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    foreach (var elem in Stratum) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    foreach (var elem in Stratum) { if (elem != null) yield return new ElementValue("stratum", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "StratifierGroupComponent")]
        [DataContract]
        public partial class StratifierGroupComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "StratifierGroupComponent"; } }
            
            /// <summary>
            /// The stratum value, e.g. male
            /// </summary>
            [FhirElement("value", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Value;
            
            /// <summary>
            /// Population results in this stratum
            /// </summary>
            [FhirElement("population", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<StratifierGroupPopulationComponent> Population
            {
                get { if(_Population==null) _Population = new List<StratifierGroupPopulationComponent>(); return _Population; }
                set { _Population = value; OnPropertyChanged("Population"); }
            }
            
            private List<StratifierGroupPopulationComponent> _Population;
            
            /// <summary>
            /// What score this stratum achieved
            /// </summary>
            [FhirElement("measureScore", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Quantity MeasureScore
            {
                get { return _MeasureScore; }
                set { _MeasureScore = value; OnPropertyChanged("MeasureScore"); }
            }
            
            private Hl7.Fhir.Model.R4.Quantity _MeasureScore;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StratifierGroupComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.R4.CodeableConcept)Value.DeepCopy();
                    if(Population != null) dest.Population = new List<StratifierGroupPopulationComponent>(Population.DeepCopy());
                    if(MeasureScore != null) dest.MeasureScore = (Hl7.Fhir.Model.R4.Quantity)MeasureScore.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StratifierGroupComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StratifierGroupComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
                if( !DeepComparable.Matches(Population, otherT.Population)) return false;
                if( !DeepComparable.Matches(MeasureScore, otherT.MeasureScore)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StratifierGroupComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
                if( !DeepComparable.IsExactly(Population, otherT.Population)) return false;
                if( !DeepComparable.IsExactly(MeasureScore, otherT.MeasureScore)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Value != null) yield return Value;
                    foreach (var elem in Population) { if (elem != null) yield return elem; }
                    if (MeasureScore != null) yield return MeasureScore;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Value != null) yield return new ElementValue("value", false, Value);
                    foreach (var elem in Population) { if (elem != null) yield return new ElementValue("population", true, elem); }
                    if (MeasureScore != null) yield return new ElementValue("measureScore", false, MeasureScore);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "StratifierGroupPopulationComponent")]
        [DataContract]
        public partial class StratifierGroupPopulationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "StratifierGroupPopulationComponent"; } }
            
            /// <summary>
            /// initial-population | numerator | numerator-exclusion | denominator | denominator-exclusion | denominator-exception | measure-population | measure-population-exclusion | measure-observation
            /// </summary>
            [FhirElement("code", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Code;
            
            /// <summary>
            /// Size of the population
            /// </summary>
            [FhirElement("count", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Integer CountElement
            {
                get { return _CountElement; }
                set { _CountElement = value; OnPropertyChanged("CountElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Integer _CountElement;
            
            /// <summary>
            /// Size of the population
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? Count
            {
                get { return CountElement != null ? CountElement.Value : null; }
                set
                {
                    if (value == null)
                        CountElement = null;
                    else
                        CountElement = new Hl7.Fhir.Model.R4.Integer(value);
                    OnPropertyChanged("Count");
                }
            }
            
            /// <summary>
            /// For subject-list reports, the subjects in this population
            /// </summary>
            [FhirElement("subjects", Order=60)]
            [CLSCompliant(false)]
            [References("List")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Subjects
            {
                get { return _Subjects; }
                set { _Subjects = value; OnPropertyChanged("Subjects"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Subjects;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as StratifierGroupPopulationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                    if(CountElement != null) dest.CountElement = (Hl7.Fhir.Model.R4.Integer)CountElement.DeepCopy();
                    if(Subjects != null) dest.Subjects = (Hl7.Fhir.Model.R4.ResourceReference)Subjects.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new StratifierGroupPopulationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as StratifierGroupPopulationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(CountElement, otherT.CountElement)) return false;
                if( !DeepComparable.Matches(Subjects, otherT.Subjects)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as StratifierGroupPopulationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(CountElement, otherT.CountElement)) return false;
                if( !DeepComparable.IsExactly(Subjects, otherT.Subjects)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Code != null) yield return Code;
                    if (CountElement != null) yield return CountElement;
                    if (Subjects != null) yield return Subjects;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    if (CountElement != null) yield return new ElementValue("count", false, CountElement);
                    if (Subjects != null) yield return new ElementValue("subjects", false, Subjects);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Additional identifier for the MeasureReport
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.R4.Identifier> _Identifier;
        
        /// <summary>
        /// complete | pending | error
        /// </summary>
        [FhirElement("status", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=100)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _StatusElement;
        
        /// <summary>
        /// complete | pending | error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// individual | subject-list | summary
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code TypeElement
        {
            get { return _TypeElement; }
            set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _TypeElement;
        
        /// <summary>
        /// individual | subject-list | summary
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Type
        {
            get { return TypeElement != null ? TypeElement.Value : null; }
            set
            {
                if (value == null)
                    TypeElement = null;
                else
                    TypeElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Type");
            }
        }
        
        /// <summary>
        /// What measure was calculated
        /// </summary>
        [FhirElement("measure", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.canonical Measure
        {
            get { return _Measure; }
            set { _Measure = value; OnPropertyChanged("Measure"); }
        }
        
        private Hl7.Fhir.Model.canonical _Measure;
        
        /// <summary>
        /// What individual(s) the report is for
        /// </summary>
        [FhirElement("subject", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [References("Patient","Practitioner","Location","Device","RelatedPerson","Group")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Subject;
        
        /// <summary>
        /// When the report was generated
        /// </summary>
        [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
        
        /// <summary>
        /// When the report was generated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                    DateElement = null;
                else
                    DateElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Who is reporting the data
        /// </summary>
        [FhirElement("reporter", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Location","Organization","Group")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Reporter
        {
            get { return _Reporter; }
            set { _Reporter = value; OnPropertyChanged("Reporter"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Reporter;
        
        /// <summary>
        /// What period the report covers
        /// </summary>
        [FhirElement("period", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Period Period
        {
            get { return _Period; }
            set { _Period = value; OnPropertyChanged("Period"); }
        }
        
        private Hl7.Fhir.Model.R4.Period _Period;
        
        /// <summary>
        /// Measure results for each group
        /// </summary>
        [FhirElement("group", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GroupComponent> Group
        {
            get { if(_Group==null) _Group = new List<GroupComponent>(); return _Group; }
            set { _Group = value; OnPropertyChanged("Group"); }
        }
        
        private List<GroupComponent> _Group;
        
        /// <summary>
        /// What data was used to calculate the measure score
        /// </summary>
        [FhirElement("evaluatedResources", Order=180)]
        [CLSCompliant(false)]
        [References("Bundle")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference EvaluatedResources
        {
            get { return _EvaluatedResources; }
            set { _EvaluatedResources = value; OnPropertyChanged("EvaluatedResources"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _EvaluatedResources;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MeasureReport;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.R4.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(TypeElement != null) dest.TypeElement = (Hl7.Fhir.Model.R4.Code)TypeElement.DeepCopy();
                if(Measure != null) dest.Measure = (Hl7.Fhir.Model.canonical)Measure.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.R4.ResourceReference)Subject.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                if(Reporter != null) dest.Reporter = (Hl7.Fhir.Model.R4.ResourceReference)Reporter.DeepCopy();
                if(Period != null) dest.Period = (Hl7.Fhir.Model.R4.Period)Period.DeepCopy();
                if(Group != null) dest.Group = new List<GroupComponent>(Group.DeepCopy());
                if(EvaluatedResources != null) dest.EvaluatedResources = (Hl7.Fhir.Model.R4.ResourceReference)EvaluatedResources.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MeasureReport());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MeasureReport;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.Matches(Measure, otherT.Measure)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Reporter, otherT.Reporter)) return false;
            if( !DeepComparable.Matches(Period, otherT.Period)) return false;
            if( !DeepComparable.Matches(Group, otherT.Group)) return false;
            if( !DeepComparable.Matches(EvaluatedResources, otherT.EvaluatedResources)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MeasureReport;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
            if( !DeepComparable.IsExactly(Measure, otherT.Measure)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Reporter, otherT.Reporter)) return false;
            if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
            if( !DeepComparable.IsExactly(Group, otherT.Group)) return false;
            if( !DeepComparable.IsExactly(EvaluatedResources, otherT.EvaluatedResources)) return false;
        
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
                if (TypeElement != null) yield return TypeElement;
                if (Measure != null) yield return Measure;
                if (Subject != null) yield return Subject;
                if (DateElement != null) yield return DateElement;
                if (Reporter != null) yield return Reporter;
                if (Period != null) yield return Period;
                foreach (var elem in Group) { if (elem != null) yield return elem; }
                if (EvaluatedResources != null) yield return EvaluatedResources;
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
                if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                if (Measure != null) yield return new ElementValue("measure", false, Measure);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (Reporter != null) yield return new ElementValue("reporter", false, Reporter);
                if (Period != null) yield return new ElementValue("period", false, Period);
                foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", true, elem); }
                if (EvaluatedResources != null) yield return new ElementValue("evaluatedResources", false, EvaluatedResources);
            }
        }
    
    }

}
