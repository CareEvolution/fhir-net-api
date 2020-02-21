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
// Generated for FHIR v4.0.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Definition of Medication Knowledge
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "MedicationKnowledge", IsResource=true)]
    [DataContract]
    public partial class MedicationKnowledge : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.MedicationKnowledge; } }
        [NotMapped]
        public override string TypeName { get { return "MedicationKnowledge"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "RelatedMedicationKnowledgeComponent")]
        [DataContract]
        public partial class RelatedMedicationKnowledgeComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedMedicationKnowledgeComponent"; } }
            
            /// <summary>
            /// Category of medicationKnowledge
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Associated documentation about the associated medication knowledge
            /// </summary>
            [FhirElement("reference", Order=50)]
            [CLSCompliant(false)]
            [References("MedicationKnowledge")]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.ResourceReference> Reference
            {
                get { if(_Reference==null) _Reference = new List<Hl7.Fhir.Model.ResourceReference>(); return _Reference; }
                set { _Reference = value; OnPropertyChanged("Reference"); }
            }
            
            private List<Hl7.Fhir.Model.ResourceReference> _Reference;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("RelatedMedicationKnowledgeComponent");
                base.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Type?.Serialize(sink);
                sink.BeginList("reference", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true);
                foreach(var item in Reference)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
                Reference = source.GetList<Hl7.Fhir.Model.ResourceReference>("reference", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"reference", typeof(Hl7.Fhir.Model.ResourceReference)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatedMedicationKnowledgeComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Reference != null) dest.Reference = new List<Hl7.Fhir.Model.ResourceReference>(Reference.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelatedMedicationKnowledgeComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatedMedicationKnowledgeComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Reference, otherT.Reference)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedMedicationKnowledgeComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Reference, otherT.Reference)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Reference) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Reference) { if (elem != null) yield return new ElementValue("reference", elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "MonographComponent")]
        [DataContract]
        public partial class MonographComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "MonographComponent"; } }
            
            /// <summary>
            /// The category of medication document
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Associated documentation about the medication
            /// </summary>
            [FhirElement("source", Order=50)]
            [CLSCompliant(false)]
            [References("DocumentReference","Media")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Source
            {
                get { return _Source; }
                set { _Source = value; OnPropertyChanged("Source"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Source;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("MonographComponent");
                base.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Type?.Serialize(sink);
                sink.Element("source", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Source?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
                Source = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("source", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"source", typeof(Hl7.Fhir.Model.ResourceReference)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MonographComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Source != null) dest.Source = (Hl7.Fhir.Model.ResourceReference)Source.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MonographComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MonographComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Source, otherT.Source)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MonographComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Source != null) yield return Source;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Source != null) yield return new ElementValue("source", Source);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "IngredientComponent")]
        [DataContract]
        public partial class IngredientComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "IngredientComponent"; } }
            
            /// <summary>
            /// Medication(s) or substance(s) contained in the medication
            /// </summary>
            [FhirElement("item", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Item
            {
                get { return _Item; }
                set { _Item = value; OnPropertyChanged("Item"); }
            }
            
            private Hl7.Fhir.Model.Element _Item;
            
            /// <summary>
            /// Active ingredient indicator
            /// </summary>
            [FhirElement("isActive", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean IsActiveElement
            {
                get { return _IsActiveElement; }
                set { _IsActiveElement = value; OnPropertyChanged("IsActiveElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _IsActiveElement;
            
            /// <summary>
            /// Active ingredient indicator
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? IsActive
            {
                get { return IsActiveElement != null ? IsActiveElement.Value : null; }
                set
                {
                    if (value == null)
                        IsActiveElement = null;
                    else
                        IsActiveElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("IsActive");
                }
            }
            
            /// <summary>
            /// Quantity of ingredient present
            /// </summary>
            [FhirElement("strength", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio Strength
            {
                get { return _Strength; }
                set { _Strength = value; OnPropertyChanged("Strength"); }
            }
            
            private Hl7.Fhir.Model.Ratio _Strength;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("IngredientComponent");
                base.Serialize(sink);
                sink.Element("item", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, true); Item?.Serialize(sink);
                sink.Element("isActive", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); IsActiveElement?.Serialize(sink);
                sink.Element("strength", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Strength?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Item = source.GetProperty<Hl7.Fhir.Model.Element>("item", Hl7.Fhir.Model.Version.All);
                IsActiveElement = source.GetBooleanProperty("isActive", Hl7.Fhir.Model.Version.All);
                Strength = source.GetProperty<Hl7.Fhir.Model.Ratio>("strength", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"item", typeof(Hl7.Fhir.Model.Element)},
                    {"isActive", typeof(Hl7.Fhir.Model.FhirBoolean)},
                    {"strength", typeof(Hl7.Fhir.Model.Ratio)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as IngredientComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Item != null) dest.Item = (Hl7.Fhir.Model.Element)Item.DeepCopy();
                    if(IsActiveElement != null) dest.IsActiveElement = (Hl7.Fhir.Model.FhirBoolean)IsActiveElement.DeepCopy();
                    if(Strength != null) dest.Strength = (Hl7.Fhir.Model.Ratio)Strength.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new IngredientComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as IngredientComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Item, otherT.Item)) return false;
                if( !DeepComparable.Matches(IsActiveElement, otherT.IsActiveElement)) return false;
                if( !DeepComparable.Matches(Strength, otherT.Strength)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as IngredientComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Item, otherT.Item)) return false;
                if( !DeepComparable.IsExactly(IsActiveElement, otherT.IsActiveElement)) return false;
                if( !DeepComparable.IsExactly(Strength, otherT.Strength)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Item != null) yield return Item;
                    if (IsActiveElement != null) yield return IsActiveElement;
                    if (Strength != null) yield return Strength;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Item != null) yield return new ElementValue("item", Item);
                    if (IsActiveElement != null) yield return new ElementValue("isActive", IsActiveElement);
                    if (Strength != null) yield return new ElementValue("strength", Strength);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "CostComponent")]
        [DataContract]
        public partial class CostComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "CostComponent"; } }
            
            /// <summary>
            /// The category of the cost information
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// The source or owner for the price information
            /// </summary>
            [FhirElement("source", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString SourceElement
            {
                get { return _SourceElement; }
                set { _SourceElement = value; OnPropertyChanged("SourceElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _SourceElement;
            
            /// <summary>
            /// The source or owner for the price information
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Source
            {
                get { return SourceElement != null ? SourceElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceElement = null;
                    else
                        SourceElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Source");
                }
            }
            
            /// <summary>
            /// The price of the medication
            /// </summary>
            [FhirElement("cost", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Money Cost
            {
                get { return _Cost; }
                set { _Cost = value; OnPropertyChanged("Cost"); }
            }
            
            private Hl7.Fhir.Model.R4.Money _Cost;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("CostComponent");
                base.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Type?.Serialize(sink);
                sink.Element("source", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); SourceElement?.Serialize(sink);
                sink.Element("cost", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Cost?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
                SourceElement = source.GetStringProperty("source", Hl7.Fhir.Model.Version.All);
                Cost = source.GetProperty<Hl7.Fhir.Model.R4.Money>("cost", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"source", typeof(Hl7.Fhir.Model.FhirString)},
                    {"cost", typeof(Hl7.Fhir.Model.R4.Money)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as CostComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(SourceElement != null) dest.SourceElement = (Hl7.Fhir.Model.FhirString)SourceElement.DeepCopy();
                    if(Cost != null) dest.Cost = (Hl7.Fhir.Model.R4.Money)Cost.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new CostComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as CostComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
                if( !DeepComparable.Matches(Cost, otherT.Cost)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as CostComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
                if( !DeepComparable.IsExactly(Cost, otherT.Cost)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (SourceElement != null) yield return SourceElement;
                    if (Cost != null) yield return Cost;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                    if (Cost != null) yield return new ElementValue("cost", Cost);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "MonitoringProgramComponent")]
        [DataContract]
        public partial class MonitoringProgramComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "MonitoringProgramComponent"; } }
            
            /// <summary>
            /// Type of program under which the medication is monitored
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Name of the reviewing program
            /// </summary>
            [FhirElement("name", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString NameElement
            {
                get { return _NameElement; }
                set { _NameElement = value; OnPropertyChanged("NameElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _NameElement;
            
            /// <summary>
            /// Name of the reviewing program
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
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("MonitoringProgramComponent");
                base.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Type?.Serialize(sink);
                sink.Element("name", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); NameElement?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
                NameElement = source.GetStringProperty("name", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"name", typeof(Hl7.Fhir.Model.FhirString)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MonitoringProgramComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(NameElement != null) dest.NameElement = (Hl7.Fhir.Model.FhirString)NameElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MonitoringProgramComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MonitoringProgramComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MonitoringProgramComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (NameElement != null) yield return NameElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "AdministrationGuidelinesComponent")]
        [DataContract]
        public partial class AdministrationGuidelinesComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "AdministrationGuidelinesComponent"; } }
            
            /// <summary>
            /// Dosage for the medication for the specific guidelines
            /// </summary>
            [FhirElement("dosage", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<DosageComponent> Dosage
            {
                get { if(_Dosage==null) _Dosage = new List<DosageComponent>(); return _Dosage; }
                set { _Dosage = value; OnPropertyChanged("Dosage"); }
            }
            
            private List<DosageComponent> _Dosage;
            
            /// <summary>
            /// Indication for use that apply to the specific administration guidelines
            /// </summary>
            [FhirElement("indication", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
            [DataMember]
            public Hl7.Fhir.Model.Element Indication
            {
                get { return _Indication; }
                set { _Indication = value; OnPropertyChanged("Indication"); }
            }
            
            private Hl7.Fhir.Model.Element _Indication;
            
            /// <summary>
            /// Characteristics of the patient that are relevant to the administration guidelines
            /// </summary>
            [FhirElement("patientCharacteristics", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<PatientCharacteristicsComponent> PatientCharacteristics
            {
                get { if(_PatientCharacteristics==null) _PatientCharacteristics = new List<PatientCharacteristicsComponent>(); return _PatientCharacteristics; }
                set { _PatientCharacteristics = value; OnPropertyChanged("PatientCharacteristics"); }
            }
            
            private List<PatientCharacteristicsComponent> _PatientCharacteristics;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("AdministrationGuidelinesComponent");
                base.Serialize(sink);
                sink.BeginList("dosage", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in Dosage)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.Element("indication", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, true); Indication?.Serialize(sink);
                sink.BeginList("patientCharacteristics", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in PatientCharacteristics)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Dosage = source.GetList<DosageComponent>("dosage", Hl7.Fhir.Model.Version.All);
                Indication = source.GetProperty<Hl7.Fhir.Model.Element>("indication", Hl7.Fhir.Model.Version.All);
                PatientCharacteristics = source.GetList<PatientCharacteristicsComponent>("patientCharacteristics", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"dosage", typeof(DosageComponent)},
                    {"indication", typeof(Hl7.Fhir.Model.Element)},
                    {"patientCharacteristics", typeof(PatientCharacteristicsComponent)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AdministrationGuidelinesComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Dosage != null) dest.Dosage = new List<DosageComponent>(Dosage.DeepCopy());
                    if(Indication != null) dest.Indication = (Hl7.Fhir.Model.Element)Indication.DeepCopy();
                    if(PatientCharacteristics != null) dest.PatientCharacteristics = new List<PatientCharacteristicsComponent>(PatientCharacteristics.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AdministrationGuidelinesComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AdministrationGuidelinesComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Dosage, otherT.Dosage)) return false;
                if( !DeepComparable.Matches(Indication, otherT.Indication)) return false;
                if( !DeepComparable.Matches(PatientCharacteristics, otherT.PatientCharacteristics)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AdministrationGuidelinesComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;
                if( !DeepComparable.IsExactly(Indication, otherT.Indication)) return false;
                if( !DeepComparable.IsExactly(PatientCharacteristics, otherT.PatientCharacteristics)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Dosage) { if (elem != null) yield return elem; }
                    if (Indication != null) yield return Indication;
                    foreach (var elem in PatientCharacteristics) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", elem); }
                    if (Indication != null) yield return new ElementValue("indication", Indication);
                    foreach (var elem in PatientCharacteristics) { if (elem != null) yield return new ElementValue("patientCharacteristics", elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DosageComponent")]
        [DataContract]
        public partial class DosageComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "DosageComponent"; } }
            
            /// <summary>
            /// Type of dosage
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Dosage for the medication for the specific guidelines
            /// </summary>
            [FhirElement("dosage", Order=50)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.Dosage> Dosage
            {
                get { if(_Dosage==null) _Dosage = new List<Hl7.Fhir.Model.R4.Dosage>(); return _Dosage; }
                set { _Dosage = value; OnPropertyChanged("Dosage"); }
            }
            
            private List<Hl7.Fhir.Model.R4.Dosage> _Dosage;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("DosageComponent");
                base.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Type?.Serialize(sink);
                sink.BeginList("dosage", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true);
                foreach(var item in Dosage)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
                Dosage = source.GetList<Hl7.Fhir.Model.R4.Dosage>("dosage", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"dosage", typeof(Hl7.Fhir.Model.R4.Dosage)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DosageComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Dosage != null) dest.Dosage = new List<Hl7.Fhir.Model.R4.Dosage>(Dosage.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DosageComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DosageComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Dosage, otherT.Dosage)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DosageComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Dosage) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PatientCharacteristicsComponent")]
        [DataContract]
        public partial class PatientCharacteristicsComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "PatientCharacteristicsComponent"; } }
            
            /// <summary>
            /// Specific characteristic that is relevant to the administration guideline
            /// </summary>
            [FhirElement("characteristic", Order=40, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.SimpleQuantity))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Characteristic
            {
                get { return _Characteristic; }
                set { _Characteristic = value; OnPropertyChanged("Characteristic"); }
            }
            
            private Hl7.Fhir.Model.Element _Characteristic;
            
            /// <summary>
            /// The specific characteristic
            /// </summary>
            [FhirElement("value", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.FhirString> ValueElement
            {
                get { if(_ValueElement==null) _ValueElement = new List<Hl7.Fhir.Model.FhirString>(); return _ValueElement; }
                set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
            }
            
            private List<Hl7.Fhir.Model.FhirString> _ValueElement;
            
            /// <summary>
            /// The specific characteristic
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public IEnumerable<string> Value
            {
                get { return ValueElement != null ? ValueElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                    OnPropertyChanged("Value");
                }
            }
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("PatientCharacteristicsComponent");
                base.Serialize(sink);
                sink.Element("characteristic", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, true); Characteristic?.Serialize(sink);
                sink.BeginList("value", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                sink.Serialize(ValueElement);
                sink.End();
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Characteristic = source.GetProperty<Hl7.Fhir.Model.Element>("characteristic", Hl7.Fhir.Model.Version.All);
                ValueElement = source.GetStringList("value", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"characteristic", typeof(Hl7.Fhir.Model.Element)},
                    {"value", typeof(Hl7.Fhir.Model.FhirString)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PatientCharacteristicsComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Characteristic != null) dest.Characteristic = (Hl7.Fhir.Model.Element)Characteristic.DeepCopy();
                    if(ValueElement != null) dest.ValueElement = new List<Hl7.Fhir.Model.FhirString>(ValueElement.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PatientCharacteristicsComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PatientCharacteristicsComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Characteristic, otherT.Characteristic)) return false;
                if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PatientCharacteristicsComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Characteristic, otherT.Characteristic)) return false;
                if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Characteristic != null) yield return Characteristic;
                    foreach (var elem in ValueElement) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Characteristic != null) yield return new ElementValue("characteristic", Characteristic);
                    foreach (var elem in ValueElement) { if (elem != null) yield return new ElementValue("value", elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "MedicineClassificationComponent")]
        [DataContract]
        public partial class MedicineClassificationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "MedicineClassificationComponent"; } }
            
            /// <summary>
            /// The type of category for the medication (for example, therapeutic classification, therapeutic sub-classification)
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Specific category assigned to the medication
            /// </summary>
            [FhirElement("classification", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Classification
            {
                get { if(_Classification==null) _Classification = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Classification; }
                set { _Classification = value; OnPropertyChanged("Classification"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Classification;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("MedicineClassificationComponent");
                base.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Type?.Serialize(sink);
                sink.BeginList("classification", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in Classification)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
                Classification = source.GetList<Hl7.Fhir.Model.CodeableConcept>("classification", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"classification", typeof(Hl7.Fhir.Model.CodeableConcept)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MedicineClassificationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Classification != null) dest.Classification = new List<Hl7.Fhir.Model.CodeableConcept>(Classification.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MedicineClassificationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MedicineClassificationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Classification, otherT.Classification)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MedicineClassificationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Classification, otherT.Classification)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    foreach (var elem in Classification) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    foreach (var elem in Classification) { if (elem != null) yield return new ElementValue("classification", elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PackagingComponent")]
        [DataContract]
        public partial class PackagingComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "PackagingComponent"; } }
            
            /// <summary>
            /// A code that defines the specific type of packaging that the medication can be found in
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// The number of product units the package would contain if fully loaded
            /// </summary>
            [FhirElement("quantity", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _Quantity;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("PackagingComponent");
                base.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Type?.Serialize(sink);
                sink.Element("quantity", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Quantity?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
                Quantity = source.GetProperty<Hl7.Fhir.Model.SimpleQuantity>("quantity", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"quantity", typeof(Hl7.Fhir.Model.SimpleQuantity)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PackagingComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.SimpleQuantity)Quantity.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PackagingComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PackagingComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PackagingComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Quantity != null) yield return Quantity;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "DrugCharacteristicComponent")]
        [DataContract]
        public partial class DrugCharacteristicComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "DrugCharacteristicComponent"; } }
            
            /// <summary>
            /// Code specifying the type of characteristic of medication
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Description of the characteristic
            /// </summary>
            [FhirElement("value", Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.SimpleQuantity),typeof(Hl7.Fhir.Model.Base64Binary))]
            [DataMember]
            public Hl7.Fhir.Model.Element Value
            {
                get { return _Value; }
                set { _Value = value; OnPropertyChanged("Value"); }
            }
            
            private Hl7.Fhir.Model.Element _Value;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("DrugCharacteristicComponent");
                base.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Type?.Serialize(sink);
                sink.Element("value", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, true); Value?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
                Value = source.GetProperty<Hl7.Fhir.Model.Element>("value", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"value", typeof(Hl7.Fhir.Model.Element)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as DrugCharacteristicComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Value != null) dest.Value = (Hl7.Fhir.Model.Element)Value.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new DrugCharacteristicComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as DrugCharacteristicComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Value, otherT.Value)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as DrugCharacteristicComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Value, otherT.Value)) return false;
            
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "RegulatoryComponent")]
        [DataContract]
        public partial class RegulatoryComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "RegulatoryComponent"; } }
            
            /// <summary>
            /// Specifies the authority of the regulation
            /// </summary>
            [FhirElement("regulatoryAuthority", Order=40)]
            [CLSCompliant(false)]
            [References("Organization")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference RegulatoryAuthority
            {
                get { return _RegulatoryAuthority; }
                set { _RegulatoryAuthority = value; OnPropertyChanged("RegulatoryAuthority"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _RegulatoryAuthority;
            
            /// <summary>
            /// Specifies if changes are allowed when dispensing a medication from a regulatory perspective
            /// </summary>
            [FhirElement("substitution", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SubstitutionComponent> Substitution
            {
                get { if(_Substitution==null) _Substitution = new List<SubstitutionComponent>(); return _Substitution; }
                set { _Substitution = value; OnPropertyChanged("Substitution"); }
            }
            
            private List<SubstitutionComponent> _Substitution;
            
            /// <summary>
            /// Specifies the schedule of a medication in jurisdiction
            /// </summary>
            [FhirElement("schedule", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ScheduleComponent> Schedule
            {
                get { if(_Schedule==null) _Schedule = new List<ScheduleComponent>(); return _Schedule; }
                set { _Schedule = value; OnPropertyChanged("Schedule"); }
            }
            
            private List<ScheduleComponent> _Schedule;
            
            /// <summary>
            /// The maximum number of units of the medication that can be dispensed in a period
            /// </summary>
            [FhirElement("maxDispense", Order=70)]
            [DataMember]
            public MaxDispenseComponent MaxDispense
            {
                get { return _MaxDispense; }
                set { _MaxDispense = value; OnPropertyChanged("MaxDispense"); }
            }
            
            private MaxDispenseComponent _MaxDispense;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("RegulatoryComponent");
                base.Serialize(sink);
                sink.Element("regulatoryAuthority", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); RegulatoryAuthority?.Serialize(sink);
                sink.BeginList("substitution", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in Substitution)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.BeginList("schedule", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in Schedule)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.Element("maxDispense", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); MaxDispense?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                RegulatoryAuthority = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("regulatoryAuthority", Hl7.Fhir.Model.Version.All);
                Substitution = source.GetList<SubstitutionComponent>("substitution", Hl7.Fhir.Model.Version.All);
                Schedule = source.GetList<ScheduleComponent>("schedule", Hl7.Fhir.Model.Version.All);
                MaxDispense = source.GetProperty<MaxDispenseComponent>("maxDispense", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"regulatoryAuthority", typeof(Hl7.Fhir.Model.ResourceReference)},
                    {"substitution", typeof(SubstitutionComponent)},
                    {"schedule", typeof(ScheduleComponent)},
                    {"maxDispense", typeof(MaxDispenseComponent)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RegulatoryComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(RegulatoryAuthority != null) dest.RegulatoryAuthority = (Hl7.Fhir.Model.ResourceReference)RegulatoryAuthority.DeepCopy();
                    if(Substitution != null) dest.Substitution = new List<SubstitutionComponent>(Substitution.DeepCopy());
                    if(Schedule != null) dest.Schedule = new List<ScheduleComponent>(Schedule.DeepCopy());
                    if(MaxDispense != null) dest.MaxDispense = (MaxDispenseComponent)MaxDispense.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RegulatoryComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RegulatoryComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(RegulatoryAuthority, otherT.RegulatoryAuthority)) return false;
                if( !DeepComparable.Matches(Substitution, otherT.Substitution)) return false;
                if( !DeepComparable.Matches(Schedule, otherT.Schedule)) return false;
                if( !DeepComparable.Matches(MaxDispense, otherT.MaxDispense)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RegulatoryComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(RegulatoryAuthority, otherT.RegulatoryAuthority)) return false;
                if( !DeepComparable.IsExactly(Substitution, otherT.Substitution)) return false;
                if( !DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;
                if( !DeepComparable.IsExactly(MaxDispense, otherT.MaxDispense)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RegulatoryAuthority != null) yield return RegulatoryAuthority;
                    foreach (var elem in Substitution) { if (elem != null) yield return elem; }
                    foreach (var elem in Schedule) { if (elem != null) yield return elem; }
                    if (MaxDispense != null) yield return MaxDispense;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RegulatoryAuthority != null) yield return new ElementValue("regulatoryAuthority", RegulatoryAuthority);
                    foreach (var elem in Substitution) { if (elem != null) yield return new ElementValue("substitution", elem); }
                    foreach (var elem in Schedule) { if (elem != null) yield return new ElementValue("schedule", elem); }
                    if (MaxDispense != null) yield return new ElementValue("maxDispense", MaxDispense);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SubstitutionComponent")]
        [DataContract]
        public partial class SubstitutionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "SubstitutionComponent"; } }
            
            /// <summary>
            /// Specifies the type of substitution allowed
            /// </summary>
            [FhirElement("type", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Specifies if regulation allows for changes in the medication when dispensing
            /// </summary>
            [FhirElement("allowed", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean AllowedElement
            {
                get { return _AllowedElement; }
                set { _AllowedElement = value; OnPropertyChanged("AllowedElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _AllowedElement;
            
            /// <summary>
            /// Specifies if regulation allows for changes in the medication when dispensing
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Allowed
            {
                get { return AllowedElement != null ? AllowedElement.Value : null; }
                set
                {
                    if (value == null)
                        AllowedElement = null;
                    else
                        AllowedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Allowed");
                }
            }
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("SubstitutionComponent");
                base.Serialize(sink);
                sink.Element("type", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Type?.Serialize(sink);
                sink.Element("allowed", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); AllowedElement?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Type = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("type", Hl7.Fhir.Model.Version.All);
                AllowedElement = source.GetBooleanProperty("allowed", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"type", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"allowed", typeof(Hl7.Fhir.Model.FhirBoolean)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstitutionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(AllowedElement != null) dest.AllowedElement = (Hl7.Fhir.Model.FhirBoolean)AllowedElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SubstitutionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(AllowedElement, otherT.AllowedElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstitutionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(AllowedElement, otherT.AllowedElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (AllowedElement != null) yield return AllowedElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (AllowedElement != null) yield return new ElementValue("allowed", AllowedElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ScheduleComponent")]
        [DataContract]
        public partial class ScheduleComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "ScheduleComponent"; } }
            
            /// <summary>
            /// Specifies the specific drug schedule
            /// </summary>
            [FhirElement("schedule", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Schedule
            {
                get { return _Schedule; }
                set { _Schedule = value; OnPropertyChanged("Schedule"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Schedule;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("ScheduleComponent");
                base.Serialize(sink);
                sink.Element("schedule", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Schedule?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Schedule = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("schedule", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"schedule", typeof(Hl7.Fhir.Model.CodeableConcept)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ScheduleComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Schedule != null) dest.Schedule = (Hl7.Fhir.Model.CodeableConcept)Schedule.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ScheduleComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ScheduleComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Schedule, otherT.Schedule)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ScheduleComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Schedule, otherT.Schedule)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Schedule != null) yield return Schedule;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Schedule != null) yield return new ElementValue("schedule", Schedule);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "MaxDispenseComponent")]
        [DataContract]
        public partial class MaxDispenseComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "MaxDispenseComponent"; } }
            
            /// <summary>
            /// The maximum number of units of the medication that can be dispensed
            /// </summary>
            [FhirElement("quantity", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.SimpleQuantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            
            private Hl7.Fhir.Model.SimpleQuantity _Quantity;
            
            /// <summary>
            /// The period that applies to the maximum number of units
            /// </summary>
            [FhirElement("period", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Duration Period
            {
                get { return _Period; }
                set { _Period = value; OnPropertyChanged("Period"); }
            }
            
            private Hl7.Fhir.Model.R4.Duration _Period;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("MaxDispenseComponent");
                base.Serialize(sink);
                sink.Element("quantity", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Quantity?.Serialize(sink);
                sink.Element("period", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Period?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Quantity = source.GetProperty<Hl7.Fhir.Model.SimpleQuantity>("quantity", Hl7.Fhir.Model.Version.All);
                Period = source.GetProperty<Hl7.Fhir.Model.R4.Duration>("period", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"quantity", typeof(Hl7.Fhir.Model.SimpleQuantity)},
                    {"period", typeof(Hl7.Fhir.Model.R4.Duration)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as MaxDispenseComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.SimpleQuantity)Quantity.DeepCopy();
                    if(Period != null) dest.Period = (Hl7.Fhir.Model.R4.Duration)Period.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new MaxDispenseComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as MaxDispenseComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(Period, otherT.Period)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as MaxDispenseComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Quantity != null) yield return Quantity;
                    if (Period != null) yield return Period;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Quantity != null) yield return new ElementValue("quantity", Quantity);
                    if (Period != null) yield return new ElementValue("period", Period);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "KineticsComponent")]
        [DataContract]
        public partial class KineticsComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "KineticsComponent"; } }
            
            /// <summary>
            /// The drug concentration measured at certain discrete points in time
            /// </summary>
            [FhirElement("areaUnderCurve", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.SimpleQuantity> AreaUnderCurve
            {
                get { if(_AreaUnderCurve==null) _AreaUnderCurve = new List<Hl7.Fhir.Model.SimpleQuantity>(); return _AreaUnderCurve; }
                set { _AreaUnderCurve = value; OnPropertyChanged("AreaUnderCurve"); }
            }
            
            private List<Hl7.Fhir.Model.SimpleQuantity> _AreaUnderCurve;
            
            /// <summary>
            /// The median lethal dose of a drug
            /// </summary>
            [FhirElement("lethalDose50", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.SimpleQuantity> LethalDose50
            {
                get { if(_LethalDose50==null) _LethalDose50 = new List<Hl7.Fhir.Model.SimpleQuantity>(); return _LethalDose50; }
                set { _LethalDose50 = value; OnPropertyChanged("LethalDose50"); }
            }
            
            private List<Hl7.Fhir.Model.SimpleQuantity> _LethalDose50;
            
            /// <summary>
            /// Time required for concentration in the body to decrease by half
            /// </summary>
            [FhirElement("halfLifePeriod", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Duration HalfLifePeriod
            {
                get { return _HalfLifePeriod; }
                set { _HalfLifePeriod = value; OnPropertyChanged("HalfLifePeriod"); }
            }
            
            private Hl7.Fhir.Model.R4.Duration _HalfLifePeriod;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("KineticsComponent");
                base.Serialize(sink);
                sink.BeginList("areaUnderCurve", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in AreaUnderCurve)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.BeginList("lethalDose50", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in LethalDose50)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.Element("halfLifePeriod", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); HalfLifePeriod?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                AreaUnderCurve = source.GetList<Hl7.Fhir.Model.SimpleQuantity>("areaUnderCurve", Hl7.Fhir.Model.Version.All);
                LethalDose50 = source.GetList<Hl7.Fhir.Model.SimpleQuantity>("lethalDose50", Hl7.Fhir.Model.Version.All);
                HalfLifePeriod = source.GetProperty<Hl7.Fhir.Model.R4.Duration>("halfLifePeriod", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"areaUnderCurve", typeof(Hl7.Fhir.Model.SimpleQuantity)},
                    {"lethalDose50", typeof(Hl7.Fhir.Model.SimpleQuantity)},
                    {"halfLifePeriod", typeof(Hl7.Fhir.Model.R4.Duration)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as KineticsComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(AreaUnderCurve != null) dest.AreaUnderCurve = new List<Hl7.Fhir.Model.SimpleQuantity>(AreaUnderCurve.DeepCopy());
                    if(LethalDose50 != null) dest.LethalDose50 = new List<Hl7.Fhir.Model.SimpleQuantity>(LethalDose50.DeepCopy());
                    if(HalfLifePeriod != null) dest.HalfLifePeriod = (Hl7.Fhir.Model.R4.Duration)HalfLifePeriod.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new KineticsComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as KineticsComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(AreaUnderCurve, otherT.AreaUnderCurve)) return false;
                if( !DeepComparable.Matches(LethalDose50, otherT.LethalDose50)) return false;
                if( !DeepComparable.Matches(HalfLifePeriod, otherT.HalfLifePeriod)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as KineticsComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(AreaUnderCurve, otherT.AreaUnderCurve)) return false;
                if( !DeepComparable.IsExactly(LethalDose50, otherT.LethalDose50)) return false;
                if( !DeepComparable.IsExactly(HalfLifePeriod, otherT.HalfLifePeriod)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in AreaUnderCurve) { if (elem != null) yield return elem; }
                    foreach (var elem in LethalDose50) { if (elem != null) yield return elem; }
                    if (HalfLifePeriod != null) yield return HalfLifePeriod;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in AreaUnderCurve) { if (elem != null) yield return new ElementValue("areaUnderCurve", elem); }
                    foreach (var elem in LethalDose50) { if (elem != null) yield return new ElementValue("lethalDose50", elem); }
                    if (HalfLifePeriod != null) yield return new ElementValue("halfLifePeriod", HalfLifePeriod);
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Code that identifies this medication
        /// </summary>
        [FhirElement("code", InSummary=Hl7.Fhir.Model.Version.All, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Code
        {
            get { return _Code; }
            set { _Code = value; OnPropertyChanged("Code"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Code;
        
        /// <summary>
        /// active | inactive | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=Hl7.Fhir.Model.Version.All, Order=100)]
        [CLSCompliant(false)]
        [DataMember]
        public Code<Hl7.Fhir.Model.R4.MedicationKnowledgeStatusCodes> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.R4.MedicationKnowledgeStatusCodes> _StatusElement;
        
        /// <summary>
        /// active | inactive | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.R4.MedicationKnowledgeStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<Hl7.Fhir.Model.R4.MedicationKnowledgeStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Manufacturer of the item
        /// </summary>
        [FhirElement("manufacturer", InSummary=Hl7.Fhir.Model.Version.All, Order=110)]
        [CLSCompliant(false)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Manufacturer
        {
            get { return _Manufacturer; }
            set { _Manufacturer = value; OnPropertyChanged("Manufacturer"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Manufacturer;
        
        /// <summary>
        /// powder | tablets | capsule +
        /// </summary>
        [FhirElement("doseForm", Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept DoseForm
        {
            get { return _DoseForm; }
            set { _DoseForm = value; OnPropertyChanged("DoseForm"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _DoseForm;
        
        /// <summary>
        /// Amount of drug in package
        /// </summary>
        [FhirElement("amount", InSummary=Hl7.Fhir.Model.Version.All, Order=130)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.SimpleQuantity Amount
        {
            get { return _Amount; }
            set { _Amount = value; OnPropertyChanged("Amount"); }
        }
        
        private Hl7.Fhir.Model.SimpleQuantity _Amount;
        
        /// <summary>
        /// Additional names for a medication
        /// </summary>
        [FhirElement("synonym", InSummary=Hl7.Fhir.Model.Version.All, Order=140)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.FhirString> SynonymElement
        {
            get { if(_SynonymElement==null) _SynonymElement = new List<Hl7.Fhir.Model.FhirString>(); return _SynonymElement; }
            set { _SynonymElement = value; OnPropertyChanged("SynonymElement"); }
        }
        
        private List<Hl7.Fhir.Model.FhirString> _SynonymElement;
        
        /// <summary>
        /// Additional names for a medication
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public IEnumerable<string> Synonym
        {
            get { return SynonymElement != null ? SynonymElement.Select(elem => elem.Value) : null; }
            set
            {
                if (value == null)
                    SynonymElement = null;
                else
                    SynonymElement = new List<Hl7.Fhir.Model.FhirString>(value.Select(elem=>new Hl7.Fhir.Model.FhirString(elem)));
                OnPropertyChanged("Synonym");
            }
        }
        
        /// <summary>
        /// Associated or related medication information
        /// </summary>
        [FhirElement("relatedMedicationKnowledge", Order=150)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedMedicationKnowledgeComponent> RelatedMedicationKnowledge
        {
            get { if(_RelatedMedicationKnowledge==null) _RelatedMedicationKnowledge = new List<RelatedMedicationKnowledgeComponent>(); return _RelatedMedicationKnowledge; }
            set { _RelatedMedicationKnowledge = value; OnPropertyChanged("RelatedMedicationKnowledge"); }
        }
        
        private List<RelatedMedicationKnowledgeComponent> _RelatedMedicationKnowledge;
        
        /// <summary>
        /// A medication resource that is associated with this medication
        /// </summary>
        [FhirElement("associatedMedication", Order=160)]
        [CLSCompliant(false)]
        [References("Medication")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> AssociatedMedication
        {
            get { if(_AssociatedMedication==null) _AssociatedMedication = new List<Hl7.Fhir.Model.ResourceReference>(); return _AssociatedMedication; }
            set { _AssociatedMedication = value; OnPropertyChanged("AssociatedMedication"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _AssociatedMedication;
        
        /// <summary>
        /// Category of the medication or product
        /// </summary>
        [FhirElement("productType", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> ProductType
        {
            get { if(_ProductType==null) _ProductType = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ProductType; }
            set { _ProductType = value; OnPropertyChanged("ProductType"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _ProductType;
        
        /// <summary>
        /// Associated documentation about the medication
        /// </summary>
        [FhirElement("monograph", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MonographComponent> Monograph
        {
            get { if(_Monograph==null) _Monograph = new List<MonographComponent>(); return _Monograph; }
            set { _Monograph = value; OnPropertyChanged("Monograph"); }
        }
        
        private List<MonographComponent> _Monograph;
        
        /// <summary>
        /// Active or inactive ingredient
        /// </summary>
        [FhirElement("ingredient", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<IngredientComponent> Ingredient
        {
            get { if(_Ingredient==null) _Ingredient = new List<IngredientComponent>(); return _Ingredient; }
            set { _Ingredient = value; OnPropertyChanged("Ingredient"); }
        }
        
        private List<IngredientComponent> _Ingredient;
        
        /// <summary>
        /// The instructions for preparing the medication
        /// </summary>
        [FhirElement("preparationInstruction", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.Markdown PreparationInstructionElement
        {
            get { return _PreparationInstructionElement; }
            set { _PreparationInstructionElement = value; OnPropertyChanged("PreparationInstructionElement"); }
        }
        
        private Hl7.Fhir.Model.Markdown _PreparationInstructionElement;
        
        /// <summary>
        /// The instructions for preparing the medication
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string PreparationInstruction
        {
            get { return PreparationInstructionElement != null ? PreparationInstructionElement.Value : null; }
            set
            {
                if (value == null)
                    PreparationInstructionElement = null;
                else
                    PreparationInstructionElement = new Hl7.Fhir.Model.Markdown(value);
                OnPropertyChanged("PreparationInstruction");
            }
        }
        
        /// <summary>
        /// The intended or approved route of administration
        /// </summary>
        [FhirElement("intendedRoute", Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> IntendedRoute
        {
            get { if(_IntendedRoute==null) _IntendedRoute = new List<Hl7.Fhir.Model.CodeableConcept>(); return _IntendedRoute; }
            set { _IntendedRoute = value; OnPropertyChanged("IntendedRoute"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _IntendedRoute;
        
        /// <summary>
        /// The pricing of the medication
        /// </summary>
        [FhirElement("cost", Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CostComponent> Cost
        {
            get { if(_Cost==null) _Cost = new List<CostComponent>(); return _Cost; }
            set { _Cost = value; OnPropertyChanged("Cost"); }
        }
        
        private List<CostComponent> _Cost;
        
        /// <summary>
        /// Program under which a medication is reviewed
        /// </summary>
        [FhirElement("monitoringProgram", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MonitoringProgramComponent> MonitoringProgram
        {
            get { if(_MonitoringProgram==null) _MonitoringProgram = new List<MonitoringProgramComponent>(); return _MonitoringProgram; }
            set { _MonitoringProgram = value; OnPropertyChanged("MonitoringProgram"); }
        }
        
        private List<MonitoringProgramComponent> _MonitoringProgram;
        
        /// <summary>
        /// Guidelines for administration of the medication
        /// </summary>
        [FhirElement("administrationGuidelines", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AdministrationGuidelinesComponent> AdministrationGuidelines
        {
            get { if(_AdministrationGuidelines==null) _AdministrationGuidelines = new List<AdministrationGuidelinesComponent>(); return _AdministrationGuidelines; }
            set { _AdministrationGuidelines = value; OnPropertyChanged("AdministrationGuidelines"); }
        }
        
        private List<AdministrationGuidelinesComponent> _AdministrationGuidelines;
        
        /// <summary>
        /// Categorization of the medication within a formulary or classification system
        /// </summary>
        [FhirElement("medicineClassification", Order=250)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<MedicineClassificationComponent> MedicineClassification
        {
            get { if(_MedicineClassification==null) _MedicineClassification = new List<MedicineClassificationComponent>(); return _MedicineClassification; }
            set { _MedicineClassification = value; OnPropertyChanged("MedicineClassification"); }
        }
        
        private List<MedicineClassificationComponent> _MedicineClassification;
        
        /// <summary>
        /// Details about packaged medications
        /// </summary>
        [FhirElement("packaging", Order=260)]
        [DataMember]
        public PackagingComponent Packaging
        {
            get { return _Packaging; }
            set { _Packaging = value; OnPropertyChanged("Packaging"); }
        }
        
        private PackagingComponent _Packaging;
        
        /// <summary>
        /// Specifies descriptive properties of the medicine
        /// </summary>
        [FhirElement("drugCharacteristic", Order=270)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<DrugCharacteristicComponent> DrugCharacteristic
        {
            get { if(_DrugCharacteristic==null) _DrugCharacteristic = new List<DrugCharacteristicComponent>(); return _DrugCharacteristic; }
            set { _DrugCharacteristic = value; OnPropertyChanged("DrugCharacteristic"); }
        }
        
        private List<DrugCharacteristicComponent> _DrugCharacteristic;
        
        /// <summary>
        /// Potential clinical issue with or between medication(s)
        /// </summary>
        [FhirElement("contraindication", Order=280)]
        [CLSCompliant(false)]
        [References("DetectedIssue")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> Contraindication
        {
            get { if(_Contraindication==null) _Contraindication = new List<Hl7.Fhir.Model.ResourceReference>(); return _Contraindication; }
            set { _Contraindication = value; OnPropertyChanged("Contraindication"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _Contraindication;
        
        /// <summary>
        /// Regulatory information about a medication
        /// </summary>
        [FhirElement("regulatory", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RegulatoryComponent> Regulatory
        {
            get { if(_Regulatory==null) _Regulatory = new List<RegulatoryComponent>(); return _Regulatory; }
            set { _Regulatory = value; OnPropertyChanged("Regulatory"); }
        }
        
        private List<RegulatoryComponent> _Regulatory;
        
        /// <summary>
        /// The time course of drug absorption, distribution, metabolism and excretion of a medication from the body
        /// </summary>
        [FhirElement("kinetics", Order=300)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<KineticsComponent> Kinetics
        {
            get { if(_Kinetics==null) _Kinetics = new List<KineticsComponent>(); return _Kinetics; }
            set { _Kinetics = value; OnPropertyChanged("Kinetics"); }
        }
        
        private List<KineticsComponent> _Kinetics;
    
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as MedicationKnowledge;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Code != null) dest.Code = (Hl7.Fhir.Model.CodeableConcept)Code.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.R4.MedicationKnowledgeStatusCodes>)StatusElement.DeepCopy();
                if(Manufacturer != null) dest.Manufacturer = (Hl7.Fhir.Model.ResourceReference)Manufacturer.DeepCopy();
                if(DoseForm != null) dest.DoseForm = (Hl7.Fhir.Model.CodeableConcept)DoseForm.DeepCopy();
                if(Amount != null) dest.Amount = (Hl7.Fhir.Model.SimpleQuantity)Amount.DeepCopy();
                if(SynonymElement != null) dest.SynonymElement = new List<Hl7.Fhir.Model.FhirString>(SynonymElement.DeepCopy());
                if(RelatedMedicationKnowledge != null) dest.RelatedMedicationKnowledge = new List<RelatedMedicationKnowledgeComponent>(RelatedMedicationKnowledge.DeepCopy());
                if(AssociatedMedication != null) dest.AssociatedMedication = new List<Hl7.Fhir.Model.ResourceReference>(AssociatedMedication.DeepCopy());
                if(ProductType != null) dest.ProductType = new List<Hl7.Fhir.Model.CodeableConcept>(ProductType.DeepCopy());
                if(Monograph != null) dest.Monograph = new List<MonographComponent>(Monograph.DeepCopy());
                if(Ingredient != null) dest.Ingredient = new List<IngredientComponent>(Ingredient.DeepCopy());
                if(PreparationInstructionElement != null) dest.PreparationInstructionElement = (Hl7.Fhir.Model.Markdown)PreparationInstructionElement.DeepCopy();
                if(IntendedRoute != null) dest.IntendedRoute = new List<Hl7.Fhir.Model.CodeableConcept>(IntendedRoute.DeepCopy());
                if(Cost != null) dest.Cost = new List<CostComponent>(Cost.DeepCopy());
                if(MonitoringProgram != null) dest.MonitoringProgram = new List<MonitoringProgramComponent>(MonitoringProgram.DeepCopy());
                if(AdministrationGuidelines != null) dest.AdministrationGuidelines = new List<AdministrationGuidelinesComponent>(AdministrationGuidelines.DeepCopy());
                if(MedicineClassification != null) dest.MedicineClassification = new List<MedicineClassificationComponent>(MedicineClassification.DeepCopy());
                if(Packaging != null) dest.Packaging = (PackagingComponent)Packaging.DeepCopy();
                if(DrugCharacteristic != null) dest.DrugCharacteristic = new List<DrugCharacteristicComponent>(DrugCharacteristic.DeepCopy());
                if(Contraindication != null) dest.Contraindication = new List<Hl7.Fhir.Model.ResourceReference>(Contraindication.DeepCopy());
                if(Regulatory != null) dest.Regulatory = new List<RegulatoryComponent>(Regulatory.DeepCopy());
                if(Kinetics != null) dest.Kinetics = new List<KineticsComponent>(Kinetics.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new MedicationKnowledge());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as MedicationKnowledge;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Code, otherT.Code)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.Matches(DoseForm, otherT.DoseForm)) return false;
            if( !DeepComparable.Matches(Amount, otherT.Amount)) return false;
            if( !DeepComparable.Matches(SynonymElement, otherT.SynonymElement)) return false;
            if( !DeepComparable.Matches(RelatedMedicationKnowledge, otherT.RelatedMedicationKnowledge)) return false;
            if( !DeepComparable.Matches(AssociatedMedication, otherT.AssociatedMedication)) return false;
            if( !DeepComparable.Matches(ProductType, otherT.ProductType)) return false;
            if( !DeepComparable.Matches(Monograph, otherT.Monograph)) return false;
            if( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
            if( !DeepComparable.Matches(PreparationInstructionElement, otherT.PreparationInstructionElement)) return false;
            if( !DeepComparable.Matches(IntendedRoute, otherT.IntendedRoute)) return false;
            if( !DeepComparable.Matches(Cost, otherT.Cost)) return false;
            if( !DeepComparable.Matches(MonitoringProgram, otherT.MonitoringProgram)) return false;
            if( !DeepComparable.Matches(AdministrationGuidelines, otherT.AdministrationGuidelines)) return false;
            if( !DeepComparable.Matches(MedicineClassification, otherT.MedicineClassification)) return false;
            if( !DeepComparable.Matches(Packaging, otherT.Packaging)) return false;
            if( !DeepComparable.Matches(DrugCharacteristic, otherT.DrugCharacteristic)) return false;
            if( !DeepComparable.Matches(Contraindication, otherT.Contraindication)) return false;
            if( !DeepComparable.Matches(Regulatory, otherT.Regulatory)) return false;
            if( !DeepComparable.Matches(Kinetics, otherT.Kinetics)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as MedicationKnowledge;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.IsExactly(DoseForm, otherT.DoseForm)) return false;
            if( !DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
            if( !DeepComparable.IsExactly(SynonymElement, otherT.SynonymElement)) return false;
            if( !DeepComparable.IsExactly(RelatedMedicationKnowledge, otherT.RelatedMedicationKnowledge)) return false;
            if( !DeepComparable.IsExactly(AssociatedMedication, otherT.AssociatedMedication)) return false;
            if( !DeepComparable.IsExactly(ProductType, otherT.ProductType)) return false;
            if( !DeepComparable.IsExactly(Monograph, otherT.Monograph)) return false;
            if( !DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
            if( !DeepComparable.IsExactly(PreparationInstructionElement, otherT.PreparationInstructionElement)) return false;
            if( !DeepComparable.IsExactly(IntendedRoute, otherT.IntendedRoute)) return false;
            if( !DeepComparable.IsExactly(Cost, otherT.Cost)) return false;
            if( !DeepComparable.IsExactly(MonitoringProgram, otherT.MonitoringProgram)) return false;
            if( !DeepComparable.IsExactly(AdministrationGuidelines, otherT.AdministrationGuidelines)) return false;
            if( !DeepComparable.IsExactly(MedicineClassification, otherT.MedicineClassification)) return false;
            if( !DeepComparable.IsExactly(Packaging, otherT.Packaging)) return false;
            if( !DeepComparable.IsExactly(DrugCharacteristic, otherT.DrugCharacteristic)) return false;
            if( !DeepComparable.IsExactly(Contraindication, otherT.Contraindication)) return false;
            if( !DeepComparable.IsExactly(Regulatory, otherT.Regulatory)) return false;
            if( !DeepComparable.IsExactly(Kinetics, otherT.Kinetics)) return false;
        
            return true;
        }
    
        internal override void Serialize(Serialization.SerializerSink sink)
        {
            sink.BeginResource("MedicationKnowledge");
            base.Serialize(sink);
            sink.Element("code", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Code?.Serialize(sink);
            sink.Element("status", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); StatusElement?.Serialize(sink);
            sink.Element("manufacturer", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Manufacturer?.Serialize(sink);
            sink.Element("doseForm", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DoseForm?.Serialize(sink);
            sink.Element("amount", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Amount?.Serialize(sink);
            sink.BeginList("synonym", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            sink.Serialize(SynonymElement);
            sink.End();
            sink.BeginList("relatedMedicationKnowledge", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in RelatedMedicationKnowledge)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("associatedMedication", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in AssociatedMedication)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("productType", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in ProductType)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("monograph", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Monograph)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("ingredient", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Ingredient)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("preparationInstruction", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); PreparationInstructionElement?.Serialize(sink);
            sink.BeginList("intendedRoute", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in IntendedRoute)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("cost", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Cost)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("monitoringProgram", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in MonitoringProgram)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("administrationGuidelines", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in AdministrationGuidelines)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("medicineClassification", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in MedicineClassification)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("packaging", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Packaging?.Serialize(sink);
            sink.BeginList("drugCharacteristic", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in DrugCharacteristic)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("contraindication", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Contraindication)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("regulatory", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Regulatory)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("kinetics", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Kinetics)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.End();
        }
        
        internal override void Parse(Serialization.IParserSource source)
        {
            base.Parse(source);
            Code = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("code", Hl7.Fhir.Model.Version.All);
            StatusElement = source.GetCodeEnumProperty<Hl7.Fhir.Model.R4.MedicationKnowledgeStatusCodes>("status", Hl7.Fhir.Model.Version.All);
            Manufacturer = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("manufacturer", Hl7.Fhir.Model.Version.All);
            DoseForm = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("doseForm", Hl7.Fhir.Model.Version.All);
            Amount = source.GetProperty<Hl7.Fhir.Model.SimpleQuantity>("amount", Hl7.Fhir.Model.Version.All);
            SynonymElement = source.GetStringList("synonym", Hl7.Fhir.Model.Version.All);
            RelatedMedicationKnowledge = source.GetList<RelatedMedicationKnowledgeComponent>("relatedMedicationKnowledge", Hl7.Fhir.Model.Version.All);
            AssociatedMedication = source.GetList<Hl7.Fhir.Model.ResourceReference>("associatedMedication", Hl7.Fhir.Model.Version.All);
            ProductType = source.GetList<Hl7.Fhir.Model.CodeableConcept>("productType", Hl7.Fhir.Model.Version.All);
            Monograph = source.GetList<MonographComponent>("monograph", Hl7.Fhir.Model.Version.All);
            Ingredient = source.GetList<IngredientComponent>("ingredient", Hl7.Fhir.Model.Version.All);
            PreparationInstructionElement = source.GetProperty<Hl7.Fhir.Model.Markdown>("preparationInstruction", Hl7.Fhir.Model.Version.All);
            IntendedRoute = source.GetList<Hl7.Fhir.Model.CodeableConcept>("intendedRoute", Hl7.Fhir.Model.Version.All);
            Cost = source.GetList<CostComponent>("cost", Hl7.Fhir.Model.Version.All);
            MonitoringProgram = source.GetList<MonitoringProgramComponent>("monitoringProgram", Hl7.Fhir.Model.Version.All);
            AdministrationGuidelines = source.GetList<AdministrationGuidelinesComponent>("administrationGuidelines", Hl7.Fhir.Model.Version.All);
            MedicineClassification = source.GetList<MedicineClassificationComponent>("medicineClassification", Hl7.Fhir.Model.Version.All);
            Packaging = source.GetProperty<PackagingComponent>("packaging", Hl7.Fhir.Model.Version.All);
            DrugCharacteristic = source.GetList<DrugCharacteristicComponent>("drugCharacteristic", Hl7.Fhir.Model.Version.All);
            Contraindication = source.GetList<Hl7.Fhir.Model.ResourceReference>("contraindication", Hl7.Fhir.Model.Version.All);
            Regulatory = source.GetList<RegulatoryComponent>("regulatory", Hl7.Fhir.Model.Version.All);
            Kinetics = source.GetList<KineticsComponent>("kinetics", Hl7.Fhir.Model.Version.All);
        }
        
        internal override Type GetPropertyType(string fhirName)
        {
            if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
            return base.GetPropertyType(fhirName);
        }
        
        private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
        {
                {"code", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"status", typeof(Hl7.Fhir.Model.Code<Hl7.Fhir.Model.R4.MedicationKnowledgeStatusCodes>)},
                {"manufacturer", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"doseForm", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"amount", typeof(Hl7.Fhir.Model.SimpleQuantity)},
                {"synonym", typeof(Hl7.Fhir.Model.FhirString)},
                {"relatedMedicationKnowledge", typeof(RelatedMedicationKnowledgeComponent)},
                {"associatedMedication", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"productType", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"monograph", typeof(MonographComponent)},
                {"ingredient", typeof(IngredientComponent)},
                {"preparationInstruction", typeof(Hl7.Fhir.Model.Markdown)},
                {"intendedRoute", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"cost", typeof(CostComponent)},
                {"monitoringProgram", typeof(MonitoringProgramComponent)},
                {"administrationGuidelines", typeof(AdministrationGuidelinesComponent)},
                {"medicineClassification", typeof(MedicineClassificationComponent)},
                {"packaging", typeof(PackagingComponent)},
                {"drugCharacteristic", typeof(DrugCharacteristicComponent)},
                {"contraindication", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"regulatory", typeof(RegulatoryComponent)},
                {"kinetics", typeof(KineticsComponent)},
        };
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Code != null) yield return Code;
                if (StatusElement != null) yield return StatusElement;
                if (Manufacturer != null) yield return Manufacturer;
                if (DoseForm != null) yield return DoseForm;
                if (Amount != null) yield return Amount;
                foreach (var elem in SynonymElement) { if (elem != null) yield return elem; }
                foreach (var elem in RelatedMedicationKnowledge) { if (elem != null) yield return elem; }
                foreach (var elem in AssociatedMedication) { if (elem != null) yield return elem; }
                foreach (var elem in ProductType) { if (elem != null) yield return elem; }
                foreach (var elem in Monograph) { if (elem != null) yield return elem; }
                foreach (var elem in Ingredient) { if (elem != null) yield return elem; }
                if (PreparationInstructionElement != null) yield return PreparationInstructionElement;
                foreach (var elem in IntendedRoute) { if (elem != null) yield return elem; }
                foreach (var elem in Cost) { if (elem != null) yield return elem; }
                foreach (var elem in MonitoringProgram) { if (elem != null) yield return elem; }
                foreach (var elem in AdministrationGuidelines) { if (elem != null) yield return elem; }
                foreach (var elem in MedicineClassification) { if (elem != null) yield return elem; }
                if (Packaging != null) yield return Packaging;
                foreach (var elem in DrugCharacteristic) { if (elem != null) yield return elem; }
                foreach (var elem in Contraindication) { if (elem != null) yield return elem; }
                foreach (var elem in Regulatory) { if (elem != null) yield return elem; }
                foreach (var elem in Kinetics) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Code != null) yield return new ElementValue("code", Code);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Manufacturer != null) yield return new ElementValue("manufacturer", Manufacturer);
                if (DoseForm != null) yield return new ElementValue("doseForm", DoseForm);
                if (Amount != null) yield return new ElementValue("amount", Amount);
                foreach (var elem in SynonymElement) { if (elem != null) yield return new ElementValue("synonym", elem); }
                foreach (var elem in RelatedMedicationKnowledge) { if (elem != null) yield return new ElementValue("relatedMedicationKnowledge", elem); }
                foreach (var elem in AssociatedMedication) { if (elem != null) yield return new ElementValue("associatedMedication", elem); }
                foreach (var elem in ProductType) { if (elem != null) yield return new ElementValue("productType", elem); }
                foreach (var elem in Monograph) { if (elem != null) yield return new ElementValue("monograph", elem); }
                foreach (var elem in Ingredient) { if (elem != null) yield return new ElementValue("ingredient", elem); }
                if (PreparationInstructionElement != null) yield return new ElementValue("preparationInstruction", PreparationInstructionElement);
                foreach (var elem in IntendedRoute) { if (elem != null) yield return new ElementValue("intendedRoute", elem); }
                foreach (var elem in Cost) { if (elem != null) yield return new ElementValue("cost", elem); }
                foreach (var elem in MonitoringProgram) { if (elem != null) yield return new ElementValue("monitoringProgram", elem); }
                foreach (var elem in AdministrationGuidelines) { if (elem != null) yield return new ElementValue("administrationGuidelines", elem); }
                foreach (var elem in MedicineClassification) { if (elem != null) yield return new ElementValue("medicineClassification", elem); }
                if (Packaging != null) yield return new ElementValue("packaging", Packaging);
                foreach (var elem in DrugCharacteristic) { if (elem != null) yield return new ElementValue("drugCharacteristic", elem); }
                foreach (var elem in Contraindication) { if (elem != null) yield return new ElementValue("contraindication", elem); }
                foreach (var elem in Regulatory) { if (elem != null) yield return new ElementValue("regulatory", elem); }
                foreach (var elem in Kinetics) { if (elem != null) yield return new ElementValue("kinetics", elem); }
            }
        }
    
    }

}
