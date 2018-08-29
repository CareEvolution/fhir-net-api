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
    /// A set of resources composed into a single coherent clinical statement with clinical attestation
    /// </summary>
    [FhirType("Composition", IsResource=true)]
    [DataContract]
    public partial class Composition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.Composition; } }
        [NotMapped]
        public override string TypeName { get { return "Composition"; } }


        [FhirType("AttesterComponent")]
        [DataContract]
        public partial class AttesterComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "AttesterComponent"; } }

            /// <summary>
            /// personal | professional | legal | official
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<Code<CompositionAttestationMode>> ModeElement
            {
                get { if (_modeElement==null) _modeElement = new List<Code<CompositionAttestationMode>>(); return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private List<Code<CompositionAttestationMode>> _modeElement;

            /// <summary>
            /// personal | professional | legal | official
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public IEnumerable<CompositionAttestationMode?> Mode
            {
                get { return ModeElement != null ? ModeElement.Select(elem => elem.Value) : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new List<Code<CompositionAttestationMode>>(value.Select(elem=>new Code<CompositionAttestationMode>(elem)));
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// When the composition was attested
            /// </summary>
            [FhirElement("time", InSummary=true, Order=50)]
            [DataMember]
            public FhirDateTime TimeElement
            {
                get { return _timeElement; }
                set { _timeElement = value; OnPropertyChanged("TimeElement"); }
            }

            private FhirDateTime _timeElement;

            /// <summary>
            /// When the composition was attested
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Time
            {
                get { return TimeElement != null ? TimeElement.Value : null; }
                set
                {
                    if (value == null)
                        TimeElement = null;
                    else
                        TimeElement = new FhirDateTime(value);
                    OnPropertyChanged("Time");
                }
            }

            /// <summary>
            /// Who attested the composition
            /// </summary>
            [FhirElement("party", InSummary=true, Order=60)]
            [References("Patient","Practitioner","Organization")]
            [DataMember]
            public ResourceReference Party
            {
                get { return _party; }
                set { _party = value; OnPropertyChanged("Party"); }
            }

            private ResourceReference _party;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AttesterComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ModeElement != null) dest.ModeElement = new List<Code<CompositionAttestationMode>>(ModeElement.DeepCopy());
                    if (TimeElement != null) dest.TimeElement = (FhirDateTime)TimeElement.DeepCopy();
                    if (Party != null) dest.Party = (ResourceReference)Party.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(TimeElement, otherT.TimeElement)) return false;
                if (!DeepComparable.Matches(Party, otherT.Party)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AttesterComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(TimeElement, otherT.TimeElement)) return false;
                if (!DeepComparable.IsExactly(Party, otherT.Party)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    foreach (var elem in ModeElement) { if (elem != null) yield return elem; }
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
                    foreach (var elem in ModeElement) { if (elem != null) yield return new ElementValue("mode", elem); }
                    if (TimeElement != null) yield return new ElementValue("time", TimeElement);
                    if (Party != null) yield return new ElementValue("party", Party);
                }
            }


        }


        [FhirType("RelatesToComponent")]
        [DataContract]
        public partial class RelatesToComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelatesToComponent"; } }

            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<DocumentRelationshipType> CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code<DocumentRelationshipType> _codeElement;

            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public DocumentRelationshipType? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code<DocumentRelationshipType>(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Target of the relationship
            /// </summary>
            [FhirElement("target", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Identifier),typeof(ResourceReference))]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Element Target
            {
                get { return _target; }
                set { _target = value; OnPropertyChanged("Target"); }
            }

            private Element _target;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatesToComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeElement != null) dest.CodeElement = (Code<DocumentRelationshipType>)CodeElement.DeepCopy();
                    if (Target != null) dest.Target = (Element)Target.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(Target, otherT.Target)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatesToComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;

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
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (Target != null) yield return new ElementValue("target", Target);
                }
            }


        }


        [FhirType("EventComponent")]
        [DataContract]
        public partial class EventComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EventComponent"; } }

            /// <summary>
            /// Code(s) that apply to the event being documented
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Code
            {
                get { if (_code==null) _code = new List<CodeableConcept>(); return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private List<CodeableConcept> _code;

            /// <summary>
            /// The period covered by the documentation
            /// </summary>
            [FhirElement("period", InSummary=true, Order=50)]
            [DataMember]
            public Period Period
            {
                get { return _period; }
                set { _period = value; OnPropertyChanged("Period"); }
            }

            private Period _period;

            /// <summary>
            /// The event(s) being documented
            /// </summary>
            [FhirElement("detail", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Detail
            {
                get { if (_detail==null) _detail = new List<ResourceReference>(); return _detail; }
                set { _detail = value; OnPropertyChanged("Detail"); }
            }

            private List<ResourceReference> _detail;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EventComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Code != null) dest.Code = new List<CodeableConcept>(Code.DeepCopy());
                    if (Period != null) dest.Period = (Period)Period.DeepCopy();
                    if (Detail != null) dest.Detail = new List<ResourceReference>(Detail.DeepCopy());
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if ( !DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Period, otherT.Period)) return false;
                if ( !DeepComparable.Matches(Detail, otherT.Detail)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EventComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if (!DeepComparable.IsExactly(Detail, otherT.Detail)) return false;

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
                    foreach (var elem in Code) { if (elem != null) yield return new ElementValue("code", elem); }
                    if (Period != null) yield return new ElementValue("period", Period);
                    foreach (var elem in Detail) { if (elem != null) yield return new ElementValue("detail", elem); }
                }
            }


        }


        [FhirType("SectionComponent")]
        [DataContract]
        public partial class SectionComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SectionComponent"; } }

            /// <summary>
            /// Label for section (e.g. for ToC)
            /// </summary>
            [FhirElement("title", Order=40)]
            [DataMember]
            public FhirString TitleElement
            {
                get { return _titleElement; }
                set { _titleElement = value; OnPropertyChanged("TitleElement"); }
            }

            private FhirString _titleElement;

            /// <summary>
            /// Label for section (e.g. for ToC)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Title
            {
                get { return TitleElement != null ? TitleElement.Value : null; }
                set
                {
                    if (value == null)
                        TitleElement = null;
                    else
                        TitleElement = new FhirString(value);
                    OnPropertyChanged("Title");
                }
            }

            /// <summary>
            /// Classification of section (recommended)
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public CodeableConcept Code
            {
                get { return _code; }
                set { _code = value; OnPropertyChanged("Code"); }
            }

            private CodeableConcept _code;

            /// <summary>
            /// Text summary of the section, for human interpretation
            /// </summary>
            [FhirElement("text", Order=60)]
            [DataMember]
            public Narrative Text
            {
                get { return _text; }
                set { _text = value; OnPropertyChanged("Text"); }
            }

            private Narrative _text;

            /// <summary>
            /// working | snapshot | changes
            /// </summary>
            [FhirElement("mode", InSummary=true, Order=70)]
            [DataMember]
            public Code<ListMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<ListMode> _modeElement;

            /// <summary>
            /// working | snapshot | changes
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ListMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<ListMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// Order of section entries
            /// </summary>
            [FhirElement("orderedBy", Order=80)]
            [DataMember]
            public CodeableConcept OrderedBy
            {
                get { return _orderedBy; }
                set { _orderedBy = value; OnPropertyChanged("OrderedBy"); }
            }

            private CodeableConcept _orderedBy;

            /// <summary>
            /// A reference to data that supports this section
            /// </summary>
            [FhirElement("entry", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Entry
            {
                get { if (_entry==null) _entry = new List<ResourceReference>(); return _entry; }
                set { _entry = value; OnPropertyChanged("Entry"); }
            }

            private List<ResourceReference> _entry;

            /// <summary>
            /// Why the section is empty
            /// </summary>
            [FhirElement("emptyReason", Order=100)]
            [DataMember]
            public CodeableConcept EmptyReason
            {
                get { return _emptyReason; }
                set { _emptyReason = value; OnPropertyChanged("EmptyReason"); }
            }

            private CodeableConcept _emptyReason;

            /// <summary>
            /// Nested Section
            /// </summary>
            [FhirElement("section", Order=110)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<SectionComponent> Section
            {
                get { if (_section==null) _section = new List<SectionComponent>(); return _section; }
                set { _section = value; OnPropertyChanged("Section"); }
            }

            private List<SectionComponent> _section;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SectionComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                    if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                    if (Text != null) dest.Text = (Narrative)Text.DeepCopy();
                    if (ModeElement != null) dest.ModeElement = (Code<ListMode>)ModeElement.DeepCopy();
                    if (OrderedBy != null) dest.OrderedBy = (CodeableConcept)OrderedBy.DeepCopy();
                    if (Entry != null) dest.Entry = new List<ResourceReference>(Entry.DeepCopy());
                    if (EmptyReason != null) dest.EmptyReason = (CodeableConcept)EmptyReason.DeepCopy();
                    if (Section != null) dest.Section = new List<SectionComponent>(Section.DeepCopy());
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.Matches(Code, otherT.Code)) return false;
                if (!DeepComparable.Matches(Text, otherT.Text)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(OrderedBy, otherT.OrderedBy)) return false;
                if ( !DeepComparable.Matches(Entry, otherT.Entry)) return false;
                if (!DeepComparable.Matches(EmptyReason, otherT.EmptyReason)) return false;
                if ( !DeepComparable.Matches(Section, otherT.Section)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SectionComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
                if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
                if (!DeepComparable.IsExactly(Text, otherT.Text)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(OrderedBy, otherT.OrderedBy)) return false;
                if (!DeepComparable.IsExactly(Entry, otherT.Entry)) return false;
                if (!DeepComparable.IsExactly(EmptyReason, otherT.EmptyReason)) return false;
                if (!DeepComparable.IsExactly(Section, otherT.Section)) return false;

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
                    if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                    if (Code != null) yield return new ElementValue("code", Code);
                    if (Text != null) yield return new ElementValue("text", Text);
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                    if (OrderedBy != null) yield return new ElementValue("orderedBy", OrderedBy);
                    foreach (var elem in Entry) { if (elem != null) yield return new ElementValue("entry", elem); }
                    if (EmptyReason != null) yield return new ElementValue("emptyReason", EmptyReason);
                    foreach (var elem in Section) { if (elem != null) yield return new ElementValue("section", elem); }
                }
            }


        }


        /// <summary>
        /// Logical identifier of composition (version-independent)
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=90)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// preliminary | final | amended | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<CompositionStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<CompositionStatus> _statusElement;

        /// <summary>
        /// preliminary | final | amended | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public CompositionStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<CompositionStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Kind of composition (LOINC if possible)
        /// </summary>
        [FhirElement("type", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Categorization of Composition
        /// </summary>
        [FhirElement("class", InSummary=true, Order=120)]
        [DataMember]
        public CodeableConcept Class
        {
            get { return _class; }
            set { _class = value; OnPropertyChanged("Class"); }
        }

        private CodeableConcept _class;

        /// <summary>
        /// Who and/or what the composition is about
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Context of the Composition
        /// </summary>
        [FhirElement("encounter", InSummary=true, Order=140)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// Composition editing time
        /// </summary>
        [FhirElement("date", InSummary=true, Order=150)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Composition editing time
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
        /// Who and/or what authored the composition
        /// </summary>
        [FhirElement("author", InSummary=true, Order=160)]
        [References("Practitioner","Device","Patient","RelatedPerson")]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<ResourceReference> Author
        {
            get { if (_author==null) _author = new List<ResourceReference>(); return _author; }
            set { _author = value; OnPropertyChanged("Author"); }
        }

        private List<ResourceReference> _author;

        /// <summary>
        /// Human Readable name/title
        /// </summary>
        [FhirElement("title", InSummary=true, Order=170)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Human Readable name/title
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Title
        {
            get { return TitleElement != null ? TitleElement.Value : null; }
            set
            {
                if (value == null)
                    TitleElement = null;
                else
                    TitleElement = new FhirString(value);
                OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// As defined by affinity domain
        /// </summary>
        [FhirElement("confidentiality", InSummary=true, Order=180)]
        [DataMember]
        public Code<ConfidentialityClassification> ConfidentialityElement
        {
            get { return _confidentialityElement; }
            set { _confidentialityElement = value; OnPropertyChanged("ConfidentialityElement"); }
        }

        private Code<ConfidentialityClassification> _confidentialityElement;

        /// <summary>
        /// As defined by affinity domain
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConfidentialityClassification? Confidentiality
        {
            get { return ConfidentialityElement != null ? ConfidentialityElement.Value : null; }
            set
            {
                if (value == null)
                    ConfidentialityElement = null;
                else
                    ConfidentialityElement = new Code<ConfidentialityClassification>(value);
                OnPropertyChanged("Confidentiality");
            }
        }

        /// <summary>
        /// Attests to accuracy of composition
        /// </summary>
        [FhirElement("attester", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<AttesterComponent> Attester
        {
            get { if (_attester==null) _attester = new List<AttesterComponent>(); return _attester; }
            set { _attester = value; OnPropertyChanged("Attester"); }
        }

        private List<AttesterComponent> _attester;

        /// <summary>
        /// Organization which maintains the composition
        /// </summary>
        [FhirElement("custodian", InSummary=true, Order=200)]
        [References("Organization")]
        [DataMember]
        public ResourceReference Custodian
        {
            get { return _custodian; }
            set { _custodian = value; OnPropertyChanged("Custodian"); }
        }

        private ResourceReference _custodian;

        /// <summary>
        /// Relationships to other compositions/documents
        /// </summary>
        [FhirElement("relatesTo", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatesToComponent> RelatesTo
        {
            get { if (_relatesTo==null) _relatesTo = new List<RelatesToComponent>(); return _relatesTo; }
            set { _relatesTo = value; OnPropertyChanged("RelatesTo"); }
        }

        private List<RelatesToComponent> _relatesTo;

        /// <summary>
        /// The clinical service(s) being documented
        /// </summary>
        [FhirElement("event", InSummary=true, Order=220)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EventComponent> Event
        {
            get { if (_event==null) _event = new List<EventComponent>(); return _event; }
            set { _event = value; OnPropertyChanged("Event"); }
        }

        private List<EventComponent> _event;

        /// <summary>
        /// Composition is broken into sections
        /// </summary>
        [FhirElement("section", Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SectionComponent> Section
        {
            get { if (_section==null) _section = new List<SectionComponent>(); return _section; }
            set { _section = value; OnPropertyChanged("Section"); }
        }

        private List<SectionComponent> _section;


        public static ElementDefinition.ConstraintComponent Composition_CMP_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "section.all(text.exists() or entry.exists() or section.exists())",
            Key = "cmp-1",
            Severity = ConstraintSeverity.Warning,
            Human = "A section must at least one of text, entries, or sub-sections",
            Xpath = "exists(f:text) or exists(f:entry) or exists(f:section)"
        };

        public static ElementDefinition.ConstraintComponent Composition_CMP_2 = new ElementDefinition.ConstraintComponent
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
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<CompositionStatus>)StatusElement.DeepCopy();
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (Class != null) dest.Class = (CodeableConcept)Class.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Author != null) dest.Author = new List<ResourceReference>(Author.DeepCopy());
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (ConfidentialityElement != null) dest.ConfidentialityElement = (Code<ConfidentialityClassification>)ConfidentialityElement.DeepCopy();
                if (Attester != null) dest.Attester = new List<AttesterComponent>(Attester.DeepCopy());
                if (Custodian != null) dest.Custodian = (ResourceReference)Custodian.DeepCopy();
                if (RelatesTo != null) dest.RelatesTo = new List<RelatesToComponent>(RelatesTo.DeepCopy());
                if (Event != null) dest.Event = new List<EventComponent>(Event.DeepCopy());
                if (Section != null) dest.Section = new List<SectionComponent>(Section.DeepCopy());
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
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(Class, otherT.Class)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if ( !DeepComparable.Matches(Author, otherT.Author)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(ConfidentialityElement, otherT.ConfidentialityElement)) return false;
            if ( !DeepComparable.Matches(Attester, otherT.Attester)) return false;
            if (!DeepComparable.Matches(Custodian, otherT.Custodian)) return false;
            if ( !DeepComparable.Matches(RelatesTo, otherT.RelatesTo)) return false;
            if ( !DeepComparable.Matches(Event, otherT.Event)) return false;
            if ( !DeepComparable.Matches(Section, otherT.Section)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Composition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(Class, otherT.Class)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Author, otherT.Author)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(ConfidentialityElement, otherT.ConfidentialityElement)) return false;
            if (!DeepComparable.IsExactly(Attester, otherT.Attester)) return false;
            if (!DeepComparable.IsExactly(Custodian, otherT.Custodian)) return false;
            if (!DeepComparable.IsExactly(RelatesTo, otherT.RelatesTo)) return false;
            if (!DeepComparable.IsExactly(Event, otherT.Event)) return false;
            if (!DeepComparable.IsExactly(Section, otherT.Section)) return false;

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
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (Type != null) yield return new ElementValue("type", Type);
                if (Class != null) yield return new ElementValue("class", Class);
                if (Subject != null) yield return new ElementValue("subject", Subject);
                if (Encounter != null) yield return new ElementValue("encounter", Encounter);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                foreach (var elem in Author) { if (elem != null) yield return new ElementValue("author", elem); }
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (ConfidentialityElement != null) yield return new ElementValue("confidentiality", ConfidentialityElement);
                foreach (var elem in Attester) { if (elem != null) yield return new ElementValue("attester", elem); }
                if (Custodian != null) yield return new ElementValue("custodian", Custodian);
                foreach (var elem in RelatesTo) { if (elem != null) yield return new ElementValue("relatesTo", elem); }
                foreach (var elem in Event) { if (elem != null) yield return new ElementValue("event", elem); }
                foreach (var elem in Section) { if (elem != null) yield return new ElementValue("section", elem); }
            }
        }

    }

}
