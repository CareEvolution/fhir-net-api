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
// Generated for FHIR v3.3.0
//
namespace Hl7.Fhir.Model.R4
{
    /// <summary>
    /// Todo
    /// </summary>
    [FhirType("SubstanceReferenceInformation", IsResource=true)]
    [DataContract]
    public partial class SubstanceReferenceInformation : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.SubstanceReferenceInformation; } }
        [NotMapped]
        public override string TypeName { get { return "SubstanceReferenceInformation"; } }


        [FhirType("GeneComponent")]
        [DataContract]
        public partial class GeneComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GeneComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("geneSequenceOrigin", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept GeneSequenceOrigin
            {
                get { return _geneSequenceOrigin; }
                set { _geneSequenceOrigin = value; OnPropertyChanged("GeneSequenceOrigin"); }
            }

            private CodeableConcept _geneSequenceOrigin;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("gene", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Gene
            {
                get { return _gene; }
                set { _gene = value; OnPropertyChanged("Gene"); }
            }

            private CodeableConcept _gene;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=true, Order=60)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Source
            {
                get { if (_source==null) _source = new List<ResourceReference>(); return _source; }
                set { _source = value; OnPropertyChanged("Source"); }
            }

            private List<ResourceReference> _source;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GeneComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (GeneSequenceOrigin != null) dest.GeneSequenceOrigin = (CodeableConcept)GeneSequenceOrigin.DeepCopy();
                    if (Gene != null) dest.Gene = (CodeableConcept)Gene.DeepCopy();
                    if (Source != null) dest.Source = new List<ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GeneComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GeneComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(GeneSequenceOrigin, otherT.GeneSequenceOrigin)) return false;
                if (!DeepComparable.Matches(Gene, otherT.Gene)) return false;
                if ( !DeepComparable.Matches(Source, otherT.Source)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GeneComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(GeneSequenceOrigin, otherT.GeneSequenceOrigin)) return false;
                if (!DeepComparable.IsExactly(Gene, otherT.Gene)) return false;
                if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (GeneSequenceOrigin != null) yield return GeneSequenceOrigin;
                    if (Gene != null) yield return Gene;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (GeneSequenceOrigin != null) yield return new ElementValue("geneSequenceOrigin", GeneSequenceOrigin);
                    if (Gene != null) yield return new ElementValue("gene", Gene);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                }
            }


        }


        [FhirType("GeneElementComponent")]
        [DataContract]
        public partial class GeneElementComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GeneElementComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("element", InSummary=true, Order=50)]
            [DataMember]
            public Identifier Element
            {
                get { return _element; }
                set { _element = value; OnPropertyChanged("Element"); }
            }

            private Identifier _element;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=true, Order=60)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Source
            {
                get { if (_source==null) _source = new List<ResourceReference>(); return _source; }
                set { _source = value; OnPropertyChanged("Source"); }
            }

            private List<ResourceReference> _source;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GeneElementComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Element != null) dest.Element = (Identifier)Element.DeepCopy();
                    if (Source != null) dest.Source = new List<ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new GeneElementComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as GeneElementComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Element, otherT.Element)) return false;
                if ( !DeepComparable.Matches(Source, otherT.Source)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GeneElementComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Element, otherT.Element)) return false;
                if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Element != null) yield return Element;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Element != null) yield return new ElementValue("element", Element);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                }
            }


        }


        [FhirType("ClassificationComponent")]
        [DataContract]
        public partial class ClassificationComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ClassificationComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("domain", InSummary=true, Order=40)]
            [DataMember]
            public CodeableConcept Domain
            {
                get { return _domain; }
                set { _domain = value; OnPropertyChanged("Domain"); }
            }

            private CodeableConcept _domain;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("classification", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Classification
            {
                get { return _classification; }
                set { _classification = value; OnPropertyChanged("Classification"); }
            }

            private CodeableConcept _classification;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("subtype", InSummary=true, Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<CodeableConcept> Subtype
            {
                get { if (_subtype==null) _subtype = new List<CodeableConcept>(); return _subtype; }
                set { _subtype = value; OnPropertyChanged("Subtype"); }
            }

            private List<CodeableConcept> _subtype;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=true, Order=70)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Source
            {
                get { if (_source==null) _source = new List<ResourceReference>(); return _source; }
                set { _source = value; OnPropertyChanged("Source"); }
            }

            private List<ResourceReference> _source;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ClassificationComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Domain != null) dest.Domain = (CodeableConcept)Domain.DeepCopy();
                    if (Classification != null) dest.Classification = (CodeableConcept)Classification.DeepCopy();
                    if (Subtype != null) dest.Subtype = new List<CodeableConcept>(Subtype.DeepCopy());
                    if (Source != null) dest.Source = new List<ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ClassificationComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ClassificationComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Domain, otherT.Domain)) return false;
                if (!DeepComparable.Matches(Classification, otherT.Classification)) return false;
                if ( !DeepComparable.Matches(Subtype, otherT.Subtype)) return false;
                if ( !DeepComparable.Matches(Source, otherT.Source)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ClassificationComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Domain, otherT.Domain)) return false;
                if (!DeepComparable.IsExactly(Classification, otherT.Classification)) return false;
                if (!DeepComparable.IsExactly(Subtype, otherT.Subtype)) return false;
                if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Domain != null) yield return Domain;
                    if (Classification != null) yield return Classification;
                    foreach (var elem in Subtype) { if (elem != null) yield return elem; }
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Domain != null) yield return new ElementValue("domain", Domain);
                    if (Classification != null) yield return new ElementValue("classification", Classification);
                    foreach (var elem in Subtype) { if (elem != null) yield return new ElementValue("subtype", elem); }
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                }
            }


        }


        [FhirType("RelationshipComponent")]
        [DataContract]
        public partial class RelationshipComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "RelationshipComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("substance", InSummary=true, Order=40, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(ResourceReference),typeof(CodeableConcept))]
            [DataMember]
            public Element Substance
            {
                get { return _substance; }
                set { _substance = value; OnPropertyChanged("Substance"); }
            }

            private Element _substance;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("relationship", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Relationship
            {
                get { return _relationship; }
                set { _relationship = value; OnPropertyChanged("Relationship"); }
            }

            private CodeableConcept _relationship;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("interaction", InSummary=true, Order=60)]
            [DataMember]
            public CodeableConcept Interaction
            {
                get { return _interaction; }
                set { _interaction = value; OnPropertyChanged("Interaction"); }
            }

            private CodeableConcept _interaction;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("isDefining", InSummary=true, Order=70)]
            [DataMember]
            public FhirBoolean IsDefiningElement
            {
                get { return _isDefiningElement; }
                set { _isDefiningElement = value; OnPropertyChanged("IsDefiningElement"); }
            }

            private FhirBoolean _isDefiningElement;

            /// <summary>
            /// Todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public bool? IsDefining
            {
                get { return IsDefiningElement != null ? IsDefiningElement.Value : null; }
                set
                {
                    if (value == null)
                        IsDefiningElement = null;
                    else
                        IsDefiningElement = new FhirBoolean(value);
                    OnPropertyChanged("IsDefining");
                }
            }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=80, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Quantity),typeof(Range),typeof(FhirString))]
            [DataMember]
            public Element Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Element _amount;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amountType", InSummary=true, Order=90)]
            [DataMember]
            public CodeableConcept AmountType
            {
                get { return _amountType; }
                set { _amountType = value; OnPropertyChanged("AmountType"); }
            }

            private CodeableConcept _amountType;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amountText", InSummary=true, Order=100)]
            [DataMember]
            public FhirString AmountTextElement
            {
                get { return _amountTextElement; }
                set { _amountTextElement = value; OnPropertyChanged("AmountTextElement"); }
            }

            private FhirString _amountTextElement;

            /// <summary>
            /// Todo
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string AmountText
            {
                get { return AmountTextElement != null ? AmountTextElement.Value : null; }
                set
                {
                    if (value == null)
                        AmountTextElement = null;
                    else
                        AmountTextElement = new FhirString(value);
                    OnPropertyChanged("AmountText");
                }
            }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=true, Order=110)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Source
            {
                get { if (_source==null) _source = new List<ResourceReference>(); return _source; }
                set { _source = value; OnPropertyChanged("Source"); }
            }

            private List<ResourceReference> _source;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelationshipComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Substance != null) dest.Substance = (Element)Substance.DeepCopy();
                    if (Relationship != null) dest.Relationship = (CodeableConcept)Relationship.DeepCopy();
                    if (Interaction != null) dest.Interaction = (CodeableConcept)Interaction.DeepCopy();
                    if (IsDefiningElement != null) dest.IsDefiningElement = (FhirBoolean)IsDefiningElement.DeepCopy();
                    if (Amount != null) dest.Amount = (Element)Amount.DeepCopy();
                    if (AmountType != null) dest.AmountType = (CodeableConcept)AmountType.DeepCopy();
                    if (AmountTextElement != null) dest.AmountTextElement = (FhirString)AmountTextElement.DeepCopy();
                    if (Source != null) dest.Source = new List<ResourceReference>(Source.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new RelationshipComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelationshipComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Substance, otherT.Substance)) return false;
                if (!DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.Matches(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.Matches(IsDefiningElement, otherT.IsDefiningElement)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(AmountType, otherT.AmountType)) return false;
                if (!DeepComparable.Matches(AmountTextElement, otherT.AmountTextElement)) return false;
                if ( !DeepComparable.Matches(Source, otherT.Source)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelationshipComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
                if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
                if (!DeepComparable.IsExactly(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.IsExactly(IsDefiningElement, otherT.IsDefiningElement)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(AmountType, otherT.AmountType)) return false;
                if (!DeepComparable.IsExactly(AmountTextElement, otherT.AmountTextElement)) return false;
                if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Substance != null) yield return Substance;
                    if (Relationship != null) yield return Relationship;
                    if (Interaction != null) yield return Interaction;
                    if (IsDefiningElement != null) yield return IsDefiningElement;
                    if (Amount != null) yield return Amount;
                    if (AmountType != null) yield return AmountType;
                    if (AmountTextElement != null) yield return AmountTextElement;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Substance != null) yield return new ElementValue("substance", Substance);
                    if (Relationship != null) yield return new ElementValue("relationship", Relationship);
                    if (Interaction != null) yield return new ElementValue("interaction", Interaction);
                    if (IsDefiningElement != null) yield return new ElementValue("isDefining", IsDefiningElement);
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (AmountType != null) yield return new ElementValue("amountType", AmountType);
                    if (AmountTextElement != null) yield return new ElementValue("amountText", AmountTextElement);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                }
            }


        }


        [FhirType("TargetComponent")]
        [DataContract]
        public partial class TargetComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TargetComponent"; } }

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("target", InSummary=true, Order=40)]
            [DataMember]
            public Identifier Target
            {
                get { return _target; }
                set { _target = value; OnPropertyChanged("Target"); }
            }

            private Identifier _target;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("type", InSummary=true, Order=50)]
            [DataMember]
            public CodeableConcept Type
            {
                get { return _type; }
                set { _type = value; OnPropertyChanged("Type"); }
            }

            private CodeableConcept _type;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("interaction", InSummary=true, Order=60)]
            [DataMember]
            public CodeableConcept Interaction
            {
                get { return _interaction; }
                set { _interaction = value; OnPropertyChanged("Interaction"); }
            }

            private CodeableConcept _interaction;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("organism", InSummary=true, Order=70)]
            [DataMember]
            public CodeableConcept Organism
            {
                get { return _organism; }
                set { _organism = value; OnPropertyChanged("Organism"); }
            }

            private CodeableConcept _organism;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("organismType", InSummary=true, Order=80)]
            [DataMember]
            public CodeableConcept OrganismType
            {
                get { return _organismType; }
                set { _organismType = value; OnPropertyChanged("OrganismType"); }
            }

            private CodeableConcept _organismType;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("source", InSummary=true, Order=90)]
            [References("DocumentReference")]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ResourceReference> Source
            {
                get { if (_source==null) _source = new List<ResourceReference>(); return _source; }
                set { _source = value; OnPropertyChanged("Source"); }
            }

            private List<ResourceReference> _source;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amount", InSummary=true, Order=100, Choice=ChoiceType.DatatypeChoice)]
            [AllowedTypes(typeof(Quantity),typeof(Range),typeof(FhirString))]
            [DataMember]
            public Element Amount
            {
                get { return _amount; }
                set { _amount = value; OnPropertyChanged("Amount"); }
            }

            private Element _amount;

            /// <summary>
            /// Todo
            /// </summary>
            [FhirElement("amountType", InSummary=true, Order=110)]
            [DataMember]
            public CodeableConcept AmountType
            {
                get { return _amountType; }
                set { _amountType = value; OnPropertyChanged("AmountType"); }
            }

            private CodeableConcept _amountType;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TargetComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (Target != null) dest.Target = (Identifier)Target.DeepCopy();
                    if (Type != null) dest.Type = (CodeableConcept)Type.DeepCopy();
                    if (Interaction != null) dest.Interaction = (CodeableConcept)Interaction.DeepCopy();
                    if (Organism != null) dest.Organism = (CodeableConcept)Organism.DeepCopy();
                    if (OrganismType != null) dest.OrganismType = (CodeableConcept)OrganismType.DeepCopy();
                    if (Source != null) dest.Source = new List<ResourceReference>(Source.DeepCopy());
                    if (Amount != null) dest.Amount = (Element)Amount.DeepCopy();
                    if (AmountType != null) dest.AmountType = (CodeableConcept)AmountType.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TargetComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TargetComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(Target, otherT.Target)) return false;
                if (!DeepComparable.Matches(Type, otherT.Type)) return false;
                if (!DeepComparable.Matches(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.Matches(Organism, otherT.Organism)) return false;
                if (!DeepComparable.Matches(OrganismType, otherT.OrganismType)) return false;
                if ( !DeepComparable.Matches(Source, otherT.Source)) return false;
                if (!DeepComparable.Matches(Amount, otherT.Amount)) return false;
                if (!DeepComparable.Matches(AmountType, otherT.AmountType)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TargetComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
                if (!DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if (!DeepComparable.IsExactly(Interaction, otherT.Interaction)) return false;
                if (!DeepComparable.IsExactly(Organism, otherT.Organism)) return false;
                if (!DeepComparable.IsExactly(OrganismType, otherT.OrganismType)) return false;
                if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
                if (!DeepComparable.IsExactly(Amount, otherT.Amount)) return false;
                if (!DeepComparable.IsExactly(AmountType, otherT.AmountType)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Target != null) yield return Target;
                    if (Type != null) yield return Type;
                    if (Interaction != null) yield return Interaction;
                    if (Organism != null) yield return Organism;
                    if (OrganismType != null) yield return OrganismType;
                    foreach (var elem in Source) { if (elem != null) yield return elem; }
                    if (Amount != null) yield return Amount;
                    if (AmountType != null) yield return AmountType;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Target != null) yield return new ElementValue("target", Target);
                    if (Type != null) yield return new ElementValue("type", Type);
                    if (Interaction != null) yield return new ElementValue("interaction", Interaction);
                    if (Organism != null) yield return new ElementValue("organism", Organism);
                    if (OrganismType != null) yield return new ElementValue("organismType", OrganismType);
                    foreach (var elem in Source) { if (elem != null) yield return new ElementValue("source", elem); }
                    if (Amount != null) yield return new ElementValue("amount", Amount);
                    if (AmountType != null) yield return new ElementValue("amountType", AmountType);
                }
            }


        }


        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("comment", InSummary=true, Order=90)]
        [DataMember]
        public FhirString CommentElement
        {
            get { return _commentElement; }
            set { _commentElement = value; OnPropertyChanged("CommentElement"); }
        }

        private FhirString _commentElement;

        /// <summary>
        /// Todo
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Comment
        {
            get { return CommentElement != null ? CommentElement.Value : null; }
            set
            {
                if (value == null)
                    CommentElement = null;
                else
                    CommentElement = new FhirString(value);
                OnPropertyChanged("Comment");
            }
        }

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("gene", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GeneComponent> Gene
        {
            get { if (_gene==null) _gene = new List<GeneComponent>(); return _gene; }
            set { _gene = value; OnPropertyChanged("Gene"); }
        }

        private List<GeneComponent> _gene;

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("geneElement", InSummary=true, Order=110)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GeneElementComponent> GeneElement
        {
            get { if (_geneElement==null) _geneElement = new List<GeneElementComponent>(); return _geneElement; }
            set { _geneElement = value; OnPropertyChanged("GeneElement"); }
        }

        private List<GeneElementComponent> _geneElement;

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("classification", InSummary=true, Order=120)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ClassificationComponent> Classification
        {
            get { if (_classification==null) _classification = new List<ClassificationComponent>(); return _classification; }
            set { _classification = value; OnPropertyChanged("Classification"); }
        }

        private List<ClassificationComponent> _classification;

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("relationship", InSummary=true, Order=130)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<RelationshipComponent> Relationship
        {
            get { if (_relationship==null) _relationship = new List<RelationshipComponent>(); return _relationship; }
            set { _relationship = value; OnPropertyChanged("Relationship"); }
        }

        private List<RelationshipComponent> _relationship;

        /// <summary>
        /// Todo
        /// </summary>
        [FhirElement("target", InSummary=true, Order=140)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<TargetComponent> Target
        {
            get { if (_target==null) _target = new List<TargetComponent>(); return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private List<TargetComponent> _target;


        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as SubstanceReferenceInformation;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
                if (Gene != null) dest.Gene = new List<GeneComponent>(Gene.DeepCopy());
                if (GeneElement != null) dest.GeneElement = new List<GeneElementComponent>(GeneElement.DeepCopy());
                if (Classification != null) dest.Classification = new List<ClassificationComponent>(Classification.DeepCopy());
                if (Relationship != null) dest.Relationship = new List<RelationshipComponent>(Relationship.DeepCopy());
                if (Target != null) dest.Target = new List<TargetComponent>(Target.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new SubstanceReferenceInformation());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as SubstanceReferenceInformation;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
            if ( !DeepComparable.Matches(Gene, otherT.Gene)) return false;
            if ( !DeepComparable.Matches(GeneElement, otherT.GeneElement)) return false;
            if ( !DeepComparable.Matches(Classification, otherT.Classification)) return false;
            if ( !DeepComparable.Matches(Relationship, otherT.Relationship)) return false;
            if ( !DeepComparable.Matches(Target, otherT.Target)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as SubstanceReferenceInformation;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
            if (!DeepComparable.IsExactly(Gene, otherT.Gene)) return false;
            if (!DeepComparable.IsExactly(GeneElement, otherT.GeneElement)) return false;
            if (!DeepComparable.IsExactly(Classification, otherT.Classification)) return false;
            if (!DeepComparable.IsExactly(Relationship, otherT.Relationship)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (CommentElement != null) yield return CommentElement;
                foreach (var elem in Gene) { if (elem != null) yield return elem; }
                foreach (var elem in GeneElement) { if (elem != null) yield return elem; }
                foreach (var elem in Classification) { if (elem != null) yield return elem; }
                foreach (var elem in Relationship) { if (elem != null) yield return elem; }
                foreach (var elem in Target) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
                foreach (var elem in Gene) { if (elem != null) yield return new ElementValue("gene", elem); }
                foreach (var elem in GeneElement) { if (elem != null) yield return new ElementValue("geneElement", elem); }
                foreach (var elem in Classification) { if (elem != null) yield return new ElementValue("classification", elem); }
                foreach (var elem in Relationship) { if (elem != null) yield return new ElementValue("relationship", elem); }
                foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", elem); }
            }
        }

    }

}
