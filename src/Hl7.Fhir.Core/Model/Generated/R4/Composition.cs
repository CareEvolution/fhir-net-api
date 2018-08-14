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
    /// A set of resources composed into a single coherent clinical statement with clinical attestation
    /// </summary>
    [FhirType(Hl7.Fhir.Model.Version.R4, "Composition", IsResource=true)]
    [DataContract]
    public partial class Composition : Hl7.Fhir.Model.R4.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Composition; } }
        [NotMapped]
        public override string TypeName { get { return "Composition"; } }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "AttesterComponent")]
        [DataContract]
        public partial class AttesterComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AttesterComponent"; } }
            
            /// <summary>
            /// personal | professional | legal | official
            /// </summary>
            [FhirElement("mode", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code ModeElement
            {
                get { return _ModeElement; }
                set { _ModeElement = value; OnPropertyChanged("ModeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _ModeElement;
            
            /// <summary>
            /// personal | professional | legal | official
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Mode");
                }
            }
            
            /// <summary>
            /// When the composition was attested
            /// </summary>
            [FhirElement("time", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.FhirDateTime TimeElement
            {
                get { return _TimeElement; }
                set { _TimeElement = value; OnPropertyChanged("TimeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.FhirDateTime _TimeElement;
            
            /// <summary>
            /// When the composition was attested
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Time
            {
                get { return TimeElement != null ? TimeElement.Value : null; }
                set
                {
                    if (value == null)
                        TimeElement = null;
                    else
                        TimeElement = new Hl7.Fhir.Model.R4.FhirDateTime(value);
                    OnPropertyChanged("Time");
                }
            }
            
            /// <summary>
            /// Who attested the composition
            /// </summary>
            [FhirElement("party", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [References("Patient","RelatedPerson","Practitioner","PractitionerRole","Organization")]
            [DataMember]
            public Hl7.Fhir.Model.R4.ResourceReference Party
            {
                get { return _Party; }
                set { _Party = value; OnPropertyChanged("Party"); }
            }
            
            private Hl7.Fhir.Model.R4.ResourceReference _Party;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AttesterComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(ModeElement != null) dest.ModeElement = (Hl7.Fhir.Model.R4.Code)ModeElement.DeepCopy();
                    if(TimeElement != null) dest.TimeElement = (Hl7.Fhir.Model.R4.FhirDateTime)TimeElement.DeepCopy();
                    if(Party != null) dest.Party = (Hl7.Fhir.Model.R4.ResourceReference)Party.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new AttesterComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AttesterComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if( !DeepComparable.Matches(TimeElement, otherT.TimeElement)) return false;
                if( !DeepComparable.Matches(Party, otherT.Party)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AttesterComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if( !DeepComparable.IsExactly(TimeElement, otherT.TimeElement)) return false;
                if( !DeepComparable.IsExactly(Party, otherT.Party)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ModeElement != null) yield return ModeElement;
                    if (TimeElement != null) yield return TimeElement;
                    if (Party != null) yield return Party;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ModeElement != null) yield return new ElementValue("mode", false, ModeElement);
                    if (TimeElement != null) yield return new ElementValue("time", false, TimeElement);
                    if (Party != null) yield return new ElementValue("party", false, Party);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "RelatesToComponent")]
        [DataContract]
        public partial class RelatesToComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RelatesToComponent"; } }
            
            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _CodeElement;
            
            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// Target of the relationship
            /// </summary>
            [FhirElement("target", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [CLSCompliant(false)]
            [AllowedTypes(typeof(Hl7.Fhir.Model.R4.Identifier),typeof(Hl7.Fhir.Model.R4.ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Element Target
            {
                get { return _Target; }
                set { _Target = value; OnPropertyChanged("Target"); }
            }
            
            private Hl7.Fhir.Model.Element _Target;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatesToComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CodeElement != null) dest.CodeElement = (Hl7.Fhir.Model.R4.Code)CodeElement.DeepCopy();
                    if(Target != null) dest.Target = (Hl7.Fhir.Model.Element)Target.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelatesToComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatesToComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.Matches(Target, otherT.Target)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatesToComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.IsExactly(Target, otherT.Target)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (Target != null) yield return Target;
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", false, CodeElement);
                    if (Target != null) yield return new ElementValue("target", false, Target);
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "EventComponent")]
        [DataContract]
        public partial class EventComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "EventComponent"; } }
            
            /// <summary>
            /// Code(s) that apply to the event being documented
            /// </summary>
            [FhirElement("code", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=40)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.CodeableConcept> Code
            {
                get { if(_Code==null) _Code = new List<Hl7.Fhir.Model.R4.CodeableConcept>(); return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private List<Hl7.Fhir.Model.R4.CodeableConcept> _Code;
            
            /// <summary>
            /// The period covered by the documentation
            /// </summary>
            [FhirElement("period", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=50)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Period Period
            {
                get { return _Period; }
                set { _Period = value; OnPropertyChanged("Period"); }
            }
            
            private Hl7.Fhir.Model.R4.Period _Period;
            
            /// <summary>
            /// The event(s) being documented
            /// </summary>
            [FhirElement("detail", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Detail
            {
                get { if(_Detail==null) _Detail = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Detail; }
                set { _Detail = value; OnPropertyChanged("Detail"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Detail;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EventComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Code != null) dest.Code = new List<Hl7.Fhir.Model.R4.CodeableConcept>(Code.DeepCopy());
                    if(Period != null) dest.Period = (Hl7.Fhir.Model.R4.Period)Period.DeepCopy();
                    if(Detail != null) dest.Detail = new List<Hl7.Fhir.Model.R4.ResourceReference>(Detail.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EventComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EventComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Period, otherT.Period)) return false;
                if( !DeepComparable.Matches(Detail, otherT.Detail)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EventComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if( !DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in Code) { if (elem != null) yield return elem; }
                    if (Period != null) yield return Period;
                    foreach (var elem in Detail) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", true, elem); }
                    if (Period != null) yield return new ElementValue("period", false, Period);
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", true, elem); }
                }
            }
        
        
        }
    
    
        [FhirType(Hl7.Fhir.Model.Version.R4, "SectionComponent")]
        [DataContract]
        public partial class SectionComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "SectionComponent"; } }
            
            /// <summary>
            /// Label for section (e.g. for ToC)
            /// </summary>
            [FhirElement("title", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TitleElement
            {
                get { return _TitleElement; }
                set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _TitleElement;
            
            /// <summary>
            /// Label for section (e.g. for ToC)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Title
            {
                get { return TitleElement != null ? TitleElement.Value : null; }
                set
                {
                    if (value == null)
                        TitleElement = null;
                    else
                        TitleElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Title");
                }
            }
            
            /// <summary>
            /// Classification of section (recommended)
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept Code
            {
                get { return _Code; }
                set { _Code = value; OnPropertyChanged("Code"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _Code;
            
            /// <summary>
            /// Who and/or what authored the section
            /// </summary>
            [FhirElement("author", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=60)]
            [CLSCompliant(false)]
            [References("Practitioner","PractitionerRole","Device","Patient","RelatedPerson","Organization")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Author
            {
                get { if(_Author==null) _Author = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Author; }
                set { _Author = value; OnPropertyChanged("Author"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Author;
            
            /// <summary>
            /// Text summary of the section, for human interpretation
            /// </summary>
            [FhirElement("text", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Narrative Text
            {
                get { return _Text; }
                set { _Text = value; OnPropertyChanged("Text"); }
            }
            
            private Hl7.Fhir.Model.R4.Narrative _Text;
            
            /// <summary>
            /// working | snapshot | changes
            /// </summary>
            [FhirElement("mode", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=80)]
            [CLSCompliant(false)]
            [DataMember]
            public Hl7.Fhir.Model.R4.Code ModeElement
            {
                get { return _ModeElement; }
                set { _ModeElement = value; OnPropertyChanged("ModeElement"); }
            }
            
            private Hl7.Fhir.Model.R4.Code _ModeElement;
            
            /// <summary>
            /// working | snapshot | changes
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Hl7.Fhir.Model.R4.Code(value);
                    OnPropertyChanged("Mode");
                }
            }
            
            /// <summary>
            /// Order of section entries
            /// </summary>
            [FhirElement("orderedBy", Order=90)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept OrderedBy
            {
                get { return _OrderedBy; }
                set { _OrderedBy = value; OnPropertyChanged("OrderedBy"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _OrderedBy;
            
            /// <summary>
            /// A reference to data that supports this section
            /// </summary>
            [FhirElement("entry", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.R4.ResourceReference> Entry
            {
                get { if(_Entry==null) _Entry = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Entry; }
                set { _Entry = value; OnPropertyChanged("Entry"); }
            }
            
            private List<Hl7.Fhir.Model.R4.ResourceReference> _Entry;
            
            /// <summary>
            /// Why the section is empty
            /// </summary>
            [FhirElement("emptyReason", Order=110)]
            [DataMember]
            public Hl7.Fhir.Model.R4.CodeableConcept EmptyReason
            {
                get { return _EmptyReason; }
                set { _EmptyReason = value; OnPropertyChanged("EmptyReason"); }
            }
            
            private Hl7.Fhir.Model.R4.CodeableConcept _EmptyReason;
            
            /// <summary>
            /// Nested Section
            /// </summary>
            [FhirElement("section", Order=120)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SectionComponent> Section
            {
                get { if(_Section==null) _Section = new List<SectionComponent>(); return _Section; }
                set { _Section = value; OnPropertyChanged("Section"); }
            }
            
            private List<SectionComponent> _Section;
        
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SectionComponent;
            
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                    if(Code != null) dest.Code = (Hl7.Fhir.Model.R4.CodeableConcept)Code.DeepCopy();
                    if(Author != null) dest.Author = new List<Hl7.Fhir.Model.R4.ResourceReference>(Author.DeepCopy());
                    if(Text != null) dest.Text = (Hl7.Fhir.Model.R4.Narrative)Text.DeepCopy();
                    if(ModeElement != null) dest.ModeElement = (Hl7.Fhir.Model.R4.Code)ModeElement.DeepCopy();
                    if(OrderedBy != null) dest.OrderedBy = (Hl7.Fhir.Model.R4.CodeableConcept)OrderedBy.DeepCopy();
                    if(Entry != null) dest.Entry = new List<Hl7.Fhir.Model.R4.ResourceReference>(Entry.DeepCopy());
                    if(EmptyReason != null) dest.EmptyReason = (Hl7.Fhir.Model.R4.CodeableConcept)EmptyReason.DeepCopy();
                    if(Section != null) dest.Section = new List<SectionComponent>(Section.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SectionComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SectionComponent;
                if(otherT == null) return false;
            
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if( !DeepComparable.Matches(Author, otherT.Author)) return false;
                if( !DeepComparable.Matches(Text, otherT.Text)) return false;
                if( !DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if( !DeepComparable.Matches(OrderedBy, otherT.OrderedBy)) return false;
                if( !DeepComparable.Matches(Entry, otherT.Entry)) return false;
                if( !DeepComparable.Matches(EmptyReason, otherT.EmptyReason)) return false;
                if( !DeepComparable.Matches(Section, otherT.Section)) return false;
            
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SectionComponent;
                if(otherT == null) return false;
            
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if( !DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if( !DeepComparable.IsExactly(Author, otherT.Author)) return false;
                if( !DeepComparable.IsExactly(Text, otherT.Text)) return false;
                if( !DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if( !DeepComparable.IsExactly(OrderedBy, otherT.OrderedBy)) return false;
                if( !DeepComparable.IsExactly(Entry, otherT.Entry)) return false;
                if( !DeepComparable.IsExactly(EmptyReason, otherT.EmptyReason)) return false;
                if( !DeepComparable.IsExactly(Section, otherT.Section)) return false;
            
                return true;
            }
        
        
            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TitleElement != null) yield return TitleElement;
                    if (Code != null) yield return Code;
                    foreach (var elem in Author) { if (elem != null) yield return elem; }
                    if (Text != null) yield return Text;
                    if (ModeElement != null) yield return ModeElement;
                    if (OrderedBy != null) yield return OrderedBy;
                    foreach (var elem in Entry) { if (elem != null) yield return elem; }
                    if (EmptyReason != null) yield return EmptyReason;
                    foreach (var elem in Section) { if (elem != null) yield return elem; }
                }
            }
            
            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TitleElement != null) yield return new ElementValue("title", false, TitleElement);
                    if (Code != null) yield return new ElementValue("code", false, Code);
                    foreach (var elem in Author) { if (elem != null) yield return new ElementValue("author", true, elem); }
                    if (Text != null) yield return new ElementValue("text", false, Text);
                    if (ModeElement != null) yield return new ElementValue("mode", false, ModeElement);
                    if (OrderedBy != null) yield return new ElementValue("orderedBy", false, OrderedBy);
                    foreach (var elem in Entry) { if (elem != null) yield return new ElementValue("entry", true, elem); }
                    if (EmptyReason != null) yield return new ElementValue("emptyReason", false, EmptyReason);
                    foreach (var elem in Section) { if (elem != null) yield return new ElementValue("section", true, elem); }
                }
            }
        
        
        }
    
        
        /// <summary>
        /// Version-independent identifier for the Composition
        /// </summary>
        [FhirElement("identifier", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=90)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Identifier Identifier
        {
            get { return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private Hl7.Fhir.Model.R4.Identifier _Identifier;
        
        /// <summary>
        /// preliminary | final | amended | entered-in-error
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
        /// preliminary | final | amended | entered-in-error
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
        /// Kind of composition (LOINC if possible)
        /// </summary>
        [FhirElement("type", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=110)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Type;
        
        /// <summary>
        /// Categorization of Composition
        /// </summary>
        [FhirElement("class", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=120)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.CodeableConcept Class
        {
            get { return _Class; }
            set { _Class = value; OnPropertyChanged("Class"); }
        }
        
        private Hl7.Fhir.Model.R4.CodeableConcept _Class;
        
        /// <summary>
        /// Who and/or what the composition is about
        /// </summary>
        [FhirElement("subject", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=130)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Subject;
        
        /// <summary>
        /// Context of the Composition
        /// </summary>
        [FhirElement("encounter", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=140)]
        [CLSCompliant(false)]
        [References("Encounter")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Encounter
        {
            get { return _Encounter; }
            set { _Encounter = value; OnPropertyChanged("Encounter"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Encounter;
        
        /// <summary>
        /// Composition editing time
        /// </summary>
        [FhirElement("date", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=150)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.R4.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.R4.FhirDateTime _DateElement;
        
        /// <summary>
        /// Composition editing time
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
        /// Who and/or what authored the composition
        /// </summary>
        [FhirElement("author", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=160)]
        [CLSCompliant(false)]
        [References("Practitioner","PractitionerRole","Device","Patient","RelatedPerson","Organization")]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.R4.ResourceReference> Author
        {
            get { if(_Author==null) _Author = new List<Hl7.Fhir.Model.R4.ResourceReference>(); return _Author; }
            set { _Author = value; OnPropertyChanged("Author"); }
        }
        
        private List<Hl7.Fhir.Model.R4.ResourceReference> _Author;
        
        /// <summary>
        /// Human Readable name/title
        /// </summary>
        [FhirElement("title", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=170)]
        [CLSCompliant(false)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString TitleElement
        {
            get { return _TitleElement; }
            set { _TitleElement = value; OnPropertyChanged("TitleElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _TitleElement;
        
        /// <summary>
        /// Human Readable name/title
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                    TitleElement = null;
                else
                    TitleElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Title");
            }
        }
        
        /// <summary>
        /// As defined by affinity domain
        /// </summary>
        [FhirElement("confidentiality", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=180)]
        [CLSCompliant(false)]
        [DataMember]
        public Hl7.Fhir.Model.R4.Code ConfidentialityElement
        {
            get { return _ConfidentialityElement; }
            set { _ConfidentialityElement = value; OnPropertyChanged("ConfidentialityElement"); }
        }
        
        private Hl7.Fhir.Model.R4.Code _ConfidentialityElement;
        
        /// <summary>
        /// As defined by affinity domain
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Confidentiality
        {
            get { return ConfidentialityElement != null ? ConfidentialityElement.Value : null; }
            set
            {
                if (value == null)
                    ConfidentialityElement = null;
                else
                    ConfidentialityElement = new Hl7.Fhir.Model.R4.Code(value);
                OnPropertyChanged("Confidentiality");
            }
        }
        
        /// <summary>
        /// Attests to accuracy of composition
        /// </summary>
        [FhirElement("attester", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=190)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AttesterComponent> Attester
        {
            get { if(_Attester==null) _Attester = new List<AttesterComponent>(); return _Attester; }
            set { _Attester = value; OnPropertyChanged("Attester"); }
        }
        
        private List<AttesterComponent> _Attester;
        
        /// <summary>
        /// Organization which maintains the composition
        /// </summary>
        [FhirElement("custodian", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=200)]
        [CLSCompliant(false)]
        [References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.R4.ResourceReference Custodian
        {
            get { return _Custodian; }
            set { _Custodian = value; OnPropertyChanged("Custodian"); }
        }
        
        private Hl7.Fhir.Model.R4.ResourceReference _Custodian;
        
        /// <summary>
        /// Relationships to other compositions/documents
        /// </summary>
        [FhirElement("relatesTo", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=210)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatesToComponent> RelatesTo
        {
            get { if(_RelatesTo==null) _RelatesTo = new List<RelatesToComponent>(); return _RelatesTo; }
            set { _RelatesTo = value; OnPropertyChanged("RelatesTo"); }
        }
        
        private List<RelatesToComponent> _RelatesTo;
        
        /// <summary>
        /// The clinical service(s) being documented
        /// </summary>
        [FhirElement("event", InSummary=new[]{Hl7.Fhir.Model.Version.All}, Order=220)]
        [CLSCompliant(false)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EventComponent> Event
        {
            get { if(_Event==null) _Event = new List<EventComponent>(); return _Event; }
            set { _Event = value; OnPropertyChanged("Event"); }
        }
        
        private List<EventComponent> _Event;
        
        /// <summary>
        /// Composition is broken into sections
        /// </summary>
        [FhirElement("section", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SectionComponent> Section
        {
            get { if(_Section==null) _Section = new List<SectionComponent>(); return _Section; }
            set { _Section = value; OnPropertyChanged("Section"); }
        }
        
        private List<SectionComponent> _Section;
    
    
        public static ElementDefinitionConstraint Composition_CMP_1 = new ElementDefinitionConstraint
        {
            Expression = "section.all(text.exists() or entry.exists() or section.exists())",
            Key = "cmp-1",
            Severity = ConstraintSeverity.Warning,
            Human = "A section must contain at least one of text, entries, or sub-sections",
            Xpath = "exists(f:text) or exists(f:entry) or exists(f:section)"
        };
    
        public static ElementDefinitionConstraint Composition_CMP_2 = new ElementDefinitionConstraint
        {
            Expression = "section.all(emptyReason.empty() or entry.empty())",
            Key = "cmp-2",
            Severity = ConstraintSeverity.Warning,
            Human = "A section can only have an emptyReason if it is empty",
            Xpath = "not(exists(f:emptyReason) and exists(f:entry))"
        };
    
        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();
    
            InvariantConstraints.Add(Composition_CMP_1);
            InvariantConstraints.Add(Composition_CMP_2);
        }
    
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Composition;
        
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.R4.Identifier)Identifier.DeepCopy();
                if(StatusElement != null) dest.StatusElement = (Hl7.Fhir.Model.R4.Code)StatusElement.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.R4.CodeableConcept)Type.DeepCopy();
                if(Class != null) dest.Class = (Hl7.Fhir.Model.R4.CodeableConcept)Class.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.R4.ResourceReference)Subject.DeepCopy();
                if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.R4.ResourceReference)Encounter.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.R4.FhirDateTime)DateElement.DeepCopy();
                if(Author != null) dest.Author = new List<Hl7.Fhir.Model.R4.ResourceReference>(Author.DeepCopy());
                if(TitleElement != null) dest.TitleElement = (Hl7.Fhir.Model.FhirString)TitleElement.DeepCopy();
                if(ConfidentialityElement != null) dest.ConfidentialityElement = (Hl7.Fhir.Model.R4.Code)ConfidentialityElement.DeepCopy();
                if(Attester != null) dest.Attester = new List<AttesterComponent>(Attester.DeepCopy());
                if(Custodian != null) dest.Custodian = (Hl7.Fhir.Model.R4.ResourceReference)Custodian.DeepCopy();
                if(RelatesTo != null) dest.RelatesTo = new List<RelatesToComponent>(RelatesTo.DeepCopy());
                if(Event != null) dest.Event = new List<EventComponent>(Event.DeepCopy());
                if(Section != null) dest.Section = new List<SectionComponent>(Section.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new Composition());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Composition;
            if(otherT == null) return false;
        
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(Class, otherT.Class)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Author, otherT.Author)) return false;
            if( !DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.Matches(ConfidentialityElement, otherT.ConfidentialityElement)) return false;
            if( !DeepComparable.Matches(Attester, otherT.Attester)) return false;
            if( !DeepComparable.Matches(Custodian, otherT.Custodian)) return false;
            if( !DeepComparable.Matches(RelatesTo, otherT.RelatesTo)) return false;
            if( !DeepComparable.Matches(Event, otherT.Event)) return false;
            if( !DeepComparable.Matches(Section, otherT.Section)) return false;
        
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Composition;
            if(otherT == null) return false;
        
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(Class, otherT.Class)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if( !DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if( !DeepComparable.IsExactly(ConfidentialityElement, otherT.ConfidentialityElement)) return false;
            if( !DeepComparable.IsExactly(Attester, otherT.Attester)) return false;
            if( !DeepComparable.IsExactly(Custodian, otherT.Custodian)) return false;
            if( !DeepComparable.IsExactly(RelatesTo, otherT.RelatesTo)) return false;
            if( !DeepComparable.IsExactly(Event, otherT.Event)) return false;
            if( !DeepComparable.IsExactly(Section, otherT.Section)) return false;
        
            return true;
        }
    
        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (Identifier != null) yield return Identifier;
                if (StatusElement != null) yield return StatusElement;
                if (Type != null) yield return Type;
                if (Class != null) yield return Class;
                if (Subject != null) yield return Subject;
                if (Encounter != null) yield return Encounter;
                if (DateElement != null) yield return DateElement;
                foreach (var elem in Author) { if (elem != null) yield return elem; }
                if (TitleElement != null) yield return TitleElement;
                if (ConfidentialityElement != null) yield return ConfidentialityElement;
                foreach (var elem in Attester) { if (elem != null) yield return elem; }
                if (Custodian != null) yield return Custodian;
                foreach (var elem in RelatesTo) { if (elem != null) yield return elem; }
                foreach (var elem in Event) { if (elem != null) yield return elem; }
                foreach (var elem in Section) { if (elem != null) yield return elem; }
            }
        }
        
        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (Type != null) yield return new ElementValue("type", false, Type);
                if (Class != null) yield return new ElementValue("class", false, Class);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (Encounter != null) yield return new ElementValue("encounter", false, Encounter);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                foreach (var elem in Author) { if (elem != null) yield return new ElementValue("author", true, elem); }
                if (TitleElement != null) yield return new ElementValue("title", false, TitleElement);
                if (ConfidentialityElement != null) yield return new ElementValue("confidentiality", false, ConfidentialityElement);
                foreach (var elem in Attester) { if (elem != null) yield return new ElementValue("attester", true, elem); }
                if (Custodian != null) yield return new ElementValue("custodian", false, Custodian);
                foreach (var elem in RelatesTo) { if (elem != null) yield return new ElementValue("relatesTo", true, elem); }
                foreach (var elem in Event) { if (elem != null) yield return new ElementValue("event", true, elem); }
                foreach (var elem in Section) { if (elem != null) yield return new ElementValue("section", true, elem); }
            }
        }
    
    }

}
