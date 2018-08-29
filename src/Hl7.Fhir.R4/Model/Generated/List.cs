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
    /// Information summarized from a list of other resources
    /// </summary>
    [FhirType("List", IsResource=true)]
    [DataContract]
    public partial class List : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.List; } }
        [NotMapped]
        public override string TypeName { get { return "List"; } }


        [FhirType("EntryComponent")]
        [DataContract]
        public partial class EntryComponent : BackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "EntryComponent"; } }

            /// <summary>
            /// Status/Workflow information about this item
            /// </summary>
            [FhirElement("flag", Order=40)]
            [DataMember]
            public CodeableConcept Flag
            {
                get { return _flag; }
                set { _flag = value; OnPropertyChanged("Flag"); }
            }

            private CodeableConcept _flag;

            /// <summary>
            /// If this item is actually marked as deleted
            /// </summary>
            [FhirElement("deleted", Order=50)]
            [DataMember]
            public FhirBoolean DeletedElement
            {
                get { return _deletedElement; }
                set { _deletedElement = value; OnPropertyChanged("DeletedElement"); }
            }

            private FhirBoolean _deletedElement;

            /// <summary>
            /// If this item is actually marked as deleted
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? Deleted
            {
                get { return DeletedElement != null ? DeletedElement.Value : null; }
                set
                {
                    if (value == null)
                        DeletedElement = null;
                    else
                        DeletedElement = new FhirBoolean(value);
                    OnPropertyChanged("Deleted");
                }
            }

            /// <summary>
            /// When item added to list
            /// </summary>
            [FhirElement("date", Order=60)]
            [DataMember]
            public FhirDateTime DateElement
            {
                get { return _dateElement; }
                set { _dateElement = value; OnPropertyChanged("DateElement"); }
            }

            private FhirDateTime _dateElement;

            /// <summary>
            /// When item added to list
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
            /// Actual entry
            /// </summary>
            [FhirElement("item", Order=70)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public ResourceReference Item
            {
                get { return _item; }
                set { _item = value; OnPropertyChanged("Item"); }
            }

            private ResourceReference _item;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as EntryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Flag != null) dest.Flag = (CodeableConcept)Flag.DeepCopy();
                    if (DeletedElement != null) dest.DeletedElement = (FhirBoolean)DeletedElement.DeepCopy();
                    if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                    if (Item != null) dest.Item = (ResourceReference)Item.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new EntryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as EntryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Flag, otherT.Flag)) return false;
                if (!DeepComparable.Matches(DeletedElement, otherT.DeletedElement)) return false;
                if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.Matches(Item, otherT.Item)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as EntryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Flag, otherT.Flag)) return false;
                if (!DeepComparable.IsExactly(DeletedElement, otherT.DeletedElement)) return false;
                if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Flag != null) yield return Flag;
                    if (DeletedElement != null) yield return DeletedElement;
                    if (DateElement != null) yield return DateElement;
                    if (Item != null) yield return Item;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Flag != null) yield return new ElementValue("flag", false, Flag);
                    if (DeletedElement != null) yield return new ElementValue("deleted", false, DeletedElement);
                    if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                    if (Item != null) yield return new ElementValue("item", false, Item);
                }
            }


        }


        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> Identifier
        {
            get { if (_identifier==null) _identifier = new List<Identifier>(); return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private List<Identifier> _identifier;

        /// <summary>
        /// current | retired | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ListStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ListStatus> _statusElement;

        /// <summary>
        /// current | retired | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ListStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ListStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// working | snapshot | changes
        /// </summary>
        [FhirElement("mode", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
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
        /// Descriptive name for the list
        /// </summary>
        [FhirElement("title", InSummary=true, Order=120)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Descriptive name for the list
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
        /// What the purpose of this list is
        /// </summary>
        [FhirElement("code", InSummary=true, Order=130)]
        [DataMember]
        public CodeableConcept Code
        {
            get { return _code; }
            set { _code = value; OnPropertyChanged("Code"); }
        }

        private CodeableConcept _code;

        /// <summary>
        /// If all resources have the same subject
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=140)]
        [References("Patient","Group","Device","Location")]
        [DataMember]
        public ResourceReference Subject
        {
            get { return _subject; }
            set { _subject = value; OnPropertyChanged("Subject"); }
        }

        private ResourceReference _subject;

        /// <summary>
        /// Context in which list created
        /// </summary>
        [FhirElement("encounter", Order=150)]
        [References("Encounter")]
        [DataMember]
        public ResourceReference Encounter
        {
            get { return _encounter; }
            set { _encounter = value; OnPropertyChanged("Encounter"); }
        }

        private ResourceReference _encounter;

        /// <summary>
        /// When the list was prepared
        /// </summary>
        [FhirElement("date", InSummary=true, Order=160)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// When the list was prepared
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
        /// Who and/or what defined the list contents (aka Author)
        /// </summary>
        [FhirElement("source", InSummary=true, Order=170)]
        [References("Practitioner","PractitionerRole","Patient","Device")]
        [DataMember]
        public ResourceReference Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private ResourceReference _source;

        /// <summary>
        /// What order the list has
        /// </summary>
        [FhirElement("orderedBy", Order=180)]
        [DataMember]
        public CodeableConcept OrderedBy
        {
            get { return _orderedBy; }
            set { _orderedBy = value; OnPropertyChanged("OrderedBy"); }
        }

        private CodeableConcept _orderedBy;

        /// <summary>
        /// Comments about the list
        /// </summary>
        [FhirElement("note", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Annotation> Note
        {
            get { if (_note==null) _note = new List<Annotation>(); return _note; }
            set { _note = value; OnPropertyChanged("Note"); }
        }

        private List<Annotation> _note;

        /// <summary>
        /// Entries in the list
        /// </summary>
        [FhirElement("entry", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<EntryComponent> Entry
        {
            get { if (_entry==null) _entry = new List<EntryComponent>(); return _entry; }
            set { _entry = value; OnPropertyChanged("Entry"); }
        }

        private List<EntryComponent> _entry;

        /// <summary>
        /// Why list is empty
        /// </summary>
        [FhirElement("emptyReason", Order=210)]
        [DataMember]
        public CodeableConcept EmptyReason
        {
            get { return _emptyReason; }
            set { _emptyReason = value; OnPropertyChanged("EmptyReason"); }
        }

        private CodeableConcept _emptyReason;


        public static ElementDefinition.ConstraintComponent List_LST_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "mode = 'changes' or entry.deleted.empty()",
            Key = "lst-2",
            Severity = ConstraintSeverity.Warning,
            Human = "The deleted flag can only be used if the mode of the list is \"changes\"",
            Xpath = "(f:mode/@value = 'changes') or not(exists(f:entry/f:deleted))"
        };

        public static ElementDefinition.ConstraintComponent List_LST_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "emptyReason.empty() or entry.empty()",
            Key = "lst-1",
            Severity = ConstraintSeverity.Warning,
            Human = "A list can only have an emptyReason if it is empty",
            Xpath = "not(exists(f:emptyReason) and exists(f:entry))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(List_LST_2);
            InvariantConstraints.Add(List_LST_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as List;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<ListStatus>)StatusElement.DeepCopy();
                if (ModeElement != null) dest.ModeElement = (Code<ListMode>)ModeElement.DeepCopy();
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (Code != null) dest.Code = (CodeableConcept)Code.DeepCopy();
                if (Subject != null) dest.Subject = (ResourceReference)Subject.DeepCopy();
                if (Encounter != null) dest.Encounter = (ResourceReference)Encounter.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (Source != null) dest.Source = (ResourceReference)Source.DeepCopy();
                if (OrderedBy != null) dest.OrderedBy = (CodeableConcept)OrderedBy.DeepCopy();
                if (Note != null) dest.Note = new List<Annotation>(Note.DeepCopy());
                if (Entry != null) dest.Entry = new List<EntryComponent>(Entry.DeepCopy());
                if (EmptyReason != null) dest.EmptyReason = (CodeableConcept)EmptyReason.DeepCopy();
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new List());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as List;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(Code, otherT.Code)) return false;
            if (!DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if (!DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if (!DeepComparable.Matches(OrderedBy, otherT.OrderedBy)) return false;
            if ( !DeepComparable.Matches(Note, otherT.Note)) return false;
            if ( !DeepComparable.Matches(Entry, otherT.Entry)) return false;
            if (!DeepComparable.Matches(EmptyReason, otherT.EmptyReason)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as List;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(Code, otherT.Code)) return false;
            if (!DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if (!DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(OrderedBy, otherT.OrderedBy)) return false;
            if (!DeepComparable.IsExactly(Note, otherT.Note)) return false;
            if (!DeepComparable.IsExactly(Entry, otherT.Entry)) return false;
            if (!DeepComparable.IsExactly(EmptyReason, otherT.EmptyReason)) return false;

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
                if (ModeElement != null) yield return ModeElement;
                if (TitleElement != null) yield return TitleElement;
                if (Code != null) yield return Code;
                if (Subject != null) yield return Subject;
                if (Encounter != null) yield return Encounter;
                if (DateElement != null) yield return DateElement;
                if (Source != null) yield return Source;
                if (OrderedBy != null) yield return OrderedBy;
                foreach (var elem in Note) { if (elem != null) yield return elem; }
                foreach (var elem in Entry) { if (elem != null) yield return elem; }
                if (EmptyReason != null) yield return EmptyReason;
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
                if (ModeElement != null) yield return new ElementValue("mode", false, ModeElement);
                if (TitleElement != null) yield return new ElementValue("title", false, TitleElement);
                if (Code != null) yield return new ElementValue("code", false, Code);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (Encounter != null) yield return new ElementValue("encounter", false, Encounter);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (Source != null) yield return new ElementValue("source", false, Source);
                if (OrderedBy != null) yield return new ElementValue("orderedBy", false, OrderedBy);
                foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", true, elem); }
                foreach (var elem in Entry) { if (elem != null) yield return new ElementValue("entry", true, elem); }
                if (EmptyReason != null) yield return new ElementValue("emptyReason", false, EmptyReason);
            }
        }

    }

}
