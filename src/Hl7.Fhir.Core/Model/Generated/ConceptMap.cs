using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection.DSTU2;
using Hl7.Fhir.Validation.DSTU2;
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
// Generated for FHIR v1.0.2
//
namespace Hl7.Fhir.Model.DSTU2
{
    /// <summary>
    /// A map from one set of concepts to one or more other concepts
    /// </summary>
    [FhirType("ConceptMap", IsResource=true)]
    [DataContract]
    public partial class ConceptMap : DomainResource
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ConceptMap; } }
        [NotMapped]
        public override string TypeName { get { return "ConceptMap"; } }

        /// <summary>
        /// The degree of equivalence between concepts.
        /// (url: http://hl7.org/fhir/ValueSet/concept-map-equivalence)
        /// </summary>
        [FhirEnumeration("ConceptMapEquivalence")]
        public enum ConceptMapEquivalence
        {
            /// <summary>
            /// The definitions of the concepts mean the same thing (including when structural implications of meaning are considered) (i.e. extensionally identical).
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("equivalent", "http://hl7.org/fhir/concept-map-equivalence"), Description("Equivalent")]
            Equivalent,
            /// <summary>
            /// The definitions of the concepts are exactly the same (i.e. only grammatical differences) and structural implications of meaning are identical or irrelevant (i.e. intentionally identical).
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("equal", "http://hl7.org/fhir/concept-map-equivalence"), Description("Equal")]
            Equal,
            /// <summary>
            /// The target mapping is wider in meaning than the source concept.
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("wider", "http://hl7.org/fhir/concept-map-equivalence"), Description("Wider")]
            Wider,
            /// <summary>
            /// The target mapping subsumes the meaning of the source concept (e.g. the source is-a target).
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("subsumes", "http://hl7.org/fhir/concept-map-equivalence"), Description("Subsumes")]
            Subsumes,
            /// <summary>
            /// The target mapping is narrower in meaning that the source concept. The sense in which the mapping is narrower SHALL be described in the comments in this case, and applications should be careful when attempting to use these mappings operationally.
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("narrower", "http://hl7.org/fhir/concept-map-equivalence"), Description("Narrower")]
            Narrower,
            /// <summary>
            /// The target mapping specializes the meaning of the source concept (e.g. the target is-a source).
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("specializes", "http://hl7.org/fhir/concept-map-equivalence"), Description("Specializes")]
            Specializes,
            /// <summary>
            /// The target mapping overlaps with the source concept, but both source and target cover additional meaning, or the definitions are imprecise and it is uncertain whether they have the same boundaries to their meaning. The sense in which the mapping is narrower SHALL be described in the comments in this case, and applications should be careful when attempting to use these mappings operationally.
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("inexact", "http://hl7.org/fhir/concept-map-equivalence"), Description("Inexact")]
            Inexact,
            /// <summary>
            /// There is no match for this concept in the destination concept system.
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("unmatched", "http://hl7.org/fhir/concept-map-equivalence"), Description("Unmatched")]
            Unmatched,
            /// <summary>
            /// This is an explicit assertion that there is no mapping between the source and target concept.
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("disjoint", "http://hl7.org/fhir/concept-map-equivalence"), Description("Disjoint")]
            Disjoint,
        }


        [FhirType("ContactComponent")]
        [DataContract]
        public partial class ContactComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "ContactComponent"; } }

            /// <summary>
            /// Name of a individual to contact
            /// </summary>
            [FhirElement("name", InSummary=true, Order=40)]
            [DataMember]
            public FhirString NameElement
            {
                get { return _nameElement; }
                set { _nameElement = value; OnPropertyChanged("NameElement"); }
            }

            private FhirString _nameElement;

            /// <summary>
            /// Name of a individual to contact
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Name
            {
                get { return NameElement != null ? NameElement.Value : null; }
                set
                {
                    if (value == null)
                        NameElement = null;
                    else
                        NameElement = new FhirString(value);
                    OnPropertyChanged("Name");
                }
            }

            /// <summary>
            /// Contact details for individual or publisher
            /// </summary>
            [FhirElement("telecom", InSummary=true, Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<ContactPoint> Telecom
            {
                get { if (_telecom==null) _telecom = new List<ContactPoint>(); return _telecom; }
                set { _telecom = value; OnPropertyChanged("Telecom"); }
            }

            private List<ContactPoint> _telecom;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContactComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                    if (Telecom != null) dest.Telecom = new List<ContactPoint>(Telecom.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new ContactComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
                if ( !DeepComparable.Matches(Telecom, otherT.Telecom)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContactComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
                if (!DeepComparable.IsExactly(Telecom, otherT.Telecom)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (NameElement != null) yield return NameElement;
                    foreach (var elem in Telecom) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (NameElement != null) yield return new ElementValue("name", NameElement);
                    foreach (var elem in Telecom) { if (elem != null) yield return new ElementValue("telecom", elem); }
                }
            }


        }


        [FhirType("SourceElementComponent")]
        [DataContract]
        public partial class SourceElementComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "SourceElementComponent"; } }

            /// <summary>
            /// Code System (if value set crosses code systems)
            /// </summary>
            [FhirElement("codeSystem", Order=40)]
            [DataMember]
            public FhirUri CodeSystemElement
            {
                get { return _codeSystemElement; }
                set { _codeSystemElement = value; OnPropertyChanged("CodeSystemElement"); }
            }

            private FhirUri _codeSystemElement;

            /// <summary>
            /// Code System (if value set crosses code systems)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string CodeSystem
            {
                get { return CodeSystemElement != null ? CodeSystemElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeSystemElement = null;
                    else
                        CodeSystemElement = new FhirUri(value);
                    OnPropertyChanged("CodeSystem");
                }
            }

            /// <summary>
            /// Identifies element being mapped
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public Code CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code _codeElement;

            /// <summary>
            /// Identifies element being mapped
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// Concept in target system for element
            /// </summary>
            [FhirElement("target", Order=60)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<TargetElementComponent> Target
            {
                get { if (_target==null) _target = new List<TargetElementComponent>(); return _target; }
                set { _target = value; OnPropertyChanged("Target"); }
            }

            private List<TargetElementComponent> _target;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SourceElementComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeSystemElement != null) dest.CodeSystemElement = (FhirUri)CodeSystemElement.DeepCopy();
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (Target != null) dest.Target = new List<TargetElementComponent>(Target.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new SourceElementComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SourceElementComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeSystemElement, otherT.CodeSystemElement)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if ( !DeepComparable.Matches(Target, otherT.Target)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SourceElementComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeSystemElement, otherT.CodeSystemElement)) return false;
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
                    if (CodeSystemElement != null) yield return CodeSystemElement;
                    if (CodeElement != null) yield return CodeElement;
                    foreach (var elem in Target) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeSystemElement != null) yield return new ElementValue("codeSystem", CodeSystemElement);
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", elem); }
                }
            }


        }


        [FhirType("TargetElementComponent")]
        [DataContract]
        public partial class TargetElementComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "TargetElementComponent"; } }

            /// <summary>
            /// System of the target (if necessary)
            /// </summary>
            [FhirElement("codeSystem", Order=40)]
            [DataMember]
            public FhirUri CodeSystemElement
            {
                get { return _codeSystemElement; }
                set { _codeSystemElement = value; OnPropertyChanged("CodeSystemElement"); }
            }

            private FhirUri _codeSystemElement;

            /// <summary>
            /// System of the target (if necessary)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string CodeSystem
            {
                get { return CodeSystemElement != null ? CodeSystemElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeSystemElement = null;
                    else
                        CodeSystemElement = new FhirUri(value);
                    OnPropertyChanged("CodeSystem");
                }
            }

            /// <summary>
            /// Code that identifies the target element
            /// </summary>
            [FhirElement("code", Order=50)]
            [DataMember]
            public Code CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private Code _codeElement;

            /// <summary>
            /// Code that identifies the target element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new Code(value);
                    OnPropertyChanged("Code");
                }
            }

            /// <summary>
            /// equivalent | equal | wider | subsumes | narrower | specializes | inexact | unmatched | disjoint
            /// </summary>
            [FhirElement("equivalence", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ConceptMapEquivalence> EquivalenceElement
            {
                get { return _equivalenceElement; }
                set { _equivalenceElement = value; OnPropertyChanged("EquivalenceElement"); }
            }

            private Code<ConceptMapEquivalence> _equivalenceElement;

            /// <summary>
            /// equivalent | equal | wider | subsumes | narrower | specializes | inexact | unmatched | disjoint
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConceptMapEquivalence? Equivalence
            {
                get { return EquivalenceElement != null ? EquivalenceElement.Value : null; }
                set
                {
                    if (value == null)
                        EquivalenceElement = null;
                    else
                        EquivalenceElement = new Code<ConceptMapEquivalence>(value);
                    OnPropertyChanged("Equivalence");
                }
            }

            /// <summary>
            /// Description of status/issues in mapping
            /// </summary>
            [FhirElement("comments", Order=70)]
            [DataMember]
            public FhirString CommentsElement
            {
                get { return _commentsElement; }
                set { _commentsElement = value; OnPropertyChanged("CommentsElement"); }
            }

            private FhirString _commentsElement;

            /// <summary>
            /// Description of status/issues in mapping
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Comments
            {
                get { return CommentsElement != null ? CommentsElement.Value : null; }
                set
                {
                    if (value == null)
                        CommentsElement = null;
                    else
                        CommentsElement = new FhirString(value);
                    OnPropertyChanged("Comments");
                }
            }

            /// <summary>
            /// Other elements required for this mapping (from context)
            /// </summary>
            [FhirElement("dependsOn", Order=80)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<OtherElementComponent> DependsOn
            {
                get { if (_dependsOn==null) _dependsOn = new List<OtherElementComponent>(); return _dependsOn; }
                set { _dependsOn = value; OnPropertyChanged("DependsOn"); }
            }

            private List<OtherElementComponent> _dependsOn;

            /// <summary>
            /// Other concepts that this mapping also produces
            /// </summary>
            [FhirElement("product", Order=90)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<OtherElementComponent> Product
            {
                get { if (_product==null) _product = new List<OtherElementComponent>(); return _product; }
                set { _product = value; OnPropertyChanged("Product"); }
            }

            private List<OtherElementComponent> _product;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as TargetElementComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (CodeSystemElement != null) dest.CodeSystemElement = (FhirUri)CodeSystemElement.DeepCopy();
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (EquivalenceElement != null) dest.EquivalenceElement = (Code<ConceptMapEquivalence>)EquivalenceElement.DeepCopy();
                    if (CommentsElement != null) dest.CommentsElement = (FhirString)CommentsElement.DeepCopy();
                    if (DependsOn != null) dest.DependsOn = new List<OtherElementComponent>(DependsOn.DeepCopy());
                    if (Product != null) dest.Product = new List<OtherElementComponent>(Product.DeepCopy());
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new TargetElementComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as TargetElementComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(CodeSystemElement, otherT.CodeSystemElement)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(EquivalenceElement, otherT.EquivalenceElement)) return false;
                if (!DeepComparable.Matches(CommentsElement, otherT.CommentsElement)) return false;
                if ( !DeepComparable.Matches(DependsOn, otherT.DependsOn)) return false;
                if ( !DeepComparable.Matches(Product, otherT.Product)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TargetElementComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeSystemElement, otherT.CodeSystemElement)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(EquivalenceElement, otherT.EquivalenceElement)) return false;
                if (!DeepComparable.IsExactly(CommentsElement, otherT.CommentsElement)) return false;
                if (!DeepComparable.IsExactly(DependsOn, otherT.DependsOn)) return false;
                if (!DeepComparable.IsExactly(Product, otherT.Product)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeSystemElement != null) yield return CodeSystemElement;
                    if (CodeElement != null) yield return CodeElement;
                    if (EquivalenceElement != null) yield return EquivalenceElement;
                    if (CommentsElement != null) yield return CommentsElement;
                    foreach (var elem in DependsOn) { if (elem != null) yield return elem; }
                    foreach (var elem in Product) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeSystemElement != null) yield return new ElementValue("codeSystem", CodeSystemElement);
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (EquivalenceElement != null) yield return new ElementValue("equivalence", EquivalenceElement);
                    if (CommentsElement != null) yield return new ElementValue("comments", CommentsElement);
                    foreach (var elem in DependsOn) { if (elem != null) yield return new ElementValue("dependsOn", elem); }
                    foreach (var elem in Product) { if (elem != null) yield return new ElementValue("product", elem); }
                }
            }


        }


        [FhirType("OtherElementComponent")]
        [DataContract]
        public partial class OtherElementComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "OtherElementComponent"; } }

            /// <summary>
            /// Reference to element/field/ValueSet mapping depends on
            /// </summary>
            [FhirElement("element", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri ElementElement
            {
                get { return _elementElement; }
                set { _elementElement = value; OnPropertyChanged("ElementElement"); }
            }

            private FhirUri _elementElement;

            /// <summary>
            /// Reference to element/field/ValueSet mapping depends on
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Element
            {
                get { return ElementElement != null ? ElementElement.Value : null; }
                set
                {
                    if (value == null)
                        ElementElement = null;
                    else
                        ElementElement = new FhirUri(value);
                    OnPropertyChanged("Element");
                }
            }

            /// <summary>
            /// Code System (if necessary)
            /// </summary>
            [FhirElement("codeSystem", Order=50)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri CodeSystemElement
            {
                get { return _codeSystemElement; }
                set { _codeSystemElement = value; OnPropertyChanged("CodeSystemElement"); }
            }

            private FhirUri _codeSystemElement;

            /// <summary>
            /// Code System (if necessary)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string CodeSystem
            {
                get { return CodeSystemElement != null ? CodeSystemElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeSystemElement = null;
                    else
                        CodeSystemElement = new FhirUri(value);
                    OnPropertyChanged("CodeSystem");
                }
            }

            /// <summary>
            /// Value of the referenced element
            /// </summary>
            [FhirElement("code", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString CodeElement
            {
                get { return _codeElement; }
                set { _codeElement = value; OnPropertyChanged("CodeElement"); }
            }

            private FhirString _codeElement;

            /// <summary>
            /// Value of the referenced element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (value == null)
                        CodeElement = null;
                    else
                        CodeElement = new FhirString(value);
                    OnPropertyChanged("Code");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OtherElementComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ElementElement != null) dest.ElementElement = (FhirUri)ElementElement.DeepCopy();
                    if (CodeSystemElement != null) dest.CodeSystemElement = (FhirUri)CodeSystemElement.DeepCopy();
                    if (CodeElement != null) dest.CodeElement = (FhirString)CodeElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new OtherElementComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as OtherElementComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ElementElement, otherT.ElementElement)) return false;
                if (!DeepComparable.Matches(CodeSystemElement, otherT.CodeSystemElement)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OtherElementComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ElementElement, otherT.ElementElement)) return false;
                if (!DeepComparable.IsExactly(CodeSystemElement, otherT.CodeSystemElement)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ElementElement != null) yield return ElementElement;
                    if (CodeSystemElement != null) yield return CodeSystemElement;
                    if (CodeElement != null) yield return CodeElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ElementElement != null) yield return new ElementValue("element", ElementElement);
                    if (CodeSystemElement != null) yield return new ElementValue("codeSystem", CodeSystemElement);
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                }
            }


        }


        /// <summary>
        /// Globally unique logical id for concept map
        /// </summary>
        [FhirElement("url", InSummary=true, Order=90)]
        [DataMember]
        public FhirUri UrlElement
        {
            get { return _urlElement; }
            set { _urlElement = value; OnPropertyChanged("UrlElement"); }
        }

        private FhirUri _urlElement;

        /// <summary>
        /// Globally unique logical id for concept map
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Url
        {
            get { return UrlElement != null ? UrlElement.Value : null; }
            set
            {
                if (value == null)
                    UrlElement = null;
                else
                    UrlElement = new FhirUri(value);
                OnPropertyChanged("Url");
            }
        }

        /// <summary>
        /// Additional identifier for the concept map
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [DataMember]
        public Identifier Identifier
        {
            get { return _identifier; }
            set { _identifier = value; OnPropertyChanged("Identifier"); }
        }

        private Identifier _identifier;

        /// <summary>
        /// Logical id for this version of the concept map
        /// </summary>
        [FhirElement("version", InSummary=true, Order=110)]
        [DataMember]
        public FhirString VersionElement
        {
            get { return _versionElement; }
            set { _versionElement = value; OnPropertyChanged("VersionElement"); }
        }

        private FhirString _versionElement;

        /// <summary>
        /// Logical id for this version of the concept map
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Version
        {
            get { return VersionElement != null ? VersionElement.Value : null; }
            set
            {
                if (value == null)
                    VersionElement = null;
                else
                    VersionElement = new FhirString(value);
                OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Informal name for this concept map
        /// </summary>
        [FhirElement("name", InSummary=true, Order=120)]
        [DataMember]
        public FhirString NameElement
        {
            get { return _nameElement; }
            set { _nameElement = value; OnPropertyChanged("NameElement"); }
        }

        private FhirString _nameElement;

        /// <summary>
        /// Informal name for this concept map
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Name
        {
            get { return NameElement != null ? NameElement.Value : null; }
            set
            {
                if (value == null)
                    NameElement = null;
                else
                    NameElement = new FhirString(value);
                OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// draft | active | retired
        /// </summary>
        [FhirElement("status", InSummary=true, Order=130)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<ConformanceResourceStatus> StatusElement
        {
            get { return _statusElement; }
            set { _statusElement = value; OnPropertyChanged("StatusElement"); }
        }

        private Code<ConformanceResourceStatus> _statusElement;

        /// <summary>
        /// draft | active | retired
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public ConformanceResourceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (value == null)
                    StatusElement = null;
                else
                    StatusElement = new Code<ConformanceResourceStatus>(value);
                OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=140)]
        [DataMember]
        public FhirBoolean ExperimentalElement
        {
            get { return _experimentalElement; }
            set { _experimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }

        private FhirBoolean _experimentalElement;

        /// <summary>
        /// If for testing purposes, not real usage
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public bool? Experimental
        {
            get { return ExperimentalElement != null ? ExperimentalElement.Value : null; }
            set
            {
                if (value == null)
                    ExperimentalElement = null;
                else
                    ExperimentalElement = new FhirBoolean(value);
                OnPropertyChanged("Experimental");
            }
        }

        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=150)]
        [DataMember]
        public FhirString PublisherElement
        {
            get { return _publisherElement; }
            set { _publisherElement = value; OnPropertyChanged("PublisherElement"); }
        }

        private FhirString _publisherElement;

        /// <summary>
        /// Name of the publisher (organization or individual)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Publisher
        {
            get { return PublisherElement != null ? PublisherElement.Value : null; }
            set
            {
                if (value == null)
                    PublisherElement = null;
                else
                    PublisherElement = new FhirString(value);
                OnPropertyChanged("Publisher");
            }
        }

        /// <summary>
        /// Contact details of the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=160)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactComponent> Contact
        {
            get { if (_contact==null) _contact = new List<ContactComponent>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactComponent> _contact;

        /// <summary>
        /// Date for given status
        /// </summary>
        [FhirElement("date", InSummary=true, Order=170)]
        [DataMember]
        public FhirDateTime DateElement
        {
            get { return _dateElement; }
            set { _dateElement = value; OnPropertyChanged("DateElement"); }
        }

        private FhirDateTime _dateElement;

        /// <summary>
        /// Date for given status
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
        /// Human language description of the concept map
        /// </summary>
        [FhirElement("description", InSummary=true, Order=180)]
        [DataMember]
        public FhirString DescriptionElement
        {
            get { return _descriptionElement; }
            set { _descriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }

        private FhirString _descriptionElement;

        /// <summary>
        /// Human language description of the concept map
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                    DescriptionElement = null;
                else
                    DescriptionElement = new FhirString(value);
                OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Content intends to support these contexts
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> UseContext
        {
            get { if (_useContext==null) _useContext = new List<CodeableConcept>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<CodeableConcept> _useContext;

        /// <summary>
        /// Why needed
        /// </summary>
        [FhirElement("requirements", Order=200)]
        [DataMember]
        public FhirString RequirementsElement
        {
            get { return _requirementsElement; }
            set { _requirementsElement = value; OnPropertyChanged("RequirementsElement"); }
        }

        private FhirString _requirementsElement;

        /// <summary>
        /// Why needed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Requirements
        {
            get { return RequirementsElement != null ? RequirementsElement.Value : null; }
            set
            {
                if (value == null)
                    RequirementsElement = null;
                else
                    RequirementsElement = new FhirString(value);
                OnPropertyChanged("Requirements");
            }
        }

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=210)]
        [DataMember]
        public FhirString CopyrightElement
        {
            get { return _copyrightElement; }
            set { _copyrightElement = value; OnPropertyChanged("CopyrightElement"); }
        }

        private FhirString _copyrightElement;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMember]
        public string Copyright
        {
            get { return CopyrightElement != null ? CopyrightElement.Value : null; }
            set
            {
                if (value == null)
                    CopyrightElement = null;
                else
                    CopyrightElement = new FhirString(value);
                OnPropertyChanged("Copyright");
            }
        }

        /// <summary>
        /// Identifies the source of the concepts which are being mapped
        /// </summary>
        [FhirElement("source", InSummary=true, Order=220, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirUri),typeof(ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private Element _source;

        /// <summary>
        /// Provides context to the mappings
        /// </summary>
        [FhirElement("target", InSummary=true, Order=230, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirUri),typeof(ResourceReference))]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Element Target
        {
            get { return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private Element _target;

        /// <summary>
        /// Mappings for a concept from the source set
        /// </summary>
        [FhirElement("element", Order=240)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<SourceElementComponent> Element
        {
            get { if (_element==null) _element = new List<SourceElementComponent>(); return _element; }
            set { _element = value; OnPropertyChanged("Element"); }
        }

        private List<SourceElementComponent> _element;


        public static ElementDefinition.ConstraintComponent ConceptMap_CMD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "element.target.all(comments or ((equivalence != 'narrower') and (equivalence != 'inexact')))",
            Key = "cmd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the map is narrower or inexact, there SHALL be some comments",
            Xpath = "exists(f:comments) or ((f:equivalence/@value != 'narrower') and (f:equivalence/@value != 'inexact'))"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ConceptMap_CMD_1);
        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ConceptMap;

            if (dest != null)
            {
                base.CopyTo(dest);
                if (UrlElement != null) dest.UrlElement = (FhirUri)UrlElement.DeepCopy();
                if (Identifier != null) dest.Identifier = (Identifier)Identifier.DeepCopy();
                if (VersionElement != null) dest.VersionElement = (FhirString)VersionElement.DeepCopy();
                if (NameElement != null) dest.NameElement = (FhirString)NameElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<ConformanceResourceStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactComponent>(Contact.DeepCopy());
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (DescriptionElement != null) dest.DescriptionElement = (FhirString)DescriptionElement.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<CodeableConcept>(UseContext.DeepCopy());
                if (RequirementsElement != null) dest.RequirementsElement = (FhirString)RequirementsElement.DeepCopy();
                if (CopyrightElement != null) dest.CopyrightElement = (FhirString)CopyrightElement.DeepCopy();
                if (Source != null) dest.Source = (Element)Source.DeepCopy();
                if (Target != null) dest.Target = (Element)Target.DeepCopy();
                if (Element != null) dest.Element = new List<SourceElementComponent>(Element.DeepCopy());
                return dest;
            }
            else
                throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        public override IDeepCopyable DeepCopy()
        {
             return CopyTo(new ConceptMap());
        }

        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ConceptMap;
            if (otherT == null) return false;

            if (!base.Matches(otherT)) return false;
            if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.Matches(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.Matches(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.Matches(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.Matches(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if (!DeepComparable.Matches(Target, otherT.Target)) return false;
            if ( !DeepComparable.Matches(Element, otherT.Element)) return false;

            return true;
        }

        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ConceptMap;
            if (otherT == null) return false;

            if (!base.IsExactly(otherT)) return false;
            if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;
            if (!DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if (!DeepComparable.IsExactly(VersionElement, otherT.VersionElement)) return false;
            if (!DeepComparable.IsExactly(NameElement, otherT.NameElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(RequirementsElement, otherT.RequirementsElement)) return false;
            if (!DeepComparable.IsExactly(CopyrightElement, otherT.CopyrightElement)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(Element, otherT.Element)) return false;

            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
                if (UrlElement != null) yield return UrlElement;
                if (Identifier != null) yield return Identifier;
                if (VersionElement != null) yield return VersionElement;
                if (NameElement != null) yield return NameElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (DateElement != null) yield return DateElement;
                if (DescriptionElement != null) yield return DescriptionElement;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                if (RequirementsElement != null) yield return RequirementsElement;
                if (CopyrightElement != null) yield return CopyrightElement;
                if (Source != null) yield return Source;
                if (Target != null) yield return Target;
                foreach (var elem in Element) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                if (Identifier != null) yield return new ElementValue("identifier", Identifier);
                if (VersionElement != null) yield return new ElementValue("version", VersionElement);
                if (NameElement != null) yield return new ElementValue("name", NameElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                if (RequirementsElement != null) yield return new ElementValue("requirements", RequirementsElement);
                if (CopyrightElement != null) yield return new ElementValue("copyright", CopyrightElement);
                if (Source != null) yield return new ElementValue("source", Source);
                if (Target != null) yield return new ElementValue("target", Target);
                foreach (var elem in Element) { if (elem != null) yield return new ElementValue("element", elem); }
            }
        }

    }

}
