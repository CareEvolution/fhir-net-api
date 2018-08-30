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
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("relatedto", "http://hl7.org/fhir/concept-map-equivalence"), Description("Related To")]
            Relatedto,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("equivalent", "http://hl7.org/fhir/concept-map-equivalence"), Description("Equivalent")]
            Equivalent,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("equal", "http://hl7.org/fhir/concept-map-equivalence"), Description("Equal")]
            Equal,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("wider", "http://hl7.org/fhir/concept-map-equivalence"), Description("Wider")]
            Wider,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("subsumes", "http://hl7.org/fhir/concept-map-equivalence"), Description("Subsumes")]
            Subsumes,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("narrower", "http://hl7.org/fhir/concept-map-equivalence"), Description("Narrower")]
            Narrower,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("specializes", "http://hl7.org/fhir/concept-map-equivalence"), Description("Specializes")]
            Specializes,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("inexact", "http://hl7.org/fhir/concept-map-equivalence"), Description("Inexact")]
            Inexact,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("unmatched", "http://hl7.org/fhir/concept-map-equivalence"), Description("Unmatched")]
            Unmatched,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/concept-map-equivalence)
            /// </summary>
            [EnumLiteral("disjoint", "http://hl7.org/fhir/concept-map-equivalence"), Description("Disjoint")]
            Disjoint,
        }

        /// <summary>
        /// Defines which action to take if there is no match in the group.
        /// (url: http://hl7.org/fhir/ValueSet/conceptmap-unmapped-mode)
        /// </summary>
        [FhirEnumeration("ConceptMapGroupUnmappedMode")]
        public enum ConceptMapGroupUnmappedMode
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conceptmap-unmapped-mode)
            /// </summary>
            [EnumLiteral("provided", "http://hl7.org/fhir/conceptmap-unmapped-mode"), Description("Provided Code")]
            Provided,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conceptmap-unmapped-mode)
            /// </summary>
            [EnumLiteral("fixed", "http://hl7.org/fhir/conceptmap-unmapped-mode"), Description("Fixed Code")]
            Fixed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/conceptmap-unmapped-mode)
            /// </summary>
            [EnumLiteral("other-map", "http://hl7.org/fhir/conceptmap-unmapped-mode"), Description("Other Map")]
            OtherMap,
        }


        [FhirType("GroupComponent")]
        [DataContract]
        public partial class GroupComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "GroupComponent"; } }

            /// <summary>
            /// Source system where concepts to be mapped are defined
            /// </summary>
            [FhirElement("source", Order=40)]
            [DataMember]
            public FhirUri SourceElement
            {
                get { return _sourceElement; }
                set { _sourceElement = value; OnPropertyChanged("SourceElement"); }
            }

            private FhirUri _sourceElement;

            /// <summary>
            /// Source system where concepts to be mapped are defined
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Source
            {
                get { return SourceElement != null ? SourceElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceElement = null;
                    else
                        SourceElement = new FhirUri(value);
                    OnPropertyChanged("Source");
                }
            }

            /// <summary>
            /// Specific version of the  code system
            /// </summary>
            [FhirElement("sourceVersion", Order=50)]
            [DataMember]
            public FhirString SourceVersionElement
            {
                get { return _sourceVersionElement; }
                set { _sourceVersionElement = value; OnPropertyChanged("SourceVersionElement"); }
            }

            private FhirString _sourceVersionElement;

            /// <summary>
            /// Specific version of the  code system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string SourceVersion
            {
                get { return SourceVersionElement != null ? SourceVersionElement.Value : null; }
                set
                {
                    if (value == null)
                        SourceVersionElement = null;
                    else
                        SourceVersionElement = new FhirString(value);
                    OnPropertyChanged("SourceVersion");
                }
            }

            /// <summary>
            /// Target system that the concepts are to be mapped to
            /// </summary>
            [FhirElement("target", Order=60)]
            [DataMember]
            public FhirUri TargetElement
            {
                get { return _targetElement; }
                set { _targetElement = value; OnPropertyChanged("TargetElement"); }
            }

            private FhirUri _targetElement;

            /// <summary>
            /// Target system that the concepts are to be mapped to
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Target
            {
                get { return TargetElement != null ? TargetElement.Value : null; }
                set
                {
                    if (value == null)
                        TargetElement = null;
                    else
                        TargetElement = new FhirUri(value);
                    OnPropertyChanged("Target");
                }
            }

            /// <summary>
            /// Specific version of the  code system
            /// </summary>
            [FhirElement("targetVersion", Order=70)]
            [DataMember]
            public FhirString TargetVersionElement
            {
                get { return _targetVersionElement; }
                set { _targetVersionElement = value; OnPropertyChanged("TargetVersionElement"); }
            }

            private FhirString _targetVersionElement;

            /// <summary>
            /// Specific version of the  code system
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string TargetVersion
            {
                get { return TargetVersionElement != null ? TargetVersionElement.Value : null; }
                set
                {
                    if (value == null)
                        TargetVersionElement = null;
                    else
                        TargetVersionElement = new FhirString(value);
                    OnPropertyChanged("TargetVersion");
                }
            }

            /// <summary>
            /// Mappings for a concept from the source set
            /// </summary>
            [FhirElement("element", Order=80)]
            [Cardinality(Min=1,Max=-1)]
            [DataMember]
            public List<SourceElementComponent> Element
            {
                get { if (_element==null) _element = new List<SourceElementComponent>(); return _element; }
                set { _element = value; OnPropertyChanged("Element"); }
            }

            private List<SourceElementComponent> _element;

            /// <summary>
            /// When there is no match for the source concept in the target system, so no mapping is available
            /// </summary>
            [FhirElement("unmapped", Order=90)]
            [DataMember]
            public UnmappedComponent Unmapped
            {
                get { return _unmapped; }
                set { _unmapped = value; OnPropertyChanged("Unmapped"); }
            }

            private UnmappedComponent _unmapped;

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as GroupComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (SourceElement != null) dest.SourceElement = (FhirUri)SourceElement.DeepCopy();
                    if (SourceVersionElement != null) dest.SourceVersionElement = (FhirString)SourceVersionElement.DeepCopy();
                    if (TargetElement != null) dest.TargetElement = (FhirUri)TargetElement.DeepCopy();
                    if (TargetVersionElement != null) dest.TargetVersionElement = (FhirString)TargetVersionElement.DeepCopy();
                    if (Element != null) dest.Element = new List<SourceElementComponent>(Element.DeepCopy());
                    if (Unmapped != null) dest.Unmapped = (UnmappedComponent)Unmapped.DeepCopy();
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
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.Matches(SourceVersionElement, otherT.SourceVersionElement)) return false;
                if (!DeepComparable.Matches(TargetElement, otherT.TargetElement)) return false;
                if (!DeepComparable.Matches(TargetVersionElement, otherT.TargetVersionElement)) return false;
                if ( !DeepComparable.Matches(Element, otherT.Element)) return false;
                if (!DeepComparable.Matches(Unmapped, otherT.Unmapped)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as GroupComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(SourceElement, otherT.SourceElement)) return false;
                if (!DeepComparable.IsExactly(SourceVersionElement, otherT.SourceVersionElement)) return false;
                if (!DeepComparable.IsExactly(TargetElement, otherT.TargetElement)) return false;
                if (!DeepComparable.IsExactly(TargetVersionElement, otherT.TargetVersionElement)) return false;
                if (!DeepComparable.IsExactly(Element, otherT.Element)) return false;
                if (!DeepComparable.IsExactly(Unmapped, otherT.Unmapped)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (SourceElement != null) yield return SourceElement;
                    if (SourceVersionElement != null) yield return SourceVersionElement;
                    if (TargetElement != null) yield return TargetElement;
                    if (TargetVersionElement != null) yield return TargetVersionElement;
                    foreach (var elem in Element) { if (elem != null) yield return elem; }
                    if (Unmapped != null) yield return Unmapped;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (SourceElement != null) yield return new ElementValue("source", SourceElement);
                    if (SourceVersionElement != null) yield return new ElementValue("sourceVersion", SourceVersionElement);
                    if (TargetElement != null) yield return new ElementValue("target", TargetElement);
                    if (TargetVersionElement != null) yield return new ElementValue("targetVersion", TargetVersionElement);
                    foreach (var elem in Element) { if (elem != null) yield return new ElementValue("element", elem); }
                    if (Unmapped != null) yield return new ElementValue("unmapped", Unmapped);
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
            /// Identifies element being mapped
            /// </summary>
            [FhirElement("code", Order=40)]
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
            /// Display for the code
            /// </summary>
            [FhirElement("display", Order=50)]
            [DataMember]
            public FhirString DisplayElement
            {
                get { return _displayElement; }
                set { _displayElement = value; OnPropertyChanged("DisplayElement"); }
            }

            private FhirString _displayElement;

            /// <summary>
            /// Display for the code
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if (value == null)
                        DisplayElement = null;
                    else
                        DisplayElement = new FhirString(value);
                    OnPropertyChanged("Display");
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
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
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
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;
                if ( !DeepComparable.Matches(Target, otherT.Target)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SourceElementComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;
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
                    if (DisplayElement != null) yield return DisplayElement;
                    foreach (var elem in Target) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
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
            /// Code that identifies the target element
            /// </summary>
            [FhirElement("code", Order=40)]
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
            /// Display for the code
            /// </summary>
            [FhirElement("display", Order=50)]
            [DataMember]
            public FhirString DisplayElement
            {
                get { return _displayElement; }
                set { _displayElement = value; OnPropertyChanged("DisplayElement"); }
            }

            private FhirString _displayElement;

            /// <summary>
            /// Display for the code
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if (value == null)
                        DisplayElement = null;
                    else
                        DisplayElement = new FhirString(value);
                    OnPropertyChanged("Display");
                }
            }

            /// <summary>
            /// relatedto | equivalent | equal | wider | subsumes | narrower | specializes | inexact | unmatched | disjoint
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
            /// relatedto | equivalent | equal | wider | subsumes | narrower | specializes | inexact | unmatched | disjoint
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
            [FhirElement("comment", Order=70)]
            [DataMember]
            public FhirString CommentElement
            {
                get { return _commentElement; }
                set { _commentElement = value; OnPropertyChanged("CommentElement"); }
            }

            private FhirString _commentElement;

            /// <summary>
            /// Description of status/issues in mapping
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
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
                    if (EquivalenceElement != null) dest.EquivalenceElement = (Code<ConceptMapEquivalence>)EquivalenceElement.DeepCopy();
                    if (CommentElement != null) dest.CommentElement = (FhirString)CommentElement.DeepCopy();
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
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;
                if (!DeepComparable.Matches(EquivalenceElement, otherT.EquivalenceElement)) return false;
                if (!DeepComparable.Matches(CommentElement, otherT.CommentElement)) return false;
                if ( !DeepComparable.Matches(DependsOn, otherT.DependsOn)) return false;
                if ( !DeepComparable.Matches(Product, otherT.Product)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as TargetElementComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;
                if (!DeepComparable.IsExactly(EquivalenceElement, otherT.EquivalenceElement)) return false;
                if (!DeepComparable.IsExactly(CommentElement, otherT.CommentElement)) return false;
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
                    if (CodeElement != null) yield return CodeElement;
                    if (DisplayElement != null) yield return DisplayElement;
                    if (EquivalenceElement != null) yield return EquivalenceElement;
                    if (CommentElement != null) yield return CommentElement;
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
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
                    if (EquivalenceElement != null) yield return new ElementValue("equivalence", EquivalenceElement);
                    if (CommentElement != null) yield return new ElementValue("comment", CommentElement);
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
            /// Reference to property mapping depends on
            /// </summary>
            [FhirElement("property", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirUri PropertyElement
            {
                get { return _propertyElement; }
                set { _propertyElement = value; OnPropertyChanged("PropertyElement"); }
            }

            private FhirUri _propertyElement;

            /// <summary>
            /// Reference to property mapping depends on
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Property
            {
                get { return PropertyElement != null ? PropertyElement.Value : null; }
                set
                {
                    if (value == null)
                        PropertyElement = null;
                    else
                        PropertyElement = new FhirUri(value);
                    OnPropertyChanged("Property");
                }
            }

            /// <summary>
            /// Code System (if necessary)
            /// </summary>
            [FhirElement("system", Order=50)]
            [DataMember]
            public Canonical SystemElement
            {
                get { return _systemElement; }
                set { _systemElement = value; OnPropertyChanged("SystemElement"); }
            }

            private Canonical _systemElement;

            /// <summary>
            /// Code System (if necessary)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string System
            {
                get { return SystemElement != null ? SystemElement.Value : null; }
                set
                {
                    if (value == null)
                        SystemElement = null;
                    else
                        SystemElement = new Canonical(value);
                    OnPropertyChanged("System");
                }
            }

            /// <summary>
            /// Value of the referenced element
            /// </summary>
            [FhirElement("value", Order=60)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public FhirString ValueElement
            {
                get { return _valueElement; }
                set { _valueElement = value; OnPropertyChanged("ValueElement"); }
            }

            private FhirString _valueElement;

            /// <summary>
            /// Value of the referenced element
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Value
            {
                get { return ValueElement != null ? ValueElement.Value : null; }
                set
                {
                    if (value == null)
                        ValueElement = null;
                    else
                        ValueElement = new FhirString(value);
                    OnPropertyChanged("Value");
                }
            }

            /// <summary>
            /// Display for the code (if value is a code)
            /// </summary>
            [FhirElement("display", Order=70)]
            [DataMember]
            public FhirString DisplayElement
            {
                get { return _displayElement; }
                set { _displayElement = value; OnPropertyChanged("DisplayElement"); }
            }

            private FhirString _displayElement;

            /// <summary>
            /// Display for the code (if value is a code)
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if (value == null)
                        DisplayElement = null;
                    else
                        DisplayElement = new FhirString(value);
                    OnPropertyChanged("Display");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as OtherElementComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (PropertyElement != null) dest.PropertyElement = (FhirUri)PropertyElement.DeepCopy();
                    if (SystemElement != null) dest.SystemElement = (Canonical)SystemElement.DeepCopy();
                    if (ValueElement != null) dest.ValueElement = (FhirString)ValueElement.DeepCopy();
                    if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
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
                if (!DeepComparable.Matches(PropertyElement, otherT.PropertyElement)) return false;
                if (!DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
                if (!DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as OtherElementComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(PropertyElement, otherT.PropertyElement)) return false;
                if (!DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
                if (!DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
                if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (PropertyElement != null) yield return PropertyElement;
                    if (SystemElement != null) yield return SystemElement;
                    if (ValueElement != null) yield return ValueElement;
                    if (DisplayElement != null) yield return DisplayElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (PropertyElement != null) yield return new ElementValue("property", PropertyElement);
                    if (SystemElement != null) yield return new ElementValue("system", SystemElement);
                    if (ValueElement != null) yield return new ElementValue("value", ValueElement);
                    if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
                }
            }


        }


        [FhirType("UnmappedComponent")]
        [DataContract]
        public partial class UnmappedComponent : BackboneElement, IBackboneElement
        {
            [NotMapped]
            public override string TypeName { get { return "UnmappedComponent"; } }

            /// <summary>
            /// provided | fixed | other-map
            /// </summary>
            [FhirElement("mode", Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<ConceptMapGroupUnmappedMode> ModeElement
            {
                get { return _modeElement; }
                set { _modeElement = value; OnPropertyChanged("ModeElement"); }
            }

            private Code<ConceptMapGroupUnmappedMode> _modeElement;

            /// <summary>
            /// provided | fixed | other-map
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public ConceptMapGroupUnmappedMode? Mode
            {
                get { return ModeElement != null ? ModeElement.Value : null; }
                set
                {
                    if (value == null)
                        ModeElement = null;
                    else
                        ModeElement = new Code<ConceptMapGroupUnmappedMode>(value);
                    OnPropertyChanged("Mode");
                }
            }

            /// <summary>
            /// Fixed code when mode = fixed
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
            /// Fixed code when mode = fixed
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
            /// Display for the code
            /// </summary>
            [FhirElement("display", Order=60)]
            [DataMember]
            public FhirString DisplayElement
            {
                get { return _displayElement; }
                set { _displayElement = value; OnPropertyChanged("DisplayElement"); }
            }

            private FhirString _displayElement;

            /// <summary>
            /// Display for the code
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMember]
            public string Display
            {
                get { return DisplayElement != null ? DisplayElement.Value : null; }
                set
                {
                    if (value == null)
                        DisplayElement = null;
                    else
                        DisplayElement = new FhirString(value);
                    OnPropertyChanged("Display");
                }
            }

            /// <summary>
            /// Canonical URI for an additional ConceptMap to use for mapping if the source concept is unmapped
            /// </summary>
            [FhirElement("url", Order=70)]
            [DataMember]
            public Canonical UrlElement
            {
                get { return _urlElement; }
                set { _urlElement = value; OnPropertyChanged("UrlElement"); }
            }

            private Canonical _urlElement;

            /// <summary>
            /// Canonical URI for an additional ConceptMap to use for mapping if the source concept is unmapped
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
                        UrlElement = new Canonical(value);
                    OnPropertyChanged("Url");
                }
            }

            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as UnmappedComponent;

                if (dest != null)
                {
                    base.CopyTo(dest);
                    if (ModeElement != null) dest.ModeElement = (Code<ConceptMapGroupUnmappedMode>)ModeElement.DeepCopy();
                    if (CodeElement != null) dest.CodeElement = (Code)CodeElement.DeepCopy();
                    if (DisplayElement != null) dest.DisplayElement = (FhirString)DisplayElement.DeepCopy();
                    if (UrlElement != null) dest.UrlElement = (Canonical)UrlElement.DeepCopy();
                    return dest;
                }
                else
                    throw new ArgumentException("Can only copy to an object of the same type", "other");
            }

            public override IDeepCopyable DeepCopy()
            {
                 return CopyTo(new UnmappedComponent());
            }

            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as UnmappedComponent;
                if (otherT == null) return false;

                if (!base.Matches(otherT)) return false;
                if (!DeepComparable.Matches(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.Matches(DisplayElement, otherT.DisplayElement)) return false;
                if (!DeepComparable.Matches(UrlElement, otherT.UrlElement)) return false;

                return true;
            }

            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as UnmappedComponent;
                if (otherT == null) return false;

                if (!base.IsExactly(otherT)) return false;
                if (!DeepComparable.IsExactly(ModeElement, otherT.ModeElement)) return false;
                if (!DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if (!DeepComparable.IsExactly(DisplayElement, otherT.DisplayElement)) return false;
                if (!DeepComparable.IsExactly(UrlElement, otherT.UrlElement)) return false;

                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (ModeElement != null) yield return ModeElement;
                    if (CodeElement != null) yield return CodeElement;
                    if (DisplayElement != null) yield return DisplayElement;
                    if (UrlElement != null) yield return UrlElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (ModeElement != null) yield return new ElementValue("mode", ModeElement);
                    if (CodeElement != null) yield return new ElementValue("code", CodeElement);
                    if (DisplayElement != null) yield return new ElementValue("display", DisplayElement);
                    if (UrlElement != null) yield return new ElementValue("url", UrlElement);
                }
            }


        }


        /// <summary>
        /// Canonical identifier for this concept map, represented as a URI (globally unique)
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
        /// Canonical identifier for this concept map, represented as a URI (globally unique)
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
        /// Business version of the concept map
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
        /// Business version of the concept map
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
        /// Name for this concept map (computer friendly)
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
        /// Name for this concept map (computer friendly)
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
        /// Name for this concept map (human friendly)
        /// </summary>
        [FhirElement("title", InSummary=true, Order=130)]
        [DataMember]
        public FhirString TitleElement
        {
            get { return _titleElement; }
            set { _titleElement = value; OnPropertyChanged("TitleElement"); }
        }

        private FhirString _titleElement;

        /// <summary>
        /// Name for this concept map (human friendly)
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
        /// draft | active | retired | unknown
        /// </summary>
        [FhirElement("status", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=1)]
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
        /// For testing purposes, not real usage
        /// </summary>
        [FhirElement("experimental", InSummary=true, Order=150)]
        [DataMember]
        public FhirBoolean ExperimentalElement
        {
            get { return _experimentalElement; }
            set { _experimentalElement = value; OnPropertyChanged("ExperimentalElement"); }
        }

        private FhirBoolean _experimentalElement;

        /// <summary>
        /// For testing purposes, not real usage
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
        /// Date last changed
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
        /// Date last changed
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
        /// Name of the publisher (organization or individual)
        /// </summary>
        [FhirElement("publisher", InSummary=true, Order=170)]
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
        /// Contact details for the publisher
        /// </summary>
        [FhirElement("contact", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<ContactDetail> Contact
        {
            get { if (_contact==null) _contact = new List<ContactDetail>(); return _contact; }
            set { _contact = value; OnPropertyChanged("Contact"); }
        }

        private List<ContactDetail> _contact;

        /// <summary>
        /// Natural language description of the concept map
        /// </summary>
        [FhirElement("description", Order=190)]
        [DataMember]
        public Markdown Description
        {
            get { return _description; }
            set { _description = value; OnPropertyChanged("Description"); }
        }

        private Markdown _description;

        /// <summary>
        /// The context that the content is intended to support
        /// </summary>
        [FhirElement("useContext", InSummary=true, Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<UsageContext> UseContext
        {
            get { if (_useContext==null) _useContext = new List<UsageContext>(); return _useContext; }
            set { _useContext = value; OnPropertyChanged("UseContext"); }
        }

        private List<UsageContext> _useContext;

        /// <summary>
        /// Intended jurisdiction for concept map (if applicable)
        /// </summary>
        [FhirElement("jurisdiction", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<CodeableConcept> Jurisdiction
        {
            get { if (_jurisdiction==null) _jurisdiction = new List<CodeableConcept>(); return _jurisdiction; }
            set { _jurisdiction = value; OnPropertyChanged("Jurisdiction"); }
        }

        private List<CodeableConcept> _jurisdiction;

        /// <summary>
        /// Why this concept map is defined
        /// </summary>
        [FhirElement("purpose", Order=220)]
        [DataMember]
        public Markdown Purpose
        {
            get { return _purpose; }
            set { _purpose = value; OnPropertyChanged("Purpose"); }
        }

        private Markdown _purpose;

        /// <summary>
        /// Use and/or publishing restrictions
        /// </summary>
        [FhirElement("copyright", Order=230)]
        [DataMember]
        public Markdown Copyright
        {
            get { return _copyright; }
            set { _copyright = value; OnPropertyChanged("Copyright"); }
        }

        private Markdown _copyright;

        /// <summary>
        /// The source value set that contains the concepts that are being mapped
        /// </summary>
        [FhirElement("source", InSummary=true, Order=240, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirUri),typeof(Canonical))]
        [DataMember]
        public Element Source
        {
            get { return _source; }
            set { _source = value; OnPropertyChanged("Source"); }
        }

        private Element _source;

        /// <summary>
        /// The target value set which provides context for the mappings
        /// </summary>
        [FhirElement("target", InSummary=true, Order=250, Choice=ChoiceType.DatatypeChoice)]
        [AllowedTypes(typeof(FhirUri),typeof(Canonical))]
        [DataMember]
        public Element Target
        {
            get { return _target; }
            set { _target = value; OnPropertyChanged("Target"); }
        }

        private Element _target;

        /// <summary>
        /// Same source and target systems
        /// </summary>
        [FhirElement("group", Order=260)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<GroupComponent> Group
        {
            get { if (_group==null) _group = new List<GroupComponent>(); return _group; }
            set { _group = value; OnPropertyChanged("Group"); }
        }

        private List<GroupComponent> _group;


        public static ElementDefinition.ConstraintComponent ConceptMap_CMD_1 = new ElementDefinition.ConstraintComponent
        {
            Expression = "group.element.target.all(comment.exists() or equivalence.empty() or ((equivalence != 'narrower') and (equivalence != 'inexact')))",
            Key = "cmd-1",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the map is narrower or inexact, there SHALL be some comments",
            Xpath = "exists(f:comment) or not(exists(f:equivalence)) or ((f:equivalence/@value != 'narrower') and (f:equivalence/@value != 'inexact'))"
        };

        public static ElementDefinition.ConstraintComponent ConceptMap_CMD_3 = new ElementDefinition.ConstraintComponent
        {
            Expression = "group.unmapped.all((mode = 'other-map') implies url.exists())",
            Key = "cmd-3",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the mode is 'other-map', a url must be provided",
            Xpath = "(f:mode/@value != 'other-map') or exists(f:url)"
        };

        public static ElementDefinition.ConstraintComponent ConceptMap_CMD_2 = new ElementDefinition.ConstraintComponent
        {
            Expression = "group.unmapped.all((mode = 'fixed') implies code.exists())",
            Key = "cmd-2",
            Severity = ElementDefinition.ConstraintSeverity.Warning,
            Human = "If the mode is 'fixed', a code must be provided",
            Xpath = "(f:mode/@value != 'fixed') or exists(f:code)"
        };

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

            InvariantConstraints.Add(ConceptMap_CMD_1);
            InvariantConstraints.Add(ConceptMap_CMD_3);
            InvariantConstraints.Add(ConceptMap_CMD_2);
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
                if (TitleElement != null) dest.TitleElement = (FhirString)TitleElement.DeepCopy();
                if (StatusElement != null) dest.StatusElement = (Code<PublicationStatus>)StatusElement.DeepCopy();
                if (ExperimentalElement != null) dest.ExperimentalElement = (FhirBoolean)ExperimentalElement.DeepCopy();
                if (DateElement != null) dest.DateElement = (FhirDateTime)DateElement.DeepCopy();
                if (PublisherElement != null) dest.PublisherElement = (FhirString)PublisherElement.DeepCopy();
                if (Contact != null) dest.Contact = new List<ContactDetail>(Contact.DeepCopy());
                if (Description != null) dest.Description = (Markdown)Description.DeepCopy();
                if (UseContext != null) dest.UseContext = new List<UsageContext>(UseContext.DeepCopy());
                if (Jurisdiction != null) dest.Jurisdiction = new List<CodeableConcept>(Jurisdiction.DeepCopy());
                if (Purpose != null) dest.Purpose = (Markdown)Purpose.DeepCopy();
                if (Copyright != null) dest.Copyright = (Markdown)Copyright.DeepCopy();
                if (Source != null) dest.Source = (Element)Source.DeepCopy();
                if (Target != null) dest.Target = (Element)Target.DeepCopy();
                if (Group != null) dest.Group = new List<GroupComponent>(Group.DeepCopy());
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
            if (!DeepComparable.Matches(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.Matches(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.Matches(PublisherElement, otherT.PublisherElement)) return false;
            if ( !DeepComparable.Matches(Contact, otherT.Contact)) return false;
            if (!DeepComparable.Matches(Description, otherT.Description)) return false;
            if ( !DeepComparable.Matches(UseContext, otherT.UseContext)) return false;
            if ( !DeepComparable.Matches(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.Matches(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.Matches(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.Matches(Source, otherT.Source)) return false;
            if (!DeepComparable.Matches(Target, otherT.Target)) return false;
            if ( !DeepComparable.Matches(Group, otherT.Group)) return false;

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
            if (!DeepComparable.IsExactly(TitleElement, otherT.TitleElement)) return false;
            if (!DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if (!DeepComparable.IsExactly(ExperimentalElement, otherT.ExperimentalElement)) return false;
            if (!DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if (!DeepComparable.IsExactly(PublisherElement, otherT.PublisherElement)) return false;
            if (!DeepComparable.IsExactly(Contact, otherT.Contact)) return false;
            if (!DeepComparable.IsExactly(Description, otherT.Description)) return false;
            if (!DeepComparable.IsExactly(UseContext, otherT.UseContext)) return false;
            if (!DeepComparable.IsExactly(Jurisdiction, otherT.Jurisdiction)) return false;
            if (!DeepComparable.IsExactly(Purpose, otherT.Purpose)) return false;
            if (!DeepComparable.IsExactly(Copyright, otherT.Copyright)) return false;
            if (!DeepComparable.IsExactly(Source, otherT.Source)) return false;
            if (!DeepComparable.IsExactly(Target, otherT.Target)) return false;
            if (!DeepComparable.IsExactly(Group, otherT.Group)) return false;

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
                if (TitleElement != null) yield return TitleElement;
                if (StatusElement != null) yield return StatusElement;
                if (ExperimentalElement != null) yield return ExperimentalElement;
                if (DateElement != null) yield return DateElement;
                if (PublisherElement != null) yield return PublisherElement;
                foreach (var elem in Contact) { if (elem != null) yield return elem; }
                if (Description != null) yield return Description;
                foreach (var elem in UseContext) { if (elem != null) yield return elem; }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return elem; }
                if (Purpose != null) yield return Purpose;
                if (Copyright != null) yield return Copyright;
                if (Source != null) yield return Source;
                if (Target != null) yield return Target;
                foreach (var elem in Group) { if (elem != null) yield return elem; }
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
                if (TitleElement != null) yield return new ElementValue("title", TitleElement);
                if (StatusElement != null) yield return new ElementValue("status", StatusElement);
                if (ExperimentalElement != null) yield return new ElementValue("experimental", ExperimentalElement);
                if (DateElement != null) yield return new ElementValue("date", DateElement);
                if (PublisherElement != null) yield return new ElementValue("publisher", PublisherElement);
                foreach (var elem in Contact) { if (elem != null) yield return new ElementValue("contact", elem); }
                if (Description != null) yield return new ElementValue("description", Description);
                foreach (var elem in UseContext) { if (elem != null) yield return new ElementValue("useContext", elem); }
                foreach (var elem in Jurisdiction) { if (elem != null) yield return new ElementValue("jurisdiction", elem); }
                if (Purpose != null) yield return new ElementValue("purpose", Purpose);
                if (Copyright != null) yield return new ElementValue("copyright", Copyright);
                if (Source != null) yield return new ElementValue("source", Source);
                if (Target != null) yield return new ElementValue("target", Target);
                foreach (var elem in Group) { if (elem != null) yield return new ElementValue("group", elem); }
            }
        }

    }

}
