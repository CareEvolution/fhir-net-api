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
    /// An entry in a catalog
    /// </summary>
    [FhirType("EntryDefinition", IsResource=true)]
    [DataContract]
    public partial class EntryDefinition : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.EntryDefinition; } }
        [NotMapped]
        public override string TypeName { get { return "EntryDefinition"; } }

        /// <summary>
        /// The type of relations between entries.
        /// (url: http://hl7.org/fhir/ValueSet/relation-type)
        /// </summary>
        [FhirEnumeration("EntryDefinitionRelationType")]
        public enum EntryDefinitionRelationType
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/relation-type)
            /// </summary>
            [EnumLiteral("has-input", "http://hl7.org/fhir/relation-type"), Description("Has Input")]
            HasInput,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/relation-type)
            /// </summary>
            [EnumLiteral("has-output", "http://hl7.org/fhir/relation-type"), Description("Has Output")]
            HasOutput,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/relation-type)
            /// </summary>
            [EnumLiteral("uses", "http://hl7.org/fhir/relation-type"), Description("Uses")]
            Uses,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/relation-type)
            /// </summary>
            [EnumLiteral("triggers", "http://hl7.org/fhir/relation-type"), Description("Triggers")]
            Triggers,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/relation-type)
            /// </summary>
            [EnumLiteral("is-replaced-by", "http://hl7.org/fhir/relation-type"), Description("Replaced By")]
            IsReplacedBy,
        }


        [FhirType("RelatedEntryComponent")]
        [DataContract]
        public partial class RelatedEntryComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedEntryComponent"; } }

            /// <summary>
            /// has-input | has-output | uses | triggers | is-replaced-by
            /// </summary>
            [FhirElement("relationtype", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<EntryDefinitionRelationType> RelationtypeElement
            {
                get { return _relationtypeElement; }
                set { _relationtypeElement = value; OnPropertyChanged("RelationtypeElement"); }
            }

            private Code<EntryDefinitionRelationType> _relationtypeElement;

            /// <summary>
            /// has-input | has-output | uses | triggers | is-replaced-by
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public EntryDefinitionRelationType? Relationtype
            {
                get { return RelationtypeElement != null ? RelationtypeElement.Value : null; }
                set
                {
                    if (value == null)
                        RelationtypeElement = null;
                    else
                        RelationtypeElement = new Code<EntryDefinitionRelationType>(value);
                    OnPropertyChanged("Relationtype");
                }
            }

            /// <summary>
            /// The reference to the related item
            /// </summary>
            [FhirElement("item", Order=50)]
            [References("EntryDefinition")]
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
                var dest = other as RelatedEntryComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (RelationtypeElement != null) dest.RelationtypeElement = (Code<EntryDefinitionRelationType>)RelationtypeElement.DeepCopy();
                    if (Item != null) dest.Item = (ResourceReference)Item.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelatedEntryComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatedEntryComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(RelationtypeElement, otherT.RelationtypeElement)) return false;
                if (!DeepComparable.Matches(Item, otherT.Item)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedEntryComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(RelationtypeElement, otherT.RelationtypeElement)) return false;
                if (!DeepComparable.IsExactly(Item, otherT.Item)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (RelationtypeElement != null) yield return RelationtypeElement;
                    if (Item != null) yield return Item;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (RelationtypeElement != null) yield return new ElementValue("relationtype", RelationtypeElement);
                    if (Item != null) yield return new ElementValue("item", Item);
                }
            }


        }


        /// <summary>
        /// Unique identifier of the catalog item
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
        /// The type of item - medication, device, service, protocol or other
        /// </summary>
        [FhirElement("type", Order=100)]
        [DataMember]
        public CodeableConcept Type
        {
            get { return _type; }
            set { _type = value; OnPropertyChanged("Type"); }
        }

        private CodeableConcept _type;

        /// <summary>
        /// Whether the entry represents an orderable item
        /// </summary>
        [FhirElement("orderable", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public FhirBoolean OrderableElement
        {
            get { return _orderableElement; }
            set { _orderableElement = value; OnPropertyChanged("OrderableElement"); }
        }

        private FhirBoolean _orderableElement;

        /// <summary>
        /// Whether the entry represents an orderable item
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Orderable
        {
            get { return OrderableElement != null ? OrderableElement.Value : null; }
            set
            {
                if (value == null)
                    OrderableElement = null;
                else
                    OrderableElement = new FhirBoolean(value);
                OnPropertyChanged("Orderable");
            }
        }

        /// <summary>
        /// The item that is being defined
        /// </summary>
        [FhirElement("referencedItem", InSummary=true, Order=120)]
        [References("Medication","Device","Organization","Practitioner","HealthcareService","ActivityDefinition","PlanDefinition","SpecimenDefinition","ObservationDefinition","Binary")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public ResourceReference ReferencedItem
        {
            get { return _referencedItem; }
            set { _referencedItem = value; OnPropertyChanged("ReferencedItem"); }
        }

        private ResourceReference _referencedItem;

        /// <summary>
        /// Any additional identifier(s) for the catalog item, in the same granularity or concept
        /// </summary>
        [FhirElement("additionalIdentifier", Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Identifier> AdditionalIdentifier
        {
            get { if (_additionalIdentifier==null) _additionalIdentifier = new List<Identifier>(); return _additionalIdentifier; }
            set { _additionalIdentifier = value; OnPropertyChanged("AdditionalIdentifier"); }
        }

        private List<Identifier> _additionalIdentifier;

        /// <summary>
        /// Classification (category or class) of the item entry
        /// </summary>
        [FhirElement("classification", Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Classification
        {
            get { if (_classification==null) _classification = new List<CodeableConcept>(); return _classification; }
            set { _classification = value; OnPropertyChanged("Classification"); }
        }

        private List<CodeableConcept> _classification;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", Order=150)]
        [DataMember]
        public Code<PublicationStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<PublicationStatus> _statusElement;

        /// <summary>
        /// draft | active | retired | unknown
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public PublicationStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<PublicationStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// The time period in which this catalog entry is expected to be active
        /// </summary>
        [FhirElement("validityPeriod", Order=160)]
        [DataMember]
        public Period ValidityPeriod
        {
            get { return _validityPeriod; }
            set { _validityPeriod = value; OnPropertyChanged("ValidityPeriod"); }
        }

        private Period _validityPeriod;

        /// <summary>
        /// When was this catalog last updated
        /// </summary>
        [FhirElement("lastUpdated", Order=170)]
        [DataMember]
        public FhirDateTime LastUpdatedElement
        {
            get { return _lastUpdatedElement; }
            set { _lastUpdatedElement = value; OnPropertyChanged("LastUpdatedElement"); }
        }

        private FhirDateTime _lastUpdatedElement;

        /// <summary>
        /// When was this catalog last updated
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string LastUpdated
        {
            get { return LastUpdatedElement != null ? LastUpdatedElement.Value : null; }
            set
            {
                if (value == null)
                    LastUpdatedElement = null;
                else
                    LastUpdatedElement = new FhirDateTime(value);
                OnPropertyChanged("LastUpdated");
            }
        }

        /// <summary>
        /// Additional characteristics of the catalog entry
        /// </summary>
        [FhirElement("additionalCharacteristic", Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> AdditionalCharacteristic
        {
            get { if (_additionalCharacteristic==null) _additionalCharacteristic = new List<CodeableConcept>(); return _additionalCharacteristic; }
            set { _additionalCharacteristic = value; OnPropertyChanged("AdditionalCharacteristic"); }
        }

        private List<CodeableConcept> _additionalCharacteristic;

        /// <summary>
        /// Additional classification of the catalog entry
        /// </summary>
        [FhirElement("additionalClassification", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> AdditionalClassification
        {
            get { if (_additionalClassification==null) _additionalClassification = new List<CodeableConcept>(); return _additionalClassification; }
            set { _additionalClassification = value; OnPropertyChanged("AdditionalClassification"); }
        }

        private List<CodeableConcept> _additionalClassification;

        /// <summary>
        /// An item that this catalog entry is related to
        /// </summary>
        [FhirElement("relatedEntry", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelatedEntryComponent> RelatedEntry
        {
            get { if (_relatedEntry==null) _relatedEntry = new List<RelatedEntryComponent>(); return _relatedEntry; }
            set { _relatedEntry = value; OnPropertyChanged("RelatedEntry"); }
        }

        private List<RelatedEntryComponent> _relatedEntry;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as EntryDefinition;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (Identifier != null) dest.Identifier = new List<Identifier>(Identifier.DeepCopy());
                if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                if (OrderableElement != null) dest.OrderableElement = (FhirBoolean)OrderableElement.DeepCopy();
                if (ReferencedItem != null) dest.ReferencedItem = (ResourceReference)ReferencedItem.DeepCopy();
                if (AdditionalIdentifier != null) dest.AdditionalIdentifier = new List<Identifier>(AdditionalIdentifier.DeepCopy());
                if (Classification != null) dest.Classification = new List<CodeableConcept>(Classification.DeepCopy());
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ValidityPeriod != null) dest.ValidityPeriod = (Period)ValidityPeriod.DeepCopy();
                if (LastUpdatedElement != null) dest.LastUpdatedElement = (FhirDateTime)LastUpdatedElement.DeepCopy();
                if (AdditionalCharacteristic != null) dest.AdditionalCharacteristic = new List<CodeableConcept>(AdditionalCharacteristic.DeepCopy());
                if (AdditionalClassification != null) dest.AdditionalClassification = new List<CodeableConcept>(AdditionalClassification.DeepCopy());
                if (RelatedEntry != null) dest.RelatedEntry = new List<RelatedEntryComponent>(RelatedEntry.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new EntryDefinition());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as EntryDefinition;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if ( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(Type, otherT.Type)) return false;
            if (!DeepComparable.Matches(OrderableElement, otherT.OrderableElement)) return false;
            if (!DeepComparable.Matches(ReferencedItem, otherT.ReferencedItem)) return false;
            if ( !DeepComparable.Matches(AdditionalIdentifier, otherT.AdditionalIdentifier)) return false;
            if ( !DeepComparable.Matches(Classification, otherT.Classification)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ValidityPeriod, otherT.ValidityPeriod)) return false;
            if (!DeepComparable.Matches(LastUpdatedElement, otherT.LastUpdatedElement)) return false;
            if ( !DeepComparable.Matches(AdditionalCharacteristic, otherT.AdditionalCharacteristic)) return false;
            if ( !DeepComparable.Matches(AdditionalClassification, otherT.AdditionalClassification)) return false;
            if ( !DeepComparable.Matches(RelatedEntry, otherT.RelatedEntry)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as EntryDefinition;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if (!DeepComparable.IsExactly(OrderableElement, otherT.OrderableElement)) return false;
            if (!DeepComparable.IsExactly(ReferencedItem, otherT.ReferencedItem)) return false;
            if (!DeepComparable.IsExactly(AdditionalIdentifier, otherT.AdditionalIdentifier)) return false;
            if (!DeepComparable.IsExactly(Classification, otherT.Classification)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ValidityPeriod, otherT.ValidityPeriod)) return false;
            if (!DeepComparable.IsExactly(LastUpdatedElement, otherT.LastUpdatedElement)) return false;
            if (!DeepComparable.IsExactly(AdditionalCharacteristic, otherT.AdditionalCharacteristic)) return false;
            if (!DeepComparable.IsExactly(AdditionalClassification, otherT.AdditionalClassification)) return false;
            if (!DeepComparable.IsExactly(RelatedEntry, otherT.RelatedEntry)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return elem; }
                if (Type != null) yield return Type;
                if (OrderableElement != null) yield return OrderableElement;
                if (ReferencedItem != null) yield return ReferencedItem;
                foreach (var elem in AdditionalIdentifier) { if (elem != null) yield return elem; }
                foreach (var elem in Classification) { if (elem != null) yield return elem; }
                if (StatusElement != null) yield return StatusElement;
                if (ValidityPeriod != null) yield return ValidityPeriod;
                if (LastUpdatedElement != null) yield return LastUpdatedElement;
                foreach (var elem in AdditionalCharacteristic) { if (elem != null) yield return elem; }
                foreach (var elem in AdditionalClassification) { if (elem != null) yield return elem; }
                foreach (var elem in RelatedEntry) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
                if (Type != null) yield return new ElementValue("type", Type);
                if (OrderableElement != null) yield return new ElementValue("orderable", OrderableElement);
                if (ReferencedItem != null) yield return new ElementValue("referencedItem", ReferencedItem);
                foreach (var elem in AdditionalIdentifier) { if (elem != null) yield return new ElementValue("additionalIdentifier", elem); }
                foreach (var elem in Classification) { if (elem != null) yield return new ElementValue("classification", elem); }
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ValidityPeriod != null) yield return new ElementValue("validityPeriod", ValidityPeriod);
                if (LastUpdatedElement != null) yield return new ElementValue("lastUpdated", LastUpdatedElement);
                foreach (var elem in AdditionalCharacteristic) { if (elem != null) yield return new ElementValue("additionalCharacteristic", elem); }
                foreach (var elem in AdditionalClassification) { if (elem != null) yield return new ElementValue("additionalClassification", elem); }
                foreach (var elem in RelatedEntry) { if (elem != null) yield return new ElementValue("relatedEntry", elem); }
            }
        }

    }

}
