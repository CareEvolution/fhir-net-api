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
    /// Immunization event information
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.STU3, "Immunization", IsResource=true)]
    [DataContract]
    public partial class Immunization : Hl7.Fhir.Model.DomainResource, Hl7.Fhir.Model.IImmunization, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Immunization; } }
        [NotMapped]
        public override string TypeName { get { return "Immunization"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "PractitionerComponent")]
        [DataContract]
        public partial class PractitionerComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "PractitionerComponent"; } }
            
            /// <summary>
            /// What type of performance was done
            /// </summary>
            [FhirElement("role", InSummary=Hl7.Fhir.Model.Version.All, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Role
            {
                get { return _Role; }
                set { _Role = value; OnPropertyChanged("Role"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Role;
            
            /// <summary>
            /// Individual who was performing
            /// </summary>
            [FhirElement("actor", InSummary=Hl7.Fhir.Model.Version.All, Order=50)]
            [CLSCompliant(false)]
            [References("Practitioner")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Actor
            {
                get { return _Actor; }
                set { _Actor = value; OnPropertyChanged("Actor"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Actor;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("PractitionerComponent");
                base.Serialize(sink);
                sink.Element("role", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Role?.Serialize(sink);
                sink.Element("actor", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); Actor?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Role = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("role", Hl7.Fhir.Model.Version.All);
                Actor = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("actor", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"role", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"actor", typeof(Hl7.Fhir.Model.ResourceReference)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PractitionerComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Role != null) dest.Role = (Hl7.Fhir.Model.CodeableConcept)Role.DeepCopy();
                    if(Actor != null) dest.Actor = (Hl7.Fhir.Model.ResourceReference)Actor.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PractitionerComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PractitionerComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Role, otherT.Role)) return false;
                if( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PractitionerComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
                if( !DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Role != null) yield return Role;
                    if (Actor != null) yield return Actor;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Role != null) yield return new ElementValue("role", Role);
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "ExplanationComponent")]
        [DataContract]
        public partial class ExplanationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "ExplanationComponent"; } }
            
            /// <summary>
            /// Why immunization occurred
            /// </summary>
            [FhirElement("reason", Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Reason
            {
                get { if(_Reason==null) _Reason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Reason; }
                set { _Reason = value; OnPropertyChanged("Reason"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Reason;
            
            /// <summary>
            /// Why immunization did not occur
            /// </summary>
            [FhirElement("reasonNotGiven", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> ReasonNotGiven
            {
                get { if(_ReasonNotGiven==null) _ReasonNotGiven = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ReasonNotGiven; }
                set { _ReasonNotGiven = value; OnPropertyChanged("ReasonNotGiven"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _ReasonNotGiven;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("ExplanationComponent");
                base.Serialize(sink);
                sink.BeginList("reason", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in Reason)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.BeginList("reasonNotGiven", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in ReasonNotGiven)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Reason = source.GetList<Hl7.Fhir.Model.CodeableConcept>("reason", Hl7.Fhir.Model.Version.All);
                ReasonNotGiven = source.GetList<Hl7.Fhir.Model.CodeableConcept>("reasonNotGiven", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"reason", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"reasonNotGiven", typeof(Hl7.Fhir.Model.CodeableConcept)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ExplanationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Reason != null) dest.Reason = new List<Hl7.Fhir.Model.CodeableConcept>(Reason.DeepCopy());
                    if(ReasonNotGiven != null) dest.ReasonNotGiven = new List<Hl7.Fhir.Model.CodeableConcept>(ReasonNotGiven.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ExplanationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ExplanationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Reason, otherT.Reason)) return false;
                if( !DeepComparable.Matches(ReasonNotGiven, otherT.ReasonNotGiven)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ExplanationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Reason, otherT.Reason)) return false;
                if( !DeepComparable.IsExactly(ReasonNotGiven, otherT.ReasonNotGiven)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Reason) { if (elem != null) yield return elem; }
                    foreach (var elem in ReasonNotGiven) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Reason) { if (elem != null) yield return new ElementValue("reason", elem); }
                    foreach (var elem in ReasonNotGiven) { if (elem != null) yield return new ElementValue("reasonNotGiven", elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "ReactionComponent")]
        [DataContract]
        public partial class ReactionComponent : Hl7.Fhir.Model.BackboneElement, Hl7.Fhir.Model.IImmunizationReactionComponent, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "ReactionComponent"; } }
            
            /// <summary>
            /// When reaction started
            /// </summary>
            [FhirElement("date", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime DateElement
            {
                get { return _DateElement; }
                set { _DateElement = value; OnPropertyChanged("DateElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _DateElement;
            
            /// <summary>
            /// When reaction started
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
                        DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("Date");
                }
            }
            
            /// <summary>
            /// Additional information on reaction
            /// </summary>
            [FhirElement("detail", Order=50)]
            [CLSCompliant(false)]
            [References("Observation")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Detail
            {
                get { return _Detail; }
                set { _Detail = value; OnPropertyChanged("Detail"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Detail;
            
            /// <summary>
            /// Indicates self-reported reaction
            /// </summary>
            [FhirElement("reported", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirBoolean ReportedElement
            {
                get { return _ReportedElement; }
                set { _ReportedElement = value; OnPropertyChanged("ReportedElement"); }
            }
            
            private Hl7.Fhir.Model.FhirBoolean _ReportedElement;
            
            /// <summary>
            /// Indicates self-reported reaction
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public bool? Reported
            {
                get { return ReportedElement != null ? ReportedElement.Value : null; }
                set
                {
                    if (value == null)
                        ReportedElement = null;
                    else
                        ReportedElement = new Hl7.Fhir.Model.FhirBoolean(value);
                    OnPropertyChanged("Reported");
                }
            }
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("ReactionComponent");
                base.Serialize(sink);
                sink.Element("date", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DateElement?.Serialize(sink);
                sink.Element("detail", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Detail?.Serialize(sink);
                sink.Element("reported", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); ReportedElement?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                DateElement = source.GetDateTimeProperty("date", Hl7.Fhir.Model.Version.All);
                Detail = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("detail", Hl7.Fhir.Model.Version.All);
                ReportedElement = source.GetBooleanProperty("reported", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"date", typeof(Hl7.Fhir.Model.FhirDateTime)},
                    {"detail", typeof(Hl7.Fhir.Model.ResourceReference)},
                    {"reported", typeof(Hl7.Fhir.Model.FhirBoolean)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ReactionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                    if(Detail != null) dest.Detail = (Hl7.Fhir.Model.ResourceReference)Detail.DeepCopy();
                    if(ReportedElement != null) dest.ReportedElement = (Hl7.Fhir.Model.FhirBoolean)ReportedElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ReactionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ReactionComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if( !DeepComparable.Matches(Detail, otherT.Detail)) return false;
                if( !DeepComparable.Matches(ReportedElement, otherT.ReportedElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ReactionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if( !DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
                if( !DeepComparable.IsExactly(ReportedElement, otherT.ReportedElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DateElement != null) yield return DateElement;
                    if (Detail != null) yield return Detail;
                    if (ReportedElement != null) yield return ReportedElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DateElement != null) yield return new ElementValue("date", DateElement);
                    if (Detail != null) yield return new ElementValue("detail", Detail);
                    if (ReportedElement != null) yield return new ElementValue("reported", ReportedElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.STU3, "VaccinationProtocolComponent")]
        [DataContract]
        public partial class VaccinationProtocolComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "VaccinationProtocolComponent"; } }
            
            /// <summary>
            /// Dose number within series
            /// </summary>
            [FhirElement("doseSequence", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.PositiveInt DoseSequenceElement
            {
                get { return _DoseSequenceElement; }
                set { _DoseSequenceElement = value; OnPropertyChanged("DoseSequenceElement"); }
            }
            
            private Hl7.Fhir.Model.PositiveInt _DoseSequenceElement;
            
            /// <summary>
            /// Dose number within series
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? DoseSequence
            {
                get { return DoseSequenceElement != null ? DoseSequenceElement.Value : null; }
                set
                {
                    if (value == null)
                        DoseSequenceElement = null;
                    else
                        DoseSequenceElement = new Hl7.Fhir.Model.PositiveInt(value);
                    OnPropertyChanged("DoseSequence");
                }
            }
            
            /// <summary>
            /// Details of vaccine protocol
            /// </summary>
            [FhirElement("description", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DescriptionElement
            {
                get { return _DescriptionElement; }
                set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DescriptionElement;
            
            /// <summary>
            /// Details of vaccine protocol
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Description
            {
                get { return DescriptionElement != null ? DescriptionElement.Value : null; }
                set
                {
                    if (value == null)
                        DescriptionElement = null;
                    else
                        DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Description");
                }
            }
            
            /// <summary>
            /// Who is responsible for protocol
            /// </summary>
            [FhirElement("authority", Order=60)]
            [CLSCompliant(false)]
            [References("Organization")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Authority
            {
                get { return _Authority; }
                set { _Authority = value; OnPropertyChanged("Authority"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Authority;
            
            /// <summary>
            /// Name of vaccine series
            /// </summary>
            [FhirElement("series", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString SeriesElement
            {
                get { return _SeriesElement; }
                set { _SeriesElement = value; OnPropertyChanged("SeriesElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _SeriesElement;
            
            /// <summary>
            /// Name of vaccine series
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Series
            {
                get { return SeriesElement != null ? SeriesElement.Value : null; }
                set
                {
                    if (value == null)
                        SeriesElement = null;
                    else
                        SeriesElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Series");
                }
            }
            
            /// <summary>
            /// Recommended number of doses for immunity
            /// </summary>
            [FhirElement("seriesDoses", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.PositiveInt SeriesDosesElement
            {
                get { return _SeriesDosesElement; }
                set { _SeriesDosesElement = value; OnPropertyChanged("SeriesDosesElement"); }
            }
            
            private Hl7.Fhir.Model.PositiveInt _SeriesDosesElement;
            
            /// <summary>
            /// Recommended number of doses for immunity
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public int? SeriesDoses
            {
                get { return SeriesDosesElement != null ? SeriesDosesElement.Value : null; }
                set
                {
                    if (value == null)
                        SeriesDosesElement = null;
                    else
                        SeriesDosesElement = new Hl7.Fhir.Model.PositiveInt(value);
                    OnPropertyChanged("SeriesDoses");
                }
            }
            
            /// <summary>
            /// Disease immunized against
            /// </summary>
            [FhirElement("targetDisease", Order=90)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> TargetDisease
            {
                get { if(_TargetDisease==null) _TargetDisease = new List<Hl7.Fhir.Model.CodeableConcept>(); return _TargetDisease; }
                set { _TargetDisease = value; OnPropertyChanged("TargetDisease"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _TargetDisease;
            
            /// <summary>
            /// Indicates if dose counts towards immunity
            /// </summary>
            [FhirElement("doseStatus", Order=100)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept DoseStatus
            {
                get { return _DoseStatus; }
                set { _DoseStatus = value; OnPropertyChanged("DoseStatus"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _DoseStatus;
            
            /// <summary>
            /// Why dose does (not) count
            /// </summary>
            [FhirElement("doseStatusReason", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept DoseStatusReason
            {
                get { return _DoseStatusReason; }
                set { _DoseStatusReason = value; OnPropertyChanged("DoseStatusReason"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _DoseStatusReason;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("VaccinationProtocolComponent");
                base.Serialize(sink);
                sink.Element("doseSequence", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DoseSequenceElement?.Serialize(sink);
                sink.Element("description", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DescriptionElement?.Serialize(sink);
                sink.Element("authority", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Authority?.Serialize(sink);
                sink.Element("series", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); SeriesElement?.Serialize(sink);
                sink.Element("seriesDoses", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); SeriesDosesElement?.Serialize(sink);
                sink.BeginList("targetDisease", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true);
                foreach(var item in TargetDisease)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.Element("doseStatus", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); DoseStatus?.Serialize(sink);
                sink.Element("doseStatusReason", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DoseStatusReason?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                DoseSequenceElement = source.GetProperty<Hl7.Fhir.Model.PositiveInt>("doseSequence", Hl7.Fhir.Model.Version.All);
                DescriptionElement = source.GetStringProperty("description", Hl7.Fhir.Model.Version.All);
                Authority = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("authority", Hl7.Fhir.Model.Version.All);
                SeriesElement = source.GetStringProperty("series", Hl7.Fhir.Model.Version.All);
                SeriesDosesElement = source.GetProperty<Hl7.Fhir.Model.PositiveInt>("seriesDoses", Hl7.Fhir.Model.Version.All);
                TargetDisease = source.GetList<Hl7.Fhir.Model.CodeableConcept>("targetDisease", Hl7.Fhir.Model.Version.All);
                DoseStatus = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("doseStatus", Hl7.Fhir.Model.Version.All);
                DoseStatusReason = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("doseStatusReason", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"doseSequence", typeof(Hl7.Fhir.Model.PositiveInt)},
                    {"description", typeof(Hl7.Fhir.Model.FhirString)},
                    {"authority", typeof(Hl7.Fhir.Model.ResourceReference)},
                    {"series", typeof(Hl7.Fhir.Model.FhirString)},
                    {"seriesDoses", typeof(Hl7.Fhir.Model.PositiveInt)},
                    {"targetDisease", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"doseStatus", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"doseStatusReason", typeof(Hl7.Fhir.Model.CodeableConcept)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as VaccinationProtocolComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(DoseSequenceElement != null) dest.DoseSequenceElement = (Hl7.Fhir.Model.PositiveInt)DoseSequenceElement.DeepCopy();
                    if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                    if(Authority != null) dest.Authority = (Hl7.Fhir.Model.ResourceReference)Authority.DeepCopy();
                    if(SeriesElement != null) dest.SeriesElement = (Hl7.Fhir.Model.FhirString)SeriesElement.DeepCopy();
                    if(SeriesDosesElement != null) dest.SeriesDosesElement = (Hl7.Fhir.Model.PositiveInt)SeriesDosesElement.DeepCopy();
                    if(TargetDisease != null) dest.TargetDisease = new List<Hl7.Fhir.Model.CodeableConcept>(TargetDisease.DeepCopy());
                    if(DoseStatus != null) dest.DoseStatus = (Hl7.Fhir.Model.CodeableConcept)DoseStatus.DeepCopy();
                    if(DoseStatusReason != null) dest.DoseStatusReason = (Hl7.Fhir.Model.CodeableConcept)DoseStatusReason.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new VaccinationProtocolComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as VaccinationProtocolComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(DoseSequenceElement, otherT.DoseSequenceElement)) return false;
                if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
                if( !DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;
                if( !DeepComparable.Matches(SeriesDosesElement, otherT.SeriesDosesElement)) return false;
                if( !DeepComparable.Matches(TargetDisease, otherT.TargetDisease)) return false;
                if( !DeepComparable.Matches(DoseStatus, otherT.DoseStatus)) return false;
                if( !DeepComparable.Matches(DoseStatusReason, otherT.DoseStatusReason)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as VaccinationProtocolComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(DoseSequenceElement, otherT.DoseSequenceElement)) return false;
                if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
                if( !DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
                if( !DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;
                if( !DeepComparable.IsExactly(SeriesDosesElement, otherT.SeriesDosesElement)) return false;
                if( !DeepComparable.IsExactly(TargetDisease, otherT.TargetDisease)) return false;
                if( !DeepComparable.IsExactly(DoseStatus, otherT.DoseStatus)) return false;
                if( !DeepComparable.IsExactly(DoseStatusReason, otherT.DoseStatusReason)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DoseSequenceElement != null) yield return DoseSequenceElement;
                    if (DescriptionElement != null) yield return DescriptionElement;
                    if (Authority != null) yield return Authority;
                    if (SeriesElement != null) yield return SeriesElement;
                    if (SeriesDosesElement != null) yield return SeriesDosesElement;
                    foreach (var elem in TargetDisease) { if (elem != null) yield return elem; }
                    if (DoseStatus != null) yield return DoseStatus;
                    if (DoseStatusReason != null) yield return DoseStatusReason;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DoseSequenceElement != null) yield return new ElementValue("doseSequence", DoseSequenceElement);
                    if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                    if (Authority != null) yield return new ElementValue("authority", Authority);
                    if (SeriesElement != null) yield return new ElementValue("series", SeriesElement);
                    if (SeriesDosesElement != null) yield return new ElementValue("seriesDoses", SeriesDosesElement);
                    foreach (var elem in TargetDisease) { if (elem != null) yield return new ElementValue("targetDisease", elem); }
                    if (DoseStatus != null) yield return new ElementValue("doseStatus", DoseStatus);
                    if (DoseStatusReason != null) yield return new ElementValue("doseStatusReason", DoseStatusReason);
                }
            }
        
        
        }
        
        [NotMapped]
        IEnumerable<Hl7.Fhir.Model.IImmunizationReactionComponent> Hl7.Fhir.Model.IImmunization.Reaction { get { return Reaction; } }
    
        
        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// completed | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=Hl7.Fhir.Model.Version.All, Order=100)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.STU3.ImmunizationStatusCodes> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.STU3.ImmunizationStatusCodes> _StatusElement;
        
        /// <summary>
        /// completed | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.STU3.ImmunizationStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<Hl7.Fhir.Model.STU3.ImmunizationStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Flag for whether immunization was given
        /// </summary>
        [FhirElement("notGiven", InSummary=Hl7.Fhir.Model.Version.All, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean NotGivenElement
        {
            get { return _NotGivenElement; }
            set { _NotGivenElement = value; OnPropertyChanged("NotGivenElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _NotGivenElement;
        
        /// <summary>
        /// Flag for whether immunization was given
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? NotGiven
        {
            get { return NotGivenElement != null ? NotGivenElement.Value : null; }
            set
            {
                if (value == null)
                    NotGivenElement = null;
                else
                    NotGivenElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("NotGiven");
            }
        }
        
        /// <summary>
        /// Vaccine product administered
        /// </summary>
        [FhirElement("vaccineCode", Order=120)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept VaccineCode
        {
            get { return _VaccineCode; }
            set { _VaccineCode = value; OnPropertyChanged("VaccineCode"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _VaccineCode;
        
        /// <summary>
        /// Who was immunized
        /// </summary>
        [FhirElement("patient", Order=130)]
        [CLSCompliant(false)]
        [References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Patient;
        
        /// <summary>
        /// Encounter administered as part of
        /// </summary>
        [FhirElement("encounter", Order=140)]
        [CLSCompliant(false)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Encounter;
        
        /// <summary>
        /// Vaccination administration date
        /// </summary>
        [FhirElement("date", Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Vaccination administration date
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
                    DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Indicates context the data was recorded in
        /// </summary>
        [FhirElement("primarySource", Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean PrimarySourceElement
        {
            get { return _PrimarySourceElement; }
            set { _PrimarySourceElement = value; OnPropertyChanged("PrimarySourceElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _PrimarySourceElement;
        
        /// <summary>
        /// Indicates context the data was recorded in
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? PrimarySource
        {
            get { return PrimarySourceElement != null ? PrimarySourceElement.Value : null; }
            set
            {
                if (value == null)
                    PrimarySourceElement = null;
                else
                    PrimarySourceElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("PrimarySource");
            }
        }
        
        /// <summary>
        /// Indicates the source of a secondarily reported record
        /// </summary>
        [FhirElement("reportOrigin", Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept ReportOrigin
        {
            get { return _ReportOrigin; }
            set { _ReportOrigin = value; OnPropertyChanged("ReportOrigin"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _ReportOrigin;
        
        /// <summary>
        /// Where vaccination occurred
        /// </summary>
        [FhirElement("location", Order=180)]
        [CLSCompliant(false)]
        [References("Location")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Location
        {
            get { return _Location; }
            set { _Location = value; OnPropertyChanged("Location"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Location;
        
        /// <summary>
        /// Vaccine manufacturer
        /// </summary>
        [FhirElement("manufacturer", Order=190)]
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
        /// Vaccine lot number
        /// </summary>
        [FhirElement("lotNumber", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString LotNumberElement
        {
            get { return _LotNumberElement; }
            set { _LotNumberElement = value; OnPropertyChanged("LotNumberElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _LotNumberElement;
        
        /// <summary>
        /// Vaccine lot number
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string LotNumber
        {
            get { return LotNumberElement != null ? LotNumberElement.Value : null; }
            set
            {
                if (value == null)
                    LotNumberElement = null;
                else
                    LotNumberElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("LotNumber");
            }
        }
        
        /// <summary>
        /// Vaccine expiration date
        /// </summary>
        [FhirElement("expirationDate", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.Date ExpirationDateElement
        {
            get { return _ExpirationDateElement; }
            set { _ExpirationDateElement = value; OnPropertyChanged("ExpirationDateElement"); }
        }
        
        private Hl7.Fhir.Model.Date _ExpirationDateElement;
        
        /// <summary>
        /// Vaccine expiration date
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string ExpirationDate
        {
            get { return ExpirationDateElement != null ? ExpirationDateElement.Value : null; }
            set
            {
                if (value == null)
                    ExpirationDateElement = null;
                else
                    ExpirationDateElement = new Hl7.Fhir.Model.Date(value);
                OnPropertyChanged("ExpirationDate");
            }
        }
        
        /// <summary>
        /// Body site vaccine  was administered
        /// </summary>
        [FhirElement("site", Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Site
        {
            get { return _Site; }
            set { _Site = value; OnPropertyChanged("Site"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Site;
        
        /// <summary>
        /// How vaccine entered body
        /// </summary>
        [FhirElement("route", Order=230)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Route
        {
            get { return _Route; }
            set { _Route = value; OnPropertyChanged("Route"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Route;
        
        /// <summary>
        /// Amount of vaccine administered
        /// </summary>
        [FhirElement("doseQuantity", Order=240)]
        [DataMember]
        public Hl7.Fhir.Model.SimpleQuantity DoseQuantity
        {
            get { return _DoseQuantity; }
            set { _DoseQuantity = value; OnPropertyChanged("DoseQuantity"); }
        }
        
        private Hl7.Fhir.Model.SimpleQuantity _DoseQuantity;
        
        /// <summary>
        /// Who performed event
        /// </summary>
        [FhirElement("practitioner", InSummary=Hl7.Fhir.Model.Version.All, Order=250)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PractitionerComponent> Practitioner
        {
            get { if(_Practitioner==null) _Practitioner = new List<PractitionerComponent>(); return _Practitioner; }
            set { _Practitioner = value; OnPropertyChanged("Practitioner"); }
        }
        
        private List<PractitionerComponent> _Practitioner;
        
        /// <summary>
        /// Vaccination notes
        /// </summary>
        [FhirElement("note", InSummary=Hl7.Fhir.Model.Version.All, Order=260)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Annotation> Note
        {
            get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
            set { _Note = value; OnPropertyChanged("Note"); }
        }
        
        private List<Hl7.Fhir.Model.Annotation> _Note;
        
        /// <summary>
        /// Administration/non-administration reasons
        /// </summary>
        [FhirElement("explanation", Order=270)]
        [DataMember]
        public ExplanationComponent Explanation
        {
            get { return _Explanation; }
            set { _Explanation = value; OnPropertyChanged("Explanation"); }
        }
        
        private ExplanationComponent _Explanation;
        
        /// <summary>
        /// Details of a reaction that follows immunization
        /// </summary>
        [FhirElement("reaction", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ReactionComponent> Reaction
        {
            get { if(_Reaction==null) _Reaction = new List<ReactionComponent>(); return _Reaction; }
            set { _Reaction = value; OnPropertyChanged("Reaction"); }
        }
        
        private List<ReactionComponent> _Reaction;
        
        /// <summary>
        /// What protocol was followed
        /// </summary>
        [FhirElement("vaccinationProtocol", Order=290)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<VaccinationProtocolComponent> VaccinationProtocol
        {
            get { if(_VaccinationProtocol==null) _VaccinationProtocol = new List<VaccinationProtocolComponent>(); return _VaccinationProtocol; }
            set { _VaccinationProtocol = value; OnPropertyChanged("VaccinationProtocol"); }
        }
        
        private List<VaccinationProtocolComponent> _VaccinationProtocol;
    
    
        public static ElementDefinitionConstraint[] Immunization_Constraints =
        {
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "imm-2",
                severity: ConstraintSeverity.Warning,
                expression: "(notGiven = true) or explanation.reasonNotGiven.empty()",
                human: "If immunization was administered (notGiven=false) then explanation.reasonNotGiven SHALL be absent.",
                xpath: "not(f:notGiven/@value=false() and exists(f:explanation/f:reasonNotGiven))"
            ),
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.STU3},
                key: "imm-1",
                severity: ConstraintSeverity.Warning,
                expression: "(notGiven = true).not() or (reaction.empty() and explanation.reason.empty())",
                human: "If immunization was not administered (notGiven=true) then there SHALL be no reaction nor explanation.reason present",
                xpath: "not(f:notGiven/@value=true() and (count(f:reaction) > 0 or exists(f:explanation/f:reason)))"
            ),
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
            InvariantConstraints.AddRange(Immunization_Constraints);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Immunization;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.STU3.ImmunizationStatusCodes>)StatusElement.DeepCopy();
                if(NotGivenElement != null) dest.NotGivenElement = (Hl7.Fhir.Model.FhirBoolean)NotGivenElement.DeepCopy();
                if(VaccineCode != null) dest.VaccineCode = (Hl7.Fhir.Model.CodeableConcept)VaccineCode.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(PrimarySourceElement != null) dest.PrimarySourceElement = (Hl7.Fhir.Model.FhirBoolean)PrimarySourceElement.DeepCopy();
                if(ReportOrigin != null) dest.ReportOrigin = (Hl7.Fhir.Model.CodeableConcept)ReportOrigin.DeepCopy();
                if(Location != null) dest.Location = (Hl7.Fhir.Model.ResourceReference)Location.DeepCopy();
                if(Manufacturer != null) dest.Manufacturer = (Hl7.Fhir.Model.ResourceReference)Manufacturer.DeepCopy();
                if(LotNumberElement != null) dest.LotNumberElement = (Hl7.Fhir.Model.FhirString)LotNumberElement.DeepCopy();
                if(ExpirationDateElement != null) dest.ExpirationDateElement = (Hl7.Fhir.Model.Date)ExpirationDateElement.DeepCopy();
                if(Site != null) dest.Site = (Hl7.Fhir.Model.CodeableConcept)Site.DeepCopy();
                if(Route != null) dest.Route = (Hl7.Fhir.Model.CodeableConcept)Route.DeepCopy();
                if(DoseQuantity != null) dest.DoseQuantity = (Hl7.Fhir.Model.SimpleQuantity)DoseQuantity.DeepCopy();
                if(Practitioner != null) dest.Practitioner = new List<PractitionerComponent>(Practitioner.DeepCopy());
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                if(Explanation != null) dest.Explanation = (ExplanationComponent)Explanation.DeepCopy();
                if(Reaction != null) dest.Reaction = new List<ReactionComponent>(Reaction.DeepCopy());
                if(VaccinationProtocol != null) dest.VaccinationProtocol = new List<VaccinationProtocolComponent>(VaccinationProtocol.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Immunization());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Immunization;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(NotGivenElement, otherT.NotGivenElement)) return false;
            if( !DeepComparable.Matches(VaccineCode, otherT.VaccineCode)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(PrimarySourceElement, otherT.PrimarySourceElement)) return false;
            if( !DeepComparable.Matches(ReportOrigin, otherT.ReportOrigin)) return false;
            if( !DeepComparable.Matches(Location, otherT.Location)) return false;
            if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if( !DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if( !DeepComparable.Matches(Site, otherT.Site)) return false;
            if( !DeepComparable.Matches(Route, otherT.Route)) return false;
            if( !DeepComparable.Matches(DoseQuantity, otherT.DoseQuantity)) return false;
            if( !DeepComparable.Matches(Practitioner, otherT.Practitioner)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(Explanation, otherT.Explanation)) return false;
            if( !DeepComparable.Matches(Reaction, otherT.Reaction)) return false;
            if( !DeepComparable.Matches(VaccinationProtocol, otherT.VaccinationProtocol)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Immunization;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(NotGivenElement, otherT.NotGivenElement)) return false;
            if( !DeepComparable.IsExactly(VaccineCode, otherT.VaccineCode)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(PrimarySourceElement, otherT.PrimarySourceElement)) return false;
            if( !DeepComparable.IsExactly(ReportOrigin, otherT.ReportOrigin)) return false;
            if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if( !DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if( !DeepComparable.IsExactly(Site, otherT.Site)) return false;
            if( !DeepComparable.IsExactly(Route, otherT.Route)) return false;
            if( !DeepComparable.IsExactly(DoseQuantity, otherT.DoseQuantity)) return false;
            if( !DeepComparable.IsExactly(Practitioner, otherT.Practitioner)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(Explanation, otherT.Explanation)) return false;
            if( !DeepComparable.IsExactly(Reaction, otherT.Reaction)) return false;
            if( !DeepComparable.IsExactly(VaccinationProtocol, otherT.VaccinationProtocol)) return false;
        
            return true;
        }
    
        internal override void Serialize(Serialization.SerializerSink sink)
        {
            sink.BeginResource("Immunization");
            base.Serialize(sink);
            sink.BeginList("identifier", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Identifier)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("status", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); StatusElement?.Serialize(sink);
            sink.Element("notGiven", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); NotGivenElement?.Serialize(sink);
            sink.Element("vaccineCode", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); VaccineCode?.Serialize(sink);
            sink.Element("patient", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); Patient?.Serialize(sink);
            sink.Element("encounter", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Encounter?.Serialize(sink);
            sink.Element("date", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DateElement?.Serialize(sink);
            sink.Element("primarySource", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, false); PrimarySourceElement?.Serialize(sink);
            sink.Element("reportOrigin", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); ReportOrigin?.Serialize(sink);
            sink.Element("location", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Location?.Serialize(sink);
            sink.Element("manufacturer", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Manufacturer?.Serialize(sink);
            sink.Element("lotNumber", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); LotNumberElement?.Serialize(sink);
            sink.Element("expirationDate", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); ExpirationDateElement?.Serialize(sink);
            sink.Element("site", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Site?.Serialize(sink);
            sink.Element("route", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Route?.Serialize(sink);
            sink.Element("doseQuantity", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DoseQuantity?.Serialize(sink);
            sink.BeginList("practitioner", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Practitioner)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("note", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Note)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("explanation", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Explanation?.Serialize(sink);
            sink.BeginList("reaction", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Reaction)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("vaccinationProtocol", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in VaccinationProtocol)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.End();
        }
        
        internal override void Parse(Serialization.IParserSource source)
        {
            base.Parse(source);
            Identifier = source.GetList<Hl7.Fhir.Model.Identifier>("identifier", Hl7.Fhir.Model.Version.All);
            StatusElement = source.GetCodeEnumProperty<Hl7.Fhir.Model.STU3.ImmunizationStatusCodes>("status", Hl7.Fhir.Model.Version.All);
            NotGivenElement = source.GetBooleanProperty("notGiven", Hl7.Fhir.Model.Version.All);
            VaccineCode = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("vaccineCode", Hl7.Fhir.Model.Version.All);
            Patient = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("patient", Hl7.Fhir.Model.Version.All);
            Encounter = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("encounter", Hl7.Fhir.Model.Version.All);
            DateElement = source.GetDateTimeProperty("date", Hl7.Fhir.Model.Version.All);
            PrimarySourceElement = source.GetBooleanProperty("primarySource", Hl7.Fhir.Model.Version.All);
            ReportOrigin = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("reportOrigin", Hl7.Fhir.Model.Version.All);
            Location = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("location", Hl7.Fhir.Model.Version.All);
            Manufacturer = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("manufacturer", Hl7.Fhir.Model.Version.All);
            LotNumberElement = source.GetStringProperty("lotNumber", Hl7.Fhir.Model.Version.All);
            ExpirationDateElement = source.GetDateProperty("expirationDate", Hl7.Fhir.Model.Version.All);
            Site = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("site", Hl7.Fhir.Model.Version.All);
            Route = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("route", Hl7.Fhir.Model.Version.All);
            DoseQuantity = source.GetProperty<Hl7.Fhir.Model.SimpleQuantity>("doseQuantity", Hl7.Fhir.Model.Version.All);
            Practitioner = source.GetList<PractitionerComponent>("practitioner", Hl7.Fhir.Model.Version.All);
            Note = source.GetList<Hl7.Fhir.Model.Annotation>("note", Hl7.Fhir.Model.Version.All);
            Explanation = source.GetProperty<ExplanationComponent>("explanation", Hl7.Fhir.Model.Version.All);
            Reaction = source.GetList<ReactionComponent>("reaction", Hl7.Fhir.Model.Version.All);
            VaccinationProtocol = source.GetList<VaccinationProtocolComponent>("vaccinationProtocol", Hl7.Fhir.Model.Version.All);
        }
        
        internal override Type GetPropertyType(string fhirName)
        {
            if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
            return base.GetPropertyType(fhirName);
        }
        
        private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
        {
                {"identifier", typeof(Hl7.Fhir.Model.Identifier)},
                {"status", typeof(Hl7.Fhir.Model.Code<Hl7.Fhir.Model.STU3.ImmunizationStatusCodes>)},
                {"notGiven", typeof(Hl7.Fhir.Model.FhirBoolean)},
                {"vaccineCode", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"patient", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"encounter", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"date", typeof(Hl7.Fhir.Model.FhirDateTime)},
                {"primarySource", typeof(Hl7.Fhir.Model.FhirBoolean)},
                {"reportOrigin", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"location", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"manufacturer", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"lotNumber", typeof(Hl7.Fhir.Model.FhirString)},
                {"expirationDate", typeof(Hl7.Fhir.Model.Date)},
                {"site", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"route", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"doseQuantity", typeof(Hl7.Fhir.Model.SimpleQuantity)},
                {"practitioner", typeof(PractitionerComponent)},
                {"note", typeof(Hl7.Fhir.Model.Annotation)},
                {"explanation", typeof(ExplanationComponent)},
                {"reaction", typeof(ReactionComponent)},
                {"vaccinationProtocol", typeof(VaccinationProtocolComponent)},
        };
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (NotGivenElement != null) yield return NotGivenElement;
                if (VaccineCode != null) yield return VaccineCode;
                if (Patient != null) yield return Patient;
                if (Encounter != null) yield return Encounter;
                if (DateElement != null) yield return DateElement;
                if (PrimarySourceElement != null) yield return PrimarySourceElement;
                if (ReportOrigin != null) yield return ReportOrigin;
                if (Location != null) yield return Location;
                if (Manufacturer != null) yield return Manufacturer;
                if (LotNumberElement != null) yield return LotNumberElement;
                if (ExpirationDateElement != null) yield return ExpirationDateElement;
                if (Site != null) yield return Site;
                if (Route != null) yield return Route;
                if (DoseQuantity != null) yield return DoseQuantity;
                foreach (var elem in Practitioner) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                if (Explanation != null) yield return Explanation;
                foreach (var elem in Reaction) { if (elem != null) yield return elem; }
                foreach (var elem in VaccinationProtocol) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (NotGivenElement != null) yield return new ElementValue("notGiven", NotGivenElement);
                if (VaccineCode != null) yield return new ElementValue("vaccineCode", VaccineCode);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PrimarySourceElement != null) yield return new ElementValue("primarySource", PrimarySourceElement);
                if (ReportOrigin != null) yield return new ElementValue("reportOrigin", ReportOrigin);
                if (Location != null) yield return new ElementValue("location", Location);
                if (Manufacturer != null) yield return new ElementValue("manufacturer", Manufacturer);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
                if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
                if (Site != null) yield return new ElementValue("site", Site);
                if (Route != null) yield return new ElementValue("route", Route);
                if (DoseQuantity != null) yield return new ElementValue("doseQuantity", DoseQuantity);
                foreach (var elem in Practitioner) { if (elem != null) yield return new ElementValue("practitioner", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                if (Explanation != null) yield return new ElementValue("explanation", Explanation);
                foreach (var elem in Reaction) { if (elem != null) yield return new ElementValue("reaction", elem); }
                foreach (var elem in VaccinationProtocol) { if (elem != null) yield return new ElementValue("vaccinationProtocol", elem); }
            }
        }
    
    }

}
