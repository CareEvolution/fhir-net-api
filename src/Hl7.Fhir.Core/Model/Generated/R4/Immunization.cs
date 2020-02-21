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
    /// Immunization event information
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "Immunization", IsResource=true)]
    [DataContract]
    public partial class Immunization : Hl7.Fhir.Model.DomainResource, Hl7.Fhir.Model.IImmunization, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Immunization; } }
        [NotMapped]
        public override string TypeName { get { return "Immunization"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "PerformerComponent")]
        [DataContract]
        public partial class PerformerComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "PerformerComponent"; } }
            
            /// <summary>
            /// What type of performance was done
            /// </summary>
            [FhirElement("function", InSummary=Hl7.Fhir.Model.Version.All, Order=40)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Function
            {
                get { return _Function; }
                set { _Function = value; OnPropertyChanged("Function"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Function;
            
            /// <summary>
            /// Individual or organization who was performing
            /// </summary>
            [FhirElement("actor", InSummary=Hl7.Fhir.Model.Version.All, Order=50)]
            [CLSCompliant(false)]
            [References("Practitioner","PractitionerRole","Organization")]
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
                sink.BeginDataType("PerformerComponent");
                base.Serialize(sink);
                sink.Element("function", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); Function?.Serialize(sink);
                sink.Element("actor", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); Actor?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                Function = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("function", Hl7.Fhir.Model.Version.All);
                Actor = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("actor", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"function", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"actor", typeof(Hl7.Fhir.Model.ResourceReference)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as PerformerComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Function != null) dest.Function = (Hl7.Fhir.Model.CodeableConcept)Function.DeepCopy();
                    if(Actor != null) dest.Actor = (Hl7.Fhir.Model.ResourceReference)Actor.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new PerformerComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as PerformerComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Function, otherT.Function)) return false;
                if( !DeepComparable.Matches(Actor, otherT.Actor)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as PerformerComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Function, otherT.Function)) return false;
                if( !DeepComparable.IsExactly(Actor, otherT.Actor)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Function != null) yield return Function;
                    if (Actor != null) yield return Actor;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Function != null) yield return new ElementValue("function", Function);
                    if (Actor != null) yield return new ElementValue("actor", Actor);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "EducationComponent")]
        [DataContract]
        public partial class EducationComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "EducationComponent"; } }
            
            /// <summary>
            /// Educational material document identifier
            /// </summary>
            [FhirElement("documentType", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString DocumentTypeElement
            {
                get { return _DocumentTypeElement; }
                set { _DocumentTypeElement = value; OnPropertyChanged("DocumentTypeElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _DocumentTypeElement;
            
            /// <summary>
            /// Educational material document identifier
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string DocumentType
            {
                get { return DocumentTypeElement != null ? DocumentTypeElement.Value : null; }
                set
                {
                    if (value == null)
                        DocumentTypeElement = null;
                    else
                        DocumentTypeElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("DocumentType");
                }
            }
            
            /// <summary>
            /// Educational material reference pointer
            /// </summary>
            [FhirElement("reference", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirUri ReferenceElement
            {
                get { return _ReferenceElement; }
                set { _ReferenceElement = value; OnPropertyChanged("ReferenceElement"); }
            }
            
            private Hl7.Fhir.Model.FhirUri _ReferenceElement;
            
            /// <summary>
            /// Educational material reference pointer
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Reference
            {
                get { return ReferenceElement != null ? ReferenceElement.Value : null; }
                set
                {
                    if (value == null)
                        ReferenceElement = null;
                    else
                        ReferenceElement = new Hl7.Fhir.Model.FhirUri(value);
                    OnPropertyChanged("Reference");
                }
            }
            
            /// <summary>
            /// Educational material publication date
            /// </summary>
            [FhirElement("publicationDate", Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime PublicationDateElement
            {
                get { return _PublicationDateElement; }
                set { _PublicationDateElement = value; OnPropertyChanged("PublicationDateElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _PublicationDateElement;
            
            /// <summary>
            /// Educational material publication date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string PublicationDate
            {
                get { return PublicationDateElement != null ? PublicationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        PublicationDateElement = null;
                    else
                        PublicationDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("PublicationDate");
                }
            }
            
            /// <summary>
            /// Educational material presentation date
            /// </summary>
            [FhirElement("presentationDate", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime PresentationDateElement
            {
                get { return _PresentationDateElement; }
                set { _PresentationDateElement = value; OnPropertyChanged("PresentationDateElement"); }
            }
            
            private Hl7.Fhir.Model.FhirDateTime _PresentationDateElement;
            
            /// <summary>
            /// Educational material presentation date
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string PresentationDate
            {
                get { return PresentationDateElement != null ? PresentationDateElement.Value : null; }
                set
                {
                    if (value == null)
                        PresentationDateElement = null;
                    else
                        PresentationDateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("PresentationDate");
                }
            }
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("EducationComponent");
                base.Serialize(sink);
                sink.Element("documentType", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DocumentTypeElement?.Serialize(sink);
                sink.Element("reference", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); ReferenceElement?.Serialize(sink);
                sink.Element("publicationDate", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); PublicationDateElement?.Serialize(sink);
                sink.Element("presentationDate", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); PresentationDateElement?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                DocumentTypeElement = source.GetStringProperty("documentType", Hl7.Fhir.Model.Version.All);
                ReferenceElement = source.GetUriProperty("reference", Hl7.Fhir.Model.Version.All);
                PublicationDateElement = source.GetDateTimeProperty("publicationDate", Hl7.Fhir.Model.Version.All);
                PresentationDateElement = source.GetDateTimeProperty("presentationDate", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"documentType", typeof(Hl7.Fhir.Model.FhirString)},
                    {"reference", typeof(Hl7.Fhir.Model.FhirUri)},
                    {"publicationDate", typeof(Hl7.Fhir.Model.FhirDateTime)},
                    {"presentationDate", typeof(Hl7.Fhir.Model.FhirDateTime)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EducationComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(DocumentTypeElement != null) dest.DocumentTypeElement = (Hl7.Fhir.Model.FhirString)DocumentTypeElement.DeepCopy();
                    if(ReferenceElement != null) dest.ReferenceElement = (Hl7.Fhir.Model.FhirUri)ReferenceElement.DeepCopy();
                    if(PublicationDateElement != null) dest.PublicationDateElement = (Hl7.Fhir.Model.FhirDateTime)PublicationDateElement.DeepCopy();
                    if(PresentationDateElement != null) dest.PresentationDateElement = (Hl7.Fhir.Model.FhirDateTime)PresentationDateElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EducationComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EducationComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(DocumentTypeElement, otherT.DocumentTypeElement)) return false;
                if( !DeepComparable.Matches(ReferenceElement, otherT.ReferenceElement)) return false;
                if( !DeepComparable.Matches(PublicationDateElement, otherT.PublicationDateElement)) return false;
                if( !DeepComparable.Matches(PresentationDateElement, otherT.PresentationDateElement)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EducationComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(DocumentTypeElement, otherT.DocumentTypeElement)) return false;
                if( !DeepComparable.IsExactly(ReferenceElement, otherT.ReferenceElement)) return false;
                if( !DeepComparable.IsExactly(PublicationDateElement, otherT.PublicationDateElement)) return false;
                if( !DeepComparable.IsExactly(PresentationDateElement, otherT.PresentationDateElement)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (DocumentTypeElement != null) yield return DocumentTypeElement;
                    if (ReferenceElement != null) yield return ReferenceElement;
                    if (PublicationDateElement != null) yield return PublicationDateElement;
                    if (PresentationDateElement != null) yield return PresentationDateElement;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (DocumentTypeElement != null) yield return new ElementValue("documentType", DocumentTypeElement);
                    if (ReferenceElement != null) yield return new ElementValue("reference", ReferenceElement);
                    if (PublicationDateElement != null) yield return new ElementValue("publicationDate", PublicationDateElement);
                    if (PresentationDateElement != null) yield return new ElementValue("presentationDate", PresentationDateElement);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ReactionComponent")]
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
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "ProtocolAppliedComponent")]
        [DataContract]
        public partial class ProtocolAppliedComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged, IComponent
        {
            [NotMapped]
            public override string TypeName { get { return "ProtocolAppliedComponent"; } }
            
            /// <summary>
            /// Name of vaccine series
            /// </summary>
            [FhirElement("series", Order=40)]
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
            /// Who is responsible for publishing the recommendations
            /// </summary>
            [FhirElement("authority", Order=50)]
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
            /// Vaccine preventatable disease being targetted
            /// </summary>
            [FhirElement("targetDisease", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> TargetDisease
            {
                get { if(_TargetDisease==null) _TargetDisease = new List<Hl7.Fhir.Model.CodeableConcept>(); return _TargetDisease; }
                set { _TargetDisease = value; OnPropertyChanged("TargetDisease"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _TargetDisease;
            
            /// <summary>
            /// Dose number within series
            /// </summary>
            [FhirElement("doseNumber", Order=70, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.PositiveInt),typeof(Hl7.Fhir.Model.FhirString))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element DoseNumber
            {
                get { return _DoseNumber; }
                set { _DoseNumber = value; OnPropertyChanged("DoseNumber"); }
            }
            
            private Hl7.Fhir.Model.Element _DoseNumber;
            
            /// <summary>
            /// Recommended number of doses for immunity
            /// </summary>
            [FhirElement("seriesDoses", Order=80, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.PositiveInt),typeof(Hl7.Fhir.Model.FhirString))]
            [DataMember]
            public Hl7.Fhir.Model.Element SeriesDoses
            {
                get { return _SeriesDoses; }
                set { _SeriesDoses = value; OnPropertyChanged("SeriesDoses"); }
            }
            
            private Hl7.Fhir.Model.Element _SeriesDoses;
        
            internal override void Serialize(Serialization.SerializerSink sink)
            {
                sink.BeginDataType("ProtocolAppliedComponent");
                base.Serialize(sink);
                sink.Element("series", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); SeriesElement?.Serialize(sink);
                sink.Element("authority", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Authority?.Serialize(sink);
                sink.BeginList("targetDisease", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
                foreach(var item in TargetDisease)
                {
                    item?.Serialize(sink);
                }
                sink.End();
                sink.Element("doseNumber", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, true, true); DoseNumber?.Serialize(sink);
                sink.Element("seriesDoses", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, true); SeriesDoses?.Serialize(sink);
                sink.End();
            }
            
            internal override void Parse(Serialization.IParserSource source)
            {
                base.Parse(source);
                SeriesElement = source.GetStringProperty("series", Hl7.Fhir.Model.Version.All);
                Authority = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("authority", Hl7.Fhir.Model.Version.All);
                TargetDisease = source.GetList<Hl7.Fhir.Model.CodeableConcept>("targetDisease", Hl7.Fhir.Model.Version.All);
                DoseNumber = source.GetProperty<Hl7.Fhir.Model.Element>("doseNumber", Hl7.Fhir.Model.Version.All);
                SeriesDoses = source.GetProperty<Hl7.Fhir.Model.Element>("seriesDoses", Hl7.Fhir.Model.Version.All);
            }
            
            internal override Type GetPropertyType(string fhirName)
            {
                if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
                return base.GetPropertyType(fhirName);
            }
            
            private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
            {
                    {"series", typeof(Hl7.Fhir.Model.FhirString)},
                    {"authority", typeof(Hl7.Fhir.Model.ResourceReference)},
                    {"targetDisease", typeof(Hl7.Fhir.Model.CodeableConcept)},
                    {"doseNumber", typeof(Hl7.Fhir.Model.Element)},
                    {"seriesDoses", typeof(Hl7.Fhir.Model.Element)},
            };
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProtocolAppliedComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(SeriesElement != null) dest.SeriesElement = (Hl7.Fhir.Model.FhirString)SeriesElement.DeepCopy();
                    if(Authority != null) dest.Authority = (Hl7.Fhir.Model.ResourceReference)Authority.DeepCopy();
                    if(TargetDisease != null) dest.TargetDisease = new List<Hl7.Fhir.Model.CodeableConcept>(TargetDisease.DeepCopy());
                    if(DoseNumber != null) dest.DoseNumber = (Hl7.Fhir.Model.Element)DoseNumber.DeepCopy();
                    if(SeriesDoses != null) dest.SeriesDoses = (Hl7.Fhir.Model.Element)SeriesDoses.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ProtocolAppliedComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProtocolAppliedComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;
                if( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
                if( !DeepComparable.Matches(TargetDisease, otherT.TargetDisease)) return false;
                if( !DeepComparable.Matches(DoseNumber, otherT.DoseNumber)) return false;
                if( !DeepComparable.Matches(SeriesDoses, otherT.SeriesDoses)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProtocolAppliedComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;
                if( !DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
                if( !DeepComparable.IsExactly(TargetDisease, otherT.TargetDisease)) return false;
                if( !DeepComparable.IsExactly(DoseNumber, otherT.DoseNumber)) return false;
                if( !DeepComparable.IsExactly(SeriesDoses, otherT.SeriesDoses)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SeriesElement != null) yield return SeriesElement;
                    if (Authority != null) yield return Authority;
                    foreach (var elem in TargetDisease) { if (elem != null) yield return elem; }
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
                    if (SeriesElement != null) yield return new ElementValue("series", SeriesElement);
                    if (Authority != null) yield return new ElementValue("authority", Authority);
                    foreach (var elem in TargetDisease) { if (elem != null) yield return new ElementValue("targetDisease", elem); }
                    if (DoseNumber != null) yield return new ElementValue("doseNumber", DoseNumber);
                    if (SeriesDoses != null) yield return new ElementValue("seriesDoses", SeriesDoses);
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
        /// completed | entered-in-error | not-done
        /// </summary>
        [FhirElement("status", InSummary=Hl7.Fhir.Model.Version.All, Order=100)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.R4.ImmunizationStatusCodes> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.R4.ImmunizationStatusCodes> _StatusElement;
        
        /// <summary>
        /// completed | entered-in-error | not-done
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.R4.ImmunizationStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<Hl7.Fhir.Model.R4.ImmunizationStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Reason not done
        /// </summary>
        [FhirElement("statusReason", Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept StatusReason
        {
            get { return _StatusReason; }
            set { _StatusReason = value; OnPropertyChanged("StatusReason"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _StatusReason;
        
        /// <summary>
        /// Vaccine product administered
        /// </summary>
        [FhirElement("vaccineCode", InSummary=Hl7.Fhir.Model.Version.All, Order=120)]
        [CLSCompliant(false)]
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
        [FhirElement("patient", InSummary=Hl7.Fhir.Model.Version.All, Order=130)]
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
        /// Encounter immunization was part of
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
        /// Vaccine administration date
        /// </summary>
        [FhirElement("occurrence", InSummary=Hl7.Fhir.Model.Version.All, Order=150, Choice=ChoiceType.DatatypeChoice)]
        [CLSCompliant(false)]
        [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.FhirString))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.Element Occurrence
        {
            get { return _Occurrence; }
            set { _Occurrence = value; OnPropertyChanged("Occurrence"); }
        }
        
        private Hl7.Fhir.Model.Element _Occurrence;
        
        /// <summary>
        /// When the immunization was first captured in the subject's record
        /// </summary>
        [FhirElement("recorded", Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime RecordedElement
        {
            get { return _RecordedElement; }
            set { _RecordedElement = value; OnPropertyChanged("RecordedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _RecordedElement;
        
        /// <summary>
        /// When the immunization was first captured in the subject's record
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Recorded
        {
            get { return RecordedElement != null ? RecordedElement.Value : null; }
            set
            {
                if (value == null)
                    RecordedElement = null;
                else
                    RecordedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Recorded");
            }
        }
        
        /// <summary>
        /// Indicates context the data was recorded in
        /// </summary>
        [FhirElement("primarySource", InSummary=Hl7.Fhir.Model.Version.All, Order=170)]
        [CLSCompliant(false)]
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
        [FhirElement("reportOrigin", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept ReportOrigin
        {
            get { return _ReportOrigin; }
            set { _ReportOrigin = value; OnPropertyChanged("ReportOrigin"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _ReportOrigin;
        
        /// <summary>
        /// Where immunization occurred
        /// </summary>
        [FhirElement("location", Order=190)]
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
        [FhirElement("manufacturer", Order=200)]
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
        [FhirElement("lotNumber", Order=210)]
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
        [FhirElement("expirationDate", Order=220)]
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
        [FhirElement("site", Order=230)]
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
        [FhirElement("route", Order=240)]
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
        [FhirElement("doseQuantity", Order=250)]
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
        [FhirElement("performer", InSummary=Hl7.Fhir.Model.Version.All, Order=260)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<PerformerComponent> Performer
        {
            get { if(_Performer==null) _Performer = new List<PerformerComponent>(); return _Performer; }
            set { _Performer = value; OnPropertyChanged("Performer"); }
        }
        
        private List<PerformerComponent> _Performer;
        
        /// <summary>
        /// Additional immunization notes
        /// </summary>
        [FhirElement("note", InSummary=Hl7.Fhir.Model.Version.All, Order=270)]
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
        /// Why immunization occurred
        /// </summary>
        [FhirElement("reasonCode", Order=280)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> ReasonCode
        {
            get { if(_ReasonCode==null) _ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ReasonCode; }
            set { _ReasonCode = value; OnPropertyChanged("ReasonCode"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _ReasonCode;
        
        /// <summary>
        /// Why immunization occurred
        /// </summary>
        [FhirElement("reasonReference", Order=290)]
        [CLSCompliant(false)]
        [References("Condition","Observation","DiagnosticReport")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> ReasonReference
        {
            get { if(_ReasonReference==null) _ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(); return _ReasonReference; }
            set { _ReasonReference = value; OnPropertyChanged("ReasonReference"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _ReasonReference;
        
        /// <summary>
        /// Dose potency
        /// </summary>
        [FhirElement("isSubpotent", InSummary=Hl7.Fhir.Model.Version.All, Order=300)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.FhirBoolean IsSubpotentElement
        {
            get { return _IsSubpotentElement; }
            set { _IsSubpotentElement = value; OnPropertyChanged("IsSubpotentElement"); }
        }
        
        private Hl7.Fhir.Model.FhirBoolean _IsSubpotentElement;
        
        /// <summary>
        /// Dose potency
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public bool? IsSubpotent
        {
            get { return IsSubpotentElement != null ? IsSubpotentElement.Value : null; }
            set
            {
                if (value == null)
                    IsSubpotentElement = null;
                else
                    IsSubpotentElement = new Hl7.Fhir.Model.FhirBoolean(value);
                OnPropertyChanged("IsSubpotent");
            }
        }
        
        /// <summary>
        /// Reason for being subpotent
        /// </summary>
        [FhirElement("subpotentReason", Order=310)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> SubpotentReason
        {
            get { if(_SubpotentReason==null) _SubpotentReason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _SubpotentReason; }
            set { _SubpotentReason = value; OnPropertyChanged("SubpotentReason"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _SubpotentReason;
        
        /// <summary>
        /// Educational material presented to patient
        /// </summary>
        [FhirElement("education", Order=320)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EducationComponent> Education
        {
            get { if(_Education==null) _Education = new List<EducationComponent>(); return _Education; }
            set { _Education = value; OnPropertyChanged("Education"); }
        }
        
        private List<EducationComponent> _Education;
        
        /// <summary>
        /// Patient eligibility for a vaccination program
        /// </summary>
        [FhirElement("programEligibility", Order=330)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> ProgramEligibility
        {
            get { if(_ProgramEligibility==null) _ProgramEligibility = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ProgramEligibility; }
            set { _ProgramEligibility = value; OnPropertyChanged("ProgramEligibility"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _ProgramEligibility;
        
        /// <summary>
        /// Funding source for the vaccine
        /// </summary>
        [FhirElement("fundingSource", Order=340)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept FundingSource
        {
            get { return _FundingSource; }
            set { _FundingSource = value; OnPropertyChanged("FundingSource"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _FundingSource;
        
        /// <summary>
        /// Details of a reaction that follows immunization
        /// </summary>
        [FhirElement("reaction", Order=350)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ReactionComponent> Reaction
        {
            get { if(_Reaction==null) _Reaction = new List<ReactionComponent>(); return _Reaction; }
            set { _Reaction = value; OnPropertyChanged("Reaction"); }
        }
        
        private List<ReactionComponent> _Reaction;
        
        /// <summary>
        /// Protocol followed by the provider
        /// </summary>
        [FhirElement("protocolApplied", Order=360)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ProtocolAppliedComponent> ProtocolApplied
        {
            get { if(_ProtocolApplied==null) _ProtocolApplied = new List<ProtocolAppliedComponent>(); return _ProtocolApplied; }
            set { _ProtocolApplied = value; OnPropertyChanged("ProtocolApplied"); }
        }
        
        private List<ProtocolAppliedComponent> _ProtocolApplied;
    
    
        public static ElementDefinitionConstraint[] Immunization_Constraints =
        {
            new ElementDefinitionConstraint(
                versions: new[] {Hl7.Fhir.Model.Version.R4},
                key: "imm-1",
                severity: ConstraintSeverity.Warning,
                expression: "education.all(documentType.exists() or reference.exists())",
                human: "One of documentType or reference SHALL be present",
                xpath: "exists(f:documentType) or exists(f:reference)"
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
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.R4.ImmunizationStatusCodes>)StatusElement.DeepCopy();
                if(StatusReason != null) dest.StatusReason = (Hl7.Fhir.Model.CodeableConcept)StatusReason.DeepCopy();
                if(VaccineCode != null) dest.VaccineCode = (Hl7.Fhir.Model.CodeableConcept)VaccineCode.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                if(Occurrence != null) dest.Occurrence = (Hl7.Fhir.Model.Element)Occurrence.DeepCopy();
                if(RecordedElement != null) dest.RecordedElement = (Hl7.Fhir.Model.FhirDateTime)RecordedElement.DeepCopy();
                if(PrimarySourceElement != null) dest.PrimarySourceElement = (Hl7.Fhir.Model.FhirBoolean)PrimarySourceElement.DeepCopy();
                if(ReportOrigin != null) dest.ReportOrigin = (Hl7.Fhir.Model.CodeableConcept)ReportOrigin.DeepCopy();
                if(Location != null) dest.Location = (Hl7.Fhir.Model.ResourceReference)Location.DeepCopy();
                if(Manufacturer != null) dest.Manufacturer = (Hl7.Fhir.Model.ResourceReference)Manufacturer.DeepCopy();
                if(LotNumberElement != null) dest.LotNumberElement = (Hl7.Fhir.Model.FhirString)LotNumberElement.DeepCopy();
                if(ExpirationDateElement != null) dest.ExpirationDateElement = (Hl7.Fhir.Model.Date)ExpirationDateElement.DeepCopy();
                if(Site != null) dest.Site = (Hl7.Fhir.Model.CodeableConcept)Site.DeepCopy();
                if(Route != null) dest.Route = (Hl7.Fhir.Model.CodeableConcept)Route.DeepCopy();
                if(DoseQuantity != null) dest.DoseQuantity = (Hl7.Fhir.Model.SimpleQuantity)DoseQuantity.DeepCopy();
                if(Performer != null) dest.Performer = new List<PerformerComponent>(Performer.DeepCopy());
                if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
                if(ReasonCode != null) dest.ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(ReasonCode.DeepCopy());
                if(ReasonReference != null) dest.ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(ReasonReference.DeepCopy());
                if(IsSubpotentElement != null) dest.IsSubpotentElement = (Hl7.Fhir.Model.FhirBoolean)IsSubpotentElement.DeepCopy();
                if(SubpotentReason != null) dest.SubpotentReason = new List<Hl7.Fhir.Model.CodeableConcept>(SubpotentReason.DeepCopy());
                if(Education != null) dest.Education = new List<EducationComponent>(Education.DeepCopy());
                if(ProgramEligibility != null) dest.ProgramEligibility = new List<Hl7.Fhir.Model.CodeableConcept>(ProgramEligibility.DeepCopy());
                if(FundingSource != null) dest.FundingSource = (Hl7.Fhir.Model.CodeableConcept)FundingSource.DeepCopy();
                if(Reaction != null) dest.Reaction = new List<ReactionComponent>(Reaction.DeepCopy());
                if(ProtocolApplied != null) dest.ProtocolApplied = new List<ProtocolAppliedComponent>(ProtocolApplied.DeepCopy());
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
            if( !DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
            if( !DeepComparable.Matches(VaccineCode, otherT.VaccineCode)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
            if( !DeepComparable.Matches(RecordedElement, otherT.RecordedElement)) return false;
            if( !DeepComparable.Matches(PrimarySourceElement, otherT.PrimarySourceElement)) return false;
            if( !DeepComparable.Matches(ReportOrigin, otherT.ReportOrigin)) return false;
            if( !DeepComparable.Matches(Location, otherT.Location)) return false;
            if( !DeepComparable.Matches(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.Matches(LotNumberElement, otherT.LotNumberElement)) return false;
            if( !DeepComparable.Matches(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if( !DeepComparable.Matches(Site, otherT.Site)) return false;
            if( !DeepComparable.Matches(Route, otherT.Route)) return false;
            if( !DeepComparable.Matches(DoseQuantity, otherT.DoseQuantity)) return false;
            if( !DeepComparable.Matches(Performer, otherT.Performer)) return false;
            if( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.Matches(IsSubpotentElement, otherT.IsSubpotentElement)) return false;
            if( !DeepComparable.Matches(SubpotentReason, otherT.SubpotentReason)) return false;
            if( !DeepComparable.Matches(Education, otherT.Education)) return false;
            if( !DeepComparable.Matches(ProgramEligibility, otherT.ProgramEligibility)) return false;
            if( !DeepComparable.Matches(FundingSource, otherT.FundingSource)) return false;
            if( !DeepComparable.Matches(Reaction, otherT.Reaction)) return false;
            if( !DeepComparable.Matches(ProtocolApplied, otherT.ProtocolApplied)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Immunization;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
            if( !DeepComparable.IsExactly(VaccineCode, otherT.VaccineCode)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
            if( !DeepComparable.IsExactly(RecordedElement, otherT.RecordedElement)) return false;
            if( !DeepComparable.IsExactly(PrimarySourceElement, otherT.PrimarySourceElement)) return false;
            if( !DeepComparable.IsExactly(ReportOrigin, otherT.ReportOrigin)) return false;
            if( !DeepComparable.IsExactly(Location, otherT.Location)) return false;
            if( !DeepComparable.IsExactly(Manufacturer, otherT.Manufacturer)) return false;
            if( !DeepComparable.IsExactly(LotNumberElement, otherT.LotNumberElement)) return false;
            if( !DeepComparable.IsExactly(ExpirationDateElement, otherT.ExpirationDateElement)) return false;
            if( !DeepComparable.IsExactly(Site, otherT.Site)) return false;
            if( !DeepComparable.IsExactly(Route, otherT.Route)) return false;
            if( !DeepComparable.IsExactly(DoseQuantity, otherT.DoseQuantity)) return false;
            if( !DeepComparable.IsExactly(Performer, otherT.Performer)) return false;
            if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if( !DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
            if( !DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
            if( !DeepComparable.IsExactly(IsSubpotentElement, otherT.IsSubpotentElement)) return false;
            if( !DeepComparable.IsExactly(SubpotentReason, otherT.SubpotentReason)) return false;
            if( !DeepComparable.IsExactly(Education, otherT.Education)) return false;
            if( !DeepComparable.IsExactly(ProgramEligibility, otherT.ProgramEligibility)) return false;
            if( !DeepComparable.IsExactly(FundingSource, otherT.FundingSource)) return false;
            if( !DeepComparable.IsExactly(Reaction, otherT.Reaction)) return false;
            if( !DeepComparable.IsExactly(ProtocolApplied, otherT.ProtocolApplied)) return false;
        
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
            sink.Element("statusReason", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); StatusReason?.Serialize(sink);
            sink.Element("vaccineCode", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); VaccineCode?.Serialize(sink);
            sink.Element("patient", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, false); Patient?.Serialize(sink);
            sink.Element("encounter", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Encounter?.Serialize(sink);
            sink.Element("occurrence", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, true, true); Occurrence?.Serialize(sink);
            sink.Element("recorded", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); RecordedElement?.Serialize(sink);
            sink.Element("primarySource", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); PrimarySourceElement?.Serialize(sink);
            sink.Element("reportOrigin", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); ReportOrigin?.Serialize(sink);
            sink.Element("location", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Location?.Serialize(sink);
            sink.Element("manufacturer", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Manufacturer?.Serialize(sink);
            sink.Element("lotNumber", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); LotNumberElement?.Serialize(sink);
            sink.Element("expirationDate", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); ExpirationDateElement?.Serialize(sink);
            sink.Element("site", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Site?.Serialize(sink);
            sink.Element("route", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); Route?.Serialize(sink);
            sink.Element("doseQuantity", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); DoseQuantity?.Serialize(sink);
            sink.BeginList("performer", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false);
            foreach(var item in Performer)
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
            sink.BeginList("reasonCode", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in ReasonCode)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("reasonReference", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in ReasonReference)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("isSubpotent", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.All, false, false); IsSubpotentElement?.Serialize(sink);
            sink.BeginList("subpotentReason", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in SubpotentReason)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("education", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Education)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("programEligibility", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in ProgramEligibility)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.Element("fundingSource", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false, false); FundingSource?.Serialize(sink);
            sink.BeginList("reaction", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in Reaction)
            {
                item?.Serialize(sink);
            }
            sink.End();
            sink.BeginList("protocolApplied", Hl7.Fhir.Model.Version.All, Hl7.Fhir.Model.Version.None, false);
            foreach(var item in ProtocolApplied)
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
            StatusElement = source.GetCodeEnumProperty<Hl7.Fhir.Model.R4.ImmunizationStatusCodes>("status", Hl7.Fhir.Model.Version.All);
            StatusReason = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("statusReason", Hl7.Fhir.Model.Version.All);
            VaccineCode = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("vaccineCode", Hl7.Fhir.Model.Version.All);
            Patient = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("patient", Hl7.Fhir.Model.Version.All);
            Encounter = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("encounter", Hl7.Fhir.Model.Version.All);
            Occurrence = source.GetProperty<Hl7.Fhir.Model.Element>("occurrence", Hl7.Fhir.Model.Version.All);
            RecordedElement = source.GetDateTimeProperty("recorded", Hl7.Fhir.Model.Version.All);
            PrimarySourceElement = source.GetBooleanProperty("primarySource", Hl7.Fhir.Model.Version.All);
            ReportOrigin = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("reportOrigin", Hl7.Fhir.Model.Version.All);
            Location = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("location", Hl7.Fhir.Model.Version.All);
            Manufacturer = source.GetProperty<Hl7.Fhir.Model.ResourceReference>("manufacturer", Hl7.Fhir.Model.Version.All);
            LotNumberElement = source.GetStringProperty("lotNumber", Hl7.Fhir.Model.Version.All);
            ExpirationDateElement = source.GetDateProperty("expirationDate", Hl7.Fhir.Model.Version.All);
            Site = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("site", Hl7.Fhir.Model.Version.All);
            Route = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("route", Hl7.Fhir.Model.Version.All);
            DoseQuantity = source.GetProperty<Hl7.Fhir.Model.SimpleQuantity>("doseQuantity", Hl7.Fhir.Model.Version.All);
            Performer = source.GetList<PerformerComponent>("performer", Hl7.Fhir.Model.Version.All);
            Note = source.GetList<Hl7.Fhir.Model.Annotation>("note", Hl7.Fhir.Model.Version.All);
            ReasonCode = source.GetList<Hl7.Fhir.Model.CodeableConcept>("reasonCode", Hl7.Fhir.Model.Version.All);
            ReasonReference = source.GetList<Hl7.Fhir.Model.ResourceReference>("reasonReference", Hl7.Fhir.Model.Version.All);
            IsSubpotentElement = source.GetBooleanProperty("isSubpotent", Hl7.Fhir.Model.Version.All);
            SubpotentReason = source.GetList<Hl7.Fhir.Model.CodeableConcept>("subpotentReason", Hl7.Fhir.Model.Version.All);
            Education = source.GetList<EducationComponent>("education", Hl7.Fhir.Model.Version.All);
            ProgramEligibility = source.GetList<Hl7.Fhir.Model.CodeableConcept>("programEligibility", Hl7.Fhir.Model.Version.All);
            FundingSource = source.GetProperty<Hl7.Fhir.Model.CodeableConcept>("fundingSource", Hl7.Fhir.Model.Version.All);
            Reaction = source.GetList<ReactionComponent>("reaction", Hl7.Fhir.Model.Version.All);
            ProtocolApplied = source.GetList<ProtocolAppliedComponent>("protocolApplied", Hl7.Fhir.Model.Version.All);
        }
        
        internal override Type GetPropertyType(string fhirName)
        {
            if(PropertyTypesByFhirName.TryGetValue(fhirName, out var propertyType)) return propertyType;
            return base.GetPropertyType(fhirName);
        }
        
        private static readonly IReadOnlyDictionary<string, Type> PropertyTypesByFhirName = new Dictionary<string,Type>
        {
                {"identifier", typeof(Hl7.Fhir.Model.Identifier)},
                {"status", typeof(Hl7.Fhir.Model.Code<Hl7.Fhir.Model.R4.ImmunizationStatusCodes>)},
                {"statusReason", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"vaccineCode", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"patient", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"encounter", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"occurrence", typeof(Hl7.Fhir.Model.Element)},
                {"recorded", typeof(Hl7.Fhir.Model.FhirDateTime)},
                {"primarySource", typeof(Hl7.Fhir.Model.FhirBoolean)},
                {"reportOrigin", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"location", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"manufacturer", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"lotNumber", typeof(Hl7.Fhir.Model.FhirString)},
                {"expirationDate", typeof(Hl7.Fhir.Model.Date)},
                {"site", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"route", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"doseQuantity", typeof(Hl7.Fhir.Model.SimpleQuantity)},
                {"performer", typeof(PerformerComponent)},
                {"note", typeof(Hl7.Fhir.Model.Annotation)},
                {"reasonCode", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"reasonReference", typeof(Hl7.Fhir.Model.ResourceReference)},
                {"isSubpotent", typeof(Hl7.Fhir.Model.FhirBoolean)},
                {"subpotentReason", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"education", typeof(EducationComponent)},
                {"programEligibility", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"fundingSource", typeof(Hl7.Fhir.Model.CodeableConcept)},
                {"reaction", typeof(ReactionComponent)},
                {"protocolApplied", typeof(ProtocolAppliedComponent)},
        };
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (StatusReason != null) yield return StatusReason;
                if (VaccineCode != null) yield return VaccineCode;
                if (Patient != null) yield return Patient;
                if (Encounter != null) yield return Encounter;
                if (Occurrence != null) yield return Occurrence;
                if (RecordedElement != null) yield return RecordedElement;
                if (PrimarySourceElement != null) yield return PrimarySourceElement;
                if (ReportOrigin != null) yield return ReportOrigin;
                if (Location != null) yield return Location;
                if (Manufacturer != null) yield return Manufacturer;
                if (LotNumberElement != null) yield return LotNumberElement;
                if (ExpirationDateElement != null) yield return ExpirationDateElement;
                if (Site != null) yield return Site;
                if (Route != null) yield return Route;
                if (DoseQuantity != null) yield return DoseQuantity;
                foreach (var elem in Performer) { if (elem != null) yield return elem; }
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
                foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
                if (IsSubpotentElement != null) yield return IsSubpotentElement;
                foreach (var elem in SubpotentReason) { if (elem != null) yield return elem; }
                foreach (var elem in Education) { if (elem != null) yield return elem; }
                foreach (var elem in ProgramEligibility) { if (elem != null) yield return elem; }
                if (FundingSource != null) yield return FundingSource;
                foreach (var elem in Reaction) { if (elem != null) yield return elem; }
                foreach (var elem in ProtocolApplied) { if (elem != null) yield return elem; }
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
                if (StatusReason != null) yield return new ElementValue("statusReason", StatusReason);
                if (VaccineCode != null) yield return new ElementValue("vaccineCode", VaccineCode);
                if (Patient != null) yield return new ElementValue("patient", Patient);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
                if (RecordedElement != null) yield return new ElementValue("recorded", RecordedElement);
                if (PrimarySourceElement != null) yield return new ElementValue("primarySource", PrimarySourceElement);
                if (ReportOrigin != null) yield return new ElementValue("reportOrigin", ReportOrigin);
                if (Location != null) yield return new ElementValue("location", Location);
                if (Manufacturer != null) yield return new ElementValue("manufacturer", Manufacturer);
                if (LotNumberElement != null) yield return new ElementValue("lotNumber", LotNumberElement);
                if (ExpirationDateElement != null) yield return new ElementValue("expirationDate", ExpirationDateElement);
                if (Site != null) yield return new ElementValue("site", Site);
                if (Route != null) yield return new ElementValue("route", Route);
                if (DoseQuantity != null) yield return new ElementValue("doseQuantity", DoseQuantity);
                foreach (var elem in Performer) { if (elem != null) yield return new ElementValue("performer", elem); }
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
                foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
                foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
                if (IsSubpotentElement != null) yield return new ElementValue("isSubpotent", IsSubpotentElement);
                foreach (var elem in SubpotentReason) { if (elem != null) yield return new ElementValue("subpotentReason", elem); }
                foreach (var elem in Education) { if (elem != null) yield return new ElementValue("education", elem); }
                foreach (var elem in ProgramEligibility) { if (elem != null) yield return new ElementValue("programEligibility", elem); }
                if (FundingSource != null) yield return new ElementValue("fundingSource", FundingSource);
                foreach (var elem in Reaction) { if (elem != null) yield return new ElementValue("reaction", elem); }
                foreach (var elem in ProtocolApplied) { if (elem != null) yield return new ElementValue("protocolApplied", elem); }
            }
        }
    
    }

}
